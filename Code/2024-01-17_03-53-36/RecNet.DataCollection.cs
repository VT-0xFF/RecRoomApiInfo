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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x57561F0", Offset = "0x5754FF0", VA = "0x1857561F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BNMFDAAIGFH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> GHDEDCCMMHF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NIHLJDCNLPO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EDCJNAFMHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CAKELPNIMKK HPPHLLKJDBD(Guid KOMJBDMNNDA, string LHJNMMMKGOK, [Optional] string LJEJLHLHIGO, [Optional] long? BBBNHBNBLJG, [Optional] string GGPKLDOALCG, [Optional] string BDCDBLHEADI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MOJKPPFAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5755290", Offset = "0x5754090", VA = "0x185755290")]
		public static CAKELPNIMKK BKKLJHBKJCM(Guid KOMJBDMNNDA, string LHJNMMMKGOK, string LJEJLHLHIGO, [Optional] long? BBBNHBNBLJG, [Optional] string GGPKLDOALCG, [Optional] string BDCDBLHEADI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CAKELPNIMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected JPDNBLMPIKG LMNOBACJGBM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
		public CAKELPNIMKK(JPDNBLMPIKG LMNOBACJGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x574E820", Offset = "0x574D620", VA = "0x18574E820")]
		public CAKELPNIMKK MPPINLJEFMH(string LEDLMNEPNJE, string MBDKMNBCLGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6D00", Offset = "0x2BE5B00", VA = "0x182BE6D00")]
		public CAKELPNIMKK MPPINLJEFMH<T>(string LEDLMNEPNJE, T MBDKMNBCLGF) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6C00", Offset = "0x2BE5A00", VA = "0x182BE6C00")]
		public CAKELPNIMKK AFKBLDGEHFN<T>(string LEDLMNEPNJE, T? MBDKMNBCLGF) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x574E790", Offset = "0x574D590", VA = "0x18574E790")]
		public CAKELPNIMKK AFKBLDGEHFN(string LEDLMNEPNJE, string MBDKMNBCLGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x574E8A0", Offset = "0x574D6A0", VA = "0x18574E8A0")]
		public PCFNKHPOHAG NDKIDOBHPKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1D07F40", Offset = "0x1D06D40", VA = "0x181D07F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JPDNBLMPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<JPDNBLMPIKG> JNCFHHEMHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string LGOPJOBKNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> GKOANPLFIKM;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5754A60", Offset = "0x5753860", VA = "0x185754A60")]
		private JPDNBLMPIKG(string LGOPJOBKNHL, int PKODCKADBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5754720", Offset = "0x5753520", VA = "0x185754720")]
		public static CAKELPNIMKK KCGHAKHJLMB(string LGOPJOBKNHL, int PKODCKADBCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57547D0", Offset = "0x57535D0", VA = "0x1857547D0")]
		public PCFNKHPOHAG NDKIDOBHPKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x57549F0", Offset = "0x57537F0", VA = "0x1857549F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2717060", Offset = "0x2715E60", VA = "0x182717060")]
		internal void GMFJOPKGPPH<T>(string LEDLMNEPNJE, T MBDKMNBCLGF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57546C0", Offset = "0x57534C0", VA = "0x1857546C0")]
		internal void GMFJOPKGPPH(string LEDLMNEPNJE, string MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA7E0", Offset = "0x2BE95E0", VA = "0x182BEA7E0")]
		private void MPECHNIIEMD<T>(string LEDLMNEPNJE, T MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ANIOJCLEACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string AGCAKLNJIFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? JLPKEBAAFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? KHEAPAIMPKA;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x574DC80", Offset = "0x574CA80", VA = "0x18574DC80")]
		public ANIOJCLEACD(string KDCBEOBDMNK, [Optional] long? NJOOPBBHHDG, [Optional] short? LAGMLGCBBJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AMNNOBONKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int HFNDEHHKEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string FACCKMIAHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short ALNMALEPCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string FGMDNEIEPHA;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x574DC30", Offset = "0x574CA30", VA = "0x18574DC30")]
		public AMNNOBONKDD(int CNGLMGOFKAC, string EHCGENJCBLF, short GDOHLFJFOEM, string PCLGLHBBAHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class JFENJJIKGAL : OKGHMJDCIHN<BCGNGJBJGMI, AMNNOBONKDD, ANIOJCLEACD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string EHCGENJCBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short GDOHLFJFOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string PCLGLHBBAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> MNFJNEEJJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GHHOKGMOCBM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5754640", Offset = "0x5753440", VA = "0x185754640")]
		public JFENJJIKGAL(string MEEIELMNBGL, Guid OAJGFOEGIIK, long BIBKCOFJIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5753FB0", Offset = "0x5752DB0", VA = "0x185753FB0", Slot = "4")]
		public override void MGJPKLFFPMN(AMNNOBONKDD KDFIONACJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x57542A0", Offset = "0x57530A0", VA = "0x1857542A0")]
		public void MOCFANJJLDP(short GDOHLFJFOEM, bool HNPPHBJEDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35D2A40", Offset = "0x35D1840", VA = "0x1835D2A40")]
		public void JOLMFBOGKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x78E0B0", Offset = "0x78CEB0", VA = "0x18078E0B0")]
		public void KHMPGIBDAIM(string BDNHOKKEKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57531C0", Offset = "0x5751FC0", VA = "0x1857531C0", Slot = "5")]
		public override void FPDHPENOGMN(bool KFEACPDNEAB, ANIOJCLEACD ODDEJGDEEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5754380", Offset = "0x5753180", VA = "0x185754380", Slot = "6")]
		public override BMKBAAOPLLL OHHFGMGIAPO(BCGNGJBJGMI JFNCAKDLOGL, int HPLKFBKKIBG, string DPANFEOIIMA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BEBFDPHMLCG : BMKBAAOPLLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string EHCGENJCBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short GDOHLFJFOEM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x574DE80", Offset = "0x574CC80", VA = "0x18574DE80")]
		public BEBFDPHMLCG(long EICDFNEIANE, int CNGLMGOFKAC, string LJEJLHLHIGO, long BIBKCOFJIKA, int BCMGCPMABBJ, string GGPKLDOALCG, short GDOHLFJFOEM, string EHCGENJCBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x574DDF0", Offset = "0x574CBF0", VA = "0x18574DDF0")]
		public void PGFJFGLHJLP(int CNGLMGOFKAC, string EHCGENJCBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x574DCC0", Offset = "0x574CAC0", VA = "0x18574DCC0", Slot = "5")]
		public override CAKELPNIMKK HPPHLLKJDBD(Guid KOMJBDMNNDA, string LHJNMMMKGOK, [Optional] string LJEJLHLHIGO, [Optional] long? BBBNHBNBLJG, [Optional] string GGPKLDOALCG, [Optional] string BDCDBLHEADI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NENEBOJDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct PNKAOIADNHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int JFPKBADGAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int GGJKEBIFLJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int DOANMOBKLHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int FFKJMDMILNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int EMCKPBMFGCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int BECFGAOOIDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int JFMMIKKMLNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int FNIKKHOBGCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int DBBOPICCMBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int BNNJGEBMNIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int NIONICJHFLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int HILLBKJFMGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int KINANLFNGCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int DGMHHLOEKBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int DNPKCINJOPM;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5756A10", Offset = "0x5755810", VA = "0x185756A10")]
			public PNKAOIADNHM(int CLIFJMPDHBL, int LPNBEDGAAFM, int GKLAAMFEPPE, int HNHBJDGBHCE, int JNLGLKGAJEH, int DNCHCAADNEG, int CODPGPCGOCF, int EKHNEBPMAJM, int EHJLPJPHAIJ, int ENHEENMFFLO, int OJMFCHCOBBC, int LDMKJMKJFMP, int NMFKBNCKLDP, int HJNPAHCCODB, int DKDILBOKCGI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? PMKFEDIJPFF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> JABAGFINOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5755CA0", Offset = "0x5754AA0", VA = "0x185755CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x57554A0", Offset = "0x57542A0", VA = "0x1857554A0")]
		public static void DAFOALNACKM(PNKAOIADNHM IJCJOHAAHHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EIBDANFAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x574FEE0", Offset = "0x574ECE0", VA = "0x18574FEE0")]
		public static void DJFJJNNEOIF(string IDGIKKEFDCG, object KJDBLNKCCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x574FCC0", Offset = "0x574EAC0", VA = "0x18574FCC0")]
		public static void DJFJJNNEOIF(string IDGIKKEFDCG, KGAHFFONDEH KJDBLNKCCEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class GELGFKGKEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x57506B0", Offset = "0x574F4B0", VA = "0x1857506B0")]
		public static void MBEEIOPHOON(float3 MHFADBEELBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BBLFJEBJEGP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FLGFGIGHMDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public BBLFJEBJEGP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public FLGFGIGHMDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x361A3E0", Offset = "0x36191E0", VA = "0x18361A3E0")]
			internal object LDAIIKKGHAB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class POMLJHACLCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public BBLFJEBJEGP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public POMLJHACLCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x40542C0", Offset = "0x40530C0", VA = "0x1840542C0")]
			internal object AEFEIOECOAF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HKJCEHPAPCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public BBLFJEBJEGP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public HKJCEHPAPCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3759820", Offset = "0x3758620", VA = "0x183759820")]
			internal object CMMMHENKONE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class BMMIEJCOMCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public BBLFJEBJEGP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public long elementId;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public BMMIEJCOMCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x46B1E70", Offset = "0x46B0C70", VA = "0x1846B1E70")]
			internal object NIOHOOHJDGK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float CKLFNNDPKBI = 0.01f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid KOMJBDMNNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string GGPKLDOALCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string MNCAKEDBFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string JCGOLIPICAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string BDCDBLHEADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string EFAOPPNLAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string EOLBNPJGHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string ABICEAFKBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string DFMLECLFFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string FLFAGEGCMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private IEnumerable<int?> CPBJPLFOKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly HashSet<T> DKLFPFCOJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly Dictionary<(T, int), string> LMDCAKFOFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), float> BNIIPGGDKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<long, string> JBJCKIAODFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool FGNLPMELKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private PCFNKHPOHAG KCBDMCDKPFP;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46673D0", Offset = "0x46661D0", VA = "0x1846673D0")]
		public BBLFJEBJEGP(Guid KOMJBDMNNDA, string MNCAKEDBFHC, string GGPKLDOALCG, string JCGOLIPICAJ, [Optional] string BDCDBLHEADI, [Optional] string EFAOPPNLAIJ, [Optional] string EOLBNPJGHON, [Optional] string FLFAGEGCMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0")]
		public void DOMLDOFFABA(string BDCDBLHEADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
		public void ILLHHIEMDIO(string JCGOLIPICAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78D1C0", Offset = "0x78BFC0", VA = "0x18078D1C0")]
		public void NMIALADFOPG(string ABICEAFKBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78D1D0", Offset = "0x78BFD0", VA = "0x18078D1D0")]
		public void HLLMLCJJFBG(string DFMLECLFFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46633C0", Offset = "0x46621C0", VA = "0x1846633C0")]
		public void LAGDFBLMDMK(T BBBNHBNBLJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4666690", Offset = "0x4665490", VA = "0x184666690")]
		public void NJMDMDCBHIJ(T BBBNHBNBLJG, int CHHMMKDDGCA, float OGMFDJJPFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4663D40", Offset = "0x4662B40", VA = "0x184663D40")]
		public void NCKMBCPELFM(T BBBNHBNBLJG, int CHHMMKDDGCA, string JOCNPJGKCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4663680", Offset = "0x4662480", VA = "0x184663680")]
		public void MFOPEIAEPHD(long BBBNHBNBLJG, string OJJEFDPEBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4667080", Offset = "0x4665E80", VA = "0x184667080")]
		public void OLDEHODGEIM(IEnumerable<int?> DFGDIOJBBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4664200", Offset = "0x4663000", VA = "0x184664200")]
		public PCFNKHPOHAG NDKIDOBHPKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4662070", Offset = "0x4660E70", VA = "0x184662070")]
		private (string, string) DODJHEKPOBL()
		{
			return default((string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4661B00", Offset = "0x4660900", VA = "0x184661B00")]
		public static CAKELPNIMKK AAMLEBDFKDC(Guid KOMJBDMNNDA, string MNCAKEDBFHC, T BBBNHBNBLJG, string GGPKLDOALCG, string KKPDGPDEHNH, string BDCDBLHEADI, int? HPLKFBKKIBG, [Optional] string GGEOILILIFB, [Optional] string OJJEFDPEBBB, [Optional] int? KBHDPNEOCME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class OKGHMJDCIHN<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string MEEIELMNBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid OAJGFOEGIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long BIBKCOFJIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int CNGLMGOFKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int AFGHAKPEHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime GKHAMPIKGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool PIBGKCBJEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, BMKBAAOPLLL> KKNPKIDCGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool GDPEHJJCIDA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DABADEKAIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x820460", Offset = "0x81F260", VA = "0x180820460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ECIJJHLIOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xCBF9B0", Offset = "0xCBE7B0", VA = "0x180CBF9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7600", Offset = "0x3EF6400", VA = "0x183EF7600")]
		public OKGHMJDCIHN(string MEEIELMNBGL, Guid OAJGFOEGIIK, long BIBKCOFJIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void MGJPKLFFPMN(TListSessionStartParams KDFIONACJFN);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6BB0", Offset = "0x3DF59B0", VA = "0x183DF6BB0")]
		public void DGBHAGNIGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FPDHPENOGMN(bool KFEACPDNEAB, TListSessionLogParams ODDEJGDEEIK);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7220", Offset = "0x3EF6020", VA = "0x183EF7220")]
		public void ALIAECONPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7390", Offset = "0x3EF6190", VA = "0x183EF7390")]
		public void INNLMEKLBEN(long EICDFNEIANE, int HPLKFBKKIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7300", Offset = "0x3EF6100", VA = "0x183EF7300")]
		public void FJENONLLGNF(long EICDFNEIANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract BMKBAAOPLLL OHHFGMGIAPO(TItem KMBHPJEIFIH, int HPLKFBKKIBG, string DPANFEOIIMA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class BMKBAAOPLLL : EDCJNAFMHOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int CNGLMGOFKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long EICDFNEIANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long BIBKCOFJIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string KDBGEKKBOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string HLOFCGBAJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int BCMGCPMABBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime IGCIILKLJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double KBEDENPKIMC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MPOLKKCLMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xC6A770", Offset = "0xC69570", VA = "0x180C6A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xC6AAA0", Offset = "0xC698A0", VA = "0x180C6AAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x574E6C0", Offset = "0x574D4C0", VA = "0x18574E6C0")]
		public BMKBAAOPLLL(long EICDFNEIANE, int CNGLMGOFKAC, string LJEJLHLHIGO, long BIBKCOFJIKA, int BCMGCPMABBJ, [Optional] string GGPKLDOALCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x574DFD0", Offset = "0x574CDD0", VA = "0x18574DFD0")]
		public void CFGCJGMEDKI(int CNGLMGOFKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x574E040", Offset = "0x574CE40", VA = "0x18574E040")]
		public void EGAPCNDPFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x574E5B0", Offset = "0x574D3B0", VA = "0x18574E5B0")]
		public void OEBPJKGJJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x574E540", Offset = "0x574D340", VA = "0x18574E540")]
		private void NIEJDFOJBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x574E090", Offset = "0x574CE90", VA = "0x18574E090", Slot = "5")]
		public virtual CAKELPNIMKK HPPHLLKJDBD(Guid KOMJBDMNNDA, string LHJNMMMKGOK, [Optional] string LJEJLHLHIGO, [Optional] long? BBBNHBNBLJG, [Optional] string GGPKLDOALCG, [Optional] string BDCDBLHEADI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class IELNIHIKJLM
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PCBOMGBNDIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public PCBOMGBNDIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5756270", Offset = "0x5755070", VA = "0x185756270")]
			internal bool LGIKPPGDJPJ()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct CJFNMOHDLAD : IAsyncStateMachine
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
			private PCBOMGBNDIC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x574E8C0", Offset = "0x574D6C0", VA = "0x18574E8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x574FA80", Offset = "0x574E880", VA = "0x18574FA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float NHNBJKDCDFO;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> PPCLOIFFHGC;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> MDJIHGMOBBP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string AAEDPOMBNPF;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? MILFBNFJFGE;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int PIIPHDCIOCJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static bool ADLLOMDFIFI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Dictionary<string, BNMFDAAIGFH> DBHLDBHCAKK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly AHOMABILGKI PMHOBIDGFHJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static BDJLMAGOJGM? HNKIDNCIPCN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string GIJHCMFOLEN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5751F30", Offset = "0x5750D30", VA = "0x185751F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5752B20", Offset = "0x5751920", VA = "0x185752B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? NPDMNPCDLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5751270", Offset = "0x5750070", VA = "0x185751270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5751990", Offset = "0x5750790", VA = "0x185751990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static EBNMHIGEHAA MINIPFBONEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5751120", Offset = "0x574FF20", VA = "0x185751120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private static bool MHEDJABBADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x57511C0", Offset = "0x574FFC0", VA = "0x1857511C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5751210", Offset = "0x5750010", VA = "0x185751210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool BGLLLNBKFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5752BE0", Offset = "0x57519E0", VA = "0x185752BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5751F80", Offset = "0x5750D80", VA = "0x185751F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static float FHKBOEBIJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x57527B0", Offset = "0x57515B0", VA = "0x1857527B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5751930", Offset = "0x5750730", VA = "0x185751930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5750980", Offset = "0x574F780", VA = "0x185750980")]
		public static void BJNBKBCCPHN(string DLKAFNPCJPA, BNMFDAAIGFH ILEAFHKBHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x57514D0", Offset = "0x57502D0", VA = "0x1857514D0")]
		private static void GIGFGFBHNMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5750A10", Offset = "0x574F810", VA = "0x185750A10")]
		internal static void CGDOOEBPPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x57507C0", Offset = "0x574F5C0", VA = "0x1857507C0")]
		internal static void BADNKBLIEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5751FE0", Offset = "0x5750DE0", VA = "0x185751FE0")]
		internal static void LJLIDGIADMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x57521D0", Offset = "0x5750FD0", VA = "0x1857521D0")]
		public static Guid MGJPKLFFPMN(string DLKAFNPCJPA, [Optional] string? GHDHDGPMDMA, [Optional] Dictionary<string, object>? AIGBGLPKDCE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5752710", Offset = "0x5751510", VA = "0x185752710")]
		public static Guid MGJPKLFFPMN(string DLKAFNPCJPA, long GHDHDGPMDMA, [Optional] Dictionary<string, object>? AIGBGLPKDCE)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5750BE0", Offset = "0x574F9E0", VA = "0x185750BE0")]
		public static void DGBHAGNIGJI(string DLKAFNPCJPA, [Optional] Guid? FILMEIPENDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5750E40", Offset = "0x574FC40", VA = "0x185750E40")]
		public static void DIPDKJPDHNF(string DLKAFNPCJPA, string MGNEKNALGOL, object LJHPJHLKELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57512E0", Offset = "0x57500E0", VA = "0x1857512E0")]
		public static bool GGPCJMDAMCF(string DLKAFNPCJPA, [Optional] string? GHDHDGPMDMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5752090", Offset = "0x5750E90", VA = "0x185752090")]
		private static void LOMJAAEOIMI(bool EKAFJFMNMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5752DC0", Offset = "0x5751BC0", VA = "0x185752DC0")]
		internal static void PHLHFMPDLEL(string BCCEHJNGNAL, string IDGIKKEFDCG, object HKPHNGEBIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5752C30", Offset = "0x5751A30", VA = "0x185752C30")]
		internal static void PHLHFMPDLEL(string BCCEHJNGNAL, Dictionary<string, object> PBMGHICHJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5750DC0", Offset = "0x574FBC0", VA = "0x185750DC0")]
		private static void DHGMMGNOEOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5751170", Offset = "0x574FF70", VA = "0x185751170")]
		public static void FECACFLFNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5752800", Offset = "0x5751600", VA = "0x185752800")]
		private static void OGMPMALHEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5751040", Offset = "0x574FE40", VA = "0x185751040")]
		private static void ELEOPMDCCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5751E60", Offset = "0x5750C60", VA = "0x185751E60")]
		[AsyncStateMachine(typeof(CJFNMOHDLAD))]
		private static Task HOBOHFHFELL(CancellationToken EHAEIHNIHFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x57519F0", Offset = "0x57507F0", VA = "0x1857519F0")]
		private static void HLEJICPMEKN(string DLKAFNPCJPA, Guid KOMJBDMNNDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class KCGIAIKEEBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct LOANBALJHAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public bool BAENCCECFMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string CPHLJEKFBPB;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x17A3780", Offset = "0x17A2580", VA = "0x1817A3780")]
			public LOANBALJHAI(bool BAENCCECFMB, string CPHLJEKFBPB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5754E70", Offset = "0x5753C70", VA = "0x185754E70")]
		public static LOANBALJHAI FPLGBFAGNKF(CAKELPNIMKK ALEJMHDHGNA)
		{
			return default(LOANBALJHAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5755190", Offset = "0x5753F90", VA = "0x185755190")]
		private static void MPBFEMBCJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5754DB0", Offset = "0x5753BB0", VA = "0x185754DB0")]
		private static void FBGJOFABHII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BJCOFLGLNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x574DF70", Offset = "0x574CD70", VA = "0x18574DF70")]
		public static CAKELPNIMKK KKGHKOCEGED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class FPJPLNCLKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x574FF50", Offset = "0x574ED50", VA = "0x18574FF50")]
		public static CAKELPNIMKK AMCHBJGEJHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x57501F0", Offset = "0x574EFF0", VA = "0x1857501F0")]
		public static CAKELPNIMKK LLDHJAMNOCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57500D0", Offset = "0x574EED0", VA = "0x1857500D0")]
		public static CAKELPNIMKK IFBGJKAPOEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5750070", Offset = "0x574EE70", VA = "0x185750070")]
		public static CAKELPNIMKK HAFOMEGPION()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57502B0", Offset = "0x574F0B0", VA = "0x1857502B0")]
		public static CAKELPNIMKK MDGDMDCAGNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5750130", Offset = "0x574EF30", VA = "0x185750130")]
		public static CAKELPNIMKK KACDLJPCHFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5750250", Offset = "0x574F050", VA = "0x185750250")]
		public static CAKELPNIMKK MBCGPMADBLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x574FFB0", Offset = "0x574EDB0", VA = "0x18574FFB0")]
		public static CAKELPNIMKK DIPEGGENOCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5750010", Offset = "0x574EE10", VA = "0x185750010")]
		public static CAKELPNIMKK GOBLNDPMPAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5750190", Offset = "0x574EF90", VA = "0x185750190")]
		public static CAKELPNIMKK LIBFEJOOKMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class DFHJAGFLBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x574FAE0", Offset = "0x574E8E0", VA = "0x18574FAE0")]
		public static CAKELPNIMKK JDCIHGANGAL(long NJOOPBBHHDG, long FMAMGAOCPGI, bool PENONMDPDEH, string IDIHPOJCOAK, string NMKDIEFAEAP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GDHONMABDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5750540", Offset = "0x574F340", VA = "0x185750540")]
		public static CAKELPNIMKK GMHGAOGFGLB(string OPIDPHJKENK, string ILLOHMGDMHB, bool GNMNPNEKEOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5750310", Offset = "0x574F110", VA = "0x185750310")]
		public static CAKELPNIMKK EEHIPGCLJOB(string BCCEHJNGNAL, string JANPDFNBGKD, string OOPBPPCLJMB, [Optional] int? PPOKHPCJLBJ, [Optional] double[] MBDDCKNNMPI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PLFLCKEEFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5756660", Offset = "0x5755460", VA = "0x185756660")]
		public static CAKELPNIMKK HJOEBACENMA(string GNDNAAOIHNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5756520", Offset = "0x5755320", VA = "0x185756520")]
		public static CAKELPNIMKK EOGHPDNFAGN(string BNMBDLJOPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x57564C0", Offset = "0x57552C0", VA = "0x1857564C0")]
		public static CAKELPNIMKK EMJOPFDJHGI(int PKODCKADBCG, string AOAIBMOPKPE, string JDEPDKNELPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5756600", Offset = "0x5755400", VA = "0x185756600")]
		public static CAKELPNIMKK FOGDLJFFJBI(int PKODCKADBCG, string AOAIBMOPKPE, string JDEPDKNELPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5756310", Offset = "0x5755110", VA = "0x185756310")]
		public static CAKELPNIMKK BJKJLAOLCOG(int PKODCKADBCG, string AOAIBMOPKPE, string JDEPDKNELPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57569B0", Offset = "0x57557B0", VA = "0x1857569B0")]
		public static CAKELPNIMKK MPEBMCIJOPP(int PKODCKADBCG, string AOAIBMOPKPE, string JDEPDKNELPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5756370", Offset = "0x5755170", VA = "0x185756370")]
		public static CAKELPNIMKK BPPDPGPANLB(string AOAIBMOPKPE, string JDEPDKNELPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5756740", Offset = "0x5755540", VA = "0x185756740")]
		private static CAKELPNIMKK HNPICDIMFFL(string MEEIELMNBGL, int PKODCKADBCG, string ILOCFCPBMOC, string AGPHOFEIIFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5756880", Offset = "0x5755680", VA = "0x185756880")]
		private static CAKELPNIMKK HNPICDIMFFL(string MEEIELMNBGL, string ILOCFCPBMOC, string AGPHOFEIIFM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IBJKCJFAAOH FPLGBFAGNKF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static KAEPKEJHNCA PHPBBMOBABP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static DLIFACNHMCN FINBIHNACPD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<CAKELPNIMKK> GBEMDPMHHNN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long LADEAPHDHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5755E10", Offset = "0x5754C10", VA = "0x185755E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5755F00", Offset = "0x5754D00", VA = "0x185755F00")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_BeforeSceneLoad)]
	private static void DHPLENJCBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5755D60", Offset = "0x5754B60", VA = "0x185755D60")]
	private static void CGDOOEBPPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5755FE0", Offset = "0x5754DE0", VA = "0x185755FE0")]
	public static CAKELPNIMKK ILNBPPLNLJA(string LGOPJOBKNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5754720", Offset = "0x5753520", VA = "0x185754720")]
	public static CAKELPNIMKK ILNBPPLNLJA(string LGOPJOBKNHL, int PKODCKADBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5756060", Offset = "0x5754E60", VA = "0x185756060")]
	[GEDGJALKBHL(HNLGNAJIJHC.Unity_BeforeSceneLoad)]
	private static void LPKOFGAMHKI()
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
