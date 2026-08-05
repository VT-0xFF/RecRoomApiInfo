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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C0B80", Offset = "0x62BF780", VA = "0x1862C0B80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62BF900", Offset = "0x62BE500", VA = "0x1862BF900", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C13C0", Offset = "0x62BFFC0", VA = "0x1862C13C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BOCBFIKJIFA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> LPOJHJNELEE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LHCGCCPLJLB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JJKPFJDBFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BIDLAAGFFBH FNFMGCLBBML(Guid KOOCAHLAKIM, string BJIOCNFIMCK, [Optional] string DOBOLLELGDA, [Optional] long? MNCPBEPHFAI, [Optional] string LKJBBFGGAHM, [Optional] string KJIPEBCGMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MDIIBJKJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62BF990", Offset = "0x62BE590", VA = "0x1862BF990")]
		public static BIDLAAGFFBH EHILJANPGJF(Guid KOOCAHLAKIM, string BJIOCNFIMCK, string DOBOLLELGDA, [Optional] long? MNCPBEPHFAI, [Optional] string LKJBBFGGAHM, [Optional] string KJIPEBCGMDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class BIDLAAGFFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected NFJPOMEKENH KLBPGDIPDDO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
		public BIDLAAGFFBH(NFJPOMEKENH KLBPGDIPDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62B8720", Offset = "0x62B7320", VA = "0x1862B8720")]
		public BIDLAAGFFBH PANFNDPFEKI(string OPOMMFAAAOF, string CABLCDOIFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34779C0", Offset = "0x34765C0", VA = "0x1834779C0")]
		public BIDLAAGFFBH PANFNDPFEKI<T>(string OPOMMFAAAOF, T CABLCDOIFFL) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3477930", Offset = "0x3476530", VA = "0x183477930")]
		public BIDLAAGFFBH ODGCKHLIHHI<T>(string OPOMMFAAAOF, T? CABLCDOIFFL) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62B8670", Offset = "0x62B7270", VA = "0x1862B8670")]
		public BIDLAAGFFBH ODGCKHLIHHI(string OPOMMFAAAOF, string CABLCDOIFFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62B8700", Offset = "0x62B7300", VA = "0x1862B8700")]
		public DMMKPEDFDBF OKKJOHPBJDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x214CB10", Offset = "0x214B710", VA = "0x18214CB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class NFJPOMEKENH
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<NFJPOMEKENH> PPJGPIEHFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string BDGIAKPDGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> BKHOLKJEFAA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62C07E0", Offset = "0x62BF3E0", VA = "0x1862C07E0")]
		private NFJPOMEKENH(string BDGIAKPDGJF, int ADKBDELMJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62BF420", Offset = "0x62BE020", VA = "0x1862BF420")]
		public static BIDLAAGFFBH ELGDCMPCLII(string BDGIAKPDGJF, int ADKBDELMJDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62C0530", Offset = "0x62BF130", VA = "0x1862C0530")]
		public DMMKPEDFDBF OKKJOHPBJDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62C0770", Offset = "0x62BF370", VA = "0x1862C0770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E498D0", Offset = "0x2E484D0", VA = "0x182E498D0")]
		internal void MEAPDIPGJLH<T>(string OPOMMFAAAOF, T CABLCDOIFFL) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62C04D0", Offset = "0x62BF0D0", VA = "0x1862C04D0")]
		internal void MEAPDIPGJLH(string OPOMMFAAAOF, string CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x347E1B0", Offset = "0x347CDB0", VA = "0x18347E1B0")]
		private void EFLADLBMPOI<T>(string OPOMMFAAAOF, T CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct OMABLMBIDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string NDKOBPPOGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? IGGPMOFIGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? DGPEJCHOIOE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62C0C00", Offset = "0x62BF800", VA = "0x1862C0C00")]
		public OMABLMBIDJD(string HDEGOHIOJLL, [Optional] long? GLOFJPFEAOO, [Optional] short? KOKJOMCFCEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NEKKMEALECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int MOLLPGOILML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string JNKMPBDPIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short MEKJKFPJNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string BKIDBMBPGCE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62C0480", Offset = "0x62BF080", VA = "0x1862C0480")]
		public NEKKMEALECJ(int FINKMKAPMEM, string NLJCGOGKNDC, short NJCLAHGPJPH, string GCKGELFNLLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FOOMMFCJBBN : OCHOEFMLNDA<GGBIBFHJKFF, NEKKMEALECJ, OMABLMBIDJD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string NLJCGOGKNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short NJCLAHGPJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string GCKGELFNLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> KPENGFPLFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int JKEJEBHIDHE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62BA930", Offset = "0x62B9530", VA = "0x1862BA930")]
		public FOOMMFCJBBN(string ANMJAABGNGI, Guid PGGGHHALPNI, long OPFGDKAACDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62BA640", Offset = "0x62B9240", VA = "0x1862BA640", Slot = "4")]
		public override void JHGJOFDGJGP(NEKKMEALECJ KDGOKBKLLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62BA2B0", Offset = "0x62B8EB0", VA = "0x1862BA2B0")]
		public void GANFANFOMLN(short NJCLAHGPJPH, bool FIJPGBPMIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DDFC10", Offset = "0x3DDE810", VA = "0x183DDFC10")]
		public void KAOOKOKLABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88C750", Offset = "0x88B350", VA = "0x18088C750")]
		public void EJCFHIAGJHP(string KGPBALOCGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62B94D0", Offset = "0x62B80D0", VA = "0x1862B94D0", Slot = "5")]
		public override void AJGBBPAOIHB(bool JNIMAFGPCEH, OMABLMBIDJD NJLALHLDILH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62BA390", Offset = "0x62B8F90", VA = "0x1862BA390", Slot = "6")]
		public override AEKNBOENPNM HMOBNLBNCPB(GGBIBFHJKFF JIPANOBIPJE, int MFJLAMOCOBC, string OALBDPMKPJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class JCKJIAGPDFM : AEKNBOENPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string NLJCGOGKNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short NJCLAHGPJPH;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62BC660", Offset = "0x62BB260", VA = "0x1862BC660")]
		public JCKJIAGPDFM(long HKNGKNOKFAF, int FINKMKAPMEM, string DOBOLLELGDA, long OPFGDKAACDG, int DPMKMGDMFAA, string LKJBBFGGAHM, short NJCLAHGPJPH, string NLJCGOGKNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62BC4B0", Offset = "0x62BB0B0", VA = "0x1862BC4B0")]
		public void AFKBDNEFPKE(int FINKMKAPMEM, string NLJCGOGKNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62BC530", Offset = "0x62BB130", VA = "0x1862BC530", Slot = "5")]
		public override BIDLAAGFFBH FNFMGCLBBML(Guid KOOCAHLAKIM, string BJIOCNFIMCK, [Optional] string DOBOLLELGDA, [Optional] long? MNCPBEPHFAI, [Optional] string LKJBBFGGAHM, [Optional] string KJIPEBCGMDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PLBLMJGDLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62C0C40", Offset = "0x62BF840", VA = "0x1862C0C40")]
		public static void ECIKBILEACG(string NONKDEOLPHL, object LBPGJAMAOGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class GFMJKDMLOLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct KPOIMJJKHDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int KAOKJCFJDIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int PAKLBDFFOMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int HDFDANLKJNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int IJDEFAMMPCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int BBCBCKGIIAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int MDAJJODHKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int LINOLCLMOKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int ABJPOGGBFCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int NDJMFPODKEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int AICEIKMCBNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int OOHNKAPCFCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int PCJJCPOFBND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int MDNHGDMPGFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int OCDKGMAODKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int EKKOIDJOGJI;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x62BF330", Offset = "0x62BDF30", VA = "0x1862BF330")]
			public KPOIMJJKHDH(int DOOGOMBHDJK, int MABEGDGLHPI, int DNGHKMJLKDP, int IGBOGIGGJFF, int BNHDPAAAHKF, int CJMPLGDFHID, int ICCCALHPPJC, int LDNHMHLPMBF, int DDFGDKKFFMC, int PNDDBJMOHAN, int MHLBKKCILCC, int IACOONCKFIK, int HIBEIAHAJHH, int JLLMLLDHPNL, int DOLNODHOAPD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? MLNMIHOKFGE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> HJJCFEJGBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x62BB1A0", Offset = "0x62B9DA0", VA = "0x1862BB1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62BA9B0", Offset = "0x62B95B0", VA = "0x1862BA9B0")]
		public static void BFODKGGCJIH(KPOIMJJKHDH CCEGBLBBDGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ECJEKCPNFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62B8F40", Offset = "0x62B7B40", VA = "0x1862B8F40")]
		public static void ECIKBILEACG(string NONKDEOLPHL, object LBPGJAMAOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x62B8FB0", Offset = "0x62B7BB0", VA = "0x1862B8FB0")]
		public static void ECIKBILEACG(string NONKDEOLPHL, float CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62B90C0", Offset = "0x62B7CC0", VA = "0x1862B90C0")]
		public static void ECIKBILEACG(string NONKDEOLPHL, EPPHABIEBLC LBPGJAMAOGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class POGOBBLCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62C0CB0", Offset = "0x62BF8B0", VA = "0x1862C0CB0")]
		public static void JDICEMJLCBO(float3 GKJAMFFKDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62C0F00", Offset = "0x62BFB00", VA = "0x1862C0F00")]
		public static void KPFLPDDBKAM(bool KEDJDHGLDAI, bool GANMNNLAECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62C1020", Offset = "0x62BFC20", VA = "0x1862C1020")]
		public static void OBHBOJMFDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62C0DC0", Offset = "0x62BF9C0", VA = "0x1862C0DC0")]
		public static void JECDEBAIPHC(int HILDGOGJPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62C0E60", Offset = "0x62BFA60", VA = "0x1862C0E60")]
		public static void JMIFAJEMDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class HLIMADDLMEA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class NKJJHLKDDNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public HLIMADDLMEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public NKJJHLKDDNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4677C50", Offset = "0x4676850", VA = "0x184677C50")]
			internal object MPKFHIKACBJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class CAJELGGGNFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public HLIMADDLMEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CAJELGGGNFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5234C30", Offset = "0x5233830", VA = "0x185234C30")]
			internal object CGIJINLFHPA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class FJAFCFPKOKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public HLIMADDLMEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public FJAFCFPKOKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3E09DB0", Offset = "0x3E089B0", VA = "0x183E09DB0")]
			internal object JEBGABMFDNF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MCKBKJFKBBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public HLIMADDLMEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public MCKBKJFKBBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4585A50", Offset = "0x4584650", VA = "0x184585A50")]
			internal object AHHDBIHEHEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class CMAMGKKNKNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public HLIMADDLMEA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CMAMGKKNKNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x55E48B0", Offset = "0x55E34B0", VA = "0x1855E48B0")]
			internal object MIPHIPEMJLG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float NLBLDLGMDPK = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid KOOCAHLAKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string LKJBBFGGAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string CIPMJNJEBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string KLLDLFPHLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string KJIPEBCGMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string LEMICIOBDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string AMBJIDMMCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string NIHIAHCMOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string CEBBDOALCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string DBMAMOGOGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? HJICOCLGGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? EBLPBLCIJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> EPBADIKPGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> JHGNLHGBECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> NIFKJLOHODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> OAMEPKHPBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Dictionary<T, string[]> FMAIGEOHLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string LJHOEDHHIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool DFMMADGIGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private DMMKPEDFDBF BHDFNOLEDKK;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F51B30", Offset = "0x3F50730", VA = "0x183F51B30")]
		public HLIMADDLMEA(Guid KOOCAHLAKIM, string CIPMJNJEBMH, string LKJBBFGGAHM, string KLLDLFPHLKB, [Optional] string KJIPEBCGMDO, [Optional] string LEMICIOBDAB, [Optional] string AMBJIDMMCPG, [Optional] string DBMAMOGOGBB, [Optional] string LJHOEDHHIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
		public void IDBPJJMHFEE(string KJIPEBCGMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
		public void IAOPAFLBLKH(string KLLDLFPHLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBE9840", Offset = "0xBE8440", VA = "0x180BE9840")]
		public void HJLIFBMGHGC(string LJHOEDHHIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88C6D0", Offset = "0x88B2D0", VA = "0x18088C6D0")]
		public void BILKADGDGOK(string NIHIAHCMOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F4DBF0", Offset = "0x3F4C7F0", VA = "0x183F4DBF0")]
		public void LABGPPJOIPH(Guid? KOOCAHLAKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCBD0", Offset = "0x3EDB7D0", VA = "0x183EDCBD0")]
		public void MIMPLGHGDGM((int, int)? EBLPBLCIJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88C6F0", Offset = "0x88B2F0", VA = "0x18088C6F0")]
		public void MJFEEGFJLBK(string CEBBDOALCJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F51180", Offset = "0x3F4FD80", VA = "0x183F51180")]
		public void PJFJNKDKABG(T MNCPBEPHFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3F4EBE0", Offset = "0x3F4D7E0", VA = "0x183F4EBE0")]
		public void NHNJBHHFNEA(T MNCPBEPHFAI, int GMGPNPEKMGM, float CPOOPJBHGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F4E060", Offset = "0x3F4CC60", VA = "0x183F4E060")]
		public void LHNBDOJIPLM(T MNCPBEPHFAI, int GMGPNPEKMGM, string LFLMOKNBGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CAA0", Offset = "0x3F4B6A0", VA = "0x183F4CAA0")]
		public void AMGDDDAENIB(T MNCPBEPHFAI, string EMJHHOLBFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3F51630", Offset = "0x3F50230", VA = "0x183F51630")]
		public void POPHBOPIMCM(T MNCPBEPHFAI, string[] MDNGLDDHPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F4EF00", Offset = "0x3F4DB00", VA = "0x183F4EF00")]
		public DMMKPEDFDBF OKKJOHPBJDJ(bool KHODILEOPHB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F4B690", Offset = "0x3F4A290", VA = "0x183F4B690")]
		private (IEnumerable<T>, string) AJNIEPAICJC()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D450", Offset = "0x3F4C050", VA = "0x183F4D450")]
		public static BIDLAAGFFBH DDPKNHEEEFM(Guid KOOCAHLAKIM, string CIPMJNJEBMH, T MNCPBEPHFAI, string LKJBBFGGAHM, string GNIMIIMCEPH, string KJIPEBCGMDO, int? MFJLAMOCOBC, [Optional] string POMGEDAMKFC, [Optional] string EMJHHOLBFAB, [Optional] int? HDHODALAMLN, [Optional] Guid? HJICOCLGGIA, [Optional] string LJHOEDHHIOI, [Optional] string DOBOLLELGDA, [Optional] (int, int)? EBLPBLCIJGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F4DC90", Offset = "0x3F4C890", VA = "0x183F4DC90")]
		[CompilerGenerated]
		private string LHKNAODPJJB(T MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3F4CED0", Offset = "0x3F4BAD0", VA = "0x183F4CED0")]
		[CompilerGenerated]
		private string CDIFPFDHILA(T MJDOIIBKEKN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class OCHOEFMLNDA<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected readonly string ANMJAABGNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected readonly Guid PGGGHHALPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected readonly long OPFGDKAACDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int FINKMKAPMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected int FHEOPIDLOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected DateTime ANKLDGJBCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected bool LLMBBPKIJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Dictionary<long, AEKNBOENPNM> KDFCMGMCBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		protected bool MLEBIABCHLE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BNAOOFMMBLM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JDICAMHNLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8F45B0", Offset = "0x8F31B0", VA = "0x1808F45B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4798C90", Offset = "0x4797890", VA = "0x184798C90")]
		public OCHOEFMLNDA(string ANMJAABGNGI, Guid PGGGHHALPNI, long OPFGDKAACDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JHGJOFDGJGP(TListSessionStartParams KDGOKBKLLPK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xB2FD80", Offset = "0xB2E980", VA = "0x180B2FD80")]
		public void AJMBIPOFNPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AJGBBPAOIHB(bool JNIMAFGPCEH, TListSessionLogParams NJLALHLDILH);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4798930", Offset = "0x4797530", VA = "0x184798930")]
		public void AFKFCEGBGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x47989D0", Offset = "0x47975D0", VA = "0x1847989D0")]
		public void CPCAJGKFJKD(long HKNGKNOKFAF, int MFJLAMOCOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4798B70", Offset = "0x4797770", VA = "0x184798B70")]
		public void JLNMGMLMDCN(long HKNGKNOKFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract AEKNBOENPNM HMOBNLBNCPB(TItem ANPIFEPGOLG, int MFJLAMOCOBC, string OALBDPMKPJG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class AEKNBOENPNM : JJKPFJDBFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int FINKMKAPMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private long HKNGKNOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long OPFGDKAACDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly string KPBDMLJPAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly string BBECEGLPFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly int DPMKMGDMFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private DateTime JAJFEKIEPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private double LDMHOKCJGKC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CMKCPFABFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1251640", Offset = "0x1250240", VA = "0x181251640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x12512B0", Offset = "0x124FEB0", VA = "0x1812512B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62B80D0", Offset = "0x62B6CD0", VA = "0x1862B80D0")]
		public AEKNBOENPNM(long HKNGKNOKFAF, int FINKMKAPMEM, string DOBOLLELGDA, long OPFGDKAACDG, int DPMKMGDMFAA, [Optional] string LKJBBFGGAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62B7F50", Offset = "0x62B6B50", VA = "0x1862B7F50")]
		public void NDEIAOHNEOB(int FINKMKAPMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62B79F0", Offset = "0x62B65F0", VA = "0x1862B79F0")]
		public void FLKLNFGCHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62B7FC0", Offset = "0x62B6BC0", VA = "0x1862B7FC0")]
		public void NPABEFCEGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62B7EF0", Offset = "0x62B6AF0", VA = "0x1862B7EF0")]
		private void IBLKCNEENIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62B7A40", Offset = "0x62B6640", VA = "0x1862B7A40", Slot = "5")]
		public virtual BIDLAAGFFBH FNFMGCLBBML(Guid KOOCAHLAKIM, string BJIOCNFIMCK, [Optional] string DOBOLLELGDA, [Optional] long? MNCPBEPHFAI, [Optional] string LKJBBFGGAHM, [Optional] string KJIPEBCGMDO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class JMFBBFLJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class CPJGHDBCGPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public CPJGHDBCGPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62B8EA0", Offset = "0x62B7AA0", VA = "0x1862B8EA0")]
			internal bool OPKNLFHFCNE()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct IPFPMNKLOAB : IAsyncStateMachine
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
			private CPJGHDBCGPG <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x62BB250", Offset = "0x62B9E50", VA = "0x1862BB250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x62BC450", Offset = "0x62BB050", VA = "0x1862BC450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly float DENCJKJNPBG;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, Dictionary<string, object>> CFDFBFMKBNG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static Dictionary<string, Dictionary<string, object>> AHCPPALHKBP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static string MHKLAAHIKGL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static CancellationTokenSource? PMNAPIIBKDN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static int LIOIGPDPPKE;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static int OHENANPAEEP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static bool PCNNJJMEFCC;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly Dictionary<string, BOCBFIKJIFA> AOMFHDKNCDB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly CBECGFLMOCG<bool> LPGOMHMPLLF;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static AJLACEJPNNH? PAENLKMNEBG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string HEFEHBIFFLL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x62BED40", Offset = "0x62BD940", VA = "0x1862BED40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x62BE880", Offset = "0x62BD480", VA = "0x1862BE880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? GLMKKBIMPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x62BD420", Offset = "0x62BC020", VA = "0x1862BD420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62BEAE0", Offset = "0x62BD6E0", VA = "0x1862BEAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? LBILPGOGODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x62BE990", Offset = "0x62BD590", VA = "0x1862BE990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x62BC750", Offset = "0x62BB350", VA = "0x1862BC750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static GEGKBDLKNEN<bool> LKBGOONHAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x62BDC80", Offset = "0x62BC880", VA = "0x1862BDC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool GEGLPOMAGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x62BCFA0", Offset = "0x62BBBA0", VA = "0x1862BCFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x62BE790", Offset = "0x62BD390", VA = "0x1862BE790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool KGLJPHIOPCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x62BDAE0", Offset = "0x62BC6E0", VA = "0x1862BDAE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x62BE550", Offset = "0x62BD150", VA = "0x1862BE550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float DCDOBFGNAFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x62BE9F0", Offset = "0x62BD5F0", VA = "0x1862BE9F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x62BE930", Offset = "0x62BD530", VA = "0x1862BE930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62BE7F0", Offset = "0x62BD3F0", VA = "0x1862BE7F0")]
		public static void LHDGBJFICCI(string AHJPILDKNIG, BOCBFIKJIFA FCPBPHLDGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62BCFF0", Offset = "0x62BBBF0", VA = "0x1862BCFF0")]
		private static void DNIEADDIGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62BE5B0", Offset = "0x62BD1B0", VA = "0x1862BE5B0")]
		internal static void KMAKNPIEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62BD8E0", Offset = "0x62BC4E0", VA = "0x1862BD8E0")]
		internal static void FCCPBBAAIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62BEA40", Offset = "0x62BD640", VA = "0x1862BEA40")]
		internal static void OBCDANGHJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62BDF80", Offset = "0x62BCB80", VA = "0x1862BDF80")]
		public static Guid JHGJOFDGJGP(string AHJPILDKNIG, [Optional] string? MOLCGHGHFLL, [Optional] Dictionary<string, object>? FPNFFAGEDOF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62BDEE0", Offset = "0x62BCAE0", VA = "0x1862BDEE0")]
		public static Guid JHGJOFDGJGP(string AHJPILDKNIG, long MOLCGHGHFLL, [Optional] Dictionary<string, object>? FPNFFAGEDOF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62BC7B0", Offset = "0x62BB3B0", VA = "0x1862BC7B0")]
		public static void AJMBIPOFNPE(string AHJPILDKNIG, [Optional] Guid? OCIHAODAEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62BEB40", Offset = "0x62BD740", VA = "0x1862BEB40")]
		public static void OFAPHDHGMJB(string AHJPILDKNIG, string LAENNHMPFKA, object FFBMMAAGCCF, bool PCNNJJMEFCC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62BCDB0", Offset = "0x62BB9B0", VA = "0x1862BCDB0")]
		public static bool CCFKEIAFMJO(string AHJPILDKNIG, [Optional] string? MOLCGHGHFLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62BDCD0", Offset = "0x62BC8D0", VA = "0x1862BDCD0")]
		private static void HPOOMJODCKA(bool MOLDKGFLHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62BEF10", Offset = "0x62BDB10", VA = "0x1862BEF10")]
		internal static void PEFBLEKKLDO(string PDMONEGPHPK, string NONKDEOLPHL, object BFLLAIFBMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62BED90", Offset = "0x62BD990", VA = "0x1862BED90")]
		internal static void PEFBLEKKLDO(string PDMONEGPHPK, Dictionary<string, object> LNIHEAGKKGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62BDB30", Offset = "0x62BC730", VA = "0x1862BDB30")]
		private static void GNENDGOGDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62BF090", Offset = "0x62BDC90", VA = "0x1862BF090")]
		public static void PPMAJBGMLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62BDA90", Offset = "0x62BC690", VA = "0x1862BDA90")]
		public static void FINDOCCALLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62BCA10", Offset = "0x62BB610", VA = "0x1862BCA10")]
		private static void BLLDDBJGAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62BDE10", Offset = "0x62BCA10", VA = "0x1862BDE10")]
		private static void JBENGOKOGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62BDBA0", Offset = "0x62BC7A0", VA = "0x1862BDBA0")]
		[AsyncStateMachine(typeof(IPFPMNKLOAB))]
		private static Task HBAOMJFGMCO(CancellationToken CKKFHABGBNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62BD480", Offset = "0x62BC080", VA = "0x1862BD480")]
		private static void FAIDIIENOGJ(string AHJPILDKNIG, Guid KOOCAHLAKIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BAOOJMEANNC
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct KEKAMCGCDCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool GBICIGILFBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string GBOALNADBDE;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1DB85B0", Offset = "0x1DB71B0", VA = "0x181DB85B0")]
			public KEKAMCGCDCH(bool GBICIGILFBJ, string GBOALNADBDE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62B81A0", Offset = "0x62B6DA0", VA = "0x1862B81A0")]
		public static KEKAMCGCDCH GHFFBIFPAGE(BIDLAAGFFBH JALJLGDDOKH)
		{
			return default(KEKAMCGCDCH);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62B84B0", Offset = "0x62B70B0", VA = "0x1862B84B0")]
		private static void JMHODLGDKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62B85B0", Offset = "0x62B71B0", VA = "0x1862B85B0")]
		private static void PEKOFJHMFPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class NNKOPIMHOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x62C0B20", Offset = "0x62BF720", VA = "0x1862C0B20")]
		public static BIDLAAGFFBH OJIEHLOJEKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class NCGBPBJAENI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x62BFC00", Offset = "0x62BE800", VA = "0x1862BFC00")]
		public static BIDLAAGFFBH BENAENMNCBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62BFFC0", Offset = "0x62BEBC0", VA = "0x1862BFFC0")]
		public static BIDLAAGFFBH NLALAFDHMKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62BFBA0", Offset = "0x62BE7A0", VA = "0x1862BFBA0")]
		public static BIDLAAGFFBH AJEGEPINKLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62C0080", Offset = "0x62BEC80", VA = "0x1862C0080")]
		public static BIDLAAGFFBH PEIEEGAMNNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62BFF00", Offset = "0x62BEB00", VA = "0x1862BFF00")]
		public static BIDLAAGFFBH MIEICEMCCNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62BFDE0", Offset = "0x62BE9E0", VA = "0x1862BFDE0")]
		public static BIDLAAGFFBH FLHACNNFKKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62BFD20", Offset = "0x62BE920", VA = "0x1862BFD20")]
		public static BIDLAAGFFBH EJEDGACOLDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62BFD80", Offset = "0x62BE980", VA = "0x1862BFD80")]
		public static BIDLAAGFFBH EMOACOFCOOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62C0020", Offset = "0x62BEC20", VA = "0x1862C0020")]
		public static BIDLAAGFFBH NNCLANGMKMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62BFEA0", Offset = "0x62BEAA0", VA = "0x1862BFEA0")]
		public static BIDLAAGFFBH LIMKJEHCHAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62BFF60", Offset = "0x62BEB60", VA = "0x1862BFF60")]
		public static BIDLAAGFFBH NDCAFCEAKKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62BFCC0", Offset = "0x62BE8C0", VA = "0x1862BFCC0")]
		public static BIDLAAGFFBH DKFFGKNLPFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62BFC60", Offset = "0x62BE860", VA = "0x1862BFC60")]
		public static BIDLAAGFFBH DBKNPDNBFMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62BFE40", Offset = "0x62BEA40", VA = "0x1862BFE40")]
		public static BIDLAAGFFBH KIKAEJOLBDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ECNCCFEGJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62B92F0", Offset = "0x62B7EF0", VA = "0x1862B92F0")]
		public static BIDLAAGFFBH LAKPAMIOLPG(long GLOFJPFEAOO, long FMFLAKHLPHK, bool KDJOKLHDNNM, string ANDHKGOAHPD, string AAHLIAFCDGK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NCOCCGNKDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62C0310", Offset = "0x62BEF10", VA = "0x1862C0310")]
		public static BIDLAAGFFBH DHLNGANEIEN(string ALDLFPEMCDK, string IEEGLDLILMP, bool OBAJKJGFEOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62C00E0", Offset = "0x62BECE0", VA = "0x1862C00E0")]
		public static BIDLAAGFFBH BBEICJFEJHO(string PDMONEGPHPK, string LKKJMCPGGJH, string LODALMOMCCJ, [Optional] int? IEAGDOPCCDO, [Optional] double[] ODBDOENMGOB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class BKGEDNNHLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62B88C0", Offset = "0x62B74C0", VA = "0x1862B88C0")]
		public static BIDLAAGFFBH HBPGHMMIEME(string GLCAEEHNDLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62B8C10", Offset = "0x62B7810", VA = "0x1862B8C10")]
		public static BIDLAAGFFBH IKBILBMCGEI(string DLHEBFLILFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x62B8860", Offset = "0x62B7460", VA = "0x1862B8860")]
		public static BIDLAAGFFBH EPLGOJCCNMD(int ADKBDELMJDI, string GMBAACDNNFI, string MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x62B8CF0", Offset = "0x62B78F0", VA = "0x1862B8CF0")]
		public static BIDLAAGFFBH JLMMPJKBCGM(int ADKBDELMJDI, string GMBAACDNNFI, string MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x62B8800", Offset = "0x62B7400", VA = "0x1862B8800")]
		public static BIDLAAGFFBH BAOPEGAFIKI(int ADKBDELMJDI, string GMBAACDNNFI, string MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62B87A0", Offset = "0x62B73A0", VA = "0x1862B87A0")]
		public static BIDLAAGFFBH AAINCPMEBJJ(int ADKBDELMJDI, string GMBAACDNNFI, string MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x62B8D50", Offset = "0x62B7950", VA = "0x1862B8D50")]
		public static BIDLAAGFFBH KNNIIHIGGEP(string GMBAACDNNFI, string MJDOIIBKEKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62B89A0", Offset = "0x62B75A0", VA = "0x1862B89A0")]
		private static BIDLAAGFFBH IFBLPKEEHDO(string ANMJAABGNGI, int ADKBDELMJDI, string GLHABOFGKEO, string FAHLPCCHNNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62B8AE0", Offset = "0x62B76E0", VA = "0x1862B8AE0")]
		private static BIDLAAGFFBH IFBLPKEEHDO(string ANMJAABGNGI, string GLHABOFGKEO, string FAHLPCCHNNO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly BNHLDIHMNLF GHFFBIFPAGE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ILCELNBOEME JBLNJDLFMJK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FNGKILJBOOA KHGMPJDPAMB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<BIDLAAGFFBH> AAPJOEAJCPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long DOJFDFIJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62BF7A0", Offset = "0x62BE3A0", VA = "0x1862BF7A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62BF4D0", Offset = "0x62BE0D0", VA = "0x1862BF4D0")]
	[INGHJIDHCCJ.DFFPMDBMIAE]
	internal static void EEJKNFECAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62BF5C0", Offset = "0x62BE1C0", VA = "0x1862BF5C0")]
	private static void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62BF3A0", Offset = "0x62BDFA0", VA = "0x1862BF3A0")]
	public static BIDLAAGFFBH DNNAFOLFGOK(string BDGIAKPDGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62BF420", Offset = "0x62BE020", VA = "0x1862BF420")]
	public static BIDLAAGFFBH DNNAFOLFGOK(string BDGIAKPDGJF, int ADKBDELMJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62BF680", Offset = "0x62BE280", VA = "0x1862BF680")]
	[INGHJIDHCCJ.DFFPMDBMIAE]
	internal static void NCJNGAHLPCP()
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
