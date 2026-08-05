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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x870AB40", Offset = "0x8709540", VA = "0x18870AB40", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86BB110", Offset = "0x86B9B10", VA = "0x1886BB110", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87130C0", Offset = "0x8711AC0", VA = "0x1887130C0")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8713650", Offset = "0x8712050", VA = "0x188713650", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87136B0", Offset = "0x87120B0", VA = "0x1887136B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DCGPPNOFADB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86F7610", Offset = "0x86F6010", VA = "0x1886F7610")]
	public static Quaternion DOAKLHHIIPJ([In] this OFDIKDELHCL GFBDACMLDEP, [In] Vector3 HLNPPHJBENM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NCIHPIHJMDD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x870C000", Offset = "0x870AA00", VA = "0x18870C000")]
	public static bool EJMJFPCLBFN(this GGCKKLHEAHJ KIFPCOAPDIF, DHMONCPGFAD MAFBHNHEGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x870BFD0", Offset = "0x870A9D0", VA = "0x18870BFD0")]
	public static bool AJIAGMNOJGL(this GGCKKLHEAHJ KIFPCOAPDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x870D130", Offset = "0x870BB30", VA = "0x18870D130")]
	public static bool NAHAJMHINNI(this GGCKKLHEAHJ KIFPCOAPDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x870D000", Offset = "0x870BA00", VA = "0x18870D000")]
	public static void MBHACHHGHCJ(this GGCKKLHEAHJ KIFPCOAPDIF, Vector3 NFCBKLDMAHK, Quaternion OIHMNHLJBII, float JBOIDCJHBGG, bool BDOEPACEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x870D840", Offset = "0x870C240", VA = "0x18870D840")]
	public static void OGACCBNKFDK(this GGCKKLHEAHJ KIFPCOAPDIF, Vector3 NFCBKLDMAHK, Quaternion OIHMNHLJBII, float JBOIDCJHBGG, int EMDEJKHMJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x870C150", Offset = "0x870AB50", VA = "0x18870C150")]
	public static void GALIJFFFKFK(this GGCKKLHEAHJ KIFPCOAPDIF, int EMDEJKHMJLL, Vector3 NFCBKLDMAHK, Quaternion OIHMNHLJBII, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x870CDF0", Offset = "0x870B7F0", VA = "0x18870CDF0")]
	public static void JJDLFCAOJEM(this GGCKKLHEAHJ KIFPCOAPDIF, Vector3 CGCHKOJJIPF, Quaternion NONNOOBDPBD, float JBOIDCJHBGG, bool BDOEPACEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x870C490", Offset = "0x870AE90", VA = "0x18870C490")]
	private static void JFLBJHABIKD(this GGCKKLHEAHJ KIFPCOAPDIF, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG, bool BDOEPACEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x870CE40", Offset = "0x870B840", VA = "0x18870CE40")]
	private static void KEMKAHFPLOP(this GGCKKLHEAHJ KIFPCOAPDIF, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON, float GKNFKPBFDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x870D160", Offset = "0x870BB60", VA = "0x18870D160")]
	private static void NGPBNOFEKPG(this GGCKKLHEAHJ KIFPCOAPDIF, int KABGMIEBEFC, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON, float GKNFKPBFDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x870DAD0", Offset = "0x870C4D0", VA = "0x18870DAD0")]
	private static bool POCIKIMAIJL(this GGCKKLHEAHJ KIFPCOAPDIF, int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x870BD30", Offset = "0x870A730", VA = "0x18870BD30")]
	private static void ADLOHHIBPMB(this GGCKKLHEAHJ KIFPCOAPDIF, int KABGMIEBEFC, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON, float GKNFKPBFDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x870D350", Offset = "0x870BD50", VA = "0x18870D350")]
	public static Vector3 NICLNDKIPOD(this GGCKKLHEAHJ KIFPCOAPDIF, int KABGMIEBEFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x870C040", Offset = "0x870AA40", VA = "0x18870C040")]
	public static Quaternion FLILAKHJAFA(this GGCKKLHEAHJ KIFPCOAPDIF, int KABGMIEBEFC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x870C270", Offset = "0x870AC70", VA = "0x18870C270")]
	public static Vector3 IOIJENLLDJK(DHMONCPGFAD JHBIAAAGFJK, Vector3 KFJFDPLEJOD, Vector3? FHPIOIJOIGB, Vector3 DBJDIOFCCBJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface KBJAHNAHBFP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODGJCPLNACM(EntityQuery AGDKAEIBGFC, EntityManager NCBHJFGCEMJ, PFBPGMHMPKE FDFGEPPACCC, KOKFIFDKFHI EJEAOAIOFOD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface FHIAHLGIMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DPOMALEMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKMBAFJJLBK(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DANFFNACLPG(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMIONEKJNGN(ONEMHINNGHH EAIEJMBCLCO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OIIJIJCAGCO : KBJAHNAHBFP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x870E580", Offset = "0x870CF80", VA = "0x18870E580", Slot = "4")]
	public void ODGJCPLNACM(EntityQuery AGDKAEIBGFC, EntityManager NCBHJFGCEMJ, PFBPGMHMPKE FDFGEPPACCC, KOKFIFDKFHI EJEAOAIOFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public OIIJIJCAGCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class LJGLCMGKGEE : KBJAHNAHBFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKEGDKKKDKI EPGEKJPNEHG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
	public LJGLCMGKGEE(IKEGDKKKDKI EPGEKJPNEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8709A10", Offset = "0x8708410", VA = "0x188709A10", Slot = "4")]
	public void ODGJCPLNACM(EntityQuery AGDKAEIBGFC, EntityManager NCBHJFGCEMJ, PFBPGMHMPKE FDFGEPPACCC, KOKFIFDKFHI EJEAOAIOFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class HNEDFMOPNJE : KBJAHNAHBFP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8707BF0", Offset = "0x87065F0", VA = "0x188707BF0", Slot = "4")]
	public void ODGJCPLNACM(EntityQuery AGDKAEIBGFC, EntityManager NCBHJFGCEMJ, PFBPGMHMPKE FDFGEPPACCC, KOKFIFDKFHI EJEAOAIOFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HNEDFMOPNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class POHMOOGFPGI : FHIAHLGIMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DPOMALEMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x870F240", Offset = "0x870DC40", VA = "0x18870F240", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x870EFC0", Offset = "0x870D9C0", VA = "0x18870EFC0", Slot = "5")]
	public void AKMBAFJJLBK(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x870F270", Offset = "0x870DC70", VA = "0x18870F270", Slot = "6")]
	public void DANFFNACLPG(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x870F4F0", Offset = "0x870DEF0", VA = "0x18870F4F0", Slot = "7")]
	public void NMIONEKJNGN(ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public POHMOOGFPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BMIOPPOJGAK : FHIAHLGIMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DPOMALEMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86F3DB0", Offset = "0x86F27B0", VA = "0x1886F3DB0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86F3B30", Offset = "0x86F2530", VA = "0x1886F3B30", Slot = "5")]
	public void AKMBAFJJLBK(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86F3DE0", Offset = "0x86F27E0", VA = "0x1886F3DE0", Slot = "6")]
	public void DANFFNACLPG(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86F4060", Offset = "0x86F2A60", VA = "0x1886F4060", Slot = "7")]
	public void NMIONEKJNGN(ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BMIOPPOJGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class INEMAPHIENE : FHIAHLGIMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DPOMALEMMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8708540", Offset = "0x8706F40", VA = "0x188708540", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x87082C0", Offset = "0x8706CC0", VA = "0x1887082C0", Slot = "5")]
	public void AKMBAFJJLBK(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8708570", Offset = "0x8706F70", VA = "0x188708570", Slot = "6")]
	public void DANFFNACLPG(EntityQuery AGDKAEIBGFC, ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x87087F0", Offset = "0x87071F0", VA = "0x1887087F0", Slot = "7")]
	public void NMIONEKJNGN(ONEMHINNGHH EAIEJMBCLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public INEMAPHIENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FHCCFEMNCJP : HKCCMPBPDAG, BOHILICPPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PFBPGMHMPKE FDFGEPPACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GOLJMDGEEMK NIAJEDFGHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KOKFIFDKFHI EJEAOAIOFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, KBJAHNAHBFP adapter)> NIJIFJLEIIM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86FFAF0", Offset = "0x86FE4F0", VA = "0x1886FFAF0", Slot = "15")]
	public virtual void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86FFB80", Offset = "0x86FE580", VA = "0x1886FFB80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86FF990", Offset = "0x86FE390", VA = "0x1886FF990")]
	private void AJIBAENMDCE(EntityQueryDesc PCKJIKHONCF, KBJAHNAHBFP EILKEPEHIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86FFDB0", Offset = "0x86FE7B0", VA = "0x1886FFDB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	public FHCCFEMNCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class KJANGEGEHIC : HKCCMPBPDAG, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class EKCMDKOEODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery BHJMKOJINKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery MOJJKGDPMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery LILPNFDBAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AENLGFGLJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery MFIEFAINMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery ABEIHLOEBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery IACHGLJKDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FHIAHLGIMJH BEHNLLEICID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType IFHNOCJHBGE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EKCMDKOEODC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PFBPGMHMPKE FDFGEPPACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KOKFIFDKFHI EJEAOAIOFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private GOLJMDGEEMK NIAJEDFGHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<EKCMDKOEODC> NIJIFJLEIIM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8709480", Offset = "0x8707E80", VA = "0x188709480", Slot = "14")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8709510", Offset = "0x8707F10", VA = "0x188709510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8709690", Offset = "0x8708090", VA = "0x188709690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8709030", Offset = "0x8707A30", VA = "0x188709030")]
	private void AOOOKCFBOHB(EKCMDKOEODC EHECNDGPJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8708900", Offset = "0x8707300", VA = "0x188708900")]
	private void AJIBAENMDCE(FHIAHLGIMJH BEHNLLEICID, ComponentType DFIAMNKGNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	public KJANGEGEHIC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct ICHHBCJFNPO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct NEGAECLDOAF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct NDBJIDOHEMB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(KOKFIFDKFHI), new string[] { })]
public class NMMPCLMCHCJ : KOKFIFDKFHI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KBICEEBHCID OCMAGODFDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KBICEEBHCID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NMMPCLMCHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(OHFHIMLKNEK), new string[] { })]
public class MHHPNBHHEAD : OHFHIMLKNEK, MDAFCEADLLG, DPIGDIPFEHO, MCFIHMMPFIH, AOOPFNOOKFO, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private CAIBNPNLHFH DFECKIOHELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private PFBPGMHMPKE FDFGEPPACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private LHOENBPGPCA BNOBLABHPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityQuery LJELLKHOGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EntityQuery DHKJFKJGKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool OMJJKOOLPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Entity DMECILKACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CFEOEFPPCFO EDLNCEDEEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Entity HOOPJOJFIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private CFEOEFPPCFO OECGMKONGFG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private EntityManager IKJPKHBBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x870B750", Offset = "0x870A150", VA = "0x18870B750")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NKOPNNOIDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x870B3E0", Offset = "0x8709DE0", VA = "0x18870B3E0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KDEJFHLHPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x870BA00", Offset = "0x870A400", VA = "0x18870BA00", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x870B920", Offset = "0x870A320", VA = "0x18870B920", Slot = "4")]
	public bool JLICIHFNBLM(IJNJMBEMEOM EFILDLEHGNL, CFIMNPCFKGP KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x870B490", Offset = "0x8709E90", VA = "0x18870B490", Slot = "5")]
	public CFEOEFPPCFO FGNPGGONDJL()
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x870AF40", Offset = "0x8709940", VA = "0x18870AF40", Slot = "6")]
	public CFEOEFPPCFO APBFEKHLMJM()
	{
		return default(CFEOEFPPCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x870B7A0", Offset = "0x870A1A0", VA = "0x18870B7A0", Slot = "9")]
	public void InitExternal(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x870BA20", Offset = "0x870A420", VA = "0x18870BA20", Slot = "11")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x870B200", Offset = "0x8709C00", VA = "0x18870B200", Slot = "10")]
	public void DAHLKNACIHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x870B400", Offset = "0x8709E00", VA = "0x18870B400", Slot = "12")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1394A40", Offset = "0x1393440", VA = "0x181394A40", Slot = "13")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MHHPNBHHEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(IMEHGFJJMAN), new string[] { })]
public class DDBCMFOCKMP : IMEHGFJJMAN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86F7740", Offset = "0x86F6140", VA = "0x1886F7740", Slot = "4")]
	public void GLIBEFPKNFK(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86F8080", Offset = "0x86F6A80", VA = "0x1886F8080", Slot = "5")]
	public void LLMPHDBBLDF(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x86F76F0", Offset = "0x86F60F0", VA = "0x1886F76F0", Slot = "6")]
	public ComponentSystemBase BABLLINBAPD(World DFECKIOHELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x86F77C0", Offset = "0x86F61C0", VA = "0x1886F77C0", Slot = "7")]
	public void GPNDMPFGHGF(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x86F81A0", Offset = "0x86F6BA0", VA = "0x1886F81A0", Slot = "8")]
	public void PGPOFPFONOB(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86F80D0", Offset = "0x86F6AD0", VA = "0x1886F80D0", Slot = "9")]
	public void MNHJNOCOGJL(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x86F8130", Offset = "0x86F6B30", VA = "0x1886F8130", Slot = "10")]
	public void OLEHHODEHGG(World DFECKIOHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x86F7820", Offset = "0x86F6220", VA = "0x1886F7820", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> KPPPCPFOFFG()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DDBCMFOCKMP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct JLGKDEIJFNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct KCGCHAEPDMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HECKMGEMBNC : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GIJGHJAGFLM DLDJNEOPHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x87072B0", Offset = "0x8705CB0", VA = "0x1887072B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8707240", Offset = "0x8705C40", VA = "0x188707240", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HECKMGEMBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct KPOMMIPPPPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CFEOEFPPCFO LGLBDEBFBIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static KPOMMIPPPPC HDPJNBPLGPE(CFEOEFPPCFO NOJLBGFGHBD)
	{
		return default(KPOMMIPPPPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CFNMPEHHBFC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DDAHMJKENKG JFHKGEFKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86F7060", Offset = "0x86F5A60", VA = "0x1886F7060", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CFNMPEHHBFC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct NJACDICJLNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10815538147163088675uL)]
public struct NBHLEACPPAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct COCIHGGMOHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public CJHDFOMFPMP HAMPKCBIKOO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static COCIHGGMOHK HDPJNBPLGPE(CJHDFOMFPMP NOJLBGFGHBD)
	{
		return default(COCIHGGMOHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct ICCNIBPIHMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public CFEOEFPPCFO LGLBDEBFBIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static ICCNIBPIHMB HDPJNBPLGPE(CFEOEFPPCFO NOJLBGFGHBD)
	{
		return default(ICCNIBPIHMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KAOIIJACKJM : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LJNNCBOFJHI IBDDCHIOMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x87088B0", Offset = "0x87072B0", VA = "0x1887088B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8708840", Offset = "0x8707240", VA = "0x188708840", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KAOIIJACKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IEGMOOAPLKC : JMJPJIJNPAA, GIJGHJAGFLM, PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FNINIENCAIO MPMCKFMCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(FNINIENCAIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EJJHKJLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD8A650", Offset = "0xD89050", VA = "0x180D8A650", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float3 LFNJKADNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x12C41A0", Offset = "0x12C2BA0", VA = "0x1812C41A0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8707D90", Offset = "0x8706790", VA = "0x188707D90")]
	public IEGMOOAPLKC(UniformTRS FEHHCKMNPGM, ADKOMDJMHFH AEMEEJKFKNN, float CMEKBCKEHIJ, float3 GFOGBBKOHLG, FIHNPCHPOKM BDOKDACGANB, MFJKGLKLLDL IHOFFFHLMAH, FNINIENCAIO IJCDBPJLAGN, float3 JBHNOBCPJPM, bool DLCOEANEMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8707D30", Offset = "0x8706730", VA = "0x188707D30", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DPMLDLPAAIL : JMJPJIJNPAA, LJNNCBOFJHI, PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<CMNLAHEDKFC> FLBODJDICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly NPAKLJFDNNC PDCLAJMPOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly float KBFJHOCLJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly int LLINFAPFHDL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AJIAIJCINPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x86F8370", Offset = "0x86F6D70", VA = "0x1886F8370", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LBLBPFNEEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86F8390", Offset = "0x86F6D90", VA = "0x1886F8390", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JCJIBOHEMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86F8380", Offset = "0x86F6D80", VA = "0x1886F8380", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HJDMGPJHJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xC57850", Offset = "0xC56250", VA = "0x180C57850", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float AHFJMDBKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE33CF0", Offset = "0xE326F0", VA = "0x180E33CF0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LLFIDMJMMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE40D50", Offset = "0xE3F750", VA = "0x180E40D50", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86F82D0", Offset = "0x86F6CD0", VA = "0x1886F82D0")]
	public DPMLDLPAAIL(UniformTRS FEHHCKMNPGM, ADKOMDJMHFH AEMEEJKFKNN, float CMEKBCKEHIJ, float3 GFOGBBKOHLG, FIHNPCHPOKM BDOKDACGANB, MFJKGLKLLDL IHOFFFHLMAH, NPAKLJFDNNC PDCLAJMPOEB, float KBFJHOCLJML, int LLINFAPFHDL, NativeArray<CMNLAHEDKFC> FLBODJDICMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x12DB4D0", Offset = "0x12D9ED0", VA = "0x1812DB4D0", Slot = "33")]
	public NativeArray<CMNLAHEDKFC> GetNativeCurvePoints()
	{
		return default(NativeArray<CMNLAHEDKFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86F8200", Offset = "0x86F6C00", VA = "0x1886F8200", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EGBHKNIEBKI : EMDKHADJODP, GIJGHJAGFLM, PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static readonly Dictionary<BMLHKENOJFK, FNINIENCAIO> PBMKOJNDMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private FNINIENCAIO IJCDBPJLAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private bool DLCOEANEMAO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private FNINIENCAIO PFEBMAAFHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0", Slot = "28")]
		get
		{
			return default(FNINIENCAIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool DBNOPEBMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xFEB810", Offset = "0xFEA210", VA = "0x180FEB810", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 LFNJKADNJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86FDB00", Offset = "0x86FC500", VA = "0x1886FDB00", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x86FDAE0", Offset = "0x86FC4E0", VA = "0x1886FDAE0")]
	public EGBHKNIEBKI(IJNJMBEMEOM JGHKDIDNBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86FD450", Offset = "0x86FBE50", VA = "0x1886FD450", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86FD4A0", Offset = "0x86FBEA0", VA = "0x1886FD4A0", Slot = "26")]
	public override void DBIPLKHEHMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OADHCELOHLC : LPPGECPOAJG, DDAHMJKENKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GameObject KFODFBLFEEO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GameObject DKIONLOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x870DE60", Offset = "0x870C860", VA = "0x18870DE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ALEFPCAPAGF AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x870E1D0", Offset = "0x870CBD0", VA = "0x18870E1D0", Slot = "15")]
		get
		{
			return default(ALEFPCAPAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MELJJFJMJGA EJJFPPGMBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x870E420", Offset = "0x870CE20", VA = "0x18870E420", Slot = "16")]
		get
		{
			return default(MELJJFJMJGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x870E2D0", Offset = "0x870CCD0", VA = "0x18870E2D0")]
	public OADHCELOHLC(IJNJMBEMEOM EFILDLEHGNL, bool DOLNNAHONHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x870E040", Offset = "0x870CA40", VA = "0x18870E040")]
	public void LNLLHOCMJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x870E1D0", Offset = "0x870CBD0", VA = "0x18870E1D0")]
	protected ALEFPCAPAGF PDBHLGODJNG()
	{
		return default(ALEFPCAPAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x870DEF0", Offset = "0x870C8F0", VA = "0x18870DEF0")]
	private static bool LEFCHKIEDEH(IJNJMBEMEOM NPIOFDGBDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x870DE30", Offset = "0x870C830", VA = "0x18870DE30", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HFHKADBHNHF : EMDKHADJODP, LJNNCBOFJHI, PPILPOLDBAI, IDisposable, MDKBNFJPNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeList<CMNLAHEDKFC> FLBODJDICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool AHKFEICEABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool BLNNPMILKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private float KBFJHOCLJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int LLINFAPFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool GJGPBPCPOFC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool OILALCDPFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CFFMDOIJEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF9EF0", Offset = "0xAF88F0", VA = "0x180AF9EF0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private float GOJDHBJBJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xF562B0", Offset = "0xF54CB0", VA = "0x180F562B0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int AMAGAIHPGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xECFBA0", Offset = "0xECE5A0", VA = "0x180ECFBA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool DJPDJMNFKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xD8A650", Offset = "0xD89050", VA = "0x180D8A650", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private int KMIEIHMHMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8707300", Offset = "0x8705D00", VA = "0x188707300", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int GOPFMPDJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8707640", Offset = "0x8706040", VA = "0x188707640", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8707BC0", Offset = "0x87065C0", VA = "0x188707BC0")]
	public HFHKADBHNHF(IJNJMBEMEOM JGHKDIDNBJI, [Optional] NativeList<CMNLAHEDKFC> FLBODJDICMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8707500", Offset = "0x8705F00", VA = "0x188707500", Slot = "26")]
	public override void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8707410", Offset = "0x8705E10", VA = "0x188707410", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x87075E0", Offset = "0x8705FE0", VA = "0x1887075E0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8707320", Offset = "0x8705D20", VA = "0x188707320")]
	public void BLHLLIHLBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8707720", Offset = "0x8706120", VA = "0x188707720", Slot = "34")]
	public NativeArray<CMNLAHEDKFC> GetNativeCurvePoints()
	{
		return default(NativeArray<CMNLAHEDKFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x87078F0", Offset = "0x87062F0", VA = "0x1887078F0", Slot = "35")]
	private Vector3 IGKDEFBEFDN(int HBDKIKFKCEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8707380", Offset = "0x8705D80", VA = "0x188707380", Slot = "36")]
	private Quaternion BNFPLPICAPD(int HBDKIKFKCEE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8707A30", Offset = "0x8706430", VA = "0x188707A30", Slot = "37")]
	private float PLIHCBHPJNE(int HBDKIKFKCEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x87073B0", Offset = "0x8705DB0", VA = "0x1887073B0")]
	private NativeArray<Entity> BOJJEHJHNIN()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class IJLPAIMDLKA : BCCAAHPEAAD
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8707E30", Offset = "0x8706830", VA = "0x188707E30", Slot = "15")]
	protected override ComponentSystemBase BNBPMJNCDIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x87082A0", Offset = "0x8706CA0", VA = "0x1887082A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x87082B0", Offset = "0x8706CB0", VA = "0x1887082B0")]
	public IJLPAIMDLKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EAJFOPCBLPM]
public sealed class LKHOIFBCBCN : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery JLDJBNKFNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery IPDFKDFNCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery NDEJNDGBGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery MFPNBOPBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EntityQuery KCALIGHEAID;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x870A320", Offset = "0x8708D20", VA = "0x18870A320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x870A680", Offset = "0x8709080", VA = "0x18870A680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8709FE0", Offset = "0x87089E0", VA = "0x188709FE0")]
	private void FPKNGJDIJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x870A1C0", Offset = "0x8708BC0", VA = "0x18870A1C0")]
	private void IHGDHJIOICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8709D10", Offset = "0x8708710", VA = "0x188709D10")]
	private void EHCANGFINKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8709B60", Offset = "0x8708560", VA = "0x188709B60")]
	private void CEIIEEAIKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8709EE0", Offset = "0x87088E0", VA = "0x188709EE0")]
	private void FOFGGBMJAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8709CC0", Offset = "0x87086C0", VA = "0x188709CC0")]
	private NativeList<Entity> DIMKEHCAPBN(NativeArray<Entity> BKFKEKMLADJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x870A2D0", Offset = "0x8708CD0", VA = "0x18870A2D0")]
	private NativeList<Entity> NECOKCCAEOL(NativeArray<Entity> BKFKEKMLADJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8709C60", Offset = "0x8708660", VA = "0x188709C60")]
	private void DEIABLECKGK(NativeArray<Entity> BKFKEKMLADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public LKHOIFBCBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[EAJFOPCBLPM]
public sealed class GAACNKDGJJH : CABEBJFCPPE, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery APDIHLBMPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery CMEFANLBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery LILPNFDBAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private OHFHIMLKNEK IOOCJEAENFE;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x87016B0", Offset = "0x87000B0", VA = "0x1887016B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8700C00", Offset = "0x86FF600", VA = "0x188700C00", Slot = "15")]
	public override void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8701880", Offset = "0x8700280", VA = "0x188701880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x87008E0", Offset = "0x86FF2E0", VA = "0x1887008E0")]
	private void CPJDINKNAGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x87001B0", Offset = "0x86FEBB0", VA = "0x1887001B0")]
	private void CBNJOIOHKFE(NativeParallelHashSet<CFEOEFPPCFO> OBABGFIGEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8700C60", Offset = "0x86FF660", VA = "0x188700C60")]
	private void LJCCNJKJLNB(NativeParallelHashSet<CFEOEFPPCFO> OBABGFIGEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x87012F0", Offset = "0x86FFCF0", VA = "0x1887012F0")]
	private void MKACLIKLOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8700840", Offset = "0x86FF240", VA = "0x188700840")]
	private bool CFCLIHHDICK(Entity BDOCGCBPBOC, [Out] CFEOEFPPCFO LGLBDEBFBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x86FFFA0", Offset = "0x86FE9A0", VA = "0x1886FFFA0")]
	internal bool BBEHANEOMIJ(Entity BDOCGCBPBOC, [Out] CFEOEFPPCFO LGLBDEBFBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public GAACNKDGJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[EAJFOPCBLPM]
public sealed class GDPONNOMAID : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery FKHOKOPFJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery CNKDOAEHFJK;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8701F90", Offset = "0x8700990", VA = "0x188701F90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x87020E0", Offset = "0x8700AE0", VA = "0x1887020E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x87019A0", Offset = "0x87003A0", VA = "0x1887019A0")]
	private void CBNJOIOHKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8701CA0", Offset = "0x87006A0", VA = "0x188701CA0")]
	private void LJCCNJKJLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public GDPONNOMAID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FAAPLHLLDHC : CABEBJFCPPE, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[BurstCompile]
	private struct APMPJIGOEAC : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob ALDNIAAOEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EntityQueryInJob MFFCPLPPHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EntityQueryInJob FCLDMKLNIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EntityQueryInJob FCIHKLMKLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ReadOnly]
		public EntityTypeHandle LOKJILHMPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public ComponentTypeHandle<ICCNIBPIHMB> BKJDHIHJMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeList<Entity> PHHDGDGIPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> DHHAOPNNLEK;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x86F39D0", Offset = "0x86F23D0", VA = "0x1886F39D0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86F3A50", Offset = "0x86F2450", VA = "0x1886F3A50")]
		private void NFIALNAICBA(EntityQueryInJob AGDKAEIBGFC, NativeList<Entity> PBBHHBECPKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct MJDHNNPDDIF : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle LOKJILHMPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<ICCNIBPIHMB> BKJDHIHJMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeList<Entity> PBBHHBECPKJ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x870BA60", Offset = "0x870A460", VA = "0x18870BA60", Slot = "4")]
		public void Execute(ArchetypeChunk MLHCKIFOBHF, int KHOMLKMHPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery ALDNIAAOEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private EntityQuery MFFCPLPPHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private EntityQuery FCLDMKLNIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private EntityQuery FCIHKLMKLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private EntityQuery JEIMJFCHFOF;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x86FF1A0", Offset = "0x86FDBA0", VA = "0x1886FF1A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x86FF5E0", Offset = "0x86FDFE0", VA = "0x1886FF5E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x86FED10", Offset = "0x86FD710", VA = "0x1886FED10")]
	private void DMAJBHLJIDL(NativeParallelHashSet<CFEOEFPPCFO> OBABGFIGEND, int BEGPBCEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x86FEE10", Offset = "0x86FD810", VA = "0x1886FEE10")]
	private void NJONCOGOIFH(NativeParallelHashSet<CFEOEFPPCFO> OBABGFIGEND, int OKABOPINAPG, int HOJCIPOJODF, int JBIBHKKMMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public FAAPLHLLDHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BNFOJGDJOBK : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[BurstCompile]
	private struct GKHBHJBNLJL : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[ReadOnly]
		public EntityTypeHandle LOKJILHMPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> AAJHJFMKELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[ReadOnly]
		public ComponentTypeHandle<COCIHGGMOHK> IHGFABDPNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public ComponentDataFromEntity<KPOMMIPPPPC> GHAKEPJCPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		public ComponentDataFromEntity<global::BFLLMACBEEP> AECLIJJABLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ComponentTypeHandle<ICCNIBPIHMB> ELHKJCMNKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeList<Entity> HJNDEOODMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<COCIHGGMOHK> IKIKNOGOANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<CFEOEFPPCFO> LBCOPICEPAA;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8702190", Offset = "0x8700B90", VA = "0x188702190", Slot = "4")]
		public void Execute(ArchetypeChunk MLHCKIFOBHF, int KHOMLKMHPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private EntityQuery JDEBAOPMIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private EntityQuery NIKJGGODJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private EntityQuery IKGFIBAHPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private EntityQuery MLKHHCENFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private EntityQuery OCFCEKGDIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private OHFHIMLKNEK GFDGECDDENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private GAACNKDGJJH PCMEJHGEJBA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x86F57D0", Offset = "0x86F41D0", VA = "0x1886F57D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86F4EE0", Offset = "0x86F38E0", VA = "0x1886F4EE0", Slot = "15")]
	public override void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86F5BC0", Offset = "0x86F45C0", VA = "0x1886F5BC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x86F4260", Offset = "0x86F2C60", VA = "0x1886F4260")]
	private void HNGAGPFIJNO(NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH, int HNKFGBMEKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86F5F20", Offset = "0x86F4920", VA = "0x1886F5F20")]
	private void PCFELNAEKDM(NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH, int KBHEBEAFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86F53A0", Offset = "0x86F3DA0", VA = "0x1886F53A0")]
	private void OIJLAAECCCB(NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH, int JDPBEPKGKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86F4F40", Offset = "0x86F3940", VA = "0x1886F4F40")]
	private void MLONPDCOBJF(NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH, int PLBMHIONIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86F49F0", Offset = "0x86F33F0", VA = "0x1886F49F0")]
	private void IKHCJNDJPPL(NativeParallelHashSet<CFEOEFPPCFO> PBBKDEEIMOH, int OMFPMJNECMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x86F40B0", Offset = "0x86F2AB0", VA = "0x1886F40B0")]
	private void DGIMBHJLHAM(Entity FOONMMGIHBF, CJHDFOMFPMP PDGKECALBHK, CFEOEFPPCFO LGLBDEBFBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public BNFOJGDJOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class OPDNMOHJFCB : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery PFCGDNMIACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EntityQuery LNPPCIMNFIJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x870E800", Offset = "0x870D200", VA = "0x18870E800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x870EA30", Offset = "0x870D430", VA = "0x18870EA30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public OPDNMOHJFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HAFLJABKILD : CABEBJFCPPE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct HMJLMNKPCCJ : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private EntityQuery ILGCCNJFLFM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8706ED0", Offset = "0x87058D0", VA = "0x188706ED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8707010", Offset = "0x8705A10", VA = "0x188707010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public HAFLJABKILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EAJFOPCBLPM]
internal class CDOOEBBGEII : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class BMCDJBPFEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EntityQuery KLFIINKPGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EntityQuery GNFDDEDOGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DNKMOGCIJCG PLKOILCIHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ComponentType NPMHDMFFFDO;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BMCDJBPFEGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private delegate void DNKMOGCIJCG(NativeArray<CJHDFOMFPMP> NOJLBGFGHBD, ONEMHINNGHH EAIEJMBCLCO);

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<BMCDJBPFEGI> NIJIFJLEIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private GOLJMDGEEMK NIAJEDFGHAB;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x86F65A0", Offset = "0x86F4FA0", VA = "0x1886F65A0", Slot = "15")]
	public override void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x86F6940", Offset = "0x86F5340", VA = "0x1886F6940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x86F6AD0", Offset = "0x86F54D0", VA = "0x1886F6AD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B87B40", Offset = "0x3B86540", VA = "0x183B87B40")]
	private void AJIBAENMDCE<T>(DNKMOGCIJCG PLKOILCIHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x86F67A0", Offset = "0x86F51A0", VA = "0x1886F67A0")]
	private static void OIDHMIEDOOG(NativeArray<CJHDFOMFPMP> AEBBDAOLLLI, ONEMHINNGHH LMJLKLMDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x86F6400", Offset = "0x86F4E00", VA = "0x1886F6400")]
	private static void HPBGCADECLK(NativeArray<CJHDFOMFPMP> AEBBDAOLLLI, ONEMHINNGHH LMJLKLMDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x86F6600", Offset = "0x86F5000", VA = "0x1886F6600")]
	private static void NBIEBOLKEKM(NativeArray<CJHDFOMFPMP> AEBBDAOLLLI, ONEMHINNGHH LMJLKLMDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public CDOOEBBGEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[EAJFOPCBLPM]
public sealed class DPOIKPNGBEP : CABEBJFCPPE
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityQuery AGDKAEIBGFC;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x86F83A0", Offset = "0x86F6DA0", VA = "0x1886F83A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KAEOBILDCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public UniformTRS FEHHCKMNPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public StandardRenderableVisualData EGEMJGDKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public FNINIENCAIO IJCDBPJLAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 JBHNOBCPJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool DLCOEANEMAO;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DJLNGIHGBKC(Lifetime.LoadInstance)]
public struct MKACIFDMOCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity LDEJAMJEHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeList<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeList<Entity> INPLEBDDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeParallelHashSet<Entity> JDFPLPLACFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeList<KAEOBILDCHO> DIMEHPPBEEI;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x870BCA0", Offset = "0x870A6A0", VA = "0x18870BCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(EJCFKMNPBIL), new string[] { })]
internal class EJCFKMNPBIL : BOHILICPPOJ, AOOPFNOOKFO, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct CIKLCCGBICG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly EJCFKMNPBIL AEMEEJKFKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly bool PCHCMDNBJHH;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B11FE0", Offset = "0x1B109E0", VA = "0x181B11FE0")]
		public CIKLCCGBICG(EJCFKMNPBIL AEMEEJKFKNN, bool PCHCMDNBJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x86F7410", Offset = "0x86F5E10", VA = "0x1886F7410")]
		public Queue<LGOFDOAKAPB>.Enumerator FIIFAFDLDFC()
		{
			return default(Queue<LGOFDOAKAPB>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86F70D0", Offset = "0x86F5AD0", VA = "0x1886F70D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[DependsOn]
	private LHOENBPGPCA ENEJEIEPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[DependsOn]
	private IFDKOPJOMNB DGBMGCMELAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private List<NativeList<CMNLAHEDKFC>> KILHJMFKJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private List<(Entity, List<GameObject>)> LIKELOPDJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<CJHDFOMFPMP> MGLDAEDDFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private CJKNMGDPHMM<LGOFDOAKAPB> ECOEGPKNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CJKNMGDPHMM<MKACIFDMOCB> GJODHHDGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private CJKNMGDPHMM<OINNGLAKOGA> JNFDNOGLLOP;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x86FE5D0", Offset = "0x86FCFD0", VA = "0x1886FE5D0", Slot = "4")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x86FE240", Offset = "0x86FCC40", VA = "0x1886FE240")]
	public void CJLGODIJNEM(NativeList<CMNLAHEDKFC> EKCIGFBAOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x86FE7D0", Offset = "0x86FD1D0", VA = "0x1886FE7D0")]
	public void KILAJLDEAEN(Entity AEMEEJKFKNN, [In] FMJHIDPKFMF<GameObject> PHLBFLBCIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x86FDD00", Offset = "0x86FC700", VA = "0x1886FDD00")]
	public void BINLOLGGHDA(NativeList<CJHDFOMFPMP> AEBBDAOLLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x86FE970", Offset = "0x86FD370", VA = "0x1886FE970")]
	public void MNHJNOCOGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x86FDD90", Offset = "0x86FC790", VA = "0x1886FDD90")]
	public void BNNIMLKFPIH(JOGKHOGLCCH KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x86FDC60", Offset = "0x86FC660", VA = "0x1886FDC60")]
	public JobHandle BHOAIGLBKIM([In] LGOFDOAKAPB JEBOHIALEMJ, JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x86FDBC0", Offset = "0x86FC5C0", VA = "0x1886FDBC0")]
	public JobHandle BHOAIGLBKIM([In] MKACIFDMOCB JEBOHIALEMJ, JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8375EB0", Offset = "0x83748B0", VA = "0x188375EB0")]
	public CIKLCCGBICG PMOJDCOIDDB(bool PCHCMDNBJHH)
	{
		return default(CIKLCCGBICG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x86FE580", Offset = "0x86FCF80", VA = "0x1886FE580")]
	public PHHFFPOKAGL<MKACIFDMOCB> HCMGKFAOBJE()
	{
		return default(PHHFFPOKAGL<MKACIFDMOCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86FE920", Offset = "0x86FD320", VA = "0x1886FE920")]
	public PHHFFPOKAGL<OINNGLAKOGA> KPHIFDFJJKC()
	{
		return default(PHHFFPOKAGL<OINNGLAKOGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x86FE360", Offset = "0x86FCD60", VA = "0x1886FE360")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x86FEBA0", Offset = "0x86FD5A0", VA = "0x1886FEBA0", Slot = "5")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x86FE2F0", Offset = "0x86FCCF0", VA = "0x1886FE2F0", Slot = "6")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1041A60", Offset = "0x1040460", VA = "0x181041A60", Slot = "7")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EJCFKMNPBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct OGKMGMKLJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public UniformTRS FEHHCKMNPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public StandardRenderableVisualData EGEMJGDKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public MGPOLIAHKGI PDCLAJMPOEB;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DJLNGIHGBKC(Lifetime.LoadInstance)]
public struct LGOFDOAKAPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity LDEJAMJEHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<Entity> INPLEBDDOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeParallelHashSet<Entity> JDFPLPLACFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeList<JDHBPJJENDI> OKJJCICOBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<CMNLAHEDKFC> EKCIGFBAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeList<OGKMGMKLJJL> IGFMFENOOPF;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8709930", Offset = "0x8708330", VA = "0x188709930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8709940", Offset = "0x8708340", VA = "0x188709940")]
	public void OKCDDGFOJCM(bool PCHCMDNBJHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterService(typeof(GBGBJKOFMCH), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class GBGBJKOFMCH : NIPGEDOBAJA, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[DependsOn]
	private EJCFKMNPBIL GMNJEOEEFGD;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8701980", Offset = "0x8700380", VA = "0x188701980", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8701930", Offset = "0x8700330", VA = "0x188701930", Slot = "5")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1366D10", Offset = "0x1365710", VA = "0x181366D10", Slot = "6")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GBGBJKOFMCH()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : CABEBJFCPPE, BOHILICPPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeParallelHashMap<int, FNINIENCAIO> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NativeArray<KAEOBILDCHO> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x87024B0", Offset = "0x8700EB0", VA = "0x1887024B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public NativeArray<CMNLAHEDKFC> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[ReadOnly]
			public NativeArray<JDHBPJJENDI> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<OGKMGMKLJJL> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8702850", Offset = "0x8701250", VA = "0x188702850", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x86F74D0", Offset = "0x86F5ED0", VA = "0x1886F74D0", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0x870F540", Offset = "0x870DF40", VA = "0x18870F540")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0x870F560", Offset = "0x870DF60", VA = "0x18870F560")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 LAKHJLLIADM(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x870A750", Offset = "0x8709150", VA = "0x18870A750", Slot = "5")]
				public float3 JGLHBIHBBED(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0x870AB00", Offset = "0x8709500", VA = "0x18870AB00", Slot = "4")]
				public float3 LAKHJLLIADM(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x870DB00", Offset = "0x870C500", VA = "0x18870DB00", Slot = "4")]
				public float3 LAKHJLLIADM(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public NativeArray<JDHBPJJENDI> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public NativeArray<CMNLAHEDKFC> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8704640", Offset = "0x8703040", VA = "0x188704640", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8704C60", Offset = "0x8703660", VA = "0x188704C60")]
			private void FMMJJPIDKOH(NativeList<PointSrcData> srcData, NativeList<CMNLAHEDKFC> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8706400", Offset = "0x8704E00", VA = "0x188706400")]
			public static Vector3 OCOEODBHEKK(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8705EE0", Offset = "0x87048E0", VA = "0x188705EE0")]
			public static quaternion IDGKMEJKGAN(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x87031B0", Offset = "0x8701BB0", VA = "0x1887031B0")]
			private static quaternion ALKICKNMDFK(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8706C70", Offset = "0x8705670", VA = "0x188706C70")]
			private static float3 PKGAOJLLAID(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8703120", Offset = "0x8701B20", VA = "0x188703120")]
			private static quaternion ABLPCMGHMJC(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x87043D0", Offset = "0x8702DD0", VA = "0x1887043D0")]
			private static CMNLAHEDKFC EIFJDMHDNCI(int idx, NativeList<PointSrcData> srcData)
			{
				return default(CMNLAHEDKFC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x44BF610", Offset = "0x44BE010", VA = "0x1844BF610")]
			private void KAIPCGLLIGN<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x87035C0", Offset = "0x8701FC0", VA = "0x1887035C0")]
			private void DDDLDDNNDMJ(NativeList<PointSrcData> sourcePoints, NativeList<CMNLAHEDKFC> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x87061E0", Offset = "0x8704BE0", VA = "0x1887061E0")]
			public static float JLFANJMBFIH(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8705CF0", Offset = "0x87046F0", VA = "0x188705CF0")]
			private static quaternion FPHNJCNPBJH(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8702F70", Offset = "0x8701970", VA = "0x188702F70")]
			private static CMNLAHEDKFC ABKEKPJLDBL(PointSrcData point)
			{
				return default(CMNLAHEDKFC);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8703090", Offset = "0x8701A90", VA = "0x188703090")]
			private static CMNLAHEDKFC ABKEKPJLDBL(float3 pos, quaternion rot, float radius)
			{
				return default(CMNLAHEDKFC);
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8706360", Offset = "0x8704D60", VA = "0x188706360")]
			private static bool LHAEMPMIDKF(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8705F60", Offset = "0x8704960", VA = "0x188705F60")]
			private static float3 IINIKOAMAFB(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8705B40", Offset = "0x8704540", VA = "0x188705B40")]
			public static float3 FOIJFBKEPGP(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8706030", Offset = "0x8704A30", VA = "0x188706030")]
			public static float3 JGLHBIHBBED(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8706810", Offset = "0x8705210", VA = "0x188706810")]
			private static quaternion PJNONNHPFNA(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x87033E0", Offset = "0x8701DE0", VA = "0x1887033E0")]
			private static float CDLNHICFMFN(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8711D70", Offset = "0x8710770", VA = "0x188711D70")]
			private void NLOALEBKNOG(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8711C80", Offset = "0x8710680", VA = "0x188711C80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeList<CMNLAHEDKFC> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8712F80", Offset = "0x8711980", VA = "0x188712F80")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8712F70", Offset = "0x8711970", VA = "0x188712F70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeList<CMNLAHEDKFC> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8712F20", Offset = "0x8711920", VA = "0x188712F20")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8712F10", Offset = "0x8711910", VA = "0x188712F10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public NativeList<KAEOBILDCHO> data;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8702BA0", Offset = "0x87015A0", VA = "0x188702BA0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8702B90", Offset = "0x8701590", VA = "0x188702B90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public NativeList<JDHBPJJENDI> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public NativeList<OGKMGMKLJJL> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8702D70", Offset = "0x8701770", VA = "0x188702D70")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8702D60", Offset = "0x8701760", VA = "0x188702D60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8712AF0", Offset = "0x87114F0", VA = "0x188712AF0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8712AE0", Offset = "0x87114E0", VA = "0x188712AE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HDGDPOGCGDG replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private LHOENBPGPCA objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private EJCFKMNPBIL bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EJOECFCAELD ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8711710", Offset = "0x8710110", VA = "0x188711710", Slot = "15")]
		public override void InitReferences(BDGILPFNAIO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8712790", Offset = "0x8711190", VA = "0x188712790", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8712880", Offset = "0x8711280", VA = "0x188712880", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x87128E0", Offset = "0x87112E0", VA = "0x1887128E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x870F5B0", Offset = "0x870DFB0", VA = "0x18870F5B0")]
		private JobHandle ACKGBGKNFMH(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8711050", Offset = "0x870FA50", VA = "0x188711050")]
		private JobHandle GDKLACFDFFG(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x870FAC0", Offset = "0x870E4C0", VA = "0x18870FAC0")]
		private JobHandle PJEPFKACMML(NativeArray<int> pointCount, NativeList<CMNLAHEDKFC> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x870F900", Offset = "0x870E300", VA = "0x18870F900")]
		private JobHandle BGICOPOABAE(NativeList<CMNLAHEDKFC> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x87117B0", Offset = "0x87101B0", VA = "0x1887117B0")]
		private JobHandle KEMJFEEKKJD(EntityQuery query, NativeList<JDHBPJJENDI> splinePointRanges, NativeList<CMNLAHEDKFC> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x87105B0", Offset = "0x870EFB0", VA = "0x1887105B0")]
		private JobHandle EEAJCBLGAIP(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x870F9A0", Offset = "0x870E3A0", VA = "0x18870F9A0")]
		private JobHandle BGOJMHKEAKG(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x870FE10", Offset = "0x870E810", VA = "0x18870FE10")]
		private JobHandle CNPOJJOIMJH(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<KAEOBILDCHO> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn, Allocator allocator = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x870FB60", Offset = "0x870E560", VA = "0x18870FB60")]
		private JobHandle CNMMEFHFHLP(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JDHBPJJENDI> splinePointRanges, [Out] NativeList<OGKMGMKLJJL> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn, Allocator allocator = Allocator.TempJob)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8710CD0", Offset = "0x870F6D0", VA = "0x188710CD0")]
		private JobHandle FIBLECIINLJ(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x87106D0", Offset = "0x870F0D0", VA = "0x1887106D0")]
		private JobHandle EJDIAOKHJCC(EntityQuery query, NativeList<KAEOBILDCHO> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x87100B0", Offset = "0x870EAB0", VA = "0x1887100B0")]
		private static NativeParallelHashMap<int, FNINIENCAIO> DKAJPKBEIBN()
		{
			return default(NativeParallelHashMap<int, FNINIENCAIO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8711FA0", Offset = "0x87109A0", VA = "0x188711FA0")]
		private JobHandle MNELBOBIDMA(EntityQuery query, NativeList<JDHBPJJENDI> splinePointRanges, NativeList<CMNLAHEDKFC> splinePointData, NativeList<OGKMGMKLJJL> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x87104D0", Offset = "0x870EED0", VA = "0x1887104D0")]
		private JobHandle ECIIHGPPKON(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x870FAC0", Offset = "0x870E4C0", VA = "0x18870FAC0")]
		private JobHandle BPLGOLFMKND(NativeArray<int> pointCount, NativeList<CMNLAHEDKFC> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x870F900", Offset = "0x870E300", VA = "0x18870F900")]
		private JobHandle JOPBJHFOCNC(NativeList<CMNLAHEDKFC> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8710BE0", Offset = "0x870F5E0", VA = "0x188710BE0")]
		private JobHandle FFKGOANMBIC(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<KAEOBILDCHO> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8712340", Offset = "0x8710D40", VA = "0x188712340")]
		private JobHandle OGAEMJNBMLE(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JDHBPJJENDI> ranges, NativeList<OGKMGMKLJJL> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8711E50", Offset = "0x8710850", VA = "0x188711E50")]
		private JobHandle MJHJIAJKEPK(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8712450", Offset = "0x8710E50", VA = "0x188712450", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OJBGBGNLNOP : HKCCMPBPDAG, BOHILICPPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EJCFKMNPBIL GMNJEOEEFGD;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x870E790", Offset = "0x870D190", VA = "0x18870E790", Slot = "14")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x870E7E0", Offset = "0x870D1E0", VA = "0x18870E7E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	public OJBGBGNLNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class EAFKGMANHBN : CABEBJFCPPE, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct BPMCJGABKNF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private EntityManager NCBHJFGCEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AFFIJHNGHCG<T> IIEPPANKIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int KABGMIEBEFC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x685C160", Offset = "0x685AB60", VA = "0x18685C160")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x685C9D0", Offset = "0x685B3D0", VA = "0x18685C9D0")]
		public BPMCJGABKNF(EntityManager NCBHJFGCEMJ, AFFIJHNGHCG<T> IIEPPANKIKK, NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4BE82A0", Offset = "0x4BE6CA0", VA = "0x184BE82A0")]
		public BPMCJGABKNF<T> FIIFAFDLDFC()
		{
			return default(BPMCJGABKNF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x685C8B0", Offset = "0x685B2B0", VA = "0x18685C8B0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly OLFEOKKCIEG GOLBNOPHKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IFDKOPJOMNB DGBMGCMELAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private EJCFKMNPBIL GMNJEOEEFGD;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x86FA1E0", Offset = "0x86F8BE0", VA = "0x1886FA1E0", Slot = "15")]
	public override void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB010", Offset = "0x86F9A10", VA = "0x1886FB010")]
	public void OLEHHODEHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x86FB040", Offset = "0x86F9A40", VA = "0x1886FB040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x86FC270", Offset = "0x86FAC70", VA = "0x1886FC270")]
	private void PLGMKOHGDMA(OINNGLAKOGA JEBOHIALEMJ, Mesh[] PIHGOJDOLKM, NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB8C0", Offset = "0x3BFA2C0", VA = "0x183BFB8C0")]
	private BPMCJGABKNF<T> EDLBFLKADAL<T>(AFFIJHNGHCG<T> IIEPPANKIKK, NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG) where T : struct
	{
		return default(BPMCJGABKNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x86FAC80", Offset = "0x86F9680", VA = "0x1886FAC80")]
	private void OJFHAPFDHIK(Transform AEMEEJKFKNN, NativeArray<KFNEIKMNOFB> ALKKOHMLKNC, FMJHIDPKFMF<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x86FA260", Offset = "0x86F8C60", VA = "0x1886FA260")]
	private void JAFFKCHNPMJ(Transform AEMEEJKFKNN, NativeArray<IHPFMEDJNLM> KNANOGANCMK, FMJHIDPKFMF<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x86F9350", Offset = "0x86F7D50", VA = "0x1886F9350")]
	private void GBKBHHICMGD(Transform AEMEEJKFKNN, NativeArray<EJEONIBKONE> GPGGFGHMHGP, FMJHIDPKFMF<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x86F9730", Offset = "0x86F8130", VA = "0x1886F9730")]
	private void GOODPLDOEOD(Transform AEMEEJKFKNN, NativeArray<JFGGFFPPNAE> PIHGOJDOLKM, Mesh[] BMPHOICBPDF, FMJHIDPKFMF<GameObject> PKEHFPOLHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x86FA720", Offset = "0x86F9120", VA = "0x1886FA720")]
	private static void KAKOACOHGCH(NativeParallelHashSet<Entity> BKFKEKMLADJ, NativeParallelHashSet<Entity> PBKAJOMGNDK, NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x86FC1B0", Offset = "0x86FABB0", VA = "0x1886FC1B0")]
	private static void PFHMGOHBPKK(NativeList<Entity> GBEHGKLEJFE, NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x86F87F0", Offset = "0x86F71F0", VA = "0x1886F87F0")]
	private NativeParallelHashMap<Entity, KPOMMIPPPPC> BENMBMGDKME(EJCFKMNPBIL.CIKLCCGBICG FMOOHGGEBCK, PHHFFPOKAGL<MKACIFDMOCB> BMPOMOBFKEI, List<GameObject> PKEHFPOLHDA)
	{
		return default(NativeParallelHashMap<Entity, KPOMMIPPPPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x86F9B60", Offset = "0x86F8560", VA = "0x1886F9B60")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> ILHJFEMILAP(Entity LCEJLOMBIKB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x86F9C60", Offset = "0x86F8660", VA = "0x1886F9C60")]
	private void IMPFFMLFFOC(NativeList<Entity> LMGOJDKAHMH, NativeList<Entity> MIPBAIKBMFO, NativeParallelHashMap<Entity, KPOMMIPPPPC> OAFLOIGNJIA, NativeList<JDHBPJJENDI> BEHJPPJJALH, NativeList<CMNLAHEDKFC> APAKPMICBGM, NativeList<OGKMGMKLJJL> KILHJMFKJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x86FA870", Offset = "0x86F9270", VA = "0x1886FA870")]
	private void MDEICHLDBLP(NativeList<Entity> BKFKEKMLADJ, NativeList<Entity> INPLEBDDOIB, NativeParallelHashMap<Entity, KPOMMIPPPPC> OAFLOIGNJIA, NativeList<KAEOBILDCHO> DIMEHPPBEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x30CF3F0", Offset = "0x30CDDF0", VA = "0x1830CF3F0")]
	public EAFKGMANHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class IPFEGKCDPOK : LJABLNFNGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly UniformTRS FEHHCKMNPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ADKOMDJMHFH AEMEEJKFKNN;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GameObject AEMMJFACMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public UniformTRS KDNINACCBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8714A90", Offset = "0x8713490", VA = "0x188714A90", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Vector3 LNKIPILGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87148B0", Offset = "0x87132B0", VA = "0x1887148B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Matrix4x4 MHFAKHODCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8714950", Offset = "0x8713350", VA = "0x188714950", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 EIDPHFIAIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x87149F0", Offset = "0x87133F0", VA = "0x1887149F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8714A40", Offset = "0x8713440", VA = "0x188714A40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Quaternion NKGCBJEFHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8714900", Offset = "0x8713300", VA = "0x188714900", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8714BC0", Offset = "0x87135C0", VA = "0x188714BC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private Vector3 NBKNJGIPABE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x87149A0", Offset = "0x87133A0", VA = "0x1887149A0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Vector3 IEKKFJCABHK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8714B70", Offset = "0x8713570", VA = "0x188714B70", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 HPBBDCKEIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8714860", Offset = "0x8713260", VA = "0x188714860", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8714C10", Offset = "0x8713610", VA = "0x188714C10")]
	public IPFEGKCDPOK(UniformTRS FEHHCKMNPGM, ADKOMDJMHFH AEMEEJKFKNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class JMJPJIJNPAA : IPFEGKCDPOK, PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float CMEKBCKEHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float3 GFOGBBKOHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly FIHNPCHPOKM BDOKDACGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly MFJKGLKLLDL IHOFFFHLMAH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private ALEFPCAPAGF OFJJJLCMOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8714DF0", Offset = "0x87137F0", VA = "0x188714DF0", Slot = "17")]
		get
		{
			return default(ALEFPCAPAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private UniformTRS OPNMCEMJMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8714CC0", Offset = "0x87136C0", VA = "0x188714CC0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private float ACLMMCGNBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAFF3B0", Offset = "0xAFDDB0", VA = "0x180AFF3B0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private Vector3 JFODNCBCDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8714DA0", Offset = "0x87137A0", VA = "0x188714DA0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private FIHNPCHPOKM LGDBCEIFPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xB2F870", Offset = "0xB2E270", VA = "0x180B2F870", Slot = "21")]
		get
		{
			return default(FIHNPCHPOKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MFJKGLKLLDL BEFKONHEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1538210", Offset = "0x1536C10", VA = "0x181538210", Slot = "22")]
		get
		{
			return default(MFJKGLKLLDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool ONAIFIELJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GAHDCPCODAN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8714E40", Offset = "0x8713840", VA = "0x188714E40")]
	protected JMJPJIJNPAA(UniformTRS FEHHCKMNPGM, ADKOMDJMHFH AEMEEJKFKNN, float CMEKBCKEHIJ, float3 GFOGBBKOHLG, FIHNPCHPOKM BDOKDACGANB, MFJKGLKLLDL IHOFFFHLMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class LPPGECPOAJG : LJABLNFNGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	protected readonly IJNJMBEMEOM KKGNPJDBLLP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected ADKOMDJMHFH NACEDJEFALG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x135A590", Offset = "0x1358F90", VA = "0x18135A590")]
		get
		{
			return default(ADKOMDJMHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected Entity AODCGFIELJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8715920", Offset = "0x8714320", VA = "0x188715920")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected LHOENBPGPCA DIBEEIFKJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8715DB0", Offset = "0x87147B0", VA = "0x188715DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected DJAJCMGGCAM CLPKKNLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8715DC0", Offset = "0x87147C0", VA = "0x188715DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	protected DOOPGKEPAJL MLFNOGDCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8715E20", Offset = "0x8714820", VA = "0x188715E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GameObject AEMMJFACMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8715A50", Offset = "0x8714450", VA = "0x188715A50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public UniformTRS KDNINACCBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1375230", Offset = "0x1373C30", VA = "0x181375230", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Vector3 LNKIPILGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8715380", Offset = "0x8713D80", VA = "0x188715380", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Matrix4x4 MHFAKHODCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8715590", Offset = "0x8713F90", VA = "0x188715590", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 EIDPHFIAIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x87157F0", Offset = "0x87141F0", VA = "0x1887157F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8715940", Offset = "0x8714340", VA = "0x188715940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Quaternion NKGCBJEFHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8715470", Offset = "0x8713E70", VA = "0x188715470", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8715CA0", Offset = "0x87146A0", VA = "0x188715CA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector3 NBKNJGIPABE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8715700", Offset = "0x8714100", VA = "0x188715700", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector3 IEKKFJCABHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8715A80", Offset = "0x8714480", VA = "0x188715A80", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector3 HPBBDCKEIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8715160", Offset = "0x8713B60", VA = "0x188715160", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xF9A070", Offset = "0xF98A70", VA = "0x180F9A070")]
	protected LPPGECPOAJG(IJNJMBEMEOM JGHKDIDNBJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8713DF0", Offset = "0x87127F0", VA = "0x188713DF0")]
	public static ALEFPCAPAGF HDPJNBPLGPE(LPPGECPOAJG GGMLEPFJHKP)
	{
		return default(ALEFPCAPAGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PNPCCDFMFIM
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x8715EB0", Offset = "0x87148B0", VA = "0x188715EB0")]
	public static void LCLMGLDBANL(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GJPAOOLJODP
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x8713EA0", Offset = "0x87128A0", VA = "0x188713EA0")]
	public static void EAPACMNMDJI(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ, JOGKHOGLCCH CILNMHMMPPM, LHOENBPGPCA BNOBLABHPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x87142B0", Offset = "0x8712CB0", VA = "0x1887142B0")]
	public static void IBBENBACEPM(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ, JOGKHOGLCCH CILNMHMMPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x87145C0", Offset = "0x8712FC0", VA = "0x1887145C0")]
	public static NativeList<Entity> NECOKCCAEOL(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8713E60", Offset = "0x8712860", VA = "0x188713E60")]
	public static NativeList<Entity> DIMKEHCAPBN(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8714600", Offset = "0x8713000", VA = "0x188714600")]
	private static NativeList<Entity> NECOKCCAEOL(NativeArray<Entity> BKFKEKMLADJ, EntityManager NCBHJFGCEMJ, bool DPOBCEBCJJP)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class EMDKHADJODP : LPPGECPOAJG, PPILPOLDBAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float CMEKBCKEHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Vector3 GFOGBBKOHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private FIHNPCHPOKM BDOKDACGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MFJKGLKLLDL IHOFFFHLMAH;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected EntityManager IKJPKHBBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8713B70", Offset = "0x8712570", VA = "0x188713B70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected CAIBNPNLHFH CFMADAGLPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8713D60", Offset = "0x8712760", VA = "0x188713D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected ShapeConfigData CHFNBEOIEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8713C30", Offset = "0x8712630", VA = "0x188713C30")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private ALEFPCAPAGF OFJJJLCMOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8713DF0", Offset = "0x87127F0", VA = "0x188713DF0", Slot = "17")]
		get
		{
			return default(ALEFPCAPAGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private float ACLMMCGNBED
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private Vector3 JFODNCBCDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1452950", Offset = "0x1451350", VA = "0x181452950", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private FIHNPCHPOKM LGDBCEIFPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0", Slot = "21")]
		get
		{
			return default(FIHNPCHPOKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private MFJKGLKLLDL BEFKONHEEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0", Slot = "22")]
		get
		{
			return default(MFJKGLKLLDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private UniformTRS OPNMCEMJMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1375230", Offset = "0x1373C30", VA = "0x181375230", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool GAHDCPCODAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool ONAIFIELJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8713E20", Offset = "0x8712820", VA = "0x188713E20")]
	protected EMDKHADJODP(IJNJMBEMEOM JGHKDIDNBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x87139E0", Offset = "0x87123E0", VA = "0x1887139E0", Slot = "26")]
	public virtual void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class CABEBJFCPPE : HKCCMPBPDAG, BOHILICPPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	protected LHOENBPGPCA BNOBLABHPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PFBPGMHMPKE FDFGEPPACCC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected JOGKHOGLCCH EMKHJAIFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8713810", Offset = "0x8712210", VA = "0x188713810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected ONEMHINNGHH EDDHOCBKPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8713920", Offset = "0x8712320", VA = "0x188713920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected bool PGNBGBNAKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8713860", Offset = "0x8712260", VA = "0x188713860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8713970", Offset = "0x8712370", VA = "0x188713970", Slot = "15")]
	public virtual void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	protected CABEBJFCPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KIFFAILOACN
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8714EC0", Offset = "0x87138C0", VA = "0x188714EC0")]
	public static void GOGMMKDMMDM(NativeArray<Entity> LMGOJDKAHMH, EntityManager NCBHJFGCEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2358585763
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x8716630", Offset = "0x8715030", VA = "0x188716630")]
	public static void AEJPHIJJPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x87168B0", Offset = "0x87152B0", VA = "0x1887168B0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class JEAMBNOFFEN : ContainerPropertyBag<HECKMGEMBNC>
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8714C60", Offset = "0x8713660", VA = "0x188714C60")]
	public JEAMBNOFFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class LALBDHKEOFM : ContainerPropertyBag<CFNMPEHHBFC>
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8715100", Offset = "0x8713B00", VA = "0x188715100")]
	public LALBDHKEOFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class BMBPKOKHAOK : ContainerPropertyBag<KAOIIJACKJM>
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x87137B0", Offset = "0x87121B0", VA = "0x1887137B0")]
	public BMBPKOKHAOK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x87160F0", Offset = "0x8714AF0", VA = "0x1887160F0")]
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
