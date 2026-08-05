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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626A6D0", Offset = "0x62690D0", VA = "0x18626A6D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x626A3E0", Offset = "0x6268DE0", VA = "0x18626A3E0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x626DC90", Offset = "0x626C690", VA = "0x18626DC90", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IFDCMOPDBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> DOBPDKBMFNM();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ALJADPJMNBB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EPPLIGGDNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OOJBDEAHKGF BHLGFEOMEEA(Guid IECOMBJIOFN, string FLMHGGHEMNL, [Optional] string ALGOILEODHA, [Optional] long? JOANAPFBHAK, [Optional] string DOBEMKAJOKK, [Optional] string OBLLMLEJPKM);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MLCHAHOOOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x626A4C0", Offset = "0x6268EC0", VA = "0x18626A4C0")]
		public static OOJBDEAHKGF IHDGIOBMNHH(Guid IECOMBJIOFN, string FLMHGGHEMNL, string ALGOILEODHA, [Optional] long? JOANAPFBHAK, [Optional] string DOBEMKAJOKK, [Optional] string OBLLMLEJPKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class OOJBDEAHKGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected AKFMJHOJLMF BEAACGPFCBO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
		public OOJBDEAHKGF(AKFMJHOJLMF BEAACGPFCBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x626D7C0", Offset = "0x626C1C0", VA = "0x18626D7C0")]
		public OOJBDEAHKGF FIAHLFEBLAP(string GDCGGGDDADM, string IPHMAHBENGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33F29B0", Offset = "0x33F13B0", VA = "0x1833F29B0")]
		public OOJBDEAHKGF FIAHLFEBLAP<T>(string GDCGGGDDADM, T IPHMAHBENGI) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x33F2D40", Offset = "0x33F1740", VA = "0x1833F2D40")]
		public OOJBDEAHKGF PPHGKAMAPPF<T>(string GDCGGGDDADM, T? IPHMAHBENGI) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x626D860", Offset = "0x626C260", VA = "0x18626D860")]
		public OOJBDEAHKGF PPHGKAMAPPF(string GDCGGGDDADM, string IPHMAHBENGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x626D840", Offset = "0x626C240", VA = "0x18626D840")]
		public KGIOENCPIOK FPMPEGHJOBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21289E0", Offset = "0x21273E0", VA = "0x1821289E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AKFMJHOJLMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<AKFMJHOJLMF> GOOCANCLCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string HEAAMIHBNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> IJKDEDECMBE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6265290", Offset = "0x6263C90", VA = "0x186265290")]
		private AKFMJHOJLMF(string HEAAMIHBNJM, int DIIHKAJKDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6264F30", Offset = "0x6263930", VA = "0x186264F30")]
		public static OOJBDEAHKGF EMJKOLAJLFI(string HEAAMIHBNJM, int DIIHKAJKDLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6264FE0", Offset = "0x62639E0", VA = "0x186264FE0")]
		public KGIOENCPIOK FPMPEGHJOBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6265220", Offset = "0x6263C20", VA = "0x186265220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2ACA240", Offset = "0x2AC8C40", VA = "0x182ACA240")]
		internal void BNINIHAJAHD<T>(string GDCGGGDDADM, T IPHMAHBENGI) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6264ED0", Offset = "0x62638D0", VA = "0x186264ED0")]
		internal void BNINIHAJAHD(string GDCGGGDDADM, string IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x33E8930", Offset = "0x33E7330", VA = "0x1833E8930")]
		private void HGNAKMCCAKA<T>(string GDCGGGDDADM, T IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct DFJKFIJIFPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string LMAMGCCIIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? EPMGNKNAKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? ODEMFICJCJN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6265AF0", Offset = "0x62644F0", VA = "0x186265AF0")]
		public DFJKFIJIFPE(string MOMBLECNGNL, [Optional] long? MOEKPKHCJHD, [Optional] short? FGIADPADFDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct MHODAPHNLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int EHLNIICJLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string HOPKOABCLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short OBGDFDCIENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JBDPHPHDKEL;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x626A470", Offset = "0x6268E70", VA = "0x18626A470")]
		public MHODAPHNLCK(int OFKKBLGHIMA, string NELOHIFBPKI, short BOBFHJMCGPD, string FNIMPGFFGJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GIPODMPOILP : LIIPLDJHLIF<GGPLGKKECDI, MHODAPHNLCK, DFJKFIJIFPE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string NELOHIFBPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short BOBFHJMCGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string FNIMPGFFGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> PAPDOAPCPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int JPPPNMPPCBC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6267F50", Offset = "0x6266950", VA = "0x186267F50")]
		public GIPODMPOILP(string GAAMAPOEHNE, Guid IHDDBMOLAKM, long GGLGKJIKCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6266BD0", Offset = "0x62655D0", VA = "0x186266BD0", Slot = "4")]
		public override void DECGPEMLDPJ(MHODAPHNLCK DOGPPEGMPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6266AF0", Offset = "0x62654F0", VA = "0x186266AF0")]
		public void BBJECPAAEPF(short BOBFHJMCGPD, bool MGJCABLJFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DB6AF0", Offset = "0x3DB54F0", VA = "0x183DB6AF0")]
		public void FPOFILFIOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88B280", Offset = "0x889C80", VA = "0x18088B280")]
		public void HAKADCEEEKF(string AHDAABNFIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6266EC0", Offset = "0x62658C0", VA = "0x186266EC0", Slot = "5")]
		public override void FIODIKODBLP(bool FFPHMDFHCIE, DFJKFIJIFPE BCIEDEJAHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6267CA0", Offset = "0x62666A0", VA = "0x186267CA0", Slot = "6")]
		public override IBOOBNADFBG KODLKFHFKJD(GGPLGKKECDI FPGKNNGOMJB, int ENMILGHAHOM, string MHCPAPBOMNJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IKHEGIEJNKK : IBOOBNADFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string NELOHIFBPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short BOBFHJMCGPD;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x626A290", Offset = "0x6268C90", VA = "0x18626A290")]
		public IKHEGIEJNKK(long MCGOHIJBLDK, int OFKKBLGHIMA, string ALGOILEODHA, long GGLGKJIKCHI, int PDMBJNDOFFI, string DOBEMKAJOKK, short BOBFHJMCGPD, string NELOHIFBPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x626A210", Offset = "0x6268C10", VA = "0x18626A210")]
		public void NHEDPDNHBDK(int OFKKBLGHIMA, string NELOHIFBPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x626A0E0", Offset = "0x6268AE0", VA = "0x18626A0E0", Slot = "5")]
		public override OOJBDEAHKGF BHLGFEOMEEA(Guid IECOMBJIOFN, string FLMHGGHEMNL, [Optional] string ALGOILEODHA, [Optional] long? JOANAPFBHAK, [Optional] string DOBEMKAJOKK, [Optional] string OBLLMLEJPKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AIMNPKHOMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6264E60", Offset = "0x6263860", VA = "0x186264E60")]
		public static void NKDMEGGPJPH(string COMNIKKFEEB, object DNDFJEOMBPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class AFONDJOBDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct CLBNMBJIBCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int DPOMIEFPPMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int BKACGOJFGNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int FLFHAMJNIII;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int OJDIJCKHONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int IFJDCEJNBCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int EOJMLMCLPPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int ONFEEIPDCEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int FDMKPMBKLEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int DKHLLMGEPEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int IGPDICDOHAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int MOHNNBOGIOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int BENJMBNIHGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int HFLLGBADHMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int BIHLOBPPKPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int EJOKBNAGHMB;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6265A80", Offset = "0x6264480", VA = "0x186265A80")]
			public CLBNMBJIBCM(int FGKEENOFEIG, int LAKOIKCBJMD, int EEPDJDLLLJN, int PFDHCFHPKFN, int DHDIGGNKBPE, int NCCODLPHIJC, int FDMEONBJBON, int FFGEMAIAILN, int BPMADPDLOAJ, int AHLENCFHDHK, int JLNIEIAEFPF, int NDPJOCIBGBH, int PIMAOKLPGBL, int MEKIHBAOABB, int EFJLAEDJJPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? MJMFIIFDBIB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> DDNNLDDBJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6264DB0", Offset = "0x62637B0", VA = "0x186264DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62645C0", Offset = "0x6262FC0", VA = "0x1862645C0")]
		public static void JBLMGCIMOMF(CLBNMBJIBCM MAPCJHGDDBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class EAEHNJJPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6266230", Offset = "0x6264C30", VA = "0x186266230")]
		public static void NKDMEGGPJPH(string COMNIKKFEEB, object DNDFJEOMBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6266000", Offset = "0x6264A00", VA = "0x186266000")]
		public static void NKDMEGGPJPH(string COMNIKKFEEB, GALLAFJFDIM DNDFJEOMBPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class EPPJCLKKNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6266460", Offset = "0x6264E60", VA = "0x186266460")]
		public static void OCFCALHPLMH(float3 EJEBFMEPKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6266340", Offset = "0x6264D40", VA = "0x186266340")]
		public static void JLBKAIIOMOF(bool JPIOGMJJIBL, bool LMOKMAPOGPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62662A0", Offset = "0x6264CA0", VA = "0x1862662A0")]
		public static void GPGJJDOHCIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AFEDJJKPOEO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KOLENBMFAHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AFEDJJKPOEO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public KOLENBMFAHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x43EB9A0", Offset = "0x43EA3A0", VA = "0x1843EB9A0")]
			internal object HMIKPEBHDIF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FGNOCPABDPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public AFEDJJKPOEO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public FGNOCPABDPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4AB0", Offset = "0x3DF34B0", VA = "0x183DF4AB0")]
			internal object EIALEIOFBFN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DPPCKJAJKDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AFEDJJKPOEO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public DPPCKJAJKDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5AAA510", Offset = "0x5AA8F10", VA = "0x185AAA510")]
			internal object BBODBALCNDF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JJOJDNODMCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public AFEDJJKPOEO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public JJOJDNODMCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x42FB7C0", Offset = "0x42FA1C0", VA = "0x1842FB7C0")]
			internal object EDLMOGKKPHB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float MHIMANOCMMK = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid IECOMBJIOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string DOBEMKAJOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string IEAGOODAOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string NMLLCLLGAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string OBLLMLEJPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string IPHNLAMBBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string APPPAHDEBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string AAFOEGOLFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string HPEPADHBNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string EFLHMLHNFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? FJGNCAMCOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? JKMHNLEBJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> KNCJLIBAAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> LELOEEGGAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> GKOPBHNENNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> DAPFOHBPFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string MCJJCILNJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool POMBMMJMJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private KGIOENCPIOK ALFJPKPCILG;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E94BA0", Offset = "0x3E935A0", VA = "0x183E94BA0")]
		public AFEDJJKPOEO(Guid IECOMBJIOFN, string IEAGOODAOKB, string DOBEMKAJOKK, string NMLLCLLGAFC, [Optional] string OBLLMLEJPKM, [Optional] string IPHNLAMBBBM, [Optional] string APPPAHDEBPG, [Optional] string EFLHMLHNFOK, [Optional] string MCJJCILNJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
		public void KEPOJDAOHNA(string OBLLMLEJPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
		public void BPAHELNDDFB(string NMLLCLLGAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88EBD0", Offset = "0x88D5D0", VA = "0x18088EBD0")]
		public void KICDMNPIHPE(string MCJJCILNJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88B2A0", Offset = "0x889CA0", VA = "0x18088B2A0")]
		public void FJKJAEHANCP(string AAFOEGOLFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3E946E0", Offset = "0x3E930E0", VA = "0x183E946E0")]
		public void LLIDONGDAIB(Guid? IECOMBJIOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3E908D0", Offset = "0x3E8F2D0", VA = "0x183E908D0")]
		public void CDBFNFDOKNH((int, int)? JKMHNLEBJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88B2D0", Offset = "0x889CD0", VA = "0x18088B2D0")]
		public void DHLCICCGJFB(string HPEPADHBNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E946F0", Offset = "0x3E930F0", VA = "0x183E946F0")]
		public void PHBABNDJCON(T JOANAPFBHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E935A0", Offset = "0x3E91FA0", VA = "0x183E935A0")]
		public void GHDHKMDLDGO(T JOANAPFBHAK, int FPNOEEJKAEC, float GLIHGPEPPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E94430", Offset = "0x3E92E30", VA = "0x183E94430")]
		public void KMOBKFIFJHF(T JOANAPFBHAK, int FPNOEEJKAEC, string FLMIHLPICJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E90570", Offset = "0x3E8EF70", VA = "0x183E90570")]
		public void BKCIKIFHNBJ(T JOANAPFBHAK, string FCMPDKMMHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E91EF0", Offset = "0x3E908F0", VA = "0x183E91EF0")]
		public KGIOENCPIOK FPMPEGHJOBC(bool LCIPAAAOEPD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F160", Offset = "0x3E8DB60", VA = "0x183E8F160")]
		private (IEnumerable<T>, string) BJMDNAPBAMI()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E91090", Offset = "0x3E8FA90", VA = "0x183E91090")]
		public static OOJBDEAHKGF DIIJCNMIKDL(Guid IECOMBJIOFN, string IEAGOODAOKB, T JOANAPFBHAK, string DOBEMKAJOKK, string JMDPGKBNGAC, string OBLLMLEJPKM, int? ENMILGHAHOM, [Optional] string BAOBMENAFGC, [Optional] string FCMPDKMMHMI, [Optional] int? JGLMJAANFIH, [Optional] Guid? FJGNCAMCOPM, [Optional] string MCJJCILNJEL, [Optional] string ALGOILEODHA, [Optional] (int, int)? JKMHNLEBJMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E933F0", Offset = "0x3E91DF0", VA = "0x183E933F0")]
		[CompilerGenerated]
		private string GDCCGADCIPD(T DNICIAANFHD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class LIIPLDJHLIF<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string GAAMAPOEHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid IHDDBMOLAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long GGLGKJIKCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int OFKKBLGHIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int KFKKDODKHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime EIKOKHBPJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool GCBAKLFCAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, IBOOBNADFBG> FOMEKCNGGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool PCDOPIOPCMF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IIKOPGKOKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9084C0", Offset = "0x906EC0", VA = "0x1809084C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PJCCGLPIMKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x98B5F0", Offset = "0x989FF0", VA = "0x18098B5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4497F40", Offset = "0x4496940", VA = "0x184497F40")]
		public LIIPLDJHLIF(string GAAMAPOEHNE, Guid IHDDBMOLAKM, long GGLGKJIKCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DECGPEMLDPJ(TListSessionStartParams DOGPPEGMPDG);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBA8720", Offset = "0xBA7120", VA = "0x180BA8720")]
		public void HHMMCFABNLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FIODIKODBLP(bool FFPHMDFHCIE, TListSessionLogParams BCIEDEJAHFG);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4497C30", Offset = "0x4496630", VA = "0x184497C30")]
		public void BFJJGJPHJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4497E70", Offset = "0x4496870", VA = "0x184497E70")]
		public void IOAGDDCPGCE(long MCGOHIJBLDK, int ENMILGHAHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4497C80", Offset = "0x4496680", VA = "0x184497C80")]
		public void FCLHHHCOGCH(long MCGOHIJBLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract IBOOBNADFBG KODLKFHFKJD(TItem LHFGBAJKEKO, int ENMILGHAHOM, string MHCPAPBOMNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class IBOOBNADFBG : EPPLIGGDNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int OFKKBLGHIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long MCGOHIJBLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long GGLGKJIKCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string ILAPLAGLKLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string CJCDLAHPLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int PDMBJNDOFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime CFDNANAFBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double MMCLKBJBCOD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GKOFDAEPIMK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x916740", Offset = "0x915140", VA = "0x180916740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x916D50", Offset = "0x915750", VA = "0x180916D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x626A010", Offset = "0x6268A10", VA = "0x18626A010")]
		public IBOOBNADFBG(long MCGOHIJBLDK, int OFKKBLGHIMA, string ALGOILEODHA, long GGLGKJIKCHI, int PDMBJNDOFFI, [Optional] string DOBEMKAJOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6269F40", Offset = "0x6268940", VA = "0x186269F40")]
		public void GNAFJKBFOLO(int OFKKBLGHIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6269EF0", Offset = "0x62688F0", VA = "0x186269EF0")]
		public void GCPDAFMGDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6269DE0", Offset = "0x62687E0", VA = "0x186269DE0")]
		public void COKGACPEEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6269FB0", Offset = "0x62689B0", VA = "0x186269FB0")]
		private void JLDCLFCLOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6269930", Offset = "0x6268330", VA = "0x186269930", Slot = "5")]
		public virtual OOJBDEAHKGF BHLGFEOMEEA(Guid IECOMBJIOFN, string FLMHGGHEMNL, [Optional] string ALGOILEODHA, [Optional] long? JOANAPFBHAK, [Optional] string DOBEMKAJOKK, [Optional] string OBLLMLEJPKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class OOGCGNEFDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OPFEAKEKDDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public OPFEAKEKDDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x626D8F0", Offset = "0x626C2F0", VA = "0x18626D8F0")]
			internal bool DKDBAGPDNFE()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct HACIEKDAECF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private OPFEAKEKDDI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private bool <isForcedHeartbeatEvent>5__3;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x62686D0", Offset = "0x62670D0", VA = "0x1862686D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x62698D0", Offset = "0x62682D0", VA = "0x1862698D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float CHPELFLBNOB;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> JCIOCDKFKGO;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> NBDJJOMKGJF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string NCBGNMAKNAE;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? CFGBIKHKGCH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int PNMPPCIAHNE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int HKLCEMNBMEH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool FIGIODKIPAK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, IFDCMOPDBFA> OCBLLNOMBFP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly ANPPHEALLCN<bool> APIMBOIPPAB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static OKLMGPLPKNE? GEIHIJIEJKK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string MJBPEEFNHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x626C060", Offset = "0x626AA60", VA = "0x18626C060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x626B9F0", Offset = "0x626A3F0", VA = "0x18626B9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? ABEPNDGCMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x626D4C0", Offset = "0x626BEC0", VA = "0x18626D4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x626D140", Offset = "0x626BB40", VA = "0x18626D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? KKLKPJGMOBN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x626D460", Offset = "0x626BE60", VA = "0x18626D460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x626CE00", Offset = "0x626B800", VA = "0x18626CE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static GJCAFMIGDML<bool> AHHIEEMOFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x626BAA0", Offset = "0x626A4A0", VA = "0x18626BAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool BIDIKDJJOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x626BF50", Offset = "0x626A950", VA = "0x18626BF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x626BFA0", Offset = "0x626A9A0", VA = "0x18626BFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool MEOLPIIFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x626D1A0", Offset = "0x626BBA0", VA = "0x18626D1A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x626ABD0", Offset = "0x62695D0", VA = "0x18626ABD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float CDDHABBDNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x626D520", Offset = "0x626BF20", VA = "0x18626D520")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x626C000", Offset = "0x626AA00", VA = "0x18626C000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x626B960", Offset = "0x626A360", VA = "0x18626B960")]
		public static void DHPPIHCLJKB(string FCKAHGAEGBJ, IFDCMOPDBFA BLOFEIAOHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x626ACD0", Offset = "0x62696D0", VA = "0x18626ACD0")]
		private static void CIJIONDGLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x626C680", Offset = "0x626B080", VA = "0x18626C680")]
		internal static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x626CC50", Offset = "0x626B650", VA = "0x18626CC50")]
		internal static void IKHFGDALBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x626AC30", Offset = "0x6269630", VA = "0x18626AC30")]
		internal static void BKKBFMJJMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x626B390", Offset = "0x6269D90", VA = "0x18626B390")]
		public static Guid DECGPEMLDPJ(string FCKAHGAEGBJ, [Optional] string? DMDECLKHEPB, [Optional] Dictionary<string, object>? AJNOAPHKOMK)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x626B2F0", Offset = "0x6269CF0", VA = "0x18626B2F0")]
		public static Guid DECGPEMLDPJ(string FCKAHGAEGBJ, long DMDECLKHEPB, [Optional] Dictionary<string, object>? AJNOAPHKOMK)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x626C420", Offset = "0x626AE20", VA = "0x18626C420")]
		public static void HHMMCFABNLM(string FCKAHGAEGBJ, [Optional] Guid? OKMPNEEAGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x626CE60", Offset = "0x626B860", VA = "0x18626CE60")]
		public static void JCEOPLCAJLB(string FCKAHGAEGBJ, string NKAJHAOLIDH, object MHFLDJAFDNK, bool FIGIODKIPAK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x626B100", Offset = "0x6269B00", VA = "0x18626B100")]
		public static bool COKNBIOJCOA(string FCKAHGAEGBJ, [Optional] string? DMDECLKHEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x626D1F0", Offset = "0x626BBF0", VA = "0x18626D1F0")]
		private static void OAMBMMEKHAP(bool GMEJBCLINCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x626C0B0", Offset = "0x626AAB0", VA = "0x18626C0B0")]
		internal static void HDBPDDPBKKL(string MPOBGCPIOEI, string COMNIKKFEEB, object LNCKNHNHHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x626C230", Offset = "0x626AC30", VA = "0x18626C230")]
		internal static void HDBPDDPBKKL(string MPOBGCPIOEI, Dictionary<string, object> BBBCJIECHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x626C3B0", Offset = "0x626ADB0", VA = "0x18626C3B0")]
		private static void HFDKAMGPKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x626CC00", Offset = "0x626B600", VA = "0x18626CC00")]
		public static void IGIINPJODPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x626D330", Offset = "0x626BD30", VA = "0x18626D330")]
		public static void OCJPOLEBGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x626C860", Offset = "0x626B260", VA = "0x18626C860")]
		private static void IBJEADILJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x626D070", Offset = "0x626BA70", VA = "0x18626D070")]
		private static void JCHNEBBCOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x626D380", Offset = "0x626BD80", VA = "0x18626D380")]
		[AsyncStateMachine(typeof(HACIEKDAECF))]
		private static Task OIIHGPHLCEM(CancellationToken LOIOCMLGMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x626BAF0", Offset = "0x626A4F0", VA = "0x18626BAF0")]
		private static void EHNLHDHDLKL(string FCKAHGAEGBJ, Guid IECOMBJIOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class DOHJJMOEOMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct FAAJFMKDDNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool FAJBCEPOPIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string HJEKPEEDGCE;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1E3AE60", Offset = "0x1E39860", VA = "0x181E3AE60")]
			public FAAJFMKDDNL(bool FAJBCEPOPIC, string HJEKPEEDGCE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6265B30", Offset = "0x6264530", VA = "0x186265B30")]
		public static FAAJFMKDDNL LHPAJEFICIG(OOJBDEAHKGF BICNIEPDLNN)
		{
			return default(FAAJFMKDDNL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6265E40", Offset = "0x6264840", VA = "0x186265E40")]
		private static void LLCKIDGMLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6265F40", Offset = "0x6264940", VA = "0x186265F40")]
		private static void NHGFFJKJDNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KDFHLCNAJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x626A380", Offset = "0x6268D80", VA = "0x18626A380")]
		public static OOJBDEAHKGF MDAACJIHCJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OJDNLMGDKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x626A750", Offset = "0x6269150", VA = "0x18626A750")]
		public static OOJBDEAHKGF AJLGDFLGGFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x626AA50", Offset = "0x6269450", VA = "0x18626AA50")]
		public static OOJBDEAHKGF JPHPFCJNBDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x626A9F0", Offset = "0x62693F0", VA = "0x18626A9F0")]
		public static OOJBDEAHKGF HPGPNHJBGDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x626AAB0", Offset = "0x62694B0", VA = "0x18626AAB0")]
		public static OOJBDEAHKGF NNKCGAJJJOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x626A870", Offset = "0x6269270", VA = "0x18626A870")]
		public static OOJBDEAHKGF EONFGEMDPIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x626AB70", Offset = "0x6269570", VA = "0x18626AB70")]
		public static OOJBDEAHKGF PJGMIMKFJMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x626A8D0", Offset = "0x62692D0", VA = "0x18626A8D0")]
		public static OOJBDEAHKGF FJDBMILFHJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x626A7B0", Offset = "0x62691B0", VA = "0x18626A7B0")]
		public static OOJBDEAHKGF DELNFFKOMAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x626A810", Offset = "0x6269210", VA = "0x18626A810")]
		public static OOJBDEAHKGF DODGPLMEAFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x626AB10", Offset = "0x6269510", VA = "0x18626AB10")]
		public static OOJBDEAHKGF PGIIMMPNGBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x626A930", Offset = "0x6269330", VA = "0x18626A930")]
		public static OOJBDEAHKGF GGLJALJMPBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x626A990", Offset = "0x6269390", VA = "0x18626A990")]
		public static OOJBDEAHKGF HAOKEIPMEMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class GDPAKEBKDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6266570", Offset = "0x6264F70", VA = "0x186266570")]
		public static OOJBDEAHKGF IEPFAPGBBNH(long MOEKPKHCJHD, long NMDIIDEMCDI, bool NBKDIIPLEDP, string PIJCKKIACOJ, string BPMPACAKNON)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class GIPKBPPNDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6266750", Offset = "0x6265150", VA = "0x186266750")]
		public static OOJBDEAHKGF FKCEKFFMLLC(string MIHONMEKCCN, string NGPAANGJAGE, bool JIHFBAMFGCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62668C0", Offset = "0x62652C0", VA = "0x1862668C0")]
		public static OOJBDEAHKGF JBIKFEAPBJO(string MPOBGCPIOEI, string KMMEPNMEPBA, string INMBFBIMABJ, [Optional] int? PHKLGHJEMJN, [Optional] double[] KDMAFMCPFDN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GKFGEAMJJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6268030", Offset = "0x6266A30", VA = "0x186268030")]
		public static OOJBDEAHKGF DMMPALLMKDC(string LMDJPEEDMPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6268380", Offset = "0x6266D80", VA = "0x186268380")]
		public static OOJBDEAHKGF HBBEEIKAPMC(string JBANDJAEMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6268610", Offset = "0x6267010", VA = "0x186268610")]
		public static OOJBDEAHKGF MJKKILNONIG(int DIIHKAJKDLA, string DDDMPLCOGIM, string DNICIAANFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62685B0", Offset = "0x6266FB0", VA = "0x1862685B0")]
		public static OOJBDEAHKGF IEBFKGNGLKD(int DIIHKAJKDLA, string DDDMPLCOGIM, string DNICIAANFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6267FD0", Offset = "0x62669D0", VA = "0x186267FD0")]
		public static OOJBDEAHKGF DKMHDNNNFJN(int DIIHKAJKDLA, string DDDMPLCOGIM, string DNICIAANFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6268670", Offset = "0x6267070", VA = "0x186268670")]
		public static OOJBDEAHKGF POHKOOFBGCK(int DIIHKAJKDLA, string DDDMPLCOGIM, string DNICIAANFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6268460", Offset = "0x6266E60", VA = "0x186268460")]
		public static OOJBDEAHKGF HFBBACAMGDD(string DDDMPLCOGIM, string DNICIAANFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6268110", Offset = "0x6266B10", VA = "0x186268110")]
		private static OOJBDEAHKGF FNKEDNJHBDN(string GAAMAPOEHNE, int DIIHKAJKDLA, string KGDEDIKLENG, string FHBFOPIEHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6268250", Offset = "0x6266C50", VA = "0x186268250")]
		private static OOJBDEAHKGF FNKEDNJHBDN(string GAAMAPOEHNE, string KGDEDIKLENG, string FHBFOPIEHJE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly CAFGMNLACIN LHPAJEFICIG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static HCHOLPPMCGJ LCJMPNBCLNG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static BJEOLIMHBMI CHLNKAGGPME;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<OOJBDEAHKGF> EMEJPKPBDNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long CBOBLCEJICH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62658A0", Offset = "0x62642A0", VA = "0x1862658A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6265690", Offset = "0x6264090", VA = "0x186265690")]
	[MDEOHLLDIMG.HGKMINFPIJL]
	internal static void IBEACPBBPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62655D0", Offset = "0x6263FD0", VA = "0x1862655D0")]
	private static void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6265990", Offset = "0x6264390", VA = "0x186265990")]
	public static OOJBDEAHKGF NPKBBOCOKIO(string HEAAMIHBNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6264F30", Offset = "0x6263930", VA = "0x186264F30")]
	public static OOJBDEAHKGF NPKBBOCOKIO(string HEAAMIHBNJM, int DIIHKAJKDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6265780", Offset = "0x6264180", VA = "0x186265780")]
	[MDEOHLLDIMG.HGKMINFPIJL]
	internal static void KBJJNOGBELM()
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
