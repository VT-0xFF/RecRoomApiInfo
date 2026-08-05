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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_RendererV1_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76197F0", Offset = "0x7618BF0", VA = "0x1876197F0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E06FF0", Offset = "0x1E063F0", VA = "0x181E06FF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76226E0", Offset = "0x7621AE0", VA = "0x1876226E0")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7622C80", Offset = "0x7622080", VA = "0x187622C80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7622CE0", Offset = "0x76220E0", VA = "0x187622CE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JCOINFMPLBK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7616850", Offset = "0x7615C50", VA = "0x187616850")]
	public static Quaternion OPBKLKHJPAL([In] this MOFBEMKMNKK FGLHGHDGDNL, [In] Vector3 BNCGOADGBEC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BKOIHBLBICF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76059C0", Offset = "0x7604DC0", VA = "0x1876059C0")]
	public static bool GMLEHFIGPKI(this OMGPNKEPIHM JBENCCOBBHH, EDJKJELJDNI JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76066C0", Offset = "0x7605AC0", VA = "0x1876066C0")]
	public static bool LLLCIBANFFN(this OMGPNKEPIHM JBENCCOBBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7605A00", Offset = "0x7604E00", VA = "0x187605A00")]
	public static bool HBANDJKPHCA(this OMGPNKEPIHM JBENCCOBBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x76066F0", Offset = "0x7605AF0", VA = "0x1876066F0")]
	public static void LOJFGGPGHAN(this OMGPNKEPIHM JBENCCOBBHH, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7606F80", Offset = "0x7606380", VA = "0x187606F80")]
	public static void OMAGJJMPCJI(this OMGPNKEPIHM JBENCCOBBHH, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG, int INOGBBDPDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76058A0", Offset = "0x7604CA0", VA = "0x1876058A0")]
	public static void FNDGMFPLHPL(this OMGPNKEPIHM JBENCCOBBHH, int INOGBBDPDLJ, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7606820", Offset = "0x7605C20", VA = "0x187606820")]
	public static void MEAMEAIFJEG(this OMGPNKEPIHM JBENCCOBBHH, Vector3 APPJOBFCCCM, Quaternion IGGDJPADDMG, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7605C50", Offset = "0x7605050", VA = "0x187605C50")]
	private static void JEPJCFNHICM(this OMGPNKEPIHM JBENCCOBBHH, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7605440", Offset = "0x7604840", VA = "0x187605440")]
	private static void AGBHPMMALLN(this OMGPNKEPIHM JBENCCOBBHH, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7605A30", Offset = "0x7604E30", VA = "0x187605A30")]
	private static void HHHGLBIIDHE(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7605C20", Offset = "0x7605020", VA = "0x187605C20")]
	private static bool JCPEEMKBPPD(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7605600", Offset = "0x7604A00", VA = "0x187605600")]
	private static void DGNJDGMJDCI(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7606A90", Offset = "0x7605E90", VA = "0x187606A90")]
	public static Vector3 OLHJLNGKDCP(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76065B0", Offset = "0x76059B0", VA = "0x1876065B0")]
	public static Quaternion KPPCNMJKMKI(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7606870", Offset = "0x7605C70", VA = "0x187606870")]
	public static Vector3 OBIMPKCOGLM(EDJKJELJDNI PNCPEFMKILJ, Vector3 NDADPNJPMFO, Vector3? EMPJHKPCCAH, Vector3 CNOFPGCGFHF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface KJAKJKJFOEC
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface HFEFCPGMDEA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType NEPOAADMDML
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GEIJBKIPBPE : KJAKJKJFOEC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7610960", Offset = "0x760FD60", VA = "0x187610960", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public GEIJBKIPBPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class LGEIOMHELKC : KJAKJKJFOEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MDOKODFBGBL OEIGHBFCMEO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
	public LGEIOMHELKC(MDOKODFBGBL OEIGHBFCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7618AE0", Offset = "0x7617EE0", VA = "0x187618AE0", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class POKODPGILHM : KJAKJKJFOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x761E770", Offset = "0x761DB70", VA = "0x18761E770", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public POKODPGILHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OFKDMLAALMG : HFEFCPGMDEA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType NEPOAADMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x761DD80", Offset = "0x761D180", VA = "0x18761DD80", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x761D830", Offset = "0x761CC30", VA = "0x18761D830", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x761DB00", Offset = "0x761CF00", VA = "0x18761DB00", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x761DAB0", Offset = "0x761CEB0", VA = "0x18761DAB0", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public OFKDMLAALMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JOPMFOKCNIF : HFEFCPGMDEA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType NEPOAADMDML
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7616E80", Offset = "0x7616280", VA = "0x187616E80", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7616930", Offset = "0x7615D30", VA = "0x187616930", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7616C00", Offset = "0x7616000", VA = "0x187616C00", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7616BB0", Offset = "0x7615FB0", VA = "0x187616BB0", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public JOPMFOKCNIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FIAJDIMNOKI : HFEFCPGMDEA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType NEPOAADMDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7610850", Offset = "0x760FC50", VA = "0x187610850", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7610300", Offset = "0x760F700", VA = "0x187610300", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76105D0", Offset = "0x760F9D0", VA = "0x1876105D0", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7610580", Offset = "0x760F980", VA = "0x187610580", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FIAJDIMNOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FDHCNCHBPML : GNKNFKJHPCF, GMBJCCNEDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AKJLCMLCONF KPHLIDJMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JLLLEOFLDKA MDFEHLNANMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OBFOPMLNHAJ GDNPGEGAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, KJAKJKJFOEC adapter)> IADPEDCDLAG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x760F460", Offset = "0x760E860", VA = "0x18760F460", Slot = "15")]
	public virtual void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x760F4F0", Offset = "0x760E8F0", VA = "0x18760F4F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x760F2F0", Offset = "0x760E6F0", VA = "0x18760F2F0")]
	private void CEAKCPDFPFE(EntityQueryDesc APNLALLMOMO, KJAKJKJFOEC BOLLEAKOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x760F720", Offset = "0x760EB20", VA = "0x18760F720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
	public FDHCNCHBPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class NLANOELBPJJ : GNKNFKJHPCF, GMBJCCNEDOA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NPLAEGGIMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery MACABHGANFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery NBOGDDKOIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery GFFMHPGLPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery GOPOFKHIDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery PMLNMKCEPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery MDLIEMMPGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery JEKCNJHDMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HFEFCPGMDEA KEJJFKFGMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType LIDEFGLMMMD;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NPLAEGGIMKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AKJLCMLCONF KPHLIDJMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OBFOPMLNHAJ GDNPGEGAOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JLLLEOFLDKA MDFEHLNANMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<NPLAEGGIMKF> IADPEDCDLAG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x761C9E0", Offset = "0x761BDE0", VA = "0x18761C9E0", Slot = "14")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x761CEC0", Offset = "0x761C2C0", VA = "0x18761CEC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x761D040", Offset = "0x761C440", VA = "0x18761D040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x761CA70", Offset = "0x761BE70", VA = "0x18761CA70")]
	private void OAOCAIOMCBM(NPLAEGGIMKF EKCONHEOFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x761C2A0", Offset = "0x761B6A0", VA = "0x18761C2A0")]
	private void CEAKCPDFPFE(HFEFCPGMDEA KEJJFKFGMOA, ComponentType CJJBMHEOEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
	public NLANOELBPJJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct MFAKBPLKBFK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct LNMBLHDOJCB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct OOBAICKCEDK : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(OBFOPMLNHAJ), new string[] { })]
public class FPNENPDCKOJ : OBFOPMLNHAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FFCHMNNCDPE LGBOACBHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FFCHMNNCDPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FPNENPDCKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(KADHNIAOJGG), new string[] { })]
public class FDEOLCKDDCI : KADHNIAOJGG, ADIIDOPLHDP, ENAMDDMDDNO, EKIGFHLMNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private GDMALILFBDO ENFBJMHAMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private AKJLCMLCONF KPHLIDJMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private ANDACNBFJKF JJPIAJMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity PJNIIPOKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private DGKNAAFCKEM GHOIIEJIFLP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x760EDB0", Offset = "0x760E1B0", VA = "0x18760EDB0", Slot = "4")]
	public bool AEJBKDCDDDH(FHNHGOPNICC KPOCLGHHOEP, MCJIKLCEHHO KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x760F030", Offset = "0x760E430", VA = "0x18760F030", Slot = "5")]
	public DGKNAAFCKEM LOOLAEAPJBD()
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x760EE90", Offset = "0x760E290", VA = "0x18760EE90", Slot = "6")]
	public void BGDBNNONMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x760EFA0", Offset = "0x760E3A0", VA = "0x18760EFA0", Slot = "7")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xF8B990", Offset = "0xF8AD90", VA = "0x180F8B990", Slot = "8")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FDEOLCKDDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BOMHNKIDBAA), new string[] { })]
public class LAKHAHJFMIL : BOMHNKIDBAA
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7618140", Offset = "0x7617540", VA = "0x187618140", Slot = "4")]
	public void HALELABMJKE(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76180F0", Offset = "0x76174F0", VA = "0x1876180F0", Slot = "5")]
	public void GCOLGNFLEPO(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7618A20", Offset = "0x7617E20", VA = "0x187618A20", Slot = "6")]
	public ComponentSystemBase NNFBCGIIGKL(World ENFBJMHAMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7618090", Offset = "0x7617490", VA = "0x187618090", Slot = "7")]
	public void EAIHIKJGCGG(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76181C0", Offset = "0x76175C0", VA = "0x1876181C0", Slot = "8")]
	public void HNPNNLNNEEE(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7618030", Offset = "0x7617430", VA = "0x187618030", Slot = "9")]
	public void AKPOJNGDJIH(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7618A70", Offset = "0x7617E70", VA = "0x187618A70", Slot = "10")]
	public void OOOOJLFIILA(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7618220", Offset = "0x7617620", VA = "0x187618220", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> KNBPBFOMJHC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public LAKHAHJFMIL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NMJINGMPAHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HNFDIBAIMJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CJLKCNMJBBN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GGPLGOGDNFL EIABDHAPLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7607F50", Offset = "0x7607350", VA = "0x187607F50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7607EE0", Offset = "0x76072E0", VA = "0x187607EE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public CJLKCNMJBBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct AHANPLHIEFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public DGKNAAFCKEM EADDGEHONEO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static AHANPLHIEFJ HEGJABMHLEC(DGKNAAFCKEM ILIIBOPHLDK)
	{
		return default(AHANPLHIEFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MGMNMOFFJEL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LIJGIKFJLHJ LAIECHLPADI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7619B70", Offset = "0x7618F70", VA = "0x187619B70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public MGMNMOFFJEL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MDNCEEJAKBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ELKFIAKMCHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EEGJHJCMEBL OAHFDOHMLKM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static ELKFIAKMCHC HEGJABMHLEC(EEGJHJCMEBL ILIIBOPHLDK)
	{
		return default(ELKFIAKMCHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OEDPOOFKPCG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DGKNAAFCKEM EADDGEHONEO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static OEDPOOFKPCG HEGJABMHLEC(DGKNAAFCKEM ILIIBOPHLDK)
	{
		return default(OEDPOOFKPCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NNOEEILDDMH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MIIIGIALJDC JPLCLCKFMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x761D350", Offset = "0x761C750", VA = "0x18761D350", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x761D2E0", Offset = "0x761C6E0", VA = "0x18761D2E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public NNOEEILDDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JBKIAFNCEKL : PHKMGPACMAE, GGPLGOGDNFL, MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OMANHOCOLNE FJHDNLPGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BD0", Offset = "0xBC2FD0", VA = "0x180BC3BD0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(OMANHOCOLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HFKONJBLIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA994E0", Offset = "0xA988E0", VA = "0x180A994E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 AGNHKCCLAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xED0690", Offset = "0xECFA90", VA = "0x180ED0690", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76167B0", Offset = "0x7615BB0", VA = "0x1876167B0")]
	public JBKIAFNCEKL(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK, float LNCPFBAGODO, float3 OBIIJDFBCJG, MONBNMPFMMO CABJAJKOCKF, CEHJAJCAOIA EFDCMEMHPCM, OMANHOCOLNE GOAJLEACEKF, float3 DBIFFOKDKEJ, bool HLJLOIPIKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7616760", Offset = "0x7615B60", VA = "0x187616760", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IEFPEFAHDMN : PHKMGPACMAE, MIIIGIALJDC, MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<MJHFHLJEIGI> EAOJFACDCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly CBJMMJDEABF FJJOKDBOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float MMHCLBPDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int ENCHIMLCJAD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BOAGBKMLGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76166A0", Offset = "0x7615AA0", VA = "0x1876166A0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EJGEJEKCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76166C0", Offset = "0x7615AC0", VA = "0x1876166C0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KFEKJCLAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76166B0", Offset = "0x7615AB0", VA = "0x1876166B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BONNAGJGKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC07FD0", Offset = "0xC073D0", VA = "0x180C07FD0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PPAPPOJMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB39E10", Offset = "0xB39210", VA = "0x180B39E10", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HOOGEGKJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xD72810", Offset = "0xD71C10", VA = "0x180D72810", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x76165F0", Offset = "0x76159F0", VA = "0x1876165F0")]
	public IEFPEFAHDMN(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK, float LNCPFBAGODO, float3 OBIIJDFBCJG, MONBNMPFMMO CABJAJKOCKF, CEHJAJCAOIA EFDCMEMHPCM, CBJMMJDEABF FJJOKDBOKAE, float MMHCLBPDOPA, int ENCHIMLCJAD, NativeArray<MJHFHLJEIGI> EAOJFACDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEE7A40", Offset = "0xEE6E40", VA = "0x180EE7A40", Slot = "33")]
	public NativeArray<MJHFHLJEIGI> GetNativeCurvePoints()
	{
		return default(NativeArray<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7616530", Offset = "0x7615930", VA = "0x187616530", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HNOHDHKEBKM : PPBAOJFJHKE, GGPLGOGDNFL, MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<OFHIFDOIEMG, OMANHOCOLNE> FJKGKFGAIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private OMANHOCOLNE GOAJLEACEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool HLJLOIPIKHL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private OMANHOCOLNE NFAOOOMDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x968620", Offset = "0x967A20", VA = "0x180968620", Slot = "28")]
		get
		{
			return default(OMANHOCOLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CBJOLKCLKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCBE180", Offset = "0xCBD580", VA = "0x180CBE180", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 AGNHKCCLAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7616460", Offset = "0x7615860", VA = "0x187616460", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7616440", Offset = "0x7615840", VA = "0x187616440")]
	public HNOHDHKEBKM(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7615DB0", Offset = "0x76151B0", VA = "0x187615DB0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7615E00", Offset = "0x7615200", VA = "0x187615E00", Slot = "26")]
	public override void PLJNMJIHBJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PGJFABICBND : CIPFFGLHPPM, LIJGIKFJLHJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject FJKHFLCIHKD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject PFCBGIFALLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x761DF50", Offset = "0x761D350", VA = "0x18761DF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LCHJICBNMPB KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x761DE50", Offset = "0x761D250", VA = "0x18761DE50", Slot = "15")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BBEOEDALAPE IFPHMOGCGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x761E410", Offset = "0x761D810", VA = "0x18761E410", Slot = "16")]
		get
		{
			return default(BBEOEDALAPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x761E2C0", Offset = "0x761D6C0", VA = "0x18761E2C0")]
	public PGJFABICBND(FHNHGOPNICC KPOCLGHHOEP, bool DDMBLFMOMEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x761DFE0", Offset = "0x761D3E0", VA = "0x18761DFE0")]
	public void KPOAHJNHEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x761DE50", Offset = "0x761D250", VA = "0x18761DE50")]
	protected LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x761E170", Offset = "0x761D570", VA = "0x18761E170")]
	private static bool PHPPMOLNPLC(FHNHGOPNICC NFNFJFJJBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x761DE20", Offset = "0x761D220", VA = "0x18761DE20", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BEDKMEAJGIC : PPBAOJFJHKE, MIIIGIALJDC, MBADBELKHDK, IDisposable, DGCJMFNLGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<MJHFHLJEIGI> EAOJFACDCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool NACAINHGGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BCPNHELDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float MMHCLBPDOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int ENCHIMLCJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool KPJDJHGBJNG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JFFMKHOLALE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A00", Offset = "0xAA5E00", VA = "0x180AA6A00", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IACEAEJIIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x995960", Offset = "0x994D60", VA = "0x180995960", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float LFHCEDMPJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE93860", Offset = "0xE92C60", VA = "0x180E93860", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int KMJBPAFOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BD0", Offset = "0xBC2FD0", VA = "0x180BC3BD0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool BGJMGOCHNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA994E0", Offset = "0xA988E0", VA = "0x180A994E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int KAFKBFIGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76048D0", Offset = "0x7603CD0", VA = "0x1876048D0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int EOFLFINGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7605000", Offset = "0x7604400", VA = "0x187605000", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76051D0", Offset = "0x76045D0", VA = "0x1876051D0")]
	public BEDKMEAJGIC(FHNHGOPNICC JOFIFDPGHKD, [Optional] NativeList<MJHFHLJEIGI> EAOJFACDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76050F0", Offset = "0x76044F0", VA = "0x1876050F0", Slot = "26")]
	public override void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76048F0", Offset = "0x7603CF0", VA = "0x1876048F0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x76049E0", Offset = "0x7603DE0", VA = "0x1876049E0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7604FA0", Offset = "0x76043A0", VA = "0x187604FA0")]
	public void MODGEBILPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7604C00", Offset = "0x7604000", VA = "0x187604C00", Slot = "34")]
	public NativeArray<MJHFHLJEIGI> GetNativeCurvePoints()
	{
		return default(NativeArray<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7604AB0", Offset = "0x7603EB0", VA = "0x187604AB0", Slot = "35")]
	private Vector3 GGJOFLJMOEF(int MKNOLMMOIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7604F70", Offset = "0x7604370", VA = "0x187604F70", Slot = "36")]
	private Quaternion JFOHDCIIMDD(int MKNOLMMOIDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7604DD0", Offset = "0x76041D0", VA = "0x187604DD0", Slot = "37")]
	private float IOLEGDKPMHG(int MKNOLMMOIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7604A40", Offset = "0x7603E40", VA = "0x187604A40")]
	private NativeArray<Entity> ECCCFKNICAP()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class HKGIBPDEKFK : FFKJDJDBLKL
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x76159E0", Offset = "0x7614DE0", VA = "0x1876159E0", Slot = "15")]
	protected override ComponentSystemBase PNGOBAOIIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76159D0", Offset = "0x7614DD0", VA = "0x1876159D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7615DA0", Offset = "0x76151A0", VA = "0x187615DA0")]
	public HKGIBPDEKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DHHFADPOGDK]
public sealed class MIAEPEBKLBL : LKAODBAHBDH
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery CAJHENHDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery FNAOHPANIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery GCDHFFKOHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery KDBCPLJKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery KOIFMPPNBNB;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x761A3D0", Offset = "0x76197D0", VA = "0x18761A3D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x761A730", Offset = "0x7619B30", VA = "0x18761A730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x761A030", Offset = "0x7619430", VA = "0x18761A030")]
	private void IHHHENNECHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7619F20", Offset = "0x7619320", VA = "0x187619F20")]
	private void GMGDHCHMBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7619BE0", Offset = "0x7618FE0", VA = "0x187619BE0")]
	private void CBNDJGIGGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7619E20", Offset = "0x7619220", VA = "0x187619E20")]
	private void FJHKFLFANJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x761A270", Offset = "0x7619670", VA = "0x18761A270")]
	private void NPAMNGDDKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x761A370", Offset = "0x7619770", VA = "0x18761A370")]
	private NativeList<Entity> OPAPHDFNFOB(NativeArray<Entity> AKCBEPDCJFL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x761A210", Offset = "0x7619610", VA = "0x18761A210")]
	private NativeList<Entity> JIENHKKPOHB(NativeArray<Entity> AKCBEPDCJFL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7619DC0", Offset = "0x76191C0", VA = "0x187619DC0")]
	private void CGGEAEDANDD(NativeArray<Entity> AKCBEPDCJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public MIAEPEBKLBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DHHFADPOGDK]
public sealed class APBOJIBGLCK : LKAODBAHBDH, GMBJCCNEDOA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery BKDCNANHDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery OAAEDFLKNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery GFFMHPGLPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KADHNIAOJGG LILNHKJFIIG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7604630", Offset = "0x7603A30", VA = "0x187604630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7604070", Offset = "0x7603470", VA = "0x187604070", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7604800", Offset = "0x7603C00", VA = "0x187604800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76032D0", Offset = "0x76026D0", VA = "0x1876032D0")]
	private void BOBLHIOLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7603950", Offset = "0x7602D50", VA = "0x187603950")]
	private void FCOOAJKGPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7604280", Offset = "0x7603680", VA = "0x187604280")]
	private void OPCBHPEJKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7603FD0", Offset = "0x76033D0", VA = "0x187603FD0")]
	private bool IFHNGONFHLM(Entity FCJGDHPNMHF, [Out] DGKNAAFCKEM EADDGEHONEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76040D0", Offset = "0x76034D0", VA = "0x1876040D0")]
	private bool JFKOKFDFMNK(Entity FCJGDHPNMHF, [Out] DGKNAAFCKEM EADDGEHONEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public APBOJIBGLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DHHFADPOGDK]
public sealed class NDOFNAHPHMM : LKAODBAHBDH
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery EMKOOHGPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery KOKJEEPIPKP;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x761B440", Offset = "0x761A840", VA = "0x18761B440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x761B590", Offset = "0x761A990", VA = "0x18761B590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x761AE50", Offset = "0x761A250", VA = "0x18761AE50")]
	private void BOBLHIOLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x761B150", Offset = "0x761A550", VA = "0x18761B150")]
	private void FCOOAJKGPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public NDOFNAHPHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FBNOBHKBOEC : LKAODBAHBDH, GMBJCCNEDOA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct OBLBHDGNNDO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob BDMMCCKNGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob HCKBGKBPOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob NJIGGDDEJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob FBEHBOBOFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle NOLOEHADOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<OEDPOOFKPCG> GOFEDCMFMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> JOKENELBCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> BPPOADNHAJA;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x761D7B0", Offset = "0x761CBB0", VA = "0x18761D7B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x761D6D0", Offset = "0x761CAD0", VA = "0x18761D6D0")]
		private void ALJNAPAMOMA(EntityQueryInJob CFNDKJDBFBE, NativeList<Entity> LLHBIOPCNLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct MLCEOFDEBFE : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle NOLOEHADOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<OEDPOOFKPCG> GOFEDCMFMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> LLHBIOPCNLB;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x761A800", Offset = "0x7619C00", VA = "0x18761A800", Slot = "4")]
		public void Execute(ArchetypeChunk FOFCJMGKHPF, int HLMEOLKNLIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct CLBBAFHOOEF : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle NOLOEHADOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> EPGBCGEICGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<ELKFIAKMCHC> MJGJOKAEHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<AHANPLHIEFJ> JAGOOLCGANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<OEDPOOFKPCG> DBAHBHEBDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> KJOLBAPCMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<ELKFIAKMCHC> EGLOOGKHJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<DGKNAAFCKEM> NCKBCKAPFDF;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7607FA0", Offset = "0x76073A0", VA = "0x187607FA0", Slot = "4")]
		public void Execute(ArchetypeChunk FOFCJMGKHPF, int HLMEOLKNLIN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery BDMMCCKNGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery HCKBGKBPOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery NJIGGDDEJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery FBEHBOBOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery KCHKHBBBDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery KGAPECCLGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery CIDLOHILAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private KADHNIAOJGG KGNPMPLKCDJ;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x760E4B0", Offset = "0x760D8B0", VA = "0x18760E4B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x760E000", Offset = "0x760D400", VA = "0x18760E000", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x760EA30", Offset = "0x760DE30", VA = "0x18760EA30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x760DA00", Offset = "0x760CE00", VA = "0x18760DA00")]
	private void HNGKPNKKIOJ(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int OCCGHIHIPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x760E060", Offset = "0x760D460", VA = "0x18760E060")]
	private void LDGFFGPFAFC(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int KBAEPPBFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x760D080", Offset = "0x760C480", VA = "0x18760D080")]
	private void DCMKNFEDAIA(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int COFKAPFMGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x760D670", Offset = "0x760CA70", VA = "0x18760D670")]
	private void GKELCAFCEBM(NativeParallelHashSet<DGKNAAFCKEM> MKJMIEBCBKD, int JABMPBCLEIG, int NOLBLGJAHCA, int DENAFBINLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x760D4C0", Offset = "0x760C8C0", VA = "0x18760D4C0")]
	private void DKJEAIGHNOB(Entity LMLAAEIHJPJ, EEGJHJCMEBL JDHADJGFNJB, DGKNAAFCKEM EADDGEHONEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public FBNOBHKBOEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class LLJFMAGFFOD : LKAODBAHBDH
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery MGMKKHAEPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery NFAKKAIAHOC;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7618C30", Offset = "0x7618030", VA = "0x187618C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7618E70", Offset = "0x7618270", VA = "0x187618E70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public LLJFMAGFFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DHHFADPOGDK]
internal class NKMNAAAOPLD : LKAODBAHBDH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class OOBNLDIKEGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public EntityQuery PPLCNKHIIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery OKPFIIIDDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KJCMHDOJJEN JNLNNHIEEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ComponentType CKFAKHIEANN;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OOBNLDIKEGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private delegate void KJCMHDOJJEN(NativeArray<EEGJHJCMEBL> ILIIBOPHLDK, LNJLGFCNCEA CNPKAHOGCNH);

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<OOBNLDIKEGP> IADPEDCDLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private JLLLEOFLDKA MDFEHLNANMC;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x761B980", Offset = "0x761AD80", VA = "0x18761B980", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x761B9E0", Offset = "0x761ADE0", VA = "0x18761B9E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x761BB70", Offset = "0x761AF70", VA = "0x18761BB70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x353F280", Offset = "0x353E680", VA = "0x18353F280")]
	private void CEAKCPDFPFE<T>(KJCMHDOJJEN JNLNNHIEEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x761B640", Offset = "0x761AA40", VA = "0x18761B640")]
	private static void BHMMHKIGCHO(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x761B7E0", Offset = "0x761ABE0", VA = "0x18761B7E0")]
	private static void EGBDCIKDLCB(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x761C070", Offset = "0x761B470", VA = "0x18761C070")]
	private static void PLKOFCDHMFA(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public NKMNAAAOPLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DHHFADPOGDK]
public sealed class AGPBGDIBGKG : LKAODBAHBDH
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private EntityQuery CFNDKJDBFBE;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7602E20", Offset = "0x7602220", VA = "0x187602E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JMHANPGJGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public UniformTRS OJKHKNKJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public StandardRenderableVisualData CGBJDEICMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public OMANHOCOLNE GOAJLEACEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 DBIFFOKDKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool HLJLOIPIKHL;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DKEJLEFENDL(Lifetime.LoadInstance)]
public struct IOMLJPNNPCO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity BKPGIELGADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> DMHMKEKNCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> NGCKNNJGEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<JMHANPGJGMK> LMKNDBCIEFM;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x76166D0", Offset = "0x7615AD0", VA = "0x1876166D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(KLDPNINNAMO), new string[] { })]
internal class KLDPNINNAMO : GMBJCCNEDOA, CBANIPAPHBJ, ENAMDDMDDNO, EKIGFHLMNBE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct MPJGNLLJOLK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly KLDPNINNAMO LDIAONMHHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly bool MHOFEOILIOO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x155CB70", Offset = "0x155BF70", VA = "0x18155CB70")]
		public MPJGNLLJOLK(KLDPNINNAMO LDIAONMHHPK, bool MHOFEOILIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x761AA50", Offset = "0x7619E50", VA = "0x18761AA50")]
		public Queue<FOOKLENIMIG>.Enumerator BNIMLGJMJBK()
		{
			return default(Queue<FOOKLENIMIG>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x761AB10", Offset = "0x7619F10", VA = "0x18761AB10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[DependsOn]
	private ANDACNBFJKF BGEKAAMBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private IAGBBFEPOKL DFMBBMFGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<NativeList<MJHFHLJEIGI>> KGPPEBAFPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<(Entity, List<GameObject>)> DCGJJGPPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<EEGJHJCMEBL> EBGHFKGMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ENAPFGCOOPM<FOOKLENIMIG> JNEBGLDBACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private ENAPFGCOOPM<IOMLJPNNPCO> ALEFALDMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private ENAPFGCOOPM<PEKELENKGLF> IMIHDHJIAFP;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7617390", Offset = "0x7616790", VA = "0x187617390", Slot = "4")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7617A20", Offset = "0x7616E20", VA = "0x187617A20")]
	public void OPOOJCLGBBK(NativeList<MJHFHLJEIGI> BGOPNEFNKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76170E0", Offset = "0x76164E0", VA = "0x1876170E0")]
	public void BJDPMPKGBDB(Entity LDIAONMHHPK, [In] EFMCPKJOHAF<GameObject> IAAPNEHEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7617590", Offset = "0x7616990", VA = "0x187617590")]
	public void KGECBKFGIHC(NativeList<EEGJHJCMEBL> FEJHOLHIAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7616EB0", Offset = "0x76162B0", VA = "0x187616EB0")]
	public void AKPOJNGDJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7617AF0", Offset = "0x7616EF0", VA = "0x187617AF0")]
	public void PPPFIKANINK(JIMDDOODGGB JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76178E0", Offset = "0x7616CE0", VA = "0x1876178E0")]
	public JobHandle NBHHDLCNONM([In] FOOKLENIMIG MIALAMIFNLM, JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7617840", Offset = "0x7616C40", VA = "0x187617840")]
	public JobHandle NBHHDLCNONM([In] IOMLJPNNPCO MIALAMIFNLM, JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7307CA0", Offset = "0x73070A0", VA = "0x187307CA0")]
	public MPJGNLLJOLK AJIILNNMAKI(bool MHOFEOILIOO)
	{
		return default(MPJGNLLJOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7617980", Offset = "0x7616D80", VA = "0x187617980")]
	public LMCGHNEGPJF<IOMLJPNNPCO> NMIAANGCCCM()
	{
		return default(LMCGHNEGPJF<IOMLJPNNPCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76179D0", Offset = "0x7616DD0", VA = "0x1876179D0")]
	public LMCGHNEGPJF<PEKELENKGLF> NPOCGDPMOAP()
	{
		return default(LMCGHNEGPJF<PEKELENKGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7617620", Offset = "0x7616A20", VA = "0x187617620")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7617240", Offset = "0x7616640", VA = "0x187617240", Slot = "5")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7617320", Offset = "0x7616720", VA = "0x187617320", Slot = "6")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xF82900", Offset = "0xF81D00", VA = "0x180F82900", Slot = "7")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public KLDPNINNAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EDCBAFLAMEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public UniformTRS OJKHKNKJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public StandardRenderableVisualData CGBJDEICMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GHMFPPOCHDI FJJOKDBOKAE;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DKEJLEFENDL(Lifetime.LoadInstance)]
public struct FOOKLENIMIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity BKPGIELGADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeList<Entity> AKCBEPDCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> DMHMKEKNCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeParallelHashSet<Entity> NGCKNNJGEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeList<AFAOEOIHAIH> HFKGPPBMPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<MJHFHLJEIGI> BGOPNEFNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<EDCBAFLAMEJ> EPKFBBNKDOA;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7610880", Offset = "0x760FC80", VA = "0x187610880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7610890", Offset = "0x760FC90", VA = "0x187610890")]
	public void GDCMIOJAIMJ(bool MHOFEOILIOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.LoadInstance)]
[RegisterService(typeof(AKBGADHEIIE), new string[] { })]
internal class AKBGADHEIIE : AJGNCJKKCHD, ENAMDDMDDNO, EKIGFHLMNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[DependsOn]
	private KLDPNINNAMO HGCNPFLPFPL;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x76032B0", Offset = "0x76026B0", VA = "0x1876032B0", Slot = "4")]
	public void HGJMKMEOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7603260", Offset = "0x7602660", VA = "0x187603260", Slot = "5")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xF5B430", Offset = "0xF5A830", VA = "0x180F5B430", Slot = "6")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public AKBGADHEIIE()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	public class PostDeserializeBakeShapesSystem : LKAODBAHBDH, GMBJCCNEDOA
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public NativeParallelHashMap<int, OMANHOCOLNE> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<JMHANPGJGMK> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7610B70", Offset = "0x760FF70", VA = "0x187610B70", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[ReadOnly]
			public NativeArray<MJHFHLJEIGI> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public NativeArray<AFAOEOIHAIH> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public NativeArray<EDCBAFLAMEJ> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7610F10", Offset = "0x7610310", VA = "0x187610F10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x76082D0", Offset = "0x76076D0", VA = "0x1876082D0", Slot = "4")]
			public void Execute(ArchetypeChunk batchInChunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[BurstCompile]
		private struct GeneratePointsJob : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct PointSrcData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0x761E8B0", Offset = "0x761DCB0", VA = "0x18761E8B0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x761E8D0", Offset = "0x761DCD0", VA = "0x18761E8D0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 GPBCIIOEANP(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x7619400", Offset = "0x7618800", VA = "0x187619400", Slot = "5")]
				public float3 BHFHGEIMKPH(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x76197B0", Offset = "0x7618BB0", VA = "0x1876197B0", Slot = "4")]
				public float3 GPBCIIOEANP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x761D3A0", Offset = "0x761C7A0", VA = "0x18761D3A0", Slot = "4")]
				public float3 GPBCIIOEANP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public NativeArray<AFAOEOIHAIH> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeArray<MJHFHLJEIGI> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7612260", Offset = "0x7611660", VA = "0x187612260", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x76128C0", Offset = "0x7611CC0", VA = "0x1876128C0")]
			private void GDLDDPLNHKH(NativeList<PointSrcData> srcData, NativeList<MJHFHLJEIGI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7611B60", Offset = "0x7610F60", VA = "0x187611B60")]
			public static Vector3 CAHNMABPIPJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7613F00", Offset = "0x7613300", VA = "0x187613F00")]
			public static quaternion JOFAKENPBOK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7614170", Offset = "0x7613570", VA = "0x187614170")]
			private static quaternion MMEANCONLAE(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7611630", Offset = "0x7610A30", VA = "0x187611630")]
			private static float3 APDEAMMJLBK(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7613A10", Offset = "0x7612E10", VA = "0x187613A10")]
			private static quaternion IFCPHDKKFNN(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x76137A0", Offset = "0x7612BA0", VA = "0x1876137A0")]
			private static MJHFHLJEIGI IAHMJJDOLEF(int idx, NativeList<PointSrcData> srcData)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7520", Offset = "0x3AE6920", VA = "0x183AE7520")]
			private void KDBNHDBCEHE<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x76143A0", Offset = "0x76137A0", VA = "0x1876143A0")]
			private void NDOPKHEMNDP(NativeList<PointSrcData> sourcePoints, NativeList<MJHFHLJEIGI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x76120E0", Offset = "0x76114E0", VA = "0x1876120E0")]
			public static float COOHHFDLOHF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7613F80", Offset = "0x7613380", VA = "0x187613F80")]
			private static quaternion KBIGDBODKOE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7615240", Offset = "0x7614640", VA = "0x187615240")]
			private static MJHFHLJEIGI OAKIGDAKPGG(PointSrcData point)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76151B0", Offset = "0x76145B0", VA = "0x1876151B0")]
			private static MJHFHLJEIGI OAKIGDAKPGG(float3 pos, quaternion rot, float radius)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7611F70", Offset = "0x7611370", VA = "0x187611F70")]
			private static bool CCPCMKMDGJJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7612010", Offset = "0x7611410", VA = "0x187612010")]
			private static float3 CNJKLDCAJJJ(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7611800", Offset = "0x7610C00", VA = "0x187611800")]
			public static float3 BENOIFIEDIH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x76119B0", Offset = "0x7610DB0", VA = "0x1876119B0")]
			public static float3 BHFHGEIMKPH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7613AA0", Offset = "0x7612EA0", VA = "0x187613AA0")]
			private static quaternion IMOCKCGDNLM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7615360", Offset = "0x7614760", VA = "0x187615360")]
			private static float PCPFIFCFEOE(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x76209C0", Offset = "0x761FDC0", VA = "0x1876209C0")]
			private void BHOFAMFOGJP(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7620AA0", Offset = "0x761FEA0", VA = "0x187620AA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public NativeList<MJHFHLJEIGI> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x76222F0", Offset = "0x76216F0", VA = "0x1876222F0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7622350", Offset = "0x7621750", VA = "0x187622350", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SetSplinePointCapacity_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<MJHFHLJEIGI> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7622290", Offset = "0x7621690", VA = "0x187622290")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x76222E0", Offset = "0x76216E0", VA = "0x1876222E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherPrimitivesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public NativeList<JMHANPGJGMK> data;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7611250", Offset = "0x7610650", VA = "0x187611250")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7611410", Offset = "0x7610810", VA = "0x187611410", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherSplinesAndUniqueParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public NativeList<AFAOEOIHAIH> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<EDCBAFLAMEJ> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7611420", Offset = "0x7610820", VA = "0x187611420")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7611620", Offset = "0x7610A20", VA = "0x187611620", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct RemoveDestroyedEntitiesFromParents_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7621E60", Offset = "0x7621260", VA = "0x187621E60")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7622280", Offset = "0x7621680", VA = "0x187622280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static readonly IBCMILIKEJG log;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private DKLOBKFLFLH replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private ANDACNBFJKF objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private KLDPNINNAMO bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private JMJCKDEDKLJ ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x761FCC0", Offset = "0x761F0C0", VA = "0x18761FCC0", Slot = "15")]
		public override void InitReferences(APLBLLDKDCG services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7621640", Offset = "0x7620A40", VA = "0x187621640", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7621730", Offset = "0x7620B30", VA = "0x187621730", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7621790", Offset = "0x7620B90", VA = "0x187621790", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7620FB0", Offset = "0x76203B0", VA = "0x187620FB0")]
		private JobHandle OBLGKLDOIPO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x761F600", Offset = "0x761EA00", VA = "0x18761F600")]
		private JobHandle HFPHIPIJOKN(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x761F560", Offset = "0x761E960", VA = "0x18761F560")]
		private JobHandle GJPHEOEMCEN(NativeArray<int> pointCount, NativeList<MJHFHLJEIGI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x761EA30", Offset = "0x761DE30", VA = "0x18761EA30")]
		private JobHandle BAIOGCABFDJ(NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7621900", Offset = "0x7620D00", VA = "0x187621900")]
		private JobHandle PFPNCLALONC(EntityQuery query, NativeList<AFAOEOIHAIH> splinePointRanges, NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x761F360", Offset = "0x761E760", VA = "0x18761F360")]
		private JobHandle FIBLPPJDMPI(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x761EAD0", Offset = "0x761DED0", VA = "0x18761EAD0")]
		private JobHandle BKHDOJKJLBO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x761F0C0", Offset = "0x761E4C0", VA = "0x18761F0C0")]
		private JobHandle ENEAAHGJHEN(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JMHANPGJGMK> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7620100", Offset = "0x761F500", VA = "0x187620100")]
		private JobHandle JJHHJGBFAOE(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<AFAOEOIHAIH> splinePointRanges, [Out] NativeList<EDCBAFLAMEJ> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x761ED40", Offset = "0x761E140", VA = "0x18761ED40")]
		private JobHandle ELPABKOIILP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x76204B0", Offset = "0x761F8B0", VA = "0x1876204B0")]
		private JobHandle KIFHAIBDKOP(EntityQuery query, NativeList<JMHANPGJGMK> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7620B90", Offset = "0x761FF90", VA = "0x187620B90")]
		private static NativeParallelHashMap<int, OMANHOCOLNE> NBJCBMBDJEA()
		{
			return default(NativeParallelHashMap<int, OMANHOCOLNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x761FD60", Offset = "0x761F160", VA = "0x18761FD60")]
		private JobHandle JIEJLEPPPGN(EntityQuery query, NativeList<AFAOEOIHAIH> splinePointRanges, NativeList<MJHFHLJEIGI> splinePointData, NativeList<EDCBAFLAMEJ> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x761F480", Offset = "0x761E880", VA = "0x18761F480")]
		private JobHandle GDPDNEFJGDA(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x761F560", Offset = "0x761E960", VA = "0x18761F560")]
		private JobHandle MMGHLIMDHEJ(NativeArray<int> pointCount, NativeList<MJHFHLJEIGI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x761EA30", Offset = "0x761DE30", VA = "0x18761EA30")]
		private JobHandle ANFPNHBMIMA(NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76203C0", Offset = "0x761F7C0", VA = "0x1876203C0")]
		private JobHandle JNFIAIOJDPC(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JMHANPGJGMK> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x761E920", Offset = "0x761DD20", VA = "0x18761E920")]
		private JobHandle AFGCINDKBKL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<AFAOEOIHAIH> ranges, NativeList<EDCBAFLAMEJ> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x761EBF0", Offset = "0x761DFF0", VA = "0x18761EBF0")]
		private JobHandle DBEHAILOMAL(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x76212F0", Offset = "0x76206F0", VA = "0x1876212F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PAECCKJJJLE : GNKNFKJHPCF, GMBJCCNEDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private KLDPNINNAMO HGCNPFLPFPL;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x761DDB0", Offset = "0x761D1B0", VA = "0x18761DDB0", Slot = "14")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x761DE00", Offset = "0x761D200", VA = "0x18761DE00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
	public PAECCKJJJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class EHOJFNFLDLI : LKAODBAHBDH, GMBJCCNEDOA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct FGNCEBLGGGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private EntityManager IDCNJMKKJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private CJKOOLDOELA<T> HKJPAOLEDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x43C8BB0", Offset = "0x43C7FB0", VA = "0x1843C8BB0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x43C9070", Offset = "0x43C8470", VA = "0x1843C9070")]
		public FGNCEBLGGGB(EntityManager IDCNJMKKJFI, CJKOOLDOELA<T> HKJPAOLEDME, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x40B8740", Offset = "0x40B7B40", VA = "0x1840B8740")]
		public FGNCEBLGGGB<T> BNIMLGJMJBK()
		{
			return default(FGNCEBLGGGB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x43C85D0", Offset = "0x43C79D0", VA = "0x1843C85D0")]
		public bool EIBHGILODBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly IBCMILIKEJG NHMPCJGFGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private IAGBBFEPOKL DFMBBMFGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private KLDPNINNAMO HGCNPFLPFPL;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x760A810", Offset = "0x7609C10", VA = "0x18760A810", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x760B940", Offset = "0x760AD40", VA = "0x18760B940")]
	public void OOOOJLFIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x760BE40", Offset = "0x760B240", VA = "0x18760BE40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76096F0", Offset = "0x7608AF0", VA = "0x1876096F0")]
	private void FGOHDEEKJFK(PEKELENKGLF MIALAMIFNLM, Mesh[] MEDHCPCLFFL, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3227F40", Offset = "0x3227340", VA = "0x183227F40")]
	private FGNCEBLGGGB<T> EEGGHBKDOAM<T>(CJKOOLDOELA<T> HKJPAOLEDME, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD) where T : struct
	{
		return default(FGNCEBLGGGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x76084D0", Offset = "0x76078D0", VA = "0x1876084D0")]
	private void BBOJHMOECPG(Transform LDIAONMHHPK, NativeArray<AHIOEHODJMA> HAAAAPJLMEJ, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x760B970", Offset = "0x760AD70", VA = "0x18760B970")]
	private void OPBCKKNMPDH(Transform LDIAONMHHPK, NativeArray<CFIFNHKCOEJ> HEEJFCLDCIO, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7608870", Offset = "0x7607C70", VA = "0x187608870")]
	private void CDMFPEELBNB(Transform LDIAONMHHPK, NativeArray<MDMKFMABILP> AELKOGJPIKE, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x760A890", Offset = "0x7609C90", VA = "0x18760A890")]
	private void JEOAGHMIDOM(Transform LDIAONMHHPK, NativeArray<KBKFOKGDANB> MEDHCPCLFFL, Mesh[] MONHCFOMLNO, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76091B0", Offset = "0x76085B0", VA = "0x1876091B0")]
	private static void DLNHBJKJIKF(NativeParallelHashSet<Entity> AKCBEPDCJFL, NativeParallelHashSet<Entity> DFDDICABMOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7608410", Offset = "0x7607810", VA = "0x187608410")]
	private static void AEHPFNGCBDA(NativeList<Entity> BHMKCPLLJPF, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x760ACD0", Offset = "0x760A0D0", VA = "0x18760ACD0")]
	private NativeParallelHashMap<Entity, AHANPLHIEFJ> KDFHHKJJJOF(KLDPNINNAMO.MPJGNLLJOLK HJCIKDMAEIH, LMCGHNEGPJF<IOMLJPNNPCO> EKEKCLLKGLB, List<GameObject> LAJDPIOBFMK)
	{
		return default(NativeParallelHashMap<Entity, AHANPLHIEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x760B840", Offset = "0x760AC40", VA = "0x18760B840")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> MDJGKOPJEBK(Entity HNGFDACBIMA)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7608C60", Offset = "0x7608060", VA = "0x187608C60")]
	private void CNBBIFJCJNG(NativeList<Entity> IGJGILGMBIM, NativeList<Entity> LFCLKAMCBFH, NativeParallelHashMap<Entity, AHANPLHIEFJ> EKGNAMGNFDP, NativeList<AFAOEOIHAIH> MDDFFJOKNCC, NativeList<MJHFHLJEIGI> PDKHPCOKAND, NativeList<EDCBAFLAMEJ> KGPPEBAFPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7609300", Offset = "0x7608700", VA = "0x187609300")]
	private void FABBNKHLLLJ(NativeList<Entity> AKCBEPDCJFL, NativeList<Entity> DMHMKEKNCJN, NativeParallelHashMap<Entity, AHANPLHIEFJ> EKGNAMGNFDP, NativeList<JMHANPGJGMK> LMKNDBCIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x76048C0", Offset = "0x7603CC0", VA = "0x1876048C0")]
	public EHOJFNFLDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class HGJNHADNBCN : OHLKAKOBKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly UniformTRS OJKHKNKJKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly JHDEHBMJKKK LDIAONMHHPK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject CJIMAGINEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS GOPPDMAABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7615620", Offset = "0x7614A20", VA = "0x187615620", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 KMFOKMFOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7615750", Offset = "0x7614B50", VA = "0x187615750", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 OMKLEAPIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7615840", Offset = "0x7614C40", VA = "0x187615840", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 MBMOKLLEPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7615930", Offset = "0x7614D30", VA = "0x187615930", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76155D0", Offset = "0x76149D0", VA = "0x1876155D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion ICPKADDHFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7615890", Offset = "0x7614C90", VA = "0x187615890", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x76157F0", Offset = "0x7614BF0", VA = "0x1876157F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 GEIPDAOLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x76157A0", Offset = "0x7614BA0", VA = "0x1876157A0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 EAJMBLHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7615700", Offset = "0x7614B00", VA = "0x187615700", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 ICKADFJJCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76158E0", Offset = "0x7614CE0", VA = "0x1876158E0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7615980", Offset = "0x7614D80", VA = "0x187615980")]
	public HGJNHADNBCN(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class PHKMGPACMAE : HGJNHADNBCN, MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly float LNCPFBAGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float3 OBIIJDFBCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly MONBNMPFMMO CABJAJKOCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly CEHJAJCAOIA EFDCMEMHPCM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private LCHJICBNMPB IFPKJGBLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x761E570", Offset = "0x761D970", VA = "0x18761E570", Slot = "17")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS DMMNKPLLMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x761E610", Offset = "0x761DA10", VA = "0x18761E610", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float JJLKFGGKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA92A90", Offset = "0xA91E90", VA = "0x180A92A90", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 NMBDGHBLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x761E5C0", Offset = "0x761D9C0", VA = "0x18761E5C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private MONBNMPFMMO GAPDFOPLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCED280", Offset = "0xCEC680", VA = "0x180CED280", Slot = "21")]
		get
		{
			return default(MONBNMPFMMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private CEHJAJCAOIA PNPBPBOBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x11769B0", Offset = "0x1175DB0", VA = "0x1811769B0", Slot = "22")]
		get
		{
			return default(CEHJAJCAOIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool KBKAGLBDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IEPPMNEGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x761E6F0", Offset = "0x761DAF0", VA = "0x18761E6F0")]
	protected PHKMGPACMAE(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK, float LNCPFBAGODO, float3 OBIIJDFBCJG, MONBNMPFMMO CABJAJKOCKF, CEHJAJCAOIA EFDCMEMHPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class CIPFFGLHPPM : OHLKAKOBKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly FHNHGOPNICC NMFKPCDLLEP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected JHDEHBMJKKK EJODNIKFKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xF5F750", Offset = "0xF5EB50", VA = "0x180F5F750")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7607210", Offset = "0x7606610", VA = "0x187607210")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7607ED0", Offset = "0x76072D0", VA = "0x187607ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7607340", Offset = "0x7606740", VA = "0x187607340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected FDJNGADHLPI KMNIOGMIMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x76073A0", Offset = "0x76067A0", VA = "0x1876073A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject CJIMAGINEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7607D70", Offset = "0x7607170", VA = "0x187607D70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS GOPPDMAABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xF7F340", Offset = "0xF7E740", VA = "0x180F7F340", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 KMFOKMFOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x76075F0", Offset = "0x76069F0", VA = "0x1876075F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 OMKLEAPIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7607910", Offset = "0x7606D10", VA = "0x187607910", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 MBMOKLLEPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7607DA0", Offset = "0x76071A0", VA = "0x187607DA0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7607230", Offset = "0x7606630", VA = "0x187607230", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion ICPKADDHFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7607A90", Offset = "0x7606E90", VA = "0x187607A90", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7607800", Offset = "0x7606C00", VA = "0x187607800", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 GEIPDAOLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x76076E0", Offset = "0x7606AE0", VA = "0x1876076E0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 EAJMBLHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7607430", Offset = "0x7606830", VA = "0x187607430", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 ICKADFJJCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7607BB0", Offset = "0x7606FB0", VA = "0x187607BB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xC7FB70", Offset = "0xC7EF70", VA = "0x180C7FB70")]
	protected CIPFFGLHPPM(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76077D0", Offset = "0x7606BD0", VA = "0x1876077D0")]
	public static LCHJICBNMPB HEGJABMHLEC(CIPFFGLHPPM CHBEBLKFDBC)
	{
		return default(LCHJICBNMPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BIADNMBPMPO
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7605200", Offset = "0x7604600", VA = "0x187605200")]
	public static void HNBADHMFMII(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FGKIPOAMLCK
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x760F910", Offset = "0x760ED10", VA = "0x18760F910")]
	public static void APDCFAHJMOK(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI, JIMDDOODGGB LDFHGGHCDLG, ANDACNBFJKF JJPIAJMIOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x760FFB0", Offset = "0x760F3B0", VA = "0x18760FFB0")]
	public static void KFOFBPGFKDB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI, JIMDDOODGGB LDFHGGHCDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x760FF70", Offset = "0x760F370", VA = "0x18760FF70")]
	public static NativeList<Entity> JIENHKKPOHB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76102C0", Offset = "0x760F6C0", VA = "0x1876102C0")]
	public static NativeList<Entity> OPAPHDFNFOB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x760FD10", Offset = "0x760F110", VA = "0x18760FD10")]
	private static NativeList<Entity> JIENHKKPOHB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI, bool IGMDGNGIHNL)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class PPBAOJFJHKE : CIPFFGLHPPM, MBADBELKHDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float LNCPFBAGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Vector3 OBIIJDFBCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private MONBNMPFMMO CABJAJKOCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CEHJAJCAOIA EFDCMEMHPCM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager FJADCGKECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x76232E0", Offset = "0x76226E0", VA = "0x1876232E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GDMALILFBDO GAHPOFMMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7623250", Offset = "0x7622650", VA = "0x187623250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData OPIHCFMDJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7623370", Offset = "0x7622770", VA = "0x187623370")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private LCHJICBNMPB IFPKJGBLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x76077D0", Offset = "0x7606BD0", VA = "0x1876077D0", Slot = "17")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float JJLKFGGKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD6B510", Offset = "0xD6A910", VA = "0x180D6B510", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 NMBDGHBLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x13D65C0", Offset = "0x13D59C0", VA = "0x1813D65C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private MONBNMPFMMO GAPDFOPLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460", Slot = "21")]
		get
		{
			return default(MONBNMPFMMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private CEHJAJCAOIA PNPBPBOBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB00470", Offset = "0xAFF870", VA = "0x180B00470", Slot = "22")]
		get
		{
			return default(CEHJAJCAOIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS DMMNKPLLMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x76232B0", Offset = "0x76226B0", VA = "0x1876232B0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IEPPMNEGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x977EC0", Offset = "0x9772C0", VA = "0x180977EC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool KBKAGLBDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x76235F0", Offset = "0x76229F0", VA = "0x1876235F0")]
	protected PPBAOJFJHKE(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7623460", Offset = "0x7622860", VA = "0x187623460", Slot = "26")]
	public virtual void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class LKAODBAHBDH : GNKNFKJHPCF, GMBJCCNEDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected ANDACNBFJKF JJPIAJMIOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private AKJLCMLCONF KPHLIDJMEFA;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected JIMDDOODGGB HKAGCELIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7623190", Offset = "0x7622590", VA = "0x187623190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected LNJLGFCNCEA DIFOMIBHGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7623140", Offset = "0x7622540", VA = "0x187623140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x76231E0", Offset = "0x76225E0", VA = "0x1876231E0", Slot = "15")]
	public virtual void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2793720", Offset = "0x2792B20", VA = "0x182793720")]
	protected LKAODBAHBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GGLMMBJKLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7622EA0", Offset = "0x76222A0", VA = "0x187622EA0")]
	public static void MMOJPLADFLJ(NativeArray<Entity> IGJGILGMBIM, EntityManager IDCNJMKKJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__179666161
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76237F0", Offset = "0x7622BF0", VA = "0x1876237F0")]
	public static void HHDEEIGDEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76237E0", Offset = "0x7622BE0", VA = "0x1876237E0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class KABAABHEGKD : ContainerPropertyBag<CJLKCNMJBBN>
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x76230E0", Offset = "0x76224E0", VA = "0x1876230E0")]
	public KABAABHEGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class BDDEILPLCFM : ContainerPropertyBag<MGMNMOFFJEL>
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7622DE0", Offset = "0x76221E0", VA = "0x187622DE0")]
	public BDDEILPLCFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class DGOGFBMDBPL : ContainerPropertyBag<NNOEEILDDMH>
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7622E40", Offset = "0x7622240", VA = "0x187622E40")]
	public DGOGFBMDBPL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7623620", Offset = "0x7622A20", VA = "0x187623620")]
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
