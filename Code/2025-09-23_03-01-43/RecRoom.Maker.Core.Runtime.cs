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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x855C7B0", Offset = "0x855ADB0", VA = "0x18855C7B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
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
		[Cpp2IlInjected.Address(RVA = "0x855D1D0", Offset = "0x855B7D0", VA = "0x18855D1D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OHALKKDPAJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ShowFreeInventionsInR2PaletteSearch
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EDPLOMLJADJ
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
public interface ABLJEEFALLD<TData, TReturn>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TReturn DDCCHNEANJH(TData MPIDDJPOOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PJPBGKHKJHB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(PMAGAGOBJMK EMFDOBHEOON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData AMMKGILEHBG, Collider CCJNMHOFBOH, PMAGAGOBJMK EMFDOBHEOON, [Optional] POFMKFJLMNC? KDACJAFAAHH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget([Out] TData AMMKGILEHBG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetHoverCollider([Out] Collider CCJNMHOFBOH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HPMDAEKPFPB<TData> : EOGMPDGGBLN, MPLGDBIPHBC<TData>, IHCLIHDJJKG<TData>, JJLNHGNHEAN<TData>, MLNFGOEFDDG, GOPCMAKFAOI<TData>, AGMIBECLHCE, PMBFLGKAEDO
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GOPCMAKFAOI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 BKLMKFANNGB, Vector3 JPDMHOCEDGB, float AHKHODDOFPB, [Out] T FHGABIOLCKJ, [Out] Vector3 MJFKEJKNNIM, [Out] Collider CCJNMHOFBOH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 BKLMKFANNGB, Vector3 JPDMHOCEDGB, float PFGNOELOPPA, float AHKHODDOFPB, T[] HFCMGALHEMO, [Out] Vector3 DJLIBHJFJNH, [Out] Collider IAHCOPHHNIF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 BKLMKFANNGB, float PFGNOELOPPA, Vector3 LDDAJGHGAAF, T[] HFCMGALHEMO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool TryGetObjectFromColliderInCurrentScope(Collider JKLOHCLNDDL, [Out] T CDMKMGMAHAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EOGMPDGGBLN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds CGECMCLHDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NNNPCDGEPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CLOLKKPOIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform LNKIMNFOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 JPAGOKEEIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ABFMNMNNAPD
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
	void SetSelectionBoundsDirty(bool EIHDOJKOCJN = true, int OIMCDEBJJAO = 0);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ShouldHideSelectionBoundsPreview(bool MIJEDDBGGPK, object INEEADCBMPK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PMBFLGKAEDO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HLLOFHFLNHG NANFPMCFAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BCEPCPKGGOE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KEKKFAEGCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OEFFOAHMHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BIBFKCIFPNB
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
	void TrySetPreviousCloneMapping(Dictionary<Guid, Guid> JHNEMJBBOCM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JJLNHGNHEAN<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool GFOMCLAGMFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	int KONCICBNMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<TData> NIGCEDGLBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData NANHMPOBBLI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MPLGDBIPHBC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T MPIDDJPOOMJ, [Optional] POFMKFJLMNC? BNPFBJAOLKG, bool BOFMFOLELIJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int LMJBLNOIBOL, IEnumerable<T> ADHFKKAKOCE, bool BOFMFOLELIJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int LMJBLNOIBOL, IEnumerable<T> ADHFKKAKOCE, POFMKFJLMNC BNPFBJAOLKG, bool BOFMFOLELIJ = true);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AGMIBECLHCE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MLNFGOEFDDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool LNNLMIJPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HNBOHIOCICC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NEMALPBKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BJNHHGNNOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CLFPBCEENKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool LIFKKAMGAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float? PGGKCIJGCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public float? LHALCAGONLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float? AGDPKAPAJEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LKCPNNJFPGE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public CLFPBCEENKJ IMIPIFBNPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57D0220", Offset = "0x57CE820", VA = "0x1857D0220")]
	public LKCPNNJFPGE(IEnumerable<TData> OAOCMEKPNDE, bool MCHJPCMMKHO, float? DPOHEHDFABP, float? ICKFEKPLGLA, float? HNJODIHBOOK, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GLEABNELFNP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] LKCPNNJFPGE<TData> PNGANGECEEL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FJJCBHCNFIG<TData> : LPNAIPJHOGL<GLEABNELFNP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LKCPNNJFPGE<TData> PNGANGECEEL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x501E8B0", Offset = "0x501CEB0", VA = "0x18501E8B0")]
	public FJJCBHCNFIG(IEnumerable<TData> OAOCMEKPNDE, bool MCHJPCMMKHO, float? DPOHEHDFABP, float? ICKFEKPLGLA, float? HNJODIHBOOK, bool FKBDHGIJJGJ, GLEABNELFNP<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NMELENIHGJF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public string ENCLKBKENGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool LCMFDPLMDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5A8F000", Offset = "0x5A8D600", VA = "0x185A8F000")]
	public NMELENIHGJF(IEnumerable<TData> OAOCMEKPNDE, string IPHPNMCAICN, bool DFGGNOENJAK, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HHDGPGPIPFM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] NMELENIHGJF<TData> PNGANGECEEL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class COEKPEFFJIB<TData> : LPNAIPJHOGL<HHDGPGPIPFM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NMELENIHGJF<TData> PNGANGECEEL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7033570", Offset = "0x7031B70", VA = "0x187033570")]
	public COEKPEFFJIB(IEnumerable<TData> OAOCMEKPNDE, string IPHPNMCAICN, bool DFGGNOENJAK, bool FKBDHGIJJGJ, HHDGPGPIPFM<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class LPNAIPJHOGL<TReceiver> : FGGBABBPBKE<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public LPNAIPJHOGL(TReceiver BOBOBLMDHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EFPCNFKDJBE<TReceiver, TFromTask> : FGGBABBPBKE<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public EFPCNFKDJBE(TReceiver BOBOBLMDHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FGGBABBPBKE<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected TReceiver BOBOBLMDHCP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FFAFC0", Offset = "0x4FF95C0", VA = "0x184FFAFC0")]
	public FGGBABBPBKE(TReceiver BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute ALBBNBAFAAF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class BDBOOJFNIEJ<TReceiver, TResult> : FGGBABBPBKE<TReceiver, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public BDBOOJFNIEJ(TReceiver BOBOBLMDHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JDCGDHDKAEP<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public TGroup KDMJGLOEFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public TData AGIPLNMOFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E8BD00", Offset = "0x1E8A300", VA = "0x181E8BD00")]
	public JDCGDHDKAEP(TGroup ACKJOLADGIO, TData LJBBCLHAECG, IEnumerable<TData> OAOCMEKPNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HKDFIIKDGGL<TGroup, TData> where TGroup : notnull where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public TGroup KDMJGLOEFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	public HKDFIIKDGGL(TGroup ACKJOLADGIO, IEnumerable<TData> OAOCMEKPNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ANKBOMICHMA<TGroup> where TGroup : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public TGroup KDMJGLOEFMA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
	public ANKBOMICHMA(TGroup ACKJOLADGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CKLIIDEMIPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEnumerable<Guid> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Guid JCEAGBJDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x855B1E0", Offset = "0x85597E0", VA = "0x18855B1E0")]
	public CKLIIDEMIPC(IEnumerable<Guid> OAOCMEKPNDE, Guid DGNKBKBGPJD, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PKHKOFEHDIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Guid JCEAGBJDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x299C3B0", Offset = "0x299A9B0", VA = "0x18299C3B0")]
	public PKHKOFEHDIE(Guid DGNKBKBGPJD, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NLEKOOGIJHA<TGroup, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBDDAJBHKHI GFDBCINLHOE(JDCGDHDKAEP<TGroup, TData> OFOFGKIIIBD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBDDAJBHKHI ODOHCIMOEPF(JDCGDHDKAEP<TGroup, TData> OFOFGKIIIBD);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OBDDAJBHKHI GLLJCDBCPIN(HKDFIIKDGGL<TGroup, TData> OFOFGKIIIBD);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBDDAJBHKHI LIBGKBMJEJJ(ANKBOMICHMA<TGroup> OFOFGKIIIBD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OLPOHMLJJEP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBDDAJBHKHI> GFDBCINLHOE(CKLIIDEMIPC OFOFGKIIIBD);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OBDDAJBHKHI> ODOHCIMOEPF(PKHKOFEHDIE OFOFGKIIIBD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BAEAACLGMOI<TGroup, TData> : BDBOOJFNIEJ<NLEKOOGIJHA<TGroup, TData>, OBDDAJBHKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HKDFIIKDGGL<TGroup, TData> OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A02C50", Offset = "0x6A01250", VA = "0x186A02C50")]
	public BAEAACLGMOI(TGroup ACKJOLADGIO, IEnumerable<TData> OAOCMEKPNDE, NLEKOOGIJHA<TGroup, TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A02B80", Offset = "0x6A01180", VA = "0x186A02B80", Slot = "4")]
	public override OBDDAJBHKHI ALBBNBAFAAF()
	{
		return default(OBDDAJBHKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GNAFGICDOFF<TGroup, TData> : BDBOOJFNIEJ<NLEKOOGIJHA<TGroup, TData>, OBDDAJBHKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JDCGDHDKAEP<TGroup, TData> OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F980", Offset = "0x4B5DF80", VA = "0x184B5F980")]
	public GNAFGICDOFF(TGroup ACKJOLADGIO, TData KKOKKIHNBDP, IEnumerable<TData> OAOCMEKPNDE, NLEKOOGIJHA<TGroup, TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x50FDF00", Offset = "0x50FC500", VA = "0x1850FDF00", Slot = "4")]
	public override OBDDAJBHKHI ALBBNBAFAAF()
	{
		return default(OBDDAJBHKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ILMPAHHADNM<TGroup, TData> : BDBOOJFNIEJ<NLEKOOGIJHA<TGroup, TData>, OBDDAJBHKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ANKBOMICHMA<TGroup> OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4B47C90", Offset = "0x4B46290", VA = "0x184B47C90")]
	public ILMPAHHADNM(TGroup ACKJOLADGIO, NLEKOOGIJHA<TGroup, TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x529D190", Offset = "0x529B790", VA = "0x18529D190", Slot = "4")]
	public override OBDDAJBHKHI ALBBNBAFAAF()
	{
		return default(OBDDAJBHKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EKLMMCAHFFC<TGroup, TData> : BDBOOJFNIEJ<NLEKOOGIJHA<TGroup, TData>, OBDDAJBHKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JDCGDHDKAEP<TGroup, TData> OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F980", Offset = "0x4B5DF80", VA = "0x184B5F980")]
	public EKLMMCAHFFC(TGroup ACKJOLADGIO, TData LJBBCLHAECG, IEnumerable<TData> OAOCMEKPNDE, NLEKOOGIJHA<TGroup, TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F8A0", Offset = "0x4B5DEA0", VA = "0x184B5F8A0", Slot = "4")]
	public override OBDDAJBHKHI ALBBNBAFAAF()
	{
		return default(OBDDAJBHKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MGDIHLKHGHB : EFPCNFKDJBE<OLPOHMLJJEP, OBDDAJBHKHI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct MMENIBBDIJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OBDDAJBHKHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public MGDIHLKHGHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OBDDAJBHKHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x855C4A0", Offset = "0x855AAA0", VA = "0x18855C4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x855C740", Offset = "0x855AD40", VA = "0x18855C740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CKLIIDEMIPC OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x855C3D0", Offset = "0x855A9D0", VA = "0x18855C3D0")]
	public MGDIHLKHGHB(IEnumerable<Guid> NPNDAGGLEEM, Guid DGNKBKBGPJD, bool FKBDHGIJJGJ, OLPOHMLJJEP BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x855C2E0", Offset = "0x855A8E0", VA = "0x18855C2E0", Slot = "4")]
	[AsyncStateMachine(typeof(MMENIBBDIJF))]
	public override Task<OBDDAJBHKHI> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FKEKBNIPOBM : EFPCNFKDJBE<OLPOHMLJJEP, OBDDAJBHKHI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct JFMPKFHDPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OBDDAJBHKHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public FKEKBNIPOBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<OBDDAJBHKHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x855BC70", Offset = "0x855A270", VA = "0x18855BC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x855BF10", Offset = "0x855A510", VA = "0x18855BF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PKHKOFEHDIE OFOFGKIIIBD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x855BA00", Offset = "0x855A000", VA = "0x18855BA00")]
	public FKEKBNIPOBM(Guid DGNKBKBGPJD, bool FKBDHGIJJGJ, OLPOHMLJJEP BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x855B910", Offset = "0x8559F10", VA = "0x18855B910", Slot = "4")]
	[AsyncStateMachine(typeof(JFMPKFHDPPG))]
	public override Task<OBDDAJBHKHI> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct CCGLEIFGOJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly PPJJLGCDLDI EOHDEIHHAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x855B1C0", Offset = "0x85597C0", VA = "0x18855B1C0")]
	public CCGLEIFGOJD(PPJJLGCDLDI FCINLKDGOAB, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BDMHIIFOMPN<TSpawnType> where TSpawnType : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> ALBBNBAFAAF(CCGLEIFGOJD GDBDHGLPAGL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BGNLHBADPNE<TSpawnType> : EFPCNFKDJBE<BDMHIIFOMPN<TSpawnType>, TSpawnType> where TSpawnType : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct LOILIADOFIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TSpawnType> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public BGNLHBADPNE<TSpawnType> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<TSpawnType> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57EC7A0", Offset = "0x57EADA0", VA = "0x1857EC7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4B54320", Offset = "0x4B52920", VA = "0x184B54320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CCGLEIFGOJD GDBDHGLPAGL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFB10", Offset = "0x6AEE110", VA = "0x186AEFB10")]
	public BGNLHBADPNE(PPJJLGCDLDI FCINLKDGOAB, bool FKBDHGIJJGJ, BDMHIIFOMPN<TSpawnType> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF810", Offset = "0x6AEDE10", VA = "0x186AEF810", Slot = "4")]
	[AsyncStateMachine(typeof(BGNLHBADPNE<>.LOILIADOFIM))]
	public override Task<TSpawnType> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PPJJLGCDLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool OJNNGHKPDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly Vector3 PFCENHGJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly Vector3 PGBNPPMBLDB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x855D0A0", Offset = "0x855B6A0", VA = "0x18855D0A0")]
	public PPJJLGCDLDI(Transform DLCGFFGDCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x855D110", Offset = "0x855B710", VA = "0x18855D110")]
	public PPJJLGCDLDI(Vector3 EPCDDFCHPMD, Vector3 APHHGJIDDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x855D070", Offset = "0x855B670", VA = "0x18855D070")]
	public static PPJJLGCDLDI JGHKMFOJCLP()
	{
		return default(PPJJLGCDLDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x855D140", Offset = "0x855B740", VA = "0x18855D140")]
	private PPJJLGCDLDI(bool APFOJBFHGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EKALKOLOABI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public TNode BPPKMNMPHKD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B58120", Offset = "0x4B56720", VA = "0x184B58120")]
	public EKALKOLOABI(TNode BPPKMNMPHKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GIBCBDMKMHB<TNode, TReparentOperations> where TNode : notnull where TReparentOperations : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TNode ELJLHAPDEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TReparentOperations DOJOJNAPMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public PEFKGOIPNDK LMCCMJMIFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x50F4F90", Offset = "0x50F3590", VA = "0x1850F4F90")]
	public GIBCBDMKMHB(TNode ELJLHAPDEDB, TReparentOperations DOJOJNAPMBD, PEFKGOIPNDK LMCCMJMIFMD, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BNGDCPLCKNI<TNode, TReparentOperations>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] EKALKOLOABI<TNode> CMLDPPGLPPD);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BMONMHCCHLB([In] GIBCBDMKMHB<TNode, TReparentOperations> PEMGMJPGGFK);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MOMGGIBHEDM();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BAEDNMNPLNO<TNode, TReparentOperations> : LPNAIPJHOGL<BNGDCPLCKNI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public BAEDNMNPLNO(BNGDCPLCKNI<TNode, TReparentOperations> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A02CE0", Offset = "0x6A012E0", VA = "0x186A02CE0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HPCFBCGBNMA<TNode, TReparentOperations> : LPNAIPJHOGL<BNGDCPLCKNI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly GIBCBDMKMHB<TNode, TReparentOperations> PEMGMJPGGFK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x518D6C0", Offset = "0x518BCC0", VA = "0x18518D6C0")]
	public HPCFBCGBNMA(TNode ELJLHAPDEDB, TReparentOperations DOJOJNAPMBD, PEFKGOIPNDK LMCCMJMIFMD, BNGDCPLCKNI<TNode, TReparentOperations> BOBOBLMDHCP, bool FKBDHGIJJGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x518D5F0", Offset = "0x518BBF0", VA = "0x18518D5F0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BJNPOHNHKAB<TNode, TReparentOperations> : LPNAIPJHOGL<BNGDCPLCKNI<TNode, TReparentOperations>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly EKALKOLOABI<TNode> CMLDPPGLPPD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AF85E0", Offset = "0x6AF6BE0", VA = "0x186AF85E0")]
	public BJNPOHNHKAB(TNode KNEEODGFOHG, BNGDCPLCKNI<TNode, TReparentOperations> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct COEBKOCAIOB<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public TSpawnInfo FEDCLFHPGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float EAHAEIJNIMH;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x70334D0", Offset = "0x7031AD0", VA = "0x1870334D0")]
	public COEBKOCAIOB(TSpawnInfo FEDCLFHPGAI, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float EAHAEIJNIMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface GOLDBOGIOJF<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> GCIJGFPOLMI([In] COEBKOCAIOB<TSpawnInfo> LFDGCFDJPCB, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JFDBCGNONHB<TSpawnType, TSpawnInfo> : EFPCNFKDJBE<GOLDBOGIOJF<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly COEBKOCAIOB<TSpawnInfo> PNGANGECEEL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54BF280", Offset = "0x54BD880", VA = "0x1854BF280")]
	public JFDBCGNONHB(TSpawnInfo LGAAAKLDEEI, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float EAHAEIJNIMH, GOLDBOGIOJF<TSpawnType, TSpawnInfo> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x462A770", Offset = "0x4628D70", VA = "0x18462A770", Slot = "4")]
	public override Task<TSpawnType> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct OMOFOHMAODJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool LAOBLAIFLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool JLBBBIBKCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly bool FPIJCMEOLGH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6930", Offset = "0x5BD4F30", VA = "0x185BD6930")]
	public OMOFOHMAODJ(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ = false, bool MOMAIDDCMCA = false, bool ICHMCLOCPHG = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IBKHFPKPBNB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBDDAJBHKHI> BEFOEJOFDCG([In] OMOFOHMAODJ<TData> IJKDFPPDEIN, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DAFKIAELIBJ<TData> : EFPCNFKDJBE<IBKHFPKPBNB<TData>, OBDDAJBHKHI> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OMOFOHMAODJ<TData> OCIAMAJAJHG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x462A8F0", Offset = "0x4628EF0", VA = "0x18462A8F0")]
	public DAFKIAELIBJ(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ, IBKHFPKPBNB<TData> BOBOBLMDHCP, bool MIKOJMMKBNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x462A770", Offset = "0x4628D70", VA = "0x18462A770", Slot = "4")]
	public override Task<OBDDAJBHKHI> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BKNHFHLNFEM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T AMMKGILEHBG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4615EB0", Offset = "0x46144B0", VA = "0x184615EB0")]
	public BKNHFHLNFEM(T KLCMBOICBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface IEFCFJBFBGL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] BKNHFHLNFEM<T> IHBGHIAFGEB);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HKFHOFFIIFJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] KHFBHDIJLGM<T> OJKPFDDKKJG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct KHFBHDIJLGM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T AMMKGILEHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool BBNMJHECEIJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x565B190", Offset = "0x5659790", VA = "0x18565B190")]
	public KHFBHDIJLGM(T KLCMBOICBEG, bool DMCKPPOIIFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CBBEGBKNFKD<T> : LPNAIPJHOGL<IEFCFJBFBGL<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public CBBEGBKNFKD(IEFCFJBFBGL<T> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6CF0", Offset = "0x6EA52F0", VA = "0x186EA6CF0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EHLOHBOPIFD<T> : LPNAIPJHOGL<IEFCFJBFBGL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly BKNHFHLNFEM<T> IHBGHIAFGEB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4B47C10", Offset = "0x4B46210", VA = "0x184B47C10")]
	public EHLOHBOPIFD(T AMMKGILEHBG, IEFCFJBFBGL<T> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MMIOKOMCEOH<T> : LPNAIPJHOGL<HKFHOFFIIFJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly KHFBHDIJLGM<T> OJKPFDDKKJG;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CE10", Offset = "0x5A1B410", VA = "0x185A1CE10")]
	public MMIOKOMCEOH(T AMMKGILEHBG, bool DMCKPPOIIFN, HKFHOFFIIFJ<T> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct CIBONONJHCH<TData> where TData : notnull, NFGFLMKDCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public bool OLDKMJCLGGA;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AE30", Offset = "0x6F89430", VA = "0x186F8AE30")]
	public CIBONONJHCH(IEnumerable<TData> CIPNHGELEGL, bool FBMOPACHJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CAHJNLIONKL<TData> where TData : notnull, NFGFLMKDCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public List<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public List<bool> FPOPDCCPDJK;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6310", Offset = "0x6EA4910", VA = "0x186EA6310")]
	public CAHJNLIONKL(List<TData> CIPNHGELEGL, List<bool> GMHJBNAJDJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NFGFLMKDCAC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MMGCOAEOGBI
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
public interface MBEMIKBNLIG<TData> where TData : NFGFLMKDCAC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] CIBONONJHCH<TData> IIGOILJDAFH);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALBBNBAFAAF([In] CAHJNLIONKL<TData> IIGOILJDAFH);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface PPDLJJLHGAN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNBHBNHMMPP(T AMMKGILEHBG);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KNKNPELPLNP<TData> : LPNAIPJHOGL<MBEMIKBNLIG<TData>> where TData : notnull, NFGFLMKDCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CIBONONJHCH<TData> IIGOILJDAFH;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x571BFB0", Offset = "0x571A5B0", VA = "0x18571BFB0")]
	public KNKNPELPLNP(List<TData> OAOCMEKPNDE, bool OLDKMJCLGGA, MBEMIKBNLIG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class PKDHGJIDBGE<TData> : LPNAIPJHOGL<MBEMIKBNLIG<TData>> where TData : notnull, NFGFLMKDCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CAHJNLIONKL<TData> IIGOILJDAFH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CDD020", Offset = "0x5CDB620", VA = "0x185CDD020")]
	public PKDHGJIDBGE(List<TData> OAOCMEKPNDE, List<bool> FPOPDCCPDJK, MBEMIKBNLIG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCF60", Offset = "0x5CDB560", VA = "0x185CDCF60", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GPBPNPINKCB<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBDDAJBHKHI> ALBBNBAFAAF(IAJLBBMCGLP<TData> MDDLAOCDPAI);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GGACEBGCGPO<TData> : EFPCNFKDJBE<GPBPNPINKCB<TData>, OBDDAJBHKHI> where TData : notnull
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PNOKMKLCCPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AsyncTaskMethodBuilder<OBDDAJBHKHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GGACEBGCGPO<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<OBDDAJBHKHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2A90", Offset = "0x5CF1090", VA = "0x185CF2A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2D80", Offset = "0x5CF1380", VA = "0x185CF2D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IAJLBBMCGLP<TData> DBELEGIEBFM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50F1120", Offset = "0x50EF720", VA = "0x1850F1120")]
	public GGACEBGCGPO(TData GPLMOCHHPKI, IReadOnlyList<TData> AIPMDBOPAAC, bool FKBDHGIJJGJ, GPBPNPINKCB<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50F1020", Offset = "0x50EF620", VA = "0x1850F1020", Slot = "4")]
	[AsyncStateMachine(typeof(GGACEBGCGPO<>.PNOKMKLCCPM))]
	public override Task<OBDDAJBHKHI> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IAJLBBMCGLP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TData PMHPJAHPMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public IReadOnlyList<TData> PEAKFCKMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x121ED30", Offset = "0x121D330", VA = "0x18121ED30")]
	public IAJLBBMCGLP(TData GPLMOCHHPKI, IReadOnlyList<TData> AIPMDBOPAAC, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface KGLFOFJCNNH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] PJAKBNNDAGM<TData> LPJADOCNCOC);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EHEFMMAANIO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALBBNBAFAAF([In] NHEDDFCPFFA<TData> LPJADOCNCOC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface FKAFEJBIDPI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GELAKPIEBLC([In] LBMCHKIGDOC<TData> LPJADOCNCOC);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PAOOINHHDND<TData> : LPNAIPJHOGL<KGLFOFJCNNH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PJAKBNNDAGM<TData> LPJADOCNCOC;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7080", Offset = "0x5CA5680", VA = "0x185CA7080")]
	public PAOOINHHDND(IEnumerable<TData> OAOCMEKPNDE, IDOKBCEFAKB FPHNLEHIJEM, FBDPDFJNLFK PFHPGDKJCCC, float ALMPJNHAKPD, string? IPHPNMCAICN, bool LDKALKBLMJN, bool FKBDHGIJJGJ, KGLFOFJCNNH<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KAHLBLBFMIM<TData> : LPNAIPJHOGL<EHEFMMAANIO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly NHEDDFCPFFA<TData> LPJADOCNCOC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55BBEC0", Offset = "0x55BA4C0", VA = "0x1855BBEC0")]
	public KAHLBLBFMIM(TData[] OAOCMEKPNDE, IDOKBCEFAKB[] FPHNLEHIJEM, FBDPDFJNLFK[] PFHPGDKJCCC, float[] ALMPJNHAKPD, EHEFMMAANIO<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55BBE00", Offset = "0x55BA400", VA = "0x1855BBE00", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HLAAAHHFIDJ<TData> : LPNAIPJHOGL<FKAFEJBIDPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public HLAAAHHFIDJ(FKAFEJBIDPI<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x516D200", Offset = "0x516B800", VA = "0x18516D200", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class LGGMDBOBNJG<TData> : LPNAIPJHOGL<FKAFEJBIDPI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LBMCHKIGDOC<TData> LPJADOCNCOC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x57C7F60", Offset = "0x57C6560", VA = "0x1857C7F60")]
	public LGGMDBOBNJG(IEnumerable<TData> OAOCMEKPNDE, IDOKBCEFAKB FPHNLEHIJEM, FBDPDFJNLFK PFHPGDKJCCC, float ALMPJNHAKPD, FKAFEJBIDPI<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x55BBE00", Offset = "0x55BA400", VA = "0x1855BBE00", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct PJAKBNNDAGM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public IDOKBCEFAKB CAPMFCMMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public FBDPDFJNLFK GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float OAIKINPPNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public string? ENCLKBKENGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool? NBHFGKAABAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5AC0", Offset = "0x5CD40C0", VA = "0x185CD5AC0")]
	public PJAKBNNDAGM(IEnumerable<TData> OAOCMEKPNDE, IDOKBCEFAKB FPHNLEHIJEM, FBDPDFJNLFK PFHPGDKJCCC, float ALMPJNHAKPD, string? IPHPNMCAICN, bool? LDKALKBLMJN, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct NHEDDFCPFFA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TData[] NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IDOKBCEFAKB[] CAPMFCMMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FBDPDFJNLFK[] GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float[] ALMPJNHAKPD;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5A84400", Offset = "0x5A82A00", VA = "0x185A84400")]
	public NHEDDFCPFFA(TData[] OAOCMEKPNDE, IDOKBCEFAKB[] FPHNLEHIJEM, FBDPDFJNLFK[] PFHPGDKJCCC, float[] ALMPJNHAKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LBMCHKIGDOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public IDOKBCEFAKB CAPMFCMMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public FBDPDFJNLFK GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float ALMPJNHAKPD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x57C2E60", Offset = "0x57C1460", VA = "0x1857C2E60")]
	public LBMCHKIGDOC(IEnumerable<TData> OAOCMEKPNDE, IDOKBCEFAKB FPHNLEHIJEM, FBDPDFJNLFK PFHPGDKJCCC, float ALMPJNHAKPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface IHCLIHDJJKG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLLJCDBCPIN([In] AABFEAEBLAJ<TData> IJKDFPPDEIN);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIBGKBMJEJJ([In] AABFEAEBLAJ<TData> IJKDFPPDEIN);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POLKBANCLHD([In] bool OONMAMCFCCB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PDMJPGOJELK([In] AABFEAEBLAJ<TData> IJKDFPPDEIN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNGFHNJMGIP();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FKLDJHNDKPN([In] TData KEJGOLDEHMH);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JOKEFMPJCJI<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly AABFEAEBLAJ<TData> IJKDFPPDEIN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x55141F0", Offset = "0x55127F0", VA = "0x1855141F0")]
	public JOKEFMPJCJI(List<TData> KBJJADJMHBH, IHCLIHDJJKG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JIOAKBBJMCG<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public JIOAKBBJMCG(IHCLIHDJJKG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x54E39D0", Offset = "0x54E1FD0", VA = "0x1854E39D0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CJHBOCBAJIH<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D660", Offset = "0x6F8BC60", VA = "0x186F8D660")]
	public CJHBOCBAJIH(bool FKBDHGIJJGJ, IHCLIHDJJKG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D600", Offset = "0x6F8BC00", VA = "0x186F8D600", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BMCFKGPCOIC<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly AABFEAEBLAJ<TData> IJKDFPPDEIN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7D10", Offset = "0x6BC6310", VA = "0x186BC7D10")]
	public BMCFKGPCOIC(List<TData> KBJJADJMHBH, bool FKBDHGIJJGJ, IHCLIHDJJKG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CDCF60", Offset = "0x5CDB560", VA = "0x185CDCF60", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class ILPAHGPPMEP<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly TData KEJGOLDEHMH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x529E580", Offset = "0x529CB80", VA = "0x18529E580")]
	public ILPAHGPPMEP(TData KEJGOLDEHMH, IHCLIHDJJKG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x529E400", Offset = "0x529CA00", VA = "0x18529E400", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JINBJFODAIG<TData> : LPNAIPJHOGL<IHCLIHDJJKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly AABFEAEBLAJ<TData> IJKDFPPDEIN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x54E3930", Offset = "0x54E1F30", VA = "0x1854E3930")]
	public JINBJFODAIG(IEnumerable<TData> KBJJADJMHBH, IHCLIHDJJKG<TData> BOBOBLMDHCP, bool FKBDHGIJJGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x54E37C0", Offset = "0x54E1DC0", VA = "0x1854E37C0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct AABFEAEBLAJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IEnumerable<TData> NONGPOLBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5319E70", Offset = "0x5318470", VA = "0x185319E70")]
	public AABFEAEBLAJ(IEnumerable<TData> CIPNHGELEGL, bool HKBBEEBJLID = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface MIPEMPFKOJP
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBDDAJBHKHI> ALBBNBAFAAF(CNBFAGMAAEB CDMIEAOEBPK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OIEMMKAIAKA : EFPCNFKDJBE<MIPEMPFKOJP, OBDDAJBHKHI>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct PDBPLFPCCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<OBDDAJBHKHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OIEMMKAIAKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<OBDDAJBHKHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x855CD80", Offset = "0x855B380", VA = "0x18855CD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x855D000", Offset = "0x855B600", VA = "0x18855D000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly CNBFAGMAAEB CEGOKEOOCDC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x855C920", Offset = "0x855AF20", VA = "0x18855C920")]
	public OIEMMKAIAKA(bool FKBDHGIJJGJ, MIPEMPFKOJP BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x855C830", Offset = "0x855AE30", VA = "0x18855C830", Slot = "4")]
	[AsyncStateMachine(typeof(PDBPLFPCCFD))]
	public override Task<OBDDAJBHKHI> ALBBNBAFAAF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct CNBFAGMAAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool LAOBLAIFLJF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7910", Offset = "0x2DB5F10", VA = "0x182DB7910")]
	public CNBFAGMAAEB(bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct MLKPMPNBJCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly bool EOCKBIOJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly bool CDJAMOLOKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly bool EAHAEIJNIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6391D30", Offset = "0x6390330", VA = "0x186391D30")]
	public MLKPMPNBJCJ(bool EOCKBIOJGJE, bool CDJAMOLOKHB, bool EAHAEIJNIMH, bool FKBDHGIJJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x855C490", Offset = "0x855AA90", VA = "0x18855C490")]
	public MLKPMPNBJCJ(bool CDJAMOLOKHB, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface ODAKOLNLAMA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HABKOJALKCL(MLKPMPNBJCJ HOCBJBMEMME);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OMAAKHKKKOM(MLKPMPNBJCJ HOCBJBMEMME);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GPAEOLEAGOC : LPNAIPJHOGL<ODAKOLNLAMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MLKPMPNBJCJ HOCBJBMEMME;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x855BBE0", Offset = "0x855A1E0", VA = "0x18855BBE0")]
	public GPAEOLEAGOC(bool CCHLCEHOKAD, bool CDJAMOLOKHB, bool EAHAEIJNIMH, bool FKBDHGIJJGJ, ODAKOLNLAMA BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x855BB90", Offset = "0x855A190", VA = "0x18855BB90", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class LANKOJAHPOP : LPNAIPJHOGL<ODAKOLNLAMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MLKPMPNBJCJ HOCBJBMEMME;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x855C260", Offset = "0x855A860", VA = "0x18855C260")]
	public LANKOJAHPOP(bool CDJAMOLOKHB, bool FKBDHGIJJGJ, ODAKOLNLAMA BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x855C210", Offset = "0x855A810", VA = "0x18855C210", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KALJDMIOFIL
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALBBNBAFAAF([In] DJBBKINADII DJEMAIPAKLP);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JMNBOAOPLNF : LPNAIPJHOGL<KALJDMIOFIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly DJBBKINADII DJEMAIPAKLP;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x855C030", Offset = "0x855A630", VA = "0x18855C030")]
	public JMNBOAOPLNF(Guid[] HKMANOOINFJ, Vector3[] NKEMJOKCLBE, Quaternion[] AHAGGFFJKHF, float[] ENHAGFLOIEC, Dictionary<Guid, Vector3> FCIFGKILBII, KALJDMIOFIL BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x855BF80", Offset = "0x855A580", VA = "0x18855BF80", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface KOCCECCLBKK<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] ICJKBGLBKLA<TData> CMLDPPGLPPD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GELAKPIEBLC([In] FJFOKMNPHFC FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GELAKPIEBLC([In] ADNGDKLJECF FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DDPKBFIPPJI<TData> : LPNAIPJHOGL<KOCCECCLBKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public DDPKBFIPPJI(KOCCECCLBKK<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4649450", Offset = "0x4647A50", VA = "0x184649450", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class EDKOMJNIBCE<TData> : LPNAIPJHOGL<KOCCECCLBKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FJFOKMNPHFC LLHEMEMKPNJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B04280", Offset = "0x4B02880", VA = "0x184B04280")]
	public EDKOMJNIBCE(Vector3 PGNLPIIIGPE, bool MEDPHPHPOBA, KOCCECCLBKK<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B04220", Offset = "0x4B02820", VA = "0x184B04220", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class CKPILEDNECH<TData> : LPNAIPJHOGL<KOCCECCLBKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ADNGDKLJECF LLHEMEMKPNJ;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8DE0", Offset = "0x6FD73E0", VA = "0x186FD8DE0")]
	public CKPILEDNECH(Guid HHHAIJJAHFL, int PMIGBJGNLLP, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO, bool MEDPHPHPOBA, KOCCECCLBKK<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8D80", Offset = "0x6FD7380", VA = "0x186FD8D80", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class FNAFLADGEFB<TData> : LPNAIPJHOGL<KOCCECCLBKK<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ICJKBGLBKLA<TData> LLHEMEMKPNJ;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5026AB0", Offset = "0x50250B0", VA = "0x185026AB0")]
	public FNAFLADGEFB(TData AMMKGILEHBG, bool FKBDHGIJJGJ, KOCCECCLBKK<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FJFOKMNPHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Vector3 PGNLPIIIGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool MEDPHPHPOBA;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x855B8F0", Offset = "0x8559EF0", VA = "0x18855B8F0")]
	public FJFOKMNPHFC(Vector3 PGNLPIIIGPE, bool MEDPHPHPOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct ADNGDKLJECF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Guid HHHAIJJAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly int PMIGBJGNLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly Vector3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly float JPNOJNLEGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool MEDPHPHPOBA;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x855B180", Offset = "0x8559780", VA = "0x18855B180")]
	public ADNGDKLJECF(Guid HHHAIJJAHFL, int PMIGBJGNLLP, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO, bool MEDPHPHPOBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct ICJKBGLBKLA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly TData AMMKGILEHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5258F20", Offset = "0x5257520", VA = "0x185258F20")]
	public ICJKBGLBKLA(TData AMMKGILEHBG, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface DJKDHAHOAHG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] GNLDHHLHGDJ<TData> GKHDCGBBPAL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALBBNBAFAAF([In] NCIAIEBDKJM<TData> GKHDCGBBPAL);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FFBAHDOOALH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] AEBDKGMHDHH<TData> PPPCLPGMGPE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GELAKPIEBLC([In] ENACBKFGEDF FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class AHNACMHCNIN<TData> : LPNAIPJHOGL<DJKDHAHOAHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GNLDHHLHGDJ<TData> GKHDCGBBPAL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5413150", Offset = "0x5411750", VA = "0x185413150")]
	public AHNACMHCNIN(IEnumerable<TData> OAOCMEKPNDE, Vector3 MDGNOADMDPO, bool FKBDHGIJJGJ, DJKDHAHOAHG<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class ABMBEBGBLFK<TData> : LPNAIPJHOGL<FFBAHDOOALH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public ABMBEBGBLFK(FFBAHDOOALH<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x531EF30", Offset = "0x531D530", VA = "0x18531EF30", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HCDFLKMNLPA<TData> : LPNAIPJHOGL<FFBAHDOOALH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly AEBDKGMHDHH<TData> GKHDCGBBPAL;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x51529D0", Offset = "0x5150FD0", VA = "0x1851529D0")]
	public HCDFLKMNLPA(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ, FFBAHDOOALH<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class BLEEEKMOBIG<TData> : LPNAIPJHOGL<DJKDHAHOAHG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly NCIAIEBDKJM<TData> GKHDCGBBPAL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBBB0", Offset = "0x6AFA1B0", VA = "0x186AFBBB0")]
	public BLEEEKMOBIG(IEnumerable<TData> OAOCMEKPNDE, Vector3 MHLEPBDIEGA, EGNPHFAPHFJ NNKJGHHAALE, bool FKBDHGIJJGJ, DJKDHAHOAHG<TData> BOBOBLMDHCP, Space JIJIJAKCCDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x518D5F0", Offset = "0x518BBF0", VA = "0x18518D5F0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class CEENLOADBME<TData> : LPNAIPJHOGL<FFBAHDOOALH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ENACBKFGEDF GKHDCGBBPAL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD150", Offset = "0x6EAB750", VA = "0x186EAD150")]
	public CEENLOADBME(Vector3 MDGNOADMDPO, FFBAHDOOALH<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B04220", Offset = "0x4B02820", VA = "0x184B04220", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GNLDHHLHGDJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly Vector3 MDGNOADMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5102760", Offset = "0x5100D60", VA = "0x185102760")]
	public GNLDHHLHGDJ(IEnumerable<TData> OAOCMEKPNDE, Vector3 MDGNOADMDPO, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct AEBDKGMHDHH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5409430", Offset = "0x5407A30", VA = "0x185409430")]
	public AEBDKGMHDHH(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct NCIAIEBDKJM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly Vector3 MHLEPBDIEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly EGNPHFAPHFJ NNKJGHHAALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly Space JIJIJAKCCDI;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A75580", Offset = "0x5A73B80", VA = "0x185A75580")]
	public NCIAIEBDKJM(IEnumerable<TData> OAOCMEKPNDE, Vector3 MHLEPBDIEGA, EGNPHFAPHFJ NNKJGHHAALE, bool FKBDHGIJJGJ, Space JIJIJAKCCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ENACBKFGEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly Vector3 MDGNOADMDPO;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8C30", Offset = "0x2DB7230", VA = "0x182DB8C30")]
	public ENACBKFGEDF(Vector3 MDGNOADMDPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public enum EGNPHFAPHFJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface GELHPAHEDJP
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] PHFHIMACGHM KOANOGEOABI);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class FLHOECFAABI : LPNAIPJHOGL<GELHPAHEDJP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly PHFHIMACGHM KOANOGEOABI;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x855BB30", Offset = "0x855A130", VA = "0x18855BB30")]
	public FLHOECFAABI(bool FKBDHGIJJGJ, GELHPAHEDJP BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x855BA80", Offset = "0x855A080", VA = "0x18855BA80", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct PHFHIMACGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DB7910", Offset = "0x2DB5F10", VA = "0x182DB7910")]
	public PHFHIMACGHM(bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface NHPOGPLLJFJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALBBNBAFAAF([In] AABIHJDNLNL<TData> DLAMMCFLHBA);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALBBNBAFAAF([In] IGOEGIFELDK<TData> DLAMMCFLHBA);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface LDLKCNGMNEO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] LFCHPENHCEG<TData> CMLDPPGLPPD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GELAKPIEBLC([In] BODNIKJMGMO FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class CNKGCDKDAMN<TData> : LPNAIPJHOGL<NHPOGPLLJFJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly AABIHJDNLNL<TData> DLAMMCFLHBA;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7032090", Offset = "0x7030690", VA = "0x187032090")]
	public CNKGCDKDAMN(IEnumerable<TData> OAOCMEKPNDE, Quaternion MDGNOADMDPO, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD, bool FKBDHGIJJGJ, NHPOGPLLJFJ<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class CHDCKDDEIOO<TData> : LPNAIPJHOGL<LDLKCNGMNEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public CHDCKDDEIOO(LDLKCNGMNEO<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x531EF30", Offset = "0x531D530", VA = "0x18531EF30", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CJFCFIJLIIK<TData> : LPNAIPJHOGL<LDLKCNGMNEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly LFCHPENHCEG<TData> DLAMMCFLHBA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CDB0", Offset = "0x6F8B3B0", VA = "0x186F8CDB0")]
	public CJFCFIJLIIK(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ, LDLKCNGMNEO<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class NMDIHMPLOAE<TData> : LPNAIPJHOGL<NHPOGPLLJFJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly IGOEGIFELDK<TData> DLAMMCFLHBA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A8EEC0", Offset = "0x5A8D4C0", VA = "0x185A8EEC0")]
	public NMDIHMPLOAE(IEnumerable<TData> OAOCMEKPNDE, Quaternion AFBGPKKHDJC, EGNPHFAPHFJ FCDBKEIHEIB, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD, bool FKBDHGIJJGJ, Space JIJIJAKCCDI, NHPOGPLLJFJ<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x518D5F0", Offset = "0x518BBF0", VA = "0x18518D5F0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class LDNBIFMAFEG<TData> : LPNAIPJHOGL<LDLKCNGMNEO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BODNIKJMGMO DLAMMCFLHBA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57C65B0", Offset = "0x57C4BB0", VA = "0x1857C65B0")]
	public LDNBIFMAFEG(Quaternion MDGNOADMDPO, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD, LDLKCNGMNEO<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B04220", Offset = "0x4B02820", VA = "0x184B04220", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct AABIHJDNLNL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly Quaternion MDGNOADMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly Vector3? ONBNKAFHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool PBAIFBLHLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x531A180", Offset = "0x5318780", VA = "0x18531A180")]
	public AABIHJDNLNL(IEnumerable<TData> OAOCMEKPNDE, Quaternion MDGNOADMDPO, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LFCHPENHCEG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x57C6D30", Offset = "0x57C5330", VA = "0x1857C6D30")]
	public LFCHPENHCEG(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IGOEGIFELDK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public readonly Quaternion AFBGPKKHDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly EGNPHFAPHFJ FCDBKEIHEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Vector3? ONBNKAFHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly bool PBAIFBLHLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly Space JIJIJAKCCDI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x52836C0", Offset = "0x5281CC0", VA = "0x1852836C0")]
	public IGOEGIFELDK(IEnumerable<TData> OAOCMEKPNDE, Quaternion AFBGPKKHDJC, EGNPHFAPHFJ FCDBKEIHEIB, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD, bool FKBDHGIJJGJ, Space JIJIJAKCCDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct BODNIKJMGMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Quaternion MDGNOADMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly Vector3? ONBNKAFHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool PBAIFBLHLLD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6337A80", Offset = "0x6336080", VA = "0x186337A80")]
	public BODNIKJMGMO(Quaternion MDGNOADMDPO, Vector3? ONBNKAFHBBB, bool PBAIFBLHLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface FMDMCHJCBAB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAGFLBAEDLC([In] JGANFIHIHPD<TData> CMLDPPGLPPD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GELAKPIEBLC([In] OLHGAODKDHK FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GELAKPIEBLC([In] OKGIALJAOHE FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GELAKPIEBLC([In] EBKHGNNGCKI FGHIPGFEIHG);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMONMHCCHLB();
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class JJCPOMLAKGL<TData> : LPNAIPJHOGL<FMDMCHJCBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly EBKHGNNGCKI IBFFIPDEMED;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x54E7310", Offset = "0x54E5910", VA = "0x1854E7310")]
	public JJCPOMLAKGL(Vector3 NEEBOLCGCAM, float PFDEEHBMFHF, Vector3 ONBNKAFHBBB, bool ABIBJCAJEGO, bool KCFKHPNEBDL, FMDMCHJCBAB<TData> BOBOBLMDHCP, Space JIJIJAKCCDI = Space.Self)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x54E72B0", Offset = "0x54E58B0", VA = "0x1854E72B0", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PEOBANPJPJE<TData> : LPNAIPJHOGL<FMDMCHJCBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	public PEOBANPJPJE(FMDMCHJCBAB<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9880", Offset = "0x5CC7E80", VA = "0x185CC9880", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class CLPHPKANEFP<TData> : LPNAIPJHOGL<FMDMCHJCBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly JGANFIHIHPD<TData> IBFFIPDEMED;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x70297E0", Offset = "0x7027DE0", VA = "0x1870297E0")]
	public CLPHPKANEFP(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ, FMDMCHJCBAB<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B50", Offset = "0x4B46150", VA = "0x184B47B50", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class OCMDMANFGPP<TData> : LPNAIPJHOGL<FMDMCHJCBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly OKGIALJAOHE IBFFIPDEMED;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B9DB30", Offset = "0x5B9C130", VA = "0x185B9DB30")]
	public OCMDMANFGPP(float BEMBCELDGCB, bool PGGNJKMHLKM, Vector3 ONBNKAFHBBB, FMDMCHJCBAB<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5B9DA60", Offset = "0x5B9C060", VA = "0x185B9DA60", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class LKODLIOHJJA<TData> : LPNAIPJHOGL<FMDMCHJCBAB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly OLHGAODKDHK IBFFIPDEMED;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x57D05C0", Offset = "0x57CEBC0", VA = "0x1857D05C0")]
	public LKODLIOHJJA(float PFDEEHBMFHF, Vector3 ONBNKAFHBBB, FMDMCHJCBAB<TData> BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4B04220", Offset = "0x4B02820", VA = "0x184B04220", Slot = "4")]
	public override bool ALBBNBAFAAF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct EBKHGNNGCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly Vector3 NEEBOLCGCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly float PFDEEHBMFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Vector3 ONBNKAFHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly bool MEDPHPHPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly Space JIJIJAKCCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly bool KCFKHPNEBDL;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x855B8B0", Offset = "0x8559EB0", VA = "0x18855B8B0")]
	public EBKHGNNGCKI(Vector3 NEEBOLCGCAM, float PFDEEHBMFHF, Vector3 ONBNKAFHBBB, bool MEDPHPHPOBA, bool MGCCCBNHIND, Space JIJIJAKCCDI = Space.Self)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct JGANFIHIHPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly IEnumerable<TData> OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly bool FKBDHGIJJGJ;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x54C0510", Offset = "0x54BEB10", VA = "0x1854C0510")]
	public JGANFIHIHPD(IEnumerable<TData> OAOCMEKPNDE, bool FKBDHGIJJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct OKGIALJAOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly float BEMBCELDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly bool PGGNJKMHLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public readonly Vector3 ONBNKAFHBBB;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x855CD60", Offset = "0x855B360", VA = "0x18855CD60")]
	public OKGIALJAOHE(float BEMBCELDGCB, bool PGGNJKMHLKM, Vector3 ONBNKAFHBBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OLHGAODKDHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public readonly float PFDEEHBMFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public readonly Vector3 ONBNKAFHBBB;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62FB8A0", Offset = "0x62F9EA0", VA = "0x1862FB8A0")]
	public OLHGAODKDHK(float PFDEEHBMFHF, Vector3 ONBNKAFHBBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct DJBBKINADII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public readonly Guid[] OAOCMEKPNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public readonly bool LNADBEPFHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly bool KICLLFPCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly bool HBPEPFBNEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly Vector3[] NKEMJOKCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly Quaternion[] AHAGGFFJKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly float[] ENHAGFLOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly Dictionary<Guid, Vector3> FCIFGKILBII;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x855B620", Offset = "0x8559C20", VA = "0x18855B620")]
	public DJBBKINADII(Guid[] HKMANOOINFJ, Vector3[] NKEMJOKCLBE, Quaternion[] AHAGGFFJKHF, float[] ENHAGFLOIEC, Dictionary<Guid, Vector3> FCIFGKILBII, bool LNADBEPFHFH = true, bool KICLLFPCHCL = true, bool HBPEPFBNEEC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x855B450", Offset = "0x8559A50", VA = "0x18855B450")]
	private static void JLBDEJPNDAB(Dictionary<Guid, Vector3> FCIFGKILBII, int PDJOCFJGHDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class OKFMNFIOPLD
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct HICCIFHACDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public bool OCIBJICFJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public NMNJFHODGJA ALEJMDEMNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public NMNJFHODGJA PAOAKKIHIMK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static HICCIFHACDG OLEILMGGEGK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CancellationToken FMBEFCNGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x855CD40", Offset = "0x855B340", VA = "0x18855CD40")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static NMNJFHODGJA ALEJMDEMNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x855CA40", Offset = "0x855B040", VA = "0x18855CA40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x855C9D0", Offset = "0x855AFD0", VA = "0x18855C9D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x855CC40", Offset = "0x855B240", VA = "0x18855CC40")]
	[EGNICHGEFDG.KJKACNMMOJK]
	internal static void PEPKAEJBCFB(NMNJFHODGJA OOMHFHLOAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x855CAE0", Offset = "0x855B0E0", VA = "0x18855CAE0")]
	public static void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x855C980", Offset = "0x855AF80", VA = "0x18855C980")]
	private static NMNJFHODGJA FHLMELGLCKL(NMNJFHODGJA LKNNNJCBLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class KGIGOCNMDBD
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public enum PHFIHIECLAA
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1880", Offset = "0x3E9FE80", VA = "0x183EA1880")]
	public static void MDEMNOIBIMA<T>(T MHKMPBAHOMB, PHFIHIECLAA GPEIAHGICNA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3EA19C0", Offset = "0x3E9FFC0", VA = "0x183EA19C0")]
	public static void MDEMNOIBIMA<T>(T MHKMPBAHOMB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3EA17A0", Offset = "0x3E9FDA0", VA = "0x183EA17A0")]
	public static void MDEMNOIBIMA<T, TImpl, T>() where T : class where TImpl : notnull, T where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1690", Offset = "0x3E9FC90", VA = "0x183EA1690")]
	public static void FMLBIEKPPOM<T>(T MHKMPBAHOMB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1700", Offset = "0x3E9FD00", VA = "0x183EA1700")]
	public static T HBAOOBIPNDD<T>(PHFIHIECLAA GPEIAHGICNA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1AC0", Offset = "0x3EA00C0", VA = "0x183EA1AC0")]
	public static bool PKCFNJDKDMF<T>(PHFIHIECLAA GPEIAHGICNA, T? IHGAMALMPOH, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T OCFHCDMJABM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA14B0", Offset = "0x3E9FAB0", VA = "0x183EA14B0")]
	public static bool BFDCCMHHAPN<T>(PHFIHIECLAA GPEIAHGICNA, [Out][NotNullWhen(true)][MaybeNullWhen(false)] T AJFAGKHCGFH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3EA15B0", Offset = "0x3E9FBB0", VA = "0x183EA15B0")]
	public static bool FDOENMHDKKC<T>(PHFIHIECLAA GPEIAHGICNA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1650", Offset = "0x3E9FC50", VA = "0x183EA1650")]
	public static T HBAOOBIPNDD<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1A20", Offset = "0x3EA0020", VA = "0x183EA1A20")]
	public static bool PKCFNJDKDMF<T>(T IHGAMALMPOH, [Out] T OCFHCDMJABM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1650", Offset = "0x3E9FC50", VA = "0x183EA1650")]
	public static bool FDOENMHDKKC<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal static class DHKNNCMGIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x855B220", Offset = "0x8559820", VA = "0x18855B220")]
	public static void HHFNHHNBJCK(IEnumerable CCHHGJKFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B490", Offset = "0x3C29A90", VA = "0x183C2B490")]
	public static void HHFNHHNBJCK<T>(T[] GHKPAFFMJAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B580", Offset = "0x3C29B80", VA = "0x183C2B580")]
	public static void HHFNHHNBJCK<T>(T KCKCBGONOJI) where T : notnull, Enum
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
