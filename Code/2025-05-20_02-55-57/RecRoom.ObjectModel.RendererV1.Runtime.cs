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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E73260", Offset = "0x7E72460", VA = "0x187E73260", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2085180", Offset = "0x2084380", VA = "0x182085180", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E84680", Offset = "0x7E83880", VA = "0x187E84680")]
		private void NDIKJDPGAHM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E84C20", Offset = "0x7E83E20", VA = "0x187E84C20", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E84C80", Offset = "0x7E83E80", VA = "0x187E84C80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BFBHAALKGNN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E65F00", Offset = "0x7E65100", VA = "0x187E65F00")]
	public static Quaternion GCOMKNMJAOL([In] this BINKOKKDEAA GBPLADNDALN, [In] Vector3 ACBMNMFGAEN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MMNCNLGFECM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E76220", Offset = "0x7E75420", VA = "0x187E76220")]
	public static bool KAMIFGNEFBN(this AGHJBFIKNCN KGNMGMAIJAA, OMNIHJEOLPK ONCELMGACCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E74AC0", Offset = "0x7E73CC0", VA = "0x187E74AC0")]
	public static bool CABKMLAEHFG(this AGHJBFIKNCN KGNMGMAIJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E76260", Offset = "0x7E75460", VA = "0x187E76260")]
	public static bool MHFPDGAMMJD(this AGHJBFIKNCN KGNMGMAIJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E74E20", Offset = "0x7E74020", VA = "0x187E74E20")]
	public static void GKHKFPDODHE(this AGHJBFIKNCN KGNMGMAIJAA, Vector3 FDAPOKGCLFA, Quaternion MOGJIJPMHLC, float IHBIKJPLAHJ, bool MCFMAGOLIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E75620", Offset = "0x7E74820", VA = "0x187E75620")]
	public static void IMOPKPEKDNM(this AGHJBFIKNCN KGNMGMAIJAA, Vector3 FDAPOKGCLFA, Quaternion MOGJIJPMHLC, float IHBIKJPLAHJ, int NKMIOCBMNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E76290", Offset = "0x7E75490", VA = "0x187E76290")]
	public static void MHNJLCJEELK(this AGHJBFIKNCN KGNMGMAIJAA, int NKMIOCBMNAP, Vector3 FDAPOKGCLFA, Quaternion MOGJIJPMHLC, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E763B0", Offset = "0x7E755B0", VA = "0x187E763B0")]
	public static void MJADNFPBAEG(this AGHJBFIKNCN KGNMGMAIJAA, Vector3 HOIMINLENLG, Quaternion EPIENMIPMJE, float IHBIKJPLAHJ, bool MCFMAGOLIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E758A0", Offset = "0x7E74AA0", VA = "0x187E758A0")]
	private static void JBKJKIFCBLC(this AGHJBFIKNCN KGNMGMAIJAA, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ, bool MCFMAGOLIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E76400", Offset = "0x7E75600", VA = "0x187E76400")]
	private static void NBFMNPCKJKN(this AGHJBFIKNCN KGNMGMAIJAA, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, float ILAEOJMCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E75440", Offset = "0x7E74640", VA = "0x187E75440")]
	private static void HJOEDPBDNMF(this AGHJBFIKNCN KGNMGMAIJAA, int NIBICIJAIGM, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, float ILAEOJMCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E761F0", Offset = "0x7E753F0", VA = "0x187E761F0")]
	private static bool JGMKNHFGIMA(this AGHJBFIKNCN KGNMGMAIJAA, int NIBICIJAIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E74830", Offset = "0x7E73A30", VA = "0x187E74830")]
	private static void BDPHKIOEEKO(this AGHJBFIKNCN KGNMGMAIJAA, int NIBICIJAIGM, Vector3 KGEICFIBDCA, Quaternion JLBNIDPEHNC, float ILAEOJMCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E74F50", Offset = "0x7E74150", VA = "0x187E74F50")]
	public static Vector3 HHCPNMCHGGL(this AGHJBFIKNCN KGNMGMAIJAA, int NIBICIJAIGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E74D10", Offset = "0x7E73F10", VA = "0x187E74D10")]
	public static Quaternion FIMMLHFJMFJ(this AGHJBFIKNCN KGNMGMAIJAA, int NIBICIJAIGM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E74AF0", Offset = "0x7E73CF0", VA = "0x187E74AF0")]
	public static Vector3 ECLEFMCFDOH(OMNIHJEOLPK MJJLCGKEEJD, Vector3 BJHAAAPCKLC, Vector3? KEAJDGABMLK, Vector3 OEDMDPPAFHE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface KDHHMBFCBPI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIJKNNKHNGO(EntityQuery OJJIKCPLFJH, EntityManager EPEFONCBOCP, MDGGINJLEMI GBEOAHCNHMI, GILDGMCIDNJ LHNECKJGJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface MHOFNNAPMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType OIEPFBGDJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCOOBOFBGPB(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPNGLCLBOBA(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LGACNBGMOKH(DNOHAGJNPAP GHBBKLJANGP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class BINNBPALNBI : KDHHMBFCBPI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E66C80", Offset = "0x7E65E80", VA = "0x187E66C80", Slot = "4")]
	public void OIJKNNKHNGO(EntityQuery OJJIKCPLFJH, EntityManager EPEFONCBOCP, MDGGINJLEMI GBEOAHCNHMI, GILDGMCIDNJ LHNECKJGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BINNBPALNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class OIBMHMPIMHB : KDHHMBFCBPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CNMFJGBLGMD FGFHIDECMGG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
	public OIBMHMPIMHB(CNMFJGBLGMD FGFHIDECMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E783D0", Offset = "0x7E775D0", VA = "0x187E783D0", Slot = "4")]
	public void OIJKNNKHNGO(EntityQuery OJJIKCPLFJH, EntityManager EPEFONCBOCP, MDGGINJLEMI GBEOAHCNHMI, GILDGMCIDNJ LHNECKJGJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HFKMNJANEJD : KDHHMBFCBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F4C0", Offset = "0x7E6E6C0", VA = "0x187E6F4C0", Slot = "4")]
	public void OIJKNNKHNGO(EntityQuery OJJIKCPLFJH, EntityManager EPEFONCBOCP, MDGGINJLEMI GBEOAHCNHMI, GILDGMCIDNJ LHNECKJGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HFKMNJANEJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CMCKIEDICLH : MHOFNNAPMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType OIEPFBGDJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E67660", Offset = "0x7E66860", VA = "0x187E67660", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E67960", Offset = "0x7E66B60", VA = "0x187E67960", Slot = "5")]
	public void NCOOBOFBGPB(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E676E0", Offset = "0x7E668E0", VA = "0x187E676E0", Slot = "6")]
	public void MPNGLCLBOBA(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E67690", Offset = "0x7E66890", VA = "0x187E67690", Slot = "7")]
	public void LGACNBGMOKH(DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CMCKIEDICLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OJICHCFDGJA : MHOFNNAPMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType OIEPFBGDJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E78520", Offset = "0x7E77720", VA = "0x187E78520", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E78820", Offset = "0x7E77A20", VA = "0x187E78820", Slot = "5")]
	public void NCOOBOFBGPB(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E785A0", Offset = "0x7E777A0", VA = "0x187E785A0", Slot = "6")]
	public void MPNGLCLBOBA(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E78550", Offset = "0x7E77750", VA = "0x187E78550", Slot = "7")]
	public void LGACNBGMOKH(DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OJICHCFDGJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GBPIANDECPK : MHOFNNAPMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType OIEPFBGDJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E69C70", Offset = "0x7E68E70", VA = "0x187E69C70", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E69F70", Offset = "0x7E69170", VA = "0x187E69F70", Slot = "5")]
	public void NCOOBOFBGPB(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E69CF0", Offset = "0x7E68EF0", VA = "0x187E69CF0", Slot = "6")]
	public void MPNGLCLBOBA(EntityQuery OJJIKCPLFJH, DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E69CA0", Offset = "0x7E68EA0", VA = "0x187E69CA0", Slot = "7")]
	public void LGACNBGMOKH(DNOHAGJNPAP GHBBKLJANGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GBPIANDECPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class JPCDHLPLBNJ : FNPANKDKAKI, IELLFNEFJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private MDGGINJLEMI GBEOAHCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PBNJILOJLGI OFCGDFCHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GILDGMCIDNJ LHNECKJGJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, KDHHMBFCBPI adapter)> FGOPHCAJIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E72960", Offset = "0x7E71B60", VA = "0x187E72960", Slot = "15")]
	public virtual void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E729F0", Offset = "0x7E71BF0", VA = "0x187E729F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E727F0", Offset = "0x7E719F0", VA = "0x187E727F0")]
	private void BNDBCGNDPJO(EntityQueryDesc ODMNDGGNEHM, KDHHMBFCBPI NAKGHKILGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E72C20", Offset = "0x7E71E20", VA = "0x187E72C20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
	public JPCDHLPLBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class FLHKHKFEKOH : FNPANKDKAKI, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LJKDDAIMCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery AHBFBLJOJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery EGFEJEHFIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery OFCFHDCMHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery PFINOPHBDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery AJDPMHEMLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery EONCJDCAEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery CODHNKPJIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MHOFNNAPMOI GNEBAOPLIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType ILHGFCDPINE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LJKDDAIMCFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private MDGGINJLEMI GBEOAHCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private GILDGMCIDNJ LHNECKJGJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PBNJILOJLGI OFCGDFCHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<LJKDDAIMCFO> FGOPHCAJIPJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E69380", Offset = "0x7E68580", VA = "0x187E69380", Slot = "14")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E69860", Offset = "0x7E68A60", VA = "0x187E69860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E699E0", Offset = "0x7E68BE0", VA = "0x187E699E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E69410", Offset = "0x7E68610", VA = "0x187E69410")]
	private void JPNJEMPNBGF(LJKDDAIMCFO GFDBNDLPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E68C40", Offset = "0x7E67E40", VA = "0x187E68C40")]
	private void BNDBCGNDPJO(MHOFNNAPMOI GNEBAOPLIPD, ComponentType MGCLMJHFDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
	public FLHKHKFEKOH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct GBOIGCEGIMM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct LBMCFKFIHDI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct IONDBJPAEFC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(GILDGMCIDNJ), new string[] { })]
public class CGJAJPFIGAN : GILDGMCIDNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LIGLMNBGNIO HMKMHDCAGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LIGLMNBGNIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CGJAJPFIGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(BHFLIOCIKLJ), new string[] { })]
public class DGDMMMCFPCL : BHFLIOCIKLJ, PLEAAKNHJFO, BJIBPMDIMDH, GKBPCKLNOCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private JLPHHADBBLP NKENFIFGFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private MDGGINJLEMI GBEOAHCNHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private IPHDOCEGNCL PKCEHJLPOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity KPDACPANICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private HEJBBJOONEM GMOACJIBKFM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E681E0", Offset = "0x7E673E0", VA = "0x187E681E0", Slot = "4")]
	public bool NEGGLIPOLKA(HAONCNNABLP EANCCIKOAFJ, JJCDHLJFLKO MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E67E10", Offset = "0x7E67010", VA = "0x187E67E10", Slot = "5")]
	public HEJBBJOONEM IMKKLNAJJJA()
	{
		return default(HEJBBJOONEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E680D0", Offset = "0x7E672D0", VA = "0x187E680D0", Slot = "6")]
	public void KLCGJKGKFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E682C0", Offset = "0x7E674C0", VA = "0x187E682C0", Slot = "7")]
	private void NPKMOIIMNFA(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11AE320", Offset = "0x11AD520", VA = "0x1811AE320", Slot = "8")]
	private void JNNNBCINACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DGDMMMCFPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(HIBHLLPIMIB), new string[] { })]
public class IKOFJJFILAE : HIBHLLPIMIB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E70130", Offset = "0x7E6F330", VA = "0x187E70130", Slot = "4")]
	public void MICDPFELEAJ(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F760", Offset = "0x7E6E960", VA = "0x187E6F760", Slot = "5")]
	public void EFMIAKLMJJC(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E70010", Offset = "0x7E6F210", VA = "0x187E70010", Slot = "6")]
	public ComponentSystemBase IICBFLHAGFJ(World NKENFIFGFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F700", Offset = "0x7E6E900", VA = "0x187E6F700", Slot = "7")]
	public void DAIDFJHCNGE(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E6FFB0", Offset = "0x7E6F1B0", VA = "0x187E6FFB0", Slot = "8")]
	public void GBJOIKBNBPF(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E700D0", Offset = "0x7E6F2D0", VA = "0x187E700D0", Slot = "9")]
	public void LJGCNPKKGLH(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E70060", Offset = "0x7E6F260", VA = "0x187E70060", Slot = "10")]
	public void KLIELDMEKOK(World NKENFIFGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F7B0", Offset = "0x7E6E9B0", VA = "0x187E6F7B0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> EIAOFBIAPHJ()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IKOFJJFILAE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct ELFLJIMEGOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct MLJNGDCGGOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FDFCOBOFJIA : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CJMNDOAJBNF IIDFAAJEINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E68B30", Offset = "0x7E67D30", VA = "0x187E68B30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E68AC0", Offset = "0x7E67CC0", VA = "0x187E68AC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FDFCOBOFJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct PBLFHEHCKOH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public HEJBBJOONEM JOONKKIKCBH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static PBLFHEHCKOH NEKLFDMHCNA(HEJBBJOONEM NLNGJFNOHGL)
	{
		return default(PBLFHEHCKOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KIBGAKCNFHC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NPAJLANHHDD AILAECKEPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E72E10", Offset = "0x7E72010", VA = "0x187E72E10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KIBGAKCNFHC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct FGCMNLAFFFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct HGMLJFHFDJI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public FJJNPNKHKFF BFGFGDFNJCN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static HGMLJFHFDJI NEKLFDMHCNA(FJJNPNKHKFF NLNGJFNOHGL)
	{
		return default(HGMLJFHFDJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct OOKIINHIDDK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HEJBBJOONEM JOONKKIKCBH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static OOKIINHIDDK NEKLFDMHCNA(HEJBBJOONEM NLNGJFNOHGL)
	{
		return default(OOKIINHIDDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FINIBKJMGGO : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CNEDPOGNDBG AOPAHPCKIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E68BF0", Offset = "0x7E67DF0", VA = "0x187E68BF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E68B80", Offset = "0x7E67D80", VA = "0x187E68B80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FINIBKJMGGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CPBCPHNHHHB : BAKBIJANPHN, CJMNDOAJBNF, JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EFDNHOFOELB GODHNAIMKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD34D90", Offset = "0xD33F90", VA = "0x180D34D90", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(EFDNHOFOELB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KNCGLOHGPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC129A0", Offset = "0xC11BA0", VA = "0x180C129A0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 BCBEMHEKLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x10C6650", Offset = "0x10C5850", VA = "0x1810C6650", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E67C30", Offset = "0x7E66E30", VA = "0x187E67C30")]
	public CPBCPHNHHHB(UniformTRS NHNDKCOGMKF, MCDCCMBIKEN NJHDJGHEICO, float FFHLABDMDPM, float3 DJFANKCCFCN, EPEJMPHDPHB OAOAKALKJPD, KBHAGNPMANG HEMCDJAHJFI, EFDNHOFOELB LNIKCCNMGEI, float3 LKIJBCNEOAB, bool OKIIGAMJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E67BE0", Offset = "0x7E66DE0", VA = "0x187E67BE0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BAMHABGGHLD : BAKBIJANPHN, CNEDPOGNDBG, JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<NOFEPGIGNGP> MLMJFGCLHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MPABIJINPFE MGEECOGALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float CHOICMFCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int OJOBKOPHLIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AKOHBLFNOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E65ED0", Offset = "0x7E650D0", VA = "0x187E65ED0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KGAMKAHFDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E65EF0", Offset = "0x7E650F0", VA = "0x187E65EF0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PNMFKGACHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E65EE0", Offset = "0x7E650E0", VA = "0x187E65EE0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PGPNCFPPDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD863B0", Offset = "0xD855B0", VA = "0x180D863B0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MCGNGODPHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC8D230", Offset = "0xC8C430", VA = "0x180C8D230", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NGNCNBKFGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF524E0", Offset = "0xF516E0", VA = "0x180F524E0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E65E20", Offset = "0x7E65020", VA = "0x187E65E20")]
	public BAMHABGGHLD(UniformTRS NHNDKCOGMKF, MCDCCMBIKEN NJHDJGHEICO, float FFHLABDMDPM, float3 DJFANKCCFCN, EPEJMPHDPHB OAOAKALKJPD, KBHAGNPMANG HEMCDJAHJFI, MPABIJINPFE MGEECOGALOB, float CHOICMFCEJA, int OJOBKOPHLIF, NativeArray<NOFEPGIGNGP> MLMJFGCLHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10F7640", Offset = "0x10F6840", VA = "0x1810F7640", Slot = "33")]
	public NativeArray<NOFEPGIGNGP> GetNativeCurvePoints()
	{
		return default(NativeArray<NOFEPGIGNGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E65D60", Offset = "0x7E64F60", VA = "0x187E65D60", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DGKMLENABNE : PDHPLOBFGFA, CJMNDOAJBNF, JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<JNBMIBPKCDD, EFDNHOFOELB> CDLOILDOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private EFDNHOFOELB LNIKCCNMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool OKIIGAMJHKC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private EFDNHOFOELB CKOLLFCAMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0", Slot = "28")]
		get
		{
			return default(EFDNHOFOELB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool FNJFBAHCDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xE2D920", Offset = "0xE2CB20", VA = "0x180E2D920", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 BCBEMHEKLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E689F0", Offset = "0x7E67BF0", VA = "0x187E689F0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E689D0", Offset = "0x7E67BD0", VA = "0x187E689D0")]
	public DGKMLENABNE(HAONCNNABLP DJMGIDJHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E68350", Offset = "0x7E67550", VA = "0x187E68350", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E683A0", Offset = "0x7E675A0", VA = "0x187E683A0", Slot = "26")]
	public override void IOJFMKAPHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NDFHCNBIICM : PNJBGJGODIP, NPAJLANHHDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject JGDFMCJIFPJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject FMNMJJFPHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E77610", Offset = "0x7E76810", VA = "0x187E77610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AOECEAGCFFM NBDDMFIBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E77510", Offset = "0x7E76710", VA = "0x187E77510", Slot = "15")]
		get
		{
			return default(AOECEAGCFFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IMKBGKEKPMO JKHPJJCGIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E777F0", Offset = "0x7E769F0", VA = "0x187E777F0", Slot = "16")]
		get
		{
			return default(IMKBGKEKPMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E776A0", Offset = "0x7E768A0", VA = "0x187E776A0")]
	public NDFHCNBIICM(HAONCNNABLP EANCCIKOAFJ, bool NPJLMPKEJEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E77380", Offset = "0x7E76580", VA = "0x187E77380")]
	public void HBJHLLKBEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E77510", Offset = "0x7E76710", VA = "0x187E77510")]
	protected AOECEAGCFFM JKGODJGNFPD()
	{
		return default(AOECEAGCFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E77200", Offset = "0x7E76400", VA = "0x187E77200")]
	private static bool AIMLNLAIAAH(HAONCNNABLP IFCFNFACFMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E77350", Offset = "0x7E76550", VA = "0x187E77350", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BINKOLMPGPJ : PDHPLOBFGFA, CNEDPOGNDBG, JHGPEPAFDAG, IDisposable, DEAIOHIJNMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<NOFEPGIGNGP> MLMJFGCLHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool LABJENGODDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool HJGCOJJPADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float CHOICMFCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OJOBKOPHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool FPNKCJNCDNN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool LMEEJEHGOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC1FDB0", Offset = "0xC1EFB0", VA = "0x180C1FDB0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool AKLKNKMPOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D020", Offset = "0xA3C220", VA = "0x180A3D020", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MFJHPAIGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x107F620", Offset = "0x107E820", VA = "0x18107F620", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int EADMFJJCECL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD34D90", Offset = "0xD33F90", VA = "0x180D34D90", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool JDLKEFBKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC129A0", Offset = "0xC11BA0", VA = "0x180C129A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int HJBKOIDIDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E66400", Offset = "0x7E65600", VA = "0x187E66400", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int CNHJNNCHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E66B60", Offset = "0x7E65D60", VA = "0x187E66B60", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E66C50", Offset = "0x7E65E50", VA = "0x187E66C50")]
	public BINKOLMPGPJ(HAONCNNABLP DJMGIDJHMIC, [Optional] NativeList<NOFEPGIGNGP> MLMJFGCLHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E66A20", Offset = "0x7E65C20", VA = "0x187E66A20", Slot = "26")]
	public override void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E66420", Offset = "0x7E65620", VA = "0x187E66420", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E66510", Offset = "0x7E65710", VA = "0x187E66510", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E66B00", Offset = "0x7E65D00", VA = "0x187E66B00")]
	public void MEPCHENHKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E666C0", Offset = "0x7E658C0", VA = "0x187E666C0", Slot = "34")]
	public NativeArray<NOFEPGIGNGP> GetNativeCurvePoints()
	{
		return default(NativeArray<NOFEPGIGNGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E66570", Offset = "0x7E65770", VA = "0x187E66570", Slot = "35")]
	private Vector3 EOGEACMIALK(int DLMCFJOIHHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E663D0", Offset = "0x7E655D0", VA = "0x187E663D0", Slot = "36")]
	private Quaternion BLOLNCPNKPK(int DLMCFJOIHHD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E66890", Offset = "0x7E65A90", VA = "0x187E66890", Slot = "37")]
	private float HGBBGELNMMM(int DLMCFJOIHHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E66360", Offset = "0x7E65560", VA = "0x187E66360")]
	private NativeArray<Entity> BEMGMHPHHPL()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class AFBNHDBCLPH : PBKDPJPOLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E65730", Offset = "0x7E64930", VA = "0x187E65730", Slot = "15")]
	protected override ComponentSystemBase MFFIBEFDMPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E65B40", Offset = "0x7E64D40", VA = "0x187E65B40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E65B50", Offset = "0x7E64D50", VA = "0x187E65B50")]
	public AFBNHDBCLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[CJHEJLEOLIP]
public sealed class PLFHGGMACHP : LBEEIHDLCKF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery AOODJMBDAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery MLBJLLGLDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery KGECAMMDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery BAFPFNNJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery JODABAEPIMP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F790", Offset = "0x7E7E990", VA = "0x187E7F790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FAF0", Offset = "0x7E7ECF0", VA = "0x187E7FAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F2E0", Offset = "0x7E7E4E0", VA = "0x187E7F2E0")]
	private void JAIICGIPHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F120", Offset = "0x7E7E320", VA = "0x187E7F120")]
	private void ECMJMEHLFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F5C0", Offset = "0x7E7E7C0", VA = "0x187E7F5C0")]
	private void LBAELBFGIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F020", Offset = "0x7E7E220", VA = "0x187E7F020")]
	private void CCHKILPHEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F4C0", Offset = "0x7E7E6C0", VA = "0x187E7F4C0")]
	private void JAJOOEHGKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F290", Offset = "0x7E7E490", VA = "0x187E7F290")]
	private NativeList<Entity> FLIMJFAJFFA(NativeArray<Entity> EEOGDGCIFOA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EFD0", Offset = "0x7E7E1D0", VA = "0x187E7EFD0")]
	private NativeList<Entity> AMLODLLGCFB(NativeArray<Entity> EEOGDGCIFOA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E7F230", Offset = "0x7E7E430", VA = "0x187E7F230")]
	private void EPAJPECIKCG(NativeArray<Entity> EEOGDGCIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public PLFHGGMACHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[CJHEJLEOLIP]
public sealed class PFDLFNPFPLK : LBEEIHDLCKF, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery GEDBHLGODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery GEKGBIEAEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery OFCFHDCMHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private BHFLIOCIKLJ KIKNNGDLDAJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E7ED60", Offset = "0x7E7DF60", VA = "0x187E7ED60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E670", Offset = "0x7E7D870", VA = "0x187E7E670", Slot = "15")]
	public override void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EF30", Offset = "0x7E7E130", VA = "0x187E7EF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E7DB10", Offset = "0x7E7CD10", VA = "0x187E7DB10")]
	private void FGNOGEKAHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E7DE30", Offset = "0x7E7D030", VA = "0x187E7DE30")]
	private void GJLEEHNNDAG(NativeParallelHashSet<HEJBBJOONEM> NOKGBKPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E6D0", Offset = "0x7E7D8D0", VA = "0x187E7E6D0")]
	private void OCPKDNKBODA(NativeParallelHashSet<HEJBBJOONEM> NOKGBKPBFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D760", Offset = "0x7E7C960", VA = "0x187E7D760")]
	private void CGNCEIGPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D6C0", Offset = "0x7E7C8C0", VA = "0x187E7D6C0")]
	private bool AKHKOMCEOFI(Entity LBPCFJCJDPM, [Out] HEJBBJOONEM JOONKKIKCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E7E4C0", Offset = "0x7E7D6C0", VA = "0x187E7E4C0")]
	private bool IMCDAODGDPI(Entity LBPCFJCJDPM, [Out] HEJBBJOONEM JOONKKIKCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public PFDLFNPFPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[CJHEJLEOLIP]
public sealed class CAFMIHKAAPP : LBEEIHDLCKF
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery NIIOJEGKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery JELGPAAFJAC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E67470", Offset = "0x7E66670", VA = "0x187E67470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E675C0", Offset = "0x7E667C0", VA = "0x187E675C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E66E80", Offset = "0x7E66080", VA = "0x187E66E80")]
	private void GJLEEHNNDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E67180", Offset = "0x7E66380", VA = "0x187E67180")]
	private void OCPKDNKBODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public CAFMIHKAAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JALKGFMPNIN : LBEEIHDLCKF, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct JEDMPMKBOPI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob CKILJOEHIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob NPLLHAAFLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob CGPBHCCMLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob EJHICMJJIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle DCINPOPFDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<OOKIINHIDDK> FALPGKLFFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> EEMMMHOIPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> KFHIGJPEGLE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E72690", Offset = "0x7E71890", VA = "0x187E72690", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E72710", Offset = "0x7E71910", VA = "0x187E72710")]
		private void JBLPHKKBBDE(EntityQueryInJob OJJIKCPLFJH, NativeList<Entity> AMALDBDDOKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct AAHCABHBBED : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle DCINPOPFDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<OOKIINHIDDK> FALPGKLFFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> AMALDBDDOKE;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E654E0", Offset = "0x7E646E0", VA = "0x187E654E0", Slot = "4")]
		public void Execute(ArchetypeChunk HAMKJLAGLED, int MOJCBFMENIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct NPJFGNEMPED : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle DCINPOPFDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> HLNKELJHFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<HGMLJFHFDJI> BFAMBNPHIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<PBLFHEHCKOH> AAAALDAEEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<OOKIINHIDDK> OLONOHPNDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> GJFKDAFFMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<HGMLJFHFDJI> IEKKGDOADNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<HEJBBJOONEM> KFCMADEOIIE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E77D80", Offset = "0x7E76F80", VA = "0x187E77D80", Slot = "4")]
		public void Execute(ArchetypeChunk HAMKJLAGLED, int MOJCBFMENIP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery CKILJOEHIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery NPLLHAAFLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery CGPBHCCMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery EJHICMJJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery FAMGKDHIHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery LPBBMBAHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery OPLKBCNNNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private BHFLIOCIKLJ GJKBMOEFFIA;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E717A0", Offset = "0x7E709A0", VA = "0x187E717A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E71140", Offset = "0x7E70340", VA = "0x187E71140", Slot = "15")]
	public override void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E71D20", Offset = "0x7E70F20", VA = "0x187E71D20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E711A0", Offset = "0x7E703A0", VA = "0x187E711A0")]
	private void MKPOAFBBPHD(NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE, int CMFDFEGFBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E70CF0", Offset = "0x7E6FEF0", VA = "0x187E70CF0")]
	private void ENINAHKJINM(NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE, int GFFFOIMBGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E72250", Offset = "0x7E71450", VA = "0x187E72250")]
	private void PNFFFLDKLAN(NativeParallelHashSet<HEJBBJOONEM> GPEFIOBNAJE, int KAHNDKPMBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E70960", Offset = "0x7E6FB60", VA = "0x187E70960")]
	private void DABCOFJOEBI(NativeParallelHashSet<HEJBBJOONEM> NOKGBKPBFJD, int BKNHNJLBIIE, int GEMOFIDGJJM, int PFENEAMOIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E720A0", Offset = "0x7E712A0", VA = "0x187E720A0")]
	private void PCKOMCLAGEE(Entity NLJFNAJIHHC, FJJNPNKHKFF LGFKJKDDACF, HEJBBJOONEM JOONKKIKCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public JALKGFMPNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class INAMFIOJJLM : LBEEIHDLCKF
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery GJFJHJKDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery KDGNIGMEJOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E701B0", Offset = "0x7E6F3B0", VA = "0x187E701B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E703E0", Offset = "0x7E6F5E0", VA = "0x187E703E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public INAMFIOJJLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BGCLDPAMGAD : LBEEIHDLCKF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct IOCBNFJBJFN : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery OPGLNGFIMBN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E65FE0", Offset = "0x7E651E0", VA = "0x187E65FE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E66120", Offset = "0x7E65320", VA = "0x187E66120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public BGCLDPAMGAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CJHEJLEOLIP]
internal class MOABKIJLOPM : LBEEIHDLCKF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class LNPAGDMLMDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery IOIIIMEKJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery AEOKAJCMDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public OLIKKDNHJDJ DIDGALJDALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType DHAIHHPJNEI;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LNPAGDMLMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void OLIKKDNHJDJ(NativeArray<FJJNPNKHKFF> NLNGJFNOHGL, DNOHAGJNPAP GHBBKLJANGP);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<LNPAGDMLMDA> FGOPHCAJIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PBNJILOJLGI OFCGDFCHMGF;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E768F0", Offset = "0x7E75AF0", VA = "0x187E768F0", Slot = "15")]
	public override void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E76AF0", Offset = "0x7E75CF0", VA = "0x187E76AF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E76C80", Offset = "0x7E75E80", VA = "0x187E76C80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x38FE720", Offset = "0x38FD920", VA = "0x1838FE720")]
	private void BNDBCGNDPJO<T>(OLIKKDNHJDJ DIDGALJDALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E76950", Offset = "0x7E75B50", VA = "0x187E76950")]
	private static void OOIIFMNOMAA(NativeArray<FJJNPNKHKFF> DCLFGGJMPBJ, DNOHAGJNPAP KPGJGFDCPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E76750", Offset = "0x7E75950", VA = "0x187E76750")]
	private static void IDIEEDOGOKJ(NativeArray<FJJNPNKHKFF> DCLFGGJMPBJ, DNOHAGJNPAP KPGJGFDCPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E765B0", Offset = "0x7E757B0", VA = "0x187E765B0")]
	private static void GJIFLNAFFJO(NativeArray<FJJNPNKHKFF> DCLFGGJMPBJ, DNOHAGJNPAP KPGJGFDCPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public MOABKIJLOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CJHEJLEOLIP]
public sealed class NNOCNCLEAIP : LBEEIHDLCKF
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery OJJIKCPLFJH;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E77950", Offset = "0x7E76B50", VA = "0x187E77950", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LGPCHAADOOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS NHNDKCOGMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData PBFMGDGIKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public EFDNHOFOELB LNIKCCNMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 LKIJBCNEOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool OKIIGAMJHKC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CGLJOOGEIJO(Lifetime.LoadInstance)]
public struct IBPNMMKDMMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity IIPJDMFDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> HINDHCKKJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> HHNDLGPDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<LGPCHAADOOP> NNJJEJBPHDH;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F670", Offset = "0x7E6E870", VA = "0x187E6F670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(MCKFJCIENAJ), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class MCKFJCIENAJ : IELLFNEFJEB, AOOLNAMPIBN, BJIBPMDIMDH, GKBPCKLNOCI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct GKCDDAKJAKO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MCKFJCIENAJ NJHDJGHEICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool HFHPEMGPLIC;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x17BD360", Offset = "0x17BC560", VA = "0x1817BD360")]
		public GKCDDAKJAKO(MCKFJCIENAJ NJHDJGHEICO, bool HFHPEMGPLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A5A0", Offset = "0x7E697A0", VA = "0x187E6A5A0")]
		public Queue<MLNPKOBGHGN>.Enumerator MAJHBAEJHEK()
		{
			return default(Queue<MLNPKOBGHGN>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A260", Offset = "0x7E69460", VA = "0x187E6A260", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private IPHDOCEGNCL KHJPABPEFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private GAEEGNJKMLI GOGNMLIABIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<NOFEPGIGNGP>> IBAJJNFGIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> IIGFIFBFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<FJJNPNKHKFF> DDKIGONDICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HAJBDHEGAHG<MLNPKOBGHGN> AMGAAKJJFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private HAJBDHEGAHG<IBPNMMKDMMN> FFIMOKGNKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private HAJBDHEGAHG<CHADBKECAEP> CKIJGFJBMBG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E741A0", Offset = "0x7E733A0", VA = "0x187E741A0", Slot = "4")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E73A90", Offset = "0x7E72C90", VA = "0x187E73A90")]
	public void EANADNGPJOB(NativeList<NOFEPGIGNGP> CIIMCAKPAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E74040", Offset = "0x7E73240", VA = "0x187E74040")]
	public void GHECAPJHDGJ(Entity NJHDJGHEICO, [In] GBAADKKOBIK<GameObject> DGPMEFNDFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E74640", Offset = "0x7E73840", VA = "0x187E74640")]
	public void PDKJLOOJEHO(NativeList<FJJNPNKHKFF> DCLFGGJMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E743A0", Offset = "0x7E735A0", VA = "0x187E743A0")]
	public void LJGCNPKKGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E735E0", Offset = "0x7E727E0", VA = "0x187E735E0")]
	public void CJMBFCNJPOA(PFOKOKEKMHK MHGFNMBGACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E73CE0", Offset = "0x7E72EE0", VA = "0x187E73CE0")]
	public JobHandle FCNAIPILOKF([In] MLNPKOBGHGN BDAAPBJEHGD, JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E73C40", Offset = "0x7E72E40", VA = "0x187E73C40")]
	public JobHandle FCNAIPILOKF([In] IBPNMMKDMMN BDAAPBJEHGD, JobHandle FCIEDFFGDDO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7B29D40", Offset = "0x7B28F40", VA = "0x187B29D40")]
	public GKCDDAKJAKO DEPLOFIHIEH(bool HFHPEMGPLIC)
	{
		return default(GKCDDAKJAKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E73FF0", Offset = "0x7E731F0", VA = "0x187E73FF0")]
	public CEJJHFCEFBJ<IBPNMMKDMMN> GGHPEEMNGEK()
	{
		return default(CEJJHFCEFBJ<IBPNMMKDMMN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E73D80", Offset = "0x7E72F80", VA = "0x187E73D80")]
	public CEJJHFCEFBJ<CHADBKECAEP> FGGIMPMDMMJ()
	{
		return default(CEJJHFCEFBJ<CHADBKECAEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E73DD0", Offset = "0x7E72FD0", VA = "0x187E73DD0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E73B60", Offset = "0x7E72D60", VA = "0x187E73B60", Slot = "5")]
	public void EFOAOCGHIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E745D0", Offset = "0x7E737D0", VA = "0x187E745D0", Slot = "6")]
	private void NPKMOIIMNFA(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1170FB0", Offset = "0x11701B0", VA = "0x181170FB0", Slot = "7")]
	private void JNNNBCINACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MCKFJCIENAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FFHEMNCBNCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS NHNDKCOGMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData PBFMGDGIKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public BKHKOHIOKMA MGEECOGALOB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[CGLJOOGEIJO(Lifetime.LoadInstance)]
public struct MLNPKOBGHGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity IIPJDMFDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> EEOGDGCIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> HINDHCKKJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> HHNDLGPDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<GDHEFDIGGIJ> FHJEDMCCKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<NOFEPGIGNGP> CIIMCAKPAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<FFHEMNCBNCL> IMOBEHEPPLI;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E74750", Offset = "0x7E73950", VA = "0x187E74750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E74760", Offset = "0x7E73960", VA = "0x187E74760")]
	public void GNJBDGKPLLM(bool HFHPEMGPLIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(HPDPIENIOAO), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class HPDPIENIOAO : ENCIJMIGADI, BJIBPMDIMDH, GKBPCKLNOCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private MCKFJCIENAJ DBJGONPDGKM;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F600", Offset = "0x7E6E800", VA = "0x187E6F600", Slot = "4")]
	public void MPMPHOFLBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E6F620", Offset = "0x7E6E820", VA = "0x187E6F620", Slot = "5")]
	private void NPKMOIIMNFA(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x11530D0", Offset = "0x11522D0", VA = "0x1811530D0", Slot = "6")]
	private void JNNNBCINACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HPDPIENIOAO()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : LBEEIHDLCKF, IELLFNEFJEB
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
			public NativeParallelHashMap<int, EFDNHOFOELB> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<LGPCHAADOOP> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AA60", Offset = "0x7E69C60", VA = "0x187E6AA60", Slot = "4")]
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
			public NativeArray<NOFEPGIGNGP> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<GDHEFDIGGIJ> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<FFHEMNCBNCL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AE00", Offset = "0x7E6A000", VA = "0x187E6AE00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E67CD0", Offset = "0x7E66ED0", VA = "0x187E67CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7E80880", Offset = "0x7E7FA80", VA = "0x187E80880")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7E808A0", Offset = "0x7E7FAA0", VA = "0x187E808A0")]
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
				float3 CDHPIDHMLEF(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7E72EC0", Offset = "0x7E720C0", VA = "0x187E72EC0", Slot = "5")]
				public float3 OJFKFIJHDDI(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7E72E80", Offset = "0x7E72080", VA = "0x187E72E80", Slot = "4")]
				public float3 CDHPIDHMLEF(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7E780B0", Offset = "0x7E772B0", VA = "0x187E780B0", Slot = "4")]
				public float3 CDHPIDHMLEF(quaternion rotation)
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
			public NativeArray<GDHEFDIGGIJ> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<NOFEPGIGNGP> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C080", Offset = "0x7E6B280", VA = "0x187E6C080", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E6D320", Offset = "0x7E6C520", VA = "0x187E6D320")]
			private void MFDKIAPDGJF(NativeList<PointSrcData> srcData, NativeList<NOFEPGIGNGP> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B750", Offset = "0x7E6A950", VA = "0x187E6B750")]
			public static Vector3 BNGOOEINDBK(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C6E0", Offset = "0x7E6B8E0", VA = "0x187E6C6E0")]
			public static quaternion FBDNKGDPFCO(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B520", Offset = "0x7E6A720", VA = "0x187E6B520")]
			private static quaternion AABOOELBAIF(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E6CB80", Offset = "0x7E6BD80", VA = "0x187E6CB80")]
			private static float3 IMCMMEMLNEP(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E6CAF0", Offset = "0x7E6BCF0", VA = "0x187E6CAF0")]
			private static quaternion IKLNCEGCMBB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7E6E200", Offset = "0x7E6D400", VA = "0x187E6E200")]
			private static NOFEPGIGNGP MPPEFBOMEFB(int idx, NativeList<PointSrcData> srcData)
			{
				return default(NOFEPGIGNGP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3FB67B0", Offset = "0x3FB59B0", VA = "0x183FB67B0")]
			private void AGLOBHFCABP<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E6E620", Offset = "0x7E6D820", VA = "0x187E6E620")]
			private void PNEPOBIGHKO(NativeList<PointSrcData> sourcePoints, NativeList<NOFEPGIGNGP> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7E6BB60", Offset = "0x7E6AD60", VA = "0x187E6BB60")]
			public static float CNOBAHDGNPO(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E6BCE0", Offset = "0x7E6AEE0", VA = "0x187E6BCE0")]
			private static quaternion DKBAIDENLGP(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7E6BED0", Offset = "0x7E6B0D0", VA = "0x187E6BED0")]
			private static NOFEPGIGNGP DPBJOJKLKOA(PointSrcData point)
			{
				return default(NOFEPGIGNGP);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E6BFF0", Offset = "0x7E6B1F0", VA = "0x187E6BFF0")]
			private static NOFEPGIGNGP DPBJOJKLKOA(float3 pos, quaternion rot, float radius)
			{
				return default(NOFEPGIGNGP);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E6CD50", Offset = "0x7E6BF50", VA = "0x187E6CD50")]
			private static bool KABHBGDOPBE(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E6D250", Offset = "0x7E6C450", VA = "0x187E6D250")]
			private static float3 LIPELACEPKI(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C940", Offset = "0x7E6BB40", VA = "0x187E6C940")]
			public static float3 GOIBOKJDCDE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7E6E470", Offset = "0x7E6D670", VA = "0x187E6E470")]
			public static float3 OJFKFIJHDDI(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E6CDF0", Offset = "0x7E6BFF0", VA = "0x187E6CDF0")]
			private static quaternion LGCJODMAJBH(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C760", Offset = "0x7E6B960", VA = "0x187E6C760")]
			private static float FBLNOBCFLIG(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7E82DD0", Offset = "0x7E81FD0", VA = "0x187E82DD0")]
			private void FGCAKPAPGGK(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7E82CE0", Offset = "0x7E81EE0", VA = "0x187E82CE0", Slot = "4")]
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
			public NativeList<NOFEPGIGNGP> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7E842B0", Offset = "0x7E834B0", VA = "0x187E842B0")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E842A0", Offset = "0x7E834A0", VA = "0x187E842A0", Slot = "4")]
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
			public NativeList<NOFEPGIGNGP> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7E84250", Offset = "0x7E83450", VA = "0x187E84250")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7E84240", Offset = "0x7E83440", VA = "0x187E84240", Slot = "4")]
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
			public NativeList<LGPCHAADOOP> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B150", Offset = "0x7E6A350", VA = "0x187E6B150")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B140", Offset = "0x7E6A340", VA = "0x187E6B140", Slot = "4")]
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
			public NativeList<GDHEFDIGGIJ> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<FFHEMNCBNCL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B320", Offset = "0x7E6A520", VA = "0x187E6B320")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B310", Offset = "0x7E6A510", VA = "0x187E6B310", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E83E20", Offset = "0x7E83020", VA = "0x187E83E20")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E83E10", Offset = "0x7E83010", VA = "0x187E83E10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly FODGIOKBGBI log;

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
		private NBONEOJHMCC replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IPHDOCEGNCL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private MCKFJCIENAJ bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KFICNDKBFHL ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E82300", Offset = "0x7E81500", VA = "0x187E82300", Slot = "15")]
		public override void InitReferences(PJPDGGELCKG services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E839B0", Offset = "0x7E82BB0", VA = "0x187E839B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E83AA0", Offset = "0x7E82CA0", VA = "0x187E83AA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E83B00", Offset = "0x7E82D00", VA = "0x187E83B00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E83330", Offset = "0x7E82530", VA = "0x187E83330")]
		private JobHandle MKDLGJJHGDD(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E808F0", Offset = "0x7E7FAF0", VA = "0x187E808F0")]
		private JobHandle ACGACCIBCIF(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E823A0", Offset = "0x7E815A0", VA = "0x187E823A0")]
		private JobHandle JFGMPJJAPIB(NativeArray<int> pointCount, NativeList<NOFEPGIGNGP> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E81930", Offset = "0x7E80B30", VA = "0x187E81930")]
		private JobHandle GDJDDLGMGHM(NativeList<NOFEPGIGNGP> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E82700", Offset = "0x7E81900", VA = "0x187E82700")]
		private JobHandle LJIMOCDLBDB(EntityQuery query, NativeList<GDHEFDIGGIJ> splinePointRanges, NativeList<NOFEPGIGNGP> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E821E0", Offset = "0x7E813E0", VA = "0x187E821E0")]
		private JobHandle IOOFAGPFFNB(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E83C70", Offset = "0x7E82E70", VA = "0x187E83C70")]
		private JobHandle PEDMFENMKGD(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E819D0", Offset = "0x7E80BD0", VA = "0x187E819D0")]
		private JobHandle HDEBJHEJNOL(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<LGPCHAADOOP> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E82440", Offset = "0x7E81640", VA = "0x187E82440")]
		private JobHandle JPFCJEJKGHJ(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<GDHEFDIGGIJ> splinePointRanges, [Out] NativeList<FFHEMNCBNCL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E80FB0", Offset = "0x7E801B0", VA = "0x187E80FB0")]
		private JobHandle CALOGAMPHMF(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E81420", Offset = "0x7E80620", VA = "0x187E81420")]
		private JobHandle FCMPNPAKPNG(EntityQuery query, NativeList<LGPCHAADOOP> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E81C70", Offset = "0x7E80E70", VA = "0x187E81C70")]
		private static NativeParallelHashMap<int, EFDNHOFOELB> IEIJEOPPKGB()
		{
			return default(NativeParallelHashMap<int, EFDNHOFOELB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E82F90", Offset = "0x7E82190", VA = "0x187E82F90")]
		private JobHandle MFEPHICGBAC(EntityQuery query, NativeList<GDHEFDIGGIJ> splinePointRanges, NativeList<NOFEPGIGNGP> splinePointData, NativeList<FFHEMNCBNCL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E82EB0", Offset = "0x7E820B0", VA = "0x187E82EB0")]
		private JobHandle MCGBKIEONOB(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E823A0", Offset = "0x7E815A0", VA = "0x187E823A0")]
		private JobHandle MHKGJCMBGJK(NativeArray<int> pointCount, NativeList<NOFEPGIGNGP> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E81930", Offset = "0x7E80B30", VA = "0x187E81930")]
		private JobHandle NCPPLPMOIDB(NativeList<NOFEPGIGNGP> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E81330", Offset = "0x7E80530", VA = "0x187E81330")]
		private JobHandle DOOOOMNILBP(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<LGPCHAADOOP> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E82BD0", Offset = "0x7E81DD0", VA = "0x187E82BD0")]
		private JobHandle LLHBJPHFFMO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<GDHEFDIGGIJ> ranges, NativeList<FFHEMNCBNCL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E82090", Offset = "0x7E81290", VA = "0x187E82090")]
		private JobHandle INIBKIFBHEC(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E83670", Offset = "0x7E82870", VA = "0x187E83670", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class GGJMEIKPLHK : FNPANKDKAKI, IELLFNEFJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private MCKFJCIENAJ DBJGONPDGKM;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A1F0", Offset = "0x7E693F0", VA = "0x187E6A1F0", Slot = "14")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A240", Offset = "0x7E69440", VA = "0x187E6A240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
	public GGJMEIKPLHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class PEGELIIFDNN : LBEEIHDLCKF, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct LGICNJGANAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager EPEFONCBOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private CEAEPCPAKAJ<T> ALEGHEAOMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int NIBICIJAIGM;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50CAAB0", Offset = "0x50C9CB0", VA = "0x1850CAAB0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50CB0F0", Offset = "0x50CA2F0", VA = "0x1850CB0F0")]
		public LGICNJGANAH(EntityManager EPEFONCBOCP, CEAEPCPAKAJ<T> ALEGHEAOMGM, NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x45E6500", Offset = "0x45E5700", VA = "0x1845E6500")]
		public LGICNJGANAH<T> MAJHBAEJHEK()
		{
			return default(LGICNJGANAH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x50CB030", Offset = "0x50CA230", VA = "0x1850CB030")]
		public bool GINLNMBLNPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly FODGIOKBGBI KLAIMJLEEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private GAEEGNJKMLI GOGNMLIABIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MCKFJCIENAJ DBJGONPDGKM;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B610", Offset = "0x7E7A810", VA = "0x187E7B610", Slot = "15")]
	public override void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E7BC20", Offset = "0x7E7AE20", VA = "0x187E7BC20")]
	public void KLIELDMEKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E7C090", Offset = "0x7E7B290", VA = "0x187E7C090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E7A1A0", Offset = "0x7E793A0", VA = "0x187E7A1A0")]
	private void IOHGBJNKEAP(CHADBKECAEP BDAAPBJEHGD, Mesh[] CFEMJPGPPKM, NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3A0C1B0", Offset = "0x3A0B3B0", VA = "0x183A0C1B0")]
	private LGICNJGANAH<T> PGONHAPJECN<T>(CEAEPCPAKAJ<T> ALEGHEAOMGM, NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK) where T : struct
	{
		return default(LGICNJGANAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B280", Offset = "0x7E7A480", VA = "0x187E7B280")]
	private void IOMJNJDMHAD(Transform NJHDJGHEICO, NativeArray<CHDCHCGGCOA> FKJFKOCBJLF, GBAADKKOBIK<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B750", Offset = "0x7E7A950", VA = "0x187E7B750")]
	private void JJDNKPIABBH(Transform NJHDJGHEICO, NativeArray<LOIOBGHMDPC> JGGJOANAOMD, GBAADKKOBIK<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D210", Offset = "0x7E7C410", VA = "0x187E7D210")]
	private void PMELHIIGLGF(Transform NJHDJGHEICO, NativeArray<FDCDAJILHDD> KDBNBDBOMCE, GBAADKKOBIK<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E7BC50", Offset = "0x7E7AE50", VA = "0x187E7BC50")]
	private void NBJNGDKAPMD(Transform NJHDJGHEICO, NativeArray<MGOOLAEAHNJ> CFEMJPGPPKM, Mesh[] AFJGGMADPJD, GBAADKKOBIK<GameObject> ODHBNGDHFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E79710", Offset = "0x7E78910", VA = "0x187E79710")]
	private static void DKBOLDFNHDO(NativeParallelHashSet<Entity> EEOGDGCIFOA, NativeParallelHashSet<Entity> GLKLJAEJFDL, NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E7B690", Offset = "0x7E7A890", VA = "0x187E7B690")]
	private static void JIBFHOMKDDA(NativeList<Entity> MEHAOGGFJIO, NativeArray<EntityRemapUtility.EntityRemapInfo> LHJNKBIOKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7E78AA0", Offset = "0x7E77CA0", VA = "0x187E78AA0")]
	private NativeParallelHashMap<Entity, PBLFHEHCKOH> BCENMOGBDOK(MCKFJCIENAJ.GKCDDAKJAKO OCHNMKFIPHL, CEJJHFCEFBJ<IBPNMMKDMMN> CHKKLMIKEJO, List<GameObject> ODHBNGDHFAO)
	{
		return default(NativeParallelHashMap<Entity, PBLFHEHCKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7E79610", Offset = "0x7E78810", VA = "0x187E79610")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> CKONAPIIDLF(Entity APHMAGJIDCG)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E79C50", Offset = "0x7E78E50", VA = "0x187E79C50")]
	private void HCPNHENFBNO(NativeList<Entity> FEIOHFHGJBO, NativeList<Entity> ELBIHCCJIFK, NativeParallelHashMap<Entity, PBLFHEHCKOH> PGAOOEIKIKO, NativeList<GDHEFDIGGIJ> MNKNBPICEIA, NativeList<NOFEPGIGNGP> FCFPAMOHLIB, NativeList<FFHEMNCBNCL> IBAJJNFGIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E79860", Offset = "0x7E78A60", VA = "0x187E79860")]
	private void FHJAAEHNOJG(NativeList<Entity> EEOGDGCIFOA, NativeList<Entity> HINDHCKKJMJ, NativeParallelHashMap<Entity, PBLFHEHCKOH> PGAOOEIKIKO, NativeList<LGPCHAADOOP> NNJJEJBPHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7E66350", Offset = "0x7E65550", VA = "0x187E66350")]
	public PEGELIIFDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GNIHDGPDKND : IDKPJKGFAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS NHNDKCOGMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly MCDCCMBIKEN NJHDJGHEICO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject PNAIALCANPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS GPNBPJCNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A8E0", Offset = "0x7E69AE0", VA = "0x187E6A8E0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 FEHKMJKAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A750", Offset = "0x7E69950", VA = "0x187E6A750", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 CAFAHGODEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A660", Offset = "0x7E69860", VA = "0x187E6A660", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BKDGPGPNOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A9C0", Offset = "0x7E69BC0", VA = "0x187E6A9C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A7A0", Offset = "0x7E699A0", VA = "0x187E6A7A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion PEBHJMNOACG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A700", Offset = "0x7E69900", VA = "0x187E6A700", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A890", Offset = "0x7E69A90", VA = "0x187E6A890", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 IHIHLMGGHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A840", Offset = "0x7E69A40", VA = "0x187E6A840", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 FCPIOMKMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A6B0", Offset = "0x7E698B0", VA = "0x187E6A6B0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 CNHHOKLPJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A7F0", Offset = "0x7E699F0", VA = "0x187E6A7F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7E6AA10", Offset = "0x7E69C10", VA = "0x187E6AA10")]
	public GNIHDGPDKND(UniformTRS NHNDKCOGMKF, MCDCCMBIKEN NJHDJGHEICO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class BAKBIJANPHN : GNIHDGPDKND, JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float FFHLABDMDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 DJFANKCCFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly EPEJMPHDPHB OAOAKALKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly KBHAGNPMANG HEMCDJAHJFI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private AOECEAGCFFM AFBLAGDFLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E65C40", Offset = "0x7E64E40", VA = "0x187E65C40", Slot = "17")]
		get
		{
			return default(AOECEAGCFFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS LFKAAMNNIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7E65B60", Offset = "0x7E64D60", VA = "0x187E65B60", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float ICIBDDPEHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC07D70", Offset = "0xC06F70", VA = "0x180C07D70", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 HMECJLGJGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7E65C90", Offset = "0x7E64E90", VA = "0x187E65C90", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private EPEJMPHDPHB CJGGPNGKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE755B0", Offset = "0xE747B0", VA = "0x180E755B0", Slot = "21")]
		get
		{
			return default(EPEJMPHDPHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private KBHAGNPMANG PLKPJFAHLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1377120", Offset = "0x1376320", VA = "0x181377120", Slot = "22")]
		get
		{
			return default(KBHAGNPMANG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool GGCMJLEDOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KJLNOHDCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7E65CE0", Offset = "0x7E64EE0", VA = "0x187E65CE0")]
	protected BAKBIJANPHN(UniformTRS NHNDKCOGMKF, MCDCCMBIKEN NJHDJGHEICO, float FFHLABDMDPM, float3 DJFANKCCFCN, EPEJMPHDPHB OAOAKALKJPD, KBHAGNPMANG HEMCDJAHJFI)
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
public abstract class PNJBGJGODIP : IDKPJKGFAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly HAONCNNABLP CFNHEFEFHMG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected MCDCCMBIKEN OGBBAAKFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1154C20", Offset = "0x1153E20", VA = "0x181154C20")]
		get
		{
			return default(MCDCCMBIKEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FD70", Offset = "0x7E7EF70", VA = "0x187E7FD70")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected IPHDOCEGNCL IOMPIJDCPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FD60", Offset = "0x7E7EF60", VA = "0x187E7FD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected NBELHCIHFBE LACODNLCBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E806C0", Offset = "0x7E7F8C0", VA = "0x187E806C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected EDLCJCKFFCD PNOBNGMACAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7E80630", Offset = "0x7E7F830", VA = "0x187E80630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject PNAIALCANPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FBB0", Offset = "0x7E7EDB0", VA = "0x187E7FBB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS GPNBPJCNPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1181A80", Offset = "0x1180C80", VA = "0x181181A80", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 FEHKMJKAEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7E80070", Offset = "0x7E7F270", VA = "0x187E80070", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 CAFAHGODEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FBE0", Offset = "0x7E7EDE0", VA = "0x187E7FBE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BKDGPGPNOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7E80750", Offset = "0x7E7F950", VA = "0x187E80750", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E80160", Offset = "0x7E7F360", VA = "0x187E80160", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion PEBHJMNOACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FF50", Offset = "0x7E7F150", VA = "0x187E7FF50", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7E80520", Offset = "0x7E7F720", VA = "0x187E80520", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 IHIHLMGGHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7E80430", Offset = "0x7E7F630", VA = "0x187E80430", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 FCPIOMKMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E7FD90", Offset = "0x7E7EF90", VA = "0x187E7FD90", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 CNHHOKLPJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7E80270", Offset = "0x7E7F470", VA = "0x187E80270", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xDF31A0", Offset = "0xDF23A0", VA = "0x180DF31A0")]
	protected PNJBGJGODIP(HAONCNNABLP DJMGIDJHMIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E80720", Offset = "0x7E7F920", VA = "0x187E80720")]
	public static AOECEAGCFFM NEKLFDMHCNA(PNJBGJGODIP PNIEJJKFCEK)
	{
		return default(AOECEAGCFFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class COCAPHMIKKF
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7E84DE0", Offset = "0x7E83FE0", VA = "0x187E84DE0")]
	public static void LBIFMAODMAK(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class IOCPGOLJNCA
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7E85610", Offset = "0x7E84810", VA = "0x187E85610")]
	public static void PIPAOLFAKNB(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP, PFOKOKEKMHK PKNEAOFFEBI, IPHDOCEGNCL PKCEHJLPOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7E85300", Offset = "0x7E84500", VA = "0x187E85300")]
	public static void PFLCBHAAHMM(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP, PFOKOKEKMHK PKNEAOFFEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7E85020", Offset = "0x7E84220", VA = "0x187E85020")]
	public static NativeList<Entity> AMLODLLGCFB(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7E852C0", Offset = "0x7E844C0", VA = "0x187E852C0")]
	public static NativeList<Entity> FLIMJFAJFFA(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7E85060", Offset = "0x7E84260", VA = "0x187E85060")]
	private static NativeList<Entity> AMLODLLGCFB(NativeArray<Entity> EEOGDGCIFOA, EntityManager EPEFONCBOCP, bool NJAAAMHDMFM)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class PDHPLOBFGFA : PNJBGJGODIP, JHGPEPAFDAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float FFHLABDMDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 DJFANKCCFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private EPEJMPHDPHB OAOAKALKJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private KBHAGNPMANG HEMCDJAHJFI;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager PAPACJKAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7E86110", Offset = "0x7E85310", VA = "0x187E86110")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected JLPHHADBBLP JFEJDCOPDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7E860B0", Offset = "0x7E852B0", VA = "0x187E860B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData PDFEGGBFAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7E861A0", Offset = "0x7E853A0", VA = "0x187E861A0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private AOECEAGCFFM AFBLAGDFLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7E80720", Offset = "0x7E7F920", VA = "0x187E80720", Slot = "17")]
		get
		{
			return default(AOECEAGCFFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float ICIBDDPEHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B50", Offset = "0xEE7D50", VA = "0x180EE8B50", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 HMECJLGJGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1603BF0", Offset = "0x1602DF0", VA = "0x181603BF0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private EPEJMPHDPHB CJGGPNGKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0", Slot = "21")]
		get
		{
			return default(EPEJMPHDPHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private KBHAGNPMANG PLKPJFAHLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60", Slot = "22")]
		get
		{
			return default(KBHAGNPMANG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS LFKAAMNNIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7E85EF0", Offset = "0x7E850F0", VA = "0x187E85EF0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KJLNOHDCHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool GGCMJLEDOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7E86290", Offset = "0x7E85490", VA = "0x187E86290")]
	protected PDHPLOBFGFA(HAONCNNABLP DJMGIDJHMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7E85F20", Offset = "0x7E85120", VA = "0x187E85F20", Slot = "26")]
	public virtual void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class LBEEIHDLCKF : FNPANKDKAKI, IELLFNEFJEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected IPHDOCEGNCL PKCEHJLPOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private MDGGINJLEMI GBEOAHCNHMI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected PFOKOKEKMHK GLHLMKCHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7E85BA0", Offset = "0x7E84DA0", VA = "0x187E85BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected DNOHAGJNPAP INEBOCMAPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7E85AE0", Offset = "0x7E84CE0", VA = "0x187E85AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool MOGJJMDOIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A20", Offset = "0x7E84C20", VA = "0x187E85A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7E85B30", Offset = "0x7E84D30", VA = "0x187E85B30", Slot = "15")]
	public virtual void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
	protected LBEEIHDLCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LHGIDNNHHID
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7E85BF0", Offset = "0x7E84DF0", VA = "0x187E85BF0")]
	public static void LJMBJPGMHEE(NativeArray<Entity> FEIOHFHGJBO, EntityManager EPEFONCBOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__594158360
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7E86490", Offset = "0x7E85690", VA = "0x187E86490")]
	public static void NJBGNBNNMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7E86480", Offset = "0x7E85680", VA = "0x187E86480")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class MAKFKKCFPEP : ContainerPropertyBag<FDFCOBOFJIA>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7E85E30", Offset = "0x7E85030", VA = "0x187E85E30")]
	public MAKFKKCFPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class MKNFGEAJCEP : ContainerPropertyBag<KIBGAKCNFHC>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7E85E90", Offset = "0x7E85090", VA = "0x187E85E90")]
	public MKNFGEAJCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class AGJNGDMGAOD : ContainerPropertyBag<FINIBKJMGGO>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7E84D80", Offset = "0x7E83F80", VA = "0x187E84D80")]
	public AGJNGDMGAOD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7E862C0", Offset = "0x7E854C0", VA = "0x187E862C0")]
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
