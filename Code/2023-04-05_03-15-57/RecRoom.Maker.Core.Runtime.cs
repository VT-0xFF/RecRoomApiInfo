using System;
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x66B2E30", Offset = "0x66B1E30", VA = "0x1866B2E30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6F0", Offset = "0x6F96F0", VA = "0x1806FA6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x929620", Offset = "0x928620", VA = "0x180929620")]
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
	[Cpp2IlInjected.Address(RVA = "0x2519FF0", Offset = "0x2518FF0", VA = "0x182519FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x379F420", Offset = "0x379E420", VA = "0x18379F420")]
	public JHGAPFFJIKO(TNode MIJLLFBOJPI, HLOBNKAHFPN NPLDKNNDEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EDBILEDNBDD<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEMPJOEKCOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0BD0", Offset = "0x69FFD0")] in global::OKACOCBGPBB<TNode?> IGIMHKJKKNC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMHJALFDIDG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0C40", Offset = "0x6A0040")] in global::JHGAPFFJIKO<TNode?> PDDPPELBLKA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PDKGAOMFGHP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0CB0", Offset = "0x6A00B0")]
public class CPPHKMKAJFN<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1102ED0", Offset = "0x1101ED0", VA = "0x181102ED0")]
	public CPPHKMKAJFN(global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x296C5C0", Offset = "0x296B5C0", VA = "0x18296C5C0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0D20", Offset = "0x6A0120")]
public class BMMJFMCACLB<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0D90", Offset = "0x6A0190")]
	private readonly global::JHGAPFFJIKO<TNode> PDDPPELBLKA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27F1EF0", Offset = "0x27F0EF0", VA = "0x1827F1EF0")]
	public BMMJFMCACLB(TNode MIJLLFBOJPI, HLOBNKAHFPN NPLDKNNDEKP, global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27F1E20", Offset = "0x27F0E20", VA = "0x1827F1E20", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0DF0", Offset = "0x6A01F0")]
public class JHNACLGOFDM<TNode> : global::FIHJGDLLCLO<global::EDBILEDNBDD<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0E60", Offset = "0x6A0260")]
	private readonly global::OKACOCBGPBB<TNode> IGIMHKJKKNC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x379F5C0", Offset = "0x379E5C0", VA = "0x18379F5C0")]
	public JHNACLGOFDM(TNode DINLEJJDNDK, global::EDBILEDNBDD<TNode> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28F8920", Offset = "0x28F7920", VA = "0x1828F8920", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x23C8C30", Offset = "0x23C7C30", VA = "0x1823C8C30")]
	public NKNIPJMPCCP(IEnumerable<TData> LOHPHEGKDLL, bool LKLIGMKNDAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JDKJFIPIEEM<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLNDMPPMHEH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0EC0", Offset = "0x6A02C0")] in global::NKNIPJMPCCP<TData?> GKFCAJPLJOH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0F30", Offset = "0x6A0330")]
public class MADDPKCEKAE<TData> : global::FIHJGDLLCLO<global::JDKJFIPIEEM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0FA0", Offset = "0x6A03A0")]
	private readonly global::NKNIPJMPCCP<TData> ELODOLLIHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A700", Offset = "0x3D89700", VA = "0x183D8A700")]
	public MADDPKCEKAE(List<TData> OBPNIKFBDBK, bool NMPKNONCEJD, global::JDKJFIPIEEM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A640", Offset = "0x3D89640", VA = "0x183D8A640", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x31D9B90", Offset = "0x31D8B90", VA = "0x1831D9B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EDC4F0", Offset = "0x2EDB4F0", VA = "0x182EDC4F0")]
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
	bool EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69FFF0", Offset = "0x69F3F0")] in global::MFEMKENJPHK<TData> PDEKCADJFGK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0060", Offset = "0x69F460")] in global::GOFPPLBDIAP<TData> PDEKCADJFGK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A00D0", Offset = "0x69F4D0")]
public class MIHNEHLAAFC<TData> : global::FIHJGDLLCLO<global::DJJFIBBBKJG<TData>> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0140", Offset = "0x69F540")]
	private readonly global::MFEMKENJPHK<TData> PDEKCADJFGK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7870", Offset = "0x3CD6870", VA = "0x183CD7870")]
	public MIHNEHLAAFC(List<TData> LOLBGJKFFAI, bool GIBGIFOMBFM, global::DJJFIBBBKJG<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28F8920", Offset = "0x28F7920", VA = "0x1828F8920", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A01A0", Offset = "0x69F5A0")]
public class MMCELNPJICI<TData> : global::FIHJGDLLCLO<global::DJJFIBBBKJG<TData>> where TData : notnull, BJDLMNFLKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0210", Offset = "0x69F610")]
	private readonly global::GOFPPLBDIAP<TData> PDEKCADJFGK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CDE5D0", Offset = "0x3CDD5D0", VA = "0x183CDE5D0")]
	public MMCELNPJICI(List<TData> LOLBGJKFFAI, List<bool> BLMDOGLPIJE, global::DJJFIBBBKJG<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x347C860", Offset = "0x347B860", VA = "0x18347C860", Slot = "4")]
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
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0270", Offset = "0x69F670")]
public abstract class FIHJGDLLCLO<TReceiver> : global::NDIJKMIFCFK<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1102ED0", Offset = "0x1101ED0", VA = "0x181102ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x23C0E90", Offset = "0x23BFE90", VA = "0x1823C0E90")]
	public NDIJKMIFCFK(TReceiver OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute EALHBJADKHF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CIEDBLKINJM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEGLMGHGIAI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0320", Offset = "0x69F720")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHDMJBNLKHO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0390", Offset = "0x69F790")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACBGNFIBKBI(in bool NEDBNAEGPKO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GDFAOHBJCDC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0400", Offset = "0x69F800")] in global::ECBIOFNPLIE<TData> GKFCAJPLJOH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIHOBBJOKMK();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GLEDLHEIAKI(TData GDPBJGJAHFE);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0470", Offset = "0x69F870")]
public class DJIEECGKCPI<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A04E0", Offset = "0x69F8E0")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x368FCB0", Offset = "0x368ECB0", VA = "0x18368FCB0")]
	public DJIEECGKCPI(List<TData> OBPNIKFBDBK, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28F8920", Offset = "0x28F7920", VA = "0x1828F8920", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0540", Offset = "0x69F940")]
public class FAEKMEJDKGE<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1102ED0", Offset = "0x1101ED0", VA = "0x181102ED0")]
	public FAEKMEJDKGE(global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41E72E0", Offset = "0x41E62E0", VA = "0x1841E72E0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A05B0", Offset = "0x69F9B0")]
public class IMMJBFFFLPN<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x11118E0", Offset = "0x11108E0", VA = "0x1811118E0")]
	public IMMJBFFFLPN(bool NMPKNONCEJD, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1111870", Offset = "0x1110870", VA = "0x181111870", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0620", Offset = "0x69FA20")]
public class PNACALJOCMM<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0690", Offset = "0x69FA90")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x347C930", Offset = "0x347B930", VA = "0x18347C930")]
	public PNACALJOCMM(List<TData> OBPNIKFBDBK, bool NMPKNONCEJD, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x347C860", Offset = "0x347B860", VA = "0x18347C860", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A06F0", Offset = "0x69FAF0")]
public class KFHFAADGOND<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly TData GDPBJGJAHFE;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x282B740", Offset = "0x282A740", VA = "0x18282B740")]
	public KFHFAADGOND(TData GDPBJGJAHFE, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x282B5A0", Offset = "0x282A5A0", VA = "0x18282B5A0", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0760", Offset = "0x69FB60")]
public class LACDMLBFMJH<TData> : global::FIHJGDLLCLO<global::CIEDBLKINJM<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A07D0", Offset = "0x69FBD0")]
	private readonly global::ECBIOFNPLIE<TData> GKFCAJPLJOH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x20A7930", Offset = "0x20A6930", VA = "0x1820A7930")]
	public LACDMLBFMJH(List<TData> OBPNIKFBDBK, global::CIEDBLKINJM<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x20A7860", Offset = "0x20A6860", VA = "0x1820A7860", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ECBIOFNPLIE<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<TData> BHPJJGGIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E047A0", Offset = "0x2E037A0", VA = "0x182E047A0")]
	public ECBIOFNPLIE(IEnumerable<TData> LOHPHEGKDLL, bool LKLIGMKNDAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JFHLDLJBDLA<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EALHBJADKHF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0870", Offset = "0x69FC70")] in global::MPPHCGGEJAB<TData?> GLAEIINKKOA);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DEMPJOEKCOL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A08E0", Offset = "0x69FCE0")] in global::PIMFCKHKCOC<TData?> PHGIODLOHMN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BHPBPBOEBGB(in LEOMHFBIHJC NDODKPGKGJE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMHJALFDIDG();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0950", Offset = "0x69FD50")]
public class GIALGHGHHBF<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A09C0", Offset = "0x69FDC0")]
	private readonly global::MPPHCGGEJAB<TData> GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28F8AC0", Offset = "0x28F7AC0", VA = "0x1828F8AC0")]
	public GIALGHGHHBF(IEnumerable<TData> LOLBGJKFFAI, Vector3 NFDNJBLAHOL, bool NMPKNONCEJD, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28F8920", Offset = "0x28F7920", VA = "0x1828F8920", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0A20", Offset = "0x69FE20")]
public class IHMJNNGPNBL<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1102ED0", Offset = "0x1101ED0", VA = "0x181102ED0")]
	public IHMJNNGPNBL(global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1102E70", Offset = "0x1101E70", VA = "0x181102E70", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0A90", Offset = "0x69FE90")]
public class MBLNMMANCBH<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0B00", Offset = "0x69FF00")]
	private readonly global::PIMFCKHKCOC<TData> GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x31CB080", Offset = "0x31CA080", VA = "0x1831CB080")]
	public MBLNMMANCBH(IEnumerable<TData> LOLBGJKFFAI, bool NMPKNONCEJD, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27F1E20", Offset = "0x27F0E20", VA = "0x1827F1E20", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A0B60", Offset = "0x69FF60")]
public class EHHLGHBCCAK<TData> : global::FIHJGDLLCLO<global::JFHLDLJBDLA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LEOMHFBIHJC GLAEIINKKOA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E16200", Offset = "0x2E15200", VA = "0x182E16200")]
	public EHHLGHBCCAK(Vector3 NFDNJBLAHOL, global::JFHLDLJBDLA<TData> OICNAHPNIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E16190", Offset = "0x2E15190", VA = "0x182E16190", Slot = "4")]
	public override bool EALHBJADKHF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MPPHCGGEJAB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly IEnumerable<TData> LOLBGJKFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 NFDNJBLAHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x356FAA0", Offset = "0x356EAA0", VA = "0x18356FAA0")]
	public MPPHCGGEJAB(IEnumerable<TData> LOLBGJKFFAI, Vector3 NFDNJBLAHOL, bool NMPKNONCEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PIMFCKHKCOC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IEnumerable<TData> LOLBGJKFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly bool NMPKNONCEJD;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B356F0", Offset = "0x2B346F0", VA = "0x182B356F0")]
	public PIMFCKHKCOC(IEnumerable<TData> LOLBGJKFFAI, bool NMPKNONCEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LEOMHFBIHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly Vector3 NFDNJBLAHOL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xE0C930", Offset = "0xE0B930", VA = "0x180E0C930")]
	public LEOMHFBIHJC(Vector3 NFDNJBLAHOL)
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
