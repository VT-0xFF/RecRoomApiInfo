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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E256E0", Offset = "0x7E246E0", VA = "0x187E256E0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x204FCB0", Offset = "0x204ECB0", VA = "0x18204FCB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E2CB20", Offset = "0x7E2BB20", VA = "0x187E2CB20")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D0C0", Offset = "0x7E2C0C0", VA = "0x187E2D0C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E2D120", Offset = "0x7E2C120", VA = "0x187E2D120")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JJHAEPJDCMN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AFC0", Offset = "0x7E19FC0", VA = "0x187E1AFC0")]
	public static Quaternion JEGADKNNKFO([In] this LKMBOJBJICB HMFCGNLLBJA, [In] Vector3 IGEMMIGMOOK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EBBGDLCCOFC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E108A0", Offset = "0x7E0F8A0", VA = "0x187E108A0")]
	public static bool BAIDJDIDMKI(this FENODIDCBGH FKFPDEAIGAP, CMOLENMEPKL CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E11080", Offset = "0x7E10080", VA = "0x187E11080")]
	public static bool JAHOGAAEOAD(this FENODIDCBGH FKFPDEAIGAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E11830", Offset = "0x7E10830", VA = "0x187E11830")]
	public static bool NHIBGHBMDHK(this FENODIDCBGH FKFPDEAIGAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E10910", Offset = "0x7E0F910", VA = "0x187E10910")]
	public static void CHBNGLMEHPM(this FENODIDCBGH FKFPDEAIGAP, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E110B0", Offset = "0x7E100B0", VA = "0x187E110B0")]
	public static void KCCGGHDIMPK(this FENODIDCBGH FKFPDEAIGAP, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN, int BCHDDCOGALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E10D70", Offset = "0x7E0FD70", VA = "0x187E10D70")]
	public static void EOMHKMPMPLE(this FENODIDCBGH FKFPDEAIGAP, int BCHDDCOGALL, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E11A20", Offset = "0x7E10A20", VA = "0x187E11A20")]
	public static void NKMELCLJJML(this FENODIDCBGH FKFPDEAIGAP, Vector3 OJNINNGHJKK, Quaternion BCOJNGHILBJ, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E11A70", Offset = "0x7E10A70", VA = "0x187E11A70")]
	private static void OGKMLKGNMCN(this FENODIDCBGH FKFPDEAIGAP, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E11860", Offset = "0x7E10860", VA = "0x187E11860")]
	private static void NINMPEBBHKB(this FENODIDCBGH FKFPDEAIGAP, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E10E90", Offset = "0x7E0FE90", VA = "0x187E10E90")]
	private static void GKAJKCFJOFA(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E108E0", Offset = "0x7E0F8E0", VA = "0x187E108E0")]
	private static bool BBFACCFMDMJ(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E123D0", Offset = "0x7E113D0", VA = "0x187E123D0")]
	private static void PDJHDIOGKGN(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E11340", Offset = "0x7E10340", VA = "0x187E11340")]
	public static Vector3 MJINHKCHCED(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E10C60", Offset = "0x7E0FC60", VA = "0x187E10C60")]
	public static Quaternion DPKEIPKDLIL(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E10A40", Offset = "0x7E0FA40", VA = "0x187E10A40")]
	public static Vector3 CKDNIMHMOJD(CMOLENMEPKL EIBMLBPPJAJ, Vector3 EPCLGOKLIPO, Vector3? NHCNCBJFGPH, Vector3 MPHNLOFBHEJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JJKIDMLKOGH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface JOCBLPDAFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DPAIAEOBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KBBMPBLGDHF : JJKIDMLKOGH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BA20", Offset = "0x7E1AA20", VA = "0x187E1BA20", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KBBMPBLGDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class BLLBFFNAKBE : JJKIDMLKOGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LIPCMCBNFNH HBODJJIPFAP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
	public BLLBFFNAKBE(LIPCMCBNFNH HBODJJIPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E550", Offset = "0x7E0D550", VA = "0x187E0E550", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PIMEODKKKKC : JJKIDMLKOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E289C0", Offset = "0x7E279C0", VA = "0x187E289C0", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PIMEODKKKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JMBONFALHLD : JOCBLPDAFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DPAIAEOBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B4A0", Offset = "0x7E1A4A0", VA = "0x187E1B4A0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B7A0", Offset = "0x7E1A7A0", VA = "0x187E1B7A0", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B4D0", Offset = "0x7E1A4D0", VA = "0x187E1B4D0", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B750", Offset = "0x7E1A750", VA = "0x187E1B750", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JMBONFALHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HFDKKBEEPHH : JOCBLPDAFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DPAIAEOBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E19840", Offset = "0x7E18840", VA = "0x187E19840", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E19B40", Offset = "0x7E18B40", VA = "0x187E19B40", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E19870", Offset = "0x7E18870", VA = "0x187E19870", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E19AF0", Offset = "0x7E18AF0", VA = "0x187E19AF0", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public HFDKKBEEPHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BIKCDKNOFMD : JOCBLPDAFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DPAIAEOBNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E0DFD0", Offset = "0x7E0CFD0", VA = "0x187E0DFD0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E2D0", Offset = "0x7E0D2D0", VA = "0x187E0E2D0", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E000", Offset = "0x7E0D000", VA = "0x187E0E000", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E280", Offset = "0x7E0D280", VA = "0x187E0E280", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BIKCDKNOFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LEPLIIFMGCC : DPKKALIBIFL, PNPJOMLIBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FKMDIIGFMOG JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IKIKHILFKDN ABEIHHFHADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CLFFFENGNKK PFOPIPGPNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JJKIDMLKOGH adapter)> HLBAMPAAPMB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E240D0", Offset = "0x7E230D0", VA = "0x187E240D0", Slot = "15")]
	public virtual void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E24160", Offset = "0x7E23160", VA = "0x187E24160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E23F50", Offset = "0x7E22F50", VA = "0x187E23F50")]
	private void BHNMKGJLOJI(EntityQueryDesc BNOFDCLPOBM, JJKIDMLKOGH ICEHFBCKOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E24390", Offset = "0x7E23390", VA = "0x187E24390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29CDEA0", Offset = "0x29CCEA0", VA = "0x1829CDEA0")]
	public LEPLIIFMGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class MOOIGHBHPFD : DPKKALIBIFL, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class FADECFIJCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery OJHFMMOLBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HNAHFDEFIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery NCBIHOAPELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery ADBGJPFCIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery BINJEMCNHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery GFODGOPMKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery KKDHMPNACOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JOCBLPDAFOI CDLDHDFACLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType GLMOMDGEFLE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FADECFIJCJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private FKMDIIGFMOG JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CLFFFENGNKK PFOPIPGPNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IKIKHILFKDN ABEIHHFHADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<FADECFIJCJL> HLBAMPAAPMB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E265F0", Offset = "0x7E255F0", VA = "0x187E265F0", Slot = "14")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E26680", Offset = "0x7E25680", VA = "0x187E26680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E26800", Offset = "0x7E25800", VA = "0x187E26800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E261A0", Offset = "0x7E251A0", VA = "0x187E261A0")]
	private void IILCCPKCOOM(FADECFIJCJL HBOHOPEJPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E25A60", Offset = "0x7E24A60", VA = "0x187E25A60")]
	private void BHNMKGJLOJI(JOCBLPDAFOI CDLDHDFACLF, ComponentType NPFIDHBDODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29CDEA0", Offset = "0x29CCEA0", VA = "0x1829CDEA0")]
	public MOOIGHBHPFD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct EILLBPHFCCA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct LBPCHGKANDN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct IGLFCECMPHI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(CLFFFENGNKK), new string[] { })]
public class KJCJFKHNJCD : CLFFFENGNKK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KIOOHKBHOLJ GCHDFGOFFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KIOOHKBHOLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KJCJFKHNJCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(KMODMBDLHLB), new string[] { })]
public class KOBNALENICG : KMODMBDLHLB, NCBKAJEOCJJ, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private DIDIFHNCLFN JEOJCJGMOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private FKMDIIGFMOG JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private JFDGJOPOGFB GGBPNJIDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity IBNFBPLOBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NCCENBGIEMA KNCNOBDIODI;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E23260", Offset = "0x7E22260", VA = "0x187E23260", Slot = "4")]
	public bool EGNNGPHJIGO(PKENAFNLEAO GOGGPBKDKBC, NBDNAFKNLDM OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E23450", Offset = "0x7E22450", VA = "0x187E23450", Slot = "5")]
	public NCCENBGIEMA OBHCPINIMHB()
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E23340", Offset = "0x7E22340", VA = "0x187E23340", Slot = "6")]
	public void HGMPKJGBHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E231D0", Offset = "0x7E221D0", VA = "0x187E231D0", Slot = "7")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1153360", Offset = "0x1152360", VA = "0x181153360", Slot = "8")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KOBNALENICG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(KHALAAIOGCO), new string[] { })]
public class NEPNELAGOIE : KHALAAIOGCO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E27410", Offset = "0x7E26410", VA = "0x187E27410", Slot = "4")]
	public void HGDPAKOJAAA(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E27500", Offset = "0x7E26500", VA = "0x187E27500", Slot = "5")]
	public void OCJMJKHCBJB(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E26B00", Offset = "0x7E25B00", VA = "0x187E26B00", Slot = "6")]
	public ComponentSystemBase ENGFLLCFLCP(World JEOJCJGMOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E26AA0", Offset = "0x7E25AA0", VA = "0x187E26AA0", Slot = "7")]
	public void CNDJHACJOKD(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E273B0", Offset = "0x7E263B0", VA = "0x187E273B0", Slot = "8")]
	public void HFFOHFJMOJL(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E26B50", Offset = "0x7E25B50", VA = "0x187E26B50", Slot = "9")]
	public void FNJGGHLLPOG(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E27490", Offset = "0x7E26490", VA = "0x187E27490", Slot = "10")]
	public void IOJJKCOJGEJ(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E26BB0", Offset = "0x7E25BB0", VA = "0x187E26BB0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FPHGPOJJHCC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NEPNELAGOIE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct POGMOCBNJCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct MCBMKBMKFHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NMDMPHKHONK : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HNGPMGMDPEH IBBGALOBEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E28220", Offset = "0x7E27220", VA = "0x187E28220", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E281B0", Offset = "0x7E271B0", VA = "0x187E281B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public NMDMPHKHONK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct DBPGNNCDKNJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NCCENBGIEMA AKIAHPJFIKE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static DBPGNNCDKNJ OIFHDJNIHDL(NCCENBGIEMA BOJCEMEJOMP)
	{
		return default(DBPGNNCDKNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AFEJAEFHGJP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HIOINALINKM OINKOPKLOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D780", Offset = "0x7E0C780", VA = "0x187E0D780", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AFEJAEFHGJP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct DFENCIMKCIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct MNJNHNCLCBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CNEDHOBLNKD BJLLGAEFDHM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static MNJNHNCLCBK OIFHDJNIHDL(CNEDHOBLNKD BOJCEMEJOMP)
	{
		return default(MNJNHNCLCBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct ALNCFMEOCDC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NCCENBGIEMA AKIAHPJFIKE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static ALNCFMEOCDC OIFHDJNIHDL(NCCENBGIEMA BOJCEMEJOMP)
	{
		return default(ALNCFMEOCDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KOENLFGEGLC : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HFIDGLOEBHF NNIKMMLLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E23780", Offset = "0x7E22780", VA = "0x187E23780", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E23710", Offset = "0x7E22710", VA = "0x187E23710", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KOENLFGEGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ODMGEGBJKDE : CAMPDBONJFN, HNGPMGMDPEH, ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IAMAGEBEBON OAOAECOFCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9F0", Offset = "0xCFB9F0", VA = "0x180CFC9F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(IAMAGEBEBON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KBLOIDENJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBE1E20", Offset = "0xBE0E20", VA = "0x180BE1E20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 HLKBEMIEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x10A2A90", Offset = "0x10A1A90", VA = "0x1810A2A90", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E285F0", Offset = "0x7E275F0", VA = "0x187E285F0")]
	public ODMGEGBJKDE(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC, float KPNAELOMDEE, float3 AILNDMFIKNH, IHNAGNCLKBF ILLMLCFLOGN, MNHJGJHOEHN KDBBAHCENGJ, IAMAGEBEBON ILGFPCICEOM, float3 BEFKOKAPEEE, bool FIFAAMJEEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E285A0", Offset = "0x7E275A0", VA = "0x187E285A0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DIGNEECJBOJ : CAMPDBONJFN, HFIDGLOEBHF, ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<KIKMAHKACEI> DHEBPGHLJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FAGHJIMEEPL PMLCGCAHNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float DPJOGBKFGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int EKPPINOMJIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JPDHAHGCJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E10800", Offset = "0x7E0F800", VA = "0x187E10800", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GAGKMEDIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E10820", Offset = "0x7E0F820", VA = "0x187E10820", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DCIOKLKOBML
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E10810", Offset = "0x7E0F810", VA = "0x187E10810", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LLAOOAMCPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD62EF0", Offset = "0xD61EF0", VA = "0x180D62EF0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float AFHEOEDEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC658A0", Offset = "0xC648A0", VA = "0x180C658A0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LMJOALMNJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF360F0", Offset = "0xF350F0", VA = "0x180F360F0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E10750", Offset = "0x7E0F750", VA = "0x187E10750")]
	public DIGNEECJBOJ(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC, float KPNAELOMDEE, float3 AILNDMFIKNH, IHNAGNCLKBF ILLMLCFLOGN, MNHJGJHOEHN KDBBAHCENGJ, FAGHJIMEEPL PMLCGCAHNGK, float DPJOGBKFGAG, int EKPPINOMJIF, NativeArray<KIKMAHKACEI> DHEBPGHLJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10BA2C0", Offset = "0x10B92C0", VA = "0x1810BA2C0", Slot = "33")]
	public NativeArray<KIKMAHKACEI> GetNativeCurvePoints()
	{
		return default(NativeArray<KIKMAHKACEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E10690", Offset = "0x7E0F690", VA = "0x187E10690", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LBLEEADODNO : LANKNMONCOL, HNGPMGMDPEH, ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<JMKKFNHDEDM, IAMAGEBEBON> JPMJLENBNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private IAMAGEBEBON ILGFPCICEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool FIFAAMJEEGO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IAMAGEBEBON OFEHOKPPGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750", Slot = "28")]
		get
		{
			return default(IAMAGEBEBON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool LCDPFINIHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xE164A0", Offset = "0xE154A0", VA = "0x180E164A0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 HLKBEMIEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E23E80", Offset = "0x7E22E80", VA = "0x187E23E80", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E23E60", Offset = "0x7E22E60", VA = "0x187E23E60")]
	public LBLEEADODNO(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E237D0", Offset = "0x7E227D0", VA = "0x187E237D0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E23820", Offset = "0x7E22820", VA = "0x187E23820", Slot = "26")]
	public override void IEKHBJGOAKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DENEOKOIILK : CJGNIPMMEKH, HIOINALINKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject OEHBKKELBPJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FB00", Offset = "0x7E0EB00", VA = "0x187E0FB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CIPJGNAKHIH IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FEA0", Offset = "0x7E0EEA0", VA = "0x187E0FEA0", Slot = "15")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AMAEECJNDGE LMDOBMIEGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E100F0", Offset = "0x7E0F0F0", VA = "0x187E100F0", Slot = "16")]
		get
		{
			return default(AMAEECJNDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FFA0", Offset = "0x7E0EFA0", VA = "0x187E0FFA0")]
	public DENEOKOIILK(PKENAFNLEAO GOGGPBKDKBC, bool KCPDFJIAIBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FD10", Offset = "0x7E0ED10", VA = "0x187E0FD10")]
	public void GNOPOGKMOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FEA0", Offset = "0x7E0EEA0", VA = "0x187E0FEA0")]
	protected CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FBC0", Offset = "0x7E0EBC0", VA = "0x187E0FBC0")]
	private static bool GDEJNPCBMON(PKENAFNLEAO DKBBAMEMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FB90", Offset = "0x7E0EB90", VA = "0x187E0FB90", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LJPNFGGNGFD : LANKNMONCOL, HFIDGLOEBHF, ONBMMNNCNDJ, IDisposable, BGHHFILJFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<KIKMAHKACEI> DHEBPGHLJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool FKPHBJJEDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool EFOHKOPBLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float DPJOGBKFGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int EKPPINOMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool LFHBLMMCIJK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool IHMCAEDDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC118F0", Offset = "0xC108F0", VA = "0x180C118F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MHLBLAHNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4C0", Offset = "0xA3B4C0", VA = "0x180A3C4C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float NMIFLKEGCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x10630A0", Offset = "0x10620A0", VA = "0x1810630A0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int KKCAPEGCIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9F0", Offset = "0xCFB9F0", VA = "0x180CFC9F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ALIOGDAMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBE1E20", Offset = "0xBE0E20", VA = "0x180BE1E20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PAPECFALFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E249D0", Offset = "0x7E239D0", VA = "0x187E249D0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int FLDCLBPNMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C80", Offset = "0x7E23C80", VA = "0x187E24C80", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E24E80", Offset = "0x7E23E80", VA = "0x187E24E80")]
	public LJPNFGGNGFD(PKENAFNLEAO FOCJCDLOOLD, [Optional] NativeList<KIKMAHKACEI> DHEBPGHLJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E24DA0", Offset = "0x7E23DA0", VA = "0x187E24DA0", Slot = "26")]
	public override void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E24870", Offset = "0x7E23870", VA = "0x187E24870", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E249F0", Offset = "0x7E239F0", VA = "0x187E249F0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E24A50", Offset = "0x7E23A50", VA = "0x187E24A50")]
	public void GNFJDLNJOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E24AB0", Offset = "0x7E23AB0", VA = "0x187E24AB0", Slot = "34")]
	public NativeArray<KIKMAHKACEI> GetNativeCurvePoints()
	{
		return default(NativeArray<KIKMAHKACEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E24580", Offset = "0x7E23580", VA = "0x187E24580", Slot = "35")]
	private Vector3 BHAHNACCAHE(int JDCGPDDDLBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E24D70", Offset = "0x7E23D70", VA = "0x187E24D70", Slot = "36")]
	private Quaternion HLMNKLDEEDL(int JDCGPDDDLBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E246D0", Offset = "0x7E236D0", VA = "0x187E246D0", Slot = "37")]
	private float CJNCDOHCGPF(int JDCGPDDDLBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E24960", Offset = "0x7E23960", VA = "0x187E24960")]
	private NativeArray<Entity> DBBJMABDPPN()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class LMLPGCAAHME : POHNNLEGCGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E24EB0", Offset = "0x7E23EB0", VA = "0x187E24EB0", Slot = "15")]
	protected override ComponentSystemBase IKALILJLACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E252D0", Offset = "0x7E242D0", VA = "0x187E252D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E252E0", Offset = "0x7E242E0", VA = "0x187E252E0")]
	public LMLPGCAAHME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[JJLECAACEFD]
public sealed class KMGELDGLHHI : FEMIGNDILNG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery KCLLILOIHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery KKFBGMIJCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery IBONOAAHADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery FJJCEMIMLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery CKAAALGCHBO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E22DA0", Offset = "0x7E21DA0", VA = "0x187E22DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E23100", Offset = "0x7E22100", VA = "0x187E23100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E225E0", Offset = "0x7E215E0", VA = "0x187E225E0")]
	private void AEHAPHMKGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E228C0", Offset = "0x7E218C0", VA = "0x187E228C0")]
	private void ICIIMMFGGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E229D0", Offset = "0x7E219D0", VA = "0x187E229D0")]
	private void JDEFLHFKPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E22BA0", Offset = "0x7E21BA0", VA = "0x187E22BA0")]
	private void JDHJBGGKPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E22CA0", Offset = "0x7E21CA0", VA = "0x187E22CA0")]
	private void NGLHKBBEBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E22870", Offset = "0x7E21870", VA = "0x187E22870")]
	private NativeList<Entity> GHCDABPODBG(NativeArray<Entity> ANKLKPHHPBD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E227C0", Offset = "0x7E217C0", VA = "0x187E227C0")]
	private NativeList<Entity> AKLEFKEMIGN(NativeArray<Entity> ANKLKPHHPBD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E22810", Offset = "0x7E21810", VA = "0x187E22810")]
	private void GEGMNFAHAEH(NativeArray<Entity> ANKLKPHHPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public KMGELDGLHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[JJLECAACEFD]
public sealed class KJNOBAMEINF : FEMIGNDILNG, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery BMGDAKIIFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery OCIFEMIIJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery NCBIHOAPELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KMODMBDLHLB JDHFODIDKHA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E22360", Offset = "0x7E21360", VA = "0x187E22360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E20FE0", Offset = "0x7E1FFE0", VA = "0x187E20FE0", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E22530", Offset = "0x7E21530", VA = "0x187E22530", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E20CC0", Offset = "0x7E1FCC0", VA = "0x187E20CC0")]
	private void BGODEAEFOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E210E0", Offset = "0x7E200E0", VA = "0x187E210E0")]
	private void LMOCPDLCHDI(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E21B20", Offset = "0x7E20B20", VA = "0x187E21B20")]
	private void NPPOBPBLGHH(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E21770", Offset = "0x7E20770", VA = "0x187E21770")]
	private void MMJFGHOMMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E21040", Offset = "0x7E20040", VA = "0x187E21040")]
	private bool LCPHNOCHIAI(Entity IOGPJKLGKKO, [Out] NCCENBGIEMA AKIAHPJFIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E221B0", Offset = "0x7E211B0", VA = "0x187E221B0")]
	private bool OEPBHIDDFHJ(Entity IOGPJKLGKKO, [Out] NCCENBGIEMA AKIAHPJFIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public KJNOBAMEINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[JJLECAACEFD]
public sealed class FHJAAFAOFCG : FEMIGNDILNG
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery OFNKBPCOKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery PJGNPNMAEGL;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E12EB0", Offset = "0x7E11EB0", VA = "0x187E12EB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E13000", Offset = "0x7E12000", VA = "0x187E13000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E128C0", Offset = "0x7E118C0", VA = "0x187E128C0")]
	private void LMOCPDLCHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E12BC0", Offset = "0x7E11BC0", VA = "0x187E12BC0")]
	private void NPPOBPBLGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public FHJAAFAOFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GHPMPOEMOAI : FEMIGNDILNG, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct PKBCDCPOLPA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob FNGBDILFOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob IPKKGLHCLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob CDIJPHMACDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob AOMNEPHBDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle CPEFKPIFNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<ALNCFMEOCDC> BDOOMGKNKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> MBNCJEKPNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> OGCAGMCCMGH;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E28BE0", Offset = "0x7E27BE0", VA = "0x187E28BE0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E28B00", Offset = "0x7E27B00", VA = "0x187E28B00")]
		private void CFJNFJEMFOH(EntityQueryInJob CEKOLPDIMMA, NativeList<Entity> OEPGDJEEHJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct EGBIJCLGIBK : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle CPEFKPIFNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<ALNCFMEOCDC> BDOOMGKNKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> OEPGDJEEHJA;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E12670", Offset = "0x7E11670", VA = "0x187E12670", Slot = "4")]
		public void Execute(ArchetypeChunk PBEJOLGEOKI, int NLOIJHKANCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct PEEKBKJBAIO : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle CPEFKPIFNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> PDDGGAMCMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<MNJNHNCLCBK> HNPDHLGMPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<DBPGNNCDKNJ> GJOJANOIDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<ALNCFMEOCDC> MMMPCEFJOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> LLDHIAHGICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<MNJNHNCLCBK> IFAJNIKFDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<NCCENBGIEMA> MKHBNBABIJE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E28690", Offset = "0x7E27690", VA = "0x187E28690", Slot = "4")]
		public void Execute(ArchetypeChunk PBEJOLGEOKI, int NLOIJHKANCB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery FNGBDILFOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery IPKKGLHCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery CDIJPHMACDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery AOMNEPHBDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery GMPFJBPLDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery MCELDKJMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery BKANNFLOGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private KMODMBDLHLB GOODMEDAMLI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E14330", Offset = "0x7E13330", VA = "0x187E14330", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E13E90", Offset = "0x7E12E90", VA = "0x187E13E90", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E148B0", Offset = "0x7E138B0", VA = "0x187E148B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E130B0", Offset = "0x7E120B0", VA = "0x187E130B0")]
	private void BFFPPDKPLCM(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int JPJBMLODKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E136B0", Offset = "0x7E126B0", VA = "0x187E136B0")]
	private void IEHACMGHGPO(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int KOJJPNLIMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E13EF0", Offset = "0x7E12EF0", VA = "0x187E13EF0")]
	private void NEGCEGJMGGE(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int OKKFLJCLCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E13B00", Offset = "0x7E12B00", VA = "0x187E13B00")]
	private void ILPEJDPOOJM(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE, int JILJAICIBLN, int KOOPCPGBAEO, int DMFBHGMNFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E14C30", Offset = "0x7E13C30", VA = "0x187E14C30")]
	private void PAGHDHPGNAA(Entity CFCDEDGMIGI, CNEDHOBLNKD DCFJJKLNHFC, NCCENBGIEMA AKIAHPJFIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public GHPMPOEMOAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ANJILEHLLAP : FEMIGNDILNG
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery IACNMMIJLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery LCCLAAIELLN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D7F0", Offset = "0x7E0C7F0", VA = "0x187E0D7F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DA30", Offset = "0x7E0CA30", VA = "0x187E0DA30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public ANJILEHLLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class CGKAMEMNIBA : FEMIGNDILNG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct KDCFNPMANHB : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery BJFJJIFJGOM;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E8A0", Offset = "0x7E0D8A0", VA = "0x187E0E8A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E9E0", Offset = "0x7E0D9E0", VA = "0x187E0E9E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public CGKAMEMNIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JJLECAACEFD]
internal class NGMPJHILHJD : FEMIGNDILNG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class EFIHDBKHHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery HIBJEPEMHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery CIKNGLJODKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public BNOBEHECFAC FFKLOCMDIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType GOBFIHAIAJN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EFIHDBKHHJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void BNOBEHECFAC(NativeArray<CNEDHOBLNKD> BOJCEMEJOMP, LGCPEOGBNJG BJFHMAIIJIJ);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<EFIHDBKHHJO> HLBAMPAAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private IKIKHILFKDN ABEIHHFHADG;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E27890", Offset = "0x7E26890", VA = "0x187E27890", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E27A90", Offset = "0x7E26A90", VA = "0x187E27A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E27C20", Offset = "0x7E26C20", VA = "0x187E27C20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x398E170", Offset = "0x398D170", VA = "0x18398E170")]
	private void BHNMKGJLOJI<T>(BNOBEHECFAC FFKLOCMDIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E278F0", Offset = "0x7E268F0", VA = "0x187E278F0")]
	private static void ODPAFJLCLOC(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E276F0", Offset = "0x7E266F0", VA = "0x187E276F0")]
	private static void GFECADCKFHH(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E27550", Offset = "0x7E26550", VA = "0x187E27550")]
	private static void BFJINLMGHFK(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public NGMPJHILHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[JJLECAACEFD]
public sealed class DHHDIMCJCPM : FEMIGNDILNG
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery CEKOLPDIMMA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E10250", Offset = "0x7E0F250", VA = "0x187E10250", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ECOECGHAGBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS DKBHBFJBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData HDKAFAJCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public IAMAGEBEBON ILGFPCICEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 BEFKOKAPEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool FIFAAMJEEGO;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MGAHMEDEONJ(Lifetime.LoadInstance)]
public struct PNKOMHDLEOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity CHJMGPBPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> GJBCDGBBFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> CCMLIAHJMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<ECOECGHAGBF> PEFKGINFGPK;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E28C60", Offset = "0x7E27C60", VA = "0x187E28C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(IOOCNDFAALB), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class IOOCNDFAALB : PNPJOMLIBJD, MMMIGLKPHHG, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JKPKJHBJDDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly IOOCNDFAALB JHDAOHEONAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool BBAPCIDHEFH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x17930E0", Offset = "0x17920E0", VA = "0x1817930E0")]
		public JKPKJHBJDDC(IOOCNDFAALB JHDAOHEONAC, bool BBAPCIDHEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B3E0", Offset = "0x7E1A3E0", VA = "0x187E1B3E0")]
		public Queue<COCLDAGBPFI>.Enumerator OMLAPONJPHN()
		{
			return default(Queue<COCLDAGBPFI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B0A0", Offset = "0x7E1A0A0", VA = "0x187E1B0A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private JFDGJOPOGFB GEGFLIFOKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private HDMAKFGCIBL EJJGNOFLFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<KIKMAHKACEI>> CKEKEGONPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> CDLLLJJCBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<CNEDHOBLNKD> CGNEAHOPEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OMJCOENGGCG<COCLDAGBPFI> PMAJEONNKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OMJCOENGGCG<PNKOMHDLEOB> NMGJPDAIEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private OMJCOENGGCG<KPPDAPCBBDM> NCIHMKAFNLE;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A4A0", Offset = "0x7E194A0", VA = "0x187E1A4A0", Slot = "4")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E19E80", Offset = "0x7E18E80", VA = "0x187E19E80")]
	public void BAAPNMLMFKH(NativeList<KIKMAHKACEI> PENPBHIEGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A830", Offset = "0x7E19830", VA = "0x187E1A830")]
	public void MNGJDPJICCL(Entity JHDAOHEONAC, [In] IEALDBHBOML<GameObject> PGBPOJMDALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A1F0", Offset = "0x7E191F0", VA = "0x187E1A1F0")]
	public void ILOENNIKHCN(NativeList<CNEDHOBLNKD> LPJEPOMELAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E19FC0", Offset = "0x7E18FC0", VA = "0x187E19FC0")]
	public void FNJGGHLLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AA80", Offset = "0x7E19A80", VA = "0x187E1AA80")]
	public void PKHLKJKCOGD(GDHFOHFFOAJ PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A6A0", Offset = "0x7E196A0", VA = "0x187E1A6A0")]
	public JobHandle MBKMEPGGGBJ([In] COCLDAGBPFI NAAMEAFIHJI, JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A740", Offset = "0x7E19740", VA = "0x187E1A740")]
	public JobHandle MBKMEPGGGBJ([In] PNKOMHDLEOB NAAMEAFIHJI, JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7AFA710", Offset = "0x7AF9710", VA = "0x187AFA710")]
	public JKPKJHBJDDC DBKOKHIBPAC(bool BBAPCIDHEFH)
	{
		return default(JKPKJHBJDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E19E30", Offset = "0x7E18E30", VA = "0x187E19E30")]
	public ABDJBANPEOH<PNKOMHDLEOB> AOFGKGBKOEP()
	{
		return default(ABDJBANPEOH<PNKOMHDLEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A7E0", Offset = "0x7E197E0", VA = "0x187E1A7E0")]
	public ABDJBANPEOH<KPPDAPCBBDM> MKLEJGMHDKK()
	{
		return default(ABDJBANPEOH<KPPDAPCBBDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A280", Offset = "0x7E19280", VA = "0x187E1A280")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A9A0", Offset = "0x7E199A0", VA = "0x187E1A9A0", Slot = "5")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E19F50", Offset = "0x7E18F50", VA = "0x187E19F50", Slot = "6")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1151D80", Offset = "0x1150D80", VA = "0x181151D80", Slot = "7")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IOOCNDFAALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JPEMOHHKKKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS DKBHBFJBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData HDKAFAJCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public JCLGHPNFNJF PMLCGCAHNGK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MGAHMEDEONJ(Lifetime.LoadInstance)]
public struct COCLDAGBPFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity CHJMGPBPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> ANKLKPHHPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> GJBCDGBBFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> CCMLIAHJMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<EIOEEPICKHB> HAOEIICOBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<KIKMAHKACEI> PENPBHIEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<JPEMOHHKKKK> CBHIDCEFPED;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F8E0", Offset = "0x7E0E8E0", VA = "0x187E0F8E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F8F0", Offset = "0x7E0E8F0", VA = "0x187E0F8F0")]
	public void NNOHEEPCFHD(bool BBAPCIDHEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(DLMGCJDBDIJ), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class DLMGCJDBDIJ : EECMODLKMOH, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private IOOCNDFAALB HHIFCBFALJA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E10830", Offset = "0x7E0F830", VA = "0x187E10830", Slot = "4")]
	public void BAOPLEDIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E10850", Offset = "0x7E0F850", VA = "0x187E10850", Slot = "5")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x112CAB0", Offset = "0x112BAB0", VA = "0x18112CAB0", Slot = "6")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DLMGCJDBDIJ()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : FEMIGNDILNG, PNPJOMLIBJD
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
			public NativeParallelHashMap<int, IAMAGEBEBON> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<ECOECGHAGBF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7E14DE0", Offset = "0x7E13DE0", VA = "0x187E14DE0", Slot = "4")]
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
			public NativeArray<KIKMAHKACEI> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<EIOEEPICKHB> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<JPEMOHHKKKK> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7E15180", Offset = "0x7E14180", VA = "0x187E15180", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E0F9C0", Offset = "0x7E0E9C0", VA = "0x187E0F9C0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7E28CF0", Offset = "0x7E27CF0", VA = "0x187E28CF0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7E28D10", Offset = "0x7E27D10", VA = "0x187E28D10")]
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
				float3 BGHEOAPFAFP(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7E25330", Offset = "0x7E24330", VA = "0x187E25330", Slot = "5")]
				public float3 CBFAJIEGBGD(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7E252F0", Offset = "0x7E242F0", VA = "0x187E252F0", Slot = "4")]
				public float3 BGHEOAPFAFP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7E28270", Offset = "0x7E27270", VA = "0x187E28270", Slot = "4")]
				public float3 BGHEOAPFAFP(quaternion rotation)
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
			public NativeArray<EIOEEPICKHB> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<KIKMAHKACEI> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E16330", Offset = "0x7E15330", VA = "0x187E16330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E17D70", Offset = "0x7E16D70", VA = "0x187E17D70")]
			private void INHLIKKMKLH(NativeList<PointSrcData> srcData, NativeList<KIKMAHKACEI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E18C50", Offset = "0x7E17C50", VA = "0x187E18C50")]
			public static Vector3 LBNCOJMKIBF(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E162B0", Offset = "0x7E152B0", VA = "0x187E162B0")]
			public static quaternion EJAAPKKPHNK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7E15C40", Offset = "0x7E14C40", VA = "0x187E15C40")]
			private static quaternion DAMHMIADFII(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E160E0", Offset = "0x7E150E0", VA = "0x187E160E0")]
			private static float3 EDKDDLPCHDM(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E191E0", Offset = "0x7E181E0", VA = "0x187E191E0")]
			private static quaternion MNBCJGEMGGH(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7E15E70", Offset = "0x7E14E70", VA = "0x187E15E70")]
			private static KIKMAHKACEI EDICKOAMOOI(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3F067A0", Offset = "0x3F057A0", VA = "0x183F067A0")]
			private void GFHGDFKNAMN<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E16F60", Offset = "0x7E15F60", VA = "0x187E16F60")]
			private void IKOMNFJJKOD(NativeList<PointSrcData> sourcePoints, NativeList<KIKMAHKACEI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7E19060", Offset = "0x7E18060", VA = "0x187E19060")]
			public static float LEMJHLGKDNG(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E158A0", Offset = "0x7E148A0", VA = "0x187E158A0")]
			private static quaternion BFDBBHGIMCE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7E19600", Offset = "0x7E18600", VA = "0x187E19600")]
			private static KIKMAHKACEI PHECOKEOHIG(PointSrcData point)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E19720", Offset = "0x7E18720", VA = "0x187E19720")]
			private static KIKMAHKACEI PHECOKEOHIG(float3 pos, quaternion rot, float radius)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E16DF0", Offset = "0x7E15DF0", VA = "0x187E16DF0")]
			private static bool GDBMEKNMAGF(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E16E90", Offset = "0x7E15E90", VA = "0x187E16E90")]
			private static float3 HMAPANMOCCF(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E19450", Offset = "0x7E18450", VA = "0x187E19450")]
			public static float3 OLDOFFKFEFM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7E15A90", Offset = "0x7E14A90", VA = "0x187E15A90")]
			public static float3 CBFAJIEGBGD(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E16990", Offset = "0x7E15990", VA = "0x187E16990")]
			private static quaternion FEAFAKOJIGA(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E19270", Offset = "0x7E18270", VA = "0x187E19270")]
			private static float ODPOIEPEEGC(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7E2AB00", Offset = "0x7E29B00", VA = "0x187E2AB00")]
			private void DJHBHCKJCAF(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7E2ABE0", Offset = "0x7E29BE0", VA = "0x187E2ABE0", Slot = "4")]
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
			public NativeList<KIKMAHKACEI> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C730", Offset = "0x7E2B730", VA = "0x187E2C730")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C790", Offset = "0x7E2B790", VA = "0x187E2C790", Slot = "4")]
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
			public NativeList<KIKMAHKACEI> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C6D0", Offset = "0x7E2B6D0", VA = "0x187E2C6D0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C720", Offset = "0x7E2B720", VA = "0x187E2C720", Slot = "4")]
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
			public NativeList<ECOECGHAGBF> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7E154C0", Offset = "0x7E144C0", VA = "0x187E154C0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E15680", Offset = "0x7E14680", VA = "0x187E15680", Slot = "4")]
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
			public NativeList<EIOEEPICKHB> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<JPEMOHHKKKK> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7E15690", Offset = "0x7E14690", VA = "0x187E15690")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7E15890", Offset = "0x7E14890", VA = "0x187E15890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E2C2A0", Offset = "0x7E2B2A0", VA = "0x187E2C2A0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E2C6C0", Offset = "0x7E2B6C0", VA = "0x187E2C6C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly JBBHIJHGEPM log;

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
		private IKLDODHOHAH replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private JFDGJOPOGFB objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IOOCNDFAALB bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private BFDGFGIFNEO ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A560", Offset = "0x7E29560", VA = "0x187E2A560", Slot = "15")]
		public override void InitReferences(APJCDBKKFBB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BBB0", Offset = "0x7E2ABB0", VA = "0x187E2BBB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BCA0", Offset = "0x7E2ACA0", VA = "0x187E2BCA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BD00", Offset = "0x7E2AD00", VA = "0x187E2BD00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A720", Offset = "0x7E29720", VA = "0x187E2A720")]
		private JobHandle KFPPPGAHCCO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E28D60", Offset = "0x7E27D60", VA = "0x187E28D60")]
		private JobHandle CFPAKLKNHJM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E295F0", Offset = "0x7E285F0", VA = "0x187E295F0")]
		private JobHandle MOFGDBBOCAK(NativeArray<int> pointCount, NativeList<KIKMAHKACEI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AA60", Offset = "0x7E29A60", VA = "0x187E2AA60")]
		private JobHandle LKHAICEELHM(NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E29C70", Offset = "0x7E28C70", VA = "0x187E29C70")]
		private JobHandle HOPOGCCEBEH(EntityQuery query, NativeList<EIOEEPICKHB> splinePointRanges, NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A600", Offset = "0x7E29600", VA = "0x187E2A600")]
		private JobHandle JGEHMGAHFLC(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B480", Offset = "0x7E2A480", VA = "0x187E2B480")]
		private JobHandle OBKBINHPOKB(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E2ACD0", Offset = "0x7E29CD0", VA = "0x187E2ACD0")]
		private JobHandle NCEOINDJDLB(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<ECOECGHAGBF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B5A0", Offset = "0x7E2A5A0", VA = "0x187E2B5A0")]
		private JobHandle ODOLKHMJHOK(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<EIOEEPICKHB> splinePointRanges, [Out] NativeList<JPEMOHHKKKK> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E298F0", Offset = "0x7E288F0", VA = "0x187E298F0")]
		private JobHandle HFPDCAILJBH(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AF70", Offset = "0x7E29F70", VA = "0x187E2AF70")]
		private JobHandle NHOEPMIAOFE(EntityQuery query, NativeList<ECOECGHAGBF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E2A140", Offset = "0x7E29140", VA = "0x187E2A140")]
		private static NativeParallelHashMap<int, IAMAGEBEBON> IFDANLGDBBH()
		{
			return default(NativeParallelHashMap<int, IAMAGEBEBON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E2BE70", Offset = "0x7E2AE70", VA = "0x187E2BE70")]
		private JobHandle PJBCICDKDIP(EntityQuery query, NativeList<EIOEEPICKHB> splinePointRanges, NativeList<KIKMAHKACEI> splinePointData, NativeList<JPEMOHHKKKK> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E29510", Offset = "0x7E28510", VA = "0x187E29510")]
		private JobHandle CIONGDKJIOH(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E295F0", Offset = "0x7E285F0", VA = "0x187E295F0")]
		private JobHandle ECHGDMPFKAI(NativeArray<int> pointCount, NativeList<KIKMAHKACEI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E2AA60", Offset = "0x7E29A60", VA = "0x187E2AA60")]
		private JobHandle NNJPFKGEACE(NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E29420", Offset = "0x7E28420", VA = "0x187E29420")]
		private JobHandle CIAPCOGKDHE(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<ECOECGHAGBF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E297E0", Offset = "0x7E287E0", VA = "0x187E297E0")]
		private JobHandle GNKILJEDEHP(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<EIOEEPICKHB> ranges, NativeList<JPEMOHHKKKK> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E29690", Offset = "0x7E28690", VA = "0x187E29690")]
		private JobHandle EGOPHLAIEEM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E2B860", Offset = "0x7E2A860", VA = "0x187E2B860", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IGJFOPMKCHO : DPKKALIBIFL, PNPJOMLIBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private IOOCNDFAALB HHIFCBFALJA;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E19DC0", Offset = "0x7E18DC0", VA = "0x187E19DC0", Slot = "14")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E19E10", Offset = "0x7E18E10", VA = "0x187E19E10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29CDEA0", Offset = "0x29CCEA0", VA = "0x1829CDEA0")]
	public IGJFOPMKCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class KJMADNKCKJI : FEMIGNDILNG, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct IJCLBOJOIMP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager IPJDHIAOJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MFMNKKMDDKE<T> NJGJLJFIMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int OHHMJGCBCKD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x4C07D30", Offset = "0x4C06D30", VA = "0x184C07D30")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C08830", Offset = "0x4C07830", VA = "0x184C08830")]
		public IJCLBOJOIMP(EntityManager IPJDHIAOJKP, MFMNKKMDDKE<T> NJGJLJFIMHO, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x458A380", Offset = "0x4589380", VA = "0x18458A380")]
		public IJCLBOJOIMP<T> OMLAPONJPHN()
		{
			return default(IJCLBOJOIMP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4C08710", Offset = "0x4C07710", VA = "0x184C08710")]
		public bool PMIJGMMFNEI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly JBBHIJHGEPM AJDAAJHBPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HDMAKFGCIBL EJJGNOFLFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IOOCNDFAALB HHIFCBFALJA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E590", Offset = "0x7E1D590", VA = "0x187E1E590", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E560", Offset = "0x7E1D560", VA = "0x187E1E560")]
	public void IOJJKCOJGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F640", Offset = "0x7E1E640", VA = "0x187E1F640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C500", Offset = "0x7E1B500", VA = "0x187E1C500")]
	private void DHHODGPJFPI(KPPDAPCBBDM NAAMEAFIHJI, Mesh[] LHHLMCNOLOM, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x38ED320", Offset = "0x38EC320", VA = "0x1838ED320")]
	private IJCLBOJOIMP<T> LAOPKEAEBOL<T>(MFMNKKMDDKE<T> NJGJLJFIMHO, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE) where T : struct
	{
		return default(IJCLBOJOIMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DB80", Offset = "0x7E1CB80", VA = "0x187E1DB80")]
	private void DOBAEBFFEHI(Transform JHDAOHEONAC, NativeArray<KGHDDMDOCBC> GAEMLEENPDN, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C030", Offset = "0x7E1B030", VA = "0x187E1C030")]
	private void CGCGOLALHAN(Transform JHDAOHEONAC, NativeArray<KEKMGHNJNPO> PGHPKJEELKC, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E1F250", Offset = "0x7E1E250", VA = "0x187E1F250")]
	private void LGJCDIEAJDF(Transform JHDAOHEONAC, NativeArray<FMBEAEEPJCM> DBLPGHIOHAK, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E207C0", Offset = "0x7E1F7C0", VA = "0x187E207C0")]
	private void PGFGNDMAJBL(Transform JHDAOHEONAC, NativeArray<EGOCGIDCHJI> LHHLMCNOLOM, Mesh[] DJHMJMICALI, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DF20", Offset = "0x7E1CF20", VA = "0x187E1DF20")]
	private static void HDIGBHJALNE(NativeParallelHashSet<Entity> ANKLKPHHPBD, NativeParallelHashSet<Entity> FFJAGBNLABL, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E610", Offset = "0x7E1D610", VA = "0x187E1E610")]
	private static void JIBDKNOHPGC(NativeList<Entity> OLEDHEBBJPH, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E6D0", Offset = "0x7E1D6D0", VA = "0x187E1E6D0")]
	private NativeParallelHashMap<Entity, DBPGNNCDKNJ> LGHIAGEFOOI(IOOCNDFAALB.JKPKJHBJDDC EOJBNLJFECM, ABDJBANPEOH<PNKOMHDLEOB> BIFFDKIHALG, List<GameObject> PICKKAJKGOK)
	{
		return default(NativeParallelHashMap<Entity, DBPGNNCDKNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E460", Offset = "0x7E1D460", VA = "0x187E1E460")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HPFBMCJNKCI(Entity BFNLIBJABAF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D620", Offset = "0x7E1C620", VA = "0x187E1D620")]
	private void DIDBKEANHBM(NativeList<Entity> HECCIIHOGIG, NativeList<Entity> DNKIMJFNFAA, NativeParallelHashMap<Entity, DBPGNNCDKNJ> ACJBHICMLKM, NativeList<EIOEEPICKHB> DJENHNLGFNC, NativeList<KIKMAHKACEI> LIBIJPCBHPF, NativeList<JPEMOHHKKKK> CKEKEGONPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E070", Offset = "0x7E1D070", VA = "0x187E1E070")]
	private void HEEMJMMBIHO(NativeList<Entity> ANKLKPHHPBD, NativeList<Entity> GJBCDGBBFFE, NativeParallelHashMap<Entity, DBPGNNCDKNJ> ACJBHICMLKM, NativeList<ECOECGHAGBF> PEFKGINFGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFC0", Offset = "0x7E0CFC0", VA = "0x187E0DFC0")]
	public KJMADNKCKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class KIJOMJOLGHO : GIIODODJLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS DKBHBFJBCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly FHMOHIBLLDK JHDAOHEONAC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject FOOFIAMMBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS CGDDFJJFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BC30", Offset = "0x7E1AC30", VA = "0x187E1BC30", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 PPPKJDCLMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEA0", Offset = "0x7E1AEA0", VA = "0x187E1BEA0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 HJIMMFEKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF90", Offset = "0x7E1AF90", VA = "0x187E1BF90", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 JFKFHNOHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEF0", Offset = "0x7E1AEF0", VA = "0x187E1BEF0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BE50", Offset = "0x7E1AE50", VA = "0x187E1BE50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion HAHIEBCKGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF40", Offset = "0x7E1AF40", VA = "0x187E1BF40", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD10", Offset = "0x7E1AD10", VA = "0x187E1BD10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 NFJLCFBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BD60", Offset = "0x7E1AD60", VA = "0x187E1BD60", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 AFLLECOEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BE00", Offset = "0x7E1AE00", VA = "0x187E1BE00", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 JHDDOLOMFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BDB0", Offset = "0x7E1ADB0", VA = "0x187E1BDB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BFE0", Offset = "0x7E1AFE0", VA = "0x187E1BFE0")]
	public KIJOMJOLGHO(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class CAMPDBONJFN : KIJOMJOLGHO, ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float KPNAELOMDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 AILNDMFIKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly IHNAGNCLKBF ILLMLCFLOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MNHJGJHOEHN KDBBAHCENGJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private CIPJGNAKHIH KLMNFCPAIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E7D0", Offset = "0x7E0D7D0", VA = "0x187E0E7D0", Slot = "17")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS JCPJNMOCNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E6F0", Offset = "0x7E0D6F0", VA = "0x187E0E6F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float CJJIAOIEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBFBD40", Offset = "0xBFAD40", VA = "0x180BFBD40", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 MMECBKAEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E6A0", Offset = "0x7E0D6A0", VA = "0x187E0E6A0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IHNAGNCLKBF HHJMFCOIPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE31160", Offset = "0xE30160", VA = "0x180E31160", Slot = "21")]
		get
		{
			return default(IHNAGNCLKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MNHJGJHOEHN HABJDCBKHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1356C00", Offset = "0x1355C00", VA = "0x181356C00", Slot = "22")]
		get
		{
			return default(MNHJGJHOEHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool HMEMCGOGMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NDPNAFDPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E820", Offset = "0x7E0D820", VA = "0x187E0E820")]
	protected CAMPDBONJFN(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC, float KPNAELOMDEE, float3 AILNDMFIKNH, IHNAGNCLKBF ILLMLCFLOGN, MNHJGJHOEHN KDBBAHCENGJ)
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
public abstract class CJGNIPMMEKH : GIIODODJLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly PKENAFNLEAO DCOBGODCAEM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected FHMOHIBLLDK LAAONLPPGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1133990", Offset = "0x1132990", VA = "0x181133990")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EE20", Offset = "0x7E0DE20", VA = "0x187E0EE20")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EE10", Offset = "0x7E0DE10", VA = "0x187E0EE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EE40", Offset = "0x7E0DE40", VA = "0x187E0EE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected JHOFBNJCHGN JAGKPLKJHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F250", Offset = "0x7E0E250", VA = "0x187E0F250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject FOOFIAMMBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F060", Offset = "0x7E0E060", VA = "0x187E0F060", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS CGDDFJJFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1155A30", Offset = "0x1154A30", VA = "0x181155A30", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 PPPKJDCLMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F3F0", Offset = "0x7E0E3F0", VA = "0x187E0F3F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 HJIMMFEKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F760", Offset = "0x7E0E760", VA = "0x187E0F760", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 JFKFHNOHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F4E0", Offset = "0x7E0E4E0", VA = "0x187E0F4E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F2E0", Offset = "0x7E0E2E0", VA = "0x187E0F2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion HAHIEBCKGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F610", Offset = "0x7E0E610", VA = "0x187E0F610", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EC10", Offset = "0x7E0DC10", VA = "0x187E0EC10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 NFJLCFBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0ED20", Offset = "0x7E0DD20", VA = "0x187E0ED20", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 AFLLECOEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F090", Offset = "0x7E0E090", VA = "0x187E0F090", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 JHDDOLOMFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7E0EEA0", Offset = "0x7E0DEA0", VA = "0x187E0EEA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xDDA6F0", Offset = "0xDD96F0", VA = "0x180DDA6F0")]
	protected CJGNIPMMEKH(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F730", Offset = "0x7E0E730", VA = "0x187E0F730")]
	public static CIPJGNAKHIH OIFHDJNIHDL(CJGNIPMMEKH LEMBKBGMCDG)
	{
		return default(CIPJGNAKHIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JAFIAIEKCDF
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DEB0", Offset = "0x7E2CEB0", VA = "0x187E2DEB0")]
	public static void KOKBOIJJGBJ(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CMOAPPNFIKP
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D4C0", Offset = "0x7E2C4C0", VA = "0x187E2D4C0")]
	public static void CKGOFKPFLNH(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP, GDHFOHFFOAJ CLLBJKEEKKA, JFDGJOPOGFB GGBPNJIDLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D910", Offset = "0x7E2C910", VA = "0x187E2D910")]
	public static void MBPMFBBIJNN(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP, GDHFOHFFOAJ CLLBJKEEKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D220", Offset = "0x7E2C220", VA = "0x187E2D220")]
	public static NativeList<Entity> AKLEFKEMIGN(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D8D0", Offset = "0x7E2C8D0", VA = "0x187E2D8D0")]
	public static NativeList<Entity> GHCDABPODBG(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7E2D260", Offset = "0x7E2C260", VA = "0x187E2D260")]
	private static NativeList<Entity> AKLEFKEMIGN(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP, bool KDMEKEJFBAB)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class LANKNMONCOL : CJGNIPMMEKH, ONBMMNNCNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float KPNAELOMDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 AILNDMFIKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private IHNAGNCLKBF ILLMLCFLOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MNHJGJHOEHN KDBBAHCENGJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager EGDKMGEFJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E0F0", Offset = "0x7E2D0F0", VA = "0x187E2E0F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DIDIFHNCLFN PPJOFODMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E430", Offset = "0x7E2D430", VA = "0x187E2E430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData IMGNFHIGEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E340", Offset = "0x7E2D340", VA = "0x187E2E340")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private CIPJGNAKHIH KLMNFCPAIML
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F730", Offset = "0x7E0E730", VA = "0x187E0F730", Slot = "17")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float CJJIAOIEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xECEA30", Offset = "0xECDA30", VA = "0x180ECEA30", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 MMECBKAEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x15DE770", Offset = "0x15DD770", VA = "0x1815DE770", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private IHNAGNCLKBF HHJMFCOIPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90", Slot = "21")]
		get
		{
			return default(IHNAGNCLKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private MNHJGJHOEHN HABJDCBKHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430", Slot = "22")]
		get
		{
			return default(MNHJGJHOEHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS JCPJNMOCNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E310", Offset = "0x7E2D310", VA = "0x187E2E310", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NDPNAFDPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool HMEMCGOGMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E490", Offset = "0x7E2D490", VA = "0x187E2E490")]
	protected LANKNMONCOL(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E180", Offset = "0x7E2D180", VA = "0x187E2E180", Slot = "26")]
	public virtual void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class FEMIGNDILNG : DPKKALIBIFL, PNPJOMLIBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected JFDGJOPOGFB GGBPNJIDLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private FKMDIIGFMOG JDPKJPILGNF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected GDHFOHFFOAJ EJHJKDKNCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DD90", Offset = "0x7E2CD90", VA = "0x187E2DD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected LGCPEOGBNJG NPOIHCKJNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DD40", Offset = "0x7E2CD40", VA = "0x187E2DD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool HBIECGDNFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7E2DC80", Offset = "0x7E2CC80", VA = "0x187E2DC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DDE0", Offset = "0x7E2CDE0", VA = "0x187E2DDE0", Slot = "15")]
	public virtual void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x29CDEA0", Offset = "0x29CCEA0", VA = "0x1829CDEA0")]
	protected FEMIGNDILNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class NJOFIIKANJO
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E520", Offset = "0x7E2D520", VA = "0x187E2E520")]
	public static void CKBKAPMKPKN(NativeArray<Entity> HECCIIHOGIG, EntityManager IPJDHIAOJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2663542189
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E930", Offset = "0x7E2D930", VA = "0x187E2E930")]
	public static void PCDGKKDKHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E920", Offset = "0x7E2D920", VA = "0x187E2E920")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NCIMHMKJNMC : ContainerPropertyBag<NMDMPHKHONK>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2E4C0", Offset = "0x7E2D4C0", VA = "0x187E2E4C0")]
	public NCIMHMKJNMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class CNHFJMIAGHM : ContainerPropertyBag<AFEJAEFHGJP>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DC20", Offset = "0x7E2CC20", VA = "0x187E2DC20")]
	public CNHFJMIAGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class IJMLFDAIOPB : ContainerPropertyBag<KOENLFGEGLC>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7E2DE50", Offset = "0x7E2CE50", VA = "0x187E2DE50")]
	public IJMLFDAIOPB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7E2E760", Offset = "0x7E2D760", VA = "0x187E2E760")]
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
