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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F68B90", Offset = "0x6F67590", VA = "0x186F68B90", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x197E170", Offset = "0x197CB70", VA = "0x18197E170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F9E0", Offset = "0x6F6E3E0", VA = "0x186F6F9E0")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FE70", Offset = "0x6F6E870", VA = "0x186F6FE70", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FED0", Offset = "0x6F6E8D0", VA = "0x186F6FED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CHLBOHHOHCE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F53E70", Offset = "0x6F52870", VA = "0x186F53E70")]
	public static Quaternion HDBAGEIJKNF([In] this NCHDOFMOHAA GBACLBFCEKD, [In] Vector3 GPCBHKJPHLL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KKNBLKJKLKL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F61360", Offset = "0x6F5FD60", VA = "0x186F61360")]
	public static bool CNHPFGOLIHD(this HIELDOAHLCE HJJBBOBEJCK, DMGCPCFOJCI NJDJDGCHMCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F613A0", Offset = "0x6F5FDA0", VA = "0x186F613A0")]
	public static bool GCGPANHHMKD(this HIELDOAHLCE HJJBBOBEJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F61600", Offset = "0x6F60000", VA = "0x186F61600")]
	public static bool HIKJLCGKCNB(this HIELDOAHLCE HJJBBOBEJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F62910", Offset = "0x6F61310", VA = "0x186F62910")]
	public static void KKJFENLOODN(this HIELDOAHLCE HJJBBOBEJCK, Vector3 IGHPFNEJPBG, Quaternion EKCKGIBGAHB, float JNPCONGOFCD, bool PCPPAHCGNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F61630", Offset = "0x6F60030", VA = "0x186F61630")]
	public static void ICCPIEJFIFI(this HIELDOAHLCE HJJBBOBEJCK, Vector3 IGHPFNEJPBG, Quaternion EKCKGIBGAHB, float JNPCONGOFCD, int LFMNPIJFPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F613D0", Offset = "0x6F5FDD0", VA = "0x186F613D0")]
	public static void HAFNLOGJEAL(this HIELDOAHLCE HJJBBOBEJCK, int LFMNPIJFPIO, Vector3 IGHPFNEJPBG, Quaternion EKCKGIBGAHB, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F61160", Offset = "0x6F5FB60", VA = "0x186F61160")]
	public static void AANOBCKABHC(this HIELDOAHLCE HJJBBOBEJCK, Vector3 FDPDOJLKGGK, Quaternion DKEEBCPJDLL, float JNPCONGOFCD, bool PCPPAHCGNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F61DA0", Offset = "0x6F607A0", VA = "0x186F61DA0")]
	private static void IGPKPDFJKMA(this HIELDOAHLCE HJJBBOBEJCK, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD, bool PCPPAHCGNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F611B0", Offset = "0x6F5FBB0", VA = "0x186F611B0")]
	private static void CHFJNNAGHBE(this HIELDOAHLCE HJJBBOBEJCK, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO, float EFCCFJEPHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F62A70", Offset = "0x6F61470", VA = "0x186F62A70")]
	private static void OFCLJFMEFMI(this HIELDOAHLCE HJJBBOBEJCK, int GCBONJOGHCD, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO, float EFCCFJEPHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F62A40", Offset = "0x6F61440", VA = "0x186F62A40")]
	private static bool MCOAFJABKDO(this HIELDOAHLCE HJJBBOBEJCK, int GCBONJOGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F62C50", Offset = "0x6F61650", VA = "0x186F62C50")]
	private static void PBNPCOKCEGB(this HIELDOAHLCE HJJBBOBEJCK, int GCBONJOGHCD, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO, float EFCCFJEPHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F618B0", Offset = "0x6F602B0", VA = "0x186F618B0")]
	public static Vector3 ICNHOABIFCG(this HIELDOAHLCE HJJBBOBEJCK, int GCBONJOGHCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F614F0", Offset = "0x6F5FEF0", VA = "0x186F614F0")]
	public static Quaternion HHCAOJJDPDA(this HIELDOAHLCE HJJBBOBEJCK, int GCBONJOGHCD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F626F0", Offset = "0x6F610F0", VA = "0x186F626F0")]
	public static Vector3 KGGCANEHOBK(DMGCPCFOJCI DDACCEBMBND, Vector3 PCPIJKGKPCE, Vector3? JLLIKOEKANI, Vector3 BHFFEALBPEG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface FNEGKJAHBBF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMJEEICJDOC(EntityQuery IBGCHBHCBAH, EntityManager LOJAAGLKEBK, KAKGKAMKELN BNEOBONNMCF, IDADEIFAOCM AILMBNGGMCL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface KEAINACOHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType NAJKKDFMMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCBFAIEMJKJ(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INKANMODHGF(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNHEDFHOAJN(EKJOIMJKNJH NDPAEIEANFP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class JDLGOAJLJIO : FNEGKJAHBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F60E30", Offset = "0x6F5F830", VA = "0x186F60E30", Slot = "4")]
	public void AMJEEICJDOC(EntityQuery IBGCHBHCBAH, EntityManager LOJAAGLKEBK, KAKGKAMKELN BNEOBONNMCF, IDADEIFAOCM AILMBNGGMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JDLGOAJLJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class GFEOLEJKLOA : FNEGKJAHBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EBLHPNHPCDN AIGEHILOBEC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
	public GFEOLEJKLOA(EBLHPNHPCDN AIGEHILOBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F58D20", Offset = "0x6F57720", VA = "0x186F58D20", Slot = "4")]
	public void AMJEEICJDOC(EntityQuery IBGCHBHCBAH, EntityManager LOJAAGLKEBK, KAKGKAMKELN BNEOBONNMCF, IDADEIFAOCM AILMBNGGMCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class IPHBBFJNKAK : FNEGKJAHBBF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F60C70", Offset = "0x6F5F670", VA = "0x186F60C70", Slot = "4")]
	public void AMJEEICJDOC(EntityQuery IBGCHBHCBAH, EntityManager LOJAAGLKEBK, KAKGKAMKELN BNEOBONNMCF, IDADEIFAOCM AILMBNGGMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public IPHBBFJNKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CCKEDECGGDI : KEAINACOHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType NAJKKDFMMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F53CA0", Offset = "0x6F526A0", VA = "0x186F53CA0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F53A20", Offset = "0x6F52420", VA = "0x186F53A20", Slot = "5")]
	public void MCBFAIEMJKJ(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F537A0", Offset = "0x6F521A0", VA = "0x186F537A0", Slot = "6")]
	public void INKANMODHGF(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F53750", Offset = "0x6F52150", VA = "0x186F53750", Slot = "7")]
	public void FNHEDFHOAJN(EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public CCKEDECGGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FGFMADCOBBF : KEAINACOHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType NAJKKDFMMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F578F0", Offset = "0x6F562F0", VA = "0x186F578F0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F57670", Offset = "0x6F56070", VA = "0x186F57670", Slot = "5")]
	public void MCBFAIEMJKJ(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F573F0", Offset = "0x6F55DF0", VA = "0x186F573F0", Slot = "6")]
	public void INKANMODHGF(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F573A0", Offset = "0x6F55DA0", VA = "0x186F573A0", Slot = "7")]
	public void FNHEDFHOAJN(EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FGFMADCOBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PDOAGPGHCKJ : KEAINACOHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType NAJKKDFMMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BA90", Offset = "0x6F6A490", VA = "0x186F6BA90", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B810", Offset = "0x6F6A210", VA = "0x186F6B810", Slot = "5")]
	public void MCBFAIEMJKJ(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B590", Offset = "0x6F69F90", VA = "0x186F6B590", Slot = "6")]
	public void INKANMODHGF(EntityQuery IBGCHBHCBAH, EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B540", Offset = "0x6F69F40", VA = "0x186F6B540", Slot = "7")]
	public void FNHEDFHOAJN(EKJOIMJKNJH NDPAEIEANFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public PDOAGPGHCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FEDGGOMCIMF : AMFIOFPENLE, DCJNOFKEBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KAKGKAMKELN BNEOBONNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KNMIKIGHPFE LIAACMHMDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDADEIFAOCM AILMBNGGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, FNEGKJAHBBF adapter)> FJLOFLOHECC;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F56D70", Offset = "0x6F55770", VA = "0x186F56D70", Slot = "15")]
	public virtual void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F56F80", Offset = "0x6F55980", VA = "0x186F56F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F56E00", Offset = "0x6F55800", VA = "0x186F56E00")]
	private void LDIMBNONNLC(EntityQueryDesc NGBNIFIABIJ, FNEGKJAHBBF NKKBELOHGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F571B0", Offset = "0x6F55BB0", VA = "0x186F571B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public FEDGGOMCIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class CJBBCPNPCGC : AMFIOFPENLE, DCJNOFKEBGO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class ALLFNDEIDIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery LJBKKCOLBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery FKCGDBJEFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery IGBOHIHNJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery FIMENHIJAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery IFEKNPFEHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KEAINACOHAH JAJFOPPLPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ComponentType CIPGEHMMLAH;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ALLFNDEIDIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KAKGKAMKELN BNEOBONNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IDADEIFAOCM AILMBNGGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KNMIKIGHPFE LIAACMHMDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<ALLFNDEIDIE> FJLOFLOHECC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F54290", Offset = "0x6F52C90", VA = "0x186F54290", Slot = "14")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F54A50", Offset = "0x6F53450", VA = "0x186F54A50", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F548D0", Offset = "0x6F532D0", VA = "0x186F548D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F54BE0", Offset = "0x6F535E0", VA = "0x186F54BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F53F50", Offset = "0x6F52950", VA = "0x186F53F50")]
	private void DNJDJGADEJM(ALLFNDEIDIE LBINNFILMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F54320", Offset = "0x6F52D20", VA = "0x186F54320")]
	private void LDIMBNONNLC(KEAINACOHAH JAJFOPPLPDF, ComponentType FCJNFPOLFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public CJBBCPNPCGC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct CJJHEFOGGME : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct COMPOFDBFBF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct KBGFMOFNKIJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(OCNLHHOHIKI), new string[] { })]
public class ADJMOLKAMOK : OCNLHHOHIKI, GPMHGHCNDML, DGPGGKHFMFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[DependsOn]
	private DNFPJMOKLIF OEGNHDJIDNP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F52970", Offset = "0x6F51370", VA = "0x186F52970", Slot = "4")]
	public bool OFGKFOMMAMJ(PPOLLJKPCNH FKHJJLCBKFN, PFLMKDOBNJI PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F52A50", Offset = "0x6F51450", VA = "0x186F52A50", Slot = "5")]
	private void OHIECHPGLCJ(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xC796A0", Offset = "0xC780A0", VA = "0x180C796A0", Slot = "6")]
	private void ACPNJHKHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public ADJMOLKAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(IDADEIFAOCM), new string[] { })]
public class MCJNEIEJAOO : IDADEIFAOCM
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FFJCINHIICI NLMMNJCGKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FFJCINHIICI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public MCJNEIEJAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(FDCJPDBFCPL), new string[] { })]
public class HPBKDMPCKDK : FDCJPDBFCPL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F630", Offset = "0x6F5E030", VA = "0x186F5F630", Slot = "4")]
	public void EAMOALLJLGB(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F7C0", Offset = "0x6F5E1C0", VA = "0x186F5F7C0", Slot = "5")]
	public void MNCPOJGFEOP(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F710", Offset = "0x6F5E110", VA = "0x186F5F710", Slot = "6")]
	public ComponentSystemBase IDKFIEPCGAH(World OEGNHDJIDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F760", Offset = "0x6F5E160", VA = "0x186F5F760", Slot = "7")]
	public void JHCPAMCDAJC(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F810", Offset = "0x6F5E210", VA = "0x186F5F810", Slot = "8")]
	public void NPJNDLKGEHH(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F6B0", Offset = "0x6F5E0B0", VA = "0x186F5F6B0", Slot = "9")]
	public void EFEFMDLLAJI(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F870", Offset = "0x6F5E270", VA = "0x186F5F870", Slot = "10")]
	public void PHCABCJIGLN(World OEGNHDJIDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public HPBKDMPCKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PPHAEAPPLKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public FCPANGHFKNK MFBEJOKBBNC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static PPHAEAPPLKJ OLKJPEKNNFN(FCPANGHFKNK DFEBEONMKNH)
	{
		return default(PPHAEAPPLKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KEKEMJOMMCM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KAKPHEFMJLI KGJDHKOMKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F610F0", Offset = "0x6F5FAF0", VA = "0x186F610F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KEKEMJOMMCM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KKAOIFDDHBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DHABBCCILBB : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ENGPPEFOKOD FHHHOBAACMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F562C0", Offset = "0x6F54CC0", VA = "0x186F562C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F56250", Offset = "0x6F54C50", VA = "0x186F56250", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public DHABBCCILBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OFMODIKHENB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public IHNAJDHMCNF OHCJMLMHJHB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static OFMODIKHENB OLKJPEKNNFN(IHNAJDHMCNF DFEBEONMKNH)
	{
		return default(OFMODIKHENB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GOJFPAMKJKF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public FCPANGHFKNK MFBEJOKBBNC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static GOJFPAMKJKF OLKJPEKNNFN(FCPANGHFKNK DFEBEONMKNH)
	{
		return default(GOJFPAMKJKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NFLFGBPLHIM : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BBDCBAJEODB GFNBKNBAAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F6AA60", Offset = "0x6F69460", VA = "0x186F6AA60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A9F0", Offset = "0x6F693F0", VA = "0x186F6A9F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public NFLFGBPLHIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LAGNHAMGJCG : PPAAGABNOOH, ENGPPEFOKOD, KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BHMPMJEBGAJ IIGHEKDCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA60", Offset = "0xA0B460", VA = "0x180A0CA60", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(BHMPMJEBGAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DKEEAEPKABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA50", Offset = "0xA0B450", VA = "0x180A0CA50", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 IKMOPIBCCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBF01E0", Offset = "0xBEEBE0", VA = "0x180BF01E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F63890", Offset = "0x6F62290", VA = "0x186F63890")]
	public LAGNHAMGJCG(UniformTRS OMDHFLNOPLG, FBPGMFLLCMG NNFBEGDDJKL, float IIFFHIAMFNG, float3 AOEJJNEHECH, JKHIHEHMHKN BGHPEEAKDOG, AJGLBKGCGHL MENFGHBIAJN, BHMPMJEBGAJ DGEPMMJFHDF, float3 FDDLCLJJHED, bool KCICNMBMNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F63840", Offset = "0x6F62240", VA = "0x186F63840", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CDDAMHNNKJN : PPAAGABNOOH, BBDCBAJEODB, KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<GAJGCAGDBEH> EGKOMMKPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LOLOFJOLBLA DIEJPPEOGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly float MMEHDCHKFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int NLKELANNFKH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AHBHEPAGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E40", Offset = "0x6F52840", VA = "0x186F53E40", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LJKFLGJPHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E60", Offset = "0x6F52860", VA = "0x186F53E60", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GBKAPLNBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F53E50", Offset = "0x6F52850", VA = "0x186F53E50", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JPEMPBPCNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x948EE0", Offset = "0x9478E0", VA = "0x180948EE0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float CDGCEGNEJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xBF0910", Offset = "0xBEF310", VA = "0x180BF0910", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HJBLKNOMPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB740", Offset = "0xAAA140", VA = "0x180AAB740", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F53D90", Offset = "0x6F52790", VA = "0x186F53D90")]
	public CDDAMHNNKJN(UniformTRS OMDHFLNOPLG, FBPGMFLLCMG NNFBEGDDJKL, float IIFFHIAMFNG, float3 AOEJJNEHECH, JKHIHEHMHKN BGHPEEAKDOG, AJGLBKGCGHL MENFGHBIAJN, LOLOFJOLBLA DIEJPPEOGBB, float MMEHDCHKFIO, int NLKELANNFKH, NativeArray<GAJGCAGDBEH> EGKOMMKPHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC09D30", Offset = "0xC08730", VA = "0x180C09D30", Slot = "33")]
	public NativeArray<GAJGCAGDBEH> GetNativeCurvePoints()
	{
		return default(NativeArray<GAJGCAGDBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F53CD0", Offset = "0x6F526D0", VA = "0x186F53CD0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BIBNMHAFFHB : ABBKOLFPLJN, KAKPHEFMJLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject DKNONHLGNNI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GameObject LCAKBKAANHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F531A0", Offset = "0x6F51BA0", VA = "0x186F531A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EFEILIAEILL DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F52F30", Offset = "0x6F51930", VA = "0x186F52F30", Slot = "15")]
		get
		{
			return default(EFEILIAEILL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LJFFPKIAAIL PJNCJKPNBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "16")]
		get
		{
			return default(LJFFPKIAAIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F53230", Offset = "0x6F51C30", VA = "0x186F53230")]
	public BIBNMHAFFHB(PPOLLJKPCNH FKHJJLCBKFN, bool NMEOAMJEEFC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F53030", Offset = "0x6F51A30", VA = "0x186F53030")]
	public void KJNPEJKMDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F52F30", Offset = "0x6F51930", VA = "0x186F52F30")]
	protected EFEILIAEILL JPGNCGECCIP()
	{
		return default(EFEILIAEILL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F52F00", Offset = "0x6F51900", VA = "0x186F52F00", Slot = "17")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GONLCHIIMDE : OCNNALJGBLG, ENGPPEFOKOD, KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Dictionary<JKLBMPOHFIB, BHMPMJEBGAJ> PKEHCAFHHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BHMPMJEBGAJ DGEPMMJFHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool KCICNMBMNJB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private BHMPMJEBGAJ HCPKAAOFOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA8A0", Offset = "0x8C92A0", VA = "0x1808CA8A0", Slot = "28")]
		get
		{
			return default(BHMPMJEBGAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool GBOAJPIPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC360", Offset = "0x9DAD60", VA = "0x1809DC360", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 IKMOPIBCCCA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AB00", Offset = "0x6F59500", VA = "0x186F5AB00", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5AAC0", Offset = "0x6F594C0", VA = "0x186F5AAC0")]
	public GONLCHIIMDE(PPOLLJKPCNH NLGCHPLJKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A440", Offset = "0x6F58E40", VA = "0x186F5A440", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A490", Offset = "0x6F58E90", VA = "0x186F5A490", Slot = "26")]
	public override void HIEHKMNLIKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CLHDAAPEBDG : OCNNALJGBLG, BBDCBAJEODB, KKDPGMEOOMM, IDisposable, CLCMJJDMDMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<GAJGCAGDBEH> EGKOMMKPHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool GFBLAMPNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool EFPIJBDCJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float MMEHDCHKFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int NLKELANNFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private bool GPDIPHOOHOK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool FICPPHOAKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9349D0", Offset = "0x9333D0", VA = "0x1809349D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool BMBADMJBFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8F77F0", Offset = "0x8F61F0", VA = "0x1808F77F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MJIKLIMGCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xBB0000", Offset = "0xBAEA00", VA = "0x180BB0000", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int NBLOFGPBPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA60", Offset = "0xA0B460", VA = "0x180A0CA60", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool JFHONOOAHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CA50", Offset = "0xA0B450", VA = "0x180A0CA50", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PJNLOIHCFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F55E80", Offset = "0x6F54880", VA = "0x186F55E80", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int NAPGKICDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F55AE0", Offset = "0x6F544E0", VA = "0x186F55AE0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F560C0", Offset = "0x6F54AC0", VA = "0x186F560C0")]
	public CLHDAAPEBDG(PPOLLJKPCNH NLGCHPLJKED, [Optional] NativeList<GAJGCAGDBEH> EGKOMMKPHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F55DA0", Offset = "0x6F547A0", VA = "0x186F55DA0", Slot = "26")]
	public override void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F55990", Offset = "0x6F54390", VA = "0x186F55990", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F55A80", Offset = "0x6F54480", VA = "0x186F55A80", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F56060", Offset = "0x6F54A60", VA = "0x186F56060")]
	public void PIGPPCAGGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F55BD0", Offset = "0x6F545D0", VA = "0x186F55BD0", Slot = "34")]
	public NativeArray<GAJGCAGDBEH> GetNativeCurvePoints()
	{
		return default(NativeArray<GAJGCAGDBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6F55840", Offset = "0x6F54240", VA = "0x186F55840", Slot = "35")]
	private Vector3 BEMBFABGPHE(int DLAFBLPELJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F55EA0", Offset = "0x6F548A0", VA = "0x186F55EA0", Slot = "36")]
	private Quaternion KJGOECHMIMO(int DLAFBLPELJG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F55ED0", Offset = "0x6F548D0", VA = "0x186F55ED0", Slot = "37")]
	private float LLCMFNIHOID(int DLAFBLPELJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F557D0", Offset = "0x6F541D0", VA = "0x186F557D0")]
	private NativeArray<Entity> AAJNEEDOHJI()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class OJLGMECBJAK : AAHAGPFAPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B180", Offset = "0x6F69B80", VA = "0x186F6B180", Slot = "15")]
	protected override ComponentSystemBase ANKJKINBJJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B520", Offset = "0x6F69F20", VA = "0x186F6B520", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B530", Offset = "0x6F69F30", VA = "0x186F6B530")]
	public OJLGMECBJAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[OPAKEPBLJGN]
public sealed class CJKGIJKANBK : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EntityQuery LJBKKCOLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EntityQuery FCPLEEPOKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EntityQuery LINEHEJDMFA;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F554C0", Offset = "0x6F53EC0", VA = "0x186F554C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F556C0", Offset = "0x6F540C0", VA = "0x186F556C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F55240", Offset = "0x6F53C40", VA = "0x186F55240")]
	private void GOFHFNOCJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F54E70", Offset = "0x6F53870", VA = "0x186F54E70")]
	private void CKMCMGDKNGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F55080", Offset = "0x6F53A80", VA = "0x186F55080")]
	private void DLFHNEJBDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F55460", Offset = "0x6F53E60", VA = "0x186F55460")]
	private NativeList<Entity> KNJKLMJMNHL(NativeArray<Entity> GBJFFOOALKI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F556F0", Offset = "0x6F540F0", VA = "0x186F556F0")]
	private NativeList<Entity> POJEFCMKCFM(NativeArray<Entity> GBJFFOOALKI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F551B0", Offset = "0x6F53BB0", VA = "0x186F551B0")]
	private void GEFKCJEFLJP(NativeArray<Entity> GBJFFOOALKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public CJKGIJKANBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[OPAKEPBLJGN]
public sealed class MLGHBJNMJCC : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EntityQuery IOFOEILPHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery AJOHAJNGFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery IGBOHIHNJPA;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A750", Offset = "0x6F69150", VA = "0x186F6A750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A940", Offset = "0x6F69340", VA = "0x186F6A940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F69B70", Offset = "0x6F68570", VA = "0x186F69B70")]
	private void DCFLIKCOLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F69380", Offset = "0x6F67D80", VA = "0x186F69380")]
	private void CCIAFFMFEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A360", Offset = "0x6F68D60", VA = "0x186F6A360")]
	private void FJDEHKGKBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public MLGHBJNMJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[OPAKEPBLJGN]
public sealed class EHDGBNMIGDA : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery FJIEKFDNOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery IEKBAPIKBAE;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B80", Offset = "0x6F55580", VA = "0x186F56B80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F56CD0", Offset = "0x6F556D0", VA = "0x186F56CD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F56870", Offset = "0x6F55270", VA = "0x186F56870")]
	private void DCFLIKCOLOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F56560", Offset = "0x6F54F60", VA = "0x186F56560")]
	private void CCIAFFMFEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public EHDGBNMIGDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FKIGDKCDJON : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	private struct ICKOEKCGHOA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EntityQueryInJob JKFAPGLFBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EntityQueryInJob MFJKHKINOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public EntityTypeHandle IFHBKFNBCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ReadOnly]
		public ComponentTypeHandle<GOJFPAMKJKF> GJAGCHMCHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeParallelHashSet<FCPANGHFKNK> BKGGALLNPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeList<Entity> GOLKAJPEKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> INPBJCKLEKA;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F910", Offset = "0x6F5E310", VA = "0x186F5F910", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F960", Offset = "0x6F5E360", VA = "0x186F5F960")]
		private void PDAGPHOCLCH(EntityQueryInJob IBGCHBHCBAH, [Optional] NativeList<Entity> FIKBOCCODPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private struct DOODJMBAPEP : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[ReadOnly]
		public EntityTypeHandle IFHBKFNBCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[ReadOnly]
		public ComponentTypeHandle<GOJFPAMKJKF> GJAGCHMCHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeParallelHashSet<FCPANGHFKNK> BKGGALLNPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeList<Entity> FIKBOCCODPJ;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F56310", Offset = "0x6F54D10", VA = "0x186F56310", Slot = "4")]
		public void Execute(ArchetypeChunk AAOEDAPOCBI, int FCNKMMPFGDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct GAPFLNLBCBA : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public EntityTypeHandle IFHBKFNBCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> HHBPDKHPEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ReadOnly]
		public ComponentTypeHandle<OFMODIKHENB> PPEHBPHHPOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ReadOnly]
		public ComponentDataFromEntity<PPHAEAPPLKJ> NMCNJMGAPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ComponentTypeHandle<GOJFPAMKJKF> JHLABLMJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeParallelHashSet<FCPANGHFKNK> BKGGALLNPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeList<Entity> PDMJHEMJOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeList<OFMODIKHENB> MHAFDIDKAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeList<FCPANGHFKNK> BMOGIPDNEBD;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F589F0", Offset = "0x6F573F0", VA = "0x186F589F0", Slot = "4")]
		public void Execute(ArchetypeChunk AAOEDAPOCBI, int FCNKMMPFGDA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery JKFAPGLFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery MFJKHKINOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery KLOOPIOFDBH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F583E0", Offset = "0x6F56DE0", VA = "0x186F583E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F58670", Offset = "0x6F57070", VA = "0x186F58670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F57C60", Offset = "0x6F56660", VA = "0x186F57C60")]
	private void JEHDBPLLKIJ(NativeParallelHashSet<FCPANGHFKNK> BKGGALLNPBN, int IPPGHIPMDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F57920", Offset = "0x6F56320", VA = "0x186F57920")]
	private void BEGLIEGCKOF(NativeParallelHashSet<FCPANGHFKNK> BKGGALLNPBN, int BGCCPGFANFN, int BEIKJKBDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public FKIGDKCDJON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class IFBFJIHJAMG : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EntityQuery IBGCHBHCBAH;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FA40", Offset = "0x6F5E440", VA = "0x186F5FA40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FAF0", Offset = "0x6F5E4F0", VA = "0x186F5FAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public IFBFJIHJAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OPAKEPBLJGN]
internal class ILHJBMIBOCG : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class EKFHKFNOCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EntityQuery IGFOPLCGIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EntityQuery INLIDLAIGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NLHEDANBLFC EHNMCOKNLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ComponentType DMDCPAFDIEK;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EKFHKFNOCFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private delegate void NLHEDANBLFC(NativeArray<IHNAJDHMCNF> DFEBEONMKNH, EKJOIMJKNJH NDPAEIEANFP);

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<EKFHKFNOCFO> FJLOFLOHECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private KNMIKIGHPFE LIAACMHMDDM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F60320", Offset = "0x6F5ED20", VA = "0x186F60320", Slot = "15")]
	public override void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F60560", Offset = "0x6F5EF60", VA = "0x186F60560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F606F0", Offset = "0x6F5F0F0", VA = "0x186F606F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C630", Offset = "0x2F2B030", VA = "0x182F2C630")]
	private void LDIMBNONNLC<T>(NLHEDANBLFC EHNMCOKNLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F60180", Offset = "0x6F5EB80", VA = "0x186F60180")]
	private static void CMBOFDAPAMH(NativeArray<IHNAJDHMCNF> PEIBLOJGPBB, EKJOIMJKNJH DDDDEMDLOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F603C0", Offset = "0x6F5EDC0", VA = "0x186F603C0")]
	private static void LOCGGOJAGKE(NativeArray<IHNAJDHMCNF> PEIBLOJGPBB, EKJOIMJKNJH DDDDEMDLOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F5FFE0", Offset = "0x6F5E9E0", VA = "0x186F5FFE0")]
	private static void BNMLNDFAGAJ(NativeArray<IHNAJDHMCNF> PEIBLOJGPBB, EKJOIMJKNJH DDDDEMDLOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public ILHJBMIBOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[OPAKEPBLJGN]
public sealed class MAGHBNDBJIA : AACGPCEJCHK
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EntityQuery IBGCHBHCBAH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F68F10", Offset = "0x6F67910", VA = "0x186F68F10", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct ECPNPGNOADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public UniformTRS OMDHFLNOPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public StandardRenderableVisualData MAKGILGCPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public BHMPMJEBGAJ DGEPMMJFHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 FDDLCLJJHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool KCICNMBMNJB;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct LLOBHPHEDFB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public NativeList<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeList<Entity> BOMJCKDGCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeParallelHashSet<Entity> NJHIMECOCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeList<ECPNPGNOADA> ABHPDNGPGIK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F63A10", Offset = "0x6F62410", VA = "0x186F63A10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RegisterService(typeof(GONHBFJPDDM), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class GONHBFJPDDM : DCJNOFKEBGO, CGBLBMCHGNL, GPMHGHCNDML, DGPGGKHFMFC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct BPHNAIHDOCB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly GONHBFJPDDM NNFBEGDDJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly bool BHEDGKFKEOB;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1239B30", Offset = "0x1238530", VA = "0x181239B30")]
		public BPHNAIHDOCB(GONHBFJPDDM NNFBEGDDJKL, bool BHEDGKFKEOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F53390", Offset = "0x6F51D90", VA = "0x186F53390")]
		public Queue<LHJDHAIIOHB>.Enumerator CBLJDKEPCGL()
		{
			return default(Queue<LHJDHAIIOHB>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F53440", Offset = "0x6F51E40", VA = "0x186F53440", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[DependsOn]
	private AEBGFDOLDHN KIMLIGPEGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[DependsOn]
	private EJLCLILBNHL IDLLKMCDKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private List<NativeList<GAJGCAGDBEH>> KKCKLAMCFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<IHNAJDHMCNF> EIFOPHJMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private List<(Entity, List<GameObject>)> FILEMAMOGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private FGJILCNDODG<LHJDHAIIOHB> PKFBCJKKLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private FGJILCNDODG<LLOBHPHEDFB> HNLOJLNBBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private FGJILCNDODG<EDNOKGGDANH> EKCNPOFEDKI;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F59F50", Offset = "0x6F58950", VA = "0x186F59F50", Slot = "4")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A230", Offset = "0x6F58C30", VA = "0x186F5A230")]
	public void NFFJGENPBHK(NativeList<GAJGCAGDBEH> AKGFEKCDEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F59DB0", Offset = "0x6F587B0", VA = "0x186F59DB0")]
	public void HKFOIMDCKKA(Entity NNFBEGDDJKL, [In] DCKFJKFGLDP<GameObject> NNGKOFGEECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A150", Offset = "0x6F58B50", VA = "0x186F5A150")]
	public void JCGEENINMPC(NativeList<IHNAJDHMCNF> PEIBLOJGPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F59970", Offset = "0x6F58370", VA = "0x186F59970")]
	public void EFEFMDLLAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F594C0", Offset = "0x6F57EC0", VA = "0x186F594C0")]
	public void CKPCAJCPHCO(ECLOEEPLPLF PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F59380", Offset = "0x6F57D80", VA = "0x186F59380")]
	public JobHandle APCJBBFAILJ([In] LHJDHAIIOHB FCMDIEEAPHD, JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F59420", Offset = "0x6F57E20", VA = "0x186F59420")]
	public JobHandle APCJBBFAILJ([In] LLOBHPHEDFB FCMDIEEAPHD, JobHandle GKJIOFGLJGG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E510", Offset = "0x6C9CF10", VA = "0x186C9E510")]
	public BPHNAIHDOCB IOGLJGELKJG(bool BHEDGKFKEOB)
	{
		return default(BPHNAIHDOCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A1E0", Offset = "0x6F58BE0", VA = "0x186F5A1E0")]
	public BHCAIBDFKDB<LLOBHPHEDFB> LNECHHLHEHC()
	{
		return default(BHCAIBDFKDB<LLOBHPHEDFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A370", Offset = "0x6F58D70", VA = "0x186F5A370")]
	public BHCAIBDFKDB<EDNOKGGDANH> OLLACHMKIBN()
	{
		return default(BHCAIBDFKDB<EDNOKGGDANH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F59BA0", Offset = "0x6F585A0", VA = "0x186F59BA0", Slot = "5")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A300", Offset = "0x6F58D00", VA = "0x186F5A300", Slot = "6")]
	private void OHIECHPGLCJ(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F19D60", Offset = "0x6F18760", VA = "0x186F19D60", Slot = "7")]
	private void ACPNJHKHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GONHBFJPDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NKIKKPIINKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public UniformTRS OMDHFLNOPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public StandardRenderableVisualData MAKGILGCPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public JFNNGCLCPMM DIEJPPEOGBB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LHJDHAIIOHB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> GBJFFOOALKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> BOMJCKDGCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> NJHIMECOCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<AJGMEHOLLCO> HBEBKBIAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<GAJGCAGDBEH> AKGFEKCDEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<NKIKKPIINKE> FJFLHGNFKGL;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F63930", Offset = "0x6F62330", VA = "0x186F63930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F63940", Offset = "0x6F62340", VA = "0x186F63940")]
	public void JFMJGMNFMJL(bool BHEDGKFKEOB)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : AACGPCEJCHK, DCJNOFKEBGO
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
			public NativeParallelHashMap<int, BHMPMJEBGAJ> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public NativeArray<ECPNPGNOADA> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6F5ABD0", Offset = "0x6F595D0", VA = "0x186F5ABD0", Slot = "4")]
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
			public NativeArray<GAJGCAGDBEH> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[ReadOnly]
			public NativeArray<AJGMEHOLLCO> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public NativeArray<NKIKKPIINKE> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6F5AF70", Offset = "0x6F59970", VA = "0x186F5AF70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F56110", Offset = "0x6F54B10", VA = "0x186F56110", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x6F6BD10", Offset = "0x6F6A710", VA = "0x186F6BD10")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x6F6BCC0", Offset = "0x6F6A6C0", VA = "0x186F6BCC0")]
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
				float3 OOLMGHMFBAE(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x6F687B0", Offset = "0x6F671B0", VA = "0x186F687B0", Slot = "5")]
				public float3 BBEOPDPHFHM(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x6F68B50", Offset = "0x6F67550", VA = "0x186F68B50", Slot = "4")]
				public float3 OOLMGHMFBAE(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x6F6AAB0", Offset = "0x6F694B0", VA = "0x186F6AAB0", Slot = "4")]
				public float3 OOLMGHMFBAE(quaternion rotation)
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
			public NativeArray<AJGMEHOLLCO> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<GAJGCAGDBEH> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6F5D7F0", Offset = "0x6F5C1F0", VA = "0x186F5D7F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6F5C650", Offset = "0x6F5B050", VA = "0x186F5C650")]
			private void CBKAOFBEECP(NativeList<PointSrcData> srcData, NativeList<GAJGCAGDBEH> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EBB0", Offset = "0x6F5D5B0", VA = "0x186F5EBB0")]
			public static Vector3 OLLEBHNFAHF(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EB30", Offset = "0x6F5D530", VA = "0x186F5EB30")]
			public static quaternion NFJPFFGKLIL(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6F5D5C0", Offset = "0x6F5BFC0", VA = "0x186F5D5C0")]
			private static quaternion DMHAFFLJDCG(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E0E0", Offset = "0x6F5CAE0", VA = "0x186F5E0E0")]
			private static float3 IFPCKFCODFN(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6F5D530", Offset = "0x6F5BF30", VA = "0x186F5D530")]
			private static quaternion CDLPIEKPBIL(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E8C0", Offset = "0x6F5D2C0", VA = "0x186F5E8C0")]
			private static GAJGCAGDBEH MMHDAPNJHEA(int idx, NativeList<PointSrcData> srcData)
			{
				return default(GAJGCAGDBEH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3583200", Offset = "0x3581C00", VA = "0x183583200")]
			private void LMPNPKMBHCP<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B840", Offset = "0x6F5A240", VA = "0x186F5B840")]
			private void BIKHBPJFIHF(NativeList<PointSrcData> sourcePoints, NativeList<GAJGCAGDBEH> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6F5EFC0", Offset = "0x6F5D9C0", VA = "0x186F5EFC0")]
			public static float PDOAJEMLHOF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6F5DE50", Offset = "0x6F5C850", VA = "0x186F5DE50")]
			private static quaternion FANGMFHMPOF(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E560", Offset = "0x6F5CF60", VA = "0x186F5E560")]
			private static GAJGCAGDBEH MFIJGCBGKID(PointSrcData point)
			{
				return default(GAJGCAGDBEH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E680", Offset = "0x6F5D080", VA = "0x186F5E680")]
			private static GAJGCAGDBEH MFIJGCBGKID(float3 pos, quaternion rot, float radius)
			{
				return default(GAJGCAGDBEH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E040", Offset = "0x6F5CA40", VA = "0x186F5E040")]
			private static bool GPEAEAKGFDJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E490", Offset = "0x6F5CE90", VA = "0x186F5E490")]
			private static float3 KPGBPHNBFKD(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E710", Offset = "0x6F5D110", VA = "0x186F5E710")]
			public static float3 MHLODEEEDGB(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B690", Offset = "0x6F5A090", VA = "0x186F5B690")]
			public static float3 BBEOPDPHFHM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5F140", Offset = "0x6F5DB40", VA = "0x186F5F140")]
			private static quaternion PIOCFCLGCGP(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5E2B0", Offset = "0x6F5CCB0", VA = "0x186F5E2B0")]
			private static float IHBFLFOOLPC(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x6F6E1F0", Offset = "0x6F6CBF0", VA = "0x186F6E1F0")]
			private void JBOBHBMJPHL(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E100", Offset = "0x6F6CB00", VA = "0x186F6E100", Slot = "4")]
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
			public NativeList<GAJGCAGDBEH> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F610", Offset = "0x6F6E010", VA = "0x186F6F610")]
			private void JBOBHBMJPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F600", Offset = "0x6F6E000", VA = "0x186F6F600", Slot = "4")]
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
			public NativeList<GAJGCAGDBEH> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F5B0", Offset = "0x6F6DFB0", VA = "0x186F6F5B0")]
			private void JBOBHBMJPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F5A0", Offset = "0x6F6DFA0", VA = "0x186F6F5A0", Slot = "4")]
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
			public NativeList<ECPNPGNOADA> data;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B2C0", Offset = "0x6F59CC0", VA = "0x186F5B2C0")]
			private void JBOBHBMJPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B2B0", Offset = "0x6F59CB0", VA = "0x186F5B2B0", Slot = "4")]
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
			public NativeList<AJGMEHOLLCO> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NativeList<NKIKKPIINKE> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B490", Offset = "0x6F59E90", VA = "0x186F5B490")]
			private void JBOBHBMJPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B480", Offset = "0x6F59E80", VA = "0x186F5B480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F6F180", Offset = "0x6F6DB80", VA = "0x186F6F180")]
			private void JBOBHBMJPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6F6F170", Offset = "0x6F6DB70", VA = "0x186F6F170", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly KLEHBGEJMBN log;

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
		private OLJAKCKAJLF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private AEBGFDOLDHN objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private GONHBFJPDDM bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private DJDNLFJJGEL ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CC60", Offset = "0x6F6B660", VA = "0x186F6CC60", Slot = "15")]
		public override void InitReferences(POGCJGLPEEP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E800", Offset = "0x6F6D200", VA = "0x186F6E800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E8F0", Offset = "0x6F6D2F0", VA = "0x186F6E8F0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E950", Offset = "0x6F6D350", VA = "0x186F6E950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C960", Offset = "0x6F6B360", VA = "0x186F6C960")]
		private JobHandle HINAJPMEDJA(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D890", Offset = "0x6F6C290", VA = "0x186F6D890")]
		private JobHandle LMHOFAABBCB(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C820", Offset = "0x6F6B220", VA = "0x186F6C820")]
		private JobHandle MHOPIMCKBDN(NativeArray<int> pointCount, NativeList<GAJGCAGDBEH> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C8C0", Offset = "0x6F6B2C0", VA = "0x186F6C8C0")]
		private JobHandle HDIBKLDBCDK(NativeList<GAJGCAGDBEH> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EA60", Offset = "0x6F6D460", VA = "0x186F6EA60")]
		private JobHandle PCPJIIKFDBD(EntityQuery query, NativeList<AJGMEHOLLCO> splinePointRanges, NativeList<GAJGCAGDBEH> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E2D0", Offset = "0x6F6CCD0", VA = "0x186F6E2D0")]
		private JobHandle MCAPNGNLFLD(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E500", Offset = "0x6F6CF00", VA = "0x186F6E500")]
		private JobHandle NMAAMFJMBPP(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D200", Offset = "0x6F6BC00", VA = "0x186F6D200")]
		private JobHandle LBFJHPMPCEM(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<ECPNPGNOADA> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C480", Offset = "0x6F6AE80", VA = "0x186F6C480")]
		private JobHandle DBHFIKBEELI(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<AJGMEHOLLCO> splinePointRanges, [Out] NativeList<NKIKKPIINKE> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CD40", Offset = "0x6F6B740", VA = "0x186F6CD40")]
		private JobHandle JGMBHPIGHNF(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BD30", Offset = "0x6F6A730", VA = "0x186F6BD30")]
		private JobHandle BLBAKKPCFDL(EntityQuery query, NativeList<ECPNPGNOADA> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D470", Offset = "0x6F6BE70", VA = "0x186F6D470")]
		private static NativeParallelHashMap<int, BHMPMJEBGAJ> LKLOLEGGCLH()
		{
			return default(NativeParallelHashMap<int, BHMPMJEBGAJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6CF50", Offset = "0x6F6B950", VA = "0x186F6CF50")]
		private JobHandle KLLFNBPGKKC(EntityQuery query, NativeList<AJGMEHOLLCO> splinePointRanges, NativeList<GAJGCAGDBEH> splinePointData, NativeList<NKIKKPIINKE> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C740", Offset = "0x6F6B140", VA = "0x186F6C740")]
		private JobHandle DPFMADELAKM(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C820", Offset = "0x6F6B220", VA = "0x186F6C820")]
		private JobHandle DPGOGCIDBPC(NativeArray<int> pointCount, NativeList<GAJGCAGDBEH> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C8C0", Offset = "0x6F6B2C0", VA = "0x186F6C8C0")]
		private JobHandle LAJJDNDPLND(NativeList<GAJGCAGDBEH> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C390", Offset = "0x6F6AD90", VA = "0x186F6C390")]
		private JobHandle DAJAMGAFHOJ(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<ECPNPGNOADA> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E3F0", Offset = "0x6F6CDF0", VA = "0x186F6E3F0")]
		private JobHandle NEKDNKPJDCB(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<AJGMEHOLLCO> ranges, NativeList<NKIKKPIINKE> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C240", Offset = "0x6F6AC40", VA = "0x186F6C240")]
		private JobHandle BOMCLEHPIPO(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E5F0", Offset = "0x6F6CFF0", VA = "0x186F6E5F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JODLAPLGIOI : AMFIOFPENLE, DCJNOFKEBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public GONHBFJPDDM KJJDLOILCDG;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6F61080", Offset = "0x6F5FA80", VA = "0x186F61080", Slot = "14")]
	public void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6F610D0", Offset = "0x6F5FAD0", VA = "0x186F610D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public JODLAPLGIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class LMHFKHONNDF : AACGPCEJCHK, DCJNOFKEBGO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct HBADNNDAKGL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EntityManager LOJAAGLKEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private GLKBGBPHHMJ<T> CONAELBKADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int GCBONJOGHCD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4171240", Offset = "0x416FC40", VA = "0x184171240")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4171D80", Offset = "0x4170780", VA = "0x184171D80")]
		public HBADNNDAKGL(EntityManager LOJAAGLKEBK, GLKBGBPHHMJ<T> CONAELBKADO, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EF30", Offset = "0x3C2D930", VA = "0x183C2EF30")]
		public HBADNNDAKGL<T> CBLJDKEPCGL()
		{
			return default(HBADNNDAKGL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4171CC0", Offset = "0x41706C0", VA = "0x184171CC0")]
		public bool JLIPANEBJLB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly KLEHBGEJMBN KANEGMAJMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private EJLCLILBNHL IDLLKMCDKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private GONHBFJPDDM KJJDLOILCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::MLMKECOAPCO FDKEAHPNOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int DDGEOECEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string CHBGJFDOLEF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6F64430", Offset = "0x6F62E30", VA = "0x186F64430", Slot = "15")]
	public override void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F68620", Offset = "0x6F67020", VA = "0x186F68620")]
	public void PHCABCJIGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F67480", Offset = "0x6F65E80", VA = "0x186F67480", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F647A0", Offset = "0x6F631A0", VA = "0x186F647A0")]
	private void JOIFLMDKDAL(EDNOKGGDANH FCMDIEEAPHD, Mesh[] ALOGMMHJILN, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1F00", Offset = "0x2FB0900", VA = "0x182FB1F00")]
	private HBADNNDAKGL<T> GCDFMNDGJJA<T>(GLKBGBPHHMJ<T> CONAELBKADO, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN) where T : struct
	{
		return default(HBADNNDAKGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F670F0", Offset = "0x6F65AF0", VA = "0x186F670F0")]
	private void OKEFBECKBPK(Transform NNFBEGDDJKL, NativeArray<PIEMCDELICN> POBFLPOKNJD, DCKFJKFGLDP<GameObject> FNJONNAFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6F63F70", Offset = "0x6F62970", VA = "0x186F63F70")]
	private void GFHOBCBCBEM(Transform NNFBEGDDJKL, NativeArray<ABPFMHBMCFD> JKKDEIJNCJJ, DCKFJKFGLDP<GameObject> FNJONNAFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F65BE0", Offset = "0x6F645E0", VA = "0x186F65BE0")]
	private void KEIMNAKPKFG(Transform NNFBEGDDJKL, NativeArray<OBAAFODGPHN> OEEHPMFEDOC, DCKFJKFGLDP<GameObject> FNJONNAFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F63AA0", Offset = "0x6F624A0", VA = "0x186F63AA0")]
	private void BGKABPCAELB(Transform NNFBEGDDJKL, NativeArray<NHBJEFHPMMN> ALOGMMHJILN, Mesh[] KJGFCKGKHFF, DCKFJKFGLDP<GameObject> FNJONNAFHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F64650", Offset = "0x6F63050", VA = "0x186F64650")]
	private static void JEKECBHPGJH(NativeParallelHashSet<Entity> GBJFFOOALKI, NativeParallelHashSet<Entity> MBJODHONPHD, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F63EB0", Offset = "0x6F628B0", VA = "0x186F63EB0")]
	private static void CFMAIDGKDKK(NativeList<Entity> HIOONLIPGID, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6F65FD0", Offset = "0x6F649D0", VA = "0x186F65FD0")]
	private NativeParallelHashMap<Entity, PPHAEAPPLKJ> KHKGGJNKPDA(GONHBFJPDDM.BPHNAIHDOCB GJHAHBBKJJO, BHCAIBDFKDB<LLOBHPHEDFB> POPAEHFNLNL, NativeArray<EntityRemapUtility.EntityRemapInfo> EDIDNKAAKIN, List<GameObject> FNJONNAFHJG)
	{
		return default(NativeParallelHashMap<Entity, PPHAEAPPLKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6F66B50", Offset = "0x6F65550", VA = "0x186F66B50")]
	private void NIJKDIGHNNK(NativeList<Entity> BJBDPNGLKBP, NativeList<Entity> KPPCAKCPPKF, NativeParallelHashMap<Entity, PPHAEAPPLKJ> HDDLIENFHPN, NativeList<AJGMEHOLLCO> DELKMEBILBE, NativeList<GAJGCAGDBEH> HACAIAIGJEH, NativeList<NKIKKPIINKE> KKCKLAMCFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F657C0", Offset = "0x6F641C0", VA = "0x186F657C0")]
	private void KBGHJHEIMHM(NativeList<Entity> GBJFFOOALKI, NativeList<Entity> BOMJCKDGCFK, NativeParallelHashMap<Entity, PPHAEAPPLKJ> HDDLIENFHPN, NativeList<ECPNPGNOADA> ABHPDNGPGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	public LMHFKHONNDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class AHFMFDOLGPG : JHLCCKFJMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly UniformTRS OMDHFLNOPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FBPGMFLLCMG NNFBEGDDJKL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject CPLCDJKKDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS GGFNOHHIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6F52DD0", Offset = "0x6F517D0", VA = "0x186F52DD0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 KBGNEBDIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6F52D30", Offset = "0x6F51730", VA = "0x186F52D30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 MMNFKEDNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6F52C90", Offset = "0x6F51690", VA = "0x186F52C90", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 BNHIMMGBLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6F52B50", Offset = "0x6F51550", VA = "0x186F52B50", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6F52BA0", Offset = "0x6F515A0", VA = "0x186F52BA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion OKLIAABLEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6F52B00", Offset = "0x6F51500", VA = "0x186F52B00", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6F52BF0", Offset = "0x6F515F0", VA = "0x186F52BF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 IHBELECAGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6F52CE0", Offset = "0x6F516E0", VA = "0x186F52CE0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 FEPHBJKEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6F52C40", Offset = "0x6F51640", VA = "0x186F52C40", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 LBBHJJIOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6F52D80", Offset = "0x6F51780", VA = "0x186F52D80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6F52EB0", Offset = "0x6F518B0", VA = "0x186F52EB0")]
	public AHFMFDOLGPG(UniformTRS OMDHFLNOPLG, FBPGMFLLCMG NNFBEGDDJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class PPAAGABNOOH : AHFMFDOLGPG, KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float IIFFHIAMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly float3 AOEJJNEHECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JKHIHEHMHKN BGHPEEAKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly AJGLBKGCGHL MENFGHBIAJN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private EFEILIAEILL NKKIBGKCGNP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BB10", Offset = "0x6F6A510", VA = "0x186F6BB10", Slot = "17")]
		get
		{
			return default(EFEILIAEILL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS DDOHGGELCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BB60", Offset = "0x6F6A560", VA = "0x186F6BB60", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float AANGMKAGOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5A00", VA = "0x180AA7000", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 INCGEHEEKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BAC0", Offset = "0x6F6A4C0", VA = "0x186F6BAC0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JKHIHEHMHKN PHKIMGODLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9E5040", Offset = "0x9E3A40", VA = "0x1809E5040", Slot = "21")]
		get
		{
			return default(JKHIHEHMHKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private AJGLBKGCGHL MNJIBNDGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xE56AD0", Offset = "0xE554D0", VA = "0x180E56AD0", Slot = "22")]
		get
		{
			return default(AJGLBKGCGHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool OPCCODKOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EBPONCAGDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BC40", Offset = "0x6F6A640", VA = "0x186F6BC40")]
	protected PPAAGABNOOH(UniformTRS OMDHFLNOPLG, FBPGMFLLCMG NNFBEGDDJKL, float IIFFHIAMFNG, float3 AOEJJNEHECH, JKHIHEHMHKN BGHPEEAKDOG, AJGLBKGCGHL MENFGHBIAJN)
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
public static class KNPDADLBNFI
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F62EE0", Offset = "0x6F618E0", VA = "0x186F62EE0")]
	public static void CDNMFFEMMMC(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK, ECLOEEPLPLF AGGOFBHALBM, AEBGFDOLDHN JCIKLIGDKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F63310", Offset = "0x6F61D10", VA = "0x186F63310")]
	public static void PFMLBPCLADC(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK, ECLOEEPLPLF AGGOFBHALBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6F63590", Offset = "0x6F61F90", VA = "0x186F63590")]
	public static NativeList<Entity> POJEFCMKCFM(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6F632D0", Offset = "0x6F61CD0", VA = "0x186F632D0")]
	public static NativeList<Entity> KNJKLMJMNHL(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F635D0", Offset = "0x6F61FD0", VA = "0x186F635D0")]
	private static NativeList<Entity> POJEFCMKCFM(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK, bool DPFFIGFNIHH)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class ABBKOLFPLJN : JHLCCKFJMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly PPOLLJKPCNH ICDADLEHPCK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected FBPGMFLLCMG HGPJBMDALGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC8BB60", Offset = "0xC8A560", VA = "0x180C8BB60")]
		get
		{
			return default(FBPGMFLLCMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6F52920", Offset = "0x6F51320", VA = "0x186F52920")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected AEBGFDOLDHN NKGNFCMDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F52550", Offset = "0x6F50F50", VA = "0x186F52550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected HFLBOJLEJNH IKJFABGIGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F52700", Offset = "0x6F51100", VA = "0x186F52700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected EOCIEIGBAMG DPAJIPHDAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6F52330", Offset = "0x6F50D30", VA = "0x186F52330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject CPLCDJKKDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6F52300", Offset = "0x6F50D00", VA = "0x186F52300", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS GGFNOHHIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xCB4DB0", Offset = "0xCB37B0", VA = "0x180CB4DB0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 KBGNEBDIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6F52630", Offset = "0x6F51030", VA = "0x186F52630", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 MMNFKEDNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6F523C0", Offset = "0x6F50DC0", VA = "0x186F523C0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 BNHIMMGBLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F51E50", Offset = "0x6F50850", VA = "0x186F51E50", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F51F20", Offset = "0x6F50920", VA = "0x186F51F20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion OKLIAABLEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F51D30", Offset = "0x6F50730", VA = "0x186F51D30", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F52030", Offset = "0x6F50A30", VA = "0x186F52030", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 IHBELECAGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F52560", Offset = "0x6F50F60", VA = "0x186F52560", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 FEPHBJKEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F52140", Offset = "0x6F50B40", VA = "0x186F52140", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 LBBHJJIOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F52760", Offset = "0x6F51160", VA = "0x186F52760", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x993E10", Offset = "0x992810", VA = "0x180993E10")]
	protected ABBKOLFPLJN(PPOLLJKPCNH NLGCHPLJKED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F52940", Offset = "0x6F51340", VA = "0x186F52940")]
	public static EFEILIAEILL OLKJPEKNNFN(ABBKOLFPLJN FOFGABNNIOJ)
	{
		return default(EFEILIAEILL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GLAHKPOJPJA
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6F58F00", Offset = "0x6F57900", VA = "0x186F58F00")]
	public static void GHILHDEIGGD(NativeArray<Entity> GBJFFOOALKI, EntityManager LOJAAGLKEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class OCNNALJGBLG : ABBKOLFPLJN, KKDPGMEOOMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float IIFFHIAMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 AOEJJNEHECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JKHIHEHMHKN BGHPEEAKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private AJGLBKGCGHL MENFGHBIAJN;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager IJNFGOPBOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AF60", Offset = "0x6F69960", VA = "0x186F6AF60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DNFPJMOKLIF OHFDDDBIGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B0B0", Offset = "0x6F69AB0", VA = "0x186F6B0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData EMHBMDBJNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B020", Offset = "0x6F69A20", VA = "0x186F6B020")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private EFEILIAEILL NKKIBGKCGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F52940", Offset = "0x6F51340", VA = "0x186F52940", Slot = "17")]
		get
		{
			return default(EFEILIAEILL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float AANGMKAGOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAA37C0", Offset = "0xAA21C0", VA = "0x180AA37C0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 INCGEHEEKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x10943B0", Offset = "0x1092DB0", VA = "0x1810943B0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JKHIHEHMHKN PHKIMGODLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0", Slot = "21")]
		get
		{
			return default(JKHIHEHMHKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private AJGLBKGCGHL MNJIBNDGFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xC6F620", Offset = "0xC6E020", VA = "0x180C6F620", Slot = "22")]
		get
		{
			return default(AJGLBKGCGHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS DDOHGGELCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCB4DB0", Offset = "0xCB37B0", VA = "0x180CB4DB0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EBPONCAGDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x964220", Offset = "0x962C20", VA = "0x180964220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9630A0", Offset = "0x961AA0", VA = "0x1809630A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool OPCCODKOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B140", Offset = "0x6F69B40", VA = "0x186F6B140")]
	protected OCNNALJGBLG(PPOLLJKPCNH NLGCHPLJKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ADD0", Offset = "0x6F697D0", VA = "0x186F6ADD0", Slot = "26")]
	public virtual void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class AACGPCEJCHK : AMFIOFPENLE, DCJNOFKEBGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected AEBGFDOLDHN JCIKLIGDKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private KAKGKAMKELN BNEOBONNMCF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected ECLOEEPLPLF IBCNENNALNF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F51C20", Offset = "0x6F50620", VA = "0x186F51C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected EKJOIMJKNJH NDDPIFHLKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F51C70", Offset = "0x6F50670", VA = "0x186F51C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6F51CC0", Offset = "0x6F506C0", VA = "0x186F51CC0", Slot = "15")]
	public virtual void InitReferences(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x249C790", Offset = "0x249B190", VA = "0x18249C790")]
	protected AACGPCEJCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class GNFJCDENAPO
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6F59140", Offset = "0x6F57B40", VA = "0x186F59140")]
	public static void HENJINFNFAD(NativeArray<Entity> BJBDPNGLKBP, EntityManager LOJAAGLKEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__643610571
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FFE0", Offset = "0x6F6E9E0", VA = "0x186F6FFE0")]
	public static void KHCKEMENAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FFD0", Offset = "0x6F6E9D0", VA = "0x186F6FFD0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class FPBIFEAKOIF : ContainerPropertyBag<KEKEMJOMMCM>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6F58990", Offset = "0x6F57390", VA = "0x186F58990")]
	public FPBIFEAKOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class AEKJOIFFNJK : ContainerPropertyBag<DHABBCCILBB>
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6F52AA0", Offset = "0x6F514A0", VA = "0x186F52AA0")]
	public AEKJOIFFNJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class LOJPIHALENB : ContainerPropertyBag<NFLFGBPLHIM>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6F68750", Offset = "0x6F67150", VA = "0x186F68750")]
	public LOJPIHALENB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EFB0", Offset = "0x6F6D9B0", VA = "0x186F6EFB0")]
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
