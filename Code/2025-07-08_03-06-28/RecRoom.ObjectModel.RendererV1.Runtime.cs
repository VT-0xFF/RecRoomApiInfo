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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82BFAE0", Offset = "0x82BE8E0", VA = "0x1882BFAE0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8278050", Offset = "0x8276E50", VA = "0x188278050", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82CE680", Offset = "0x82CD480", VA = "0x1882CE680")]
		private void AFKHLAMEPCM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82CEC10", Offset = "0x82CDA10", VA = "0x1882CEC10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82CEC70", Offset = "0x82CDA70", VA = "0x1882CEC70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KCJACBGNEIF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82BBE60", Offset = "0x82BAC60", VA = "0x1882BBE60")]
	public static Quaternion HCPHGOEAIHL([In] this FAOEDIHHGLD EKJEEABCOBB, [In] Vector3 NCJMIJBPLIB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OIFIGIGOGCI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82C7E30", Offset = "0x82C6C30", VA = "0x1882C7E30")]
	public static bool AIEGPLBDCBE(this HBGMJPLFBFM BJIHLOBCEHA, BKLCIIPAJGH DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82C85D0", Offset = "0x82C73D0", VA = "0x1882C85D0")]
	public static bool GJPHPMJNCGC(this HBGMJPLFBFM BJIHLOBCEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x82C7E70", Offset = "0x82C6C70", VA = "0x1882C7E70")]
	public static bool AJHPGPLDEJF(this HBGMJPLFBFM BJIHLOBCEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82C8140", Offset = "0x82C6F40", VA = "0x1882C8140")]
	public static void EOBDAINDIBM(this HBGMJPLFBFM BJIHLOBCEHA, Vector3 JGLFFAFJAON, Quaternion LHKAMIJBIAE, float LNLGAMEGNNM, bool JILMNJOJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82C8930", Offset = "0x82C7730", VA = "0x1882C8930")]
	public static void KEDNFMGOJCL(this HBGMJPLFBFM BJIHLOBCEHA, Vector3 JGLFFAFJAON, Quaternion LHKAMIJBIAE, float LNLGAMEGNNM, int IMBBBOKAKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82C8270", Offset = "0x82C7070", VA = "0x1882C8270")]
	public static void FICDFEHMAAJ(this HBGMJPLFBFM BJIHLOBCEHA, int IMBBBOKAKNL, Vector3 JGLFFAFJAON, Quaternion LHKAMIJBIAE, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82C8580", Offset = "0x82C7380", VA = "0x1882C8580")]
	public static void GJGOKAPCAOL(this HBGMJPLFBFM BJIHLOBCEHA, Vector3 IMEKHDLJLMC, Quaternion EKHKEOPFAJD, float LNLGAMEGNNM, bool JILMNJOJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82C90B0", Offset = "0x82C7EB0", VA = "0x1882C90B0")]
	private static void MPIPILILLPD(this HBGMJPLFBFM BJIHLOBCEHA, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM, bool JILMNJOJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82C9A40", Offset = "0x82C8840", VA = "0x1882C9A40")]
	private static void PKPDLNPMCLK(this HBGMJPLFBFM BJIHLOBCEHA, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL, float MDPLINMNADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82C8390", Offset = "0x82C7190", VA = "0x1882C8390")]
	private static void GCBBPOPJPKE(this HBGMJPLFBFM BJIHLOBCEHA, int CKFKPOAGPKN, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL, float MDPLINMNADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82C9A10", Offset = "0x82C8810", VA = "0x1882C9A10")]
	private static bool PDNFAKHJGLP(this HBGMJPLFBFM BJIHLOBCEHA, int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82C7EA0", Offset = "0x82C6CA0", VA = "0x1882C7EA0")]
	private static void BJCPHPGFIBM(this HBGMJPLFBFM BJIHLOBCEHA, int CKFKPOAGPKN, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL, float MDPLINMNADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82C8BC0", Offset = "0x82C79C0", VA = "0x1882C8BC0")]
	public static Vector3 MKNAGHFBDGE(this HBGMJPLFBFM BJIHLOBCEHA, int CKFKPOAGPKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82C8600", Offset = "0x82C7400", VA = "0x1882C8600")]
	public static Quaternion GPAKHJFMOCE(this HBGMJPLFBFM BJIHLOBCEHA, int CKFKPOAGPKN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82C8710", Offset = "0x82C7510", VA = "0x1882C8710")]
	public static Vector3 IOMDHJIPFEB(BKLCIIPAJGH AALJBKNKHCP, Vector3 EMECBHNHILC, Vector3? MGJCBIIIBNK, Vector3 FCLBCGKIEBI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface PBENLBKBIME
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDAMAGCCGPI(EntityQuery LNMFFMOCINL, EntityManager BIBOOAGIPAC, DJHIFFLMBDL FHICECHOKKP, ANHJDHKJMJA ABMFALIBMIK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface JDLFLAFAJDO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType AIBEFMOFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECCDMHAGFKJ(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFNEPKHGPKL(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELCNHINDBBE(CHEKCMOLHDO EGPMGCMAIOH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class CFAKCENCCLN : PBENLBKBIME
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82AFBC0", Offset = "0x82AE9C0", VA = "0x1882AFBC0", Slot = "4")]
	public void DDAMAGCCGPI(EntityQuery LNMFFMOCINL, EntityManager BIBOOAGIPAC, DJHIFFLMBDL FHICECHOKKP, ANHJDHKJMJA ABMFALIBMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CFAKCENCCLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class JOKDEONBKLB : PBENLBKBIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HMDPDMKPOCJ OPMILLGOOOM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
	public JOKDEONBKLB(HMDPDMKPOCJ OPMILLGOOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82BBBB0", Offset = "0x82BA9B0", VA = "0x1882BBBB0", Slot = "4")]
	public void DDAMAGCCGPI(EntityQuery LNMFFMOCINL, EntityManager BIBOOAGIPAC, DJHIFFLMBDL FHICECHOKKP, ANHJDHKJMJA ABMFALIBMIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class BGPLFDPIJKN : PBENLBKBIME
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82AF9A0", Offset = "0x82AE7A0", VA = "0x1882AF9A0", Slot = "4")]
	public void DDAMAGCCGPI(EntityQuery LNMFFMOCINL, EntityManager BIBOOAGIPAC, DJHIFFLMBDL FHICECHOKKP, ANHJDHKJMJA ABMFALIBMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public BGPLFDPIJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ONLMLJJFAOJ : JDLFLAFAJDO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType AIBEFMOFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82CA760", Offset = "0x82C9560", VA = "0x1882CA760", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82CA490", Offset = "0x82C9290", VA = "0x1882CA490", Slot = "5")]
	public void ECCDMHAGFKJ(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82CA210", Offset = "0x82C9010", VA = "0x1882CA210", Slot = "6")]
	public void CFNEPKHGPKL(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82CA710", Offset = "0x82C9510", VA = "0x1882CA710", Slot = "7")]
	public void ELCNHINDBBE(CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ONLMLJJFAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GDFACDOPDCH : JDLFLAFAJDO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType AIBEFMOFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82B6010", Offset = "0x82B4E10", VA = "0x1882B6010", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82B5D40", Offset = "0x82B4B40", VA = "0x1882B5D40", Slot = "5")]
	public void ECCDMHAGFKJ(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x82B5AC0", Offset = "0x82B48C0", VA = "0x1882B5AC0", Slot = "6")]
	public void CFNEPKHGPKL(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82B5FC0", Offset = "0x82B4DC0", VA = "0x1882B5FC0", Slot = "7")]
	public void ELCNHINDBBE(CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GDFACDOPDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MAEPJMHDABI : JDLFLAFAJDO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType AIBEFMOFAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82C03B0", Offset = "0x82BF1B0", VA = "0x1882C03B0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82C00E0", Offset = "0x82BEEE0", VA = "0x1882C00E0", Slot = "5")]
	public void ECCDMHAGFKJ(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x82BFE60", Offset = "0x82BEC60", VA = "0x1882BFE60", Slot = "6")]
	public void CFNEPKHGPKL(EntityQuery LNMFFMOCINL, CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x82C0360", Offset = "0x82BF160", VA = "0x1882C0360", Slot = "7")]
	public void ELCNHINDBBE(CHEKCMOLHDO EGPMGCMAIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public MAEPJMHDABI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class OKOOKFKELNI : MMBILNDFKLF, BIBHAKFMBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DJHIFFLMBDL FHICECHOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DBCPHJOAPCI NIOKJEGDGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ANHJDHKJMJA ABMFALIBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, PBENLBKBIME adapter)> BFKGDLEGFEL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82C9C00", Offset = "0x82C8A00", VA = "0x1882C9C00", Slot = "15")]
	public virtual void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82C9DF0", Offset = "0x82C8BF0", VA = "0x1882C9DF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82C9C90", Offset = "0x82C8A90", VA = "0x1882C9C90")]
	private void NBCLFLHOIMK(EntityQueryDesc EFOJPDNHNAD, PBENLBKBIME IEAPENCPBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x82CA020", Offset = "0x82C8E20", VA = "0x1882CA020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
	public OKOOKFKELNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class EGBCKCCJIBJ : MMBILNDFKLF, BIBHAKFMBDN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class FNJAHNPMALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery NLNJPHMEKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery IBBMELFNMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery KCJPBNLKIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery KCOPDKHOBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery IFEAEPIDMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery EBGEFCAOIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery JNMEKMHDEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JDLFLAFAJDO AGJDMGFLCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType OIOOJHPNDJK;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FNJAHNPMALE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DJHIFFLMBDL FHICECHOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ANHJDHKJMJA ABMFALIBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DBCPHJOAPCI NIOKJEGDGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<FNJAHNPMALE> BFKGDLEGFEL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82B0F20", Offset = "0x82AFD20", VA = "0x1882B0F20", Slot = "14")]
	public void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x82B16E0", Offset = "0x82B04E0", VA = "0x1882B16E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x82B1860", Offset = "0x82B0660", VA = "0x1882B1860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82B0AD0", Offset = "0x82AF8D0", VA = "0x1882B0AD0")]
	private void HJKKEHBOMBL(FNJAHNPMALE GJLIACHKFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82B0FB0", Offset = "0x82AFDB0", VA = "0x1882B0FB0")]
	private void NBCLFLHOIMK(JDLFLAFAJDO AGJDMGFLCCN, ComponentType LOMPCNDINDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
	public EGBCKCCJIBJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct IDLBNEKJCNE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct LBKHGHLNGOO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct MALKFGBEEGC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(ANHJDHKJMJA), new string[] { })]
public class LIMMBCIOLCB : ANHJDHKJMJA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CKJLKPAHMFI ADPGPPGOMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CKJLKPAHMFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LIMMBCIOLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(PNHNGEJMCJN), new string[] { })]
public class JDFPIKLAKDB : PNHNGEJMCJN, AKJPHGCMHJK, KFAMAKMBLEN, HGADKLGPBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private MODFEFDOPCN HOJGMNLGPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private DJHIFFLMBDL FHICECHOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private BPAIJKJGNLD NMBGECILFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity LGLHNDIHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private IFKLBEEHLLN DPHNLIPOHOH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82BBAD0", Offset = "0x82BA8D0", VA = "0x1882BBAD0", Slot = "4")]
	public bool LGCAJBDKLOH(JDKDDPDJCCM OPKFGAAECNB, FGKHGPMAONK BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x82BB700", Offset = "0x82BA500", VA = "0x1882BB700", Slot = "5")]
	public IFKLBEEHLLN BNNNPFJEGME()
	{
		return default(IFKLBEEHLLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82BB9C0", Offset = "0x82BA7C0", VA = "0x1882BB9C0", Slot = "6")]
	public void CHLEBEMPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82BB670", Offset = "0x82BA470", VA = "0x1882BB670", Slot = "7")]
	private void BIPCOHCEAAL(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x12A6B50", Offset = "0x12A5950", VA = "0x1812A6B50", Slot = "8")]
	private void AABAMDPDGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JDFPIKLAKDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(OLFKPPOLMHK), new string[] { })]
public class KODCAFPDADK : OLFKPPOLMHK
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82BEF20", Offset = "0x82BDD20", VA = "0x1882BEF20", Slot = "4")]
	public void POACBPACPKK(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82BE4C0", Offset = "0x82BD2C0", VA = "0x1882BE4C0", Slot = "5")]
	public void APDABNLOBJK(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82BE570", Offset = "0x82BD370", VA = "0x1882BE570", Slot = "6")]
	public ComponentSystemBase CCLCBHMHHFH(World HOJGMNLGPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82BEDF0", Offset = "0x82BDBF0", VA = "0x1882BEDF0", Slot = "7")]
	public void HEKBLMLLPLC(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82BE510", Offset = "0x82BD310", VA = "0x1882BE510", Slot = "8")]
	public void BNDPKDNAAFD(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82BEE50", Offset = "0x82BDC50", VA = "0x1882BEE50", Slot = "9")]
	public void KDCHCBJJHHH(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82BEEB0", Offset = "0x82BDCB0", VA = "0x1882BEEB0", Slot = "10")]
	public void MAGHHDHMFEK(World HOJGMNLGPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82BE5C0", Offset = "0x82BD3C0", VA = "0x1882BE5C0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FNMPABBDBBI()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KODCAFPDADK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct EOBJDINPMDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct CMCKIABJJLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MKDIFPELGEG : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KCFGAJKDIOC HPEMIAFCAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82C1110", Offset = "0x82BFF10", VA = "0x1882C1110", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82C10A0", Offset = "0x82BFEA0", VA = "0x1882C10A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public MKDIFPELGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct NCDIMOCJEIA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IFKLBEEHLLN LNKDFHODHMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static NCDIMOCJEIA JGGBAIGHKJA(IFKLBEEHLLN DADONNGONOC)
	{
		return default(NCDIMOCJEIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DHOPENLMGMP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LCOLNOMHDFM KCEBGEIIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82B06F0", Offset = "0x82AF4F0", VA = "0x1882B06F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public DHOPENLMGMP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct IOJJNEBIIFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct IIGBJHDCGIM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DDJIEOGAMGL OBNNKCNBNFF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static IIGBJHDCGIM JGGBAIGHKJA(DDJIEOGAMGL DADONNGONOC)
	{
		return default(IIGBJHDCGIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct JEFHAEDEGCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IFKLBEEHLLN LNKDFHODHMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JEFHAEDEGCK JGGBAIGHKJA(IFKLBEEHLLN DADONNGONOC)
	{
		return default(JEFHAEDEGCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OOPLMJNGMIA : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HDAFBNCPEAH FEPGPJJIEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82CA800", Offset = "0x82C9600", VA = "0x1882CA800", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82CA790", Offset = "0x82C9590", VA = "0x1882CA790", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OOPLMJNGMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FCPKGPOAJJB : KHFBGPEAAIG, KCFGAJKDIOC, IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LBBOFCAGNFJ OENJGGOHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE3B640", Offset = "0xE3A440", VA = "0x180E3B640", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(LBBOFCAGNFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IGMKNKJDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD16540", Offset = "0xD15340", VA = "0x180D16540", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 LCBCICMILDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x11F3530", Offset = "0x11F2330", VA = "0x1811F3530", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82B1F90", Offset = "0x82B0D90", VA = "0x1882B1F90")]
	public FCPKGPOAJJB(UniformTRS LOADEEDFKKE, AIJLMLNJMHO CMDMCJGFCDK, float HHOICDFCKKO, float3 ANHKCEBFHHE, AOKFBPFAEAA PPFLAKEGMOB, PLHKBDHNDHI IDLOHJEKDMO, LBBOFCAGNFJ FBIBFNHIELC, float3 PPBGLAGDIMC, bool JHCIIHDIJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82B1F40", Offset = "0x82B0D40", VA = "0x1882B1F40", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class APLFBKMKKBK : KHFBGPEAAIG, HDAFBNCPEAH, IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<FLPAONONIEF> MAEJEOPJPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ABGIEGMENKA OAEBFAAHGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float BHGKOCCDEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int GKGECBOFKDF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GDBCHBAMBED
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82AF520", Offset = "0x82AE320", VA = "0x1882AF520", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FGPEGJHCFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82AF540", Offset = "0x82AE340", VA = "0x1882AF540", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OAFBPIDLCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82AF530", Offset = "0x82AE330", VA = "0x1882AF530", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FGKFCKBPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5350", Offset = "0xAB4150", VA = "0x180AB5350", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float DPNNBLMCMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xDA13F0", Offset = "0xDA01F0", VA = "0x180DA13F0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KJMOFKDALPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10268A0", Offset = "0x10256A0", VA = "0x1810268A0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82AF470", Offset = "0x82AE270", VA = "0x1882AF470")]
	public APLFBKMKKBK(UniformTRS LOADEEDFKKE, AIJLMLNJMHO CMDMCJGFCDK, float HHOICDFCKKO, float3 ANHKCEBFHHE, AOKFBPFAEAA PPFLAKEGMOB, PLHKBDHNDHI IDLOHJEKDMO, ABGIEGMENKA OAEBFAAHGEJ, float BHGKOCCDEKB, int GKGECBOFKDF, NativeArray<FLPAONONIEF> MAEJEOPJPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x120C0C0", Offset = "0x120AEC0", VA = "0x18120C0C0", Slot = "33")]
	public NativeArray<FLPAONONIEF> GetNativeCurvePoints()
	{
		return default(NativeArray<FLPAONONIEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82AF3B0", Offset = "0x82AE1B0", VA = "0x1882AF3B0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KEAONONLEBC : MBEJDAODNLJ, KCFGAJKDIOC, IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<FHBADAKFFGA, LBBOFCAGNFJ> DPHOLGOBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LBBOFCAGNFJ FBIBFNHIELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool JHCIIHDIJND;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private LBBOFCAGNFJ MIILODNMIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750", Slot = "28")]
		get
		{
			return default(LBBOFCAGNFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool GHMGEMBJKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xF56A60", Offset = "0xF55860", VA = "0x180F56A60", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 LCBCICMILDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82BC5F0", Offset = "0x82BB3F0", VA = "0x1882BC5F0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x82BC5D0", Offset = "0x82BB3D0", VA = "0x1882BC5D0")]
	public KEAONONLEBC(JDKDDPDJCCM AMECNEFIPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82BBF40", Offset = "0x82BAD40", VA = "0x1882BBF40", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x82BBF90", Offset = "0x82BAD90", VA = "0x1882BBF90", Slot = "26")]
	public override void FLCGEBIGNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LCGDOFDCLGK : MCLKJPDDKPF, LCOLNOMHDFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject HAFKEIACKNP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject GJPFCDPKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82BF260", Offset = "0x82BE060", VA = "0x1882BF260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GKKGCGDMMHN HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82BF130", Offset = "0x82BDF30", VA = "0x1882BF130", Slot = "15")]
		get
		{
			return default(GKKGCGDMMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MDHGKJAOALO OKFOCLEADEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82BF590", Offset = "0x82BE390", VA = "0x1882BF590", Slot = "16")]
		get
		{
			return default(MDHGKJAOALO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82BF440", Offset = "0x82BE240", VA = "0x1882BF440")]
	public LCGDOFDCLGK(JDKDDPDJCCM OPKFGAAECNB, bool BCPMDPONCKK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82BEFA0", Offset = "0x82BDDA0", VA = "0x1882BEFA0")]
	public void BIGAMJOODOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82BF130", Offset = "0x82BDF30", VA = "0x1882BF130")]
	protected GKKGCGDMMHN CLLOEOHCKEH()
	{
		return default(GKKGCGDMMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82BF2F0", Offset = "0x82BE0F0", VA = "0x1882BF2F0")]
	private static bool KPLBOGALFNP(JDKDDPDJCCM AOHLKKCMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82BF230", Offset = "0x82BE030", VA = "0x1882BF230", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OHPOMIPDPAC : MBEJDAODNLJ, HDAFBNCPEAH, IOKBKKINBCG, IDisposable, DEAKCBKIHCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<FLPAONONIEF> MAEJEOPJPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool OHPGFMABNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BLMDCPAPHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float BHGKOCCDEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int GKGECBOFKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool AIPCOOFLNJF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool HJFNPMFINED
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD238D0", Offset = "0xD226D0", VA = "0x180D238D0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool NFMOPJAAMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5120", Offset = "0xAA3F20", VA = "0x180AA5120", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float LHHINLFODOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE93C60", Offset = "0xE92A60", VA = "0x180E93C60", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int LEKBPKIHJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE3B640", Offset = "0xE3A440", VA = "0x180E3B640", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool EPHKMNMAAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD16540", Offset = "0xD15340", VA = "0x180D16540", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int CICFCFHNBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82C7500", Offset = "0x82C6300", VA = "0x1882C7500", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int PGBGHDGHDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82C7520", Offset = "0x82C6320", VA = "0x1882C7520", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82C7E00", Offset = "0x82C6C00", VA = "0x1882C7E00")]
	public OHPOMIPDPAC(JDKDDPDJCCM AMECNEFIPBJ, [Optional] NativeList<FLPAONONIEF> MAEJEOPJPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82C7920", Offset = "0x82C6720", VA = "0x1882C7920", Slot = "26")]
	public override void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82C7680", Offset = "0x82C6480", VA = "0x1882C7680", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82C7770", Offset = "0x82C6570", VA = "0x1882C7770", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82C7DA0", Offset = "0x82C6BA0", VA = "0x1882C7DA0")]
	public void NDIEANLIDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82C7A00", Offset = "0x82C6800", VA = "0x1882C7A00", Slot = "34")]
	public NativeArray<FLPAONONIEF> GetNativeCurvePoints()
	{
		return default(NativeArray<FLPAONONIEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x82C77D0", Offset = "0x82C65D0", VA = "0x1882C77D0", Slot = "35")]
	private Vector3 ENILCJGACHN(int BLFNDPNNLJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82C7BD0", Offset = "0x82C69D0", VA = "0x1882C7BD0", Slot = "36")]
	private Quaternion JHHEOHIMDMM(int BLFNDPNNLJD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82C7C00", Offset = "0x82C6A00", VA = "0x1882C7C00", Slot = "37")]
	private float LBPFABMCNCE(int BLFNDPNNLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82C7610", Offset = "0x82C6410", VA = "0x1882C7610")]
	private NativeArray<Entity> CFOKLNAFDMP()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class EJMFLNOENNL : ACPEBAGPDBP
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x82B1B10", Offset = "0x82B0910", VA = "0x1882B1B10", Slot = "15")]
	protected override ComponentSystemBase PAGGHHCAFKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82B1B00", Offset = "0x82B0900", VA = "0x1882B1B00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x82B1F30", Offset = "0x82B0D30", VA = "0x1882B1F30")]
	public EJMFLNOENNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LNMIKKKJNOG]
public sealed class FGNAPLGGHPC : GELOJECJLHP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery CKBPOBBHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery BNDEFEBFJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery LOBFPNFCJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery MPGMCELDIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery JOENDOJJEFC;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x82B27F0", Offset = "0x82B15F0", VA = "0x1882B27F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x82B2B50", Offset = "0x82B1950", VA = "0x1882B2B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82B2030", Offset = "0x82B0E30", VA = "0x1882B2030")]
	private void BEIBEOLDIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82B2210", Offset = "0x82B1010", VA = "0x1882B2210")]
	private void ELALHKPAGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x82B2420", Offset = "0x82B1220", VA = "0x1882B2420")]
	private void GIELOBPHBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82B25F0", Offset = "0x82B13F0", VA = "0x1882B25F0")]
	private void IOKDEHDNANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x82B2320", Offset = "0x82B1120", VA = "0x1882B2320")]
	private void FHCNMAKPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x82B2740", Offset = "0x82B1540", VA = "0x1882B2740")]
	private NativeList<Entity> LEDIKKLNGOD(NativeArray<Entity> DIDGDGLCMEE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x82B26F0", Offset = "0x82B14F0", VA = "0x1882B26F0")]
	private NativeList<Entity> KLFELFEGBIH(NativeArray<Entity> DIDGDGLCMEE)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x82B2790", Offset = "0x82B1590", VA = "0x1882B2790")]
	private void MDJLONLILEN(NativeArray<Entity> DIDGDGLCMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public FGNAPLGGHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[LNMIKKKJNOG]
public sealed class KNMAHPBFDGB : GELOJECJLHP, BIBHAKFMBDN
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery JIFOECBCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery GPKLIPPJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery KCJPBNLKIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PNHNGEJMCJN BHABGFHJBNA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82BE240", Offset = "0x82BD040", VA = "0x1882BE240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x82BD310", Offset = "0x82BC110", VA = "0x1882BD310", Slot = "15")]
	public override void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82BE410", Offset = "0x82BD210", VA = "0x1882BE410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82BCB90", Offset = "0x82BB990", VA = "0x1882BCB90")]
	private void CFFHMGGEPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82BDBB0", Offset = "0x82BC9B0", VA = "0x1882BDBB0")]
	private void OHHHBIKCJLF(NativeParallelHashSet<IFKLBEEHLLN> FINNCLAMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82BD370", Offset = "0x82BC170", VA = "0x1882BD370")]
	private void KMBJIONFJPD(NativeParallelHashSet<IFKLBEEHLLN> FINNCLAMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82BCEB0", Offset = "0x82BBCB0", VA = "0x1882BCEB0")]
	private void FAPJKFIPDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x82BD270", Offset = "0x82BC070", VA = "0x1882BD270")]
	private bool IBLJCHHLFOP(Entity ALBBAEBLONH, [Out] IFKLBEEHLLN LNKDFHODHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82BDA00", Offset = "0x82BC800", VA = "0x1882BDA00")]
	private bool LCACBCLMLEI(Entity ALBBAEBLONH, [Out] IFKLBEEHLLN LNKDFHODHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public KNMAHPBFDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LNMIKKKJNOG]
public sealed class NPGEPAGFMNK : GELOJECJLHP
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery NJHNOABOPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery IMINBFEPHAP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x82C6370", Offset = "0x82C5170", VA = "0x1882C6370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x82C64C0", Offset = "0x82C52C0", VA = "0x1882C64C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x82C6070", Offset = "0x82C4E70", VA = "0x1882C6070")]
	private void OHHHBIKCJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x82C5D80", Offset = "0x82C4B80", VA = "0x1882C5D80")]
	private void KMBJIONFJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public NPGEPAGFMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FPDOIBPBDOP : GELOJECJLHP, BIBHAKFMBDN
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct JOOLMDPLLDA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob LMLFOMJLKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob EFCMEPEKFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob JIMPHJALFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob KMCHPHOKEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle PBEGOBKDIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<JEFHAEDEGCK> LKJHNENAFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> FJLFAPNBJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> MKIPEKDEJMP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82BBD00", Offset = "0x82BAB00", VA = "0x1882BBD00", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x82BBD80", Offset = "0x82BAB80", VA = "0x1882BBD80")]
		private void HLDFAAFLAMF(EntityQueryInJob LNMFFMOCINL, NativeList<Entity> BDIFNFAEBDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct KHPKKAEFHPL : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle PBEGOBKDIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<JEFHAEDEGCK> LKJHNENAFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> BDIFNFAEBDB;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82BC8C0", Offset = "0x82BB6C0", VA = "0x1882BC8C0", Slot = "4")]
		public void Execute(ArchetypeChunk PMKNNIHBEPG, int HIKKFOLCILK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct HJMEPCLNFHK : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle PBEGOBKDIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> BJGBBCCOAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<IIGBJHDCGIM> NICONIAHAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<NCDIMOCJEIA> PMDHIDEPGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<JEFHAEDEGCK> CDAFIINLOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> MINMCGGCGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<IIGBJHDCGIM> HCCCINIFGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<IFKLBEEHLLN> BAIGBEHBJJM;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82BB2D0", Offset = "0x82BA0D0", VA = "0x1882BB2D0", Slot = "4")]
		public void Execute(ArchetypeChunk PMKNNIHBEPG, int HIKKFOLCILK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery LMLFOMJLKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery EFCMEPEKFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery JIMPHJALFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery KMCHPHOKEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery JELDLCDLFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery CBAKMHJMCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery PIBOBNJEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private PNHNGEJMCJN NAPFEDAHKCI;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x82B4BB0", Offset = "0x82B39B0", VA = "0x1882B4BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82B42C0", Offset = "0x82B30C0", VA = "0x1882B42C0", Slot = "15")]
	public override void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x82B5130", Offset = "0x82B3F30", VA = "0x1882B5130", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82B54C0", Offset = "0x82B42C0", VA = "0x1882B54C0")]
	private void PEKAMGOLGJD(NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP, int MNDJMFMHOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82B4760", Offset = "0x82B3560", VA = "0x1882B4760")]
	private void MKAEAHNEBIK(NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP, int KDLPGFFCBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82B4320", Offset = "0x82B3120", VA = "0x1882B4320")]
	private void LBAHFFFOEJG(NativeParallelHashSet<IFKLBEEHLLN> HMKEGPELAGP, int LCCINCNPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82B3F30", Offset = "0x82B2D30", VA = "0x1882B3F30")]
	private void GIMHEJPOOLM(NativeParallelHashSet<IFKLBEEHLLN> FINNCLAMFHK, int PMHIPKGAJAK, int DIDNFDFNLHI, int AKODABDLBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82B3D80", Offset = "0x82B2B80", VA = "0x1882B3D80")]
	private void BNBFDGKDHLO(Entity AIFJOGJJAIC, DDJIEOGAMGL PGHOADEKDDJ, IFKLBEEHLLN LNKDFHODHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public FPDOIBPBDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DEGEDDJNABI : GELOJECJLHP
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery EBEMFBJCGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery OMKJGNCNEHG;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AED10", VA = "0x1882AFF10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82B0150", Offset = "0x82AEF50", VA = "0x1882B0150", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public DEGEDDJNABI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DPIFPAHFOOL : GELOJECJLHP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct AEPLNCMBHGF : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery FLEAKEKINMB;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82B0760", Offset = "0x82AF560", VA = "0x1882B0760", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82B08A0", Offset = "0x82AF6A0", VA = "0x1882B08A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public DPIFPAHFOOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LNMIKKKJNOG]
internal class OFPCGKGMJGP : GELOJECJLHP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class IDJGHCPPIEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery JFLDPADGFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery BAMLKPEMJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FMHMFAPFHJE BBLBPPFHMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType OHENCHHDGIO;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IDJGHCPPIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void FMHMFAPFHJE(NativeArray<DDJIEOGAMGL> DADONNGONOC, CHEKCMOLHDO EGPMGCMAIOH);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<IDJGHCPPIEA> BFKGDLEGFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private DBCPHJOAPCI NIOKJEGDGJP;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82C6D80", Offset = "0x82C5B80", VA = "0x1882C6D80", Slot = "15")]
	public override void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82C6DE0", Offset = "0x82C5BE0", VA = "0x1882C6DE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82C6F70", Offset = "0x82C5D70", VA = "0x1882C6F70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D36F90", Offset = "0x3D35D90", VA = "0x183D36F90")]
	private void NBCLFLHOIMK<T>(FMHMFAPFHJE BBLBPPFHMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x82C6A40", Offset = "0x82C5840", VA = "0x1882C6A40")]
	private static void ICBALHFAKKA(NativeArray<DDJIEOGAMGL> FLKIPICBFGF, CHEKCMOLHDO IPLPOBIMMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82C6BE0", Offset = "0x82C59E0", VA = "0x1882C6BE0")]
	private static void IOPIAMAFIMO(NativeArray<DDJIEOGAMGL> FLKIPICBFGF, CHEKCMOLHDO IPLPOBIMMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82C68A0", Offset = "0x82C56A0", VA = "0x1882C68A0")]
	private static void IBBFOLFOKJL(NativeArray<DDJIEOGAMGL> FLKIPICBFGF, CHEKCMOLHDO IPLPOBIMMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public OFPCGKGMJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LNMIKKKJNOG]
public sealed class BCFFLMNMOLN : GELOJECJLHP
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery LNMFFMOCINL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x82AF550", Offset = "0x82AE350", VA = "0x1882AF550", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BHNMJKFJFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS LOADEEDFKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData IKFDHHJDMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LBBOFCAGNFJ FBIBFNHIELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PPBGLAGDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool JHCIIHDIJND;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[FNKMGFLJGGM(Lifetime.LoadInstance)]
public struct KLFILCBOPDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity DHLFBBHICBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> BJABKGICJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> CILDNCBHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<BHNMJKFJFGI> FJPLNCANBKI;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82BCB00", Offset = "0x82BB900", VA = "0x1882BCB00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(FGNGMENBLHA), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class FGNGMENBLHA : BIBHAKFMBDN, GNJFBAIKFDH, KFAMAKMBLEN, HGADKLGPBDL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct HHEPOMMEDFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly FGNGMENBLHA CMDMCJGFCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool BFPGHOGICDD;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x19D5B50", Offset = "0x19D4950", VA = "0x1819D5B50")]
		public HHEPOMMEDFA(FGNGMENBLHA CMDMCJGFCDK, bool BFPGHOGICDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x82BB1A0", Offset = "0x82B9FA0", VA = "0x1882BB1A0")]
		public Queue<BHPGPPHEJDH>.Enumerator OMGGHMFPBJO()
		{
			return default(Queue<BHPGPPHEJDH>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x82BAE60", Offset = "0x82B9C60", VA = "0x1882BAE60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private BPAIJKJGNLD EJOEOKEBELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private DCIIFADGPIA BOIFOABFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<FLPAONONIEF>> CEPBLANBFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> HIEKBDELDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<DDJIEOGAMGL> JJNNJDJIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private GNBPOPIPAOL<BHPGPPHEJDH> NKNOJNGBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private GNBPOPIPAOL<KLFILCBOPDC> AHEMAAOFLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private GNBPOPIPAOL<PKFBBCNOKOF> KHFHBMOAKIC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82B3650", Offset = "0x82B2450", VA = "0x1882B3650", Slot = "4")]
	public void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x82B2C90", Offset = "0x82B1A90", VA = "0x1882B2C90")]
	public void DCJCFMHABEP(NativeList<FLPAONONIEF> FCEIEJMPBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82B2FC0", Offset = "0x82B1DC0", VA = "0x1882B2FC0")]
	public void HPPJIJDOPGH(Entity CMDMCJGFCDK, [In] GDLAFIILODC<GameObject> CHPPBIFFKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x82B3110", Offset = "0x82B1F10", VA = "0x1882B3110")]
	public void IBKHGELJHFE(NativeList<DDJIEOGAMGL> FLKIPICBFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x82B3850", Offset = "0x82B2650", VA = "0x1882B3850")]
	public void KDCHCBJJHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x82B31A0", Offset = "0x82B1FA0", VA = "0x1882B31A0")]
	public void IIFBPMMHGON(JLDCHECNAIA HEJIJKOGOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x82B2F20", Offset = "0x82B1D20", VA = "0x1882B2F20")]
	public JobHandle GLKDHKBMCEI([In] BHPGPPHEJDH IIHOFBLPONF, JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x82B2E80", Offset = "0x82B1C80", VA = "0x1882B2E80")]
	public JobHandle GLKDHKBMCEI([In] KLFILCBOPDC IIHOFBLPONF, JobHandle PMKMPILBKMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F46550", Offset = "0x7F45350", VA = "0x187F46550")]
	public HHEPOMMEDFA AADCDBNDEGB(bool BFPGHOGICDD)
	{
		return default(HHEPOMMEDFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x82B3A80", Offset = "0x82B2880", VA = "0x1882B3A80")]
	public JHDEAMPCLAM<KLFILCBOPDC> LPCFLBGLIAF()
	{
		return default(JHDEAMPCLAM<KLFILCBOPDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x82B2E30", Offset = "0x82B1C30", VA = "0x1882B2E30")]
	public JHDEAMPCLAM<PKFBBCNOKOF> EOAHCACJFHN()
	{
		return default(JHDEAMPCLAM<PKFBBCNOKOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x82B3AD0", Offset = "0x82B28D0", VA = "0x1882B3AD0")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x82B2D50", Offset = "0x82B1B50", VA = "0x1882B2D50", Slot = "5")]
	public void ECMDLAACMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82B2C20", Offset = "0x82B1A20", VA = "0x1882B2C20", Slot = "6")]
	private void BIPCOHCEAAL(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x12AF640", Offset = "0x12AE440", VA = "0x1812AF640", Slot = "7")]
	private void AABAMDPDGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FGNGMENBLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct EFFHBHGPCEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS LOADEEDFKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData IKFDHHJDMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public GGKKLOFKKIO OAEBFAAHGEJ;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[FNKMGFLJGGM(Lifetime.LoadInstance)]
public struct BHPGPPHEJDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity DHLFBBHICBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> DIDGDGLCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> BJABKGICJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> CILDNCBHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<PIHJPNGEKCI> BBOFPOIGJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<FLPAONONIEF> FCEIEJMPBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<EFFHBHGPCEP> ALNMHAABDCF;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x82AFAE0", Offset = "0x82AE8E0", VA = "0x1882AFAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x82AFAF0", Offset = "0x82AE8F0", VA = "0x1882AFAF0")]
	public void LEFDKMKGENP(bool BFPGHOGICDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(JBLNNMIOLGJ), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class JBLNNMIOLGJ : IPCNMPIDJOB, KFAMAKMBLEN, HGADKLGPBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private FGNGMENBLHA DHOILHOONIG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x82BB650", Offset = "0x82BA450", VA = "0x1882BB650", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x82BB600", Offset = "0x82BA400", VA = "0x1882BB600", Slot = "5")]
	private void BIPCOHCEAAL(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x128F760", Offset = "0x128E560", VA = "0x18128F760", Slot = "6")]
	private void AABAMDPDGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JBLNNMIOLGJ()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : GELOJECJLHP, BIBHAKFMBDN
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
			public NativeParallelHashMap<int, LBBOFCAGNFJ> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<BHNMJKFJFGI> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x82B6440", Offset = "0x82B5240", VA = "0x1882B6440", Slot = "4")]
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
			public NativeArray<FLPAONONIEF> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<PIHJPNGEKCI> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<EFFHBHGPCEP> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x82B67E0", Offset = "0x82B55E0", VA = "0x1882B67E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x82AFDD0", Offset = "0x82AEBD0", VA = "0x1882AFDD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x82CA850", Offset = "0x82C9650", VA = "0x1882CA850")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x82CA870", Offset = "0x82C9670", VA = "0x1882CA870")]
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
				float3 KNKCLMOCBIA(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x82BF6F0", Offset = "0x82BE4F0", VA = "0x1882BF6F0", Slot = "5")]
				public float3 EBFMJAGGPBK(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x82BFAA0", Offset = "0x82BE8A0", VA = "0x1882BFAA0", Slot = "4")]
				public float3 KNKCLMOCBIA(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x82C6570", Offset = "0x82C5370", VA = "0x1882C6570", Slot = "4")]
				public float3 KNKCLMOCBIA(quaternion rotation)
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
			public NativeArray<PIHJPNGEKCI> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<FLPAONONIEF> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x82B7370", Offset = "0x82B6170", VA = "0x1882B7370", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82B98B0", Offset = "0x82B86B0", VA = "0x1882B98B0")]
			private void NOCCPGLFFBP(NativeList<PointSrcData> srcData, NativeList<FLPAONONIEF> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x82B8C30", Offset = "0x82B7A30", VA = "0x1882B8C30")]
			public static Vector3 HJEBCHNEHIJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F00", Offset = "0x82B5D00", VA = "0x1882B6F00")]
			public static quaternion AEFHGMHHKHK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x82B9680", Offset = "0x82B8480", VA = "0x1882B9680")]
			private static quaternion KNMKJHHGDBK(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x82BA980", Offset = "0x82B9780", VA = "0x1882BA980")]
			private static float3 ONCJFNLMOKK(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x82B6F80", Offset = "0x82B5D80", VA = "0x1882B6F80")]
			private static quaternion BMEIEEKJEOI(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x82B8920", Offset = "0x82B7720", VA = "0x1882B8920")]
			private static FLPAONONIEF FMGIBDNPEKE(int idx, NativeList<PointSrcData> srcData)
			{
				return default(FLPAONONIEF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x42C81C0", Offset = "0x42C6FC0", VA = "0x1842C81C0")]
			private void NPBPIMAAFBF<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x82B7990", Offset = "0x82B6790", VA = "0x1882B7990")]
			private void FAGPKCMKPFI(NativeList<PointSrcData> sourcePoints, NativeList<FLPAONONIEF> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x82B87A0", Offset = "0x82B75A0", VA = "0x1882B87A0")]
			public static float FDEPBPCMLHA(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x82BA790", Offset = "0x82B9590", VA = "0x1882BA790")]
			private static quaternion NPCLNFLKPEM(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x82B7250", Offset = "0x82B6050", VA = "0x1882B7250")]
			private static FLPAONONIEF EMILLAMHLLE(PointSrcData point)
			{
				return default(FLPAONONIEF);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x82B71C0", Offset = "0x82B5FC0", VA = "0x1882B71C0")]
			private static FLPAONONIEF EMILLAMHLLE(float3 pos, quaternion rot, float radius)
			{
				return default(FLPAONONIEF);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x82B8B90", Offset = "0x82B7990", VA = "0x1882B8B90")]
			private static bool GKOBGMENIPP(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x82BAB50", Offset = "0x82B9950", VA = "0x1882BAB50")]
			private static float3 PHEMONFOIIP(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x82BAC20", Offset = "0x82B9A20", VA = "0x1882BAC20")]
			public static float3 PPFBFNNIDDC(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x82B7010", Offset = "0x82B5E10", VA = "0x1882B7010")]
			public static float3 EBFMJAGGPBK(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x82B9220", Offset = "0x82B8020", VA = "0x1882B9220")]
			private static quaternion KECJDJAPOGC(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x82B9040", Offset = "0x82B7E40", VA = "0x1882B9040")]
			private static float JGKHPJHOBOL(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x82CCF90", Offset = "0x82CBD90", VA = "0x1882CCF90")]
			private void ELEAHIOBOHM(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x82CD070", Offset = "0x82CBE70", VA = "0x1882CD070", Slot = "4")]
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
			public NativeList<FLPAONONIEF> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x82CE290", Offset = "0x82CD090", VA = "0x1882CE290")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x82CE2F0", Offset = "0x82CD0F0", VA = "0x1882CE2F0", Slot = "4")]
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
			public NativeList<FLPAONONIEF> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x82CE230", Offset = "0x82CD030", VA = "0x1882CE230")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x82CE280", Offset = "0x82CD080", VA = "0x1882CE280", Slot = "4")]
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
			public NativeList<BHNMJKFJFGI> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x82B6B20", Offset = "0x82B5920", VA = "0x1882B6B20")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x82B6CE0", Offset = "0x82B5AE0", VA = "0x1882B6CE0", Slot = "4")]
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
			public NativeList<PIHJPNGEKCI> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<EFFHBHGPCEP> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x82B6CF0", Offset = "0x82B5AF0", VA = "0x1882B6CF0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x82B6EF0", Offset = "0x82B5CF0", VA = "0x1882B6EF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x82CDE00", Offset = "0x82CCC00", VA = "0x1882CDE00")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x82CE220", Offset = "0x82CD020", VA = "0x1882CE220", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly PHLHEDGDBJO log;

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
		private JNAHFDACBPG replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BPAIJKJGNLD objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FGNGMENBLHA bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DHCKHFELHMJ ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x82CC540", Offset = "0x82CB340", VA = "0x1882CC540", Slot = "15")]
		public override void InitReferences(GFFDGLCCIJL services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x82CD810", Offset = "0x82CC610", VA = "0x1882CD810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82CD900", Offset = "0x82CC700", VA = "0x1882CD900", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x82CD960", Offset = "0x82CC760", VA = "0x1882CD960", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82CAF90", Offset = "0x82C9D90", VA = "0x1882CAF90")]
		private JobHandle EGFDLONEAAL(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x82CB770", Offset = "0x82CA570", VA = "0x1882CB770")]
		private JobHandle IALPMPLCLIA(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x82CC5E0", Offset = "0x82CB3E0", VA = "0x1882CC5E0")]
		private JobHandle NFEMBBEEEJM(NativeArray<int> pointCount, NativeList<FLPAONONIEF> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82CD160", Offset = "0x82CBF60", VA = "0x1882CD160")]
		private JobHandle NIOAEJADCDM(NativeList<FLPAONONIEF> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x82CA8C0", Offset = "0x82C96C0", VA = "0x1882CA8C0")]
		private JobHandle CPEAEKKMFNN(EntityQuery query, NativeList<PIHJPNGEKCI> splinePointRanges, NativeList<FLPAONONIEF> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x82CB650", Offset = "0x82CA450", VA = "0x1882CB650")]
		private JobHandle GHPDEIKBOMB(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x82CBE30", Offset = "0x82CAC30", VA = "0x1882CBE30")]
		private JobHandle IBNBNLKJNKF(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x82CDAD0", Offset = "0x82CC8D0", VA = "0x1882CDAD0")]
		private JobHandle PMEDHAJLODK(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<BHNMJKFJFGI> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x82CD200", Offset = "0x82CC000", VA = "0x1882CD200")]
		private JobHandle OPNGDOFLHBO(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<PIHJPNGEKCI> splinePointRanges, [Out] NativeList<EFFHBHGPCEP> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x82CB2D0", Offset = "0x82CA0D0", VA = "0x1882CB2D0")]
		private JobHandle ELMFHHNGKAM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x82CBF50", Offset = "0x82CAD50", VA = "0x1882CBF50")]
		private JobHandle IHMOELFLNJO(EntityQuery query, NativeList<BHNMJKFJFGI> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x82CC680", Offset = "0x82CB480", VA = "0x1882CC680")]
		private static NativeParallelHashMap<int, LBBOFCAGNFJ> JJIKEFCKMID()
		{
			return default(NativeParallelHashMap<int, LBBOFCAGNFJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x82CCAA0", Offset = "0x82CB8A0", VA = "0x1882CCAA0")]
		private JobHandle KEMNLJKIKOG(EntityQuery query, NativeList<PIHJPNGEKCI> splinePointRanges, NativeList<FLPAONONIEF> splinePointData, NativeList<EFFHBHGPCEP> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x82CC460", Offset = "0x82CB260", VA = "0x1882CC460")]
		private JobHandle IJKPLDGFACF(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x82CC5E0", Offset = "0x82CB3E0", VA = "0x1882CC5E0")]
		private JobHandle JGJNEIMBBJO(NativeArray<int> pointCount, NativeList<FLPAONONIEF> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x82CD160", Offset = "0x82CBF60", VA = "0x1882CD160")]
		private JobHandle OLLAKDAEGHH(NativeList<FLPAONONIEF> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x82CAEA0", Offset = "0x82C9CA0", VA = "0x1882CAEA0")]
		private JobHandle DPBFNCLGCII(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<BHNMJKFJFGI> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x82CAD90", Offset = "0x82C9B90", VA = "0x1882CAD90")]
		private JobHandle DCEFKJMHKLJ(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<PIHJPNGEKCI> ranges, NativeList<EFFHBHGPCEP> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82CCE40", Offset = "0x82CBC40", VA = "0x1882CCE40")]
		private JobHandle LPHKONGJKDE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x82CD4C0", Offset = "0x82CC2C0", VA = "0x1882CD4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class HJCJLHLBBMN : MMBILNDFKLF, BIBHAKFMBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private FGNGMENBLHA DHOILHOONIG;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x82BB260", Offset = "0x82BA060", VA = "0x1882BB260", Slot = "14")]
	public void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x82BB2B0", Offset = "0x82BA0B0", VA = "0x1882BB2B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
	public HJCJLHLBBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class NNMCFDIOKAI : GELOJECJLHP, BIBHAKFMBDN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct DGIHAAAABMI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager BIBOOAGIPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private DNHDDPEMCHP<T> JDPAALNKJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int CKFKPOAGPKN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6DDD850", Offset = "0x6DDC650", VA = "0x186DDD850")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDDF40", Offset = "0x6DDCD40", VA = "0x186DDDF40")]
		public DGIHAAAABMI(EntityManager BIBOOAGIPAC, DNHDDPEMCHP<T> JDPAALNKJKC, NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x48E1740", Offset = "0x48E0540", VA = "0x1848E1740")]
		public DGIHAAAABMI<T> OMGGHMFPBJO()
		{
			return default(DGIHAAAABMI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD480", Offset = "0x6DDC280", VA = "0x186DDD480")]
		public bool CELMNIAJJCM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly PHLHEDGDBJO GBKJGICDKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DCIIFADGPIA BOIFOABFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private FGNGMENBLHA DHOILHOONIG;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x82C1860", Offset = "0x82C0660", VA = "0x1882C1860", Slot = "15")]
	public override void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x82C3800", Offset = "0x82C2600", VA = "0x1882C3800")]
	public void MAGHHDHMFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x82C47C0", Offset = "0x82C35C0", VA = "0x1882C47C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x82C22F0", Offset = "0x82C10F0", VA = "0x1882C22F0")]
	private void KNHJJIFMAHN(PKFBBCNOKOF IIHOFBLPONF, Mesh[] APIAOCPINLL, NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3D11850", Offset = "0x3D10650", VA = "0x183D11850")]
	private DGIHAAAABMI<T> PBFOLNNBIBA<T>(DNHDDPEMCHP<T> JDPAALNKJKC, NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK) where T : struct
	{
		return default(DGIHAAAABMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x82C5930", Offset = "0x82C4730", VA = "0x1882C5930")]
	private void PNIFKGMGGBF(Transform CMDMCJGFCDK, NativeArray<CJDKLCICIOC> PHPOHIJNGGI, GDLAFIILODC<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x82C1E30", Offset = "0x82C0C30", VA = "0x1882C1E30")]
	private void KMNHBOMKPAJ(Transform CMDMCJGFCDK, NativeArray<NKKPFAKHDHH> KDLJKLNNKGA, GDLAFIILODC<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x82C3410", Offset = "0x82C2210", VA = "0x1882C3410")]
	private void LPBDNOKNJBP(Transform CMDMCJGFCDK, NativeArray<MHABNBGLDMK> PNFBPHBBMMA, GDLAFIILODC<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x82C3830", Offset = "0x82C2630", VA = "0x1882C3830")]
	private void NBPFAJNMEDE(Transform CMDMCJGFCDK, NativeArray<IINKIJCIAOO> APIAOCPINLL, Mesh[] NFCGHAEILPH, GDLAFIILODC<GameObject> EHPJPDMDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x82C1220", Offset = "0x82C0020", VA = "0x1882C1220")]
	private static void DIPEBICBHAC(NativeParallelHashSet<Entity> DIDGDGLCMEE, NativeParallelHashSet<Entity> LDPLKDEFKPO, NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x82C1160", Offset = "0x82BFF60", VA = "0x1882C1160")]
	private static void BDGPBPGFBOI(NativeList<Entity> ECEBLBALENP, NativeArray<EntityRemapUtility.EntityRemapInfo> MMLAEDPLIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x82C3C60", Offset = "0x82C2A60", VA = "0x1882C3C60")]
	private NativeParallelHashMap<Entity, NCDIMOCJEIA> OPJLPKNHIKP(FGNGMENBLHA.HHEPOMMEDFA MANDNILIEHN, JHDEAMPCLAM<KLFILCBOPDC> FNKJCMBGDMM, List<GameObject> EHPJPDMDMOC)
	{
		return default(NativeParallelHashMap<Entity, NCDIMOCJEIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x82C1370", Offset = "0x82C0170", VA = "0x1882C1370")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> HLFCEKCNHDJ(Entity HHJCIFCKEEN)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x82C18E0", Offset = "0x82C06E0", VA = "0x1882C18E0")]
	private void KJJEMDHLIDD(NativeList<Entity> GGGKAJGDMJK, NativeList<Entity> BCEAAPIDPFO, NativeParallelHashMap<Entity, NCDIMOCJEIA> FPDPGHEDPBI, NativeList<PIHJPNGEKCI> DPDLOIKBOHO, NativeList<FLPAONONIEF> DFPPIPKDAHG, NativeList<EFFHBHGPCEP> CEPBLANBFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x82C1470", Offset = "0x82C0270", VA = "0x1882C1470")]
	private void IMMIIAIOINI(NativeList<Entity> DIDGDGLCMEE, NativeList<Entity> BJABKGICJPF, NativeParallelHashMap<Entity, NCDIMOCJEIA> FPDPGHEDPBI, NativeList<BHNMJKFJFGI> FJPLNCANBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x82B06E0", Offset = "0x82AF4E0", VA = "0x1882B06E0")]
	public NNMCFDIOKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GKIEBFJDGFM : CEOPIHMNPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS LOADEEDFKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly AIJLMLNJMHO CMDMCJGFCDK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject GOJGONDLKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS MBPKFFDBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x82B6310", Offset = "0x82B5110", VA = "0x1882B6310", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 KHPFGGFLDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x82B6180", Offset = "0x82B4F80", VA = "0x1882B6180", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 DGOFLJDIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x82B6270", Offset = "0x82B5070", VA = "0x1882B6270", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 HFPBGINCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x82B60E0", Offset = "0x82B4EE0", VA = "0x1882B60E0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x82B6130", Offset = "0x82B4F30", VA = "0x1882B6130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion KBDANKFKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x82B61D0", Offset = "0x82B4FD0", VA = "0x1882B61D0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x82B62C0", Offset = "0x82B50C0", VA = "0x1882B62C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 EMPBEBHPLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x82B6040", Offset = "0x82B4E40", VA = "0x1882B6040", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 GOFHNINFIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x82B6090", Offset = "0x82B4E90", VA = "0x1882B6090", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 ONKIBFAODAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x82B6220", Offset = "0x82B5020", VA = "0x1882B6220", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x82B63F0", Offset = "0x82B51F0", VA = "0x1882B63F0")]
	public GKIEBFJDGFM(UniformTRS LOADEEDFKKE, AIJLMLNJMHO CMDMCJGFCDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class KHFBGPEAAIG : GKIEBFJDGFM, IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float HHOICDFCKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 ANHKCEBFHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly AOKFBPFAEAA PPFLAKEGMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly PLHKBDHNDHI IDLOHJEKDMO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private GKKGCGDMMHN DLODDDAIGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x82BC710", Offset = "0x82BB510", VA = "0x1882BC710", Slot = "17")]
		get
		{
			return default(GKKGCGDMMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS NPEIINDMLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x82BC760", Offset = "0x82BB560", VA = "0x1882BC760", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float KFNJPHADHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAA8F00", Offset = "0xAA7D00", VA = "0x180AA8F00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IKGGDDFFLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x82BC6C0", Offset = "0x82BB4C0", VA = "0x1882BC6C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private AOKFBPFAEAA APLKIJCLNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xACBC40", Offset = "0xACAA40", VA = "0x180ACBC40", Slot = "21")]
		get
		{
			return default(AOKFBPFAEAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private PLHKBDHNDHI AMNEKNBBMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1401D80", Offset = "0x1400B80", VA = "0x181401D80", Slot = "22")]
		get
		{
			return default(PLHKBDHNDHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool EPPMLDKIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CBAECABMNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x82BC840", Offset = "0x82BB640", VA = "0x1882BC840")]
	protected KHFBGPEAAIG(UniformTRS LOADEEDFKKE, AIJLMLNJMHO CMDMCJGFCDK, float HHOICDFCKKO, float3 ANHKCEBFHHE, AOKFBPFAEAA PPFLAKEGMOB, PLHKBDHNDHI IDLOHJEKDMO)
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
public abstract class MCLKJPDDKPF : CEOPIHMNPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x128BBC0", Offset = "0x128A9C0", VA = "0x18128BBC0")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity CCDIJACDPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x82C06D0", Offset = "0x82BF4D0", VA = "0x1882C06D0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x82C06C0", Offset = "0x82BF4C0", VA = "0x1882C06C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x82C0820", Offset = "0x82BF620", VA = "0x1882C0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected ICGPKIBCHFK EMNPLGABNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82C0BD0", Offset = "0x82BF9D0", VA = "0x1882C0BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject GOJGONDLKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x82C03E0", Offset = "0x82BF1E0", VA = "0x1882C03E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS MBPKFFDBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x12BB690", Offset = "0x12BA490", VA = "0x1812BB690", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 KHPFGGFLDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x82C0990", Offset = "0x82BF790", VA = "0x1882C0990", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 DGOFLJDIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x82C0E20", Offset = "0x82BFC20", VA = "0x1882C0E20", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 HFPBGINCGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x82C06F0", Offset = "0x82BF4F0", VA = "0x1882C06F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x82C0880", Offset = "0x82BF680", VA = "0x1882C0880", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion KBDANKFKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x82C0A80", Offset = "0x82BF880", VA = "0x1882C0A80", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0F90", Offset = "0x82BFD90", VA = "0x1882C0F90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 EMPBEBHPLHN
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x82C0410", Offset = "0x82BF210", VA = "0x1882C0410", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 GOFHNINFIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0500", Offset = "0x82BF300", VA = "0x1882C0500", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 ONKIBFAODAD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x82C0C60", Offset = "0x82BFA60", VA = "0x1882C0C60", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xF175F0", Offset = "0xF163F0", VA = "0x180F175F0")]
	protected MCLKJPDDKPF(JDKDDPDJCCM AMECNEFIPBJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x82C0BA0", Offset = "0x82BF9A0", VA = "0x1882C0BA0")]
	public static GKKGCGDMMHN JGGBAIGHKJA(MCLKJPDDKPF ODOKMLFIJNG)
	{
		return default(GKKGCGDMMHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KNMCCKGAGMC
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x82CFCA0", Offset = "0x82CEAA0", VA = "0x1882CFCA0")]
	public static void BMEBBMJNAFC(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CHLHLBIDHLH
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82CED70", Offset = "0x82CDB70", VA = "0x1882CED70")]
	public static void DHCLDPBBDMI(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC, JLDCHECNAIA CHBEBFPENIB, BPAIJKJGNLD NMBGECILFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x82CF180", Offset = "0x82CDF80", VA = "0x1882CF180")]
	public static void EEELBKAFECD(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC, JLDCHECNAIA CHBEBFPENIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x82CF6F0", Offset = "0x82CE4F0", VA = "0x1882CF6F0")]
	public static NativeList<Entity> KLFELFEGBIH(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x82CF730", Offset = "0x82CE530", VA = "0x1882CF730")]
	public static NativeList<Entity> LEDIKKLNGOD(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82CF490", Offset = "0x82CE290", VA = "0x1882CF490")]
	private static NativeList<Entity> KLFELFEGBIH(NativeArray<Entity> DIDGDGLCMEE, EntityManager BIBOOAGIPAC, bool APMNEEHEBOH)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class MBEJDAODNLJ : MCLKJPDDKPF, IOKBKKINBCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float HHOICDFCKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 ANHKCEBFHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private AOKFBPFAEAA PPFLAKEGMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private PLHKBDHNDHI IDLOHJEKDMO;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager IKHIKBCMLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x82D0160", Offset = "0x82CEF60", VA = "0x1882D0160")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected MODFEFDOPCN HHGCCIBDEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x82D0220", Offset = "0x82CF020", VA = "0x1882D0220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData NDGOGNGOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x82CFEE0", Offset = "0x82CECE0", VA = "0x1882CFEE0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private GKKGCGDMMHN DLODDDAIGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0BA0", Offset = "0x82BF9A0", VA = "0x1882C0BA0", Slot = "17")]
		get
		{
			return default(GKKGCGDMMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float KFNJPHADHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB1B70", VA = "0x180AB2D70", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IKGGDDFFLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x13737B0", Offset = "0x13725B0", VA = "0x1813737B0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private AOKFBPFAEAA APLKIJCLNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420", Slot = "21")]
		get
		{
			return default(AOKFBPFAEAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private PLHKBDHNDHI AMNEKNBBMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAA74E0", Offset = "0xAA62E0", VA = "0x180AA74E0", Slot = "22")]
		get
		{
			return default(PLHKBDHNDHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS NPEIINDMLHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x82D01F0", Offset = "0x82CEFF0", VA = "0x1882D01F0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CBAECABMNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool EPPMLDKIEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x82D0280", Offset = "0x82CF080", VA = "0x1882D0280")]
	protected MBEJDAODNLJ(JDKDDPDJCCM AMECNEFIPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x82CFFD0", Offset = "0x82CEDD0", VA = "0x1882CFFD0", Slot = "26")]
	public virtual void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class GELOJECJLHP : MMBILNDFKLF, BIBHAKFMBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected BPAIJKJGNLD NMBGECILFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private DJHIFFLMBDL FHICECHOKKP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected JLDCHECNAIA BCOFHGJJHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x82CFA10", Offset = "0x82CE810", VA = "0x1882CFA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected CHEKCMOLHDO KNJJIBAEODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x82CF890", Offset = "0x82CE690", VA = "0x1882CF890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool IIDODIJDLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x82CF8E0", Offset = "0x82CE6E0", VA = "0x1882CF8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x82CF9A0", Offset = "0x82CE7A0", VA = "0x1882CF9A0", Slot = "15")]
	public virtual void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
	protected GELOJECJLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IGPILCFDEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x82CFA60", Offset = "0x82CE860", VA = "0x1882CFA60")]
	public static void JPODFADDOOF(NativeArray<Entity> GGGKAJGDMJK, EntityManager BIBOOAGIPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3449605573
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x82D0480", Offset = "0x82CF280", VA = "0x1882D0480")]
	public static void KJKFPIHJHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x82D0470", Offset = "0x82CF270", VA = "0x1882D0470")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FGEPJJALFDB : ContainerPropertyBag<MKDIFPELGEG>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x82CF7D0", Offset = "0x82CE5D0", VA = "0x1882CF7D0")]
	public FGEPJJALFDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class FOCCCEFILHB : ContainerPropertyBag<DHOPENLMGMP>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x82CF830", Offset = "0x82CE630", VA = "0x1882CF830")]
	public FOCCCEFILHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class EKGAIDOPOHG : ContainerPropertyBag<OOPLMJNGMIA>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x82CF770", Offset = "0x82CE570", VA = "0x1882CF770")]
	public EKGAIDOPOHG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x82D02B0", Offset = "0x82CF0B0", VA = "0x1882D02B0")]
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
