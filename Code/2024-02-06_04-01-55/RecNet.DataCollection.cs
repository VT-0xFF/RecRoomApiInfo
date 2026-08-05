using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5803560", Offset = "0x5802960", VA = "0x185803560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KDPECBAKJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> IFEJMBMOEKC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JENKLMKKOAG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DNBEMIKHMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BLJJOBIFCDH NLMJMAGNKFA(Guid NFINLDCGANN, string AHHPGJPOKHJ, [Optional] string IPFKHIBJBNI, [Optional] long? JHNMNABFEIK, [Optional] string MJGOFPFLEKC, [Optional] string EKBLLAKLJKL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OIEMPHGBLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5803EA0", Offset = "0x58032A0", VA = "0x185803EA0")]
		public static BLJJOBIFCDH KNGPFHHABOJ(Guid NFINLDCGANN, string AHHPGJPOKHJ, string IPFKHIBJBNI, [Optional] long? JHNMNABFEIK, [Optional] string MJGOFPFLEKC, [Optional] string EKBLLAKLJKL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class BLJJOBIFCDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected PGMMFLDHJNM AAHHIKMPPAJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
		public BLJJOBIFCDH(PGMMFLDHJNM AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57FED00", Offset = "0x57FE100", VA = "0x1857FED00")]
		public BLJJOBIFCDH ODGNGIBCCEK(string PLNALAIILFK, string ANJCCKHBJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E290", Offset = "0x2C9D690", VA = "0x182C9E290")]
		public BLJJOBIFCDH ODGNGIBCCEK<T>(string PLNALAIILFK, T ANJCCKHBJJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E190", Offset = "0x2C9D590", VA = "0x182C9E190")]
		public BLJJOBIFCDH LKIOBHFFGHH<T>(string PLNALAIILFK, T? ANJCCKHBJJO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57FEC70", Offset = "0x57FE070", VA = "0x1857FEC70")]
		public BLJJOBIFCDH LKIOBHFFGHH(string PLNALAIILFK, string ANJCCKHBJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x57FEC50", Offset = "0x57FE050", VA = "0x1857FEC50")]
		public IIJBCHKFBNI BGPBKFMLKIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1D33180", Offset = "0x1D32580", VA = "0x181D33180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PGMMFLDHJNM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<PGMMFLDHJNM> LFKPOPDJEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string LOHMAPLKFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> CDNMCNLECBC;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5806D10", Offset = "0x5806110", VA = "0x185806D10")]
		private PGMMFLDHJNM(string LOHMAPLKFCN, int KFLANNEPPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5802CE0", Offset = "0x58020E0", VA = "0x185802CE0")]
		public static BLJJOBIFCDH HDHFILGDDKG(string LOHMAPLKFCN, int KFLANNEPPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5806A80", Offset = "0x5805E80", VA = "0x185806A80")]
		public IIJBCHKFBNI BGPBKFMLKIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5806CA0", Offset = "0x58060A0", VA = "0x185806CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x26CDDC0", Offset = "0x26CD1C0", VA = "0x1826CDDC0")]
		internal void AFDIDBEIALC<T>(string PLNALAIILFK, T ANJCCKHBJJO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5806A20", Offset = "0x5805E20", VA = "0x185806A20")]
		internal void AFDIDBEIALC(string PLNALAIILFK, string ANJCCKHBJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5130", Offset = "0x2CA4530", VA = "0x182CA5130")]
		private void MCLGLHINLLE<T>(string PLNALAIILFK, T ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JEOJDHKDMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string MOPAIKJCNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? IBHBBJILKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? BEACMHCOODN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5803020", Offset = "0x5802420", VA = "0x185803020")]
		public JEOJDHKDMHF(string NKALCAPLDDA, [Optional] long? KKFMPNCGPKO, [Optional] short? MCHGCOFBOID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct KADANAHCBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int DOJOGAPCHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string CILGLFOADOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short FDGHIPKMNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string OOEFMMGEDOE;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5803060", Offset = "0x5802460", VA = "0x185803060")]
		public KADANAHCBDK(int LODHKHLNOOM, string NKBHMCBLIDH, short JBMMGDLBDBP, string OBGHGEBCFDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OIPNPKHFIHF : KOIEOFOAMIE<GJGMICDDCOF, KADANAHCBDK, JEOJDHKDMHF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string NKBHMCBLIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short JBMMGDLBDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string OBGHGEBCFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> IHHDAANCNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MEDNNKAKLNM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5805530", Offset = "0x5804930", VA = "0x185805530")]
		public OIPNPKHFIHF(string CJMCNKMIMDL, Guid KHEJPDBANEL, long GJFLGBMDDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5804F80", Offset = "0x5804380", VA = "0x185804F80", Slot = "4")]
		public override void NMBBKIMAHHA(KADANAHCBDK IPOFKOAEHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x58040B0", Offset = "0x58034B0", VA = "0x1858040B0")]
		public void DEEDMJEMALM(short JBMMGDLBDBP, bool EPPAJPKDBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3624150", Offset = "0x3623550", VA = "0x183624150")]
		public void CMFGIFGMMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7A6800", Offset = "0x7A5C00", VA = "0x1807A6800")]
		public void NJILMFBJKJH(string MKALAFKJBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5804190", Offset = "0x5803590", VA = "0x185804190", Slot = "5")]
		public override void FNGGNOFNPKF(bool KBILKKFNAKG, JEOJDHKDMHF EHDICPFKAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5805270", Offset = "0x5804670", VA = "0x185805270", Slot = "6")]
		public override CLMDJADBNMJ PCGLLJMDDCL(GJGMICDDCOF GGDGPACJFJN, int AHDNEIKOMIB, string EPOJLLJMEHO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FJKPBHCKCNE : CLMDJADBNMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string NKBHMCBLIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short JBMMGDLBDBP;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57FFD50", Offset = "0x57FF150", VA = "0x1857FFD50")]
		public FJKPBHCKCNE(long CLKANEFGNMP, int LODHKHLNOOM, string IPFKHIBJBNI, long GJFLGBMDDAH, int JOKKLEJHEMG, string MJGOFPFLEKC, short JBMMGDLBDBP, string NKBHMCBLIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x57FFCC0", Offset = "0x57FF0C0", VA = "0x1857FFCC0")]
		public void OKMJPJMMLHI(int LODHKHLNOOM, string NKBHMCBLIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x57FFB90", Offset = "0x57FEF90", VA = "0x1857FFB90", Slot = "5")]
		public override BLJJOBIFCDH NLMJMAGNKFA(Guid NFINLDCGANN, string AHHPGJPOKHJ, [Optional] string IPFKHIBJBNI, [Optional] long? JHNMNABFEIK, [Optional] string MJGOFPFLEKC, [Optional] string EKBLLAKLJKL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class OAJHEGLFGOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct PEGCEOEGDID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int OFEEGLBOFFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int BIBAHCPMEII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int PBKCNHGJJPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int CFFGPBBPFON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int BFIHAECAKCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int DEAMHOHONLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int BNKKIEKGOBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int CPONKIFDMIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int EJPHKCGFFEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int DMHALJPCPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int MLGKHFMJLKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int EKIAKKODDNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int FCDIEBHOIEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int PNBOKBBJNPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int NCBGINAGBLD;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x58067D0", Offset = "0x5805BD0", VA = "0x1858067D0")]
			public PEGCEOEGDID(int IELNMELNDDB, int GFFONLBCCDE, int PGJAEBEJJPM, int AMPKKBDIIEJ, int GBLFBFFKPBG, int AAKCLHKNOBD, int HKEPBCCGJPO, int JNBCNKNILGI, int HDCLELANJKD, int JHOLLAJEFLA, int ODHPOBPKEMN, int FHAGIDJLCKK, int PEGNGCDJMKN, int MLJIHONEHGM, int NCDAHLMKNHD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? CMODOIGGBKC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> KDPILHAMMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5803DE0", Offset = "0x58031E0", VA = "0x185803DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58035E0", Offset = "0x58029E0", VA = "0x1858035E0")]
		public static void HKBBJAJIODN(PEGCEOEGDID GCHANDHJFKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class CBCKOCHEOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x57FF360", Offset = "0x57FE760", VA = "0x1857FF360")]
		public static void AKCAOJCKJNM(string GPGELODKPOB, object NFHMFDDONOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57FF140", Offset = "0x57FE540", VA = "0x1857FF140")]
		public static void AKCAOJCKJNM(string GPGELODKPOB, HDJCNNPMBAI NFHMFDDONOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class KIBHMPOOCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x58030B0", Offset = "0x58024B0", VA = "0x1858030B0")]
		public static void GLCGEJCNNLI(float3 BEBKKMFGLCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class EEKEBDLPODD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IOILFMBAIGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public EEKEBDLPODD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public IOILFMBAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x383E860", Offset = "0x383DC60", VA = "0x18383E860")]
			internal object HLHKDLBBHJE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BEMDOBIIMGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public EEKEBDLPODD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BEMDOBIIMGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x472E690", Offset = "0x472DA90", VA = "0x18472E690")]
			internal object KHLJJOCDAGC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class PMLEGBGHPBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public EEKEBDLPODD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public PMLEGBGHPBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x40B2C10", Offset = "0x40B2010", VA = "0x1840B2C10")]
			internal object IHEDPINANGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class EIJKKAIOEGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public EEKEBDLPODD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public long elementId;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public EIJKKAIOEGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x32B8500", Offset = "0x32B7900", VA = "0x1832B8500")]
			internal object GBKGKMIMKOG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float IDLDDGMHHPM = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid NFINLDCGANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string MJGOFPFLEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string DHKHHONEMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string APAOPAIAPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string EKBLLAKLJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string OBEAIDPEDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string FHOINJIBJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string LJNAPMMKGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string POPGJFOHKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string PAIDAPDIBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private IEnumerable<int?> PNMNMOCPPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HashSet<T> LNKHLEPEEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Dictionary<(T, int), string> IPCGINOJPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), float> FJNBENOMALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<long, string> DPDDKLFNHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool AJOEHHPCMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IIJBCHKFBNI DBLMIJEDIAO;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32ADA20", Offset = "0x32ACE20", VA = "0x1832ADA20")]
		public EEKEBDLPODD(Guid NFINLDCGANN, string DHKHHONEMJB, string MJGOFPFLEKC, string APAOPAIAPEI, [Optional] string EKBLLAKLJKL, [Optional] string OBEAIDPEDEM, [Optional] string FHOINJIBJHP, [Optional] string PAIDAPDIBFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A5A10", Offset = "0x7A4E10", VA = "0x1807A5A10")]
		public void MACHBHDNMMD(string EKBLLAKLJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		public void JIDENKKOGLJ(string APAOPAIAPEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7A67C0", Offset = "0x7A5BC0", VA = "0x1807A67C0")]
		public void NIPMCIFABJI(string LJNAPMMKGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A6810", Offset = "0x7A5C10", VA = "0x1807A6810")]
		public void OHAEHALDOMH(string POPGJFOHKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32AAFF0", Offset = "0x32AA3F0", VA = "0x1832AAFF0")]
		public void DBJELBDAFKP(T JHNMNABFEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x32ACEC0", Offset = "0x32AC2C0", VA = "0x1832ACEC0")]
		public void LEEJADMPFND(T JHNMNABFEIK, int MEAMFLDBHHM, float POAEONMMKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32AB5D0", Offset = "0x32AA9D0", VA = "0x1832AB5D0")]
		public void DCDMLCGPMBF(T JHNMNABFEIK, int MEAMFLDBHHM, string HNNPMBEMOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x32ACD40", Offset = "0x32AC140", VA = "0x1832ACD40")]
		public void FIOMPAHAPCK(long JHNMNABFEIK, string OOAFHFCOKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x32A7E90", Offset = "0x32A7290", VA = "0x1832A7E90")]
		public void BGNGJJCAHCN(IEnumerable<int?> EDFAKGGMPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x32A8CA0", Offset = "0x32A80A0", VA = "0x1832A8CA0")]
		public IIJBCHKFBNI BGPBKFMLKIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32AC440", Offset = "0x32AB840", VA = "0x1832AC440")]
		private (string, string) ELHMMOIDILK()
		{
			return default((string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32AA500", Offset = "0x32A9900", VA = "0x1832AA500")]
		public static BLJJOBIFCDH CAMPDHPANHL(Guid NFINLDCGANN, string DHKHHONEMJB, T JHNMNABFEIK, string MJGOFPFLEKC, string BAFAOGMBHCF, string EKBLLAKLJKL, int? AHDNEIKOMIB, [Optional] string LELDKGCONDA, [Optional] string OOAFHFCOKGL, [Optional] int? MIIFEFJJHNN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class KOIEOFOAMIE<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string CJMCNKMIMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid KHEJPDBANEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long GJFLGBMDDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int LODHKHLNOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int FIJPLKDHGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime FCIFFFNCEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool GILLDMEDIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, CLMDJADBNMJ> GNNOPACHDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool KJMKEKPOLHG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool OOIEMCANFAP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x818FE0", Offset = "0x8183E0", VA = "0x180818FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NOKNIALNJMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCD3950", Offset = "0xCD2D50", VA = "0x180CD3950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF5A0", Offset = "0x3ADE9A0", VA = "0x183ADF5A0")]
		public KOIEOFOAMIE(string CJMCNKMIMDL, Guid KHEJPDBANEL, long GJFLGBMDDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void NMBBKIMAHHA(TListSessionStartParams IPOFKOAEHNL);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF590", Offset = "0x3ADE990", VA = "0x183ADF590")]
		public void ODNPEBLJDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FNGGNOFNPKF(bool KBILKKFNAKG, TListSessionLogParams EHDICPFKAAL);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF420", Offset = "0x3ADE820", VA = "0x183ADF420")]
		public void DLAIPIAEHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF230", Offset = "0x3ADE630", VA = "0x183ADF230")]
		public void BMCPKAPGKLB(long CLKANEFGNMP, int AHDNEIKOMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF500", Offset = "0x3ADE900", VA = "0x183ADF500")]
		public void MPNPLAEGMFJ(long CLKANEFGNMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract CLMDJADBNMJ PCGLLJMDDCL(TItem IEEBNOOJIPC, int AHDNEIKOMIB, string EPOJLLJMEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class CLMDJADBNMJ : DNBEMIKHMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int LODHKHLNOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long CLKANEFGNMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long GJFLGBMDDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string KLOPKAHJCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string GLDMCFPGOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int JOKKLEJHEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime FHPIGJPFFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double HMLENHNKBLI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GCOGOLGDNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC70DF0", Offset = "0xC701F0", VA = "0x180C70DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xC70DE0", Offset = "0xC701E0", VA = "0x180C70DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x57FFAC0", Offset = "0x57FEEC0", VA = "0x1857FFAC0")]
		public CLMDJADBNMJ(long CLKANEFGNMP, int LODHKHLNOOM, string IPFKHIBJBNI, long GJFLGBMDDAH, int JOKKLEJHEMG, [Optional] string MJGOFPFLEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57FF3D0", Offset = "0x57FE7D0", VA = "0x1857FF3D0")]
		public void COODGPFHBEN(int LODHKHLNOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x57FF440", Offset = "0x57FE840", VA = "0x1857FF440")]
		public void DLIAGHFAFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57FF500", Offset = "0x57FE900", VA = "0x1857FF500")]
		public void GMBPJCDLHKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x57FF490", Offset = "0x57FE890", VA = "0x1857FF490")]
		private void DPGIADLHHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57FF610", Offset = "0x57FEA10", VA = "0x1857FF610", Slot = "5")]
		public virtual BLJJOBIFCDH NLMJMAGNKFA(Guid NFINLDCGANN, string AHHPGJPOKHJ, [Optional] string IPFKHIBJBNI, [Optional] long? JHNMNABFEIK, [Optional] string MJGOFPFLEKC, [Optional] string EKBLLAKLJKL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IGNCBHGOJOK
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GJJJKDJBHKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GJJJKDJBHKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x57FFE40", Offset = "0x57FF240", VA = "0x1857FFE40")]
			internal bool JLMIACBBMIJ()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct OMJNPIMJJIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private GJJJKDJBHKL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x58055B0", Offset = "0x58049B0", VA = "0x1858055B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5806770", Offset = "0x5805B70", VA = "0x185806770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float ENMONABHGJK;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> JBHDKPDBFBN;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> OBJOJCKOHAP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string HNIHIOFDKEC;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? ANGAKBIFNNP;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int MFPFFCNNOJB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static bool KDMPICPOPNP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Dictionary<string, KDPECBAKJEM> MBIBJHCCMJH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly DICJLHNIKOO HBGPAOLOLKI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static NKMEFLDNBKH? NHIMCFCPCGN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string LAPICOCNJCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x58027D0", Offset = "0x5801BD0", VA = "0x1858027D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x58014B0", Offset = "0x58008B0", VA = "0x1858014B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? ECHMEFHAKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5801440", Offset = "0x5800840", VA = "0x185801440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x57FFEE0", Offset = "0x57FF2E0", VA = "0x1857FFEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? FDGNJAMNCAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x58004D0", Offset = "0x57FF8D0", VA = "0x1858004D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5801600", Offset = "0x5800A00", VA = "0x185801600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static KCJJJNFDHFE KFMGKJBCAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5800540", Offset = "0x57FF940", VA = "0x185800540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool LILNBHDBMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x58012B0", Offset = "0x58006B0", VA = "0x1858012B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5801860", Offset = "0x5800C60", VA = "0x185801860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool JMKLODMIJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5802820", Offset = "0x5801C20", VA = "0x185802820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5800D10", Offset = "0x5800110", VA = "0x185800D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float CMKMHKEBPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5800590", Offset = "0x57FF990", VA = "0x185800590")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5800990", Offset = "0x57FFD90", VA = "0x185800990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5801570", Offset = "0x5800970", VA = "0x185801570")]
		public static void MAGOKPJHIFM(string JIACPNLMDFE, KDPECBAKJEM BKDLAHJNEKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x57FFF40", Offset = "0x57FF340", VA = "0x1857FFF40")]
		private static void BJMAHEFONEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5801F40", Offset = "0x5801340", VA = "0x185801F40")]
		internal static void OBMDJKKOMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x58007D0", Offset = "0x57FFBD0", VA = "0x1858007D0")]
		internal static void EGGINPAKHMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5800420", Offset = "0x57FF820", VA = "0x185800420")]
		internal static void CFIIBANLMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x58018C0", Offset = "0x5800CC0", VA = "0x1858018C0")]
		public static Guid NMBBKIMAHHA(string JIACPNLMDFE, [Optional] string? OCLNFGHLMOL, [Optional] Dictionary<string, object>? FCHOKOPEKBH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5801EA0", Offset = "0x58012A0", VA = "0x185801EA0")]
		public static Guid NMBBKIMAHHA(string JIACPNLMDFE, long OCLNFGHLMOL, [Optional] Dictionary<string, object>? FCHOKOPEKBH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5802110", Offset = "0x5801510", VA = "0x185802110")]
		public static void ODNPEBLJDBI(string JIACPNLMDFE, [Optional] Guid? LHLNCEHJAOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5801660", Offset = "0x5800A60", VA = "0x185801660")]
		public static void NEKPLLHEFFM(string JIACPNLMDFE, string GBGIFCKJMIO, object NLMHJMLNMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58005E0", Offset = "0x57FF9E0", VA = "0x1858005E0")]
		public static bool EAEEOFKNJAE(string JIACPNLMDFE, [Optional] string? OCLNFGHLMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5801300", Offset = "0x5800700", VA = "0x185801300")]
		private static void JCIIJDCNBAD(bool DIKEKIJHMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5800B80", Offset = "0x57FFF80", VA = "0x185800B80")]
		internal static void HNCIPNHHOEI(string HFPPGLCONIA, string GPGELODKPOB, object ALPLHOOHPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x58009F0", Offset = "0x57FFDF0", VA = "0x1858009F0")]
		internal static void HNCIPNHHOEI(string HFPPGLCONIA, Dictionary<string, object> HAJDGKCJJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x58003A0", Offset = "0x57FF7A0", VA = "0x1858003A0")]
		private static void BLDIEFHJOJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5802380", Offset = "0x5801780", VA = "0x185802380")]
		public static void OEPOMLEALDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58023D0", Offset = "0x58017D0", VA = "0x1858023D0")]
		private static void OFLADOJJKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x58026F0", Offset = "0x5801AF0", VA = "0x1858026F0")]
		private static void OHDNICNFEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x58011E0", Offset = "0x58005E0", VA = "0x1858011E0")]
		[AsyncStateMachine(typeof(OMJNPIMJJIB))]
		private static Task IEKFKPFBJKH(CancellationToken PPJMMMGPFGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5800D70", Offset = "0x5800170", VA = "0x185800D70")]
		private static void IBKMOAKOMFN(string JIACPNLMDFE, Guid NFINLDCGANN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class ACOPDMFFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct KMJHOJOKEIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public bool GDPLLPCFBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public string PLLJJKBGMHI;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1791CA0", Offset = "0x17910A0", VA = "0x181791CA0")]
			public KMJHOJOKEIB(bool GDPLLPCFBNP, string PLLJJKBGMHI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x57FE010", Offset = "0x57FD410", VA = "0x1857FE010")]
		public static KMJHOJOKEIB JBOJMAMBIHB(BLJJOBIFCDH JLFGCHJAJBH)
		{
			return default(KMJHOJOKEIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57FE330", Offset = "0x57FD730", VA = "0x1857FE330")]
		private static void JJGJMEMNLHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57FE430", Offset = "0x57FD830", VA = "0x1857FE430")]
		private static void KIENOAMKPPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BGBBPNOGLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x57FEBF0", Offset = "0x57FDFF0", VA = "0x1857FEBF0")]
		public static BLJJOBIFCDH APIHKLLJAFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class CAIINONDCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57FEEA0", Offset = "0x57FE2A0", VA = "0x1857FEEA0")]
		public static BLJJOBIFCDH FHOGGKPEODE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x57FEFC0", Offset = "0x57FE3C0", VA = "0x1857FEFC0")]
		public static BLJJOBIFCDH KGFKAGDCPJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57FEF00", Offset = "0x57FE300", VA = "0x1857FEF00")]
		public static BLJJOBIFCDH HMCKLMGONDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57FEDE0", Offset = "0x57FE1E0", VA = "0x1857FEDE0")]
		public static BLJJOBIFCDH CJLLEIGIFBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57FED80", Offset = "0x57FE180", VA = "0x1857FED80")]
		public static BLJJOBIFCDH CAGPIAFFFOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x57FF0E0", Offset = "0x57FE4E0", VA = "0x1857FF0E0")]
		public static BLJJOBIFCDH PPKEIKIDHNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57FF080", Offset = "0x57FE480", VA = "0x1857FF080")]
		public static BLJJOBIFCDH OCFIPMOADLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x57FEE40", Offset = "0x57FE240", VA = "0x1857FEE40")]
		public static BLJJOBIFCDH EECLLKJGIDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x57FEF60", Offset = "0x57FE360", VA = "0x1857FEF60")]
		public static BLJJOBIFCDH JADIIPJGBNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x57FF020", Offset = "0x57FE420", VA = "0x1857FF020")]
		public static BLJJOBIFCDH LIDNMDOALMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PGIOCPBPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5806840", Offset = "0x5805C40", VA = "0x185806840")]
		public static BLJJOBIFCDH NGHBBOHAIEM(long KKFMPNCGPKO, long FIPIBEMPEAF, bool OJHDCOMPIEG, string KNIBGLJLJAB, string JHHOPEILAOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class LBAOMLACJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58031C0", Offset = "0x58025C0", VA = "0x1858031C0")]
		public static BLJJOBIFCDH ADFNABOIFFN(string PCDEGGKCLPJ, string BCANNLPEJHP, bool BJKIIOCJPHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5803330", Offset = "0x5802730", VA = "0x185803330")]
		public static BLJJOBIFCDH HCPGGAFDJFP(string HFPPGLCONIA, string BPHDINNFAPM, string HBFNMODJANI, [Optional] int? IJIIFLKDHGA, [Optional] double[] ENHJLCJOEON)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ANPFODPEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x57FE7E0", Offset = "0x57FDBE0", VA = "0x1857FE7E0")]
		public static BLJJOBIFCDH HOCCNBANIBD(string IMHJEOHOPIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x57FE6A0", Offset = "0x57FDAA0", VA = "0x1857FE6A0")]
		public static BLJJOBIFCDH FIMAFDDHCAL(string AIOEILMMNKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57FE920", Offset = "0x57FDD20", VA = "0x1857FE920")]
		public static BLJJOBIFCDH ODJLEGBNELD(int KFLANNEPPAB, string GFBABMFGHOJ, string FNOGEAGAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57FE780", Offset = "0x57FDB80", VA = "0x1857FE780")]
		public static BLJJOBIFCDH FOFCHBIBMAC(int KFLANNEPPAB, string GFBABMFGHOJ, string FNOGEAGAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x57FE640", Offset = "0x57FDA40", VA = "0x1857FE640")]
		public static BLJJOBIFCDH EDKJOCDANBE(int KFLANNEPPAB, string GFBABMFGHOJ, string FNOGEAGAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x57FE8C0", Offset = "0x57FDCC0", VA = "0x1857FE8C0")]
		public static BLJJOBIFCDH IMPOIEFDBHP(int KFLANNEPPAB, string GFBABMFGHOJ, string FNOGEAGAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x57FE4F0", Offset = "0x57FD8F0", VA = "0x1857FE4F0")]
		public static BLJJOBIFCDH EBDFHCNCHIM(string GFBABMFGHOJ, string FNOGEAGAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x57FE980", Offset = "0x57FDD80", VA = "0x1857FE980")]
		private static BLJJOBIFCDH PGIJJCOEMNG(string CJMCNKMIMDL, int KFLANNEPPAB, string CFEBCHENLAL, string DHIJPNOKOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x57FEAC0", Offset = "0x57FDEC0", VA = "0x1857FEAC0")]
		private static BLJJOBIFCDH PGIJJCOEMNG(string CJMCNKMIMDL, string CFEBCHENLAL, string DHIJPNOKOFE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly OKECMMGLCGL JBOJMAMBIHB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FHDFONCLEPF MAMDEOELOAB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static PECGDHEJDOJ KIMMCJFLNIN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<BLJJOBIFCDH> OLLFONHCNIG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long OMBGNEHMCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5802E10", Offset = "0x5802210", VA = "0x185802E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5802AE0", Offset = "0x5801EE0", VA = "0x185802AE0")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_BeforeSceneLoad)]
	private static void DDEFNBKGBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5802F00", Offset = "0x5802300", VA = "0x185802F00")]
	private static void OBMDJKKOMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5802D90", Offset = "0x5802190", VA = "0x185802D90")]
	public static BLJJOBIFCDH KGPFMCMFDLM(string LOHMAPLKFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5802CE0", Offset = "0x58020E0", VA = "0x185802CE0")]
	public static BLJJOBIFCDH KGPFMCMFDLM(string LOHMAPLKFCN, int KFLANNEPPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5802BC0", Offset = "0x5801FC0", VA = "0x185802BC0")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_BeforeSceneLoad)]
	private static void HIHJBDLHDBC()
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
