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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7180C80", Offset = "0x7180080", VA = "0x187180C80", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1A51480", Offset = "0x1A50880", VA = "0x181A51480", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x718A7E0", Offset = "0x7189BE0", VA = "0x18718A7E0")]
		private void PKLDHDIFILK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x718AC60", Offset = "0x718A060", VA = "0x18718AC60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x718ACC0", Offset = "0x718A0C0", VA = "0x18718ACC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HDJODLELFML
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x717D280", Offset = "0x717C680", VA = "0x18717D280")]
	public static Quaternion GABIKJGPDGF([In] this IDNDILFAIKH AHAAMINLDGL, [In] Vector3 LIDLBHGKPBN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PILMDNDHCAH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7184110", Offset = "0x7183510", VA = "0x187184110")]
	public static bool HCCFLEOLLOH(this EIGHLLMDFND GNDJONLPBDP, MCBOHJAEBBG NMJPBABDHGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71858B0", Offset = "0x7184CB0", VA = "0x1871858B0")]
	public static bool OGDKGLFJCCC(this EIGHLLMDFND GNDJONLPBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71840E0", Offset = "0x71834E0", VA = "0x1871840E0")]
	public static bool GKJAMGPLIAA(this EIGHLLMDFND GNDJONLPBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7183D90", Offset = "0x7183190", VA = "0x187183D90")]
	public static void EAEELGKFCBI(this EIGHLLMDFND GNDJONLPBDP, Vector3 HAFFNKMHEBO, Quaternion MHEADAMEHHA, float NCJKDICMFFP, bool HNNJCFCBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7185420", Offset = "0x7184820", VA = "0x187185420")]
	public static void LFHGIHGIOMF(this EIGHLLMDFND GNDJONLPBDP, Vector3 HAFFNKMHEBO, Quaternion MHEADAMEHHA, float NCJKDICMFFP, int LEHJHPNNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7183C70", Offset = "0x7183070", VA = "0x187183C70")]
	public static void COJDBHOHJLN(this EIGHLLMDFND GNDJONLPBDP, int LEHJHPNNFIB, Vector3 HAFFNKMHEBO, Quaternion MHEADAMEHHA, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7184150", Offset = "0x7183550", VA = "0x187184150")]
	public static void KFCENEFADLK(this EIGHLLMDFND GNDJONLPBDP, Vector3 FBJKECACLKH, Quaternion JHLKPCBCNKM, float NCJKDICMFFP, bool HNNJCFCBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71841A0", Offset = "0x71835A0", VA = "0x1871841A0")]
	private static void KIAPPNOENCA(this EIGHLLMDFND GNDJONLPBDP, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP, bool HNNJCFCBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7184AF0", Offset = "0x7183EF0", VA = "0x187184AF0")]
	private static void KLINFCCHNAA(this EIGHLLMDFND GNDJONLPBDP, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK, float DJPCHDEOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71856A0", Offset = "0x7184AA0", VA = "0x1871856A0")]
	private static void NEKBCFFDAHF(this EIGHLLMDFND GNDJONLPBDP, int IIACLAMOIEE, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK, float DJPCHDEOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7185880", Offset = "0x7184C80", VA = "0x187185880")]
	private static bool NPHDADKDIBC(this EIGHLLMDFND GNDJONLPBDP, int IIACLAMOIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7185190", Offset = "0x7184590", VA = "0x187185190")]
	private static void LAMKNJAOHCH(this EIGHLLMDFND GNDJONLPBDP, int IIACLAMOIEE, Vector3 ENJPHPPLHAI, Quaternion HONHOJHJMHK, float DJPCHDEOOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7184CA0", Offset = "0x71840A0", VA = "0x187184CA0")]
	public static Vector3 KNGEANDFLPN(this EIGHLLMDFND GNDJONLPBDP, int IIACLAMOIEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7183B60", Offset = "0x7182F60", VA = "0x187183B60")]
	public static Quaternion BKHGEHGILPG(this EIGHLLMDFND GNDJONLPBDP, int IIACLAMOIEE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7183EC0", Offset = "0x71832C0", VA = "0x187183EC0")]
	public static Vector3 EENODBHLCAP(MCBOHJAEBBG OBCABLKNBMC, Vector3 CPGMOBFHDAC, Vector3? LHOPGFOIONP, Vector3 GJGOMBEICIM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface FHGFCJPDGBN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPLLLIPAPCK(EntityQuery KMAGGAOJLCG, EntityManager PKOBGBCOJNG, LENDPAHFCIN OGOGOLFFADO, ABPNNEDOAIG KGMOHFPDNLA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface FBKAIEHEELN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType KIHDINMEAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLCILNOAPNE(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGDBAAHHAKF(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDLLGIAMAGK(HPHPPPLGLDK NDGFJFPPHLN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KHIDKCNHDJA : FHGFCJPDGBN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x717F840", Offset = "0x717EC40", VA = "0x18717F840", Slot = "4")]
	public void EPLLLIPAPCK(EntityQuery KMAGGAOJLCG, EntityManager PKOBGBCOJNG, LENDPAHFCIN OGOGOLFFADO, ABPNNEDOAIG KGMOHFPDNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KHIDKCNHDJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class GKKDMACKBDO : FHGFCJPDGBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PHLFHEADMAE PNKOKJNBOBJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
	public GKKDMACKBDO(PHLFHEADMAE PNKOKJNBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71781E0", Offset = "0x71775E0", VA = "0x1871781E0", Slot = "4")]
	public void EPLLLIPAPCK(EntityQuery KMAGGAOJLCG, EntityManager PKOBGBCOJNG, LENDPAHFCIN OGOGOLFFADO, ABPNNEDOAIG KGMOHFPDNLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class ODJAIHCFIEM : FHGFCJPDGBN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7182F10", Offset = "0x7182310", VA = "0x187182F10", Slot = "4")]
	public void EPLLLIPAPCK(EntityQuery KMAGGAOJLCG, EntityManager PKOBGBCOJNG, LENDPAHFCIN OGOGOLFFADO, ABPNNEDOAIG KGMOHFPDNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ODJAIHCFIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LGFBDGEJKAL : FBKAIEHEELN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType KIHDINMEAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x71807B0", Offset = "0x717FBB0", VA = "0x1871807B0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7180260", Offset = "0x717F660", VA = "0x187180260", Slot = "5")]
	public void BLCILNOAPNE(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7180530", Offset = "0x717F930", VA = "0x187180530", Slot = "6")]
	public void DGDBAAHHAKF(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71804E0", Offset = "0x717F8E0", VA = "0x1871804E0", Slot = "7")]
	public void DDLLGIAMAGK(HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LGFBDGEJKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JHNBDBIKOHL : FBKAIEHEELN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType KIHDINMEAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x717F810", Offset = "0x717EC10", VA = "0x18717F810", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x717F2C0", Offset = "0x717E6C0", VA = "0x18717F2C0", Slot = "5")]
	public void BLCILNOAPNE(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x717F590", Offset = "0x717E990", VA = "0x18717F590", Slot = "6")]
	public void DGDBAAHHAKF(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x717F540", Offset = "0x717E940", VA = "0x18717F540", Slot = "7")]
	public void DDLLGIAMAGK(HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JHNBDBIKOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KPFPBPJPCEB : FBKAIEHEELN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType KIHDINMEAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x717FFE0", Offset = "0x717F3E0", VA = "0x18717FFE0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x717FA90", Offset = "0x717EE90", VA = "0x18717FA90", Slot = "5")]
	public void BLCILNOAPNE(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x717FD60", Offset = "0x717F160", VA = "0x18717FD60", Slot = "6")]
	public void DGDBAAHHAKF(EntityQuery KMAGGAOJLCG, HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x717FD10", Offset = "0x717F110", VA = "0x18717FD10", Slot = "7")]
	public void DDLLGIAMAGK(HPHPPPLGLDK NDGFJFPPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KPFPBPJPCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class ENLGOJEIMMP : ICMPKEPKJGI, DMLBGGHLGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LENDPAHFCIN OGOGOLFFADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BMGOFICAPAD IBKDGOFBEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ABPNNEDOAIG KGMOHFPDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, FHGFCJPDGBN adapter)> GJMDOBJNCLG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7175AF0", Offset = "0x7174EF0", VA = "0x187175AF0", Slot = "15")]
	public virtual void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7175D00", Offset = "0x7175100", VA = "0x187175D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7175B80", Offset = "0x7174F80", VA = "0x187175B80")]
	private void MMOBKPCGGFE(EntityQueryDesc DHKJHIHBFBK, FHGFCJPDGBN ADAKOLFMEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7175F30", Offset = "0x7175330", VA = "0x187175F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public ENLGOJEIMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class ALBCMGCCABG : ICMPKEPKJGI, DMLBGGHLGCD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EBFAEGBJOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery IIDGGPGFLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery CAEBHJAHMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery KDKBPOFDDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery FMDFHKOOKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery LIAGNKCDHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FBKAIEHEELN JHNPLJHFLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ComponentType EBDKOBOLBDD;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EBFAEGBJOON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LENDPAHFCIN OGOGOLFFADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ABPNNEDOAIG KGMOHFPDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private BMGOFICAPAD IBKDGOFBEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<EBFAEGBJOON> GJMDOBJNCLG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x716D7A0", Offset = "0x716CBA0", VA = "0x18716D7A0", Slot = "14")]
	public void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x716DF50", Offset = "0x716D350", VA = "0x18716DF50", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x716DDD0", Offset = "0x716D1D0", VA = "0x18716DDD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x716E0E0", Offset = "0x716D4E0", VA = "0x18716E0E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x716D470", Offset = "0x716C870", VA = "0x18716D470")]
	private void DNONGFJBPIE(EBFAEGBJOON BIKOEPMKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x716D830", Offset = "0x716CC30", VA = "0x18716D830")]
	private void MMOBKPCGGFE(FBKAIEHEELN JHNPLJHFLLA, ComponentType AMICIKEMAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public ALBCMGCCABG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct LFMGDENLIAK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct JIPHEOCICHB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct BPPMNPDPGJF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(HNOOAIEMFKP), new string[] { })]
public class DLNGOBOBAEJ : HNOOAIEMFKP, IBKPHGCGFKM, PMFJAPPJIBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[DependsOn]
	private HIKOLNFHCME GPOOJLKEOLB;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7174510", Offset = "0x7173910", VA = "0x187174510", Slot = "4")]
	public bool PANCLOEJDMI(AOMADBOBEAJ FCHDAFNGEPF, EPEJGOLLHIL HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71744C0", Offset = "0x71738C0", VA = "0x1871744C0", Slot = "5")]
	private void CNKJMHHGNCN(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xD13730", Offset = "0xD12B30", VA = "0x180D13730", Slot = "6")]
	private void GHHONKMBLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DLNGOBOBAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(ABPNNEDOAIG), new string[] { })]
public class LAKAOJFJKNO : ABPNNEDOAIG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BLEKIMGBKEH AOPMEINAEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BLEKIMGBKEH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LAKAOJFJKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(JFGBOJIICBN), new string[] { })]
public class OMCNHAOIHGM : JFGBOJIICBN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7183810", Offset = "0x7182C10", VA = "0x187183810", Slot = "4")]
	public void FCHFMCOLFFL(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7183940", Offset = "0x7182D40", VA = "0x187183940", Slot = "5")]
	public void MIPOPDIDLMM(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7183890", Offset = "0x7182C90", VA = "0x187183890", Slot = "6")]
	public ComponentSystemBase FHFDOBFENIC(World GPOOJLKEOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7183990", Offset = "0x7182D90", VA = "0x187183990", Slot = "7")]
	public void NIHOMJLNLJH(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71838E0", Offset = "0x7182CE0", VA = "0x1871838E0", Slot = "8")]
	public void KNIFFBJGEDJ(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71839F0", Offset = "0x7182DF0", VA = "0x1871839F0", Slot = "9")]
	public void OEKFBJCODBG(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7183A50", Offset = "0x7182E50", VA = "0x187183A50", Slot = "10")]
	public void OIAENJACMNI(World GPOOJLKEOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7183130", Offset = "0x7182530", VA = "0x187183130", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> EHHLABMONHG()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OMCNHAOIHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AALKOIAAPNK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public MKEMEHIOFOB PLMJMPJAION;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static AALKOIAAPNK IDKOEJANABA(MKEMEHIOFOB KADPKBIGPFN)
	{
		return default(AALKOIAAPNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IOFAJLCCLHI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EGLHNIPKIOL MNPJFHKMJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x717E9A0", Offset = "0x717DDA0", VA = "0x18717E9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IOFAJLCCLHI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DJKFBNJONCD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LNNOMDPLPMI : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CGDLKBEKKDO PKAJJOHBAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7180850", Offset = "0x717FC50", VA = "0x187180850", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71807E0", Offset = "0x717FBE0", VA = "0x1871807E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LNNOMDPLPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AGMHLHGGIDK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EMKOHBIHIFI EFIAIPLAKNN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static AGMHLHGGIDK IDKOEJANABA(EMKOHBIHIFI KADPKBIGPFN)
	{
		return default(AGMHLHGGIDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BKPOPEIFGAP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public MKEMEHIOFOB PLMJMPJAION;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static BKPOPEIFGAP IDKOEJANABA(MKEMEHIOFOB KADPKBIGPFN)
	{
		return default(BKPOPEIFGAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MLHLGDHDMLD : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AIKPDBPDPPK KAEJLMHIALL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7182210", Offset = "0x7181610", VA = "0x187182210", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71821A0", Offset = "0x71815A0", VA = "0x1871821A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MLHLGDHDMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MJHBMGDCPDO : NDOGIKOJCKF, CGDLKBEKKDO, GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GPFOAHFBENB HJPEKEOHMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x968280", Offset = "0x967680", VA = "0x180968280", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(GPFOAHFBENB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FFFMDHIEOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAB1FD0", Offset = "0xAB13D0", VA = "0x180AB1FD0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 DAOKLOIBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC76F50", Offset = "0xC76350", VA = "0x180C76F50", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7182100", Offset = "0x7181500", VA = "0x187182100")]
	public MJHBMGDCPDO(UniformTRS HLDEADCPJLI, OBGLMNKFCEH AMMKPAGCALK, float OJGIOHLAJPI, float3 ELGNFHNDJOL, FLEIDECPCLB DHAMDPLLEGD, HDEGMGMJOHI COHALLNKGAC, GPFOAHFBENB AOPKOLCMLOH, float3 EDHOCAINKBJ, bool LANKCMOJKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71820B0", Offset = "0x71814B0", VA = "0x1871820B0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JADCFFMAOJO : NDOGIKOJCKF, AIKPDBPDPPK, GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<LMKDMCGCAOO> AICLELMIJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HEMMIIAGOPG OKAMEPDCJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly float AJJJMJCIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int APNONPFOGIH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DKMLLJDHEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x717EB80", Offset = "0x717DF80", VA = "0x18717EB80", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MLADAJOKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x717EBA0", Offset = "0x717DFA0", VA = "0x18717EBA0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IIKNHDJHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x717EB90", Offset = "0x717DF90", VA = "0x18717EB90", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NLOPINDHPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99DFB0", Offset = "0x99D3B0", VA = "0x18099DFB0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float EFJHHPMKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC80050", Offset = "0xC7F450", VA = "0x180C80050", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MDOHBLCPKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB1C670", Offset = "0xB1BA70", VA = "0x180B1C670", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x717EAD0", Offset = "0x717DED0", VA = "0x18717EAD0")]
	public JADCFFMAOJO(UniformTRS HLDEADCPJLI, OBGLMNKFCEH AMMKPAGCALK, float OJGIOHLAJPI, float3 ELGNFHNDJOL, FLEIDECPCLB DHAMDPLLEGD, HDEGMGMJOHI COHALLNKGAC, HEMMIIAGOPG OKAMEPDCJCI, float AJJJMJCIPNE, int APNONPFOGIH, NativeArray<LMKDMCGCAOO> AICLELMIJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC8EA70", Offset = "0xC8DE70", VA = "0x180C8EA70", Slot = "33")]
	public NativeArray<LMKDMCGCAOO> GetNativeCurvePoints()
	{
		return default(NativeArray<LMKDMCGCAOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x717EA10", Offset = "0x717DE10", VA = "0x18717EA10", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PKOOIHIBIMM : PIOMKMDFIHK, EGLHNIPKIOL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject CKPDFOONLGC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GameObject ILKBGMGJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7186880", Offset = "0x7185C80", VA = "0x187186880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JBNHCDLOLNG DCIPDEOFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71865E0", Offset = "0x71859E0", VA = "0x1871865E0", Slot = "15")]
		get
		{
			return default(JBNHCDLOLNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HEMKNAONLNN IDOOLOFOONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "16")]
		get
		{
			return default(HEMKNAONLNN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7186910", Offset = "0x7185D10", VA = "0x187186910")]
	public PKOOIHIBIMM(AOMADBOBEAJ FCHDAFNGEPF, bool FGMKDCONOFK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7186710", Offset = "0x7185B10", VA = "0x187186710")]
	public void FMMMGJGJKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71865E0", Offset = "0x71859E0", VA = "0x1871865E0")]
	protected JBNHCDLOLNG CJGNMDAICHG()
	{
		return default(JBNHCDLOLNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71866E0", Offset = "0x7185AE0", VA = "0x1871866E0", Slot = "17")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NAMKBHKLJEC : JHBLLBADJKC, CGDLKBEKKDO, GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Dictionary<LHOIJIFDHFN, GPFOAHFBENB> IIHPIAEONMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GPFOAHFBENB AOPKOLCMLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool LANKCMOJKIP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GPFOAHFBENB OJMLNCJCLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E4C50", Offset = "0x8E4050", VA = "0x1808E4C50", Slot = "28")]
		get
		{
			return default(GPFOAHFBENB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool JNEMLOBFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA549B0", Offset = "0xA53DB0", VA = "0x180A549B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 DAOKLOIBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7182920", Offset = "0x7181D20", VA = "0x187182920", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71828E0", Offset = "0x7181CE0", VA = "0x1871828E0")]
	public NAMKBHKLJEC(AOMADBOBEAJ ODACIIAKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71823E0", Offset = "0x71817E0", VA = "0x1871823E0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7182260", Offset = "0x7181660", VA = "0x187182260", Slot = "26")]
	public override void BFLBMILJDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BOPLODIOCGB : JHBLLBADJKC, AIKPDBPDPPK, GHMLMFMOILD, IDisposable, LPLOOLNENLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<LMKDMCGCAOO> AICLELMIJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool PKBHHBJGJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool AJMINLDEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float AJJJMJCIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int APNONPFOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private bool JFGDBEMAHNB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool AIJECMNNJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F80", Offset = "0x9A2380", VA = "0x1809A2F80", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IOJDJONOBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9118D0", Offset = "0x910CD0", VA = "0x1809118D0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float JNJCDDCNBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC1C790", Offset = "0xC1BB90", VA = "0x180C1C790", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int DEEPHKGBADF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x968280", Offset = "0x967680", VA = "0x180968280", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DLPPHPEIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB1FD0", Offset = "0xAB13D0", VA = "0x180AB1FD0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int ODJPFGBEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7173AC0", Offset = "0x7172EC0", VA = "0x187173AC0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BOJHLNIKHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7173490", Offset = "0x7172890", VA = "0x187173490", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7173CA0", Offset = "0x71730A0", VA = "0x187173CA0")]
	public BOPLODIOCGB(AOMADBOBEAJ ODACIIAKALC, [Optional] NativeList<LMKDMCGCAOO> AICLELMIJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71733B0", Offset = "0x71727B0", VA = "0x1871733B0", Slot = "26")]
	public override void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7173580", Offset = "0x7172980", VA = "0x187173580", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7173670", Offset = "0x7172A70", VA = "0x187173670", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7173A30", Offset = "0x7172E30", VA = "0x187173A30")]
	public void INCEICEEMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71736D0", Offset = "0x7172AD0", VA = "0x1871736D0", Slot = "34")]
	public NativeArray<LMKDMCGCAOO> GetNativeCurvePoints()
	{
		return default(NativeArray<LMKDMCGCAOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7173AE0", Offset = "0x7172EE0", VA = "0x187173AE0", Slot = "35")]
	private Vector3 MBHHKMLPDMG(int DEFGGFLHDDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7173A90", Offset = "0x7172E90", VA = "0x187173A90", Slot = "36")]
	private Quaternion LAHKHLICFMF(int DEFGGFLHDDI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71738A0", Offset = "0x7172CA0", VA = "0x1871738A0", Slot = "37")]
	private float HPBFCJMIHKL(int DEFGGFLHDDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7173C30", Offset = "0x7173030", VA = "0x187173C30")]
	private NativeArray<Entity> PAGAIFLBEOE()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class BJJPPBENJJH : IPNJPCLKMLF
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7172FF0", Offset = "0x71723F0", VA = "0x187172FF0", Slot = "15")]
	protected override ComponentSystemBase IAAHPGDOLNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7173390", Offset = "0x7172790", VA = "0x187173390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71733A0", Offset = "0x71727A0", VA = "0x1871733A0")]
	public BJJPPBENJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[GCJBKLLMNAD]
public sealed class HGOHBPHKHJJ : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EntityQuery IIDGGPGFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EntityQuery NAGDJOFGECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EntityQuery JACBNNGPMKF;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x717DB20", Offset = "0x717CF20", VA = "0x18717DB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x717DD20", Offset = "0x717D120", VA = "0x18717DD20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x717D630", Offset = "0x717CA30", VA = "0x18717D630")]
	private void FAANBAAKMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x717D8B0", Offset = "0x717CCB0", VA = "0x18717D8B0")]
	private void HKCBEFMHIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x717D470", Offset = "0x717C870", VA = "0x18717D470")]
	private void CCIKMLFNKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x717D850", Offset = "0x717CC50", VA = "0x18717D850")]
	private NativeList<Entity> FJJPJEEFNAM(NativeArray<Entity> NNNALCFDKMF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x717DAC0", Offset = "0x717CEC0", VA = "0x18717DAC0")]
	private NativeList<Entity> JCBHAPIJPKL(NativeArray<Entity> NNNALCFDKMF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x717D5A0", Offset = "0x717C9A0", VA = "0x18717D5A0")]
	private void CDLBOOKMJFL(NativeArray<Entity> NNNALCFDKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public HGOHBPHKHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[GCJBKLLMNAD]
public sealed class FKMHBECKBOG : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EntityQuery FKCKDCFPCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery LGNJKOPBGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery KDKBPOFDDDP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x71774F0", Offset = "0x71768F0", VA = "0x1871774F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71776E0", Offset = "0x7176AE0", VA = "0x1871776E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7176120", Offset = "0x7175520", VA = "0x187176120")]
	private void EFPPDAONJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7176910", Offset = "0x7175D10", VA = "0x187176910")]
	private void HFIDFHIPEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7177100", Offset = "0x7176500", VA = "0x187177100")]
	private void MNNPFDJBEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public FKMHBECKBOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[GCJBKLLMNAD]
public sealed class GBEIHOMEIIE : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery GBOCAFDFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery EFLBMGADIPE;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7177FF0", Offset = "0x71773F0", VA = "0x187177FF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7178140", Offset = "0x7177540", VA = "0x187178140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71779D0", Offset = "0x7176DD0", VA = "0x1871779D0")]
	private void EFPPDAONJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7177CE0", Offset = "0x71770E0", VA = "0x187177CE0")]
	private void HFIDFHIPEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public GBEIHOMEIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EDDALNDCFBK : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	private struct DAGBGEJBJAC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EntityQueryInJob BJKJCIDMOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EntityQueryInJob MMNCKNPLKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public EntityTypeHandle NFBMIMGEJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ReadOnly]
		public ComponentTypeHandle<BKPOPEIFGAP> PMOBOJLIPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeParallelHashSet<MKEMEHIOFOB> KLOKCOHLCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeList<Entity> PNKIBADAAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> JEBOPDJANMH;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7173E90", Offset = "0x7173290", VA = "0x187173E90", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7173EE0", Offset = "0x71732E0", VA = "0x187173EE0")]
		private void NPIMBECBOCH(EntityQueryInJob KMAGGAOJLCG, [Optional] NativeList<Entity> CDCCPHGKKAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private struct LCHFFLIJGNB : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[ReadOnly]
		public EntityTypeHandle NFBMIMGEJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[ReadOnly]
		public ComponentTypeHandle<BKPOPEIFGAP> PMOBOJLIPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeParallelHashSet<MKEMEHIOFOB> KLOKCOHLCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeList<Entity> CDCCPHGKKAE;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7180010", Offset = "0x717F410", VA = "0x187180010", Slot = "4")]
		public void Execute(ArchetypeChunk IAIOCCJBCNL, int NJLGCGKFPOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct JHDGLLFALIE : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public EntityTypeHandle NFBMIMGEJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> AEEFPKBGEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ReadOnly]
		public ComponentTypeHandle<AGMHLHGGIDK> MCGMOFBEEBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ReadOnly]
		public ComponentDataFromEntity<AALKOIAAPNK> NJFIOKJLAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ComponentTypeHandle<BKPOPEIFGAP> ANEKAOLJJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeParallelHashSet<MKEMEHIOFOB> KLOKCOHLCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeList<Entity> DONIJHAPBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeList<AGMHLHGGIDK> GMPEELMLMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeList<MKEMEHIOFOB> DDIKCBLLMCG;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x717EF90", Offset = "0x717E390", VA = "0x18717EF90", Slot = "4")]
		public void Execute(ArchetypeChunk IAIOCCJBCNL, int NJLGCGKFPOK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery BJKJCIDMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery MMNCKNPLKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery BGODIHIKGLE;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x71749C0", Offset = "0x7173DC0", VA = "0x1871749C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7174C50", Offset = "0x7174050", VA = "0x187174C50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7174F70", Offset = "0x7174370", VA = "0x187174F70")]
	private void PKPMAOLHGFL(NativeParallelHashSet<MKEMEHIOFOB> KLOKCOHLCLB, int CNKPFGKFOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7174680", Offset = "0x7173A80", VA = "0x187174680")]
	private void CIPPGNMPFMB(NativeParallelHashSet<MKEMEHIOFOB> KLOKCOHLCLB, int GAJNJJEHDLA, int LNLLHKIPPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public EDDALNDCFBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class ADPIEHJGJPO : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EntityQuery KMAGGAOJLCG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x716C240", Offset = "0x716B640", VA = "0x18716C240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x716C2F0", Offset = "0x716B6F0", VA = "0x18716C2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public ADPIEHJGJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[GCJBKLLMNAD]
internal class AKOBDLNLMEL : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class JHLIKIGCMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EntityQuery NLDGBKCNOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EntityQuery HICCPDGPJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LEABBHGNNFO FPMJNGIGFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ComponentType NABOGMMOEMD;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JHLIKIGCMBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private delegate void LEABBHGNNFO(NativeArray<EMKOHBIHIFI> KADPKBIGPFN, HPHPPPLGLDK NDGFJFPPHLN);

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<JHLIKIGCMBL> GJMDOBJNCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private BMGOFICAPAD IBKDGOFBEPE;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x716CB20", Offset = "0x716BF20", VA = "0x18716CB20", Slot = "15")]
	public override void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x716CD60", Offset = "0x716C160", VA = "0x18716CD60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x716CEF0", Offset = "0x716C2F0", VA = "0x18716CEF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x372D440", Offset = "0x372C840", VA = "0x18372D440")]
	private void MMOBKPCGGFE<T>(LEABBHGNNFO FPMJNGIGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x716C7E0", Offset = "0x716BBE0", VA = "0x18716C7E0")]
	private static void GMFAOLHOJGJ(NativeArray<EMKOHBIHIFI> BLENOGEPAEK, HPHPPPLGLDK GKAPLNOCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x716CBC0", Offset = "0x716BFC0", VA = "0x18716CBC0")]
	private static void MJFHFPCFCPJ(NativeArray<EMKOHBIHIFI> BLENOGEPAEK, HPHPPPLGLDK GKAPLNOCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x716C980", Offset = "0x716BD80", VA = "0x18716C980")]
	private static void HAPHAJBLOOI(NativeArray<EMKOHBIHIFI> BLENOGEPAEK, HPHPPPLGLDK GKAPLNOCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public AKOBDLNLMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GCJBKLLMNAD]
public sealed class HCHOMKCNLBK : HECGDAHGKGC
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EntityQuery KMAGGAOJLCG;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x717CE10", Offset = "0x717C210", VA = "0x18717CE10", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GPAAMJPFLGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public UniformTRS HLDEADCPJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public StandardRenderableVisualData NAMDJJNCPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public GPFOAHFBENB AOPKOLCMLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 EDHOCAINKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool LANKCMOJKIP;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DPKMMNMEOMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public NativeList<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeList<Entity> ACLMGKMDAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeParallelHashSet<Entity> KEEOLLBPOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeList<GPAAMJPFLGE> PCBNHEDDCMD;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x71745F0", Offset = "0x71739F0", VA = "0x1871745F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RegisterService(typeof(MEPCOIBMFNF), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class MEPCOIBMFNF : DMLBGGHLGCD, FCDDCBJENJH, IBKPHGCGFKM, PMFJAPPJIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DIGFDHHMJEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly MEPCOIBMFNF AMMKPAGCALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly bool ELPBODOAHNC;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12D9330", Offset = "0x12D8730", VA = "0x1812D9330")]
		public DIGFDHHMJEP(MEPCOIBMFNF AMMKPAGCALK, bool ELPBODOAHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7174410", Offset = "0x7173810", VA = "0x187174410")]
		public Queue<DHECBDKFMEH>.Enumerator JDJKPBEKJIJ()
		{
			return default(Queue<DHECBDKFMEH>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7174100", Offset = "0x7173500", VA = "0x187174100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[DependsOn]
	private ENHHHCAGNII FCBGOFLIGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[DependsOn]
	private KJLMBHJGPEE FGEELPDNNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private List<NativeList<LMKDMCGCAOO>> GEBFDCPHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<EMKOHBIHIFI> IAMAHCMFLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private List<(Entity, List<GameObject>)> LDJCAJDEKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private KOBGADHPDPM<DHECBDKFMEH> ADDCAOGGCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private KOBGADHPDPM<DPKMMNMEOMJ> GNJMINGOGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private KOBGADHPDPM<GFCLDBAFHDL> COPMAKLKIBD;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x71812E0", Offset = "0x71806E0", VA = "0x1871812E0", Slot = "4")]
	public void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x71814E0", Offset = "0x71808E0", VA = "0x1871814E0")]
	public void JFDLHCDLEMG(NativeList<LMKDMCGCAOO> AGDCKMMAAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7181A60", Offset = "0x7180E60", VA = "0x187181A60")]
	public void NENGHGGGPCO(Entity AMMKPAGCALK, [In] IGBALICKMIC<GameObject> ADEDGJMCEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7181200", Offset = "0x7180600", VA = "0x187181200")]
	public void DNODPCKDIIE(NativeList<EMKOHBIHIFI> BLENOGEPAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7181E10", Offset = "0x7181210", VA = "0x187181E10")]
	public void OEKFBJCODBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x71815B0", Offset = "0x71809B0", VA = "0x1871815B0")]
	public void NCFMBNAKBBC(HAMODOLAMII KCLPDCIIPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x71810C0", Offset = "0x71804C0", VA = "0x1871810C0")]
	public JobHandle DAOLPDLBDIO([In] DHECBDKFMEH LNICHECHJFC, JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7181160", Offset = "0x7180560", VA = "0x187181160")]
	public JobHandle DAOLPDLBDIO([In] DPKMMNMEOMJ LNICHECHJFC, JobHandle BGAGLBHPLFA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA4A90", Offset = "0x6EA3E90", VA = "0x186EA4A90")]
	public DIGFDHHMJEP HPMPKMOJLME(bool ELPBODOAHNC)
	{
		return default(DIGFDHHMJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7181000", Offset = "0x7180400", VA = "0x187181000")]
	public CNGNOGGGHEN<DPKMMNMEOMJ> BJMHKMNJLCB()
	{
		return default(CNGNOGGGHEN<DPKMMNMEOMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7181290", Offset = "0x7180690", VA = "0x187181290")]
	public CNGNOGGGHEN<GFCLDBAFHDL> EBELMAFAFNL()
	{
		return default(CNGNOGGGHEN<GFCLDBAFHDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7181C00", Offset = "0x7181000", VA = "0x187181C00", Slot = "5")]
	public void OBDLHHEKPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7181050", Offset = "0x7180450", VA = "0x187181050", Slot = "6")]
	private void CNKJMHHGNCN(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7134AA0", Offset = "0x7133EA0", VA = "0x187134AA0", Slot = "7")]
	private void GHHONKMBLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MEPCOIBMFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MMBCLIGPIAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public UniformTRS HLDEADCPJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public StandardRenderableVisualData NAMDJJNCPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AHKAPNEMKGD OKAMEPDCJCI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct DHECBDKFMEH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> NNNALCFDKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> ACLMGKMDAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> KEEOLLBPOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<IGMINMCGFIO> ICBCLCCJDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<LMKDMCGCAOO> AGDCKMMAAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<MMBCLIGPIAB> PIAGGBEHMCC;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7174020", Offset = "0x7173420", VA = "0x187174020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7174030", Offset = "0x7173430", VA = "0x187174030")]
	public void GMPAFBLCGBH(bool ELPBODOAHNC)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : HECGDAHGKGC, DMLBGGHLGCD
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
			public NativeParallelHashMap<int, GPFOAHFBENB> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public NativeArray<GPAAMJPFLGE> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x71783B0", Offset = "0x71777B0", VA = "0x1871783B0", Slot = "4")]
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
			public NativeArray<LMKDMCGCAOO> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[ReadOnly]
			public NativeArray<IGMINMCGFIO> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public NativeArray<MMBCLIGPIAB> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7178750", Offset = "0x7177B50", VA = "0x187178750", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7173D50", Offset = "0x7173150", VA = "0x187173D50", Slot = "4")]
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
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x7186AC0", Offset = "0x7185EC0", VA = "0x187186AC0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x7186AE0", Offset = "0x7185EE0", VA = "0x187186AE0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 KHGNODJKMDD(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x71808A0", Offset = "0x717FCA0", VA = "0x1871808A0", Slot = "5")]
				public float3 GCGNGECPABJ(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x7180C40", Offset = "0x7180040", VA = "0x187180C40", Slot = "4")]
				public float3 KHGNODJKMDD(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x7182BF0", Offset = "0x7181FF0", VA = "0x187182BF0", Slot = "4")]
				public float3 KHGNODJKMDD(quaternion rotation)
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
			public NativeArray<IGMINMCGFIO> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<LMKDMCGCAOO> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7179940", Offset = "0x7178D40", VA = "0x187179940", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x717A220", Offset = "0x7179620", VA = "0x18717A220")]
			private void HBGMGOBNGKH(NativeList<PointSrcData> srcData, NativeList<LMKDMCGCAOO> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7179530", Offset = "0x7178930", VA = "0x187179530")]
			public static Vector3 EAIALKLODJK(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7178E70", Offset = "0x7178270", VA = "0x187178E70")]
			public static quaternion AKJALGAIIMP(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x717C980", Offset = "0x717BD80", VA = "0x18717C980")]
			private static quaternion NPIEHMGJKFC(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x717CBB0", Offset = "0x717BFB0", VA = "0x18717CBB0")]
			private static float3 PNDKLMGKDIB(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x717B4A0", Offset = "0x717A8A0", VA = "0x18717B4A0")]
			private static quaternion JBNLABJPKNN(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x71792C0", Offset = "0x71786C0", VA = "0x1871792C0")]
			private static LMKDMCGCAOO DLKKAJEEIPF(int idx, NativeList<PointSrcData> srcData)
			{
				return default(LMKDMCGCAOO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x36EECD0", Offset = "0x36EE0D0", VA = "0x1836EECD0")]
			private void FGGMANGONBK<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x717BB70", Offset = "0x717AF70", VA = "0x18717BB70")]
			private void LAJPGAOBHJG(NativeList<PointSrcData> sourcePoints, NativeList<LMKDMCGCAOO> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7178F90", Offset = "0x7178390", VA = "0x187178F90")]
			public static float CALKNJAIOPL(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x717B100", Offset = "0x717A500", VA = "0x18717B100")]
			private static quaternion HBMBNDAHBBE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x71791A0", Offset = "0x71785A0", VA = "0x1871791A0")]
			private static LMKDMCGCAOO CKFHMNCGEHD(PointSrcData point)
			{
				return default(LMKDMCGCAOO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7179110", Offset = "0x7178510", VA = "0x187179110")]
			private static LMKDMCGCAOO CKFHMNCGEHD(float3 pos, quaternion rot, float radius)
			{
				return default(LMKDMCGCAOO);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7178EF0", Offset = "0x71782F0", VA = "0x187178EF0")]
			private static bool BPNPEFABIFI(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x717A150", Offset = "0x7179550", VA = "0x18717A150")]
			private static float3 GFMNDIMAFCN(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x717B2F0", Offset = "0x717A6F0", VA = "0x18717B2F0")]
			public static float3 HINCANHCGFF(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7179FA0", Offset = "0x71793A0", VA = "0x187179FA0")]
			public static float3 GCGNGECPABJ(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x717B530", Offset = "0x717A930", VA = "0x18717B530")]
			private static quaternion JNADNFJCBIG(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x717B990", Offset = "0x717AD90", VA = "0x18717B990")]
			private static float JOOEKFFOBIN(float3 from, float3 to)
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

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7188CB0", Offset = "0x71880B0", VA = "0x187188CB0")]
			private void CECGPJENAFO(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7188D90", Offset = "0x7188190", VA = "0x187188D90", Slot = "4")]
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
			public NativeList<LMKDMCGCAOO> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x718A400", Offset = "0x7189800", VA = "0x18718A400")]
			private void CECGPJENAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x718A460", Offset = "0x7189860", VA = "0x18718A460", Slot = "4")]
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
			public NativeList<LMKDMCGCAOO> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x718A3A0", Offset = "0x71897A0", VA = "0x18718A3A0")]
			private void CECGPJENAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x718A3F0", Offset = "0x71897F0", VA = "0x18718A3F0", Slot = "4")]
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
			public NativeList<GPAAMJPFLGE> data;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7178A90", Offset = "0x7177E90", VA = "0x187178A90")]
			private void CECGPJENAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7178C50", Offset = "0x7178050", VA = "0x187178C50", Slot = "4")]
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
			public NativeList<IGMINMCGFIO> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NativeList<MMBCLIGPIAB> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7178C60", Offset = "0x7178060", VA = "0x187178C60")]
			private void CECGPJENAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7178E60", Offset = "0x7178260", VA = "0x187178E60", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7189F70", Offset = "0x7189370", VA = "0x187189F70")]
			private void CECGPJENAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x718A390", Offset = "0x7189790", VA = "0x18718A390", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly GKOKEEMOOFG log;

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
		private PMJAFECFBFF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private ENHHHCAGNII objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private MEPCOIBMFNF bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FGOJCOJEDDF ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7188210", Offset = "0x7187610", VA = "0x187188210", Slot = "15")]
		public override void InitReferences(PBPBPCOFCDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x71899E0", Offset = "0x7188DE0", VA = "0x1871899E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7189AD0", Offset = "0x7188ED0", VA = "0x187189AD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7189B30", Offset = "0x7188F30", VA = "0x187189B30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7187F10", Offset = "0x7187310", VA = "0x187187F10")]
		private JobHandle IMHHCNFHNKB(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7188440", Offset = "0x7187840", VA = "0x187188440")]
		private JobHandle KKFNFCGPHHN(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x71877B0", Offset = "0x7186BB0", VA = "0x1871877B0")]
		private JobHandle DNLOCCCDFPL(NativeArray<int> pointCount, NativeList<LMKDMCGCAOO> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7187D60", Offset = "0x7187160", VA = "0x187187D60")]
		private JobHandle HFDOONIHNGA(NativeList<LMKDMCGCAOO> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7189300", Offset = "0x7188700", VA = "0x187189300")]
		private JobHandle ONNPPEEBILP(EntityQuery query, NativeList<IGMINMCGFIO> splinePointRanges, NativeList<LMKDMCGCAOO> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7187120", Offset = "0x7186520", VA = "0x187187120")]
		private JobHandle CKIAIACGDJK(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7189C40", Offset = "0x7189040", VA = "0x187189C40")]
		private JobHandle PKDCHJDLMMD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7188E80", Offset = "0x7188280", VA = "0x187188E80")]
		private JobHandle NAAKPDCMBPD(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<GPAAMJPFLGE> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x71874F0", Offset = "0x71868F0", VA = "0x1871874F0")]
		private JobHandle DKEGLNKOIDC(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<IGMINMCGFIO> splinePointRanges, [Out] NativeList<MMBCLIGPIAB> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x71890F0", Offset = "0x71884F0", VA = "0x1871890F0")]
		private JobHandle OCOGLHOEJDA(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7186B30", Offset = "0x7185F30", VA = "0x187186B30")]
		private JobHandle BEFMHOKNKIH(EntityQuery query, NativeList<GPAAMJPFLGE> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7187940", Offset = "0x7186D40", VA = "0x187187940")]
		private static NativeParallelHashMap<int, GPFOAHFBENB> EOHKIMCABLC()
		{
			return default(NativeParallelHashMap<int, GPFOAHFBENB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7187240", Offset = "0x7186640", VA = "0x187187240")]
		private JobHandle DBJMNEHEENE(EntityQuery query, NativeList<IGMINMCGFIO> splinePointRanges, NativeList<LMKDMCGCAOO> splinePointData, NativeList<MMBCLIGPIAB> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7187040", Offset = "0x7186440", VA = "0x187187040")]
		private JobHandle BJMPMFIHLCH(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x71877B0", Offset = "0x7186BB0", VA = "0x1871877B0")]
		private JobHandle IOALGGGMDAO(NativeArray<int> pointCount, NativeList<LMKDMCGCAOO> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7187D60", Offset = "0x7187160", VA = "0x187187D60")]
		private JobHandle FKHKJKCPJOL(NativeList<LMKDMCGCAOO> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7187850", Offset = "0x7186C50", VA = "0x187187850")]
		private JobHandle EOHIDGCPGIB(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<GPAAMJPFLGE> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7187E00", Offset = "0x7187200", VA = "0x187187E00")]
		private JobHandle HKIPCPCJDLE(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<IGMINMCGFIO> ranges, NativeList<MMBCLIGPIAB> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x71882F0", Offset = "0x71876F0", VA = "0x1871882F0")]
		private JobHandle JLJGLBHJBFG(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x71897D0", Offset = "0x7188BD0", VA = "0x1871897D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OPOBMAELBNJ : ICMPKEPKJGI, DMLBGGHLGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public MEPCOIBMFNF KGIFMGGDJOG;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7183AF0", Offset = "0x7182EF0", VA = "0x187183AF0", Slot = "14")]
	public void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7183B40", Offset = "0x7182F40", VA = "0x187183B40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public OPOBMAELBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class BHMOBHNOPMJ : HECGDAHGKGC, DMLBGGHLGCD
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct AIBACCCDLGH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EntityManager PKOBGBCOJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private GNGKNDPCFBG<T> ODFNNAJIIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int IIACLAMOIEE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x41D9D60", Offset = "0x41D9160", VA = "0x1841D9D60")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x41DA3C0", Offset = "0x41D97C0", VA = "0x1841DA3C0")]
		public AIBACCCDLGH(EntityManager PKOBGBCOJNG, GNGKNDPCFBG<T> ODFNNAJIIMK, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D703B0", Offset = "0x3D6F7B0", VA = "0x183D703B0")]
		public AIBACCCDLGH<T> JDJKPBEKJIJ()
		{
			return default(AIBACCCDLGH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x41DA360", Offset = "0x41D9760", VA = "0x1841DA360")]
		public bool KFHHDPCHMMF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly GKOKEEMOOFG NGFNNECOKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private KJLMBHJGPEE FGEELPDNNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private MEPCOIBMFNF KGIFMGGDJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::DDOECKIPLGP JHDJBGBIBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int OKDDPCIIODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string EEAMHLFJMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7171260", Offset = "0x7170660", VA = "0x187171260", Slot = "15")]
	public override void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7171D40", Offset = "0x7171140", VA = "0x187171D40")]
	public void OIAENJACMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7171DB0", Offset = "0x71711B0", VA = "0x187171DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7170240", Offset = "0x716F640", VA = "0x187170240")]
	private void HJFLEJONILJ(GFCLDBAFHDL LNICHECHJFC, Mesh[] MPGEEFBKPBP, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDAAE0", Offset = "0x2DD9EE0", VA = "0x182DDAAE0")]
	private AIBACCCDLGH<T> HDEPBFKGGMI<T>(GNGKNDPCFBG<T> ODFNNAJIIMK, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ) where T : struct
	{
		return default(AIBACCCDLGH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x716F270", Offset = "0x716E670", VA = "0x18716F270")]
	private void EMKGBHPOMDA(Transform AMMKPAGCALK, NativeArray<GIFBMMCCPOE> MIKLFBIBGIO, IGBALICKMIC<GameObject> CPENJOGGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7171470", Offset = "0x7170870", VA = "0x187171470")]
	private void MNPIJGHNLDB(Transform AMMKPAGCALK, NativeArray<DJPHBLMPPHH> CGDKMLGDMKM, IGBALICKMIC<GameObject> CPENJOGGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x716EE80", Offset = "0x716E280", VA = "0x18716EE80")]
	private void EFKHIMLLHDM(Transform AMMKPAGCALK, NativeArray<OIODAALGPPG> ENFMDEKJGPD, IGBALICKMIC<GameObject> CPENJOGGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7171930", Offset = "0x7170D30", VA = "0x187171930")]
	private void NCADPCBEJAL(Transform AMMKPAGCALK, NativeArray<GLDEFPHKPAM> MPGEEFBKPBP, Mesh[] GOODFGEOKMI, IGBALICKMIC<GameObject> CPENJOGGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x716ED30", Offset = "0x716E130", VA = "0x18716ED30")]
	private static void DPPIJECOBDD(NativeParallelHashSet<Entity> NNNALCFDKMF, NativeParallelHashSet<Entity> ILGMPKNCIAK, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7170180", Offset = "0x716F580", VA = "0x187170180")]
	private static void FNLIDDBMADB(NativeList<Entity> CECMFLAILAL, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x716F600", Offset = "0x716EA00", VA = "0x18716F600")]
	private NativeParallelHashMap<Entity, AALKOIAAPNK> EMPGHPBDPDL(MEPCOIBMFNF.DIGFDHHMJEP CGNDDCAKHIM, CNGNOGGGHEN<DPKMMNMEOMJ> HLDPBIKAJLC, NativeArray<EntityRemapUtility.EntityRemapInfo> EFLLLGHLFLJ, List<GameObject> CPENJOGGFCB)
	{
		return default(NativeParallelHashMap<Entity, AALKOIAAPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x716E370", Offset = "0x716D770", VA = "0x18716E370")]
	private void AMFNDKKPEIG(NativeList<Entity> KOELMIBAAKN, NativeList<Entity> GCMOPJOCONA, NativeParallelHashMap<Entity, AALKOIAAPNK> GKNKJEHKLJD, NativeList<IGMINMCGFIO> GBGIOOKCFPM, NativeList<LMKDMCGCAOO> OAFDPLMBIOL, NativeList<MMBCLIGPIAB> GEBFDCPHDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x716E910", Offset = "0x716DD10", VA = "0x18716E910")]
	private void DIGFAMFKKBH(NativeList<Entity> NNNALCFDKMF, NativeList<Entity> ACLMGKMDAGK, NativeParallelHashMap<Entity, AALKOIAAPNK> GKNKJEHKLJD, NativeList<GPAAMJPFLGE> PCBNHEDDCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	public BHMOBHNOPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class EFNCDKFKIHK : NPKDLPIDJMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly UniformTRS HLDEADCPJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly OBGLMNKFCEH AMMKPAGCALK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject NDIAGHJPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS AIEMCMMAIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7175740", Offset = "0x7174B40", VA = "0x187175740", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 ACHMJNIFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x71756F0", Offset = "0x7174AF0", VA = "0x1871756F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 EJCLLFFAACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7175A00", Offset = "0x7174E00", VA = "0x187175A00", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 JNMAMCIFGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7175960", Offset = "0x7174D60", VA = "0x187175960", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7175A50", Offset = "0x7174E50", VA = "0x187175A50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion KNAFGIAKLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x71758C0", Offset = "0x7174CC0", VA = "0x1871758C0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7175870", Offset = "0x7174C70", VA = "0x187175870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 HEFCBMFLKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x71759B0", Offset = "0x7174DB0", VA = "0x1871759B0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 PMFFOOKBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7175910", Offset = "0x7174D10", VA = "0x187175910", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 LCINKKBLAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7175820", Offset = "0x7174C20", VA = "0x187175820", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7175AA0", Offset = "0x7174EA0", VA = "0x187175AA0")]
	public EFNCDKFKIHK(UniformTRS HLDEADCPJLI, OBGLMNKFCEH AMMKPAGCALK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class NDOGIKOJCKF : EFNCDKFKIHK, GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float OJGIOHLAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly float3 ELGNFHNDJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FLEIDECPCLB DHAMDPLLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HDEGMGMJOHI COHALLNKGAC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private JBNHCDLOLNG DPKFOFNMFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7182AD0", Offset = "0x7181ED0", VA = "0x187182AD0", Slot = "17")]
		get
		{
			return default(JBNHCDLOLNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS GAFCFOPPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x71829F0", Offset = "0x7181DF0", VA = "0x1871829F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float DBMEFIAGLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x933D00", Offset = "0x933100", VA = "0x180933D00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 CFAMHAGPBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7182B20", Offset = "0x7181F20", VA = "0x187182B20", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private FLEIDECPCLB BPBEOJPPOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACD0", Offset = "0xA4A0D0", VA = "0x180A4ACD0", Slot = "21")]
		get
		{
			return default(FLEIDECPCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private HDEGMGMJOHI OAHEEKGNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xEFFDE0", Offset = "0xEFF1E0", VA = "0x180EFFDE0", Slot = "22")]
		get
		{
			return default(HDEGMGMJOHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool LFAOPAHJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KBLOLEBAPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7182B70", Offset = "0x7181F70", VA = "0x187182B70")]
	protected NDOGIKOJCKF(UniformTRS HLDEADCPJLI, OBGLMNKFCEH AMMKPAGCALK, float OJGIOHLAJPI, float3 ELGNFHNDJOL, FLEIDECPCLB DHAMDPLLEGD, HDEGMGMJOHI COHALLNKGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HIDAFILPNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x717E340", Offset = "0x717D740", VA = "0x18717E340")]
	public static void OOMKGKCMKPG(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG, HAMODOLAMII FNIPBIOCMAN, ENHHHCAGNII LBFGHBIKLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x717DDD0", Offset = "0x717D1D0", VA = "0x18717DDD0")]
	public static void BGCAHEFCNLA(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG, HAMODOLAMII FNIPBIOCMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x717E090", Offset = "0x717D490", VA = "0x18717E090")]
	public static NativeList<Entity> JCBHAPIJPKL(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x717E050", Offset = "0x717D450", VA = "0x18717E050")]
	public static NativeList<Entity> FJJPJEEFNAM(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x717E0D0", Offset = "0x717D4D0", VA = "0x18717E0D0")]
	private static NativeList<Entity> JCBHAPIJPKL(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG, bool JCJBBMOFBMM)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class PIOMKMDFIHK : NPKDLPIDJMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly AOMADBOBEAJ NKCFJFCLAAC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected OBGLMNKFCEH FPOFEBBOGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xD09870", Offset = "0xD08C70", VA = "0x180D09870")]
		get
		{
			return default(OBGLMNKFCEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity LCFCJAKPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7185AA0", Offset = "0x7184EA0", VA = "0x187185AA0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected ENHHHCAGNII MOMHLDEJAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x71861C0", Offset = "0x71855C0", VA = "0x1871861C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected BDCOBEDGNIJ JGPGGCBIIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x71861D0", Offset = "0x71855D0", VA = "0x1871861D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected LHAACOMCFDP OPNFIMNJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7185A10", Offset = "0x7184E10", VA = "0x187185A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject NDIAGHJPFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7186190", Offset = "0x7185590", VA = "0x187186190", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS AIEMCMMAIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD286F0", Offset = "0xD27AF0", VA = "0x180D286F0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 ACHMJNIFHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x71858E0", Offset = "0x7184CE0", VA = "0x1871858E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 EJCLLFFAACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7186360", Offset = "0x7185760", VA = "0x187186360", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 JNMAMCIFGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7186060", Offset = "0x7185460", VA = "0x187186060", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x71864E0", Offset = "0x71858E0", VA = "0x1871864E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion KNAFGIAKLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7185D80", Offset = "0x7185180", VA = "0x187185D80", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7185C80", Offset = "0x7185080", VA = "0x187185C80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 HEFCBMFLKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7186230", Offset = "0x7185630", VA = "0x187186230", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 PMFFOOKBKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7185EA0", Offset = "0x71852A0", VA = "0x187185EA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 LCINKKBLAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7185AC0", Offset = "0x7184EC0", VA = "0x187185AC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xA0BC30", Offset = "0xA0B030", VA = "0x180A0BC30")]
	protected PIOMKMDFIHK(AOMADBOBEAJ ODACIIAKALC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x717EE00", Offset = "0x717E200", VA = "0x18717EE00")]
	public static JBNHCDLOLNG IDKOEJANABA(PIOMKMDFIHK OPGNNMINDKO)
	{
		return default(JBNHCDLOLNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HOHLOJAHCGA
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x717E760", Offset = "0x717DB60", VA = "0x18717E760")]
	public static void GJCALCBALDL(NativeArray<Entity> NNNALCFDKMF, EntityManager PKOBGBCOJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class JHBLLBADJKC : PIOMKMDFIHK, GHMLMFMOILD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float OJGIOHLAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 ELGNFHNDJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FLEIDECPCLB DHAMDPLLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private HDEGMGMJOHI COHALLNKGAC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager BADBCGGHDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x717ED40", Offset = "0x717E140", VA = "0x18717ED40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected HIKOLNFHCME OABPBFKKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x717EE30", Offset = "0x717E230", VA = "0x18717EE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData EDPJDONMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x717EEC0", Offset = "0x717E2C0", VA = "0x18717EEC0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private JBNHCDLOLNG DPKFOFNMFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x717EE00", Offset = "0x717E200", VA = "0x18717EE00", Slot = "17")]
		get
		{
			return default(JBNHCDLOLNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float DBMEFIAGLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB05EB0", Offset = "0xB052B0", VA = "0x180B05EB0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 CFAMHAGPBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x11176A0", Offset = "0x1116AA0", VA = "0x1811176A0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private FLEIDECPCLB BPBEOJPPOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C50", Offset = "0x8C8050", VA = "0x1808C8C50", Slot = "21")]
		get
		{
			return default(FLEIDECPCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private HDEGMGMJOHI OAHEEKGNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6F40", Offset = "0xCF6340", VA = "0x180CF6F40", Slot = "22")]
		get
		{
			return default(HDEGMGMJOHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS GAFCFOPPBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xD286F0", Offset = "0xD27AF0", VA = "0x180D286F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KBLOLEBAPND
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4100", Offset = "0x8F3500", VA = "0x1808F4100", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F20", Offset = "0x8F3320", VA = "0x1808F3F20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool LFAOPAHJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x717EF50", Offset = "0x717E350", VA = "0x18717EF50")]
	protected JHBLLBADJKC(AOMADBOBEAJ ODACIIAKALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x717EBB0", Offset = "0x717DFB0", VA = "0x18717EBB0", Slot = "26")]
	public virtual void BFLBMILJDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class HECGDAHGKGC : ICMPKEPKJGI, DMLBGGHLGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected ENHHHCAGNII LBFGHBIKLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LENDPAHFCIN OGOGOLFFADO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected HAMODOLAMII NPJDIOBLFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x717D360", Offset = "0x717C760", VA = "0x18717D360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected HPHPPPLGLDK FOHEHLJGJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x717D420", Offset = "0x717C820", VA = "0x18717D420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x717D3B0", Offset = "0x717C7B0", VA = "0x18717D3B0", Slot = "15")]
	public virtual void InitReferences(PBPBPCOFCDM LAACHEAGFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x254E620", Offset = "0x254DA20", VA = "0x18254E620")]
	protected HECGDAHGKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FPIFHMCKLOD
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7177790", Offset = "0x7176B90", VA = "0x187177790")]
	public static void DHHCNCDMDLA(NativeArray<Entity> KOELMIBAAKN, EntityManager PKOBGBCOJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3736080344
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x718ADC0", Offset = "0x718A1C0", VA = "0x18718ADC0")]
	public static void EAAEBHHHNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x718B040", Offset = "0x718A440", VA = "0x18718B040")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class OEANFOFIAGB : ContainerPropertyBag<IOFAJLCCLHI>
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x71830D0", Offset = "0x71824D0", VA = "0x1871830D0")]
	public OEANFOFIAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class DAMLOCLPHEM : ContainerPropertyBag<LNNOMDPLPMI>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7173FC0", Offset = "0x71733C0", VA = "0x187173FC0")]
	public DAMLOCLPHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class CGFFODPFKDA : ContainerPropertyBag<MLHLGDHDMLD>
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7173CF0", Offset = "0x71730F0", VA = "0x187173CF0")]
	public CGFFODPFKDA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7189DB0", Offset = "0x71891B0", VA = "0x187189DB0")]
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
