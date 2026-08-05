using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x672E3C0", Offset = "0x672D7C0", VA = "0x18672E3C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6F0", Offset = "0x6FAAF0", VA = "0x1806FB6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x92A620", Offset = "0x929A20", VA = "0x18092A620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MIMKEIIOEBE<TData> : JMOLJBOOCAA, global::ALHDFGBLOKM<TData>, global::CIEDBLKINJM<TData>, global::HJCGGFOGHOH<TData>, global::BNFBHNKCNIJ<TData>, MDLKKIBJOPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BNFBHNKCNIJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 ANCODJBIPAB, Vector3 JLBPNKFCLFO, float FNIJMIADAMA, out T MBOCJDFJPLO, out Vector3 GONMFKBKGNP, out Collider NHBCCIJBNMC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 ANCODJBIPAB, Vector3 JLBPNKFCLFO, float CJHJGNMKFHK, float FNIJMIADAMA, T[] HPELDDDEPOA, out Vector3 IPDOMDGFINO, out Collider AIACIHEEAHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 ANCODJBIPAB, float CJHJGNMKFHK, Vector3 LJLMAKOHENM, T[] HPELDDDEPOA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JMOLJBOOCAA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds DLBGEAOLEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform PFBLOAAMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds CFCMDLGMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform OLOOBCFFGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 APNALDPEELB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HJCGGFOGHOH<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KHKJNHKMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int FBAHAHAHNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> EDJGNLNGLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData DKIDMLOAMGB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData DKIDMLOAMGB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALHDFGBLOKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T AELIHOPICED, [Optional] NIHKMKJOMNK? FFHNNFOLDDG, bool PENGOKKBLNB = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int KJAHKKMJHHG, IEnumerable<T> MAGFIPGLPJJ, bool PENGOKKBLNB = true);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int KJAHKKMJHHG, IEnumerable<T> MAGFIPGLPJJ, NIHKMKJOMNK FFHNNFOLDDG, bool PENGOKKBLNB = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MDLKKIBJOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OKACOCBGPBB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TNode NFIBOHFIBDF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7BD0", Offset = "0x2BD6FD0", VA = "0x182BD7BD0")]
	public OKACOCBGPBB(TNode NFIBOHFIBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JHGAPFFJIKO<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode MIJLLFBOJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public HLOBNKAHFPN NPLDKNNDEKP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3606340", Offset = "0x3605740", VA = "0x183606340")]
	public JHGAPFFJIKO(TNode MIJLLFBOJPI, HLOBNKAHFPN NPLDKNNDEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EDBILEDNBDD<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEMPJOEKCOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EB00", Offset = "0x69DF00")] in global::OKACOCBGPBB<TNode?> IGIMHKJKKNC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMHJALFDIDG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EB70", Offset = "0x69DF70")] in global::JHGAPFFJIKO<TNode?> PDDPPELBLKA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PDKGAOMFGHP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EBE0", Offset = "0x69DFE0")]
public class CPPHKMKAJFN<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710")]
	public CPPHKMKAJFN(global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2766870", Offset = "0x2765C70", VA = "0x182766870", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EC50", Offset = "0x69E050")]
public class BMMJFMCACLB<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69ECC0", Offset = "0x69E0C0")]
	private readonly global::JHGAPFFJIKO<TNode> PDDPPELBLKA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x40C0120", Offset = "0x40BF520", VA = "0x1840C0120")]
	public BMMJFMCACLB(TNode MIJLLFBOJPI, HLOBNKAHFPN NPLDKNNDEKP, global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30A6930", Offset = "0x30A5D30", VA = "0x1830A6930", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69ED20", Offset = "0x69E120")]
public class JHNACLGOFDM<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69ED90", Offset = "0x69E190")]
	private readonly global::OKACOCBGPBB<TNode> IGIMHKJKKNC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36065E0", Offset = "0x36059E0", VA = "0x1836065E0")]
	public JHNACLGOFDM(TNode DINLEJJDNDK, global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x16533E0", Offset = "0x16527E0", VA = "0x1816533E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NKNIPJMPCCP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x277EED0", Offset = "0x277E2D0", VA = "0x18277EED0")]
	public NKNIPJMPCCP(IEnumerable<TData> LOHPHEGKDLL, bool LKLIGMKNDAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JDKJFIPIEEM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLNDMPPMHEH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EDF0", Offset = "0x69E1F0")] in global::NKNIPJMPCCP<TData?> GKFCAJPLJOH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EE60", Offset = "0x69E260")]
public class MADDPKCEKAE<TData> : global::FIHJGDLLCLO<global::JDKJFIPIEEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EED0", Offset = "0x69E2D0")]
	private readonly global::NKNIPJMPCCP<TData> ELODOLLIHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30A0F90", Offset = "0x30A0390", VA = "0x1830A0F90")]
	public MADDPKCEKAE(List<TData> OBPNIKFBDBK, bool NMPKNONCEJD, global::JDKJFIPIEEM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30A0ED0", Offset = "0x30A02D0", VA = "0x1830A0ED0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MFEMKENJPHK<TData> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool GIBGIFOMBFM;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x36E6A40", Offset = "0x36E5E40", VA = "0x1836E6A40")]
	public MFEMKENJPHK(IEnumerable<TData> LOHPHEGKDLL, bool FLEOLNIGEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GOFPPLBDIAP<TData> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public List<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<bool> BLMDOGLPIJE;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2AD71A0", Offset = "0x2AD65A0", VA = "0x182AD71A0")]
	public GOFPPLBDIAP(List<TData> LOHPHEGKDLL, List<bool> LFPADDEDFGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BJDLMNFLKDK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool FPPEEKDMICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DJJFIBBBKJG<TData> where TData : BJDLMNFLKDK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DAF0", Offset = "0x69CEF0")] in global::MFEMKENJPHK<TData> PDEKCADJFGK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DB60", Offset = "0x69CF60")] in global::GOFPPLBDIAP<TData> PDEKCADJFGK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DBD0", Offset = "0x69CFD0")]
public class MIHNEHLAAFC<TData> : global::FIHJGDLLCLO<global::DJJFIBBBKJG<TData>> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DC40", Offset = "0x69D040")]
	private readonly global::MFEMKENJPHK<TData> PDEKCADJFGK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36F6490", Offset = "0x36F5890", VA = "0x1836F6490")]
	public MIHNEHLAAFC(List<TData> LOLBGJKFFAI, bool GIBGIFOMBFM, global::DJJFIBBBKJG<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x16533E0", Offset = "0x16527E0", VA = "0x1816533E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DCA0", Offset = "0x69D0A0")]
public class MMCELNPJICI<TData> : global::FIHJGDLLCLO<global::DJJFIBBBKJG<TData>> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DD10", Offset = "0x69D110")]
	private readonly global::GOFPPLBDIAP<TData> PDEKCADJFGK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32108C0", Offset = "0x320FCC0", VA = "0x1832108C0")]
	public MMCELNPJICI(List<TData> LOLBGJKFFAI, List<bool> BLMDOGLPIJE, global::DJJFIBBBKJG<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x32107F0", Offset = "0x320FBF0", VA = "0x1832107F0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HLDGGBECGPF : BJDLMNFLKDK
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DD70", Offset = "0x69D170")]
public abstract class FIHJGDLLCLO<TReceiver> : global::NDIJKMIFCFK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710")]
	public FIHJGDLLCLO(TReceiver OICNAHPNIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class NDIJKMIFCFK<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected TReceiver OICNAHPNIJJ;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2777C30", Offset = "0x2777030", VA = "0x182777C30")]
	public NDIJKMIFCFK(TReceiver OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EALHBJADKHF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DJCKMBNCEMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DE20", Offset = "0x69D220")] in global::GNDNKMFNLPD<TData?> DHNGHJNDDKI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HDJKMDGABFC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DE90", Offset = "0x69D290")] in global::PDADIHEGAOJ<TData?> DHNGHJNDDKI);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HEIBIDKDKFC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BHPBPBOEBGB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DF00", Offset = "0x69D300")] in global::JHIBBMAGALD<TData?> DHNGHJNDDKI);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMHJALFDIDG();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DF70", Offset = "0x69D370")]
public class IAAOKDPECKF<TData> : global::FIHJGDLLCLO<global::DJCKMBNCEMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69DFE0", Offset = "0x69D3E0")]
	private readonly global::GNDNKMFNLPD<TData> DHNGHJNDDKI;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x16534A0", Offset = "0x16528A0", VA = "0x1816534A0")]
	public IAAOKDPECKF(IEnumerable<TData> LOLBGJKFFAI, GEHJPLJJIIJ LDFNLMPJEDN, LIFEBPMLBGM HNKAKNCAJGB, float MMMJMCGCPII, bool NMPKNONCEJD, global::DJCKMBNCEMB<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x16533E0", Offset = "0x16527E0", VA = "0x1816533E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E040", Offset = "0x69D440")]
public class KMMAJFICMIP<TData> : global::FIHJGDLLCLO<global::HDJKMDGABFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E0B0", Offset = "0x69D4B0")]
	private readonly global::PDADIHEGAOJ<TData> DHNGHJNDDKI;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x369A810", Offset = "0x3699C10", VA = "0x18369A810")]
	public KMMAJFICMIP(TData[] LOLBGJKFFAI, GEHJPLJJIIJ[] LDFNLMPJEDN, LIFEBPMLBGM[] HNKAKNCAJGB, float[] MMMJMCGCPII, global::HDJKMDGABFC<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30A0ED0", Offset = "0x30A02D0", VA = "0x1830A0ED0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E110", Offset = "0x69D510")]
public class KANOKPANICE<TData> : global::FIHJGDLLCLO<global::HEIBIDKDKFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710")]
	public KANOKPANICE(global::HEIBIDKDKFC<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2848EA0", Offset = "0x28482A0", VA = "0x182848EA0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E180", Offset = "0x69D580")]
public class JDDCOKOLGHF<TData> : global::FIHJGDLLCLO<global::HEIBIDKDKFC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E1F0", Offset = "0x69D5F0")]
	private readonly global::JHIBBMAGALD<TData> DHNGHJNDDKI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x316E660", Offset = "0x316DA60", VA = "0x18316E660")]
	public JDDCOKOLGHF(IEnumerable<TData> LOLBGJKFFAI, GEHJPLJJIIJ LDFNLMPJEDN, LIFEBPMLBGM HNKAKNCAJGB, float MMMJMCGCPII, global::HEIBIDKDKFC<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30A0ED0", Offset = "0x30A02D0", VA = "0x1830A0ED0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GNDNKMFNLPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public GEHJPLJJIIJ GOMHMFOHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public LIFEBPMLBGM JFKBNJPJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float MMMJMCGCPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5EE0", Offset = "0x2AD52E0", VA = "0x182AD5EE0")]
	public GNDNKMFNLPD(IEnumerable<TData> LOLBGJKFFAI, GEHJPLJJIIJ LDFNLMPJEDN, LIFEBPMLBGM HNKAKNCAJGB, float MMMJMCGCPII, bool NMPKNONCEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PDADIHEGAOJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData[] BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public GEHJPLJJIIJ[] GOMHMFOHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public LIFEBPMLBGM[] JFKBNJPJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float[] MMMJMCGCPII;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DABF70", Offset = "0x2DAB370", VA = "0x182DABF70")]
	public PDADIHEGAOJ(TData[] LOLBGJKFFAI, GEHJPLJJIIJ[] LDFNLMPJEDN, LIFEBPMLBGM[] HNKAKNCAJGB, float[] MMMJMCGCPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JHIBBMAGALD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GEHJPLJJIIJ GOMHMFOHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public LIFEBPMLBGM JFKBNJPJFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float MMMJMCGCPII;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36064E0", Offset = "0x36058E0", VA = "0x1836064E0")]
	public JHIBBMAGALD(IEnumerable<TData> LOLBGJKFFAI, GEHJPLJJIIJ LDFNLMPJEDN, LIFEBPMLBGM HNKAKNCAJGB, float MMMJMCGCPII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CIEDBLKINJM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEGLMGHGIAI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E250", Offset = "0x69D650")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHDMJBNLKHO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E2C0", Offset = "0x69D6C0")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACBGNFIBKBI(in bool NEDBNAEGPKO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GDFAOHBJCDC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E330", Offset = "0x69D730")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIHOBBJOKMK();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLEDLHEIAKI(in TData GDPBJGJAHFE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E3A0", Offset = "0x69D7A0")]
public class DJIEECGKCPI<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E410", Offset = "0x69D810")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x32A0AF0", Offset = "0x329FEF0", VA = "0x1832A0AF0")]
	public DJIEECGKCPI(List<TData> OBPNIKFBDBK, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16533E0", Offset = "0x16527E0", VA = "0x1816533E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E470", Offset = "0x69D870")]
public class FAEKMEJDKGE<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710")]
	public FAEKMEJDKGE(global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4556D90", Offset = "0x4556190", VA = "0x184556D90", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E4E0", Offset = "0x69D8E0")]
public class IMMJBFFFLPN<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x22709C0", Offset = "0x226FDC0", VA = "0x1822709C0")]
	public IMMJBFFFLPN(bool NMPKNONCEJD, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2270950", Offset = "0x226FD50", VA = "0x182270950", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E550", Offset = "0x69D950")]
public class PNACALJOCMM<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E5C0", Offset = "0x69D9C0")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x33FC850", Offset = "0x33FBC50", VA = "0x1833FC850")]
	public PNACALJOCMM(List<TData> OBPNIKFBDBK, bool NMPKNONCEJD, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x32107F0", Offset = "0x320FBF0", VA = "0x1832107F0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E620", Offset = "0x69DA20")]
public class KFHFAADGOND<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData GDPBJGJAHFE;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2857830", Offset = "0x2856C30", VA = "0x182857830")]
	public KFHFAADGOND(TData GDPBJGJAHFE, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2857760", Offset = "0x2856B60", VA = "0x182857760", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E690", Offset = "0x69DA90")]
public class LACDMLBFMJH<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E700", Offset = "0x69DB00")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26B09D0", Offset = "0x26AFDD0", VA = "0x1826B09D0")]
	public LACDMLBFMJH(List<TData> OBPNIKFBDBK, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26B0900", Offset = "0x26AFD00", VA = "0x1826B0900", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ECBIOFNPLIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29B2380", Offset = "0x29B1780", VA = "0x1829B2380")]
	public ECBIOFNPLIE(IEnumerable<TData> LOHPHEGKDLL, bool LKLIGMKNDAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JFHLDLJBDLA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E760", Offset = "0x69DB60")] in global::MPPHCGGEJAB<TData?> GLAEIINKKOA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEMPJOEKCOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E7D0", Offset = "0x69DBD0")] in global::PIMFCKHKCOC<TData?> PHGIODLOHMN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHPBPBOEBGB(in LEOMHFBIHJC NDODKPGKGJE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMHJALFDIDG();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E840", Offset = "0x69DC40")]
public class GIALGHGHHBF<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E8B0", Offset = "0x69DCB0")]
	private readonly global::MPPHCGGEJAB<TData> GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x318BD60", Offset = "0x318B160", VA = "0x18318BD60")]
	public GIALGHGHHBF(IEnumerable<TData> LOLBGJKFFAI, Vector3 NFDNJBLAHOL, bool NMPKNONCEJD, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x16533E0", Offset = "0x16527E0", VA = "0x1816533E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E910", Offset = "0x69DD10")]
public class IHMJNNGPNBL<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1673710", Offset = "0x1672B10", VA = "0x181673710")]
	public IHMJNNGPNBL(global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x16736B0", Offset = "0x1672AB0", VA = "0x1816736B0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E980", Offset = "0x69DD80")]
public class MBLNMMANCBH<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69E9F0", Offset = "0x69DDF0")]
	private readonly global::PIMFCKHKCOC<TData> GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x30A6AA0", Offset = "0x30A5EA0", VA = "0x1830A6AA0")]
	public MBLNMMANCBH(IEnumerable<TData> LOLBGJKFFAI, bool NMPKNONCEJD, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x30A6930", Offset = "0x30A5D30", VA = "0x1830A6930", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69EA50", Offset = "0x69DE50")]
public class EHHLGHBCCAK<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LEOMHFBIHJC GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29C4970", Offset = "0x29C3D70", VA = "0x1829C4970")]
	public EHHLGHBCCAK(Vector3 NFDNJBLAHOL, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29C4900", Offset = "0x29C3D00", VA = "0x1829C4900", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MPPHCGGEJAB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly IEnumerable<TData> LOLBGJKFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly Vector3 NFDNJBLAHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x31B78A0", Offset = "0x31B6CA0", VA = "0x1831B78A0")]
	public MPPHCGGEJAB(IEnumerable<TData> LOLBGJKFFAI, Vector3 NFDNJBLAHOL, bool NMPKNONCEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PIMFCKHKCOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly IEnumerable<TData> LOLBGJKFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DC56B0", Offset = "0x2DC4AB0", VA = "0x182DC56B0")]
	public PIMFCKHKCOC(IEnumerable<TData> LOLBGJKFFAI, bool NMPKNONCEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LEOMHFBIHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly Vector3 NFDNJBLAHOL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xE0D930", Offset = "0xE0CD30", VA = "0x180E0D930")]
	public LEOMHFBIHJC(Vector3 NFDNJBLAHOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class EAGBCCNAJFG
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x672E150", Offset = "0x672D550", VA = "0x18672E150")]
	public static void PEJJGBPNLEF(IEnumerable NLKNKDBPBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2303930", Offset = "0x2302D30", VA = "0x182303930")]
	public static void PEJJGBPNLEF<T>(T[] EGIDMCNFHCK) where T : notnull
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
