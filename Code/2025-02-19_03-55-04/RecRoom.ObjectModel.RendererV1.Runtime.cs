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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7651680", Offset = "0x7650280", VA = "0x187651680", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCDA0", Offset = "0x1DFB9A0", VA = "0x181DFCDA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76589F0", Offset = "0x76575F0", VA = "0x1876589F0")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7658F90", Offset = "0x7657B90", VA = "0x187658F90", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7658FF0", Offset = "0x7657BF0", VA = "0x187658FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EDPCNFHPJBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x763ECF0", Offset = "0x763D8F0", VA = "0x18763ECF0")]
	public static Quaternion NLJJBLMAJPK([In] this FLAABHJOBCN DMAKEFCFHCP, [In] Vector3 JJPEELBONAL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IGIBBHEPANK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x764D030", Offset = "0x764BC30", VA = "0x18764D030")]
	public static bool IGIAAFHFAAF(this KPHGMKHMDMA IMBIPGAJGEI, AELPFFMHMMC DLDAGIPJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x764D4E0", Offset = "0x764C0E0", VA = "0x18764D4E0")]
	public static bool PPDCFJCGILI(this KPHGMKHMDMA IMBIPGAJGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x764C550", Offset = "0x764B150", VA = "0x18764C550")]
	public static bool BLHHKDKCDKE(this KPHGMKHMDMA IMBIPGAJGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x764D3B0", Offset = "0x764BFB0", VA = "0x18764D3B0")]
	public static void OGKDMIBPBFK(this KPHGMKHMDMA IMBIPGAJGEI, Vector3 KNHFCCCHNNC, Quaternion FDIJIGAPHDA, float GHONGHPPDGL, bool NBMGGGEBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x764CB90", Offset = "0x764B790", VA = "0x18764CB90")]
	public static void GMFEONBPLPC(this KPHGMKHMDMA IMBIPGAJGEI, Vector3 KNHFCCCHNNC, Quaternion FDIJIGAPHDA, float GHONGHPPDGL, int EOCMNFJLDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x764CA70", Offset = "0x764B670", VA = "0x18764CA70")]
	public static void DOOCGEONDDM(this KPHGMKHMDMA IMBIPGAJGEI, int EOCMNFJLDLN, Vector3 KNHFCCCHNNC, Quaternion FDIJIGAPHDA, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x764D220", Offset = "0x764BE20", VA = "0x18764D220")]
	public static void LCGPJPIBDPN(this KPHGMKHMDMA IMBIPGAJGEI, Vector3 EFKBDNDLLBB, Quaternion JMCDGLBFGIL, float GHONGHPPDGL, bool NBMGGGEBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x764B970", Offset = "0x764A570", VA = "0x18764B970")]
	private static void BCEIIDCEPEP(this KPHGMKHMDMA IMBIPGAJGEI, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL, bool NBMGGGEBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x764D070", Offset = "0x764BC70", VA = "0x18764D070")]
	private static void JCGHPIMPPHP(this KPHGMKHMDMA IMBIPGAJGEI, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, float KFJIFELBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x764B790", Offset = "0x764A390", VA = "0x18764B790")]
	private static void ABEJGNCOBCA(this KPHGMKHMDMA IMBIPGAJGEI, int BIEEMEKMINN, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, float KFJIFELBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x764D270", Offset = "0x764BE70", VA = "0x18764D270")]
	private static bool LCNFHNCPJKP(this KPHGMKHMDMA IMBIPGAJGEI, int BIEEMEKMINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x764C2C0", Offset = "0x764AEC0", VA = "0x18764C2C0")]
	private static void BCJDPOOGJDJ(this KPHGMKHMDMA IMBIPGAJGEI, int BIEEMEKMINN, Vector3 DDPAPHFNFJI, Quaternion CIDNHFONBIJ, float KFJIFELBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x764C580", Offset = "0x764B180", VA = "0x18764C580")]
	public static Vector3 DDJHOJPMENG(this KPHGMKHMDMA IMBIPGAJGEI, int BIEEMEKMINN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x764D2A0", Offset = "0x764BEA0", VA = "0x18764D2A0")]
	public static Quaternion MNGJGDGLKPC(this KPHGMKHMDMA IMBIPGAJGEI, int BIEEMEKMINN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x764CE10", Offset = "0x764BA10", VA = "0x18764CE10")]
	public static Vector3 HPBMHOHPKFB(AELPFFMHMMC HOHMEIEFKJJ, Vector3 FCININPMBGJ, Vector3? HEDGLNFPFGI, Vector3 OIJMIFMDBFD)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface PBOIFBOGOJN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFBIMHLLNKA(EntityQuery ANLCMNDJLMD, EntityManager BJAJJLPDBMA, OAIDNPCNLKP ENEHENBPLMA, OBCIDGFICJO BGDHICOBJAM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface CBCLCDICLNH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType IEMEDACHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BADOIOKMEID(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOPELOBCJIF(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLLALALOGLO(NPIAAOHMPJM EMJGFCNOBKP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class LJNCKBKGGLF : PBOIFBOGOJN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7650CA0", Offset = "0x764F8A0", VA = "0x187650CA0", Slot = "4")]
	public void OFBIMHLLNKA(EntityQuery ANLCMNDJLMD, EntityManager BJAJJLPDBMA, OAIDNPCNLKP ENEHENBPLMA, OBCIDGFICJO BGDHICOBJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public LJNCKBKGGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class FAMEJDBBLGI : PBOIFBOGOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EOGPNMLBPJG HKPDLOOMFFD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
	public FAMEJDBBLGI(EOGPNMLBPJG HKPDLOOMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7643B60", Offset = "0x7642760", VA = "0x187643B60", Slot = "4")]
	public void OFBIMHLLNKA(EntityQuery ANLCMNDJLMD, EntityManager BJAJJLPDBMA, OAIDNPCNLKP ENEHENBPLMA, OBCIDGFICJO BGDHICOBJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class NFJMEMLCGEK : PBOIFBOGOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7652890", Offset = "0x7651490", VA = "0x187652890", Slot = "4")]
	public void OFBIMHLLNKA(EntityQuery ANLCMNDJLMD, EntityManager BJAJJLPDBMA, OAIDNPCNLKP ENEHENBPLMA, OBCIDGFICJO BGDHICOBJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NFJMEMLCGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DLJFHNPAPAN : CBCLCDICLNH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType IEMEDACHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x763D800", Offset = "0x763C400", VA = "0x18763D800", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x763D580", Offset = "0x763C180", VA = "0x18763D580", Slot = "5")]
	public void BADOIOKMEID(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x763D830", Offset = "0x763C430", VA = "0x18763D830", Slot = "6")]
	public void FOPELOBCJIF(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x763DAB0", Offset = "0x763C6B0", VA = "0x18763DAB0", Slot = "7")]
	public void LLLALALOGLO(NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLJFHNPAPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MMNMMBLBGLO : CBCLCDICLNH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType IEMEDACHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76524A0", Offset = "0x76510A0", VA = "0x1876524A0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7652220", Offset = "0x7650E20", VA = "0x187652220", Slot = "5")]
	public void BADOIOKMEID(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76524D0", Offset = "0x76510D0", VA = "0x1876524D0", Slot = "6")]
	public void FOPELOBCJIF(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7652750", Offset = "0x7651350", VA = "0x187652750", Slot = "7")]
	public void LLLALALOGLO(NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MMNMMBLBGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MIKKMNGBFBA : CBCLCDICLNH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType IEMEDACHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7651E90", Offset = "0x7650A90", VA = "0x187651E90", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7651C10", Offset = "0x7650810", VA = "0x187651C10", Slot = "5")]
	public void BADOIOKMEID(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7651EC0", Offset = "0x7650AC0", VA = "0x187651EC0", Slot = "6")]
	public void FOPELOBCJIF(EntityQuery ANLCMNDJLMD, NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7652140", Offset = "0x7650D40", VA = "0x187652140", Slot = "7")]
	public void LLLALALOGLO(NPIAAOHMPJM EMJGFCNOBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MIKKMNGBFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BKELNHEBPNF : LOHOFMOMPFM, PEGFAJCJPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OAIDNPCNLKP ENEHENBPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HMFAFNIBCMF PCBGOCDPNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OBCIDGFICJO BGDHICOBJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, PBOIFBOGOJN adapter)> DCGAOHJCIHK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x763B080", Offset = "0x7639C80", VA = "0x18763B080", Slot = "15")]
	public virtual void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x763B290", Offset = "0x7639E90", VA = "0x18763B290", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x763B110", Offset = "0x7639D10", VA = "0x18763B110")]
	private void OEPIIFAPDMK(EntityQueryDesc EELLJOEFHJM, PBOIFBOGOJN AENDBIABDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x763B4C0", Offset = "0x763A0C0", VA = "0x18763B4C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27631A0", Offset = "0x2761DA0", VA = "0x1827631A0")]
	public BKELNHEBPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class DIDNIKEDAKG : LOHOFMOMPFM, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class CCAJFBPALNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery GCNGKLBGNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery GHBGPHDMFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery HPHMABAAGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery AJLDAOIEBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery FHCKMBEEMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery FICDMBEFJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery OLPMNIGLAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CBCLCDICLNH KAMJAPNOENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType DILLPAKJHFK;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CCAJFBPALNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OAIDNPCNLKP ENEHENBPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OBCIDGFICJO BGDHICOBJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HMFAFNIBCMF PCBGOCDPNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<CCAJFBPALNA> DCGAOHJCIHK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x763C9A0", Offset = "0x763B5A0", VA = "0x18763C9A0", Slot = "14")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x763D170", Offset = "0x763BD70", VA = "0x18763D170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x763D2F0", Offset = "0x763BEF0", VA = "0x18763D2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x763C550", Offset = "0x763B150", VA = "0x18763C550")]
	private void ILGNJGNJDBK(CCAJFBPALNA OHCGACBJPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x763CA30", Offset = "0x763B630", VA = "0x18763CA30")]
	private void OEPIIFAPDMK(CBCLCDICLNH KAMJAPNOENJ, ComponentType NCGKDAOLHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27631A0", Offset = "0x2761DA0", VA = "0x1827631A0")]
	public DIDNIKEDAKG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct MJHHFCMMJLA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal struct KEJCMPIIPNC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal struct KICACKPHPPM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(OBCIDGFICJO), new string[] { })]
public class GFMPGHOKGKH : OBCIDGFICJO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JCPBLDHJLEF DILIOJHFLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JCPBLDHJLEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public GFMPGHOKGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(ABBAFIAPMHL), new string[] { })]
public class ILDOBHLPAAC : ABBAFIAPMHL, GJBMJKGMHHN, EPCACDHCPJF, KKIFGLMKOAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private KNHPIELBCJK CDEKECFBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private OAIDNPCNLKP ENEHENBPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private JCGKMOCONDO NAKGBBMJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity BLIKGCOOGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private IIPDOOIGMOL FLKAIJLBMHK;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x764D8E0", Offset = "0x764C4E0", VA = "0x18764D8E0", Slot = "4")]
	public bool IFEBBAMLMMD(OJMCCDFHBJG JKOPHJKJLOL, AIHLGPNPJOE MPDLOLIOGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x764D510", Offset = "0x764C110", VA = "0x18764D510", Slot = "5")]
	public IIPDOOIGMOL BHFFOAGAAKF()
	{
		return default(IIPDOOIGMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x764D7D0", Offset = "0x764C3D0", VA = "0x18764D7D0", Slot = "6")]
	public void GFFIEIENNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x764D9C0", Offset = "0x764C5C0", VA = "0x18764D9C0", Slot = "7")]
	private void KOFKNPJJNIF(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xF85140", Offset = "0xF83D40", VA = "0x180F85140", Slot = "8")]
	private void KNGPAJOOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public ILDOBHLPAAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(HDODKIPKMGF), new string[] { })]
public class JGIAJBFBEKB : HDODKIPKMGF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x764DDD0", Offset = "0x764C9D0", VA = "0x18764DDD0", Slot = "4")]
	public void DCMGCKEPJCM(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x764DD80", Offset = "0x764C980", VA = "0x18764DD80", Slot = "5")]
	public void AOGOMNLMFPE(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x764E770", Offset = "0x764D370", VA = "0x18764E770", Slot = "6")]
	public ComponentSystemBase OHENPFMDENE(World CDEKECFBCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x764E710", Offset = "0x764D310", VA = "0x18764E710", Slot = "7")]
	public void MPEMPKFKCGN(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x764DE50", Offset = "0x764CA50", VA = "0x18764DE50", Slot = "8")]
	public void FNCEMCNHOGO(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x764DEB0", Offset = "0x764CAB0", VA = "0x18764DEB0", Slot = "9")]
	public void HDGLGBAHDAB(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x764E7C0", Offset = "0x764D3C0", VA = "0x18764E7C0", Slot = "10")]
	public void OKGECGHDLEB(World CDEKECFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x764DF10", Offset = "0x764CB10", VA = "0x18764DF10", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> MNJCIOILJOO()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JGIAJBFBEKB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FBBHLEGNOEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FEEEPBBPBGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NFOLDAECBPJ : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PPIKABHIOAG GDOEMLMCAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7652A40", Offset = "0x7651640", VA = "0x187652A40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76529D0", Offset = "0x76515D0", VA = "0x1876529D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NFOLDAECBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DOAFEDPFAAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IIPDOOIGMOL ODDMLILOACN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static DOAFEDPFAAJ NIBCGLOMJGK(IIPDOOIGMOL EHNDIPGCOKP)
	{
		return default(DOAFEDPFAAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BLIPBOAAPIP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ECMOINEGHPA DBEEOHAKMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x763B6B0", Offset = "0x763A2B0", VA = "0x18763B6B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public BLIPBOAAPIP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BELLBIHAABF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FIJKKANLHPB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OJNLEJKNADA FIDFNKDDNKK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static FIJKKANLHPB NIBCGLOMJGK(OJNLEJKNADA EHNDIPGCOKP)
	{
		return default(FIJKKANLHPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GNNFOCJCPCF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IIPDOOIGMOL ODDMLILOACN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static GNNFOCJCPCF NIBCGLOMJGK(IIPDOOIGMOL EHNDIPGCOKP)
	{
		return default(GNNFOCJCPCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NKKFNHKPLPN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PBHNFJGKOIJ GKPJAPCKNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7652B00", Offset = "0x7651700", VA = "0x187652B00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7652A90", Offset = "0x7651690", VA = "0x187652A90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NKKFNHKPLPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NCFGFPKAPGG : PLLJKEFCAFA, PPIKABHIOAG, NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LKLBAIDKPCN AFJHNFGAFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBD46A0", Offset = "0xBD32A0", VA = "0x180BD46A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(LKLBAIDKPCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CLEGDGHCDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAA6B20", Offset = "0xAA5720", VA = "0x180AA6B20", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 MMJFHBPLDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xED3C30", Offset = "0xED2830", VA = "0x180ED3C30", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76527F0", Offset = "0x76513F0", VA = "0x1876527F0")]
	public NCFGFPKAPGG(UniformTRS LAJJLIFHPEH, PADKPDAFIDF KOIBCEOILEL, float PAELBJKLMOH, float3 LOCALHCHLNC, IIENBPKDKHB NHJFBGDBECB, DLFEHIBNHLA EJIAIHGOFDK, LKLBAIDKPCN BCNDEFGBDIH, float3 JNMOFAPIJCL, bool HHEAHAEOOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76527A0", Offset = "0x76513A0", VA = "0x1876527A0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MFIMKDOFNAF : PLLJKEFCAFA, PBHNFJGKOIJ, NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<DPNIHIHALMF> EFHINKKBCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly LGKICAFDIOA KNNHCEBFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float JKEPJGHOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int GCEAMCNFION;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NKLLHLLIKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7651BE0", Offset = "0x76507E0", VA = "0x187651BE0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LHMINMKFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7651C00", Offset = "0x7650800", VA = "0x187651C00", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IIOKHBDDCGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7651BF0", Offset = "0x76507F0", VA = "0x187651BF0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PNOJIKMKEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xBEA7E0", Offset = "0xBE93E0", VA = "0x180BEA7E0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float OMMLCNLCCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB42ED0", Offset = "0xB41AD0", VA = "0x180B42ED0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FLLPAMHNEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xD75340", Offset = "0xD73F40", VA = "0x180D75340", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7651B30", Offset = "0x7650730", VA = "0x187651B30")]
	public MFIMKDOFNAF(UniformTRS LAJJLIFHPEH, PADKPDAFIDF KOIBCEOILEL, float PAELBJKLMOH, float3 LOCALHCHLNC, IIENBPKDKHB NHJFBGDBECB, DLFEHIBNHLA EJIAIHGOFDK, LGKICAFDIOA KNNHCEBFGKJ, float JKEPJGHOFFI, int GCEAMCNFION, NativeArray<DPNIHIHALMF> EFHINKKBCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEECD50", Offset = "0xEEB950", VA = "0x180EECD50", Slot = "33")]
	public NativeArray<DPNIHIHALMF> GetNativeCurvePoints()
	{
		return default(NativeArray<DPNIHIHALMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7651A70", Offset = "0x7650670", VA = "0x187651A70", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GNCDCIGHLJK : GBHONMJLEGB, PPIKABHIOAG, NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<PKHCDPIAIHH, LKLBAIDKPCN> APBPJFFMLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LKLBAIDKPCN BCNDEFGBDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool HHEAHAEOOOE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private LKLBAIDKPCN AOAACHDJHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9752D0", VA = "0x1809766D0", Slot = "28")]
		get
		{
			return default(LKLBAIDKPCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool GHANKPOGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCC4450", Offset = "0xCC3050", VA = "0x180CC4450", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 MMJFHBPLDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7644B30", Offset = "0x7643730", VA = "0x187644B30", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7644B10", Offset = "0x7643710", VA = "0x187644B10")]
	public GNCDCIGHLJK(OJMCCDFHBJG PJGHLHDAMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7644490", Offset = "0x7643090", VA = "0x187644490", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76444E0", Offset = "0x76430E0", VA = "0x1876444E0", Slot = "26")]
	public override void KAFGFLAKMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PBIEJGMGDBO : PNPDJLCFELC, ECMOINEGHPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject OLAMHAPLIDN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject FOFMPGFPBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7653A50", Offset = "0x7652650", VA = "0x187653A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MLDOPOKHGBO DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7653950", Offset = "0x7652550", VA = "0x187653950", Slot = "15")]
		get
		{
			return default(MLDOPOKHGBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CBOJNGCBBKE AIKBGEJFEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "16")]
		get
		{
			return default(CBOJNGCBBKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7653AE0", Offset = "0x76526E0", VA = "0x187653AE0")]
	public PBIEJGMGDBO(OJMCCDFHBJG JKOPHJKJLOL, bool DDHALADNDML = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7653790", Offset = "0x7652390", VA = "0x187653790")]
	public void BCJIGDNHBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7653950", Offset = "0x7652550", VA = "0x187653950")]
	protected MLDOPOKHGBO EBFDBMJNJMC()
	{
		return default(MLDOPOKHGBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7653920", Offset = "0x7652520", VA = "0x187653920", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OHIIELIBEDJ : GBHONMJLEGB, PBHNFJGKOIJ, NJEBMGBJJEC, IDisposable, EHHMHNLIKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<DPNIHIHALMF> EFHINKKBCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CPLCLEKLCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool DMFHCCPDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float JKEPJGHOFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int GCEAMCNFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool EJNBOCEDFHC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool LFHBNBMOADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FB0", Offset = "0xAB2BB0", VA = "0x180AB3FB0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IBJNBIPDHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BA0", Offset = "0x9A27A0", VA = "0x1809A3BA0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float KJEOCLHOCNE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xE95CC0", Offset = "0xE948C0", VA = "0x180E95CC0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int IFDLPGBPNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBD46A0", Offset = "0xBD32A0", VA = "0x180BD46A0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool AFLJMELIBMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6B20", Offset = "0xAA5720", VA = "0x180AA6B20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int HPDCKHCJOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7653030", Offset = "0x7651C30", VA = "0x187653030", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int JPGOKAOOLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7653530", Offset = "0x7652130", VA = "0x187653530", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7653760", Offset = "0x7652360", VA = "0x187653760")]
	public OHIIELIBEDJ(OJMCCDFHBJG PJGHLHDAMNE, [Optional] NativeList<DPNIHIHALMF> EFHINKKBCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7653620", Offset = "0x7652220", VA = "0x187653620", Slot = "26")]
	public override void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7653050", Offset = "0x7651C50", VA = "0x187653050", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7653140", Offset = "0x7651D40", VA = "0x187653140", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7653700", Offset = "0x7652300", VA = "0x187653700")]
	public void OIGOGOGMJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x76531A0", Offset = "0x7651DA0", VA = "0x1876531A0", Slot = "34")]
	public NativeArray<DPNIHIHALMF> GetNativeCurvePoints()
	{
		return default(NativeArray<DPNIHIHALMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7652EE0", Offset = "0x7651AE0", VA = "0x187652EE0", Slot = "35")]
	private Vector3 BIEIBCHPOAI(int MGPCONLELFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7653370", Offset = "0x7651F70", VA = "0x187653370", Slot = "36")]
	private Quaternion JAEIIOKKGGJ(int MGPCONLELFP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76533A0", Offset = "0x7651FA0", VA = "0x1876533A0", Slot = "37")]
	private float JIEENJAILFK(int MGPCONLELFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7652E70", Offset = "0x7651A70", VA = "0x187652E70")]
	private NativeArray<Entity> AIMPNDBEEIH()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class DDFNNBOJKDO : LCBLBFFICDO
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x763C010", Offset = "0x763AC10", VA = "0x18763C010", Slot = "15")]
	protected override ComponentSystemBase JKGKHODBCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x763C3D0", Offset = "0x763AFD0", VA = "0x18763C3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x763C3E0", Offset = "0x763AFE0", VA = "0x18763C3E0")]
	public DDFNNBOJKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[HHCIOGEHFJK]
public sealed class BGCENKNGDGI : CHPKDAGBHPA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery KLGEOLFHGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery BBBBHPPBKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery KLIIJKJGDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery HAMCOMNLHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery DLIKENNJAEG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x763AAF0", Offset = "0x76396F0", VA = "0x18763AAF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x763AE50", Offset = "0x7639A50", VA = "0x18763AE50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x763A8B0", Offset = "0x76394B0", VA = "0x18763A8B0")]
	private void NMIGKKNHBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x763A5C0", Offset = "0x76391C0", VA = "0x18763A5C0")]
	private void JOFCOHBFFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x763A6D0", Offset = "0x76392D0", VA = "0x18763A6D0")]
	private void LBKJOAOBJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x763AEF0", Offset = "0x7639AF0", VA = "0x18763AEF0")]
	private void PNDLGPPCPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x763A4C0", Offset = "0x76390C0", VA = "0x18763A4C0")]
	private void CHFLDHLAFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x763AE90", Offset = "0x7639A90", VA = "0x18763AE90")]
	private NativeList<Entity> PCLKPGLLPHH(NativeArray<Entity> BMGAGFMALJB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x763A460", Offset = "0x7639060", VA = "0x18763A460")]
	private NativeList<Entity> BEDHODJFOOO(NativeArray<Entity> BMGAGFMALJB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x763AA90", Offset = "0x7639690", VA = "0x18763AA90")]
	private void NNMMAEEDMLD(NativeArray<Entity> BMGAGFMALJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public BGCENKNGDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HHCIOGEHFJK]
public sealed class JPAFGKHMIJM : CHPKDAGBHPA, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery PKGHJNDFIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery HAEKODALJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery HPHMABAAGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ABBAFIAPMHL PIPPKAJCPGA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x764FB90", Offset = "0x764E790", VA = "0x18764FB90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x764F6E0", Offset = "0x764E2E0", VA = "0x18764F6E0", Slot = "15")]
	public override void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x764FD60", Offset = "0x764E960", VA = "0x18764FD60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x764F060", Offset = "0x764DC60", VA = "0x18764F060")]
	private void HNCEFJCJJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x764E830", Offset = "0x764D430", VA = "0x18764E830")]
	private void EPIKCLMLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x764F740", Offset = "0x764E340", VA = "0x18764F740")]
	private void KEMIEEEBHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x764FAF0", Offset = "0x764E6F0", VA = "0x18764FAF0")]
	private bool MNKNPKKIGDI(Entity CANLONBNOKL, [Out] IIPDOOIGMOL ODDMLILOACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x764EEB0", Offset = "0x764DAB0", VA = "0x18764EEB0")]
	private bool GBMOFOAIKHO(Entity CANLONBNOKL, [Out] IIPDOOIGMOL ODDMLILOACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public JPAFGKHMIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[HHCIOGEHFJK]
public sealed class GIKPGCKMFIO : CHPKDAGBHPA
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery PGFLBOIHIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery KJNAJEIDCJB;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76442A0", Offset = "0x7642EA0", VA = "0x1876442A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x76443F0", Offset = "0x7642FF0", VA = "0x1876443F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7643FA0", Offset = "0x7642BA0", VA = "0x187643FA0")]
	private void HNCEFJCJJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7643CB0", Offset = "0x76428B0", VA = "0x187643CB0")]
	private void EPIKCLMLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public GIKPGCKMFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HHHBDAPKPPE : CHPKDAGBHPA, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct DFDKIGKJNLJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob CFIAKIDCOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob DLCBDBOEGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob FLIOKDLFPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob NKHINILFDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle NLLOBCHMCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<GNNFOCJCPCF> LLCJDOEKDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> OPJPHKFHINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> LLMHLNMFJKI;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x763C3F0", Offset = "0x763AFF0", VA = "0x18763C3F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x763C470", Offset = "0x763B070", VA = "0x18763C470")]
		private void PIFPAIAJEAN(EntityQueryInJob ANLCMNDJLMD, NativeList<Entity> BDFLOIGHNBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct ALANNJJBLGK : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle NLLOBCHMCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<GNNFOCJCPCF> LLCJDOEKDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> BDFLOIGHNBG;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7639DE0", Offset = "0x76389E0", VA = "0x187639DE0", Slot = "4")]
		public void Execute(ArchetypeChunk JFGJMKNOEFA, int DANNPFJNAPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct JFGABMGPCJK : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle NLLOBCHMCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> ELAFPPLNPNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<FIJKKANLHPB> AKGKPIEGPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<DOAFEDPFAAJ> PABEPNKEKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<GNNFOCJCPCF> FJMDJEMHHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> OJCIFPOCOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<FIJKKANLHPB> CHLLPCMHAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<IIPDOOIGMOL> LINIHDHHEJM;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x764DA50", Offset = "0x764C650", VA = "0x18764DA50", Slot = "4")]
		public void Execute(ArchetypeChunk JFGJMKNOEFA, int DANNPFJNAPK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery CFIAKIDCOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery DLCBDBOEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery FLIOKDLFPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery NKHINILFDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery NLMFCGECJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery KLCCBBOLBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery HFHDKHIIKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private ABBAFIAPMHL GGEOAFPJPHD;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x764AE90", Offset = "0x7649A90", VA = "0x18764AE90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x764A9F0", Offset = "0x76495F0", VA = "0x18764A9F0", Slot = "15")]
	public override void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x764B410", Offset = "0x764A010", VA = "0x18764B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7649A60", Offset = "0x7648660", VA = "0x187649A60")]
	private void AFEMHLFMIGJ(NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH, int EFALNEDCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x764A060", Offset = "0x7648C60", VA = "0x18764A060")]
	private void CDPBCHJMPPI(NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH, int HDPLDMJABKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x764AA50", Offset = "0x7649650", VA = "0x18764AA50")]
	private void LFKJEEDKPIN(NativeParallelHashSet<IIPDOOIGMOL> KNCBNMOPLNH, int OFKHEJPGGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x764A660", Offset = "0x7649260", VA = "0x18764A660")]
	private void EJHGBAMPNNB(NativeParallelHashSet<IIPDOOIGMOL> DMOFKFAACPC, int GMLDOHIKNOM, int FDFAMJGGGKO, int KKMCLLBPLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x764A4B0", Offset = "0x76490B0", VA = "0x18764A4B0")]
	private void ECNOGEDIKNM(Entity HNJAKCNEIEB, OJNLEJKNADA DGODJFKCMIC, IIPDOOIGMOL ODDMLILOACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public HHHBDAPKPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DDCLMNFNGHE : CHPKDAGBHPA
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery ALABEMIMADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery NHDPGGELJIH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x763B860", Offset = "0x763A460", VA = "0x18763B860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x763BAA0", Offset = "0x763A6A0", VA = "0x18763BAA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public DDCLMNFNGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HHCIOGEHFJK]
internal class KBGHPIFDAGE : CHPKDAGBHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class JLKAMMMJPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public EntityQuery CCEGEJKHCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery DKPEKGEKAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public JJBPEEDHGBJ DCPOHPCCGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ComponentType NCIILNHCABJ;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JLKAMMMJPHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private delegate void JJBPEEDHGBJ(NativeArray<OJNLEJKNADA> EHNDIPGCOKP, NPIAAOHMPJM EMJGFCNOBKP);

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private List<JLKAMMMJPHB> DCGAOHJCIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HMFAFNIBCMF PCBGOCDPNPC;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x764FFB0", Offset = "0x764EBB0", VA = "0x18764FFB0", Slot = "15")]
	public override void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x76501B0", Offset = "0x764EDB0", VA = "0x1876501B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7650340", Offset = "0x764EF40", VA = "0x187650340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3430B60", Offset = "0x342F760", VA = "0x183430B60")]
	private void OEPIIFAPDMK<T>(JJBPEEDHGBJ DCPOHPCCGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7650840", Offset = "0x764F440", VA = "0x187650840")]
	private static void PCMPOFOKMDF(NativeArray<OJNLEJKNADA> ICGBHNFFINL, NPIAAOHMPJM OGHPDDLCLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x764FE10", Offset = "0x764EA10", VA = "0x18764FE10")]
	private static void GNMMLJHCDNK(NativeArray<OJNLEJKNADA> ICGBHNFFINL, NPIAAOHMPJM OGHPDDLCLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7650010", Offset = "0x764EC10", VA = "0x187650010")]
	private static void OIBGGFNOIFP(NativeArray<OJNLEJKNADA> ICGBHNFFINL, NPIAAOHMPJM OGHPDDLCLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public KBGHPIFDAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HHCIOGEHFJK]
public sealed class BCEMCDKFLBC : CHPKDAGBHPA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private EntityQuery ANLCMNDJLMD;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x763A030", Offset = "0x7638C30", VA = "0x18763A030", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DKMBBPHCHGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public UniformTRS LAJJLIFHPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public StandardRenderableVisualData DANFOAGHBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LKLBAIDKPCN BCNDEFGBDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 JNMOFAPIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool HHEAHAEOOOE;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OKIDOEIDFDN(Lifetime.LoadInstance)]
public struct MKFPIMLBHNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity GEINBKBBJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeList<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> OIAAPHFFFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeParallelHashSet<Entity> OLPNAOJMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<DKMBBPHCHGC> IEMMCOCCPBB;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7652190", Offset = "0x7650D90", VA = "0x187652190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(EABAKLONAPI), new string[] { })]
internal class EABAKLONAPI : PEGFAJCJPDH, PPOHJMEPICJ, EPCACDHCPJF, KKIFGLMKOAD
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct LMBBHNENCLM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly EABAKLONAPI KOIBCEOILEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly bool KNDHOHNIGJM;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1554050", Offset = "0x1552C50", VA = "0x181554050")]
		public LMBBHNENCLM(EABAKLONAPI KOIBCEOILEL, bool KNDHOHNIGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76511E0", Offset = "0x764FDE0", VA = "0x1876511E0")]
		public Queue<POKJFIKPHBO>.Enumerator HCMJLOGCBCL()
		{
			return default(Queue<POKJFIKPHBO>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7650EA0", Offset = "0x764FAA0", VA = "0x187650EA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[DependsOn]
	private JCGKMOCONDO MPJJNLJGOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private CCMEPOLNAJF MPJBCIIBIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<NativeList<DPNIHIHALMF>> OLIMAMGPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<(Entity, List<GameObject>)> LDBBHHPDEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<OJNLEJKNADA> JHBANLIMHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CAFHNJPIJPC<POKJFIKPHBO> CNPFAJIBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private CAFHNJPIJPC<MKFPIMLBHNA> MJFONNPPJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private CAFHNJPIJPC<HNAFOJLJLEK> EACOECJLGFL;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x763E650", Offset = "0x763D250", VA = "0x18763E650", Slot = "4")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x763DC00", Offset = "0x763C800", VA = "0x18763DC00")]
	public void CINDCCPIEDL(NativeList<DPNIHIHALMF> JCJAIFCCLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x763E260", Offset = "0x763CE60", VA = "0x18763E260")]
	public void HCIGMLJCFBN(Entity KOIBCEOILEL, [In] HKBIAANNAOH<GameObject> CODBFFEDKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x763DB70", Offset = "0x763C770", VA = "0x18763DB70")]
	public void CGKNNMCJKAM(NativeList<OJNLEJKNADA> ICGBHNFFINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x763E3D0", Offset = "0x763CFD0", VA = "0x18763E3D0")]
	public void HDGLGBAHDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x763DCD0", Offset = "0x763C8D0", VA = "0x18763DCD0")]
	public void EDJFIJHHHGF(LAHFEONIIDI JHBOJJACLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x763EBD0", Offset = "0x763D7D0", VA = "0x18763EBD0")]
	public JobHandle NOCILPKGHND([In] POKJFIKPHBO KBPDEFFIKOJ, JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x763EB30", Offset = "0x763D730", VA = "0x18763EB30")]
	public JobHandle NOCILPKGHND([In] MKFPIMLBHNA KBPDEFFIKOJ, JobHandle COHFFHJAGDK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7351C80", Offset = "0x7350880", VA = "0x187351C80")]
	public LMBBHNENCLM GCCOAOKNDBD(bool KNDHOHNIGJM)
	{
		return default(LMBBHNENCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x763E600", Offset = "0x763D200", VA = "0x18763E600")]
	public DGBEKNEABMH<MKFPIMLBHNA> IBBPCDNNIEO()
	{
		return default(DGBEKNEABMH<MKFPIMLBHNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x763E8C0", Offset = "0x763D4C0", VA = "0x18763E8C0")]
	public DGBEKNEABMH<HNAFOJLJLEK> LEFJNHGBBMA()
	{
		return default(DGBEKNEABMH<HNAFOJLJLEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x763E910", Offset = "0x763D510", VA = "0x18763E910")]
	public void NGMONOEHMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x763E180", Offset = "0x763CD80", VA = "0x18763E180", Slot = "5")]
	public void GMJHFFLJMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x763E850", Offset = "0x763D450", VA = "0x18763E850", Slot = "6")]
	private void KOFKNPJJNIF(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xF92680", Offset = "0xF91280", VA = "0x180F92680", Slot = "7")]
	private void KNGPAJOOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public EABAKLONAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NLDDCAMCMPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public UniformTRS LAJJLIFHPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public StandardRenderableVisualData DANFOAGHBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public BGBHOGOFFCI KNNHCEBFGKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OKIDOEIDFDN(Lifetime.LoadInstance)]
public struct POKJFIKPHBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity GEINBKBBJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeList<Entity> BMGAGFMALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> OIAAPHFFFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeParallelHashSet<Entity> OLPNAOJMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeList<PPECJFOKLGF> HLPIHALKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<DPNIHIHALMF> JCJAIFCCLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<NLDDCAMCMPP> LKLMBNCHKMK;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7654B00", Offset = "0x7653700", VA = "0x187654B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7654B10", Offset = "0x7653710", VA = "0x187654B10")]
	public void MPDBLNIHPLD(bool KNDHOHNIGJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.LoadInstance)]
[RegisterService(typeof(MCBOKCLCILA), new string[] { })]
internal class MCBOKCLCILA : HPCHENCNLKD, EPCACDHCPJF, KKIFGLMKOAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[DependsOn]
	private EABAKLONAPI FEOLLHDHPFK;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7651A00", Offset = "0x7650600", VA = "0x187651A00", Slot = "4")]
	public void GCKDBAMOHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7651A20", Offset = "0x7650620", VA = "0x187651A20", Slot = "5")]
	private void KOFKNPJJNIF(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xF73A20", Offset = "0xF72620", VA = "0x180F73A20", Slot = "6")]
	private void KNGPAJOOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MCBOKCLCILA()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	public class PostDeserializeBakeShapesSystem : CHPKDAGBHPA, PEGFAJCJPDH
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
			public NativeParallelHashMap<int, LKLBAIDKPCN> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public NativeArray<DKMBBPHCHGC> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7644C00", Offset = "0x7643800", VA = "0x187644C00", Slot = "4")]
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
			public NativeArray<DPNIHIHALMF> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public NativeArray<PPECJFOKLGF> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public NativeArray<NLDDCAMCMPP> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7644FA0", Offset = "0x7643BA0", VA = "0x187644FA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x763B720", Offset = "0x763A320", VA = "0x18763B720", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x7654BE0", Offset = "0x76537E0", VA = "0x187654BE0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0x7654C00", Offset = "0x7653800", VA = "0x187654C00")]
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
				float3 LIHNFJPMDLO(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x76512E0", Offset = "0x764FEE0", VA = "0x1876512E0", Slot = "5")]
				public float3 NHMFMENABFL(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x76512A0", Offset = "0x764FEA0", VA = "0x1876512A0", Slot = "4")]
				public float3 LIHNFJPMDLO(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x7652B50", Offset = "0x7651750", VA = "0x187652B50", Slot = "4")]
				public float3 LIHNFJPMDLO(quaternion rotation)
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
			public NativeArray<PPECJFOKLGF> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NativeArray<DPNIHIHALMF> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x76462D0", Offset = "0x7644ED0", VA = "0x1876462D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7647580", Offset = "0x7646180", VA = "0x187647580")]
			private void MJGCOPDIDLI(NativeList<PointSrcData> srcData, NativeList<DPNIHIHALMF> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7646D20", Offset = "0x7645920", VA = "0x187646D20")]
			public static Vector3 HIPHKGAGFFA(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7645760", Offset = "0x7644360", VA = "0x187645760")]
			public static quaternion ANODKCOPJDA(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7645A60", Offset = "0x7644660", VA = "0x187645A60")]
			private static quaternion CIIDMOOECKL(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7647130", Offset = "0x7645D30", VA = "0x187647130")]
			private static float3 HMNMHOFIPJH(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x76474F0", Offset = "0x76460F0", VA = "0x1876474F0")]
			private static quaternion JHOLPOEFNHB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7646930", Offset = "0x7645530", VA = "0x187646930")]
			private static DPNIHIHALMF FFAIKJPPKGD(int idx, NativeList<PointSrcData> srcData)
			{
				return default(DPNIHIHALMF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3A75CB0", Offset = "0x3A748B0", VA = "0x183A75CB0")]
			private void KKDPAENOKPD<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x76487C0", Offset = "0x76473C0", VA = "0x1876487C0")]
			private void ONAHOMPKOOE(NativeList<PointSrcData> sourcePoints, NativeList<DPNIHIHALMF> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7646BA0", Offset = "0x76457A0", VA = "0x187646BA0")]
			public static float GKIFJPAKFED(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7647300", Offset = "0x7645F00", VA = "0x187647300")]
			private static quaternion IHHJHJNCOFI(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7645870", Offset = "0x7644470", VA = "0x187645870")]
			private static DPNIHIHALMF AOHNGMBECKJ(PointSrcData point)
			{
				return default(DPNIHIHALMF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x76457E0", Offset = "0x76443E0", VA = "0x1876457E0")]
			private static DPNIHIHALMF AOHNGMBECKJ(float3 pos, quaternion rot, float radius)
			{
				return default(DPNIHIHALMF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x76456C0", Offset = "0x76442C0", VA = "0x1876456C0")]
			private static bool AGMGMMODKNK(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7645990", Offset = "0x7644590", VA = "0x187645990")]
			private static float3 BELIFNACNOG(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7648610", Offset = "0x7647210", VA = "0x187648610")]
			public static float3 OKALOBHEDKP(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7648460", Offset = "0x7647060", VA = "0x187648460")]
			public static float3 NHMFMENABFL(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7645C90", Offset = "0x7644890", VA = "0x187645C90")]
			private static quaternion CJECOKALJAM(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x76460F0", Offset = "0x7644CF0", VA = "0x1876460F0")]
			private static float CKGLNOBMJFN(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x7656D90", Offset = "0x7655990", VA = "0x187656D90")]
			private void KEFCEEFPFNI(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7656CA0", Offset = "0x76558A0", VA = "0x187656CA0", Slot = "4")]
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
			public NativeList<DPNIHIHALMF> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7658620", Offset = "0x7657220", VA = "0x187658620")]
			private void KEFCEEFPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7658610", Offset = "0x7657210", VA = "0x187658610", Slot = "4")]
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
			public NativeList<DPNIHIHALMF> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x76585C0", Offset = "0x76571C0", VA = "0x1876585C0")]
			private void KEFCEEFPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x76585B0", Offset = "0x76571B0", VA = "0x1876585B0", Slot = "4")]
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
			public NativeList<DKMBBPHCHGC> data;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x76452F0", Offset = "0x7643EF0", VA = "0x1876452F0")]
			private void KEFCEEFPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x76452E0", Offset = "0x7643EE0", VA = "0x1876452E0", Slot = "4")]
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
			public NativeList<PPECJFOKLGF> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<NLDDCAMCMPP> bakedData;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x76454C0", Offset = "0x76440C0", VA = "0x1876454C0")]
			private void KEFCEEFPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x76454B0", Offset = "0x76440B0", VA = "0x1876454B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7658190", Offset = "0x7656D90", VA = "0x187658190")]
			private void KEFCEEFPFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7658180", Offset = "0x7656D80", VA = "0x187658180", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static readonly NDNFAPMFFIF log;

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
		private JFJCNAGDFGL replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private JCGKMOCONDO objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EABAKLONAPI bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private AICMKIHAFMN ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7656930", Offset = "0x7655530", VA = "0x187656930", Slot = "15")]
		public override void InitReferences(AILCBCECHFO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x76571C0", Offset = "0x7655DC0", VA = "0x1876571C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76572B0", Offset = "0x7655EB0", VA = "0x1876572B0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7657310", Offset = "0x7655F10", VA = "0x187657310", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76550E0", Offset = "0x7653CE0", VA = "0x1876550E0")]
		private JobHandle EGONJMFMOIE(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7655420", Offset = "0x7654020", VA = "0x187655420")]
		private JobHandle EJFBFAKJCNN(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x76569D0", Offset = "0x76555D0", VA = "0x1876569D0")]
		private JobHandle KJEPNCKKBFI(NativeArray<int> pointCount, NativeList<DPNIHIHALMF> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7656890", Offset = "0x7655490", VA = "0x187656890")]
		private JobHandle OMLPMPDCPEL(NativeList<DPNIHIHALMF> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7657720", Offset = "0x7656320", VA = "0x187657720")]
		private JobHandle PKHGDPIKJIN(EntityQuery query, NativeList<PPECJFOKLGF> splinePointRanges, NativeList<DPNIHIHALMF> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7656020", Offset = "0x7654C20", VA = "0x187656020")]
		private JobHandle FCHPGNKFBII(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7655F00", Offset = "0x7654B00", VA = "0x187655F00")]
		private JobHandle EPJKCIOCIII(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7657480", Offset = "0x7656080", VA = "0x187657480")]
		private JobHandle PAAMBCGCOCE(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<DKMBBPHCHGC> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7656140", Offset = "0x7654D40", VA = "0x187656140")]
		private JobHandle FNEBBNMOOFL(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<PPECJFOKLGF> splinePointRanges, [Out] NativeList<NLDDCAMCMPP> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7654D60", Offset = "0x7653960", VA = "0x187654D60")]
		private JobHandle EAHONEEMOID(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7657BF0", Offset = "0x76567F0", VA = "0x187657BF0")]
		private JobHandle PPDAGCGLKKN(EntityQuery query, NativeList<DKMBBPHCHGC> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7655AE0", Offset = "0x76546E0", VA = "0x187655AE0")]
		private static NativeParallelHashMap<int, LKLBAIDKPCN> EKCHFJEKIHN()
		{
			return default(NativeParallelHashMap<int, LKLBAIDKPCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7656400", Offset = "0x7655000", VA = "0x187656400")]
		private JobHandle ICIGMHNLBOI(EntityQuery query, NativeList<PPECJFOKLGF> splinePointRanges, NativeList<DPNIHIHALMF> splinePointData, NativeList<NLDDCAMCMPP> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7656BC0", Offset = "0x76557C0", VA = "0x187656BC0")]
		private JobHandle LLCBMPHAHOO(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x76569D0", Offset = "0x76555D0", VA = "0x1876569D0")]
		private JobHandle MABEJANAPCE(NativeArray<int> pointCount, NativeList<DPNIHIHALMF> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7656890", Offset = "0x7655490", VA = "0x187656890")]
		private JobHandle IJEFEMFGLAJ(NativeList<DPNIHIHALMF> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x76567A0", Offset = "0x76553A0", VA = "0x1876567A0")]
		private JobHandle IDMFCBNAPEA(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<DKMBBPHCHGC> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7654C50", Offset = "0x7653850", VA = "0x187654C50")]
		private JobHandle AADGIIKPKOE(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<PPECJFOKLGF> ranges, NativeList<NLDDCAMCMPP> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7656A70", Offset = "0x7655670", VA = "0x187656A70")]
		private JobHandle LEAPJCIDGNL(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7656E70", Offset = "0x7655A70", VA = "0x187656E70", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DPLAEDCNAEJ : LOHOFMOMPFM, PEGFAJCJPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private EABAKLONAPI FEOLLHDHPFK;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x763DB00", Offset = "0x763C700", VA = "0x18763DB00", Slot = "14")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x763DB50", Offset = "0x763C750", VA = "0x18763DB50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x27631A0", Offset = "0x2761DA0", VA = "0x1827631A0")]
	public DPLAEDCNAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AlwaysUpdateSystem]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public class EFOHDHPGPJE : CHPKDAGBHPA, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct HPIDNFKKBED<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private EntityManager BJAJJLPDBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private JNFNJEFEDIN<T> MHJJDBNKJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int BIEEMEKMINN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x463E890", Offset = "0x463D490", VA = "0x18463E890")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x463EFE0", Offset = "0x463DBE0", VA = "0x18463EFE0")]
		public HPIDNFKKBED(EntityManager BJAJJLPDBMA, JNFNJEFEDIN<T> MHJJDBNKJFA, NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x409BDF0", Offset = "0x409A9F0", VA = "0x18409BDF0")]
		public HPIDNFKKBED<T> HCMJLOGCBCL()
		{
			return default(HPIDNFKKBED<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x463E4A0", Offset = "0x463D0A0", VA = "0x18463E4A0")]
		public bool DJBPCPHNBAK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly NDNFAPMFFIF FGEFNPEPPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private CCMEPOLNAJF MPJBCIIBIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EABAKLONAPI FEOLLHDHPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int ACHENBPHIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string HEFCCLHIPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7641820", Offset = "0x7640420", VA = "0x187641820", Slot = "15")]
	public override void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x76428F0", Offset = "0x76414F0", VA = "0x1876428F0")]
	public void OKGECGHDLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7642920", Offset = "0x7641520", VA = "0x187642920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7640740", Offset = "0x763F340", VA = "0x187640740")]
	private void HGANDDJLKMH(HNAFOJLJLEK KBPDEFFIKOJ, Mesh[] HMICJGHEICD, NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x31CEE50", Offset = "0x31CDA50", VA = "0x1831CEE50")]
	private HPIDNFKKBED<T> DICPPNABOHA<T>(JNFNJEFEDIN<T> MHJJDBNKJFA, NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA) where T : struct
	{
		return default(HPIDNFKKBED<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7642560", Offset = "0x7641160", VA = "0x187642560")]
	private void MJMINBNAOAF(Transform KOIBCEOILEL, NativeArray<BIIPMFCPIMF> PDEOIIJLIHA, HKBIAANNAOH<GameObject> PFGFGAODPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x763EE90", Offset = "0x763DA90", VA = "0x18763EE90")]
	private void BAJCOIJBHHL(Transform KOIBCEOILEL, NativeArray<GMFBGOFFGOE> IJNCEBDCGIF, HKBIAANNAOH<GameObject> PFGFGAODPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x763F460", Offset = "0x763E060", VA = "0x18763F460")]
	private void DIBDGEJGCED(Transform KOIBCEOILEL, NativeArray<PNMDKADKHIK> JNKGDJAPKMK, HKBIAANNAOH<GameObject> PFGFGAODPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x76401B0", Offset = "0x763EDB0", VA = "0x1876401B0")]
	private void FMCLHGHMNDP(Transform KOIBCEOILEL, NativeArray<MFEDHNFKANJ> HMICJGHEICD, Mesh[] NKNBNKOGCLC, HKBIAANNAOH<GameObject> PFGFGAODPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x76405F0", Offset = "0x763F1F0", VA = "0x1876405F0")]
	private static void GHNFIJPEANF(NativeParallelHashSet<Entity> BMGAGFMALJB, NativeParallelHashSet<Entity> NBFNKOOIBIM, NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x763EDD0", Offset = "0x763D9D0", VA = "0x18763EDD0")]
	private static void AHGAAECBKNO(NativeList<Entity> DGHHCPPFODF, NativeArray<EntityRemapUtility.EntityRemapInfo> OONJPDICBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x76419E0", Offset = "0x76405E0", VA = "0x1876419E0")]
	private NativeParallelHashMap<Entity, DOAFEDPFAAJ> LHCCHDOEPIO(EABAKLONAPI.LMBBHNENCLM MBHHPLLMMHK, DGBEKNEABMH<MKFPIMLBHNA> JPNDEHOIALN, List<GameObject> PFGFGAODPLH)
	{
		return default(NativeParallelHashMap<Entity, DOAFEDPFAAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x763F360", Offset = "0x763DF60", VA = "0x18763F360")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BEOGMAHMLJG(Entity HOMGFDAGBLD)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x763F860", Offset = "0x763E460", VA = "0x18763F860")]
	private void EOEIFBMLNAM(NativeList<Entity> CLBPLDJOFGK, NativeList<Entity> JFKMPHIMIPE, NativeParallelHashMap<Entity, DOAFEDPFAAJ> BEIBLJJFLEP, NativeList<PPECJFOKLGF> PKBGMBDPLNP, NativeList<DPNIHIHALMF> DOJPHAIMFLM, NativeList<NLDDCAMCMPP> OLIMAMGPDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x763FDC0", Offset = "0x763E9C0", VA = "0x18763FDC0")]
	private void FAHKPCEKCLN(NativeList<Entity> BMGAGFMALJB, NativeList<Entity> OIAAPHFFFEC, NativeParallelHashMap<Entity, DOAFEDPFAAJ> BEIBLJJFLEP, NativeList<DKMBBPHCHGC> IEMMCOCCPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x763B070", Offset = "0x7639C70", VA = "0x18763B070")]
	public EFOHDHPGPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class HEHPJOMLADL : ONILLEMOPDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly UniformTRS LAJJLIFHPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly PADKPDAFIDF KOIBCEOILEL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject NHPMFLLANLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS NKNHMFFFNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7649890", Offset = "0x7648490", VA = "0x187649890", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 FNDCHCDDGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x76496B0", Offset = "0x76482B0", VA = "0x1876496B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 IKKBICGPAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76499C0", Offset = "0x76485C0", VA = "0x1876499C0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 HHOMGGEAEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76497F0", Offset = "0x76483F0", VA = "0x1876497F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76497A0", Offset = "0x76483A0", VA = "0x1876497A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion DFAJIFOCEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7649700", Offset = "0x7648300", VA = "0x187649700", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7649840", Offset = "0x7648440", VA = "0x187649840", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 CIIDEHEAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7649970", Offset = "0x7648570", VA = "0x187649970", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 JPCIJMLKAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7649750", Offset = "0x7648350", VA = "0x187649750", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 IMAJJNAKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7649660", Offset = "0x7648260", VA = "0x187649660", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7649A10", Offset = "0x7648610", VA = "0x187649A10")]
	public HEHPJOMLADL(UniformTRS LAJJLIFHPEH, PADKPDAFIDF KOIBCEOILEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class PLLJKEFCAFA : HEHPJOMLADL, NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float PAELBJKLMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly float3 LOCALHCHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly IIENBPKDKHB NHJFBGDBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly DLFEHIBNHLA EJIAIHGOFDK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private MLDOPOKHGBO POGHEFAFDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7653C80", Offset = "0x7652880", VA = "0x187653C80", Slot = "17")]
		get
		{
			return default(MLDOPOKHGBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS IGIEIIBCKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7653CD0", Offset = "0x76528D0", VA = "0x187653CD0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float NCGGMBHFLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA9DDF0", Offset = "0xA9C9F0", VA = "0x180A9DDF0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 IJMPOLKHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7653C30", Offset = "0x7652830", VA = "0x187653C30", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private IIENBPKDKHB PNKHJAOAKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCED400", Offset = "0xCEC000", VA = "0x180CED400", Slot = "21")]
		get
		{
			return default(IIENBPKDKHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private DLFEHIBNHLA JAKDDDAKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x117DDC0", Offset = "0x117C9C0", VA = "0x18117DDC0", Slot = "22")]
		get
		{
			return default(DLFEHIBNHLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool EJJPJCLFABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KLGBGKEHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7653DB0", Offset = "0x76529B0", VA = "0x187653DB0")]
	protected PLLJKEFCAFA(UniformTRS LAJJLIFHPEH, PADKPDAFIDF KOIBCEOILEL, float PAELBJKLMOH, float3 LOCALHCHLNC, IIENBPKDKHB NHJFBGDBECB, DLFEHIBNHLA EJIAIHGOFDK)
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
public abstract class PNPDJLCFELC : ONILLEMOPDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly OJMCCDFHBJG KJFLIOABFFB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected PADKPDAFIDF GGPPCPGJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xF68890", Offset = "0xF67490", VA = "0x180F68890")]
		get
		{
			return default(PADKPDAFIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity DCAIFFNHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7654AE0", Offset = "0x76536E0", VA = "0x187654AE0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected JCGKMOCONDO EJJFAALPFID
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7654770", Offset = "0x7653370", VA = "0x187654770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected JKCBDBLFMMD HOOHOMDEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x76543C0", Offset = "0x7652FC0", VA = "0x1876543C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected JJLPEBMBDPJ BHFPLIEPHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7654A50", Offset = "0x7653650", VA = "0x187654A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject NHPMFLLANLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7654870", Offset = "0x7653470", VA = "0x187654870", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS NKNHMFFFNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xF838D0", Offset = "0xF824D0", VA = "0x180F838D0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 FNDCHCDDGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7653FF0", Offset = "0x7652BF0", VA = "0x187653FF0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 IKKBICGPAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x76548D0", Offset = "0x76534D0", VA = "0x1876548D0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 HHOMGGEAEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7654530", Offset = "0x7653130", VA = "0x187654530", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7654420", Offset = "0x7653020", VA = "0x187654420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion DFAJIFOCEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76540E0", Offset = "0x7652CE0", VA = "0x1876540E0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7654660", Offset = "0x7653260", VA = "0x187654660", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 CIIDEHEAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7654780", Offset = "0x7653380", VA = "0x187654780", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 JPCIJMLKAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7654200", Offset = "0x7652E00", VA = "0x187654200", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 IMAJJNAKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7653E30", Offset = "0x7652A30", VA = "0x187653E30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xC75730", Offset = "0xC74330", VA = "0x180C75730")]
	protected PNPDJLCFELC(OJMCCDFHBJG PJGHLHDAMNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76548A0", Offset = "0x76534A0", VA = "0x1876548A0")]
	public static MLDOPOKHGBO NIBCGLOMJGK(PNPDJLCFELC LDIBCOFKEDC)
	{
		return default(MLDOPOKHGBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KIBEKKIHFPO
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7650A60", Offset = "0x764F660", VA = "0x187650A60")]
	public static void PHIFHEJCEIO(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class AKIMCDBMLHD
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x76399E0", Offset = "0x76385E0", VA = "0x1876399E0")]
	public static void PFHOFAAEPFD(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA, LAHFEONIIDI NAKKAOFGDJM, JCGKMOCONDO NAKGBBMJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7639690", Offset = "0x7638290", VA = "0x187639690")]
	public static void MKGLICODNBN(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA, LAHFEONIIDI NAKKAOFGDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7639650", Offset = "0x7638250", VA = "0x187639650")]
	public static NativeList<Entity> BEDHODJFOOO(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76399A0", Offset = "0x76385A0", VA = "0x1876399A0")]
	public static NativeList<Entity> PCLKPGLLPHH(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x76393F0", Offset = "0x7637FF0", VA = "0x1876393F0")]
	private static NativeList<Entity> BEDHODJFOOO(NativeArray<Entity> BMGAGFMALJB, EntityManager BJAJJLPDBMA, bool MJOMGGLBOGO)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class GBHONMJLEGB : PNPDJLCFELC, NJEBMGBJJEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private float PAELBJKLMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Vector3 LOCALHCHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IIENBPKDKHB NHJFBGDBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private DLFEHIBNHLA EJIAIHGOFDK;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager JKMHIGGDNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7659780", Offset = "0x7658380", VA = "0x187659780")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected KNHPIELBCJK BFMNHKCMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7659590", Offset = "0x7658190", VA = "0x187659590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData IJPAPDNABDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x76594A0", Offset = "0x76580A0", VA = "0x1876594A0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private MLDOPOKHGBO POGHEFAFDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x76548A0", Offset = "0x76534A0", VA = "0x1876548A0", Slot = "17")]
		get
		{
			return default(MLDOPOKHGBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float NCGGMBHFLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xD69C10", Offset = "0xD68810", VA = "0x180D69C10", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 IJMPOLKHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x13CD1C0", Offset = "0x13CBDC0", VA = "0x1813CD1C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private IIENBPKDKHB PNKHJAOAKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840", Slot = "21")]
		get
		{
			return default(IIENBPKDKHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private DLFEHIBNHLA JAKDDDAKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB0EFA0", Offset = "0xB0DBA0", VA = "0x180B0EFA0", Slot = "22")]
		get
		{
			return default(DLFEHIBNHLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS IGIEIIBCKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7659810", Offset = "0x7658410", VA = "0x187659810", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KLGBGKEHGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x986300", Offset = "0x984F00", VA = "0x180986300", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x986080", Offset = "0x984C80", VA = "0x180986080")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool EJJPJCLFABG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7659840", Offset = "0x7658440", VA = "0x187659840")]
	protected GBHONMJLEGB(OJMCCDFHBJG PJGHLHDAMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76595F0", Offset = "0x76581F0", VA = "0x1876595F0", Slot = "26")]
	public virtual void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class CHPKDAGBHPA : LOHOFMOMPFM, PEGFAJCJPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected JCGKMOCONDO NAKGBBMJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private OAIDNPCNLKP ENEHENBPLMA;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected LAHFEONIIDI BBBHJIHEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7659380", Offset = "0x7657F80", VA = "0x187659380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected NPIAAOHMPJM GCHACOOLJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7659330", Offset = "0x7657F30", VA = "0x187659330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x76593D0", Offset = "0x7657FD0", VA = "0x1876593D0", Slot = "15")]
	public virtual void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x27631A0", Offset = "0x2761DA0", VA = "0x1827631A0")]
	protected CHPKDAGBHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class BFJBDHJHEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x76590F0", Offset = "0x7657CF0", VA = "0x1876590F0")]
	public static void DJGIBPANBMN(NativeArray<Entity> CLBPLDJOFGK, EntityManager BJAJJLPDBMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4198717563
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7659B00", Offset = "0x7658700", VA = "0x187659B00")]
	public static void GJEHIDHJLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7659AF0", Offset = "0x76586F0", VA = "0x187659AF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class PABDMEIJKIN : ContainerPropertyBag<NFOLDAECBPJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x76598D0", Offset = "0x76584D0", VA = "0x1876598D0")]
	public PABDMEIJKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal class JCEGAHFBAHL : ContainerPropertyBag<BLIPBOAAPIP>
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7659870", Offset = "0x7658470", VA = "0x187659870")]
	public JCEGAHFBAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FHLONJDCOGO : ContainerPropertyBag<NKKFNHKPLPN>
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7659440", Offset = "0x7658040", VA = "0x187659440")]
	public FHLONJDCOGO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7659930", Offset = "0x7658530", VA = "0x187659930")]
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
