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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x624A040", Offset = "0x6248640", VA = "0x18624A040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6249C10", Offset = "0x6248210", VA = "0x186249C10", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x624B640", Offset = "0x6249C40", VA = "0x18624B640", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6249CA0", Offset = "0x62482A0", VA = "0x186249CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
		public NCADCHHGNMM(GCLOCNNEAOO GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6249F60", Offset = "0x6248560", VA = "0x186249F60")]
		public NCADCHHGNMM GOPKJLCFEDI(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33266E0", Offset = "0x3324CE0", VA = "0x1833266E0")]
		public NCADCHHGNMM GOPKJLCFEDI<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3326650", Offset = "0x3324C50", VA = "0x183326650")]
		public NCADCHHGNMM GBKBFGGBLEM<T>(string PKFJNPAMFMB, T? KLABJGGMBGH) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6249ED0", Offset = "0x62484D0", VA = "0x186249ED0")]
		public NCADCHHGNMM GBKBFGGBLEM(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6249EB0", Offset = "0x62484B0", VA = "0x186249EB0")]
		public EOHNLEPDLDE FCOCIKKNLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x209FA80", Offset = "0x209E080", VA = "0x18209FA80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6244530", Offset = "0x6242B30", VA = "0x186244530")]
		private GCLOCNNEAOO(string BGEIDKDDNAG, int DKOHPFNHOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6244410", Offset = "0x6242A10", VA = "0x186244410")]
		public static NCADCHHGNMM GMDNOGMNFLF(string BGEIDKDDNAG, int DKOHPFNHOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62441D0", Offset = "0x62427D0", VA = "0x1862441D0")]
		public EOHNLEPDLDE FCOCIKKNLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62444C0", Offset = "0x6242AC0", VA = "0x1862444C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D28980", Offset = "0x2D26F80", VA = "0x182D28980")]
		internal void CLGFGABNIJP<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6244170", Offset = "0x6242770", VA = "0x186244170")]
		internal void CLGFGABNIJP(string PKFJNPAMFMB, string KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3321050", Offset = "0x331F650", VA = "0x183321050")]
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
		[Cpp2IlInjected.Address(RVA = "0x6241FB0", Offset = "0x62405B0", VA = "0x186241FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6243E90", Offset = "0x6242490", VA = "0x186243E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6243450", Offset = "0x6241A50", VA = "0x186243450")]
		public DHLEFEGPLMK(string PJJMBOHKNAL, Guid ENGGKJCHLBI, long FBCNKAADCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6243080", Offset = "0x6241680", VA = "0x186243080", Slot = "4")]
		public override void GBODEMMMAJE(FKDMKEPDJFN ACMLDNHDHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6243370", Offset = "0x6241970", VA = "0x186243370")]
		public void PIDELBACACA(short DENADLOPLLG, bool AJKPKEEFGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9580", Offset = "0x3CE7B80", VA = "0x183CE9580")]
		public void GJPDFOHOOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x886890", Offset = "0x884E90", VA = "0x180886890")]
		public void FMLNEIPHBPA(string JFAEECJILLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62422A0", Offset = "0x62408A0", VA = "0x1862422A0", Slot = "5")]
		public override void GBEHHPIMKME(bool IHDCBPEHPKN, CFMGCGGOAKM IDBBCPIFEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6241FF0", Offset = "0x62405F0", VA = "0x186241FF0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x624AB00", Offset = "0x6249100", VA = "0x18624AB00")]
		public PILPPJENIBB(long EAOAFMGNILC, int HIHMKCLGBJJ, string BPGGDLCCALD, long FBCNKAADCGD, int DBILGPPNEMM, string CALGPPKAMIA, short DENADLOPLLG, string HPDFELOGCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x624AA80", Offset = "0x6249080", VA = "0x18624AA80")]
		public void JDBEHPGNMKE(int HIHMKCLGBJJ, string HPDFELOGCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x624A950", Offset = "0x6248F50", VA = "0x18624A950", Slot = "5")]
		public override NCADCHHGNMM HOJJNBMPKFO(Guid LHJFCKGLOBG, string EOHMGONFIDB, [Optional] string BPGGDLCCALD, [Optional] long? MIEJCHBJGNK, [Optional] string CALGPPKAMIA, [Optional] string FFJAPDNBDFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DJICBGEMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62434D0", Offset = "0x6241AD0", VA = "0x1862434D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6243540", Offset = "0x6241B40", VA = "0x186243540")]
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
			[Cpp2IlInjected.Address(RVA = "0x624A0C0", Offset = "0x62486C0", VA = "0x18624A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x624A170", Offset = "0x6248770", VA = "0x18624A170")]
		public static void KPMFMFBGFPM(EGMHGNMOHCN LEGMJCLILML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class FPNAJKALNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6243EE0", Offset = "0x62424E0", VA = "0x186243EE0")]
		public static void GHNAMHBKHIL(string LFOBGDLOPID, object AGHEGPHMAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6243F50", Offset = "0x6242550", VA = "0x186243F50")]
		public static void GHNAMHBKHIL(string LFOBGDLOPID, FMCECJDHLGB AGHEGPHMAKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class PLNLKPPDHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x624ADB0", Offset = "0x62493B0", VA = "0x18624ADB0")]
		public static void KAOLJAEIINI(float3 LEELMECKGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x624ABF0", Offset = "0x62491F0", VA = "0x18624ABF0")]
		public static void GLKODGNEMPD(bool OPMDJHBIICE, bool IODDBGMJFNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x624AD10", Offset = "0x6249310", VA = "0x18624AD10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public CEIDGBONJIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x54B2300", Offset = "0x54B0900", VA = "0x1854B2300")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public GHGNFEDGBAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DE9120", Offset = "0x3DE7720", VA = "0x183DE9120")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public MFKDHJGOPBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4690240", Offset = "0x468E840", VA = "0x184690240")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public KDNANLHEBBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4341760", Offset = "0x433FD60", VA = "0x184341760")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DF2DE0", Offset = "0x3DF13E0", VA = "0x183DF2DE0")]
		public GJHGJJLJAKO(Guid LHJFCKGLOBG, string AGPNMOBNOKI, string CALGPPKAMIA, string PEGGDPPLFKC, [Optional] string FFJAPDNBDFJ, [Optional] string CPFDKLOJFKI, [Optional] string DOKJGHGPLGC, [Optional] string ILOFCKCOMPO, [Optional] string EIGDNAIEJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		public void MMLGKALONIL(string FFJAPDNBDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		public void DAEAEDKIDBE(string PEGGDPPLFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x885DC0", Offset = "0x8843C0", VA = "0x180885DC0")]
		public void EIJHIOLJIGM(string EIGDNAIEJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x886880", Offset = "0x884E80", VA = "0x180886880")]
		public void ELCJPAEICKE(string BKCIODBPBOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFEA0", Offset = "0x3DEE4A0", VA = "0x183DEFEA0")]
		public void HLGIEDBBAEN(Guid? LHJFCKGLOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3DED240", Offset = "0x3DEB840", VA = "0x183DED240")]
		public void DCPMLFAMCOK((int, int)? CPDOBPFECII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8868A0", Offset = "0x884EA0", VA = "0x1808868A0")]
		public void GHBLBFKKDIP(string FACGLPPFOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0F20", Offset = "0x3DEF520", VA = "0x183DF0F20")]
		public void LEGLAGGANFN(T MIEJCHBJGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2760", Offset = "0x3DF0D60", VA = "0x183DF2760")]
		public void MGOEONCEFOD(T MIEJCHBJGNK, int KHLKIJNBBPP, float MCPPIEMELEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0180", Offset = "0x3DEE780", VA = "0x183DF0180")]
		public void INEFAPMIPGC(T MIEJCHBJGNK, int KHLKIJNBBPP, string BKJDNDAINKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0A20", Offset = "0x3DEF020", VA = "0x183DF0A20")]
		public void KEBJNLDLBJD(T MIEJCHBJGNK, string KFMPLNGMGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE820", Offset = "0x3DECE20", VA = "0x183DEE820")]
		public EOHNLEPDLDE FCOCIKKNLAM(bool LENLJCDCMCG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DF1D70", Offset = "0x3DF0370", VA = "0x183DF1D70")]
		private (IEnumerable<T>, string) LLNNBFDANBB()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DEF6E0", Offset = "0x3DEDCE0", VA = "0x183DEF6E0")]
		public static NCADCHHGNMM FPJDJKDPOCG(Guid LHJFCKGLOBG, string AGPNMOBNOKI, T MIEJCHBJGNK, string CALGPPKAMIA, string HHNCDBIPKMJ, string FFJAPDNBDFJ, int? HGFDMIDEFHN, [Optional] string DNGCFDJPJOF, [Optional] string KFMPLNGMGOI, [Optional] int? EFBOPOFJFDJ, [Optional] Guid? LOAGDFFPIPL, [Optional] string EIGDNAIEJMM, [Optional] string BPGGDLCCALD, [Optional] (int, int)? CPDOBPFECII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DED120", Offset = "0x3DEB720", VA = "0x183DED120")]
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
			[Cpp2IlInjected.Address(RVA = "0x915190", Offset = "0x913790", VA = "0x180915190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JKBKKOEIPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FA9E0", VA = "0x1808FC3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x436F840", Offset = "0x436DE40", VA = "0x18436F840")]
		public KOFAKDGNDDO(string PJJMBOHKNAL, Guid ENGGKJCHLBI, long FBCNKAADCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GBODEMMMAJE(TListSessionStartParams ACMLDNHDHEF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB0AEA0", Offset = "0xB094A0", VA = "0x180B0AEA0")]
		public void GILGLMOAFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GBEHHPIMKME(bool IHDCBPEHPKN, TListSessionLogParams IDBBCPIFEOI);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x436F5B0", Offset = "0x436DBB0", VA = "0x18436F5B0")]
		public void DJOGLOCAKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x436F410", Offset = "0x436DA10", VA = "0x18436F410")]
		public void BAGEMHPCPJB(long EAOAFMGNILC, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x436F6E0", Offset = "0x436DCE0", VA = "0x18436F6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x120C050", Offset = "0x120A650", VA = "0x18120C050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x120BDD0", Offset = "0x120A3D0", VA = "0x18120BDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6247FF0", Offset = "0x62465F0", VA = "0x186247FF0")]
		public HMNIGLHODBD(long EAOAFMGNILC, int HIHMKCLGBJJ, string BPGGDLCCALD, long FBCNKAADCGD, int DBILGPPNEMM, [Optional] string CALGPPKAMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6247A20", Offset = "0x6246020", VA = "0x186247A20")]
		public void FHJHBDGDOIC(int HIHMKCLGBJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6247A90", Offset = "0x6246090", VA = "0x186247A90")]
		public void GADJNFEGNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6247910", Offset = "0x6245F10", VA = "0x186247910")]
		public void CHDEOMFHAKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6247AE0", Offset = "0x62460E0", VA = "0x186247AE0")]
		private void HKJBPNDDPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6247B40", Offset = "0x6246140", VA = "0x186247B40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HNLJGFGKPFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x62480C0", Offset = "0x62466C0", VA = "0x1862480C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6248500", Offset = "0x6246B00", VA = "0x186248500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x62496E0", Offset = "0x6247CE0", VA = "0x1862496E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x62471B0", Offset = "0x62457B0", VA = "0x1862471B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6247050", Offset = "0x6245650", VA = "0x186247050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? GCENCDDNFFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6246A60", Offset = "0x6245060", VA = "0x186246A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6244D20", Offset = "0x6243320", VA = "0x186244D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? BFEAFFMAKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6247150", Offset = "0x6245750", VA = "0x186247150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6246350", Offset = "0x6244950", VA = "0x186246350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static MODDMLILIKO<bool> KOLLGNHJKHI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x62455D0", Offset = "0x6243BD0", VA = "0x1862455D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool FMBENCGDPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6247200", Offset = "0x6245800", VA = "0x186247200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6246AC0", Offset = "0x62450C0", VA = "0x186246AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool ODCPKCLPAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6245C20", Offset = "0x6244220", VA = "0x186245C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6245B30", Offset = "0x6244130", VA = "0x186245B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float LHKKPFPKCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6247100", Offset = "0x6245700", VA = "0x186247100")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6246A00", Offset = "0x6245000", VA = "0x186246A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6245B90", Offset = "0x6244190", VA = "0x186245B90")]
		public static void FDBPGNFLGND(string GIHNHDHICBG, EGHFNNKKCEP JOFBFEFNFMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6245620", Offset = "0x6243C20", VA = "0x186245620")]
		private static void DNOLBDOPLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6244D80", Offset = "0x6243380", VA = "0x186244D80")]
		internal static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6246850", Offset = "0x6244E50", VA = "0x186246850")]
		internal static void ILGPEBACAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6247250", Offset = "0x6245850", VA = "0x186247250")]
		internal static void NNKCHEEOIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6245D80", Offset = "0x6244380", VA = "0x186245D80")]
		public static Guid GBODEMMMAJE(string GIHNHDHICBG, [Optional] string? NHAAIIBGEEH, [Optional] Dictionary<string, object>? IEHIOJFMCJA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6245CE0", Offset = "0x62442E0", VA = "0x186245CE0")]
		public static Guid GBODEMMMAJE(string GIHNHDHICBG, long NHAAIIBGEEH, [Optional] Dictionary<string, object>? IEHIOJFMCJA)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62463B0", Offset = "0x62449B0", VA = "0x1862463B0")]
		public static void GILGLMOAFKB(string GIHNHDHICBG, [Optional] Guid? GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62453C0", Offset = "0x62439C0", VA = "0x1862453C0")]
		public static void CGMONNOKJCC(string GIHNHDHICBG, string HLFMMAJIGEG, object APCDCFKEBFP, bool BBMCHKKKMFM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6246610", Offset = "0x6244C10", VA = "0x186246610")]
		public static bool GKMBGDAIDME(string GIHNHDHICBG, [Optional] string? NHAAIIBGEEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6246B20", Offset = "0x6245120", VA = "0x186246B20")]
		private static void KLBAHJPMGGI(bool JJLBNGBLPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6247470", Offset = "0x6245A70", VA = "0x186247470")]
		internal static void OEDDOGLNFMF(string EIGKPCONJCB, string LFOBGDLOPID, object JGCMECODHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62472F0", Offset = "0x62458F0", VA = "0x1862472F0")]
		internal static void OEDDOGLNFMF(string EIGKPCONJCB, Dictionary<string, object> GMHOCNFEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6245C70", Offset = "0x6244270", VA = "0x186245C70")]
		private static void FNICIFOMKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6246C60", Offset = "0x6245260", VA = "0x186246C60")]
		public static void KNFMCDLCMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6246800", Offset = "0x6244E00", VA = "0x186246800")]
		public static void HNIIKNJAHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6246CB0", Offset = "0x62452B0", VA = "0x186246CB0")]
		private static void LDPCNHKPMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62475F0", Offset = "0x6245BF0", VA = "0x1862475F0")]
		private static void PPCKCFMKBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6245A50", Offset = "0x6244050", VA = "0x186245A50")]
		[AsyncStateMachine(typeof(KKIHOBIFCJD))]
		private static Task EKKGNNFEDNN(CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6244F60", Offset = "0x6243560", VA = "0x186244F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D19970", Offset = "0x1D17F70", VA = "0x181D19970")]
			public EHIGKEEOKGF(bool PPGNMKCJKAG, string CCOJMELONMF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6249840", Offset = "0x6247E40", VA = "0x186249840")]
		public static EHIGKEEOKGF OJMFFMAGFPH(NCADCHHGNMM PCIJKBOCLFN)
		{
			return default(EHIGKEEOKGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6249740", Offset = "0x6247D40", VA = "0x186249740")]
		private static void HNFLOCILBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6249B50", Offset = "0x6248150", VA = "0x186249B50")]
		private static void PHGPKDLLKLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJEOAPHPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6249FE0", Offset = "0x62485E0", VA = "0x186249FE0")]
		public static NCADCHHGNMM KAPJIKPGEOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PPCBEFIBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x624B0A0", Offset = "0x62496A0", VA = "0x18624B0A0")]
		public static NCADCHHGNMM GPALHHNFCME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x624B1C0", Offset = "0x62497C0", VA = "0x18624B1C0")]
		public static NCADCHHGNMM IDLHCELPOJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x624AF20", Offset = "0x6249520", VA = "0x18624AF20")]
		public static NCADCHHGNMM CEALKBBICOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x624AFE0", Offset = "0x62495E0", VA = "0x18624AFE0")]
		public static NCADCHHGNMM ECABKANPPMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x624B040", Offset = "0x6249640", VA = "0x18624B040")]
		public static NCADCHHGNMM FKIHJBKDLAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x624B100", Offset = "0x6249700", VA = "0x18624B100")]
		public static NCADCHHGNMM HCKENHNIIHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x624AF80", Offset = "0x6249580", VA = "0x18624AF80")]
		public static NCADCHHGNMM CNIOMKKHGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x624B220", Offset = "0x6249820", VA = "0x18624B220")]
		public static NCADCHHGNMM KECEIFGKALG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x624B280", Offset = "0x6249880", VA = "0x18624B280")]
		public static NCADCHHGNMM KGFCAKOLNAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x624AEC0", Offset = "0x62494C0", VA = "0x18624AEC0")]
		public static NCADCHHGNMM AEELOAKMLGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x624B2E0", Offset = "0x62498E0", VA = "0x18624B2E0")]
		public static NCADCHHGNMM PIKKPGDPALO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x624B160", Offset = "0x6249760", VA = "0x18624B160")]
		public static NCADCHHGNMM HLLIACOPBNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class FAEANKKGDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62435B0", Offset = "0x6241BB0", VA = "0x1862435B0")]
		public static NCADCHHGNMM KBHDBEIDKJA(long FNKMOIJJLLC, long PIGKPDHCACB, bool MKACEJFKIIN, string CEJNOCFPOFM, string GPNOKCKBLJA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class HPEHLEMPFOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6248390", Offset = "0x6246990", VA = "0x186248390")]
		public static NCADCHHGNMM NIAJHCHNGOO(string HPKCDFGLPOL, string ABLOENIHIEO, bool HGKGHECMIAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6248160", Offset = "0x6246760", VA = "0x186248160")]
		public static NCADCHHGNMM CCMNEIPDPIC(string EIGKPCONJCB, string KDLMHFLAFNO, string PHDBCHOADLP, [Optional] int? CJMCOEKDPNB, [Optional] double[] KJMJNNNHOGM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FCGOLJIBGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6243790", Offset = "0x6241D90", VA = "0x186243790")]
		public static NCADCHHGNMM AHNMEAPPEJI(string CDNLCNMJJDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6243D50", Offset = "0x6242350", VA = "0x186243D50")]
		public static NCADCHHGNMM MCOLGPCLOLP(string MHKKMFLGALO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6243E30", Offset = "0x6242430", VA = "0x186243E30")]
		public static NCADCHHGNMM OMHMLHEBPAG(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6243AE0", Offset = "0x62420E0", VA = "0x186243AE0")]
		public static NCADCHHGNMM DDHGMKEADDD(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6243B40", Offset = "0x6242140", VA = "0x186243B40")]
		public static NCADCHHGNMM FIFLJJOLBBP(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6243CF0", Offset = "0x62422F0", VA = "0x186243CF0")]
		public static NCADCHHGNMM HHNPJKDFPBC(int DKOHPFNHOFE, string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6243BA0", Offset = "0x62421A0", VA = "0x186243BA0")]
		public static NCADCHHGNMM GBAKKHOIKLE(string KJPHMNNIMDP, string MCAKFNPAKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62439A0", Offset = "0x6241FA0", VA = "0x1862439A0")]
		private static NCADCHHGNMM CLAMNPBIMOL(string PJJMBOHKNAL, int DKOHPFNHOFE, string IJPJHDGAPKB, string NLAEPOFBHEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6243870", Offset = "0x6241E70", VA = "0x186243870")]
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
		[Cpp2IlInjected.Address(RVA = "0x6244930", Offset = "0x6242F30", VA = "0x186244930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6244A20", Offset = "0x6243020", VA = "0x186244A20")]
	[KMFBAGPNCPO.KMNJIMBONBM]
	internal static void NCFKHHJLNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6244870", Offset = "0x6242E70", VA = "0x186244870")]
	private static void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6244B10", Offset = "0x6243110", VA = "0x186244B10")]
	public static NCADCHHGNMM NELKJPFOAJE(string BGEIDKDDNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6244410", Offset = "0x6242A10", VA = "0x186244410")]
	public static NCADCHHGNMM NELKJPFOAJE(string BGEIDKDDNAG, int DKOHPFNHOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6244B90", Offset = "0x6243190", VA = "0x186244B90")]
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
