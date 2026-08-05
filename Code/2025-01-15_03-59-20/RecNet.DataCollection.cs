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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6659020", Offset = "0x6658420", VA = "0x186659020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6658920", Offset = "0x6657D20", VA = "0x186658920", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6659C40", Offset = "0x6659040", VA = "0x186659C40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KHDFIANJBIF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> PGEJJIMKKLM();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GLFEDGLGEEF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GLHDHJOLHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NBPJEHFNFFH OOHNKIMODMP(Guid BLMHJOODFPE, string CDAABEECPKP, [Optional] string LKDEECFFKBF, [Optional] long? OIGAGHELKAO, [Optional] string BGHKIELOFOG, [Optional] string HNANMKHAMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class IAJBGBBGCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6655310", Offset = "0x6654710", VA = "0x186655310")]
		public static NBPJEHFNFFH DGOGGGEHAGA(Guid BLMHJOODFPE, string CDAABEECPKP, string LKDEECFFKBF, [Optional] long? OIGAGHELKAO, [Optional] string BGHKIELOFOG, [Optional] string HNANMKHAMEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NBPJEHFNFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected APIMFILCEDN IAAPABJLNAL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
		public NBPJEHFNFFH(APIMFILCEDN IAAPABJLNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x66589B0", Offset = "0x6657DB0", VA = "0x1866589B0")]
		public NBPJEHFNFFH BHOANFGMAPJ(string LKGPHBHEBBE, string HCPAOILCJCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36F5840", Offset = "0x36F4C40", VA = "0x1836F5840")]
		public NBPJEHFNFFH BHOANFGMAPJ<T>(string LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x36F5BC0", Offset = "0x36F4FC0", VA = "0x1836F5BC0")]
		public NBPJEHFNFFH FLEIEDMIEOA<T>(string LKGPHBHEBBE, T? HCPAOILCJCB) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6658A30", Offset = "0x6657E30", VA = "0x186658A30")]
		public NBPJEHFNFFH FLEIEDMIEOA(string LKGPHBHEBBE, string HCPAOILCJCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6658AC0", Offset = "0x6657EC0", VA = "0x186658AC0")]
		public CLHPIMOBJFN NBNOGKPBDNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x23137B0", Offset = "0x2312BB0", VA = "0x1823137B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class APIMFILCEDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<APIMFILCEDN> KNPBEKGNNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string CJDBHELDNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> PJCBCKLBNFK;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6651B20", Offset = "0x6650F20", VA = "0x186651B20")]
		private APIMFILCEDN(string CJDBHELDNNN, int HKJDGEGEECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x66517C0", Offset = "0x6650BC0", VA = "0x1866517C0")]
		public static NBPJEHFNFFH KOPOAAAOIOD(string CJDBHELDNNN, int HKJDGEGEECN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6651870", Offset = "0x6650C70", VA = "0x186651870")]
		public CLHPIMOBJFN NBNOGKPBDNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6651AB0", Offset = "0x6650EB0", VA = "0x186651AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x30D8760", Offset = "0x30D7B60", VA = "0x1830D8760")]
		internal void IBOCLJOLHEG<T>(string LKGPHBHEBBE, T HCPAOILCJCB) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6651760", Offset = "0x6650B60", VA = "0x186651760")]
		internal void IBOCLJOLHEG(string LKGPHBHEBBE, string HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x36ED070", Offset = "0x36EC470", VA = "0x1836ED070")]
		private void NIJBHENMHCC<T>(string LKGPHBHEBBE, T HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct HJEJGJNNCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string FDHEGEJHECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? JHIEDJKCDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? FHGPKAKOKEF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6654BD0", Offset = "0x6653FD0", VA = "0x186654BD0")]
		public HJEJGJNNCCM(string BIGILGJFGIL, [Optional] long? GGLEGKBAGLC, [Optional] short? EHAHLIONMFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CAAOEKHFBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int JNCDKAKOOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string BNPNIKAJDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short EODDPLJDNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string GOLCNAFKHPB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6652330", Offset = "0x6651730", VA = "0x186652330")]
		public CAAOEKHFBED(int LHOFKHKBNJK, string DIHNCDHPMFF, short KOFHILADDEN, string JFPCADPGCJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ANCHFMLFECM : LFLJHBCMADD<NPJKANMGAGF, CAAOEKHFBED, HJEJGJNNCCM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string DIHNCDHPMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short KOFHILADDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string JFPCADPGCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> AIGOFAAMHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int OAOAIALDKLL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66516E0", Offset = "0x6650AE0", VA = "0x1866516E0")]
		public ANCHFMLFECM(string IFALOHNMHNE, Guid JOKAAAMIIHN, long EOJIEKDCDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66513F0", Offset = "0x66507F0", VA = "0x1866513F0", Slot = "4")]
		public override void OICOGPMHBBD(CAAOEKHFBED EMGDJLDJPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6650280", Offset = "0x664F680", VA = "0x186650280")]
		public void CKDBPJGIAKP(short KOFHILADDEN, bool NOENGGMMCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4046750", Offset = "0x4045B50", VA = "0x184046750")]
		public void IIAIJCOPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF40", Offset = "0x8CA340", VA = "0x1808CAF40")]
		public void KNGHIHNLGIO(string DBNEEPCPCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6650360", Offset = "0x664F760", VA = "0x186650360", Slot = "5")]
		public override void KOMKDPJCOHK(bool GENGOJOFDFM, HJEJGJNNCCM LIIPDKMEMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6651140", Offset = "0x6650540", VA = "0x186651140", Slot = "6")]
		public override IHBDEPDILIK OEMCGNMLKMK(NPJKANMGAGF JNJHAEDGEPO, int IIACLAMOIEE, string MFALCIBLBGG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class DLAEKJJNCJP : IHBDEPDILIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string DIHNCDHPMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short KOFHILADDEN;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6653BD0", Offset = "0x6652FD0", VA = "0x186653BD0")]
		public DLAEKJJNCJP(long ELHJOOLDFFH, int LHOFKHKBNJK, string LKDEECFFKBF, long EOJIEKDCDLB, int KDCDKOGPIHC, string BGHKIELOFOG, short KOFHILADDEN, string DIHNCDHPMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6653A20", Offset = "0x6652E20", VA = "0x186653A20")]
		public void BPONKCKBGKP(int LHOFKHKBNJK, string DIHNCDHPMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6653AA0", Offset = "0x6652EA0", VA = "0x186653AA0", Slot = "5")]
		public override NBPJEHFNFFH OOHNKIMODMP(Guid BLMHJOODFPE, string CDAABEECPKP, [Optional] string LKDEECFFKBF, [Optional] long? OIGAGHELKAO, [Optional] string BGHKIELOFOG, [Optional] string HNANMKHAMEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IIJOEEOJEED
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6655CD0", Offset = "0x66550D0", VA = "0x186655CD0")]
		public static void JEADHJMLFBP(string LDCKBFKFIKC, object GFBHKFECFCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class PAPIKFEDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct GLBJOLAGMFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int FLCLCDDFAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int KJGDAOKNFJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int ABEBFOOKEIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int OGNAEPKBCID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int CIAIPJFJBEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int NOGOBPMBGKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int NJKINMFEPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int EAEKGPCANAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int NJAPHKEOOMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int NNBKPKANBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int MOIHJPKMDKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int HJPMECGLCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int OECJGBFKOHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int JICMMPKLJLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int OGCHMOPDCLP;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x66546B0", Offset = "0x6653AB0", VA = "0x1866546B0")]
			public GLBJOLAGMFI(int IAJNGBPOPEE, int HFJKHIBLEFO, int OPEHFJHJLHI, int FHJMPEGKPAL, int MLLLMHOCJJP, int GJNKADJCPAD, int AFKPPHANHBA, int KKBLMBPOOFM, int FBDMHDKAMNC, int HECNHHJPHFC, int MDKNBBLHHEH, int ECICHHEDOLJ, int OJDLMKMEPLJ, int DEDONEOLFOJ, int CIIDIKFFNDH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? EFMMDDEHCPN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> KAHJEFAJNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x66590A0", Offset = "0x66584A0", VA = "0x1866590A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6659150", Offset = "0x6658550", VA = "0x186659150")]
		public static void GNGGMKOIMIC(GLBJOLAGMFI PIOKALPGGGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class COOLJIEIFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66535D0", Offset = "0x66529D0", VA = "0x1866535D0")]
		public static void JEADHJMLFBP(string LDCKBFKFIKC, object GFBHKFECFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6653870", Offset = "0x6652C70", VA = "0x186653870")]
		public static void JEADHJMLFBP(string LDCKBFKFIKC, float HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6653640", Offset = "0x6652A40", VA = "0x186653640")]
		public static void JEADHJMLFBP(string LDCKBFKFIKC, INHNBFJLKDB GFBHKFECFCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class GBNIDBCOPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x66544A0", Offset = "0x66538A0", VA = "0x1866544A0")]
		public static void LKNCCCAOKOH(float3 CPGMOBFHDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66542E0", Offset = "0x66536E0", VA = "0x1866542E0")]
		public static void KOBJGGHGJCC(bool OEBBPBMKGBM, bool AKMOOGCDCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66545B0", Offset = "0x66539B0", VA = "0x1866545B0")]
		public static void PNFIPOAJAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6654400", Offset = "0x6653800", VA = "0x186654400")]
		public static void LBKFJLJJFCG(int BICMKJFMMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6654240", Offset = "0x6653640", VA = "0x186654240")]
		public static void DEPJHBCKMOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class GOBJNJKDNIN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class MFIAMEDLKHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GOBJNJKDNIN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MFIAMEDLKHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x49E80E0", Offset = "0x49E74E0", VA = "0x1849E80E0")]
			internal object ONOLGLNDMKA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class MBODJJNKHJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public GOBJNJKDNIN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MBODJJNKHJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x49D98B0", Offset = "0x49D8CB0", VA = "0x1849D98B0")]
			internal object DMCCLFKBLAG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class GMAKMOLJOML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public GOBJNJKDNIN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public GMAKMOLJOML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x41A82C0", Offset = "0x41A76C0", VA = "0x1841A82C0")]
			internal object JIKPDEJDJAO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BJJKKGLODFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public GOBJNJKDNIN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public BJJKKGLODFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x53D82A0", Offset = "0x53D76A0", VA = "0x1853D82A0")]
			internal object CHEFBMHEJGP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class HINLKFIJLHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public GOBJNJKDNIN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HINLKFIJLHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x425BE90", Offset = "0x425B290", VA = "0x18425BE90")]
			internal object IIHDENPIFMG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float AMLMCEFOKMO = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid BLMHJOODFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string BGHKIELOFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string KAKLDAPDPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string CIOEHBOIIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string HNANMKHAMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string NECKFEKLAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string JOCHJKCAKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string KPPEBJJFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string HNDKNMIKLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string NPKJJKOHOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? INPBLMCGBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? FAOOODGMAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> KMLMCOEIFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> DNOIMGHLICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> MNCJPCONJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> BFPBEEIDJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Dictionary<T, string[]> OGIFBNKEAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string KKKPHKFMOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CBDJGDIEMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CLHPIMOBJFN EGKBOBOPBOC;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41B5E90", Offset = "0x41B5290", VA = "0x1841B5E90")]
		public GOBJNJKDNIN(Guid BLMHJOODFPE, string KAKLDAPDPCP, string BGHKIELOFOG, string CIOEHBOIIGD, [Optional] string HNANMKHAMEO, [Optional] string NECKFEKLAAC, [Optional] string JOCHJKCAKPF, [Optional] string NPKJJKOHOHK, [Optional] string KKKPHKFMOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D0CD0", Offset = "0x8D00D0", VA = "0x1808D0CD0")]
		public void BELKCIABCCP(string HNANMKHAMEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80")]
		public void GBJFJCOHHMK(string CIOEHBOIIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280")]
		public void CDFNFDACLND(string KKKPHKFMOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8CA2B0", VA = "0x1808CAEB0")]
		public void HHGCBKDEKFF(string KPPEBJJFOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x41B29C0", Offset = "0x41B1DC0", VA = "0x1841B29C0")]
		public void KPAPJIHKGAF(Guid? BLMHJOODFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41B1190", Offset = "0x41B0590", VA = "0x1841B1190")]
		public void JBIELMJLKGI((int, int)? FAOOODGMAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8CAF30", Offset = "0x8CA330", VA = "0x1808CAF30")]
		public void FLPNAEBGAPL(string HNDKNMIKLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41AF6E0", Offset = "0x41AEAE0", VA = "0x1841AF6E0")]
		public void BPOJHPKMEKC(T OIGAGHELKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41AFF10", Offset = "0x41AF310", VA = "0x1841AFF10")]
		public void CCAOFCJKFNC(T OIGAGHELKAO, int OHGMPJEEFNN, float BOHBFCKDKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41B4EF0", Offset = "0x41B42F0", VA = "0x1841B4EF0")]
		public void NCBJBNJEFBB(T OIGAGHELKAO, int OHGMPJEEFNN, string IBGCCMINDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41B2650", Offset = "0x41B1A50", VA = "0x1841B2650")]
		public void KMIBJGCCCDP(T OIGAGHELKAO, string AHAFONDBFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41B56F0", Offset = "0x41B4AF0", VA = "0x1841B56F0")]
		public void PIFLJFPFKJE(T OIGAGHELKAO, string[] JCCJHIHEFJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41B2B80", Offset = "0x41B1F80", VA = "0x1841B2B80")]
		public CLHPIMOBJFN NBNOGKPBDNI(bool MKNFMGNFODH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41B17F0", Offset = "0x41B0BF0", VA = "0x1841B17F0")]
		private (IEnumerable<T>, string) KBGAJHCOPFN()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x41B09D0", Offset = "0x41AFDD0", VA = "0x1841B09D0")]
		public static NBPJEHFNFFH CLNKOAHGNPN(Guid BLMHJOODFPE, string KAKLDAPDPCP, T OIGAGHELKAO, string BGHKIELOFOG, string EKOOIFGAOON, string HNANMKHAMEO, int? IIACLAMOIEE, [Optional] string ENFKEEKENPG, [Optional] string AHAFONDBFBO, [Optional] int? NGIKCFLEJKN, [Optional] Guid? INPBLMCGBOD, [Optional] string KKKPHKFMOOE, [Optional] string LKDEECFFKBF, [Optional] (int, int)? FAOOODGMAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x41B2A60", Offset = "0x41B1E60", VA = "0x1841B2A60")]
		[CompilerGenerated]
		private string LOHONDDPDNN(T LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x41B5C20", Offset = "0x41B5020", VA = "0x1841B5C20")]
		[CompilerGenerated]
		private string PNEOCJEJFPO(T LPMIIFILJPI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class LFLJHBCMADD<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected readonly string IFALOHNMHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected readonly Guid JOKAAAMIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected readonly long EOJIEKDCDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int LHOFKHKBNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int DLANNCOEILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected DateTime MONFEFOGBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected bool JCJAMJOABFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Dictionary<long, IHBDEPDILIK> JOPJMCIOOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		protected bool DEPAGMLNMAH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LEGHPMGIPEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x942EF0", Offset = "0x9422F0", VA = "0x180942EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool HHINCDIHMCF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xAE8480", Offset = "0xAE7880", VA = "0x180AE8480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x47C33A0", Offset = "0x47C27A0", VA = "0x1847C33A0")]
		public LFLJHBCMADD(string IFALOHNMHNE, Guid JOKAAAMIIHN, long EOJIEKDCDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OICOGPMHBBD(TListSessionStartParams EMGDJLDJPLM);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD26FC0", Offset = "0xD263C0", VA = "0x180D26FC0")]
		public void IGJGFLLKOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KOMKDPJCOHK(bool GENGOJOFDFM, TListSessionLogParams LIIPDKMEMNP);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x47C3090", Offset = "0x47C2490", VA = "0x1847C3090")]
		public void ACBDHIHAENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x47C31B0", Offset = "0x47C25B0", VA = "0x1847C31B0")]
		public void BJMDNEENGEK(long ELHJOOLDFFH, int IIACLAMOIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x47C3310", Offset = "0x47C2710", VA = "0x1847C3310")]
		public void HAAOODKICGB(long ELHJOOLDFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract IHBDEPDILIK OEMCGNMLKMK(TItem FKIFNEPLBJJ, int IIACLAMOIEE, string MFALCIBLBGG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class IHBDEPDILIK : GLHDHJOLHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int LHOFKHKBNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long ELHJOOLDFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long EOJIEKDCDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly string CBKEHLGKGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly string KALAGKBMPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly int KDCDKOGPIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DateTime FJFKBJDIDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private double OBCFOFOJINE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PLKHKFDNJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA549B0", Offset = "0xA53DB0", VA = "0x180A549B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA546D0", Offset = "0xA53AD0", VA = "0x180A546D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6655C00", Offset = "0x6655000", VA = "0x186655C00")]
		public IHBDEPDILIK(long ELHJOOLDFFH, int LHOFKHKBNJK, string LKDEECFFKBF, long EOJIEKDCDLB, int KDCDKOGPIHC, [Optional] string BGHKIELOFOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6655690", Offset = "0x6654A90", VA = "0x186655690")]
		public void HNEPOINFOMB(int LHOFKHKBNJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6655700", Offset = "0x6654B00", VA = "0x186655700")]
		public void JNGINOIKIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6655580", Offset = "0x6654980", VA = "0x186655580")]
		public void GLJOJPFEMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6655520", Offset = "0x6654920", VA = "0x186655520")]
		private void CGIOIDFOEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6655750", Offset = "0x6654B50", VA = "0x186655750", Slot = "5")]
		public virtual NBPJEHFNFFH OOHNKIMODMP(Guid BLMHJOODFPE, string CDAABEECPKP, [Optional] string LKDEECFFKBF, [Optional] long? OIGAGHELKAO, [Optional] string BGHKIELOFOG, [Optional] string HNANMKHAMEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class KFABLLKDDCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class DGCANCHDPJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DGCANCHDPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6653980", Offset = "0x6652D80", VA = "0x186653980")]
			internal bool HADLLHIJIIC()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct CLHLOCCHKHD : IAsyncStateMachine
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
			private DGCANCHDPJN <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x6652380", Offset = "0x6651780", VA = "0x186652380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6653570", Offset = "0x6652970", VA = "0x186653570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly float CDABJDMLIHM;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, Dictionary<string, object>> MLKBJPBONNI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static Dictionary<string, Dictionary<string, object>> IEAJKLPJKBG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static string CEDHPPEALID;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static CancellationTokenSource? KOLMAFHDILK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static int IEBIOIFGLLM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static int CFFDOPEEOLD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static bool KNDNIOJKFJE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly Dictionary<string, KHDFIANJBIF> OHCNAANBCLO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly FABEAAEBPBG<bool> JBIIKIBPJOA;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static AJCHOFIOKBP? AHABIKIGDEA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string KPCDAFDKAED
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6656B40", Offset = "0x6655F40", VA = "0x186656B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6656640", Offset = "0x6655A40", VA = "0x186656640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? OIHEIJGLFLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6655D40", Offset = "0x6655140", VA = "0x186655D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6657750", Offset = "0x6656B50", VA = "0x186657750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? PHDBMLAICEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6658670", Offset = "0x6657A70", VA = "0x186658670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6657CE0", Offset = "0x66570E0", VA = "0x186657CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static NDJAOIDIEAL<bool> CILHLNICODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x66566F0", Offset = "0x6655AF0", VA = "0x1866566F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool FIIJIKNIDMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6657800", Offset = "0x6656C00", VA = "0x186657800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6656740", Offset = "0x6655B40", VA = "0x186656740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool KEPDPFKCNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6657850", Offset = "0x6656C50", VA = "0x186657850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x66578A0", Offset = "0x6656CA0", VA = "0x1866578A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float BFAIJFFJIOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6656C30", Offset = "0x6656030", VA = "0x186656C30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6657900", Offset = "0x6656D00", VA = "0x186657900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6655DA0", Offset = "0x66551A0", VA = "0x186655DA0")]
		public static void BBPNNBFBBFL(string CBJCFNNKEDF, KHDFIANJBIF GKOJGGDECBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6657050", Offset = "0x6656450", VA = "0x186657050")]
		private static void HPIAAGBBFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6658490", Offset = "0x6657890", VA = "0x186658490")]
		internal static void OOJJEJPOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6656490", Offset = "0x6655890", VA = "0x186656490")]
		internal static void CLBLNEJDEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6656B90", Offset = "0x6655F90", VA = "0x186656B90")]
		internal static void EDOHJCKLGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6657DE0", Offset = "0x66571E0", VA = "0x186657DE0")]
		public static Guid OICOGPMHBBD(string CBJCFNNKEDF, [Optional] string? LFAKJMNCAMO, [Optional] Dictionary<string, object>? DIGPOIBCLPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6657D40", Offset = "0x6657140", VA = "0x186657D40")]
		public static Guid OICOGPMHBBD(string CBJCFNNKEDF, long LFAKJMNCAMO, [Optional] Dictionary<string, object>? DIGPOIBCLPD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6657480", Offset = "0x6656880", VA = "0x186657480")]
		public static void IGJGFLLKOPC(string CBJCFNNKEDF, [Optional] Guid? FNECNONNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6655E30", Offset = "0x6655230", VA = "0x186655E30")]
		public static void BIPPLELGBHI(string CBJCFNNKEDF, string EKKLNJAKAEM, object FHPMIEJAIHK, bool KNDNIOJKFJE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6657960", Offset = "0x6656D60", VA = "0x186657960")]
		public static bool MEHNENCEIGD(string CBJCFNNKEDF, [Optional] string? LFAKJMNCAMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6657B50", Offset = "0x6656F50", VA = "0x186657B50")]
		private static void MNODIHMHJKO(bool GIOMDAKHMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6656D50", Offset = "0x6656150", VA = "0x186656D50")]
		internal static void HLEHAKNPPDJ(string NOIHGGNEIML, string LDCKBFKFIKC, object JGCOLLOOLHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6656ED0", Offset = "0x66562D0", VA = "0x186656ED0")]
		internal static void HLEHAKNPPDJ(string NOIHGGNEIML, Dictionary<string, object> MFECDBFEDPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66576E0", Offset = "0x6656AE0", VA = "0x1866576E0")]
		private static void JALAGAGKLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6657C90", Offset = "0x6657090", VA = "0x186657C90")]
		public static void NCPHMODFIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x66577B0", Offset = "0x6656BB0", VA = "0x1866577B0")]
		public static void KFPGFDOEELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x66567A0", Offset = "0x6655BA0", VA = "0x1866567A0")]
		private static void DHJADNOBGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6656C80", Offset = "0x6656080", VA = "0x186656C80")]
		private static void FGEFHEEOKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x66583B0", Offset = "0x66577B0", VA = "0x1866583B0")]
		[AsyncStateMachine(typeof(CLHLOCCHKHD))]
		private static Task OLAEFNDAPFJ(CancellationToken FHGIOBPPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6656030", Offset = "0x6655430", VA = "0x186656030")]
		private static void CCMHKHDDKPM(string CBJCFNNKEDF, Guid BLMHJOODFPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BFPHANEOLLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct EJLGCAHCPAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool BIDPAAHCAAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string PFKGJDDEPJK;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x21486C0", Offset = "0x2147AC0", VA = "0x1821486C0")]
			public EJLGCAHCPAO(bool BIDPAAHCAAA, string PFKGJDDEPJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6652020", Offset = "0x6651420", VA = "0x186652020")]
		public static EJLGCAHCPAO LDCMEBNGNBB(NBPJEHFNFFH EBHMEHANGKM)
		{
			return default(EJLGCAHCPAO);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6651E60", Offset = "0x6651260", VA = "0x186651E60")]
		private static void ADPPONPLDAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6651F60", Offset = "0x6651360", VA = "0x186651F60")]
		private static void BOEPAANBPFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class GCMEDBCFPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6654650", Offset = "0x6653A50", VA = "0x186654650")]
		public static NBPJEHFNFFH AHNIOOIBKCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class NHAEBMACLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6658C60", Offset = "0x6658060", VA = "0x186658C60")]
		public static NBPJEHFNFFH FIFLGMCKILP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6658B40", Offset = "0x6657F40", VA = "0x186658B40")]
		public static NBPJEHFNFFH EBNAEOBFPDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6658EA0", Offset = "0x66582A0", VA = "0x186658EA0")]
		public static NBPJEHFNFFH MMFKAFODJEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6658E40", Offset = "0x6658240", VA = "0x186658E40")]
		public static NBPJEHFNFFH LHOMFMGFHFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6658D80", Offset = "0x6658180", VA = "0x186658D80")]
		public static NBPJEHFNFFH HOMJCOAMLDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6658AE0", Offset = "0x6657EE0", VA = "0x186658AE0")]
		public static NBPJEHFNFFH DNNEEGCNPLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6658BA0", Offset = "0x6657FA0", VA = "0x186658BA0")]
		public static NBPJEHFNFFH FCHPBFCHDKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6658F60", Offset = "0x6658360", VA = "0x186658F60")]
		public static NBPJEHFNFFH OLJBAODAHEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6658FC0", Offset = "0x66583C0", VA = "0x186658FC0")]
		public static NBPJEHFNFFH ONBAMCOKADL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6658C00", Offset = "0x6658000", VA = "0x186658C00")]
		public static NBPJEHFNFFH FFLGKMGPNDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6658D20", Offset = "0x6658120", VA = "0x186658D20")]
		public static NBPJEHFNFFH HCAJHKBIBBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6658DE0", Offset = "0x66581E0", VA = "0x186658DE0")]
		public static NBPJEHFNFFH KILLOFCAPMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6658CC0", Offset = "0x66580C0", VA = "0x186658CC0")]
		public static NBPJEHFNFFH GLHFHLALFAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6658F00", Offset = "0x6658300", VA = "0x186658F00")]
		public static NBPJEHFNFFH NFGICBHDMCB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FCEGPJNCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6654060", Offset = "0x6653460", VA = "0x186654060")]
		public static NBPJEHFNFFH HHHKNNOJFMP(long GGLEGKBAGLC, long DLGNECIGKLC, bool IOLBANAPPCK, string FGJJHCFPBCC, string PBLHLNAFJAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ENMLGCMNIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6653EF0", Offset = "0x66532F0", VA = "0x186653EF0")]
		public static NBPJEHFNFFH NCCFBOFFHJN(string PBJCDGJPELC, string INOPGFHPFIG, bool ODJMJLCFDNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6653CC0", Offset = "0x66530C0", VA = "0x186653CC0")]
		public static NBPJEHFNFFH JPMPIAGOJHG(string NOIHGGNEIML, string HHKCFLABBMA, string KONCFNJACEI, [Optional] int? JONPGJGGIJJ, [Optional] double[] ADEJIMLLHCH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HKCHOEINEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6655150", Offset = "0x6654550", VA = "0x186655150")]
		public static NBPJEHFNFFH OEOGPDHMOFP(string EIBACBGJEHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6655230", Offset = "0x6654630", VA = "0x186655230")]
		public static NBPJEHFNFFH PDCHENJGMOF(string NJMBEEDLFGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6654E80", Offset = "0x6654280", VA = "0x186654E80")]
		public static NBPJEHFNFFH BNHPICELNFL(int HKJDGEGEECN, string LJAGHAHCFHJ, string LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6654EE0", Offset = "0x66542E0", VA = "0x186654EE0")]
		public static NBPJEHFNFFH JLCEMGFPBJM(int HKJDGEGEECN, string LJAGHAHCFHJ, string LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6654FA0", Offset = "0x66543A0", VA = "0x186654FA0")]
		public static NBPJEHFNFFH KHJLFCPHDEH(int HKJDGEGEECN, string LJAGHAHCFHJ, string LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6654F40", Offset = "0x6654340", VA = "0x186654F40")]
		public static NBPJEHFNFFH JPJEKEHBDOD(int HKJDGEGEECN, string LJAGHAHCFHJ, string LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6655000", Offset = "0x6654400", VA = "0x186655000")]
		public static NBPJEHFNFFH NALNFMNJEHF(string LJAGHAHCFHJ, string LPMIIFILJPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6654D40", Offset = "0x6654140", VA = "0x186654D40")]
		private static NBPJEHFNFFH BDCCDDLOMMN(string IFALOHNMHNE, int HKJDGEGEECN, string DHIGFFCEMOL, string MPLCINHGAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6654C10", Offset = "0x6654010", VA = "0x186654C10")]
		private static NBPJEHFNFFH BDCCDDLOMMN(string IFALOHNMHNE, string DHIGFFCEMOL, string MPLCINHGAMH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly GKOKEEMOOFG LDCMEBNGNBB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static FNJEDMNNIPN JOEJCKPBHPM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static JNBOKINFKNI PBALAKOOIEP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<NBPJEHFNFFH> GAGCMBIMGKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long BALKCIKPMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6654810", Offset = "0x6653C10", VA = "0x186654810")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6654720", Offset = "0x6653B20", VA = "0x186654720")]
	[FEALGOFKPAD.NCEOPNKGCMA]
	internal static void IEPNBOKMEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6654980", Offset = "0x6653D80", VA = "0x186654980")]
	private static void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6654900", Offset = "0x6653D00", VA = "0x186654900")]
	public static NBPJEHFNFFH LNCGDDMDFGM(string CJDBHELDNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66517C0", Offset = "0x6650BC0", VA = "0x1866517C0")]
	public static NBPJEHFNFFH LNCGDDMDFGM(string CJDBHELDNNN, int HKJDGEGEECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6654A40", Offset = "0x6653E40", VA = "0x186654A40")]
	[FEALGOFKPAD.NCEOPNKGCMA]
	internal static void PNJPIDJPKPH()
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
