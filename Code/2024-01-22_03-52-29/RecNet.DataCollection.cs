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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5792AE0", Offset = "0x5791EE0", VA = "0x185792AE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GEMJPFGHNML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> FBHPHHBDOHA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KFICECCNMGL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LCGAIFAGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JOOCFFIKAOB JMHEDGEMBKC(Guid ONGEFBKHPDG, string BODEPOINBLC, [Optional] string KBECCPLOKDP, [Optional] long? FDJCLHKPCBI, [Optional] string PMKAFIGADDK, [Optional] string JECOLECBLOF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ABIKCFHJPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x578A880", Offset = "0x5789C80", VA = "0x18578A880")]
		public static JOOCFFIKAOB LKPAKFBMGHB(Guid ONGEFBKHPDG, string BODEPOINBLC, string KBECCPLOKDP, [Optional] long? FDJCLHKPCBI, [Optional] string PMKAFIGADDK, [Optional] string JECOLECBLOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class JOOCFFIKAOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected ILCPHNNKAKB FILLDNNEIPF;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
		public JOOCFFIKAOB(ILCPHNNKAKB FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x578F780", Offset = "0x578EB80", VA = "0x18578F780")]
		public JOOCFFIKAOB MEPLKNIGBCO(string JAOOJJKNLDO, string PAHKKNONPEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C08660", Offset = "0x2C07A60", VA = "0x182C08660")]
		public JOOCFFIKAOB MEPLKNIGBCO<T>(string JAOOJJKNLDO, T PAHKKNONPEO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C08760", Offset = "0x2C07B60", VA = "0x182C08760")]
		public JOOCFFIKAOB OAHFGBMKOGD<T>(string JAOOJJKNLDO, T? PAHKKNONPEO) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x578F800", Offset = "0x578EC00", VA = "0x18578F800")]
		public JOOCFFIKAOB OAHFGBMKOGD(string JAOOJJKNLDO, string PAHKKNONPEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x578F760", Offset = "0x578EB60", VA = "0x18578F760")]
		public DONEJHADFEN FCNEIHDKPOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1D10EC0", Offset = "0x1D102C0", VA = "0x181D10EC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ILCPHNNKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<ILCPHNNKAKB> JMPKBCBEIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string LFBEEOHBILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> IBGLCPIMJDP;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x578CA10", Offset = "0x578BE10", VA = "0x18578CA10")]
		private ILCPHNNKAKB(string LFBEEOHBILH, int IENHMGCHNBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x578C670", Offset = "0x578BA70", VA = "0x18578C670")]
		public static JOOCFFIKAOB CNMCABBAMHK(string LFBEEOHBILH, int IENHMGCHNBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x578C780", Offset = "0x578BB80", VA = "0x18578C780")]
		public DONEJHADFEN FCNEIHDKPOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x578C9A0", Offset = "0x578BDA0", VA = "0x18578C9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24AFB10", Offset = "0x24AEF10", VA = "0x1824AFB10")]
		internal void ENNNOEDLHCO<T>(string JAOOJJKNLDO, T PAHKKNONPEO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x578C720", Offset = "0x578BB20", VA = "0x18578C720")]
		internal void ENNNOEDLHCO(string JAOOJJKNLDO, string PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2C075B0", Offset = "0x2C069B0", VA = "0x182C075B0")]
		private void MICGLAPJBHN<T>(string JAOOJJKNLDO, T PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BALDCDEIFPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string FPEJOEGDABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? GJKPNGNLLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? KFDMKJNBPDJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x578AB30", Offset = "0x5789F30", VA = "0x18578AB30")]
		public BALDCDEIFPC(string OEJINLBEBKH, [Optional] long? JFLKHKDOLFI, [Optional] short? CFCOINMENPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CBPKAFHGOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int PGALMIJMFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string NCCDFOGCEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short JNFKDOKENPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string MNIFADOOLNG;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x578AB70", Offset = "0x5789F70", VA = "0x18578AB70")]
		public CBPKAFHGOLI(int LEJLHDJKPLG, string LOJKOHGGEMD, short FIOAPDJOLBN, string KHNNICPMIKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MIPOICBGLCA : JAOODEHMGNC<MANCKAJCPKD, CBPKAFHGOLI, BALDCDEIFPC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string LOJKOHGGEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short FIOAPDJOLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string KHNNICPMIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> IOGNEBDNEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MOHJCKPDFGN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57915B0", Offset = "0x57909B0", VA = "0x1857915B0")]
		public MIPOICBGLCA(string HHKJMGDMIGK, Guid CCDIPOJKKAF, long EDHFPGBPPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x57903F0", Offset = "0x578F7F0", VA = "0x1857903F0", Slot = "4")]
		public override void HJJFBOMGPNP(CBPKAFHGOLI BDBAIKJMLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x57914D0", Offset = "0x57908D0", VA = "0x1857914D0")]
		public void OJNHELLFGMG(short FIOAPDJOLBN, bool MIEOOEFEAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3638EF0", Offset = "0x36382F0", VA = "0x183638EF0")]
		public void GPMMLGLJCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x792F50", Offset = "0x792350", VA = "0x180792F50")]
		public void CNBKAKLGJCL(string DKNDMDCJNIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57906E0", Offset = "0x578FAE0", VA = "0x1857906E0", Slot = "5")]
		public override void KAALOOEBBDJ(bool CJACMJKHMID, BALDCDEIFPC HGNLHACLNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5790130", Offset = "0x578F530", VA = "0x185790130", Slot = "6")]
		public override EBMICHOCENF HJANMICAKII(MANCKAJCPKD DMBDLMNAGKE, int FGBBDGJMFEH, string IIGLBKKMIEK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PFEMDGNFHKG : EBMICHOCENF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string LOJKOHGGEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short FIOAPDJOLBN;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5792D20", Offset = "0x5792120", VA = "0x185792D20")]
		public PFEMDGNFHKG(long HPIELIGPHKI, int LEJLHDJKPLG, string KBECCPLOKDP, long EDHFPGBPPLM, int GDHDDDLFONE, string PMKAFIGADDK, short FIOAPDJOLBN, string LOJKOHGGEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5792B60", Offset = "0x5791F60", VA = "0x185792B60")]
		public void AFLAABPFDLM(int LEJLHDJKPLG, string LOJKOHGGEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5792BF0", Offset = "0x5791FF0", VA = "0x185792BF0", Slot = "5")]
		public override JOOCFFIKAOB JMHEDGEMBKC(Guid ONGEFBKHPDG, string BODEPOINBLC, [Optional] string KBECCPLOKDP, [Optional] long? FDJCLHKPCBI, [Optional] string PMKAFIGADDK, [Optional] string JECOLECBLOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class PNHDBJNJFMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct MINKJDCGOGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int BMDANECAJMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int KEGMKIFFOHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int HJIINLELANF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int DMOOGDICEFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int GCAJGKJFEGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int DMIHABEAHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int DPHINEIAKOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int KADBBPGMFDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int LOLOGIEGEJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int PBLFGHGECJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int FOGBMFFHOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int FDJBBKMBFGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int EBIAGJNCAIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int NIIDHKEPBAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int EBNEBDCDGBB;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x57900C0", Offset = "0x578F4C0", VA = "0x1857900C0")]
			public MINKJDCGOGJ(int ABCAPCFALLC, int JEKODBLMHEC, int DIBPFDNIDNG, int OAEACBHDPMN, int FHJPIIGNHPC, int MJPEOOHPAJA, int KBPKNNPIPHB, int DLHOMGDALEK, int JBECMIJACHL, int GFBNFOGOJJL, int HFBMANODEHG, int FPDJMNKDCFK, int PGLGCMPJHJJ, int CEOMEJGMDIJ, int EIICIGOFJAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? CKFNGLKNBOA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> PFEPMOLJOBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5792E10", Offset = "0x5792210", VA = "0x185792E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5792ED0", Offset = "0x57922D0", VA = "0x185792ED0")]
		public static void OJNAMEPMKLB(MINKJDCGOGJ OFOPAOGIADE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class NJOBGOOGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5791630", Offset = "0x5790A30", VA = "0x185791630")]
		public static void EJPPHKNBJIE(string CONEAMPCFEL, object GHOKKFDEKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57916A0", Offset = "0x5790AA0", VA = "0x1857916A0")]
		public static void EJPPHKNBJIE(string CONEAMPCFEL, CECGDKLBKDI GHOKKFDEKNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FFBGFPOKOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x578BCC0", Offset = "0x578B0C0", VA = "0x18578BCC0")]
		public static void HMFLICAHDPK(float3 BCGGHPIMKDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class EMIIDPNBPOF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DOMALHNIDEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public EMIIDPNBPOF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public DOMALHNIDEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4FB8350", Offset = "0x4FB7750", VA = "0x184FB8350")]
			internal object NKIEPOGOPGB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CGELFKLPALK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public EMIIDPNBPOF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public CGELFKLPALK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4AA04A0", Offset = "0x4A9F8A0", VA = "0x184AA04A0")]
			internal object BNPPAOGAJLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EHDAHLLNOPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public EMIIDPNBPOF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public EHDAHLLNOPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x32BD660", Offset = "0x32BCA60", VA = "0x1832BD660")]
			internal object NIKMIDNMILG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DIMHCDINBIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public EMIIDPNBPOF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public long elementId;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public DIMHCDINBIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4F9AE80", Offset = "0x4F9A280", VA = "0x184F9AE80")]
			internal object CFIKDKMCIDA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float NFHGACKPLKF = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid ONGEFBKHPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string PMKAFIGADDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string BPIOHOOKEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string OLCILKOOKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string JECOLECBLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string HHAIAIAOMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string LKOLOKOPLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string FBJABJMAADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string MLGNJIAIOLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string FPOKPFGGAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private IEnumerable<int?> FHIJFPPFFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HashSet<T> EMIIBJOCFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Dictionary<(T, int), string> PEPCMAFKAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), float> LLBBIIOMGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<long, string> APEBFGEEANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool MMELNLHMJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private DONEJHADFEN IEDLAIFADIL;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32EA2C0", Offset = "0x32E96C0", VA = "0x1832EA2C0")]
		public EMIIDPNBPOF(Guid ONGEFBKHPDG, string BPIOHOOKEHF, string PMKAFIGADDK, string OLCILKOOKFI, [Optional] string JECOLECBLOF, [Optional] string HHAIAIAOMGL, [Optional] string LKOLOKOPLEK, [Optional] string FPOKPFGGAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7940F0", Offset = "0x7934F0", VA = "0x1807940F0")]
		public void NHLAOAEMKGL(string JECOLECBLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
		public void LBBDNGONLEM(string OLCILKOOKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x792F60", Offset = "0x792360", VA = "0x180792F60")]
		public void PINCMLECPFI(string FBJABJMAADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x792F80", Offset = "0x792380", VA = "0x180792F80")]
		public void GEGLDOAAAEO(string MLGNJIAIOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32E4660", Offset = "0x32E3A60", VA = "0x1832E4660")]
		public void CNKLKPIBNNN(T FDJCLHKPCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x32E8020", Offset = "0x32E7420", VA = "0x1832E8020")]
		public void IKHKHEKMOAP(T FDJCLHKPCBI, int CMLHDBJOBBN, float NNDGBAFPCAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32E5380", Offset = "0x32E4780", VA = "0x1832E5380")]
		public void EFNAGJPEBFN(T FDJCLHKPCBI, int CMLHDBJOBBN, string IEANLOPOEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x32E4A80", Offset = "0x32E3E80", VA = "0x1832E4A80")]
		public void DIMDDJCGIHD(long FDJCLHKPCBI, string CDOMPFDIOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x32E45C0", Offset = "0x32E39C0", VA = "0x1832E45C0")]
		public void AEKDEMHAFOL(IEnumerable<int?> HBIIFIJGLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x32E6230", Offset = "0x32E5630", VA = "0x1832E6230")]
		public DONEJHADFEN FCNEIHDKPOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32E8F30", Offset = "0x32E8330", VA = "0x1832E8F30")]
		private (string, string) NJGPPHBPHNN()
		{
			return default((string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32E9530", Offset = "0x32E8930", VA = "0x1832E9530")]
		public static JOOCFFIKAOB OGPOGDOGEEL(Guid ONGEFBKHPDG, string BPIOHOOKEHF, T FDJCLHKPCBI, string PMKAFIGADDK, string LIOHDAAADED, string JECOLECBLOF, int? FGBBDGJMFEH, [Optional] string MEPNHNIFPDM, [Optional] string CDOMPFDIOPC, [Optional] int? ACMAFGGNOAJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class JAOODEHMGNC<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string HHKJMGDMIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid CCDIPOJKKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long EDHFPGBPPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int LEJLHDJKPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int CCKPDCBENLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime NJHALIHADLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool HPHJELPMNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, EBMICHOCENF> LNJLIBJPECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool LEGOJKEEHGB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PEEHDGOMBAP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x81FE30", Offset = "0x81F230", VA = "0x18081FE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CMLNOPCKNIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCBAB80", Offset = "0xCB9F80", VA = "0x180CBAB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA69A0", Offset = "0x3AA5DA0", VA = "0x183AA69A0")]
		public JAOODEHMGNC(string HHKJMGDMIGK, Guid CCDIPOJKKAF, long EDHFPGBPPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void HJJFBOMGPNP(TListSessionStartParams BDBAIKJMLJA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6720", Offset = "0x3AA5B20", VA = "0x183AA6720")]
		public void IALJKGIKPGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KAALOOEBBDJ(bool CJACMJKHMID, TListSessionLogParams HGNLHACLNFF);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3AA65B0", Offset = "0x3AA59B0", VA = "0x183AA65B0")]
		public void BNAGCGJNHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6730", Offset = "0x3AA5B30", VA = "0x183AA6730")]
		public void MEIFJMINIMK(long HPIELIGPHKI, int FGBBDGJMFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6600", Offset = "0x3AA5A00", VA = "0x183AA6600")]
		public void EFCJDMGEGCE(long HPIELIGPHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract EBMICHOCENF HJANMICAKII(TItem JCBFPBHHLOH, int FGBBDGJMFEH, string IIGLBKKMIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class EBMICHOCENF : LCGAIFAGOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int LEJLHDJKPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long HPIELIGPHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long EDHFPGBPPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string HJCADBLOPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string EHJEMJJIIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int GDHDDDLFONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime MLGAJGHKLDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double GMLLIAEMGFC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NHONDLOOFGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC4EEB0", Offset = "0xC4E2B0", VA = "0x180C4EEB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xC4EEC0", Offset = "0xC4E2C0", VA = "0x180C4EEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x578BBF0", Offset = "0x578AFF0", VA = "0x18578BBF0")]
		public EBMICHOCENF(long HPIELIGPHKI, int LEJLHDJKPLG, string KBECCPLOKDP, long EDHFPGBPPLM, int GDHDDDLFONE, [Optional] string PMKAFIGADDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x578B570", Offset = "0x578A970", VA = "0x18578B570")]
		public void CLNCPEDCGFA(int LEJLHDJKPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x578B5E0", Offset = "0x578A9E0", VA = "0x18578B5E0")]
		public void HPOCGEDDDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x578BAE0", Offset = "0x578AEE0", VA = "0x18578BAE0")]
		public void LINJODLDIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x578B500", Offset = "0x578A900", VA = "0x18578B500")]
		private void ACFAAAGJMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x578B630", Offset = "0x578AA30", VA = "0x18578B630", Slot = "5")]
		public virtual JOOCFFIKAOB JMHEDGEMBKC(Guid ONGEFBKHPDG, string BODEPOINBLC, [Optional] string KBECCPLOKDP, [Optional] long? FDJCLHKPCBI, [Optional] string PMKAFIGADDK, [Optional] string JECOLECBLOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JAPOABKNAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class AEPHOABHIGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public AEPHOABHIGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x578AA90", Offset = "0x5789E90", VA = "0x18578AA90")]
			internal bool DLGMONMKONC()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct NPLPPPMEHMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private AEPHOABHIGH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x57918C0", Offset = "0x5790CC0", VA = "0x1857918C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5792A80", Offset = "0x5791E80", VA = "0x185792A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float PLAAAJOBDAM;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> BBJJEBLDLKG;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> FIECHAMDIAI;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string BMGKMCDCPNJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? ALIBFGIIAOD;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int IGPOPKLOHBE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static bool LFKNGLJOIHE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Dictionary<string, GEMJPFGHNML> AMHFGIPFFPO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly DECPPMKECOG BLLEHMDBFDN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static ALPEHOGHKBH? GKLMEMCHCKL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string FPGMGNEGOOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x578E750", Offset = "0x578DB50", VA = "0x18578E750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x578DA80", Offset = "0x578CE80", VA = "0x18578DA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? EOMOPJDMKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x578EE30", Offset = "0x578E230", VA = "0x18578EE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x578DF30", Offset = "0x578D330", VA = "0x18578DF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PPGOLPCGKFN GAGEIBONHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x578CD60", Offset = "0x578C160", VA = "0x18578CD60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private static bool LGOFMKCLFFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x578ED90", Offset = "0x578E190", VA = "0x18578ED90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x578F270", Offset = "0x578E670", VA = "0x18578F270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool JIGIEGGJCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x578EDE0", Offset = "0x578E1E0", VA = "0x18578EDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x578E7A0", Offset = "0x578DBA0", VA = "0x18578E7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static float CIMBOGEJFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x578DDE0", Offset = "0x578D1E0", VA = "0x18578DDE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x578F490", Offset = "0x578E890", VA = "0x18578F490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x578EEA0", Offset = "0x578E2A0", VA = "0x18578EEA0")]
		public static void MJEHICHLOFN(string DECJJIHKENO, GEMJPFGHNML LEPKBABCNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x578D620", Offset = "0x578CA20", VA = "0x18578D620")]
		private static void DNOMICJNBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x578DB40", Offset = "0x578CF40", VA = "0x18578DB40")]
		internal static void FILODNFGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x578F2D0", Offset = "0x578E6D0", VA = "0x18578F2D0")]
		internal static void PHGCODCDGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x578DE30", Offset = "0x578D230", VA = "0x18578DE30")]
		internal static void GKBJCBCBIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x578E030", Offset = "0x578D430", VA = "0x18578E030")]
		public static Guid HJJFBOMGPNP(string DECJJIHKENO, [Optional] string? FBDBOIDBBGM, [Optional] Dictionary<string, object>? BDNACECHFCB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x578DF90", Offset = "0x578D390", VA = "0x18578DF90")]
		public static Guid HJJFBOMGPNP(string DECJJIHKENO, long FBDBOIDBBGM, [Optional] Dictionary<string, object>? BDNACECHFCB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x578E570", Offset = "0x578D970", VA = "0x18578E570")]
		public static void IALJKGIKPGI(string DECJJIHKENO, [Optional] Guid? EFNPBHMDENF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x578EF30", Offset = "0x578E330", VA = "0x18578EF30")]
		public static void NHGOLCNCHGH(string DECJJIHKENO, string EABHCILPPLI, object LMHFEJNIFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x578E800", Offset = "0x578DC00", VA = "0x18578E800")]
		public static bool JNJEDFDPHAP(string DECJJIHKENO, [Optional] string? FBDBOIDBBGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x578F130", Offset = "0x578E530", VA = "0x18578F130")]
		private static void OGMOKOELEEK(bool GOEOPICFHFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x578EB80", Offset = "0x578DF80", VA = "0x18578EB80")]
		internal static void KFNNNGKCLNL(string AOGDICEMNLI, string CONEAMPCFEL, object GMLIPIALCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x578E9F0", Offset = "0x578DDF0", VA = "0x18578E9F0")]
		internal static void KFNNNGKCLNL(string AOGDICEMNLI, Dictionary<string, object> KHBDFCDIBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x578ED10", Offset = "0x578E110", VA = "0x18578ED10")]
		private static void KHEDDPGDEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x578DEE0", Offset = "0x578D2E0", VA = "0x18578DEE0")]
		public static void HFCGLCPFCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x578D300", Offset = "0x578C700", VA = "0x18578D300")]
		private static void DAKKHIAKDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x578CDB0", Offset = "0x578C1B0", VA = "0x18578CDB0")]
		private static void CKHMCCEPGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x578DD10", Offset = "0x578D110", VA = "0x18578DD10")]
		[AsyncStateMachine(typeof(NPLPPPMEHMH))]
		private static Task FPKBGDNCBEM(CancellationToken HHHPDCGPCML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x578CE90", Offset = "0x578C290", VA = "0x18578CE90")]
		private static void CNLFLKANIBO(string DECJJIHKENO, Guid ONGEFBKHPDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class FGLCKHHLOJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct BPOMPBFOPEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public bool NMDELEBPBKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string CEFPGGFPHAK;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x17A8030", Offset = "0x17A7430", VA = "0x1817A8030")]
			public BPOMPBFOPEP(bool NMDELEBPBKE, string CEFPGGFPHAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x578BDD0", Offset = "0x578B1D0", VA = "0x18578BDD0")]
		public static BPOMPBFOPEP AOEJNDMBIGP(JOOCFFIKAOB LBJNGELJJOA)
		{
			return default(BPOMPBFOPEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x578C1B0", Offset = "0x578B5B0", VA = "0x18578C1B0")]
		private static void POJEGNINOKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x578C0F0", Offset = "0x578B4F0", VA = "0x18578C0F0")]
		private static void KNJKCHGNNLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DBFGMCIBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x578ADA0", Offset = "0x578A1A0", VA = "0x18578ADA0")]
		public static JOOCFFIKAOB MDDOIKBOGKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GLIILNHBCFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x578C4F0", Offset = "0x578B8F0", VA = "0x18578C4F0")]
		public static JOOCFFIKAOB LNGEPFILLAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x578C610", Offset = "0x578BA10", VA = "0x18578C610")]
		public static JOOCFFIKAOB PHNEFAMAHAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x578C550", Offset = "0x578B950", VA = "0x18578C550")]
		public static JOOCFFIKAOB MCJEFGMNFGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x578C370", Offset = "0x578B770", VA = "0x18578C370")]
		public static JOOCFFIKAOB IGMFMMOHNGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x578C3D0", Offset = "0x578B7D0", VA = "0x18578C3D0")]
		public static JOOCFFIKAOB IMIAOADOOGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x578C2B0", Offset = "0x578B6B0", VA = "0x18578C2B0")]
		public static JOOCFFIKAOB DFNDGCJPLGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x578C5B0", Offset = "0x578B9B0", VA = "0x18578C5B0")]
		public static JOOCFFIKAOB NBOPMBNJJGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x578C490", Offset = "0x578B890", VA = "0x18578C490")]
		public static JOOCFFIKAOB KOOAGLCGIFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x578C310", Offset = "0x578B710", VA = "0x18578C310")]
		public static JOOCFFIKAOB HBGGCJIACBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x578C430", Offset = "0x578B830", VA = "0x18578C430")]
		public static JOOCFFIKAOB KAILJDGPBNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class CPDFLOPIHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x578ABC0", Offset = "0x5789FC0", VA = "0x18578ABC0")]
		public static JOOCFFIKAOB PMAEILILDII(long JFLKHKDOLFI, long MAEPHJBACME, bool AOHDJCGJAML, string GDBHCCKGIGN, string KHJPAHFAFFO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KCDNMCBOOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x578FAC0", Offset = "0x578EEC0", VA = "0x18578FAC0")]
		public static JOOCFFIKAOB HMCEHGNKDBC(string LIINKPMBACE, string BEKADNNELEO, bool HAINGCIIIDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x578F890", Offset = "0x578EC90", VA = "0x18578F890")]
		public static JOOCFFIKAOB BCPPOIFKAFL(string AOGDICEMNLI, string GHIMFGPONMO, string OPDELHLJIPE, [Optional] int? ADODNCEHIMI, [Optional] double[] JPKLHNLDLLN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DMCNPJCEAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x578B3C0", Offset = "0x578A7C0", VA = "0x18578B3C0")]
		public static JOOCFFIKAOB OLNDAEJPALG(string NGEJGEFNBMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x578AEC0", Offset = "0x578A2C0", VA = "0x18578AEC0")]
		public static JOOCFFIKAOB GNPMPNHOLGF(string OFCHKELFLLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x578B4A0", Offset = "0x578A8A0", VA = "0x18578B4A0")]
		public static JOOCFFIKAOB PMFLLCBECOM(int IENHMGCHNBA, string ADLKEGECLOG, string NONJEEALACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x578AE00", Offset = "0x578A200", VA = "0x18578AE00")]
		public static JOOCFFIKAOB FGPNLAINGDF(int IENHMGCHNBA, string ADLKEGECLOG, string NONJEEALACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x578AE60", Offset = "0x578A260", VA = "0x18578AE60")]
		public static JOOCFFIKAOB GEBFEEGAHBC(int IENHMGCHNBA, string ADLKEGECLOG, string NONJEEALACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x578B360", Offset = "0x578A760", VA = "0x18578B360")]
		public static JOOCFFIKAOB NDNFGJMCFJB(int IENHMGCHNBA, string ADLKEGECLOG, string NONJEEALACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x578B210", Offset = "0x578A610", VA = "0x18578B210")]
		public static JOOCFFIKAOB KMNIFIHHIAL(string ADLKEGECLOG, string NONJEEALACK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x578AFA0", Offset = "0x578A3A0", VA = "0x18578AFA0")]
		private static JOOCFFIKAOB JMNBAMJFFIC(string HHKJMGDMIGK, int IENHMGCHNBA, string OHBMFJDOMNK, string PHJDICEOPFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x578B0E0", Offset = "0x578A4E0", VA = "0x18578B0E0")]
		private static JOOCFFIKAOB JMNBAMJFFIC(string HHKJMGDMIGK, string OHBMFJDOMNK, string PHJDICEOPFE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly KBKFCGENGMC AOEJNDMBIGP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static KGDLPKLBGOA NNBEDIJKHML;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static GACLONJEIFK INEHAHPBCHM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<JOOCFFIKAOB> ONPICLDPAFN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long EEIAJNPIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x578FD90", Offset = "0x578F190", VA = "0x18578FD90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x578FCB0", Offset = "0x578F0B0", VA = "0x18578FCB0")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_BeforeSceneLoad)]
	private static void EJIOIPMNJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x578FE80", Offset = "0x578F280", VA = "0x18578FE80")]
	private static void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x578FC30", Offset = "0x578F030", VA = "0x18578FC30")]
	public static JOOCFFIKAOB CPEPMJKJALA(string LFBEEOHBILH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x578C670", Offset = "0x578BA70", VA = "0x18578C670")]
	public static JOOCFFIKAOB CPEPMJKJALA(string LFBEEOHBILH, int IENHMGCHNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x578FF30", Offset = "0x578F330", VA = "0x18578FF30")]
	[PFGHMHCOGDP(HCKINNNGEKD.Unity_BeforeSceneLoad)]
	private static void KKDNBHOFBNI()
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
