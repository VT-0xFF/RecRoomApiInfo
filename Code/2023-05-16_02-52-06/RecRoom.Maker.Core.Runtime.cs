using System;
using System.Collections;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B2C2E0", Offset = "0x6B2B0E0", VA = "0x186B2C2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AMDANOPCBND<TData> : EMJGOALAMDG, global::LFOLOHIJLDC<TData>, global::AACPLMMELBJ<TData>, global::BGMJGLOLHKO<TData>, JHPKLOCDKJM, global::MMCGIOLOHJE<TData>, FNCECONLMGN
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMCGIOLOHJE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 OBMFGFCEDPK, Vector3 DJIMPKHJJFP, float JOJDHMIFOPA, out T HKDOOPNEKEA, out Vector3 FCCGKBDBGNF, out Collider ECAPDAALHGO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 OBMFGFCEDPK, Vector3 DJIMPKHJJFP, float BJMLPBOFFKA, float JOJDHMIFOPA, T[] OFGIINLGODM, out Vector3 OOLKOANCGPL, out Collider JINOLLCGLJK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 OBMFGFCEDPK, float BJMLPBOFFKA, Vector3 JFEMBELHCCK, T[] OFGIINLGODM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMJGOALAMDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds EDBHOBDHNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform ACHOMHJFKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds LKKNAKCDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform FEEMCKEKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 AICAJKGHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BGMJGLOLHKO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NJAOLNONNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int FGJHKJMAGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> PIPPLOAJPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData PIBOOIGHJBI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData PIBOOIGHJBI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LFOLOHIJLDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T OJGAEOFIMPK, [Optional] NFGOLKNMBLF? BJJHMHPLIBG, bool BHLBPMJHMKO = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int MNBBKKLFBKD, IEnumerable<T> BFJIAFJFPDF, bool BHLBPMJHMKO = true);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int MNBBKKLFBKD, IEnumerable<T> BFJIAFJFPDF, NFGOLKNMBLF BJJHMHPLIBG, bool BHLBPMJHMKO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FNCECONLMGN
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JHPKLOCDKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool POJOLMDHLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HJBEKDMKMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CAANBNIFHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LBDHBOCDHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7980", Offset = "0x6F6D80")]
public abstract class KCIACMNHGIG<TReceiver> : global::COBFINPAGDD<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public KCIACMNHGIG(TReceiver FCIJEBBDABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F79F0", Offset = "0x6F6DF0")]
public abstract class KELKDNEFJAC<TReceiver, TFromTask> : global::COBFINPAGDD<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public KELKDNEFJAC(TReceiver FCIJEBBDABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class COBFINPAGDD<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected TReceiver FCIJEBBDABO;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32DBA80", Offset = "0x32DA880", VA = "0x1832DBA80")]
	public COBFINPAGDD(TReceiver FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute JBLEBGFLKBJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LBOANEIODBH<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode EDCODDOMHLB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28419A0", Offset = "0x28407A0", VA = "0x1828419A0")]
	public LBOANEIODBH(TNode EDCODDOMHLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AHJODOGGPGG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public TNode PLJPHLLAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public NBCEGCANABD OMKMFHDCPAA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33FD760", Offset = "0x33FC560", VA = "0x1833FD760")]
	public AHJODOGGPGG(TNode PLJPHLLAAEE, NBCEGCANABD OMKMFHDCPAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DHPHBIBCPOA<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAIHBKNCGCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5D90", Offset = "0x6F5190")] in global::LBOANEIODBH<TNode?> KLDBMDMGHGB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MODMGKHKGEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5E00", Offset = "0x6F5200")] in global::AHJODOGGPGG<TNode?> HOHJIDCFAON);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFLMEMFMJML();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5E70", Offset = "0x6F5270")]
public class PFELLJPKBPN<TNode> : global::KCIACMNHGIG<global::DHPHBIBCPOA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public PFELLJPKBPN(global::DHPHBIBCPOA<TNode> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x104CBB0", Offset = "0x104B9B0", VA = "0x18104CBB0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5EE0", Offset = "0x6F52E0")]
public class DJOOFLKPMDP<TNode> : global::KCIACMNHGIG<global::DHPHBIBCPOA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5F50", Offset = "0x6F5350")]
	private readonly global::AHJODOGGPGG<TNode> HOHJIDCFAON;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B13B10", Offset = "0x2B12910", VA = "0x182B13B10")]
	public DJOOFLKPMDP(TNode PLJPHLLAAEE, NBCEGCANABD OMKMFHDCPAA, global::DHPHBIBCPOA<TNode> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B13A40", Offset = "0x2B12840", VA = "0x182B13A40", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F5FB0", Offset = "0x6F53B0")]
public class HLEAEAFAGPH<TNode> : global::KCIACMNHGIG<global::DHPHBIBCPOA<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6020", Offset = "0x6F5420")]
	private readonly global::LBOANEIODBH<TNode> KLDBMDMGHGB;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35ECCE0", Offset = "0x35EBAE0", VA = "0x1835ECCE0")]
	public HLEAEAFAGPH(TNode CGEKCFAHEOJ, global::DHPHBIBCPOA<TNode> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OPFMKIHOFIC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IEnumerable<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x254AA50", Offset = "0x2549850", VA = "0x18254AA50")]
	public OPFMKIHOFIC(IEnumerable<TData> ILNCLJENEJB, bool AHACOJNMBGE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CCMGCCNAELP<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NCFLNOIOKBE> BBAGNEPMOCM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6080", Offset = "0x6F5480")] in global::OPFMKIHOFIC<TData> DCGEDGDGFJH, CancellationToken NBLKBHANAPP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F60F0", Offset = "0x6F54F0")]
public class FMEKDIKCAPN<TData> : global::KELKDNEFJAC<global::CCMGCCNAELP<TData>, NCFLNOIOKBE> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6160", Offset = "0x6F5560")]
	private readonly global::OPFMKIHOFIC<TData> CECEJNPKMGM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A71910", Offset = "0x2A70710", VA = "0x182A71910")]
	public FMEKDIKCAPN(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL, global::CCMGCCNAELP<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A71830", Offset = "0x2A70630", VA = "0x182A71830", Slot = "4")]
	public override Task<NCFLNOIOKBE> JBLEBGFLKBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GBHAKDGMNKH<TData> where TData : notnull, GEKANIIAOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public IEnumerable<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool PMFODHGMPMC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E670", Offset = "0x3C8D470", VA = "0x183C8E670")]
	public GBHAKDGMNKH(IEnumerable<TData> ILNCLJENEJB, bool ICMJKAGLGDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GOKNLPJPBJN<TData> where TData : notnull, GEKANIIAOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public List<bool> NPOHFIKCNEB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4792F90", Offset = "0x4791D90", VA = "0x184792F90")]
	public GOKNLPJPBJN(List<TData> ILNCLJENEJB, List<bool> KFAANIIEHEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GEKANIIAOHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NNPCOGHLJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DONLNNOFGCC<TData> where TData : GEKANIIAOHB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F61C0", Offset = "0x6F55C0")] in global::GBHAKDGMNKH<TData> OFKGAMDAOFM);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6230", Offset = "0x6F5630")] in global::GOKNLPJPBJN<TData> OFKGAMDAOFM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F62A0", Offset = "0x6F56A0")]
public class AFFDNNEKKKG<TData> : global::KCIACMNHGIG<global::DONLNNOFGCC<TData>> where TData : notnull, GEKANIIAOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6310", Offset = "0x6F5710")]
	private readonly global::GBHAKDGMNKH<TData> OFKGAMDAOFM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x33F3570", Offset = "0x33F2370", VA = "0x1833F3570")]
	public AFFDNNEKKKG(List<TData> JLCKEKEMPNL, bool PMFODHGMPMC, global::DONLNNOFGCC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6370", Offset = "0x6F5770")]
public class HANCANKFMHP<TData> : global::KCIACMNHGIG<global::DONLNNOFGCC<TData>> where TData : notnull, GEKANIIAOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F63E0", Offset = "0x6F57E0")]
	private readonly global::GOKNLPJPBJN<TData> OFKGAMDAOFM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE700", Offset = "0x3DAD500", VA = "0x183DAE700")]
	public HANCANKFMHP(List<TData> JLCKEKEMPNL, List<bool> NPOHFIKCNEB, global::DONLNNOFGCC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31BA6B0", Offset = "0x31B94B0", VA = "0x1831BA6B0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HPEENCEJEEB : GEKANIIAOHB
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EDMMLACCMII<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6440", Offset = "0x6F5840")] in global::HMMLFJODGPC<TData?> GPLLKMEALBI);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OCAFLNDCPLB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F64B0", Offset = "0x6F58B0")] in global::NDIDEDLJDKF<TData?> GPLLKMEALBI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EOMAMPKAMCC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FAAPNEHNGKF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6520", Offset = "0x6F5920")] in global::PDDOJOGHFOB<TData?> GPLLKMEALBI);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MODMGKHKGEI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6590", Offset = "0x6F5990")]
public class MNDLHNPDLKE<TData> : global::KCIACMNHGIG<global::EDMMLACCMII<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6600", Offset = "0x6F5A00")]
	private readonly global::HMMLFJODGPC<TData> GPLLKMEALBI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30D8DB0", Offset = "0x30D7BB0", VA = "0x1830D8DB0")]
	public MNDLHNPDLKE(IEnumerable<TData> JLCKEKEMPNL, IIGBEHGCPNH MHCJBLNNNKG, CDBIPHNIDEL ECFGNJLOODA, float BHKFANFPCNB, bool PFDGPONMIKL, global::EDMMLACCMII<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6660", Offset = "0x6F5A60")]
public class FLEOAOBPKNL<TData> : global::KCIACMNHGIG<global::OCAFLNDCPLB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F66D0", Offset = "0x6F5AD0")]
	private readonly global::NDIDEDLJDKF<TData> GPLLKMEALBI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A6E430", Offset = "0x2A6D230", VA = "0x182A6E430")]
	public FLEOAOBPKNL(TData[] JLCKEKEMPNL, IIGBEHGCPNH[] MHCJBLNNNKG, CDBIPHNIDEL[] ECFGNJLOODA, float[] BHKFANFPCNB, global::OCAFLNDCPLB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2001770", Offset = "0x2000570", VA = "0x182001770", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6730", Offset = "0x6F5B30")]
public class GIBGGCNICIO<TData> : global::KCIACMNHGIG<global::EOMAMPKAMCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public GIBGGCNICIO(global::EOMAMPKAMCC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x32D21E0", Offset = "0x32D0FE0", VA = "0x1832D21E0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F67A0", Offset = "0x6F5BA0")]
public class PEMNFDPEPIC<TData> : global::KCIACMNHGIG<global::EOMAMPKAMCC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6810", Offset = "0x6F5C10")]
	private readonly global::PDDOJOGHFOB<TData> GPLLKMEALBI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2001830", Offset = "0x2000630", VA = "0x182001830")]
	public PEMNFDPEPIC(IEnumerable<TData> JLCKEKEMPNL, IIGBEHGCPNH MHCJBLNNNKG, CDBIPHNIDEL ECFGNJLOODA, float BHKFANFPCNB, global::EOMAMPKAMCC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2001770", Offset = "0x2000570", VA = "0x182001770", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HMMLFJODGPC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IEnumerable<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public IIGBEHGCPNH MOOLLEIJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public CDBIPHNIDEL FLDPDFIKAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float BHKFANFPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35F29F0", Offset = "0x35F17F0", VA = "0x1835F29F0")]
	public HMMLFJODGPC(IEnumerable<TData> JLCKEKEMPNL, IIGBEHGCPNH MHCJBLNNNKG, CDBIPHNIDEL ECFGNJLOODA, float BHKFANFPCNB, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NDIDEDLJDKF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public TData[] FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IIGBEHGCPNH[] MOOLLEIJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CDBIPHNIDEL[] FLDPDFIKAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float[] BHKFANFPCNB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x31B04B0", Offset = "0x31AF2B0", VA = "0x1831B04B0")]
	public NDIDEDLJDKF(TData[] JLCKEKEMPNL, IIGBEHGCPNH[] MHCJBLNNNKG, CDBIPHNIDEL[] ECFGNJLOODA, float[] BHKFANFPCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PDDOJOGHFOB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IEnumerable<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IIGBEHGCPNH MOOLLEIJKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public CDBIPHNIDEL FLDPDFIKAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float BHKFANFPCNB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA2F0", Offset = "0x1FF90F0", VA = "0x181FFA2F0")]
	public PDDOJOGHFOB(IEnumerable<TData> JLCKEKEMPNL, IIGBEHGCPNH MHCJBLNNNKG, CDBIPHNIDEL ECFGNJLOODA, float BHKFANFPCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AACPLMMELBJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBJHCDPDJJL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6870", Offset = "0x6F5C70")] in global::ICEBLECCLJP<TData> DCGEDGDGFJH);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJANLKMACLE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F68E0", Offset = "0x6F5CE0")] in global::ICEBLECCLJP<TData> DCGEDGDGFJH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFAIIMFFMNB(in bool KNPLDKCJMMH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMDNLENHBIP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6950", Offset = "0x6F5D50")] in global::ICEBLECCLJP<TData> DCGEDGDGFJH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNPMFECGLCG();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FOJGABBLOKH(in TData NCPJANKJGHI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F69C0", Offset = "0x6F5DC0")]
public class OOJJMFICOFN<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6A30", Offset = "0x6F5E30")]
	private readonly global::ICEBLECCLJP<TData> DCGEDGDGFJH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25497D0", Offset = "0x25485D0", VA = "0x1825497D0")]
	public OOJJMFICOFN(List<TData> BFGFBJNNCDN, global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6A90", Offset = "0x6F5E90")]
public class HMLJMOCGGML<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public HMLJMOCGGML(global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x35F2750", Offset = "0x35F1550", VA = "0x1835F2750", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6B00", Offset = "0x6F5F00")]
public class PIONONGNNDL<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x200B570", Offset = "0x200A370", VA = "0x18200B570")]
	public PIONONGNNDL(bool PFDGPONMIKL, global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x200B500", Offset = "0x200A300", VA = "0x18200B500", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6B70", Offset = "0x6F5F70")]
public class NJGOFHFPFBN<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6BE0", Offset = "0x6F5FE0")]
	private readonly global::ICEBLECCLJP<TData> DCGEDGDGFJH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31BA780", Offset = "0x31B9580", VA = "0x1831BA780")]
	public NJGOFHFPFBN(List<TData> BFGFBJNNCDN, bool PFDGPONMIKL, global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31BA6B0", Offset = "0x31B94B0", VA = "0x1831BA6B0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6C40", Offset = "0x6F6040")]
public class DPNFMLBIHLF<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly TData NCPJANKJGHI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x419FBA0", Offset = "0x419E9A0", VA = "0x18419FBA0")]
	public DPNFMLBIHLF(TData NCPJANKJGHI, global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x419FA30", Offset = "0x419E830", VA = "0x18419FA30", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6CB0", Offset = "0x6F60B0")]
public class PJNONIDGEMH<TData> : global::KCIACMNHGIG<global::AACPLMMELBJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6D20", Offset = "0x6F6120")]
	private readonly global::ICEBLECCLJP<TData> DCGEDGDGFJH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20122A0", Offset = "0x20110A0", VA = "0x1820122A0")]
	public PJNONIDGEMH(List<TData> BFGFBJNNCDN, global::AACPLMMELBJ<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2012140", Offset = "0x2010F40", VA = "0x182012140", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ICEBLECCLJP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IEnumerable<TData> FNKBKLNEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DFF0C0", Offset = "0x1DFDEC0", VA = "0x181DFF0C0")]
	public ICEBLECCLJP(IEnumerable<TData> ILNCLJENEJB, bool AHACOJNMBGE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DABNPLDNMHC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAIHBKNCGCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6D80", Offset = "0x6F6180")] in global::EFBBDOALCKK<TData?> KLDBMDMGHGB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAPNEHNGKF(in ANLCMPJBJCL GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAAPNEHNGKF(in CAADCLLGGBB GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MODMGKHKGEI();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6DF0", Offset = "0x6F61F0")]
public class AAAJMIHLPFF<TData> : global::KCIACMNHGIG<global::DABNPLDNMHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public AAAJMIHLPFF(global::DABNPLDNMHC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B97910", Offset = "0x2B96710", VA = "0x182B97910", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6E60", Offset = "0x6F6260")]
public class LAOCMGPAEHP<TData> : global::KCIACMNHGIG<global::DABNPLDNMHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly ANLCMPJBJCL GGFCAODCJPM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2840FF0", Offset = "0x283FDF0", VA = "0x182840FF0")]
	public LAOCMGPAEHP(Vector3 HHJHEAKMBAC, bool CKEMPLKBKED, global::DABNPLDNMHC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2840F80", Offset = "0x283FD80", VA = "0x182840F80", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6ED0", Offset = "0x6F62D0")]
public class CILBFOHBDAP<TData> : global::KCIACMNHGIG<global::DABNPLDNMHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CAADCLLGGBB GGFCAODCJPM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DB95F0", Offset = "0x2DB83F0", VA = "0x182DB95F0")]
	public CILBFOHBDAP(Guid KFHFCKJGBHF, int NNHNOIMLALG, Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ, float JONJPBNIFLM, bool CKEMPLKBKED, global::DABNPLDNMHC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DB9580", Offset = "0x2DB8380", VA = "0x182DB9580", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6F40", Offset = "0x6F6340")]
public class CMPIEEKFMED<TData> : global::KCIACMNHGIG<global::DABNPLDNMHC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F6FB0", Offset = "0x6F63B0")]
	private readonly global::EFBBDOALCKK<TData> GGFCAODCJPM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x32D9A60", Offset = "0x32D8860", VA = "0x1832D9A60")]
	public CMPIEEKFMED(TData ONDHOAIGIEB, bool PFDGPONMIKL, global::DABNPLDNMHC<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ANLCMPJBJCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly Vector3 HHJHEAKMBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly bool CKEMPLKBKED;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BDE0", Offset = "0x6B2ABE0", VA = "0x186B2BDE0")]
	public ANLCMPJBJCL(Vector3 HHJHEAKMBAC, bool CKEMPLKBKED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CAADCLLGGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Guid KFHFCKJGBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly int NNHNOIMLALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly Vector3 DNPAJCANFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly Quaternion NNAIELBMKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float JONJPBNIFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly bool CKEMPLKBKED;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BE00", Offset = "0x6B2AC00", VA = "0x186B2BE00")]
	public CAADCLLGGBB(Guid KFHFCKJGBHF, int NNHNOIMLALG, Vector3 DNPAJCANFPF, Quaternion NNAIELBMKHJ, float JONJPBNIFLM, bool CKEMPLKBKED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EFBBDOALCKK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly TData ONDHOAIGIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3220030", Offset = "0x321EE30", VA = "0x183220030")]
	public EFBBDOALCKK(TData ONDHOAIGIEB, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KBKOHIOCGMB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7010", Offset = "0x6F6410")] in global::LOBANODHMCK<TData?> PAEOJOLKPMM);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IBLJPDPKCFD<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAIHBKNCGCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7080", Offset = "0x6F6480")] in global::MAFKPAGPBJK<TData?> IGJDJFKAJNG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAPNEHNGKF(in NBPHFOCKGNE GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MODMGKHKGEI();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F70F0", Offset = "0x6F64F0")]
public class LNNFGGFMHPG<TData> : global::KCIACMNHGIG<global::KBKOHIOCGMB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7160", Offset = "0x6F6560")]
	private readonly global::LOBANODHMCK<TData> PAEOJOLKPMM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A360", Offset = "0x3A99160", VA = "0x183A9A360")]
	public LNNFGGFMHPG(IEnumerable<TData> JLCKEKEMPNL, Vector3 EEPPPHJNPLB, bool PFDGPONMIKL, global::KBKOHIOCGMB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F71C0", Offset = "0x6F65C0")]
public class FHJBKNOFINC<TData> : global::KCIACMNHGIG<global::IBLJPDPKCFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public FHJBKNOFINC(global::IBLJPDPKCFD<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x104CBB0", Offset = "0x104B9B0", VA = "0x18104CBB0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7230", Offset = "0x6F6630")]
public class GBNLHPGFEHI<TData> : global::KCIACMNHGIG<global::IBLJPDPKCFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F72A0", Offset = "0x6F66A0")]
	private readonly global::MAFKPAGPBJK<TData> PAEOJOLKPMM;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3C941F0", Offset = "0x3C92FF0", VA = "0x183C941F0")]
	public GBNLHPGFEHI(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL, global::IBLJPDPKCFD<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7300", Offset = "0x6F6700")]
public class BMDGDEMIHIC<TData> : global::KCIACMNHGIG<global::IBLJPDPKCFD<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NBPHFOCKGNE PAEOJOLKPMM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1250", Offset = "0x2CA0050", VA = "0x182CA1250")]
	public BMDGDEMIHIC(Vector3 EEPPPHJNPLB, global::IBLJPDPKCFD<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2840F80", Offset = "0x283FD80", VA = "0x182840F80", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LOBANODHMCK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IEnumerable<TData> JLCKEKEMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly Vector3 EEPPPHJNPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CFF0", Offset = "0x3A9BDF0", VA = "0x183A9CFF0")]
	public LOBANODHMCK(IEnumerable<TData> JLCKEKEMPNL, Vector3 EEPPPHJNPLB, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct MAFKPAGPBJK<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly IEnumerable<TData> JLCKEKEMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x47741D0", Offset = "0x4772FD0", VA = "0x1847741D0")]
	public MAFKPAGPBJK(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct NBPHFOCKGNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly Vector3 EEPPPHJNPLB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xE73E90", Offset = "0xE72C90", VA = "0x180E73E90")]
	public NBPHFOCKGNE(Vector3 EEPPPHJNPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface EHEMGGKGING<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JBLEBGFLKBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7370", Offset = "0x6F6770")] in global::OLLEABLJGCG<TData?> KFAJFBHDDPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LBINPJBIKKG<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAIHBKNCGCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F73E0", Offset = "0x6F67E0")] in global::OCJAOFNIANM<TData?> KLDBMDMGHGB);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAPNEHNGKF(in GAHLNMNJICL GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MODMGKHKGEI();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7450", Offset = "0x6F6850")]
public class PDINDMANPDI<TData> : global::KCIACMNHGIG<global::EHEMGGKGING<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F74C0", Offset = "0x6F68C0")]
	private readonly global::OLLEABLJGCG<TData> KFAJFBHDDPJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA900", Offset = "0x1FF9700", VA = "0x181FFA900")]
	public PDINDMANPDI(IEnumerable<TData> JLCKEKEMPNL, Quaternion EEPPPHJNPLB, Vector3? BPCHKMOJEKF, bool FIKFNLFMCEN, bool PFDGPONMIKL, global::EHEMGGKGING<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7520", Offset = "0x6F6920")]
public class EMMEKDHCGCB<TData> : global::KCIACMNHGIG<global::LBINPJBIKKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public EMMEKDHCGCB(global::LBINPJBIKKG<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x104CBB0", Offset = "0x104B9B0", VA = "0x18104CBB0", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7590", Offset = "0x6F6990")]
public class MOADLBMIGLC<TData> : global::KCIACMNHGIG<global::LBINPJBIKKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7600", Offset = "0x6F6A00")]
	private readonly global::OCJAOFNIANM<TData> KFAJFBHDDPJ;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30D91F0", Offset = "0x30D7FF0", VA = "0x1830D91F0")]
	public MOADLBMIGLC(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL, global::LBINPJBIKKG<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7660", Offset = "0x6F6A60")]
public class MIMKLKHNNNI<TData> : global::KCIACMNHGIG<global::LBINPJBIKKG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GAHLNMNJICL KFAJFBHDDPJ;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30D0DF0", Offset = "0x30CFBF0", VA = "0x1830D0DF0")]
	public MIMKLKHNNNI(Quaternion EEPPPHJNPLB, Vector3? BPCHKMOJEKF, bool FIKFNLFMCEN, global::LBINPJBIKKG<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2840F80", Offset = "0x283FD80", VA = "0x182840F80", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct OLLEABLJGCG<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly IEnumerable<TData> JLCKEKEMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly Quaternion EEPPPHJNPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3? BPCHKMOJEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool FIKFNLFMCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2543F90", Offset = "0x2542D90", VA = "0x182543F90")]
	public OLLEABLJGCG(IEnumerable<TData> JLCKEKEMPNL, Quaternion EEPPPHJNPLB, Vector3? BPCHKMOJEKF, bool FIKFNLFMCEN, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct OCJAOFNIANM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IEnumerable<TData> JLCKEKEMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B402F0", Offset = "0x3B3F0F0", VA = "0x183B402F0")]
	public OCJAOFNIANM(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GAHLNMNJICL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Quaternion EEPPPHJNPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly Vector3? BPCHKMOJEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool FIKFNLFMCEN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x578ED70", Offset = "0x578DB70", VA = "0x18578ED70")]
	public GAHLNMNJICL(Quaternion EEPPPHJNPLB, Vector3? BPCHKMOJEKF, bool FIKFNLFMCEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface LJILKOFILPB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAIHBKNCGCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F76D0", Offset = "0x6F6AD0")] in global::GNPILOEMENL<TData?> KLDBMDMGHGB);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FAAPNEHNGKF(in EFPGHFDNHIG GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAAPNEHNGKF(in CBKNAAIICDP GIFJKDKIDFH);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MODMGKHKGEI();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7740", Offset = "0x6F6B40")]
public class COHOGLDMLDM<TData> : global::KCIACMNHGIG<global::LJILKOFILPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly CBKNAAIICDP PCCLNGPGKEG;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32DC310", Offset = "0x32DB110", VA = "0x1832DC310")]
	public COHOGLDMLDM(Vector3 PHDDPAOFMFM, float LPOEOCLIKMH, Vector3 BPCHKMOJEKF, bool HINCAGCBFIC, global::LJILKOFILPB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB9580", Offset = "0x2DB8380", VA = "0x182DB9580", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F77B0", Offset = "0x6F6BB0")]
public class CFMKDNLKDHA<TData> : global::KCIACMNHGIG<global::LJILKOFILPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10")]
	public CFMKDNLKDHA(global::LJILKOFILPB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B97910", Offset = "0x2B96710", VA = "0x182B97910", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7820", Offset = "0x6F6C20")]
public class CDEJNJOBJBE<TData> : global::KCIACMNHGIG<global::LJILKOFILPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F7890", Offset = "0x6F6C90")]
	private readonly global::GNPILOEMENL<TData> PCCLNGPGKEG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x316D4E0", Offset = "0x316C2E0", VA = "0x18316D4E0")]
	public CDEJNJOBJBE(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL, global::LJILKOFILPB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA730", Offset = "0x1FF9530", VA = "0x181FFA730", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6F78F0", Offset = "0x6F6CF0")]
public class EBEGOJOJDKP<TData> : global::KCIACMNHGIG<global::LJILKOFILPB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EFPGHFDNHIG PCCLNGPGKEG;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x364BFA0", Offset = "0x364ADA0", VA = "0x18364BFA0")]
	public EBEGOJOJDKP(float LPOEOCLIKMH, Vector3 BPCHKMOJEKF, global::LJILKOFILPB<TData> FCIJEBBDABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2840F80", Offset = "0x283FD80", VA = "0x182840F80", Slot = "4")]
	public override bool JBLEBGFLKBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct CBKNAAIICDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly Vector3 PHDDPAOFMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly float LPOEOCLIKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Vector3 BPCHKMOJEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly bool CKEMPLKBKED;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BE40", Offset = "0x6B2AC40", VA = "0x186B2BE40")]
	public CBKNAAIICDP(Vector3 PHDDPAOFMFM, float LPOEOCLIKMH, Vector3 BPCHKMOJEKF, bool CKEMPLKBKED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct GNPILOEMENL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly IEnumerable<TData> JLCKEKEMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool PFDGPONMIKL;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4791FF0", Offset = "0x4790DF0", VA = "0x184791FF0")]
	public GNPILOEMENL(IEnumerable<TData> JLCKEKEMPNL, bool PFDGPONMIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct EFPGHFDNHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float LPOEOCLIKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly Vector3 BPCHKMOJEKF;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x577C100", Offset = "0x577AF00", VA = "0x18577C100")]
	public EFPGHFDNHIG(float LPOEOCLIKMH, Vector3 BPCHKMOJEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MJICENIHDGI
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static GMLHNNIDAIC? APKLODLMDMJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	internal static GMLHNNIDAIC GKFOBOEAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6B2C0E0", Offset = "0x6B2AEE0", VA = "0x186B2C0E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B2C210", Offset = "0x6B2B010", VA = "0x186B2C210")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static CancellationToken BPEOEBDKKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6B2C170", Offset = "0x6B2AF70", VA = "0x186B2C170")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C260", Offset = "0x6B2B060", VA = "0x186B2C260")]
	[CFDOMFEMHNO(LLLAACKFLBA.Room, ANAFFCEINAM.None)]
	private static void KLALIAONMAF(GMLHNNIDAIC PMCFHJPIPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GGKAMBAGIIK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum NKAJBIOJKLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x208EC00", Offset = "0x208DA00", VA = "0x18208EC00")]
	public static void MLNEIGPPJOK<T>(T DMDACHFLMCK, NKAJBIOJKLI LEDIIMFEFLP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x208EDA0", Offset = "0x208DBA0", VA = "0x18208EDA0")]
	public static void MLNEIGPPJOK<T>(T DMDACHFLMCK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x208EB20", Offset = "0x208D920", VA = "0x18208EB20")]
	public static T BANNGLOAJDI<T>(NKAJBIOJKLI LEDIIMFEFLP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x208EBC0", Offset = "0x208D9C0", VA = "0x18208EBC0")]
	public static T BANNGLOAJDI<T>() where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class COOBFHGNPPM
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BE70", Offset = "0x6B2AC70", VA = "0x186B2BE70")]
	public static void HPECDMCFADP(IEnumerable LAPHJEMBCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22AA460", Offset = "0x22A9260", VA = "0x1822AA460")]
	public static void HPECDMCFADP<T>(T[] PALKODKBAJM) where T : notnull
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
