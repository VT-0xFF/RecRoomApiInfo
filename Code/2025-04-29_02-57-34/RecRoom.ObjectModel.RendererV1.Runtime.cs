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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7460", Offset = "0x7CB6860", VA = "0x187CB7460", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FE38C0", Offset = "0x1FE2CC0", VA = "0x181FE38C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0B30", Offset = "0x7CBFF30", VA = "0x187CC0B30")]
		private void NJKHJLGIPFD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CC10D0", Offset = "0x7CC04D0", VA = "0x187CC10D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1130", Offset = "0x7CC0530", VA = "0x187CC1130")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GILNJEANPCC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8240", Offset = "0x7CA7640", VA = "0x187CA8240")]
	public static Quaternion BMOECODPENF([In] this FNIAMENGHOL IAMJEIEGALK, [In] Vector3 DJMLEJBBDGG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HPGABBLJMLI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE000", Offset = "0x7CAD400", VA = "0x187CAE000")]
	public static bool BAJFEPKNNON(this LNIJFHBDEKN ENBGJLJJBHG, IOEIEABAMHG GPLLJCODACJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF2B0", Offset = "0x7CAE6B0", VA = "0x187CAF2B0")]
	public static bool LOAKLCDBDBG(this LNIJFHBDEKN ENBGJLJJBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7CADEC0", Offset = "0x7CAD2C0", VA = "0x187CADEC0")]
	public static bool ABJMHJILDFN(this LNIJFHBDEKN ENBGJLJJBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF180", Offset = "0x7CAE580", VA = "0x187CAF180")]
	public static void LHJFPECLALM(this LNIJFHBDEKN ENBGJLJJBHG, Vector3 ADACIJCKIHL, Quaternion DAMIAGKKDEK, float PPFBOIIFNHM, bool LLHHFMCELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE870", Offset = "0x7CADC70", VA = "0x187CAE870")]
	public static void ELMKPAENLDM(this LNIJFHBDEKN ENBGJLJJBHG, Vector3 ADACIJCKIHL, Quaternion DAMIAGKKDEK, float PPFBOIIFNHM, int EFPOPEKHAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE750", Offset = "0x7CADB50", VA = "0x187CAE750")]
	public static void DPLHBLMIGCN(this LNIJFHBDEKN ENBGJLJJBHG, int EFPOPEKHAAN, Vector3 ADACIJCKIHL, Quaternion DAMIAGKKDEK, float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF2E0", Offset = "0x7CAE6E0", VA = "0x187CAF2E0")]
	public static void MGIGDGPIDBG(this LNIJFHBDEKN ENBGJLJJBHG, Vector3 MACLHBHIMEF, Quaternion CAMPNDLMPMJ, float PPFBOIIFNHM, bool LLHHFMCELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF330", Offset = "0x7CAE730", VA = "0x187CAF330")]
	private static void PACENIHBCBP(this LNIJFHBDEKN ENBGJLJJBHG, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, float PPFBOIIFNHM, bool LLHHFMCELFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEFC0", Offset = "0x7CAE3C0", VA = "0x187CAEFC0")]
	private static void KEGBLJGAEJP(this LNIJFHBDEKN ENBGJLJJBHG, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB, float HDNDEBONOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE040", Offset = "0x7CAD440", VA = "0x187CAE040")]
	private static void BAKDPJAOCAI(this LNIJFHBDEKN ENBGJLJJBHG, int COPLIEINKOF, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB, float HDNDEBONOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE720", Offset = "0x7CADB20", VA = "0x187CAE720")]
	private static bool BLGKLKALBBA(this LNIJFHBDEKN ENBGJLJJBHG, int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEB00", Offset = "0x7CADF00", VA = "0x187CAEB00")]
	private static void EPBHCJMMMBM(this LNIJFHBDEKN ENBGJLJJBHG, int COPLIEINKOF, Vector3 PJFBLLCJOED, Quaternion EFHNCGDBHHB, float HDNDEBONOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE230", Offset = "0x7CAD630", VA = "0x187CAE230")]
	public static Vector3 BFNKPIENDPM(this LNIJFHBDEKN ENBGJLJJBHG, int COPLIEINKOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CADEF0", Offset = "0x7CAD2F0", VA = "0x187CADEF0")]
	public static Quaternion AMOPPDJKJDE(this LNIJFHBDEKN ENBGJLJJBHG, int COPLIEINKOF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEDA0", Offset = "0x7CAE1A0", VA = "0x187CAEDA0")]
	public static Vector3 JHNGDMFPLPL(IOEIEABAMHG PNEABCGFGDJ, Vector3 KBPOHLLNAIG, Vector3? NBLDBKJKINN, Vector3 CCNPMBBIJDJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface PELJOEEFNHI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHEDBHCNBKE(EntityQuery NANKCCKFFLO, EntityManager IBLGEGBFEIJ, PEDBLHEMBDD DMMOIDHGCMK, AMGLOGKJDJF KLDOGAEBEMF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface DKNHFINLNJP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType DIGMLIFCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IADNDFKPIAL(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDGGOKJNNOI(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJOIADCMHHI(GJBDMCKPJAO BGCLOEPMJGN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class BELBCCEELJI : PELJOEEFNHI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1FC0", Offset = "0x7CA13C0", VA = "0x187CA1FC0", Slot = "4")]
	public void PHEDBHCNBKE(EntityQuery NANKCCKFFLO, EntityManager IBLGEGBFEIJ, PEDBLHEMBDD DMMOIDHGCMK, AMGLOGKJDJF KLDOGAEBEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public BELBCCEELJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class BFDCKLIACEJ : PELJOEEFNHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NHNCDPLDBOL GFDPMGHKLOK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
	public BFDCKLIACEJ(NHNCDPLDBOL GFDPMGHKLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CA21D0", Offset = "0x7CA15D0", VA = "0x187CA21D0", Slot = "4")]
	public void PHEDBHCNBKE(EntityQuery NANKCCKFFLO, EntityManager IBLGEGBFEIJ, PEDBLHEMBDD DMMOIDHGCMK, AMGLOGKJDJF KLDOGAEBEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class AAELFGADGFN : PELJOEEFNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1730", Offset = "0x7CA0B30", VA = "0x187CA1730", Slot = "4")]
	public void PHEDBHCNBKE(EntityQuery NANKCCKFFLO, EntityManager IBLGEGBFEIJ, PEDBLHEMBDD DMMOIDHGCMK, AMGLOGKJDJF KLDOGAEBEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public AAELFGADGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FGAGMPBGLHN : DKNHFINLNJP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType DIGMLIFCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7CA6C80", Offset = "0x7CA6080", VA = "0x187CA6C80", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6F30", Offset = "0x7CA6330", VA = "0x187CA6F30", Slot = "5")]
	public void IADNDFKPIAL(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6CB0", Offset = "0x7CA60B0", VA = "0x187CA6CB0", Slot = "6")]
	public void FDGGOKJNNOI(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CA71B0", Offset = "0x7CA65B0", VA = "0x187CA71B0", Slot = "7")]
	public void KJOIADCMHHI(GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FGAGMPBGLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GNIDACLNALA : DKNHFINLNJP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType DIGMLIFCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA8320", Offset = "0x7CA7720", VA = "0x187CA8320", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA85D0", Offset = "0x7CA79D0", VA = "0x187CA85D0", Slot = "5")]
	public void IADNDFKPIAL(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8350", Offset = "0x7CA7750", VA = "0x187CA8350", Slot = "6")]
	public void FDGGOKJNNOI(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8850", Offset = "0x7CA7C50", VA = "0x187CA8850", Slot = "7")]
	public void KJOIADCMHHI(GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public GNIDACLNALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BFKJCLAPFKJ : DKNHFINLNJP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType DIGMLIFCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2320", Offset = "0x7CA1720", VA = "0x187CA2320", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CA25D0", Offset = "0x7CA19D0", VA = "0x187CA25D0", Slot = "5")]
	public void IADNDFKPIAL(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2350", Offset = "0x7CA1750", VA = "0x187CA2350", Slot = "6")]
	public void FDGGOKJNNOI(EntityQuery NANKCCKFFLO, GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2850", Offset = "0x7CA1C50", VA = "0x187CA2850", Slot = "7")]
	public void KJOIADCMHHI(GJBDMCKPJAO BGCLOEPMJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public BFKJCLAPFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class MGGLLPJGMEF : IEAMNHGIGNJ, JFNILPFMLLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PEDBLHEMBDD DMMOIDHGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private KHHPLHLGOOL ONAMGPLOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private AMGLOGKJDJF KLDOGAEBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, PELJOEEFNHI adapter)> EJINELPHPOF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8290", Offset = "0x7CB7690", VA = "0x187CB8290", Slot = "15")]
	public virtual void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8320", Offset = "0x7CB7720", VA = "0x187CB8320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8110", Offset = "0x7CB7510", VA = "0x187CB8110")]
	private void FACHFAOPHAA(EntityQueryDesc BPFCFAJBNGP, PELJOEEFNHI OJJLJCJKJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8550", Offset = "0x7CB7950", VA = "0x187CB8550", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
	public MGGLLPJGMEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class FHNLBAPBGHF : IEAMNHGIGNJ, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class PGMCAOINDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery ALFKKJEGNKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery HPHDGCNHPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery GHLCIOAGOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery LACMCNENPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery HPFHHMKMDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery MNJOGOIFGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery MEPLNJEKPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DKNHFINLNJP HJJLBFBEBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType JNFMOGJFBHE;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PGMCAOINDHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PEDBLHEMBDD DMMOIDHGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AMGLOGKJDJF KLDOGAEBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KHHPLHLGOOL ONAMGPLOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<PGMCAOINDHE> EJINELPHPOF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7940", Offset = "0x7CA6D40", VA = "0x187CA7940", Slot = "14")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CA79D0", Offset = "0x7CA6DD0", VA = "0x187CA79D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7B50", Offset = "0x7CA6F50", VA = "0x187CA7B50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7D60", Offset = "0x7CA7160", VA = "0x187CA7D60")]
	private void PAOEKNIHDJD(PGMCAOINDHE OAIILONFKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA7200", Offset = "0x7CA6600", VA = "0x187CA7200")]
	private void FACHFAOPHAA(DKNHFINLNJP HJJLBFBEBGK, ComponentType AFLHDBFPFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
	public FHNLBAPBGHF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct OPEPHEGPJCK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct EMPKIFCEPCK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct BGAODMJEPOH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(AMGLOGKJDJF), new string[] { })]
public class KAKMKHMIOHC : AMGLOGKJDJF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PDIICNIPGKM MMDFFAAPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PDIICNIPGKM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KAKMKHMIOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(NKEGDGACPIC), new string[] { })]
public class CJOIAFLKGPL : NKEGDGACPIC, FHLBDFLOGEB, DNHLMEDMKFA, JAPHOPEKBNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private ELBNKBHBHAE PAOPDPDOEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private PEDBLHEMBDD DMMOIDHGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private GKJIAFBFJDA AGJHJAFADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity MKJFGHEJAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private POFBMACAHHC LEBGJHLCEJG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2FC0", Offset = "0x7CA23C0", VA = "0x187CA2FC0", Slot = "4")]
	public bool OPMFINLAIGN(NLJNHNAFJHN LAOCDNNIMLF, EFACPNDLDKE OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2B60", Offset = "0x7CA1F60", VA = "0x187CA2B60", Slot = "5")]
	public POFBMACAHHC BHEDPNBFEIJ()
	{
		return default(POFBMACAHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2EB0", Offset = "0x7CA22B0", VA = "0x187CA2EB0", Slot = "6")]
	public void NAOFHPCNMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CA2E20", Offset = "0x7CA2220", VA = "0x187CA2E20", Slot = "7")]
	private void FNKOKEAHKOA(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x110A8A0", Offset = "0x1109CA0", VA = "0x18110A8A0", Slot = "8")]
	private void CKBMOLKFEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CJOIAFLKGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BOCLFBKNELP), new string[] { })]
public class JDKKPJPIKHP : BOCLFBKNELP
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB11D0", Offset = "0x7CB05D0", VA = "0x187CB11D0", Slot = "4")]
	public void JPJBJPLJGOJ(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1060", Offset = "0x7CB0460", VA = "0x187CB1060", Slot = "5")]
	public void FFINCBHAEDO(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1110", Offset = "0x7CB0510", VA = "0x187CB1110", Slot = "6")]
	public ComponentSystemBase HDCCNHMGFFI(World PAOPDPDOEOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1250", Offset = "0x7CB0650", VA = "0x187CB1250", Slot = "7")]
	public void MFIDENLCDAC(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1000", Offset = "0x7CB0400", VA = "0x187CB1000", Slot = "8")]
	public void BDMIHAPAHOL(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CB10B0", Offset = "0x7CB04B0", VA = "0x187CB10B0", Slot = "9")]
	public void HCDADFHEHJB(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1160", Offset = "0x7CB0560", VA = "0x187CB1160", Slot = "10")]
	public void JGGPICOIBME(World PAOPDPDOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0800", Offset = "0x7CAFC00", VA = "0x187CB0800", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> AHHDEHKKOGF()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public JDKKPJPIKHP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct FIIPMDCNNGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct JOFBGBOBBCN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OBIDGDGKOHG : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OEONGFIBELC NKDDHEIMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA7A0", Offset = "0x7CB9BA0", VA = "0x187CBA7A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA730", Offset = "0x7CB9B30", VA = "0x187CBA730", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public OBIDGDGKOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct AHOPOBHPBHG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public POFBMACAHHC IBDLLPLCIAN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static AHOPOBHPBHG HIHFKEJHDAH(POFBMACAHHC PAOMPCHHBKF)
	{
		return default(AHOPOBHPBHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ENBBCAFFCHP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GEHONHPBHEG JIICPEKJMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4170", Offset = "0x7CA3570", VA = "0x187CA4170", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public ENBBCAFFCHP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct EEJCBJHMEHI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct KEDEEIIKOBD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LAKJFHCHGBH NCDIHIHPBFM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static KEDEEIIKOBD HIHFKEJHDAH(LAKJFHCHGBH PAOMPCHHBKF)
	{
		return default(KEDEEIIKOBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct KGMIBJENLOL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public POFBMACAHHC IBDLLPLCIAN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static KGMIBJENLOL HIHFKEJHDAH(POFBMACAHHC PAOMPCHHBKF)
	{
		return default(KGMIBJENLOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EIEMCOBHBKC : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GOBGNEEINFF MHHMEMKBINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4090", Offset = "0x7CA3490", VA = "0x187CA4090", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4020", Offset = "0x7CA3420", VA = "0x187CA4020", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public EIEMCOBHBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FEBPJIBBGHI : IGGMPMGMDMJ, OEONGFIBELC, HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DEPAGOGAGPE CIBMKDGKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCDFED0", Offset = "0xCDF2D0", VA = "0x180CDFED0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(DEPAGOGAGPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FGKIPPAJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7C0", Offset = "0xBBABC0", VA = "0x180BBB7C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 OCNIPBHKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x104DEF0", Offset = "0x104D2F0", VA = "0x18104DEF0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6BE0", Offset = "0x7CA5FE0", VA = "0x187CA6BE0")]
	public FEBPJIBBGHI(UniformTRS EMGJFNJDKNN, KDMKMFHLINI GEFLCBDBKHP, float CGHLPACFJDK, float3 PPJGCFONNGD, ADLIHGEBFFL IKDHIAHCLAA, MCPAODJHNLK EEDFBMGEIMB, DEPAGOGAGPE DKBOLAGDDFJ, float3 PKJEALNFHFD, bool GABPKPPAJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6B90", Offset = "0x7CA5F90", VA = "0x187CA6B90", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IGDJLJHEFHJ : IGGMPMGMDMJ, GOBGNEEINFF, HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<KOLCMGJNCCI> FKHCMIPLAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JAKCDADELOK OPJDOLNIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float PFKNBJJIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int CDJCKJJELLM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GDAAMBEPHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFE00", Offset = "0x7CAF200", VA = "0x187CAFE00", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KHDNGDAAEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFE20", Offset = "0x7CAF220", VA = "0x187CAFE20", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HJHODHKAPEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFE10", Offset = "0x7CAF210", VA = "0x187CAFE10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CEICEBMGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD37CA0", Offset = "0xD370A0", VA = "0x180D37CA0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float IDLDMKGGKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC47150", Offset = "0xC46550", VA = "0x180C47150", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BHOGBPPACME
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xECF790", Offset = "0xECEB90", VA = "0x180ECF790", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFD50", Offset = "0x7CAF150", VA = "0x187CAFD50")]
	public IGDJLJHEFHJ(UniformTRS EMGJFNJDKNN, KDMKMFHLINI GEFLCBDBKHP, float CGHLPACFJDK, float3 PPJGCFONNGD, ADLIHGEBFFL IKDHIAHCLAA, MCPAODJHNLK EEDFBMGEIMB, JAKCDADELOK OPJDOLNIGOE, float PFKNBJJIEND, int CDJCKJJELLM, NativeArray<KOLCMGJNCCI> FKHCMIPLAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1065CE0", Offset = "0x10650E0", VA = "0x181065CE0", Slot = "33")]
	public NativeArray<KOLCMGJNCCI> GetNativeCurvePoints()
	{
		return default(NativeArray<KOLCMGJNCCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFC90", Offset = "0x7CAF090", VA = "0x187CAFC90", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HNKBLDNNNHL : HBDMCIMDLLK, OEONGFIBELC, HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<HKOELKKOBKF, DEPAGOGAGPE> PHJHHJHDINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DEPAGOGAGPE DKBOLAGDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool GABPKPPAJFH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private DEPAGOGAGPE DLFDNCLIIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9E8570", Offset = "0x9E7970", VA = "0x1809E8570", Slot = "28")]
		get
		{
			return default(DEPAGOGAGPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool FNJBECKMDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDF1F70", Offset = "0xDF1370", VA = "0x180DF1F70", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 OCNIPBHKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7CADDF0", Offset = "0x7CAD1F0", VA = "0x187CADDF0", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CADDD0", Offset = "0x7CAD1D0", VA = "0x187CADDD0")]
	public HNKBLDNNNHL(NLJNHNAFJHN GIIPELIILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD740", Offset = "0x7CACB40", VA = "0x187CAD740", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CAD790", Offset = "0x7CACB90", VA = "0x187CAD790", Slot = "26")]
	public override void LFKOACHICEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ANBHEPLGBJN : EHFLILOMBNF, GEHONHPBHEG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject OECHIKEMPKC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject BNJNOHCALEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA19A0", Offset = "0x7CA0DA0", VA = "0x187CA19A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PLBPIALOLIB ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CA18A0", Offset = "0x7CA0CA0", VA = "0x187CA18A0", Slot = "15")]
		get
		{
			return default(PLBPIALOLIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PKFKFDHPGGD DNLDOFIGLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CA1E60", Offset = "0x7CA1260", VA = "0x187CA1E60", Slot = "16")]
		get
		{
			return default(PKFKFDHPGGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1D10", Offset = "0x7CA1110", VA = "0x187CA1D10")]
	public ANBHEPLGBJN(NLJNHNAFJHN LAOCDNNIMLF, bool IKLCMOFGPKN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1A30", Offset = "0x7CA0E30", VA = "0x187CA1A30")]
	public void KBCFPPDNIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA18A0", Offset = "0x7CA0CA0", VA = "0x187CA18A0")]
	protected PLBPIALOLIB EDPNIMOKHHJ()
	{
		return default(PLBPIALOLIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1BC0", Offset = "0x7CA0FC0", VA = "0x187CA1BC0")]
	private static bool LDPBOIPIMFL(NLJNHNAFJHN PACJNDHPPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CA1870", Offset = "0x7CA0C70", VA = "0x187CA1870", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MFHHEKDEJLO : HBDMCIMDLLK, GOBGNEEINFF, HKIAOKEMAMI, IDisposable, OMOHOGJENME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<KOLCMGJNCCI> FKHCMIPLAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool PECLHCMLFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BDFLHOODOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float PFKNBJJIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int CDJCKJJELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool PCLHPHBLNEH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NELNHAIGFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xBEB240", Offset = "0xBEA640", VA = "0x180BEB240", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool JHNFFBPNMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA16550", Offset = "0xA15950", VA = "0x180A16550", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float FNKDKJDGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xFD8540", Offset = "0xFD7940", VA = "0x180FD8540", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int IFICDEIELKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCDFED0", Offset = "0xCDF2D0", VA = "0x180CDFED0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CPMFKNGLNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7C0", Offset = "0xBBABC0", VA = "0x180BBB7C0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int NGMBLKLCKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8090", Offset = "0x7CB7490", VA = "0x187CB8090", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int BENHLPFGBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7C80", Offset = "0x7CB7080", VA = "0x187CB7C80", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7CB80E0", Offset = "0x7CB74E0", VA = "0x187CB80E0")]
	public MFHHEKDEJLO(NLJNHNAFJHN GIIPELIILIO, [Optional] NativeList<KOLCMGJNCCI> FKHCMIPLAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7FB0", Offset = "0x7CB73B0", VA = "0x187CB7FB0", Slot = "26")]
	public override void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7990", Offset = "0x7CB6D90", VA = "0x187CB7990", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7A80", Offset = "0x7CB6E80", VA = "0x187CB7A80", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7930", Offset = "0x7CB6D30", VA = "0x187CB7930")]
	public void BPEBJEBFGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7D70", Offset = "0x7CB7170", VA = "0x187CB7D70", Slot = "34")]
	public NativeArray<KOLCMGJNCCI> GetNativeCurvePoints()
	{
		return default(NativeArray<KOLCMGJNCCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7CB77E0", Offset = "0x7CB6BE0", VA = "0x187CB77E0", Slot = "35")]
	private Vector3 BNBFIJIAPAK(int MLHFFBNEEHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7CB80B0", Offset = "0x7CB74B0", VA = "0x187CB80B0", Slot = "36")]
	private Quaternion PJHCGNLBPBJ(int MLHFFBNEEHM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7AE0", Offset = "0x7CB6EE0", VA = "0x187CB7AE0", Slot = "37")]
	private float EMLHIFDKFNB(int MLHFFBNEEHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CB7F40", Offset = "0x7CB7340", VA = "0x187CB7F40")]
	private NativeArray<Entity> HCNPDKDLHLH()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class GOEOEIJOHGO : ELFBCEFHHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7CA88A0", Offset = "0x7CA7CA0", VA = "0x187CA88A0", Slot = "15")]
	protected override ComponentSystemBase IFCNJICDLFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8CC0", Offset = "0x7CA80C0", VA = "0x187CA8CC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8CD0", Offset = "0x7CA80D0", VA = "0x187CA8CD0")]
	public GOEOEIJOHGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[IIMNOBJEEED]
public sealed class LHMOOGBJOIE : HGBMKHJBHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery AEDIAAGOHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery CPEACLPECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery ENIBALFBAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery PGIOOAMAKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery AHLMPLHLECB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6B40", Offset = "0x7CB5F40", VA = "0x187CB6B40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6EA0", Offset = "0x7CB62A0", VA = "0x187CB6EA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6580", Offset = "0x7CB5980", VA = "0x187CB6580")]
	private void CIECHGMBNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6760", Offset = "0x7CB5B60", VA = "0x187CB6760")]
	private void CPPCDBDDAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6920", Offset = "0x7CB5D20", VA = "0x187CB6920")]
	private void IGKNKODFBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6480", Offset = "0x7CB5880", VA = "0x187CB6480")]
	private void BGJEJIIJNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6EE0", Offset = "0x7CB62E0", VA = "0x187CB6EE0")]
	private void PLJCGCBAEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6AF0", Offset = "0x7CB5EF0", VA = "0x187CB6AF0")]
	private NativeList<Entity> LFJMLIKILCH(NativeArray<Entity> EOFNKKAANKG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6870", Offset = "0x7CB5C70", VA = "0x187CB6870")]
	private NativeList<Entity> EPLBGMELBIE(NativeArray<Entity> EOFNKKAANKG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB68C0", Offset = "0x7CB5CC0", VA = "0x187CB68C0")]
	private void HHIEKCACECF(NativeArray<Entity> EOFNKKAANKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public LHMOOGBJOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[IIMNOBJEEED]
public sealed class PPHIFDABHJC : HGBMKHJBHPG, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery KDOMHPKKIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery BMBMPPOMOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery GHLCIOAGOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NKEGDGACPIC OGKDEFBONEK;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCA80", Offset = "0x7CBBE80", VA = "0x187CBCA80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBD80", Offset = "0x7CBB180", VA = "0x187CBBD80", Slot = "15")]
	public override void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBCC50", Offset = "0x7CBC050", VA = "0x187CBCC50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB3C0", Offset = "0x7CBA7C0", VA = "0x187CBB3C0")]
	private void BOHLCHEIDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CBBDE0", Offset = "0x7CBB1E0", VA = "0x187CBBDE0")]
	private void JPPMPMKDGOD(NativeParallelHashSet<POFBMACAHHC> LNJEDPGHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB6F0", Offset = "0x7CBAAF0", VA = "0x187CBB6F0")]
	private void FMEJCDHOFCP(NativeParallelHashSet<POFBMACAHHC> LNJEDPGHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC470", Offset = "0x7CBB870", VA = "0x187CBC470")]
	private void KEAMCHDFNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC9E0", Offset = "0x7CBBDE0", VA = "0x187CBC9E0")]
	private bool MKAJKGCNKKN(Entity BGFOMMJBGIM, [Out] POFBMACAHHC IBDLLPLCIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7CBC830", Offset = "0x7CBBC30", VA = "0x187CBC830")]
	private bool KOLHDHCPADE(Entity BGFOMMJBGIM, [Out] POFBMACAHHC IBDLLPLCIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public PPHIFDABHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[IIMNOBJEEED]
public sealed class PEELHJEMHAO : HGBMKHJBHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery BHBOBFPJFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery DLIAAJIMNIF;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAE50", Offset = "0x7CBA250", VA = "0x187CBAE50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAFA0", Offset = "0x7CBA3A0", VA = "0x187CBAFA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CBAB50", Offset = "0x7CB9F50", VA = "0x187CBAB50")]
	private void JPPMPMKDGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA860", Offset = "0x7CB9C60", VA = "0x187CBA860")]
	private void FMEJCDHOFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public PEELHJEMHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FBNLDBJGCKG : HGBMKHJBHPG, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct CLGJPENBIKA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob GFFOEFGGFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob BDNHCDIOADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob NLAEFDJNNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob BBMJCNNJLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle FELOEBLPPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<KGMIBJENLOL> FAMOLHGNDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> NNEGNDELMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> JIPKFLNPFJI;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3180", Offset = "0x7CA2580", VA = "0x187CA3180", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CA30A0", Offset = "0x7CA24A0", VA = "0x187CA30A0")]
		private void ADAIBAMLDMJ(EntityQueryInJob NANKCCKFFLO, NativeList<Entity> FGCOLJPLHLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct CDEMFLBGIGB : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle FELOEBLPPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<KGMIBJENLOL> FAMOLHGNDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> FGCOLJPLHLP;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA2910", Offset = "0x7CA1D10", VA = "0x187CA2910", Slot = "4")]
		public void Execute(ArchetypeChunk NPMCFBCPDBP, int FMPALOFNOEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct MIHAJENDABF : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle FELOEBLPPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> AOPJHPCMAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<KEDEEIIKOBD> AGDGHLFMHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<AHOPOBHPBHG> BLFJKPGDOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<KGMIBJENLOL> DHNCLAPAEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> NKKFGIAHHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<KEDEEIIKOBD> NFAJNIEMGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<POFBMACAHHC> LOMGPGFKNEG;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8740", Offset = "0x7CB7B40", VA = "0x187CB8740", Slot = "4")]
		public void Execute(ArchetypeChunk NPMCFBCPDBP, int FMPALOFNOEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery GFFOEFGGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery BDNHCDIOADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery NLAEFDJNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery BBMJCNNJLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery ALEGIBEKACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery IMAMKHIOGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery GIAMHAPOADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NKEGDGACPIC HOJLGIPHFLE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6280", Offset = "0x7CA5680", VA = "0x187CA6280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5000", Offset = "0x7CA4400", VA = "0x187CA5000", Slot = "15")]
	public override void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6800", Offset = "0x7CA5C00", VA = "0x187CA6800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5C80", Offset = "0x7CA5080", VA = "0x187CA5C80")]
	private void NDGFIIJEBOM(NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN, int AGHHMMNLEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5060", Offset = "0x7CA4460", VA = "0x187CA5060")]
	private void JAPOAICGNAB(NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN, int OABEMHNKJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5840", Offset = "0x7CA4C40", VA = "0x187CA5840")]
	private void LMNJANGNGPC(NativeParallelHashSet<POFBMACAHHC> OGKEEFCBDBN, int BLNIPCCNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA54B0", Offset = "0x7CA48B0", VA = "0x187CA54B0")]
	private void KKDANACCMLF(NativeParallelHashSet<POFBMACAHHC> LNJEDPGHIHO, int IPMOICOMJPO, int KNDDIIKABAE, int NNNOBAFJLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E50", Offset = "0x7CA4250", VA = "0x187CA4E50")]
	private void ABPHADOLABF(Entity PMFEPJPCLAE, LAKJFHCHGBH JBGLKCKLCPM, POFBMACAHHC IBDLLPLCIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public FBNLDBJGCKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class INGGIIDNBOA : HGBMKHJBHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery BEAPAHEEOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery BDIGFCCBODE;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0030", Offset = "0x7CAF430", VA = "0x187CB0030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0270", Offset = "0x7CAF670", VA = "0x187CB0270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public INGGIIDNBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class POHKNJMOAFD : HGBMKHJBHPG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct AAPGECKGGFH : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery NFDNACPPFGP;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB050", Offset = "0x7CBA450", VA = "0x187CBB050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB190", Offset = "0x7CBA590", VA = "0x187CBB190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public POHKNJMOAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IIMNOBJEEED]
internal class FBLPLBHAHOI : HGBMKHJBHPG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class MPDEGAOIPPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery AMHAHODPDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery JAFAKFKPKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PIGPOFEEKPD OJOPCOJDIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType CHOOMJLBGHN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MPDEGAOIPPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void PIGPOFEEKPD(NativeArray<LAKJFHCHGBH> PAOMPCHHBKF, GJBDMCKPJAO BGCLOEPMJGN);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<MPDEGAOIPPH> EJINELPHPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private KHHPLHLGOOL ONAMGPLOODL;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4520", Offset = "0x7CA3920", VA = "0x187CA4520", Slot = "15")]
	public override void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4720", Offset = "0x7CA3B20", VA = "0x187CA4720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA48B0", Offset = "0x7CA3CB0", VA = "0x187CA48B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x36843C0", Offset = "0x36837C0", VA = "0x1836843C0")]
	private void FACHFAOPHAA<T>(PIGPOFEEKPD OJOPCOJDIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA41E0", Offset = "0x7CA35E0", VA = "0x187CA41E0")]
	private static void DKOPPFBBPDO(NativeArray<LAKJFHCHGBH> OGLMLGNLLKL, GJBDMCKPJAO CHNGJIDGPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4380", Offset = "0x7CA3780", VA = "0x187CA4380")]
	private static void FPGJPLPAHOB(NativeArray<LAKJFHCHGBH> OGLMLGNLLKL, GJBDMCKPJAO CHNGJIDGPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4580", Offset = "0x7CA3980", VA = "0x187CA4580")]
	private static void NKHPMNDPHPK(NativeArray<LAKJFHCHGBH> OGLMLGNLLKL, GJBDMCKPJAO CHNGJIDGPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public FBLPLBHAHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IIMNOBJEEED]
public sealed class LEIPJCECFGJ : HGBMKHJBHPG
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery NANKCCKFFLO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6030", Offset = "0x7CB5430", VA = "0x187CB6030", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct HJBMNKLGFOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS EMGJFNJDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData BMDEEOEJLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public DEPAGOGAGPE DKBOLAGDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PKJEALNFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool GABPKPPAJFH;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GGGEECODDOE(Lifetime.LoadInstance)]
public struct EJBBIDGMLJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity GCOBHCDOBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> AABOKJPOACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> IMABEJCIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<HJBMNKLGFOI> OMLAKNPHGKC;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7CA40E0", Offset = "0x7CA34E0", VA = "0x187CA40E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(NGCNFJOGFIO), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class NGCNFJOGFIO : JFNILPFMLLH, BAEPLJFAONJ, DNHLMEDMKFA, JAPHOPEKBNC
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NLEPEFMEDDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NGCNFJOGFIO GEFLCBDBKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool NHHBDBECFLE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1729F40", Offset = "0x1729340", VA = "0x181729F40")]
		public NLEPEFMEDDH(NGCNFJOGFIO GEFLCBDBKHP, bool NHHBDBECFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA340", Offset = "0x7CB9740", VA = "0x187CBA340")]
		public Queue<JHGLLIPKHAJ>.Enumerator PMMOLBDEIOM()
		{
			return default(Queue<JHGLLIPKHAJ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA000", Offset = "0x7CB9400", VA = "0x187CBA000", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private GKJIAFBFJDA KPDEAGMHCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private GNBNLDPGOMJ GJHJEBBOPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<KOLCMGJNCCI>> PLDPFHGJMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> CGMKOPPPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<LAKJFHCHGBH> NJNLIKNEDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private OFCPOIENKLP<JHGLLIPKHAJ> OBFLCJCPCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OFCPOIENKLP<EJBBIDGMLJN> DMCHHBJBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private OFCPOIENKLP<INMDMKDGJDN> PHDNMBCOGCL;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9910", Offset = "0x7CB8D10", VA = "0x187CB9910", Slot = "4")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9D60", Offset = "0x7CB9160", VA = "0x187CB9D60")]
	public void NHNIIGIAIFP(NativeList<KOLCMGJNCCI> IPCOLDHFCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9BA0", Offset = "0x7CB8FA0", VA = "0x187CB9BA0")]
	public void MIDCBJFBCMM(Entity GEFLCBDBKHP, [In] OAGGALGHDAH<GameObject> LNELACABHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9B10", Offset = "0x7CB8F10", VA = "0x187CB9B10")]
	public void JEACAPOFGDE(NativeList<LAKJFHCHGBH> OGLMLGNLLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9230", Offset = "0x7CB8630", VA = "0x187CB9230")]
	public void HCDADFHEHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9460", Offset = "0x7CB8860", VA = "0x187CB9460")]
	public void HOECKCBBIFI(CHLPKMIEKPP BIGODBDFGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9ED0", Offset = "0x7CB92D0", VA = "0x187CB9ED0")]
	public JobHandle ODFMPNJAKPC([In] JHGLLIPKHAJ FGEBHLNNMNH, JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9E30", Offset = "0x7CB9230", VA = "0x187CB9E30")]
	public JobHandle ODFMPNJAKPC([In] EJBBIDGMLJN FGEBHLNNMNH, JobHandle LLKBKEKCHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7981E20", Offset = "0x7981220", VA = "0x187981E20")]
	public NLEPEFMEDDH JDFFGAMHMMD(bool NHHBDBECFLE)
	{
		return default(NLEPEFMEDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9D10", Offset = "0x7CB9110", VA = "0x187CB9D10")]
	public EPABPCBACNJ<EJBBIDGMLJN> NDBEEIJOCIF()
	{
		return default(EPABPCBACNJ<EJBBIDGMLJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8F50", Offset = "0x7CB8350", VA = "0x187CB8F50")]
	public EPABPCBACNJ<INMDMKDGJDN> EAGGEBOKCIB()
	{
		return default(EPABPCBACNJ<INMDMKDGJDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8FA0", Offset = "0x7CB83A0", VA = "0x187CB8FA0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8E70", Offset = "0x7CB8270", VA = "0x187CB8E70", Slot = "5")]
	public void AECAJPPNPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CB91C0", Offset = "0x7CB85C0", VA = "0x187CB91C0", Slot = "6")]
	private void FNKOKEAHKOA(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x10FD6F0", Offset = "0x10FCAF0", VA = "0x1810FD6F0", Slot = "7")]
	private void CKBMOLKFEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NGCNFJOGFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GAHOGGBMPPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS EMGJFNJDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData BMDEEOEJLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AJDJHPALEJE OPJDOLNIGOE;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[GGGEECODDOE(Lifetime.LoadInstance)]
public struct JHGLLIPKHAJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity GCOBHCDOBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> EOFNKKAANKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> AABOKJPOACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> IMABEJCIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<OIJNMGBLDKP> NIOMKCGLHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<KOLCMGJNCCI> IPCOLDHFCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<GAHOGGBMPPM> LICPFJMAJOO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1380", Offset = "0x7CB0780", VA = "0x187CB1380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7CB12B0", Offset = "0x7CB06B0", VA = "0x187CB12B0")]
	public void BKMLDGFOOLL(bool NHHBDBECFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(OCNIMOCFKGC), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class OCNIMOCFKGC : PGGDGFFOEAH, DNHLMEDMKFA, JAPHOPEKBNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private NGCNFJOGFIO CHIKGHLEJBI;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA840", Offset = "0x7CB9C40", VA = "0x187CBA840", Slot = "4")]
	public void JCBDOFPJAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA7F0", Offset = "0x7CB9BF0", VA = "0x187CBA7F0", Slot = "5")]
	private void FNKOKEAHKOA(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x10CF690", Offset = "0x10CEA90", VA = "0x1810CF690", Slot = "6")]
	private void CKBMOLKFEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public OCNIMOCFKGC()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : HGBMKHJBHPG, JFNILPFMLLH
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
			public NativeParallelHashMap<int, DEPAGOGAGPE> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<HJBMNKLGFOI> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7CA8CE0", Offset = "0x7CA80E0", VA = "0x187CA8CE0", Slot = "4")]
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
			public NativeArray<KOLCMGJNCCI> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<OIJNMGBLDKP> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<GAHOGGBMPPM> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9080", Offset = "0x7CA8480", VA = "0x187CA9080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CA3200", Offset = "0x7CA2600", VA = "0x187CA3200", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7CBCD00", Offset = "0x7CBC100", VA = "0x187CBCD00")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0x7CBCD20", Offset = "0x7CBC120", VA = "0x187CBCD20")]
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
				float3 GIBHKOHFEBL(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x7CB70B0", Offset = "0x7CB64B0", VA = "0x187CB70B0", Slot = "5")]
				public float3 LFEBIAEFJCF(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x7CB7070", Offset = "0x7CB6470", VA = "0x187CB7070", Slot = "4")]
				public float3 GIBHKOHFEBL(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x7CBA400", Offset = "0x7CB9800", VA = "0x187CBA400", Slot = "4")]
				public float3 GIBHKOHFEBL(quaternion rotation)
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
			public NativeArray<OIJNMGBLDKP> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<KOLCMGJNCCI> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9F60", Offset = "0x7CA9360", VA = "0x187CA9F60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7CAB1B0", Offset = "0x7CAA5B0", VA = "0x187CAB1B0")]
			private void LEBELNJLLDH(NativeList<PointSrcData> srcData, NativeList<KOLCMGJNCCI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7CAA5C0", Offset = "0x7CA99C0", VA = "0x187CAA5C0")]
			public static Vector3 GFIILBGPJNN(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7CAA9D0", Offset = "0x7CA9DD0", VA = "0x187CAA9D0")]
			public static quaternion GLCFGDDICBL(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7CAD480", Offset = "0x7CAC880", VA = "0x187CAD480")]
			private static quaternion PFHMPDFPGEF(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7CAAFE0", Offset = "0x7CAA3E0", VA = "0x187CAAFE0")]
			private static float3 KENBKAPGPPL(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC240", Offset = "0x7CAB640", VA = "0x187CAC240")]
			private static quaternion LJIAKFKMGAH(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7CAABC0", Offset = "0x7CA9FC0", VA = "0x187CAABC0")]
			private static KOLCMGJNCCI IPBIANDILGP(int idx, NativeList<PointSrcData> srcData)
			{
				return default(KOLCMGJNCCI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE390", Offset = "0x3DDD790", VA = "0x183DDE390")]
			private void ADPGBDHHJDN<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC670", Offset = "0x7CABA70", VA = "0x187CAC670")]
			private void OMHBNEMACFP(NativeList<PointSrcData> sourcePoints, NativeList<KOLCMGJNCCI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9980", Offset = "0x7CA8D80", VA = "0x187CA9980")]
			public static float EBNENDNEDLC(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC480", Offset = "0x7CAB880", VA = "0x187CAC480")]
			private static quaternion NLJJCFMEPKG(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC2D0", Offset = "0x7CAB6D0", VA = "0x187CAC2D0")]
			private static KOLCMGJNCCI LNMGELNKEPP(PointSrcData point)
			{
				return default(KOLCMGJNCCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC3F0", Offset = "0x7CAB7F0", VA = "0x187CAC3F0")]
			private static KOLCMGJNCCI LNMGELNKEPP(float3 pos, quaternion rot, float radius)
			{
				return default(KOLCMGJNCCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7CAAB20", Offset = "0x7CA9F20", VA = "0x187CAAB20")]
			private static bool IDGJEJLAHOM(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7CAAA50", Offset = "0x7CA9E50", VA = "0x187CAAA50")]
			private static float3 HDMGMKCCIOO(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7CAAE30", Offset = "0x7CAA230", VA = "0x187CAAE30")]
			public static float3 JIPNFGLOFAM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC090", Offset = "0x7CAB490", VA = "0x187CAC090")]
			public static float3 LFEBIAEFJCF(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9B00", Offset = "0x7CA8F00", VA = "0x187CA9B00")]
			private static quaternion EEGOKFNFIOE(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7CA97A0", Offset = "0x7CA8BA0", VA = "0x187CA97A0")]
			private static float BHCMIAKLOCM(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7CBE5A0", Offset = "0x7CBD9A0", VA = "0x187CBE5A0")]
			private void AOLJGBEOMDC(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7CBE680", Offset = "0x7CBDA80", VA = "0x187CBE680", Slot = "4")]
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
			public NativeList<KOLCMGJNCCI> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7CC0740", Offset = "0x7CBFB40", VA = "0x187CC0740")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7CC07A0", Offset = "0x7CBFBA0", VA = "0x187CC07A0", Slot = "4")]
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
			public NativeList<KOLCMGJNCCI> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7CC06E0", Offset = "0x7CBFAE0", VA = "0x187CC06E0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7CC0730", Offset = "0x7CBFB30", VA = "0x187CC0730", Slot = "4")]
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
			public NativeList<HJBMNKLGFOI> data;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7CA93C0", Offset = "0x7CA87C0", VA = "0x187CA93C0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9580", Offset = "0x7CA8980", VA = "0x187CA9580", Slot = "4")]
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
			public NativeList<OIJNMGBLDKP> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<GAHOGGBMPPM> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9590", Offset = "0x7CA8990", VA = "0x187CA9590")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7CA9790", Offset = "0x7CA8B90", VA = "0x187CA9790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CC02B0", Offset = "0x7CBF6B0", VA = "0x187CC02B0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7CC06D0", Offset = "0x7CBFAD0", VA = "0x187CC06D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly LMKAPNBAFDO log;

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
		private FCBOCGKDMAN replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private GKJIAFBFJDA objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NGCNFJOGFIO bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private DJMDMLFLCFB ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDB00", Offset = "0x7CBCF00", VA = "0x187CBDB00", Slot = "15")]
		public override void InitReferences(KKNBMHIKNAE services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFF60", Offset = "0x7CBF360", VA = "0x187CBFF60", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CC0050", Offset = "0x7CBF450", VA = "0x187CC0050", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CC00B0", Offset = "0x7CBF4B0", VA = "0x187CC00B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE260", Offset = "0x7CBD660", VA = "0x187CBE260")]
		private JobHandle KLDJFDDPBOL(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CBEBD0", Offset = "0x7CBDFD0", VA = "0x187CBEBD0")]
		private JobHandle NGLBDNAEOLJ(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDA60", Offset = "0x7CBCE60", VA = "0x187CBDA60")]
		private JobHandle OOEGBBLICCC(NativeArray<int> pointCount, NativeList<KOLCMGJNCCI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD360", Offset = "0x7CBC760", VA = "0x187CBD360")]
		private JobHandle IJBJIMEPLPK(NativeList<KOLCMGJNCCI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF3A0", Offset = "0x7CBE7A0", VA = "0x187CBF3A0")]
		private JobHandle ODECLLBFECM(EntityQuery query, NativeList<OIJNMGBLDKP> splinePointRanges, NativeList<KOLCMGJNCCI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD120", Offset = "0x7CBC520", VA = "0x187CBD120")]
		private JobHandle IAFOOMODIGM(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD240", Offset = "0x7CBC640", VA = "0x187CBD240")]
		private JobHandle IAMJEJFFNOJ(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDBA0", Offset = "0x7CBCFA0", VA = "0x187CBDBA0")]
		private JobHandle JGENDKIHOCN(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HJBMNKLGFOI> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CBCD70", Offset = "0x7CBC170", VA = "0x187CBCD70")]
		private JobHandle AIGMGEMCPIL(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<OIJNMGBLDKP> splinePointRanges, [Out] NativeList<GAHOGGBMPPM> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE850", Offset = "0x7CBDC50", VA = "0x187CBE850")]
		private JobHandle MJAOCMOPGNF(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD400", Offset = "0x7CBC800", VA = "0x187CBD400")]
		private JobHandle IJLAAJHEEBI(EntityQuery query, NativeList<HJBMNKLGFOI> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDE40", Offset = "0x7CBD240", VA = "0x187CBDE40")]
		private static NativeParallelHashMap<int, DEPAGOGAGPE> KKHABKHIKGK()
		{
			return default(NativeParallelHashMap<int, DEPAGOGAGPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF870", Offset = "0x7CBEC70", VA = "0x187CBF870")]
		private JobHandle OHPHLDLMBLF(EntityQuery query, NativeList<OIJNMGBLDKP> splinePointRanges, NativeList<KOLCMGJNCCI> splinePointData, NativeList<GAHOGGBMPPM> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE770", Offset = "0x7CBDB70", VA = "0x187CBE770")]
		private JobHandle MBJFHEEBPDP(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDA60", Offset = "0x7CBCE60", VA = "0x187CBDA60")]
		private JobHandle IMNLGKNPFNN(NativeArray<int> pointCount, NativeList<KOLCMGJNCCI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD360", Offset = "0x7CBC760", VA = "0x187CBD360")]
		private JobHandle LEIKNMKKIIM(NativeList<KOLCMGJNCCI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD030", Offset = "0x7CBC430", VA = "0x187CBD030")]
		private JobHandle BGCHOBMNODD(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HJBMNKLGFOI> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF290", Offset = "0x7CBE690", VA = "0x187CBF290")]
		private JobHandle NNCINPGIJAK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<OIJNMGBLDKP> ranges, NativeList<GAHOGGBMPPM> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD910", Offset = "0x7CBCD10", VA = "0x187CBD910")]
		private JobHandle IMDOOIGCKIO(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFC10", Offset = "0x7CBF010", VA = "0x187CBFC10", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class BOCINNPKOAC : IEAMNHGIGNJ, JFNILPFMLLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NGCNFJOGFIO CHIKGHLEJBI;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7CA28A0", Offset = "0x7CA1CA0", VA = "0x187CA28A0", Slot = "14")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7CA28F0", Offset = "0x7CA1CF0", VA = "0x187CA28F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
	public BOCINNPKOAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class LDNEEFHHHNK : HGBMKHJBHPG, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct ODNHOONCMIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager IBLGEGBFEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private FMDDKGMEHML<T> CLLELHMJGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int COPLIEINKOF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5336A00", Offset = "0x5335E00", VA = "0x185336A00")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5337540", Offset = "0x5336940", VA = "0x185337540")]
		public ODNHOONCMIN(EntityManager IBLGEGBFEIJ, FMDDKGMEHML<T> CLLELHMJGFJ, NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x444EB10", Offset = "0x444DF10", VA = "0x18444EB10")]
		public ODNHOONCMIN<T> PMMOLBDEIOM()
		{
			return default(ODNHOONCMIN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5337480", Offset = "0x5336880", VA = "0x185337480")]
		public bool OOODFKMFOLP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly LMKAPNBAFDO JCIDKFFFAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private GNBNLDPGOMJ GJHJEBBOPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private NGCNFJOGFIO CHIKGHLEJBI;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3B10", Offset = "0x7CB2F10", VA = "0x187CB3B10", Slot = "15")]
	public override void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3B90", Offset = "0x7CB2F90", VA = "0x187CB3B90")]
	public void JGGPICOIBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4450", Offset = "0x7CB3850", VA = "0x187CB4450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1E70", Offset = "0x7CB1270", VA = "0x187CB1E70")]
	private void FKMJLNKEGOJ(INMDMKDGJDN FGEBHLNNMNH, Mesh[] GKNMEGNOFHB, NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x37955E0", Offset = "0x37949E0", VA = "0x1837955E0")]
	private ODNHOONCMIN<T> AKDJDDNAOOF<T>(FMDDKGMEHML<T> CLLELHMJGFJ, NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB) where T : struct
	{
		return default(ODNHOONCMIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB40B0", Offset = "0x7CB34B0", VA = "0x187CB40B0")]
	private void OGAFCAJEKBK(Transform GEFLCBDBKHP, NativeArray<KPJDEFIDHGC> ODBACEABEKC, OAGGALGHDAH<GameObject> HPEPHKOLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7CB15A0", Offset = "0x7CB09A0", VA = "0x187CB15A0")]
	private void DMIADIEIDAH(Transform GEFLCBDBKHP, NativeArray<NFEIDKCJMPO> BEDLJDAFNFN, OAGGALGHDAH<GameObject> HPEPHKOLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1A70", Offset = "0x7CB0E70", VA = "0x187CB1A70")]
	private void FBCMHHHHODO(Transform GEFLCBDBKHP, NativeArray<GLMOJEHANHH> ODLMPIFHHPB, OAGGALGHDAH<GameObject> HPEPHKOLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7CB55D0", Offset = "0x7CB49D0", VA = "0x187CB55D0")]
	private void POELCFIOANJ(Transform GEFLCBDBKHP, NativeArray<OPPBJNNMFNE> GKNMEGNOFHB, Mesh[] BGBMLFGILEL, OAGGALGHDAH<GameObject> HPEPHKOLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1450", Offset = "0x7CB0850", VA = "0x187CB1450")]
	private static void BFNNKNEHILB(NativeParallelHashSet<Entity> EOFNKKAANKG, NativeParallelHashSet<Entity> CKFINBAADJF, NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1390", Offset = "0x7CB0790", VA = "0x187CB1390")]
	private static void AGPOPEAEDKF(NativeList<Entity> ANHMDLEGCDL, NativeArray<EntityRemapUtility.EntityRemapInfo> EDOMNLLHFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7CB2F90", Offset = "0x7CB2390", VA = "0x187CB2F90")]
	private NativeParallelHashMap<Entity, AHOPOBHPBHG> IFIMPMFAEOB(NGCNFJOGFIO.NLEPEFMEDDH EOLFCMMFDBF, EPABPCBACNJ<EJBBIDGMLJN> NKHADJHDHFN, List<GameObject> HPEPHKOLPHM)
	{
		return default(NativeParallelHashMap<Entity, AHOPOBHPBHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3BC0", Offset = "0x7CB2FC0", VA = "0x187CB3BC0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KPKPMOLIIEP(Entity KAGLJHONMPC)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5A10", Offset = "0x7CB4E10", VA = "0x187CB5A10")]
	private void PPAHBABGHLJ(NativeList<Entity> LGCFDEDBCHL, NativeList<Entity> DGNIJIMALHE, NativeParallelHashMap<Entity, AHOPOBHPBHG> BJKFKJFNDBI, NativeList<OIJNMGBLDKP> PJOJGNCAOKM, NativeList<KOLCMGJNCCI> HDOCOGGPECP, NativeList<GAHOGGBMPPM> PLDPFHGJMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3CC0", Offset = "0x7CB30C0", VA = "0x187CB3CC0")]
	private void MPJEANNPLJL(NativeList<Entity> EOFNKKAANKG, NativeList<Entity> AABOKJPOACL, NativeParallelHashMap<Entity, AHOPOBHPBHG> BJKFKJFNDBI, NativeList<HJBMNKLGFOI> OMLAKNPHGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7CA4E40", Offset = "0x7CA4240", VA = "0x187CA4E40")]
	public LDNEEFHHHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class MLBPAEHNIMD : LPNNEIHHKDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS EMGJFNJDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly KDMKMFHLINI GEFLCBDBKHP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject EKMNGIKHMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS BLNJEGMAAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8C50", Offset = "0x7CB8050", VA = "0x187CB8C50", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 HMOAJBDKJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8D80", Offset = "0x7CB8180", VA = "0x187CB8D80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 JHIPGNNDBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8C00", Offset = "0x7CB8000", VA = "0x187CB8C00", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 GEPKMCBKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8B10", Offset = "0x7CB7F10", VA = "0x187CB8B10", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8A70", Offset = "0x7CB7E70", VA = "0x187CB8A70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion DDBKLLGDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8AC0", Offset = "0x7CB7EC0", VA = "0x187CB8AC0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8D30", Offset = "0x7CB8130", VA = "0x187CB8D30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 KLIBFLIBDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8DD0", Offset = "0x7CB81D0", VA = "0x187CB8DD0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 PBHODIDBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8BB0", Offset = "0x7CB7FB0", VA = "0x187CB8BB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 FJBEIACLLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8B60", Offset = "0x7CB7F60", VA = "0x187CB8B60", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7CB8E20", Offset = "0x7CB8220", VA = "0x187CB8E20")]
	public MLBPAEHNIMD(UniformTRS EMGJFNJDKNN, KDMKMFHLINI GEFLCBDBKHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IGGMPMGMDMJ : MLBPAEHNIMD, HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float CGHLPACFJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 PPJGCFONNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ADLIHGEBFFL IKDHIAHCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly MCPAODJHNLK EEDFBMGEIMB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private PLBPIALOLIB BCIIBKBPBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFF60", Offset = "0x7CAF360", VA = "0x187CAFF60", Slot = "17")]
		get
		{
			return default(PLBPIALOLIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS MLLEFIDPCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFE30", Offset = "0x7CAF230", VA = "0x187CAFE30", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float PEJNGLLFHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xBD1EF0", Offset = "0xBD12F0", VA = "0x180BD1EF0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 BMAPHOBFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFF10", Offset = "0x7CAF310", VA = "0x187CAFF10", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private ADLIHGEBFFL NHAPHIKAIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xE1B1E0", Offset = "0xE1A5E0", VA = "0x180E1B1E0", Slot = "21")]
		get
		{
			return default(ADLIHGEBFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MCPAODJHNLK GGHLKOLINGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x12BB820", Offset = "0x12BAC20", VA = "0x1812BB820", Slot = "22")]
		get
		{
			return default(MCPAODJHNLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool IKIKCAHFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NEAIJDEAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFFB0", Offset = "0x7CAF3B0", VA = "0x187CAFFB0")]
	protected IGGMPMGMDMJ(UniformTRS EMGJFNJDKNN, KDMKMFHLINI GEFLCBDBKHP, float CGHLPACFJDK, float3 PPJGCFONNGD, ADLIHGEBFFL IKDHIAHCLAA, MCPAODJHNLK EEDFBMGEIMB)
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
public abstract class EHFLILOMBNF : LPNNEIHHKDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly NLJNHNAFJHN OOGFIGJOHMP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected KDMKMFHLINI HGPAKJHEINP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x10B5250", Offset = "0x10B4650", VA = "0x1810B5250")]
		get
		{
			return default(KDMKMFHLINI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity GAEEFHDEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3480", Offset = "0x7CA2880", VA = "0x187CA3480")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected GKJIAFBFJDA OGNANHHAGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA36F0", Offset = "0x7CA2AF0", VA = "0x187CA36F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected CCJMMFFAIHP CDKACGHEINK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A80", Offset = "0x7CA2E80", VA = "0x187CA3A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected CHIINBBJCCE IBGDJNLLODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3DB0", Offset = "0x7CA31B0", VA = "0x187CA3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject EKMNGIKHMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3450", Offset = "0x7CA2850", VA = "0x187CA3450", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS BLNJEGMAAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x10D9B10", Offset = "0x10D8F10", VA = "0x1810D9B10", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 HMOAJBDKJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3E40", Offset = "0x7CA3240", VA = "0x187CA3E40", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 JHIPGNNDBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3B10", Offset = "0x7CA2F10", VA = "0x187CA3B10", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 GEPKMCBKFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7CA35C0", Offset = "0x7CA29C0", VA = "0x187CA35C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3340", Offset = "0x7CA2740", VA = "0x187CA3340", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion DDBKLLGDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7CA34A0", Offset = "0x7CA28A0", VA = "0x187CA34A0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3CA0", Offset = "0x7CA30A0", VA = "0x187CA3CA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 KLIBFLIBDDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3F30", Offset = "0x7CA3330", VA = "0x187CA3F30", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 PBHODIDBMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA38C0", Offset = "0x7CA2CC0", VA = "0x187CA38C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 FJBEIACLLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3700", Offset = "0x7CA2B00", VA = "0x187CA3700", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xDA8F30", Offset = "0xDA8330", VA = "0x180DA8F30")]
	protected EHFLILOMBNF(NLJNHNAFJHN GIIPELIILIO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7CA3AE0", Offset = "0x7CA2EE0", VA = "0x187CA3AE0")]
	public static PLBPIALOLIB HIHFKEJHDAH(EHFLILOMBNF DEEHPBDAIHI)
	{
		return default(PLBPIALOLIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HFONIHCCGGF
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1840", Offset = "0x7CC0C40", VA = "0x187CC1840")]
	public static void DJNEOEMLOOM(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class ILHGJDIBKDB
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2200", Offset = "0x7CC1600", VA = "0x187CC2200")]
	public static void ICHFEIGGODN(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ, CHLPKMIEKPP HFMOJJEMMEE, GKJIAFBFJDA AGJHJAFADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1EF0", Offset = "0x7CC12F0", VA = "0x187CC1EF0")]
	public static void GKDOPJLOAOL(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ, CHLPKMIEKPP HFMOJJEMMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1C50", Offset = "0x7CC1050", VA = "0x187CC1C50")]
	public static NativeList<Entity> EPLBGMELBIE(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2610", Offset = "0x7CC1A10", VA = "0x187CC2610")]
	public static NativeList<Entity> LFJMLIKILCH(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1C90", Offset = "0x7CC1090", VA = "0x187CC1C90")]
	private static NativeList<Entity> EPLBGMELBIE(NativeArray<Entity> EOFNKKAANKG, EntityManager IBLGEGBFEIJ, bool AJFDOAMGHEC)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class HBDMCIMDLLK : EHFLILOMBNF, HKIAOKEMAMI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float CGHLPACFJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 PPJGCFONNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private ADLIHGEBFFL IKDHIAHCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MCPAODJHNLK EEDFBMGEIMB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager CMICOJMDJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1470", Offset = "0x7CC0870", VA = "0x187CC1470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected ELBNKBHBHAE AEAAPKCBFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1500", Offset = "0x7CC0900", VA = "0x187CC1500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData CGDPFLGHAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1720", Offset = "0x7CC0B20", VA = "0x187CC1720")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private PLBPIALOLIB BCIIBKBPBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3AE0", Offset = "0x7CA2EE0", VA = "0x187CA3AE0", Slot = "17")]
		get
		{
			return default(PLBPIALOLIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float PEJNGLLFHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xEA4540", Offset = "0xEA3940", VA = "0x180EA4540", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 BMAPHOBFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x15569C0", Offset = "0x1555DC0", VA = "0x1815569C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private ADLIHGEBFFL NHAPHIKAIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0", Slot = "21")]
		get
		{
			return default(ADLIHGEBFFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private MCPAODJHNLK GGHLKOLINGE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xC330B0", Offset = "0xC324B0", VA = "0x180C330B0", Slot = "22")]
		get
		{
			return default(MCPAODJHNLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS MLLEFIDPCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1560", Offset = "0x7CC0960", VA = "0x187CC1560", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NEAIJDEAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FA0", Offset = "0x9F73A0", VA = "0x1809F7FA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D20", Offset = "0x9F7120", VA = "0x1809F7D20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool IKIKCAHFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1810", Offset = "0x7CC0C10", VA = "0x187CC1810")]
	protected HBDMCIMDLLK(NLJNHNAFJHN GIIPELIILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1590", Offset = "0x7CC0990", VA = "0x187CC1590", Slot = "26")]
	public virtual void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class HGBMKHJBHPG : IEAMNHGIGNJ, JFNILPFMLLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected GKJIAFBFJDA AGJHJAFADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PEDBLHEMBDD DMMOIDHGCMK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected CHLPKMIEKPP GKPOCKCJAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1A80", Offset = "0x7CC0E80", VA = "0x187CC1A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected GJBDMCKPJAO AJJGPOOLFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1AD0", Offset = "0x7CC0ED0", VA = "0x187CC1AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool IJHBNIPAJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7CC1B90", Offset = "0x7CC0F90", VA = "0x187CC1B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1B20", Offset = "0x7CC0F20", VA = "0x187CC1B20", Slot = "15")]
	public virtual void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
	protected HGBMKHJBHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CLIIHMMBIIB
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1230", Offset = "0x7CC0630", VA = "0x187CC1230")]
	public static void IMKMCJMIPIL(NativeArray<Entity> LGCFDEDBCHL, EntityManager IBLGEGBFEIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3340367570
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2930", Offset = "0x7CC1D30", VA = "0x187CC2930")]
	public static void CMABMGCGHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2BB0", Offset = "0x7CC1FB0", VA = "0x187CC2BB0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class IMIDOIBNBPH : ContainerPropertyBag<OBIDGDGKOHG>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2650", Offset = "0x7CC1A50", VA = "0x187CC2650")]
	public IMIDOIBNBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class JMDAGFINOBG : ContainerPropertyBag<ENBBCAFFCHP>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC26B0", Offset = "0x7CC1AB0", VA = "0x187CC26B0")]
	public JMDAGFINOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class PLGIKGHNHGD : ContainerPropertyBag<EIEMCOBHBKC>
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2710", Offset = "0x7CC1B10", VA = "0x187CC2710")]
	public PLGIKGHNHGD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2770", Offset = "0x7CC1B70", VA = "0x187CC2770")]
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
