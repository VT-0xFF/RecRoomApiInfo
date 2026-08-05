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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81A2FE0", Offset = "0x81A17E0", VA = "0x1881A2FE0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8157C30", Offset = "0x8156430", VA = "0x188157C30", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81AAE40", Offset = "0x81A9640", VA = "0x1881AAE40")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81AB3D0", Offset = "0x81A9BD0", VA = "0x1881AB3D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81AB430", Offset = "0x81A9C30", VA = "0x1881AB430")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NGOONPJOLLM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81A5A80", Offset = "0x81A4280", VA = "0x1881A5A80")]
	public static Quaternion JPHCFIODNBF([In] this NOMICBGIFOL CJBDHOMMHIA, [In] Vector3 LONBCENHPHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MADNDDEIJIB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81A3740", Offset = "0x81A1F40", VA = "0x1881A3740")]
	public static bool DGAKFOHMHKO(this OHAPFJNKCIG KLNCEFCFPOE, CMGJMELDMAG KNDBAOCCLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81A3780", Offset = "0x81A1F80", VA = "0x1881A3780")]
	public static bool FFAHDJMIHBP(this OHAPFJNKCIG KLNCEFCFPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81A3490", Offset = "0x81A1C90", VA = "0x1881A3490")]
	public static bool BEKMMKAKBFN(this OHAPFJNKCIG KLNCEFCFPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x81A3360", Offset = "0x81A1B60", VA = "0x1881A3360")]
	public static void ADMHJEADOLI(this OHAPFJNKCIG KLNCEFCFPOE, Vector3 EHFDIMAFMLE, Quaternion KJKLAHDDAOF, float ANIHENNGJAL, bool BGKPNCJLAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81A34C0", Offset = "0x81A1CC0", VA = "0x1881A34C0")]
	public static void CNPEENECHKP(this OHAPFJNKCIG KLNCEFCFPOE, Vector3 EHFDIMAFMLE, Quaternion KJKLAHDDAOF, float ANIHENNGJAL, int CEBMFCNIBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81A4CE0", Offset = "0x81A34E0", VA = "0x1881A4CE0")]
	public static void NJIGGNLEHAN(this OHAPFJNKCIG KLNCEFCFPOE, int CEBMFCNIBDD, Vector3 EHFDIMAFMLE, Quaternion KJKLAHDDAOF, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81A5090", Offset = "0x81A3890", VA = "0x1881A5090")]
	public static void PPNEBHFHIEG(this OHAPFJNKCIG KLNCEFCFPOE, Vector3 AOMIPAKFAHK, Quaternion AIGCPIHGNPB, float ANIHENNGJAL, bool BGKPNCJLAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81A37B0", Offset = "0x81A1FB0", VA = "0x1881A37B0")]
	private static void FNNGEKJEFCF(this OHAPFJNKCIG KLNCEFCFPOE, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL, bool BGKPNCJLAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81A4700", Offset = "0x81A2F00", VA = "0x1881A4700")]
	private static void IBODCEICOMP(this OHAPFJNKCIG KLNCEFCFPOE, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, float IJEPEGPNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81A48B0", Offset = "0x81A30B0", VA = "0x1881A48B0")]
	private static void JPKOKKECONF(this OHAPFJNKCIG KLNCEFCFPOE, int PNJCJGEIDHG, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, float IJEPEGPNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81A4CB0", Offset = "0x81A34B0", VA = "0x1881A4CB0")]
	private static bool MOAIDDFDKFP(this OHAPFJNKCIG KLNCEFCFPOE, int PNJCJGEIDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81A4E00", Offset = "0x81A3600", VA = "0x1881A4E00")]
	private static void PBDHFGIPJCG(this OHAPFJNKCIG KLNCEFCFPOE, int PNJCJGEIDHG, Vector3 BAIEFBENFCP, Quaternion HBPGIGGIBDO, float IJEPEGPNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81A4100", Offset = "0x81A2900", VA = "0x1881A4100")]
	public static Vector3 FPLOBOLGBPF(this OHAPFJNKCIG KLNCEFCFPOE, int PNJCJGEIDHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81A45F0", Offset = "0x81A2DF0", VA = "0x1881A45F0")]
	public static Quaternion GLHOAPBJABN(this OHAPFJNKCIG KLNCEFCFPOE, int PNJCJGEIDHG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81A4A90", Offset = "0x81A3290", VA = "0x1881A4A90")]
	public static Vector3 LILMFDKHLMG(CMGJMELDMAG NMFHGOAHANN, Vector3 KKEEFCOJJFM, Vector3? FFIGIJDIKMO, Vector3 FGNIOGCKLKH)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface MBEBAPOLHHA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFLPKGPKNNB(EntityQuery JGNCOBLHBBM, EntityManager FAIGBHOGMGE, CHKGGGNHDIL DLJGBAKBBOP, PCNNFFFDAKC LKIAIKIGBAL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface ELLDELJGPNA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DJKCBJNLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMBHIHKPKPC(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FODIEKKLAND(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLGHFJACIJM(DBFFJCHPNOI NBMGFOGPGII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HPCJJHKCKNH : MBEBAPOLHHA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x819C370", Offset = "0x819AB70", VA = "0x18819C370", Slot = "4")]
	public void DFLPKGPKNNB(EntityQuery JGNCOBLHBBM, EntityManager FAIGBHOGMGE, CHKGGGNHDIL DLJGBAKBBOP, PCNNFFFDAKC LKIAIKIGBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HPCJJHKCKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class GDHNLOBBCPB : MBEBAPOLHHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FGMEPCABJKL BGHBIEECDGN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
	public GDHNLOBBCPB(FGMEPCABJKL BGHBIEECDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8191680", Offset = "0x818FE80", VA = "0x188191680", Slot = "4")]
	public void DFLPKGPKNNB(EntityQuery JGNCOBLHBBM, EntityManager FAIGBHOGMGE, CHKGGGNHDIL DLJGBAKBBOP, PCNNFFFDAKC LKIAIKIGBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class NKPEGOPOCAL : MBEBAPOLHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x81A5C20", Offset = "0x81A4420", VA = "0x1881A5C20", Slot = "4")]
	public void DFLPKGPKNNB(EntityQuery JGNCOBLHBBM, EntityManager FAIGBHOGMGE, CHKGGGNHDIL DLJGBAKBBOP, PCNNFFFDAKC LKIAIKIGBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NKPEGOPOCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IHJLGHOGKLO : ELLDELJGPNA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DJKCBJNLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x819CC70", Offset = "0x819B470", VA = "0x18819CC70", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x819C770", Offset = "0x819AF70", VA = "0x18819C770", Slot = "5")]
	public void DMBHIHKPKPC(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x819C9F0", Offset = "0x819B1F0", VA = "0x18819C9F0", Slot = "6")]
	public void FODIEKKLAND(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x819CCA0", Offset = "0x819B4A0", VA = "0x18819CCA0", Slot = "7")]
	public void GLGHFJACIJM(DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IHJLGHOGKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LLJBEAGOENC : ELLDELJGPNA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DJKCBJNLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81A2B80", Offset = "0x81A1380", VA = "0x1881A2B80", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81A2680", Offset = "0x81A0E80", VA = "0x1881A2680", Slot = "5")]
	public void DMBHIHKPKPC(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81A2900", Offset = "0x81A1100", VA = "0x1881A2900", Slot = "6")]
	public void FODIEKKLAND(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81A2BB0", Offset = "0x81A13B0", VA = "0x1881A2BB0", Slot = "7")]
	public void GLGHFJACIJM(DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LLJBEAGOENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EJHNFLNLMJI : ELLDELJGPNA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DJKCBJNLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81901F0", Offset = "0x818E9F0", VA = "0x1881901F0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x818FCF0", Offset = "0x818E4F0", VA = "0x18818FCF0", Slot = "5")]
	public void DMBHIHKPKPC(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x818FF70", Offset = "0x818E770", VA = "0x18818FF70", Slot = "6")]
	public void FODIEKKLAND(EntityQuery JGNCOBLHBBM, DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8190220", Offset = "0x818EA20", VA = "0x188190220", Slot = "7")]
	public void GLGHFJACIJM(DBFFJCHPNOI NBMGFOGPGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EJHNFLNLMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LJLPDKODHLO : PLKHDOOKPMK, FHLMMIDFMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CHKGGGNHDIL DLJGBAKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private PIPEPLAECIA OALANCOEDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private PCNNFFFDAKC LKIAIKIGBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, MBEBAPOLHHA adapter)> FDDIBMEHMKG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81A21D0", Offset = "0x81A09D0", VA = "0x1881A21D0", Slot = "15")]
	public virtual void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81A2260", Offset = "0x81A0A60", VA = "0x1881A2260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81A2050", Offset = "0x81A0850", VA = "0x1881A2050")]
	private void DKHEGGAOHKJ(EntityQueryDesc HDIHLBOKMOF, MBEBAPOLHHA MEBIMKAMPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81A2490", Offset = "0x81A0C90", VA = "0x1881A2490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
	public LJLPDKODHLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class LFACMPENOCJ : PLKHDOOKPMK, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IAKDPHFHIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery LONLADGANDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HDECGODFKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery CFDCKGFPIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AJJEOFGENGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery ABNIIAOAICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery EHDJGEMOHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery LJGLAIKCPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ELLDELJGPNA LGOJHFPBKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType NPACELOEMEC;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IAKDPHFHIKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CHKGGGNHDIL DLJGBAKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private PCNNFFFDAKC LKIAIKIGBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PIPEPLAECIA OALANCOEDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<IAKDPHFHIKL> FDDIBMEHMKG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x81A1BB0", Offset = "0x81A03B0", VA = "0x1881A1BB0", Slot = "14")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x81A1C40", Offset = "0x81A0440", VA = "0x1881A1C40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81A1DC0", Offset = "0x81A05C0", VA = "0x1881A1DC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81A1020", Offset = "0x819F820", VA = "0x1881A1020")]
	private void CGFBFDHNDDP(IAKDPHFHIKL EOCCCIJGCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81A1470", Offset = "0x819FC70", VA = "0x1881A1470")]
	private void DKHEGGAOHKJ(ELLDELJGPNA LGOJHFPBKAI, ComponentType JDFNLFFPADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
	public LFACMPENOCJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct NPIGMIPODDL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct IFIDBLBPHLF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct GMMMKDGGCKL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(PCNNFFFDAKC), new string[] { })]
public class DCEJAPGMAJC : PCNNFFFDAKC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ELCBLENENFJ BCEIHLGIBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(ELCBLENENFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DCEJAPGMAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(ENIMDODCOJL), new string[] { })]
public class BOLCCLKGDOM : ENIMDODCOJL, CEMPNLCLMHD, JCLLOKFPFOL, FFGPMFMFIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private MGOAOGOOHDM NAHDLONMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private CHKGGGNHDIL DLJGBAKBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private IPIPLKEIAHG OKNIDGHPEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity BFLBICAKMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EHLBOOAPMJF FCNLEOPNMOH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x818D1D0", Offset = "0x818B9D0", VA = "0x18818D1D0", Slot = "4")]
	public bool DHJNBDEDHFJ(BMGFKKCFMCO MIKNGKGCFKJ, AFPIKACBKKH MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x818D340", Offset = "0x818BB40", VA = "0x18818D340", Slot = "5")]
	public EHLBOOAPMJF NEGEPEGGCHM()
	{
		return default(EHLBOOAPMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x818D0C0", Offset = "0x818B8C0", VA = "0x18818D0C0", Slot = "6")]
	public void BHGLJKNHMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x818D2B0", Offset = "0x818BAB0", VA = "0x18818D2B0", Slot = "7")]
	private void DJHOLMKIEEJ(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11F1720", Offset = "0x11EFF20", VA = "0x1811F1720", Slot = "8")]
	private void BFECBMINEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BOLCCLKGDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(EINOBEFJFHP), new string[] { })]
public class KMLMFGGEJCL : EINOBEFJFHP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81A04C0", Offset = "0x819ECC0", VA = "0x1881A04C0", Slot = "4")]
	public void DALEMKKFMFF(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81A0D70", Offset = "0x819F570", VA = "0x1881A0D70", Slot = "5")]
	public void FKNABFDEOPG(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x81A0DC0", Offset = "0x819F5C0", VA = "0x1881A0DC0", Slot = "6")]
	public ComponentSystemBase HBKIEDPNCEN(World NAHDLONMOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81A0460", Offset = "0x819EC60", VA = "0x1881A0460", Slot = "7")]
	public void BPFKBPHNNNF(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x81A0E10", Offset = "0x819F610", VA = "0x1881A0E10", Slot = "8")]
	public void JHMGOIEDHHK(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81A0EE0", Offset = "0x819F6E0", VA = "0x1881A0EE0", Slot = "9")]
	public void POKCPMCHEDP(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x81A0E70", Offset = "0x819F670", VA = "0x1881A0E70", Slot = "10")]
	public void PBOFMINNFHC(World NAHDLONMOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x81A0540", Offset = "0x819ED40", VA = "0x1881A0540", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> EBOECHMNLDJ()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KMLMFGGEJCL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct GKBNGCHCBCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct DEOGIJGJNBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JBFKKAIMKOP : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FAKJEMFPGGP MDMAJGJKLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x819DED0", Offset = "0x819C6D0", VA = "0x18819DED0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x819DE60", Offset = "0x819C660", VA = "0x18819DE60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JBFKKAIMKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct BJEHAEJKINN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EHLBOOAPMJF LJHAOJFELLK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static BJEHAEJKINN KEINEINMKGA(EHLBOOAPMJF DAMJGGDGMEF)
	{
		return default(BJEHAEJKINN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GPLKDGFOLLD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NKCLKODHAAP OGKKCEIECPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8197450", Offset = "0x8195C50", VA = "0x188197450", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GPLKDGFOLLD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct GKCOOEIJNFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct LLDGKNBHPEB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AOHNGCKJMMB GNCIACHIDAJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static LLDGKNBHPEB KEINEINMKGA(AOHNGCKJMMB DAMJGGDGMEF)
	{
		return default(LLDGKNBHPEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct DCOCOJKKHPF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EHLBOOAPMJF LJHAOJFELLK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static DCOCOJKKHPF KEINEINMKGA(EHLBOOAPMJF DAMJGGDGMEF)
	{
		return default(DCOCOJKKHPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NHEENCAOCJH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public COKLCAOIGDG LDOCFDILMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81A5BD0", Offset = "0x81A43D0", VA = "0x1881A5BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81A5B60", Offset = "0x81A4360", VA = "0x1881A5B60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NHEENCAOCJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AHLKMIMEPCN : IBGHMDFEIGG, FAKJEMFPGGP, OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GPADGHOFJCI ADOIFIGOBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xDC47B0", Offset = "0xDC2FB0", VA = "0x180DC47B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(GPADGHOFJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OIJLDMKPBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC8E670", Offset = "0xC8CE70", VA = "0x180C8E670", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 EPJNLHHIMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1122340", Offset = "0x1120B40", VA = "0x181122340", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x818BF40", Offset = "0x818A740", VA = "0x18818BF40")]
	public AHLKMIMEPCN(UniformTRS AFPDKPEENFE, MGMNCEJOGLO MJNLMOPPION, float BJBPNGPOJFB, float3 JLFJDCJFBJO, OCHABKGPDJF PPOBOACOKGP, MGEEHPEJAKN HGFCNJJMHME, GPADGHOFJCI LDIMBHJDJOD, float3 LOJEJHFIPJF, bool MGHEDPEGDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x818BEF0", Offset = "0x818A6F0", VA = "0x18818BEF0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AHIADODIEJK : IBGHMDFEIGG, COKLCAOIGDG, OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<KKEDALOMPGI> ANCKDHEONMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly IKBILMPCMNJ JCPNJLMMOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float CIFGKDHKDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int LJNNJIGIHHP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GEOJDLJFJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x818BE30", Offset = "0x818A630", VA = "0x18818BE30", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool BJJEMCEGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x818BE50", Offset = "0x818A650", VA = "0x18818BE50", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool AJFFMACCMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x818BE40", Offset = "0x818A640", VA = "0x18818BE40", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AFALELDPBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA877D0", Offset = "0xA85FD0", VA = "0x180A877D0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float CHMGLBHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD13080", Offset = "0xD11880", VA = "0x180D13080", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KAKMPJPCNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF79070", Offset = "0xF77870", VA = "0x180F79070", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x818BD80", Offset = "0x818A580", VA = "0x18818BD80")]
	public AHIADODIEJK(UniformTRS AFPDKPEENFE, MGMNCEJOGLO MJNLMOPPION, float BJBPNGPOJFB, float3 JLFJDCJFBJO, OCHABKGPDJF PPOBOACOKGP, MGEEHPEJAKN HGFCNJJMHME, IKBILMPCMNJ JCPNJLMMOLN, float CIFGKDHKDOL, int LJNNJIGIHHP, NativeArray<KKEDALOMPGI> ANCKDHEONMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x113B550", Offset = "0x1139D50", VA = "0x18113B550", Slot = "33")]
	public NativeArray<KKEDALOMPGI> GetNativeCurvePoints()
	{
		return default(NativeArray<KKEDALOMPGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x818BCC0", Offset = "0x818A4C0", VA = "0x18818BCC0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ODOCNKAMICJ : LHGBFEIAIID, FAKJEMFPGGP, OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<HBIFHMNPGDK, GPADGHOFJCI> HIBDCFEEMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private GPADGHOFJCI LDIMBHJDJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MGHEDPEGDIC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GPADGHOFJCI JHIIDEHLLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30", Slot = "28")]
		get
		{
			return default(GPADGHOFJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool IFIABLMNGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xECB7B0", Offset = "0xEC9FB0", VA = "0x180ECB7B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 EPJNLHHIMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81A6720", Offset = "0x81A4F20", VA = "0x1881A6720", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81A6700", Offset = "0x81A4F00", VA = "0x1881A6700")]
	public ODOCNKAMICJ(BMGFKKCFMCO NHDNPGNDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81A6080", Offset = "0x81A4880", VA = "0x1881A6080", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x81A60D0", Offset = "0x81A48D0", VA = "0x1881A60D0", Slot = "26")]
	public override void JNHFKCNMNLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MAEBONLKMKP : BBEOHMKJACI, NKCLKODHAAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject FOBOOIGJOCI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject CBMGDPANAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81A5270", Offset = "0x81A3A70", VA = "0x1881A5270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HOAIPFDEDJB GNOACPCNCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81A5300", Offset = "0x81A3B00", VA = "0x1881A5300", Slot = "15")]
		get
		{
			return default(HOAIPFDEDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MGNEEMIMPIH FEDFIMMIGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81A56D0", Offset = "0x81A3ED0", VA = "0x1881A56D0", Slot = "16")]
		get
		{
			return default(MGNEEMIMPIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x81A5580", Offset = "0x81A3D80", VA = "0x1881A5580")]
	public MAEBONLKMKP(BMGFKKCFMCO MIKNGKGCFKJ, bool HGJMPDPDBEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81A50E0", Offset = "0x81A38E0", VA = "0x1881A50E0")]
	public void AGJMKHEAEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81A5300", Offset = "0x81A3B00", VA = "0x1881A5300")]
	protected HOAIPFDEDJB DMLLPLAIBOP()
	{
		return default(HOAIPFDEDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x81A5430", Offset = "0x81A3C30", VA = "0x1881A5430")]
	private static bool MABNFHFBPPB(BMGFKKCFMCO PDGPMIEMGMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81A5400", Offset = "0x81A3C00", VA = "0x1881A5400", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EEEBIPMMGJI : LHGBFEIAIID, COKLCAOIGDG, OMPPFNFJGFB, IDisposable, PPOCPEKNDDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<KKEDALOMPGI> ANCKDHEONMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NGEEELLEEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool ADGEPNDNPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float CIFGKDHKDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int LJNNJIGIHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool JGIBACDIEHE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool DNCLPPBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC9B980", Offset = "0xC9A180", VA = "0x180C9B980", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool DJKJJDKNKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA74FA0", Offset = "0xA737A0", VA = "0x180A74FA0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float DNKODFOLGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE0CD50", Offset = "0xE0B550", VA = "0x180E0CD50", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int NCICNAJPIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xDC47B0", Offset = "0xDC2FB0", VA = "0x180DC47B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool ONKICDCLGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC8E670", Offset = "0xC8CE70", VA = "0x180C8E670", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int NLFDCBKMFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x818F5B0", Offset = "0x818DDB0", VA = "0x18818F5B0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int MIINJGHDBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x818F3D0", Offset = "0x818DBD0", VA = "0x18818F3D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x818FCC0", Offset = "0x818E4C0", VA = "0x18818FCC0")]
	public EEEBIPMMGJI(BMGFKKCFMCO NHDNPGNDBND, [Optional] NativeList<KKEDALOMPGI> ANCKDHEONMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x818F8A0", Offset = "0x818E0A0", VA = "0x18818F8A0", Slot = "26")]
	public override void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x818F4C0", Offset = "0x818DCC0", VA = "0x18818F4C0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x818F5D0", Offset = "0x818DDD0", VA = "0x18818F5D0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x818F980", Offset = "0x818E180", VA = "0x18818F980")]
	public void LPEBPGEFALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x818F630", Offset = "0x818DE30", VA = "0x18818F630", Slot = "34")]
	public NativeArray<KKEDALOMPGI> GetNativeCurvePoints()
	{
		return default(NativeArray<KKEDALOMPGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x818FB70", Offset = "0x818E370", VA = "0x18818FB70", Slot = "35")]
	private Vector3 OBNHNNKHCII(int BIJFLLMPINH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x818F800", Offset = "0x818E000", VA = "0x18818F800", Slot = "36")]
	private Quaternion IALJKGGJPFJ(int BIJFLLMPINH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x818F9E0", Offset = "0x818E1E0", VA = "0x18818F9E0", Slot = "37")]
	private float NOHJGCOIHPN(int BIJFLLMPINH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x818F830", Offset = "0x818E030", VA = "0x18818F830")]
	private NativeArray<Entity> JIJACHAMNMO()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class AIGKHALEHAG : KMFJJDDOIIN
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x818BFE0", Offset = "0x818A7E0", VA = "0x18818BFE0", Slot = "15")]
	protected override ComponentSystemBase IDMPEHANMAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x818C3F0", Offset = "0x818ABF0", VA = "0x18818C3F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x818C400", Offset = "0x818AC00", VA = "0x18818C400")]
	public AIGKHALEHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FKFAABHOEMC]
public sealed class FGFEMIPBIGH : EGDEADJGJNN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery GNAFEFMJKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery FCGBLNACLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery LGABLHGGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery OGBEIBHFNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery FNKBPOMGPNK;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8190A30", Offset = "0x818F230", VA = "0x188190A30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8190D90", Offset = "0x818F590", VA = "0x188190D90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x81907A0", Offset = "0x818EFA0", VA = "0x1881907A0")]
	private void IOCMKMIMJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8190690", Offset = "0x818EE90", VA = "0x188190690")]
	private void INNGDAMGAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8190270", Offset = "0x818EA70", VA = "0x188190270")]
	private void AADGFJGADKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8190440", Offset = "0x818EC40", VA = "0x188190440")]
	private void AJJLOBDLALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8190540", Offset = "0x818ED40", VA = "0x188190540")]
	private void EHEBAKLEBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81909E0", Offset = "0x818F1E0", VA = "0x1881909E0")]
	private NativeList<Entity> NFICHDKCHCG(NativeArray<Entity> EFHAKLBGNAC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8190640", Offset = "0x818EE40", VA = "0x188190640")]
	private NativeList<Entity> GBCALLLMDKJ(NativeArray<Entity> EFHAKLBGNAC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8190980", Offset = "0x818F180", VA = "0x188190980")]
	private void MGBLAKHDFLL(NativeArray<Entity> EFHAKLBGNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public FGFEMIPBIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FKFAABHOEMC]
public sealed class DCHBIICAAOE : EGDEADJGJNN, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery ACDBCNDILNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery DKMODLHFFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery CFDCKGFPIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ENIMDODCOJL FDMOMDJJKKI;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x818F160", Offset = "0x818D960", VA = "0x18818F160", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x818EDE0", Offset = "0x818D5E0", VA = "0x18818EDE0", Slot = "15")]
	public override void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x818F330", Offset = "0x818DB30", VA = "0x18818F330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x818EE40", Offset = "0x818D640", VA = "0x18818EE40")]
	private void LPLJGFOAKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x818E750", Offset = "0x818CF50", VA = "0x18818E750")]
	private void HENMHIFKBMF(NativeParallelHashSet<EHLBOOAPMJF> JKCLMDDHPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x818DAC0", Offset = "0x818C2C0", VA = "0x18818DAC0")]
	private void AJCNILBFJDK(NativeParallelHashSet<EHLBOOAPMJF> JKCLMDDHPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x818E150", Offset = "0x818C950", VA = "0x18818E150")]
	private void DMCCCEDLHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x818E6B0", Offset = "0x818CEB0", VA = "0x18818E6B0")]
	private bool HBDKCAMCNIM(Entity JAOKKIIOCBD, [Out] EHLBOOAPMJF LJHAOJFELLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x818E500", Offset = "0x818CD00", VA = "0x18818E500")]
	private bool FPLMMOMIDAK(Entity JAOKKIIOCBD, [Out] EHLBOOAPMJF LJHAOJFELLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public DCHBIICAAOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[FKFAABHOEMC]
public sealed class PFNNEDFDEDM : EGDEADJGJNN
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery KHLLIDNGLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery GKOHLDKPEEM;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81A6DE0", Offset = "0x81A55E0", VA = "0x1881A6DE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81A6F30", Offset = "0x81A5730", VA = "0x1881A6F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81A6AE0", Offset = "0x81A52E0", VA = "0x1881A6AE0")]
	private void HENMHIFKBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x81A67F0", Offset = "0x81A4FF0", VA = "0x1881A67F0")]
	private void AJCNILBFJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public PFNNEDFDEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KLEHIGCIKDH : EGDEADJGJNN, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct HIMEIJLCPLJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob FANJLAPJPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob BOIIAKBBALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob EJDCKFHCOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob FFLBNPKAOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle JBAGJBCOKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<DCOCOJKKHPF> PIJJJDPIPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> CKDIMLHNOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> KMAMDKLMDNL;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x819BFC0", Offset = "0x819A7C0", VA = "0x18819BFC0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x819BEE0", Offset = "0x819A6E0", VA = "0x18819BEE0")]
		private void BLGGBOOGCPA(EntityQueryInJob JGNCOBLHBBM, NativeList<Entity> BKABJAEDIMB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct MPOCIAKIHEO : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle JBAGJBCOKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<DCOCOJKKHPF> PIJJJDPIPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> BKABJAEDIMB;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x81A5830", Offset = "0x81A4030", VA = "0x1881A5830", Slot = "4")]
		public void Execute(ArchetypeChunk FIDKOBLOONO, int BIEHEIKEAFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct HMNPAGOHIHG : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle JBAGJBCOKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> HMKDNGFCAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<LLDGKNBHPEB> OGGODKJFMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<BJEHAEJKINN> BDBIINMEDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<DCOCOJKKHPF> FOPDKEIAGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> PHLILENCPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<LLDGKNBHPEB> ADPEPFNAAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<EHLBOOAPMJF> IILIIKKIELM;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x819C040", Offset = "0x819A840", VA = "0x18819C040", Slot = "4")]
		public void Execute(ArchetypeChunk FIDKOBLOONO, int BIEHEIKEAFA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery FANJLAPJPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery BOIIAKBBALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery EJDCKFHCOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery FFLBNPKAOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery PHDJIKCIEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery PKBHEBLGOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery LCMPOGLCOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private ENIMDODCOJL CLIGHEBLPMO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x819FB60", Offset = "0x819E360", VA = "0x18819FB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x819E730", Offset = "0x819CF30", VA = "0x18819E730", Slot = "15")]
	public override void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81A00E0", Offset = "0x819E8E0", VA = "0x1881A00E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x819E790", Offset = "0x819CF90", VA = "0x18819E790")]
	private void KFBHEGEOLHN(NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN, int AOAGEHFKNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x819F120", Offset = "0x819D920", VA = "0x18819F120")]
	private void LLMBIOPIHND(NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN, int NJNOFNBFKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x819F570", Offset = "0x819DD70", VA = "0x18819F570")]
	private void MDKBHPCLNCI(NativeParallelHashSet<EHLBOOAPMJF> EFCPAFEEFHN, int PFAHNLMFCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x819ED90", Offset = "0x819D590", VA = "0x18819ED90")]
	private void KLMLKLIMDBC(NativeParallelHashSet<EHLBOOAPMJF> JKCLMDDHPFC, int CMMHKIICOLC, int PABBMOAILOD, int HCJPJKPOIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x819F9B0", Offset = "0x819E1B0", VA = "0x18819F9B0")]
	private void MFGDBDFICPC(Entity LFAGFBEGIBB, AOHNGCKJMMB IPEKGCFHIHM, EHLBOOAPMJF LJHAOJFELLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public KLEHIGCIKDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class JMPHFJAALGD : EGDEADJGJNN
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery OFKOBLDNEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery BHFNBHBCJEO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x819DF20", Offset = "0x819C720", VA = "0x18819DF20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x819E150", Offset = "0x819C950", VA = "0x18819E150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public JMPHFJAALGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class COIOKENHBOI : EGDEADJGJNN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct BOFGDONNNPJ : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery EMHJCHLAHED;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x818D600", Offset = "0x818BE00", VA = "0x18818D600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x818D740", Offset = "0x818BF40", VA = "0x18818D740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public COIOKENHBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FKFAABHOEMC]
internal class GKOCDLKHKFK : EGDEADJGJNN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FPOPCKIJFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery NOIBGLEEEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery MIGCEGHJBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FBLHPDEEBHD NEILAOHPANA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType OEILJICBJAO;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FPOPCKIJFBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void FBLHPDEEBHD(NativeArray<AOHNGCKJMMB> DAMJGGDGMEF, DBFFJCHPNOI NBMGFOGPGII);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<FPOPCKIJFBN> FDDIBMEHMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PIPEPLAECIA OALANCOEDCK;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8191F10", Offset = "0x8190710", VA = "0x188191F10", Slot = "15")]
	public override void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8192110", Offset = "0x8190910", VA = "0x188192110", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x81922A0", Offset = "0x8190AA0", VA = "0x1881922A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39E6540", Offset = "0x39E4D40", VA = "0x1839E6540")]
	private void DKHEGGAOHKJ<T>(FBLHPDEEBHD NEILAOHPANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8191BD0", Offset = "0x81903D0", VA = "0x188191BD0")]
	private static void CGPHNFLDGPM(NativeArray<AOHNGCKJMMB> NBGKLLBKMKP, DBFFJCHPNOI MDLLJGPEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8191F70", Offset = "0x8190770", VA = "0x188191F70")]
	private static void LGPBELFHAFH(NativeArray<AOHNGCKJMMB> NBGKLLBKMKP, DBFFJCHPNOI MDLLJGPEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8191D70", Offset = "0x8190570", VA = "0x188191D70")]
	private static void IMIKBMIBEEJ(NativeArray<AOHNGCKJMMB> NBGKLLBKMKP, DBFFJCHPNOI MDLLJGPEJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public GKOCDLKHKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[FKFAABHOEMC]
public sealed class FLKFDKCKMGM : EGDEADJGJNN
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery JGNCOBLHBBM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8191250", Offset = "0x818FA50", VA = "0x188191250", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EEDFNFMOFKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS AFPDKPEENFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData FJMKLIMLDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public GPADGHOFJCI LDIMBHJDJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 LOJEJHFIPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MGHEDPEGDIC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BEFKGCJHLFI(Lifetime.LoadInstance)]
public struct AHKOAJDIMHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity NBLBLIGFFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> APIDGJJNDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> BJOAMCMCEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<EEDFNFMOFKF> NPOIBJBPHAM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x818BE60", Offset = "0x818A660", VA = "0x18818BE60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(IKNFGAJFNPF), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class IKNFGAJFNPF : FHLMMIDFMKJ, DEPOIAMCLIH, JCLLOKFPFOL, FFGPMFMFIPE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct FHBKCAECBNA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly IKNFGAJFNPF MJNLMOPPION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool KOMPFLGNHEJ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x18D8EE0", Offset = "0x18D76E0", VA = "0x1818D8EE0")]
		public FHBKCAECBNA(IKNFGAJFNPF MJNLMOPPION, bool KOMPFLGNHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8191190", Offset = "0x818F990", VA = "0x188191190")]
		public Queue<KNFNNAGHGJC>.Enumerator KFPOPIJHFBP()
		{
			return default(Queue<KNFNNAGHGJC>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8190E50", Offset = "0x818F650", VA = "0x188190E50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private IPIPLKEIAHG LJJHNICONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private ANNCKEJGCIP NHOKFEFDEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<KKEDALOMPGI>> NDABHIANMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> PJMKELMCNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<AOHNGCKJMMB> PFDOPBHKEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private APLOHNLIOOF<KNFNNAGHGJC> JFIIMDJOEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private APLOHNLIOOF<AHKOAJDIMHO> BPJCKCBKCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private APLOHNLIOOF<GHBKNPCKMOA> BBEFAAMAIFM;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x819D3D0", Offset = "0x819BBD0", VA = "0x18819D3D0", Slot = "4")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x819CCF0", Offset = "0x819B4F0", VA = "0x18819CCF0")]
	public void AAFDDFJKADD(NativeList<KKEDALOMPGI> MCOAFGEEKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x819D110", Offset = "0x819B910", VA = "0x18819D110")]
	public void DBBPOOJEBMB(Entity MJNLMOPPION, [In] FJODPEEPKJK<GameObject> EAOLHBCCNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x819D340", Offset = "0x819BB40", VA = "0x18819D340")]
	public void GIIACJPJEAG(NativeList<AOHNGCKJMMB> NBGKLLBKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x819DBC0", Offset = "0x819C3C0", VA = "0x18819DBC0")]
	public void POKCPMCHEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x819D5D0", Offset = "0x819BDD0", VA = "0x18819D5D0")]
	public void JBMEBBKLGPB(EKIIKOCIIMI EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x819DA80", Offset = "0x819C280", VA = "0x18819DA80")]
	public JobHandle NDJANBFCGAN([In] KNFNNAGHGJC ILBALOOKKCP, JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x819DB20", Offset = "0x819C320", VA = "0x18819DB20")]
	public JobHandle NDJANBFCGAN([In] AHKOAJDIMHO ILBALOOKKCP, JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E37200", Offset = "0x7E35A00", VA = "0x187E37200")]
	public FHBKCAECBNA EDMDBAIOEEL(bool KOMPFLGNHEJ)
	{
		return default(FHBKCAECBNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x819CEA0", Offset = "0x819B6A0", VA = "0x18819CEA0")]
	public CJKDKEAFMME<AHKOAJDIMHO> AMJOCFJIAGN()
	{
		return default(CJKDKEAFMME<AHKOAJDIMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x819D280", Offset = "0x819BA80", VA = "0x18819D280")]
	public CJKDKEAFMME<GHBKNPCKMOA> DEIJNGALFMN()
	{
		return default(CJKDKEAFMME<GHBKNPCKMOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x819CEF0", Offset = "0x819B6F0", VA = "0x18819CEF0")]
	public void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x819CDC0", Offset = "0x819B5C0", VA = "0x18819CDC0", Slot = "5")]
	public void AIEFDFNMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x819D2D0", Offset = "0x819BAD0", VA = "0x18819D2D0", Slot = "6")]
	private void DJHOLMKIEEJ(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x11EBD20", Offset = "0x11EA520", VA = "0x1811EBD20", Slot = "7")]
	private void BFECBMINEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IKNFGAJFNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JILFHBIAHBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS AFPDKPEENFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData FJMKLIMLDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ONDGGPNOKFN JCPNJLMMOLN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BEFKGCJHLFI(Lifetime.LoadInstance)]
public struct KNFNNAGHGJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity NBLBLIGFFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> APIDGJJNDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> BJOAMCMCEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<OFIADOPPLCJ> OPBFGPKAAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<KKEDALOMPGI> MCOAFGEEKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<JILFHBIAHBO> LKKCLJCKJIP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x81A0F40", Offset = "0x819F740", VA = "0x1881A0F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x81A0F50", Offset = "0x819F750", VA = "0x1881A0F50")]
	public void JGAHMDKPFDK(bool KOMPFLGNHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(KGJPJLJOEPN), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class KGJPJLJOEPN : GOCAAFFABHB, JCLLOKFPFOL, FFGPMFMFIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private IKNFGAJFNPF JJHNEOMPFBN;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x819E710", Offset = "0x819CF10", VA = "0x18819E710", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x819E6C0", Offset = "0x819CEC0", VA = "0x18819E6C0", Slot = "5")]
	private void DJHOLMKIEEJ(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1196B40", Offset = "0x1195340", VA = "0x181196B40", Slot = "6")]
	private void BFECBMINEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KGJPJLJOEPN()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : EGDEADJGJNN, FHLMMIDFMKJ
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
			public NativeParallelHashMap<int, GPADGHOFJCI> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<EEDFNFMOFKF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x81974C0", Offset = "0x8195CC0", VA = "0x1881974C0", Slot = "4")]
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
			public NativeArray<KKEDALOMPGI> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<OFIADOPPLCJ> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<JILFHBIAHBO> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8197860", Offset = "0x8196060", VA = "0x188197860", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x818D980", Offset = "0x818C180", VA = "0x18818D980", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x81A7040", Offset = "0x81A5840", VA = "0x1881A7040")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x81A7060", Offset = "0x81A5860", VA = "0x1881A7060")]
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
				float3 BLFHHPMIHLD(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x81A2C40", Offset = "0x81A1440", VA = "0x1881A2C40", Slot = "5")]
				public float3 OFKIKLDJNOA(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x81A2C00", Offset = "0x81A1400", VA = "0x1881A2C00", Slot = "4")]
				public float3 BLFHHPMIHLD(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x81A5D60", Offset = "0x81A4560", VA = "0x1881A5D60", Slot = "4")]
				public float3 BLFHHPMIHLD(quaternion rotation)
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
			public NativeArray<OFIADOPPLCJ> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<KKEDALOMPGI> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x819A3A0", Offset = "0x8198BA0", VA = "0x18819A3A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81984E0", Offset = "0x8196CE0", VA = "0x1881984E0")]
			private void CHMMEEBAHBE(NativeList<PointSrcData> srcData, NativeList<KKEDALOMPGI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x819AD60", Offset = "0x8199560", VA = "0x18819AD60")]
			public static Vector3 JAIHCAPIFNJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8197F80", Offset = "0x8196780", VA = "0x188197F80")]
			public static quaternion AGEOKFGCJJF(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8198000", Offset = "0x8196800", VA = "0x188198000")]
			private static quaternion AKPKFALDOEA(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x81993C0", Offset = "0x8197BC0", VA = "0x1881993C0")]
			private static float3 DDOMBCPGMOH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x819A9C0", Offset = "0x81991C0", VA = "0x18819A9C0")]
			private static quaternion HHIPBDBLEJM(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x819AA50", Offset = "0x8199250", VA = "0x18819AA50")]
			private static KKEDALOMPGI IBEABBEMJPI(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KKEDALOMPGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x414F4F0", Offset = "0x414DCF0", VA = "0x18414F4F0")]
			private void OMAHJEOBFEE<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8199590", Offset = "0x8197D90", VA = "0x188199590")]
			private void EJFACCNJIJC(NativeList<PointSrcData> sourcePoints, NativeList<KKEDALOMPGI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x819B170", Offset = "0x8199970", VA = "0x18819B170")]
			public static float JGOMBFFIGAI(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x819BC60", Offset = "0x819A460", VA = "0x18819BC60")]
			private static quaternion PBLJCMALEGA(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x819B750", Offset = "0x8199F50", VA = "0x18819B750")]
			private static KKEDALOMPGI LKBMGNLBAMG(PointSrcData point)
			{
				return default(KKEDALOMPGI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x819B870", Offset = "0x819A070", VA = "0x18819B870")]
			private static KKEDALOMPGI LKBMGNLBAMG(float3 pos, quaternion rot, float radius)
			{
				return default(KKEDALOMPGI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x819ACC0", Offset = "0x81994C0", VA = "0x18819ACC0")]
			private static bool ILAMEIANEKL(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8198410", Offset = "0x8196C10", VA = "0x188198410")]
			private static float3 CHGAOCKPGLB(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x819B900", Offset = "0x819A100", VA = "0x18819B900")]
			public static float3 NJCOIMCBPAF(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x819BAB0", Offset = "0x819A2B0", VA = "0x18819BAB0")]
			public static float3 OFKIKLDJNOA(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x819B2F0", Offset = "0x8199AF0", VA = "0x18819B2F0")]
			private static quaternion LFPBCAOLEMB(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8198230", Offset = "0x8196A30", VA = "0x188198230")]
			private static float BHOBCOHICDN(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x81A9520", Offset = "0x81A7D20", VA = "0x1881A9520")]
			private void LADMOOBMFLP(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x81A9430", Offset = "0x81A7C30", VA = "0x1881A9430", Slot = "4")]
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
			public NativeList<KKEDALOMPGI> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x81AAA70", Offset = "0x81A9270", VA = "0x1881AAA70")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x81AAA60", Offset = "0x81A9260", VA = "0x1881AAA60", Slot = "4")]
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
			public NativeList<KKEDALOMPGI> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81AAA10", Offset = "0x81A9210", VA = "0x1881AAA10")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x81AAA00", Offset = "0x81A9200", VA = "0x1881AAA00", Slot = "4")]
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
			public NativeList<EEDFNFMOFKF> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8197BB0", Offset = "0x81963B0", VA = "0x188197BB0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8197BA0", Offset = "0x81963A0", VA = "0x188197BA0", Slot = "4")]
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
			public NativeList<OFIADOPPLCJ> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<JILFHBIAHBO> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8197D80", Offset = "0x8196580", VA = "0x188197D80")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8197D70", Offset = "0x8196570", VA = "0x188197D70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x81AA5E0", Offset = "0x81A8DE0", VA = "0x1881AA5E0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x81AA5D0", Offset = "0x81A8DD0", VA = "0x1881AA5D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly BMELPJIFPCL log;

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
		private FDLNIFJFJGB replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IPIPLKEIAHG objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private IKNFGAJFNPF bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private JILAOKHAAPF ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81A9200", Offset = "0x81A7A00", VA = "0x1881A9200", Slot = "15")]
		public override void InitReferences(OBECFEHHJHL services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x81A9EF0", Offset = "0x81A86F0", VA = "0x1881A9EF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x81A9FE0", Offset = "0x81A87E0", VA = "0x1881A9FE0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81AA040", Offset = "0x81A8840", VA = "0x1881AA040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x81A8780", Offset = "0x81A6F80", VA = "0x1881A8780")]
		private JobHandle DMJABGLOBHE(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x81A70B0", Offset = "0x81A58B0", VA = "0x1881A70B0")]
		private JobHandle ABAGGOJNHBC(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x81A7890", Offset = "0x81A6090", VA = "0x1881A7890")]
		private JobHandle NAPJLDCDNLH(NativeArray<int> pointCount, NativeList<KKEDALOMPGI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x81A9390", Offset = "0x81A7B90", VA = "0x1881A9390")]
		private JobHandle PNMDNDKGFBI(NativeList<KKEDALOMPGI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81A96E0", Offset = "0x81A7EE0", VA = "0x1881A96E0")]
		private JobHandle ODKHCMCKFLF(EntityQuery query, NativeList<OFIADOPPLCJ> splinePointRanges, NativeList<KKEDALOMPGI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81A8AC0", Offset = "0x81A72C0", VA = "0x1881A8AC0")]
		private JobHandle GDGAIKBEMAA(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x81A7770", Offset = "0x81A5F70", VA = "0x1881A7770")]
		private JobHandle BCOFAKDHOML(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x81A8BE0", Offset = "0x81A73E0", VA = "0x1881A8BE0")]
		private JobHandle HGEIBJODOGN(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<EEDFNFMOFKF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x81A7E60", Offset = "0x81A6660", VA = "0x1881A7E60")]
		private JobHandle DCPPKGGPDIF(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<OFIADOPPLCJ> splinePointRanges, [Out] NativeList<JILFHBIAHBO> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81A8E80", Offset = "0x81A7680", VA = "0x1881A8E80")]
		private JobHandle HHGHCHFDCJI(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x81A8120", Offset = "0x81A6920", VA = "0x1881A8120")]
		private JobHandle DFKEPHHJGIG(EntityQuery query, NativeList<EEDFNFMOFKF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81A7A40", Offset = "0x81A6240", VA = "0x1881A7A40")]
		private static NativeParallelHashMap<int, GPADGHOFJCI> CNPPCDBBFHP()
		{
			return default(NativeParallelHashMap<int, GPADGHOFJCI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81AA1B0", Offset = "0x81A89B0", VA = "0x1881AA1B0")]
		private JobHandle PFLBEGLPGGF(EntityQuery query, NativeList<OFIADOPPLCJ> splinePointRanges, NativeList<KKEDALOMPGI> splinePointData, NativeList<JILFHBIAHBO> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x81A9600", Offset = "0x81A7E00", VA = "0x1881A9600")]
		private JobHandle MOMPHKCFMCE(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x81A7890", Offset = "0x81A6090", VA = "0x1881A7890")]
		private JobHandle BKDIFJIDOEL(NativeArray<int> pointCount, NativeList<KKEDALOMPGI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x81A9390", Offset = "0x81A7B90", VA = "0x1881A9390")]
		private JobHandle LKHBPIIDMKA(NativeList<KKEDALOMPGI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x81A92A0", Offset = "0x81A7AA0", VA = "0x1881A92A0")]
		private JobHandle KIPFBJDFLLN(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<EEDFNFMOFKF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x81A7930", Offset = "0x81A6130", VA = "0x1881A7930")]
		private JobHandle CBJKHPJIAPO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<OFIADOPPLCJ> ranges, NativeList<JILFHBIAHBO> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81A8630", Offset = "0x81A6E30", VA = "0x1881A8630")]
		private JobHandle DLHBBPLPOEM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81A9BB0", Offset = "0x81A83B0", VA = "0x1881A9BB0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class PPCIDNIIDIA : PLKHDOOKPMK, FHLMMIDFMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private IKNFGAJFNPF JJHNEOMPFBN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x81A6FD0", Offset = "0x81A57D0", VA = "0x1881A6FD0", Slot = "14")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x81A7020", Offset = "0x81A5820", VA = "0x1881A7020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
	public PPCIDNIIDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class GMFDNOFOMDL : EGDEADJGJNN, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct JCIEDAHJMHK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager FAIGBHOGMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LKOEHOGMIBD<T> FAFDCMPBBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int PNJCJGEIDHG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50A8320", Offset = "0x50A6B20", VA = "0x1850A8320")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50A8710", Offset = "0x50A6F10", VA = "0x1850A8710")]
		public JCIEDAHJMHK(EntityManager FAIGBHOGMGE, LKOEHOGMIBD<T> FAFDCMPBBMD, NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x47F3850", Offset = "0x47F2050", VA = "0x1847F3850")]
		public JCIEDAHJMHK<T> KFPOPIJHFBP()
		{
			return default(JCIEDAHJMHK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x50A8590", Offset = "0x50A6D90", VA = "0x1850A8590")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly BMELPJIFPCL LGKGFAKAIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ANNCKEJGCIP NHOKFEFDEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IKNFGAJFNPF JJHNEOMPFBN;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8195680", Offset = "0x8193E80", VA = "0x188195680", Slot = "15")]
	public override void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8197360", Offset = "0x8195B60", VA = "0x188197360")]
	public void PBOFMINNFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x81961F0", Offset = "0x81949F0", VA = "0x1881961F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8193C50", Offset = "0x8192450", VA = "0x188193C50")]
	private void EPIFKJLLMHM(GHBKNPCKMOA ILBALOOKKCP, Mesh[] IEIEGKJHFNE, NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x39E7000", Offset = "0x39E5800", VA = "0x1839E7000")]
	private JCIEDAHJMHK<T> AFBMFDANDJH<T>(LKOEHOGMIBD<T> FAFDCMPBBMD, NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI) where T : struct
	{
		return default(JCIEDAHJMHK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x81951F0", Offset = "0x81939F0", VA = "0x1881951F0")]
	private void GBKINGCFGOH(Transform MJNLMOPPION, NativeArray<DOMNKGOALBC> NOFOFGMDBEJ, FJODPEEPKJK<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8192820", Offset = "0x8191020", VA = "0x188192820")]
	private void DHHJHFENAFJ(Transform MJNLMOPPION, NativeArray<HMJCANFBGEN> HDECLLOOMHJ, FJODPEEPKJK<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8194DF0", Offset = "0x81935F0", VA = "0x188194DF0")]
	private void FJCJJAHGMGF(Transform MJNLMOPPION, NativeArray<LINIILKPLJO> EGEJBFMOPLG, FJODPEEPKJK<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8195C60", Offset = "0x8194460", VA = "0x188195C60")]
	private void LHAKKPCBDLN(Transform MJNLMOPPION, NativeArray<AOEFBMKHFBA> IEIEGKJHFNE, Mesh[] HJHPEDLCOEI, FJODPEEPKJK<GameObject> NFACCHLCKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x81960A0", Offset = "0x81948A0", VA = "0x1881960A0")]
	private static void MIOJNOFMBIK(NativeParallelHashSet<Entity> EFHAKLBGNAC, NativeParallelHashSet<Entity> ELEHLPGILIO, NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8194D30", Offset = "0x8193530", VA = "0x188194D30")]
	private static void EPNMMGIBLKO(NativeList<Entity> NFJJCCDFOPE, NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81930E0", Offset = "0x81918E0", VA = "0x1881930E0")]
	private NativeParallelHashMap<Entity, BJEHAEJKINN> EPBEPONBFHK(IKNFGAJFNPF.FHBKCAECBNA CKJCBDKEOPI, CJKDKEAFMME<AHKOAJDIMHO> FNAPNCFPLEJ, List<GameObject> NFACCHLCKJK)
	{
		return default(NativeParallelHashMap<Entity, BJEHAEJKINN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8195580", Offset = "0x8193D80", VA = "0x188195580")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IOEFCCOMJNA(Entity PHHKKBPDBDL)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8195700", Offset = "0x8193F00", VA = "0x188195700")]
	private void KAOBIPPOGCK(NativeList<Entity> FGAGPDEDCFF, NativeList<Entity> MMAFDGCNOIK, NativeParallelHashMap<Entity, BJEHAEJKINN> NBHAFDOJGHL, NativeList<OFIADOPPLCJ> HCFJPFLAKHG, NativeList<KKEDALOMPGI> ACKEIIDIDHL, NativeList<JILFHBIAHBO> NDABHIANMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8192CF0", Offset = "0x81914F0", VA = "0x188192CF0")]
	private void DNFOLBMBENN(NativeList<Entity> EFHAKLBGNAC, NativeList<Entity> APIDGJJNDDH, NativeParallelHashMap<Entity, BJEHAEJKINN> NBHAFDOJGHL, NativeList<EEDFNFMOFKF> NPOIBJBPHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x818D970", Offset = "0x818C170", VA = "0x18818D970")]
	public GMFDNOFOMDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GENOAEIMFBC : FOJCGJEAGJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS AFPDKPEENFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly MGMNCEJOGLO MJNLMOPPION;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject AFKFEIMJKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS HPMKBLJKBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x81917D0", Offset = "0x818FFD0", VA = "0x1881917D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 MPIMFLBGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x81919F0", Offset = "0x81901F0", VA = "0x1881919F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 HCCCCOIGFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8191A40", Offset = "0x8190240", VA = "0x188191A40", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 LBAKLGBPAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x81919A0", Offset = "0x81901A0", VA = "0x1881919A0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x81918B0", Offset = "0x81900B0", VA = "0x1881918B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion DCIADBFILGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8191B30", Offset = "0x8190330", VA = "0x188191B30", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8191A90", Offset = "0x8190290", VA = "0x188191A90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 GPIFMOAPJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8191950", Offset = "0x8190150", VA = "0x188191950", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 HJBEIDKMECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8191900", Offset = "0x8190100", VA = "0x188191900", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 OEMGHJIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8191AE0", Offset = "0x81902E0", VA = "0x188191AE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8191B80", Offset = "0x8190380", VA = "0x188191B80")]
	public GENOAEIMFBC(UniformTRS AFPDKPEENFE, MGMNCEJOGLO MJNLMOPPION)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IBGHMDFEIGG : GENOAEIMFBC, OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float BJBPNGPOJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 JLFJDCJFBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly OCHABKGPDJF PPOBOACOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MGEEHPEJAKN HGFCNJJMHME;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private HOAIPFDEDJB KFINLLBCOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x819C570", Offset = "0x819AD70", VA = "0x18819C570", Slot = "17")]
		get
		{
			return default(HOAIPFDEDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS AOJEBHMHDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x819C610", Offset = "0x819AE10", VA = "0x18819C610", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float KBEMHPKEING
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC86040", Offset = "0xC84840", VA = "0x180C86040", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 CFCDELHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x819C5C0", Offset = "0x819ADC0", VA = "0x18819C5C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private OCHABKGPDJF ACHBPFEDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xEE5350", Offset = "0xEE3B50", VA = "0x180EE5350", Slot = "21")]
		get
		{
			return default(OCHABKGPDJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MGEEHPEJAKN BLFDCFFAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1446190", Offset = "0x1444990", VA = "0x181446190", Slot = "22")]
		get
		{
			return default(MGEEHPEJAKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool NJJDFPJALMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BIGENMIIGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x819C6F0", Offset = "0x819AEF0", VA = "0x18819C6F0")]
	protected IBGHMDFEIGG(UniformTRS AFPDKPEENFE, MGMNCEJOGLO MJNLMOPPION, float BJBPNGPOJFB, float3 JLFJDCJFBJO, OCHABKGPDJF PPOBOACOKGP, MGEEHPEJAKN HGFCNJJMHME)
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
public abstract class BBEOHMKJACI : FOJCGJEAGJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly BMGFKKCFMCO BDGEMDMFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected MGMNCEJOGLO FNEEDJKOJML
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x11AF580", Offset = "0x11ADD80", VA = "0x1811AF580")]
		get
		{
			return default(MGMNCEJOGLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity JDCDJCPFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x818CF80", Offset = "0x818B780", VA = "0x18818CF80")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected IPIPLKEIAHG CJNOHKMKOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x818C410", Offset = "0x818AC10", VA = "0x18818C410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected AENKGANHCMH EKDCHCNMKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x818C900", Offset = "0x818B100", VA = "0x18818C900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected HJKEFICBHPD MBJIMADJFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x818C960", Offset = "0x818B160", VA = "0x18818C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject AFKFEIMJKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x818CD90", Offset = "0x818B590", VA = "0x18818CD90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS HPMKBLJKBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x11EA810", Offset = "0x11E9010", VA = "0x1811EA810", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 MPIMFLBGCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x818C9F0", Offset = "0x818B1F0", VA = "0x18818C9F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 HCCCCOIGFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x818CAE0", Offset = "0x818B2E0", VA = "0x18818CAE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 LBAKLGBPAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x818C7D0", Offset = "0x818AFD0", VA = "0x18818C7D0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x818C420", Offset = "0x818AC20", VA = "0x18818C420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion DCIADBFILGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x818CFA0", Offset = "0x818B7A0", VA = "0x18818CFA0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x818CC90", Offset = "0x818B490", VA = "0x18818CC90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 GPIFMOAPJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x818C6E0", Offset = "0x818AEE0", VA = "0x18818C6E0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 HJBEIDKMECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x818C520", Offset = "0x818AD20", VA = "0x18818C520", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 OEMGHJIPLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x818CDC0", Offset = "0x818B5C0", VA = "0x18818CDC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xE69310", Offset = "0xE67B10", VA = "0x180E69310")]
	protected BBEOHMKJACI(BMGFKKCFMCO NHDNPGNDBND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x818CC60", Offset = "0x818B460", VA = "0x18818CC60")]
	public static HOAIPFDEDJB KEINEINMKGA(BBEOHMKJACI ODKLOJBBLOI)
	{
		return default(HOAIPFDEDJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LBDDENGGEOI
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x81AC400", Offset = "0x81AAC00", VA = "0x1881AC400")]
	public static void HKEBDEBCCPA(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AKGFEKKOOMA
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x81AB7D0", Offset = "0x81A9FD0", VA = "0x1881AB7D0")]
	public static void LGOGLOPELFC(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE, EKIIKOCIIMI NBOBNMDPDOA, IPIPLKEIAHG OKNIDGHPEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x81ABBE0", Offset = "0x81AA3E0", VA = "0x1881ABBE0")]
	public static void MOKBLHLCAFG(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE, EKIIKOCIIMI NBOBNMDPDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x81AB790", Offset = "0x81A9F90", VA = "0x1881AB790")]
	public static NativeList<Entity> GBCALLLMDKJ(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x81ABEF0", Offset = "0x81AA6F0", VA = "0x1881ABEF0")]
	public static NativeList<Entity> NFICHDKCHCG(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x81AB530", Offset = "0x81A9D30", VA = "0x1881AB530")]
	private static NativeList<Entity> GBCALLLMDKJ(NativeArray<Entity> EFHAKLBGNAC, EntityManager FAIGBHOGMGE, bool JLJFKALEADO)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class LHGBFEIAIID : BBEOHMKJACI, OMPPFNFJGFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float BJBPNGPOJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 JLFJDCJFBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private OCHABKGPDJF PPOBOACOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MGEEHPEJAKN HGFCNJJMHME;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager BAGCDNKPGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x81AC950", Offset = "0x81AB150", VA = "0x1881AC950")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MGOAOGOOHDM IAJPEJHMHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x81AC730", Offset = "0x81AAF30", VA = "0x1881AC730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData GOFBJOBABMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x81AC640", Offset = "0x81AAE40", VA = "0x1881AC640")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private HOAIPFDEDJB KFINLLBCOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x818CC60", Offset = "0x818B460", VA = "0x18818CC60", Slot = "17")]
		get
		{
			return default(HOAIPFDEDJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float KBEMHPKEING
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 CFCDELHGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x16EF480", Offset = "0x16EDC80", VA = "0x1816EF480", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private OCHABKGPDJF ACHBPFEDBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70", Slot = "21")]
		get
		{
			return default(OCHABKGPDJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private MGEEHPEJAKN BLFDCFFAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80", Slot = "22")]
		get
		{
			return default(MGEEHPEJAKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS AOJEBHMHDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x81AC920", Offset = "0x81AB120", VA = "0x1881AC920", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool BIGENMIIGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool NJJDFPJALMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x81AC9E0", Offset = "0x81AB1E0", VA = "0x1881AC9E0")]
	protected LHGBFEIAIID(BMGFKKCFMCO NHDNPGNDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x81AC790", Offset = "0x81AAF90", VA = "0x1881AC790", Slot = "26")]
	public virtual void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class EGDEADJGJNN : PLKHDOOKPMK, FHLMMIDFMKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected IPIPLKEIAHG OKNIDGHPEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CHKGGGNHDIL DLJGBAKBBOP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected EKIIKOCIIMI IKFMGEGBDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x81AC170", Offset = "0x81AA970", VA = "0x1881AC170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected DBFFJCHPNOI NBGMHLGKAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x81AC230", Offset = "0x81AAA30", VA = "0x1881AC230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool NPMHMFDEPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x81AC280", Offset = "0x81AAA80", VA = "0x1881AC280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x81AC1C0", Offset = "0x81AA9C0", VA = "0x1881AC1C0", Slot = "15")]
	public virtual void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
	protected EGDEADJGJNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EAGPBNHOPCA
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x81ABF30", Offset = "0x81AA730", VA = "0x1881ABF30")]
	public static void OPJHDGGMAAC(NativeArray<Entity> FGAGPDEDCFF, EntityManager FAIGBHOGMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3573082467
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x81ACC40", Offset = "0x81AB440", VA = "0x1881ACC40")]
	public static void IDNJGMJBKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x81ACC30", Offset = "0x81AB430", VA = "0x1881ACC30")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class HEPJJIFENBC : ContainerPropertyBag<JBFKKAIMKOP>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x81AC3A0", Offset = "0x81AABA0", VA = "0x1881AC3A0")]
	public HEPJJIFENBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class MGPNEAJDGGC : ContainerPropertyBag<GPLKDGFOLLD>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x81ACA10", Offset = "0x81AB210", VA = "0x1881ACA10")]
	public MGPNEAJDGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class FGFIJMLNDFE : ContainerPropertyBag<NHEENCAOCJH>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x81AC340", Offset = "0x81AAB40", VA = "0x1881AC340")]
	public FGFIJMLNDFE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x81ACA70", Offset = "0x81AB270", VA = "0x1881ACA70")]
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
