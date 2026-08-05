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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6281CD0", Offset = "0x62806D0", VA = "0x186281CD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
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
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62816F0", Offset = "0x62800F0", VA = "0x1862816F0", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6283240", Offset = "0x6281C40", VA = "0x186283240", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DKNNCDPGKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> KBNHEGKMJGG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NEAOLNIDDJB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CAJPLMNKCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KCHEAGPJFNB HENHINDNPGI(Guid HEJPJBAPELP, string INDPCJJDBOK, [Optional] string EDGPHDPDGLB, [Optional] long? IKEMLBNLNCL, [Optional] string LKBAKGNBOEH, [Optional] string FKEGECNPCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OAICGONCBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6281D50", Offset = "0x6280750", VA = "0x186281D50")]
		public static KCHEAGPJFNB EBIOGBJCOJH(Guid HEJPJBAPELP, string INDPCJJDBOK, string EDGPHDPDGLB, [Optional] long? IKEMLBNLNCL, [Optional] string LKBAKGNBOEH, [Optional] string FKEGECNPCMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class KCHEAGPJFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected ENOGIFODECA NIMOEMOGMIA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		public KCHEAGPJFNB(ENOGIFODECA NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62810F0", Offset = "0x627FAF0", VA = "0x1862810F0")]
		public KCHEAGPJFNB IIGBAGNCBDB(string FMKCBFNEFEH, string CLMKDBDPNNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x332B250", Offset = "0x3329C50", VA = "0x18332B250")]
		public KCHEAGPJFNB IIGBAGNCBDB<T>(string FMKCBFNEFEH, T CLMKDBDPNNH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x332B5E0", Offset = "0x3329FE0", VA = "0x18332B5E0")]
		public KCHEAGPJFNB KOADGPINPPI<T>(string FMKCBFNEFEH, T? CLMKDBDPNNH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6281170", Offset = "0x627FB70", VA = "0x186281170")]
		public KCHEAGPJFNB KOADGPINPPI(string FMKCBFNEFEH, string CLMKDBDPNNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62810D0", Offset = "0x627FAD0", VA = "0x1862810D0")]
		public MFAPHLCBHHA CINKPDPAHFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2099100", Offset = "0x2097B00", VA = "0x182099100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ENOGIFODECA
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<ENOGIFODECA> JIAPGJBPOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string CPNMNFEEDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> BADGDOAJEDA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x627C070", Offset = "0x627AA70", VA = "0x18627C070")]
		private ENOGIFODECA(string CPNMNFEEDIG, int JECGBBECKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x627BEF0", Offset = "0x627A8F0", VA = "0x18627BEF0")]
		public static KCHEAGPJFNB IFAFEFDLIPC(string CPNMNFEEDIG, int JECGBBECKDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x627BCB0", Offset = "0x627A6B0", VA = "0x18627BCB0")]
		public MFAPHLCBHHA CINKPDPAHFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x627C000", Offset = "0x627AA00", VA = "0x18627C000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A106F0", Offset = "0x2A0F0F0", VA = "0x182A106F0")]
		internal void PIFJIIIFKFG<T>(string FMKCBFNEFEH, T CLMKDBDPNNH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x627BFA0", Offset = "0x627A9A0", VA = "0x18627BFA0")]
		internal void PIFJIIIFKFG(string FMKCBFNEFEH, string CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x332A070", Offset = "0x3328A70", VA = "0x18332A070")]
		private void JLMKPPJIMHM<T>(string FMKCBFNEFEH, T CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FPEHKPDIANN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string BBPBAMKGBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? GOHJNFCMHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? EFIFENGFMIE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x627C3B0", Offset = "0x627ADB0", VA = "0x18627C3B0")]
		public FPEHKPDIANN(string NMNBAMGKJPB, [Optional] long? NDAIANNJONA, [Optional] short? DAGEMANMCDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PDDFLIALKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int OEPBPALFCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string EJJACAJFIAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short HDPAIPMFENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string BHNOJNHNMFC;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62827F0", Offset = "0x62811F0", VA = "0x1862827F0")]
		public PDDFLIALKEI(int LGGIOCLKLDM, string BBDBENBIGCA, short KOJOHMKJKHP, string GKGANEJLLJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AOPEOFCOJCC : LINJDHHPJCM<MNHNMPBBKJO, PDDFLIALKEI, FPEHKPDIANN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string BBDBENBIGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short KOJOHMKJKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string GKGANEJLLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> LEGKDCPGGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MABLOAJCFGG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x627B4E0", Offset = "0x6279EE0", VA = "0x18627B4E0")]
		public AOPEOFCOJCC(string EIKPMHBAPNA, Guid FPEOAKIHAMA, long OJALFDDIFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x627A060", Offset = "0x6278A60", VA = "0x18627A060", Slot = "4")]
		public override void ENGIOACJJFG(PDDFLIALKEI PLAGHHCFBPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x627B400", Offset = "0x6279E00", VA = "0x18627B400")]
		public void OOPOLIABOIG(short KOJOHMKJKHP, bool KCMLEFOPAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D12D30", Offset = "0x3D11730", VA = "0x183D12D30")]
		public void IDGPLANEOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x886010", Offset = "0x884A10", VA = "0x180886010")]
		public void FMHINKHENJN(string OBFLCBBPEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x627A600", Offset = "0x6279000", VA = "0x18627A600", Slot = "5")]
		public override void NKFAFPNOINP(bool AICFHBGHMME, FPEHKPDIANN DLLDCCFNJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x627A350", Offset = "0x6278D50", VA = "0x18627A350", Slot = "6")]
		public override HEHENCNGKFM IHPFENPLHHM(MNHNMPBBKJO MNBGEOINCEI, int EBDDHAPIAHH, string LCPNEJHOLNH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KHNMLOLEJGJ : HEHENCNGKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string BBDBENBIGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short KOJOHMKJKHP;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6281600", Offset = "0x6280000", VA = "0x186281600")]
		public KHNMLOLEJGJ(long KLIDJGNPIFF, int LGGIOCLKLDM, string EDGPHDPDGLB, long OJALFDDIFCK, int GJCBFLODBGG, string LKBAKGNBOEH, short KOJOHMKJKHP, string BBDBENBIGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6281450", Offset = "0x627FE50", VA = "0x186281450")]
		public void ADBCGGIGIMJ(int LGGIOCLKLDM, string BBDBENBIGCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62814D0", Offset = "0x627FED0", VA = "0x1862814D0", Slot = "5")]
		public override KCHEAGPJFNB HENHINDNPGI(Guid HEJPJBAPELP, string INDPCJJDBOK, [Optional] string EDGPHDPDGLB, [Optional] long? IKEMLBNLNCL, [Optional] string LKBAKGNBOEH, [Optional] string FKEGECNPCMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IHBMMOHFAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x627FB30", Offset = "0x627E530", VA = "0x18627FB30")]
		public static void IMHNMNJCFHB(string JODEIIFHAPK, object DAHKFPOLCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class OFBNLDPPEMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct KHJNFLGNPFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int NGFBMFFNNAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int PCJJKLMLPMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int KDLCCFAPNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int CKKLGJNEJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int JMPJFBGDDPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int GDINEICKCFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int ALNICKBHOBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int MABDKIFDNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int CKKFIOHODBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int BHEGHLPHKKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int FKEHDDAFGLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int BPCAIBAAPFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int ONFPPDNEKMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int GMEEHKDDLLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int IDIOKEAKKJA;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x62813E0", Offset = "0x627FDE0", VA = "0x1862813E0")]
			public KHJNFLGNPFF(int OIBNBMCHPPC, int OLLFMIFPDHH, int EINDKNAAPEN, int EHICAMOFPPC, int GMPIKJLAANK, int EPMCJPADAEH, int IKHKABIKDDN, int MBFEDHKKAIC, int EIBEOFGHADG, int NNAHHCDAKAG, int GOICPEKCKAI, int NIOBGDGEKPA, int HHMLEDJEECL, int OFHGNEPHJJF, int PABJHBPHNOJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? LLILCJFHIEE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> HLELKEBJDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6281F60", Offset = "0x6280960", VA = "0x186281F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6282010", Offset = "0x6280A10", VA = "0x186282010")]
		public static void LDLCNCOOAFC(KHJNFLGNPFF BIGCGCBADBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class IOEBDGMNFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x627FBA0", Offset = "0x627E5A0", VA = "0x18627FBA0")]
		public static void IMHNMNJCFHB(string JODEIIFHAPK, object DAHKFPOLCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x627FC10", Offset = "0x627E610", VA = "0x18627FC10")]
		public static void IMHNMNJCFHB(string JODEIIFHAPK, KIBKCNNAKFH DAHKFPOLCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DBNNICLHOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x627B560", Offset = "0x6279F60", VA = "0x18627B560")]
		public static void ALDBJJKOCLE(float3 BJDHDJCINFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x627B710", Offset = "0x627A110", VA = "0x18627B710")]
		public static void CLPGDNPGLKK(bool KFDBHMHLCLG, bool AHIAGJPFKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x627B670", Offset = "0x627A070", VA = "0x18627B670")]
		public static void CDIOHFGPPLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class HGHKGLEBJDJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class INFCEPCCOGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public HGHKGLEBJDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public INFCEPCCOGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x402BD00", Offset = "0x402A700", VA = "0x18402BD00")]
			internal object JFJMCKGEBCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NAAIIOPNCCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public HGHKGLEBJDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public NAAIIOPNCCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x468F9D0", Offset = "0x468E3D0", VA = "0x18468F9D0")]
			internal object CLHCCMJOKAG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PJCNLBJILED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public HGHKGLEBJDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public PJCNLBJILED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4932BB0", Offset = "0x49315B0", VA = "0x184932BB0")]
			internal object CFKOKLOMFEJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BLHHAIMPDGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public HGHKGLEBJDJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BLHHAIMPDGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5063C40", Offset = "0x5062640", VA = "0x185063C40")]
			internal object NDIHKNPKJOA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float OEADIFIODPL = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid HEJPJBAPELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string LKBAKGNBOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string PNAKKKOFJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string FDGKMMDFHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string FKEGECNPCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string HAAPLFKNJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string BGAOKMDPECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string JPGLICEKCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string BNKBCBOFBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string CJKGCKEEIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? NLEHCHKBIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? PGLEDDONNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> JHAOAMHEHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> DLNPALAFFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> NFDGIPFPHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> JHGJLMNPMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string NCJKNGINNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool LELMKICEHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private MFAPHLCBHHA AOJAFHLJOMC;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAC60", Offset = "0x3ED9660", VA = "0x183EDAC60")]
		public HGHKGLEBJDJ(Guid HEJPJBAPELP, string PNAKKKOFJCA, string LKBAKGNBOEH, string FDGKMMDFHMK, [Optional] string FKEGECNPCMO, [Optional] string HAAPLFKNJCK, [Optional] string BGAOKMDPECJ, [Optional] string CJKGCKEEIMM, [Optional] string NCJKNGINNKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
		public void CNHEEEBABEI(string FKEGECNPCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
		public void KGADHICOKDH(string FDGKMMDFHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8882D0", Offset = "0x886CD0", VA = "0x1808882D0")]
		public void NBCMGPMDAAO(string NCJKNGINNKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x885FF0", Offset = "0x8849F0", VA = "0x180885FF0")]
		public void PNMFDOKJPKE(string JPGLICEKCHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAC50", Offset = "0x3ED9650", VA = "0x183EDAC50")]
		public void PAFJJGPNFLK(Guid? HEJPJBAPELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4F30", Offset = "0x3ED3930", VA = "0x183ED4F30")]
		public void BKFCAEGKGPL((int, int)? PGLEDDONNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x886000", Offset = "0x884A00", VA = "0x180886000")]
		public void OBFENKMJHDJ(string BNKBCBOFBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6FF0", Offset = "0x3ED59F0", VA = "0x183ED6FF0")]
		public void GDKONPOKCGI(T IKEMLBNLNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9D10", Offset = "0x3ED8710", VA = "0x183ED9D10")]
		public void KEHNGGGECPH(T IKEMLBNLNCL, int CPEOFADCMDG, float PCILJOIJLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3ED93C0", Offset = "0x3ED7DC0", VA = "0x183ED93C0")]
		public void KDKHKCKMCEN(T IKEMLBNLNCL, int CPEOFADCMDG, string KLPNILCMFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7680", Offset = "0x3ED6080", VA = "0x183ED7680")]
		public void JIADJBLJPPO(T IKEMLBNLNCL, string FADNKBIICHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4F50", Offset = "0x3ED3950", VA = "0x183ED4F50")]
		public MFAPHLCBHHA CINKPDPAHFN(bool MOFNDFHCJJC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8840", Offset = "0x3ED7240", VA = "0x183ED8840")]
		private (IEnumerable<T>, string) JJCEHNALMCA()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA490", Offset = "0x3ED8E90", VA = "0x183EDA490")]
		public static KCHEAGPJFNB LFPFOAJDFNK(Guid HEJPJBAPELP, string PNAKKKOFJCA, T IKEMLBNLNCL, string LKBAKGNBOEH, string GEMGINMKGPI, string FKEGECNPCMO, int? EBDDHAPIAHH, [Optional] string NPKHKCPBLIH, [Optional] string FADNKBIICHB, [Optional] int? BLFPJFOJKKF, [Optional] Guid? NLEHCHKBIBO, [Optional] string NCJKNGINNKH, [Optional] string EDGPHDPDGLB, [Optional] (int, int)? PGLEDDONNEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7560", Offset = "0x3ED5F60", VA = "0x183ED7560")]
		[CompilerGenerated]
		private string IHIMOAANLDC(T KFBALBFDDFF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class LINJDHHPJCM<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string EIKPMHBAPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid FPEOAKIHAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long OJALFDDIFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int LGGIOCLKLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int GEGMNFEPFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime MDNIODIFJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool KMLIMCONOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, HEHENCNGKFM> FBNLOMIJBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool CGPJAFPOKAC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LKCOBPNALCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x912E40", Offset = "0x911840", VA = "0x180912E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DDGECGBPEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x907950", Offset = "0x906350", VA = "0x180907950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4432430", Offset = "0x4430E30", VA = "0x184432430")]
		public LINJDHHPJCM(string EIKPMHBAPNA, Guid FPEOAKIHAMA, long OJALFDDIFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ENGIOACJJFG(TListSessionStartParams PLAGHHCFBPJ);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAFB7C0", Offset = "0xAFA1C0", VA = "0x180AFB7C0")]
		public void ODFEPCJINAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void NKFAFPNOINP(bool AICFHBGHMME, TListSessionLogParams DLLDCCFNJAP);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4432050", Offset = "0x4430A50", VA = "0x184432050")]
		public void FELONINFJCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4432290", Offset = "0x4430C90", VA = "0x184432290")]
		public void KIBKOHCFEGI(long KLIDJGNPIFF, int EBDDHAPIAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x44320A0", Offset = "0x4430AA0", VA = "0x1844320A0")]
		public void ILMMKBMHPDC(long KLIDJGNPIFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract HEHENCNGKFM IHPFENPLHHM(TItem EDKOAHIAMMF, int EBDDHAPIAHH, string LCPNEJHOLNH);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class HEHENCNGKFM : CAJPLMNKCHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int LGGIOCLKLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long KLIDJGNPIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long OJALFDDIFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string BNMHAJCOFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string CCFKLCEKEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int GJCBFLODBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime OCEGDAKNHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double ENIMFCIKNCJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GFDFMAGNEGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1207BC0", Offset = "0x12065C0", VA = "0x181207BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1207940", Offset = "0x1206340", VA = "0x181207940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x627CAD0", Offset = "0x627B4D0", VA = "0x18627CAD0")]
		public HEHENCNGKFM(long KLIDJGNPIFF, int LGGIOCLKLDM, string EDGPHDPDGLB, long OJALFDDIFCK, int GJCBFLODBGG, [Optional] string LKBAKGNBOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x627C500", Offset = "0x627AF00", VA = "0x18627C500")]
		public void GPJPEJHNODD(int LGGIOCLKLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x627CA20", Offset = "0x627B420", VA = "0x18627CA20")]
		public void NCPBCEDAOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x627C3F0", Offset = "0x627ADF0", VA = "0x18627C3F0")]
		public void AACHIBGCMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x627CA70", Offset = "0x627B470", VA = "0x18627CA70")]
		private void NLPOJNLLOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x627C570", Offset = "0x627AF70", VA = "0x18627C570", Slot = "5")]
		public virtual KCHEAGPJFNB HENHINDNPGI(Guid HEJPJBAPELP, string INDPCJJDBOK, [Optional] string EDGPHDPDGLB, [Optional] long? IKEMLBNLNCL, [Optional] string LKBAKGNBOEH, [Optional] string FKEGECNPCMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HLGDAHNHIEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class NCGLGFEODMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public NCGLGFEODMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6281780", Offset = "0x6280180", VA = "0x186281780")]
			internal bool ANCKPGKOHOH()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct JJJHNEACOHB : IAsyncStateMachine
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
			private NCGLGFEODMG <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x627FE30", Offset = "0x627E830", VA = "0x18627FE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6281010", Offset = "0x627FA10", VA = "0x186281010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float JCAGCPBMMNO;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> IHJNMONLHAN;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> FBDCDDKLOBH;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string DCPCLDJJPOD;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? OEDJIALLBPH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int ILIFGIDKOAJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int IDLNDBBPMOI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool FLCEFKICLNN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, DKNNCDPGKIJ> DCJHKPKCDGI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly HLIGJNPKABP<bool> IBMBONPMGAH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static JAHIFEMIDHK? OBMCLMEHLHA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string PLFNGDGIGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x627EE60", Offset = "0x627D860", VA = "0x18627EE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x627EEB0", Offset = "0x627D8B0", VA = "0x18627EEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? KOELPKKBLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x627DDA0", Offset = "0x627C7A0", VA = "0x18627DDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x627DE00", Offset = "0x627C800", VA = "0x18627DE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? AAIAELENIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x627DA40", Offset = "0x627C440", VA = "0x18627DA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x627EF60", Offset = "0x627D960", VA = "0x18627EF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static FNKNKJIHBHA<bool> LBDKAJMFLEF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x627CF30", Offset = "0x627B930", VA = "0x18627CF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool BCFPFGKIFFC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x627E5B0", Offset = "0x627CFB0", VA = "0x18627E5B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x627CF80", Offset = "0x627B980", VA = "0x18627CF80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool BPPLMMPGOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x627D080", Offset = "0x627BA80", VA = "0x18627D080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x627DD40", Offset = "0x627C740", VA = "0x18627DD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float PFEPCLJFFHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x627CFE0", Offset = "0x627B9E0", VA = "0x18627CFE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x627CCE0", Offset = "0x627B6E0", VA = "0x18627CCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x627DAA0", Offset = "0x627C4A0", VA = "0x18627DAA0")]
		public static void GNKNJEFKCKN(string PNAMLOGLIPB, DKNNCDPGKIJ LLMEHPJFBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x627E7D0", Offset = "0x627D1D0", VA = "0x18627E7D0")]
		private static void OBBMDKMGMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x627EFC0", Offset = "0x627D9C0", VA = "0x18627EFC0")]
		internal static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x627DFA0", Offset = "0x627C9A0", VA = "0x18627DFA0")]
		internal static void LEMGKKGBPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x627E730", Offset = "0x627D130", VA = "0x18627E730")]
		internal static void NDPIAFNHGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x627D3D0", Offset = "0x627BDD0", VA = "0x18627D3D0")]
		public static Guid ENGIOACJJFG(string PNAMLOGLIPB, [Optional] string? CIELEGBAFCI, [Optional] Dictionary<string, object>? NFCDMKIKPEC)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x627D9A0", Offset = "0x627C3A0", VA = "0x18627D9A0")]
		public static Guid ENGIOACJJFG(string PNAMLOGLIPB, long CIELEGBAFCI, [Optional] Dictionary<string, object>? NFCDMKIKPEC)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x627EC00", Offset = "0x627D600", VA = "0x18627EC00")]
		public static void ODFEPCJINAE(string PNAMLOGLIPB, [Optional] Guid? HLIKNGLOMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x627DB30", Offset = "0x627C530", VA = "0x18627DB30")]
		public static void IEIBGFILGIH(string PNAMLOGLIPB, string CMMKLLOHGFA, object GHPAKCPGANE, bool FLCEFKICLNN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x627CD40", Offset = "0x627B740", VA = "0x18627CD40")]
		public static bool APNCKAECEGM(string PNAMLOGLIPB, [Optional] string? CIELEGBAFCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x627DE60", Offset = "0x627C860", VA = "0x18627DE60")]
		private static void JNMAMOCBLBO(bool JCGAKJLPFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x627D250", Offset = "0x627BC50", VA = "0x18627D250")]
		internal static void DJELHCAFPLL(string GJGBLLHIOAC, string JODEIIFHAPK, object OIGMDCDEKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x627D0D0", Offset = "0x627BAD0", VA = "0x18627D0D0")]
		internal static void DJELHCAFPLL(string GJGBLLHIOAC, Dictionary<string, object> ANCDMKKBECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x627CC70", Offset = "0x627B670", VA = "0x18627CC70")]
		private static void AKOIBLOGEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x627E600", Offset = "0x627D000", VA = "0x18627E600")]
		public static void LNJEHOHOBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x627D030", Offset = "0x627BA30", VA = "0x18627D030")]
		public static void CMEHHPAMPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x627F1A0", Offset = "0x627DBA0", VA = "0x18627F1A0")]
		private static void PPPLDFFDIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x627CBA0", Offset = "0x627B5A0", VA = "0x18627CBA0")]
		private static void AGOCMINLFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x627E650", Offset = "0x627D050", VA = "0x18627E650")]
		[AsyncStateMachine(typeof(JJJHNEACOHB))]
		private static Task MAMJCHCADJD(CancellationToken OGJIGALEPCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x627E150", Offset = "0x627CB50", VA = "0x18627E150")]
		private static void LFHCACOBGGJ(string PNAMLOGLIPB, Guid HEJPJBAPELP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class ADJGPHMAHOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct ALEKCPFGPFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool HDPGMPGBGCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string MNKHJCJHKNO;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1D0EF20", Offset = "0x1D0D920", VA = "0x181D0EF20")]
			public ALEKCPFGPFD(bool HDPGMPGBGCM, string MNKHJCJHKNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6279B90", Offset = "0x6278590", VA = "0x186279B90")]
		public static ALEKCPFGPFD HBGLILHNFJH(KCHEAGPJFNB AKKJJAGDDOJ)
		{
			return default(ALEKCPFGPFD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6279F60", Offset = "0x6278960", VA = "0x186279F60")]
		private static void KNDFDBHNHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6279EA0", Offset = "0x62788A0", VA = "0x186279EA0")]
		private static void INGKPPOJLGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KCCNEHELNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6281070", Offset = "0x627FA70", VA = "0x186281070")]
		public static KCHEAGPJFNB BEBLEPBKBCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class EMKJMGFENKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x627BA70", Offset = "0x627A470", VA = "0x18627BA70")]
		public static KCHEAGPJFNB HMKLMEBHDCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x627B9B0", Offset = "0x627A3B0", VA = "0x18627B9B0")]
		public static KCHEAGPJFNB GJPHECCCJBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x627B8F0", Offset = "0x627A2F0", VA = "0x18627B8F0")]
		public static KCHEAGPJFNB FBGNJEIFDFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x627B890", Offset = "0x627A290", VA = "0x18627B890")]
		public static KCHEAGPJFNB EBENEMLPBOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x627B830", Offset = "0x627A230", VA = "0x18627B830")]
		public static KCHEAGPJFNB CLEBAMOKADI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x627BA10", Offset = "0x627A410", VA = "0x18627BA10")]
		public static KCHEAGPJFNB HCMOAFDKLFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x627B950", Offset = "0x627A350", VA = "0x18627B950")]
		public static KCHEAGPJFNB GBACBOJPFKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x627BBF0", Offset = "0x627A5F0", VA = "0x18627BBF0")]
		public static KCHEAGPJFNB LCEDHENGHGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x627BB30", Offset = "0x627A530", VA = "0x18627BB30")]
		public static KCHEAGPJFNB JPHKNMCFBJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x627BB90", Offset = "0x627A590", VA = "0x18627BB90")]
		public static KCHEAGPJFNB LCCHLGMAFLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x627BC50", Offset = "0x627A650", VA = "0x18627BC50")]
		public static KCHEAGPJFNB NMHLGEBDKKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x627BAD0", Offset = "0x627A4D0", VA = "0x18627BAD0")]
		public static KCHEAGPJFNB JBEOBFCLEKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class KFLCPCPBNFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6281200", Offset = "0x627FC00", VA = "0x186281200")]
		public static KCHEAGPJFNB LFGOBDPBGLL(long NDAIANNJONA, long EIJHDDNKCOA, bool INAOPEBCKIN, string DEAIPGBEPIE, string HFNAKCEKNCD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class IDONGJMGENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x627F790", Offset = "0x627E190", VA = "0x18627F790")]
		public static KCHEAGPJFNB IMPNHKHIIGG(string OHCKJFOCDGI, string ECMDFBCHANC, bool OHDJDEGNNIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x627F900", Offset = "0x627E300", VA = "0x18627F900")]
		public static KCHEAGPJFNB JPJNKHICHCJ(string GJGBLLHIOAC, string IFMOANIIDIA, string CJKHGJMGAIJ, [Optional] int? BCLJIHGJJHB, [Optional] double[] OMKDKFHOJDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PEKLDHGEEID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6282920", Offset = "0x6281320", VA = "0x186282920")]
		public static KCHEAGPJFNB DJKADGPEMOI(string IDPBFJCELDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6282840", Offset = "0x6281240", VA = "0x186282840")]
		public static KCHEAGPJFNB DIHOOHDGJPA(string NCDFPGPKKJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6282AC0", Offset = "0x62814C0", VA = "0x186282AC0")]
		public static KCHEAGPJFNB KPNLAMDJIHF(int JECGBBECKDN, string HBOONHFLONJ, string KFBALBFDDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6282EE0", Offset = "0x62818E0", VA = "0x186282EE0")]
		public static KCHEAGPJFNB OJLGJFNFGFD(int JECGBBECKDN, string HBOONHFLONJ, string KFBALBFDDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6282A60", Offset = "0x6281460", VA = "0x186282A60")]
		public static KCHEAGPJFNB KLLHKEJMKCM(int JECGBBECKDN, string HBOONHFLONJ, string KFBALBFDDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6282A00", Offset = "0x6281400", VA = "0x186282A00")]
		public static KCHEAGPJFNB EBJNIPPLJDL(int JECGBBECKDN, string HBOONHFLONJ, string KFBALBFDDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6282B20", Offset = "0x6281520", VA = "0x186282B20")]
		public static KCHEAGPJFNB NCEMJHIPAJK(string HBOONHFLONJ, string KFBALBFDDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6282DA0", Offset = "0x62817A0", VA = "0x186282DA0")]
		private static KCHEAGPJFNB OCJHCJDAKBG(string EIKPMHBAPNA, int JECGBBECKDN, string DKDODMFFLEC, string JDEHEAILINA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6282C70", Offset = "0x6281670", VA = "0x186282C70")]
		private static KCHEAGPJFNB OCJHCJDAKBG(string EIKPMHBAPNA, string DKDODMFFLEC, string JDEHEAILINA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly ANDGIEDMMDP HBGLILHNFJH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static LEOKDMFNADP PFNPNFEKNGM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static CNCGMILALCP JOHBDHGAMOO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<KCHEAGPJFNB> LAMMMLFMOCH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long IOPJDEDMKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62818A0", Offset = "0x62802A0", VA = "0x1862818A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6281990", Offset = "0x6280390", VA = "0x186281990")]
	[NBPHLMAPGPJ.LCAAJBOOONB]
	internal static void KECOGBHHKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6281BA0", Offset = "0x62805A0", VA = "0x186281BA0")]
	private static void PCEEADECCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6281820", Offset = "0x6280220", VA = "0x186281820")]
	public static KCHEAGPJFNB FCPLBKBJKKO(string CPNMNFEEDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x627BEF0", Offset = "0x627A8F0", VA = "0x18627BEF0")]
	public static KCHEAGPJFNB FCPLBKBJKKO(string CPNMNFEEDIG, int JECGBBECKDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6281A80", Offset = "0x6280480", VA = "0x186281A80")]
	[NBPHLMAPGPJ.LCAAJBOOONB]
	internal static void LDJEMONMCMK()
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
