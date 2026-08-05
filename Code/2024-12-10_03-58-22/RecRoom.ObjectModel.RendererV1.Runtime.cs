using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5EA0", Offset = "0x6DC4AA0", VA = "0x186DC5EA0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x17502F0", Offset = "0x174EEF0", VA = "0x1817502F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBED0", Offset = "0x6DCAAD0", VA = "0x186DCBED0")]
		private void MNIOJKDAHNG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC360", Offset = "0x6DCAF60", VA = "0x186DCC360", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC3C0", Offset = "0x6DCAFC0", VA = "0x186DCC3C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class APMGGIJEJDK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE330", Offset = "0x6DACF30", VA = "0x186DAE330")]
	public static Quaternion POLPOLJOLFH([In] this HGDMNGFMHBN FOHKBJHIPEI, [In] Vector3 EJOHIEANBFL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FPKFCEAKHMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1AB0", Offset = "0x6DB06B0", VA = "0x186DB1AB0")]
	public static bool GFJLLLBGCHB(this GJGOCLGMFFN HICFJNJABJI, BBKOFHLHEBG JEFLNAOAGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB28C0", Offset = "0x6DB14C0", VA = "0x186DB28C0")]
	public static bool KDFPLFPHEHH(this GJGOCLGMFFN HICFJNJABJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2920", Offset = "0x6DB1520", VA = "0x186DB2920")]
	public static bool LNOLFGHCHLJ(this GJGOCLGMFFN HICFJNJABJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB32A0", Offset = "0x6DB1EA0", VA = "0x186DB32A0")]
	public static void NEJPMLDFMII(this GJGOCLGMFFN HICFJNJABJI, Vector3 PLCJDNFJGLB, Quaternion LKNEMKELHJF, float JLDCCBFCJGC, bool AKIKHGAEOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1D10", Offset = "0x6DB0910", VA = "0x186DB1D10")]
	public static void IHOAPHIIGDP(this GJGOCLGMFFN HICFJNJABJI, Vector3 PLCJDNFJGLB, Quaternion LKNEMKELHJF, float JLDCCBFCJGC, int LJMIEFBOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1650", Offset = "0x6DB0250", VA = "0x186DB1650")]
	public static void CHIDIODGHNN(this GJGOCLGMFFN HICFJNJABJI, int LJMIEFBOFFI, Vector3 PLCJDNFJGLB, Quaternion LKNEMKELHJF, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1770", Offset = "0x6DB0370", VA = "0x186DB1770")]
	public static void COJPPMOHKDL(this GJGOCLGMFFN HICFJNJABJI, Vector3 ODEKMILCJLH, Quaternion DLOEMGCMNEL, float JLDCCBFCJGC, bool AKIKHGAEOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2950", Offset = "0x6DB1550", VA = "0x186DB2950")]
	private static void MKCKLHBHBFL(this GJGOCLGMFFN HICFJNJABJI, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC, bool AKIKHGAEOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1F90", Offset = "0x6DB0B90", VA = "0x186DB1F90")]
	private static void IOHOACBAEJH(this GJGOCLGMFFN HICFJNJABJI, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ, float PIHIGAFBELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DB18D0", Offset = "0x6DB04D0", VA = "0x186DB18D0")]
	private static void EPNNFLIAKOG(this GJGOCLGMFFN HICFJNJABJI, int MFJLAMOCOBC, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ, float PIHIGAFBELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DB28F0", Offset = "0x6DB14F0", VA = "0x186DB28F0")]
	private static bool KKJCLOCFFGI(this GJGOCLGMFFN HICFJNJABJI, int MFJLAMOCOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2140", Offset = "0x6DB0D40", VA = "0x186DB2140")]
	private static void JANCGNEEFBO(this GJGOCLGMFFN HICFJNJABJI, int MFJLAMOCOBC, Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ, float PIHIGAFBELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DB23D0", Offset = "0x6DB0FD0", VA = "0x186DB23D0")]
	public static Vector3 JLPKDLCIALO(this GJGOCLGMFFN HICFJNJABJI, int MFJLAMOCOBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DB17C0", Offset = "0x6DB03C0", VA = "0x186DB17C0")]
	public static Quaternion CPHDCDLAPCI(this GJGOCLGMFFN HICFJNJABJI, int MFJLAMOCOBC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1AF0", Offset = "0x6DB06F0", VA = "0x186DB1AF0")]
	public static Vector3 HKPPABPOBNB(BBKOFHLHEBG KCDIMIFJDPI, Vector3 GKJAMFFKDLE, Vector3? NBLOOCANDCC, Vector3 NNIGFGMJEKD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface GCKHDOOOOAG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCCCLLICJGI(EntityQuery PBBNDNDLPAF, EntityManager DPCAAACILIP, INOJLNLAEOL PIAKONPJLMJ, LKOKMLACDBN GLDBJDDPLPF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface CIODBGBFGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType OLCHBBHKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJJKLIOJNNI(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBBIDDIHDFB(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEDNKDKLOJD(IFIADOEPHCD BOINMGKPKBC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OEHBMPLKOPI : GCKHDOOOOAG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC76F0", Offset = "0x6DC62F0", VA = "0x186DC76F0", Slot = "4")]
	public void KCCCLLICJGI(EntityQuery PBBNDNDLPAF, EntityManager DPCAAACILIP, INOJLNLAEOL PIAKONPJLMJ, LKOKMLACDBN GLDBJDDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OEHBMPLKOPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class IJLIPLOGFOM : GCKHDOOOOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ODMGODNGJGC MBHJGKJJEMC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
	public IJLIPLOGFOM(ODMGODNGJGC MBHJGKJJEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2450", Offset = "0x6DC1050", VA = "0x186DC2450", Slot = "4")]
	public void KCCCLLICJGI(EntityQuery PBBNDNDLPAF, EntityManager DPCAAACILIP, INOJLNLAEOL PIAKONPJLMJ, LKOKMLACDBN GLDBJDDPLPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class GENGIDEDKCB : GCKHDOOOOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4F30", Offset = "0x6DB3B30", VA = "0x186DB4F30", Slot = "4")]
	public void KCCCLLICJGI(EntityQuery PBBNDNDLPAF, EntityManager DPCAAACILIP, INOJLNLAEOL PIAKONPJLMJ, LKOKMLACDBN GLDBJDDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public GENGIDEDKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GOAEPNHOGDE : CIODBGBFGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType OLCHBBHKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DB6CF0", Offset = "0x6DB58F0", VA = "0x186DB6CF0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6A70", Offset = "0x6DB5670", VA = "0x186DB6A70", Slot = "5")]
	public void FJJKLIOJNNI(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DB67A0", Offset = "0x6DB53A0", VA = "0x186DB67A0", Slot = "6")]
	public void DBBIDDIHDFB(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6A20", Offset = "0x6DB5620", VA = "0x186DB6A20", Slot = "7")]
	public void EEDNKDKLOJD(IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public GOAEPNHOGDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HFGFDAEIIDJ : CIODBGBFGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType OLCHBBHKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DBBCD0", Offset = "0x6DBA8D0", VA = "0x186DBBCD0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBA50", Offset = "0x6DBA650", VA = "0x186DBBA50", Slot = "5")]
	public void FJJKLIOJNNI(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB780", Offset = "0x6DBA380", VA = "0x186DBB780", Slot = "6")]
	public void DBBIDDIHDFB(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBA00", Offset = "0x6DBA600", VA = "0x186DBBA00", Slot = "7")]
	public void EEDNKDKLOJD(IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HFGFDAEIIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IKHGALEIMLE : CIODBGBFGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType OLCHBBHKMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2BF0", Offset = "0x6DC17F0", VA = "0x186DC2BF0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2970", Offset = "0x6DC1570", VA = "0x186DC2970", Slot = "5")]
	public void FJJKLIOJNNI(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DC26A0", Offset = "0x6DC12A0", VA = "0x186DC26A0", Slot = "6")]
	public void DBBIDDIHDFB(EntityQuery PBBNDNDLPAF, IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2920", Offset = "0x6DC1520", VA = "0x186DC2920", Slot = "7")]
	public void EEDNKDKLOJD(IFIADOEPHCD BOINMGKPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public IKHGALEIMLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class MGFPDCIHLPK : GBBIAOIACBC, PFAELLKIJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private INOJLNLAEOL PIAKONPJLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PKKJIOEKPJA FJJEBFCKDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LKOKMLACDBN GLDBJDDPLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, GCKHDOOOOAG adapter)> NJPFIPLAOAL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6390", Offset = "0x6DC4F90", VA = "0x186DC6390", Slot = "15")]
	public virtual void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6420", Offset = "0x6DC5020", VA = "0x186DC6420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6220", Offset = "0x6DC4E20", VA = "0x186DC6220")]
	private void DJKLABMPKIJ(EntityQueryDesc FKBNFPNPPFB, GCKHDOOOOAG HOFANJGEPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6650", Offset = "0x6DC5250", VA = "0x186DC6650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public MGFPDCIHLPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class GDAJNBKMMBJ : GBBIAOIACBC, PFAELLKIJHO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class OMLODEIPAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery GGMOHPFFHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery BJLJPEDJOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery APLPJJAEDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery IDAAPFKNGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery PENNAHEEFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public CIODBGBFGGI AMFGFEIJIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ComponentType ONMCBDPFKFO;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public OMLODEIPAFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private INOJLNLAEOL PIAKONPJLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LKOKMLACDBN GLDBJDDPLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PKKJIOEKPJA FJJEBFCKDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<OMLODEIPAFL> NJPFIPLAOAL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB45C0", Offset = "0x6DB31C0", VA = "0x186DB45C0", Slot = "14")]
	public void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB47D0", Offset = "0x6DB33D0", VA = "0x186DB47D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4650", Offset = "0x6DB3250", VA = "0x186DB4650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4960", Offset = "0x6DB3560", VA = "0x186DB4960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4B70", Offset = "0x6DB3770", VA = "0x186DB4B70")]
	private void PFGPOCIAKCJ(OMLODEIPAFL HGOPBGFEGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4010", Offset = "0x6DB2C10", VA = "0x186DB4010")]
	private void DJKLABMPKIJ(CIODBGBFGGI AMFGFEIJIDD, ComponentType IPPCGOOLFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public GDAJNBKMMBJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct HHNOFPIKKFF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct HHEFBIIGNKB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct HKKOPFKODJP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(PIFCONMIKHN), new string[] { })]
public class HLALCGAOFOJ : PIFCONMIKHN, LCGGPACKJOJ, EIHOCFDABND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[DependsOn]
	private BIOJOMCAEIE CHCPMCFMNCL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2260", Offset = "0x6DC0E60", VA = "0x186DC2260", Slot = "4")]
	public bool BMANOAIJPCE(JBKDGFJKCIL DKAIINNEBFL, CHKJBCCKFLA CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2340", Offset = "0x6DC0F40", VA = "0x186DC2340", Slot = "5")]
	private void GGEGDPIKPLN(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xAE9C20", Offset = "0xAE8820", VA = "0x180AE9C20", Slot = "6")]
	private void AEHPABPDHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HLALCGAOFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(LKOKMLACDBN), new string[] { })]
public class OOMEOANCJFM : LKOKMLACDBN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BLNKBACJIBE DEBNNMIFCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BLNKBACJIBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OOMEOANCJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(JINHOAOOCBB), new string[] { })]
public class JFOAJKIIPND : JINHOAOOCBB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2DC0", Offset = "0x6DC19C0", VA = "0x186DC2DC0", Slot = "4")]
	public void DDCAAHNBDBC(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2E40", Offset = "0x6DC1A40", VA = "0x186DC2E40", Slot = "5")]
	public void GGPMFKLDANC(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2D10", Offset = "0x6DC1910", VA = "0x186DC2D10", Slot = "6")]
	public ComponentSystemBase CBAMIKKNEMD(World CHCPMCFMNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2EF0", Offset = "0x6DC1AF0", VA = "0x186DC2EF0", Slot = "7")]
	public void JJMOELMMFHM(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2D60", Offset = "0x6DC1960", VA = "0x186DC2D60", Slot = "8")]
	public void CBGMOIKMPDO(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2E90", Offset = "0x6DC1A90", VA = "0x186DC2E90", Slot = "9")]
	public void HDCJDKGJJKO(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2F50", Offset = "0x6DC1B50", VA = "0x186DC2F50", Slot = "10")]
	public void LKEBGELEEJC(World CHCPMCFMNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public JFOAJKIIPND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DNPNPGJLOBH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public HOIMHHIKEDC BHENDMEMCJC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static DNPNPGJLOBH FGDKAMMLLCN(HOIMHHIKEDC JBFBMCPGKHE)
	{
		return default(DNPNPGJLOBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JLBLHFIDAIN : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PLEFNFBHPPD JBCMOLBIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3580", Offset = "0x6DC2180", VA = "0x186DC3580", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public JLBLHFIDAIN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KMBOEDKADMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JFPOCDBINJH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FIFKKIMGIBH CGBGGKOCDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3060", Offset = "0x6DC1C60", VA = "0x186DC3060", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2FF0", Offset = "0x6DC1BF0", VA = "0x186DC2FF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public JFPOCDBINJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GFKAJFOLONN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public KFAONOJCCPI PKNKKIBEMGG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static GFKAJFOLONN FGDKAMMLLCN(KFAONOJCCPI JBFBMCPGKHE)
	{
		return default(GFKAJFOLONN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OEDFLCJCONB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public HOIMHHIKEDC BHENDMEMCJC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static OEDFLCJCONB FGDKAMMLLCN(HOIMHHIKEDC JBFBMCPGKHE)
	{
		return default(OEDFLCJCONB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ICJJEOIBDEJ : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GHIENMFCFMM OLNBPKBLKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2400", Offset = "0x6DC1000", VA = "0x186DC2400", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2390", Offset = "0x6DC0F90", VA = "0x186DC2390", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public ICJJEOIBDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class INFCCNHBNCO : AJKJOPPIPIO, FIFKKIMGIBH, ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PKDHLEFJHBK CGAFNLJEBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC3A1B0", Offset = "0xC38DB0", VA = "0x180C3A1B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(PKDHLEFJHBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AKDHOELJHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x10605F0", Offset = "0x105F1F0", VA = "0x1810605F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 IMFJPMCCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA62200", Offset = "0xA60E00", VA = "0x180A62200", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2C70", Offset = "0x6DC1870", VA = "0x186DC2C70")]
	public INFCCNHBNCO(UniformTRS JCBHPFOKECA, BDGGMOHGNEL CDBGCEIGNJC, float JCPIPHBCGIA, float3 DJPMHCGJNKL, JJGANJGEFFL GNBIKNFLGKC, OICBHJLAMDI AFAMNECOPMO, PKDHLEFJHBK GAABCMMGDNL, float3 IPEJKCDEJFF, bool PCIEJNKEHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2C20", Offset = "0x6DC1820", VA = "0x186DC2C20", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LJJOFJPLGPB : AJKJOPPIPIO, GHIENMFCFMM, ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<BKCAPMPDKDN> OJOENCCADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AIHJMCNHHGH HHLMDDDPFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly float HABKJMMEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int CDIOKHCGPPO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BIJMFHIJOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5130", Offset = "0x6DC3D30", VA = "0x186DC5130", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JDPMNKFIINO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5150", Offset = "0x6DC3D50", VA = "0x186DC5150", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KPOGMLDNHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC5140", Offset = "0x6DC3D40", VA = "0x186DC5140", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int APEENCGEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB6DC10", Offset = "0xB6C810", VA = "0x180B6DC10", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MMFHCNJPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA629C0", Offset = "0xA615C0", VA = "0x180A629C0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CEABBFHIPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x920430", Offset = "0x91F030", VA = "0x180920430", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5080", Offset = "0x6DC3C80", VA = "0x186DC5080")]
	public LJJOFJPLGPB(UniformTRS JCBHPFOKECA, BDGGMOHGNEL CDBGCEIGNJC, float JCPIPHBCGIA, float3 DJPMHCGJNKL, JJGANJGEFFL GNBIKNFLGKC, OICBHJLAMDI AFAMNECOPMO, AIHJMCNHHGH HHLMDDDPFNI, float HABKJMMEMDN, int CDIOKHCGPPO, NativeArray<BKCAPMPDKDN> OJOENCCADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA7C300", Offset = "0xA7AF00", VA = "0x180A7C300", Slot = "33")]
	public NativeArray<BKCAPMPDKDN> GetNativeCurvePoints()
	{
		return default(NativeArray<BKCAPMPDKDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4FC0", Offset = "0x6DC3BC0", VA = "0x186DC4FC0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GGFMINPNJMF : FPMAPBNJKPJ, PLEFNFBHPPD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject NAMJKICKFDN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6DB5290", Offset = "0x6DB3E90", VA = "0x186DB5290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FJFKEFAPLLG DJCNFDBJOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6DB5320", Offset = "0x6DB3F20", VA = "0x186DB5320", Slot = "15")]
		get
		{
			return default(FJFKEFAPLLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EPEJAJNGNFC GGCJHBMDIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "16")]
		get
		{
			return default(EPEJAJNGNFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5420", Offset = "0x6DB4020", VA = "0x186DB5420")]
	public GGFMINPNJMF(JBKDGFJKCIL DKAIINNEBFL, bool NCMFMPGPHLH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DB50F0", Offset = "0x6DB3CF0", VA = "0x186DB50F0")]
	public void CEPADAGMGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5320", Offset = "0x6DB3F20", VA = "0x186DB5320")]
	protected FJFKEFAPLLG NFNAAPAAGBN()
	{
		return default(FJFKEFAPLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5260", Offset = "0x6DB3E60", VA = "0x186DB5260", Slot = "17")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GNKDKONKMDJ : NJCHHOODKNB, FIFKKIMGIBH, ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Dictionary<FLDGGDEOLHM, PKDHLEFJHBK> IMHMKKCNNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PKDHLEFJHBK GAABCMMGDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool PCIEJNKEHLN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private PKDHLEFJHBK CGLPELFONLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6460", Offset = "0x8A5060", VA = "0x1808A6460", Slot = "28")]
		get
		{
			return default(PKDHLEFJHBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool MIPNHGIHKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1251640", Offset = "0x1250240", VA = "0x181251640", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 IMFJPMCCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB66D0", Offset = "0x6DB52D0", VA = "0x186DB66D0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6690", Offset = "0x6DB5290", VA = "0x186DB6690")]
	public GNKDKONKMDJ(JBKDGFJKCIL IGNNJCLPPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6010", Offset = "0x6DB4C10", VA = "0x186DB6010", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB6060", Offset = "0x6DB4C60", VA = "0x186DB6060", Slot = "26")]
	public override void HMDNBLCBPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LFCOECAGFOI : NJCHHOODKNB, GHIENMFCFMM, ALJHPAAKHOE, IDisposable, CHOMKALJNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<BKCAPMPDKDN> OJOENCCADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool ALEEADNGIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool CPLFCJHCKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float HABKJMMEMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int CDIOKHCGPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private bool FNCNMFGLKJK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JBFJMJGFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8F4160", Offset = "0x8F2D60", VA = "0x1808F4160", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PAIFOJIPKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B00", Offset = "0x8D2700", VA = "0x1808D3B00", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float HDOPBDAEALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20FA0", VA = "0x180A223A0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int CNNNDGJLHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC3A1B0", Offset = "0xC38DB0", VA = "0x180C3A1B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool HKOPHOGEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x10605F0", Offset = "0x105F1F0", VA = "0x1810605F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int AEBCBIDDAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4DD0", Offset = "0x6DC39D0", VA = "0x186DC4DD0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BPADMPEODIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6DC49D0", Offset = "0x6DC35D0", VA = "0x186DC49D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4F70", Offset = "0x6DC3B70", VA = "0x186DC4F70")]
	public LFCOECAGFOI(JBKDGFJKCIL IGNNJCLPPOC, [Optional] NativeList<BKCAPMPDKDN> OJOENCCADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4CF0", Offset = "0x6DC38F0", VA = "0x186DC4CF0", Slot = "26")]
	public override void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DC46F0", Offset = "0x6DC32F0", VA = "0x186DC46F0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DC47E0", Offset = "0x6DC33E0", VA = "0x186DC47E0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4AC0", Offset = "0x6DC36C0", VA = "0x186DC4AC0")]
	public void GCCBMLIAHME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4B20", Offset = "0x6DC3720", VA = "0x186DC4B20", Slot = "34")]
	public NativeArray<BKCAPMPDKDN> GetNativeCurvePoints()
	{
		return default(NativeArray<BKCAPMPDKDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4DF0", Offset = "0x6DC39F0", VA = "0x186DC4DF0", Slot = "35")]
	private Vector3 LKILGGJEPPF(int MCPGGPJAKIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4F40", Offset = "0x6DC3B40", VA = "0x186DC4F40", Slot = "36")]
	private Quaternion PPIEIPLBGME(int MCPGGPJAKIM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4840", Offset = "0x6DC3440", VA = "0x186DC4840", Slot = "37")]
	private float EMIOLKLMIFM(int MCPGGPJAKIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4680", Offset = "0x6DC3280", VA = "0x186DC4680")]
	private NativeArray<Entity> AMMCBMHEFGD()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class EDKJKBNMJJM : BNBKEOHPNEE
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1240", Offset = "0x6DAFE40", VA = "0x186DB1240", Slot = "15")]
	protected override ComponentSystemBase PHCMJAKBKEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1230", Offset = "0x6DAFE30", VA = "0x186DB1230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6DB15E0", Offset = "0x6DB01E0", VA = "0x186DB15E0")]
	public EDKJKBNMJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LPLPCBFDCKF]
public sealed class LNNABKGEADL : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EntityQuery GGMOHPFFHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EntityQuery EIOOOFMPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EntityQuery NACKEECMPDN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5810", Offset = "0x6DC4410", VA = "0x186DC5810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5A10", Offset = "0x6DC4610", VA = "0x186DC5A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6DC55F0", Offset = "0x6DC41F0", VA = "0x186DC55F0")]
	private void OOMHFGBIOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5160", Offset = "0x6DC3D60", VA = "0x186DC5160")]
	private void BJJFDBMGGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5370", Offset = "0x6DC3F70", VA = "0x186DC5370")]
	private void BJLLMGENEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5500", Offset = "0x6DC4100", VA = "0x186DC5500")]
	private NativeList<Entity> OBHFCDGIBDA(NativeArray<Entity> BHNJCFOPBNC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC54A0", Offset = "0x6DC40A0", VA = "0x186DC54A0")]
	private NativeList<Entity> LBKPGBOKIBI(NativeArray<Entity> BHNJCFOPBNC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5560", Offset = "0x6DC4160", VA = "0x186DC5560")]
	private void OCONNAFPBJP(NativeArray<Entity> BHNJCFOPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public LNNABKGEADL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[LPLPCBFDCKF]
public sealed class HHKHCBPMDLB : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EntityQuery FIOGFMNGLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery AEDMMBICLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery APLPJJAEDPC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD0D0", Offset = "0x6DBBCD0", VA = "0x186DBD0D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD2C0", Offset = "0x6DBBEC0", VA = "0x186DBD2C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBD00", Offset = "0x6DBA900", VA = "0x186DBBD00")]
	private void BCEBKNJNHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC8E0", Offset = "0x6DBB4E0", VA = "0x186DBC8E0")]
	private void LNFJFJCCHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC4F0", Offset = "0x6DBB0F0", VA = "0x186DBC4F0")]
	private void BFFCJBOMGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public HHKHCBPMDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LPLPCBFDCKF]
public sealed class PBKKGPFEMJM : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery GNILKEKEAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery EADJFNOKOCP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7F60", Offset = "0x6DC6B60", VA = "0x186DC7F60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6DC80B0", Offset = "0x6DC6CB0", VA = "0x186DC80B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7940", Offset = "0x6DC6540", VA = "0x186DC7940")]
	private void BCEBKNJNHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7C50", Offset = "0x6DC6850", VA = "0x186DC7C50")]
	private void LNFJFJCCHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public PBKKGPFEMJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BAANNPIJFAA : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	private struct GMMPFJGDANI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EntityQueryInJob KMNMGHDCBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EntityQueryInJob DCKHKHIOPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public EntityTypeHandle FDHCGHDMMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ReadOnly]
		public ComponentTypeHandle<OEDFLCJCONB> FGGBILIEKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeParallelHashSet<HOIMHHIKEDC> CGPKEMBDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeList<Entity> PPFJIIALENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> BJHOAJLEEHB;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6DB5EE0", Offset = "0x6DB4AE0", VA = "0x186DB5EE0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB5F30", Offset = "0x6DB4B30", VA = "0x186DB5F30")]
		private void IJGJIGMPPME(EntityQueryInJob PBBNDNDLPAF, [Optional] NativeList<Entity> HHEGBIDLHCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private struct HJOFJNOJNGP : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[ReadOnly]
		public EntityTypeHandle FDHCGHDMMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[ReadOnly]
		public ComponentTypeHandle<OEDFLCJCONB> FGGBILIEKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeParallelHashSet<HOIMHHIKEDC> CGPKEMBDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeList<Entity> HHEGBIDLHCB;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC2010", Offset = "0x6DC0C10", VA = "0x186DC2010", Slot = "4")]
		public void Execute(ArchetypeChunk NAOKEIMJCDG, int CPFDOPIPNMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct DJDCMBKPOGF : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public EntityTypeHandle FDHCGHDMMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> HFIEBMDADFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ReadOnly]
		public ComponentTypeHandle<GFKAJFOLONN> IHBCAMDNDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ReadOnly]
		public ComponentDataFromEntity<DNPNPGJLOBH> NOHHECICBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ComponentTypeHandle<OEDFLCJCONB> IIKAGBMDCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeParallelHashSet<HOIMHHIKEDC> CGPKEMBDAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeList<Entity> MPMFEJDHMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeList<GFKAJFOLONN> CHIJHHCPAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeList<HOIMHHIKEDC> CCLCCKKMKGK;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0A30", Offset = "0x6DAF630", VA = "0x186DB0A30", Slot = "4")]
		public void Execute(ArchetypeChunk NAOKEIMJCDG, int CPFDOPIPNMB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery KMNMGHDCBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery DCKHKHIOPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery GAPAAHBCGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEED0", Offset = "0x6DADAD0", VA = "0x186DAEED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF160", Offset = "0x6DADD60", VA = "0x186DAF160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE750", Offset = "0x6DAD350", VA = "0x186DAE750")]
	private void FPGFCADLMND(NativeParallelHashSet<HOIMHHIKEDC> CGPKEMBDAKN, int FEPLNAIMNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE410", Offset = "0x6DAD010", VA = "0x186DAE410")]
	private void BOPMDFKCFPJ(NativeParallelHashSet<HOIMHHIKEDC> CGPKEMBDAKN, int FOACPDJKLGJ, int EJOACKKGPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public BAANNPIJFAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ODJBLPPNNKL : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EntityQuery PBBNDNDLPAF;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7150", Offset = "0x6DC5D50", VA = "0x186DC7150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7200", Offset = "0x6DC5E00", VA = "0x186DC7200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public ODJBLPPNNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LPLPCBFDCKF]
internal class KNMPIJKPIOL : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class EJLFFDLAJMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EntityQuery LELGMCDEJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EntityQuery BADHECCLPCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LMKBPDNGJBO CKBALICMNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ComponentType NHGABGPFHFC;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EJLFFDLAJMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private delegate void LMKBPDNGJBO(NativeArray<KFAONOJCCPI> JBFBMCPGKHE, IFIADOEPHCD BOINMGKPKBC);

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<EJLFFDLAJMI> NJPFIPLAOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PKKJIOEKPJA FJJEBFCKDED;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3ED0", Offset = "0x6DC2AD0", VA = "0x186DC3ED0", Slot = "15")]
	public override void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3F70", Offset = "0x6DC2B70", VA = "0x186DC3F70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4100", Offset = "0x6DC2D00", VA = "0x186DC4100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2ECC8F0", Offset = "0x2ECB4F0", VA = "0x182ECC8F0")]
	private void DJKLABMPKIJ<T>(LMKBPDNGJBO CKBALICMNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DC39F0", Offset = "0x6DC25F0", VA = "0x186DC39F0")]
	private static void FMIEHJOBEDG(NativeArray<KFAONOJCCPI> BKJFMIDIDBM, IFIADOEPHCD JNLOJCKEFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3D30", Offset = "0x6DC2930", VA = "0x186DC3D30")]
	private static void IDOEIJILBDJ(NativeArray<KFAONOJCCPI> BKJFMIDIDBM, IFIADOEPHCD JNLOJCKEFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3B90", Offset = "0x6DC2790", VA = "0x186DC3B90")]
	private static void HIOOLKNBDEM(NativeArray<KFAONOJCCPI> BKJFMIDIDBM, IFIADOEPHCD JNLOJCKEFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public KNMPIJKPIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LPLPCBFDCKF]
public sealed class DJDOCPDHNIH : JHOFCDCEFIB
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EntityQuery PBBNDNDLPAF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0D60", Offset = "0x6DAF960", VA = "0x186DB0D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OBPKNBEFOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public UniformTRS JCBHPFOKECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public StandardRenderableVisualData CKKCIGFGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public PKDHLEFJHBK GAABCMMGDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 IPEJKCDEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool PCIEJNKEHLN;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DBPNKNOBBEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public NativeList<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeList<Entity> LLHGNDFGELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeParallelHashSet<Entity> AAFNGEECJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeList<OBPKNBEFOFF> HEIOGCLCBOF;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6DB09A0", Offset = "0x6DAF5A0", VA = "0x186DB09A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RegisterService(typeof(BBOMDFEBJLN), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class BBOMDFEBJLN : PFAELLKIJHO, POGLPIENEJD, LCGGPACKJOJ, EIHOCFDABND
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct JHGJHANKNKI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly BBOMDFEBJLN CDBGCEIGNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly bool EIOCNNHPNIK;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x10BF1C0", Offset = "0x10BDDC0", VA = "0x1810BF1C0")]
		public JHGJHANKNKI(BBOMDFEBJLN CDBGCEIGNJC, bool EIOCNNHPNIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6DC33C0", Offset = "0x6DC1FC0", VA = "0x186DC33C0")]
		public Queue<CHOLEGGOAAH>.Enumerator NEGBLLIJCNA()
		{
			return default(Queue<CHOLEGGOAAH>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC30B0", Offset = "0x6DC1CB0", VA = "0x186DC30B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[DependsOn]
	private OIMOBMEJAIF HJOCKDGCNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[DependsOn]
	private HMEHHLPADPE LCLENKADDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private List<NativeList<BKCAPMPDKDN>> JHMMFFJLFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<KFAONOJCCPI> ADJABHCDAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private List<(Entity, List<GameObject>)> HFGEFOIIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private DBKFKEKHADG<CHOLEGGOAAH> GIJLPGADAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private DBKFKEKHADG<DBPNKNOBBEM> MDHMGAOPELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private DBKFKEKHADG<CDJGIGJBEDG> LPFKOMGOLGA;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF8B0", Offset = "0x6DAE4B0", VA = "0x186DAF8B0", Slot = "4")]
	public void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFB00", Offset = "0x6DAE700", VA = "0x186DAFB00")]
	public void MFMBAFGNIOH(NativeList<BKCAPMPDKDN> MDFOPCMGEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0320", Offset = "0x6DAEF20", VA = "0x186DB0320")]
	public void ONJAJECNCMP(Entity CDBGCEIGNJC, [In] DBNLNCLIBPO<GameObject> JMOIGLOLGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0080", Offset = "0x6DAEC80", VA = "0x186DB0080")]
	public void NGAIMBFJOHA(NativeList<KFAONOJCCPI> BKJFMIDIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF680", Offset = "0x6DAE280", VA = "0x186DAF680")]
	public void HDCJDKGJJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFBD0", Offset = "0x6DAE7D0", VA = "0x186DAFBD0")]
	public void MIBDLONPMNL(LONHKCPEDHN IGEADGIGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF480", Offset = "0x6DAE080", VA = "0x186DAF480")]
	public JobHandle ENPBOICBPFF([In] CHOLEGGOAAH LFKIGNHCOID, JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF520", Offset = "0x6DAE120", VA = "0x186DAF520")]
	public JobHandle ENPBOICBPFF([In] DBPNKNOBBEM LFKIGNHCOID, JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0A10", Offset = "0x6AEF610", VA = "0x186AF0A10")]
	public JHGJHANKNKI NMJGHNOMHCG(bool EIOCNNHPNIK)
	{
		return default(JHGJHANKNKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFAB0", Offset = "0x6DAE6B0", VA = "0x186DAFAB0")]
	public LACBKPLCKFJ<DBPNKNOBBEM> KOLJFJMJFKF()
	{
		return default(LACBKPLCKFJ<DBPNKNOBBEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF630", Offset = "0x6DAE230", VA = "0x186DAF630")]
	public LACBKPLCKFJ<CDJGIGJBEDG> GOCKEPDEANL()
	{
		return default(LACBKPLCKFJ<CDJGIGJBEDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0110", Offset = "0x6DAED10", VA = "0x186DB0110", Slot = "5")]
	public void NPJJLDNPIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF5C0", Offset = "0x6DAE1C0", VA = "0x186DAF5C0", Slot = "6")]
	private void GGEGDPIKPLN(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D77360", Offset = "0x6D75F60", VA = "0x186D77360", Slot = "7")]
	private void AEHPABPDHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public BBOMDFEBJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct HHKCLMOKNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public UniformTRS JCBHPFOKECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public StandardRenderableVisualData CKKCIGFGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public ENKLMLKMLJC HHLMDDDPFNI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CHOLEGGOAAH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> LLHGNDFGELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> AAFNGEECJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<FEBLOFFJPHN> LDEMGPJCLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<BKCAPMPDKDN> MDFOPCMGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<HHKCLMOKNHL> GOIIHPKHCFK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0540", Offset = "0x6DAF140", VA = "0x186DB0540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0550", Offset = "0x6DAF150", VA = "0x186DB0550")]
	public void ICJAGPEAKJN(bool EIOCNNHPNIK)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : JHOFCDCEFIB, PFAELLKIJHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			[ReadOnly]
			public NativeParallelHashMap<int, PKDHLEFJHBK> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public NativeArray<OBPKNBEFOFF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6DB6D20", Offset = "0x6DB5920", VA = "0x186DB6D20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			[ReadOnly]
			public NativeArray<BKCAPMPDKDN> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[ReadOnly]
			public NativeArray<FEBLOFFJPHN> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public NativeArray<HHKCLMOKNHL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6DB70C0", Offset = "0x6DB5CC0", VA = "0x186DB70C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6DB0860", Offset = "0x6DAF460", VA = "0x186DB0860", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0x6DC8200", Offset = "0x6DC6E00", VA = "0x186DC8200")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x6DC81B0", Offset = "0x6DC6DB0", VA = "0x186DC81B0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 CFJPPBJEJMC(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x6DC5B00", Offset = "0x6DC4700", VA = "0x186DC5B00", Slot = "5")]
				public float3 LEODIMDNJAH(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x6DC5AC0", Offset = "0x6DC46C0", VA = "0x186DC5AC0", Slot = "4")]
				public float3 CFJPPBJEJMC(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x6DC6E30", Offset = "0x6DC5A30", VA = "0x186DC6E30", Slot = "4")]
				public float3 CFJPPBJEJMC(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public NativeArray<FEBLOFFJPHN> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<BKCAPMPDKDN> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8CE0", Offset = "0x6DB78E0", VA = "0x186DB8CE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6DBA1B0", Offset = "0x6DB8DB0", VA = "0x186DBA1B0")]
			private void LHMFIJEONMJ(NativeList<PointSrcData> srcData, NativeList<BKCAPMPDKDN> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6DBB2E0", Offset = "0x6DB9EE0", VA = "0x186DBB2E0")]
			public static Vector3 MKLNAPMCKCM(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7870", Offset = "0x6DB6470", VA = "0x186DB7870")]
			public static quaternion AODFKPDLHKK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7AD0", Offset = "0x6DB66D0", VA = "0x186DB7AD0")]
			private static quaternion DEHOJEGNBCN(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7D00", Offset = "0x6DB6900", VA = "0x186DB7D00")]
			private static float3 DFFNJLILLEP(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6DB77E0", Offset = "0x6DB63E0", VA = "0x186DB77E0")]
			private static quaternion AIGHDJNKFME(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9A30", Offset = "0x6DB8630", VA = "0x186DB9A30")]
			private static BKCAPMPDKDN ICJFDBHEDJN(int idx, NativeList<PointSrcData> srcData)
			{
				return default(BKCAPMPDKDN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x34786A0", Offset = "0x34772A0", VA = "0x1834786A0")]
			private void AMEBPKCFHAP<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7ED0", Offset = "0x6DB6AD0", VA = "0x186DB7ED0")]
			private void EGCIGGMNOHA(NativeList<PointSrcData> sourcePoints, NativeList<BKCAPMPDKDN> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6DBB160", Offset = "0x6DB9D60", VA = "0x186DBB160")]
			public static float LNKGAFIDNJJ(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9340", Offset = "0x6DB7F40", VA = "0x186DB9340")]
			private static quaternion FBAMDDAFIMB(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9D30", Offset = "0x6DB8930", VA = "0x186DB9D30")]
			private static BKCAPMPDKDN IOCLOMDCAEF(PointSrcData point)
			{
				return default(BKCAPMPDKDN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9CA0", Offset = "0x6DB88A0", VA = "0x186DB9CA0")]
			private static BKCAPMPDKDN IOCLOMDCAEF(float3 pos, quaternion rot, float radius)
			{
				return default(BKCAPMPDKDN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9530", Offset = "0x6DB8130", VA = "0x186DB9530")]
			private static bool FMGJKNAPFJI(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6DBB090", Offset = "0x6DB9C90", VA = "0x186DBB090")]
			private static float3 LLOJGJBEENM(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6DB9E50", Offset = "0x6DB8A50", VA = "0x186DB9E50")]
			public static float3 LBEAKCEACOB(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6DBA000", Offset = "0x6DB8C00", VA = "0x186DBA000")]
			public static float3 LEODIMDNJAH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6DB95D0", Offset = "0x6DB81D0", VA = "0x186DB95D0")]
			private static quaternion FPBCDBNNLNC(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6DB78F0", Offset = "0x6DB64F0", VA = "0x186DB78F0")]
			private static float BBGBDNCGMLC(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6DCA4F0", Offset = "0x6DC90F0", VA = "0x186DCA4F0")]
			private void JOHJBAEGEGM(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6DCA400", Offset = "0x6DC9000", VA = "0x186DCA400", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public NativeList<BKCAPMPDKDN> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6DCBB00", Offset = "0x6DCA700", VA = "0x186DCBB00")]
			private void JOHJBAEGEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6DCBAF0", Offset = "0x6DCA6F0", VA = "0x186DCBAF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public NativeList<BKCAPMPDKDN> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6DCBAA0", Offset = "0x6DCA6A0", VA = "0x186DCBAA0")]
			private void JOHJBAEGEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6DCBA90", Offset = "0x6DCA690", VA = "0x186DCBA90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeList<OBPKNBEFOFF> data;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7410", Offset = "0x6DB6010", VA = "0x186DB7410")]
			private void JOHJBAEGEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6DB7400", Offset = "0x6DB6000", VA = "0x186DB7400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NativeList<FEBLOFFJPHN> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NativeList<HHKCLMOKNHL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6DB75E0", Offset = "0x6DB61E0", VA = "0x186DB75E0")]
			private void JOHJBAEGEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6DB75D0", Offset = "0x6DB61D0", VA = "0x186DB75D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6DCB670", Offset = "0x6DCA270", VA = "0x186DCB670")]
			private void JOHJBAEGEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6DCB660", Offset = "0x6DCA260", VA = "0x186DCB660", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly BNHLDIHMNLF log;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CDGDIIFGCKH replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private OIMOBMEJAIF objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BBOMDFEBJLN bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FPMOCEIKBFP ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9F60", Offset = "0x6DC8B60", VA = "0x186DC9F60", Slot = "15")]
		public override void InitReferences(JHKOPLPKGAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA9F0", Offset = "0x6DC95F0", VA = "0x186DCA9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAAE0", Offset = "0x6DC96E0", VA = "0x186DCAAE0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAB40", Offset = "0x6DC9740", VA = "0x186DCAB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB120", Offset = "0x6DC9D20", VA = "0x186DCB120")]
		private JobHandle PKIONFNBJHL(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6DC90A0", Offset = "0x6DC7CA0", VA = "0x186DC90A0")]
		private JobHandle HMNJLNNDGBH(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8220", Offset = "0x6DC6E20", VA = "0x186DC8220")]
		private JobHandle AKEPCNBBLKO(NativeArray<int> pointCount, NativeList<BKCAPMPDKDN> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DC99F0", Offset = "0x6DC85F0", VA = "0x186DC99F0")]
		private JobHandle IEFIHBLNEGN(NativeList<BKCAPMPDKDN> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAC50", Offset = "0x6DC9850", VA = "0x186DCAC50")]
		private JobHandle PGMHFONCPID(EntityQuery query, NativeList<FEBLOFFJPHN> splinePointRanges, NativeList<BKCAPMPDKDN> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA5D0", Offset = "0x6DC91D0", VA = "0x186DCA5D0")]
		private JobHandle MJGGBAFADLK(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8AA0", Offset = "0x6DC76A0", VA = "0x186DC8AA0")]
		private JobHandle FHLBFNHHGHI(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA040", Offset = "0x6DC8C40", VA = "0x186DCA040")]
		private JobHandle JMBOAABOBEK(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<OBPKNBEFOFF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9CA0", Offset = "0x6DC88A0", VA = "0x186DC9CA0")]
		private JobHandle IOGEGIHGGHD(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<FEBLOFFJPHN> splinePointRanges, [Out] NativeList<HHKCLMOKNHL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9A90", Offset = "0x6DC8690", VA = "0x186DC9A90")]
		private JobHandle IENECKMOEAK(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8B90", Offset = "0x6DC7790", VA = "0x186DC8B90")]
		private JobHandle FIKGGGMBAPL(EntityQuery query, NativeList<OBPKNBEFOFF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6DC83D0", Offset = "0x6DC6FD0", VA = "0x186DC83D0")]
		private static NativeParallelHashMap<int, PKDHLEFJHBK> CMBIKEGDIAG()
		{
			return default(NativeParallelHashMap<int, PKDHLEFJHBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6DC87F0", Offset = "0x6DC73F0", VA = "0x186DC87F0")]
		private JobHandle ENAABDDIGPB(EntityQuery query, NativeList<FEBLOFFJPHN> splinePointRanges, NativeList<BKCAPMPDKDN> splinePointData, NativeList<HHKCLMOKNHL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9910", Offset = "0x6DC8510", VA = "0x186DC9910")]
		private JobHandle HPCPIDKPFKM(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8220", Offset = "0x6DC6E20", VA = "0x186DC8220")]
		private JobHandle JFJFBCAHMAF(NativeArray<int> pointCount, NativeList<BKCAPMPDKDN> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6DC99F0", Offset = "0x6DC85F0", VA = "0x186DC99F0")]
		private JobHandle NJNDIKNDBEJ(NativeList<BKCAPMPDKDN> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA6F0", Offset = "0x6DC92F0", VA = "0x186DCA6F0")]
		private JobHandle OJMCGGDMKME(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<OBPKNBEFOFF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6DC82C0", Offset = "0x6DC6EC0", VA = "0x186DC82C0")]
		private JobHandle AMIFABENMLO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<FEBLOFFJPHN> ranges, NativeList<HHKCLMOKNHL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA2B0", Offset = "0x6DC8EB0", VA = "0x186DCA2B0")]
		private JobHandle KKAOKDDLICP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA7E0", Offset = "0x6DC93E0", VA = "0x186DCA7E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IKHFPADMMEN : GBBIAOIACBC, PFAELLKIJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public BBOMDFEBJLN EJINJBGMOCF;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2630", Offset = "0x6DC1230", VA = "0x186DC2630", Slot = "14")]
	public void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2680", Offset = "0x6DC1280", VA = "0x186DC2680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public IKHFPADMMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class HJJMHEHPEEO : JHOFCDCEFIB, PFAELLKIJHO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct AJDOFDKNFBG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EntityManager DPCAAACILIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private DCJBKFEFELO<T> GICACIPKCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int MFJLAMOCOBC;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x3EB7890", Offset = "0x3EB6490", VA = "0x183EB7890")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7C70", Offset = "0x3EB6870", VA = "0x183EB7C70")]
		public AJDOFDKNFBG(EntityManager DPCAAACILIP, DCJBKFEFELO<T> GICACIPKCID, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CCE0", Offset = "0x3B1B8E0", VA = "0x183B1CCE0")]
		public AJDOFDKNFBG<T> NEGBLLIJCNA()
		{
			return default(AJDOFDKNFBG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7BB0", Offset = "0x3EB67B0", VA = "0x183EB7BB0")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly BNHLDIHMNLF IPOJDOIEHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private HMEHHLPADPE LCLENKADDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private BBOMDFEBJLN EJINJBGMOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::ONCDAMBDMAA GCENDBBKOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int PLDDLMABCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string ENADNPKHGIF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEC40", Offset = "0x6DBD840", VA = "0x186DBEC40", Slot = "15")]
	public override void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFF40", Offset = "0x6DBEB40", VA = "0x186DBFF40")]
	public void LKEBGELEEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0870", Offset = "0x6DBF470", VA = "0x186DC0870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEF20", Offset = "0x6DBDB20", VA = "0x186DBEF20")]
	private void KLAIHKGEGCO(CDJGIGJBEDG LFKIGNHCOID, Mesh[] OOAIDKILIOC, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2E303E0", Offset = "0x2E2EFE0", VA = "0x182E303E0")]
	private AJDOFDKNFBG<T> FABCNKPMNMJ<T>(DCJBKFEFELO<T> GICACIPKCID, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB) where T : struct
	{
		return default(AJDOFDKNFBG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE8B0", Offset = "0x6DBD4B0", VA = "0x186DBE8B0")]
	private void FJKMCPBAKJA(Transform CDBGCEIGNJC, NativeArray<ACPDDKHIAHD> IHKBIBDBONM, DBNLNCLIBPO<GameObject> GLFIDHMIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC03B0", Offset = "0x6DBEFB0", VA = "0x186DC03B0")]
	private void OGOMEKENNAC(Transform CDBGCEIGNJC, NativeArray<BNBHPCMOGNM> FDNCBMHENJO, DBNLNCLIBPO<GameObject> GLFIDHMIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1A10", Offset = "0x6DC0610", VA = "0x186DC1A10")]
	private void PFOEEFONGBE(Transform CDBGCEIGNJC, NativeArray<LELMPAGNAMH> PDJHOPJCBHC, DBNLNCLIBPO<GameObject> GLFIDHMIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6DBFFB0", Offset = "0x6DBEBB0", VA = "0x186DBFFB0")]
	private void ODABMMCCCII(Transform CDBGCEIGNJC, NativeArray<ELEOAFMMIAG> OOAIDKILIOC, Mesh[] PMKKEMGMIOC, DBNLNCLIBPO<GameObject> GLFIDHMIEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1E00", Offset = "0x6DC0A00", VA = "0x186DC1E00")]
	private static void PGIICABKOHO(NativeParallelHashSet<Entity> BHNJCFOPBNC, NativeParallelHashSet<Entity> DHGADNMDKDK, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6DBEE60", Offset = "0x6DBDA60", VA = "0x186DBEE60")]
	private static void KGAJCCLPCDE(NativeList<Entity> APGPCFDNGCA, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD370", Offset = "0x6DBBF70", VA = "0x186DBD370")]
	private NativeParallelHashMap<Entity, DNPNPGJLOBH> ALNGFDNHCNB(BBOMDFEBJLN.JHGJHANKNKI POOMCCPFADK, LACBKPLCKFJ<DBPNKNOBBEM> GGFAPJPDCAD, NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB, List<GameObject> GLFIDHMIEBE)
	{
		return default(NativeParallelHashMap<Entity, DNPNPGJLOBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6DBE310", Offset = "0x6DBCF10", VA = "0x186DBE310")]
	private void DLMOKDAEHCB(NativeList<Entity> GFBPCNPDHKP, NativeList<Entity> GLOBIHCGNPA, NativeParallelHashMap<Entity, DNPNPGJLOBH> HJHGPDDGNEM, NativeList<FEBLOFFJPHN> DMBPONLJLPH, NativeList<BKCAPMPDKDN> PLHJLLFGPMK, NativeList<HHKCLMOKNHL> JHMMFFJLFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDEF0", Offset = "0x6DBCAF0", VA = "0x186DBDEF0")]
	private void BFBDJHKOPOL(NativeList<Entity> BHNJCFOPBNC, NativeList<Entity> LLHGNDFGELM, NativeParallelHashMap<Entity, DNPNPGJLOBH> HJHGPDDGNEM, NativeList<OBPKNBEFOFF> HEIOGCLCBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	public HJJMHEHPEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class KKBAEABLFAB : KPHEMJJKPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly UniformTRS JCBHPFOKECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly BDGGMOHGNEL CDBGCEIGNJC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject GIOHANGHEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS COPPBHBKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3820", Offset = "0x6DC2420", VA = "0x186DC3820", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 NPNBDFJAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3640", Offset = "0x6DC2240", VA = "0x186DC3640", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 NNPCPMMNCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6DC35F0", Offset = "0x6DC21F0", VA = "0x186DC35F0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 FABHAHLAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3780", Offset = "0x6DC2380", VA = "0x186DC3780", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3900", Offset = "0x6DC2500", VA = "0x186DC3900", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion KBPLANPJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6DC36E0", Offset = "0x6DC22E0", VA = "0x186DC36E0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3730", Offset = "0x6DC2330", VA = "0x186DC3730", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 AODJFPGMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3690", Offset = "0x6DC2290", VA = "0x186DC3690", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 AENBOOGLPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6DC37D0", Offset = "0x6DC23D0", VA = "0x186DC37D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 KOBKDFEMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3950", Offset = "0x6DC2550", VA = "0x186DC3950", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC39A0", Offset = "0x6DC25A0", VA = "0x186DC39A0")]
	public KKBAEABLFAB(UniformTRS JCBHPFOKECA, BDGGMOHGNEL CDBGCEIGNJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class AJKJOPPIPIO : KKBAEABLFAB, ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float JCPIPHBCGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly float3 DJPMHCGJNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JJGANJGEFFL GNBIKNFLGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly OICBHJLAMDI AFAMNECOPMO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private FJFKEFAPLLG MBNBMMDPFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAE180", Offset = "0x6DACD80", VA = "0x186DAE180", Slot = "17")]
		get
		{
			return default(FJFKEFAPLLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS LGDFKDAKLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAE1D0", Offset = "0x6DACDD0", VA = "0x186DAE1D0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float DPAJOBGBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x91A510", Offset = "0x919110", VA = "0x18091A510", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 DODJNHLBEML
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAE130", Offset = "0x6DACD30", VA = "0x186DAE130", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JJGANJGEFFL NDJJFACBDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x90A080", Offset = "0x908C80", VA = "0x18090A080", Slot = "21")]
		get
		{
			return default(JJGANJGEFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private OICBHJLAMDI NCCMEGAAKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xCDF820", Offset = "0xCDE420", VA = "0x180CDF820", Slot = "22")]
		get
		{
			return default(OICBHJLAMDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool MHEMJJPNIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GBJEBMDNCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE2B0", Offset = "0x6DACEB0", VA = "0x186DAE2B0")]
	protected AJKJOPPIPIO(UniformTRS JCBHPFOKECA, BDGGMOHGNEL CDBGCEIGNJC, float JCPIPHBCGIA, float3 DJPMHCGJNKL, JJGANJGEFFL GNBIKNFLGKC, OICBHJLAMDI AFAMNECOPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GIGLPMNLKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5580", Offset = "0x6DB4180", VA = "0x186DB5580")]
	public static void HOFHDKHMGLE(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP, LONHKCPEDHN DGKMFHJOKEK, OIMOBMEJAIF KKIIGPHCOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5970", Offset = "0x6DB4570", VA = "0x186DB5970")]
	public static void JDLHGCJCBFB(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP, LONHKCPEDHN DGKMFHJOKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5BF0", Offset = "0x6DB47F0", VA = "0x186DB5BF0")]
	public static NativeList<Entity> LBKPGBOKIBI(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5EA0", Offset = "0x6DB4AA0", VA = "0x186DB5EA0")]
	public static NativeList<Entity> OBHFCDGIBDA(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5C30", Offset = "0x6DB4830", VA = "0x186DB5C30")]
	private static NativeList<Entity> LBKPGBOKIBI(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP, bool CGKONDPCGIJ)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class FPMAPBNJKPJ : KPHEMJJKPDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly JBKDGFJKCIL IMOBCMCECHO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected BDGGMOHGNEL NDBMEFNOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAE6980", Offset = "0xAE5580", VA = "0x180AE6980")]
		get
		{
			return default(BDGGMOHGNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity FJGACADKINK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3D20", Offset = "0x6DB2920", VA = "0x186DB3D20")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected OIMOBMEJAIF ONJJENNLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3630", Offset = "0x6DB2230", VA = "0x186DB3630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected CACJPJLNOFJ HIJGPDHINAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3A00", Offset = "0x6DB2600", VA = "0x186DB3A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected DNJBJGGECOC LOMFAGFONCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3860", Offset = "0x6DB2460", VA = "0x186DB3860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject GIOHANGHEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3A60", Offset = "0x6DB2660", VA = "0x186DB3A60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS COPPBHBKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB143F0", Offset = "0xB12FF0", VA = "0x180B143F0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 NPNBDFJAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3560", Offset = "0x6DB2160", VA = "0x186DB3560", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 NNPCPMMNCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6DB33D0", Offset = "0x6DB1FD0", VA = "0x186DB33D0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 FABHAHLAOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3A90", Offset = "0x6DB2690", VA = "0x186DB3A90", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3D40", Offset = "0x6DB2940", VA = "0x186DB3D40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion KBPLANPJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3740", Offset = "0x6DB2340", VA = "0x186DB3740", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB38F0", Offset = "0x6DB24F0", VA = "0x186DB38F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 AODJFPGMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3640", Offset = "0x6DB2240", VA = "0x186DB3640", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 AENBOOGLPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3B60", Offset = "0x6DB2760", VA = "0x186DB3B60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 KOBKDFEMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3E50", Offset = "0x6DB2A50", VA = "0x186DB3E50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1F695C0", Offset = "0x1F681C0", VA = "0x181F695C0")]
	protected FPMAPBNJKPJ(JBKDGFJKCIL IGNNJCLPPOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3710", Offset = "0x6DB2310", VA = "0x186DB3710")]
	public static FJFKEFAPLLG FGDKAMMLLCN(FPMAPBNJKPJ APOGBJPOAAH)
	{
		return default(FJFKEFAPLLG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MKGBEBOMOFP
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6840", Offset = "0x6DC5440", VA = "0x186DC6840")]
	public static void AJALKIGKDNH(NativeArray<Entity> BHNJCFOPBNC, EntityManager DPCAAACILIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class NJCHHOODKNB : FPMAPBNJKPJ, ALJHPAAKHOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float JCPIPHBCGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 DJPMHCGJNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JJGANJGEFFL GNBIKNFLGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private OICBHJLAMDI AFAMNECOPMO;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager EHDJNFFGDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6D30", Offset = "0x6DC5930", VA = "0x186DC6D30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected BIOJOMCAEIE GFOAIEOFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6CA0", Offset = "0x6DC58A0", VA = "0x186DC6CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData JMHCBIMHEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6DC6A80", Offset = "0x6DC5680", VA = "0x186DC6A80")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FJFKEFAPLLG MBNBMMDPFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3710", Offset = "0x6DB2310", VA = "0x186DB3710", Slot = "17")]
		get
		{
			return default(FJFKEFAPLLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float DPAJOBGBEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x918F20", Offset = "0x917B20", VA = "0x180918F20", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 DODJNHLBEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xF05B10", Offset = "0xF04710", VA = "0x180F05B10", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JJGANJGEFFL NDJJFACBDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0", Slot = "21")]
		get
		{
			return default(JJGANJGEFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private OICBHJLAMDI NCCMEGAAKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xADFAB0", Offset = "0xADE6B0", VA = "0x180ADFAB0", Slot = "22")]
		get
		{
			return default(OICBHJLAMDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS LGDFKDAKLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB143F0", Offset = "0xB12FF0", VA = "0x180B143F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GBJEBMDNCPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6010", Offset = "0x8B4C10", VA = "0x1808B6010", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D90", Offset = "0x8B4990", VA = "0x1808B5D90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool MHEMJJPNIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6DF0", Offset = "0x6DC59F0", VA = "0x186DC6DF0")]
	protected NJCHHOODKNB(JBKDGFJKCIL IGNNJCLPPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6B10", Offset = "0x6DC5710", VA = "0x186DC6B10", Slot = "26")]
	public virtual void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class JHOFCDCEFIB : GBBIAOIACBC, PFAELLKIJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected OIMOBMEJAIF KKIIGPHCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private INOJLNLAEOL PIAKONPJLMJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected LONHKCPEDHN PHEGFAEEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6DC34C0", Offset = "0x6DC20C0", VA = "0x186DC34C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected IFIADOEPHCD DCBGKAOFDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3470", Offset = "0x6DC2070", VA = "0x186DC3470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3510", Offset = "0x6DC2110", VA = "0x186DC3510", Slot = "15")]
	public virtual void InitReferences(JHKOPLPKGAC AOJEPPFAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2371B00", Offset = "0x2370700", VA = "0x182371B00")]
	protected JHOFCDCEFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CIIALHFPBCE
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0620", Offset = "0x6DAF220", VA = "0x186DB0620")]
	public static void GCDMJDICPBA(NativeArray<Entity> GFBPCNPDHKP, EntityManager DPCAAACILIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2819608899
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC4D0", Offset = "0x6DCB0D0", VA = "0x186DCC4D0")]
	public static void GENFCPCECLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC4C0", Offset = "0x6DCB0C0", VA = "0x186DCC4C0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class DPNDNDOEJKB : ContainerPropertyBag<JLBLHFIDAIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6DB11D0", Offset = "0x6DAFDD0", VA = "0x186DB11D0")]
	public DPNDNDOEJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class EMEMMFJLHMH : ContainerPropertyBag<JFPOCDBINJH>
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6DB15F0", Offset = "0x6DB01F0", VA = "0x186DB15F0")]
	public EMEMMFJLHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class PINPGBLMLIP : ContainerPropertyBag<ICJJEOIBDEJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8150", Offset = "0x6DC6D50", VA = "0x186DC8150")]
	public PINPGBLMLIP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB4A0", Offset = "0x6DCA0A0", VA = "0x186DCB4A0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
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
