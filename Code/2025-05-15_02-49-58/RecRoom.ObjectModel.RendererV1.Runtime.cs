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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E15820", Offset = "0x7E13E20", VA = "0x187E15820", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2064230", Offset = "0x2062830", VA = "0x182064230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CC00", Offset = "0x7E1B200", VA = "0x187E1CC00")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D1A0", Offset = "0x7E1B7A0", VA = "0x187E1D1A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D200", Offset = "0x7E1B800", VA = "0x187E1D200")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JJHAEPJDCMN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B1F0", Offset = "0x7E097F0", VA = "0x187E0B1F0")]
	public static Quaternion JEGADKNNKFO([In] this LKMBOJBJICB HMFCGNLLBJA, [In] Vector3 IGEMMIGMOOK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EBBGDLCCOFC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E00B50", Offset = "0x7DFF150", VA = "0x187E00B50")]
	public static bool BAIDJDIDMKI(this FENODIDCBGH FKFPDEAIGAP, CMOLENMEPKL CPNOKLLGBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E01320", Offset = "0x7DFF920", VA = "0x187E01320")]
	public static bool JAHOGAAEOAD(this FENODIDCBGH FKFPDEAIGAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E01AC0", Offset = "0x7E000C0", VA = "0x187E01AC0")]
	public static bool NHIBGHBMDHK(this FENODIDCBGH FKFPDEAIGAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E00BC0", Offset = "0x7DFF1C0", VA = "0x187E00BC0")]
	public static void CHBNGLMEHPM(this FENODIDCBGH FKFPDEAIGAP, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E01350", Offset = "0x7DFF950", VA = "0x187E01350")]
	public static void KCCGGHDIMPK(this FENODIDCBGH FKFPDEAIGAP, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN, int BCHDDCOGALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E01020", Offset = "0x7DFF620", VA = "0x187E01020")]
	public static void EOMHKMPMPLE(this FENODIDCBGH FKFPDEAIGAP, int BCHDDCOGALL, Vector3 PPMCFFDAOMB, Quaternion NIKLGDEBMLK, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E01CA0", Offset = "0x7E002A0", VA = "0x187E01CA0")]
	public static void NKMELCLJJML(this FENODIDCBGH FKFPDEAIGAP, Vector3 OJNINNGHJKK, Quaternion BCOJNGHILBJ, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E01CF0", Offset = "0x7E002F0", VA = "0x187E01CF0")]
	private static void OGKMLKGNMCN(this FENODIDCBGH FKFPDEAIGAP, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E01AF0", Offset = "0x7E000F0", VA = "0x187E01AF0")]
	private static void NINMPEBBHKB(this FENODIDCBGH FKFPDEAIGAP, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E01140", Offset = "0x7DFF740", VA = "0x187E01140")]
	private static void GKAJKCFJOFA(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E00B90", Offset = "0x7DFF190", VA = "0x187E00B90")]
	private static bool BBFACCFMDMJ(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E02640", Offset = "0x7E00C40", VA = "0x187E02640")]
	private static void PDJHDIOGKGN(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD, Vector3 IHMLAPGNLCC, Quaternion JHMNNKLOODA, float JHNELCICLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E015D0", Offset = "0x7DFFBD0", VA = "0x187E015D0")]
	public static Vector3 MJINHKCHCED(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E00F10", Offset = "0x7DFF510", VA = "0x187E00F10")]
	public static Quaternion DPKEIPKDLIL(this FENODIDCBGH FKFPDEAIGAP, int OHHMJGCBCKD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E00CF0", Offset = "0x7DFF2F0", VA = "0x187E00CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E0BC50", Offset = "0x7E0A250", VA = "0x187E0BC50", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
	public BLLBFFNAKBE(LIPCMCBNFNH HBODJJIPFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE810", Offset = "0x7DFCE10", VA = "0x187DFE810", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PIMEODKKKKC : JJKIDMLKOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E18AD0", Offset = "0x7E170D0", VA = "0x187E18AD0", Slot = "4")]
	public void NFMCGACGBBP(EntityQuery CEKOLPDIMMA, EntityManager IPJDHIAOJKP, FKMDIIGFMOG JDPKJPILGNF, CLFFFENGNKK PFOPIPGPNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E0B6D0", Offset = "0x7E09CD0", VA = "0x187E0B6D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B9D0", Offset = "0x7E09FD0", VA = "0x187E0B9D0", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B700", Offset = "0x7E09D00", VA = "0x187E0B700", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B980", Offset = "0x7E09F80", VA = "0x187E0B980", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E09A90", Offset = "0x7E08090", VA = "0x187E09A90", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E09D90", Offset = "0x7E08390", VA = "0x187E09D90", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E09AC0", Offset = "0x7E080C0", VA = "0x187E09AC0", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E09D40", Offset = "0x7E08340", VA = "0x187E09D40", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFE290", Offset = "0x7DFC890", VA = "0x187DFE290", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE590", Offset = "0x7DFCB90", VA = "0x187DFE590", Slot = "5")]
	public void KHILONCNOFM(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE2C0", Offset = "0x7DFC8C0", VA = "0x187DFE2C0", Slot = "6")]
	public void DFBIOJPABOH(EntityQuery CEKOLPDIMMA, LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE540", Offset = "0x7DFCB40", VA = "0x187DFE540", Slot = "7")]
	public void DMIFOKJLNJE(LGCPEOGBNJG BJFHMAIIJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E14240", Offset = "0x7E12840", VA = "0x187E14240", Slot = "15")]
	public virtual void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E142D0", Offset = "0x7E128D0", VA = "0x187E142D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E140D0", Offset = "0x7E126D0", VA = "0x187E140D0")]
	private void BHNMKGJLOJI(EntityQueryDesc BNOFDCLPOBM, JJKIDMLKOGH ICEHFBCKOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E14500", Offset = "0x7E12B00", VA = "0x187E14500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E16730", Offset = "0x7E14D30", VA = "0x187E16730", Slot = "14")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E167C0", Offset = "0x7E14DC0", VA = "0x187E167C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E16940", Offset = "0x7E14F40", VA = "0x187E16940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E162E0", Offset = "0x7E148E0", VA = "0x187E162E0")]
	private void IILCCPKCOOM(FADECFIJCJL HBOHOPEJPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E15BA0", Offset = "0x7E141A0", VA = "0x187E15BA0")]
	private void BHNMKGJLOJI(JOCBLPDAFOI CDLDHDFACLF, ComponentType NPFIDHBDODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KIOOHKBHOLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E133F0", Offset = "0x7E119F0", VA = "0x187E133F0", Slot = "4")]
	public bool EGNNGPHJIGO(PKENAFNLEAO GOGGPBKDKBC, NBDNAFKNLDM OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E135E0", Offset = "0x7E11BE0", VA = "0x187E135E0", Slot = "5")]
	public NCCENBGIEMA OBHCPINIMHB()
	{
		return default(NCCENBGIEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E134D0", Offset = "0x7E11AD0", VA = "0x187E134D0", Slot = "6")]
	public void HGMPKJGBHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E13360", Offset = "0x7E11960", VA = "0x187E13360", Slot = "7")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11676F0", Offset = "0x1165CF0", VA = "0x1811676F0", Slot = "8")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KOBNALENICG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(KHALAAIOGCO), new string[] { })]
public class NEPNELAGOIE : KHALAAIOGCO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E17540", Offset = "0x7E15B40", VA = "0x187E17540", Slot = "4")]
	public void HGDPAKOJAAA(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E17630", Offset = "0x7E15C30", VA = "0x187E17630", Slot = "5")]
	public void OCJMJKHCBJB(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E16C30", Offset = "0x7E15230", VA = "0x187E16C30", Slot = "6")]
	public ComponentSystemBase ENGFLLCFLCP(World JEOJCJGMOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E16BD0", Offset = "0x7E151D0", VA = "0x187E16BD0", Slot = "7")]
	public void CNDJHACJOKD(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E174E0", Offset = "0x7E15AE0", VA = "0x187E174E0", Slot = "8")]
	public void HFFOHFJMOJL(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E16C80", Offset = "0x7E15280", VA = "0x187E16C80", Slot = "9")]
	public void FNJGGHLLPOG(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E175C0", Offset = "0x7E15BC0", VA = "0x187E175C0", Slot = "10")]
	public void IOJJKCOJGEJ(World JEOJCJGMOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E16CE0", Offset = "0x7E152E0", VA = "0x187E16CE0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FPHGPOJJHCC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E18340", Offset = "0x7E16940", VA = "0x187E18340", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E182D0", Offset = "0x7E168D0", VA = "0x187E182D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDA60", Offset = "0x7DFC060", VA = "0x187DFDA60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
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
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E13910", Offset = "0x7E11F10", VA = "0x187E13910", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E138A0", Offset = "0x7E11EA0", VA = "0x187E138A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD2BF70", Offset = "0xD2A570", VA = "0x180D2BF70", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC089E0", VA = "0x180C0A3E0", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0x10B6760", Offset = "0x10B4D60", VA = "0x1810B6760", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E18700", Offset = "0x7E16D00", VA = "0x187E18700")]
	public ODMGEGBJKDE(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC, float KPNAELOMDEE, float3 AILNDMFIKNH, IHNAGNCLKBF ILLMLCFLOGN, MNHJGJHOEHN KDBBAHCENGJ, IAMAGEBEBON ILGFPCICEOM, float3 BEFKOKAPEEE, bool FIFAAMJEEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E186B0", Offset = "0x7E16CB0", VA = "0x187E186B0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E00AB0", Offset = "0x7DFF0B0", VA = "0x187E00AB0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GAGKMEDIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E00AD0", Offset = "0x7DFF0D0", VA = "0x187E00AD0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DCIOKLKOBML
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E00AC0", Offset = "0x7DFF0C0", VA = "0x187E00AC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int LLAOOAMCPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float AFHEOEDEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC905F0", Offset = "0xC8EBF0", VA = "0x180C905F0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LMJOALMNJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF476A0", Offset = "0xF45CA0", VA = "0x180F476A0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E00A00", Offset = "0x7DFF000", VA = "0x187E00A00")]
	public DIGNEECJBOJ(UniformTRS DKBHBFJBCKF, FHMOHIBLLDK JHDAOHEONAC, float KPNAELOMDEE, float3 AILNDMFIKNH, IHNAGNCLKBF ILLMLCFLOGN, MNHJGJHOEHN KDBBAHCENGJ, FAGHJIMEEPL PMLCGCAHNGK, float DPJOGBKFGAG, int EKPPINOMJIF, NativeArray<KIKMAHKACEI> DHEBPGHLJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10CDF30", Offset = "0x10CC530", VA = "0x1810CDF30", Slot = "33")]
	public NativeArray<KIKMAHKACEI> GetNativeCurvePoints()
	{
		return default(NativeArray<KIKMAHKACEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E00940", Offset = "0x7DFEF40", VA = "0x187E00940", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0", Slot = "28")]
		get
		{
			return default(IAMAGEBEBON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool LCDPFINIHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xE28200", Offset = "0xE26800", VA = "0x180E28200", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 HLKBEMIEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E14000", Offset = "0x7E12600", VA = "0x187E14000", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E13FE0", Offset = "0x7E125E0", VA = "0x187E13FE0")]
	public LBLEEADODNO(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E13960", Offset = "0x7E11F60", VA = "0x187E13960", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E139B0", Offset = "0x7E11FB0", VA = "0x187E139B0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFFDC0", Offset = "0x7DFE3C0", VA = "0x187DFFDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CIPJGNAKHIH IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E00160", Offset = "0x7DFE760", VA = "0x187E00160", Slot = "15")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AMAEECJNDGE LMDOBMIEGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E003B0", Offset = "0x7DFE9B0", VA = "0x187E003B0", Slot = "16")]
		get
		{
			return default(AMAEECJNDGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E00260", Offset = "0x7DFE860", VA = "0x187E00260")]
	public DENEOKOIILK(PKENAFNLEAO GOGGPBKDKBC, bool KCPDFJIAIBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFFD0", Offset = "0x7DFE5D0", VA = "0x187DFFFD0")]
	public void GNOPOGKMOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E00160", Offset = "0x7DFE760", VA = "0x187E00160")]
	protected CIPJGNAKHIH LAOJGEPMLKG()
	{
		return default(CIPJGNAKHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFE80", Offset = "0x7DFE480", VA = "0x187DFFE80")]
	private static bool GDEJNPCBMON(PKENAFNLEAO DKBBAMEMKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFE50", Offset = "0x7DFE450", VA = "0x187DFFE50", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xC177F0", Offset = "0xC15DF0", VA = "0x180C177F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MHLBLAHNPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA36A10", Offset = "0xA35010", VA = "0x180A36A10", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float NMIFLKEGCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1076300", Offset = "0x1074900", VA = "0x181076300", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int KKCAPEGCIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF70", Offset = "0xD2A570", VA = "0x180D2BF70", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ALIOGDAMKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC089E0", VA = "0x180C0A3E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PAPECFALFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E14B30", Offset = "0x7E13130", VA = "0x187E14B30", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int FLDCLBPNMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E14DE0", Offset = "0x7E133E0", VA = "0x187E14DE0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E14FE0", Offset = "0x7E135E0", VA = "0x187E14FE0")]
	public LJPNFGGNGFD(PKENAFNLEAO FOCJCDLOOLD, [Optional] NativeList<KIKMAHKACEI> DHEBPGHLJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E14F00", Offset = "0x7E13500", VA = "0x187E14F00", Slot = "26")]
	public override void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E149D0", Offset = "0x7E12FD0", VA = "0x187E149D0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E14B50", Offset = "0x7E13150", VA = "0x187E14B50", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E14BB0", Offset = "0x7E131B0", VA = "0x187E14BB0")]
	public void GNFJDLNJOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E14C10", Offset = "0x7E13210", VA = "0x187E14C10", Slot = "34")]
	public NativeArray<KIKMAHKACEI> GetNativeCurvePoints()
	{
		return default(NativeArray<KIKMAHKACEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E146F0", Offset = "0x7E12CF0", VA = "0x187E146F0", Slot = "35")]
	private Vector3 BHAHNACCAHE(int JDCGPDDDLBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E14ED0", Offset = "0x7E134D0", VA = "0x187E14ED0", Slot = "36")]
	private Quaternion HLMNKLDEEDL(int JDCGPDDDLBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E14840", Offset = "0x7E12E40", VA = "0x187E14840", Slot = "37")]
	private float CJNCDOHCGPF(int JDCGPDDDLBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E14AC0", Offset = "0x7E130C0", VA = "0x187E14AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E15010", Offset = "0x7E13610", VA = "0x187E15010", Slot = "15")]
	protected override ComponentSystemBase IKALILJLACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E15420", Offset = "0x7E13A20", VA = "0x187E15420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E15430", Offset = "0x7E13A30", VA = "0x187E15430")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E12F40", Offset = "0x7E11540", VA = "0x187E12F40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E132A0", Offset = "0x7E118A0", VA = "0x187E132A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E12780", Offset = "0x7E10D80", VA = "0x187E12780")]
	private void AEHAPHMKGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E12A60", Offset = "0x7E11060", VA = "0x187E12A60")]
	private void ICIIMMFGGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E12B70", Offset = "0x7E11170", VA = "0x187E12B70")]
	private void JDEFLHFKPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D40", Offset = "0x7E11340", VA = "0x187E12D40")]
	private void JDHJBGGKPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E12E40", Offset = "0x7E11440", VA = "0x187E12E40")]
	private void NGLHKBBEBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E12A10", Offset = "0x7E11010", VA = "0x187E12A10")]
	private NativeList<Entity> GHCDABPODBG(NativeArray<Entity> ANKLKPHHPBD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E12960", Offset = "0x7E10F60", VA = "0x187E12960")]
	private NativeList<Entity> AKLEFKEMIGN(NativeArray<Entity> ANKLKPHHPBD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E129B0", Offset = "0x7E10FB0", VA = "0x187E129B0")]
	private void GEGMNFAHAEH(NativeArray<Entity> ANKLKPHHPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E12510", Offset = "0x7E10B10", VA = "0x187E12510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E11190", Offset = "0x7E0F790", VA = "0x187E11190", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E126E0", Offset = "0x7E10CE0", VA = "0x187E126E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E10E70", Offset = "0x7E0F470", VA = "0x187E10E70")]
	private void BGODEAEFOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E11290", Offset = "0x7E0F890", VA = "0x187E11290")]
	private void LMOCPDLCHDI(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E11CD0", Offset = "0x7E102D0", VA = "0x187E11CD0")]
	private void NPPOBPBLGHH(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E11920", Offset = "0x7E0FF20", VA = "0x187E11920")]
	private void MMJFGHOMMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E111F0", Offset = "0x7E0F7F0", VA = "0x187E111F0")]
	private bool LCPHNOCHIAI(Entity IOGPJKLGKKO, [Out] NCCENBGIEMA AKIAHPJFIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E12360", Offset = "0x7E10960", VA = "0x187E12360")]
	private bool OEPBHIDDFHJ(Entity IOGPJKLGKKO, [Out] NCCENBGIEMA AKIAHPJFIKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E03110", Offset = "0x7E01710", VA = "0x187E03110", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E03260", Offset = "0x7E01860", VA = "0x187E03260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E02B20", Offset = "0x7E01120", VA = "0x187E02B20")]
	private void LMOCPDLCHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E02E20", Offset = "0x7E01420", VA = "0x187E02E20")]
	private void NPPOBPBLGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E18CF0", Offset = "0x7E172F0", VA = "0x187E18CF0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E18C10", Offset = "0x7E17210", VA = "0x187E18C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E028D0", Offset = "0x7E00ED0", VA = "0x187E028D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E187A0", Offset = "0x7E16DA0", VA = "0x187E187A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E04580", Offset = "0x7E02B80", VA = "0x187E04580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E040E0", Offset = "0x7E026E0", VA = "0x187E040E0", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E04B00", Offset = "0x7E03100", VA = "0x187E04B00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E03300", Offset = "0x7E01900", VA = "0x187E03300")]
	private void BFFPPDKPLCM(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int JPJBMLODKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E03900", Offset = "0x7E01F00", VA = "0x187E03900")]
	private void IEHACMGHGPO(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int KOJJPNLIMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E04140", Offset = "0x7E02740", VA = "0x187E04140")]
	private void NEGCEGJMGGE(NativeParallelHashSet<NCCENBGIEMA> OJLLNICLHMN, int OKKFLJCLCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E03D50", Offset = "0x7E02350", VA = "0x187E03D50")]
	private void ILPEJDPOOJM(NativeParallelHashSet<NCCENBGIEMA> AKMKIMOBPHE, int JILJAICIBLN, int KOOPCPGBAEO, int DMFBHGMNFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E04E80", Offset = "0x7E03480", VA = "0x187E04E80")]
	private void PAGHDHPGNAA(Entity CFCDEDGMIGI, CNEDHOBLNKD DCFJJKLNHFC, NCCENBGIEMA AKIAHPJFIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DFDAD0", Offset = "0x7DFC0D0", VA = "0x187DFDAD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD00", Offset = "0x7DFC300", VA = "0x187DFDD00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DFEB60", Offset = "0x7DFD160", VA = "0x187DFEB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DFECA0", Offset = "0x7DFD2A0", VA = "0x187DFECA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E179C0", Offset = "0x7E15FC0", VA = "0x187E179C0", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E17BC0", Offset = "0x7E161C0", VA = "0x187E17BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E17D50", Offset = "0x7E16350", VA = "0x187E17D50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39AA710", Offset = "0x39A8D10", VA = "0x1839AA710")]
	private void BHNMKGJLOJI<T>(BNOBEHECFAC FFKLOCMDIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E17A20", Offset = "0x7E16020", VA = "0x187E17A20")]
	private static void ODPAFJLCLOC(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E17820", Offset = "0x7E15E20", VA = "0x187E17820")]
	private static void GFECADCKFHH(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E17680", Offset = "0x7E15C80", VA = "0x187E17680")]
	private static void BFJINLMGHFK(NativeArray<CNEDHOBLNKD> LPJEPOMELAF, LGCPEOGBNJG APJPFGIELEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E00510", Offset = "0x7DFEB10", VA = "0x187E00510", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E18D70", Offset = "0x7E17370", VA = "0x187E18D70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x17AD290", Offset = "0x17AB890", VA = "0x1817AD290")]
		public JKPKJHBJDDC(IOOCNDFAALB JHDAOHEONAC, bool BBAPCIDHEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B610", Offset = "0x7E09C10", VA = "0x187E0B610")]
		public Queue<COCLDAGBPFI>.Enumerator OMLAPONJPHN()
		{
			return default(Queue<COCLDAGBPFI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B2D0", Offset = "0x7E098D0", VA = "0x187E0B2D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E0A6F0", Offset = "0x7E08CF0", VA = "0x187E0A6F0", Slot = "4")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A0D0", Offset = "0x7E086D0", VA = "0x187E0A0D0")]
	public void BAAPNMLMFKH(NativeList<KIKMAHKACEI> PENPBHIEGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E0AA80", Offset = "0x7E09080", VA = "0x187E0AA80")]
	public void MNGJDPJICCL(Entity JHDAOHEONAC, [In] IEALDBHBOML<GameObject> PGBPOJMDALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A440", Offset = "0x7E08A40", VA = "0x187E0A440")]
	public void ILOENNIKHCN(NativeList<CNEDHOBLNKD> LPJEPOMELAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A210", Offset = "0x7E08810", VA = "0x187E0A210")]
	public void FNJGGHLLPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E0ACC0", Offset = "0x7E092C0", VA = "0x187E0ACC0")]
	public void PKHLKJKCOGD(GDHFOHFFOAJ PAKPDHLKNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A8F0", Offset = "0x7E08EF0", VA = "0x187E0A8F0")]
	public JobHandle MBKMEPGGGBJ([In] COCLDAGBPFI NAAMEAFIHJI, JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A990", Offset = "0x7E08F90", VA = "0x187E0A990")]
	public JobHandle MBKMEPGGGBJ([In] PNKOMHDLEOB NAAMEAFIHJI, JobHandle KKBIELNOEEO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7AC9D20", Offset = "0x7AC8320", VA = "0x187AC9D20")]
	public JKPKJHBJDDC DBKOKHIBPAC(bool BBAPCIDHEFH)
	{
		return default(JKPKJHBJDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A080", Offset = "0x7E08680", VA = "0x187E0A080")]
	public ABDJBANPEOH<PNKOMHDLEOB> AOFGKGBKOEP()
	{
		return default(ABDJBANPEOH<PNKOMHDLEOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E0AA30", Offset = "0x7E09030", VA = "0x187E0AA30")]
	public ABDJBANPEOH<KPPDAPCBBDM> MKLEJGMHDKK()
	{
		return default(ABDJBANPEOH<KPPDAPCBBDM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A4D0", Offset = "0x7E08AD0", VA = "0x187E0A4D0")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E0ABE0", Offset = "0x7E091E0", VA = "0x187E0ABE0", Slot = "5")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A1A0", Offset = "0x7E087A0", VA = "0x187E0A1A0", Slot = "6")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x11661B0", Offset = "0x11647B0", VA = "0x1811661B0", Slot = "7")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DFFBA0", Offset = "0x7DFE1A0", VA = "0x187DFFBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7DFFBB0", Offset = "0x7DFE1B0", VA = "0x187DFFBB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E00AE0", Offset = "0x7DFF0E0", VA = "0x187E00AE0", Slot = "4")]
	public void BAOPLEDIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E00B00", Offset = "0x7DFF100", VA = "0x187E00B00", Slot = "5")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1142790", Offset = "0x1140D90", VA = "0x181142790", Slot = "6")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E05030", Offset = "0x7E03630", VA = "0x187E05030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E053D0", Offset = "0x7E039D0", VA = "0x187E053D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFFC80", Offset = "0x7DFE280", VA = "0x187DFFC80", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7E18E00", Offset = "0x7E17400", VA = "0x187E18E00")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7E18E20", Offset = "0x7E17420", VA = "0x187E18E20")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E15480", Offset = "0x7E13A80", VA = "0x187E15480", Slot = "5")]
				public float3 CBFAJIEGBGD(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7E15440", Offset = "0x7E13A40", VA = "0x187E15440", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E18390", Offset = "0x7E16990", VA = "0x187E18390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E06580", Offset = "0x7E04B80", VA = "0x187E06580", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E07FC0", Offset = "0x7E065C0", VA = "0x187E07FC0")]
			private void INHLIKKMKLH(NativeList<PointSrcData> srcData, NativeList<KIKMAHKACEI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E08EA0", Offset = "0x7E074A0", VA = "0x187E08EA0")]
			public static Vector3 LBNCOJMKIBF(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E06500", Offset = "0x7E04B00", VA = "0x187E06500")]
			public static quaternion EJAAPKKPHNK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7E05E90", Offset = "0x7E04490", VA = "0x187E05E90")]
			private static quaternion DAMHMIADFII(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E06330", Offset = "0x7E04930", VA = "0x187E06330")]
			private static float3 EDKDDLPCHDM(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E09430", Offset = "0x7E07A30", VA = "0x187E09430")]
			private static quaternion MNBCJGEMGGH(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7E060C0", Offset = "0x7E046C0", VA = "0x187E060C0")]
			private static KIKMAHKACEI EDICKOAMOOI(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3F5B6A0", Offset = "0x3F59CA0", VA = "0x183F5B6A0")]
			private void GFHGDFKNAMN<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E071B0", Offset = "0x7E057B0", VA = "0x187E071B0")]
			private void IKOMNFJJKOD(NativeList<PointSrcData> sourcePoints, NativeList<KIKMAHKACEI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7E092B0", Offset = "0x7E078B0", VA = "0x187E092B0")]
			public static float LEMJHLGKDNG(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E05AF0", Offset = "0x7E040F0", VA = "0x187E05AF0")]
			private static quaternion BFDBBHGIMCE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7E09850", Offset = "0x7E07E50", VA = "0x187E09850")]
			private static KIKMAHKACEI PHECOKEOHIG(PointSrcData point)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E09970", Offset = "0x7E07F70", VA = "0x187E09970")]
			private static KIKMAHKACEI PHECOKEOHIG(float3 pos, quaternion rot, float radius)
			{
				return default(KIKMAHKACEI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E07040", Offset = "0x7E05640", VA = "0x187E07040")]
			private static bool GDBMEKNMAGF(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E070E0", Offset = "0x7E056E0", VA = "0x187E070E0")]
			private static float3 HMAPANMOCCF(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E096A0", Offset = "0x7E07CA0", VA = "0x187E096A0")]
			public static float3 OLDOFFKFEFM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7E05CE0", Offset = "0x7E042E0", VA = "0x187E05CE0")]
			public static float3 CBFAJIEGBGD(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E06BE0", Offset = "0x7E051E0", VA = "0x187E06BE0")]
			private static quaternion FEAFAKOJIGA(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E094C0", Offset = "0x7E07AC0", VA = "0x187E094C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1AC10", Offset = "0x7E19210", VA = "0x187E1AC10")]
			private void DJHBHCKJCAF(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7E1ACF0", Offset = "0x7E192F0", VA = "0x187E1ACF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1C820", Offset = "0x7E1AE20", VA = "0x187E1C820")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E1C880", Offset = "0x7E1AE80", VA = "0x187E1C880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1C7C0", Offset = "0x7E1ADC0", VA = "0x187E1C7C0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7E1C810", Offset = "0x7E1AE10", VA = "0x187E1C810", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E05710", Offset = "0x7E03D10", VA = "0x187E05710")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E058D0", Offset = "0x7E03ED0", VA = "0x187E058D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E058E0", Offset = "0x7E03EE0", VA = "0x187E058E0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7E05AE0", Offset = "0x7E040E0", VA = "0x187E05AE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E1C390", Offset = "0x7E1A990", VA = "0x187E1C390")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E1C7B0", Offset = "0x7E1ADB0", VA = "0x187E1C7B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E1A670", Offset = "0x7E18C70", VA = "0x187E1A670", Slot = "15")]
		public override void InitReferences(APJCDBKKFBB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BCB0", Offset = "0x7E1A2B0", VA = "0x187E1BCB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BDA0", Offset = "0x7E1A3A0", VA = "0x187E1BDA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BE00", Offset = "0x7E1A400", VA = "0x187E1BE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A830", Offset = "0x7E18E30", VA = "0x187E1A830")]
		private JobHandle KFPPPGAHCCO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E18E70", Offset = "0x7E17470", VA = "0x187E18E70")]
		private JobHandle CFPAKLKNHJM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E19700", Offset = "0x7E17D00", VA = "0x187E19700")]
		private JobHandle MOFGDBBOCAK(NativeArray<int> pointCount, NativeList<KIKMAHKACEI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E1AB70", Offset = "0x7E19170", VA = "0x187E1AB70")]
		private JobHandle LKHAICEELHM(NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E19D80", Offset = "0x7E18380", VA = "0x187E19D80")]
		private JobHandle HOPOGCCEBEH(EntityQuery query, NativeList<EIOEEPICKHB> splinePointRanges, NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A710", Offset = "0x7E18D10", VA = "0x187E1A710")]
		private JobHandle JGEHMGAHFLC(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B590", Offset = "0x7E19B90", VA = "0x187E1B590")]
		private JobHandle OBKBINHPOKB(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E1ADE0", Offset = "0x7E193E0", VA = "0x187E1ADE0")]
		private JobHandle NCEOINDJDLB(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<ECOECGHAGBF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B6B0", Offset = "0x7E19CB0", VA = "0x187E1B6B0")]
		private JobHandle ODOLKHMJHOK(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<EIOEEPICKHB> splinePointRanges, [Out] NativeList<JPEMOHHKKKK> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E19A00", Offset = "0x7E18000", VA = "0x187E19A00")]
		private JobHandle HFPDCAILJBH(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B080", Offset = "0x7E19680", VA = "0x187E1B080")]
		private JobHandle NHOEPMIAOFE(EntityQuery query, NativeList<ECOECGHAGBF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E1A250", Offset = "0x7E18850", VA = "0x187E1A250")]
		private static NativeParallelHashMap<int, IAMAGEBEBON> IFDANLGDBBH()
		{
			return default(NativeParallelHashMap<int, IAMAGEBEBON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BF70", Offset = "0x7E1A570", VA = "0x187E1BF70")]
		private JobHandle PJBCICDKDIP(EntityQuery query, NativeList<EIOEEPICKHB> splinePointRanges, NativeList<KIKMAHKACEI> splinePointData, NativeList<JPEMOHHKKKK> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E19620", Offset = "0x7E17C20", VA = "0x187E19620")]
		private JobHandle CIONGDKJIOH(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E19700", Offset = "0x7E17D00", VA = "0x187E19700")]
		private JobHandle ECHGDMPFKAI(NativeArray<int> pointCount, NativeList<KIKMAHKACEI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E1AB70", Offset = "0x7E19170", VA = "0x187E1AB70")]
		private JobHandle NNJPFKGEACE(NativeList<KIKMAHKACEI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E19530", Offset = "0x7E17B30", VA = "0x187E19530")]
		private JobHandle CIAPCOGKDHE(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<ECOECGHAGBF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E198F0", Offset = "0x7E17EF0", VA = "0x187E198F0")]
		private JobHandle GNKILJEDEHP(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<EIOEEPICKHB> ranges, NativeList<JPEMOHHKKKK> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E197A0", Offset = "0x7E17DA0", VA = "0x187E197A0")]
		private JobHandle EGOPHLAIEEM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B970", Offset = "0x7E19F70", VA = "0x187E1B970", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E0A010", Offset = "0x7E08610", VA = "0x187E0A010", Slot = "14")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A060", Offset = "0x7E08660", VA = "0x187E0A060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C3C880", Offset = "0x4C3AE80", VA = "0x184C3C880")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C3D380", Offset = "0x4C3B980", VA = "0x184C3D380")]
		public IJCLBOJOIMP(EntityManager IPJDHIAOJKP, MFMNKKMDDKE<T> NJGJLJFIMHO, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x45C2690", Offset = "0x45C0C90", VA = "0x1845C2690")]
		public IJCLBOJOIMP<T> OMLAPONJPHN()
		{
			return default(IJCLBOJOIMP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4C3D260", Offset = "0x4C3B860", VA = "0x184C3D260")]
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
	[Cpp2IlInjected.Address(RVA = "0x7E0E750", Offset = "0x7E0CD50", VA = "0x187E0E750", Slot = "15")]
	public override void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E720", Offset = "0x7E0CD20", VA = "0x187E0E720")]
	public void IOJJKCOJGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F7F0", Offset = "0x7E0DDF0", VA = "0x187E0F7F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C720", Offset = "0x7E0AD20", VA = "0x187E0C720")]
	private void DHHODGPJFPI(KPPDAPCBBDM NAAMEAFIHJI, Mesh[] LHHLMCNOLOM, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x390B940", Offset = "0x3909F40", VA = "0x18390B940")]
	private IJCLBOJOIMP<T> LAOPKEAEBOL<T>(MFMNKKMDDKE<T> NJGJLJFIMHO, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE) where T : struct
	{
		return default(IJCLBOJOIMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DD50", Offset = "0x7E0C350", VA = "0x187E0DD50")]
	private void DOBAEBFFEHI(Transform JHDAOHEONAC, NativeArray<KGHDDMDOCBC> GAEMLEENPDN, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C250", Offset = "0x7E0A850", VA = "0x187E0C250")]
	private void CGCGOLALHAN(Transform JHDAOHEONAC, NativeArray<KEKMGHNJNPO> PGHPKJEELKC, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F400", Offset = "0x7E0DA00", VA = "0x187E0F400")]
	private void LGJCDIEAJDF(Transform JHDAOHEONAC, NativeArray<FMBEAEEPJCM> DBLPGHIOHAK, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E10970", Offset = "0x7E0EF70", VA = "0x187E10970")]
	private void PGFGNDMAJBL(Transform JHDAOHEONAC, NativeArray<EGOCGIDCHJI> LHHLMCNOLOM, Mesh[] DJHMJMICALI, IEALDBHBOML<GameObject> PICKKAJKGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E0E0", Offset = "0x7E0C6E0", VA = "0x187E0E0E0")]
	private static void HDIGBHJALNE(NativeParallelHashSet<Entity> ANKLKPHHPBD, NativeParallelHashSet<Entity> FFJAGBNLABL, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E7D0", Offset = "0x7E0CDD0", VA = "0x187E0E7D0")]
	private static void JIBDKNOHPGC(NativeList<Entity> OLEDHEBBJPH, NativeArray<EntityRemapUtility.EntityRemapInfo> JAPCEEJMKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E890", Offset = "0x7E0CE90", VA = "0x187E0E890")]
	private NativeParallelHashMap<Entity, DBPGNNCDKNJ> LGHIAGEFOOI(IOOCNDFAALB.JKPKJHBJDDC EOJBNLJFECM, ABDJBANPEOH<PNKOMHDLEOB> BIFFDKIHALG, List<GameObject> PICKKAJKGOK)
	{
		return default(NativeParallelHashMap<Entity, DBPGNNCDKNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E620", Offset = "0x7E0CC20", VA = "0x187E0E620")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HPFBMCJNKCI(Entity BFNLIBJABAF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D800", Offset = "0x7E0BE00", VA = "0x187E0D800")]
	private void DIDBKEANHBM(NativeList<Entity> HECCIIHOGIG, NativeList<Entity> DNKIMJFNFAA, NativeParallelHashMap<Entity, DBPGNNCDKNJ> ACJBHICMLKM, NativeList<EIOEEPICKHB> DJENHNLGFNC, NativeList<KIKMAHKACEI> LIBIJPCBHPF, NativeList<JPEMOHHKKKK> CKEKEGONPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E230", Offset = "0x7E0C830", VA = "0x187E0E230")]
	private void HEEMJMMBIHO(NativeList<Entity> ANKLKPHHPBD, NativeList<Entity> GJBCDGBBFFE, NativeParallelHashMap<Entity, DBPGNNCDKNJ> ACJBHICMLKM, NativeList<ECOECGHAGBF> PEFKGINFGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE280", Offset = "0x7DFC880", VA = "0x187DFE280")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS CGDDFJJFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BE50", Offset = "0x7E0A450", VA = "0x187E0BE50", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 PPPKJDCLMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C0C0", Offset = "0x7E0A6C0", VA = "0x187E0C0C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 HJIMMFEKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C1B0", Offset = "0x7E0A7B0", VA = "0x187E0C1B0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 JFKFHNOHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C110", Offset = "0x7E0A710", VA = "0x187E0C110", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C070", Offset = "0x7E0A670", VA = "0x187E0C070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion HAHIEBCKGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C160", Offset = "0x7E0A760", VA = "0x187E0C160", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BF30", Offset = "0x7E0A530", VA = "0x187E0BF30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 NFJLCFBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BF80", Offset = "0x7E0A580", VA = "0x187E0BF80", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 AFLLECOEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C020", Offset = "0x7E0A620", VA = "0x187E0C020", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 JHDDOLOMFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BFD0", Offset = "0x7E0A5D0", VA = "0x187E0BFD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7E0C200", Offset = "0x7E0A800", VA = "0x187E0C200")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFEA90", Offset = "0x7DFD090", VA = "0x187DFEA90", Slot = "17")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS JCPJNMOCNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE9B0", Offset = "0x7DFCFB0", VA = "0x187DFE9B0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float CJJIAOIEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC07340", Offset = "0xC05940", VA = "0x180C07340", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 MMECBKAEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE960", Offset = "0x7DFCF60", VA = "0x187DFE960", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IHNAGNCLKBF HHJMFCOIPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE58DB0", Offset = "0xE573B0", VA = "0x180E58DB0", Slot = "21")]
		get
		{
			return default(IHNAGNCLKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MNHJGJHOEHN HABJDCBKHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1372530", Offset = "0x1370B30", VA = "0x181372530", Slot = "22")]
		get
		{
			return default(MNHJGJHOEHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool HMEMCGOGMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NDPNAFDPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEAE0", Offset = "0x7DFD0E0", VA = "0x187DFEAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1148630", Offset = "0x1146C30", VA = "0x181148630")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0E0", Offset = "0x7DFD6E0", VA = "0x187DFF0E0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected JFDGJOPOGFB PIJODJEEGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0D0", Offset = "0x7DFD6D0", VA = "0x187DFF0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected KJLADPJFBIO LBCCNKIBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF100", Offset = "0x7DFD700", VA = "0x187DFF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected JHOFBNJCHGN JAGKPLKJHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF510", Offset = "0x7DFDB10", VA = "0x187DFF510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject FOOFIAMMBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF320", Offset = "0x7DFD920", VA = "0x187DFF320", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS CGDDFJJFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1169D80", Offset = "0x1168380", VA = "0x181169D80", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 PPPKJDCLMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF6B0", Offset = "0x7DFDCB0", VA = "0x187DFF6B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 HJIMMFEKNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFA20", Offset = "0x7DFE020", VA = "0x187DFFA20", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 JFKFHNOHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF7A0", Offset = "0x7DFDDA0", VA = "0x187DFF7A0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF5A0", Offset = "0x7DFDBA0", VA = "0x187DFF5A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion HAHIEBCKGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF8D0", Offset = "0x7DFDED0", VA = "0x187DFF8D0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEED0", Offset = "0x7DFD4D0", VA = "0x187DFEED0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 NFJLCFBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEFE0", Offset = "0x7DFD5E0", VA = "0x187DFEFE0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 AFLLECOEHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF350", Offset = "0x7DFD950", VA = "0x187DFF350", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 JHDDOLOMFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF160", Offset = "0x7DFD760", VA = "0x187DFF160", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xDEC6A0", Offset = "0xDEACA0", VA = "0x180DEC6A0")]
	protected CJGNIPMMEKH(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7DFF9F0", Offset = "0x7DFDFF0", VA = "0x187DFF9F0")]
	public static CIPJGNAKHIH OIFHDJNIHDL(CJGNIPMMEKH LEMBKBGMCDG)
	{
		return default(CIPJGNAKHIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JAFIAIEKCDF
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DF90", Offset = "0x7E1C590", VA = "0x187E1DF90")]
	public static void KOKBOIJJGBJ(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CMOAPPNFIKP
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D5A0", Offset = "0x7E1BBA0", VA = "0x187E1D5A0")]
	public static void CKGOFKPFLNH(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP, GDHFOHFFOAJ CLLBJKEEKKA, JFDGJOPOGFB GGBPNJIDLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D9F0", Offset = "0x7E1BFF0", VA = "0x187E1D9F0")]
	public static void MBPMFBBIJNN(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP, GDHFOHFFOAJ CLLBJKEEKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D300", Offset = "0x7E1B900", VA = "0x187E1D300")]
	public static NativeList<Entity> AKLEFKEMIGN(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D9B0", Offset = "0x7E1BFB0", VA = "0x187E1D9B0")]
	public static NativeList<Entity> GHCDABPODBG(NativeArray<Entity> ANKLKPHHPBD, EntityManager IPJDHIAOJKP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7E1D340", Offset = "0x7E1B940", VA = "0x187E1D340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E1E1D0", Offset = "0x7E1C7D0", VA = "0x187E1E1D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DIDIFHNCLFN PPJOFODMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E510", Offset = "0x7E1CB10", VA = "0x187E1E510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData IMGNFHIGEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E420", Offset = "0x7E1CA20", VA = "0x187E1E420")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private CIPJGNAKHIH KLMNFCPAIML
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF9F0", Offset = "0x7DFDFF0", VA = "0x187DFF9F0", Slot = "17")]
		get
		{
			return default(CIPJGNAKHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float CJJIAOIEKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 MMECBKAEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x15F93E0", Offset = "0x15F79E0", VA = "0x1815F93E0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private IHNAGNCLKBF HHJMFCOIPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90", Slot = "21")]
		get
		{
			return default(IHNAGNCLKBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private MNHJGJHOEHN HABJDCBKHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0", Slot = "22")]
		get
		{
			return default(MNHJGJHOEHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS JCPJNMOCNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E3F0", Offset = "0x7E1C9F0", VA = "0x187E1E3F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NDPNAFDPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool HMEMCGOGMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E570", Offset = "0x7E1CB70", VA = "0x187E1E570")]
	protected LANKNMONCOL(PKENAFNLEAO FOCJCDLOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E260", Offset = "0x7E1C860", VA = "0x187E1E260", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E1DE70", Offset = "0x7E1C470", VA = "0x187E1DE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected LGCPEOGBNJG NPOIHCKJNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DE20", Offset = "0x7E1C420", VA = "0x187E1DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool HBIECGDNFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DD60", Offset = "0x7E1C360", VA = "0x187E1DD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DEC0", Offset = "0x7E1C4C0", VA = "0x187E1DEC0", Slot = "15")]
	public virtual void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
	protected FEMIGNDILNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class NJOFIIKANJO
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E600", Offset = "0x7E1CC00", VA = "0x187E1E600")]
	public static void CKBKAPMKPKN(NativeArray<Entity> HECCIIHOGIG, EntityManager IPJDHIAOJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3080188230
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EA10", Offset = "0x7E1D010", VA = "0x187E1EA10")]
	public static void PCDGKKDKHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7E1EA00", Offset = "0x7E1D000", VA = "0x187E1EA00")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NCIMHMKJNMC : ContainerPropertyBag<NMDMPHKHONK>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E5A0", Offset = "0x7E1CBA0", VA = "0x187E1E5A0")]
	public NCIMHMKJNMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class CNHFJMIAGHM : ContainerPropertyBag<AFEJAEFHGJP>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DD00", Offset = "0x7E1C300", VA = "0x187E1DD00")]
	public CNHFJMIAGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class IJMLFDAIOPB : ContainerPropertyBag<KOENLFGEGLC>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1DF30", Offset = "0x7E1C530", VA = "0x187E1DF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E1E840", Offset = "0x7E1CE40", VA = "0x187E1E840")]
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
