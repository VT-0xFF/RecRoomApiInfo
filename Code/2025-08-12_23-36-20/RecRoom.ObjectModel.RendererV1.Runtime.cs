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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85923A0", Offset = "0x85911A0", VA = "0x1885923A0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8543CB0", Offset = "0x8542AB0", VA = "0x188543CB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x859A790", Offset = "0x8599590", VA = "0x18859A790")]
		private void EDICDPMMNIG(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x859AD30", Offset = "0x8599B30", VA = "0x18859AD30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x859AD90", Offset = "0x8599B90", VA = "0x18859AD90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NCHNPEDLJFP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8593730", Offset = "0x8592530", VA = "0x188593730")]
	public static Quaternion DIHCCLFHGAD([In] this JJKAMNDBKIN IIFBANEKAMN, [In] Vector3 GHKIAFFJCCO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GKHNMJMDEKO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8586740", Offset = "0x8585540", VA = "0x188586740")]
	public static bool KBEBDGPCJAC(this FBCKBFCNNNP NAAPKOMAPGM, HACLILBGPLE FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8585780", Offset = "0x8584580", VA = "0x188585780")]
	public static bool AOKCEHCCBCM(this FBCKBFCNNNP NAAPKOMAPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8585D60", Offset = "0x8584B60", VA = "0x188585D60")]
	public static bool CEGFPALCIMA(this FBCKBFCNNNP NAAPKOMAPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8586780", Offset = "0x8585580", VA = "0x188586780")]
	public static void LDNIDFMBOOM(this FBCKBFCNNNP NAAPKOMAPGM, Vector3 IGPGFHCJILO, Quaternion OBOHOHMIDAJ, float GDMMFIOGDOL, bool GMFFMGHMBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85857B0", Offset = "0x85845B0", VA = "0x1885857B0")]
	public static void BALKMBENCOL(this FBCKBFCNNNP NAAPKOMAPGM, Vector3 IGPGFHCJILO, Quaternion OBOHOHMIDAJ, float GDMMFIOGDOL, int GFONLAPEBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85868B0", Offset = "0x85856B0", VA = "0x1885868B0")]
	public static void MALNEGFHCMN(this FBCKBFCNNNP NAAPKOMAPGM, int GFONLAPEBLI, Vector3 IGPGFHCJILO, Quaternion OBOHOHMIDAJ, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8585D90", Offset = "0x8584B90", VA = "0x188585D90")]
	public static void CHGNHPLDLMO(this FBCKBFCNNNP NAAPKOMAPGM, Vector3 PEBLNDLEJKM, Quaternion HHKJNHCMMFI, float GDMMFIOGDOL, bool GMFFMGHMBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8586BB0", Offset = "0x85859B0", VA = "0x188586BB0")]
	private static void PHKAOBJOLHB(this FBCKBFCNNNP NAAPKOMAPGM, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL, bool GMFFMGHMBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8586A00", Offset = "0x8585800", VA = "0x188586A00")]
	private static void OHFOMDGAJHI(this FBCKBFCNNNP NAAPKOMAPGM, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG, float OAACACBILFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85862D0", Offset = "0x85850D0", VA = "0x1885862D0")]
	private static void DKICLDFCHAB(this FBCKBFCNNNP NAAPKOMAPGM, int JJJJBEGKNIN, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG, float OAACACBILFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85869D0", Offset = "0x85857D0", VA = "0x1885869D0")]
	private static bool ODANLAELGLD(this FBCKBFCNNNP NAAPKOMAPGM, int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85864B0", Offset = "0x85852B0", VA = "0x1885864B0")]
	private static void IFFGJMGNEBP(this FBCKBFCNNNP NAAPKOMAPGM, int JJJJBEGKNIN, Vector3 JONEPNABAIM, Quaternion NIALEBCNBKG, float OAACACBILFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8585DE0", Offset = "0x8584BE0", VA = "0x188585DE0")]
	public static Vector3 DDGKPGILECO(this FBCKBFCNNNP NAAPKOMAPGM, int JJJJBEGKNIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8585C50", Offset = "0x8584A50", VA = "0x188585C50")]
	public static Quaternion BIACCLOOCPB(this FBCKBFCNNNP NAAPKOMAPGM, int JJJJBEGKNIN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8585A30", Offset = "0x8584830", VA = "0x188585A30")]
	public static Vector3 BAMBJNFAAHF(HACLILBGPLE AEDIGFLCOAJ, Vector3 FLAPAOJCDCM, Vector3? NPJGIIMOGJL, Vector3 NKDFCLLCBEE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface JKHPOLMJGCI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJLAFCFFOLK(EntityQuery ENBMOIDBGKM, EntityManager OPLCAABCINH, CEMAGBAFCCI IHDHFEFDGDE, NIOLEBCMJHG IGNAJBGOAEA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface LMEOKCODECL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ComponentType ECLIHKBPGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELEEGGJHMID(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GONDBFHFLKE(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIEPJEMGNBC(CNCKGAMCPLB IBNABEIDIKD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class LEIBABBCPEA : JKHPOLMJGCI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8591DC0", Offset = "0x8590BC0", VA = "0x188591DC0", Slot = "4")]
	public void PJLAFCFFOLK(EntityQuery ENBMOIDBGKM, EntityManager OPLCAABCINH, CEMAGBAFCCI IHDHFEFDGDE, NIOLEBCMJHG IGNAJBGOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LEIBABBCPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class OOIHGFOAFCD : JKHPOLMJGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IEHEPMCODHJ JNPOLDJJOIO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
	public OOIHGFOAFCD(IEHEPMCODHJ JNPOLDJJOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8594B00", Offset = "0x8593900", VA = "0x188594B00", Slot = "4")]
	public void PJLAFCFFOLK(EntityQuery ENBMOIDBGKM, EntityManager OPLCAABCINH, CEMAGBAFCCI IHDHFEFDGDE, NIOLEBCMJHG IGNAJBGOAEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal class OAJNPNPHEDC : JKHPOLMJGCI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8594820", Offset = "0x8593620", VA = "0x188594820", Slot = "4")]
	public void PJLAFCFFOLK(EntityQuery ENBMOIDBGKM, EntityManager OPLCAABCINH, CEMAGBAFCCI IHDHFEFDGDE, NIOLEBCMJHG IGNAJBGOAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OAJNPNPHEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BPKKBGKJIIJ : LMEOKCODECL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ComponentType ECLIHKBPGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x857DD60", Offset = "0x857CB60", VA = "0x18857DD60", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x857D860", Offset = "0x857C660", VA = "0x18857D860", Slot = "5")]
	public void ELEEGGJHMID(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x857DAE0", Offset = "0x857C8E0", VA = "0x18857DAE0", Slot = "6")]
	public void GONDBFHFLKE(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x857D810", Offset = "0x857C610", VA = "0x18857D810", Slot = "7")]
	public void CIEPJEMGNBC(CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BPKKBGKJIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NNJCBFPMAEM : LMEOKCODECL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ComponentType ECLIHKBPGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85944D0", Offset = "0x85932D0", VA = "0x1885944D0", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8593FD0", Offset = "0x8592DD0", VA = "0x188593FD0", Slot = "5")]
	public void ELEEGGJHMID(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8594250", Offset = "0x8593050", VA = "0x188594250", Slot = "6")]
	public void GONDBFHFLKE(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8593F80", Offset = "0x8592D80", VA = "0x188593F80", Slot = "7")]
	public void CIEPJEMGNBC(CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NNJCBFPMAEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HFODLKEHGIJ : LMEOKCODECL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComponentType ECLIHKBPGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x858C470", Offset = "0x858B270", VA = "0x18858C470", Slot = "4")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x858BF70", Offset = "0x858AD70", VA = "0x18858BF70", Slot = "5")]
	public void ELEEGGJHMID(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x858C1F0", Offset = "0x858AFF0", VA = "0x18858C1F0", Slot = "6")]
	public void GONDBFHFLKE(EntityQuery ENBMOIDBGKM, CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x858BF20", Offset = "0x858AD20", VA = "0x18858BF20", Slot = "7")]
	public void CIEPJEMGNBC(CNCKGAMCPLB IBNABEIDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HFODLKEHGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class NGLBCBBOIGI : MECAHDPAGBH, CMKJLANCAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CEMAGBAFCCI IHDHFEFDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MEBBFMGIGNO HIEOFBFJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NIOLEBCMJHG IGNAJBGOAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<(EntityQuery query, JKHPOLMJGCI adapter)> OIIKFMJOPPL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8593970", Offset = "0x8592770", VA = "0x188593970", Slot = "15")]
	public virtual void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8593A00", Offset = "0x8592800", VA = "0x188593A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8593810", Offset = "0x8592610", VA = "0x188593810")]
	private void HCFDILNBEIH(EntityQueryDesc BMINCCFLNLD, JKHPOLMJGCI GPEHCCEHDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8593C30", Offset = "0x8592A30", VA = "0x188593C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
	public NGLBCBBOIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal class INDPAICMFMG : MECAHDPAGBH, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class PJNEGCHMBKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EntityQuery AOCCHCCLPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EntityQuery LPBBGJJOEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EntityQuery MADOCAKEDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EntityQuery FEAHLDNFMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EntityQuery IAKLANBHGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EntityQuery FNGCCDEDAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EntityQuery CFPPGCFBKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LMEOKCODECL OOJONGEPMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public ComponentType DGKCOJMIKIN;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PJNEGCHMBKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CEMAGBAFCCI IHDHFEFDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NIOLEBCMJHG IGNAJBGOAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MEBBFMGIGNO HIEOFBFJNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private List<PJNEGCHMBKG> OIIKFMJOPPL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x858FBB0", Offset = "0x858E9B0", VA = "0x18858FBB0", Slot = "14")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x858FC40", Offset = "0x858EA40", VA = "0x18858FC40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x858FDC0", Offset = "0x858EBC0", VA = "0x18858FDC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x858F030", Offset = "0x858DE30", VA = "0x18858F030")]
	private void CFEPKOHDDIA(PJNEGCHMBKG ELKCFKNGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x858F480", Offset = "0x858E280", VA = "0x18858F480")]
	private void HCFDILNBEIH(LMEOKCODECL OOJONGEPMME, ComponentType HNMLCANMKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
	public INDPAICMFMG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14336554891096525153uL)]
internal struct ADHDBBKEEHP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(3939343835747908767uL)]
internal struct GEIMEHKDBLB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(9697228609905595395uL)]
internal struct ABGMLAMCKFG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[RegisterService(typeof(NIOLEBCMJHG), new string[] { })]
public class LHIHCLNHOJI : NIOLEBCMJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EHMIJFGJLBH KDPGFALOHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EHMIJFGJLBH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LHIHCLNHOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[RegisterService(typeof(GOCKEMDPACE), new string[] { })]
public class JGDMPPCCOFJ : GOCKEMDPACE, EADJGLLJPNJ, MLOBALCJPKH, NCBGAICBELD, JDBGEACJNEG, IHLGGOCLGIA, BOIHHABJILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[DependsOn]
	private IJIJHKDIMIJ DJKOEPFGION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[DependsOn]
	private CEMAGBAFCCI IHDHFEFDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[DependsOn]
	private NKPGLIPFHAL HNCOOFAGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EntityQuery JMIFMKENMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private EntityQuery KOICLCGNHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private bool HFDFHNHJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Entity GOKHJMDANCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private AIOBPENNHGA IPAAMPBKKNO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private EntityManager CDPCMDMNAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8590790", Offset = "0x858F590", VA = "0x188590790")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CHBBEHPCBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8590050", Offset = "0x858EE50", VA = "0x188590050", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GJFJFKDGLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8590070", Offset = "0x858EE70", VA = "0x188590070", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85901E0", Offset = "0x858EFE0", VA = "0x1885901E0", Slot = "4")]
	public bool HEODBBAOOPP(CLPADLABDGI DPODDKLLKHL, CIBOKDDAPGP HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85904D0", Offset = "0x858F2D0", VA = "0x1885904D0", Slot = "5")]
	public AIOBPENNHGA MCBELBEALLP()
	{
		return default(AIOBPENNHGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85902C0", Offset = "0x858F0C0", VA = "0x1885902C0", Slot = "8")]
	public void InitExternal(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85901A0", Offset = "0x858EFA0", VA = "0x1885901A0", Slot = "10")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8590090", Offset = "0x858EE90", VA = "0x188590090", Slot = "9")]
	public void EIBFHHFGNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8590440", Offset = "0x858F240", VA = "0x188590440", Slot = "11")]
	private void LFGDJFPHPKJ(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1334F60", Offset = "0x1333D60", VA = "0x181334F60", Slot = "12")]
	private void HJBDBNLCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JGDMPPCCOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[RegisterService(typeof(ILMMFBIKFOD), new string[] { })]
public class BHDLHABFFHJ : ILMMFBIKFOD
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x857D5B0", Offset = "0x857C3B0", VA = "0x18857D5B0", Slot = "4")]
	public void FIIDMLJFPHG(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x857CD30", Offset = "0x857BB30", VA = "0x18857CD30", Slot = "5")]
	public void BEAIOGFPMMO(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x857D700", Offset = "0x857C500", VA = "0x18857D700", Slot = "6")]
	public ComponentSystemBase KBAEHEIODJP(World DJKOEPFGION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x857D7B0", Offset = "0x857C5B0", VA = "0x18857D7B0", Slot = "7")]
	public void LFAKFGFPLHK(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x857D630", Offset = "0x857C430", VA = "0x18857D630", Slot = "8")]
	public void FOHCCGADKPO(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x857D750", Offset = "0x857C550", VA = "0x18857D750", Slot = "9")]
	public void LEMEGJMOLDO(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x857D690", Offset = "0x857C490", VA = "0x18857D690", Slot = "10")]
	public void JNCODDOGHGH(World DJKOEPFGION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x857CD80", Offset = "0x857BB80", VA = "0x18857CD80", Slot = "11")]
	public NativeParallelHashSet<ComponentTypeIndex> FGINMAHBGEP()
	{
		return default(NativeParallelHashSet<ComponentTypeIndex>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BHDLHABFFHJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(8022771283198464153uL)]
public struct JAEAMMKHGAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(7787318400023670087uL)]
public struct EBILDMKLCJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CIGIEBPPDFO : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EFOEIEPCHCP GDAFOFJKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x857E580", Offset = "0x857D380", VA = "0x18857E580", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x857E510", Offset = "0x857D310", VA = "0x18857E510", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CIGIEBPPDFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(9578575130884295287uL)]
public struct JKKMMEPDCOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AIOBPENNHGA PFGIHJOLFAO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static JKKMMEPDCOB MIDAFINGFAP(AIOBPENNHGA MJIBDELKIML)
	{
		return default(JKKMMEPDCOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KOCEIHEODHC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IAJEINKKMII GFHIHKBEAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8591D50", Offset = "0x8590B50", VA = "0x188591D50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KOCEIHEODHC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(10815538147163088674uL)]
public struct AKICJNEGEKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(10245696125477899514uL)]
public struct CCCMABGKDGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KCPCCONBFEI GOOFENBGIKB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static CCCMABGKDGK MIDAFINGFAP(KCPCCONBFEI MJIBDELKIML)
	{
		return default(CCCMABGKDGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(10129251117493878592uL)]
public struct DPHPKIBOONE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public AIOBPENNHGA PFGIHJOLFAO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static DPHPKIBOONE MIDAFINGFAP(AIOBPENNHGA MJIBDELKIML)
	{
		return default(DPHPKIBOONE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BDFCAKMIPAH : IComponentData, ICloneable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BJPNHFEILJG OAOBMDAAANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x857CC00", Offset = "0x857BA00", VA = "0x18857CC00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x857CB90", Offset = "0x857B990", VA = "0x18857CB90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BDFCAKMIPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NIEJOBFCAEN : ILFPEEAIJNH, EFOEIEPCHCP, MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ALLMNIBKHFE MAGKOPHJOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return default(ALLMNIBKHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool AHHEHKEPPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD63540", Offset = "0xD62340", VA = "0x180D63540", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float3 PFIKAFHIICN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x127F640", Offset = "0x127E440", VA = "0x18127F640", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8593E70", Offset = "0x8592C70", VA = "0x188593E70")]
	public NIEJOBFCAEN(UniformTRS CLIIEFBGOBF, PLCNDJEJBLF PJGOIMBEKPK, float IDDADLBOLCF, float3 MPGMCEPNBNO, BEIEMLGIDNI BAGAAFAGDHI, PFNNFGPAHBA IPGCKMEFIPB, ALLMNIBKHFE JBABKNDKMFA, float3 AAJOGIMGMNC, bool HFCJABFOAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8593E20", Offset = "0x8592C20", VA = "0x188593E20", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OJAGPFJBCHE : ILFPEEAIJNH, BJPNHFEILJG, MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<BPLOOPPGBOJ> ACNFJHCMFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly EJCFGOKHNGI ONHEEOKCMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly float MDKGAGBCCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly int GHFMGDNJMGG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MMAFJLPBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8594AD0", Offset = "0x85938D0", VA = "0x188594AD0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool ELNOMNBHNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8594AF0", Offset = "0x85938F0", VA = "0x188594AF0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ODKBFDHHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8594AE0", Offset = "0x85938E0", VA = "0x188594AE0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FAMCMJKNHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAF8A80", Offset = "0xAF7880", VA = "0x180AF8A80", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float NHMOGDAJDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xE12C90", Offset = "0xE11A90", VA = "0x180E12C90", Slot = "29")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LHMNAJNKKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A30", Offset = "0x10B0830", VA = "0x1810B1A30", Slot = "30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8594A20", Offset = "0x8593820", VA = "0x188594A20")]
	public OJAGPFJBCHE(UniformTRS CLIIEFBGOBF, PLCNDJEJBLF PJGOIMBEKPK, float IDDADLBOLCF, float3 MPGMCEPNBNO, BEIEMLGIDNI BAGAAFAGDHI, PFNNFGPAHBA IPGCKMEFIPB, EJCFGOKHNGI ONHEEOKCMKO, float MDKGAGBCCIN, int GHFMGDNJMGG, NativeArray<BPLOOPPGBOJ> ACNFJHCMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1296C90", Offset = "0x1295A90", VA = "0x181296C90", Slot = "33")]
	public NativeArray<BPLOOPPGBOJ> GetNativeCurvePoints()
	{
		return default(NativeArray<BPLOOPPGBOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8594960", Offset = "0x8593760", VA = "0x188594960", Slot = "25")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "26")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CEMELEBADIO : CMDGBJACPCM, EFOEIEPCHCP, MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly Dictionary<OJDJBNOCNOE, ALLMNIBKHFE> CIGLAAEFKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private ALLMNIBKHFE JBABKNDKMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool HFCJABFOAJB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private ALLMNIBKHFE KJIAKCKPENN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0", Slot = "28")]
		get
		{
			return default(ALLMNIBKHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool BBBDDLIMHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xFBC1B0", Offset = "0xFBAFB0", VA = "0x180FBC1B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float3 PFIKAFHIICN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x857E440", Offset = "0x857D240", VA = "0x18857E440", Slot = "30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x857E420", Offset = "0x857D220", VA = "0x18857E420")]
	public CEMELEBADIO(CLPADLABDGI MPOBGGNJMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x857DF10", Offset = "0x857CD10", VA = "0x18857DF10", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x857DD90", Offset = "0x857CB90", VA = "0x18857DD90", Slot = "26")]
	public override void AFCEEABIEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BCBIHLIMAHN : HOIFDDDCMMI, IAJEINKKMII, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GameObject NIAGIDMHFAF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GameObject AHIOLNHEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x857C700", Offset = "0x857B500", VA = "0x18857C700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FHLDPOMNGOB DGABKBJAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x857C600", Offset = "0x857B400", VA = "0x18857C600", Slot = "15")]
		get
		{
			return default(FHLDPOMNGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AKINJEDNFNM ANPDCELFGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x857CA30", Offset = "0x857B830", VA = "0x18857CA30", Slot = "16")]
		get
		{
			return default(AKINJEDNFNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x857C8E0", Offset = "0x857B6E0", VA = "0x18857C8E0")]
	public BCBIHLIMAHN(CLPADLABDGI DPODDKLLKHL, bool HDJCAAANCAL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x857C440", Offset = "0x857B240", VA = "0x18857C440")]
	public void BIJBIAJFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x857C600", Offset = "0x857B400", VA = "0x18857C600")]
	protected FHLDPOMNGOB EIOANADDEND()
	{
		return default(FHLDPOMNGOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x857C790", Offset = "0x857B590", VA = "0x18857C790")]
	private static bool KLNNFKOLJCA(CLPADLABDGI JMPILGKOBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x857C5D0", Offset = "0x857B3D0", VA = "0x18857C5D0", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JKHDDAMCAGK : CMDGBJACPCM, BJPNHFEILJG, MONDPKCLBPC, IDisposable, FKOGGCMOAEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NativeList<BPLOOPPGBOJ> ACNFJHCMFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private bool KLBHINAAGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private bool HCHKACKIEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private float MDKGAGBCCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int GHFMGDNJMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool IDGNMKBLOBB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool JIBFPEJLOED
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool KPBOOCOJLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAE1510", Offset = "0xAE0310", VA = "0x180AE1510", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private float HKMMDDNAFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xF29370", Offset = "0xF28170", VA = "0x180F29370", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private int NGIFIDCHOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool NIDEJEFNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xD63540", Offset = "0xD62340", VA = "0x180D63540", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private int FPDEFJOLNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8591020", Offset = "0x858FE20", VA = "0x188591020", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int GPHDLADCDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8590A80", Offset = "0x858F880", VA = "0x188590A80", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x85910D0", Offset = "0x858FED0", VA = "0x1885910D0")]
	public JKHDDAMCAGK(CLPADLABDGI MPOBGGNJMLJ, [Optional] NativeList<BPLOOPPGBOJ> ACNFJHCMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85907E0", Offset = "0x858F5E0", VA = "0x1885907E0", Slot = "26")]
	public override void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8590930", Offset = "0x858F730", VA = "0x188590930", Slot = "27")]
	public override UnityEngine.Hash128 ComputeHash()
	{
		return default(UnityEngine.Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8590A20", Offset = "0x858F820", VA = "0x188590A20", Slot = "25")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8591040", Offset = "0x858FE40", VA = "0x188591040")]
	public void MCJOKCDIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8590D00", Offset = "0x858FB00", VA = "0x188590D00", Slot = "34")]
	public NativeArray<BPLOOPPGBOJ> GetNativeCurvePoints()
	{
		return default(NativeArray<BPLOOPPGBOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8590ED0", Offset = "0x858FCD0", VA = "0x188590ED0", Slot = "35")]
	private Vector3 HIBHPMBLBBG(int ENMBFMACLBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85910A0", Offset = "0x858FEA0", VA = "0x1885910A0", Slot = "36")]
	private Quaternion MEOFPAICLDM(int ENMBFMACLBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8590B70", Offset = "0x858F970", VA = "0x188590B70", Slot = "37")]
	private float GLPIGDACPLN(int ENMBFMACLBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x85908C0", Offset = "0x858F6C0", VA = "0x1885908C0")]
	private NativeArray<Entity> BHAKJFEHGFL()
	{
		return default(NativeArray<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
internal sealed class NAJKNMGAACD : PPGMKLFCEGL
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8593300", Offset = "0x8592100", VA = "0x188593300", Slot = "15")]
	protected override ComponentSystemBase ALHJINPJJNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8593710", Offset = "0x8592510", VA = "0x188593710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8593720", Offset = "0x8592520", VA = "0x188593720")]
	public NAJKNMGAACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[LEJBAGPJGGP]
public sealed class MHMFBJJAINI : PLNFHAJCGIN
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EntityQuery NEMLMJAABDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EntityQuery OKNPCHHNBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private EntityQuery ONIIHEBMEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityQuery GKDHEHPOCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityQuery GBLEFJEANCJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8592EE0", Offset = "0x8591CE0", VA = "0x188592EE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8593240", Offset = "0x8592040", VA = "0x188593240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8592B30", Offset = "0x8591930", VA = "0x188592B30")]
	private void KMAPIHJBLCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8592820", Offset = "0x8591620", VA = "0x188592820")]
	private void GOOKAIGDMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8592D10", Offset = "0x8591B10", VA = "0x188592D10")]
	private void NIDIEHELAOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8592930", Offset = "0x8591730", VA = "0x188592930")]
	private void IBBGJFEPOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8592A30", Offset = "0x8591830", VA = "0x188592A30")]
	private void KHDKBCDMHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x85927D0", Offset = "0x85915D0", VA = "0x1885927D0")]
	private NativeList<Entity> FILIBPFOKJO(NativeArray<Entity> ALJPELHALEH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8592780", Offset = "0x8591580", VA = "0x188592780")]
	private NativeList<Entity> EHBKHBGGNCH(NativeArray<Entity> ALJPELHALEH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8592720", Offset = "0x8591520", VA = "0x188592720")]
	private void CLIFDMFNDAC(NativeArray<Entity> ALJPELHALEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public MHMFBJJAINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[LEJBAGPJGGP]
public sealed class IEBMHDDHFMM : PLNFHAJCGIN, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private EntityQuery BCHLKIEEEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EntityQuery NFFFMOBDLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private EntityQuery MADOCAKEDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private GOCKEMDPACE DKPPPIGALDL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x858E460", Offset = "0x858D260", VA = "0x18858E460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x858E1B0", Offset = "0x858CFB0", VA = "0x18858E1B0", Slot = "15")]
	public override void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x858E630", Offset = "0x858D430", VA = "0x18858E630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x858DE80", Offset = "0x858CC80", VA = "0x18858DE80")]
	private void IILIGBDHPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x858D7F0", Offset = "0x858C5F0", VA = "0x18858D7F0")]
	private void GBHDABJPKDA(NativeParallelHashSet<AIOBPENNHGA> LHCAOKPPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x858D160", Offset = "0x858BF60", VA = "0x18858D160")]
	private void DLFDHKNOCPM(NativeParallelHashSet<AIOBPENNHGA> LHCAOKPPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x858E650", Offset = "0x858D450", VA = "0x18858E650")]
	private void PNMGNMOAHBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x858E210", Offset = "0x858D010", VA = "0x18858E210")]
	private bool NLKKJGECNJK(Entity DJHHEAHBFFL, [Out] AIOBPENNHGA PFGIHJOLFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x858E2B0", Offset = "0x858D0B0", VA = "0x18858E2B0")]
	private bool OHBCCCFJBME(Entity DJHHEAHBFFL, [Out] AIOBPENNHGA PFGIHJOLFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public IEBMHDDHFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[LEJBAGPJGGP]
public sealed class AIKJKFAJMLN : PLNFHAJCGIN
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EntityQuery JALBGKJDABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private EntityQuery DLFBLJHEPIJ;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x857BE40", Offset = "0x857AC40", VA = "0x18857BE40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x857BF90", Offset = "0x857AD90", VA = "0x18857BF90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x857BB40", Offset = "0x857A940", VA = "0x18857BB40")]
	private void GBHDABJPKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x857B850", Offset = "0x857A650", VA = "0x18857B850")]
	private void DLFDHKNOCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public AIKJKFAJMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PLENHPDOHCO : PLNFHAJCGIN, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[BurstCompile]
	private struct IICFMNLOAIF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EntityQueryInJob IIMGLAMJINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EntityQueryInJob BFAMNOPHHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EntityQueryInJob NKFMFANLNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EntityQueryInJob AEOMJNAKJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ReadOnly]
		public EntityTypeHandle HCDDGMIAEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ReadOnly]
		public ComponentTypeHandle<DPHPKIBOONE> HMJDMPKGNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NativeList<Entity> CDJLGBBBCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeList<Entity> ABCNIIKLECO;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x858ECD0", Offset = "0x858DAD0", VA = "0x18858ECD0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x858ED50", Offset = "0x858DB50", VA = "0x18858ED50")]
		private void GCBGLOMHEJG(EntityQueryInJob ENBMOIDBGKM, NativeList<Entity> KCHKFJOMHEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct IFJLNDEKMEN : IQueryInJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[ReadOnly]
		public EntityTypeHandle HCDDGMIAEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ReadOnly]
		public ComponentTypeHandle<DPHPKIBOONE> HMJDMPKGNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeList<Entity> KCHKFJOMHEF;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x858EA90", Offset = "0x858D890", VA = "0x18858EA90", Slot = "4")]
		public void Execute(ArchetypeChunk KGPOOHDNKCJ, int DEJJPHKKPPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[BurstCompile]
	private struct FDNOFCNJHJC : IJobEntityBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public EntityTypeHandle HCDDGMIAEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public ComponentTypeHandle<ParentData> IJAFENCAMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ReadOnly]
		public ComponentTypeHandle<CCCMABGKDGK> OOMEJALLDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[ReadOnly]
		public ComponentDataFromEntity<JKKMMEPDCOB> COCIDGFDLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ComponentTypeHandle<DPHPKIBOONE> DNFIECOADJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> CLDPAFIBGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeList<CCCMABGKDGK> EDPGIEJOJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeList<AIOBPENNHGA> MOPJPHKJAMF;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85848B0", Offset = "0x85836B0", VA = "0x1885848B0", Slot = "4")]
		public void Execute(ArchetypeChunk KGPOOHDNKCJ, int DEJJPHKKPPK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EntityQuery IIMGLAMJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private EntityQuery BFAMNOPHHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private EntityQuery NKFMFANLNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EntityQuery AEOMJNAKJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private EntityQuery MOPJOJPBNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private EntityQuery GLNIEHMIKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private EntityQuery AEHOHHOKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private GOCKEMDPACE LPDJFABGOGF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8596080", Offset = "0x8594E80", VA = "0x188596080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8595BD0", Offset = "0x85949D0", VA = "0x188595BD0", Slot = "15")]
	public override void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8596600", Offset = "0x8595400", VA = "0x188596600", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8594FE0", Offset = "0x8593DE0", VA = "0x188594FE0")]
	private void BNEFFNOAJEI(NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA, int FIBEGOFOKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8595C30", Offset = "0x8594A30", VA = "0x188595C30")]
	private void NMACMPDFAHE(NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA, int MLEACKJCEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85955E0", Offset = "0x85943E0", VA = "0x1885955E0")]
	private void EEFLHAMHENC(NativeParallelHashSet<AIOBPENNHGA> EEMEHMFCEFA, int IFPAFPMDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8594C50", Offset = "0x8593A50", VA = "0x188594C50")]
	private void BIGJNCOOMKO(NativeParallelHashSet<AIOBPENNHGA> LHCAOKPPEIK, int ILMBKMBNMNK, int JJJKNBJJBGO, int IMGFAOADJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8595A20", Offset = "0x8594820", VA = "0x188595A20")]
	private void HMPGADIMDIB(Entity MKEFJDHJMEO, KCPCCONBFEI MAFEAKAEFLJ, AIOBPENNHGA PFGIHJOLFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public PLENHPDOHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FHKGJKGDICK : PLNFHAJCGIN
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private EntityQuery PDEOPHAEKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private EntityQuery INBHIKBKLHL;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8584BE0", Offset = "0x85839E0", VA = "0x188584BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8584E10", Offset = "0x8583C10", VA = "0x188584E10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public FHKGJKGDICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EBANNCHOJCA : PLNFHAJCGIN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(13972172025007325174uL)]
	private struct PCLCMBGNGIJ : IComponentData
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private EntityQuery PKGLCDAAOPL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8584540", Offset = "0x8583340", VA = "0x188584540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8584680", Offset = "0x8583480", VA = "0x188584680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public EBANNCHOJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LEJBAGPJGGP]
internal class JOELAHBEJDF : PLNFHAJCGIN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class BJEFFNFDLND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EntityQuery JDKPJENNBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EntityQuery GAJACFIIEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IJALPCJPGIE NMLJDJEKGNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ComponentType CKFOBGKELCD;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BJEFFNFDLND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private delegate void IJALPCJPGIE(NativeArray<KCPCCONBFEI> MJIBDELKIML, CNCKGAMCPLB IBNABEIDIKD);

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<BJEFFNFDLND> OIIKFMJOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private MEBBFMGIGNO HIEOFBFJNIH;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85912A0", Offset = "0x85900A0", VA = "0x1885912A0", Slot = "15")]
	public override void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8591640", Offset = "0x8590440", VA = "0x188591640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x85917D0", Offset = "0x85905D0", VA = "0x1885917D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D77580", Offset = "0x3D76380", VA = "0x183D77580")]
	private void HCFDILNBEIH<T>(IJALPCJPGIE NMLJDJEKGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8591300", Offset = "0x8590100", VA = "0x188591300")]
	private static void JACPPKGJMGD(NativeArray<KCPCCONBFEI> KELIIEBDMOM, CNCKGAMCPLB MPPAIDCJNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x85914A0", Offset = "0x85902A0", VA = "0x1885914A0")]
	private static void OCAJFMPLMKD(NativeArray<KCPCCONBFEI> KELIIEBDMOM, CNCKGAMCPLB MPPAIDCJNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8591100", Offset = "0x858FF00", VA = "0x188591100")]
	private static void ELODGIKHFKH(NativeArray<KCPCCONBFEI> KELIIEBDMOM, CNCKGAMCPLB MPPAIDCJNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public JOELAHBEJDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LEJBAGPJGGP]
public sealed class AALDCLLBCPK : PLNFHAJCGIN
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery ENBMOIDBGKM;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x857B410", Offset = "0x857A210", VA = "0x18857B410", Slot = "13")]
	protected override void OnUpdate()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct HMFEIACKGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public UniformTRS CLIIEFBGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public StandardRenderableVisualData IDELAOGFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ALLMNIBKHFE JBABKNDKMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 AAJOGIMGMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool HFCJABFOAJB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[OOIBNJCENBJ(Lifetime.LoadInstance)]
public struct CPJDJLDMJAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity OKCGKPEIJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeList<Entity> HMDGCANLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeParallelHashSet<Entity> BFBNJMLHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<HMFEIACKGGE> GKENHHBCDEE;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x857E640", Offset = "0x857D440", VA = "0x18857E640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterService(typeof(DHKLPGFNNLG), new string[] { })]
[ServiceLifetime(Lifetime.OMRoom)]
internal class DHKLPGFNNLG : CMKJLANCAGA, JDBGEACJNEG, IHLGGOCLGIA, BOIHHABJILH
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct AKOJGDNADHK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly DHKLPGFNNLG PJGOIMBEKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly bool FKCKOGLEONL;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7590", Offset = "0x1AA6390", VA = "0x181AA7590")]
		public AKOJGDNADHK(DHKLPGFNNLG PJGOIMBEKPK, bool FKCKOGLEONL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x857C380", Offset = "0x857B180", VA = "0x18857C380")]
		public Queue<BDFFGGCJFJN>.Enumerator OLGNAIIDMLF()
		{
			return default(Queue<BDFFGGCJFJN>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x857C040", Offset = "0x857AE40", VA = "0x18857C040", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[DependsOn]
	private NKPGLIPFHAL BFBCMNKJIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[DependsOn]
	private BKHEGJALGFC DBPJJCFIOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<NativeList<BPLOOPPGBOJ>> GKADJBFEPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<(Entity, List<GameObject>)> FPOFHPMIFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeList<KCPCCONBFEI> LGPKHOJLFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private HPJECGFCGKK<BDFFGGCJFJN> GLHDGNLHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private HPJECGFCGKK<CPJDJLDMJAA> PPLJFGBCCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private HPJECGFCGKK<AMBDGHOOILP> OHLMBAOCCKM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8583960", Offset = "0x8582760", VA = "0x188583960", Slot = "4")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8584400", Offset = "0x8583200", VA = "0x188584400")]
	public void PACJKCLAPIB(NativeList<BPLOOPPGBOJ> NNLFKKEKIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8583B60", Offset = "0x8582960", VA = "0x188583B60")]
	public void JKINNGKCOKF(Entity PJGOIMBEKPK, [In] LIJJHMMHNOE<GameObject> MFJFAOKMIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8583880", Offset = "0x8582680", VA = "0x188583880")]
	public void HPMJCFNLEKF(NativeList<KCPCCONBFEI> KELIIEBDMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8584160", Offset = "0x8582F60", VA = "0x188584160")]
	public void LEMEGJMOLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8583CB0", Offset = "0x8582AB0", VA = "0x188583CB0")]
	public void LBJGCLNPEEK(DBDEJHBHIBB EKOKCFOMOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8583520", Offset = "0x8582320", VA = "0x188583520")]
	public JobHandle FBBBGHPHGNK([In] BDFFGGCJFJN JDFCBBCKOGJ, JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85835C0", Offset = "0x85823C0", VA = "0x1885835C0")]
	public JobHandle FBBBGHPHGNK([In] CPJDJLDMJAA JDFCBBCKOGJ, JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x81FFA90", Offset = "0x81FE890", VA = "0x1881FFA90")]
	public AKOJGDNADHK BDFAOGNNEPG(bool FKCKOGLEONL)
	{
		return default(AKOJGDNADHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8583910", Offset = "0x8582710", VA = "0x188583910")]
	public KOHAGEEJJEC<CPJDJLDMJAA> IAMMKPNBJID()
	{
		return default(KOHAGEEJJEC<CPJDJLDMJAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x85833F0", Offset = "0x85821F0", VA = "0x1885833F0")]
	public KOHAGEEJJEC<AMBDGHOOILP> CDOEBOJJGKD()
	{
		return default(KOHAGEEJJEC<AMBDGHOOILP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8583660", Offset = "0x8582460", VA = "0x188583660")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8583440", Offset = "0x8582240", VA = "0x188583440", Slot = "5")]
	public void EMLPGEIJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8584390", Offset = "0x8583190", VA = "0x188584390", Slot = "6")]
	private void LFGDJFPHPKJ(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xFFD440", Offset = "0xFFC240", VA = "0x180FFD440", Slot = "7")]
	private void HJBDBNLCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DHKLPGFNNLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct LHGCNDHLHII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public UniformTRS CLIIEFBGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public StandardRenderableVisualData IDELAOGFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GCFIDBADAPD ONHEEOKCMKO;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[OOIBNJCENBJ(Lifetime.LoadInstance)]
public struct BDFFGGCJFJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Entity OKCGKPEIJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NativeList<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeList<Entity> HMDGCANLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NativeParallelHashSet<Entity> BFBNJMLHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public NativeList<EFHLFJNDJJB> KKEIJBOOLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public NativeList<BPLOOPPGBOJ> NNLFKKEKIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeList<LHGCNDHLHII> JFMDGLLIGAO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x857CC50", Offset = "0x857BA50", VA = "0x18857CC50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x857CC60", Offset = "0x857BA60", VA = "0x18857CC60")]
	public void FFICDEPBOPL(bool FKCKOGLEONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RegisterService(typeof(NNDIKBJJCME), new string[] { })]
[ServiceLifetime(Lifetime.LoadInstance)]
internal class NNDIKBJJCME : HNJMCIHMAGA, IHLGGOCLGIA, BOIHHABJILH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[DependsOn]
	private DHKLPGFNNLG JFNBNLINNOF;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8593F60", Offset = "0x8592D60", VA = "0x188593F60", Slot = "4")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8593F10", Offset = "0x8592D10", VA = "0x188593F10", Slot = "5")]
	private void LFGDJFPHPKJ(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x130AE30", Offset = "0x1309C30", VA = "0x18130AE30", Slot = "6")]
	private void HJBDBNLCEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NNDIKBJJCME()
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[SystemEnabledLifetime(Lifetime.OMRoom)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	public class PostDeserializeBakeShapesSystem : PLNFHAJCGIN, CMKJLANCAGA
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
			public NativeParallelHashMap<int, ALLMNIBKHFE> primitiveToMeshTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public NativeArray<HMFEIACKGGE> primitiveDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8587500", Offset = "0x8586300", VA = "0x188587500", Slot = "4")]
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
			public NativeArray<BPLOOPPGBOJ> splinePointDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			[ReadOnly]
			public NativeArray<EFHLFJNDJJB> splinePointRangesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public NativeArray<LHGCNDHLHII> bakedSplineDataRW;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x85878A0", Offset = "0x85866A0", VA = "0x1885878A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x857E6D0", Offset = "0x857D4D0", VA = "0x18857E6D0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x85969E0", Offset = "0x85957E0", VA = "0x1885969E0")]
					get
					{
						return default(float3);
					}
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0x8596990", Offset = "0x8595790", VA = "0x188596990")]
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
				float3 POOBMELEPMG(quaternion rotation);
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000044")]
			private struct LegacyDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8591FC0", Offset = "0x8590DC0", VA = "0x188591FC0", Slot = "5")]
				public float3 CHMHJPLKLNM(quaternion rotation)
				{
					return default(float3);
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x8592360", Offset = "0x8591160", VA = "0x188592360", Slot = "4")]
				public float3 POOBMELEPMG(quaternion rotation)
				{
					return default(float3);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private struct NewDirectionFromRotation : IDirectionFromRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x8594500", Offset = "0x8593300", VA = "0x188594500", Slot = "4")]
				public float3 POOBMELEPMG(quaternion rotation)
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
			public NativeArray<EFHLFJNDJJB> splinePointRangesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public NativeArray<BPLOOPPGBOJ> splinePointDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public NativeArray<int> pointCountRW;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x85898C0", Offset = "0x85886C0", VA = "0x1885898C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x85889E0", Offset = "0x85877E0", VA = "0x1885889E0")]
			private void DBPJMCIGJKP(NativeList<PointSrcData> srcData, NativeList<BPLOOPPGBOJ> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8588420", Offset = "0x8587220", VA = "0x188588420")]
			public static Vector3 CEGKKOOMNOE(Vector3 fromDirection, Vector3 toDirection, Vector3 normal)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x858A3F0", Offset = "0x85891F0", VA = "0x18858A3F0")]
			public static quaternion GPLDKKABDJC(float3 direction, float3 normal)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x858A540", Offset = "0x8589340", VA = "0x18858A540")]
			private static quaternion JIOGALLDOEC(float3 axis, float angleDegrees, quaternion vector)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x858B620", Offset = "0x858A420", VA = "0x18858B620")]
			private static float3 LBEDPLDGBGA(float3 axis, float angleDegrees, float3 vector)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x858BC50", Offset = "0x858AA50", VA = "0x18858BC50")]
			private static quaternion NMHFHGILPPK(float3 axis, float angleDegrees)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x858B9E0", Offset = "0x858A7E0", VA = "0x18858B9E0")]
			private static BPLOOPPGBOJ MDMMACOPMHP(int idx, NativeList<PointSrcData> srcData)
			{
				return default(BPLOOPPGBOJ);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4448830", Offset = "0x4447630", VA = "0x184448830")]
			private void BDGMGJJLHML<T>(NativeArray<Entity> entities, NativeList<PointSrcData> points, float threshold, T dirFromRot) where T : struct, IDirectionFromRotation
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x858A770", Offset = "0x8589570", VA = "0x18858A770")]
			private void KLOJKJHHLOF(NativeList<PointSrcData> sourcePoints, NativeList<BPLOOPPGBOJ> result, float heightScale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x858A090", Offset = "0x8588E90", VA = "0x18858A090")]
			public static float FOLJLFGNEKK(float3 from, float3 to, float3 axis)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x858B7F0", Offset = "0x858A5F0", VA = "0x18858B7F0")]
			private static quaternion MCLDDPLFHMP(quaternion q1, quaternion q2, float t)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x858BD70", Offset = "0x858AB70", VA = "0x18858BD70")]
			private static BPLOOPPGBOJ ONBGAGIMHKA(PointSrcData point)
			{
				return default(BPLOOPPGBOJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x858BCE0", Offset = "0x858AAE0", VA = "0x18858BCE0")]
			private static BPLOOPPGBOJ ONBGAGIMHKA(float3 pos, quaternion rot, float radius)
			{
				return default(BPLOOPPGBOJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x858B580", Offset = "0x858A380", VA = "0x18858B580")]
			private static bool KOFIIJLEJLH(float3 v, float thresholdSq, [Out] float3 result)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x858A470", Offset = "0x8589270", VA = "0x18858A470")]
			private static float3 HCCPDMGMCBP(float3 v, float thresholdSq)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8589EE0", Offset = "0x8588CE0", VA = "0x188589EE0")]
			public static float3 FMJLNPNBDPA(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8588830", Offset = "0x8587630", VA = "0x188588830")]
			public static float3 CHMHJPLKLNM(quaternion rotation)
			{
				return default(float3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8587FC0", Offset = "0x8586DC0", VA = "0x188587FC0")]
			private static quaternion BJGNCBJOOJO(quaternion rot, float3 direction)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x858A210", Offset = "0x8589010", VA = "0x18858A210")]
			private static float GNHKGHDCDEG(float3 from, float3 to)
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
			[Cpp2IlInjected.Address(RVA = "0x8598D30", Offset = "0x8597B30", VA = "0x188598D30")]
			private void NAIPPLMNFCM(DynamicBuffer<LinkedEntityGroup> splineAndPoints, int entityInQueryIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8598C40", Offset = "0x8597A40", VA = "0x188598C40", Slot = "4")]
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
			public NativeList<BPLOOPPGBOJ> splinePointData;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x859A3C0", Offset = "0x85991C0", VA = "0x18859A3C0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x859A3B0", Offset = "0x85991B0", VA = "0x18859A3B0", Slot = "4")]
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
			public NativeList<BPLOOPPGBOJ> splinePointData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[ReadOnly]
			public NativeArray<int> pointEstimate;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x859A360", Offset = "0x8599160", VA = "0x18859A360")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x859A350", Offset = "0x8599150", VA = "0x18859A350", Slot = "4")]
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
			public NativeList<HMFEIACKGGE> data;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8587BF0", Offset = "0x85869F0", VA = "0x188587BF0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8587BE0", Offset = "0x85869E0", VA = "0x188587BE0", Slot = "4")]
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
			public NativeList<EFHLFJNDJJB> ranges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public NativeList<LHGCNDHLHII> bakedData;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8587DC0", Offset = "0x8586BC0", VA = "0x188587DC0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8587DB0", Offset = "0x8586BB0", VA = "0x188587DB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8599F30", Offset = "0x8598D30", VA = "0x188599F30")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8599F20", Offset = "0x8598D20", VA = "0x188599F20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly ALMLLDBPKBM log;

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
		private ACLEDFNEIEG replicationService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NKPGLIPFHAL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private DHKLPGFNNLG bakedShapeDataService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GPIMOLGELDE ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private EntityQuery PostDeserializeBakeShapesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85981B0", Offset = "0x8596FB0", VA = "0x1885981B0", Slot = "15")]
		public override void InitReferences(CKKEMANKHME services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8599A90", Offset = "0x8598890", VA = "0x188599A90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8599B80", Offset = "0x8598980", VA = "0x188599B80", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8599BE0", Offset = "0x85989E0", VA = "0x188599BE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8597E70", Offset = "0x8596C70", VA = "0x188597E70")]
		private JobHandle IGKDOEAGDIM(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85972F0", Offset = "0x85960F0", VA = "0x1885972F0")]
		private JobHandle CJHFJNJONJO(EntityQuery query, Entity sceneEntity, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8597A90", Offset = "0x8596890", VA = "0x188597A90")]
		private JobHandle ENNPHBNBMND(NativeArray<int> pointCount, NativeList<BPLOOPPGBOJ> splinePointData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8597DD0", Offset = "0x8596BD0", VA = "0x188597DD0")]
		private JobHandle KIDIPNDOPFO(NativeList<BPLOOPPGBOJ> splinePointData, NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8598F00", Offset = "0x8597D00", VA = "0x188598F00")]
		private JobHandle OJGCFPMPLLB(EntityQuery query, NativeList<EFHLFJNDJJB> splinePointRanges, NativeList<BPLOOPPGBOJ> splinePointData, NativeArray<int> pointCount, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8596A00", Offset = "0x8595800", VA = "0x188596A00")]
		private JobHandle BPFKGOGCDOO(EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8598780", Offset = "0x8597580", VA = "0x188598780")]
		private JobHandle LAINEFCGOBA(NativeArray<int> pointEstimate, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8597B30", Offset = "0x8596930", VA = "0x188597B30")]
		private JobHandle GKLOGBNGHEM(EntityQuery query, [Out] NativeList<Entity> primitivesEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<HMFEIACKGGE> primitiveData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8597030", Offset = "0x8595E30", VA = "0x188597030")]
		private JobHandle CAMIHOPCKJI(EntityQuery query, [Out] NativeList<Entity> splineEntities, [Out] NativeList<Entity> parentEntities, [Out] NativeList<EFHLFJNDJJB> splinePointRanges, [Out] NativeList<LHGCNDHLHII> splineBakedData, [Out] NativeParallelHashSet<Entity> uniqueParentEntities, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85993D0", Offset = "0x85981D0", VA = "0x1885993D0")]
		private JobHandle OPMFNCJOMCE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8596B20", Offset = "0x8595920", VA = "0x188596B20")]
		private JobHandle CAHPPMECDEE(EntityQuery query, NativeList<HMFEIACKGGE> primitiveData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8598250", Offset = "0x8597050", VA = "0x188598250")]
		private static NativeParallelHashMap<int, ALLMNIBKHFE> JDDGLPEPGNK()
		{
			return default(NativeParallelHashMap<int, ALLMNIBKHFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85988A0", Offset = "0x85976A0", VA = "0x1885988A0")]
		private JobHandle LHAFPEFJJGJ(EntityQuery query, NativeList<EFHLFJNDJJB> splinePointRanges, NativeList<BPLOOPPGBOJ> splinePointData, NativeList<LHGCNDHLHII> bakedSplineData, JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85979B0", Offset = "0x85967B0", VA = "0x1885979B0")]
		private JobHandle DKJKDPKBMGE(EntityCommandBuffer.ParallelWriter ecbWriter, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8597A90", Offset = "0x8596890", VA = "0x188597A90")]
		private JobHandle GOLFBDNHLAK(NativeArray<int> pointCount, NativeList<BPLOOPPGBOJ> splinePointData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8597DD0", Offset = "0x8596BD0", VA = "0x188597DD0")]
		private JobHandle IGKCJELBCIO(NativeList<BPLOOPPGBOJ> splinePointData, NativeArray<int> pointEstimate, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8598E10", Offset = "0x8597C10", VA = "0x188598E10")]
		private JobHandle MEFAPKHFACC(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> entities, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<HMFEIACKGGE> data, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8598670", Offset = "0x8597470", VA = "0x188598670")]
		private JobHandle KGICMDPMKCJ(EntityQueryInJob queryInJob, EntityTypeHandle entityTypeHandle, ComponentTypeHandle<ParentData> parentTypeHandle, NativeList<Entity> splines, NativeList<Entity> parents, NativeParallelHashSet<Entity> uniqueParents, NativeList<EFHLFJNDJJB> ranges, NativeList<LHGCNDHLHII> bakedData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8599D50", Offset = "0x8598B50", VA = "0x188599D50")]
		private JobHandle PKEBPHCMOHE(NativeList<Entity> splineParents, NativeList<Entity> splineEntities, EntityCommandBuffer ecb, BufferFromEntity<ChildBuffer> childrenFromEntity, BufferFromEntity<AuthoredChildBuffer> authoredChildrenFromEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8599750", Offset = "0x8598550", VA = "0x188599750", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
		public PostDeserializeBakeShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CLEBCINCNDE : MECAHDPAGBH, CMKJLANCAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DHKLPGFNNLG JFNBNLINNOF;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x857E5D0", Offset = "0x857D3D0", VA = "0x18857E5D0", Slot = "14")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x857E620", Offset = "0x857D420", VA = "0x18857E620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
	public CLEBCINCNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
[AlwaysUpdateSystem]
public class DDHGGLHEBEF : PLNFHAJCGIN, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct NINBKPCAGGJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private EntityManager OPLCAABCINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private BBDDOHKDGIJ<T> GPGPOLEHPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int JJJJBEGKNIN;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (Entity parent, Transform containerWrapper, NativeArray<T> descriptors) BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x59870A0", Offset = "0x5985EA0", VA = "0x1859870A0")]
			get
			{
				return default((Entity, Transform, NativeArray<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x59879E0", Offset = "0x59867E0", VA = "0x1859879E0")]
		public NINBKPCAGGJ(EntityManager OPLCAABCINH, BBDDOHKDGIJ<T> GPGPOLEHPBC, NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4B1F2C0", Offset = "0x4B1E0C0", VA = "0x184B1F2C0")]
		public NINBKPCAGGJ<T> OLGNAIIDMLF()
		{
			return default(NINBKPCAGGJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5987040", Offset = "0x5985E40", VA = "0x185987040")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ALMLLDBPKBM NBPMLPGBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private BKHEGJALGFC DBPJJCFIOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DHKLPGFNNLG JFNBNLINNOF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8580730", Offset = "0x857F530", VA = "0x188580730", Slot = "15")]
	public override void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8581310", Offset = "0x8580110", VA = "0x188581310")]
	public void JNCODDOGHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x85821B0", Offset = "0x8580FB0", VA = "0x1885821B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x857F590", Offset = "0x857E390", VA = "0x18857F590")]
	private void IGLCIIALKFI(AMBDGHOOILP JDFCBBCKOGJ, Mesh[] AIIDMPLADMN, NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3B55200", Offset = "0x3B54000", VA = "0x183B55200")]
	private NINBKPCAGGJ<T> MJPPNJAJOLK<T>(BBDDOHKDGIJ<T> GPGPOLEHPBC, NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG) where T : struct
	{
		return default(NINBKPCAGGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x857E810", Offset = "0x857D610", VA = "0x18857E810")]
	private void ACFCBNMPNDN(Transform PJGOIMBEKPK, NativeArray<KDDALIMPNOH> IDMCLBHGDAN, LIJJHMMHNOE<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x857EB90", Offset = "0x857D990", VA = "0x18857EB90")]
	private void COKOBOGIIMM(Transform PJGOIMBEKPK, NativeArray<PDPMCOKBLPK> FHKLFDHIMHL, LIJJHMMHNOE<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8581770", Offset = "0x8580570", VA = "0x188581770")]
	private void KPNPHLKGKIM(Transform PJGOIMBEKPK, NativeArray<KALBJFILOAD> LMMLOPMDKED, LIJJHMMHNOE<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8581340", Offset = "0x8580140", VA = "0x188581340")]
	private void KAJIOPEMOEK(Transform PJGOIMBEKPK, NativeArray<AAADMPEKIMD> AIIDMPLADMN, Mesh[] HGMJFMDEKDD, LIJJHMMHNOE<GameObject> EBCPGCCPGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x857F050", Offset = "0x857DE50", VA = "0x18857F050")]
	private static void DICBHLBLBLJ(NativeParallelHashSet<Entity> ALJPELHALEH, NativeParallelHashSet<Entity> PPHJDCHEJLO, NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8580670", Offset = "0x857F470", VA = "0x188580670")]
	private static void IIAJLEKDCFO(NativeList<Entity> NGGCNGNMEBF, NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x85807B0", Offset = "0x857F5B0", VA = "0x1885807B0")]
	private NativeParallelHashMap<Entity, JKKMMEPDCOB> JLPOELAFDDK(DHKLPGFNNLG.AKOJGDNADHK BIHMLLLOMPH, KOHAGEEJJEC<CPJDJLDMJAA> GHOGNJOECFC, List<GameObject> EBCPGCCPGNC)
	{
		return default(NativeParallelHashMap<Entity, JKKMMEPDCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8581B60", Offset = "0x8580960", VA = "0x188581B60")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> NDLLMIFLNLD(Entity IFKEGLICNEN)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8581C60", Offset = "0x8580A60", VA = "0x188581C60")]
	private void OEDKDNPDOOA(NativeList<Entity> DCPBADMIFGO, NativeList<Entity> BGKKIFOEJBA, NativeParallelHashMap<Entity, JKKMMEPDCOB> OHGHHICEIPL, NativeList<EFHLFJNDJJB> AACLLMOMEJC, NativeList<BPLOOPPGBOJ> NKAACLDGDPC, NativeList<LHGCNDHLHII> GKADJBFEPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x857F1A0", Offset = "0x857DFA0", VA = "0x18857F1A0")]
	private void EPLIJNOGMCD(NativeList<Entity> ALJPELHALEH, NativeList<Entity> HMDGCANLOCL, NativeParallelHashMap<Entity, JKKMMEPDCOB> OHGHHICEIPL, NativeList<HMFEIACKGGE> GKENHHBCDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x857C030", Offset = "0x857AE30", VA = "0x18857C030")]
	public DDHGGLHEBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class FICIEALFCPC : NBLJMAGCCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly UniformTRS CLIIEFBGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly PLCNDJEJBLF PJGOIMBEKPK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GameObject HBEFENOINDF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public UniformTRS GOGCFENDHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8585380", Offset = "0x8584180", VA = "0x188585380", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Vector3 JOIDANEOEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85855A0", Offset = "0x85843A0", VA = "0x1885855A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Matrix4x4 LEBCKMOIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8585690", Offset = "0x8584490", VA = "0x188585690", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Vector3 PCCJPPJLNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8585460", Offset = "0x8584260", VA = "0x188585460", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8585550", Offset = "0x8584350", VA = "0x188585550", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Quaternion CJLKBFOFGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8585500", Offset = "0x8584300", VA = "0x188585500", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8585640", Offset = "0x8584440", VA = "0x188585640", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private Vector3 CJEJKBLCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x85854B0", Offset = "0x85842B0", VA = "0x1885854B0", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Vector3 JFPMHLPGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85856E0", Offset = "0x85844E0", VA = "0x1885856E0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private Vector3 NMFFJFDEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85855F0", Offset = "0x85843F0", VA = "0x1885855F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8585730", Offset = "0x8584530", VA = "0x188585730")]
	public FICIEALFCPC(UniformTRS CLIIEFBGOBF, PLCNDJEJBLF PJGOIMBEKPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class ILFPEEAIJNH : FICIEALFCPC, MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly float IDDADLBOLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly float3 MPGMCEPNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly BEIEMLGIDNI BAGAAFAGDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PFNNFGPAHBA IPGCKMEFIPB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private FHLDPOMNGOB BBJOFAODNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x858EF60", Offset = "0x858DD60", VA = "0x18858EF60", Slot = "17")]
		get
		{
			return default(FHLDPOMNGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private UniformTRS JJFKKKPNLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x858EE30", Offset = "0x858DC30", VA = "0x18858EE30", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private float DGGCLGGDHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAE8A00", Offset = "0xAE7800", VA = "0x180AE8A00", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private Vector3 KBDLGNKGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x858EF10", Offset = "0x858DD10", VA = "0x18858EF10", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private BEIEMLGIDNI CKNHPDLNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB1E560", Offset = "0xB1D360", VA = "0x180B1E560", Slot = "21")]
		get
		{
			return default(BEIEMLGIDNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private PFNNFGPAHBA GKHMCIMLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x14AEA20", Offset = "0x14AD820", VA = "0x1814AEA20", Slot = "22")]
		get
		{
			return default(PFNNFGPAHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool KOALPEGONCO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CGJEENDEDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x858EFB0", Offset = "0x858DDB0", VA = "0x18858EFB0")]
	protected ILFPEEAIJNH(UniformTRS CLIIEFBGOBF, PLCNDJEJBLF PJGOIMBEKPK, float IDDADLBOLCF, float3 MPGMCEPNBNO, BEIEMLGIDNI BAGAAFAGDHI, PFNNFGPAHBA IPGCKMEFIPB)
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
public abstract class HOIFDDDCMMI : NBLJMAGCCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly CLPADLABDGI JIKGGNOOJMH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	protected PLCNDJEJBLF DJIEKFAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1309DE0", Offset = "0x1308BE0", VA = "0x181309DE0")]
		get
		{
			return default(PLCNDJEJBLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	protected Entity CEMCFJKCGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x858C4A0", Offset = "0x858B2A0", VA = "0x18858C4A0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	protected NKPGLIPFHAL HHDKFMGHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x858C4C0", Offset = "0x858B2C0", VA = "0x18858C4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	protected AEBDOBPMKGB MFLMOIICLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x858CA10", Offset = "0x858B810", VA = "0x18858CA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	protected LMNDMENDAKD KMPLMGBFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x858CD40", Offset = "0x858BB40", VA = "0x18858CD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GameObject HBEFENOINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x858CF70", Offset = "0x858BD70", VA = "0x18858CF70", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public UniformTRS GOGCFENDHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1343470", Offset = "0x1342270", VA = "0x181343470", Slot = "8")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private Vector3 JOIDANEOEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x858C920", Offset = "0x858B720", VA = "0x18858C920", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Matrix4x4 LEBCKMOIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x858CDD0", Offset = "0x858BBD0", VA = "0x18858CDD0", Slot = "9")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector3 PCCJPPJLNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x858C4D0", Offset = "0x858B2D0", VA = "0x18858C4D0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x858C810", Offset = "0x858B610", VA = "0x18858C810", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Quaternion CJLKBFOFGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x858C6F0", Offset = "0x858B4F0", VA = "0x18858C6F0", Slot = "6")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x858CC30", Offset = "0x858BA30", VA = "0x18858CC30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector3 CJEJKBLCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x858C600", Offset = "0x858B400", VA = "0x18858C600", Slot = "11")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector3 JFPMHLPGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x858CFA0", Offset = "0x858BDA0", VA = "0x18858CFA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector3 NMFFJFDEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x858CA70", Offset = "0x858B870", VA = "0x18858CA70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xF6D660", Offset = "0xF6C460", VA = "0x180F6D660")]
	protected HOIFDDDCMMI(CLPADLABDGI MPOBGGNJMLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x858CF40", Offset = "0x858BD40", VA = "0x18858CF40")]
	public static FHLDPOMNGOB MIDAFINGFAP(HOIFDDDCMMI DDCPKPIHIOM)
	{
		return default(FHLDPOMNGOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LFILDMCPGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x859BD20", Offset = "0x859AB20", VA = "0x18859BD20")]
	public static void IPFJEHLGMFJ(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JPCJOAMMCBH
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x859B320", Offset = "0x859A120", VA = "0x18859B320")]
	public static void ECENJOIJCBI(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH, DBDEJHBHIBB AEBEDMHDKKF, NKPGLIPFHAL HNCOOFAGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x859BA10", Offset = "0x859A810", VA = "0x18859BA10")]
	public static void GCNHOJLHNAH(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH, DBDEJHBHIBB AEBEDMHDKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x859B990", Offset = "0x859A790", VA = "0x18859B990")]
	public static NativeList<Entity> EHBKHBGGNCH(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x859B9D0", Offset = "0x859A7D0", VA = "0x18859B9D0")]
	public static NativeList<Entity> FILIBPFOKJO(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x859B730", Offset = "0x859A530", VA = "0x18859B730")]
	private static NativeList<Entity> EHBKHBGGNCH(NativeArray<Entity> ALJPELHALEH, EntityManager OPLCAABCINH, bool FEFPOHGLBAH)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class CMDGBJACPCM : HOIFDDDCMMI, MONDPKCLBPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float IDDADLBOLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Vector3 MPGMCEPNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private BEIEMLGIDNI BAGAAFAGDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PFNNFGPAHBA IPGCKMEFIPB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	protected EntityManager CDPCMDMNAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x859B1A0", Offset = "0x8599FA0", VA = "0x18859B1A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	protected IJIJHKDIMIJ FDDNDPHMAON
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x859B230", Offset = "0x859A030", VA = "0x18859B230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	protected ShapeConfigData CIENENHNGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x859B0B0", Offset = "0x8599EB0", VA = "0x18859B0B0")]
		get
		{
			return default(ShapeConfigData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private FHLDPOMNGOB BBJOFAODNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x858CF40", Offset = "0x858BD40", VA = "0x18858CF40", Slot = "17")]
		get
		{
			return default(FHLDPOMNGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private float DGGCLGGDHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAE7AE0", Offset = "0xAE68E0", VA = "0x180AE7AE0", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private Vector3 KBDLGNKGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x141AB00", Offset = "0x1419900", VA = "0x18141AB00", Slot = "20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private BEIEMLGIDNI CKNHPDLNDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30", Slot = "21")]
		get
		{
			return default(BEIEMLGIDNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private PFNNFGPAHBA GKHMCIMLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0", Slot = "22")]
		get
		{
			return default(PFNNFGPAHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private UniformTRS JJFKKKPNLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x859B080", Offset = "0x8599E80", VA = "0x18859B080", Slot = "18")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool CGJEENDEDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool KOALPEGONCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x859B290", Offset = "0x859A090", VA = "0x18859B290")]
	protected CMDGBJACPCM(CLPADLABDGI MPOBGGNJMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x859AEF0", Offset = "0x8599CF0", VA = "0x18859AEF0", Slot = "26")]
	public virtual void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract UnityEngine.Hash128 ComputeHash();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SystemEnabledLifetime(Lifetime.LoadInstance)]
public abstract class PLNFHAJCGIN : MECAHDPAGBH, CMKJLANCAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected NKPGLIPFHAL HNCOOFAGEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private CEMAGBAFCCI IHDHFEFDGDE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected DBDEJHBHIBB ALGLKLLAEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x859C270", Offset = "0x859B070", VA = "0x18859C270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected CNCKGAMCPLB FMLHBHEAHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x859C380", Offset = "0x859B180", VA = "0x18859C380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected bool JNBFLNLOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x859C2C0", Offset = "0x859B0C0", VA = "0x18859C2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x859C200", Offset = "0x859B000", VA = "0x18859C200", Slot = "15")]
	public virtual void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
	protected PLNFHAJCGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class NKHCMDEGIMP
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x859BFC0", Offset = "0x859ADC0", VA = "0x18859BFC0")]
	public static void AAGBGHHCPCP(NativeArray<Entity> DCPBADMIFGO, EntityManager OPLCAABCINH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3396989378
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x859C590", Offset = "0x859B390", VA = "0x18859C590")]
	public static void BHCFGFEPANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x859C810", Offset = "0x859B610", VA = "0x18859C810")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class NCNPCPEELGF : ContainerPropertyBag<CIGIEBPPDFO>
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x859BF60", Offset = "0x859AD60", VA = "0x18859BF60")]
	public NCNPCPEELGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class BIEBCKGLBEL : ContainerPropertyBag<KOCEIHEODHC>
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x859AE90", Offset = "0x8599C90", VA = "0x18859AE90")]
	public BIEBCKGLBEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class IMANKMDDPGD : ContainerPropertyBag<BDFCAKMIPAH>
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x859B2C0", Offset = "0x859A0C0", VA = "0x18859B2C0")]
	public IMANKMDDPGD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x859C3D0", Offset = "0x859B1D0", VA = "0x18859C3D0")]
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
