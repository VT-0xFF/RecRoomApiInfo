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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C4030", Offset = "0x79C3430", VA = "0x1879C4030", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F206C0", Offset = "0x1F1FAC0", VA = "0x181F206C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79CFDF0", Offset = "0x79CF1F0", VA = "0x1879CFDF0")]
		private void LBKELEMAONI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79D0390", Offset = "0x79CF790", VA = "0x1879D0390", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79D03F0", Offset = "0x79CF7F0", VA = "0x1879D03F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OAEHGCEMFDI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79C9A00", Offset = "0x79C8E00", VA = "0x1879C9A00")]
	public static Quaternion GLJBLJEIFIG([In] this LFKFJAGKMGM CBDDEPDGEKA, [In] Vector3 DLBKBBJEBDD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JNBLBHAOGCE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79C1650", Offset = "0x79C0A50", VA = "0x1879C1650")]
	public static bool FELCJBNJPDJ(this NBNAKELDNIB JEHEOMBMMOC, JIHOGGHEDMF GNABMNHJHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79C19A0", Offset = "0x79C0DA0", VA = "0x1879C19A0")]
	public static bool IOLDODLMHGI(this NBNAKELDNIB JEHEOMBMMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79C2AC0", Offset = "0x79C1EC0", VA = "0x1879C2AC0")]
	public static bool PJDAOAKDGJO(this NBNAKELDNIB JEHEOMBMMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x79C1690", Offset = "0x79C0A90", VA = "0x1879C1690")]
	public static void GDBCAAIHLOL(this NBNAKELDNIB JEHEOMBMMOC, Vector3 BFDDAKOEBHD, Quaternion FEFNOGDOGPH, float MCIPFGHOGIP, bool IBDAMEMCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79C1380", Offset = "0x79C0780", VA = "0x1879C1380")]
	public static void DHDHIFDHBMK(this NBNAKELDNIB JEHEOMBMMOC, Vector3 BFDDAKOEBHD, Quaternion FEFNOGDOGPH, float MCIPFGHOGIP, int HNGDGEKICAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79C0D70", Offset = "0x79C0170", VA = "0x1879C0D70")]
	public static void ADNFLLHIMCN(this NBNAKELDNIB JEHEOMBMMOC, int HNGDGEKICAI, Vector3 BFDDAKOEBHD, Quaternion FEFNOGDOGPH, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79C1600", Offset = "0x79C0A00", VA = "0x1879C1600")]
	public static void EDBMPCJCBJD(this NBNAKELDNIB JEHEOMBMMOC, Vector3 HEOCEOCBLON, Quaternion CLJHJMJFEKJ, float MCIPFGHOGIP, bool IBDAMEMCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79C19D0", Offset = "0x79C0DD0", VA = "0x1879C19D0")]
	private static void JAMGKONGPKE(this NBNAKELDNIB JEHEOMBMMOC, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP, bool IBDAMEMCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79C2910", Offset = "0x79C1D10", VA = "0x1879C2910")]
	private static void OOGCACICGHO(this NBNAKELDNIB JEHEOMBMMOC, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, float HPHKHEHCJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79C17C0", Offset = "0x79C0BC0", VA = "0x1879C17C0")]
	private static void HLDOKPOHGHL(this NBNAKELDNIB JEHEOMBMMOC, int KDCAMOIGIMA, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, float HPHKHEHCJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79C25B0", Offset = "0x79C19B0", VA = "0x1879C25B0")]
	private static bool NHDFDADGCDP(this NBNAKELDNIB JEHEOMBMMOC, int KDCAMOIGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79C2320", Offset = "0x79C1720", VA = "0x1879C2320")]
	private static void KJIJMDABGBG(this NBNAKELDNIB JEHEOMBMMOC, int KDCAMOIGIMA, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, float HPHKHEHCJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79C0E90", Offset = "0x79C0290", VA = "0x1879C0E90")]
	public static Vector3 BMELLEAEBAH(this NBNAKELDNIB JEHEOMBMMOC, int KDCAMOIGIMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79C2800", Offset = "0x79C1C00", VA = "0x1879C2800")]
	public static Quaternion OKGBBABFCKA(this NBNAKELDNIB JEHEOMBMMOC, int KDCAMOIGIMA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79C25E0", Offset = "0x79C19E0", VA = "0x1879C25E0")]
	public static Vector3 OKDJMHAKLKP(JIHOGGHEDMF CPMLONDPBFE, Vector3 JPKKPDPLAGA, Vector3? BOOJKPPEPLC, Vector3 CJMDGEBHAFH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface LCDGMENHOEF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEKHLMENIBB(EntityQuery MHFPDMHHOMF, EntityManager EDIIKMBGJIA, KAMIOLGOEIG CLKKBOEEKDJ, GMDACEHEEGF LJCKNNKNPNA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface JPGJGINBMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType IIHIPIMJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMFJHBIIPEM(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDMIOEIKNMC(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMECFALEAPA(GGLOKDKCJOE PINNJHFODKP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class ADMAHMCPOEI : LCDGMENHOEF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79B0FB0", Offset = "0x79B03B0", VA = "0x1879B0FB0", Slot = "4")]
	public void JEKHLMENIBB(EntityQuery MHFPDMHHOMF, EntityManager EDIIKMBGJIA, KAMIOLGOEIG CLKKBOEEKDJ, GMDACEHEEGF LJCKNNKNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ADMAHMCPOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class JINELHMMCMG : LCDGMENHOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IHDDPGHJDNB HDNIPLAAELF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
	public JINELHMMCMG(IHDDPGHJDNB HDNIPLAAELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79C0440", Offset = "0x79BF840", VA = "0x1879C0440", Slot = "4")]
	public void JEKHLMENIBB(EntityQuery MHFPDMHHOMF, EntityManager EDIIKMBGJIA, KAMIOLGOEIG CLKKBOEEKDJ, GMDACEHEEGF LJCKNNKNPNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class BHCNJKIKOAO : LCDGMENHOEF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79B2AE0", Offset = "0x79B1EE0", VA = "0x1879B2AE0", Slot = "4")]
	public void JEKHLMENIBB(EntityQuery MHFPDMHHOMF, EntityManager EDIIKMBGJIA, KAMIOLGOEIG CLKKBOEEKDJ, GMDACEHEEGF LJCKNNKNPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public BHCNJKIKOAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AAANMOAHKPL : JPGJGINBMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType IIHIPIMJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79B02C0", Offset = "0x79AF6C0", VA = "0x1879B02C0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79B05C0", Offset = "0x79AF9C0", VA = "0x1879B05C0", Slot = "5")]
	public void PMFJHBIIPEM(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x79B02F0", Offset = "0x79AF6F0", VA = "0x1879B02F0", Slot = "6")]
	public void JDMIOEIKNMC(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79B0570", Offset = "0x79AF970", VA = "0x1879B0570", Slot = "7")]
	public void NMECFALEAPA(GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public AAANMOAHKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HJGDKOBGPNJ : JPGJGINBMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType IIHIPIMJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x79BF990", Offset = "0x79BED90", VA = "0x1879BF990", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x79BFC90", Offset = "0x79BF090", VA = "0x1879BFC90", Slot = "5")]
	public void PMFJHBIIPEM(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79BF9C0", Offset = "0x79BEDC0", VA = "0x1879BF9C0", Slot = "6")]
	public void JDMIOEIKNMC(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79BFC40", Offset = "0x79BF040", VA = "0x1879BFC40", Slot = "7")]
	public void NMECFALEAPA(GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public HJGDKOBGPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GLABDDDMOMC : JPGJGINBMLP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType IIHIPIMJFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79B8C70", Offset = "0x79B8070", VA = "0x1879B8C70", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79B8F70", Offset = "0x79B8370", VA = "0x1879B8F70", Slot = "5")]
	public void PMFJHBIIPEM(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x79B8CA0", Offset = "0x79B80A0", VA = "0x1879B8CA0", Slot = "6")]
	public void JDMIOEIKNMC(EntityQuery MHFPDMHHOMF, GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79B8F20", Offset = "0x79B8320", VA = "0x1879B8F20", Slot = "7")]
	public void NMECFALEAPA(GGLOKDKCJOE PINNJHFODKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public GLABDDDMOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FPGPPKCCHDD : AKIFIDDOCJA, IHCCKBEFLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KAMIOLGOEIG CLKKBOEEKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PEDHLFBNIMO GLCLMIIIONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GMDACEHEEGF LJCKNNKNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, LCDGMENHOEF adapter)> CILBNFANGFH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x79B87C0", Offset = "0x79B7BC0", VA = "0x1879B87C0", Slot = "15")]
	public virtual void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x79B8850", Offset = "0x79B7C50", VA = "0x1879B8850", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x79B8650", Offset = "0x79B7A50", VA = "0x1879B8650")]
	private void HCJIKOEDJPP(EntityQueryDesc KHKFOLKPLGL, LCDGMENHOEF BBIEMBKECLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x79B8A80", Offset = "0x79B7E80", VA = "0x1879B8A80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
	public FPGPPKCCHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class OGGKDGEJAEB : AKIFIDDOCJA, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NAKOLKJCLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery AJHDPDOFGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery ALNPAKKCGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery KPGMPLHBPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery FOMJKLPFNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery GEDAHHDBBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery HPDJHKCJLOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery DOPIFHMLLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JPGJGINBMLP NJGKIBGCMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType CHGAELLPFKP;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public NAKOLKJCLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KAMIOLGOEIG CLKKBOEEKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GMDACEHEEGF LJCKNNKNPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PEDHLFBNIMO GLCLMIIIONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<NAKOLKJCLNI> CILBNFANGFH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x79CA670", Offset = "0x79C9A70", VA = "0x1879CA670", Slot = "14")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x79CA700", Offset = "0x79C9B00", VA = "0x1879CA700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79CA880", Offset = "0x79C9C80", VA = "0x1879CA880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79C9AE0", Offset = "0x79C8EE0", VA = "0x1879C9AE0")]
	private void EAFIICJJBFI(NAKOLKJCLNI NLHLNBDAOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79C9F30", Offset = "0x79C9330", VA = "0x1879C9F30")]
	private void HCJIKOEDJPP(JPGJGINBMLP NJGKIBGCMII, ComponentType ICCIANDMJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
	public OGGKDGEJAEB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct LLGLCKKEODE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct PLFPPFDCIDN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct NHBOKKOFMOC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(GMDACEHEEGF), new string[] { })]
public class MLAKBMGNNLO : GMDACEHEEGF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LCELNNMJEBA BAKNLMLOEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LCELNNMJEBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MLAKBMGNNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(HEOPOKIOLJB), new string[] { })]
public class DLAEGKEGMIC : HEOPOKIOLJB, BCFPBBPBCDB, HNDDMAHOBCN, AMKGLADJPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private GGAPNNOMOKP DKMHLJBGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private KAMIOLGOEIG CLKKBOEEKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private IKEEOMDEEKE NMKGGMBKIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity KNBGJJAAMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EHIJPMKNJBK FEGLIFMOPCK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79B7310", Offset = "0x79B6710", VA = "0x1879B7310", Slot = "4")]
	public bool OKCPOFPCMHM(PMMHELJLBHE MBPEAJOCCID, DCENJHJEFHP FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79B7050", Offset = "0x79B6450", VA = "0x1879B7050", Slot = "5")]
	public EHIJPMKNJBK HFFCJGKDILO()
	{
		return default(EHIJPMKNJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x79B6EB0", Offset = "0x79B62B0", VA = "0x1879B6EB0", Slot = "6")]
	public void DKAAFCLMKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79B6FC0", Offset = "0x79B63C0", VA = "0x1879B6FC0", Slot = "7")]
	private void GBNLIKPCGPH(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x10765E0", Offset = "0x10759E0", VA = "0x1810765E0", Slot = "8")]
	private void IKBMCJJKAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DLAEGKEGMIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(KFBEKILNECL), new string[] { })]
public class BLFFJFLJKHG : KFBEKILNECL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79B2C20", Offset = "0x79B2020", VA = "0x1879B2C20", Slot = "4")]
	public void BPENKDPLAOM(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79B2DC0", Offset = "0x79B21C0", VA = "0x1879B2DC0", Slot = "5")]
	public void JMMDGPFLICK(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79B2CA0", Offset = "0x79B20A0", VA = "0x1879B2CA0", Slot = "6")]
	public ComponentSystemBase CPFLHGKHDPE(World DKMHLJBGIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79B2D60", Offset = "0x79B2160", VA = "0x1879B2D60", Slot = "7")]
	public void FIDFNBINJGK(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79B3670", Offset = "0x79B2A70", VA = "0x1879B3670", Slot = "8")]
	public void PKACCCDGGBP(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79B2E10", Offset = "0x79B2210", VA = "0x1879B2E10", Slot = "9")]
	public void OKJFGDGKHOE(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79B2CF0", Offset = "0x79B20F0", VA = "0x1879B2CF0", Slot = "10")]
	public void DDMNLPJLEEO(World DKMHLJBGIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79B2E70", Offset = "0x79B2270", VA = "0x1879B2E70", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> PHOMNMKIFJG()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public BLFFJFLJKHG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct ELGKDHKFPPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct DKEEPIDBCEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HKHKECDPPBL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ILFCNFCNGEH KCKNBOIOGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79BFF80", Offset = "0x79BF380", VA = "0x1879BFF80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79BFF10", Offset = "0x79BF310", VA = "0x1879BFF10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public HKHKECDPPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct HNKGKNJPKED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EHIJPMKNJBK FJIJIKAGHGP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static HNKGKNJPKED MDKCMNAEKLA(EHIJPMKNJBK ENGGEIHHCEE)
	{
		return default(HNKGKNJPKED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IGJMOENMPGM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AGEEDABPPLL GHGDNIIEBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79BFFD0", Offset = "0x79BF3D0", VA = "0x1879BFFD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public IGJMOENMPGM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct CPPDHLPKOEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct JJGGMABAONN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BLIJJMIHMBP KEHNILIEJPK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static JJGGMABAONN MDKCMNAEKLA(BLIJJMIHMBP ENGGEIHHCEE)
	{
		return default(JJGGMABAONN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct GOFGDICMIGJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EHIJPMKNJBK FJIJIKAGHGP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static GOFGDICMIGJ MDKCMNAEKLA(EHIJPMKNJBK ENGGEIHHCEE)
	{
		return default(GOFGDICMIGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JNLIFAMNBFJ : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EBHGEGCEOOD CJFPDCGGEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79C2B60", Offset = "0x79C1F60", VA = "0x1879C2B60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79C2AF0", Offset = "0x79C1EF0", VA = "0x1879C2AF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JNLIFAMNBFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JPNDHKANNPG : LKKMOFGLMIL, ILFCNFCNGEH, JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MADKHAHICNA LPGDLIDPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC6BF50", Offset = "0xC6B350", VA = "0x180C6BF50", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(MADKHAHICNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JMEGBOFNJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB47850", Offset = "0xB46C50", VA = "0x180B47850", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 CBKHPAAGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xFA2080", Offset = "0xFA1480", VA = "0x180FA2080", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79C2C00", Offset = "0x79C2000", VA = "0x1879C2C00")]
	public JPNDHKANNPG(UniformTRS FGJIBBMFFAD, ABFOBKHKCPD PBIFOHNGFLL, float DIOGLFEGGFF, float3 KHGAPLNHGHG, OCHPJGPHIOB FECIEDEIBMC, FECNNNMEDDD MFMLBKEBCKM, MADKHAHICNA BCOGHILOCOE, float3 DLCODMKGMBH, bool BEHFKEHPLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x79C2BB0", Offset = "0x79C1FB0", VA = "0x1879C2BB0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NPMBEJMDJBC : LKKMOFGLMIL, EBHGEGCEOOD, JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<HDHHCFJCJDP> KCPMKMAMKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IINBDMIFCPI NFHKMOGHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float ONBNIKAEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int IKMNKKHJDPL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MDIAOHMEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79C96B0", Offset = "0x79C8AB0", VA = "0x1879C96B0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FHCNLEOHCDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79C96D0", Offset = "0x79C8AD0", VA = "0x1879C96D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ACBBAMDHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79C96C0", Offset = "0x79C8AC0", VA = "0x1879C96C0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EDBPAHEHPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCC2500", Offset = "0xCC1900", VA = "0x180CC2500", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float NLLEBINNLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBD2F80", Offset = "0xBD2380", VA = "0x180BD2F80", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MFBGJBMKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE58260", Offset = "0xE57660", VA = "0x180E58260", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x79C9600", Offset = "0x79C8A00", VA = "0x1879C9600")]
	public NPMBEJMDJBC(UniformTRS FGJIBBMFFAD, ABFOBKHKCPD PBIFOHNGFLL, float DIOGLFEGGFF, float3 KHGAPLNHGHG, OCHPJGPHIOB FECIEDEIBMC, FECNNNMEDDD MFMLBKEBCKM, IINBDMIFCPI NFHKMOGHIBC, float ONBNIKAEMHA, int IKMNKKHJDPL, NativeArray<HDHHCFJCJDP> KCPMKMAMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xFB9E40", Offset = "0xFB9240", VA = "0x180FB9E40", Slot = "33")]
	public NativeArray<HDHHCFJCJDP> GetNativeCurvePoints()
	{
		return default(NativeArray<HDHHCFJCJDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x79C9540", Offset = "0x79C8940", VA = "0x1879C9540", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ABFLHLFJBNE : IJKPONFONIE, ILFCNFCNGEH, JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<GCBGIGDHMFN, MADKHAHICNA> PGIHDGINHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MADKHAHICNA BCOGHILOCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BEHFKEHPLMC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private MADKHAHICNA AOJLFBCNMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9AF910", Offset = "0x9AED10", VA = "0x1809AF910", Slot = "28")]
		get
		{
			return default(MADKHAHICNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool HFJLFMIHMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD77920", Offset = "0xD76D20", VA = "0x180D77920", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 CBKHPAAGKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x79B0EE0", Offset = "0x79B02E0", VA = "0x1879B0EE0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x79B0EC0", Offset = "0x79B02C0", VA = "0x1879B0EC0")]
	public ABFLHLFJBNE(PMMHELJLBHE FAIMNGLIIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79B0840", Offset = "0x79AFC40", VA = "0x1879B0840", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79B0890", Offset = "0x79AFC90", VA = "0x1879B0890", Slot = "26")]
	public override void NABACIPFMBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CCIMFOJPBIO : BMJPHHMFCMI, AGEEDABPPLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject LBDLCJDFAKB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject JAHMEOIAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x79B4420", Offset = "0x79B3820", VA = "0x1879B4420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AKBPOJOBHNP GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x79B44E0", Offset = "0x79B38E0", VA = "0x1879B44E0", Slot = "15")]
		get
		{
			return default(AKBPOJOBHNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BCPFADGNNNB OKJMMBHENKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x79B4A10", Offset = "0x79B3E10", VA = "0x1879B4A10", Slot = "16")]
		get
		{
			return default(BCPFADGNNNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79B48C0", Offset = "0x79B3CC0", VA = "0x1879B48C0")]
	public CCIMFOJPBIO(PMMHELJLBHE MBPEAJOCCID, bool DBMLLCONPNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79B45E0", Offset = "0x79B39E0", VA = "0x1879B45E0")]
	public void IIFKKCGFMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x79B44E0", Offset = "0x79B38E0", VA = "0x1879B44E0")]
	protected AKBPOJOBHNP IEILHPGPLBH()
	{
		return default(AKBPOJOBHNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x79B4770", Offset = "0x79B3B70", VA = "0x1879B4770")]
	private static bool JHCOONOFLHK(PMMHELJLBHE KPJKGGLPKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79B44B0", Offset = "0x79B38B0", VA = "0x1879B44B0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KHGGBHGOLCB : IJKPONFONIE, EBHGEGCEOOD, JGBANNPBHOM, IDisposable, MPAIKKNNIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<HDHHCFJCJDP> KCPMKMAMKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool BDIBFGDMGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LLDAGJGIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float ONBNIKAEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int IKMNKKHJDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool COOJDIBBBBK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool CLHKPODFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB54C40", Offset = "0xB54040", VA = "0x180B54C40", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool GOHHAMMGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD850", Offset = "0x9DCC50", VA = "0x1809DD850", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float JMNGKCDFNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF630F0", Offset = "0xF624F0", VA = "0x180F630F0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int GEPIEADBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC6BF50", Offset = "0xC6B350", VA = "0x180C6BF50", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool IPEPGOMDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB47850", Offset = "0xB46C50", VA = "0x180B47850", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int JCGLGKJBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x79C3430", Offset = "0x79C2830", VA = "0x1879C3430", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int GHOJHODCFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x79C3340", Offset = "0x79C2740", VA = "0x1879C3340", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79C3590", Offset = "0x79C2990", VA = "0x1879C3590")]
	public KHGGBHGOLCB(PMMHELJLBHE FAIMNGLIIAA, [Optional] NativeList<HDHHCFJCJDP> KCPMKMAMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79C3450", Offset = "0x79C2850", VA = "0x1879C3450", Slot = "26")]
	public override void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x79C2DF0", Offset = "0x79C21F0", VA = "0x1879C2DF0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x79C2EE0", Offset = "0x79C22E0", VA = "0x1879C2EE0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x79C3530", Offset = "0x79C2930", VA = "0x1879C3530")]
	public void OPNFAMHCDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x79C3100", Offset = "0x79C2500", VA = "0x1879C3100", Slot = "34")]
	public NativeArray<HDHHCFJCJDP> GetNativeCurvePoints()
	{
		return default(NativeArray<HDHHCFJCJDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x79C2CA0", Offset = "0x79C20A0", VA = "0x1879C2CA0", Slot = "35")]
	private Vector3 BIDENJNCPCB(int MGJOIMHBHJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x79C2F40", Offset = "0x79C2340", VA = "0x1879C2F40", Slot = "36")]
	private Quaternion FIFNFHBFOCO(int MGJOIMHBHJO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x79C2F70", Offset = "0x79C2370", VA = "0x1879C2F70", Slot = "37")]
	private float GKIGGKLBACI(int MGJOIMHBHJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x79C32D0", Offset = "0x79C26D0", VA = "0x1879C32D0")]
	private NativeArray<Entity> IANCAPDMHNO()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class EIMHHLPGPMO : BDPJGHNOAON
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x79B7550", Offset = "0x79B6950", VA = "0x1879B7550", Slot = "15")]
	protected override ComponentSystemBase BMENBOOAFLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x79B7970", Offset = "0x79B6D70", VA = "0x1879B7970", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x79B7980", Offset = "0x79B6D80", VA = "0x1879B7980")]
	public EIMHHLPGPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[IFLAJJBFDLA]
public sealed class DGACJCAIDIH : NMHIKCLDHNA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery CHOIKBBPKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery JEOOIIGJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery NOMDCOCAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery PAHLMDABHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery IHBELFNHLHE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79B6A30", Offset = "0x79B5E30", VA = "0x1879B6A30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x79B6D90", Offset = "0x79B6190", VA = "0x1879B6D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x79B6670", Offset = "0x79B5A70", VA = "0x1879B6670")]
	private void JLPKIICMNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x79B62A0", Offset = "0x79B56A0", VA = "0x1879B62A0")]
	private void CCLEEEAOLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x79B6850", Offset = "0x79B5C50", VA = "0x1879B6850")]
	private void MGBBOEMJAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79B63B0", Offset = "0x79B57B0", VA = "0x1879B63B0")]
	private void DJBEBKHKOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x79B6570", Offset = "0x79B5970", VA = "0x1879B6570")]
	private void JIHFLMAFCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x79B6DD0", Offset = "0x79B61D0", VA = "0x1879B6DD0")]
	private NativeList<Entity> PFAIEFIKPIN(NativeArray<Entity> CCIGPBFJEAO)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79B64B0", Offset = "0x79B58B0", VA = "0x1879B64B0")]
	private NativeList<Entity> HEBCDNBBIKM(NativeArray<Entity> CCIGPBFJEAO)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x79B6510", Offset = "0x79B5910", VA = "0x1879B6510")]
	private void IOPAPKIMLEJ(NativeArray<Entity> CCIGPBFJEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public DGACJCAIDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[IFLAJJBFDLA]
public sealed class CLFPNIIIFOE : NMHIKCLDHNA, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery HGFPEFIDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery IIDKNKCONOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery KPGMPLHBPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HEOPOKIOLJB EIDMDLDPIMC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79B5E40", Offset = "0x79B5240", VA = "0x1879B5E40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79B5A20", Offset = "0x79B4E20", VA = "0x1879B5A20", Slot = "15")]
	public override void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79B6010", Offset = "0x79B5410", VA = "0x1879B6010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79B53A0", Offset = "0x79B47A0", VA = "0x1879B53A0")]
	private void GICCFLBLJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x79B4D20", Offset = "0x79B4120", VA = "0x1879B4D20")]
	private void FKIDKEMMCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79B5A80", Offset = "0x79B4E80", VA = "0x1879B5A80")]
	private void JOEKMKDPOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79B6040", Offset = "0x79B5440", VA = "0x1879B6040")]
	private bool PCPLCKMLHHC(Entity PPBBFEJHKOL, [Out] EHIJPMKNJBK FJIJIKAGHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79B4B70", Offset = "0x79B3F70", VA = "0x1879B4B70")]
	private bool EPKKBEMGLCB(Entity PPBBFEJHKOL, [Out] EHIJPMKNJBK FJIJIKAGHGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public CLFPNIIIFOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[IFLAJJBFDLA]
public sealed class JKDEOHBHGAH : NMHIKCLDHNA
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery LDEKJJOHPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery MJONDPKPENN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x79C0B80", Offset = "0x79BFF80", VA = "0x1879C0B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x79C0CD0", Offset = "0x79C00D0", VA = "0x1879C0CD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x79C0880", Offset = "0x79BFC80", VA = "0x1879C0880")]
	private void GICCFLBLJPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x79C0590", Offset = "0x79BF990", VA = "0x1879C0590")]
	private void FKIDKEMMCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public JKDEOHBHGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HFKPCHMFLKL : NMHIKCLDHNA, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct EELBAJNIAEL : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob KDOCJBHINGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob OGIHIIPIMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob LLIBJPHPION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob GONIJACIKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle KFGOODOFBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<GOFGDICMIGJ> INEDKKPBBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> OLDMPDPLEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> NEGIHCLJBAP;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x79B74D0", Offset = "0x79B68D0", VA = "0x1879B74D0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x79B73F0", Offset = "0x79B67F0", VA = "0x1879B73F0")]
		private void ACGAMKPCHGH(EntityQueryInJob MHFPDMHHOMF, NativeList<Entity> EHDIHIHINHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct OJJBJCFHBMF : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle KFGOODOFBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<GOFGDICMIGJ> INEDKKPBBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> EHDIHIHINHK;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79CB500", Offset = "0x79CA900", VA = "0x1879CB500", Slot = "4")]
		public void Execute(ArchetypeChunk HGKDBENILNI, int ECKKOKABHOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct MOKHEEPFEOP : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle KFGOODOFBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> HIBGAAAMBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<JJGGMABAONN> DMNDOELAOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<HNKGKNJPKED> GCPOKNIEFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<GOFGDICMIGJ> JFNKIPEAAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> GBBKILMBMHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<JJGGMABAONN> AGHJBIPFMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<EHIJPMKNJBK> PHDFLDOMBPM;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x79C45F0", Offset = "0x79C39F0", VA = "0x1879C45F0", Slot = "4")]
		public void Execute(ArchetypeChunk HGKDBENILNI, int ECKKOKABHOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery KDOCJBHINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery OGIHIIPIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery LLIBJPHPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery GONIJACIKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery JPEAKIFOMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery MJIEJCCBCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery LNNINLBOLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HEOPOKIOLJB BCFACOHFFNF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x79BF080", Offset = "0x79BE480", VA = "0x1879BF080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x79BE840", Offset = "0x79BDC40", VA = "0x1879BE840", Slot = "15")]
	public override void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x79BF600", Offset = "0x79BEA00", VA = "0x1879BF600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x79BE240", Offset = "0x79BD640", VA = "0x1879BE240")]
	private void IBMMGFCOEDK(NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD, int PCDPCHIIDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x79BEC30", Offset = "0x79BE030", VA = "0x1879BEC30")]
	private void KNNCMIMBFCL(NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD, int PKGENKILGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x79BDE00", Offset = "0x79BD200", VA = "0x1879BDE00")]
	private void CONNNMPBOBM(NativeParallelHashSet<EHIJPMKNJBK> EDOBNJAGIKD, int DEEABKHKHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79BE8A0", Offset = "0x79BDCA0", VA = "0x1879BE8A0")]
	private void KMACMCPAOCF(NativeParallelHashSet<EHIJPMKNJBK> IMHOPJOLOIK, int CGNDECKPHOI, int HANHKEBCEHE, int BHHAPHHBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x79BDC50", Offset = "0x79BD050", VA = "0x1879BDC50")]
	private void CLDKJAODLJG(Entity KAMPJJKGPKH, BLIJJMIHMBP FNCPHNIFLGI, EHIJPMKNJBK FJIJIKAGHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public HFKPCHMFLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class PAKLBEAFJDB : NMHIKCLDHNA
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery KPNCIFGJNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery MNMJKPIJAPK;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x79CB750", Offset = "0x79CAB50", VA = "0x1879CB750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x79CB990", Offset = "0x79CAD90", VA = "0x1879CB990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public PAKLBEAFJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class APKEJKDJIPB : NMHIKCLDHNA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct AJKNIGOFAGA : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery CJOKDHIHJOA;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x79B2320", Offset = "0x79B1720", VA = "0x1879B2320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x79B2460", Offset = "0x79B1860", VA = "0x1879B2460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public APKEJKDJIPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IFLAJJBFDLA]
internal class FCGJELJHEPN : NMHIKCLDHNA
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class AELMLFMDNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery GOCIMLFKCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery JKAHNKJFOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public BPPBBEGBEBC CEAOGEFEBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType COALLHOBCCG;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AELMLFMDNII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void BPPBBEGBEBC(NativeArray<BLIJJMIHMBP> ENGGEIHHCEE, GGLOKDKCJOE PINNJHFODKP);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<AELMLFMDNII> CILBNFANGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PEDHLFBNIMO GLCLMIIIONA;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x79B7CD0", Offset = "0x79B70D0", VA = "0x1879B7CD0", Slot = "15")]
	public override void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x79B7ED0", Offset = "0x79B72D0", VA = "0x1879B7ED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x79B8060", Offset = "0x79B7460", VA = "0x1879B8060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3597220", Offset = "0x3596620", VA = "0x183597220")]
	private void HCJIKOEDJPP<T>(BPPBBEGBEBC CEAOGEFEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x79B7B30", Offset = "0x79B6F30", VA = "0x1879B7B30")]
	private static void EFJHPEFMDHN(NativeArray<BLIJJMIHMBP> KKPPEGLJPBD, GGLOKDKCJOE AHCPLALOHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x79B7D30", Offset = "0x79B7130", VA = "0x1879B7D30")]
	private static void JEMCLEKBFNO(NativeArray<BLIJJMIHMBP> KKPPEGLJPBD, GGLOKDKCJOE AHCPLALOHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x79B7990", Offset = "0x79B6D90", VA = "0x1879B7990")]
	private static void DDHBDNENJAI(NativeArray<BLIJJMIHMBP> KKPPEGLJPBD, GGLOKDKCJOE AHCPLALOHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public FCGJELJHEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IFLAJJBFDLA]
public sealed class BBOILBOCLHD : NMHIKCLDHNA
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery MHFPDMHHOMF;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x79B26A0", Offset = "0x79B1AA0", VA = "0x1879B26A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct JCKLNHHCFHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS FGJIBBMFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData OCPOKNEEKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public MADKHAHICNA BCOGHILOCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 DLCODMKGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool BEHFKEHPLMC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[JACFHLPNAMJ(Lifetime.LoadInstance)]
public struct KPFGGDEBNAI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity MILOFGFNFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> HFFJFPDMANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> MCIMKEDALKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<JCKLNHHCFHN> CELLPKPNIDP;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79C35C0", Offset = "0x79C29C0", VA = "0x1879C35C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(ALCALLLBIKE), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class ALCALLLBIKE : IHCCKBEFLCO, AOPBNJCLOCO, HNDDMAHOBCN, AMKGLADJPMK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct IKADMHEIMAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly ALCALLLBIKE PBIFOHNGFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool PGECKFIAOBJ;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1681620", Offset = "0x1680A20", VA = "0x181681620")]
		public IKADMHEIMAM(ALCALLLBIKE PBIFOHNGFLL, bool PGECKFIAOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x79C0380", Offset = "0x79BF780", VA = "0x1879C0380")]
		public Queue<PFPIJCIGJGN>.Enumerator NHFIHKFCIDL()
		{
			return default(Queue<PFPIJCIGJGN>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79C0040", Offset = "0x79BF440", VA = "0x1879C0040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private IKEEOMDEEKE PMCCMOAGFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private EIOPLOFBIEE AMBMEFABFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<HDHHCFJCJDP>> EOMONOOPJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> EAPEMCBJMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<BLIJJMIHMBP> GCIHGLGPHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HNCNPCPDECO<PFPIJCIGJGN> EPEPCHKMIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private HNCNPCPDECO<KPFGGDEBNAI> CABECPLFOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private HNCNPCPDECO<MCLIAMMGIHC> GPCMNHKADFL;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79B1970", Offset = "0x79B0D70", VA = "0x1879B1970", Slot = "4")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79B1340", Offset = "0x79B0740", VA = "0x1879B1340")]
	public void FLIAHCKMPDD(NativeList<HDHHCFJCJDP> FBNICMAOOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x79B1810", Offset = "0x79B0C10", VA = "0x1879B1810")]
	public void HGEMNLPAMDL(Entity PBIFOHNGFLL, [In] EIEPCDCEBED<GameObject> JOIPBHLLIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x79B1780", Offset = "0x79B0B80", VA = "0x1879B1780")]
	public void GBPNGIACJKI(NativeList<BLIJJMIHMBP> KKPPEGLJPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x79B2070", Offset = "0x79B1470", VA = "0x1879B2070")]
	public void OKJFGDGKHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x79B1B70", Offset = "0x79B0F70", VA = "0x1879B1B70")]
	public void MHGDAHLKACA(BMEMPFINILP ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x79B11B0", Offset = "0x79B05B0", VA = "0x1879B11B0")]
	public JobHandle BEIDLLLANIE([In] PFPIJCIGJGN EIGJGBPHOMK, JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x79B1250", Offset = "0x79B0650", VA = "0x1879B1250")]
	public JobHandle BEIDLLLANIE([In] KPFGGDEBNAI EIGJGBPHOMK, JobHandle BODEMHDIPOA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76B0290", Offset = "0x76AF690", VA = "0x1876B0290")]
	public IKADMHEIMAM JOHJLEJGIHG(bool PGECKFIAOBJ)
	{
		return default(IKADMHEIMAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x79B12F0", Offset = "0x79B06F0", VA = "0x1879B12F0")]
	public BMIBNAPKGIM<KPFGGDEBNAI> DIKDKJELOGD()
	{
		return default(BMIBNAPKGIM<KPFGGDEBNAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x79B2020", Offset = "0x79B1420", VA = "0x1879B2020")]
	public BMIBNAPKGIM<MCLIAMMGIHC> OAPDMNACPAP()
	{
		return default(BMIBNAPKGIM<MCLIAMMGIHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x79B1410", Offset = "0x79B0810", VA = "0x1879B1410")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x79B1630", Offset = "0x79B0A30", VA = "0x1879B1630", Slot = "5")]
	public void GBFOCOOFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x79B1710", Offset = "0x79B0B10", VA = "0x1879B1710", Slot = "6")]
	private void GBNLIKPCGPH(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x106FB60", Offset = "0x106EF60", VA = "0x18106FB60", Slot = "7")]
	private void IKBMCJJKAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ALCALLLBIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JFAGICJAKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS FGJIBBMFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData OCPOKNEEKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public IJKALMPDIAP NFHKMOGHIBC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[JACFHLPNAMJ(Lifetime.LoadInstance)]
public struct PFPIJCIGJGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity MILOFGFNFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> CCIGPBFJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> HFFJFPDMANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> MCIMKEDALKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<JMJNMGPMDKG> CLKEDPBHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<HDHHCFJCJDP> FBNICMAOOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<JFAGICJAKLK> BMENEFCADFH;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x79CBF00", Offset = "0x79CB300", VA = "0x1879CBF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x79CBF10", Offset = "0x79CB310", VA = "0x1879CBF10")]
	public void JNOHBLLEJCJ(bool PGECKFIAOBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(BNNOKEOBINI), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class BNNOKEOBINI : CJOJBMACFLA, HNDDMAHOBCN, AMKGLADJPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private ALCALLLBIKE BNOKELHMFDO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x79B43B0", Offset = "0x79B37B0", VA = "0x1879B43B0", Slot = "4")]
	public void DEOHLEFHHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x79B43D0", Offset = "0x79B37D0", VA = "0x1879B43D0", Slot = "5")]
	private void GBNLIKPCGPH(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x104C660", Offset = "0x104BA60", VA = "0x18104C660", Slot = "6")]
	private void IKBMCJJKAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public BNNOKEOBINI()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : NMHIKCLDHNA, IHCCKBEFLCO
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[ReadOnly]
			public NativeParallelHashMap<int, MADKHAHICNA> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<JCKLNHHCFHN> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x79B91F0", Offset = "0x79B85F0", VA = "0x1879B91F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public NativeArray<HDHHCFJCJDP> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<JMJNMGPMDKG> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<JFAGICJAKLK> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x79B9590", Offset = "0x79B8990", VA = "0x1879B9590", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x79B6160", Offset = "0x79B5560", VA = "0x1879B6160", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x79CC030", Offset = "0x79CB430", VA = "0x1879CC030")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x79CBFE0", Offset = "0x79CB3E0", VA = "0x1879CBFE0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 FFKNKOLJCDH(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x79C3C90", Offset = "0x79C3090", VA = "0x1879C3C90", Slot = "5")]
				public float3 GNPBLDKFFHE(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x79C3C50", Offset = "0x79C3050", VA = "0x1879C3C50", Slot = "4")]
				public float3 FFKNKOLJCDH(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x79C96E0", Offset = "0x79C8AE0", VA = "0x1879C96E0", Slot = "4")]
				public float3 FFKNKOLJCDH(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeArray<JMJNMGPMDKG> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<HDHHCFJCJDP> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x79B9FB0", Offset = "0x79B93B0", VA = "0x1879B9FB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x79BC570", Offset = "0x79BB970", VA = "0x1879BC570")]
			private void LOJDKLODKID(NativeList<PointSrcData> srcData, NativeList<HDHHCFJCJDP> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x79BB800", Offset = "0x79BAC00", VA = "0x1879BB800")]
			public static Vector3 JBHECNJJFGC(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x79BA610", Offset = "0x79B9A10", VA = "0x1879BA610")]
			public static quaternion FKBOEPOCBLP(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x79B9CB0", Offset = "0x79B90B0", VA = "0x1879B9CB0")]
			private static quaternion EGCKNDDNFJB(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x79BBE50", Offset = "0x79BB250", VA = "0x1879BBE50")]
			private static float3 LALKABBJAJO(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x79BBC10", Offset = "0x79BB010", VA = "0x1879BBC10")]
			private static quaternion JFCFMGGGDMM(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x79BD4F0", Offset = "0x79BC8F0", VA = "0x1879BD4F0")]
			private static HDHHCFJCJDP NMFMHDOAFBE(int idx, NativeList<PointSrcData> srcData)
			{
				return default(HDHHCFJCJDP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3CFE8D0", Offset = "0x3CFDCD0", VA = "0x183CFE8D0")]
			private void BHHIMGNKPIF<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x79BA9F0", Offset = "0x79B9DF0", VA = "0x1879BA9F0")]
			private void JBDIOHHFNLG(NativeList<PointSrcData> sourcePoints, NativeList<HDHHCFJCJDP> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x79BC020", Offset = "0x79BB420", VA = "0x1879BC020")]
			public static float LBPAHKFLEKD(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x79BC1A0", Offset = "0x79BB5A0", VA = "0x1879BC1A0")]
			private static quaternion LFBEEEOMBHG(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x79BBCA0", Offset = "0x79BB0A0", VA = "0x1879BBCA0")]
			private static HDHHCFJCJDP KGEMJCDKCCO(PointSrcData point)
			{
				return default(HDHHCFJCJDP);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x79BBDC0", Offset = "0x79BB1C0", VA = "0x1879BBDC0")]
			private static HDHHCFJCJDP KGEMJCDKCCO(float3 pos, quaternion rot, float radius)
			{
				return default(HDHHCFJCJDP);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x79BD450", Offset = "0x79BC850", VA = "0x1879BD450")]
			private static bool NDCNOJMIJCL(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x79B9EE0", Offset = "0x79B92E0", VA = "0x1879B9EE0")]
			private static float3 EOGMKMHIOAK(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x79BA840", Offset = "0x79B9C40", VA = "0x1879BA840")]
			public static float3 GPKBIKKNGAP(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x79BA690", Offset = "0x79B9A90", VA = "0x1879BA690")]
			public static float3 GNPBLDKFFHE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x79BD760", Offset = "0x79BCB60", VA = "0x1879BD760")]
			private static quaternion OJJBOOBKEKL(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x79BC390", Offset = "0x79BB790", VA = "0x1879BC390")]
			private static float LLNBGDEIHIM(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x79CE6F0", Offset = "0x79CDAF0", VA = "0x1879CE6F0")]
			private void LGJGGKAKAFN(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x79CE600", Offset = "0x79CDA00", VA = "0x1879CE600", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<HDHHCFJCJDP> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x79CFA20", Offset = "0x79CEE20", VA = "0x1879CFA20")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x79CFA10", Offset = "0x79CEE10", VA = "0x1879CFA10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeList<HDHHCFJCJDP> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x79CF9C0", Offset = "0x79CEDC0", VA = "0x1879CF9C0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x79CF9B0", Offset = "0x79CEDB0", VA = "0x1879CF9B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NativeList<JCKLNHHCFHN> data;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x79B98E0", Offset = "0x79B8CE0", VA = "0x1879B98E0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x79B98D0", Offset = "0x79B8CD0", VA = "0x1879B98D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<JMJNMGPMDKG> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<JFAGICJAKLK> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x79B9AB0", Offset = "0x79B8EB0", VA = "0x1879B9AB0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x79B9AA0", Offset = "0x79B8EA0", VA = "0x1879B9AA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x79CF590", Offset = "0x79CE990", VA = "0x1879CF590")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x79CF580", Offset = "0x79CE980", VA = "0x1879CF580", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private GMOMONKDIAO replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IKEEOMDEEKE objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private ALCALLLBIKE bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private CEBEANBCDAI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79CD700", Offset = "0x79CCB00", VA = "0x1879CD700", Slot = "15")]
		public override void InitReferences(INNCJKBLPNO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x79CF240", Offset = "0x79CE640", VA = "0x1879CF240", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x79CF330", Offset = "0x79CE730", VA = "0x1879CF330", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x79CF390", Offset = "0x79CE790", VA = "0x1879CF390", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x79CEBB0", Offset = "0x79CDFB0", VA = "0x1879CEBB0")]
		private JobHandle OMEFIBINDIB(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x79CDBC0", Offset = "0x79CCFC0", VA = "0x1879CDBC0")]
		private JobHandle KDGDHOEPKBK(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x79CC050", Offset = "0x79CB450", VA = "0x1879CC050")]
		private JobHandle OPMCHIHJPDM(NativeArray<int> pointCount, NativeList<HDHHCFJCJDP> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x79CCCB0", Offset = "0x79CC0B0", VA = "0x1879CCCB0")]
		private JobHandle PGMMOEBNHHJ(NativeList<HDHHCFJCJDP> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x79CC0F0", Offset = "0x79CB4F0", VA = "0x1879CC0F0")]
		private JobHandle BEKLOJCCNKF(EntityQuery query, NativeList<JMJNMGPMDKG> splinePointRanges, NativeList<HDHHCFJCJDP> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA90", Offset = "0x79CDE90", VA = "0x1879CEA90")]
		private JobHandle MLPFFOLKHIK(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x79CCD50", Offset = "0x79CC150", VA = "0x1879CCD50")]
		private JobHandle HELPEPDLEGA(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x79CD380", Offset = "0x79CC780", VA = "0x1879CD380")]
		private JobHandle IMDJEICDFJA(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JCKLNHHCFHN> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x79CE7D0", Offset = "0x79CDBD0", VA = "0x1879CE7D0")]
		private JobHandle MILLDAINNEN(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JMJNMGPMDKG> splinePointRanges, [Out] NativeList<JFAGICJAKLK> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x79CE280", Offset = "0x79CD680", VA = "0x1879CE280")]
		private JobHandle KNFLOBNJMCO(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x79CCE70", Offset = "0x79CC270", VA = "0x1879CCE70")]
		private JobHandle IMDHDKDLOGD(EntityQuery query, NativeList<JCKLNHHCFHN> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x79CD7A0", Offset = "0x79CCBA0", VA = "0x1879CD7A0")]
		private static NativeParallelHashMap<int, MADKHAHICNA> JJMNDAANBJP()
		{
			return default(NativeParallelHashMap<int, MADKHAHICNA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x79CC6D0", Offset = "0x79CBAD0", VA = "0x1879CC6D0")]
		private JobHandle DKBGCMEIJAC(EntityQuery query, NativeList<JMJNMGPMDKG> splinePointRanges, NativeList<HDHHCFJCJDP> splinePointData, NativeList<JFAGICJAKLK> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x79CD620", Offset = "0x79CCA20", VA = "0x1879CD620")]
		private JobHandle IMMPNIAGFDD(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x79CC050", Offset = "0x79CB450", VA = "0x1879CC050")]
		private JobHandle AGJGLFLOFFG(NativeArray<int> pointCount, NativeList<HDHHCFJCJDP> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x79CCCB0", Offset = "0x79CC0B0", VA = "0x1879CCCB0")]
		private JobHandle FDBGIDPAEAD(NativeList<HDHHCFJCJDP> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x79CCA70", Offset = "0x79CBE70", VA = "0x1879CCA70")]
		private JobHandle ECEFPCGBDCK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JCKLNHHCFHN> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x79CC5C0", Offset = "0x79CB9C0", VA = "0x1879CC5C0")]
		private JobHandle COBFBCICDAL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JMJNMGPMDKG> ranges, NativeList<JFAGICJAKLK> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x79CCB60", Offset = "0x79CBF60", VA = "0x1879CCB60")]
		private JobHandle ELMNHLNJHIA(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x79CEEF0", Offset = "0x79CE2F0", VA = "0x1879CEEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class FECHLOLABDE : AKIFIDDOCJA, IHCCKBEFLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private ALCALLLBIKE BNOKELHMFDO;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x79B85E0", Offset = "0x79B79E0", VA = "0x1879B85E0", Slot = "14")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79B8630", Offset = "0x79B7A30", VA = "0x1879B8630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
	public FECHLOLABDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class NGIADNOJGJD : NMHIKCLDHNA, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct AMNEDDLJEKE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager EDIIKMBGJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private BDHDJKMPPAE<T> DALNELLCDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int KDCAMOIGIMA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4A149D0", Offset = "0x4A13DD0", VA = "0x184A149D0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4A14DB0", Offset = "0x4A141B0", VA = "0x184A14DB0")]
		public AMNEDDLJEKE(EntityManager EDIIKMBGJIA, BDHDJKMPPAE<T> DALNELLCDHC, NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4353260", Offset = "0x4352660", VA = "0x184353260")]
		public AMNEDDLJEKE<T> NHFIHKFCIDL()
		{
			return default(AMNEDDLJEKE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4A14C30", Offset = "0x4A14030", VA = "0x184A14C30")]
		public bool OPMFPOJCPHB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ABDDJEPKCOD IPFDKDJFOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EIOPLOFBIEE AMBMEFABFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private ALCALLLBIKE BNOKELHMFDO;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79C6C30", Offset = "0x79C6030", VA = "0x1879C6C30", Slot = "15")]
	public override void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x79C5490", Offset = "0x79C4890", VA = "0x1879C5490")]
	public void DDMNLPJLEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x79C8300", Offset = "0x79C7700", VA = "0x1879C8300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79C54C0", Offset = "0x79C48C0", VA = "0x1879C54C0")]
	private void EKHPOFFHEMA(MCLIAMMGIHC EIGJGBPHOMK, Mesh[] HMIMDNDEDBH, NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3799D10", Offset = "0x3799110", VA = "0x183799D10")]
	private AMNEDDLJEKE<T> JFMIBNBKDAN<T>(BDHDJKMPPAE<T> DALNELLCDHC, NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB) where T : struct
	{
		return default(AMNEDDLJEKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x79C7B80", Offset = "0x79C6F80", VA = "0x1879C7B80")]
	private void NLLOMMGNJGK(Transform PBIFOHNGFLL, NativeArray<PEMDAPAFPNP> ONMDLAIDKNO, EIEPCDCEBED<GameObject> HKMBJNDOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x79C65A0", Offset = "0x79C59A0", VA = "0x1879C65A0")]
	private void ELMPPAEIPGO(Transform PBIFOHNGFLL, NativeArray<EAHBELBDKGJ> IPDBBHAFGPD, EIEPCDCEBED<GameObject> HKMBJNDOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x79C7200", Offset = "0x79C6600", VA = "0x1879C7200")]
	private void JMCINFPECGH(Transform PBIFOHNGFLL, NativeArray<LJEIHLPFPLH> ECJPMAAMNAD, EIEPCDCEBED<GameObject> HKMBJNDOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79C75F0", Offset = "0x79C69F0", VA = "0x1879C75F0")]
	private void KMKCNGJENPB(Transform PBIFOHNGFLL, NativeArray<MNHLGOHDBBD> HMIMDNDEDBH, Mesh[] FBOFCDOLOHJ, EIEPCDCEBED<GameObject> HKMBJNDOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x79C7A30", Offset = "0x79C6E30", VA = "0x1879C7A30")]
	private static void NLIPKIMGCLD(NativeParallelHashSet<Entity> CCIGPBFJEAO, NativeParallelHashSet<Entity> NIHDOAOFDBO, NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x79C6A70", Offset = "0x79C5E70", VA = "0x1879C6A70")]
	private static void HACPDDBFOOE(NativeList<Entity> JMHKEMEJOPH, NativeArray<EntityRemapUtility.EntityRemapInfo> HKAIMIGDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x79C4920", Offset = "0x79C3D20", VA = "0x1879C4920")]
	private NativeParallelHashMap<Entity, HNKGKNJPKED> CNFGJHMGBKE(ALCALLLBIKE.IKADMHEIMAM HIFKPCNOMKG, BMIBNAPKGIM<KPFGGDEBNAI> ACEOIOFBFMK, List<GameObject> HKMBJNDOMJG)
	{
		return default(NativeParallelHashMap<Entity, HNKGKNJPKED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x79C6B30", Offset = "0x79C5F30", VA = "0x1879C6B30")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HIKCICEHEAD(Entity IBCKLHGJOPI)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x79C6CB0", Offset = "0x79C60B0", VA = "0x1879C6CB0")]
	private void JGLOMJPKGPN(NativeList<Entity> HFOGHNFHFJI, NativeList<Entity> AECNDHOCMHF, NativeParallelHashMap<Entity, HNKGKNJPKED> APCLJJJNGFL, NativeList<JMJNMGPMDKG> IIAKNONBPGI, NativeList<HDHHCFJCJDP> IHHFADJOHEH, NativeList<JFAGICJAKLK> EOMONOOPJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x79C7F10", Offset = "0x79C7310", VA = "0x1879C7F10")]
	private void OAOKBNMONBE(NativeList<Entity> CCIGPBFJEAO, NativeList<Entity> HFFJFPDMANK, NativeParallelHashMap<Entity, HNKGKNJPKED> APCLJJJNGFL, NativeList<JCKLNHHCFHN> CELLPKPNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79B2690", Offset = "0x79B1A90", VA = "0x1879B2690")]
	public NGIADNOJGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class LIBBIANHNCN : MBIPDLNJDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS FGJIBBMFFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ABFOBKHKCPD PBIFOHNGFLL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject CPDDEOPCOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS MHFKHLGLACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x79C3920", Offset = "0x79C2D20", VA = "0x1879C3920", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 GIGJPGKFAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x79C3880", Offset = "0x79C2C80", VA = "0x1879C3880", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 KKOJHDEBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x79C38D0", Offset = "0x79C2CD0", VA = "0x1879C38D0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 KDHMNNPLOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x79C3650", Offset = "0x79C2A50", VA = "0x1879C3650", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x79C3740", Offset = "0x79C2B40", VA = "0x1879C3740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion FGLMKOGKJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x79C36A0", Offset = "0x79C2AA0", VA = "0x1879C36A0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x79C37E0", Offset = "0x79C2BE0", VA = "0x1879C37E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 PGANGAIHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x79C3790", Offset = "0x79C2B90", VA = "0x1879C3790", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 EDMMCBPKGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x79C3830", Offset = "0x79C2C30", VA = "0x1879C3830", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 CCBJGPPHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x79C36F0", Offset = "0x79C2AF0", VA = "0x1879C36F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x79C3A00", Offset = "0x79C2E00", VA = "0x1879C3A00")]
	public LIBBIANHNCN(UniformTRS FGJIBBMFFAD, ABFOBKHKCPD PBIFOHNGFLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class LKKMOFGLMIL : LIBBIANHNCN, JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float DIOGLFEGGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 KHGAPLNHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly OCHPJGPHIOB FECIEDEIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly FECNNNMEDDD MFMLBKEBCKM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private AKBPOJOBHNP LFDJKLPKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x79C3AA0", Offset = "0x79C2EA0", VA = "0x1879C3AA0", Slot = "17")]
		get
		{
			return default(AKBPOJOBHNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS BLDDNHAMHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x79C3AF0", Offset = "0x79C2EF0", VA = "0x1879C3AF0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float POGIIBNAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xB40D00", Offset = "0xB40100", VA = "0x180B40D00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IFGJMJDLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x79C3A50", Offset = "0x79C2E50", VA = "0x1879C3A50", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private OCHPJGPHIOB AJFPNGODHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xDA2D00", Offset = "0xDA2100", VA = "0x180DA2D00", Slot = "21")]
		get
		{
			return default(OCHPJGPHIOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private FECNNNMEDDD GLKBIIKFHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE660B0", Offset = "0xE654B0", VA = "0x180E660B0", Slot = "22")]
		get
		{
			return default(FECNNNMEDDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool FKICGHHHKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CFMOGMFPPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79C3BD0", Offset = "0x79C2FD0", VA = "0x1879C3BD0")]
	protected LKKMOFGLMIL(UniformTRS FGJIBBMFFAD, ABFOBKHKCPD PBIFOHNGFLL, float DIOGLFEGGFF, float3 KHGAPLNHGHG, OCHPJGPHIOB FECIEDEIBMC, FECNNNMEDDD MFMLBKEBCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class BMJPHHMFCMI : MBIPDLNJDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly PMMHELJLBHE NFJLMELBBOO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected ABFOBKHKCPD NIIDGBCBCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x1057060", Offset = "0x1056460", VA = "0x181057060")]
		get
		{
			return default(ABFOBKHKCPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity IAFDAGDDGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x79B3F10", Offset = "0x79B3310", VA = "0x1879B3F10")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected IKEEOMDEEKE PPBBAPHENCF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x79B43A0", Offset = "0x79B37A0", VA = "0x1879B43A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected MEOMFJKIPJN GODMPEMOLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x79B3EB0", Offset = "0x79B32B0", VA = "0x1879B3EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected GGPNACIJLGA MJGFNPKHNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79B3C20", Offset = "0x79B3020", VA = "0x1879B3C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject CPDDEOPCOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x79B3920", Offset = "0x79B2D20", VA = "0x1879B3920", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS MHFKHLGLACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x107E050", Offset = "0x107D450", VA = "0x18107E050", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 GIGJPGKFAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x79B40F0", Offset = "0x79B34F0", VA = "0x1879B40F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 KKOJHDEBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x79B41E0", Offset = "0x79B35E0", VA = "0x1879B41E0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 KDHMNNPLOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79B36D0", Offset = "0x79B2AD0", VA = "0x1879B36D0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79B3B10", Offset = "0x79B2F10", VA = "0x1879B3B10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion FGLMKOGKJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x79B3800", Offset = "0x79B2C00", VA = "0x1879B3800", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x79B3DA0", Offset = "0x79B31A0", VA = "0x1879B3DA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 PGANGAIHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x79B3CB0", Offset = "0x79B30B0", VA = "0x1879B3CB0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 EDMMCBPKGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x79B3F30", Offset = "0x79B3330", VA = "0x1879B3F30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 CCBJGPPHNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x79B3950", Offset = "0x79B2D50", VA = "0x1879B3950", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xD3FD70", Offset = "0xD3F170", VA = "0x180D3FD70")]
	protected BMJPHHMFCMI(PMMHELJLBHE FAIMNGLIIAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x79B4370", Offset = "0x79B3770", VA = "0x1879B4370")]
	public static AKBPOJOBHNP MDKCMNAEKLA(BMJPHHMFCMI CFOOONLCHLJ)
	{
		return default(AKBPOJOBHNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MGGJKKPCGEB
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x79C43B0", Offset = "0x79C37B0", VA = "0x1879C43B0")]
	public static void AAAFLFHDCBN(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OHOCDJCPLKO
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x79CADF0", Offset = "0x79CA1F0", VA = "0x1879CADF0")]
	public static void PHPFJJOFMEE(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA, BMEMPFINILP JKDPAKGEHHH, IKEEOMDEEKE NMKGGMBKIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x79CB1F0", Offset = "0x79CA5F0", VA = "0x1879CB1F0")]
	public static void PLECJPKJBOG(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA, BMEMPFINILP JKDPAKGEHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x79CAD70", Offset = "0x79CA170", VA = "0x1879CAD70")]
	public static NativeList<Entity> HEBCDNBBIKM(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x79CADB0", Offset = "0x79CA1B0", VA = "0x1879CADB0")]
	public static NativeList<Entity> PFAIEFIKPIN(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x79CAB10", Offset = "0x79C9F10", VA = "0x1879CAB10")]
	private static NativeList<Entity> HEBCDNBBIKM(NativeArray<Entity> CCIGPBFJEAO, EntityManager EDIIKMBGJIA, bool NNFIEHLNIAE)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class IJKPONFONIE : BMJPHHMFCMI, JGBANNPBHOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float DIOGLFEGGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 KHGAPLNHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private OCHPJGPHIOB FECIEDEIBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FECNNNMEDDD MFMLBKEBCKM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager KGDFMKAAMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x79D0550", Offset = "0x79CF950", VA = "0x1879D0550")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GGAPNNOMOKP KJGELGKFGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x79D04F0", Offset = "0x79CF8F0", VA = "0x1879D04F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData JAIOLGOCCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x79D0770", Offset = "0x79CFB70", VA = "0x1879D0770")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private AKBPOJOBHNP LFDJKLPKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x79B4370", Offset = "0x79B3770", VA = "0x1879B4370", Slot = "17")]
		get
		{
			return default(AKBPOJOBHNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float POGIIBNAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xE2E720", Offset = "0xE2DB20", VA = "0x180E2E720", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IFGJMJDLPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x14A4780", Offset = "0x14A3B80", VA = "0x1814A4780", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private OCHPJGPHIOB AJFPNGODHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560", Slot = "21")]
		get
		{
			return default(OCHPJGPHIOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FECNNNMEDDD GLKBIIKFHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xBB54C0", Offset = "0xBB48C0", VA = "0x180BB54C0", Slot = "22")]
		get
		{
			return default(FECNNNMEDDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS BLDDNHAMHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x79D0860", Offset = "0x79CFC60", VA = "0x1879D0860", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CFMOGMFPPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool FKICGHHHKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79D0890", Offset = "0x79CFC90", VA = "0x1879D0890")]
	protected IJKPONFONIE(PMMHELJLBHE FAIMNGLIIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x79D05E0", Offset = "0x79CF9E0", VA = "0x1879D05E0", Slot = "26")]
	public virtual void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class NMHIKCLDHNA : AKIFIDDOCJA, IHCCKBEFLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected IKEEOMDEEKE NMKGGMBKIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private KAMIOLGOEIG CLKKBOEEKDJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected BMEMPFINILP LJEKMEGMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x79D0C10", Offset = "0x79D0010", VA = "0x1879D0C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected GGLOKDKCJOE DLDEMKENGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x79D0BC0", Offset = "0x79CFFC0", VA = "0x1879D0BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool GIDNGKLOKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x79D0CD0", Offset = "0x79D00D0", VA = "0x1879D0CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x79D0C60", Offset = "0x79D0060", VA = "0x1879D0C60", Slot = "15")]
	public virtual void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
	protected NMHIKCLDHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LGNGFMFKCCG
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x79D08C0", Offset = "0x79CFCC0", VA = "0x1879D08C0")]
	public static void GJGLNCPKECH(NativeArray<Entity> HFOGHNFHFJI, EntityManager EDIIKMBGJIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3081860656
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x79D0FC0", Offset = "0x79D03C0", VA = "0x1879D0FC0")]
	public static void NLACCDPEEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x79D0FB0", Offset = "0x79D03B0", VA = "0x1879D0FB0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NPAAEHBBMNH : ContainerPropertyBag<HKHKECDPPBL>
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x79D0D90", Offset = "0x79D0190", VA = "0x1879D0D90")]
	public NPAAEHBBMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class MCFGPKGCGHI : ContainerPropertyBag<IGJMOENMPGM>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x79D0B00", Offset = "0x79CFF00", VA = "0x1879D0B00")]
	public MCFGPKGCGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class MMDBKHMCBNH : ContainerPropertyBag<JNLIFAMNBFJ>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x79D0B60", Offset = "0x79CFF60", VA = "0x1879D0B60")]
	public MMDBKHMCBNH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x79D0DF0", Offset = "0x79D01F0", VA = "0x1879D0DF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
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
