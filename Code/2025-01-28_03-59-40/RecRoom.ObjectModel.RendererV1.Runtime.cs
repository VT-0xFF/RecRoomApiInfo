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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73C0030", Offset = "0x73BF230", VA = "0x1873C0030", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0C10", Offset = "0x1DDFE10", VA = "0x181DE0C10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73C9910", Offset = "0x73C8B10", VA = "0x1873C9910")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73C9D90", Offset = "0x73C8F90", VA = "0x1873C9D90", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73C9DF0", Offset = "0x73C8FF0", VA = "0x1873C9DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KCPGDMLNAJF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73BE170", Offset = "0x73BD370", VA = "0x1873BE170")]
	public static Quaternion JINGBADJEGA([In] this GHEFNHFHIMC JABDKBNOIDB, [In] Vector3 BDIPLNMOFCC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CGKFENOKJCK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73AD7E0", Offset = "0x73AC9E0", VA = "0x1873AD7E0")]
	public static bool FKAMAEKAOFD(this MIFOPKBCNCO KAAKBIHCNAB, GCEHINAIMFJ CGDNKIJMMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73AD930", Offset = "0x73ACB30", VA = "0x1873AD930")]
	public static bool GDIGPFHNKKK(this MIFOPKBCNCO KAAKBIHCNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73AE410", Offset = "0x73AD610", VA = "0x1873AE410")]
	public static bool PHHAJBCHMEF(this MIFOPKBCNCO KAAKBIHCNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x73AC670", Offset = "0x73AB870", VA = "0x1873AC670")]
	public static void AFPLIDCIDCA(this MIFOPKBCNCO KAAKBIHCNAB, Vector3 NOKIDCDBNHD, Quaternion KLMFGIEKKIB, float COBBNHPDFBH, bool AEGNIMIPPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x73ADCA0", Offset = "0x73ACEA0", VA = "0x1873ADCA0")]
	public static void NEBDAIMJCHM(this MIFOPKBCNCO KAAKBIHCNAB, Vector3 NOKIDCDBNHD, Quaternion KLMFGIEKKIB, float COBBNHPDFBH, int MDDLDFCDELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73ADB80", Offset = "0x73ACD80", VA = "0x1873ADB80")]
	public static void MFANHLGKHPP(this MIFOPKBCNCO KAAKBIHCNAB, int MDDLDFCDELL, Vector3 NOKIDCDBNHD, Quaternion KLMFGIEKKIB, float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x73AE0F0", Offset = "0x73AD2F0", VA = "0x1873AE0F0")]
	public static void OMBCEIPECGO(this MIFOPKBCNCO KAAKBIHCNAB, Vector3 JDGKILLEFDD, Quaternion FDKIBAHNAAO, float COBBNHPDFBH, bool AEGNIMIPPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x73ACE80", Offset = "0x73AC080", VA = "0x1873ACE80")]
	private static void EKCHGFGPAHL(this MIFOPKBCNCO KAAKBIHCNAB, Vector3 FCKJMOMOHAE, Quaternion EGIHDGHICMO, float COBBNHPDFBH, bool AEGNIMIPPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73ADF30", Offset = "0x73AD130", VA = "0x1873ADF30")]
	private static void NGMFEIHAEJA(this MIFOPKBCNCO KAAKBIHCNAB, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, float BCIEGHNCHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73ACC90", Offset = "0x73ABE90", VA = "0x1873ACC90")]
	private static void DHGIFOPCKIA(this MIFOPKBCNCO KAAKBIHCNAB, int CPLNODNGKGB, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, float BCIEGHNCHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73AE3E0", Offset = "0x73AD5E0", VA = "0x1873AE3E0")]
	private static bool PCMGFNGBJPC(this MIFOPKBCNCO KAAKBIHCNAB, int CPLNODNGKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73AE140", Offset = "0x73AD340", VA = "0x1873AE140")]
	private static void PADGOGKOABK(this MIFOPKBCNCO KAAKBIHCNAB, int CPLNODNGKGB, Vector3 ONLMFNGKLOH, Quaternion IBAINNMCHCO, float BCIEGHNCHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7A0", Offset = "0x73AB9A0", VA = "0x1873AC7A0")]
	public static Vector3 CHFJKDOBBFH(this MIFOPKBCNCO KAAKBIHCNAB, int CPLNODNGKGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73AD820", Offset = "0x73ACA20", VA = "0x1873AD820")]
	public static Quaternion FKOHIEFJEJL(this MIFOPKBCNCO KAAKBIHCNAB, int CPLNODNGKGB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73AD960", Offset = "0x73ACB60", VA = "0x1873AD960")]
	public static Vector3 JOCBILDIIFN(GCEHINAIMFJ HPIEALDMKDL, Vector3 FCKJMOMOHAE, Vector3? BJBEDEMMCEB, Vector3 AGGIGPGPLNF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface AAKGDBFNEIM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLBALEMDFIN(EntityQuery BEAAEGFHIAL, EntityManager ACAAJNNIMJL, GCLGCHJKJOB DNIPNOKEENP, JPLOJLEEOAH HMBDFFFLAIK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface MJNOCIIILGI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType JMCJHMEIAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBHEEHDILKI(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMHNJJFEJND(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHIEAGDCLBL(AOFAIHBKPNG JFGOCCGJCBH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class EBKHPDCDANJ : AAKGDBFNEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73AEFE0", Offset = "0x73AE1E0", VA = "0x1873AEFE0", Slot = "4")]
	public void DLBALEMDFIN(EntityQuery BEAAEGFHIAL, EntityManager ACAAJNNIMJL, GCLGCHJKJOB DNIPNOKEENP, JPLOJLEEOAH HMBDFFFLAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public EBKHPDCDANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class CANEMDNNCCM : AAKGDBFNEIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NAOAHHFOEAM JFGHHALANHN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
	public CANEMDNNCCM(NAOAHHFOEAM JFGHHALANHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x73AB310", Offset = "0x73AA510", VA = "0x1873AB310", Slot = "4")]
	public void DLBALEMDFIN(EntityQuery BEAAEGFHIAL, EntityManager ACAAJNNIMJL, GCLGCHJKJOB DNIPNOKEENP, JPLOJLEEOAH HMBDFFFLAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class ADJOEAHEOLL : AAKGDBFNEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x73A9DC0", Offset = "0x73A8FC0", VA = "0x1873A9DC0", Slot = "4")]
	public void DLBALEMDFIN(EntityQuery BEAAEGFHIAL, EntityManager ACAAJNNIMJL, GCLGCHJKJOB DNIPNOKEENP, JPLOJLEEOAH HMBDFFFLAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ADJOEAHEOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LEFJBOAHADO : MJNOCIIILGI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType JMCJHMEIAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x73BF560", Offset = "0x73BE760", VA = "0x1873BF560", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73BF590", Offset = "0x73BE790", VA = "0x1873BF590", Slot = "5")]
	public void EBHEEHDILKI(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73BF810", Offset = "0x73BEA10", VA = "0x1873BF810", Slot = "6")]
	public void GMHNJJFEJND(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73BFA90", Offset = "0x73BEC90", VA = "0x1873BFA90", Slot = "7")]
	public void OHIEAGDCLBL(AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public LEFJBOAHADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CNKLDCCDIPF : MJNOCIIILGI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType JMCJHMEIAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x73AE440", Offset = "0x73AD640", VA = "0x1873AE440", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73AE470", Offset = "0x73AD670", VA = "0x1873AE470", Slot = "5")]
	public void EBHEEHDILKI(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73AE6F0", Offset = "0x73AD8F0", VA = "0x1873AE6F0", Slot = "6")]
	public void GMHNJJFEJND(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73AE970", Offset = "0x73ADB70", VA = "0x1873AE970", Slot = "7")]
	public void OHIEAGDCLBL(AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public CNKLDCCDIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FDLKEHKCBLF : MJNOCIIILGI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType JMCJHMEIAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x73AF300", Offset = "0x73AE500", VA = "0x1873AF300", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73AF330", Offset = "0x73AE530", VA = "0x1873AF330", Slot = "5")]
	public void EBHEEHDILKI(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73AF5B0", Offset = "0x73AE7B0", VA = "0x1873AF5B0", Slot = "6")]
	public void GMHNJJFEJND(EntityQuery BEAAEGFHIAL, AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73AF830", Offset = "0x73AEA30", VA = "0x1873AF830", Slot = "7")]
	public void OHIEAGDCLBL(AOFAIHBKPNG JFGOCCGJCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public FDLKEHKCBLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class AFIBFNIPODC : CGIKCMPOGCF, AFDHOICPIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private GCLGCHJKJOB DNIPNOKEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EOJPBENJFKC LHLIBKGDAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JPLOJLEEOAH HMBDFFFLAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, AAKGDBFNEIM adapter)> KKLIMIBLOMN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x73A9F80", Offset = "0x73A9180", VA = "0x1873A9F80", Slot = "15")]
	public virtual void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x73AA010", Offset = "0x73A9210", VA = "0x1873AA010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73AA430", Offset = "0x73A9630", VA = "0x1873AA430")]
	private void PALMKDJHBPE(EntityQueryDesc HAFOMBGFBDB, AAKGDBFNEIM MMNFIGNIBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73AA240", Offset = "0x73A9440", VA = "0x1873AA240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public AFIBFNIPODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class IADPJEFAIFO : CGIKCMPOGCF, AFDHOICPIPH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class MKAADGAIDLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery IOOKHJFIBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HGJOIBCHLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery GHHJPDDHCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery CECIBNEAADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery IOJGDJNNEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery IDEMOJIGOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MJNOCIIILGI DEOPFFJLMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ComponentType JBNAILIELGG;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MKAADGAIDLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private GCLGCHJKJOB DNIPNOKEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private JPLOJLEEOAH HMBDFFFLAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EOJPBENJFKC LHLIBKGDAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<MKAADGAIDLI> KKLIMIBLOMN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73BC5E0", Offset = "0x73BB7E0", VA = "0x1873BC5E0", Slot = "14")]
	public void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73BC7F0", Offset = "0x73BB9F0", VA = "0x1873BC7F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x73BC670", Offset = "0x73BB870", VA = "0x1873BC670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73BC980", Offset = "0x73BBB80", VA = "0x1873BC980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73BC2A0", Offset = "0x73BB4A0", VA = "0x1873BC2A0")]
	private void GBABHJEMEGH(MKAADGAIDLI JFLEKIKLEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x73BCB90", Offset = "0x73BBD90", VA = "0x1873BCB90")]
	private void PALMKDJHBPE(MJNOCIIILGI DEOPFFJLMAN, ComponentType FNGGPGGLNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public IADPJEFAIFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct IFJAKJPCGFE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct KKMADECJJBF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct JLBMFJFAPID : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(JPLOJLEEOAH), new string[] { })]
public class LGHIADLKKDG : JPLOJLEEOAH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JHEIHPJJONE NMJCMNFBIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JHEIHPJJONE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public LGHIADLKKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(NHCMBLLOECB), new string[] { })]
public class PKOBGMCBCBF : NHCMBLLOECB, BJGPNHPOKFJ, CDKIFFPDAFF, AGGHCDPFEAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[DependsOn]
	private EEPABMPJIMJ HMFCAHOKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private GCLGCHJKJOB DNIPNOKEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private EKHABGHIANL HHGPPDCIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Entity BFCOFMFBCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IMHPOJOIOJD EGDBBAKCPGH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x73C5C20", Offset = "0x73C4E20", VA = "0x1873C5C20", Slot = "4")]
	public bool KKHPIEPDMMG(CIBKNFGEPGP IMMLHGFCKGF, LHLPPNFLPDM OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73C5850", Offset = "0x73C4A50", VA = "0x1873C5850", Slot = "5")]
	public IMHPOJOIOJD DBDDPKEINCA()
	{
		return default(IMHPOJOIOJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73C5B10", Offset = "0x73C4D10", VA = "0x1873C5B10", Slot = "6")]
	public void GBFIEJOIMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73C5D00", Offset = "0x73C4F00", VA = "0x1873C5D00", Slot = "7")]
	private void MDGJKGBLCGG(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xF9B4B0", Offset = "0xF9A6B0", VA = "0x180F9B4B0", Slot = "8")]
	private void DEIJODOHECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public PKOBGMCBCBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(JCOJACFHIFA), new string[] { })]
public class FONCGPDGPJO : JCOJACFHIFA
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73AF8E0", Offset = "0x73AEAE0", VA = "0x1873AF8E0", Slot = "4")]
	public void BAEKNIDPMEI(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x73B01C0", Offset = "0x73AF3C0", VA = "0x1873B01C0", Slot = "5")]
	public void KKDFIIPFLDB(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x73B0170", Offset = "0x73AF370", VA = "0x1873B0170", Slot = "6")]
	public ComponentSystemBase KJICMCEPAAC(World HMFCAHOKFHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73AF9C0", Offset = "0x73AEBC0", VA = "0x1873AF9C0", Slot = "7")]
	public void CPBCIMCDKHK(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73AF960", Offset = "0x73AEB60", VA = "0x1873AF960", Slot = "8")]
	public void CMPAHLJPGFO(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x73AF880", Offset = "0x73AEA80", VA = "0x1873AF880", Slot = "9")]
	public void AOGPOIDKFFP(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x73B00D0", Offset = "0x73AF2D0", VA = "0x1873B00D0", Slot = "10")]
	public void GAHNCEAGCGD(World HMFCAHOKFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73AFA20", Offset = "0x73AEC20", VA = "0x1873AFA20", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FJOLLLLLEKD()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public FONCGPDGPJO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OMJMBEIBOAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BKMKIPCGKFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OJGBAFAKGFB : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CHNJCLCIIHF OEKKJCNMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x73C3340", Offset = "0x73C2540", VA = "0x1873C3340", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x73C32D0", Offset = "0x73C24D0", VA = "0x1873C32D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OJGBAFAKGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JFELCGGGAID : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public IMHPOJOIOJD KOANHBPJFBM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static JFELCGGGAID KEDBNOKLEHE(IMHPOJOIOJD AINDMPLBNFF)
	{
		return default(JFELCGGGAID);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OBIBHJIIPNM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HDHNHBENNJN GILPMNKPIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73C2140", Offset = "0x73C1340", VA = "0x1873C2140", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OBIBHJIIPNM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ONLLJCPEECC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GNDNCACLKDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public PBANANEDPKJ JJJLGOBMJLF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static GNDNCACLKDJ KEDBNOKLEHE(PBANANEDPKJ AINDMPLBNFF)
	{
		return default(GNDNCACLKDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LKCDOABFICA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IMHPOJOIOJD KOANHBPJFBM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static LKCDOABFICA KEDBNOKLEHE(IMHPOJOIOJD AINDMPLBNFF)
	{
		return default(LKCDOABFICA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EFEMJLFMFHF : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OPFNBBFLGAH FGCHHKFHEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73AF2B0", Offset = "0x73AE4B0", VA = "0x1873AF2B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73AF240", Offset = "0x73AE440", VA = "0x1873AF240", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public EFEMJLFMFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NMIKHHHKNFC : LCGCCJFLBDO, CHNJCLCIIHF, FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BGAPCNLHHPL LDFDLFIBENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3B0", Offset = "0xBB95B0", VA = "0x180BBA3B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(BGAPCNLHHPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LBIGOPPPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA8D1A0", Offset = "0xA8C3A0", VA = "0x180A8D1A0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 AKNGNLDICHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xECC600", Offset = "0xECB800", VA = "0x180ECC600", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73C1420", Offset = "0x73C0620", VA = "0x1873C1420")]
	public NMIKHHHKNFC(UniformTRS BBADKBNANFF, JGGGIHBIMPC DBEHKFODEEL, float GEEPLGPHMLO, float3 GGPMBPBMGHE, HOLOGFIEFDN FLANOGIBFIK, DIABBMOAIAG HHABDDPJBPD, BGAPCNLHHPL BGHKGPOBOOH, float3 FBOIPCMLEAA, bool EFOMIDIOIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73C13D0", Offset = "0x73C05D0", VA = "0x1873C13D0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BFEJBOPMOAP : LCGCCJFLBDO, OPFNBBFLGAH, FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<CHNNPJCIGPE> JIINBFDKBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly NFLNGEMCPPK HLJPDMABNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly float PBHMBDKFOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly int LCMELDGLDNC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IFBNJBLNAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73AAEB0", Offset = "0x73AA0B0", VA = "0x1873AAEB0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EOAJJMHPLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73AAED0", Offset = "0x73AA0D0", VA = "0x1873AAED0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool APNNOIKDMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x73AAEC0", Offset = "0x73AA0C0", VA = "0x1873AAEC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BPHDAHGENNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBFC380", Offset = "0xBFB580", VA = "0x180BFC380", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JECNBNFELJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xB24E30", Offset = "0xB24030", VA = "0x180B24E30", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CIBDACEALGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA56480", Offset = "0xA55680", VA = "0x180A56480", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x73AAE00", Offset = "0x73AA000", VA = "0x1873AAE00")]
	public BFEJBOPMOAP(UniformTRS BBADKBNANFF, JGGGIHBIMPC DBEHKFODEEL, float GEEPLGPHMLO, float3 GGPMBPBMGHE, HOLOGFIEFDN FLANOGIBFIK, DIABBMOAIAG HHABDDPJBPD, NFLNGEMCPPK HLJPDMABNJO, float PBHMBDKFOGM, int LCMELDGLDNC, NativeArray<CHNNPJCIGPE> JIINBFDKBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xEE5310", Offset = "0xEE4510", VA = "0x180EE5310", Slot = "33")]
	public NativeArray<CHNNPJCIGPE> GetNativeCurvePoints()
	{
		return default(NativeArray<CHNNPJCIGPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73AAD40", Offset = "0x73A9F40", VA = "0x1873AAD40", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AONKHBJNEND : PCGKGNPILGM, CHNJCLCIIHF, FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Dictionary<EAOBBGHPEOO, BGAPCNLHHPL> GEGMBBCKBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BGAPCNLHHPL BGHKGPOBOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool EFOMIDIOIOP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private BGAPCNLHHPL DFBIDAGFNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x911450", Offset = "0x910650", VA = "0x180911450", Slot = "28")]
		get
		{
			return default(BGAPCNLHHPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool MNAAMPLFENO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCC4CD0", Offset = "0xCC3ED0", VA = "0x180CC4CD0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 AKNGNLDICHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73AAC70", Offset = "0x73A9E70", VA = "0x1873AAC70", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73AAC30", Offset = "0x73A9E30", VA = "0x1873AAC30")]
	public AONKHBJNEND(CIBKNFGEPGP OFNKJKFNBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73AA5A0", Offset = "0x73A97A0", VA = "0x1873AA5A0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73AA5F0", Offset = "0x73A97F0", VA = "0x1873AA5F0", Slot = "26")]
	public override void MEIPIBBEBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CBHIOLAOHPD : CCJCKJOHKBI, HDHNHBENNJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private GameObject NIFOCGEANNA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject EBDEMNLMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x73AB4E0", Offset = "0x73AA6E0", VA = "0x1873AB4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HLDKLCEAPAJ JICGKLMMHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73AB570", Offset = "0x73AA770", VA = "0x1873AB570", Slot = "15")]
		get
		{
			return default(HLDKLCEAPAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KPNBLOEFJLM PILNDFLHAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "16")]
		get
		{
			return default(KPNBLOEFJLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x73AB810", Offset = "0x73AAA10", VA = "0x1873AB810")]
	public CBHIOLAOHPD(CIBKNFGEPGP IMMLHGFCKGF, bool OHGAFILAPDJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73AB6A0", Offset = "0x73AA8A0", VA = "0x1873AB6A0")]
	public void PMPJGBMMBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73AB570", Offset = "0x73AA770", VA = "0x1873AB570")]
	protected HLDKLCEAPAJ DDCPBFLJHAC()
	{
		return default(HLDKLCEAPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x73AB670", Offset = "0x73AA870", VA = "0x1873AB670", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NPMJOLEGNME : PCGKGNPILGM, OPFNBBFLGAH, FDIGCKFAKMF, IDisposable, CEJNEKCLMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NativeList<CHNNPJCIGPE> JIINBFDKBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private bool CKCHBHKBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PGOPMONADEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private float PBHMBDKFOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int LCMELDGLDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool LFBNHFMPHLL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JHGMHAHOFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xABD790", Offset = "0xABC990", VA = "0x180ABD790", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool EMBDLFCLGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x93E680", Offset = "0x93D880", VA = "0x18093E680", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float MKHNBMHHKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE8C7D0", Offset = "0xE8B9D0", VA = "0x180E8C7D0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int DLHBDALOJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBBA3B0", Offset = "0xBB95B0", VA = "0x180BBA3B0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool FOKEACFGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA8D1A0", Offset = "0xA8C3A0", VA = "0x180A8D1A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int AGLBDEBKELC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73C14C0", Offset = "0x73C06C0", VA = "0x1873C14C0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int PCCOCIBDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x73C1BF0", Offset = "0x73C0DF0", VA = "0x1873C1BF0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73C1DC0", Offset = "0x73C0FC0", VA = "0x1873C1DC0")]
	public NPMJOLEGNME(CIBKNFGEPGP OFNKJKFNBEJ, [Optional] NativeList<CHNNPJCIGPE> JIINBFDKBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x73C1CE0", Offset = "0x73C0EE0", VA = "0x1873C1CE0", Slot = "26")]
	public override void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73C1750", Offset = "0x73C0950", VA = "0x1873C1750", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x73C1840", Offset = "0x73C0A40", VA = "0x1873C1840", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x73C1550", Offset = "0x73C0750", VA = "0x1873C1550")]
	public void BNPONNLOLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73C18A0", Offset = "0x73C0AA0", VA = "0x1873C18A0", Slot = "34")]
	public NativeArray<CHNNPJCIGPE> GetNativeCurvePoints()
	{
		return default(NativeArray<CHNNPJCIGPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x73C1AA0", Offset = "0x73C0CA0", VA = "0x1873C1AA0", Slot = "35")]
	private Vector3 KJJFJGJAPLF(int ODMGJHMGBIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x73C1A70", Offset = "0x73C0C70", VA = "0x1873C1A70", Slot = "36")]
	private Quaternion HMGAGBGFMJB(int ODMGJHMGBIJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73C15B0", Offset = "0x73C07B0", VA = "0x1873C15B0", Slot = "37")]
	private float CEIKBMNPCKM(int ODMGJHMGBIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x73C14E0", Offset = "0x73C06E0", VA = "0x1873C14E0")]
	private NativeArray<Entity> ALBCIFCIIKL()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class KLJKHPEAPFB : OMDAOJMBIID
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73BEFB0", Offset = "0x73BE1B0", VA = "0x1873BEFB0", Slot = "15")]
	protected override ComponentSystemBase PFMBGAPBKCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73BEFA0", Offset = "0x73BE1A0", VA = "0x1873BEFA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73BF350", Offset = "0x73BE550", VA = "0x1873BF350")]
	public KLJKHPEAPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FNJDBJHKMGO]
public sealed class KHLLOENALPH : ICKEALEHHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery INHCJMCFMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery BIIBJBFFNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery BLPJENIKACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery PKPAAGGGNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery NOIFKOKJFOI;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x73BEB70", Offset = "0x73BDD70", VA = "0x1873BEB70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x73BEED0", Offset = "0x73BE0D0", VA = "0x1873BEED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73BE950", Offset = "0x73BDB50", VA = "0x1873BE950")]
	private void NBKNIHEGGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x73BE720", Offset = "0x73BD920", VA = "0x1873BE720")]
	private void FAFFGJABENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x73BE510", Offset = "0x73BD710", VA = "0x1873BE510")]
	private void BPHFNGGEFFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x73BE250", Offset = "0x73BD450", VA = "0x1873BE250")]
	private void ALLHOKMLAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x73BE3E0", Offset = "0x73BD5E0", VA = "0x1873BE3E0")]
	private void BNKMOGFFBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73BE380", Offset = "0x73BD580", VA = "0x1873BE380")]
	private NativeList<Entity> BBIPCPOAHDM(NativeArray<Entity> NNDJLDGDLBA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x73BE8F0", Offset = "0x73BDAF0", VA = "0x1873BE8F0")]
	private NativeList<Entity> GEFCMEJAFJI(NativeArray<Entity> NNDJLDGDLBA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x73BE860", Offset = "0x73BDA60", VA = "0x1873BE860")]
	private void FNDMMDCNOFF(NativeArray<Entity> NNDJLDGDLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public KHLLOENALPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FNJDBJHKMGO]
public sealed class GGNIKGIKPMF : ICKEALEHHBN, AFDHOICPIPH
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery PDNIHFPKIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery LLIELJENMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery GHHJPDDHCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private NHCMBLLOECB HDFBNIEEMDA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x73B75B0", Offset = "0x73B67B0", VA = "0x1873B75B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x73B65C0", Offset = "0x73B57C0", VA = "0x1873B65C0", Slot = "15")]
	public override void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x73B7780", Offset = "0x73B6980", VA = "0x1873B7780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x73B6D80", Offset = "0x73B5F80", VA = "0x1873B6D80")]
	private void OCNGMKGGCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x73B6660", Offset = "0x73B5860", VA = "0x1873B6660")]
	private void JMOONFBKKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x73B61D0", Offset = "0x73B53D0", VA = "0x1873B61D0")]
	private void GOHCGCDAEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x73B6CE0", Offset = "0x73B5EE0", VA = "0x1873B6CE0")]
	private bool LIEGJPADKHM(Entity KPFAGKHHMMH, [Out] IMHPOJOIOJD KOANHBPJFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x73B7400", Offset = "0x73B6600", VA = "0x1873B7400")]
	private bool OPOMAPLCJAN(Entity KPFAGKHHMMH, [Out] IMHPOJOIOJD KOANHBPJFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public GGNIKGIKPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[FNJDBJHKMGO]
public sealed class MCEJMHFJAHG : ICKEALEHHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EntityQuery CHJGFBOIJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery FBBKOFGPPOH;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x73C09D0", Offset = "0x73BFBD0", VA = "0x1873C09D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x73C0B20", Offset = "0x73BFD20", VA = "0x1873C0B20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x73C06C0", Offset = "0x73BF8C0", VA = "0x1873C06C0")]
	private void OCNGMKGGCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x73C03B0", Offset = "0x73BF5B0", VA = "0x1873C03B0")]
	private void JMOONFBKKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public MCEJMHFJAHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PIJOEOFKFDG : ICKEALEHHBN, AFDHOICPIPH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct LKBCJNNKPEN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public EntityQueryInJob KBAHEOMFHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob AGKHCHADGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob AJBJHJGLGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob DFELMJAILLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ReadOnly]
		public EntityTypeHandle FHMKCODKFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public ComponentTypeHandle<LKCDOABFICA> MILPKBKCDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeList<Entity> FDMADHLJKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> EECNLCJEEOO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x73BFAE0", Offset = "0x73BECE0", VA = "0x1873BFAE0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x73BFB60", Offset = "0x73BED60", VA = "0x1873BFB60")]
		private void HAGAFFLAAOO(EntityQueryInJob BEAAEGFHIAL, NativeList<Entity> DOPHGDFLANK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct FPPGBLDLFFN : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public EntityTypeHandle FHMKCODKFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public ComponentTypeHandle<LKCDOABFICA> MILPKBKCDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> DOPHGDFLANK;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x73B0210", Offset = "0x73AF410", VA = "0x1873B0210", Slot = "4")]
		public void Execute(ArchetypeChunk AELEHFNBCII, int IPAHNOCIDCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct IBCGDJCJHAN : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle FHMKCODKFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> GBIJGGANOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<GNDNCACLKDJ> DEGIFHFAIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentDataFromEntity<JFELCGGGAID> FKIOPFMFGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public ComponentTypeHandle<LKCDOABFICA> JMFEEJCKKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeList<Entity> BPICNKPJDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<GNDNCACLKDJ> AGEIBPKBCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<IMHPOJOIOJD> FPJJNJGGDAN;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x73BD2B0", Offset = "0x73BC4B0", VA = "0x1873BD2B0", Slot = "4")]
		public void Execute(ArchetypeChunk AELEHFNBCII, int IPAHNOCIDCC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery KBAHEOMFHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery AGKHCHADGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery AJBJHJGLGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery DFELMJAILLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery OKDENDAIODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery NCAJHEPNCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery FOJIPLNBKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private NHCMBLLOECB BDKAJMIEAEK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x73C4F10", Offset = "0x73C4110", VA = "0x1873C4F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x73C4AE0", Offset = "0x73C3CE0", VA = "0x1873C4AE0", Slot = "15")]
	public override void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x73C5490", Offset = "0x73C4690", VA = "0x1873C5490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x73C3A10", Offset = "0x73C2C10", VA = "0x1873C3A10")]
	private void AOHBACBJNJK(NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE, int GJDBLEBNIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x73C4250", Offset = "0x73C3450", VA = "0x1873C4250")]
	private void EHFPHHIHMMF(NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE, int CJMDCENJBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x73C46A0", Offset = "0x73C38A0", VA = "0x1873C46A0")]
	private void IOHDFPPGELM(NativeParallelHashSet<IMHPOJOIOJD> GGBMIOMDIJE, int OGCDMMIPOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73C4B80", Offset = "0x73C3D80", VA = "0x1873C4B80")]
	private void KFGODIMKMAC(NativeParallelHashSet<IMHPOJOIOJD> GBOJEJBAMDI, int JDNIELFBGOG, int IEALBJALJPM, int FABEKAPLFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x73C4010", Offset = "0x73C3210", VA = "0x1873C4010")]
	private void DDECFNMGANI(Entity CFMPEIOKPKP, PBANANEDPKJ COCMCPHHACI, IMHPOJOIOJD KOANHBPJFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public PIJOEOFKFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class NJGLKOOCCNC : ICKEALEHHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private EntityQuery BEAAEGFHIAL;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x73C0E10", Offset = "0x73C0010", VA = "0x1873C0E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x73C0EC0", Offset = "0x73C00C0", VA = "0x1873C0EC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public NJGLKOOCCNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[FNJDBJHKMGO]
internal class OHKFAIMLDLH : ICKEALEHHBN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NDKJKBJGEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EntityQuery GMFMGIBGEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public EntityQuery GNMJDOCOFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AALDFPJHJCK BIGKEKFJDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ComponentType LDJBEGFPIKD;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NDKJKBJGEAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private delegate void AALDFPJHJCK(NativeArray<PBANANEDPKJ> AINDMPLBNFF, AOFAIHBKPNG JFGOCCGJCBH);

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<NDKJKBJGEAN> KKLIMIBLOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EOJPBENJFKC LHLIBKGDAOD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x73C27D0", Offset = "0x73C19D0", VA = "0x1873C27D0", Slot = "15")]
	public override void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x73C2BB0", Offset = "0x73C1DB0", VA = "0x1873C2BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73C2D40", Offset = "0x73C1F40", VA = "0x1873C2D40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3438070", Offset = "0x3437270", VA = "0x183438070")]
	private void PALMKDJHBPE<T>(AALDFPJHJCK BIGKEKFJDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x73C2870", Offset = "0x73C1A70", VA = "0x1873C2870")]
	private static void LFDMJOFNKOP(NativeArray<PBANANEDPKJ> MDDOOEMKCOM, AOFAIHBKPNG AHAICOAHEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73C2630", Offset = "0x73C1830", VA = "0x1873C2630")]
	private static void FLMMPNLPGGJ(NativeArray<PBANANEDPKJ> MDDOOEMKCOM, AOFAIHBKPNG AHAICOAHEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73C2A10", Offset = "0x73C1C10", VA = "0x1873C2A10")]
	private static void MNPOHJLIKGM(NativeArray<PBANANEDPKJ> MDDOOEMKCOM, AOFAIHBKPNG AHAICOAHEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public OHKFAIMLDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[FNJDBJHKMGO]
public sealed class OCBFGGHKPJM : ICKEALEHHBN
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EntityQuery BEAAEGFHIAL;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73C21B0", Offset = "0x73C13B0", VA = "0x1873C21B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DPJIGCGLIOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public UniformTRS BBADKBNANFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public StandardRenderableVisualData ALCHLHCOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public BGAPCNLHHPL BGHKGPOBOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float3 FBOIPCMLEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool EFOMIDIOIOP;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PGAEGHNFIIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeList<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeList<Entity> HODGBONNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeParallelHashSet<Entity> JDOLINCOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<DPJIGCGLIOC> MBNMLLMNLLB;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x73C3740", Offset = "0x73C2940", VA = "0x1873C3740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterService(typeof(GAPFIPDNAFD), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class GAPFIPDNAFD : AFDHOICPIPH, CIDGALBBDPG, CDKIFFPDAFF, AGGHCDPFEAK
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct BHMEMPAANLI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly GAPFIPDNAFD DBEHKFODEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly bool AIBFMHKKHEG;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1532D30", Offset = "0x1531F30", VA = "0x181532D30")]
		public BHMEMPAANLI(GAPFIPDNAFD DBEHKFODEEL, bool AIBFMHKKHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x73AB1F0", Offset = "0x73AA3F0", VA = "0x1873AB1F0")]
		public Queue<DNAPAKCDDME>.Enumerator EMKBHPPGLAN()
		{
			return default(Queue<DNAPAKCDDME>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x73AAEE0", Offset = "0x73AA0E0", VA = "0x1873AAEE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[DependsOn]
	private EKHABGHIANL IHKPGDOPBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[DependsOn]
	private HBJOEILPNHI MBEBFJBAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<NativeList<CHNNPJCIGPE>> PKLMOLCEAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<PBANANEDPKJ> HCDNFJHJKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<(Entity, List<GameObject>)> APCMMMBCGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private AIJJJHBFAIF<DNAPAKCDDME> GFKGIEKALPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private AIJJJHBFAIF<PGAEGHNFIIL> CJNKPPDMJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private AIJJJHBFAIF<MOOGPMOENJP> FDLKCNPOCII;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73B0EE0", Offset = "0x73B00E0", VA = "0x1873B0EE0", Slot = "4")]
	public void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73B1170", Offset = "0x73B0370", VA = "0x1873B1170")]
	public void KJNLJBLMNIN(NativeList<CHNNPJCIGPE> DMPLILNJAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73B0890", Offset = "0x73AFA90", VA = "0x1873B0890")]
	public void BABFBCEKKHL(Entity DBEHKFODEEL, [In] CMGBCFKNNNB<GameObject> HEPBPKEBCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73B10E0", Offset = "0x73B02E0", VA = "0x1873B10E0")]
	public void KDMJJGKJJFH(NativeList<PBANANEDPKJ> MDDOOEMKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73B0460", Offset = "0x73AF660", VA = "0x1873B0460")]
	public void AOGPOIDKFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73B0A30", Offset = "0x73AFC30", VA = "0x1873B0A30")]
	public void FOFOCPNHLNJ(ELNPEFEPDJC ODPBGAGOMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x73B1350", Offset = "0x73B0550", VA = "0x1873B1350")]
	public JobHandle PMKFMIABINN([In] DNAPAKCDDME CBCJFCINKPJ, JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x73B13F0", Offset = "0x73B05F0", VA = "0x1873B13F0")]
	public JobHandle PMKFMIABINN([In] PGAEGHNFIIL CBCJFCINKPJ, JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x70C4910", Offset = "0x70C3B10", VA = "0x1870C4910")]
	public BHMEMPAANLI PHLOFMGPFJM(bool AIBFMHKKHEG)
	{
		return default(BHMEMPAANLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x73B1240", Offset = "0x73B0440", VA = "0x1873B1240")]
	public JICJDAJNLHP<PGAEGHNFIIL> MDDBNLBODMA()
	{
		return default(JICJDAJNLHP<PGAEGHNFIIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x73B1300", Offset = "0x73B0500", VA = "0x1873B1300")]
	public JICJDAJNLHP<MOOGPMOENJP> OFDBIKFMAJG()
	{
		return default(JICJDAJNLHP<MOOGPMOENJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x73B0680", Offset = "0x73AF880", VA = "0x1873B0680", Slot = "5")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x73B1290", Offset = "0x73B0490", VA = "0x1873B1290", Slot = "6")]
	private void MDGJKGBLCGG(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7371960", Offset = "0x7370B60", VA = "0x187371960", Slot = "7")]
	private void DEIJODOHECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public GAPFIPDNAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DGHFHOMOCBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public UniformTRS BBADKBNANFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public StandardRenderableVisualData ALCHLHCOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public LMHHOBCBPNM HLJPDMABNJO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct DNAPAKCDDME : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeList<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeList<Entity> HODGBONNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeParallelHashSet<Entity> JDOLINCOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeList<FCLIOCDNHNC> MFLHDLGKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeList<CHNNPJCIGPE> DMPLILNJAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<DGHFHOMOCBD> PHCIOJBENJO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x73AEF00", Offset = "0x73AE100", VA = "0x1873AEF00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x73AEF10", Offset = "0x73AE110", VA = "0x1873AEF10")]
	public void MFBFDNDBONL(bool AIBFMHKKHEG)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : ICKEALEHHBN, AFDHOICPIPH
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[ReadOnly]
			public NativeParallelHashMap<int, BGAPCNLHHPL> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public NativeArray<DPJIGCGLIOC> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x73B7840", Offset = "0x73B6A40", VA = "0x1873B7840", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public NativeArray<CHNNPJCIGPE> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[ReadOnly]
			public NativeArray<FCLIOCDNHNC> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<DGHFHOMOCBD> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x73B7BE0", Offset = "0x73B6DE0", VA = "0x1873B7BE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x73AE9C0", Offset = "0x73ADBC0", VA = "0x1873AE9C0", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0x73C5DE0", Offset = "0x73C4FE0", VA = "0x1873C5DE0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0x73C5D90", Offset = "0x73C4F90", VA = "0x1873C5D90")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 IKAOPNDLOGK(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x73BFC40", Offset = "0x73BEE40", VA = "0x1873BFC40", Slot = "5")]
				public float3 GADIJJMFOAG(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x73BFFF0", Offset = "0x73BF1F0", VA = "0x1873BFFF0", Slot = "4")]
				public float3 IKAOPNDLOGK(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x73C1E10", Offset = "0x73C1010", VA = "0x1873C1E10", Slot = "4")]
				public float3 IKAOPNDLOGK(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public NativeArray<FCLIOCDNHNC> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NativeArray<CHNNPJCIGPE> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x73B99F0", Offset = "0x73B8BF0", VA = "0x1873B99F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x73B8B10", Offset = "0x73B7D10", VA = "0x1873B8B10")]
			private void CJMKHHIICNM(NativeList<PointSrcData> srcData, NativeList<CHNNPJCIGPE> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x73BAC10", Offset = "0x73B9E10", VA = "0x1873BAC10")]
			public static Vector3 MDLFANFGADP(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x73BBED0", Offset = "0x73BB0D0", VA = "0x1873BBED0")]
			public static quaternion ONAKJPIPAJE(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x73BA380", Offset = "0x73B9580", VA = "0x1873BA380")]
			private static quaternion HHKBCKLCKLO(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x73B8300", Offset = "0x73B7500", VA = "0x1873B8300")]
			private static float3 BCBNFOMDGAP(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x73BAB80", Offset = "0x73B9D80", VA = "0x1873BAB80")]
			private static quaternion KAEHNEGPDKA(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x73BA5B0", Offset = "0x73B97B0", VA = "0x1873BA5B0")]
			private static CHNNPJCIGPE HICILKENNIH(int idx, NativeList<PointSrcData> srcData)
			{
				return default(CHNNPJCIGPE);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x399B070", Offset = "0x399A270", VA = "0x18399B070")]
			private void IHLIBHCMJFJ<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x73BB020", Offset = "0x73BA220", VA = "0x1873BB020")]
			private void MPBKIFOLDJM(NativeList<PointSrcData> sourcePoints, NativeList<CHNNPJCIGPE> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x73BA050", Offset = "0x73B9250", VA = "0x1873BA050")]
			public static float FGDAJKMAEHE(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x73BC020", Offset = "0x73BB220", VA = "0x1873BC020")]
			private static quaternion POODHIGFJAF(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x73BA8B0", Offset = "0x73B9AB0", VA = "0x1873BA8B0")]
			private static CHNNPJCIGPE IIOOJHHFPAM(PointSrcData point)
			{
				return default(CHNNPJCIGPE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x73BA820", Offset = "0x73B9A20", VA = "0x1873BA820")]
			private static CHNNPJCIGPE IIOOJHHFPAM(float3 pos, quaternion rot, float radius)
			{
				return default(CHNNPJCIGPE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x73BBE30", Offset = "0x73BB030", VA = "0x1873BBE30")]
			private static bool NMBDEDMOFOD(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x73BBF50", Offset = "0x73BB150", VA = "0x1873BBF50")]
			private static float3 PHKABNLMMEK(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x73BA9D0", Offset = "0x73B9BD0", VA = "0x1873BA9D0")]
			public static float3 JBFMAHANCDG(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x73BA1D0", Offset = "0x73B93D0", VA = "0x1873BA1D0")]
			public static float3 GADIJJMFOAG(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x73B86B0", Offset = "0x73B78B0", VA = "0x1873B86B0")]
			private static quaternion CHIHLPGLJFC(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x73B84D0", Offset = "0x73B76D0", VA = "0x1873B84D0")]
			private static float BHDLHNFLACJ(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x73C7750", Offset = "0x73C6950", VA = "0x1873C7750")]
			private void LOKOCOBDHAE(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x73C7660", Offset = "0x73C6860", VA = "0x1873C7660", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public NativeList<CHNNPJCIGPE> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x73C9530", Offset = "0x73C8730", VA = "0x1873C9530")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x73C9520", Offset = "0x73C8720", VA = "0x1873C9520", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NativeList<CHNNPJCIGPE> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x73C94D0", Offset = "0x73C86D0", VA = "0x1873C94D0")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x73C94C0", Offset = "0x73C86C0", VA = "0x1873C94C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public NativeList<DPJIGCGLIOC> data;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x73B7F30", Offset = "0x73B7130", VA = "0x1873B7F30")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x73B7F20", Offset = "0x73B7120", VA = "0x1873B7F20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherSplinesAndUniqueParents_Job : IJob
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
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NativeList<FCLIOCDNHNC> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public NativeList<DGHFHOMOCBD> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x73B8100", Offset = "0x73B7300", VA = "0x1873B8100")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x73B80F0", Offset = "0x73B72F0", VA = "0x1873B80F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x73C90A0", Offset = "0x73C82A0", VA = "0x1873C90A0")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x73C9090", Offset = "0x73C8290", VA = "0x1873C9090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private JFKCAAABPDJ replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private EKHABGHIANL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GAPFIPDNAFD bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private BCPONCIHDCA ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x73C71F0", Offset = "0x73C63F0", VA = "0x1873C71F0", Slot = "15")]
		public override void InitReferences(DMNOAHHBJOJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x73C8890", Offset = "0x73C7A90", VA = "0x1873C8890", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x73C8980", Offset = "0x73C7B80", VA = "0x1873C8980", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x73C89E0", Offset = "0x73C7BE0", VA = "0x1873C89E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x73C6940", Offset = "0x73C5B40", VA = "0x1873C6940")]
		private JobHandle FAHJGMPAFHB(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x73C7830", Offset = "0x73C6A30", VA = "0x1873C7830")]
		private JobHandle MHILBKEKCCF(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x73C6800", Offset = "0x73C5A00", VA = "0x1873C6800")]
		private JobHandle JGHALBGIIBC(NativeArray<int> pointCount, NativeList<CHNNPJCIGPE> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x73C68A0", Offset = "0x73C5AA0", VA = "0x1873C68A0")]
		private JobHandle IJAMBGBCFHK(NativeList<CHNNPJCIGPE> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x73C81B0", Offset = "0x73C73B0", VA = "0x1873C81B0")]
		private JobHandle MLBOCBGNKKB(EntityQuery query, NativeList<FCLIOCDNHNC> splinePointRanges, NativeList<CHNNPJCIGPE> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73C72D0", Offset = "0x73C64D0", VA = "0x1873C72D0")]
		private JobHandle KEJCGKPKOMJ(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x73C6200", Offset = "0x73C5400", VA = "0x1873C6200")]
		private JobHandle CJIBGBHEJOB(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x73C73F0", Offset = "0x73C65F0", VA = "0x1873C73F0")]
		private JobHandle KFCMKILCOMO(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<DPJIGCGLIOC> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x73C6F30", Offset = "0x73C6130", VA = "0x1873C6F30")]
		private JobHandle HEIJODCGJJM(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<FCLIOCDNHNC> splinePointRanges, [Out] NativeList<DGHFHOMOCBD> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x73C6C40", Offset = "0x73C5E40", VA = "0x1873C6C40")]
		private JobHandle GJIDAHEOLEP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x73C62F0", Offset = "0x73C54F0", VA = "0x1873C62F0")]
		private JobHandle CLDPDCIBCMK(EntityQuery query, NativeList<DPJIGCGLIOC> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x73C8AF0", Offset = "0x73C7CF0", VA = "0x1873C8AF0")]
		private static NativeParallelHashMap<int, BGAPCNLHHPL> PFFMDDGICOI()
		{
			return default(NativeParallelHashMap<int, BGAPCNLHHPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x73C5F50", Offset = "0x73C5150", VA = "0x1873C5F50")]
		private JobHandle BBIPIKINBHO(EntityQuery query, NativeList<FCLIOCDNHNC> splinePointRanges, NativeList<CHNNPJCIGPE> splinePointData, NativeList<DGHFHOMOCBD> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x73C6E50", Offset = "0x73C6050", VA = "0x1873C6E50")]
		private JobHandle GLNMPENILED(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x73C6800", Offset = "0x73C5A00", VA = "0x1873C6800")]
		private JobHandle CMDJPGMDKBC(NativeArray<int> pointCount, NativeList<CHNNPJCIGPE> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x73C68A0", Offset = "0x73C5AA0", VA = "0x1873C68A0")]
		private JobHandle DEOKKIFLKAP(NativeList<CHNNPJCIGPE> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x73C8F10", Offset = "0x73C8110", VA = "0x1873C8F10")]
		private JobHandle POKLIAJFMGJ(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<DPJIGCGLIOC> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x73C80A0", Offset = "0x73C72A0", VA = "0x1873C80A0")]
		private JobHandle MKPFEKMODAO(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<FCLIOCDNHNC> ranges, NativeList<DGHFHOMOCBD> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x73C5E00", Offset = "0x73C5000", VA = "0x1873C5E00")]
		private JobHandle BACKKNADLCM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x73C8680", Offset = "0x73C7880", VA = "0x1873C8680", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class BPLKBNPMDEJ : CGIKCMPOGCF, AFDHOICPIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public GAPFIPDNAFD ILAOGMGDPKE;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x73AB2A0", Offset = "0x73AA4A0", VA = "0x1873AB2A0", Slot = "14")]
	public void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x73AB2F0", Offset = "0x73AA4F0", VA = "0x1873AB2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public BPLKBNPMDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class GEIPKADBPBN : ICKEALEHHBN, AFDHOICPIPH
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct FAADGPAKCGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private EntityManager ACAAJNNIMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private CNMBGNBPEPB<T> EAFLMLPMBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int CPLNODNGKGB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x42CF8C0", Offset = "0x42CEAC0", VA = "0x1842CF8C0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x42CFB20", Offset = "0x42CED20", VA = "0x1842CFB20")]
		public FAADGPAKCGO(EntityManager ACAAJNNIMJL, CNMBGNBPEPB<T> EAFLMLPMBIP, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1550", Offset = "0x3FF0750", VA = "0x183FF1550")]
		public FAADGPAKCGO<T> EMKBHPPGLAN()
		{
			return default(FAADGPAKCGO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x42CF020", Offset = "0x42CE220", VA = "0x1842CF020")]
		public bool ACEFONMJBCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly KJMCEDJMPPA MFBIMFCNFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private HBJOEILPNHI MBEBFJBAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private GAPFIPDNAFD ILAOGMGDPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private global::CEDCPDDIJOG GIDEHNJKJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int DMAHIFGONJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private string EJJNLCAKDOF;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x73B4830", Offset = "0x73B3A30", VA = "0x1873B4830", Slot = "15")]
	public override void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x73B3B80", Offset = "0x73B2D80", VA = "0x1873B3B80")]
	public void GAHNCEAGCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x73B4F90", Offset = "0x73B4190", VA = "0x1873B4F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x73B23A0", Offset = "0x73B15A0", VA = "0x1873B23A0")]
	private void EONEDAOIIIG(MOOGPMOENJP CBCJFCINKPJ, Mesh[] BCGDIBMJAOD, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x32574B0", Offset = "0x32566B0", VA = "0x1832574B0")]
	private FAADGPAKCGO<T> AOHGOJMFGOH<T>(CNMBGNBPEPB<T> EAFLMLPMBIP, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN) where T : struct
	{
		return default(FAADGPAKCGO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x73B3400", Offset = "0x73B2600", VA = "0x1873B3400")]
	private void FJEJGMEEJEC(Transform DBEHKFODEEL, NativeArray<JJDFGJMPHLJ> LIGHCNDOAND, CMGBCFKNNNB<GameObject> KFJLAMLHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x73B1940", Offset = "0x73B0B40", VA = "0x1873B1940")]
	private void BMFACBJAJGC(Transform DBEHKFODEEL, NativeArray<FJNCLOBMMNA> NKLOOMGNMLP, CMGBCFKNNNB<GameObject> KFJLAMLHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x73B3790", Offset = "0x73B2990", VA = "0x1873B3790")]
	private void GABEIBJDCIF(Transform DBEHKFODEEL, NativeArray<NNHDDFIGNHI> DDEAKGOLBDF, CMGBCFKNNNB<GameObject> KFJLAMLHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x73B4A40", Offset = "0x73B3C40", VA = "0x1873B4A40")]
	private void KCKIDECBEGN(Transform DBEHKFODEEL, NativeArray<HBPMHMGJPNO> BCGDIBMJAOD, Mesh[] KKBEKMGHBMJ, CMGBCFKNNNB<GameObject> KFJLAMLHKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x73B4E40", Offset = "0x73B4040", VA = "0x1873B4E40")]
	private static void NEAOKDCEGAC(NativeParallelHashSet<Entity> NNDJLDGDLBA, NativeParallelHashSet<Entity> MEIDLKNNJCB, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x73B3BF0", Offset = "0x73B2DF0", VA = "0x1873B3BF0")]
	private static void GBIIAGIODNI(NativeList<Entity> AFNGOKKOBOC, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x73B3CB0", Offset = "0x73B2EB0", VA = "0x1873B3CB0")]
	private NativeParallelHashMap<Entity, JFELCGGGAID> HAAJOCNLLIL(GAPFIPDNAFD.BHMEMPAANLI NDGIJHONDIN, JICJDAJNLHP<PGAEGHNFIIL> IPAHDBFJJNH, NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN, List<GameObject> KFJLAMLHKKI)
	{
		return default(NativeParallelHashMap<Entity, JFELCGGGAID>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x73B1E00", Offset = "0x73B1000", VA = "0x1873B1E00")]
	private void BNGNKFBFIOM(NativeList<Entity> KINLKBHLAPI, NativeList<Entity> BOIPEHOKLGC, NativeParallelHashMap<Entity, JFELCGGGAID> IHKJCKKKKDK, NativeList<FCLIOCDNHNC> AFPALOAMHDA, NativeList<CHNNPJCIGPE> ANGJDJHGKOD, NativeList<DGHFHOMOCBD> PKLMOLCEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x73B1520", Offset = "0x73B0720", VA = "0x1873B1520")]
	private void BGDJCHIJENK(NativeList<Entity> NNDJLDGDLBA, NativeList<Entity> HODGBONNOFH, NativeParallelHashMap<Entity, JFELCGGGAID> IHKJCKKKKDK, NativeList<DPJIGCGLIOC> MBNMLLMNLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	public GEIPKADBPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class DFBPIFAECFG : DODPMJEPHJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly UniformTRS BBADKBNANFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly JGGGIHBIMPC DBEHKFODEEL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject EFCGPNPGPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS IEKCACFBDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x73AEBA0", Offset = "0x73ADDA0", VA = "0x1873AEBA0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 KIBOBPNMCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x73AEE10", Offset = "0x73AE010", VA = "0x1873AEE10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 MJJKODGIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x73AED20", Offset = "0x73ADF20", VA = "0x1873AED20", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 IODMOHLFPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x73AEB50", Offset = "0x73ADD50", VA = "0x1873AEB50", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x73AED70", Offset = "0x73ADF70", VA = "0x1873AED70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion NIJJODMMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x73AEDC0", Offset = "0x73ADFC0", VA = "0x1873AEDC0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x73AEC80", Offset = "0x73ADE80", VA = "0x1873AEC80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 DNMMPDADEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x73AECD0", Offset = "0x73ADED0", VA = "0x1873AECD0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 ADNDBKAFPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x73AEE60", Offset = "0x73AE060", VA = "0x1873AEE60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 HIPPFGPGNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x73AEB00", Offset = "0x73ADD00", VA = "0x1873AEB00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x73AEEB0", Offset = "0x73AE0B0", VA = "0x1873AEEB0")]
	public DFBPIFAECFG(UniformTRS BBADKBNANFF, JGGGIHBIMPC DBEHKFODEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class LCGCCJFLBDO : DFBPIFAECFG, FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly float GEEPLGPHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float3 GGPMBPBMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly HOLOGFIEFDN FLANOGIBFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DIABBMOAIAG HHABDDPJBPD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private HLDKLCEAPAJ KOLBPKDKGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x73BF490", Offset = "0x73BE690", VA = "0x1873BF490", Slot = "17")]
		get
		{
			return default(HLDKLCEAPAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS FFFKAPNDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x73BF3B0", Offset = "0x73BE5B0", VA = "0x1873BF3B0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float NDIMLCFFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xAA2CD0", Offset = "0xAA1ED0", VA = "0x180AA2CD0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 AKAPBCNKGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x73BF360", Offset = "0x73BE560", VA = "0x1873BF360", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HOLOGFIEFDN DNMCHKAPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEF50", Offset = "0xCDE150", VA = "0x180CDEF50", Slot = "21")]
		get
		{
			return default(HOLOGFIEFDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private DIABBMOAIAG NMNKCOFMPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1156410", Offset = "0x1155610", VA = "0x181156410", Slot = "22")]
		get
		{
			return default(DIABBMOAIAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool JOADPPBAIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EEAJIDDKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x73BF4E0", Offset = "0x73BE6E0", VA = "0x1873BF4E0")]
	protected LCGCCJFLBDO(UniformTRS BBADKBNANFF, JGGGIHBIMPC DBEHKFODEEL, float GEEPLGPHMLO, float3 GGPMBPBMGHE, HOLOGFIEFDN FLANOGIBFIK, DIABBMOAIAG HHABDDPJBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class CCJCKJOHKBI : DODPMJEPHJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly CIBKNFGEPGP MMGDIFNEOOE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected JGGGIHBIMPC COLLFNBHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xF75D00", Offset = "0xF74F00", VA = "0x180F75D00")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity HMEPBLPCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x73ABD40", Offset = "0x73AAF40", VA = "0x1873ABD40")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected EKHABGHIANL HPKADIGEOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x73AC190", Offset = "0x73AB390", VA = "0x1873AC190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected BBPKOKGMLME BANBHEAECAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x73AC130", Offset = "0x73AB330", VA = "0x1873AC130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected BGCIOADNHMO GNIJDIPKIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x73ABB80", Offset = "0x73AAD80", VA = "0x1873ABB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject EFCGPNPGPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x73ABD60", Offset = "0x73AAF60", VA = "0x1873ABD60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS IEKCACFBDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xFAD1D0", Offset = "0xFAC3D0", VA = "0x180FAD1D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 KIBOBPNMCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x73AC3C0", Offset = "0x73AB5C0", VA = "0x1873AC3C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 MJJKODGIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73ABFB0", Offset = "0x73AB1B0", VA = "0x1873ABFB0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 IODMOHLFPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x73ABC10", Offset = "0x73AAE10", VA = "0x1873ABC10", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x73AC1A0", Offset = "0x73AB3A0", VA = "0x1873AC1A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion NIJJODMMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x73AC2A0", Offset = "0x73AB4A0", VA = "0x1873AC2A0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x73ABD90", Offset = "0x73AAF90", VA = "0x1873ABD90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 DNMMPDADEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x73ABE90", Offset = "0x73AB090", VA = "0x1873ABE90", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 ADNDBKAFPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x73AC4B0", Offset = "0x73AB6B0", VA = "0x1873AC4B0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 HIPPFGPGNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x73AB9C0", Offset = "0x73AABC0", VA = "0x1873AB9C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0xC88790", Offset = "0xC87990", VA = "0x180C88790")]
	protected CCJCKJOHKBI(CIBKNFGEPGP OFNKJKFNBEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x73ABF80", Offset = "0x73AB180", VA = "0x1873ABF80")]
	public static HLDKLCEAPAJ KEDBNOKLEHE(CCJCKJOHKBI EBJDGDIMGBD)
	{
		return default(HLDKLCEAPAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PGMMJLGJCDD
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x73C37D0", Offset = "0x73C29D0", VA = "0x1873C37D0")]
	public static void MPBPFFGEJBB(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class IPJGGBJPNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x73BD730", Offset = "0x73BC930", VA = "0x1873BD730")]
	public static void DMLKOLIFCJD(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL, ELNPEFEPDJC DCJKANEPNFE, EKHABGHIANL HHGPPDCIJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x73BDE60", Offset = "0x73BD060", VA = "0x1873BDE60")]
	public static void JKGGHBJIDMJ(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL, ELNPEFEPDJC DCJKANEPNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x73BDBB0", Offset = "0x73BCDB0", VA = "0x1873BDBB0")]
	public static NativeList<Entity> GEFCMEJAFJI(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x73BD6F0", Offset = "0x73BC8F0", VA = "0x1873BD6F0")]
	public static NativeList<Entity> BBIPCPOAHDM(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x73BDBF0", Offset = "0x73BCDF0", VA = "0x1873BDBF0")]
	private static NativeList<Entity> GEFCMEJAFJI(NativeArray<Entity> NNDJLDGDLBA, EntityManager ACAAJNNIMJL, bool PDBPHANHHLM)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class PCGKGNPILGM : CCJCKJOHKBI, FDIGCKFAKMF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float GEEPLGPHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Vector3 GGPMBPBMGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private HOLOGFIEFDN FLANOGIBFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private DIABBMOAIAG HHABDDPJBPD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager AGJILKLBNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x73C3390", Offset = "0x73C2590", VA = "0x1873C3390")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EEPABMPJIMJ AJMAHBOENMM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x73C3450", Offset = "0x73C2650", VA = "0x1873C3450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData CJDHHGONEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x73C34E0", Offset = "0x73C26E0", VA = "0x1873C34E0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private HLDKLCEAPAJ KOLBPKDKGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x73ABF80", Offset = "0x73AB180", VA = "0x1873ABF80", Slot = "17")]
		get
		{
			return default(HLDKLCEAPAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float NDIMLCFFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xD59F40", Offset = "0xD59140", VA = "0x180D59F40", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 AKAPBCNKGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x1391A30", Offset = "0x1390C30", VA = "0x181391A30", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HOLOGFIEFDN DNMCHKAPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470", Slot = "21")]
		get
		{
			return default(HOLOGFIEFDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private DIABBMOAIAG NMNKCOFMPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xB29E30", Offset = "0xB29030", VA = "0x180B29E30", Slot = "22")]
		get
		{
			return default(DIABBMOAIAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS FFFKAPNDCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xFAD1D0", Offset = "0xFAC3D0", VA = "0x180FAD1D0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool EEAJIDDKMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x920F50", Offset = "0x920150", VA = "0x180920F50", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x920CD0", Offset = "0x91FED0", VA = "0x180920CD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool JOADPPBAIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x73C3700", Offset = "0x73C2900", VA = "0x1873C3700")]
	protected PCGKGNPILGM(CIBKNFGEPGP OFNKJKFNBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x73C3570", Offset = "0x73C2770", VA = "0x1873C3570", Slot = "26")]
	public virtual void MEIPIBBEBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class ICKEALEHHBN : CGIKCMPOGCF, AFDHOICPIPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected EKHABGHIANL HHGPPDCIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private GCLGCHJKJOB DNIPNOKEENP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected ELNPEFEPDJC CEBOGOEKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x73BD650", Offset = "0x73BC850", VA = "0x1873BD650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected AOFAIHBKPNG GDGMCIKKOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x73BD6A0", Offset = "0x73BC8A0", VA = "0x1873BD6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x73BD5E0", Offset = "0x73BC7E0", VA = "0x1873BD5E0", Slot = "15")]
	public virtual void InitReferences(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
	protected ICKEALEHHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NHKLCMCLCAJ
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x73C0BD0", Offset = "0x73BFDD0", VA = "0x1873C0BD0")]
	public static void HEPJHAHKHMG(NativeArray<Entity> KINLKBHLAPI, EntityManager ACAAJNNIMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1779746012
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x73C9F00", Offset = "0x73C9100", VA = "0x1873C9F00")]
	public static void NDFJCLOCNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x73C9EF0", Offset = "0x73C90F0", VA = "0x1873C9EF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class AHPPGPGNKMB : ContainerPropertyBag<OJGBAFAKGFB>
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x73CA180", Offset = "0x73C9380", VA = "0x1873CA180")]
	public AHPPGPGNKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class IBEMEKJOHHF : ContainerPropertyBag<OBIBHJIIPNM>
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x73CA240", Offset = "0x73C9440", VA = "0x1873CA240")]
	public IBEMEKJOHHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class CDALIMCMEDN : ContainerPropertyBag<EFEMJLFMFHF>
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x73CA1E0", Offset = "0x73C93E0", VA = "0x1873CA1E0")]
	public CDALIMCMEDN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x73CA2A0", Offset = "0x73C94A0", VA = "0x1873CA2A0")]
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
