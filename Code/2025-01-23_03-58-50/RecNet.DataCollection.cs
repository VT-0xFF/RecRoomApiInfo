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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x659FE10", Offset = "0x659E610", VA = "0x18659FE10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x659CEC0", Offset = "0x659B6C0", VA = "0x18659CEC0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65A1770", Offset = "0x659FF70", VA = "0x1865A1770", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBBGCKBPDHD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> OKKINAIJNIL();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DHLFCDCDCJK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EPAKLJBLLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OMFEPOCLDCL OFPKEANHELC(Guid JJNICACABPB, string HJGFDIPCBNA, [Optional] string KNALOFPNFGF, [Optional] long? OPHBLCIMHEC, [Optional] string OFLNBGDFDAO, [Optional] string BLIPHCBHELD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class HBOBFIEBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6599BD0", Offset = "0x65983D0", VA = "0x186599BD0")]
		public static OMFEPOCLDCL OFDKKKNLCEP(Guid JJNICACABPB, string HJGFDIPCBNA, string KNALOFPNFGF, [Optional] long? OPHBLCIMHEC, [Optional] string OFLNBGDFDAO, [Optional] string BLIPHCBHELD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class OMFEPOCLDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected PADECODJJLF NBKLKIFNAIH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
		public OMFEPOCLDCL(PADECODJJLF NBKLKIFNAIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65A0370", Offset = "0x659EB70", VA = "0x1865A0370")]
		public OMFEPOCLDCL CBCEOFNIIEL(string MFCFAMOHGBK, string INDENPJBLHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3710330", Offset = "0x370EB30", VA = "0x183710330")]
		public OMFEPOCLDCL CBCEOFNIIEL<T>(string MFCFAMOHGBK, T INDENPJBLHO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37106C0", Offset = "0x370EEC0", VA = "0x1837106C0")]
		public OMFEPOCLDCL HLBGIODDPBF<T>(string MFCFAMOHGBK, T? INDENPJBLHO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65A0410", Offset = "0x659EC10", VA = "0x1865A0410")]
		public OMFEPOCLDCL HLBGIODDPBF(string MFCFAMOHGBK, string INDENPJBLHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65A03F0", Offset = "0x659EBF0", VA = "0x1865A03F0")]
		public MOPOHKAGKCI HJBMPCHFGBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2308D60", Offset = "0x2307560", VA = "0x182308D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PADECODJJLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<PADECODJJLF> ACHJJDLEGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string KLIEFOPLHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> AKDJJMDGJFB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65A0A10", Offset = "0x659F210", VA = "0x1865A0A10")]
		private PADECODJJLF(string KLIEFOPLHLG, int OLKCJJDGMPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6599250", Offset = "0x6597A50", VA = "0x186599250")]
		public static OMFEPOCLDCL JHEOKMMJDLF(string KLIEFOPLHLG, int OLKCJJDGMPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65A0750", Offset = "0x659EF50", VA = "0x1865A0750")]
		public MOPOHKAGKCI HJBMPCHFGBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65A09A0", Offset = "0x659F1A0", VA = "0x1865A09A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E5DD70", Offset = "0x2E5C570", VA = "0x182E5DD70")]
		internal void CNLAOLJFINB<T>(string MFCFAMOHGBK, T INDENPJBLHO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65A06F0", Offset = "0x659EEF0", VA = "0x1865A06F0")]
		internal void CNLAOLJFINB(string MFCFAMOHGBK, string INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x37117F0", Offset = "0x370FFF0", VA = "0x1837117F0")]
		private void ACCOGANPCIO<T>(string MFCFAMOHGBK, T INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CEBKHPLNNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string HHFGNOFGLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? FMJKOMLKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? DBJIIIHMIMD;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6599190", Offset = "0x6597990", VA = "0x186599190")]
		public CEBKHPLNNEO(string MLEAEJPJMOL, [Optional] long? NKDNOGOOODN, [Optional] short? JOEHDLKPHLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HOEBPBFEBPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int LCCDBFECOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string LBJEAEADDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short FFMEIMAKPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string AGAHDKMJIAO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6599DE0", Offset = "0x65985E0", VA = "0x186599DE0")]
		public HOEBPBFEBPD(int PGLBFLGIFBF, string IDGFONMAJFD, short IDNAPMDHJLM, string HFMKNLPJJBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NBKGCBIMMDA : KDBNHCODHAB<NCCNBLBAJGE, HOEBPBFEBPD, CEBKHPLNNEO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string IDGFONMAJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short IDNAPMDHJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string HFMKNLPJJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> KFGKDKDJPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int EGJAIKBKBJP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x659FD30", Offset = "0x659E530", VA = "0x18659FD30")]
		public NBKGCBIMMDA(string FBCFCCIBNHM, Guid HDCDMMLFMME, long DCDLHONMOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x659E8C0", Offset = "0x659D0C0", VA = "0x18659E8C0", Slot = "4")]
		public override void BBOFIPICJLM(HOEBPBFEBPD EDEDBJOODHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x659EBB0", Offset = "0x659D3B0", VA = "0x18659EBB0")]
		public void MDALACLBPBB(short IDNAPMDHJLM, bool EJBDBJMCJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4049F60", Offset = "0x4048760", VA = "0x184049F60")]
		public void GICLEFBCAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B74F0", Offset = "0x8B5CF0", VA = "0x1808B74F0")]
		public void LOCIPANBPBF(string NCACEDMNIGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x659EF50", Offset = "0x659D750", VA = "0x18659EF50", Slot = "5")]
		public override void PECKPILAMDF(bool IDAFPIDNCKC, CEBKHPLNNEO FMGCOJNHIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x659EC90", Offset = "0x659D490", VA = "0x18659EC90", Slot = "6")]
		public override NBCFADJFDCP NABENJPGGOK(NCCNBLBAJGE IIGEMNCOLHB, int ECDOOAABOPD, string AELPFAFKICJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IGJGJHIDGCK : NBCFADJFDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string IDGFONMAJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short IDNAPMDHJLM;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6599FF0", Offset = "0x65987F0", VA = "0x186599FF0")]
		public IGJGJHIDGCK(long FGAKIHGJJAJ, int PGLBFLGIFBF, string KNALOFPNFGF, long DCDLHONMOIF, int PBDMJNGOPCG, string OFLNBGDFDAO, short IDNAPMDHJLM, string IDGFONMAJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6599E30", Offset = "0x6598630", VA = "0x186599E30")]
		public void DMDPDFNLNBM(int PGLBFLGIFBF, string IDGFONMAJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6599EC0", Offset = "0x65986C0", VA = "0x186599EC0", Slot = "5")]
		public override OMFEPOCLDCL OFPKEANHELC(Guid JJNICACABPB, string HJGFDIPCBNA, [Optional] string KNALOFPNFGF, [Optional] long? OPHBLCIMHEC, [Optional] string OFLNBGDFDAO, [Optional] string BLIPHCBHELD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OPAIPMGCMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x65A0680", Offset = "0x659EE80", VA = "0x1865A0680")]
		public static void OECMBEHCBKA(string KCGKBDGKIOP, object HFGLFOEFCPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class MIGHJLHLGJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct FLGKJBLCEJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int ONHDBDIGDPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int AKNOMJDEBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int OFJJHMCELMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int DELPAPFMHCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int EADNIKFLEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int NIAPNPEOECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int BEOHOJCJGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int MGCOAFKHIAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int GIPEFFEHLGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int NCJCECFPNFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int IIIJFOHFJEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int NAHODDOJEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int FFNNLHAGKCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int FLPONEKIGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int MOJJOHKIFIG;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6599B60", Offset = "0x6598360", VA = "0x186599B60")]
			public FLGKJBLCEJG(int ANEBJNCMKDP, int PGEFHEMDFHK, int DPMMJFOANEP, int FKELBNDBDGI, int DCKONKELFIN, int MBNIHECCDJE, int GEEFHMJBKPF, int MJPGLIOPIKJ, int LAGBLBEDHBC, int NBAEDPFDGIH, int DHKLEJBBAAF, int FIDGEGELKPJ, int HHLFKAIHOKK, int BEKAHMCEIDM, int OMNLNCBPLOD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? BNOHHCLAEIO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> ECAAGMLEMCF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x659D490", Offset = "0x659BC90", VA = "0x18659D490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x659D550", Offset = "0x659BD50", VA = "0x18659D550")]
		public static void ICNLLEGNCFB(FLGKJBLCEJG EANAEIBEGPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CBHIOKLCLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6598DE0", Offset = "0x65975E0", VA = "0x186598DE0")]
		public static void OECMBEHCBKA(string KCGKBDGKIOP, object HFGLFOEFCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6598E50", Offset = "0x6597650", VA = "0x186598E50")]
		public static void OECMBEHCBKA(string KCGKBDGKIOP, float INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6598F60", Offset = "0x6597760", VA = "0x186598F60")]
		public static void OECMBEHCBKA(string KCGKBDGKIOP, NDDPKFPCCGB HFGLFOEFCPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DIKDDHGOHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65997F0", Offset = "0x6597FF0", VA = "0x1865997F0")]
		public static void ENGDHKGMLJI(float3 BALIIBCILHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6599A40", Offset = "0x6598240", VA = "0x186599A40")]
		public static void PKMHJPOEELN(bool DKDOALBJEOF, bool HGEODONOHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6599750", Offset = "0x6597F50", VA = "0x186599750")]
		public static void CIBFGBPBDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x65999A0", Offset = "0x65981A0", VA = "0x1865999A0")]
		public static void LNEOKDPKBLM(int CLGEBPOHGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6599900", Offset = "0x6598100", VA = "0x186599900")]
		public static void GBEHFJLHLKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class IACHPBLCBNO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PNPPAHLIOLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public IACHPBLCBNO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public PNPPAHLIOLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DDB0", Offset = "0x4C7C5B0", VA = "0x184C7DDB0")]
			internal object LNIAOAHIKDA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class GLAGHNABLPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public IACHPBLCBNO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GLAGHNABLPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x41403A0", Offset = "0x413EBA0", VA = "0x1841403A0")]
			internal object ADIDBIANEDP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EEIHANJPBIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public IACHPBLCBNO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public EEIHANJPBIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB430", Offset = "0x3CC9C30", VA = "0x183CCB430")]
			internal object DIGNBNLNEFP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JKLLHIEFJHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public IACHPBLCBNO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JKLLHIEFJHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4558DD0", Offset = "0x45575D0", VA = "0x184558DD0")]
			internal object FCJCKKIAKFH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class GMLKLGNMGBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public IACHPBLCBNO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GMLKLGNMGBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x41431E0", Offset = "0x41419E0", VA = "0x1841431E0")]
			internal object GGKOBJGANIO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float BOJGOJAPGAH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid JJNICACABPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string OFLNBGDFDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string PLEGEAKIHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string CFMCONPHGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string BLIPHCBHELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string LDJKEPILBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string NKBAALIMNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string AEFPOOIAFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string AKGBDOKHMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string LBDMFOIIBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? BPAOPGBNLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? LJFNCPMDNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> CGJCFCFGMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> CHKGCBHHKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> IPHIBEKDPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> FPNJNNCBBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Dictionary<T, string[]> FGACKMDANPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string CPFMFPOPBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool JGBGAFNNHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private MOPOHKAGKCI EPIFJMKIMIO;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x42F2F60", Offset = "0x42F1760", VA = "0x1842F2F60")]
		public IACHPBLCBNO(Guid JJNICACABPB, string PLEGEAKIHIP, string OFLNBGDFDAO, string CFMCONPHGKH, [Optional] string BLIPHCBHELD, [Optional] string LDJKEPILBBA, [Optional] string NKBAALIMNME, [Optional] string LBDMFOIIBMF, [Optional] string CPFMFPOPBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFE0", Offset = "0x8B97E0", VA = "0x1808BAFE0")]
		public void KHNDEDDHGEK(string BLIPHCBHELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
		public void HCKNDHECCLN(string CFMCONPHGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA90070", Offset = "0xA8E870", VA = "0x180A90070")]
		public void CCAENNAIKOE(string CPFMFPOPBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7510", Offset = "0x8B5D10", VA = "0x1808B7510")]
		public void NBGJFCJLBBJ(string AEFPOOIAFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x42EF530", Offset = "0x42EDD30", VA = "0x1842EF530")]
		public void HADAINJJHHM(Guid? JJNICACABPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x420AB60", Offset = "0x4209360", VA = "0x18420AB60")]
		public void IDEJBEKOHJN((int, int)? LJFNCPMDNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B7570", Offset = "0x8B5D70", VA = "0x1808B7570")]
		public void BJELNAECLBN(string AKGBDOKHMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x42F2070", Offset = "0x42F0870", VA = "0x1842F2070")]
		public void KOEAHEDNEHB(T OPHBLCIMHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x42F1BE0", Offset = "0x42F03E0", VA = "0x1842F1BE0")]
		public void KCJDFDDKEGJ(T OPHBLCIMHEC, int FGLAFNAIKAH, float IGEHIFGNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x42F23A0", Offset = "0x42F0BA0", VA = "0x1842F23A0")]
		public void LCELPPNIHFP(T OPHBLCIMHEC, int FGLAFNAIKAH, string FPIMOPIOHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x42F2A60", Offset = "0x42F1260", VA = "0x1842F2A60")]
		public void NFOCEFBBILO(T OPHBLCIMHEC, string DGBBFEEAFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x42F2C10", Offset = "0x42F1410", VA = "0x1842F2C10")]
		public void PAMOAPNKKKF(T OPHBLCIMHEC, string[] PBMMALAIMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x42F00D0", Offset = "0x42EE8D0", VA = "0x1842F00D0")]
		public MOPOHKAGKCI HJBMPCHFGBB(bool KHDIFEIJFDB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42F0C60", Offset = "0x42EF460", VA = "0x1842F0C60")]
		private (IEnumerable<T>, string) IAAANEMHGFP()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x42EF150", Offset = "0x42ED950", VA = "0x1842EF150")]
		public static OMFEPOCLDCL BNFGJGKPNNL(Guid JJNICACABPB, string PLEGEAKIHIP, T OPHBLCIMHEC, string OFLNBGDFDAO, string AOKHKFJIBNE, string BLIPHCBHELD, int? ECDOOAABOPD, [Optional] string JPPDEDFLLON, [Optional] string DGBBFEEAFNM, [Optional] int? AMPDOMJMIBP, [Optional] Guid? BPAOPGBNLGK, [Optional] string CPFMFPOPBJC, [Optional] string KNALOFPNFGF, [Optional] (int, int)? LJFNCPMDNLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x42F1FE0", Offset = "0x42F07E0", VA = "0x1842F1FE0")]
		[CompilerGenerated]
		private string KFLHNDHAGHN(T DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42EECB0", Offset = "0x42ED4B0", VA = "0x1842EECB0")]
		[CompilerGenerated]
		private string AKPNAJHOIBD(T DOBPKLNCBDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class KDBNHCODHAB<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected readonly string FBCFCCIBNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected readonly Guid HDCDMMLFMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected readonly long DCDLHONMOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int PGLBFLGIFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int OIPLKLAPEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected DateTime FLAJBOMNBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected bool OHOOPIBECCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Dictionary<long, NBCFADJFDCP> CGFENFLMFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		protected bool LLEFFCOJHLI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JFFJPJACBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x933530", Offset = "0x931D30", VA = "0x180933530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GJEPBOFBDIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAE86A0", Offset = "0xAE6EA0", VA = "0x180AE86A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4630750", Offset = "0x462EF50", VA = "0x184630750")]
		public KDBNHCODHAB(string FBCFCCIBNHM, Guid HDCDMMLFMME, long DCDLHONMOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void BBOFIPICJLM(TListSessionStartParams EDEDBJOODHH);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD19290", Offset = "0xD17A90", VA = "0x180D19290")]
		public void IIILJGLKCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PECKPILAMDF(bool IDAFPIDNCKC, TListSessionLogParams FMGCOJNHIAA);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4630440", Offset = "0x462EC40", VA = "0x184630440")]
		public void DLLHPJMOMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4630680", Offset = "0x462EE80", VA = "0x184630680")]
		public void PNCBOPDJIPB(long FGAKIHGJJAJ, int ECDOOAABOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4630490", Offset = "0x462EC90", VA = "0x184630490")]
		public void LLAGJIOCMGO(long FGAKIHGJJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract NBCFADJFDCP NABENJPGGOK(TItem DEDDGCENOOL, int ECDOOAABOPD, string AELPFAFKICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class NBCFADJFDCP : EPAKLJBLLCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int PGLBFLGIFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long FGAKIHGJJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long DCDLHONMOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly string EGNAFDJJMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly string CIMMLPCAPFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly int PBDMJNGOPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DateTime GCGPNGLKNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private double FGJHPBNLOIK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CJDBCNGJKNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA3C0A0", Offset = "0xA3A8A0", VA = "0x180A3C0A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B570", VA = "0x180A3CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x659E7F0", Offset = "0x659CFF0", VA = "0x18659E7F0")]
		public NBCFADJFDCP(long FGAKIHGJJAJ, int PGLBFLGIFBF, string KNALOFPNFGF, long DCDLHONMOIF, int PBDMJNGOPCG, [Optional] string OFLNBGDFDAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x659E170", Offset = "0x659C970", VA = "0x18659E170")]
		public void HEDPEDPLGJA(int PGLBFLGIFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x659E1E0", Offset = "0x659C9E0", VA = "0x18659E1E0")]
		public void IKPHIJMBKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x659E230", Offset = "0x659CA30", VA = "0x18659E230")]
		public void LHLIIDFLCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x659E100", Offset = "0x659C900", VA = "0x18659E100")]
		private void ENOEBEICOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x659E340", Offset = "0x659CB40", VA = "0x18659E340", Slot = "5")]
		public virtual OMFEPOCLDCL OFPKEANHELC(Guid JJNICACABPB, string HJGFDIPCBNA, [Optional] string KNALOFPNFGF, [Optional] long? OPHBLCIMHEC, [Optional] string OFLNBGDFDAO, [Optional] string BLIPHCBHELD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class KGOHGGGFHIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class JHBOCCDAGLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public JHBOCCDAGLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x659A0E0", Offset = "0x65988E0", VA = "0x18659A0E0")]
			internal bool JEKLDAECDDB()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct BNCMDBEBMLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private JHBOCCDAGLN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private bool <isForcedHeartbeatEvent>5__3;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6597B50", Offset = "0x6596350", VA = "0x186597B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6598D80", Offset = "0x6597580", VA = "0x186598D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly float OFLDNOKMECB;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, Dictionary<string, object>> DCMNACIJFAN;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static Dictionary<string, Dictionary<string, object>> POHAAMIFPEA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static string CPCIHCGJIJH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static CancellationTokenSource? AEEEFFAMEKF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static int OPCEJKPOFDJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static int PNAKIKOPFGO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static bool BDDCCCDEKGC;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly Dictionary<string, HBBGCKBPDHD> LJHLMKJKLFC;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly ANHAMBLCGDC<bool> EACANKMLGPM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static BLOHICJFBII? NODPKNNBCCM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string HGFADKGDNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x659BB40", Offset = "0x659A340", VA = "0x18659BB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x659BF40", Offset = "0x659A740", VA = "0x18659BF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? MIDFBKCNOMD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x659C2F0", Offset = "0x659AAF0", VA = "0x18659C2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x659CB90", Offset = "0x659B390", VA = "0x18659CB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? JFCBIDGPEGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x659BA80", Offset = "0x659A280", VA = "0x18659BA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x659A860", Offset = "0x6599060", VA = "0x18659A860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static MGBMPGMPPHD<bool> NKCFHPADFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x659CB40", Offset = "0x659B340", VA = "0x18659CB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool CMGGAHNGDCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x659CBF0", Offset = "0x659B3F0", VA = "0x18659CBF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x659B010", Offset = "0x6599810", VA = "0x18659B010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool BCGIBJKOAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x659BAF0", Offset = "0x659A2F0", VA = "0x18659BAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x659B070", Offset = "0x6599870", VA = "0x18659B070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float JFNEDLKCMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x659C000", Offset = "0x659A800", VA = "0x18659C000")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x659A180", Offset = "0x6598980", VA = "0x18659A180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x659B0D0", Offset = "0x65998D0", VA = "0x18659B0D0")]
		public static void EEGAJMJJHKO(string NHJMPEOKOAN, HBBGCKBPDHD LLNDKEPJNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x659A8C0", Offset = "0x65990C0", VA = "0x18659A8C0")]
		private static void BLHGFFNELHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x659B160", Offset = "0x6599960", VA = "0x18659B160")]
		internal static void EHFCOOMFLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x659C050", Offset = "0x659A850", VA = "0x18659C050")]
		internal static void KHANLFIJLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x659AF60", Offset = "0x6599760", VA = "0x18659AF60")]
		internal static void CKLAIOPDHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x659A1E0", Offset = "0x65989E0", VA = "0x18659A1E0")]
		public static Guid BBOFIPICJLM(string NHJMPEOKOAN, [Optional] string? LIOCFGBDHNE, [Optional] Dictionary<string, object>? FGLPMAOHFCL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x659A7C0", Offset = "0x6598FC0", VA = "0x18659A7C0")]
		public static Guid BBOFIPICJLM(string NHJMPEOKOAN, long LIOCFGBDHNE, [Optional] Dictionary<string, object>? FGLPMAOHFCL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x659BB90", Offset = "0x659A390", VA = "0x18659BB90")]
		public static void IIILJGLKCEC(string NHJMPEOKOAN, [Optional] Guid? PLMJELCKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x659B870", Offset = "0x659A070", VA = "0x18659B870")]
		public static void GJFINLMNGGK(string NHJMPEOKOAN, string AJIJJHNJDHC, object FEPKFAGJJMG, bool BDDCCCDEKGC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x659AD70", Offset = "0x6599570", VA = "0x18659AD70")]
		public static bool CIAHBMDAMHE(string NHJMPEOKOAN, [Optional] string? LIOCFGBDHNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x659BE00", Offset = "0x659A600", VA = "0x18659BE00")]
		private static void IKMPCOLJHGL(bool EMNBDBPGPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x659C360", Offset = "0x659AB60", VA = "0x18659C360")]
		internal static void MEDACIOOLGD(string IKGPEBFFMPK, string KCGKBDGKIOP, object EBNFOODJNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x659C4F0", Offset = "0x659ACF0", VA = "0x18659C4F0")]
		internal static void MEDACIOOLGD(string IKGPEBFFMPK, Dictionary<string, object> OGLLBJKFKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x659B360", Offset = "0x6599B60", VA = "0x18659B360")]
		private static void EMEMGILMDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x659C680", Offset = "0x659AE80", VA = "0x18659C680")]
		public static void MFEDOCGODBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x659AD10", Offset = "0x6599510", VA = "0x18659AD10")]
		public static void CCNCDMEFENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x659B4C0", Offset = "0x6599CC0", VA = "0x18659B4C0")]
		private static void GEENAIAPPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x659C210", Offset = "0x659AA10", VA = "0x18659C210")]
		private static void KKJELDJIFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x659B3E0", Offset = "0x6599BE0", VA = "0x18659B3E0")]
		[AsyncStateMachine(typeof(BNCMDBEBMLD))]
		private static Task FDNHJCJLKCH(CancellationToken ALKEMFHOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x659C6D0", Offset = "0x659AED0", VA = "0x18659C6D0")]
		private static void NLAOJGPEBKF(string NHJMPEOKOAN, Guid JJNICACABPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class OCCIBEENLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct BNJPCONNAGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool ANJHFABIGJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string DFNPEPOLIKL;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2138C20", Offset = "0x2137420", VA = "0x182138C20")]
			public BNJPCONNAGC(bool ANJHFABIGJN, string DFNPEPOLIKL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x659FE90", Offset = "0x659E690", VA = "0x18659FE90")]
		public static BNJPCONNAGC CLLGOIEIHDM(OMFEPOCLDCL PIHEOEPKNKG)
		{
			return default(BNJPCONNAGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x65A0270", Offset = "0x659EA70", VA = "0x1865A0270")]
		private static void INBOBHJDLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65A01B0", Offset = "0x659E9B0", VA = "0x1865A01B0")]
		private static void EADPEOAKFHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class NDNCGJNEOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x659FDB0", Offset = "0x659E5B0", VA = "0x18659FDB0")]
		public static OMFEPOCLDCL JHDIOOENLOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MFBGPGGIMND
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x659D0D0", Offset = "0x659B8D0", VA = "0x18659D0D0")]
		public static OMFEPOCLDCL FAONIAJIAGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x659D250", Offset = "0x659BA50", VA = "0x18659D250")]
		public static OMFEPOCLDCL IFKDFJAAGNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x659D1F0", Offset = "0x659B9F0", VA = "0x18659D1F0")]
		public static OMFEPOCLDCL HCEHMJBFIID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x659D430", Offset = "0x659BC30", VA = "0x18659D430")]
		public static OMFEPOCLDCL PPEGBDPHLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x659D070", Offset = "0x659B870", VA = "0x18659D070")]
		public static OMFEPOCLDCL CODFAIKNJPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x659D3D0", Offset = "0x659BBD0", VA = "0x18659D3D0")]
		public static OMFEPOCLDCL MFBBEPAHADO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x659CFB0", Offset = "0x659B7B0", VA = "0x18659CFB0")]
		public static OMFEPOCLDCL BGGGPMFCMNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x659D130", Offset = "0x659B930", VA = "0x18659D130")]
		public static OMFEPOCLDCL GDHMBFOCIJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x659D370", Offset = "0x659BB70", VA = "0x18659D370")]
		public static OMFEPOCLDCL KKFKDLJIHNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x659D010", Offset = "0x659B810", VA = "0x18659D010")]
		public static OMFEPOCLDCL CNKJNGLPCID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x659D310", Offset = "0x659BB10", VA = "0x18659D310")]
		public static OMFEPOCLDCL IOEJHGPMJLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x659D190", Offset = "0x659B990", VA = "0x18659D190")]
		public static OMFEPOCLDCL GNGJCJEKFHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x659CF50", Offset = "0x659B750", VA = "0x18659CF50")]
		public static OMFEPOCLDCL AOAPBIBBJAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x659D2B0", Offset = "0x659BAB0", VA = "0x18659D2B0")]
		public static OMFEPOCLDCL IFNLNCDAGKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ONDGMANKMJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65A04A0", Offset = "0x659ECA0", VA = "0x1865A04A0")]
		public static OMFEPOCLDCL APAAOAPCHKE(long NKDNOGOOODN, long ACPFGDPOKJK, bool FCLJHJIEBOI, string EIPIBMNIAAC, string NGOLKDFBOCG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MJDJKOPJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x659DF90", Offset = "0x659C790", VA = "0x18659DF90")]
		public static OMFEPOCLDCL LOIJFABCFPC(string AHPNDKBGDFP, string AIOHOIIAGKJ, bool JPMOEDLNBIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x659DD60", Offset = "0x659C560", VA = "0x18659DD60")]
		public static OMFEPOCLDCL HJPKLCIGGPO(string IKGPEBFFMPK, string DJAHFJKCKHL, string LMDNGEIKACH, [Optional] int? CCIKPPOBLDO, [Optional] double[] LDKMLHEDHJO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PINPBDDGCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65A10A0", Offset = "0x659F8A0", VA = "0x1865A10A0")]
		public static OMFEPOCLDCL JHNKLOPOIJO(string DIKIPAPPADM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x65A0DB0", Offset = "0x659F5B0", VA = "0x1865A0DB0")]
		public static OMFEPOCLDCL FDDCMLOINHB(string HHFIOCBKPLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x65A1180", Offset = "0x659F980", VA = "0x1865A1180")]
		public static OMFEPOCLDCL LCIFEBCNLMA(int OLKCJJDGMPH, string IKMKCMDHFDC, string DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x65A0D50", Offset = "0x659F550", VA = "0x1865A0D50")]
		public static OMFEPOCLDCL DBIIIADMHJP(int OLKCJJDGMPH, string IKMKCMDHFDC, string DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x65A0E90", Offset = "0x659F690", VA = "0x1865A0E90")]
		public static OMFEPOCLDCL FKLELGCJGHD(int OLKCJJDGMPH, string IKMKCMDHFDC, string DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x65A0EF0", Offset = "0x659F6F0", VA = "0x1865A0EF0")]
		public static OMFEPOCLDCL FPKMKBBAAMG(int OLKCJJDGMPH, string IKMKCMDHFDC, string DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x65A0F50", Offset = "0x659F750", VA = "0x1865A0F50")]
		public static OMFEPOCLDCL IMAOPBLGNMB(string IKMKCMDHFDC, string DOBPKLNCBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x65A1310", Offset = "0x659FB10", VA = "0x1865A1310")]
		private static OMFEPOCLDCL MIBGHOFEJGD(string FBCFCCIBNHM, int OLKCJJDGMPH, string PPHHPGEEFPJ, string CADOJKALEIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x65A11E0", Offset = "0x659F9E0", VA = "0x1865A11E0")]
		private static OMFEPOCLDCL MIBGHOFEJGD(string FBCFCCIBNHM, string PPHHPGEEFPJ, string CADOJKALEIK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly FICDJCDJOAA CLLGOIEIHDM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static KEKAPCFDNME IPNAMIAMHAP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CGNKJLNMKHO BBGAFBGNMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<OMFEPOCLDCL> JEHJIFMBOCH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long PMLNFGOGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65995F0", Offset = "0x6597DF0", VA = "0x1865995F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6599300", Offset = "0x6597B00", VA = "0x186599300")]
	[GOEJJNJJNIL.ABCDFDECKHK]
	internal static void DJHMGECEMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6599400", Offset = "0x6597C00", VA = "0x186599400")]
	private static void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65991D0", Offset = "0x65979D0", VA = "0x1865991D0")]
	public static OMFEPOCLDCL DFKMCKPIHMM(string KLIEFOPLHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6599250", Offset = "0x6597A50", VA = "0x186599250")]
	public static OMFEPOCLDCL DFKMCKPIHMM(string KLIEFOPLHLG, int OLKCJJDGMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65994D0", Offset = "0x6597CD0", VA = "0x1865994D0")]
	[GOEJJNJJNIL.ABCDFDECKHK]
	internal static void GOKAPDFOFHB()
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
