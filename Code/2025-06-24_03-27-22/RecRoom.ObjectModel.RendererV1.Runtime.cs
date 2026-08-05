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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD4D0", Offset = "0x7FCC0D0", VA = "0x187FCD4D0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F81230", Offset = "0x7F7FE30", VA = "0x187F81230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5FD0", Offset = "0x7FD4BD0", VA = "0x187FD5FD0")]
		private void HNLBFOBJPNI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6570", Offset = "0x7FD5170", VA = "0x187FD6570", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FD65D0", Offset = "0x7FD51D0", VA = "0x187FD65D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FFMKAGGLMHC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB910", Offset = "0x7FBA510", VA = "0x187FBB910")]
	public static Quaternion MJIGLDNIHGL([In] this KJCPBHFFDCI MLBPOBOGEJN, [In] Vector3 HLIFPOIPBBB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CBGFIIBNNHE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8BE0", Offset = "0x7FB77E0", VA = "0x187FB8BE0")]
	public static bool BBEGFLKINGL(this MGHMHMMMJHA GIIDJBGBEKP, DAMCLPLILIH FCCNKGNGPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB96A0", Offset = "0x7FB82A0", VA = "0x187FB96A0")]
	public static bool BNDHBODFNPE(this MGHMHMMMJHA GIIDJBGBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9960", Offset = "0x7FB8560", VA = "0x187FB9960")]
	public static bool EAALNIGFNEM(this MGHMHMMMJHA GIIDJBGBEKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8C20", Offset = "0x7FB7820", VA = "0x187FB8C20")]
	public static void BGGKDGEEFMB(this MGHMHMMMJHA GIIDJBGBEKP, Vector3 AFCGIDGIBNF, Quaternion PMLFJIKNGDP, float HPDHPFDMAAO, bool ANHBBDEMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA1C0", Offset = "0x7FB8DC0", VA = "0x187FBA1C0")]
	public static void MDENAADACOC(this MGHMHMMMJHA GIIDJBGBEKP, Vector3 AFCGIDGIBNF, Quaternion PMLFJIKNGDP, float HPDHPFDMAAO, int LDNIGGFNHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA620", Offset = "0x7FB9220", VA = "0x187FBA620")]
	public static void NEGHDCJCKGI(this MGHMHMMMJHA GIIDJBGBEKP, int LDNIGGFNHKH, Vector3 AFCGIDGIBNF, Quaternion PMLFJIKNGDP, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9F90", Offset = "0x7FB8B90", VA = "0x187FB9F90")]
	public static void FJJHCLEBKCM(this MGHMHMMMJHA GIIDJBGBEKP, Vector3 DIBGONDIHEF, Quaternion LBJNLJOGKAA, float HPDHPFDMAAO, bool ANHBBDEMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8D50", Offset = "0x7FB7950", VA = "0x187FB8D50")]
	private static void BLJABGHPHGJ(this MGHMHMMMJHA GIIDJBGBEKP, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO, bool ANHBBDEMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9FE0", Offset = "0x7FB8BE0", VA = "0x187FB9FE0")]
	private static void JABEKHDLIBP(this MGHMHMMMJHA GIIDJBGBEKP, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL, float JMLBMCMPHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA440", Offset = "0x7FB9040", VA = "0x187FBA440")]
	private static void MJILCFJEFDM(this MGHMHMMMJHA GIIDJBGBEKP, int EMMACFPOKFB, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL, float JMLBMCMPHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA190", Offset = "0x7FB8D90", VA = "0x187FBA190")]
	private static bool JDBNJCPDMFM(this MGHMHMMMJHA GIIDJBGBEKP, int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FB96D0", Offset = "0x7FB82D0", VA = "0x187FB96D0")]
	private static void CNFFDLIOFJF(this MGHMHMMMJHA GIIDJBGBEKP, int EMMACFPOKFB, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL, float JMLBMCMPHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9AA0", Offset = "0x7FB86A0", VA = "0x187FB9AA0")]
	public static Vector3 FHOEJGACGPA(this MGHMHMMMJHA GIIDJBGBEKP, int EMMACFPOKFB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FB9990", Offset = "0x7FB8590", VA = "0x187FB9990")]
	public static Quaternion EDOHBCJOLIA(this MGHMHMMMJHA GIIDJBGBEKP, int EMMACFPOKFB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FB89C0", Offset = "0x7FB75C0", VA = "0x187FB89C0")]
	public static Vector3 AOBJBJLNMFL(DAMCLPLILIH GEFKHBLJENB, Vector3 IIBJECFMAJC, Vector3? CNCBIPJKFID, Vector3 GINDDCIIAAF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface LHEBFHGLHEF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGAGDIBJDAG(EntityQuery KPNAGIAKBLA, EntityManager HGAKBEIGHGE, KLONDPBKHOO BNLGIODIEPM, NAPFPJCKNHK KIGGMGMMJHC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface KFICHCBGGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType MGDAAABJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEHMCPFFPNO(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLHNGBIHFHD(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEACCKBBAND(FOCKMLOJPND PPEEJMHIONF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class JPEEOPEPKBE : LHEBFHGLHEF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA650", Offset = "0x7FC9250", VA = "0x187FCA650", Slot = "4")]
	public void LGAGDIBJDAG(EntityQuery KPNAGIAKBLA, EntityManager HGAKBEIGHGE, KLONDPBKHOO BNLGIODIEPM, NAPFPJCKNHK KIGGMGMMJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JPEEOPEPKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class IPHKCCKKGJD : LHEBFHGLHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JOMANKOGPON JGEAKKMMJAI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
	public IPHKCCKKGJD(JOMANKOGPON JGEAKKMMJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9070", Offset = "0x7FC7C70", VA = "0x187FC9070", Slot = "4")]
	public void LGAGDIBJDAG(EntityQuery KPNAGIAKBLA, EntityManager HGAKBEIGHGE, KLONDPBKHOO BNLGIODIEPM, NAPFPJCKNHK KIGGMGMMJHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class PAMMMDJCMML : LHEBFHGLHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FD2090", Offset = "0x7FD0C90", VA = "0x187FD2090", Slot = "4")]
	public void LGAGDIBJDAG(EntityQuery KPNAGIAKBLA, EntityManager HGAKBEIGHGE, KLONDPBKHOO BNLGIODIEPM, NAPFPJCKNHK KIGGMGMMJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PAMMMDJCMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JDEMMKPADMH : KFICHCBGGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType MGDAAABJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FC97B0", Offset = "0x7FC83B0", VA = "0x187FC97B0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9530", Offset = "0x7FC8130", VA = "0x187FC9530", Slot = "5")]
	public void OEHMCPFFPNO(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FC92B0", Offset = "0x7FC7EB0", VA = "0x187FC92B0", Slot = "6")]
	public void NLHNGBIHFHD(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FC97E0", Offset = "0x7FC83E0", VA = "0x187FC97E0", Slot = "7")]
	public void PEACCKBBAND(FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JDEMMKPADMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JHBNONDOOGF : KFICHCBGGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType MGDAAABJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC9D30", Offset = "0x7FC8930", VA = "0x187FC9D30", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9AB0", Offset = "0x7FC86B0", VA = "0x187FC9AB0", Slot = "5")]
	public void OEHMCPFFPNO(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9830", Offset = "0x7FC8430", VA = "0x187FC9830", Slot = "6")]
	public void NLHNGBIHFHD(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9D60", Offset = "0x7FC8960", VA = "0x187FC9D60", Slot = "7")]
	public void PEACCKBBAND(FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public JHBNONDOOGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HONFFACNNCO : KFICHCBGGNK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType MGDAAABJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7FC43C0", Offset = "0x7FC2FC0", VA = "0x187FC43C0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4140", Offset = "0x7FC2D40", VA = "0x187FC4140", Slot = "5")]
	public void OEHMCPFFPNO(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3EC0", Offset = "0x7FC2AC0", VA = "0x187FC3EC0", Slot = "6")]
	public void NLHNGBIHFHD(EntityQuery KPNAGIAKBLA, FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FC43F0", Offset = "0x7FC2FF0", VA = "0x187FC43F0", Slot = "7")]
	public void PEACCKBBAND(FOCKMLOJPND PPEEJMHIONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public HONFFACNNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EDJHJGOLNHE : BCHHLKDMOPB, OMNICACBHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private KLONDPBKHOO BNLGIODIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HCBADEACGBJ CGHDNENEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NAPFPJCKNHK KIGGMGMMJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, LHEBFHGLHEF adapter)> PBGKCKOEGBP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB460", Offset = "0x7FBA060", VA = "0x187FBB460", Slot = "15")]
	public virtual void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB4F0", Offset = "0x7FBA0F0", VA = "0x187FBB4F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB300", Offset = "0x7FB9F00", VA = "0x187FBB300")]
	private void BGDHNGPAJJI(EntityQueryDesc HJFEKPGLBDH, LHEBFHGLHEF JHFEIJLFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB720", Offset = "0x7FBA320", VA = "0x187FBB720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
	public EDJHJGOLNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class KNAJNFPOGMN : BCHHLKDMOPB, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class FNBECMOOLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery FEOPFFFFKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HNGJONBNLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery DJPHBOBFJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AENICMMDBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery LHKGJDPOPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery HNPADGIPLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery MEDHDIJFCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KFICHCBGGNK HLFHDANFFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType ALJFBNEFPJI;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FNBECMOOLAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KLONDPBKHOO BNLGIODIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NAPFPJCKNHK KIGGMGMMJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HCBADEACGBJ CGHDNENEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<FNBECMOOLAF> PBGKCKOEGBP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBBC0", Offset = "0x7FCA7C0", VA = "0x187FCBBC0", Slot = "14")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBC50", Offset = "0x7FCA850", VA = "0x187FCBC50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FCBDD0", Offset = "0x7FCA9D0", VA = "0x187FCBDD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FCB770", Offset = "0x7FCA370", VA = "0x187FCB770")]
	private void ICHHNCNOPEC(FNBECMOOLAF AAFEIODLFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAFF0", Offset = "0x7FC9BF0", VA = "0x187FCAFF0")]
	private void BGDHNGPAJJI(KFICHCBGGNK HLFHDANFFLM, ComponentType FKODHJGMOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
	public KNAJNFPOGMN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct GHONNPCGMDE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct IGHFBJBNEFM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct FICEBFMHFHA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(NAPFPJCKNHK), new string[] { })]
public class IOJKANLCJMD : NAPFPJCKNHK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGAICHLALAG CBDHGEKHJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGAICHLALAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public IOJKANLCJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(PCCJKEOOMPO), new string[] { })]
public class CLEELJNMDGJ : PCCJKEOOMPO, LHJHKELMPGP, CBLCJDEAFID, JOOIONMMMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private DIOBJPDBJAJ CJNNELLKJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private KLONDPBKHOO BNLGIODIEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private BNNLGKNFBBF BEIHHAGEJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity MABIAKFPIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EEHGLNGJALI OOJJHMPJBEO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA740", Offset = "0x7FB9340", VA = "0x187FBA740", Slot = "4")]
	public bool DDHHIBCGBPC(GBGGLBKJJPC EAOPNGFGOCP, NPPLDKJABIP OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA820", Offset = "0x7FB9420", VA = "0x187FBA820", Slot = "5")]
	public EEHGLNGJALI IIMONHHEPBJ()
	{
		return default(EEHGLNGJALI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAAE0", Offset = "0x7FB96E0", VA = "0x187FBAAE0", Slot = "6")]
	public void JGDAKBPELOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FBABF0", Offset = "0x7FB97F0", VA = "0x187FBABF0", Slot = "7")]
	private void KKNLMKKOOCF(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1223D60", Offset = "0x1222960", VA = "0x181223D60", Slot = "8")]
	private void OLKMBFKLKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CLEELJNMDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(GJPDHMLGPKL), new string[] { })]
public class GDIPMNILANA : GJPDHMLGPKL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC750", Offset = "0x7FBB350", VA = "0x187FBC750", Slot = "4")]
	public void LGMPBLENANE(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBDC0", Offset = "0x7FBA9C0", VA = "0x187FBBDC0", Slot = "5")]
	public void DILKGCOCDPK(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBED0", Offset = "0x7FBAAD0", VA = "0x187FBBED0", Slot = "6")]
	public ComponentSystemBase HDONDECGHEM(World CJNNELLKJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBE70", Offset = "0x7FBAA70", VA = "0x187FBBE70", Slot = "7")]
	public void HDANGDEFAOF(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBD60", Offset = "0x7FBA960", VA = "0x187FBBD60", Slot = "8")]
	public void DFMNNLAFLAO(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBE10", Offset = "0x7FBAA10", VA = "0x187FBBE10", Slot = "9")]
	public void GMAKGOJBEIM(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBCF0", Offset = "0x7FBA8F0", VA = "0x187FBBCF0", Slot = "10")]
	public void CFDEFPBNJEK(World CJNNELLKJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBF20", Offset = "0x7FBAB20", VA = "0x187FBBF20", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> LGGGCGHNBKH()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GDIPMNILANA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct NNKIIMAKPGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct CGOPBBFHADM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NAIIFNFMHMG : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FLIFFCNMJBP KCDHOPDFCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE0A0", Offset = "0x7FCCCA0", VA = "0x187FCE0A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE030", Offset = "0x7FCCC30", VA = "0x187FCE030", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NAIIFNFMHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct GLAJNHGGAIN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EEHGLNGJALI IIDMJHNGGHH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GLAJNHGGAIN GHOKLFELACP(EEHGLNGJALI BEPAMKMBKNC)
	{
		return default(GLAJNHGGAIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ODKLBPLNJGH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PLLHHFOOEOI BMLFHNNKKML
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD02F0", Offset = "0x7FCEEF0", VA = "0x187FD02F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public ODKLBPLNJGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct KHMPOJNGHEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct CFKLILFGJDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PLBHNIEEDEN CCNGLPNLNMK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static CFKLILFGJDJ GHOKLFELACP(PLBHNIEEDEN BEPAMKMBKNC)
	{
		return default(CFKLILFGJDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct LIAGJEABGIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EEHGLNGJALI IIDMJHNGGHH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static LIAGJEABGIE GHOKLFELACP(EEHGLNGJALI BEPAMKMBKNC)
	{
		return default(LIAGJEABGIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDNHEOMFDJD : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BKJBENJIBKG MBDLJHAJENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB1D0", Offset = "0x7FB9DD0", VA = "0x187FBB1D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB160", Offset = "0x7FB9D60", VA = "0x187FBB160", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DDNHEOMFDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JCFDEGNNNOF : NCCCPFJMFFN, FLIFFCNMJBP, DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KPFEPBPCGON IBEBECLIJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xDCF4D0", Offset = "0xDCE0D0", VA = "0x180DCF4D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(KPFEPBPCGON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ENNGJDDIGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xCADB40", Offset = "0xCAC740", VA = "0x180CADB40", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 CIOJGHJNDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1149710", Offset = "0x1148310", VA = "0x181149710", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9210", Offset = "0x7FC7E10", VA = "0x187FC9210")]
	public JCFDEGNNNOF(UniformTRS LPDGFNHIEBD, GBGEFMIEGNI LIPFJJEAFCE, float PBHJKABEKEB, float3 CMDOGPMDMEM, JLNOJMKJPNC CJBJNGGFNMA, IIDDCNCKDDH DGPGGNNBGPD, KPFEPBPCGON CKCLCKKEEHN, float3 KAJEPGKJNHP, bool MFNJCBDPJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7FC91C0", Offset = "0x7FC7DC0", VA = "0x187FC91C0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GCBJAPGPFKH : NCCCPFJMFFN, BKJBENJIBKG, DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<PENOEPANFIA> BAFFAABICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GMHGPIGAFIH GALEDNLDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float ADMCNIEMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int DKJOAIFHFAC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BCLPPAANIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBCC0", Offset = "0x7FBA8C0", VA = "0x187FBBCC0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MOPIONDHEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBCE0", Offset = "0x7FBA8E0", VA = "0x187FBBCE0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GGMHMHIBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBCD0", Offset = "0x7FBA8D0", VA = "0x187FBBCD0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NLFOIHCIAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA50", Offset = "0xA7B650", VA = "0x180A7CA50", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float HNKFFHFOEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD26CA0", Offset = "0xD258A0", VA = "0x180D26CA0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KMMEFBHACEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xFB2570", Offset = "0xFB1170", VA = "0x180FB2570", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBC10", Offset = "0x7FBA810", VA = "0x187FBBC10")]
	public GCBJAPGPFKH(UniformTRS LPDGFNHIEBD, GBGEFMIEGNI LIPFJJEAFCE, float PBHJKABEKEB, float3 CMDOGPMDMEM, JLNOJMKJPNC CJBJNGGFNMA, IIDDCNCKDDH DGPGGNNBGPD, GMHGPIGAFIH GALEDNLDGCG, float ADMCNIEMPBB, int DKJOAIFHFAC, NativeArray<PENOEPANFIA> BAFFAABICFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1161220", Offset = "0x115FE20", VA = "0x181161220", Slot = "33")]
	public NativeArray<PENOEPANFIA> GetNativeCurvePoints()
	{
		return default(NativeArray<PENOEPANFIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBB50", Offset = "0x7FBA750", VA = "0x187FBBB50", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NOGLJCMPKOM : BMFCGPILCAL, FLIFFCNMJBP, DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<DDKHKNGGFFK, KPFEPBPCGON> BHAICIEADLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KPFEPBPCGON CKCLCKKEEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MFNJCBDPJJB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private KPFEPBPCGON FAMFLPCLOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA3B560", Offset = "0xA3A160", VA = "0x180A3B560", Slot = "28")]
		get
		{
			return default(KPFEPBPCGON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JDGCMCHEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xEE9190", Offset = "0xEE7D90", VA = "0x180EE9190", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 CIOJGHJNDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCFF00", Offset = "0x7FCEB00", VA = "0x187FCFF00", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFEE0", Offset = "0x7FCEAE0", VA = "0x187FCFEE0")]
	public NOGLJCMPKOM(GBGGLBKJJPC EGALIAAOIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF860", Offset = "0x7FCE460", VA = "0x187FCF860", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF8B0", Offset = "0x7FCE4B0", VA = "0x187FCF8B0", Slot = "26")]
	public override void NJCBLGMIGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HFHLJJCNCBD : HIHGILFOHHF, PLLHHFOOEOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject BDJEMDHDNKM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC1E40", Offset = "0x7FC0A40", VA = "0x187FC1E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LNFJEBGBMKD FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7FC21B0", Offset = "0x7FC0DB0", VA = "0x187FC21B0", Slot = "15")]
		get
		{
			return default(LNFJEBGBMKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LLKIKIFPCCN GAOLILFBDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2430", Offset = "0x7FC1030", VA = "0x187FC2430", Slot = "16")]
		get
		{
			return default(LLKIKIFPCCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FC22E0", Offset = "0x7FC0EE0", VA = "0x187FC22E0")]
	public HFHLJJCNCBD(GBGGLBKJJPC EAOPNGFGOCP, bool LAEBNIHKAPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC1ED0", Offset = "0x7FC0AD0", VA = "0x187FC1ED0")]
	public void CFHIAPFFAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC21B0", Offset = "0x7FC0DB0", VA = "0x187FC21B0")]
	protected LNFJEBGBMKD DANAIHCBOCN()
	{
		return default(LNFJEBGBMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2060", Offset = "0x7FC0C60", VA = "0x187FC2060")]
	private static bool DAIMGPJGGJM(GBGGLBKJJPC FFCOGJOEHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FC22B0", Offset = "0x7FC0EB0", VA = "0x187FC22B0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LOJKBJMFFMM : BMFCGPILCAL, BKJBENJIBKG, DIAELBGNDEJ, IDisposable, IIDGFLNLEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<PENOEPANFIA> BAFFAABICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CPPBAPJPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LOJMGONAOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float ADMCNIEMPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int DKJOAIFHFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool FACLKMJDCAO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JEBHOALIIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xCBAD60", Offset = "0xCB9960", VA = "0x180CBAD60", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KHOGCDHICIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A640", Offset = "0xA69240", VA = "0x180A6A640", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float OOPMMIBOKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE24770", Offset = "0xE23370", VA = "0x180E24770", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int LJDNCEKEJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xDCF4D0", Offset = "0xDCE0D0", VA = "0x180DCF4D0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool GBHJEHCDFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCADB40", Offset = "0xCAC740", VA = "0x180CADB40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int BPNCIMIDKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD0A0", Offset = "0x7FCBCA0", VA = "0x187FCD0A0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int MIFJLMDHLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7FCCD80", Offset = "0x7FCB980", VA = "0x187FCCD80", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD0C0", Offset = "0x7FCBCC0", VA = "0x187FCD0C0")]
	public LOJKBJMFFMM(GBGGLBKJJPC EGALIAAOIOO, [Optional] NativeList<PENOEPANFIA> BAFFAABICFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCE70", Offset = "0x7FCBA70", VA = "0x187FCCE70", Slot = "26")]
	public override void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC7D0", Offset = "0x7FCB3D0", VA = "0x187FCC7D0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC8F0", Offset = "0x7FCB4F0", VA = "0x187FCC8F0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCD20", Offset = "0x7FCB920", VA = "0x187FCCD20")]
	public void HJFKJNMEDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCB50", Offset = "0x7FCB750", VA = "0x187FCCB50", Slot = "34")]
	public NativeArray<PENOEPANFIA> GetNativeCurvePoints()
	{
		return default(NativeArray<PENOEPANFIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7FCCF50", Offset = "0x7FCBB50", VA = "0x187FCCF50", Slot = "35")]
	private Vector3 PANPAMIAOOD(int IFAMDLCCFIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC8C0", Offset = "0x7FCB4C0", VA = "0x187FCC8C0", Slot = "36")]
	private Quaternion DJHFDOFBFNK(int IFAMDLCCFIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC9C0", Offset = "0x7FCB5C0", VA = "0x187FCC9C0", Slot = "37")]
	private float FBJJFKPAEML(int IFAMDLCCFIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC950", Offset = "0x7FCB550", VA = "0x187FCC950")]
	private NativeArray<Entity> ECIAHBFDGHI()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class JHMDPMEHPIP : OPPAPMGCDCI
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9E20", Offset = "0x7FC8A20", VA = "0x187FC9E20", Slot = "15")]
	protected override ComponentSystemBase KACDKPCEHNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA230", Offset = "0x7FC8E30", VA = "0x187FCA230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA240", Offset = "0x7FC8E40", VA = "0x187FCA240")]
	public JHMDPMEHPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FLOBEIPIHCH]
public sealed class HOIGLJOGFPH : FDMOLOBBHJE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery HKHGABHDIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery PGEEKDKNKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery PFEOBNIPLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery CKHEIBEFKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery BMBJLHKDNPG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3AA0", Offset = "0x7FC26A0", VA = "0x187FC3AA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3E00", Offset = "0x7FC2A00", VA = "0x187FC3E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FC36A0", Offset = "0x7FC22A0", VA = "0x187FC36A0")]
	private void FOGIFAKEOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3590", Offset = "0x7FC2190", VA = "0x187FC3590")]
	private void EEONODLOAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3880", Offset = "0x7FC2480", VA = "0x187FC3880")]
	private void JBEBMBBMPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3330", Offset = "0x7FC1F30", VA = "0x187FC3330")]
	private void DDJICGEKNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3490", Offset = "0x7FC2090", VA = "0x187FC3490")]
	private void ECFANHCOGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3A50", Offset = "0x7FC2650", VA = "0x187FC3A50")]
	private NativeList<Entity> OMJILFIBIAH(NativeArray<Entity> NKHJILJFELH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7FC32E0", Offset = "0x7FC1EE0", VA = "0x187FC32E0")]
	private NativeList<Entity> AKLGEKDPDHJ(NativeArray<Entity> NKHJILJFELH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3430", Offset = "0x7FC2030", VA = "0x187FC3430")]
	private void DDKNJCDGJIK(NativeArray<Entity> NKHJILJFELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public HOIGLJOGFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FLOBEIPIHCH]
public sealed class ADPBFKJGBIA : FDMOLOBBHJE, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery JBAEGPOOKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery HOFILKJBFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery DJPHBOBFJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PCCJKEOOMPO PMGHLKNNKNP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8510", Offset = "0x7FB7110", VA = "0x187FB8510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8300", Offset = "0x7FB6F00", VA = "0x187FB8300", Slot = "15")]
	public override void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7FB86E0", Offset = "0x7FB72E0", VA = "0x187FB86E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7FE0", Offset = "0x7FB6BE0", VA = "0x187FB7FE0")]
	private void HHALPLOCKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7950", Offset = "0x7FB6550", VA = "0x187FB7950")]
	private void GJDIFJDBGEK(NativeParallelHashSet<EEHGLNGJALI> IPADHELADIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6F10", Offset = "0x7FB5B10", VA = "0x187FB6F10")]
	private void EPMCMAEBICB(NativeParallelHashSet<EEHGLNGJALI> IPADHELADIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7FB75A0", Offset = "0x7FB61A0", VA = "0x187FB75A0")]
	private void FLBLLPKOBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6E70", Offset = "0x7FB5A70", VA = "0x187FB6E70")]
	private bool CEEMBEGEGAD(Entity JMNEAPNCNHN, [Out] EEHGLNGJALI IIDMJHNGGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7FB8360", Offset = "0x7FB6F60", VA = "0x187FB8360")]
	private bool MGOIPBBAKOP(Entity JMNEAPNCNHN, [Out] EEHGLNGJALI IIDMJHNGGHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public ADPBFKJGBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[FLOBEIPIHCH]
public sealed class MCPCBIBDNHM : FDMOLOBBHJE
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery KNLFALGBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery AJBAENCDLNF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDE40", Offset = "0x7FCCA40", VA = "0x187FCDE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDF90", Offset = "0x7FCCB90", VA = "0x187FCDF90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCDB40", Offset = "0x7FCC740", VA = "0x187FCDB40")]
	private void GJDIFJDBGEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCD850", Offset = "0x7FCC450", VA = "0x187FCD850")]
	private void EPMCMAEBICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public MCPCBIBDNHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ONACMCMFCCN : FDMOLOBBHJE, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct FOIOGPLOBLO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob AIKLDIBAPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob CFHJPNABHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob JNEMDJJFJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob DEGALIHJAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle GIKGJKECGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<LIAGJEABGIE> EGPPKFNJCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> ENDEEBCPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> GALOOJMEHEE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB9F0", Offset = "0x7FBA5F0", VA = "0x187FBB9F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBA70", Offset = "0x7FBA670", VA = "0x187FBBA70")]
		private void GINOKNNGLMG(EntityQueryInJob KPNAGIAKBLA, NativeList<Entity> DOFDLFPPGMG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct AKHHMHHHMND : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle GIKGJKECGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<LIAGJEABGIE> EGPPKFNJCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> DOFDLFPPGMG;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7FB8780", Offset = "0x7FB7380", VA = "0x187FB8780", Slot = "4")]
		public void Execute(ArchetypeChunk HGMFFNNBEDL, int CHCJIDHGOAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct CMJAICAHMNI : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle GIKGJKECGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> PDGIGBGBPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<CFKLILFGJDJ> JICMMCLHENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<GLAJNHGGAIN> FCGCEJKLFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<LIAGJEABGIE> IOFDNBLCKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> MHDHLEMBPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<CFKLILFGJDJ> DHJBADNJOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<EEHGLNGJALI> OAGNGMCKLHA;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAC80", Offset = "0x7FB9880", VA = "0x187FBAC80", Slot = "4")]
		public void Execute(ArchetypeChunk HGMFFNNBEDL, int CHCJIDHGOAI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery AIKLDIBAPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery CFHJPNABHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery JNEMDJJFJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery DEGALIHJAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery HHDKNEOIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery OPCJIIDKBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery HLECKHDAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PCCJKEOOMPO PGAMBNLEFDN;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1790", Offset = "0x7FD0390", VA = "0x187FD1790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7FD06F0", Offset = "0x7FCF2F0", VA = "0x187FD06F0", Slot = "15")]
	public override void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1D10", Offset = "0x7FD0910", VA = "0x187FD1D10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7FD1190", Offset = "0x7FCFD90", VA = "0x187FD1190")]
	private void MOEAHOCHCGG(NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI, int EEDFEILOPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0D40", Offset = "0x7FCF940", VA = "0x187FD0D40")]
	private void MLAFGEOIGKM(NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI, int FAAODDICEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0750", Offset = "0x7FCF350", VA = "0x187FD0750")]
	private void KNAJDPMHJME(NativeParallelHashSet<EEHGLNGJALI> HIMKHCFJHBI, int BAFKDKGPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0360", Offset = "0x7FCEF60", VA = "0x187FD0360")]
	private void GNAIAGKFONI(NativeParallelHashSet<EEHGLNGJALI> IPADHELADIG, int NNMLPJLAHLC, int EAKFJKLCLKB, int BKAACKNGDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD0B90", Offset = "0x7FCF790", VA = "0x187FD0B90")]
	private void LAECBACELKN(Entity LGFAMJANOCB, PLBHNIEEDEN LPGMNICCBBJ, EEHGLNGJALI IIDMJHNGGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public ONACMCMFCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class KFEIGFJCLHH : FDMOLOBBHJE
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery FJGLIGMMDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery OKPMKNIGKAG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA850", Offset = "0x7FC9450", VA = "0x187FCA850", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCAA80", Offset = "0x7FC9680", VA = "0x187FCAA80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public KFEIGFJCLHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KPLKNPFCKGB : FDMOLOBBHJE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct CLLHJIJNJJO : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery PNNLGNLDNAL;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC060", Offset = "0x7FCAC60", VA = "0x187FCC060", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC1A0", Offset = "0x7FCADA0", VA = "0x187FCC1A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public KPLKNPFCKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FLOBEIPIHCH]
internal class GDMNDKDMCPC : FDMOLOBBHJE
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class ONLEGANHMBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery GGBBKIPEEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery JAHCPMEBBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LAEGIHDANJP FMMEHABGHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType JGMFNCMAGLH;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ONLEGANHMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void LAEGIHDANJP(NativeArray<PLBHNIEEDEN> BEPAMKMBKNC, FOCKMLOJPND PPEEJMHIONF);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<ONLEGANHMBM> PBGKCKOEGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private HCBADEACGBJ CGHDNENEFOK;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCB10", Offset = "0x7FBB710", VA = "0x187FBCB10", Slot = "15")]
	public override void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCD10", Offset = "0x7FBB910", VA = "0x187FBCD10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCEA0", Offset = "0x7FBBAA0", VA = "0x187FBCEA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A84EE0", Offset = "0x3A83AE0", VA = "0x183A84EE0")]
	private void BGDHNGPAJJI<T>(LAEGIHDANJP FMMEHABGHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC970", Offset = "0x7FBB570", VA = "0x187FBC970")]
	private static void IAGEMMGJDHP(NativeArray<PLBHNIEEDEN> EJOMAHOPPJE, FOCKMLOJPND PGEAAPMIDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC7D0", Offset = "0x7FBB3D0", VA = "0x187FBC7D0")]
	private static void DOKLFAEMJII(NativeArray<PLBHNIEEDEN> EJOMAHOPPJE, FOCKMLOJPND PGEAAPMIDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCB70", Offset = "0x7FBB770", VA = "0x187FBCB70")]
	private static void OCEMNHOPKFC(NativeArray<PLBHNIEEDEN> EJOMAHOPPJE, FOCKMLOJPND PGEAAPMIDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public GDMNDKDMCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[FLOBEIPIHCH]
public sealed class NCOKKDHHBOP : FDMOLOBBHJE
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery KPNAGIAKBLA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE2F0", Offset = "0x7FCCEF0", VA = "0x187FCE2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EHEFBPJDEKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS LPDGFNHIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData KFAEPMCPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public KPFEPBPCGON CKCLCKKEEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 KAJEPGKJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MFNJCBDPJJB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[KGGDBGGCKMI(Lifetime.LoadInstance)]
public struct HMMKMGMKCIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity IPOHHENOLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> MKBPPMEGIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> LDPCMFABGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<EHEFBPJDEKM> BJKCEENPOJO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7FC3250", Offset = "0x7FC1E50", VA = "0x187FC3250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(NEPEOOJEDBA), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class NEPEOOJEDBA : OMNICACBHFO, IDOBMNBOACG, CBLCJDEAFID, JOOIONMMMGO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LFHEKEMILEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NEPEOOJEDBA LIPFJJEAFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool GIOCHLLANID;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x193B530", Offset = "0x193A130", VA = "0x18193B530")]
		public LFHEKEMILEE(NEPEOOJEDBA LIPFJJEAFCE, bool GIOCHLLANID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC710", Offset = "0x7FCB310", VA = "0x187FCC710")]
		public Queue<DGIPHMECHFK>.Enumerator MEEEBEDBKAB()
		{
			return default(Queue<DGIPHMECHFK>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC3D0", Offset = "0x7FCAFD0", VA = "0x187FCC3D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private BNNLGKNFBBF DLFIGPDLPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private HLGIOBGHNLH DEMNLIAJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<PENOEPANFIA>> HLIJGMBCDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> LFFIIIHPKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<PLBHNIEEDEN> ONKKBPKOHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private AFGLLDMDDKL<DGIPHMECHFK> IOLMIBFAKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private AFGLLDMDDKL<HMMKMGMKCIG> GLJGGMHCMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AFGLLDMDDKL<HHAEMIKCFLI> JKDEJEKKKBB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF380", Offset = "0x7FCDF80", VA = "0x187FCF380", Slot = "4")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF020", Offset = "0x7FCDC20", VA = "0x187FCF020")]
	public void HEHBPAIIONJ(NativeList<PENOEPANFIA> JAFNDBEGOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF5F0", Offset = "0x7FCE1F0", VA = "0x187FCF5F0")]
	public void LOMINHNFGBO(Entity LIPFJJEAFCE, [In] JAGGGNKIKJG<GameObject> LFONGOACFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF2F0", Offset = "0x7FCDEF0", VA = "0x187FCF2F0")]
	public void INLPKBENNFB(NativeList<PLBHNIEEDEN> EJOMAHOPPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEDF0", Offset = "0x7FCD9F0", VA = "0x187FCEDF0")]
	public void GMAKGOJBEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE720", Offset = "0x7FCD320", VA = "0x187FCE720")]
	public void DBHBDKAMPBI(MEFOENIIPMB GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7FCED50", Offset = "0x7FCD950", VA = "0x187FCED50")]
	public JobHandle GGBANOHKPGH([In] DGIPHMECHFK FNFIPKNHEOF, JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7FCECB0", Offset = "0x7FCD8B0", VA = "0x187FCECB0")]
	public JobHandle GGBANOHKPGH([In] HMMKMGMKCIG FNFIPKNHEOF, JobHandle OLHPIOMJOOH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E6E0", Offset = "0x7C5D2E0", VA = "0x187C5E6E0")]
	public LFHEKEMILEE JCALNFMCJHC(bool GIOCHLLANID)
	{
		return default(LFHEKEMILEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF790", Offset = "0x7FCE390", VA = "0x187FCF790")]
	public APHLINHGHMD<HMMKMGMKCIG> PLHFPBNOBGD()
	{
		return default(APHLINHGHMD<HMMKMGMKCIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF740", Offset = "0x7FCE340", VA = "0x187FCF740")]
	public APHLINHGHMD<HHAEMIKCFLI> OLFIBPFJLDP()
	{
		return default(APHLINHGHMD<HHAEMIKCFLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF0D0", Offset = "0x7FCDCD0", VA = "0x187FCF0D0")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7FCEBD0", Offset = "0x7FCD7D0", VA = "0x187FCEBD0", Slot = "5")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7FCF580", Offset = "0x7FCE180", VA = "0x187FCF580", Slot = "6")]
	private void KKNLMKKOOCF(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x121C5F0", Offset = "0x121B1F0", VA = "0x18121C5F0", Slot = "7")]
	private void OLKMBFKLKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NEPEOOJEDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NILFHGEKPKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS LPDGFNHIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData KFAEPMCPOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public BMIAJFBBPCI GALEDNLDGCG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KGGDBGGCKMI(Lifetime.LoadInstance)]
public struct DGIPHMECHFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity IPOHHENOLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> NKHJILJFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> MKBPPMEGIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> LDPCMFABGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<HJOGNENAABH> PPJMFKBBDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<PENOEPANFIA> JAFNDBEGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<NILFHGEKPKH> CKIMIHINKIB;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB220", Offset = "0x7FB9E20", VA = "0x187FBB220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB230", Offset = "0x7FB9E30", VA = "0x187FBB230")]
	public void LDCCMKMJIMF(bool GIOCHLLANID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(CNKMNPIDCMJ), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class CNKMNPIDCMJ : GEKOOPGEMNM, CBLCJDEAFID, JOOIONMMMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private NEPEOOJEDBA FKDHJFDIMAC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB000", Offset = "0x7FB9C00", VA = "0x187FBB000", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAFB0", Offset = "0x7FB9BB0", VA = "0x187FBAFB0", Slot = "5")]
	private void KKNLMKKOOCF(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x11FF100", Offset = "0x11FDD00", VA = "0x1811FF100", Slot = "6")]
	private void OLKMBFKLKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CNKMNPIDCMJ()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : FDMOLOBBHJE, OMNICACBHFO
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
			public NativeParallelHashMap<int, KPFEPBPCGON> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<EHEFBPJDEKM> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD420", Offset = "0x7FBC020", VA = "0x187FBD420", Slot = "4")]
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
			public NativeArray<PENOEPANFIA> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<HJOGNENAABH> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<NILFHGEKPKH> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7FBD7C0", Offset = "0x7FBC3C0", VA = "0x187FBD7C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FBB020", Offset = "0x7FB9C20", VA = "0x187FBB020", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7FD21D0", Offset = "0x7FD0DD0", VA = "0x187FD21D0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7FD21F0", Offset = "0x7FD0DF0", VA = "0x187FD21F0")]
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
				float3 IBBOCDLLDBA(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7FCD0F0", Offset = "0x7FCBCF0", VA = "0x187FCD0F0", Slot = "5")]
				public float3 BHLBDDKNMFL(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7FCD490", Offset = "0x7FCC090", VA = "0x187FCD490", Slot = "4")]
				public float3 IBBOCDLLDBA(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7FCFFD0", Offset = "0x7FCEBD0", VA = "0x187FCFFD0", Slot = "4")]
				public float3 IBBOCDLLDBA(quaternion rotation)
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
			public NativeArray<HJOGNENAABH> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<PENOEPANFIA> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF600", Offset = "0x7FBE200", VA = "0x187FBF600", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDF70", Offset = "0x7FBCB70", VA = "0x187FBDF70")]
			private void AMAHFMMIEPJ(NativeList<PointSrcData> srcData, NativeList<PENOEPANFIA> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7FBEE50", Offset = "0x7FBDA50", VA = "0x187FBEE50")]
			public static Vector3 BBPHNEADHEC(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0CF0", Offset = "0x7FBF8F0", VA = "0x187FC0CF0")]
			public static quaternion PCAEPFAJNMF(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7FC1B80", Offset = "0x7FC0780", VA = "0x187FC1B80")]
			private static quaternion PPPFHNIGHPG(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFC20", Offset = "0x7FBE820", VA = "0x187FBFC20")]
			private static float3 FFPBPAENLLH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDEE0", Offset = "0x7FBCAE0", VA = "0x187FBDEE0")]
			private static quaternion AJENBHBKGMN(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0A80", Offset = "0x7FBF680", VA = "0x187FC0A80")]
			private static PENOEPANFIA OCGGJJBLKAO(int idx, NativeList<PointSrcData> srcData)
			{
				return default(PENOEPANFIA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x41BE430", Offset = "0x41BD030", VA = "0x1841BE430")]
			private void BLJHPCKKHKB<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0D70", Offset = "0x7FBF970", VA = "0x187FC0D70")]
			private void PPKPMOMBIBA(NativeList<PointSrcData> sourcePoints, NativeList<PENOEPANFIA> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7FC03D0", Offset = "0x7FBEFD0", VA = "0x187FC03D0")]
			public static float INOJINEDMPD(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF410", Offset = "0x7FBE010", VA = "0x187FBF410")]
			private static quaternion EMAJHNIABNE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7FC02B0", Offset = "0x7FBEEB0", VA = "0x187FC02B0")]
			private static PENOEPANFIA IKKAKPJFOPO(PointSrcData point)
			{
				return default(PENOEPANFIA);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0220", Offset = "0x7FBEE20", VA = "0x187FC0220")]
			private static PENOEPANFIA IKKAKPJFOPO(float3 pos, quaternion rot, float radius)
			{
				return default(PENOEPANFIA);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFDF0", Offset = "0x7FBE9F0", VA = "0x187FBFDF0")]
			private static bool GKIPBAOAHHF(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7FC09B0", Offset = "0x7FBF5B0", VA = "0x187FC09B0")]
			private static float3 LBHOHMHECBC(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7FBFE90", Offset = "0x7FBEA90", VA = "0x187FBFE90")]
			public static float3 HIKJCNMBAKF(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7FBF260", Offset = "0x7FBDE60", VA = "0x187FBF260")]
			public static float3 BHLBDDKNMFL(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0550", Offset = "0x7FBF150", VA = "0x187FC0550")]
			private static quaternion KGHOFBOEFMJ(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7FC0040", Offset = "0x7FBEC40", VA = "0x187FC0040")]
			private static float IAGBGKBHAFG(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7FD4410", Offset = "0x7FD3010", VA = "0x187FD4410")]
			private void MKOGAGGJLME(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD4320", Offset = "0x7FD2F20", VA = "0x187FD4320", Slot = "4")]
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
			public NativeList<PENOEPANFIA> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5C00", Offset = "0x7FD4800", VA = "0x187FD5C00")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5BF0", Offset = "0x7FD47F0", VA = "0x187FD5BF0", Slot = "4")]
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
			public NativeList<PENOEPANFIA> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5BA0", Offset = "0x7FD47A0", VA = "0x187FD5BA0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5B90", Offset = "0x7FD4790", VA = "0x187FD5B90", Slot = "4")]
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
			public NativeList<EHEFBPJDEKM> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDB10", Offset = "0x7FBC710", VA = "0x187FBDB10")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDB00", Offset = "0x7FBC700", VA = "0x187FBDB00", Slot = "4")]
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
			public NativeList<HJOGNENAABH> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<NILFHGEKPKH> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDCE0", Offset = "0x7FBC8E0", VA = "0x187FBDCE0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7FBDCD0", Offset = "0x7FBC8D0", VA = "0x187FBDCD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD5770", Offset = "0x7FD4370", VA = "0x187FD5770")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7FD5760", Offset = "0x7FD4360", VA = "0x187FD5760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly JPIBGNDAFKP log;

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
		private LANCAEOKFKH replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BNNLGKNFBBF objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NEPEOOJEDBA bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private OEJOOANDLOK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4090", Offset = "0x7FD2C90", VA = "0x187FD4090", Slot = "15")]
		public override void InitReferences(OLKHLOEBPJH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5420", Offset = "0x7FD4020", VA = "0x187FD5420", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5510", Offset = "0x7FD4110", VA = "0x187FD5510", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FD5570", Offset = "0x7FD4170", VA = "0x187FD5570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2F50", Offset = "0x7FD1B50", VA = "0x187FD2F50")]
		private JobHandle DALDAHAGBME(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD44F0", Offset = "0x7FD30F0", VA = "0x187FD44F0")]
		private JobHandle MBJHPPJOMLJ(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2870", Offset = "0x7FD1470", VA = "0x187FD2870")]
		private JobHandle BAEFOHOPHBN(NativeArray<int> pointCount, NativeList<PENOEPANFIA> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3610", Offset = "0x7FD2210", VA = "0x187FD3610")]
		private JobHandle OCNONIPDEAO(NativeList<PENOEPANFIA> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FD36B0", Offset = "0x7FD22B0", VA = "0x187FD36B0")]
		private JobHandle GLEIHIOIKDM(EntityQuery query, NativeList<HJOGNENAABH> splinePointRanges, NativeList<PENOEPANFIA> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4D00", Offset = "0x7FD3900", VA = "0x187FD4D00")]
		private JobHandle MOABKBGEPEP(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2240", Offset = "0x7FD0E40", VA = "0x187FD2240")]
		private JobHandle ABOEKFHLIKN(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2CB0", Offset = "0x7FD18B0", VA = "0x187FD2CB0")]
		private JobHandle CLMEIEAHFEB(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<EHEFBPJDEKM> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4E20", Offset = "0x7FD3A20", VA = "0x187FD4E20")]
		private JobHandle OPDKKNPMLJD(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HJOGNENAABH> splinePointRanges, [Out] NativeList<NILFHGEKPKH> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3290", Offset = "0x7FD1E90", VA = "0x187FD3290")]
		private JobHandle DLNBHENPKNJ(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2360", Offset = "0x7FD0F60", VA = "0x187FD2360")]
		private JobHandle AKGFIMBAILD(EntityQuery query, NativeList<EHEFBPJDEKM> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3C70", Offset = "0x7FD2870", VA = "0x187FD3C70")]
		private static NativeParallelHashMap<int, KPFEPBPCGON> HFOLBLCENIF()
		{
			return default(NativeParallelHashMap<int, KPFEPBPCGON>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2910", Offset = "0x7FD1510", VA = "0x187FD2910")]
		private JobHandle BBDLPLMMMAO(EntityQuery query, NativeList<HJOGNENAABH> splinePointRanges, NativeList<PENOEPANFIA> splinePointData, NativeList<NILFHGEKPKH> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4130", Offset = "0x7FD2D30", VA = "0x187FD4130")]
		private JobHandle JDHJIGFGJBK(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7FD2870", Offset = "0x7FD1470", VA = "0x187FD2870")]
		private JobHandle KPLECPFDCNI(NativeArray<int> pointCount, NativeList<PENOEPANFIA> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3610", Offset = "0x7FD2210", VA = "0x187FD3610")]
		private JobHandle DMJIAKDMMBP(NativeList<PENOEPANFIA> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FD3B80", Offset = "0x7FD2780", VA = "0x187FD3B80")]
		private JobHandle GPFEMNBGPJK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<EHEFBPJDEKM> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4210", Offset = "0x7FD2E10", VA = "0x187FD4210")]
		private JobHandle LKCALMLPAAH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HJOGNENAABH> ranges, NativeList<NILFHGEKPKH> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4BB0", Offset = "0x7FD37B0", VA = "0x187FD4BB0")]
		private JobHandle MMEAOLECMDI(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7FD50E0", Offset = "0x7FD3CE0", VA = "0x187FD50E0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JHKKCOKEGAO : BCHHLKDMOPB, OMNICACBHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NEPEOOJEDBA FKDHJFDIMAC;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9DB0", Offset = "0x7FC89B0", VA = "0x187FC9DB0", Slot = "14")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7FC9E00", Offset = "0x7FC8A00", VA = "0x187FC9E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
	public JHKKCOKEGAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class HOOOADICKNC : FDMOLOBBHJE, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct LJJFHHHBHGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager HGAKBEIGHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private GFGKDCAMGNM<T> EHEMLAPPKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int EMMACFPOKFB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x52C0400", Offset = "0x52BF000", VA = "0x1852C0400")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x52C0A00", Offset = "0x52BF600", VA = "0x1852C0A00")]
		public LJJFHHHBHGC(EntityManager HGAKBEIGHGE, GFGKDCAMGNM<T> EHEMLAPPKKF, NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x47EA3D0", Offset = "0x47E8FD0", VA = "0x1847EA3D0")]
		public LJJFHHHBHGC<T> MEEEBEDBKAB()
		{
			return default(LJJFHHHBHGC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x52C0880", Offset = "0x52BF480", VA = "0x1852C0880")]
		public bool MNOHJEBJBPH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly JPIBGNDAFKP DOLNEEJHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HLGIOBGHNLH DEMNLIAJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private NEPEOOJEDBA FKDHJFDIMAC;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6150", Offset = "0x7FC4D50", VA = "0x187FC6150", Slot = "15")]
	public override void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7FC55E0", Offset = "0x7FC41E0", VA = "0x187FC55E0")]
	public void CFDEFPBNJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7E30", Offset = "0x7FC6A30", VA = "0x187FC7E30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4500", Offset = "0x7FC3100", VA = "0x187FC4500")]
	private void BGEHBDFHLGM(HHAEMIKCFLI FNFIPKNHEOF, Mesh[] FCGKFOHAJFM, NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD820", Offset = "0x3ABC420", VA = "0x183ABD820")]
	private LJJFHHHBHGC<T> FFFOOKEABMN<T>(GFGKDCAMGNM<T> EHEMLAPPKKF, NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO) where T : struct
	{
		return default(LJJFHHHBHGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7560", Offset = "0x7FC6160", VA = "0x187FC7560")]
	private void MCEJDMABPNA(Transform LIPFJJEAFCE, NativeArray<CKJIIOHOEND> ODGIIKLCACH, JAGGGNKIKJG<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5860", Offset = "0x7FC4460", VA = "0x187FC5860")]
	private void HCEKGJMOMJG(Transform LIPFJJEAFCE, NativeArray<OFKPLCOMGLB> HKDKJJDGGBJ, JAGGGNKIKJG<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FC6D90", Offset = "0x7FC5990", VA = "0x187FC6D90")]
	private void JMALEGIOJOJ(Transform LIPFJJEAFCE, NativeArray<JPHHCJIGKPJ> HKDGPOKJPDJ, JAGGGNKIKJG<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5D20", Offset = "0x7FC4920", VA = "0x187FC5D20")]
	private void HLAAIPIEODL(Transform LIPFJJEAFCE, NativeArray<KAOPIOGJMAA> FCGKFOHAJFM, Mesh[] HDOKPPHIPIC, JAGGGNKIKJG<GameObject> CELEDNBGMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5610", Offset = "0x7FC4210", VA = "0x187FC5610")]
	private static void DIGKHHGOLFK(NativeParallelHashSet<Entity> NKHJILJFELH, NativeParallelHashSet<Entity> BEMGEIDNMCD, NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7FC4440", Offset = "0x7FC3040", VA = "0x187FC4440")]
	private static void ADPMPPFKPJK(NativeList<Entity> DNNGKIFFAHG, NativeArray<EntityRemapUtility.EntityRemapInfo> KPBJEHDGCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7FC61D0", Offset = "0x7FC4DD0", VA = "0x187FC61D0")]
	private NativeParallelHashMap<Entity, GLAJNHGGAIN> JJBGGOIHKBM(NEPEOOJEDBA.LFHEKEMILEE MHCFNLOOOLO, APHLINHGHMD<HMMKMGMKCIG> EAPFNCLGABM, List<GameObject> CELEDNBGMMN)
	{
		return default(NativeParallelHashMap<Entity, GLAJNHGGAIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7FC5760", Offset = "0x7FC4360", VA = "0x187FC5760")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HAKLAKMHIEF(Entity KOBMGPFFHGG)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7FC78E0", Offset = "0x7FC64E0", VA = "0x187FC78E0")]
	private void ODNILNAGNEO(NativeList<Entity> NDNNOAAEPJE, NativeList<Entity> EFAAGJCNFCP, NativeParallelHashMap<Entity, GLAJNHGGAIN> CAEFNJLMCKK, NativeList<HJOGNENAABH> NGNBADLLDKC, NativeList<PENOEPANFIA> CGIBLCCDGME, NativeList<NILFHGEKPKH> HLIJGMBCDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7FC7170", Offset = "0x7FC5D70", VA = "0x187FC7170")]
	private void KACOHDGHAAM(NativeList<Entity> NKHJILJFELH, NativeList<Entity> MKBPPMEGIKB, NativeParallelHashMap<Entity, GLAJNHGGAIN> CAEFNJLMCKK, NativeList<EHEFBPJDEKM> BJKCEENPOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD7AF0", VA = "0x182CD8EF0")]
	public HOOOADICKNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class JJJOAFDPKFF : NIJHHNODIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS LPDGFNHIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly GBGEFMIEGNI LIPFJJEAFCE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject ODDGBNMFPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS OGEAAGCFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA4D0", Offset = "0x7FC90D0", VA = "0x187FCA4D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 DHBGOMDOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA5B0", Offset = "0x7FC91B0", VA = "0x187FCA5B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 BHFBEEGAIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA480", Offset = "0x7FC9080", VA = "0x187FCA480", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 KPCJNOAJHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA430", Offset = "0x7FC9030", VA = "0x187FCA430", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA2F0", Offset = "0x7FC8EF0", VA = "0x187FCA2F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion KIHDMHGJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA250", Offset = "0x7FC8E50", VA = "0x187FCA250", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA3E0", Offset = "0x7FC8FE0", VA = "0x187FCA3E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 LNHACDAKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA2A0", Offset = "0x7FC8EA0", VA = "0x187FCA2A0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 CPKHADGFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA340", Offset = "0x7FC8F40", VA = "0x187FCA340", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 PGOPJNLDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7FCA390", Offset = "0x7FC8F90", VA = "0x187FCA390", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7FCA600", Offset = "0x7FC9200", VA = "0x187FCA600")]
	public JJJOAFDPKFF(UniformTRS LPDGFNHIEBD, GBGEFMIEGNI LIPFJJEAFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NCCCPFJMFFN : JJJOAFDPKFF, DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float PBHJKABEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 CMDOGPMDMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly JLNOJMKJPNC CJBJNGGFNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly IIDDCNCKDDH DGPGGNNBGPD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private LNFJEBGBMKD ICANMAPLKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE140", Offset = "0x7FCCD40", VA = "0x187FCE140", Slot = "17")]
		get
		{
			return default(LNFJEBGBMKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS JOENKAAKAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE190", Offset = "0x7FCCD90", VA = "0x187FCE190", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float GPKNKFFMMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5C0", Offset = "0xA6E1C0", VA = "0x180A6F5C0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 ODIMHMJHALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7FCE0F0", Offset = "0x7FCCCF0", VA = "0x187FCE0F0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private JLNOJMKJPNC KICCAGJLEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xF0E930", Offset = "0xF0D530", VA = "0x180F0E930", Slot = "21")]
		get
		{
			return default(JLNOJMKJPNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private IIDDCNCKDDH GBEFPCHOALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x136A720", Offset = "0x1369320", VA = "0x18136A720", Slot = "22")]
		get
		{
			return default(IIDDCNCKDDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool HCNONJBBLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KODINGJMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE270", Offset = "0x7FCCE70", VA = "0x187FCE270")]
	protected NCCCPFJMFFN(UniformTRS LPDGFNHIEBD, GBGEFMIEGNI LIPFJJEAFCE, float PBHJKABEKEB, float3 CMDOGPMDMEM, JLNOJMKJPNC CJBJNGGFNMA, IIDDCNCKDDH DGPGGNNBGPD)
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
public abstract class HIHGILFOHHF : NIJHHNODIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly GBGGLBKJJPC AEIJGHPBELE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected GBGEFMIEGNI HOFAHNGFIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x11FCE90", Offset = "0x11FBA90", VA = "0x1811FCE90")]
		get
		{
			return default(GBGEFMIEGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity ICBFOLBLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2FC0", Offset = "0x7FC1BC0", VA = "0x187FC2FC0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected BNNLGKNFBBF CKPEGOEMBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3150", Offset = "0x7FC1D50", VA = "0x187FC3150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected COKECCKPMJD DJECBLFHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2F60", Offset = "0x7FC1B60", VA = "0x187FC2F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected CGHCFDJMGCD ICPKOBDFLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7FC26E0", Offset = "0x7FC12E0", VA = "0x187FC26E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject ODDGBNMFPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2590", Offset = "0x7FC1190", VA = "0x187FC2590", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS OGEAAGCFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1228960", Offset = "0x1227560", VA = "0x181228960", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 DHBGOMDOJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7FC3160", Offset = "0x7FC1D60", VA = "0x187FC3160", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 BHFBEEGAIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2FE0", Offset = "0x7FC1BE0", VA = "0x187FC2FE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 KPCJNOAJHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2E30", Offset = "0x7FC1A30", VA = "0x187FC2E30", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2860", Offset = "0x7FC1460", VA = "0x187FC2860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion KIHDMHGJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7FC25C0", Offset = "0x7FC11C0", VA = "0x187FC25C0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2D20", Offset = "0x7FC1920", VA = "0x187FC2D20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 LNHACDAKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2770", Offset = "0x7FC1370", VA = "0x187FC2770", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 CPKHADGFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7FC29A0", Offset = "0x7FC15A0", VA = "0x187FC29A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 PGOPJNLDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2B60", Offset = "0x7FC1760", VA = "0x187FC2B60", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xEA32A0", Offset = "0xEA1EA0", VA = "0x180EA32A0")]
	protected HIHGILFOHHF(GBGGLBKJJPC EGALIAAOIOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7FC2970", Offset = "0x7FC1570", VA = "0x187FC2970")]
	public static LNFJEBGBMKD GHOKLFELACP(HIHGILFOHHF LPCHKKFEGJO)
	{
		return default(LNFJEBGBMKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class AHABGJJLHAG
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD66D0", Offset = "0x7FD52D0", VA = "0x187FD66D0")]
	public static void GPICIFGNHNI(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JAMCLFAAGHP
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7740", Offset = "0x7FD6340", VA = "0x187FD7740")]
	public static void ONGGALHMCAP(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE, MEFOENIIPMB CJLMONCKHJM, BNNLGKNFBBF BEIHHAGEJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7FD73F0", Offset = "0x7FD5FF0", VA = "0x187FD73F0")]
	public static void JNOODAFNCJG(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE, MEFOENIIPMB CJLMONCKHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7FD73B0", Offset = "0x7FD5FB0", VA = "0x187FD73B0")]
	public static NativeList<Entity> AKLGEKDPDHJ(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7700", Offset = "0x7FD6300", VA = "0x187FD7700")]
	public static NativeList<Entity> OMJILFIBIAH(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7150", Offset = "0x7FD5D50", VA = "0x187FD7150")]
	private static NativeList<Entity> AKLGEKDPDHJ(NativeArray<Entity> NKHJILJFELH, EntityManager HGAKBEIGHGE, bool IFOIFFMEEAL)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class BMFCGPILCAL : HIHGILFOHHF, DIAELBGNDEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float PBHJKABEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 CMDOGPMDMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private JLNOJMKJPNC CJBJNGGFNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IIDDCNCKDDH DGPGGNNBGPD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager DAJNGOJPDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6A60", Offset = "0x7FD5660", VA = "0x187FD6A60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected DIOBJPDBJAJ MLDHFINAALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6A00", Offset = "0x7FD5600", VA = "0x187FD6A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData FBENFNJHANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6910", Offset = "0x7FD5510", VA = "0x187FD6910")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private LNFJEBGBMKD ICANMAPLKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC2970", Offset = "0x7FC1570", VA = "0x187FC2970", Slot = "17")]
		get
		{
			return default(LNFJEBGBMKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float GPKNKFFMMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA70670", Offset = "0xA6F270", VA = "0x180A70670", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 ODIMHMJHALM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x12E95A0", Offset = "0x12E81A0", VA = "0x1812E95A0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JLNOJMKJPNC KICCAGJLEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70", Slot = "21")]
		get
		{
			return default(JLNOJMKJPNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private IIDDCNCKDDH GBEFPCHOALD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8E0", Offset = "0xA6C4E0", VA = "0x180A6D8E0", Slot = "22")]
		get
		{
			return default(IIDDCNCKDDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS JOENKAAKAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6C80", Offset = "0x7FD5880", VA = "0x187FD6C80", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KODINGJMAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3A0", Offset = "0xA49FA0", VA = "0x180A4B3A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool HCNONJBBLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6CB0", Offset = "0x7FD58B0", VA = "0x187FD6CB0")]
	protected BMFCGPILCAL(GBGGLBKJJPC EGALIAAOIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6AF0", Offset = "0x7FD56F0", VA = "0x187FD6AF0", Slot = "26")]
	public virtual void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class FDMOLOBBHJE : BCHHLKDMOPB, OMNICACBHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected BNNLGKNFBBF BEIHHAGEJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private KLONDPBKHOO BNLGIODIEPM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected MEFOENIIPMB IMIHMFPONKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6D30", Offset = "0x7FD5930", VA = "0x187FD6D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected FOCKMLOJPND FANILCBKBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6CE0", Offset = "0x7FD58E0", VA = "0x187FD6CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool OBIDKANBFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7FD6DF0", Offset = "0x7FD59F0", VA = "0x187FD6DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6D80", Offset = "0x7FD5980", VA = "0x187FD6D80", Slot = "15")]
	public virtual void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
	protected FDMOLOBBHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FIDMEGFFCCB
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7FD6EB0", Offset = "0x7FD5AB0", VA = "0x187FD6EB0")]
	public static void BHPLHOLJKNI(NativeArray<Entity> NDNNOAAEPJE, EntityManager HGAKBEIGHGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1291402877
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7DE0", Offset = "0x7FD69E0", VA = "0x187FD7DE0")]
	public static void PPEFGBJBMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7DD0", Offset = "0x7FD69D0", VA = "0x187FD7DD0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class OMKNAABOCNO : ContainerPropertyBag<NAIIFNFMHMG>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7BB0", Offset = "0x7FD67B0", VA = "0x187FD7BB0")]
	public OMKNAABOCNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class HBKLHDDNDMO : ContainerPropertyBag<ODKLBPLNJGH>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD70F0", Offset = "0x7FD5CF0", VA = "0x187FD70F0")]
	public HBKLHDDNDMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class LKNFJKPJBAI : ContainerPropertyBag<DDNHEOMFDJD>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7B50", Offset = "0x7FD6750", VA = "0x187FD7B50")]
	public LKNFJKPJBAI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD7C10", Offset = "0x7FD6810", VA = "0x187FD7C10")]
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
