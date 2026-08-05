using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F15BA0", Offset = "0x6F145A0", VA = "0x186F15BA0", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : KNDIHPLNFAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GMBGGGKOBCM bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14DAB10", Offset = "0x14D9510", VA = "0x1814DAB10", Slot = "5")]
		public override void BJJKNHPAGFH(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F25E30", Offset = "0x6F24830", VA = "0x186F25E30")]
		private void PDCGCIGJIBA(MFILPAPNOLD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F25DD0", Offset = "0x6F247D0", VA = "0x186F25DD0", Slot = "6")]
		public override void LBKEFPFAKCK(MFILPAPNOLD registry, [In] EONNNAINMIG filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "8")]
		public override void JNGALHFGLMK(FBOEMILKFHO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F26130", Offset = "0x6F24B30", VA = "0x186F26130")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HMIKMKPGKPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LGKLDLNGEGN NGCDLIDONJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool BFBDOFCMLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private JKJIEFIICJB BELHHBONLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[GAAOMKKOEKA(MJDOLBEDPIO.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GAAOMKKOEKA(MJDOLBEDPIO.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private AHFBHELEKED physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal JKJIEFIICJB GOADNKKLIAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F21400", Offset = "0x6F1FE00", VA = "0x186F21400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private JKJIEFIICJB NKJDKGGKJED
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KPPAJCGFPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F23240", Offset = "0x6F21C40", VA = "0x186F23240")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx LCAAKADGFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F235A0", Offset = "0x6F21FA0", VA = "0x186F235A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx CMJBHOFLJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F234E0", Offset = "0x6F21EE0", VA = "0x186F234E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx EMNGIAIDBPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F24240", Offset = "0x6F22C40", VA = "0x186F24240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F25740", Offset = "0x6F24140", VA = "0x186F25740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ANDFGINGEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x875FF0", Offset = "0x8749F0", VA = "0x180875FF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JHFGJGILODH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x875FF0", Offset = "0x8749F0", VA = "0x180875FF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ALFJCHGPFEB JODJINPJKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F232A0", Offset = "0x6F21CA0", VA = "0x186F232A0")]
			get
			{
				return default(ALFJCHGPFEB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F24EF0", Offset = "0x6F238F0", VA = "0x186F24EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OJBMLGHDKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F238B0", Offset = "0x6F222B0", VA = "0x186F238B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OLEIKJADGKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F233C0", Offset = "0x6F21DC0", VA = "0x186F233C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EBKBOJHOLGL GBKKBMKCHLE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F237F0", Offset = "0x6F221F0", VA = "0x186F237F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F250B0", Offset = "0x6F23AB0", VA = "0x186F250B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EGCBEDHFHPO APDAHLMFMPI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F23790", Offset = "0x6F22190", VA = "0x186F23790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F25040", Offset = "0x6F23A40", VA = "0x186F25040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool GAOHMGIOIKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F236E0", Offset = "0x6F220E0", VA = "0x186F236E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody ANKDGFGHEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F23740", Offset = "0x6F22140", VA = "0x186F23740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DOLMDGJBAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F23420", Offset = "0x6F21E20", VA = "0x186F23420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F24F60", Offset = "0x6F23960", VA = "0x186F24F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KMJLNIADHEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6630380", Offset = "0x662ED80", VA = "0x186630380", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float AHMELKGLCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F241E0", Offset = "0x6F22BE0", VA = "0x186F241E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float LODEJFOHOJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F24180", Offset = "0x6F22B80", VA = "0x186F24180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F256D0", Offset = "0x6F240D0", VA = "0x186F256D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EOBNNHKBNDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F23B10", Offset = "0x6F22510", VA = "0x186F23B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F25350", Offset = "0x6F23D50", VA = "0x186F25350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LGJHLMDJPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F23910", Offset = "0x6F22310", VA = "0x186F23910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F25120", Offset = "0x6F23B20", VA = "0x186F25120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NOEDFKHBPAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F24790", Offset = "0x6F23190", VA = "0x186F24790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F25C80", Offset = "0x6F24680", VA = "0x186F25C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 HOLHIMCPIOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F23F60", Offset = "0x6F22960", VA = "0x186F23F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F254A0", Offset = "0x6F23EA0", VA = "0x186F254A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 CIBHOHOPPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F248D0", Offset = "0x6F232D0", VA = "0x186F248D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode MLKJEMHHAPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F23A50", Offset = "0x6F22450", VA = "0x186F23A50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F25270", Offset = "0x6F23C70", VA = "0x186F25270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float HCFPALINGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F23480", Offset = "0x6F21E80", VA = "0x186F23480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F24FD0", Offset = "0x6F239D0", VA = "0x186F24FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints DKFFHGEIPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F23AB0", Offset = "0x6F224B0", VA = "0x186F23AB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F252E0", Offset = "0x6F23CE0", VA = "0x186F252E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 EEACBFIEJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F24300", Offset = "0x6F22D00", VA = "0x186F24300")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 MBHJJJNHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F24300", Offset = "0x6F22D00", VA = "0x186F24300")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F25A60", Offset = "0x6F24460", VA = "0x186F25A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MPJHHFFMCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F24040", Offset = "0x6F22A40", VA = "0x186F24040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F25580", Offset = "0x6F23F80", VA = "0x186F25580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float JIKPOHHGNGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F24730", Offset = "0x6F23130", VA = "0x186F24730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F25C10", Offset = "0x6F24610", VA = "0x186F25C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion MNNCANMMGIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F243E0", Offset = "0x6F22DE0", VA = "0x186F243E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F257E0", Offset = "0x6F241E0", VA = "0x186F257E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion IFDBNFBKKAA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F24660", Offset = "0x6F23060", VA = "0x186F24660")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F25B40", Offset = "0x6F24540", VA = "0x186F25B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 IKCLOKDNJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F244B0", Offset = "0x6F22EB0", VA = "0x186F244B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F258B0", Offset = "0x6F242B0", VA = "0x186F258B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MNBDLJMINCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F24590", Offset = "0x6F22F90", VA = "0x186F24590")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F25990", Offset = "0x6F24390", VA = "0x186F25990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PBGBFAMBAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F247F0", Offset = "0x6F231F0", VA = "0x186F247F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F25CF0", Offset = "0x6F246F0", VA = "0x186F25CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 LNGMMPKBNBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F240A0", Offset = "0x6F22AA0", VA = "0x186F240A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F255F0", Offset = "0x6F23FF0", VA = "0x186F255F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FJPMHBKDAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F23970", Offset = "0x6F22370", VA = "0x186F23970")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F25190", Offset = "0x6F23B90", VA = "0x186F25190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AMLNDCBAFED
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F23E80", Offset = "0x6F22880", VA = "0x186F23E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F253C0", Offset = "0x6F23DC0", VA = "0x186F253C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 GHBEHJPLLBG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F23D40", Offset = "0x6F22740", VA = "0x186F23D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion PDEGLHKGEJC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F23C70", Offset = "0x6F22670", VA = "0x186F23C70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CIAKGELLOAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F24A90", Offset = "0x6F23490", VA = "0x186F24A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 FIMDFOLPKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F249B0", Offset = "0x6F233B0", VA = "0x186F249B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JHPCHHNCNCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F23E20", Offset = "0x6F22820", VA = "0x186F23E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KOEEFHLGECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F23850", Offset = "0x6F22250", VA = "0x186F23850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CNHCOJFGPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F23360", Offset = "0x6F21D60", VA = "0x186F23360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BBNFHNPPLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F23300", Offset = "0x6F21D00", VA = "0x186F23300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BBMLDLGJCJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F231E0", Offset = "0x6F21BE0", VA = "0x186F231E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PDNFODBANLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F23B70", Offset = "0x6F22570", VA = "0x186F23B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool NMLOGLDCMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x23DF720", Offset = "0x23DE120", VA = "0x1823DF720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JDMIOPHFEMM GOEDHNFBDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F23100", Offset = "0x6F21B00", VA = "0x186F23100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F24E10", Offset = "0x6F23810", VA = "0x186F24E10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FAKKNJDHEEJ EEIPCPBLFLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6F22E70", Offset = "0x6F21870", VA = "0x186F22E70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F24B70", Offset = "0x6F23570", VA = "0x186F24B70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FAKKNJDHEEJ OGJCLDNCBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F22ED0", Offset = "0x6F218D0", VA = "0x186F22ED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F24BE0", Offset = "0x6F235E0", VA = "0x186F24BE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FAKKNJDHEEJ OGAKFGNKACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F23020", Offset = "0x6F21A20", VA = "0x186F23020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F24D30", Offset = "0x6F23730", VA = "0x186F24D30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<KFIHHKNEBMF, KFIHHKNEBMF> ACAFKCPEHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F22FB0", Offset = "0x6F219B0", VA = "0x186F22FB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F24CC0", Offset = "0x6F236C0", VA = "0x186F24CC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event FAKKNJDHEEJ PLFBLIHDHJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F23090", Offset = "0x6F21A90", VA = "0x186F23090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F24DA0", Offset = "0x6F237A0", VA = "0x186F24DA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FAKKNJDHEEJ BAMGNCLGAKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F23170", Offset = "0x6F21B70", VA = "0x186F23170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F24E80", Offset = "0x6F23880", VA = "0x186F24E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FAKKNJDHEEJ EIKDMIJICCO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F22F40", Offset = "0x6F21940", VA = "0x186F22F40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F24C50", Offset = "0x6F23650", VA = "0x186F24C50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40", Slot = "8")]
		private void IBHNCIOOKIJ(JKJIEFIICJB PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F21EE0", Offset = "0x6F208E0", VA = "0x186F21EE0")]
		internal void PABIGNPBKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F22B90", Offset = "0x6F21590", VA = "0x186F22B90")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody BMGJPPIBOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F218A0", Offset = "0x6F202A0", VA = "0x186F218A0")]
		public HMIKMKPGKPD GetChild(int ILOCEPPJPDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F22800", Offset = "0x6F21200", VA = "0x186F22800")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IIFLMEOHBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F21390", Offset = "0x6F1FD90", VA = "0x186F21390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F21400", Offset = "0x6F1FE00", VA = "0x186F21400")]
		private JKJIEFIICJB BIJPOBHBPOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F21690", Offset = "0x6F20090", VA = "0x186F21690")]
		private void GKMPMEFLHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F21FD0", Offset = "0x6F209D0", VA = "0x186F21FD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F21EE0", Offset = "0x6F208E0", VA = "0x186F21EE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F21F70", Offset = "0x6F20970", VA = "0x186F21F70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F22030", Offset = "0x6F20A30", VA = "0x186F22030")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F20980", Offset = "0x6F1F380", VA = "0x186F20980")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F22090", Offset = "0x6F20A90", VA = "0x186F22090")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F21630", Offset = "0x6F20030", VA = "0x186F21630")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F21E80", Offset = "0x6F20880", VA = "0x186F21E80")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F22960", Offset = "0x6F21360", VA = "0x186F22960")]
		public void SetParent(RigidbodyEx DBOBEHLEAAE, bool OLBIGMEKFFD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F223A0", Offset = "0x6F20DA0", VA = "0x186F223A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F21B50", Offset = "0x6F20550", VA = "0x186F21B50")]
		public bool IsRigidbodyAncestor(RigidbodyEx MBEHGJAPFNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F21C30", Offset = "0x6F20630", VA = "0x186F21C30")]
		public bool IsRigidbodyDescendant(RigidbodyEx JNDKJGHBBAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F20BF0", Offset = "0x6F1F5F0", VA = "0x186F20BF0")]
		public void AddInterpolationRestriction(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F22100", Offset = "0x6F20B00", VA = "0x186F22100")]
		public void RemoveInterpolationRestriction(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F20C60", Offset = "0x6F1F660", VA = "0x186F20C60")]
		public void AddKinematic(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F22170", Offset = "0x6F20B70", VA = "0x186F22170")]
		public void RemoveKinematic(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F228E0", Offset = "0x6F212E0", VA = "0x186F228E0")]
		public void SetKinematic(object JCIFCENKMKP, bool MGPOKEFPGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F22700", Offset = "0x6F21100", VA = "0x186F22700")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PPBFOEBKKOC, Quaternion EKPDKJAAKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F22600", Offset = "0x6F21000", VA = "0x186F22600")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 CDCOLBIEICK, Quaternion KIJAKHEBLHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F21A40", Offset = "0x6F20440", VA = "0x186F21A40")]
		public Vector3 GetConstrainedVelocity(Vector3 PBGBFAMBAMF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F21930", Offset = "0x6F20330", VA = "0x186F21930")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FJPMHBKDAMB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F20B00", Offset = "0x6F1F500", VA = "0x186F20B00")]
		public void AddForce(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F209F0", Offset = "0x6F1F3F0", VA = "0x186F209F0")]
		public void AddForceAtPosition(Vector3 JFKDELALDJD, Vector3 GLNEOPDBMFP, ForceMode HFPFADDBPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F20E30", Offset = "0x6F1F830", VA = "0x186F20E30")]
		public void AddTorque(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F20CD0", Offset = "0x6F1F6D0", VA = "0x186F20CD0")]
		public void AddRelativeTorque(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F22C60", Offset = "0x6F21660", VA = "0x186F22C60")]
		public Vector3 WorldToLocalVelocity(Vector3 PJHDGKKEAIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F21D70", Offset = "0x6F20770", VA = "0x186F21D70")]
		public Vector3 LocalToWorldVelocity(Vector3 LNGMMPKBNBD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F215D0", Offset = "0x6F1FFD0", VA = "0x186F215D0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F21570", Offset = "0x6F1FF70", VA = "0x186F21570")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F21510", Offset = "0x6F1FF10", VA = "0x186F21510")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F214B0", Offset = "0x6F1FEB0", VA = "0x186F214B0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F22500", Offset = "0x6F20F00", VA = "0x186F22500")]
		public void ResetVelocityWorldSpace(Vector3 LADJHAOBEDO, Vector3 HEFMKCBGOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F22400", Offset = "0x6F20E00", VA = "0x186F22400")]
		public void ResetVelocityLocalSpace(Vector3 PIFHENFKDHB, Vector3 AMLNDCBAFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F222C0", Offset = "0x6F20CC0", VA = "0x186F222C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 PIFHENFKDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A90", Offset = "0x6F21490", VA = "0x186F22A90")]
		public bool SweepTest(Vector3 NMAFDGGPBKA, [Out] RaycastHit KGGKMKMJHGJ, float APKOACGHEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F21D10", Offset = "0x6F20710", VA = "0x186F21D10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F22A30", Offset = "0x6F21430", VA = "0x186F22A30")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F22C00", Offset = "0x6F21600", VA = "0x186F22C00")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F20DC0", Offset = "0x6F1F7C0", VA = "0x186F20DC0")]
		public void AddShouldHaveUnityRigidbodyToken(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F221E0", Offset = "0x6F20BE0", VA = "0x186F221E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F211C0", Offset = "0x6F1FBC0", VA = "0x186F211C0")]
		public void ApplyForceVelocityChange(KELPIDMOECD PNOFGNKBEPL, Vector3 LCCMGOJPBMA, float IGGAJLACDEJ, float LFEDGHAJLBJ = 8f, float DELKKLHPPEP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F210C0", Offset = "0x6F1FAC0", VA = "0x186F210C0")]
		public void ApplyAngularVelocityChange(DAOMMCIAOEJ NGLIKOKHABN, Vector3 HDLPFGDIGCD, float KAKBEDIMKEC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F21280", Offset = "0x6F1FC80", VA = "0x186F21280")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(DAOMMCIAOEJ NGLIKOKHABN, Vector3 NGGFFKDNCFB, float EIPKJPHAGMD = 7f, float JHPDDNKFPBF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F20FF0", Offset = "0x6F1F9F0", VA = "0x186F20FF0")]
		public bool AllowedScaleChange(float MCFAHFLECNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F20F20", Offset = "0x6F1F920", VA = "0x186F20F20")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CNBPKDOLLMB, object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F22250", Offset = "0x6F20C50", VA = "0x186F22250")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F22E00", Offset = "0x6F21800", VA = "0x186F22E00")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9399A0", Offset = "0x9383A0", VA = "0x1809399A0", Slot = "4")]
		private GameObject DAEPCDCFLIM()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x875FF0", Offset = "0x8749F0", VA = "0x180875FF0", Slot = "5")]
		private Transform PJMEFKBGHLF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class NKFCIENBONJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F17260", Offset = "0x6F15C60", VA = "0x186F17260")]
	public static JKJIEFIICJB GOADNKKLIAB(this RigidbodyEx JPICPJHAJDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JFDKKALIBKJ(typeof(EMPFNOOEPJM), new string[] { })]
public class JLLCGKBMOJH : EMPFNOOEPJM, GMAJAMLLCFH
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private IKJAJBIJIFA LGMHNFLKCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MFJECFDCBJN GLFIGPDLPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IPJOGHOIABB MGIHDNDIIJE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MFJECFDCBJN NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IPJOGHOIABB PODBIEHACML
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F11420", Offset = "0x6F0FE20", VA = "0x186F11420", Slot = "7")]
	public void InitReferences(GHEIIEALIKL PFLLPPCJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F11320", Offset = "0x6F0FD20", VA = "0x186F11320", Slot = "6")]
	public JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public JLLCGKBMOJH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static MNIMPDIHNFL UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int KJBPJNENICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MBKBANHHPDK;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F207E0", Offset = "0x6F1F1E0", VA = "0x186F207E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F20820", Offset = "0x6F1F220", VA = "0x186F20820")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F20800", Offset = "0x6F1F200", VA = "0x186F20800")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BDCMABOIIFF, [Optional] UnityEngine.Object NIDJKNBFFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BDCMABOIIFF, [Optional] UnityEngine.Object NIDJKNBFFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F20930", Offset = "0x6F1F330", VA = "0x186F20930")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LMGFJPBIIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FBLCEJHMKDP : EBKBOJHOLGL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85CCE0", Offset = "0x85B6E0", VA = "0x18085CCE0", Slot = "4")]
		public Vector3 BNHJBOOGGCI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85CCE0", Offset = "0x85B6E0", VA = "0x18085CCE0", Slot = "5")]
		public Vector3 DKAMHJAJBPM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FBLCEJHMKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static EBKBOJHOLGL PGPEEFMKKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F15AD0", Offset = "0x6F144D0", VA = "0x186F15AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FKCJNGDPCJI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode AEDNJJODHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFGPEGKJPJL(bool JHPCHHNCNCC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDJEPIAGAKJ(bool JHPCHHNCNCC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GGEPOKHBBLE(Vector3 NMAFDGGPBKA, [Out] RaycastHit KGGKMKMJHGJ, float APKOACGHEPL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MNMPCDCLANA : IDisposable, JBPMFOFDJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ALFJCHGPFEB JODJINPJKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KFIHHKNEBMF, KFIHHKNEBMF> ACAFKCPEHDK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GONOBOFENIO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface IPJOGHOIABB
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJMGAKOPHDJ KDPCODADEKH(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BJGJEGGBHHA BLAIIKGBILL(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ILNIDINBIEN HGBJPOJGNGB(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PBPJIJDKDHN IKEIHNBHKCN(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PPPDHPAGOPC GMEJLMGKEDI(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MNMPCDCLANA KBMDIJNBHEP(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EPJABEBNPGG ODECDCFOAPP(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KPONNBMBLDC NONCLLPKGDN(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FKCJNGDPCJI CBMNKPBHALG(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GMKCHJIFHIP LDPOOOPMCHO(JKJIEFIICJB PEDEOCHCNFH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJIKIMBBDPO GDLNILFNCJK(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KDBEDGALKFK FODLCJFPHCI(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MHACDHNHHDI FLKAAKHAKHD(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OOPNMGHKKIB DKIENMKAKJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KAOLJFOKKFJ ONMGFBANMJO(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL, EMPFNOOEPJM KNCHPAAMIFB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KPONNBMBLDC
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHBAFNHBCGF(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLMJHCPBEGE(Vector3 JFKDELALDJD, Vector3 GLNEOPDBMFP, ForceMode HFPFADDBPGP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIIIEIJMMOD(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDHIHLIEIFN(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GMKCHJIFHIP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool NEDLPALOLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFGHGLGHIEE(Rigidbody NIHPDINGBCI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GJMGAKOPHDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<JKJIEFIICJB> FICPDIBEANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JKJIEFIICJB CMJBHOFLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FAKKNJDHEEJ EEIPCPBLFLF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FAKKNJDHEEJ OGJCLDNCBDJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JDMIOPHFEMM PAOPDENECIC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action CGIJIGKJGJM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MBALPCGJHNJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JKJIEFIICJB> JIFAJJLFHPM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JKJIEFIICJB> BKPJPOCCIGI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action GOGIAPDLCBB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<JKJIEFIICJB> BEGGAMKHDPA;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void APFFKENNKIB(JKJIEFIICJB AEJHEFECOBJ, bool OLBIGMEKFFD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ILNIDINBIEN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 LMGIBEHEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 AOOBNGPIECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENEEDNMDIHC(JKJIEFIICJB EMNGIAIDBPA, object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJGNOCEMMFB(object JCIFCENKMKP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OOPNMGHKKIB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 LKBBFDLMBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 EKHBCLMDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float KJIHPLPMADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float LANFEFDKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 EDPIICPNBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion JHCNHKODLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event FAKKNJDHEEJ HBMMCBOOMJB;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GAPPAGCJDEF((Quaternion rot, Vector3 moments) IIFLMEOHBOK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PNIADNPDMEB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOOMDOJOFHB();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KAKHHKCOMEP();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GFGHGLGHIEE(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PIIDJCGOECO();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MHACDHNHHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNGNOBMMDDD(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIHIILLONHJ(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ECDAHLFDJNH(JKJIEFIICJB JPICPJHAJDB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBIPPCIABGC(JKJIEFIICJB JPICPJHAJDB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCLMKCOCBHB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EPJABEBNPGG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool ADHPAKJDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FAKKNJDHEEJ MFEODPJIPMC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIPHLDNNFFM(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FKLCBPOGBCL(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLNDKFEBIMN(object JCIFCENKMKP, bool MGPOKEFPGBG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOAFFKBHCPJ(Rigidbody AOJGKLNIGLI);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GFGHGLGHIEE(Rigidbody NIHPDINGBCI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KDBEDGALKFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OJBMLGHDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OLEIKJADGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FAKKNJDHEEJ ANDDKFFFLNB;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEENBKJFKGA(JKJIEFIICJB EMNGIAIDBPA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNNDEKOGEGL(JKJIEFIICJB EMNGIAIDBPA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KAOLJFOKKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DOLMDGJBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GMBAIHFBPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints KNEMAKFPIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFGHGLGHIEE(Rigidbody NIHPDINGBCI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PBPJIJDKDHN
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float JADHIHMHHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float PMHDKIEDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFGHGLGHIEE(Rigidbody NIHPDINGBCI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PPPDHPAGOPC
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FAKKNJDHEEJ OHJFMGGNIDG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KDFLEENLFFK();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLAFJOFGPFE();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNCBBDPIJIF();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKIMLJAMGBL();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OILIAJJHDPL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BJIKIMBBDPO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GGHDGMCBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKOIIDAFPJE(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJLLHEJKBEB(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLPANGNCEKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BJGJEGGBHHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	EBKBOJHOLGL GBKKBMKCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EGCBEDHFHPO APDAHLMFMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 CMLKBLFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 OHIMHJKNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 CGHCHFLNLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 JKIBPHPNMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float HCFPALINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool GAOHMGIOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GONOBOFENIO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BPMCHJABAGC(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HCGOKDHLMOF(DAOMMCIAOEJ NGLIKOKHABN, Vector3 HDLPFGDIGCD, float KAKBEDIMKEC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KHCKHMIPMNC(KELPIDMOECD PNOFGNKBEPL, Vector3 LCCMGOJPBMA, float IGGAJLACDEJ, float LFEDGHAJLBJ = 8f, float DELKKLHPPEP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OPCAGBODJDB(DAOMMCIAOEJ NGLIKOKHABN, Vector3 NGGFFKDNCFB, float EIPKJPHAGMD = 7f, float JHPDDNKFPBF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FBMNKHGFFNB();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JANLJPDNGLA();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EKDEKGLCNFJ();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JPCNAOMICAJ();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FGHIMFBLDFP(Vector3 PBGBFAMBAMF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NOAPMCJOHOB(object JCIFCENKMKP);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CHGEDLILKHL(Vector3 JGCMFGPJEBC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GEDAGAIHADD(Vector3 PIFHENFKDHB, Vector3 AMLNDCBAFED);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MOLKJLBJFLJ(Vector3 LADJHAOBEDO, Vector3 HEFMKCBGOPG);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IGJHINDIJMJ(Vector3 LNGMMPKBNBD);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KAOEOAFIGHJ(Vector3 PJHDGKKEAIL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface MFJECFDCBJN
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool EGLMKEKIOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFECJDFBHFM(string BKMJJACFCBK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJBCPPBFBMD(RigidbodyEx JPICPJHAJDB, Action GKKKLNHPKBN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJMFLMFAEEI GFPCMALNCGJ(int LCOKDFKIKNB);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EIAAAJAHKKI(Vector3 CIBHOHOPPDG, float PAJEIAJICEJ, Color COGPPELINPO);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PDIHONIFFOJ(BLECGLOBIIF.Application)]
public interface EMPFNOOEPJM
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	MFJECFDCBJN NCEODIICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	IPJOGHOIABB PODBIEHACML
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OPLKJDHEMCI : JKJIEFIICJB, IDisposable, LEMMBDELOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly EMPFNOOEPJM KNCHPAAMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal GJMGAKOPHDJ FLNKLJIEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal MHACDHNHHDI AFHCJJEIGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal KDBEDGALKFK KDPCOECIJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BJGJEGGBHHA PBGBFAMBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ILNIDINBIEN KIINLHELELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal OOPNMGHKKIB ILLNJIEOIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal PBPJIJDKDHN MPPBBBOLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GMKCHJIFHIP LDICGGIOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal PPPDHPAGOPC MMICFEACKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MNMPCDCLANA FLAKOGLJHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal EPJABEBNPGG KFOBPDAHDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal KPONNBMBLDC JFKDELALDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal KAOLJFOKKFJ DBPHBNOPDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal BJIKIMBBDPO NIHPDINGBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal FKCJNGDPCJI PCHLEJJHGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable PGGIOGOKLLL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public CGKDLJPPHGG CHLKNJOLKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "22")]
		get
		{
			return default(CGKDLJPPHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HMIKMKPGKPD FEBHEKFMAHP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x855000", Offset = "0x853A00", VA = "0x180855000", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x855020", Offset = "0x853A20", VA = "0x180855020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject PEPDCAMMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD510", Offset = "0x9DBF10", VA = "0x1809DD510", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC650", Offset = "0x9BB050", VA = "0x1809BC650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F19FA0", Offset = "0x6F189A0", VA = "0x186F19FA0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C1C0", Offset = "0x6F1ABC0", VA = "0x186F1C1C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E4B0", Offset = "0x6F1CEB0", VA = "0x186F1E4B0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DDB0", Offset = "0x6F1C7B0", VA = "0x186F1DDB0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int KPPAJCGFPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EE20", Offset = "0x6F1D820", VA = "0x186F1EE20", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public JKJIEFIICJB CMJBHOFLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A6A0", Offset = "0x6F190A0", VA = "0x186F1A6A0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool EIMBCEIHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A4B0", Offset = "0x6F18EB0", VA = "0x186F1A4B0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OJBMLGHDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C660", Offset = "0x6F1B060", VA = "0x186F1C660", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool OLEIKJADGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6F19DD0", Offset = "0x6F187D0", VA = "0x186F19DD0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EBKBOJHOLGL GBKKBMKCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CC50", Offset = "0x6F1B650", VA = "0x186F1CC50", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CA70", Offset = "0x6F1B470", VA = "0x186F1CA70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EGCBEDHFHPO APDAHLMFMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A3C0", Offset = "0x6F18DC0", VA = "0x186F1A3C0", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DAE0", Offset = "0x6F1C4E0", VA = "0x186F1DAE0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float HCFPALINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CD50", Offset = "0x6F1B750", VA = "0x186F1CD50", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D9A0", Offset = "0x6F1C3A0", VA = "0x186F1D9A0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 OHIMHJKNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E270", Offset = "0x6F1CC70", VA = "0x186F1E270", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B340", Offset = "0x6F19D40", VA = "0x186F1B340", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 JKIBPHPNMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E350", Offset = "0x6F1CD50", VA = "0x186F1E350", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CDF0", Offset = "0x6F1B7F0", VA = "0x186F1CDF0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 CMLKBLFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D810", Offset = "0x6F1C210", VA = "0x186F1D810", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B7F0", Offset = "0x6F1A1F0", VA = "0x186F1B7F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 CGHCHFLNLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CAD0", Offset = "0x6F1B4D0", VA = "0x186F1CAD0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E950", Offset = "0x6F1D350", VA = "0x186F1E950", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool CNHCOJFGPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D6C0", Offset = "0x6F1C0C0", VA = "0x186F1D6C0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool BBNFHNPPLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D460", Offset = "0x6F1BE60", VA = "0x186F1D460", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BBMLDLGJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AB30", Offset = "0x6F19530", VA = "0x186F1AB30", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool GAOHMGIOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CDA0", Offset = "0x6F1B7A0", VA = "0x186F1CDA0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 LMGIBEHEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F19390", Offset = "0x6F17D90", VA = "0x186F19390", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 AOOBNGPIECO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A820", Offset = "0x6F19220", VA = "0x186F1A820", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 LKBBFDLMBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C580", Offset = "0x6F1AF80", VA = "0x186F1C580", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C7E0", Offset = "0x6F1B1E0", VA = "0x186F1C7E0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 EKHBCLMDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C6B0", Offset = "0x6F1B0B0", VA = "0x186F1C6B0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float KJIHPLPMADF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CED0", Offset = "0x6F1B8D0", VA = "0x186F1CED0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float LANFEFDKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F19AE0", Offset = "0x6F184E0", VA = "0x186F19AE0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D660", Offset = "0x6F1C060", VA = "0x186F1D660", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 EDPIICPNBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F198F0", Offset = "0x6F182F0", VA = "0x186F198F0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion JHCNHKODLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A1D0", Offset = "0x6F18BD0", VA = "0x186F1A1D0", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float JADHIHMHHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DFB0", Offset = "0x6F1C9B0", VA = "0x186F1DFB0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F192B0", Offset = "0x6F17CB0", VA = "0x186F192B0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float PMHDKIEDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C790", Offset = "0x6F1B190", VA = "0x186F1C790", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F19A20", Offset = "0x6F18420", VA = "0x186F19A20", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool NEDLPALOLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C9C0", Offset = "0x6F1B3C0", VA = "0x186F1C9C0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A090", Offset = "0x6F18A90", VA = "0x186F1A090", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public ALFJCHGPFEB JODJINPJKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A460", Offset = "0x6F18E60", VA = "0x186F1A460", Slot = "68")]
		get
		{
			return default(ALFJCHGPFEB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B8D0", Offset = "0x6F1A2D0", VA = "0x186F1B8D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool ADHPAKJDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CBB0", Offset = "0x6F1B5B0", VA = "0x186F1CBB0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform JHFGJGILODH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F19310", Offset = "0x6F17D10", VA = "0x186F19310", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 GBLOKAEKGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1ADD0", Offset = "0x6F197D0", VA = "0x186F1ADD0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E000", Offset = "0x6F1CA00", VA = "0x186F1E000", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float EADKAPOFDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E6D0", Offset = "0x6F1D0D0", VA = "0x186F1E6D0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DE10", Offset = "0x6F1C810", VA = "0x186F1DE10", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float OKCMJJPFOML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E490", Offset = "0x6F1CE90", VA = "0x186F1E490", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A900", Offset = "0x6F19300", VA = "0x186F1A900", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion OKAGPECGPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CFD0", Offset = "0x6F1B9D0", VA = "0x186F1CFD0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C490", Offset = "0x6F1AE90", VA = "0x186F1C490", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A410", Offset = "0x6F18E10", VA = "0x186F1A410", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CF20", Offset = "0x6F1B920", VA = "0x186F1CF20", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DA60", Offset = "0x6F1C460", VA = "0x186F1DA60", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DAA0", Offset = "0x6F1C4A0", VA = "0x186F1DAA0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints KNEMAKFPIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EDD0", Offset = "0x6F1D7D0", VA = "0x186F1EDD0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D400", Offset = "0x6F1BE00", VA = "0x186F1D400", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool DOLMDGJBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B7A0", Offset = "0x6F1A1A0", VA = "0x186F1B7A0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A300", Offset = "0x6F18D00", VA = "0x186F1A300", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AEDNJJODHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DC50", Offset = "0x6F1C650", VA = "0x186F1DC50", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EA30", Offset = "0x6F1D430", VA = "0x186F1EA30", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool FALBGPDGCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A560", Offset = "0x6F18F60", VA = "0x186F1A560", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool KOEEFHLGECA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C210", Offset = "0x6F1AC10", VA = "0x186F1C210", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FAKKNJDHEEJ EEIPCPBLFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E500", Offset = "0x6F1CF00", VA = "0x186F1E500", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6F1EEE0", Offset = "0x6F1D8E0", VA = "0x186F1EEE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event FAKKNJDHEEJ OGJCLDNCBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BB00", Offset = "0x6F1A500", VA = "0x186F1BB00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6F18F30", Offset = "0x6F17930", VA = "0x186F18F30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JDMIOPHFEMM PAOPDENECIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6F19D10", Offset = "0x6F18710", VA = "0x186F19D10", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C020", Offset = "0x6F1AA20", VA = "0x186F1C020", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FAKKNJDHEEJ ANDDKFFFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DA00", Offset = "0x6F1C400", VA = "0x186F1DA00", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CA10", Offset = "0x6F1B410", VA = "0x186F1CA10", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event FAKKNJDHEEJ OGAKFGNKACL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BE50", Offset = "0x6F1A850", VA = "0x186F1BE50", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1ECC0", Offset = "0x6F1D6C0", VA = "0x186F1ECC0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event FAKKNJDHEEJ OHJFMGGNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E430", Offset = "0x6F1CE30", VA = "0x186F1E430", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A360", Offset = "0x6F18D60", VA = "0x186F1A360", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<KFIHHKNEBMF, KFIHHKNEBMF> ACAFKCPEHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A030", Offset = "0x6F18A30", VA = "0x186F1A030", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F19D70", Offset = "0x6F18770", VA = "0x186F19D70", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FAKKNJDHEEJ MFEODPJIPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E120", Offset = "0x6F1CB20", VA = "0x186F1E120", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1A7C0", Offset = "0x6F191C0", VA = "0x186F1A7C0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FAKKNJDHEEJ EIKDMIJICCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D8F0", Offset = "0x6F1C2F0", VA = "0x186F1D8F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CCA0", Offset = "0x6F1B6A0", VA = "0x186F1CCA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFF0", Offset = "0x6F1D9F0", VA = "0x186F1EFF0")]
	public OPLKJDHEMCI(GameObject AOOABPFBFDN, RigidbodyEx FBFBFNIKALG, EMPFNOOEPJM KNCHPAAMIFB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BB60", Offset = "0x6F1A560", VA = "0x186F1BB60", Slot = "136")]
	protected virtual void GEMICHPLLIB(EMPFNOOEPJM KNCHPAAMIFB, OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A6F0", Offset = "0x6F190F0", VA = "0x186F1A6F0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C080", Offset = "0x6F1AA80", VA = "0x186F1C080", Slot = "91")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6F199D0", Offset = "0x6F183D0", VA = "0x186F199D0", Slot = "92")]
	public void BIMKGBAEGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B780", Offset = "0x6F1A180", VA = "0x186F1B780", Slot = "93")]
	public void FLLAAJGOOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E8D0", Offset = "0x6F1D2D0", VA = "0x186F1E8D0")]
	private void PBPDAGNEOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E6F0", Offset = "0x6F1D0F0", VA = "0x186F1E6F0", Slot = "30")]
	public JKJIEFIICJB OEKONKEJMOF(int ILOCEPPJPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F19320", Offset = "0x6F17D20", VA = "0x186F19320", Slot = "95")]
	public void APFFKENNKIB(JKJIEFIICJB DBOBEHLEAAE, bool OLBIGMEKFFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EC60", Offset = "0x6F1D660", VA = "0x186F1EC60", Slot = "96")]
	public void PFHNPGOOLDF(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DD50", Offset = "0x6F1C750", VA = "0x186F1DD50", Slot = "97")]
	public void MAKAEJINPPM(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D1A0", Offset = "0x6F1BBA0", VA = "0x186F1D1A0", Slot = "98")]
	public Vector3 KAOEOAFIGHJ(Vector3 PJHDGKKEAIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C8C0", Offset = "0x6F1B2C0", VA = "0x186F1C8C0", Slot = "99")]
	public Vector3 IGJHINDIJMJ(Vector3 LNGMMPKBNBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F199D0", Offset = "0x6F183D0", VA = "0x186F199D0", Slot = "100")]
	public void JPCNAOMICAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CC00", Offset = "0x6F1B600", VA = "0x186F1CC00", Slot = "101")]
	public void JANLJPDNGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AD80", Offset = "0x6F19780", VA = "0x186F1AD80", Slot = "102")]
	public void FBMNKHGFFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E180", Offset = "0x6F1CB80", VA = "0x186F1E180", Slot = "103")]
	public void MOLKJLBJFLJ(Vector3 LADJHAOBEDO, Vector3 HEFMKCBGOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BA10", Offset = "0x6F1A410", VA = "0x186F1BA10", Slot = "104")]
	public void GEDAGAIHADD(Vector3 PIFHENFKDHB, Vector3 AMLNDCBAFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A0F0", Offset = "0x6F18AF0", VA = "0x186F1A0F0", Slot = "105")]
	public void CHGEDLILKHL(Vector3 JGCMFGPJEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D5A0", Offset = "0x6F1BFA0", VA = "0x186F1D5A0", Slot = "106")]
	public void KHCKHMIPMNC(KELPIDMOECD PNOFGNKBEPL, Vector3 LCCMGOJPBMA, float IGGAJLACDEJ, float LFEDGHAJLBJ = 8f, float DELKKLHPPEP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C390", Offset = "0x6F1AD90", VA = "0x186F1C390", Slot = "107")]
	public void HCGOKDHLMOF(DAOMMCIAOEJ NGLIKOKHABN, Vector3 HDLPFGDIGCD, float KAKBEDIMKEC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E7C0", Offset = "0x6F1D1C0", VA = "0x186F1E7C0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OPCAGBODJDB(DAOMMCIAOEJ NGLIKOKHABN, Vector3 NGGFFKDNCFB, float EIPKJPHAGMD = 7f, float JHPDDNKFPBF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B420", Offset = "0x6F19E20", VA = "0x186F1B420", Slot = "109")]
	public Vector3 FGHIMFBLDFP(Vector3 DBOBEHLEAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EB60", Offset = "0x6F1D560", VA = "0x186F1EB60", Slot = "110")]
	public Vector3 PFDKGENAMEN(Vector3 DBOBEHLEAAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AAE0", Offset = "0x6F194E0", VA = "0x186F1AAE0", Slot = "111")]
	public void EKDEKGLCNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EF40", Offset = "0x6F1D940", VA = "0x186F1EF40", Slot = "112")]
	public void PPJPBCBBLDE(JKJIEFIICJB CNBPKDOLLMB, object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A2A0", Offset = "0x6F18CA0", VA = "0x186F1A2A0", Slot = "113")]
	public void CKDPNJLJKDK(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B930", Offset = "0x6F1A330", VA = "0x186F1B930", Slot = "61")]
	public void GAPPAGCJDEF((Quaternion rot, Vector3 moments) IIFLMEOHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DD00", Offset = "0x6F1C700", VA = "0x186F1DD00", Slot = "114")]
	public void LOOMDOJOFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EE90", Offset = "0x6F1D890", VA = "0x186F1EE90", Slot = "115")]
	public void PNIADNPDMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D150", Offset = "0x6F1BB50", VA = "0x186F1D150", Slot = "116")]
	public void KAKHHKCOMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D3B0", Offset = "0x6F1BDB0", VA = "0x186F1D3B0", Slot = "117")]
	public bool KDFLEENLFFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A510", Offset = "0x6F18F10", VA = "0x186F1A510", Slot = "94")]
	public void DNCBBDPIJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E770", Offset = "0x6F1D170", VA = "0x186F1E770", Slot = "118")]
	public void OILIAJJHDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E0C0", Offset = "0x6F1CAC0", VA = "0x186F1E0C0", Slot = "119")]
	public void MIPHLDNNFFM(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B720", Offset = "0x6F1A120", VA = "0x186F1B720", Slot = "120")]
	public void FKLCBPOGBCL(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BFB0", Offset = "0x6F1A9B0", VA = "0x186F1BFB0", Slot = "121")]
	public void GLNDKFEBIMN(object JCIFCENKMKP, bool MGPOKEFPGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B520", Offset = "0x6F19F20", VA = "0x186F1B520", Slot = "122")]
	public void FKDGKOOBJKB(Vector3 PPBFOEBKKOC, Quaternion EKPDKJAAKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B1F0", Offset = "0x6F19BF0", VA = "0x186F1B1F0", Slot = "123")]
	public void FFBABMDBLJA(Vector3 CDCOLBIEICK, Quaternion KIJAKHEBLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DCA0", Offset = "0x6F1C6A0", VA = "0x186F1DCA0", Slot = "124")]
	public bool LMFKKPFLEEL(float MCFAHFLECNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED70", Offset = "0x6F1D770", VA = "0x186F1ED70", Slot = "125")]
	public void PIPHPFIIOPI(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE80", Offset = "0x6F1C880", VA = "0x186F1DE80", Slot = "126")]
	public void MCMAJPNOPLO(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F19A80", Offset = "0x6F18480", VA = "0x186F19A80", Slot = "127")]
	public void BKOIIDAFPJE(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CF70", Offset = "0x6F1B970", VA = "0x186F1CF70", Slot = "128")]
	public void JJLLHEJKBEB(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D4C0", Offset = "0x6F1BEC0", VA = "0x186F1D4C0", Slot = "129")]
	public void KHBAFNHBCGF(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB40", Offset = "0x6F1C540", VA = "0x186F1DB40", Slot = "130")]
	public void LLMJHCPBEGE(Vector3 JFKDELALDJD, Vector3 GLNEOPDBMFP, ForceMode HFPFADDBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AA00", Offset = "0x6F19400", VA = "0x186F1AA00", Slot = "131")]
	public void EIIIEIJMMOD(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F19460", Offset = "0x6F17E60", VA = "0x186F19460", Slot = "132")]
	public void BDHIHLIEIFN(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BEB0", Offset = "0x6F1A8B0", VA = "0x186F1BEB0", Slot = "133")]
	public bool GGEPOKHBBLE(Vector3 NMAFDGGPBKA, [Out] RaycastHit KGGKMKMJHGJ, float APKOACGHEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ED20", Offset = "0x6F1D720", VA = "0x186F1ED20", Slot = "134")]
	public void PIIDJCGOECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EFB0", Offset = "0x6F1D9B0", VA = "0x186F1EFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1EA90", Offset = "0x6F1D490", VA = "0x186F1EA90")]
	private void PEJPLAOAJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D2A0", Offset = "0x6F1BCA0", VA = "0x186F1D2A0")]
	private void KBGCPHBIFOM(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F19B30", Offset = "0x6F18530", VA = "0x186F19B30")]
	private void BNJKILAGBKE(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AC10", Offset = "0x6F19610", VA = "0x186F1AC10")]
	private void ELOFGNAHKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D710", Offset = "0x6F1C110", VA = "0x186F1D710")]
	private void KMLPBMJNKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F19E20", Offset = "0x6F18820", VA = "0x186F19E20")]
	private void CCKOJGLHAFL(JKJIEFIICJB JCIJKLPMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DEE0", Offset = "0x6F1C8E0", VA = "0x186F1DEE0")]
	private void MEENBKJFKGA(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D080", Offset = "0x6F1BA80", VA = "0x186F1D080")]
	private void JNNDEKOGEGL(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E560", Offset = "0x6F1CF60", VA = "0x186F1E560")]
	private void OBDNBKNJHCM(HMIKMKPGKPD EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F19540", Offset = "0x6F17F40", VA = "0x186F19540", Slot = "141")]
	protected virtual void BEJJFHPHNJC(HMIKMKPGKPD JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F18F90", Offset = "0x6F17990", VA = "0x186F18F90")]
	protected void AIIKFJOEKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AE80", Offset = "0x6F19880", VA = "0x186F1AE80")]
	protected void FCPAHCPNLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1ACC0", Offset = "0x6F196C0", VA = "0x186F1ACC0", Slot = "142")]
	protected virtual IDisposable FBBEGNMDAEF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class BFACIBOHBAF
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D3C0", Offset = "0x6F0BDC0", VA = "0x186F0D3C0")]
	public static JKJIEFIICJB NJOGPADLPOA(this JKJIEFIICJB JPICPJHAJDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D200", Offset = "0x6F0BC00", VA = "0x186F0D200")]
	public static bool AOMDIBOPPOM(this JKJIEFIICJB JPICPJHAJDB, JKJIEFIICJB MBEHGJAPFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D340", Offset = "0x6F0BD40", VA = "0x186F0D340")]
	public static bool JEKGBIGGPML(this JKJIEFIICJB JPICPJHAJDB, JKJIEFIICJB JNDKJGHBBAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D2F0", Offset = "0x6F0BCF0", VA = "0x186F0D2F0")]
	public static HMIKMKPGKPD GJKFMNPKGBG(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D280", Offset = "0x6F0BC80", VA = "0x186F0D280")]
	public static OPLKJDHEMCI DPDEEFJADAD(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class INEJKDAMOJH : IPJOGHOIABB
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F111C0", Offset = "0x6F0FBC0", VA = "0x186F111C0", Slot = "19")]
	public JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL, EMPFNOOEPJM KNCHPAAMIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "4")]
	public GJMGAKOPHDJ KDPCODADEKH(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "5")]
	public BJGJEGGBHHA BLAIIKGBILL(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "6")]
	public ILNIDINBIEN HGBJPOJGNGB(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "7")]
	public PBPJIJDKDHN IKEIHNBHKCN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "8")]
	public PPPDHPAGOPC GMEJLMGKEDI(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "9")]
	public MNMPCDCLANA KBMDIJNBHEP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "10")]
	public EPJABEBNPGG ODECDCFOAPP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "11")]
	public KPONNBMBLDC NONCLLPKGDN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "12")]
	public FKCJNGDPCJI CBMNKPBHALG(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "13")]
	public GMKCHJIFHIP LDPOOOPMCHO(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	public BJIKIMBBDPO GDLNILFNCJK(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	public KDBEDGALKFK FODLCJFPHCI(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	public MHACDHNHHDI FLKAAKHAKHD(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	public OOPNMGHKKIB DKIENMKAKJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	public KAOLJFOKKFJ ONMGFBANMJO(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public INEJKDAMOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "14")]
	private BJIKIMBBDPO GOOJLFCLOJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "15")]
	private KDBEDGALKFK AGCPKAHBHEL(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "16")]
	private MHACDHNHHDI JCABEMLIKJF(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "17")]
	private OOPNMGHKKIB BIDJGJADFGA(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "18")]
	private KAOLJFOKKFJ DDFONGGGEBM(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[JFDKKALIBKJ(typeof(IPJOGHOIABB), new string[] { })]
public class OPIFDOEILGI : IPJOGHOIABB, GMAJAMLLCFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IPJOGHOIABB MHIKMEPMFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IPJOGHOIABB GHPIBOGBGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private IKJAJBIJIFA LGMHNFLKCBA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private IPJOGHOIABB PODBIEHACML
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F18770", Offset = "0x6F17170", VA = "0x186F18770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B10", Offset = "0x6F17510", VA = "0x186F18B10", Slot = "20")]
	public void InitReferences(GHEIIEALIKL PFLLPPCJLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F18C00", Offset = "0x6F17600", VA = "0x186F18C00", Slot = "4")]
	public GJMGAKOPHDJ KDPCODADEKH(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6F18580", Offset = "0x6F16F80", VA = "0x186F18580", Slot = "5")]
	public BJGJEGGBHHA BLAIIKGBILL(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6F189D0", Offset = "0x6F173D0", VA = "0x186F189D0", Slot = "6")]
	public ILNIDINBIEN HGBJPOJGNGB(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6F18A70", Offset = "0x6F17470", VA = "0x186F18A70", Slot = "7")]
	public PBPJIJDKDHN IKEIHNBHKCN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6F18930", Offset = "0x6F17330", VA = "0x186F18930", Slot = "8")]
	public PPPDHPAGOPC GMEJLMGKEDI(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B60", Offset = "0x6F17560", VA = "0x186F18B60", Slot = "9")]
	public MNMPCDCLANA KBMDIJNBHEP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F18DE0", Offset = "0x6F177E0", VA = "0x186F18DE0", Slot = "10")]
	public EPJABEBNPGG ODECDCFOAPP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6F18D40", Offset = "0x6F17740", VA = "0x186F18D40", Slot = "11")]
	public KPONNBMBLDC NONCLLPKGDN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6F18620", Offset = "0x6F17020", VA = "0x186F18620", Slot = "12")]
	public FKCJNGDPCJI CBMNKPBHALG(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6F18CA0", Offset = "0x6F176A0", VA = "0x186F18CA0", Slot = "13")]
	public GMKCHJIFHIP LDPOOOPMCHO(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6F18880", Offset = "0x6F17280", VA = "0x186F18880")]
	public BJIKIMBBDPO GDLNILFNCJK(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6F182D0", Offset = "0x6F16CD0", VA = "0x186F182D0")]
	public KDBEDGALKFK FODLCJFPHCI(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6F187D0", Offset = "0x6F171D0", VA = "0x186F187D0")]
	public MHACDHNHHDI FLKAAKHAKHD(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F184D0", Offset = "0x6F16ED0", VA = "0x186F184D0")]
	public OOPNMGHKKIB DKIENMKAKJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F186C0", Offset = "0x6F170C0", VA = "0x186F186C0")]
	public KAOLJFOKKFJ ONMGFBANMJO(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18380", Offset = "0x6F16D80", VA = "0x186F18380", Slot = "19")]
	public JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL, EMPFNOOEPJM KNCHPAAMIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F18E80", Offset = "0x6F17880", VA = "0x186F18E80")]
	public OPIFDOEILGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F18880", Offset = "0x6F17280", VA = "0x186F18880", Slot = "14")]
	private BJIKIMBBDPO GOOJLFCLOJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F182D0", Offset = "0x6F16CD0", VA = "0x186F182D0", Slot = "15")]
	private KDBEDGALKFK AGCPKAHBHEL(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F187D0", Offset = "0x6F171D0", VA = "0x186F187D0", Slot = "16")]
	private MHACDHNHHDI JCABEMLIKJF(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F184D0", Offset = "0x6F16ED0", VA = "0x186F184D0", Slot = "17")]
	private OOPNMGHKKIB BIDJGJADFGA(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F186C0", Offset = "0x6F170C0", VA = "0x186F186C0", Slot = "18")]
	private KAOLJFOKKFJ DDFONGGGEBM(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HCLJIABPBAF : GJMGAKOPHDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLDFMJHFEAO(JKJIEFIICJB JPICPJHAJDB);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDFAGPAKMCH(JKJIEFIICJB JPICPJHAJDB);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHBEGNHAILE(JKJIEFIICJB JCIJKLPMGMB);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKGONAALIIC(JKJIEFIICJB JCIJKLPMGMB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CAHJNDAJKEE : ILNIDINBIEN
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	EBGDNFNNEHI<JKJIEFIICJB> NKFHCGJKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	JKJIEFIICJB PHABOEDLALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KDLFDODGPJM : OOPNMGHKKIB
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NDPFKIKONBE(Rigidbody AEHLDGLHNCC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MEJJGEKNPDH : KDBEDGALKFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView JCNHNAKEFAF
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MFMLBHONKJM : FKCJNGDPCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode AELNPNKLJME;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6F16650", Offset = "0x6F15050", VA = "0x186F16650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AEDNJJODHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F167C0", Offset = "0x6F151C0", VA = "0x186F167C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6F168E0", Offset = "0x6F152E0", VA = "0x186F168E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FFF0", Offset = "0x6F0E9F0", VA = "0x186F0FFF0")]
	public MFMLBHONKJM(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F16540", Offset = "0x6F14F40", VA = "0x186F16540", Slot = "6")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F16360", Offset = "0x6F14D60", VA = "0x186F16360", Slot = "9")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F16350", Offset = "0x6F14D50", VA = "0x186F16350", Slot = "7")]
	public void EFGPEGKJPJL(bool JHPCHHNCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F168D0", Offset = "0x6F152D0", VA = "0x186F168D0", Slot = "8")]
	public void NDJEPIAGAKJ(bool JHPCHHNCNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F163E0", Offset = "0x6F14DE0", VA = "0x186F163E0", Slot = "10")]
	public bool GGEPOKHBBLE(Vector3 NMAFDGGPBKA, [Out] RaycastHit KGGKMKMJHGJ, float APKOACGHEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F166A0", Offset = "0x6F150A0", VA = "0x186F166A0")]
	private void KEAACCDLKOB(bool JHPCHHNCNCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MANDANKIPKB : MNMPCDCLANA, IDisposable, JBPMFOFDJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ALFJCHGPFEB NGODHMMDGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OJMFLMFAEEI GOIEJEGINBN;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ALFJCHGPFEB JODJINPJKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F15DD0", Offset = "0x6F147D0", VA = "0x186F15DD0", Slot = "6")]
		get
		{
			return default(ALFJCHGPFEB);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F15F60", Offset = "0x6F14960", VA = "0x186F15F60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform GDENJGINLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F162A0", Offset = "0x6F14CA0", VA = "0x186F162A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KFIHHKNEBMF, KFIHHKNEBMF> ACAFKCPEHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F15D20", Offset = "0x6F14720", VA = "0x186F15D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F15C70", Offset = "0x6F14670", VA = "0x186F15C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6F162C0", Offset = "0x6F14CC0", VA = "0x186F162C0")]
	public MANDANKIPKB(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6F16030", Offset = "0x6F14A30", VA = "0x186F16030", Slot = "8")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6F15F10", Offset = "0x6F14910", VA = "0x186F15F10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x96B3E0", Offset = "0x969DE0", VA = "0x18096B3E0", Slot = "11")]
	private void OMOOIFLPKGC(KFIHHKNEBMF EJCBBMLGPKI, KFIHHKNEBMF DFLILBDBGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "12")]
	private void OGNAAJIHHEJ(bool MHOIIAGFKCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AAHHJILNEMF : IPJOGHOIABB
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AFA0", Offset = "0x6F099A0", VA = "0x186F0AFA0", Slot = "4")]
	public GJMGAKOPHDJ KDPCODADEKH(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A720", Offset = "0x6F09120", VA = "0x186F0A720", Slot = "5")]
	public BJGJEGGBHHA BLAIIKGBILL(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AD20", Offset = "0x6F09720", VA = "0x186F0AD20", Slot = "6")]
	public ILNIDINBIEN HGBJPOJGNGB(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE50", Offset = "0x6F09850", VA = "0x186F0AE50", Slot = "7")]
	public PBPJIJDKDHN IKEIHNBHKCN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AC50", Offset = "0x6F09650", VA = "0x186F0AC50", Slot = "8")]
	public PPPDHPAGOPC GMEJLMGKEDI(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AED0", Offset = "0x6F098D0", VA = "0x186F0AED0", Slot = "9")]
	public MNMPCDCLANA KBMDIJNBHEP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B210", Offset = "0x6F09C10", VA = "0x186F0B210", Slot = "10")]
	public EPJABEBNPGG ODECDCFOAPP(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B150", Offset = "0x6F09B50", VA = "0x186F0B150", Slot = "11")]
	public KPONNBMBLDC NONCLLPKGDN(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A840", Offset = "0x6F09240", VA = "0x186F0A840", Slot = "12")]
	public FKCJNGDPCJI CBMNKPBHALG(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B090", Offset = "0x6F09A90", VA = "0x186F0B090", Slot = "13")]
	public GMKCHJIFHIP LDPOOOPMCHO(JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AB10", Offset = "0x6F09510", VA = "0x186F0AB10")]
	public BJIKIMBBDPO GDLNILFNCJK(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A2E0", Offset = "0x6F08CE0", VA = "0x186F0A2E0")]
	public KDBEDGALKFK FODLCJFPHCI(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A9E0", Offset = "0x6F093E0", VA = "0x186F0A9E0")]
	public MHACDHNHHDI FLKAAKHAKHD(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A590", Offset = "0x6F08F90", VA = "0x186F0A590")]
	public OOPNMGHKKIB DKIENMKAKJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A900", Offset = "0x6F09300", VA = "0x186F0A900")]
	public KAOLJFOKKFJ ONMGFBANMJO(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A470", Offset = "0x6F08E70", VA = "0x186F0A470", Slot = "19")]
	public JKJIEFIICJB AKCOKKOKIGD(RigidbodyEx JPICPJHAJDB, OHPIALCJANL EEOBDBMOHPL, EMPFNOOEPJM KNCHPAAMIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public AAHHJILNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AB10", Offset = "0x6F09510", VA = "0x186F0AB10", Slot = "14")]
	private BJIKIMBBDPO GOOJLFCLOJB(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A2E0", Offset = "0x6F08CE0", VA = "0x186F0A2E0", Slot = "15")]
	private KDBEDGALKFK AGCPKAHBHEL(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A9E0", Offset = "0x6F093E0", VA = "0x186F0A9E0", Slot = "16")]
	private MHACDHNHHDI JCABEMLIKJF(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A590", Offset = "0x6F08F90", VA = "0x186F0A590", Slot = "17")]
	private OOPNMGHKKIB BIDJGJADFGA(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A900", Offset = "0x6F09300", VA = "0x186F0A900", Slot = "18")]
	private KAOLJFOKKFJ DDFONGGGEBM(JKJIEFIICJB PEDEOCHCNFH, [In] OHPIALCJANL EEOBDBMOHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class NLPICFGLPAA : KPONNBMBLDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6F16650", Offset = "0x6F15050", VA = "0x186F16650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool ADHPAKJDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6F178F0", Offset = "0x6F162F0", VA = "0x186F178F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool EIMBCEIHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6F16980", Offset = "0x6F15380", VA = "0x186F16980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6F17D20", Offset = "0x6F16720", VA = "0x186F17D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FFF0", Offset = "0x6F0E9F0", VA = "0x186F0FFF0")]
	public NLPICFGLPAA(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F17940", Offset = "0x6F16340", VA = "0x186F17940", Slot = "4")]
	public void KHBAFNHBCGF(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F17530", Offset = "0x6F15F30", VA = "0x186F17530")]
	private void DDBBAHEKGIA(Vector3 JFKDELALDJD, ForceMode HFPFADDBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F17AA0", Offset = "0x6F164A0", VA = "0x186F17AA0", Slot = "5")]
	public void LLMJHCPBEGE(Vector3 JFKDELALDJD, Vector3 GLNEOPDBMFP, ForceMode HFPFADDBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F17790", Offset = "0x6F16190", VA = "0x186F17790", Slot = "6")]
	public void EIIIEIJMMOD(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F17D80", Offset = "0x6F16780", VA = "0x186F17D80")]
	private void PLJGIBIKODP(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F172D0", Offset = "0x6F15CD0", VA = "0x186F172D0", Slot = "7")]
	public void BDHIHLIEIFN(Vector3 EKGFJGIMCEO, ForceMode HFPFADDBPGP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class BPPCLEJIHOB : GMKCHJIFHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool NOEDFKHBPAE;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool NEDLPALOLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x915D70", Offset = "0x914770", VA = "0x180915D70", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FE40", Offset = "0x6F0E840", VA = "0x186F0FE40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FFF0", Offset = "0x6F0E9F0", VA = "0x186F0FFF0")]
	public BPPCLEJIHOB(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FF50", Offset = "0x6F0E950", VA = "0x186F0FF50", Slot = "6")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FF80", Offset = "0x6F0E980", VA = "0x186F0FF80", Slot = "7")]
	public void GFGHGLGHIEE(Rigidbody NIHPDINGBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class BDAGJIKOBOD : HCLJIABPBAF, GJMGAKOPHDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JKJIEFIICJB JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<JKJIEFIICJB> NPGJAMFOHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private JKJIEFIICJB GPKGNPPAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private JKJIEFIICJB EMNGIAIDBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform AIGNIJIHDKE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BAB0", Offset = "0x6F0A4B0", VA = "0x186F0BAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C810", Offset = "0x6F0B210", VA = "0x186F0C810", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public JKJIEFIICJB CMJBHOFLJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC0", Offset = "0x84E6C0", VA = "0x18084FCC0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<JKJIEFIICJB> FICPDIBEANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event FAKKNJDHEEJ EEIPCPBLFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CB40", Offset = "0x6F0B540", VA = "0x186F0CB40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D0A0", Offset = "0x6F0BAA0", VA = "0x186F0D0A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event FAKKNJDHEEJ OGJCLDNCBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BF70", Offset = "0x6F0A970", VA = "0x186F0BF70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B330", Offset = "0x6F09D30", VA = "0x186F0B330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JDMIOPHFEMM PAOPDENECIC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BA10", Offset = "0x6F0A410", VA = "0x186F0BA10", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C0B0", Offset = "0x6F0AAB0", VA = "0x186F0C0B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action CGIJIGKJGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C010", Offset = "0x6F0AA10", VA = "0x186F0C010", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CBE0", Offset = "0x6F0B5E0", VA = "0x186F0CBE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MBALPCGJHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CD30", Offset = "0x6F0B730", VA = "0x186F0CD30", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C150", Offset = "0x6F0AB50", VA = "0x186F0C150", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<JKJIEFIICJB> JIFAJJLFHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CDD0", Offset = "0x6F0B7D0", VA = "0x186F0CDD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C4D0", Offset = "0x6F0AED0", VA = "0x186F0C4D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<JKJIEFIICJB> BKPJPOCCIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C760", Offset = "0x6F0B160", VA = "0x186F0C760", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BEC0", Offset = "0x6F0A8C0", VA = "0x186F0BEC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GOGIAPDLCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C580", Offset = "0x6F0AF80", VA = "0x186F0C580", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C820", Offset = "0x6F0B220", VA = "0x186F0C820", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<JKJIEFIICJB> BEGGAMKHDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CC80", Offset = "0x6F0B680", VA = "0x186F0CC80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CFF0", Offset = "0x6F0B9F0", VA = "0x186F0CFF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D140", Offset = "0x6F0BB40", VA = "0x186F0D140")]
	public BDAGJIKOBOD(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BBB0", Offset = "0x6F0A5B0", VA = "0x186F0BBB0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B490", Offset = "0x6F09E90", VA = "0x186F0B490", Slot = "30")]
	public void APFFKENNKIB(JKJIEFIICJB AEJHEFECOBJ, bool OLBIGMEKFFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC50", Offset = "0x6F0A650", VA = "0x186F0BC50", Slot = "6")]
	public void FHBEGNHAILE(JKJIEFIICJB JCIJKLPMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C8C0", Offset = "0x6F0B2C0", VA = "0x186F0C8C0", Slot = "7")]
	public void NKGONAALIIC(JKJIEFIICJB JCIJKLPMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C320", Offset = "0x6F0AD20", VA = "0x186F0C320", Slot = "4")]
	public void HLDFMJHFEAO(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C430", Offset = "0x6F0AE30", VA = "0x186F0C430", Slot = "5")]
	public void IDFAGPAKMCH(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BB10", Offset = "0x6F0A510", VA = "0x186F0BB10")]
	private void DNAPNNPMAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CFB0", Offset = "0x6F0B9B0", VA = "0x186F0CFB0")]
	private void PJBGGOHKMPD(JKJIEFIICJB JCIJKLPMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C620", Offset = "0x6F0B020", VA = "0x186F0C620")]
	private void KLOEDPNNCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CE80", Offset = "0x6F0B880", VA = "0x186F0CE80")]
	private void PCFAHHKJLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C1F0", Offset = "0x6F0ABF0", VA = "0x186F0C1F0")]
	private void HJPNMAEHKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B3D0", Offset = "0x6F09DD0", VA = "0x186F0B3D0")]
	[CompilerGenerated]
	private object AGLMAMCCKPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FOLABFNMNJC
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F10140", Offset = "0x6F0EB40", VA = "0x186F10140")]
	public static HCLJIABPBAF LNBAMHJPONJ(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KCJCKEOGFJH : CAHJNDAJKEE, ILNIDINBIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EBGDNFNNEHI<JKJIEFIICJB> NOEKJFGAFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool KPDCOIIIDDL;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EBGDNFNNEHI<JKJIEFIICJB> NKFHCGJKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LMGIBEHEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F118D0", Offset = "0x6F102D0", VA = "0x186F118D0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 AOOBNGPIECO
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6F11900", Offset = "0x6F10300", VA = "0x186F11900", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 CMLKBLFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6F12000", Offset = "0x6F10A00", VA = "0x186F12000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public JKJIEFIICJB PHABOEDLALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F120E0", Offset = "0x6F10AE0", VA = "0x186F120E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F121F0", Offset = "0x6F10BF0", VA = "0x186F121F0")]
	public KCJCKEOGFJH(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F11C00", Offset = "0x6F10600", VA = "0x186F11C00", Slot = "8")]
	public void ENEEDNMDIHC(JKJIEFIICJB EMNGIAIDBPA, object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F12190", Offset = "0x6F10B90", VA = "0x186F12190", Slot = "9")]
	public void NJGNOCEMMFB(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F11540", Offset = "0x6F0FF40", VA = "0x186F11540")]
	private Vector3 AOKOMJFIOKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F11C70", Offset = "0x6F10670", VA = "0x186F11C70")]
	private void JIADKCCPFNL(JKJIEFIICJB LHGODPDPNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class JGACJPMGCHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F11260", Offset = "0x6F0FC60", VA = "0x186F11260")]
	public static CAHJNDAJKEE LFFGBOPCFNA(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BLMEOKHLGON : KDLFDODGPJM, OOPNMGHKKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 BALABFLOFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 EEIBIMBJMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float LODEJFOHOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float AHMELKGLCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 HOLHIMCPIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? GHBEHJPLLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? PDEGLHKGEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool NADCNEMBHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool JFKAEMCELIO;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LKBBFDLMBHL
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xD62F70", Offset = "0xD61970", VA = "0x180D62F70", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E1E0", Offset = "0x6F0CBE0", VA = "0x186F0E1E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 EKHBCLMDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E0E0", Offset = "0x6F0CAE0", VA = "0x186F0E0E0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float KJIHPLPMADF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA20", Offset = "0x8BA420", VA = "0x1808BBA20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D610", Offset = "0x6F0C010", VA = "0x186F0D610")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float LANFEFDKEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB30", Offset = "0x8BA530", VA = "0x1808BBB30", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DD50", Offset = "0x6F0C750", VA = "0x186F0DD50", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 EDPIICPNBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D480", Offset = "0x6F0BE80", VA = "0x186F0D480", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion JHCNHKODLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F0D720", Offset = "0x6F0C120", VA = "0x186F0D720", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DFF0", Offset = "0x6F0C9F0", VA = "0x186F0DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event FAKKNJDHEEJ HBMMCBOOMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E040", Offset = "0x6F0CA40", VA = "0x186F0E040", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E430", Offset = "0x6F0CE30", VA = "0x186F0E430", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FCE0", Offset = "0x6F0E6E0", VA = "0x186F0FCE0")]
	public BLMEOKHLGON(JKJIEFIICJB JPICPJHAJDB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E5C0", Offset = "0x6F0CFC0", VA = "0x186F0E5C0", Slot = "17")]
	public void LOOMDOJOFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FC00", Offset = "0x6F0E600", VA = "0x186F0FC00", Slot = "16")]
	public void PNIADNPDMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DA40", Offset = "0x6F0C440", VA = "0x186F0DA40", Slot = "19")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DE00", Offset = "0x6F0C800", VA = "0x186F0DE00", Slot = "20")]
	public void GFGHGLGHIEE(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E290", Offset = "0x6F0CC90", VA = "0x186F0E290", Slot = "18")]
	public void KAKHHKCOMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F770", Offset = "0x6F0E170", VA = "0x186F0F770", Slot = "21")]
	public void PIIDJCGOECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E1E0", Offset = "0x6F0CBE0", VA = "0x186F0E1E0")]
	private void MNJNJKPEHDK(Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E4D0", Offset = "0x6F0CED0", VA = "0x186F0E4D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LJEKGAHAKKD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D610", Offset = "0x6F0C010", VA = "0x186F0D610")]
	private void BFBPOHEIIAN(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DD50", Offset = "0x6F0C750", VA = "0x186F0DD50")]
	private void GCJHJGFJGFM(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D8A0", Offset = "0x6F0C2A0", VA = "0x186F0D8A0")]
	private Vector3 CLBOJAEBBGA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DB20", Offset = "0x6F0C520", VA = "0x186F0DB20", Slot = "15")]
	public void GAPPAGCJDEF((Quaternion rot, Vector3 moments) IIFLMEOHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F5F0", Offset = "0x6F0DFF0", VA = "0x186F0F5F0")]
	private Quaternion OKLJFDMCCAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E770", Offset = "0x6F0D170", VA = "0x186F0E770")]
	public void NDPFKIKONBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E840", Offset = "0x6F0D240", VA = "0x186F0E840", Slot = "4")]
	public (float, Vector3) NDPFKIKONBE(Rigidbody AEHLDGLHNCC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class CJAGMCBHJOH
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F10080", Offset = "0x6F0EA80", VA = "0x186F10080")]
	public static KDLFDODGPJM NFEKHAHHMHD(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PPMCPGKJKLN : MHACDHNHHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NFLEMDIBMBJ DNGMIMJEMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AHFBHELEKED NNJNCPOKHGJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool OFACJEHJHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xEE4C20", Offset = "0xEE3620", VA = "0x180EE4C20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public AHFBHELEKED OLNMECBPMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0", Slot = "11")]
		get
		{
			return default(AHFBHELEKED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F206E0", Offset = "0x6F1F0E0", VA = "0x186F206E0")]
	public PPMCPGKJKLN(JKJIEFIICJB JPICPJHAJDB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F203B0", Offset = "0x6F1EDB0", VA = "0x186F203B0", Slot = "4")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F20130", Offset = "0x6F1EB30", VA = "0x186F20130")]
	private bool CDLMIHFGLMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F20380", Offset = "0x6F1ED80", VA = "0x186F20380", Slot = "5")]
	public void FNGNOBMMDDD(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F200C0", Offset = "0x6F1EAC0", VA = "0x186F200C0", Slot = "6")]
	public void AIHIILLONHJ(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F205A0", Offset = "0x6F1EFA0", VA = "0x186F205A0", Slot = "9")]
	public void OCLMKCOCBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F20480", Offset = "0x6F1EE80", VA = "0x186F20480")]
	private void MMIKMEGIOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F20210", Offset = "0x6F1EC10", VA = "0x186F20210")]
	private void EOLHOPMCKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F200F0", Offset = "0x6F1EAF0", VA = "0x186F200F0", Slot = "8")]
	public void BBIPPCIABGC(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F201D0", Offset = "0x6F1EBD0", VA = "0x186F201D0", Slot = "7")]
	public void ECDAHLFDJNH(JKJIEFIICJB JPICPJHAJDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class POGAFMJEFEE : EPJABEBNPGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NFLEMDIBMBJ IBIJBFEOOGN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool ADHPAKJDEOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FE30", Offset = "0x6F1E830", VA = "0x186F1FE30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FAKKNJDHEEJ MFEODPJIPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FEF0", Offset = "0x6F1E8F0", VA = "0x186F1FEF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FBC0", Offset = "0x6F1E5C0", VA = "0x186F1FBC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FFD0", Offset = "0x6F1E9D0", VA = "0x186F1FFD0")]
	public POGAFMJEFEE(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FEE0", Offset = "0x6F1E8E0", VA = "0x186F1FEE0", Slot = "7")]
	public void MIPHLDNNFFM(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FCE0", Offset = "0x6F1E6E0", VA = "0x186F1FCE0", Slot = "8")]
	public void FKLCBPOGBCL(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FD20", Offset = "0x6F1E720", VA = "0x186F1FD20", Slot = "9")]
	public void GLNDKFEBIMN(object JCIFCENKMKP, bool MGPOKEFPGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FF90", Offset = "0x6F1E990", VA = "0x186F1FF90", Slot = "12")]
	public void MNKHHJGCDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FC60", Offset = "0x6F1E660", VA = "0x186F1FC60", Slot = "10")]
	public void EOAFFKBHCPJ(Rigidbody AOJGKLNIGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FCF0", Offset = "0x6F1E6F0", VA = "0x186F1FCF0", Slot = "11")]
	public void GFGHGLGHIEE(Rigidbody NIHPDINGBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class GAMNKIKEDOL : MEJJGEKNPDH, KDBEDGALKFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView BMLCBLNGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool JMIEDMCIAFJ;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView JCNHNAKEFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool OJBMLGHDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F105A0", Offset = "0x6F0EFA0", VA = "0x186F105A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool OLEIKJADGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA659B0", Offset = "0xA643B0", VA = "0x180A659B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FAKKNJDHEEJ ANDDKFFFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F10B90", Offset = "0x6F0F590", VA = "0x186F10B90", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F105C0", Offset = "0x6F0EFC0", VA = "0x186F105C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F10DA0", Offset = "0x6F0F7A0", VA = "0x186F10DA0")]
	public GAMNKIKEDOL(JKJIEFIICJB JPICPJHAJDB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F10470", Offset = "0x6F0EE70", VA = "0x186F10470", Slot = "9")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F10370", Offset = "0x6F0ED70", VA = "0x186F10370", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F10C30", Offset = "0x6F0F630", VA = "0x186F10C30", Slot = "10")]
	public void MEENBKJFKGA(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F107B0", Offset = "0x6F0F1B0", VA = "0x186F107B0", Slot = "11")]
	public void JNNDEKOGEGL(JKJIEFIICJB EMNGIAIDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F10200", Offset = "0x6F0EC00", VA = "0x186F10200")]
	private void ADGLDLIBDKC(PhotonView JGGCGKAGIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F10660", Offset = "0x6F0F060", VA = "0x186F10660")]
	private void IMOBLMHJEGB(HMIKMKPGKPD KLNHBMGEOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F10920", Offset = "0x6F0F320", VA = "0x186F10920")]
	private void KFLMIBGCDIE(PhotonView EFGBLNDMHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class NMLGAEEEDMD
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F17FE0", Offset = "0x6F169E0", VA = "0x186F17FE0")]
	public static MEJJGEKNPDH NIMMAHAGMHK(this JKJIEFIICJB PEDEOCHCNFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OGBNEIJPFMJ : KAOLJFOKKFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints DKFFHGEIPJM;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool DOLMDGJBAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCE4370", Offset = "0xCE2D70", VA = "0x180CE4370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44C0120", Offset = "0x44BEB20", VA = "0x1844C0120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GMBAIHFBPAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF356F0", Offset = "0xF340F0", VA = "0x180F356F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x44C0110", Offset = "0x44BEB10", VA = "0x1844C0110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints KNEMAKFPIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F18100", Offset = "0x6F16B00", VA = "0x186F18100", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F18230", Offset = "0x6F16C30", VA = "0x186F18230")]
	public OGBNEIJPFMJ(JKJIEFIICJB JPICPJHAJDB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F180A0", Offset = "0x6F16AA0", VA = "0x186F180A0", Slot = "9")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F180D0", Offset = "0x6F16AD0", VA = "0x186F180D0", Slot = "10")]
	public void GFGHGLGHIEE(Rigidbody NIHPDINGBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GAOLKKLPGJJ : PBPJIJDKDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JKJIEFIICJB JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float EOBNNHKBNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float LGJHLMDJPEE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float JADHIHMHHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBB0", Offset = "0x8BA5B0", VA = "0x1808BBBB0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6F10EF0", Offset = "0x6F0F8F0", VA = "0x186F10EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float PMHDKIEDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB70", Offset = "0x8BA570", VA = "0x1808BBB70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F10FC0", Offset = "0x6F0F9C0", VA = "0x186F10FC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F11180", Offset = "0x6F0FB80", VA = "0x186F11180")]
	public GAOLKKLPGJJ(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F11090", Offset = "0x6F0FA90", VA = "0x186F11090", Slot = "8")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F110E0", Offset = "0x6F0FAE0", VA = "0x186F110E0", Slot = "9")]
	public void GFGHGLGHIEE(Rigidbody NIHPDINGBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class POBOMOBHMOA : PPPDHPAGOPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool FJPJNPBEKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool NOGOIKAECCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KJGCLILPPEP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DFF0", Offset = "0x6F0C9F0", VA = "0x186F0DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool FALBGPDGCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F410", Offset = "0x6F1DE10", VA = "0x186F1F410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private JKJIEFIICJB LKABBOLBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F1FA30", Offset = "0x6F1E430", VA = "0x186F1FA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EIMBCEIHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F310", Offset = "0x6F1DD10", VA = "0x186F1F310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FAKKNJDHEEJ OHJFMGGNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F990", Offset = "0x6F1E390", VA = "0x186F1F990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F270", Offset = "0x6F1DC70", VA = "0x186F1F270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FB30", Offset = "0x6F1E530", VA = "0x186F1FB30")]
	public POBOMOBHMOA(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F440", Offset = "0x6F1DE40", VA = "0x186F1F440", Slot = "6")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F430", Offset = "0x6F1DE30", VA = "0x186F1F430", Slot = "8")]
	public void GLAFJOFGPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F6B0", Offset = "0x6F1E0B0", VA = "0x186F1F6B0", Slot = "7")]
	public bool KDFLEENLFFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F370", Offset = "0x6F1DD70", VA = "0x186F1F370", Slot = "9")]
	public void DNCBBDPIJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F1FA90", Offset = "0x6F1E490", VA = "0x186F1FA90", Slot = "11")]
	public void OILIAJJHDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F0C0", Offset = "0x6F1DAC0", VA = "0x186F1F0C0", Slot = "10")]
	public void BKIMLJAMGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F4D0", Offset = "0x6F1DED0", VA = "0x186F1F4D0")]
	private bool HCOAPGINGMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F800", Offset = "0x6F1E200", VA = "0x186F1F800")]
	private void KGEAIINLKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MPCDEBALKLI : BJIKIMBBDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NFLEMDIBMBJ FOIGJJEMKMB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody ANKDGFGHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool EIMBCEIHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F16980", Offset = "0x6F15380", VA = "0x186F16980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool GGHDGMCBEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xEE4C20", Offset = "0xEE3620", VA = "0x180EE4C20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F17150", Offset = "0x6F15B50", VA = "0x186F17150")]
	public MPCDEBALKLI(JKJIEFIICJB JPICPJHAJDB, [In] OHPIALCJANL EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F16B60", Offset = "0x6F15560", VA = "0x186F16B60", Slot = "5")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F16950", Offset = "0x6F15350", VA = "0x186F16950", Slot = "7")]
	public void BKOIIDAFPJE(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F16DF0", Offset = "0x6F157F0", VA = "0x186F16DF0", Slot = "8")]
	public void JJLLHEJKBEB(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6F16E20", Offset = "0x6F15820", VA = "0x186F16E20", Slot = "9")]
	public void OLPANGNCEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F16C00", Offset = "0x6F15600", VA = "0x186F16C00", Slot = "10")]
	public void HGCKDDEKENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F169E0", Offset = "0x6F153E0", VA = "0x186F169E0", Slot = "11")]
	public void GNHPGDAAPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LFPKAJLODBN : BJGJEGGBHHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly OPLKJDHEMCI JPICPJHAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NFLEMDIBMBJ ACFKDKLNMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float MOBELBFJFDG;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public EBKBOJHOLGL GBKKBMKCHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EGCBEDHFHPO APDAHLMFMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 CMLKBLFDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6F14740", Offset = "0x6F13140", VA = "0x186F14740", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6F13500", Offset = "0x6F11F00", VA = "0x186F13500", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 OHIMHJKNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6F14BF0", Offset = "0x6F135F0", VA = "0x186F14BF0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6F133F0", Offset = "0x6F11DF0", VA = "0x186F133F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 CGHCHFLNLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6F13DB0", Offset = "0x6F127B0", VA = "0x186F13DB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6F15920", Offset = "0x6F14320", VA = "0x186F15920", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 JKIBPHPNMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6F14D80", Offset = "0x6F13780", VA = "0x186F14D80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6F13FE0", Offset = "0x6F129E0", VA = "0x186F13FE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float HCFPALINGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBA90", Offset = "0x8BA490", VA = "0x1808BBA90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6F137A0", Offset = "0x6F121A0", VA = "0x186F137A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool GAOHMGIOIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18A3610", Offset = "0x18A2010", VA = "0x1818A3610", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KPONNBMBLDC ACFJJOOPFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6747F20", Offset = "0x6746920", VA = "0x186747F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool FALBGPDGCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F13050", Offset = "0x6F11A50", VA = "0x186F13050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6F159E0", Offset = "0x6F143E0", VA = "0x186F159E0")]
	public LFPKAJLODBN(JKJIEFIICJB JPICPJHAJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6F138B0", Offset = "0x6F122B0", VA = "0x186F138B0", Slot = "19")]
	public void GONOBOFENIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6F13070", Offset = "0x6F11A70", VA = "0x186F13070", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6F13260", Offset = "0x6F11C60", VA = "0x186F13260", Slot = "28")]
	public void EOAFFKBHCPJ(Rigidbody NIHPDINGBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD22F70", Offset = "0xD21970", VA = "0x180D22F70", Slot = "20")]
	public void BPMCHJABAGC(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD22F90", Offset = "0xD21990", VA = "0x180D22F90", Slot = "30")]
	public void NOAPMCJOHOB(object JCIFCENKMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6F14010", Offset = "0x6F12A10", VA = "0x186F14010", Slot = "35")]
	public Vector3 KAOEOAFIGHJ(Vector3 PJHDGKKEAIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6F13BF0", Offset = "0x6F125F0", VA = "0x186F13BF0", Slot = "34")]
	public Vector3 IGJHINDIJMJ(Vector3 LNGMMPKBNBD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6F138B0", Offset = "0x6F122B0", VA = "0x186F138B0", Slot = "27")]
	public void JPCNAOMICAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F13F80", Offset = "0x6F12980", VA = "0x186F13F80", Slot = "25")]
	public void JANLJPDNGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6F13390", Offset = "0x6F11D90", VA = "0x186F13390", Slot = "24")]
	public void FBMNKHGFFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6F14900", Offset = "0x6F13300", VA = "0x186F14900", Slot = "33")]
	public void MOLKJLBJFLJ(Vector3 LADJHAOBEDO, Vector3 HEFMKCBGOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6F13740", Offset = "0x6F12140", VA = "0x186F13740", Slot = "32")]
	public void GEDAGAIHADD(Vector3 PIFHENFKDHB, Vector3 AMLNDCBAFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F12D20", Offset = "0x6F11720", VA = "0x186F12D20", Slot = "31")]
	public void CHGEDLILKHL(Vector3 JGCMFGPJEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F141F0", Offset = "0x6F12BF0", VA = "0x186F141F0", Slot = "22")]
	public void KHCKHMIPMNC(KELPIDMOECD PNOFGNKBEPL, Vector3 LCCMGOJPBMA, float IGGAJLACDEJ, float LFEDGHAJLBJ = 8f, float DELKKLHPPEP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6F13960", Offset = "0x6F12360", VA = "0x186F13960", Slot = "21")]
	public void HCGOKDHLMOF(DAOMMCIAOEJ NGLIKOKHABN, Vector3 HDLPFGDIGCD, float KAKBEDIMKEC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F15530", Offset = "0x6F13F30", VA = "0x186F15530", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void OPCAGBODJDB(DAOMMCIAOEJ NGLIKOKHABN, Vector3 NGGFFKDNCFB, float EIPKJPHAGMD = 7f, float JHPDDNKFPBF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE22250", Offset = "0xE20C50", VA = "0x180E22250")]
	private static void AHMHCHMLFKF(Vector3 PBGBFAMBAMF, Vector3 GKJCNLBHEIK, [Out] Vector3 BNDPOGHEGOL, [Out] Vector3 ADNJMJBBOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F13420", Offset = "0x6F11E20", VA = "0x186F13420", Slot = "29")]
	public Vector3 FGHIMFBLDFP(Vector3 PBGBFAMBAMF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6F130D0", Offset = "0x6F11AD0", VA = "0x186F130D0", Slot = "26")]
	public void EKDEKGLCNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6F137A0", Offset = "0x6F121A0", VA = "0x186F137A0")]
	private void GOKNBPNKFMF(float DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6F14F10", Offset = "0x6F13910", VA = "0x186F14F10")]
	private void OHPPMGGADNF(Vector3 HDLPFGDIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6F135C0", Offset = "0x6F11FC0", VA = "0x186F135C0")]
	private Vector3 GBEPAPDJIGN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6F150B0", Offset = "0x6F13AB0", VA = "0x186F150B0")]
	private void OJDKEAELJAM(Vector3 LNGMMPKBNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6F12EC0", Offset = "0x6F118C0", VA = "0x186F12EC0")]
	private Vector3 DKAMHJAJBPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F122F0", Offset = "0x6F10CF0", VA = "0x186F122F0")]
	private void AENCDPENANH(Vector3 DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6F12770", Offset = "0x6F11170", VA = "0x186F12770")]
	private void BKKFFEDAAOH(Vector3 LNGMMPKBNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6F14B40", Offset = "0x6F13540", VA = "0x186F14B40")]
	private void NBJPIKGHOJF()
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
