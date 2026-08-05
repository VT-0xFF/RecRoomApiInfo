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
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
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
		[Cpp2IlInjected.Address(RVA = "0x6644560", Offset = "0x6643360", VA = "0x186644560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB9A310", Offset = "0xB99110", VA = "0x180B9A310")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GDCNPAGNGEN<TData> : FDDOLMGOBCI, global::BGKHJGNBCKK<TData>, global::BEAIFFNJAIL<TData>, global::LDCEJHPELPM<TData>, global::IGHBLMMNGLO<TData>, CLPKONIPHPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IGHBLMMNGLO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 LPHFKJJAHJH, Vector3 HHGBGELADCO, float EMEIKNNEGHK, out T IJJNEMICCBJ, out Vector3 BPJDKANIENA, out Collider BDNKKMLBEFO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 LPHFKJJAHJH, Vector3 HHGBGELADCO, float DMDKLJNGMGA, float EMEIKNNEGHK, T[] GNKGDAMOIDD, out Vector3 JFINHLLPMHN, out Collider PENGAMLKLGH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 LPHFKJJAHJH, float DMDKLJNGMGA, Vector3 LMMGBJPCMAB, T[] GNKGDAMOIDD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FDDOLMGOBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds IPCDKPBBFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform NFJJNGANFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds MINBPEOBONF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform ILDAJMPBBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 FPMGPOOPDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LDCEJHPELPM<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DOMEBKNNBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int NIFGCHCKGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> CKCBPOLJKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData CDHGABCIPJC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData CDHGABCIPJC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BGKHJGNBCKK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BLIKPCIFNNO, [Optional] MAKIJPKOCCA? FCFGABEKNGB, bool DHOLNJPLONG = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int PHHDFCFDFMP, IEnumerable<T> AEBOLACOCGH, bool DHOLNJPLONG = true);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int PHHDFCFDFMP, IEnumerable<T> AEBOLACOCGH, MAKIJPKOCCA FCFGABEKNGB, bool DHOLNJPLONG = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CLPKONIPHPE
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FINEIAMPGCF<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TNode IGHINPPPOEB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37C6D80", Offset = "0x37C5B80", VA = "0x1837C6D80")]
	public FINEIAMPGCF(TNode IGHINPPPOEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MDPGJBLGHJB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode AKDHALPKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public COMMOPLNNFN CPHLJCCCMFE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35E3A90", Offset = "0x35E2890", VA = "0x1835E3A90")]
	public MDPGJBLGHJB(TNode AKDHALPKNJO, COMMOPLNNFN CPHLJCCCMFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FBFNPDADHKN<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJIJIEAJABJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D0F0", Offset = "0x69C4F0")] in global::FINEIAMPGCF<TNode?> CHAGJFAGMKO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFFCMCHIKBP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D160", Offset = "0x69C560")] in global::MDPGJBLGHJB<TNode?> HIONMOKIJDP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CJJHPCCHNEO();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D1D0", Offset = "0x69C5D0")]
public class KOJEJOAEPLK<TNode> : global::DDFNJLCDLOA<global::FBFNPDADHKN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE6E20", VA = "0x181FE8020")]
	public KOJEJOAEPLK(global::FBFNPDADHKN<TNode> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2BC0", Offset = "0x2EF19C0", VA = "0x182EF2BC0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D240", Offset = "0x69C640")]
public class OHEJFKNEIGB<TNode> : global::DDFNJLCDLOA<global::FBFNPDADHKN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D2B0", Offset = "0x69C6B0")]
	private readonly global::MDPGJBLGHJB<TNode> HIONMOKIJDP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x36B84C0", Offset = "0x36B72C0", VA = "0x1836B84C0")]
	public OHEJFKNEIGB(TNode AKDHALPKNJO, COMMOPLNNFN CPHLJCCCMFE, global::FBFNPDADHKN<TNode> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36B83F0", Offset = "0x36B71F0", VA = "0x1836B83F0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D310", Offset = "0x69C710")]
public class KLDNCEALNEO<TNode> : global::DDFNJLCDLOA<global::FBFNPDADHKN<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D380", Offset = "0x69C780")]
	private readonly global::FINEIAMPGCF<TNode> CHAGJFAGMKO;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x272F130", Offset = "0x272DF30", VA = "0x18272F130")]
	public KLDNCEALNEO(TNode LMJNOHHCJNC, global::FBFNPDADHKN<TNode> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x272F070", Offset = "0x272DE70", VA = "0x18272F070", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ENAKGBEPHJL<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> OJFNNJKNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EKBCLDGILLP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x351F5D0", Offset = "0x351E3D0", VA = "0x18351F5D0")]
	public ENAKGBEPHJL(IEnumerable<TData> PEJGAPBIOBO, bool FDDBHCIIHCA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MHNGMDHCFMI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEJAAKMGLCA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D3E0", Offset = "0x69C7E0")] in global::ENAKGBEPHJL<TData?> POJACELJOBN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D450", Offset = "0x69C850")]
public class HMPEOPHHIJN<TData> : global::DDFNJLCDLOA<global::MHNGMDHCFMI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D4C0", Offset = "0x69C8C0")]
	private readonly global::ENAKGBEPHJL<TData> GCOMNGCIBJJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C6FB40", Offset = "0x2C6E940", VA = "0x182C6FB40")]
	public HMPEOPHHIJN(List<TData> EAGLPNMMNNI, bool EKBCLDGILLP, global::MHNGMDHCFMI<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F9E0", Offset = "0x2C6E7E0", VA = "0x182C6F9E0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CBLHFJPHMNK<TData> where TData : notnull, HDOGGOEFNIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> OJFNNJKNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public bool FMAHCIHJDAF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3566570", Offset = "0x3565370", VA = "0x183566570")]
	public CBLHFJPHMNK(IEnumerable<TData> PEJGAPBIOBO, bool GEEJENHGNOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ABOGNHEOEFM<TData> where TData : notnull, HDOGGOEFNIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public List<TData> OJFNNJKNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public List<bool> JPADDJGAOMF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C268E0", Offset = "0x2C256E0", VA = "0x182C268E0")]
	public ABOGNHEOEFM(List<TData> PEJGAPBIOBO, List<bool> FNJFDCOCDIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HDOGGOEFNIK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LGICLKILALD
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
public interface LBIEFCDGNKC<TData> where TData : HDOGGOEFNIK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLNAABKOMLL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C5C0", Offset = "0x69B9C0")] in global::CBLHFJPHMNK<TData> BPICCPGMKFJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLNAABKOMLL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C630", Offset = "0x69BA30")] in global::ABOGNHEOEFM<TData> BPICCPGMKFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C6A0", Offset = "0x69BAA0")]
public class BLMJBFOGCBH<TData> : global::DDFNJLCDLOA<global::LBIEFCDGNKC<TData>> where TData : notnull, HDOGGOEFNIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C710", Offset = "0x69BB10")]
	private readonly global::CBLHFJPHMNK<TData> BPICCPGMKFJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2985390", Offset = "0x2984190", VA = "0x182985390")]
	public BLMJBFOGCBH(List<TData> MDFBEMBBHPF, bool FMAHCIHJDAF, global::LBIEFCDGNKC<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x272F070", Offset = "0x272DE70", VA = "0x18272F070", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C770", Offset = "0x69BB70")]
public class MKACGENGDPB<TData> : global::DDFNJLCDLOA<global::LBIEFCDGNKC<TData>> where TData : notnull, HDOGGOEFNIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C7E0", Offset = "0x69BBE0")]
	private readonly global::ABOGNHEOEFM<TData> BPICCPGMKFJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x395FC80", Offset = "0x395EA80", VA = "0x18395FC80")]
	public MKACGENGDPB(List<TData> MDFBEMBBHPF, List<bool> JPADDJGAOMF, global::LBIEFCDGNKC<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x395FBB0", Offset = "0x395E9B0", VA = "0x18395FBB0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OKHCILHODFH : HDOGGOEFNIK
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DDFNJLCDLOA<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected TReceiver AKCEDGNFHHI;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B03EB0", Offset = "0x2B02CB0", VA = "0x182B03EB0")]
	public DDFNJLCDLOA(TReceiver AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NLNAABKOMLL();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BEAIFFNJAIL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHIGKEMMPKB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C880", Offset = "0x69BC80")] in global::GAONLPJNGDO<TData> POJACELJOBN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDGDBMOGAJH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C8F0", Offset = "0x69BCF0")] in global::GAONLPJNGDO<TData> POJACELJOBN);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEHBOHEMEMC(in bool FDPONLABNLC);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPLMPEMLBMH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C960", Offset = "0x69BD60")] in global::GAONLPJNGDO<TData> POJACELJOBN);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LEPAMAHDOMH();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NKGNAPPPNFI(TData JBOOMGAEPMK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69C9D0", Offset = "0x69BDD0")]
public class DKBABAEJBNK<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CA40", Offset = "0x69BE40")]
	private readonly global::GAONLPJNGDO<TData> POJACELJOBN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B12330", Offset = "0x2B11130", VA = "0x182B12330")]
	public DKBABAEJBNK(List<TData> EAGLPNMMNNI, global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x272F070", Offset = "0x272DE70", VA = "0x18272F070", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CAA0", Offset = "0x69BEA0")]
public class CFMPOJCPGFC<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE6E20", VA = "0x181FE8020")]
	public CFMPOJCPGFC(global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3579440", Offset = "0x3578240", VA = "0x183579440", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CB10", Offset = "0x69BF10")]
public class BIIGLFMAFBA<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool EKBCLDGILLP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2982A60", Offset = "0x2981860", VA = "0x182982A60")]
	public BIIGLFMAFBA(bool EKBCLDGILLP, global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29829F0", Offset = "0x29817F0", VA = "0x1829829F0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CB80", Offset = "0x69BF80")]
public class GGJJAPCOJMO<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CBF0", Offset = "0x69BFF0")]
	private readonly global::GAONLPJNGDO<TData> POJACELJOBN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E380", Offset = "0x3C1D180", VA = "0x183C1E380")]
	public GGJJAPCOJMO(List<TData> EAGLPNMMNNI, bool EKBCLDGILLP, global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x395FBB0", Offset = "0x395E9B0", VA = "0x18395FBB0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CC50", Offset = "0x69C050")]
public class JHHLFHBFPBG<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly TData JBOOMGAEPMK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F290", Offset = "0x2F4E090", VA = "0x182F4F290")]
	public JHHLFHBFPBG(TData JBOOMGAEPMK, global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F4F120", Offset = "0x2F4DF20", VA = "0x182F4F120", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CCC0", Offset = "0x69C0C0")]
public class LMBPIPFCMOO<TData> : global::DDFNJLCDLOA<global::BEAIFFNJAIL<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CD30", Offset = "0x69C130")]
	private readonly global::GAONLPJNGDO<TData> POJACELJOBN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x31912D0", Offset = "0x31900D0", VA = "0x1831912D0")]
	public LMBPIPFCMOO(List<TData> EAGLPNMMNNI, global::BEAIFFNJAIL<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3191170", Offset = "0x318FF70", VA = "0x183191170", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GAONLPJNGDO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public IEnumerable<TData> OJFNNJKNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool EKBCLDGILLP;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7760", Offset = "0x2DF6560", VA = "0x182DF7760")]
	public GAONLPJNGDO(IEnumerable<TData> PEJGAPBIOBO, bool FDDBHCIIHCA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface NHFBKFKHNDB<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLNAABKOMLL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CD90", Offset = "0x69C190")] in global::DBJEKJDDLGC<TData?> LDBLEHFMNJH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FJIJIEAJABJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CE00", Offset = "0x69C200")] in global::JNFDHDFICPD<TData?> MFOFMNEOLLD);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCBMGNOLHAK(in EJMPFMNJHFK KJJFIGDNLEO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFFCMCHIKBP();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CE70", Offset = "0x69C270")]
public class GIEKBJCHDBH<TData> : global::DDFNJLCDLOA<global::NHFBKFKHNDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CEE0", Offset = "0x69C2E0")]
	private readonly global::DBJEKJDDLGC<TData> LDBLEHFMNJH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C1F4B0", Offset = "0x3C1E2B0", VA = "0x183C1F4B0")]
	public GIEKBJCHDBH(IEnumerable<TData> MDFBEMBBHPF, Vector3 JHNKJDJICBB, bool EKBCLDGILLP, global::NHFBKFKHNDB<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x272F070", Offset = "0x272DE70", VA = "0x18272F070", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CF40", Offset = "0x69C340")]
public class PFHPEOFAJJK<TData> : global::DDFNJLCDLOA<global::NHFBKFKHNDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE6E20", VA = "0x181FE8020")]
	public PFHPEOFAJJK(global::NHFBKFKHNDB<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC320", Offset = "0x2ABB120", VA = "0x182ABC320", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69CFB0", Offset = "0x69C3B0")]
public class OPOKCLLFIBE<TData> : global::DDFNJLCDLOA<global::NHFBKFKHNDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D020", Offset = "0x69C420")]
	private readonly global::JNFDHDFICPD<TData> LDBLEHFMNJH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A309B0", Offset = "0x4A2F7B0", VA = "0x184A309B0")]
	public OPOKCLLFIBE(IEnumerable<TData> MDFBEMBBHPF, bool EKBCLDGILLP, global::NHFBKFKHNDB<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36B83F0", Offset = "0x36B71F0", VA = "0x1836B83F0", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x69D080", Offset = "0x69C480")]
public class GPOKMPDBCGP<TData> : global::DDFNJLCDLOA<global::NHFBKFKHNDB<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly EJMPFMNJHFK LDBLEHFMNJH;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D35080", Offset = "0x3D33E80", VA = "0x183D35080")]
	public GPOKMPDBCGP(Vector3 JHNKJDJICBB, global::NHFBKFKHNDB<TData> AKCEDGNFHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D35010", Offset = "0x3D33E10", VA = "0x183D35010", Slot = "4")]
	public override bool NLNAABKOMLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct DBJEKJDDLGC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly IEnumerable<TData> MDFBEMBBHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Vector3 JHNKJDJICBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly bool EKBCLDGILLP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B02C90", Offset = "0x2B01A90", VA = "0x182B02C90")]
	public DBJEKJDDLGC(IEnumerable<TData> MDFBEMBBHPF, Vector3 JHNKJDJICBB, bool EKBCLDGILLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JNFDHDFICPD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IEnumerable<TData> MDFBEMBBHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly bool EKBCLDGILLP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F63510", Offset = "0x2F62310", VA = "0x182F63510")]
	public JNFDHDFICPD(IEnumerable<TData> MDFBEMBBHPF, bool EKBCLDGILLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EJMPFMNJHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly Vector3 JHNKJDJICBB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73D750", Offset = "0x73C550", VA = "0x18073D750")]
	public EJMPFMNJHFK(Vector3 JHNKJDJICBB)
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
