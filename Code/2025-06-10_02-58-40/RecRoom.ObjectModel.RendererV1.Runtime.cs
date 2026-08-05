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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E50A30", Offset = "0x7E4FC30", VA = "0x187E50A30", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E08C50", Offset = "0x7E07E50", VA = "0x187E08C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BD70", Offset = "0x7E5AF70", VA = "0x187E5BD70")]
		private void AGIDAPFICKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C310", Offset = "0x7E5B510", VA = "0x187E5C310", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C370", Offset = "0x7E5B570", VA = "0x187E5C370")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HGDIFNGCIPB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B310", Offset = "0x7E4A510", VA = "0x187E4B310")]
	public static Quaternion BLPCLFFJNBL([In] this MCHPBLJLBOJ FNPPOOMPKEE, [In] Vector3 JBACNGDELHL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JGACDBDDBHP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D690", Offset = "0x7E4C890", VA = "0x187E4D690")]
	public static bool ALALAGNHLKC(this GBAGLKGCOGP MJAMAMCODKD, FEDMKIFLINL FENFECOCBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EC70", Offset = "0x7E4DE70", VA = "0x187E4EC70")]
	public static bool LNMFKFICDCN(this GBAGLKGCOGP MJAMAMCODKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DE50", Offset = "0x7E4D050", VA = "0x187E4DE50")]
	public static bool FEMOAELMJGF(this GBAGLKGCOGP MJAMAMCODKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D560", Offset = "0x7E4C760", VA = "0x187E4D560")]
	public static void AGFIEILOCMB(this GBAGLKGCOGP MJAMAMCODKD, Vector3 JKNFPFJOGKI, Quaternion FFOLNFHADMG, float DKGEGBLOEHH, bool BJBDNNHOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EEB0", Offset = "0x7E4E0B0", VA = "0x187E4EEB0")]
	public static void OGEINIFDDEI(this GBAGLKGCOGP MJAMAMCODKD, Vector3 JKNFPFJOGKI, Quaternion FFOLNFHADMG, float DKGEGBLOEHH, int KBGOMFCPKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DE80", Offset = "0x7E4D080", VA = "0x187E4DE80")]
	public static void GMIMABEJFDB(this GBAGLKGCOGP MJAMAMCODKD, int KBGOMFCPKIE, Vector3 JKNFPFJOGKI, Quaternion FFOLNFHADMG, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DFA0", Offset = "0x7E4D1A0", VA = "0x187E4DFA0")]
	public static void HAEABMHEAJM(this GBAGLKGCOGP MJAMAMCODKD, Vector3 AGGCMHKDOAH, Quaternion HJAFCIMKJLH, float DKGEGBLOEHH, bool BJBDNNHOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E210", Offset = "0x7E4D410", VA = "0x187E4E210")]
	private static void JPJPKIGOMMO(this GBAGLKGCOGP MJAMAMCODKD, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH, bool BJBDNNHOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F130", Offset = "0x7E4E330", VA = "0x187E4F130")]
	private static void PFHPHICAEAI(this GBAGLKGCOGP MJAMAMCODKD, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, float MNBBJONKABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ECA0", Offset = "0x7E4DEA0", VA = "0x187E4ECA0")]
	private static void MNADKCKMFBB(this GBAGLKGCOGP MJAMAMCODKD, int CMDFFDAPDIB, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, float MNBBJONKABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EE80", Offset = "0x7E4E080", VA = "0x187E4EE80")]
	private static bool NOEIMAINNDD(this GBAGLKGCOGP MJAMAMCODKD, int CMDFFDAPDIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D6D0", Offset = "0x7E4C8D0", VA = "0x187E4D6D0")]
	private static void DANILEIMDFB(this GBAGLKGCOGP MJAMAMCODKD, int CMDFFDAPDIB, Vector3 JCHDHELBFIA, Quaternion FODPIPCFDKK, float MNBBJONKABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D960", Offset = "0x7E4CB60", VA = "0x187E4D960")]
	public static Vector3 DMNJOMPGKLC(this GBAGLKGCOGP MJAMAMCODKD, int CMDFFDAPDIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EB60", Offset = "0x7E4DD60", VA = "0x187E4EB60")]
	public static Quaternion LGNNOJCHMEG(this GBAGLKGCOGP MJAMAMCODKD, int CMDFFDAPDIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DFF0", Offset = "0x7E4D1F0", VA = "0x187E4DFF0")]
	public static Vector3 JKAFAHKKFKD(FEDMKIFLINL FFMDBMBLMEI, Vector3 FICCENLPJEL, Vector3? GINOOCDIOBI, Vector3 CCIDJKMOLDG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface ANBNCEPLFON
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAKDGFGAPEC(EntityQuery NKFJHBACJGC, EntityManager GHGOAAAICCH, HDCONKFMOMB KOHBDHDNGIJ, DCDAGLEECEJ EOHFHEKDECF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface GDDEIEPDCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType IBIHMOHDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBBOOCHHAN(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MOLBOJAKMNP(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBEFLCKNLDP(BJOOKMNONND EBGIKMFALOH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class KBIIOEHAGJA : ANBNCEPLFON
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F2E0", Offset = "0x7E4E4E0", VA = "0x187E4F2E0", Slot = "4")]
	public void AAKDGFGAPEC(EntityQuery NKFJHBACJGC, EntityManager GHGOAAAICCH, HDCONKFMOMB KOHBDHDNGIJ, DCDAGLEECEJ EOHFHEKDECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public KBIIOEHAGJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class APJAHNNLINO : ANBNCEPLFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MFEDJIKCLFM CBCPLGKAOIC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
	public APJAHNNLINO(MFEDJIKCLFM CBCPLGKAOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DE50", Offset = "0x7E3D050", VA = "0x187E3DE50", Slot = "4")]
	public void AAKDGFGAPEC(EntityQuery NKFJHBACJGC, EntityManager GHGOAAAICCH, HDCONKFMOMB KOHBDHDNGIJ, DCDAGLEECEJ EOHFHEKDECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class JBBGEMLPDBA : ANBNCEPLFON
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D420", Offset = "0x7E4C620", VA = "0x187E4D420", Slot = "4")]
	public void AAKDGFGAPEC(EntityQuery NKFJHBACJGC, EntityManager GHGOAAAICCH, HDCONKFMOMB KOHBDHDNGIJ, DCDAGLEECEJ EOHFHEKDECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JBBGEMLPDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AKAMOIBLGIA : GDDEIEPDCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType IBIHMOHDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CB90", Offset = "0x7E3BD90", VA = "0x187E3CB90", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CC10", Offset = "0x7E3BE10", VA = "0x187E3CC10", Slot = "5")]
	public void IDBBOOCHHAN(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CE90", Offset = "0x7E3C090", VA = "0x187E3CE90", Slot = "6")]
	public void MOLBOJAKMNP(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E3CBC0", Offset = "0x7E3BDC0", VA = "0x187E3CBC0", Slot = "7")]
	public void HBEFLCKNLDP(BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public AKAMOIBLGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GMPNLADPAHB : GDDEIEPDCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType IBIHMOHDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E45F70", Offset = "0x7E45170", VA = "0x187E45F70", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E45FF0", Offset = "0x7E451F0", VA = "0x187E45FF0", Slot = "5")]
	public void IDBBOOCHHAN(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E46270", Offset = "0x7E45470", VA = "0x187E46270", Slot = "6")]
	public void MOLBOJAKMNP(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E45FA0", Offset = "0x7E451A0", VA = "0x187E45FA0", Slot = "7")]
	public void HBEFLCKNLDP(BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GMPNLADPAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ALCHDBAOJKF : GDDEIEPDCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType IBIHMOHDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D8D0", Offset = "0x7E3CAD0", VA = "0x187E3D8D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D950", Offset = "0x7E3CB50", VA = "0x187E3D950", Slot = "5")]
	public void IDBBOOCHHAN(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DBD0", Offset = "0x7E3CDD0", VA = "0x187E3DBD0", Slot = "6")]
	public void MOLBOJAKMNP(EntityQuery NKFJHBACJGC, BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D900", Offset = "0x7E3CB00", VA = "0x187E3D900", Slot = "7")]
	public void HBEFLCKNLDP(BJOOKMNONND EBGIKMFALOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public ALCHDBAOJKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class DLHHFADCIFF : JONOCOFLKDO, HGIOMKPLONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HDCONKFMOMB KOHBDHDNGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KFMBDCPEMBA JFDKKNCDKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DCDAGLEECEJ EOHFHEKDECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, ANBNCEPLFON adapter)> MBMBNFOAGJF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E45530", Offset = "0x7E44730", VA = "0x187E45530", Slot = "15")]
	public virtual void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E455C0", Offset = "0x7E447C0", VA = "0x187E455C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E453D0", Offset = "0x7E445D0", VA = "0x187E453D0")]
	private void BIAKBALLFFH(EntityQueryDesc INNHHLMODJH, ANBNCEPLFON KEKMBMCEADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E457F0", Offset = "0x7E449F0", VA = "0x187E457F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DC0", Offset = "0x2B23FC0", VA = "0x182B24DC0")]
	public DLHHFADCIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class IOPGEJCPOLK : JONOCOFLKDO, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IMKEBGLBPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery JLHBKNAKNCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery JCKAMHEMHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery PKDLKCLAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery BHKMFJPIENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery BCKNJMPFOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery AKFDIPLBHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery MLFBAAAMKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GDDEIEPDCIG PGLCIHNFIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType JBBHGACBMEN;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public IMKEBGLBPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HDCONKFMOMB KOHBDHDNGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DCDAGLEECEJ EOHFHEKDECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KFMBDCPEMBA JFDKKNCDKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<IMKEBGLBPJP> MBMBNFOAGJF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CC10", Offset = "0x7E4BE10", VA = "0x187E4CC10", Slot = "14")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CCA0", Offset = "0x7E4BEA0", VA = "0x187E4CCA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CE20", Offset = "0x7E4C020", VA = "0x187E4CE20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C7C0", Offset = "0x7E4B9C0", VA = "0x187E4C7C0")]
	private void IFBOBJJOGMJ(IMKEBGLBPJP HFNMJIMMOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C040", Offset = "0x7E4B240", VA = "0x187E4C040")]
	private void BIAKBALLFFH(GDDEIEPDCIG PGLCIHNFIKN, ComponentType JKNPLHLACPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DC0", Offset = "0x2B23FC0", VA = "0x182B24DC0")]
	public IOPGEJCPOLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct AODLMODDHFM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct PEENOLDGGKD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct CFKCLNIBNMJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(DCDAGLEECEJ), new string[] { })]
public class NHBLNIKAKLF : DCDAGLEECEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CHMGPECIKJJ EMPPGDEDAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CHMGPECIKJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NHBLNIKAKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(ILGGNHIGLIB), new string[] { })]
public class CNILLIENNEO : ILGGNHIGLIB, APJFIENGAAE, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private LANOECBBLFB AFDKGPIKPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private HDCONKFMOMB KOHBDHDNGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private MIPBFCPKCOJ BHGHJPNDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity GAMGDJIGAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private GPGLHFGDHFI PIILKDEHNFG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E44B70", Offset = "0x7E43D70", VA = "0x187E44B70", Slot = "4")]
	public bool NCANLDFLAOH(EBBGNAFIMFG MNPNHJICMND, COFGDNEKJBL KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E448B0", Offset = "0x7E43AB0", VA = "0x187E448B0", Slot = "5")]
	public GPGLHFGDHFI LNAIGLCEHAH()
	{
		return default(GPGLHFGDHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E44C50", Offset = "0x7E43E50", VA = "0x187E44C50", Slot = "6")]
	public void PNCDLNJKAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E44820", Offset = "0x7E43A20", VA = "0x187E44820", Slot = "7")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x11CA4D0", Offset = "0x11C96D0", VA = "0x1811CA4D0", Slot = "8")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public CNILLIENNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(ODDPDOHMGMG), new string[] { })]
public class CMCLHPANIII : ODDPDOHMGMG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E435F0", Offset = "0x7E427F0", VA = "0x187E435F0", Slot = "4")]
	public void CMNNCGBMGGE(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E43540", Offset = "0x7E42740", VA = "0x187E43540", Slot = "5")]
	public void CDPFALEGOBJ(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E434F0", Offset = "0x7E426F0", VA = "0x187E434F0", Slot = "6")]
	public ComponentSystemBase BJMMGNEKHBP(World AFDKGPIKPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E43590", Offset = "0x7E42790", VA = "0x187E43590", Slot = "7")]
	public void CMIFEFJBMLJ(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E43420", Offset = "0x7E42620", VA = "0x187E43420", Slot = "8")]
	public void ADCBPDFFIMD(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E43670", Offset = "0x7E42870", VA = "0x187E43670", Slot = "9")]
	public void CNEEBMKLCAP(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E43480", Offset = "0x7E42680", VA = "0x187E43480", Slot = "10")]
	public void BBFDPJNGOHL(World AFDKGPIKPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E436D0", Offset = "0x7E428D0", VA = "0x187E436D0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> MPIPGGOFGAH()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public CMCLHPANIII()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct CAIBDENFKAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct DILKLDDMKAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EOFBMBEOMHA : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FBCEMHOLLKI EHDBOAHIODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E45A50", Offset = "0x7E44C50", VA = "0x187E45A50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E459E0", Offset = "0x7E44BE0", VA = "0x187E459E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EOFBMBEOMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct FMGAGIBFBPH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GPGLHFGDHFI KFEEDHAAJKI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static FMGAGIBFBPH PDHAGBEBCNG(GPGLHFGDHFI BIFBBDMNGPL)
	{
		return default(FMGAGIBFBPH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BOMGLCMLOIH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JOPFHDFGJHL NNNMCEIDKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E42BD0", Offset = "0x7E41DD0", VA = "0x187E42BD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BOMGLCMLOIH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct KAOKAKPBMPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct JGNPBMINFDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BGBEOAFDOPH JMFLLGMHMPM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static JGNPBMINFDG PDHAGBEBCNG(BGBEOAFDOPH BIFBBDMNGPL)
	{
		return default(JGNPBMINFDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct MOKCGHCIFDP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GPGLHFGDHFI KFEEDHAAJKI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static MOKCGHCIFDP PDHAGBEBCNG(GPGLHFGDHFI BIFBBDMNGPL)
	{
		return default(MOKCGHCIFDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OMHHAGKLMOL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EABGNPNGALB DIKPFEOADOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E565E0", Offset = "0x7E557E0", VA = "0x187E565E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E56570", Offset = "0x7E55770", VA = "0x187E56570", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OMHHAGKLMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DHPBIEJLOKE : LCBGDOLLDNN, FBCEMHOLLKI, MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CALBLPNDMED OAHCAKNONAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD9E5B0", Offset = "0xD9D7B0", VA = "0x180D9E5B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(CALBLPNDMED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KGILOAPKIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC6A590", Offset = "0xC69790", VA = "0x180C6A590", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 ICEOJFKEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1104EC0", Offset = "0x11040C0", VA = "0x181104EC0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E45330", Offset = "0x7E44530", VA = "0x187E45330")]
	public DHPBIEJLOKE(UniformTRS GAEKEPJFGNF, OGCPECJLBAM FLKKOCNDECC, float EMKPAGDHIHO, float3 PEDBALNJPOC, IPAPAOLOGOE HALEFGOCOLG, JMKIOIDBFKN IPJOPNPOCBI, CALBLPNDMED JHKMGLEBLEB, float3 PODHAPAPKLD, bool AAFIEEDLAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E452E0", Offset = "0x7E444E0", VA = "0x187E452E0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GJGCCCLNKNM : LCBGDOLLDNN, EABGNPNGALB, MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<FOAHBAFICDA> AEEFACBDEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NDNJLMAHJJI AJLJPILGNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float JEGINGABLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int GGHELHBAIFA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FGNNFPEONOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E45C10", Offset = "0x7E44E10", VA = "0x187E45C10", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool ADDNJIJFNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E45C30", Offset = "0x7E44E30", VA = "0x187E45C30", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IAFBBNJPGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E45C20", Offset = "0x7E44E20", VA = "0x187E45C20", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PHIICBAEOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDD9A20", Offset = "0xDD8C20", VA = "0x180DD9A20", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float FHGBEKFLKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xCECA70", Offset = "0xCEBC70", VA = "0x180CECA70", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DHGLNINDJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xF51900", Offset = "0xF50B00", VA = "0x180F51900", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E45B60", Offset = "0x7E44D60", VA = "0x187E45B60")]
	public GJGCCCLNKNM(UniformTRS GAEKEPJFGNF, OGCPECJLBAM FLKKOCNDECC, float EMKPAGDHIHO, float3 PEDBALNJPOC, IPAPAOLOGOE HALEFGOCOLG, JMKIOIDBFKN IPJOPNPOCBI, NDNJLMAHJJI AJLJPILGNIP, float JEGINGABLBC, int GGHELHBAIFA, NativeArray<FOAHBAFICDA> AEEFACBDEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x111A760", Offset = "0x1119960", VA = "0x18111A760", Slot = "33")]
	public NativeArray<FOAHBAFICDA> GetNativeCurvePoints()
	{
		return default(NativeArray<FOAHBAFICDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E45AA0", Offset = "0x7E44CA0", VA = "0x187E45AA0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NFAAAFJAPDE : ADEOJPCPEPH, FBCEMHOLLKI, MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<AJCKMHEMCBO, CALBLPNDMED> KHLCCOPOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private CALBLPNDMED JHKMGLEBLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool AAFIEEDLAGJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private CALBLPNDMED PCMGGLOFCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0", Slot = "28")]
		get
		{
			return default(CALBLPNDMED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CMEHBOEGPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xE9F650", Offset = "0xE9E850", VA = "0x180E9F650", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 ICEOJFKEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E52A60", Offset = "0x7E51C60", VA = "0x187E52A60", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E52A40", Offset = "0x7E51C40", VA = "0x187E52A40")]
	public NFAAAFJAPDE(EBBGNAFIMFG DBENCIIAGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E523C0", Offset = "0x7E515C0", VA = "0x187E523C0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E52410", Offset = "0x7E51610", VA = "0x187E52410", Slot = "26")]
	public override void KJFMNLEBHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OIFDIKHHEFM : OCNEGBIIHOA, JOPFHDFGJHL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject DCDOKADPHMP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E55E50", Offset = "0x7E55050", VA = "0x187E55E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DONKIJIPKJK DEGAIHEEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E561C0", Offset = "0x7E553C0", VA = "0x187E561C0", Slot = "15")]
		get
		{
			return default(DONKIJIPKJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OGAOHBCKIEK EEDOPDOLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E56410", Offset = "0x7E55610", VA = "0x187E56410", Slot = "16")]
		get
		{
			return default(OGAOHBCKIEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E562C0", Offset = "0x7E554C0", VA = "0x187E562C0")]
	public OIFDIKHHEFM(EBBGNAFIMFG MNPNHJICMND, bool KHDBNDJJEHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E55EE0", Offset = "0x7E550E0", VA = "0x187E55EE0")]
	public void KGFGKPMBFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E561C0", Offset = "0x7E553C0", VA = "0x187E561C0")]
	protected DONKIJIPKJK PLJKDDBHHMP()
	{
		return default(DONKIJIPKJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E56070", Offset = "0x7E55270", VA = "0x187E56070")]
	private static bool LOJDHOJNAKJ(EBBGNAFIMFG KAEBCFFDMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E55E20", Offset = "0x7E55020", VA = "0x187E55E20", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CMKNDNJECNC : ADEOJPCPEPH, EABGNPNGALB, MOBKHCNBNPA, IDisposable, POJLDBNILMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<FOAHBAFICDA> AEEFACBDEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CMINMLCFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LJNBFCJBJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float JEGINGABLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int GGHELHBAIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool EHBNDMEOJAL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool GOJOAPGPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC777B0", Offset = "0xC769B0", VA = "0x180C777B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool PONPPDBGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E470", Offset = "0xA4D670", VA = "0x180A4E470", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MCDMPGHACFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xDE6A80", Offset = "0xDE5C80", VA = "0x180DE6A80", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int MLBHGJJGOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD9E5B0", Offset = "0xD9D7B0", VA = "0x180D9E5B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool IJAMHEMFBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC6A590", Offset = "0xC69790", VA = "0x180C6A590", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int OHNBFHHLFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E44560", Offset = "0x7E43760", VA = "0x187E44560", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int JJONPEBBKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E446D0", Offset = "0x7E438D0", VA = "0x187E446D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E447F0", Offset = "0x7E439F0", VA = "0x187E447F0")]
	public CMKNDNJECNC(EBBGNAFIMFG DBENCIIAGPJ, [Optional] NativeList<FOAHBAFICDA> AEEFACBDEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E445F0", Offset = "0x7E437F0", VA = "0x187E445F0", Slot = "26")]
	public override void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E44050", Offset = "0x7E43250", VA = "0x187E44050", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E44140", Offset = "0x7E43340", VA = "0x187E44140", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E441A0", Offset = "0x7E433A0", VA = "0x187E441A0")]
	public void ECFNELJFHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E44390", Offset = "0x7E43590", VA = "0x187E44390", Slot = "34")]
	public NativeArray<FOAHBAFICDA> GetNativeCurvePoints()
	{
		return default(NativeArray<FOAHBAFICDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E43F00", Offset = "0x7E43100", VA = "0x187E43F00", Slot = "35")]
	private Vector3 BHKGOCMKMGH(int CIAPLOIMNOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7E447C0", Offset = "0x7E439C0", VA = "0x187E447C0", Slot = "36")]
	private Quaternion NOMFJHCBIOA(int CIAPLOIMNOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E44200", Offset = "0x7E43400", VA = "0x187E44200", Slot = "37")]
	private float EMAMNCCGGGC(int CIAPLOIMNOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7E44580", Offset = "0x7E43780", VA = "0x187E44580")]
	private NativeArray<Entity> JDKDDBMEHBB()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class DFNNGEIIKEB : JOJOGCCFJFE
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7E44EA0", Offset = "0x7E440A0", VA = "0x187E44EA0", Slot = "15")]
	protected override ComponentSystemBase NNKLCEPPGBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E452C0", Offset = "0x7E444C0", VA = "0x187E452C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E452D0", Offset = "0x7E444D0", VA = "0x187E452D0")]
	public DFNNGEIIKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[EPOBOCCNAMD]
public sealed class LODJGEPOBJL : COIPPAKCHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery DLMAILIBBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery DPMHOEOGNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery IPPEDNGINOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery BDNCLIPBHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery LFMNCCJHCJG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E50050", Offset = "0x7E4F250", VA = "0x187E50050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E503B0", Offset = "0x7E4F5B0", VA = "0x187E503B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E503F0", Offset = "0x7E4F5F0", VA = "0x187E503F0")]
	private void PNPHIGLNKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FE90", Offset = "0x7E4F090", VA = "0x187E4FE90")]
	private void EGNGADOGDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FAC0", Offset = "0x7E4ECC0", VA = "0x187E4FAC0")]
	private void CDHNMGNEMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FC90", Offset = "0x7E4EE90", VA = "0x187E4FC90")]
	private void COPBGLJLFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FD90", Offset = "0x7E4EF90", VA = "0x187E4FD90")]
	private void DDCBIFLKJJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FFA0", Offset = "0x7E4F1A0", VA = "0x187E4FFA0")]
	private NativeList<Entity> FBFODAOHBGH(NativeArray<Entity> HBEMCIPCOAI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FA70", Offset = "0x7E4EC70", VA = "0x187E4FA70")]
	private NativeList<Entity> BLIMPDLKJJB(NativeArray<Entity> HBEMCIPCOAI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FFF0", Offset = "0x7E4F1F0", VA = "0x187E4FFF0")]
	private void LKDIMMEHHPO(NativeArray<Entity> HBEMCIPCOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public LODJGEPOBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EPOBOCCNAMD]
public sealed class PKIPCGMMHPJ : COIPPAKCHJD, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery AJMCGLDBBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery FFEKNHBGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery PKDLKCLAOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ILGGNHIGLIB PELBECKOMEP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E57CF0", Offset = "0x7E56EF0", VA = "0x187E57CF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E56BA0", Offset = "0x7E55DA0", VA = "0x187E56BA0", Slot = "15")]
	public override void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E57EC0", Offset = "0x7E570C0", VA = "0x187E57EC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E56C00", Offset = "0x7E55E00", VA = "0x187E56C00")]
	private void JDOCHIJCCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E57660", Offset = "0x7E56860", VA = "0x187E57660")]
	private void OPKELOONMEG(NativeParallelHashSet<GPGLHFGDHFI> IJBMJKOHCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E56FD0", Offset = "0x7E561D0", VA = "0x187E56FD0")]
	private void MMNLAEGIEBO(NativeParallelHashSet<GPGLHFGDHFI> IJBMJKOHCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E567E0", Offset = "0x7E559E0", VA = "0x187E567E0")]
	private void IAMHAJGJKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E56F30", Offset = "0x7E56130", VA = "0x187E56F30")]
	private bool JFHDBAKFDHN(Entity GONFONDIOED, [Out] GPGLHFGDHFI KFEEDHAAJKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E56630", Offset = "0x7E55830", VA = "0x187E56630")]
	private bool HLOJIPHEAJH(Entity GONFONDIOED, [Out] GPGLHFGDHFI KFEEDHAAJKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public PKIPCGMMHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[EPOBOCCNAMD]
public sealed class CIGDOPABPFE : COIPPAKCHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery CPGAGDDCCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery DKKLLPCMDDK;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E43230", Offset = "0x7E42430", VA = "0x187E43230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E43380", Offset = "0x7E42580", VA = "0x187E43380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E42F30", Offset = "0x7E42130", VA = "0x187E42F30")]
	private void OPKELOONMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E42C40", Offset = "0x7E41E40", VA = "0x187E42C40")]
	private void MMNLAEGIEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public CIGDOPABPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NMDJNIDKCJO : COIPPAKCHJD, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct OEJFNODHHHJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob KBDLJAMNPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob GDONEEBMOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob BNOHEEECEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob DLJGPCMFLDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle AMOEDKGLGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<MOKCGHCIFDP> LPIGFCEHLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> EMFDHOCMEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> CPJFHLHAEOD;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E55CC0", Offset = "0x7E54EC0", VA = "0x187E55CC0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E55D40", Offset = "0x7E54F40", VA = "0x187E55D40")]
		private void HIEEPCGJNEP(EntityQueryInJob NKFJHBACJGC, NativeList<Entity> MEPLEJJGOFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct LJKAHHDCBMM : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle AMOEDKGLGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<MOKCGHCIFDP> LPIGFCEHLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> MEPLEJJGOFF;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F830", Offset = "0x7E4EA30", VA = "0x187E4F830", Slot = "4")]
		public void Execute(ArchetypeChunk FBJMFNHIFCA, int AFBFBBCMCPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct GLGNPLPMGGO : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle AMOEDKGLGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> LFJJJBAGCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<JGNPBMINFDG> OPFJLHDPFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<FMGAGIBFBPH> BCOIOLPOOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<MOKCGHCIFDP> IBHFJMPNFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> DBKKCOGEFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<JGNPBMINFDG> KHBFIMFBFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<GPGLHFGDHFI> LIDCFKMJFPO;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E45C40", Offset = "0x7E44E40", VA = "0x187E45C40", Slot = "4")]
		public void Execute(ArchetypeChunk FBJMFNHIFCA, int AFBFBBCMCPA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery KBDLJAMNPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery GDONEEBMOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery BNOHEEECEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery DLJGPCMFLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery IHJOGDAICBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery CCADEBPGKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery LOKOEIOKJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private ILGGNHIGLIB JOCLJGJDIEH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E543D0", Offset = "0x7E535D0", VA = "0x187E543D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E53330", Offset = "0x7E52530", VA = "0x187E53330", Slot = "15")]
	public override void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E54950", Offset = "0x7E53B50", VA = "0x187E54950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E537E0", Offset = "0x7E529E0", VA = "0x187E537E0")]
	private void NNMCOJICBGI(NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC, int EJKFNKKKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E53390", Offset = "0x7E52590", VA = "0x187E53390")]
	private void NHKBIPMGAAN(NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC, int MELGIHCOGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E53F90", Offset = "0x7E53190", VA = "0x187E53F90")]
	private void OKINBFBCPKP(NativeParallelHashSet<GPGLHFGDHFI> BLOGAGBAFAC, int EABDLDIAHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E52FA0", Offset = "0x7E521A0", VA = "0x187E52FA0")]
	private void GBPCEIIPNFC(NativeParallelHashSet<GPGLHFGDHFI> IJBMJKOHCLH, int BIONAMIDEDN, int ACEECKLIBBD, int BAFHMLCNKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E53DE0", Offset = "0x7E52FE0", VA = "0x187E53DE0")]
	private void OJLCPDDNKCD(Entity NCDHHPBCCHF, BGBEOAFDOPH KNNJBKFMIBB, GPGLHFGDHFI KFEEDHAAJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public NMDJNIDKCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class AKMBPAHCEOK : COIPPAKCHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery HMIHAKDGAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery FGJMJNODNIC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D110", Offset = "0x7E3C310", VA = "0x187E3D110", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D350", Offset = "0x7E3C550", VA = "0x187E3D350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public AKMBPAHCEOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JBANPPOJECH : COIPPAKCHJD
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct NKMPLELFOPG : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery OBBLMCFAOKH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D0B0", Offset = "0x7E4C2B0", VA = "0x187E4D0B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D1F0", Offset = "0x7E4C3F0", VA = "0x187E4D1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public JBANPPOJECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[EPOBOCCNAMD]
internal class HLHPNGLFLIG : COIPPAKCHJD
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class GLJJOJDOFAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery AGEFEEPHBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery ENEMILNCBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FCCBONHNPBM FGOENCMHLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType KIALMENHKOB;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public GLJJOJDOFAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void FCCBONHNPBM(NativeArray<BGBEOAFDOPH> BIFBBDMNGPL, BJOOKMNONND EBGIKMFALOH);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<GLJJOJDOFAH> MBMBNFOAGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private KFMBDCPEMBA JFDKKNCDKNM;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B590", Offset = "0x7E4A790", VA = "0x187E4B590", Slot = "15")]
	public override void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B930", Offset = "0x7E4AB30", VA = "0x187E4B930", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BAC0", Offset = "0x7E4ACC0", VA = "0x187E4BAC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A27590", Offset = "0x3A26790", VA = "0x183A27590")]
	private void BIAKBALLFFH<T>(FCCBONHNPBM FGOENCMHLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B790", Offset = "0x7E4A990", VA = "0x187E4B790")]
	private static void LDEKAJDCPEO(NativeArray<BGBEOAFDOPH> ILJPGEOGGKI, BJOOKMNONND CJPNHGAAAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B5F0", Offset = "0x7E4A7F0", VA = "0x187E4B5F0")]
	private static void JJLPPAHFJOK(NativeArray<BGBEOAFDOPH> ILJPGEOGGKI, BJOOKMNONND CJPNHGAAAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B3F0", Offset = "0x7E4A5F0", VA = "0x187E4B3F0")]
	private static void BHDKJDPPLBF(NativeArray<BGBEOAFDOPH> ILJPGEOGGKI, BJOOKMNONND CJPNHGAAAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public HLHPNGLFLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EPOBOCCNAMD]
public sealed class MINEOLCJOHP : COIPPAKCHJD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery NKFJHBACJGC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E51EF0", Offset = "0x7E510F0", VA = "0x187E51EF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ODCAGAENPIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS GAEKEPJFGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData EOHEOHGPMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public CALBLPNDMED JHKMGLEBLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PODHAPAPKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool AAFIEEDLAGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IMLOLMKNCJP(Lifetime.LoadInstance)]
public struct MIPBJAIHKJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FFNEFMEEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> BODMFCLHIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> BJKNMEBEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<ODCAGAENPIF> HBJNHJHKEHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E52330", Offset = "0x7E51530", VA = "0x187E52330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(MFAKDKDJIDL), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class MFAKDKDJIDL : HGIOMKPLONA, EJADEOIPJPK, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NHDJILOIOJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly MFAKDKDJIDL FLKKOCNDECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool KNDNMLLNPEH;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x18CDBA0", Offset = "0x18CCDA0", VA = "0x1818CDBA0")]
		public NHDJILOIOJN(MFAKDKDJIDL FLKKOCNDECC, bool KNDNMLLNPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E52B30", Offset = "0x7E51D30", VA = "0x187E52B30")]
		public Queue<KEIIIOENBNM>.Enumerator BFKODFEKGDL()
		{
			return default(Queue<KEIIIOENBNM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E52BF0", Offset = "0x7E51DF0", VA = "0x187E52BF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private MIPBFCPKCOJ LBLOMJNHNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private INAOMOHBGFI CEBJIJLNOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<FOAHBAFICDA>> KMLMOLKKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> GPBCPHPOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<BGBEOAFDOPH> GKDBGJFMCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NOCGFFCFADK<KEIIIOENBNM> ANPEMNGMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NOCGFFCFADK<MIPBJAIHKJI> LIIEHLAPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NOCGFFCFADK<GGPLJGBCMIP> EIHBLHJKBPA;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E51410", Offset = "0x7E50610", VA = "0x187E51410", Slot = "4")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E51610", Offset = "0x7E50810", VA = "0x187E51610")]
	public void OBAEDMFHADF(NativeList<FOAHBAFICDA> BACDLJGLPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E51050", Offset = "0x7E50250", VA = "0x187E51050")]
	public void DFMNEBPBGLH(Entity FLKKOCNDECC, [In] NKNHMBEFOJB<GameObject> JAANNPCPFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E511A0", Offset = "0x7E503A0", VA = "0x187E511A0")]
	public void EBBNKOPBOLE(NativeList<BGBEOAFDOPH> ILJPGEOGGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E50DB0", Offset = "0x7E4FFB0", VA = "0x187E50DB0")]
	public void CNEEBMKLCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E516C0", Offset = "0x7E508C0", VA = "0x187E516C0")]
	public void OEJEKGPHCGE(NBLECBFEIMG OBHJPIMFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E51230", Offset = "0x7E50430", VA = "0x187E51230")]
	public JobHandle ELMNNCCEHHF([In] KEIIIOENBNM NPEJLHCJPAI, JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E512D0", Offset = "0x7E504D0", VA = "0x187E512D0")]
	public JobHandle ELMNNCCEHHF([In] MIPBJAIHKJI NPEJLHCJPAI, JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7AECD90", Offset = "0x7AEBF90", VA = "0x187AECD90")]
	public NHDJILOIOJN ACHKFPJOGFP(bool KNDNMLLNPEH)
	{
		return default(NHDJILOIOJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E513C0", Offset = "0x7E505C0", VA = "0x187E513C0")]
	public PNIFAKFDDDJ<MIPBJAIHKJI> IKCCAOBLOBH()
	{
		return default(PNIFAKFDDDJ<MIPBJAIHKJI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E51370", Offset = "0x7E50570", VA = "0x187E51370")]
	public PNIFAKFDDDJ<GGPLJGBCMIP> HKDCDMNANPA()
	{
		return default(PNIFAKFDDDJ<GGPLJGBCMIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7E51B70", Offset = "0x7E50D70", VA = "0x187E51B70")]
	public void OLKFAGPLGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E51D90", Offset = "0x7E50F90", VA = "0x187E51D90", Slot = "5")]
	public void PNAGKOGGHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E50FE0", Offset = "0x7E501E0", VA = "0x187E50FE0", Slot = "6")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x11D7350", Offset = "0x11D6550", VA = "0x1811D7350", Slot = "7")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public MFAKDKDJIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KOMINMNOFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS GAEKEPJFGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData EOHEOHGPMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public FLHGMAEFHJA AJLJPILGNIP;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IMLOLMKNCJP(Lifetime.LoadInstance)]
public struct KEIIIOENBNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity FFNEFMEEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> BODMFCLHIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> BJKNMEBEHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<BMJBNELGBIH> HFKPDDAKOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<FOAHBAFICDA> BACDLJGLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<KOMINMNOFJD> EEBPIJLEDHD;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F5B0", Offset = "0x7E4E7B0", VA = "0x187E4F5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F4E0", Offset = "0x7E4E6E0", VA = "0x187E4F4E0")]
	public void BHPGJKNEABL(bool KNDNMLLNPEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(NINLNAEOEEK), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class NINLNAEOEEK : GDMDHKNHDMK, LNIDKKDBPDJ, OBFJDPCMLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private MFAKDKDJIDL PPKHOFNLHDA;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E52F80", Offset = "0x7E52180", VA = "0x187E52F80", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E52F30", Offset = "0x7E52130", VA = "0x187E52F30", Slot = "5")]
	private void DDIHEPEDMIL(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1187CA0", Offset = "0x1186EA0", VA = "0x181187CA0", Slot = "6")]
	private void OEBCMEIKBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NINLNAEOEEK()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : COIPPAKCHJD, HGIOMKPLONA
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
			public NativeParallelHashMap<int, CALBLPNDMED> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<ODCAGAENPIF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7E464F0", Offset = "0x7E456F0", VA = "0x187E464F0", Slot = "4")]
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
			public NativeArray<FOAHBAFICDA> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<BMJBNELGBIH> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<KOMINMNOFJD> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7E46890", Offset = "0x7E45A90", VA = "0x187E46890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E44D60", Offset = "0x7E43F60", VA = "0x187E44D60", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7E57FB0", Offset = "0x7E571B0", VA = "0x187E57FB0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7E57F60", Offset = "0x7E57160", VA = "0x187E57F60")]
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
				float3 GCBMLPNCPLP(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7E50650", Offset = "0x7E4F850", VA = "0x187E50650", Slot = "5")]
				public float3 FLFAAJCPPBK(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7E509F0", Offset = "0x7E4FBF0", VA = "0x187E509F0", Slot = "4")]
				public float3 GCBMLPNCPLP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7E54CE0", Offset = "0x7E53EE0", VA = "0x187E54CE0", Slot = "4")]
				public float3 GCBMLPNCPLP(quaternion rotation)
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
			public NativeArray<BMJBNELGBIH> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<FOAHBAFICDA> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7E48120", Offset = "0x7E47320", VA = "0x187E48120", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E47040", Offset = "0x7E46240", VA = "0x187E47040")]
			private void BPIABMHCDFG(NativeList<PointSrcData> srcData, NativeList<FOAHBAFICDA> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E4A500", Offset = "0x7E49700", VA = "0x187E4A500")]
			public static Vector3 MGAHKEJGFOI(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E47F20", Offset = "0x7E47120", VA = "0x187E47F20")]
			public static quaternion CEBCNINMMPF(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7E48740", Offset = "0x7E47940", VA = "0x187E48740")]
			private static quaternion FAMPDOGFDKK(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E4ACB0", Offset = "0x7E49EB0", VA = "0x187E4ACB0")]
			private static float3 OCKNLAHBLLG(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E46FB0", Offset = "0x7E461B0", VA = "0x187E46FB0")]
			private static quaternion ACLLKLNHECH(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7E48F80", Offset = "0x7E48180", VA = "0x187E48F80")]
			private static FOAHBAFICDA HHCJGPGKEMK(int idx, NativeList<PointSrcData> srcData)
			{
				return default(FOAHBAFICDA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4139F10", Offset = "0x4139110", VA = "0x184139F10")]
			private void KLMKIHEKHFI<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7E491F0", Offset = "0x7E483F0", VA = "0x187E491F0")]
			private void JCMFPKECDJG(NativeList<PointSrcData> sourcePoints, NativeList<FOAHBAFICDA> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7E47FA0", Offset = "0x7E471A0", VA = "0x187E47FA0")]
			public static float CNKOFEHJKBE(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E4A910", Offset = "0x7E49B10", VA = "0x187E4A910")]
			private static quaternion NAIFBMACAMN(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7E48C80", Offset = "0x7E47E80", VA = "0x187E48C80")]
			private static FOAHBAFICDA GAPJKGJCFEF(PointSrcData point)
			{
				return default(FOAHBAFICDA);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E48BF0", Offset = "0x7E47DF0", VA = "0x187E48BF0")]
			private static FOAHBAFICDA GAPJKGJCFEF(float3 pos, quaternion rot, float radius)
			{
				return default(FOAHBAFICDA);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E4A000", Offset = "0x7E49200", VA = "0x187E4A000")]
			private static bool JPNAIOILPPP(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E48B20", Offset = "0x7E47D20", VA = "0x187E48B20")]
			private static float3 FONBPIAEGPJ(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E4AB00", Offset = "0x7E49D00", VA = "0x187E4AB00")]
			public static float3 NAJJPMPEHOC(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7E48970", Offset = "0x7E47B70", VA = "0x187E48970")]
			public static float3 FLFAAJCPPBK(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E4A0A0", Offset = "0x7E492A0", VA = "0x187E4A0A0")]
			private static quaternion KAFKJEENOMC(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E48DA0", Offset = "0x7E47FA0", VA = "0x187E48DA0")]
			private static float GLBDLGJKHKM(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7E5A340", Offset = "0x7E59540", VA = "0x187E5A340")]
			private void NKHHELGLHMD(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7E5A250", Offset = "0x7E59450", VA = "0x187E5A250", Slot = "4")]
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
			public NativeList<FOAHBAFICDA> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B9A0", Offset = "0x7E5ABA0", VA = "0x187E5B9A0")]
			private void NKHHELGLHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B990", Offset = "0x7E5AB90", VA = "0x187E5B990", Slot = "4")]
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
			public NativeList<FOAHBAFICDA> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B940", Offset = "0x7E5AB40", VA = "0x187E5B940")]
			private void NKHHELGLHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B930", Offset = "0x7E5AB30", VA = "0x187E5B930", Slot = "4")]
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
			public NativeList<ODCAGAENPIF> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7E46BE0", Offset = "0x7E45DE0", VA = "0x187E46BE0")]
			private void NKHHELGLHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E46BD0", Offset = "0x7E45DD0", VA = "0x187E46BD0", Slot = "4")]
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
			public NativeList<BMJBNELGBIH> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<KOMINMNOFJD> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7E46DB0", Offset = "0x7E45FB0", VA = "0x187E46DB0")]
			private void NKHHELGLHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7E46DA0", Offset = "0x7E45FA0", VA = "0x187E46DA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5B510", Offset = "0x7E5A710", VA = "0x187E5B510")]
			private void NKHHELGLHMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E5B500", Offset = "0x7E5A700", VA = "0x187E5B500", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly KEPOMIIOHBM log;

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
		private KPJGFGIGDHN replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MIPBFCPKCOJ objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private MFAKDKDJIDL bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private LGFABBDAFGD ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E59710", Offset = "0x7E58910", VA = "0x187E59710", Slot = "15")]
		public override void InitReferences(EENCHNOCEIL services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B0E0", Offset = "0x7E5A2E0", VA = "0x187E5B0E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B1D0", Offset = "0x7E5A3D0", VA = "0x187E5B1D0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B230", Offset = "0x7E5A430", VA = "0x187E5B230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E597B0", Offset = "0x7E589B0", VA = "0x187E597B0")]
		private JobHandle KADAPJJICCG(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E59B90", Offset = "0x7E58D90", VA = "0x187E59B90")]
		private JobHandle KOPGGADMOHF(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E59AF0", Offset = "0x7E58CF0", VA = "0x187E59AF0")]
		private JobHandle NJBOBMBAJCI(NativeArray<int> pointCount, NativeList<FOAHBAFICDA> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E57FD0", Offset = "0x7E571D0", VA = "0x187E57FD0")]
		private JobHandle EMBJLJHFCDG(NativeList<FOAHBAFICDA> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A420", Offset = "0x7E59620", VA = "0x187E5A420")]
		private JobHandle MCICOGDKGIO(EntityQuery query, NativeList<BMJBNELGBIH> splinePointRanges, NativeList<FOAHBAFICDA> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E59100", Offset = "0x7E58300", VA = "0x187E59100")]
		private JobHandle IGPAPKJPAGL(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E589A0", Offset = "0x7E57BA0", VA = "0x187E589A0")]
		private JobHandle FPIDAPHBCKF(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A8F0", Offset = "0x7E59AF0", VA = "0x187E5A8F0")]
		private JobHandle OFDKKGJPCIJ(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<ODCAGAENPIF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E58AC0", Offset = "0x7E57CC0", VA = "0x187E58AC0")]
		private JobHandle GFOGHMCIAEC(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<BMJBNELGBIH> splinePointRanges, [Out] NativeList<KOMINMNOFJD> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E58D80", Offset = "0x7E57F80", VA = "0x187E58D80")]
		private JobHandle IAHIEOLOOKB(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E58070", Offset = "0x7E57270", VA = "0x187E58070")]
		private JobHandle DNAMPCIOCFF(EntityQuery query, NativeList<ODCAGAENPIF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E58580", Offset = "0x7E57780", VA = "0x187E58580")]
		private static NativeParallelHashMap<int, CALBLPNDMED> ELNEFPPCEOC()
		{
			return default(NativeParallelHashMap<int, CALBLPNDMED>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7E59370", Offset = "0x7E58570", VA = "0x187E59370")]
		private JobHandle IJGDKHJHMDL(EntityQuery query, NativeList<BMJBNELGBIH> splinePointRanges, NativeList<FOAHBAFICDA> splinePointData, NativeList<KOMINMNOFJD> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B3A0", Offset = "0x7E5A5A0", VA = "0x187E5B3A0")]
		private JobHandle PEAKIKIOCKN(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E59AF0", Offset = "0x7E58CF0", VA = "0x187E59AF0")]
		private JobHandle KLKMCEKKPLG(NativeArray<int> pointCount, NativeList<FOAHBAFICDA> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E57FD0", Offset = "0x7E571D0", VA = "0x187E57FD0")]
		private JobHandle CPICHCKMJAA(NativeList<FOAHBAFICDA> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AB90", Offset = "0x7E59D90", VA = "0x187E5AB90")]
		private JobHandle OHFJDMKMJJM(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<ODCAGAENPIF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AC80", Offset = "0x7E59E80", VA = "0x187E5AC80")]
		private JobHandle OPFKILJMONJ(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<BMJBNELGBIH> ranges, NativeList<KOMINMNOFJD> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7E59220", Offset = "0x7E58420", VA = "0x187E59220")]
		private JobHandle IHIFHGFNDIH(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AD90", Offset = "0x7E59F90", VA = "0x187E5AD90", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LBPPGNMMNID : JONOCOFLKDO, HGIOMKPLONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private MFAKDKDJIDL PPKHOFNLHDA;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F5C0", Offset = "0x7E4E7C0", VA = "0x187E4F5C0", Slot = "14")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F610", Offset = "0x7E4E810", VA = "0x187E4F610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DC0", Offset = "0x2B23FC0", VA = "0x182B24DC0")]
	public LBPPGNMMNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class BKLCJDNPCOD : COIPPAKCHJD, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct JDHFLJEHHPE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager GHGOAAAICCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private FHJAMJKLBKH<T> BGABGJOGKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int CMDFFDAPDIB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x502CA60", Offset = "0x502BC60", VA = "0x18502CA60")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x502CCA0", Offset = "0x502BEA0", VA = "0x18502CCA0")]
		public JDHFLJEHHPE(EntityManager GHGOAAAICCH, FHJAMJKLBKH<T> BGABGJOGKGI, NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4784AB0", Offset = "0x4783CB0", VA = "0x184784AB0")]
		public JDHFLJEHHPE<T> BFKODFEKGDL()
		{
			return default(JDHFLJEHHPE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x502C2E0", Offset = "0x502B4E0", VA = "0x18502C2E0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly KEPOMIIOHBM CKKOBMAPJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private INAOMOHBGFI CEBJIJLNOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MFAKDKDJIDL PPKHOFNLHDA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E409D0", Offset = "0x7E3FBD0", VA = "0x187E409D0", Slot = "15")]
	public override void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DFA0", Offset = "0x7E3D1A0", VA = "0x187E3DFA0")]
	public void BBFDPJNGOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E41990", Offset = "0x7E40B90", VA = "0x187E41990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E6A0", Offset = "0x7E3D8A0", VA = "0x187E3E6A0")]
	private void DKKLCDGNECO(GGPLJGBCMIP NPEJLHCJPAI, Mesh[] ECMMPHFCBLK, NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x378FBC0", Offset = "0x378EDC0", VA = "0x18378FBC0")]
	private JDHFLJEHHPE<T> OGFLJBHNLBG<T>(FHJAMJKLBKH<T> BGABGJOGKGI, NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD) where T : struct
	{
		return default(JDHFLJEHHPE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E41610", Offset = "0x7E40810", VA = "0x187E41610")]
	private void OPBDHDFIGDN(Transform FLKKOCNDECC, NativeArray<BMPHLPEDAAK> GMCKFDMEOEG, NKNHMBEFOJB<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E090", Offset = "0x7E3D290", VA = "0x187E3E090")]
	private void BLMIKFOCOJE(Transform FLKKOCNDECC, NativeArray<OCOEFNLIKCH> AAHKHFOLDGD, NKNHMBEFOJB<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E40100", Offset = "0x7E3F300", VA = "0x187E40100")]
	private void EMPDNOHCKBI(Transform FLKKOCNDECC, NativeArray<ACENFOOBIAC> AIPFEGFILNG, NKNHMBEFOJB<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7E3FCD0", Offset = "0x7E3EED0", VA = "0x187E3FCD0")]
	private void DPNCNBBGCAB(Transform FLKKOCNDECC, NativeArray<GPCFBPDBMEN> ECMMPHFCBLK, Mesh[] JKJPNIKBBDM, NKNHMBEFOJB<GameObject> EAFNNDGEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E550", Offset = "0x7E3D750", VA = "0x187E3E550")]
	private static void DIKBJMIOICI(NativeParallelHashSet<Entity> HBEMCIPCOAI, NativeParallelHashSet<Entity> KFMADDMOPIE, NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DFD0", Offset = "0x7E3D1D0", VA = "0x187E3DFD0")]
	private static void BCJGGCEFKIK(NativeList<Entity> CFFEIIKPOPD, NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7E40A50", Offset = "0x7E3FC50", VA = "0x187E40A50")]
	private NativeParallelHashMap<Entity, FMGAGIBFBPH> KHIBCHPGLCC(MFAKDKDJIDL.NHDJILOIOJN HPGKBGDLJOF, PNIFAKFDDDJ<MIPBJAIHKJI> KLNOKDLGEDO, List<GameObject> EAFNNDGEDKP)
	{
		return default(NativeParallelHashMap<Entity, FMGAGIBFBPH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7E404E0", Offset = "0x7E3F6E0", VA = "0x187E404E0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> GCKNKLKJKIN(Entity PNCDMNJEHIM)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F780", Offset = "0x7E3E980", VA = "0x187E3F780")]
	private void DNGAMNOLJKI(NativeList<Entity> CAENHAKKNGI, NativeList<Entity> IBHIMHPGMAC, NativeParallelHashMap<Entity, FMGAGIBFBPH> MCLLMGIJCAH, NativeList<BMJBNELGBIH> IBKOPGFBDCH, NativeList<FOAHBAFICDA> APHKNEGLNNJ, NativeList<KOMINMNOFJD> KMLMOLKKJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E405E0", Offset = "0x7E3F7E0", VA = "0x187E405E0")]
	private void GNPOFJLJFHN(NativeList<Entity> HBEMCIPCOAI, NativeList<Entity> BODMFCLHIMI, NativeParallelHashMap<Entity, FMGAGIBFBPH> MCLLMGIJCAH, NativeList<ODCAGAENPIF> HBJNHJHKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8C0", Offset = "0x7E3CAC0", VA = "0x187E3D8C0")]
	public BKLCJDNPCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class HBJICBFBLLC : AEAEHHIPDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS GAEKEPJFGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly OGCPECJLBAM FLKKOCNDECC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject GCNOFFNOCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS INNEJOHAJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AF10", Offset = "0x7E4A110", VA = "0x187E4AF10", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 GMAFCMPPNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B0E0", Offset = "0x7E4A2E0", VA = "0x187E4B0E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 FGEKBLPENNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B040", Offset = "0x7E4A240", VA = "0x187E4B040", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 HAMJKPMFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B270", Offset = "0x7E4A470", VA = "0x187E4B270", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B130", Offset = "0x7E4A330", VA = "0x187E4B130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion OLNCGCKBNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B180", Offset = "0x7E4A380", VA = "0x187E4B180", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B1D0", Offset = "0x7E4A3D0", VA = "0x187E4B1D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 PICNBKPALLL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B090", Offset = "0x7E4A290", VA = "0x187E4B090", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 IHFOPPNFPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AFF0", Offset = "0x7E4A1F0", VA = "0x187E4AFF0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 AIOPLDEPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B220", Offset = "0x7E4A420", VA = "0x187E4B220", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B2C0", Offset = "0x7E4A4C0", VA = "0x187E4B2C0")]
	public HBJICBFBLLC(UniformTRS GAEKEPJFGNF, OGCPECJLBAM FLKKOCNDECC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class LCBGDOLLDNN : HBJICBFBLLC, MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float EMKPAGDHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 PEDBALNJPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly IPAPAOLOGOE HALEFGOCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly JMKIOIDBFKN IPJOPNPOCBI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private DONKIJIPKJK PNJHINKOLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F710", Offset = "0x7E4E910", VA = "0x187E4F710", Slot = "17")]
		get
		{
			return default(DONKIJIPKJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS BDHFOKJPNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F630", Offset = "0x7E4E830", VA = "0x187E4F630", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float HBEMNGAGDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC56240", Offset = "0xC55440", VA = "0x180C56240", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 GDJCCMJEDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F760", Offset = "0x7E4E960", VA = "0x187E4F760", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IPAPAOLOGOE FIEONLLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xECFF00", Offset = "0xECF100", VA = "0x180ECFF00", Slot = "21")]
		get
		{
			return default(IPAPAOLOGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private JMKIOIDBFKN JMJPPHAENKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xF74AF0", Offset = "0xF73CF0", VA = "0x180F74AF0", Slot = "22")]
		get
		{
			return default(JMKIOIDBFKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool EDHKLEHPHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CFLIEIANFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F7B0", Offset = "0x7E4E9B0", VA = "0x187E4F7B0")]
	protected LCBGDOLLDNN(UniformTRS GAEKEPJFGNF, OGCPECJLBAM FLKKOCNDECC, float EMKPAGDHIHO, float3 PEDBALNJPOC, IPAPAOLOGOE HALEFGOCOLG, JMKIOIDBFKN IPJOPNPOCBI)
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
public abstract class OCNEGBIIHOA : AEAEHHIPDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly EBBGNAFIMFG PMOPIAOAEIC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected OGCPECJLBAM CGNKBCKBMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x11986B0", Offset = "0x11978B0", VA = "0x1811986B0")]
		get
		{
			return default(OGCPECJLBAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity JICIEFKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7E55570", Offset = "0x7E54770", VA = "0x187E55570")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected MIPBFCPKCOJ ILKAAAENLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7E55B80", Offset = "0x7E54D80", VA = "0x187E55B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected EIMDFMFNNAG PDLLLCCCCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7E55000", Offset = "0x7E54200", VA = "0x187E55000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected MLACKGMOCIO CGELCHDENFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7E55A90", Offset = "0x7E54C90", VA = "0x187E55A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject GCNOFFNOCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7E55B20", Offset = "0x7E54D20", VA = "0x187E55B20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS INNEJOHAJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x11CB770", Offset = "0x11CA970", VA = "0x1811CB770", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 GMAFCMPPNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7E55480", Offset = "0x7E54680", VA = "0x187E55480", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 FGEKBLPENNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E55220", Offset = "0x7E54420", VA = "0x187E55220", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 HAMJKPMFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7E55B90", Offset = "0x7E54D90", VA = "0x187E55B90", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7E55590", Offset = "0x7E54790", VA = "0x187E55590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion OLNCGCKBNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7E556A0", Offset = "0x7E548A0", VA = "0x187E556A0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7E557C0", Offset = "0x7E549C0", VA = "0x187E557C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 PICNBKPALLL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7E55390", Offset = "0x7E54590", VA = "0x187E55390", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 IHFOPPNFPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E55060", Offset = "0x7E54260", VA = "0x187E55060", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 AIOPLDEPJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7E558D0", Offset = "0x7E54AD0", VA = "0x187E558D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xE50430", Offset = "0xE4F630", VA = "0x180E50430")]
	protected OCNEGBIIHOA(EBBGNAFIMFG DBENCIIAGPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E55B50", Offset = "0x7E54D50", VA = "0x187E55B50")]
	public static DONKIJIPKJK PDHAGBEBCNG(OCNEGBIIHOA DACBPJEFOKJ)
	{
		return default(DONKIJIPKJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KLIPDDADCGA
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D4D0", Offset = "0x7E5C6D0", VA = "0x187E5D4D0")]
	public static void CHNALKPGLAH(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class BCNNOILICOO
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CE30", Offset = "0x7E5C030", VA = "0x187E5CE30")]
	public static void OBGMDDJLCFJ(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH, NBLECBFEIMG OIENLIBHJIE, MIPBFCPKCOJ BHGHJPNDBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CB20", Offset = "0x7E5BD20", VA = "0x187E5CB20")]
	public static void LBCMKPHLIEB(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH, NBLECBFEIMG OIENLIBHJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CAA0", Offset = "0x7E5BCA0", VA = "0x187E5CAA0")]
	public static NativeList<Entity> BLIMPDLKJJB(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CAE0", Offset = "0x7E5BCE0", VA = "0x187E5CAE0")]
	public static NativeList<Entity> FBFODAOHBGH(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C840", Offset = "0x7E5BA40", VA = "0x187E5C840")]
	private static NativeList<Entity> BLIMPDLKJJB(NativeArray<Entity> HBEMCIPCOAI, EntityManager GHGOAAAICCH, bool PPPIJDINFIG)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class ADEOJPCPEPH : OCNEGBIIHOA, MOBKHCNBNPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float EMKPAGDHIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 PEDBALNJPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private IPAPAOLOGOE HALEFGOCOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private JMKIOIDBFKN IPJOPNPOCBI;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager EPHJNECDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C470", Offset = "0x7E5B670", VA = "0x187E5C470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected LANOECBBLFB OAOPEPGHMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C7B0", Offset = "0x7E5B9B0", VA = "0x187E5C7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData FBPAJMGBIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C530", Offset = "0x7E5B730", VA = "0x187E5C530")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private DONKIJIPKJK PNJHINKOLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7E55B50", Offset = "0x7E54D50", VA = "0x187E55B50", Slot = "17")]
		get
		{
			return default(DONKIJIPKJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float HBEMNGAGDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1104F70", Offset = "0x1104170", VA = "0x181104F70", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 GDJCCMJEDHP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x127BBC0", Offset = "0x127ADC0", VA = "0x18127BBC0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private IPAPAOLOGOE FIEONLLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0", Slot = "21")]
		get
		{
			return default(IPAPAOLOGOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private JMKIOIDBFKN JMJPPHAENKO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xCB7D00", Offset = "0xCB6F00", VA = "0x180CB7D00", Slot = "22")]
		get
		{
			return default(JMKIOIDBFKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS BDHFOKJPNOM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C500", Offset = "0x7E5B700", VA = "0x187E5C500", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CFLIEIANFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA2F4A0", Offset = "0xA2E6A0", VA = "0x180A2F4A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA2F2C0", Offset = "0xA2E4C0", VA = "0x180A2F2C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool EDHKLEHPHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C810", Offset = "0x7E5BA10", VA = "0x187E5C810")]
	protected ADEOJPCPEPH(EBBGNAFIMFG DBENCIIAGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C620", Offset = "0x7E5B820", VA = "0x187E5C620", Slot = "26")]
	public virtual void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class COIPPAKCHJD : JONOCOFLKDO, HGIOMKPLONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected MIPBFCPKCOJ BHGHJPNDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private HDCONKFMOMB KOHBDHDNGIJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected NBLECBFEIMG LNBDOGNFPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D2A0", Offset = "0x7E5C4A0", VA = "0x187E5D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected BJOOKMNONND HBPKJPOMDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D2F0", Offset = "0x7E5C4F0", VA = "0x187E5D2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool AONABAILCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D3B0", Offset = "0x7E5C5B0", VA = "0x187E5D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D340", Offset = "0x7E5C540", VA = "0x187E5D340", Slot = "15")]
	public virtual void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DC0", Offset = "0x2B23FC0", VA = "0x182B24DC0")]
	protected COIPPAKCHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ONMBDKPEIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D770", Offset = "0x7E5C970", VA = "0x187E5D770")]
	public static void HAPGDBHABOI(NativeArray<Entity> CAENHAKKNGI, EntityManager GHGOAAAICCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4182317777
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DB80", Offset = "0x7E5CD80", VA = "0x187E5DB80")]
	public static void KJOJENNPCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DB70", Offset = "0x7E5CD70", VA = "0x187E5DB70")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CBILMEPPIKG : ContainerPropertyBag<EOFBMBEOMHA>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D240", Offset = "0x7E5C440", VA = "0x187E5D240")]
	public CBILMEPPIKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class HHKJOGGLENJ : ContainerPropertyBag<BOMGLCMLOIH>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D470", Offset = "0x7E5C670", VA = "0x187E5D470")]
	public HHKJOGGLENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class KMABMFFDCLB : ContainerPropertyBag<OMHHAGKLMOL>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D710", Offset = "0x7E5C910", VA = "0x187E5D710")]
	public KMABMFFDCLB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D9B0", Offset = "0x7E5CBB0", VA = "0x187E5D9B0")]
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
