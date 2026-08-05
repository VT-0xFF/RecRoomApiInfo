using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.DataLayer.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x795DB70", Offset = "0x795C570", VA = "0x18795DB70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FMJMJKOAMFI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum CFECPDLFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string PLJKFBEPIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HMDDDEADNFN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CFECPDLFLMH NIBFJDCEAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(CFECPDLFLMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JADOKCAOJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23D16B0", Offset = "0x23D00B0", VA = "0x1823D16B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BEFGJEABBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A99850", Offset = "0x1A98250", VA = "0x181A99850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79593B0", Offset = "0x7957DB0", VA = "0x1879593B0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FMJMJKOAMFI ANDPHKADADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7959410", Offset = "0x7957E10", VA = "0x187959410")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static FMJMJKOAMFI LOIAEKDHOBA([Optional] string ENPOCPFPLGO, [Optional] string PEDNLFPNKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FMJMJKOAMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NDEBENMBGIO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string CBEHNNBCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string ELMFOJFBBON
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FDPIJCLDDDL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NDEBENMBGIO> IJNPCPOJFHG(string ILHBIPCPNKK, string JMMIJOBFAPH, string CGPFDODFOOL, VoiceOption JDFDIABHFMB, string? LDNCOAJNKKO, float MPCAADCMDJI, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EIMOPKCOAGH : FDPIJCLDDDL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AAJLCGGADDE? ACENPJLKKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AHDLCNFLGGK<MNHJJAPIHEA> FGGDFHAAONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AHDLCNFLGGK<PCFIAJBHKHG> CJHOODFICNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AHDLCNFLGGK<CFFHIGCOICE> NOEOGFFOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EBDGCEEEFPM LENDFEHIKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCCGOIBALIC();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GKNHKNCNHCH<byte>> BNDOKBNMBFL(string LJJHGOFCFDE, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<JLBJIODKMGG> FGCDCPLFEBN(bool OMAPMCDLEGI, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<FCGNLEDIIPA<LFLKCJBNAHK>> GGPABHGMHIL(bool HFEPLEDAGIO = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<JLBJIODKMGG> IDCDOELEKME(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IHPFBOBMIJI<IHINEBFOCKN>> LEEMDBOKDIL(long GDCAPMONNDM, bool NDJAJNFNLMD = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<JKALFADFGCO> HNPJDHHLHJE([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<JKALFADFGCO> NMBIKIJGFPI(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<JKEJHLKFOBK> JHNILEIFEJI(bool NDJAJNFNLMD = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<FMOLAOBEJCF> AFDJHJDHDNC([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<JLBJIODKMGG> OJDPMPKBMKN(bool NDJAJNFNLMD = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<JLBJIODKMGG> BEDFDOMKOHJ([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<JLBJIODKMGG> NENHJBEBCGH(string ILHBIPCPNKK, Guid ILMHMCLGFKA, long GDCAPMONNDM, long AFCPIMKFDHC, decimal JCBKLKAAAII, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<FCGNLEDIIPA<LFLKCJBNAHK>> PEAOIGEHNCA(Guid ILMHMCLGFKA, long GDCAPMONNDM, long AFCPIMKFDHC, decimal JCBKLKAAAII, byte JBOCPDMBOJB, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DPABMGJLGFA(string MEDJNHBKECM, string JIEMNLBLGAP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<POMNPKEOPAI> ENFENOOMHKB(string JMMIJOBFAPH, string LGEEHAKHGNN, bool HHPJGLOFKLO, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<CFFHIGCOICE> LINEPIGIABA(long GDCAPMONNDM, string ANCCKKAOPHF, string CDLCGIGHGJP, string LGEEHAKHGNN, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<CFFHIGCOICE> FBPGMJGKDBP(long OOLNKBEPLKK, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<KAMJNOEJBBA> BBIDFBLIONE(string? JMMIJOBFAPH, string LGEEHAKHGNN, string CGPNBEBFGEL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<KAMJNOEJBBA> BBIDFBLIONE(string? JMMIJOBFAPH, string LGEEHAKHGNN, byte[] LKBLIOOCLMO, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<KAMJNOEJBBA> OENDJAHBLBI(long GDCAPMONNDM, string? JMMIJOBFAPH, string LGEEHAKHGNN, string CGPNBEBFGEL, float? MPCAADCMDJI, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<KAMJNOEJBBA> OENDJAHBLBI(long GDCAPMONNDM, string? JMMIJOBFAPH, string LGEEHAKHGNN, byte[] LKBLIOOCLMO, float? MPCAADCMDJI, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<POMNPKEOPAI> HAGKOOHOGEC(long GDCAPMONNDM, JMGGEDKFBOM KGHMNJMLIBE, byte[] LKBLIOOCLMO, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<POMNPKEOPAI> HPCMAMAEGFD(JMGGEDKFBOM KGHMNJMLIBE, string ANCCKKAOPHF, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<POMNPKEOPAI> CHKHMKNGFGJ(long GDCAPMONNDM, string? JMMIJOBFAPH, string LGEEHAKHGNN, bool HHPJGLOFKLO, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<OJHFOIJJHPG> KLHMGMOFCPG(string LGEEHAKHGNN, int NDKGEJPCLBH, string OCOFHALKGAA, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<OJHFOIJJHPG> KPOKJEKMBDF(string LGEEHAKHGNN, int NDKGEJPCLBH, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<CMIFHHGCAPB> KEOLEKGBOGL(string? JMMIJOBFAPH, string LGEEHAKHGNN, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<AAJLCGGADDE> JMHMOHCLOOG(string LGEEHAKHGNN, OFMIDCCPHGM? HPGLBDINAFO, IReadOnlyList<OFMIDCCPHGM>? IGNOOJFKFBO, IReadOnlyList<string> PIJDIBMKEPE, ANFAKHIIDHK OINEAODAACF, [Optional] string? HFFNEEMAABM, [Optional] string? AHBGMMCIKMF, [Optional] string? COMHENHFILL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<AAJLCGGADDE> EIBNMOHABCH(string DDFEAKLIDDG, OFMIDCCPHGM? HPGLBDINAFO, IReadOnlyList<string> PIJDIBMKEPE, ANFAKHIIDHK OINEAODAACF, [Optional] string? AHBGMMCIKMF, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<List<string>> DLIKIPGCICK(string LGEEHAKHGNN, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<string> CKOEOPLMNOH(ANFAKHIIDHK OINEAODAACF, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task ADBLFIJKPNP(string GHANLDMHBLD, VoiceOption JDFDIABHFMB, string? CGPFDODFOOL, Action<string> AODAFFDGAHB, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<string> CLGCGNKNOGL(ReadOnlyMemory<byte> IMFLGGHCLAF, int MCAKEJBBCAG, int HGCOIPKMAAD, string IJNPIDPIBFP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<PBFLCJHJGNG> MLIGDJNFLMC(List<CEEOAHIBCHO> AIIOACFDGIM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<PBFLCJHJGNG> BIGGGFGKIDH([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<bool> HEFLDJKHMFO(string FALJCHJDPBE, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task JGOPPDJNLAO(string KKNBBHBHLCJ, EPGFBBKIGOI PEOOMOJFLJI, string AKEJFNGKBEL, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task JKKJOBPEOMF(string KKNBBHBHLCJ, string GNLOBFABEGI, string EKMCEDIJMDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<LANLKNMKDGO> JANEJAGCBCE(string KKNBBHBHLCJ, string IJNPIDPIBFP, [Optional] string? JMMIJOBFAPH, [Optional] float? MPCAADCMDJI, [Optional] HIJPBOEHCOE? EKLAOFBEFHD, [Optional] IReadOnlyCollection<HIJPBOEHCOE>? MBIGEOPOHBI, PFKIONNDEEB LFFDLFADFLN = PFKIONNDEEB.Auto, [Optional] string? EKKHDFLHOBA, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OANEKPHLJMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string MKIAGOIBBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string PEOFFBAPCHM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string LEANCNDFOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string LBNIANOPBMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string CHNDDCGJPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string GLEIPOBHGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? JMJBKDDJAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? MNNOPFMAFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x795DD20", Offset = "0x795C720", VA = "0x18795DD20")]
	public OANEKPHLJMK(string PDCEPFLECJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x795DCF0", Offset = "0x795C6F0", VA = "0x18795DCF0")]
	public void PGGGENJHPLN(string OPHHAPPLNGI = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x795DBF0", Offset = "0x795C5F0", VA = "0x18795DBF0")]
	private void JCFLLFEIOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KEJOCEMCOHO
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EPDJAOACKCO OHNCNOENLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HLHOHLGPEEO> POJJGCCPGBD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BBHLDELEIHC> LJEINEDPCGF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BBHLDELEIHC> ACINCBLHNCP(bool KEDBDJKEGJP = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFBLMFBPMAC([Out] BBHLDELEIHC CJFGGLCCOHC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NPAOIGADHII
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x795D990", Offset = "0x795C390", VA = "0x18795D990")]
	public static bool AFKIDGMJDOL(this KEJOCEMCOHO EOEAKDKKPDD, [Out] HLHOHLGPEEO FEJEFMCDPJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x795DA80", Offset = "0x795C480", VA = "0x18795DA80")]
	public static bool NODKEPHAOIK(this KEJOCEMCOHO EOEAKDKKPDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KNNJHDJBOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task APADDFOINFO(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNANJPOBDHI(int JBOKKGAAAMF, [Out] BALNLOBADED? OINEAODAACF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BALNLOBADED
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int BCICHPDGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? DDEHIHIJDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? CKPIOBEGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? KMFFNALBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JFOIKICJOLO? ADGFLDECECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CJELFLFLGLD(string KNICLOGGHLB, [Out] OBFILDBPEHN? OINEAODAACF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OBFILDBPEHN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? JGMPAAHOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? CFEDBCFEJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<MCCOKHBLPGF>? PLBIJAGOKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JFOIKICJOLO? ADGFLDECECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? EDJKGPGFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MCCOKHBLPGF
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	EFLJBCDFBNA LDLHEILDAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JFOIKICJOLO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? LBCCILMOBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[NMCNMLEECDM]
public class PPFPCLAOCDB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string NENGNGDOILA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int BCICHPDGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int? NGDHPIDOIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x14033F0", Offset = "0x1401DF0", VA = "0x1814033F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1403420", Offset = "0x1401E20", VA = "0x181403420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int? CAIMFJJAEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1403400", Offset = "0x1401E00", VA = "0x181403400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10D50B0", Offset = "0x10D3AB0", VA = "0x1810D50B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public List<MMDHIIEJGLF> INBGJPDJOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PPFPCLAOCDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NMCNMLEECDM]
public class KLBLKNJIELH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long FPJPIJBJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KLBLKNJIELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NMCNMLEECDM]
public class PJELCLEJLCB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string NENGNGDOILA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CPMCBIBALKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int? NGDHPIDOIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int? CAIMFJJAEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public List<MMDHIIEJGLF> INBGJPDJOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PJELCLEJLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NMCNMLEECDM]
public class GLDINLAEEMK
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public List<AHFINMDAKPG> PJBFEJEIPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Dictionary<string, string> PBPCAGHIJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7959A70", Offset = "0x7958470", VA = "0x187959A70")]
	public GLDINLAEEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NMCNMLEECDM]
public class AHFINMDAKPG
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BCICHPDGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string CKPIOBEGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string KMFFNALBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool? DDEHIHIJDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xEC3790", Offset = "0xEC2190", VA = "0x180EC3790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xEC37A0", Offset = "0xEC21A0", VA = "0x180EC37A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NKHOMHOBNCF ADGFLDECECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Dictionary<string, BPINAHMHIHP> MBOPFPACJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7953A50", Offset = "0x7952450", VA = "0x187953A50")]
	public AHFINMDAKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NMCNMLEECDM]
public class NKHOMHOBNCF
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string LBCCILMOBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NKHOMHOBNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[NMCNMLEECDM]
public class BPINAHMHIHP
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string JGMPAAHOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string CFEDBCFEJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public List<BMLEFGDAMCC> PLBIJAGOKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NKHOMHOBNCF ADGFLDECECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public long EDJKGPGFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x79555F0", Offset = "0x7953FF0", VA = "0x1879555F0")]
	public BPINAHMHIHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EFLJBCDFBNA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[NMCNMLEECDM]
public class BMLEFGDAMCC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public EFLJBCDFBNA LDLHEILDAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(EFLJBCDFBNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BMLEFGDAMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct BDONDKDPJHL : IEquatable<BDONDKDPJHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly bool ECOBIBNCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly DateTime PMNOMDPMLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool ACMJNOBFMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly FDEIDHKCJEA? OGJLNJLIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly string LGOBMAEDMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly int? BCNABAANFHF;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static BDONDKDPJHL KIIHCOANHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDA00", Offset = "0x2AEC400", VA = "0x182AEDA00")]
		get
		{
			return default(BDONDKDPJHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7955220", Offset = "0x7953C20", VA = "0x187955220")]
	public BDONDKDPJHL(DateTime LOCBCHMKEGF, bool NMHGNLHEBFG, FDEIDHKCJEA? EACGAJLGFDL, string LCPPOCBPBMC, int? BCLAKEGPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7955090", Offset = "0x7953A90", VA = "0x187955090")]
	public HLHOHLGPEEO JCLLJALGOAM(EPDJAOACKCO JJCICNHLINF)
	{
		return default(HLHOHLGPEEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7954D50", Offset = "0x7953750", VA = "0x187954D50")]
	private static HLHOHLGPEEO DHJMDAFALBO(EPDJAOACKCO JJCICNHLINF, DateTime LOCBCHMKEGF)
	{
		return default(HLHOHLGPEEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7954DD0", Offset = "0x79537D0", VA = "0x187954DD0", Slot = "4")]
	public bool Equals(BDONDKDPJHL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7954F30", Offset = "0x7953930", VA = "0x187954F30", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7954FE0", Offset = "0x79539E0", VA = "0x187954FE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7955120", Offset = "0x7953B20", VA = "0x187955120")]
	public static bool NOPNAEDOCOI(BDONDKDPJHL IIIICGAEODJ, BDONDKDPJHL ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7954D10", Offset = "0x7953710", VA = "0x187954D10")]
	public static bool DFNINOIAFHB(BDONDKDPJHL IIIICGAEODJ, BDONDKDPJHL ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7955150", Offset = "0x7953B50", VA = "0x187955150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct BBHLDELEIHC : IEquatable<BBHLDELEIHC>
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly BBHLDELEIHC KIIHCOANHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool OEBGFPNJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly HLHOHLGPEEO GIBJJGNFEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly BDONDKDPJHL OKNBJHJPJDO;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7954CE0", Offset = "0x79536E0", VA = "0x187954CE0")]
	public BBHLDELEIHC(HLHOHLGPEEO FEJEFMCDPJH, BDONDKDPJHL FHOGGDMABEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7954840", Offset = "0x7953240", VA = "0x187954840", Slot = "4")]
	public bool Equals(BBHLDELEIHC GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x79548F0", Offset = "0x79532F0", VA = "0x1879548F0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7954A20", Offset = "0x7953420", VA = "0x187954A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7954AE0", Offset = "0x79534E0", VA = "0x187954AE0")]
	public static bool NOPNAEDOCOI(BBHLDELEIHC IIIICGAEODJ, BBHLDELEIHC ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7954720", Offset = "0x7953120", VA = "0x187954720")]
	public static bool DFNINOIAFHB(BBHLDELEIHC IIIICGAEODJ, BBHLDELEIHC ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7954BF0", Offset = "0x79535F0", VA = "0x187954BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HLHOHLGPEEO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NHHFFJOBHFP : EPDJAOACKCO
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public const string CCFALDMCPDO = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly Stopwatch PGPMMHMAOJM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static DateTimeOffset? HGNCACGIHKK;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly NHHFFJOBHFP GMFHHDBKLAN;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static EPDJAOACKCO FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x795D5B0", Offset = "0x795BFB0", VA = "0x18795D5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal static NHHFFJOBHFP OOAMNLLOENF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x795D220", Offset = "0x795BC20", VA = "0x18795D220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public static DateTimeOffset MNGNLENEPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x795D600", Offset = "0x795C000", VA = "0x18795D600")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public static DateTime HLBBEPOPLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x795D190", Offset = "0x795BB90", VA = "0x18795D190")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DateTime GDIMIMAHELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x795D2D0", Offset = "0x795BCD0", VA = "0x18795D2D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DateTimeOffset IIEIHNBMBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x795D270", Offset = "0x795BC70", VA = "0x18795D270", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	private NHHFFJOBHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x795D390", Offset = "0x795BD90", VA = "0x18795D390")]
	internal static void NAEDIHBLBLN(DateTime? PHADNCIJMGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum BHAPJECFNOC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum FBBBEEHOIEM
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NMCNMLEECDM]
public class HJLACLGONDN : ADJAHFDAOOH, JJNPIFNJJFP, HJBDJGHOGMK, APPPDLBPNNL, IDOKPAIAMCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FJMBDMBAJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HJLACLGONDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x79582C0", Offset = "0x7956CC0", VA = "0x1879582C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7958670", Offset = "0x7957070", VA = "0x187958670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[IgnoreDataMember]
	public static GEHECBHLLJC KIMPEAFEJBO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int MAGAGLJOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(OGPADJCDAAA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1794EA0", Offset = "0x17938A0", VA = "0x181794EA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool LBLCPGOFFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xDB85B0", Offset = "0xDB6FB0", VA = "0x180DB85B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xEA4E70", Offset = "0xEA3870", VA = "0x180EA4E70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FJBIPDCKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xF34AA0", Offset = "0xF334A0", VA = "0x180F34AA0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xF334C0", Offset = "0xF31EC0", VA = "0x180F334C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool DEHKANDGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x21EF3F0", Offset = "0x21EDDF0", VA = "0x1821EF3F0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x21EEC70", Offset = "0x21ED670", VA = "0x1821EEC70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7958130", Offset = "0x7956B30", VA = "0x187958130", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7958180", Offset = "0x7956B80", VA = "0x187958180", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string JLGCPJBJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string NPIIHCDOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string LBBHENBDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1001780", Offset = "0x1000180", VA = "0x181001780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1001750", Offset = "0x1000150", VA = "0x181001750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public BHAPJECFNOC GOHAJOPMFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(BHAPJECFNOC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167C660", VA = "0x18167DC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string OGIBEPJCCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int PCFMLOHMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D30", Offset = "0xDD5730", VA = "0x180DD6D30", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xDD7030", Offset = "0xDD5A30", VA = "0x180DD7030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public IReadOnlyList<GDGKJAFLADP> NENPCEGAJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IReadOnlyList<DMJKDCPLOCL> AONHAGLAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public HPHKLJMNEEE IELOGKPCDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string GMFFHPANMOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x795ABF0", Offset = "0x79595F0", VA = "0x18795ABF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public FAJOKKEMLLC NGLODIAJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "24")]
		get
		{
			return default(FAJOKKEMLLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x795ABF0", Offset = "0x79595F0", VA = "0x18795ABF0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool NMKKFKNGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BJHDLCNOPOE BIPECCNKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAFDE20", Offset = "0xAFC820", VA = "0x180AFDE20", Slot = "30")]
		get
		{
			return default(BJHDLCNOPOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string AKODFKHHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BHCOMPDPHKN? ECMCFPCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x795ACE0", Offset = "0x79596E0", VA = "0x18795ACE0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HGOIMOGAAEP IPOGJEPFEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "33")]
		get
		{
			return default(HGOIMOGAAEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool FDNGDDAFNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HJLACLGONDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x112C200", Offset = "0x112AC00", VA = "0x18112C200")]
	public HJLACLGONDN([Optional] Guid PCPOOIGHMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x795ADA0", Offset = "0x79597A0", VA = "0x18795ADA0", Slot = "35")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x795AC10", Offset = "0x7959610", VA = "0x18795AC10", Slot = "36")]
	[AsyncStateMachine(typeof(FJMBDMBAJEH))]
	public Task DBOLDCHIAGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x795AD30", Offset = "0x7959730", VA = "0x18795AD30")]
	public HJLACLGONDN GJDBKFJEDMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[NMCNMLEECDM]
public class JEHGEFBIMHO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1403400", Offset = "0x1401E00", VA = "0x181403400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x10D50B0", Offset = "0x10D3AB0", VA = "0x1810D50B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string JLGCPJBJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(OGPADJCDAAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BHAPJECFNOC? GOHAJOPMFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAFBBF0", Offset = "0xAFA5F0", VA = "0x180AFBBF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAFBC00", Offset = "0xAFA600", VA = "0x180AFBC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JEHGEFBIMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[NMCNMLEECDM]
public class CPGGCKBJEKG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int MAGAGLJOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x14033C0", Offset = "0x1401DC0", VA = "0x1814033C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1404710", Offset = "0x1403110", VA = "0x181404710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string NPIIHCDOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public string JLGCPJBJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CPGGCKBJEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[NMCNMLEECDM]
public class MFABMKBDJCL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public string JLGCPJBJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MFABMKBDJCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CJIFFDNBAFN
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static int AAAIIDPBMGL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static int ODKALBOPJKE;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int HNGNPBOJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int IMKCNBBDFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public static CJIFFDNBAFN IIDHIFPMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7956060", Offset = "0x7954A60", VA = "0x187956060")]
		get
		{
			return default(CJIFFDNBAFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7956110", Offset = "0x7954B10", VA = "0x187956110")]
	public CJIFFDNBAFN(int BAIJMOJEILB, int MNCBLAJJLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NMCNMLEECDM]
public class IFBNFCPCAAJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int ADFEJENENII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public int NELIHDMMELB;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IFBNFCPCAAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[NMCNMLEECDM]
public class NDILJJGEODK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int GCBBAKPCJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int? DOFGLDLDKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x14033C0", Offset = "0x1401DC0", VA = "0x1814033C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1404710", Offset = "0x1403110", VA = "0x181404710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public string? LBGIPDADNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x795D0B0", Offset = "0x795BAB0", VA = "0x18795D0B0")]
	public NDILJJGEODK(int MCIFNPFIHOD, int? AHLNPOPCLCL, string? JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NDILJJGEODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[NMCNMLEECDM]
public class NMIIMAFJJLM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public DHELACGCDHD.GINGPABHDBE NLIBHDGKFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(DHELACGCDHD.GINGPABHDBE);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public string GHKMAEGDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int? CAPONIJIHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NMIIMAFJJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DMJKDCPLOCL
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	long IMCDBJNGFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Guid CFMLHNHKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string ELCAKBODBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string OAHLNJJKPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	int EEPLNFFDGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string DHJKNAHOPID
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	string POIENLLIBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string AGKMJEDAJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string EFKIEAGDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	int PCFMLOHMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NMCNMLEECDM]
public class GDGKJAFLADP : DMJKDCPLOCL, HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public long IMCDBJNGFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Guid CFMLHNHKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public string ELCAKBODBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public string OAHLNJJKPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int EEPLNFFDGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1026A90", Offset = "0x1025490", VA = "0x181026A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string DHJKNAHOPID
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string POIENLLIBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string AGKMJEDAJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string EFKIEAGDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int PCFMLOHMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167C660", VA = "0x18167DC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "15")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GDGKJAFLADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Flags]
public enum PPLANBFLIOI
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum GBKBEHIPFBD
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AMFDEADBDDI
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7953B70", Offset = "0x7952570", VA = "0x187953B70")]
	public static int? HGDCIBOFMNO(PPLANBFLIOI? PLLCLLNFEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7953AE0", Offset = "0x79524E0", VA = "0x187953AE0")]
	public static int? HCEJLLGCIMC(GBKBEHIPFBD? IHIPJOILELK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NMCNMLEECDM]
public class BKEDEALINBI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public long MAGAGLJOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public List<HJLACLGONDN> IFFNELJODJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7955430", Offset = "0x7953E30", VA = "0x187955430", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BKEDEALINBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NMCNMLEECDM]
public class PJPMGCENDHN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int? JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public OGPADJCDAAA? NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PJPMGCENDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NMCNMLEECDM]
public class HKGMBANLFND : NMMCIAJOPCH, HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public byte ILBGGFKMPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HKGMBANLFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HKKHCEMEPJN
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x795AF50", Offset = "0x7959950", VA = "0x18795AF50")]
	public static CELDHBEKCDH NACIFKAGFMA(this HKGMBANLFND DKGBCFDLMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ADJAHFDAOOH
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	int MAGAGLJOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool LBLCPGOFFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool FJBIPDCKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool DEHKANDGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	string JLGCPJBJJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	string NPIIHCDOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string LBBHENBDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	BHAPJECFNOC GOHAJOPMFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string OGIBEPJCCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	int PCFMLOHMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string GMFFHPANMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7953580", Offset = "0x7951F80", VA = "0x187953580", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IDOKPAIAMCC
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	IReadOnlyList<DMJKDCPLOCL> AONHAGLAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	int MAGAGLJOCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	bool DEHKANDGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	int PCFMLOHMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	int? MLAIKPMGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DDKPEBCFJNF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MMNCEIIODKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public IEnumerable<APPPDLBPNNL> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x795CBB0", Offset = "0x795B5B0", VA = "0x18795CBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x795CE60", Offset = "0x795B860", VA = "0x18795CE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x79573B0", Offset = "0x7955DB0", VA = "0x1879573B0")]
	public static bool GNIPNJKBIAO(this IEnumerable<HJBDJGHOGMK> GBEHGKLEJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x79575E0", Offset = "0x7955FE0", VA = "0x1879575E0")]
	[AsyncStateMachine(typeof(MMNCEIIODKJ))]
	public static Task NPDEBECDMJL(this IEnumerable<APPPDLBPNNL> GBEHGKLEJFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct APAFHBPABPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly string EDBPDGHPKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly string NDFBHDFHOIM;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public static readonly APAFHBPABPH LDBDNKHHGOP;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	public APAFHBPABPH(string LJJHGOFCFDE, string LMLHBIBFOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x143A210", Offset = "0x1438C10", VA = "0x18143A210")]
	public bool CFJEMHPIHGP(APAFHBPABPH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x79544C0", Offset = "0x7952EC0", VA = "0x1879544C0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7954590", Offset = "0x7952F90", VA = "0x187954590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7954600", Offset = "0x7953000", VA = "0x187954600")]
	public static bool NOPNAEDOCOI(APAFHBPABPH IIIICGAEODJ, APAFHBPABPH ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7954440", Offset = "0x7952E40", VA = "0x187954440")]
	public static bool DFNINOIAFHB(APAFHBPABPH IIIICGAEODJ, APAFHBPABPH ELBIKJBAIEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface HJABGCALBPL
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	OANEKPHLJMK OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string MFCKAANIGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	string AALMNHLEDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	long POPHNMJENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string IFIBOFACGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	string AKMKAANPFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	string CNEMGKOBNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	string DIPCOLHJGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[NMCNMLEECDM]
public class NJCKELIHICG : ENKOJIMGPCG
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string CPGDJLKJINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public EAFPOPNKKFG FIBEHDDKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(EAFPOPNKKFG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public MDMKJLAFECA OJALLJFPNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		[CompilerGenerated]
		get
		{
			return default(MDMKJLAFECA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public PGHIJKDJPPM GJPNMHIDJON
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(PGHIJKDJPPM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[DataMember(Name = "Header")]
	public string? FGFKDGAEPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public string? JGMPAAHOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string? EACMHGMPFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public List<string> EOGHDGNHFBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public List<MEMOPEMIBFA> PLBIJAGOKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7958190", Offset = "0x7956B90", VA = "0x187958190", Slot = "5")]
	public override void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x795D850", Offset = "0x795C250", VA = "0x18795D850")]
	public NJCKELIHICG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum LEIMIODPLNH
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum EAFPOPNKKFG
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum MDMKJLAFECA
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum PGHIJKDJPPM
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	After
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[NMCNMLEECDM]
public class MEMOPEMIBFA : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public LEIMIODPLNH OGBFPNHAMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(LEIMIODPLNH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string? ACCCMPLKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[DataMember(Name = "LinkParameter")]
	public string? IEPJLPNENLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string? CPJEFECDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MEMOPEMIBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class ENKOJIMGPCG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public string? JAPKCBMDLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JCFGPHPCCIK();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7957FF0", Offset = "0x79569F0", VA = "0x187957FF0")]
	protected ENKOJIMGPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[NMCNMLEECDM]
public class FEHEHDKDPEJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public string? BCIDBFOBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FEHEHDKDPEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[NMCNMLEECDM]
public class PLBODDJGHCG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	internal static Func<string, NJCKELIHICG>? IFJNHHAIOMC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	internal static Func<string, GJHPPFHECKG>? KBCHEGDKKBI;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string? BCIDBFOBJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string? DCMMGJNJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool HPMGBAHGEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public FDEIDHKCJEA HIBPENHPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		[CompilerGenerated]
		get
		{
			return default(FDEIDHKCJEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public AMLOJEALFHA EFGBHEOLGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(AMLOJEALFHA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int BAJJHIOFCHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime FOGIGILBLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "IsRead")]
	internal bool NFNLLEGPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xB04860", Offset = "0xB03260", VA = "0x180B04860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	[IgnoreDataMember]
	public bool NKEKCNKPABP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x15C7D40", Offset = "0x15C6740", VA = "0x1815C7D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x15C7A00", Offset = "0x15C6400", VA = "0x1815C7A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DPLNMKINCDM FJEIABBLJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0")]
		[CompilerGenerated]
		get
		{
			return default(DPLNMKINCDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1794EA0", Offset = "0x17938A0", VA = "0x181794EA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MPKEEGNPGDM HKMMJBFNGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		[CompilerGenerated]
		get
		{
			return default(MPKEEGNPGDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	internal string? DMPDDHGOJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	[IgnoreDataMember]
	public NJCKELIHICG? EHFKBBEKJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x795F240", Offset = "0x795DC40", VA = "0x18795F240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	[IgnoreDataMember]
	public GJHPPFHECKG? EIDFBMHGHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x795F2C0", Offset = "0x795DCC0", VA = "0x18795F2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	[IgnoreDataMember]
	public ENKOJIMGPCG? FMDJOPBCDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x795F340", Offset = "0x795DD40", VA = "0x18795F340", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xAD7C40", Offset = "0xAD6640", VA = "0x180AD7C40")]
	public PLBODDJGHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[NMCNMLEECDM]
public class CMPNCNLMLBL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public ACPFBHPDAHI PIPAOLKKFNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(ACPFBHPDAHI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public string FPBNHMANLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public int FPGFCNKJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x79572D0", Offset = "0x7955CD0", VA = "0x1879572D0")]
	public CMPNCNLMLBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[NMCNMLEECDM]
public class GJHPPFHECKG : ENKOJIMGPCG
{
	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public string ENMICGMLGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public string? DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public FFBIBKLIJAI EPLOLGABFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(FFBIBKLIJAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	[DataMember(Name = "all_conditions_required")]
	public bool BPOICBIMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x18AB960", Offset = "0x18AA360", VA = "0x1818AB960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x10C54D0", Offset = "0x10C3ED0", VA = "0x1810C54D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public List<CMPNCNLMLBL> FMCIAFOJAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x79599A0", Offset = "0x79583A0", VA = "0x1879599A0", Slot = "5")]
	public override void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x79599B0", Offset = "0x79583B0", VA = "0x1879599B0")]
	public GJHPPFHECKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum MPKEEGNPGDM
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum DPLNMKINCDM
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public enum FFBIBKLIJAI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public enum ACPFBHPDAHI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface IGDAODIEAGJ
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool EHILIOIGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	AHDLCNFLGGK<PLBODDJGHCG> ALEILOBMJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	AHDLCNFLGGK<string> FAKMFJAJBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	AHDLCNFLGGK<PLBODDJGHCG> IIMMIGEHHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	AHDLCNFLGGK<PLBODDJGHCG> EEAGHPFHNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<PLBODDJGHCG> GJEALLENFOF(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PLBODDJGHCG> DLEDMGMOPBB(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLBODDJGHCG AFMEOAFBGGE(DPLNMKINCDM FLIDFJKDJOB, string CNNMFHGFJJD);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PLBODDJGHCG HHCABPNAHML(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GCBHDNJOFKM(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EEOFEFOLMBM(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OLGKJIKJDDF();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OHNPOPFJDLL(PLBODDJGHCG JEBOHIALEMJ);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CBJAOFNNIOB
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	DCMBPNOKEGC BPLAKCCOLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	int KAHCJCKDDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool MENOILLGPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	bool DNKPADBCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool GENGHMJKEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool JKICMICNNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool DKJGCGEBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool LECKHHKIHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool AEPCJJPLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool FMKNLJMBDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool HLOOGFDEPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool JAHGAHMCNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LMEDBMCOENE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action OKGDGAMEIDC;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FKFADEBPFBK<NHEHGMDMJGF> DNABFEHOCJM(int KPCCLFNHPJC);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CNBBKAECPOB CKLHMDBMLPA(DateTime KBHJMOEMDFH);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CNBBKAECPOB NAAHPJOALHP(string IDELAJEJODI);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BPDFNOAMGAF([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum GPLMCLJNALP
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FKOMCFHHLAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7958F50", Offset = "0x7957950", VA = "0x187958F50")]
	public static string CAKOCHMNMKN(this GPLMCLJNALP PEOOMOJFLJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ADOHBPFLNEP
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<PLBODDJGHCG>> IPJOCIGABKO(DPLNMKINCDM FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OHNPOPFJDLL(string CNNMFHGFJJD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface OEPKIHNHCHP
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EIMNLFDPLFP> LJJMCKMPPDI();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface GBBONLOICIO
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	Guid? KBFBPNDPLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PDEKJIGFELF
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKFADEBPFBK<List<JFOFFPPJIFD>> JKLOHLAJKHG();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKFADEBPFBK<List<JFOFFPPJIFD>> DOAECKLCKGP();

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<JFOFFPPJIFD>> DJEKKNHAKEC([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKFADEBPFBK<List<JFOFFPPJIFD>> LHLOHFDOHGI(List<NCHELFAJJGK> DACOPEGAGEK);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKFADEBPFBK<List<JFOFFPPJIFD>> CNJJNLAGGHP(List<NCHELFAJJGK> DACOPEGAGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface MCGGGBGPEPF
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	List<NDAMNDNBEKH> OPFKIDGDKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LEGLGJBOCGC> GALCLOCAJGC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NDAMNDNBEKH> GLDFJKHFGPC;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CNBBKAECPOB ENMCFAJFFFI(NDAMNDNBEKH GPLPEJGDGAD);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NJGNDBEPKFO(NDAMNDNBEKH GPLPEJGDGAD);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	FKFADEBPFBK<NDAMNDNBEKH> FOCFJEHJMFO(OMIDHABEBNI IJNPIDPIBFP, OMIDHABEBNI? EELBGELMIMN, bool IOBEJJEJGBD, string JEBOHIALEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FKFADEBPFBK<NDAMNDNBEKH> FOCFJEHJMFO(OMIDHABEBNI IJNPIDPIBFP, string JEBOHIALEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BGANCAJPPKD(NDAMNDNBEKH DEDAFCDMBCH, bool MOMEBECLDOE = false, bool AEKOCDIPMAG = false, bool IKHCKLGKCAO = true);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FKFADEBPFBK<List<NDAMNDNBEKH>> KAAINIMBLEA();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HKNNCFIGDMO
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	string LJHIBHOHGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	bool DNEGBMDKPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNBBKAECPOB KGGHIAEHMHM();

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNBBKAECPOB JKGDMNPFJAO(string MDCGCNGCCOD, string MLMCPPBNFEN);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNBBKAECPOB LDAMFHAMFPG(string NGDLHJPAKPC);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHODGOOGNJL();

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<HILCFGDNHNH> MPNKFMPNPID(string IDELAJEJODI, string NGDLHJPAKPC, bool LGLFAPOHJOG, string ICHILHNFIIP, string CGOONKNPGCM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task PICBCKHOLKP(int KPCCLFNHPJC, string NFEEJJBJNAH, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task FKFGAINMIFE(int KPCCLFNHPJC, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task PCFDALHJEIF([Optional] GPLMCLJNALP? LFKGAPEDBCP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<NJDKGKKHMHE>> EDHOIGOIHMP([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task PJGOKJFLFJP([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface AGECEMJHJAB
{
	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<LBALNAMDGBI>> MDPOFAKIBBB([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<NEKKANBMCMO>> NEJHNAOAFEK([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GGGNMKFGAIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NDOBCPOHBLN([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJIMPEDAFPB();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface IKCDPOLEDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OAHEAJKCMAK(int FMPHAOBBHMB, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KMPFBGAAGBP
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FGNOMCPIGON? NKKMACJCJDN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FGNOMCPIGON? KMDEDLLCEOD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FGNOMCPIGON? JDLAOBGCHII;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<BNNANBPCKPP> DGJIMNKOGHM();

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<BNNANBPCKPP?>? GHLPMAFKOJK(int KPCCLFNHPJC);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<EJDJJINJFOD>> EENNPDADHPH(List<int> JBOPBMEBBNP);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, BNNANBPCKPP>> AAIOEMMAJEM();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<BNNANBPCKPP?>?>? MNEALAAEMMI(int KPCCLFNHPJC);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task MGJELIILMNA(int CKOENHFPFNP);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ENEHDIDOEFG> OGCLMLGDLLC(BNNANBPCKPP BABKFLMJLEF);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate void FGNOMCPIGON(int KPCCLFNHPJC, int CKOENHFPFNP, BNNANBPCKPP? BABKFLMJLEF);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GEHECBHLLJC : HCOGJNBDPNI, FDHMEMKKDPL
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Flags]
	public enum LFNBKLMCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string EFGADHAHLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	AIIENGDOPBC GKADJDAHJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	FDEIDHKCJEA HIBPENHPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string LGOBMAEDMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	byte DLIKNBDBADM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	int GLMMNBHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	int OOJCMJOFHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool EKCIHDNEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool IHKBNNJAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	bool FHNGKAFDHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	bool KNDCDCAEINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	bool ILPIFMDOPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool OBEIBCNAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	bool EFJHIJLOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FKFADEBPFBK<string> HCHNMLGOBHK();

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> JJKFLGPMBAE();

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FKFADEBPFBK<bool> IsPlayerCommunicationRestricted(int KPCCLFNHPJC);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string OGBIIKOMMDP(string IELIBBNCJAC, bool HGHINBAMFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> FMONINNOGDM(string IELIBBNCJAC, bool HGHINBAMFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FKFADEBPFBK<string> MakeRoomNameAdhereToPlatformRequirements(long GDCAPMONNDM, string IELIBBNCJAC);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string OPCLGKIOIHP, LFNBKLMCNLA IJFLNGKPKAE = LFNBKLMCNLA.FilterProfanity | LFNBKLMCNLA.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string OPCLGKIOIHP, LFNBKLMCNLA IJFLNGKPKAE = LFNBKLMCNLA.FilterProfanity | LFNBKLMCNLA.FilterURL, bool LFHDDJPLMBJ = false);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string IELIBBNCJAC, LFNBKLMCNLA IJFLNGKPKAE = LFNBKLMCNLA.FilterProfanity | LFNBKLMCNLA.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FKFADEBPFBK<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HBDEIFHOJGN
{
	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<ENILJOLKFMD>> BGCFMFGEIMB([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface HCGCOGIEBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCCHKGNANCE(byte[] LMLHBIBFOGI, byte[] INDJHFNBMHP);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface MGLJKLMIOKD
{
	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AEEAIDBEPHB(string HPIKCKKFHKC);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface DNNKELKIAMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<IHPFBOBMIJI<FilteredTextDTO>>> BOGIBLCMCBI(uint PPINEDCLKCO, IEnumerable<string> MKLOKPOHLLK);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface DECBEMKCNLN
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	AHDLCNFLGGK<MCDBGDEBFGF> IAAHMBMKJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCCGOIBALIC();

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EPEHLLAICDK> FMJHDPFFKKP(long GPAGMHAKKLI, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EPEHLLAICDK> FMJHDPFFKKP(string IELIBBNCJAC, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<MCDBGDEBFGF> HFOLFPCABGD(long GPAGMHAKKLI, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface GIJKPLBENKG
{
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFOCEDBBIHD([Out] bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BEOOBIPLGME([Out] bool KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FJPHFNJIFEC([Out] int KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKCCGHOELKP([Out] bool KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public enum BJHPNDGEOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public enum LICDCOAJJGF
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Flags]
public enum GGLNPAMIKAN
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[Flags]
public enum BPECJGALPLE
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum GPKCCMNPPJH
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum CCNOAHNBBFD
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface NHEHGMDMJGF
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	string MEGOBGNMGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	string DMGFAJLMLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	string MCPKJMFBHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	string MCLCBKNLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	string BHOHFKIEHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	string IPECBOBJKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	bool DHFPGIAJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool PNAGENMGLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	GGLNPAMIKAN IHPGAOCFEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	BPECJGALPLE DFKICHCKKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	bool? CCMBCJEHDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HJKAMJFPJFL(bool AHIBMGAPHPF);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPAPGBFMELE(bool JDDCMKFGPCP);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface DCMBPNOKEGC : NHEHGMDMJGF
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	string HDINEMLLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	string JMDCOIHHFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	DateTime? GMCLCFNBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	BJHPNDGEOGF OOGENCAODMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	int? IGAKHBAMBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	int KNEHCIPDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	bool CHLMHOBIFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	bool AOFLOBIBMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	bool? DCLMLPPNFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KNMPBKBHBPF
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public NHEHGMDMJGF GPLNCPBCJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public LICDCOAJJGF OKILANDLPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(LICDCOAJJGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public string NPKENKMPAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x72ED460", Offset = "0x72EBE60", VA = "0x1872ED460")]
	public KNMPBKBHBPF(NHEHGMDMJGF DCHPCFDAGKH, LICDCOAJJGF LBMOFDFOFAK, string DGPNLDJHGKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface PKJNKIBFFFI
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	bool GAHCAGAPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface KCJKDCGHOLA
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	bool PMPLFEKMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface NDOOFKMANAM
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	string FKAJEJBMGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum BHCOMPDPHKN
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class JFOFFPPJIFD
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public BHCOMPDPHKN ECMCFPCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(BHCOMPDPHKN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public string JIPINABHJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public BJHDLCNOPOE BIPECCNKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(BJHDLCNOPOE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string IPFCPCNHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public int GDNHGDFEPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool AFLMEMDFDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xFEB810", Offset = "0xFEA210", VA = "0x180FEB810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xFEB700", Offset = "0xFEA100", VA = "0x180FEB700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public NCHELFAJJGK GDJDPGKMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x15B58D0", Offset = "0x15B42D0", VA = "0x1815B58D0")]
		[CompilerGenerated]
		get
		{
			return default(NCHELFAJJGK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x795B5E0", Offset = "0x7959FE0", VA = "0x18795B5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public PDKIOGIIPNG IJBFCPJHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xF59880", Offset = "0xF58280", VA = "0x180F59880")]
		[CompilerGenerated]
		get
		{
			return default(PDKIOGIIPNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x4603C50", Offset = "0x4602650", VA = "0x184603C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public string ALIHKAGOKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x51D4400", Offset = "0x51D2E00", VA = "0x1851D4400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x795B600", Offset = "0x795A000", VA = "0x18795B600")]
	internal JFOFFPPJIFD(MAFPDFIIEMM DICFNAJDLLP, OGMBPJENFED IJNCBEGIJPK, DLFALJHALEC FKKDBGIKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x795B860", Offset = "0x795A260", VA = "0x18795B860")]
	public JFOFFPPJIFD(BHCOMPDPHKN CGAOJOHKDPI = BHCOMPDPHKN.Outfit, [Optional] NCHELFAJJGK PELBIPJJGNP, [Optional] string CDLCGIGHGJP, [Optional] string ILAEKGJFODM, BJHDLCNOPOE EIMFIPFCEIE = BJHDLCNOPOE.Common, [Optional] string ANBGFBPGPIK, int NKDDKILHAIA = 0, bool MGOFHAEEJFL = false, [Optional] string IGLMPANNLJN, [Optional] DateTime? HJMDCHHCMEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[NMCNMLEECDM]
public class MAFPDFIIEMM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public BHCOMPDPHKN ECMCFPCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(BHCOMPDPHKN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	[DataMember(Name = "AvatarItemDesc")]
	public string DDCBPOEGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public string JIPINABHJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public BJHDLCNOPOE BIPECCNKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(BJHDLCNOPOE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public string IPFCPCNHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public int GDNHGDFEPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool AFLMEMDFDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x19D98C0", Offset = "0x19D82C0", VA = "0x1819D98C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x19F8950", Offset = "0x19F7350", VA = "0x1819F8950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public string OMAKCKAANOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xFEB730", Offset = "0xFEA130", VA = "0x180FEB730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MAFPDFIIEMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[NMCNMLEECDM]
public sealed class PALHDONLOKM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public List<string> NEMDMDFCALG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x795E470", Offset = "0x795CE70", VA = "0x18795E470")]
	public PALHDONLOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public PALHDONLOKM(List<string> DACOPEGAGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[NMCNMLEECDM]
public class EIMNLFDPLFP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public FKMLKNBOACD FOFKKFLALEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public DBNEMKOAAPE DLONNKEIBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EIMNLFDPLFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public EIMNLFDPLFP(FKMLKNBOACD CCGCEIICBKL, DBNEMKOAAPE KONLPLKNEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public enum LGNBOPOEOMD
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public enum NLEHIOLOFPD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[NMCNMLEECDM]
public class FKMLKNBOACD : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public LGNBOPOEOMD LINIDMGLCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(LGNBOPOEOMD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public NLEHIOLOFPD? DJKCOLHKKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3296A30", Offset = "0x3295430", VA = "0x183296A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x77EFE00", Offset = "0x77EE800", VA = "0x1877EFE00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool JCNPFGJCKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x20E4CD0", Offset = "0x20E36D0", VA = "0x1820E4CD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x20E4CE0", Offset = "0x20E36E0", VA = "0x1820E4CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7958EB0", Offset = "0x79578B0", VA = "0x187958EB0")]
	public FKMLKNBOACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7958EC0", Offset = "0x79578C0", VA = "0x187958EC0")]
	public FKMLKNBOACD(LGNBOPOEOMD NPCDADJOPGG, NLEHIOLOFPD JPAAAMFEAGE, bool CMJNNHDLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NMCNMLEECDM]
public class DBNEMKOAAPE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public string BIJCKNJBBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public string BHDGBNDMGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DBNEMKOAAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public DBNEMKOAAPE(string GMAFCNFIMIB, string POOLHFACAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public enum AIIENGDOPBC
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LEGLGJBOCGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NDAMNDNBEKH KHCBHKFEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public bool HPMDOJLENOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public bool AEEALBJNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public bool ANOGMJCPDIK;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[NMCNMLEECDM]
public class NDAMNDNBEKH : APPPDLBPNNL, HJBDJGHOGMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct DGOKIJDIKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public NDAMNDNBEKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x79576B0", Offset = "0x79560B0", VA = "0x1879576B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7957840", Offset = "0x7956240", VA = "0x187957840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal static Action<NDAMNDNBEKH> KDNMDMOONCN;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	internal static Func<NDAMNDNBEKH, Task> NLELJOMDMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[IgnoreDataMember]
	public bool NHBHIOGNBAF;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public long? BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int HDIHMAKDCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public int? IBLDMJEBMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1403400", Offset = "0x1401E00", VA = "0x181403400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x10D50B0", Offset = "0x10D3AB0", VA = "0x1810D50B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public string AKODFKHHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public BHCOMPDPHKN? ECMCFPCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	[DataMember(Name = "AvatarItemDesc")]
	public string ALKNMAOEFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Guid? KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xE40C90", Offset = "0xE3F690", VA = "0x180E40C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xE40A60", Offset = "0xE3F460", VA = "0x180E40A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public string DIDOPDAFIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public string MAOJNDJNKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public LMFNPHDGODM FLJCMKOBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70")]
		[CompilerGenerated]
		get
		{
			return default(LMFNPHDGODM);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1618FE0", Offset = "0x16179E0", VA = "0x181618FE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public int HPDBGBGAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4AD0", Offset = "0xAD34D0", VA = "0x180AD4AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1618FD0", Offset = "0x16179D0", VA = "0x181618FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int PIKPOIHNECG
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167C660", VA = "0x18167DC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public OMIDHABEBNI ECCKENGDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7B0", Offset = "0xB2E1B0", VA = "0x180B2F7B0")]
		[CompilerGenerated]
		get
		{
			return default(OMIDHABEBNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x167CC80", Offset = "0x167B680", VA = "0x18167CC80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public BJHDLCNOPOE KBICIHBHCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE70", Offset = "0xD8C870", VA = "0x180D8DE70")]
		[CompilerGenerated]
		get
		{
			return default(BJHDLCNOPOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x163A020", Offset = "0x1638A20", VA = "0x18163A020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	[DataMember(Name = "Message")]
	public string PBBPNCKIJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public string CMBOMBGBOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PCKLFOGAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xFEB720", Offset = "0xFEA120", VA = "0x180FEB720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public FDEIDHKCJEA HIBPENHPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xF68C80", Offset = "0xF67680", VA = "0x180F68C80")]
		[CompilerGenerated]
		get
		{
			return default(FDEIDHKCJEA);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xF67580", Offset = "0xF65F80", VA = "0x180F67580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public AMLOJEALFHA IPLOFJPKBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xAB7C30", Offset = "0xAB6630", VA = "0x180AB7C30")]
		[CompilerGenerated]
		get
		{
			return default(AMLOJEALFHA);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xAB7BC0", Offset = "0xAB65C0", VA = "0x180AB7BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public EBECOMOBJJD? CHMBNECCLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1566580", Offset = "0x1564F80", VA = "0x181566580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x795D0A0", Offset = "0x795BAA0", VA = "0x18795D0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool LEFEKEDLOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x795CEC0", Offset = "0x795B8C0", VA = "0x18795CEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool IIDIHCLEGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x795D020", Offset = "0x795BA20", VA = "0x18795D020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool DPOCGHBDNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x795D000", Offset = "0x795BA00", VA = "0x18795D000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	[IgnoreDataMember]
	public bool GEFPAPNMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAAC1A0", Offset = "0xAAABA0", VA = "0x180AAC1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAAC1C0", Offset = "0xAAABC0", VA = "0x180AAC1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	[IgnoreDataMember]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2F2E3F0", Offset = "0x2F2CDF0", VA = "0x182F2E3F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2F2DE10", Offset = "0x2F2C810", VA = "0x182F2DE10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	[IgnoreDataMember]
	public string LFBHEFKMNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	[IgnoreDataMember]
	public string EDKDECCKLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xEE2970", Offset = "0xEE1370", VA = "0x180EE2970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	[IgnoreDataMember]
	public bool KFNPNDAHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD75210", Offset = "0xD73C10", VA = "0x180D75210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x795D040", Offset = "0x795BA40", VA = "0x18795D040", Slot = "5")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x795CF30", Offset = "0x795B930", VA = "0x18795CF30", Slot = "6")]
	[AsyncStateMachine(typeof(DGOKIJDIKDF))]
	public virtual Task DBOLDCHIAGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x167CC80", Offset = "0x167B680", VA = "0x18167CC80")]
	public void PCCGFOCIGOB(OMIDHABEBNI IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NDAMNDNBEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface JPAJMKPCDKM
{
	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long FLKEPANIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	string FDEPBPLCLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int DJPEIGCEDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	string FPCABGCJJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	byte KOIJJMDMCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	int GPNIMGAGCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	int AJNNFHFEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool LBLCPGOFFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	DateTime? FGHOBIDPOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	long? DMKCKADILGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	int EPAJJACGAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	int OAMBEOECCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	int LJEFKEINMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	JALBGOEMJIB OGDHOBPLBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	JALBGOEMJIB DDLLIKJKBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	bool ECBPLPBCDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	bool HLAGBKIGAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	bool DEHKANDGHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	bool DKIJNFDBHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	int? JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	bool MFOHFOBFJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	string EODNHNCKLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOAGLONFAMA();

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HJPKGMADJGD();
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[NMCNMLEECDM]
public class ADOPOHFDNDH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public List<FPMGEPJAEGN> PPHPOIIEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7953800", Offset = "0x7952200", VA = "0x187953800")]
	public List<string> NFKJACFKGFL(params GNPFLHLJALH[] LKBJDBEOPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x79539C0", Offset = "0x79523C0", VA = "0x1879539C0")]
	public List<string> OHKIFEKPMLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7953780", Offset = "0x7952180", VA = "0x187953780")]
	public List<string> MGODNNHNDHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7953730", Offset = "0x7952130", VA = "0x187953730")]
	public List<string> JNHCANHMNOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7953640", Offset = "0x7952040", VA = "0x187953640", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ADOPOHFDNDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NMCNMLEECDM]
public class LEEADJMNELE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int DJPEIGCEDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LEEADJMNELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[NMCNMLEECDM]
public class HHGNENPJHMJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public long FLKEPANIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public string FDEPBPLCLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public int NJJEJHFIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool JIHLHCAFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E60", Offset = "0xEC6860", VA = "0x180EC7E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F70", Offset = "0xEC6970", VA = "0x180EC7F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public int BHCPDIJGILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public int COOIMNADCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public int FLJHEPCBNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public int GNAPNEHPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xAEE7D0", Offset = "0xAED1D0", VA = "0x180AEE7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xAED910", Offset = "0xAEC310", VA = "0x180AED910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public string LMJDALJKCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public string HCNJJADODEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public OGPADJCDAAA? LINILLOJEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xFEB730", Offset = "0xFEA130", VA = "0x180FEB730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public IReadOnlyList<Guid> EKHCFDBMCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public APAFHBPABPH LBAFDFELJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x795A720", Offset = "0x7959120", VA = "0x18795A720")]
		get
		{
			return default(APAFHBPABPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x795A780", Offset = "0x7959180", VA = "0x18795A780", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x795A770", Offset = "0x7959170", VA = "0x18795A770")]
	public bool CFJEMHPIHGP(HHGNENPJHMJ FBJGDHOGOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x795A800", Offset = "0x7959200", VA = "0x18795A800")]
	private bool FOIDEOCJKGO(HHGNENPJHMJ FBJGDHOGOCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x795A680", Offset = "0x7959080", VA = "0x18795A680")]
	private static bool BDINOOGNJGM(IReadOnlyList<Guid> DFPHHIJOJHG, IReadOnlyList<Guid> DKCNPHIKFMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2B533F0", Offset = "0x2B51DF0", VA = "0x182B533F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HHGNENPJHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NMCNMLEECDM]
public class LMKJENBMEOJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public int FLKBEKIMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LMKJENBMEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[NMCNMLEECDM]
public class BHPCEGGPPLJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public bool PLEMLIMEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BHPCEGGPPLJ()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[NMCNMLEECDM]
	public class NewInventionRequestDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public LHDJNPMOIOH creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x795DB60", Offset = "0x795C560", VA = "0x18795DB60")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[NMCNMLEECDM]
	public class AddVersionInventionRequestDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7954710", Offset = "0x7953110", VA = "0x187954710")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[NMCNMLEECDM]
	public class ModifyTagsRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[NMCNMLEECDM]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[NMCNMLEECDM]
	public class ReportRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public JKGODIDOMBJ ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[NMCNMLEECDM]
	public class CheerRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[NMCNMLEECDM]
	public class UpdatePriceRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[NMCNMLEECDM]
	public class UpdateInventionMetadataRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[NMCNMLEECDM]
	public class UpdateInventionGeneralPermissionRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public JALBGOEMJIB Permission
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(JALBGOEMJIB);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[NMCNMLEECDM]
	public class PublishInventionRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public JALBGOEMJIB Permission
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(JALBGOEMJIB);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public OGPADJCDAAA Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			[CompilerGenerated]
			get
			{
				return default(OGPADJCDAAA);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[NMCNMLEECDM]
	public class UnpublishInventionRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[NMCNMLEECDM]
	public class DeleteInventionRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[NMCNMLEECDM]
	public class SetInventionVersionAccessibilityRequest : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public OGPADJCDAAA NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			[CompilerGenerated]
			get
			{
				return default(OGPADJCDAAA);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[NMCNMLEECDM]
	public class SpecialTags : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public enum BDEKGEJBOJM
{
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum JKGODIDOMBJ
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public enum OHLCAMIMNEA
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface NJDKGKKHMHE
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	FDEIDHKCJEA HIBPENHPDCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	string LGOBMAEDMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	DateTime MANNNPNCKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	bool IELLFINNHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	string GNAGOJAEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	NHEHGMDMJGF GPLNCPBCJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JCFGPHPCCIK();

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADIOILCMLMJ(NHEHGMDMJGF DCHPCFDAGKH);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface IILEIBJFKJG
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	bool ANJJPEJAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCFGPHPCCIK();
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct HILCFGDNHNH
{
	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public APCJJFEMJCJ KAMKMMHBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930")]
		[CompilerGenerated]
		readonly get
		{
			return default(APCJJFEMJCJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public IILEIBJFKJG PHPCHHCONEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xB51470", Offset = "0xB4FE70", VA = "0x180B51470")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xF728C0", Offset = "0xF712C0", VA = "0x180F728C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string BPMKBLIIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6326630", Offset = "0x6325030", VA = "0x186326630")]
	public HILCFGDNHNH(APCJJFEMJCJ HPOEHMOLEIK, [Optional] IILEIBJFKJG FCHHMPLHDOJ, [Optional] string CGOONKNPGCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public enum APCJJFEMJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[NMCNMLEECDM]
public class LBALNAMDGBI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string GGJJIKGBAID
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public string JEBOGINBKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string JIEMIIOKDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public string FGMJBBEJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public List<IKDCCEEMENP> IMPOBDLIBEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LBALNAMDGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5068240", Offset = "0x5066C40", VA = "0x185068240")]
	public LBALNAMDGBI([Optional] string CCHKMDMCOFK, [Optional] string FFPIOCFGCFP, [Optional] string BOBKELOOKIO, [Optional] string JPBBHACAGHA, [Optional] List<IKDCCEEMENP> MLJCJMEDMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[NMCNMLEECDM]
public class IKDCCEEMENP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string CNEMGKOBNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string FGMJBBEJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IKDCCEEMENP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[NMCNMLEECDM]
public class NEKKANBMCMO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string JEBOGINBKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string KAMKMMHBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string GGJJIKGBAID
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public List<string> GOIALGNBPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NEKKANBMCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[NMCNMLEECDM]
public interface HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCFGPHPCCIK();
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[NMCNMLEECDM]
public interface APPPDLBPNNL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DBOLDCHIAGO();
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[NKJLCLJLBEN]
public interface NMMCIAJOPCH : HJBDJGHOGMK
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[NMCNMLEECDM]
public class CELDHBEKCDH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public int ILBGGFKMPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string EEGDLJAMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string OAHLNJJKPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CELDHBEKCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7955FC0", Offset = "0x79549C0", VA = "0x187955FC0")]
	public CELDHBEKCDH([Optional] Guid PCPOOIGHMLK, int GDCGOHLFNLP = 0, [Optional] string NKOEIJFFOFL, [Optional] string ANHJMJKANCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[NMCNMLEECDM]
public class BNNANBPCKPP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public const int AIPPEHOOOBK = 0;

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public long FIKDMAMJPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public PALFIHGDMPK PGILIOMOGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public string PNKBPKEIDLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public List<CELDHBEKCDH> ABIKJGNGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int BDBCDOKLIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public OGPADJCDAAA NICPEGJFIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		[CompilerGenerated]
		get
		{
			return default(OGPADJCDAAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public string ELCAKBODBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public bool NDNEPNMBBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x21D9F10", Offset = "0x21D8910", VA = "0x1821D9F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7955440", Offset = "0x7953E40", VA = "0x187955440")]
	public BNNANBPCKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x79554D0", Offset = "0x7953ED0", VA = "0x1879554D0")]
	public BNNANBPCKPP(long GJAGBHJANHL = 0L, [Optional] PALFIHGDMPK OJEONAHKAAF, [Optional] string NILCIGHBBCP, [Optional] List<CELDHBEKCDH> EMLAEABMMPO, int CKOENHFPFNP = 0, [Optional] string IELIBBNCJAC, OGPADJCDAAA MHLPAIHPPIO = OGPADJCDAAA.Private, [Optional] string OELMBNFNGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class EJDJJINJFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public readonly int NOJMGAAAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public readonly BNNANBPCKPP HJBPJACEAFF;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x109EE20", Offset = "0x109D820", VA = "0x18109EE20")]
	public EJDJJINJFOD(int KPCCLFNHPJC, BNNANBPCKPP BABKFLMJLEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[NMCNMLEECDM]
public class PALFIHGDMPK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public string GNIEMJGLBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public string PNNKFCJDHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public string CAGPPKBDKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public string FIJJCCCKIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public string AOHNMJAMBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public string ABIKJGNGHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x795E440", Offset = "0x795CE40", VA = "0x18795E440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PALFIHGDMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5068240", Offset = "0x5066C40", VA = "0x185068240")]
	public PALFIHGDMPK([Optional] string DFFHJJDFMII, [Optional] string MDCKKFDBNEB, [Optional] string HOIMHIMJBBL, [Optional] string FLIINIJOCEE, [Optional] string JOBCGCABNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[NMCNMLEECDM]
public class KCHBEBLDGAL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public Dictionary<int, BNNANBPCKPP> NLDNBJBFGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KCHBEBLDGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[NMCNMLEECDM]
public class OBKBBOHFOKP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public List<int> MLOJLAJIJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public byte? DLIKNBDBADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x3284B10", Offset = "0x3283510", VA = "0x183284B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x3284C00", Offset = "0x3283600", VA = "0x183284C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public int? GLMMNBHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x14033F0", Offset = "0x1401DF0", VA = "0x1814033F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1403420", Offset = "0x1401E20", VA = "0x181403420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OBKBBOHFOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class LLNEGADFIOB
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x795C190", Offset = "0x795AB90", VA = "0x18795C190")]
	public static HKGMBANLFND DJJPFENJIAF(this CELDHBEKCDH DKGBCFDLMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[Flags]
public enum AMLOJEALFHA
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum FDEIDHKCJEA
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[NMCNMLEECDM]
public class LKDAKICMOII : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	[DataMember(Name = "PlayerId")]
	public int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public int LBKEOPBGBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	public int MPOCDJNOAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LKDAKICMOII()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[NMCNMLEECDM]
	public class ProgressionEventRecordDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int NOJMGAAAMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public int PIKPOIHNECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public int LAKBAEIBEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public int JPJBHJBAMPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public int NJHMHEJMBKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public DateTime? EDLCCMBPJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public int CCLHLCPHFLD
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x795F750", Offset = "0x795E150", VA = "0x18795F750")]
		public ProgressionEventRecordDTO(int KPCCLFNHPJC = 0, int DOAHPABGPJL = 0, int HPIEPEDNNIL = 0, int FELJJGHIJND = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[NMCNMLEECDM]
	public class ProgressionEventDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long KEMMBOFCCJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public string DDPJMHMICBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public List<ProgressionEventRewardDTO> NACBKBNFDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public List<KeepsakeRoomListDTO> CBCGEOIPOKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public DateTime FKFNCAEJINK
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public DateTime NBHIMKHFABA
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public DateTime FFIOLHFOOJB
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public bool IMFHHKDPJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xDD31C0", Offset = "0xDD1BC0", VA = "0x180DD31C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public int MFFPBBDHFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x1538210", Offset = "0x1536C10", VA = "0x181538210")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x23894E0", Offset = "0x2387EE0", VA = "0x1823894E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public float ILJHLLMIIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x12CD6A0", Offset = "0x12CC0A0", VA = "0x1812CD6A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x14AB300", Offset = "0x14A9D00", VA = "0x1814AB300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public Guid? JHDLEBKEFKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x795F670", Offset = "0x795E070", VA = "0x18795F670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x795F690", Offset = "0x795E090", VA = "0x18795F690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public string PGNCNIOPPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public string MPMHHAGMIJC
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public string PFMCGMIMDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAB7BB0", Offset = "0xAB65B0", VA = "0x180AB7BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public string GEPFJMNGOKM
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x795F6A0", Offset = "0x795E0A0", VA = "0x18795F6A0")]
		public ProgressionEventDTO(long KEFAHAJFGLE = 0L, [Optional] string IELIBBNCJAC, [Optional] List<ProgressionEventRewardDTO> BBDFFFCDDOD, [Optional] List<KeepsakeRoomListDTO> NALKILBANLG, [Optional] DateTime OFLPMAPNJKG, [Optional] DateTime PDIIAGIDEOG, [Optional] DateTime IOBACBFHCIJ, bool HGMEEICLHDE = false, int NABJOJCADNH = 0, float AGGPMHCBMLB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[NMCNMLEECDM]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long JAMGCBIMLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public long KEMMBOFCCJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int? IIGHOCCENLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int? LJFDOGNFBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public long? IMPEGHFCKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public long GACOBLJMIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public TimeSpan NHEMIAFKEDE
		{
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x795C030", Offset = "0x795AA30", VA = "0x18795C030")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public long BHJOOAGAFLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public TimeSpan ALPNMCOKEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x795BFE0", Offset = "0x795A9E0", VA = "0x18795BFE0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public int FBHOFEJKKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x1026A90", Offset = "0x1025490", VA = "0x181026A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public LCIKBIAEKOC CFDNFJMGAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x13412A0", Offset = "0x133FCA0", VA = "0x1813412A0")]
			[CompilerGenerated]
			get
			{
				return default(LCIKBIAEKOC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x25616F0", Offset = "0x25600F0", VA = "0x1825616F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public List<KeepsakeRoomDTO> IGFEENIKBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x795C080", Offset = "0x795AA80", VA = "0x18795C080")]
		public KeepsakeRoomListDTO(long KBFNBNBEBAB = 0L, long KEFAHAJFGLE = 0L, [Optional] int? AMJMJLNMBAO, [Optional] int? OFFLODOLBIB, [Optional] long? DLMIAKGAMKJ, long IFBGIDEAFEN = 0L, long PBNODDKNFLE = 0L, int LKMJMKPMDGH = 0, LCIKBIAEKOC KPMOLHNALPE = LCIKBIAEKOC.Standard, [Optional] List<KeepsakeRoomDTO> MKLIIPOGFOI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[NMCNMLEECDM]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public long MPCOEHPNKED
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public long JELONAFLPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long JAMGCBIMLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		public LCIKBIAEKOC EMHLKEMKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
			[CompilerGenerated]
			get
			{
				return default(LCIKBIAEKOC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public int ALCDHGPIINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x795BF80", Offset = "0x795A980", VA = "0x18795BF80")]
		public KeepsakeRoomDTO(long BOPHKBCBNEI = 0L, long GDCAPMONNDM = 0L, long KBFNBNBEBAB = 0L, LCIKBIAEKOC DGNODDPLLPC = LCIKBIAEKOC.Standard, int MOKDONKKJGG = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[NMCNMLEECDM]
	public class ProgressionEventRewardDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public long NKONBNNHFKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public int COIFGFCPPAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public string PBPJPBFPLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public int PIKPOIHNECG
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public int GFMKGBLOJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public bool KMIJCJFHNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public bool CNDMLJCMGME
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0xF79550", Offset = "0xF77F50", VA = "0x180F79550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x1626120", Offset = "0x1624B20", VA = "0x181626120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[NMCNMLEECDM]
	public class ProgressionEventPurchasableXpBoostDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Guid DFIJHFNCGEC
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int DKCFKCBPJAF
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public int DMPKMGGGCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public int EAHPGMLFIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public long BJLOBKLLFLC
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public long PJFBJJMGODL
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public enum LCIKBIAEKOC
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public enum OJBCBIHCMHF
{
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[NMCNMLEECDM]
public class ENILJOLKFMD : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public string EDBPDGHPKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public string? NDFBHDFHOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ENILJOLKFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface JLBJIODKMGG
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	bool ANDPHKADADF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	string? GOEGMEJBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	string? HHECMJONEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface FCGNLEDIIPA<T> : JLBJIODKMGG
{
	[Cpp2IlInjected.Token(Token = "0x17000212")]
	T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class AHLDGLKLKPK
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x32D75A0", Offset = "0x32D5FA0", VA = "0x1832D75A0")]
	public static FCGNLEDIIPA<T> AJEDGAAHNKE<T, U>(this FCGNLEDIIPA<U> GGIKEMCHAAA, Func<U, T> PPDBENNPGFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct BGEJEHAENKP<T> : FCGNLEDIIPA<T>, JLBJIODKMGG
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool ANDPHKADADF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x10D7B10", Offset = "0x10D6510", VA = "0x1810D7B10", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string? GOEGMEJBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xB51470", Offset = "0xB4FE70", VA = "0x180B51470", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xF728C0", Offset = "0xF712C0", VA = "0x180F728C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public string? HHECMJONEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6693CB0", Offset = "0x66926B0", VA = "0x186693CB0")]
	public static BGEJEHAENKP<T> KEOGHOIFMHC(T KMAFNKGMDCF)
	{
		return default(BGEJEHAENKP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6693D50", Offset = "0x6692750", VA = "0x186693D50")]
	public static BGEJEHAENKP<T> LNAAIDJILAA(string IHPAEKNOMOJ, string OELKOHJOGJA = "")
	{
		return default(BGEJEHAENKP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[NMCNMLEECDM]
public class ENEHDIDOEFG : JLBJIODKMGG, HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public bool ANDPHKADADF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public string? GOEGMEJBNMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	[DataMember(Name = "error_id")]
	public string? HHECMJONEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public virtual void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x7957EF0", Offset = "0x79568F0", VA = "0x187957EF0")]
	public static ENEHDIDOEFG KEOGHOIFMHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x7957F60", Offset = "0x7956960", VA = "0x187957F60")]
	public static ENEHDIDOEFG LNAAIDJILAA(string IHPAEKNOMOJ, string OELKOHJOGJA = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ENEHDIDOEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[CHANNPPKAHC]
public abstract class KADCEGKBANA<T> : ENEHDIDOEFG, FCGNLEDIIPA<T>, JLBJIODKMGG
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xC1EBD0", Offset = "0xC1D5D0", VA = "0x180C1EBD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	protected KADCEGKBANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[CHANNPPKAHC]
public class EBNPNMLLHLM<T> : KADCEGKBANA<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6560", Offset = "0x4AF4F60", VA = "0x184AF6560")]
	private static void MFECABJOBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
	public EBNPNMLLHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[CHANNPPKAHC]
public class IHPFBOBMIJI<T> : KADCEGKBANA<T>, APPPDLBPNNL, HJBDJGHOGMK where T : HJBDJGHOGMK, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct PPPHFMJAAJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public IHPFBOBMIJI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9310", Offset = "0x5CD7D10", VA = "0x185CD9310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9590", Offset = "0x5CD7F90", VA = "0x185CD9590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x52ED320", Offset = "0x52EBD20", VA = "0x1852ED320", Slot = "8")]
	public override void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x52ED250", Offset = "0x52EBC50", VA = "0x1852ED250", Slot = "10")]
	[AsyncStateMachine(typeof(IHPFBOBMIJI<>.PPPHFMJAAJF))]
	public Task DBOLDCHIAGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x52ED3B0", Offset = "0x52EBDB0", VA = "0x1852ED3B0")]
	public static IHPFBOBMIJI<T> KEOGHOIFMHC(T KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x52ED4F0", Offset = "0x52EBEF0", VA = "0x1852ED4F0")]
	public new static IHPFBOBMIJI<T> LNAAIDJILAA(string IHPAEKNOMOJ, string OELKOHJOGJA = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x45C6BC0", Offset = "0x45C55C0", VA = "0x1845C6BC0")]
	public IHPFBOBMIJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[CHANNPPKAHC]
public class MEBNGDLFMOL<T> : KADCEGKBANA<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
	public MEBNGDLFMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[CHANNPPKAHC]
public class EBBKIEKHFLD<T> : KADCEGKBANA<List<T>>, APPPDLBPNNL, HJBDJGHOGMK where T : HJBDJGHOGMK, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct GIMIGCHMPOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public EBBKIEKHFLD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x512F5E0", Offset = "0x512DFE0", VA = "0x18512F5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x512F7E0", Offset = "0x512E1E0", VA = "0x18512F7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5400", Offset = "0x4AF3E00", VA = "0x184AF5400")]
	public static EBBKIEKHFLD<T> KEOGHOIFMHC(List<T> KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5530", Offset = "0x4AF3F30", VA = "0x184AF5530")]
	public new static EBBKIEKHFLD<T> LNAAIDJILAA(string IHPAEKNOMOJ, string OELKOHJOGJA = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x4AF51B0", Offset = "0x4AF3BB0", VA = "0x184AF51B0", Slot = "8")]
	public override void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x4AF50E0", Offset = "0x4AF3AE0", VA = "0x184AF50E0", Slot = "10")]
	[AsyncStateMachine(typeof(EBBKIEKHFLD<>.GIMIGCHMPOF))]
	public Task DBOLDCHIAGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5680", Offset = "0x4AF4080", VA = "0x184AF5680")]
	public EBBKIEKHFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public enum HHHMIEFPOCL
{
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class AGGFCJKGOJM
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7953A30", Offset = "0x7952430", VA = "0x187953A30")]
	public static bool EPDCMDDBAKO(this HHHMIEFPOCL DGDHAMECAIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7953A30", Offset = "0x7952430", VA = "0x187953A30")]
	public static bool HADONCLJLHE(this HHHMIEFPOCL DGDHAMECAIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum LMFNPHDGODM
{
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	ProgressionEvent = 400,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	RoomieCredits = 500
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public enum EBECOMOBJJD
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NonPurchasedEarnedByP2Pv2 = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	RoomieEnergyPack = 1101
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum OMIDHABEBNI
{
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Paintball_MerryMidway = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public enum BJHDLCNOPOE
{
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public enum LACADHPJJMN
{
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000375")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000377")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[NMCNMLEECDM]
	public class BalanceResponseDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public LMFNPHDGODM CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(LMFNPHDGODM);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		[DataMember(Name = "Platform")]
		public EBECOMOBJJD BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
			[CompilerGenerated]
			get
			{
				return default(EBECOMOBJJD);
			}
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public virtual void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[NMCNMLEECDM]
	public class FilteredTextDTO : HJBDJGHOGMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public string MCFBIHIKFGH
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public int BEBAPINCAGA
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[NMCNMLEECDM]
public class EPEHLLAICDK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public long BDKDCCGPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public DateTime FKFNCAEJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public DateTime NBHIMKHFABA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public int KEPHNFEDBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public int COIFGFCPPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xAEE7D0", Offset = "0xAED1D0", VA = "0x180AEE7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xAED910", Offset = "0xAEC310", VA = "0x180AED910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EPEHLLAICDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[NMCNMLEECDM]
public class MCDBGDEBFGF : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public long BDKDCCGPBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public int NOJMGAAAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public int PIKPOIHNECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MCDBGDEBFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class DHELACGCDHD
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum GINGPABHDBE
	{
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[NMCNMLEECDM]
public class CEGFKPKCFHC : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public Guid EEEAFLALBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public long PCBIJPBFBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public BGHGPCCGDKM IBHGLCHGLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CEGFKPKCFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x7955F60", Offset = "0x7954960", VA = "0x187955F60")]
	public CEGFKPKCFHC(long GDCAPMONNDM, Guid HPPLLHHCNJA, long BKCEIDHPFJM, BGHGPCCGDKM NOEMOILOKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x7955F40", Offset = "0x7954940", VA = "0x187955F40", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[NMCNMLEECDM]
public class ENKFMEDMAII : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public NKPGOMFEIGH ECLPEGKCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(NKPGOMFEIGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public LGEEKDLHLIB MAEAAKCMKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ENKFMEDMAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x109EE20", Offset = "0x109D820", VA = "0x18109EE20")]
	public ENKFMEDMAII(NKPGOMFEIGH GGIKEMCHAAA, LGEEKDLHLIB JANGCDFCPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[NMCNMLEECDM]
public class BGHGPCCGDKM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public Guid? MOBMAGBCNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x325EFB0", Offset = "0x325D9B0", VA = "0x18325EFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7955260", Offset = "0x7953C60", VA = "0x187955260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public Guid LBGCJBEAOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xECFB90", Offset = "0xECE590", VA = "0x180ECFB90")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x10D0D90", Offset = "0x10CF790", VA = "0x1810D0D90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BGHGPCCGDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x7955270", Offset = "0x7953C70", VA = "0x187955270")]
	public BGHGPCCGDKM(Guid? FMMIELFCKAP, Guid BMDPCKBNBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[NMCNMLEECDM]
public class LGEEKDLHLIB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public Guid EEEAFLALBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public long BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public Guid NMPLDIOGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LGEEKDLHLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[NMCNMLEECDM]
public class EPIKLMFELLB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public List<long> GAHGMONNAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public List<BFIOACCMCMK> MOCBKMGPNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string GHDPEELJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public byte? MLIKFJLMGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7958120", Offset = "0x7956B20", VA = "0x187958120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7958140", Offset = "0x7956B40", VA = "0x187958140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public int? HCMEEMNMDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7958130", Offset = "0x7956B30", VA = "0x187958130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7958180", Offset = "0x7956B80", VA = "0x187958180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public Guid? AFELHFMAIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7958160", Offset = "0x7956B60", VA = "0x187958160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7958150", Offset = "0x7956B50", VA = "0x187958150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public bool FPNFIOJCDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EPIKLMFELLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[NMCNMLEECDM]
public class MGMMOAHIKDI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public Guid AFELHFMAIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string GHDPEELJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public List<long> GAHGMONNAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public List<GDKAEKAIFPN> MOCBKMGPNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public byte MLIKFJLMGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xB2F800", Offset = "0xB2E200", VA = "0x180B2F800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public int HCMEEMNMDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xAE4550", Offset = "0xAE2F50", VA = "0x180AE4550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1619010", Offset = "0x1617A10", VA = "0x181619010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MGMMOAHIKDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[NMCNMLEECDM]
public class IMGPNPCLJFN : MGMMOAHIKDI
{
	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public Guid APFHNFCEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xF59880", Offset = "0xF58280", VA = "0x180F59880")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x4603C50", Offset = "0x4602650", VA = "0x184603C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IMGPNPCLJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public enum NKPGOMFEIGH
{
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public interface BJMPNEAFPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KADCEGKBANA<MGMMOAHIKDI>> IEBKMPABNGE(Guid? GBFHHPHEKAE, long GDCAPMONNDM, string IELIBBNCJAC, string GDFPOPIGPDJ, string CGPNBEBFGEL, string OIJFLKEKDGO, byte ENDDNPPKCPO, int EOGEFFOIIOP, [Optional] List<long> LBBOFEDLGGN, [Optional] List<GDKAEKAIFPN> JAGOMLPEFCP, bool DFEBCDBMDKF = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KADCEGKBANA<MGMMOAHIKDI>> OCFKHJEHOHO(Guid HPPLLHHCNJA, long GDCAPMONNDM, [Optional] string IELIBBNCJAC, [Optional] string GDFPOPIGPDJ, [Optional] string CGPNBEBFGEL, [Optional] List<long> LBBOFEDLGGN, [Optional] Dictionary<string, string> JAGOMLPEFCP, [Optional] string OIJFLKEKDGO, [Optional] byte? ENDDNPPKCPO, [Optional] int? EOGEFFOIIOP, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ENEHDIDOEFG> BNMOGMLKNCN(Guid HPPLLHHCNJA, long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<MGMMOAHIKDI>> CFAKFDABPPO(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<LGEEKDLHLIB>> JDPCKMKJHPO(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<ENKFMEDMAII>> PECONEAEJHD(long GDCAPMONNDM, List<CEGFKPKCFHC> FOEBBIIMICK, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[NMCNMLEECDM]
public class BFIOACCMCMK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string GHDPEELJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BFIOACCMCMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[NMCNMLEECDM]
public class GDKAEKAIFPN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public long LNGDBCEJPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public string GHDPEELJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GDKAEKAIFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[NMCNMLEECDM]
public class POKHMJDDKBC : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public long LNGDBCEJPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public string GHDPEELJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC7A0", Offset = "0x1CEB1A0", VA = "0x181CEC7A0")]
	public POKHMJDDKBC(long CFKONBPFBGN, string PIBAONGDHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface NIJIGLNFEJN
{
	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KADCEGKBANA<List<GDKAEKAIFPN>>> IHCMLJPPLDC(long GDCAPMONNDM, List<POKHMJDDKBC> FOEBBIIMICK, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ENEHDIDOEFG> PHELKAJADKI(long CFKONBPFBGN, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<GDKAEKAIFPN>> LLBGOGLEBLD(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[NMCNMLEECDM]
public class MLKNCBAOAPH : GCBFFNGFBNN, IEquatable<MLKNCBAOAPH>
{
	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x79595B0", Offset = "0x7957FB0", VA = "0x1879595B0", Slot = "7")]
	public bool Equals(MLKNCBAOAPH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x795C4A0", Offset = "0x795AEA0", VA = "0x18795C4A0", Slot = "6")]
	public override GCBFFNGFBNN AFCIIKKNNFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MLKNCBAOAPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class PFMJOEAGDOC
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x795E800", Offset = "0x795D200", VA = "0x18795E800")]
	public static MLKNCBAOAPH ENMICGMLGAF(this CDBNKOPIMAJ EOJOFJJBHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x795E870", Offset = "0x795D270", VA = "0x18795E870")]
	public static MLKNCBAOAPH KNDMBFMMLME(string AMGNMJKIIFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[NMCNMLEECDM]
public class CDBNKOPIMAJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int IHCIFGGJFMN = 3;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public const int PFCBHJNONAD = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public const int GJNDBJDJCFL = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public const int PNIGABKPGCO = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public const int ANBMANKJHEL = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public const int KNFAAAHIPDC = 8;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public const int BGFOCMJCAKL = 1;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public const int OPHGPKEFNAH = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public const int LFLDEEFOLEG = 9999;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public const int JJKEDGIONEN = 1;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public const int AGHGFDKMOMA = 1000000000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? CBABJHLOCEG;

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public Guid AFELHFMAIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public string? ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public string? PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xB2EDB0", Offset = "0xB2D7B0", VA = "0x180B2EDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public bool MFJNLDFCDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x19D98C0", Offset = "0x19D82C0", VA = "0x1819D98C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x19F8950", Offset = "0x19F7350", VA = "0x1819F8950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	internal int? GEIJDGDBGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	[IgnoreDataMember]
	public int HJBIMMNBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7955BD0", Offset = "0x79545D0", VA = "0x187955BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	internal int? DLGHGBEPAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xFEB730", Offset = "0xFEA130", VA = "0x180FEB730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	[IgnoreDataMember]
	public int MNCAJJPALPO
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x7955C70", Offset = "0x7954670", VA = "0x187955C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public Guid? PCKDICLHJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7955C40", Offset = "0x7954640", VA = "0x187955C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7955BA0", Offset = "0x79545A0", VA = "0x187955BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xAE4550", Offset = "0xAE2F50", VA = "0x180AE4550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x1619010", Offset = "0x1617A10", VA = "0x181619010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public int? MOBAMPKANPP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x1001750", Offset = "0x1000150", VA = "0x181001750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public int? KEDCFJBPNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x1001D40", Offset = "0x1000740", VA = "0x181001D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public IReadOnlyList<DCBLAFMEJAI> HMLCFEDJMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x51D4400", Offset = "0x51D2E00", VA = "0x1851D4400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D80", Offset = "0x2A97780", VA = "0x182A98D80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	[IgnoreDataMember]
	public GJFJKNIHJKL BDEAKBGCNLD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7955CE0", Offset = "0x79546E0", VA = "0x187955CE0")]
		get
		{
			return default(GJFJKNIHJKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> EADGNFKIALN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7955B00", Offset = "0x7954500", VA = "0x187955B00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	[IgnoreDataMember]
	public string? CCMANHCINIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	[IgnoreDataMember]
	public bool OPEONAJHAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7955BB0", Offset = "0x79545B0", VA = "0x187955BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	[IgnoreDataMember]
	public string? PHKKJGKBFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	[IgnoreDataMember]
	public bool HOPMHAKCFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7955CC0", Offset = "0x79546C0", VA = "0x187955CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	[IgnoreDataMember]
	public int? ADLNIKBMGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x1D04100", Offset = "0x1D02B00", VA = "0x181D04100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	[IgnoreDataMember]
	public bool FPHMJHHPAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7955B60", Offset = "0x7954560", VA = "0x187955B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	[IgnoreDataMember]
	public int MMHOGMGEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7955D50", Offset = "0x7954750", VA = "0x187955D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	[IgnoreDataMember]
	public string? KDDFOMBCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xEE2970", Offset = "0xEE1370", VA = "0x180EE2970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	[IgnoreDataMember]
	public bool ONIOEEBKCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7955C20", Offset = "0x7954620", VA = "0x187955C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x7955C60", Offset = "0x7954660", VA = "0x187955C60", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CDBNKOPIMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x7955DD0", Offset = "0x79547D0", VA = "0x187955DD0")]
	public CDBNKOPIMAJ(Guid GBFHHPHEKAE, long GDCAPMONNDM, string IELIBBNCJAC, string GDFPOPIGPDJ, string CGPNBEBFGEL, int MANOLGLEOMD, bool GPLGMENJLMF, int? ONBCFPIHPKM, int? DMDOCHBPEJE, int? JEINODHNEKF, int? LAEKJBPFCHM, List<DCBLAFMEJAI> FJAJIIEBEAC, [Optional] DateTime HJMDCHHCMEE, [Optional] DateTime CHEOOPMFAPE, [Optional] Guid? PBIENKDJCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x7955A90", Offset = "0x7954490", VA = "0x187955A90")]
	private GJFJKNIHJKL DACIAOMKFGC()
	{
		return default(GJFJKNIHJKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x79557D0", Offset = "0x79541D0", VA = "0x1879557D0")]
	private Dictionary<Guid, int> BEPILGJIOJA(IReadOnlyList<DCBLAFMEJAI> FJAJIIEBEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[NMCNMLEECDM]
public class HIFKNMEJABL : HJBDJGHOGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public Guid AFELHFMAIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public long JELONAFLPBN;

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HIFKNMEJABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[NMCNMLEECDM]
public class CPIINMABFIK : CDBNKOPIMAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public Guid BNPMAGMFHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x12CD660", Offset = "0x12CC060", VA = "0x1812CD660")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x1770220", Offset = "0x176EC20", VA = "0x181770220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Guid? NDLKNKPIGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7957320", Offset = "0x7955D20", VA = "0x187957320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7957340", Offset = "0x7955D40", VA = "0x187957340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CPIINMABFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[NMCNMLEECDM]
public class FBLAFHGOBKJ : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public string? ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public string? PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public bool MFJNLDFCDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x18AB960", Offset = "0x18AA360", VA = "0x1818AB960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x10C54D0", Offset = "0x10C3ED0", VA = "0x1810C54D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public int? GEIJDGDBGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public int? DLGHGBEPAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public int? MOBAMPKANPP
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xFEB710", Offset = "0xFEA110", VA = "0x180FEB710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public int? KEDCFJBPNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x1408920", Offset = "0x1407320", VA = "0x181408920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public List<DCBLAFMEJAI> HMLCFEDJMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public Guid? NDLKNKPIGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7955C40", Offset = "0x7954640", VA = "0x187955C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7955BA0", Offset = "0x79545A0", VA = "0x187955BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public Guid? AFELHFMAIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x518FDE0", Offset = "0x518E7E0", VA = "0x18518FDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x518E2B0", Offset = "0x518CCB0", VA = "0x18518E2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public bool FPNFIOJCDKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xE218E0", Offset = "0xE202E0", VA = "0x180E218E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x7958190", Offset = "0x7956B90", VA = "0x187958190", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FBLAFHGOBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[NMCNMLEECDM]
public class DCBLAFMEJAI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public FELEGELDJOL NGLODIAJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(FELEGELDJOL);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public Guid KNMHJPFKLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A70", Offset = "0x1C20470", VA = "0x181C21A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC700", Offset = "0x5EFB100", VA = "0x185EFC700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DCBLAFMEJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7957360", Offset = "0x7955D60", VA = "0x187957360")]
	public DCBLAFMEJAI(Guid MDKFJFHCKIF, FELEGELDJOL DGNODDPLLPC, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[NMCNMLEECDM]
public class MAHNKPHFAAP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public Guid FCMGJLENPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000286")]
	public int PHFNFLFHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public DateTime GCAPAOGNEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x795C200", Offset = "0x795AC00", VA = "0x18795C200")]
	public MAHNKPHFAAP(Guid BCFMKAGABNE, string IELIBBNCJAC, int GICMEDGKCKL, DateTime OFFMPPLENOD, int PKNNCMNKNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MAHNKPHFAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[NMCNMLEECDM]
public class MBOCOAHGGGA : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public Guid FCMGJLENPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public int ALKJPPENGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MBOCOAHGGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x5BAB220", Offset = "0x5BA9C20", VA = "0x185BAB220")]
	public MBOCOAHGGGA(Guid BCFMKAGABNE, int BEJINJLFMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[NMCNMLEECDM]
public class NEPMOCBKDOO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public int ALKJPPENGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public Guid FPJPIJBJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A70", Offset = "0x1C20470", VA = "0x181C21A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC700", Offset = "0x5EFB100", VA = "0x185EFC700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public int CBABBBACMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public Guid? EMNKNMFCENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x1002B20", Offset = "0x1001520", VA = "0x181002B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x25540B0", Offset = "0x2552AB0", VA = "0x1825540B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public int GOILHGNLGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xACB3F0", Offset = "0xAC9DF0", VA = "0x180ACB3F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x1794EA0", Offset = "0x17938A0", VA = "0x181794EA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public Dictionary<Guid, Guid?> DIAIHEBHHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NEPMOCBKDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x795D110", Offset = "0x795BB10", VA = "0x18795D110")]
	public NEPMOCBKDOO(int BEJINJLFMIP, Guid MBEAOLFIINO, int FELOPJKLDKO, Guid? PIGGHEHAGJG, int OBHGAEGJJPN, Dictionary<Guid, Guid?> BLDNJPFHHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[NMCNMLEECDM]
public class HGNCPMJBHEM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public IPBGLCGMMCD DJGJKAIHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(IPBGLCGMMCD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public LACADHPJJMN? JKIIHHFMBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x14033C0", Offset = "0x1401DC0", VA = "0x1814033C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x1404710", Offset = "0x1403110", VA = "0x181404710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public BalanceResponseDTO GKPMPAFIDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public List<LGEEKDLHLIB> GECJPNICGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HGNCPMJBHEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x795A610", Offset = "0x7959010", VA = "0x18795A610")]
	public HGNCPMJBHEM(IPBGLCGMMCD EIDBENAHBGH, LACADHPJJMN? DNIEJKCGGOK, BalanceResponseDTO OGEDNOECHMI, List<LGEEKDLHLIB> DKAFKNBIKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x795A600", Offset = "0x7959000", VA = "0x18795A600", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum FELEGELDJOL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum IPBGLCGMMCD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	InvalidDynamicPriceSettings = 15,
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	InvalidDynamicPrice = 16,
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum GJFJKNIHJKL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface ONCDPENGOJI
{
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	static AHDLCNFLGGK<CDBNKOPIMAJ> KKPINAIGKHC;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	static AHDLCNFLGGK<CDBNKOPIMAJ> GPFFBHNPPND;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	static AHDLCNFLGGK<Guid> MMMPMPGCHOD;

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KADCEGKBANA<CDBNKOPIMAJ?>?>? CPENGBKAGIC(Guid? GBFHHPHEKAE, long GDCAPMONNDM, string IELIBBNCJAC, string? GDFPOPIGPDJ, string? CGPNBEBFGEL, int MANOLGLEOMD, bool GPLGMENJLMF, int ONBCFPIHPKM, int DMDOCHBPEJE, GJFJKNIHJKL MOCCACNMFLN, [Optional] Dictionary<Guid, int>? CPDLMNLAHHJ, [Optional] Guid? HGDFBLJLHAD, bool DFEBCDBMDKF = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KADCEGKBANA<CDBNKOPIMAJ?>?>? BNPJMEGDMEG(Guid BCFMKAGABNE, long GDCAPMONNDM, string IELIBBNCJAC, string? GDFPOPIGPDJ, string? CGPNBEBFGEL, int MANOLGLEOMD, bool GPLGMENJLMF, int ONBCFPIHPKM, int DMDOCHBPEJE, GJFJKNIHJKL MOCCACNMFLN, [Optional] Dictionary<Guid, int>? CPDLMNLAHHJ, [Optional] Guid? HGDFBLJLHAD, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ENEHDIDOEFG> OKIAGDHJEFO(Guid BCFMKAGABNE, long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<CDBNKOPIMAJ>> KGAGBMOGIMK(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<KADCEGKBANA<List<MBOCOAHGGGA>>> HODICKCJJEL(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KADCEGKBANA<List<MAHNKPHFAAP>>> NCLEIMCCFKM(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<HGNCPMJBHEM> LMDADAEDBJH(Guid BCFMKAGABNE, long GDCAPMONNDM, int BEJINJLFMIP, int FELOPJKLDKO, Guid? HINFODKCAEO, int OBHGAEGJJPN, Dictionary<Guid, Guid?> KPAODIGMGGB, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x795E2E0", Offset = "0x795CCE0", VA = "0x18795E2E0")]
	static ONCDPENGOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[NMCNMLEECDM]
public class AGGLDMINJEF : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public bool JOFKFDPIEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AGGLDMINJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface EMNBHIODAJO
{
	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AGGLDMINJEF> KENNINKPHBK(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ENEHDIDOEFG> JJNHGJBLAAB(long GDCAPMONNDM, bool LOHOAFEKKCG, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[CHANNPPKAHC]
public class GPMMFGGIAMN<DataType> where DataType : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public long FCECLLCDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public LMFNPHDGODM FLJCMKOBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(LMFNPHDGODM);
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public EBECOMOBJJD CHMBNECCLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
		[CompilerGenerated]
		get
		{
			return default(EBECOMOBJJD);
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public DataType AMLFHELBNMB
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GPMMFGGIAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[CHANNPPKAHC]
public class CLAIABHBDKH<DataType> where DataType : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public long FCECLLCDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public LMFNPHDGODM FLJCMKOBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(LMFNPHDGODM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public EBECOMOBJJD CHMBNECCLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
		[CompilerGenerated]
		get
		{
			return default(EBECOMOBJJD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xEFFCF0", Offset = "0xEFE6F0", VA = "0x180EFFCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public List<DataType> AMLFHELBNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CLAIABHBDKH()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CHANNPPKAHC]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HJBDJGHOGMK, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CHANNPPKAHC]
		public class LFBLDDHNHPA : APPPDLBPNNL, HJBDJGHOGMK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private struct LKABOBHKPPD : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000438")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000439")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043A")]
				public LFBLDDHNHPA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000646")]
				[Cpp2IlInjected.Address(RVA = "0x573A9B0", Offset = "0x57393B0", VA = "0x18573A9B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000647")]
				[Cpp2IlInjected.Address(RVA = "0x573AC80", Offset = "0x5739680", VA = "0x18573AC80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A0")]
			public LACADHPJJMN MDACHMNKHJI
			{
				[Cpp2IlInjected.Token(Token = "0x600063F")]
				[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
				[CompilerGenerated]
				get
				{
					return default(LACADHPJJMN);
				}
				[Cpp2IlInjected.Token(Token = "0x6000640")]
				[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A1")]
			public DataTypeDTO AMLFHELBNMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000641")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000642")]
				[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x5722120", Offset = "0x5720B20", VA = "0x185722120", Slot = "5")]
			public void JCFGPHPCCIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x5722050", Offset = "0x5720A50", VA = "0x185722050", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.LFBLDDHNHPA.LKABOBHKPPD))]
			public Task DBOLDCHIAGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public LFBLDDHNHPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		public List<LFBLDDHNHPA> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x5D110E0", Offset = "0x5D0FAE0", VA = "0x185D110E0", Slot = "5")]
		public override void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CHANNPPKAHC]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : HJBDJGHOGMK, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		[CHANNPPKAHC]
		public class GNHDPBAIMDI : APPPDLBPNNL, HJBDJGHOGMK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EC")]
			[CompilerGenerated]
			private struct DACIPKJJDAF : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400043F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000440")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000441")]
				public GNHDPBAIMDI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000442")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000653")]
				[Cpp2IlInjected.Address(RVA = "0x45CFB50", Offset = "0x45CE550", VA = "0x1845CFB50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000654")]
				[Cpp2IlInjected.Address(RVA = "0x45CFDA0", Offset = "0x45CE7A0", VA = "0x1845CFDA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A3")]
			public LACADHPJJMN MDACHMNKHJI
			{
				[Cpp2IlInjected.Token(Token = "0x600064C")]
				[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
				[CompilerGenerated]
				get
				{
					return default(LACADHPJJMN);
				}
				[Cpp2IlInjected.Token(Token = "0x600064D")]
				[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002A4")]
			public List<DataTypeDTO> AMLFHELBNMB
			{
				[Cpp2IlInjected.Token(Token = "0x600064E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600064F")]
				[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x5152780", Offset = "0x5151180", VA = "0x185152780", Slot = "5")]
			public void JCFGPHPCCIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x51526B0", Offset = "0x51510B0", VA = "0x1851526B0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.GNHDPBAIMDI.DACIPKJJDAF))]
			public Task DBOLDCHIAGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public GNHDPBAIMDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public List<GNHDPBAIMDI> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x5D110E0", Offset = "0x5D0FAE0", VA = "0x185D110E0", Slot = "5")]
		public override void JCFGPHPCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[HPPJACALLDC]
public class IOOCAMEFMPL : PurchaseBalanceUpdateResponseDTO<NDAMNDNBEKH>
{
	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x795B2F0", Offset = "0x7959CF0", VA = "0x18795B2F0")]
	public IOOCAMEFMPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[HPPJACALLDC]
public class HEPPDLCBNPM : PurchaseBalanceUpdateResponseDTO<NDAMNDNBEKH>.GNHDPBAIMDI
{
	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x795A5C0", Offset = "0x7958FC0", VA = "0x18795A5C0")]
	public HEPPDLCBNPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[NMCNMLEECDM]
public class MHLOALDKMIB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public MMDHIIEJGLF FCNMDLJDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public long GCBBAKPCJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public GiftItemDTO? DAJHDNPFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public long? FILIPNCKKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public int JLDAOEJOHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x795C420", Offset = "0x795AE20", VA = "0x18795C420")]
	public MHLOALDKMIB(MMDHIIEJGLF AJPMHCMPIPO, long MCIFNPFIHOD, GiftItemDTO? GPLPEJGDGAD, int FNALNEELHDE = 1, [Optional] long? FPNNJGOGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[NMCNMLEECDM]
public class KCCDMPIIJOG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public List<MHLOALDKMIB> DOCOFDBJOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public MNKKBGFEDOF? FBGEEDLNMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public LMFNPHDGODM FLJCMKOBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(LMFNPHDGODM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public bool FOEIOIHKMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E60", Offset = "0xEC6860", VA = "0x180EC7E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F70", Offset = "0xEC6970", VA = "0x180EC7F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public bool BJDNLAMLJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x1677E60", Offset = "0x1676860", VA = "0x181677E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x29B9610", Offset = "0x29B8010", VA = "0x1829B9610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public Guid? OOABAIMLGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1002B20", Offset = "0x1001520", VA = "0x181002B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x25540B0", Offset = "0x2552AB0", VA = "0x1825540B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x795B9F0", Offset = "0x795A3F0", VA = "0x18795B9F0")]
	public KCCDMPIIJOG(List<MHLOALDKMIB> LNAFNMFDJLM, MNKKBGFEDOF? GDOALLFDIEI, LMFNPHDGODM MPANHJMLCKL, bool MFJHIKILDHO, bool AFFKEJLBFOL = false, [Optional] Guid? CMEFKHGDGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[NMCNMLEECDM]
public class EEPEABGHNJH : APPPDLBPNNL, HJBDJGHOGMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct KLNMHCBDONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public EEPEABGHNJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x795BC40", Offset = "0x795A640", VA = "0x18795BC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x795BF20", Offset = "0x795A920", VA = "0x18795BF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	internal static Action<NDAMNDNBEKH>? EBOEHEHBEAC;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	internal static Func<NDAMNDNBEKH, Task>? HPFKBHOLADK;

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public NDAMNDNBEKH KHCBHKFEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public int? DFAIJJHPPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public HJLACLGONDN? MLBFADNAKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7957DB0", Offset = "0x79567B0", VA = "0x187957DB0", Slot = "5")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x7957CE0", Offset = "0x79566E0", VA = "0x187957CE0", Slot = "6")]
	[AsyncStateMachine(typeof(KLNMHCBDONM))]
	public virtual Task DBOLDCHIAGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EEPEABGHNJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[HPPJACALLDC]
public class MFPAHCLODNM : BalanceUpdateResponseDTO<EEPEABGHNJH>
{
	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x795C270", Offset = "0x795AC70", VA = "0x18795C270")]
	public MFPAHCLODNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[HPPJACALLDC]
public class BJDKAAPAFHD : BalanceUpdateResponseDTO<EEPEABGHNJH>.LFBLDDHNHPA
{
	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x79552C0", Offset = "0x7953CC0", VA = "0x1879552C0")]
	public BJDKAAPAFHD()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[NMCNMLEECDM]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		public OMIDHABEBNI GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
			[CompilerGenerated]
			get
			{
				return default(OMIDHABEBNI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[NMCNMLEECDM]
public class HPHKLJMNEEE : HJBDJGHOGMK, LGHAMIPCGHL
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	public PIEGLCNCEHC? MONGEDMGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	[IgnoreDataMember]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x795AFC0", Offset = "0x79599C0", VA = "0x18795AFC0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	public MMDHIIEJGLF? PBKIPIFBBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	public List<EEJCFNMDBNE>? HDNJHLLAGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	public DateTime? APODPBBHDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	public DateTime? KBOMJMNAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x167E000", Offset = "0x167CA00", VA = "0x18167E000", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x167E200", Offset = "0x167CC00", VA = "0x18167E200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	public DateTime? JLLAGDDOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A80", Offset = "0xEC8480", VA = "0x180EC9A80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9360", Offset = "0x5EF7D60", VA = "0x185EF9360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	public bool HLGFOMCBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD7DEA0", Offset = "0xD7C8A0", VA = "0x180D7DEA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD7D250", Offset = "0xD7BC50", VA = "0x180D7D250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	public bool PPGEIIBJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x10F3100", Offset = "0x10F1B00", VA = "0x1810F3100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x12D0210", Offset = "0x12CEC10", VA = "0x1812D0210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	public bool NMKKFKNGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x10B2160", Offset = "0x10B0B60", VA = "0x1810B2160", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x12D0200", Offset = "0x12CEC00", VA = "0x1812D0200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	public bool FJBIPDCKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x10AA260", Offset = "0x10A8C60", VA = "0x1810AA260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A00", Offset = "0x10B0400", VA = "0x1810B1A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x795B040", Offset = "0x7959A40", VA = "0x18795B040")]
	public static HPHKLJMNEEE BNLEGFCJOAB(Guid PCPOOIGHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HPHKLJMNEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[NMCNMLEECDM]
public class ABLGPDJIBAI
{
	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	public string ELPFAJHJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	public string GEGMNPMLLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	public Dictionary<int, ADFKFEBIBNK> CCMNDELGIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	public Dictionary<string, int> LKOGJAECBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public Dictionary<KKJOHCAGGKO, List<int>> DKBOGIJLHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public Dictionary<string, string> MFIICPBCNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ABLGPDJIBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum KKJOHCAGGKO
{
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[NMCNMLEECDM]
public class ADFKFEBIBNK : HJJGPGJIOEN
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public AMLOJEALFHA NECKOKLOMME
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(AMLOJEALFHA);
		}
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public bool MAFOBBNKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x1341D00", Offset = "0x1340700", VA = "0x181341D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x1679750", Offset = "0x1678150", VA = "0x181679750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public bool HBNCHMKKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x20E4CB0", Offset = "0x20E36B0", VA = "0x1820E4CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x20E4CC0", Offset = "0x20E36C0", VA = "0x1820E4CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public string HKOHCLIPBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public string BHJIFPBGDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public string MIJDMNDLIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public string BFJJIBKKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public Dictionary<FDEIDHKCJEA, string> FDFENLIENFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x16797A0", Offset = "0x16781A0", VA = "0x1816797A0")]
	public ADFKFEBIBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[NMCNMLEECDM]
public class OCMGAKPKJCH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public IReadOnlyList<PIEGLCNCEHC>? LFBMDIHLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OCMGAKPKJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public OCMGAKPKJCH(IReadOnlyList<PIEGLCNCEHC>? LHGAGJBLMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public enum HGOIMOGAAEP
{
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface LGHAMIPCGHL
{
	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	MMDHIIEJGLF? PBKIPIFBBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	List<EEJCFNMDBNE>? HDNJHLLAGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	DateTime? APODPBBHDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	DateTime? KBOMJMNAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	DateTime? JLLAGDDOEED
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	bool HLGFOMCBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	bool NMKKFKNGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	bool FJBIPDCKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface KLCMCCDOMGP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action LBBFABAICPC;

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task APADDFOINFO(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task LJDBBKHGJKM(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGEJLCNODMA([Out] HOFFGEBPBDL OINEAODAACF);
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface HOFFGEBPBDL
{
	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	string ELPFAJHJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	string GEGMNPMLLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	IReadOnlyDictionary<KKJOHCAGGKO, IReadOnlyList<HJJGPGJIOEN>> MOBFNEFCDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	IReadOnlyDictionary<string, string> MFIICPBCNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface HJJGPGJIOEN
{
	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	string BHJIFPBGDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	string HKOHCLIPBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	string MIJDMNDLIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	string BFJJIBKKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public interface JJNPIFNJJFP
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	FAJOKKEMLLC NGLODIAJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	string LBBHENBDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	bool FJBIPDCKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	bool NMKKFKNGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	BJHDLCNOPOE BIPECCNKIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	string AKODFKHHMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	BHCOMPDPHKN? ECMCFPCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	HGOIMOGAAEP IPOGJEPFEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	bool FDNGDDAFNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[NMCNMLEECDM]
public class MMDHIIEJGLF : HJBDJGHOGMK, IEquatable<MMDHIIEJGLF>
{
	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public FAJOKKEMLLC EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(FAJOKKEMLLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public int? MFKDHHMBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x14033C0", Offset = "0x1401DC0", VA = "0x1814033C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x1404710", Offset = "0x1403110", VA = "0x181404710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public Guid? IOGMHGHCIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B10", Offset = "0xAB6510", VA = "0x180AB7B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B90", Offset = "0xAB6590", VA = "0x180AB7B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x795CB10", Offset = "0x795B510", VA = "0x18795CB10")]
	public static MMDHIIEJGLF OPMNBEFJNFB(int CBKJMCCIGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x795CA50", Offset = "0x795B450", VA = "0x18795CA50")]
	public static MMDHIIEJGLF NNPNPBIGJCC(Guid PCPOOIGHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x795C850", Offset = "0x795B250", VA = "0x18795C850")]
	public static MMDHIIEJGLF IFJCJPEHEAC(CKAJELFPLEM BBMDGMLEDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x795C510", Offset = "0x795AF10", VA = "0x18795C510", Slot = "5")]
	public bool Equals(MMDHIIEJGLF? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x795C600", Offset = "0x795B000", VA = "0x18795C600", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x795C7B0", Offset = "0x795B1B0", VA = "0x18795C7B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x15A12B0", Offset = "0x159FCB0", VA = "0x1815A12B0")]
	public static bool NOPNAEDOCOI(MMDHIIEJGLF? IIIICGAEODJ, MMDHIIEJGLF? ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x15A0C80", Offset = "0x159F680", VA = "0x1815A0C80")]
	public static bool DFNINOIAFHB(MMDHIIEJGLF? IIIICGAEODJ, MMDHIIEJGLF? ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MMDHIIEJGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum FAJOKKEMLLC
{
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[NMCNMLEECDM]
public class EEJCFNMDBNE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public LMFNPHDGODM FLJCMKOBDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(LMFNPHDGODM);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public HIJIDGMNGEE GPOBALGPCED
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x7957C90", Offset = "0x7956690", VA = "0x187957C90")]
	public int CFOABCOMEED(DateTime PNMBHMMEFCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EEJCFNMDBNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
[NMCNMLEECDM]
public class HIJIDGMNGEE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public int OJPAJMPGPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public DateTime? DLMOBEOAHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public DateTime? NHHGAPKIHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x15AC720", Offset = "0x15AB120", VA = "0x1815AC720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x795A9E0", Offset = "0x79593E0", VA = "0x18795A9E0")]
	public bool BNAFAFPIGEJ(DateTime PNMBHMMEFCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x795AAD0", Offset = "0x79594D0", VA = "0x18795AAD0")]
	public int CCOOFAIACHM(DateTime PNMBHMMEFCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x795AB00", Offset = "0x7959500", VA = "0x18795AB00")]
	public TimeSpan? KFNBEJHLOID(DateTime PNMBHMMEFCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HIJIDGMNGEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum MNKKBGFEDOF
{
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum NDLFBGODIHD
{
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum MOCNHAMKIHJ
{
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum FNHFNCBBDAF
{
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum CJJHBCJMEFF
{
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[NMCNMLEECDM]
public class GPIPNLICMOP : IEquatable<GPIPNLICMOP>
{
	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public int? NGDHPIDOIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public int? OPKPDCMBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public int? CAIMFJJAEML
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public List<MMDHIIEJGLF>? FNKKIBAAFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x795A280", Offset = "0x7958C80", VA = "0x18795A280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x795A220", Offset = "0x7958C20", VA = "0x18795A220")]
	public static GPIPNLICMOP MGAHFGOFIJL(int? PKJENIJHIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x7959E20", Offset = "0x7958820", VA = "0x187959E20", Slot = "4")]
	public bool Equals(GPIPNLICMOP? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x7959FA0", Offset = "0x79589A0", VA = "0x187959FA0")]
	private static bool GBDLDOCEMLD(List<MMDHIIEJGLF>? EICJFDNFOCB, List<MMDHIIEJGLF>? MIBIEOGGIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x7959BF0", Offset = "0x79585F0", VA = "0x187959BF0", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x795A040", Offset = "0x7958A40", VA = "0x18795A040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GPIPNLICMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public struct CKAJELFPLEM : IEquatable<CKAJELFPLEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public readonly FAJOKKEMLLC NGLODIAJNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly int MFKDHHMBDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly Guid IOGMHGHCIOF;

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public Guid KGGNNFDKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x79565B0", Offset = "0x7954FB0", VA = "0x1879565B0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public int DFAIJJHPPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x7956BC0", Offset = "0x79555C0", VA = "0x187956BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public string KNCEGKAEGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x79568A0", Offset = "0x79552A0", VA = "0x1879568A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x7956170", Offset = "0x7954B70", VA = "0x187956170")]
	public static bool AJEKELLDDGL(string HPKKCNLEGJA, [Out] CKAJELFPLEM BBMDGMLEDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x79568F0", Offset = "0x79552F0", VA = "0x1879568F0")]
	public static bool EELMOJMENGO(string CLJPNHOJHMC, [Out] CKAJELFPLEM BBMDGMLEDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x7956620", Offset = "0x7955020", VA = "0x187956620")]
	public static CKAJELFPLEM CNHFNAIOMFD(int NMAIBBDGPCD)
	{
		return default(CKAJELFPLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x7956750", Offset = "0x7955150", VA = "0x187956750")]
	public static CKAJELFPLEM COGNEEJJLFI(Guid NMAIBBDGPCD)
	{
		return default(CKAJELFPLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x7956DC0", Offset = "0x79557C0", VA = "0x187956DC0")]
	private static bool OONNIGLEPAK(string HPKKCNLEGJA, [Out] FAJOKKEMLLC BMFIGBAJCHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x7956F80", Offset = "0x7955980", VA = "0x187956F80")]
	private CKAJELFPLEM(FAJOKKEMLLC BMFIGBAJCHH, int? NGJEJPHMEIH, Guid? PCPOOIGHMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x7956CC0", Offset = "0x79556C0", VA = "0x187956CC0", Slot = "4")]
	public bool Equals(CKAJELFPLEM GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x7956BD0", Offset = "0x79555D0", VA = "0x187956BD0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x7956D30", Offset = "0x7955730", VA = "0x187956D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x7956ED0", Offset = "0x79558D0", VA = "0x187956ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[NMCNMLEECDM]
public abstract class GCBFFNGFBNN : IEquatable<GCBFFNGFBNN>, HJBDJGHOGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public Guid JNHMLCINHNO;

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x7959670", Offset = "0x7958070", VA = "0x187959670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x79595F0", Offset = "0x7957FF0", VA = "0x1879595F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x79595B0", Offset = "0x7957FB0", VA = "0x1879595B0", Slot = "4")]
	public bool Equals(GCBFFNGFBNN GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x79594A0", Offset = "0x7957EA0", VA = "0x1879594A0", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract GCBFFNGFBNN AFCIIKKNNFA();

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected GCBFFNGFBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum HDGFDNCHPPJ
{
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	RoomOffer,
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[NMCNMLEECDM]
public class PIEGLCNCEHC : GCBFFNGFBNN, IEquatable<PIEGLCNCEHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public HDGFDNCHPPJ BMFIGBAJCHH;

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x795EB30", Offset = "0x795D530", VA = "0x18795EB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x795EAB0", Offset = "0x795D4B0", VA = "0x18795EAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PIEGLCNCEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x795EBD0", Offset = "0x795D5D0", VA = "0x18795EBD0")]
	public PIEGLCNCEHC(HDGFDNCHPPJ BMFIGBAJCHH, Guid JNHMLCINHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x795E9F0", Offset = "0x795D3F0", VA = "0x18795E9F0")]
	public static PIEGLCNCEHC COGNEEJJLFI(Guid NKDDKILHAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x795EA60", Offset = "0x795D460", VA = "0x18795EA60", Slot = "7")]
	public bool Equals(PIEGLCNCEHC GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x795E980", Offset = "0x795D380", VA = "0x18795E980", Slot = "6")]
	public override GCBFFNGFBNN AFCIIKKNNFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public static class PKAKPODANNL
{
	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x795F070", Offset = "0x795DA70", VA = "0x18795F070")]
	public static PIEGLCNCEHC ENMICGMLGAF(this MFPNIMPMBFE EOJOFJJBHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x795F150", Offset = "0x795DB50", VA = "0x18795F150")]
	public static PIEGLCNCEHC KNDMBFMMLME(string OFANCEEHEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x795F0E0", Offset = "0x795DAE0", VA = "0x18795F0E0")]
	public static PIEGLCNCEHC FNAOMLNFPEF(Guid KOOEBEJNFKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[NMCNMLEECDM]
public class MFPNIMPMBFE : NMMCIAJOPCH, HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public HDGFDNCHPPJ NGLODIAJNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(HDGFDNCHPPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public Guid MONGEDMGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A70", Offset = "0x1C20470", VA = "0x181C21A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC700", Offset = "0x5EFB100", VA = "0x185EFC700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public long? JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C680", VA = "0x18109DC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x109DC70", Offset = "0x109C670", VA = "0x18109DC70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public long JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0xFEB730", Offset = "0xFEA130", VA = "0x180FEB730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public Guid? DEONPKKEDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x7955C40", Offset = "0x7954640", VA = "0x187955C40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x7955BA0", Offset = "0x79545A0", VA = "0x187955BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x1001750", Offset = "0x1000150", VA = "0x181001750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public DateTime IGNEBMAKGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x1001D40", Offset = "0x1000740", VA = "0x181001D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MFPNIMPMBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x795C360", Offset = "0x795AD60", VA = "0x18795C360")]
	public MFPNIMPMBFE(HDGFDNCHPPJ BMFIGBAJCHH, Guid JNHMLCINHNO, [Optional] string IELIBBNCJAC, [Optional] string GDFPOPIGPDJ, [Optional] string CGPNBEBFGEL, [Optional] long? GDCAPMONNDM, long MANOLGLEOMD = 0L, [Optional] Guid? EDJFHIDOPBH, [Optional] DateTime HJMDCHHCMEE, [Optional] DateTime CHEOOPMFAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x795C2B0", Offset = "0x795ACB0", VA = "0x18795C2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public interface DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000308")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public interface ICPJPJDOFCC<out TId> : DNBCNEDFPIJ where TId : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000309")]
	TId BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[NMCNMLEECDM]
public class PILAELGHMIO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public List<FLIELDFLDKD> GMINBLIGFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public List<EKAFHIMLCKB> MAPDCIHONCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public List<EKPMFKPNLMH> GBCINEGDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public List<KCNEBMDADKI> LNBKIEMONEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public List<BJMBPHGDEPH> CONLEELDPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public List<GNHJAGFKEFD> GLHDIFLBKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public List<HDKEKBOFLIB> BJOCINNKAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public List<FMGKEAPDOLH> POHHHEMJGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public PBAEIHCFMAI POEEGFNJCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public PBAEIHCFMAI DDBNAPNOEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public PBAEIHCFMAI IBGMFEOECBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x795EC10", Offset = "0x795D610", VA = "0x18795EC10", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x795EDC0", Offset = "0x795D7C0", VA = "0x18795EDC0")]
	public PILAELGHMIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[NMCNMLEECDM]
public class FLIELDFLDKD : HJBDJGHOGMK, IEquatable<FLIELDFLDKD>
{
	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public JAAFCJGPCNL IMHJFCBCLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(JAAFCJGPCNL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public FMOJBGAEPIN PPFKLMPPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA70", Offset = "0xB8A470", VA = "0x180B8BA70")]
		[CompilerGenerated]
		get
		{
			return default(FMOJBGAEPIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA50", Offset = "0xB8A450", VA = "0x180B8BA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public Guid NAPOCAJLOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A70", Offset = "0x1C20470", VA = "0x181C21A70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC700", Offset = "0x5EFB100", VA = "0x185EFC700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public Guid NAGILBLACMB
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xECFB90", Offset = "0xECE590", VA = "0x180ECFB90")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x10D0D90", Offset = "0x10CF790", VA = "0x1810D0D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x7959190", Offset = "0x7957B90", VA = "0x187959190", Slot = "5")]
	public bool Equals(FLIELDFLDKD GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x7959030", Offset = "0x7957A30", VA = "0x187959030", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x7959230", Offset = "0x7957C30", VA = "0x187959230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x15A12B0", Offset = "0x159FCB0", VA = "0x1815A12B0")]
	public static bool NOPNAEDOCOI(FLIELDFLDKD IIIICGAEODJ, FLIELDFLDKD ELBIKJBAIEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x15A0C80", Offset = "0x159F680", VA = "0x1815A0C80")]
	public static bool DFNINOIAFHB(FLIELDFLDKD IIIICGAEODJ, FLIELDFLDKD ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FLIELDFLDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[NMCNMLEECDM]
public class PBAEIHCFMAI : HJBDJGHOGMK, ICPJPJDOFCC<FMOJBGAEPIN>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public FMOJBGAEPIN BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FMOJBGAEPIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public EOKCLINBNFB GAFLGNLHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public float GHAPBIENMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x10DF360", Offset = "0x10DDD60", VA = "0x1810DF360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x15FEFB0", Offset = "0x15FD9B0", VA = "0x1815FEFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public float CNJALDEGIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xDDC030", Offset = "0xDDAA30", VA = "0x180DDC030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xDDC040", Offset = "0xDDAA40", VA = "0x180DDC040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public float OPIBOBOJPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xD89940", Offset = "0xD88340", VA = "0x180D89940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x10C43F0", Offset = "0x10C2DF0", VA = "0x1810C43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x795E500", Offset = "0x795CF00", VA = "0x18795E500", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x795E550", Offset = "0x795CF50", VA = "0x18795E550")]
	public PBAEIHCFMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[NMCNMLEECDM]
public class EKAFHIMLCKB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public FLIELDFLDKD PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public string IHEFDOHGAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public POGIIFLCOLE GEECAEBFGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x7957E70", Offset = "0x7956870", VA = "0x187957E70")]
	public EKAFHIMLCKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[NMCNMLEECDM]
public class EKPMFKPNLMH : HJBDJGHOGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public string CIAJOPDBKCH;

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public FMOJBGAEPIN PPFKLMPPCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
		[CompilerGenerated]
		get
		{
			return default(FMOJBGAEPIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EKPMFKPNLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[NMCNMLEECDM]
public class ECOMIEDEBHD : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public float JPIKKBKOFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x10DF360", Offset = "0x10DDD60", VA = "0x1810DF360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x15FEFB0", Offset = "0x15FD9B0", VA = "0x1815FEFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public float EHJENOCEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xDDC030", Offset = "0xDDAA30", VA = "0x180DDC030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xDDC040", Offset = "0xDDAA40", VA = "0x180DDC040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public float AMBMFAKEJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xD89940", Offset = "0xD88340", VA = "0x180D89940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x10C43F0", Offset = "0x10C2DF0", VA = "0x1810C43F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public float EABAPCBKGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xADDD10", Offset = "0xADC710", VA = "0x180ADDD10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xADDAE0", Offset = "0xADC4E0", VA = "0x180ADDAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ECOMIEDEBHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[NMCNMLEECDM]
public class KCNEBMDADKI : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x795BA70", Offset = "0x795A470", VA = "0x18795BA70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public int PMIFPNHFKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string CIAJOPDBKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public POGIIFLCOLE JCMKCPCHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x7955F40", Offset = "0x7954940", VA = "0x187955F40", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x795BAE0", Offset = "0x795A4E0", VA = "0x18795BAE0")]
	public KCNEBMDADKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[NMCNMLEECDM]
public class BJMBPHGDEPH : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public float IFDHFAOEHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x10DF360", Offset = "0x10DDD60", VA = "0x1810DF360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x15FEFB0", Offset = "0x15FD9B0", VA = "0x1815FEFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public ABLKNBHLNAF EOMEIGNKFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x18AB960", Offset = "0x18AA360", VA = "0x1818AB960")]
		[CompilerGenerated]
		get
		{
			return default(ABLKNBHLNAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x10C54D0", Offset = "0x10C3ED0", VA = "0x1810C54D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public List<FEPFBEDDBDE> KECMMALMEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x7955300", Offset = "0x7953D00", VA = "0x187955300", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x79553A0", Offset = "0x7953DA0", VA = "0x1879553A0")]
	public BJMBPHGDEPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[NMCNMLEECDM]
public class GNHJAGFKEFD : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public EOKCLINBNFB GAFLGNLHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x79592E0", Offset = "0x7957CE0", VA = "0x1879592E0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x7959B70", Offset = "0x7958570", VA = "0x187959B70")]
	public GNHJAGFKEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[NMCNMLEECDM]
public class EOKCLINBNFB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public List<FBILCMEKOHI> IKKDNELBAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x7958050", Offset = "0x7956A50", VA = "0x187958050", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x7958090", Offset = "0x7956A90", VA = "0x187958090")]
	public EOKCLINBNFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[NMCNMLEECDM]
public class FBILCMEKOHI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public float IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public float AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E80", Offset = "0xEC6880", VA = "0x180EC7E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E70", Offset = "0xEC6870", VA = "0x180EC7E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public float BCJBHAEKPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x1405390", Offset = "0x1403D90", VA = "0x181405390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public float BPFNAHBDIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public float HNPHMJOEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB044A0", VA = "0x180B05AA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x10D55B0", Offset = "0x10D3FB0", VA = "0x1810D55B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public float DLPOPKDNBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xB0D530", Offset = "0xB0BF30", VA = "0x180B0D530")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xB0DB20", Offset = "0xB0C520", VA = "0x180B0DB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public int IBDCDDEODFI
	{
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public int OPLAAIFJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x16E8640", Offset = "0x16E7040", VA = "0x1816E8640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FBILCMEKOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[NMCNMLEECDM]
public class FEPFBEDDBDE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public float IBJIMPNBLHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public POGIIFLCOLE JCMKCPCHLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x79581A0", Offset = "0x7956BA0", VA = "0x1879581A0")]
	public FEPFBEDDBDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[NMCNMLEECDM]
public class POGIIFLCOLE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public float COLAKAJDJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public float PPJIFDIFELE
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E80", Offset = "0xEC6880", VA = "0x180EC7E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E70", Offset = "0xEC6870", VA = "0x180EC7E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public float BGONGBMJPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x1405390", Offset = "0x1403D90", VA = "0x181405390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public float JIGNGCLDIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public POGIIFLCOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x795B290", Offset = "0x7959C90", VA = "0x18795B290")]
	public POGIIFLCOLE(float OLMEHKPIJHD, float AMANNJNDJGG, float MIBIEOGGIAP, float EICJFDNFOCB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[NMCNMLEECDM]
public class FMGKEAPDOLH : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public EOKCLINBNFB HBGNADILGFG
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x79592E0", Offset = "0x7957CE0", VA = "0x1879592E0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x7959330", Offset = "0x7957D30", VA = "0x187959330")]
	public FMGKEAPDOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[NMCNMLEECDM]
public class HDKEKBOFLIB : HJBDJGHOGMK, ICPJPJDOFCC<Guid>, DNBCNEDFPIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public Guid BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public string KFHEKBBHICD
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public string EHAEOFFJIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public bool JMOOJLKLMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xB04860", Offset = "0xB03260", VA = "0x180B04860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public float LEAJKPBNJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xAFF3A0", Offset = "0xAFDDA0", VA = "0x180AFF3A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xD845D0", Offset = "0xD82FD0", VA = "0x180D845D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public GEFGOLMDCEN DBHOBNPKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public GEFGOLMDCEN FEJDLLPHKKC
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public GEFGOLMDCEN ACGILBOACGF
	{
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public GEFGOLMDCEN CMPDHACHNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public IIAOLDOENND GLFLCKHKECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x795A3F0", Offset = "0x7958DF0", VA = "0x18795A3F0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x795A4B0", Offset = "0x7958EB0", VA = "0x18795A4B0")]
	public HDKEKBOFLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[NMCNMLEECDM]
public class GEFGOLMDCEN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public GLLOANLEJIN NAAMJPDCCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public float ABNJMOFLFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x1405390", Offset = "0x1403D90", VA = "0x181405390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public float NEDGBCCDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public IIAOLDOENND LDCOCLEJOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x79596E0", Offset = "0x79580E0", VA = "0x1879596E0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x7959700", Offset = "0x7958100", VA = "0x187959700")]
	public GEFGOLMDCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[NMCNMLEECDM]
public class GLLOANLEJIN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public float NMHBMBGEJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public float DJJOMGDFFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E80", Offset = "0xEC6880", VA = "0x180EC7E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E70", Offset = "0xEC6870", VA = "0x180EC7E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GLLOANLEJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x7936260", Offset = "0x7934C60", VA = "0x187936260")]
	public GLLOANLEJIN(float FKPKEFAKAOE, float KEEMKILMOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public virtual void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
[NMCNMLEECDM]
public class IIAOLDOENND : GLLOANLEJIN
{
	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public float JMKJEJELKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x1405390", Offset = "0x1403D90", VA = "0x181405390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public float COFKONJEGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xEE12E0", Offset = "0xEDFCE0", VA = "0x180EE12E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IIAOLDOENND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x795B290", Offset = "0x7959C90", VA = "0x18795B290")]
	public IIAOLDOENND(float FKPKEFAKAOE, float KEEMKILMOML, float JLNCPHFMCKO, float LIPBKGAOLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public override void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal static class KJIJFPJAIJM
{
	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x3E59F20", Offset = "0x3E58920", VA = "0x183E59F20")]
	public static void BICECJEOMEB<T>(IList<T>? ONIJFDHAPBM) where T : HJBDJGHOGMK
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum JAAFCJGPCNL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	Emission,
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	PlayerHeadScale,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	Aura,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	Texture,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	PlayerAvatarScale
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public enum FMOJBGAEPIN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	PlayerVoiceInput,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	PlayerVelocity,
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	AnimationCurve,
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	HighFiveCount,
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	AlwaysOn
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public enum ABLKNBHLNAF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	Time,
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	ValueRamp
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public static class EBCMOHGHBPB
{
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public static readonly JAAFCJGPCNL[] PGKDCALJAPB;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public static readonly JAAFCJGPCNL[] ANGBIHHGBKB;

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public static readonly FMOJBGAEPIN[] DABEIDJCINI;

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public static readonly FMOJBGAEPIN[] NHANAHEDHDA;

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x79578A0", Offset = "0x79562A0", VA = "0x1879578A0")]
	public static bool LHAJMOGEDFC(this JAAFCJGPCNL EPFEECIDFAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum GNPFLHLJALH
{
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	General,
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public enum OOAHBJKLADP
{
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[NMCNMLEECDM]
public class IPAPHMAKOAB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public OOAHBJKLADP ECLPEGKCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(OOAHBJKLADP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public List<string> PPHPOIIEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x795B330", Offset = "0x7959D30", VA = "0x18795B330")]
	public string OEFBAEEIKMM(int MEIGCONBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IPAPHMAKOAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[NMCNMLEECDM]
public class FPMGEPJAEGN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public string BFCLHODIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public GNPFLHLJALH EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(GNPFLHLJALH);
		}
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FPMGEPJAEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public static class PDALHMGODIF
{
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	public const string NEDIBDGJPHJ = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000593")]
	public const string JEHCDGODAAH = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000594")]
	public const string DCFLKJOLBHH = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000595")]
	public const string AFEHALPGEKE = "large";

	[Cpp2IlInjected.Token(Token = "0x4000596")]
	public const string GENKAMBFLBC = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000597")]
	public const string NDBJDBLEKJJ = "small";

	[Cpp2IlInjected.Token(Token = "0x4000598")]
	public const string JKGBIACLAKK = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000599")]
	public const string CFGBCLFHJJD = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400059A")]
	public const string LNFEIKDNOIG = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400059B")]
	public const string OMCPENEHKLE = "r2";

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public static List<string> LPIEJINKJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x795E630", Offset = "0x795D030", VA = "0x18795E630")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public static class NMMOIMHAKJA
{
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	public const string MJFMBIIFDNB = "beta";

	[Cpp2IlInjected.Token(Token = "0x400059D")]
	public const string GLNPGFDDAPI = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[NMCNMLEECDM]
public class DJFGJCINPGM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public List<string> HHFJOANADCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public List<string> JDLLEDMEBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	public List<string> PMGENINBALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DJFGJCINPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public class FKGCDFACIGM : IEquatable<FKGCDFACIGM>
{
	[Cpp2IlInjected.Token(Token = "0x17000363")]
	protected virtual Type HCMMHEKOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x7958BC0", Offset = "0x79575C0", VA = "0x187958BC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	public HHHMIEFPOCL? BDBHKDAOGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	public HttpMethod? GNKMNIMIPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public string? PFOAMBBMKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x7958E60", Offset = "0x7957860", VA = "0x187958E60")]
	public FKGCDFACIGM(HHHMIEFPOCL? BDBHKDAOGEB, HttpMethod? GNKMNIMIPDD, string? PFOAMBBMKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x7958CF0", Offset = "0x79576F0", VA = "0x187958CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x79586D0", Offset = "0x79570D0", VA = "0x1879586D0", Slot = "6")]
	protected virtual bool ECBFINKPGDH(StringBuilder EAHPNFLHNJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x12D0300", Offset = "0x12CED00", VA = "0x1812D0300")]
	public static bool DFNINOIAFHB(FKGCDFACIGM? FKHOLJEDBPC, FKGCDFACIGM? EEAEODONEDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x12D07B0", Offset = "0x12CF1B0", VA = "0x1812D07B0")]
	public static bool NOPNAEDOCOI(FKGCDFACIGM? FKHOLJEDBPC, FKGCDFACIGM? EEAEODONEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x7958A50", Offset = "0x7957450", VA = "0x187958A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x7958830", Offset = "0x7957230", VA = "0x187958830", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x79588C0", Offset = "0x79572C0", VA = "0x1879588C0", Slot = "7")]
	public virtual bool Equals(FKGCDFACIGM? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x7958C20", Offset = "0x7957620", VA = "0x187958C20", Slot = "8")]
	public virtual FKGCDFACIGM OAGDMDEKLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x7958E00", Offset = "0x7957800", VA = "0x187958E00")]
	protected FKGCDFACIGM(FKGCDFACIGM KDKPJJBFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x7958CB0", Offset = "0x79576B0", VA = "0x187958CB0")]
	public void ODNAGOAKDMJ([Out] HHHMIEFPOCL? BDBHKDAOGEB, [Out] HttpMethod? GNKMNIMIPDD, [Out] string? PFOAMBBMKGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public class ANHHLPDCMOM : IEquatable<ANHHLPDCMOM>
{
	[Cpp2IlInjected.Token(Token = "0x17000367")]
	protected virtual Type HCMMHEKOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x7954240", Offset = "0x7952C40", VA = "0x187954240", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public int LGDGEGFGMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public EMOHBIBDBFK PFABIBLMOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(EMOHBIBDBFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x7954430", Offset = "0x7952E30", VA = "0x187954430")]
	public ANHHLPDCMOM(int LGDGEGFGMFC, EMOHBIBDBFK PFABIBLMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x7954320", Offset = "0x7952D20", VA = "0x187954320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x7953E30", Offset = "0x7952830", VA = "0x187953E30", Slot = "6")]
	protected virtual bool ECBFINKPGDH(StringBuilder EAHPNFLHNJH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x12D0300", Offset = "0x12CED00", VA = "0x1812D0300")]
	public static bool DFNINOIAFHB(ANHHLPDCMOM? FKHOLJEDBPC, ANHHLPDCMOM? EEAEODONEDA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x12D07B0", Offset = "0x12CF1B0", VA = "0x1812D07B0")]
	public static bool NOPNAEDOCOI(ANHHLPDCMOM? FKHOLJEDBPC, ANHHLPDCMOM? EEAEODONEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x7954130", Offset = "0x7952B30", VA = "0x187954130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x7953F60", Offset = "0x7952960", VA = "0x187953F60", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x7953FF0", Offset = "0x79529F0", VA = "0x187953FF0", Slot = "7")]
	public virtual bool Equals(ANHHLPDCMOM? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x79542A0", Offset = "0x7952CA0", VA = "0x1879542A0", Slot = "8")]
	public virtual ANHHLPDCMOM OAGDMDEKLJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0xD18290", Offset = "0xD16C90", VA = "0x180D18290")]
	protected ANHHLPDCMOM(ANHHLPDCMOM KDKPJJBFLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x7954310", Offset = "0x7952D10", VA = "0x187954310")]
	public void ODNAGOAKDMJ([Out] int LGDGEGFGMFC, [Out] EMOHBIBDBFK PFABIBLMOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public enum EMOHBIBDBFK
{
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public interface AMDJHBOIJNB
{
	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<FKGCDFACIGM, ANHHLPDCMOM> LGLPOPDCGPL();

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEPLBBFGEKH(FKGCDFACIGM HPFHOBCPNEF, ANHHLPDCMOM FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x600085E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBFGPHCFCEJ(FKGCDFACIGM HPFHOBCPNEF);

	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OBLJGKLLCPB();

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LBMAAMCEJLD(HHHMIEFPOCL DGDHAMECAIH, HttpMethod PECFHCNLPEO, string CPNBOGANGLJ, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[CHANNPPKAHC]
public class GMECIJHCICI<TResult> where TResult : HJBDJGHOGMK, new()
{
	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public IReadOnlyList<TResult> GKJFONJHDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public long CNCALALILIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GMECIJHCICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public enum BIJGPGHBOCM
{
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
public interface HCOGJNBDPNI : FDHMEMKKDPL
{
	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	bool NABBMNAEJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long MBEAOLFIINO, GGCLDHPLEAO HJEBLBOJOPK);

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FMJMJKOAMFI> PurchaseAsync(GGCLDHPLEAO HJEBLBOJOPK, GPIPNLICMOP KOJKAGPHBEH);

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(NKOPOCFNKME ONNAEAEMOBN, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
public interface FDHMEMKKDPL
{
	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	bool NOONFECBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
public interface KPNHBLOPCCA
{
	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	int BCNAGDKINCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GGCLDHPLEAO>> ADGCDNFHEPJ(bool KEDBDJKEGJP = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMDBJOFBDMM([Out] GGCLDHPLEAO? KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GGCLDHPLEAO> HNMOOLONGIN(bool KEDBDJKEGJP = false, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPMNJKHPODE(string LJPPNNLHGCJ = "");
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
public interface ACPBHJBIODI
{
	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EDBDHOGEBMJ(NKOPOCFNKME ONNAEAEMOBN, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FJHFJDLPLFL(NKOPOCFNKME ONNAEAEMOBN, CancellationToken AHOMALKMHKK, [Optional] BINAHLCNALG? DGFECCOHCNM);
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public interface BINAHLCNALG
{
	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIAKCLIMEJF(string AKEJFNGKBEL);
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public interface MAANGMJNBAB
{
	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EBJFNBPMDOJ(NKOPOCFNKME ENKMPHFIKKD, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public interface CGBBEHOLKHG
{
	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	bool MEPHPNPCNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public interface FDBGELAEBMI
{
	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKOPOCFNKME JMAJAMACNIA(GGCLDHPLEAO HJEBLBOJOPK, GPIPNLICMOP KOJKAGPHBEH, string EEFMPKKEEJO, [Optional] ACPBHJBIODI? GLNHGAHHKIG);
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public interface DFINBOFBLJI
{
	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCDCOLLLEKE(MAANGMJNBAB OIAJENBJKKC);

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHIFAJCIOIC(MAANGMJNBAB OIAJENBJKKC);

	[Cpp2IlInjected.Token(Token = "0x6000879")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JAICAHBLDPK(NKOPOCFNKME ONNAEAEMOBN, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public interface NKOPOCFNKME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000370")]
	CHLCKPFDNPB FOHJCCDHLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	GGCLDHPLEAO PLJFNENBGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	GPIPNLICMOP PAKAFBKFBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	string DKHKGGHBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	string KDKCJPMOHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GMPEDELLLJK> OHGCMGJEAGG(CancellationToken ICODIHINNBH, [Optional] BINAHLCNALG? DGFECCOHCNM);

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ENCLBDGMBKJ(string EDCCMILPHPE);

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ENCLBDGMBKJ<T>(Func<T, string> EDCCMILPHPE, [In] T KGAIMCKFBBD);
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public abstract class DINLDGKFGDG
{
	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected DINLDGKFGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum IDLNAHFOIFD
{
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public enum JAIDKOONMIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[NMCNMLEECDM]
public class GGCLDHPLEAO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public int BCICHPDGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public int JOMAPKDMNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public string DKJLFJGHHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public string NPHDMKABHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	[DataMember(Name = "PsnProductLabel")]
	public string DKNNINACFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public string PCGJGBGCIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public string GMKMANGNOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public string GMIHIEEFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public string LJENONGONEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public string HJMPOOBLCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public bool EOHCOFIOHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xDD49D0", Offset = "0xDD33D0", VA = "0x180DD49D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xDD3F80", Offset = "0xDD2980", VA = "0x180DD3F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public bool EJGGPJLJBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x18DC6D0", Offset = "0x18DB0D0", VA = "0x1818DC6D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x18DC8B0", Offset = "0x18DB2B0", VA = "0x1818DC8B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public JBFIFLIEDKB AMLFHELBNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	[IgnoreDataMember]
	public string GGLOJELMOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	[IgnoreDataMember]
	public string FPCABGCJJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	[IgnoreDataMember]
	public string FCNPHLHLOEM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	[IgnoreDataMember]
	public DINLDGKFGDG OFJFLCMMDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	[IgnoreDataMember]
	public bool BNENJFAGDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x7959780", Offset = "0x7958180", VA = "0x187959780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	[IgnoreDataMember]
	public string CKPIOBEGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x7959840", Offset = "0x7958240", VA = "0x187959840", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AF")]
	[Cpp2IlInjected.Address(RVA = "0x79597A0", Offset = "0x79581A0", VA = "0x1879597A0")]
	public static GGCLDHPLEAO IHGMDJBDIHE(int NMAIBBDGPCD, string IELIBBNCJAC, string CGPNBEBFGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B0")]
	[Cpp2IlInjected.Address(RVA = "0x7959930", Offset = "0x7958330", VA = "0x187959930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GGCLDHPLEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[NMCNMLEECDM]
public class JBFIFLIEDKB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public List<int> DONCLILIAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public string LBGIPDADNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public CKOGGJOMPBM FOLAIGDJHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x10A80D0", Offset = "0x10A6AD0", VA = "0x1810A80D0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JBFIFLIEDKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public readonly struct GMPEDELLLJK
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	public enum LKEMIJMOMFC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	public readonly LKEMIJMOMFC HMKHMFFLILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	public readonly JAIDKOONMIG GHCLCLIOIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public readonly IDLNAHFOIFD ENBBFAIELJI;

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x7959B60", Offset = "0x7958560", VA = "0x187959B60")]
	private GMPEDELLLJK(LKEMIJMOMFC IMNBLKDCAKA, JAIDKOONMIG LAJBAIBKPIH = JAIDKOONMIG.Unknown, IDLNAHFOIFD PAILMGNPFEN = IDLNAHFOIFD.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x7959B00", Offset = "0x7958500", VA = "0x187959B00")]
	public static GMPEDELLLJK ANDPHKADADF()
	{
		return default(GMPEDELLLJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x7959B40", Offset = "0x7958540", VA = "0x187959B40")]
	public static GMPEDELLLJK LOIAEKDHOBA()
	{
		return default(GMPEDELLLJK);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x7959B20", Offset = "0x7958520", VA = "0x187959B20")]
	public static GMPEDELLLJK GOEGMEJBNMI(JAIDKOONMIG LAJBAIBKPIH, IDLNAHFOIFD PAILMGNPFEN)
	{
		return default(GMPEDELLLJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public enum ABGDENONHIK
{
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public enum HEHGEENCIGA
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[NMCNMLEECDM]
public class CKOGGJOMPBM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public ABGDENONHIK LBKEOPBGBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(ABGDENONHIK);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public HEHGEENCIGA CLCOOHPGJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(HEHGEENCIGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public bool ACMJNOBFMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CKOGGJOMPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public enum CHLCKPFDNPB
{
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[NMCNMLEECDM]
public class LFLKCJBNAHK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public long OBANOHMGLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public long AHCDPJINJNE
	{
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public bool FAFGLCLMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LFLKCJBNAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[NMCNMLEECDM]
public class AOLFKCJJEIP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public OFMIDCCPHGM? FAHCPCNHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public IReadOnlyList<OFMIDCCPHGM>? FIJHFIHNJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public IReadOnlyList<string>? HGIAGKNMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public ANFAKHIIDHK CBOIHOPEAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public string? KJLIBJNMEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public string? LBJHJJBMGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public string? FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AOLFKCJJEIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[NMCNMLEECDM]
public class PBNDGDDGCIP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string CGKLPFAGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public OFMIDCCPHGM? FAHCPCNHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public ANFAKHIIDHK CBOIHOPEAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public string? LBJHJJBMGIK
	{
		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public IReadOnlyList<string>? HGIAGKNMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PBNDGDDGCIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[NMCNMLEECDM]
public class ANFAKHIIDHK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public string LPBLBHLJOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public bool NNCGBAPHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public bool KLFOBBHCJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x1258F70", Offset = "0x1257970", VA = "0x181258F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x13C47A0", Offset = "0x13C31A0", VA = "0x1813C47A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public bool HOFLPKCEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x1258F60", Offset = "0x1257960", VA = "0x181258F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x1738100", Offset = "0x1736B00", VA = "0x181738100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public bool GBNKAIIGLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x1258F50", Offset = "0x1257950", VA = "0x181258F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x668B850", Offset = "0x668A250", VA = "0x18668B850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public bool NAKMIAJKLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xB7AFD0", Offset = "0xB799D0", VA = "0x180B7AFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F80", Offset = "0xEC6980", VA = "0x180EC7F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public bool FHLDDFMJOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79A30", VA = "0x180B7B030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F90", Offset = "0xEC6990", VA = "0x180EC7F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public bool AAFAHFKCIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B8F440", Offset = "0x1B8DE40", VA = "0x181B8F440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x7953D70", Offset = "0x7952770", VA = "0x187953D70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public bool PDOOMJKCBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x1B85600", Offset = "0x1B84000", VA = "0x181B85600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x7953D60", Offset = "0x7952760", VA = "0x187953D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public bool IFAEKFMMINK
	{
		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public bool CMEGNLJECPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x15F1A40", Offset = "0x15F0440", VA = "0x1815F1A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x15F1730", Offset = "0x15F0130", VA = "0x1815F1730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public bool GEJBAGOJINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x16E8B40", Offset = "0x16E7540", VA = "0x1816E8B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x16E8650", Offset = "0x16E7050", VA = "0x1816E8650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x7953D80", Offset = "0x7952780", VA = "0x187953D80")]
	public ANFAKHIIDHK(string FKGNAIJCJOP, bool MEDKCAAEBCB, bool OPOMAHIOMIL, bool ADBJGAHMMEC, bool LCGJOHIBGMN, bool JBKLKCLOGFG, bool IOCIHLEMAPC, bool PKBMBAHAPAH, bool FDMIDOLOPGK, bool KEODCMLCFMG, bool AJGDLLJGIAE, bool IBPDPNDBHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[NMCNMLEECDM]
public class IAIDKGELMJB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public string LNBIEOIALEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public string FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public string KJLIBJNMEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public string? CHFALKFDCBE
	{
		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public string? BKDNFCCFHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public float OCIBKFGOKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xAFF3B0", Offset = "0xAFDDB0", VA = "0x180AFF3B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1490590", Offset = "0x148EF90", VA = "0x181490590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000912")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000913")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IAIDKGELMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[NMCNMLEECDM]
public class KKCNDKPOCGA : NDEBENMBGIO, HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public string CBEHNNBCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public string ELMFOJFBBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KKCNDKPOCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[NMCNMLEECDM]
public class HGGAABMGBHN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public Guid NGMKNKNKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xED1500", Offset = "0xECFF00", VA = "0x180ED1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public long FNMDIMLGPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A50", Offset = "0xAB4450", VA = "0x180AB5A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public decimal DALJDEPHLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000922")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000923")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HGGAABMGBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[NMCNMLEECDM]
public class JDDJLOFEJMH : HGGAABMGBHN
{
	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public byte DIFCHBHGHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xDB85B0", Offset = "0xDB6FB0", VA = "0x180DB85B0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xEA4E70", Offset = "0xEA3870", VA = "0x180EA4E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JDDJLOFEJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[NMCNMLEECDM]
public class HMIHMIHNBLH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public string CBEHNNBCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public string FLGKFPDAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600092B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HMIHMIHNBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092C")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public HMIHMIHNBLH(string MEDJNHBKECM, string JIEMNLBLGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600092D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[NMCNMLEECDM]
public class HNNEBEIMBKL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public string FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public bool MEJFEJJHHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000934")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000935")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HNNEBEIMBKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
[NMCNMLEECDM]
public class POMNPKEOPAI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public string EDBPDGHPKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public decimal GAABAFJNOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public POMNPKEOPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[NMCNMLEECDM]
public class BFBKCMECGAK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public string? FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public float? OCIBKFGOKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public string? PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BFBKCMECGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[NMCNMLEECDM]
public class KAMJNOEJBBA : CMIFHHGCAPB
{
	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KAMJNOEJBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[NMCNMLEECDM]
public class BKENNGDHFAG : KJMIOABDBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BKENNGDHFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[NMCNMLEECDM]
public class BKBMMEDDNOL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public bool KEFCLOEMNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BKBMMEDDNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[NMCNMLEECDM]
public class APMCCIBDKDG : BKBMMEDDNOL
{
	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public APMCCIBDKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[NMCNMLEECDM]
public class CFFHIGCOICE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public long IGIJOHKGOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public string KMGIKAEEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public EHFHIEFEOPC BPGMAIDHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(EHFHIEFEOPC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public Guid? CFMLHNHKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x7956030", Offset = "0x7954A30", VA = "0x187956030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x7956050", Offset = "0x7954A50", VA = "0x187956050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public string? PNGGONEBNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CFFHIGCOICE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
public enum EHFHIEFEOPC
{
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	Requested = 0,
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	ProviderMeshRequested = 1,
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	ProviderMeshGenerated = 2,
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	ProviderMeshGenFailed = 3,
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	CloudBuildRequested = 11,
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	CloudBuildCompleted = 12,
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	CloudBuildFailed = 13,
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	MeshGenCompleted = 21,
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	ImageReferenceRequested = 31,
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	ImageReferenceGenerated = 32,
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	ImageReferenceGenerationFailed = 33
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[NMCNMLEECDM]
public class JMGGEDKFBOM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public string? FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x795B9A0", Offset = "0x795A3A0", VA = "0x18795B9A0")]
	public JMGGEDKFBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[NMCNMLEECDM]
public class KJMIOABDBBD : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public string FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public string KGLMJOHELPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KJMIOABDBBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[NMCNMLEECDM]
public class CMIFHHGCAPB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public List<string> KHOJINEKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public decimal DKCFKCBPJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CMIFHHGCAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[NMCNMLEECDM]
public class KILEJGLBODP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public int BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public string EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public string? DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public IReadOnlyList<int> POAKFCBHMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public string? AAMNCMPBPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x795BBB0", Offset = "0x795A5B0", VA = "0x18795BBB0")]
	public KILEJGLBODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[NMCNMLEECDM]
public class CMFLKDMELAP : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public int BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600097E")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public Guid? IOGMHGHCIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x25543D0", Offset = "0x2552DD0", VA = "0x1825543D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x25543B0", Offset = "0x2552DB0", VA = "0x1825543B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public string EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public List<KILEJGLBODP> AFJODCOHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public List<KILEJGLBODP> DNCGHGJCLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public string? DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public string? AAMNCMPBPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public string? BGIOPJAOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x79571E0", Offset = "0x7955BE0", VA = "0x1879571E0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x7957210", Offset = "0x7955C10", VA = "0x187957210")]
	public CMFLKDMELAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[NMCNMLEECDM]
public class CLEIDCFADIM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public CMFLKDMELAP AFJODCOHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public CMFLKDMELAP DNCGHGJCLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public string? BGIOPJAOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x7957180", Offset = "0x7955B80", VA = "0x187957180", Slot = "5")]
	public virtual void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CLEIDCFADIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[NMCNMLEECDM]
public class CAJNCHBEBDL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public IReadOnlyList<CMFLKDMELAP> GLMKHBJBPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public IReadOnlyList<CLEIDCFADIM> NKHBOFGAKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public IReadOnlyList<CAJNCHBEBDL> BKFOENLNAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public string? BGIOPJAOFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x7955680", Offset = "0x7954080", VA = "0x187955680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x79556B0", Offset = "0x79540B0", VA = "0x1879556B0")]
	public CAJNCHBEBDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[NMCNMLEECDM]
public class EEACIOJJPNA : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	public const string GFHHFIGGMMK = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public int AMBKKDBDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EEACIOJJPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[NMCNMLEECDM]
public class OFMIDCCPHGM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public int? PHLFNBHNCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public string? BOCGMDANCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public string EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public List<OFMIDCCPHGM>? CFJCMLOIJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public EEACIOJJPNA? AFJEFKBFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x795E210", Offset = "0x795CC10", VA = "0x18795E210", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OFMIDCCPHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[NMCNMLEECDM]
public class GIPKMAIDJHD : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public string IBAMKDEKNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public string PJHNJGFIFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GIPKMAIDJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[NMCNMLEECDM]
public class ANCNCFOHEDG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public CAJNCHBEBDL DFBJIACJNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public OFMIDCCPHGM? FAHCPCNHMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public List<OFMIDCCPHGM>? FIJHFIHNJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F8")]
	public IReadOnlyList<CMFLKDMELAP> NPLIPEAJIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F9")]
	public IReadOnlyList<GIPKMAIDJHD> BBPPKBKCCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FA")]
	public string? CGKLPFAGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x7953C00", Offset = "0x7952600", VA = "0x187953C00", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x7953C90", Offset = "0x7952690", VA = "0x187953C90")]
	public ANCNCFOHEDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
[NMCNMLEECDM]
public class AAJLCGGADDE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003FB")]
	public IHPFBOBMIJI<ANCNCFOHEDG> ECLPEGKCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FC")]
	public decimal LKNNMMBLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x78669E0", Offset = "0x78653E0", VA = "0x1878669E0", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AAJLCGGADDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public enum FDIJFAGMGAG
{
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[NMCNMLEECDM]
public class MNHJJAPIHEA : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003FD")]
	public FDIJFAGMGAG LBJBLALHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FE")]
	public DateTime PPEIMIBPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MNHJJAPIHEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[NMCNMLEECDM]
public class PCFIAJBHKHG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x170003FF")]
	public FDIJFAGMGAG KLEJLMBGJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000400")]
	public float MGFGOAFGHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E80", Offset = "0xEC6880", VA = "0x180EC7E80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0xEC7E70", Offset = "0xEC6870", VA = "0x180EC7E70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PCFIAJBHKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[NMCNMLEECDM]
public class JKEJHLKFOBK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000401")]
	public FDIJFAGMGAG LBJBLALHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000402")]
	public DateTime PPEIMIBPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000403")]
	public FDIJFAGMGAG KLEJLMBGJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xB0D970", Offset = "0xB0C370", VA = "0x180B0D970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000404")]
	public float MGFGOAFGHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0xB0D530", Offset = "0xB0BF30", VA = "0x180B0D530")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0xB0DB20", Offset = "0xB0C520", VA = "0x180B0DB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000405")]
	public FDIJFAGMGAG NHEFPMJKIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0xAB33D0", Offset = "0xAB1DD0", VA = "0x180AB33D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000406")]
	public float KPEBIGDAPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0xDDC030", Offset = "0xDDAA30", VA = "0x180DDC030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0xDDC040", Offset = "0xDDAA40", VA = "0x180DDC040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JKEJHLKFOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[NMCNMLEECDM]
public class FMOLAOBEJCF : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000407")]
	public TimeSpan EDJKGPGFPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000408")]
	public TimeSpan FLKBEKIMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FMOLAOBEJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[NMCNMLEECDM]
public class FDNNMGEPGDM : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000409")]
	public List<string> AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FDNNMGEPGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[NMCNMLEECDM]
public class KIHNGCDGCBI : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700040A")]
	public string? FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040B")]
	public string AFJODCOHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040C")]
	public string CHFALKFDCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040D")]
	public string MJHKOECGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040E")]
	public string? KJLIBJNMEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x795BB60", Offset = "0x795A560", VA = "0x18795BB60")]
	public KIHNGCDGCBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[NMCNMLEECDM]
public class IHINEBFOCKN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700040F")]
	public ENEHDIDOEFG CELNIEDKPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000410")]
	public FDIJFAGMGAG AMJHPOFNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(FDIJFAGMGAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000411")]
	public long? AHKCGHKPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A60", Offset = "0xEC8460", VA = "0x180EC9A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0xFC3A10", Offset = "0xFC2410", VA = "0x180FC3A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000412")]
	public DateTime? OLGHLGOCJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0xF84360", Offset = "0xF82D60", VA = "0x180F84360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xF83BD0", Offset = "0xF825D0", VA = "0x180F83BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000413")]
	public long? HENNBOJIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C680", VA = "0x18109DC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x109DC70", Offset = "0x109C670", VA = "0x18109DC70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IHINEBFOCKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[NMCNMLEECDM]
public class JKALFADFGCO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000414")]
	public int HLJLJCBCDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000415")]
	public DateTime? OHMLLIHNEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB00", Offset = "0xF8C500", VA = "0x180F8DB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JKALFADFGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[NMCNMLEECDM]
public class MKGFMFIGBFH : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000416")]
	public List<CEEOAHIBCHO> JELCBGOAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MKGFMFIGBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[NMCNMLEECDM]
public class CEEOAHIBCHO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000417")]
	public string HIPPOGMEDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x7955EE0", Offset = "0x79548E0", VA = "0x187955EE0")]
	public CEEOAHIBCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[NMCNMLEECDM]
public class PBFLCJHJGNG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000418")]
	public List<ABPNHOCMFDB> OEAPIFCKCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000419")]
	public string FJACLJMIOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x795E5D0", Offset = "0x795CFD0", VA = "0x18795E5D0")]
	public PBFLCJHJGNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[NMCNMLEECDM]
public class ABPNHOCMFDB : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700041A")]
	public string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041B")]
	public string IAIKBMAPMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041C")]
	public string NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041D")]
	public string EGJJCGGJOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041E")]
	public DateTime FANPBCJKNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C90", Offset = "0xAB4690", VA = "0x180AB5C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public ABPNHOCMFDB(string NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public enum EPGFBBKIGOI
{
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	User,
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	System,
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	AI
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[NMCNMLEECDM]
public class NFIPMOIHBFF : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700041F")]
	public string CBAICICBJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000420")]
	public EPGFBBKIGOI BBABCAOOJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(EPGFBBKIGOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000421")]
	public string MCFBIHIKFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NFIPMOIHBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[NMCNMLEECDM]
public class MIBIJJGJKFN : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000422")]
	public string CBAICICBJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000423")]
	public string LABNEGPEDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000424")]
	public string GOFCLEHMLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MIBIJJGJKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
public enum PFKIONNDEEB
{
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	Required,
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	Forced
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[NMCNMLEECDM]
public class HIJPBOEHCOE : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000425")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000426")]
	public string CLPFJINNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000427")]
	public string? ELDLMDNPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HIJPBOEHCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[NMCNMLEECDM]
public class OJKOBLBCMHL : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000428")]
	public string CBAICICBJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000429")]
	public string? FEKBMOMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042A")]
	public float? OCIBKFGOKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042B")]
	public HIJPBOEHCOE? MJHKOECGMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042C")]
	public List<HIJPBOEHCOE> ODBKHHNHEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042D")]
	public PFKIONNDEEB MEPGIMJFNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		[CompilerGenerated]
		get
		{
			return default(PFKIONNDEEB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xEFC730", Offset = "0xEFB130", VA = "0x180EFC730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042E")]
	public string? PNJENEIJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x795E230", Offset = "0x795CC30", VA = "0x18795E230", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x795E250", Offset = "0x795CC50", VA = "0x18795E250")]
	public OJKOBLBCMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[NMCNMLEECDM]
public class HEKODKKCGPK : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x1700042F")]
	public string BKICOPKGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000430")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000431")]
	public string EDPLDEHIPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HEKODKKCGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[NMCNMLEECDM]
public class LANLKNMKDGO : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000432")]
	public List<string> OOBJONIBCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000433")]
	public List<HEKODKKCGPK>? JBOFOACHONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x795C170", Offset = "0x795AB70", VA = "0x18795C170", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LANLKNMKDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[NMCNMLEECDM]
public class OJHFOIJJHPG : HJBDJGHOGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000434")]
	public string EDBPDGHPKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void JCFGPHPCCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OJHFOIJJHPG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000181")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x7684ED0", Offset = "0x76838D0", VA = "0x187684ED0")]
	public static string GFBFIMHGKPM(byte[] DDEIHHFHHME, byte[] JHDCFCMBFOH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
