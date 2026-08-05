using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LKNNDNPAAMM<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TPlayer GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNIJMCOOONC(in TObject LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMDOPNGNDGM(in TObject LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFEAHKEDLNP(in TObject LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJIIFOCOCHG(in TObject LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TPlayer AHLJJJICDDF(in TObject LGKNNMGLNIA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FAMFILCLBIN(in TObject LGKNNMGLNIA, TPlayer PAIIMNGOMFM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TSyncField KDFAGNALDEL(global::GFOJEHCBKMK<BEAFNHKLJOO> CBBOJGIJLHN, in TObject LGKNNMGLNIA, in TSyncFieldParam IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHCFBADACAC(in TSyncField IAHPHHNFGHI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDHGFAIAHEE(in TSyncField PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AIFBJHBPEIG<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEEJANMPNKK(in TRpcParam PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JJOHJGHOLNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BEAFNHKLJOO
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GMIAMPIHODH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> : IDisposable where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam> where TDeps : global::LKNNDNPAAMM<TObject, TPlayer, TRpcParam, TSyncField, TSyncFieldParam, TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps CLMOOCMNIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private global::BGKBNBCOCPB<JJOHJGHOLNH, global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver>> BBLCDPDFLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::BGKBNBCOCPB<BEAFNHKLJOO, global::GNIGBNCBFHE<TSyncField>> KBCFIIGIJJF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TPlayer GAMBFDBGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4084E80", Offset = "0x4083480", VA = "0x184084E80")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4084CE0", Offset = "0x40832E0", VA = "0x184084CE0")]
	public TSyncField FJALCNGJCPK(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40859F0", Offset = "0x4083FF0", VA = "0x1840859F0")]
	protected GMIAMPIHODH(in TDeps LCOMIHDGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4085920", Offset = "0x4083F20", VA = "0x184085920")]
	public static global::GMIAMPIHODH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> OJKIKDBCCPC(in TDeps LCOMIHDGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40844E0", Offset = "0x4082AE0", VA = "0x1840844E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4084200", Offset = "0x4082800", VA = "0x184084200")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG(in TObject LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4083C40", Offset = "0x4082240", VA = "0x184083C40")]
	public void BHHFEICBEND(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4084A60", Offset = "0x4083060", VA = "0x184084A60")]
	public void ENFJIGBIMBO(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40840C0", Offset = "0x40826C0", VA = "0x1840840C0")]
	public void CNIJMCOOONC(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40839A0", Offset = "0x4081FA0", VA = "0x1840839A0")]
	public void AMDOPNGNDGM(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4084160", Offset = "0x4082760", VA = "0x184084160")]
	public void DFEAHKEDLNP(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40849C0", Offset = "0x4082FC0", VA = "0x1840849C0")]
	public void EJIIFOCOCHG(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4084EE0", Offset = "0x40834E0", VA = "0x184084EE0")]
	public void HAEAAFAFGID(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4083820", Offset = "0x4081E20", VA = "0x184083820")]
	public TPlayer AHLJJJICDDF(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4084AF0", Offset = "0x40830F0", VA = "0x184084AF0")]
	public bool FAMFILCLBIN(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TPlayer PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40855B0", Offset = "0x4083BB0", VA = "0x1840855B0")]
	public global::GFOJEHCBKMK<BEAFNHKLJOO> KDFAGNALDEL(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TSyncFieldParam IAHPHHNFGHI)
	{
		return default(global::GFOJEHCBKMK<BEAFNHKLJOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4083D40", Offset = "0x4082340", VA = "0x184083D40")]
	public void CHCFBADACAC(global::GFOJEHCBKMK<BEAFNHKLJOO> DCOJPFADING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4084D00", Offset = "0x4083300", VA = "0x184084D00")]
	public void GONFONCILEI(global::GFOJEHCBKMK<BEAFNHKLJOO> PJGOPPMNMAI, in TSyncFieldValue MAKFNMHIJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver> where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly HashSet<global::GFOJEHCBKMK<BEAFNHKLJOO>> JDDHLINBLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TObject FKEJCFGNBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TRpcReceiver KAMLENNJIBI;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4404CE0", Offset = "0x44032E0", VA = "0x184404CE0")]
	private HCFHCDJCMHO(HashSet<global::GFOJEHCBKMK<BEAFNHKLJOO>> JAOCOFJMLML, in TObject LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4404C10", Offset = "0x4403210", VA = "0x184404C10")]
	public static global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver> OJKIKDBCCPC(in TObject LGKNNMGLNIA)
	{
		return default(global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class CGFJFPLJBDF<TRpcParam, TRpcReceiver> where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33197E0", Offset = "0x3317DE0", VA = "0x1833197E0")]
	public static global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver> OJKIKDBCCPC<TObject>(in TObject LGKNNMGLNIA)
	{
		return default(global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal struct GNIGBNCBFHE<TSyncField>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TSyncField PKHBIKJMMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly global::GFOJEHCBKMK<JJOHJGHOLNH> AEFECNLNCJI;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x40869C0", Offset = "0x4084FC0", VA = "0x1840869C0")]
	private GNIGBNCBFHE(in TSyncField AMOJNABADGD, global::GFOJEHCBKMK<JJOHJGHOLNH> GPNMCIKHCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40868B0", Offset = "0x4084EB0", VA = "0x1840868B0")]
	public static global::GNIGBNCBFHE<TSyncField> OJKIKDBCCPC(in TSyncField AMOJNABADGD, global::GFOJEHCBKMK<JJOHJGHOLNH> GPNMCIKHCOL)
	{
		return default(global::GNIGBNCBFHE<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KGAKDFEOPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x308FED0", Offset = "0x308E4D0", VA = "0x18308FED0")]
	public static global::GNIGBNCBFHE<TSyncField> OJKIKDBCCPC<TSyncField>(in TSyncField AMOJNABADGD, global::GFOJEHCBKMK<JJOHJGHOLNH> GPNMCIKHCOL)
	{
		return default(global::GNIGBNCBFHE<TSyncField>);
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
