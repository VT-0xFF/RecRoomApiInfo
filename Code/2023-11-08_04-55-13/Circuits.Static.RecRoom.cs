using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CECFC0", Offset = "0x1CEBDC0", VA = "0x181CECFC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ONMIGNCBNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CEEC30", Offset = "0x1CEDA30", VA = "0x181CEEC30")]
	public static bool AGINDIHEPFC(this BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CEEB70", Offset = "0x1CED970", VA = "0x181CEEB70")]
	public static bool AGINDIHEPFC(this GPLEIKOBAEP GFHODACCCLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NANIFDOGOHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MJKPCDHPDHM? DAELIEMGHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HHCHMAJAMPN
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4740", Offset = "0x1CE3540", VA = "0x181CE4740")]
	internal static HPKFJDHKMLI DAELIEMGHPO(this NANIFDOGOHH HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4820", Offset = "0x1CE3620", VA = "0x181CE4820")]
	internal static EFFPFBGFCJB<HPKFJDHKMLI, JJAMPFGMGOK> KDLCNPNLGCC(this NANIFDOGOHH HLCOOGAGOEK)
	{
		return default(EFFPFBGFCJB<HPKFJDHKMLI, JJAMPFGMGOK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MJKPCDHPDHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly HPKFJDHKMLI DAELIEMGHPO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public MJKPCDHPDHM(HPKFJDHKMLI NAONDGHEPAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PKBJOCILJJC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2646F40", Offset = "0x2645D40", VA = "0x182646F40")]
	public static DLLEOEKENNC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot, MFMKLHPACBE.JJFEKGOOHAC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot>> GGLBFPNOBNF<TRoot>([In] this DLLEOEKENNC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot, MFMKLHPACBE.JJFEKGOOHAC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot>> KJPOLHOOAKJ) where TRoot : NANIFDOGOHH
	{
		return default(DLLEOEKENNC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot, MFMKLHPACBE.JJFEKGOOHAC<GAJFIOFAGAG, GNLMBGBJMJN, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BIFKPLHLOKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface JPIEMBOLANA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		AEKPLBLLCEB ACDILALAJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FOJBLGBILGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CDJCMODHOBD AOIEGFOHNFE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
		public FOJBLGBILGG(CDJCMODHOBD KCDDDCEEJBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CIMKGDHEBIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MLOCHKHLPON<EGCNCIDBIAF> GAADLDOKDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MLOCHKHLPON<EGCNCIDBIAF> OJBFJNNFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public MLOCHKHLPON<EGCNCIDBIAF> LLJPJHMJOKL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CD19A0", Offset = "0x1CD07A0", VA = "0x181CD19A0")]
		public static CIMKGDHEBIK FMIHPEHEFKO(DGHEHDCIAKI HNLEBFFJDHB, AEKPLBLLCEB IFPKGKPDGBH)
		{
			return default(CIMKGDHEBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CCGOPJAONAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MLOCHKHLPON<ALHGGAPBPBA> LALHKJFNECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MLOCHKHLPON<ALHGGAPBPBA> FBLMKIIEFAH;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1CD1310", Offset = "0x1CD0110", VA = "0x181CD1310")]
		public static CCGOPJAONAG FMIHPEHEFKO(PDBLDDFPGKC<HPKFJDHKMLI> HNLEBFFJDHB)
		{
			return default(CCGOPJAONAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FKDMCMBKNBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MLOCHKHLPON<AGCCDPAGALI> HEBFKIKNLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MLOCHKHLPON<AGCCDPAGALI> HLGKFGMLDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MLOCHKHLPON<AGCCDPAGALI> HGCKBKPDPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public MLOCHKHLPON<AGCCDPAGALI> ANLNLMEKEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public MLOCHKHLPON<AGCCDPAGALI> MNHAMABADHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MLOCHKHLPON<AGCCDPAGALI> KAMAPHCLCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MLOCHKHLPON<AGCCDPAGALI> OLLMFGLNAOK;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1CD4020", Offset = "0x1CD2E20", VA = "0x181CD4020")]
		public static FKDMCMBKNBH FMIHPEHEFKO(CJGNNFIALEF<HPKFJDHKMLI> HNLEBFFJDHB)
		{
			return default(FKDMCMBKNBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class OKDIJKDFNMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static Dictionary<MLOCHKHLPON<NMEGILIBHGH>, HHHKMBCLJCG> PEHKEKCKGBC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> OAICJFILECK;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> AONEHKCLPHK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> FELHHJKOJLF;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> OMIMHOIFNCM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> JELNEOJFIDD;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> EEIIAMBFFGB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> CHCAJJFNACF;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> PMOEKPIPDAK;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> IDBKGANPJMC;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> FCEMHJKHPCL;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> CGDAHKEONNI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> ICHMPKIIGMF;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> LPPFPPGNMGC;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> HBLILPMBLPI;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> KNPKGGMLCIB;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> BEEGAOALDBE;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> JJCNNLEMNCH;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> PBAEMAMPIJE;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> IMGFIKMMCHP;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> KFBCPMBODOE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> LONCJLCBFBN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> HALBGDOMOHI;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> BJOONBJNCCC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NDBDDMCLBMF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> CMDMNFKBDMO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> BFLHOBDAECB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> BLEGNCOBGBD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> GEKDFMJCEBP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> CKOFBDNGMDL;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> EHHJCFOINGD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NDBHMNGCMBN;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NIOIOOAADEI;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> HOEKBLMIBFH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> HNNCDNGGAFE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> FALPAFHPKKP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NEFKJMNCFAA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NIBCFFHDOIN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> LALEBPGAOIA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> FGLACDGEOOM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NBFMDKMFCIC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> AIMJEJGFFPB;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> GKNHFMDMFCB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> JKJICDGPDAA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> FFLGMHPMNLK;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> MHLDGBOOPEO;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> IFJMDNOIIDH;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> MJMFHAPLDAN;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> NMDOHGBIJEO;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> MKBDGGMFCFP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> OFCHPEOAOOH;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> OABJKGGHHED;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly MLOCHKHLPON<NMEGILIBHGH> AMAOLPHFCAM;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1CED980", Offset = "0x1CEC780", VA = "0x181CED980")]
		public static HHHKMBCLJCG JJGBNLBEPIH(MLOCHKHLPON<NMEGILIBHGH> JPODHBJFPKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1CEDA00", Offset = "0x1CEC800", VA = "0x181CEDA00")]
		public static bool MKANLIHOBNO(MLOCHKHLPON<NMEGILIBHGH> JPODHBJFPKM, [Out] HHHKMBCLJCG LNPADAHGKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CED8D0", Offset = "0x1CEC6D0", VA = "0x181CED8D0")]
		public static BAMPGCHBHMA HLPNMPCJOGN(MLOCHKHLPON<NMEGILIBHGH> JPODHBJFPKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CED840", Offset = "0x1CEC640", VA = "0x181CED840")]
		private static MLOCHKHLPON<NMEGILIBHGH> EEHFKNGNNHO(HHHKMBCLJCG LNPADAHGKJB, MLOCHKHLPON<NMEGILIBHGH> JPODHBJFPKM)
		{
			return default(MLOCHKHLPON<NMEGILIBHGH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GGGPKNCLJHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EEMAALAHEFC : IEnumerable<BAMPGCHBHMA>, IEnumerable, IEnumerator<BAMPGCHBHMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private BAMPGCHBHMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			private BAMPGCHBHMA System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
			[DebuggerHidden]
			public EEMAALAHEFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1CD26E0", Offset = "0x1CD14E0", VA = "0x181CD26E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1CD3C00", Offset = "0x1CD2A00", VA = "0x181CD3C00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1CD3B50", Offset = "0x1CD2950", VA = "0x181CD3B50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BAMPGCHBHMA> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1CD3B50", Offset = "0x1CD2950", VA = "0x181CD3B50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class DJMLFIFIGON : IEnumerable<BAMPGCHBHMA>, IEnumerable, IEnumerator<BAMPGCHBHMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private BAMPGCHBHMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<BAMPGCHBHMA> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private BAMPGCHBHMA <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			private BAMPGCHBHMA System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CB0", Offset = "0x8C3AB0", VA = "0x1808C4CB0")]
			[DebuggerHidden]
			public DJMLFIFIGON(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD21F0", Offset = "0x1CD0FF0", VA = "0x181CD21F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD1C00", Offset = "0x1CD0A00", VA = "0x181CD1C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD1BB0", Offset = "0x1CD09B0", VA = "0x181CD1BB0")]
			private void FKICEAEIDMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD21A0", Offset = "0x1CD0FA0", VA = "0x181CD21A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1CD20F0", Offset = "0x1CD0EF0", VA = "0x181CD20F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BAMPGCHBHMA> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1CD20F0", Offset = "0x1CD0EF0", VA = "0x181CD20F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly GPLEIKOBAEP GEKMJCKPOBD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly GPLEIKOBAEP HLIJHKGPDMF;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly HashSet<BAMPGCHBHMA> BLMFDNMDHEM;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static List<BAMPGCHBHMA> OHFGPFCEIIE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static LIEBIDKEEKD FCGALCJKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x839C70", Offset = "0x838A70", VA = "0x180839C70")]
			get
			{
				return default(LIEBIDKEEKD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static BAMPGCHBHMA FGEJCDHHGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8570", Offset = "0x1CD7370", VA = "0x181CD8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static BAMPGCHBHMA NAJLJDJHDJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1CD83B0", Offset = "0x1CD71B0", VA = "0x181CD83B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static BAMPGCHBHMA JDIBFLJONKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8C70", Offset = "0x1CD7A70", VA = "0x181CD8C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static BAMPGCHBHMA HDHDPKCAJAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8830", Offset = "0x1CD7630", VA = "0x181CD8830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static BAMPGCHBHMA NNALIBENBEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7F30", Offset = "0x1CD6D30", VA = "0x181CD7F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static BAMPGCHBHMA MEPBJMEBGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9480", Offset = "0x1CD8280", VA = "0x181CD9480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static BAMPGCHBHMA NHHCEIELGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7990", Offset = "0x1CD6790", VA = "0x181CD7990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static BAMPGCHBHMA KHKHMKJNBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9330", Offset = "0x1CD8130", VA = "0x181CD9330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static FAEIJGLNAEE LBCBDAINGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8190", Offset = "0x1CD6F90", VA = "0x181CD8190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static FAEIJGLNAEE ENONONCACFD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7080", Offset = "0x1CD5E80", VA = "0x181CD7080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static FAEIJGLNAEE DBHDHGEBOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8D00", Offset = "0x1CD7B00", VA = "0x181CD8D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static FAEIJGLNAEE MKAOKAKAECM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD87E0", Offset = "0x1CD75E0", VA = "0x181CD87E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FAEIJGLNAEE AIHCBFAEAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9230", Offset = "0x1CD8030", VA = "0x181CD9230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static FAEIJGLNAEE PEBOCEDBLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1CD72D0", Offset = "0x1CD60D0", VA = "0x181CD72D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static FAEIJGLNAEE MOJCCKGNDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1CD84F0", Offset = "0x1CD72F0", VA = "0x181CD84F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static FAEIJGLNAEE LDCCPOMJBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9280", Offset = "0x1CD8080", VA = "0x181CD9280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FAEIJGLNAEE NACJGNBDLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9180", Offset = "0x1CD7F80", VA = "0x181CD9180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static FAEIJGLNAEE MJPGCJKANIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1CD98A0", Offset = "0x1CD86A0", VA = "0x181CD98A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static FAEIJGLNAEE BDNHFDMHKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7680", Offset = "0x1CD6480", VA = "0x181CD7680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static FAEIJGLNAEE FEKGDHENFOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8360", Offset = "0x1CD7160", VA = "0x181CD8360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static FAEIJGLNAEE CMENGCOLBIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1CD84A0", Offset = "0x1CD72A0", VA = "0x181CD84A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static FAEIJGLNAEE HMJJCPHHPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1CD80E0", Offset = "0x1CD6EE0", VA = "0x181CD80E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static FAEIJGLNAEE KFMAJEIBMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7DD0", Offset = "0x1CD6BD0", VA = "0x181CD7DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static FAEIJGLNAEE NFJHKHNIFCG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7E20", Offset = "0x1CD6C20", VA = "0x181CD7E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static FAEIJGLNAEE HGJEMOFGLCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD73E0", Offset = "0x1CD61E0", VA = "0x181CD73E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static FAEIJGLNAEE GDABILNCFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7B30", Offset = "0x1CD6930", VA = "0x181CD7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static FAEIJGLNAEE JKBNNPGGEME
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8660", Offset = "0x1CD7460", VA = "0x181CD8660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static FAEIJGLNAEE BJGHJBHMLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7320", Offset = "0x1CD6120", VA = "0x181CD7320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static FAEIJGLNAEE OBGHEHBNIKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9120", Offset = "0x1CD7F20", VA = "0x181CD9120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static FAEIJGLNAEE ECNODPDGOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7020", Offset = "0x1CD5E20", VA = "0x181CD7020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static FAEIJGLNAEE NOKNCCBIKFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7ED0", Offset = "0x1CD6CD0", VA = "0x181CD7ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static FAEIJGLNAEE ENFLMHGMDCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8080", Offset = "0x1CD6E80", VA = "0x181CD8080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static FAEIJGLNAEE GIMBANGEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7E70", Offset = "0x1CD6C70", VA = "0x181CD7E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static FAEIJGLNAEE GABNIINHLPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8440", Offset = "0x1CD7240", VA = "0x181CD8440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static FAEIJGLNAEE OOHJKMFPNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1CD93C0", Offset = "0x1CD81C0", VA = "0x181CD93C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static FAEIJGLNAEE PPLEDCPONPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1CD98F0", Offset = "0x1CD86F0", VA = "0x181CD98F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static FAEIJGLNAEE FIOCDPGHFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1CD75C0", Offset = "0x1CD63C0", VA = "0x181CD75C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static FAEIJGLNAEE NDAKGMBEHND
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8BB0", Offset = "0x1CD79B0", VA = "0x181CD8BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static FAEIJGLNAEE IIMIDGDIMCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8020", Offset = "0x1CD6E20", VA = "0x181CD8020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static FAEIJGLNAEE MNFLLNCPAGL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7560", Offset = "0x1CD6360", VA = "0x181CD7560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static FAEIJGLNAEE PEDDPOJHOHC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8130", Offset = "0x1CD6F30", VA = "0x181CD8130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static FAEIJGLNAEE MFPENPDEFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8980", Offset = "0x1CD7780", VA = "0x181CD8980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static FAEIJGLNAEE EBHEOMCBKLN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8D50", Offset = "0x1CD7B50", VA = "0x181CD8D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static FAEIJGLNAEE EHCBBDMEAIN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9420", Offset = "0x1CD8220", VA = "0x181CD9420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static FAEIJGLNAEE LHANPOLHKND
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7FC0", Offset = "0x1CD6DC0", VA = "0x181CD7FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static FAEIJGLNAEE HKFEJICHJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7240", Offset = "0x1CD6040", VA = "0x181CD7240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static FAEIJGLNAEE KJJAMBCALKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1CD77B0", Offset = "0x1CD65B0", VA = "0x181CD77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static FAEIJGLNAEE FIMJHAKGHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7D70", Offset = "0x1CD6B70", VA = "0x181CD7D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static FAEIJGLNAEE GFFOKFLBAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7A20", Offset = "0x1CD6820", VA = "0x181CD7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static FAEIJGLNAEE MDKGHHGNHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1CD91D0", Offset = "0x1CD7FD0", VA = "0x181CD91D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static FAEIJGLNAEE LFNEEPBMEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8300", Offset = "0x1CD7100", VA = "0x181CD8300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static FAEIJGLNAEE EDKEIIAMHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1CD88C0", Offset = "0x1CD76C0", VA = "0x181CD88C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static FAEIJGLNAEE DFJGCOAHCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7620", Offset = "0x1CD6420", VA = "0x181CD7620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static FAEIJGLNAEE PAOJGLGAPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8E10", Offset = "0x1CD7C10", VA = "0x181CD8E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static FAEIJGLNAEE OLPEMBLHAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9660", Offset = "0x1CD8460", VA = "0x181CD9660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static FAEIJGLNAEE GBKCJNHMIAG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7380", Offset = "0x1CD6180", VA = "0x181CD7380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static FAEIJGLNAEE BOCNDBOJFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7BF0", Offset = "0x1CD69F0", VA = "0x181CD7BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static FAEIJGLNAEE GCFKEPKBIAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD92D0", Offset = "0x1CD80D0", VA = "0x181CD92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static FAEIJGLNAEE HNEIJADGGEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7870", Offset = "0x1CD6670", VA = "0x181CD7870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static FAEIJGLNAEE JOOOBIDLFLP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7750", Offset = "0x1CD6550", VA = "0x181CD7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static FAEIJGLNAEE OCGCBNDBPHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7930", Offset = "0x1CD6730", VA = "0x181CD7930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static FAEIJGLNAEE MCDEKLCAIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7500", Offset = "0x1CD6300", VA = "0x181CD7500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static FAEIJGLNAEE EGEGCLNFGKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1CD81E0", Offset = "0x1CD6FE0", VA = "0x181CD81E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static FAEIJGLNAEE HLIBLBEIIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1CD6FC0", Offset = "0x1CD5DC0", VA = "0x181CD6FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static FAEIJGLNAEE BOOBNLONPEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1CD78D0", Offset = "0x1CD66D0", VA = "0x181CD78D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static FAEIJGLNAEE FKCMLOLKAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8F90", Offset = "0x1CD7D90", VA = "0x181CD8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static FAEIJGLNAEE LABKFDNOPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1CD86C0", Offset = "0x1CD74C0", VA = "0x181CD86C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static FAEIJGLNAEE GNJJLODLCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1CD89E0", Offset = "0x1CD77E0", VA = "0x181CD89E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static FAEIJGLNAEE JMPOGBCDBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1CD82A0", Offset = "0x1CD70A0", VA = "0x181CD82A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static FAEIJGLNAEE DIHBJMBBHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7CB0", Offset = "0x1CD6AB0", VA = "0x181CD7CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static FAEIJGLNAEE AIELCKJOGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8E70", Offset = "0x1CD7C70", VA = "0x181CD8E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static FAEIJGLNAEE NMNFKKECIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD74A0", Offset = "0x1CD62A0", VA = "0x181CD74A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static FAEIJGLNAEE OGADCEHFKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7D10", Offset = "0x1CD6B10", VA = "0x181CD7D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static FAEIJGLNAEE FCGMJLGBABN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8780", Offset = "0x1CD7580", VA = "0x181CD8780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static FAEIJGLNAEE MELAFIGHHBN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8720", Offset = "0x1CD7520", VA = "0x181CD8720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static FAEIJGLNAEE BGFDAMIOOLE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8C10", Offset = "0x1CD7A10", VA = "0x181CD8C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static FAEIJGLNAEE LOELFDHADOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7810", Offset = "0x1CD6610", VA = "0x181CD7810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static FAEIJGLNAEE NPLIOGAEDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7440", Offset = "0x1CD6240", VA = "0x181CD7440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static FAEIJGLNAEE KCHPPGGIMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7B90", Offset = "0x1CD6990", VA = "0x181CD7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static FAEIJGLNAEE JNHIDIBLJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8240", Offset = "0x1CD7040", VA = "0x181CD8240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static FAEIJGLNAEE LGKHCCBPHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8920", Offset = "0x1CD7720", VA = "0x181CD8920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static FAEIJGLNAEE HDHPFILKAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1CD7C50", Offset = "0x1CD6A50", VA = "0x181CD7C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static FAEIJGLNAEE PEGAHBPCCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1CD96C0", Offset = "0x1CD84C0", VA = "0x181CD96C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static FAEIJGLNAEE IPBMDPJOHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1CD9600", Offset = "0x1CD8400", VA = "0x181CD9600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static FAEIJGLNAEE ICBDDNICJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8DB0", Offset = "0x1CD7BB0", VA = "0x181CD8DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static FAEIJGLNAEE LGCNBBHCIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8ED0", Offset = "0x1CD7CD0", VA = "0x181CD8ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static FAEIJGLNAEE DGNAJAEDKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8600", Offset = "0x1CD7400", VA = "0x181CD8600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static FAEIJGLNAEE EIFHNFFAAON
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1CD8F30", Offset = "0x1CD7D30", VA = "0x181CD8F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CD9510", Offset = "0x1CD8310", VA = "0x181CD9510")]
		public static GPLEIKOBAEP ONOCPHEOLLM([In] CODMHGJILEG GBJJNKHBNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CD97C0", Offset = "0x1CD85C0", VA = "0x181CD97C0")]
		public static KOPHGOMKCDP PLGHAGCMKJN(string JPODHBJFPKM, [Optional] string NDLLBBKGIJD)
		{
			return default(KOPHGOMKCDP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1CD9870", Offset = "0x1CD8670", VA = "0x181CD9870")]
		public static KOPHGOMKCDP PLGHAGCMKJN([Optional][In] Guid? JPODHBJFPKM, [Optional] string NDLLBBKGIJD)
		{
			return default(KOPHGOMKCDP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CD72A0", Offset = "0x1CD60A0", VA = "0x181CD72A0")]
		public static GPLEIKOBAEP AKKEGCGOHDA(params CODMHGJILEG[] DKCJBDGJKED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1CD8540", Offset = "0x1CD7340", VA = "0x181CD8540")]
		public static GPLEIKOBAEP IOFDEINFCME(params CODMHGJILEG[] DKCJBDGJKED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1CD8FF0", Offset = "0x1CD7DF0", VA = "0x181CD8FF0")]
		public static GPLEIKOBAEP NBOMLIMCKGE([In] CODMHGJILEG GBJJNKHBNFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CD9950", Offset = "0x1CD8750", VA = "0x181CD9950")]
		static GGGPKNCLJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CD9720", Offset = "0x1CD8520", VA = "0x181CD9720")]
		[IteratorStateMachine(typeof(EEMAALAHEFC))]
		private static IEnumerable<BAMPGCHBHMA> PJIAAJNJBCE(bool HPNEPMDKEKH, bool LDBDNNAEKLD, bool BFAMJNONIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CD7A80", Offset = "0x1CD6880", VA = "0x181CD7A80")]
		[IteratorStateMachine(typeof(DJMLFIFIGON))]
		public static IEnumerable<BAMPGCHBHMA> CMPBOPICBBO(bool MNGEIINFBNO, bool HPNEPMDKEKH, bool LDBDNNAEKLD, bool BFAMJNONIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CD8A40", Offset = "0x1CD7840", VA = "0x181CD8A40")]
		public static FNHANFHBEAF LLLOKJIIAGK(BAMPGCHBHMA AOPDMLJGEMB)
		{
			return default(FNHANFHBEAF);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1CD70D0", Offset = "0x1CD5ED0", VA = "0x181CD70D0")]
		public static FNHANFHBEAF AIDEKCEOEDA(BAMPGCHBHMA AOPDMLJGEMB)
		{
			return default(FNHANFHBEAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1CD76D0", Offset = "0x1CD64D0", VA = "0x181CD76D0")]
		public static bool BKCMFOOPIAB(BAMPGCHBHMA AOPDMLJGEMB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FKDMCMBKNBH BMDAPCGGOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CCGOPJAONAG DGJBHNJPBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly CIMKGDHEBIK LHMLEFMGBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OAEADIDHHCL<AGCCDPAGALI, HMPKOKPCHPM<HPKFJDHKMLI>> PJDJEJKMPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OAEADIDHHCL<ALHGGAPBPBA, INFPNMHFIJF<HPKFJDHKMLI>> PKMBEEPGLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OAEADIDHHCL<EGCNCIDBIAF, DINOMMGCMNK> NCGFKGMMCDG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFF60", Offset = "0x1CCED60", VA = "0x181CCFF60")]
	private BIFKPLHLOKA([In] FKDMCMBKNBH AKBFDCNMECP, [In] CCGOPJAONAG IOEFGMBOBPE, [In] CIMKGDHEBIK IOLIEJJCEJN, OAEADIDHHCL<AGCCDPAGALI, HMPKOKPCHPM<HPKFJDHKMLI>> CKPFGMCCCJH, OAEADIDHHCL<ALHGGAPBPBA, INFPNMHFIJF<HPKFJDHKMLI>> BOOCBDHDANP, OAEADIDHHCL<EGCNCIDBIAF, DINOMMGCMNK> CAPNOBFOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF6B0", Offset = "0x1CCE4B0", VA = "0x181CCF6B0")]
	public static BIFKPLHLOKA FMIHPEHEFKO(JPIEMBOLANA IFPKGKPDGBH)
	{
		return default(BIFKPLHLOKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF970", Offset = "0x1CCE770", VA = "0x181CCF970")]
	public static void IFMJALEKMOK([In] BIFKPLHLOKA HLCOOGAGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF6A0", Offset = "0x1CCE4A0", VA = "0x181CCF6A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF5C0", Offset = "0x1CCE3C0", VA = "0x181CCF5C0")]
	public static LCKFNLALNFP<HPKFJDHKMLI> BFKOPONHPHG([In] BIFKPLHLOKA HLCOOGAGOEK, [In] BANKIOHFCEE OGNEMFAEDIP, [In] NLHILNDMCEH ALNLOJFNOJP)
	{
		return default(LCKFNLALNFP<HPKFJDHKMLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFDC0", Offset = "0x1CCEBC0", VA = "0x181CCFDC0")]
	public static HPKFJDHKMLI NBEICNCHINH([In] BIFKPLHLOKA HLCOOGAGOEK, [In] OBEIDHGKAAD NFKNILOALDK, [In] LCKFNLALNFP<HPKFJDHKMLI> ALEKFBOABOP, [In] FEJAEOBMEHL CJEJPAGMGHO, MLOCHKHLPON<BJGNAPHFBHH> DLIFIECADOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HPKFJDHKMLI : BLDEFDBHAJI, NCOOLGMKMIG<HPKFJDHKMLI>, CBMOMHJHEAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly BIFKPLHLOKA LFNMNKGKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private OBEIDHGKAAD GLKFNJNMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private LCKFNLALNFP<HPKFJDHKMLI> MEPIMCAAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private FEJAEOBMEHL ELPLHGJFDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> DGHCNKOFDBI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7720", Offset = "0x1CE6520", VA = "0x181CE7720")]
	private HPKFJDHKMLI([In] BIFKPLHLOKA HEJIOKNFDFA, [In] OBEIDHGKAAD BCNEODGIDLF, [In] LCKFNLALNFP<HPKFJDHKMLI> ALEKFBOABOP, [In] FEJAEOBMEHL CJEJPAGMGHO, MLOCHKHLPON<BJGNAPHFBHH> FNFJPGFELAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFDC0", Offset = "0x1CCEBC0", VA = "0x181CCFDC0")]
	public static HPKFJDHKMLI BDOHGNMNHBJ([In] BIFKPLHLOKA HEJIOKNFDFA, [In] OBEIDHGKAAD BCNEODGIDLF, [In] LCKFNLALNFP<HPKFJDHKMLI> ALEKFBOABOP, [In] FEJAEOBMEHL CJEJPAGMGHO, MLOCHKHLPON<BJGNAPHFBHH> FNFJPGFELAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5710", Offset = "0x1CE4510", VA = "0x181CE5710", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1CE69A0", Offset = "0x1CE57A0", VA = "0x181CE69A0", Slot = "8")]
	public LCKFNLALNFP<HPKFJDHKMLI> NBEDEKCHDKP()
	{
		return default(LCKFNLALNFP<HPKFJDHKMLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5790", Offset = "0x1CE4590", VA = "0x181CE5790")]
	public OBEIDHGKAAD ECIIHLALBAP()
	{
		return default(OBEIDHGKAAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2514FD0", Offset = "0x2513DD0", VA = "0x182514FD0")]
	public MLOCHKHLPON<TMVirt> GEBIKGJJICE<TMVirt>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM) where TMVirt : KJKBDHLLKII.LPEGHPNKIMJ
	{
		return default(MLOCHKHLPON<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2515210", Offset = "0x2514010", VA = "0x182515210")]
	public MLOCHKHLPON<TMVirt> IEPCGNAGGIO<TMVirt>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC) where TMVirt : EJOOHFJCFEJ.JPFCGFCALJB
	{
		return default(MLOCHKHLPON<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4A50", Offset = "0x1CE3850", VA = "0x181CE4A50")]
	internal BANKIOHFCEE AHOJKODFPFJ()
	{
		return default(BANKIOHFCEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE76D0", Offset = "0x1CE64D0", VA = "0x181CE76D0")]
	internal NLHILNDMCEH PELAKMLEBLF()
	{
		return default(NLHILNDMCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE69A0", Offset = "0x1CE57A0", VA = "0x181CE69A0")]
	internal LCKFNLALNFP<HPKFJDHKMLI> HNBHFIBFIDH()
	{
		return default(LCKFNLALNFP<HPKFJDHKMLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5790", Offset = "0x1CE4590", VA = "0x181CE5790")]
	internal OBEIDHGKAAD OKECMEAMILO()
	{
		return default(OBEIDHGKAAD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7710", Offset = "0x1CE6510", VA = "0x181CE7710")]
	internal FEJAEOBMEHL PJECGBFIFBK()
	{
		return default(FEJAEOBMEHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2514F70", Offset = "0x2513D70", VA = "0x182514F70")]
	public void FLEDJGLAGMO<TMVirt>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<TMVirt> GHIDKLBJHKJ) where TMVirt : KJKBDHLLKII.LPEGHPNKIMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2514ED0", Offset = "0x2513CD0", VA = "0x182514ED0")]
	public void CPKFHIKAAKG<TMVirt>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<TMVirt> GHIDKLBJHKJ) where TMVirt : EJOOHFJCFEJ.JPFCGFCALJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE72D0", Offset = "0x1CE60D0", VA = "0x181CE72D0", Slot = "9")]
	public MOLNBMFLEJJ MDBFPJJCMEO()
	{
		return default(MOLNBMFLEJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7310", Offset = "0x1CE6110", VA = "0x181CE7310", Slot = "10")]
	public FNHANFHBEAF NFGMGMGOEGI(BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(FNHANFHBEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4B20", Offset = "0x1CE3920", VA = "0x181CE4B20", Slot = "11")]
	public bool CCGICFIBFMN(BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE74D0", Offset = "0x1CE62D0", VA = "0x181CE74D0", Slot = "4")]
	private void NNIGFMPJLBL(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE69B0", Offset = "0x1CE57B0", VA = "0x181CE69B0", Slot = "5")]
	private void KCFAFDOFFIJ(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7240", Offset = "0x1CE6040", VA = "0x181CE7240", Slot = "6")]
	private void LNLAGLCLIKE(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE7580", Offset = "0x1CE6380", VA = "0x181CE7580", Slot = "7")]
	private void NOPGCCGPBFA(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6820", Offset = "0x1CE5620", VA = "0x181CE6820")]
	internal EFFPFBGFCJB<MLOCHKHLPON<DOHDAHLOGBC>, JLMPFOOAOBO> HEBFKIKNLDP(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<AGCCDPAGALI> JLFBOJFABPA, [In] ALABNNELONF EHFMGFPLNPD, [In] PFGFFEFKBLO GBLLLKBIFDK, HNDBIENACOA LMEJEPJMMDM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? OBCCGMFFBBM)
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<DOHDAHLOGBC>, JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE75F0", Offset = "0x1CE63F0", VA = "0x181CE75F0")]
	internal MLOCHKHLPON<DOHDAHLOGBC> OPHEKGMPHED(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<AGCCDPAGALI> JLFBOJFABPA, [In] ALABNNELONF EHFMGFPLNPD, [In] PFGFFEFKBLO GBLLLKBIFDK, HNDBIENACOA LMEJEPJMMDM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? OBCCGMFFBBM)
	{
		return default(MLOCHKHLPON<DOHDAHLOGBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4A90", Offset = "0x1CE3890", VA = "0x181CE4A90")]
	internal EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> CAHFHDEJNFE(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x25152C0", Offset = "0x25140C0", VA = "0x1825152C0")]
	public EFFPFBGFCJB<MLOCHKHLPON<TM>, JLMPFOOAOBO> IMEKOKJBIJM<TM>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<ALHGGAPBPBA> FGHOJFDKLMC) where TM : KJKBDHLLKII.LPEGHPNKIMJ
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<TM>, JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2515040", Offset = "0x2513E40", VA = "0x182515040")]
	public EFFPFBGFCJB<MLOCHKHLPON<TM>, JLMPFOOAOBO> GNHNJLNLKKA<TM>(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<AGCCDPAGALI> EPDEPCLBLAP) where TM : EJOOHFJCFEJ.JPFCGFCALJB
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<TM>, JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4BD0", Offset = "0x1CE39D0", VA = "0x181CE4BD0")]
	private EFFPFBGFCJB<(MLOCHKHLPON<OCANDIGPHLL.DCECDAHFPJA>, MLOCHKHLPON<AIJPPNFOECJ.CDKHNMNAAEI>), JLMPFOOAOBO> DHMEKIPLAKJ(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
		return default(EFFPFBGFCJB<(MLOCHKHLPON<OCANDIGPHLL.DCECDAHFPJA>, MLOCHKHLPON<AIJPPNFOECJ.CDKHNMNAAEI>), JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1CE57A0", Offset = "0x1CE45A0", VA = "0x181CE57A0")]
	internal EFFPFBGFCJB<(MLOCHKHLPON<IKFLLCHHAHF>, MLOCHKHLPON<OGAMGKFNOJD>), JLMPFOOAOBO> EHMIGANNGOA(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int LJKKKOEHGLO, [In] BAFJLAKLIFO AOPDMLJGEMB)
	{
		return default(EFFPFBGFCJB<(MLOCHKHLPON<IKFLLCHHAHF>, MLOCHKHLPON<OGAMGKFNOJD>), JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4F40", Offset = "0x1CE3D40", VA = "0x181CE4F40")]
	internal EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> DJGAGMMLEKN(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int LJKKKOEHGLO)
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5FB0", Offset = "0x1CE4DB0", VA = "0x181CE5FB0")]
	internal EFFPFBGFCJB<(MLOCHKHLPON<OGAMGKFNOJD>, MLOCHKHLPON<IKFLLCHHAHF>), JLMPFOOAOBO> FJJDEJDPODH(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int HIDLGKEKBJA, [In] BAFJLAKLIFO AOPDMLJGEMB)
	{
		return default(EFFPFBGFCJB<(MLOCHKHLPON<OGAMGKFNOJD>, MLOCHKHLPON<IKFLLCHHAHF>), JLMPFOOAOBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6A40", Offset = "0x1CE5840", VA = "0x181CE6A40")]
	internal EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> KKHNHLFOMLG(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int HIDLGKEKBJA)
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FEJAEOBMEHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public EBPMFLLAEFM<AIJPPNFOECJ.CDKHNMNAAEI, OPAFCPEHPEG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC, BJGNAPHFBHH>> JFMCKAPHLMG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1C9ADD0", Offset = "0x1C99BD0", VA = "0x181C9ADD0")]
	private FEJAEOBMEHL([In] EBPMFLLAEFM<AIJPPNFOECJ.CDKHNMNAAEI, OPAFCPEHPEG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC, BJGNAPHFBHH>> JLIPNKJOFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1CD3D20", Offset = "0x1CD2B20", VA = "0x181CD3D20")]
	public static FEJAEOBMEHL FMIHPEHEFKO()
	{
		return default(FEJAEOBMEHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ILEFEMOIGHH
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8870", Offset = "0x1CE7670", VA = "0x181CE8870")]
	public static void IFMJALEKMOK(this FEJAEOBMEHL HLCOOGAGOEK, [In] GCIMOGLIMHK<AIJPPNFOECJ.CDKHNMNAAEI> ABJANHIGKNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IDFIFIAPNHK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8020", Offset = "0x1CE6E20", VA = "0x181CE8020")]
	public static BKADKCCHKCG OJBJHHLKILJ(HPKFJDHKMLI ALEKFBOABOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1CE78E0", Offset = "0x1CE66E0", VA = "0x181CE78E0")]
	public static BKADKCCHKCG HNEDOMKLBLG(MLOCHKHLPON<ALHGGAPBPBA> OOFHJOGCLDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FMNEPPBGMMH
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4E20", Offset = "0x1CD3C20", VA = "0x181CD4E20")]
	public static BJGOEICLIHP OJBJHHLKILJ(this BAMPGCHBHMA AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4260", Offset = "0x1CD3060", VA = "0x181CD4260")]
	public static BAMPGCHBHMA LKNPCKIALBL(this BJGOEICLIHP AOPDMLJGEMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LCMHGALFAGG
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2558CC0", Offset = "0x2557AC0", VA = "0x182558CC0")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> GFJHPDNKFKA<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> BBFMJKBFLAL, Func<TSerialized, TDeserializedKey> MHMJAAIKDAO, Func<TSerialized, TDeserializedValue> PGJFJAMGFMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JFIBGLPAAPK
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA2C0", Offset = "0x1CE90C0", VA = "0x181CEA2C0")]
	public static ADPCPFMOCLM OJBJHHLKILJ([In] this KJKBDHLLKII HLCOOGAGOEK, [In] GFDIDGCOKOG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC> OPMPICBIMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9B80", Offset = "0x1CE8980", VA = "0x181CE9B80")]
	public static KJKBDHLLKII LKNPCKIALBL(this ADPCPFMOCLM HLCOOGAGOEK, [In] GFDIDGCOKOG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC> OPMPICBIMMG)
	{
		return default(KJKBDHLLKII);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CEGGIBKCGON
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1CD16A0", Offset = "0x1CD04A0", VA = "0x181CD16A0")]
	public static PPCCKAOOMAP OJBJHHLKILJ([In] this NLHILNDMCEH HLCOOGAGOEK, [In] BANKIOHFCEE FAENJJOJFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1CD13E0", Offset = "0x1CD01E0", VA = "0x181CD13E0")]
	public static NLHILNDMCEH LKNPCKIALBL(this PPCCKAOOMAP HLCOOGAGOEK, [In] BANKIOHFCEE FAENJJOJFNO)
	{
		return default(NLHILNDMCEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GADELJJKFCG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6160", Offset = "0x1CD4F60", VA = "0x181CD6160")]
	public static NAHAIDPCIDK OJBJHHLKILJ([In] this PCLIPEPNOAK HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1CD60B0", Offset = "0x1CD4EB0", VA = "0x181CD60B0")]
	public static PCLIPEPNOAK LKNPCKIALBL(this NAHAIDPCIDK HLCOOGAGOEK)
	{
		return default(PCLIPEPNOAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class GBNPFCNIKJO
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1CD64A0", Offset = "0x1CD52A0", VA = "0x181CD64A0")]
	public static DIBFDGBGDLI OJBJHHLKILJ([In] this EJOOHFJCFEJ HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6420", Offset = "0x1CD5220", VA = "0x181CD6420")]
	public static EJOOHFJCFEJ LKNPCKIALBL(this DIBFDGBGDLI HLCOOGAGOEK)
	{
		return default(EJOOHFJCFEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OJLHFCOIHDG
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1CED7D0", Offset = "0x1CEC5D0", VA = "0x181CED7D0")]
	public static AKLOPMHOGKL OJBJHHLKILJ([In] this PLBCHKOBIDP HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CED750", Offset = "0x1CEC550", VA = "0x181CED750")]
	public static PLBCHKOBIDP LKNPCKIALBL(this AKLOPMHOGKL HLCOOGAGOEK)
	{
		return default(PLBCHKOBIDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class IDKIMHPCDEI
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x251D4A0", Offset = "0x251C2A0", VA = "0x18251D4A0")]
	public static KLNLODGLOOM OJBJHHLKILJ<TRoot>([In] this LCKFNLALNFP<TRoot> HLCOOGAGOEK) where TRoot : NCOOLGMKMIG<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8170", Offset = "0x1CE6F70", VA = "0x181CE8170")]
	public static LCKFNLALNFP<HPKFJDHKMLI> LKNPCKIALBL(this KLNLODGLOOM HLCOOGAGOEK, [In] BIFKPLHLOKA HEJIOKNFDFA)
	{
		return default(LCKFNLALNFP<HPKFJDHKMLI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OEEOAGOLBPM
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CED4E0", Offset = "0x1CEC2E0", VA = "0x181CED4E0")]
	public static AOPKBDBPJLK OJBJHHLKILJ([In] this AIJPPNFOECJ.PIEOHDOGKFC HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CED1E0", Offset = "0x1CEBFE0", VA = "0x181CED1E0")]
	public static AIJPPNFOECJ.PIEOHDOGKFC LKNPCKIALBL(this AOPKBDBPJLK HLCOOGAGOEK)
	{
		return default(AIJPPNFOECJ.PIEOHDOGKFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NPIPLHHPECB
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CECF50", Offset = "0x1CEBD50", VA = "0x181CECF50")]
	public static FJNNHHLKMMJ OJBJHHLKILJ([In] this OCANDIGPHLL.EPJAKNGFHMO HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CECF00", Offset = "0x1CEBD00", VA = "0x181CECF00")]
	public static OCANDIGPHLL.EPJAKNGFHMO LKNPCKIALBL(this FJNNHHLKMMJ HLCOOGAGOEK)
	{
		return default(OCANDIGPHLL.EPJAKNGFHMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ALGMLNJPDDI
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF080", Offset = "0x1CCDE80", VA = "0x181CCF080")]
	public static GDNDDMNEGKF OJBJHHLKILJ([In] this BANKIOHFCEE HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1CCEE20", Offset = "0x1CCDC20", VA = "0x181CCEE20")]
	public static BANKIOHFCEE LKNPCKIALBL(this GDNDDMNEGKF HLCOOGAGOEK)
	{
		return default(BANKIOHFCEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MBPBIMFAAJF
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1CEBC60", Offset = "0x1CEAA60", VA = "0x181CEBC60")]
	public static AKPOPADPINC OJBJHHLKILJ([In] Guid HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1CEBBC0", Offset = "0x1CEA9C0", VA = "0x181CEBBC0")]
	public static Guid LKNPCKIALBL(AKPOPADPINC HLCOOGAGOEK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class LGIFHHKAKOD
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1CEBA60", Offset = "0x1CEA860", VA = "0x181CEBA60")]
	public static ONNAIALCPKG OJBJHHLKILJ([In] this LFNODKACDLF HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB9C0", Offset = "0x1CEA7C0", VA = "0x181CEB9C0")]
	public static LFNODKACDLF LKNPCKIALBL(this ONNAIALCPKG HLCOOGAGOEK)
	{
		return default(LFNODKACDLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NDJNDMFCOBF
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC4C0", Offset = "0x1CEB2C0", VA = "0x181CEC4C0")]
	public static NGKDMBOMFKM OJBJHHLKILJ([In] this BAFJLAKLIFO HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC460", Offset = "0x1CEB260", VA = "0x181CEC460")]
	public static BAFJLAKLIFO LKNPCKIALBL(this NGKDMBOMFKM HLCOOGAGOEK)
	{
		return default(BAFJLAKLIFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DDPFFOGNENN
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1B30", Offset = "0x1CD0930", VA = "0x181CD1B30")]
	public static PMPBJLAJEHM OJBJHHLKILJ([In] this EEJLFDCDOGD HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1A90", Offset = "0x1CD0890", VA = "0x181CD1A90")]
	public static EEJLFDCDOGD LKNPCKIALBL(this PMPBJLAJEHM HLCOOGAGOEK)
	{
		return default(EEJLFDCDOGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DKKNAEBPDDM
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x235E950", Offset = "0x235D750", VA = "0x18235E950")]
	public static void GEFHAJLOGPB<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> HLCOOGAGOEK, RepeatedField<TSerialized> BBFMJKBFLAL, DKHLJEINEKA<TDeserialized, TSerialized> ODKEOEFEHCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KOPEEPKNIFK
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB3B0", Offset = "0x1CEA1B0", VA = "0x181CEB3B0")]
	public static PJDMOCHPNDD OJBJHHLKILJ([In] this MLICGDNLACC HLCOOGAGOEK, [In] GFDIDGCOKOG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC> OPMPICBIMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB080", Offset = "0x1CE9E80", VA = "0x181CEB080")]
	public static MLICGDNLACC LKNPCKIALBL(this PJDMOCHPNDD HLCOOGAGOEK, [In] GFDIDGCOKOG<IKFLLCHHAHF, OGAMGKFNOJD, DOHDAHLOGBC> OPMPICBIMMG)
	{
		return default(MLICGDNLACC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BNKPKNKPNEF
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0D00", Offset = "0x1CCFB00", VA = "0x181CD0D00")]
	public static CEHAGCMCCJP OJBJHHLKILJ([In] this OBEIDHGKAAD HLCOOGAGOEK, [In] BANKIOHFCEE FAENJJOJFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0890", Offset = "0x1CCF690", VA = "0x181CD0890")]
	public static OBEIDHGKAAD LKNPCKIALBL(this CEHAGCMCCJP HLCOOGAGOEK, [In] BANKIOHFCEE FAENJJOJFNO)
	{
		return default(OBEIDHGKAAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AILLBMCJKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1CCED90", Offset = "0x1CCDB90", VA = "0x181CCED90")]
	public static BHIBKKGOFGJ OJBJHHLKILJ([In] this PGKLANPOGLJ HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1CCECE0", Offset = "0x1CCDAE0", VA = "0x181CCECE0")]
	public static PGKLANPOGLJ LKNPCKIALBL(this BHIBKKGOFGJ HLCOOGAGOEK)
	{
		return default(PGKLANPOGLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PIFAFAKCJLO
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFBC0", Offset = "0x1CEE9C0", VA = "0x181CEFBC0")]
	public static GCANEDHIHOB OJBJHHLKILJ(this HPKFJDHKMLI HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1CEF6A0", Offset = "0x1CEE4A0", VA = "0x181CEF6A0")]
	public static HPKFJDHKMLI LKNPCKIALBL(this GCANEDHIHOB HLCOOGAGOEK, [In] BIFKPLHLOKA HEJIOKNFDFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KGOANPGBFFO
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAEC0", Offset = "0x1CE9CC0", VA = "0x181CEAEC0")]
	public static ANMCLHDCFEF OJBJHHLKILJ([In] this FNHANFHBEAF HLCOOGAGOEK, BAMPGCHBHMA AOPDMLJGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAD70", Offset = "0x1CE9B70", VA = "0x181CEAD70")]
	public static FNHANFHBEAF LKNPCKIALBL(this ANMCLHDCFEF HLCOOGAGOEK)
	{
		return default(FNHANFHBEAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct DLHJJDKMCCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly MLOCHKHLPON<OGAMGKFNOJD> ILKEAPLCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly MLOCHKHLPON<IKFLLCHHAHF> MPGOMKBGOFP;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1802530", Offset = "0x1801330", VA = "0x181802530")]
	private DLHJJDKMCCK(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<OGAMGKFNOJD> BJJAFFNMJKF, MLOCHKHLPON<IKFLLCHHAHF> FHHDPKLNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD2610", Offset = "0x1CD1410", VA = "0x181CD2610")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, DLHJJDKMCCK> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, DLHJJDKMCCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x235F2C0", Offset = "0x235E0C0", VA = "0x18235F2C0")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] DLHJJDKMCCK HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct FMPJPEICMND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH>? DHDPJBNOBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly MLOCHKHLPON<ALHGGAPBPBA> APLKBDMNHFJ;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6030", Offset = "0x1CD4E30", VA = "0x181CD6030")]
	private FMPJPEICMND(MLOCHKHLPON<BJGNAPHFBHH>? FFGHNOABOCG, MLOCHKHLPON<ALHGGAPBPBA> FGHOJFDKLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5F50", Offset = "0x1CD4D50", VA = "0x181CD5F50")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, FMPJPEICMND> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, FMPJPEICMND>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x24DFFB0", Offset = "0x24DEDB0", VA = "0x1824DFFB0")]
	public static EFFPFBGFCJB<MLOCHKHLPON<BJGNAPHFBHH>, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] FMPJPEICMND HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<BJGNAPHFBHH>, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct GANGJPABONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public readonly MLOCHKHLPON<JNFHCKPJEOI> HAJOFOBKDKL;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1802530", Offset = "0x1801330", VA = "0x181802530")]
	private GANGJPABONO(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6350", Offset = "0x1CD5150", VA = "0x181CD6350")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, GANGJPABONO> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, GANGJPABONO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x24EDB50", Offset = "0x24EC950", VA = "0x1824EDB50")]
	public static EFFPFBGFCJB<MLOCHKHLPON<IKFLLCHHAHF>, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] GANGJPABONO HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<IKFLLCHHAHF>, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct BOFEAHLEPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public readonly MLOCHKHLPON<AGCCDPAGALI> EEDPCICBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public readonly ALABNNELONF BEDPIAEOKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public readonly PFGFFEFKBLO FGBNJMGCCIG;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1CD12E0", Offset = "0x1CD00E0", VA = "0x181CD12E0")]
	private BOFEAHLEPED(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<AGCCDPAGALI> LPKLNBMDHGN, [In] ALABNNELONF AJENLMKLGKJ, [In] PFGFFEFKBLO BACOEHLKBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1CD1170", Offset = "0x1CCFF70", VA = "0x181CD1170")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, BOFEAHLEPED> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, BOFEAHLEPED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x22B9D50", Offset = "0x22B8B50", VA = "0x1822B9D50")]
	public static EFFPFBGFCJB<MLOCHKHLPON<DOHDAHLOGBC>, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] BOFEAHLEPED HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<DOHDAHLOGBC>, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct PPOGLININKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly int GFBNMECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly BAFJLAKLIFO OIIFFAPKJEG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC290", Offset = "0x1CEB090", VA = "0x181CEC290")]
	private PPOGLININKE(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int HIDLGKEKBJA, BAFJLAKLIFO AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1CEFD20", Offset = "0x1CEEB20", VA = "0x181CEFD20")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, PPOGLININKE> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, PPOGLININKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x264F140", Offset = "0x264DF40", VA = "0x18264F140")]
	public static EFFPFBGFCJB<(MLOCHKHLPON<IKFLLCHHAHF>, MLOCHKHLPON<OGAMGKFNOJD>), JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] PPOGLININKE HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<(MLOCHKHLPON<IKFLLCHHAHF>, MLOCHKHLPON<OGAMGKFNOJD>), JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct MGJFKOFNKOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly int EMDCFHPBFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly BAFJLAKLIFO OIIFFAPKJEG;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC290", Offset = "0x1CEB090", VA = "0x181CEC290")]
	private MGJFKOFNKOL(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int HIDLGKEKBJA, BAFJLAKLIFO AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC120", Offset = "0x1CEAF20", VA = "0x181CEC120")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, MGJFKOFNKOL> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, MGJFKOFNKOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x257F150", Offset = "0x257DF50", VA = "0x18257F150")]
	public static EFFPFBGFCJB<(MLOCHKHLPON<OGAMGKFNOJD>, MLOCHKHLPON<IKFLLCHHAHF>), JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] MGJFKOFNKOL HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<(MLOCHKHLPON<OGAMGKFNOJD>, MLOCHKHLPON<IKFLLCHHAHF>), JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct JFOFMBOJAOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly int GFBNMECEMNE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1802530", Offset = "0x1801330", VA = "0x181802530")]
	private JFOFMBOJAOC(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int LJKKKOEHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA9E0", Offset = "0x1CE97E0", VA = "0x181CEA9E0")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, JFOFMBOJAOC> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, JFOFMBOJAOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x253B110", Offset = "0x2539F10", VA = "0x18253B110")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] JFOFMBOJAOC HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct JHDECBDGNJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly int EMDCFHPBFOF;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1802530", Offset = "0x1801330", VA = "0x181802530")]
	private JHDECBDGNJG(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, int LJKKKOEHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1CEAAA0", Offset = "0x1CE98A0", VA = "0x181CEAAA0")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, JHDECBDGNJG> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, JHDECBDGNJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x253B5D0", Offset = "0x253A3D0", VA = "0x18253B5D0")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] JHDECBDGNJG HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct JANKOEOCCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly MLOCHKHLPON<IKFLLCHHAHF> EICOHJDDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly FNHANFHBEAF JEEGFHLBLPF;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1CE98C0", Offset = "0x1CE86C0", VA = "0x181CE98C0")]
	private JANKOEOCCFJ(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<IKFLLCHHAHF> DLNMELFOEGB, [In] FNHANFHBEAF JDDKNLMJJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1CE97B0", Offset = "0x1CE85B0", VA = "0x181CE97B0")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, JANKOEOCCFJ> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, JANKOEOCCFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x25335D0", Offset = "0x25323D0", VA = "0x1825335D0")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] JANKOEOCCFJ HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct ELLBLHPMGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly MLOCHKHLPON<OGAMGKFNOJD> ILKEAPLCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly MLOCHKHLPON<IKFLLCHHAHF> MPGOMKBGOFP;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1802530", Offset = "0x1801330", VA = "0x181802530")]
	private ELLBLHPMGDF(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<OGAMGKFNOJD> BJJAFFNMJKF, MLOCHKHLPON<IKFLLCHHAHF> FHHDPKLNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1CD3C50", Offset = "0x1CD2A50", VA = "0x181CD3C50")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, ELLBLHPMGDF> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, ELLBLHPMGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x23AA470", Offset = "0x23A9270", VA = "0x1823AA470")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] ELLBLHPMGDF HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct OMECIEMAJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
	private OMECIEMAJEM(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1CEEAF0", Offset = "0x1CED8F0", VA = "0x181CEEAF0")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, OMECIEMAJEM> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, OMECIEMAJEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2634C70", Offset = "0x2633A70", VA = "0x182634C70")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] OMECIEMAJEM HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct AHGELAJIPHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> CLAECJANOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly MLOCHKHLPON<DOHDAHLOGBC> KLIBDGJKFAC;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9D7BB0", Offset = "0x9D69B0", VA = "0x1809D7BB0")]
	private AHGELAJIPHN(MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1CCEC20", Offset = "0x1CCDA20", VA = "0x181CCEC20")]
	public static OHGDAPNNJMC<GAJFIOFAGAG, AHGELAJIPHN> GNGKMPFLLPB(GNLMBGBJMJN BKLMNLJPNJP)
	{
		return default(OHGDAPNNJMC<GAJFIOFAGAG, AHGELAJIPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCCA0", Offset = "0x2AFBAA0", VA = "0x182AFCCA0")]
	public static EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO> ALGJBIHJFKO<TRoot>(TRoot NANDDCHCAEB, [In] AHGELAJIPHN HLCOOGAGOEK) where TRoot : NANIFDOGOHH
	{
		return default(EFFPFBGFCJB<CJPHMHJPNKO, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NKDECONJICN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Guid ENCEIJDIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly bool PEGPCAAGCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly bool OELBGDEDHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly bool ABIMAIMCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly bool IPDGFPMBCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly bool ANNDJDAEJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly List<(string Name, BAMPGCHBHMA Type)> MIICFOHGBOH;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Guid EDMBHINBAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC600", Offset = "0x1CEB400", VA = "0x181CEC600")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public IReadOnlyList<(string Name, BAMPGCHBHMA Type)> AALNAINHBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action CLDIJMPIAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC840", Offset = "0x1CEB640", VA = "0x181CEC840")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC610", Offset = "0x1CEB410", VA = "0x181CEC610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, BAMPGCHBHMA> NDHPDHOEDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC6B0", Offset = "0x1CEB4B0", VA = "0x181CEC6B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC550", Offset = "0x1CEB350", VA = "0x181CEC550")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> LJAFFEKGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC8E0", Offset = "0x1CEB6E0", VA = "0x181CEC8E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1CECA30", Offset = "0x1CEB830", VA = "0x181CECA30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OFAKADLGOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC990", Offset = "0x1CEB790", VA = "0x181CEC990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1CECAE0", Offset = "0x1CEB8E0", VA = "0x181CECAE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x199BC50", Offset = "0x199AA50", VA = "0x18199BC50")]
	public void JJLCJBCKMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1CECE00", Offset = "0x1CEBC00", VA = "0x181CECE00")]
	internal NKDECONJICN([In] Guid JPODHBJFPKM, string NDLLBBKGIJD, bool KLEKFIKGIDM, bool FMPIAAOFJIH, bool BKHOGKOPKBK, bool HACJCHGMGIP, bool JDPLILEOMDG, List<(string Name, BAMPGCHBHMA Type)> NMNEEHKOFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1CECCA0", Offset = "0x1CEBAA0", VA = "0x181CECCA0")]
	public static GDIDMHCKDLM MBBHLBOFKAO(string JPODHBJFPKM, string NDLLBBKGIJD, bool KLEKFIKGIDM = false, bool FMPIAAOFJIH = false, bool BKHOGKOPKBK = false, bool HACJCHGMGIP = true, bool JDPLILEOMDG = true)
	{
		return default(GDIDMHCKDLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1CEC760", Offset = "0x1CEB560", VA = "0x181CEC760")]
	public static NKDECONJICN JPNOENCBCBC([In] Guid JPODHBJFPKM, string NDLLBBKGIJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1CECDA0", Offset = "0x1CEBBA0", VA = "0x181CECDA0")]
	public void OPNLPMIMONA(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1CECB80", Offset = "0x1CEB980", VA = "0x181CECB80")]
	public void MANLEHLEMPB(string NDLLBBKGIJD, BAMPGCHBHMA MLMNOHIPKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1CECD30", Offset = "0x1CEBB30", VA = "0x181CECD30")]
	public void MHKGHKHLMHC(int NGIPPLLBEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct GDIDMHCKDLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Guid ENCEIJDIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string PPOHMFFHMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool EOELBPCNHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool MOHOPAFLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly bool IKOANFNILDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool BBKPIEJMNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly bool BLPDBBKIBOG;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1CD67C0", Offset = "0x1CD55C0", VA = "0x181CD67C0")]
	public GDIDMHCKDLM([In] Guid JPODHBJFPKM, string NDLLBBKGIJD, bool KLEKFIKGIDM, bool FMPIAAOFJIH, bool BKHOGKOPKBK, bool HACJCHGMGIP, bool JDPLILEOMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6520", Offset = "0x1CD5320", VA = "0x181CD6520")]
	public LGBDNMFKAGD COIEOMFCNJF(string NDLLBBKGIJD, BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(LGBDNMFKAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1CD66A0", Offset = "0x1CD54A0", VA = "0x181CD66A0")]
	public NKDECONJICN KIEPBNIPFMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct LGBDNMFKAGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Guid ENCEIJDIAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly string PPOHMFFHMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly bool EOELBPCNHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly bool MOHOPAFLJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly bool IKOANFNILDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly bool BBKPIEJMNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly bool BLPDBBKIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<(string Name, BAMPGCHBHMA Type)> MIICFOHGBOH;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB950", Offset = "0x1CEA750", VA = "0x181CEB950")]
	public LGBDNMFKAGD([In] Guid JPODHBJFPKM, string NDLLBBKGIJD, bool KLEKFIKGIDM, bool FMPIAAOFJIH, bool BKHOGKOPKBK, bool HACJCHGMGIP, bool JDPLILEOMDG, List<(string Name, BAMPGCHBHMA Type)> NMNEEHKOFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB730", Offset = "0x1CEA530", VA = "0x181CEB730")]
	public LGBDNMFKAGD COIEOMFCNJF(string NDLLBBKGIJD, BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(LGBDNMFKAGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB860", Offset = "0x1CEA660", VA = "0x181CEB860")]
	public NKDECONJICN KIEPBNIPFMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class IPDCIOPBHBI
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class BFCHLFJPEEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly NKDECONJICN MGEHOFFMBCF;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly NKDECONJICN PJCEFCHGDNP;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class KGCCCMIAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly NKDECONJICN ICEOPPCBGMA;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class FJEFDJFDGJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly NKDECONJICN LFKFNCPIBMG;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly NKDECONJICN BEHLMBCCKPA;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class MCACBIGNBGL
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly NKDECONJICN DCLLPKOADIO;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly NKDECONJICN KCFDCAJLHOE;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class GLDAPOFNELI
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly NKDECONJICN OGEMNOOBHKA;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly NKDECONJICN IIHOBEAFADI;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class JBMBELFILPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly NKDECONJICN LFKFNCPIBMG;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly NKDECONJICN BEHLMBCCKPA;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class GKIPAECLGLE
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly NKDECONJICN JGMPKPPPDII;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly NKDECONJICN DBFDMCLLFBN;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly NKDECONJICN FCPMAMEJGPC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly NKDECONJICN HFEEOENKBDD;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly NKDECONJICN EIIJDGMLLMI;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly NKDECONJICN MCJAHPHFIKO;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly NKDECONJICN ENEBKMMJHGP;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class HOCNHKBNMHE
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class LJLBENPILBC
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class GACPJIFNPGE
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class IEAPPJFDKEF
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly NKDECONJICN LPHLOGIEBFA;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly NKDECONJICN NJGMDMOBLIH;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class JMHFMKMAICL
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class NNMGENGHAAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class MKFADAGEAPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly NKDECONJICN ODNALBIPNPD;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class HGLNBHDAIPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly NKDECONJICN JBMKHCFCGOJ;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly NKDECONJICN NHMNFJAIILK;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly NKDECONJICN OGEMNOOBHKA;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly NKDECONJICN FJJBGEFEHON;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly NKDECONJICN DJMMLBPEGBM;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly NKDECONJICN IBHBCDFBBCH;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly NKDECONJICN APLKFKMHPGG;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly NKDECONJICN KBGMACOHCMN;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly NKDECONJICN EEDMAAENFNG;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly NKDECONJICN KPIJIKLBNOG;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly NKDECONJICN JAAFEMEMFCG;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly NKDECONJICN FOINBLBGABG;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly NKDECONJICN LLCIHDDKKNK;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly NKDECONJICN BIOPENDLBIE;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly NKDECONJICN OKIGFLPMIJM;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly NKDECONJICN OCBMGDCNFDI;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly NKDECONJICN IBGOJIDCACI;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly NKDECONJICN FALNBLMHOAK;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly NKDECONJICN DBOOAIAHHJN;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly NKDECONJICN PEHKPHNOFGD;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly NKDECONJICN HOPFPFGJJBK;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly NKDECONJICN PIELBGAANPE;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly NKDECONJICN BOLIHAGGCKP;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly NKDECONJICN GACLAHGFJNH;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly NKDECONJICN HMLFONJDFBA;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly NKDECONJICN KELDMBBEPOD;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly NKDECONJICN HJLONIPMODF;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly NKDECONJICN ONMLGBELLPC;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly NKDECONJICN LPAOILOFOKO;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly NKDECONJICN NLEBBCMDILG;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class LOJHMGDJPKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class GECIOPBMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly NKDECONJICN JBMKHCFCGOJ;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly NKDECONJICN GANDNGNEKOG;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class PFKJLCFLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly NKDECONJICN IFAEEJLLAHK;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly NKDECONJICN HPBKENBNECA;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly NKDECONJICN CANGNNDLECH;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly NKDECONJICN GEEKHIFOINF;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly NKDECONJICN HMLFHIMGCBN;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly NKDECONJICN BINLDNCAPEE;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class AHAHAJDBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class HDCOCALFIHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly NKDECONJICN LIHCAPBBGPC;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class OAJNNIFOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly NKDECONJICN ODNALBIPNPD;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class LFGMEPJHDJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class PKHPPEPOGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class BNKJPPOONJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly NKDECONJICN GCPKOIHCOID;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly NKDECONJICN MMKBECHBIPD;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly NKDECONJICN JJEDOKJPODK;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly NKDECONJICN COJNIEKKJMJ;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class DKIDGFNAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly NKDECONJICN KALCMEPDPJI;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly NKDECONJICN AGCPIDDGOEK;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class IDDEGCKHIIP
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class IOBFFJGACIP
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly NKDECONJICN AANDAKINJEO;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly NKDECONJICN CMGMCMNMENG;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly NKDECONJICN PFLGOEMJKKL;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly NKDECONJICN IOCFCNKCNCB;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly NKDECONJICN DOCOGONGIJN;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly NKDECONJICN OIJDBCEICGG;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly NKDECONJICN IKHPJIOOLAN;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly NKDECONJICN JKLBAOCIKDI;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly NKDECONJICN BFEPAFPJCBH;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly NKDECONJICN PGAAECEKFMI;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly NKDECONJICN LABDGACAJBM;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly NKDECONJICN HCFLFLFMJJD;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class MONCJKEJCKC
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class PNEKILKMCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly NKDECONJICN LABDGACAJBM;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly NKDECONJICN HCFLFLFMJJD;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly NKDECONJICN KANJJENKOPK;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly NKDECONJICN JLJDNILDHLA;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly NKDECONJICN NOMJEGLHKAP;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class NJPKEHNPMHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class INGBFJHPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly NKDECONJICN KPBIBMIPILK;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class JMNOPFHBLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly NKDECONJICN NIANOOBCIGB;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly NKDECONJICN HOFNGCKIKPF;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly NKDECONJICN LABDGACAJBM;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly NKDECONJICN HCFLFLFMJJD;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class INDOKIALALH
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class JDLKFMNBKOH
	{
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class JKBCCHJBNIM
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class CALDNIKLPCB
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class IPMLKPAJPJA
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly NKDECONJICN LPHLOGIEBFA;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly NKDECONJICN NJGMDMOBLIH;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class CDJPFENGOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly NKDECONJICN HIJHFNIIBGM;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly NKDECONJICN IPBENOBPMPP;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly NKDECONJICN MHJHGMICMGO;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public static readonly NKDECONJICN GDMDADBOKEB;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class EPCADPEOODP
	{
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly NKDECONJICN HIJHFNIIBGM;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly NKDECONJICN IPBENOBPMPP;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly NKDECONJICN MHJHGMICMGO;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly NKDECONJICN GDMDADBOKEB;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class NOIGHDPEKCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class BPIKAHJAGIP
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly NKDECONJICN MMJCPPIPIBA;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly NKDECONJICN CJBAODNFJBF;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly NKDECONJICN KEELLDNPACM;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class EBFJIFHKCED
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly NKDECONJICN LBCNDPFFOJJ;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public static readonly NKDECONJICN MJCKMOKMDJE;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly NKDECONJICN EFEKOHABBJN;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class FGKJJGMCCMH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class CNGBHMPFJLP
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly NKDECONJICN FLMOODEFKAO;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly NKDECONJICN EIPAPOLDAEE;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly NKDECONJICN NIMNIIJOPLI;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class ELMNBMHNCPH
	{
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly NKDECONJICN JOMHHJCGKKI;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class MBCEEAECACD
	{
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly NKDECONJICN OLKODCAOBKE;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public static readonly NKDECONJICN DLJKKIACBKB;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static readonly NKDECONJICN MMJKDHDLGGG;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class MAJCGFEHHML
	{
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class OPEDGGCKEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class LHMFFIMFNNL
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly NKDECONJICN PIKJDMEEKGF;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly NKDECONJICN KAKMACAEMCD;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly NKDECONJICN CCFIHKCGIFM;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		internal static readonly NKDECONJICN[] EAEJOAJPIKL;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class HHHKMBCLJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public readonly BAMPGCHBHMA HLPMDJBCNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly List<NKDECONJICN> HFDKBKCIHFC;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public IReadOnlyList<NKDECONJICN> FGHCNKACOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6B10", Offset = "0x1CF5910", VA = "0x181CF6B10")]
	protected HHHKMBCLJCG(BAMPGCHBHMA AKIHEIIPHFJ, params NKDECONJICN[][] CDGPINCMLEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DDMJPFMJIIP : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3E80", Offset = "0x1CF2C80", VA = "0x181CF3E80")]
	internal DDMJPFMJIIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DMEHNBFFDLC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4240", Offset = "0x1CF3040", VA = "0x181CF4240")]
	internal DMEHNBFFDLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class JEMACEBBAHC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8B70", Offset = "0x1CF7970", VA = "0x181CF8B70")]
	internal JEMACEBBAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class APAIDCLGDDL : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1A50", Offset = "0x1CF0850", VA = "0x181CF1A50")]
	internal APAIDCLGDDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KGMOEBCOJEC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9AA0", Offset = "0x1CF88A0", VA = "0x181CF9AA0")]
	internal KGMOEBCOJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class ENNDPFJGGGN : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4FC0", Offset = "0x1CF3DC0", VA = "0x181CF4FC0")]
	internal ENNDPFJGGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class JBMMLPOOGBP : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8740", Offset = "0x1CF7540", VA = "0x181CF8740")]
	internal JBMMLPOOGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class IMJPKCAJDII : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7E10", Offset = "0x1CF6C10", VA = "0x181CF7E10")]
	internal IMJPKCAJDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PAENKJIDBFF : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD190", Offset = "0x1CFBF90", VA = "0x181CFD190")]
	internal PAENKJIDBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class POPDPJAMICI : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE140", Offset = "0x1CFCF40", VA = "0x181CFE140")]
	internal POPDPJAMICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class EEDCHNELEPB : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1CF48D0", Offset = "0x1CF36D0", VA = "0x181CF48D0")]
	internal EEDCHNELEPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class KCKHGOEKOJG : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9560", Offset = "0x1CF8360", VA = "0x181CF9560")]
	internal KCKHGOEKOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class PFPPKKCGFGH : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD370", Offset = "0x1CFC170", VA = "0x181CFD370")]
	internal PFPPKKCGFGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class MBCKEKBPIFF : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAB50", Offset = "0x1CF9950", VA = "0x181CFAB50")]
	internal MBCKEKBPIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class CHCINAJFNKE : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2DD0", Offset = "0x1CF1BD0", VA = "0x181CF2DD0")]
	internal CHCINAJFNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KHBPPIIFGME : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9C80", Offset = "0x1CF8A80", VA = "0x181CF9C80")]
	internal KHBPPIIFGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class LIFEABPHFCE : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA4C0", Offset = "0x1CF92C0", VA = "0x181CFA4C0")]
	internal LIFEABPHFCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class HMFLIAPPNAH : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6DF0", Offset = "0x1CF5BF0", VA = "0x181CF6DF0")]
	internal HMFLIAPPNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JGGOBNBGEKN : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8D50", Offset = "0x1CF7B50", VA = "0x181CF8D50")]
	internal JGGOBNBGEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class OENBABNAHCE : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC9A0", Offset = "0x1CFB7A0", VA = "0x181CFC9A0")]
	internal OENBABNAHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OCHGBJMDDPC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC7C0", Offset = "0x1CFB5C0", VA = "0x181CFC7C0")]
	internal OCHGBJMDDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class AKLLKKDPODN : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1610", Offset = "0x1CF0410", VA = "0x181CF1610")]
	internal AKLLKKDPODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class FPKFJHJFHBJ : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6060", Offset = "0x1CF4E60", VA = "0x181CF6060")]
	internal FPKFJHJFHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class FLKIOOBHNIC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5CA0", Offset = "0x1CF4AA0", VA = "0x181CF5CA0")]
	internal FLKIOOBHNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class ICNECJFCJLC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1CF71B0", Offset = "0x1CF5FB0", VA = "0x181CF71B0")]
	internal ICNECJFCJLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class MBCMMEOMDPC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAD30", Offset = "0x1CF9B30", VA = "0x181CFAD30")]
	internal MBCMMEOMDPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class IDIKNNIHOPF : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7570", Offset = "0x1CF6370", VA = "0x181CF7570")]
	internal IDIKNNIHOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class KNLJIBIAHOC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9EE0", Offset = "0x1CF8CE0", VA = "0x181CF9EE0")]
	internal KNLJIBIAHOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class OOIJNNJAPMF : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCF40", Offset = "0x1CFBD40", VA = "0x181CFCF40")]
	internal OOIJNNJAPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class DIDAAAKLEJJ : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4060", Offset = "0x1CF2E60", VA = "0x181CF4060")]
	internal DIDAAAKLEJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class NDFGACCKOLD : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB960", Offset = "0x1CFA760", VA = "0x181CFB960")]
	internal NDFGACCKOLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class JBOBBNPOLBP : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8920", Offset = "0x1CF7720", VA = "0x181CF8920")]
	internal JBOBBNPOLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class MOCPCONMDEF : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB710", Offset = "0x1CFA510", VA = "0x181CFB710")]
	internal MOCPCONMDEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class IMDGHMPPCPL : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7C30", Offset = "0x1CF6A30", VA = "0x181CF7C30")]
	internal IMDGHMPPCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class AKEFOBPJEFD : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1430", Offset = "0x1CF0230", VA = "0x181CF1430")]
	internal AKEFOBPJEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class EEDDNCGECPG : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF49A0", Offset = "0x1CF37A0", VA = "0x181CF49A0")]
	internal EEDDNCGECPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class IJEIDLKJALP : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7930", Offset = "0x1CF6730", VA = "0x181CF7930")]
	internal IJEIDLKJALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class OHAADIPBBGM : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCD60", Offset = "0x1CFBB60", VA = "0x181CFCD60")]
	internal OHAADIPBBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class IDGFKNINPOC : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7390", Offset = "0x1CF6190", VA = "0x181CF7390")]
	internal IDGFKNINPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class IIOHBNHPGMA : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7750", Offset = "0x1CF6550", VA = "0x181CF7750")]
	internal IIOHBNHPGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class EKDPOBNOPOD : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4B80", Offset = "0x1CF3980", VA = "0x181CF4B80")]
	internal EKDPOBNOPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class HJAPNAPBNCK : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6C10", Offset = "0x1CF5A10", VA = "0x181CF6C10")]
	internal HJAPNAPBNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NIHFANJMNNL : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBB40", Offset = "0x1CFA940", VA = "0x181CFBB40")]
	internal NIHFANJMNNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class FPEOCJOPAEH : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5E80", Offset = "0x1CF4C80", VA = "0x181CF5E80")]
	internal FPEOCJOPAEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class PLMOKLEHCNN : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD780", Offset = "0x1CFC580", VA = "0x181CFD780")]
	internal PLMOKLEHCNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class IAOBDPJNDJL : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6FD0", Offset = "0x1CF5DD0", VA = "0x181CF6FD0")]
	internal IAOBDPJNDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class HEPEGDKADAO : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6930", Offset = "0x1CF5730", VA = "0x181CF6930")]
	internal HEPEGDKADAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class OFFDFIJACJE : HHHKMBCLJCG
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCB80", Offset = "0x1CFB980", VA = "0x181CFCB80")]
	internal OFFDFIJACJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public sealed class BCEHPOJDBGG : KEHAPBGLOFC
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1DD0", Offset = "0x1CF0BD0", VA = "0x181CF1DD0")]
	public BCEHPOJDBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public abstract class NGNANODCNLF : EINCBCMKCGI<HPKFJDHKMLI>
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5BF0", Offset = "0x1CF49F0", VA = "0x181CF5BF0")]
	protected NGNANODCNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public abstract class ILOKOOBKIGL : NMDENCNOGEP<HPKFJDHKMLI>
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2FB0", Offset = "0x1CF1DB0", VA = "0x181CF2FB0")]
	protected ILOKOOBKIGL([In] BGFMJNFNLAD NCINMLELLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7B10", Offset = "0x1CF6910", VA = "0x181CF7B10", Slot = "11")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7BA0", Offset = "0x1CF69A0", VA = "0x181CF7BA0", Slot = "14")]
	public override void MNLEMGBKMKD(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class CKNLHBCIOPK : ILOKOOBKIGL
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF2FB0", Offset = "0x1CF1DB0", VA = "0x181CF2FB0")]
	public CKNLHBCIOPK([In] BGFMJNFNLAD NCINMLELLJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class MECKFOAJBDF : NGNANODCNLF
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "11")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "12")]
	public override void BAODKCEMNKL(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAF10", Offset = "0x1CF9D10", VA = "0x181CFAF10", Slot = "13")]
	public override IEnumerable<GLHGDGFFHLN<BAMPGCHBHMA>> KIMDFDKMJGH(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAF40", Offset = "0x1CF9D40", VA = "0x181CFAF40", Slot = "14")]
	public override void MNLEMGBKMKD(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB1C0", Offset = "0x1CF9FC0", VA = "0x181CFB1C0")]
	public static void NEBAPAHNKHM(HPKFJDHKMLI ALEKFBOABOP, [In] AIJPPNFOECJ.PIEOHDOGKFC FBDIJMAHHKB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<OGAMGKFNOJD> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5900", Offset = "0x1CF4700", VA = "0x181CF5900", Slot = "15")]
	public override FNHANFHBEAF KEOLMBHJKCC(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, BAMPGCHBHMA OMKGHHBPEDJ)
	{
		return default(FNHANFHBEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5BF0", Offset = "0x1CF49F0", VA = "0x181CF5BF0")]
	public MECKFOAJBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class OCANDIGPHLL : NGNANODCNLF
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class DCECDAHFPJA : EJOOHFJCFEJ.JPFCGFCALJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct EPJAKNGFHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public readonly MLOCHKHLPON<BJGNAPHFBHH> JIJBABNPLPE;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
		private EPJAKNGFHMO(MLOCHKHLPON<BJGNAPHFBHH> KDPCEPLFGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
		public static EPJAKNGFHMO FMIHPEHEFKO(MLOCHKHLPON<BJGNAPHFBHH> MCEEEELIIJM)
		{
			return default(EPJAKNGFHMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC040", Offset = "0x1CFAE40", VA = "0x181CFC040", Slot = "11")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBE00", Offset = "0x1CFAC00", VA = "0x181CFBE00", Slot = "12")]
	public override void BAODKCEMNKL(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC1E0", Offset = "0x1CFAFE0", VA = "0x181CFC1E0", Slot = "13")]
	public override IEnumerable<GLHGDGFFHLN<BAMPGCHBHMA>> KIMDFDKMJGH(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC270", Offset = "0x1CFB070", VA = "0x181CFC270", Slot = "14")]
	public override void MNLEMGBKMKD(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBF70", Offset = "0x1CFAD70", VA = "0x181CFBF70")]
	public static void JIHHEFAABGH(HPKFJDHKMLI ALEKFBOABOP, [In] AIJPPNFOECJ.PIEOHDOGKFC FBDIJMAHHKB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<IKFLLCHHAHF> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC6F0", Offset = "0x1CFB4F0", VA = "0x181CFC6F0")]
	public static void NEBAPAHNKHM(HPKFJDHKMLI ALEKFBOABOP, [In] AIJPPNFOECJ.PIEOHDOGKFC FBDIJMAHHKB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<OGAMGKFNOJD> IEHMFIJKAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5900", Offset = "0x1CF4700", VA = "0x181CF5900", Slot = "15")]
	public override FNHANFHBEAF KEOLMBHJKCC(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, BAMPGCHBHMA OMKGHHBPEDJ)
	{
		return default(FNHANFHBEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5BF0", Offset = "0x1CF49F0", VA = "0x181CF5BF0")]
	public OCANDIGPHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class FCCDGNGJGFA : NGNANODCNLF
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "11")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "12")]
	public override void BAODKCEMNKL(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5940", Offset = "0x1CF4740", VA = "0x181CF5940", Slot = "13")]
	public override IEnumerable<GLHGDGFFHLN<BAMPGCHBHMA>> KIMDFDKMJGH(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5970", Offset = "0x1CF4770", VA = "0x181CF5970", Slot = "14")]
	public override void MNLEMGBKMKD(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5820", Offset = "0x1CF4620", VA = "0x181CF5820")]
	public static void JIHHEFAABGH(HPKFJDHKMLI ALEKFBOABOP, [In] AIJPPNFOECJ.PIEOHDOGKFC FBDIJMAHHKB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<IKFLLCHHAHF> DLNMELFOEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5900", Offset = "0x1CF4700", VA = "0x181CF5900", Slot = "15")]
	public override FNHANFHBEAF KEOLMBHJKCC(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, BAMPGCHBHMA OMKGHHBPEDJ)
	{
		return default(FNHANFHBEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5BF0", Offset = "0x1CF49F0", VA = "0x181CF5BF0")]
	public FCCDGNGJGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class GBLDJILFBOH : ILOKOOBKIGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public readonly MLOCHKHLPON<JNFHCKPJEOI> JOBBHINGANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public readonly MLOCHKHLPON<GPPPMJHGDAG> HPLMANPAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public readonly MLOCHKHLPON<GPPPMJHGDAG> DFAOPJEDJBL;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF62C0", Offset = "0x1CF50C0", VA = "0x181CF62C0")]
	public GBLDJILFBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class KEHAPBGLOFC : JLMIPAAPBLM<HPKFJDHKMLI>
{
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9A50", Offset = "0x1CF8850", VA = "0x181CF9A50")]
	protected KEHAPBGLOFC([In] GIKCAGHLFGK NCINMLELLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF97E0", Offset = "0x1CF85E0", VA = "0x181CF97E0", Slot = "11")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? IBDCDGNNIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9740", Offset = "0x1CF8540", VA = "0x181CF9740", Slot = "12")]
	public override void BAODKCEMNKL(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF99C0", Offset = "0x1CF87C0", VA = "0x181CF99C0", Slot = "14")]
	public override void MNLEMGBKMKD(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9890", Offset = "0x1CF8690", VA = "0x181CF9890", Slot = "17")]
	public override EFFPFBGFCJB<MLOCHKHLPON<IKFLLCHHAHF>, JLMPFOOAOBO> MHGKCEIMJKF(HPKFJDHKMLI NANDDCHCAEB, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, MLOCHKHLPON<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP)
	{
		return default(EFFPFBGFCJB<MLOCHKHLPON<IKFLLCHHAHF>, JLMPFOOAOBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class AMFPOJCJMGL : CKNLHBCIOPK
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF17F0", Offset = "0x1CF05F0", VA = "0x181CF17F0")]
	public AMFPOJCJMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct PGKLANPOGLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public ALABNNELONF BEDPIAEOKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public PFGFFEFKBLO FGBNJMGCCIG;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD5A0", Offset = "0x1CFC3A0", VA = "0x181CFD5A0")]
	internal PGKLANPOGLJ([In] ALABNNELONF EHFMGFPLNPD, [In] PFGFFEFKBLO GBLLLKBIFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD570", Offset = "0x1CFC370", VA = "0x181CFD570")]
	public static PGKLANPOGLJ FMIHPEHEFKO()
	{
		return default(PGKLANPOGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD550", Offset = "0x1CFC350", VA = "0x181CFD550")]
	public static PGKLANPOGLJ BDOHGNMNHBJ([In] ALABNNELONF EHFMGFPLNPD, [In] PFGFFEFKBLO GBLLLKBIFDK)
	{
		return default(PGKLANPOGLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class GONPDPOLKGO : KEHAPBGLOFC
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF65C0", Offset = "0x1CF53C0", VA = "0x181CF65C0")]
	public GONPDPOLKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class KJHNJKNCLDF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class AIJPPNFOECJ : OAADMGFGNDN
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class CDKHNMNAAEI : KJKBDHLLKII.LPEGHPNKIMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public struct PIEOHDOGKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public string NKCKPGIEOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public NCBLLHFNNBM<JNFHCKPJEOI, BAFJLAKLIFO> ELKKKACNHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public NCBLLHFNNBM<GPPPMJHGDAG, BAFJLAKLIFO> KOKPAKJGFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public readonly MLOCHKHLPON<DOHDAHLOGBC> BMPJAMDGNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public readonly MLOCHKHLPON<DOHDAHLOGBC> JJNHBDGBFKK;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD710", Offset = "0x1CFC510", VA = "0x181CFD710")]
		private PIEOHDOGKFC(string NDLLBBKGIJD, [In] NCBLLHFNNBM<JNFHCKPJEOI, BAFJLAKLIFO> IPPPJIKJIOK, [In] NCBLLHFNNBM<GPPPMJHGDAG, BAFJLAKLIFO> ANLOCKABCAM, MLOCHKHLPON<DOHDAHLOGBC> KHJHCPNEPFK, MLOCHKHLPON<DOHDAHLOGBC> IPPJLGEKGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD640", Offset = "0x1CFC440", VA = "0x181CFD640")]
		public static PIEOHDOGKFC FMIHPEHEFKO(MLOCHKHLPON<DOHDAHLOGBC> KOLIDJEDFEN, MLOCHKHLPON<DOHDAHLOGBC> JFGCNLPBIAG)
		{
			return default(PIEOHDOGKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1CFD5C0", Offset = "0x1CFC3C0", VA = "0x181CFD5C0")]
		public static PIEOHDOGKFC BDOHGNMNHBJ(string NDLLBBKGIJD, [In] NCBLLHFNNBM<JNFHCKPJEOI, BAFJLAKLIFO> IPPPJIKJIOK, [In] NCBLLHFNNBM<GPPPMJHGDAG, BAFJLAKLIFO> ANLOCKABCAM, MLOCHKHLPON<DOHDAHLOGBC> KOLIDJEDFEN, MLOCHKHLPON<DOHDAHLOGBC> JFGCNLPBIAG)
		{
			return default(PIEOHDOGKFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1050", Offset = "0x1CEFE50", VA = "0x181CF1050", Slot = "8")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? OBCCGMFFBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1CF0E50", Offset = "0x1CEFC50", VA = "0x181CF0E50", Slot = "9")]
	public override void BAODKCEMNKL(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF13F0", Offset = "0x1CF01F0", VA = "0x181CF13F0")]
	public AIJPPNFOECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class IPHJBGDLDAN
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8310", Offset = "0x1CF7110", VA = "0x181CF8310")]
	public static void IFMJALEKMOK(this AIJPPNFOECJ.PIEOHDOGKFC HLCOOGAGOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public abstract class OAADMGFGNDN : NDGCIAFBFKH<HPKFJDHKMLI>
{
	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF13F0", Offset = "0x1CF01F0", VA = "0x181CF13F0")]
	protected OAADMGFGNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public readonly struct BAFJLAKLIFO : IEquatable<BAFJLAKLIFO>, AEHDPJNHKCC<BAFJLAKLIFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string NKCKPGIEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly BAMPGCHBHMA OIIFFAPKJEG;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	private BAFJLAKLIFO(string NDLLBBKGIJD, BAMPGCHBHMA AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB3D0", Offset = "0x1CCA1D0", VA = "0x181CCB3D0")]
	public static BAFJLAKLIFO FMIHPEHEFKO(string NDLLBBKGIJD, BAMPGCHBHMA AOPDMLJGEMB)
	{
		return default(BAFJLAKLIFO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C30", Offset = "0x1CF0A30", VA = "0x181CF1C30")]
	public static bool HIHGGPGGFPN([In] BAFJLAKLIFO KADNMONNONH, [In] BAFJLAKLIFO DCAFNABOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C30", Offset = "0x1CF0A30", VA = "0x181CF1C30", Slot = "4")]
	public bool Equals(BAFJLAKLIFO LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C30", Offset = "0x1CF0A30", VA = "0x181CF1C30")]
	public bool PBIEABNKMNG([In] BAFJLAKLIFO LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C80", Offset = "0x1CF0A80", VA = "0x181CF1C80", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1D30", Offset = "0x1CF0B30", VA = "0x181CF1D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1D90", Offset = "0x1CF0B90", VA = "0x181CF1D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF1C30", Offset = "0x1CF0A30", VA = "0x181CF1C30", Slot = "5")]
	private bool CGFGPKAECJO([In] BAFJLAKLIFO LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class EHKPGLCOBFD : OAADMGFGNDN
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "8")]
	public override void KFHFDCMCMAB(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, HNDBIENACOA COBIPBKFCCM, MLOCHKHLPON<KHFEHAIPGCK.KDOLGBHEMEG>? OBCCGMFFBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "9")]
	public override void BAODKCEMNKL(HPKFJDHKMLI ALEKFBOABOP, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF13F0", Offset = "0x1CF01F0", VA = "0x181CF13F0")]
	public EHKPGLCOBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct MLICGDNLACC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public EBPMFLLAEFM<DOHDAHLOGBC, PGKLANPOGLJ> AMNNMJIFCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public GCIMOGLIMHK<OCANDIGPHLL.DCECDAHFPJA> KFFMDFPELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public EBPMFLLAEFM<OCANDIGPHLL.DCECDAHFPJA, OCANDIGPHLL.EPJAKNGFHMO> JHDODDJAIPJ;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB6A0", Offset = "0x1CFA4A0", VA = "0x181CFB6A0")]
	private MLICGDNLACC([In] EBPMFLLAEFM<DOHDAHLOGBC, PGKLANPOGLJ> ODGBHJCIJDK, [In] GCIMOGLIMHK<OCANDIGPHLL.DCECDAHFPJA> HCGGBPCMMDM, [In] EBPMFLLAEFM<OCANDIGPHLL.DCECDAHFPJA, OCANDIGPHLL.EPJAKNGFHMO> MNOBGAKOBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB5B0", Offset = "0x1CFA3B0", VA = "0x181CFB5B0")]
	public static MLICGDNLACC FMIHPEHEFKO()
	{
		return default(MLICGDNLACC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB520", Offset = "0x1CFA320", VA = "0x181CFB520")]
	public static MLICGDNLACC BDOHGNMNHBJ([In] EBPMFLLAEFM<DOHDAHLOGBC, PGKLANPOGLJ> ODGBHJCIJDK, [In] GCIMOGLIMHK<OCANDIGPHLL.DCECDAHFPJA> HCGGBPCMMDM, [In] EBPMFLLAEFM<OCANDIGPHLL.DCECDAHFPJA, OCANDIGPHLL.EPJAKNGFHMO> MNOBGAKOBHL)
	{
		return default(MLICGDNLACC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class FPMCDKGDFEO
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6240", Offset = "0x1CF5040", VA = "0x181CF6240")]
	public static void IFMJALEKMOK(this MLICGDNLACC HLCOOGAGOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct OBEIDHGKAAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public EBPMFLLAEFM<BJGNAPHFBHH, MLICGDNLACC> CPCIHCKEGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public GCIMOGLIMHK<AIJPPNFOECJ.CDKHNMNAAEI> OGJBNCJNJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public EBPMFLLAEFM<AIJPPNFOECJ.CDKHNMNAAEI, AIJPPNFOECJ.PIEOHDOGKFC> MNOGMDADHND;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB6A0", Offset = "0x1CFA4A0", VA = "0x181CFB6A0")]
	private OBEIDHGKAAD([In] EBPMFLLAEFM<BJGNAPHFBHH, MLICGDNLACC> BLKANEONNOI, [In] GCIMOGLIMHK<AIJPPNFOECJ.CDKHNMNAAEI> ABJANHIGKNO, [In] EBPMFLLAEFM<AIJPPNFOECJ.CDKHNMNAAEI, AIJPPNFOECJ.PIEOHDOGKFC> ALNHNGHDBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB520", Offset = "0x1CFA320", VA = "0x181CFB520")]
	public static OBEIDHGKAAD BDOHGNMNHBJ([In] EBPMFLLAEFM<BJGNAPHFBHH, MLICGDNLACC> BLKANEONNOI, [In] GCIMOGLIMHK<AIJPPNFOECJ.CDKHNMNAAEI> ABJANHIGKNO, [In] EBPMFLLAEFM<AIJPPNFOECJ.CDKHNMNAAEI, AIJPPNFOECJ.PIEOHDOGKFC> ALNHNGHDBFB)
	{
		return default(OBEIDHGKAAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class DCIIHEANBAI
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3A80", Offset = "0x1CF2880", VA = "0x181CF3A80")]
	public static void IFMJALEKMOK(this OBEIDHGKAAD HLCOOGAGOEK, [In] BANKIOHFCEE OGNEMFAEDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF37B0", Offset = "0x1CF25B0", VA = "0x181CF37B0")]
	public static void AJFPOFBBGPG(this OBEIDHGKAAD HLCOOGAGOEK, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, [In] MLICGDNLACC OPMPICBIMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3810", Offset = "0x1CF2610", VA = "0x181CF3810")]
	public static void HCFLFLFMJJD(this OBEIDHGKAAD HLCOOGAGOEK, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM, [In] BANKIOHFCEE OGNEMFAEDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3A20", Offset = "0x1CF2820", VA = "0x181CF3A20")]
	public static MLICGDNLACC HFNEOIKDHBA([In] this OBEIDHGKAAD HLCOOGAGOEK, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
		return default(MLICGDNLACC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3E20", Offset = "0x1CF2C20", VA = "0x181CF3E20")]
	public static MLICGDNLACC IGBEFMOAHGD(this OBEIDHGKAAD HLCOOGAGOEK, MLOCHKHLPON<BJGNAPHFBHH> MOFFGNIDNJM)
	{
		return default(MLICGDNLACC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface DGHEHDCIAKI
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLOCHKHLPON<EGCNCIDBIAF> HCIDHEJOPMI(DINOMMGCMNK BEKGBKIFHLH);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class MHGDIINEJHI : IEFKCNCGCCP<MHGDIINEJHI, HPKFJDHKMLI>, DGHEHDCIAKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private NCBLLHFNNBM<EGCNCIDBIAF, DINOMMGCMNK> NCGFKGMMCDG;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB3A0", Offset = "0x1CFA1A0", VA = "0x181CFB3A0", Slot = "6")]
	public MLOCHKHLPON<EGCNCIDBIAF> HCIDHEJOPMI(DINOMMGCMNK BEKGBKIFHLH)
	{
		return default(MLOCHKHLPON<EGCNCIDBIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB4A0", Offset = "0x1CFA2A0", VA = "0x181CFB4A0")]
	private MHGDIINEJHI([In] NCBLLHFNNBM<AGCCDPAGALI, HMPKOKPCHPM<HPKFJDHKMLI>> CKPFGMCCCJH, [In] NCBLLHFNNBM<ALHGGAPBPBA, INFPNMHFIJF<HPKFJDHKMLI>> BOOCBDHDANP, [In] NCBLLHFNNBM<EGCNCIDBIAF, DINOMMGCMNK> CAPNOBFOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB2A0", Offset = "0x1CFA0A0", VA = "0x181CFB2A0")]
	public static MHGDIINEJHI FMIHPEHEFKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB3F0", Offset = "0x1CFA1F0", VA = "0x181CFB3F0")]
	public new (OAEADIDHHCL<AGCCDPAGALI, HMPKOKPCHPM<HPKFJDHKMLI>>, OAEADIDHHCL<ALHGGAPBPBA, INFPNMHFIJF<HPKFJDHKMLI>>, OAEADIDHHCL<EGCNCIDBIAF, DINOMMGCMNK>) ICNFLNGJCLD()
	{
		return default((OAEADIDHHCL<AGCCDPAGALI, HMPKOKPCHPM<HPKFJDHKMLI>>, OAEADIDHHCL<ALHGGAPBPBA, INFPNMHFIJF<HPKFJDHKMLI>>, OAEADIDHHCL<EGCNCIDBIAF, DINOMMGCMNK>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public sealed class JJAMPFGMGOK : BHDBCNGGGDH
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8F30", Offset = "0x1CF7D30", VA = "0x181CF8F30", Slot = "7")]
	public override string BCJNMAHEGJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8F60", Offset = "0x1CF7D60", VA = "0x181CF8F60")]
	public JJAMPFGMGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface AEKPLBLLCEB
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DINOMMGCMNK IMDACPKBNHB();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DINOMMGCMNK DAPMBMBAHKH();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DINOMMGCMNK BEGOADCNKON();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface CDJCMODHOBD
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFFPFBGFCJB<object, FCBFPODNPBP>> OLMIIOMKEEH(GNLMBGBJMJN CBNAIFNPGEI, bool LIKFPADOMED);
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
