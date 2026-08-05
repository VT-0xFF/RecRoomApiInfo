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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77A43B0", Offset = "0x77A35B0", VA = "0x1877A43B0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E90770", Offset = "0x1E8F970", VA = "0x181E90770", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77B26C0", Offset = "0x77B18C0", VA = "0x1877B26C0")]
		private void BCKFAMNGJJN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77B2C60", Offset = "0x77B1E60", VA = "0x1877B2C60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77B2CC0", Offset = "0x77B1EC0", VA = "0x1877B2CC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MHDAJACADMA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77A4C70", Offset = "0x77A3E70", VA = "0x1877A4C70")]
	public static Quaternion MJMJNMBIGBF([In] this CLMGHJDLADB OFLKAPOMOKH, [In] Vector3 FOKNLDGGKBN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BKPPOOLFCNA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7794F10", Offset = "0x7794110", VA = "0x187794F10")]
	public static bool KCLBANCEJAP(this CAMGGILPPIO GBAEHOGFOIG, HLJNCAAHCPJ GONPIINPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77952D0", Offset = "0x77944D0", VA = "0x1877952D0")]
	public static bool PLPELCGKHGA(this CAMGGILPPIO GBAEHOGFOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7793580", Offset = "0x7792780", VA = "0x187793580")]
	public static bool AJOKDPBPBIC(this CAMGGILPPIO GBAEHOGFOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7795170", Offset = "0x7794370", VA = "0x187795170")]
	public static void OHPPKHBMNDM(this CAMGGILPPIO GBAEHOGFOIG, Vector3 FOHNJIHBJKM, Quaternion CDJAHMGPKAC, float LDCGEIMNGOD, bool OMJCHCJNHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77937E0", Offset = "0x77929E0", VA = "0x1877937E0")]
	public static void CDBCPFKKFHH(this CAMGGILPPIO GBAEHOGFOIG, Vector3 FOHNJIHBJKM, Quaternion CDJAHMGPKAC, float LDCGEIMNGOD, int CPFJACEFIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77944C0", Offset = "0x77936C0", VA = "0x1877944C0")]
	public static void FPJLPDOOHDI(this CAMGGILPPIO GBAEHOGFOIG, int CPFJACEFIGE, Vector3 FOHNJIHBJKM, Quaternion CDJAHMGPKAC, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77935B0", Offset = "0x77927B0", VA = "0x1877935B0")]
	public static void BHAOOMDHALM(this CAMGGILPPIO GBAEHOGFOIG, Vector3 NOFOEEIMHKF, Quaternion EICEHDFMIED, float LDCGEIMNGOD, bool OMJCHCJNHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7793A60", Offset = "0x7792C60", VA = "0x187793A60")]
	private static void DGNHBEFJMEN(this CAMGGILPPIO GBAEHOGFOIG, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD, bool OMJCHCJNHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77945E0", Offset = "0x77937E0", VA = "0x1877945E0")]
	private static void GGHGAMGJLNJ(this CAMGGILPPIO GBAEHOGFOIG, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA, float MFEOFCCHHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7793600", Offset = "0x7792800", VA = "0x187793600")]
	private static void BIMAGBGEAMD(this CAMGGILPPIO GBAEHOGFOIG, int KOOLKCPAFBB, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA, float MFEOFCCHHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77952A0", Offset = "0x77944A0", VA = "0x1877952A0")]
	private static bool OKEHJGGBOAJ(this CAMGGILPPIO GBAEHOGFOIG, int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7794C80", Offset = "0x7793E80", VA = "0x187794C80")]
	private static void IKHKNFJEJOK(this CAMGGILPPIO GBAEHOGFOIG, int KOOLKCPAFBB, Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA, float MFEOFCCHHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7794790", Offset = "0x7793990", VA = "0x187794790")]
	public static Vector3 GOGJIGNCFOG(this CAMGGILPPIO GBAEHOGFOIG, int KOOLKCPAFBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77943B0", Offset = "0x77935B0", VA = "0x1877943B0")]
	public static Quaternion EDKPBINGINI(this CAMGGILPPIO GBAEHOGFOIG, int KOOLKCPAFBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7794F50", Offset = "0x7794150", VA = "0x187794F50")]
	public static Vector3 NFBKDACEAAG(HLJNCAAHCPJ BCFKGGKKKIL, Vector3 LBPAIJGCICL, Vector3? IEIBKIHFBGD, Vector3 LMDIMFEOKIO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface HIMBCNKIMMI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHANOCDIIOD(EntityQuery DOPGKNOHOBG, EntityManager HOPEOGNNILD, OEMELGDKBOH OCNNBPCACIL, BGFIDOBDAGA MJBNIBAEHFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface HGMFKLHGCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType ILFGBJDCJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAGOPHDAPAB(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNAGGDKBGOC(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMCBADLCHNK(FDBJDLMKNEH CGJOMDOPKHL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class GGHKBKHEEKE : HIMBCNKIMMI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7798B10", Offset = "0x7797D10", VA = "0x187798B10", Slot = "4")]
	public void IHANOCDIIOD(EntityQuery DOPGKNOHOBG, EntityManager HOPEOGNNILD, OEMELGDKBOH OCNNBPCACIL, BGFIDOBDAGA MJBNIBAEHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GGHKBKHEEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class KEGBODFMGFA : HIMBCNKIMMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MPMHJLBLEOI JNIGJFGCALI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
	public KEGBODFMGFA(MPMHJLBLEOI JNIGJFGCALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77A3130", Offset = "0x77A2330", VA = "0x1877A3130", Slot = "4")]
	public void IHANOCDIIOD(EntityQuery DOPGKNOHOBG, EntityManager HOPEOGNNILD, OEMELGDKBOH OCNNBPCACIL, BGFIDOBDAGA MJBNIBAEHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class FAFNNJHLBNH : HIMBCNKIMMI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77982B0", Offset = "0x77974B0", VA = "0x1877982B0", Slot = "4")]
	public void IHANOCDIIOD(EntityQuery DOPGKNOHOBG, EntityManager HOPEOGNNILD, OEMELGDKBOH OCNNBPCACIL, BGFIDOBDAGA MJBNIBAEHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FAFNNJHLBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FJNPFPPLBIK : HGMFKLHGCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType ILFGBJDCJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7798500", Offset = "0x7797700", VA = "0x187798500", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77987B0", Offset = "0x77979B0", VA = "0x1877987B0", Slot = "5")]
	public void MAGOPHDAPAB(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7798530", Offset = "0x7797730", VA = "0x187798530", Slot = "6")]
	public void JNAGGDKBGOC(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x77984B0", Offset = "0x77976B0", VA = "0x1877984B0", Slot = "7")]
	public void DMCBADLCHNK(FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FJNPFPPLBIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DIKJJCLDGPK : HGMFKLHGCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType ILFGBJDCJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7796160", Offset = "0x7795360", VA = "0x187796160", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7796410", Offset = "0x7795610", VA = "0x187796410", Slot = "5")]
	public void MAGOPHDAPAB(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7796190", Offset = "0x7795390", VA = "0x187796190", Slot = "6")]
	public void JNAGGDKBGOC(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7796110", Offset = "0x7795310", VA = "0x187796110", Slot = "7")]
	public void DMCBADLCHNK(FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DIKJJCLDGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NPAHDNHPDAK : HGMFKLHGCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType ILFGBJDCJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77A7720", Offset = "0x77A6920", VA = "0x1877A7720", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77A79D0", Offset = "0x77A6BD0", VA = "0x1877A79D0", Slot = "5")]
	public void MAGOPHDAPAB(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77A7750", Offset = "0x77A6950", VA = "0x1877A7750", Slot = "6")]
	public void JNAGGDKBGOC(EntityQuery DOPGKNOHOBG, FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77A76D0", Offset = "0x77A68D0", VA = "0x1877A76D0", Slot = "7")]
	public void DMCBADLCHNK(FDBJDLMKNEH CGJOMDOPKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NPAHDNHPDAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class DINLNODDJHD : IJJBIAEOBIE, ANAKBJKCMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OEMELGDKBOH OCNNBPCACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DOAJILOHGAC LGIKKEKIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BGFIDOBDAGA MJBNIBAEHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, HIMBCNKIMMI adapter)> IIMFMKDGECA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7796800", Offset = "0x7795A00", VA = "0x187796800", Slot = "15")]
	public virtual void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7796890", Offset = "0x7795A90", VA = "0x187796890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7796690", Offset = "0x7795890", VA = "0x187796690")]
	private void FMCIANIIFDC(EntityQueryDesc CPHPMAOLCBE, HIMBCNKIMMI EPCDKKOGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7796AC0", Offset = "0x7795CC0", VA = "0x187796AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC20", Offset = "0x27ECE20", VA = "0x1827EDC20")]
	public DINLNODDJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class JDCOMFICKBC : IJJBIAEOBIE, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class KKIIFKOBLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery KLGBPMGOOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery DCPKOHCKGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery AGGMBKLGPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery ICBGMABEDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery JFBJHFBJCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery NHEOHLKKNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery JEECDJIHJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HGMFKLHGCLD BMOBGLHFIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType APOLCPFMOOO;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KKIIFKOBLJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OEMELGDKBOH OCNNBPCACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BGFIDOBDAGA MJBNIBAEHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DOAJILOHGAC LGIKKEKIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<KKIIFKOBLJP> IIMFMKDGECA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x77A2A50", Offset = "0x77A1C50", VA = "0x1877A2A50", Slot = "14")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x77A2AE0", Offset = "0x77A1CE0", VA = "0x1877A2AE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77A2C60", Offset = "0x77A1E60", VA = "0x1877A2C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x77A1EC0", Offset = "0x77A10C0", VA = "0x1877A1EC0")]
	private void CJCONLAOPEM(KKIIFKOBLJP ACAKIKHJABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77A2310", Offset = "0x77A1510", VA = "0x1877A2310")]
	private void FMCIANIIFDC(HGMFKLHGCLD BMOBGLHFIEJ, ComponentType NBCFAFJPEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC20", Offset = "0x27ECE20", VA = "0x1827EDC20")]
	public JDCOMFICKBC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct HJEHHANIAPI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct FDMKFJFODGL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct MMOAJMBOEMJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(BGFIDOBDAGA), new string[] { })]
public class LDFHJIGJMHA : BGFIDOBDAGA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GIHAKHDNNJF KFAKAGIENPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GIHAKHDNNJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LDFHJIGJMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(HJOJPOMBOGB), new string[] { })]
public class MFPJKGANHEA : HJOJPOMBOGB, HKIFLJPIKLG, ACFHKDFELAE, CBKDENAGIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private LDFBPFEFEGF HCDDAGKOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private OEMELGDKBOH OCNNBPCACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private NFIPPAIECID BOCHMICIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Entity PNBGGKFBBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private OMLFPKHBOMD DBLLLGCBBMB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77A4730", Offset = "0x77A3930", VA = "0x1877A4730", Slot = "4")]
	public bool JELGOGLJHAH(EOFNBBMGHCB DEBNBMMFJPK, AIPPNDPMCFL OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77A48A0", Offset = "0x77A3AA0", VA = "0x1877A48A0", Slot = "5")]
	public OMLFPKHBOMD MJHLAGAELAB()
	{
		return default(OMLFPKHBOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x77A4B60", Offset = "0x77A3D60", VA = "0x1877A4B60", Slot = "6")]
	public void POPKDACAFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77A4810", Offset = "0x77A3A10", VA = "0x1877A4810", Slot = "7")]
	private void LAHBCOILANO(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x100E750", Offset = "0x100D950", VA = "0x18100E750", Slot = "8")]
	private void HCHPEMCKIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MFPJKGANHEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(MMGJDMHNHJM), new string[] { })]
public class NOGMKJEKCAG : MMGJDMHNHJM
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77A6C20", Offset = "0x77A5E20", VA = "0x1877A6C20", Slot = "4")]
	public void BEEEGNHCCKA(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77A6E20", Offset = "0x77A6020", VA = "0x1877A6E20", Slot = "5")]
	public void KKMJKJDBAOF(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x77A6D00", Offset = "0x77A5F00", VA = "0x1877A6D00", Slot = "6")]
	public ComponentSystemBase DNLMHIEMAHE(World HCDDAGKOEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x77A6CA0", Offset = "0x77A5EA0", VA = "0x1877A6CA0", Slot = "7")]
	public void DAGDDEOLJHL(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77A6DC0", Offset = "0x77A5FC0", VA = "0x1877A6DC0", Slot = "8")]
	public void GGFKBGNJLMP(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77A7670", Offset = "0x77A6870", VA = "0x1877A7670", Slot = "9")]
	public void OKEJKKJIAMC(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x77A6D50", Offset = "0x77A5F50", VA = "0x1877A6D50", Slot = "10")]
	public void FKHGBIGBEOL(World HCDDAGKOEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77A6E70", Offset = "0x77A6070", VA = "0x1877A6E70", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> MJFACGMIGOG()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NOGMKJEKCAG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct GAIINMPACFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct FOGOKKLAKAD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FAKHOKKGACN : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GFCAFNBKIEB ELFALEIJLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7798460", Offset = "0x7797660", VA = "0x187798460", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x77983F0", Offset = "0x77975F0", VA = "0x1877983F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public FAKHOKKGACN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct MLIONBKKNNM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OMLFPKHBOMD CIPJDFILCHF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static MLIONBKKNNM AJAOLMPMCKD(OMLFPKHBOMD PBLKLOBKEHJ)
	{
		return default(MLIONBKKNNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GBDFCLPNBMA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OCMFLIKNIPB JGIGJBIFGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7798A30", Offset = "0x7797C30", VA = "0x187798A30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GBDFCLPNBMA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct ONBEPPJPBDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct BOGINMMACEP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OKPBHDAFLPP HGNKIDLCCGG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static BOGINMMACEP AJAOLMPMCKD(OKPBHDAFLPP PBLKLOBKEHJ)
	{
		return default(BOGINMMACEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct NOILKDICGPB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OMLFPKHBOMD CIPJDFILCHF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static NOILKDICGPB AJAOLMPMCKD(OMLFPKHBOMD PBLKLOBKEHJ)
	{
		return default(NOILKDICGPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LECIAHOHCHL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FLIGGIIDKOK OFNECHKEAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x77A3F80", Offset = "0x77A3180", VA = "0x1877A3F80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77A3F10", Offset = "0x77A3110", VA = "0x1877A3F10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LECIAHOHCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EAHOIMCAHBG : GHLLPPFMGDI, GFCAFNBKIEB, LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PGANNLEBPBC NPPOAAKEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC20FA0", Offset = "0xC201A0", VA = "0x180C20FA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(PGANNLEBPBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FLAPDCADLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAF8030", Offset = "0xAF7230", VA = "0x180AF8030", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float3 FLCOCAKBKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xF35840", Offset = "0xF34A40", VA = "0x180F35840", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7796D00", Offset = "0x7795F00", VA = "0x187796D00")]
	public EAHOIMCAHBG(UniformTRS BGKECKAHJOL, EMAAEODMJFK JNGEIJHHFEP, float CONBGIGHGMM, float3 PEIDLJCGCJL, EOGPNGFBHLD CPKOGGLEBFE, FAKFOCBMCDN PIHNCGOAMPK, PGANNLEBPBC KFKGNOABOBA, float3 BCKJOFIDPBM, bool MFBHKFDHBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7796CB0", Offset = "0x7795EB0", VA = "0x187796CB0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NGFABCIDAKI : GHLLPPFMGDI, FLIGGIIDKOK, LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<FACMCBMMKCI> GFFIHDGBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ANJLJPHGACH BNHLGDBCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly float ICFGJDMHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly int OJEJJGEEEOH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AKKMIIIBPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77A4EC0", Offset = "0x77A40C0", VA = "0x1877A4EC0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DCPGKGOMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x77A4EE0", Offset = "0x77A40E0", VA = "0x1877A4EE0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FMFLNPBMGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x77A4ED0", Offset = "0x77A40D0", VA = "0x1877A4ED0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AEPHLELMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xC58EB0", Offset = "0xC580B0", VA = "0x180C58EB0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float MBEBBDGPLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB97500", Offset = "0xB96700", VA = "0x180B97500", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CJIGAEKJMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xDF9340", Offset = "0xDF8540", VA = "0x180DF9340", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x77A4E10", Offset = "0x77A4010", VA = "0x1877A4E10")]
	public NGFABCIDAKI(UniformTRS BGKECKAHJOL, EMAAEODMJFK JNGEIJHHFEP, float CONBGIGHGMM, float3 PEIDLJCGCJL, EOGPNGFBHLD CPKOGGLEBFE, FAKFOCBMCDN PIHNCGOAMPK, ANJLJPHGACH BNHLGDBCCDH, float ICFGJDMHHOH, int OJEJJGEEEOH, NativeArray<FACMCBMMKCI> GFFIHDGBNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xF4EF50", Offset = "0xF4E150", VA = "0x180F4EF50", Slot = "33")]
	public NativeArray<FACMCBMMKCI> GetNativeCurvePoints()
	{
		return default(NativeArray<FACMCBMMKCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77A4D50", Offset = "0x77A3F50", VA = "0x1877A4D50", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GLLGBOHEGPF : KKOKPLPFNCC, GFCAFNBKIEB, LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<PMLONBCCMJA, PGANNLEBPBC> MFGJDNCAILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private PGANNLEBPBC KFKGNOABOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MFBHKFDHBBE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private PGANNLEBPBC HIDBBFCGODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x980830", Offset = "0x97FA30", VA = "0x180980830", Slot = "28")]
		get
		{
			return default(PGANNLEBPBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool GEJMNJBAALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xD2FFA0", Offset = "0xD2F1A0", VA = "0x180D2FFA0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float3 FLCOCAKBKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x779A200", Offset = "0x7799400", VA = "0x18779A200", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x779A1E0", Offset = "0x77993E0", VA = "0x18779A1E0")]
	public GLLGBOHEGPF(EOFNBBMGHCB MOEJABALFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7799B60", Offset = "0x7798D60", VA = "0x187799B60", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7799BB0", Offset = "0x7798DB0", VA = "0x187799BB0", Slot = "26")]
	public override void DJHAIOPCIPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EDCHLDFLNDO : CEHDHHNOPMK, OCMFLIKNIPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GameObject HDNBMIOIPFB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GameObject FOFJJMEPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x77971B0", Offset = "0x77963B0", VA = "0x1877971B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MOCOMOJHGBP FFFKHKBLIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7796EF0", Offset = "0x77960F0", VA = "0x187796EF0", Slot = "15")]
		get
		{
			return default(MOCOMOJHGBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public COMIHINGFAG IMKDJLCDLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7797390", Offset = "0x7796590", VA = "0x187797390", Slot = "16")]
		get
		{
			return default(COMIHINGFAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7797240", Offset = "0x7796440", VA = "0x187797240")]
	public EDCHLDFLNDO(EOFNBBMGHCB DEBNBMMFJPK, bool IMPKOPMHHKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7797020", Offset = "0x7796220", VA = "0x187797020")]
	public void INFAMDGEMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7796EF0", Offset = "0x77960F0", VA = "0x187796EF0")]
	protected MOCOMOJHGBP CMKHMOFPIMB()
	{
		return default(MOCOMOJHGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7796DA0", Offset = "0x7795FA0", VA = "0x187796DA0")]
	private static bool BGDNAEPAJMG(EOFNBBMGHCB OFMLIMMJLAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7796FF0", Offset = "0x77961F0", VA = "0x187796FF0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KPODPIEGKAF : KKOKPLPFNCC, FLIGGIIDKOK, LKGDJKBNHHG, IDisposable, PMNGINNALJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeList<FACMCBMMKCI> GFFIHDGBNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool LLGMKGFOPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool MLEOPBGHDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float ICFGJDMHHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OJEJJGEEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool JOEJEACPDKA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool HGLFAEOFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB05410", Offset = "0xB04610", VA = "0x180B05410", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool INOCEDHLPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7F0", Offset = "0x9AD9F0", VA = "0x1809AE7F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private float JLNJOHMCJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xEFE5E0", Offset = "0xEFD7E0", VA = "0x180EFE5E0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private int GPPOBMIJHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC20FA0", Offset = "0xC201A0", VA = "0x180C20FA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool OFHACNEMJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAF8030", Offset = "0xAF7230", VA = "0x180AF8030", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int JAEFENLHCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77A3EC0", Offset = "0x77A30C0", VA = "0x1877A3EC0", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int GOGFIKMPIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x77A3DD0", Offset = "0x77A2FD0", VA = "0x1877A3DD0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x77A3EE0", Offset = "0x77A30E0", VA = "0x1877A3EE0")]
	public KPODPIEGKAF(EOFNBBMGHCB MOEJABALFBA, [Optional] NativeList<FACMCBMMKCI> GFFIHDGBNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x77A3830", Offset = "0x77A2A30", VA = "0x1877A3830", Slot = "26")]
	public override void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x77A3740", Offset = "0x77A2940", VA = "0x1877A3740", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x77A3910", Offset = "0x77A2B10", VA = "0x1877A3910", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x77A3D70", Offset = "0x77A2F70", VA = "0x1877A3D70")]
	public void LJINPCOBLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x77A3B70", Offset = "0x77A2D70", VA = "0x1877A3B70", Slot = "34")]
	public NativeArray<FACMCBMMKCI> GetNativeCurvePoints()
	{
		return default(NativeArray<FACMCBMMKCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x77A35F0", Offset = "0x77A27F0", VA = "0x1877A35F0", Slot = "35")]
	private Vector3 CCGMCEPPOLG(int EFNCIOCDOKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x77A3D40", Offset = "0x77A2F40", VA = "0x1877A3D40", Slot = "36")]
	private Quaternion JICDNIKJNLF(int EFNCIOCDOKE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x77A3970", Offset = "0x77A2B70", VA = "0x1877A3970", Slot = "37")]
	private float ELHKCIHPNJI(int EFNCIOCDOKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77A3B00", Offset = "0x77A2D00", VA = "0x1877A3B00")]
	private NativeArray<Entity> FKMBDMBLMDE()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class HEEHFOHGLMI : KMHEFEAEGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x779F800", Offset = "0x779EA00", VA = "0x18779F800", Slot = "15")]
	protected override ComponentSystemBase LKHOGCOEFKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x779FC20", Offset = "0x779EE20", VA = "0x18779FC20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x779FC30", Offset = "0x779EE30", VA = "0x18779FC30")]
	public HEEHFOHGLMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[JAOIDFJKNNC]
public sealed class HJIDMEOCPIP : AOOMEIIKCHD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private EntityQuery JPMPDFEKEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private EntityQuery PBHKEFNEGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EntityQuery KKJAMLPEHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery HGILEPLPBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery HNANHFHNDHP;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77A03D0", Offset = "0x779F5D0", VA = "0x1877A03D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77A0730", Offset = "0x779F930", VA = "0x1877A0730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x779FFE0", Offset = "0x779F1E0", VA = "0x18779FFE0")]
	private void NABDIFGKOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77A02C0", Offset = "0x779F4C0", VA = "0x1877A02C0")]
	private void OFBDHBNMCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x779FD00", Offset = "0x779EF00", VA = "0x18779FD00")]
	private void LFEDFDEMDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x779FEE0", Offset = "0x779F0E0", VA = "0x18779FEE0")]
	private void MGCGCMEGEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77A01C0", Offset = "0x779F3C0", VA = "0x1877A01C0")]
	private void NHEGKAFOBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x779FC40", Offset = "0x779EE40", VA = "0x18779FC40")]
	private NativeList<Entity> DDFNDNCIEHB(NativeArray<Entity> DNOHLBIMBBG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77A0770", Offset = "0x779F970", VA = "0x1877A0770")]
	private NativeList<Entity> PNLHFFPFMKD(NativeArray<Entity> DNOHLBIMBBG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x779FCA0", Offset = "0x779EEA0", VA = "0x18779FCA0")]
	private void EDOMLBGBCMN(NativeArray<Entity> DNOHLBIMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public HJIDMEOCPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[JAOIDFJKNNC]
public sealed class JBJDCEMBNJO : AOOMEIIKCHD, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery GEKMMPHFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery ICJFLJKFPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EntityQuery AGGMBKLGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private HJOJPOMBOGB MEGCICPDCBD;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x77A15C0", Offset = "0x77A07C0", VA = "0x1877A15C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x77A14C0", Offset = "0x77A06C0", VA = "0x1877A14C0", Slot = "15")]
	public override void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x77A1790", Offset = "0x77A0990", VA = "0x1877A1790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77A0E40", Offset = "0x77A0040", VA = "0x1877A0E40")]
	private void DGPAAHEONAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77A17C0", Offset = "0x77A09C0", VA = "0x1877A17C0")]
	private void PJDGHFABINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x77A0A90", Offset = "0x779FC90", VA = "0x1877A0A90")]
	private void CFPIGMCGHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x77A1520", Offset = "0x77A0720", VA = "0x1877A1520")]
	private bool NKJGPGDGKMK(Entity JJMNGBLHAJC, [Out] OMLFPKHBOMD CIPJDFILCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77A08E0", Offset = "0x779FAE0", VA = "0x1877A08E0")]
	private bool BIBBCKBFDAM(Entity JJMNGBLHAJC, [Out] OMLFPKHBOMD CIPJDFILCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public JBJDCEMBNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[JAOIDFJKNNC]
public sealed class EDIJIAICFIA : AOOMEIIKCHD
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery CFBJIJGOMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private EntityQuery MLAAAAONIPN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x77977F0", Offset = "0x77969F0", VA = "0x1877977F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7797940", Offset = "0x7796B40", VA = "0x187797940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x77974F0", Offset = "0x77966F0", VA = "0x1877974F0")]
	private void DGPAAHEONAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7797960", Offset = "0x7796B60", VA = "0x187797960")]
	private void PJDGHFABINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public EDIJIAICFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NMAFMJPKLEP : AOOMEIIKCHD, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct EEBHPIONFBH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public EntityQueryInJob MCCCHAHBHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EntityQueryInJob ONNODCFMNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EntityQueryInJob CAKLIPNBGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob GACCGJCAIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ReadOnly]
		public EntityTypeHandle NFIOJCBOFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ReadOnly]
		public ComponentTypeHandle<NOILKDICGPB> PNNMMNBPEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NativeList<Entity> LOPFPILBHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeList<Entity> MGGPDEGDFLN;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7797CE0", Offset = "0x7796EE0", VA = "0x187797CE0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7797D60", Offset = "0x7796F60", VA = "0x187797D60")]
		private void NOOKDACKLOP(EntityQueryInJob DOPGKNOHOBG, NativeList<Entity> PNLLFHEICGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct BHMAEAIEPNG : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ReadOnly]
		public EntityTypeHandle NFIOJCBOFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ReadOnly]
		public ComponentTypeHandle<NOILKDICGPB> PNNMMNBPEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeList<Entity> PNLLFHEICGH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7793330", Offset = "0x7792530", VA = "0x187793330", Slot = "4")]
		public void Execute(ArchetypeChunk IMNJGNIDLOK, int EKMLGMOLDIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct BAPFHCPKFOA : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public EntityTypeHandle NFIOJCBOFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> DDDDCLNCAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ReadOnly]
		public ComponentTypeHandle<BOGINMMACEP> LEHDLELLPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public ComponentDataFromEntity<MLIONBKKNNM> DMBBALAADIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComponentTypeHandle<NOILKDICGPB> EJONBMGKDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeList<Entity> LHJOOOCMBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeList<BOGINMMACEP> MDGMMJLIELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<OMLFPKHBOMD> CBBPHLMGNAO;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7792BD0", Offset = "0x7791DD0", VA = "0x187792BD0", Slot = "4")]
		public void Execute(ArchetypeChunk IMNJGNIDLOK, int EKMLGMOLDIN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private EntityQuery MCCCHAHBHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery ONNODCFMNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery CAKLIPNBGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery GACCGJCAIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery APAEBAPCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery EJCDLBMMFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery CJIGHOMHCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HJOJPOMBOGB ICGBJFAHIMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x77A6320", Offset = "0x77A5520", VA = "0x1877A6320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x77A5E70", Offset = "0x77A5070", VA = "0x1877A5E70", Slot = "15")]
	public override void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x77A68A0", Offset = "0x77A5AA0", VA = "0x1877A68A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x77A5870", Offset = "0x77A4A70", VA = "0x1877A5870")]
	private void HLPEBAEKAGC(NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM, int BLLODJBEJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x77A5ED0", Offset = "0x77A50D0", VA = "0x1877A5ED0")]
	private void KMNMHMNDGFG(NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM, int AKKGJEHINJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x77A4EF0", Offset = "0x77A40F0", VA = "0x1877A4EF0")]
	private void BKPLINMGOBB(NativeParallelHashSet<OMLFPKHBOMD> ABCLAJPKDIM, int JHIKIFIJDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x77A54E0", Offset = "0x77A46E0", VA = "0x1877A54E0")]
	private void GFAIHGPPION(NativeParallelHashSet<OMLFPKHBOMD> AHMHIIAMPEC, int AKCIECJAEDO, int MFMMJCOMEBE, int AFADKHLJNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x77A5330", Offset = "0x77A4530", VA = "0x1877A5330")]
	private void CNBENPKJALE(Entity GPJEHEFGOMF, OKPBHDAFLPP NJFIEMAHGAM, OMLFPKHBOMD CIPJDFILCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public NMAFMJPKLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class PEFDHANPMCJ : AOOMEIIKCHD
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EntityQuery HJKOAJHJPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private EntityQuery MMPBAELGDIL;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x77AE100", Offset = "0x77AD300", VA = "0x1877AE100", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x77AE340", Offset = "0x77AD540", VA = "0x1877AE340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public PEFDHANPMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNKGLFFEDAC : AOOMEIIKCHD
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private struct OKKJLAAIABG : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private EntityQuery KAOHDDDNMDA;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x77A3280", Offset = "0x77A2480", VA = "0x1877A3280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x77A33C0", Offset = "0x77A25C0", VA = "0x1877A33C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public KNKGLFFEDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JAOIDFJKNNC]
internal class GLBDGLAMGAB : AOOMEIIKCHD
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class DEJPLKADIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public EntityQuery HFMCCOKPIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public EntityQuery BPNNBPABFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public EAOBEPMCIDE DDLPOPCKEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ComponentType OOAEFNIDJEE;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DEJPLKADIMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void EAOBEPMCIDE(NativeArray<OKPBHDAFLPP> PBLKLOBKEHJ, FDBJDLMKNEH CGJOMDOPKHL);

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private List<DEJPLKADIMM> IIMFMKDGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private DOAJILOHGAC LGIKKEKIOME;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7799250", Offset = "0x7798450", VA = "0x187799250", Slot = "15")]
	public override void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7799450", Offset = "0x7798650", VA = "0x187799450", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x77995E0", Offset = "0x77987E0", VA = "0x1877995E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x349D5D0", Offset = "0x349C7D0", VA = "0x18349D5D0")]
	private void FMCIANIIFDC<T>(EAOBEPMCIDE DDLPOPCKEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77992B0", Offset = "0x77984B0", VA = "0x1877992B0")]
	private static void NNNNIIOBAIN(NativeArray<OKPBHDAFLPP> OPEHJJPEJMB, FDBJDLMKNEH PMMMHLMLGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7798F10", Offset = "0x7798110", VA = "0x187798F10")]
	private static void CAHNJOIGOBD(NativeArray<OKPBHDAFLPP> OPEHJJPEJMB, FDBJDLMKNEH PMMMHLMLGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x77990B0", Offset = "0x77982B0", VA = "0x1877990B0")]
	private static void EPPLCBIJOCE(NativeArray<OKPBHDAFLPP> OPEHJJPEJMB, FDBJDLMKNEH PMMMHLMLGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public GLBDGLAMGAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[JAOIDFJKNNC]
public sealed class BDKKLGHCAHJ : AOOMEIIKCHD
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EntityQuery DOPGKNOHOBG;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7792F00", Offset = "0x7792100", VA = "0x187792F00", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct IGJNKAKDPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UniformTRS BGKECKAHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public StandardRenderableVisualData BBIOKBCKNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public PGANNLEBPBC KFKGNOABOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 BCKJOFIDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MFBHKFDHBBE;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HPJEIIJOBGC(Lifetime.LoadInstance)]
public struct HOBJBDMHOJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity ILIEDPLAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<Entity> LHOCHCKDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<Entity> FKKAAEPCAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<IGJNKAKDPKB> KLDCFCIMDFB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x77A0850", Offset = "0x779FA50", VA = "0x1877A0850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.OMRoom)]
[RegisterService(typeof(OOMPANJGGKH), new string[] { })]
internal class OOMPANJGGKH : ANAKBJKCMDF, DKPHGOHMHMA, ACFHKDFELAE, CBKDENAGIHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct OADOCFLIINA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly OOMPANJGGKH JNGEIJHHFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly bool OFPEDIALDEC;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x15EF900", Offset = "0x15EEB00", VA = "0x1815EF900")]
		public OADOCFLIINA(OOMPANJGGKH JNGEIJHHFEP, bool OFPEDIALDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77A82B0", Offset = "0x77A74B0", VA = "0x1877A82B0")]
		public Queue<GPALOAKGBFL>.Enumerator PACLDABBHPO()
		{
			return default(Queue<GPALOAKGBFL>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77A7F70", Offset = "0x77A7170", VA = "0x1877A7F70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[DependsOn]
	private NFIPPAIECID OIEFJGPFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[DependsOn]
	private CBLNDJBNILG FLJFDDOFMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeList<FACMCBMMKCI>> MCPIKOIEJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<(Entity, List<GameObject>)> AJDHLOCPAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeList<OKPBHDAFLPP> IPIALNMNNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KNPJAENEPMF<GPALOAKGBFL> FGLHKGFEONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private KNPJAENEPMF<HOBJBDMHOJF> OIMNPNFBEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private KNPJAENEPMF<CBJMDEIIBKK> MKPPFFAEKDJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x77AD650", Offset = "0x77AC850", VA = "0x1877AD650", Slot = "4")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x77AD440", Offset = "0x77AC640", VA = "0x1877AD440")]
	public void ELJONACBJME(NativeList<FACMCBMMKCI> FGCDOLGLPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x77AD850", Offset = "0x77ACA50", VA = "0x1877AD850")]
	public void KMLJEAAHJFO(Entity JNGEIJHHFEP, [In] HKOOMBBGJCN<GameObject> KLFHBGEJDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x77ADF10", Offset = "0x77AD110", VA = "0x1877ADF10")]
	public void ONIEGFFIOCN(NativeList<OKPBHDAFLPP> OPEHJJPEJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x77ADCE0", Offset = "0x77ACEE0", VA = "0x1877ADCE0")]
	public void OKEJKKJIAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x77ACF90", Offset = "0x77AC190", VA = "0x1877ACF90")]
	public void BKKDALNLDGD(IGEBAHMFCMN CKLPHBNMNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x77AD510", Offset = "0x77AC710", VA = "0x1877AD510")]
	public JobHandle IMHKNNEEKFF([In] GPALOAKGBFL DCEACFEGBDC, JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x77AD5B0", Offset = "0x77AC7B0", VA = "0x1877AD5B0")]
	public JobHandle IMHKNNEEKFF([In] HOBJBDMHOJF DCEACFEGBDC, JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x749BC30", Offset = "0x749AE30", VA = "0x18749BC30")]
	public OADOCFLIINA NCGICJPNPPN(bool OFPEDIALDEC)
	{
		return default(OADOCFLIINA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x77ADA70", Offset = "0x77ACC70", VA = "0x1877ADA70")]
	public LCHJGNHBHFK<HOBJBDMHOJF> MPLOJGKMNJP()
	{
		return default(LCHJGNHBHFK<HOBJBDMHOJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x77ADA20", Offset = "0x77ACC20", VA = "0x1877ADA20")]
	public LCHJGNHBHFK<CBJMDEIIBKK> MDKEEGBFDEO()
	{
		return default(LCHJGNHBHFK<CBJMDEIIBKK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x77ADAC0", Offset = "0x77ACCC0", VA = "0x1877ADAC0")]
	public void NLADMABHKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x77ADFA0", Offset = "0x77AD1A0", VA = "0x1877ADFA0", Slot = "5")]
	public void PPDMLGCOEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x77AD9B0", Offset = "0x77ACBB0", VA = "0x1877AD9B0", Slot = "6")]
	private void LAHBCOILANO(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1005EC0", Offset = "0x10050C0", VA = "0x181005EC0", Slot = "7")]
	private void HCHPEMCKIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public OOMPANJGGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HLGBNJOMNEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public UniformTRS BGKECKAHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public StandardRenderableVisualData BBIOKBCKNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public GOJEDHLHKHB BNHLGDBCCDH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[HPJEIIJOBGC(Lifetime.LoadInstance)]
public struct GPALOAKGBFL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity ILIEDPLAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeList<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NativeList<Entity> LHOCHCKDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeParallelHashSet<Entity> FKKAAEPCAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<AIKFLEGLMCF> KIEJJBPENBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<FACMCBMMKCI> FGCDOLGLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeList<HLGBNJOMNEN> EJFKECJLBJJ;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x779A2D0", Offset = "0x77994D0", VA = "0x18779A2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x779A2E0", Offset = "0x77994E0", VA = "0x18779A2E0")]
	public void GNPGDFFJFNC(bool OFPEDIALDEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(GEBGMKNAPON), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class GEBGMKNAPON : CKMNDLDGHIM, ACFHKDFELAE, CBKDENAGIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[DependsOn]
	private OOMPANJGGKH ACPGALPDDBO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7798AA0", Offset = "0x7797CA0", VA = "0x187798AA0", Slot = "4")]
	public void INAPGGJAMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7798AC0", Offset = "0x7797CC0", VA = "0x187798AC0", Slot = "5")]
	private void LAHBCOILANO(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xFE6320", Offset = "0xFE5520", VA = "0x180FE6320", Slot = "6")]
	private void HCHPEMCKIOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GEBGMKNAPON()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[AlwaysUpdateSystem]
	public class PostDeserializeBakeShapesSystem : AOOMEIIKCHD, ANAKBJKCMDF
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
			public NativeParallelHashMap<int, PGANNLEBPBC> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public NativeArray<IGJNKAKDPKB> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x779A3B0", Offset = "0x77995B0", VA = "0x18779A3B0", Slot = "4")]
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
			public NativeArray<FACMCBMMKCI> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public NativeArray<AIKFLEGLMCF> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public NativeArray<HLGBNJOMNEN> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x779A750", Offset = "0x7799950", VA = "0x18779A750", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7795FD0", Offset = "0x77951D0", VA = "0x187795FD0", Slot = "4")]
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
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0x77AE8B0", Offset = "0x77ADAB0", VA = "0x1877AE8B0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0x77AE8D0", Offset = "0x77ADAD0", VA = "0x1877AE8D0")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 FJMHBBMLDHO(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x77A4010", Offset = "0x77A3210", VA = "0x1877A4010", Slot = "5")]
				public float3 IOHDBKEKHJK(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x77A3FD0", Offset = "0x77A31D0", VA = "0x1877A3FD0", Slot = "4")]
				public float3 FJMHBBMLDHO(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x77A7C50", Offset = "0x77A6E50", VA = "0x1877A7C50", Slot = "4")]
				public float3 FJMHBBMLDHO(quaternion rotation)
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
			public NativeArray<AIKFLEGLMCF> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public NativeArray<FACMCBMMKCI> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x779B990", Offset = "0x779AB90", VA = "0x18779B990", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x779CFB0", Offset = "0x779C1B0", VA = "0x18779CFB0")]
			private void IBAGFHNBDEP(NativeList<PointSrcData> srcData, NativeList<FACMCBMMKCI> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x779B120", Offset = "0x779A320", VA = "0x18779B120")]
			public static Vector3 DEHKJHLJDKJ(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x779EC60", Offset = "0x779DE60", VA = "0x18779EC60")]
			public static quaternion PLELEFGBAJH(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x779E700", Offset = "0x779D900", VA = "0x18779E700")]
			private static quaternion MNMBHAMIADH(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x779DE90", Offset = "0x779D090", VA = "0x18779DE90")]
			private static float3 IHHHEGEKKBN(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x779E670", Offset = "0x779D870", VA = "0x18779E670")]
			private static quaternion LDOCLDLEJEB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x779E060", Offset = "0x779D260", VA = "0x18779E060")]
			private static FACMCBMMKCI IMAFCDOPCKK(int idx, NativeList<PointSrcData> srcData)
			{
				return default(FACMCBMMKCI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3B80E50", Offset = "0x3B80050", VA = "0x183B80E50")]
			private void HIICNCDHLME<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x779BFF0", Offset = "0x779B1F0", VA = "0x18779BFF0")]
			private void FBKFJCOCFIL(NativeList<PointSrcData> sourcePoints, NativeList<FACMCBMMKCI> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x779EAE0", Offset = "0x779DCE0", VA = "0x18779EAE0")]
			public static float PGHGAPGPFAB(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x779E480", Offset = "0x779D680", VA = "0x18779E480")]
			private static quaternion JAFEEOCPGIM(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x779E9C0", Offset = "0x779DBC0", VA = "0x18779E9C0")]
			private static FACMCBMMKCI OAPIIJPMHPF(PointSrcData point)
			{
				return default(FACMCBMMKCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x779E930", Offset = "0x779DB30", VA = "0x18779E930")]
			private static FACMCBMMKCI OAPIIJPMHPF(float3 pos, quaternion rot, float radius)
			{
				return default(FACMCBMMKCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x779ECE0", Offset = "0x779DEE0", VA = "0x18779ECE0")]
			private static bool PMCPGHOMCFJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x779AE70", Offset = "0x779A070", VA = "0x18779AE70")]
			private static float3 ADFOKEOAMPA(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x779CE00", Offset = "0x779C000", VA = "0x18779CE00")]
			public static float3 FGFGPCCDJIP(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x779E2D0", Offset = "0x779D4D0", VA = "0x18779E2D0")]
			public static float3 IOHDBKEKHJK(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x779B530", Offset = "0x779A730", VA = "0x18779B530")]
			private static quaternion ENDDMBGIFPP(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x779AF40", Offset = "0x779A140", VA = "0x18779AF40")]
			private static float ALPJELKNLLI(float3 from, float3 to)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeBakeShapesSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x77B0C30", Offset = "0x77AFE30", VA = "0x1877B0C30")]
			private void ABOBBJAMGEH(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x77B0D10", Offset = "0x77AFF10", VA = "0x1877B0D10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct TrimSplinePointExcess_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public NativeList<FACMCBMMKCI> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x77B22E0", Offset = "0x77B14E0", VA = "0x1877B22E0")]
			private void ABOBBJAMGEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x77B2340", Offset = "0x77B1540", VA = "0x1877B2340", Slot = "4")]
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
			public NativeList<FACMCBMMKCI> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x77B2280", Offset = "0x77B1480", VA = "0x1877B2280")]
			private void ABOBBJAMGEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x77B22D0", Offset = "0x77B14D0", VA = "0x1877B22D0", Slot = "4")]
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
			public NativeList<IGJNKAKDPKB> data;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x779AA90", Offset = "0x7799C90", VA = "0x18779AA90")]
			private void ABOBBJAMGEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x779AC50", Offset = "0x7799E50", VA = "0x18779AC50", Slot = "4")]
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
			public NativeList<AIKFLEGLMCF> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<HLGBNJOMNEN> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x779AC60", Offset = "0x7799E60", VA = "0x18779AC60")]
			private void ABOBBJAMGEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x779AE60", Offset = "0x779A060", VA = "0x18779AE60", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x77B1E50", Offset = "0x77B1050", VA = "0x1877B1E50")]
			private void ABOBBJAMGEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x77B2270", Offset = "0x77B1470", VA = "0x1877B2270", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private static readonly PBBCGFNIILA log;

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
		private EDCMKFOBCID replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NFIPPAIECID objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private OOMPANJGGKH bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KCMNLDIBGEM ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77B06D0", Offset = "0x77AF8D0", VA = "0x1877B06D0", Slot = "15")]
		public override void InitReferences(DBCOBCEEMIL services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x77B1770", Offset = "0x77B0970", VA = "0x1877B1770", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x77B1860", Offset = "0x77B0A60", VA = "0x1877B1860", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77B18C0", Offset = "0x77B0AC0", VA = "0x1877B18C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x77B10E0", Offset = "0x77B02E0", VA = "0x1877B10E0")]
		private JobHandle NMNIENCAAKH(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x77AF9D0", Offset = "0x77AEBD0", VA = "0x1877AF9D0")]
		private JobHandle GLMAKECLCHM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x77B0F20", Offset = "0x77B0120", VA = "0x1877B0F20")]
		private JobHandle ONLPFBHBOIJ(NativeArray<int> pointCount, NativeList<FACMCBMMKCI> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x77B0770", Offset = "0x77AF970", VA = "0x1877B0770")]
		private JobHandle OIFLAIGJOEJ(NativeList<FACMCBMMKCI> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x77AEF80", Offset = "0x77AE180", VA = "0x1877AEF80")]
		private JobHandle BKALDPHLLAJ(EntityQuery query, NativeList<AIKFLEGLMCF> splinePointRanges, NativeList<FACMCBMMKCI> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x77B0E00", Offset = "0x77B0000", VA = "0x1877B0E00")]
		private JobHandle NANFAHNMFHG(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77B0FC0", Offset = "0x77B01C0", VA = "0x1877B0FC0")]
		private JobHandle NMFKLPBPNPO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x77AF450", Offset = "0x77AE650", VA = "0x1877AF450")]
		private JobHandle CBJHCMEBBPF(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<IGJNKAKDPKB> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x77B0410", Offset = "0x77AF610", VA = "0x1877B0410")]
		private JobHandle IDFJOHCNCJO(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<AIKFLEGLMCF> splinePointRanges, [Out] NativeList<HLGBNJOMNEN> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77B0090", Offset = "0x77AF290", VA = "0x1877B0090")]
		private JobHandle IAKMPJGHAMM(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x77AE920", Offset = "0x77ADB20", VA = "0x1877AE920")]
		private JobHandle ALONDGMKJNI(EntityQuery query, NativeList<IGJNKAKDPKB> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77B0810", Offset = "0x77AFA10", VA = "0x1877B0810")]
		private static NativeParallelHashMap<int, PGANNLEBPBC> LOKDLAKHCBO()
		{
			return default(NativeParallelHashMap<int, PGANNLEBPBC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x77B1A30", Offset = "0x77B0C30", VA = "0x1877B1A30")]
		private JobHandle PJFMDGJHKPG(EntityQuery query, NativeList<AIKFLEGLMCF> splinePointRanges, NativeList<FACMCBMMKCI> splinePointData, NativeList<HLGBNJOMNEN> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77AF7E0", Offset = "0x77AE9E0", VA = "0x1877AF7E0")]
		private JobHandle DMLFIEFJPCO(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77B0F20", Offset = "0x77B0120", VA = "0x1877B0F20")]
		private JobHandle NGMAGEKBBAD(NativeArray<int> pointCount, NativeList<FACMCBMMKCI> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77B0770", Offset = "0x77AF970", VA = "0x1877B0770")]
		private JobHandle KBAKAELJOEO(NativeList<FACMCBMMKCI> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77AF6F0", Offset = "0x77AE8F0", VA = "0x1877AF6F0")]
		private JobHandle DDAJOGGAPFM(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<IGJNKAKDPKB> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77AF8C0", Offset = "0x77AEAC0", VA = "0x1877AF8C0")]
		private JobHandle DNFHNHCCHHH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<AIKFLEGLMCF> ranges, NativeList<HLGBNJOMNEN> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77AEE30", Offset = "0x77AE030", VA = "0x1877AEE30")]
		private JobHandle BEBOJMMBIGD(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x77B1420", Offset = "0x77B0620", VA = "0x1877B1420", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EOJIPIDGPJG : IJJBIAEOBIE, ANAKBJKCMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private OOMPANJGGKH ACPGALPDDBO;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7798240", Offset = "0x7797440", VA = "0x187798240", Slot = "14")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7798290", Offset = "0x7797490", VA = "0x187798290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC20", Offset = "0x27ECE20", VA = "0x1827EDC20")]
	public EOJIPIDGPJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class OOFOBFLHHDE : AOOMEIIKCHD, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct IHOAEFHPPFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private EntityManager HOPEOGNNILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NNGCBKGMNCP<T> JHAPDDACOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int KOOLKCPAFBB;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x47773C0", Offset = "0x47765C0", VA = "0x1847773C0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4777860", Offset = "0x4776A60", VA = "0x184777860")]
		public IHOAEFHPPFA(EntityManager HOPEOGNNILD, NNGCBKGMNCP<T> JHAPDDACOJP, NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x41B2060", Offset = "0x41B1260", VA = "0x1841B2060")]
		public IHOAEFHPPFA<T> PACLDABBHPO()
		{
			return default(IHOAEFHPPFA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4776E00", Offset = "0x4776000", VA = "0x184776E00")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly PBBCGFNIILA GHIBFKPNGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private CBLNDJBNILG FLJFDDOFMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private OOMPANJGGKH ACPGALPDDBO;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x77AA430", Offset = "0x77A9630", VA = "0x1877AA430", Slot = "15")]
	public override void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x77A8AF0", Offset = "0x77A7CF0", VA = "0x1877A8AF0")]
	public void FKHGBIGBEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x77AB1E0", Offset = "0x77AA3E0", VA = "0x1877AB1E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x77A8F10", Offset = "0x77A8110", VA = "0x1877A8F10")]
	private void IKDGNMGPBBC(CBJMDEIIBKK DCEACFEGBDC, Mesh[] CHFILKKILHC, NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x36656F0", Offset = "0x36648F0", VA = "0x1836656F0")]
	private IHOAEFHPPFA<T> KKDMMPKAILK<T>(NNGCBKGMNCP<T> JHAPDDACOJP, NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO) where T : struct
	{
		return default(IHOAEFHPPFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x77A8370", Offset = "0x77A7570", VA = "0x1877A8370")]
	private void DCHFENIAFLK(Transform JNGEIJHHFEP, NativeArray<NKDEELCKILC> JBGLEDHEBHK, HKOOMBBGJCN<GameObject> CDOADMHNFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x77AAC10", Offset = "0x77A9E10", VA = "0x1877AAC10")]
	private void NFEGDNDJJMI(Transform JNGEIJHHFEP, NativeArray<HHMCIOHPJHD> FHMNFNPKMGJ, HKOOMBBGJCN<GameObject> CDOADMHNFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x77A8700", Offset = "0x77A7900", VA = "0x1877A8700")]
	private void FBFJDNGLNAE(Transform JNGEIJHHFEP, NativeArray<EGEPLAIMNJG> FIMFHIFKKNM, HKOOMBBGJCN<GameObject> CDOADMHNFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x77A9FF0", Offset = "0x77A91F0", VA = "0x1877A9FF0")]
	private void IOGJPJGPMIP(Transform JNGEIJHHFEP, NativeArray<IOGGLGKJIHO> CHFILKKILHC, Mesh[] NGPADLOIMHE, HKOOMBBGJCN<GameObject> CDOADMHNFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x77AA570", Offset = "0x77A9770", VA = "0x1877AA570")]
	private static void KJAGJGCCIMF(NativeParallelHashSet<Entity> DNOHLBIMBBG, NativeParallelHashSet<Entity> AANCGPOHNHI, NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x77AA4B0", Offset = "0x77A96B0", VA = "0x1877AA4B0")]
	private static void JCBADOBGIBJ(NativeList<Entity> KBPAKCCMOCP, NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x77AC360", Offset = "0x77AB560", VA = "0x1877AC360")]
	private NativeParallelHashMap<Entity, MLIONBKKNNM> PHOBPAFOBCE(OOMPANJGGKH.OADOCFLIINA CAKIOPCGGMG, LCHJGNHBHFK<HOBJBDMHOJF> DOKJOKFFPEE, List<GameObject> CDOADMHNFHK)
	{
		return default(NativeParallelHashMap<Entity, MLIONBKKNNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x77AB0E0", Offset = "0x77AA2E0", VA = "0x1877AB0E0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OKAAOMCGLEA(Entity FEMAPLNAJEF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x77AA6C0", Offset = "0x77A98C0", VA = "0x1877AA6C0")]
	private void MHGBKMPPOCE(NativeList<Entity> AFPCAIENOIK, NativeList<Entity> LCGIDEJAJAN, NativeParallelHashMap<Entity, MLIONBKKNNM> LGHCAGBMBOA, NativeList<AIKFLEGLMCF> IAOMBCHEDLE, NativeList<FACMCBMMKCI> DKKNOFEFGPH, NativeList<HLGBNJOMNEN> MCPIKOIEJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x77A8B20", Offset = "0x77A7D20", VA = "0x1877A8B20")]
	private void GFBHLKNGEAN(NativeList<Entity> DNOHLBIMBBG, NativeList<Entity> LHOCHCKDEAK, NativeParallelHashMap<Entity, MLIONBKKNNM> LGHCAGBMBOA, NativeList<IGJNKAKDPKB> KLDCFCIMDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7797CD0", Offset = "0x7796ED0", VA = "0x187797CD0")]
	public OOFOBFLHHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class EFLGECHDNOJ : NKMHLOAHFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly UniformTRS BGKECKAHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly EMAAEODMJFK JNGEIJHHFEP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private GameObject OMFNEBFDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public UniformTRS MAGNLICGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7798110", Offset = "0x7797310", VA = "0x187798110", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Vector3 MBOCJCPLPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7797F30", Offset = "0x7797130", VA = "0x187797F30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Matrix4x4 MJLBHPJLJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7797E90", Offset = "0x7797090", VA = "0x187797E90", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Vector3 OKCIKOKDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7798070", Offset = "0x7797270", VA = "0x187798070", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7797F80", Offset = "0x7797180", VA = "0x187797F80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Quaternion IDJOPLABMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7797FD0", Offset = "0x77971D0", VA = "0x187797FD0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x77980C0", Offset = "0x77972C0", VA = "0x1877980C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Vector3 EGIEGDJMFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7797EE0", Offset = "0x77970E0", VA = "0x187797EE0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 MKCLOJDEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7797E40", Offset = "0x7797040", VA = "0x187797E40", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Vector3 ADBBGFICBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7798020", Offset = "0x7797220", VA = "0x187798020", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77981F0", Offset = "0x77973F0", VA = "0x1877981F0")]
	public EFLGECHDNOJ(UniformTRS BGKECKAHJOL, EMAAEODMJFK JNGEIJHHFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class GHLLPPFMGDI : EFLGECHDNOJ, LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly float CONBGIGHGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly float3 PEIDLJCGCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly EOGPNGFBHLD CPKOGGLEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly FAKFOCBMCDN PIHNCGOAMPK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private MOCOMOJHGBP IJJDGLPHKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7798D10", Offset = "0x7797F10", VA = "0x187798D10", Slot = "17")]
		get
		{
			return default(MOCOMOJHGBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private UniformTRS POFPKNNLKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7798D60", Offset = "0x7797F60", VA = "0x187798D60", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private float ILLPHFCHBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAE43C0", Offset = "0xAE35C0", VA = "0x180AE43C0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private Vector3 OIEAKHPHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7798E40", Offset = "0x7798040", VA = "0x187798E40", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private EOGPNGFBHLD EIBNPMJMHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD2F2D0", Offset = "0xD2E4D0", VA = "0x180D2F2D0", Slot = "21")]
		get
		{
			return default(EOGPNGFBHLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private FAKFOCBMCDN FEPNNMECCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x11E6490", Offset = "0x11E5690", VA = "0x1811E6490", Slot = "22")]
		get
		{
			return default(FAKFOCBMCDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool LMAEBDIAEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PEIMBAMBPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7798E90", Offset = "0x7798090", VA = "0x187798E90")]
	protected GHLLPPFMGDI(UniformTRS BGKECKAHJOL, EMAAEODMJFK JNGEIJHHFEP, float CONBGIGHGMM, float3 PEIDLJCGCJL, EOGPNGFBHLD CPKOGGLEBFE, FAKFOCBMCDN PIHNCGOAMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class CEHDHHNOPMK : NKMHLOAHFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly EOFNBBMGHCB BNMNHJKEFGM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	protected EMAAEODMJFK LLFABGIMMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xFDFDD0", Offset = "0xFDEFD0", VA = "0x180FDFDD0")]
		get
		{
			return default(EMAAEODMJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	protected Entity EAFAIKPPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7795300", Offset = "0x7794500", VA = "0x187795300")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	protected NFIPPAIECID MHGAHKONKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7795900", Offset = "0x7794B00", VA = "0x187795900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected DGNODCBEMMF HBBAEGELGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x77956C0", Offset = "0x77948C0", VA = "0x1877956C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected OOJGFGPONHL FHKJPICOIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7795F40", Offset = "0x7795140", VA = "0x187795F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GameObject OMFNEBFDKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7795350", Offset = "0x7794550", VA = "0x187795350", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public UniformTRS MAGNLICGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x100F7F0", Offset = "0x100E9F0", VA = "0x18100F7F0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private Vector3 MBOCJCPLPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7795810", Offset = "0x7794A10", VA = "0x187795810", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private Matrix4x4 MJLBHPJLJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7795540", Offset = "0x7794740", VA = "0x187795540", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private Vector3 OKCIKOKDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7795D00", Offset = "0x7794F00", VA = "0x187795D00", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7795910", Offset = "0x7794B10", VA = "0x187795910", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Quaternion IDJOPLABMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7795A20", Offset = "0x7794C20", VA = "0x187795A20", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7795E30", Offset = "0x7795030", VA = "0x187795E30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector3 EGIEGDJMFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7795720", Offset = "0x7794920", VA = "0x187795720", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 MKCLOJDEGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7795380", Offset = "0x7794580", VA = "0x187795380", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector3 ADBBGFICBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7795B40", Offset = "0x7794D40", VA = "0x187795B40", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0xCF3180", Offset = "0xCF2380", VA = "0x180CF3180")]
	protected CEHDHHNOPMK(EOFNBBMGHCB MOEJABALFBA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7795320", Offset = "0x7794520", VA = "0x187795320")]
	public static MOCOMOJHGBP AJAOLMPMCKD(CEHDHHNOPMK FDDEDLKEPIJ)
	{
		return default(MOCOMOJHGBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JJMNMMJFDMH
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x77A2EF0", Offset = "0x77A20F0", VA = "0x1877A2EF0")]
	public static void IHEBBOPIPIO(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HBOPFLJOLJE
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x779EE50", Offset = "0x779E050", VA = "0x18779EE50")]
	public static void EHFNDIFHFAB(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD, IGEBAHMFCMN EBINEHAPHDK, NFIPPAIECID BOCHMICIIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x779F250", Offset = "0x779E450", VA = "0x18779F250")]
	public static void OGALNAECDFM(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD, IGEBAHMFCMN EBINEHAPHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x779F560", Offset = "0x779E760", VA = "0x18779F560")]
	public static NativeList<Entity> PNLHFFPFMKD(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x779EE10", Offset = "0x779E010", VA = "0x18779EE10")]
	public static NativeList<Entity> DDFNDNCIEHB(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x779F5A0", Offset = "0x779E7A0", VA = "0x18779F5A0")]
	private static NativeList<Entity> PNLHFFPFMKD(NativeArray<Entity> DNOHLBIMBBG, EntityManager HOPEOGNNILD, bool CGCIDJIFEDD)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class KKOKPLPFNCC : CEHDHHNOPMK, LKGDJKBNHHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float CONBGIGHGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 PEIDLJCGCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private EOGPNGFBHLD CPKOGGLEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FAKFOCBMCDN PIHNCGOAMPK;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	protected EntityManager HNLDMAKDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x77B3570", Offset = "0x77B2770", VA = "0x1877B3570")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected LDFBPFEFEGF HPHKONGLMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x77B3630", Offset = "0x77B2830", VA = "0x1877B3630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected ShapeConfigData KNJGBFAAJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x77B32F0", Offset = "0x77B24F0", VA = "0x1877B32F0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private MOCOMOJHGBP IJJDGLPHKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7795320", Offset = "0x7794520", VA = "0x187795320", Slot = "17")]
		get
		{
			return default(MOCOMOJHGBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float ILLPHFCHBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8360", Offset = "0xDE7560", VA = "0x180DE8360", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Vector3 OIEAKHPHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1434140", Offset = "0x1433340", VA = "0x181434140", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private EOGPNGFBHLD EIBNPMJMHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080", Slot = "21")]
		get
		{
			return default(EOGPNGFBHLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private FAKFOCBMCDN FEPNNMECCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB73CD0", Offset = "0xB72ED0", VA = "0x180B73CD0", Slot = "22")]
		get
		{
			return default(FAKFOCBMCDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private UniformTRS POFPKNNLKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x77B3600", Offset = "0x77B2800", VA = "0x1877B3600", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PEIMBAMBPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private bool LMAEBDIAEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x77B3690", Offset = "0x77B2890", VA = "0x1877B3690")]
	protected KKOKPLPFNCC(EOFNBBMGHCB MOEJABALFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x77B33E0", Offset = "0x77B25E0", VA = "0x1877B33E0", Slot = "26")]
	public virtual void DJHAIOPCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class AOOMEIIKCHD : IJJBIAEOBIE, ANAKBJKCMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected NFIPPAIECID BOCHMICIIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private OEMELGDKBOH OCNNBPCACIL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	protected IGEBAHMFCMN OLFPNNJBBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x77B2ED0", Offset = "0x77B20D0", VA = "0x1877B2ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	protected FDBJDLMKNEH EGCJADFNLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x77B2E80", Offset = "0x77B2080", VA = "0x1877B2E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	protected bool ENKJOMMCLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x77B2DC0", Offset = "0x77B1FC0", VA = "0x1877B2DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x77B2F20", Offset = "0x77B2120", VA = "0x1877B2F20", Slot = "15")]
	public virtual void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC20", Offset = "0x27ECE20", VA = "0x1827EDC20")]
	protected AOOMEIIKCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DJNDHNPFIDF
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x77B2F90", Offset = "0x77B2190", VA = "0x1877B2F90")]
	public static void BEGAHJEIMNM(NativeArray<Entity> AFPCAIENOIK, EntityManager HOPEOGNNILD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3952681008
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x77B3890", Offset = "0x77B2A90", VA = "0x1877B3890")]
	public static void LAKKIDAJBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x77B3880", Offset = "0x77B2A80", VA = "0x1877B3880")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class ELCODDCLMEA : ContainerPropertyBag<FAKHOKKGACN>
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x77B31D0", Offset = "0x77B23D0", VA = "0x1877B31D0")]
	public ELCODDCLMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class JHIKMLKEFIO : ContainerPropertyBag<GBDFCLPNBMA>
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x77B3290", Offset = "0x77B2490", VA = "0x1877B3290")]
	public JHIKMLKEFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class GPFGNPDBENP : ContainerPropertyBag<LECIAHOHCHL>
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x77B3230", Offset = "0x77B2430", VA = "0x1877B3230")]
	public GPFGNPDBENP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x77B36C0", Offset = "0x77B28C0", VA = "0x1877B36C0")]
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
