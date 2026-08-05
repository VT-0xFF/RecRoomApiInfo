using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBLDFABDFKL<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer KNPOIGBLIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIKMGGDENNN(in TObject KLDDDNGBABC, in TRpcParam BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBDBACEOEMF(in TObject KLDDDNGBABC, in TRpcParam BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAAKMAFLJFB(in TObject KLDDDNGBABC, in TRpcParam BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGPALIEGCLG(in TObject KLDDDNGBABC, in TRpcParam BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer GOJNGFIJPKH(in TObject KLDDDNGBABC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CHJPDFOADBJ(in TObject KLDDDNGBABC, in TPlayer JEKHMAKJKFG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField CECBEPLJCEG(in global::NIIAMMJDGBF<MIHFMOMICGO> CGOFEAKINMF, in TObject KLDDDNGBABC, in TSyncFieldParam BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GOODKPJFIHL(in TSyncField BMMKEAHNPAG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CIAMDOPBPOH(in TSyncField CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct LFIMOPGKNHA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct MIHFMOMICGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJBLHBACJBM<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable, global::ACOFMMOHBHI<global::NIIAMMJDGBF<LFIMOPGKNHA>, TPlayer, TRpcParam, TRpcReceiver, global::NIIAMMJDGBF<MIHFMOMICGO>, TSyncFieldParam, TSyncFieldValue> where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam> where TDeps : global::PBLDFABDFKL<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps OGLFLFKGHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly global::KLHNENCECOM<LFIMOPGKNHA, global::BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver>> OICNILMHECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly global::KLHNENCECOM<MIHFMOMICGO, global::MKAOALEBEPN<TSyncField>> LFHNJMAMCJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer KNPOIGBLIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3989C60", Offset = "0x3988860", VA = "0x183989C60", Slot = "5")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3989BD0", Offset = "0x39887D0", VA = "0x183989BD0")]
	public TSyncField IOLICAPPJND(global::NIIAMMJDGBF<MIHFMOMICGO> BFKMIBIIBHJ)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3989F40", Offset = "0x3988B40", VA = "0x183989F40")]
	protected BJBLHBACJBM(in TDeps HGEKHAPOBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39891A0", Offset = "0x3987DA0", VA = "0x1839891A0")]
	public static global::BJBLHBACJBM<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> EEJCKKCGPGE(in TDeps HGEKHAPOBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3988FD0", Offset = "0x3987BD0", VA = "0x183988FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3989D60", Offset = "0x3988960", VA = "0x183989D60")]
	public global::NIIAMMJDGBF<LFIMOPGKNHA> MOHGFODLLFP(in TObject KLDDDNGBABC)
	{
		return default(global::NIIAMMJDGBF<LFIMOPGKNHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x39899B0", Offset = "0x39885B0", VA = "0x1839899B0")]
	public void IAGJHGKMIGP(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39882D0", Offset = "0x3986ED0", VA = "0x1839882D0")]
	public void AEIJAJIMNEI(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3989E00", Offset = "0x3988A00", VA = "0x183989E00")]
	public void NIKMGGDENNN(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3988F30", Offset = "0x3987B30", VA = "0x183988F30")]
	public void DBDBACEOEMF(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3989EA0", Offset = "0x3988AA0", VA = "0x183989EA0")]
	public void OAAKMAFLJFB(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3989CC0", Offset = "0x39888C0", VA = "0x183989CC0")]
	public void MGPALIEGCLG(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3988390", Offset = "0x3986F90", VA = "0x183988390")]
	public void AJOBLHAFICK(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcReceiver MOPKGOJHCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3989410", Offset = "0x3988010", VA = "0x183989410")]
	public TPlayer GOJNGFIJPKH(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3988E30", Offset = "0x3987A30", VA = "0x183988E30")]
	public bool CHJPDFOADBJ(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TPlayer JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3988410", Offset = "0x3987010", VA = "0x183988410")]
	public global::NIIAMMJDGBF<MIHFMOMICGO> CECBEPLJCEG(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TSyncFieldParam BMMKEAHNPAG)
	{
		return default(global::NIIAMMJDGBF<MIHFMOMICGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3989750", Offset = "0x3988350", VA = "0x183989750")]
	public void GOODKPJFIHL(in global::NIIAMMJDGBF<MIHFMOMICGO> BHPPOABBADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3989310", Offset = "0x3987F10", VA = "0x183989310")]
	public void GKAHHMDKIIO(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x372A380", Offset = "0x3728F80", VA = "0x18372A380", Slot = "6")]
	private void BOOJKPDJPEF(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3989870", Offset = "0x3988470", VA = "0x183989870", Slot = "7")]
	private void HBOBBIHPAEP(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x372AA40", Offset = "0x3729640", VA = "0x18372AA40", Slot = "8")]
	private void KJIFDFDCHLM(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3729E40", Offset = "0x3728A40", VA = "0x183729E40", Slot = "9")]
	private void PJAHMPEFKFF(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcParam BMMKEAHNPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3988360", Offset = "0x3986F60", VA = "0x183988360", Slot = "10")]
	private void AJLBHHMOGEC(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TRpcReceiver MOPKGOJHCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3989C30", Offset = "0x3988830", VA = "0x183989C30", Slot = "11")]
	private TPlayer JLDKFOFFDDI(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x372A3B0", Offset = "0x3728FB0", VA = "0x18372A3B0", Slot = "12")]
	private bool LFCGPBDOENN(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TPlayer JEKHMAKJKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3989DD0", Offset = "0x39889D0", VA = "0x183989DD0", Slot = "13")]
	private global::NIIAMMJDGBF<MIHFMOMICGO> NBNAOPOBJLM(in global::NIIAMMJDGBF<LFIMOPGKNHA> KLDDDNGBABC, in TSyncFieldParam BMMKEAHNPAG)
	{
		return default(global::NIIAMMJDGBF<MIHFMOMICGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3989C00", Offset = "0x3988800", VA = "0x183989C00", Slot = "14")]
	private void IOPFNFJGBAE(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39883E0", Offset = "0x3986FE0", VA = "0x1839883E0", Slot = "15")]
	private void BJHDKJGILHC(in global::NIIAMMJDGBF<MIHFMOMICGO> CINGIEKIPNK, in TSyncFieldValue JHEBJPCMJGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal struct BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::NIIAMMJDGBF<MIHFMOMICGO>> HBLKANOOLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject CIIJJMGIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver HDIGENOCLHO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4010540", Offset = "0x400F140", VA = "0x184010540")]
	private BCGNEKGBAGF(HashSet<global::NIIAMMJDGBF<MIHFMOMICGO>> IELKCMPCODO, in TObject KLDDDNGBABC, in TRpcReceiver MOPKGOJHCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4010370", Offset = "0x400EF70", VA = "0x184010370")]
	public static global::BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver> EEJCKKCGPGE(in TObject KLDDDNGBABC)
	{
		return default(global::BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class JHDLLEHLMFG<TRpcParam, TRpcReceiver> where TRpcReceiver : global::CHCHKNIIJNE<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28A3C10", Offset = "0x28A2810", VA = "0x1828A3C10")]
	public static global::BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver> EEJCKKCGPGE<TObject>(in TObject KLDDDNGBABC)
	{
		return default(global::BCGNEKGBAGF<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct MKAOALEBEPN<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField PGEPPGOLOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::NIIAMMJDGBF<LFIMOPGKNHA> FODGPIPNJOP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D580", Offset = "0x3A3C180", VA = "0x183A3D580")]
	private MKAOALEBEPN(in TSyncField BFKMIBIIBHJ, in global::NIIAMMJDGBF<LFIMOPGKNHA> DJGLKDEDMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D480", Offset = "0x3A3C080", VA = "0x183A3D480")]
	public static global::MKAOALEBEPN<TSyncField> EEJCKKCGPGE(in TSyncField BFKMIBIIBHJ, global::NIIAMMJDGBF<LFIMOPGKNHA> DJGLKDEDMKK)
	{
		return default(global::MKAOALEBEPN<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class ILACAPENFFP
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27676C0", Offset = "0x27662C0", VA = "0x1827676C0")]
	public static global::MKAOALEBEPN<TSyncField> EEJCKKCGPGE<TSyncField>(in TSyncField BFKMIBIIBHJ, global::NIIAMMJDGBF<LFIMOPGKNHA> DJGLKDEDMKK)
	{
		return default(global::MKAOALEBEPN<TSyncField>);
	}
}
namespace Cpp2IlInjected;

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
