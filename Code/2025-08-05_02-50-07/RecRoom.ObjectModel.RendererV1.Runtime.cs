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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84BD3A0", Offset = "0x84BC7A0", VA = "0x1884BD3A0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x846E210", Offset = "0x846D610", VA = "0x18846E210", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84C58C0", Offset = "0x84C4CC0", VA = "0x1884C58C0")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84C5E50", Offset = "0x84C5250", VA = "0x1884C5E50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84C5EB0", Offset = "0x84C52B0", VA = "0x1884C5EB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GCLENKJIGHP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84B34C0", Offset = "0x84B28C0", VA = "0x1884B34C0")]
	public static Quaternion IALFNCGKHFA([In] this HPMIBJEAGOE APINDHBJOAM, [In] Vector3 NLDMHMFAEEN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OMMEJBAEJOH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84BFAB0", Offset = "0x84BEEB0", VA = "0x1884BFAB0")]
	public static bool DCGJBPJPPBC(this MCGPACNOOPH JIJBIEHNKAL, HNPEOKBOCPL HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84C0E10", Offset = "0x84C0210", VA = "0x1884C0E10")]
	public static bool JFIEOFFOHNN(this MCGPACNOOPH JIJBIEHNKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x84C1580", Offset = "0x84C0980", VA = "0x1884C1580")]
	public static bool MEOKJCJKPIC(this MCGPACNOOPH JIJBIEHNKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84C0E70", Offset = "0x84C0270", VA = "0x1884C0E70")]
	public static void KCPMKFLNAAF(this MCGPACNOOPH JIJBIEHNKAL, Vector3 BPAABHCDOCM, Quaternion PEENLLJLMIP, float FLMDAOGEKMO, bool FKDJNOALHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84C04A0", Offset = "0x84BF8A0", VA = "0x1884C04A0")]
	public static void GCBCIGMDCHH(this MCGPACNOOPH JIJBIEHNKAL, Vector3 BPAABHCDOCM, Quaternion PEENLLJLMIP, float FLMDAOGEKMO, int JJIGAHGBBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84C11C0", Offset = "0x84C05C0", VA = "0x1884C11C0")]
	public static void LJEJEMOMBIO(this MCGPACNOOPH JIJBIEHNKAL, int JJIGAHGBBLB, Vector3 BPAABHCDOCM, Quaternion PEENLLJLMIP, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84C0450", Offset = "0x84BF850", VA = "0x1884C0450")]
	public static void GAOGJKNJKNG(this MCGPACNOOPH JIJBIEHNKAL, Vector3 DIBKCDBNMKE, Quaternion DLFDKBLBCHK, float FLMDAOGEKMO, bool FKDJNOALHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84BFAF0", Offset = "0x84BEEF0", VA = "0x1884BFAF0")]
	private static void EEBBFAHHKNI(this MCGPACNOOPH JIJBIEHNKAL, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO, bool FKDJNOALHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84C15B0", Offset = "0x84C09B0", VA = "0x1884C15B0")]
	private static void NNEJGHABHOP(this MCGPACNOOPH JIJBIEHNKAL, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, float GPNMIAPMOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84C0C20", Offset = "0x84C0020", VA = "0x1884C0C20")]
	private static void IOLFDAFAKHN(this MCGPACNOOPH JIJBIEHNKAL, int NOEININIMIL, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, float GPNMIAPMOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84C0E40", Offset = "0x84C0240", VA = "0x1884C0E40")]
	private static bool KAMKKHLLJEL(this MCGPACNOOPH JIJBIEHNKAL, int NOEININIMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84C12E0", Offset = "0x84C06E0", VA = "0x1884C12E0")]
	private static void MCGDHDOGJOO(this MCGPACNOOPH JIJBIEHNKAL, int NOEININIMIL, Vector3 IPGNGMJBFOL, Quaternion JJPOMEGMBHP, float GPNMIAPMOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84C0730", Offset = "0x84BFB30", VA = "0x1884C0730")]
	public static Vector3 ILJADCNDIGI(this MCGPACNOOPH JIJBIEHNKAL, int NOEININIMIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84C1770", Offset = "0x84C0B70", VA = "0x1884C1770")]
	public static Quaternion PJAGBCADLFH(this MCGPACNOOPH JIJBIEHNKAL, int NOEININIMIL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84C0FA0", Offset = "0x84C03A0", VA = "0x1884C0FA0")]
	public static Vector3 KDIJENBHNFI(HNPEOKBOCPL DPALHGCDOLB, Vector3 LBCFHLNAPLC, Vector3? JMMBFMDPADJ, Vector3 HAECFLIPIHK)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface EKAGFJNKNJG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPHAOHMCHLF(EntityQuery MEHCBCCALPK, EntityManager JGFECLAMEOK, HHCMFEOCFNN ANBICBPBIDK, MOHAGAINBII AOGNBJDIOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface LNBIJHBPKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DPMPHPCKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLHGIBKNCOJ(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMDBONIFOEP(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMKOFJNGCOH(IEKGCOIIEHP JIGKMBOLPNH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class IIHLFILGCMD : EKAGFJNKNJG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84B93D0", Offset = "0x84B87D0", VA = "0x1884B93D0", Slot = "4")]
	public void IPHAOHMCHLF(EntityQuery MEHCBCCALPK, EntityManager JGFECLAMEOK, HHCMFEOCFNN ANBICBPBIDK, MOHAGAINBII AOGNBJDIOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IIHLFILGCMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class NBMPHKKMLLI : EKAGFJNKNJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HGDKDFHGHAK DNGECPKMELJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
	public NBMPHKKMLLI(HGDKDFHGHAK DNGECPKMELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84BDCA0", Offset = "0x84BD0A0", VA = "0x1884BDCA0", Slot = "4")]
	public void IPHAOHMCHLF(EntityQuery MEHCBCCALPK, EntityManager JGFECLAMEOK, HHCMFEOCFNN ANBICBPBIDK, MOHAGAINBII AOGNBJDIOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class APJNDCOIDEK : EKAGFJNKNJG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84A8850", Offset = "0x84A7C50", VA = "0x1884A8850", Slot = "4")]
	public void IPHAOHMCHLF(EntityQuery MEHCBCCALPK, EntityManager JGFECLAMEOK, HHCMFEOCFNN ANBICBPBIDK, MOHAGAINBII AOGNBJDIOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public APJNDCOIDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MFMIGMEHCJI : LNBIJHBPKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DPMPHPCKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84BD9A0", Offset = "0x84BCDA0", VA = "0x1884BD9A0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84BD9D0", Offset = "0x84BCDD0", VA = "0x1884BD9D0", Slot = "5")]
	public void NLHGIBKNCOJ(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84BD720", Offset = "0x84BCB20", VA = "0x1884BD720", Slot = "6")]
	public void KMDBONIFOEP(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84BDC50", Offset = "0x84BD050", VA = "0x1884BDC50", Slot = "7")]
	public void OMKOFJNGCOH(IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MFMIGMEHCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KKGJJNJNCLJ : LNBIJHBPKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DPMPHPCKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84BB920", Offset = "0x84BAD20", VA = "0x1884BB920", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84BB950", Offset = "0x84BAD50", VA = "0x1884BB950", Slot = "5")]
	public void NLHGIBKNCOJ(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84BB6A0", Offset = "0x84BAAA0", VA = "0x1884BB6A0", Slot = "6")]
	public void KMDBONIFOEP(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84BBBD0", Offset = "0x84BAFD0", VA = "0x1884BBBD0", Slot = "7")]
	public void OMKOFJNGCOH(IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KKGJJNJNCLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EMCFOOLKBJF : LNBIJHBPKBH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DPMPHPCKLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84AE3F0", Offset = "0x84AD7F0", VA = "0x1884AE3F0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84AE420", Offset = "0x84AD820", VA = "0x1884AE420", Slot = "5")]
	public void NLHGIBKNCOJ(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84AE170", Offset = "0x84AD570", VA = "0x1884AE170", Slot = "6")]
	public void KMDBONIFOEP(EntityQuery MEHCBCCALPK, IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84AE6A0", Offset = "0x84ADAA0", VA = "0x1884AE6A0", Slot = "7")]
	public void OMKOFJNGCOH(IEKGCOIIEHP JIGKMBOLPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EMCFOOLKBJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class CFGFOOPNBKC : IHEMLNHABNH, FMPNPCDDCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HHCMFEOCFNN ANBICBPBIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DHEEPFGFJHD DOAAGCFNLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MOHAGAINBII AOGNBJDIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, EKAGFJNKNJG adapter)> MJBHHPDEGOC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84AB340", Offset = "0x84AA740", VA = "0x1884AB340", Slot = "15")]
	public virtual void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84AB530", Offset = "0x84AA930", VA = "0x1884AB530", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84AB3D0", Offset = "0x84AA7D0", VA = "0x1884AB3D0")]
	private void NHKLCIADLNK(EntityQueryDesc AGBLJCDPLPB, EKAGFJNKNJG AAIIPNLNFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84AB760", Offset = "0x84AAB60", VA = "0x1884AB760", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
	public CFGFOOPNBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class KKECDOJFIGO : IHEMLNHABNH, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class FGDFLNBIDDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery CEGHOEAHMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery MEGMEPCPEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery MFELKDIDALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery DKNAJOJKAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery FCPFIBJENEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery LIMNLJMBOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery HPDIGFCPMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LNBIJHBPKBH OACCHOJEEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType MLCGKNBCEKF;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FGDFLNBIDDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HHCMFEOCFNN ANBICBPBIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MOHAGAINBII AOGNBJDIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DHEEPFGFJHD DOAAGCFNLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<FGDFLNBIDDP> MJBHHPDEGOC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84BAA80", Offset = "0x84B9E80", VA = "0x1884BAA80", Slot = "14")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84BB280", Offset = "0x84BA680", VA = "0x1884BB280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84BB400", Offset = "0x84BA800", VA = "0x1884BB400", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84BA630", Offset = "0x84B9A30", VA = "0x1884BA630")]
	private void CDLCCLBGNFH(FGDFLNBIDDP HMACDGCBIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84BAB10", Offset = "0x84B9F10", VA = "0x1884BAB10")]
	private void NHKLCIADLNK(LNBIJHBPKBH OACCHOJEEOM, ComponentType DPFCKJGPGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
	public KKECDOJFIGO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct CILNKBBFFJD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct NEPALGBFANP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct FBMBLJJBDHP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(MOHAGAINBII), new string[] { })]
public class INMCPMEPPKE : MOHAGAINBII
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MPJPIJDIFLM DFIBAKGGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MPJPIJDIFLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public INMCPMEPPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(MFGDNLAANGB), new string[] { })]
public class AJOIHKJANOE : MFGDNLAANGB, JLKFIOACBKP, GIBCNELDPEH, OBNIMLJGHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private DJEGDOLDLFH BADONBAKCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private HHCMFEOCFNN ANBICBPBIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private MHFAEJPNHJP GFKIDJOBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity LGGKBFMEMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NGNHPGHDKAF KAOJCEADEMB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84A8420", Offset = "0x84A7820", VA = "0x1884A8420", Slot = "4")]
	public bool FMEDOFNMFBC(NAIIODHHNBF HNIIKCBNMGN, GHFLJPPKMHJ CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84A8500", Offset = "0x84A7900", VA = "0x1884A8500", Slot = "5")]
	public NGNHPGHDKAF LHPNLNJLKBO()
	{
		return default(NGNHPGHDKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x84A8310", Offset = "0x84A7710", VA = "0x1884A8310", Slot = "6")]
	public void FIHIOOONHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84A87C0", Offset = "0x84A7BC0", VA = "0x1884A87C0", Slot = "7")]
	private void LOIPDCNMFAN(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x12F3CB0", Offset = "0x12F30B0", VA = "0x1812F3CB0", Slot = "8")]
	private void IBPLCLLIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AJOIHKJANOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(FCBFAGKFLPB), new string[] { })]
public class BEODCNDLIIO : FCBFAGKFLPB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84A8E90", Offset = "0x84A8290", VA = "0x1884A8E90", Slot = "4")]
	public void FGNJFODHPHN(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84A9800", Offset = "0x84A8C00", VA = "0x1884A9800", Slot = "5")]
	public void OFPBDLLJCIE(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x84A97B0", Offset = "0x84A8BB0", VA = "0x1884A97B0", Slot = "6")]
	public ComponentSystemBase NALKADBENGJ(World BADONBAKCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84A9850", Offset = "0x84A8C50", VA = "0x1884A9850", Slot = "7")]
	public void PNMFOFLELOF(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x84A8E30", Offset = "0x84A8230", VA = "0x1884A8E30", Slot = "8")]
	public void DPHKOMLMPAM(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84A8DD0", Offset = "0x84A81D0", VA = "0x1884A8DD0", Slot = "9")]
	public void CEFJCOMOJHJ(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F10", Offset = "0x84A8310", VA = "0x1884A8F10", Slot = "10")]
	public void GJMIALCKMGP(World BADONBAKCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F80", Offset = "0x84A8380", VA = "0x1884A8F80", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> MMBMHDIIMLE()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BEODCNDLIIO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct DOIOJPGMDPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct BODFAPNEJAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ILJADMNBDON : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DDKMMPAGGHJ BHFFDMBEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84B9650", Offset = "0x84B8A50", VA = "0x1884B9650", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84B95E0", Offset = "0x84B89E0", VA = "0x1884B95E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ILJADMNBDON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct AOBEIIAKKHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NGNHPGHDKAF HJJHKKCCGBE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static AOBEIIAKKHK GKKMDDPCKIG(NGNHPGHDKAF FELIADFOOJH)
	{
		return default(AOBEIIAKKHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GMJIDAACPBO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MIHILIACLNI DOELDHDEIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84B35A0", Offset = "0x84B29A0", VA = "0x1884B35A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GMJIDAACPBO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct GJANLGEIDCN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct JFBGGNHNBJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PGGHBPJAHOA NODDNELMGAO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static JFBGGNHNBJL GKKMDDPCKIG(PGGHBPJAHOA FELIADFOOJH)
	{
		return default(JFBGGNHNBJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct PDBCBJNEFGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NGNHPGHDKAF HJJHKKCCGBE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static PDBCBJNEFGK GKKMDDPCKIG(NGNHPGHDKAF FELIADFOOJH)
	{
		return default(PDBCBJNEFGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HIOMOMBDANA : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GGBCEOMBCDB BMJBNEHFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84B9180", Offset = "0x84B8580", VA = "0x1884B9180", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84B9110", Offset = "0x84B8510", VA = "0x1884B9110", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HIOMOMBDANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OHAMJAONMNI : IDMMAJDPOIN, DDKMMPAGGHJ, KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public INMHHAMFOKG OAEMCKKJKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE6F700", Offset = "0xE6EB00", VA = "0x180E6F700", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(INMHHAMFOKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JMCJHIKCPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD24CE0", Offset = "0xD240E0", VA = "0x180D24CE0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 AKGJJMKBJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12460E0", Offset = "0x12454E0", VA = "0x1812460E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84BFA10", Offset = "0x84BEE10", VA = "0x1884BFA10")]
	public OHAMJAONMNI(UniformTRS FFICBLJOMDD, OAMEECEEOCH JIECBJMGMAC, float ADLMLIEOCMK, float3 CKKCOAPGODB, HOPHEEHHBNP FFJNHKKJBIM, BMPAPPBHELN BCHBEKOGKAP, INMHHAMFOKG LKBHLCAIMIP, float3 PLGCJPDFBPB, bool LPIOKFLOGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84BF9C0", Offset = "0x84BEDC0", VA = "0x1884BF9C0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OPLCMDNHEBL : IDMMAJDPOIN, GGBCEOMBCDB, KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<ABIKCOMHDNG> PJOEDHHNPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ODFEMOHOCPF FGEMBJJOPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float DFFOCIFLKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int NGFMBEFFJCO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AFJMPBCMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84C19F0", Offset = "0x84C0DF0", VA = "0x1884C19F0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GFMCGDGBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A10", Offset = "0x84C0E10", VA = "0x1884C1A10", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HNCCECMKHON
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A00", Offset = "0x84C0E00", VA = "0x1884C1A00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IDMNAMECOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAD29F0", Offset = "0xAD1DF0", VA = "0x180AD29F0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JLFFJAAFCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xDD8DA0", Offset = "0xDD81A0", VA = "0x180DD8DA0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JOLDDADFICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1072D30", Offset = "0x1072130", VA = "0x181072D30", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84C1940", Offset = "0x84C0D40", VA = "0x1884C1940")]
	public OPLCMDNHEBL(UniformTRS FFICBLJOMDD, OAMEECEEOCH JIECBJMGMAC, float ADLMLIEOCMK, float3 CKKCOAPGODB, HOPHEEHHBNP FFJNHKKJBIM, BMPAPPBHELN BCHBEKOGKAP, ODFEMOHOCPF FGEMBJJOPFK, float DFFOCIFLKBM, int NGFMBEFFJCO, NativeArray<ABIKCOMHDNG> PJOEDHHNPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x125D0D0", Offset = "0x125C4D0", VA = "0x18125D0D0", Slot = "33")]
	public NativeArray<ABIKCOMHDNG> GetNativeCurvePoints()
	{
		return default(NativeArray<ABIKCOMHDNG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84C1880", Offset = "0x84C0C80", VA = "0x1884C1880", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NCGOMJAAGLK : HAOJEKGKEGC, DDKMMPAGGHJ, KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<BFBNMLCCBFM, INMHHAMFOKG> CFJEEPKGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private INMHHAMFOKG LKBHLCAIMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool LPIOKFLOGMK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private INMHHAMFOKG BFKPGHBOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50", Slot = "28")]
		get
		{
			return default(INMHHAMFOKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool OGEFDKFHIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xF79120", Offset = "0xF78520", VA = "0x180F79120", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 AKGJJMKBJPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84BE4A0", Offset = "0x84BD8A0", VA = "0x1884BE4A0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84BE480", Offset = "0x84BD880", VA = "0x1884BE480")]
	public NCGOMJAAGLK(NAIIODHHNBF ANKACPFCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84BDDF0", Offset = "0x84BD1F0", VA = "0x1884BDDF0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x84BDE40", Offset = "0x84BD240", VA = "0x1884BDE40", Slot = "26")]
	public override void OGELNPLKAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JHEDECNMEDC : GOEGKKAMCEJ, MIHILIACLNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject NEDCPIIPGAH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject KBGJEENOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84B9B20", Offset = "0x84B8F20", VA = "0x1884B9B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GIJLHKFOFFB MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84B9710", Offset = "0x84B8B10", VA = "0x1884B9710", Slot = "15")]
		get
		{
			return default(GIJLHKFOFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GLAENEDOOAG NJEDNIOLCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84B9D00", Offset = "0x84B9100", VA = "0x1884B9D00", Slot = "16")]
		get
		{
			return default(GLAENEDOOAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84B9BB0", Offset = "0x84B8FB0", VA = "0x1884B9BB0")]
	public JHEDECNMEDC(NAIIODHHNBF HNIIKCBNMGN, bool APLMOMMANFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84B9840", Offset = "0x84B8C40", VA = "0x1884B9840")]
	public void FMOHKHGIHFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84B9710", Offset = "0x84B8B10", VA = "0x1884B9710")]
	protected GIJLHKFOFFB AFKPIFCJIJH()
	{
		return default(GIJLHKFOFFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x84B99D0", Offset = "0x84B8DD0", VA = "0x1884B99D0")]
	private static bool IOGIKAIKAEK(NAIIODHHNBF JKGEIBCCKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84B9810", Offset = "0x84B8C10", VA = "0x1884B9810", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ODJJLOJLCOD : HAOJEKGKEGC, GGBCEOMBCDB, KAFHCNKFIJM, IDisposable, BNGPGNBMHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<ABIKCOMHDNG> PJOEDHHNPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool KGHJOMACNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool AEMKHKNFONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float DFFOCIFLKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int NGFMBEFFJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool LHPCAEKNDDD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JAPKHFKIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD315F0", Offset = "0xD309F0", VA = "0x180D315F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PCNDJAPDKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xABB510", Offset = "0xABA910", VA = "0x180ABB510", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float BNMHBEMKPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEEE240", Offset = "0xEED640", VA = "0x180EEE240", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int KKKJBKCLDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE6F700", Offset = "0xE6EB00", VA = "0x180E6F700", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool HMMJAGNDOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD24CE0", Offset = "0xD240E0", VA = "0x180D24CE0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int IOLLMMMCFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84BF480", Offset = "0x84BE880", VA = "0x1884BF480", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int HOKJPEPBKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84BF390", Offset = "0x84BE790", VA = "0x1884BF390", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84BF990", Offset = "0x84BED90", VA = "0x1884BF990")]
	public ODJJLOJLCOD(NAIIODHHNBF ANKACPFCKKH, [Optional] NativeList<ABIKCOMHDNG> PJOEDHHNPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84BF8B0", Offset = "0x84BECB0", VA = "0x1884BF8B0", Slot = "26")]
	public override void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84BF240", Offset = "0x84BE640", VA = "0x1884BF240", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x84BF330", Offset = "0x84BE730", VA = "0x1884BF330", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84BF1E0", Offset = "0x84BE5E0", VA = "0x1884BF1E0")]
	public void BIFGIJMGBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84BF4A0", Offset = "0x84BE8A0", VA = "0x1884BF4A0", Slot = "34")]
	public NativeArray<ABIKCOMHDNG> GetNativeCurvePoints()
	{
		return default(NativeArray<ABIKCOMHDNG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x84BF090", Offset = "0x84BE490", VA = "0x1884BF090", Slot = "35")]
	private Vector3 BGDMIPLBOEO(int PFKMHLGKANI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x84BF670", Offset = "0x84BEA70", VA = "0x1884BF670", Slot = "36")]
	private Quaternion JJJNDFIJEPO(int PFKMHLGKANI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x84BF710", Offset = "0x84BEB10", VA = "0x1884BF710", Slot = "37")]
	private float NMCIELOLNMO(int PFKMHLGKANI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x84BF6A0", Offset = "0x84BEAA0", VA = "0x1884BF6A0")]
	private NativeArray<Entity> LEONBILLLKO()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class BBEPCCMCFBF : OEBKDPFPPOB
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x84A8990", Offset = "0x84A7D90", VA = "0x1884A8990", Slot = "15")]
	protected override ComponentSystemBase CCEFHIDJKKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x84A8DB0", Offset = "0x84A81B0", VA = "0x1884A8DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x84A8DC0", Offset = "0x84A81C0", VA = "0x1884A8DC0")]
	public BBEPCCMCFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DNNEBKKPJAB]
public sealed class EJEGFJPKBMB : BFLFALKDAHO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery PIECAHBGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery NMDJNHEOFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery BHFLHOMCCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery HFFJCDFIDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery LFPDDDCBLDE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x84ACC00", Offset = "0x84AC000", VA = "0x1884ACC00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84ACF60", Offset = "0x84AC360", VA = "0x1884ACF60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x84AC610", Offset = "0x84ABA10", VA = "0x1884AC610")]
	private void COMFAOCBOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x84AC850", Offset = "0x84ABC50", VA = "0x1884AC850")]
	private void FAODMOLHLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84AC440", Offset = "0x84AB840", VA = "0x1884AC440")]
	private void AKEMIPBHJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84AC960", Offset = "0x84ABD60", VA = "0x1884AC960")]
	private void KAHANDOMDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84ACA60", Offset = "0x84ABE60", VA = "0x1884ACA60")]
	private void LOOPOKBGEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x84ACBB0", Offset = "0x84ABFB0", VA = "0x1884ACBB0")]
	private NativeList<Entity> MKOPMDJNPOO(NativeArray<Entity> FGABDCIOGLK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x84ACB60", Offset = "0x84ABF60", VA = "0x1884ACB60")]
	private NativeList<Entity> MICOFKOJGDI(NativeArray<Entity> FGABDCIOGLK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84AC7F0", Offset = "0x84ABBF0", VA = "0x1884AC7F0")]
	private void EMDLPLOPNJF(NativeArray<Entity> FGABDCIOGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public EJEGFJPKBMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DNNEBKKPJAB]
public sealed class CCCNCDHCGLC : BFLFALKDAHO, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery NFNMKBAINBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery LKGGCGEOFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery MFELKDIDALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MFGDNLAANGB IPEHKGBCKCA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84AB0C0", Offset = "0x84AA4C0", VA = "0x1884AB0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84AB060", Offset = "0x84AA460", VA = "0x1884AB060", Slot = "15")]
	public override void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x84AB290", Offset = "0x84AA690", VA = "0x1884AB290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x84AACA0", Offset = "0x84AA0A0", VA = "0x1884AACA0")]
	private void GODAJFHEHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84AA610", Offset = "0x84A9A10", VA = "0x1884AA610")]
	private void GNDCHPBKOIF(NativeParallelHashSet<NGNHPGHDKAF> DHDHEOOPDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x84A9A20", Offset = "0x84A8E20", VA = "0x1884A9A20")]
	private void ACBDBPPIGIC(NativeParallelHashSet<NGNHPGHDKAF> DHDHEOOPDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x84AA0B0", Offset = "0x84A94B0", VA = "0x1884AA0B0")]
	private void FLIENNFCPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x84AAFC0", Offset = "0x84AA3C0", VA = "0x1884AAFC0")]
	private bool IEOEGPDAEFO(Entity MEOOAHKPJCE, [Out] NGNHPGHDKAF HJJHKKCCGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x84AA460", Offset = "0x84A9860", VA = "0x1884AA460")]
	private bool GCOKABJCHEE(Entity MEOOAHKPJCE, [Out] NGNHPGHDKAF HJJHKKCCGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public CCCNCDHCGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DNNEBKKPJAB]
public sealed class NHLOJIHNOFN : BFLFALKDAHO
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery MMDGKHJMOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery PILOOJKIEDA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x84BEB60", Offset = "0x84BDF60", VA = "0x1884BEB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x84BECB0", Offset = "0x84BE0B0", VA = "0x1884BECB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x84BE860", Offset = "0x84BDC60", VA = "0x1884BE860")]
	private void GNDCHPBKOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x84BE570", Offset = "0x84BD970", VA = "0x1884BE570")]
	private void ACBDBPPIGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public NHLOJIHNOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class AJBKNKKLACP : BFLFALKDAHO, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct FKIBGHBEGHN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob OFLILOCANOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob IEFNOOMFHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob LAIAMMLPMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob LHKLFHDPDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle PJBNHDDPIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<PDBCBJNEFGK> BBBEEIIDEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> HPHMBICPDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> ODFDHKHEPPP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84AE6F0", Offset = "0x84ADAF0", VA = "0x1884AE6F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x84AE770", Offset = "0x84ADB70", VA = "0x1884AE770")]
		private void KEFFCEOGMIO(EntityQueryInJob MEHCBCCALPK, NativeList<Entity> MBIHKAGMNEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct ECCOLENGALA : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle PJBNHDDPIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<PDBCBJNEFGK> BBBEEIIDEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> MBIHKAGMNEP;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84AC200", Offset = "0x84AB600", VA = "0x1884AC200", Slot = "4")]
		public void Execute(ArchetypeChunk GIICMONPAHH, int PPLGDGGAMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct LEMOENDMEGJ : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle PJBNHDDPIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> EJPMCEGAHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<JFBGGNHNBJL> CIEEMEELHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<AOBEIIAKKHK> BILIJHFIFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<PDBCBJNEFGK> EIHKMNIJLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> EMIIJBAKMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<JFBGGNHNBJL> HKANELPOMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<NGNHPGHDKAF> OCEOEJCCGOP;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84BC020", Offset = "0x84BB420", VA = "0x1884BC020", Slot = "4")]
		public void Execute(ArchetypeChunk GIICMONPAHH, int PPLGDGGAMBD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery OFLILOCANOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery IEFNOOMFHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery LAIAMMLPMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery LHKLFHDPDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery LAAEOJDGLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery NPLNGGKIOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery HMIDEJHGDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private MFGDNLAANGB CFIPAAHOMMH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x84A7A00", Offset = "0x84A6E00", VA = "0x1884A7A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x84A6BC0", Offset = "0x84A5FC0", VA = "0x1884A6BC0", Slot = "15")]
	public override void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x84A7F80", Offset = "0x84A7380", VA = "0x1884A7F80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84A6FB0", Offset = "0x84A63B0", VA = "0x1884A6FB0")]
	private void MABECIJINIL(NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE, int PHMGOCIKIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x84A75B0", Offset = "0x84A69B0", VA = "0x1884A75B0")]
	private void MEMJFLODLGN(NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE, int GEDFDANMNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84A6780", Offset = "0x84A5B80", VA = "0x1884A6780")]
	private void IADAJJLBJFG(NativeParallelHashSet<NGNHPGHDKAF> MHKEFPICBCE, int IEPCHIBKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x84A6C20", Offset = "0x84A6020", VA = "0x1884A6C20")]
	private void LCLPEKHKJDP(NativeParallelHashSet<NGNHPGHDKAF> DHDHEOOPDAN, int DPIMPOGNNCP, int GHPGIIDMCHM, int HKEDCPCOELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84A65D0", Offset = "0x84A59D0", VA = "0x1884A65D0")]
	private void HBLFNMAIALG(Entity BGBDLJKCEDO, PGGHBPJAHOA EACKCEBODHH, NGNHPGHDKAF HJJHKKCCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public AJBKNKKLACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class KEBOLIKLAHB : BFLFALKDAHO
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery OPIILBHPEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery EJJBMNMLMDF;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84B9E60", Offset = "0x84B9260", VA = "0x1884B9E60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84BA0A0", Offset = "0x84B94A0", VA = "0x1884BA0A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public KEBOLIKLAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DILGDAAIPEH : BFLFALKDAHO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct GCIMKABBCEK : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery BHOJHKEKJJE;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84ABE90", Offset = "0x84AB290", VA = "0x1884ABE90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84ABFD0", Offset = "0x84AB3D0", VA = "0x1884ABFD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public DILGDAAIPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DNNEBKKPJAB]
internal class LOIMOBICODE : BFLFALKDAHO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class PJMPENFOACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery ECFCLFPEJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery CCOALJCENLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FCGKNHBFEEF BFOMFOJIMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType KNGLGKOFKMF;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PJMPENFOACN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void FCGKNHBFEEF(NativeArray<PGGHBPJAHOA> FELIADFOOJH, IEKGCOIIEHP JIGKMBOLPNH);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<PJMPENFOACN> MJBHHPDEGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private DHEEPFGFJHD DOAAGCFNLFD;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84BC690", Offset = "0x84BBA90", VA = "0x1884BC690", Slot = "15")]
	public override void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x84BC890", Offset = "0x84BBC90", VA = "0x1884BC890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA20", Offset = "0x84BBE20", VA = "0x1884BCA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DD0BC0", Offset = "0x3DCFFC0", VA = "0x183DD0BC0")]
	private void NHKLCIADLNK<T>(FCGKNHBFEEF BFOMFOJIMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84BC350", Offset = "0x84BB750", VA = "0x1884BC350")]
	private static void CNHCMOEPJKP(NativeArray<PGGHBPJAHOA> DHJLFOIFJKG, IEKGCOIIEHP KBLGMNFNDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84BC6F0", Offset = "0x84BBAF0", VA = "0x1884BC6F0")]
	private static void NPBOCINHMPA(NativeArray<PGGHBPJAHOA> DHJLFOIFJKG, IEKGCOIIEHP KBLGMNFNDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84BC4F0", Offset = "0x84BB8F0", VA = "0x1884BC4F0")]
	private static void DKDKBPDLNCF(NativeArray<PGGHBPJAHOA> DHJLFOIFJKG, IEKGCOIIEHP KBLGMNFNDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public LOIMOBICODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DNNEBKKPJAB]
public sealed class GOGHLPGHAPK : BFLFALKDAHO
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery MEHCBCCALPK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84B42B0", Offset = "0x84B36B0", VA = "0x1884B42B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IHOJBAJDOLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS FFICBLJOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData PPHCJIPLAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public INMHHAMFOKG LKBHLCAIMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PLGCJPDFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool LPIOKFLOGMK;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[APGGMLJJANJ(Lifetime.LoadInstance)]
public struct BGKDHBCEBHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity CHBELKDGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> BNMOMPBEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> OJAMAKLEAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<IHOJBAJDOLK> IFNJOHIILDN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x84A98B0", Offset = "0x84A8CB0", VA = "0x1884A98B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(ELGAONBJMLD), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class ELGAONBJMLD : FMPNPCDDCKO, LLJNOAGPADG, GIBCNELDPEH, OBNIMLJGHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DFLCKOMDBDE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly ELGAONBJMLD JIECBJMGMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool OBNIFJEIAKG;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A68C90", Offset = "0x1A68090", VA = "0x181A68C90")]
		public DFLCKOMDBDE(ELGAONBJMLD JIECBJMGMAC, bool OBNIFJEIAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84ABDD0", Offset = "0x84AB1D0", VA = "0x1884ABDD0")]
		public Queue<BNNELNAEKHL>.Enumerator OJAPBOKMMBI()
		{
			return default(Queue<BNNELNAEKHL>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84ABA90", Offset = "0x84AAE90", VA = "0x1884ABA90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private MHFAEJPNHJP CNKCCCNPKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private PLNPFJLOHIL PEJOKJNOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<ABIKCOMHDNG>> HHLIHGKLHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> EGIIDJNEOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<PGGHBPJAHOA> BDOPPOAJJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KBFBFCBDDEI<BNNELNAEKHL> BIEPIBAJKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KBFBFCBDDEI<BGKDHBCEBHC> OCOMNHAPDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private KBFBFCBDDEI<GGNEMNALEEH> LBFODFKDGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84ADE20", Offset = "0x84AD220", VA = "0x1884ADE20", Slot = "4")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84ADA70", Offset = "0x84ACE70", VA = "0x1884ADA70")]
	public void GGDKNMPBEAL(NativeList<ABIKCOMHDNG> FKGKCFLIBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84AD030", Offset = "0x84AC430", VA = "0x1884AD030")]
	public void AJMDECHOBMM(Entity JIECBJMGMAC, [In] PNBCFLDECIA<GameObject> PFLOMPFPOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84AD9E0", Offset = "0x84ACDE0", VA = "0x1884AD9E0")]
	public void FDMOFIFNAHD(NativeList<PGGHBPJAHOA> DHJLFOIFJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84AD180", Offset = "0x84AC580", VA = "0x1884AD180")]
	public void CEFJCOMOJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84AD3F0", Offset = "0x84AC7F0", VA = "0x1884AD3F0")]
	public void CPAOKOGFLBG(KGMOHGCFKDB JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x84AD940", Offset = "0x84ACD40", VA = "0x1884AD940")]
	public JobHandle DKJGAAELMOB([In] BNNELNAEKHL AFDNIPHJHMO, JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84AD8A0", Offset = "0x84ACCA0", VA = "0x1884AD8A0")]
	public JobHandle DKJGAAELMOB([In] BGKDHBCEBHC AFDNIPHJHMO, JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8131930", Offset = "0x8130D30", VA = "0x188131930")]
	public DFLCKOMDBDE EHJHANHMOIG(bool OBNIFJEIAKG)
	{
		return default(DFLCKOMDBDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84AD3A0", Offset = "0x84AC7A0", VA = "0x1884AD3A0")]
	public ONHMLLHIEOH<BGKDHBCEBHC> CNHMBFMGHOM()
	{
		return default(ONHMLLHIEOH<BGKDHBCEBHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84AE020", Offset = "0x84AD420", VA = "0x1884AE020")]
	public ONHMLLHIEOH<GGNEMNALEEH> LFFOFOHEGLC()
	{
		return default(ONHMLLHIEOH<GGNEMNALEEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84ADB20", Offset = "0x84ACF20", VA = "0x1884ADB20")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84ADD40", Offset = "0x84AD140", VA = "0x1884ADD40", Slot = "5")]
	public void IFLOIAOAMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84AE070", Offset = "0x84AD470", VA = "0x1884AE070", Slot = "6")]
	private void LOIPDCNMFAN(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0xFAB3B0", Offset = "0xFAA7B0", VA = "0x180FAB3B0", Slot = "7")]
	private void IBPLCLLIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ELGAONBJMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FEOFAMNHDDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS FFICBLJOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData PPHCJIPLAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public BFGADLCEFPF FGEMBJJOPFK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[APGGMLJJANJ(Lifetime.LoadInstance)]
public struct BNNELNAEKHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity CHBELKDGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> BNMOMPBEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> OJAMAKLEAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<NJKCHNHGMDO> KMMKAGGMBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<ABIKCOMHDNG> FKGKCFLIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<FEOFAMNHDDN> INHNCBEEFFP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84A9940", Offset = "0x84A8D40", VA = "0x1884A9940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84A9950", Offset = "0x84A8D50", VA = "0x1884A9950")]
	public void HNJLALOFPOG(bool OBNIFJEIAKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(JGPCBKPHHMJ), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class JGPCBKPHHMJ : HOHCEPPJBFD, GIBCNELDPEH, OBNIMLJGHNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private ELGAONBJMLD DOMOLOAAMKO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84B96F0", Offset = "0x84B8AF0", VA = "0x1884B96F0", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84B96A0", Offset = "0x84B8AA0", VA = "0x1884B96A0", Slot = "5")]
	private void LOIPDCNMFAN(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x12EF0D0", Offset = "0x12EE4D0", VA = "0x1812EF0D0", Slot = "6")]
	private void IBPLCLLIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JGPCBKPHHMJ()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : BFLFALKDAHO, FMPNPCDDCKO
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
			public NativeParallelHashMap<int, INMHHAMFOKG> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<IHOJBAJDOLK> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x84B46F0", Offset = "0x84B3AF0", VA = "0x1884B46F0", Slot = "4")]
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
			public NativeArray<ABIKCOMHDNG> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<NJKCHNHGMDO> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<FEOFAMNHDDN> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x84B4A90", Offset = "0x84B3E90", VA = "0x1884B4A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84AB950", Offset = "0x84AAD50", VA = "0x1884AB950", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x84C1A90", Offset = "0x84C0E90", VA = "0x1884C1A90")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x84C1AB0", Offset = "0x84C0EB0", VA = "0x1884C1AB0")]
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
				float3 NMIOEABNPJD(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x84BCFB0", Offset = "0x84BC3B0", VA = "0x1884BCFB0", Slot = "5")]
				public float3 AHHLKKBEDFM(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x84BD360", Offset = "0x84BC760", VA = "0x1884BD360", Slot = "4")]
				public float3 NMIOEABNPJD(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x84BED60", Offset = "0x84BE160", VA = "0x1884BED60", Slot = "4")]
				public float3 NMIOEABNPJD(quaternion rotation)
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
			public NativeArray<NJKCHNHGMDO> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<ABIKCOMHDNG> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x84B5A80", Offset = "0x84B4E80", VA = "0x1884B5A80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x84B6290", Offset = "0x84B5690", VA = "0x1884B6290")]
			private void FJMEKKNMOFP(NativeList<PointSrcData> srcData, NativeList<ABIKCOMHDNG> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x84B8C70", Offset = "0x84B8070", VA = "0x1884B8C70")]
			public static Vector3 PNCLHGOHLKM(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x84B5590", Offset = "0x84B4990", VA = "0x1884B5590")]
			public static quaternion CGDGALEKHHP(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x84B5360", Offset = "0x84B4760", VA = "0x1884B5360")]
			private static quaternion CFDHEHBHGDJ(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x84B7350", Offset = "0x84B6750", VA = "0x1884B7350")]
			private static float3 GIABJBOOPOH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x84B59F0", Offset = "0x84B4DF0", VA = "0x1884B59F0")]
			private static quaternion DODPKMNENFN(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x84B5780", Offset = "0x84B4B80", VA = "0x1884B5780")]
			private static ABIKCOMHDNG DFPEILPKOCA(int idx, NativeList<PointSrcData> srcData)
			{
				return default(ABIKCOMHDNG);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x441CD40", Offset = "0x441C140", VA = "0x18441CD40")]
			private void HHJKLOIFIBN<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x84B76A0", Offset = "0x84B6AA0", VA = "0x1884B76A0")]
			private void HJEIBHPKCPH(NativeList<PointSrcData> sourcePoints, NativeList<ABIKCOMHDNG> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x84B7520", Offset = "0x84B6920", VA = "0x1884B7520")]
			public static float HDBOBKDLDKF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x84B60A0", Offset = "0x84B54A0", VA = "0x1884B60A0")]
			private static quaternion FFCCBCGDKGI(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x84B8AC0", Offset = "0x84B7EC0", VA = "0x1884B8AC0")]
			private static ABIKCOMHDNG JNHJFHIBOCA(PointSrcData point)
			{
				return default(ABIKCOMHDNG);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x84B8BE0", Offset = "0x84B7FE0", VA = "0x1884B8BE0")]
			private static ABIKCOMHDNG JNHJFHIBOCA(float3 pos, quaternion rot, float radius)
			{
				return default(ABIKCOMHDNG);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x84B56E0", Offset = "0x84B4AE0", VA = "0x1884B56E0")]
			private static bool CNGGFLBJEDH(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x84B5610", Offset = "0x84B4A10", VA = "0x1884B5610")]
			private static float3 CKAGFGCIOFN(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x84B8910", Offset = "0x84B7D10", VA = "0x1884B8910")]
			public static float3 IOFFJMKOENI(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x84B51B0", Offset = "0x84B45B0", VA = "0x1884B51B0")]
			public static float3 AHHLKKBEDFM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x84B84B0", Offset = "0x84B78B0", VA = "0x1884B84B0")]
			private static quaternion HNCAFKGJKOF(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x84B7170", Offset = "0x84B6570", VA = "0x1884B7170")]
			private static float FLEJLJJLJCL(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x84C3FE0", Offset = "0x84C33E0", VA = "0x1884C3FE0")]
			private void MNLFJJBMCPO(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x84C3EF0", Offset = "0x84C32F0", VA = "0x1884C3EF0", Slot = "4")]
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
			public NativeList<ABIKCOMHDNG> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x84C54E0", Offset = "0x84C48E0", VA = "0x1884C54E0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x84C54D0", Offset = "0x84C48D0", VA = "0x1884C54D0", Slot = "4")]
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
			public NativeList<ABIKCOMHDNG> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x84C5480", Offset = "0x84C4880", VA = "0x1884C5480")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x84C5470", Offset = "0x84C4870", VA = "0x1884C5470", Slot = "4")]
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
			public NativeList<IHOJBAJDOLK> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x84B4DE0", Offset = "0x84B41E0", VA = "0x1884B4DE0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x84B4DD0", Offset = "0x84B41D0", VA = "0x1884B4DD0", Slot = "4")]
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
			public NativeList<NJKCHNHGMDO> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<FEOFAMNHDDN> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x84B4FB0", Offset = "0x84B43B0", VA = "0x1884B4FB0")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84B4FA0", Offset = "0x84B43A0", VA = "0x1884B4FA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84C5050", Offset = "0x84C4450", VA = "0x1884C5050")]
			private void MNLFJJBMCPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x84C5040", Offset = "0x84C4440", VA = "0x1884C5040", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly AKNCNLDICPO log;

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
		private CLFCFOAFCHG replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MHFAEJPNHJP objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private ELGAONBJMLD bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private JOMHFGPJNEI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84C35C0", Offset = "0x84C29C0", VA = "0x1884C35C0", Slot = "15")]
		public override void InitReferences(BBKOKELKFDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84C4CF0", Offset = "0x84C40F0", VA = "0x1884C4CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84C4DE0", Offset = "0x84C41E0", VA = "0x1884C4DE0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84C4E40", Offset = "0x84C4240", VA = "0x1884C4E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84C1BF0", Offset = "0x84C0FF0", VA = "0x1884C1BF0")]
		private JobHandle AJEMIABJLIL(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84C2F00", Offset = "0x84C2300", VA = "0x1884C2F00")]
		private JobHandle IINEOHIMDGI(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84C2E60", Offset = "0x84C2260", VA = "0x1884C2E60")]
		private JobHandle KDIGLOMAOPP(NativeArray<int> pointCount, NativeList<ABIKCOMHDNG> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84C2DC0", Offset = "0x84C21C0", VA = "0x1884C2DC0")]
		private JobHandle GAOADEBHAHG(NativeList<ABIKCOMHDNG> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84C27D0", Offset = "0x84C1BD0", VA = "0x1884C27D0")]
		private JobHandle CNBAKEBABFI(EntityQuery query, NativeList<NJKCHNHGMDO> splinePointRanges, NativeList<ABIKCOMHDNG> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84C2CA0", Offset = "0x84C20A0", VA = "0x1884C2CA0")]
		private JobHandle DKDJNGGIGML(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84C41A0", Offset = "0x84C35A0", VA = "0x1884C41A0")]
		private JobHandle NAGKIOFGBKO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x84C1F30", Offset = "0x84C1330", VA = "0x1884C1F30")]
		private JobHandle APJAKPIHGAL(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<IHOJBAJDOLK> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x84C46E0", Offset = "0x84C3AE0", VA = "0x1884C46E0")]
		private JobHandle OLEMHBACNIK(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<NJKCHNHGMDO> splinePointRanges, [Out] NativeList<FEOFAMNHDDN> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84C3B70", Offset = "0x84C2F70", VA = "0x1884C3B70")]
		private JobHandle LJEMDFLJOCK(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84C3660", Offset = "0x84C2A60", VA = "0x1884C3660")]
		private JobHandle JMDFBMOLHGP(EntityQuery query, NativeList<IHOJBAJDOLK> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84C42C0", Offset = "0x84C36C0", VA = "0x1884C42C0")]
		private static NativeParallelHashMap<int, INMHHAMFOKG> NMKIANILIPD()
		{
			return default(NativeParallelHashMap<int, INMHHAMFOKG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84C2430", Offset = "0x84C1830", VA = "0x1884C2430")]
		private JobHandle CMCBENNJNHK(EntityQuery query, NativeList<NJKCHNHGMDO> splinePointRanges, NativeList<ABIKCOMHDNG> splinePointData, NativeList<FEOFAMNHDDN> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x84C40C0", Offset = "0x84C34C0", VA = "0x1884C40C0")]
		private JobHandle MLNLNJMHPLJ(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84C2E60", Offset = "0x84C2260", VA = "0x1884C2E60")]
		private JobHandle HAIOGFFGPIH(NativeArray<int> pointCount, NativeList<ABIKCOMHDNG> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84C2DC0", Offset = "0x84C21C0", VA = "0x1884C2DC0")]
		private JobHandle NHGFPBPBDLG(NativeList<ABIKCOMHDNG> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84C1B00", Offset = "0x84C0F00", VA = "0x1884C1B00")]
		private JobHandle AAOCPGNNPJN(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<IHOJBAJDOLK> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84C21D0", Offset = "0x84C15D0", VA = "0x1884C21D0")]
		private JobHandle BHODGHMMFHB(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<NJKCHNHGMDO> ranges, NativeList<FEOFAMNHDDN> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84C22E0", Offset = "0x84C16E0", VA = "0x1884C22E0")]
		private JobHandle BKJGDCHFPJN(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84C49A0", Offset = "0x84C3DA0", VA = "0x1884C49A0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PEGNKBEFCIO : IHEMLNHABNH, FMPNPCDDCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private ELGAONBJMLD DOMOLOAAMKO;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x84C1A20", Offset = "0x84C0E20", VA = "0x1884C1A20", Slot = "14")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x84C1A70", Offset = "0x84C0E70", VA = "0x1884C1A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
	public PEGNKBEFCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class FLPJIFEDCHD : BFLFALKDAHO, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct CGAFFBEKAEO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager JGFECLAMEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private OPIHLKGAMMF<T> FPHMDDANKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int NOEININIMIL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6D706A0", Offset = "0x6D6FAA0", VA = "0x186D706A0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6D708F0", Offset = "0x6D6FCF0", VA = "0x186D708F0")]
		public CGAFFBEKAEO(EntityManager JGFECLAMEOK, OPIHLKGAMMF<T> FPHMDDANKNJ, NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4A9BDE0", Offset = "0x4A9B1E0", VA = "0x184A9BDE0")]
		public CGAFFBEKAEO<T> OJAPBOKMMBI()
		{
			return default(CGAFFBEKAEO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FF50", Offset = "0x6D6F350", VA = "0x186D6FF50")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly AKNCNLDICPO OHJHCMFMIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PLNPFJLOHIL PEJOKJNOJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private ELGAONBJMLD DOMOLOAAMKO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x84B0690", Offset = "0x84AFA90", VA = "0x1884B0690", Slot = "15")]
	public override void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x84B0660", Offset = "0x84AFA60", VA = "0x1884B0660")]
	public void GJMIALCKMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x84B1EA0", Offset = "0x84B12A0", VA = "0x1884B1EA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x84AE850", Offset = "0x84ADC50", VA = "0x1884AE850")]
	private void ABJPPLOAMFC(GGNEMNALEEH AFDNIPHJHMO, Mesh[] LCOEDLEMBLE, NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F330", Offset = "0x3C9E730", VA = "0x183C9F330")]
	private CGAFFBEKAEO<T> FMCNEHENHIE<T>(OPIHLKGAMMF<T> FPHMDDANKNJ, NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO) where T : struct
	{
		return default(CGAFFBEKAEO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x84AFE30", Offset = "0x84AF230", VA = "0x1884AFE30")]
	private void BPCIPOAFOIK(Transform JIECBJMGMAC, NativeArray<LEGMCLEGFMJ> CNDJGEALFLI, PNBCFLDECIA<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x84AF970", Offset = "0x84AED70", VA = "0x1884AF970")]
	private void ACAAOJJHEKD(Transform JIECBJMGMAC, NativeArray<LHMHKINJMON> ICJPLEBFKAE, PNBCFLDECIA<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x84B0280", Offset = "0x84AF680", VA = "0x1884B0280")]
	private void EOGKDBGIMLK(Transform JIECBJMGMAC, NativeArray<BCGKAACKEBN> DLCONBAALPO, PNBCFLDECIA<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x84B1920", Offset = "0x84B0D20", VA = "0x1884B1920")]
	private void OAPHIDHEBHJ(Transform JIECBJMGMAC, NativeArray<PIOJDGCIPDH> LCOEDLEMBLE, Mesh[] EGJHAOAOGDC, PNBCFLDECIA<GameObject> HAFPNOBOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x84B1D50", Offset = "0x84B1150", VA = "0x1884B1D50")]
	private static void OMLAECDEODG(NativeParallelHashSet<Entity> FGABDCIOGLK, NativeParallelHashSet<Entity> CKFJNBFCLDK, NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x84B01C0", Offset = "0x84AF5C0", VA = "0x1884B01C0")]
	private static void EAIAKFBKDJP(NativeList<Entity> KIGLENMLJCP, NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x84B0710", Offset = "0x84AFB10", VA = "0x1884B0710")]
	private NativeParallelHashMap<Entity, AOBEIIAKKHK> JHFPCGPHMHF(ELGAONBJMLD.DFLCKOMDBDE LLNAIDLLMCJ, ONHMLLHIEOH<BGKDHBCEBHC> HHFOECCENPE, List<GameObject> HAFPNOBOFIH)
	{
		return default(NativeParallelHashMap<Entity, AOBEIIAKKHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x84B1820", Offset = "0x84B0C20", VA = "0x1884B1820")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> LKPDPFBIKLD(Entity KEBOGPAAGDM)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x84B12D0", Offset = "0x84B06D0", VA = "0x1884B12D0")]
	private void LDPLOKJCKAA(NativeList<Entity> HBOKCBMJLHM, NativeList<Entity> IBJBOAJOFKK, NativeParallelHashMap<Entity, AOBEIIAKKHK> DAMIIFKCNLA, NativeList<NJKCHNHGMDO> NAHOEBAJOIH, NativeList<ABIKCOMHDNG> IDNGONCBFPK, NativeList<FEOFAMNHDDN> HHLIHGKLHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x84B3010", Offset = "0x84B2410", VA = "0x1884B3010")]
	private void PDLHAMCPKFI(NativeList<Entity> FGABDCIOGLK, NativeList<Entity> BNMOMPBEPGM, NativeParallelHashMap<Entity, AOBEIIAKKHK> DAMIIFKCNLA, NativeList<IHOJBAJDOLK> IFNJOHIILDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x84A8300", Offset = "0x84A7700", VA = "0x1884A8300")]
	public FLPJIFEDCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class KNCONIHEBJC : HDBHIAFLJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS FFICBLJOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly OAMEECEEOCH JIECBJMGMAC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject EOIMHFEFFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS ENMAOKJKOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x84BBD10", Offset = "0x84BB110", VA = "0x1884BBD10", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 AHDKEPJGEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x84BBC70", Offset = "0x84BB070", VA = "0x1884BBC70", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 IDOKLGGBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x84BBC20", Offset = "0x84BB020", VA = "0x1884BBC20", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 FPDMOOLMBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84BBF30", Offset = "0x84BB330", VA = "0x1884BBF30", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE90", Offset = "0x84BB290", VA = "0x1884BBE90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion LMPBOALGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x84BBEE0", Offset = "0x84BB2E0", VA = "0x1884BBEE0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE40", Offset = "0x84BB240", VA = "0x1884BBE40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 MBNJCFCFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84BBCC0", Offset = "0x84BB0C0", VA = "0x1884BBCC0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 IPPIGDIFDII
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x84BBF80", Offset = "0x84BB380", VA = "0x1884BBF80", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 LCIILMFCJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84BBDF0", Offset = "0x84BB1F0", VA = "0x1884BBDF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x84BBFD0", Offset = "0x84BB3D0", VA = "0x1884BBFD0")]
	public KNCONIHEBJC(UniformTRS FFICBLJOMDD, OAMEECEEOCH JIECBJMGMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IDMMAJDPOIN : KNCONIHEBJC, KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float ADLMLIEOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 CKKCOAPGODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly HOPHEEHHBNP FFJNHKKJBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly BMPAPPBHELN BCHBEKOGKAP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private GIJLHKFOFFB LFBAHDBIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x84B92B0", Offset = "0x84B86B0", VA = "0x1884B92B0", Slot = "17")]
		get
		{
			return default(GIJLHKFOFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS GBPIBKGPGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x84B91D0", Offset = "0x84B85D0", VA = "0x1884B91D0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float IGDDJKHEMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAC27C0", Offset = "0xAC1BC0", VA = "0x180AC27C0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 CJENAHHCLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84B9300", Offset = "0x84B8700", VA = "0x1884B9300", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HOPHEEHHBNP HNFBIEJJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAD90A0", Offset = "0xAD84A0", VA = "0x180AD90A0", Slot = "21")]
		get
		{
			return default(HOPHEEHHBNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private BMPAPPBHELN BOEDHEHABEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x146C6F0", Offset = "0x146BAF0", VA = "0x18146C6F0", Slot = "22")]
		get
		{
			return default(BMPAPPBHELN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool PLOBDKDKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ONJGLIEOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x84B9350", Offset = "0x84B8750", VA = "0x1884B9350")]
	protected IDMMAJDPOIN(UniformTRS FFICBLJOMDD, OAMEECEEOCH JIECBJMGMAC, float ADLMLIEOCMK, float3 CKKCOAPGODB, HOPHEEHHBNP FFJNHKKJBIM, BMPAPPBHELN BCHBEKOGKAP)
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
public abstract class GOEGKKAMCEJ : HDBHIAFLJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly NAIIODHHNBF FBNJAHIFLKC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected OAMEECEEOCH HACCPIDBCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x12DC660", Offset = "0x12DBA60", VA = "0x1812DC660")]
		get
		{
			return default(OAMEECEEOCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x84B3E70", Offset = "0x84B3270", VA = "0x1884B3E70")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected MHFAEJPNHJP EPCFGMJMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x84B40E0", Offset = "0x84B34E0", VA = "0x1884B40E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected FGPBDDGCBGJ MCFHOGBMFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x84B3780", Offset = "0x84B2B80", VA = "0x1884B3780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected FOOPJJDIOEH LDGBAJEDOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x84B3DE0", Offset = "0x84B31E0", VA = "0x1884B3DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject EOIMHFEFFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x84B3CB0", Offset = "0x84B30B0", VA = "0x1884B3CB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS ENMAOKJKOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1304E90", Offset = "0x1304290", VA = "0x181304E90", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 AHDKEPJGEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x84B37E0", Offset = "0x84B2BE0", VA = "0x1884B37E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 IDOKLGGBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x84B3610", Offset = "0x84B2A10", VA = "0x1884B3610", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 FPDMOOLMBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84B3FB0", Offset = "0x84B33B0", VA = "0x1884B3FB0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84B3CE0", Offset = "0x84B30E0", VA = "0x1884B3CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion LMPBOALGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x84B3E90", Offset = "0x84B3290", VA = "0x1884B3E90", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84B3B80", Offset = "0x84B2F80", VA = "0x1884B3B80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 MBNJCFCFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x84B38D0", Offset = "0x84B2CD0", VA = "0x1884B38D0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 IPPIGDIFDII
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84B40F0", Offset = "0x84B34F0", VA = "0x1884B40F0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 LCIILMFCJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x84B39C0", Offset = "0x84B2DC0", VA = "0x1884B39C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xF30E60", Offset = "0xF30260", VA = "0x180F30E60")]
	protected GOEGKKAMCEJ(NAIIODHHNBF ANKACPFCKKH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x84B3C80", Offset = "0x84B3080", VA = "0x1884B3C80")]
	public static GIJLHKFOFFB GKKMDDPCKIG(GOEGKKAMCEJ DBAMLJDDEJL)
	{
		return default(GIJLHKFOFFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class COGEGFCMAFA
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x84C61E0", Offset = "0x84C55E0", VA = "0x1884C61E0")]
	public static void FJMIEGKPPIC(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JHPBAKNIEHM
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x84C6A30", Offset = "0x84C5E30", VA = "0x1884C6A30")]
	public static void LLJKPMGADGP(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK, KGMOHGCFKDB NFKFLBHFFLG, MHFAEJPNHJP GFKIDJOBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x84C7120", Offset = "0x84C6520", VA = "0x1884C7120")]
	public static void PHAMFJJAEOE(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK, KGMOHGCFKDB NFKFLBHFFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x84C70A0", Offset = "0x84C64A0", VA = "0x1884C70A0")]
	public static NativeList<Entity> MICOFKOJGDI(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x84C70E0", Offset = "0x84C64E0", VA = "0x1884C70E0")]
	public static NativeList<Entity> MKOPMDJNPOO(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x84C6E40", Offset = "0x84C6240", VA = "0x1884C6E40")]
	private static NativeList<Entity> MICOFKOJGDI(NativeArray<Entity> FGABDCIOGLK, EntityManager JGFECLAMEOK, bool PFHPKMFDHED)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class HAOJEKGKEGC : GOEGKKAMCEJ, KAFHCNKFIJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float ADLMLIEOCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 CKKCOAPGODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private HOPHEEHHBNP FFJNHKKJBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private BMPAPPBHELN BCHBEKOGKAP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager LLDMANKJGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x84C65A0", Offset = "0x84C59A0", VA = "0x1884C65A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DJEGDOLDLFH LJBGKPDCCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84C6450", Offset = "0x84C5850", VA = "0x1884C6450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData EHBODLAEONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x84C64B0", Offset = "0x84C58B0", VA = "0x1884C64B0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private GIJLHKFOFFB LFBAHDBIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x84B3C80", Offset = "0x84B3080", VA = "0x1884B3C80", Slot = "17")]
		get
		{
			return default(GIJLHKFOFFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float IGDDJKHEMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 CJENAHHCLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x13E0020", Offset = "0x13DF420", VA = "0x1813E0020", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HOPHEEHHBNP HNFBIEJJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130", Slot = "21")]
		get
		{
			return default(HOPHEEHHBNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BMPAPPBHELN BOEDHEHABEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670", Slot = "22")]
		get
		{
			return default(BMPAPPBHELN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS GBPIBKGPGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x84C6420", Offset = "0x84C5820", VA = "0x1884C6420", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ONJGLIEOOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA9C410", Offset = "0xA9B810", VA = "0x180A9C410")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool PLOBDKDKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x84C67C0", Offset = "0x84C5BC0", VA = "0x1884C67C0")]
	protected HAOJEKGKEGC(NAIIODHHNBF ANKACPFCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84C6630", Offset = "0x84C5A30", VA = "0x1884C6630", Slot = "26")]
	public virtual void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class BFLFALKDAHO : IHEMLNHABNH, FMPNPCDDCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected MHFAEJPNHJP GFKIDJOBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private HHCMFEOCFNN ANBICBPBIDK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected KGMOHGCFKDB AIKCJPBGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x84C6080", Offset = "0x84C5480", VA = "0x1884C6080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected IEKGCOIIEHP NJHODAGHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x84C60D0", Offset = "0x84C54D0", VA = "0x1884C60D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool EMBHFDKCFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84C6120", Offset = "0x84C5520", VA = "0x1884C6120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x84C6010", Offset = "0x84C5410", VA = "0x1884C6010", Slot = "15")]
	public virtual void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
	protected BFLFALKDAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JHIHHGEPFEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x84C67F0", Offset = "0x84C5BF0", VA = "0x1884C67F0")]
	public static void DPLOOEBFBGI(NativeArray<Entity> HBOKCBMJLHM, EntityManager JGFECLAMEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3945089838
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x84C76C0", Offset = "0x84C6AC0", VA = "0x1884C76C0")]
	public static void GFGHLGNFNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x84C76B0", Offset = "0x84C6AB0", VA = "0x1884C76B0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class KEDBGFGDFEJ : ContainerPropertyBag<ILJADMNBDON>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x84C7490", Offset = "0x84C6890", VA = "0x1884C7490")]
	public KEDBGFGDFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class KCALGBAFKIO : ContainerPropertyBag<GMJIDAACPBO>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x84C7430", Offset = "0x84C6830", VA = "0x1884C7430")]
	public KCALGBAFKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class AJOMHGIGOCA : ContainerPropertyBag<HIOMOMBDANA>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x84C5FB0", Offset = "0x84C53B0", VA = "0x1884C5FB0")]
	public AJOMHGIGOCA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x84C74F0", Offset = "0x84C68F0", VA = "0x1884C74F0")]
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
