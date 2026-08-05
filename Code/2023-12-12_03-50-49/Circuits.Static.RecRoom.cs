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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CFF9B0", Offset = "0x1CFE1B0", VA = "0x181CFF9B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GGLEBAMLBCO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB6B0", Offset = "0x1CE9EB0", VA = "0x181CEB6B0")]
	public static bool EMIBJGHOODD(this CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB5F0", Offset = "0x1CE9DF0", VA = "0x181CEB5F0")]
	public static bool EMIBJGHOODD(this OPNNOPPDGDE KHHECNHEFGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface AKNNCAJBOEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HEBMGMFICMC? LLILDDMCOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class BOHOOFEIFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3950", Offset = "0x1CE2150", VA = "0x181CE3950")]
	internal static DCCDIHPMMLE LLILDDMCOMH(this AKNNCAJBOEB PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3790", Offset = "0x1CE1F90", VA = "0x181CE3790")]
	internal static LBFOJMHFNLD<DCCDIHPMMLE, BEKBEBIBBCL> ALAHBPHHBFE(this AKNNCAJBOEB PIEBBHMNEOG)
	{
		return default(LBFOJMHFNLD<DCCDIHPMMLE, BEKBEBIBBCL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HEBMGMFICMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly DCCDIHPMMLE LLILDDMCOMH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	public HEBMGMFICMC(DCCDIHPMMLE CGIAHINKELD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MELONPFIKOP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25903C0", Offset = "0x258EBC0", VA = "0x1825903C0")]
	public static OBFNFIDHDKL<PPOILEHMDEK, JNDFKAPOEAK, TRoot, LCPNCEBBACA.IJBAKLDHLPI<PPOILEHMDEK, JNDFKAPOEAK, TRoot>> BBINMFMCEEO<TRoot>([In] this OBFNFIDHDKL<PPOILEHMDEK, JNDFKAPOEAK, TRoot, LCPNCEBBACA.IJBAKLDHLPI<PPOILEHMDEK, JNDFKAPOEAK, TRoot>> EJMBNENAIFJ) where TRoot : AKNNCAJBOEB
	{
		return default(OBFNFIDHDKL<PPOILEHMDEK, JNDFKAPOEAK, TRoot, LCPNCEBBACA.IJBAKLDHLPI<PPOILEHMDEK, JNDFKAPOEAK, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BNJIHBFCHHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface HGHHDNAGGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		GHKILDFDOLJ FAKEEMEKHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct CMHPIKODLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly LICAKHGBNBJ NJIJHMBMELA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
		public CMHPIKODLJF(LICAKHGBNBJ BOPDMOEPEOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CNCHLHIFBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public BIAFJNPKHBL<GOOGICFALMF> KDHADGCNJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BIAFJNPKHBL<GOOGICFALMF> FOBECBABIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public BIAFJNPKHBL<GOOGICFALMF> PLOILJHCBOH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3BD0", Offset = "0x1CE23D0", VA = "0x181CE3BD0")]
		public static CNCHLHIFBAG AKKFLOCCMNP(IIDKLDGKAOP HCLNPCAIBJA, GHKILDFDOLJ JFHMOFHDJOF)
		{
			return default(CNCHLHIFBAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IKPOHANJNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BIAFJNPKHBL<CGJGKMDFDEE> KHLKFIAPGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BIAFJNPKHBL<CGJGKMDFDEE> OLBGDIPNKJD;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9810", Offset = "0x1CF8010", VA = "0x181CF9810")]
		public static IKPOHANJNGO AKKFLOCCMNP(GLIBLPHGCMG<DCCDIHPMMLE> HCLNPCAIBJA)
		{
			return default(IKPOHANJNGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct ODCLAJCJOLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public BIAFJNPKHBL<FIOKAOEJDHN> NBHPHNHPOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BIAFJNPKHBL<FIOKAOEJDHN> DCPEPIAIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BIAFJNPKHBL<FIOKAOEJDHN> APENOAMKPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public BIAFJNPKHBL<FIOKAOEJDHN> NJOLLANBMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public BIAFJNPKHBL<FIOKAOEJDHN> OFDLCIEIEAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BIAFJNPKHBL<FIOKAOEJDHN> OODLJMMPJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BIAFJNPKHBL<FIOKAOEJDHN> LOPHKPBLBNL;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFAA0", Offset = "0x1CFE2A0", VA = "0x181CFFAA0")]
		public static ODCLAJCJOLG AKKFLOCCMNP(GAANLFNIDPK<DCCDIHPMMLE> HCLNPCAIBJA)
		{
			return default(ODCLAJCJOLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class OHDPPEEDMPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static Dictionary<BIAFJNPKHBL<BEJLPFMDLLD>, DNJAKIICHFF> ECHIOPGNAKM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MIOPHGKICKL;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> IPKEOFFDHDH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> NFBBBFCEFHG;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> BFBLHFGCCDJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> EEDBOLNHHLG;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GDKONFJGBAF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> KFPOOJKEEKM;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> BPOJEAHFPNH;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MDNIMCAPIGA;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> DGDBANHDJHB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> EMBFDKBMEOO;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GCMCMNPFOMN;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> HLMNNLBMNKH;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GMFGNICOLME;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> OKCOKMBKPDL;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> JOGLOOGJMEI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> LNFFLDBBOHP;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> IAGLABMKMHG;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> EJJHAAFOEMN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MIILPCHDICH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> PDJAMFMOBMC;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> CAPEAILGMLM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> KBJCDFEHPNI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> PNEPKPEPMHD;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> DLNKOHGJHLC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> BCGHPENBAFO;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> FCLHGJECJNM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> HDHNAIDFMNG;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> LHNNCLGBGAE;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MFBJOANBOPP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> IILHKHJPOHB;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> PNBAANPHGFH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MPAMILNEHLB;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GLDPNHOPOON;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> NFMCKGAGIGH;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> NGAAOBIAOHI;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GDGOCEGGBDL;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> JOGIINCDKBH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MEDBOPPNFNM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GDDGMFPJAFH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> OOMGFOLPIKM;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GLGBMODEPEH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> LFHJGCKKIOE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> HPMCNDJMPEH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> LMLOGGNCBFD;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> OPGEIPGGFBG;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> FANAPHPMHBB;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> AHBKNKALLGG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GLIMIBNJPCB;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> MLBPFKABCNC;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> GFNGNMJFHKH;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly BIAFJNPKHBL<BEJLPFMDLLD> CCJJEIIBPIP;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFD70", Offset = "0x1CFE570", VA = "0x181CFFD70")]
		public static DNJAKIICHFF DDDJIMHLDPA(BIAFJNPKHBL<BEJLPFMDLLD> MBMFHFDDILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFCE0", Offset = "0x1CFE4E0", VA = "0x181CFFCE0")]
		public static bool AKLEGGKPMAF(BIAFJNPKHBL<BEJLPFMDLLD> MBMFHFDDILC, [Out] DNJAKIICHFF BNEPPPNNIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFE80", Offset = "0x1CFE680", VA = "0x181CFFE80")]
		public static CEOOMGIHGEO GPIHEGGHMDF(BIAFJNPKHBL<BEJLPFMDLLD> MBMFHFDDILC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFDF0", Offset = "0x1CFE5F0", VA = "0x181CFFDF0")]
		private static BIAFJNPKHBL<BEJLPFMDLLD> FPBPDBBEPKK(DNJAKIICHFF BNEPPPNNIBM, BIAFJNPKHBL<BEJLPFMDLLD> MBMFHFDDILC)
		{
			return default(BIAFJNPKHBL<BEJLPFMDLLD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IDKIKHMFNBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MNMFLABKNPN : IEnumerable<CEOOMGIHGEO>, IEnumerable, IEnumerator<CEOOMGIHGEO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private CEOOMGIHGEO <>2__current;

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
			private CEOOMGIHGEO System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
			[DebuggerHidden]
			public MNMFLABKNPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1CFD650", Offset = "0x1CFBE50", VA = "0x181CFD650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1CFEB70", Offset = "0x1CFD370", VA = "0x181CFEB70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1CFEAC0", Offset = "0x1CFD2C0", VA = "0x181CFEAC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CEOOMGIHGEO> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1CFEAC0", Offset = "0x1CFD2C0", VA = "0x181CFEAC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MFCDAEFLHEO : IEnumerable<CEOOMGIHGEO>, IEnumerable, IEnumerator<CEOOMGIHGEO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private CEOOMGIHGEO <>2__current;

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
			private IEnumerator<CEOOMGIHGEO> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private CEOOMGIHGEO <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			private CEOOMGIHGEO System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
			[DebuggerHidden]
			public MFCDAEFLHEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1CFD5C0", Offset = "0x1CFBDC0", VA = "0x181CFD5C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1CFCFD0", Offset = "0x1CFB7D0", VA = "0x181CFCFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1CFCF80", Offset = "0x1CFB780", VA = "0x181CFCF80")]
			private void JLELDKFKKHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1CFD570", Offset = "0x1CFBD70", VA = "0x181CFD570", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1CFD4C0", Offset = "0x1CFBCC0", VA = "0x181CFD4C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CEOOMGIHGEO> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1CFD4C0", Offset = "0x1CFBCC0", VA = "0x181CFD4C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly OPNNOPPDGDE PAFHBLACCCL;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly OPNNOPPDGDE PLBMHLFDGFA;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly HashSet<CEOOMGIHGEO> CMALHBGMOON;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static List<CEOOMGIHGEO> IEDOBLGJGDD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static ANENFDKLEDA AKDKHGPCADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8703F0", Offset = "0x86EBF0", VA = "0x1808703F0")]
			get
			{
				return default(ANENFDKLEDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static CEOOMGIHGEO GHJFAFJHAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1E00", Offset = "0x1CF0600", VA = "0x181CF1E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static CEOOMGIHGEO JOMIECNDGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0930", Offset = "0x1CEF130", VA = "0x181CF0930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static CEOOMGIHGEO MMHJPOBCBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2230", Offset = "0x1CF0A30", VA = "0x181CF2230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static CEOOMGIHGEO ANJBPLBFFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1930", Offset = "0x1CF0130", VA = "0x181CF1930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static CEOOMGIHGEO CLLJFAMDPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1A70", Offset = "0x1CF0270", VA = "0x181CF1A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static CEOOMGIHGEO DDGBBFPLLMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1780", Offset = "0x1CEFF80", VA = "0x181CF1780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static CEOOMGIHGEO EBCOBNKHNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0730", Offset = "0x1CEEF30", VA = "0x181CF0730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static CEOOMGIHGEO NGNEDPPPLCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2710", Offset = "0x1CF0F10", VA = "0x181CF2710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static AGFKPKEBHHD CKJKEHKBNBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1C40", Offset = "0x1CF0440", VA = "0x181CF1C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static AGFKPKEBHHD NALLDGBPGOB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1C90", Offset = "0x1CF0490", VA = "0x181CF1C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static AGFKPKEBHHD KKCDONOGMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1500", Offset = "0x1CEFD00", VA = "0x181CF1500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static AGFKPKEBHHD JEAENKMDNNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0030", Offset = "0x1CEE830", VA = "0x181CF0030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static AGFKPKEBHHD JJFDEGMAKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2430", Offset = "0x1CF0C30", VA = "0x181CF2430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static AGFKPKEBHHD HPHOJHFFIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0280", Offset = "0x1CEEA80", VA = "0x181CF0280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static AGFKPKEBHHD FMKAOCOLHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0880", Offset = "0x1CEF080", VA = "0x181CF0880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static AGFKPKEBHHD CEAGLEFIBLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2130", Offset = "0x1CF0930", VA = "0x181CF2130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static AGFKPKEBHHD AJEAMCKACIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1CF02D0", Offset = "0x1CEEAD0", VA = "0x181CF02D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static AGFKPKEBHHD ICOFHFKJOAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0B40", Offset = "0x1CEF340", VA = "0x181CF0B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static AGFKPKEBHHD JOGOCMBFHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1CF24E0", Offset = "0x1CF0CE0", VA = "0x181CF24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static AGFKPKEBHHD CNFCDMOJPFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1CF15B0", Offset = "0x1CEFDB0", VA = "0x181CF15B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static AGFKPKEBHHD FEBMHMFALEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1B90", Offset = "0x1CF0390", VA = "0x181CF1B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static AGFKPKEBHHD OBNDLCMJNBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2020", Offset = "0x1CF0820", VA = "0x181CF2020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static AGFKPKEBHHD NOMEMAODONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1A20", Offset = "0x1CF0220", VA = "0x181CF1A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static AGFKPKEBHHD HNFKGJNBNFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2320", Offset = "0x1CF0B20", VA = "0x181CF2320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static AGFKPKEBHHD NKEGBEBPDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0A20", Offset = "0x1CEF220", VA = "0x181CF0A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static AGFKPKEBHHD DBCDLBHCEBF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0E30", Offset = "0x1CEF630", VA = "0x181CF0E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static AGFKPKEBHHD HKELBCELJCB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1010", Offset = "0x1CEF810", VA = "0x181CF1010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static AGFKPKEBHHD BEFCIIHKGII
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF16C0", Offset = "0x1CEFEC0", VA = "0x181CF16C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static AGFKPKEBHHD PAFOJLCNJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1CF05B0", Offset = "0x1CEEDB0", VA = "0x181CF05B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static AGFKPKEBHHD CEFMHPOIKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1130", Offset = "0x1CEF930", VA = "0x181CF1130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static AGFKPKEBHHD GACNPGLJOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2800", Offset = "0x1CF1000", VA = "0x181CF2800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static AGFKPKEBHHD PHPJCLGHGLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0F50", Offset = "0x1CEF750", VA = "0x181CF0F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static AGFKPKEBHHD ICBAFDAFLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0A80", Offset = "0x1CEF280", VA = "0x181CF0A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static AGFKPKEBHHD DFNMDBOFHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2070", Offset = "0x1CF0870", VA = "0x181CF2070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static AGFKPKEBHHD LHBJOJOJCIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2370", Offset = "0x1CF0B70", VA = "0x181CF2370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static AGFKPKEBHHD HDBBAFMBMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2650", Offset = "0x1CF0E50", VA = "0x181CF2650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static AGFKPKEBHHD OMNJKKHKKHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1CEFFD0", Offset = "0x1CEE7D0", VA = "0x181CEFFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static AGFKPKEBHHD NMJDDGGOGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1CF25F0", Offset = "0x1CF0DF0", VA = "0x181CF25F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static AGFKPKEBHHD AJGBKHDDJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1550", Offset = "0x1CEFD50", VA = "0x181CF1550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static AGFKPKEBHHD MDOJKFJBNEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF27A0", Offset = "0x1CF0FA0", VA = "0x181CF27A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static AGFKPKEBHHD DBBLBHBBEFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF08D0", Offset = "0x1CEF0D0", VA = "0x181CF08D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static AGFKPKEBHHD GKNKFELCBKK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1BE0", Offset = "0x1CF03E0", VA = "0x181CF1BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static AGFKPKEBHHD LBLNDNODMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0D10", Offset = "0x1CEF510", VA = "0x181CF0D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static AGFKPKEBHHD BCMNGEACGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1600", Offset = "0x1CEFE00", VA = "0x181CF1600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static AGFKPKEBHHD ECALFJMCDML
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1CF19C0", Offset = "0x1CF01C0", VA = "0x181CF19C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static AGFKPKEBHHD DFHHMOCOLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1720", Offset = "0x1CEFF20", VA = "0x181CF1720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static AGFKPKEBHHD JHBDOFHIEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0CB0", Offset = "0x1CEF4B0", VA = "0x181CF0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static AGFKPKEBHHD HMJEMJHOHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0B90", Offset = "0x1CEF390", VA = "0x181CF0B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static AGFKPKEBHHD IJJLAOFBCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1CF09C0", Offset = "0x1CEF1C0", VA = "0x181CF09C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static AGFKPKEBHHD DBIFHBPGEEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1810", Offset = "0x1CF0010", VA = "0x181CF1810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static AGFKPKEBHHD EGLACEODKCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1CE0", Offset = "0x1CF04E0", VA = "0x181CF1CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static AGFKPKEBHHD DCCPDDHNJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2480", Offset = "0x1CF0C80", VA = "0x181CF2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static AGFKPKEBHHD BBCEEAEHJAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2590", Offset = "0x1CF0D90", VA = "0x181CF2590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static AGFKPKEBHHD LOLLNAKKJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0820", Offset = "0x1CEF020", VA = "0x181CF0820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static AGFKPKEBHHD GFKKONGHNCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0D70", Offset = "0x1CEF570", VA = "0x181CF0D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static AGFKPKEBHHD OMICKCBLCIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF18D0", Offset = "0x1CF00D0", VA = "0x181CF18D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static AGFKPKEBHHD PMNOAEFHMJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0DD0", Offset = "0x1CEF5D0", VA = "0x181CF0DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static AGFKPKEBHHD KKHDOHGLNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1CF03E0", Offset = "0x1CEEBE0", VA = "0x181CF03E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static AGFKPKEBHHD GAAPHMDHNBM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF07C0", Offset = "0x1CEEFC0", VA = "0x181CF07C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static AGFKPKEBHHD DMNBGFPJFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1190", Offset = "0x1CEF990", VA = "0x181CF1190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static AGFKPKEBHHD MBEAJKBACPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0E90", Offset = "0x1CEF690", VA = "0x181CF0E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static AGFKPKEBHHD GCICMFMDKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1CEFF70", Offset = "0x1CEE770", VA = "0x181CEFF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static AGFKPKEBHHD NMFPGLDLFAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1D40", Offset = "0x1CF0540", VA = "0x181CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static AGFKPKEBHHD CNGKJKECNNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0AE0", Offset = "0x1CEF2E0", VA = "0x181CF0AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static AGFKPKEBHHD POLHDLEEAHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1CF22C0", Offset = "0x1CF0AC0", VA = "0x181CF22C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static AGFKPKEBHHD BKDEMPNGFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1CF01C0", Offset = "0x1CEE9C0", VA = "0x181CF01C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static AGFKPKEBHHD FFJJHAANIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0FB0", Offset = "0x1CEF7B0", VA = "0x181CF0FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static AGFKPKEBHHD NOEHHHNPKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0220", Offset = "0x1CEEA20", VA = "0x181CF0220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static AGFKPKEBHHD JEAGMINHOHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0EF0", Offset = "0x1CEF6F0", VA = "0x181CF0EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static AGFKPKEBHHD PCIJBKDFOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1B00", Offset = "0x1CF0300", VA = "0x181CF1B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static AGFKPKEBHHD OLCPNLCEMHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0BF0", Offset = "0x1CEF3F0", VA = "0x181CF0BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static AGFKPKEBHHD ABMLAHAOAPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF26B0", Offset = "0x1CF0EB0", VA = "0x181CF26B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static AGFKPKEBHHD KGOJKGNHFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1660", Offset = "0x1CEFE60", VA = "0x181CF1660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static AGFKPKEBHHD GOJNELEDLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0380", Offset = "0x1CEEB80", VA = "0x181CF0380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static AGFKPKEBHHD MAHKFAGHEEA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0080", Offset = "0x1CEE880", VA = "0x181CF0080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static AGFKPKEBHHD KGNCPDKMGEC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1DA0", Offset = "0x1CF05A0", VA = "0x181CF1DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static AGFKPKEBHHD ADKICAJJBOO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1070", Offset = "0x1CEF870", VA = "0x181CF1070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static AGFKPKEBHHD ENEMNOACNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1FC0", Offset = "0x1CF07C0", VA = "0x181CF1FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static AGFKPKEBHHD OHNGEJDLNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1CF10D0", Offset = "0x1CEF8D0", VA = "0x181CF10D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static AGFKPKEBHHD HELEDMAGFJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1CF2530", Offset = "0x1CF0D30", VA = "0x181CF2530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static AGFKPKEBHHD JKKBEBCCAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1CF11F0", Offset = "0x1CEF9F0", VA = "0x181CF11F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static AGFKPKEBHHD ICBGIEMBCFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1CF20D0", Offset = "0x1CF08D0", VA = "0x181CF20D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static AGFKPKEBHHD KCOGLMLLAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0C50", Offset = "0x1CEF450", VA = "0x181CF0C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static AGFKPKEBHHD FHOGCNCKOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1CF23D0", Offset = "0x1CF0BD0", VA = "0x181CF23D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static AGFKPKEBHHD AMPFEIAOMLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1CF14A0", Offset = "0x1CEFCA0", VA = "0x181CF14A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static AGFKPKEBHHD FLLHNANEPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1870", Offset = "0x1CF0070", VA = "0x181CF1870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static AGFKPKEBHHD JLFEPDOHFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1CF1250", Offset = "0x1CEFA50", VA = "0x181CF1250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static AGFKPKEBHHD IELKBDNNFKN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1CF0320", Offset = "0x1CEEB20", VA = "0x181CF0320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0610", Offset = "0x1CEEE10", VA = "0x181CF0610")]
		public static OPNNOPPDGDE DDLHANNOFNM([In] NHBMDNLGKCF IOMJPIFHDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF00E0", Offset = "0x1CEE8E0", VA = "0x181CF00E0")]
		public static ILGCHEBGHOJ BLJOFJKCCKK(string MBMFHFDDILC, [Optional] string PMDCAPIFBIP)
		{
			return default(ILGCHEBGHOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0190", Offset = "0x1CEE990", VA = "0x181CF0190")]
		public static ILGCHEBGHOJ BLJOFJKCCKK([Optional][In] Guid? MBMFHFDDILC, [Optional] string PMDCAPIFBIP)
		{
			return default(ILGCHEBGHOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF1B60", Offset = "0x1CF0360", VA = "0x181CF1B60")]
		public static OPNNOPPDGDE LHFKIALINCB(params NHBMDNLGKCF[] KDMJPDFGHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0700", Offset = "0x1CEEF00", VA = "0x181CF0700")]
		public static OPNNOPPDGDE DHPBOONJPOE(params NHBMDNLGKCF[] KDMJPDFGHPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1CF1E90", Offset = "0x1CF0690", VA = "0x181CF1E90")]
		public static OPNNOPPDGDE MJLMDCNBMMB([In] NHBMDNLGKCF IOMJPIFHDKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2900", Offset = "0x1CF1100", VA = "0x181CF2900")]
		static IDKIKHMFNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2860", Offset = "0x1CF1060", VA = "0x181CF2860")]
		[IteratorStateMachine(typeof(MNMFLABKNPN))]
		private static IEnumerable<CEOOMGIHGEO> PPNEJLFFBJI(bool BLNIMBPPMME, bool HEDOKPBPAPA, bool MFHJDCBEKON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2180", Offset = "0x1CF0980", VA = "0x181CF2180")]
		[IteratorStateMachine(typeof(MFCDAEFLHEO))]
		public static IEnumerable<CEOOMGIHGEO> NDKDJBJEICA(bool EHICIMBNDKL, bool BLNIMBPPMME, bool HEDOKPBPAPA, bool MFHJDCBEKON)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0440", Offset = "0x1CEEC40", VA = "0x181CF0440")]
		public static IPMNDADMDBP DAJNLPAFBOB(CEOOMGIHGEO HJNJPNKDEFH)
		{
			return default(IPMNDADMDBP);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF1330", Offset = "0x1CEFB30", VA = "0x181CF1330")]
		public static IPMNDADMDBP IPCIKNFEPJF(CEOOMGIHGEO HJNJPNKDEFH)
		{
			return default(IPMNDADMDBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1CF12B0", Offset = "0x1CEFAB0", VA = "0x181CF12B0")]
		public static bool IJPAJFNBKJI(CEOOMGIHGEO HJNJPNKDEFH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ODCLAJCJOLG JIGPGHGODMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IKPOHANJNGO MJOMJCLGJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly CNCHLHIFBAG KDHIPNECKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GDEFMAIOBKG<FIOKAOEJDHN, LDKAMBCKFPK<DCCDIHPMMLE>> JGAGAGLAEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GDEFMAIOBKG<CGJGKMDFDEE, NBMLGICBOPL<DCCDIHPMMLE>> OOAGNNGECKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GDEFMAIOBKG<GOOGICFALMF, HOEBBPDIEOD> OJJAOPJLIAG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3710", Offset = "0x1CE1F10", VA = "0x181CE3710")]
	private BNJIHBFCHHB([In] ODCLAJCJOLG CBFMGDGJLIC, [In] IKPOHANJNGO OAPKEJLMGAP, [In] CNCHLHIFBAG POCKOKDILBO, GDEFMAIOBKG<FIOKAOEJDHN, LDKAMBCKFPK<DCCDIHPMMLE>> ONMKGMKNFNM, GDEFMAIOBKG<CGJGKMDFDEE, NBMLGICBOPL<DCCDIHPMMLE>> OEEAGLMHCMI, GDEFMAIOBKG<GOOGICFALMF, HOEBBPDIEOD> PBJFGFJNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2D70", Offset = "0x1CE1570", VA = "0x181CE2D70")]
	public static BNJIHBFCHHB AKKFLOCCMNP(HGHHDNAGGEJ JFHMOFHDJOF)
	{
		return default(BNJIHBFCHHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE32C0", Offset = "0x1CE1AC0", VA = "0x181CE32C0")]
	public static void PIODDHMICMM([In] BNJIHBFCHHB PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3110", Offset = "0x1CE1910", VA = "0x181CE3110", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3030", Offset = "0x1CE1830", VA = "0x181CE3030")]
	public static MOAPGHAEGDC<DCCDIHPMMLE> DIBOIHFABDF([In] BNJIHBFCHHB PIEBBHMNEOG, [In] FOKEMEGHNDE JPOOJGACNAB, [In] MBHIGLPPCJJ DCAPDMNKIKA)
	{
		return default(MOAPGHAEGDC<DCCDIHPMMLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3120", Offset = "0x1CE1920", VA = "0x181CE3120")]
	public static DCCDIHPMMLE KDCFEOLGAOD([In] BNJIHBFCHHB PIEBBHMNEOG, [In] MBNEGLLKLEJ KGOPCGFABFC, [In] MOAPGHAEGDC<DCCDIHPMMLE> BJHLIJNMCPA, [In] OLLEOCEHEKP DODMGKNNGLE, BIAFJNPKHBL<HDHGCCECDFN> ELPKJAMMFAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DCCDIHPMMLE : FKACBJFEPLB, NKAEMCAKPEN<DCCDIHPMMLE>, NOHEMCNFFPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly BNJIHBFCHHB EHFGEACDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private MBNEGLLKLEJ CNNAEJMMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private MOAPGHAEGDC<DCCDIHPMMLE> BCGNNHCOALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private OLLEOCEHEKP KLNGHLJMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> BEPNHPLBNFN;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6990", Offset = "0x1CE5190", VA = "0x181CE6990")]
	private DCCDIHPMMLE([In] BNJIHBFCHHB AHBAPCFMEFC, [In] MBNEGLLKLEJ KKFIODJJLDP, [In] MOAPGHAEGDC<DCCDIHPMMLE> BJHLIJNMCPA, [In] OLLEOCEHEKP DODMGKNNGLE, BIAFJNPKHBL<HDHGCCECDFN> AGGNOLMBFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3120", Offset = "0x1CE1920", VA = "0x181CE3120")]
	public static DCCDIHPMMLE GPIMNGGFKOC([In] BNJIHBFCHHB AHBAPCFMEFC, [In] MBNEGLLKLEJ KKFIODJJLDP, [In] MOAPGHAEGDC<DCCDIHPMMLE> BJHLIJNMCPA, [In] OLLEOCEHEKP DODMGKNNGLE, BIAFJNPKHBL<HDHGCCECDFN> AGGNOLMBFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1CE46B0", Offset = "0x1CE2EB0", VA = "0x181CE46B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4550", Offset = "0x1CE2D50", VA = "0x181CE4550", Slot = "8")]
	public MOAPGHAEGDC<DCCDIHPMMLE> CIODCKCBOOL()
	{
		return default(MOAPGHAEGDC<DCCDIHPMMLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4730", Offset = "0x1CE2F30", VA = "0x181CE4730")]
	public MBNEGLLKLEJ MKNBDHADNEL()
	{
		return default(MBNEGLLKLEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2355B80", Offset = "0x2354380", VA = "0x182355B80")]
	public BIAFJNPKHBL<TMVirt> LMHHOBAFGJB<TMVirt>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN) where TMVirt : JIPHABGKENI.IHPABEEFAJJ
	{
		return default(BIAFJNPKHBL<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2355A70", Offset = "0x2354270", VA = "0x182355A70")]
	public BIAFJNPKHBL<TMVirt> JGMDNEKKDHB<TMVirt>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH) where TMVirt : CLOOHKMBCMK.NFMIDNOFBHH
	{
		return default(BIAFJNPKHBL<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4670", Offset = "0x1CE2E70", VA = "0x181CE4670")]
	internal FOKEMEGHNDE DIJHNOKFDCN()
	{
		return default(FOKEMEGHNDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4630", Offset = "0x1CE2E30", VA = "0x181CE4630")]
	internal MBHIGLPPCJJ DHNKBLADFKC()
	{
		return default(MBHIGLPPCJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4550", Offset = "0x1CE2D50", VA = "0x181CE4550")]
	internal MOAPGHAEGDC<DCCDIHPMMLE> NKMICDAKNGD()
	{
		return default(MOAPGHAEGDC<DCCDIHPMMLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4730", Offset = "0x1CE2F30", VA = "0x181CE4730")]
	internal MBNEGLLKLEJ EONOGFCIDAG()
	{
		return default(MBNEGLLKLEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5B30", Offset = "0x1CE4330", VA = "0x181CE5B30")]
	internal OLLEOCEHEKP KPCBADOLBAA()
	{
		return default(OLLEOCEHEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2355B20", Offset = "0x2354320", VA = "0x182355B20")]
	public void LJAKBNDMNIA<TMVirt>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<TMVirt> EOKBHKADKLJ) where TMVirt : JIPHABGKENI.IHPABEEFAJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2355840", Offset = "0x2354040", VA = "0x182355840")]
	public void CDMNEKOGCJA<TMVirt>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<TMVirt> EOKBHKADKLJ) where TMVirt : CLOOHKMBCMK.NFMIDNOFBHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE45F0", Offset = "0x1CE2DF0", VA = "0x181CE45F0", Slot = "9")]
	public BBBLJJCEMFO DHNEEIFGANI()
	{
		return default(BBBLJJCEMFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4740", Offset = "0x1CE2F40", VA = "0x181CE4740", Slot = "10")]
	public IPMNDADMDBP FIJPFKHOOGL(CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(IPMNDADMDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5220", Offset = "0x1CE3A20", VA = "0x181CE5220", Slot = "11")]
	public bool GKDGAHIKCOL(CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5170", Offset = "0x1CE3970", VA = "0x181CE5170", Slot = "4")]
	private void FKJHGDFNNGC(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE44C0", Offset = "0x1CE2CC0", VA = "0x181CE44C0", Slot = "5")]
	private void CDJEFHNFPJD(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5AA0", Offset = "0x1CE42A0", VA = "0x181CE5AA0", Slot = "6")]
	private void KGCJCOIAGAK(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6920", Offset = "0x1CE5120", VA = "0x181CE6920", Slot = "7")]
	private void NMAEOMAFFDP(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE67A0", Offset = "0x1CE4FA0", VA = "0x181CE67A0")]
	internal LBFOJMHFNLD<BIAFJNPKHBL<ILGLJDCFBLD>, IJJELFILJOP> NBHPHNHPOAP(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<FIOKAOEJDHN> BAPHFMDELAI, [In] IMAJOCIMDLK ENHKIKKDBOC, [In] NPNJGJGODAK AOABADNNGMN, BDBPKDECIFP EBGBEDHDDLG, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? NBEFEKABAFO)
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<ILGLJDCFBLD>, IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE66C0", Offset = "0x1CE4EC0", VA = "0x181CE66C0")]
	internal BIAFJNPKHBL<ILGLJDCFBLD> MJJNDONAHDD(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<FIOKAOEJDHN> BAPHFMDELAI, [In] IMAJOCIMDLK ENHKIKKDBOC, [In] NPNJGJGODAK AOABADNNGMN, BDBPKDECIFP EBGBEDHDDLG, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? NBEFEKABAFO)
	{
		return default(BIAFJNPKHBL<ILGLJDCFBLD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4560", Offset = "0x1CE2D60", VA = "0x181CE4560")]
	internal LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> CJHKMMGFCHL(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23558E0", Offset = "0x23540E0", VA = "0x1823558E0")]
	public LBFOJMHFNLD<BIAFJNPKHBL<TM>, IJJELFILJOP> JFIMKBNEOFB<TM>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<CGJGKMDFDEE> IDIHOCKKJFK) where TM : JIPHABGKENI.IHPABEEFAJJ
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<TM>, IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2355BF0", Offset = "0x23543F0", VA = "0x182355BF0")]
	public LBFOJMHFNLD<BIAFJNPKHBL<TM>, IJJELFILJOP> MEEPEBPMEDF<TM>(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<FIOKAOEJDHN> INMKFAEJHKM) where TM : CLOOHKMBCMK.NFMIDNOFBHH
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<TM>, IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6350", Offset = "0x1CE4B50", VA = "0x181CE6350")]
	private LBFOJMHFNLD<(BIAFJNPKHBL<IMOECONPDEP.OMLHFPKBINK>, BIAFJNPKHBL<HCMCNEEDMNH.BNJNAPFKPDA>), IJJELFILJOP> MECMAIOHJBJ(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
		return default(LBFOJMHFNLD<(BIAFJNPKHBL<IMOECONPDEP.OMLHFPKBINK>, BIAFJNPKHBL<HCMCNEEDMNH.BNJNAPFKPDA>), IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1CE5B40", Offset = "0x1CE4340", VA = "0x181CE5B40")]
	internal LBFOJMHFNLD<(BIAFJNPKHBL<NDCIINJLAPJ>, BIAFJNPKHBL<LNMMLKANDNP>), IJJELFILJOP> MAFJLFPPIDL(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int GJPDNAFHJNG, [In] KIIEKELKLNA HJNJPNKDEFH)
	{
		return default(LBFOJMHFNLD<(BIAFJNPKHBL<NDCIINJLAPJ>, BIAFJNPKHBL<LNMMLKANDNP>), IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE52D0", Offset = "0x1CE3AD0", VA = "0x181CE52D0")]
	internal LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> JMJGBCHNBEJ(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int GJPDNAFHJNG)
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1CE4900", Offset = "0x1CE3100", VA = "0x181CE4900")]
	internal LBFOJMHFNLD<(BIAFJNPKHBL<LNMMLKANDNP>, BIAFJNPKHBL<NDCIINJLAPJ>), IJJELFILJOP> FKJCMGGBBBG(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int PAEHCPCCHPC, [In] KIIEKELKLNA HJNJPNKDEFH)
	{
		return default(LBFOJMHFNLD<(BIAFJNPKHBL<LNMMLKANDNP>, BIAFJNPKHBL<NDCIINJLAPJ>), IJJELFILJOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3CC0", Offset = "0x1CE24C0", VA = "0x181CE3CC0")]
	internal LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> BMBMDBBKEAL(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int PAEHCPCCHPC)
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OLLEOCEHEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public DHDAPGCBMBJ<HCMCNEEDMNH.BNJNAPFKPDA, LKELFPBIEGJ<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD, HDHGCCECDFN>> EGPGEKKECMC;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2D20", Offset = "0x1CB1520", VA = "0x181CB2D20")]
	private OLLEOCEHEKP([In] DHDAPGCBMBJ<HCMCNEEDMNH.BNJNAPFKPDA, LKELFPBIEGJ<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD, HDHGCCECDFN>> FGPLFCALDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D017E0", Offset = "0x1CFFFE0", VA = "0x181D017E0")]
	public static OLLEOCEHEKP AKKFLOCCMNP()
	{
		return default(OLLEOCEHEKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AKCIIHMFLMI
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2380", Offset = "0x1CE0B80", VA = "0x181CE2380")]
	public static void PIODDHMICMM(this OLLEOCEHEKP PIEBBHMNEOG, [In] KKHCNNBPMJB<HCMCNEEDMNH.BNJNAPFKPDA> BIEJJDEEPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NIAFAHLODOP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF5C0", Offset = "0x1CFDDC0", VA = "0x181CFF5C0")]
	public static IDIOCAECPKH JMOOMJHDBEG(DCCDIHPMMLE BJHLIJNMCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1CFEE80", Offset = "0x1CFD680", VA = "0x181CFEE80")]
	public static IDIOCAECPKH AMNJGHMJHFA(BIAFJNPKHBL<CGJGKMDFDEE> DINGDIPHDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DILOJHHHMIO
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE76A0", Offset = "0x1CE5EA0", VA = "0x181CE76A0")]
	public static HEPNBNBJHMB JMOOMJHDBEG(this CEOOMGIHGEO HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE6AE0", Offset = "0x1CE52E0", VA = "0x181CE6AE0")]
	public static CEOOMGIHGEO AEDPLFCAHJC(this HEPNBNBJHMB HJNJPNKDEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KOONMIHACKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x255B840", Offset = "0x255A040", VA = "0x18255B840")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> LBMFDEIFDJM<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> KAGAAHEAJHB, Func<TSerialized, TDeserializedKey> CKJLIJNEHKK, Func<TSerialized, TDeserializedValue> LMAAJDLBLAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KJBLMEKMIMN
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB8D0", Offset = "0x1CFA0D0", VA = "0x181CFB8D0")]
	public static NGNCHBNHAPM JMOOMJHDBEG([In] this JIPHABGKENI PIEBBHMNEOG, [In] BPDEBBGALOB<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD> OLMAEEEFKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB190", Offset = "0x1CF9990", VA = "0x181CFB190")]
	public static JIPHABGKENI AEDPLFCAHJC(this NGNCHBNHAPM PIEBBHMNEOG, [In] BPDEBBGALOB<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD> OLMAEEEFKOE)
	{
		return default(JIPHABGKENI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PPFFBAMEEDD
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D03150", Offset = "0x1D01950", VA = "0x181D03150")]
	public static IEHIBMBBOCB JMOOMJHDBEG([In] this MBHIGLPPCJJ PIEBBHMNEOG, [In] FOKEMEGHNDE MOEGLFJNJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D02E90", Offset = "0x1D01690", VA = "0x181D02E90")]
	public static MBHIGLPPCJJ AEDPLFCAHJC(this IEHIBMBBOCB PIEBBHMNEOG, [In] FOKEMEGHNDE MOEGLFJNJHO)
	{
		return default(MBHIGLPPCJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AKCIOEIDNMB
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE25A0", Offset = "0x1CE0DA0", VA = "0x181CE25A0")]
	public static CGJHMLNNGHF JMOOMJHDBEG([In] this HMAHLEEEMKC PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE24F0", Offset = "0x1CE0CF0", VA = "0x181CE24F0")]
	public static HMAHLEEEMKC AEDPLFCAHJC(this CGJHMLNNGHF PIEBBHMNEOG)
	{
		return default(HMAHLEEEMKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class JMKJEBGIIOC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB040", Offset = "0x1CF9840", VA = "0x181CFB040")]
	public static CEGADHPMPFN JMOOMJHDBEG([In] this CLOOHKMBCMK PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAFC0", Offset = "0x1CF97C0", VA = "0x181CFAFC0")]
	public static CLOOHKMBCMK AEDPLFCAHJC(this CEGADHPMPFN PIEBBHMNEOG)
	{
		return default(CLOOHKMBCMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DNGMPPPIGMD
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1CE89F0", Offset = "0x1CE71F0", VA = "0x181CE89F0")]
	public static DBFELBBIJIO JMOOMJHDBEG([In] this HEADFJJCGCA PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8970", Offset = "0x1CE7170", VA = "0x181CE8970")]
	public static HEADFJJCGCA AEDPLFCAHJC(this DBFELBBIJIO PIEBBHMNEOG)
	{
		return default(HEADFJJCGCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BNCFJKJKKJL
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x22CC370", Offset = "0x22CAB70", VA = "0x1822CC370")]
	public static GOAOPCLJPJC JMOOMJHDBEG<TRoot>([In] this MOAPGHAEGDC<TRoot> PIEBBHMNEOG) where TRoot : NKAEMCAKPEN<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2A30", Offset = "0x1CE1230", VA = "0x181CE2A30")]
	public static MOAPGHAEGDC<DCCDIHPMMLE> AEDPLFCAHJC(this GOAOPCLJPJC PIEBBHMNEOG, [In] BNJIHBFCHHB AHBAPCFMEFC)
	{
		return default(MOAPGHAEGDC<DCCDIHPMMLE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LPCBGCLBFIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCC20", Offset = "0x1CFB420", VA = "0x181CFCC20")]
	public static BJHDCIADIFF JMOOMJHDBEG([In] this HCMCNEEDMNH.ODMHCKMBGMJ PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC920", Offset = "0x1CFB120", VA = "0x181CFC920")]
	public static HCMCNEEDMNH.ODMHCKMBGMJ AEDPLFCAHJC(this BJHDCIADIFF PIEBBHMNEOG)
	{
		return default(HCMCNEEDMNH.ODMHCKMBGMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FHDMLBABPBB
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA9A0", Offset = "0x1CE91A0", VA = "0x181CEA9A0")]
	public static EIGKPKPCAEF JMOOMJHDBEG([In] this IMOECONPDEP.GCFBALKJCLA PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA950", Offset = "0x1CE9150", VA = "0x181CEA950")]
	public static IMOECONPDEP.GCFBALKJCLA AEDPLFCAHJC(this EIGKPKPCAEF PIEBBHMNEOG)
	{
		return default(IMOECONPDEP.GCFBALKJCLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JGLAKAJBGEK
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFADC0", Offset = "0x1CF95C0", VA = "0x181CFADC0")]
	public static DGGHJGOGGNE JMOOMJHDBEG([In] this FOKEMEGHNDE PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAB60", Offset = "0x1CF9360", VA = "0x181CFAB60")]
	public static FOKEMEGHNDE AEDPLFCAHJC(this DGGHJGOGGNE PIEBBHMNEOG)
	{
		return default(FOKEMEGHNDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class PIJLNLEHJPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1D02D10", Offset = "0x1D01510", VA = "0x181D02D10")]
	public static FGFEPDPNOGA JMOOMJHDBEG([In] Guid PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D02C70", Offset = "0x1D01470", VA = "0x181D02C70")]
	public static Guid AEDPLFCAHJC(FGFEPDPNOGA PIEBBHMNEOG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NHNEMIMIGBK
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1CFEE00", Offset = "0x1CFD600", VA = "0x181CFEE00")]
	public static LKKCEMGMBMF JMOOMJHDBEG([In] this LICAOGKPICI PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1CFED60", Offset = "0x1CFD560", VA = "0x181CFED60")]
	public static LICAOGKPICI AEDPLFCAHJC(this LKKCEMGMBMF PIEBBHMNEOG)
	{
		return default(LICAOGKPICI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EAANODEGKNI
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8AC0", Offset = "0x1CE72C0", VA = "0x181CE8AC0")]
	public static JKPODDFMOAE JMOOMJHDBEG([In] this KIIEKELKLNA PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8A60", Offset = "0x1CE7260", VA = "0x181CE8A60")]
	public static KIIEKELKLNA AEDPLFCAHJC(this JKPODDFMOAE PIEBBHMNEOG)
	{
		return default(KIIEKELKLNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FBFNHGBKIHE
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9670", Offset = "0x1CE7E70", VA = "0x181CE9670")]
	public static EPEKGAEBNBO JMOOMJHDBEG([In] this JNIIBDOADCC PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE95D0", Offset = "0x1CE7DD0", VA = "0x181CE95D0")]
	public static JNIIBDOADCC AEDPLFCAHJC(this EPEKGAEBNBO PIEBBHMNEOG)
	{
		return default(JNIIBDOADCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KMGCCCELOBE
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x255A660", Offset = "0x2558E60", VA = "0x18255A660")]
	public static void GNKCJNEHEOL<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> PIEBBHMNEOG, RepeatedField<TSerialized> KAGAAHEAJHB, HDFMNNEOBEA<TDeserialized, TSerialized> GFDFAAHPKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FCBAIKKMPJD
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9A20", Offset = "0x1CE8220", VA = "0x181CE9A20")]
	public static OEMHGHJIIHP JMOOMJHDBEG([In] this MLOFIFPDPIA PIEBBHMNEOG, [In] BPDEBBGALOB<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD> OLMAEEEFKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CE96F0", Offset = "0x1CE7EF0", VA = "0x181CE96F0")]
	public static MLOFIFPDPIA AEDPLFCAHJC(this OEMHGHJIIHP PIEBBHMNEOG, [In] BPDEBBGALOB<NDCIINJLAPJ, LNMMLKANDNP, ILGLJDCFBLD> OLMAEEEFKOE)
	{
		return default(MLOFIFPDPIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FEKMIGOLLII
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA1A0", Offset = "0x1CE89A0", VA = "0x181CEA1A0")]
	public static GNOHEBMNDNB JMOOMJHDBEG([In] this MBNEGLLKLEJ PIEBBHMNEOG, [In] FOKEMEGHNDE MOEGLFJNJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9D30", Offset = "0x1CE8530", VA = "0x181CE9D30")]
	public static MBNEGLLKLEJ AEDPLFCAHJC(this GNOHEBMNDNB PIEBBHMNEOG, [In] FOKEMEGHNDE MOEGLFJNJHO)
	{
		return default(MBNEGLLKLEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HBLOOOABOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB9C0", Offset = "0x1CEA1C0", VA = "0x181CEB9C0")]
	public static ODGMEICCBNN JMOOMJHDBEG([In] this JJIKJBDEGED PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB910", Offset = "0x1CEA110", VA = "0x181CEB910")]
	public static JJIKJBDEGED AEDPLFCAHJC(this ODGMEICCBNN PIEBBHMNEOG)
	{
		return default(JJIKJBDEGED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KOJLNBHNCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC7C0", Offset = "0x1CFAFC0", VA = "0x181CFC7C0")]
	public static JNJMKFBMFNN JMOOMJHDBEG(this DCCDIHPMMLE PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC2A0", Offset = "0x1CFAAA0", VA = "0x181CFC2A0")]
	public static DCCDIHPMMLE AEDPLFCAHJC(this JNJMKFBMFNN PIEBBHMNEOG, [In] BNJIHBFCHHB AHBAPCFMEFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PGJMGIGBFEH
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1D02AB0", Offset = "0x1D012B0", VA = "0x181D02AB0")]
	public static OBJKDJPHPHC JMOOMJHDBEG([In] this IPMNDADMDBP PIEBBHMNEOG, CEOOMGIHGEO HJNJPNKDEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1D02960", Offset = "0x1D01160", VA = "0x181D02960")]
	public static IPMNDADMDBP AEDPLFCAHJC(this OBJKDJPHPHC PIEBBHMNEOG)
	{
		return default(IPMNDADMDBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct KLPAOBCNLOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly BIAFJNPKHBL<LNMMLKANDNP> ELIFGOEGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly BIAFJNPKHBL<NDCIINJLAPJ> JKONPEELLKD;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1838C40", Offset = "0x1837440", VA = "0x181838C40")]
	private KLPAOBCNLOI(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<LNMMLKANDNP> BCNGFOHBCGB, BIAFJNPKHBL<NDCIINJLAPJ> CNHJILOMFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC060", Offset = "0x1CFA860", VA = "0x181CFC060")]
	public static NJKBAHIFHIM<PPOILEHMDEK, KLPAOBCNLOI> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, KLPAOBCNLOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x255A400", Offset = "0x2558C00", VA = "0x18255A400")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] KLPAOBCNLOI PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct MFAGPAMHDOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN>? KBMNGOIJBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly BIAFJNPKHBL<CGJGKMDFDEE> LPFMMMMJOKH;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCF70", Offset = "0x1CFB770", VA = "0x181CFCF70")]
	private MFAGPAMHDOC(BIAFJNPKHBL<HDHGCCECDFN>? MKHMOJLHHGF, BIAFJNPKHBL<CGJGKMDFDEE> IDIHOCKKJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCE90", Offset = "0x1CFB690", VA = "0x181CFCE90")]
	public static NJKBAHIFHIM<PPOILEHMDEK, MFAGPAMHDOC> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, MFAGPAMHDOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2590CE0", Offset = "0x258F4E0", VA = "0x182590CE0")]
	public static LBFOJMHFNLD<BIAFJNPKHBL<HDHGCCECDFN>, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] MFAGPAMHDOC PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<HDHGCCECDFN>, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct KDPHPPMJIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public readonly BIAFJNPKHBL<CKOMANNAHHK> HPOMLIMGIKP;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1838C40", Offset = "0x1837440", VA = "0x181838C40")]
	private KDPHPPMJIFA(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<CKOMANNAHHK> DABJFHNEMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB0C0", Offset = "0x1CF98C0", VA = "0x181CFB0C0")]
	public static NJKBAHIFHIM<PPOILEHMDEK, KDPHPPMJIFA> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, KDPHPPMJIFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x25550D0", Offset = "0x25538D0", VA = "0x1825550D0")]
	public static LBFOJMHFNLD<BIAFJNPKHBL<NDCIINJLAPJ>, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] KDPHPPMJIFA PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<NDCIINJLAPJ>, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct DJBFPOBBCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public readonly BIAFJNPKHBL<FIOKAOEJDHN> NCEFBMJCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public readonly IMAJOCIMDLK HAONNNBKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public readonly NPNJGJGODAK MGBCJOLDJFF;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8940", Offset = "0x1CE7140", VA = "0x181CE8940")]
	private DJBFPOBBCPG(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<FIOKAOEJDHN> BDHFGBIAMGF, [In] IMAJOCIMDLK HNMECAIDFDA, [In] NPNJGJGODAK FMOJBJGJDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1CE87D0", Offset = "0x1CE6FD0", VA = "0x181CE87D0")]
	public static NJKBAHIFHIM<PPOILEHMDEK, DJBFPOBBCPG> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, DJBFPOBBCPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2357EA0", Offset = "0x23566A0", VA = "0x182357EA0")]
	public static LBFOJMHFNLD<BIAFJNPKHBL<ILGLJDCFBLD>, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] DJBFPOBBCPG PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<ILGLJDCFBLD>, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct CAOJKDLLCMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly int AJLNMJOIJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly KIIEKELKLNA CCNHBOAJCJO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3BA0", Offset = "0x1CE23A0", VA = "0x181CE3BA0")]
	private CAOJKDLLCMH(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int PAEHCPCCHPC, KIIEKELKLNA HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3A30", Offset = "0x1CE2230", VA = "0x181CE3A30")]
	public static NJKBAHIFHIM<PPOILEHMDEK, CAOJKDLLCMH> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, CAOJKDLLCMH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2326B00", Offset = "0x2325300", VA = "0x182326B00")]
	public static LBFOJMHFNLD<(BIAFJNPKHBL<NDCIINJLAPJ>, BIAFJNPKHBL<LNMMLKANDNP>), IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] CAOJKDLLCMH PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<(BIAFJNPKHBL<NDCIINJLAPJ>, BIAFJNPKHBL<LNMMLKANDNP>), IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct KNFGIPBOKED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly int GDLNJJFPPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly KIIEKELKLNA CCNHBOAJCJO;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3BA0", Offset = "0x1CE23A0", VA = "0x181CE3BA0")]
	private KNFGIPBOKED(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int PAEHCPCCHPC, KIIEKELKLNA HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC130", Offset = "0x1CFA930", VA = "0x181CFC130")]
	public static NJKBAHIFHIM<PPOILEHMDEK, KNFGIPBOKED> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, KNFGIPBOKED>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x255ADC0", Offset = "0x25595C0", VA = "0x18255ADC0")]
	public static LBFOJMHFNLD<(BIAFJNPKHBL<LNMMLKANDNP>, BIAFJNPKHBL<NDCIINJLAPJ>), IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] KNFGIPBOKED PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<(BIAFJNPKHBL<LNMMLKANDNP>, BIAFJNPKHBL<NDCIINJLAPJ>), IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct IMNIPEIJKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly int AJLNMJOIJFI;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1838C40", Offset = "0x1837440", VA = "0x181838C40")]
	private IMNIPEIJKJF(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int GJPDNAFHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF98E0", Offset = "0x1CF80E0", VA = "0x181CF98E0")]
	public static NJKBAHIFHIM<PPOILEHMDEK, IMNIPEIJKJF> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, IMNIPEIJKJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2521C30", Offset = "0x2520430", VA = "0x182521C30")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] IMNIPEIJKJF PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct PDACMBJDLGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly int GDLNJJFPPEF;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1838C40", Offset = "0x1837440", VA = "0x181838C40")]
	private PDACMBJDLGN(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, int GJPDNAFHJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1D028A0", Offset = "0x1D010A0", VA = "0x181D028A0")]
	public static NJKBAHIFHIM<PPOILEHMDEK, PDACMBJDLGN> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, PDACMBJDLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2653670", Offset = "0x2651E70", VA = "0x182653670")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] PDACMBJDLGN PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct IDMNCHJLKPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly BIAFJNPKHBL<NDCIINJLAPJ> LICGCIHBKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly IPMNDADMDBP PIFGLCGFEEC;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8DE0", Offset = "0x1CF75E0", VA = "0x181CF8DE0")]
	private IDMNCHJLKPM(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<NDCIINJLAPJ> LPCJAHLDKAI, [In] IPMNDADMDBP OGJIDOCEOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8CD0", Offset = "0x1CF74D0", VA = "0x181CF8CD0")]
	public static NJKBAHIFHIM<PPOILEHMDEK, IDMNCHJLKPM> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, IDMNCHJLKPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2501730", Offset = "0x24FFF30", VA = "0x182501730")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] IDMNCHJLKPM PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct IJBBFBOFDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly BIAFJNPKHBL<LNMMLKANDNP> ELIFGOEGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly BIAFJNPKHBL<NDCIINJLAPJ> JKONPEELLKD;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1838C40", Offset = "0x1837440", VA = "0x181838C40")]
	private IJBBFBOFDIJ(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<LNMMLKANDNP> BCNGFOHBCGB, BIAFJNPKHBL<NDCIINJLAPJ> CNHJILOMFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9740", Offset = "0x1CF7F40", VA = "0x181CF9740")]
	public static NJKBAHIFHIM<PPOILEHMDEK, IJBBFBOFDIJ> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, IJBBFBOFDIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x25058A0", Offset = "0x25040A0", VA = "0x1825058A0")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] IJBBFBOFDIJ PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct PJCGHAEOHPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
	private PJCGHAEOHPF(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1D02E10", Offset = "0x1D01610", VA = "0x181D02E10")]
	public static NJKBAHIFHIM<PPOILEHMDEK, PJCGHAEOHPF> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, PJCGHAEOHPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2656780", Offset = "0x2654F80", VA = "0x182656780")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] PJCGHAEOHPF PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct HGJKCLEPPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly BIAFJNPKHBL<HDHGCCECDFN> LAOKAKDMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly BIAFJNPKHBL<ILGLJDCFBLD> JGKGMPNPHJP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xA106A0", Offset = "0xA0EEA0", VA = "0x180A106A0")]
	private HGJKCLEPPCM(BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1CEBA50", Offset = "0x1CEA250", VA = "0x181CEBA50")]
	public static NJKBAHIFHIM<PPOILEHMDEK, HGJKCLEPPCM> LIDAOAJDCAO(JNDFKAPOEAK OFAILEIBBMN)
	{
		return default(NJKBAHIFHIM<PPOILEHMDEK, HGJKCLEPPCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x24ECE10", Offset = "0x24EB610", VA = "0x1824ECE10")]
	public static LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP> NACPJKEFMEB<TRoot>(TRoot PHEKGOFMNOB, [In] HGJKCLEPPCM PIEBBHMNEOG) where TRoot : AKNNCAJBOEB
	{
		return default(LBFOJMHFNLD<EGJHPKNOBOC, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class IEMMGMBJKIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Guid HIADNILMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly bool CJMENANDPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly bool DNHFKMFMOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly bool MFFNOONOKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly bool ICMDILDBHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly bool HHINLAFHGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly List<(string Name, CEOOMGIHGEO Type)> ENHHPKJKGFI;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Guid ALAIFGAODFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9370", Offset = "0x1CF7B70", VA = "0x181CF9370")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public IReadOnlyList<(string Name, CEOOMGIHGEO Type)> LFGLADKCKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action CLCHAJAMJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8E60", Offset = "0x1CF7660", VA = "0x181CF8E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8F00", Offset = "0x1CF7700", VA = "0x181CF8F00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, CEOOMGIHGEO> NMMDBPMGLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1CF90F0", Offset = "0x1CF78F0", VA = "0x181CF90F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8FA0", Offset = "0x1CF77A0", VA = "0x181CF8FA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> MHEMLBBHIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9600", Offset = "0x1CF7E00", VA = "0x181CF9600")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1CF91A0", Offset = "0x1CF79A0", VA = "0x181CF91A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ELGDLGFEFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9050", Offset = "0x1CF7850", VA = "0x181CF9050")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9560", Offset = "0x1CF7D60", VA = "0x181CF9560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x19D5850", Offset = "0x19D4050", VA = "0x1819D5850")]
	public void LBFOMHHOEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1CF96B0", Offset = "0x1CF7EB0", VA = "0x181CF96B0")]
	internal IEMMGMBJKIM([In] Guid MBMFHFDDILC, string PMDCAPIFBIP, bool DPAKDGBOHMH, bool FFIDMLCNKEB, bool LDJAOCNJHFO, bool BPHCFGDNKEH, bool BEONHBEAGNP, List<(string Name, CEOOMGIHGEO Type)> DDACLDFNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9460", Offset = "0x1CF7C60", VA = "0x181CF9460")]
	public static EIGCJKMEKIE MKOLGNEGDKP(string MBMFHFDDILC, string PMDCAPIFBIP, bool DPAKDGBOHMH = false, bool FFIDMLCNKEB = false, bool LDJAOCNJHFO = false, bool BPHCFGDNKEH = true, bool BEONHBEAGNP = true)
	{
		return default(EIGCJKMEKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9380", Offset = "0x1CF7B80", VA = "0x181CF9380")]
	public static IEMMGMBJKIM LJIJPKFAOJA([In] Guid MBMFHFDDILC, string PMDCAPIFBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8E00", Offset = "0x1CF7600", VA = "0x181CF8E00")]
	public void BANAOPNNAOC(string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9250", Offset = "0x1CF7A50", VA = "0x181CF9250")]
	public void JCOFJIIKJKJ(string PMDCAPIFBIP, CEOOMGIHGEO OALDIBGHIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1CF94F0", Offset = "0x1CF7CF0", VA = "0x181CF94F0")]
	public void NKKOLBFGBOJ(int EAHCFBMNNCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct EIGCJKMEKIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Guid HIADNILMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string HACDJEIIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool LAJONOGBJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool KDMMMJDCHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly bool JGKKJFFLFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool HDEABKFLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly bool BFOHHDDNBJF;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1CE91B0", Offset = "0x1CE79B0", VA = "0x181CE91B0")]
	public EIGCJKMEKIE([In] Guid MBMFHFDDILC, string PMDCAPIFBIP, bool DPAKDGBOHMH, bool FFIDMLCNKEB, bool LDJAOCNJHFO, bool BPHCFGDNKEH, bool BEONHBEAGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8F10", Offset = "0x1CE7710", VA = "0x181CE8F10")]
	public ONABLBLCACP BJGCNFGOOGI(string PMDCAPIFBIP, CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(ONABLBLCACP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9090", Offset = "0x1CE7890", VA = "0x181CE9090")]
	public IEMMGMBJKIM CGLCBLDLOFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct ONABLBLCACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Guid HIADNILMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly string HACDJEIIPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly bool LAJONOGBJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly bool KDMMMJDCHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly bool JGKKJFFLFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly bool HDEABKFLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly bool BFOHHDDNBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly List<(string Name, CEOOMGIHGEO Type)> ENHHPKJKGFI;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1D01A60", Offset = "0x1D00260", VA = "0x181D01A60")]
	public ONABLBLCACP([In] Guid MBMFHFDDILC, string PMDCAPIFBIP, bool DPAKDGBOHMH, bool FFIDMLCNKEB, bool LDJAOCNJHFO, bool BPHCFGDNKEH, bool BEONHBEAGNP, List<(string Name, CEOOMGIHGEO Type)> DDACLDFNFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1D01840", Offset = "0x1D00040", VA = "0x181D01840")]
	public ONABLBLCACP BJGCNFGOOGI(string PMDCAPIFBIP, CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(ONABLBLCACP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1D01970", Offset = "0x1D00170", VA = "0x181D01970")]
	public IEMMGMBJKIM CGLCBLDLOFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BLKFCGBDHCL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class FFNEDKHGPNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IEMMGMBJKIM KHEFFLFFMGI;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly IEMMGMBJKIM MCFDGDBIHJN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class FINFDHNGPHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly IEMMGMBJKIM NFENCBCLBOH;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class NIEICPHMFPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly IEMMGMBJKIM GCEPOKIGMLG;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IEMMGMBJKIM DKGHNJOPACE;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class EAFFIBBFPIL
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly IEMMGMBJKIM ENAKADKBFIF;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly IEMMGMBJKIM JIMCFEGMBMI;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class JBLPNFIJNKL
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly IEMMGMBJKIM NJMKPOOAPBK;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IEMMGMBJKIM BGJKIJMGFHN;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class BHBIAPAFMEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly IEMMGMBJKIM GCEPOKIGMLG;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly IEMMGMBJKIM DKGHNJOPACE;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class OKOIPKDLOBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly IEMMGMBJKIM KNCOGCAPECA;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IEMMGMBJKIM FGKPBCHKPGK;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly IEMMGMBJKIM JEAPMOAKEKD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly IEMMGMBJKIM CBKAGKLDOMC;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly IEMMGMBJKIM IKDNKGGEEIF;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly IEMMGMBJKIM FNAAKPNMDDM;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly IEMMGMBJKIM PDJCDNKOKON;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class GPPEDBOEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class IDEPIOOKOII
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class LBIGBHJGKEM
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class EPBFDFGHNAP
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly IEMMGMBJKIM MGGDKPBFLMH;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly IEMMGMBJKIM NDLPHABLIIL;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class GHHOONGKHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class GAIJNDNDJDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class NENENGPLDAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly IEMMGMBJKIM MOJLBGBEHAL;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class HKLECOFHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly IEMMGMBJKIM MNBFMDOLMJI;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly IEMMGMBJKIM NCCECAIHHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly IEMMGMBJKIM NJMKPOOAPBK;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly IEMMGMBJKIM NEDGIEAEGBB;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly IEMMGMBJKIM EIGDDPKNGFN;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly IEMMGMBJKIM BMGDFKACJCI;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly IEMMGMBJKIM ANLADKFJIAK;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly IEMMGMBJKIM BIEKONNNKIK;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly IEMMGMBJKIM KGJDHCNJNAA;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly IEMMGMBJKIM AHDMGIKKFJN;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly IEMMGMBJKIM DOOKEFMBGOF;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly IEMMGMBJKIM EJENIEPEADK;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly IEMMGMBJKIM DLJEMPFJAHN;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly IEMMGMBJKIM HAMKKOHBENL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly IEMMGMBJKIM ONKMPAHHOFE;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly IEMMGMBJKIM HOGKKEFMPCL;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly IEMMGMBJKIM NOIOIGCHEBI;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly IEMMGMBJKIM FEBDIBKHHAH;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly IEMMGMBJKIM HNGDOOENDJO;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly IEMMGMBJKIM KMKOLANEDPP;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly IEMMGMBJKIM BBADMIBNNKN;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly IEMMGMBJKIM IMJEOBJEBKC;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly IEMMGMBJKIM HIFDFGBOHLE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly IEMMGMBJKIM BDMPJFFJALK;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly IEMMGMBJKIM GCFCAGAHKBN;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly IEMMGMBJKIM IDIJOHNDMLK;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly IEMMGMBJKIM CFNEIJMHHII;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly IEMMGMBJKIM LJODMCFHNLN;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly IEMMGMBJKIM OJAENDIIJIL;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly IEMMGMBJKIM LIECFLJMNIN;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class GJIKGCLLDHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class JFGJDDJLHFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly IEMMGMBJKIM MNBFMDOLMJI;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly IEMMGMBJKIM LAMNCKADJIP;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class FHGOPENBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly IEMMGMBJKIM CHGBNIJOAHH;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly IEMMGMBJKIM GKEOLJOPDCM;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly IEMMGMBJKIM POFELEOLDDF;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly IEMMGMBJKIM KMFNKBJMBHL;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly IEMMGMBJKIM EHGNLKMBJIJ;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly IEMMGMBJKIM JNKOPBEDDAH;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class GAKLEPGLCMG
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class HJBJCMNIAFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly IEMMGMBJKIM KKPIKMFOIBM;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class AENEIDAHDJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly IEMMGMBJKIM MOJLBGBEHAL;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class OBMJGPHAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class KJHOFBABJIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class HPLKENLPFEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly IEMMGMBJKIM CNDMIDLBIOD;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly IEMMGMBJKIM HABAAPMLEBF;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly IEMMGMBJKIM GPEIHNNEPJE;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly IEMMGMBJKIM OOHAGJGIBIE;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class JBKKFDJDHMO
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly IEMMGMBJKIM PGEFFBGNNCJ;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly IEMMGMBJKIM NNNMEJPEMKC;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class PPHICNIGLCB
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class PAJOMELPBEL
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly IEMMGMBJKIM FEDGFNFGFFP;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly IEMMGMBJKIM IJLDGICCMLJ;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly IEMMGMBJKIM MDJGGIGBLNO;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly IEMMGMBJKIM DGMPAJLKBFH;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly IEMMGMBJKIM EPJGHPELJLK;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly IEMMGMBJKIM AGIDEEHGBHK;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly IEMMGMBJKIM NDMIHMFNPLL;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly IEMMGMBJKIM EAIPHGMBHHH;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly IEMMGMBJKIM BEJEAGNEKGP;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly IEMMGMBJKIM DNHKBEGLDOD;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly IEMMGMBJKIM PJKADPLLBEE;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly IEMMGMBJKIM DABJCHJIOBI;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class AICHIIBJJLN
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class EGALJNEJOEF
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly IEMMGMBJKIM PJKADPLLBEE;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly IEMMGMBJKIM DABJCHJIOBI;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly IEMMGMBJKIM CILPMCDOBOO;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly IEMMGMBJKIM LKODGCNIJGG;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly IEMMGMBJKIM CKFKBPOHOBD;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class BJFAIECCHLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class JFKLKNAODAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly IEMMGMBJKIM NJKGONABJPP;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class LKBCEIPFDEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly IEMMGMBJKIM JDNMILALCIJ;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly IEMMGMBJKIM GBAOBCPNGOK;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly IEMMGMBJKIM PJKADPLLBEE;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly IEMMGMBJKIM DABJCHJIOBI;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class EPMKOAGMNEC
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class JOINBPJFFHM
	{
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class JCNIHIBKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class AHJGBECIHOP
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class OKOJMBANEHO
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly IEMMGMBJKIM MGGDKPBFLMH;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly IEMMGMBJKIM NDLPHABLIIL;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class MAPCAFEFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly IEMMGMBJKIM DPKAOGMIAFL;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly IEMMGMBJKIM NPLAMPIJKLL;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly IEMMGMBJKIM CGEPCNLDPLN;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public static readonly IEMMGMBJKIM FHOOKFJABAB;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class OPBGMLLOBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly IEMMGMBJKIM DPKAOGMIAFL;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly IEMMGMBJKIM NPLAMPIJKLL;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly IEMMGMBJKIM CGEPCNLDPLN;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly IEMMGMBJKIM FHOOKFJABAB;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class JMFJKOGBBML
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class NLHIHHNMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public static readonly IEMMGMBJKIM HJFCPLOFEMH;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly IEMMGMBJKIM DBDDELKCPAG;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly IEMMGMBJKIM FADEDFAPCIA;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class GOMKCAHELFH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly IEMMGMBJKIM IGELPBMNNNO;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public static readonly IEMMGMBJKIM PDBAFJFNPBH;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly IEMMGMBJKIM PKOILFELBGL;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class PIOMGDOBAIG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class BOLNJGICEPG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly IEMMGMBJKIM IKAEBBKIIHG;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly IEMMGMBJKIM HENPAICJKIE;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly IEMMGMBJKIM BEMMDDCACKJ;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class GGBOKEGPFIL
	{
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly IEMMGMBJKIM DLIODENEGOO;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class PNBOKOCAPNB
	{
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly IEMMGMBJKIM FCAKGEFMJPD;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public static readonly IEMMGMBJKIM BEEDPNLFINC;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static readonly IEMMGMBJKIM FKPBHEDFLKH;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class DJHGFAPIJKL
	{
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class BJKMNIKJFLA
	{
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class DOMGFIBPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly IEMMGMBJKIM PJNBINBCALB;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly IEMMGMBJKIM OHINLIELLLE;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly IEMMGMBJKIM GDENECJKCLD;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		internal static readonly IEMMGMBJKIM[] OFDFOBCHLIB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class DNJAKIICHFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public readonly CEOOMGIHGEO OLOFPKFOFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly List<IEMMGMBJKIM> MLAIHEKEGKB;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public IReadOnlyList<IEMMGMBJKIM> DFLBOOLHFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1D07580", Offset = "0x1D05D80", VA = "0x181D07580")]
	protected DNJAKIICHFF(CEOOMGIHGEO CONMFOFKDIN, params IEMMGMBJKIM[][] PHPFDGNPHMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GGPNFMLPIAO : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1D08BF0", Offset = "0x1D073F0", VA = "0x181D08BF0")]
	internal GGPNFMLPIAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HMGPJINOFPL : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A180", Offset = "0x1D08980", VA = "0x181D0A180")]
	internal HMGPJINOFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class CHMBKPOOPJI : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1D068B0", Offset = "0x1D050B0", VA = "0x181D068B0")]
	internal CHMBKPOOPJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class IIMMDPHDNDI : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A540", Offset = "0x1D08D40", VA = "0x181D0A540")]
	internal IIMMDPHDNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MJINLDFHBIL : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DC90", Offset = "0x1D0C490", VA = "0x181D0DC90")]
	internal MJINLDFHBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class PJIDJLFHLGM : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1D10F70", Offset = "0x1D0F770", VA = "0x181D10F70")]
	internal PJIDJLFHLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CDCLFJMIPHK : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1D06310", Offset = "0x1D04B10", VA = "0x181D06310")]
	internal CDCLFJMIPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class GPKJNEMCDIA : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1D09460", Offset = "0x1D07C60", VA = "0x181D09460")]
	internal GPKJNEMCDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PDOEGMFGNFI : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1D109C0", Offset = "0x1D0F1C0", VA = "0x181D109C0")]
	internal PDOEGMFGNFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class JCFACIPABAO : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B2C0", Offset = "0x1D09AC0", VA = "0x181D0B2C0")]
	internal JCFACIPABAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class CMOBMGFECGE : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A90", Offset = "0x1D05290", VA = "0x181D06A90")]
	internal CMOBMGFECGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GLDOCEONMLJ : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1D08DD0", Offset = "0x1D075D0", VA = "0x181D08DD0")]
	internal GLDOCEONMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class AHGEJABPMBB : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1D04660", Offset = "0x1D02E60", VA = "0x181D04660")]
	internal AHGEJABPMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class DPEFILNDCDI : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1D07A80", Offset = "0x1D06280", VA = "0x181D07A80")]
	internal DPEFILNDCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class HIGDGAPENNL : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1D09DC0", Offset = "0x1D085C0", VA = "0x181D09DC0")]
	internal HIGDGAPENNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OGCHEGOFACH : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F360", Offset = "0x1D0DB60", VA = "0x181D0F360")]
	internal OGCHEGOFACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class PPBCBGJNNJC : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1D11770", Offset = "0x1D0FF70", VA = "0x181D11770")]
	internal PPBCBGJNNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JHGABEBCCOK : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B9A0", Offset = "0x1D0A1A0", VA = "0x181D0B9A0")]
	internal JHGABEBCCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JEMIJCKGKJC : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B510", Offset = "0x1D09D10", VA = "0x181D0B510")]
	internal JEMIJCKGKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class NGOGLOPJBHE : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E480", Offset = "0x1D0CC80", VA = "0x181D0E480")]
	internal NGOGLOPJBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class DCKBAJEJALO : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1D07150", Offset = "0x1D05950", VA = "0x181D07150")]
	internal DCKBAJEJALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class BCJFPOGGKEF : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1D04C90", Offset = "0x1D03490", VA = "0x181D04C90")]
	internal BCJFPOGGKEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class PMEDHIEBHOK : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1D11150", Offset = "0x1D0F950", VA = "0x181D11150")]
	internal PMEDHIEBHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class HHNNONHIPJH : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1D09BE0", Offset = "0x1D083E0", VA = "0x181D09BE0")]
	internal HHNNONHIPJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class GGNBKLDKGHG : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1D08A10", Offset = "0x1D07210", VA = "0x181D08A10")]
	internal GGNBKLDKGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class BDAOPJEFLCP : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1D04E70", Offset = "0x1D03670", VA = "0x181D04E70")]
	internal BDAOPJEFLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class CDOJGLDCMIA : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1D064F0", Offset = "0x1D04CF0", VA = "0x181D064F0")]
	internal CDOJGLDCMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class CGMJKIOBJMF : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1D066D0", Offset = "0x1D04ED0", VA = "0x181D066D0")]
	internal CGMJKIOBJMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class ICHNMNPLNKA : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A360", Offset = "0x1D08B60", VA = "0x181D0A360")]
	internal ICHNMNPLNKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class AGCCFGBNOBF : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1D04480", Offset = "0x1D02C80", VA = "0x181D04480")]
	internal AGCCFGBNOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class CPNPFLJFBPD : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1D06F70", Offset = "0x1D05770", VA = "0x181D06F70")]
	internal CPNPFLJFBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class NJFHDFEMKGL : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E840", Offset = "0x1D0D040", VA = "0x181D0E840")]
	internal NJFHDFEMKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class BHLAFHMNMEE : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1D05490", Offset = "0x1D03C90", VA = "0x181D05490")]
	internal BHLAFHMNMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class INMHAHMGFEF : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B0E0", Offset = "0x1D098E0", VA = "0x181D0B0E0")]
	internal INMHAHMGFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class BMEHAJAOOIG : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1D05750", Offset = "0x1D03F50", VA = "0x181D05750")]
	internal BMEHAJAOOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class NOGHLCHBIEJ : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EFC0", Offset = "0x1D0D7C0", VA = "0x181D0EFC0")]
	internal NOGHLCHBIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class OGKCAGGONLH : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F5C0", Offset = "0x1D0DDC0", VA = "0x181D0F5C0")]
	internal OGKCAGGONLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class BEDLECECHAC : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D05050", Offset = "0x1D03850", VA = "0x181D05050")]
	internal BEDLECECHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class DDELALLGOPL : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D07330", Offset = "0x1D05B30", VA = "0x181D07330")]
	internal DDELALLGOPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class JLKHGKLFELH : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BBF0", Offset = "0x1D0A3F0", VA = "0x181D0BBF0")]
	internal JLKHGKLFELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class OHNNPIACCJA : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F7A0", Offset = "0x1D0DFA0", VA = "0x181D0F7A0")]
	internal OHNNPIACCJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class LMCMPFPNGOC : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0CB40", Offset = "0x1D0B340", VA = "0x181D0CB40")]
	internal LMCMPFPNGOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class MNBJJKAILLE : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DF60", Offset = "0x1D0C760", VA = "0x181D0DF60")]
	internal MNBJJKAILLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class CCPPIMAENKB : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1D06130", Offset = "0x1D04930", VA = "0x181D06130")]
	internal CCPPIMAENKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class LANJHDCLKMM : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C050", Offset = "0x1D0A850", VA = "0x181D0C050")]
	internal LANJHDCLKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class BGJFDBOBFIH : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D05270", Offset = "0x1D03A70", VA = "0x181D05270")]
	internal BGJFDBOBFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class NHOJAANBGON : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E660", Offset = "0x1D0CE60", VA = "0x181D0E660")]
	internal NHOJAANBGON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class HKHFHBEAMDN : DNJAKIICHFF
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1D09FA0", Offset = "0x1D087A0", VA = "0x181D09FA0")]
	internal HKHFHBEAMDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public sealed class OJHBBMCIFPG : PFNKDNKDIDF
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F980", Offset = "0x1D0E180", VA = "0x181D0F980")]
	public OJHBBMCIFPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public abstract class LKBNPHAGNBJ : JHJILGHICPL<DCCDIHPMMLE>
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D06F30", Offset = "0x1D05730", VA = "0x181D06F30")]
	protected LKBNPHAGNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public abstract class MBIJGEBIKOK : IMKABKMOALM<DCCDIHPMMLE>
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D060E0", Offset = "0x1D048E0", VA = "0x181D060E0")]
	protected MBIJGEBIKOK([In] CDFEGKIGIAG EBPJMBIIAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D430", Offset = "0x1D0BC30", VA = "0x181D0D430", Slot = "11")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D3A0", Offset = "0x1D0BBA0", VA = "0x181D0D3A0", Slot = "14")]
	public override void DAOAMHKGIJK(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class BONLOCKEDHH : MBIJGEBIKOK
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D060E0", Offset = "0x1D048E0", VA = "0x181D060E0")]
	public BONLOCKEDHH([In] CDFEGKIGIAG EBPJMBIIAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public sealed class LDABECKOEBA : LKBNPHAGNBJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "11")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "12")]
	public override void DODDMCOMDJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C4B0", Offset = "0x1D0ACB0", VA = "0x181D0C4B0", Slot = "13")]
	public override IEnumerable<EDMADECGABL<CEOOMGIHGEO>> DIJJNHCMOLB(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C230", Offset = "0x1D0AA30", VA = "0x181D0C230", Slot = "14")]
	public override void DAOAMHKGIJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C4E0", Offset = "0x1D0ACE0", VA = "0x181D0C4E0")]
	public static void LEMMEHMAKCF(DCCDIHPMMLE BJHLIJNMCPA, [In] HCMCNEEDMNH.ODMHCKMBGMJ MHDFNGGDGNI, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<LNMMLKANDNP> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D06EF0", Offset = "0x1D056F0", VA = "0x181D06EF0", Slot = "15")]
	public override IPMNDADMDBP LPFEHBDFBGC(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<CKOMANNAHHK> DABJFHNEMEC, CEOOMGIHGEO IKPGIOBDBKA)
	{
		return default(IPMNDADMDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D06F30", Offset = "0x1D05730", VA = "0x181D06F30")]
	public LDABECKOEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class IMOECONPDEP : LKBNPHAGNBJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class OMLHFPKBINK : CLOOHKMBCMK.NFMIDNOFBHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct GCFBALKJCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public readonly BIAFJNPKHBL<HDHGCCECDFN> ICLABKHGMML;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
		private GCFBALKJCLA(BIAFJNPKHBL<HDHGCCECDFN> GIEKLIHPACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
		public static GCFBALKJCLA AKKFLOCCMNP(BIAFJNPKHBL<HDHGCCECDFN> PNJFJCKKDMB)
		{
			return default(GCFBALKJCLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D0ABA0", Offset = "0x1D093A0", VA = "0x181D0ABA0", Slot = "11")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D0ADD0", Offset = "0x1D095D0", VA = "0x181D0ADD0", Slot = "12")]
	public override void DODDMCOMDJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AD40", Offset = "0x1D09540", VA = "0x181D0AD40", Slot = "13")]
	public override IEnumerable<EDMADECGABL<CEOOMGIHGEO>> DIJJNHCMOLB(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A720", Offset = "0x1D08F20", VA = "0x181D0A720", Slot = "14")]
	public override void DAOAMHKGIJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AF40", Offset = "0x1D09740", VA = "0x181D0AF40")]
	public static void FJLKIANJNGA(DCCDIHPMMLE BJHLIJNMCPA, [In] HCMCNEEDMNH.ODMHCKMBGMJ MHDFNGGDGNI, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<NDCIINJLAPJ> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B010", Offset = "0x1D09810", VA = "0x181D0B010")]
	public static void LEMMEHMAKCF(DCCDIHPMMLE BJHLIJNMCPA, [In] HCMCNEEDMNH.ODMHCKMBGMJ MHDFNGGDGNI, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<LNMMLKANDNP> GAABFGHHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D06EF0", Offset = "0x1D056F0", VA = "0x181D06EF0", Slot = "15")]
	public override IPMNDADMDBP LPFEHBDFBGC(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<CKOMANNAHHK> DABJFHNEMEC, CEOOMGIHGEO IKPGIOBDBKA)
	{
		return default(IPMNDADMDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D06F30", Offset = "0x1D05730", VA = "0x181D06F30")]
	public IMOECONPDEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class CNLPJAEEMDO : LKBNPHAGNBJ
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "11")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "12")]
	public override void DODDMCOMDJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D06DE0", Offset = "0x1D055E0", VA = "0x181D06DE0", Slot = "13")]
	public override IEnumerable<EDMADECGABL<CEOOMGIHGEO>> DIJJNHCMOLB(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D06B60", Offset = "0x1D05360", VA = "0x181D06B60", Slot = "14")]
	public override void DAOAMHKGIJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D06E10", Offset = "0x1D05610", VA = "0x181D06E10")]
	public static void FJLKIANJNGA(DCCDIHPMMLE BJHLIJNMCPA, [In] HCMCNEEDMNH.ODMHCKMBGMJ MHDFNGGDGNI, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<NDCIINJLAPJ> LPCJAHLDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D06EF0", Offset = "0x1D056F0", VA = "0x181D06EF0", Slot = "15")]
	public override IPMNDADMDBP LPFEHBDFBGC(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<CKOMANNAHHK> DABJFHNEMEC, CEOOMGIHGEO IKPGIOBDBKA)
	{
		return default(IPMNDADMDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D06F30", Offset = "0x1D05730", VA = "0x181D06F30")]
	public CNLPJAEEMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class EHJBJEJDOOB : MBIJGEBIKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public readonly BIAFJNPKHBL<CKOMANNAHHK> ECMKACJBFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public readonly BIAFJNPKHBL<NANJIIGGMCC> FCFKACEGIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public readonly BIAFJNPKHBL<NANJIIGGMCC> DDEFNCGGIDF;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D08440", Offset = "0x1D06C40", VA = "0x181D08440")]
	public EHJBJEJDOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class PFNKDNKDIDF : HOBADAFAKHF<DCCDIHPMMLE>
{
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D10EB0", Offset = "0x1D0F6B0", VA = "0x181D10EB0")]
	protected PFNKDNKDIDF([In] LGPKNPAPFAO EBPJMBIIAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D10C30", Offset = "0x1D0F430", VA = "0x181D10C30", Slot = "11")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? PNAJPPILBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D10CE0", Offset = "0x1D0F4E0", VA = "0x181D10CE0", Slot = "12")]
	public override void DODDMCOMDJK(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D10BA0", Offset = "0x1D0F3A0", VA = "0x181D10BA0", Slot = "14")]
	public override void DAOAMHKGIJK(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D10D80", Offset = "0x1D0F580", VA = "0x181D10D80", Slot = "17")]
	public override LBFOJMHFNLD<BIAFJNPKHBL<NDCIINJLAPJ>, IJJELFILJOP> ENKECALAKMP(DCCDIHPMMLE PHEKGOFMNOB, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BIAFJNPKHBL<ILGLJDCFBLD> IEJCDLJALPH, BIAFJNPKHBL<CKOMANNAHHK> DABJFHNEMEC)
	{
		return default(LBFOJMHFNLD<BIAFJNPKHBL<NDCIINJLAPJ>, IJJELFILJOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class MPBHJJDJOEA : BONLOCKEDHH
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E220", Offset = "0x1D0CA20", VA = "0x181D0E220")]
	public MPBHJJDJOEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct JJIKJBDEGED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public IMAJOCIMDLK HAONNNBKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NPNJGJGODAK MGBCJOLDJFF;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BBD0", Offset = "0x1D0A3D0", VA = "0x181D0BBD0")]
	internal JJIKJBDEGED([In] IMAJOCIMDLK ENHKIKKDBOC, [In] NPNJGJGODAK AOABADNNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BB80", Offset = "0x1D0A380", VA = "0x181D0BB80")]
	public static JJIKJBDEGED AKKFLOCCMNP()
	{
		return default(JJIKJBDEGED);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BBB0", Offset = "0x1D0A3B0", VA = "0x181D0BBB0")]
	public static JJIKJBDEGED GPIMNGGFKOC([In] IMAJOCIMDLK ENHKIKKDBOC, [In] NPNJGJGODAK AOABADNNGMN)
	{
		return default(JJIKJBDEGED);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class AKIEKPCPHGO : PFNKDNKDIDF
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D04920", Offset = "0x1D03120", VA = "0x181D04920")]
	public AKIEKPCPHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class BCPFEBAKMDD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class HCMCNEEDMNH : BHKFCIEOFPM
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class BNJNAPFKPDA : JIPHABGKENI.IHPABEEFAJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public struct ODMHCKMBGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public string JOBPEPKBADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public BIFGLJCHOMN<CKOMANNAHHK, KIIEKELKLNA> LLBJOEAOKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public BIFGLJCHOMN<NANJIIGGMCC, KIIEKELKLNA> MIMHCILGKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public readonly BIAFJNPKHBL<ILGLJDCFBLD> BPPDOMOHEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public readonly BIAFJNPKHBL<ILGLJDCFBLD> IMPJCMMDFLM;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F2F0", Offset = "0x1D0DAF0", VA = "0x181D0F2F0")]
		private ODMHCKMBGMJ(string PMDCAPIFBIP, [In] BIFGLJCHOMN<CKOMANNAHHK, KIIEKELKLNA> AENKLOGIEEL, [In] BIFGLJCHOMN<NANJIIGGMCC, KIIEKELKLNA> NNIENAGCMCA, BIAFJNPKHBL<ILGLJDCFBLD> KJHBBLOOHML, BIAFJNPKHBL<ILGLJDCFBLD> NEPMHKJFEIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F1A0", Offset = "0x1D0D9A0", VA = "0x181D0F1A0")]
		public static ODMHCKMBGMJ AKKFLOCCMNP(BIAFJNPKHBL<ILGLJDCFBLD> IDDOBKNBDGG, BIAFJNPKHBL<ILGLJDCFBLD> FGLPMGEAHDC)
		{
			return default(ODMHCKMBGMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F270", Offset = "0x1D0DA70", VA = "0x181D0F270")]
		public static ODMHCKMBGMJ GPIMNGGFKOC(string PMDCAPIFBIP, [In] BIFGLJCHOMN<CKOMANNAHHK, KIIEKELKLNA> AENKLOGIEEL, [In] BIFGLJCHOMN<NANJIIGGMCC, KIIEKELKLNA> NNIENAGCMCA, BIAFJNPKHBL<ILGLJDCFBLD> IDDOBKNBDGG, BIAFJNPKHBL<ILGLJDCFBLD> FGLPMGEAHDC)
		{
			return default(ODMHCKMBGMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D09640", Offset = "0x1D07E40", VA = "0x181D09640", Slot = "8")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? NBEFEKABAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D099E0", Offset = "0x1D081E0", VA = "0x181D099E0", Slot = "9")]
	public override void DODDMCOMDJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D05450", Offset = "0x1D03C50", VA = "0x181D05450")]
	public HCMCNEEDMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MNJAJHKNOPN
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E1C0", Offset = "0x1D0C9C0", VA = "0x181D0E1C0")]
	public static void PIODDHMICMM(this HCMCNEEDMNH.ODMHCKMBGMJ PIEBBHMNEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public abstract class BHKFCIEOFPM : LHGBBCAJMOP<DCCDIHPMMLE>
{
	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1D05450", Offset = "0x1D03C50", VA = "0x181D05450")]
	protected BHKFCIEOFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public readonly struct KIIEKELKLNA : IEquatable<KIIEKELKLNA>, AIENODJKFOP<KIIEKELKLNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public readonly string JOBPEPKBADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public readonly CEOOMGIHGEO CCNHBOAJCJO;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
	private KIIEKELKLNA(string PMDCAPIFBIP, CEOOMGIHGEO HJNJPNKDEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE0460", Offset = "0x1CDEC60", VA = "0x181CE0460")]
	public static KIIEKELKLNA AKKFLOCCMNP(string PMDCAPIFBIP, CEOOMGIHGEO HJNJPNKDEFH)
	{
		return default(KIIEKELKLNA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BF60", Offset = "0x1D0A760", VA = "0x181D0BF60")]
	public static bool FMFPLPMCDAE([In] KIIEKELKLNA NMCFAAKFHJI, [In] KIIEKELKLNA AKHEBCAILGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BF60", Offset = "0x1D0A760", VA = "0x181D0BF60", Slot = "4")]
	public bool Equals(KIIEKELKLNA FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BF60", Offset = "0x1D0A760", VA = "0x181D0BF60")]
	public bool PCNBHFDPOMC([In] KIIEKELKLNA FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BEB0", Offset = "0x1D0A6B0", VA = "0x181D0BEB0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BFB0", Offset = "0x1D0A7B0", VA = "0x181D0BFB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C010", Offset = "0x1D0A810", VA = "0x181D0C010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BF60", Offset = "0x1D0A760", VA = "0x181D0BF60", Slot = "5")]
	private bool LBLFANLKMAI([In] KIIEKELKLNA FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class CJMPNPMLFND : BHKFCIEOFPM
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "8")]
	public override void DGBBOFCNPHJ(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, BDBPKDECIFP ONPDKCJBDAB, BIAFJNPKHBL<JHAIACJHPMK.PNNNOIMJIMM>? NBEFEKABAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
	public override void DODDMCOMDJK(DCCDIHPMMLE BJHLIJNMCPA, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D05450", Offset = "0x1D03C50", VA = "0x181D05450")]
	public CJMPNPMLFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct MLOFIFPDPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public DHDAPGCBMBJ<ILGLJDCFBLD, JJIKJBDEGED> GLIPLODAFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public KKHCNNBPMJB<IMOECONPDEP.OMLHFPKBINK> MOJOBAGPBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public DHDAPGCBMBJ<IMOECONPDEP.OMLHFPKBINK, IMOECONPDEP.GCFBALKJCLA> FMOFBOKLJLG;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D550", Offset = "0x1D0BD50", VA = "0x181D0D550")]
	private MLOFIFPDPIA([In] DHDAPGCBMBJ<ILGLJDCFBLD, JJIKJBDEGED> COCKMPEBNJP, [In] KKHCNNBPMJB<IMOECONPDEP.OMLHFPKBINK> LHFENADEPFC, [In] DHDAPGCBMBJ<IMOECONPDEP.OMLHFPKBINK, IMOECONPDEP.GCFBALKJCLA> KAEMEEEHMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DE70", Offset = "0x1D0C670", VA = "0x181D0DE70")]
	public static MLOFIFPDPIA AKKFLOCCMNP()
	{
		return default(MLOFIFPDPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D4C0", Offset = "0x1D0BCC0", VA = "0x181D0D4C0")]
	public static MLOFIFPDPIA GPIMNGGFKOC([In] DHDAPGCBMBJ<ILGLJDCFBLD, JJIKJBDEGED> COCKMPEBNJP, [In] KKHCNNBPMJB<IMOECONPDEP.OMLHFPKBINK> LHFENADEPFC, [In] DHDAPGCBMBJ<IMOECONPDEP.OMLHFPKBINK, IMOECONPDEP.GCFBALKJCLA> KAEMEEEHMNG)
	{
		return default(MLOFIFPDPIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class MNEFBNOKMAG
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E140", Offset = "0x1D0C940", VA = "0x181D0E140")]
	public static void PIODDHMICMM(this MLOFIFPDPIA PIEBBHMNEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct MBNEGLLKLEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public DHDAPGCBMBJ<HDHGCCECDFN, MLOFIFPDPIA> NBLNBPDFFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public KKHCNNBPMJB<HCMCNEEDMNH.BNJNAPFKPDA> DNMGDGEPOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DHDAPGCBMBJ<HCMCNEEDMNH.BNJNAPFKPDA, HCMCNEEDMNH.ODMHCKMBGMJ> NIOCCDJGHPA;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D550", Offset = "0x1D0BD50", VA = "0x181D0D550")]
	private MBNEGLLKLEJ([In] DHDAPGCBMBJ<HDHGCCECDFN, MLOFIFPDPIA> BGOMBENDKBO, [In] KKHCNNBPMJB<HCMCNEEDMNH.BNJNAPFKPDA> BIEJJDEEPNG, [In] DHDAPGCBMBJ<HCMCNEEDMNH.BNJNAPFKPDA, HCMCNEEDMNH.ODMHCKMBGMJ> IGHOJIDBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D4C0", Offset = "0x1D0BCC0", VA = "0x181D0D4C0")]
	public static MBNEGLLKLEJ GPIMNGGFKOC([In] DHDAPGCBMBJ<HDHGCCECDFN, MLOFIFPDPIA> BGOMBENDKBO, [In] KKHCNNBPMJB<HCMCNEEDMNH.BNJNAPFKPDA> BIEJJDEEPNG, [In] DHDAPGCBMBJ<HCMCNEEDMNH.BNJNAPFKPDA, HCMCNEEDMNH.ODMHCKMBGMJ> IGHOJIDBLGN)
	{
		return default(MBNEGLLKLEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class MCFHBGBEIIF
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D8F0", Offset = "0x1D0C0F0", VA = "0x181D0D8F0")]
	public static void PIODDHMICMM(this MBNEGLLKLEJ PIEBBHMNEOG, [In] FOKEMEGHNDE JPOOJGACNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D680", Offset = "0x1D0BE80", VA = "0x181D0D680")]
	public static void CJBBHKJKFDA(this MBNEGLLKLEJ PIEBBHMNEOG, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, [In] MLOFIFPDPIA OLMAEEEFKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D6E0", Offset = "0x1D0BEE0", VA = "0x181D0D6E0")]
	public static void DABJCHJIOBI(this MBNEGLLKLEJ PIEBBHMNEOG, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN, [In] FOKEMEGHNDE JPOOJGACNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D5C0", Offset = "0x1D0BDC0", VA = "0x181D0D5C0")]
	public static MLOFIFPDPIA BGCBNLKDELI([In] this MBNEGLLKLEJ PIEBBHMNEOG, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
		return default(MLOFIFPDPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D0D620", Offset = "0x1D0BE20", VA = "0x181D0D620")]
	public static MLOFIFPDPIA BKFMFNMDOPB(this MBNEGLLKLEJ PIEBBHMNEOG, BIAFJNPKHBL<HDHGCCECDFN> BDNPJKGJPHN)
	{
		return default(MLOFIFPDPIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public interface IIDKLDGKAOP
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIAFJNPKHBL<GOOGICFALMF> JOBBAENBNCD(HOEBBPDIEOD JONDHAAAEFN);
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class OLOMJEADIJO : BAJNPNNFPAI<OLOMJEADIJO, DCCDIHPMMLE>, IIDKLDGKAOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private BIFGLJCHOMN<GOOGICFALMF, HOEBBPDIEOD> OJJAOPJLIAG;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D10270", Offset = "0x1D0EA70", VA = "0x181D10270", Slot = "6")]
	public BIAFJNPKHBL<GOOGICFALMF> JOBBAENBNCD(HOEBBPDIEOD JONDHAAAEFN)
	{
		return default(BIAFJNPKHBL<GOOGICFALMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D102C0", Offset = "0x1D0EAC0", VA = "0x181D102C0")]
	private OLOMJEADIJO([In] BIFGLJCHOMN<FIOKAOEJDHN, LDKAMBCKFPK<DCCDIHPMMLE>> ONMKGMKNFNM, [In] BIFGLJCHOMN<CGJGKMDFDEE, NBMLGICBOPL<DCCDIHPMMLE>> OEEAGLMHCMI, [In] BIFGLJCHOMN<GOOGICFALMF, HOEBBPDIEOD> PBJFGFJNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D100C0", Offset = "0x1D0E8C0", VA = "0x181D100C0")]
	public static OLOMJEADIJO AKKFLOCCMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D101C0", Offset = "0x1D0E9C0", VA = "0x181D101C0")]
	public new (GDEFMAIOBKG<FIOKAOEJDHN, LDKAMBCKFPK<DCCDIHPMMLE>>, GDEFMAIOBKG<CGJGKMDFDEE, NBMLGICBOPL<DCCDIHPMMLE>>, GDEFMAIOBKG<GOOGICFALMF, HOEBBPDIEOD>) JIBJCAGFJDK()
	{
		return default((GDEFMAIOBKG<FIOKAOEJDHN, LDKAMBCKFPK<DCCDIHPMMLE>>, GDEFMAIOBKG<CGJGKMDFDEE, NBMLGICBOPL<DCCDIHPMMLE>>, GDEFMAIOBKG<GOOGICFALMF, HOEBBPDIEOD>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public sealed class BEKBEBIBBCL : HJOPJBABLLI
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D05230", Offset = "0x1D03A30", VA = "0x181D05230", Slot = "7")]
	public override string PJMGMONBGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D05260", Offset = "0x1D03A60", VA = "0x181D05260")]
	public BEKBEBIBBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface GHKILDFDOLJ
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOEBBPDIEOD BBHGFECMIGB();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOEBBPDIEOD EEPJKACPPJC();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOEBBPDIEOD LHLIHBMDLBC();
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public interface LICAKHGBNBJ
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LBFOJMHFNLD<object, AABCOILMPHO>> MFJCJOEJHGF(JNDFKAPOEAK KJDOCFCKCJE, bool JHPDADAFFCB);
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
