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
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70643D0", Offset = "0x70629D0", VA = "0x1870643D0", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
	public class _AssemblyIndex : MFFEOJCHKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LGNGCJEOPOG bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1530BC0", Offset = "0x152F1C0", VA = "0x181530BC0", Slot = "5")]
		public override void DPMBFMAPFBK(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x706B430", Offset = "0x7069A30", VA = "0x18706B430")]
		private void EHBFLIGPAJF(FCPMPAGEMFF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x706B3D0", Offset = "0x70699D0", VA = "0x18706B3D0", Slot = "6")]
		public override void CIENDGKKGFP(FCPMPAGEMFF registry, [In] PCFCONNFILF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "8")]
		public override void JHLKEJPJBFN(FONNCKCINIP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x706B740", Offset = "0x7069D40", VA = "0x18706B740")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, DKAMHPILGME
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly PBGLEKOCCEM BPMHENFKFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PBBNFCONDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NEDLHIMBFHA CPDLPLKCBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[EOFOOIANCED(MLFOJBPNDOB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[EOFOOIANCED(MLFOJBPNDOB.SelfAndParent, true, false, false)]
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
		private JLMNFBGGGIJ physicsInterpolation;

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
		internal NEDLHIMBFHA FFCIBIMIEJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7066E10", Offset = "0x7065410", VA = "0x187066E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NEDLHIMBFHA NEGKCFPBJEC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LPNPPNCGIEH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7068800", Offset = "0x7066E00", VA = "0x187068800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx ANKEJOMPJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7068B60", Offset = "0x7067160", VA = "0x187068B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DBCKFKNELBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7068AA0", Offset = "0x70670A0", VA = "0x187068AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PPEEAFEPIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7069810", Offset = "0x7067E10", VA = "0x187069810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x706AD40", Offset = "0x7069340", VA = "0x18706AD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform HGEEPPPHLEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88F8B0", Offset = "0x88DEB0", VA = "0x18088F8B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HDNBEKMOJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88F8B0", Offset = "0x88DEB0", VA = "0x18088F8B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IBJOHPGNLAO HNGJCFHGNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7068860", Offset = "0x7066E60", VA = "0x187068860")]
			get
			{
				return default(IBJOHPGNLAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x706A4F0", Offset = "0x7068AF0", VA = "0x18706A4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EPBKCECLMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7068E70", Offset = "0x7067470", VA = "0x187068E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FGJHMHFFMPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7068980", Offset = "0x7066F80", VA = "0x187068980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NGDDLDGNNPG EKGEDOLJCMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7068DB0", Offset = "0x70673B0", VA = "0x187068DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x706A6B0", Offset = "0x7068CB0", VA = "0x18706A6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NDGEFNLJMAC IADAJOGNIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7068D50", Offset = "0x7067350", VA = "0x187068D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x706A640", Offset = "0x7068C40", VA = "0x18706A640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IGFMPAHDGNF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7068CA0", Offset = "0x70672A0", VA = "0x187068CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody JIDGAHELAIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7068D00", Offset = "0x7067300", VA = "0x187068D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ECMCFIPLAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x70689E0", Offset = "0x7066FE0", VA = "0x1870689E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x706A560", Offset = "0x7068B60", VA = "0x18706A560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OMMFIJCLBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D3BA20", Offset = "0x6D3A020", VA = "0x186D3BA20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float MAKICPOEHIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x70697B0", Offset = "0x7067DB0", VA = "0x1870697B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float BNMOOCAIDGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7069750", Offset = "0x7067D50", VA = "0x187069750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x706ACD0", Offset = "0x70692D0", VA = "0x18706ACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float PEIIDLLEFGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70690D0", Offset = "0x70676D0", VA = "0x1870690D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x706A950", Offset = "0x7068F50", VA = "0x18706A950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ODBDGLOKCLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7068ED0", Offset = "0x70674D0", VA = "0x187068ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x706A720", Offset = "0x7068D20", VA = "0x18706A720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool BGJPPMBFBLC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7069D90", Offset = "0x7068390", VA = "0x187069D90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x706B280", Offset = "0x7069880", VA = "0x18706B280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 CLNDGLKKOBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7069530", Offset = "0x7067B30", VA = "0x187069530")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x706AAA0", Offset = "0x70690A0", VA = "0x18706AAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 NKGOLBBDJHK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7069ED0", Offset = "0x70684D0", VA = "0x187069ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode ICBHPAJNDAN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7069010", Offset = "0x7067610", VA = "0x187069010")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x706A870", Offset = "0x7068E70", VA = "0x18706A870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float LFEBMBIHGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7068A40", Offset = "0x7067040", VA = "0x187068A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x706A5D0", Offset = "0x7068BD0", VA = "0x18706A5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints OMMLCMDJCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7069070", Offset = "0x7067670", VA = "0x187069070")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x706A8E0", Offset = "0x7068EE0", VA = "0x18706A8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 NGJMCAMAOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x70698D0", Offset = "0x7067ED0", VA = "0x1870698D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LBOAICAEBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x70698D0", Offset = "0x7067ED0", VA = "0x1870698D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x706B060", Offset = "0x7069660", VA = "0x18706B060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float IDNMIPJFBOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7069610", Offset = "0x7067C10", VA = "0x187069610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x706AB80", Offset = "0x7069180", VA = "0x18706AB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float JDFNLPMIKGO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7069D30", Offset = "0x7068330", VA = "0x187069D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x706B210", Offset = "0x7069810", VA = "0x18706B210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion OLIGLOLLEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x70699B0", Offset = "0x7067FB0", VA = "0x1870699B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x706ADE0", Offset = "0x70693E0", VA = "0x18706ADE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion OBAHGDOINKO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7069C50", Offset = "0x7068250", VA = "0x187069C50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x706B140", Offset = "0x7069740", VA = "0x18706B140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 CCMPOELBJIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7069A90", Offset = "0x7068090", VA = "0x187069A90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x706AEB0", Offset = "0x70694B0", VA = "0x18706AEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DFKFGDBCFHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7069B70", Offset = "0x7068170", VA = "0x187069B70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x706AF90", Offset = "0x7069590", VA = "0x18706AF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NPPDGHLPBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7069DF0", Offset = "0x70683F0", VA = "0x187069DF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x706B2F0", Offset = "0x70698F0", VA = "0x18706B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DEOFHMCEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7069670", Offset = "0x7067C70", VA = "0x187069670")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x706ABF0", Offset = "0x70691F0", VA = "0x18706ABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CDGJDANICCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7068F30", Offset = "0x7067530", VA = "0x187068F30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x706A790", Offset = "0x7068D90", VA = "0x18706A790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FMJPBBNAKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7069450", Offset = "0x7067A50", VA = "0x187069450")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x706A9C0", Offset = "0x7068FC0", VA = "0x18706A9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EDBKCELFBOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7069310", Offset = "0x7067910", VA = "0x187069310")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion OPDBCGCJIPH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7069230", Offset = "0x7067830", VA = "0x187069230")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OIDNBLEPDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x706A090", Offset = "0x7068690", VA = "0x18706A090")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NHEPNPJJMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7069FB0", Offset = "0x70685B0", VA = "0x187069FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BODOKGBBLOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x70693F0", Offset = "0x70679F0", VA = "0x1870693F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HKHDCKOACIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7068E10", Offset = "0x7067410", VA = "0x187068E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GHDEILMADAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7068920", Offset = "0x7066F20", VA = "0x187068920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LOCFOHBDCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x70688C0", Offset = "0x7066EC0", VA = "0x1870688C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LFLLFNIGFFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70687A0", Offset = "0x7066DA0", VA = "0x1870687A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JGEJGIOOEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7069130", Offset = "0x7067730", VA = "0x187069130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BGBBMOLNFII
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5A5FCF0", Offset = "0x5A5E2F0", VA = "0x185A5FCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EMMBFAHGHHH CPDBLOIHLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x70686C0", Offset = "0x7066CC0", VA = "0x1870686C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x706A410", Offset = "0x7068A10", VA = "0x18706A410")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DODFEPBDCAA CKDHEMDMHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7068430", Offset = "0x7066A30", VA = "0x187068430")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x706A170", Offset = "0x7068770", VA = "0x18706A170")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DODFEPBDCAA FMNPNFLKHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7068490", Offset = "0x7066A90", VA = "0x187068490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x706A1E0", Offset = "0x70687E0", VA = "0x18706A1E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DODFEPBDCAA MNNBDDKFMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x70685E0", Offset = "0x7066BE0", VA = "0x1870685E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x706A330", Offset = "0x7068930", VA = "0x18706A330")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JCHEPGBFHGG, JCHEPGBFHGG> ICLOABOBCFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7068570", Offset = "0x7066B70", VA = "0x187068570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x706A2C0", Offset = "0x70688C0", VA = "0x18706A2C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event DODFEPBDCAA BIKBANEMCBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7068650", Offset = "0x7066C50", VA = "0x187068650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x706A3A0", Offset = "0x70689A0", VA = "0x18706A3A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DODFEPBDCAA FHHFEJAJFGH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7068730", Offset = "0x7066D30", VA = "0x187068730")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x706A480", Offset = "0x7068A80", VA = "0x18706A480")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DODFEPBDCAA PGIMLAKJANJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7068500", Offset = "0x7066B00", VA = "0x187068500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x706A250", Offset = "0x7068850", VA = "0x18706A250")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230", Slot = "8")]
		private void KPGKLABPOBD(NEDLHIMBFHA AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7067390", Offset = "0x7065990", VA = "0x187067390")]
		internal void KPDIGFMAAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7068150", Offset = "0x7066750", VA = "0x187068150")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody CMKNKCMANHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7066EC0", Offset = "0x70654C0", VA = "0x187066EC0")]
		public DKAMHPILGME GetChild(int PDMMEDBMFPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7067E20", Offset = "0x7066420", VA = "0x187067E20")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IIIBFELFAJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7066BC0", Offset = "0x70651C0", VA = "0x187066BC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7066E10", Offset = "0x7065410", VA = "0x187066E10")]
		private NEDLHIMBFHA FNNCJHBNGFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7066050", Offset = "0x7064650", VA = "0x187066050")]
		private void ADKLMMLJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70675F0", Offset = "0x7065BF0", VA = "0x1870675F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7067390", Offset = "0x7065990", VA = "0x187067390")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7067590", Offset = "0x7065B90", VA = "0x187067590")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7067650", Offset = "0x7065C50", VA = "0x187067650")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7066270", Offset = "0x7064870", VA = "0x187066270")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70676B0", Offset = "0x7065CB0", VA = "0x1870676B0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7066DB0", Offset = "0x70653B0", VA = "0x187066DB0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7067530", Offset = "0x7065B30", VA = "0x187067530")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7067F80", Offset = "0x7066580", VA = "0x187067F80")]
		public void SetParent(RigidbodyEx DMNGPNKHPKF, bool ILHLBOIBFME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70679C0", Offset = "0x7065FC0", VA = "0x1870679C0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7067170", Offset = "0x7065770", VA = "0x187067170")]
		public bool IsRigidbodyAncestor(RigidbodyEx FAGAAIEDMPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7067250", Offset = "0x7065850", VA = "0x187067250")]
		public bool IsRigidbodyDescendant(RigidbodyEx MICELFBICGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x70664E0", Offset = "0x7064AE0", VA = "0x1870664E0")]
		public void AddInterpolationRestriction(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7067720", Offset = "0x7065D20", VA = "0x187067720")]
		public void RemoveInterpolationRestriction(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7066550", Offset = "0x7064B50", VA = "0x187066550")]
		public void AddKinematic(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7067790", Offset = "0x7065D90", VA = "0x187067790")]
		public void RemoveKinematic(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7067F00", Offset = "0x7066500", VA = "0x187067F00")]
		public void SetKinematic(object NJLOKHEKBBE, bool JJAGHLCDGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7067D20", Offset = "0x7066320", VA = "0x187067D20")]
		public void SetDiscontinuousPositionAndRotation(Vector3 BMIACJNKBNO, Quaternion NBMPFMOAJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7067C20", Offset = "0x7066220", VA = "0x187067C20")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 HKPHFAKOJNH, Quaternion FMACAJCCHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7067060", Offset = "0x7065660", VA = "0x187067060")]
		public Vector3 GetConstrainedVelocity(Vector3 NPPDGHLPBPO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7066F50", Offset = "0x7065550", VA = "0x187066F50")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 CDGJDANICCD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70663F0", Offset = "0x70649F0", VA = "0x1870663F0")]
		public void AddForce(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70662E0", Offset = "0x70648E0", VA = "0x1870662E0")]
		public void AddForceAtPosition(Vector3 LCIFANAPNML, Vector3 MCPNOOFMAHG, ForceMode MEKJDPKKBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7066720", Offset = "0x7064D20", VA = "0x187066720")]
		public void AddTorque(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x70665C0", Offset = "0x7064BC0", VA = "0x1870665C0")]
		public void AddRelativeTorque(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7068220", Offset = "0x7066820", VA = "0x187068220")]
		public Vector3 WorldToLocalVelocity(Vector3 AFHHNEMELLI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7067420", Offset = "0x7065A20", VA = "0x187067420")]
		public Vector3 LocalToWorldVelocity(Vector3 DEOFHMCEHDL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7066D50", Offset = "0x7065350", VA = "0x187066D50")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7066CF0", Offset = "0x70652F0", VA = "0x187066CF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7066C90", Offset = "0x7065290", VA = "0x187066C90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7066C30", Offset = "0x7065230", VA = "0x187066C30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7067B20", Offset = "0x7066120", VA = "0x187067B20")]
		public void ResetVelocityWorldSpace(Vector3 ILPBCAOFHFC, Vector3 BNCHFJNCMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7067A20", Offset = "0x7066020", VA = "0x187067A20")]
		public void ResetVelocityLocalSpace(Vector3 BGGFFMNEHLJ, Vector3 FMJPBBNAKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x70678E0", Offset = "0x7065EE0", VA = "0x1870678E0")]
		public void ResetLinearVelocityLocalSpace(Vector3 BGGFFMNEHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x70680B0", Offset = "0x70666B0", VA = "0x1870680B0")]
		public bool SweepTest(Vector3 GKDEFPHJFPJ, [Out] RaycastHit HBCOBNFHLDN, float KPAPKDHNJLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7067330", Offset = "0x7065930", VA = "0x187067330")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7068050", Offset = "0x7066650", VA = "0x187068050")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x70681C0", Offset = "0x70667C0", VA = "0x1870681C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70666B0", Offset = "0x7064CB0", VA = "0x1870666B0")]
		public void AddShouldHaveUnityRigidbodyToken(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7067800", Offset = "0x7065E00", VA = "0x187067800")]
		public void RemoveShouldHaveUnityRigidbodyToken(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7066A50", Offset = "0x7065050", VA = "0x187066A50")]
		public void ApplyForceVelocityChange(BGCGFDEOGGE NCBLBBPMLOJ, Vector3 DKAPEBBIDMB, float KEAADBCIBNM, float KAJOLOCGJBD = 8f, float EOMIAHCPFMP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70669B0", Offset = "0x7064FB0", VA = "0x1870669B0")]
		public void ApplyAngularVelocityChange(LOONDOIDMJL ACLHBCPAOJF, Vector3 NPEDGDPAGMP, float OJAJPGIKPFI = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7066B10", Offset = "0x7065110", VA = "0x187066B10")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LOONDOIDMJL ACLHBCPAOJF, Vector3 GLKHDAMNPBA, float JCENBACKGJB = 7f, float OMOGOJBEKDL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x70668E0", Offset = "0x7064EE0", VA = "0x1870668E0")]
		public bool AllowedScaleChange(float FEMHAGNJCKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7066810", Offset = "0x7064E10", VA = "0x187066810")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx BJMEMMNCKAM, object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7067870", Offset = "0x7065E70", VA = "0x187067870")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x70683C0", Offset = "0x70669C0", VA = "0x1870683C0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x974D20", Offset = "0x973320", VA = "0x180974D20", Slot = "4")]
		private GameObject LAGBOMBHGCK()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88F8B0", Offset = "0x88DEB0", VA = "0x18088F8B0", Slot = "5")]
		private Transform LFJGHNBDJEG()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class AKODLEFANMN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7050F60", Offset = "0x704F560", VA = "0x187050F60")]
	public static NEDLHIMBFHA FFCIBIMIEJM(this RigidbodyEx CGLBFHOJGON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[FCONBELFMBI(typeof(JPAOGFNLGHI), new string[] { })]
public class LEHOHAMILMJ : JPAOGFNLGHI, HJHDLHOJDKL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private MEJIGCPJODJ BJPJHFIPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BACCPHOINKP MBKGOLHFIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private MHHGMGMNMAL KBGKGFGIBGL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BACCPHOINKP NHDLNOJMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MHHGMGMNMAL JNIDBCCOBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70642B0", Offset = "0x70628B0", VA = "0x1870642B0", Slot = "7")]
	public void InitReferences(DPIICBKDOMF OOLAHKJIFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7064220", Offset = "0x7062820", VA = "0x187064220", Slot = "6")]
	public NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public LEHOHAMILMJ()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static AOBPFOPEJNG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int AMACKGLEOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DFNNOACBOGO;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7065EB0", Offset = "0x70644B0", VA = "0x187065EB0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7065EF0", Offset = "0x70644F0", VA = "0x187065EF0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7065ED0", Offset = "0x70644D0", VA = "0x187065ED0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ELIMFPDKMPD, [Optional] UnityEngine.Object CAMDIODFJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ELIMFPDKMPD, [Optional] UnityEngine.Object CAMDIODFJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7066000", Offset = "0x7064600", VA = "0x187066000")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MAAKJGPHJMB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AFIDGJKCJJJ : NGDDLDGNNPG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x876D20", Offset = "0x875320", VA = "0x180876D20", Slot = "4")]
		public Vector3 IAFBJDCFIMB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x876D20", Offset = "0x875320", VA = "0x180876D20", Slot = "5")]
		public Vector3 ELOLHMHMIDM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public AFIDGJKCJJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static NGDDLDGNNPG MIKOHBJGCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70644A0", Offset = "0x7062AA0", VA = "0x1870644A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KGKFOMOAKIB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode FAGPOIEBDIB
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
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLCGPHBEBAL(bool BODOKGBBLOC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKFBMILACJF(bool BODOKGBBLOC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OOEAELNAIFD(Vector3 GKDEFPHJFPJ, [Out] RaycastHit HBCOBNFHLDN, float KPAPKDHNJLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BEBJCJIMNJG : IDisposable, CBACEKMNGCB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IBJOHPGNLAO HNGJCFHGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JCHEPGBFHGG, JCHEPGBFHGG> ICLOABOBCFK;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDMDMOBKCMD();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface MHHGMGMNMAL
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPFICMICDDF NEMOGAGJFEG(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOMGCMOCNNJ APFNIHDKJED(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EEPCFGAOBEG ODPNFDPACEJ(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBFKHMPMKCA ENAEBMIAFOP(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPEIJGMHMGN HAACJBGGLAL(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BEBJCJIMNJG CFMONIKJDDN(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JNGCKGHGGBC CCPIPEFBMHD(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LFAJNHFGEFG FBKJJFBIIJB(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KGKFOMOAKIB GEOPJFIJEEA(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AOGEFGJAHOL BFOCJGNGGIO(NEDLHIMBFHA AKLCDEBLEOF);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PEMHMIPEMLE JFEFFOPAFPA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BOADBJPKJIN IEKOOFDMOME(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HCGDOLHJAFI BIKCGNCHDEO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LDOAKDKELFE AELEGHGNLDJ(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NPLECDBNCMJ FMPIPOELDLO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC, JPAOGFNLGHI FECFMDJKBKG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LFAJNHFGEFG
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMDNLCNGJGB(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJLBNHFKMFJ(Vector3 LCIFANAPNML, Vector3 MCPNOOFMAHG, ForceMode MEKJDPKKBKK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEFJHMAJKGO(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHHMNHFNFJN(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AOGEFGJAHOL
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MNNEEEAOEBM
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
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BPFICMICDDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<NEDLHIMBFHA> HDNHCPHIDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NEDLHIMBFHA DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event DODFEPBDCAA CKDHEMDMHGM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DODFEPBDCAA FMNPNFLKHGO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EMMBFAHGHHH FIGMEEFEPGN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ECFEFFJNHFP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EJLMKDKIDJA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<NEDLHIMBFHA> HIAGGJEOEOP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NEDLHIMBFHA> LBMFGALAGCI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action DMGNOBBCOOG;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<NEDLHIMBFHA> ALNIDANKEKE;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GOPGAHCPBFG(NEDLHIMBFHA MBKJJMHGOEE, bool ILHLBOIBFME = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EEPCFGAOBEG
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 ECNEOFFOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 CIAHPNLACKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBBFJLMDPMI(NEDLHIMBFHA PPEEAFEPIIK, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJFHIFELABM(object NJLOKHEKBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LDOAKDKELFE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MKIELKNCOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GJPCPFIMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float BFOPBBLOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float PLPACLCBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 BONJCBHHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion DCHJEMEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event DODFEPBDCAA COLLCBECGEM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JBAAJHJFDLH((Quaternion rot, Vector3 moments) IIIBFELFAJH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MEDPKKHGJNI();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IEFFBHIPMGI();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHIKINPOCCE();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HCLMGPGOGHO();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCGDOLHJAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COEBEFFEAKD(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGOAJCIACGL(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEGLBFEKGEH(NEDLHIMBFHA CGLBFHOJGON);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIIIOFAIACM(NEDLHIMBFHA CGLBFHOJGON);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLMMINMJFKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JNGCKGHGGBC
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool FGABCNCEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DODFEPBDCAA BAKMEOLKDHL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENNODFFCPIE(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGLKGJIFNHM(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDBNMGDDKDI(object NJLOKHEKBBE, bool JJAGHLCDGON);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJKIAHPLGDF(Rigidbody OBCIJMKFLAO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BOADBJPKJIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool EPBKCECLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FGJHMHFFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DODFEPBDCAA NCHLAJEIDLG;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHLPIPJJKDJ(NEDLHIMBFHA PPEEAFEPIIK);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGMJLGFHANO(NEDLHIMBFHA PPEEAFEPIIK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NPLECDBNCMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ECMCFIPLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GBBCHGKLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints GPNINJJAFBE
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
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HBFKHMPMKCA
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float MCKCDBHOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float AHICHIOPFFN
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
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DPEIJGMHMGN
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DODFEPBDCAA PHPNCGGJCDA;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNHNLLGKJFJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPJAMOAJNBO();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGGOJEGNFAM();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BHPJJEGPHFJ();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PJCEGLNOPJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PEMHMIPEMLE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KPKNODMHPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDCGELNKCEI(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHFBOIOGAJP(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMJINEHNIMC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OOMGCMOCNNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NGDDLDGNNPG EKGEDOLJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NDGEFNLJMAC IADAJOGNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 OMBMCOIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 OICLGKNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 KIEFOPGJEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 APKPAJFJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float LFEBMBIHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool IGFMPAHDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDMDMOBKCMD();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AJBMGJOCMCN(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KKKPDELJAFB(LOONDOIDMJL ACLHBCPAOJF, Vector3 NPEDGDPAGMP, float OJAJPGIKPFI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PBBOHBCIODG(BGCGFDEOGGE NCBLBBPMLOJ, Vector3 DKAPEBBIDMB, float KEAADBCIBNM, float KAJOLOCGJBD = 8f, float EOMIAHCPFMP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GHOADAOFGPJ(LOONDOIDMJL ACLHBCPAOJF, Vector3 GLKHDAMNPBA, float JCENBACKGJB = 7f, float OMOGOJBEKDL = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void INDAIBOJKJH();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FCNIJEHAHAA();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JAMHHKKJPLH();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IOAEOFFBJDL();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 OAKNDJIBJPF(Vector3 NPPDGHLPBPO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MLDNMEMBMEO(object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PBKOFMIKDPP(Vector3 FGIOIHCCMGD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LEHHKNIFKIO(Vector3 BGGFFMNEHLJ, Vector3 FMJPBBNAKNO);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MEPAMPPEPAB(Vector3 ILPBCAOFHFC, Vector3 BNCHFJNCMAC);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GFGIFPFOEJI(Vector3 DEOFHMCEHDL);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FKIDMCMFECG(Vector3 AFHHNEMELLI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface BACCPHOINKP
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NKBMHFAHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIEPKJPEOMB(string ENLEFDLBBGG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKFNJMDCMPG(RigidbodyEx CGLBFHOJGON, Action PEMICEIPPPL);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKJGAMOJFGP FEDCPOPPHOH(int OOHEFAEDLKM);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCAPFNPMKNF(Vector3 NKGOLBBDJHK, float DCINMOFHAMK, Color PHHAMGLLFIF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DBIJOBJFKFD(OFPDOPBEGLP.Application)]
public interface JPAOGFNLGHI
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BACCPHOINKP NHDLNOJMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	MHHGMGMNMAL JNIDBCCOBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EMHPEGHHEBE : NEDLHIMBFHA, IDisposable, DJBDAFKKPIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly JPAOGFNLGHI FECFMDJKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal BPFICMICDDF CEFJJCAFMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal HCGDOLHJAFI ANOAAHKLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal BOADBJPKJIN BBPFLBEOAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OOMGCMOCNNJ NPPDGHLPBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal EEPCFGAOBEG NBFNIEPBJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LDOAKDKELFE FBGOGALMMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HBFKHMPMKCA CJAGCEKHCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal AOGEFGJAHOL FICNAJIBMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal DPEIJGMHMGN PBMPFPKDGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal BEBJCJIMNJG LGJDDEBBFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal JNGCKGHGGBC KKGMCIPPPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal LFAJNHFGEFG LCIFANAPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal NPLECDBNCMJ MKLHPCFOOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal PEMHMIPEMLE GEAHMGKGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal KGKFOMOAKIB GEMGHLKKFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable DODKNCGGDPD;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AMOFBKBMFBA IMKGIBCHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "22")]
		get
		{
			return default(AMOFBKBMFBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public DKAMHPILGME BHKCNGCONEF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86C7B0", Offset = "0x86ADB0", VA = "0x18086C7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject HJMFHICNFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD30", Offset = "0xA1A330", VA = "0x180A1BD30", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9FB860", Offset = "0x9F9E60", VA = "0x1809FB860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7054930", Offset = "0x7052F30", VA = "0x187054930", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7052E50", Offset = "0x7051450", VA = "0x187052E50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7057A50", Offset = "0x7056050", VA = "0x187057A50", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x70572D0", Offset = "0x70558D0", VA = "0x1870572D0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int LPNPPNCGIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x70581C0", Offset = "0x70567C0", VA = "0x1870581C0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NEDLHIMBFHA DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x70566E0", Offset = "0x7054CE0", VA = "0x1870566E0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DKCHKAELDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7054D10", Offset = "0x7053310", VA = "0x187054D10", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EPBKCECLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7057640", Offset = "0x7055C40", VA = "0x187057640", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FGJHMHFFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7057780", Offset = "0x7055D80", VA = "0x187057780", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NGDDLDGNNPG EKGEDOLJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x70541D0", Offset = "0x70527D0", VA = "0x1870541D0", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7053630", Offset = "0x7051C30", VA = "0x187053630", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NDGEFNLJMAC IADAJOGNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7056970", Offset = "0x7054F70", VA = "0x187056970", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x70571C0", Offset = "0x70557C0", VA = "0x1870571C0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float LFEBMBIHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7053C00", Offset = "0x7052200", VA = "0x187053C00", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7058230", Offset = "0x7056830", VA = "0x187058230", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 OICLGKNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7056890", Offset = "0x7054E90", VA = "0x187056890", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7056340", Offset = "0x7054940", VA = "0x187056340", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 APKPAJFJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7056D10", Offset = "0x7055310", VA = "0x187056D10", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7057330", Offset = "0x7055930", VA = "0x187057330", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 OMBMCOIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7053770", Offset = "0x7051D70", VA = "0x187053770", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7056B40", Offset = "0x7055140", VA = "0x187056B40", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 KIEFOPGJEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7053AA0", Offset = "0x70520A0", VA = "0x187053AA0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7053960", Offset = "0x7051F60", VA = "0x187053960", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GHDEILMADAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x70542D0", Offset = "0x70528D0", VA = "0x1870542D0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool LOCFOHBDCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7057D70", Offset = "0x7056370", VA = "0x187057D70", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LFLLFNIGFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7057F20", Offset = "0x7056520", VA = "0x187057F20", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool IGFMPAHDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7057220", Offset = "0x7055820", VA = "0x187057220", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 ECNEOFFOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7053F70", Offset = "0x7052570", VA = "0x187053F70", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 CIAHPNLACKA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x70549C0", Offset = "0x7052FC0", VA = "0x1870549C0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MKIELKNCOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7054850", Offset = "0x7052E50", VA = "0x187054850", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x70580E0", Offset = "0x70566E0", VA = "0x1870580E0", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GJPCPFIMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7053690", Offset = "0x7051C90", VA = "0x187053690", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float BFOPBBLOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7057DD0", Offset = "0x70563D0", VA = "0x187057DD0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float PLPACLCBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7055D30", Offset = "0x7054330", VA = "0x187055D30", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7056730", Offset = "0x7054D30", VA = "0x187056730", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 BONJCBHHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7055F00", Offset = "0x7054500", VA = "0x187055F00", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion DCHJEMEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7053C50", Offset = "0x7052250", VA = "0x187053C50", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float MCKCDBHOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x70564C0", Offset = "0x7054AC0", VA = "0x1870564C0", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x70535D0", Offset = "0x7051BD0", VA = "0x1870535D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float AHICHIOPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x70552F0", Offset = "0x70538F0", VA = "0x1870552F0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x70579F0", Offset = "0x7055FF0", VA = "0x1870579F0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool MNNEEEAOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7056420", Offset = "0x7054A20", VA = "0x187056420", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7057AA0", Offset = "0x70560A0", VA = "0x187057AA0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IBJOHPGNLAO HNGJCFHGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x70562F0", Offset = "0x70548F0", VA = "0x1870562F0", Slot = "68")]
		get
		{
			return default(IBJOHPGNLAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x70585E0", Offset = "0x7056BE0", VA = "0x1870585E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool FGABCNCEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7055AA0", Offset = "0x70540A0", VA = "0x187055AA0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform HDNBEKMOJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7056000", Offset = "0x7054600", VA = "0x187056000", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 CNDGMBBGEON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70558B0", Offset = "0x7053EB0", VA = "0x1870558B0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7052EA0", Offset = "0x70514A0", VA = "0x187052EA0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float BMIGAHHGIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7055FE0", Offset = "0x70545E0", VA = "0x187055FE0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7055130", Offset = "0x7053730", VA = "0x187055130", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JNBNNNNEDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x70579D0", Offset = "0x7055FD0", VA = "0x1870579D0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x70551A0", Offset = "0x70537A0", VA = "0x1870551A0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion ICHHJMIFMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7052D40", Offset = "0x7051340", VA = "0x187052D40", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7052830", Offset = "0x7050E30", VA = "0x187052830", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 AFDJHIPPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7056470", Offset = "0x7054A70", VA = "0x187056470", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7055B70", Offset = "0x7054170", VA = "0x187055B70", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JGMGNPPDNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7053530", Offset = "0x7051B30", VA = "0x187053530", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7056510", Offset = "0x7054B10", VA = "0x187056510", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints GPNINJJAFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7052920", Offset = "0x7050F20", VA = "0x187052920", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7053E50", Offset = "0x7052450", VA = "0x187053E50", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool ECMCFIPLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x70574E0", Offset = "0x7055AE0", VA = "0x1870574E0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7053A40", Offset = "0x7052040", VA = "0x187053A40", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode FAGPOIEBDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x70533D0", Offset = "0x70519D0", VA = "0x1870533D0", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7057270", Offset = "0x7055870", VA = "0x187057270", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool JNNIHBFIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7054040", Offset = "0x7052640", VA = "0x187054040", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool HKHDCKOACIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7055460", Offset = "0x7053A60", VA = "0x187055460", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event DODFEPBDCAA CKDHEMDMHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70553B0", Offset = "0x70539B0", VA = "0x1870553B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7053F10", Offset = "0x7052510", VA = "0x187053F10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event DODFEPBDCAA FMNPNFLKHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70527D0", Offset = "0x7050DD0", VA = "0x1870527D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7054C00", Offset = "0x7053200", VA = "0x187054C00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EMMBFAHGHHH FIGMEEFEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7057590", Offset = "0x7055B90", VA = "0x187057590", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7053DF0", Offset = "0x70523F0", VA = "0x187053DF0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event DODFEPBDCAA NCHLAJEIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7054420", Offset = "0x7052A20", VA = "0x187054420", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7052970", Offset = "0x7050F70", VA = "0x187052970", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event DODFEPBDCAA MNNBDDKFMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7054AA0", Offset = "0x70530A0", VA = "0x187054AA0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7056290", Offset = "0x7054890", VA = "0x187056290", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event DODFEPBDCAA PHPNCGGJCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x70565B0", Offset = "0x7054BB0", VA = "0x1870565B0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7056830", Offset = "0x7054E30", VA = "0x187056830", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<JCHEPGBFHGG, JCHEPGBFHGG> ICLOABOBCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7053570", Offset = "0x7051B70", VA = "0x187053570", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7056610", Offset = "0x7054C10", VA = "0x187056610", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DODFEPBDCAA BAKMEOLKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x70547F0", Offset = "0x7052DF0", VA = "0x1870547F0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7055A40", Offset = "0x7054040", VA = "0x187055A40", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DODFEPBDCAA PGIMLAKJANJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7053250", Offset = "0x7051850", VA = "0x187053250", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x70555E0", Offset = "0x7053BE0", VA = "0x1870555E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7058780", Offset = "0x7056D80", VA = "0x187058780")]
	public EMHPEGHHEBE(GameObject FNAHDAKHMJN, RigidbodyEx EKPJLIPGAOG, JPAOGFNLGHI FECFMDJKBKG, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7056ED0", Offset = "0x70554D0", VA = "0x187056ED0", Slot = "136")]
	protected virtual void LINMEKPHOGC(JPAOGFNLGHI FECFMDJKBKG, OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7053D20", Offset = "0x7052320", VA = "0x187053D20", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7057B00", Offset = "0x7056100", VA = "0x187057B00", Slot = "91")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x70552A0", Offset = "0x70538A0", VA = "0x1870552A0", Slot = "92")]
	public void GNBLJPCGDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x70566C0", Offset = "0x7054CC0", VA = "0x1870566C0", Slot = "93")]
	public void KGKMGBPFLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7053B80", Offset = "0x7052180", VA = "0x187053B80")]
	private void CPKGOLOAPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7055AF0", Offset = "0x70540F0", VA = "0x187055AF0", Slot = "30")]
	public NEDLHIMBFHA HOPIJKGEJHM(int PDMMEDBMFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7055340", Offset = "0x7053940", VA = "0x187055340", Slot = "95")]
	public void GOPGAHCPBFG(NEDLHIMBFHA DMNGPNKHPKF, bool ILHLBOIBFME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7055EA0", Offset = "0x70544A0", VA = "0x187055EA0", Slot = "96")]
	public void IINDOLNHFEK(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x70584D0", Offset = "0x7056AD0", VA = "0x1870584D0", Slot = "97")]
	public void PIBPPGOMCPM(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7054320", Offset = "0x7052920", VA = "0x187054320", Slot = "98")]
	public Vector3 FKIDMCMFECG(Vector3 AFHHNEMELLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7054B00", Offset = "0x7053100", VA = "0x187054B00", Slot = "99")]
	public Vector3 GFGIFPFOEJI(Vector3 DEOFHMCEHDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x70552A0", Offset = "0x70538A0", VA = "0x1870552A0", Slot = "100")]
	public void IOAEOFFBJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7054180", Offset = "0x7052780", VA = "0x187054180", Slot = "101")]
	public void FCNIJEHAHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7056010", Offset = "0x7054610", VA = "0x187056010", Slot = "102")]
	public void INDAIBOJKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7057690", Offset = "0x7055C90", VA = "0x187057690", Slot = "103")]
	public void MEPAMPPEPAB(Vector3 ILPBCAOFHFC, Vector3 BNCHFJNCMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7056C20", Offset = "0x7055220", VA = "0x187056C20", Slot = "104")]
	public void LEHHKNIFKIO(Vector3 BGGFFMNEHLJ, Vector3 FMJPBBNAKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x70583F0", Offset = "0x70569F0", VA = "0x1870583F0", Slot = "105")]
	public void PBKOFMIKDPP(Vector3 FGIOIHCCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7058330", Offset = "0x7056930", VA = "0x187058330", Slot = "106")]
	public void PBBOHBCIODG(BGCGFDEOGGE NCBLBBPMLOJ, Vector3 DKAPEBBIDMB, float KEAADBCIBNM, float KAJOLOCGJBD = 8f, float EOMIAHCPFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7056790", Offset = "0x7054D90", VA = "0x187056790", Slot = "107")]
	public void KKKPDELJAFB(LOONDOIDMJL ACLHBCPAOJF, Vector3 NPEDGDPAGMP, float OJAJPGIKPFI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7054C60", Offset = "0x7053260", VA = "0x187054C60", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GHOADAOFGPJ(LOONDOIDMJL ACLHBCPAOJF, Vector3 GLKHDAMNPBA, float JCENBACKGJB = 7f, float OMOGOJBEKDL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7057E20", Offset = "0x7056420", VA = "0x187057E20", Slot = "109")]
	public Vector3 OAKNDJIBJPF(Vector3 DMNGPNKHPKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7058640", Offset = "0x7056C40", VA = "0x187058640", Slot = "110")]
	public Vector3 PNDHLPJJNED(Vector3 DMNGPNKHPKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7056060", Offset = "0x7054660", VA = "0x187056060", Slot = "111")]
	public void JAMHHKKJPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7057470", Offset = "0x7055A70", VA = "0x187057470", Slot = "112")]
	public void LPNDDLMKLAJ(NEDLHIMBFHA BJMEMMNCKAM, object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7056550", Offset = "0x7054B50", VA = "0x187056550", Slot = "113")]
	public void KCDMMALODBE(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x70561B0", Offset = "0x70547B0", VA = "0x1870561B0", Slot = "61")]
	public void JBAAJHJFDLH((Quaternion rot, Vector3 moments) IIIBFELFAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7055DF0", Offset = "0x70543F0", VA = "0x187055DF0", Slot = "114")]
	public void IEFFBHIPMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x70575F0", Offset = "0x7055BF0", VA = "0x1870575F0", Slot = "115")]
	public void MEDPKKHGJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7053850", Offset = "0x7051E50", VA = "0x187053850", Slot = "116")]
	public void CHIKINPOCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x70547A0", Offset = "0x7052DA0", VA = "0x1870547A0", Slot = "117")]
	public bool FNHNLLGKJFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7056670", Offset = "0x7054C70", VA = "0x187056670", Slot = "94")]
	public void KGGOJEGNFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7058530", Offset = "0x7056B30", VA = "0x187058530", Slot = "118")]
	public void PJCEGLNOPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7053EB0", Offset = "0x70524B0", VA = "0x187053EB0", Slot = "119")]
	public void ENNODFFCPIE(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7057C40", Offset = "0x7056240", VA = "0x187057C40", Slot = "120")]
	public void NGLKGJIFNHM(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7055D80", Offset = "0x7054380", VA = "0x187055D80", Slot = "121")]
	public void IDBNMGDDKDI(object NJLOKHEKBBE, bool JJAGHLCDGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x70577D0", Offset = "0x7055DD0", VA = "0x1870577D0", Slot = "122")]
	public void MJIMNGPEBBJ(Vector3 BMIACJNKBNO, Quaternion NBMPFMOAJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7055760", Offset = "0x7053D60", VA = "0x187055760", Slot = "123")]
	public void HJFOIKLCHHN(Vector3 HKPHFAKOJNH, Quaternion FMACAJCCHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7055E40", Offset = "0x7054440", VA = "0x187055E40", Slot = "124")]
	public bool IGOMLAHJKFG(float FEMHAGNJCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7057410", Offset = "0x7055A10", VA = "0x187057410", Slot = "125")]
	public void LPKNGANHBFN(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7058580", Offset = "0x7056B80", VA = "0x187058580", Slot = "126")]
	public void PJLPHAKEAPK(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7057530", Offset = "0x7055B30", VA = "0x187057530", Slot = "127")]
	public void MDCGELNKCEI(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7052DF0", Offset = "0x70513F0", VA = "0x187052DF0", Slot = "128")]
	public void AHFBOIOGAJP(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7055960", Offset = "0x7053F60", VA = "0x187055960", Slot = "129")]
	public void HMDNLCNGJGB(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7053420", Offset = "0x7051A20", VA = "0x187053420", Slot = "130")]
	public void BJLBNHFKMFJ(Vector3 LCIFANAPNML, Vector3 MCPNOOFMAHG, ForceMode MEKJDPKKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7058000", Offset = "0x7056600", VA = "0x187058000", Slot = "131")]
	public void OEFJHMAJKGO(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7056DF0", Offset = "0x70553F0", VA = "0x187056DF0", Slot = "132")]
	public void LHHMNHFNFJN(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7058290", Offset = "0x7056890", VA = "0x187058290", Slot = "133")]
	public bool OOEAELNAIFD(Vector3 GKDEFPHJFPJ, [Out] RaycastHit HBCOBNFHLDN, float KPAPKDHNJLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7055410", Offset = "0x7053A10", VA = "0x187055410", Slot = "134")]
	public void HCLMGPGOGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7058740", Offset = "0x7056D40", VA = "0x187058740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7053300", Offset = "0x7051900", VA = "0x187053300")]
	private void BBJFMLHMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7052F60", Offset = "0x7051560", VA = "0x187052F60")]
	private void ANDJCONFANA(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7053070", Offset = "0x7051670", VA = "0x187053070")]
	private void AOBIIBDMHJC(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7054220", Offset = "0x7052820", VA = "0x187054220")]
	private void FGABLADNDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x70560B0", Offset = "0x70546B0", VA = "0x1870560B0")]
	private void JAPPIPBLBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x70569C0", Offset = "0x7054FC0", VA = "0x1870569C0")]
	private void LBJAOHLDPCJ(NEDLHIMBFHA OPOJDBFACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7057CA0", Offset = "0x70562A0", VA = "0x187057CA0")]
	private void NHLPIPJJKDJ(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7055690", Offset = "0x7053C90", VA = "0x187055690")]
	private void HGMJLGFHANO(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7055BC0", Offset = "0x70541C0", VA = "0x187055BC0")]
	private void IAHBGMIPPBG(DKAMHPILGME PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7054D70", Offset = "0x7053370", VA = "0x187054D70", Slot = "141")]
	protected virtual void GKNDIFABEGC(DKAMHPILGME CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7054480", Offset = "0x7052A80", VA = "0x187054480")]
	protected void FMBEKIKICEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x70529D0", Offset = "0x7050FD0", VA = "0x1870529D0")]
	protected void AGKHNCKMFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x70538A0", Offset = "0x7051EA0", VA = "0x1870538A0", Slot = "142")]
	protected virtual IDisposable CHLAALEDCFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class LACLOPGCODA
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7064090", Offset = "0x7062690", VA = "0x187064090")]
	public static NEDLHIMBFHA ENBJNCFLKCL(this NEDLHIMBFHA CGLBFHOJGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x70641A0", Offset = "0x70627A0", VA = "0x1870641A0")]
	public static bool MJBNJAKHIKC(this NEDLHIMBFHA CGLBFHOJGON, NEDLHIMBFHA FAGAAIEDMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7064010", Offset = "0x7062610", VA = "0x187064010")]
	public static bool CBOAFBLLKJM(this NEDLHIMBFHA CGLBFHOJGON, NEDLHIMBFHA MICELFBICGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7064150", Offset = "0x7062750", VA = "0x187064150")]
	public static DKAMHPILGME FCCCOENEHLL(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7063FA0", Offset = "0x70625A0", VA = "0x187063FA0")]
	public static EMHPEGHHEBE AOPCLNBAFDA(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NHMAMBFCNKO : MHHGMGMNMAL
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7065260", Offset = "0x7063860", VA = "0x187065260", Slot = "19")]
	public NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC, JPAOGFNLGHI FECFMDJKBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "4")]
	public BPFICMICDDF NEMOGAGJFEG(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "5")]
	public OOMGCMOCNNJ APFNIHDKJED(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "6")]
	public EEPCFGAOBEG ODPNFDPACEJ(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "7")]
	public HBFKHMPMKCA ENAEBMIAFOP(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "8")]
	public DPEIJGMHMGN HAACJBGGLAL(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "9")]
	public BEBJCJIMNJG CFMONIKJDDN(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "10")]
	public JNGCKGHGGBC CCPIPEFBMHD(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "11")]
	public LFAJNHFGEFG FBKJJFBIIJB(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "12")]
	public KGKFOMOAKIB GEOPJFIJEEA(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "13")]
	public AOGEFGJAHOL BFOCJGNGGIO(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	public PEMHMIPEMLE JFEFFOPAFPA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	public BOADBJPKJIN IEKOOFDMOME(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	public HCGDOLHJAFI BIKCGNCHDEO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	public LDOAKDKELFE AELEGHGNLDJ(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	public NPLECDBNCMJ FMPIPOELDLO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public NHMAMBFCNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "14")]
	private PEMHMIPEMLE HDNINCJAGDE(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "15")]
	private BOADBJPKJIN BFCMBNDDEFA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "16")]
	private HCGDOLHJAFI JAHJOFNJBFM(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "17")]
	private LDOAKDKELFE EBLOANBKALN(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "18")]
	private NPLECDBNCMJ DOMNBJAHCMP(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FCONBELFMBI(typeof(MHHGMGMNMAL), new string[] { })]
public class EBBKMLJMEGJ : MHHGMGMNMAL, HJHDLHOJDKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly MHHGMGMNMAL PJOLNJENKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MHHGMGMNMAL OHCOIAHKOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MEJIGCPJODJ BJPJHFIPEHA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private MHHGMGMNMAL JNIDBCCOBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7052580", Offset = "0x7050B80", VA = "0x187052580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7052530", Offset = "0x7050B30", VA = "0x187052530", Slot = "20")]
	public void InitReferences(DPIICBKDOMF OOLAHKJIFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x70525E0", Offset = "0x7050BE0", VA = "0x1870525E0", Slot = "4")]
	public BPFICMICDDF NEMOGAGJFEG(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7051C90", Offset = "0x7050290", VA = "0x187051C90", Slot = "5")]
	public OOMGCMOCNNJ APFNIHDKJED(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7052680", Offset = "0x7050C80", VA = "0x187052680", Slot = "6")]
	public EEPCFGAOBEG ODPNFDPACEJ(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7052120", Offset = "0x7050720", VA = "0x187052120", Slot = "7")]
	public HBFKHMPMKCA ENAEBMIAFOP(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7052300", Offset = "0x7050900", VA = "0x187052300", Slot = "8")]
	public DPEIJGMHMGN HAACJBGGLAL(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7051FD0", Offset = "0x70505D0", VA = "0x187051FD0", Slot = "9")]
	public BEBJCJIMNJG CFMONIKJDDN(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7051F30", Offset = "0x7050530", VA = "0x187051F30", Slot = "10")]
	public JNGCKGHGGBC CCPIPEFBMHD(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x70521C0", Offset = "0x70507C0", VA = "0x1870521C0", Slot = "11")]
	public LFAJNHFGEFG FBKJJFBIIJB(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7052260", Offset = "0x7050860", VA = "0x187052260", Slot = "12")]
	public KGKFOMOAKIB GEOPJFIJEEA(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7051DE0", Offset = "0x70503E0", VA = "0x187051DE0", Slot = "13")]
	public AOGEFGJAHOL BFOCJGNGGIO(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x70523A0", Offset = "0x70509A0", VA = "0x1870523A0")]
	public PEMHMIPEMLE JFEFFOPAFPA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7051D30", Offset = "0x7050330", VA = "0x187051D30")]
	public BOADBJPKJIN IEKOOFDMOME(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7051E80", Offset = "0x7050480", VA = "0x187051E80")]
	public HCGDOLHJAFI BIKCGNCHDEO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7051BE0", Offset = "0x70501E0", VA = "0x187051BE0")]
	public LDOAKDKELFE AELEGHGNLDJ(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7052070", Offset = "0x7050670", VA = "0x187052070")]
	public NPLECDBNCMJ FMPIPOELDLO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7052450", Offset = "0x7050A50", VA = "0x187052450", Slot = "19")]
	public NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC, JPAOGFNLGHI FECFMDJKBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7052720", Offset = "0x7050D20", VA = "0x187052720")]
	public EBBKMLJMEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x70523A0", Offset = "0x70509A0", VA = "0x1870523A0", Slot = "14")]
	private PEMHMIPEMLE HDNINCJAGDE(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7051D30", Offset = "0x7050330", VA = "0x187051D30", Slot = "15")]
	private BOADBJPKJIN BFCMBNDDEFA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7051E80", Offset = "0x7050480", VA = "0x187051E80", Slot = "16")]
	private HCGDOLHJAFI JAHJOFNJBFM(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7051BE0", Offset = "0x70501E0", VA = "0x187051BE0", Slot = "17")]
	private LDOAKDKELFE EBLOANBKALN(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7052070", Offset = "0x7050670", VA = "0x187052070", Slot = "18")]
	private NPLECDBNCMJ DOMNBJAHCMP(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IPFNMBOKKPD : BPFICMICDDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNDDDBCIJKM(NEDLHIMBFHA CGLBFHOJGON);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCLEIOPKKPI(NEDLHIMBFHA CGLBFHOJGON);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMNNLPOILFH(NEDLHIMBFHA OPOJDBFACCG);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IGPKNJGLDHP(NEDLHIMBFHA OPOJDBFACCG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FLPOFOKIPCL : EEPCFGAOBEG
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PGFMDEOJING<NEDLHIMBFHA> DAOFNNALPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	NEDLHIMBFHA LPDBIBEIEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OOMNPOLINGE : LDOAKDKELFE
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JCJCANHDAFE(Rigidbody NNBJBGMMJBP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CIGIFCAIBON : BOADBJPKJIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView IOGLFDHEHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class OICDGGOIHPK : KGKFOMOAKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private CollisionDetectionMode ODGJIOBOIPA;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7059160", Offset = "0x7057760", VA = "0x187059160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode FAGPOIEBDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x70655D0", Offset = "0x7063BD0", VA = "0x1870655D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x70656F0", Offset = "0x7063CF0", VA = "0x1870656F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7059EC0", Offset = "0x70584C0", VA = "0x187059EC0")]
	public OICDGGOIHPK(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7065760", Offset = "0x7063D60", VA = "0x187065760", Slot = "6")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x70659A0", Offset = "0x7063FA0", VA = "0x1870659A0", Slot = "9")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7065870", Offset = "0x7063E70", VA = "0x187065870", Slot = "7")]
	public void NLCGPHBEBAL(bool BODOKGBBLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x70656E0", Offset = "0x7063CE0", VA = "0x1870656E0", Slot = "8")]
	public void LKFBMILACJF(bool BODOKGBBLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7065A20", Offset = "0x7064020", VA = "0x187065A20", Slot = "10")]
	public bool OOEAELNAIFD(Vector3 GKDEFPHJFPJ, [Out] RaycastHit HBCOBNFHLDN, float KPAPKDHNJLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7065880", Offset = "0x7063E80", VA = "0x187065880")]
	private void NPBAABHAALB(bool BODOKGBBLOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KAAEHEAEDNI : BEBJCJIMNJG, IDisposable, CBACEKMNGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IBJOHPGNLAO OABKGOOJIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private PKJGAMOJFGP NMLANPMNNNF;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public IBJOHPGNLAO HNGJCFHGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x70639C0", Offset = "0x7061FC0", VA = "0x1870639C0", Slot = "6")]
		get
		{
			return default(IBJOHPGNLAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7063E40", Offset = "0x7062440", VA = "0x187063E40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform PGMKLOLIEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7063BB0", Offset = "0x70621B0", VA = "0x187063BB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JCHEPGBFHGG, JCHEPGBFHGG> ICLOABOBCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x70638C0", Offset = "0x7061EC0", VA = "0x1870638C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7063B00", Offset = "0x7062100", VA = "0x187063B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7063F10", Offset = "0x7062510", VA = "0x187063F10")]
	public KAAEHEAEDNI(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7063BD0", Offset = "0x70621D0", VA = "0x187063BD0", Slot = "8")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7063970", Offset = "0x7061F70", VA = "0x187063970", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x9AAB70", Offset = "0x9A9170", VA = "0x1809AAB70", Slot = "11")]
	private void FLAOBABNPEI(JCHEPGBFHGG OAIAKECGFEC, JCHEPGBFHGG EFHFFPHCNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "12")]
	private void GIAGPCAHCGF(bool KBMCAOCOMKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class INBDIBJPMDO : MHHGMGMNMAL
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x705D7D0", Offset = "0x705BDD0", VA = "0x18705D7D0", Slot = "4")]
	public BPFICMICDDF NEMOGAGJFEG(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x705CB30", Offset = "0x705B130", VA = "0x18705CB30", Slot = "5")]
	public OOMGCMOCNNJ APFNIHDKJED(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x705D8C0", Offset = "0x705BEC0", VA = "0x18705D8C0", Slot = "6")]
	public EEPCFGAOBEG ODPNFDPACEJ(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x705D2A0", Offset = "0x705B8A0", VA = "0x18705D2A0", Slot = "7")]
	public HBFKHMPMKCA ENAEBMIAFOP(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x705D4A0", Offset = "0x705BAA0", VA = "0x18705D4A0", Slot = "8")]
	public DPEIJGMHMGN HAACJBGGLAL(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x705D0F0", Offset = "0x705B6F0", VA = "0x18705D0F0", Slot = "9")]
	public BEBJCJIMNJG CFMONIKJDDN(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x705CFD0", Offset = "0x705B5D0", VA = "0x18705CFD0", Slot = "10")]
	public JNGCKGHGGBC CCPIPEFBMHD(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x705D320", Offset = "0x705B920", VA = "0x18705D320", Slot = "11")]
	public LFAJNHFGEFG FBKJJFBIIJB(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x705D3E0", Offset = "0x705B9E0", VA = "0x18705D3E0", Slot = "12")]
	public KGKFOMOAKIB GEOPJFIJEEA(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x705CDE0", Offset = "0x705B3E0", VA = "0x18705CDE0", Slot = "13")]
	public AOGEFGJAHOL BFOCJGNGGIO(NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x705D570", Offset = "0x705BB70", VA = "0x18705D570")]
	public PEMHMIPEMLE JFEFFOPAFPA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x705CC50", Offset = "0x705B250", VA = "0x18705CC50")]
	public BOADBJPKJIN IEKOOFDMOME(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x705CEA0", Offset = "0x705B4A0", VA = "0x18705CEA0")]
	public HCGDOLHJAFI BIKCGNCHDEO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x705C9A0", Offset = "0x705AFA0", VA = "0x18705C9A0")]
	public LDOAKDKELFE AELEGHGNLDJ(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x705D1C0", Offset = "0x705B7C0", VA = "0x18705D1C0")]
	public NPLECDBNCMJ FMPIPOELDLO(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x705D6B0", Offset = "0x705BCB0", VA = "0x18705D6B0", Slot = "19")]
	public NEDLHIMBFHA HEDOHGMLPBJ(RigidbodyEx CGLBFHOJGON, OGPNDBNBFDI MMDLBEBNCGC, JPAOGFNLGHI FECFMDJKBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public INBDIBJPMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x705D570", Offset = "0x705BB70", VA = "0x18705D570", Slot = "14")]
	private PEMHMIPEMLE HDNINCJAGDE(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x705CC50", Offset = "0x705B250", VA = "0x18705CC50", Slot = "15")]
	private BOADBJPKJIN BFCMBNDDEFA(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x705CEA0", Offset = "0x705B4A0", VA = "0x18705CEA0", Slot = "16")]
	private HCGDOLHJAFI JAHJOFNJBFM(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x705C9A0", Offset = "0x705AFA0", VA = "0x18705C9A0", Slot = "17")]
	private LDOAKDKELFE EBLOANBKALN(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x705D1C0", Offset = "0x705B7C0", VA = "0x18705D1C0", Slot = "18")]
	private NPLECDBNCMJ DOMNBJAHCMP(NEDLHIMBFHA AKLCDEBLEOF, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class FLLNFGFFIBD : LFAJNHFGEFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7059160", Offset = "0x7057760", VA = "0x187059160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool FGABCNCEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7059590", Offset = "0x7057B90", VA = "0x187059590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool DKCHKAELDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7058A70", Offset = "0x7057070", VA = "0x187058A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7059D00", Offset = "0x7058300", VA = "0x187059D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7059EC0", Offset = "0x70584C0", VA = "0x187059EC0")]
	public FLLNFGFFIBD(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7059430", Offset = "0x7057A30", VA = "0x187059430", Slot = "4")]
	public void HMDNLCNGJGB(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x70595E0", Offset = "0x7057BE0", VA = "0x1870595E0")]
	private void IOKBKKLLHGD(Vector3 LCIFANAPNML, ForceMode MEKJDPKKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x70591B0", Offset = "0x70577B0", VA = "0x1870591B0", Slot = "5")]
	public void BJLBNHFKMFJ(Vector3 LCIFANAPNML, Vector3 MCPNOOFMAHG, ForceMode MEKJDPKKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7059D60", Offset = "0x7058360", VA = "0x187059D60", Slot = "6")]
	public void OEFJHMAJKGO(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7059840", Offset = "0x7057E40", VA = "0x187059840")]
	private void KOCJKKACNDA(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7059AA0", Offset = "0x70580A0", VA = "0x187059AA0", Slot = "7")]
	public void LHHMNHFNFJN(Vector3 IGNIGENLOEO, ForceMode MEKJDPKKBKK = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class OJFOIHOOHJD : AOGEFGJAHOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private bool BGJPPMBFBLC;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MNNEEEAOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7065BF0", Offset = "0x70641F0", VA = "0x187065BF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7059EC0", Offset = "0x70584C0", VA = "0x187059EC0")]
	public OJFOIHOOHJD(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7065D00", Offset = "0x7064300", VA = "0x187065D00", Slot = "6")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7065B80", Offset = "0x7064180", VA = "0x187065B80", Slot = "7")]
	public void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class JKGIDOEFOHD : IPFNMBOKKPD, BPFICMICDDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NEDLHIMBFHA CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<NEDLHIMBFHA> BCCNBOKDCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private NEDLHIMBFHA OPJBDKMKMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NEDLHIMBFHA PPEEAFEPIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform NGHNAFJJNGM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7061740", Offset = "0x705FD40", VA = "0x187061740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x86FA50", Offset = "0x86E050", VA = "0x18086FA50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7062750", Offset = "0x7060D50", VA = "0x187062750", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public NEDLHIMBFHA DBCKFKNELBO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86ADD0", Offset = "0x8693D0", VA = "0x18086ADD0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<NEDLHIMBFHA> HDNHCPHIDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x86AE10", Offset = "0x869410", VA = "0x18086AE10", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DODFEPBDCAA CKDHEMDMHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7061E60", Offset = "0x7060460", VA = "0x187061E60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x70614F0", Offset = "0x705FAF0", VA = "0x1870614F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DODFEPBDCAA FMNPNFLKHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x70610A0", Offset = "0x705F6A0", VA = "0x1870610A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x70617A0", Offset = "0x705FDA0", VA = "0x1870617A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EMMBFAHGHHH FIGMEEFEPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7062760", Offset = "0x7060D60", VA = "0x187062760", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7061450", Offset = "0x705FA50", VA = "0x187061450", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ECFEFFJNHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7062210", Offset = "0x7060810", VA = "0x187062210", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7062D20", Offset = "0x7061320", VA = "0x187062D20", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EJLMKDKIDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x70616A0", Offset = "0x705FCA0", VA = "0x1870616A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x70628B0", Offset = "0x7060EB0", VA = "0x1870628B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<NEDLHIMBFHA> HIAGGJEOEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x70626A0", Offset = "0x7060CA0", VA = "0x1870626A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7062E00", Offset = "0x7061400", VA = "0x187062E00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<NEDLHIMBFHA> LBMFGALAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7062B30", Offset = "0x7061130", VA = "0x187062B30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x70625F0", Offset = "0x7060BF0", VA = "0x1870625F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action DMGNOBBCOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7061F00", Offset = "0x7060500", VA = "0x187061F00", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x70611E0", Offset = "0x705F7E0", VA = "0x1870611E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<NEDLHIMBFHA> ALNIDANKEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7062800", Offset = "0x7060E00", VA = "0x187062800", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7062950", Offset = "0x7060F50", VA = "0x187062950", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7062EB0", Offset = "0x70614B0", VA = "0x187062EB0")]
	public JKGIDOEFOHD(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x70613B0", Offset = "0x705F9B0", VA = "0x1870613B0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x70618E0", Offset = "0x705FEE0", VA = "0x1870618E0", Slot = "30")]
	public void GOPGAHCPBFG(NEDLHIMBFHA MBKJJMHGOEE, bool ILHLBOIBFME = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x7061FA0", Offset = "0x70605A0", VA = "0x187061FA0", Slot = "6")]
	public void HMNNLPOILFH(NEDLHIMBFHA OPOJDBFACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x7062370", Offset = "0x7060970", VA = "0x187062370", Slot = "7")]
	public void IGPKNJGLDHP(NEDLHIMBFHA OPOJDBFACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7061590", Offset = "0x705FB90", VA = "0x187061590", Slot = "4")]
	public void FNDDDBCIJKM(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7061140", Offset = "0x705F740", VA = "0x187061140", Slot = "5")]
	public void BCLEIOPKKPI(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7061840", Offset = "0x705FE40", VA = "0x187061840")]
	private void GIKHBDGNGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7062DC0", Offset = "0x70613C0", VA = "0x187062DC0")]
	private void PKLJEDEGLBF(NEDLHIMBFHA OPOJDBFACCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7062BE0", Offset = "0x70611E0", VA = "0x187062BE0")]
	private void PCBBPIAKIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7062A00", Offset = "0x7061000", VA = "0x187062A00")]
	private void OEPHADIHOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x7061280", Offset = "0x705F880", VA = "0x187061280")]
	private void CCJGEBFDPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x70622B0", Offset = "0x70608B0", VA = "0x1870622B0")]
	[CompilerGenerated]
	private object ICLEEJIFENF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OOPCODCPMJB
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7065D30", Offset = "0x7064330", VA = "0x187065D30")]
	public static IPFNMBOKKPD DNOCCFDMNNN(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class ABJMFHFGPHI : FLPOFOKIPCL, EEPCFGAOBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly PGFMDEOJING<NEDLHIMBFHA> GHCLCCEICFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool IDHLJGIGKDA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PGFMDEOJING<NEDLHIMBFHA> DAOFNNALPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 ECNEOFFOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7050760", Offset = "0x704ED60", VA = "0x187050760", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 CIAHPNLACKA
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7050790", Offset = "0x704ED90", VA = "0x187050790", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 OMBMCOIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x70502E0", Offset = "0x704E8E0", VA = "0x1870502E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public NEDLHIMBFHA LPDBIBEIEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7050DB0", Offset = "0x704F3B0", VA = "0x187050DB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7050E60", Offset = "0x704F460", VA = "0x187050E60")]
	public ABJMFHFGPHI(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x70509B0", Offset = "0x704EFB0", VA = "0x1870509B0", Slot = "8")]
	public void KBBFJLMDPMI(NEDLHIMBFHA PPEEAFEPIIK, object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7050950", Offset = "0x704EF50", VA = "0x187050950", Slot = "9")]
	public void HJFHIFELABM(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x70503D0", Offset = "0x704E9D0", VA = "0x1870503D0")]
	private Vector3 CIEAJGFECBB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7050A20", Offset = "0x704F020", VA = "0x187050A20")]
	private void OABFINALIPK(NEDLHIMBFHA MMODMOOFBHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class HDKMEKIGDHB
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7059F50", Offset = "0x7058550", VA = "0x187059F50")]
	public static FLPOFOKIPCL KDDFKCCAHDL(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class ICGBDIKHNIC : OOMNPOLINGE, LDOAKDKELFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OverridableVector3 ALIDCNJFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 JMBLMEINHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private float BNMOOCAIDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float MAKICPOEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Vector3 CLNDGLKKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3? EDBKCELFBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Quaternion? OPDBCGCJIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool NNCJBHONLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool FMEODJDGCON;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MKIELKNCOAF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xDAD2E0", Offset = "0xDAB8E0", VA = "0x180DAD2E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x705A560", Offset = "0x7058B60", VA = "0x18705A560", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 GJPCPFIMBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x705A120", Offset = "0x7058720", VA = "0x18705A120", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BFOPBBLOEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8F7580", Offset = "0x8F5B80", VA = "0x1808F7580", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x705A010", Offset = "0x7058610", VA = "0x18705A010")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float PLPACLCBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8F7690", Offset = "0x8F5C90", VA = "0x1808F7690", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x705ADB0", Offset = "0x70593B0", VA = "0x18705ADB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 BONJCBHHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x705B200", Offset = "0x7059800", VA = "0x18705B200", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion DCHJEMEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x705A610", Offset = "0x7058C10", VA = "0x18705A610", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7051090", Offset = "0x704F690", VA = "0x187051090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event DODFEPBDCAA COLLCBECGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x705C7A0", Offset = "0x705ADA0", VA = "0x18705C7A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x705A4C0", Offset = "0x7058AC0", VA = "0x18705A4C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x705C840", Offset = "0x705AE40", VA = "0x18705C840")]
	public ICGBDIKHNIC(NEDLHIMBFHA CGLBFHOJGON, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x705AE60", Offset = "0x7059460", VA = "0x18705AE60", Slot = "17")]
	public void IEFFBHIPMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x705C440", Offset = "0x705AA40", VA = "0x18705C440", Slot = "16")]
	public void MEDPKKHGJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x705C6C0", Offset = "0x705ACC0", VA = "0x18705C6C0", Slot = "19")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x705B010", Offset = "0x7059610", VA = "0x18705B010", Slot = "20")]
	public void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x705A220", Offset = "0x7058820", VA = "0x18705A220", Slot = "18")]
	public void CHIKINPOCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x705A910", Offset = "0x7058F10", VA = "0x18705A910", Slot = "21")]
	public void HCLMGPGOGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x705A560", Offset = "0x7058B60", VA = "0x18705A560")]
	private void DHAHCMFCJKA(Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x705A3D0", Offset = "0x70589D0", VA = "0x18705A3D0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CPBFNAMLNKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x705A010", Offset = "0x7058610", VA = "0x18705A010")]
	private void KHAGOEDLDDJ(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x705ADB0", Offset = "0x70593B0", VA = "0x18705ADB0")]
	private void HFGLBJBGBJO(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x705C520", Offset = "0x705AB20", VA = "0x18705C520")]
	private Vector3 MJDMHAGDHPI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x705B390", Offset = "0x7059990", VA = "0x18705B390", Slot = "15")]
	public void JBAAJHJFDLH((Quaternion rot, Vector3 moments) IIIBFELFAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x705A790", Offset = "0x7058D90", VA = "0x18705A790")]
	private Quaternion EEIFICBGIMH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x705B5C0", Offset = "0x7059BC0", VA = "0x18705B5C0")]
	public void JCJCANHDAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x705B690", Offset = "0x7059C90", VA = "0x18705B690", Slot = "4")]
	public (float, Vector3) JCJCANHDAFE(Rigidbody NNBJBGMMJBP)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class CGLIAEEDHEM
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7050FD0", Offset = "0x704F5D0", VA = "0x187050FD0")]
	public static OOMNPOLINGE OMNGJGJAOAD(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JNAPGLJLIKI : HCGDOLHJAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NJLEKBCHGOF MFAFHHNGEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly JLMNFBGGGIJ DDPEKAFJBCD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool FIHBIOIAPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xF33810", Offset = "0xF31E10", VA = "0x180F33810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JLMNFBGGGIJ OMLGDEPGPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30", Slot = "11")]
		get
		{
			return default(JLMNFBGGGIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x70637C0", Offset = "0x7061DC0", VA = "0x1870637C0")]
	public JNAPGLJLIKI(NEDLHIMBFHA CGLBFHOJGON, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7063540", Offset = "0x7061B40", VA = "0x187063540", Slot = "4")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7063330", Offset = "0x7061930", VA = "0x187063330")]
	private bool COHABFKDLKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7063300", Offset = "0x7061900", VA = "0x187063300", Slot = "5")]
	public void COEBEFFEAKD(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x70633D0", Offset = "0x70619D0", VA = "0x1870633D0", Slot = "6")]
	public void DGOAJCIACGL(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7063400", Offset = "0x7061A00", VA = "0x187063400", Slot = "9")]
	public void LLMMINMJFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x70631A0", Offset = "0x70617A0", VA = "0x1870631A0")]
	private void BJDDGJKKKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7063610", Offset = "0x7061C10", VA = "0x187063610")]
	private void NFGBHLJBJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7063780", Offset = "0x7061D80", VA = "0x187063780", Slot = "8")]
	public void NIIIOFAIACM(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x70632C0", Offset = "0x70618C0", VA = "0x1870632C0", Slot = "7")]
	public void CEGLBFEKGEH(NEDLHIMBFHA CGLBFHOJGON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AAHBFGMELPJ : JNGCKGHGGBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NJLEKBCHGOF FFKGGKNGOOF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool FGABCNCEAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x704FF30", Offset = "0x704E530", VA = "0x18704FF30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DODFEPBDCAA BAKMEOLKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x704FDF0", Offset = "0x704E3F0", VA = "0x18704FDF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x704FE90", Offset = "0x704E490", VA = "0x18704FE90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x70501F0", Offset = "0x704E7F0", VA = "0x1870501F0")]
	public AAHBFGMELPJ(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x704FDE0", Offset = "0x704E3E0", VA = "0x18704FDE0", Slot = "7")]
	public void ENNODFFCPIE(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7050160", Offset = "0x704E760", VA = "0x187050160", Slot = "8")]
	public void NGLKGJIFNHM(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x704FFE0", Offset = "0x704E5E0", VA = "0x18704FFE0", Slot = "9")]
	public void IDBNMGDDKDI(object NJLOKHEKBBE, bool JJAGHLCDGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7050120", Offset = "0x704E720", VA = "0x187050120", Slot = "12")]
	public void IJLOAEFLHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7050170", Offset = "0x704E770", VA = "0x187050170", Slot = "10")]
	public void OJKIAHPLGDF(Rigidbody OBCIJMKFLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x70500F0", Offset = "0x704E6F0", VA = "0x1870500F0", Slot = "11")]
	public void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class MPHJDHDLODP : CIGIFCAIBON, BOADBJPKJIN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private PhotonView OOONIGNCAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool MJMKHBKKOON;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView IOGLFDHEHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool EPBKCECLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7064E50", Offset = "0x7063450", VA = "0x187064E50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool FGJHMHFFMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DODFEPBDCAA NCHLAJEIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7064980", Offset = "0x7062F80", VA = "0x187064980", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7064570", Offset = "0x7062B70", VA = "0x187064570", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7065110", Offset = "0x7063710", VA = "0x187065110")]
	public MPHJDHDLODP(NEDLHIMBFHA CGLBFHOJGON, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7064E70", Offset = "0x7063470", VA = "0x187064E70", Slot = "9")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7064880", Offset = "0x7062E80", VA = "0x187064880", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x7064FA0", Offset = "0x70635A0", VA = "0x187064FA0", Slot = "10")]
	public void NHLPIPJJKDJ(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7064A20", Offset = "0x7063020", VA = "0x187064A20", Slot = "11")]
	public void HGMJLGFHANO(NEDLHIMBFHA PPEEAFEPIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x7064CE0", Offset = "0x70632E0", VA = "0x187064CE0")]
	private void MAAFICBCBAA(PhotonView ONDEHADLLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7064B90", Offset = "0x7063190", VA = "0x187064B90")]
	private void LAAGPLOFFDP(DKAMHPILGME LOAINBDIIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7064610", Offset = "0x7062C10", VA = "0x187064610")]
	private void ALJIDBLHPIO(PhotonView NIHFLLBNBHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class PMOCHIHLGLB
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7065DF0", Offset = "0x70643F0", VA = "0x187065DF0")]
	public static CIGIFCAIBON KEHEDMDHAPN(this NEDLHIMBFHA AKLCDEBLEOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JLAOJNJGFGK : NPLECDBNCMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private RigidbodyConstraints OMMLCMDJCGO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool ECMCFIPLAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD2C6E0", Offset = "0xD2ACE0", VA = "0x180D2C6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x45320B0", Offset = "0x45306B0", VA = "0x1845320B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GBBCHGKLNND
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF874E0", Offset = "0xF85AE0", VA = "0x180F874E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x45320A0", Offset = "0x45306A0", VA = "0x1845320A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints GPNINJJAFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7062F70", Offset = "0x7061570", VA = "0x187062F70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x7063100", Offset = "0x7061700", VA = "0x187063100")]
	public JLAOJNJGFGK(NEDLHIMBFHA CGLBFHOJGON, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x70630D0", Offset = "0x70616D0", VA = "0x1870630D0", Slot = "9")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x70630A0", Offset = "0x70616A0", VA = "0x1870630A0", Slot = "10")]
	public void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NKBCOBMONGN : HBFKHMPMKCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NEDLHIMBFHA CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private float PEIIDLLEFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float ODBDGLOKCLK;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float MCKCDBHOEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F7710", Offset = "0x8F5D10", VA = "0x1808F7710", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7065300", Offset = "0x7063900", VA = "0x187065300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float AHICHIOPFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8F76D0", Offset = "0x8F5CD0", VA = "0x1808F76D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7065470", Offset = "0x7063A70", VA = "0x187065470", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7065590", Offset = "0x7063B90", VA = "0x187065590")]
	public NKBCOBMONGN(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7065540", Offset = "0x7063B40", VA = "0x187065540", Slot = "8")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x70653D0", Offset = "0x70639D0", VA = "0x1870653D0", Slot = "9")]
	public void IGCNIEIIGPJ(Rigidbody GEAHMGKGGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DMCAMDOHLGF : DPEIJGMHMGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool MEJOOPDCJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool DHCECLMOMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int HDOACAEGJHA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7051090", Offset = "0x704F690", VA = "0x187051090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool JNNIHBFIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7051290", Offset = "0x704F890", VA = "0x187051290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private NEDLHIMBFHA GPPJHNPGLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x70519C0", Offset = "0x704FFC0", VA = "0x1870519C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool DKCHKAELDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7051400", Offset = "0x704FA00", VA = "0x187051400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event DODFEPBDCAA PHPNCGGJCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7051460", Offset = "0x704FA60", VA = "0x187051460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x70515A0", Offset = "0x704FBA0", VA = "0x1870515A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7051B50", Offset = "0x7050150", VA = "0x187051B50")]
	public DMCAMDOHLGF(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7051A20", Offset = "0x7050020", VA = "0x187051A20", Slot = "6")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x70519B0", Offset = "0x704FFB0", VA = "0x1870519B0", Slot = "8")]
	public void LPJAMOAJNBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x70512B0", Offset = "0x704F8B0", VA = "0x1870512B0", Slot = "7")]
	public bool FNHNLLGKJFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7051500", Offset = "0x704FB00", VA = "0x187051500", Slot = "9")]
	public void KGGOJEGNFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7051AB0", Offset = "0x70500B0", VA = "0x187051AB0", Slot = "11")]
	public void PJCEGLNOPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x70510E0", Offset = "0x704F6E0", VA = "0x1870510E0", Slot = "10")]
	public void BHPJJEGPHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7051640", Offset = "0x704FC40", VA = "0x187051640")]
	private bool LFPAHPFEKDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7051820", Offset = "0x704FE20", VA = "0x187051820")]
	private void LLHFKDJGGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FLIELHPJEGP : PEMHMIPEMLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NJLEKBCHGOF MHBNCGIBLLG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody JIDGAHELAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool DKCHKAELDKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7058A70", Offset = "0x7057070", VA = "0x187058A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KPKNODMHPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xF33810", Offset = "0xF31E10", VA = "0x180F33810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7059050", Offset = "0x7057650", VA = "0x187059050")]
	public FLIELHPJEGP(NEDLHIMBFHA CGLBFHOJGON, [In] OGPNDBNBFDI MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7058E30", Offset = "0x7057430", VA = "0x187058E30", Slot = "5")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7058AD0", Offset = "0x70570D0", VA = "0x187058AD0", Slot = "7")]
	public void MDCGELNKCEI(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7058A40", Offset = "0x7057040", VA = "0x187058A40", Slot = "8")]
	public void AHFBOIOGAJP(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7058B00", Offset = "0x7057100", VA = "0x187058B00", Slot = "9")]
	public void MMJINEHNIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7058850", Offset = "0x7056E50", VA = "0x187058850", Slot = "10")]
	public void ADNCMNNGAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7058ED0", Offset = "0x70574D0", VA = "0x187058ED0", Slot = "11")]
	public void PHKCICICPCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class JFCHOFNFLEP : OOMGCMOCNNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly EMHPEGHHEBE CGLBFHOJGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NJLEKBCHGOF JHCEHCMALCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private float LKELGKDBFGG;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NGDDLDGNNPG EKGEDOLJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x868280", Offset = "0x866880", VA = "0x180868280", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public NDGEFNLJMAC IADAJOGNIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 OMBMCOIBKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x705D9F0", Offset = "0x705BFF0", VA = "0x18705D9F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x705FA10", Offset = "0x705E010", VA = "0x18705FA10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 OICLGKNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x705F8F0", Offset = "0x705DEF0", VA = "0x18705F8F0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x705F630", Offset = "0x705DC30", VA = "0x18705F630", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 KIEFOPGJEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x705DC10", Offset = "0x705C210", VA = "0x18705DC10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x705DB50", Offset = "0x705C150", VA = "0x18705DB50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 APKPAJFJKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x705FB30", Offset = "0x705E130", VA = "0x18705FB30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x705FC60", Offset = "0x705E260", VA = "0x18705FC60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float LFEBMBIHGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8F75F0", Offset = "0x8F5BF0", VA = "0x1808F75F0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x705FED0", Offset = "0x705E4D0", VA = "0x18705FED0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool IGFMPAHDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1913220", Offset = "0x1911820", VA = "0x181913220", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private LFAJNHFGEFG GPACHBCKGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6884800", Offset = "0x6882E00", VA = "0x186884800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool JNNIHBFIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x705E5D0", Offset = "0x705CBD0", VA = "0x18705E5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7060FB0", Offset = "0x705F5B0", VA = "0x187060FB0")]
	public JFCHOFNFLEP(NEDLHIMBFHA CGLBFHOJGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x705F3F0", Offset = "0x705D9F0", VA = "0x18705F3F0", Slot = "19")]
	public void NDMDMOBKCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x705DFC0", Offset = "0x705C5C0", VA = "0x18705DFC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x70601E0", Offset = "0x705E7E0", VA = "0x1870601E0", Slot = "28")]
	public void OJKIAHPLGDF(Rigidbody GEAHMGKGGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD681A0", Offset = "0xD667A0", VA = "0x180D681A0", Slot = "20")]
	public void AJBMGJOCMCN(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD681C0", Offset = "0xD667C0", VA = "0x180D681C0", Slot = "30")]
	public void MLDNMEMBMEO(object NJLOKHEKBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x705E650", Offset = "0x705CC50", VA = "0x18705E650", Slot = "35")]
	public Vector3 FKIDMCMFECG(Vector3 AFHHNEMELLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x705E830", Offset = "0x705CE30", VA = "0x18705E830", Slot = "34")]
	public Vector3 GFGIFPFOEJI(Vector3 DEOFHMCEHDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x705F3F0", Offset = "0x705D9F0", VA = "0x18705F3F0", Slot = "27")]
	public void IOAEOFFBJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x705E5F0", Offset = "0x705CBF0", VA = "0x18705E5F0", Slot = "25")]
	public void FCNIJEHAHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x705F390", Offset = "0x705D990", VA = "0x18705F390", Slot = "24")]
	public void INDAIBOJKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x705FC90", Offset = "0x705E290", VA = "0x18705FC90", Slot = "33")]
	public void MEPAMPPEPAB(Vector3 ILPBCAOFHFC, Vector3 BNCHFJNCMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x705FAD0", Offset = "0x705E0D0", VA = "0x18705FAD0", Slot = "32")]
	public void LEHHKNIFKIO(Vector3 BGGFFMNEHLJ, Vector3 FMJPBBNAKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7060980", Offset = "0x705EF80", VA = "0x187060980", Slot = "31")]
	public void PBKOFMIKDPP(Vector3 FGIOIHCCMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7060310", Offset = "0x705E910", VA = "0x187060310", Slot = "22")]
	public void PBBOHBCIODG(BGCGFDEOGGE NCBLBBPMLOJ, Vector3 DKAPEBBIDMB, float KEAADBCIBNM, float KAJOLOCGJBD = 8f, float EOMIAHCPFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x705F660", Offset = "0x705DC60", VA = "0x18705F660", Slot = "21")]
	public void KKKPDELJAFB(LOONDOIDMJL ACLHBCPAOJF, Vector3 NPEDGDPAGMP, float OJAJPGIKPFI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x705E9F0", Offset = "0x705CFF0", VA = "0x18705E9F0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void GHOADAOFGPJ(LOONDOIDMJL ACLHBCPAOJF, Vector3 GLKHDAMNPBA, float JCENBACKGJB = 7f, float OMOGOJBEKDL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE6DB00", Offset = "0xE6C100", VA = "0x180E6DB00")]
	private static void IPHOLPEIBKL(Vector3 NPPDGHLPBPO, Vector3 MHHLIPGJMOK, [Out] Vector3 ECBNLKMKKHO, [Out] Vector3 ONKGHFIIKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7060100", Offset = "0x705E700", VA = "0x187060100", Slot = "29")]
	public Vector3 OAKNDJIBJPF(Vector3 NPPDGHLPBPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x705F4A0", Offset = "0x705DAA0", VA = "0x18705F4A0", Slot = "26")]
	public void JAMHHKKJPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x705FED0", Offset = "0x705E4D0", VA = "0x18705FED0")]
	private void MNEKMDMCPKI(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x705DD70", Offset = "0x705C370", VA = "0x18705DD70")]
	private void DBBPHENJKCG(Vector3 NPEDGDPAGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x705FFE0", Offset = "0x705E5E0", VA = "0x18705FFE0")]
	private Vector3 NCNIEGALJIC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x705E140", Offset = "0x705C740", VA = "0x18705E140")]
	private void FABJOKNDJKD(Vector3 DEOFHMCEHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x705E020", Offset = "0x705C620", VA = "0x18705E020")]
	private Vector3 ELOLHMHMIDM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7060B20", Offset = "0x705F120", VA = "0x187060B20")]
	private void PCOAICPOGDI(Vector3 DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x705EDE0", Offset = "0x705D3E0", VA = "0x18705EDE0")]
	private void IILBDIHKGBC(Vector3 DEOFHMCEHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x705DF10", Offset = "0x705C510", VA = "0x18705DF10")]
	private void DJJIAKPGLJF()
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
