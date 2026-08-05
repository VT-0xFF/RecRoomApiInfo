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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F750", Offset = "0x7F4E150", VA = "0x187F4F750", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F02850", Offset = "0x7F01250", VA = "0x187F02850", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F56900", Offset = "0x7F55300", VA = "0x187F56900")]
		private void LNHKNJMKPNK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F56E90", Offset = "0x7F55890", VA = "0x187F56E90", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F56EF0", Offset = "0x7F558F0", VA = "0x187F56EF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KDJGEHHEHNP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DDC0", Offset = "0x7F4C7C0", VA = "0x187F4DDC0")]
	public static Quaternion JJLJJNCGKMC([In] this PFFPLMOBLJN IIJMPJHDMNB, [In] Vector3 HPCBBMBEKNN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EJEKJELBKFG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F42480", Offset = "0x7F40E80", VA = "0x187F42480")]
	public static bool DGHDEFEFCDI(this EOJIGNLPGOF DOOGFLKEMBP, JBJNHLKNCIO KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F43380", Offset = "0x7F41D80", VA = "0x187F43380")]
	public static bool NLPFHNIPDKJ(this EOJIGNLPGOF DOOGFLKEMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F41880", Offset = "0x7F40280", VA = "0x187F41880")]
	public static bool CCPGJNCMAEC(this EOJIGNLPGOF DOOGFLKEMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F433B0", Offset = "0x7F41DB0", VA = "0x187F433B0")]
	public static void PGMFBODFIIG(this EOJIGNLPGOF DOOGFLKEMBP, Vector3 ICAGJAOAGGC, Quaternion MIJNKMMAGGH, float BGJJMJPDNJC, bool EPKBBGMNGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F42200", Offset = "0x7F40C00", VA = "0x187F42200")]
	public static void CMPNFDDIKFL(this EOJIGNLPGOF DOOGFLKEMBP, Vector3 ICAGJAOAGGC, Quaternion MIJNKMMAGGH, float BGJJMJPDNJC, int AEHJJPLJBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F41760", Offset = "0x7F40160", VA = "0x187F41760")]
	public static void BPOKAPFBDJL(this EOJIGNLPGOF DOOGFLKEMBP, int AEHJJPLJBLK, Vector3 ICAGJAOAGGC, Quaternion MIJNKMMAGGH, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F42710", Offset = "0x7F41110", VA = "0x187F42710")]
	public static void GCEKANGABEH(this EOJIGNLPGOF DOOGFLKEMBP, Vector3 LAPHHKLOELO, Quaternion LONDEMMBNMM, float BGJJMJPDNJC, bool EPKBBGMNGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F418B0", Offset = "0x7F402B0", VA = "0x187F418B0")]
	private static void CDLKLBFOFFL(this EOJIGNLPGOF DOOGFLKEMBP, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC, bool EPKBBGMNGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F42760", Offset = "0x7F41160", VA = "0x187F42760")]
	private static void GHLKBDBCDLE(this EOJIGNLPGOF DOOGFLKEMBP, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD, float LOCFPCEGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F43090", Offset = "0x7F41A90", VA = "0x187F43090")]
	private static void JIGGAODAGBD(this EOJIGNLPGOF DOOGFLKEMBP, int MNFHMLCLFEB, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD, float LOCFPCEGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F424C0", Offset = "0x7F40EC0", VA = "0x187F424C0")]
	private static bool EABALGLCBLD(this EOJIGNLPGOF DOOGFLKEMBP, int MNFHMLCLFEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F42910", Offset = "0x7F41310", VA = "0x187F42910")]
	private static void IENEKPCFGGG(this EOJIGNLPGOF DOOGFLKEMBP, int MNFHMLCLFEB, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD, float LOCFPCEGAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F42BA0", Offset = "0x7F415A0", VA = "0x187F42BA0")]
	public static Vector3 JHKDINJOKHA(this EOJIGNLPGOF DOOGFLKEMBP, int MNFHMLCLFEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F43270", Offset = "0x7F41C70", VA = "0x187F43270")]
	public static Quaternion LDJEALGHHMF(this EOJIGNLPGOF DOOGFLKEMBP, int MNFHMLCLFEB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F424F0", Offset = "0x7F40EF0", VA = "0x187F424F0")]
	public static Vector3 FHMNMLOEFMJ(JBJNHLKNCIO FIKPCOCNDHE, Vector3 JFMEMBGKAOB, Vector3? CEPADKLPLBN, Vector3 EDNIDDDKKDE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface KKPCFIMLGPC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHJIEJNIDMF(EntityQuery HGDNMECPDPO, EntityManager CBHCEEBBPPJ, HNJPGNIHIMB MKNDHMJOBPH, FLAPFPGLJHE KKNCGMJHGKP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface PMPANIAGMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType KGBMPAACLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKAEAMBMJOG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNAGELNHEIG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKLOFBEIFMO(KCOGCHBFLDF NAHCCGHJGAG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class NCHFAHCLPDI : KKPCFIMLGPC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FB40", Offset = "0x7F4E540", VA = "0x187F4FB40", Slot = "4")]
	public void EHJIEJNIDMF(EntityQuery HGDNMECPDPO, EntityManager CBHCEEBBPPJ, HNJPGNIHIMB MKNDHMJOBPH, FLAPFPGLJHE KKNCGMJHGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public NCHFAHCLPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class BIMPANJCDIL : KKPCFIMLGPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EJEKANEOHGI HPJMJFCDFBG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
	public BIMPANJCDIL(EJEKANEOHGI HPJMJFCDFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F39090", Offset = "0x7F37A90", VA = "0x187F39090", Slot = "4")]
	public void EHJIEJNIDMF(EntityQuery HGDNMECPDPO, EntityManager CBHCEEBBPPJ, HNJPGNIHIMB MKNDHMJOBPH, FLAPFPGLJHE KKNCGMJHGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class CPPDNDJHBCF : KKPCFIMLGPC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E240", Offset = "0x7F3CC40", VA = "0x187F3E240", Slot = "4")]
	public void EHJIEJNIDMF(EntityQuery HGDNMECPDPO, EntityManager CBHCEEBBPPJ, HNJPGNIHIMB MKNDHMJOBPH, FLAPFPGLJHE KKNCGMJHGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public CPPDNDJHBCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PNPJKFAAAEA : PMPANIAGMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType KGBMPAACLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F528C0", Offset = "0x7F512C0", VA = "0x187F528C0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F52370", Offset = "0x7F50D70", VA = "0x187F52370", Slot = "5")]
	public void HKAEAMBMJOG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F525F0", Offset = "0x7F50FF0", VA = "0x187F525F0", Slot = "6")]
	public void JNAGELNHEIG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F52870", Offset = "0x7F51270", VA = "0x187F52870", Slot = "7")]
	public void MKLOFBEIFMO(KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PNPJKFAAAEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGOJKPHMBNG : PMPANIAGMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType KGBMPAACLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DD20", Offset = "0x7F4C720", VA = "0x187F4DD20", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D7D0", Offset = "0x7F4C1D0", VA = "0x187F4D7D0", Slot = "5")]
	public void HKAEAMBMJOG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DA50", Offset = "0x7F4C450", VA = "0x187F4DA50", Slot = "6")]
	public void JNAGELNHEIG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DCD0", Offset = "0x7F4C6D0", VA = "0x187F4DCD0", Slot = "7")]
	public void MKLOFBEIFMO(KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JGOJKPHMBNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IOMHHPFJDCB : PMPANIAGMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType KGBMPAACLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D6B0", Offset = "0x7F4C0B0", VA = "0x187F4D6B0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D160", Offset = "0x7F4BB60", VA = "0x187F4D160", Slot = "5")]
	public void HKAEAMBMJOG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D3E0", Offset = "0x7F4BDE0", VA = "0x187F4D3E0", Slot = "6")]
	public void JNAGELNHEIG(EntityQuery HGDNMECPDPO, KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D660", Offset = "0x7F4C060", VA = "0x187F4D660", Slot = "7")]
	public void MKLOFBEIFMO(KCOGCHBFLDF NAHCCGHJGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IOMHHPFJDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class GJGGLJINAEF : NFJLOKHFHGF, BOEGHMMFADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HNJPGNIHIMB MKNDHMJOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CCIJNJHLGOE APEBIGJNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FLAPFPGLJHE KKNCGMJHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, KKPCFIMLGPC adapter)> GIPFCGDEGPH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F469C0", Offset = "0x7F453C0", VA = "0x187F469C0", Slot = "15")]
	public virtual void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F46A50", Offset = "0x7F45450", VA = "0x187F46A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F46860", Offset = "0x7F45260", VA = "0x187F46860")]
	private void GIIEKMHOBBB(EntityQueryDesc IPCJKIPJBHL, KKPCFIMLGPC GDABKIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F46C80", Offset = "0x7F45680", VA = "0x187F46C80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
	public GJGGLJINAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class OACEFNBECAH : NFJLOKHFHGF, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class IPINDIDFHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery ADAEJDEHEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery NNGBFCGJINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery POFECKJELIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AGHPODHLNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery NPGBBGFNBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery DDLKNBHHAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery FCPAKDFANHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PMPANIAGMHG DNKBONLGDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType NFBMPBCFFEH;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IPINDIDFHID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HNJPGNIHIMB MKNDHMJOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FLAPFPGLJHE KKNCGMJHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CCIJNJHLGOE APEBIGJNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<IPINDIDFHID> GIPFCGDEGPH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F50CC0", Offset = "0x7F4F6C0", VA = "0x187F50CC0", Slot = "14")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F50D50", Offset = "0x7F4F750", VA = "0x187F50D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F50ED0", Offset = "0x7F4F8D0", VA = "0x187F50ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F500F0", Offset = "0x7F4EAF0", VA = "0x187F500F0")]
	private void CDLIAFDPMMD(IPINDIDFHID OBENIOFAPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F50540", Offset = "0x7F4EF40", VA = "0x187F50540")]
	private void GIIEKMHOBBB(PMPANIAGMHG DNKBONLGDIA, ComponentType MKGLFGKLFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
	public OACEFNBECAH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct AIGEGPMPCJL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct AAHDGLBPBED : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct AHKOPBPDCNJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(FLAPFPGLJHE), new string[] { })]
public class OIIGHEBJOAJ : FLAPFPGLJHE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LBAACCFPEFG LNFMLOJGGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LBAACCFPEFG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OIIGHEBJOAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(MGLBOPBHLHA), new string[] { })]
public class AEBHEIPLPPP : MGLBOPBHLHA, PCPOMAIKFAI, JEKAABCJIBE, HKKELALCKCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private EGLJCDJPPKL HAGIBPOACDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private HNJPGNIHIMB MKNDHMJOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private LIEJCDBGGEG CFOOPMPGJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity LCBECHGFLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private LFLLENECNAF EJOOIGCOEEP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F38360", Offset = "0x7F36D60", VA = "0x187F38360", Slot = "4")]
	public bool LFOPOLEGLJG(ENAPEPFMDAJ MBIJJAIIOHD, DMLEMIIKCOM PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F37F00", Offset = "0x7F36900", VA = "0x187F37F00", Slot = "5")]
	public LFLLENECNAF AMDCFBDOBIN()
	{
		return default(LFLLENECNAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F381C0", Offset = "0x7F36BC0", VA = "0x187F381C0", Slot = "6")]
	public void CBHKFMHLIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F382D0", Offset = "0x7F36CD0", VA = "0x187F382D0", Slot = "7")]
	private void LAICDJPNDMA(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1212740", Offset = "0x1211140", VA = "0x181212740", Slot = "8")]
	private void CBBMFAEKICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public AEBHEIPLPPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(NEOCGKLJABG), new string[] { })]
public class KKANPGDLNEK : NEOCGKLJABG
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EC90", Offset = "0x7F4D690", VA = "0x187F4EC90", Slot = "4")]
	public void LIOPPGJHEIG(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4ED10", Offset = "0x7F4D710", VA = "0x187F4ED10", Slot = "5")]
	public void LMIJAPBBBMH(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EBE0", Offset = "0x7F4D5E0", VA = "0x187F4EBE0", Slot = "6")]
	public ComponentSystemBase GABCIFCMFGO(World HAGIBPOACDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EC30", Offset = "0x7F4D630", VA = "0x187F4EC30", Slot = "7")]
	public void LIIBPMGABGN(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EB10", Offset = "0x7F4D510", VA = "0x187F4EB10", Slot = "8")]
	public void EAOJPCEGPBD(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F4ED60", Offset = "0x7F4D760", VA = "0x187F4ED60", Slot = "9")]
	public void OHFKBFNNLCB(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F4EB70", Offset = "0x7F4D570", VA = "0x187F4EB70", Slot = "10")]
	public void FMNMHHLIPKG(World HAGIBPOACDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E2E0", Offset = "0x7F4CCE0", VA = "0x187F4E2E0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> BMMEDGBMNGC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public KKANPGDLNEK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct AACCCLJDHOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct JJIEFMFDCDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DNDILHCNIOL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AELOEGAHNAG DEEIMIACFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F40FA0", Offset = "0x7F3F9A0", VA = "0x187F40FA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F40F30", Offset = "0x7F3F930", VA = "0x187F40F30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DNDILHCNIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct FLEGAJFKEPE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public LFLLENECNAF ODCLBLBHLEN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static FLEGAJFKEPE HNONLACFBHP(LFLLENECNAF GCKDJGKENJL)
	{
		return default(FLEGAJFKEPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DJGIJNFKIFP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FMGFLKNPHAK IOFAJAFBNKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E4C0", Offset = "0x7F3CEC0", VA = "0x187F3E4C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DJGIJNFKIFP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct PEGMBFABMIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct FOFFLCDBMLE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OOCANPCELJK FIHEBGFBGKP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static FOFFLCDBMLE HNONLACFBHP(OOCANPCELJK GCKDJGKENJL)
	{
		return default(FOFFLCDBMLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct IIHKBMENICN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LFLLENECNAF ODCLBLBHLEN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static IIHKBMENICN HNONLACFBHP(LFLLENECNAF GCKDJGKENJL)
	{
		return default(IIHKBMENICN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GPAALCBDFHM : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AJFNDLNEHCE GHJJNNKGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F46EE0", Offset = "0x7F458E0", VA = "0x187F46EE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F46E70", Offset = "0x7F45870", VA = "0x187F46E70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GPAALCBDFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JGGCAPLGHPA : PPHFLOMJLNA, AELOEGAHNAG, HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CMGHNAKJDFM OLGMGEHPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xDC1120", Offset = "0xDBFB20", VA = "0x180DC1120", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(CMGHNAKJDFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FLBPKEFKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC99F10", Offset = "0xC98910", VA = "0x180C99F10", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 PNKKOOCLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1135AE0", Offset = "0x11344E0", VA = "0x181135AE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D730", Offset = "0x7F4C130", VA = "0x187F4D730")]
	public JGGCAPLGHPA(UniformTRS DOJAOGOFCDN, DLOAIPKFGBA EAGGHBKHKHF, float GNGFKAPLEPB, float3 DHGHMLBENNF, AOFPBDKJHJG AIFOBKHLKPO, OCLKLGODOEL JIPHKMMDNLF, CMGHNAKJDFM FNPPAEMKOHH, float3 PGLCLCMJOKJ, bool CIKAJJOHIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D6E0", Offset = "0x7F4C0E0", VA = "0x187F4D6E0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OHPMCPKDCCH : PPHFLOMJLNA, AJFNDLNEHCE, HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<PLLACCJJPHF> KPPFGECBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly NFNDHLABKJP JKGCHKOAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float IEJMHCEOFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int NKBLHPNIMNA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ONJONHGJOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F512D0", Offset = "0x7F4FCD0", VA = "0x187F512D0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GNAMPCONKOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F512F0", Offset = "0x7F4FCF0", VA = "0x187F512F0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CNMKBLECDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F512E0", Offset = "0x7F4FCE0", VA = "0x187F512E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int JLKLKDMDGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA676C0", Offset = "0xA660C0", VA = "0x180A676C0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float FGPJFIIOKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD17B40", Offset = "0xD16540", VA = "0x180D17B40", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BKBEKHCFABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xFA0640", Offset = "0xF9F040", VA = "0x180FA0640", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F51220", Offset = "0x7F4FC20", VA = "0x187F51220")]
	public OHPMCPKDCCH(UniformTRS DOJAOGOFCDN, DLOAIPKFGBA EAGGHBKHKHF, float GNGFKAPLEPB, float3 DHGHMLBENNF, AOFPBDKJHJG AIFOBKHLKPO, OCLKLGODOEL JIPHKMMDNLF, NFNDHLABKJP JKGCHKOAIPN, float IEJMHCEOFAJ, int NKBLHPNIMNA, NativeArray<PLLACCJJPHF> KPPFGECBPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x114CC80", Offset = "0x114B680", VA = "0x18114CC80", Slot = "33")]
	public NativeArray<PLLACCJJPHF> GetNativeCurvePoints()
	{
		return default(NativeArray<PLLACCJJPHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F51160", Offset = "0x7F4FB60", VA = "0x187F51160", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EFABEGKJJDE : KHPHAEDGHEJ, AELOEGAHNAG, HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<AMKAGOPDJAP, CMGHNAKJDFM> NFBJEFOKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private CMGHNAKJDFM FNPPAEMKOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool CIKAJJOHIHG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private CMGHNAKJDFM IDFEACDONIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0", Slot = "28")]
		get
		{
			return default(CMGHNAKJDFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool AENKNEGKMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xED7A00", Offset = "0xED6400", VA = "0x180ED7A00", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 PNKKOOCLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F41690", Offset = "0x7F40090", VA = "0x187F41690", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F41670", Offset = "0x7F40070", VA = "0x187F41670")]
	public EFABEGKJJDE(ENAPEPFMDAJ JNMDJGFBNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F40FF0", Offset = "0x7F3F9F0", VA = "0x187F40FF0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F41040", Offset = "0x7F3FA40", VA = "0x187F41040", Slot = "26")]
	public override void FPILOHDMIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HOFLEHAHIOJ : DKFMNGENAGD, FMGFLKNPHAK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject KANJMNGKACD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject MIGFNEFDENP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BD60", Offset = "0x7F4A760", VA = "0x187F4BD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KAOEODPJKHN OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BC60", Offset = "0x7F4A660", VA = "0x187F4BC60", Slot = "15")]
		get
		{
			return default(KAOEODPJKHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EABNKPDDGGB CBLNHJFHAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BF40", Offset = "0x7F4A940", VA = "0x187F4BF40", Slot = "16")]
		get
		{
			return default(EABNKPDDGGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BDF0", Offset = "0x7F4A7F0", VA = "0x187F4BDF0")]
	public HOFLEHAHIOJ(ENAPEPFMDAJ MBIJJAIIOHD, bool FFHJKAHOJPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B950", Offset = "0x7F4A350", VA = "0x187F4B950")]
	public void CALKJJMLMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BC60", Offset = "0x7F4A660", VA = "0x187F4BC60")]
	protected KAOEODPJKHN IGIPFCFHKPG()
	{
		return default(KAOEODPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BB10", Offset = "0x7F4A510", VA = "0x187F4BB10")]
	private static bool FHONIKOBGMJ(ENAPEPFMDAJ PHGPJJNEHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BAE0", Offset = "0x7F4A4E0", VA = "0x187F4BAE0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GFJMHDLFAOK : KHPHAEDGHEJ, AJFNDLNEHCE, HHCMFCBLDPE, IDisposable, GFBHNCCBMLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<PLLACCJJPHF> KPPFGECBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool BKBMJJFKMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool CLPJHAJOBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float IEJMHCEOFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int NKBLHPNIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool HJBKPBKIFBP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PGLFOICFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xCA7110", Offset = "0xCA5B10", VA = "0x180CA7110", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IEAMONNHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA57570", Offset = "0xA55F70", VA = "0x180A57570", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float AJGFBMHHDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE13B00", Offset = "0xE12500", VA = "0x180E13B00", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int COAPNEDGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xDC1120", Offset = "0xDBFB20", VA = "0x180DC1120", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PDFJPCNEMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xC99F10", Offset = "0xC98910", VA = "0x180C99F10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int MEAOLHNJAML
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F465E0", Offset = "0x7F44FE0", VA = "0x187F465E0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BCINFHGIOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F46090", Offset = "0x7F44A90", VA = "0x187F46090", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F46830", Offset = "0x7F45230", VA = "0x187F46830")]
	public GFJMHDLFAOK(ENAPEPFMDAJ JNMDJGFBNHD, [Optional] NativeList<PLLACCJJPHF> KPPFGECBPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F46180", Offset = "0x7F44B80", VA = "0x187F46180", Slot = "26")]
	public override void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F45F40", Offset = "0x7F44940", VA = "0x187F45F40", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F46030", Offset = "0x7F44A30", VA = "0x187F46030", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F46580", Offset = "0x7F44F80", VA = "0x187F46580")]
	public void MGOKHKOGPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F46260", Offset = "0x7F44C60", VA = "0x187F46260", Slot = "34")]
	public NativeArray<PLLACCJJPHF> GetNativeCurvePoints()
	{
		return default(NativeArray<PLLACCJJPHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F46430", Offset = "0x7F44E30", VA = "0x187F46430", Slot = "35")]
	private Vector3 IAKFCAMDCLE(int IDANDMAPNBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F46790", Offset = "0x7F45190", VA = "0x187F46790", Slot = "36")]
	private Quaternion OGGDKIMNDAJ(int IDANDMAPNBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F46600", Offset = "0x7F45000", VA = "0x187F46600", Slot = "37")]
	private float NHIDFNNNALB(int IDANDMAPNBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F467C0", Offset = "0x7F451C0", VA = "0x187F467C0")]
	private NativeArray<Entity> OPCBDMCAAMI()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class KGKAOCGCJGH : BEBGPCKHFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DEA0", Offset = "0x7F4C8A0", VA = "0x187F4DEA0", Slot = "15")]
	protected override ComponentSystemBase AFMHKADDOAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E2C0", Offset = "0x7F4CCC0", VA = "0x187F4E2C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E2D0", Offset = "0x7F4CCD0", VA = "0x187F4E2D0")]
	public KGKAOCGCJGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LABNIJDJELA]
public sealed class OIHFBICNLOJ : KFMHNIJKKKB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery CDPFPANKCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery FECBACHANOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery JOOAKFAJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery HEFNGJBKHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery KDHDKLOIOHL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F518F0", Offset = "0x7F502F0", VA = "0x187F518F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F51C50", Offset = "0x7F50650", VA = "0x187F51C50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F51450", Offset = "0x7F4FE50", VA = "0x187F51450")]
	private void FNKAHFLJBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F51690", Offset = "0x7F50090", VA = "0x187F51690")]
	private void JMBJEIBJKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F51C90", Offset = "0x7F50690", VA = "0x187F51C90")]
	private void PIFPDMHLFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F51350", Offset = "0x7F4FD50", VA = "0x187F51350")]
	private void BMJPBANGGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F517F0", Offset = "0x7F501F0", VA = "0x187F517F0")]
	private void OPIKHLIIEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F51300", Offset = "0x7F4FD00", VA = "0x187F51300")]
	private NativeList<Entity> AJFNJGKFJLG(NativeArray<Entity> OBKJONELPMG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F517A0", Offset = "0x7F501A0", VA = "0x187F517A0")]
	private NativeList<Entity> LOMAHOIDJFM(NativeArray<Entity> OBKJONELPMG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F51630", Offset = "0x7F50030", VA = "0x187F51630")]
	private void HCNLJEHGPMH(NativeArray<Entity> OBKJONELPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public OIHFBICNLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[LABNIJDJELA]
public sealed class FFPBGBOGKDE : KFMHNIJKKKB, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery EHFBCNDJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery IMDPPHOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery POFECKJELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MGLBOPBHLHA IGNMBKHJJMN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F44B90", Offset = "0x7F43590", VA = "0x187F44B90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F43FD0", Offset = "0x7F429D0", VA = "0x187F43FD0", Slot = "15")]
	public override void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F44D60", Offset = "0x7F43760", VA = "0x187F44D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F441E0", Offset = "0x7F42BE0", VA = "0x187F441E0")]
	private void NDIFJGFMGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F434E0", Offset = "0x7F41EE0", VA = "0x187F434E0")]
	private void DOEINPENOIJ(NativeParallelHashSet<LFLLENECNAF> NPDDJMBABPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F44500", Offset = "0x7F42F00", VA = "0x187F44500")]
	private void NGCPICALOGA(NativeParallelHashSet<LFLLENECNAF> NPDDJMBABPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F43C10", Offset = "0x7F42610", VA = "0x187F43C10")]
	private void IOOICPFLDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F43B70", Offset = "0x7F42570", VA = "0x187F43B70")]
	private bool HGJGDNFFACJ(Entity FCFDGFFMMDF, [Out] LFLLENECNAF ODCLBLBHLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F44030", Offset = "0x7F42A30", VA = "0x187F44030")]
	private bool MFAFOPGIOGG(Entity FCFDGFFMMDF, [Out] LFLLENECNAF ODCLBLBHLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public FFPBGBOGKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LABNIJDJELA]
public sealed class IDHNHINDOKI : KFMHNIJKKKB
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery OBHDLLHPHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery FBGEKBGCBOJ;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C690", Offset = "0x7F4B090", VA = "0x187F4C690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C7E0", Offset = "0x7F4B1E0", VA = "0x187F4C7E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C0A0", Offset = "0x7F4AAA0", VA = "0x187F4C0A0")]
	private void DOEINPENOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C3A0", Offset = "0x7F4ADA0", VA = "0x187F4C3A0")]
	private void NGCPICALOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public IDHNHINDOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DLNCMMPIDJL : KFMHNIJKKKB, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct PCDIPNLPBMP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob OPLFFECDION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob MCLLIPBONLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob LOLCCHBEIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob DMMMKICHBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle BFNOEIKPHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<IIHKBMENICN> FOHBLBGEMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> BCAGLJIBHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> FKGCCEPHPFJ;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F51EE0", Offset = "0x7F508E0", VA = "0x187F51EE0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F51F60", Offset = "0x7F50960", VA = "0x187F51F60")]
		private void KABLKNMOJFL(EntityQueryInJob HGDNMECPDPO, NativeList<Entity> IHPFHPPLNOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct KMGPPJLALPH : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle BFNOEIKPHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<IIHKBMENICN> FOHBLBGEMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> IHPFHPPLNOM;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EDC0", Offset = "0x7F4D7C0", VA = "0x187F4EDC0", Slot = "4")]
		public void Execute(ArchetypeChunk JGNEIPNAHGI, int CFLNOANBMOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct PJIMGPECCEA : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle BFNOEIKPHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> NOJCAHBHJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<FOFFLCDBMLE> FGCMFCMNJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<FLEGAJFKEPE> GFPEBGOGNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<IIHKBMENICN> ADLHCJOPLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> MHLKOEJHCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<FOFFLCDBMLE> KPHIJHBGOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<LFLLENECNAF> ENIJJNHHKFC;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F52040", Offset = "0x7F50A40", VA = "0x187F52040", Slot = "4")]
		public void Execute(ArchetypeChunk JGNEIPNAHGI, int CFLNOANBMOC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery OPLFFECDION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery MCLLIPBONLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery LOLCCHBEIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery DMMMKICHBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery PEFAHKAFPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery FMKLJKMJGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery HOOKPNAHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private MGLBOPBHLHA HOLGMAKHOGF;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F40620", Offset = "0x7F3F020", VA = "0x187F40620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FC30", Offset = "0x7F3E630", VA = "0x187F3FC30", Slot = "15")]
	public override void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F40BA0", Offset = "0x7F3F5A0", VA = "0x187F40BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F1F0", Offset = "0x7F3DBF0", VA = "0x187F3F1F0")]
	private void DIEGGDFJFCC(NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF, int LGEHOBGOLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FE40", Offset = "0x7F3E840", VA = "0x187F3FE40")]
	private void KMBDJGNFKEH(NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF, int EEEPMEOJPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F7F0", Offset = "0x7F3E1F0", VA = "0x187F3F7F0")]
	private void EHAFPAFKKPA(NativeParallelHashSet<LFLLENECNAF> BGAFLJDDEMF, int IHBAMGNFMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F40290", Offset = "0x7F3EC90", VA = "0x187F40290")]
	private void NAEFOAIHEPL(NativeParallelHashSet<LFLLENECNAF> NPDDJMBABPM, int CGFDMLLGNMO, int LGIKODDCBNM, int GJGJGDHCNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FC90", Offset = "0x7F3E690", VA = "0x187F3FC90")]
	private void KGLPBADADAC(Entity ACKEPHNMBEP, OOCANPCELJK IMEKKLDLFBL, LFLLENECNAF ODCLBLBHLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public DLNCMMPIDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ADLIHEFGCGO : KFMHNIJKKKB
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery FGDFMLNLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery EPKMNGDFMDE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F37740", Offset = "0x7F36140", VA = "0x187F37740", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F37980", Offset = "0x7F36380", VA = "0x187F37980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public ADLIHEFGCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LKFHLCBGEPN : KFMHNIJKKKB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct DANKBPMPJDO : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery DMHGFNIMLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F000", Offset = "0x7F4DA00", VA = "0x187F4F000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F4F140", Offset = "0x7F4DB40", VA = "0x187F4F140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public LKFHLCBGEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LABNIJDJELA]
internal class AIAMCPALCCF : KFMHNIJKKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class HJNGMABOGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery JLJEKFOIHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery CEJLNCHHLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CDMFFMMPOOB PHKGACLNHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType HOCOHFJEJDE;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HJNGMABOGLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void CDMFFMMPOOB(NativeArray<OOCANPCELJK> GCKDJGKENJL, KCOGCHBFLDF NAHCCGHJGAG);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<HJNGMABOGLN> GIPFCGDEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CCIJNJHLGOE APEBIGJNACI;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F385E0", Offset = "0x7F36FE0", VA = "0x187F385E0", Slot = "15")]
	public override void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F38980", Offset = "0x7F37380", VA = "0x187F38980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F38B10", Offset = "0x7F37510", VA = "0x187F38B10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x30026D0", Offset = "0x30010D0", VA = "0x1830026D0")]
	private void GIIEKMHOBBB<T>(CDMFFMMPOOB PHKGACLNHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F387E0", Offset = "0x7F371E0", VA = "0x187F387E0")]
	private static void LEOGLONMHEK(NativeArray<OOCANPCELJK> FMPLMPHMMMJ, KCOGCHBFLDF LPNOGCKCNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F38440", Offset = "0x7F36E40", VA = "0x187F38440")]
	private static void FBLMKKLFANN(NativeArray<OOCANPCELJK> FMPLMPHMMMJ, KCOGCHBFLDF LPNOGCKCNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F38640", Offset = "0x7F37040", VA = "0x187F38640")]
	private static void JBIJMLIHBFO(NativeArray<OOCANPCELJK> FMPLMPHMMMJ, KCOGCHBFLDF LPNOGCKCNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public AIAMCPALCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LABNIJDJELA]
public sealed class BPNNAMAAOPI : KFMHNIJKKKB
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery HGDNMECPDPO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F391E0", Offset = "0x7F37BE0", VA = "0x187F391E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DCLHMNOIGBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS DOJAOGOFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData APDLNIHPKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public CMGHNAKJDFM FNPPAEMKOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PGLCLCMJOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool CIKAJJOHIHG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DHDKGLCENPP(Lifetime.LoadInstance)]
public struct NFFFJHFDFOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity JGPHIOPNBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> CJKJLGMNLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> KAGMIBLOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<DCLHMNOIGBF> MNPKJLEBJJO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FD40", Offset = "0x7F4E740", VA = "0x187F4FD40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(GDDJAACACCI), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class GDDJAACACCI : BOEGHMMFADM, IIAKOCKOOML, JEKAABCJIBE, HKKELALCKCD
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct IIMNKBEPBPM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly GDDJAACACCI EAGGHBKHKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool NOKOHKHNBHC;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1919890", Offset = "0x1918290", VA = "0x181919890")]
		public IIMNKBEPBPM(GDDJAACACCI EAGGHBKHKHF, bool NOKOHKHNBHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CCA0", Offset = "0x7F4B6A0", VA = "0x187F4CCA0")]
		public Queue<IFLOHJIHAOF>.Enumerator ICNPOCIJNJG()
		{
			return default(Queue<IFLOHJIHAOF>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C960", Offset = "0x7F4B360", VA = "0x187F4C960", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private LIEJCDBGGEG BKOBJPKBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private CKHGENHBJMF OIOLEEAIPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<PLLACCJJPHF>> CKCGLCEFEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> BFPGLIGAEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<OOCANPCELJK> MABPKEJJBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private GPNKNINDHHP<IFLOHJIHAOF> HAFJCAJGMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private GPNKNINDHHP<NFFFJHFDFOO> NNDOCHDMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private GPNKNINDHHP<LLCCNBEGHAH> JFNJCDAAIKD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F45300", Offset = "0x7F43D00", VA = "0x187F45300", Slot = "4")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F45E10", Offset = "0x7F44810", VA = "0x187F45E10")]
	public void PMJHKJCONKG(NativeList<PLLACCJJPHF> EKBEICAOOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F45590", Offset = "0x7F43F90", VA = "0x187F45590")]
	public void KBFOIOOFOEA(Entity EAGGHBKHKHF, [In] BBKFGDIALBG<GameObject> PGJILNCDOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F45500", Offset = "0x7F43F00", VA = "0x187F45500")]
	public void JELCJCMNAEA(NativeList<OOCANPCELJK> FMPLMPHMMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F45BE0", Offset = "0x7F445E0", VA = "0x187F45BE0")]
	public void OHFKBFNNLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F44E50", Offset = "0x7F43850", VA = "0x187F44E50")]
	public void BBFGEFOGOBB(JHOAFMOCPOK BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F45730", Offset = "0x7F44130", VA = "0x187F45730")]
	public JobHandle KODIFFMOFBP([In] IFLOHJIHAOF IJOJGNJMCGP, JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F457D0", Offset = "0x7F441D0", VA = "0x187F457D0")]
	public JobHandle KODIFFMOFBP([In] NFFFJHFDFOO IJOJGNJMCGP, JobHandle HGAGAALLKJC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF8C0", Offset = "0x7BDE2C0", VA = "0x187BDF8C0")]
	public IIMNKBEPBPM BIOFENNMPDH(bool NOKOHKHNBHC)
	{
		return default(IIMNKBEPBPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F456E0", Offset = "0x7F440E0", VA = "0x187F456E0")]
	public OPMNAEBACNA<NFFFJHFDFOO> KEMBHCPDIAB()
	{
		return default(OPMNAEBACNA<NFFFJHFDFOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F44E00", Offset = "0x7F43800", VA = "0x187F44E00")]
	public OPMNAEBACNA<LLCCNBEGHAH> ABOLCMONAEJ()
	{
		return default(OPMNAEBACNA<LLCCNBEGHAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F458E0", Offset = "0x7F442E0", VA = "0x187F458E0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F45B00", Offset = "0x7F44500", VA = "0x187F45B00", Slot = "5")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F45870", Offset = "0x7F44270", VA = "0x187F45870", Slot = "6")]
	private void LAICDJPNDMA(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1210780", Offset = "0x120F180", VA = "0x181210780", Slot = "7")]
	private void CBBMFAEKICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GDDJAACACCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct DDEBADHGOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS DOJAOGOFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData APDLNIHPKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public KIMDEAGCPNF JKGCHKOAIPN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DHDKGLCENPP(Lifetime.LoadInstance)]
public struct IFLOHJIHAOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity JGPHIOPNBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> OBKJONELPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> CJKJLGMNLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> KAGMIBLOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<JOGKEMLKOOJ> IDLFHOJGJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<PLLACCJJPHF> EKBEICAOOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<DDEBADHGOEM> NCCJKKPJICK;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C880", Offset = "0x7F4B280", VA = "0x187F4C880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C890", Offset = "0x7F4B290", VA = "0x187F4C890")]
	public void IIPIKJHBJDI(bool NOKOHKHNBHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(MBNAKHBEGIP), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class MBNAKHBEGIP : OJLLDEKEAMD, JEKAABCJIBE, HKKELALCKCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private GDDJAACACCI EGLIDFLBAMK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FB20", Offset = "0x7F4E520", VA = "0x187F4FB20", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F4FAD0", Offset = "0x7F4E4D0", VA = "0x187F4FAD0", Slot = "5")]
	private void LAICDJPNDMA(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x11DFC50", Offset = "0x11DE650", VA = "0x1811DFC50", Slot = "6")]
	private void CBBMFAEKICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MBNAKHBEGIP()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : KFMHNIJKKKB, BOEGHMMFADM
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
			public NativeParallelHashMap<int, CMGHNAKJDFM> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<DCLHMNOIGBF> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7F46F30", Offset = "0x7F45930", VA = "0x187F46F30", Slot = "4")]
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
			public NativeArray<PLLACCJJPHF> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<JOGKEMLKOOJ> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<DDEBADHGOEM> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7F472D0", Offset = "0x7F45CD0", VA = "0x187F472D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3E380", Offset = "0x7F3CD80", VA = "0x187F3E380", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7F52B40", Offset = "0x7F51540", VA = "0x187F52B40")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7F52AF0", Offset = "0x7F514F0", VA = "0x187F52AF0")]
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
				float3 MGFLGFPNAJJ(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7F4F370", Offset = "0x7F4DD70", VA = "0x187F4F370", Slot = "5")]
				public float3 HLOIPIHBLPF(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7F4F710", Offset = "0x7F4E110", VA = "0x187F4F710", Slot = "4")]
				public float3 MGFLGFPNAJJ(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7F4FDD0", Offset = "0x7F4E7D0", VA = "0x187F4FDD0", Slot = "4")]
				public float3 MGFLGFPNAJJ(quaternion rotation)
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
			public NativeArray<JOGKEMLKOOJ> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<PLLACCJJPHF> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7F482E0", Offset = "0x7F46CE0", VA = "0x187F482E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7F48A70", Offset = "0x7F47470", VA = "0x187F48A70")]
			private void GOGGFNANOJO(NativeList<PointSrcData> srcData, NativeList<PLLACCJJPHF> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7F49F00", Offset = "0x7F48900", VA = "0x187F49F00")]
			public static Vector3 MLIHOCIHNON(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7F48260", Offset = "0x7F46C60", VA = "0x187F48260")]
			public static quaternion DEJKJINNLFA(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7F48030", Offset = "0x7F46A30", VA = "0x187F48030")]
			private static quaternion CAONMNGDCEF(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F4A310", Offset = "0x7F48D10", VA = "0x187F4A310")]
			private static float3 NGFFBAMAHNL(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F49C80", Offset = "0x7F48680", VA = "0x187F49C80")]
			private static quaternion IJLLCCIMMLA(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B2F0", Offset = "0x7F49CF0", VA = "0x187F4B2F0")]
			private static PLLACCJJPHF PDFHLHAILMH(int idx, NativeList<PointSrcData> srcData)
			{
				return default(PLLACCJJPHF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4188100", Offset = "0x4186B00", VA = "0x184188100")]
			private void EGNBDDDDPEA<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7F4A4E0", Offset = "0x7F48EE0", VA = "0x187F4A4E0")]
			private void OJMCLFOFFMJ(NativeList<PointSrcData> sourcePoints, NativeList<PLLACCJJPHF> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7F49950", Offset = "0x7F48350", VA = "0x187F49950")]
			public static float HCPOKEHBBFF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7F49D10", Offset = "0x7F48710", VA = "0x187F49D10")]
			private static quaternion JIAHNFCCNEG(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B710", Offset = "0x7F4A110", VA = "0x187F4B710")]
			private static PLLACCJJPHF PNHIGIAMFHE(PointSrcData point)
			{
				return default(PLLACCJJPHF);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B830", Offset = "0x7F4A230", VA = "0x187F4B830")]
			private static PLLACCJJPHF PNHIGIAMFHE(float3 pos, quaternion rot, float radius)
			{
				return default(PLLACCJJPHF);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7F489D0", Offset = "0x7F473D0", VA = "0x187F489D0")]
			private static bool GGKEONBJPAD(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F48900", Offset = "0x7F47300", VA = "0x187F48900")]
			private static float3 FHLJHNLFEBL(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B560", Offset = "0x7F49F60", VA = "0x187F4B560")]
			public static float3 PHOAFCCCJPL(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7F49AD0", Offset = "0x7F484D0", VA = "0x187F49AD0")]
			public static float3 HLOIPIHBLPF(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7F479F0", Offset = "0x7F463F0", VA = "0x187F479F0")]
			private static quaternion BCLGGKFJDAN(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7F47E50", Offset = "0x7F46850", VA = "0x187F47E50")]
			private static float BEGBHJFPJCE(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7F54DE0", Offset = "0x7F537E0", VA = "0x187F54DE0")]
			private void KCCCCCIADOP(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7F54CF0", Offset = "0x7F536F0", VA = "0x187F54CF0", Slot = "4")]
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
			public NativeList<PLLACCJJPHF> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F56530", Offset = "0x7F54F30", VA = "0x187F56530")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7F56520", Offset = "0x7F54F20", VA = "0x187F56520", Slot = "4")]
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
			public NativeList<PLLACCJJPHF> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F564D0", Offset = "0x7F54ED0", VA = "0x187F564D0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7F564C0", Offset = "0x7F54EC0", VA = "0x187F564C0", Slot = "4")]
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
			public NativeList<DCLHMNOIGBF> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7F47620", Offset = "0x7F46020", VA = "0x187F47620")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F47610", Offset = "0x7F46010", VA = "0x187F47610", Slot = "4")]
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
			public NativeList<JOGKEMLKOOJ> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<DDEBADHGOEM> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7F477F0", Offset = "0x7F461F0", VA = "0x187F477F0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F477E0", Offset = "0x7F461E0", VA = "0x187F477E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F560A0", Offset = "0x7F54AA0", VA = "0x187F560A0")]
			private void KCCCCCIADOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7F56090", Offset = "0x7F54A90", VA = "0x187F56090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly COJJKFBGGKB log;

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
		private HLOEAOGKPNF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private LIEJCDBGGEG objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private GDDJAACACCI bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IMCGIIAJEMF ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B60", Offset = "0x7F53560", VA = "0x187F54B60", Slot = "15")]
		public override void InitReferences(FKFJNEKJHIE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F55D50", Offset = "0x7F54750", VA = "0x187F55D50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F55E40", Offset = "0x7F54840", VA = "0x187F55E40", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F55EA0", Offset = "0x7F548A0", VA = "0x187F55EA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F532C0", Offset = "0x7F51CC0", VA = "0x187F532C0")]
		private JobHandle BMLADMFKMDF(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F54EC0", Offset = "0x7F538C0", VA = "0x187F54EC0")]
		private JobHandle NNMABGPBLBF(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F52B60", Offset = "0x7F51560", VA = "0x187F52B60")]
		private JobHandle ABLAOOAEILO(NativeArray<int> pointCount, NativeList<PLLACCJJPHF> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F52D10", Offset = "0x7F51710", VA = "0x187F52D10")]
		private JobHandle PKGJMJGBNGP(NativeList<PLLACCJJPHF> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F53A20", Offset = "0x7F52420", VA = "0x187F53A20")]
		private JobHandle DAOGNBODIMG(EntityQuery query, NativeList<JOGKEMLKOOJ> splinePointRanges, NativeList<PLLACCJJPHF> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F54A40", Offset = "0x7F53440", VA = "0x187F54A40")]
		private JobHandle IJKINNEOCCE(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F547D0", Offset = "0x7F531D0", VA = "0x187F547D0")]
		private JobHandle HDOILNBIPHL(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F541B0", Offset = "0x7F52BB0", VA = "0x187F541B0")]
		private JobHandle EHLLBPEEIMD(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<DCLHMNOIGBF> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F53EF0", Offset = "0x7F528F0", VA = "0x187F53EF0")]
		private JobHandle DJDHOIOHEPO(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JOGKEMLKOOJ> splinePointRanges, [Out] NativeList<DDEBADHGOEM> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F54450", Offset = "0x7F52E50", VA = "0x187F54450")]
		private JobHandle FCOKDOBOOPA(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7F52DB0", Offset = "0x7F517B0", VA = "0x187F52DB0")]
		private JobHandle BAINCDMLGDG(EntityQuery query, NativeList<DCLHMNOIGBF> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7F53600", Offset = "0x7F52000", VA = "0x187F53600")]
		private static NativeParallelHashMap<int, CMGHNAKJDFM> BNOEIJFADKD()
		{
			return default(NativeParallelHashMap<int, CMGHNAKJDFM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F55580", Offset = "0x7F53F80", VA = "0x187F55580")]
		private JobHandle OJEEMPHCPKF(EntityQuery query, NativeList<JOGKEMLKOOJ> splinePointRanges, NativeList<PLLACCJJPHF> splinePointData, NativeList<DDEBADHGOEM> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7F55920", Offset = "0x7F54320", VA = "0x187F55920")]
		private JobHandle ONAHNJOJBPC(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7F52B60", Offset = "0x7F51560", VA = "0x187F52B60")]
		private JobHandle AJIMDBGLJLA(NativeArray<int> pointCount, NativeList<PLLACCJJPHF> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7F52D10", Offset = "0x7F51710", VA = "0x187F52D10")]
		private JobHandle AIEMKAAGBMA(NativeList<PLLACCJJPHF> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F54C00", Offset = "0x7F53600", VA = "0x187F54C00")]
		private JobHandle KDCNCGMDCKA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<DCLHMNOIGBF> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7F52C00", Offset = "0x7F51600", VA = "0x187F52C00")]
		private JobHandle ADDKGIKBFFL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JOGKEMLKOOJ> ranges, NativeList<DDEBADHGOEM> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F548F0", Offset = "0x7F532F0", VA = "0x187F548F0")]
		private JobHandle IAAILADOBKH(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F55A00", Offset = "0x7F54400", VA = "0x187F55A00", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JLEGNNPBKJG : NFJLOKHFHGF, BOEGHMMFADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private GDDJAACACCI EGLIDFLBAMK;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DD50", Offset = "0x7F4C750", VA = "0x187F4DD50", Slot = "14")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DDA0", Offset = "0x7F4C7A0", VA = "0x187F4DDA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
	public JLEGNNPBKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class CCOAPPMMOAF : KFMHNIJKKKB, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct DKHCJOHEAKE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager CBHCEEBBPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private OIHKMMLKDEH<T> MFEGPLGCIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int MNFHMLCLFEB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD000", Offset = "0x6AFBA00", VA = "0x186AFD000")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD870", Offset = "0x6AFC270", VA = "0x186AFD870")]
		public DKHCJOHEAKE(EntityManager CBHCEEBBPPJ, OIHKMMLKDEH<T> MFEGPLGCIDN, NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4790D20", Offset = "0x478F720", VA = "0x184790D20")]
		public DKHCJOHEAKE<T> ICNPOCIJNJG()
		{
			return default(DKHCJOHEAKE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD750", Offset = "0x6AFC150", VA = "0x186AFD750")]
		public bool OKGFECGDIIM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly COJJKFBGGKB ONCBAJHNEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CKHGENHBJMF OIOLEEAIPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private GDDJAACACCI EGLIDFLBAMK;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F3B410", Offset = "0x7F39E10", VA = "0x187F3B410", Slot = "15")]
	public override void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F39D80", Offset = "0x7F38780", VA = "0x187F39D80")]
	public void FMNMHHLIPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F3CAC0", Offset = "0x7F3B4C0", VA = "0x187F3CAC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F39DB0", Offset = "0x7F387B0", VA = "0x187F39DB0")]
	private void FPMCFLKFBEK(LLCCNBEGHAH IJOJGNJMCGP, Mesh[] OJOHGKGLJEH, NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x384ED90", Offset = "0x384D790", VA = "0x18384ED90")]
	private DKHCJOHEAKE<T> PPEGCIOJDFG<T>(OIHKMMLKDEH<T> MFEGPLGCIDN, NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH) where T : struct
	{
		return default(DKHCJOHEAKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F39620", Offset = "0x7F38020", VA = "0x187F39620")]
	private void BDODFOKBCNO(Transform EAGGHBKHKHF, NativeArray<BFHOKKMJPBN> ILBKNFHGEAN, BBKFGDIALBG<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3AF50", Offset = "0x7F39950", VA = "0x187F3AF50")]
	private void IHMHHONKHCJ(Transform EAGGHBKHKHF, NativeArray<MHEBHKLPMHH> OBFABBIOEOO, BBKFGDIALBG<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F399A0", Offset = "0x7F383A0", VA = "0x187F399A0")]
	private void EDFGOOLEEJL(Transform EAGGHBKHKHF, NativeArray<LLFBJJACFDA> IDNDHGMJFPG, BBKFGDIALBG<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7F3B490", Offset = "0x7F39E90", VA = "0x187F3B490")]
	private void KHFGJKLCLBP(Transform EAGGHBKHKHF, NativeArray<AEDKKFOBEOK> OJOHGKGLJEH, Mesh[] DGHFBLNODIL, BBKFGDIALBG<GameObject> LGEEGHMACEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F3C970", Offset = "0x7F3B370", VA = "0x187F3C970")]
	private static void LNJDOKNCFLL(NativeParallelHashSet<Entity> OBKJONELPMG, NativeParallelHashSet<Entity> IBOIKPNDBHF, NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7F3AE90", Offset = "0x7F39890", VA = "0x187F3AE90")]
	private static void HALKBGPLJLC(NativeList<Entity> IBKFNAMHILN, NativeArray<EntityRemapUtility.EntityRemapInfo> IGDLLJBKEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7F3BCB0", Offset = "0x7F3A6B0", VA = "0x187F3BCB0")]
	private NativeParallelHashMap<Entity, FLEGAJFKEPE> LEFNILGHGHK(GDDJAACACCI.IIMNKBEPBPM FPGGNICGPOE, OPMNAEBACNA<NFFFJHFDFOO> EOKABDPBOPG, List<GameObject> LGEEGHMACEM)
	{
		return default(NativeParallelHashMap<Entity, FLEGAJFKEPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7F3C870", Offset = "0x7F3B270", VA = "0x187F3C870")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> LMLIECOLFHO(Entity PFANMEFDHGB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F3DC30", Offset = "0x7F3C630", VA = "0x187F3DC30")]
	private void PCDBFHHGEFN(NativeList<Entity> EPLNGNNNKND, NativeList<Entity> GJNEOKGNMME, NativeParallelHashMap<Entity, FLEGAJFKEPE> GENGEPKCJBH, NativeList<JOGKEMLKOOJ> GFDCCEIFIGL, NativeList<PLLACCJJPHF> BCOGLODEHHK, NativeList<DDEBADHGOEM> CKCGLCEFEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7F3B8C0", Offset = "0x7F3A2C0", VA = "0x187F3B8C0")]
	private void KIJOBJHCGBL(NativeList<Entity> OBKJONELPMG, NativeList<Entity> CJKJLGMNLNL, NativeParallelHashMap<Entity, FLEGAJFKEPE> GENGEPKCJBH, NativeList<DCLHMNOIGBF> MNPKJLEBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D6D0", Offset = "0x2C9C0D0", VA = "0x182C9D6D0")]
	public CCOAPPMMOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class INNBCIDGELA : LPNALBCFNML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS DOJAOGOFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DLOAIPKFGBA EAGGHBKHKHF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject KNOLMLDOMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS EHEFGMGMKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D030", Offset = "0x7F4BA30", VA = "0x187F4D030", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 BFILPNKFNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CDB0", Offset = "0x7F4B7B0", VA = "0x187F4CDB0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 AAELMKFKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CEF0", Offset = "0x7F4B8F0", VA = "0x187F4CEF0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 NABMKBOHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CFE0", Offset = "0x7F4B9E0", VA = "0x187F4CFE0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CEA0", Offset = "0x7F4B8A0", VA = "0x187F4CEA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion JNCOJBBBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CE50", Offset = "0x7F4B850", VA = "0x187F4CE50", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CD60", Offset = "0x7F4B760", VA = "0x187F4CD60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 EBOPAOJJCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CF40", Offset = "0x7F4B940", VA = "0x187F4CF40", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 OOKNLLIMMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CF90", Offset = "0x7F4B990", VA = "0x187F4CF90", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 MNNAABNONHK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CE00", Offset = "0x7F4B800", VA = "0x187F4CE00", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D110", Offset = "0x7F4BB10", VA = "0x187F4D110")]
	public INNBCIDGELA(UniformTRS DOJAOGOFCDN, DLOAIPKFGBA EAGGHBKHKHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class PPHFLOMJLNA : INNBCIDGELA, HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float GNGFKAPLEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 DHGHMLBENNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly AOFPBDKJHJG AIFOBKHLKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly OCLKLGODOEL JIPHKMMDNLF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private KAOEODPJKHN DJOLACOJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7F528F0", Offset = "0x7F512F0", VA = "0x187F528F0", Slot = "17")]
		get
		{
			return default(KAOEODPJKHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS BHCPGPOMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F52940", Offset = "0x7F51340", VA = "0x187F52940", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float PHICNKHHMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE80", Offset = "0xA5A880", VA = "0x180A5BE80", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 DKLNMJABJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7F52A20", Offset = "0x7F51420", VA = "0x187F52A20", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private AOFPBDKJHJG EBDLKHLOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xF015A0", Offset = "0xEFFFA0", VA = "0x180F015A0", Slot = "21")]
		get
		{
			return default(AOFPBDKJHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private OCLKLGODOEL PNOIKHOAHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x13630B0", Offset = "0x1361AB0", VA = "0x1813630B0", Slot = "22")]
		get
		{
			return default(OCLKLGODOEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool ILILEJIAHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LFAEOEKJBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F52A70", Offset = "0x7F51470", VA = "0x187F52A70")]
	protected PPHFLOMJLNA(UniformTRS DOJAOGOFCDN, DLOAIPKFGBA EAGGHBKHKHF, float GNGFKAPLEPB, float3 DHGHMLBENNF, AOFPBDKJHJG AIFOBKHLKPO, OCLKLGODOEL JIPHKMMDNLF)
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
public abstract class DKFMNGENAGD : LPNALBCFNML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x11E65E0", Offset = "0x11E4FE0", VA = "0x1811E65E0")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity JAJKMDFDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F140", Offset = "0x7F3DB40", VA = "0x187F3F140")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E670", Offset = "0x7F3D070", VA = "0x187F3E670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E930", Offset = "0x7F3D330", VA = "0x187F3E930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected CAADPBPBGFN BDAHMDIAEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F160", Offset = "0x7F3DB60", VA = "0x187F3F160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject KNOLMLDOMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E640", Offset = "0x7F3D040", VA = "0x187F3E640", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS EHEFGMGMKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1211E70", Offset = "0x1210870", VA = "0x181211E70", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 BFILPNKFNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E680", Offset = "0x7F3D080", VA = "0x187F3E680", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 AAELMKFKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EBF0", Offset = "0x7F3D5F0", VA = "0x187F3EBF0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 NABMKBOHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F010", Offset = "0x7F3DA10", VA = "0x187F3F010", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EAB0", Offset = "0x7F3D4B0", VA = "0x187F3EAB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion JNCOJBBBEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E990", Offset = "0x7F3D390", VA = "0x187F3E990", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E530", Offset = "0x7F3CF30", VA = "0x187F3E530", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 EBOPAOJJCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3ED60", Offset = "0x7F3D760", VA = "0x187F3ED60", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 OOKNLLIMMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EE50", Offset = "0x7F3D850", VA = "0x187F3EE50", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 MNNAABNONHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E770", Offset = "0x7F3D170", VA = "0x187F3E770", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xE8B190", Offset = "0xE89B90", VA = "0x180E8B190")]
	protected DKFMNGENAGD(ENAPEPFMDAJ JNMDJGFBNHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EBC0", Offset = "0x7F3D5C0", VA = "0x187F3EBC0")]
	public static KAOEODPJKHN HNONLACFBHP(DKFMNGENAGD ANAFNAJGANI)
	{
		return default(KAOEODPJKHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class OJHLBCLJEEI
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7F580B0", Offset = "0x7F56AB0", VA = "0x187F580B0")]
	public static void KLIMFHFHFOB(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HNCJDCEJOOB
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7F57640", Offset = "0x7F56040", VA = "0x187F57640")]
	public static void OJBBEGOJJLL(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ, JHOAFMOCPOK IBCFDIANABM, LIEJCDBGGEG CFOOPMPGJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F57090", Offset = "0x7F55A90", VA = "0x187F57090")]
	public static void JDJMPHKKKKH(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ, JHOAFMOCPOK IBCFDIANABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7F57600", Offset = "0x7F56000", VA = "0x187F57600")]
	public static NativeList<Entity> LOMAHOIDJFM(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7F57050", Offset = "0x7F55A50", VA = "0x187F57050")]
	public static NativeList<Entity> AJFNJGKFJLG(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7F573A0", Offset = "0x7F55DA0", VA = "0x187F573A0")]
	private static NativeList<Entity> LOMAHOIDJFM(NativeArray<Entity> OBKJONELPMG, EntityManager CBHCEEBBPPJ, bool MNOBJHEPPPL)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class KHPHAEDGHEJ : DKFMNGENAGD, HHCMFCBLDPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float GNGFKAPLEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 DHGHMLBENNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private AOFPBDKJHJG AIFOBKHLKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private OCLKLGODOEL JIPHKMMDNLF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager EPPMAGJCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7F57F60", Offset = "0x7F56960", VA = "0x187F57F60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EGLJCDJPPKL OJJAAPMGEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F57C80", Offset = "0x7F56680", VA = "0x187F57C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData KFDKEJDFFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F57CE0", Offset = "0x7F566E0", VA = "0x187F57CE0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private KAOEODPJKHN DJOLACOJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EBC0", Offset = "0x7F3D5C0", VA = "0x187F3EBC0", Slot = "17")]
		get
		{
			return default(KAOEODPJKHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PHICNKHHMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 DKLNMJABJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x12D5210", Offset = "0x12D3C10", VA = "0x1812D5210", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private AOFPBDKJHJG EBDLKHLOFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0", Slot = "21")]
		get
		{
			return default(AOFPBDKJHJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private OCLKLGODOEL PNOIKHOAHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A900", Offset = "0xA59300", VA = "0x180A5A900", Slot = "22")]
		get
		{
			return default(OCLKLGODOEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS BHCPGPOMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7F57FF0", Offset = "0x7F569F0", VA = "0x187F57FF0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LFAEOEKJBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36D90", VA = "0x180A38390")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool ILILEJIAHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7F58020", Offset = "0x7F56A20", VA = "0x187F58020")]
	protected KHPHAEDGHEJ(ENAPEPFMDAJ JNMDJGFBNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7F57DD0", Offset = "0x7F567D0", VA = "0x187F57DD0", Slot = "26")]
	public virtual void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class KFMHNIJKKKB : NFJLOKHFHGF, BOEGHMMFADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected LIEJCDBGGEG CFOOPMPGJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private HNJPGNIHIMB MKNDHMJOBPH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected JHOAFMOCPOK PIBBBEBOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7F57BC0", Offset = "0x7F565C0", VA = "0x187F57BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected KCOGCHBFLDF KDILAENBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7F57AB0", Offset = "0x7F564B0", VA = "0x187F57AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool AIICJEJDLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7F57B00", Offset = "0x7F56500", VA = "0x187F57B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F57C10", Offset = "0x7F56610", VA = "0x187F57C10", Slot = "15")]
	public virtual void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
	protected KFMHNIJKKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PDGBGGKEBPH
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7F582F0", Offset = "0x7F56CF0", VA = "0x187F582F0")]
	public static void PNPPHIPOKBK(NativeArray<Entity> EPLNGNNNKND, EntityManager CBHCEEBBPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2851410999
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7F58700", Offset = "0x7F57100", VA = "0x187F58700")]
	public static void GLFEIEJEHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7F586F0", Offset = "0x7F570F0", VA = "0x187F586F0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class KAPGGLJEIBJ : ContainerPropertyBag<DNDILHCNIOL>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7F57A50", Offset = "0x7F56450", VA = "0x187F57A50")]
	public KAPGGLJEIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class GDFFNNDBFIE : ContainerPropertyBag<DJGIJNFKIFP>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7F56FF0", Offset = "0x7F559F0", VA = "0x187F56FF0")]
	public GDFFNNDBFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class LMGDPDPFEGF : ContainerPropertyBag<GPAALCBDFHM>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F58050", Offset = "0x7F56A50", VA = "0x187F58050")]
	public LMGDPDPFEGF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7F58530", Offset = "0x7F56F30", VA = "0x187F58530")]
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
