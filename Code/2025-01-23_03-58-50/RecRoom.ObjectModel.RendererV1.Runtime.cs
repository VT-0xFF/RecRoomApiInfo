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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70DE0D0", Offset = "0x70DC8D0", VA = "0x1870DE0D0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1A468A0", Offset = "0x1A450A0", VA = "0x181A468A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70EA990", Offset = "0x70E9190", VA = "0x1870EA990")]
		private void HOKDCPPBEII(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70EAE10", Offset = "0x70E9610", VA = "0x1870EAE10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70EAE70", Offset = "0x70E9670", VA = "0x1870EAE70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BAAMPMNNBAC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70CCB80", Offset = "0x70CB380", VA = "0x1870CCB80")]
	public static Quaternion IGCMHGNDFNA([In] this GADNAPGBOLM NHHDDOHIEIC, [In] Vector3 NGBCGJCGHJG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PMMMIKNKMJK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70E62F0", Offset = "0x70E4AF0", VA = "0x1870E62F0")]
	public static bool GKMOCJDPLOK(this ENCIOJMOOGP GBFAPJDBEMN, JIKEHJJLJAI PNPOCGOGHBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70E64F0", Offset = "0x70E4CF0", VA = "0x1870E64F0")]
	public static bool IDFKGHJGNOC(this ENCIOJMOOGP GBFAPJDBEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70E5480", Offset = "0x70E3C80", VA = "0x1870E5480")]
	public static bool DLBDBBJEGCM(this ENCIOJMOOGP GBFAPJDBEMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70E61C0", Offset = "0x70E49C0", VA = "0x1870E61C0")]
	public static void GGCGFDLGCEP(this ENCIOJMOOGP GBFAPJDBEMN, Vector3 CGOEPMAPHJL, Quaternion KKFHNCNEJPO, float EKHPIDKNFIF, bool BDMBDNCNPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70E4E80", Offset = "0x70E3680", VA = "0x1870E4E80")]
	public static void AAMPFFMKGHD(this ENCIOJMOOGP GBFAPJDBEMN, Vector3 CGOEPMAPHJL, Quaternion KKFHNCNEJPO, float EKHPIDKNFIF, int OIJJCJEOBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70E5360", Offset = "0x70E3B60", VA = "0x1870E5360")]
	public static void CKMKGBHJJKJ(this ENCIOJMOOGP GBFAPJDBEMN, int OIJJCJEOBKG, Vector3 CGOEPMAPHJL, Quaternion KKFHNCNEJPO, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70E6A10", Offset = "0x70E5210", VA = "0x1870E6A10")]
	public static void OJCJPFLIAME(this ENCIOJMOOGP GBFAPJDBEMN, Vector3 LNPCMCGJJFP, Quaternion CJGGNMBPJIJ, float EKHPIDKNFIF, bool BDMBDNCNPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70E5860", Offset = "0x70E4060", VA = "0x1870E5860")]
	private static void GCMGKFOJAHK(this ENCIOJMOOGP GBFAPJDBEMN, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF, bool BDMBDNCNPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70E6330", Offset = "0x70E4B30", VA = "0x1870E6330")]
	private static void HMCBAHNDCGH(this ENCIOJMOOGP GBFAPJDBEMN, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG, float PNFFCGBDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70E6A60", Offset = "0x70E5260", VA = "0x1870E6A60")]
	private static void OLEKGHIIPCK(this ENCIOJMOOGP GBFAPJDBEMN, int ECDOOAABOPD, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG, float PNFFCGBDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70E5330", Offset = "0x70E3B30", VA = "0x1870E5330")]
	private static bool CCMPOGCBKLF(this ENCIOJMOOGP GBFAPJDBEMN, int ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70E54B0", Offset = "0x70E3CB0", VA = "0x1870E54B0")]
	private static void DNEMPMIKGIF(this ENCIOJMOOGP GBFAPJDBEMN, int ECDOOAABOPD, Vector3 BIIIOAKOBBK, Quaternion HAODNGMNEJG, float PNFFCGBDLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70E6520", Offset = "0x70E4D20", VA = "0x1870E6520")]
	public static Vector3 KGIDMLLLMOM(this ENCIOJMOOGP GBFAPJDBEMN, int ECDOOAABOPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70E5750", Offset = "0x70E3F50", VA = "0x1870E5750")]
	public static Quaternion GBGJMOGCPCA(this ENCIOJMOOGP GBFAPJDBEMN, int ECDOOAABOPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x70E5110", Offset = "0x70E3910", VA = "0x1870E5110")]
	public static Vector3 BHDIPPDIDGD(JIKEHJJLJAI NHJAJPHALPB, Vector3 BALIIBCILHH, Vector3? OGELDMALEBC, Vector3 NGOGNGNIKOO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JIPFKGKGCDD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGJLIBAMEMF(EntityQuery GDGPGFFCGKI, EntityManager MOHAGLEGECH, LMDHMHAKCOB AFFIFGJEAGI, HIAGFACLOGL PPGFGLMONCN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface KOLODLDJMGF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType FGHKHHPDDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDHPNMMNGIG(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBJNDCDNJBL(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJFCNEOGHHG(NNAOBFCCCAA KOLEEAIFBBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class ONBKAPOFICK : JIPFKGKGCDD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x70E3850", Offset = "0x70E2050", VA = "0x1870E3850", Slot = "4")]
	public void NGJLIBAMEMF(EntityQuery GDGPGFFCGKI, EntityManager MOHAGLEGECH, LMDHMHAKCOB AFFIFGJEAGI, HIAGFACLOGL PPGFGLMONCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public ONBKAPOFICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class LJGFJLIAODF : JIPFKGKGCDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EMCNJLJEEBA HBIAINGLMPA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
	public LJGFJLIAODF(EMCNJLJEEBA HBIAINGLMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70DDB10", Offset = "0x70DC310", VA = "0x1870DDB10", Slot = "4")]
	public void NGJLIBAMEMF(EntityQuery GDGPGFFCGKI, EntityManager MOHAGLEGECH, LMDHMHAKCOB AFFIFGJEAGI, HIAGFACLOGL PPGFGLMONCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class ELFMKGNJJIF : JIPFKGKGCDD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70CF6F0", Offset = "0x70CDEF0", VA = "0x1870CF6F0", Slot = "4")]
	public void NGJLIBAMEMF(EntityQuery GDGPGFFCGKI, EntityManager MOHAGLEGECH, LMDHMHAKCOB AFFIFGJEAGI, HIAGFACLOGL PPGFGLMONCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public ELFMKGNJJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OHIBFOALBBN : KOLODLDJMGF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType FGHKHHPDDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70E35A0", Offset = "0x70E1DA0", VA = "0x1870E35A0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70E35D0", Offset = "0x70E1DD0", VA = "0x1870E35D0", Slot = "5")]
	public void KDHPNMMNGIG(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70E3320", Offset = "0x70E1B20", VA = "0x1870E3320", Slot = "6")]
	public void EBJNDCDNJBL(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70E32D0", Offset = "0x70E1AD0", VA = "0x1870E32D0", Slot = "7")]
	public void CJFCNEOGHHG(NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OHIBFOALBBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OFOBGAPKPOC : KOLODLDJMGF
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType FGHKHHPDDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70E3020", Offset = "0x70E1820", VA = "0x1870E3020", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x70E3050", Offset = "0x70E1850", VA = "0x1870E3050", Slot = "5")]
	public void KDHPNMMNGIG(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70E2DA0", Offset = "0x70E15A0", VA = "0x1870E2DA0", Slot = "6")]
	public void EBJNDCDNJBL(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70E2D50", Offset = "0x70E1550", VA = "0x1870E2D50", Slot = "7")]
	public void CJFCNEOGHHG(NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OFOBGAPKPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MNLKDKHHNKB : KOLODLDJMGF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType FGHKHHPDDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70E0CB0", Offset = "0x70DF4B0", VA = "0x1870E0CB0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70E0CE0", Offset = "0x70DF4E0", VA = "0x1870E0CE0", Slot = "5")]
	public void KDHPNMMNGIG(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70E0A30", Offset = "0x70DF230", VA = "0x1870E0A30", Slot = "6")]
	public void EBJNDCDNJBL(EntityQuery GDGPGFFCGKI, NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70E09E0", Offset = "0x70DF1E0", VA = "0x1870E09E0", Slot = "7")]
	public void CJFCNEOGHHG(NNAOBFCCCAA KOLEEAIFBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MNLKDKHHNKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class KPGJPLPGHBK : BGBDLDKINMC, NAFMJLPHDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LMDHMHAKCOB AFFIFGJEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CONJMKEBONK CCJPLGMOBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HIAGFACLOGL PPGFGLMONCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JIPFKGKGCDD adapter)> NCJDPJFNHHB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70DC850", Offset = "0x70DB050", VA = "0x1870DC850", Slot = "15")]
	public virtual void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70DCA50", Offset = "0x70DB250", VA = "0x1870DCA50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x70DC8E0", Offset = "0x70DB0E0", VA = "0x1870DC8E0")]
	private void OBLNDFLCLHO(EntityQueryDesc KBCECCLKLDJ, JIPFKGKGCDD EGCFEKJHPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70DCC80", Offset = "0x70DB480", VA = "0x1870DCC80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public KPGJPLPGHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class MGMLOANMDAN : BGBDLDKINMC, NAFMJLPHDHE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class DAHBKBOELPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery FNHOLAJLBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery OBEABJGLBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery LFMFAKGMOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery INEDGPJKDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery NDMAECCKKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KOLODLDJMGF EPDBCEIMEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ComponentType FEOJCHNDCPI;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DAHBKBOELPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LMDHMHAKCOB AFFIFGJEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HIAGFACLOGL PPGFGLMONCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CONJMKEBONK CCJPLGMOBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<DAHBKBOELPI> NCJDPJFNHHB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x70DFE00", Offset = "0x70DE600", VA = "0x1870DFE00", Slot = "14")]
	public void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70E05B0", Offset = "0x70DEDB0", VA = "0x1870E05B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70E0430", Offset = "0x70DEC30", VA = "0x1870E0430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70E0740", Offset = "0x70DEF40", VA = "0x1870E0740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70DFAD0", Offset = "0x70DE2D0", VA = "0x1870DFAD0")]
	private void DIMAIIOMPIA(DAHBKBOELPI AEKKIGMJNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70DFE90", Offset = "0x70DE690", VA = "0x1870DFE90")]
	private void OBLNDFLCLHO(KOLODLDJMGF EPDBCEIMEGA, ComponentType AOIBBOMGEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public MGMLOANMDAN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct NLKJNCMIIPK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct LHPECBGEJBI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct HKBBJKKIGEL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(KIMALLHGCOF), new string[] { })]
public class HKCKPCECIJO : KIMALLHGCOF, HFFMLPMNKCE, FMDAFAPAHCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[DependsOn]
	private GIAJMCLBEFD LHFELFOPEAG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70DADB0", Offset = "0x70D95B0", VA = "0x1870DADB0", Slot = "4")]
	public bool JBPIEEJKCDE(NLPICMPDONC BCECCNCMCGN, NAGHPEHFOJO INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x70DAD60", Offset = "0x70D9560", VA = "0x1870DAD60", Slot = "5")]
	private void CGBPBNNGKAA(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xD002E0", Offset = "0xCFEAE0", VA = "0x180D002E0", Slot = "6")]
	private void IIJGEHKIEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public HKCKPCECIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(HIAGFACLOGL), new string[] { })]
public class AOHEKILGFPP : HIAGFACLOGL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LDFEEADCCGN KPOANAODNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LDFEEADCCGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AOHEKILGFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(GHBENOJCJFF), new string[] { })]
public class GBHOILKIKHJ : GHBENOJCJFF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70D0380", Offset = "0x70CEB80", VA = "0x1870D0380", Slot = "4")]
	public void EGDHEPCNGIO(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70D0560", Offset = "0x70CED60", VA = "0x1870D0560", Slot = "5")]
	public void NBFAAJAPJNL(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70D0C90", Offset = "0x70CF490", VA = "0x1870D0C90", Slot = "6")]
	public ComponentSystemBase PDCADGCJLEF(World LHFELFOPEAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x70D0320", Offset = "0x70CEB20", VA = "0x1870D0320", Slot = "7")]
	public void ABJBKHGPLAA(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x70D0460", Offset = "0x70CEC60", VA = "0x1870D0460", Slot = "8")]
	public void IHFAFPOFPAH(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x70D0400", Offset = "0x70CEC00", VA = "0x1870D0400", Slot = "9")]
	public void ICFOGHKJKIL(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70D04C0", Offset = "0x70CECC0", VA = "0x1870D04C0", Slot = "10")]
	public void JPBHMAGFJMN(World LHFELFOPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70D05B0", Offset = "0x70CEDB0", VA = "0x1870D05B0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> OFBKDHNKEOB()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public GBHOILKIKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ODNCGEHHLPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public HIOFIBKKFLJ IMHBJILLCHD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static ODNCGEHHLPM FMEIMHFCNHG(HIOFIBKKFLJ KACBIAOBGKP)
	{
		return default(ODNCGEHHLPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KOPGDPEDDJA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PEOKLHNBNLK AIMNCKBDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x70DC7E0", Offset = "0x70DAFE0", VA = "0x1870DC7E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public KOPGDPEDDJA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OFCFGKGCENN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HOOMBAGNDBL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FNFGIGIJDCM FKMGACBJNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70DB030", Offset = "0x70D9830", VA = "0x1870DB030", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70DAFC0", Offset = "0x70D97C0", VA = "0x1870DAFC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public HOOMBAGNDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GDPCEIONGCA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NKAAMDNONPL EJCFOGEPMMB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static GDPCEIONGCA FMEIMHFCNHG(NKAAMDNONPL KACBIAOBGKP)
	{
		return default(GDPCEIONGCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NJMOAJJEDKO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public HIOFIBKKFLJ IMHBJILLCHD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static NJMOAJJEDKO FMEIMHFCNHG(HIOFIBKKFLJ KACBIAOBGKP)
	{
		return default(NJMOAJJEDKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CALNGFBIGFB : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NLIBAEJGLLA BHBDKKPDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70CDFB0", Offset = "0x70CC7B0", VA = "0x1870CDFB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x70CDF40", Offset = "0x70CC740", VA = "0x1870CDF40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CALNGFBIGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JDFEBEJPMCP : CKDBCCHNFIK, FNFGIGIJDCM, LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LMLJLLLHEEP JOFNHCCGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x958990", Offset = "0x957190", VA = "0x180958990", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(LMLJLLLHEEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AMBCAMEPBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA999B0", Offset = "0xA981B0", VA = "0x180A999B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 KOIONMJJJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC6A180", Offset = "0xC68980", VA = "0x180C6A180", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70DBE10", Offset = "0x70DA610", VA = "0x1870DBE10")]
	public JDFEBEJPMCP(UniformTRS OMCMFPGOOFL, COHFKJEBDIE NCCLECGLDAO, float BCAMIMKLAPP, float3 CGIFOCMCAIF, CEBKHCOPPLM GINDLHIINKD, PJFDOHDFBLL HNHLDOPPHMH, LMLJLLLHEEP FFPEKFKIDDJ, float3 ANKPCCHOGHI, bool AOPBFHAAOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x70DBDC0", Offset = "0x70DA5C0", VA = "0x1870DBDC0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PJDGFJNIDPM : CKDBCCHNFIK, NLIBAEJGLLA, LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<JIKFLLDMDJN> JLGHPJMPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IFPGDNKHPCP OFGFBCNFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly float JPENPMCCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int JPMEJFNLFPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JOFHHNPMFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70E4DF0", Offset = "0x70E35F0", VA = "0x1870E4DF0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JBNHJIPHILD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70E4E10", Offset = "0x70E3610", VA = "0x1870E4E10", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MODNBNPAKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70E4E00", Offset = "0x70E3600", VA = "0x1870E4E00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NLJPDNGHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99C870", Offset = "0x99B070", VA = "0x18099C870", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float NEAEOFGNNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC73420", Offset = "0xC71C20", VA = "0x180C73420", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IDNLPJCNKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB0E530", Offset = "0xB0CD30", VA = "0x180B0E530", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x70E4D40", Offset = "0x70E3540", VA = "0x1870E4D40")]
	public PJDGFJNIDPM(UniformTRS OMCMFPGOOFL, COHFKJEBDIE NCCLECGLDAO, float BCAMIMKLAPP, float3 CGIFOCMCAIF, CEBKHCOPPLM GINDLHIINKD, PJFDOHDFBLL HNHLDOPPHMH, IFPGDNKHPCP OFGFBCNFINC, float JPENPMCCBIB, int JPMEJFNLFPJ, NativeArray<JIKFLLDMDJN> JLGHPJMPOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC82880", Offset = "0xC81080", VA = "0x180C82880", Slot = "33")]
	public NativeArray<JIKFLLDMDJN> GetNativeCurvePoints()
	{
		return default(NativeArray<JIKFLLDMDJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70E4C80", Offset = "0x70E3480", VA = "0x1870E4C80", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AEOEALBAIAD : MPOCNALLHIF, PEOKLHNBNLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GameObject GBIOICBNFCB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70CC450", Offset = "0x70CAC50", VA = "0x1870CC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IGANFMNEEBA KEKDMLOCEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x70CC510", Offset = "0x70CAD10", VA = "0x1870CC510", Slot = "15")]
		get
		{
			return default(IGANFMNEEBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public NFLFIOOFEKC GKJLFFIHBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "16")]
		get
		{
			return default(NFLFIOOFEKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70CC610", Offset = "0x70CAE10", VA = "0x1870CC610")]
	public AEOEALBAIAD(NLPICMPDONC BCECCNCMCGN, bool PPLAKPEEMKL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70CC2E0", Offset = "0x70CAAE0", VA = "0x1870CC2E0")]
	public void CDLHJNOLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70CC510", Offset = "0x70CAD10", VA = "0x1870CC510")]
	protected IGANFMNEEBA IHABKLNNCOO()
	{
		return default(IGANFMNEEBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70CC4E0", Offset = "0x70CACE0", VA = "0x1870CC4E0", Slot = "17")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NCAJGLLKLCI : JDBMIAIKBMD, FNFGIGIJDCM, LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Dictionary<KCDIPBECKHL, LMLJLLLHEEP> NIMCOFIBHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LMLJLLLHEEP FFPEKFKIDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool AOPBFHAAOGF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private LMLJLLLHEEP ABNCOKJMMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4630", Offset = "0x8D2E30", VA = "0x1808D4630", Slot = "28")]
		get
		{
			return default(LMLJLLLHEEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool CNHMDKCLPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0A0", Offset = "0xA3A8A0", VA = "0x180A3C0A0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 KOIONMJJJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70E2330", Offset = "0x70E0B30", VA = "0x1870E2330", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70E22F0", Offset = "0x70E0AF0", VA = "0x1870E22F0")]
	public NCAJGLLKLCI(NLPICMPDONC KKPONDJIGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x70E1C60", Offset = "0x70E0460", VA = "0x1870E1C60", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70E1CB0", Offset = "0x70E04B0", VA = "0x1870E1CB0", Slot = "26")]
	public override void LHNLPLKLOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BDDKEMDHAKE : JDBMIAIKBMD, NLIBAEJGLLA, LHBMJJFFGPI, IDisposable, HEPANMFIAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeList<JIKFLLDMDJN> JLGHPJMPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool OICFJDKNBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool AJBIOJKMGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private float JPENPMCCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int JPMEJFNLFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private bool CBHEEMNOAGO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool GKAOOIJCJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x997550", Offset = "0x995D50", VA = "0x180997550", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool FHOHMJIKJDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9014B0", Offset = "0x8FFCB0", VA = "0x1809014B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float JKMKMNEAJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xC15580", Offset = "0xC13D80", VA = "0x180C15580", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int OJFLMEBOPII
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x958990", Offset = "0x957190", VA = "0x180958990", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CLFNNPBDDOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA999B0", Offset = "0xA981B0", VA = "0x180A999B0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int CHOEJMOHGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x70CCEA0", Offset = "0x70CB6A0", VA = "0x1870CCEA0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int IKEEKGMMJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70CCD50", Offset = "0x70CB550", VA = "0x1870CCD50", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x70CD560", Offset = "0x70CBD60", VA = "0x1870CD560")]
	public BDDKEMDHAKE(NLPICMPDONC KKPONDJIGMO, [Optional] NativeList<JIKFLLDMDJN> JLGHPJMPOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70CD1E0", Offset = "0x70CB9E0", VA = "0x1870CD1E0", Slot = "26")]
	public override void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x70CCC60", Offset = "0x70CB460", VA = "0x1870CCC60", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x70CCE40", Offset = "0x70CB640", VA = "0x1870CCE40", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70CD500", Offset = "0x70CBD00", VA = "0x1870CD500")]
	public void PFOGNLIKBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x70CCEC0", Offset = "0x70CB6C0", VA = "0x1870CCEC0", Slot = "34")]
	public NativeArray<JIKFLLDMDJN> GetNativeCurvePoints()
	{
		return default(NativeArray<JIKFLLDMDJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70CD090", Offset = "0x70CB890", VA = "0x1870CD090", Slot = "35")]
	private Vector3 KJBPNIIFMFE(int JAIJLDENOAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70CD330", Offset = "0x70CBB30", VA = "0x1870CD330", Slot = "36")]
	private Quaternion OAPPDLGMJOI(int JAIJLDENOAK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70CD360", Offset = "0x70CBB60", VA = "0x1870CD360", Slot = "37")]
	private float OINCEHJHCJC(int JAIJLDENOAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x70CD2C0", Offset = "0x70CBAC0", VA = "0x1870CD2C0")]
	private NativeArray<Entity> LKIHFKMDDCB()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class AFFPOGDKBHK : JBMGEFICBDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70CC7C0", Offset = "0x70CAFC0", VA = "0x1870CC7C0", Slot = "15")]
	protected override ComponentSystemBase LLDOLHMEGEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70CCB60", Offset = "0x70CB360", VA = "0x1870CCB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x70CCB70", Offset = "0x70CB370", VA = "0x1870CCB70")]
	public AFFPOGDKBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[LMGDPPAGHNA]
public sealed class HHNJKBKCIDH : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EntityQuery FNHOLAJLBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EntityQuery ANGBJNLKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EntityQuery FFDJJICMFNA;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x70DAAA0", Offset = "0x70D92A0", VA = "0x1870DAAA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x70DACA0", Offset = "0x70D94A0", VA = "0x1870DACA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x70DA610", Offset = "0x70D8E10", VA = "0x1870DA610")]
	private void CKODECGALON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70DA890", Offset = "0x70D9090", VA = "0x1870DA890")]
	private void KKHEHAIIMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x70DA4E0", Offset = "0x70D8CE0", VA = "0x1870DA4E0")]
	private void CCLFJFLGCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70DA480", Offset = "0x70D8C80", VA = "0x1870DA480")]
	private NativeList<Entity> CAIDEPAMOJK(NativeArray<Entity> NFLDGMHEJEF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70DA830", Offset = "0x70D9030", VA = "0x1870DA830")]
	private NativeList<Entity> HLDGDFGNLFF(NativeArray<Entity> NFLDGMHEJEF)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x70DA3F0", Offset = "0x70D8BF0", VA = "0x1870DA3F0")]
	private void BLPOPEGFMAB(NativeArray<Entity> NFLDGMHEJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public HHNJKBKCIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[LMGDPPAGHNA]
public sealed class MEKJLAEOKPC : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private EntityQuery BFGBJOJPBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EntityQuery AOEFKICLLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery LFMFAKGMOJE;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70DF820", Offset = "0x70DE020", VA = "0x1870DF820", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70DFA10", Offset = "0x70DE210", VA = "0x1870DFA10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70DE450", Offset = "0x70DCC50", VA = "0x1870DE450")]
	private void FKDMDPFGHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70DEC40", Offset = "0x70DD440", VA = "0x1870DEC40")]
	private void IBBDNHDDNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x70DF430", Offset = "0x70DDC30", VA = "0x1870DF430")]
	private void JMPPKFKGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public MEKJLAEOKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LMGDPPAGHNA]
public sealed class FHFMPBEOLDO : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery HHFDFJOAKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery LIPCBCGAFDP;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70CFED0", Offset = "0x70CE6D0", VA = "0x1870CFED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70D0020", Offset = "0x70CE820", VA = "0x1870D0020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70CF8B0", Offset = "0x70CE0B0", VA = "0x1870CF8B0")]
	private void FKDMDPFGHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70CFBC0", Offset = "0x70CE3C0", VA = "0x1870CFBC0")]
	private void IBBDNHDDNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public FHFMPBEOLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DLDAJJCLFHH : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[BurstCompile]
	private struct HNMEDAEHHDN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EntityQueryInJob GKNKGOGOILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EntityQueryInJob NBCEFGKCCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ReadOnly]
		public EntityTypeHandle GGBLNPOPJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[ReadOnly]
		public ComponentTypeHandle<NJMOAJJEDKO> JIMLIFMEMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeParallelHashSet<HIOFIBKKFLJ> JKECHLNDJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeList<Entity> BAKDPOPFKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeList<Entity> DIHGCEBEMOG;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70DAF70", Offset = "0x70D9770", VA = "0x1870DAF70", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70DAE90", Offset = "0x70D9690", VA = "0x1870DAE90")]
		private void DEOAMJIFNOD(EntityQueryInJob GDGPGFFCGKI, [Optional] NativeList<Entity> BBPHCMOODJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private struct FNGGKNDDMFF : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[ReadOnly]
		public EntityTypeHandle GGBLNPOPJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[ReadOnly]
		public ComponentTypeHandle<NJMOAJJEDKO> JIMLIFMEMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeParallelHashSet<HIOFIBKKFLJ> JKECHLNDJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeList<Entity> BBPHCMOODJF;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70D00D0", Offset = "0x70CE8D0", VA = "0x1870D00D0", Slot = "4")]
		public void Execute(ArchetypeChunk DCDCMDNHBGP, int KEIIILNHHJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct KCJNADPMJNI : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public EntityTypeHandle GGBLNPOPJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> KCGGKFPABJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ReadOnly]
		public ComponentTypeHandle<GDPCEIONGCA> LCKBLDGMMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ReadOnly]
		public ComponentDataFromEntity<ODNCGEHHLPM> JNGLJABOOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ComponentTypeHandle<NJMOAJJEDKO> EDOIBIBKIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NativeParallelHashSet<HIOFIBKKFLJ> JKECHLNDJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NativeList<Entity> HFLOMMNADCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NativeList<GDPCEIONGCA> FMDAOPPFBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NativeList<HIOFIBKKFLJ> FCPLHIJEMBK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70DC270", Offset = "0x70DAA70", VA = "0x1870DC270", Slot = "4")]
		public void Execute(ArchetypeChunk DCDCMDNHBGP, int KEIIILNHHJH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery GKNKGOGOILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery NBCEFGKCCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery KHHGNCCGGMF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70CF0D0", Offset = "0x70CD8D0", VA = "0x1870CF0D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x70CF360", Offset = "0x70CDB60", VA = "0x1870CF360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x70CE950", Offset = "0x70CD150", VA = "0x1870CE950")]
	private void MOKNFDEEAFH(NativeParallelHashSet<HIOFIBKKFLJ> JKECHLNDJHA, int FEAPOKOHGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x70CE610", Offset = "0x70CCE10", VA = "0x1870CE610")]
	private void ELDOCDMFPCK(NativeParallelHashSet<HIOFIBKKFLJ> JKECHLNDJHA, int PCOKCBCBBKL, int DJJCNPBJACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public DLDAJJCLFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class NMHKOAOGOEO : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private EntityQuery GDGPGFFCGKI;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x70E2460", Offset = "0x70E0C60", VA = "0x1870E2460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70E2510", Offset = "0x70E0D10", VA = "0x1870E2510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public NMHKOAOGOEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LMGDPPAGHNA]
internal class LCOKCDHHGJJ : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class OOIIOAMFLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EntityQuery LBFGJIKADPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EntityQuery NCKJFNKIJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public NLOHLCDNJCK AIHAFMDAMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ComponentType JEJPBJGHLNO;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OOIIOAMFLPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private delegate void NLOHLCDNJCK(NativeArray<NKAAMDNONPL> KACBIAOBGKP, NNAOBFCCCAA KOLEEAIFBBJ);

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<OOIIOAMFLPO> NCJDPJFNHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private CONJMKEBONK CCJPLGMOBOP;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x70DD1B0", Offset = "0x70DB9B0", VA = "0x1870DD1B0", Slot = "15")]
	public override void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x70DD3F0", Offset = "0x70DBBF0", VA = "0x1870DD3F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x70DD580", Offset = "0x70DBD80", VA = "0x1870DD580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x310AA60", Offset = "0x3109260", VA = "0x18310AA60")]
	private void OBLNDFLCLHO<T>(NLOHLCDNJCK AIHAFMDAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x70DD010", Offset = "0x70DB810", VA = "0x1870DD010")]
	private static void HBNEKALCOPC(NativeArray<NKAAMDNONPL> FOOPPDKFADO, NNAOBFCCCAA JCEDCGKBIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x70DCE70", Offset = "0x70DB670", VA = "0x1870DCE70")]
	private static void BHGNLBCJBPO(NativeArray<NKAAMDNONPL> FOOPPDKFADO, NNAOBFCCCAA JCEDCGKBIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70DD250", Offset = "0x70DBA50", VA = "0x1870DD250")]
	private static void JACGKLFENAO(NativeArray<NKAAMDNONPL> FOOPPDKFADO, NNAOBFCCCAA JCEDCGKBIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public LCOKCDHHGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[LMGDPPAGHNA]
public sealed class IFKDCBJMKCO : PCFBPCNCLBA
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EntityQuery GDGPGFFCGKI;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x70DB480", Offset = "0x70D9C80", VA = "0x1870DB480", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PEJEFJCLCEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public UniformTRS OMCMFPGOOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public StandardRenderableVisualData LKHEAKFGPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public LMLJLLLHEEP FFPEKFKIDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 ANKPCCHOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool AOPBFHAAOGF;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DIIGOMJGPEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public NativeList<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NativeList<Entity> AMPAKEENBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeParallelHashSet<Entity> MINBIHCDHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeList<PEJEFJCLCEB> EIAFAINMGOI;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x70CE340", Offset = "0x70CCB40", VA = "0x1870CE340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RegisterService(typeof(OOMNDIGPCIO), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
public class OOMNDIGPCIO : NAFMJLPHDHE, GOCAFABHBEB, HFFMLPMNKCE, FMDAFAPAHCF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct JMHMEBIMHOD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly OOMNDIGPCIO NCCLECGLDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly bool EFLGLHNOJCL;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12CD500", Offset = "0x12CBD00", VA = "0x1812CD500")]
		public JMHMEBIMHOD(OOMNDIGPCIO NCCLECGLDAO, bool EFLGLHNOJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x70DC1C0", Offset = "0x70DA9C0", VA = "0x1870DC1C0")]
		public Queue<JBKOGPDNBFO>.Enumerator IGEPHCDGPEC()
		{
			return default(Queue<JBKOGPDNBFO>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x70DBEB0", Offset = "0x70DA6B0", VA = "0x1870DBEB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[DependsOn]
	private PJJOGJFNMIM FLGLGKAHJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[DependsOn]
	private EFHAFOHFCIE APLIHJKICNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private List<NativeList<JIKFLLDMDJN>> NDNHGJGALPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeList<NKAAMDNONPL> MOEBEMBAFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private List<(Entity, List<GameObject>)> FCDGKPPGODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HFNOCELKKKF<JBKOGPDNBFO> PANHFFEDMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HFNOCELKKKF<DIIGOMJGPEP> FKKHDBAECGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HFNOCELKKKF<NEJKHHEBCOJ> JGPLGDBJIII;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x70E4700", Offset = "0x70E2F00", VA = "0x1870E4700", Slot = "4")]
	public void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x70E3DC0", Offset = "0x70E25C0", VA = "0x1870E3DC0")]
	public void DNJJMGKHAIE(NativeList<JIKFLLDMDJN> KLOCPDOODFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x70E4560", Offset = "0x70E2D60", VA = "0x1870E4560")]
	public void IPEGKNHJOLM(Entity NCCLECGLDAO, [In] FAHGBPLMFAB<GameObject> DIPEBEJILNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x70E3AB0", Offset = "0x70E22B0", VA = "0x1870E3AB0")]
	public void ALBPMHJNKGM(NativeList<NKAAMDNONPL> FOOPPDKFADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x70E4340", Offset = "0x70E2B40", VA = "0x1870E4340")]
	public void ICFOGHKJKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x70E3E90", Offset = "0x70E2690", VA = "0x1870E3E90")]
	public void IBBFOGNMJDH(IPOCMNFOENG JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x70E4900", Offset = "0x70E3100", VA = "0x1870E4900")]
	public JobHandle JDOIODOABOA([In] JBKOGPDNBFO PJFOMDHJLBF, JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x70E49A0", Offset = "0x70E31A0", VA = "0x1870E49A0")]
	public JobHandle JDOIODOABOA([In] DIIGOMJGPEP PJFOMDHJLBF, JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DF31E0", Offset = "0x6DF19E0", VA = "0x186DF31E0")]
	public JMHMEBIMHOD OLAIDEAFPKB(bool EFLGLHNOJCL)
	{
		return default(JMHMEBIMHOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x70E4A40", Offset = "0x70E3240", VA = "0x1870E4A40")]
	public OFGDPJNMCJP<DIIGOMJGPEP> ODMMBJILINM()
	{
		return default(OFGDPJNMCJP<DIIGOMJGPEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x70E4A90", Offset = "0x70E3290", VA = "0x1870E4A90")]
	public OFGDPJNMCJP<NEJKHHEBCOJ> OJBHHJJFGKD()
	{
		return default(OFGDPJNMCJP<NEJKHHEBCOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x70E3BB0", Offset = "0x70E23B0", VA = "0x1870E3BB0", Slot = "5")]
	public void DECDNNFOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x70E3B40", Offset = "0x70E2340", VA = "0x1870E3B40", Slot = "6")]
	private void CGBPBNNGKAA(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7092F10", Offset = "0x7091710", VA = "0x187092F10", Slot = "7")]
	private void IIJGEHKIEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OOMNDIGPCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NNOBJPAMDNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public UniformTRS OMCMFPGOOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public StandardRenderableVisualData LKHEAKFGPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GMIJGAFIAIM OFGFBCNFINC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JBKOGPDNBFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> AMPAKEENBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> MINBIHCDHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<LGIPPHGAGPO> BGPKGJKJBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<JIKFLLDMDJN> KLOCPDOODFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<NNOBJPAMDNJ> BNKOCIMHJIG;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x70DB9D0", Offset = "0x70DA1D0", VA = "0x1870DB9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x70DB900", Offset = "0x70DA100", VA = "0x1870DB900")]
	public void BJHAOCCHMOL(bool EFLGLHNOJCL)
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[SystemEnabledLifetime(Lifetime.LoadInstance)]
	public class PostDeserializeBakeShapesSystem : PCFBPCNCLBA, NAFMJLPHDHE
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
			public NativeParallelHashMap<int, LMLJLLLHEEP> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public NativeArray<PEJEFJCLCEB> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x70D5990", Offset = "0x70D4190", VA = "0x1870D5990", Slot = "4")]
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
			public NativeArray<JIKFLLDMDJN> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[ReadOnly]
			public NativeArray<LGIPPHGAGPO> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public NativeArray<NNOBJPAMDNJ> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x70D5D30", Offset = "0x70D4530", VA = "0x1870D5D30", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x70CE200", Offset = "0x70CCA00", VA = "0x1870CE200", Slot = "4")]
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
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x70E6CA0", Offset = "0x70E54A0", VA = "0x1870E6CA0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0x70E6C50", Offset = "0x70E5450", VA = "0x1870E6C50")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 FHJMNJFKOHC(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x70DDD20", Offset = "0x70DC520", VA = "0x1870DDD20", Slot = "5")]
				public float3 NLNLGJDDFOC(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x70DDCE0", Offset = "0x70DC4E0", VA = "0x1870DDCE0", Slot = "4")]
				public float3 FHJMNJFKOHC(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x70E2A20", Offset = "0x70E1220", VA = "0x1870E2A20", Slot = "4")]
				public float3 FHJMNJFKOHC(quaternion rotation)
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
			public NativeArray<LGIPPHGAGPO> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<JIKFLLDMDJN> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x70D8D60", Offset = "0x70D7560", VA = "0x1870D8D60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x70D7A50", Offset = "0x70D6250", VA = "0x1870D7A50")]
			private void CPHFPPFFCML(NativeList<PointSrcData> srcData, NativeList<JIKFLLDMDJN> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x70D9BF0", Offset = "0x70D83F0", VA = "0x1870D9BF0")]
			public static Vector3 NHHGIOBLBOB(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x70D8930", Offset = "0x70D7130", VA = "0x1870D8930")]
			public static quaternion DGJIIAPDHFB(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x70D6940", Offset = "0x70D5140", VA = "0x1870D6940")]
			private static quaternion BHHLCBDLJDM(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x70D89B0", Offset = "0x70D71B0", VA = "0x1870D89B0")]
			private static float3 DHPEMAHOGFJ(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x70D6450", Offset = "0x70D4C50", VA = "0x1870D6450")]
			private static quaternion ABMKEJJLEDE(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x70D98E0", Offset = "0x70D80E0", VA = "0x1870D98E0")]
			private static JIKFLLDMDJN JIHLEJHHLAI(int idx, NativeList<PointSrcData> srcData)
			{
				return default(JIKFLLDMDJN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x370AB90", Offset = "0x3709390", VA = "0x18370AB90")]
			private void EDBPIHINDGI<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x70D6B70", Offset = "0x70D5370", VA = "0x1870D6B70")]
			private void CAPCIOBKECE(NativeList<PointSrcData> sourcePoints, NativeList<JIKFLLDMDJN> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x70D9570", Offset = "0x70D7D70", VA = "0x1870D9570")]
			public static float IEMDDHCEOJP(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x70D96F0", Offset = "0x70D7EF0", VA = "0x1870D96F0")]
			private static quaternion IJKJDCAGFCG(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x70DA240", Offset = "0x70D8A40", VA = "0x1870DA240")]
			private static JIKFLLDMDJN OMHAEMNMEPL(PointSrcData point)
			{
				return default(JIKFLLDMDJN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x70DA1B0", Offset = "0x70D89B0", VA = "0x1870DA1B0")]
			private static JIKFLLDMDJN OMHAEMNMEPL(float3 pos, quaternion rot, float radius)
			{
				return default(JIKFLLDMDJN);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x70D9B50", Offset = "0x70D8350", VA = "0x1870D9B50")]
			private static bool KBEMLBPHKBN(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x70D7980", Offset = "0x70D6180", VA = "0x1870D7980")]
			private static float3 CFKAAAAACME(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x70D93C0", Offset = "0x70D7BC0", VA = "0x1870D93C0")]
			public static float3 IAFOCKHHHGP(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x70DA000", Offset = "0x70D8800", VA = "0x1870DA000")]
			public static float3 NLNLGJDDFOC(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x70D64E0", Offset = "0x70D4CE0", VA = "0x1870D64E0")]
			private static quaternion BFOBPBLNKKM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x70D8B80", Offset = "0x70D7380", VA = "0x1870D8B80")]
			private static float EJLEKONMILG(float3 from, float3 to)
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

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x70E9020", Offset = "0x70E7820", VA = "0x1870E9020")]
			private void CILIOJBKPLC(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x70E9100", Offset = "0x70E7900", VA = "0x1870E9100", Slot = "4")]
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
			public NativeList<JIKFLLDMDJN> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x70EA5A0", Offset = "0x70E8DA0", VA = "0x1870EA5A0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x70EA600", Offset = "0x70E8E00", VA = "0x1870EA600", Slot = "4")]
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
			public NativeList<JIKFLLDMDJN> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x70EA540", Offset = "0x70E8D40", VA = "0x1870EA540")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x70EA590", Offset = "0x70E8D90", VA = "0x1870EA590", Slot = "4")]
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
			public NativeList<PEJEFJCLCEB> data;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x70D6070", Offset = "0x70D4870", VA = "0x1870D6070")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x70D6230", Offset = "0x70D4A30", VA = "0x1870D6230", Slot = "4")]
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
			public NativeList<LGIPPHGAGPO> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NativeList<NNOBJPAMDNJ> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x70D6240", Offset = "0x70D4A40", VA = "0x1870D6240")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x70D6440", Offset = "0x70D4C40", VA = "0x1870D6440", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x70EA110", Offset = "0x70E8910", VA = "0x1870EA110")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x70EA530", Offset = "0x70E8D30", VA = "0x1870EA530", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly FICDJCDJOAA log;

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
		private JFFDEFJMHAP replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private PJJOGJFNMIM objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private OOMNDIGPCIO bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private EAFIBMINNDH ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70E8B30", Offset = "0x70E7330", VA = "0x1870E8B30", Slot = "15")]
		public override void InitReferences(IMGHKCMNGFB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x70E9750", Offset = "0x70E7F50", VA = "0x1870E9750", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x70E9840", Offset = "0x70E8040", VA = "0x1870E9840", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x70E98A0", Offset = "0x70E80A0", VA = "0x1870E98A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x70E8830", Offset = "0x70E7030", VA = "0x1870E8830")]
		private JobHandle IMGIPJBFNKH(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x70E7180", Offset = "0x70E5980", VA = "0x1870E7180")]
		private JobHandle BBJDKJEMDJB(EntityQuery query, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70E91F0", Offset = "0x70E79F0", VA = "0x1870E91F0")]
		private JobHandle OAOODJBHAEF(NativeArray<int> pointCount, NativeList<JIKFLLDMDJN> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x70E6CC0", Offset = "0x70E54C0", VA = "0x1870E6CC0")]
		private JobHandle AEBFHMKACNF(NativeList<JIKFLLDMDJN> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x70E7C00", Offset = "0x70E6400", VA = "0x1870E7C00")]
		private JobHandle DDCNDCEGONI(EntityQuery query, NativeList<LGIPPHGAGPO> splinePointRanges, NativeList<JIKFLLDMDJN> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x70E80D0", Offset = "0x70E68D0", VA = "0x1870E80D0")]
		private JobHandle EOHGENDFBNI(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x70E8F30", Offset = "0x70E7730", VA = "0x1870E8F30")]
		private JobHandle LADGCJCNLKP(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x70E8300", Offset = "0x70E6B00", VA = "0x1870E8300")]
		private JobHandle HAAGCDOGJON(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<PEJEFJCLCEB> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70E8570", Offset = "0x70E6D70", VA = "0x1870E8570")]
		private JobHandle HAELEJPPLOP(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<LGIPPHGAGPO> splinePointRanges, [Out] NativeList<NNOBJPAMDNJ> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70E79F0", Offset = "0x70E61F0", VA = "0x1870E79F0")]
		private JobHandle BMGMJJPLGJN(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70E99B0", Offset = "0x70E81B0", VA = "0x1870E99B0")]
		private JobHandle PFNNADBMMFA(EntityQuery query, NativeList<PEJEFJCLCEB> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x70E6D60", Offset = "0x70E5560", VA = "0x1870E6D60")]
		private static NativeParallelHashMap<int, LMLJLLLHEEP> AONAPNBDJOB()
		{
			return default(NativeParallelHashMap<int, LMLJLLLHEEP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70E9290", Offset = "0x70E7A90", VA = "0x1870E9290")]
		private JobHandle NJDKNNMONIG(EntityQuery query, NativeList<LGIPPHGAGPO> splinePointRanges, NativeList<JIKFLLDMDJN> splinePointData, NativeList<NNOBJPAMDNJ> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x70E8E50", Offset = "0x70E7650", VA = "0x1870E8E50")]
		private JobHandle KGLHCBGFHAO(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x70E91F0", Offset = "0x70E79F0", VA = "0x1870E91F0")]
		private JobHandle NHEBBEIENLA(NativeArray<int> pointCount, NativeList<JIKFLLDMDJN> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x70E6CC0", Offset = "0x70E54C0", VA = "0x1870E6CC0")]
		private JobHandle FLJLMMLMOMO(NativeList<JIKFLLDMDJN> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x70E8C10", Offset = "0x70E7410", VA = "0x1870E8C10")]
		private JobHandle KCLDIMLPELB(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<PEJEFJCLCEB> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x70E81F0", Offset = "0x70E69F0", VA = "0x1870E81F0")]
		private JobHandle FPOPLPNJFMF(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<LGIPPHGAGPO> ranges, NativeList<NNOBJPAMDNJ> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x70E8D00", Offset = "0x70E7500", VA = "0x1870E8D00")]
		private JobHandle KFKDIAMCLAD(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70E9540", Offset = "0x70E7D40", VA = "0x1870E9540", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EKGLLMEJKKP : BGBDLDKINMC, NAFMJLPHDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public OOMNDIGPCIO NCPHILDMACO;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70CF680", Offset = "0x70CDE80", VA = "0x1870CF680", Slot = "14")]
	public void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x70CF6D0", Offset = "0x70CDED0", VA = "0x1870CF6D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public EKGLLMEJKKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class GDGMHGLFFDD : PCFBPCNCLBA, NAFMJLPHDHE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct CKOICFANDBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EntityManager MOHAGLEGECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private JGPIHIFFIDO<T> CDAHCNPNJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int ECDOOAABOPD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x59324F0", Offset = "0x5930CF0", VA = "0x1859324F0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5932D90", Offset = "0x5931590", VA = "0x185932D90")]
		public CKOICFANDBH(EntityManager MOHAGLEGECH, JGPIHIFFIDO<T> CDAHCNPNJEP, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D79550", Offset = "0x3D77D50", VA = "0x183D79550")]
		public CKOICFANDBH<T> IGEPHCDGPEC()
		{
			return default(CKOICFANDBH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5932CD0", Offset = "0x59314D0", VA = "0x185932CD0")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly FICDJCDJOAA BLBGMLIIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private EFHAFOHFCIE APLIHJKICNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private OOMNDIGPCIO NCPHILDMACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::DPJPICKDGFF EDKFNMMBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CAJDNBGOENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private string FMFPGDFMBEE;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x70D33B0", Offset = "0x70D1BB0", VA = "0x1870D33B0", Slot = "15")]
	public override void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x70D4620", Offset = "0x70D2E20", VA = "0x1870D4620")]
	public void JPBHMAGFJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x70D4690", Offset = "0x70D2E90", VA = "0x1870D4690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x70D35C0", Offset = "0x70D1DC0", VA = "0x1870D35C0")]
	private void JLIJGEFIFIC(NEJKHHEBCOJ PJFOMDHJLBF, Mesh[] KFGLAHKLBII, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3078D70", Offset = "0x3077570", VA = "0x183078D70")]
	private CKOICFANDBH<T> AFJKCFNHFLG<T>(JGPIHIFFIDO<T> CDAHCNPNJEP, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM) where T : struct
	{
		return default(CKOICFANDBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x70D0CE0", Offset = "0x70CF4E0", VA = "0x1870D0CE0")]
	private void BDNCNDNODID(Transform NCCLECGLDAO, NativeArray<FDDPFKCGKAF> OCHAMDBHCBC, FAHGBPLMFAB<GameObject> JCDDPJABKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x70D2AD0", Offset = "0x70D12D0", VA = "0x1870D2AD0")]
	private void HOKAGAKEBNC(Transform NCCLECGLDAO, NativeArray<EFLJDLMJPOP> CAONNOEHFID, FAHGBPLMFAB<GameObject> JCDDPJABKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x70D1A10", Offset = "0x70D0210", VA = "0x1870D1A10")]
	private void CGDFDGJCINB(Transform NCCLECGLDAO, NativeArray<LLGCKPFIHHI> EEGFNPPJMOC, FAHGBPLMFAB<GameObject> JCDDPJABKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x70D1610", Offset = "0x70CFE10", VA = "0x1870D1610")]
	private void BNFOPDBJILK(Transform NCCLECGLDAO, NativeArray<FBAONJOAJFK> KFGLAHKLBII, Mesh[] JJPJIDGPKFE, FAHGBPLMFAB<GameObject> JCDDPJABKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x70D1E00", Offset = "0x70D0600", VA = "0x1870D1E00")]
	private static void HBNLPOFCAMO(NativeParallelHashSet<Entity> NFLDGMHEJEF, NativeParallelHashSet<Entity> HAPKGJEJNBI, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x70D5810", Offset = "0x70D4010", VA = "0x1870D5810")]
	private static void PFGIDIOBMOC(NativeList<Entity> OCHGNEGGEPP, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x70D1F50", Offset = "0x70D0750", VA = "0x1870D1F50")]
	private NativeParallelHashMap<Entity, ODNCGEHHLPM> HCPAHPDPOPJ(OOMNDIGPCIO.JMHMEBIMHOD BFFENLFEGPC, OFGDPJNMCJP<DIIGOMJGPEP> ENLJGHOHOLG, NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM, List<GameObject> JCDDPJABKNH)
	{
		return default(NativeParallelHashMap<Entity, ODNCGEHHLPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x70D1070", Offset = "0x70CF870", VA = "0x1870D1070")]
	private void BIJJDDLDBHM(NativeList<Entity> FCDFEIBGLOK, NativeList<Entity> IAHHIIJGMKB, NativeParallelHashMap<Entity, ODNCGEHHLPM> JNKHJJEJKMM, NativeList<LGIPPHGAGPO> INILFEOFHKD, NativeList<JIKFLLDMDJN> HIJEBHKPPPN, NativeList<NNOBJPAMDNJ> NDNHGJGALPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x70D2F90", Offset = "0x70D1790", VA = "0x1870D2F90")]
	private void IGLDEOEGJJP(NativeList<Entity> NFLDGMHEJEF, NativeList<Entity> AMPAKEENBAD, NativeParallelHashMap<Entity, ODNCGEHHLPM> JNKHJJEJKMM, NativeList<PEJEFJCLCEB> EIAFAINMGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	public GDGMHGLFFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class IFJJJJIDHCH : AAOBMMOFFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly UniformTRS OMCMFPGOOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly COHFKJEBDIE NCCLECGLDAO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject LIGFIIOLPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS CJGGNOMGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x70DB2B0", Offset = "0x70D9AB0", VA = "0x1870DB2B0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 IKKAPIEHBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x70DB390", Offset = "0x70D9B90", VA = "0x1870DB390", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 PKMBBAPCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x70DB3E0", Offset = "0x70D9BE0", VA = "0x1870DB3E0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 HLGMIDMAOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x70DB260", Offset = "0x70D9A60", VA = "0x1870DB260", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x70DB210", Offset = "0x70D9A10", VA = "0x1870DB210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion FFPLCIFKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x70DB080", Offset = "0x70D9880", VA = "0x1870DB080", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x70DB170", Offset = "0x70D9970", VA = "0x1870DB170", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 DNDECGACJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x70DB1C0", Offset = "0x70D99C0", VA = "0x1870DB1C0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 BKAOIPBCNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70DB0D0", Offset = "0x70D98D0", VA = "0x1870DB0D0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 EOKHLDNNIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x70DB120", Offset = "0x70D9920", VA = "0x1870DB120", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x70DB430", Offset = "0x70D9C30", VA = "0x1870DB430")]
	public IFJJJJIDHCH(UniformTRS OMCMFPGOOFL, COHFKJEBDIE NCCLECGLDAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class CKDBCCHNFIK : IFJJJJIDHCH, LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float BCAMIMKLAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly float3 CGIFOCMCAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CEBKHCOPPLM GINDLHIINKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly PJFDOHDFBLL HNHLDOPPHMH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private IGANFMNEEBA BJDENKKLINB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70CE130", Offset = "0x70CC930", VA = "0x1870CE130", Slot = "17")]
		get
		{
			return default(IGANFMNEEBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS BMIOEMNMCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x70CE050", Offset = "0x70CC850", VA = "0x1870CE050", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float ENDFCJHMJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x924D00", Offset = "0x923500", VA = "0x180924D00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 GBHJFELHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x70CE000", Offset = "0x70CC800", VA = "0x1870CE000", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private CEBKHCOPPLM KENEOPHEBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA87F30", Offset = "0xA86730", VA = "0x180A87F30", Slot = "21")]
		get
		{
			return default(CEBKHCOPPLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private PJFDOHDFBLL KDHKOKILOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xF00D90", Offset = "0xEFF590", VA = "0x180F00D90", Slot = "22")]
		get
		{
			return default(PJFDOHDFBLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool GNALDKJKGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FNEHAEHCFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x70CE180", Offset = "0x70CC980", VA = "0x1870CE180")]
	protected CKDBCCHNFIK(UniformTRS OMCMFPGOOFL, COHFKJEBDIE NCCLECGLDAO, float BCAMIMKLAPP, float3 CGIFOCMCAIF, CEBKHCOPPLM GINDLHIINKD, PJFDOHDFBLL HNHLDOPPHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BDDPIJBELMA
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x70CDB20", Offset = "0x70CC320", VA = "0x1870CDB20")]
	public static void HOIHNODKELE(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH, IPOCMNFOENG KAMFEBINFNJ, PJJOGJFNMIM HIOGCNEKLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x70CD5B0", Offset = "0x70CBDB0", VA = "0x1870CD5B0")]
	public static void BGGGKGGGCJG(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH, IPOCMNFOENG KAMFEBINFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x70CDAE0", Offset = "0x70CC2E0", VA = "0x1870CDAE0")]
	public static NativeList<Entity> HLDGDFGNLFF(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x70CD830", Offset = "0x70CC030", VA = "0x1870CD830")]
	public static NativeList<Entity> CAIDEPAMOJK(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x70CD870", Offset = "0x70CC070", VA = "0x1870CD870")]
	private static NativeList<Entity> HLDGDFGNLFF(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH, bool GHMJPJENGJJ)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class MPOCNALLHIF : AAOBMMOFFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly NLPICMPDONC JDJHDGCHHFG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected COHFKJEBDIE OKJEJOLANIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xCF5EE0", Offset = "0xCF46E0", VA = "0x180CF5EE0")]
		get
		{
			return default(COHFKJEBDIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity MEGDLLJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x70E0F60", Offset = "0x70DF760", VA = "0x1870E0F60")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected PJJOGJFNMIM KJPEHNEANDN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x70E1970", Offset = "0x70E0170", VA = "0x1870E1970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected JIKKDKGBDLB POADOIIONBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x70E1520", Offset = "0x70DFD20", VA = "0x1870E1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected IMJOBFPMAKJ LNEHDOKPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70E16B0", Offset = "0x70DFEB0", VA = "0x1870E16B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject LIGFIIOLPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70E1C30", Offset = "0x70E0430", VA = "0x1870E1C30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS CJGGNOMGKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD18BB0", Offset = "0xD173B0", VA = "0x180D18BB0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 IKKAPIEHBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x70E1980", Offset = "0x70E0180", VA = "0x1870E1980", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 PKMBBAPCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70E1AB0", Offset = "0x70E02B0", VA = "0x1870E1AB0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 HLGMIDMAOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70E1840", Offset = "0x70E0040", VA = "0x1870E1840", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70E1740", Offset = "0x70DFF40", VA = "0x1870E1740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion FFPLCIFKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x70E0F80", Offset = "0x70DF780", VA = "0x1870E0F80", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x70E1420", Offset = "0x70DFC20", VA = "0x1870E1420", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 DNDECGACJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x70E1580", Offset = "0x70DFD80", VA = "0x1870E1580", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 BKAOIPBCNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x70E10A0", Offset = "0x70DF8A0", VA = "0x1870E10A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 EOKHLDNNIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x70E1260", Offset = "0x70DFA60", VA = "0x1870E1260", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9EFD40", VA = "0x1809F1540")]
	protected MPOCNALLHIF(NLPICMPDONC KKPONDJIGMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x70DBCC0", Offset = "0x70DA4C0", VA = "0x1870DBCC0")]
	public static IGANFMNEEBA FMEIMHFCNHG(MPOCNALLHIF EBDGHJJPDEM)
	{
		return default(IGANFMNEEBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DJLEKMELOEH
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x70CE3D0", Offset = "0x70CCBD0", VA = "0x1870CE3D0")]
	public static void BKBLCELOMPD(NativeArray<Entity> NFLDGMHEJEF, EntityManager MOHAGLEGECH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class JDBMIAIKBMD : MPOCNALLHIF, LHBMJJFFGPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private float BCAMIMKLAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 CGIFOCMCAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private CEBKHCOPPLM GINDLHIINKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private PJFDOHDFBLL HNHLDOPPHMH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager LMPOOGFFNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x70DBA70", Offset = "0x70DA270", VA = "0x1870DBA70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GIAJMCLBEFD EEGIJJFADFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x70DBCF0", Offset = "0x70DA4F0", VA = "0x1870DBCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData LNGMNBGJDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x70DB9E0", Offset = "0x70DA1E0", VA = "0x1870DB9E0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private IGANFMNEEBA BJDENKKLINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x70DBCC0", Offset = "0x70DA4C0", VA = "0x1870DBCC0", Slot = "17")]
		get
		{
			return default(IGANFMNEEBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float ENDFCJHMJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB07540", Offset = "0xB05D40", VA = "0x180B07540", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 GBHJFELHDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1108E00", Offset = "0x1107600", VA = "0x181108E00", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private CEBKHCOPPLM KENEOPHEBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250", Slot = "21")]
		get
		{
			return default(CEBKHCOPPLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private PJFDOHDFBLL KDHKOKILOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCEF3B0", Offset = "0xCEDBB0", VA = "0x180CEF3B0", Slot = "22")]
		get
		{
			return default(PJFDOHDFBLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS BMIOEMNMCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xD18BB0", Offset = "0xD173B0", VA = "0x180D18BB0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool FNEHAEHCFND
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8E3DA0", Offset = "0x8E25A0", VA = "0x1808E3DA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8E3B20", Offset = "0x8E2320", VA = "0x1808E3B20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool GNALDKJKGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x70DBD80", Offset = "0x70DA580", VA = "0x1870DBD80")]
	protected JDBMIAIKBMD(NLPICMPDONC KKPONDJIGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x70DBB30", Offset = "0x70DA330", VA = "0x1870DBB30", Slot = "26")]
	public virtual void LHNLPLKLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class PCFBPCNCLBA : BGBDLDKINMC, NAFMJLPHDHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected PJJOGJFNMIM HIOGCNEKLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LMDHMHAKCOB AFFIFGJEAGI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected IPOCMNFOENG HINKIGIPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x70E4C30", Offset = "0x70E3430", VA = "0x1870E4C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected NNAOBFCCCAA NDLGLFPPHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x70E4B70", Offset = "0x70E3370", VA = "0x1870E4B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x70E4BC0", Offset = "0x70E33C0", VA = "0x1870E4BC0", Slot = "15")]
	public virtual void InitReferences(IMGHKCMNGFB AFLKPGNHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
	protected PCFBPCNCLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KGMNBLNFHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x70DC5A0", Offset = "0x70DADA0", VA = "0x1870DC5A0")]
	public static void PEBFKCJCLJA(NativeArray<Entity> FCDFEIBGLOK, EntityManager MOHAGLEGECH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3797449613
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x70EAF80", Offset = "0x70E9780", VA = "0x1870EAF80")]
	public static void JBKONBKIOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x70EAF70", Offset = "0x70E9770", VA = "0x1870EAF70")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class PLNPDNBEFIB : ContainerPropertyBag<KOPGDPEDDJA>
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x70E4E20", Offset = "0x70E3620", VA = "0x1870E4E20")]
	public PLNPDNBEFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class NICCDFOJKGB : ContainerPropertyBag<HOOMBAGNDBL>
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x70E2400", Offset = "0x70E0C00", VA = "0x1870E2400")]
	public NICCDFOJKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class ACDFHFBGINE : ContainerPropertyBag<CALNGFBIGFB>
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x70CC280", Offset = "0x70CAA80", VA = "0x1870CC280")]
	public ACDFHFBGINE()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70E9F50", Offset = "0x70E8750", VA = "0x1870E9F50")]
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
