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
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA2270", Offset = "0xEA0A70", VA = "0x180EA2270")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F06F0", Offset = "0x6EEEF0", VA = "0x1806F06F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91F620", Offset = "0x91DE20", VA = "0x18091F620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ONHAGPMANON<TData> : FKOJFNIIJAM, global::BGCKKFJEGLD<TData>, global::MDNDDCDNIGA<TData>, global::IONEBBNDLFJ<TData>, global::LJFDCEINFCM<TData>
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LJFDCEINFCM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 INODPFILAHI, Vector3 ACGENMPHBIP, float DGBJANBPLCN, out T DBKNEOCEKNK, out Vector3 JJNNLOMIJPG, out Collider KNEOBBGNPAK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 INODPFILAHI, Vector3 ACGENMPHBIP, float BIEJJJHPDGK, float DGBJANBPLCN, T[] GGBGNHBAKCM, out Vector3 GGIFGAMHCPD, out Collider GIGNEAHONKC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 INODPFILAHI, float BIEJJJHPDGK, Vector3 NDBALGMBCCM, T[] GGBGNHBAKCM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FKOJFNIIJAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Bounds NODCJHNCFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Transform MFADFFHFFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Bounds KHGBAEHAHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Transform BHIPHGDIGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Vector3 HPAEOGBDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IONEBBNDLFJ<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DNOIJMEPBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int BNPLMCPGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<TData> NNMIJDNHKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData FNHAIFCEKHG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BGCKKFJEGLD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T BFHAMCLNCKB, [Optional] PBIKJFDGJLJ? KMBBOGPNPJD, bool GDCHGOGIEAO = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FCKFNIPNJCI, IEnumerable<T> MJNFLJIGHLN, bool GDCHGOGIEAO = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FCKFNIPNJCI, IEnumerable<T> MJNFLJIGHLN, PBIKJFDGJLJ KMBBOGPNPJD, bool GDCHGOGIEAO = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PBPLIKAKGEG<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TNode IHLEADHNLKL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F06CF0", Offset = "0x2F054F0", VA = "0x182F06CF0")]
	public PBPLIKAKGEG(TNode IHLEADHNLKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DHOFMAPBEHB<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public TNode EOJICMOFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ACAJEMELKAA CINLLPOIKHM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BB39A0", Offset = "0x2BB21A0", VA = "0x182BB39A0")]
	public DHOFMAPBEHB(TNode EOJICMOFAJM, ACAJEMELKAA CINLLPOIKHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ODAEMCDGNLC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMPMFIMEFIK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6996E0", Offset = "0x698AE0")] in global::PBPLIKAKGEG<TNode?> FBIDPGFOOOC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AIOGAGFMCLI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699750", Offset = "0x698B50")] in global::DHOFMAPBEHB<TNode?> PKHIFNFGLGK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANKHOCAOEMH();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6997C0", Offset = "0x698BC0")]
public class JDCHCPKCKPE<TNode> : global::PLNGDCAFFJM<global::ODAEMCDGNLC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1818FD0", Offset = "0x18177D0", VA = "0x181818FD0")]
	public JDCHCPKCKPE(global::ODAEMCDGNLC<TNode> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33FFDC0", Offset = "0x33FE5C0", VA = "0x1833FFDC0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699830", Offset = "0x698C30")]
public class HHEKKPHLJPD<TNode> : global::PLNGDCAFFJM<global::ODAEMCDGNLC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6998A0", Offset = "0x698CA0")]
	private readonly global::DHOFMAPBEHB<TNode> PKHIFNFGLGK;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3654530", Offset = "0x3652D30", VA = "0x183654530")]
	public HHEKKPHLJPD(TNode EOJICMOFAJM, ACAJEMELKAA CINLLPOIKHM, global::ODAEMCDGNLC<TNode> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3654460", Offset = "0x3652C60", VA = "0x183654460", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699900", Offset = "0x698D00")]
public class BCCLAMOJHLO<TNode> : global::PLNGDCAFFJM<global::ODAEMCDGNLC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699970", Offset = "0x698D70")]
	private readonly global::PBPLIKAKGEG<TNode> FBIDPGFOOOC;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D85630", Offset = "0x3D83E30", VA = "0x183D85630")]
	public BCCLAMOJHLO(TNode GMNFAMBPMBN, global::ODAEMCDGNLC<TNode> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25ED5D0", Offset = "0x25EBDD0", VA = "0x1825ED5D0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NGOCOGLKADL<TData> where TData : notnull, GPFBLKNCHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public IEnumerable<TData> KHHBCJKABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EAHJMBDIBIO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34C3950", Offset = "0x34C2150", VA = "0x1834C3950")]
	public NGOCOGLKADL(IEnumerable<TData> IPFBBKHNCME, bool PGKIJIDCMHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EAIOJKMPEPO<TData> where TData : notnull, GPFBLKNCHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public List<TData> KHHBCJKABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public List<bool> EADOEKIIGIF;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x261DD50", Offset = "0x261C550", VA = "0x18261DD50")]
	public EAIOJKMPEPO(List<TData> IPFBBKHNCME, List<bool> GHOLHNNIKGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GPFBLKNCHMC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CCEJMPEKJKN
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
public interface BPGJONOPFNA<TData> where TData : GPFBLKNCHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JHECMGPLBMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6999D0", Offset = "0x698DD0")] in global::NGOCOGLKADL<TData> OLNOPPELHKJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHECMGPLBMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699A40", Offset = "0x698E40")] in global::EAIOJKMPEPO<TData> OLNOPPELHKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699AB0", Offset = "0x698EB0")]
public class LEKOIEPFNEP<TData> : global::PLNGDCAFFJM<global::BPGJONOPFNA<TData>> where TData : notnull, GPFBLKNCHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699B20", Offset = "0x698F20")]
	private readonly global::NGOCOGLKADL<TData> OLNOPPELHKJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2CFD070", Offset = "0x2CFB870", VA = "0x182CFD070")]
	public LEKOIEPFNEP(List<TData> EPBNEGLCBCF, bool EAHJMBDIBIO, global::BPGJONOPFNA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25ED5D0", Offset = "0x25EBDD0", VA = "0x1825ED5D0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6990C0", Offset = "0x6984C0")]
public class BHAIKFHIEJB<TData> : global::PLNGDCAFFJM<global::BPGJONOPFNA<TData>> where TData : notnull, GPFBLKNCHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699130", Offset = "0x698530")]
	private readonly global::EAIOJKMPEPO<TData> OLNOPPELHKJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D21EA0", Offset = "0x3D206A0", VA = "0x183D21EA0")]
	public BHAIKFHIEJB(List<TData> EPBNEGLCBCF, List<bool> EADOEKIIGIF, global::BPGJONOPFNA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x32A50B0", Offset = "0x32A38B0", VA = "0x1832A50B0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KBIICFMEIGL : GPFBLKNCHMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class PLNGDCAFFJM<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected TReceiver ANJLMIKLNPJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3713F20", Offset = "0x3712720", VA = "0x183713F20")]
	public PLNGDCAFFJM(TReceiver ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JHECMGPLBMB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MDNDDCDNIGA<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOLKOEHMJPM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6991D0", Offset = "0x6985D0")] in global::PJNHEGIAMNM<TData> AGKEHOIOBDE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPBFCHHPADI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699240", Offset = "0x698640")] in global::PJNHEGIAMNM<TData> AGKEHOIOBDE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POFMJEDLMIM(in bool IGLOJLEPKBO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DEPCHJKPOMC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6992B0", Offset = "0x6986B0")] in global::PJNHEGIAMNM<TData> AGKEHOIOBDE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKHMGKKKOFD();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LLGKALJHOCL(TData MJNLNPIPDAN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699320", Offset = "0x698720")]
public class KBICPBKCBAN<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699390", Offset = "0x698790")]
	private readonly global::PJNHEGIAMNM<TData> AGKEHOIOBDE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x25ED690", Offset = "0x25EBE90", VA = "0x1825ED690")]
	public KBICPBKCBAN(List<TData> COFKFNBJGGD, global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25ED5D0", Offset = "0x25EBDD0", VA = "0x1825ED5D0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6993F0", Offset = "0x6987F0")]
public class PHACDBKLPND<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1818FD0", Offset = "0x18177D0", VA = "0x181818FD0")]
	public PHACDBKLPND(global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2F129D0", Offset = "0x2F111D0", VA = "0x182F129D0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699460", Offset = "0x698860")]
public class GEOGAOHNIMF<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly bool INGCHDLOLCL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2724680", Offset = "0x2722E80", VA = "0x182724680")]
	public GEOGAOHNIMF(bool INGCHDLOLCL, global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2724610", Offset = "0x2722E10", VA = "0x182724610", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6994D0", Offset = "0x6988D0")]
public class EDMHFOFMDFL<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699540", Offset = "0x698940")]
	private readonly global::PJNHEGIAMNM<TData> AGKEHOIOBDE;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x32A5220", Offset = "0x32A3A20", VA = "0x1832A5220")]
	public EDMHFOFMDFL(List<TData> COFKFNBJGGD, bool INGCHDLOLCL, global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x32A50B0", Offset = "0x32A38B0", VA = "0x1832A50B0", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6995A0", Offset = "0x6989A0")]
public class DFDHFOGHCLO<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TData MJNLNPIPDAN;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CD60", Offset = "0x3A8B560", VA = "0x183A8CD60")]
	public DFDHFOGHCLO(TData MJNLNPIPDAN, global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CC20", Offset = "0x3A8B420", VA = "0x183A8CC20", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699610", Offset = "0x698A10")]
public class JOCCGNKHFME<TData> : global::PLNGDCAFFJM<global::MDNDDCDNIGA<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x699680", Offset = "0x698A80")]
	private readonly global::PJNHEGIAMNM<TData> AGKEHOIOBDE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27E9C70", Offset = "0x27E8470", VA = "0x1827E9C70")]
	public JOCCGNKHFME(List<TData> COFKFNBJGGD, global::MDNDDCDNIGA<TData> ANJLMIKLNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27E9B10", Offset = "0x27E8310", VA = "0x1827E9B10", Slot = "4")]
	public override bool JHECMGPLBMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PJNHEGIAMNM<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public IEnumerable<TData> KHHBCJKABBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool INGCHDLOLCL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x370C2B0", Offset = "0x370AAB0", VA = "0x18370C2B0")]
	public PJNHEGIAMNM(IEnumerable<TData> IPFBBKHNCME, bool MJNAOKMHLBL = false)
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
