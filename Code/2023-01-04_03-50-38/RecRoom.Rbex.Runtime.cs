using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class KCFPEDJFGKM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string IKKJEMGHEFN = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float ELLHGJHPHGE = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float OIEEFJKJBKD = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float CNNMIGDIIHI = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public KCFPEDJFGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CKLJAPHNLKM(RigidbodyEx BAEIHEKDJGL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void EFJJLAHIMJH(RigidbodyEx BAEIHEKDJGL, bool PHAEAKBOIBF = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OKBCKLHECLO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IFCEMEGFPJI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AJDKHDDFJDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KNJDJLMMODA : MKGJHDNFCEE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ONPGGECMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GHNFOEAAHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68E790", Offset = "0x68DB90", VA = "0x18068E790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "6")]
	public IJGKBFNAJFK DFDGIBGPDOL(float JAIDHIGECJH)
	{
		return default(IJGKBFNAJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
	public void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, Transform FPBLCKPMGJP, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "9")]
	public void OCGAHAILOMO(DJGKFKHPHGC JLBINKLPHKJ, [Optional] float? MPJOCGGPJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "10")]
	public void GKDAOIMBAHJ(DJGKFKHPHGC AGAKBPAIILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "11")]
	public IJGKBFNAJFK PMPBKHLIHAD(DJGKFKHPHGC JLBINKLPHKJ)
	{
		return default(IJGKBFNAJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "12")]
	public bool AMNIIINMFAK(DJGKFKHPHGC JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
	public void MGNABJMKJAC(DJGKFKHPHGC JLBINKLPHKJ, EHGHHHPBJOG DMIICIGAEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public KNJDJLMMODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NDGJMMLBLBO(typeof(CBADBDALOFD), new string[] { "Ignore", "Mock" })]
public class MGFEJJKDHPH : CBADBDALOFD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MAFFFHJPAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67C250", Offset = "0x67B650", VA = "0x18067C250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
	public void ICNCLAFMIAL(string CIMKHIELLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "6")]
	public void PGOPMONILOA(RigidbodyEx BCFNKEDGEDJ, Action LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "7")]
	public MKGJHDNFCEE JFJDCIILPDC(int CDOMPINHFID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void EIBLMLMDKEB(Vector3 EIKJBMMFJGP, float FBFKPGAOKDO, Color CNDGCCPDGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MGFEJJKDHPH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool MEFCNDPFEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MOEFOGMCKBP NLFKHOCCBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[EONKNFFEMMN(IJIMEJPPCDF.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[EONKNFFEMMN(IJIMEJPPCDF.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private IFCEMEGFPJI physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal MOEFOGMCKBP FOFFIIGGJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x60600B0", Offset = "0x605F4B0", VA = "0x1860600B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> BACNDKNLMGG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x719AB0", Offset = "0x718EB0", VA = "0x180719AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx EEONOFLFKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6062180", Offset = "0x6061580", VA = "0x186062180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx OGEOEBLKHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6062120", Offset = "0x6061520", VA = "0x186062120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx JFCNGAACNEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6062CE0", Offset = "0x60620E0", VA = "0x186062CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6064430", Offset = "0x6063830", VA = "0x186064430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform OIGIPMCMONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1072C70", Offset = "0x1072070", VA = "0x181072C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OAMKBJNKBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1072C70", Offset = "0x1072070", VA = "0x181072C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EHGHHHPBJOG FBLFOFCHFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6061E10", Offset = "0x6061210", VA = "0x186061E10")]
			get
			{
				return default(EHGHHHPBJOG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x60639D0", Offset = "0x6062DD0", VA = "0x1860639D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AKHFDGNNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6062390", Offset = "0x6061790", VA = "0x186062390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FNBKGIKELMP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6061FA0", Offset = "0x60613A0", VA = "0x186061FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IGLAABABGOP MPPOHEOFGPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6062330", Offset = "0x6061730", VA = "0x186062330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6063BE0", Offset = "0x6062FE0", VA = "0x186063BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public OCAOBGNCGFH GHDMHBNFFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x60622D0", Offset = "0x60616D0", VA = "0x1860622D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6063B70", Offset = "0x6062F70", VA = "0x186063B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MNNOGIBHHEH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x60621B0", Offset = "0x60615B0", VA = "0x1860621B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody AIKMBCIHNNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6062210", Offset = "0x6061610", VA = "0x186062210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OHOLAJEIPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6062060", Offset = "0x6061460", VA = "0x186062060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6063A90", Offset = "0x6062E90", VA = "0x186063A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OPFALFLNGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x105FC60", Offset = "0x105F060", VA = "0x18105FC60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x105F9C0", Offset = "0x105EDC0", VA = "0x18105F9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BGFEOHOAHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6062C80", Offset = "0x6062080", VA = "0x186062C80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BHCIOEAMLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6062C20", Offset = "0x6062020", VA = "0x186062C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x60643C0", Offset = "0x60637C0", VA = "0x1860643C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OGMFBNAEINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x60625F0", Offset = "0x60619F0", VA = "0x1860625F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6063E80", Offset = "0x6063280", VA = "0x186063E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KCCFOKBJFJI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x60623F0", Offset = "0x60617F0", VA = "0x1860623F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6063C50", Offset = "0x6063050", VA = "0x186063C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool FDGHFGMHACF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6063200", Offset = "0x6062600", VA = "0x186063200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6064970", Offset = "0x6063D70", VA = "0x186064970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 HEDDCKELFBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6062A00", Offset = "0x6061E00", VA = "0x186062A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6064190", Offset = "0x6063590", VA = "0x186064190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 EIKJBMMFJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6063340", Offset = "0x6062740", VA = "0x186063340")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode NIEDKAPHIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6062530", Offset = "0x6061930", VA = "0x186062530")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6063DA0", Offset = "0x60631A0", VA = "0x186063DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float JABOBOHPOHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x60620C0", Offset = "0x60614C0", VA = "0x1860620C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6063B00", Offset = "0x6062F00", VA = "0x186063B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints DMPHDKHPPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6062590", Offset = "0x6061990", VA = "0x186062590")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6063E10", Offset = "0x6063210", VA = "0x186063E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 DLJGNEFEBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6062D40", Offset = "0x6062140", VA = "0x186062D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 HGEMDGEGMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6062D40", Offset = "0x6062140", VA = "0x186062D40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6064740", Offset = "0x6063B40", VA = "0x186064740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CNFCMLDOGHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6062AE0", Offset = "0x6061EE0", VA = "0x186062AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6064270", Offset = "0x6063670", VA = "0x186064270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JEBHDDNDEDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x60631A0", Offset = "0x60625A0", VA = "0x1860631A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6064900", Offset = "0x6063D00", VA = "0x186064900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion FAKNCCABOAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6062E20", Offset = "0x6062220", VA = "0x186062E20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60644A0", Offset = "0x60638A0", VA = "0x1860644A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MOHFGOKIPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x60630C0", Offset = "0x60624C0", VA = "0x1860630C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6064820", Offset = "0x6063C20", VA = "0x186064820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 FNCLNMIEIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6062F00", Offset = "0x6062300", VA = "0x186062F00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6064580", Offset = "0x6063980", VA = "0x186064580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion KLPLGAAFPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6062FE0", Offset = "0x60623E0", VA = "0x186062FE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6064660", Offset = "0x6063A60", VA = "0x186064660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 EAMJDCGEMLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6063260", Offset = "0x6062660", VA = "0x186063260")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x60649E0", Offset = "0x6063DE0", VA = "0x1860649E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 IBINHIACJHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6062B40", Offset = "0x6061F40", VA = "0x186062B40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x60642E0", Offset = "0x60636E0", VA = "0x1860642E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BPNOJOBDHCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6062450", Offset = "0x6061850", VA = "0x186062450")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6063CC0", Offset = "0x60630C0", VA = "0x186063CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 PKHHPIFOLFB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6062920", Offset = "0x6061D20", VA = "0x186062920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x60640B0", Offset = "0x60634B0", VA = "0x1860640B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KHDOEBPONPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x60627E0", Offset = "0x6061BE0", VA = "0x1860627E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6063FD0", Offset = "0x60633D0", VA = "0x186063FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion IDNFPECKBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6062700", Offset = "0x6061B00", VA = "0x186062700")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6063EF0", Offset = "0x60632F0", VA = "0x186063EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 OFIHOJJMMAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6063500", Offset = "0x6062900", VA = "0x186063500")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 BOHOIAIALKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6063420", Offset = "0x6062820", VA = "0x186063420")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IFILKDBGJAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x60628C0", Offset = "0x6061CC0", VA = "0x1860628C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DGNLMJKGDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6062000", Offset = "0x6061400", VA = "0x186062000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ODENFPLCPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6061F40", Offset = "0x6061340", VA = "0x186061F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NGBGNGACAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6061EE0", Offset = "0x60612E0", VA = "0x186061EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AEKNHCIFPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6061DB0", Offset = "0x60611B0", VA = "0x186061DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ECHKEMFJGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6062650", Offset = "0x6061A50", VA = "0x186062650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool MMIGCPEOPKL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x710580", Offset = "0x70F980", VA = "0x180710580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CKLJAPHNLKM LHODPLFNBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6061CD0", Offset = "0x60610D0", VA = "0x186061CD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60638F0", Offset = "0x6062CF0", VA = "0x1860638F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EFJJLAHIMJH DLJJNPJJBLA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6061C60", Offset = "0x6061060", VA = "0x186061C60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6063880", Offset = "0x6062C80", VA = "0x186063880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CKLJAPHNLKM BOPPGLHMCFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x60619C0", Offset = "0x6060DC0", VA = "0x1860619C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60635E0", Offset = "0x60629E0", VA = "0x1860635E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CKLJAPHNLKM EOLJOLENJJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6061A30", Offset = "0x6060E30", VA = "0x186061A30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6063650", Offset = "0x6062A50", VA = "0x186063650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event CKLJAPHNLKM JMHMDIBAOFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6061B80", Offset = "0x6060F80", VA = "0x186061B80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60637A0", Offset = "0x6062BA0", VA = "0x1860637A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6061B10", Offset = "0x6060F10", VA = "0x186061B10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6063730", Offset = "0x6062B30", VA = "0x186063730")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CKLJAPHNLKM LPFMMFODAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6061BF0", Offset = "0x6060FF0", VA = "0x186061BF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6063810", Offset = "0x6062C10", VA = "0x186063810")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CKLJAPHNLKM HNLICJHEGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6061D40", Offset = "0x6061140", VA = "0x186061D40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6063960", Offset = "0x6062D60", VA = "0x186063960")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event CKLJAPHNLKM LKLBHBDHOFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6061AA0", Offset = "0x6060EA0", VA = "0x186061AA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60636C0", Offset = "0x6062AC0", VA = "0x1860636C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		internal void LPHGIEIOEPD(MOEFOGMCKBP BDGKEIOKECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6060040", Offset = "0x605F440", VA = "0x186060040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60600B0", Offset = "0x605F4B0", VA = "0x1860600B0")]
		private MOEFOGMCKBP BIGJLIGHMDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60606E0", Offset = "0x605FAE0", VA = "0x1860606E0")]
		private void KELJHIKJDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6060CD0", Offset = "0x60600D0", VA = "0x186060CD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6060BD0", Offset = "0x605FFD0", VA = "0x186060BD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60603A0", Offset = "0x605F7A0", VA = "0x1860603A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6060C70", Offset = "0x6060070", VA = "0x186060C70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6060D30", Offset = "0x6060130", VA = "0x186060D30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x605F6D0", Offset = "0x605EAD0", VA = "0x18605F6D0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6060DA0", Offset = "0x60601A0", VA = "0x186060DA0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6060340", Offset = "0x605F740", VA = "0x186060340")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6060B70", Offset = "0x605FF70", VA = "0x186060B70")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6061590", Offset = "0x6060990", VA = "0x186061590")]
		public void SetParent(RigidbodyEx IGDJJEECDAF, bool PHAEAKBOIBF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60610B0", Offset = "0x60604B0", VA = "0x1860610B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6060600", Offset = "0x605FA00", VA = "0x186060600")]
		public bool IsRigidbodyAncestor(RigidbodyEx LDBIMIKCADG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6060640", Offset = "0x605FA40", VA = "0x186060640")]
		public bool IsRigidbodyDescendant(RigidbodyEx NEHLJONEPAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x605F8F0", Offset = "0x605ECF0", VA = "0x18605F8F0")]
		public void AddInterpolationRestriction(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6060E10", Offset = "0x6060210", VA = "0x186060E10")]
		public void RemoveInterpolationRestriction(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6060160", Offset = "0x605F560", VA = "0x186060160")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x605F960", Offset = "0x605ED60", VA = "0x18605F960")]
		public void AddKinematic(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6060E80", Offset = "0x6060280", VA = "0x186060E80")]
		public void RemoveKinematic(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6061510", Offset = "0x6060910", VA = "0x186061510")]
		public void SetKinematic(object MJNGPHMPILM, bool NIFMDNMIGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6061410", Offset = "0x6060810", VA = "0x186061410")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DLDCBLIOEFE, Quaternion DJCHJBALDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6061310", Offset = "0x6060710", VA = "0x186061310")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 IOAMNOKKGAC, Quaternion CMEIICOJBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6060500", Offset = "0x605F900", VA = "0x186060500")]
		public Vector3 GetConstrainedVelocity(Vector3 EAMJDCGEMLP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6060400", Offset = "0x605F800", VA = "0x186060400")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BPNOJOBDHCP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x605F860", Offset = "0x605EC60", VA = "0x18605F860")]
		public void AddForce(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x605F740", Offset = "0x605EB40", VA = "0x18605F740")]
		public void AddForceAtPosition(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x605FA60", Offset = "0x605EE60", VA = "0x18605FA60")]
		public void AddTorque(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x605F9D0", Offset = "0x605EDD0", VA = "0x18605F9D0")]
		public void AddRelativeTorque(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60617F0", Offset = "0x6060BF0", VA = "0x1860617F0")]
		public Vector3 WorldToLocalVelocity(Vector3 GFENFADPBNA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6060A70", Offset = "0x605FE70", VA = "0x186060A70")]
		public Vector3 LocalToWorldVelocity(Vector3 IBINHIACJHK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60602E0", Offset = "0x605F6E0", VA = "0x1860602E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6060280", Offset = "0x605F680", VA = "0x186060280")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6060220", Offset = "0x605F620", VA = "0x186060220")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60601C0", Offset = "0x605F5C0", VA = "0x1860601C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6061210", Offset = "0x6060610", VA = "0x186061210")]
		public void ResetVelocityWorldSpace(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6061110", Offset = "0x6060510", VA = "0x186061110")]
		public void ResetVelocityLocalSpace(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6060FD0", Offset = "0x60603D0", VA = "0x186060FD0")]
		public void ResetLinearVelocityLocalSpace(Vector3 EPKHEMAGDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6061680", Offset = "0x6060A80", VA = "0x186061680")]
		public bool SweepTest(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6060680", Offset = "0x605FA80", VA = "0x186060680")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6061620", Offset = "0x6060A20", VA = "0x186061620")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6061790", Offset = "0x6060B90", VA = "0x186061790")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x605FAF0", Offset = "0x605EEF0", VA = "0x18605FAF0")]
		public void AddUnityRigidbody(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6060EF0", Offset = "0x60602F0", VA = "0x186060EF0")]
		public void RemoveUnityRigidbody(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x605FE10", Offset = "0x605F210", VA = "0x18605FE10")]
		public void ApplyForceVelocityChange(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x605FD10", Offset = "0x605F110", VA = "0x18605FD10")]
		public void ApplyAngularVelocityChange(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x605FF30", Offset = "0x605F330", VA = "0x18605FF30")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x605FC50", Offset = "0x605F050", VA = "0x18605FC50")]
		public bool AllowedScaleChange(float BJONIIADEJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x605FB60", Offset = "0x605EF60", VA = "0x18605FB60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx EONLKJMHCON, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6060F60", Offset = "0x6060360", VA = "0x186060F60")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6061940", Offset = "0x6060D40", VA = "0x186061940")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class OFEILJIOLLP
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x504C810", Offset = "0x504BC10", VA = "0x18504C810")]
	public static MOEFOGMCKBP FOFFIIGGJCL(this RigidbodyEx BCFNKEDGEDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JPIMKKACAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody DGOFHFLMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView DKHPAPAKJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 ICIKHPLKJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 KPGDKBFNDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public IFCEMEGFPJI DJKGDJKALKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DFLEEMDDNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool CAKADECPACD;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[NDGJMMLBLBO(typeof(MOCBKGLLLEF), new string[] { })]
public class JPMLANKLHCN : MOCBKGLLLEF, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LCCHFDCPEHE BLAHIPBNDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CBADBDALOFD GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LILHCMCOEBD IKEAIGGPMPA;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MMBJGKNLOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x503C780", Offset = "0x503BB80", VA = "0x18503C780", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CBADBDALOFD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LILHCMCOEBD PEEHJHPMOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x503C8C0", Offset = "0x503BCC0", VA = "0x18503C8C0", Slot = "10")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x503C310", Offset = "0x503B710", VA = "0x18503C310", Slot = "7")]
	public MOLBNKBNJLI BMPOHHMLPOH(RigidbodyEx BCFNKEDGEDJ)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x503C7D0", Offset = "0x503BBD0", VA = "0x18503C7D0")]
	private static MOLBNKBNJLI HIDCCFBCLMM(RigidbodyEx BCFNKEDGEDJ)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x503C5B0", Offset = "0x503B9B0", VA = "0x18503C5B0", Slot = "8")]
	public MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x503C650", Offset = "0x503BA50", VA = "0x18503C650", Slot = "9")]
	private RigidbodyEx EPIJKLCGKAK(GameObject GEMPPKOEIPE, JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JPMLANKLHCN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static PENMMECJMBL UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int DJHPJPKDPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int FGMLFNCEOBH;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x605F1B0", Offset = "0x605E5B0", VA = "0x18605F1B0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x605F1F0", Offset = "0x605E5F0", VA = "0x18605F1F0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x605F1D0", Offset = "0x605E5D0", VA = "0x18605F1D0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KAKCNEMJMJL, [Optional] UnityEngine.Object GKMHGIGLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KAKCNEMJMJL, [Optional] UnityEngine.Object GKMHGIGLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x605F2E0", Offset = "0x605E6E0", VA = "0x18605F2E0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ICOFFBDAKHN
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5039050", Offset = "0x5038450", VA = "0x185039050")]
	public static void EJEAKBJAMLO(this Rigidbody CLNIMFPKIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5038F40", Offset = "0x5038340", VA = "0x185038F40")]
	public static void EJEAKBJAMLO(this Rigidbody CLNIMFPKIAF, Vector3 KHDOEBPONPE, Quaternion IDNFPECKBBI, Vector3 GCFJJFPNJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50391A0", Offset = "0x50385A0", VA = "0x1850391A0")]
	public static void PAEJBJLOLIA(Vector3 EAMJDCGEMLP, Vector3 HBJDEILKJKB, out Vector3 HOKEJADDAEA, out Vector3 GPMLDNFKGHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HOPPFHHIJBC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class CPBLMBJLGCL : IGLAABABGOP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1421F80", Offset = "0x1421380", VA = "0x181421F80", Slot = "4")]
		public Vector3 DPGFPHPJNKG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1421F80", Offset = "0x1421380", VA = "0x181421F80", Slot = "5")]
		public Vector3 KIODBDOEPHD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CPBLMBJLGCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static IGLAABABGOP MHOOFFGNONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5038DB0", Offset = "0x50381B0", VA = "0x185038DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CMGALEDPEOD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGGHPEEMCDO(bool IFILKDBGJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAAHDKJPDKI(bool IFILKDBGJAA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CEEOOLNBEAB : IDisposable, DJGKFKHPHGC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COBCLAGHHHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
public interface LILHCMCOEBD
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJBGKFLLKGL AGFICOJOKMA(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCDDIDCNMEM OLMKBEOJODC(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLKCBOFCHOP GOGOHDMIFAP(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DJKOOKOCBBL FPHLJCEEMCP(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHJNFOLMBKE OFCGOGHHCDK(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CEEOOLNBEAB JHBNNELEDNF(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KHOEFPLAJFD ELPGNALAKAD(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LFDDJBANODG GBGJMGFKGNH(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CMGALEDPEOD FADNALMPLHJ(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NIHFMIHDEJO PKCPGPAMJKH(MOEFOGMCKBP BDGKEIOKECF);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HHKLONHDBCP FPIDOEFIGKO(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OKGPPOGBFMI AMMKHOJLEHJ(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HCDIAGKJOKB NGDEPNHKILK(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FFONHMBHMEF LOAAEMBOPCE(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DKAJJIAJAGC HPFNKKLNJCL(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON, MOCBKGLLLEF LHHJJDCDFNG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LFDDJBANODG
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NIHFMIHDEJO
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JHANLBAFJCE(Rigidbody DGOFHFLMDGM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IJBGKFLLKGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CKLJAPHNLKM BOPPGLHMCFB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event CKLJAPHNLKM EOLJOLENJJO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event EFJJLAHIMJH JHNMCLJNKGG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PPBMKPGGKEM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action MPAGNMJCFFA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MOEFOGMCKBP> PGBNNBOMPAM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MOEFOGMCKBP> HCJPLFLCKKA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action ANNLKPMJIDH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<MOEFOGMCKBP> JCKFCNBPMPB;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GHJLFEJPDIG(MOEFOGMCKBP CNMJLCOJOLA, bool PHAEAKBOIBF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PLKCBOFCHOP
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEPLEFNKCLC(MOEFOGMCKBP JFCNGAACNEO, object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCGHBFCIDFG(object MJNGPHMPILM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FFONHMBHMEF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CKLJAPHNLKM NDICODEJHMO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MNDDCBFDCAO();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LHNHDPFMEIA();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OAGFHHDJOIA();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHANLBAFJCE(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IKBDJGHAHAP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HCDIAGKJOKB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NIDJDKKDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	OMABPCEAJCN LEEEKIFGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AIENKBIMAED(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMBEGJNJAFJ(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPIJJDDGIJN(MOEFOGMCKBP BCFNKEDGEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEEGCBFLJPC(MOEFOGMCKBP BCFNKEDGEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBFPKEEJCOM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KHOEFPLAJFD
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> POMBOBCBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CKLJAPHNLKM MEHLGLPEDBB;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPIPAEBMEKC(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMHAINEJFMJ(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable IOAAKHBHNGE();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DODLGDLPNBJ(Rigidbody GAOHKMMENID);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JHANLBAFJCE(Rigidbody DGOFHFLMDGM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OKGPPOGBFMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CKLJAPHNLKM PNGOIJCLLAF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDEMAKMNMLM(MOEFOGMCKBP JFCNGAACNEO);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDOJIPNNAPF(MOEFOGMCKBP JFCNGAACNEO);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DKAJJIAJAGC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PAHIOOGCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHANLBAFJCE(Rigidbody DGOFHFLMDGM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DJKOOKOCBBL
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHANLBAFJCE(Rigidbody DGOFHFLMDGM);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EEEIHNFIBFO
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx PFFCNPKPMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EHJNFOLMBKE
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event CKLJAPHNLKM OPHAOHPDLJL;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPFDKFMNBJE();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNMIICJHFIP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANCJCOBPGIM();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPAFANIKDAB();

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNJBHKHMMDN();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNBPEOADCFI(bool FBMIBFGCBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HHKLONHDBCP
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLOKMFJCJPL(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALOKAEHFLOF(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODFAIAHCPNM();

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JIKCGGCJNKF();

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEBJIGNJHJP();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EIKELGJGOHG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface JCDDIDCNMEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCHCHPECDKN(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EIDMJDCHHEF();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FCLOHKDNJBE();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BPOMELIBGGB();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DKFBDOCLLHK();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 HBHKKFLNBPP(Vector3 BPNOJOBDHCP);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KPCKJBEFMPA(Vector3 EAMJDCGEMLP);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NNHLDFPJICN(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MGMFBINMOAG(Vector3 MEPDHFGMHPN);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
public interface CBADBDALOFD
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MAFFFHJPAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNCLAFMIAL(string CIMKHIELLCI);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PGOPMONILOA(RigidbodyEx BCFNKEDGEDJ, Action LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MKGJHDNFCEE JFJDCIILPDC(int CDOMPINHFID);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIBLMLMDKEB(Vector3 EIKJBMMFJGP, float FBFKPGAOKDO, Color CNDGCCPDGDM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
public interface MOCBKGLLLEF
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	CBADBDALOFD JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	LILHCMCOEBD PEEHJHPMOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool MMBJGKNLOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MOLBNKBNJLI BMPOHHMLPOH(RigidbodyEx BCFNKEDGEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "5")]
	internal RigidbodyEx EFAFJBCIOKI(GameObject GEMPPKOEIPE, [Optional] JPIMKKACAGA PNMIIEJFOON);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OCAOBGNCGFH
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLELDGLJMAF(Vector3 ECKHODNFJMI);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDKPEJGDLFI(Vector3 BPNOJOBDHCP);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BKBCJGHNGLH(Vector3 ECKHODNFJMI);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNEKMDLPEIE(Vector3 BPNOJOBDHCP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IGLAABABGOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DPGFPHPJNKG();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 KIODBDOEPHD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MOEFOGMCKBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx HOJFEHABDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject NEHBINLAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> OPDAKEENMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool ODENFPLCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool NGBGNGACAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool AEKNHCIFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform OIGIPMCMONG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform OAMKBJNKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GBOLJIPIHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float OGBGBAOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float EFFCFAKACCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion GMFJBDNIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 ADLALFFNAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion IGNNLHFDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event CKLJAPHNLKM BOPPGLHMCFB;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event CKLJAPHNLKM EOLJOLENJJO;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event EFJJLAHIMJH JHNMCLJNKGG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event CKLJAPHNLKM PNGOIJCLLAF;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event CKLJAPHNLKM JMHMDIBAOFA;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event CKLJAPHNLKM OPHAOHPDLJL;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event CKLJAPHNLKM HNNHONJIJBO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event CKLJAPHNLKM LKLBHBDHOFM;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void COBCLAGHHHJ();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void INNPMKNCCOP();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BEEEBNOHKDJ();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void ANCJCOBPGIM();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void DIIDILKFGEG();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void GHJLFEJPDIG(MOEFOGMCKBP IGDJJEECDAF, bool PHAEAKBOIBF = false);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void OBNNPADEOAG(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void OJCCDEGMEKM(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DKFBDOCLLHK();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FCLOHKDNJBE();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void EIDMJDCHHEF();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MGMFBINMOAG(Vector3 MEPDHFGMHPN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KPCKJBEFMPA(Vector3 IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 HBHKKFLNBPP(Vector3 IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void BPOMELIBGGB();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void GGAGIEHFLDD(MOEFOGMCKBP EONLKJMHCON, object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EADAKDNJPLE(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LHNHDPFMEIA();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void MNDDCBFDCAO();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void OAGFHHDJOIA();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool KPFDKFMNBJE();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void NNJBHKHMMDN();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable IOAAKHBHNGE();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void EPIPAEBMEKC(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void IMHAINEJFMJ(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void OPFFGAEBOEA(Vector3 DLDCBLIOEFE, Quaternion DJCHJBALDHE);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MNMLHPJJJML(Vector3 IOAMNOKKGAC, Quaternion CMEIICOJBKI);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool KAIMLNCPGNN(float BJONIIADEJC);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FHLCJMDDJOP(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void FEGCFIPBGGB(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void DLOKMFJCJPL(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ALOKAEHFLOF(object MJNGPHMPILM);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void IKBDJGHAHAP();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LPOINMJCEJA : MOEFOGMCKBP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly MOCBKGLLLEF LHHJJDCDFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IJBGKFLLKGL MIKBKPPJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal HCDIAGKJOKB FPJDDCKGNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal OKGPPOGBFMI MLGFPIININH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal JCDDIDCNMEM EAMJDCGEMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PLKCBOFCHOP BCMDGNEMPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal FFONHMBHMEF BLAOHKMGAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DJKOOKOCBBL OGEKEOHPCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NIHFMIHDEJO NODLOHCCNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal EHJNFOLMBKE DGDLKKPKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal CEEOOLNBEAB BCCODDEFFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal KHOEFPLAJFD KFLHBLFAJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal LFDDJBANODG POKKNFLDEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal DKAJJIAJAGC FDPHDIGCCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal HHKLONHDBCP DGOFHFLMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal CMGALEDPEOD KEMGLOKJAFE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx HOJFEHABDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x67EE20", Offset = "0x67E220", VA = "0x18067EE20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7F79F0", Offset = "0x7F6DF0", VA = "0x1807F79F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject NEHBINLAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6B46A0", Offset = "0x6B3AA0", VA = "0x1806B46A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x914EA0", Offset = "0x9142A0", VA = "0x180914EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5041070", Offset = "0x5040470", VA = "0x185041070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> OPDAKEENMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5041330", Offset = "0x5040730", VA = "0x185041330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5040CD0", Offset = "0x50400D0", VA = "0x185040CD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5041DE0", Offset = "0x50411E0", VA = "0x185041DE0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5042DB0", Offset = "0x50421B0", VA = "0x185042DB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5040270", Offset = "0x503F670", VA = "0x185040270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5041D90", Offset = "0x5041190", VA = "0x185041D90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5040810", Offset = "0x503FC10", VA = "0x185040810", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5042230", Offset = "0x5041630", VA = "0x185042230", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x503DE10", Offset = "0x503D210", VA = "0x18503DE10", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5040D20", Offset = "0x5040120", VA = "0x185040D20", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x503E510", Offset = "0x503D910", VA = "0x18503E510", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x503F130", Offset = "0x503E530", VA = "0x18503F130", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5043C10", Offset = "0x5043010", VA = "0x185043C10", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x503DCB0", Offset = "0x503D0B0", VA = "0x18503DCB0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5040940", Offset = "0x503FD40", VA = "0x185040940", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5042770", Offset = "0x5041B70", VA = "0x185042770", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5042A20", Offset = "0x5041E20", VA = "0x185042A20", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5040870", Offset = "0x503FC70", VA = "0x185040870", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x503E850", Offset = "0x503DC50", VA = "0x18503E850", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x503F550", Offset = "0x503E950", VA = "0x18503F550", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x503FD30", Offset = "0x503F130", VA = "0x18503FD30", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5042F80", Offset = "0x5042380", VA = "0x185042F80", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x503E010", Offset = "0x503D410", VA = "0x18503E010", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool ODENFPLCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x503EEA0", Offset = "0x503E2A0", VA = "0x18503EEA0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool NGBGNGACAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x503E1B0", Offset = "0x503D5B0", VA = "0x18503E1B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool AEKNHCIFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x50419D0", Offset = "0x5040DD0", VA = "0x1850419D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5042970", Offset = "0x5041D70", VA = "0x185042970", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5042160", Offset = "0x5041560", VA = "0x185042160", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5041790", Offset = "0x5040B90", VA = "0x185041790", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x50415F0", Offset = "0x50409F0", VA = "0x1850415F0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5040460", Offset = "0x503F860", VA = "0x185040460", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x503E0E0", Offset = "0x503D4E0", VA = "0x18503E0E0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x50401E0", Offset = "0x503F5E0", VA = "0x1850401E0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x50425E0", Offset = "0x50419E0", VA = "0x1850425E0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5040FC0", Offset = "0x50403C0", VA = "0x185040FC0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5041900", Offset = "0x5040D00", VA = "0x185041900", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x50416C0", Offset = "0x5040AC0", VA = "0x1850416C0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x503FE00", Offset = "0x503F200", VA = "0x18503FE00", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x50439B0", Offset = "0x5042DB0", VA = "0x1850439B0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5043230", Offset = "0x5042630", VA = "0x185043230", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x503DFB0", Offset = "0x503D3B0", VA = "0x18503DFB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x50438D0", Offset = "0x5042CD0", VA = "0x1850438D0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x503E7F0", Offset = "0x503DBF0", VA = "0x18503E7F0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x503F620", Offset = "0x503EA20", VA = "0x18503F620", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x503FED0", Offset = "0x503F2D0", VA = "0x18503FED0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x503DF60", Offset = "0x503D360", VA = "0x18503DF60", Slot = "52")]
		get
		{
			return default(CCMIJJFALNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x503EEF0", Offset = "0x503E2F0", VA = "0x18503EEF0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x503F3F0", Offset = "0x503E7F0", VA = "0x18503F3F0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform OIGIPMCMONG
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x503F810", Offset = "0x503EC10", VA = "0x18503F810", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform OAMKBJNKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x503F810", Offset = "0x503EC10", VA = "0x18503F810", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 GBOLJIPIHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x5042530", Offset = "0x5041930", VA = "0x185042530", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5042480", Offset = "0x5041880", VA = "0x185042480", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float OGBGBAOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x503F4F0", Offset = "0x503E8F0", VA = "0x18503F4F0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x503E5D0", Offset = "0x503D9D0", VA = "0x18503E5D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float EFFCFAKACCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x503EA60", Offset = "0x503DE60", VA = "0x18503EA60", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5042280", Offset = "0x5041680", VA = "0x185042280", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion GMFJBDNIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x50403B0", Offset = "0x503F7B0", VA = "0x1850403B0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5043920", Offset = "0x5042D20", VA = "0x185043920", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 ADLALFFNAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x503F0E0", Offset = "0x503E4E0", VA = "0x18503F0E0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x50413E0", Offset = "0x50407E0", VA = "0x1850413E0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion IGNNLHFDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5040230", Offset = "0x503F630", VA = "0x185040230", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x503F3B0", Offset = "0x503E7B0", VA = "0x18503F3B0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x503F6D0", Offset = "0x503EAD0", VA = "0x18503F6D0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5041160", Offset = "0x5040560", VA = "0x185041160", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5042F30", Offset = "0x5042330", VA = "0x185042F30", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5042840", Offset = "0x5041C40", VA = "0x185042840", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x503DE60", Offset = "0x503D260", VA = "0x18503DE60", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5040D70", Offset = "0x5040170", VA = "0x185040D70", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x503E3D0", Offset = "0x503D7D0", VA = "0x18503E3D0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CKLJAPHNLKM BOPPGLHMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x503F490", Offset = "0x503E890", VA = "0x18503F490", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5043050", Offset = "0x5042450", VA = "0x185043050", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CKLJAPHNLKM EOLJOLENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x50433E0", Offset = "0x50427E0", VA = "0x1850433E0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5043760", Offset = "0x5042B60", VA = "0x185043760", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EFJJLAHIMJH JHNMCLJNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5043BB0", Offset = "0x5042FB0", VA = "0x185043BB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x503E570", Offset = "0x503D970", VA = "0x18503E570", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event CKLJAPHNLKM PNGOIJCLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5041490", Offset = "0x5040890", VA = "0x185041490", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5042AF0", Offset = "0x5041EF0", VA = "0x185042AF0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event CKLJAPHNLKM JMHMDIBAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x50429C0", Offset = "0x5041DC0", VA = "0x1850429C0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x503F870", Offset = "0x503EC70", VA = "0x18503F870", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event CKLJAPHNLKM OPHAOHPDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5042B50", Offset = "0x5041F50", VA = "0x185042B50", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5042ED0", Offset = "0x50422D0", VA = "0x185042ED0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5042E10", Offset = "0x5042210", VA = "0x185042E10", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5042E70", Offset = "0x5042270", VA = "0x185042E70", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event CKLJAPHNLKM HNNHONJIJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5041380", Offset = "0x5040780", VA = "0x185041380", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5041430", Offset = "0x5040830", VA = "0x185041430", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event CKLJAPHNLKM LKLBHBDHOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x50411C0", Offset = "0x50405C0", VA = "0x1850411C0", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x503F310", Offset = "0x503E710", VA = "0x18503F310", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5043CB0", Offset = "0x50430B0", VA = "0x185043CB0")]
	public LPOINMJCEJA(GameObject FLFBOHHHJJB, RigidbodyEx CAGIABCENMB, MOCBKGLLLEF LHHJJDCDFNG, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5041AB0", Offset = "0x5040EB0", VA = "0x185041AB0", Slot = "142")]
	protected virtual void KICMJHPFOLP(MOCBKGLLLEF LHHJJDCDFNG, JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x503EFB0", Offset = "0x503E3B0", VA = "0x18503EFB0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x503E920", Offset = "0x503DD20", VA = "0x18503E920", Slot = "76")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x503EDF0", Offset = "0x503E1F0", VA = "0x18503EDF0", Slot = "77")]
	public void INNPMKNCCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1064BD0", Offset = "0x1063FD0", VA = "0x181064BD0", Slot = "78")]
	public void BEEEBNOHKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x503EC90", Offset = "0x503E090", VA = "0x18503EC90", Slot = "144")]
	public virtual void DIIDILKFGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5040170", Offset = "0x503F570", VA = "0x185040170", Slot = "87")]
	public void GHJLFEJPDIG(MOEFOGMCKBP IGDJJEECDAF, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5043150", Offset = "0x5042550", VA = "0x185043150", Slot = "90")]
	public void OBNNPADEOAG(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5043280", Offset = "0x5042680", VA = "0x185043280", Slot = "91")]
	public void OJCCDEGMEKM(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x503F720", Offset = "0x503EB20", VA = "0x18503F720", Slot = "92")]
	public Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x503E260", Offset = "0x503D660", VA = "0x18503E260", Slot = "93")]
	public Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x503EDF0", Offset = "0x503E1F0", VA = "0x18503EDF0", Slot = "94")]
	public void DKFBDOCLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x503F820", Offset = "0x503EC20", VA = "0x18503F820", Slot = "95")]
	public void FCLOHKDNJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x503F440", Offset = "0x503E840", VA = "0x18503F440", Slot = "96")]
	public void EIDMJDCHHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x503EBA0", Offset = "0x503DFA0", VA = "0x18503EBA0", Slot = "97")]
	public void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5040ED0", Offset = "0x50402D0", VA = "0x185040ED0", Slot = "98")]
	public void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x50428A0", Offset = "0x5041CA0", VA = "0x1850428A0", Slot = "99")]
	public void MGMFBINMOAG(Vector3 MEPDHFGMHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x503E6D0", Offset = "0x503DAD0", VA = "0x18503E6D0", Slot = "100")]
	public void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x50432E0", Offset = "0x50426E0", VA = "0x1850432E0", Slot = "101")]
	public void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5043440", Offset = "0x5042840", VA = "0x185043440", Slot = "102")]
	[Obsolete]
	public void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5042020", Offset = "0x5041420", VA = "0x185042020", Slot = "103")]
	public Vector3 KPCKJBEFMPA(Vector3 IGDJJEECDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x50402C0", Offset = "0x503F6C0", VA = "0x1850402C0", Slot = "104")]
	public Vector3 HBHKKFLNBPP(Vector3 IGDJJEECDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x503E210", Offset = "0x503D610", VA = "0x18503E210", Slot = "105")]
	public void BPOMELIBGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x503FF30", Offset = "0x503F330", VA = "0x18503FF30", Slot = "106")]
	public void GGAGIEHFLDD(MOEFOGMCKBP EONLKJMHCON, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x503F080", Offset = "0x503E480", VA = "0x18503F080", Slot = "107")]
	public void EADAKDNJPLE(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5042430", Offset = "0x5041830", VA = "0x185042430", Slot = "110")]
	public void LHNHDPFMEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5042BB0", Offset = "0x5041FB0", VA = "0x185042BB0", Slot = "111")]
	public void MNDDCBFDCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5043100", Offset = "0x5042500", VA = "0x185043100", Slot = "112")]
	public void OAGFHHDJOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5042110", Offset = "0x5041510", VA = "0x185042110", Slot = "115")]
	public bool KPFDKFMNBJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503D310", VA = "0x18503DF10", Slot = "79")]
	public void ANCJCOBPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x50430B0", Offset = "0x50424B0", VA = "0x1850430B0", Slot = "116")]
	public void NNJBHKHMMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5041260", Offset = "0x5040660", VA = "0x185041260", Slot = "121")]
	public IDisposable IOAAKHBHNGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x503F670", Offset = "0x503EA70", VA = "0x18503F670", Slot = "122")]
	public void EPIPAEBMEKC(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5041100", Offset = "0x5040500", VA = "0x185041100", Slot = "123")]
	public void IMHAINEJFMJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5042630", Offset = "0x5041A30", VA = "0x185042630", Slot = "124")]
	public void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5043550", Offset = "0x5042950", VA = "0x185043550", Slot = "127")]
	public void OPFFGAEBOEA(Vector3 DLDCBLIOEFE, Quaternion DJCHJBALDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5042C00", Offset = "0x5042000", VA = "0x185042C00", Slot = "128")]
	public void MNMLHPJJJML(Vector3 IOAMNOKKGAC, Quaternion CMEIICOJBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5041860", Offset = "0x5040C60", VA = "0x185041860", Slot = "129")]
	public bool KAIMLNCPGNN(float BJONIIADEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x503FCD0", Offset = "0x503F0D0", VA = "0x18503FCD0", Slot = "130")]
	public void FHLCJMDDJOP(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x503FC70", Offset = "0x503F070", VA = "0x18503FC70", Slot = "131")]
	public void FEGCFIPBGGB(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x503EE40", Offset = "0x503E240", VA = "0x18503EE40", Slot = "132")]
	public void DLOKMFJCJPL(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x503DEB0", Offset = "0x503D2B0", VA = "0x18503DEB0", Slot = "133")]
	public void ALOKAEHFLOF(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x50431B0", Offset = "0x50425B0", VA = "0x1850431B0", Slot = "134")]
	public void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x50437C0", Offset = "0x5042BC0", VA = "0x1850437C0", Slot = "135")]
	public void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x50412B0", Offset = "0x50406B0", VA = "0x1850412B0", Slot = "136")]
	public void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x503E350", Offset = "0x503D750", VA = "0x18503E350", Slot = "137")]
	public void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x50414F0", Offset = "0x50408F0", VA = "0x1850414F0", Slot = "138")]
	public bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5041020", Offset = "0x5040420", VA = "0x185041020", Slot = "139")]
	public void IKBDJGHAHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5043C70", Offset = "0x5043070", VA = "0x185043C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x50426A0", Offset = "0x5041AA0", VA = "0x1850426A0")]
	private void MCBFANNCIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x503DD00", Offset = "0x503D100", VA = "0x18503DD00")]
	private void AGENHODJAPE(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5041E30", Offset = "0x5041230", VA = "0x185041E30")]
	private void KOJFHAIPDIE(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x503F180", Offset = "0x503E580", VA = "0x18503F180")]
	private void ECHEKBGHNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5040DD0", Offset = "0x50401D0", VA = "0x185040DD0")]
	private void IGJDOIAPLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x503ED40", Offset = "0x503E140", VA = "0x18503ED40")]
	private void DJBHECCCCJF(MOEFOGMCKBP KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x503F230", Offset = "0x503E630", VA = "0x18503F230")]
	private void EDEMAKMNMLM(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x503EAC0", Offset = "0x503DEC0", VA = "0x18503EAC0")]
	private void DDOJIPNNAPF(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5040000", Offset = "0x503F400", VA = "0x185040000")]
	private void GGLBHEBBECK(RigidbodyEx JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x503F8D0", Offset = "0x503ECD0", VA = "0x18503F8D0")]
	private void FDNPIAHGFOL(RigidbodyEx BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5043A80", Offset = "0x5042E80", VA = "0x185043A80")]
	[Conditional("UNITY_EDITOR")]
	private void PHFJAEFKGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5040530", Offset = "0x503F930", VA = "0x185040530")]
	protected void HHPCBFMMMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x50409A0", Offset = "0x503FDA0", VA = "0x1850409A0")]
	protected void HOIDEGGNNNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OJNDPMIENBF
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x504CA50", Offset = "0x504BE50", VA = "0x18504CA50")]
	public static MOEFOGMCKBP LMFOFJLMGJG(this MOEFOGMCKBP BCFNKEDGEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x504C9D0", Offset = "0x504BDD0", VA = "0x18504C9D0")]
	public static bool ICAHEDKCMND(this MOEFOGMCKBP BCFNKEDGEDJ, MOEFOGMCKBP LDBIMIKCADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x504C900", Offset = "0x504BD00", VA = "0x18504C900")]
	public static bool HCAAPLMLHAM(this MOEFOGMCKBP BCFNKEDGEDJ, MOEFOGMCKBP NEHLJONEPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x504C980", Offset = "0x504BD80", VA = "0x18504C980")]
	public static RigidbodyEx HOJFEHABDEI(this MOEFOGMCKBP FOFFIIGGJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x504C890", Offset = "0x504BC90", VA = "0x18504C890")]
	public static LPOINMJCEJA GLCAKLCHFCP(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class JHBMANJBOFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x503A7D0", Offset = "0x5039BD0", VA = "0x18503A7D0")]
	public JHBMANJBOFP(LPOINMJCEJA HMKELCEODPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x503A770", Offset = "0x5039B70", VA = "0x18503A770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class JPGCJJFLKHO : EFMJMKJNDHN, CMGALEDPEOD
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode PNGOMEFFBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x503BF30", Offset = "0x503B330", VA = "0x18503BF30")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x503C010", Offset = "0x503B410", VA = "0x18503C010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x503BA80", Offset = "0x503AE80", VA = "0x18503BA80", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x503BD30", Offset = "0x503B130", VA = "0x18503BD30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public JPGCJJFLKHO(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x503BB90", Offset = "0x503AF90", VA = "0x18503BB90", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x503BCA0", Offset = "0x503B0A0", VA = "0x18503BCA0", Slot = "9")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x503C100", Offset = "0x503B500", VA = "0x18503C100", Slot = "7")]
	public void PGGHPEEMCDO(bool IFILKDBGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x503BF20", Offset = "0x503B320", VA = "0x18503BF20", Slot = "8")]
	public void KAAHDKJPDKI(bool IFILKDBGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x503BDB0", Offset = "0x503B1B0", VA = "0x18503BDB0", Slot = "10")]
	public bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x503C110", Offset = "0x503B510", VA = "0x18503C110")]
	private void PHMHJPILHPJ(bool IFILKDBGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OADHHCGEMKA : EFMJMKJNDHN, CEEOOLNBEAB, IDisposable, DJGKFKHPHGC
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CCMIJJFALNJ BNHCHMOCHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x50482D0", Offset = "0x50476D0", VA = "0x1850482D0")]
		get
		{
			return default(CCMIJJFALNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x50481E0", Offset = "0x50475E0", VA = "0x1850481E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5047FC0", Offset = "0x50473C0", VA = "0x185047FC0", Slot = "6")]
		get
		{
			return default(CCMIJJFALNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x50481E0", Offset = "0x50475E0", VA = "0x1850481E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform MBPDAJOJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x50483B0", Offset = "0x50477B0", VA = "0x1850483B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5048450", Offset = "0x5047850", VA = "0x185048450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public OADHHCGEMKA(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x50484F0", Offset = "0x50478F0", VA = "0x1850484F0", Slot = "11")]
	public void OnChangedDistanceBand(IJGKBFNAJFK EMCJDFHKAFD, IJGKBFNAJFK ADNCLAHHBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "12")]
	public void OnChangedVisibility(bool DAJDNICIJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class OMLCJLEKECL : EFMJMKJNDHN, LFDDJBANODG
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x504CD90", Offset = "0x504C190", VA = "0x18504CD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x50286C0", Offset = "0x5027AC0", VA = "0x1850286C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x504D1C0", Offset = "0x504C5C0", VA = "0x18504D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public OMLCJLEKECL(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x504D220", Offset = "0x504C620", VA = "0x18504D220", Slot = "4")]
	public void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x504D380", Offset = "0x504C780", VA = "0x18504D380")]
	private void OLHFILGGMFH(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x504D600", Offset = "0x504CA00", VA = "0x18504D600", Slot = "5")]
	public void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x504D060", Offset = "0x504C460", VA = "0x18504D060", Slot = "6")]
	public void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x504CDE0", Offset = "0x504C1E0", VA = "0x18504CDE0")]
	private void HGHFMLJKDHD(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x504CB10", Offset = "0x504BF10", VA = "0x18504CB10", Slot = "7")]
	public void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NHGIGCGKEHE : EFMJMKJNDHN, NIHFMIHDEJO
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x50476D0", Offset = "0x5046AD0", VA = "0x1850476D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x50477B0", Offset = "0x5046BB0", VA = "0x1850477B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public NHGIGCGKEHE(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x50475D0", Offset = "0x50469D0", VA = "0x1850475D0", Slot = "6")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x502EA40", Offset = "0x502DE40", VA = "0x18502EA40", Slot = "7")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OPOBNFLDIDO : EFMJMKJNDHN, IJBGKFLLKGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly NGKLLKOLANM HEIHGIHIMEK;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x504E600", Offset = "0x504DA00", VA = "0x18504E600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MOLBNKBNJLI HLGLKILHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x504FC30", Offset = "0x504F030", VA = "0x18504FC30")]
		get
		{
			return default(MOLBNKBNJLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x504E990", Offset = "0x504DD90", VA = "0x18504E990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x504F490", Offset = "0x504E890", VA = "0x18504F490", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x504F960", Offset = "0x504ED60", VA = "0x18504F960", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public MOLBNKBNJLI BADBMFGFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x504E890", Offset = "0x504DC90", VA = "0x18504E890")]
		get
		{
			return default(MOLBNKBNJLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x504DD60", Offset = "0x504D160", VA = "0x18504DD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x504F3B0", Offset = "0x504E7B0", VA = "0x18504F3B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CKLJAPHNLKM BOPPGLHMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x504DE60", Offset = "0x504D260", VA = "0x18504DE60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x504F9D0", Offset = "0x504EDD0", VA = "0x18504F9D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CKLJAPHNLKM EOLJOLENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x504FAF0", Offset = "0x504EEF0", VA = "0x18504FAF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x504FB90", Offset = "0x504EF90", VA = "0x18504FB90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EFJJLAHIMJH JHNMCLJNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x504FDD0", Offset = "0x504F1D0", VA = "0x18504FDD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x504DA40", Offset = "0x504CE40", VA = "0x18504DA40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PPBMKPGGKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x504FD30", Offset = "0x504F130", VA = "0x18504FD30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x504E040", Offset = "0x504D440", VA = "0x18504E040", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action MPAGNMJCFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x504DFA0", Offset = "0x504D3A0", VA = "0x18504DFA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x504E430", Offset = "0x504D830", VA = "0x18504E430", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<MOEFOGMCKBP> PGBNNBOMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x504DF00", Offset = "0x504D300", VA = "0x18504DF00", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x504F7C0", Offset = "0x504EBC0", VA = "0x18504F7C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<MOEFOGMCKBP> HCJPLFLCKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x504F310", Offset = "0x504E710", VA = "0x18504F310", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x504E0E0", Offset = "0x504D4E0", VA = "0x18504E0E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action ANNLKPMJIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x504F4D0", Offset = "0x504E8D0", VA = "0x18504F4D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x504FE70", Offset = "0x504F270", VA = "0x18504FE70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<MOEFOGMCKBP> JCKFCNBPMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x504E630", Offset = "0x504DA30", VA = "0x18504E630", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x504F3F0", Offset = "0x504E7F0", VA = "0x18504F3F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x504FF10", Offset = "0x504F310", VA = "0x18504FF10")]
	public OPOBNFLDIDO(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x504DB90", Offset = "0x504CF90", VA = "0x18504DB90", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x504E1F0", Offset = "0x504D5F0", VA = "0x18504E1F0", Slot = "26")]
	public void GHJLFEJPDIG(MOEFOGMCKBP CNMJLCOJOLA, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x504E180", Offset = "0x504D580", VA = "0x18504E180")]
	private void GHJLFEJPDIG(MAFFOPFHJPE CNMJLCOJOLA, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x504EA90", Offset = "0x504DE90", VA = "0x18504EA90")]
	private void KDNBDEADIAB(MAFFOPFHJPE CNMJLCOJOLA, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x504E270", Offset = "0x504D670", VA = "0x18504E270")]
	private void GKCGGIPCKIK(MAFFOPFHJPE KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x504E6D0", Offset = "0x504DAD0", VA = "0x18504E6D0")]
	private void JIFGOJPDJNL(MAFFOPFHJPE KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x504D8A0", Offset = "0x504CCA0", VA = "0x18504D8A0")]
	private void CCHBINEBOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x504FA70", Offset = "0x504EE70", VA = "0x18504FA70")]
	private void OGKHJIFOKKE(MAFFOPFHJPE KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x504DAE0", Offset = "0x504CEE0", VA = "0x18504DAE0")]
	private void CGBDPAINHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x504F6A0", Offset = "0x504EAA0", VA = "0x18504F6A0")]
	private void LKMHBKDGPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x504F570", Offset = "0x504E970", VA = "0x18504F570")]
	private void LJBOEABGKKO(MAFFOPFHJPE BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x504E4D0", Offset = "0x504D8D0", VA = "0x18504E4D0")]
	private void HKBMMHHGPCM(MAFFOPFHJPE BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x504F860", Offset = "0x504EC60", VA = "0x18504F860")]
	[CompilerGenerated]
	private object MGFDNBFDKKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class MFIAKPGNLGK
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x50445C0", Offset = "0x50439C0", VA = "0x1850445C0")]
	public static OPOBNFLDIDO HHMAHAKHJJA(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class ENBFBCDPPLJ : EFMJMKJNDHN, PLKCBOFCHOP
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x5034450", Offset = "0x5033850", VA = "0x185034450", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x5034290", Offset = "0x5033690", VA = "0x185034290", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x5033D90", Offset = "0x5033190", VA = "0x185033D90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private MOEFOGMCKBP DAFMLCLDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5033E70", Offset = "0x5033270", VA = "0x185033E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public ENBFBCDPPLJ(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5033FD0", Offset = "0x50333D0", VA = "0x185033FD0", Slot = "6")]
	public void JEPLEFNKCLC(MOEFOGMCKBP JFCNGAACNEO, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5034160", Offset = "0x5033560", VA = "0x185034160")]
	private void JEPLEFNKCLC(MAFFOPFHJPE JFCNGAACNEO, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5034480", Offset = "0x5033880", VA = "0x185034480", Slot = "7")]
	public void MCGHBFCIDFG(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5034570", Offset = "0x5033970", VA = "0x185034570")]
	private Vector3 OMEFOHLKJME()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class PEKPELCCELP
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x605E2B0", Offset = "0x605D6B0", VA = "0x18605E2B0")]
	public static ENBFBCDPPLJ NPPBBALHGEP(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CDHCFHPEIGC : EFMJMKJNDHN, FFONHMBHMEF
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x502B5A0", Offset = "0x502A9A0", VA = "0x18502B5A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5029760", Offset = "0x5028B60", VA = "0x185029760", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5029420", Offset = "0x5028820", VA = "0x185029420", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x502AB50", Offset = "0x5029F50", VA = "0x18502AB50", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x502BDA0", Offset = "0x502B1A0", VA = "0x18502BDA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x502B940", Offset = "0x502AD40", VA = "0x18502B940", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x502AD20", Offset = "0x502A120", VA = "0x18502AD20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x502B700", Offset = "0x502AB00", VA = "0x18502B700", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x502B6D0", Offset = "0x502AAD0", VA = "0x18502B6D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5029AD0", Offset = "0x5028ED0", VA = "0x185029AD0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x502C600", Offset = "0x502BA00", VA = "0x18502C600", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event CKLJAPHNLKM NDICODEJHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5029380", Offset = "0x5028780", VA = "0x185029380", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x502AC30", Offset = "0x502A030", VA = "0x18502AC30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x502C620", Offset = "0x502BA20", VA = "0x18502C620")]
	public CDHCFHPEIGC(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x502B730", Offset = "0x502AB30", VA = "0x18502B730", Slot = "17")]
	public void LHNHDPFMEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x502BA20", Offset = "0x502AE20", VA = "0x18502BA20", Slot = "16")]
	public void MNDDCBFDCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5029540", Offset = "0x5028940", VA = "0x185029540", Slot = "19")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x502B220", Offset = "0x502A620", VA = "0x18502B220", Slot = "20")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x502C310", Offset = "0x502B710", VA = "0x18502C310", Slot = "18")]
	public void OAGFHHDJOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x502AD30", Offset = "0x502A130", VA = "0x18502AD30", Slot = "21")]
	public void IKBDJGHAHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5029340", Offset = "0x5028740", VA = "0x185029340")]
	public void BLAGNGLICOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5029760", Offset = "0x5028B60", VA = "0x185029760")]
	private void EDMDNMPOIKG(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x502C1F0", Offset = "0x502B5F0", VA = "0x18502C1F0")]
	private Vector3 MPBPAMJKKIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5029170", Offset = "0x5028570", VA = "0x185029170")]
	private void AOFNDIGNFKF(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5028FB0", Offset = "0x50283B0", VA = "0x185028FB0")]
	private void ACOBFNFKOJD(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x502BFC0", Offset = "0x502B3C0", VA = "0x18502BFC0")]
	private Vector3 MOCNFHBLPOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x50298A0", Offset = "0x5028CA0", VA = "0x1850298A0")]
	private void ENDCIDFLABL(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x502BDB0", Offset = "0x502B1B0", VA = "0x18502BDB0")]
	private Quaternion MNFPOHMDBEA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x502C3F0", Offset = "0x502B7F0", VA = "0x18502C3F0")]
	private void OCBKHLPGCNK(Quaternion IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5029B00", Offset = "0x5028F00", VA = "0x185029B00")]
	internal (float, Vector3) GGGMGOLJEJN(Rigidbody FDJPNKEOCML)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class IMAIHFOJEKL
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x50392F0", Offset = "0x50386F0", VA = "0x1850392F0")]
	public static CDHCFHPEIGC PADFLPJNEEG(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EPDHGBLMGIK : EFMJMKJNDHN, HCDIAGKJOKB
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const string KGPDFBEICML = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool NIDJDKKDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x5035BA0", Offset = "0x5034FA0", VA = "0x185035BA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public OMABPCEAJCN LEEEKIFGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5036150", Offset = "0x5035550", VA = "0x185036150", Slot = "5")]
		get
		{
			return default(OMABPCEAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private OMABPCEAJCN CAGLJKHHADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5036070", Offset = "0x5035470", VA = "0x185036070")]
		get
		{
			return default(OMABPCEAJCN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5035F80", Offset = "0x5035380", VA = "0x185035F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x50362D0", Offset = "0x50356D0", VA = "0x1850362D0")]
	public EPDHGBLMGIK(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5035AE0", Offset = "0x5034EE0", VA = "0x185035AE0", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5035DD0", Offset = "0x50351D0", VA = "0x185035DD0")]
	private bool FBNEOJMBAEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x50358E0", Offset = "0x5034CE0", VA = "0x1850358E0", Slot = "7")]
	public void AIENKBIMAED(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x50359E0", Offset = "0x5034DE0", VA = "0x1850359E0", Slot = "8")]
	public void CMBEGJNJAFJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5035E70", Offset = "0x5035270", VA = "0x185035E70", Slot = "11")]
	public void HBFPKEEJCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5036160", Offset = "0x5035560", VA = "0x185036160")]
	private void MBNNEHKOBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5035C80", Offset = "0x5035080", VA = "0x185035C80")]
	private void DLHGBLHEAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5036250", Offset = "0x5035650", VA = "0x185036250", Slot = "10")]
	public void NEEGCBFLJPC(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5036290", Offset = "0x5035690", VA = "0x185036290", Slot = "9")]
	public void OPIJJDDGIJN(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class CNMNHHIBCIA : EFMJMKJNDHN, KHOEFPLAJFD
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x502CC80", Offset = "0x502C080", VA = "0x18502CC80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> POMBOBCBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x502CA90", Offset = "0x502BE90", VA = "0x18502CA90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool LENBPIOPMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x502CDF0", Offset = "0x502C1F0", VA = "0x18502CDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event CKLJAPHNLKM MEHLGLPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x502CBE0", Offset = "0x502BFE0", VA = "0x18502CBE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x502C9F0", Offset = "0x502BDF0", VA = "0x18502C9F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public CNMNHHIBCIA(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x502CD60", Offset = "0x502C160", VA = "0x18502CD60", Slot = "11")]
	public IDisposable IOAAKHBHNGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x502CD40", Offset = "0x502C140", VA = "0x18502CD40", Slot = "8")]
	public void EPIPAEBMEKC(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x502CD50", Offset = "0x502C150", VA = "0x18502CD50", Slot = "9")]
	public void IMHAINEJFMJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x502CED0", Offset = "0x502C2D0", VA = "0x18502CED0", Slot = "10")]
	public void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x502CB70", Offset = "0x502BF70", VA = "0x18502CB70", Slot = "12")]
	public void DODLGDLPNBJ(Rigidbody GAOHKMMENID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x502CDC0", Offset = "0x502C1C0", VA = "0x18502CDC0", Slot = "13")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class ENBNJPMODOH : EFMJMKJNDHN, OKGPPOGBFMI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private PhotonView DKHPAPAKJPC;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5035270", Offset = "0x5034670", VA = "0x185035270", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5034960", Offset = "0x5033D60", VA = "0x185034960", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event CKLJAPHNLKM PNGOIJCLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x50351D0", Offset = "0x50345D0", VA = "0x1850351D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5035290", Offset = "0x5034690", VA = "0x185035290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5035850", Offset = "0x5034C50", VA = "0x185035850")]
	public ENBNJPMODOH(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5034A70", Offset = "0x5033E70", VA = "0x185034A70", Slot = "8")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5034DD0", Offset = "0x50341D0", VA = "0x185034DD0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5034FC0", Offset = "0x50343C0", VA = "0x185034FC0", Slot = "9")]
	public void EDEMAKMNMLM(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5034BC0", Offset = "0x5033FC0", VA = "0x185034BC0", Slot = "10")]
	public void DDOJIPNNAPF(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5035660", Offset = "0x5034A60", VA = "0x185035660")]
	private void OAPEMOFBBCI(PhotonView PDNOGDFFKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5035330", Offset = "0x5034730", VA = "0x185035330")]
	private void MPJCMFHMMIF(RigidbodyEx OLLGOPFNHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5035490", Offset = "0x5034890", VA = "0x185035490")]
	private void NKPCPPPCOLB(PhotonView OGOAKIJNCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class JMJJKHIPOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x503B320", Offset = "0x503A720", VA = "0x18503B320")]
	public static ENBNJPMODOH KGFKDKMKHCO(this LPOINMJCEJA BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class JHPKMJMBBCL : EFMJMKJNDHN, DKAJJIAJAGC
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x503AF10", Offset = "0x503A310", VA = "0x18503AF10", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x503AE20", Offset = "0x503A220", VA = "0x18503AE20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool PAHIOOGCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x503AA40", Offset = "0x5039E40", VA = "0x18503AA40", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x503AFF0", Offset = "0x503A3F0", VA = "0x18503AFF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x503A960", Offset = "0x5039D60", VA = "0x18503A960", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x503AB20", Offset = "0x5039F20", VA = "0x18503AB20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x503B0E0", Offset = "0x503A4E0", VA = "0x18503B0E0")]
	public JHPKMJMBBCL(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x503A860", Offset = "0x5039C60", VA = "0x18503A860", Slot = "9")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x503AD20", Offset = "0x503A120", VA = "0x18503AD20", Slot = "10")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class JCJCEFJJIJH : EFMJMKJNDHN, DJKOOKOCBBL
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x503A5B0", Offset = "0x50399B0", VA = "0x18503A5B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5039F70", Offset = "0x5039370", VA = "0x185039F70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x503A690", Offset = "0x5039A90", VA = "0x18503A690", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x503A140", Offset = "0x5039540", VA = "0x18503A140", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public JCJCEFJJIJH(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x503A310", Offset = "0x5039710", VA = "0x18503A310", Slot = "8")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x503A4E0", Offset = "0x50398E0", VA = "0x18503A4E0", Slot = "9")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[NDGJMMLBLBO(typeof(FNOAHGOMEEJ), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public sealed class RbexServiceCallbacks : LNLPIGELLPM, FNOAHGOMEEJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private DJJJIFEINIH BCFNKEDGEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool NMHLJFGMGOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x605F630", Offset = "0x605EA30", VA = "0x18605F630", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x605F350", Offset = "0x605E750", VA = "0x18605F350", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x605F380", Offset = "0x605E780", VA = "0x18605F380", Slot = "6")]
		public void GGGMGOLJEJN(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class DHHNAECNCNF : EFMJMKJNDHN, EHJNFOLMBKE
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const int LGDAPAINMOO = 10;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const float KGAPEFMHBOB = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float KDDJGNACKDP = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float CPNONKGFIMC = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool EDPFKNJAFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x502DFA0", Offset = "0x502D3A0", VA = "0x18502DFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x502D180", Offset = "0x502C580", VA = "0x18502D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x502DA40", Offset = "0x502CE40", VA = "0x18502DA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x502D880", Offset = "0x502CC80", VA = "0x18502D880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool DBAEOKKFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x502D510", Offset = "0x502C910", VA = "0x18502D510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x502DE00", Offset = "0x502D200", VA = "0x18502DE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool BPKPFLFAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x502D7A0", Offset = "0x502CBA0", VA = "0x18502D7A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x502D420", Offset = "0x502C820", VA = "0x18502D420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int LLILPAFLMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x502D340", Offset = "0x502C740", VA = "0x18502D340")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x502D250", Offset = "0x502C650", VA = "0x18502D250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event CKLJAPHNLKM OPHAOHPDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x502DCC0", Offset = "0x502D0C0", VA = "0x18502DCC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x502DD60", Offset = "0x502D160", VA = "0x18502DD60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x502E040", Offset = "0x502D440", VA = "0x18502E040")]
	public DHHNAECNCNF(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x502D1A0", Offset = "0x502C5A0", VA = "0x18502D1A0", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x502D8E0", Offset = "0x502CCE0", VA = "0x18502D8E0", Slot = "8")]
	public void HNMIICJHFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x502DAA0", Offset = "0x502CEA0", VA = "0x18502DAA0", Slot = "7")]
	public bool KPFDKFMNBJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x502D0D0", Offset = "0x502C4D0", VA = "0x18502D0D0", Slot = "9")]
	public void ANCJCOBPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5029340", Offset = "0x5028740", VA = "0x185029340", Slot = "12")]
	public void JNBPEOADCFI(bool FBMIBFGCBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x502DEF0", Offset = "0x502D2F0", VA = "0x18502DEF0", Slot = "11")]
	public void NNJBHKHMMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "10")]
	public void OPAFANIKDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x502D5F0", Offset = "0x502C9F0", VA = "0x18502D5F0")]
	private bool GEBLKEPACPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x502D8F0", Offset = "0x502CCF0", VA = "0x18502D8F0")]
	private void HPPGLJCIKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class PMPGEEGMIAH : EFMJMKJNDHN, HHKLONHDBCP
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string NNDBDBLKNJH = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x605EAE0", Offset = "0x605DEE0", VA = "0x18605EAE0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x605EBD0", Offset = "0x605DFD0", VA = "0x18605EBD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x605EAC0", Offset = "0x605DEC0", VA = "0x18605EAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x605F180", Offset = "0x605E580", VA = "0x18605F180")]
	public PMPGEEGMIAH(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x605E5B0", Offset = "0x605D9B0", VA = "0x18605E5B0", Slot = "5")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x605E660", Offset = "0x605DA60", VA = "0x18605E660", Slot = "6")]
	public void DLOKMFJCJPL(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x605E320", Offset = "0x605D720", VA = "0x18605E320", Slot = "7")]
	public void ALOKAEHFLOF(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x605EF30", Offset = "0x605E330", VA = "0x18605EF30", Slot = "8")]
	public void ODFAIAHCPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x605ECD0", Offset = "0x605E0D0", VA = "0x18605ECD0", Slot = "9")]
	public void JIKCGGCJNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x605E760", Offset = "0x605DB60", VA = "0x18605E760", Slot = "10")]
	public void HEBJIGNJHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "11")]
	public void EIKELGJGOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x605E420", Offset = "0x605D820", VA = "0x18605E420")]
	private void BJHCOMPNNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x605E930", Offset = "0x605DD30", VA = "0x18605E930")]
	private void HEIGHNEHJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class OCPDMGIGBEP : EFMJMKJNDHN, JCDDIDCNMEM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x504A040", Offset = "0x5049440", VA = "0x18504A040", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5048AD0", Offset = "0x5047ED0", VA = "0x185048AD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5049480", Offset = "0x5048880", VA = "0x185049480", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x504BC00", Offset = "0x504B000", VA = "0x18504BC00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x50495F0", Offset = "0x50489F0", VA = "0x1850495F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5049CA0", Offset = "0x50490A0", VA = "0x185049CA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x504B140", Offset = "0x504A540", VA = "0x18504B140", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x504B490", Offset = "0x504A890", VA = "0x18504B490", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x504B4C0", Offset = "0x504A8C0", VA = "0x18504B4C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5048720", Offset = "0x5047B20", VA = "0x185048720", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5049F10", Offset = "0x5049310", VA = "0x185049F10", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5049030", Offset = "0x5048430", VA = "0x185049030", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5048550", Offset = "0x5047950", VA = "0x185048550", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x504A030", Offset = "0x5049430", VA = "0x18504A030", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x504B3B0", Offset = "0x504A7B0", VA = "0x18504B3B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private LFDDJBANODG AMEAGKIDCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1B5D240", Offset = "0x1B5C640", VA = "0x181B5D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x502D180", Offset = "0x502C580", VA = "0x18502D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public OCPDMGIGBEP(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5048630", Offset = "0x5047A30", VA = "0x185048630", Slot = "20")]
	public void BCHCHPECDKN(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x504B610", Offset = "0x504AA10", VA = "0x18504B610", Slot = "31")]
	public void NNHLDFPJICN(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5049060", Offset = "0x5048460", VA = "0x185049060", Slot = "19")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5049350", Offset = "0x5048750", VA = "0x185049350", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5049310", Offset = "0x5048710", VA = "0x185049310", Slot = "28")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5049740", Offset = "0x5048B40", VA = "0x185049740", Slot = "36")]
	public Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5048910", Offset = "0x5047D10", VA = "0x185048910", Slot = "35")]
	public Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5049060", Offset = "0x5048460", VA = "0x185049060", Slot = "27")]
	public void DKFBDOCLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5049920", Offset = "0x5048D20", VA = "0x185049920", Slot = "25")]
	public void FCLOHKDNJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x50495B0", Offset = "0x50489B0", VA = "0x1850495B0", Slot = "24")]
	public void EIDMJDCHHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x50490D0", Offset = "0x50484D0", VA = "0x1850490D0", Slot = "34")]
	public void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x504A170", Offset = "0x5049570", VA = "0x18504A170", Slot = "33")]
	public void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x504B250", Offset = "0x504A650", VA = "0x18504B250", Slot = "32")]
	public void MGMFBINMOAG(Vector3 MEPDHFGMHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5048BC0", Offset = "0x5047FC0", VA = "0x185048BC0", Slot = "22")]
	public void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x504B700", Offset = "0x504AB00", VA = "0x18504B700", Slot = "21")]
	public void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x504B930", Offset = "0x504AD30", VA = "0x18504B930", Slot = "23")]
	[Obsolete]
	public void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x504AA80", Offset = "0x5049E80", VA = "0x18504AA80", Slot = "30")]
	public Vector3 KPCKJBEFMPA(Vector3 EAMJDCGEMLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5049E20", Offset = "0x5049220", VA = "0x185049E20", Slot = "29")]
	public Vector3 HBHKKFLNBPP(Vector3 BPNOJOBDHCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x50487E0", Offset = "0x5047BE0", VA = "0x1850487E0", Slot = "26")]
	public void BPOMELIBGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x504A640", Offset = "0x5049A40", VA = "0x18504A640")]
	private void KCHHHANJEOB(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x504A810", Offset = "0x5049C10", VA = "0x18504A810")]
	private void KIHHCFBBBDE(Vector3 CPFFKJJFDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x504A530", Offset = "0x5049930", VA = "0x18504A530")]
	private Vector3 JLNDMGPEACL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5049960", Offset = "0x5048D60", VA = "0x185049960")]
	private void FFEMPINGOKL(Vector3 IBINHIACJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x504A970", Offset = "0x5049D70", VA = "0x18504A970")]
	private Vector3 KIODBDOEPHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x504A1D0", Offset = "0x50495D0", VA = "0x18504A1D0")]
	private void JDKPEJGDLFI(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x504AB40", Offset = "0x5049F40", VA = "0x18504AB40")]
	private void LHEBIHJPLOL(Vector3 IBINHIACJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5049D60", Offset = "0x5049160", VA = "0x185049D60")]
	private void GEFHBPCJAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class EFMJMKJNDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly MAFFOPFHJPE BCFNKEDGEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected DJJJIFEINIH NGDMLDAICEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xC45790", Offset = "0xC44B90", VA = "0x180C45790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected MOLBNKBNJLI LMHNINBJGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5033C40", Offset = "0x5033040", VA = "0x185033C40")]
		get
		{
			return default(MOLBNKBNJLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
	public EFMJMKJNDHN(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5033C70", Offset = "0x5033070", VA = "0x185033C70")]
	protected MOEFOGMCKBP MNAOEEEAKEB(MOLBNKBNJLI OACDBCDEFBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OECJCICPCKC : LILHCMCOEBD
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x504BCF0", Offset = "0x504B0F0", VA = "0x18504BCF0", Slot = "4")]
	public IJBGKFLLKGL AGFICOJOKMA(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x504C6D0", Offset = "0x504BAD0", VA = "0x18504C6D0", Slot = "5")]
	public JCDDIDCNMEM OLMKBEOJODC(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x504C330", Offset = "0x504B730", VA = "0x18504C330", Slot = "6")]
	public PLKCBOFCHOP GOGOHDMIFAP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x504C180", Offset = "0x504B580", VA = "0x18504C180", Slot = "7")]
	public DJKOOKOCBBL FPHLJCEEMCP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x504C670", Offset = "0x504BA70", VA = "0x18504C670", Slot = "8")]
	public EHJNFOLMBKE OFCGOGHHCDK(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x504C440", Offset = "0x504B840", VA = "0x18504C440", Slot = "9")]
	public CEEOOLNBEAB JHBNNELEDNF(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x504C040", Offset = "0x504B440", VA = "0x18504C040", Slot = "10")]
	public KHOEFPLAJFD ELPGNALAKAD(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x504C290", Offset = "0x504B690", VA = "0x18504C290", Slot = "11")]
	public LFDDJBANODG GBGJMGFKGNH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x504C0E0", Offset = "0x504B4E0", VA = "0x18504C0E0", Slot = "12")]
	public CMGALEDPEOD FADNALMPLHJ(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x504C770", Offset = "0x504BB70", VA = "0x18504C770", Slot = "13")]
	public NIHFMIHDEJO PKCPGPAMJKH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x504C220", Offset = "0x504B620", VA = "0x18504C220")]
	public HHKLONHDBCP FPIDOEFIGKO(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x504BE60", Offset = "0x504B260", VA = "0x18504BE60")]
	public OKGPPOGBFMI AMMKHOJLEHJ(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x504C4E0", Offset = "0x504B8E0", VA = "0x18504C4E0")]
	public HCDIAGKJOKB NGDEPNHKILK(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x504BFD0", Offset = "0x504B3D0", VA = "0x18504BFD0")]
	public FFONHMBHMEF LOAAEMBOPCE(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x504C3D0", Offset = "0x504B7D0", VA = "0x18504C3D0")]
	public DKAJJIAJAGC HPFNKKLNJCL(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x504BF20", Offset = "0x504B320", VA = "0x18504BF20", Slot = "19")]
	public MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON, MOCBKGLLLEF LHHJJDCDFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OECJCICPCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x504C220", Offset = "0x504B620", VA = "0x18504C220", Slot = "14")]
	private HHKLONHDBCP KMFMCLEDKBN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x504BE60", Offset = "0x504B260", VA = "0x18504BE60", Slot = "15")]
	private OKGPPOGBFMI BLDPIPCPFIH(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x504C4E0", Offset = "0x504B8E0", VA = "0x18504C4E0", Slot = "16")]
	private HCDIAGKJOKB JKOAIHDOPFC(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x504BFD0", Offset = "0x504B3D0", VA = "0x18504BFD0", Slot = "17")]
	private FFONHMBHMEF EDPIHFGAJIA(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x504C3D0", Offset = "0x504B7D0", VA = "0x18504C3D0", Slot = "18")]
	private DKAJJIAJAGC HCCIKPPBDPN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class NGKLLKOLANM : IReadOnlyList<MOEFOGMCKBP>, IEnumerable<MOEFOGMCKBP>, IEnumerable, IReadOnlyCollection<MOEFOGMCKBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly MOLBNKBNJLI OACDBCDEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly DJJJIFEINIH IIHJMACAMDH;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5044900", Offset = "0x5043D00", VA = "0x185044900", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public MOEFOGMCKBP HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x50449D0", Offset = "0x5043DD0", VA = "0x1850449D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x50448B0", Offset = "0x5043CB0", VA = "0x1850448B0")]
	public NGKLLKOLANM(MOLBNKBNJLI OACDBCDEFBJ, DJJJIFEINIH IIHJMACAMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5044720", Offset = "0x5043B20", VA = "0x185044720", Slot = "6")]
	public IEnumerator<MOEFOGMCKBP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5044720", Offset = "0x5043B20", VA = "0x185044720", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5044710", Offset = "0x5043B10", VA = "0x185044710")]
	[CompilerGenerated]
	private MOEFOGMCKBP ANCELCNLKCG(int FNHGJOONKOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[NDGJMMLBLBO(typeof(LILHCMCOEBD), new string[] { })]
public class JCHAEDHGDCI : LILHCMCOEBD, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LILHCMCOEBD AOOFCOCFPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LILHCMCOEBD JOGJFLEFHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LCCHFDCPEHE BLAHIPBNDLP;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LILHCMCOEBD PEEHJHPMOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5039670", Offset = "0x5038A70", VA = "0x185039670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5039DE0", Offset = "0x50391E0", VA = "0x185039DE0", Slot = "20")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5039380", Offset = "0x5038780", VA = "0x185039380", Slot = "4")]
	public IJBGKFLLKGL AGFICOJOKMA(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5039D40", Offset = "0x5039140", VA = "0x185039D40", Slot = "5")]
	public JCDDIDCNMEM OLMKBEOJODC(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5039A00", Offset = "0x5038E00", VA = "0x185039A00", Slot = "6")]
	public PLKCBOFCHOP GOGOHDMIFAP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5039810", Offset = "0x5038C10", VA = "0x185039810", Slot = "7")]
	public DJKOOKOCBBL FPHLJCEEMCP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5039CA0", Offset = "0x50390A0", VA = "0x185039CA0", Slot = "8")]
	public EHJNFOLMBKE OFCGOGHHCDK(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5039B50", Offset = "0x5038F50", VA = "0x185039B50", Slot = "9")]
	public CEEOOLNBEAB JHBNNELEDNF(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x50396D0", Offset = "0x5038AD0", VA = "0x1850396D0", Slot = "10")]
	public KHOEFPLAJFD ELPGNALAKAD(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5039960", Offset = "0x5038D60", VA = "0x185039960", Slot = "11")]
	public LFDDJBANODG GBGJMGFKGNH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5039770", Offset = "0x5038B70", VA = "0x185039770", Slot = "12")]
	public CMGALEDPEOD FADNALMPLHJ(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5039E30", Offset = "0x5039230", VA = "0x185039E30", Slot = "13")]
	public NIHFMIHDEJO PKCPGPAMJKH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x50398B0", Offset = "0x5038CB0", VA = "0x1850398B0")]
	public HHKLONHDBCP FPIDOEFIGKO(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5039420", Offset = "0x5038820", VA = "0x185039420")]
	public OKGPPOGBFMI AMMKHOJLEHJ(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5039BF0", Offset = "0x5038FF0", VA = "0x185039BF0")]
	public HCDIAGKJOKB NGDEPNHKILK(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x50395C0", Offset = "0x50389C0", VA = "0x1850395C0")]
	public FFONHMBHMEF LOAAEMBOPCE(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5039AA0", Offset = "0x5038EA0", VA = "0x185039AA0")]
	public DKAJJIAJAGC HPFNKKLNJCL(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x50394D0", Offset = "0x50388D0", VA = "0x1850394D0", Slot = "19")]
	public MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON, MOCBKGLLLEF LHHJJDCDFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5039ED0", Offset = "0x50392D0", VA = "0x185039ED0")]
	public JCHAEDHGDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x50398B0", Offset = "0x5038CB0", VA = "0x1850398B0", Slot = "14")]
	private HHKLONHDBCP KMFMCLEDKBN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5039420", Offset = "0x5038820", VA = "0x185039420", Slot = "15")]
	private OKGPPOGBFMI BLDPIPCPFIH(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5039BF0", Offset = "0x5038FF0", VA = "0x185039BF0", Slot = "16")]
	private HCDIAGKJOKB JKOAIHDOPFC(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x50395C0", Offset = "0x50389C0", VA = "0x1850395C0", Slot = "17")]
	private FFONHMBHMEF EDPIHFGAJIA(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5039AA0", Offset = "0x5038EA0", VA = "0x185039AA0", Slot = "18")]
	private DKAJJIAJAGC HCCIKPPBDPN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class ILIJFLGPBPG : MOEFOGMCKBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ILIJFLGPBPG KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx HOJFEHABDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject NEHBINLAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> OPDAKEENMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6780D0", Offset = "0x6774D0", VA = "0x1806780D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B40", Offset = "0x9F7F40", VA = "0x1809F8B40", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1087DE0", Offset = "0x10871E0", VA = "0x181087DE0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xC12FA0", Offset = "0xC123A0", VA = "0x180C12FA0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6780B0", Offset = "0x6774B0", VA = "0x1806780B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x770300", Offset = "0x76F700", VA = "0x180770300", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x719AB0", Offset = "0x718EB0", VA = "0x180719AB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x155DD00", Offset = "0x155D100", VA = "0x18155DD00", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xEABF70", Offset = "0xEAB370", VA = "0x180EABF70", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E720", Offset = "0x3A3DB20", VA = "0x183A3E720", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3CFB0", Offset = "0x3A3C3B0", VA = "0x183A3CFB0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE890", Offset = "0x1ABDC90", VA = "0x181ABE890", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA2A0", Offset = "0x1AB96A0", VA = "0x181ABA2A0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE8B0", Offset = "0x1ABDCB0", VA = "0x181ABE8B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB4F0", Offset = "0x1ABA8F0", VA = "0x181ABB4F0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool ODENFPLCPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xC493C0", Offset = "0xC487C0", VA = "0x180C493C0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool NGBGNGACAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xCAD7B0", Offset = "0xCACBB0", VA = "0x180CAD7B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool AEKNHCIFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xCAD7A0", Offset = "0xCACBA0", VA = "0x180CAD7A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xAD6A70", Offset = "0xAD5E70", VA = "0x180AD6A70", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x15131C0", Offset = "0x15125C0", VA = "0x1815131C0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1A197B0", Offset = "0x1A18BB0", VA = "0x181A197B0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1ABE970", Offset = "0x1ABDD70", VA = "0x181ABE970", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x22271B0", Offset = "0x22265B0", VA = "0x1822271B0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x19A6BA0", Offset = "0x19A5FA0", VA = "0x1819A6BA0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool FHIGBPDMEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "52")]
		get
		{
			return default(CCMIJJFALNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1A07050", Offset = "0x1A06450", VA = "0x181A07050", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform OIGIPMCMONG
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C00", Offset = "0x7A8000", VA = "0x1807A8C00", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform OAMKBJNKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7307A0", Offset = "0x72FBA0", VA = "0x1807307A0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 GBOLJIPIHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float OGBGBAOPBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float EFFCFAKACCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion GMFJBDNIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x15D0880", Offset = "0x15CFC80", VA = "0x1815D0880", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 ADLALFFNAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion IGNNLHFDJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x15D0880", Offset = "0x15CFC80", VA = "0x1815D0880", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x1326A80", Offset = "0x1325E80", VA = "0x181326A80", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event CKLJAPHNLKM BOPPGLHMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event CKLJAPHNLKM EOLJOLENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event EFJJLAHIMJH JHNMCLJNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event CKLJAPHNLKM PNGOIJCLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event CKLJAPHNLKM JMHMDIBAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event CKLJAPHNLKM OPHAOHPDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event CKLJAPHNLKM HNNHONJIJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event CKLJAPHNLKM LKLBHBDHOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "76")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "77")]
	public void INNPMKNCCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "78")]
	public void BEEEBNOHKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "79")]
	public void ANCJCOBPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "80")]
	public void DIIDILKFGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "87")]
	public void GHJLFEJPDIG(MOEFOGMCKBP IGDJJEECDAF, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "90")]
	public void OBNNPADEOAG(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "91")]
	public void OJCCDEGMEKM(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "92")]
	public Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "93")]
	public Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "94")]
	public void DKFBDOCLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "95")]
	public void FCLOHKDNJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "96")]
	public void EIDMJDCHHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "97")]
	public void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "98")]
	public void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "99")]
	public void MGMFBINMOAG(Vector3 MEPDHFGMHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "100")]
	public void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "101")]
	public void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "102")]
	public void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "103")]
	public Vector3 KPCKJBEFMPA(Vector3 IGDJJEECDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x15E0B90", Offset = "0x15DFF90", VA = "0x1815E0B90", Slot = "104")]
	public Vector3 HBHKKFLNBPP(Vector3 IGDJJEECDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "105")]
	public void BPOMELIBGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "106")]
	public void GGAGIEHFLDD(MOEFOGMCKBP EONLKJMHCON, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "107")]
	public void EADAKDNJPLE(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "110")]
	public void LHNHDPFMEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "111")]
	public void MNDDCBFDCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "112")]
	public void OAGFHHDJOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "115")]
	public bool KPFDKFMNBJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "116")]
	public void NNJBHKHMMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "121")]
	public IDisposable IOAAKHBHNGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "122")]
	public void EPIPAEBMEKC(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "123")]
	public void IMHAINEJFMJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "124")]
	public void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "127")]
	public void OPFFGAEBOEA(Vector3 DLDCBLIOEFE, Quaternion DJCHJBALDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "128")]
	public void MNMLHPJJJML(Vector3 IOAMNOKKGAC, Quaternion CMEIICOJBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "129")]
	public bool KAIMLNCPGNN(float BJONIIADEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "130")]
	public void FHLCJMDDJOP(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "131")]
	public void FEGCFIPBGGB(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "132")]
	public void DLOKMFJCJPL(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "133")]
	public void ALOKAEHFLOF(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "134")]
	public void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "135")]
	public void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "136")]
	public void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "137")]
	public void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5039270", Offset = "0x5038670", VA = "0x185039270", Slot = "138")]
	public bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "139")]
	public void IKBDJGHAHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ILIJFLGPBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class MAFFOPFHJPE : LPOINMJCEJA, AEGKIDLHAJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	internal MOLBNKBNJLI OACDBCDEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal DJJJIFEINIH NMEJFFCLNGB;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x50445B0", Offset = "0x50439B0", VA = "0x1850445B0")]
	public MAFFOPFHJPE(GameObject FLFBOHHHJJB, RigidbodyEx CAGIABCENMB, MOCBKGLLLEF LHHJJDCDFNG, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5044190", Offset = "0x5043590", VA = "0x185044190", Slot = "142")]
	protected override void KICMJHPFOLP(MOCBKGLLLEF LHHJJDCDFNG, JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5043FA0", Offset = "0x50433A0", VA = "0x185043FA0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x50444E0", Offset = "0x50438E0", VA = "0x1850444E0", Slot = "145")]
	public void MPKIGBCDIBA(MIAPNMCOIGB EMCJDFHKAFD, MIAPNMCOIGB ADNCLAHHBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5044420", Offset = "0x5043820", VA = "0x185044420", Slot = "146")]
	public void KJNNDCJLJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5043EE0", Offset = "0x50432E0", VA = "0x185043EE0", Slot = "147")]
	public void DPOBMHJAKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5044130", Offset = "0x5043530", VA = "0x185044130", Slot = "148")]
	public void JNBPEOADCFI(bool FBMIBFGCBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5043D80", Offset = "0x5043180", VA = "0x185043D80", Slot = "149")]
	public bool APDEHGHLOMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "144")]
	public override void DIIDILKFGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class CKKHLFAAPPN
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x502C9A0", Offset = "0x502BDA0", VA = "0x18502C9A0")]
	public static LPOINMJCEJA GPAPNCBDMCP(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KMJDJHIAAAD : IJBGKFLLKGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJBOEABGKKO(MOEFOGMCKBP BCFNKEDGEDJ);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKBMMHHGPCM(MOEFOGMCKBP BCFNKEDGEDJ);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKCGGIPCKIK(MOEFOGMCKBP KJLAIHIGEMC);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIFGOJPDJNL(MOEFOGMCKBP KJLAIHIGEMC);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface BAGGFLAMDAA : PLKCBOFCHOP
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::NIBMCCJIKPI<MOEFOGMCKBP> FANHJNAHOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	MOEFOGMCKBP DAFMLCLDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface OMPHNJCKPCN : FFONHMBHMEF
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) GGGMGOLJEJN(Rigidbody FDJPNKEOCML);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface NKFKJEOMMME : OKGPPOGBFMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView PHLEMNLJONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KAGBCKPCJEN : CMGALEDPEOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private CollisionDetectionMode GLJJHEIKMAM;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode CCKOOKGODHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x503C950", Offset = "0x503BD50", VA = "0x18503C950", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x503CC00", Offset = "0x503C000", VA = "0x18503CC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x502EAB0", Offset = "0x502DEB0", VA = "0x18502EAB0")]
	public KAGBCKPCJEN(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x503CA60", Offset = "0x503BE60", VA = "0x18503CA60", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x503CB80", Offset = "0x503BF80", VA = "0x18503CB80", Slot = "9")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x503CDF0", Offset = "0x503C1F0", VA = "0x18503CDF0", Slot = "7")]
	public void PGGHPEEMCDO(bool IFILKDBGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x503CDE0", Offset = "0x503C1E0", VA = "0x18503CDE0", Slot = "8")]
	public void KAAHDKJPDKI(bool IFILKDBGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x503CC70", Offset = "0x503C070", VA = "0x18503CC70", Slot = "10")]
	public bool JLENJGNLECL(Vector3 BENEMIPHCAB, out RaycastHit PJKEBJKEDGG, float KKONCICCPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x503CE00", Offset = "0x503C200", VA = "0x18503CE00")]
	private void PHMHJPILHPJ(bool IFILKDBGJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class PBCJJKLDPKG : CEEOOLNBEAB, IDisposable, DJGKFKHPHGC
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const int FGBLPAKLDOM = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CCMIJJFALNJ COPDHDNJBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private MKGJHDNFCEE AKOAMEAHIPB;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CCMIJJFALNJ FBLFOFCHFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5050050", Offset = "0x504F450", VA = "0x185050050", Slot = "6")]
		get
		{
			return default(CCMIJJFALNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5050470", Offset = "0x504F870", VA = "0x185050470", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform MBPDAJOJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5050590", Offset = "0x504F990", VA = "0x185050590", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<IJGKBFNAJFK, IJGKBFNAJFK> FIIEBBGNMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x50505B0", Offset = "0x504F9B0", VA = "0x1850505B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5050650", Offset = "0x504FA50", VA = "0x185050650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5050750", Offset = "0x504FB50", VA = "0x185050750")]
	public PBCJJKLDPKG(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5050190", Offset = "0x504F590", VA = "0x185050190", Slot = "8")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5050540", Offset = "0x504F940", VA = "0x185050540", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x50506F0", Offset = "0x504FAF0", VA = "0x1850506F0", Slot = "11")]
	private void NJHDINCECPI(IJGKBFNAJFK PHCIBHAPAEA, IJGKBFNAJFK HOINOFOELCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "12")]
	private void EEMEPGNKNNK(bool DAJDNICIJIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class PEDKAKCJCDP : LFDDJBANODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x502ACD0", Offset = "0x502A0D0", VA = "0x18502ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x504CD90", Offset = "0x504C190", VA = "0x18504CD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x50286C0", Offset = "0x5027AC0", VA = "0x1850286C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5050E40", Offset = "0x5050240", VA = "0x185050E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x502EAB0", Offset = "0x502DEB0", VA = "0x18502EAB0")]
	public PEDKAKCJCDP(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5050EA0", Offset = "0x50502A0", VA = "0x185050EA0", Slot = "4")]
	public void OFNGEKHNHDO(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5051000", Offset = "0x5050400", VA = "0x185051000")]
	private void OLHFILGGMFH(Vector3 POKKNFLDEOM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5051280", Offset = "0x5050680", VA = "0x185051280", Slot = "5")]
	public void PANDNEAPNOP(Vector3 POKKNFLDEOM, Vector3 EFKMIDDCAKM, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5050CE0", Offset = "0x50500E0", VA = "0x185050CE0", Slot = "6")]
	public void JCPCODNIMNN(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5050A60", Offset = "0x504FE60", VA = "0x185050A60")]
	private void HGHFMLJKDHD(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x50507E0", Offset = "0x504FBE0", VA = "0x1850507E0", Slot = "7")]
	public void CAOHBCFLDNB(Vector3 OKGPFMPIJMJ, ForceMode MDHECHKIHGC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DPLMMGCMNPM : NIHFMIHDEJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool FDGHFGMHACF;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool BIPPBPGOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x502E930", Offset = "0x502DD30", VA = "0x18502E930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x502EAB0", Offset = "0x502DEB0", VA = "0x18502EAB0")]
	public DPLMMGCMNPM(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x502E900", Offset = "0x502DD00", VA = "0x18502E900", Slot = "6")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x502EA40", Offset = "0x502DE40", VA = "0x18502EA40", Slot = "7")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class EEIHAEBGDJK : KMJDJHIAAAD, IJBGKFLLKGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MOEFOGMCKBP BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<MOEFOGMCKBP> HEIHGIHIMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private MOEFOGMCKBP NMIIAOIKHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private MOEFOGMCKBP JFCNGAACNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Transform OEJPOPCDPEC;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform ELOLOIEDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x50329D0", Offset = "0x5031DD0", VA = "0x1850329D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x68E700", Offset = "0x68DB00", VA = "0x18068E700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x50332C0", Offset = "0x50326C0", VA = "0x1850332C0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public MOEFOGMCKBP OGEOEBLKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x68E780", Offset = "0x68DB80", VA = "0x18068E780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<MOEFOGMCKBP> BACNDKNLMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event CKLJAPHNLKM BOPPGLHMCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5031DA0", Offset = "0x50311A0", VA = "0x185031DA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x50332D0", Offset = "0x50326D0", VA = "0x1850332D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event CKLJAPHNLKM EOLJOLENJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x50333B0", Offset = "0x50327B0", VA = "0x1850333B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x5033450", Offset = "0x5032850", VA = "0x185033450", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event EFJJLAHIMJH JHNMCLJNKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5033590", Offset = "0x5032990", VA = "0x185033590", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5031B50", Offset = "0x5030F50", VA = "0x185031B50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PPBMKPGGKEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x50334F0", Offset = "0x50328F0", VA = "0x1850334F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5031F80", Offset = "0x5031380", VA = "0x185031F80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action MPAGNMJCFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5031EE0", Offset = "0x50312E0", VA = "0x185031EE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5032890", Offset = "0x5031C90", VA = "0x185032890", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<MOEFOGMCKBP> PGBNNBOMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5031E40", Offset = "0x5031240", VA = "0x185031E40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5033220", Offset = "0x5032620", VA = "0x185033220", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<MOEFOGMCKBP> HCJPLFLCKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5032D30", Offset = "0x5032130", VA = "0x185032D30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5032020", Offset = "0x5031420", VA = "0x185032020", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action ANNLKPMJIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5032FC0", Offset = "0x50323C0", VA = "0x185032FC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5033630", Offset = "0x5032A30", VA = "0x185033630", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<MOEFOGMCKBP> JCKFCNBPMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5032A30", Offset = "0x5031E30", VA = "0x185032A30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5032F20", Offset = "0x5032320", VA = "0x185032F20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x50336D0", Offset = "0x5032AD0", VA = "0x1850336D0")]
	public EEIHAEBGDJK(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5031D20", Offset = "0x5031120", VA = "0x185031D20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x50320C0", Offset = "0x50314C0", VA = "0x1850320C0", Slot = "30")]
	public void GHJLFEJPDIG(MOEFOGMCKBP CNMJLCOJOLA, bool PHAEAKBOIBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5032640", Offset = "0x5031A40", VA = "0x185032640", Slot = "6")]
	public void GKCGGIPCKIK(MOEFOGMCKBP KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5032AD0", Offset = "0x5031ED0", VA = "0x185032AD0", Slot = "7")]
	public void JIFGOJPDJNL(MOEFOGMCKBP KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x5033060", Offset = "0x5032460", VA = "0x185033060", Slot = "4")]
	public void LJBOEABGKKO(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x5032930", Offset = "0x5031D30", VA = "0x185032930", Slot = "5")]
	public void HKBMMHHGPCM(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x5031AC0", Offset = "0x5030EC0", VA = "0x185031AC0")]
	private void CCHBINEBOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x5033370", Offset = "0x5032770", VA = "0x185033370")]
	private void OGKHJIFOKKE(MOEFOGMCKBP KJLAIHIGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5032DD0", Offset = "0x50321D0", VA = "0x185032DD0")]
	private void KHDJFGHIKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5031BF0", Offset = "0x5030FF0", VA = "0x185031BF0")]
	private void CGBDPAINHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5033100", Offset = "0x5032500", VA = "0x185033100")]
	private void LKMHBKDGPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x50319D0", Offset = "0x5030DD0", VA = "0x1850319D0")]
	[CompilerGenerated]
	private object AFHAIAFNBFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DMLGONPJDOG
{
	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x502E240", Offset = "0x502D640", VA = "0x18502E240")]
	public static KMJDJHIAAAD HHMAHAKHJJA(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class GMIONEEPOHG : BAGGFLAMDAA, PLKCBOFCHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly global::NIBMCCJIKPI<MOEFOGMCKBP> EBCFCPPJMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool OJBMFLPGDFC;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::NIBMCCJIKPI<MOEFOGMCKBP> FANHJNAHOND
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 FFHMKBKFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x5037880", Offset = "0x5036C80", VA = "0x185037880", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 ADHFFAMLOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x50376B0", Offset = "0x5036AB0", VA = "0x1850376B0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x5037110", Offset = "0x5036510", VA = "0x185037110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public MOEFOGMCKBP DAFMLCLDEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x5037590", Offset = "0x5036990", VA = "0x185037590", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5037C60", Offset = "0x5037060", VA = "0x185037C60")]
	public GMIONEEPOHG(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5037640", Offset = "0x5036A40", VA = "0x185037640", Slot = "8")]
	public void JEPLEFNKCLC(MOEFOGMCKBP JFCNGAACNEO, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x50378B0", Offset = "0x5036CB0", VA = "0x1850378B0", Slot = "9")]
	public void MCGHBFCIDFG(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5037910", Offset = "0x5036D10", VA = "0x185037910")]
	private Vector3 OMEFOHLKJME()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x50371F0", Offset = "0x50365F0", VA = "0x1850371F0")]
	private void IBNHFLEGKNJ(MOEFOGMCKBP OGNDGPFKDNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MGBKIHLCIPF
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5044650", Offset = "0x5043A50", VA = "0x185044650")]
	public static BAGGFLAMDAA NPPBBALHGEP(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class NHEBHCGLCEA : OMPHNJCKPCN, FFONHMBHMEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OverridableVector3 ICIKHPLKJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 KPGDKBFNDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private float BHCIOEAMLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float BGFEOHOAHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Vector3 HEDDCKELFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3? KHDOEBPONPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Quaternion? IDNFPECKBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool GCCKJICAGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool MEAOECMIEAK;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 LNPOCKOODND
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x102B2E0", Offset = "0x102A6E0", VA = "0x18102B2E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5044F40", Offset = "0x5044340", VA = "0x185044F40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 NJLILBDECGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5044D60", Offset = "0x5044160", VA = "0x185044D60", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float IDIMBBHOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x14538A0", Offset = "0x1452CA0", VA = "0x1814538A0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x5044BA0", Offset = "0x5043FA0", VA = "0x185044BA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float GCAOODIDKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x11F1B40", Offset = "0x11F0F40", VA = "0x1811F1B40", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5044B80", Offset = "0x5043F80", VA = "0x185044B80", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 LOFJDMEDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5046A10", Offset = "0x5045E10", VA = "0x185046A10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5044F60", Offset = "0x5044360", VA = "0x185044F60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion PHFFIFIDEON
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5045100", Offset = "0x5044500", VA = "0x185045100", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5047360", Offset = "0x5046760", VA = "0x185047360", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x503D2A0", Offset = "0x503C6A0", VA = "0x18503D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event CKLJAPHNLKM NDICODEJHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x5044CC0", Offset = "0x50440C0", VA = "0x185044CC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x5046210", Offset = "0x5045610", VA = "0x185046210", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5047500", Offset = "0x5046900", VA = "0x185047500")]
	public NHEBHCGLCEA(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5046B80", Offset = "0x5045F80", VA = "0x185046B80", Slot = "18")]
	public void LHNHDPFMEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5046D40", Offset = "0x5046140", VA = "0x185046D40", Slot = "17")]
	public void MNDDCBFDCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5044E60", Offset = "0x5044260", VA = "0x185044E60", Slot = "20")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5046770", Offset = "0x5045B70", VA = "0x185046770", Slot = "21")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x50471F0", Offset = "0x50465F0", VA = "0x1850471F0", Slot = "19")]
	public void OAGFHHDJOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x50462B0", Offset = "0x50456B0", VA = "0x1850462B0", Slot = "22")]
	public void IKBDJGHAHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5044F40", Offset = "0x5044340", VA = "0x185044F40")]
	private void EDMDNMPOIKG(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5047100", Offset = "0x5046500", VA = "0x185047100")]
	private Vector3 MPBPAMJKKIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5044BA0", Offset = "0x5043FA0", VA = "0x185044BA0")]
	private void AOFNDIGNFKF(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5044B80", Offset = "0x5043F80", VA = "0x185044B80")]
	private void ACOBFNFKOJD(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5046F80", Offset = "0x5046380", VA = "0x185046F80")]
	private Vector3 MOCNFHBLPOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5044F60", Offset = "0x5044360", VA = "0x185044F60")]
	private void ENDCIDFLABL(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5046E20", Offset = "0x5046220", VA = "0x185046E20")]
	private Quaternion MNFPOHMDBEA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5047360", Offset = "0x5046760", VA = "0x185047360")]
	private void OCBKHLPGCNK(Quaternion IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5045270", Offset = "0x5044670", VA = "0x185045270")]
	public void GGGMGOLJEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5045350", Offset = "0x5044750", VA = "0x185045350", Slot = "4")]
	public (float, Vector3) GGGMGOLJEJN(Rigidbody FDJPNKEOCML)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class HPGKPBGIDIM
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5038E80", Offset = "0x5038280", VA = "0x185038E80")]
	public static OMPHNJCKPCN PADFLPJNEEG(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JMOPAJNKOLH : HCDIAGKJOKB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string KGPDFBEICML = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AKHDANBKPMC OBHGGAKKMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly OMABPCEAJCN DJKGDJKALKK;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool NIDJDKKDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x100B7F0", Offset = "0x100ABF0", VA = "0x18100B7F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public OMABPCEAJCN LEEEKIFGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010", Slot = "5")]
		get
		{
			return default(OMABPCEAJCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x503B990", Offset = "0x503AD90", VA = "0x18503B990")]
	public JMOPAJNKOLH(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x503B3E0", Offset = "0x503A7E0", VA = "0x18503B3E0", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x503B630", Offset = "0x503AA30", VA = "0x18503B630")]
	private bool FBNEOJMBAEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x503B380", Offset = "0x503A780", VA = "0x18503B380", Slot = "7")]
	public void AIENKBIMAED(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x503B3B0", Offset = "0x503A7B0", VA = "0x18503B3B0", Slot = "8")]
	public void CMBEGJNJAFJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x503B6D0", Offset = "0x503AAD0", VA = "0x18503B6D0", Slot = "11")]
	public void HBFPKEEJCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x503B800", Offset = "0x503AC00", VA = "0x18503B800")]
	private void MBNNEHKOBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x503B4B0", Offset = "0x503A8B0", VA = "0x18503B4B0")]
	private void DLHGBLHEAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x503B910", Offset = "0x503AD10", VA = "0x18503B910", Slot = "10")]
	public void NEEGCBFLJPC(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x503B950", Offset = "0x503AD50", VA = "0x18503B950", Slot = "9")]
	public void OPIJJDDGIJN(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class DPDGLGMPJLI : KHOEFPLAJFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly AKHDANBKPMC LPAEHLJPBGB;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool DLHNEBDBKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x502E4E0", Offset = "0x502D8E0", VA = "0x18502E4E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> POMBOBCBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x502E3A0", Offset = "0x502D7A0", VA = "0x18502E3A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event CKLJAPHNLKM MEHLGLPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x502E440", Offset = "0x502D840", VA = "0x18502E440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x502E300", Offset = "0x502D700", VA = "0x18502E300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x502E820", Offset = "0x502DC20", VA = "0x18502E820")]
	public DPDGLGMPJLI(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x502E690", Offset = "0x502DA90", VA = "0x18502E690", Slot = "11")]
	public IDisposable IOAAKHBHNGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x502E5A0", Offset = "0x502D9A0", VA = "0x18502E5A0", Slot = "8")]
	public void EPIPAEBMEKC(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x502E680", Offset = "0x502DA80", VA = "0x18502E680", Slot = "9")]
	public void IMHAINEJFMJ(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x502E720", Offset = "0x502DB20", VA = "0x18502E720", Slot = "10")]
	public void MAGDAECPPID(object MJNGPHMPILM, bool NIFMDNMIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x502E3C0", Offset = "0x502D7C0", VA = "0x18502E3C0", Slot = "12")]
	public void DODLGDLPNBJ(Rigidbody GAOHKMMENID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x502E6F0", Offset = "0x502DAF0", VA = "0x18502E6F0", Slot = "13")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class FMLHGLHLJKP : NKFKJEOMMME, OKGPPOGBFMI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private PhotonView DKHPAPAKJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool FBDHEJNBGFP;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView PHLEMNLJONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool AKHFDGNNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x5035270", Offset = "0x5034670", VA = "0x185035270", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool FNBKGIKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event CKLJAPHNLKM PNGOIJCLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x50369C0", Offset = "0x5035DC0", VA = "0x1850369C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x5036A60", Offset = "0x5035E60", VA = "0x185036A60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5037070", Offset = "0x5036470", VA = "0x185037070")]
	public FMLHGLHLJKP(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5036440", Offset = "0x5035840", VA = "0x185036440", Slot = "9")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5036720", Offset = "0x5035B20", VA = "0x185036720", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5036830", Offset = "0x5035C30", VA = "0x185036830", Slot = "10")]
	public void EDEMAKMNMLM(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5036590", Offset = "0x5035990", VA = "0x185036590", Slot = "11")]
	public void DDOJIPNNAPF(MOEFOGMCKBP JFCNGAACNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5036EF0", Offset = "0x50362F0", VA = "0x185036EF0")]
	private void OAPEMOFBBCI(PhotonView PDNOGDFFKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x5036B00", Offset = "0x5035F00", VA = "0x185036B00")]
	private void MPJCMFHMMIF(RigidbodyEx OLLGOPFNHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5036C70", Offset = "0x5036070", VA = "0x185036C70")]
	private void NKPCPPPCOLB(PhotonView OGOAKIJNCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class CDLNLHBFEFA
{
	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x502C8E0", Offset = "0x502BCE0", VA = "0x18502C8E0")]
	public static NKFKJEOMMME KGFKDKMKHCO(this MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class BMBIDHHBIHM : DKAJJIAJAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private RigidbodyConstraints DMPHDKHPPGP;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool OHOLAJEIPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AE0", Offset = "0xAAFEE0", VA = "0x180AB0AE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x22455D0", Offset = "0x22449D0", VA = "0x1822455D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool PAHIOOGCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2402130", Offset = "0x2401530", VA = "0x182402130", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2402120", Offset = "0x2401520", VA = "0x182402120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints PLAEKNPFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5028DA0", Offset = "0x50281A0", VA = "0x185028DA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5028F10", Offset = "0x5028310", VA = "0x185028F10")]
	public BMBIDHHBIHM(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5028D70", Offset = "0x5028170", VA = "0x185028D70", Slot = "9")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x5028EE0", Offset = "0x50282E0", VA = "0x185028EE0", Slot = "10")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HHKFBFCKEIJ : DJKOOKOCBBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly MOEFOGMCKBP BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float OGMFBNAEINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float KCCFOKBJFJI;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float CIMNKBCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x1030690", Offset = "0x102FA90", VA = "0x181030690", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5037D50", Offset = "0x5037150", VA = "0x185037D50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float MGEPOBJEHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1030680", Offset = "0x102FA80", VA = "0x181030680", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5037E20", Offset = "0x5037220", VA = "0x185037E20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x5037FE0", Offset = "0x50373E0", VA = "0x185037FE0")]
	public HHKFBFCKEIJ(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5037EF0", Offset = "0x50372F0", VA = "0x185037EF0", Slot = "8")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5037F40", Offset = "0x5037340", VA = "0x185037F40", Slot = "9")]
	public void JHANLBAFJCE(Rigidbody DGOFHFLMDGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class KEPMJCLFCPA : EHJNFOLMBKE
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const int LGDAPAINMOO = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const float KGAPEFMHBOB = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float KDDJGNACKDP = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float CPNONKGFIMC = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool AODKPIHCPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool PKCFAEIIGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int APKPLOMBJIG;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x503D2A0", Offset = "0x503C6A0", VA = "0x18503D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool EDPFKNJAFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x503DB80", Offset = "0x503CF80", VA = "0x18503DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x503CFD0", Offset = "0x503C3D0", VA = "0x18503CFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private MOEFOGMCKBP AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x503D4C0", Offset = "0x503C8C0", VA = "0x18503D4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x503D230", Offset = "0x503C630", VA = "0x18503D230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event CKLJAPHNLKM OPHAOHPDLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x503D670", Offset = "0x503CA70", VA = "0x18503D670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x503D710", Offset = "0x503CB10", VA = "0x18503D710", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x503DC20", Offset = "0x503D020", VA = "0x18503DC20")]
	public KEPMJCLFCPA(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x503CFF0", Offset = "0x503C3F0", VA = "0x18503CFF0", Slot = "6")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x503D290", Offset = "0x503C690", VA = "0x18503D290", Slot = "8")]
	public void HNMIICJHFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x503D520", Offset = "0x503C920", VA = "0x18503D520", Slot = "7")]
	public bool KPFDKFMNBJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x503CF30", Offset = "0x503C330", VA = "0x18503CF30", Slot = "9")]
	public void ANCJCOBPGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x503D7B0", Offset = "0x503CBB0", VA = "0x18503D7B0", Slot = "11")]
	public void NNJBHKHMMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x503D480", Offset = "0x503C880", VA = "0x18503D480", Slot = "12")]
	public void JNBPEOADCFI(bool FBMIBFGCBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x503D850", Offset = "0x503CC50", VA = "0x18503D850", Slot = "10")]
	public void OPAFANIKDAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x503D080", Offset = "0x503C480", VA = "0x18503D080")]
	private bool GEBLKEPACPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x503D2F0", Offset = "0x503C6F0", VA = "0x18503D2F0")]
	private void HPPGLJCIKNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class AGEKKCPMMBH : HHKLONHDBCP
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const string NNDBDBLKNJH = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly AKHDANBKPMC BIIAHPKCFPK;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody AIKMBCIHNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool FMDHJHCNPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x50286C0", Offset = "0x5027AC0", VA = "0x1850286C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5028C80", Offset = "0x5028080", VA = "0x185028C80")]
	public AGEKKCPMMBH(MOEFOGMCKBP BCFNKEDGEDJ, in JPIMKKACAGA PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5027E10", Offset = "0x5027210", VA = "0x185027E10", Slot = "5")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5027EC0", Offset = "0x50272C0", VA = "0x185027EC0", Slot = "6")]
	public void DLOKMFJCJPL(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5027C30", Offset = "0x5027030", VA = "0x185027C30", Slot = "7")]
	public void ALOKAEHFLOF(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5028920", Offset = "0x5027D20", VA = "0x185028920", Slot = "8")]
	public void ODFAIAHCPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5028720", Offset = "0x5027B20", VA = "0x185028720", Slot = "9")]
	public void JIKCGGCJNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5028390", Offset = "0x5027790", VA = "0x185028390", Slot = "10")]
	public void HEBJIGNJHJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5027EF0", Offset = "0x50272F0", VA = "0x185027EF0", Slot = "11")]
	public void EIKELGJGOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5027C60", Offset = "0x5027060", VA = "0x185027C60")]
	private void BJHCOMPNNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5028510", Offset = "0x5027910", VA = "0x185028510")]
	private void HEIGHNEHJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class DPOHGGMICDF : JCDDIDCNMEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly LPOINMJCEJA BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly AKHDANBKPMC IOLILLDKJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float AOMKBDHPMLB;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public IGLAABABGOP MPPOHEOFGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public OCAOBGNCGFH GHDMHBNFFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 DJEOCKCADPC
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x502F7F0", Offset = "0x502EBF0", VA = "0x18502F7F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x502FE60", Offset = "0x502F260", VA = "0x18502FE60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 PDJBPIFPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5031060", Offset = "0x5030460", VA = "0x185031060", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5031290", Offset = "0x5030690", VA = "0x185031290", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 GEPBDMGPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x50312C0", Offset = "0x50306C0", VA = "0x1850312C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x502EB40", Offset = "0x502DF40", VA = "0x18502EB40", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 CEPBHMNGOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x50300D0", Offset = "0x502F4D0", VA = "0x1850300D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x502F340", Offset = "0x502E740", VA = "0x18502F340", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float JABOBOHPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1088B00", Offset = "0x1087F00", VA = "0x181088B00", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x50301C0", Offset = "0x502F5C0", VA = "0x1850301C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool MNNOGIBHHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1020190", Offset = "0x101F590", VA = "0x181020190", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private LFDDJBANODG AMEAGKIDCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x1B5D240", Offset = "0x1B5C640", VA = "0x181B5D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool DGNLMJKGDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x502D180", Offset = "0x502C580", VA = "0x18502D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x50318F0", Offset = "0x5030CF0", VA = "0x1850318F0")]
	public DPOHGGMICDF(MOEFOGMCKBP BCFNKEDGEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x502F370", Offset = "0x502E770", VA = "0x18502F370", Slot = "19")]
	public void COBCLAGHHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x502F750", Offset = "0x502EB50", VA = "0x18502F750", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x502F620", Offset = "0x502EA20", VA = "0x18502F620", Slot = "28")]
	public void DODLGDLPNBJ(Rigidbody DGOFHFLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x101F4F0", Offset = "0x101E8F0", VA = "0x18101F4F0", Slot = "20")]
	public void BCHCHPECDKN(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x101FD60", Offset = "0x101F160", VA = "0x18101FD60", Slot = "31")]
	public void NNHLDFPJICN(object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x502F910", Offset = "0x502ED10", VA = "0x18502F910", Slot = "36")]
	public Vector3 FAMKIHLGABC(Vector3 GFENFADPBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x502ED30", Offset = "0x502E130", VA = "0x18502ED30", Slot = "35")]
	public Vector3 CAGCLFIOOCK(Vector3 IBINHIACJHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x502F370", Offset = "0x502E770", VA = "0x18502F370", Slot = "27")]
	public void DKFBDOCLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x502FAF0", Offset = "0x502EEF0", VA = "0x18502FAF0", Slot = "25")]
	public void FCLOHKDNJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x502F7B0", Offset = "0x502EBB0", VA = "0x18502F7B0", Slot = "24")]
	public void EIDMJDCHHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x502F3E0", Offset = "0x502E7E0", VA = "0x18502F3E0", Slot = "34")]
	public void DFOJMPEMMOP(Vector3 AAAKDPCBLLO, Vector3 OLFNIEFCLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x50302E0", Offset = "0x502F6E0", VA = "0x1850302E0", Slot = "33")]
	public void IGPEHPJDIMP(Vector3 EPKHEMAGDNO, Vector3 PKHHPIFOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5031150", Offset = "0x5030550", VA = "0x185031150", Slot = "32")]
	public void MGMFBINMOAG(Vector3 MEPDHFGMHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x502EEF0", Offset = "0x502E2F0", VA = "0x18502EEF0", Slot = "22")]
	public void CLMAGKFHCKJ(OKBCKLHECLO AFJIJGKHGDD, Vector3 INHBJADHCCK, float CKJCMEGFCIO, float DDGPMABKELO = 8f, float JNCFKKPHMEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x50313F0", Offset = "0x50307F0", VA = "0x1850313F0", Slot = "21")]
	public void OJMOAFLNHBA(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 CPFFKJJFDKF, float MKMALFEDBGP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5031620", Offset = "0x5030A20", VA = "0x185031620", Slot = "23")]
	[Obsolete]
	public void OLGMBHMCFFO(AJDKHDDFJDJ OLBKLOGBIIK, Vector3 IAPKIBMDFEP, float LDGHKOOGDAF = 7f, float GKOIKFLOJNA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x50309A0", Offset = "0x502FDA0", VA = "0x1850309A0", Slot = "30")]
	public Vector3 KPCKJBEFMPA(Vector3 EAMJDCGEMLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x502FFE0", Offset = "0x502F3E0", VA = "0x18502FFE0", Slot = "29")]
	public Vector3 HBHKKFLNBPP(Vector3 BPNOJOBDHCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x502EC00", Offset = "0x502E000", VA = "0x18502EC00", Slot = "26")]
	public void BPOMELIBGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x50301C0", Offset = "0x502F5C0", VA = "0x1850301C0")]
	private void KCHHHANJEOB(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5030770", Offset = "0x502FB70", VA = "0x185030770")]
	private void KIHHCFBBBDE(Vector3 CPFFKJJFDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5030680", Offset = "0x502FA80", VA = "0x185030680")]
	private Vector3 JLNDMGPEACL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x502FB30", Offset = "0x502EF30", VA = "0x18502FB30")]
	private void FFEMPINGOKL(Vector3 IBINHIACJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x50308B0", Offset = "0x502FCB0", VA = "0x1850308B0")]
	private Vector3 KIODBDOEPHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5030340", Offset = "0x502F740", VA = "0x185030340")]
	private void JDKPEJGDLFI(Vector3 IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5030A60", Offset = "0x502FE60", VA = "0x185030A60")]
	private void LHEBIHJPLOL(Vector3 IBINHIACJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x502FF20", Offset = "0x502F320", VA = "0x18502FF20")]
	private void GEFHBPCJAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HMFCDMCHAIL : LILHCMCOEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5038020", Offset = "0x5037420", VA = "0x185038020", Slot = "4")]
	public IJBGKFLLKGL AGFICOJOKMA(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5038BF0", Offset = "0x5037FF0", VA = "0x185038BF0", Slot = "5")]
	public JCDDIDCNMEM OLMKBEOJODC(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5038770", Offset = "0x5037B70", VA = "0x185038770", Slot = "6")]
	public PLKCBOFCHOP GOGOHDMIFAP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5038530", Offset = "0x5037930", VA = "0x185038530", Slot = "7")]
	public DJKOOKOCBBL FPHLJCEEMCP(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5038B30", Offset = "0x5037F30", VA = "0x185038B30", Slot = "8")]
	public EHJNFOLMBKE OFCGOGHHCDK(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5038950", Offset = "0x5037D50", VA = "0x185038950", Slot = "9")]
	public CEEOOLNBEAB JHBNNELEDNF(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5038380", Offset = "0x5037780", VA = "0x185038380", Slot = "10")]
	public KHOEFPLAJFD ELPGNALAKAD(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x50386C0", Offset = "0x5037AC0", VA = "0x1850386C0", Slot = "11")]
	public LFDDJBANODG GBGJMGFKGNH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5038480", Offset = "0x5037880", VA = "0x185038480", Slot = "12")]
	public CMGALEDPEOD FADNALMPLHJ(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5038D00", Offset = "0x5038100", VA = "0x185038D00", Slot = "13")]
	public NIHFMIHDEJO PKCPGPAMJKH(MOEFOGMCKBP BDGKEIOKECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x50385A0", Offset = "0x50379A0", VA = "0x1850385A0")]
	public HHKLONHDBCP FPIDOEFIGKO(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5038100", Offset = "0x5037500", VA = "0x185038100")]
	public OKGPPOGBFMI AMMKHOJLEHJ(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5038A10", Offset = "0x5037E10", VA = "0x185038A10")]
	public HCDIAGKJOKB NGDEPNHKILK(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5038280", Offset = "0x5037680", VA = "0x185038280")]
	public FFONHMBHMEF LOAAEMBOPCE(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5038880", Offset = "0x5037C80", VA = "0x185038880")]
	public DKAJJIAJAGC HPFNKKLNJCL(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x50381D0", Offset = "0x50375D0", VA = "0x1850381D0", Slot = "19")]
	public MOEFOGMCKBP CJCCPFKOKKA(RigidbodyEx BCFNKEDGEDJ, JPIMKKACAGA PNMIIEJFOON, MOCBKGLLLEF LHHJJDCDFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HMFCDMCHAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x50385A0", Offset = "0x50379A0", VA = "0x1850385A0", Slot = "14")]
	private HHKLONHDBCP KMFMCLEDKBN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5038100", Offset = "0x5037500", VA = "0x185038100", Slot = "15")]
	private OKGPPOGBFMI BLDPIPCPFIH(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5038A10", Offset = "0x5037E10", VA = "0x185038A10", Slot = "16")]
	private HCDIAGKJOKB JKOAIHDOPFC(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5038280", Offset = "0x5037680", VA = "0x185038280", Slot = "17")]
	private FFONHMBHMEF EDPIHFGAJIA(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5038880", Offset = "0x5037C80", VA = "0x185038880", Slot = "18")]
	private DKAJJIAJAGC HCCIKPPBDPN(MOEFOGMCKBP BDGKEIOKECF, in JPIMKKACAGA PNMIIEJFOON)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6064BE0", Offset = "0x6063FE0", VA = "0x186064BE0", Slot = "6")]
		public sealed override void FOLCGPFLFII(JPJOAJAPKJJ MCFINHLOBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x6064DC0", Offset = "0x60641C0", VA = "0x186064DC0", Slot = "4")]
		public sealed override void PJNICPDDEAL()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5047990", Offset = "0x5046D90", VA = "0x185047990")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5047AA0", Offset = "0x5046EA0", VA = "0x185047AA0")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
