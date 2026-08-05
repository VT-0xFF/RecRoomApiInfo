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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B7EC0", Offset = "0x76B64C0", VA = "0x1876B7EC0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E286B0", Offset = "0x1E26CB0", VA = "0x181E286B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76C0DB0", Offset = "0x76BF3B0", VA = "0x1876C0DB0")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76C1350", Offset = "0x76BF950", VA = "0x1876C1350", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76C13B0", Offset = "0x76BF9B0", VA = "0x1876C13B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JCOINFMPLBK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76B4F20", Offset = "0x76B3520", VA = "0x1876B4F20")]
	public static Quaternion OPBKLKHJPAL([In] this MOFBEMKMNKK FGLHGHDGDNL, [In] Vector3 BNCGOADGBEC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BKOIHBLBICF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76A4090", Offset = "0x76A2690", VA = "0x1876A4090")]
	public static bool GMLEHFIGPKI(this OMGPNKEPIHM JBENCCOBBHH, EDJKJELJDNI JFJMJEFHFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76A4D90", Offset = "0x76A3390", VA = "0x1876A4D90")]
	public static bool LLLCIBANFFN(this OMGPNKEPIHM JBENCCOBBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76A40D0", Offset = "0x76A26D0", VA = "0x1876A40D0")]
	public static bool HBANDJKPHCA(this OMGPNKEPIHM JBENCCOBBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x76A4DC0", Offset = "0x76A33C0", VA = "0x1876A4DC0")]
	public static void LOJFGGPGHAN(this OMGPNKEPIHM JBENCCOBBHH, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76A5650", Offset = "0x76A3C50", VA = "0x1876A5650")]
	public static void OMAGJJMPCJI(this OMGPNKEPIHM JBENCCOBBHH, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG, int INOGBBDPDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76A3F70", Offset = "0x76A2570", VA = "0x1876A3F70")]
	public static void FNDGMFPLHPL(this OMGPNKEPIHM JBENCCOBBHH, int INOGBBDPDLJ, Vector3 CFPPKGBFECH, Quaternion AJLPIMKBEBD, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76A4EF0", Offset = "0x76A34F0", VA = "0x1876A4EF0")]
	public static void MEAMEAIFJEG(this OMGPNKEPIHM JBENCCOBBHH, Vector3 APPJOBFCCCM, Quaternion IGGDJPADDMG, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76A4320", Offset = "0x76A2920", VA = "0x1876A4320")]
	private static void JEPJCFNHICM(this OMGPNKEPIHM JBENCCOBBHH, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x76A3B10", Offset = "0x76A2110", VA = "0x1876A3B10")]
	private static void AGBHPMMALLN(this OMGPNKEPIHM JBENCCOBBHH, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76A4100", Offset = "0x76A2700", VA = "0x1876A4100")]
	private static void HHHGLBIIDHE(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76A42F0", Offset = "0x76A28F0", VA = "0x1876A42F0")]
	private static bool JCPEEMKBPPD(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x76A3CD0", Offset = "0x76A22D0", VA = "0x1876A3CD0")]
	private static void DGNJDGMJDCI(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN, Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK, float KKNEPFALNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76A5160", Offset = "0x76A3760", VA = "0x1876A5160")]
	public static Vector3 OLHJLNGKDCP(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76A4C80", Offset = "0x76A3280", VA = "0x1876A4C80")]
	public static Quaternion KPPCNMJKMKI(this OMGPNKEPIHM JBENCCOBBHH, int EAHKFAJBNDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76A4F40", Offset = "0x76A3540", VA = "0x1876A4F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x76AF030", Offset = "0x76AD630", VA = "0x1876AF030", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
	public LGEIOMHELKC(MDOKODFBGBL OEIGHBFCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76B71B0", Offset = "0x76B57B0", VA = "0x1876B71B0", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class POKODPGILHM : KJAKJKJFOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76BCE40", Offset = "0x76BB440", VA = "0x1876BCE40", Slot = "4")]
	public void GNCIIDBKINA(EntityQuery CFNDKJDBFBE, EntityManager IDCNJMKKJFI, AKJLCMLCONF KPHLIDJMEFA, OBFOPMLNHAJ GDNPGEGAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76BC450", Offset = "0x76BAA50", VA = "0x1876BC450", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76BBF00", Offset = "0x76BA500", VA = "0x1876BBF00", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76BC1D0", Offset = "0x76BA7D0", VA = "0x1876BC1D0", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76BC180", Offset = "0x76BA780", VA = "0x1876BC180", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B5550", Offset = "0x76B3B50", VA = "0x1876B5550", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76B5000", Offset = "0x76B3600", VA = "0x1876B5000", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76B52D0", Offset = "0x76B38D0", VA = "0x1876B52D0", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76B5280", Offset = "0x76B3880", VA = "0x1876B5280", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76AEF20", Offset = "0x76AD520", VA = "0x1876AEF20", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76AE9D0", Offset = "0x76ACFD0", VA = "0x1876AE9D0", Slot = "5")]
	public void BMBBNCPOKLH(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76AECA0", Offset = "0x76AD2A0", VA = "0x1876AECA0", Slot = "6")]
	public void FOAHLIPGCID(EntityQuery CFNDKJDBFBE, LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76AEC50", Offset = "0x76AD250", VA = "0x1876AEC50", Slot = "7")]
	public void CNPGANMHJKI(LNJLGFCNCEA CNPKAHOGCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76ADB30", Offset = "0x76AC130", VA = "0x1876ADB30", Slot = "15")]
	public virtual void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x76ADBC0", Offset = "0x76AC1C0", VA = "0x1876ADBC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x76AD9C0", Offset = "0x76ABFC0", VA = "0x1876AD9C0")]
	private void CEAKCPDFPFE(EntityQueryDesc APNLALLMOMO, KJAKJKJFOEC BOLLEAKOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x76ADDF0", Offset = "0x76AC3F0", VA = "0x1876ADDF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76BB0B0", Offset = "0x76B96B0", VA = "0x1876BB0B0", Slot = "14")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x76BB590", Offset = "0x76B9B90", VA = "0x1876BB590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76BB710", Offset = "0x76B9D10", VA = "0x1876BB710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76BB140", Offset = "0x76B9740", VA = "0x1876BB140")]
	private void OAOCAIOMCBM(NPLAEGGIMKF EKCONHEOFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76BA970", Offset = "0x76B8F70", VA = "0x1876BA970")]
	private void CEAKCPDFPFE(HFEFCPGMDEA KEJJFKFGMOA, ComponentType CJJBMHEOEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FFCHMNNCDPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76AD480", Offset = "0x76ABA80", VA = "0x1876AD480", Slot = "4")]
	public bool AEJBKDCDDDH(FHNHGOPNICC KPOCLGHHOEP, MCJIKLCEHHO KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76AD700", Offset = "0x76ABD00", VA = "0x1876AD700", Slot = "5")]
	public DGKNAAFCKEM LOOLAEAPJBD()
	{
		return default(DGKNAAFCKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76AD560", Offset = "0x76ABB60", VA = "0x1876AD560", Slot = "6")]
	public void BGDBNNONMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76AD670", Offset = "0x76ABC70", VA = "0x1876AD670", Slot = "7")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xFB4D50", Offset = "0xFB3350", VA = "0x180FB4D50", Slot = "8")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public FDEOLCKDDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BOMHNKIDBAA), new string[] { })]
public class LAKHAHJFMIL : BOMHNKIDBAA
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76B6810", Offset = "0x76B4E10", VA = "0x1876B6810", Slot = "4")]
	public void HALELABMJKE(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76B67C0", Offset = "0x76B4DC0", VA = "0x1876B67C0", Slot = "5")]
	public void GCOLGNFLEPO(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76B70F0", Offset = "0x76B56F0", VA = "0x1876B70F0", Slot = "6")]
	public ComponentSystemBase NNFBCGIIGKL(World ENFBJMHAMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76B6760", Offset = "0x76B4D60", VA = "0x1876B6760", Slot = "7")]
	public void EAIHIKJGCGG(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76B6890", Offset = "0x76B4E90", VA = "0x1876B6890", Slot = "8")]
	public void HNPNNLNNEEE(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76B6700", Offset = "0x76B4D00", VA = "0x1876B6700", Slot = "9")]
	public void AKPOJNGDJIH(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76B7140", Offset = "0x76B5740", VA = "0x1876B7140", Slot = "10")]
	public void OOOOJLFIILA(World ENFBJMHAMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x76B68F0", Offset = "0x76B4EF0", VA = "0x1876B68F0", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> KNBPBFOMJHC()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76A6620", Offset = "0x76A4C20", VA = "0x1876A6620", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76A65B0", Offset = "0x76A4BB0", VA = "0x1876A65B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76B8240", Offset = "0x76B6840", VA = "0x1876B8240", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
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
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76BBA20", Offset = "0x76BA020", VA = "0x1876BBA20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76BB9B0", Offset = "0x76B9FB0", VA = "0x1876BB9B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCCAA0", Offset = "0xBCB0A0", VA = "0x180BCCAA0", Slot = "27")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA1400", Offset = "0xA9FA00", VA = "0x180AA1400", Slot = "28")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE2D10", Offset = "0xEE1310", VA = "0x180EE2D10", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76B4E80", Offset = "0x76B3480", VA = "0x1876B4E80")]
	public JBKIAFNCEKL(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK, float LNCPFBAGODO, float3 OBIIJDFBCJG, MONBNMPFMMO CABJAJKOCKF, CEHJAJCAOIA EFDCMEMHPCM, OMANHOCOLNE GOAJLEACEKF, float3 DBIFFOKDKEJ, bool HLJLOIPIKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76B4E30", Offset = "0x76B3430", VA = "0x1876B4E30", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B4D70", Offset = "0x76B3370", VA = "0x1876B4D70", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EJGEJEKCLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x76B4D90", Offset = "0x76B3390", VA = "0x1876B4D90", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KFEKJCLAOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76B4D80", Offset = "0x76B3380", VA = "0x1876B4D80", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BONNAGJGKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC0C580", Offset = "0xC0AB80", VA = "0x180C0C580", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PPAPPOJMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB45930", Offset = "0xB43F30", VA = "0x180B45930", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HOOGEGKJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xD804F0", Offset = "0xD7EAF0", VA = "0x180D804F0", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x76B4CC0", Offset = "0x76B32C0", VA = "0x1876B4CC0")]
	public IEFPEFAHDMN(UniformTRS OJKHKNKJKPP, JHDEHBMJKKK LDIAONMHHPK, float LNCPFBAGODO, float3 OBIIJDFBCJG, MONBNMPFMMO CABJAJKOCKF, CEHJAJCAOIA EFDCMEMHPCM, CBJMMJDEABF FJJOKDBOKAE, float MMHCLBPDOPA, int ENCHIMLCJAD, NativeArray<MJHFHLJEIGI> EAOJFACDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEFA0D0", Offset = "0xEF86D0", VA = "0x180EFA0D0", Slot = "33")]
	public NativeArray<MJHFHLJEIGI> GetNativeCurvePoints()
	{
		return default(NativeArray<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x76B4C00", Offset = "0x76B3200", VA = "0x1876B4C00", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x96F660", Offset = "0x96DC60", VA = "0x18096F660", Slot = "28")]
		get
		{
			return default(OMANHOCOLNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CBJOLKCLKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCD2890", Offset = "0xCD0E90", VA = "0x180CD2890", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 AGNHKCCLAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76B4B30", Offset = "0x76B3130", VA = "0x1876B4B30", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76B4B10", Offset = "0x76B3110", VA = "0x1876B4B10")]
	public HNOHDHKEBKM(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76B4480", Offset = "0x76B2A80", VA = "0x1876B4480", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76B44D0", Offset = "0x76B2AD0", VA = "0x1876B44D0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x76BC620", Offset = "0x76BAC20", VA = "0x1876BC620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LCHJICBNMPB KECLKMNFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76BC520", Offset = "0x76BAB20", VA = "0x1876BC520", Slot = "15")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BBEOEDALAPE IFPHMOGCGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x76BCAE0", Offset = "0x76BB0E0", VA = "0x1876BCAE0", Slot = "16")]
		get
		{
			return default(BBEOEDALAPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76BC990", Offset = "0x76BAF90", VA = "0x1876BC990")]
	public PGJFABICBND(FHNHGOPNICC KPOCLGHHOEP, bool DDMBLFMOMEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x76BC6B0", Offset = "0x76BACB0", VA = "0x1876BC6B0")]
	public void KPOAHJNHEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76BC520", Offset = "0x76BAB20", VA = "0x1876BC520")]
	protected LCHJICBNMPB HCAOBHMHALE()
	{
		return default(LCHJICBNMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76BC840", Offset = "0x76BAE40", VA = "0x1876BC840")]
	private static bool PHPPMOLNPLC(FHNHGOPNICC NFNFJFJJBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76BC4F0", Offset = "0x76BAAF0", VA = "0x1876BC4F0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IACEAEJIIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99D690", Offset = "0x99BC90", VA = "0x18099D690", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float LFHCEDMPJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEA5EE0", Offset = "0xEA44E0", VA = "0x180EA5EE0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int KMJBPAFOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBCCAA0", Offset = "0xBCB0A0", VA = "0x180BCCAA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool BGJMGOCHNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA1400", Offset = "0xA9FA00", VA = "0x180AA1400", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int KAFKBFIGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76A2FA0", Offset = "0x76A15A0", VA = "0x1876A2FA0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int EOFLFINGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76A36D0", Offset = "0x76A1CD0", VA = "0x1876A36D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76A38A0", Offset = "0x76A1EA0", VA = "0x1876A38A0")]
	public BEDKMEAJGIC(FHNHGOPNICC JOFIFDPGHKD, [Optional] NativeList<MJHFHLJEIGI> EAOJFACDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76A37C0", Offset = "0x76A1DC0", VA = "0x1876A37C0", Slot = "26")]
	public override void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76A2FC0", Offset = "0x76A15C0", VA = "0x1876A2FC0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x76A30B0", Offset = "0x76A16B0", VA = "0x1876A30B0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76A3670", Offset = "0x76A1C70", VA = "0x1876A3670")]
	public void MODGEBILPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76A32D0", Offset = "0x76A18D0", VA = "0x1876A32D0", Slot = "34")]
	public NativeArray<MJHFHLJEIGI> GetNativeCurvePoints()
	{
		return default(NativeArray<MJHFHLJEIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76A3180", Offset = "0x76A1780", VA = "0x1876A3180", Slot = "35")]
	private Vector3 GGJOFLJMOEF(int MKNOLMMOIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76A3640", Offset = "0x76A1C40", VA = "0x1876A3640", Slot = "36")]
	private Quaternion JFOHDCIIMDD(int MKNOLMMOIDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76A34A0", Offset = "0x76A1AA0", VA = "0x1876A34A0", Slot = "37")]
	private float IOLEGDKPMHG(int MKNOLMMOIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x76A3110", Offset = "0x76A1710", VA = "0x1876A3110")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B40B0", Offset = "0x76B26B0", VA = "0x1876B40B0", Slot = "15")]
	protected override ComponentSystemBase PNGOBAOIIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76B40A0", Offset = "0x76B26A0", VA = "0x1876B40A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x76B4470", Offset = "0x76B2A70", VA = "0x1876B4470")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B8AA0", Offset = "0x76B70A0", VA = "0x1876B8AA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76B8E00", Offset = "0x76B7400", VA = "0x1876B8E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76B8700", Offset = "0x76B6D00", VA = "0x1876B8700")]
	private void IHHHENNECHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x76B85F0", Offset = "0x76B6BF0", VA = "0x1876B85F0")]
	private void GMGDHCHMBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x76B82B0", Offset = "0x76B68B0", VA = "0x1876B82B0")]
	private void CBNDJGIGGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76B84F0", Offset = "0x76B6AF0", VA = "0x1876B84F0")]
	private void FJHKFLFANJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76B8940", Offset = "0x76B6F40", VA = "0x1876B8940")]
	private void NPAMNGDDKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76B8A40", Offset = "0x76B7040", VA = "0x1876B8A40")]
	private NativeList<Entity> OPAPHDFNFOB(NativeArray<Entity> AKCBEPDCJFL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76B88E0", Offset = "0x76B6EE0", VA = "0x1876B88E0")]
	private NativeList<Entity> JIENHKKPOHB(NativeArray<Entity> AKCBEPDCJFL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76B8490", Offset = "0x76B6A90", VA = "0x1876B8490")]
	private void CGGEAEDANDD(NativeArray<Entity> AKCBEPDCJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x76A2D00", Offset = "0x76A1300", VA = "0x1876A2D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76A2740", Offset = "0x76A0D40", VA = "0x1876A2740", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76A2ED0", Offset = "0x76A14D0", VA = "0x1876A2ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76A19A0", Offset = "0x769FFA0", VA = "0x1876A19A0")]
	private void BOBLHIOLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76A2020", Offset = "0x76A0620", VA = "0x1876A2020")]
	private void FCOOAJKGPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76A2950", Offset = "0x76A0F50", VA = "0x1876A2950")]
	private void OPCBHPEJKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76A26A0", Offset = "0x76A0CA0", VA = "0x1876A26A0")]
	private bool IFHNGONFHLM(Entity FCJGDHPNMHF, [Out] DGKNAAFCKEM EADDGEHONEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76A27A0", Offset = "0x76A0DA0", VA = "0x1876A27A0")]
	private bool JFKOKFDFMNK(Entity FCJGDHPNMHF, [Out] DGKNAAFCKEM EADDGEHONEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B9B10", Offset = "0x76B8110", VA = "0x1876B9B10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x76B9C60", Offset = "0x76B8260", VA = "0x1876B9C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x76B9520", Offset = "0x76B7B20", VA = "0x1876B9520")]
	private void BOBLHIOLFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x76B9820", Offset = "0x76B7E20", VA = "0x1876B9820")]
	private void FCOOAJKGPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x76BBE80", Offset = "0x76BA480", VA = "0x1876BBE80", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76BBDA0", Offset = "0x76BA3A0", VA = "0x1876BBDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B8ED0", Offset = "0x76B74D0", VA = "0x1876B8ED0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x76A6670", Offset = "0x76A4C70", VA = "0x1876A6670", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x76ACB80", Offset = "0x76AB180", VA = "0x1876ACB80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76AC6D0", Offset = "0x76AACD0", VA = "0x1876AC6D0", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76AD100", Offset = "0x76AB700", VA = "0x1876AD100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76AC0D0", Offset = "0x76AA6D0", VA = "0x1876AC0D0")]
	private void HNGKPNKKIOJ(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int OCCGHIHIPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76AC730", Offset = "0x76AAD30", VA = "0x1876AC730")]
	private void LDGFFGPFAFC(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int KBAEPPBFPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76AB750", Offset = "0x76A9D50", VA = "0x1876AB750")]
	private void DCMKNFEDAIA(NativeParallelHashSet<DGKNAAFCKEM> HKGBNCNKFBG, int COFKAPFMGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76ABD40", Offset = "0x76AA340", VA = "0x1876ABD40")]
	private void GKELCAFCEBM(NativeParallelHashSet<DGKNAAFCKEM> MKJMIEBCBKD, int JABMPBCLEIG, int NOLBLGJAHCA, int DENAFBINLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x76ABB90", Offset = "0x76AA190", VA = "0x1876ABB90")]
	private void DKJEAIGHNOB(Entity LMLAAEIHJPJ, EEGJHJCMEBL JDHADJGFNJB, DGKNAAFCKEM EADDGEHONEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B7300", Offset = "0x76B5900", VA = "0x1876B7300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x76B7540", Offset = "0x76B5B40", VA = "0x1876B7540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76BA050", Offset = "0x76B8650", VA = "0x1876BA050", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x76BA0B0", Offset = "0x76B86B0", VA = "0x1876BA0B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x76BA240", Offset = "0x76B8840", VA = "0x1876BA240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x35B8A90", Offset = "0x35B7090", VA = "0x1835B8A90")]
	private void CEAKCPDFPFE<T>(KJCMHDOJJEN JNLNNHIEEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x76B9D10", Offset = "0x76B8310", VA = "0x1876B9D10")]
	private static void BHMMHKIGCHO(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x76B9EB0", Offset = "0x76B84B0", VA = "0x1876B9EB0")]
	private static void EGBDCIKDLCB(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76BA740", Offset = "0x76B8D40", VA = "0x1876BA740")]
	private static void PLKOFCDHMFA(NativeArray<EEGJHJCMEBL> FEJHOLHIAPJ, LNJLGFCNCEA LNIHPJABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x76A14F0", Offset = "0x769FAF0", VA = "0x1876A14F0", Slot = "13")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B4DA0", Offset = "0x76B33A0", VA = "0x1876B4DA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x15917E0", Offset = "0x158FDE0", VA = "0x1815917E0")]
		public MPJGNLLJOLK(KLDPNINNAMO LDIAONMHHPK, bool MHOFEOILIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76B9120", Offset = "0x76B7720", VA = "0x1876B9120")]
		public Queue<FOOKLENIMIG>.Enumerator BNIMLGJMJBK()
		{
			return default(Queue<FOOKLENIMIG>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x76B91E0", Offset = "0x76B77E0", VA = "0x1876B91E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x76B5A60", Offset = "0x76B4060", VA = "0x1876B5A60", Slot = "4")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76B60F0", Offset = "0x76B46F0", VA = "0x1876B60F0")]
	public void OPOOJCLGBBK(NativeList<MJHFHLJEIGI> BGOPNEFNKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76B57B0", Offset = "0x76B3DB0", VA = "0x1876B57B0")]
	public void BJDPMPKGBDB(Entity LDIAONMHHPK, [In] EFMCPKJOHAF<GameObject> IAAPNEHEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x76B5C60", Offset = "0x76B4260", VA = "0x1876B5C60")]
	public void KGECBKFGIHC(NativeList<EEGJHJCMEBL> FEJHOLHIAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76B5580", Offset = "0x76B3B80", VA = "0x1876B5580")]
	public void AKPOJNGDJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x76B61C0", Offset = "0x76B47C0", VA = "0x1876B61C0")]
	public void PPPFIKANINK(JIMDDOODGGB JEIEGFHFIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76B5FB0", Offset = "0x76B45B0", VA = "0x1876B5FB0")]
	public JobHandle NBHHDLCNONM([In] FOOKLENIMIG MIALAMIFNLM, JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76B5F10", Offset = "0x76B4510", VA = "0x1876B5F10")]
	public JobHandle NBHHDLCNONM([In] IOMLJPNNPCO MIALAMIFNLM, JobHandle ODEGOODBELJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x73A5960", Offset = "0x73A3F60", VA = "0x1873A5960")]
	public MPJGNLLJOLK AJIILNNMAKI(bool MHOFEOILIOO)
	{
		return default(MPJGNLLJOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76B6050", Offset = "0x76B4650", VA = "0x1876B6050")]
	public LMCGHNEGPJF<IOMLJPNNPCO> NMIAANGCCCM()
	{
		return default(LMCGHNEGPJF<IOMLJPNNPCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76B60A0", Offset = "0x76B46A0", VA = "0x1876B60A0")]
	public LMCGHNEGPJF<PEKELENKGLF> NPOCGDPMOAP()
	{
		return default(LMCGHNEGPJF<PEKELENKGLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76B5CF0", Offset = "0x76B42F0", VA = "0x1876B5CF0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76B5910", Offset = "0x76B3F10", VA = "0x1876B5910", Slot = "5")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x76B59F0", Offset = "0x76B3FF0", VA = "0x1876B59F0", Slot = "6")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xFABC40", Offset = "0xFAA240", VA = "0x180FABC40", Slot = "7")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76AEF50", Offset = "0x76AD550", VA = "0x1876AEF50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x76AEF60", Offset = "0x76AD560", VA = "0x1876AEF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x76A1980", Offset = "0x769FF80", VA = "0x1876A1980", Slot = "4")]
	public void HGJMKMEOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76A1930", Offset = "0x769FF30", VA = "0x1876A1930", Slot = "5")]
	private void GIBJGOKIIIN(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xF6DAD0", Offset = "0xF6C0D0", VA = "0x180F6DAD0", Slot = "6")]
	private void LCJILCFFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x76AF240", Offset = "0x76AD840", VA = "0x1876AF240", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76AF5E0", Offset = "0x76ADBE0", VA = "0x1876AF5E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76A69A0", Offset = "0x76A4FA0", VA = "0x1876A69A0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x76BCF80", Offset = "0x76BB580", VA = "0x1876BCF80")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x76BCFA0", Offset = "0x76BB5A0", VA = "0x1876BCFA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B7AD0", Offset = "0x76B60D0", VA = "0x1876B7AD0", Slot = "5")]
				public float3 BHFHGEIMKPH(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x76B7E80", Offset = "0x76B6480", VA = "0x1876B7E80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76BBA70", Offset = "0x76BA070", VA = "0x1876BBA70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76B0930", Offset = "0x76AEF30", VA = "0x1876B0930", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x76B0F90", Offset = "0x76AF590", VA = "0x1876B0F90")]
			private void GDLDDPLNHKH(NativeList<PointSrcData> srcData, NativeList<MJHFHLJEIGI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x76B0230", Offset = "0x76AE830", VA = "0x1876B0230")]
			public static Vector3 CAHNMABPIPJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x76B25D0", Offset = "0x76B0BD0", VA = "0x1876B25D0")]
			public static quaternion JOFAKENPBOK(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x76B2840", Offset = "0x76B0E40", VA = "0x1876B2840")]
			private static quaternion MMEANCONLAE(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x76AFD00", Offset = "0x76AE300", VA = "0x1876AFD00")]
			private static float3 APDEAMMJLBK(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x76B20E0", Offset = "0x76B06E0", VA = "0x1876B20E0")]
			private static quaternion IFCPHDKKFNN(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x76B1E70", Offset = "0x76B0470", VA = "0x1876B1E70")]
			private static MJHFHLJEIGI IAHMJJDOLEF(int idx, NativeList<PointSrcData> srcData)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3B35140", Offset = "0x3B33740", VA = "0x183B35140")]
			private void KDBNHDBCEHE<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x76B2A70", Offset = "0x76B1070", VA = "0x1876B2A70")]
			private void NDOPKHEMNDP(NativeList<PointSrcData> sourcePoints, NativeList<MJHFHLJEIGI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x76B07B0", Offset = "0x76AEDB0", VA = "0x1876B07B0")]
			public static float COOHHFDLOHF(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x76B2650", Offset = "0x76B0C50", VA = "0x1876B2650")]
			private static quaternion KBIGDBODKOE(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x76B3910", Offset = "0x76B1F10", VA = "0x1876B3910")]
			private static MJHFHLJEIGI OAKIGDAKPGG(PointSrcData point)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76B3880", Offset = "0x76B1E80", VA = "0x1876B3880")]
			private static MJHFHLJEIGI OAKIGDAKPGG(float3 pos, quaternion rot, float radius)
			{
				return default(MJHFHLJEIGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x76B0640", Offset = "0x76AEC40", VA = "0x1876B0640")]
			private static bool CCPCMKMDGJJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x76B06E0", Offset = "0x76AECE0", VA = "0x1876B06E0")]
			private static float3 CNJKLDCAJJJ(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x76AFED0", Offset = "0x76AE4D0", VA = "0x1876AFED0")]
			public static float3 BENOIFIEDIH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x76B0080", Offset = "0x76AE680", VA = "0x1876B0080")]
			public static float3 BHFHGEIMKPH(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x76B2170", Offset = "0x76B0770", VA = "0x1876B2170")]
			private static quaternion IMOCKCGDNLM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x76B3A30", Offset = "0x76B2030", VA = "0x1876B3A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x76BF090", Offset = "0x76BD690", VA = "0x1876BF090")]
			private void BHOFAMFOGJP(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x76BF170", Offset = "0x76BD770", VA = "0x1876BF170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76C09C0", Offset = "0x76BEFC0", VA = "0x1876C09C0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x76C0A20", Offset = "0x76BF020", VA = "0x1876C0A20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76C0960", Offset = "0x76BEF60", VA = "0x1876C0960")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x76C09B0", Offset = "0x76BEFB0", VA = "0x1876C09B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76AF920", Offset = "0x76ADF20", VA = "0x1876AF920")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x76AFAE0", Offset = "0x76AE0E0", VA = "0x1876AFAE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76AFAF0", Offset = "0x76AE0F0", VA = "0x1876AFAF0")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x76AFCF0", Offset = "0x76AE2F0", VA = "0x1876AFCF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76C0530", Offset = "0x76BEB30", VA = "0x1876C0530")]
			private void BHOFAMFOGJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x76C0950", Offset = "0x76BEF50", VA = "0x1876C0950", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x76BE390", Offset = "0x76BC990", VA = "0x1876BE390", Slot = "15")]
		public override void InitReferences(APLBLLDKDCG services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x76BFD10", Offset = "0x76BE310", VA = "0x1876BFD10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76BFE00", Offset = "0x76BE400", VA = "0x1876BFE00", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x76BFE60", Offset = "0x76BE460", VA = "0x1876BFE60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76BF680", Offset = "0x76BDC80", VA = "0x1876BF680")]
		private JobHandle OBLGKLDOIPO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76BDCD0", Offset = "0x76BC2D0", VA = "0x1876BDCD0")]
		private JobHandle HFPHIPIJOKN(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x76BDC30", Offset = "0x76BC230", VA = "0x1876BDC30")]
		private JobHandle GJPHEOEMCEN(NativeArray<int> pointCount, NativeList<MJHFHLJEIGI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x76BD100", Offset = "0x76BB700", VA = "0x1876BD100")]
		private JobHandle BAIOGCABFDJ(NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x76BFFD0", Offset = "0x76BE5D0", VA = "0x1876BFFD0")]
		private JobHandle PFPNCLALONC(EntityQuery query, NativeList<AFAOEOIHAIH> splinePointRanges, NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x76BDA30", Offset = "0x76BC030", VA = "0x1876BDA30")]
		private JobHandle FIBLPPJDMPI(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x76BD1A0", Offset = "0x76BB7A0", VA = "0x1876BD1A0")]
		private JobHandle BKHDOJKJLBO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x76BD790", Offset = "0x76BBD90", VA = "0x1876BD790")]
		private JobHandle ENEAAHGJHEN(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<JMHANPGJGMK> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76BE7D0", Offset = "0x76BCDD0", VA = "0x1876BE7D0")]
		private JobHandle JJHHJGBFAOE(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<AFAOEOIHAIH> splinePointRanges, [Out] NativeList<EDCBAFLAMEJ> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76BD410", Offset = "0x76BBA10", VA = "0x1876BD410")]
		private JobHandle ELPABKOIILP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x76BEB80", Offset = "0x76BD180", VA = "0x1876BEB80")]
		private JobHandle KIFHAIBDKOP(EntityQuery query, NativeList<JMHANPGJGMK> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76BF260", Offset = "0x76BD860", VA = "0x1876BF260")]
		private static NativeParallelHashMap<int, OMANHOCOLNE> NBJCBMBDJEA()
		{
			return default(NativeParallelHashMap<int, OMANHOCOLNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76BE430", Offset = "0x76BCA30", VA = "0x1876BE430")]
		private JobHandle JIEJLEPPPGN(EntityQuery query, NativeList<AFAOEOIHAIH> splinePointRanges, NativeList<MJHFHLJEIGI> splinePointData, NativeList<EDCBAFLAMEJ> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76BDB50", Offset = "0x76BC150", VA = "0x1876BDB50")]
		private JobHandle GDPDNEFJGDA(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x76BDC30", Offset = "0x76BC230", VA = "0x1876BDC30")]
		private JobHandle MMGHLIMDHEJ(NativeArray<int> pointCount, NativeList<MJHFHLJEIGI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76BD100", Offset = "0x76BB700", VA = "0x1876BD100")]
		private JobHandle ANFPNHBMIMA(NativeList<MJHFHLJEIGI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76BEA90", Offset = "0x76BD090", VA = "0x1876BEA90")]
		private JobHandle JNFIAIOJDPC(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<JMHANPGJGMK> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x76BCFF0", Offset = "0x76BB5F0", VA = "0x1876BCFF0")]
		private JobHandle AFGCINDKBKL(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<AFAOEOIHAIH> ranges, NativeList<EDCBAFLAMEJ> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x76BD2C0", Offset = "0x76BB8C0", VA = "0x1876BD2C0")]
		private JobHandle DBEHAILOMAL(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x76BF9C0", Offset = "0x76BDFC0", VA = "0x1876BF9C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
	[Cpp2IlInjected.Address(RVA = "0x76BC480", Offset = "0x76BAA80", VA = "0x1876BC480", Slot = "14")]
	public void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x76BC4D0", Offset = "0x76BAAD0", VA = "0x1876BC4D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
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
			[Cpp2IlInjected.Address(RVA = "0x4421FA0", Offset = "0x44205A0", VA = "0x184421FA0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4422460", Offset = "0x4420A60", VA = "0x184422460")]
		public FGNCEBLGGGB(EntityManager IDCNJMKKJFI, CJKOOLDOELA<T> HKJPAOLEDME, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x410D430", Offset = "0x410BA30", VA = "0x18410D430")]
		public FGNCEBLGGGB<T> BNIMLGJMJBK()
		{
			return default(FGNCEBLGGGB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x44219C0", Offset = "0x441FFC0", VA = "0x1844219C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x76A8EE0", Offset = "0x76A74E0", VA = "0x1876A8EE0", Slot = "15")]
	public override void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x76AA010", Offset = "0x76A8610", VA = "0x1876AA010")]
	public void OOOOJLFIILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x76AA510", Offset = "0x76A8B10", VA = "0x1876AA510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76A7DC0", Offset = "0x76A63C0", VA = "0x1876A7DC0")]
	private void FGOHDEEKJFK(PEKELENKGLF MIALAMIFNLM, Mesh[] MEDHCPCLFFL, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x32710A0", Offset = "0x326F6A0", VA = "0x1832710A0")]
	private FGNCEBLGGGB<T> EEGGHBKDOAM<T>(CJKOOLDOELA<T> HKJPAOLEDME, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD) where T : struct
	{
		return default(FGNCEBLGGGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x76A6BA0", Offset = "0x76A51A0", VA = "0x1876A6BA0")]
	private void BBOJHMOECPG(Transform LDIAONMHHPK, NativeArray<AHIOEHODJMA> HAAAAPJLMEJ, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x76AA040", Offset = "0x76A8640", VA = "0x1876AA040")]
	private void OPBCKKNMPDH(Transform LDIAONMHHPK, NativeArray<CFIFNHKCOEJ> HEEJFCLDCIO, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76A6F40", Offset = "0x76A5540", VA = "0x1876A6F40")]
	private void CDMFPEELBNB(Transform LDIAONMHHPK, NativeArray<MDMKFMABILP> AELKOGJPIKE, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x76A8F60", Offset = "0x76A7560", VA = "0x1876A8F60")]
	private void JEOAGHMIDOM(Transform LDIAONMHHPK, NativeArray<KBKFOKGDANB> MEDHCPCLFFL, Mesh[] MONHCFOMLNO, EFMCPKJOHAF<GameObject> LAJDPIOBFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76A7880", Offset = "0x76A5E80", VA = "0x1876A7880")]
	private static void DLNHBJKJIKF(NativeParallelHashSet<Entity> AKCBEPDCJFL, NativeParallelHashSet<Entity> DFDDICABMOJ, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x76A6AE0", Offset = "0x76A50E0", VA = "0x1876A6AE0")]
	private static void AEHPFNGCBDA(NativeList<Entity> BHMKCPLLJPF, NativeArray<EntityRemapUtility.EntityRemapInfo> DMMMLPALPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x76A93A0", Offset = "0x76A79A0", VA = "0x1876A93A0")]
	private NativeParallelHashMap<Entity, AHANPLHIEFJ> KDFHHKJJJOF(KLDPNINNAMO.MPJGNLLJOLK HJCIKDMAEIH, LMCGHNEGPJF<IOMLJPNNPCO> EKEKCLLKGLB, List<GameObject> LAJDPIOBFMK)
	{
		return default(NativeParallelHashMap<Entity, AHANPLHIEFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x76A9F10", Offset = "0x76A8510", VA = "0x1876A9F10")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> MDJGKOPJEBK(Entity HNGFDACBIMA)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x76A7330", Offset = "0x76A5930", VA = "0x1876A7330")]
	private void CNBBIFJCJNG(NativeList<Entity> IGJGILGMBIM, NativeList<Entity> LFCLKAMCBFH, NativeParallelHashMap<Entity, AHANPLHIEFJ> EKGNAMGNFDP, NativeList<AFAOEOIHAIH> MDDFFJOKNCC, NativeList<MJHFHLJEIGI> PDKHPCOKAND, NativeList<EDCBAFLAMEJ> KGPPEBAFPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x76A79D0", Offset = "0x76A5FD0", VA = "0x1876A79D0")]
	private void FABBNKHLLLJ(NativeList<Entity> AKCBEPDCJFL, NativeList<Entity> DMHMKEKNCJN, NativeParallelHashMap<Entity, AHANPLHIEFJ> EKGNAMGNFDP, NativeList<JMHANPGJGMK> LMKNDBCIEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x76A2F90", Offset = "0x76A1590", VA = "0x1876A2F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS GOPPDMAABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76B3CF0", Offset = "0x76B22F0", VA = "0x1876B3CF0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 KMFOKMFOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x76B3E20", Offset = "0x76B2420", VA = "0x1876B3E20", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 OMKLEAPIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76B3F10", Offset = "0x76B2510", VA = "0x1876B3F10", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 MBMOKLLEPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76B4000", Offset = "0x76B2600", VA = "0x1876B4000", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76B3CA0", Offset = "0x76B22A0", VA = "0x1876B3CA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion ICPKADDHFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x76B3F60", Offset = "0x76B2560", VA = "0x1876B3F60", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x76B3EC0", Offset = "0x76B24C0", VA = "0x1876B3EC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 GEIPDAOLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x76B3E70", Offset = "0x76B2470", VA = "0x1876B3E70", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 EAJMBLHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x76B3DD0", Offset = "0x76B23D0", VA = "0x1876B3DD0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 ICKADFJJCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76B3FB0", Offset = "0x76B25B0", VA = "0x1876B3FB0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x76B4050", Offset = "0x76B2650", VA = "0x1876B4050")]
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
		[Cpp2IlInjected.Address(RVA = "0x76BCC40", Offset = "0x76BB240", VA = "0x1876BCC40", Slot = "17")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS DMMNKPLLMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76BCCE0", Offset = "0x76BB2E0", VA = "0x1876BCCE0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float JJLKFGGKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA9A9B0", Offset = "0xA98FB0", VA = "0x180A9A9B0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 NMBDGHBLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x76BCC90", Offset = "0x76BB290", VA = "0x1876BCC90", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private MONBNMPFMMO GAPDFOPLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCFF400", Offset = "0xCFDA00", VA = "0x180CFF400", Slot = "21")]
		get
		{
			return default(MONBNMPFMMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private CEHJAJCAOIA PNPBPBOBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x118C550", Offset = "0x118AB50", VA = "0x18118C550", Slot = "22")]
		get
		{
			return default(CEHJAJCAOIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool KBKAGLBDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IEPPMNEGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x76BCDC0", Offset = "0x76BB3C0", VA = "0x1876BCDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF71DF0", Offset = "0xF703F0", VA = "0x180F71DF0")]
		get
		{
			return default(JHDEHBMJKKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x76A58E0", Offset = "0x76A3EE0", VA = "0x1876A58E0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected ANDACNBFJKF EGGGEPPGBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x76A65A0", Offset = "0x76A4BA0", VA = "0x1876A65A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected KOJAMECNJEF NLDGJODPDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x76A5A10", Offset = "0x76A4010", VA = "0x1876A5A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected FDJNGADHLPI KMNIOGMIMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x76A5A70", Offset = "0x76A4070", VA = "0x1876A5A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject CJIMAGINEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x76A6440", Offset = "0x76A4A40", VA = "0x1876A6440", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS GOPPDMAABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xFA8650", Offset = "0xFA6C50", VA = "0x180FA8650", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 KMFOKMFOLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x76A5CC0", Offset = "0x76A42C0", VA = "0x1876A5CC0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 OMKLEAPIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76A5FE0", Offset = "0x76A45E0", VA = "0x1876A5FE0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 MBMOKLLEPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x76A6470", Offset = "0x76A4A70", VA = "0x1876A6470", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x76A5900", Offset = "0x76A3F00", VA = "0x1876A5900", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion ICPKADDHFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76A6160", Offset = "0x76A4760", VA = "0x1876A6160", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x76A5ED0", Offset = "0x76A44D0", VA = "0x1876A5ED0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 GEIPDAOLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x76A5DB0", Offset = "0x76A43B0", VA = "0x1876A5DB0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 EAJMBLHFJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x76A5B00", Offset = "0x76A4100", VA = "0x1876A5B00", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 ICKADFJJCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x76A6280", Offset = "0x76A4880", VA = "0x1876A6280", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xC9B6F0", Offset = "0xC99CF0", VA = "0x180C9B6F0")]
	protected CIPFFGLHPPM(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76A5EA0", Offset = "0x76A44A0", VA = "0x1876A5EA0")]
	public static LCHJICBNMPB HEGJABMHLEC(CIPFFGLHPPM CHBEBLKFDBC)
	{
		return default(LCHJICBNMPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class BIADNMBPMPO
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x76A38D0", Offset = "0x76A1ED0", VA = "0x1876A38D0")]
	public static void HNBADHMFMII(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FGKIPOAMLCK
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x76ADFE0", Offset = "0x76AC5E0", VA = "0x1876ADFE0")]
	public static void APDCFAHJMOK(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI, JIMDDOODGGB LDFHGGHCDLG, ANDACNBFJKF JJPIAJMIOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x76AE680", Offset = "0x76ACC80", VA = "0x1876AE680")]
	public static void KFOFBPGFKDB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI, JIMDDOODGGB LDFHGGHCDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76AE640", Offset = "0x76ACC40", VA = "0x1876AE640")]
	public static NativeList<Entity> JIENHKKPOHB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76AE990", Offset = "0x76ACF90", VA = "0x1876AE990")]
	public static NativeList<Entity> OPAPHDFNFOB(NativeArray<Entity> AKCBEPDCJFL, EntityManager IDCNJMKKJFI)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x76AE3E0", Offset = "0x76AC9E0", VA = "0x1876AE3E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76C19B0", Offset = "0x76BFFB0", VA = "0x1876C19B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GDMALILFBDO GAHPOFMMCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x76C1920", Offset = "0x76BFF20", VA = "0x1876C1920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData OPIHCFMDJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76C1A40", Offset = "0x76C0040", VA = "0x1876C1A40")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private LCHJICBNMPB IFPKJGBLMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x76A5EA0", Offset = "0x76A44A0", VA = "0x1876A5EA0", Slot = "17")]
		get
		{
			return default(LCHJICBNMPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float JJLKFGGKHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD791D0", Offset = "0xD777D0", VA = "0x180D791D0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 NMBDGHBLFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x13CAA10", Offset = "0x13C9010", VA = "0x1813CAA10", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private MONBNMPFMMO GAPDFOPLPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460", Slot = "21")]
		get
		{
			return default(MONBNMPFMMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private CEHJAJCAOIA PNPBPBOBPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB08740", Offset = "0xB06D40", VA = "0x180B08740", Slot = "22")]
		get
		{
			return default(CEHJAJCAOIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS DMMNKPLLMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x76C1980", Offset = "0x76BFF80", VA = "0x1876C1980", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IEPPMNEGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool KBKAGLBDHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x76C1CC0", Offset = "0x76C02C0", VA = "0x1876C1CC0")]
	protected PPBAOJFJHKE(FHNHGOPNICC JOFIFDPGHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76C1B30", Offset = "0x76C0130", VA = "0x1876C1B30", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x76C1860", Offset = "0x76BFE60", VA = "0x1876C1860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected LNJLGFCNCEA DIFOMIBHGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x76C1810", Offset = "0x76BFE10", VA = "0x1876C1810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x76C18B0", Offset = "0x76BFEB0", VA = "0x1876C18B0", Slot = "15")]
	public virtual void InitReferences(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x27C7370", Offset = "0x27C5970", VA = "0x1827C7370")]
	protected LKAODBAHBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GGLMMBJKLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x76C1570", Offset = "0x76BFB70", VA = "0x1876C1570")]
	public static void MMOJPLADFLJ(NativeArray<Entity> IGJGILGMBIM, EntityManager IDCNJMKKJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2554768062
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76C1EC0", Offset = "0x76C04C0", VA = "0x1876C1EC0")]
	public static void HHDEEIGDEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x76C1EB0", Offset = "0x76C04B0", VA = "0x1876C1EB0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class KABAABHEGKD : ContainerPropertyBag<CJLKCNMJBBN>
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x76C17B0", Offset = "0x76BFDB0", VA = "0x1876C17B0")]
	public KABAABHEGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class BDDEILPLCFM : ContainerPropertyBag<MGMNMOFFJEL>
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x76C14B0", Offset = "0x76BFAB0", VA = "0x1876C14B0")]
	public BDDEILPLCFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class DGOGFBMDBPL : ContainerPropertyBag<NNOEEILDDMH>
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x76C1510", Offset = "0x76BFB10", VA = "0x1876C1510")]
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
		[Cpp2IlInjected.Address(RVA = "0x76C1CF0", Offset = "0x76C02F0", VA = "0x1876C1CF0")]
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
