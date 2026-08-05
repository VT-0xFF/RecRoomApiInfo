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
		[Cpp2IlInjected.Address(RVA = "0x35C8510", Offset = "0x35C6F10", VA = "0x1835C8510")]
		get
		{
			return (TPlayer)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35C8370", Offset = "0x35C6D70", VA = "0x1835C8370")]
	public TSyncField FJALCNGJCPK(global::GFOJEHCBKMK<BEAFNHKLJOO> AMOJNABADGD)
	{
		return (TSyncField)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35C9080", Offset = "0x35C7A80", VA = "0x1835C9080")]
	protected GMIAMPIHODH(in TDeps LCOMIHDGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35C8FB0", Offset = "0x35C79B0", VA = "0x1835C8FB0")]
	public static global::GMIAMPIHODH<TObject, TPlayer, TRpcParam, TRpcReceiver, TSyncField, TSyncFieldParam, TSyncFieldValue, TDeps> OJKIKDBCCPC(in TDeps LCOMIHDGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35C7B70", Offset = "0x35C6570", VA = "0x1835C7B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35C7890", Offset = "0x35C6290", VA = "0x1835C7890")]
	public global::GFOJEHCBKMK<JJOHJGHOLNH> DHFBPNPAJMG(in TObject LGKNNMGLNIA)
	{
		return default(global::GFOJEHCBKMK<JJOHJGHOLNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x35C72D0", Offset = "0x35C5CD0", VA = "0x1835C72D0")]
	public void BHHFEICBEND(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x35C80F0", Offset = "0x35C6AF0", VA = "0x1835C80F0")]
	public void ENFJIGBIMBO(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35C7750", Offset = "0x35C6150", VA = "0x1835C7750")]
	public void CNIJMCOOONC(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35C7030", Offset = "0x35C5A30", VA = "0x1835C7030")]
	public void AMDOPNGNDGM(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35C77F0", Offset = "0x35C61F0", VA = "0x1835C77F0")]
	public void DFEAHKEDLNP(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35C8050", Offset = "0x35C6A50", VA = "0x1835C8050")]
	public void EJIIFOCOCHG(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcParam IAHPHHNFGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35C8570", Offset = "0x35C6F70", VA = "0x1835C8570")]
	public void HAEAAFAFGID(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35C6EB0", Offset = "0x35C58B0", VA = "0x1835C6EB0")]
	public TPlayer AHLJJJICDDF(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA)
	{
		return (TPlayer)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35C8180", Offset = "0x35C6B80", VA = "0x1835C8180")]
	public bool FAMFILCLBIN(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TPlayer PAIIMNGOMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35C8C40", Offset = "0x35C7640", VA = "0x1835C8C40")]
	public global::GFOJEHCBKMK<BEAFNHKLJOO> KDFAGNALDEL(global::GFOJEHCBKMK<JJOHJGHOLNH> LGKNNMGLNIA, in TSyncFieldParam IAHPHHNFGHI)
	{
		return default(global::GFOJEHCBKMK<BEAFNHKLJOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35C73D0", Offset = "0x35C5DD0", VA = "0x1835C73D0")]
	public void CHCFBADACAC(global::GFOJEHCBKMK<BEAFNHKLJOO> DCOJPFADING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35C8390", Offset = "0x35C6D90", VA = "0x1835C8390")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AEDC10", Offset = "0x3AEC610", VA = "0x183AEDC10")]
	private HCFHCDJCMHO(HashSet<global::GFOJEHCBKMK<BEAFNHKLJOO>> JAOCOFJMLML, in TObject LGKNNMGLNIA, in TRpcReceiver JLNEPCPFMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDB40", Offset = "0x3AEC540", VA = "0x183AEDB40")]
	public static global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver> OJKIKDBCCPC(in TObject LGKNNMGLNIA)
	{
		return default(global::HCFHCDJCMHO<TObject, TRpcParam, TRpcReceiver>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class CGFJFPLJBDF<TRpcParam, TRpcReceiver> where TRpcReceiver : global::AIFBJHBPEIG<TRpcParam>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x254B060", Offset = "0x2549A60", VA = "0x18254B060")]
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
	[Cpp2IlInjected.Address(RVA = "0x35CA050", Offset = "0x35C8A50", VA = "0x1835CA050")]
	private GNIGBNCBFHE(in TSyncField AMOJNABADGD, global::GFOJEHCBKMK<JJOHJGHOLNH> GPNMCIKHCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35C9F40", Offset = "0x35C8940", VA = "0x1835C9F40")]
	public static global::GNIGBNCBFHE<TSyncField> OJKIKDBCCPC(in TSyncField AMOJNABADGD, global::GFOJEHCBKMK<JJOHJGHOLNH> GPNMCIKHCOL)
	{
		return default(global::GNIGBNCBFHE<TSyncField>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KGAKDFEOPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22A2600", Offset = "0x22A1000", VA = "0x1822A2600")]
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
