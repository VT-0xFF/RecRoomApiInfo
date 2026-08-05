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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A6F060", Offset = "0x1A6E460", VA = "0x181A6F060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
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
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NGPNBIMAODH<TData> : FMFPOJJNDBH, global::GMGIACIBBND<TData>, global::OKOGCDNHAJG<TData>, global::AKFBLKGNFJL<TData>, global::NENBGMOKBCB<TData>
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NENBGMOKBCB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 NOKNCIPGLOJ, Vector3 GPCLDFNJCPC, float DODLNOOJAAB, out T HENHDFCOHOJ, out Vector3 FDPAPLPBBJP, out Collider LBABKFDBKDG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 NOKNCIPGLOJ, Vector3 GPCLDFNJCPC, float COFGOOEODPJ, float DODLNOOJAAB, T[] FPECDMOLGNB, out Vector3 OPHMIHIHNMO, out Collider FMDHMGJBCKI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 NOKNCIPGLOJ, float COFGOOEODPJ, Vector3 JFBKDOEBHNN, T[] FPECDMOLGNB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FMFPOJJNDBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds PPLDMEBPHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform GAJEHLJJODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds HINGHALKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform EMLIJFFNOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 PFJEEDOAFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AKFBLKGNFJL<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KJMLONCDEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int JLADPCOJJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> EGEGMOHAAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData GABBPODJMBM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GMGIACIBBND<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T JGHFLANLLNE, [Optional] DCLGFICIGHE? DBOMLKOOKNG, bool HHMJAIPFDCC = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int NDNADCNCIGM, IEnumerable<T> NBEDLAKOFBD, bool HHMJAIPFDCC = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int NDNADCNCIGM, IEnumerable<T> NBEDLAKOFBD, DCLGFICIGHE DBOMLKOOKNG, bool HHMJAIPFDCC = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AGLFNPJDPEA<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TNode CLANBLGGHIG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3222740", Offset = "0x3221B40", VA = "0x183222740")]
	public AGLFNPJDPEA(TNode CLANBLGGHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BNKLKMAHKLI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode BAJJOOJBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public FOGHDIDJABM LNAHCPHLEDF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31E6C90", Offset = "0x31E6090", VA = "0x1831E6C90")]
	public BNKLKMAHKLI(TNode BAJJOOJBJHP, FOGHDIDJABM LNAHCPHLEDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HGJOPACOELE<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ENPFFFJIEMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFC80", Offset = "0xFF080")] in global::AGLFNPJDPEA<TNode?> DAPIIBJPGJP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AKJGPMEJOGB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFCF0", Offset = "0xFF0F0")] in global::BNKLKMAHKLI<TNode?> INOHNKFOKHK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OMMOJNMFILF();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFD60", Offset = "0xFF160")]
public class GICBOPFFECJ<TNode> : global::LNLEAPJIGCO<global::HGJOPACOELE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27EBE60", Offset = "0x27EB260", VA = "0x1827EBE60")]
	public GICBOPFFECJ(global::HGJOPACOELE<TNode> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x339F880", Offset = "0x339EC80", VA = "0x18339F880", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFDD0", Offset = "0xFF1D0")]
public class BNDLKBALBDP<TNode> : global::LNLEAPJIGCO<global::HGJOPACOELE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFE40", Offset = "0xFF240")]
	private readonly global::BNKLKMAHKLI<TNode> INOHNKFOKHK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x31E3EB0", Offset = "0x31E32B0", VA = "0x1831E3EB0")]
	public BNDLKBALBDP(TNode BAJJOOJBJHP, FOGHDIDJABM LNAHCPHLEDF, global::HGJOPACOELE<TNode> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x31E3DE0", Offset = "0x31E31E0", VA = "0x1831E3DE0", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFEA0", Offset = "0xFF2A0")]
public class FLKAOKKOPBB<TNode> : global::LNLEAPJIGCO<global::HGJOPACOELE<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFF10", Offset = "0xFF310")]
	private readonly global::AGLFNPJDPEA<TNode> DAPIIBJPGJP;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E99830", Offset = "0x3E98C30", VA = "0x183E99830")]
	public FLKAOKKOPBB(TNode IBMCEEJHAMD, global::HGJOPACOELE<TNode> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x35153D0", Offset = "0x35147D0", VA = "0x1835153D0", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PGOGPMMKIGO<TData> where TData : notnull, PAMNFNHJEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> EHIBODNEMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BPCGPPJPMNH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43476B0", Offset = "0x4346AB0", VA = "0x1843476B0")]
	public PGOGPMMKIGO(IEnumerable<TData> KECACKHGIMJ, bool ALKIGFGPEFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FKDPBCMHNLN<TData> where TData : notnull, PAMNFNHJEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public List<TData> EHIBODNEMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public List<bool> MAIKJEMPAJG;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E947C0", Offset = "0x3E93BC0", VA = "0x183E947C0")]
	public FKDPBCMHNLN(List<TData> KECACKHGIMJ, List<bool> NCDJFDBFDFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PAMNFNHJEOF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GNFJPOOOFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IGNGAEAJMEI<TData> where TData : PAMNFNHJEOF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOMLBECGKNO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFF70", Offset = "0xFF370")] in global::PGOGPMMKIGO<TData> LPOKPJLAPBF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOMLBECGKNO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFFE0", Offset = "0xFF3E0")] in global::FKDPBCMHNLN<TData> LPOKPJLAPBF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x100050", Offset = "0xFF450")]
public class DFFFJAFGBAF<TData> : global::LNLEAPJIGCO<global::IGNGAEAJMEI<TData>> where TData : notnull, PAMNFNHJEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x1000C0", Offset = "0xFF4C0")]
	private readonly global::PGOGPMMKIGO<TData> LPOKPJLAPBF;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3515490", Offset = "0x3514890", VA = "0x183515490")]
	public DFFFJAFGBAF(List<TData> HIABBMOGMOA, bool BPCGPPJPMNH, global::IGNGAEAJMEI<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35153D0", Offset = "0x35147D0", VA = "0x1835153D0", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF660", Offset = "0xFEA60")]
public class FPDIFPDEMKO<TData> : global::LNLEAPJIGCO<global::IGNGAEAJMEI<TData>> where TData : notnull, PAMNFNHJEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF6D0", Offset = "0xFEAD0")]
	private readonly global::FKDPBCMHNLN<TData> LPOKPJLAPBF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D010", Offset = "0x3E9C410", VA = "0x183E9D010")]
	public FPDIFPDEMKO(List<TData> HIABBMOGMOA, List<bool> MAIKJEMPAJG, global::IGNGAEAJMEI<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2780", Offset = "0x2EA1B80", VA = "0x182EA2780", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NCLJNNKJCBG : PAMNFNHJEOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class LNLEAPJIGCO<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected TReceiver ILAEOFBGAHD;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3BF48E0", Offset = "0x3BF3CE0", VA = "0x183BF48E0")]
	public LNLEAPJIGCO(TReceiver ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DOMLBECGKNO();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKOGCDNHAJG<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHIJFLBKKOK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF770", Offset = "0xFEB70")] in global::PMKJENABOEF<TData> OCGCFEJKLIG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POIJKBNPGPF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF7E0", Offset = "0xFEBE0")] in global::PMKJENABOEF<TData> OCGCFEJKLIG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FADJJIHPCMA(in bool EHFPOJCNFGD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IEECGLOBCBJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF850", Offset = "0xFEC50")] in global::PMKJENABOEF<TData> OCGCFEJKLIG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJKODJALDDB();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FHGAEMJBAJP(TData NEOCMDGJANC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF8C0", Offset = "0xFECC0")]
public class KCFKHHBLHDJ<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF930", Offset = "0xFED30")]
	private readonly global::PMKJENABOEF<TData> OCGCFEJKLIG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39C2100", Offset = "0x39C1500", VA = "0x1839C2100")]
	public KCFKHHBLHDJ(List<TData> DGHKCMOGJPO, global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x35153D0", Offset = "0x35147D0", VA = "0x1835153D0", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFF990", Offset = "0xFED90")]
public class AABGCDOGJCL<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27EBE60", Offset = "0x27EB260", VA = "0x1827EBE60")]
	public AABGCDOGJCL(global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x493B260", Offset = "0x493A660", VA = "0x18493B260", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFA00", Offset = "0xFEE00")]
public class LEIBHNGPMAB<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly bool BIFNALBDBMC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C3E0", Offset = "0x2E9B7E0", VA = "0x182E9C3E0")]
	public LEIBHNGPMAB(bool BIFNALBDBMC, global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C370", Offset = "0x2E9B770", VA = "0x182E9C370", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFA70", Offset = "0xFEE70")]
public class LHNDFCKBFMI<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFAE0", Offset = "0xFEEE0")]
	private readonly global::PMKJENABOEF<TData> OCGCFEJKLIG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2EA28F0", Offset = "0x2EA1CF0", VA = "0x182EA28F0")]
	public LHNDFCKBFMI(List<TData> DGHKCMOGJPO, bool BIFNALBDBMC, global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2780", Offset = "0x2EA1B80", VA = "0x182EA2780", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFB40", Offset = "0xFEF40")]
public class OIOPACKEMDI<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TData NEOCMDGJANC;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CC76F0", Offset = "0x2CC6AF0", VA = "0x182CC76F0")]
	public OIOPACKEMDI(TData NEOCMDGJANC, global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7620", Offset = "0x2CC6A20", VA = "0x182CC7620", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFBB0", Offset = "0xFEFB0")]
public class HENMFAEBLKJ<TData> : global::LNLEAPJIGCO<global::OKOGCDNHAJG<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xFFC20", Offset = "0xFF020")]
	private readonly global::PMKJENABOEF<TData> OCGCFEJKLIG;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39C7A10", Offset = "0x39C6E10", VA = "0x1839C7A10")]
	public HENMFAEBLKJ(List<TData> DGHKCMOGJPO, global::OKOGCDNHAJG<TData> ILAEOFBGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39C7940", Offset = "0x39C6D40", VA = "0x1839C7940", Slot = "4")]
	public override bool DOMLBECGKNO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PMKJENABOEF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public IEnumerable<TData> EHIBODNEMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool BIFNALBDBMC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D70710", Offset = "0x3D6FB10", VA = "0x183D70710")]
	public PMKJENABOEF(IEnumerable<TData> KECACKHGIMJ, bool GAPOKCEHMLO = false)
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
