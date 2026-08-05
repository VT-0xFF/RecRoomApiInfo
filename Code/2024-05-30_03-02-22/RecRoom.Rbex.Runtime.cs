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
	public class LogRegistrationIndex : NNEIMJEPGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69E32A0", Offset = "0x69E24A0", VA = "0x1869E32A0", Slot = "4")]
		public override void FLGJIGKCNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
	public class _AssemblyIndex : MBJBLHMHHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private JNAIIOKPOLP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x141F5B0", Offset = "0x141E7B0", VA = "0x18141F5B0", Slot = "5")]
		public override void OKGLDPGEPKF(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69F07D0", Offset = "0x69EF9D0", VA = "0x1869F07D0")]
		private void FFEDMEEHEAA(FDHHLBIFCIG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69F0AD0", Offset = "0x69EFCD0", VA = "0x1869F0AD0", Slot = "6")]
		public override void HJJLHAIMLPB(FDHHLBIFCIG registry, [In] DOMKNINMNCP filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "8")]
		public override void EMMAINJNGHI(AICMJOGJDAO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69F0B30", Offset = "0x69EFD30", VA = "0x1869F0B30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, JIFDJNGDNBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LBOEGNBEJHN NPAAFGPOJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DFELNLCCGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MLBMNLCAMKC IHIAHAELDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[MIIJAPCLEGN(LIEGAMPPNDC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MIIJAPCLEGN(LIEGAMPPNDC.SelfAndParent, true, false, false)]
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
		private MGOCMEIHPAH physicsInterpolation;

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
		internal MLBMNLCAMKC HIDDLFOHBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x69EBE90", Offset = "0x69EB090", VA = "0x1869EBE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MLBMNLCAMKC KJCJFJPFCML
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GGLIOEIHAGG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x69EDC40", Offset = "0x69ECE40", VA = "0x1869EDC40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CEEGKNHNDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x69EDFA0", Offset = "0x69ED1A0", VA = "0x1869EDFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LHCGPINMKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69EDEE0", Offset = "0x69ED0E0", VA = "0x1869EDEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BGILIGANMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69EEC40", Offset = "0x69EDE40", VA = "0x1869EEC40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69F0140", Offset = "0x69EF340", VA = "0x1869F0140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform OOIBHIBFMID
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D00", Offset = "0x7F0F00", VA = "0x1807F1D00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KAIPCDOFCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D00", Offset = "0x7F0F00", VA = "0x1807F1D00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HLACIDOJOGN EAELJIAICHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69EDCA0", Offset = "0x69ECEA0", VA = "0x1869EDCA0")]
			get
			{
				return default(HLACIDOJOGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69EF8F0", Offset = "0x69EEAF0", VA = "0x1869EF8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HOAOHAGBBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69EE2B0", Offset = "0x69ED4B0", VA = "0x1869EE2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HEJDBCNPDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69EDDC0", Offset = "0x69ECFC0", VA = "0x1869EDDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HGDEADHMLPB PAEMNMIPHFK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69EE1F0", Offset = "0x69ED3F0", VA = "0x1869EE1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x69EFAB0", Offset = "0x69EECB0", VA = "0x1869EFAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ADACCNNPCMH NHGOIAIBBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69EE190", Offset = "0x69ED390", VA = "0x1869EE190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69EFA40", Offset = "0x69EEC40", VA = "0x1869EFA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ILNPIGNFNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69EE0E0", Offset = "0x69ED2E0", VA = "0x1869EE0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody HKCDHJFADIO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69EE140", Offset = "0x69ED340", VA = "0x1869EE140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JPAFICCGOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69EDE20", Offset = "0x69ED020", VA = "0x1869EDE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x69EF960", Offset = "0x69EEB60", VA = "0x1869EF960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LOOOHCEIAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6157630", Offset = "0x6156830", VA = "0x186157630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KOPNAKBHKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69EEBE0", Offset = "0x69EDDE0", VA = "0x1869EEBE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BNHJIEHFLKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69EEB80", Offset = "0x69EDD80", VA = "0x1869EEB80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69F00D0", Offset = "0x69EF2D0", VA = "0x1869F00D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KGHHNPPMFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69EE510", Offset = "0x69ED710", VA = "0x1869EE510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x69EFD50", Offset = "0x69EEF50", VA = "0x1869EFD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KLBMAGELMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x69EE310", Offset = "0x69ED510", VA = "0x1869EE310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x69EFB20", Offset = "0x69EED20", VA = "0x1869EFB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KKFECHKHJJH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x69EF190", Offset = "0x69EE390", VA = "0x1869EF190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69F0680", Offset = "0x69EF880", VA = "0x1869F0680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 LDFMFHKJMDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x69EE960", Offset = "0x69EDB60", VA = "0x1869EE960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x69EFEA0", Offset = "0x69EF0A0", VA = "0x1869EFEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 OKDJLNLPMCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x69EF2D0", Offset = "0x69EE4D0", VA = "0x1869EF2D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode FEKGKELIANO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69EE450", Offset = "0x69ED650", VA = "0x1869EE450")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x69EFC70", Offset = "0x69EEE70", VA = "0x1869EFC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float CLHNPKJEKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69EDE80", Offset = "0x69ED080", VA = "0x1869EDE80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x69EF9D0", Offset = "0x69EEBD0", VA = "0x1869EF9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints EKIINMPEHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x69EE4B0", Offset = "0x69ED6B0", VA = "0x1869EE4B0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x69EFCE0", Offset = "0x69EEEE0", VA = "0x1869EFCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 GFBIBBCGNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x69EED00", Offset = "0x69EDF00", VA = "0x1869EED00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 BJNAJMEHABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x69EED00", Offset = "0x69EDF00", VA = "0x1869EED00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x69F0460", Offset = "0x69EF660", VA = "0x1869F0460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JHBDJMECJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x69EEA40", Offset = "0x69EDC40", VA = "0x1869EEA40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x69EFF80", Offset = "0x69EF180", VA = "0x1869EFF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MCOIFLBOBBD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x69EF130", Offset = "0x69EE330", VA = "0x1869EF130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x69F0610", Offset = "0x69EF810", VA = "0x1869F0610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion NFFHIBHJAED
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x69EEDE0", Offset = "0x69EDFE0", VA = "0x1869EEDE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x69F01E0", Offset = "0x69EF3E0", VA = "0x1869F01E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BBNIHMHOFKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x69EF060", Offset = "0x69EE260", VA = "0x1869EF060")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69F0540", Offset = "0x69EF740", VA = "0x1869F0540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 OOHCOGOLKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x69EEEB0", Offset = "0x69EE0B0", VA = "0x1869EEEB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x69F02B0", Offset = "0x69EF4B0", VA = "0x1869F02B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GPIKOIOEJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x69EEF90", Offset = "0x69EE190", VA = "0x1869EEF90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x69F0390", Offset = "0x69EF590", VA = "0x1869F0390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 OAFPAEEDKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x69EF1F0", Offset = "0x69EE3F0", VA = "0x1869EF1F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x69F06F0", Offset = "0x69EF8F0", VA = "0x1869F06F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FGFDGBCPILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x69EEAA0", Offset = "0x69EDCA0", VA = "0x1869EEAA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x69EFFF0", Offset = "0x69EF1F0", VA = "0x1869EFFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MELEABFLNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x69EE370", Offset = "0x69ED570", VA = "0x1869EE370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x69EFB90", Offset = "0x69EED90", VA = "0x1869EFB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CBADBDPEHDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x69EE880", Offset = "0x69EDA80", VA = "0x1869EE880")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x69EFDC0", Offset = "0x69EEFC0", VA = "0x1869EFDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EMHOHBOOEKO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x69EE740", Offset = "0x69ED940", VA = "0x1869EE740")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion DLCGJPBMPJE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x69EE670", Offset = "0x69ED870", VA = "0x1869EE670")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 ABFJPHBJAND
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69EF490", Offset = "0x69EE690", VA = "0x1869EF490")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 CEIOOJAAHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69EF3B0", Offset = "0x69EE5B0", VA = "0x1869EF3B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool LONFNJCAPJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x69EE820", Offset = "0x69EDA20", VA = "0x1869EE820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MAOCKBIGHOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x69EE250", Offset = "0x69ED450", VA = "0x1869EE250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DHDLIFDBECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69EDD60", Offset = "0x69ECF60", VA = "0x1869EDD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MIHCFFEIEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x69EDD00", Offset = "0x69ECF00", VA = "0x1869EDD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool JIFBIHHBFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69EDBE0", Offset = "0x69ECDE0", VA = "0x1869EDBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NMHBKFMNOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x69EE570", Offset = "0x69ED770", VA = "0x1869EE570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CABIBPNMJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x54A9330", Offset = "0x54A8530", VA = "0x1854A9330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JCLJMAKIKCG ILCJPFLOAOL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x69EDB00", Offset = "0x69ECD00", VA = "0x1869EDB00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69EF810", Offset = "0x69EEA10", VA = "0x1869EF810")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AJLICCNEBGN HJBGBJDDJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x69ED870", Offset = "0x69ECA70", VA = "0x1869ED870")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x69EF570", Offset = "0x69EE770", VA = "0x1869EF570")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event AJLICCNEBGN ACGNDKIELMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x69ED8D0", Offset = "0x69ECAD0", VA = "0x1869ED8D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69EF5E0", Offset = "0x69EE7E0", VA = "0x1869EF5E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event AJLICCNEBGN LLBODENLJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x69EDA20", Offset = "0x69ECC20", VA = "0x1869EDA20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x69EF730", Offset = "0x69EE930", VA = "0x1869EF730")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<IEIKJHNHGAC, IEIKJHNHGAC> CPBOLKGBPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69ED9B0", Offset = "0x69ECBB0", VA = "0x1869ED9B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69EF6C0", Offset = "0x69EE8C0", VA = "0x1869EF6C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event AJLICCNEBGN BNNNKBHIPOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69EDA90", Offset = "0x69ECC90", VA = "0x1869EDA90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69EF7A0", Offset = "0x69EE9A0", VA = "0x1869EF7A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event AJLICCNEBGN PMPHKJBCEDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x69EDB70", Offset = "0x69ECD70", VA = "0x1869EDB70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x69EF880", Offset = "0x69EEA80", VA = "0x1869EF880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event AJLICCNEBGN EPIBEKDMNGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69ED940", Offset = "0x69ECB40", VA = "0x1869ED940")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69EF650", Offset = "0x69EE850", VA = "0x1869EF650")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90", Slot = "8")]
		private void OOMEHBMLPJM(MLBMNLCAMKC FNFDOEGAMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69EBE00", Offset = "0x69EB000", VA = "0x1869EBE00")]
		internal void BAFLKGNPOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69ED590", Offset = "0x69EC790", VA = "0x1869ED590")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody BEKCENIMBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69EC120", Offset = "0x69EB320", VA = "0x1869EC120")]
		public JIFDJNGDNBF GetChild(int PMNHOLIPOMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69ED200", Offset = "0x69EC400", VA = "0x1869ED200")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) HOGIILJMFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69EBD90", Offset = "0x69EAF90", VA = "0x1869EBD90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69EBE90", Offset = "0x69EB090", VA = "0x1869EBE90")]
		private MLBMNLCAMKC CHMBAKIOIHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69EC3D0", Offset = "0x69EB5D0", VA = "0x1869EC3D0")]
		private void ICOEADAEIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69EC9D0", Offset = "0x69EBBD0", VA = "0x1869EC9D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69EBE00", Offset = "0x69EB000", VA = "0x1869EBE00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69EC970", Offset = "0x69EBB70", VA = "0x1869EC970")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69ECA30", Offset = "0x69EBC30", VA = "0x1869ECA30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69EB380", Offset = "0x69EA580", VA = "0x1869EB380")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69ECA90", Offset = "0x69EBC90", VA = "0x1869ECA90")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69EC0C0", Offset = "0x69EB2C0", VA = "0x1869EC0C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69EC910", Offset = "0x69EBB10", VA = "0x1869EC910")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69ED360", Offset = "0x69EC560", VA = "0x1869ED360")]
		public void SetParent(RigidbodyEx HLCKBKFCMPI, bool KHENNGFPBJA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69ECDA0", Offset = "0x69EBFA0", VA = "0x1869ECDA0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69EC5E0", Offset = "0x69EB7E0", VA = "0x1869EC5E0")]
		public bool IsRigidbodyAncestor(RigidbodyEx OKELAPHKIIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69EC6C0", Offset = "0x69EB8C0", VA = "0x1869EC6C0")]
		public bool IsRigidbodyDescendant(RigidbodyEx FBLBOCAONMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69EB5F0", Offset = "0x69EA7F0", VA = "0x1869EB5F0")]
		public void AddInterpolationRestriction(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69ECB00", Offset = "0x69EBD00", VA = "0x1869ECB00")]
		public void RemoveInterpolationRestriction(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69EB660", Offset = "0x69EA860", VA = "0x1869EB660")]
		public void AddKinematic(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69ECB70", Offset = "0x69EBD70", VA = "0x1869ECB70")]
		public void RemoveKinematic(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69ED2E0", Offset = "0x69EC4E0", VA = "0x1869ED2E0")]
		public void SetKinematic(object CEFPPEHCFCF, bool FBFCNIMNMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69ED100", Offset = "0x69EC300", VA = "0x1869ED100")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LMOBBILKECB, Quaternion LDLNNPHEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69ED000", Offset = "0x69EC200", VA = "0x1869ED000")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 BOALPCHKKBL, Quaternion PMOGLIHDKBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69EC2C0", Offset = "0x69EB4C0", VA = "0x1869EC2C0")]
		public Vector3 GetConstrainedVelocity(Vector3 OAFPAEEDKIL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x69EC1B0", Offset = "0x69EB3B0", VA = "0x1869EC1B0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 MELEABFLNHP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69EB500", Offset = "0x69EA700", VA = "0x1869EB500")]
		public void AddForce(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69EB3F0", Offset = "0x69EA5F0", VA = "0x1869EB3F0")]
		public void AddForceAtPosition(Vector3 LBPGAAMAJKE, Vector3 CAOOPLKANIG, ForceMode KEFPKBHNHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69EB830", Offset = "0x69EAA30", VA = "0x1869EB830")]
		public void AddTorque(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x69EB6D0", Offset = "0x69EA8D0", VA = "0x1869EB6D0")]
		public void AddRelativeTorque(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x69ED660", Offset = "0x69EC860", VA = "0x1869ED660")]
		public Vector3 WorldToLocalVelocity(Vector3 AFMJJPANOMP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69EC800", Offset = "0x69EBA00", VA = "0x1869EC800")]
		public Vector3 LocalToWorldVelocity(Vector3 FGFDGBCPILN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69EC060", Offset = "0x69EB260", VA = "0x1869EC060")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69EC000", Offset = "0x69EB200", VA = "0x1869EC000")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69EBFA0", Offset = "0x69EB1A0", VA = "0x1869EBFA0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69EBF40", Offset = "0x69EB140", VA = "0x1869EBF40")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69ECF00", Offset = "0x69EC100", VA = "0x1869ECF00")]
		public void ResetVelocityWorldSpace(Vector3 JJJBAPONEMM, Vector3 IJOJBCPABEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69ECE00", Offset = "0x69EC000", VA = "0x1869ECE00")]
		public void ResetVelocityLocalSpace(Vector3 NLCAFHPBMBL, Vector3 CBADBDPEHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69ECCC0", Offset = "0x69EBEC0", VA = "0x1869ECCC0")]
		public void ResetLinearVelocityLocalSpace(Vector3 NLCAFHPBMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69ED490", Offset = "0x69EC690", VA = "0x1869ED490")]
		public bool SweepTest(Vector3 GDLGHHBOJHM, [Out] RaycastHit MBAPAGKHAEB, float DLJLDGNAIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69EC7A0", Offset = "0x69EB9A0", VA = "0x1869EC7A0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69ED430", Offset = "0x69EC630", VA = "0x1869ED430")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69ED600", Offset = "0x69EC800", VA = "0x1869ED600")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69EB7C0", Offset = "0x69EA9C0", VA = "0x1869EB7C0")]
		public void AddShouldHaveUnityRigidbodyToken(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69ECBE0", Offset = "0x69EBDE0", VA = "0x1869ECBE0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x69EBBC0", Offset = "0x69EADC0", VA = "0x1869EBBC0")]
		public void ApplyForceVelocityChange(GFDEOLECDKI PDKKCJGKJON, Vector3 BBLCKOPMCNG, float FDFBILKKBBE, float MKNLLALMFAI = 8f, float KOGOLPMGEIH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69EBAC0", Offset = "0x69EACC0", VA = "0x1869EBAC0")]
		public void ApplyAngularVelocityChange(JCMCBMFLILG BFMIDLCNFLF, Vector3 PADGEFFBBON, float PGKGMEEJICP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69EBC80", Offset = "0x69EAE80", VA = "0x1869EBC80")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JCMCBMFLILG BFMIDLCNFLF, Vector3 JCCMNAMJFGM, float JAOCLLEPJKG = 7f, float CIJCOKDJPCK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69EB9F0", Offset = "0x69EABF0", VA = "0x1869EB9F0")]
		public bool AllowedScaleChange(float ONKBHOLJPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x69EB920", Offset = "0x69EAB20", VA = "0x1869EB920")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FJHBOCHLGKB, object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69ECC50", Offset = "0x69EBE50", VA = "0x1869ECC50")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69ED800", Offset = "0x69ECA00", VA = "0x1869ED800")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x891650", Offset = "0x890850", VA = "0x180891650", Slot = "4")]
		private GameObject FDLIIGBHKAJ()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D00", Offset = "0x7F0F00", VA = "0x1807F1D00", Slot = "5")]
		private Transform HNOLBOCJADB()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JDNMDKHBLCL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69DFC70", Offset = "0x69DEE70", VA = "0x1869DFC70")]
	public static MLBMNLCAMKC HIDDLFOHBPP(this RigidbodyEx FIABOAAAKMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NFGMPEFBAIM(typeof(CJLOPNFHCEF), new string[] { })]
public class LLOBFMJPFFE : CJLOPNFHCEF, HMPBIKBKFPG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private MLAHKJBCIOP GFMDIJNCLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ELLKOGGEMIJ BJEABGEEHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EEJCHIGHLGH MKNOJKCIKPE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ELLKOGGEMIJ BNJMLFBBMNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EEJCHIGHLGH ONOAEEKIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69E2480", Offset = "0x69E1680", VA = "0x1869E2480", Slot = "7")]
	public void InitReferences(JGBBAMADHPC NNLNOJIBJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69E2380", Offset = "0x69E1580", VA = "0x1869E2380", Slot = "6")]
	public MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public LLOBFMJPFFE()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static OJHEJHCKNBB UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int EACONFOHEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BGDNDJBPCNO;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69EB1E0", Offset = "0x69EA3E0", VA = "0x1869EB1E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69EB220", Offset = "0x69EA420", VA = "0x1869EB220")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69EB200", Offset = "0x69EA400", VA = "0x1869EB200")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string PPGBBBOBJLN, [Optional] UnityEngine.Object EOIJJPCMNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string PPGBBBOBJLN, [Optional] UnityEngine.Object EOIJJPCMNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69EB330", Offset = "0x69EA530", VA = "0x1869EB330")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EJCBJNFBGDH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AJHCAOAKJJC : HGDEADHMLPB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EA0", Offset = "0x7D80A0", VA = "0x1807D8EA0", Slot = "4")]
		public Vector3 AKPALBGAJLD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8EA0", Offset = "0x7D80A0", VA = "0x1807D8EA0", Slot = "5")]
		public Vector3 EJCJDNGCOPB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AJHCAOAKJJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static HGDEADHMLPB JHMABKAGJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69DB200", Offset = "0x69DA400", VA = "0x1869DB200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HINBMJPPHGA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode OLHKHODMHDP
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
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDHGPBGOANB(bool LONFNJCAPJF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNKMEPPHIAB(bool LONFNJCAPJF);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BBLEMPEKGOP(Vector3 GDLGHHBOJHM, [Out] RaycastHit MBAPAGKHAEB, float DLJLDGNAIFD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BHFCPJLFGBH : IDisposable, FOINJLNNCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HLACIDOJOGN EAELJIAICHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<IEIKJHNHGAC, IEIKJHNHGAC> CPBOLKGBPPH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GENMKELLIEJ();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface EEJCHIGHLGH
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGKNFLEAOHK NJEOICLHBEI(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJHPFJONJFB OHOCIPODNBP(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKJDGPKAIFF HCAJHPPBFFK(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EIBFAKJBPKK KIJBNILGJPJ(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLFANNPNIJN OKNGAGELHLD(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BHFCPJLFGBH APIOFFHPJMP(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CCLILMJPJAE KOOOKIEPCCF(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BPFNEEFLKFD LCOHAPDCEAM(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HINBMJPPHGA IIJMGLCPFBB(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MFKDHKCCJCM IHANLNPLFPO(MLBMNLCAMKC FNFDOEGAMFP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	INOFAABIFLC DKKDAPLGEIF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GDAOADKDPAF CGEIAAEADIK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IIAGEEMDHLO KJJOMLMAEBE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JAKABNCBAIN LBKPKKMEKIE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEAEDMPDGJJ OGMDNOCMIOI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF, CJLOPNFHCEF LJOFMHFOMJI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BPFNEEFLKFD
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCIDKICACAE(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLEGEFDHPLD(Vector3 LBPGAAMAJKE, Vector3 CAOOPLKANIG, ForceMode KEFPKBHNHNL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBFMPPOMLMG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MNBILPCOKHG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MFKDHKCCJCM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool ANNDCPJNOEC
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
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CGKNFLEAOHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<MLBMNLCAMKC> ALOCFGFMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	MLBMNLCAMKC LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event AJLICCNEBGN HJBGBJDDJNN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event AJLICCNEBGN ACGNDKIELMB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JCLJMAKIKCG HNFDIBDHMFG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BBHPMJGAJDP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MJEKHHDBGJJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MLBMNLCAMKC> OFLJBBLAPKD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MLBMNLCAMKC> BGGEOHAEEFE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IHJKHLHIDKA;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MLBMNLCAMKC> PFAPIHCEFGG;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NDMMKDCEAMC(MLBMNLCAMKC KFDAFHAJFEH, bool KHENNGFPBJA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DKJDGPKAIFF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 FAJCEAKEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 IECIKDIFPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FALNLPHIAFF(MLBMNLCAMKC BGILIGANMHA, object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHHPLKKPCDB(object CEFPPEHCFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JAKABNCBAIN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DNFOLPHPADO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 BGJFBCMDJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float GBEJFLLHBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float CJALDMPNNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 LEMDFFDMIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion PBEMDKEHNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event AJLICCNEBGN MCBCIFHMPIK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KMPMDCIKOCD((Quaternion rot, Vector3 moments) HOGIILJMFNM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MEMNDDBKPBK();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPDDLMJMCOA();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CPDCLMMKGOM();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HLKCDMOBFPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IIAGEEMDHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIKAKGMHIAA(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGJDLCAHDBI(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNEEBOEJLGG(MLBMNLCAMKC FIABOAAAKMM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFGLOBIFOFN(MLBMNLCAMKC FIABOAAAKMM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJCCCKCAIMK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CCLILMJPJAE
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool NAKOAPFAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event AJLICCNEBGN GEOLLDMFHDC;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEJPDILMIBL(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KANKOMFMBOD(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPDCEJFENKH(object CEFPPEHCFCF, bool FBFCNIMNMCH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADBPPACPBLH(Rigidbody NCIFAJPFOJP);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GDAOADKDPAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HOAOHAGBBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HEJDBCNPDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event AJLICCNEBGN PAIFKHNNABM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGCONMEGJJD(MLBMNLCAMKC BGILIGANMHA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGOLNCCFEIO(MLBMNLCAMKC BGILIGANMHA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IEAEDMPDGJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JPAFICCGOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool KFCOLDHIDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints MGBDMOMNEAD
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
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EIBFAKJBPKK
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float NCLNCILOJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float HLOFEGMDDPH
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
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JLFANNPNIJN
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event AJLICCNEBGN JAKODDHNACF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IMDPPCPMHKN();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOGIKHHBCBH();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDNJLABBBKN();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONNEJMLPGDD();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PPALGMNDKAC();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface INOFAABIFLC
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool HBAPLIIFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HABHNOOKKKB(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ENDPKLCJOGC(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLDDOKBOEJI();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHFNIJLOAIG();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CJHPFJONJFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	HGDEADHMLPB PAEMNMIPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	ADACCNNPCMH NHGOIAIBBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 PFKDBCAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 BJEPGMCEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MPOGMCLMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 OKJJBAPADJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float CLHNPKJEKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool ILNPIGNFNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GENMKELLIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BMMKCICEKPL(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ALIEEIAANFJ(JCMCBMFLILG BFMIDLCNFLF, Vector3 PADGEFFBBON, float PGKGMEEJICP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LAFFEJBOCJB(GFDEOLECDKI PDKKCJGKJON, Vector3 BBLCKOPMCNG, float FDFBILKKBBE, float MKNLLALMFAI = 8f, float KOGOLPMGEIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HLMADCNFDJO(JCMCBMFLILG BFMIDLCNFLF, Vector3 JCCMNAMJFGM, float JAOCLLEPJKG = 7f, float CIJCOKDJPCK = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PAOJHICNPLG();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AHDMJDPBIAO();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LMIPMOKCPOD();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HDPLKKMDNPD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ADBPPACPBLH(Rigidbody IOIJBGDBPEN);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NCPGDGBHEKB(Vector3 OAFPAEEDKIL);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ENMIDCPJMCD(object CEFPPEHCFCF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IEKNJPPHKKM(Vector3 EHKJBKDMPFH);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MLPLNPGBJBG(Vector3 NLCAFHPBMBL, Vector3 CBADBDPEHDG);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JIBBKGEAECD(Vector3 JJJBAPONEMM, Vector3 IJOJBCPABEP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KBECBHDFLBL(Vector3 FGFDGBCPILN);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 GAHFGNCCNEI(Vector3 AFMJJPANOMP);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface ELLKOGGEMIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NDAPDKELNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBHKHNDBEPF(string KFNIFKKFLAO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGGIMDPLGCH(RigidbodyEx FIABOAAAKMM, Action BGMBJALDBDD);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CJELFLNLFHN HAJILPDGFPK(int LECFLFJNIHF);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHECCOJFFKO(Vector3 OKDJLNLPMCM, float MNEDOKHCGCA, Color LHAAJEOMGEG);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJHHDEPHJLP();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFNECKMFGFE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FNBGDBIFOLG(OLEKGNKHMMB.Application)]
public interface CJLOPNFHCEF
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	ELLKOGGEMIJ BNJMLFBBMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	EEJCHIGHLGH ONOAEEKIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EHAPKFOGFHF : MLBMNLCAMKC, IDisposable, IANJAOACEII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly CJLOPNFHCEF LJOFMHFOMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal CGKNFLEAOHK JCLPMKKELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal IIAGEEMDHLO OPIDJLNNPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal GDAOADKDPAF HGIFPHKBPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal CJHPFJONJFB OAFPAEEDKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DKJDGPKAIFF IHEMCCILEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JAKABNCBAIN DOPFENAJKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EIBFAKJBPKK NHEAFMEADAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MFKDHKCCJCM MJIMKNAHILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal JLFANNPNIJN AOPKEDAAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal BHFCPJLFGBH MBNICEHPDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CCLILMJPJAE HKBJHGOAALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal BPFNEEFLKFD LBPGAAMAJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal IEAEDMPDGJJ CHBGBOJFAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal INOFAABIFLC IOIJBGDBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal HINBMJPPHGA NNEGEPEKILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable FGEKLOKNGKA;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NKJBKLODBOM NIMFNJAPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "22")]
		get
		{
			return default(NKJBKLODBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JIFDJNGDNBF LGFACAOBOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7D2440", Offset = "0x7D1640", VA = "0x1807D2440", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2300", Offset = "0x7D1500", VA = "0x1807D2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject ABFNCMAFNND
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x919320", Offset = "0x918520", VA = "0x180919320", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x919440", Offset = "0x918640", VA = "0x180919440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x69D5F90", Offset = "0x69D5190", VA = "0x1869D5F90", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x69D9D00", Offset = "0x69D8F00", VA = "0x1869D9D00", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x69D4FE0", Offset = "0x69D41E0", VA = "0x1869D4FE0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x69D67F0", Offset = "0x69D59F0", VA = "0x1869D67F0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int GGLIOEIHAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x69D8820", Offset = "0x69D7A20", VA = "0x1869D8820", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MLBMNLCAMKC LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x69D6E80", Offset = "0x69D6080", VA = "0x1869D6E80", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool FMPMOALNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x69D5D30", Offset = "0x69D4F30", VA = "0x1869D5D30", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool HOAOHAGBBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x69D6090", Offset = "0x69D5290", VA = "0x1869D6090", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HEJDBCNPDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x69D69C0", Offset = "0x69D5BC0", VA = "0x1869D69C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HGDEADHMLPB PAEMNMIPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x69D6FB0", Offset = "0x69D61B0", VA = "0x1869D6FB0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x69D5470", Offset = "0x69D4670", VA = "0x1869D5470", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public ADACCNNPCMH NHGOIAIBBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7410", Offset = "0x69D6610", VA = "0x1869D7410", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7150", Offset = "0x69D6350", VA = "0x1869D7150", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float CLHNPKJEKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x69D5030", Offset = "0x69D4230", VA = "0x1869D5030", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x69D89F0", Offset = "0x69D7BF0", VA = "0x1869D89F0", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 BJEPGMCEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x69D5270", Offset = "0x69D4470", VA = "0x1869D5270", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x69D8570", Offset = "0x69D7770", VA = "0x1869D8570", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 OKJJBAPADJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x69D8FC0", Offset = "0x69D81C0", VA = "0x1869D8FC0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x69D94C0", Offset = "0x69D86C0", VA = "0x1869D94C0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PFKDBCAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x69D5DE0", Offset = "0x69D4FE0", VA = "0x1869D5DE0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x69D7330", Offset = "0x69D6530", VA = "0x1869D7330", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MPOGMCLMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x69D5A40", Offset = "0x69D4C40", VA = "0x1869D5A40", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x69D9830", Offset = "0x69D8A30", VA = "0x1869D9830", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool DHDLIFDBECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x69D6E30", Offset = "0x69D6030", VA = "0x1869D6E30", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool MIHCFFEIEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x69D61E0", Offset = "0x69D53E0", VA = "0x1869D61E0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JIFBIHHBFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x69D8120", Offset = "0x69D7320", VA = "0x1869D8120", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool ILNPIGNFNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x69DA610", Offset = "0x69D9810", VA = "0x1869DA610", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 FAJCEAKEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x69D7CE0", Offset = "0x69D6EE0", VA = "0x1869D7CE0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 IECIKDIFPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x69D7070", Offset = "0x69D6270", VA = "0x1869D7070", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 DNFOLPHPADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x69D7F10", Offset = "0x69D7110", VA = "0x1869D7F10", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x69D8330", Offset = "0x69D7530", VA = "0x1869D8330", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 BGJFBCMDJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x69D5820", Offset = "0x69D4A20", VA = "0x1869D5820", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float GBEJFLLHBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x69D7760", Offset = "0x69D6960", VA = "0x1869D7760", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float CJALDMPNNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x69D8070", Offset = "0x69D7270", VA = "0x1869D8070", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x69D6790", Offset = "0x69D5990", VA = "0x1869D6790", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 LEMDFFDMIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x69D5080", Offset = "0x69D4280", VA = "0x1869D5080", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion PBEMDKEHNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x69DA540", Offset = "0x69D9740", VA = "0x1869DA540", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float NCLNCILOJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x69DA360", Offset = "0x69D9560", VA = "0x1869DA360", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x69D8760", Offset = "0x69D7960", VA = "0x1869D8760", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float HLOFEGMDDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x69D8710", Offset = "0x69D7910", VA = "0x1869D8710", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x69D5950", Offset = "0x69D4B50", VA = "0x1869D5950", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool ANNDCPJNOEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x69D8200", Offset = "0x69D7400", VA = "0x1869D8200", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x69D53B0", Offset = "0x69D45B0", VA = "0x1869D53B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HLACIDOJOGN EAELJIAICHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x69D8A50", Offset = "0x69D7C50", VA = "0x1869D8A50", Slot = "68")]
		get
		{
			return default(HLACIDOJOGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x69D8930", Offset = "0x69D7B30", VA = "0x1869D8930", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NAKOAPFAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x69D8890", Offset = "0x69D7A90", VA = "0x1869D8890", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform KAIPCDOFCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x69D6080", Offset = "0x69D5280", VA = "0x1869D6080", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 MHPPJPHAOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x69D6A60", Offset = "0x69D5C60", VA = "0x1869D6A60", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x69D7560", Offset = "0x69D6760", VA = "0x1869D7560", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float HGONEJLKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x69D5A20", Offset = "0x69D4C20", VA = "0x1869D5A20", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C10", Offset = "0x69D7E10", VA = "0x1869D8C10", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float AECLGOKMGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x69D94A0", Offset = "0x69D86A0", VA = "0x1869D94A0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x69D5C30", Offset = "0x69D4E30", VA = "0x1869D5C30", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HGAAFJGFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x69D9670", Offset = "0x69D8870", VA = "0x1869D9670", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x69D6640", Offset = "0x69D5840", VA = "0x1869D6640", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 IKDGFFADEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x69D5900", Offset = "0x69D4B00", VA = "0x1869D5900", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x69D6850", Offset = "0x69D5A50", VA = "0x1869D6850", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MBPJHPHFEML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x69D9910", Offset = "0x69D8B10", VA = "0x1869D9910", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x69D60E0", Offset = "0x69D52E0", VA = "0x1869D60E0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints MGBDMOMNEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x69D6240", Offset = "0x69D5440", VA = "0x1869D6240", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x69D8CE0", Offset = "0x69D7EE0", VA = "0x1869D8CE0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool JPAFICCGOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x69D68A0", Offset = "0x69D5AA0", VA = "0x1869D68A0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x69D54D0", Offset = "0x69D46D0", VA = "0x1869D54D0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode OLHKHODMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x69D77B0", Offset = "0x69D69B0", VA = "0x1869D77B0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x69D92D0", Offset = "0x69D84D0", VA = "0x1869D92D0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool EFIGICGIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x69D7620", Offset = "0x69D6820", VA = "0x1869D7620", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool MAOCKBIGHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x69D9D50", Offset = "0x69D8F50", VA = "0x1869D9D50", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event AJLICCNEBGN HJBGBJDDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x69DA2A0", Offset = "0x69D94A0", VA = "0x1869DA2A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x69D8BB0", Offset = "0x69D7DB0", VA = "0x1869D8BB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event AJLICCNEBGN ACGNDKIELMB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x69D5350", Offset = "0x69D4550", VA = "0x1869D5350", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x69D87C0", Offset = "0x69D79C0", VA = "0x1869D87C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JCLJMAKIKCG HNFDIBDHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x69DA300", Offset = "0x69D9500", VA = "0x1869DA300", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x69D6180", Offset = "0x69D5380", VA = "0x1869D6180", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event AJLICCNEBGN PAIFKHNNABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x69D5B80", Offset = "0x69D4D80", VA = "0x1869D5B80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x69D4C40", Offset = "0x69D3E40", VA = "0x1869D4C40", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event AJLICCNEBGN LLBODENLJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x69D6020", Offset = "0x69D5220", VA = "0x1869D6020", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x69D4DA0", Offset = "0x69D3FA0", VA = "0x1869D4DA0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event AJLICCNEBGN JAKODDHNACF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x69D9ED0", Offset = "0x69D90D0", VA = "0x1869D9ED0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x69D7800", Offset = "0x69D6A00", VA = "0x1869D7800", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<IEIKJHNHGAC, IEIKJHNHGAC> CPBOLKGBPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x69D6DD0", Offset = "0x69D5FD0", VA = "0x1869D6DD0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x69D8C80", Offset = "0x69D7E80", VA = "0x1869D8C80", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event AJLICCNEBGN GEOLLDMFHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x69D80C0", Offset = "0x69D72C0", VA = "0x1869D80C0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x69D8AA0", Offset = "0x69D7CA0", VA = "0x1869D8AA0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event AJLICCNEBGN EPIBEKDMNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x69D8F10", Offset = "0x69D8110", VA = "0x1869D8F10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x69D6B10", Offset = "0x69D5D10", VA = "0x1869D6B10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x69DAA10", Offset = "0x69D9C10", VA = "0x1869DAA10")]
	public EHAPKFOGFHF(GameObject IIDBEBHLIGH, RigidbodyEx GJMGGHAOBCA, CJLOPNFHCEF LJOFMHFOMJI, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x69D5530", Offset = "0x69D4730", VA = "0x1869D5530", Slot = "136")]
	protected virtual void BOOEIKFHMEG(CJLOPNFHCEF LJOFMHFOMJI, KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x69D5EC0", Offset = "0x69D50C0", VA = "0x1869D5EC0", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x69D6500", Offset = "0x69D5700", VA = "0x1869D6500", Slot = "91")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A10", Offset = "0x69D5C10", VA = "0x1869D6A10", Slot = "92")]
	public void JOBLCGKNBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x69D7000", Offset = "0x69D6200", VA = "0x1869D7000", Slot = "93")]
	public void IICMOCFDDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x69D6BC0", Offset = "0x69D5DC0", VA = "0x1869D6BC0")]
	private void HLFNFEDAPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x69D7FF0", Offset = "0x69D71F0", VA = "0x1869D7FF0", Slot = "30")]
	public MLBMNLCAMKC KBOMDFOMOPE(int PMNHOLIPOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x69D9430", Offset = "0x69D8630", VA = "0x1869D9430", Slot = "95")]
	public void NDMMKDCEAMC(MLBMNLCAMKC HLCKBKFCMPI, bool KHENNGFPBJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x69D5410", Offset = "0x69D4610", VA = "0x1869D5410", Slot = "96")]
	public void BKLGBNGLILO(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x69D8B00", Offset = "0x69D7D00", VA = "0x1869D8B00", Slot = "97")]
	public void MEACGFOKMIK(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x69D6290", Offset = "0x69D5490", VA = "0x1869D6290", Slot = "98")]
	public Vector3 GAHFGNCCNEI(Vector3 AFMJJPANOMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x69D7E10", Offset = "0x69D7010", VA = "0x1869D7E10", Slot = "99")]
	public Vector3 KBECBHDFLBL(Vector3 FGFDGBCPILN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x69D6A10", Offset = "0x69D5C10", VA = "0x1869D6A10", Slot = "100")]
	public void HDPLKKMDNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x69D4A00", Offset = "0x69D3C00", VA = "0x1869D4A00", Slot = "101")]
	public void AHDMJDPBIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x69DA3B0", Offset = "0x69D95B0", VA = "0x1869DA3B0", Slot = "102")]
	public void PAOJHICNPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69D7930", Offset = "0x69D6B30", VA = "0x1869D7930", Slot = "103")]
	public void JIBBKGEAECD(Vector3 JJJBAPONEMM, Vector3 IJOJBCPABEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x69D8D40", Offset = "0x69D7F40", VA = "0x1869D8D40", Slot = "104")]
	public void MLPLNPGBJBG(Vector3 NLCAFHPBMBL, Vector3 CBADBDPEHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x69D6ED0", Offset = "0x69D60D0", VA = "0x1869D6ED0", Slot = "105")]
	public void IEKNJPPHKKM(Vector3 EHKJBKDMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x69D8650", Offset = "0x69D7850", VA = "0x1869D8650", Slot = "106")]
	public void LAFFEJBOCJB(GFDEOLECDKI PDKKCJGKJON, Vector3 BBLCKOPMCNG, float FDFBILKKBBE, float MKNLLALMFAI = 8f, float KOGOLPMGEIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x69D4CA0", Offset = "0x69D3EA0", VA = "0x1869D4CA0", Slot = "107")]
	public void ALIEEIAANFJ(JCMCBMFLILG BFMIDLCNFLF, Vector3 PADGEFFBBON, float PGKGMEEJICP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x69D6CC0", Offset = "0x69D5EC0", VA = "0x1869D6CC0", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLMADCNFDJO(JCMCBMFLILG BFMIDLCNFLF, Vector3 JCCMNAMJFGM, float JAOCLLEPJKG = 7f, float CIJCOKDJPCK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x69D9330", Offset = "0x69D8530", VA = "0x1869D9330", Slot = "109")]
	public Vector3 NCPGDGBHEKB(Vector3 HLCKBKFCMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x69D4900", Offset = "0x69D3B00", VA = "0x1869D4900", Slot = "110")]
	public Vector3 AEFNPINOLPP(Vector3 HLCKBKFCMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x69D88E0", Offset = "0x69D7AE0", VA = "0x1869D88E0", Slot = "111")]
	public void LMIPMOKCPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x69D59B0", Offset = "0x69D4BB0", VA = "0x1869D59B0", Slot = "112")]
	public void CFKOPIEACGH(MLBMNLCAMKC FJHBOCHLGKB, object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x69D8990", Offset = "0x69D7B90", VA = "0x1869D8990", Slot = "113")]
	public void LNFMIFDCAHO(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D8250", Offset = "0x69D7450", VA = "0x1869D8250", Slot = "61")]
	public void KMPMDCIKOCD((Quaternion rot, Vector3 moments) HOGIILJMFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x69D8410", Offset = "0x69D7610", VA = "0x1869D8410", Slot = "114")]
	public void KPDDLMJMCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x69D8B60", Offset = "0x69D7D60", VA = "0x1869D8B60", Slot = "115")]
	public void MEMNDDBKPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5BE0", Offset = "0x69D4DE0", VA = "0x1869D5BE0", Slot = "116")]
	public void CPDCLMMKGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x69D7020", Offset = "0x69D6220", VA = "0x1869D7020", Slot = "117")]
	public bool IMDPPCPMHKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x69D5D90", Offset = "0x69D4F90", VA = "0x1869D5D90", Slot = "94")]
	public void DDNJLABBBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x69DA980", Offset = "0x69D9B80", VA = "0x1869DA980", Slot = "118")]
	public void PPALGMNDKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x69DA400", Offset = "0x69D9600", VA = "0x1869DA400", Slot = "119")]
	public void PEJPDILMIBL(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x69D7DB0", Offset = "0x69D6FB0", VA = "0x1869D7DB0", Slot = "120")]
	public void KANKOMFMBOD(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x69D68F0", Offset = "0x69D5AF0", VA = "0x1869D68F0", Slot = "121")]
	public void GPDCEJFENKH(object CEFPPEHCFCF, bool FBFCNIMNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x69D7AE0", Offset = "0x69D6CE0", VA = "0x1869D7AE0", Slot = "122")]
	public void JLAOEDDFNBO(Vector3 LMOBBILKECB, Quaternion LDLNNPHEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x69D90A0", Offset = "0x69D82A0", VA = "0x1869D90A0", Slot = "123")]
	public void MPLGNHELLDA(Vector3 BOALPCHKKBL, Quaternion PMOGLIHDKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x69D5B20", Offset = "0x69D4D20", VA = "0x1869D5B20", Slot = "124")]
	public bool CKFHMCFEMKA(float ONKBHOLJPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x69D5160", Offset = "0x69D4360", VA = "0x1869D5160", Slot = "125")]
	public void BGIHIOEEFNM(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x69D6730", Offset = "0x69D5930", VA = "0x1869D6730", Slot = "126")]
	public void GJFNAJLEKPJ(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x69D6960", Offset = "0x69D5B60", VA = "0x1869D6960", Slot = "127")]
	public void HABHNOOKKKB(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x69D6120", Offset = "0x69D5320", VA = "0x1869D6120", Slot = "128")]
	public void ENDPKLCJOGC(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x69D4F00", Offset = "0x69D4100", VA = "0x1869D4F00", Slot = "129")]
	public void BCIDKICACAE(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x69D9720", Offset = "0x69D8920", VA = "0x1869D9720", Slot = "130")]
	public void NLEGEFDHPLD(Vector3 LBPGAAMAJKE, Vector3 CAOOPLKANIG, ForceMode KEFPKBHNHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x69D91F0", Offset = "0x69D83F0", VA = "0x1869D91F0", Slot = "131")]
	public void NBFMPPOMLMG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x69D8E30", Offset = "0x69D8030", VA = "0x1869D8E30", Slot = "132")]
	public void MNBILPCOKHG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x69D4E00", Offset = "0x69D4000", VA = "0x1869D4E00", Slot = "133")]
	public bool BBLEMPEKGOP(Vector3 GDLGHHBOJHM, [Out] RaycastHit MBAPAGKHAEB, float DLJLDGNAIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x69D6C70", Offset = "0x69D5E70", VA = "0x1869D6C70", Slot = "134")]
	public void HLKCDMOBFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69DA9D0", Offset = "0x69D9BD0", VA = "0x1869DA9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69DA460", Offset = "0x69D9660", VA = "0x1869DA460")]
	private void PGCDPFCOLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69D8460", Offset = "0x69D7660", VA = "0x1869D8460")]
	private void KPLPCONAMFG(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x69D4A50", Offset = "0x69D3C50", VA = "0x1869D4A50")]
	private void AIDHNFDFDFO(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x69D51C0", Offset = "0x69D43C0", VA = "0x1869D51C0")]
	private void BHOJGMINONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D7460", Offset = "0x69D6660", VA = "0x1869D7460")]
	private void JBAEACHMMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69D71B0", Offset = "0x69D63B0", VA = "0x1869D71B0")]
	private void IMPGFBHFJEF(MLBMNLCAMKC EEFLIDEPHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D95A0", Offset = "0x69D87A0", VA = "0x1869D95A0")]
	private void NGCONMEGJJD(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69D7860", Offset = "0x69D6A60", VA = "0x1869D7860")]
	private void JGOLNCCFEIO(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69D6390", Offset = "0x69D5590", VA = "0x1869D6390")]
	private void GAJNNMEPDJE(JIFDJNGDNBF BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69D9950", Offset = "0x69D8B50", VA = "0x1869D9950", Slot = "141")]
	protected virtual void NOADDNELLPI(JIFDJNGDNBF FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69DA660", Offset = "0x69D9860", VA = "0x1869DA660")]
	protected void PIPOOABKFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D9F30", Offset = "0x69D9130", VA = "0x1869D9F30")]
	protected void OGCMOHDPNNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x69D7A20", Offset = "0x69D6C20", VA = "0x1869D7A20", Slot = "142")]
	protected virtual IDisposable JKBGKHOAIAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class MAAOPLLPJNP
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69E3540", Offset = "0x69E2740", VA = "0x1869E3540")]
	public static MLBMNLCAMKC PCJLJNBAKKK(this MLBMNLCAMKC FIABOAAAKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69E3470", Offset = "0x69E2670", VA = "0x1869E3470")]
	public static bool BLMFLHFMIGE(this MLBMNLCAMKC FIABOAAAKMM, MLBMNLCAMKC OKELAPHKIIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69E33F0", Offset = "0x69E25F0", VA = "0x1869E33F0")]
	public static bool BBPGAHLPLLJ(this MLBMNLCAMKC FIABOAAAKMM, MLBMNLCAMKC FBLBOCAONMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69E34F0", Offset = "0x69E26F0", VA = "0x1869E34F0")]
	public static JIFDJNGDNBF JIAHNFPIHPN(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69E3370", Offset = "0x69E2570", VA = "0x1869E3370")]
	public static EHAPKFOGFHF BAIKHKCFEKF(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GCMEPEOFBCB : EEJCHIGHLGH
{
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x69DB2D0", Offset = "0x69DA4D0", VA = "0x1869DB2D0", Slot = "19")]
	public MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF, CJLOPNFHCEF LJOFMHFOMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "4")]
	public CGKNFLEAOHK NJEOICLHBEI(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "5")]
	public CJHPFJONJFB OHOCIPODNBP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "6")]
	public DKJDGPKAIFF HCAJHPPBFFK(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "7")]
	public EIBFAKJBPKK KIJBNILGJPJ(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "8")]
	public JLFANNPNIJN OKNGAGELHLD(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "9")]
	public BHFCPJLFGBH APIOFFHPJMP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "10")]
	public CCLILMJPJAE KOOOKIEPCCF(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "11")]
	public BPFNEEFLKFD LCOHAPDCEAM(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "12")]
	public HINBMJPPHGA IIJMGLCPFBB(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "13")]
	public MFKDHKCCJCM IHANLNPLFPO(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	public INOFAABIFLC DKKDAPLGEIF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	public GDAOADKDPAF CGEIAAEADIK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	public IIAGEEMDHLO KJJOMLMAEBE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	public JAKABNCBAIN LBKPKKMEKIE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	public IEAEDMPDGJJ OGMDNOCMIOI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GCMEPEOFBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "14")]
	private INOFAABIFLC DEEHEHOALPF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "15")]
	private GDAOADKDPAF MOEGDAHNGGO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "16")]
	private IIAGEEMDHLO PCDDPGGCKFI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "17")]
	private JAKABNCBAIN GMBELEFOPBK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "18")]
	private IEAEDMPDGJJ ABDFPFBCMBO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[NFGMPEFBAIM(typeof(EEJCHIGHLGH), new string[] { })]
public class NDCMFAJOICL : EEJCHIGHLGH, HMPBIKBKFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly EEJCHIGHLGH MNKKLOJKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly EEJCHIGHLGH AOOCIDGAOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MLAHKJBCIOP GFMDIJNCLKB;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private EEJCHIGHLGH ONOAEEKIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x69E5C70", Offset = "0x69E4E70", VA = "0x1869E5C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x69E5E10", Offset = "0x69E5010", VA = "0x1869E5E10", Slot = "20")]
	public void InitReferences(JGBBAMADHPC NNLNOJIBJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x69E60F0", Offset = "0x69E52F0", VA = "0x1869E60F0", Slot = "4")]
	public CGKNFLEAOHK NJEOICLHBEI(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x69E6190", Offset = "0x69E5390", VA = "0x1869E6190", Slot = "5")]
	public CJHPFJONJFB OHOCIPODNBP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x69E5BD0", Offset = "0x69E4DD0", VA = "0x1869E5BD0", Slot = "6")]
	public DKJDGPKAIFF HCAJHPPBFFK(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x69E5E60", Offset = "0x69E5060", VA = "0x1869E5E60", Slot = "7")]
	public EIBFAKJBPKK KIJBNILGJPJ(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x69E6230", Offset = "0x69E5430", VA = "0x1869E6230", Slot = "8")]
	public JLFANNPNIJN OKNGAGELHLD(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x69E57D0", Offset = "0x69E49D0", VA = "0x1869E57D0", Slot = "9")]
	public BHFCPJLFGBH APIOFFHPJMP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x69E5FB0", Offset = "0x69E51B0", VA = "0x1869E5FB0", Slot = "10")]
	public CCLILMJPJAE KOOOKIEPCCF(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x69E6050", Offset = "0x69E5250", VA = "0x1869E6050", Slot = "11")]
	public BPFNEEFLKFD LCOHAPDCEAM(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x69E5D70", Offset = "0x69E4F70", VA = "0x1869E5D70", Slot = "12")]
	public HINBMJPPHGA IIJMGLCPFBB(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x69E5CD0", Offset = "0x69E4ED0", VA = "0x1869E5CD0", Slot = "13")]
	public MFKDHKCCJCM IHANLNPLFPO(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x69E5920", Offset = "0x69E4B20", VA = "0x1869E5920")]
	public INOFAABIFLC DKKDAPLGEIF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x69E5870", Offset = "0x69E4A70", VA = "0x1869E5870")]
	public GDAOADKDPAF CGEIAAEADIK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x69E5F00", Offset = "0x69E5100", VA = "0x1869E5F00")]
	public IIAGEEMDHLO KJJOMLMAEBE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x69E5B20", Offset = "0x69E4D20", VA = "0x1869E5B20")]
	public JAKABNCBAIN LBKPKKMEKIE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x69E5720", Offset = "0x69E4920", VA = "0x1869E5720")]
	public IEAEDMPDGJJ OGMDNOCMIOI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x69E59D0", Offset = "0x69E4BD0", VA = "0x1869E59D0", Slot = "19")]
	public MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF, CJLOPNFHCEF LJOFMHFOMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x69E62D0", Offset = "0x69E54D0", VA = "0x1869E62D0")]
	public NDCMFAJOICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x69E5920", Offset = "0x69E4B20", VA = "0x1869E5920", Slot = "14")]
	private INOFAABIFLC DEEHEHOALPF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x69E5870", Offset = "0x69E4A70", VA = "0x1869E5870", Slot = "15")]
	private GDAOADKDPAF MOEGDAHNGGO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x69E5F00", Offset = "0x69E5100", VA = "0x1869E5F00", Slot = "16")]
	private IIAGEEMDHLO PCDDPGGCKFI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x69E5B20", Offset = "0x69E4D20", VA = "0x1869E5B20", Slot = "17")]
	private JAKABNCBAIN GMBELEFOPBK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x69E5720", Offset = "0x69E4920", VA = "0x1869E5720", Slot = "18")]
	private IEAEDMPDGJJ ABDFPFBCMBO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HMJANEJHBNM : CGKNFLEAOHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDOMKOPCCKF(MLBMNLCAMKC FIABOAAAKMM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNAPFILCBHP(MLBMNLCAMKC FIABOAAAKMM);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDHNIEFPEBM(MLBMNLCAMKC EEFLIDEPHEH);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GADGEOCCOMK(MLBMNLCAMKC EEFLIDEPHEH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HGMGOFLMABF : DKJDGPKAIFF
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	GAPNAMDEEEN<MLBMNLCAMKC> MPGNCDKJGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	MLBMNLCAMKC BAOPPGMKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GPAPEJMKLMN : JAKABNCBAIN
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KKNJMMNGIJE(Rigidbody KBNBJGLLEOP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FJGGMMMFMLP : GDAOADKDPAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView PJODKKOKLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class LGGGPGHAKJO : HINBMJPPHGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode MIEBMAGPBNF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x69DFB90", Offset = "0x69DED90", VA = "0x1869DFB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode OLHKHODMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x69E1290", Offset = "0x69E0490", VA = "0x1869E1290", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x69E13B0", Offset = "0x69E05B0", VA = "0x1869E13B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x69DFBE0", Offset = "0x69DEDE0", VA = "0x1869DFBE0")]
	public LGGGPGHAKJO(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x69E1180", Offset = "0x69E0380", VA = "0x1869E1180", Slot = "6")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x69E0F90", Offset = "0x69E0190", VA = "0x1869E0F90", Slot = "9")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x69E1170", Offset = "0x69E0370", VA = "0x1869E1170", Slot = "7")]
	public void FDHGPBGOANB(bool LONFNJCAPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x69E13A0", Offset = "0x69E05A0", VA = "0x1869E13A0", Slot = "8")]
	public void KNKMEPPHIAB(bool LONFNJCAPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x69E1010", Offset = "0x69E0210", VA = "0x1869E1010", Slot = "10")]
	public bool BBLEMPEKGOP(Vector3 GDLGHHBOJHM, [Out] RaycastHit MBAPAGKHAEB, float DLJLDGNAIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x69E1420", Offset = "0x69E0620", VA = "0x1869E1420")]
	private void NCLBBAEHDMB(bool LONFNJCAPJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ODPGIOKIOMP : BHFCPJLFGBH, IDisposable, FOINJLNNCBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HLACIDOJOGN POFLCPFILKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CJELFLNLFHN KAALDMGHBEH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HLACIDOJOGN EAELJIAICHG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x69E7590", Offset = "0x69E6790", VA = "0x1869E7590", Slot = "6")]
		get
		{
			return default(HLACIDOJOGN);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x69E74C0", Offset = "0x69E66C0", VA = "0x1869E74C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform GHKJCCENOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x69E7130", Offset = "0x69E6330", VA = "0x1869E7130", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IEIKJHNHGAC, IEIKJHNHGAC> CPBOLKGBPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x69E7410", Offset = "0x69E6610", VA = "0x1869E7410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x69E76E0", Offset = "0x69E68E0", VA = "0x1869E76E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x69E7790", Offset = "0x69E6990", VA = "0x1869E7790")]
	public ODPGIOKIOMP(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x69E71A0", Offset = "0x69E63A0", VA = "0x1869E71A0", Slot = "8")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x69E7150", Offset = "0x69E6350", VA = "0x1869E7150", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8C9280", Offset = "0x8C8480", VA = "0x1808C9280", Slot = "11")]
	private void MCGOAAAGJCF(IEIKJHNHGAC DMFJEJONEHK, IEIKJHNHGAC JLJIKMDBAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "12")]
	private void PBPOIEBJALF(bool NPGCEAJJJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KLDBMGOMKFB : EEJCHIGHLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x69E0CA0", Offset = "0x69DFEA0", VA = "0x1869E0CA0", Slot = "4")]
	public CGKNFLEAOHK NJEOICLHBEI(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x69E0D90", Offset = "0x69DFF90", VA = "0x1869E0D90", Slot = "5")]
	public CJHPFJONJFB OHOCIPODNBP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x69E0660", Offset = "0x69DF860", VA = "0x1869E0660", Slot = "6")]
	public DKJDGPKAIFF HCAJHPPBFFK(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x69E0910", Offset = "0x69DFB10", VA = "0x1869E0910", Slot = "7")]
	public EIBFAKJBPKK KIJBNILGJPJ(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x69E0EC0", Offset = "0x69E00C0", VA = "0x1869E0EC0", Slot = "8")]
	public JLFANNPNIJN OKNGAGELHLD(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x69E0000", Offset = "0x69DF200", VA = "0x1869E0000", Slot = "9")]
	public BHFCPJLFGBH APIOFFHPJMP(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x69E0AC0", Offset = "0x69DFCC0", VA = "0x1869E0AC0", Slot = "10")]
	public CCLILMJPJAE KOOOKIEPCCF(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x69E0BE0", Offset = "0x69DFDE0", VA = "0x1869E0BE0", Slot = "11")]
	public BPFNEEFLKFD LCOHAPDCEAM(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x69E0850", Offset = "0x69DFA50", VA = "0x1869E0850", Slot = "12")]
	public HINBMJPPHGA IIJMGLCPFBB(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x69E0790", Offset = "0x69DF990", VA = "0x1869E0790", Slot = "13")]
	public MFKDHKCCJCM IHANLNPLFPO(MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x69E0260", Offset = "0x69DF460", VA = "0x1869E0260")]
	public INOFAABIFLC DKKDAPLGEIF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x69E00D0", Offset = "0x69DF2D0", VA = "0x1869E00D0")]
	public GDAOADKDPAF CGEIAAEADIK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x69E0990", Offset = "0x69DFB90", VA = "0x1869E0990")]
	public IIAGEEMDHLO KJJOMLMAEBE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x69E04C0", Offset = "0x69DF6C0", VA = "0x1869E04C0")]
	public JAKABNCBAIN LBKPKKMEKIE(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x69DFF20", Offset = "0x69DF120", VA = "0x1869DFF20")]
	public IEAEDMPDGJJ OGMDNOCMIOI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x69E03A0", Offset = "0x69DF5A0", VA = "0x1869E03A0", Slot = "19")]
	public MLBMNLCAMKC FPLKNDOHABF(RigidbodyEx FIABOAAAKMM, KIHAJJACEBK JLJKEBMIIPF, CJLOPNFHCEF LJOFMHFOMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KLDBMGOMKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x69E0260", Offset = "0x69DF460", VA = "0x1869E0260", Slot = "14")]
	private INOFAABIFLC DEEHEHOALPF(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x69E00D0", Offset = "0x69DF2D0", VA = "0x1869E00D0", Slot = "15")]
	private GDAOADKDPAF MOEGDAHNGGO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x69E0990", Offset = "0x69DFB90", VA = "0x1869E0990", Slot = "16")]
	private IIAGEEMDHLO PCDDPGGCKFI(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x69E04C0", Offset = "0x69DF6C0", VA = "0x1869E04C0", Slot = "17")]
	private JAKABNCBAIN GMBELEFOPBK(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x69DFF20", Offset = "0x69DF120", VA = "0x1869DFF20", Slot = "18")]
	private IEAEDMPDGJJ ABDFPFBCMBO(MLBMNLCAMKC FNFDOEGAMFP, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class IKHKOHFEHBE : BPFNEEFLKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x69DFB90", Offset = "0x69DED90", VA = "0x1869DFB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool NAKOAPFAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x69DF500", Offset = "0x69DE700", VA = "0x1869DF500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool FMPMOALNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x69DF240", Offset = "0x69DE440", VA = "0x1869DF240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x69DEF80", Offset = "0x69DE180", VA = "0x1869DEF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x69DFBE0", Offset = "0x69DEDE0", VA = "0x1869DFBE0")]
	public IKHKOHFEHBE(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x69DEE20", Offset = "0x69DE020", VA = "0x1869DEE20", Slot = "4")]
	public void BCIDKICACAE(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x69DEFE0", Offset = "0x69DE1E0", VA = "0x1869DEFE0")]
	private void CCLEAHBMBCD(Vector3 LBPGAAMAJKE, ForceMode KEFPKBHNHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x69DF910", Offset = "0x69DEB10", VA = "0x1869DF910", Slot = "5")]
	public void NLEGEFDHPLD(Vector3 LBPGAAMAJKE, Vector3 CAOOPLKANIG, ForceMode KEFPKBHNHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x69DF7B0", Offset = "0x69DE9B0", VA = "0x1869DF7B0", Slot = "6")]
	public void NBFMPPOMLMG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x69DF2A0", Offset = "0x69DE4A0", VA = "0x1869DF2A0")]
	private void KMALEEOJPIG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x69DF550", Offset = "0x69DE750", VA = "0x1869DF550", Slot = "7")]
	public void MNBILPCOKHG(Vector3 CCLGGMMGBEG, ForceMode KEFPKBHNHNL = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class MLIGEHJEJMN : MFKDHKCCJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool KKFECHKHJJH;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool ANNDCPJNOEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x69E3630", Offset = "0x69E2830", VA = "0x1869E3630", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x69DFBE0", Offset = "0x69DEDE0", VA = "0x1869DFBE0")]
	public MLIGEHJEJMN(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x69E3600", Offset = "0x69E2800", VA = "0x1869E3600", Slot = "6")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x69E3740", Offset = "0x69E2940", VA = "0x1869E3740", Slot = "7")]
	public void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class NDBKBNODGNM : HMJANEJHBNM, CGKNFLEAOHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MLBMNLCAMKC FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<MLBMNLCAMKC> IELELFGAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MLBMNLCAMKC LNOFAKNEFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MLBMNLCAMKC BGILIGANMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform IKMMDGFMMFO;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x69E41D0", Offset = "0x69E33D0", VA = "0x1869E41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x69E46B0", Offset = "0x69E38B0", VA = "0x1869E46B0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public MLBMNLCAMKC LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFC0", Offset = "0x7CB1C0", VA = "0x1807CBFC0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<MLBMNLCAMKC> ALOCFGFMFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFA0", Offset = "0x7CB1A0", VA = "0x1807CBFA0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event AJLICCNEBGN HJBGBJDDJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x69E5480", Offset = "0x69E4680", VA = "0x1869E5480", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x69E4D20", Offset = "0x69E3F20", VA = "0x1869E4D20", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event AJLICCNEBGN ACGNDKIELMB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x69E3C30", Offset = "0x69E2E30", VA = "0x1869E3C30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x69E4C80", Offset = "0x69E3E80", VA = "0x1869E4C80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JCLJMAKIKCG HNFDIBDHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x69E5520", Offset = "0x69E4720", VA = "0x1869E5520", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x69E4390", Offset = "0x69E3590", VA = "0x1869E4390", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action BBHPMJGAJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x69E42F0", Offset = "0x69E34F0", VA = "0x1869E42F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x69E46C0", Offset = "0x69E38C0", VA = "0x1869E46C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MJEKHHDBGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x69E3CD0", Offset = "0x69E2ED0", VA = "0x1869E3CD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x69E3E20", Offset = "0x69E3020", VA = "0x1869E3E20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<MLBMNLCAMKC> OFLJBBLAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x69E3AD0", Offset = "0x69E2CD0", VA = "0x1869E3AD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x69E4A70", Offset = "0x69E3C70", VA = "0x1869E4A70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MLBMNLCAMKC> BGGEOHAEEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x69E4B20", Offset = "0x69E3D20", VA = "0x1869E4B20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x69E4BD0", Offset = "0x69E3DD0", VA = "0x1869E4BD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IHJKHLHIDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x69E4890", Offset = "0x69E3A90", VA = "0x1869E4890", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x69E5340", Offset = "0x69E4540", VA = "0x1869E5340", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<MLBMNLCAMKC> PFAPIHCEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x69E3B80", Offset = "0x69E2D80", VA = "0x1869E3B80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x69E3D70", Offset = "0x69E2F70", VA = "0x1869E3D70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x69E5660", Offset = "0x69E4860", VA = "0x1869E5660")]
	public NDBKBNODGNM(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x69E4130", Offset = "0x69E3330", VA = "0x1869E4130", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x69E4DC0", Offset = "0x69E3FC0", VA = "0x1869E4DC0", Slot = "30")]
	public void NDMMKDCEAMC(MLBMNLCAMKC KFDAFHAJFEH, bool KHENNGFPBJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x69E3EC0", Offset = "0x69E30C0", VA = "0x1869E3EC0", Slot = "6")]
	public void DDHNIEFPEBM(MLBMNLCAMKC EEFLIDEPHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x69E4430", Offset = "0x69E3630", VA = "0x1869E4430", Slot = "7")]
	public void GADGEOCCOMK(MLBMNLCAMKC EEFLIDEPHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x69E4760", Offset = "0x69E3960", VA = "0x1869E4760", Slot = "4")]
	public void HDOMKOPCCKF(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x69E53E0", Offset = "0x69E45E0", VA = "0x1869E53E0", Slot = "5")]
	public void NNAPFILCBHP(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x69E55C0", Offset = "0x69E47C0", VA = "0x1869E55C0")]
	private void PPKLPPKKNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x69E4850", Offset = "0x69E3A50", VA = "0x1869E4850")]
	private void HLNDAPNMALG(MLBMNLCAMKC EEFLIDEPHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x69E4930", Offset = "0x69E3B30", VA = "0x1869E4930")]
	private void IOAEMKAEDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x69E39A0", Offset = "0x69E2BA0", VA = "0x1869E39A0")]
	private void BAGFIDHEHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x69E3870", Offset = "0x69E2A70", VA = "0x1869E3870")]
	private void AOIBJKDCGEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x69E4230", Offset = "0x69E3430", VA = "0x1869E4230")]
	[CompilerGenerated]
	private object ECGFHMOMHEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CIKAPGMHGFO
{
	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x69D46C0", Offset = "0x69D38C0", VA = "0x1869D46C0")]
	public static HMJANEJHBNM LFAOMMHPIGB(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class NNBEOOAAFCH : HGMGOFLMABF, DKJDGPKAIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GAPNAMDEEEN<MLBMNLCAMKC> GJCIKFBIDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool EPFNCAKAECP;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GAPNAMDEEEN<MLBMNLCAMKC> MPGNCDKJGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 FAJCEAKEFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x69E6C70", Offset = "0x69E5E70", VA = "0x1869E6C70", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IECIKDIFPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x69E65E0", Offset = "0x69E57E0", VA = "0x1869E65E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 PFKDBCAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x69E63E0", Offset = "0x69E55E0", VA = "0x1869E63E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public MLBMNLCAMKC BAOPPGMKDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x69E6530", Offset = "0x69E5730", VA = "0x1869E6530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x69E7030", Offset = "0x69E6230", VA = "0x1869E7030")]
	public NNBEOOAAFCH(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x69E64C0", Offset = "0x69E56C0", VA = "0x1869E64C0", Slot = "8")]
	public void FALNLPHIAFF(MLBMNLCAMKC BGILIGANMHA, object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x69E6380", Offset = "0x69E5580", VA = "0x1869E6380", Slot = "9")]
	public void AHHPLKKPCDB(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x69E6CA0", Offset = "0x69E5EA0", VA = "0x1869E6CA0")]
	private Vector3 MFDKHPJOADN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x69E68E0", Offset = "0x69E5AE0", VA = "0x1869E68E0")]
	private void JKMPAIPEFAP(MLBMNLCAMKC PMNKIKCHBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class DAGKKELDELJ
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x69D4840", Offset = "0x69D3A40", VA = "0x1869D4840")]
	public static HGMGOFLMABF MHPFNAPAPHH(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PNPILALPADA : GPAPEJMKLMN, JAKABNCBAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 FOBAICDJODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 FLPHCNMPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float BNHJIEHFLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float KOPNAKBHKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 LDFMFHKJMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? EMHOHBOOEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? DLCGJPBMPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool EDABJIDDJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool BNFCJBNINJM;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 DNFOLPHPADO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xCB7CB0", Offset = "0xCB6EB0", VA = "0x180CB7CB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x69EAA40", Offset = "0x69E9C40", VA = "0x1869EAA40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 BGJFBCMDJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x69E8AE0", Offset = "0x69E7CE0", VA = "0x1869E8AE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float GBEJFLLHBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8345B0", Offset = "0x8337B0", VA = "0x1808345B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x69E8BE0", Offset = "0x69E7DE0", VA = "0x1869E8BE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float CJALDMPNNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8346C0", Offset = "0x8338C0", VA = "0x1808346C0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x69E9310", Offset = "0x69E8510", VA = "0x1869E9310", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 LEMDFFDMIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x69E8950", Offset = "0x69E7B50", VA = "0x1869E8950", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion PBEMDKEHNKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x69EAF00", Offset = "0x69EA100", VA = "0x1869EAF00", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x69E7FA0", Offset = "0x69E71A0", VA = "0x1869E7FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event AJLICCNEBGN MCBCIFHMPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x69E9460", Offset = "0x69E8660", VA = "0x1869E9460", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x69E93C0", Offset = "0x69E85C0", VA = "0x1869E93C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x69EB080", Offset = "0x69EA280", VA = "0x1869EB080")]
	public PNPILALPADA(MLBMNLCAMKC FIABOAAAKMM, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x69EAAF0", Offset = "0x69E9CF0", VA = "0x1869EAAF0", Slot = "17")]
	public void KPDDLMJMCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x69EAE20", Offset = "0x69EA020", VA = "0x1869EAE20", Slot = "16")]
	public void MEMNDDBKPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x69E8870", Offset = "0x69E7A70", VA = "0x1869E8870", Slot = "19")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x69E9120", Offset = "0x69E8320", VA = "0x1869E9120", Slot = "20")]
	public void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x69E8CF0", Offset = "0x69E7EF0", VA = "0x1869E8CF0", Slot = "18")]
	public void CPDCLMMKGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x69E9500", Offset = "0x69E8700", VA = "0x1869E9500", Slot = "21")]
	public void HLKCDMOBFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x69EAA40", Offset = "0x69E9C40", VA = "0x1869EAA40")]
	private void OEBAOHJCKGM(Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x69E8E90", Offset = "0x69E8090", VA = "0x1869E8E90")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DDACPAKILNM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x69E8BE0", Offset = "0x69E7DE0", VA = "0x1869E8BE0")]
	private void EBAHMPOPOPE(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x69E9310", Offset = "0x69E8510", VA = "0x1869E9310")]
	private void JBHCGOONBEI(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x69E8F80", Offset = "0x69E8180", VA = "0x1869E8F80")]
	private Vector3 FBIPGNECKBN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x69EA810", Offset = "0x69E9A10", VA = "0x1869EA810", Slot = "15")]
	public void KMPMDCIKOCD((Quaternion rot, Vector3 moments) HOGIILJMFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x69EACA0", Offset = "0x69E9EA0", VA = "0x1869EACA0")]
	private Quaternion MDONIOLDGLO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x69E9990", Offset = "0x69E8B90", VA = "0x1869E9990")]
	public void KKNJMMNGIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x69E9A60", Offset = "0x69E8C60", VA = "0x1869E9A60", Slot = "4")]
	public (float, Vector3) KKNJMMNGIJE(Rigidbody KBNBJGLLEOP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class CPAGMMBHMKL
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x69D4780", Offset = "0x69D3980", VA = "0x1869D4780")]
	public static GPAPEJMKLMN FPBHHCLDDPH(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class EHENHAGOLKP : IIAGEEMDHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly IHDMHCMLFDH NAFIIFIPBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MGOCMEIHPAH OOIAPDIEPPC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool HHIKIPIHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xE35500", Offset = "0xE34700", VA = "0x180E35500", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public MGOCMEIHPAH NHOMBPKJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x831BC0", Offset = "0x830DC0", VA = "0x180831BC0", Slot = "11")]
		get
		{
			return default(MGOCMEIHPAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x69DB100", Offset = "0x69DA300", VA = "0x1869DB100")]
	public EHENHAGOLKP(MLBMNLCAMKC FIABOAAAKMM, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x69DAE10", Offset = "0x69DA010", VA = "0x1869DAE10", Slot = "4")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x69DB060", Offset = "0x69DA260", VA = "0x1869DB060")]
	private bool PPELOMKGMGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x69DAAE0", Offset = "0x69D9CE0", VA = "0x1869DAAE0", Slot = "5")]
	public void BIKAKGMHIAA(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x69DADE0", Offset = "0x69D9FE0", VA = "0x1869DADE0", Slot = "6")]
	public void FGJDLCAHDBI(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x69DAEE0", Offset = "0x69DA0E0", VA = "0x1869DAEE0", Slot = "9")]
	public void GJCCCKCAIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x69DACC0", Offset = "0x69D9EC0", VA = "0x1869DACC0")]
	private void DOCGNOINLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x69DAB50", Offset = "0x69D9D50", VA = "0x1869DAB50")]
	private void CJOCFJKGANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x69DAB10", Offset = "0x69D9D10", VA = "0x1869DAB10", Slot = "8")]
	public void CFGLOBIFOFN(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x69DB020", Offset = "0x69DA220", VA = "0x1869DB020", Slot = "7")]
	public void KNEEBOEJLGG(MLBMNLCAMKC FIABOAAAKMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OPIPIJGCPNP : CCLILMJPJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IHDMHCMLFDH KGLKLLEKHPO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NAKOAPFAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x69E85E0", Offset = "0x69E77E0", VA = "0x1869E85E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event AJLICCNEBGN GEOLLDMFHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x69E8540", Offset = "0x69E7740", VA = "0x1869E8540", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x69E8690", Offset = "0x69E7890", VA = "0x1869E8690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x69E8780", Offset = "0x69E7980", VA = "0x1869E8780")]
	public OPIPIJGCPNP(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x69E8770", Offset = "0x69E7970", VA = "0x1869E8770", Slot = "7")]
	public void PEJPDILMIBL(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x69E8530", Offset = "0x69E7730", VA = "0x1869E8530", Slot = "8")]
	public void KANKOMFMBOD(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x69E8420", Offset = "0x69E7620", VA = "0x1869E8420", Slot = "9")]
	public void GPDCEJFENKH(object CEFPPEHCFCF, bool FBFCNIMNMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x69E8730", Offset = "0x69E7930", VA = "0x1869E8730", Slot = "12")]
	public void MGKIKCNLKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x69E8370", Offset = "0x69E7570", VA = "0x1869E8370", Slot = "10")]
	public void ADBPPACPBLH(Rigidbody NCIFAJPFOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x69E83F0", Offset = "0x69E75F0", VA = "0x1869E83F0", Slot = "11")]
	public void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class LNPCKDBKMPB : FJGGMMMFMLP, GDAOADKDPAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView MBBBGFBBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool EOHAKJPGGKM;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView PJODKKOKLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HOAOHAGBBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x69E27E0", Offset = "0x69E19E0", VA = "0x1869E27E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HEJDBCNPDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B6690", Offset = "0x9B5890", VA = "0x1809B6690", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event AJLICCNEBGN PAIFKHNNABM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x69E2640", Offset = "0x69E1840", VA = "0x1869E2640", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x69E25A0", Offset = "0x69E17A0", VA = "0x1869E25A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x69E3140", Offset = "0x69E2340", VA = "0x1869E3140")]
	public LNPCKDBKMPB(MLBMNLCAMKC FIABOAAAKMM, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x69E2800", Offset = "0x69E1A00", VA = "0x1869E2800", Slot = "9")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x69E26E0", Offset = "0x69E18E0", VA = "0x1869E26E0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x69E2E60", Offset = "0x69E2060", VA = "0x1869E2E60", Slot = "10")]
	public void NGCONMEGJJD(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x69E2CF0", Offset = "0x69E1EF0", VA = "0x1869E2CF0", Slot = "11")]
	public void JGOLNCCFEIO(MLBMNLCAMKC BGILIGANMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x69E2FD0", Offset = "0x69E21D0", VA = "0x1869E2FD0")]
	private void PGNILBEPIFH(PhotonView FEDBOIFOOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x69E2930", Offset = "0x69E1B30", VA = "0x1869E2930")]
	private void GHONEEOKAOC(JIFDJNGDNBF HODCHMBKBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x69E2A80", Offset = "0x69E1C80", VA = "0x1869E2A80")]
	private void HOBAPBJDJMG(PhotonView LOKLNLJAEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class MOHCPILFFAE
{
	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x69E37B0", Offset = "0x69E29B0", VA = "0x1869E37B0")]
	public static FJGGMMMFMLP PIPKNHKKHPG(this MLBMNLCAMKC FNFDOEGAMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JMBMCHHFPAA : IEAEDMPDGJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints EKIINMPEHKP;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool JPAFICCGOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xC1B2D0", Offset = "0xC1A4D0", VA = "0x180C1B2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x4186B70", Offset = "0x4185D70", VA = "0x184186B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KFCOLDHIDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xE89BD0", Offset = "0xE88DD0", VA = "0x180E89BD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4186B60", Offset = "0x4185D60", VA = "0x184186B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints MGBDMOMNEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x69DFD40", Offset = "0x69DEF40", VA = "0x1869DFD40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x69DFE70", Offset = "0x69DF070", VA = "0x1869DFE70")]
	public JMBMCHHFPAA(MLBMNLCAMKC FIABOAAAKMM, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x69DFCE0", Offset = "0x69DEEE0", VA = "0x1869DFCE0", Slot = "9")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x69DFD10", Offset = "0x69DEF10", VA = "0x1869DFD10", Slot = "10")]
	public void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HDLDLLCAGOI : EIBFAKJBPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MLBMNLCAMKC FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float KGHHNPPMFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float KLBMAGELMNP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float NCLNCILOJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x834740", Offset = "0x833940", VA = "0x180834740", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x69DB530", Offset = "0x69DA730", VA = "0x1869DB530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float HLOFEGMDDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x834700", Offset = "0x833900", VA = "0x180834700", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x69DB3C0", Offset = "0x69DA5C0", VA = "0x1869DB3C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x69DB600", Offset = "0x69DA800", VA = "0x1869DB600")]
	public HDLDLLCAGOI(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x69DB370", Offset = "0x69DA570", VA = "0x1869DB370", Slot = "8")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x69DB490", Offset = "0x69DA690", VA = "0x1869DB490", Slot = "9")]
	public void FGIDFHPPHEO(Rigidbody IOIJBGDBPEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OGNENAFKGEJ : JLFANNPNIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool KLHKAKIGLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool KPIJDGCCKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int KDIEHDDACPB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x69E7FA0", Offset = "0x69E71A0", VA = "0x1869E7FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool EFIGICGIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x69E7B70", Offset = "0x69E6D70", VA = "0x1869E7B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private MLBMNLCAMKC DPGEGBIPNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x69E7830", Offset = "0x69E6A30", VA = "0x1869E7830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool FMPMOALNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x69E7890", Offset = "0x69E6A90", VA = "0x1869E7890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event AJLICCNEBGN JAKODDHNACF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x69E7FF0", Offset = "0x69E71F0", VA = "0x1869E7FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x69E7F00", Offset = "0x69E7100", VA = "0x1869E7F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x69E82E0", Offset = "0x69E74E0", VA = "0x1869E82E0")]
	public OGNENAFKGEJ(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x69E7990", Offset = "0x69E6B90", VA = "0x1869E7990", Slot = "6")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x69E7820", Offset = "0x69E6A20", VA = "0x1869E7820", Slot = "8")]
	public void AOGIKHHBCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x69E7A20", Offset = "0x69E6C20", VA = "0x1869E7A20", Slot = "7")]
	public bool IMDPPCPMHKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x69E78F0", Offset = "0x69E6AF0", VA = "0x1869E78F0", Slot = "9")]
	public void DDNJLABBBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x69E8240", Offset = "0x69E7440", VA = "0x1869E8240", Slot = "11")]
	public void PPALGMNDKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x69E8090", Offset = "0x69E7290", VA = "0x1869E8090", Slot = "10")]
	public void ONNEJMLPGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x69E7B90", Offset = "0x69E6D90", VA = "0x1869E7B90")]
	private bool JFBDIAGDBDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x69E7D70", Offset = "0x69E6F70", VA = "0x1869E7D70")]
	private void JGIBECMPHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LJCOIHMFPMD : INOFAABIFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IHDMHCMLFDH OFDFFKAMEGI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody HKCDHJFADIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool FMPMOALNLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x69DF240", Offset = "0x69DE440", VA = "0x1869DF240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool HBAPLIIFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xE35500", Offset = "0xE34700", VA = "0x180E35500", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x69E2270", Offset = "0x69E1470", VA = "0x1869E2270")]
	public LJCOIHMFPMD(MLBMNLCAMKC FIABOAAAKMM, [In] KIHAJJACEBK JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x69E1AF0", Offset = "0x69E0CF0", VA = "0x1869E1AF0", Slot = "5")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x69E1B90", Offset = "0x69E0D90", VA = "0x1869E1B90", Slot = "7")]
	public void HABHNOOKKKB(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x69E1730", Offset = "0x69E0930", VA = "0x1869E1730", Slot = "8")]
	public void ENDPKLCJOGC(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x69E1F40", Offset = "0x69E1140", VA = "0x1869E1F40", Slot = "9")]
	public void PLDDOKBOEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x69E1540", Offset = "0x69E0740", VA = "0x1869E1540", Slot = "11")]
	public void EFCGOPAEOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x69E1DC0", Offset = "0x69E0FC0", VA = "0x1869E1DC0", Slot = "12")]
	public void MNBGLECMGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x69E1760", Offset = "0x69E0960", VA = "0x1869E1760", Slot = "10")]
	public void FHFNIJLOAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x69E18F0", Offset = "0x69E0AF0", VA = "0x1869E18F0")]
	private void GDNAMOIGIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x69E1BC0", Offset = "0x69E0DC0", VA = "0x1869E1BC0")]
	private void KFPJFDKAAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HFHHIKELKHH : CJHPFJONJFB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly EHAPKFOGFHF FIABOAAAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly IHDMHCMLFDH GGLBEGOCMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float NANJGBHKMLB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public HGDEADHMLPB PAEMNMIPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public ADACCNNPCMH NHGOIAIBBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 PFKDBCAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x69DC010", Offset = "0x69DB210", VA = "0x1869DC010", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x69DD5F0", Offset = "0x69DC7F0", VA = "0x1869DD5F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 BJEPGMCEGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x69DBA60", Offset = "0x69DAC60", VA = "0x1869DBA60", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x69DDAD0", Offset = "0x69DCCD0", VA = "0x1869DDAD0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MPOGMCLMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x69DBE40", Offset = "0x69DB040", VA = "0x1869DBE40", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x69DE660", Offset = "0x69DD860", VA = "0x1869DE660", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 OKJJBAPADJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x69DE3C0", Offset = "0x69DD5C0", VA = "0x1869DE3C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x69DE630", Offset = "0x69DD830", VA = "0x1869DE630", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float CLHNPKJEKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x834620", Offset = "0x833820", VA = "0x180834620", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x69DD4E0", Offset = "0x69DC6E0", VA = "0x1869DD4E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool ILNPIGNFNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x17E14E0", Offset = "0x17E06E0", VA = "0x1817E14E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BPFNEEFLKFD DLDIDCJNHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6287B20", Offset = "0x6286D20", VA = "0x186287B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool EFIGICGIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x69DD6B0", Offset = "0x69DC8B0", VA = "0x1869DD6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x69DED30", Offset = "0x69DDF30", VA = "0x1869DED30")]
	public HFHHIKELKHH(MLBMNLCAMKC FIABOAAAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x69DC5A0", Offset = "0x69DB7A0", VA = "0x1869DC5A0", Slot = "19")]
	public void GENMKELLIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x69DC1D0", Offset = "0x69DB3D0", VA = "0x1869DC1D0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x69DB640", Offset = "0x69DA840", VA = "0x1869DB640", Slot = "28")]
	public void ADBPPACPBLH(Rigidbody IOIJBGDBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xC7C990", Offset = "0xC7BB90", VA = "0x180C7C990", Slot = "20")]
	public void BMMKCICEKPL(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xC7C970", Offset = "0xC7BB70", VA = "0x180C7C970", Slot = "30")]
	public void ENMIDCPJMCD(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x69DC3C0", Offset = "0x69DB5C0", VA = "0x1869DC3C0", Slot = "35")]
	public Vector3 GAHFGNCCNEI(Vector3 AFMJJPANOMP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x69DD910", Offset = "0x69DCB10", VA = "0x1869DD910", Slot = "34")]
	public Vector3 KBECBHDFLBL(Vector3 FGFDGBCPILN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x69DC5A0", Offset = "0x69DB7A0", VA = "0x1869DC5A0", Slot = "27")]
	public void HDPLKKMDNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x69DB770", Offset = "0x69DA970", VA = "0x1869DB770", Slot = "25")]
	public void AHDMJDPBIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x69DECD0", Offset = "0x69DDED0", VA = "0x1869DECD0", Slot = "24")]
	public void PAOJHICNPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x69DD6D0", Offset = "0x69DC8D0", VA = "0x1869DD6D0", Slot = "33")]
	public void JIBBKGEAECD(Vector3 JJJBAPONEMM, Vector3 IJOJBCPABEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x69DE360", Offset = "0x69DD560", VA = "0x1869DE360", Slot = "32")]
	public void MLPLNPGBJBG(Vector3 NLCAFHPBMBL, Vector3 CBADBDPEHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x69DD340", Offset = "0x69DC540", VA = "0x1869DD340", Slot = "31")]
	public void IEKNJPPHKKM(Vector3 EHKJBKDMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x69DDB00", Offset = "0x69DCD00", VA = "0x1869DDB00", Slot = "22")]
	public void LAFFEJBOCJB(GFDEOLECDKI PDKKCJGKJON, Vector3 BBLCKOPMCNG, float FDFBILKKBBE, float MKNLLALMFAI = 8f, float KOGOLPMGEIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x69DB7D0", Offset = "0x69DA9D0", VA = "0x1869DB7D0", Slot = "21")]
	public void ALIEEIAANFJ(JCMCBMFLILG BFMIDLCNFLF, Vector3 PADGEFFBBON, float PGKGMEEJICP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x69DCF50", Offset = "0x69DC150", VA = "0x1869DCF50", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void HLMADCNFDJO(JCMCBMFLILG BFMIDLCNFLF, Vector3 JCCMNAMJFGM, float JAOCLLEPJKG = 7f, float CIJCOKDJPCK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xD614F0", Offset = "0xD606F0", VA = "0x180D614F0")]
	private static void NCKOPOGDEFK(Vector3 OAFPAEEDKIL, Vector3 BGIIKDPIDDB, [Out] Vector3 MIFAFIMCBPF, [Out] Vector3 KAKEFGPBKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x69DE550", Offset = "0x69DD750", VA = "0x1869DE550", Slot = "29")]
	public Vector3 NCPGDGBHEKB(Vector3 OAFPAEEDKIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x69DE050", Offset = "0x69DD250", VA = "0x1869DE050", Slot = "26")]
	public void LMIPMOKCPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x69DD4E0", Offset = "0x69DC6E0", VA = "0x1869DD4E0")]
	private void IGGBLIIIOPP(float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x69DBCA0", Offset = "0x69DAEA0", VA = "0x1869DBCA0")]
	private void CHFKIKLHCCB(Vector3 PADGEFFBBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x69DE1E0", Offset = "0x69DD3E0", VA = "0x1869DE1E0")]
	private Vector3 MEAKEDMACKH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x69DCAD0", Offset = "0x69DBCD0", VA = "0x1869DCAD0")]
	private void HLIANCOCHIM(Vector3 FGFDGBCPILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x69DC230", Offset = "0x69DB430", VA = "0x1869DC230")]
	private Vector3 EJCJDNGCOPB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x69DC650", Offset = "0x69DB850", VA = "0x1869DC650")]
	private void HHLFDMHANBG(Vector3 HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x69DE720", Offset = "0x69DD920", VA = "0x1869DE720")]
	private void NOPBDDNMACP(Vector3 FGFDGBCPILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x69DBBF0", Offset = "0x69DADF0", VA = "0x1869DBBF0")]
	private void BPKBCLIJEOK()
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
