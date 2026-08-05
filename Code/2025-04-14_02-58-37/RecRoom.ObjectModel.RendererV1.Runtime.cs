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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7AC11D0", Offset = "0x7ABFBD0", VA = "0x187AC11D0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EA40", Offset = "0x1F7D440", VA = "0x181F7EA40", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA400", Offset = "0x7AC8E00", VA = "0x187ACA400")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA990", Offset = "0x7AC9390", VA = "0x187ACA990", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ACA9F0", Offset = "0x7AC93F0", VA = "0x187ACA9F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MLDECIPDNJN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1640", Offset = "0x7AC0040", VA = "0x187AC1640")]
	public static Quaternion IKPEKHMILAG([In] this NKLIGKJDPMF KIFJADBHAIH, [In] Vector3 BJECPMGLFMN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ABJJFBICEJA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AACF80", Offset = "0x7AAB980", VA = "0x187AACF80")]
	public static bool POIHDOKBGAI(this KJHHHBLLAOE CIGFHDBGGNF, FFELHMGLKAD ADHFHCKDLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB6E0", Offset = "0x7AAA0E0", VA = "0x187AAB6E0")]
	public static bool CKMNPDNBAEF(this KJHHHBLLAOE CIGFHDBGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC520", Offset = "0x7AAAF20", VA = "0x187AAC520")]
	public static bool HFFIBHNIKDL(this KJHHHBLLAOE CIGFHDBGGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC660", Offset = "0x7AAB060", VA = "0x187AAC660")]
	public static void LNFOLPAPDCK(this KJHHHBLLAOE CIGFHDBGGNF, Vector3 AJDIABAIFJM, Quaternion ECFCLCMDHFK, float OAIHKLDEKFL, bool KNNDDPJBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB460", Offset = "0x7AA9E60", VA = "0x187AAB460")]
	public static void CJOIEIGJNPG(this KJHHHBLLAOE CIGFHDBGGNF, Vector3 AJDIABAIFJM, Quaternion ECFCLCMDHFK, float OAIHKLDEKFL, int KDEOGPDNFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7AACC80", Offset = "0x7AAB680", VA = "0x187AACC80")]
	public static void NOPMNFHAKOH(this KJHHHBLLAOE CIGFHDBGGNF, int KDEOGPDNFEK, Vector3 AJDIABAIFJM, Quaternion ECFCLCMDHFK, float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB710", Offset = "0x7AAA110", VA = "0x187AAB710")]
	public static void DBNJOCCDIIC(this KJHHHBLLAOE CIGFHDBGGNF, Vector3 HKJANPHKKCO, Quaternion AKPHJGIOIKH, float OAIHKLDEKFL, bool KNNDDPJBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7AABBD0", Offset = "0x7AAA5D0", VA = "0x187AABBD0")]
	private static void EPFDEACODFL(this KJHHHBLLAOE CIGFHDBGGNF, Vector3 KKIJMCHODGC, Quaternion KONJHPLFEME, float OAIHKLDEKFL, bool KNNDDPJBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7AABA20", Offset = "0x7AAA420", VA = "0x187AABA20")]
	private static void EGFNFPIHIAP(this KJHHHBLLAOE CIGFHDBGGNF, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, float GBEBBDKBMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7AACDA0", Offset = "0x7AAB7A0", VA = "0x187AACDA0")]
	private static void OHLOFNMFAIP(this KJHHHBLLAOE CIGFHDBGGNF, int DOAKEFBOPIA, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, float GBEBBDKBMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB760", Offset = "0x7AAA160", VA = "0x187AAB760")]
	private static bool DLGEKMAGCLA(this KJHHHBLLAOE CIGFHDBGGNF, int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB790", Offset = "0x7AAA190", VA = "0x187AAB790")]
	private static void DOMKGJJNBEI(this KJHHHBLLAOE CIGFHDBGGNF, int DOAKEFBOPIA, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, float GBEBBDKBMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC790", Offset = "0x7AAB190", VA = "0x187AAC790")]
	public static Vector3 NNIOIOJNEIG(this KJHHHBLLAOE CIGFHDBGGNF, int DOAKEFBOPIA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC550", Offset = "0x7AAAF50", VA = "0x187AAC550")]
	public static Quaternion HLADAPMOJPG(this KJHHHBLLAOE CIGFHDBGGNF, int DOAKEFBOPIA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB240", Offset = "0x7AA9C40", VA = "0x187AAB240")]
	public static Vector3 CAOKILCGDHB(FFELHMGLKAD BNNEEGIINDP, Vector3 KKIJMCHODGC, Vector3? FLEHHNBJBLE, Vector3 EDIOPPBFIOC)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JICEGGHNEDO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCHDHLGOCKG(EntityQuery EFJPJMPCAPD, EntityManager IOCALHHKFGN, EDBGHLHADIK OADJGMBHLBP, AKICPHADAJJ NOAIJOJDHKH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface GNHIINFKNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DJLGFKLNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFDNENCEBOI(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCOKEMAJJJA(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFLLHOGFIKA(HBJPHKMFDDO NKJEJGHMMEE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GDFGPBLFOMC : JICEGGHNEDO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6230", Offset = "0x7AB4C30", VA = "0x187AB6230", Slot = "4")]
	public void JCHDHLGOCKG(EntityQuery EFJPJMPCAPD, EntityManager IOCALHHKFGN, EDBGHLHADIK OADJGMBHLBP, AKICPHADAJJ NOAIJOJDHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public GDFGPBLFOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class EMLLAPAHCGC : JICEGGHNEDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LCGNEMGJNFI GBNJCPHDBMP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
	public EMLLAPAHCGC(LCGNEMGJNFI GBNJCPHDBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3810", Offset = "0x7AB2210", VA = "0x187AB3810", Slot = "4")]
	public void JCHDHLGOCKG(EntityQuery EFJPJMPCAPD, EntityManager IOCALHHKFGN, EDBGHLHADIK OADJGMBHLBP, AKICPHADAJJ NOAIJOJDHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PGNLJNBLHLC : JICEGGHNEDO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4000", Offset = "0x7AC2A00", VA = "0x187AC4000", Slot = "4")]
	public void JCHDHLGOCKG(EntityQuery EFJPJMPCAPD, EntityManager IOCALHHKFGN, EDBGHLHADIK OADJGMBHLBP, AKICPHADAJJ NOAIJOJDHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PGNLJNBLHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IHLDGIFIKKG : GNHIINFKNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DJLGFKLNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB5E0", Offset = "0x7AB9FE0", VA = "0x187ABB5E0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7ABB610", Offset = "0x7ABA010", VA = "0x187ABB610", Slot = "5")]
	public void KFDNENCEBOI(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7ABB310", Offset = "0x7AB9D10", VA = "0x187ABB310", Slot = "6")]
	public void DCOKEMAJJJA(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7ABB590", Offset = "0x7AB9F90", VA = "0x187ABB590", Slot = "7")]
	public void GFLLHOGFIKA(HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public IHLDGIFIKKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PNDPBINJNKM : GNHIINFKNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DJLGFKLNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4A30", Offset = "0x7AC3430", VA = "0x187AC4A30", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4A60", Offset = "0x7AC3460", VA = "0x187AC4A60", Slot = "5")]
	public void KFDNENCEBOI(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4760", Offset = "0x7AC3160", VA = "0x187AC4760", Slot = "6")]
	public void DCOKEMAJJJA(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC49E0", Offset = "0x7AC33E0", VA = "0x187AC49E0", Slot = "7")]
	public void GFLLHOGFIKA(HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PNDPBINJNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PDBDINFPFCM : GNHIINFKNFL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DJLGFKLNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3D50", Offset = "0x7AC2750", VA = "0x187AC3D50", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3D80", Offset = "0x7AC2780", VA = "0x187AC3D80", Slot = "5")]
	public void KFDNENCEBOI(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3A80", Offset = "0x7AC2480", VA = "0x187AC3A80", Slot = "6")]
	public void DCOKEMAJJJA(EntityQuery EFJPJMPCAPD, HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3D00", Offset = "0x7AC2700", VA = "0x187AC3D00", Slot = "7")]
	public void GFLLHOGFIKA(HBJPHKMFDDO NKJEJGHMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PDBDINFPFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class PMCIFEPOKPJ : IMFEJPHBKOA, KFPIMHBKPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EDBGHLHADIK OADJGMBHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EMBEGMEPJAI MJBGFGOJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AKICPHADAJJ NOAIJOJDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JICEGGHNEDO adapter)> FLIABNBGKOG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4140", Offset = "0x7AC2B40", VA = "0x187AC4140", Slot = "15")]
	public virtual void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4340", Offset = "0x7AC2D40", VA = "0x187AC4340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7AC41D0", Offset = "0x7AC2BD0", VA = "0x187AC41D0")]
	private void MGAFCPNAIDC(EntityQueryDesc GLGGJJHJBAG, JICEGGHNEDO IMHHGNONMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4570", Offset = "0x7AC2F70", VA = "0x187AC4570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
	public PMCIFEPOKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class LAPIEBAOJJH : IMFEJPHBKOA, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EGKJDLDJBGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery DIMBBNKBIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery JHDKDLIMJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery JHHNKKDJFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery DKIEPPFPAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery HPEDMPFNEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery GIHGCDKFMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery KELPFDPCJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GNHIINFKNFL PGFOFOOJBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType JFFNHGBDLIE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EGKJDLDJBGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private EDBGHLHADIK OADJGMBHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AKICPHADAJJ NOAIJOJDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EMBEGMEPJAI MJBGFGOJNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<EGKJDLDJBGK> FLIABNBGKOG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7ABEEE0", Offset = "0x7ABD8E0", VA = "0x187ABEEE0", Slot = "14")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7ABF6B0", Offset = "0x7ABE0B0", VA = "0x187ABF6B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7ABF830", Offset = "0x7ABE230", VA = "0x187ABF830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7ABEA90", Offset = "0x7ABD490", VA = "0x187ABEA90")]
	private void DKOMFOANNOD(EGKJDLDJBGK PGPOHLGBGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7ABEF70", Offset = "0x7ABD970", VA = "0x187ABEF70")]
	private void MGAFCPNAIDC(GNHIINFKNFL PGFOFOOJBBO, ComponentType BEANINJEGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
	public LAPIEBAOJJH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct MIMPDDPJHOC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct GOECNHCNDCB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct AEMMECEGNDA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(AKICPHADAJJ), new string[] { })]
public class LCDLLAJNNIB : AKICPHADAJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MPMOFPPLHCF CPNPEFBGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MPMOFPPLHCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B9180", Offset = "0x9B7B80", VA = "0x1809B9180", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LCDLLAJNNIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(NDNBHEHGHAG), new string[] { })]
public class OEABHFFFHAA : NDNBHEHGHAG, IMGBGCGLCBE, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private MIAJELHJLFO ILOAGCFCJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private EDBGHLHADIK OADJGMBHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private HOECEAHHGFN DOOFKBLICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity MOLNFMBJHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private JBGLFFCNIBO DPHGBBNFPCJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3540", Offset = "0x7AC1F40", VA = "0x187AC3540", Slot = "4")]
	public bool BIEIJPCCBFP(ECEDHFIPBHO CEJEEJJKEJL, GDFAAFKOMOG PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AC37C0", Offset = "0x7AC21C0", VA = "0x187AC37C0", Slot = "5")]
	public JBGLFFCNIBO OMKHIKDGOLD()
	{
		return default(JBGLFFCNIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7AC36B0", Offset = "0x7AC20B0", VA = "0x187AC36B0", Slot = "6")]
	public void MEALOKHBGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AC3620", Offset = "0x7AC2020", VA = "0x187AC3620", Slot = "7")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x10B2EE0", Offset = "0x10B18E0", VA = "0x1810B2EE0", Slot = "8")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public OEABHFFFHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(DHPCIPMOIHO), new string[] { })]
public class NKMNHMOKGGH : DHPCIPMOIHO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC28D0", Offset = "0x7AC12D0", VA = "0x187AC28D0", Slot = "4")]
	public void NEJBDMOILOL(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2700", Offset = "0x7AC1100", VA = "0x187AC2700", Slot = "5")]
	public void AIEOPJHPKIM(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2880", Offset = "0x7AC1280", VA = "0x187AC2880", Slot = "6")]
	public ComponentSystemBase MLINKMBCGJO(World ILOAGCFCJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2750", Offset = "0x7AC1150", VA = "0x187AC2750", Slot = "7")]
	public void FEBALICFKMM(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2950", Offset = "0x7AC1350", VA = "0x187AC2950", Slot = "8")]
	public void OKHFEBIIPCF(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2820", Offset = "0x7AC1220", VA = "0x187AC2820", Slot = "9")]
	public void MLEMGBGPOFB(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AC27B0", Offset = "0x7AC11B0", VA = "0x187AC27B0", Slot = "10")]
	public void GJAJDKAECDB(World ILOAGCFCJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AC29B0", Offset = "0x7AC13B0", VA = "0x187AC29B0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> PKODNDHHNOB()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NKMNHMOKGGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct CAMNOIBHFCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct BCODLNAFJMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GGFHBAHPAOM : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HFEEEJKKJME ICPMOJMCHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AB64A0", Offset = "0x7AB4EA0", VA = "0x187AB64A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6430", Offset = "0x7AB4E30", VA = "0x187AB6430", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public GGFHBAHPAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct LCEJOPGCPMJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JBGLFFCNIBO BNKIEELAIFF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static LCEJOPGCPMJ MEHFEEABIDG(JBGLFFCNIBO ENNBIIMEOCP)
	{
		return default(LCEJOPGCPMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NOJMEBGKJHH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CMKEMJONGPA AEIKJKEIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC31B0", Offset = "0x7AC1BB0", VA = "0x187AC31B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NOJMEBGKJHH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct KKDMBBLKOMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct BDNELKOHDOM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LIINPMBBOMO EHPKFMDKMMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static BDNELKOHDOM MEHFEEABIDG(LIINPMBBOMO ENNBIIMEOCP)
	{
		return default(BDNELKOHDOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct MCOCKLIIILB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JBGLFFCNIBO BNKIEELAIFF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static MCOCKLIIILB MEHFEEABIDG(JBGLFFCNIBO ENNBIIMEOCP)
	{
		return default(MCOCKLIIILB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NBMMCMIGGNH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KOBGOEHEJAM AMPKLCHMJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1F00", Offset = "0x7AC0900", VA = "0x187AC1F00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1E90", Offset = "0x7AC0890", VA = "0x187AC1E90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NBMMCMIGGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MCLDDLIFMPN : CPHBIBJHOAM, HFEEEJKKJME, INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BPEIFANGIJA IINCIAONFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCA40F0", Offset = "0xCA2AF0", VA = "0x180CA40F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(BPEIFANGIJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DNAFPIBDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB66450", Offset = "0xB64E50", VA = "0x180B66450", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 MFOOEHLOKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1006220", Offset = "0x1004C20", VA = "0x181006220", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7AC15A0", Offset = "0x7ABFFA0", VA = "0x187AC15A0")]
	public MCLDDLIFMPN(UniformTRS AGNKFGEDAEE, DFLEJIJCDEG HGBJMKAPAJA, float EEILIJKHAHG, float3 ALGNLMNEICO, ADADNEEPCEF CNPOKMNHKGC, KJDEIJDKCCB PIFNBLMLAMH, BPEIFANGIJA BLBNPJFGILF, float3 MPCJABFJLIO, bool IAKOHACFNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1550", Offset = "0x7ABFF50", VA = "0x187AC1550", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IIIPNHDICJF : CPHBIBJHOAM, KOBGOEHEJAM, INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<CEGHMCHEJIL> GKDAOCBBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LKPMBDOIBEA KHABEFHMCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float CCHOCGMLNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int NBOIBGANHOH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HPEMNCOOJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBA00", Offset = "0x7ABA400", VA = "0x187ABBA00", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PODNLPPIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBA20", Offset = "0x7ABA420", VA = "0x187ABBA20", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JDJHABCKPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBA10", Offset = "0x7ABA410", VA = "0x187ABBA10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CCGIPAEILIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCFE580", Offset = "0xCFCF80", VA = "0x180CFE580", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MIEAJCFMJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBFFBA0", Offset = "0xBFE5A0", VA = "0x180BFFBA0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OHGHIHMCMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE8CDD0", Offset = "0xE8B7D0", VA = "0x180E8CDD0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7ABB950", Offset = "0x7ABA350", VA = "0x187ABB950")]
	public IIIPNHDICJF(UniformTRS AGNKFGEDAEE, DFLEJIJCDEG HGBJMKAPAJA, float EEILIJKHAHG, float3 ALGNLMNEICO, ADADNEEPCEF CNPOKMNHKGC, KJDEIJDKCCB PIFNBLMLAMH, LKPMBDOIBEA KHABEFHMCBM, float CCHOCGMLNHK, int NBOIBGANHOH, NativeArray<CEGHMCHEJIL> GKDAOCBBDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x101F310", Offset = "0x101DD10", VA = "0x18101F310", Slot = "33")]
	public NativeArray<CEGHMCHEJIL> GetNativeCurvePoints()
	{
		return default(NativeArray<CEGHMCHEJIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7ABB890", Offset = "0x7ABA290", VA = "0x187ABB890", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NANKOHMANNN : FHLHKIIHCIJ, HFEEEJKKJME, INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<AHBNMJGLFPD, BPEIFANGIJA> HAKNKLMPMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private BPEIFANGIJA BLBNPJFGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool IAKOHACFNJD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private BPEIFANGIJA IGOHNMNEBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9CB660", Offset = "0x9CA060", VA = "0x1809CB660", Slot = "28")]
		get
		{
			return default(BPEIFANGIJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool AAPFKMFGIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDB02E0", Offset = "0xDAECE0", VA = "0x180DB02E0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 MFOOEHLOKON
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1DC0", Offset = "0x7AC07C0", VA = "0x187AC1DC0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1DA0", Offset = "0x7AC07A0", VA = "0x187AC1DA0")]
	public NANKOHMANNN(ECEDHFIPBHO HDDPFCMNNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1720", Offset = "0x7AC0120", VA = "0x187AC1720", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1770", Offset = "0x7AC0170", VA = "0x187AC1770", Slot = "26")]
	public override void IPDLKHCHONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LFLPFHGLBJJ : JNMANKGAEBJ, CMKEMJONGPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject JPJGJMCEMKE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFC50", Offset = "0x7ABE650", VA = "0x187ABFC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FJCDPKDIACD GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFD10", Offset = "0x7ABE710", VA = "0x187ABFD10", Slot = "15")]
		get
		{
			return default(FJCDPKDIACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NIIEHKEHOHC EENGMHNFCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7AC00B0", Offset = "0x7ABEAB0", VA = "0x187AC00B0", Slot = "16")]
		get
		{
			return default(NIIEHKEHOHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7ABFF60", Offset = "0x7ABE960", VA = "0x187ABFF60")]
	public LFLPFHGLBJJ(ECEDHFIPBHO CEJEEJJKEJL, bool KEJNGMEGFOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7ABFAC0", Offset = "0x7ABE4C0", VA = "0x187ABFAC0")]
	public void BOBHJJOFBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7ABFD10", Offset = "0x7ABE710", VA = "0x187ABFD10")]
	protected FJCDPKDIACD GFIDGEKBDEF()
	{
		return default(FJCDPKDIACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7ABFE10", Offset = "0x7ABE810", VA = "0x187ABFE10")]
	private static bool HKCIJLODDHI(ECEDHFIPBHO JENKJOKHCAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7ABFCE0", Offset = "0x7ABE6E0", VA = "0x187ABFCE0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LAAFKMNFBEM : FHLHKIIHCIJ, KOBGOEHEJAM, INKAKBMLPEF, IDisposable, KMCFMGGIDLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<CEGHMCHEJIL> GKDAOCBBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool HPCMMKONBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BIDGIGOEKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float CCHOCGMLNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int NBOIBGANHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool KIIIHCMFACK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool KNMCNCIDKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xBAD050", Offset = "0xBABA50", VA = "0x180BAD050", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool GHLOOMIADAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9560", Offset = "0x9F7F60", VA = "0x1809F9560", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float IALBCAKKEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xF8EF00", Offset = "0xF8D900", VA = "0x180F8EF00", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int IBENJBAAGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCA40F0", Offset = "0xCA2AF0", VA = "0x180CA40F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool KGNHCAHHMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB66450", Offset = "0xB64E50", VA = "0x180B66450", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int JPINNNJDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE5E0", Offset = "0x7ABCFE0", VA = "0x187ABE5E0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BMOLHBBCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE300", Offset = "0x7ABCD00", VA = "0x187ABE300", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7ABEA60", Offset = "0x7ABD460", VA = "0x187ABEA60")]
	public LAAFKMNFBEM(ECEDHFIPBHO HDDPFCMNNBA, [Optional] NativeList<CEGHMCHEJIL> GKDAOCBBDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE980", Offset = "0x7ABD380", VA = "0x187ABE980", Slot = "26")]
	public override void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE480", Offset = "0x7ABCE80", VA = "0x187ABE480", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE600", Offset = "0x7ABD000", VA = "0x187ABE600", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE420", Offset = "0x7ABCE20", VA = "0x187ABE420")]
	public void CDDNOGMINID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE7B0", Offset = "0x7ABD1B0", VA = "0x187ABE7B0", Slot = "34")]
	public NativeArray<CEGHMCHEJIL> GetNativeCurvePoints()
	{
		return default(NativeArray<CEGHMCHEJIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE660", Offset = "0x7ABD060", VA = "0x187ABE660", Slot = "35")]
	private Vector3 EFJHFMNCHBN(int AIBKCJCMBBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE3F0", Offset = "0x7ABCDF0", VA = "0x187ABE3F0", Slot = "36")]
	private Quaternion BNJCPEAKAJL(int AIBKCJCMBBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE170", Offset = "0x7ABCB70", VA = "0x187ABE170", Slot = "37")]
	private float AAJCONCIALO(int AIBKCJCMBBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7ABE570", Offset = "0x7ABCF70", VA = "0x187ABE570")]
	private NativeArray<Entity> DMPJEKCLMEM()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class AFCIDMACLBF : PJCGHOBHCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7AACFD0", Offset = "0x7AAB9D0", VA = "0x187AACFD0", Slot = "15")]
	protected override ComponentSystemBase PMPIAKOJABA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7AACFC0", Offset = "0x7AAB9C0", VA = "0x187AACFC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD3E0", Offset = "0x7AABDE0", VA = "0x187AAD3E0")]
	public AFCIDMACLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PPAOKFOPBDL]
public sealed class LPJJJCOPAHL : OODCEDJDLFK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery DHOGGPAKBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery HDPMJOMGJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery ENBKDMIHDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery PHCPJGCEHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery CCKEIIFCCLN;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0800", Offset = "0x7ABF200", VA = "0x187AC0800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0B60", Offset = "0x7ABF560", VA = "0x187AC0B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0520", Offset = "0x7ABEF20", VA = "0x187AC0520")]
	private void IDFKIJCJNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0210", Offset = "0x7ABEC10", VA = "0x187AC0210")]
	private void ADJGJKPHBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0BA0", Offset = "0x7ABF5A0", VA = "0x187AC0BA0")]
	private void PGBBDCNNIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0320", Offset = "0x7ABED20", VA = "0x187AC0320")]
	private void BCHGACJPKLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0700", Offset = "0x7ABF100", VA = "0x187AC0700")]
	private void KCDALPBMNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0480", Offset = "0x7ABEE80", VA = "0x187AC0480")]
	private NativeList<Entity> HEIAOOPDEPP(NativeArray<Entity> GABLPEMHKBP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7AC04D0", Offset = "0x7ABEED0", VA = "0x187AC04D0")]
	private NativeList<Entity> HGIDNMDFDFL(NativeArray<Entity> GABLPEMHKBP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AC0420", Offset = "0x7ABEE20", VA = "0x187AC0420")]
	private void HBDDNLGJLFG(NativeArray<Entity> GABLPEMHKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public LPJJJCOPAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[PPAOKFOPBDL]
public sealed class PNLJLMKFDMA : OODCEDJDLFK, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery BEJAHEKOLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery DNCDODBAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery JHHNKKDJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NDNBHEHGHAG CDDHPEFOCHP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6390", Offset = "0x7AC4D90", VA = "0x187AC6390", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5520", Offset = "0x7AC3F20", VA = "0x187AC5520", Slot = "15")]
	public override void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AC6560", Offset = "0x7AC4F60", VA = "0x187AC6560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AC59E0", Offset = "0x7AC43E0", VA = "0x187AC59E0")]
	private void KMHHINPIKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AC4CE0", Offset = "0x7AC36E0", VA = "0x187AC4CE0")]
	private void EHEGPGMNIHJ(NativeParallelHashSet<JBGLFFCNIBO> GDIECOFNKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5D00", Offset = "0x7AC4700", VA = "0x187AC5D00")]
	private void NIFNOCPFJOF(NativeParallelHashSet<JBGLFFCNIBO> GDIECOFNKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5580", Offset = "0x7AC3F80", VA = "0x187AC5580")]
	private void JHFNJICEJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5940", Offset = "0x7AC4340", VA = "0x187AC5940")]
	private bool KHMANHCAIOC(Entity CGNAGBGLBDK, [Out] JBGLFFCNIBO BNKIEELAIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5370", Offset = "0x7AC3D70", VA = "0x187AC5370")]
	private bool HPBAFDGDKBM(Entity CGNAGBGLBDK, [Out] JBGLFFCNIBO BNKIEELAIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public PNLJLMKFDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[PPAOKFOPBDL]
public sealed class FADFBCFEECL : OODCEDJDLFK
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery OLKGNOKGHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery GJFCHGLHGMH;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7AB40B0", Offset = "0x7AB2AB0", VA = "0x187AB40B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4200", Offset = "0x7AB2C00", VA = "0x187AB4200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3AC0", Offset = "0x7AB24C0", VA = "0x187AB3AC0")]
	private void EHEGPGMNIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7AB3DC0", Offset = "0x7AB27C0", VA = "0x187AB3DC0")]
	private void NIFNOCPFJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public FADFBCFEECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GAIJHEFNCOM : OODCEDJDLFK, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct EPPLKGEJIDA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob EADOBBDDAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob KFJCPKAAGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob PIDCGILEGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob EHJPJGJLAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle HEOKKCGEBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<MCOCKLIIILB> CFGJLHOLCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> ABPMNKJHINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> EMKEIJLHMHM;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3960", Offset = "0x7AB2360", VA = "0x187AB3960", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AB39E0", Offset = "0x7AB23E0", VA = "0x187AB39E0")]
		private void GEAGACEMLDK(EntityQueryInJob EFJPJMPCAPD, NativeList<Entity> HFFOELNJOEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct FFEFLHAIPLK : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle HEOKKCGEBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<MCOCKLIIILB> CFGJLHOLCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> HFFOELNJOEO;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB42A0", Offset = "0x7AB2CA0", VA = "0x187AB42A0", Slot = "4")]
		public void Execute(ArchetypeChunk LMEOEJGADIE, int CHEEDPGBMFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct HNDINPFDBOA : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle HEOKKCGEBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> DGJKFMEHFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<BDNELKOHDOM> LOALAKFGOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<LCEJOPGCPMJ> OKJGHBDGKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<MCOCKLIIILB> NPIINBFCGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> NAGMMCPLMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<BDNELKOHDOM> PCPADDPCCAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<JBGLFFCNIBO> FPKMEKHMAJH;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAFE0", Offset = "0x7AB99E0", VA = "0x187ABAFE0", Slot = "4")]
		public void Execute(ArchetypeChunk LMEOEJGADIE, int CHEEDPGBMFH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery EADOBBDDAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery KFJCPKAAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery PIDCGILEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery EHJPJGJLAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery DABPDECJGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery IGOOOBDFKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery DDBAKECCIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NDNBHEHGHAG JHKAADIHJMF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5920", Offset = "0x7AB4320", VA = "0x187AB5920", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5380", Offset = "0x7AB3D80", VA = "0x187AB5380", Slot = "15")]
	public override void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5EA0", Offset = "0x7AB48A0", VA = "0x187AB5EA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4930", Offset = "0x7AB3330", VA = "0x187AB4930")]
	private void IBECCMBBEHB(NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME, int HAHJLKGAHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7AB4F30", Offset = "0x7AB3930", VA = "0x187AB4F30")]
	private void IJGHACDMLBM(NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME, int GDFJJMANNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB44F0", Offset = "0x7AB2EF0", VA = "0x187AB44F0")]
	private void AAFDNBEOPON(NativeParallelHashSet<JBGLFFCNIBO> IDKAKLLLCME, int IOMIMBJJKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB5590", Offset = "0x7AB3F90", VA = "0x187AB5590")]
	private void NIGDBMHKJCH(NativeParallelHashSet<JBGLFFCNIBO> GDIECOFNKGB, int FMLAGKJLPCJ, int NDIHKENJELL, int MBCIJMDAFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7AB53E0", Offset = "0x7AB3DE0", VA = "0x187AB53E0")]
	private void JBMKPNPFIIC(Entity OKNJICKKPAI, LIINPMBBOMO NIEOJHLJHBD, JBGLFFCNIBO BNKIEELAIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public GAIJHEFNCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class KIACPLLCEEA : OODCEDJDLFK
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery OMFALGNDAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery KLAFFNHNLLD;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7ABD9D0", Offset = "0x7ABC3D0", VA = "0x187ABD9D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7ABDC00", Offset = "0x7ABC600", VA = "0x187ABDC00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public KIACPLLCEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NIFHEHKIAIH : OODCEDJDLFK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct DOGLDJCAALK : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery EDBJJMOEELG;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2390", Offset = "0x7AC0D90", VA = "0x187AC2390", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7AC24D0", Offset = "0x7AC0ED0", VA = "0x187AC24D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public NIFHEHKIAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PPAOKFOPBDL]
internal class DLBDKGGKDGN : OODCEDJDLFK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class MJDNDIMLBFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery GOALNIHPOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery MAODIJDBKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PEFPBOOMELM KBHCADEGKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType KIKLPFHNBDI;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MJDNDIMLBFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void PEFPBOOMELM(NativeArray<LIINPMBBOMO> ENNBIIMEOCP, HBJPHKMFDDO NKJEJGHMMEE);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<MJDNDIMLBFH> FLIABNBGKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private EMBEGMEPJAI MJBGFGOJNJO;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2B00", Offset = "0x7AB1500", VA = "0x187AB2B00", Slot = "15")]
	public override void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2D00", Offset = "0x7AB1700", VA = "0x187AB2D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2E90", Offset = "0x7AB1890", VA = "0x187AB2E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3466B40", Offset = "0x3465540", VA = "0x183466B40")]
	private void MGAFCPNAIDC<T>(PEFPBOOMELM KBHCADEGKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2B60", Offset = "0x7AB1560", VA = "0x187AB2B60")]
	private static void LBPEBFPHGDA(NativeArray<LIINPMBBOMO> MECHNCGCANG, HBJPHKMFDDO AGENMNKFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2960", Offset = "0x7AB1360", VA = "0x187AB2960")]
	private static void DHCJIBHAMBJ(NativeArray<LIINPMBBOMO> MECHNCGCANG, HBJPHKMFDDO AGENMNKFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7AB27C0", Offset = "0x7AB11C0", VA = "0x187AB27C0")]
	private static void ANBIFDHHODD(NativeArray<LIINPMBBOMO> MECHNCGCANG, HBJPHKMFDDO AGENMNKFHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public DLBDKGGKDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PPAOKFOPBDL]
public sealed class NENFPPKJKOF : OODCEDJDLFK
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery EFJPJMPCAPD;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7AC1F50", Offset = "0x7AC0950", VA = "0x187AC1F50", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OGIHPHMGAJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS AGNKFGEDAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData AKJCFHMIOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public BPEIFANGIJA BLBNPJFGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 MPCJABFJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool IAKOHACFNJD;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HBMFLMABMLN(Lifetime.LoadInstance)]
public struct GPNGMMMJCBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FHMFNFPPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> DHKHEFACEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> ENLJNIAHIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<OGIHPHMGAJP> IAKGPOKOJHN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AB64F0", Offset = "0x7AB4EF0", VA = "0x187AB64F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(KEFFHEKDKEJ), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class KEFFHEKDKEJ : KFPIMHBKPFA, BLJGGMGKPKC, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct EAIOFIOLKLJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly KEFFHEKDKEJ HGBJMKAPAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool PBLHNJOFOKE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x16D9FD0", Offset = "0x16D89D0", VA = "0x1816D9FD0")]
		public EAIOFIOLKLJ(KEFFHEKDKEJ HGBJMKAPAJA, bool PBLHNJOFOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3750", Offset = "0x7AB2150", VA = "0x187AB3750")]
		public Queue<KBDDCMAIGLL>.Enumerator KCFKLFFNEEA()
		{
			return default(Queue<KBDDCMAIGLL>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3410", Offset = "0x7AB1E10", VA = "0x187AB3410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private HOECEAHHGFN ABNDEHEFKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private JABONDMAHIA KNEENDICBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<CEGHMCHEJIL>> ENNNDGGELOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> DLEIDCCNKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<LIINPMBBOMO> BAFPGJBHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private EILFOAHOGFI<KBDDCMAIGLL> LAIAMFCNFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EILFOAHOGFI<GPNGMMMJCBN> ENMMACJEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EILFOAHOGFI<ILLFADGCMBH> OHKGDCOHFGE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCDC0", Offset = "0x7ABB7C0", VA = "0x187ABCDC0", Slot = "4")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCCF0", Offset = "0x7ABB6F0", VA = "0x187ABCCF0")]
	public void IJNJAGNBJLJ(NativeList<CEGHMCHEJIL> CMOAACGHPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCAD0", Offset = "0x7ABB4D0", VA = "0x187ABCAD0")]
	public void FMIMNKLDAHF(Entity HGBJMKAPAJA, [In] HPNOBMMHMAN<GameObject> AKIBHLDONID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7ABD8C0", Offset = "0x7ABC2C0", VA = "0x187ABD8C0")]
	public void PIKKMFJAOCH(NativeList<LIINPMBBOMO> MECHNCGCANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7ABD470", Offset = "0x7ABBE70", VA = "0x187ABD470")]
	public void MLEMGBGPOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCFC0", Offset = "0x7ABB9C0", VA = "0x187ABCFC0")]
	public void KMLCJJBDMGI(AMDEOGDAEEI GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC900", Offset = "0x7ABB300", VA = "0x187ABC900")]
	public JobHandle CONADDOEIBM([In] KBDDCMAIGLL FLPDJFEEMLN, JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC860", Offset = "0x7ABB260", VA = "0x187ABC860")]
	public JobHandle CONADDOEIBM([In] GPNGMMMJCBN FLPDJFEEMLN, JobHandle BNGPINPCCLG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x77A02F0", Offset = "0x779ECF0", VA = "0x1877A02F0")]
	public EAIOFIOLKLJ JBKFJDDDCCN(bool PBLHNJOFOKE)
	{
		return default(EAIOFIOLKLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCA80", Offset = "0x7ABB480", VA = "0x187ABCA80")]
	public ECNLMIPFCAI<GPNGMMMJCBN> FEDFMDCACLA()
	{
		return default(ECNLMIPFCAI<GPNGMMMJCBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCC30", Offset = "0x7ABB630", VA = "0x187ABCC30")]
	public ECNLMIPFCAI<ILLFADGCMBH> GPFIPKHKOPF()
	{
		return default(ECNLMIPFCAI<ILLFADGCMBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7ABD6A0", Offset = "0x7ABC0A0", VA = "0x187ABD6A0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC9A0", Offset = "0x7ABB3A0", VA = "0x187ABC9A0", Slot = "5")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7ABCC80", Offset = "0x7ABB680", VA = "0x187ABCC80", Slot = "6")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x10C4C30", Offset = "0x10C3630", VA = "0x1810C4C30", Slot = "7")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KEFFHEKDKEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JODDDPLLHMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS AGNKFGEDAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData AKJCFHMIOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public JPHEOFPJKHK KHABEFHMCBM;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[HBMFLMABMLN(Lifetime.LoadInstance)]
public struct KBDDCMAIGLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity FHMFNFPPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> GABLPEMHKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> DHKHEFACEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> ENLJNIAHIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<FOFEFKICODD> PNNMIICFMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<CEGHMCHEJIL> CMOAACGHPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<JODDDPLLHMC> AIBGDBDIDAP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC850", Offset = "0x7ABB250", VA = "0x187ABC850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC780", Offset = "0x7ABB180", VA = "0x187ABC780")]
	public void CHMHFDMILHD(bool PBLHNJOFOKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(IJIGHLCDAHI), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class IJIGHLCDAHI : FEIEJJCEAHO, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private KEFFHEKDKEJ HAJDHEHGIMP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBA80", Offset = "0x7ABA480", VA = "0x187ABBA80", Slot = "4")]
	public void OFIOACGPNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBA30", Offset = "0x7ABA430", VA = "0x187ABBA30", Slot = "5")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1073A10", Offset = "0x1072410", VA = "0x181073A10", Slot = "6")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public IJIGHLCDAHI()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : OODCEDJDLFK, KFPIMHBKPFA
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
			public NativeParallelHashMap<int, BPEIFANGIJA> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<OGIHPHMGAJP> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6580", Offset = "0x7AB4F80", VA = "0x187AB6580", Slot = "4")]
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
			public NativeArray<CEGHMCHEJIL> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<FOFEFKICODD> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<JODDDPLLHMC> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6920", Offset = "0x7AB5320", VA = "0x187AB6920", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2680", Offset = "0x7AB1080", VA = "0x187AB2680", Slot = "4")]
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
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x7AC6650", Offset = "0x7AC5050", VA = "0x187AC6650")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7AC6600", Offset = "0x7AC5000", VA = "0x187AC6600")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 EDGHDDPDDIA(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7AC0E30", Offset = "0x7ABF830", VA = "0x187AC0E30", Slot = "5")]
				public float3 EMNNPFFGIOC(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7AC0DF0", Offset = "0x7ABF7F0", VA = "0x187AC0DF0", Slot = "4")]
				public float3 EDGHDDPDDIA(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7AC3220", Offset = "0x7AC1C20", VA = "0x187AC3220", Slot = "4")]
				public float3 EDGHDDPDDIA(quaternion rotation)
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
			public NativeArray<FOFEFKICODD> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<CEGHMCHEJIL> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7DA0", Offset = "0x7AB67A0", VA = "0x187AB7DA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8D30", Offset = "0x7AB7730", VA = "0x187AB8D30")]
			private void NEHDNIBDBIB(NativeList<PointSrcData> srcData, NativeList<CEGHMCHEJIL> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7AB77E0", Offset = "0x7AB61E0", VA = "0x187AB77E0")]
			public static Vector3 DFBDOJEPBML(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8400", Offset = "0x7AB6E00", VA = "0x187AB8400")]
			public static quaternion FEMKHKJFFLM(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7AB75B0", Offset = "0x7AB5FB0", VA = "0x187AB75B0")]
			private static quaternion COMCNPDDPCO(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7AB88D0", Offset = "0x7AB72D0", VA = "0x187AB88D0")]
			private static float3 HPNCMPOLPBK(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7AB71F0", Offset = "0x7AB5BF0", VA = "0x187AB71F0")]
			private static quaternion AJLIKPMLOEL(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8480", Offset = "0x7AB6E80", VA = "0x187AB8480")]
			private static CEGHMCHEJIL GFJKIOEANNP(int idx, NativeList<PointSrcData> srcData)
			{
				return default(CEGHMCHEJIL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3D462A0", Offset = "0x3D44CA0", VA = "0x183D462A0")]
			private void MIKFIDNBMAG<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7AB9C10", Offset = "0x7AB8610", VA = "0x187AB9C10")]
			private void NGIPPFNDPPE(NativeList<PointSrcData> sourcePoints, NativeList<CEGHMCHEJIL> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7280", Offset = "0x7AB5C80", VA = "0x187AB7280")]
			public static float AMJGAENELNF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8B40", Offset = "0x7AB7540", VA = "0x187AB8B40")]
			private static quaternion MKJEJCHFBCA(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7400", Offset = "0x7AB5E00", VA = "0x187AB7400")]
			private static CEGHMCHEJIL APOBAFDOHKL(PointSrcData point)
			{
				return default(CEGHMCHEJIL);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7520", Offset = "0x7AB5F20", VA = "0x187AB7520")]
			private static CEGHMCHEJIL APOBAFDOHKL(float3 pos, quaternion rot, float radius)
			{
				return default(CEGHMCHEJIL);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB8AA0", Offset = "0x7AB74A0", VA = "0x187AB8AA0")]
			private static bool KPKFEFKABKJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAE80", Offset = "0x7AB9880", VA = "0x187ABAE80")]
			private static float3 PJCABKJMEIE(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7040", Offset = "0x7AB5A40", VA = "0x187AB7040")]
			public static float3 AABLFNHOAKG(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7BF0", Offset = "0x7AB65F0", VA = "0x187AB7BF0")]
			public static float3 EMNNPFFGIOC(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7ABAA20", Offset = "0x7AB9420", VA = "0x187ABAA20")]
			private static quaternion NLOOLAPANFM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7AB86F0", Offset = "0x7AB70F0", VA = "0x187AB86F0")]
			private static float HDICNCEPAPH(float3 from, float3 to)
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

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8DD0", Offset = "0x7AC77D0", VA = "0x187AC8DD0")]
			private void CLCPOIIMDLC(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC8EB0", Offset = "0x7AC78B0", VA = "0x187AC8EB0", Slot = "4")]
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
			public NativeList<CEGHMCHEJIL> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA020", Offset = "0x7AC8A20", VA = "0x187ACA020")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA080", Offset = "0x7AC8A80", VA = "0x187ACA080", Slot = "4")]
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
			public NativeList<CEGHMCHEJIL> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9FC0", Offset = "0x7AC89C0", VA = "0x187AC9FC0")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7ACA010", Offset = "0x7AC8A10", VA = "0x187ACA010", Slot = "4")]
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
			public NativeList<OGIHPHMGAJP> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6C60", Offset = "0x7AB5660", VA = "0x187AB6C60")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6E20", Offset = "0x7AB5820", VA = "0x187AB6E20", Slot = "4")]
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
			public NativeList<FOFEFKICODD> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<JODDDPLLHMC> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6E30", Offset = "0x7AB5830", VA = "0x187AB6E30")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7AB7030", Offset = "0x7AB5A30", VA = "0x187AB7030", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9B90", Offset = "0x7AC8590", VA = "0x187AC9B90")]
			private void CLCPOIIMDLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7AC9FB0", Offset = "0x7AC89B0", VA = "0x187AC9FB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly LMPJBEBLCLM log;

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
		private KPNAOMAKIAK replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private HOECEAHHGFN objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private KEFFHEKDKEJ bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private BMKLAKIKJIF ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7CD0", Offset = "0x7AC66D0", VA = "0x187AC7CD0", Slot = "15")]
		public override void InitReferences(LBHNIGEPODB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9430", Offset = "0x7AC7E30", VA = "0x187AC9430", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9520", Offset = "0x7AC7F20", VA = "0x187AC9520", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AC9580", Offset = "0x7AC7F80", VA = "0x187AC9580", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7290", Offset = "0x7AC5C90", VA = "0x187AC7290")]
		private JobHandle FKNAFPNCKKE(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6910", Offset = "0x7AC5310", VA = "0x187AC6910")]
		private JobHandle FBPFANFJCHH(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6670", Offset = "0x7AC5070", VA = "0x187AC6670")]
		private JobHandle JJIMNLFDCKC(NativeArray<int> pointCount, NativeList<CEGHMCHEJIL> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8240", Offset = "0x7AC6C40", VA = "0x187AC8240")]
		private JobHandle JGCIBBAAEGK(NativeList<CEGHMCHEJIL> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7D70", Offset = "0x7AC6770", VA = "0x187AC7D70")]
		private JobHandle JABMDPIJJJK(EntityQuery query, NativeList<FOFEFKICODD> splinePointRanges, NativeList<CEGHMCHEJIL> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8CB0", Offset = "0x7AC76B0", VA = "0x187AC8CB0")]
		private JobHandle LPHPPOAOPCJ(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7AC87F0", Offset = "0x7AC71F0", VA = "0x187AC87F0")]
		private JobHandle KPKNMFLOIIH(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7950", Offset = "0x7AC6350", VA = "0x187AC7950")]
		private JobHandle HIIFCBAMKLP(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<OGIHPHMGAJP> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6FD0", Offset = "0x7AC59D0", VA = "0x187AC6FD0")]
		private JobHandle FDFMNJNHKBN(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<FOFEFKICODD> splinePointRanges, [Out] NativeList<JODDDPLLHMC> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC75D0", Offset = "0x7AC5FD0", VA = "0x187AC75D0")]
		private JobHandle GMGKONAEKON(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7AC82E0", Offset = "0x7AC6CE0", VA = "0x187AC82E0")]
		private JobHandle JOMILOJBELD(EntityQuery query, NativeList<OGIHPHMGAJP> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7AC96F0", Offset = "0x7AC80F0", VA = "0x187AC96F0")]
		private static NativeParallelHashMap<int, BPEIFANGIJA> POHOBLNBLHD()
		{
			return default(NativeParallelHashMap<int, BPEIFANGIJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8910", Offset = "0x7AC7310", VA = "0x187AC8910")]
		private JobHandle LBCLJMKDHFD(EntityQuery query, NativeList<FOFEFKICODD> splinePointRanges, NativeList<CEGHMCHEJIL> splinePointData, NativeList<JODDDPLLHMC> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7BF0", Offset = "0x7AC65F0", VA = "0x187AC7BF0")]
		private JobHandle IKPCHMBHIIH(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6670", Offset = "0x7AC5070", VA = "0x187AC6670")]
		private JobHandle AILGBHFDDEC(NativeArray<int> pointCount, NativeList<CEGHMCHEJIL> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8240", Offset = "0x7AC6C40", VA = "0x187AC8240")]
		private JobHandle NDNJPMLDBMH(NativeList<CEGHMCHEJIL> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6710", Offset = "0x7AC5110", VA = "0x187AC6710")]
		private JobHandle APFKMEFIFNH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<OGIHPHMGAJP> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6800", Offset = "0x7AC5200", VA = "0x187AC6800")]
		private JobHandle CAKEAKDFIHH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<FOFEFKICODD> ranges, NativeList<JODDDPLLHMC> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7AC8FA0", Offset = "0x7AC79A0", VA = "0x187AC8FA0")]
		private JobHandle MEBPJAOMNKE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7AC90F0", Offset = "0x7AC7AF0", VA = "0x187AC90F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class BNLOCLLFAND : IMFEJPHBKOA, KFPIMHBKPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private KEFFHEKDKEJ HAJDHEHGIMP;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2410", Offset = "0x7AB0E10", VA = "0x187AB2410", Slot = "14")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2460", Offset = "0x7AB0E60", VA = "0x187AB2460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
	public BNLOCLLFAND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class APEHAHIADFA : OODCEDJDLFK, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct NDMHHCGGKJE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager IOCALHHKFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private EENFHEOECFN<T> GJKBBDJJMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int DOAKEFBOPIA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x51983D0", Offset = "0x5196DD0", VA = "0x1851983D0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x51987B0", Offset = "0x51971B0", VA = "0x1851987B0")]
		public NDMHHCGGKJE(EntityManager IOCALHHKFGN, EENFHEOECFN<T> GJKBBDJJMHF, NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x442B190", Offset = "0x4429B90", VA = "0x18442B190")]
		public NDMHHCGGKJE<T> KCFKLFFNEEA()
		{
			return default(NDMHHCGGKJE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5198690", Offset = "0x5197090", VA = "0x185198690")]
		public bool FMNODPIACON()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly LMPJBEBLCLM CGNKCFHLIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private JABONDMAHIA KNEENDICBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private KEFFHEKDKEJ HAJDHEHGIMP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7AAFF20", Offset = "0x7AAE920", VA = "0x187AAFF20", Slot = "15")]
	public override void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEE10", Offset = "0x7AAD810", VA = "0x187AAEE10")]
	public void GJAJDKAECDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB11D0", Offset = "0x7AAFBD0", VA = "0x187AB11D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEE40", Offset = "0x7AAD840", VA = "0x187AAEE40")]
	private void HCLCJBKFAGK(ILLFADGCMBH FLPDJFEEMLN, Mesh[] IDAOLDLBKHN, NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB80C0", Offset = "0x3DB6AC0", VA = "0x183DB80C0")]
	private NDMHHCGGKJE<T> FDIBKAHMNMK<T>(EENFHEOECFN<T> GJKBBDJJMHF, NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ) where T : struct
	{
		return default(NDMHHCGGKJE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAEA80", Offset = "0x7AAD480", VA = "0x187AAEA80")]
	private void EBFGPMMIPOF(Transform HGBJMKAPAJA, NativeArray<BLDAGBCEGEM> LGEJIDGFMCK, HPNOBMMHMAN<GameObject> GDOHDHJGJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE5B0", Offset = "0x7AACFB0", VA = "0x187AAE5B0")]
	private void DPJBLHHNMPO(Transform HGBJMKAPAJA, NativeArray<KBJFMEKNOIC> EBJGKLNGLNK, HPNOBMMHMAN<GameObject> GDOHDHJGJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7AB07D0", Offset = "0x7AAF1D0", VA = "0x187AB07D0")]
	private void MFNFENKBNIP(Transform HGBJMKAPAJA, NativeArray<MLHKPLJHOCE> GMNGHICOLLH, HPNOBMMHMAN<GameObject> GDOHDHJGJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0390", Offset = "0x7AAED90", VA = "0x187AB0390")]
	private void KIDDIDAHJKA(Transform HGBJMKAPAJA, NativeArray<FDKLNMHPLEJ> IDAOLDLBKHN, Mesh[] JHABBFCKHBB, HPNOBMMHMAN<GameObject> GDOHDHJGJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD8F0", Offset = "0x7AAC2F0", VA = "0x187AAD8F0")]
	private static void CPNMCMCAGCL(NativeParallelHashSet<Entity> GABLPEMHKBP, NativeParallelHashSet<Entity> DEBCDCFEKOA, NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7AB1110", Offset = "0x7AAFB10", VA = "0x187AB1110")]
	private static void NKLNEELAHNB(NativeList<Entity> FMFEHIEKOMI, NativeArray<EntityRemapUtility.EntityRemapInfo> NCPKIGJLCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7AADA40", Offset = "0x7AAC440", VA = "0x187AADA40")]
	private NativeParallelHashMap<Entity, LCEJOPGCPMJ> DOLFOIHFOBM(KEFFHEKDKEJ.EAIOFIOLKLJ NBPAOPIJKHP, ECNLMIPFCAI<GPNGMMMJCBN> NAIBFDEOEOB, List<GameObject> GDOHDHJGJCD)
	{
		return default(NativeParallelHashMap<Entity, LCEJOPGCPMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD7F0", Offset = "0x7AAC1F0", VA = "0x187AAD7F0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BJICNKALPMF(Entity FAFFHDDKPPM)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7AB0BC0", Offset = "0x7AAF5C0", VA = "0x187AB0BC0")]
	private void NBEDLOGEAKH(NativeList<Entity> ILAIDLNJHIA, NativeList<Entity> GMPHJIMLDCG, NativeParallelHashMap<Entity, LCEJOPGCPMJ> IGJOJMBKDMH, NativeList<FOFEFKICODD> DFJPMGFIGOK, NativeList<CEGHMCHEJIL> MOLCNIGANJH, NativeList<JODDDPLLHMC> ENNNDGGELOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7AAFFA0", Offset = "0x7AAE9A0", VA = "0x187AAFFA0")]
	private void JMBEDHOLHAH(NativeList<Entity> GABLPEMHKBP, NativeList<Entity> DHKHEFACEBO, NativeParallelHashMap<Entity, LCEJOPGCPMJ> IGJOJMBKDMH, NativeList<OGIHPHMGAJP> IAKGPOKOJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2400", Offset = "0x7AB0E00", VA = "0x187AB2400")]
	public APEHAHIADFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class AIOKFFCFLMF : FCPOOFIHPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS AGNKFGEDAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DFLEJIJCDEG HGBJMKAPAJA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject LJBHLJGFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS DJEDBPCNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD670", Offset = "0x7AAC070", VA = "0x187AAD670", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 LFLHPBCHDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD5D0", Offset = "0x7AABFD0", VA = "0x187AAD5D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 CIKGPENDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD4E0", Offset = "0x7AABEE0", VA = "0x187AAD4E0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 INEEIGKJABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD3F0", Offset = "0x7AABDF0", VA = "0x187AAD3F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD580", Offset = "0x7AABF80", VA = "0x187AAD580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion IEFJODHLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD530", Offset = "0x7AABF30", VA = "0x187AAD530", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD490", Offset = "0x7AABE90", VA = "0x187AAD490", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 MADPDENEDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD620", Offset = "0x7AAC020", VA = "0x187AAD620", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 LKKGNGLEHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD440", Offset = "0x7AABE40", VA = "0x187AAD440", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 FOKIKJJCBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD750", Offset = "0x7AAC150", VA = "0x187AAD750", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD7A0", Offset = "0x7AAC1A0", VA = "0x187AAD7A0")]
	public AIOKFFCFLMF(UniformTRS AGNKFGEDAEE, DFLEJIJCDEG HGBJMKAPAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class CPHBIBJHOAM : AIOKFFCFLMF, INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float EEILIJKHAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 ALGNLMNEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ADADNEEPCEF CNPOKMNHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly KJDEIJDKCCB PIFNBLMLAMH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private FJCDPKDIACD DBIFAIALCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2480", Offset = "0x7AB0E80", VA = "0x187AB2480", Slot = "17")]
		get
		{
			return default(FJCDPKDIACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS KGDJIHLLKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AB24D0", Offset = "0x7AB0ED0", VA = "0x187AB24D0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float BAPEEALIDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB91A90", Offset = "0xB90490", VA = "0x180B91A90", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 FMGPIOEJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7AB25B0", Offset = "0x7AB0FB0", VA = "0x187AB25B0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private ADADNEEPCEF ADGKHFECFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xDD8F10", Offset = "0xDD7910", VA = "0x180DD8F10", Slot = "21")]
		get
		{
			return default(ADADNEEPCEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private KJDEIJDKCCB LEKMMHMMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x128B080", Offset = "0x1289A80", VA = "0x18128B080", Slot = "22")]
		get
		{
			return default(KJDEIJDKCCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool HBHMLLDBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EIDHKNJDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2600", Offset = "0x7AB1000", VA = "0x187AB2600")]
	protected CPHBIBJHOAM(UniformTRS AGNKFGEDAEE, DFLEJIJCDEG HGBJMKAPAJA, float EEILIJKHAHG, float3 ALGNLMNEICO, ADADNEEPCEF CNPOKMNHKGC, KJDEIJDKCCB PIFNBLMLAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class JNMANKGAEBJ : FCPOOFIHPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly ECEDHFIPBHO OHLJFNOIPDI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected DFLEJIJCDEG IBFGPMEBEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1072220", Offset = "0x1070C20", VA = "0x181072220")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC760", Offset = "0x7ABB160", VA = "0x187ABC760")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected HOECEAHHGFN OFJMFPBDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC750", Offset = "0x7ABB150", VA = "0x187ABC750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected PEBMNHFMPEL FMHELOONJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC260", Offset = "0x7ABAC60", VA = "0x187ABC260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected PDMBJJLECEJ GAAGAGBOFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC6C0", Offset = "0x7ABB0C0", VA = "0x187ABC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject LJBHLJGFFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC3B0", Offset = "0x7ABADB0", VA = "0x187ABC3B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS DJEDBPCNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x10910A0", Offset = "0x108FAA0", VA = "0x1810910A0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 LFLHPBCHDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC2C0", Offset = "0x7ABACC0", VA = "0x187ABC2C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 CIKGPENDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBEA0", Offset = "0x7ABA8A0", VA = "0x187ABBEA0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 INEEIGKJABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBAA0", Offset = "0x7ABA4A0", VA = "0x187ABBAA0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC150", Offset = "0x7ABAB50", VA = "0x187ABC150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion IEFJODHLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC030", Offset = "0x7ABAA30", VA = "0x187ABC030", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBD90", Offset = "0x7ABA790", VA = "0x187ABBD90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 MADPDENEDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC3E0", Offset = "0x7ABADE0", VA = "0x187ABC3E0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 LKKGNGLEHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBD0", Offset = "0x7ABA5D0", VA = "0x187ABBBD0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 FOKIKJJCBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC500", Offset = "0x7ABAF00", VA = "0x187ABC500", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xD711E0", Offset = "0xD6FBE0", VA = "0x180D711E0")]
	protected JNMANKGAEBJ(ECEDHFIPBHO HDDPFCMNNBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7ABC4D0", Offset = "0x7ABAED0", VA = "0x187ABC4D0")]
	public static FJCDPKDIACD MEHFEEABIDG(JNMANKGAEBJ PPOLMDFNGFC)
	{
		return default(FJCDPKDIACD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LENEEHBHOOO
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBBC0", Offset = "0x7ACA5C0", VA = "0x187ACBBC0")]
	public static void NNJMJEEGIEO(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EONKJGOPENG
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7ACAB50", Offset = "0x7AC9550", VA = "0x187ACAB50")]
	public static void BLFDHDBAAFE(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN, AMDEOGDAEEI LKGCGDAJEPM, HOECEAHHGFN DOOFKBLICCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7ACAF60", Offset = "0x7AC9960", VA = "0x187ACAF60")]
	public static void GIAGOMNGMEI(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN, AMDEOGDAEEI LKGCGDAJEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB2B0", Offset = "0x7AC9CB0", VA = "0x187ACB2B0")]
	public static NativeList<Entity> HGIDNMDFDFL(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB270", Offset = "0x7AC9C70", VA = "0x187ACB270")]
	public static NativeList<Entity> HEIAOOPDEPP(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB2F0", Offset = "0x7AC9CF0", VA = "0x187ACB2F0")]
	private static NativeList<Entity> HGIDNMDFDFL(NativeArray<Entity> GABLPEMHKBP, EntityManager IOCALHHKFGN, bool OMHNGMKOBAB)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class FHLHKIIHCIJ : JNMANKGAEBJ, INKAKBMLPEF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float EEILIJKHAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 ALGNLMNEICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private ADADNEEPCEF CNPOKMNHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private KJDEIJDKCCB PIFNBLMLAMH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager JIDOJAHOFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB580", Offset = "0x7AC9F80", VA = "0x187ACB580")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MIAJELHJLFO CGCFOLKHODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB7A0", Offset = "0x7ACA1A0", VA = "0x187ACB7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData MHLKHEIJJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB800", Offset = "0x7ACA200", VA = "0x187ACB800")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FJCDPKDIACD DBIFAIALCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC4D0", Offset = "0x7ABAED0", VA = "0x187ABC4D0", Slot = "17")]
		get
		{
			return default(FJCDPKDIACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float BAPEEALIDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD30", Offset = "0xE5E730", VA = "0x180E5FD30", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 FMGPIOEJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1510090", Offset = "0x150EA90", VA = "0x181510090", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private ADADNEEPCEF ADGKHFECFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540", Slot = "21")]
		get
		{
			return default(ADADNEEPCEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private KJDEIJDKCCB LEKMMHMMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xBF57B0", Offset = "0xBF41B0", VA = "0x180BF57B0", Slot = "22")]
		get
		{
			return default(KJDEIJDKCCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS KGDJIHLLKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACB550", Offset = "0x7AC9F50", VA = "0x187ACB550", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EIDHKNJDLOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF20", Offset = "0x9D9920", VA = "0x1809DAF20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD40", Offset = "0x9D9740", VA = "0x1809DAD40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool HBHMLLDBMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB8F0", Offset = "0x7ACA2F0", VA = "0x187ACB8F0")]
	protected FHLHKIIHCIJ(ECEDHFIPBHO HDDPFCMNNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB610", Offset = "0x7ACA010", VA = "0x187ACB610", Slot = "26")]
	public virtual void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class OODCEDJDLFK : IMFEJPHBKOA, KFPIMHBKPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected HOECEAHHGFN DOOFKBLICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private EDBGHLHADIK OADJGMBHLBP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected AMDEOGDAEEI KNLOAKJHFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBEB0", Offset = "0x7ACA8B0", VA = "0x187ACBEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected HBJPHKMFDDO CHGKFNOICGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBE60", Offset = "0x7ACA860", VA = "0x187ACBE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool PDDCHCCCDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7ACBF00", Offset = "0x7ACA900", VA = "0x187ACBF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBFC0", Offset = "0x7ACA9C0", VA = "0x187ACBFC0", Slot = "15")]
	public virtual void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
	protected OODCEDJDLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IMPNCBOPNNI
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB980", Offset = "0x7ACA380", VA = "0x187ACB980")]
	public static void LDMJAMCOPBD(NativeArray<Entity> ILAIDLNJHIA, EntityManager IOCALHHKFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3995630665
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC200", Offset = "0x7ACAC00", VA = "0x187ACC200")]
	public static void PBGLILIDOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC1F0", Offset = "0x7ACABF0", VA = "0x187ACC1F0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class IJPEFOIHBJC : ContainerPropertyBag<GGFHBAHPAOM>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7ACB920", Offset = "0x7ACA320", VA = "0x187ACB920")]
	public IJPEFOIHBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class NEBKBFKMDEA : ContainerPropertyBag<NOJMEBGKJHH>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7ACBE00", Offset = "0x7ACA800", VA = "0x187ACBE00")]
	public NEBKBFKMDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class EKJDFBMJLEC : ContainerPropertyBag<NBMMCMIGGNH>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACAAF0", Offset = "0x7AC94F0", VA = "0x187ACAAF0")]
	public EKJDFBMJLEC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC030", Offset = "0x7ACAA30", VA = "0x187ACC030")]
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
