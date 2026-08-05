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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x866CD90", Offset = "0x866B390", VA = "0x18866CD90", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8623C50", Offset = "0x8622250", VA = "0x188623C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x867B320", Offset = "0x8679920", VA = "0x18867B320")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x867B8B0", Offset = "0x8679EB0", VA = "0x18867B8B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x867B910", Offset = "0x8679F10", VA = "0x18867B910")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IMGJHCBMCEC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8667F70", Offset = "0x8666570", VA = "0x188667F70")]
	public static Quaternion BLDMMEFJDMB([In] this HACCFGPOJHK PFMJHJMELOD, [In] Vector3 FANJPCNJGDA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OFBCGECDBPF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8673730", Offset = "0x8671D30", VA = "0x188673730")]
	public static bool EDIHBCHBPIM(this HFLBAJMNINP NLAOFGKAGCG, DFBCNJDDJPE KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x86735E0", Offset = "0x8671BE0", VA = "0x1886735E0")]
	public static bool DIBFDEDLBKJ(this HFLBAJMNINP NLAOFGKAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86739B0", Offset = "0x8671FB0", VA = "0x1886739B0")]
	public static bool FALDGCLACGA(this HFLBAJMNINP NLAOFGKAGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8673770", Offset = "0x8671D70", VA = "0x188673770")]
	public static void EDJAIHCJFEH(this HFLBAJMNINP NLAOFGKAGCG, Vector3 DLKDNFLHILK, Quaternion KCNOHEFEOGA, float OFHHJJPMNHK, bool DPJEPBOGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8673C80", Offset = "0x8672280", VA = "0x188673C80")]
	public static void HNEBEACFJJG(this HFLBAJMNINP NLAOFGKAGCG, Vector3 DLKDNFLHILK, Quaternion KCNOHEFEOGA, float OFHHJJPMNHK, int JHGGACKLCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8673610", Offset = "0x8671C10", VA = "0x188673610")]
	public static void DMCABENPKND(this HFLBAJMNINP NLAOFGKAGCG, int JHGGACKLCAJ, Vector3 DLKDNFLHILK, Quaternion KCNOHEFEOGA, float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8674620", Offset = "0x8672C20", VA = "0x188674620")]
	public static void LNHIFHDJJAM(this HFLBAJMNINP NLAOFGKAGCG, Vector3 NPLCLJLCGMN, Quaternion JGJKPJHDLJN, float OFHHJJPMNHK, bool DPJEPBOGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8674A50", Offset = "0x8673050", VA = "0x188674A50")]
	private static void PHDLHFGKKEE(this HFLBAJMNINP NLAOFGKAGCG, Vector3 AANGPKCDGHO, Quaternion NEOIPHFFLHF, float OFHHJJPMNHK, bool DPJEPBOGCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8674860", Offset = "0x8672E60", VA = "0x188674860")]
	private static void MPHABKHJCIE(this HFLBAJMNINP NLAOFGKAGCG, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, float GDDPPPNBODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8674670", Offset = "0x8672C70", VA = "0x188674670")]
	private static void MFMBFIABLAH(this HFLBAJMNINP NLAOFGKAGCG, int LEPAEEGOBDO, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, float GDDPPPNBODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8674A20", Offset = "0x8673020", VA = "0x188674A20")]
	private static bool PGPHINEGHMM(this HFLBAJMNINP NLAOFGKAGCG, int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86739E0", Offset = "0x8671FE0", VA = "0x1886739E0")]
	private static void FBFCFFEAHDN(this HFLBAJMNINP NLAOFGKAGCG, int LEPAEEGOBDO, Vector3 AEDFHMKGLON, Quaternion IOCPNAEAJJE, float GDDPPPNBODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8673F10", Offset = "0x8672510", VA = "0x188673F10")]
	public static Vector3 KDAIMKIBOJJ(this HFLBAJMNINP NLAOFGKAGCG, int LEPAEEGOBDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86738A0", Offset = "0x8671EA0", VA = "0x1886738A0")]
	public static Quaternion EFMBPFAPJAK(this HFLBAJMNINP NLAOFGKAGCG, int LEPAEEGOBDO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8674400", Offset = "0x8672A00", VA = "0x188674400")]
	public static Vector3 LMJIEJNGNMH(DFBCNJDDJPE OAKCIAMNOIJ, Vector3 AANGPKCDGHO, Vector3? NGKHHNMBBKF, Vector3 PCNNNFAHELF)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JGOEBAEAPFB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGKHLPNBOAN(EntityQuery FMMNAILFLHJ, EntityManager JMBADOBJEBH, OKDKNCHKIHF AEAKONLNGGP, LKMDPNOBCID FHOHBJNPOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface DJFJDIEIANA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType CHJJLICPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMLJMIHBIHI(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCLAFKJPPAE(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIECEEFLOCE(KPOKAGBLPPC PHMACIMNIMG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class NCKLBECFGDD : JGOEBAEAPFB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86728D0", Offset = "0x8670ED0", VA = "0x1886728D0", Slot = "4")]
	public void EGKHLPNBOAN(EntityQuery FMMNAILFLHJ, EntityManager JMBADOBJEBH, OKDKNCHKIHF AEAKONLNGGP, LKMDPNOBCID FHOHBJNPOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NCKLBECFGDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class OEHCPKEAEAM : JGOEBAEAPFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BFKHDCBEHIE KCBMGJBFEDC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
	public OEHCPKEAEAM(BFKHDCBEHIE KCBMGJBFEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8673490", Offset = "0x8671A90", VA = "0x188673490", Slot = "4")]
	public void EGKHLPNBOAN(EntityQuery FMMNAILFLHJ, EntityManager JMBADOBJEBH, OKDKNCHKIHF AEAKONLNGGP, LKMDPNOBCID FHOHBJNPOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class BPNOELBLJCF : JGOEBAEAPFB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x865C000", Offset = "0x865A600", VA = "0x18865C000", Slot = "4")]
	public void EGKHLPNBOAN(EntityQuery FMMNAILFLHJ, EntityManager JMBADOBJEBH, OKDKNCHKIHF AEAKONLNGGP, LKMDPNOBCID FHOHBJNPOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BPNOELBLJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KJMJEDOKIEA : DJFJDIEIANA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType CHJJLICPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x866BC40", Offset = "0x866A240", VA = "0x18866BC40", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x866B6F0", Offset = "0x8669CF0", VA = "0x18866B6F0", Slot = "5")]
	public void AMLJMIHBIHI(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x866B970", Offset = "0x8669F70", VA = "0x18866B970", Slot = "6")]
	public void FCLAFKJPPAE(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x866BBF0", Offset = "0x866A1F0", VA = "0x18866BBF0", Slot = "7")]
	public void MIECEEFLOCE(KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KJMJEDOKIEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NILGMHBMJFC : DJFJDIEIANA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType CHJJLICPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8673130", Offset = "0x8671730", VA = "0x188673130", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8672BE0", Offset = "0x86711E0", VA = "0x188672BE0", Slot = "5")]
	public void AMLJMIHBIHI(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8672E60", Offset = "0x8671460", VA = "0x188672E60", Slot = "6")]
	public void FCLAFKJPPAE(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86730E0", Offset = "0x86716E0", VA = "0x1886730E0", Slot = "7")]
	public void MIECEEFLOCE(KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NILGMHBMJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OGHOOJHAEIC : DJFJDIEIANA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType CHJJLICPIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8675900", Offset = "0x8673F00", VA = "0x188675900", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86753B0", Offset = "0x86739B0", VA = "0x1886753B0", Slot = "5")]
	public void AMLJMIHBIHI(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8675630", Offset = "0x8673C30", VA = "0x188675630", Slot = "6")]
	public void FCLAFKJPPAE(EntityQuery FMMNAILFLHJ, KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86758B0", Offset = "0x8673EB0", VA = "0x1886758B0", Slot = "7")]
	public void MIECEEFLOCE(KPOKAGBLPPC PHMACIMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public OGHOOJHAEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EICNKEGCBOM : EJNDCHEOADB, DPFKFJLGBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private OKDKNCHKIHF AEAKONLNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MDNJPDDHNCC FAOBPBCHDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private LKMDPNOBCID FHOHBJNPOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JGOEBAEAPFB adapter)> NJMDPPLAFGK;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x865C580", Offset = "0x865AB80", VA = "0x18865C580", Slot = "15")]
	public virtual void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x865C610", Offset = "0x865AC10", VA = "0x18865C610", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x865C420", Offset = "0x865AA20", VA = "0x18865C420")]
	private void DIMAEONOHGI(EntityQueryDesc CFMGEHFDBOG, JGOEBAEAPFB NGOAHLFCIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x865C840", Offset = "0x865AE40", VA = "0x18865C840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
	public EICNKEGCBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class GGMIOCPELEF : EJNDCHEOADB, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class OEDDPOHJDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery HMCEIGGNAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery KLIDGDFIAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery LDOEDCBJCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery GPIPFLCDFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery DMADHFBADPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery GBLLMPMHHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery JADEBFMJLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DJFJDIEIANA ICCOPDINFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType HGHCLOEKDGP;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public OEDDPOHJDIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OKDKNCHKIHF AEAKONLNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LKMDPNOBCID FHOHBJNPOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MDNJPDDHNCC FAOBPBCHDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<OEDDPOHJDIC> NJMDPPLAFGK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x865F680", Offset = "0x865DC80", VA = "0x18865F680", Slot = "14")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x865F710", Offset = "0x865DD10", VA = "0x18865F710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x865F890", Offset = "0x865DE90", VA = "0x18865F890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x865F230", Offset = "0x865D830", VA = "0x18865F230")]
	private void EIONDKJBKAM(OEDDPOHJDIC HGCNACBEHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x865EB00", Offset = "0x865D100", VA = "0x18865EB00")]
	private void DIMAEONOHGI(DJFJDIEIANA ICCOPDINFDG, ComponentType JIKPGLDJCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
	public GGMIOCPELEF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct FNALMOPODMG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct MPOENBMMEKE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct CGPGJPDOFKC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(LKMDPNOBCID), new string[] { })]
public class FPGIDLMDCAG : LKMDPNOBCID
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HPNEHHPMAMF NCFDIGAMAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HPNEHHPMAMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FPGIDLMDCAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(BLACCFEAHOH), new string[] { })]
public class FJNFPFOBMEA : BLACCFEAHOH, BKEPMNNKLHF, BEEMKDJGJGG, HJJHIIDNFCE, LKJPKMELKMK, FCOEENGBKBM, CEJIANFMEIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private PNCGDOMLIHN JJBMFGJCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private OKDKNCHKIHF AEAKONLNGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private OBECOIDGDPJ CGAAKJBHOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityQuery JDFNCAFIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EntityQuery KGDOMEEFAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool LEDNMMLOJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Entity KJMHLCJBOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MOELEHFPCPE MGGDBNENLHK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private EntityManager HNJPJAEOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x865CF90", Offset = "0x865B590", VA = "0x18865CF90")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DHFLGPJKMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x865CA30", Offset = "0x865B030", VA = "0x18865CA30", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NDCGHJNMKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x865D160", Offset = "0x865B760", VA = "0x18865D160", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x865CEB0", Offset = "0x865B4B0", VA = "0x18865CEB0", Slot = "4")]
	public bool EHNGKFKGOHL(JPDMABGMGFC DLICMGKJENE, DJHKGJKFELM FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x865CBF0", Offset = "0x865B1F0", VA = "0x18865CBF0", Slot = "5")]
	public MOELEHFPCPE DIBCICMDGPB()
	{
		return default(MOELEHFPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x865CFE0", Offset = "0x865B5E0", VA = "0x18865CFE0", Slot = "8")]
	public void InitExternal(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x865D180", Offset = "0x865B780", VA = "0x18865D180", Slot = "10")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x865CAE0", Offset = "0x865B0E0", VA = "0x18865CAE0", Slot = "9")]
	public void BMODMMCKAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x865CA50", Offset = "0x865B050", VA = "0x18865CA50", Slot = "11")]
	private void BFPDDFBJGNA(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1347950", Offset = "0x1345F50", VA = "0x181347950", Slot = "12")]
	private void KMJKAGKKLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FJNFPFOBMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(BMLBEFCPPAN), new string[] { })]
public class MJDCENPFLFK : BMLBEFCPPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x866DAC0", Offset = "0x866C0C0", VA = "0x18866DAC0", Slot = "4")]
	public void PILEAPGEGPM(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x866DBA0", Offset = "0x866C1A0", VA = "0x18866DBA0", Slot = "5")]
	public void PPLLAGBPKJL(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x866DA00", Offset = "0x866C000", VA = "0x18866DA00", Slot = "6")]
	public ComponentSystemBase MKCOFEFMODM(World JJBMFGJCFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x866DB40", Offset = "0x866C140", VA = "0x18866DB40", Slot = "7")]
	public void PLAFPOPGHFP(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x866D940", Offset = "0x866BF40", VA = "0x18866D940", Slot = "8")]
	public void DFBLAKGEFAD(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x866D9A0", Offset = "0x866BFA0", VA = "0x18866D9A0", Slot = "9")]
	public void JNLFCKLOBMI(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x866DA50", Offset = "0x866C050", VA = "0x18866DA50", Slot = "10")]
	public void OBDHBBDIMLJ(World JJBMFGJCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x866D110", Offset = "0x866B710", VA = "0x18866D110", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> BGPACMDALIH()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MJDCENPFLFK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct BCJOGHLLONN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct IKIAAGKFFCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MOIGOLALALL : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KINPHOMJCLM OKPNMAPDCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x866DC60", Offset = "0x866C260", VA = "0x18866DC60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x866DBF0", Offset = "0x866C1F0", VA = "0x18866DBF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MOIGOLALALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct AGKHFLBFNGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MOELEHFPCPE IFBBKCCHICI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static AGKHFLBFNGN HPNBGLLBBBG(MOELEHFPCPE IINGFCBPPPE)
	{
		return default(AGKHFLBFNGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NIELMNDHPEL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BGNDGMGKLOG FHOAMCDCOLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8672B70", Offset = "0x8671170", VA = "0x188672B70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NIELMNDHPEL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct KHIPLCMHBCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct NIIBECIELFL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public IFOKEJDEOGF CCHNCBFLFJD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static NIIBECIELFL HPNBGLLBBBG(IFOKEJDEOGF IINGFCBPPPE)
	{
		return default(NIIBECIELFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct AODCINLAFKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MOELEHFPCPE IFBBKCCHICI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static AODCINLAFKI HPNBGLLBBBG(MOELEHFPCPE IINGFCBPPPE)
	{
		return default(AODCINLAFKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EFKJDDPBKGJ : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FOCDFGPPKDG LCIACDFKPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x865C3D0", Offset = "0x865A9D0", VA = "0x18865C3D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x865C360", Offset = "0x865A960", VA = "0x18865C360", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public EFKJDDPBKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JBIBEKNMKKG : BBMBDGLGCOB, KINPHOMJCLM, GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DAKFOMKEJOH LFEMELPPIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(DAKFOMKEJOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DKBOGHJDABA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD664C0", Offset = "0xD64AC0", VA = "0x180D664C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float3 LILJOILJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1287640", Offset = "0x1285C40", VA = "0x181287640", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86680A0", Offset = "0x86666A0", VA = "0x1886680A0")]
	public JBIBEKNMKKG(UniformTRS BKBPHMFHMFK, IKNCJJMPFDD IGDHFGFJBMG, float BDGPOIHFPOM, float3 LJBBKCNKMPI, JHJALLMJIFB AMCEBNCMBLC, CKIILNPNIGK HJLKDFMPACF, DAKFOMKEJOH BPBDHNPBNNC, float3 HPJEAHFEGHF, bool GBDIJAGLDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8668050", Offset = "0x8666650", VA = "0x188668050", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JNNDCFKPMIH : BBMBDGLGCOB, FOCDFGPPKDG, GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<ONPFMKLHPJO> OLCLKKFNDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly EDHEHLCEEFH MHCCEBNBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly float BDJKCOLAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly int FFOEEIHNLHF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IJLHGOCOMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x866AA60", Offset = "0x8669060", VA = "0x18866AA60", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool KBLBFPOEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x866AA80", Offset = "0x8669080", VA = "0x18866AA80", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KDGEOLNDMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x866AA70", Offset = "0x8669070", VA = "0x18866AA70", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int AGLBEGDADAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAF9970", Offset = "0xAF7F70", VA = "0x180AF9970", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float FMHEGOGCEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xE14FE0", Offset = "0xE135E0", VA = "0x180E14FE0", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AOIAILACBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x10B8870", Offset = "0x10B6E70", VA = "0x1810B8870", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x866A9B0", Offset = "0x8668FB0", VA = "0x18866A9B0")]
	public JNNDCFKPMIH(UniformTRS BKBPHMFHMFK, IKNCJJMPFDD IGDHFGFJBMG, float BDGPOIHFPOM, float3 LJBBKCNKMPI, JHJALLMJIFB AMCEBNCMBLC, CKIILNPNIGK HJLKDFMPACF, EDHEHLCEEFH MHCCEBNBPPI, float BDJKCOLAJKJ, int FFOEEIHNLHF, NativeArray<ONPFMKLHPJO> OLCLKKFNDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x129FD30", Offset = "0x129E330", VA = "0x18129FD30", Slot = "33")]
	public NativeArray<ONPFMKLHPJO> GetNativeCurvePoints()
	{
		return default(NativeArray<ONPFMKLHPJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x866A8F0", Offset = "0x8668EF0", VA = "0x18866A8F0", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IAKPDNKFLDA : OPKCMEIJIBO, KINPHOMJCLM, GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly Dictionary<FNNLELJCGID, DAKFOMKEJOH> NCDNPNCBAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private DAKFOMKEJOH BPBDHNPBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool GBDIJAGLDFC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private DAKFOMKEJOH IKHMOAHKAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880", Slot = "28")]
		get
		{
			return default(DAKFOMKEJOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool IFHMKJOEJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xFC0810", Offset = "0xFBEE10", VA = "0x180FC0810", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 LILJOILJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8666160", Offset = "0x8664760", VA = "0x188666160", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8666140", Offset = "0x8664740", VA = "0x188666140")]
	public IAKPDNKFLDA(JPDMABGMGFC EKIEPLMIJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8665AB0", Offset = "0x86640B0", VA = "0x188665AB0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8665B00", Offset = "0x8664100", VA = "0x188665B00", Slot = "26")]
	public override void FLHPFKIPOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GAHEIDJLPND : KOEFJKMLPFP, BGNDGMGKLOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GameObject HCALOMDMFKF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GameObject OKIANKCJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x865E510", Offset = "0x865CB10", VA = "0x18865E510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HGOECGDMDII ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x865E3E0", Offset = "0x865C9E0", VA = "0x18865E3E0", Slot = "15")]
		get
		{
			return default(HGOECGDMDII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PBMIECBIOFI ILAFKJJHADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x865E840", Offset = "0x865CE40", VA = "0x18865E840", Slot = "16")]
		get
		{
			return default(PBMIECBIOFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x865E6F0", Offset = "0x865CCF0", VA = "0x18865E6F0")]
	public GAHEIDJLPND(JPDMABGMGFC DLICMGKJENE, bool CEIHPKNBOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x865E250", Offset = "0x865C850", VA = "0x18865E250")]
	public void APAPFPHJLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x865E3E0", Offset = "0x865C9E0", VA = "0x18865E3E0")]
	protected HGOECGDMDII DPJMNCKNNHF()
	{
		return default(HGOECGDMDII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x865E5A0", Offset = "0x865CBA0", VA = "0x18865E5A0")]
	private static bool HJIMGEHMHIE(JPDMABGMGFC FKLFNAOMMOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x865E4E0", Offset = "0x865CAE0", VA = "0x18865E4E0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PDMNFNOOLEE : OPKCMEIJIBO, FOCDFGPPKDG, GIIFJHIFIIE, IDisposable, PPGDCNAHADK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NativeList<ONPFMKLHPJO> OLCLKKFNDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool NGEJHKLOGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool LHHNKOJBMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private float BDJKCOLAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int FFOEEIHNLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool GMFLMHMGJPE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool DKFEFBFLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xD94690", Offset = "0xD92C90", VA = "0x180D94690", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool DAFKNKHBECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAE2340", Offset = "0xAE0940", VA = "0x180AE2340", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private float BIIHCHDADKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xF2EA00", Offset = "0xF2D000", VA = "0x180F2EA00", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int KAIBNGIJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool PLFFFONKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD664C0", Offset = "0xD64AC0", VA = "0x180D664C0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private int GONHHLJEIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8676D10", Offset = "0x8675310", VA = "0x188676D10", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int AGHCKOCAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86773D0", Offset = "0x86759D0", VA = "0x1886773D0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86774C0", Offset = "0x8675AC0", VA = "0x1886774C0")]
	public PDMNFNOOLEE(JPDMABGMGFC EKIEPLMIJBC, [Optional] NativeList<ONPFMKLHPJO> OLCLKKFNDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8676D30", Offset = "0x8675330", VA = "0x188676D30", Slot = "26")]
	public override void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8676BC0", Offset = "0x86751C0", VA = "0x188676BC0", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8676CB0", Offset = "0x86752B0", VA = "0x188676CB0", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8677370", Offset = "0x8675970", VA = "0x188677370")]
	public void MNABNBPPGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8676FB0", Offset = "0x86755B0", VA = "0x188676FB0", Slot = "34")]
	public NativeArray<ONPFMKLHPJO> GetNativeCurvePoints()
	{
		return default(NativeArray<ONPFMKLHPJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8677180", Offset = "0x8675780", VA = "0x188677180", Slot = "35")]
	private Vector3 JCCKOMNABJO(int IEODBGLFEOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8677340", Offset = "0x8675940", VA = "0x188677340", Slot = "36")]
	private Quaternion MJEDDNFIMLF(int IEODBGLFEOD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8676E10", Offset = "0x8675410", VA = "0x188676E10", Slot = "37")]
	private float GAPLNFKLFBA(int IEODBGLFEOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86772D0", Offset = "0x86758D0", VA = "0x1886772D0")]
	private NativeArray<Entity> JEOFFJKDEBN()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class FKHLKKKOOHH : AGADIHNNJOD
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x865D1C0", Offset = "0x865B7C0", VA = "0x18865D1C0", Slot = "15")]
	protected override ComponentSystemBase OAMBDJAMHJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x865D5E0", Offset = "0x865BBE0", VA = "0x18865D5E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x865D5F0", Offset = "0x865BBF0", VA = "0x18865D5F0")]
	public FKHLKKKOOHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[ABBJCEFBIMJ]
public sealed class PAAMFKEMJMI : GABINGJPOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery KBGNCAJLFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery HMHIPOOOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery OIAGHBPCDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery MNCDHMIBIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery PGNNMLABABE;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8676790", Offset = "0x8674D90", VA = "0x188676790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8676AF0", Offset = "0x86750F0", VA = "0x188676AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8676250", Offset = "0x8674850", VA = "0x188676250")]
	private void HBDPPMBIKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8676680", Offset = "0x8674C80", VA = "0x188676680")]
	private void MLDGANPMKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8675FD0", Offset = "0x86745D0", VA = "0x188675FD0")]
	private void ADAENGAOKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8676430", Offset = "0x8674A30", VA = "0x188676430")]
	private void HNKEPAJGJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8676530", Offset = "0x8674B30", VA = "0x188676530")]
	private void IFMLACPDNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8676200", Offset = "0x8674800", VA = "0x188676200")]
	private NativeList<Entity> FJKNBOJONMF(NativeArray<Entity> GIPMABPLBDJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8676630", Offset = "0x8674C30", VA = "0x188676630")]
	private NativeList<Entity> KLMCELEAMOB(NativeArray<Entity> GIPMABPLBDJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x86761A0", Offset = "0x86747A0", VA = "0x1886761A0")]
	private void CGEOMJBECHF(NativeArray<Entity> GIPMABPLBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public PAAMFKEMJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ABBJCEFBIMJ]
public sealed class JMFECOJAAKE : GABINGJPOPI, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EntityQuery EBGOLBEAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EntityQuery LBPBJFEBABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery LDOEDCBJCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private BLACCFEAHOH EOCHJIAMIEH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x866A070", Offset = "0x8668670", VA = "0x18866A070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8669B40", Offset = "0x8668140", VA = "0x188669B40", Slot = "15")]
	public override void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x866A240", Offset = "0x8668840", VA = "0x18866A240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8669D50", Offset = "0x8668350", VA = "0x188669D50")]
	private void KPNBEAGMGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8668E20", Offset = "0x8667420", VA = "0x188668E20")]
	private void EBBCFADPCOC(NativeParallelHashSet<MOELEHFPCPE> AEAGEBOBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x86694B0", Offset = "0x8667AB0", VA = "0x1886694B0")]
	private void GGHBGJAAFJO(NativeParallelHashSet<MOELEHFPCPE> AEAGEBOBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x866A260", Offset = "0x8668860", VA = "0x18866A260")]
	private void PLCALMLHOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8668D80", Offset = "0x8667380", VA = "0x188668D80")]
	private bool BMDJIBOBONO(Entity COIPJNEHPIG, [Out] MOELEHFPCPE IFBBKCCHICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8669BA0", Offset = "0x86681A0", VA = "0x188669BA0")]
	private bool KEMBCIIHAKE(Entity COIPJNEHPIG, [Out] MOELEHFPCPE IFBBKCCHICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public JMFECOJAAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ABBJCEFBIMJ]
public sealed class FKJAEDFLFNL : GABINGJPOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery DOPCCGICHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery MFNGCDPPGDA;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x865DBF0", Offset = "0x865C1F0", VA = "0x18865DBF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x865DD40", Offset = "0x865C340", VA = "0x18865DD40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x865D600", Offset = "0x865BC00", VA = "0x18865D600")]
	private void EBBCFADPCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x865D900", Offset = "0x865BF00", VA = "0x18865D900")]
	private void GGHBGJAAFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public FKJAEDFLFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IDPGDFOAKJG : GABINGJPOPI, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct GBDJAOKCBFM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob IJILDIALDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EntityQueryInJob NACKGEHHKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EntityQueryInJob JHOOIFDKANE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EntityQueryInJob KOINHJHHJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ReadOnly]
		public EntityTypeHandle OLFOHKMBIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public ComponentTypeHandle<AODCINLAFKI> NJIGIKBPDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeList<Entity> AINBODJIIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> DNGPPNJFIKJ;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x865E9A0", Offset = "0x865CFA0", VA = "0x18865E9A0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x865EA20", Offset = "0x865D020", VA = "0x18865EA20")]
		private void OKJFBCNJPOD(EntityQueryInJob FMMNAILFLHJ, NativeList<Entity> HFCOOCFFBHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct JNEFDIPBKCA : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle OLFOHKMBIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<AODCINLAFKI> NJIGIKBPDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeList<Entity> HFCOOCFFBHL;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x866A6B0", Offset = "0x8668CB0", VA = "0x18866A6B0", Slot = "4")]
		public void Execute(ArchetypeChunk NMFFHPNOLKP, int BBAJCBKNIAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct PAALPDJCJAB : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public EntityTypeHandle OLFOHKMBIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> EPFAPKDOGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public ComponentTypeHandle<NIIBECIELFL> IKFLLLIFBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[ReadOnly]
		public ComponentDataFromEntity<AGKHFLBFNGN> CKCDCOJOGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ComponentTypeHandle<AODCINLAFKI> NINIKECBFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> MCDJFBACJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<NIIBECIELFL> ECADAINDFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeList<MOELEHFPCPE> JOMCGAIGHDD;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8675CA0", Offset = "0x86742A0", VA = "0x188675CA0", Slot = "4")]
		public void Execute(ArchetypeChunk NMFFHPNOLKP, int BBAJCBKNIAB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery IJILDIALDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery NACKGEHHKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery JHOOIFDKANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery KOINHJHHJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private EntityQuery ONBPNICGKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private EntityQuery DMAHNDKCGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private EntityQuery IOJJBBGOEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private BLACCFEAHOH HGPPCMOCAFJ;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8667660", Offset = "0x8665C60", VA = "0x188667660", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8666E30", Offset = "0x8665430", VA = "0x188666E30", Slot = "15")]
	public override void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8667BE0", Offset = "0x86661E0", VA = "0x188667BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8666680", Offset = "0x8664C80", VA = "0x188666680")]
	private void CGAAGDDAOPB(NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE, int LLMLCNNMILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8666230", Offset = "0x8664830", VA = "0x188666230")]
	private void ADFHNOJNOPJ(NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE, int PJGBENKEKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8666E90", Offset = "0x8665490", VA = "0x188666E90")]
	private void KFCFAMLCNJN(NativeParallelHashSet<MOELEHFPCPE> KKIPLIFOKOE, int LCHEKKLBDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x86672D0", Offset = "0x86658D0", VA = "0x1886672D0")]
	private void NJJOJHGDNPJ(NativeParallelHashSet<MOELEHFPCPE> AEAGEBOBGDB, int JELAFEGIGDK, int ANOBCEGODEF, int KDNIFLBEPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8666C80", Offset = "0x8665280", VA = "0x188666C80")]
	private void EHJLLHOEAKB(Entity HGOKFKIINBN, IFOKEJDEOGF HJAAEOJMPOG, MOELEHFPCPE IFBBKCCHICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public IDPGDFOAKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class JIDCHJKIMNL : GABINGJPOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EntityQuery PJMKHEIJJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private EntityQuery FBFLLAMMPBF;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8668140", Offset = "0x8666740", VA = "0x188668140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8668380", Offset = "0x8666980", VA = "0x188668380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public JIDCHJKIMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OKNHNFECKGF : GABINGJPOPI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct NAFBOIHODAM : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private EntityQuery CDJHGIMHKOE;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8675930", Offset = "0x8673F30", VA = "0x188675930", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8675A70", Offset = "0x8674070", VA = "0x188675A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public OKNHNFECKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ABBJCEFBIMJ]
internal class KHCLHHABCMG : GABINGJPOPI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class LJNFBDKHJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EntityQuery IDPBEHIMFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EntityQuery EMPEJLKELIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KHJHKAPPFCC EPOAAKHMHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ComponentType MGDPGGOCBKM;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LJNFBDKHJMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void KHJHKAPPFCC(NativeArray<IFOKEJDEOGF> IINGFCBPPPE, KPOKAGBLPPC PHMACIMNIMG);

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<LJNFBDKHJMG> NJMDPPLAFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private MDNJPDDHNCC FAOBPBCHDMB;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x866AC30", Offset = "0x8669230", VA = "0x18866AC30", Slot = "15")]
	public override void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x866AFD0", Offset = "0x86695D0", VA = "0x18866AFD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x866B160", Offset = "0x8669760", VA = "0x18866B160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E64C50", Offset = "0x3E63250", VA = "0x183E64C50")]
	private void DIMAEONOHGI<T>(KHJHKAPPFCC EPOAAKHMHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x866AE30", Offset = "0x8669430", VA = "0x18866AE30")]
	private static void KCDNLGFNCED(NativeArray<IFOKEJDEOGF> DEDILDEDBEA, KPOKAGBLPPC EGOOGMFHEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x866AA90", Offset = "0x8669090", VA = "0x18866AA90")]
	private static void DHFIKNKBPFM(NativeArray<IFOKEJDEOGF> DEDILDEDBEA, KPOKAGBLPPC EGOOGMFHEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x866AC90", Offset = "0x8669290", VA = "0x18866AC90")]
	private static void JGIHFLOABKP(NativeArray<IFOKEJDEOGF> DEDILDEDBEA, KPOKAGBLPPC EGOOGMFHEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public KHCLHHABCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ABBJCEFBIMJ]
public sealed class FNBDEBOMPML : GABINGJPOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery FMMNAILFLHJ;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x865DE00", Offset = "0x865C400", VA = "0x18865DE00", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ICGJCCOKGNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public UniformTRS BKBPHMFHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public StandardRenderableVisualData HJKKPFBDGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public DAKFOMKEJOH BPBDHNPBNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 HPJEAHFEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool GBDIJAGLDFC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PANIIMPHHFF(Lifetime.LoadInstance)]
public struct NDLLJKGKBIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity PDFMOBOALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> PGGNJCNLBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeParallelHashSet<Entity> CKGMNAOJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<ICGJCCOKGNL> NEIGDKBNEJB;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8672AE0", Offset = "0x86710E0", VA = "0x188672AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(GIILPADNGBJ), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class GIILPADNGBJ : DPFKFJLGBCO, LKJPKMELKMK, FCOEENGBKBM, CEJIANFMEIL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JJGKDHKFKGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly GIILPADNGBJ IGDHFGFJBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly bool IOGILEJEPMD;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9730", Offset = "0x1AB7D30", VA = "0x181AB9730")]
		public JJGKDHKFKGC(GIILPADNGBJ IGDHFGFJBMG, bool IOGILEJEPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8668910", Offset = "0x8666F10", VA = "0x188668910")]
		public Queue<CKHJDOMKGEP>.Enumerator DKMCAGKLCHH()
		{
			return default(Queue<CKHJDOMKGEP>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x86689D0", Offset = "0x8666FD0", VA = "0x1886689D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[DependsOn]
	private OBECOIDGDPJ AFBKJDCCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[DependsOn]
	private KNLCBINKMLD OMCNJLKBHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<NativeList<ONPFMKLHPJO>> IFBKNNIMEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<(Entity, List<GameObject>)> NLJODBOGHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeList<IFOKEJDEOGF> EEDGPEGGHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private FPEEDDEGOJH<CKHJDOMKGEP> NHGNPKKHBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private FPEEDDEGOJH<NDLLJKGKBIN> EHLHACADEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private FPEEDDEGOJH<ECDAFHMNHHI> ENMOEOAFDLL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8660580", Offset = "0x865EB80", VA = "0x188660580", Slot = "4")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8660AF0", Offset = "0x865F0F0", VA = "0x188660AF0")]
	public void KLFLPAFLOPH(NativeList<ONPFMKLHPJO> GNFMGGDDAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8660BB0", Offset = "0x865F1B0", VA = "0x188660BB0")]
	public void OLALLEMMOKJ(Entity IGDHFGFJBMG, [In] BIGICIGIIKM<GameObject> GFLBNMDDFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x86604F0", Offset = "0x865EAF0", VA = "0x1886604F0")]
	public void ELAFNMLEKGJ(NativeList<IFOKEJDEOGF> DEDILDEDBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8660780", Offset = "0x865ED80", VA = "0x188660780")]
	public void JNLFCKLOBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x865FF30", Offset = "0x865E530", VA = "0x18865FF30")]
	public void ADCFCBKLHCN(IPGDEIOBDCB BIAJFLEJGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8660A50", Offset = "0x865F050", VA = "0x188660A50")]
	public JobHandle KGEAMMPHJAC([In] CKHJDOMKGEP IFEHDCDCFPK, JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x86609B0", Offset = "0x865EFB0", VA = "0x1886609B0")]
	public JobHandle KGEAMMPHJAC([In] NDLLJKGKBIN IFEHDCDCFPK, JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82E7DC0", Offset = "0x82E63C0", VA = "0x1882E7DC0")]
	public JJGKDHKFKGC GOAKLHGHJEI(bool IOGILEJEPMD)
	{
		return default(JJGKDHKFKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8660450", Offset = "0x865EA50", VA = "0x188660450")]
	public JEBGLMACPHE<NDLLJKGKBIN> BJEBLHKKDNK()
	{
		return default(JEBGLMACPHE<NDLLJKGKBIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86604A0", Offset = "0x865EAA0", VA = "0x1886604A0")]
	public JEBGLMACPHE<ECDAFHMNHHI> DAHGOHLLJGB()
	{
		return default(JEBGLMACPHE<ECDAFHMNHHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8660D00", Offset = "0x865F300", VA = "0x188660D00")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8660F20", Offset = "0x865F520", VA = "0x188660F20", Slot = "5")]
	public void PILPLNBAOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x86603E0", Offset = "0x865E9E0", VA = "0x1886603E0", Slot = "6")]
	private void BFPDDFBJGNA(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1004A20", Offset = "0x1003020", VA = "0x181004A20", Slot = "7")]
	private void KMJKAGKKLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GIILPADNGBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IAJLEAAFJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public UniformTRS BKBPHMFHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public StandardRenderableVisualData HJKKPFBDGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public EKPIPMMBPJG MHCCEBNBPPI;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PANIIMPHHFF(Lifetime.LoadInstance)]
public struct CKHJDOMKGEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Entity PDFMOBOALJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<Entity> PGGNJCNLBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeParallelHashSet<Entity> CKGMNAOJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public NativeList<LKOMLBJPOKB> PDJDCJKAOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public NativeList<ONPFMKLHPJO> GNFMGGDDAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeList<IAJLEAAFJGE> GCLHPICAGEM;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x865C210", Offset = "0x865A810", VA = "0x18865C210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x865C140", Offset = "0x865A740", VA = "0x18865C140")]
	public void CKBKAMMKCLJ(bool IOGILEJEPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(LIKKCOJKKFG), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class LIKKCOJKKFG : PNLABLKFCDP, FCOEENGBKBM, CEJIANFMEIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[DependsOn]
	private GIILPADNGBJ JFDOPPNJOMI;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x866C980", Offset = "0x866AF80", VA = "0x18866C980", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x866C930", Offset = "0x866AF30", VA = "0x18866C930", Slot = "5")]
	private void BFPDDFBJGNA(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1316140", Offset = "0x1314740", VA = "0x181316140", Slot = "6")]
	private void KMJKAGKKLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LIKKCOJKKFG()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : GABINGJPOPI, DPFKFJLGBCO
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[BurstCompile]
		private struct GatherBakedPrimitiveDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			[ReadOnly]
			public ComponentTypeHandle<LocalDeformableScaleData> deformationScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> configTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			[ReadOnly]
			public ComponentTypeHandle<PrimitiveShapeData> shapeDataTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			[ReadOnly]
			public NativeParallelHashMap<int, DAKFOMKEJOH> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public NativeArray<ICGJCCOKGNL> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8661090", Offset = "0x865F690", VA = "0x188661090", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[BurstCompile]
		private struct GatherBakedSplineDataJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineShapeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[ReadOnly]
			public ComponentTypeHandle<StandardRenderableVisualData> visualTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalPoseData> poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[ReadOnly]
			public ComponentTypeHandle<AuthoredLocalUniformScaleData> scaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[ReadOnly]
			public NativeArray<ONPFMKLHPJO> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public NativeArray<LKOMLBJPOKB> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public NativeArray<IAJLEAAFJGE> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8661430", Offset = "0x865FA30", VA = "0x188661430", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[BurstCompile]
		internal struct CalculateSplinePointEstimateJob : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> linkedEntityGroup;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x865C220", Offset = "0x865A820", VA = "0x18865C220", Slot = "4")]
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
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public float3 Position;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public quaternion Rotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public quaternion BlendedRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public float BendAngle;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public float BendRadius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public float DistanceToNext;

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public float3 Direction
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0x86774F0", Offset = "0x8675AF0", VA = "0x1886774F0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8677510", Offset = "0x8675B10", VA = "0x188677510")]
					set
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			private interface IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				float3 FPKGOHINJPP(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x866C9A0", Offset = "0x866AFA0", VA = "0x18866C9A0", Slot = "5")]
				public float3 DMOOFOMNNBE(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x866CD50", Offset = "0x866B350", VA = "0x18866CD50", Slot = "4")]
				public float3 FPKGOHINJPP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x8673160", Offset = "0x8671760", VA = "0x188673160", Slot = "4")]
				public float3 FPKGOHINJPP(quaternion rotation)
				{
					return default(float3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private static readonly float3 Up;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private static readonly float3 DirectionAxis;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private static readonly float3 NormalAxis;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			[ReadOnly]
			public BufferTypeHandle<LinkedEntityGroup> pointsByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			[ReadOnly]
			public ComponentTypeHandle<ShapeConfigData> shapeConfigTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public ComponentTypeHandle<SplineShapeData> splineParametersTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> pointPositions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointRotationData> pointRotations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> pointScales;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public NativeArray<LKOMLBJPOKB> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public NativeArray<ONPFMKLHPJO> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8662330", Offset = "0x8660930", VA = "0x188662330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8662F10", Offset = "0x8661510", VA = "0x188662F10")]
			private void JFIHFADMINE(NativeList<PointSrcData> srcData, NativeList<ONPFMKLHPJO> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8664EF0", Offset = "0x86634F0", VA = "0x188664EF0")]
			public static Vector3 MLBNMGBNALN(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8662950", Offset = "0x8660F50", VA = "0x188662950")]
			public static quaternion FAOMANNMICL(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x86657F0", Offset = "0x8663DF0", VA = "0x1886657F0")]
			private static quaternion NOPDPNDMBHD(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8661B50", Offset = "0x8660150", VA = "0x188661B50")]
			private static float3 AAOBMJBNELD(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8665760", Offset = "0x8663D60", VA = "0x188665760")]
			private static quaternion NEDOEIMCPLB(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x86620C0", Offset = "0x86606C0", VA = "0x1886620C0")]
			private static ONPFMKLHPJO EGKDLLKFEKJ(int idx, NativeList<PointSrcData> srcData)
			{
				return default(ONPFMKLHPJO);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x44991E0", Offset = "0x44977E0", VA = "0x1844991E0")]
			private void NOPOGKKICED<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8663DF0", Offset = "0x86623F0", VA = "0x188663DF0")]
			private void JICHKGAMHOO(NativeList<PointSrcData> sourcePoints, NativeList<ONPFMKLHPJO> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8664C00", Offset = "0x8663200", VA = "0x188664C00")]
			public static float JIIEBCNIPGH(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8661ED0", Offset = "0x86604D0", VA = "0x188661ED0")]
			private static quaternion EAFPAKAJAON(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8662D60", Offset = "0x8661360", VA = "0x188662D60")]
			private static ONPFMKLHPJO JBKOJIHBMEC(PointSrcData point)
			{
				return default(ONPFMKLHPJO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8662E80", Offset = "0x8661480", VA = "0x188662E80")]
			private static ONPFMKLHPJO JBKOJIHBMEC(float3 pos, quaternion rot, float radius)
			{
				return default(ONPFMKLHPJO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8664D80", Offset = "0x8663380", VA = "0x188664D80")]
			private static bool JINCOOKDPFJ(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8664E20", Offset = "0x8663420", VA = "0x188664E20")]
			private static float3 JJPPANKPNMN(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x86629D0", Offset = "0x8660FD0", VA = "0x1886629D0")]
			public static float3 FMHAGNINCFE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8661D20", Offset = "0x8660320", VA = "0x188661D20")]
			public static float3 DMOOFOMNNBE(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8665300", Offset = "0x8663900", VA = "0x188665300")]
			private static quaternion NDNGIDODHDO(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8662B80", Offset = "0x8661180", VA = "0x188662B80")]
			private static float IKBMLMHJCNH(float3 from, float3 to)
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
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public EntityCommandBuffer.ParallelWriter ecbWriter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public BufferTypeHandle<LinkedEntityGroup> __splineAndPointsTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8679720", Offset = "0x8677D20", VA = "0x188679720")]
			private void AAGLOGBCLIN(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8679800", Offset = "0x8677E00", VA = "0x188679800", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[ReadOnly]
			public NativeArray<int> pointCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public NativeList<ONPFMKLHPJO> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x867AF30", Offset = "0x8679530", VA = "0x18867AF30")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x867AF90", Offset = "0x8679590", VA = "0x18867AF90", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public NativeList<ONPFMKLHPJO> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x867AED0", Offset = "0x86794D0", VA = "0x18867AED0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x867AF20", Offset = "0x8679520", VA = "0x18867AF20", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public NativeList<ICGJCCOKGNL> data;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8661770", Offset = "0x865FD70", VA = "0x188661770")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8661930", Offset = "0x865FF30", VA = "0x188661930", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> parentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public NativeList<Entity> splines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public NativeList<Entity> parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public NativeParallelHashSet<Entity> uniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public NativeList<LKOMLBJPOKB> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public NativeList<IAJLEAAFJGE> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8661940", Offset = "0x865FF40", VA = "0x188661940")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8661B40", Offset = "0x8660140", VA = "0x188661B40", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			[ReadOnly]
			public NativeList<Entity> splineParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			[ReadOnly]
			public NativeList<Entity> splineEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public BufferFromEntity<ChildBuffer> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x867AAA0", Offset = "0x86790A0", VA = "0x18867AAA0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x867AEC0", Offset = "0x86794C0", VA = "0x18867AEC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private const int PointEstimateIndex = 0;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private const int PointCountIndex = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private EntityQuery primitiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NGDFNIKLJAF replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private OBECOIDGDPJ objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private GIILPADNGBJ bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private OJMIHFPAHJE ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8679300", Offset = "0x8677900", VA = "0x188679300", Slot = "15")]
		public override void InitReferences(MKDGNELEFKI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x867A750", Offset = "0x8678D50", VA = "0x18867A750", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x867A840", Offset = "0x8678E40", VA = "0x18867A840", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x867A8A0", Offset = "0x8678EA0", VA = "0x18867A8A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8679C50", Offset = "0x8678250", VA = "0x188679C50")]
		private JobHandle MKOAHHOOANG(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8677AC0", Offset = "0x86760C0", VA = "0x188677AC0")]
		private JobHandle CLOCNJDCJBK(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8677560", Offset = "0x8675B60", VA = "0x188677560")]
		private JobHandle AFHFHKBDJMO(NativeArray<int> pointCount, NativeList<ONPFMKLHPJO> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x86798F0", Offset = "0x8677EF0", VA = "0x1886798F0")]
		private JobHandle NAPMIDGOCFN(NativeList<ONPFMKLHPJO> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8678E30", Offset = "0x8677430", VA = "0x188678E30")]
		private JobHandle IHMCMBJICGK(EntityQuery query, NativeList<LKOMLBJPOKB> splinePointRanges, NativeList<ONPFMKLHPJO> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x86779A0", Offset = "0x8675FA0", VA = "0x1886779A0")]
		private JobHandle CCGMALNBGKH(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8678800", Offset = "0x8676E00", VA = "0x188678800")]
		private JobHandle HCPAKOLNMHO(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8679480", Offset = "0x8677A80", VA = "0x188679480")]
		private JobHandle KBAPLPFPCPG(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<ICGJCCOKGNL> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8679990", Offset = "0x8677F90", VA = "0x188679990")]
		private JobHandle MDMIKLLBLND(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<LKOMLBJPOKB> splinePointRanges, [Out] NativeList<IAJLEAAFJGE> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x867A080", Offset = "0x8678680", VA = "0x18867A080")]
		private JobHandle OCLFHKCAEIP(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8678920", Offset = "0x8676F20", VA = "0x188678920")]
		private JobHandle HGNLIELCDLD(EntityQuery query, NativeList<ICGJCCOKGNL> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8678290", Offset = "0x8676890", VA = "0x188678290")]
		private static NativeParallelHashMap<int, DAKFOMKEJOH> EPHOCAHLJHA()
		{
			return default(NativeParallelHashMap<int, DAKFOMKEJOH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8677600", Offset = "0x8675C00", VA = "0x188677600")]
		private JobHandle AFNCJKFCPMF(EntityQuery query, NativeList<LKOMLBJPOKB> splinePointRanges, NativeList<ONPFMKLHPJO> splinePointData, NativeList<IAJLEAAFJGE> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x86793A0", Offset = "0x86779A0", VA = "0x1886793A0")]
		private JobHandle JBMHELFDGCB(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8677560", Offset = "0x8675B60", VA = "0x188677560")]
		private JobHandle ANALLCMJBCC(NativeArray<int> pointCount, NativeList<ONPFMKLHPJO> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x86798F0", Offset = "0x8677EF0", VA = "0x1886798F0")]
		private JobHandle MAHNNJCHHJF(NativeList<ONPFMKLHPJO> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8679F90", Offset = "0x8678590", VA = "0x188679F90")]
		private JobHandle MMDAHGONKEK(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<ICGJCCOKGNL> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8678180", Offset = "0x8676780", VA = "0x188678180")]
		private JobHandle EFBMEDILBOH(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<LKOMLBJPOKB> ranges, NativeList<IAJLEAAFJGE> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x86786B0", Offset = "0x8676CB0", VA = "0x1886786B0")]
		private JobHandle FLJGMALFAEC(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x867A400", Offset = "0x8678A00", VA = "0x18867A400", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JMAFEPOMNGG : EJNDCHEOADB, DPFKFJLGBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private GIILPADNGBJ JFDOPPNJOMI;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8668D10", Offset = "0x8667310", VA = "0x188668D10", Slot = "14")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8668D60", Offset = "0x8667360", VA = "0x188668D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
	public JMAFEPOMNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class MPCGFAPELIA : GABINGJPOPI, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct IAOCGCEHEOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private EntityManager JMBADOBJEBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private DCFMBFHAHKC<T> BPGGMHMDODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int LEPAEEGOBDO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5215E10", Offset = "0x5214410", VA = "0x185215E10")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5216910", Offset = "0x5214F10", VA = "0x185216910")]
		public IAOCGCEHEOB(EntityManager JMBADOBJEBH, DCFMBFHAHKC<T> BPGGMHMDODM, NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4B4EB50", Offset = "0x4B4D150", VA = "0x184B4EB50")]
		public IAOCGCEHEOB<T> DKMCAGKLCHH()
		{
			return default(IAOCGCEHEOB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x52168B0", Offset = "0x5214EB0", VA = "0x1852168B0")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly IDGHEFJHGEI GMGACCMOICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private KNLCBINKMLD OMCNJLKBHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private GIILPADNGBJ JFDOPPNJOMI;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x866FE20", Offset = "0x866E420", VA = "0x18866FE20", Slot = "15")]
	public override void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8671570", Offset = "0x866FB70", VA = "0x188671570")]
	public void OBDHBBDIMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x86715A0", Offset = "0x866FBA0", VA = "0x1886715A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x866DD70", Offset = "0x866C370", VA = "0x18866DD70")]
	private void BPFPHIANACI(ECDAFHMNHHI IFEHDCDCFPK, Mesh[] AFMMHMEHFMK, NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3EAFD00", Offset = "0x3EAE300", VA = "0x183EAFD00")]
	private IAOCGCEHEOB<T> NGJONHKLFPE<T>(DCFMBFHAHKC<T> BPGGMHMDODM, NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD) where T : struct
	{
		return default(IAOCGCEHEOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x866FEA0", Offset = "0x866E4A0", VA = "0x18866FEA0")]
	private void KFEEKIBNPGK(Transform IGDHFGFJBMG, NativeArray<DDEEFJJLBFE> LHDBPHACFBM, BIGICIGIIKM<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x866F410", Offset = "0x866DA10", VA = "0x18866F410")]
	private void GFMJPIOEGMK(Transform IGDHFGFJBMG, NativeArray<PKMOAPKMDAM> KBKJJGPNANP, BIGICIGIIKM<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8671180", Offset = "0x866F780", VA = "0x188671180")]
	private void NIDFANFOMNK(Transform IGDHFGFJBMG, NativeArray<OIBDBCAOOCD> DCHECGFPKOA, BIGICIGIIKM<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x866EFE0", Offset = "0x866D5E0", VA = "0x18866EFE0")]
	private void EFMIMAPBHOP(Transform IGDHFGFJBMG, NativeArray<ANBLJJPOPAN> AFMMHMEHFMK, Mesh[] EIFDLFAAMNI, BIGICIGIIKM<GameObject> PMKNAOIONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x866EE90", Offset = "0x866D490", VA = "0x18866EE90")]
	private static void CCENDFABDCC(NativeParallelHashSet<Entity> GIPMABPLBDJ, NativeParallelHashSet<Entity> PJNFDBFBBHL, NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x866DCB0", Offset = "0x866C2B0", VA = "0x18866DCB0")]
	private static void ANNHAAJEAAA(NativeList<Entity> AHJLBOEGGKN, NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8670620", Offset = "0x866EC20", VA = "0x188670620")]
	private NativeParallelHashMap<Entity, AGKHFLBFNGN> LHANOMNEJBB(GIILPADNGBJ.JJGKDHKFKGC EJGNGPHILBG, JEBGLMACPHE<NDLLJKGKBIN> APPOHPLELNK, List<GameObject> PMKNAOIONBC)
	{
		return default(NativeParallelHashMap<Entity, AGKHFLBFNGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8672710", Offset = "0x8670D10", VA = "0x188672710")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PNBDFLBNGAE(Entity LJHBDJFOEDM)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x866F8D0", Offset = "0x866DED0", VA = "0x18866F8D0")]
	private void HHOJHODGGFO(NativeList<Entity> DEABGCNFFCG, NativeList<Entity> BMNNLFBLADD, NativeParallelHashMap<Entity, AGKHFLBFNGN> JFAPKKGHKEE, NativeList<LKOMLBJPOKB> MCCKNLPECFD, NativeList<ONPFMKLHPJO> GCCLCNHFAKP, NativeList<IAJLEAAFJGE> IFBKNNIMEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8670230", Offset = "0x866E830", VA = "0x188670230")]
	private void KPDCAOOGGBN(NativeList<Entity> GIPMABPLBDJ, NativeList<Entity> PGGNJCNLBKL, NativeParallelHashMap<Entity, AGKHFLBFNGN> JFAPKKGHKEE, NativeList<ICGJCCOKGNL> NEIGDKBNEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x865DDF0", Offset = "0x865C3F0", VA = "0x18865DDF0")]
	public MPCGFAPELIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GHKONAINMAJ : NHIAHADKENM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly UniformTRS BKBPHMFHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly IKNCJJMPFDD IGDHFGFJBMG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GameObject IJMEDFPNMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public UniformTRS LOOBJEFNKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x865FD60", Offset = "0x865E360", VA = "0x18865FD60", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Vector3 LLKBDLNPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x865FC20", Offset = "0x865E220", VA = "0x18865FC20", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Matrix4x4 MIENGCCKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x865FE40", Offset = "0x865E440", VA = "0x18865FE40", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 NNMANMNMHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x865FCC0", Offset = "0x865E2C0", VA = "0x18865FCC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x865FC70", Offset = "0x865E270", VA = "0x18865FC70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Quaternion BBJJDIHBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x865FB80", Offset = "0x865E180", VA = "0x18865FB80", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x865FBD0", Offset = "0x865E1D0", VA = "0x18865FBD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private Vector3 GGOHELEPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x865FB30", Offset = "0x865E130", VA = "0x18865FB30", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Vector3 NDHIFMCHELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x865FE90", Offset = "0x865E490", VA = "0x18865FE90", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 JBKBGEKLINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x865FD10", Offset = "0x865E310", VA = "0x18865FD10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x865FEE0", Offset = "0x865E4E0", VA = "0x18865FEE0")]
	public GHKONAINMAJ(UniformTRS BKBPHMFHMFK, IKNCJJMPFDD IGDHFGFJBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class BBMBDGLGCOB : GHKONAINMAJ, GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly float BDGPOIHFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly float3 LJBBKCNKMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly JHJALLMJIFB AMCEBNCMBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly CKIILNPNIGK HJLKDFMPACF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private HGOECGDMDII AKALCNIJLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x865BEE0", Offset = "0x865A4E0", VA = "0x18865BEE0", Slot = "17")]
		get
		{
			return default(HGOECGDMDII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private UniformTRS DBLEDLICMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x865BE00", Offset = "0x865A400", VA = "0x18865BE00", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private float DFFJLJNPHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAE9950", Offset = "0xAE7F50", VA = "0x180AE9950", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private Vector3 LOEFDEACEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x865BF30", Offset = "0x865A530", VA = "0x18865BF30", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private JHJALLMJIFB MNNKCLDGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB19E90", Offset = "0xB18490", VA = "0x180B19E90", Slot = "21")]
		get
		{
			return default(JHJALLMJIFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private CKIILNPNIGK JDILNIJKELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x14B8A00", Offset = "0x14B7000", VA = "0x1814B8A00", Slot = "22")]
		get
		{
			return default(CKIILNPNIGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool DKMGHCHILMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KGINCHNHDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x865BF80", Offset = "0x865A580", VA = "0x18865BF80")]
	protected BBMBDGLGCOB(UniformTRS BKBPHMFHMFK, IKNCJJMPFDD IGDHFGFJBMG, float BDGPOIHFPOM, float3 LJBBKCNKMPI, JHJALLMJIFB AMCEBNCMBLC, CKIILNPNIGK HJLKDFMPACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract UnityEngine.Hash128 ComputeHash();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class KOEFJKMLPFP : NHIAHADKENM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly JPDMABGMGFC IEIKHLNDANP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected IKNCJJMPFDD JJLBJLPMOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1320710", Offset = "0x131ED10", VA = "0x181320710")]
		get
		{
			return default(IKNCJJMPFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected Entity MFLBPHFKANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x866C020", Offset = "0x866A620", VA = "0x18866C020")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected OBECOIDGDPJ MAKJIOAKLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x866C430", Offset = "0x866AA30", VA = "0x18866C430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected JEGHBMGNMHL IBEKGCKCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x866C3D0", Offset = "0x866A9D0", VA = "0x18866C3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	protected CMLIPCHHEFN KFKKGHJNMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x866BC70", Offset = "0x866A270", VA = "0x18866BC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GameObject IJMEDFPNMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x866C3A0", Offset = "0x866A9A0", VA = "0x18866C3A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public UniformTRS LOOBJEFNKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x134F6B0", Offset = "0x134DCB0", VA = "0x18134F6B0", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Vector3 LLKBDLNPFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x866C040", Offset = "0x866A640", VA = "0x18866C040", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Matrix4x4 MIENGCCKOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x866C600", Offset = "0x866AC00", VA = "0x18866C600", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 NNMANMNMHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x866C270", Offset = "0x866A870", VA = "0x18866C270", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x866C160", Offset = "0x866A760", VA = "0x18866C160", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Quaternion BBJJDIHBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x866BDF0", Offset = "0x866A3F0", VA = "0x18866BDF0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x866BF10", Offset = "0x866A510", VA = "0x18866BF10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector3 GGOHELEPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x866BD00", Offset = "0x866A300", VA = "0x18866BD00", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector3 NDHIFMCHELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x866C770", Offset = "0x866AD70", VA = "0x18866C770", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector3 JBKBGEKLINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x866C440", Offset = "0x866AA40", VA = "0x18866C440", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xF70F60", Offset = "0xF6F560", VA = "0x180F70F60")]
	protected KOEFJKMLPFP(JPDMABGMGFC EKIEPLMIJBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x866C130", Offset = "0x866A730", VA = "0x18866C130")]
	public static HGOECGDMDII HPNBGLLBBBG(KOEFJKMLPFP IHNLGGEEIFC)
	{
		return default(HGOECGDMDII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JMGMJCFOKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x867BEE0", Offset = "0x867A4E0", VA = "0x18867BEE0")]
	public static void FOKLHGNPIDO(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MHIAALMPOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x867C710", Offset = "0x867AD10", VA = "0x18867C710")]
	public static void MMMMENOLFNP(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH, IPGDEIOBDCB DHGPKDLDDNF, OBECOIDGDPJ CGAAKJBHOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x867C160", Offset = "0x867A760", VA = "0x18867C160")]
	public static void KJGCLCFKHPI(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH, IPGDEIOBDCB DHGPKDLDDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x867C6D0", Offset = "0x867ACD0", VA = "0x18867C6D0")]
	public static NativeList<Entity> KLMCELEAMOB(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x867C120", Offset = "0x867A720", VA = "0x18867C120")]
	public static NativeList<Entity> FJKNBOJONMF(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x867C470", Offset = "0x867AA70", VA = "0x18867C470")]
	private static NativeList<Entity> KLMCELEAMOB(NativeArray<Entity> GIPMABPLBDJ, EntityManager JMBADOBJEBH, bool KOMGEFKKJFE)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class OPKCMEIJIBO : KOEFJKMLPFP, GIIFJHIFIIE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float BDGPOIHFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Vector3 LJBBKCNKMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private JHJALLMJIFB AMCEBNCMBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CKIILNPNIGK HJLKDFMPACF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected EntityManager HNJPJAEOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x867CDA0", Offset = "0x867B3A0", VA = "0x18867CDA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected PNCGDOMLIHN JHKDEFOAAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x867CB80", Offset = "0x867B180", VA = "0x18867CB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected ShapeConfigData OMBCILNPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x867CE30", Offset = "0x867B430", VA = "0x18867CE30")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HGOECGDMDII AKALCNIJLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x866C130", Offset = "0x866A730", VA = "0x18866C130", Slot = "17")]
		get
		{
			return default(HGOECGDMDII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private float DFFJLJNPHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private Vector3 LOEFDEACEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x14274B0", Offset = "0x1425AB0", VA = "0x1814274B0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private JHJALLMJIFB MNNKCLDGDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90", Slot = "21")]
		get
		{
			return default(JHJALLMJIFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private CKIILNPNIGK JDILNIJKELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560", Slot = "22")]
		get
		{
			return default(CKIILNPNIGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private UniformTRS DBLEDLICMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x867CBE0", Offset = "0x867B1E0", VA = "0x18867CBE0", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool KGINCHNHDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAC33B0", Offset = "0xAC19B0", VA = "0x180AC33B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool DKMGHCHILMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x867CF20", Offset = "0x867B520", VA = "0x18867CF20")]
	protected OPKCMEIJIBO(JPDMABGMGFC EKIEPLMIJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x867CC10", Offset = "0x867B210", VA = "0x18867CC10", Slot = "26")]
	public virtual void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class GABINGJPOPI : EJNDCHEOADB, DPFKFJLGBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected OBECOIDGDPJ CGAAKJBHOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private OKDKNCHKIHF AEAKONLNGGP;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected IPGDEIOBDCB PIEDHEBMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x867BCB0", Offset = "0x867A2B0", VA = "0x18867BCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected KPOKAGBLPPC PIKGLOCCKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x867BE30", Offset = "0x867A430", VA = "0x18867BE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected bool CBCBLHGLEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x867BD70", Offset = "0x867A370", VA = "0x18867BD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x867BD00", Offset = "0x867A300", VA = "0x18867BD00", Slot = "15")]
	public virtual void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
	protected GABINGJPOPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EJCLKKKLHKH
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x867BA70", Offset = "0x867A070", VA = "0x18867BA70")]
	public static void FHJDNCODPFK(NativeArray<Entity> DEABGCNFFCG, EntityManager JMBADOBJEBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3424723883
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x867D120", Offset = "0x867B720", VA = "0x18867D120")]
	public static void NCAGDGCNHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x867D110", Offset = "0x867B710", VA = "0x18867D110")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NBNJFLJBHLM : ContainerPropertyBag<MOIGOLALALL>
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x867CB20", Offset = "0x867B120", VA = "0x18867CB20")]
	public NBNJFLJBHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class CMHPCNCNNFJ : ContainerPropertyBag<NIELMNDHPEL>
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x867BA10", Offset = "0x867A010", VA = "0x18867BA10")]
	public CMHPCNCNNFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class JJCLDOIAGPM : ContainerPropertyBag<EFKJDDPBKGJ>
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x867BE80", Offset = "0x867A480", VA = "0x18867BE80")]
	public JJCLDOIAGPM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x867CF50", Offset = "0x867B550", VA = "0x18867CF50")]
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
