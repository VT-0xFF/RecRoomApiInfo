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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x632D7C0", Offset = "0x632C1C0", VA = "0x18632D7C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x632D390", Offset = "0x632BD90", VA = "0x18632D390", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x632EDC0", Offset = "0x632D7C0", VA = "0x18632EDC0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EGHFNNKKCEP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> GEKBCDHNLHH();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GPGLMKGKNGG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EGDMGMAFJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NCADCHHGNMM HOJJNBMPKFO(Guid LHJFCKGLOBG, string EOHMGONFIDB, [Optional] string BPGGDLCCALD, [Optional] long? MIEJCHBJGNK, [Optional] string CALGPPKAMIA, [Optional] string FFJAPDNBDFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MKMBOKJPAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x632D420", Offset = "0x632BE20", VA = "0x18632D420")]
		public static NCADCHHGNMM BHFLOILCHGE(Guid LHJFCKGLOBG, string EOHMGONFIDB, string BPGGDLCCALD, [Optional] long? MIEJCHBJGNK, [Optional] string CALGPPKAMIA, [Optional] string FFJAPDNBDFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NCADCHHGNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected GCLOCNNEAOO GIEOAGIJFBB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
		public NCADCHHGNMM(GCLOCNNEAOO GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x632D6E0", Offset = "0x632C0E0", VA = "0x18632D6E0")]
		public NCADCHHGNMM GOPKJLCFEDI(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x340E100", Offset = "0x340CB00", VA = "0x18340E100")]
		public NCADCHHGNMM GOPKJLCFEDI<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x340E070", Offset = "0x340CA70", VA = "0x18340E070")]
		public NCADCHHGNMM GBKBFGGBLEM<T>(string PKFJNPAMFMB, T? KLABJGGMBGH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x632D650", Offset = "0x632C050", VA = "0x18632D650")]
		public NCADCHHGNMM GBKBFGGBLEM(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x632D630", Offset = "0x632C030", VA = "0x18632D630")]
		public EOHNLEPDLDE FCOCIKKNLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2140B10", Offset = "0x213F510", VA = "0x182140B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GCLOCNNEAOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<GCLOCNNEAOO> IAGGKPPKOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string BGEIDKDDNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> JKCKNBOJFIM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6327CB0", Offset = "0x63266B0", VA = "0x186327CB0")]
		private GCLOCNNEAOO(string BGEIDKDDNAG, int DKOHPFNHOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6327B90", Offset = "0x6326590", VA = "0x186327B90")]
		public static NCADCHHGNMM GMDNOGMNFLF(string BGEIDKDDNAG, int DKOHPFNHOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6327950", Offset = "0x6326350", VA = "0x186327950")]
		public EOHNLEPDLDE FCOCIKKNLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6327C40", Offset = "0x6326640", VA = "0x186327C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E07F10", Offset = "0x2E06910", VA = "0x182E07F10")]
		internal void CLGFGABNIJP<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63278F0", Offset = "0x63262F0", VA = "0x1863278F0")]
		internal void CLGFGABNIJP(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3408E30", Offset = "0x3407830", VA = "0x183408E30")]
		private void LFEEIPEODPB<T>(string PKFJNPAMFMB, T KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CFMGCGGOAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string BLJNJEJNBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? OMKGAKAMIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? OCLJEDLECHE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6325730", Offset = "0x6324130", VA = "0x186325730")]
		public CFMGCGGOAKM(string NGFHOKEAFAE, [Optional] long? FNKMOIJJLLC, [Optional] short? JCGAGHDMNJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FKDMKEPDJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int ONCBOOGODOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string MOFAAEKBPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short LJJJGAJCDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string IMGNHNLCFPE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6327610", Offset = "0x6326010", VA = "0x186327610")]
		public FKDMKEPDJFN(int HIHMKCLGBJJ, string HPDFELOGCPD, short DENADLOPLLG, string EGJGDMAAAAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class DHLEFEGPLMK : KOFAKDGNDDO<LJNFALBLIFC, FKDMKEPDJFN, CFMGCGGOAKM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string HPDFELOGCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short DENADLOPLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string EGJGDMAAAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> OMGPFOIBHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int PDHJHLKOPIG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6326BD0", Offset = "0x63255D0", VA = "0x186326BD0")]
		public DHLEFEGPLMK(string PJJMBOHKNAL, Guid ENGGKJCHLBI, long FBCNKAADCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6326800", Offset = "0x6325200", VA = "0x186326800", Slot = "4")]
		public override void GBODEMMMAJE(FKDMKEPDJFN ACMLDNHDHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6326AF0", Offset = "0x63254F0", VA = "0x186326AF0")]
		public void PIDELBACACA(short DENADLOPLLG, bool AJKPKEEFGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE170", Offset = "0x3DCCB70", VA = "0x183DCE170")]
		public void GJPDFOHOOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		public void FMLNEIPHBPA(string JFAEECJILLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6325A20", Offset = "0x6324420", VA = "0x186325A20", Slot = "5")]
		public override void GBEHHPIMKME(bool IHDCBPEHPKN, CFMGCGGOAKM IDBBCPIFEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6325770", Offset = "0x6324170", VA = "0x186325770", Slot = "6")]
		public override HMNIGLHODBD DGNLADKNKPN(LJNFALBLIFC LOLBGIPGGDC, int HGFDMIDEFHN, string DBFNEOCMANL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PILPPJENIBB : HMNIGLHODBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string HPDFELOGCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short DENADLOPLLG;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x632E280", Offset = "0x632CC80", VA = "0x18632E280")]
		public PILPPJENIBB(long EAOAFMGNILC, int HIHMKCLGBJJ, string BPGGDLCCALD, long FBCNKAADCGD, int DBILGPPNEMM, string CALGPPKAMIA, short DENADLOPLLG, string HPDFELOGCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x632E200", Offset = "0x632CC00", VA = "0x18632E200")]
		public void JDBEHPGNMKE(int HIHMKCLGBJJ, string HPDFELOGCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x632E0D0", Offset = "0x632CAD0", VA = "0x18632E0D0", Slot = "5")]
		public override NCADCHHGNMM HOJJNBMPKFO(Guid LHJFCKGLOBG, string EOHMGONFIDB, [Optional] string BPGGDLCCALD, [Optional] long? MIEJCHBJGNK, [Optional] string CALGPPKAMIA, [Optional] string FFJAPDNBDFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DJICBGEMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6326C50", Offset = "0x6325650", VA = "0x186326C50")]
		public static void GHNAMHBKHIL(string LFOBGDLOPID, object AGHEGPHMAKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class OPAAGHGABNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct EGMHGNMOHCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int HBBFONCKAMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int GMANBDJGNII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int BHOFMNKCIFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int DMKGHHJIKBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int FFPHNIBDBGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int BFPOMJMFAJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int KDBNEHMIIDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int OIOJOFLPJIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int DFAPGGJNNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int NACMJFHOPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int FCMBNJLENDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int CALDGBPKGNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int AHEBCADOIKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int ELNBEBIDGDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int MHECMMNCJIJ;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6326CC0", Offset = "0x63256C0", VA = "0x186326CC0")]
			public EGMHGNMOHCN(int NPEHMGODGBB, int EMOPFKBMFKM, int KEBMIBGLEJK, int GBBFPHDIEFL, int LDHKEHJANDM, int KOJCOHIDJGE, int FJAPKBHNCJO, int DMEFAJCCPOC, int JPMBMIPDLEN, int FPHNLAILIMP, int MIEDKOIKNHN, int EGBNAKMCMME, int JFPPANNPOFH, int JDEPFGEKEAJ, int FBGGKGCOFML)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? BMIEPPJDJKM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> KFDOKJPOFFB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x632D840", Offset = "0x632C240", VA = "0x18632D840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x632D8F0", Offset = "0x632C2F0", VA = "0x18632D8F0")]
		public static void KPMFMFBGFPM(EGMHGNMOHCN LEGMJCLILML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class FPNAJKALNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6327660", Offset = "0x6326060", VA = "0x186327660")]
		public static void GHNAMHBKHIL(string LFOBGDLOPID, object AGHEGPHMAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63276D0", Offset = "0x63260D0", VA = "0x1863276D0")]
		public static void GHNAMHBKHIL(string LFOBGDLOPID, FMCECJDHLGB AGHEGPHMAKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class PLNLKPPDHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x632E530", Offset = "0x632CF30", VA = "0x18632E530")]
		public static void KAOLJAEIINI(float3 LEELMECKGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x632E370", Offset = "0x632CD70", VA = "0x18632E370")]
		public static void GLKODGNEMPD(bool OPMDJHBIICE, bool IODDBGMJFNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x632E490", Offset = "0x632CE90", VA = "0x18632E490")]
		public static void JOHIOOHEEAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class GJHGJJLJAKO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CEIDGBONJIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public GJHGJJLJAKO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public CEIDGBONJIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x557E930", Offset = "0x557D330", VA = "0x18557E930")]
			internal object CDDFFNNPADJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class GHGNFEDGBAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public GJHGJJLJAKO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GHGNFEDGBAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3ED79E0", Offset = "0x3ED63E0", VA = "0x183ED79E0")]
			internal object PKPEIHLAOBG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class MFKDHJGOPBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public GJHGJJLJAKO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public MFKDHJGOPBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4766B90", Offset = "0x4765590", VA = "0x184766B90")]
			internal object EJIAAHNEHHJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KDNANLHEBBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public GJHGJJLJAKO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public KDNANLHEBBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4416260", Offset = "0x4414C60", VA = "0x184416260")]
			internal object GLABHNNLOLH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float KGDJFBOLIEJ = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid LHJFCKGLOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string CALGPPKAMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string AGPNMOBNOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string PEGGDPPLFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string FFJAPDNBDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string CPFDKLOJFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string DOKJGHGPLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string BKCIODBPBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string FACGLPPFOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string ILOFCKCOMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? LOAGDFFPIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? CPDOBPFECII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> GPNJKHEBGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> NDNCDFOAAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> JDECJDPONJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> DLCFOJDNKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string EIGDNAIEJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GJKBODNEFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private EOHNLEPDLDE PKNCNAKAMDD;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0FE0", Offset = "0x3EDF9E0", VA = "0x183EE0FE0")]
		public GJHGJJLJAKO(Guid LHJFCKGLOBG, string AGPNMOBNOKI, string CALGPPKAMIA, string PEGGDPPLFKC, [Optional] string FFJAPDNBDFJ, [Optional] string CPFDKLOJFKI, [Optional] string DOKJGHGPLGC, [Optional] string ILOFCKCOMPO, [Optional] string EIGDNAIEJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		public void MMLGKALONIL(string FFJAPDNBDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		public void DAEAEDKIDBE(string PEGGDPPLFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0")]
		public void EIJHIOLJIGM(string EIGDNAIEJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		public void ELCJPAEICKE(string BKCIODBPBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE0A0", Offset = "0x3EDCAA0", VA = "0x183EDE0A0")]
		public void HLGIEDBBAEN(Guid? LHJFCKGLOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB440", Offset = "0x3ED9E40", VA = "0x183EDB440")]
		public void DCPMLFAMCOK((int, int)? CPDOBPFECII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		public void GHBLBFKKDIP(string FACGLPPFOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF120", Offset = "0x3EDDB20", VA = "0x183EDF120")]
		public void LEGLAGGANFN(T MIEJCHBJGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0960", Offset = "0x3EDF360", VA = "0x183EE0960")]
		public void MGOEONCEFOD(T MIEJCHBJGNK, int KHLKIJNBBPP, float MCPPIEMELEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE380", Offset = "0x3EDCD80", VA = "0x183EDE380")]
		public void INEFAPMIPGC(T MIEJCHBJGNK, int KHLKIJNBBPP, string BKJDNDAINKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEC20", Offset = "0x3EDD620", VA = "0x183EDEC20")]
		public void KEBJNLDLBJD(T MIEJCHBJGNK, string KFMPLNGMGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCA20", Offset = "0x3EDB420", VA = "0x183EDCA20")]
		public EOHNLEPDLDE FCOCIKKNLAM(bool LENLJCDCMCG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFF70", Offset = "0x3EDE970", VA = "0x183EDFF70")]
		private (IEnumerable<T>, string) LLNNBFDANBB()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD8E0", Offset = "0x3EDC2E0", VA = "0x183EDD8E0")]
		public static NCADCHHGNMM FPJDJKDPOCG(Guid LHJFCKGLOBG, string AGPNMOBNOKI, T MIEJCHBJGNK, string CALGPPKAMIA, string HHNCDBIPKMJ, string FFJAPDNBDFJ, int? HGFDMIDEFHN, [Optional] string DNGCFDJPJOF, [Optional] string KFMPLNGMGOI, [Optional] int? EFBOPOFJFDJ, [Optional] Guid? LOAGDFFPIPL, [Optional] string EIGDNAIEJMM, [Optional] string BPGGDLCCALD, [Optional] (int, int)? CPDOBPFECII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB320", Offset = "0x3ED9D20", VA = "0x183EDB320")]
		[CompilerGenerated]
		private string BLLEMDAIGLK(T MCAKFNPAKIL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class KOFAKDGNDDO<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string PJJMBOHKNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid ENGGKJCHLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long FBCNKAADCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int HIHMKCLGBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int FOEFDNHJFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime HHPGMJJPMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool NMIBAAGJFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, HMNIGLHODBD> DLKLDFCJNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool KGDFOBKBGLL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool OKKHPAEKBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x91C960", Offset = "0x91B360", VA = "0x18091C960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JKBKKOEIPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9A44C0", Offset = "0x9A2EC0", VA = "0x1809A44C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4444800", Offset = "0x4443200", VA = "0x184444800")]
		public KOFAKDGNDDO(string PJJMBOHKNAL, Guid ENGGKJCHLBI, long FBCNKAADCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GBODEMMMAJE(TListSessionStartParams ACMLDNHDHEF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBBEB80", Offset = "0xBBD580", VA = "0x180BBEB80")]
		public void GILGLMOAFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GBEHHPIMKME(bool IHDCBPEHPKN, TListSessionLogParams IDBBCPIFEOI);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4444570", Offset = "0x4442F70", VA = "0x184444570")]
		public void DJOGLOCAKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x44443D0", Offset = "0x4442DD0", VA = "0x1844443D0")]
		public void BAGEMHPCPJB(long EAOAFMGNILC, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x44446A0", Offset = "0x44430A0", VA = "0x1844446A0")]
		public void KFNONONJPLJ(long EAOAFMGNILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract HMNIGLHODBD DGNLADKNKPN(TItem IFNDNLEGMFO, int HGFDMIDEFHN, string DBFNEOCMANL);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class HMNIGLHODBD : EGDMGMAFJAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int HIHMKCLGBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long EAOAFMGNILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long FBCNKAADCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string CHAKMNAKLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string NELJBHOOMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int DBILGPPNEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime INELHNBENOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double KGNDMEFGOOG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OEHIEPNODJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x923C70", Offset = "0x922670", VA = "0x180923C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x922FC0", Offset = "0x9219C0", VA = "0x180922FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x632B770", Offset = "0x632A170", VA = "0x18632B770")]
		public HMNIGLHODBD(long EAOAFMGNILC, int HIHMKCLGBJJ, string BPGGDLCCALD, long FBCNKAADCGD, int DBILGPPNEMM, [Optional] string CALGPPKAMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x632B1A0", Offset = "0x6329BA0", VA = "0x18632B1A0")]
		public void FHJHBDGDOIC(int HIHMKCLGBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x632B210", Offset = "0x6329C10", VA = "0x18632B210")]
		public void GADJNFEGNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x632B090", Offset = "0x6329A90", VA = "0x18632B090")]
		public void CHDEOMFHAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x632B260", Offset = "0x6329C60", VA = "0x18632B260")]
		private void HKJBPNDDPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x632B2C0", Offset = "0x6329CC0", VA = "0x18632B2C0", Slot = "5")]
		public virtual NCADCHHGNMM HOJJNBMPKFO(Guid LHJFCKGLOBG, string EOHMGONFIDB, [Optional] string BPGGDLCCALD, [Optional] long? MIEJCHBJGNK, [Optional] string CALGPPKAMIA, [Optional] string FFJAPDNBDFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HACKNJICCGB
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HNLJGFGKPFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HNLJGFGKPFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x632B840", Offset = "0x632A240", VA = "0x18632B840")]
			internal bool FJDFFNHLHHB()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct KKIHOBIFCJD : IAsyncStateMachine
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
			private HNLJGFGKPFK <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x632BC80", Offset = "0x632A680", VA = "0x18632BC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x632CE60", Offset = "0x632B860", VA = "0x18632CE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float MPJFFBHNJLE;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> DFIKOKPMGLA;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> EAKGLEMLCLP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string NDEIKMOFAMI;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? OBFPFDCNEOG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int GEFMDHEPCPC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int AMMPAMNKDBP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool BBMCHKKKMFM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, EGHFNNKKCEP> KAGPBIHDGNE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly KHECJJJIFBB<bool> CLDJJGIOPJB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static LEBBOCDPOJL? MMONEJKNGMO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string BEFNEIPICBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x632A930", Offset = "0x6329330", VA = "0x18632A930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x632A7D0", Offset = "0x63291D0", VA = "0x18632A7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? GCENCDDNFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x632A1E0", Offset = "0x6328BE0", VA = "0x18632A1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63284A0", Offset = "0x6326EA0", VA = "0x1863284A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? BFEAFFMAKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x632A8D0", Offset = "0x63292D0", VA = "0x18632A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6329AD0", Offset = "0x63284D0", VA = "0x186329AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static MODDMLILIKO<bool> KOLLGNHJKHI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6328D50", Offset = "0x6327750", VA = "0x186328D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool FMBENCGDPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x632A980", Offset = "0x6329380", VA = "0x18632A980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x632A240", Offset = "0x6328C40", VA = "0x18632A240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool ODCPKCLPAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x63293A0", Offset = "0x6327DA0", VA = "0x1863293A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x63292B0", Offset = "0x6327CB0", VA = "0x1863292B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float LHKKPFPKCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x632A880", Offset = "0x6329280", VA = "0x18632A880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x632A180", Offset = "0x6328B80", VA = "0x18632A180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6329310", Offset = "0x6327D10", VA = "0x186329310")]
		public static void FDBPGNFLGND(string GIHNHDHICBG, EGHFNNKKCEP JOFBFEFNFMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6328DA0", Offset = "0x63277A0", VA = "0x186328DA0")]
		private static void DNOLBDOPLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6328500", Offset = "0x6326F00", VA = "0x186328500")]
		internal static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6329FD0", Offset = "0x63289D0", VA = "0x186329FD0")]
		internal static void ILGPEBACAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x632A9D0", Offset = "0x63293D0", VA = "0x18632A9D0")]
		internal static void NNKCHEEOIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6329500", Offset = "0x6327F00", VA = "0x186329500")]
		public static Guid GBODEMMMAJE(string GIHNHDHICBG, [Optional] string? NHAAIIBGEEH, [Optional] Dictionary<string, object>? IEHIOJFMCJA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6329460", Offset = "0x6327E60", VA = "0x186329460")]
		public static Guid GBODEMMMAJE(string GIHNHDHICBG, long NHAAIIBGEEH, [Optional] Dictionary<string, object>? IEHIOJFMCJA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6329B30", Offset = "0x6328530", VA = "0x186329B30")]
		public static void GILGLMOAFKB(string GIHNHDHICBG, [Optional] Guid? GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6328B40", Offset = "0x6327540", VA = "0x186328B40")]
		public static void CGMONNOKJCC(string GIHNHDHICBG, string HLFMMAJIGEG, object APCDCFKEBFP, bool BBMCHKKKMFM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6329D90", Offset = "0x6328790", VA = "0x186329D90")]
		public static bool GKMBGDAIDME(string GIHNHDHICBG, [Optional] string? NHAAIIBGEEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x632A2A0", Offset = "0x6328CA0", VA = "0x18632A2A0")]
		private static void KLBAHJPMGGI(bool JJLBNGBLPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x632ABF0", Offset = "0x63295F0", VA = "0x18632ABF0")]
		internal static void OEDDOGLNFMF(string EIGKPCONJCB, string LFOBGDLOPID, object JGCMECODHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x632AA70", Offset = "0x6329470", VA = "0x18632AA70")]
		internal static void OEDDOGLNFMF(string EIGKPCONJCB, Dictionary<string, object> GMHOCNFEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63293F0", Offset = "0x6327DF0", VA = "0x1863293F0")]
		private static void FNICIFOMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x632A3E0", Offset = "0x6328DE0", VA = "0x18632A3E0")]
		public static void KNFMCDLCMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6329F80", Offset = "0x6328980", VA = "0x186329F80")]
		public static void HNIIKNJAHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x632A430", Offset = "0x6328E30", VA = "0x18632A430")]
		private static void LDPCNHKPMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x632AD70", Offset = "0x6329770", VA = "0x18632AD70")]
		private static void PPCKCFMKBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63291D0", Offset = "0x6327BD0", VA = "0x1863291D0")]
		[AsyncStateMachine(typeof(KKIHOBIFCJD))]
		private static Task EKKGNNFEDNN(CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63286E0", Offset = "0x63270E0", VA = "0x1863286E0")]
		private static void CCPCEDGNINB(string GIHNHDHICBG, Guid LHJFCKGLOBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class LDJLEJNOENA
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct EHIGKEEOKGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool PPGNMKCJKAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string CCOJMELONMF;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1E56020", Offset = "0x1E54A20", VA = "0x181E56020")]
			public EHIGKEEOKGF(bool PPGNMKCJKAG, string CCOJMELONMF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x632CFC0", Offset = "0x632B9C0", VA = "0x18632CFC0")]
		public static EHIGKEEOKGF OJMFFMAGFPH(NCADCHHGNMM PCIJKBOCLFN)
		{
			return default(EHIGKEEOKGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x632CEC0", Offset = "0x632B8C0", VA = "0x18632CEC0")]
		private static void HNFLOCILBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x632D2D0", Offset = "0x632BCD0", VA = "0x18632D2D0")]
		private static void PHGPKDLLKLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJEOAPHPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x632D760", Offset = "0x632C160", VA = "0x18632D760")]
		public static NCADCHHGNMM KAPJIKPGEOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PPCBEFIBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x632E820", Offset = "0x632D220", VA = "0x18632E820")]
		public static NCADCHHGNMM GPALHHNFCME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x632E940", Offset = "0x632D340", VA = "0x18632E940")]
		public static NCADCHHGNMM IDLHCELPOJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x632E6A0", Offset = "0x632D0A0", VA = "0x18632E6A0")]
		public static NCADCHHGNMM CEALKBBICOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x632E760", Offset = "0x632D160", VA = "0x18632E760")]
		public static NCADCHHGNMM ECABKANPPMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x632E7C0", Offset = "0x632D1C0", VA = "0x18632E7C0")]
		public static NCADCHHGNMM FKIHJBKDLAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x632E880", Offset = "0x632D280", VA = "0x18632E880")]
		public static NCADCHHGNMM HCKENHNIIHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x632E700", Offset = "0x632D100", VA = "0x18632E700")]
		public static NCADCHHGNMM CNIOMKKHGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x632E9A0", Offset = "0x632D3A0", VA = "0x18632E9A0")]
		public static NCADCHHGNMM KECEIFGKALG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x632EA00", Offset = "0x632D400", VA = "0x18632EA00")]
		public static NCADCHHGNMM KGFCAKOLNAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x632E640", Offset = "0x632D040", VA = "0x18632E640")]
		public static NCADCHHGNMM AEELOAKMLGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x632EA60", Offset = "0x632D460", VA = "0x18632EA60")]
		public static NCADCHHGNMM PIKKPGDPALO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x632E8E0", Offset = "0x632D2E0", VA = "0x18632E8E0")]
		public static NCADCHHGNMM HLLIACOPBNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class FAEANKKGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6326D30", Offset = "0x6325730", VA = "0x186326D30")]
		public static NCADCHHGNMM KBHDBEIDKJA(long FNKMOIJJLLC, long PIGKPDHCACB, bool MKACEJFKIIN, string CEJNOCFPOFM, string GPNOKCKBLJA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class HPEHLEMPFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x632BB10", Offset = "0x632A510", VA = "0x18632BB10")]
		public static NCADCHHGNMM NIAJHCHNGOO(string HPKCDFGLPOL, string ABLOENIHIEO, bool HGKGHECMIAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x632B8E0", Offset = "0x632A2E0", VA = "0x18632B8E0")]
		public static NCADCHHGNMM CCMNEIPDPIC(string EIGKPCONJCB, string KDLMHFLAFNO, string PHDBCHOADLP, [Optional] int? CJMCOEKDPNB, [Optional] double[] KJMJNNNHOGM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FCGOLJIBGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6326F10", Offset = "0x6325910", VA = "0x186326F10")]
		public static NCADCHHGNMM AHNMEAPPEJI(string CDNLCNMJJDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63274D0", Offset = "0x6325ED0", VA = "0x1863274D0")]
		public static NCADCHHGNMM MCOLGPCLOLP(string MHKKMFLGALO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63275B0", Offset = "0x6325FB0", VA = "0x1863275B0")]
		public static NCADCHHGNMM OMHMLHEBPAG(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6327260", Offset = "0x6325C60", VA = "0x186327260")]
		public static NCADCHHGNMM DDHGMKEADDD(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63272C0", Offset = "0x6325CC0", VA = "0x1863272C0")]
		public static NCADCHHGNMM FIFLJJOLBBP(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6327470", Offset = "0x6325E70", VA = "0x186327470")]
		public static NCADCHHGNMM HHNPJKDFPBC(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6327320", Offset = "0x6325D20", VA = "0x186327320")]
		public static NCADCHHGNMM GBAKKHOIKLE(string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6327120", Offset = "0x6325B20", VA = "0x186327120")]
		private static NCADCHHGNMM CLAMNPBIMOL(string PJJMBOHKNAL, int DKOHPFNHOFE, string IJPJHDGAPKB, string NLAEPOFBHEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6326FF0", Offset = "0x63259F0", VA = "0x186326FF0")]
		private static NCADCHHGNMM CLAMNPBIMOL(string PJJMBOHKNAL, string IJPJHDGAPKB, string NLAEPOFBHEF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly CMICIECANPG OJMFFMAGFPH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static BDCICANMNGP JFNPAFENPOP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static HELBBFLMJNL OGLHLHGKEFF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<NCADCHHGNMM> AHIPNANAMIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long KOEJAMDLGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63280B0", Offset = "0x6326AB0", VA = "0x1863280B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63281A0", Offset = "0x6326BA0", VA = "0x1863281A0")]
	[KMFBAGPNCPO.KMNJIMBONBM]
	internal static void NCFKHHJLNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6327FF0", Offset = "0x63269F0", VA = "0x186327FF0")]
	private static void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6328290", Offset = "0x6326C90", VA = "0x186328290")]
	public static NCADCHHGNMM NELKJPFOAJE(string BGEIDKDDNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6327B90", Offset = "0x6326590", VA = "0x186327B90")]
	public static NCADCHHGNMM NELKJPFOAJE(string BGEIDKDDNAG, int DKOHPFNHOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6328310", Offset = "0x6326D10", VA = "0x186328310")]
	[KMFBAGPNCPO.KMNJIMBONBM]
	internal static void OBHFKNEGIOG()
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
