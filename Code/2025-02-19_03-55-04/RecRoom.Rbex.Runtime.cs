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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BD12A0", Offset = "0x7BCFEA0", VA = "0x187BD12A0", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCDA0", Offset = "0x1DFB9A0", VA = "0x181DFCDA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE540", Offset = "0x7BDD140", VA = "0x187BDE540")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE840", Offset = "0x7BDD440", VA = "0x187BDE840", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BDE8A0", Offset = "0x7BDD4A0", VA = "0x187BDE8A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, JKJFLLICHBF, PMHAEKLGAHN, DELPGJANODF
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly NDNFAPMFFIF PBLBHPNKPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool INEDPJEALGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MMNADIEGNMF OBDEMGIJMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[FKADGLKHFBM(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[FKADGLKHFBM(EGFPEOBPDHA.SelfAndParent, true, false, false)]
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
		private HGFGAMBABML physicsInterpolation;

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

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform COIANACMHAK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MMNADIEGNMF BLANNJFJBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7BD8F80", Offset = "0x7BD7B80", VA = "0x187BD8F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MMNADIEGNMF NDNDPIBKBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IHLOJNOIGLB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBA50", Offset = "0x7BDA650", VA = "0x187BDBA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HOGKEBMOLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBDB0", Offset = "0x7BDA9B0", VA = "0x187BDBDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JHCLOFMDCND
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBCF0", Offset = "0x7BDA8F0", VA = "0x187BDBCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx KOIBCEOILEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC9B0", Offset = "0x7BDB5B0", VA = "0x187BDC9B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDEB0", Offset = "0x7BDCAB0", VA = "0x187BDDEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OHHMMIABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7BB79C0", Offset = "0x7BB65C0", VA = "0x187BB79C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7BB5920", Offset = "0x7BB4520", VA = "0x187BB5920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FDCDPIOJPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1C405A0", Offset = "0x1C3F1A0", VA = "0x181C405A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform BFGABEOIKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1C405A0", Offset = "0x1C3F1A0", VA = "0x181C405A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform GLLFOAFAGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1C405A0", Offset = "0x1C3F1A0", VA = "0x181C405A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public INJLACPLDPA BMIDJOFLCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBAB0", Offset = "0x7BDA6B0", VA = "0x187BDBAB0")]
			get
			{
				return default(INJLACPLDPA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD660", Offset = "0x7BDC260", VA = "0x187BDD660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IDCMPKOIAME
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC0C0", Offset = "0x7BDACC0", VA = "0x187BDC0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DCAJBNFMLED
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBBD0", Offset = "0x7BDA7D0", VA = "0x187BDBBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DDBGNDDKCOF DHBAJIEBKNC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC000", Offset = "0x7BDAC00", VA = "0x187BDC000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD820", Offset = "0x7BDC420", VA = "0x187BDD820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PGKFHALECKJ CEHBFLLMLHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBFA0", Offset = "0x7BDABA0", VA = "0x187BDBFA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD7B0", Offset = "0x7BDC3B0", VA = "0x187BDD7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MDKOMOAIIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBEF0", Offset = "0x7BDAAF0", VA = "0x187BDBEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LMCFJKNGFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBF50", Offset = "0x7BDAB50", VA = "0x187BDBF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NPKNNINDDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBC30", Offset = "0x7BDA830", VA = "0x187BDBC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD6D0", Offset = "0x7BDC2D0", VA = "0x187BDD6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PFKLMPHGBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7895440", Offset = "0x7894040", VA = "0x187895440", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IJIKDBDCDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC950", Offset = "0x7BDB550", VA = "0x187BDC950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GGFJEDBCOEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC8F0", Offset = "0x7BDB4F0", VA = "0x187BDC8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDE40", Offset = "0x7BDCA40", VA = "0x187BDDE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float BNEDBGHNBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC320", Offset = "0x7BDAF20", VA = "0x187BDC320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDAC0", Offset = "0x7BDC6C0", VA = "0x187BDDAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float CHFHCGCKICK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC120", Offset = "0x7BDAD20", VA = "0x187BDC120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD890", Offset = "0x7BDC490", VA = "0x187BDD890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool PLOFNPGGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCF00", Offset = "0x7BDBB00", VA = "0x187BDCF00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE3F0", Offset = "0x7BDCFF0", VA = "0x187BDE3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 JGOFCJOHKEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC6D0", Offset = "0x7BDB2D0", VA = "0x187BDC6D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDC10", Offset = "0x7BDC810", VA = "0x187BDDC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 BEKJAEKHLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD040", Offset = "0x7BDBC40", VA = "0x187BDD040")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode NECJFJBPEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC260", Offset = "0x7BDAE60", VA = "0x187BDC260")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD9E0", Offset = "0x7BDC5E0", VA = "0x187BDD9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FHHLPKEKJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBC90", Offset = "0x7BDA890", VA = "0x187BDBC90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD740", Offset = "0x7BDC340", VA = "0x187BDD740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints PEPMCCJPIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC2C0", Offset = "0x7BDAEC0", VA = "0x187BDC2C0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDA50", Offset = "0x7BDC650", VA = "0x187BDDA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GCLIGMCFNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCA70", Offset = "0x7BDB670", VA = "0x187BDCA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 GOAPICOMOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCA70", Offset = "0x7BDB670", VA = "0x187BDCA70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE1D0", Offset = "0x7BDCDD0", VA = "0x187BDE1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float CBPAGEIDANI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC7B0", Offset = "0x7BDB3B0", VA = "0x187BDC7B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDCF0", Offset = "0x7BDC8F0", VA = "0x187BDDCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float LIILBLDLNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCEA0", Offset = "0x7BDBAA0", VA = "0x187BDCEA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE380", Offset = "0x7BDCF80", VA = "0x187BDE380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion IMOIFIPIEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCB50", Offset = "0x7BDB750", VA = "0x187BDCB50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDF50", Offset = "0x7BDCB50", VA = "0x187BDDF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion CDOEMNLBFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCDD0", Offset = "0x7BDB9D0", VA = "0x187BDCDD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE2B0", Offset = "0x7BDCEB0", VA = "0x187BDE2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DKPEPEFNBBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCC20", Offset = "0x7BDB820", VA = "0x187BDCC20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE020", Offset = "0x7BDCC20", VA = "0x187BDE020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BAMAIGGPLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCD00", Offset = "0x7BDB900", VA = "0x187BDCD00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE100", Offset = "0x7BDCD00", VA = "0x187BDE100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CNPDFOJECOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BDCF60", Offset = "0x7BDBB60", VA = "0x187BDCF60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7BDE460", Offset = "0x7BDD060", VA = "0x187BDE460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CMHAGMHENKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC810", Offset = "0x7BDB410", VA = "0x187BDC810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDD60", Offset = "0x7BDC960", VA = "0x187BDDD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NNJICJPFFMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC180", Offset = "0x7BDAD80", VA = "0x187BDC180")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD900", Offset = "0x7BDC500", VA = "0x187BDD900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GIHMFKNIMAP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC5F0", Offset = "0x7BDB1F0", VA = "0x187BDC5F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDB30", Offset = "0x7BDC730", VA = "0x187BDDB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JEDHAJEGGHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC4B0", Offset = "0x7BDB0B0", VA = "0x187BDC4B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion OAIGKKJLCDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC3E0", Offset = "0x7BDAFE0", VA = "0x187BDC3E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 OKOEONGNDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD200", Offset = "0x7BDBE00", VA = "0x187BDD200")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 EGIGLCHOJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD120", Offset = "0x7BDBD20", VA = "0x187BDD120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DMDIMEKCFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC590", Offset = "0x7BDB190", VA = "0x187BDC590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EDFJJLKIMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC060", Offset = "0x7BDAC60", VA = "0x187BDC060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MONADMKKLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBB70", Offset = "0x7BDA770", VA = "0x187BDBB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool OOMJCKOOIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BDBB10", Offset = "0x7BDA710", VA = "0x187BDBB10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MDCGNGJFFMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB9F0", Offset = "0x7BDA5F0", VA = "0x187BDB9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool HGMFNOHIPCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7BDC380", Offset = "0x7BDAF80", VA = "0x187BDC380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DFIMOLGJAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x20B90A0", Offset = "0x20B7CA0", VA = "0x1820B90A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GKPCOHIAIAH HCAOMLBFIII
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB910", Offset = "0x7BDA510", VA = "0x187BDB910")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD580", Offset = "0x7BDC180", VA = "0x187BDD580")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GKDNFNOFKME MLLGBFINBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB680", Offset = "0x7BDA280", VA = "0x187BDB680")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD2E0", Offset = "0x7BDBEE0", VA = "0x187BDD2E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GKDNFNOFKME ACBHKDBCCPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB6E0", Offset = "0x7BDA2E0", VA = "0x187BDB6E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD350", Offset = "0x7BDBF50", VA = "0x187BDD350")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event GKDNFNOFKME PPLNAOMNMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB830", Offset = "0x7BDA430", VA = "0x187BDB830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD4A0", Offset = "0x7BDC0A0", VA = "0x187BDD4A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<CKBJHKOEDDL, CKBJHKOEDDL> GHPAPKAFGPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB7C0", Offset = "0x7BDA3C0", VA = "0x187BDB7C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD430", Offset = "0x7BDC030", VA = "0x187BDD430")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event GKDNFNOFKME MCHNDNKNIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB8A0", Offset = "0x7BDA4A0", VA = "0x187BDB8A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD510", Offset = "0x7BDC110", VA = "0x187BDD510")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event GKDNFNOFKME IPHNPKLLGCF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB980", Offset = "0x7BDA580", VA = "0x187BDB980")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD5F0", Offset = "0x7BDC1F0", VA = "0x187BDD5F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event GKDNFNOFKME MBAOJBPEGPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB750", Offset = "0x7BDA350", VA = "0x187BDB750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BDD3C0", Offset = "0x7BDBFC0", VA = "0x187BDD3C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500", Slot = "8")]
		private void PMIOJJPGBLJ(MMNADIEGNMF FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA0A0", Offset = "0x7BD8CA0", VA = "0x187BDA0A0", Slot = "9")]
		public HJKIKFEINAB GetData()
		{
			return default(HJKIKFEINAB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA510", Offset = "0x7BD9110", VA = "0x187BDA510")]
		internal void LCMBNECCHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB3B0", Offset = "0x7BD9FB0", VA = "0x187BDB3B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody FFGLMLCIKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9DF0", Offset = "0x7BD89F0", VA = "0x187BD9DF0")]
		public JKJFLLICHBF GetChild(int BIEEMEKMINN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB010", Offset = "0x7BD9C10", VA = "0x187BDB010")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GEKAGIBPJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9A40", Offset = "0x7BD8640", VA = "0x187BD9A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB2A0", Offset = "0x7BD9EA0", VA = "0x187BDB2A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8F80", Offset = "0x7BD7B80", VA = "0x187BD8F80")]
		private MMNADIEGNMF ADIFJHCPHNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA130", Offset = "0x7BD8D30", VA = "0x187BDA130")]
		private void HGFFJCPBDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA7E0", Offset = "0x7BD93E0", VA = "0x187BDA7E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA720", Offset = "0x7BD9320", VA = "0x187BDA720")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA510", Offset = "0x7BD9110", VA = "0x187BDA510")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA780", Offset = "0x7BD9380", VA = "0x187BDA780")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA840", Offset = "0x7BD9440", VA = "0x187BDA840")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9030", Offset = "0x7BD7C30", VA = "0x187BD9030")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA8A0", Offset = "0x7BD94A0", VA = "0x187BDA8A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9D90", Offset = "0x7BD8990", VA = "0x187BD9D90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA6B0", Offset = "0x7BD92B0", VA = "0x187BDA6B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB170", Offset = "0x7BD9D70", VA = "0x187BDB170")]
		public void SetParent(RigidbodyEx MPDLOLIOGJL, bool HDEDJGFEFFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7BDABB0", Offset = "0x7BD97B0", VA = "0x187BDABB0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA2B0", Offset = "0x7BD8EB0", VA = "0x187BDA2B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx FGHAKLFHDNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA3B0", Offset = "0x7BD8FB0", VA = "0x187BDA3B0")]
		public bool IsRigidbodyDescendant(RigidbodyEx AEOOKJGJOAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD92A0", Offset = "0x7BD7EA0", VA = "0x187BD92A0")]
		public void AddInterpolationRestriction(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA910", Offset = "0x7BD9510", VA = "0x187BDA910")]
		public void RemoveInterpolationRestriction(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9310", Offset = "0x7BD7F10", VA = "0x187BD9310")]
		public void AddKinematic(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA980", Offset = "0x7BD9580", VA = "0x187BDA980")]
		public void RemoveKinematic(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB0F0", Offset = "0x7BD9CF0", VA = "0x187BDB0F0")]
		public void SetKinematic(object IKLHDHMJFFL, bool IAKCGCGLECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAF10", Offset = "0x7BD9B10", VA = "0x187BDAF10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JMOMNLNOKEI, Quaternion FJBMELLBPLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAE10", Offset = "0x7BD9A10", VA = "0x187BDAE10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MKMLABJLANA, Quaternion IADBBDDNDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9F90", Offset = "0x7BD8B90", VA = "0x187BD9F90")]
		public Vector3 GetConstrainedVelocity(Vector3 CNPDFOJECOP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9E80", Offset = "0x7BD8A80", VA = "0x187BD9E80")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NNJICJPFFMH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BD91B0", Offset = "0x7BD7DB0", VA = "0x187BD91B0")]
		public void AddForce(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BD90A0", Offset = "0x7BD7CA0", VA = "0x187BD90A0")]
		public void AddForceAtPosition(Vector3 NBNIPGNLIMD, Vector3 FCININPMBGJ, ForceMode KDJAPCNFGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BD94E0", Offset = "0x7BD80E0", VA = "0x187BD94E0")]
		public void AddTorque(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9380", Offset = "0x7BD7F80", VA = "0x187BD9380")]
		public void AddRelativeTorque(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB480", Offset = "0x7BDA080", VA = "0x187BDB480")]
		public Vector3 WorldToLocalVelocity(Vector3 KOBCHCGJLLB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA5A0", Offset = "0x7BD91A0", VA = "0x187BDA5A0")]
		public Vector3 LocalToWorldVelocity(Vector3 CMHAGMHENKF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9D30", Offset = "0x7BD8930", VA = "0x187BD9D30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9CD0", Offset = "0x7BD88D0", VA = "0x187BD9CD0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9C70", Offset = "0x7BD8870", VA = "0x187BD9C70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9C10", Offset = "0x7BD8810", VA = "0x187BD9C10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAD10", Offset = "0x7BD9910", VA = "0x187BDAD10")]
		public void ResetVelocityWorldSpace(Vector3 KPFDANNBDMG, Vector3 DJCOHPBIMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAC10", Offset = "0x7BD9810", VA = "0x187BDAC10")]
		public void ResetVelocityLocalSpace(Vector3 MDCKKGLAALC, Vector3 GIHMFKNIMAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAAD0", Offset = "0x7BD96D0", VA = "0x187BDAAD0")]
		public void ResetLinearVelocityLocalSpace(Vector3 MDCKKGLAALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB2B0", Offset = "0x7BD9EB0", VA = "0x187BDB2B0")]
		public bool SweepTest(Vector3 JJPEELBONAL, [Out] RaycastHit NNKLPCEFCLH, float JOBEKHJDCMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA4B0", Offset = "0x7BD90B0", VA = "0x187BDA4B0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB240", Offset = "0x7BD9E40", VA = "0x187BDB240")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB420", Offset = "0x7BDA020", VA = "0x187BDB420")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9470", Offset = "0x7BD8070", VA = "0x187BD9470")]
		public void AddShouldHaveUnityRigidbodyToken(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA9F0", Offset = "0x7BD95F0", VA = "0x187BDA9F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9870", Offset = "0x7BD8470", VA = "0x187BD9870")]
		public void ApplyForceVelocityChange(HDEBMOKJEII AHLANEMEBKA, Vector3 CLHLJFLAFEF, float IKBHBGJMCJB, float HCNGNGAPDLK = 8f, float ECOAHHAENAE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9770", Offset = "0x7BD8370", VA = "0x187BD9770")]
		public void ApplyAngularVelocityChange(NCBHFGHIKBE KJNADMEBEIF, Vector3 OEFJLLAMMJJ, float NBFMMJGHGJM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9930", Offset = "0x7BD8530", VA = "0x187BD9930")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(NCBHFGHIKBE KJNADMEBEIF, Vector3 APLHHNGOEFP, float ONMPAKODLON = 7f, float LJHKMJLPGFG = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD96A0", Offset = "0x7BD82A0", VA = "0x187BD96A0")]
		public bool AllowedScaleChange(float BPPKCFHOFCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD95D0", Offset = "0x7BD81D0", VA = "0x187BD95D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx APINEPJPKIP, object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAA60", Offset = "0x7BD9660", VA = "0x187BDAA60")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object IKLHDHMJFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDA710", Offset = "0x7BD9310", VA = "0x187BDA710", Slot = "12")]
		private void OAOMPCECDEB(EEPNIHLMHOE HJIAOGEIAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB610", Offset = "0x7BDA210", VA = "0x187BDB610")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ACB0", Offset = "0xA698B0", VA = "0x180A6ACB0", Slot = "4")]
		private GameObject ADJFOENKAOI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "10")]
		private bool DGIDCMLKFAK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class DIJOKPGDCMB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3850", Offset = "0x7BC2450", VA = "0x187BC3850")]
	public static MMNADIEGNMF BLANNJFJBMH(this RigidbodyEx PPJMBNBBIOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(EMLCKEBDGOE), new string[] { })]
public class DEMOAMDEHPG : EMLCKEBDGOE, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JCEJDJMPJAP JOHAHHCBBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FNENLGPLIKK PEOCBNOJDHG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JCEJDJMPJAP GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FNENLGPLIKK LFFAGHNIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3760", Offset = "0x7BC2360", VA = "0x187BC3760", Slot = "7")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3590", Offset = "0x7BC2190", VA = "0x187BC3590", Slot = "6")]
	public MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DEMOAMDEHPG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static NCEKLMPIJLO UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HJBPKGCFOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int JBHNPMMJODE;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8E00", Offset = "0x7BD7A00", VA = "0x187BD8E00")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8E40", Offset = "0x7BD7A40", VA = "0x187BD8E40")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8E20", Offset = "0x7BD7A20", VA = "0x187BD8E20")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string KBPDEFFIKOJ, [Optional] UnityEngine.Object HJIAOGEIAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string KBPDEFFIKOJ, [Optional] UnityEngine.Object HJIAOGEIAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8F30", Offset = "0x7BD7B30", VA = "0x187BD8F30")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AKGNAAFGMJL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CGBKNIJNCAP : DDBGNDDKCOF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9689E0", Offset = "0x9675E0", VA = "0x1809689E0", Slot = "4")]
		public Vector3 PFIDBEMDOLK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9689E0", Offset = "0x9675E0", VA = "0x1809689E0", Slot = "5")]
		public Vector3 PPBIGEPBCJB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "6")]
		public bool PBMOBELDEOI(float HKNOKFFEMKD, float FBMDEKFLPPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CGBKNIJNCAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static DDBGNDDKCOF IEJBLMFFLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3420", Offset = "0x7BC2020", VA = "0x187BC3420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AOOOOAFHLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode MJDIBONEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPPEHCGCAIA(bool DMDIMEKCFBI);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDMAGFJJDCE(bool DMDIMEKCFBI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FHPNHGEDKKF(Vector3 JJPEELBONAL, [Out] RaycastHit NNKLPCEFCLH, float JOBEKHJDCMI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EGLCLDBEGIA : IDisposable, KOBEPGCLKJL
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	INJLACPLDPA BMIDJOFLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<CKBJHKOEDDL, CKBJHKOEDDL> GHPAPKAFGPO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKEOJGLDIFP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface FNENLGPLIKK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKINKMOMMHM BEHJHKNBMGJ(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BAEKAHCPLJM CIOBLJOBIGN(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BEMKKJCJFIH HCBABMHFNMB(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHGCMBPDIBD DCABOBJMJFJ(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCDHFAMACEN CFPBILLGMKL(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EGLCLDBEGIA AKGOPDEMOKE(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HBAKFHGADEE KOICNNMHKLA(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ICPNFADBKNB JKEOPOBLDMN(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AOOOOAFHLKD KIDKJIIIFNN(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AEAEGAPIKMH EPIGGIIBJDA(MMNADIEGNMF FOBBPKHANPP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KBJNBNAAPCP ILDGMIALALE(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ELGGDMCLPFM KBLAMDIIIBJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DMJEGOFOJKK JCLJICALPPI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EOMAMBBEKEH JAFECCHDLBK(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DFJFNEMONGM HHPICFKIKPJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK, HJKIKFEINAB LLDJIJICLJF, EMLCKEBDGOE JHBOJJACLJB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ICPNFADBKNB
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIBENAEJGFN(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIICJKOKFLH(Vector3 NBNIPGNLIMD, Vector3 FCININPMBGJ, ForceMode KDJAPCNFGKA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLKADJAGMED(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNDAOKJAHHP(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AEAEGAPIKMH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IHDBOAJAICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HKINKMOMMHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<MMNADIEGNMF> KBIAIELPOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MMNADIEGNMF JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GKDNFNOFKME MLLGBFINBNM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event GKDNFNOFKME ACBHKDBCCPP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event GKPCOHIAIAH CHABONFNFMP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DMDNJKFBIKO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action NFFDFICGAPI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MMNADIEGNMF> EFBHODOCKCI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MMNADIEGNMF> PDLAMJBGHLG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action PBLCCAKOAOH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MMNADIEGNMF> OECPIBDECBE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JCGLDFHMCIJ(MMNADIEGNMF BDHPANPFDPF, bool HDEDJGFEFFK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BEMKKJCJFIH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IPPPMGEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 HAPHIOLJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEKAPCCIJKN(MMNADIEGNMF KOIBCEOILEL, object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEMDLOCJHDK(object IKLHDHMJFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EOMAMBBEKEH
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 OMLAPECNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 PELDPPHALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AIJIDCPBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float PIMPOCNJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 AEBPNODKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion JNBMHDELDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event GKDNFNOFKME CMLLNCFMEBF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EHOIEOIGCDD((Quaternion rot, Vector3 moments) GEKAGIBPJGO);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ENNOBFJFNFD();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FKCLKJNLANB();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LIIOCOMGKBC();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MGIEJHBMCFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DMJEGOFOJKK
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAIFHFNFKFC(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLAEDBOLGOC(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJFAGGCGHJA(MMNADIEGNMF PPJMBNBBIOK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNGNBAOLJJJ(MMNADIEGNMF PPJMBNBBIOK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DOFKAMJJBMN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HBAKFHGADEE
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NNNLOIGOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event GKDNFNOFKME NPAOOIFHPJL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOGKFAFEGLD(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJBOLPDJGPB(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBCMOEIEBPL(object IKLHDHMJFFL, bool IAKCGCGLECI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGDHFLCDEDC(Rigidbody NIAHBPBMHAK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ELGGDMCLPFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool IDCMPKOIAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DCAJBNFMLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event GKDNFNOFKME HFHAFGPCCJN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IILNOCCLGIP(MMNADIEGNMF KOIBCEOILEL);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBLFLPGLKDG(MMNADIEGNMF KOIBCEOILEL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DFJFNEMONGM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NPKNNINDDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GHFLKNMKAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints EALBMOJKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IHGCMBPDIBD
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float LNFNJMGEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PLONLIDEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HCDHFAMACEN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool JHCGIAEPFPM;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event GKDNFNOFKME PCNPJOLDDHA;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INDNBMGINBH();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKEKHPCCLBD();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGFIKBBGNKB();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AFMNFLFADGH();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PDOKHIHCKNJ();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFGJGEKHFMB(bool FNOBGOMNOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COFJLBAIBME();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBJNBNAAPCP
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BEMEDGLNGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHBBILMDFLD(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBOHAKJBPKK(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OINNNAEHPDA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BAEKAHCPLJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DDBGNDDKCOF DHBAJIEBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PGKFHALECKJ CEHBFLLMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 FDADPHGJIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 NDCIBIEBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 OOHNAEGHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 INGOOIDCCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float FHHLPKEKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MDKOMOAIIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DKEOJGLDIFP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DPPCLPDCBHH(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CELABFNKMLM(NCBHFGHIKBE KJNADMEBEIF, Vector3 OEFJLLAMMJJ, float NBFMMJGHGJM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OINNCCJMKIA(HDEBMOKJEII AHLANEMEBKA, Vector3 CLHLJFLAFEF, float IKBHBGJMCJB, float HCNGNGAPDLK = 8f, float ECOAHHAENAE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ECHEDHBNPAA(NCBHFGHIKBE KJNADMEBEIF, Vector3 APLHHNGOEFP, float ONMPAKODLON = 7f, float LJHKMJLPGFG = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FAGDFGFBAJJ();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JLDHACAJGFE();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CHNJMNIJNEM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NDCHPBBDEKH();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 ENJNNDLEPCJ(Vector3 CNPDFOJECOP);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GAMDEEDLGGF(object IKLHDHMJFFL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NJBIANIADOP(Vector3 FJMMHMJJINN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ILGOOKEKFNJ(Vector3 MDCKKGLAALC, Vector3 GIHMFKNIMAP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CLPCFJILFHH(Vector3 KPFDANNBDMG, Vector3 DJCOHPBIMGB);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FBECAFHGFMD(Vector3 CMHAGMHENKF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 MEDMBNAIIBB(Vector3 KOBCHCGJLLB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface JCEJDJMPJAP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CHAHGBNADDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGHOBKEJCJJ(string AHPAHIHOBBE);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPJHOCBHCCF(RigidbodyEx PPJMBNBBIOK, Action OAGMINHECCA);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNBIKALEBEL EKFNMJLGIMA(int GCNCEMKOBJH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNBIJNINCNA(Vector3 BEKJAEKHLPN, float GGAKKEKINAM, Color PFOKHHCFPNE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface EMLCKEBDGOE
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	JCEJDJMPJAP GNGHLGLBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	FNENLGPLIKK LFFAGHNIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DOKGDAHGDLJ : MMNADIEGNMF, IDisposable, BOCMIOGEADG
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool ALKMIPDJGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly EMLCKEBDGOE JHBOJJACLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HKINKMOMMHM IFJIIPEPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DMJEGOFOJKK AFPGIJCNKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ELGGDMCLPFM IDPJNHDJMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal BAEKAHCPLJM CNPDFOJECOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal BEMKKJCJFIH OFFBDNLOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal EOMAMBBEKEH GCPJMHHCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal IHGCMBPDIBD FGMCHPABALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal AEAEGAPIKMH MJHBGKHIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HCDHFAMACEN KLOODBKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal EGLCLDBEGIA CADEHMCFMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HBAKFHGADEE IHNPPEJGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal ICPNFADBKNB NBNIPGNLIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal DFJFNEMONGM LDFOGCCOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal KBJNBNAAPCP GLAPFMEOBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal AOOOOAFHLKD APOEBBLFDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable IMFOFHBCEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool HPCHGCGBJOH;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public OJMCCDFHBJG OLMMINDFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "22")]
		get
		{
			return default(OJMCCDFHBJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public JKJFLLICHBF MJDOAILBGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xCE2060", Offset = "0xCE0C60", VA = "0x180CE2060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject FOFMPGFPBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x95A600", Offset = "0x959200", VA = "0x18095A600", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x95A5E0", Offset = "0x9591E0", VA = "0x18095A5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAC2650", Offset = "0xAC1250", VA = "0x180AC2650", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xCF11F0", Offset = "0xCEFDF0", VA = "0x180CF11F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7700", Offset = "0x7BC6300", VA = "0x187BC7700", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7440", Offset = "0x7BC6040", VA = "0x187BC7440", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7830", Offset = "0x7BC6430", VA = "0x187BC7830", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int IHLOJNOIGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6750", Offset = "0x7BC5350", VA = "0x187BC6750", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MMNADIEGNMF JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4950", Offset = "0x7BC3550", VA = "0x187BC4950", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool KDDPDIGHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4F20", Offset = "0x7BC3B20", VA = "0x187BC4F20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool IDCMPKOIAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7540", Offset = "0x7BC6140", VA = "0x187BC7540", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DCAJBNFMLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BC51C0", Offset = "0x7BC3DC0", VA = "0x187BC51C0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DDBGNDDKCOF DHBAJIEBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7BC38C0", Offset = "0x7BC24C0", VA = "0x187BC38C0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7BC67C0", Offset = "0x7BC53C0", VA = "0x187BC67C0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PGKFHALECKJ CEHBFLLMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9D20", Offset = "0x7BC8920", VA = "0x187BC9D20", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9920", Offset = "0x7BC8520", VA = "0x187BC9920", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float FHHLPKEKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5090", Offset = "0x7BC3C90", VA = "0x187BC5090", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8430", Offset = "0x7BC7030", VA = "0x187BC8430", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 NDCIBIEBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5E20", Offset = "0x7BC4A20", VA = "0x187BC5E20", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8880", Offset = "0x7BC7480", VA = "0x187BC8880", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 INGOOIDCCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3F30", Offset = "0x7BC2B30", VA = "0x187BC3F30", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC44A0", Offset = "0x7BC30A0", VA = "0x187BC44A0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 FDADPHGJIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3D90", Offset = "0x7BC2990", VA = "0x187BC3D90", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8730", Offset = "0x7BC7330", VA = "0x187BC8730", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 OOHNAEGHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6010", Offset = "0x7BC4C10", VA = "0x187BC6010", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7750", Offset = "0x7BC6350", VA = "0x187BC7750", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MONADMKKLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6620", Offset = "0x7BC5220", VA = "0x187BC6620", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool OOMJCKOOIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5F00", Offset = "0x7BC4B00", VA = "0x187BC5F00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool MDCGNGJFFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4C60", Offset = "0x7BC3860", VA = "0x187BC4C60", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool MDKOMOAIIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C50", Offset = "0x7BC6850", VA = "0x187BC7C50", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IPPPMGEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9770", Offset = "0x7BC8370", VA = "0x187BC9770", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 HAPHIOLJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC41B0", Offset = "0x7BC2DB0", VA = "0x187BC41B0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 OMLAPECNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6300", Offset = "0x7BC4F00", VA = "0x187BC6300", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7890", Offset = "0x7BC6490", VA = "0x187BC7890", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 PELDPPHALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4710", Offset = "0x7BC3310", VA = "0x187BC4710", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AIJIDCPBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7970", Offset = "0x7BC6570", VA = "0x187BC7970", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float PIMPOCNJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC49A0", Offset = "0x7BC35A0", VA = "0x187BC49A0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4A60", Offset = "0x7BC3660", VA = "0x187BC4A60", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 AEBPNODKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC64F0", Offset = "0x7BC50F0", VA = "0x187BC64F0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion JNBMHDELDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9B50", Offset = "0x7BC8750", VA = "0x187BC9B50", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float LNFNJMGEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC65D0", Offset = "0x7BC51D0", VA = "0x187BC65D0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4DC0", Offset = "0x7BC39C0", VA = "0x187BC4DC0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PLONLIDEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6440", Offset = "0x7BC5040", VA = "0x187BC6440", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8550", Offset = "0x7BC7150", VA = "0x187BC8550", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool IHDBOAJAICE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7F90", Offset = "0x7BC6B90", VA = "0x187BC7F90", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9540", Offset = "0x7BC8140", VA = "0x187BC9540", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public INJLACPLDPA BMIDJOFLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8CA0", Offset = "0x7BC78A0", VA = "0x187BC8CA0", Slot = "70")]
		get
		{
			return default(INJLACPLDPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6C80", Offset = "0x7BC5880", VA = "0x187BC6C80", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool NNNLOIGOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC68B0", Offset = "0x7BC54B0", VA = "0x187BC68B0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform GLLFOAFAGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAC2650", Offset = "0xAC1250", VA = "0x180AC2650", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 NAHOODPCOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B40", Offset = "0x7BC6740", VA = "0x187BC7B40", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5270", Offset = "0x7BC3E70", VA = "0x187BC5270", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float AIHLPMDGINB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4580", Offset = "0x7BC3180", VA = "0x187BC4580", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8810", Offset = "0x7BC7410", VA = "0x187BC8810", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float OCAGNBGFEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC95A0", Offset = "0x7BC81A0", VA = "0x187BC95A0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9690", Offset = "0x7BC8290", VA = "0x187BC9690", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MPGKBGPDMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4400", Offset = "0x7BC3000", VA = "0x187BC4400", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7180", Offset = "0x7BC5D80", VA = "0x187BC7180", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 FIAHPIOKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8CF0", Offset = "0x7BC78F0", VA = "0x187BC8CF0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9CE0", Offset = "0x7BC88E0", VA = "0x187BC9CE0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion GFLBEFOIGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6C40", Offset = "0x7BC5840", VA = "0x187BC6C40", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4690", Offset = "0x7BC3290", VA = "0x187BC4690", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints EALBMOJKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5650", Offset = "0x7BC4250", VA = "0x187BC5650", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC63E0", Offset = "0x7BC4FE0", VA = "0x187BC63E0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NPKNNINDDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC94A0", Offset = "0x7BC80A0", VA = "0x187BC94A0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7BC73E0", Offset = "0x7BC5FE0", VA = "0x187BC73E0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode MJDIBONEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5FC0", Offset = "0x7BC4BC0", VA = "0x187BC5FC0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8C40", Offset = "0x7BC7840", VA = "0x187BC8C40", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool MAMANHMLNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4010", Offset = "0x7BC2C10", VA = "0x187BC4010", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool EDFJJLKIMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC79C0", Offset = "0x7BC65C0", VA = "0x187BC79C0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event GKDNFNOFKME MLLGBFINBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6BE0", Offset = "0x7BC57E0", VA = "0x187BC6BE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9C80", Offset = "0x7BC8880", VA = "0x187BC9C80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event GKDNFNOFKME ACBHKDBCCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3ED0", Offset = "0x7BC2AD0", VA = "0x187BC3ED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5210", Offset = "0x7BC3E10", VA = "0x187BC5210", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GKPCOHIAIAH CHABONFNFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8A60", Offset = "0x7BC7660", VA = "0x187BC8A60", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4150", Offset = "0x7BC2D50", VA = "0x187BC4150", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GKDNFNOFKME HFHAFGPCCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7BF0", Offset = "0x7BC67F0", VA = "0x187BC7BF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7BC8490", Offset = "0x7BC7090", VA = "0x187BC8490", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event GKDNFNOFKME PPLNAOMNMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7590", Offset = "0x7BC6190", VA = "0x187BC7590", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC85B0", Offset = "0x7BC71B0", VA = "0x187BC85B0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event GKDNFNOFKME PCNPJOLDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3E70", Offset = "0x7BC2A70", VA = "0x187BC3E70", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC84F0", Offset = "0x7BC70F0", VA = "0x187BC84F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<CKBJHKOEDDL, CKBJHKOEDDL> GHPAPKAFGPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3CA0", Offset = "0x7BC28A0", VA = "0x187BC3CA0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6EB0", Offset = "0x7BC5AB0", VA = "0x187BC6EB0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event GKDNFNOFKME NPAOOIFHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9AF0", Offset = "0x7BC86F0", VA = "0x187BC9AF0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3910", Offset = "0x7BC2510", VA = "0x187BC3910", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event GKDNFNOFKME MBAOJBPEGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6900", Offset = "0x7BC5500", VA = "0x187BC6900", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3970", Offset = "0x7BC2570", VA = "0x187BC3970", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9FB0", Offset = "0x7BC8BB0", VA = "0x187BC9FB0")]
	public DOKGDAHGDLJ(GameObject PHPLOOLODCB, RigidbodyEx OFMPPLMKAPK, EMLCKEBDGOE JHBOJJACLJB, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7CA0", Offset = "0x7BC68A0", VA = "0x187BC7CA0", Slot = "139")]
	protected virtual void LEIDKENHJAN(EMLCKEBDGOE JHBOJJACLJB, HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4E20", Offset = "0x7BC3A20", VA = "0x187BC4E20", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4B20", Offset = "0x7BC3720", VA = "0x187BC4B20", Slot = "93")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3D00", Offset = "0x7BC2900", VA = "0x187BC3D00", Slot = "94")]
	public void ALIGLFPBGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9840", Offset = "0x7BC8440", VA = "0x187BC9840", Slot = "95")]
	public void OCDFJNNGHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4D40", Offset = "0x7BC3940", VA = "0x187BC4D40", Slot = "96")]
	public void DOGLMGKBOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3A20", Offset = "0x7BC2620", VA = "0x187BC3A20")]
	private void AFGJGEKHFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7BC98A0", Offset = "0x7BC84A0", VA = "0x187BC98A0")]
	private void OCPPPMAJOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9C20", Offset = "0x7BC8820", VA = "0x187BC9C20")]
	private void PDOKHIHCKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8360", Offset = "0x7BC6F60", VA = "0x187BC8360", Slot = "30")]
	public MMNADIEGNMF LIGAJEJMKLO(int BIEEMEKMINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7260", Offset = "0x7BC5E60", VA = "0x187BC7260", Slot = "98")]
	public void JCGLDFHMCIJ(MMNADIEGNMF MPDLOLIOGJL, bool HDEDJGFEFFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9980", Offset = "0x7BC8580", VA = "0x187BC9980", Slot = "99")]
	public void OHBDGFHCDOP(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6490", Offset = "0x7BC5090", VA = "0x187BC6490", Slot = "100")]
	public void GMAKCBJGEFG(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8960", Offset = "0x7BC7560", VA = "0x187BC8960", Slot = "101")]
	public Vector3 MEDMBNAIIBB(Vector3 KOBCHCGJLLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC56F0", Offset = "0x7BC42F0", VA = "0x187BC56F0", Slot = "102")]
	public Vector3 FBECAFHGFMD(Vector3 CMHAGMHENKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC94F0", Offset = "0x7BC80F0", VA = "0x187BC94F0", Slot = "103")]
	public void NDCHPBBDEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC74F0", Offset = "0x7BC60F0", VA = "0x187BC74F0", Slot = "104")]
	public void JLDHACAJGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC56A0", Offset = "0x7BC42A0", VA = "0x187BC56A0", Slot = "105")]
	public void FAGDFGFBAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC47F0", Offset = "0x7BC33F0", VA = "0x187BC47F0", Slot = "106")]
	public void CLPCFJILFHH(Vector3 KPFDANNBDMG, Vector3 DJCOHPBIMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6F10", Offset = "0x7BC5B10", VA = "0x187BC6F10", Slot = "107")]
	public void ILGOOKEKFNJ(Vector3 MDCKKGLAALC, Vector3 GIHMFKNIMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BC95B0", Offset = "0x7BC81B0", VA = "0x187BC95B0", Slot = "108")]
	public void NJBIANIADOP(Vector3 FJMMHMJJINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9A30", Offset = "0x7BC8630", VA = "0x187BC9A30", Slot = "109")]
	public void OINNCCJMKIA(HDEBMOKJEII AHLANEMEBKA, Vector3 CLHLJFLAFEF, float IKBHBGJMCJB, float HCNGNGAPDLK = 8f, float ECOAHHAENAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4590", Offset = "0x7BC3190", VA = "0x187BC4590", Slot = "110")]
	public void CELABFNKMLM(NCBHFGHIKBE KJNADMEBEIF, Vector3 OEFJLLAMMJJ, float NBFMMJGHGJM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F80", Offset = "0x7BC3B80", VA = "0x187BC4F80", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ECHEDHBNPAA(NCBHFGHIKBE KJNADMEBEIF, Vector3 APLHHNGOEFP, float ONMPAKODLON = 7f, float LJHKMJLPGFG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5500", Offset = "0x7BC4100", VA = "0x187BC5500", Slot = "112")]
	public Vector3 ENJNNDLEPCJ(Vector3 MPDLOLIOGJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6DB0", Offset = "0x7BC59B0", VA = "0x187BC6DB0", Slot = "113")]
	public Vector3 IKIBKFMHDDD(Vector3 MPDLOLIOGJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC46C0", Offset = "0x7BC32C0", VA = "0x187BC46C0", Slot = "114")]
	public void CHNJMNIJNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6B70", Offset = "0x7BC5770", VA = "0x187BC6B70", Slot = "115")]
	public void HOCDBNODBEI(MMNADIEGNMF APINEPJPKIP, object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8BE0", Offset = "0x7BC77E0", VA = "0x187BC8BE0", Slot = "116")]
	public void MOEGNJKHHMK(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC50E0", Offset = "0x7BC3CE0", VA = "0x187BC50E0", Slot = "63")]
	public void EHOIEOIGCDD((Quaternion rot, Vector3 moments) GEKAGIBPJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5DD0", Offset = "0x7BC49D0", VA = "0x187BC5DD0", Slot = "117")]
	public void FKCLKJNLANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5600", Offset = "0x7BC4200", VA = "0x187BC5600", Slot = "118")]
	public void ENNOBFJFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC83E0", Offset = "0x7BC6FE0", VA = "0x187BC83E0", Slot = "119")]
	public void LIIOCOMGKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7000", Offset = "0x7BC5C00", VA = "0x187BC7000", Slot = "120")]
	public bool INDNBMGINBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5C80", Offset = "0x7BC4880", VA = "0x187BC5C80", Slot = "97")]
	public void FGFIKBBGNKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC48E0", Offset = "0x7BC34E0", VA = "0x187BC48E0", Slot = "121")]
	public void COFJLBAIBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5F60", Offset = "0x7BC4B60", VA = "0x187BC5F60", Slot = "122")]
	public void FOGKFAFEGLD(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4AC0", Offset = "0x7BC36C0", VA = "0x187BC4AC0", Slot = "123")]
	public void DJBOLPDJGPB(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BC49F0", Offset = "0x7BC35F0", VA = "0x187BC49F0", Slot = "124")]
	public void DBCMOEIEBPL(object IKLHDHMJFFL, bool IAKCGCGLECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9D70", Offset = "0x7BC8970", VA = "0x187BC9D70", Slot = "125")]
	public void POBHHGFPNHM(Vector3 JMOMNLNOKEI, Quaternion FJBMELLBPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7050", Offset = "0x7BC5C50", VA = "0x187BC7050", Slot = "126")]
	public void IPNNFFJADLL(Vector3 MKMLABJLANA, Quaternion IADBBDDNDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BC99E0", Offset = "0x7BC85E0", VA = "0x187BC99E0", Slot = "127")]
	public bool OHMEGBDNIAB(float BPPKCFHOFCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4D60", Offset = "0x7BC3960", VA = "0x187BC4D60", Slot = "128")]
	public void DOICKCEOPDP(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7490", Offset = "0x7BC6090", VA = "0x187BC7490", Slot = "129")]
	public void JKBNBFHDLJF(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC62A0", Offset = "0x7BC4EA0", VA = "0x187BC62A0", Slot = "130")]
	public void GHBBILMDFLD(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC92F0", Offset = "0x7BC7EF0", VA = "0x187BC92F0", Slot = "131")]
	public void NBOHAKJBPKK(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6670", Offset = "0x7BC5270", VA = "0x187BC6670", Slot = "132")]
	public void HIBENAEJGFN(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC72D0", Offset = "0x7BC5ED0", VA = "0x187BC72D0", Slot = "133")]
	public void JIICJKOKFLH(Vector3 NBNIPGNLIMD, Vector3 FCININPMBGJ, ForceMode KDJAPCNFGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC69B0", Offset = "0x7BC55B0", VA = "0x187BC69B0", Slot = "134")]
	public void HLKADJAGMED(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6A90", Offset = "0x7BC5690", VA = "0x187BC6A90", Slot = "135")]
	public void HNDAOKJAHHP(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5CD0", Offset = "0x7BC48D0", VA = "0x187BC5CD0", Slot = "136")]
	public bool FHPNHGEDKKF(Vector3 JJPEELBONAL, [Out] RaycastHit NNKLPCEFCLH, float JOBEKHJDCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8B90", Offset = "0x7BC7790", VA = "0x187BC8B90", Slot = "137")]
	public void MGIEJHBMCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9F70", Offset = "0x7BC8B70", VA = "0x187BC9F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8AC0", Offset = "0x7BC76C0", VA = "0x187BC8AC0")]
	private void MFGGCNEPMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC75F0", Offset = "0x7BC61F0", VA = "0x187BC75F0")]
	private void JPBNINNBCDJ(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5320", Offset = "0x7BC3F20", VA = "0x187BC5320")]
	private void ENAKGGMKKLJ(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8D30", Offset = "0x7BC7930", VA = "0x187BC8D30")]
	private void NBDBNGFEKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8610", Offset = "0x7BC7210", VA = "0x187BC8610")]
	private void MAKDBBKEMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC60F0", Offset = "0x7BC4CF0", VA = "0x187BC60F0")]
	private void GECOOMLKLKN(MMNADIEGNMF JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6CE0", Offset = "0x7BC58E0", VA = "0x187BC6CE0")]
	private void IILNOCCLGIP(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9220", Offset = "0x7BC7E20", VA = "0x187BC9220")]
	private void NBLFLPGLKDG(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9350", Offset = "0x7BC7F50", VA = "0x187BC9350")]
	private void NCEJKPHKHBE(JKJFLLICHBF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8DE0", Offset = "0x7BC79E0", VA = "0x187BC8DE0", Slot = "142")]
	protected virtual void NBEMNOGPHCM(JKJFLLICHBF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BC57F0", Offset = "0x7BC43F0", VA = "0x187BC57F0")]
	protected void FFHEINGJFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7FE0", Offset = "0x7BC6BE0", VA = "0x187BC7FE0")]
	protected void LIDJNLFNFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5B50", Offset = "0x7BC4750", VA = "0x187BC5B50")]
	private void FFLEIAOGLJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4290", Offset = "0x7BC2E90", VA = "0x187BC4290")]
	private void BKOEOILFJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class NOEBGMHKAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4930", Offset = "0x7BD3530", VA = "0x187BD4930")]
	public static MMNADIEGNMF CMFKGLLNENC(this MMNADIEGNMF PPJMBNBBIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7BD49F0", Offset = "0x7BD35F0", VA = "0x187BD49F0")]
	public static bool EDFKIFJPOME(this MMNADIEGNMF PPJMBNBBIOK, MMNADIEGNMF FGHAKLFHDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4A90", Offset = "0x7BD3690", VA = "0x187BD4A90")]
	public static bool ONOIAKLAKFD(this MMNADIEGNMF PPJMBNBBIOK, MMNADIEGNMF AEOOKJGJOAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7BD48E0", Offset = "0x7BD34E0", VA = "0x187BD48E0")]
	public static JKJFLLICHBF BOIKHPICHDM(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4B30", Offset = "0x7BD3730", VA = "0x187BD4B30")]
	public static DOKGDAHGDLJ PNCJGFPMLGM(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BPIGCDGKBOE : FNENLGPLIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7BC34F0", Offset = "0x7BC20F0", VA = "0x187BC34F0", Slot = "19")]
	public MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK, HJKIKFEINAB LLDJIJICLJF, EMLCKEBDGOE JHBOJJACLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "4")]
	public HKINKMOMMHM BEHJHKNBMGJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "5")]
	public BAEKAHCPLJM CIOBLJOBIGN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "6")]
	public BEMKKJCJFIH HCBABMHFNMB(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "7")]
	public IHGCMBPDIBD DCABOBJMJFJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "8")]
	public HCDHFAMACEN CFPBILLGMKL(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "9")]
	public EGLCLDBEGIA AKGOPDEMOKE(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "10")]
	public HBAKFHGADEE KOICNNMHKLA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "11")]
	public ICPNFADBKNB JKEOPOBLDMN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "12")]
	public AOOOOAFHLKD KIDKJIIIFNN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "13")]
	public AEAEGAPIKMH EPIGGIIBJDA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public KBJNBNAAPCP ILDGMIALALE(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public ELGGDMCLPFM KBLAMDIIIBJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public DMJEGOFOJKK JCLJICALPPI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public EOMAMBBEKEH JAFECCHDLBK(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	public DFJFNEMONGM HHPICFKIKPJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public BPIGCDGKBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "14")]
	private KBJNBNAAPCP DJOEINAHCHI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "15")]
	private ELGGDMCLPFM BGCLEGMEJKD(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "16")]
	private DMJEGOFOJKK EFOPKBGFEDG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "17")]
	private EOMAMBBEKEH HEHNAKHJIEG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "18")]
	private DFJFNEMONGM HMCEAJENNJH(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(FNENLGPLIKK), new string[] { })]
public class MDECHHKPFJE : FNENLGPLIKK, PEGFAJCJPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FNENLGPLIKK NHFICFIOANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FNENLGPLIKK BDJIKIAHLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PDNAPLMDGDP PJMIOFIBCEK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FNENLGPLIKK LFFAGHNIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3E70", Offset = "0x7BD2A70", VA = "0x187BD3E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3ED0", Offset = "0x7BD2AD0", VA = "0x187BD3ED0", Slot = "20")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD35F0", Offset = "0x7BD21F0", VA = "0x187BD35F0", Slot = "4")]
	public HKINKMOMMHM BEHJHKNBMGJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD37E0", Offset = "0x7BD23E0", VA = "0x187BD37E0", Slot = "5")]
	public BAEKAHCPLJM CIOBLJOBIGN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3C70", Offset = "0x7BD2870", VA = "0x187BD3C70", Slot = "6")]
	public BEMKKJCJFIH HCBABMHFNMB(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3880", Offset = "0x7BD2480", VA = "0x187BD3880", Slot = "7")]
	public IHGCMBPDIBD DCABOBJMJFJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3740", Offset = "0x7BD2340", VA = "0x187BD3740", Slot = "8")]
	public HCDHFAMACEN CFPBILLGMKL(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3550", Offset = "0x7BD2150", VA = "0x187BD3550", Slot = "9")]
	public EGLCLDBEGIA AKGOPDEMOKE(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4060", Offset = "0x7BD2C60", VA = "0x187BD4060", Slot = "10")]
	public HBAKFHGADEE KOICNNMHKLA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3F20", Offset = "0x7BD2B20", VA = "0x187BD3F20", Slot = "11")]
	public ICPNFADBKNB JKEOPOBLDMN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3FC0", Offset = "0x7BD2BC0", VA = "0x187BD3FC0", Slot = "12")]
	public AOOOOAFHLKD KIDKJIIIFNN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3A80", Offset = "0x7BD2680", VA = "0x187BD3A80", Slot = "13")]
	public AEAEGAPIKMH EPIGGIIBJDA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3920", Offset = "0x7BD2520", VA = "0x187BD3920")]
	public KBJNBNAAPCP ILDGMIALALE(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3690", Offset = "0x7BD2290", VA = "0x187BD3690")]
	public ELGGDMCLPFM KBLAMDIIIBJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD39D0", Offset = "0x7BD25D0", VA = "0x187BD39D0")]
	public DMJEGOFOJKK JCLJICALPPI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3D10", Offset = "0x7BD2910", VA = "0x187BD3D10")]
	public EOMAMBBEKEH JAFECCHDLBK(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3DC0", Offset = "0x7BD29C0", VA = "0x187BD3DC0")]
	public DFJFNEMONGM HHPICFKIKPJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3B20", Offset = "0x7BD2720", VA = "0x187BD3B20", Slot = "19")]
	public MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK, HJKIKFEINAB LLDJIJICLJF, EMLCKEBDGOE JHBOJJACLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4100", Offset = "0x7BD2D00", VA = "0x187BD4100")]
	public MDECHHKPFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3920", Offset = "0x7BD2520", VA = "0x187BD3920", Slot = "14")]
	private KBJNBNAAPCP DJOEINAHCHI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3690", Offset = "0x7BD2290", VA = "0x187BD3690", Slot = "15")]
	private ELGGDMCLPFM BGCLEGMEJKD(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7BD39D0", Offset = "0x7BD25D0", VA = "0x187BD39D0", Slot = "16")]
	private DMJEGOFOJKK EFOPKBGFEDG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3D10", Offset = "0x7BD2910", VA = "0x187BD3D10", Slot = "17")]
	private EOMAMBBEKEH HEHNAKHJIEG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3DC0", Offset = "0x7BD29C0", VA = "0x187BD3DC0", Slot = "18")]
	private DFJFNEMONGM HMCEAJENNJH(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FJGKAOMNAHC : HKINKMOMMHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOMJBDKJEKF(MMNADIEGNMF PPJMBNBBIOK);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCCNKLGIMBC(MMNADIEGNMF PPJMBNBBIOK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PELCLBIDJBO(MMNADIEGNMF JBLNPFGIKHB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGDNFAFIMJP(MMNADIEGNMF JBLNPFGIKHB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FOGNCFJDFHI : BEMKKJCJFIH
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	NICJALOBGIF<MMNADIEGNMF> MIMKAPHDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	MMNADIEGNMF KEPMNKCDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JNHGFJEGEHM : EOMAMBBEKEH
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JPLBGCAIDEO(Rigidbody BGFKGNNCFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface COGGKBPHKED : ELGGDMCLPFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView CHLOACJGDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EOIJLCBINAF : AOOOOAFHLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode HMPNNNPEDIK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAB70", Offset = "0x7BC9770", VA = "0x187BCAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode MJDIBONEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA9E0", Offset = "0x7BC95E0", VA = "0x187BCA9E0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7BCACF0", Offset = "0x7BC98F0", VA = "0x187BCACF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAD60", Offset = "0x7BC9960", VA = "0x187BCAD60")]
	public EOIJLCBINAF(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA770", Offset = "0x7BC9370", VA = "0x187BCA770", Slot = "6")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAAF0", Offset = "0x7BC96F0", VA = "0x187BCAAF0", Slot = "9")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7BCACE0", Offset = "0x7BC98E0", VA = "0x187BCACE0", Slot = "7")]
	public void KPPEHCGCAIA(bool DMDIMEKCFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA760", Offset = "0x7BC9360", VA = "0x187BCA760", Slot = "8")]
	public void CDMAGFJJDCE(bool DMDIMEKCFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA880", Offset = "0x7BC9480", VA = "0x187BCA880", Slot = "10")]
	public bool FHPNHGEDKKF(Vector3 JJPEELBONAL, [Out] RaycastHit NNKLPCEFCLH, float JOBEKHJDCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7BCABC0", Offset = "0x7BC97C0", VA = "0x187BCABC0")]
	private void KKJBCOLGDFM(bool DMDIMEKCFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EAPCENAIFLJ : EGLCLDBEGIA, IDisposable, KOBEPGCLKJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private INJLACPLDPA LCFLCMLHHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private HNBIKALEBEL HLGCCLDPFID;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public INJLACPLDPA BMIDJOFLCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA590", Offset = "0x7BC9190", VA = "0x187BCA590", Slot = "6")]
		get
		{
			return default(INJLACPLDPA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA410", Offset = "0x7BC9010", VA = "0x187BCA410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform DNNGDBLOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB79370", Offset = "0xB77F70", VA = "0x180B79370", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CKBJHKOEDDL, CKBJHKOEDDL> GHPAPKAFGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA0A0", Offset = "0x7BC8CA0", VA = "0x187BCA0A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA4E0", Offset = "0x7BC90E0", VA = "0x187BCA4E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA6D0", Offset = "0x7BC92D0", VA = "0x187BCA6D0")]
	public EAPCENAIFLJ(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA150", Offset = "0x7BC8D50", VA = "0x187BCA150", Slot = "8")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCA3C0", Offset = "0x7BC8FC0", VA = "0x187BCA3C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFBF2D0", Offset = "0xFBDED0", VA = "0x180FBF2D0", Slot = "11")]
	private void CONKHPEFMCK(CKBJHKOEDDL FIABLBDDJHG, CKBJHKOEDDL IKECMDPKBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "12")]
	private void FONDJEBGDAJ(bool BCGLHGDCEPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AIPFBKBGNAF : FNENLGPLIKK
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2470", Offset = "0x7BC1070", VA = "0x187BC2470", Slot = "4")]
	public HKINKMOMMHM BEHJHKNBMGJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7BC27C0", Offset = "0x7BC13C0", VA = "0x187BC27C0", Slot = "5")]
	public BAEKAHCPLJM CIOBLJOBIGN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2DE0", Offset = "0x7BC19E0", VA = "0x187BC2DE0", Slot = "6")]
	public BEMKKJCJFIH HCBABMHFNMB(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7BC28E0", Offset = "0x7BC14E0", VA = "0x187BC28E0", Slot = "7")]
	public IHGCMBPDIBD DCABOBJMJFJ(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7BC26F0", Offset = "0x7BC12F0", VA = "0x187BC26F0", Slot = "8")]
	public HCDHFAMACEN CFPBILLGMKL(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7BC23A0", Offset = "0x7BC0FA0", VA = "0x187BC23A0", Slot = "9")]
	public EGLCLDBEGIA AKGOPDEMOKE(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3300", Offset = "0x7BC1F00", VA = "0x187BC3300", Slot = "10")]
	public HBAKFHGADEE KOICNNMHKLA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3180", Offset = "0x7BC1D80", VA = "0x187BC3180", Slot = "11")]
	public ICPNFADBKNB JKEOPOBLDMN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3240", Offset = "0x7BC1E40", VA = "0x187BC3240", Slot = "12")]
	public AOOOOAFHLKD KIDKJIIIFNN(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2BD0", Offset = "0x7BC17D0", VA = "0x187BC2BD0", Slot = "13")]
	public AEAEGAPIKMH EPIGGIIBJDA(MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2960", Offset = "0x7BC1560", VA = "0x187BC2960")]
	public KBJNBNAAPCP ILDGMIALALE(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2560", Offset = "0x7BC1160", VA = "0x187BC2560")]
	public ELGGDMCLPFM KBLAMDIIIBJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2AA0", Offset = "0x7BC16A0", VA = "0x187BC2AA0")]
	public DMJEGOFOJKK JCLJICALPPI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2F10", Offset = "0x7BC1B10", VA = "0x187BC2F10")]
	public EOMAMBBEKEH JAFECCHDLBK(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC30A0", Offset = "0x7BC1CA0", VA = "0x187BC30A0")]
	public DFJFNEMONGM HHPICFKIKPJ(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2C90", Offset = "0x7BC1890", VA = "0x187BC2C90", Slot = "19")]
	public MMNADIEGNMF FCFGCKCFOKI(RigidbodyEx PPJMBNBBIOK, HJKIKFEINAB LLDJIJICLJF, EMLCKEBDGOE JHBOJJACLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public AIPFBKBGNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2960", Offset = "0x7BC1560", VA = "0x187BC2960", Slot = "14")]
	private KBJNBNAAPCP DJOEINAHCHI(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2560", Offset = "0x7BC1160", VA = "0x187BC2560", Slot = "15")]
	private ELGGDMCLPFM BGCLEGMEJKD(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2AA0", Offset = "0x7BC16A0", VA = "0x187BC2AA0", Slot = "16")]
	private DMJEGOFOJKK EFOPKBGFEDG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2F10", Offset = "0x7BC1B10", VA = "0x187BC2F10", Slot = "17")]
	private EOMAMBBEKEH HEHNAKHJIEG(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7BC30A0", Offset = "0x7BC1CA0", VA = "0x187BC30A0", Slot = "18")]
	private DFJFNEMONGM HMCEAJENNJH(MMNADIEGNMF FOBBPKHANPP, [In] HJKIKFEINAB LLDJIJICLJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class ODMDDEDCDOA : ICPNFADBKNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAB70", Offset = "0x7BC9770", VA = "0x187BCAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool NNNLOIGOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4D00", Offset = "0x7BD3900", VA = "0x187BD4D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool KDDPDIGHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7BD0BB0", Offset = "0x7BCF7B0", VA = "0x187BD0BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7BD55F0", Offset = "0x7BD41F0", VA = "0x187BD55F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAD60", Offset = "0x7BC9960", VA = "0x187BCAD60")]
	public ODMDDEDCDOA(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4BA0", Offset = "0x7BD37A0", VA = "0x187BD4BA0", Slot = "4")]
	public void HIBENAEJGFN(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5650", Offset = "0x7BD4250", VA = "0x187BD5650")]
	private void NPKEKPJIOOP(Vector3 NBNIPGNLIMD, ForceMode KDJAPCNFGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5370", Offset = "0x7BD3F70", VA = "0x187BD5370", Slot = "5")]
	public void JIICJKOKFLH(Vector3 NBNIPGNLIMD, Vector3 FCININPMBGJ, ForceMode KDJAPCNFGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4D50", Offset = "0x7BD3950", VA = "0x187BD4D50", Slot = "6")]
	public void HLKADJAGMED(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5110", Offset = "0x7BD3D10", VA = "0x187BD5110")]
	private void IGAJCENMFME(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4EB0", Offset = "0x7BD3AB0", VA = "0x187BD4EB0", Slot = "7")]
	public void HNDAOKJAHHP(Vector3 PAOIBNHJPJJ, ForceMode KDJAPCNFGKA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class FBKMMOBAJMI : AEAEGAPIKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PLOFNPGGJPE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool IHDBOAJAICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xBB8D00", Offset = "0xBB7900", VA = "0x180BB8D00", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAE90", Offset = "0x7BC9A90", VA = "0x187BCAE90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAD60", Offset = "0x7BC9960", VA = "0x187BCAD60")]
	public FBKMMOBAJMI(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7BCADF0", Offset = "0x7BC99F0", VA = "0x187BCADF0", Slot = "6")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAE20", Offset = "0x7BC9A20", VA = "0x187BCAE20", Slot = "7")]
	public void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class MCIKAEIPGHH : FJGKAOMNAHC, HKINKMOMMHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MMNADIEGNMF PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<MMNADIEGNMF> HGBJMNEMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MMNADIEGNMF EBMDCHEPJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MMNADIEGNMF KOIBCEOILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform MLNPJHEPNJO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform DKANJPNMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2260", Offset = "0x7BD0E60", VA = "0x187BD2260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960220", VA = "0x180961620", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2A30", Offset = "0x7BD1630", VA = "0x187BD2A30", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public MMNADIEGNMF JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x960120", VA = "0x180961520", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<MMNADIEGNMF> KBIAIELPOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x95F020", Offset = "0x95DC20", VA = "0x18095F020", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event GKDNFNOFKME MLLGBFINBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7BD22C0", Offset = "0x7BD0EC0", VA = "0x187BD22C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F00", Offset = "0x7BD1B00", VA = "0x187BD2F00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event GKDNFNOFKME ACBHKDBCCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1740", Offset = "0x7BD0340", VA = "0x187BD1740", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1CE0", Offset = "0x7BD08E0", VA = "0x187BD1CE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GKPCOHIAIAH CHABONFNFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2BA0", Offset = "0x7BD17A0", VA = "0x187BD2BA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD17E0", Offset = "0x7BD03E0", VA = "0x187BD17E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action DMDNJKFBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1880", Offset = "0x7BD0480", VA = "0x187BD1880", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2C80", Offset = "0x7BD1880", VA = "0x187BD2C80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action NFFDFICGAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1A70", Offset = "0x7BD0670", VA = "0x187BD1A70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2E60", Offset = "0x7BD1A60", VA = "0x187BD2E60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<MMNADIEGNMF> EFBHODOCKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2AF0", Offset = "0x7BD16F0", VA = "0x187BD2AF0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BD19C0", Offset = "0x7BD05C0", VA = "0x187BD19C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MMNADIEGNMF> PDLAMJBGHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2360", Offset = "0x7BD0F60", VA = "0x187BD2360", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BD21B0", Offset = "0x7BD0DB0", VA = "0x187BD21B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action PBLCCAKOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2110", Offset = "0x7BD0D10", VA = "0x187BD2110", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2990", Offset = "0x7BD1590", VA = "0x187BD2990", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<MMNADIEGNMF> OECPIBDECBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2A40", Offset = "0x7BD1640", VA = "0x187BD2A40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E20", Offset = "0x7BD0A20", VA = "0x187BD1E20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3490", Offset = "0x7BD2090", VA = "0x187BD3490")]
	public MCIKAEIPGHH(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1B10", Offset = "0x7BD0710", VA = "0x187BD1B10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2410", Offset = "0x7BD1010", VA = "0x187BD2410", Slot = "30")]
	public void JCGLDFHMCIJ(MMNADIEGNMF BDHPANPFDPF, bool HDEDJGFEFFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2FA0", Offset = "0x7BD1BA0", VA = "0x187BD2FA0", Slot = "6")]
	public void PELCLBIDJBO(MMNADIEGNMF JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3210", Offset = "0x7BD1E10", VA = "0x187BD3210", Slot = "7")]
	public void PGDNFAFIMJP(MMNADIEGNMF JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2000", Offset = "0x7BD0C00", VA = "0x187BD2000", Slot = "4")]
	public void FOMJBDKJEKF(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1920", Offset = "0x7BD0520", VA = "0x187BD1920", Slot = "5")]
	public void CCCNKLGIMBC(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1D80", Offset = "0x7BD0980", VA = "0x187BD1D80")]
	private void ENKDEBBIPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2C40", Offset = "0x7BD1840", VA = "0x187BD2C40")]
	private void MFGCHDNPDNO(MMNADIEGNMF JBLNPFGIKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2D20", Offset = "0x7BD1920", VA = "0x187BD2D20")]
	private void NEFJKOLKOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1ED0", Offset = "0x7BD0AD0", VA = "0x187BD1ED0")]
	private void FCAIDIPAJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1BB0", Offset = "0x7BD07B0", VA = "0x187BD1BB0")]
	private void ELDIEKNMFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1680", Offset = "0x7BD0280", VA = "0x187BD1680")]
	[CompilerGenerated]
	private object AKGFBEPLHGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class AEEFFDIJNOM
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC22E0", Offset = "0x7BC0EE0", VA = "0x187BC22E0")]
	public static FJGKAOMNAHC DKHCKMBPBNO(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PFDOKCHNDLG : FOGNCFJDFHI, BEMKKJCJFIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NICJALOBGIF<MMNADIEGNMF> KFGJLGAGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool POJLCIMEHJP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NICJALOBGIF<MMNADIEGNMF> MIMKAPHDMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 IPPPMGEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6410", Offset = "0x7BD5010", VA = "0x187BD6410", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 HAPHIOLJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD59A0", Offset = "0x7BD45A0", VA = "0x187BD59A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 FDADPHGJIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD58B0", Offset = "0x7BD44B0", VA = "0x187BD58B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public MMNADIEGNMF KEPMNKCDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD62F0", Offset = "0x7BD4EF0", VA = "0x187BD62F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6440", Offset = "0x7BD5040", VA = "0x187BD6440")]
	public PFDOKCHNDLG(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD63A0", Offset = "0x7BD4FA0", VA = "0x187BD63A0", Slot = "8")]
	public void LEKAPCCIJKN(MMNADIEGNMF KOIBCEOILEL, object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5B60", Offset = "0x7BD4760", VA = "0x187BD5B60", Slot = "9")]
	public void HEMDLOCJHDK(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5F50", Offset = "0x7BD4B50", VA = "0x187BD5F50")]
	private Vector3 ILKAICAMOBN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5BC0", Offset = "0x7BD47C0", VA = "0x187BD5BC0")]
	private void ILCHCAJGPDB(MMNADIEGNMF FHPFCGNELFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class KNJLMFLPGFM
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCB20", Offset = "0x7BCB720", VA = "0x187BCCB20")]
	public static FOGNCFJDFHI IOGIJALABKK(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PJLLLBNGODJ : JNHGFJEGEHM, EOMAMBBEKEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 GHLEGGNKMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 BAIOIKGIMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GGFJEDBCOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float IJIKDBDCDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 JGOFCJOHKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? JEDHAJEGGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? OAIGKKJLCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool NNOJNGDAFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool HANKKEHLJDF;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 OMLAPECNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x13E75C0", Offset = "0x13E61C0", VA = "0x1813E75C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7F10", Offset = "0x7BD6B10", VA = "0x187BD7F10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 PELDPPHALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6690", Offset = "0x7BD5290", VA = "0x187BD6690", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float AIJIDCPBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xB9DB60", Offset = "0xB9C760", VA = "0x180B9DB60", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8140", Offset = "0x7BD6D40", VA = "0x187BD8140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float PIMPOCNJNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA9DE00", Offset = "0xA9CA00", VA = "0x180A9DE00", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD65E0", Offset = "0x7BD51E0", VA = "0x187BD65E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 AEBPNODKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6C50", Offset = "0x7BD5850", VA = "0x187BD6C50", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion JNBMHDELDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD8980", Offset = "0x7BD7580", VA = "0x187BD8980", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB770", Offset = "0x7BCA370", VA = "0x187BCB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event GKDNFNOFKME CMLLNCFMEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6780", Offset = "0x7BD5380", VA = "0x187BD6780", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD6540", Offset = "0x7BD5140", VA = "0x187BD6540", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8CA0", Offset = "0x7BD78A0", VA = "0x187BD8CA0")]
	public PJLLLBNGODJ(MMNADIEGNMF PPJMBNBBIOK, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6B30", Offset = "0x7BD5730", VA = "0x187BD6B30", Slot = "17")]
	public void FKCLKJNLANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6A50", Offset = "0x7BD5650", VA = "0x187BD6A50", Slot = "16")]
	public void ENNOBFJFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6DE0", Offset = "0x7BD59E0", VA = "0x187BD6DE0", Slot = "19")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6EC0", Offset = "0x7BD5AC0", VA = "0x187BD6EC0", Slot = "20")]
	public void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8250", Offset = "0x7BD6E50", VA = "0x187BD8250", Slot = "18")]
	public void LIIOCOMGKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8400", Offset = "0x7BD7000", VA = "0x187BD8400", Slot = "21")]
	public void MGIEJHBMCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7F10", Offset = "0x7BD6B10", VA = "0x187BD7F10")]
	private void NCCGGLKKNKJ(Vector3 MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8890", Offset = "0x7BD7490", VA = "0x187BD8890")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 MPNACBAILCG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8140", Offset = "0x7BD6D40", VA = "0x187BD8140")]
	private void LHMBLNACDID(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD65E0", Offset = "0x7BD51E0", VA = "0x187BD65E0")]
	private void AMMDJMNEIGB(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8B00", Offset = "0x7BD7700", VA = "0x187BD8B00")]
	private Vector3 PEJPJJFDGDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6820", Offset = "0x7BD5420", VA = "0x187BD6820", Slot = "15")]
	public void EHOIEOIGCDD((Quaternion rot, Vector3 moments) GEKAGIBPJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7FC0", Offset = "0x7BD6BC0", VA = "0x187BD7FC0")]
	private Quaternion LBPKFHDONID()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD70A0", Offset = "0x7BD5CA0", VA = "0x187BD70A0")]
	public void JPLBGCAIDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7170", Offset = "0x7BD5D70", VA = "0x187BD7170", Slot = "4")]
	public (float, Vector3) JPLBGCAIDEO(Rigidbody BGFKGNNCFGD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class IIDEBFOCIPJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBD70", Offset = "0x7BCA970", VA = "0x187BCBD70")]
	public static JNHGFJEGEHM ODNFFIFGJJN(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LHPOHALJEDB : DMJEGOFOJKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MKEMIGJFLFM ILNKIHCFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly HGFGAMBABML DBMDMGIFLNH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AFBKCMMGOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x157B810", Offset = "0x157A410", VA = "0x18157B810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HGFGAMBABML PODHPPPDFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00", Slot = "11")]
		get
		{
			return default(HGFGAMBABML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0890", Offset = "0x7BCF490", VA = "0x187BD0890")]
	public LHPOHALJEDB(MMNADIEGNMF PPJMBNBBIOK, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0280", Offset = "0x7BCEE80", VA = "0x187BD0280", Slot = "4")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0780", Offset = "0x7BCF380", VA = "0x187BD0780")]
	private bool LLLLBMHOGLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0860", Offset = "0x7BCF460", VA = "0x187BD0860", Slot = "5")]
	public void NAIFHFNFKFC(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0350", Offset = "0x7BCEF50", VA = "0x187BD0350", Slot = "6")]
	public void DLAEDBOLGOC(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0380", Offset = "0x7BCEF80", VA = "0x187BD0380", Slot = "9")]
	public void DOFKAMJJBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0670", Offset = "0x7BCF270", VA = "0x187BD0670")]
	private void JPCJFGNKLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD04F0", Offset = "0x7BCF0F0", VA = "0x187BD04F0")]
	private void ILKLDMFKPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD04B0", Offset = "0x7BCF0B0", VA = "0x187BD04B0", Slot = "8")]
	public void GNGNBAOLJJJ(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0820", Offset = "0x7BCF420", VA = "0x187BD0820", Slot = "7")]
	public void MJFAGGCGHJA(MMNADIEGNMF PPJMBNBBIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NEFGBOIPINF : HBAKFHGADEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MKEMIGJFLFM AOCKKGMJOMB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool NNNLOIGOEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4670", Offset = "0x7BD3270", VA = "0x187BD4670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event GKDNFNOFKME NPAOOIFHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4750", Offset = "0x7BD3350", VA = "0x187BD4750", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD43E0", Offset = "0x7BD2FE0", VA = "0x187BD43E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD47F0", Offset = "0x7BD33F0", VA = "0x187BD47F0")]
	public NEFGBOIPINF(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD45E0", Offset = "0x7BD31E0", VA = "0x187BD45E0", Slot = "7")]
	public void FOGKFAFEGLD(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4590", Offset = "0x7BD3190", VA = "0x187BD4590", Slot = "8")]
	public void DJBOLPDJGPB(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4480", Offset = "0x7BD3080", VA = "0x187BD4480", Slot = "9")]
	public void DBCMOEIEBPL(object IKLHDHMJFFL, bool IAKCGCGLECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD45A0", Offset = "0x7BD31A0", VA = "0x187BD45A0", Slot = "12")]
	public void FLCKGGCPFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD45F0", Offset = "0x7BD31F0", VA = "0x187BD45F0", Slot = "10")]
	public void HGDHFLCDEDC(Rigidbody NIAHBPBMHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4720", Offset = "0x7BD3320", VA = "0x187BD4720", Slot = "11")]
	public void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JMMMEIFECLO : COGGKBPHKED, ELGGDMCLPFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView FBABJFFKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool DNPGBKMEJEG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView CHLOACJGDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool IDCMPKOIAME
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC340", Offset = "0x7BCAF40", VA = "0x187BCC340", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DCAJBNFMLED
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event GKDNFNOFKME HFHAFGPCCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC360", Offset = "0x7BCAF60", VA = "0x187BCC360", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC400", Offset = "0x7BCB000", VA = "0x187BCC400", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC9D0", Offset = "0x7BCB5D0", VA = "0x187BCC9D0")]
	public JMMMEIFECLO(MMNADIEGNMF PPJMBNBBIOK, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBFA0", Offset = "0x7BCABA0", VA = "0x187BCBFA0", Slot = "9")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC0D0", Offset = "0x7BCACD0", VA = "0x187BCC0D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC1D0", Offset = "0x7BCADD0", VA = "0x187BCC1D0", Slot = "10")]
	public void IILNOCCLGIP(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC860", Offset = "0x7BCB460", VA = "0x187BCC860", Slot = "11")]
	public void NBLFLPGLKDG(MMNADIEGNMF KOIBCEOILEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBE30", Offset = "0x7BCAA30", VA = "0x187BCBE30")]
	private void AHKKKEKAKLC(PhotonView PNDJDIGHPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC4A0", Offset = "0x7BCB0A0", VA = "0x187BCC4A0")]
	private void LPLOHIIPFJA(JKJFLLICHBF MCCCFCALLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC5F0", Offset = "0x7BCB1F0", VA = "0x187BCC5F0")]
	private void MDLCJFLONPM(PhotonView EMNFEGILINP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class HBDEKOEMKHE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBCB0", Offset = "0x7BCA8B0", VA = "0x187BCBCB0")]
	public static COGGKBPHKED PJMNBOANAHA(this MMNADIEGNMF FOBBPKHANPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NDNKKCPHCFJ : DFJFNEMONGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints PEPMCCJPIPI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool NPKNNINDDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB251F0", Offset = "0xB23DF0", VA = "0x180B251F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xBBB4F0", Offset = "0xBBA0F0", VA = "0x180BBB4F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GHFLKNMKAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xBBB500", Offset = "0xBBA100", VA = "0x180BBB500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xBBB580", Offset = "0xBBA180", VA = "0x180BBB580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints EALBMOJKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD41B0", Offset = "0x7BD2DB0", VA = "0x187BD41B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4340", Offset = "0x7BD2F40", VA = "0x187BD4340")]
	public NDNKKCPHCFJ(MMNADIEGNMF PPJMBNBBIOK, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD42E0", Offset = "0x7BD2EE0", VA = "0x187BD42E0", Slot = "9")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4310", Offset = "0x7BD2F10", VA = "0x187BD4310", Slot = "10")]
	public void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MCDAAEHJDMN : IHGCMBPDIBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MMNADIEGNMF PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float BNEDBGHNBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float CHFHCGCKICK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float LNFNJMGEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xD69C10", Offset = "0xD68810", VA = "0x180D69C10", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD13B0", Offset = "0x7BCFFB0", VA = "0x187BD13B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PLONLIDEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xBE6C40", Offset = "0xBE5840", VA = "0x180BE6C40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1570", Offset = "0x7BD0170", VA = "0x187BD1570", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1640", Offset = "0x7BD0240", VA = "0x187BD1640")]
	public MCDAAEHJDMN(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1480", Offset = "0x7BD0080", VA = "0x187BD1480", Slot = "8")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD14D0", Offset = "0x7BD00D0", VA = "0x187BD14D0", Slot = "9")]
	public void IPGCJIOGMFD(Rigidbody GLAPFMEOBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GCAEFGLPMFF : HCDHFAMACEN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly NDNFAPMFFIF NCKKDAACPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool BIPLLMMEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool LOFOMBDBJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int MBPGFEGFLAM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB770", Offset = "0x7BCA370", VA = "0x187BCB770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool MAMANHMLNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB1D0", Offset = "0x7BC9DD0", VA = "0x187BCB1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MMNADIEGNMF HNLFKIAHAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB710", Offset = "0x7BCA310", VA = "0x187BCB710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool KDDPDIGHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB320", Offset = "0x7BC9F20", VA = "0x187BCB320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GKDNFNOFKME PCNPJOLDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB130", Offset = "0x7BC9D30", VA = "0x187BCB130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB7C0", Offset = "0x7BCA3C0", VA = "0x187BCB7C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBC20", Offset = "0x7BCA820", VA = "0x187BCBC20")]
	public GCAEFGLPMFF(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB290", Offset = "0x7BC9E90", VA = "0x187BCB290", Slot = "6")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB510", Offset = "0x7BCA110", VA = "0x187BCB510", Slot = "8")]
	public void EKEKHPCCLBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB5C0", Offset = "0x7BCA1C0", VA = "0x187BCB5C0", Slot = "7")]
	public bool INDNBMGINBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB520", Offset = "0x7BCA120", VA = "0x187BCB520", Slot = "9")]
	public void FGFIKBBGNKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB1F0", Offset = "0x7BC9DF0", VA = "0x187BCB1F0", Slot = "13")]
	public void COFJLBAIBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7BCAFA0", Offset = "0x7BC9BA0", VA = "0x187BCAFA0", Slot = "12")]
	public void AFGJGEKHFMB(bool FNOBGOMNOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB0C0", Offset = "0x7BC9CC0", VA = "0x187BCB0C0", Slot = "10")]
	public bool AFMNFLFADGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBAE0", Offset = "0x7BCA6E0", VA = "0x187BCBAE0", Slot = "11")]
	public bool PDOKHIHCKNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB860", Offset = "0x7BCA460", VA = "0x187BCB860")]
	private bool NLDEMGDEBHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB380", Offset = "0x7BC9F80", VA = "0x187BCB380")]
	private void EDHEDGFNODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LKOJHALCGKD : KBJNBNAAPCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MKEMIGJFLFM HODAHCPKKNN;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody LMCFJKNGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool KDDPDIGHGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD0BB0", Offset = "0x7BCF7B0", VA = "0x187BD0BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool BEMEDGLNGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x157B810", Offset = "0x157A410", VA = "0x18157B810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1190", Offset = "0x7BCFD90", VA = "0x187BD1190")]
	public LKOJHALCGKD(MMNADIEGNMF PPJMBNBBIOK, [In] HJKIKFEINAB LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0B10", Offset = "0x7BCF710", VA = "0x187BD0B10", Slot = "5")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0E00", Offset = "0x7BCFA00", VA = "0x187BD0E00", Slot = "7")]
	public void GHBBILMDFLD(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0E30", Offset = "0x7BCFA30", VA = "0x187BD0E30", Slot = "8")]
	public void NBOHAKJBPKK(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0E60", Offset = "0x7BCFA60", VA = "0x187BD0E60", Slot = "9")]
	public void OINNNAEHPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0C10", Offset = "0x7BCF810", VA = "0x187BD0C10", Slot = "10")]
	public void EFLNCBOFJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0990", Offset = "0x7BCF590", VA = "0x187BD0990", Slot = "11")]
	public void AEBLOFPIBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LADDPENPOON : BAEKAHCPLJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly DOKGDAHGDLJ PPJMBNBBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MKEMIGJFLFM KHGHGKNCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float HKACAGCGEBP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DDBGNDDKCOF DHBAJIEBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PGKFHALECKJ CEHBFLLMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 FDADPHGJIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCD80", Offset = "0x7BCB980", VA = "0x187BCCD80", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7BCEB80", Offset = "0x7BCD780", VA = "0x187BCEB80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 NDCIBIEBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE130", Offset = "0x7BCCD30", VA = "0x187BCE130", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCEC40", Offset = "0x7BCD840", VA = "0x187BCEC40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 OOHNAEGHCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE250", Offset = "0x7BCCE50", VA = "0x187BCE250", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7BCEA10", Offset = "0x7BCD610", VA = "0x187BCEA10", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 INGOOIDCCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCED0", Offset = "0x7BCBAD0", VA = "0x187BCCED0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD230", Offset = "0x7BCBE30", VA = "0x187BCD230", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float FHHLPKEKJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xE95D30", Offset = "0xE94930", VA = "0x180E95D30", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD120", Offset = "0x7BCBD20", VA = "0x187BCD120", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool MDKOMOAIIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1E9CEF0", Offset = "0x1E9BAF0", VA = "0x181E9CEF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ICPNFADBKNB CJOEFIMNFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x72B8390", Offset = "0x72B6F90", VA = "0x1872B8390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool MAMANHMLNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCFF0", Offset = "0x7BCBBF0", VA = "0x187BCCFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0190", Offset = "0x7BCED90", VA = "0x187BD0190")]
	public LADDPENPOON(MMNADIEGNMF PPJMBNBBIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD8B0", Offset = "0x7BCC4B0", VA = "0x187BCD8B0", Slot = "19")]
	public void DKEOJGLDIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD950", Offset = "0x7BCC550", VA = "0x187BCD950", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE3A0", Offset = "0x7BCCFA0", VA = "0x187BCE3A0", Slot = "28")]
	public void HGDHFLCDEDC(Rigidbody GLAPFMEOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x139A680", Offset = "0x1399280", VA = "0x18139A680", Slot = "20")]
	public void DPPCLPDCBHH(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x139C620", Offset = "0x139B220", VA = "0x18139C620", Slot = "30")]
	public void GAMDEEDLGGF(object IKLHDHMJFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEC70", Offset = "0x7BCD870", VA = "0x187BCEC70", Slot = "35")]
	public Vector3 MEDMBNAIIBB(Vector3 KOBCHCGJLLB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF70", Offset = "0x7BCCB70", VA = "0x187BCDF70", Slot = "34")]
	public Vector3 FBECAFHGFMD(Vector3 CMHAGMHENKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD8B0", Offset = "0x7BCC4B0", VA = "0x187BCD8B0", Slot = "27")]
	public void NDCHPBBDEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE9B0", Offset = "0x7BCD5B0", VA = "0x187BCE9B0", Slot = "25")]
	public void JLDHACAJGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF10", Offset = "0x7BCCB10", VA = "0x187BCDF10", Slot = "24")]
	public void FAGDFGFBAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD670", Offset = "0x7BCC270", VA = "0x187BCD670", Slot = "33")]
	public void CLPCFJILFHH(Vector3 KPFDANNBDMG, Vector3 DJCOHPBIMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE950", Offset = "0x7BCD550", VA = "0x187BCE950", Slot = "32")]
	public void ILGOOKEKFNJ(Vector3 MDCKKGLAALC, Vector3 GIHMFKNIMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEE50", Offset = "0x7BCDA50", VA = "0x187BCEE50", Slot = "31")]
	public void NJBIANIADOP(Vector3 FJMMHMJJINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEFF0", Offset = "0x7BCDBF0", VA = "0x187BCEFF0", Slot = "22")]
	public void OINNCCJMKIA(HDEBMOKJEII AHLANEMEBKA, Vector3 CLHLJFLAFEF, float IKBHBGJMCJB, float HCNGNGAPDLK = 8f, float ECOAHHAENAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD260", Offset = "0x7BCBE60", VA = "0x187BCD260", Slot = "21")]
	public void CELABFNKMLM(NCBHFGHIKBE KJNADMEBEIF, Vector3 OEFJLLAMMJJ, float NBFMMJGHGJM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD9B0", Offset = "0x7BCC5B0", VA = "0x187BCD9B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ECHEDHBNPAA(NCBHFGHIKBE KJNADMEBEIF, Vector3 APLHHNGOEFP, float ONMPAKODLON = 7f, float LJHKMJLPGFG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x14BC9E0", Offset = "0x14BB5E0", VA = "0x1814BC9E0")]
	private static void HANKIEFPDOH(Vector3 CNPDFOJECOP, Vector3 HKFKAONALCJ, [Out] Vector3 OHIIFHNMIBH, [Out] Vector3 MDNJGEIMEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDE30", Offset = "0x7BCCA30", VA = "0x187BCDE30", Slot = "29")]
	public Vector3 ENJNNDLEPCJ(Vector3 CNPDFOJECOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD4E0", Offset = "0x7BCC0E0", VA = "0x187BCD4E0", Slot = "26")]
	public void CHNJMNIJNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD120", Offset = "0x7BCBD20", VA = "0x187BCD120")]
	private void BLLPPMAJAPN(float MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCBE0", Offset = "0x7BCB7E0", VA = "0x187BCCBE0")]
	private void AIDKCHEADJF(Vector3 OEFJLLAMMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCD010", Offset = "0x7BCBC10", VA = "0x187BCD010")]
	private Vector3 BLIDHDJGFLP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE4D0", Offset = "0x7BCD0D0", VA = "0x187BCE4D0")]
	private void IHPHMHBNEFM(Vector3 CMHAGMHENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0070", Offset = "0x7BCEC70", VA = "0x187BD0070")]
	private Vector3 PPBIGEPBCJB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF640", Offset = "0x7BCE240", VA = "0x187BCF640")]
	private void OKOCGBANCEG(Vector3 MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7BCFAC0", Offset = "0x7BCE6C0", VA = "0x187BCFAC0")]
	private void OOCMMKCJHGH(Vector3 CMHAGMHENKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEAD0", Offset = "0x7BCD6D0", VA = "0x187BCEAD0")]
	private void KFEOPAFFMGK()
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
