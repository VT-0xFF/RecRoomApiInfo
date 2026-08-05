using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static MLPFDGHACOI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int EAAAMEBMIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int JHNILKPMHFG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7108BD0", Offset = "0x7107FD0", VA = "0x187108BD0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7108C10", Offset = "0x7108010", VA = "0x187108C10")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7108BF0", Offset = "0x7107FF0", VA = "0x187108BF0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FHDJIGKOLJM, [Optional] UnityEngine.Object AKPCLGIGABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FHDJIGKOLJM, [Optional] UnityEngine.Object AKPCLGIGABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7108D00", Offset = "0x7108100", VA = "0x187108D00")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HBCJLPHKOFL
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class KLLCBPGIEHE : DEOHHMCHBDP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE567C0", Offset = "0xE55BC0", VA = "0x180E567C0", Slot = "4")]
		public Vector3 FDNBPGPHICC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE567C0", Offset = "0xE55BC0", VA = "0x180E567C0", Slot = "5")]
		public Vector3 HFPOCNEJCHL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KLLCBPGIEHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DEOHHMCHBDP KBKKKOAPMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B55270", Offset = "0x5B54670", VA = "0x185B55270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly EHKEPJIBENP JDBMMNOFBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool HFFJKOBDDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private NCGMOGGOLJC HBKPHPNEIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[ODLEDLFOPDE(BLGBJPBFLHB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[ODLEDLFOPDE(BLGBJPBFLHB.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private NMGAHHIMFKG physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal NCGMOGGOLJC HNCNJLHJDCK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x710A060", Offset = "0x7109460", VA = "0x18710A060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> DDHIFCMPLOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx PJLJFJENPIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x710B900", Offset = "0x710AD00", VA = "0x18710B900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx LECOLGFBNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x710B8A0", Offset = "0x710ACA0", VA = "0x18710B8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OJBGDMNECON
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x710C450", Offset = "0x710B850", VA = "0x18710C450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x710D910", Offset = "0x710CD10", VA = "0x18710D910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform CPIFFJPNGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBB2B00", Offset = "0xBB1F00", VA = "0x180BB2B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform HKLOKDCHCPN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBB2B00", Offset = "0xBB1F00", VA = "0x180BB2B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public AIAJHOEHKAH FNHGKHKMPMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x710B660", Offset = "0x710AA60", VA = "0x18710B660")]
			get
			{
				return default(AIAJHOEHKAH);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x710D0B0", Offset = "0x710C4B0", VA = "0x18710D0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JFBHIKEBFMB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x710BB60", Offset = "0x710AF60", VA = "0x18710BB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IBNEDDAIIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x710B780", Offset = "0x710AB80", VA = "0x18710B780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DEOHHMCHBDP NLKDIBHEMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x710BAA0", Offset = "0x710AEA0", VA = "0x18710BAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x710D2C0", Offset = "0x710C6C0", VA = "0x18710D2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PIHEGONEGJC BKDCKNHAMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x710BA40", Offset = "0x710AE40", VA = "0x18710BA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x710D250", Offset = "0x710C650", VA = "0x18710D250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GLIGEFNNMGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x710B930", Offset = "0x710AD30", VA = "0x18710B930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody BHLLKFJBOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x710B990", Offset = "0x710AD90", VA = "0x18710B990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HAEFBBMPBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x710B7E0", Offset = "0x710ABE0", VA = "0x18710B7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x710D170", Offset = "0x710C570", VA = "0x18710D170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GEAGNBKLDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1624EC0", Offset = "0x16242C0", VA = "0x181624EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4075630", Offset = "0x4074A30", VA = "0x184075630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float HEFLELEADFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x710C3F0", Offset = "0x710B7F0", VA = "0x18710C3F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float BDBMEBNCLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x710C390", Offset = "0x710B790", VA = "0x18710C390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x710D8A0", Offset = "0x710CCA0", VA = "0x18710D8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ODPCCEIIAEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x710BDB0", Offset = "0x710B1B0", VA = "0x18710BDB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x710D550", Offset = "0x710C950", VA = "0x18710D550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KGIGLEACBMK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x710BBC0", Offset = "0x710AFC0", VA = "0x18710BBC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x710D330", Offset = "0x710C730", VA = "0x18710D330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool JDDNIBAEAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x710C920", Offset = "0x710BD20", VA = "0x18710C920")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x710DE00", Offset = "0x710D200", VA = "0x18710DE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 OMIHAIJGEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x710C190", Offset = "0x710B590", VA = "0x18710C190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x710D690", Offset = "0x710CA90", VA = "0x18710D690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 EEPOJPKNAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x710CA50", Offset = "0x710BE50", VA = "0x18710CA50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode LCIIIOGNCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x710BCF0", Offset = "0x710B0F0", VA = "0x18710BCF0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x710D470", Offset = "0x710C870", VA = "0x18710D470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float LHKEKDPDMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x710B840", Offset = "0x710AC40", VA = "0x18710B840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x710D1E0", Offset = "0x710C5E0", VA = "0x18710D1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints JAEAAMFNBED
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x710BD50", Offset = "0x710B150", VA = "0x18710BD50")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x710D4E0", Offset = "0x710C8E0", VA = "0x18710D4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 INADABBPDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x710C4B0", Offset = "0x710B8B0", VA = "0x18710C4B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 JAPBCAOFODI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x710C4B0", Offset = "0x710B8B0", VA = "0x18710C4B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x710DBF0", Offset = "0x710CFF0", VA = "0x18710DBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float DHHEBBKINNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x710C260", Offset = "0x710B660", VA = "0x18710C260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x710D760", Offset = "0x710CB60", VA = "0x18710D760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float AHIDNLPGMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x710C8C0", Offset = "0x710BCC0", VA = "0x18710C8C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x710DD90", Offset = "0x710D190", VA = "0x18710DD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion ABAMMFMPOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x710C580", Offset = "0x710B980", VA = "0x18710C580")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x710D980", Offset = "0x710CD80", VA = "0x18710D980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion IGABECHFIFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x710C7F0", Offset = "0x710BBF0", VA = "0x18710C7F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x710DCC0", Offset = "0x710D0C0", VA = "0x18710DCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 PHBLNILLJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x710C650", Offset = "0x710BA50", VA = "0x18710C650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x710DA50", Offset = "0x710CE50", VA = "0x18710DA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion ENEHFOLIGDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x710C720", Offset = "0x710BB20", VA = "0x18710C720")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x710DB20", Offset = "0x710CF20", VA = "0x18710DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 EDAEDABCFDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x710C980", Offset = "0x710BD80", VA = "0x18710C980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x710DE70", Offset = "0x710D270", VA = "0x18710DE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 HCOFOPDNEPD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x710C2C0", Offset = "0x710B6C0", VA = "0x18710C2C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x710D7D0", Offset = "0x710CBD0", VA = "0x18710D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HLKCHKIFBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x710BC20", Offset = "0x710B020", VA = "0x18710BC20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x710D3A0", Offset = "0x710C7A0", VA = "0x18710D3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GLJMNNPFGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x710C0C0", Offset = "0x710B4C0", VA = "0x18710C0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x710D5C0", Offset = "0x710C9C0", VA = "0x18710D5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 OAIPLLGEDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x710BF90", Offset = "0x710B390", VA = "0x18710BF90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion DMENBEGNAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x710BEC0", Offset = "0x710B2C0", VA = "0x18710BEC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 CFFFGOCIBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x710CBF0", Offset = "0x710BFF0", VA = "0x18710CBF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 EJLCJEMJLAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x710CB20", Offset = "0x710BF20", VA = "0x18710CB20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DDKLJJCFMPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x710C060", Offset = "0x710B460", VA = "0x18710C060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MMPFHBGKFAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x710BB00", Offset = "0x710AF00", VA = "0x18710BB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CJCADBDJBHB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x710B720", Offset = "0x710AB20", VA = "0x18710B720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NIOAFGGDDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x710B6C0", Offset = "0x710AAC0", VA = "0x18710B6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BJGICOFGOHO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x710B600", Offset = "0x710AA00", VA = "0x18710B600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BKJGNNAHBNB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x710BE10", Offset = "0x710B210", VA = "0x18710BE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HPOMJOMGINK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x305DE10", Offset = "0x305D210", VA = "0x18305DE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ELIHEGNOPEG CCBCMBEKFFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x710B520", Offset = "0x710A920", VA = "0x18710B520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x710CFD0", Offset = "0x710C3D0", VA = "0x18710CFD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IDLODEKJPBI PIIPAEAMFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x710B4B0", Offset = "0x710A8B0", VA = "0x18710B4B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x710CF60", Offset = "0x710C360", VA = "0x18710CF60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ELIHEGNOPEG DPPGNFNPGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x710B210", Offset = "0x710A610", VA = "0x18710B210")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x710CCC0", Offset = "0x710C0C0", VA = "0x18710CCC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ELIHEGNOPEG JEIIIGJGJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x710B280", Offset = "0x710A680", VA = "0x18710B280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x710CD30", Offset = "0x710C130", VA = "0x18710CD30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ELIHEGNOPEG JKIOCBLMGOI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x710B3D0", Offset = "0x710A7D0", VA = "0x18710B3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x710CE80", Offset = "0x710C280", VA = "0x18710CE80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x710B360", Offset = "0x710A760", VA = "0x18710B360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x710CE10", Offset = "0x710C210", VA = "0x18710CE10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ELIHEGNOPEG JAGAPPJKOCF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x710B440", Offset = "0x710A840", VA = "0x18710B440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x710CEF0", Offset = "0x710C2F0", VA = "0x18710CEF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ELIHEGNOPEG LBGJKELFPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x710B590", Offset = "0x710A990", VA = "0x18710B590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x710D040", Offset = "0x710C440", VA = "0x18710D040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ELIHEGNOPEG PPLEHAAHCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x710B2F0", Offset = "0x710A6F0", VA = "0x18710B2F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x710CDA0", Offset = "0x710C1A0", VA = "0x18710CDA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		internal void CDJOOJDICPE(NCGMOGGOLJC JGNMLMMCBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7109800", Offset = "0x7108C00", VA = "0x187109800")]
		internal void BPPEKNADJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x710AF00", Offset = "0x710A300", VA = "0x18710AF00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody FOMGMDJCAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x710ABC0", Offset = "0x7109FC0", VA = "0x18710ABC0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GHDEIKNJGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7109790", Offset = "0x7108B90", VA = "0x187109790")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x710A060", Offset = "0x7109460", VA = "0x18710A060")]
		private NCGMOGGOLJC HDBFKDNIBBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7109A70", Offset = "0x7108E70", VA = "0x187109A70")]
		private void DKPCMCGGMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x710A3B0", Offset = "0x71097B0", VA = "0x18710A3B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7109800", Offset = "0x7108C00", VA = "0x187109800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x710A350", Offset = "0x7109750", VA = "0x18710A350")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x710A410", Offset = "0x7109810", VA = "0x18710A410")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7108D50", Offset = "0x7108150", VA = "0x187108D50")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x710A480", Offset = "0x7109880", VA = "0x18710A480")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7109E00", Offset = "0x7109200", VA = "0x187109E00")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x710A2F0", Offset = "0x71096F0", VA = "0x18710A2F0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x710AD20", Offset = "0x710A120", VA = "0x18710AD20")]
		public void SetParent(RigidbodyEx AGLCIEKHLEE, bool ECPEOFEOOHH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x710A780", Offset = "0x7109B80", VA = "0x18710A780")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x710A110", Offset = "0x7109510", VA = "0x18710A110")]
		public bool IsRigidbodyAncestor(RigidbodyEx IBNCLFDLEFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x710A150", Offset = "0x7109550", VA = "0x18710A150")]
		public bool IsRigidbodyDescendant(RigidbodyEx GEAKCCCGEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7108FC0", Offset = "0x71083C0", VA = "0x187108FC0")]
		public void AddInterpolationRestriction(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x710A4F0", Offset = "0x71098F0", VA = "0x18710A4F0")]
		public void RemoveInterpolationRestriction(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7109890", Offset = "0x7108C90", VA = "0x187109890")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7109030", Offset = "0x7108430", VA = "0x187109030")]
		public void AddKinematic(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x710A560", Offset = "0x7109960", VA = "0x18710A560")]
		public void RemoveKinematic(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x710ACA0", Offset = "0x710A0A0", VA = "0x18710ACA0")]
		public void SetKinematic(object AEMEEHLIDCM, bool PILGGODJCBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x710AAD0", Offset = "0x7109ED0", VA = "0x18710AAD0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NFEIMAPGBJI, Quaternion MAEBOAEOIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x710A9E0", Offset = "0x7109DE0", VA = "0x18710A9E0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 KMCELLJPILA, Quaternion EIFGPNBPBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7109F60", Offset = "0x7109360", VA = "0x187109F60")]
		public Vector3 GetConstrainedVelocity(Vector3 EDAEDABCFDL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7109E60", Offset = "0x7109260", VA = "0x187109E60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HLKCHKIFBCP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7108ED0", Offset = "0x71082D0", VA = "0x187108ED0")]
		public void AddForce(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7108DC0", Offset = "0x71081C0", VA = "0x187108DC0")]
		public void AddForceAtPosition(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7109200", Offset = "0x7108600", VA = "0x187109200")]
		public void AddTorque(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71090A0", Offset = "0x71084A0", VA = "0x1871090A0")]
		public void AddRelativeTorque(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x710AFE0", Offset = "0x710A3E0", VA = "0x18710AFE0")]
		public Vector3 WorldToLocalVelocity(Vector3 HNDHEPCHDJH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x710A1F0", Offset = "0x71095F0", VA = "0x18710A1F0")]
		public Vector3 LocalToWorldVelocity(Vector3 HCOFOPDNEPD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7109A10", Offset = "0x7108E10", VA = "0x187109A10")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71099B0", Offset = "0x7108DB0", VA = "0x1871099B0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7109950", Offset = "0x7108D50", VA = "0x187109950")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71098F0", Offset = "0x7108CF0", VA = "0x1871098F0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x710A8E0", Offset = "0x7109CE0", VA = "0x18710A8E0")]
		public void ResetVelocityWorldSpace(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x710A7E0", Offset = "0x7109BE0", VA = "0x18710A7E0")]
		public void ResetVelocityLocalSpace(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x710A6B0", Offset = "0x7109AB0", VA = "0x18710A6B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 LPBHCFOANKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x710AE10", Offset = "0x710A210", VA = "0x18710AE10")]
		public bool SweepTest(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x710A190", Offset = "0x7109590", VA = "0x18710A190")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x710ADB0", Offset = "0x710A1B0", VA = "0x18710ADB0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x710AF80", Offset = "0x710A380", VA = "0x18710AF80")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7109190", Offset = "0x7108590", VA = "0x187109190")]
		public void AddShouldHaveUnityRigidbodyToken(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x710A5D0", Offset = "0x71099D0", VA = "0x18710A5D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7109580", Offset = "0x7108980", VA = "0x187109580")]
		public void ApplyForceVelocityChange(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7109490", Offset = "0x7108890", VA = "0x187109490")]
		public void ApplyAngularVelocityChange(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7109690", Offset = "0x7108A90", VA = "0x187109690")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x71093D0", Offset = "0x71087D0", VA = "0x1871093D0")]
		public bool AllowedScaleChange(float GOMMNCPNCIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71092F0", Offset = "0x71086F0", VA = "0x1871092F0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LCPHECLEJFP, object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x710A640", Offset = "0x7109A40", VA = "0x18710A640")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x710B170", Offset = "0x710A570", VA = "0x18710B170")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class GGLHCPJDKKG
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EF10", Offset = "0x5B4E310", VA = "0x185B4EF10")]
	public static NCGMOGGOLJC HNCNJLHJDCK(this RigidbodyEx LDOEEENLAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ELIHEGNOPEG(RigidbodyEx NLHCPAAMOGP);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NMGAHHIMFKG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum CDHNIIFJBPG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IAPDAIABMEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Rigidbody AHLEEGMGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public PhotonView IEGPKLGPBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OverridableVector3 JAHEMHCOHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 JFOPBIMEOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NMGAHHIMFKG IAEICMCBOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool EHANMFOBHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool HAGIAFODDME;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void IDLODEKJPBI(RigidbodyEx NLHCPAAMOGP, bool ECPEOFEOOHH = false);
[Cpp2IlInjected.Token(Token = "0x200000D")]
[EPJIKDLNGEH(typeof(HKNCFIEKIEP), new string[] { "Ignore", "Mock" })]
public class ELBOELDNJKI : HKNCFIEKIEP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LPLCOPHHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD740", Offset = "0x8BCB40", VA = "0x1808BD740", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void HHPPICLJKBN(string FOMNCGOADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void DKKGMMMENPB(RigidbodyEx LDOEEENLAJO, Action NDPBOAHDPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "7")]
	public NBLEDJCPAGF LCGKOPNGPIC(int IMIPAOPCMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
	public void FCHBECDOOGL(Vector3 EEPOJPKNAAC, float EJOOBBLJBBH, Color DEJOCIOKOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ELBOELDNJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[EPJIKDLNGEH(typeof(MDEEPGFJICJ), new string[] { })]
public class ENDDPLDKKPC : MDEEPGFJICJ, NEHPEGODEDF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private OEGCJPFACKE AIDLIFMNAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HKNCFIEKIEP EOPIGBOAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IKBBFODFLBF KIMAHGPPKMB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HKNCFIEKIEP OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IKBBFODFLBF OKCKKCOHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C420", Offset = "0x5B4B820", VA = "0x185B4C420", Slot = "8")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C550", Offset = "0x5B4B950", VA = "0x185B4C550", Slot = "6")]
	public HEKFLAGDMLJ NINEBCEIANE(RigidbodyEx LDOEEENLAJO)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C850", Offset = "0x5B4BC50", VA = "0x185B4C850")]
	private static HEKFLAGDMLJ OGKNOBNOMHH(RigidbodyEx LDOEEENLAJO)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C4B0", Offset = "0x5B4B8B0", VA = "0x185B4C4B0", Slot = "7")]
	public NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ENDDPLDKKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PCNKMEDGJNC
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x71062A0", Offset = "0x71056A0", VA = "0x1871062A0")]
	public static void IEOIEBGMPAI(this Rigidbody FOMGMDJCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7106190", Offset = "0x7105590", VA = "0x187106190")]
	public static void IEOIEBGMPAI(this Rigidbody FOMGMDJCAOB, Vector3 KCGNLNIAFGO, Quaternion DMENBEGNAHH, Vector3 IEMIKFMOCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x23F22A0", Offset = "0x23F16A0", VA = "0x1823F22A0")]
	public static void EAMNIILANGI(Vector3 EDAEDABCFDL, Vector3 PKGGKJEKINO, out Vector3 BHKJHOEHJOF, out Vector3 CLLDGALOEPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum EJFFJHNIKMI
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IEPLNCDMOAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ELIHEGNOPEG OELFJEKIAAN;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADANEAPHPNN(NCGMOGGOLJC OJBGDMNECON);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMIMDEOPKNL(NCGMOGGOLJC OJBGDMNECON);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EGCGLKGHOFP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLDPONOIEBN(Rigidbody AHLEEGMGCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface HKNCFIEKIEP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LPLCOPHHHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHPPICLJKBN(string FOMNCGOADBK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKKGMMMENPB(RigidbodyEx LDOEEENLAJO, Action NDPBOAHDPLI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBLEDJCPAGF LCGKOPNGPIC(int IMIPAOPCMPM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCHBECDOOGL(Vector3 EEPOJPKNAAC, float EJOOBBLJBBH, Color DEJOCIOKOBF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface MDEEPGFJICJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HKNCFIEKIEP OLJLNILBIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IKBBFODFLBF OKCKKCOHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HEKFLAGDMLJ NINEBCEIANE(RigidbodyEx LDOEEENLAJO);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLJIDOBPAAA
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx DNCFADBIKOP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FKEJKJMGAFO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEHJBCDADCI(NCGMOGGOLJC OJBGDMNECON, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDINHACLNPC(object AEMEEHLIDCM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FIKHILCIDBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DD30", Offset = "0x5B4D130", VA = "0x185B4DD30")]
	public FIKHILCIDBJ(GIIKJICOFOC OEMJPJIELLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DCD0", Offset = "0x5B4D0D0", VA = "0x185B4DCD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GIIKJICOFOC : NCGMOGGOLJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly MDEEPGFJICJ CHLJPKFIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OBAIIGLIFII LJNICDIKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NNIKCNPIEIG PKENOBLBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal IEPLNCDMOAJ BHEMNPHLEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal MHNEMBOIFAD EDAEDABCFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal FKEJKJMGAFO DDPDBBCBCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal EELEJHNFDJM CJIAICPDEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal EGCGLKGHOFP KFADLCDGMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal AMGJBKJIDFC FJGAHPPLKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal GKMLGKADIJC KADAOPFMBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PBCPIOEBFAD NLEBMDGBIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal AHHPIAHJIJI HODPODCGFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal LEHPGJCNDCB DGLCECEILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal MMONDIHOKIN MACGOJAHGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal LFMHEODBGCI AHLEEGMGCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal GFNKAKPEMKH FMLEODMJNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IDisposable JEBOFJGOJLM;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public RigidbodyEx JAPKJKBDICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x822D70", Offset = "0x822170", VA = "0x180822D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GameObject DLKPPCKHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAFBF00", Offset = "0xAFB300", VA = "0x180AFBF00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAFBEF0", Offset = "0xAFB2F0", VA = "0x180AFBEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Transform BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B503F0", Offset = "0x5B4F7F0", VA = "0x185B503F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B51180", Offset = "0x5B50580", VA = "0x185B51180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B503A0", Offset = "0x5B4F7A0", VA = "0x185B503A0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B525B0", Offset = "0x5B519B0", VA = "0x185B525B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B50B80", Offset = "0x5B4FF80", VA = "0x185B50B80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B517C0", Offset = "0x5B50BC0", VA = "0x185B517C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B538E0", Offset = "0x5B52CE0", VA = "0x185B538E0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B54440", Offset = "0x5B53840", VA = "0x185B54440", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5B54620", Offset = "0x5B53A20", VA = "0x185B54620", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B543F0", Offset = "0x5B537F0", VA = "0x185B543F0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B547D0", Offset = "0x5B53BD0", VA = "0x185B547D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B533C0", Offset = "0x5B527C0", VA = "0x185B533C0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5B53410", Offset = "0x5B52810", VA = "0x185B53410", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B541B0", Offset = "0x5B535B0", VA = "0x185B541B0", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B54920", Offset = "0x5B53D20", VA = "0x185B54920", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5B52490", Offset = "0x5B51890", VA = "0x185B52490", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F4C0", Offset = "0x5B4E8C0", VA = "0x185B4F4C0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B522B0", Offset = "0x5B516B0", VA = "0x185B522B0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B515B0", Offset = "0x5B509B0", VA = "0x185B515B0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B53940", Offset = "0x5B52D40", VA = "0x185B53940", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B52880", Offset = "0x5B51C80", VA = "0x185B52880", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B53C00", Offset = "0x5B53000", VA = "0x185B53C00", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B50C30", Offset = "0x5B50030", VA = "0x185B50C30", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool CJCADBDJBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B54830", Offset = "0x5B53C30", VA = "0x185B54830", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NIOAFGGDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B50E80", Offset = "0x5B50280", VA = "0x185B50E80", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool BJGICOFGOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B53670", Offset = "0x5B52A70", VA = "0x185B53670", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5B53B60", Offset = "0x5B52F60", VA = "0x185B53B60", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F9B0", Offset = "0x5B4EDB0", VA = "0x185B4F9B0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5B51CB0", Offset = "0x5B510B0", VA = "0x185B51CB0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5B53810", Offset = "0x5B52C10", VA = "0x185B53810", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5B521E0", Offset = "0x5B515E0", VA = "0x185B521E0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5B50750", Offset = "0x5B4FB50", VA = "0x185B50750", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5B50120", Offset = "0x5B4F520", VA = "0x185B50120", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5B54880", Offset = "0x5B53C80", VA = "0x185B54880", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5B53480", Offset = "0x5B52880", VA = "0x185B53480", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5B51E40", Offset = "0x5B51240", VA = "0x185B51E40", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5B51F10", Offset = "0x5B51310", VA = "0x185B51F10", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5B501E0", Offset = "0x5B4F5E0", VA = "0x185B501E0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5B54F50", Offset = "0x5B54350", VA = "0x185B54F50", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5B548D0", Offset = "0x5B53CD0", VA = "0x185B548D0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5B50230", Offset = "0x5B4F630", VA = "0x185B50230", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5B53760", Offset = "0x5B52B60", VA = "0x185B53760", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5B54E40", Offset = "0x5B54240", VA = "0x185B54E40", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5B50350", Offset = "0x5B4F750", VA = "0x185B50350", Slot = "48")]
		get
		{
			return default(JDKBOLPCEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B50D00", Offset = "0x5B50100", VA = "0x185B50D00", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5B51770", Offset = "0x5B50B70", VA = "0x185B51770", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Transform HKLOKDCHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B53470", Offset = "0x5B52870", VA = "0x185B53470", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 OHEFFLBIFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B50290", Offset = "0x5B4F690", VA = "0x185B50290", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5B53E00", Offset = "0x5B53200", VA = "0x185B53E00", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float KLDCIHBBDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5B52470", Offset = "0x5B51870", VA = "0x185B52470", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F340", Offset = "0x5B4E740", VA = "0x185B4F340", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public float NJDFPHEEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5B514B0", Offset = "0x5B508B0", VA = "0x185B514B0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F850", Offset = "0x5B4EC50", VA = "0x185B4F850", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Quaternion KIDKMOGDJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5B53130", Offset = "0x5B52530", VA = "0x185B53130", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5B53AC0", Offset = "0x5B52EC0", VA = "0x185B53AC0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector3 NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5B51280", Offset = "0x5B50680", VA = "0x185B51280", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F1A0", Offset = "0x5B4E5A0", VA = "0x185B4F1A0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Quaternion DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B543B0", Offset = "0x5B537B0", VA = "0x185B543B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5B53030", Offset = "0x5B52430", VA = "0x185B53030", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5B52190", Offset = "0x5B51590", VA = "0x185B52190", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B54EA0", Offset = "0x5B542A0", VA = "0x185B54EA0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5B50AE0", Offset = "0x5B4FEE0", VA = "0x185B50AE0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5B51120", Offset = "0x5B50520", VA = "0x185B51120", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5B511D0", Offset = "0x5B505D0", VA = "0x185B511D0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5B518C0", Offset = "0x5B50CC0", VA = "0x185B518C0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool GKDECOKBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5B55010", Offset = "0x5B54410", VA = "0x185B55010", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MMPFHBGKFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FB60", Offset = "0x5B4EF60", VA = "0x185B4FB60", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool IOIGABECHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5B53A10", Offset = "0x5B52E10", VA = "0x185B53A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool ENOLKPMJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F7B0", Offset = "0x5B4EBB0", VA = "0x185B4F7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event ELIHEGNOPEG DPPGNFNPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5B50FD0", Offset = "0x5B503D0", VA = "0x185B50FD0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B50BD0", Offset = "0x5B4FFD0", VA = "0x185B50BD0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event ELIHEGNOPEG JEIIIGJGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B52950", Offset = "0x5B51D50", VA = "0x185B52950", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B54A30", Offset = "0x5B53E30", VA = "0x185B54A30", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event IDLODEKJPBI BJDJOGDNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B53DA0", Offset = "0x5B531A0", VA = "0x185B53DA0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B534E0", Offset = "0x5B528E0", VA = "0x185B534E0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event ELIHEGNOPEG OELFJEKIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B530D0", Offset = "0x5B524D0", VA = "0x185B530D0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B51860", Offset = "0x5B50C60", VA = "0x185B51860", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event ELIHEGNOPEG JKIOCBLMGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F7F0", Offset = "0x5B4EBF0", VA = "0x185B4F7F0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5B54FB0", Offset = "0x5B543B0", VA = "0x185B54FB0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event ELIHEGNOPEG IBIENMBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5B52FD0", Offset = "0x5B523D0", VA = "0x185B52FD0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F2E0", Offset = "0x5B4E6E0", VA = "0x185B4F2E0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5B537B0", Offset = "0x5B52BB0", VA = "0x185B537B0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5B51B70", Offset = "0x5B50F70", VA = "0x185B51B70", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ELIHEGNOPEG MLINHCJFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B54980", Offset = "0x5B53D80", VA = "0x185B54980", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5B50DC0", Offset = "0x5B501C0", VA = "0x185B50DC0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ELIHEGNOPEG PPLEHAAHCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B546D0", Offset = "0x5B53AD0", VA = "0x185B546D0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5B535D0", Offset = "0x5B529D0", VA = "0x185B535D0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B551A0", Offset = "0x5B545A0", VA = "0x185B551A0")]
	public GIIKJICOFOC(GameObject NNAKJIJAOJG, RigidbodyEx GOCLKMDKLDN, MDEEPGFJICJ CHLJPKFIHHL, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FCF0", Offset = "0x5B4F0F0", VA = "0x185B4FCF0", Slot = "135")]
	protected virtual void CEHIJIINHLM(MDEEPGFJICJ CHLJPKFIHHL, IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5B50A10", Offset = "0x5B4FE10", VA = "0x185B50A10", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5B529B0", Offset = "0x5B51DB0", VA = "0x185B529B0", Slot = "71")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F960", Offset = "0x5B4ED60", VA = "0x185B4F960", Slot = "72")]
	public void DJBCALPNGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B54490", Offset = "0x5B53890", VA = "0x185B54490", Slot = "73")]
	public void NGFAPIMLJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F700", Offset = "0x5B4EB00", VA = "0x185B4F700")]
	private void BKGCCEADAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5B50170", Offset = "0x5B4F570", VA = "0x185B50170", Slot = "81")]
	public void CILNNMACHKK(NCGMOGGOLJC AGLCIEKHLEE, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FFD0", Offset = "0x5B4F3D0", VA = "0x185B4FFD0", Slot = "84")]
	public void CEJCAKMFOJG(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5B51220", Offset = "0x5B50620", VA = "0x185B51220", Slot = "85")]
	public void GBJKJGKGFAC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5B54AF0", Offset = "0x5B53EF0", VA = "0x185B54AF0", Slot = "86")]
	public Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5B52380", Offset = "0x5B51780", VA = "0x185B52380", Slot = "87")]
	public Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F960", Offset = "0x5B4ED60", VA = "0x185B4F960", Slot = "88")]
	public void BNMCOBBCIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5B50B30", Offset = "0x5B4FF30", VA = "0x185B50B30", Slot = "89")]
	public void EEKOFCBBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5B549E0", Offset = "0x5B53DE0", VA = "0x185B549E0", Slot = "90")]
	public void OILGEJECDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5B51920", Offset = "0x5B50D20", VA = "0x185B51920", Slot = "91")]
	public void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5B50EE0", Offset = "0x5B502E0", VA = "0x185B50EE0", Slot = "92")]
	public void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5B53CD0", Offset = "0x5B530D0", VA = "0x185B53CD0", Slot = "93")]
	public void MLAAAIFLNKB(Vector3 NOEMEMLNICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5B54BE0", Offset = "0x5B53FE0", VA = "0x185B54BE0", Slot = "94")]
	public void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5B50030", Offset = "0x5B4F430", VA = "0x185B50030", Slot = "95")]
	public void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F600", Offset = "0x5B4EA00", VA = "0x185B4F600", Slot = "96")]
	[Obsolete]
	public void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F1F0", Offset = "0x5B4E5F0", VA = "0x185B4F1F0", Slot = "97")]
	public Vector3 AJCMHLLPEGB(Vector3 AGLCIEKHLEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5B51030", Offset = "0x5B50430", VA = "0x185B51030", Slot = "98")]
	public Vector3 FDHLNKOHAPE(Vector3 AGLCIEKHLEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5B53BB0", Offset = "0x5B52FB0", VA = "0x185B53BB0", Slot = "99")]
	public void MJDGFHOJNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5B51D80", Offset = "0x5B51180", VA = "0x185B51D80", Slot = "100")]
	public void ICJJAKDOKAD(NCGMOGGOLJC LCPHECLEJFP, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5B50E20", Offset = "0x5B50220", VA = "0x185B50E20", Slot = "101")]
	public void ELNKAEKHGPH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5B531E0", Offset = "0x5B525E0", VA = "0x185B531E0", Slot = "41")]
	public void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5B54F00", Offset = "0x5B54300", VA = "0x185B54F00", Slot = "104")]
	public void PICHCOMHIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5B51A10", Offset = "0x5B50E10", VA = "0x185B51A10", Slot = "105")]
	public void HEDLCKMDLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5B54CF0", Offset = "0x5B540F0", VA = "0x185B54CF0", Slot = "106")]
	public void OPHCKNJDABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5B50700", Offset = "0x5B4FB00", VA = "0x185B50700", Slot = "109")]
	public bool DGEIDJLIEBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5B54DF0", Offset = "0x5B541F0", VA = "0x185B54DF0", Slot = "74")]
	public void PDFPHCJBIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B54D40", Offset = "0x5B54140", VA = "0x185B54D40", Slot = "110")]
	public void PBBFKBBPONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B51810", Offset = "0x5B50C10", VA = "0x185B51810", Slot = "115")]
	public IDisposable GPKALIHNCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B54D90", Offset = "0x5B54190", VA = "0x185B54D90", Slot = "116")]
	public void PBLEBGEAFIJ(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EF90", Offset = "0x5B4E390", VA = "0x185B4EF90", Slot = "117")]
	public void ACECBHDGJAP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F590", Offset = "0x5B4E990", VA = "0x185B4F590", Slot = "118")]
	public void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5B52610", Offset = "0x5B51A10", VA = "0x185B52610", Slot = "121")]
	public void JELMKFGFBCI(Vector3 NFEIMAPGBJI, Quaternion MAEBOAEOIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5B51FE0", Offset = "0x5B513E0", VA = "0x185B51FE0", Slot = "122")]
	public void IDPNOOMHMDJ(Vector3 KMCELLJPILA, Quaternion EIFGPNBPBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5B54770", Offset = "0x5B53B70", VA = "0x185B54770", Slot = "123")]
	public bool NNCKOPLCPCB(float GOMMNCPNCIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5B54A90", Offset = "0x5B53E90", VA = "0x185B54A90", Slot = "124")]
	public void OJLIAPKCGLG(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F3B0", Offset = "0x5B4E7B0", VA = "0x185B4F3B0", Slot = "125")]
	public void ANCHLFGJMIA(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5B53070", Offset = "0x5B52470", VA = "0x185B53070", Slot = "126")]
	public void JOKNGAABFDH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5B54670", Offset = "0x5B53A70", VA = "0x185B54670", Slot = "127")]
	public void NLHAGIMAHMP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4FA80", Offset = "0x5B4EE80", VA = "0x185B4FA80", Slot = "128")]
	public void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5B51A60", Offset = "0x5B50E60", VA = "0x185B51A60", Slot = "129")]
	public void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5B514D0", Offset = "0x5B508D0", VA = "0x185B514D0", Slot = "130")]
	public void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5B52AF0", Offset = "0x5B51EF0", VA = "0x185B52AF0", Slot = "131")]
	public void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5B51680", Offset = "0x5B50A80", VA = "0x185B51680", Slot = "132")]
	public bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5B52560", Offset = "0x5B51960", VA = "0x185B52560", Slot = "133")]
	public void IPGHJIHGELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5B55160", Offset = "0x5B54560", VA = "0x185B55160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EFF0", Offset = "0x5B4E3F0", VA = "0x185B4EFF0")]
	private void ACGIAMEOHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5B54200", Offset = "0x5B53600", VA = "0x185B54200")]
	private void NABEBBOEBHM(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5B50820", Offset = "0x5B4FC20", VA = "0x185B50820")]
	private void DPOPDIECNMA(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F410", Offset = "0x5B4E810", VA = "0x185B4F410")]
	private void AOGNKBBCMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5B532C0", Offset = "0x5B526C0", VA = "0x185B532C0")]
	private void KEKAOMAKEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5B512D0", Offset = "0x5B506D0", VA = "0x185B512D0")]
	private void GDHIACKBCLG(NCGMOGGOLJC AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5B4F0C0", Offset = "0x5B4E4C0", VA = "0x185B4F0C0")]
	private void ADANEAPHPNN(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5B51BD0", Offset = "0x5B50FD0", VA = "0x185B51BD0")]
	private void HMIMDEOPKNL(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5B544B0", Offset = "0x5B538B0", VA = "0x185B544B0")]
	private void NJNODGPJDEG(RigidbodyEx OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5B50480", Offset = "0x5B4F880", VA = "0x185B50480", Slot = "140")]
	protected virtual void DFGEJBOPEFF(RigidbodyEx LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5B53EB0", Offset = "0x5B532B0", VA = "0x185B53EB0")]
	protected void MPDEIPEDAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5B52BD0", Offset = "0x5B51FD0", VA = "0x185B52BD0")]
	protected void JLKICCPGOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5B53540", Offset = "0x5B52940", VA = "0x185B53540", Slot = "141")]
	protected virtual IDisposable LIKMKOJFMEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class HOIEAIIODHK
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5B56D80", Offset = "0x5B56180", VA = "0x185B56D80")]
	public static NCGMOGGOLJC BLAIFKFPGMM(this NCGMOGGOLJC LDOEEENLAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5B56EB0", Offset = "0x5B562B0", VA = "0x185B56EB0")]
	public static bool IKCFHNNNGLC(this NCGMOGGOLJC LDOEEENLAJO, NCGMOGGOLJC IBNCLFDLEFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5B56F80", Offset = "0x5B56380", VA = "0x185B56F80")]
	public static bool OPPKMAHIMIL(this NCGMOGGOLJC LDOEEENLAJO, NCGMOGGOLJC GEAKCCCGEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5B56F30", Offset = "0x5B56330", VA = "0x185B56F30")]
	public static RigidbodyEx JAPKJKBDICO(this NCGMOGGOLJC HNCNJLHJDCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5B56E40", Offset = "0x5B56240", VA = "0x185B56E40")]
	public static GIIKJICOFOC FAMDHLIOHDM(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EELEJHNFDJM
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ELIHEGNOPEG AODCGBNNAFD;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HEDLCKMDLNN();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PICHCOMHIFC();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OPHCKNJDABG();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JLDPONOIEBN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IPGHJIHGELN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NCGMOGGOLJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	RigidbodyEx JAPKJKBDICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GameObject DLKPPCKHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Transform BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool NIOAFGGDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool BJGICOFGOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform HKLOKDCHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 OHEFFLBIFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float KLDCIHBBDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float NJDFPHEEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Quaternion KIDKMOGDJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Quaternion DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool MMPFHBGKFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ELIHEGNOPEG DPPGNFNPGAA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ELIHEGNOPEG JEIIIGJGJFF;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event IDLODEKJPBI BJDJOGDNGKA;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event ELIHEGNOPEG OELFJEKIAAN;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event ELIHEGNOPEG JKIOCBLMGOI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ELIHEGNOPEG IBIENMBEAGD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event ELIHEGNOPEG MLINHCJFPMH;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event ELIHEGNOPEG PPLEHAAHCGH;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void DJBCALPNGHB();

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void NGFAPIMLJNJ();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void PDFPHCJBIKI();

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void CILNNMACHKK(NCGMOGGOLJC AGLCIEKHLEE, bool ECPEOFEOOHH = false);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void CEJCAKMFOJG(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void GBJKJGKGFAC(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void BNMCOBBCIMG();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void EEKOFCBBFLM();

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void OILGEJECDMC();

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MLAAAIFLNKB(Vector3 NOEMEMLNICJ);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 AJCMHLLPEGB(Vector3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 FDHLNKOHAPE(Vector3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void MJDGFHOJNKA();

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void ICJJAKDOKAD(NCGMOGGOLJC LCPHECLEJFP, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void ELNKAEKHGPH(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void PICHCOMHIFC();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HEDLCKMDLNN();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OPHCKNJDABG();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DGEIDJLIEBI();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void PBBFKBBPONJ();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable GPKALIHNCKJ();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PBLEBGEAFIJ(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void ACECBHDGJAP(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void JELMKFGFBCI(Vector3 NFEIMAPGBJI, Quaternion MAEBOAEOIKA);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void IDPNOOMHMDJ(Vector3 KMCELLJPILA, Quaternion EIFGPNBPBFJ);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool NNCKOPLCPCB(float GOMMNCPNCIM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void OJLIAPKCGLG(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void ANCHLFGJMIA(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void JOKNGAABFDH(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void NLHAGIMAHMP(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void IPGHJIHGELN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LEHPGJCNDCB
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface DEOHHMCHBDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FDNBPGPHICC();

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HFPOCNEJCHL();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NNIKCNPIEIG
{
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHIGIGKHNPC(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFFHDDPAMGB(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGNPHDFIGEA(NCGMOGGOLJC LDOEEENLAJO);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDHNAGLIDII(NCGMOGGOLJC LDOEEENLAJO);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EMGKBBNOLJI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PBCPIOEBFAD : IDisposable, EGLIMKJGMKP
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGIDPLFHMGE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OBAIIGLIFII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event ELIHEGNOPEG DPPGNFNPGAA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event ELIHEGNOPEG JEIIIGJGJFF;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event IDLODEKJPBI BJDJOGDNGKA;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action MJOMGFFFCIJ;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action DMEICIJBIIK;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<NCGMOGGOLJC> PFKGANDHCNJ;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<NCGMOGGOLJC> ACEOCEJIIPM;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action JIMCINENMAD;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<NCGMOGGOLJC> GKBIPNMDEIK;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CILNNMACHKK(NCGMOGGOLJC ICPFLJENDFI, bool ECPEOFEOOHH = false);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface IKBBFODFLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBAIIGLIFII AANGPHEJGCL(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MHNEMBOIFAD PJFPBFHAOML(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKEJKJMGAFO HFENCANGDKE(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EGCGLKGHOFP DMAFMKOHEOO(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKMLGKADIJC FJJAEBDHJCF(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PBCPIOEBFAD NHOFOAJBICP(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AHHPIAHJIJI JPDJFGCACIC(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LEHPGJCNDCB KACEDDKEFEG(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GFNKAKPEMKH EGPGDBFFMGP(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AMGJBKJIDFC DEBMICHCJJB(NCGMOGGOLJC JGNMLMMCBGP);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LFMHEODBGCI LHMFGADFIGL(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IEPLNCDMOAJ INPLBNCPOAN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NNIKCNPIEIG CHPLFLHKPHP(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EELEJHNFDJM IOEEPDHBIJA(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MMONDIHOKIN OFLCBPMNJIG(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ, MDEEPGFJICJ CHLJPKFIHHL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MMONDIHOKIN
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool JEFMAODCONO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLDPONOIEBN(Rigidbody AHLEEGMGCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PIHEGONEGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGPBJCNGOJH(Vector3 PGJFNDKKDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DABIBKBLAAP(Vector3 HLKCHKIFBCP);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBKGGKCIDPF(Vector3 PGJFNDKKDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEDLOPCIEOL(Vector3 HLKCHKIFBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface AHHPIAHJIJI
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event ELIHEGNOPEG MLINHCJFPMH;

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIGKKDFFFPA();

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBLEBGEAFIJ(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACECBHDGJAP(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GPKALIHNCKJ();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NPFPPHNMPFN(Rigidbody MOJFAKMKAFL);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLDPONOIEBN(Rigidbody AHLEEGMGCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GFNKAKPEMKH
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGGALKCGKPB(bool DDKLJJCFMPD);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKFDPDOIELI(bool DDKLJJCFMPD);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MHNEMBOIFAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DMAGDBMMDIC(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OILGEJECDMC();

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EEKOFCBBFLM();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MJDGFHOJNKA();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BNMCOBBCIMG();

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 AJCMHLLPEGB(Vector3 EDAEDABCFDL);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MDJMBEKOCCK(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MLAAAIFLNKB(Vector3 NOEMEMLNICJ);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LFMHEODBGCI
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool JPIPMDKPKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOKNGAABFDH(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLHAGIMAHMP(object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEONHNBMDND();

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMMKAJHACHG();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface AMGJBKJIDFC
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLDPONOIEBN(Rigidbody AHLEEGMGCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GKMLGKADIJC
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event ELIHEGNOPEG IBIENMBEAGD;

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGIDPLFHMGE();

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGEIDJLIEBI();

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFLCAEDMDCN();

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDFPHCJBIKI();

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHIALGIDODP();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PBBFKBBPONJ();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMGNIMIBHCI(bool NNFJFPAHDOG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[EPJIKDLNGEH(typeof(JJLJCDMIEAB), new string[] { })]
public sealed class ENLIIAOKKEP : NEHPEGODEDF, JJLJCDMIEAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[BOJGNOMIPCG]
	private FIOENEMHNNB LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CCA0", Offset = "0x5B4C0A0", VA = "0x185B4CCA0", Slot = "4")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C9E0", Offset = "0x5B4BDE0", VA = "0x185B4C9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CE30", Offset = "0x5B4C230", VA = "0x185B4CE30", Slot = "6")]
	public void MABINJOIHNC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CA10", Offset = "0x5B4BE10", VA = "0x185B4CA10", Slot = "7")]
	public void FOHJFGDONLI(HEKFLAGDMLJ LEMCMBEMOCB, bool GCLLIHABBOD, bool AHIGJLPFING, bool KPKEDBFMAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CCF0", Offset = "0x5B4C0F0", VA = "0x185B4CCF0")]
	private bool KEAADOMKKDL(HEKFLAGDMLJ LEMCMBEMOCB, out MMFJMOCJFKG JGNMLMMCBGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4CFC0", Offset = "0x5B4C3C0", VA = "0x185B4CFC0")]
	private bool PGGIBCMOLDB(HEKFLAGDMLJ LEMCMBEMOCB, out MFNCLMNFAAN BLOMGCONCAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public ENLIIAOKKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MFNCLMNFAAN : DPMOENNEEJC, EELEJHNFDJM
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	[Obsolete]
	public Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D150", Offset = "0x5B5C550", VA = "0x185B5D150", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C390", Offset = "0x5B5B790", VA = "0x185B5C390", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 MJLPLGPLMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5B5EE70", Offset = "0x5B5E270", VA = "0x185B5EE70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 ADAIDOENCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B5E910", Offset = "0x5B5DD10", VA = "0x185B5E910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[Obsolete]
	public Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B9F0", Offset = "0x5B5ADF0", VA = "0x185B5B9F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	[Obsolete]
	public float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B840", Offset = "0x5B5AC40", VA = "0x185B5B840", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float DKPMOIOCHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5B5E380", Offset = "0x5B5D780", VA = "0x185B5E380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B5E5D0", Offset = "0x5B5D9D0", VA = "0x185B5E5D0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B730", Offset = "0x5B5AB30", VA = "0x185B5B730", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C330", Offset = "0x5B5B730", VA = "0x185B5C330", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C360", Offset = "0x5B5B760", VA = "0x185B5C360", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ELIHEGNOPEG AODCGBNNAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B5CA00", Offset = "0x5B5BE00", VA = "0x185B5CA00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B5EDD0", Offset = "0x5B5E1D0", VA = "0x185B5EDD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B5EFB0", Offset = "0x5B5E3B0", VA = "0x185B5EFB0")]
	public MFNCLMNFAAN(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B5B930", Offset = "0x5B5AD30", VA = "0x185B5B930")]
	public float3 DCLPBJHHDIF()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B5CEC0", Offset = "0x5B5C2C0", VA = "0x185B5CEC0", Slot = "14")]
	public void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B5EB40", Offset = "0x5B5DF40", VA = "0x185B5EB40", Slot = "16")]
	public void PICHCOMHIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B5BDB0", Offset = "0x5B5B1B0", VA = "0x185B5BDB0", Slot = "15")]
	public void HEDLCKMDLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B5E480", Offset = "0x5B5D880", VA = "0x185B5E480", Slot = "18")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B5CBF0", Offset = "0x5B5BFF0", VA = "0x185B5CBF0", Slot = "19")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B5EA50", Offset = "0x5B5DE50", VA = "0x185B5EA50", Slot = "17")]
	public void OPHCKNJDABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B5C4E0", Offset = "0x5B5B8E0", VA = "0x185B5C4E0", Slot = "20")]
	public void IPGHJIHGELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B49C30", Offset = "0x5B49030", VA = "0x185B49C30")]
	public void KMPBLCCECIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B5CAA0", Offset = "0x5B5BEA0", VA = "0x185B5CAA0")]
	private void JJNBFKNAFII(Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B5C1C0", Offset = "0x5B5B5C0", VA = "0x185B5C1C0")]
	[Obsolete]
	private Vector3 HMIOHPCILOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B5B730", Offset = "0x5B5AB30", VA = "0x185B5B730")]
	private void BMIKFCMBODE(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B5E6C0", Offset = "0x5B5DAC0", VA = "0x185B5E6C0")]
	private Vector3 OFHIKMCPNBL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B5BB70", Offset = "0x5B5AF70", VA = "0x185B5BB70")]
	private Quaternion ELGFKFNABEI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5B5D290", Offset = "0x5B5C690", VA = "0x185B5D290")]
	internal (float, Vector3) MABINJOIHNC(Rigidbody BIMEOLEJKOG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class KPNIEBNMKJE
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B5B2A0", Offset = "0x5B5A6A0", VA = "0x185B5B2A0")]
	public static MFNCLMNFAAN FFPJJBOIHDL(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BMKLCKAEMFK : DPMOENNEEJC, MHNEMBOIFAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B41EE0", Offset = "0x5B412E0", VA = "0x185B41EE0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B420D0", Offset = "0x5B414D0", VA = "0x185B420D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B40FD0", Offset = "0x5B403D0", VA = "0x185B40FD0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5B41100", Offset = "0x5B40500", VA = "0x185B41100", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B41200", Offset = "0x5B40600", VA = "0x185B41200", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B40F10", Offset = "0x5B40310", VA = "0x185B40F10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B40EE0", Offset = "0x5B402E0", VA = "0x185B40EE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F060", Offset = "0x5B3E460", VA = "0x185B3F060", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B415B0", Offset = "0x5B409B0", VA = "0x185B415B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B3FF70", Offset = "0x5B3F370", VA = "0x185B3FF70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B40CF0", Offset = "0x5B400F0", VA = "0x185B40CF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B407C0", Offset = "0x5B3FBC0", VA = "0x185B407C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B41DF0", Offset = "0x5B411F0", VA = "0x185B41DF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B42460", Offset = "0x5B41860", VA = "0x185B42460", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B41360", Offset = "0x5B40760", VA = "0x185B41360", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private LEHPGJCNDCB HNPDEOBNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0300", Offset = "0x1FDF700", VA = "0x181FE0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool GKDECOKBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B42AB0", Offset = "0x5B41EB0", VA = "0x185B42AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public BMKLCKAEMFK(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FB20", Offset = "0x5B3EF20", VA = "0x185B3FB20", Slot = "20")]
	public void DMAGDBMMDIC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B41260", Offset = "0x5B40660", VA = "0x185B41260", Slot = "30")]
	public void MDJMBEKOCCK(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F3B0", Offset = "0x5B3E7B0", VA = "0x185B3F3B0", Slot = "19")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FC20", Offset = "0x5B3F020", VA = "0x185B3FC20", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B421D0", Offset = "0x5B415D0", VA = "0x185B421D0", Slot = "28")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5B424B0", Offset = "0x5B418B0", VA = "0x185B424B0", Slot = "35")]
	public Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B40D20", Offset = "0x5B40120", VA = "0x185B40D20", Slot = "34")]
	public Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F3B0", Offset = "0x5B3E7B0", VA = "0x185B3F3B0", Slot = "27")]
	public void BNMCOBBCIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FD60", Offset = "0x5B3F160", VA = "0x185B3FD60", Slot = "25")]
	public void EEKOFCBBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B42470", Offset = "0x5B41870", VA = "0x185B42470", Slot = "24")]
	public void OILGEJECDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B407F0", Offset = "0x5B3FBF0", VA = "0x185B407F0", Slot = "33")]
	public void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B40760", Offset = "0x5B3FB60", VA = "0x185B40760", Slot = "32")]
	public void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B41610", Offset = "0x5B40A10", VA = "0x185B41610", Slot = "31")]
	public void MLAAAIFLNKB(Vector3 NOEMEMLNICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B42690", Offset = "0x5B41A90", VA = "0x185B42690", Slot = "22")]
	public void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F480", Offset = "0x5B3E880", VA = "0x185B3F480", Slot = "21")]
	public void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F090", Offset = "0x5B3E490", VA = "0x185B3F090", Slot = "23")]
	[Obsolete]
	public void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EFA0", Offset = "0x5B3E3A0", VA = "0x185B3EFA0", Slot = "29")]
	public Vector3 AJCMHLLPEGB(Vector3 EDAEDABCFDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B41450", Offset = "0x5B40850", VA = "0x185B41450", Slot = "26")]
	public void MJDGFHOJNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B42270", Offset = "0x5B41670", VA = "0x185B42270")]
	private void ODDDHNCAMHO(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FDA0", Offset = "0x5B3F1A0", VA = "0x185B3FDA0")]
	private void EHFJHAANLGC(Vector3 JHLLBKFCHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5B40030", Offset = "0x5B3F430", VA = "0x185B40030")]
	private Vector3 ELDBAIDDHNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5B402F0", Offset = "0x5B3F6F0", VA = "0x185B402F0")]
	private void ELDHKBLKCOM(Vector3 HCOFOPDNEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B40A30", Offset = "0x5B3FE30", VA = "0x185B40A30")]
	private Vector3 HFPOCNEJCHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F6C0", Offset = "0x5B3EAC0", VA = "0x185B3F6C0")]
	private void DABIBKBLAAP(Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B3F420", Offset = "0x5B3E820", VA = "0x185B3F420")]
	private void CEPACLIELHO(Vector3 EDAEDABCFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B42210", Offset = "0x5B41610", VA = "0x185B42210")]
	private void OBFIKMHGLAL(Vector3 HLKCHKIFBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B417E0", Offset = "0x5B40BE0", VA = "0x185B417E0")]
	private void MLHEAHJBDDO(string PKODDPNIHLP, Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B42010", Offset = "0x5B41410", VA = "0x185B42010")]
	private void NGEFODALPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class BHFNPDPMMPO : DPMOENNEEJC, EGCGLKGHOFP
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E660", Offset = "0x5B3DA60", VA = "0x185B3E660", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ECF0", Offset = "0x5B3E0F0", VA = "0x185B3ECF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EC00", Offset = "0x5B3E000", VA = "0x185B3EC00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E750", Offset = "0x5B3DB50", VA = "0x185B3E750", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public BHFNPDPMMPO(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EA10", Offset = "0x5B3DE10", VA = "0x185B3EA10", Slot = "8")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E940", Offset = "0x5B3DD40", VA = "0x185B3E940", Slot = "9")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[UnityEngine.Scripting.Preserve]
public sealed class JBEJLCCNGOG : NCGMOGGOLJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JBEJLCCNGOG FNGGPKJOCFE;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public RigidbodyEx JAPKJKBDICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GameObject DLKPPCKHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Transform BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A850", Offset = "0xA39C50", VA = "0x180A3A850", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABD0A0", VA = "0x180ABDCA0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xE84260", Offset = "0xE83660", VA = "0x180E84260", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x34EAF50", Offset = "0x34EA350", VA = "0x1834EAF50", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1138AE0", Offset = "0x1137EE0", VA = "0x181138AE0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA880", Offset = "0x2BA9C80", VA = "0x182BAA880", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x327E8A0", Offset = "0x327DCA0", VA = "0x18327E8A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5B59C20", Offset = "0x5B59020", VA = "0x185B59C20", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x34D7140", Offset = "0x34D6540", VA = "0x1834D7140", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1BF0100", Offset = "0x1BEF500", VA = "0x181BF0100", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool NIOAFGGDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA070", Offset = "0x8C9470", VA = "0x1808CA070", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool BJGICOFGOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CB0", Offset = "0x8F90B0", VA = "0x1808F9CB0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10E6300", Offset = "0x10E5700", VA = "0x1810E6300", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x327E8D0", Offset = "0x327DCD0", VA = "0x18327E8D0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10BD360", Offset = "0x10BC760", VA = "0x1810BD360", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5B59C00", Offset = "0x5B59000", VA = "0x185B59C00", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x5B59BF0", Offset = "0x5B58FF0", VA = "0x185B59BF0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA55500", Offset = "0xA54900", VA = "0x180A55500", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1350440", Offset = "0x134F840", VA = "0x181350440", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA55500", Offset = "0xA54900", VA = "0x180A55500", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA55500", Offset = "0xA54900", VA = "0x180A55500", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "48")]
		get
		{
			return default(JDKBOLPCEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5B59C50", Offset = "0x5B59050", VA = "0x185B59C50", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Transform HKLOKDCHCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA31EB0", Offset = "0xA312B0", VA = "0x180A31EB0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 OHEFFLBIFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float KLDCIHBBDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA55500", Offset = "0xA54900", VA = "0x180A55500", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float NJDFPHEEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA55500", Offset = "0xA54900", VA = "0x180A55500", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion KIDKMOGDJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xC138C0", Offset = "0xC12CC0", VA = "0x180C138C0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Quaternion DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xC138C0", Offset = "0xC12CC0", VA = "0x180C138C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool MMPFHBGKFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3036A30", Offset = "0x3035E30", VA = "0x183036A30", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ELIHEGNOPEG DPPGNFNPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ELIHEGNOPEG JEIIIGJGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event IDLODEKJPBI BJDJOGDNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event ELIHEGNOPEG OELFJEKIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event ELIHEGNOPEG JKIOCBLMGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event ELIHEGNOPEG IBIENMBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event ELIHEGNOPEG MLINHCJFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event ELIHEGNOPEG PPLEHAAHCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "41")]
	public void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "71")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "72")]
	public void DJBCALPNGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "73")]
	public void NGFAPIMLJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "74")]
	public void PDFPHCJBIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "81")]
	public void CILNNMACHKK(NCGMOGGOLJC AGLCIEKHLEE, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "84")]
	public void CEJCAKMFOJG(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "85")]
	public void GBJKJGKGFAC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "86")]
	public Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "87")]
	public Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "88")]
	public void BNMCOBBCIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "89")]
	public void EEKOFCBBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "90")]
	public void OILGEJECDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "91")]
	public void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "92")]
	public void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "93")]
	public void MLAAAIFLNKB(Vector3 NOEMEMLNICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "94")]
	public void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "95")]
	public void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "96")]
	public void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "97")]
	public Vector3 AJCMHLLPEGB(Vector3 AGLCIEKHLEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x9BDA10", Offset = "0x9BCE10", VA = "0x1809BDA10", Slot = "98")]
	public Vector3 FDHLNKOHAPE(Vector3 AGLCIEKHLEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "99")]
	public void MJDGFHOJNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "100")]
	public void ICJJAKDOKAD(NCGMOGGOLJC LCPHECLEJFP, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "101")]
	public void ELNKAEKHGPH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "104")]
	public void PICHCOMHIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "105")]
	public void HEDLCKMDLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "106")]
	public void OPHCKNJDABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "109")]
	public bool DGEIDJLIEBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "110")]
	public void PBBFKBBPONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "115")]
	public IDisposable GPKALIHNCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "116")]
	public void PBLEBGEAFIJ(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "117")]
	public void ACECBHDGJAP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "118")]
	public void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "121")]
	public void JELMKFGFBCI(Vector3 NFEIMAPGBJI, Quaternion MAEBOAEOIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "122")]
	public void IDPNOOMHMDJ(Vector3 KMCELLJPILA, Quaternion EIFGPNBPBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "123")]
	public bool NNCKOPLCPCB(float GOMMNCPNCIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "124")]
	public void OJLIAPKCGLG(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "125")]
	public void ANCHLFGJMIA(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "126")]
	public void JOKNGAABFDH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "127")]
	public void NLHAGIMAHMP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "128")]
	public void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "129")]
	public void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "130")]
	public void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "131")]
	public void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5B59C30", Offset = "0x5B59030", VA = "0x185B59C30", Slot = "132")]
	public bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "133")]
	public void IPGHJIHGELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public JBEJLCCNGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class INDDALJLNBP : DPMOENNEEJC, FKEJKJMGAFO
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5B584D0", Offset = "0x5B578D0", VA = "0x185B584D0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5B58780", Offset = "0x5B57B80", VA = "0x185B58780", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5B58C80", Offset = "0x5B58080", VA = "0x185B58C80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private NCGMOGGOLJC GAPFNOENEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5B58500", Offset = "0x5B57900", VA = "0x185B58500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public INDDALJLNBP(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5B58B00", Offset = "0x5B57F00", VA = "0x185B58B00", Slot = "6")]
	public void JEHJBCDADCI(NCGMOGGOLJC OJBGDMNECON, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5B589C0", Offset = "0x5B57DC0", VA = "0x185B589C0")]
	private void JEHJBCDADCI(MMFJMOCJFKG OJBGDMNECON, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5B58D60", Offset = "0x5B58160", VA = "0x185B58D60", Slot = "7")]
	public void MDINHACLNPC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5B58240", Offset = "0x5B57640", VA = "0x185B58240")]
	private Vector3 ABDFBEEFGKI()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class MJDIFBHLCJO
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F2D0", Offset = "0x5B5E6D0", VA = "0x185B5F2D0")]
	public static INDDALJLNBP HHAPDAAIAKD(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class PPPKOIBNOHJ : DPMOENNEEJC, OBAIIGLIFII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly EHKEPJIBENP EINBENMDMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AJGDKAMMEDL NKANDPPGOGN;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Transform BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7106EF0", Offset = "0x71062F0", VA = "0x187106EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public HEKFLAGDMLJ GNPLPKJOMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7107A30", Offset = "0x7106E30", VA = "0x187107A30")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7107E70", Offset = "0x7107270", VA = "0x187107E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7106EB0", Offset = "0x71062B0", VA = "0x187106EB0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7108030", Offset = "0x7107430", VA = "0x187108030", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public HEKFLAGDMLJ EMAKPFDKNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7106B10", Offset = "0x7105F10", VA = "0x187106B10")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7107510", Offset = "0x7106910", VA = "0x187107510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7107B50", Offset = "0x7106F50", VA = "0x187107B50", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ELIHEGNOPEG DPPGNFNPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7107630", Offset = "0x7106A30", VA = "0x187107630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7107330", Offset = "0x7106730", VA = "0x187107330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ELIHEGNOPEG JEIIIGJGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x71080A0", Offset = "0x71074A0", VA = "0x1871080A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7108870", Offset = "0x7107C70", VA = "0x187108870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event IDLODEKJPBI BJDJOGDNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x71083C0", Offset = "0x71077C0", VA = "0x1871083C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7108280", Offset = "0x7107680", VA = "0x187108280", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action MJOMGFFFCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x71086B0", Offset = "0x7107AB0", VA = "0x1871086B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7108460", Offset = "0x7107860", VA = "0x187108460", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action DMEICIJBIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x71073D0", Offset = "0x71067D0", VA = "0x1871073D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7107F90", Offset = "0x7107390", VA = "0x187107F90", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<NCGMOGGOLJC> PFKGANDHCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7108910", Offset = "0x7107D10", VA = "0x187108910", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7107B90", Offset = "0x7106F90", VA = "0x187107B90", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<NCGMOGGOLJC> ACEOCEJIIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7107470", Offset = "0x7106870", VA = "0x187107470", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7108140", Offset = "0x7107540", VA = "0x187108140", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action JIMCINENMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x71081E0", Offset = "0x71075E0", VA = "0x1871081E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7108320", Offset = "0x7107720", VA = "0x187108320", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<NCGMOGGOLJC> GKBIPNMDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7107C30", Offset = "0x7107030", VA = "0x187107C30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7106E10", Offset = "0x7106210", VA = "0x187106E10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7108A40", Offset = "0x7107E40", VA = "0x187108A40")]
	public PPPKOIBNOHJ(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7106F20", Offset = "0x7106320", VA = "0x187106F20", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7106CA0", Offset = "0x71060A0", VA = "0x187106CA0", Slot = "26")]
	public void CILNNMACHKK(NCGMOGGOLJC ICPFLJENDFI, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7106C30", Offset = "0x7106030", VA = "0x187106C30")]
	private void CILNNMACHKK(MMFJMOCJFKG ICPFLJENDFI, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x71063F0", Offset = "0x71057F0", VA = "0x1871063F0")]
	private void AFJANOICCMD(MMFJMOCJFKG ICPFLJENDFI, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7108500", Offset = "0x7107900", VA = "0x187108500")]
	private void NILGCEFECPE(MMFJMOCJFKG AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7107CD0", Offset = "0x71070D0", VA = "0x187107CD0")]
	private void HGKIKABGAIF(MMFJMOCJFKG AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x71076D0", Offset = "0x7106AD0", VA = "0x1871076D0")]
	private void GBNKCMIGEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7106D20", Offset = "0x7106120", VA = "0x187106D20")]
	private void CKNPMPBKFGC(MMFJMOCJFKG AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7108750", Offset = "0x7107B50", VA = "0x187108750")]
	private void NOOJAFENDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x71078D0", Offset = "0x7106CD0", VA = "0x1871078D0")]
	private void GKKELJKGEHE(MMFJMOCJFKG LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x71071D0", Offset = "0x71065D0", VA = "0x1871071D0")]
	private void EFGKFCOBOBC(MMFJMOCJFKG LDOEEENLAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CPMLLJDEKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A470", Offset = "0x5B49870", VA = "0x185B4A470")]
	public static PPPKOIBNOHJ LJHMBDPCDOC(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class MMFJMOCJFKG : GIIKJICOFOC, COBFMFPIDNL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal FIOENEMHNNB ILKBJBFBHIC;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FE30", Offset = "0x5B5F230", VA = "0x185B5FE30")]
	public MMFJMOCJFKG(GameObject NNAKJIJAOJG, RigidbodyEx GOCLKMDKLDN, MDEEPGFJICJ CHLJPKFIHHL, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F360", Offset = "0x5B5E760", VA = "0x185B5F360", Slot = "135")]
	protected override void CEHIJIINHLM(MDEEPGFJICJ CHLJPKFIHHL, IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "141")]
	protected override IDisposable LIKMKOJFMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F5F0", Offset = "0x5B5E9F0", VA = "0x185B5F5F0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FA70", Offset = "0x5B5EE70", VA = "0x185B5FA70", Slot = "142")]
	public void NPEAGFLPFEB(GFEODBLIPAM CBNEMGEKLOD, GFEODBLIPAM BGDHKJDGOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FB30", Offset = "0x5B5EF30", VA = "0x185B5FB30", Slot = "143")]
	public void PMEICNJFNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F950", Offset = "0x5B5ED50", VA = "0x185B5F950", Slot = "144")]
	public void NBDHCDDLGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F8F0", Offset = "0x5B5ECF0", VA = "0x185B5F8F0", Slot = "145")]
	public void MMGNIMIBHCI(bool NNFJFPAHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B5F780", Offset = "0x5B5EB80", VA = "0x185B5F780", Slot = "146")]
	public bool EBJCGFCDLNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FA10", Offset = "0x5B5EE10", VA = "0x185B5FA10", Slot = "147")]
	public void NEGKIBOJNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "140")]
	protected override void DFGEJBOPEFF(RigidbodyEx PIALDONBLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FBF0", Offset = "0x5B5EFF0", VA = "0x185B5FBF0")]
	private void PONBOONLEIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class IOPHOPNBMAF
{
	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B58E60", Offset = "0x5B58260", VA = "0x185B58E60")]
	public static GIIKJICOFOC MHOFBMCKIAM(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BOFBMPFGFCJ : DPMOENNEEJC, NNIKCNPIEIG
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool DDEHEDMAJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B48CC0", Offset = "0x5B480C0", VA = "0x185B48CC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public HIECNPEDPHM GOKPJCPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5B48330", Offset = "0x5B47730", VA = "0x185B48330", Slot = "11")]
		get
		{
			return default(HIECNPEDPHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private HIECNPEDPHM FELOJBELEON
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5B48450", Offset = "0x5B47850", VA = "0x185B48450")]
		get
		{
			return default(HIECNPEDPHM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B488C0", Offset = "0x5B47CC0", VA = "0x185B488C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B48DB0", Offset = "0x5B481B0", VA = "0x185B48DB0")]
	public BOFBMPFGFCJ(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B48670", Offset = "0x5B47A70", VA = "0x185B48670", Slot = "4")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B48A00", Offset = "0x5B47E00", VA = "0x185B48A00")]
	private bool NDJDAJDAIHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B48BB0", Offset = "0x5B47FB0", VA = "0x185B48BB0", Slot = "5")]
	public void NHIGIGKHNPC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5B48AA0", Offset = "0x5B47EA0", VA = "0x185B48AA0", Slot = "6")]
	public void NFFHDDPAMGB(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B48340", Offset = "0x5B47740", VA = "0x185B48340", Slot = "9")]
	public void EMGKBBNOLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B48540", Offset = "0x5B47940", VA = "0x185B48540")]
	private void HCAMIMIHBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B48730", Offset = "0x5B47B30", VA = "0x185B48730")]
	private void KCFMLANKGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B48630", Offset = "0x5B47A30", VA = "0x185B48630", Slot = "8")]
	public void HDHNAGLIDII(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B489C0", Offset = "0x5B47DC0", VA = "0x185B489C0", Slot = "7")]
	public void MGNPHDFIGEA(NCGMOGGOLJC LDOEEENLAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class AGCBLACGJOB : DPMOENNEEJC, LEHPGJCNDCB
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AFA0", Offset = "0x5B3A3A0", VA = "0x185B3AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B600", Offset = "0x5B3AA00", VA = "0x185B3B600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AAA0", Offset = "0x5B39EA0", VA = "0x185B3AAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public AGCBLACGJOB(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A940", Offset = "0x5B39D40", VA = "0x185B3A940", Slot = "4")]
	public void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AB00", Offset = "0x5B39F00", VA = "0x185B3AB00")]
	private void EBMKDGBGDBD(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AFF0", Offset = "0x5B3A3F0", VA = "0x185B3AFF0", Slot = "5")]
	public void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5B3AE40", Offset = "0x5B3A240", VA = "0x185B3AE40", Slot = "6")]
	public void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B660", Offset = "0x5B3AA60", VA = "0x185B3B660")]
	private void PPKBDGHBLBO(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B380", Offset = "0x5B3A780", VA = "0x185B3B380", Slot = "7")]
	public void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B290", Offset = "0x5B3A690", VA = "0x185B3B290")]
	private void JGFJHJADKIM(string FHDJIGKOLJM, UnityEngine.Object AKPCLGIGABA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IPIBLGJLHGE : DPMOENNEEJC, LFMHEODBGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B58FB0", Offset = "0x5B583B0", VA = "0x185B58FB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B58EB0", Offset = "0x5B582B0", VA = "0x185B58EB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B600", Offset = "0x5B3AA00", VA = "0x185B3B600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool JPIPMDKPKON
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B59850", Offset = "0x5B58C50", VA = "0x185B59850", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B59B60", Offset = "0x5B58F60", VA = "0x185B59B60")]
	public IPIBLGJLHGE(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B597A0", Offset = "0x5B58BA0", VA = "0x185B597A0", Slot = "5")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B59940", Offset = "0x5B58D40", VA = "0x185B59940", Slot = "7")]
	public void JOKNGAABFDH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B59A50", Offset = "0x5B58E50", VA = "0x185B59A50", Slot = "8")]
	public void NLHAGIMAHMP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B59300", Offset = "0x5B58700", VA = "0x185B59300", Slot = "9")]
	public void GEONHNBMDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B590A0", Offset = "0x5B584A0", VA = "0x185B590A0", Slot = "11")]
	public void FNGGFCBNAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B595D0", Offset = "0x5B589D0", VA = "0x185B595D0", Slot = "12")]
	public void INCEGHAHPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "10")]
	public void BMMKAJHACHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class CIBFHGKFNIG : DPMOENNEEJC, AHHPIAHJIJI
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B498D0", Offset = "0x5B48CD0", VA = "0x185B498D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private bool IFHCLHOJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B497E0", Offset = "0x5B48BE0", VA = "0x185B497E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ELIHEGNOPEG MLINHCJFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5B49E10", Offset = "0x5B49210", VA = "0x185B49E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5B49740", Offset = "0x5B48B40", VA = "0x185B49740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public CIBFHGKFNIG(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B499C0", Offset = "0x5B48DC0", VA = "0x185B499C0", Slot = "11")]
	public IDisposable GPKALIHNCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5B49EB0", Offset = "0x5B492B0", VA = "0x185B49EB0", Slot = "8")]
	public void PBLEBGEAFIJ(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5B49620", Offset = "0x5B48A20", VA = "0x185B49620", Slot = "9")]
	public void ACECBHDGJAP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B49630", Offset = "0x5B48A30", VA = "0x185B49630", Slot = "10")]
	public void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B49C70", Offset = "0x5B49070", VA = "0x185B49C70", Slot = "12")]
	public void NPFPPHNMPFN(Rigidbody MOJFAKMKAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B49A20", Offset = "0x5B48E20", VA = "0x185B49A20", Slot = "13")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B49C30", Offset = "0x5B49030", VA = "0x185B49C30", Slot = "6")]
	public void KIGKKDFFFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class FFHMHMHCAGH : DPMOENNEEJC, GFNKAKPEMKH
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private CollisionDetectionMode MEOGGNAPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D930", Offset = "0x5B4CD30", VA = "0x185B4D930")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DB30", Offset = "0x5B4CF30", VA = "0x185B4DB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D630", Offset = "0x5B4CA30", VA = "0x185B4D630", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D8B0", Offset = "0x5B4CCB0", VA = "0x185B4D8B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public FFHMHMHCAGH(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DA20", Offset = "0x5B4CE20", VA = "0x185B4DA20", Slot = "6")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DC40", Offset = "0x5B4D040", VA = "0x185B4DC40", Slot = "9")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DC30", Offset = "0x5B4D030", VA = "0x185B4DC30", Slot = "7")]
	public void NGGALKCGKPB(bool DDKLJJCFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D620", Offset = "0x5B4CA20", VA = "0x185B4D620", Slot = "8")]
	public void EKFDPDOIELI(bool DDKLJJCFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D740", Offset = "0x5B4CB40", VA = "0x185B4D740", Slot = "10")]
	public bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D400", Offset = "0x5B4C800", VA = "0x185B4D400")]
	private void AENCJCPCKMJ(bool DDKLJJCFMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DefaultMember("Item")]
public sealed class AJGDKAMMEDL : IReadOnlyList<NCGMOGGOLJC>, IEnumerable<NCGMOGGOLJC>, IEnumerable, IReadOnlyCollection<NCGMOGGOLJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly FIOENEMHNNB DEMMAINGNBB;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BB60", Offset = "0x5B3AF60", VA = "0x185B3BB60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public NCGMOGGOLJC ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BC40", Offset = "0x5B3B040", VA = "0x185B3BC40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B3BB10", Offset = "0x5B3AF10", VA = "0x185B3BB10")]
	public AJGDKAMMEDL(HEKFLAGDMLJ JBFCCDGDFOM, FIOENEMHNNB DEMMAINGNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B970", Offset = "0x5B3AD70", VA = "0x185B3B970", Slot = "6")]
	public IEnumerator<NCGMOGGOLJC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B970", Offset = "0x5B3AD70", VA = "0x185B3B970", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B960", Offset = "0x5B3AD60", VA = "0x185B3B960")]
	[CompilerGenerated]
	private NCGMOGGOLJC DAAIOFBMCIC(int APEMPONKPBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BDDHGIMADMA : IKBBFODFLBF
{
	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DBF0", Offset = "0x5B3CFF0", VA = "0x185B3DBF0", Slot = "4")]
	public OBAIIGLIFII AANGPHEJGCL(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E5C0", Offset = "0x5B3D9C0", VA = "0x185B3E5C0", Slot = "5")]
	public MHNEMBOIFAD PJFPBFHAOML(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E160", Offset = "0x5B3D560", VA = "0x185B3E160", Slot = "6")]
	public FKEJKJMGAFO HFENCANGDKE(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DF50", Offset = "0x5B3D350", VA = "0x185B3DF50", Slot = "7")]
	public EGCGLKGHOFP DMAFMKOHEOO(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E090", Offset = "0x5B3D490", VA = "0x185B3E090", Slot = "8")]
	public GKMLGKADIJC FJJAEBDHJCF(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E520", Offset = "0x5B3D920", VA = "0x185B3E520", Slot = "9")]
	public PBCPIOEBFAD NHOFOAJBICP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E330", Offset = "0x5B3D730", VA = "0x185B3E330", Slot = "10")]
	public AHHPIAHJIJI JPDJFGCACIC(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E3D0", Offset = "0x5B3D7D0", VA = "0x185B3E3D0", Slot = "11")]
	public LEHPGJCNDCB KACEDDKEFEG(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DFF0", Offset = "0x5B3D3F0", VA = "0x185B3DFF0", Slot = "12")]
	public GFNKAKPEMKH EGPGDBFFMGP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DEB0", Offset = "0x5B3D2B0", VA = "0x185B3DEB0", Slot = "13")]
	public AMGJBKJIDFC DEBMICHCJJB(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DC50", Offset = "0x5B3D050", VA = "0x185B3DC50")]
	public LFMHEODBGCI LHMFGADFIGL(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E200", Offset = "0x5B3D600", VA = "0x185B3E200")]
	public IEPLNCDMOAJ INPLBNCPOAN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DD10", Offset = "0x5B3D110", VA = "0x185B3DD10")]
	public NNIKCNPIEIG CHPLFLHKPHP(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E2C0", Offset = "0x5B3D6C0", VA = "0x185B3E2C0")]
	public EELEJHNFDJM IOEEPDHBIJA(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E0F0", Offset = "0x5B3D4F0", VA = "0x185B3E0F0")]
	public MMONDIHOKIN OFLCBPMNJIG(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E470", Offset = "0x5B3D870", VA = "0x185B3E470", Slot = "19")]
	public NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ, MDEEPGFJICJ CHLJPKFIHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public BDDHGIMADMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DC50", Offset = "0x5B3D050", VA = "0x185B3DC50", Slot = "14")]
	private LFMHEODBGCI AINDMNMAAMN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E200", Offset = "0x5B3D600", VA = "0x185B3E200", Slot = "15")]
	private IEPLNCDMOAJ OEEFBGKJMBE(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DD10", Offset = "0x5B3D110", VA = "0x185B3DD10", Slot = "16")]
	private NNIKCNPIEIG JJMIFMLGGCB(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E2C0", Offset = "0x5B3D6C0", VA = "0x185B3E2C0", Slot = "17")]
	private EELEJHNFDJM NGHPDHBOHOF(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5B3E0F0", Offset = "0x5B3D4F0", VA = "0x185B3E0F0", Slot = "18")]
	private MMONDIHOKIN FODHMDDBKFJ(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JHBBCOEKLFJ : DPMOENNEEJC, GKMLGKADIJC
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool GKDECOKBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5B42AB0", Offset = "0x5B41EB0", VA = "0x185B42AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A5D0", Offset = "0x5B599D0", VA = "0x185B5A5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5B5AD00", Offset = "0x5B5A100", VA = "0x185B5AD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private bool ECKPGNEHIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5B5AC10", Offset = "0x5B5A010", VA = "0x185B5AC10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5B5AD60", Offset = "0x5B5A160", VA = "0x185B5AD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private bool ECCICEJKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A9D0", Offset = "0x5B59DD0", VA = "0x185B5A9D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A330", Offset = "0x5B59730", VA = "0x185B5A330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private int FDGEABBOEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A4D0", Offset = "0x5B598D0", VA = "0x185B5A4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event ELIHEGNOPEG IBIENMBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5B5AB70", Offset = "0x5B59F70", VA = "0x185B5AB70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A430", Offset = "0x5B59830", VA = "0x185B5A430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5B5AFC0", Offset = "0x5B5A3C0", VA = "0x185B5AFC0")]
	public JHBBCOEKLFJ(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5B5AAC0", Offset = "0x5B59EC0", VA = "0x185B5AAC0", Slot = "6")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A630", Offset = "0x5B59A30", VA = "0x185B5A630", Slot = "8")]
	public void DFLCAEDMDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A640", Offset = "0x5B59A40", VA = "0x185B5A640", Slot = "7")]
	public bool DGEIDJLIEBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5B5AF10", Offset = "0x5B5A310", VA = "0x185B5AF10", Slot = "9")]
	public void PDFPHCJBIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5B49C30", Offset = "0x5B49030", VA = "0x185B49C30", Slot = "12")]
	public void MMGNIMIBHCI(bool NNFJFPAHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5B5AE60", Offset = "0x5B5A260", VA = "0x185B5AE60", Slot = "11")]
	public void PBBFKBBPONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "10")]
	public void AHIALGIDODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A870", Offset = "0x5B59C70", VA = "0x185B5A870")]
	private void FMDFJLAAGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[EPJIKDLNGEH(typeof(IKBBFODFLBF), new string[] { })]
public class FONGIFGLLKJ : IKBBFODFLBF, NEHPEGODEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly IKBBFODFLBF EGOPAGKBALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IKBBFODFLBF PKDKKELFBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private OEGCJPFACKE AIDLIFMNAKP;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private IKBBFODFLBF OKCKKCOHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x5B4ECD0", Offset = "0x5B4E0D0", VA = "0x185B4ECD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EA50", Offset = "0x5B4DE50", VA = "0x185B4EA50", Slot = "20")]
	public void InitReferences(IABLIMOJJBC CEMAJLICLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E320", Offset = "0x5B4D720", VA = "0x185B4E320", Slot = "4")]
	public OBAIIGLIFII AANGPHEJGCL(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EDD0", Offset = "0x5B4E1D0", VA = "0x185B4EDD0", Slot = "5")]
	public MHNEMBOIFAD PJFPBFHAOML(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E850", Offset = "0x5B4DC50", VA = "0x185B4E850", Slot = "6")]
	public FKEJKJMGAFO HFENCANGDKE(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E5C0", Offset = "0x5B4D9C0", VA = "0x185B4E5C0", Slot = "7")]
	public EGCGLKGHOFP DMAFMKOHEOO(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E700", Offset = "0x5B4DB00", VA = "0x185B4E700", Slot = "8")]
	public GKMLGKADIJC FJJAEBDHJCF(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4ED30", Offset = "0x5B4E130", VA = "0x185B4ED30", Slot = "9")]
	public PBCPIOEBFAD NHOFOAJBICP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EAA0", Offset = "0x5B4DEA0", VA = "0x185B4EAA0", Slot = "10")]
	public AHHPIAHJIJI JPDJFGCACIC(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EB40", Offset = "0x5B4DF40", VA = "0x185B4EB40", Slot = "11")]
	public LEHPGJCNDCB KACEDDKEFEG(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E660", Offset = "0x5B4DA60", VA = "0x185B4E660", Slot = "12")]
	public GFNKAKPEMKH EGPGDBFFMGP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E520", Offset = "0x5B4D920", VA = "0x185B4E520", Slot = "13")]
	public AMGJBKJIDFC DEBMICHCJJB(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E3C0", Offset = "0x5B4D7C0", VA = "0x185B4E3C0")]
	public LFMHEODBGCI LHMFGADFIGL(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E8F0", Offset = "0x5B4DCF0", VA = "0x185B4E8F0")]
	public IEPLNCDMOAJ INPLBNCPOAN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E470", Offset = "0x5B4D870", VA = "0x185B4E470")]
	public NNIKCNPIEIG CHPLFLHKPHP(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E9A0", Offset = "0x5B4DDA0", VA = "0x185B4E9A0")]
	public EELEJHNFDJM IOEEPDHBIJA(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E7A0", Offset = "0x5B4DBA0", VA = "0x185B4E7A0")]
	public MMONDIHOKIN OFLCBPMNJIG(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EBE0", Offset = "0x5B4DFE0", VA = "0x185B4EBE0", Slot = "19")]
	public NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ, MDEEPGFJICJ CHLJPKFIHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4EE70", Offset = "0x5B4E270", VA = "0x185B4EE70")]
	public FONGIFGLLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E3C0", Offset = "0x5B4D7C0", VA = "0x185B4E3C0", Slot = "14")]
	private LFMHEODBGCI AINDMNMAAMN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E8F0", Offset = "0x5B4DCF0", VA = "0x185B4E8F0", Slot = "15")]
	private IEPLNCDMOAJ OEEFBGKJMBE(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E470", Offset = "0x5B4D870", VA = "0x185B4E470", Slot = "16")]
	private NNIKCNPIEIG JJMIFMLGGCB(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E9A0", Offset = "0x5B4DDA0", VA = "0x185B4E9A0", Slot = "17")]
	private EELEJHNFDJM NGHPDHBOHOF(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E7A0", Offset = "0x5B4DBA0", VA = "0x185B4E7A0", Slot = "18")]
	private MMONDIHOKIN FODHMDDBKFJ(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class MEDJMEDLMIG : DPMOENNEEJC, AMGJBKJIDFC
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B330", Offset = "0x5B5A730", VA = "0x185B5B330", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B540", Offset = "0x5B5A940", VA = "0x185B5B540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public MEDJMEDLMIG(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5B5B420", Offset = "0x5B5A820", VA = "0x185B5B420", Slot = "6")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5B55340", Offset = "0x5B54740", VA = "0x185B55340", Slot = "7")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class DPMOENNEEJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly MMFJMOCJFKG LDOEEENLAJO;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected FIOENEMHNNB PIFKHFKELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x28DA770", Offset = "0x28D9B70", VA = "0x1828DA770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B6A0", Offset = "0x5B4AAA0", VA = "0x185B4B6A0")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public DPMOENNEEJC(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B580", Offset = "0x5B4A980", VA = "0x185B4B580")]
	protected NCGMOGGOLJC GIEMHHKPEML(HEKFLAGDMLJ JBFCCDGDFOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class DPEBFIMMKFA : DPMOENNEEJC, IEPLNCDMOAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PhotonView IEGPKLGPBPH;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B380", Offset = "0x5B4A780", VA = "0x185B4B380", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B3A0", Offset = "0x5B4A7A0", VA = "0x185B4B3A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ELIHEGNOPEG OELFJEKIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B130", Offset = "0x5B4A530", VA = "0x185B4B130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5B4AD30", Offset = "0x5B4A130", VA = "0x185B4AD30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B4F0", Offset = "0x5B4A8F0", VA = "0x185B4B4F0")]
	public DPEBFIMMKFA(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AFE0", Offset = "0x5B4A3E0", VA = "0x185B4AFE0", Slot = "8")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A940", Offset = "0x5B49D40", VA = "0x185B4A940", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A500", Offset = "0x5B49900", VA = "0x185B4A500", Slot = "9")]
	public void ADANEAPHPNN(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5B4ADD0", Offset = "0x5B4A1D0", VA = "0x185B4ADD0", Slot = "10")]
	public void HMIMDEOPKNL(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A710", Offset = "0x5B49B10", VA = "0x185B4A710")]
	private void BOOFLOPCFEP(PhotonView EBHAONEMBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B1D0", Offset = "0x5B4A5D0", VA = "0x185B4B1D0")]
	private void LPGAPBEBCMA(RigidbodyEx JLOHMGNAFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5B4AB50", Offset = "0x5B49F50", VA = "0x185B4AB50")]
	private void FJIGGEPKBEO(PhotonView PNILBPJGAMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class EAOOPKKHKHE
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B6D0", Offset = "0x5B4AAD0", VA = "0x185B4B6D0")]
	public static DPEBFIMMKFA HKNCEJNPJII(this GIIKJICOFOC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class HLHMAJCIPNA : DPMOENNEEJC, MMONDIHOKIN
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5B55580", Offset = "0x5B54980", VA = "0x185B55580", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x5B55670", Offset = "0x5B54A70", VA = "0x185B55670", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool JEFMAODCONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x5B55B90", Offset = "0x5B54F90", VA = "0x185B55B90", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x5B55860", Offset = "0x5B54C60", VA = "0x185B55860")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x5B55770", Offset = "0x5B54B70", VA = "0x185B55770", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5B55C80", Offset = "0x5B55080", VA = "0x185B55C80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5B55E90", Offset = "0x5B55290", VA = "0x185B55E90")]
	public HLHMAJCIPNA(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5B55A70", Offset = "0x5B54E70", VA = "0x185B55A70", Slot = "9")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5B55960", Offset = "0x5B54D60", VA = "0x185B55960", Slot = "10")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class CMIDAFMMBDD : DPMOENNEEJC, PBCPIOEBFAD, IDisposable, EGLIMKJGMKP
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public JDKBOLPCEHA KOFGOMJFJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x5B49EC0", Offset = "0x5B492C0", VA = "0x185B49EC0")]
		get
		{
			return default(JDKBOLPCEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A1D0", Offset = "0x5B495D0", VA = "0x185B4A1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5B49FB0", Offset = "0x5B493B0", VA = "0x185B49FB0", Slot = "6")]
		get
		{
			return default(JDKBOLPCEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A1D0", Offset = "0x5B495D0", VA = "0x185B4A1D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private Transform LBEDGMIGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A370", Offset = "0x5B49770", VA = "0x185B4A370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A2D0", Offset = "0x5B496D0", VA = "0x185B4A2D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3B8E0", Offset = "0x5B3ACE0", VA = "0x185B3B8E0")]
	public CMIDAFMMBDD(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5B4A410", Offset = "0x5B49810", VA = "0x185B4A410", Slot = "11")]
	public void OnChangedDistanceBand(FGLEPFCKOAH CBNEMGEKLOD, FGLEPFCKOAH BGDHKJDGOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
	public void OnChangedVisibility(bool OAFKEEFNLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class ONCCJCJDBGB : PBCPIOEBFAD, IDisposable, EGLIMKJGMKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private JDKBOLPCEHA GELDEMKHJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NBLEDJCPAGF BJCLJGMIFKD;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public JDKBOLPCEHA FNHGKHKMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7104BC0", Offset = "0x7103FC0", VA = "0x187104BC0", Slot = "6")]
		get
		{
			return default(JDKBOLPCEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7104CC0", Offset = "0x71040C0", VA = "0x187104CC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private Transform LBEDGMIGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7105190", Offset = "0x7104590", VA = "0x187105190", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FGLEPFCKOAH, FGLEPFCKOAH> IILHHIHEBML
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7105090", Offset = "0x7104490", VA = "0x187105090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7104D90", Offset = "0x7104190", VA = "0x187104D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x71051B0", Offset = "0x71045B0", VA = "0x1871051B0")]
	public ONCCJCJDBGB(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x7104E30", Offset = "0x7104230", VA = "0x187104E30", Slot = "8")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x7104C70", Offset = "0x7104070", VA = "0x187104C70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7105130", Offset = "0x7104530", VA = "0x187105130", Slot = "11")]
	private void NBBBMOCHFKK(FGLEPFCKOAH MKCCIDALIGJ, FGLEPFCKOAH JGAEINHKEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
	private void DDJGEKMJIDK(bool OAFKEEFNLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class NNGOCKKBNNE : GHOKBPPLIHC, IEPLNCDMOAJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PhotonView IEGPKLGPBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool PAANFKAFIFE;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PhotonView KMCGLOFOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool JFBHIKEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x5B4B380", Offset = "0x5B4A780", VA = "0x185B4B380", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool IBNEDDAIIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ELIHEGNOPEG OELFJEKIAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7104A40", Offset = "0x7103E40", VA = "0x187104A40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x71046D0", Offset = "0x7103AD0", VA = "0x1871046D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x7104B60", Offset = "0x7103F60", VA = "0x187104B60")]
	public NNGOCKKBNNE(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x71048F0", Offset = "0x7103CF0", VA = "0x1871048F0", Slot = "9")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x71043D0", Offset = "0x71037D0", VA = "0x1871043D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7104140", Offset = "0x7103540", VA = "0x187104140", Slot = "10")]
	public void ADANEAPHPNN(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7104770", Offset = "0x7103B70", VA = "0x187104770", Slot = "11")]
	public void HMIMDEOPKNL(NCGMOGGOLJC OJBGDMNECON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x71042C0", Offset = "0x71036C0", VA = "0x1871042C0")]
	private void BOOFLOPCFEP(PhotonView EBHAONEMBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7104AE0", Offset = "0x7103EE0", VA = "0x187104AE0")]
	private void LPGAPBEBCMA(RigidbodyEx JLOHMGNAFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x71044E0", Offset = "0x71038E0", VA = "0x1871044E0")]
	private void FJIGGEPKBEO(PhotonView PNILBPJGAMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal static class KKCGDLLCDEL
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5B5B1E0", Offset = "0x5B5A5E0", VA = "0x185B5B1E0")]
	public static GHOKBPPLIHC HKNCEJNPJII(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class OPFCDPGIGDM : LFMHEODBGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GLMKJHJBJDA KLNEEJBCFBA;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7106090", Offset = "0x7105490", VA = "0x187106090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool JPIPMDKPKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8BF010", Offset = "0x8BE410", VA = "0x1808BF010", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x71060E0", Offset = "0x71054E0", VA = "0x1871060E0")]
	public OPFCDPGIGDM(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7105E30", Offset = "0x7105230", VA = "0x187105E30", Slot = "5")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x7105EE0", Offset = "0x71052E0", VA = "0x187105EE0", Slot = "7")]
	public void JOKNGAABFDH(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x71060B0", Offset = "0x71054B0", VA = "0x1871060B0", Slot = "8")]
	public void NLHAGIMAHMP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x7105830", Offset = "0x7104C30", VA = "0x187105830", Slot = "9")]
	public void GEONHNBMDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x7105630", Offset = "0x7104A30", VA = "0x187105630", Slot = "11")]
	public void FNGGFCBNAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7105CB0", Offset = "0x71050B0", VA = "0x187105CB0", Slot = "12")]
	public void INCEGHAHPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x71051F0", Offset = "0x71045F0", VA = "0x1871051F0", Slot = "10")]
	public void BMMKAJHACHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7105F10", Offset = "0x7105310", VA = "0x187105F10")]
	private void KOEFONBAPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7105B30", Offset = "0x7104F30", VA = "0x187105B30")]
	private void HINFDAJNFDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class IECELFOHMJO : MMONDIHOKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private RigidbodyConstraints JAEAAMFNBED;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool HAEFBBMPBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x10623D0", Offset = "0x10617D0", VA = "0x1810623D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x1D35DC0", Offset = "0x1D351C0", VA = "0x181D35DC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool JEFMAODCONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1D35DD0", Offset = "0x1D351D0", VA = "0x181D35DD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1D35DB0", Offset = "0x1D351B0", VA = "0x181D35DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public RigidbodyConstraints PJBOCAIMOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x5B57500", Offset = "0x5B56900", VA = "0x185B57500", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5B57640", Offset = "0x5B56A40", VA = "0x185B57640")]
	public IECELFOHMJO(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5B574D0", Offset = "0x5B568D0", VA = "0x185B574D0", Slot = "9")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5B574A0", Offset = "0x5B568A0", VA = "0x185B574A0", Slot = "10")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class MNBJKAHMCEP : LEHPGJCNDCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AFA0", Offset = "0x5B3A3A0", VA = "0x185B3AFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B600", Offset = "0x5B3AA00", VA = "0x185B3B600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5B5FFA0", Offset = "0x5B5F3A0", VA = "0x185B5FFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A2A0", Offset = "0x5B596A0", VA = "0x185B5A2A0")]
	public MNBJKAHMCEP(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5B5FE40", Offset = "0x5B5F240", VA = "0x185B5FE40", Slot = "4")]
	public void CCMFELGENOG(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B60000", Offset = "0x5B5F400", VA = "0x185B60000")]
	private void EBMKDGBGDBD(Vector3 DGLCECEILBL, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B603E0", Offset = "0x5B5F7E0", VA = "0x185B603E0", Slot = "5")]
	public void HIGGALHBFON(Vector3 DGLCECEILBL, Vector3 FGLOAKJBDBO, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B60280", Offset = "0x5B5F680", VA = "0x185B60280", Slot = "6")]
	public void GGEGEFDLIMF(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B60900", Offset = "0x5B5FD00", VA = "0x185B60900")]
	private void PPKBDGHBLBO(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B60680", Offset = "0x5B5FA80", VA = "0x185B60680", Slot = "7")]
	public void JLEAFFINNHD(Vector3 BJPJHCCKFGH, ForceMode ONLJMMLFHDJ = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class ECDAJLKDHDG : JOJAKNALOHE, FKEJKJMGAFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly HIANALMEENI<NCGMOGGOLJC> MOMNOOGNFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool MFJNJJOKGOM;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public HIANALMEENI<NCGMOGGOLJC> MHBDDLOCHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 ACPLCCODOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BA60", Offset = "0x5B4AE60", VA = "0x185B4BA60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 CMMHHJGMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BB40", Offset = "0x5B4AF40", VA = "0x185B4BB40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C130", Offset = "0x5B4B530", VA = "0x185B4C130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public NCGMOGGOLJC GAPFNOENEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4BA90", Offset = "0x5B4AE90", VA = "0x185B4BA90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C270", Offset = "0x5B4B670", VA = "0x185B4C270")]
	public ECDAJLKDHDG(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B4BD10", Offset = "0x5B4B110", VA = "0x185B4BD10", Slot = "8")]
	public void JEHJBCDADCI(NCGMOGGOLJC OJBGDMNECON, object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C210", Offset = "0x5B4B610", VA = "0x185B4C210", Slot = "9")]
	public void MDINHACLNPC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B4B730", Offset = "0x5B4AB30", VA = "0x185B4B730")]
	private Vector3 ABDFBEEFGKI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B4BD80", Offset = "0x5B4B180", VA = "0x185B4BD80")]
	private void LGOGLEFMPLN(NCGMOGGOLJC AAHAHFMENPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class BJIJKIIHONK
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5B3EEE0", Offset = "0x5B3E2E0", VA = "0x185B3EEE0")]
	public static JOJAKNALOHE HHAPDAAIAKD(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class BOCIOHJJGCL : NOEGLLKEKKA, EELEJHNFDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OverridableVector3 JAHEMHCOHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OverridableVector3 JFOPBIMEOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float BDBMEBNCLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float HEFLELEADFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Vector3 OMIHAIJGEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Vector3? OAIPLLGEDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Quaternion? DMENBEGNAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool KPGINKGCCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool BNLIJIDOIBM;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 LGHEJBHDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC090", Offset = "0x8CB490", VA = "0x1808CC090", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x5B45BF0", Offset = "0x5B44FF0", VA = "0x185B45BF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 JONCNKMGBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5B45CA0", Offset = "0x5B450A0", VA = "0x185B45CA0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float GMKMEKKFPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xC2F780", Offset = "0xC2EB80", VA = "0x180C2F780", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x5B45A20", Offset = "0x5B44E20", VA = "0x185B45A20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float ODLJDAMGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CC080", Offset = "0x8CB480", VA = "0x1808CC080", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5B45B40", Offset = "0x5B44F40", VA = "0x185B45B40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 ADLLCMIHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x5B461A0", Offset = "0x5B455A0", VA = "0x185B461A0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Quaternion LFIIADAKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B46310", Offset = "0x5B45710", VA = "0x185B46310", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B45F20", Offset = "0x5B45320", VA = "0x185B45F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ELIHEGNOPEG AODCGBNNAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5B46940", Offset = "0x5B45D40", VA = "0x185B46940", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5B48190", Offset = "0x5B47590", VA = "0x185B48190", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B48230", Offset = "0x5B47630", VA = "0x185B48230")]
	public BOCIOHJJGCL(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B47FC0", Offset = "0x5B473C0", VA = "0x185B47FC0", Slot = "17")]
	public void PICHCOMHIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B45F70", Offset = "0x5B45370", VA = "0x185B45F70", Slot = "16")]
	public void HEDLCKMDLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5B47C10", Offset = "0x5B47010", VA = "0x185B47C10", Slot = "19")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B469E0", Offset = "0x5B45DE0", VA = "0x185B469E0", Slot = "20")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B47E60", Offset = "0x5B47260", VA = "0x185B47E60", Slot = "18")]
	public void OPHCKNJDABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B46480", Offset = "0x5B45880", VA = "0x185B46480", Slot = "21")]
	public void IPGHJIHGELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B45BF0", Offset = "0x5B44FF0", VA = "0x185B45BF0")]
	private void COHHBPFEOGP(Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B46090", Offset = "0x5B45490", VA = "0x185B46090")]
	[Obsolete]
	private Vector3 HMIOHPCILOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B45A20", Offset = "0x5B44E20", VA = "0x185B45A20")]
	private void KGGHPCKJHMH(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B45B40", Offset = "0x5B44F40", VA = "0x185B45B40")]
	private void BMIKFCMBODE(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B47CF0", Offset = "0x5B470F0", VA = "0x185B47CF0")]
	private Vector3 OFHIKMCPNBL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B46BD0", Offset = "0x5B45FD0", VA = "0x185B46BD0", Slot = "15")]
	public void KCFEFGAMIAB((Quaternion rot, Vector3 moments) GHDEIKNJGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B45DB0", Offset = "0x5B451B0", VA = "0x185B45DB0")]
	private Quaternion ELGFKFNABEI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B47B30", Offset = "0x5B46F30", VA = "0x185B47B30")]
	public void MABINJOIHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B46E10", Offset = "0x5B46210", VA = "0x185B46E10", Slot = "4")]
	public (float, Vector3) MABINJOIHNC(Rigidbody BIMEOLEJKOG)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class NGIPAKPFANC
{
	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x71040C0", Offset = "0x71034C0", VA = "0x1871040C0")]
	public static NOEGLLKEKKA FFPJJBOIHDL(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface JOJAKNALOHE : FKEJKJMGAFO
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	HIANALMEENI<NCGMOGGOLJC> MHBDDLOCHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	NCGMOGGOLJC GAPFNOENEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class BNDHOALANBB : MHNEMBOIFAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly GLMKJHJBJDA JEMAOJCKMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float LIBKIHNMBEC;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public DEOHHMCHBDP NLKDIBHEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public PIHEGONEGJC BKDCKNHAMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 EGPIMAAGMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B449D0", Offset = "0x5B43DD0", VA = "0x185B449D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x5B44910", Offset = "0x5B43D10", VA = "0x185B44910", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 HFBGEAOFIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5B44820", Offset = "0x5B43C20", VA = "0x185B44820", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B42B90", Offset = "0x5B41F90", VA = "0x185B42B90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 HFJMOPEHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B44C50", Offset = "0x5B44050", VA = "0x185B44C50", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B43CD0", Offset = "0x5B430D0", VA = "0x185B43CD0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 BIDJPDDCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B44570", Offset = "0x5B43970", VA = "0x185B44570", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x5B44200", Offset = "0x5B43600", VA = "0x185B44200", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float LHKEKDPDMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xC2F7C0", Offset = "0xC2EBC0", VA = "0x180C2F7C0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x5B45110", Offset = "0x5B44510", VA = "0x185B45110", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool GLIGEFNNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x974940", Offset = "0x973D40", VA = "0x180974940", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private LEHPGJCNDCB HNPDEOBNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0300", Offset = "0x1FDF700", VA = "0x181FE0300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private bool GKDECOKBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B42AB0", Offset = "0x5B41EB0", VA = "0x185B42AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B45940", Offset = "0x5B44D40", VA = "0x185B45940")]
	public BNDHOALANBB(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B42EC0", Offset = "0x5B422C0", VA = "0x185B42EC0", Slot = "19")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B43A90", Offset = "0x5B42E90", VA = "0x185B43A90", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B44FE0", Offset = "0x5B443E0", VA = "0x185B44FE0", Slot = "28")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x973ED0", Offset = "0x9732D0", VA = "0x180973ED0", Slot = "20")]
	public void DMAGDBMMDIC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x973EB0", Offset = "0x9732B0", VA = "0x180973EB0", Slot = "30")]
	public void MDJMBEKOCCK(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B45270", Offset = "0x5B44670", VA = "0x185B45270", Slot = "35")]
	public Vector3 OLOJKEJOJOH(Vector3 HNDHEPCHDJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B44660", Offset = "0x5B43A60", VA = "0x185B44660", Slot = "34")]
	public Vector3 IMGMCCAEEGL(Vector3 HCOFOPDNEPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5B42EC0", Offset = "0x5B422C0", VA = "0x185B42EC0", Slot = "27")]
	public void BNMCOBBCIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5B43AF0", Offset = "0x5B42EF0", VA = "0x185B43AF0", Slot = "25")]
	public void EEKOFCBBFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B45230", Offset = "0x5B44630", VA = "0x185B45230", Slot = "24")]
	public void OILGEJECDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B44230", Offset = "0x5B43630", VA = "0x185B44230", Slot = "33")]
	public void HDLNAJENDEP(Vector3 JGPBJCBOKNL, Vector3 MBGGEBDKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B441A0", Offset = "0x5B435A0", VA = "0x185B441A0", Slot = "32")]
	public void FBHOBFGLOLA(Vector3 LPBHCFOANKC, Vector3 GLJMNNPFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B44D80", Offset = "0x5B44180", VA = "0x185B44D80", Slot = "31")]
	public void MLAAAIFLNKB(Vector3 NOEMEMLNICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B45450", Offset = "0x5B44850", VA = "0x185B45450", Slot = "22")]
	public void ONALPNJLCON(EJFFJHNIKMI IMDELDIDJFD, Vector3 AKBJFPEBMKM, float LFPLGLNBEMG, float GNDMGKKOPPA = 8f, float FANMOPGIGEE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B43530", Offset = "0x5B42930", VA = "0x185B43530", Slot = "21")]
	public void CFGKOEIJAFC(CDHNIIFJBPG EIDMEBMEOFF, Vector3 JHLLBKFCHJM, float BFJENEIOPJP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B42BC0", Offset = "0x5B41FC0", VA = "0x185B42BC0", Slot = "23")]
	[Obsolete]
	public void BIFLKPEMPEE(CDHNIIFJBPG EIDMEBMEOFF, Vector3 OCEJJKMFIJB, float BMOGNEGDLMM = 7f, float NDOICOFLJGP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B42AD0", Offset = "0x5B41ED0", VA = "0x185B42AD0", Slot = "29")]
	public Vector3 AJCMHLLPEGB(Vector3 EDAEDABCFDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B44AF0", Offset = "0x5B43EF0", VA = "0x185B44AF0", Slot = "26")]
	public void MJDGFHOJNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B45110", Offset = "0x5B44510", VA = "0x185B45110")]
	private void ODDDHNCAMHO(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B43B30", Offset = "0x5B42F30", VA = "0x185B43B30")]
	private void EHFJHAANLGC(Vector3 JHLLBKFCHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B43D90", Offset = "0x5B43190", VA = "0x185B43D90")]
	private Vector3 ELDBAIDDHNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5B43E80", Offset = "0x5B43280", VA = "0x185B43E80")]
	private void ELDHKBLKCOM(Vector3 HCOFOPDNEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B44470", Offset = "0x5B43870", VA = "0x185B44470")]
	private Vector3 HFPOCNEJCHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B43760", Offset = "0x5B42B60", VA = "0x185B43760")]
	private void DABIBKBLAAP(Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B42F30", Offset = "0x5B42330", VA = "0x185B42F30")]
	private void CEPACLIELHO(Vector3 HCOFOPDNEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B44F20", Offset = "0x5B44320", VA = "0x185B44F20")]
	private void NGEFODALPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class FMAPIIKKMKI : AHHPIAHJIJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GLMKJHJBJDA KKDJOJLELJD;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool IOPFDHGCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DF70", Offset = "0x5B4D370", VA = "0x185B4DF70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ELIHEGNOPEG MLINHCJFPMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5B4E190", Offset = "0x5B4D590", VA = "0x185B4E190", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x5B4DED0", Offset = "0x5B4D2D0", VA = "0x185B4DED0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E240", Offset = "0x5B4D640", VA = "0x185B4E240")]
	public FMAPIIKKMKI(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E040", Offset = "0x5B4D440", VA = "0x185B4E040", Slot = "11")]
	public IDisposable GPKALIHNCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E230", Offset = "0x5B4D630", VA = "0x185B4E230", Slot = "8")]
	public void PBLEBGEAFIJ(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DDC0", Offset = "0x5B4D1C0", VA = "0x185B4DDC0", Slot = "9")]
	public void ACECBHDGJAP(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5B4DDD0", Offset = "0x5B4D1D0", VA = "0x185B4DDD0", Slot = "10")]
	public void BDKBNPPAIAI(object AEMEEHLIDCM, bool PILGGODJCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E0D0", Offset = "0x5B4D4D0", VA = "0x185B4E0D0", Slot = "6")]
	public void KIGKKDFFFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E110", Offset = "0x5B4D510", VA = "0x185B4E110", Slot = "12")]
	public void NPFPPHNMPFN(Rigidbody MOJFAKMKAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5B4E0A0", Offset = "0x5B4D4A0", VA = "0x185B4E0A0", Slot = "13")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal sealed class JCBFHCPALMK : GFNKAKPEMKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CollisionDetectionMode PFGJFMAKIOB;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADF0", Offset = "0x5B3A1F0", VA = "0x185B3ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CollisionDetectionMode LLEBKDIAAII
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5B59E00", Offset = "0x5B59200", VA = "0x185B59E00", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A080", Offset = "0x5B59480", VA = "0x185B5A080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A2A0", Offset = "0x5B596A0", VA = "0x185B5A2A0")]
	public JCBFHCPALMK(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A0F0", Offset = "0x5B594F0", VA = "0x185B5A0F0", Slot = "6")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A220", Offset = "0x5B59620", VA = "0x185B5A220", Slot = "9")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5B5A210", Offset = "0x5B59610", VA = "0x185B5A210", Slot = "7")]
	public void NGGALKCGKPB(bool DDKLJJCFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5B59DF0", Offset = "0x5B591F0", VA = "0x185B59DF0", Slot = "8")]
	public void EKFDPDOIELI(bool DDKLJJCFMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5B59F10", Offset = "0x5B59310", VA = "0x185B59F10", Slot = "10")]
	public bool GIJFHIBJHNG(Vector3 GCNKNLGIDOA, out RaycastHit JDDOPHGBFAC, float AKODDLNKMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5B59CC0", Offset = "0x5B590C0", VA = "0x185B59CC0")]
	private void AENCJCPCKMJ(bool DDKLJJCFMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HNNDJHEGBGE : IKBBFODFLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5B560E0", Offset = "0x5B554E0", VA = "0x185B560E0", Slot = "4")]
	public OBAIIGLIFII AANGPHEJGCL(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5B56C70", Offset = "0x5B56070", VA = "0x185B56C70", Slot = "5")]
	public MHNEMBOIFAD PJFPBFHAOML(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5B566F0", Offset = "0x5B55AF0", VA = "0x185B566F0", Slot = "6")]
	public FKEJKJMGAFO HFENCANGDKE(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5B56420", Offset = "0x5B55820", VA = "0x185B56420", Slot = "7")]
	public EGCGLKGHOFP DMAFMKOHEOO(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x5B56540", Offset = "0x5B55940", VA = "0x185B56540", Slot = "8")]
	public GKMLGKADIJC FJJAEBDHJCF(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x5B56C10", Offset = "0x5B56010", VA = "0x185B56C10", Slot = "9")]
	public PBCPIOEBFAD NHOFOAJBICP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x5B569B0", Offset = "0x5B55DB0", VA = "0x185B569B0", Slot = "10")]
	public AHHPIAHJIJI JPDJFGCACIC(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x5B56AB0", Offset = "0x5B55EB0", VA = "0x185B56AB0", Slot = "11")]
	public LEHPGJCNDCB KACEDDKEFEG(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5B56490", Offset = "0x5B55890", VA = "0x185B56490", Slot = "12")]
	public GFNKAKPEMKH EGPGDBFFMGP(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5B56360", Offset = "0x5B55760", VA = "0x185B56360", Slot = "13")]
	public AMGJBKJIDFC DEBMICHCJJB(NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5B561D0", Offset = "0x5B555D0", VA = "0x185B561D0")]
	public LFMHEODBGCI LHMFGADFIGL(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5B56810", Offset = "0x5B55C10", VA = "0x185B56810")]
	public IEPLNCDMOAJ INPLBNCPOAN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5B56240", Offset = "0x5B55640", VA = "0x185B56240")]
	public NNIKCNPIEIG CHPLFLHKPHP(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x5B56880", Offset = "0x5B55C80", VA = "0x185B56880")]
	public EELEJHNFDJM IOEEPDHBIJA(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x5B56620", Offset = "0x5B55A20", VA = "0x185B56620")]
	public MMONDIHOKIN OFLCBPMNJIG(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5B56B60", Offset = "0x5B55F60", VA = "0x185B56B60", Slot = "19")]
	public NCGMOGGOLJC LNMBDJECAJN(RigidbodyEx LDOEEENLAJO, IAPDAIABMEI CLCAIFLMLCJ, MDEEPGFJICJ CHLJPKFIHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public HNNDJHEGBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5B561D0", Offset = "0x5B555D0", VA = "0x185B561D0", Slot = "14")]
	private LFMHEODBGCI AINDMNMAAMN(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5B56810", Offset = "0x5B55C10", VA = "0x185B56810", Slot = "15")]
	private IEPLNCDMOAJ OEEFBGKJMBE(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5B56240", Offset = "0x5B55640", VA = "0x185B56240", Slot = "16")]
	private NNIKCNPIEIG JJMIFMLGGCB(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5B56880", Offset = "0x5B55C80", VA = "0x185B56880", Slot = "17")]
	private EELEJHNFDJM NGHPDHBOHOF(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5B56620", Offset = "0x5B55A20", VA = "0x185B56620", Slot = "18")]
	private MMONDIHOKIN FODHMDDBKFJ(NCGMOGGOLJC JGNMLMMCBGP, in IAPDAIABMEI CLCAIFLMLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class AODPOKAANNH : IOEOAKFDDGO, OBAIIGLIFII, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly NCGMOGGOLJC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<NCGMOGGOLJC> LEGMMMPKLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private NCGMOGGOLJC AOCBEEBNJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NCGMOGGOLJC OJBGDMNECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform JMHFHDCIJCB;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Transform BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C480", Offset = "0x5B3B880", VA = "0x185B3C480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CDF0", Offset = "0x5B3C1F0", VA = "0x185B3CDF0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public NCGMOGGOLJC LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IReadOnlyList<NCGMOGGOLJC> JDPCIFFDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event ELIHEGNOPEG DPPGNFNPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C7E0", Offset = "0x5B3BBE0", VA = "0x185B3C7E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C600", Offset = "0x5B3BA00", VA = "0x185B3C600", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event ELIHEGNOPEG JEIIIGJGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CE00", Offset = "0x5B3C200", VA = "0x185B3CE00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D9F0", Offset = "0x5B3CDF0", VA = "0x185B3D9F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event IDLODEKJPBI BJDJOGDNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D360", Offset = "0x5B3C760", VA = "0x185B3D360", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CFE0", Offset = "0x5B3C3E0", VA = "0x185B3CFE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action MJOMGFFFCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D6F0", Offset = "0x5B3CAF0", VA = "0x185B3D6F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D400", Offset = "0x5B3C800", VA = "0x185B3D400", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action DMEICIJBIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C6A0", Offset = "0x5B3BAA0", VA = "0x185B3C6A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CD50", Offset = "0x5B3C150", VA = "0x185B3CD50", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<NCGMOGGOLJC> PFKGANDHCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x5B3DA90", Offset = "0x5B3CE90", VA = "0x185B3DA90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C9B0", Offset = "0x5B3BDB0", VA = "0x185B3C9B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<NCGMOGGOLJC> ACEOCEJIIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C740", Offset = "0x5B3BB40", VA = "0x185B3C740", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CEA0", Offset = "0x5B3C2A0", VA = "0x185B3CEA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action JIMCINENMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CF40", Offset = "0x5B3C340", VA = "0x185B3CF40", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D170", Offset = "0x5B3C570", VA = "0x185B3D170", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<NCGMOGGOLJC> GKBIPNMDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CA50", Offset = "0x5B3BE50", VA = "0x185B3CA50", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C3E0", Offset = "0x5B3B7E0", VA = "0x185B3C3E0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x5B3DB30", Offset = "0x5B3CF30", VA = "0x185B3DB30")]
	public AODPOKAANNH(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C4E0", Offset = "0x5B3B8E0", VA = "0x185B3C4E0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x5B3BE10", Offset = "0x5B3B210", VA = "0x185B3BE10", Slot = "30")]
	public void CILNNMACHKK(NCGMOGGOLJC ICPFLJENDFI, bool ECPEOFEOOHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D4A0", Offset = "0x5B3C8A0", VA = "0x185B3D4A0", Slot = "6")]
	public void NILGCEFECPE(NCGMOGGOLJC AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x5B3CAF0", Offset = "0x5B3BEF0", VA = "0x185B3CAF0", Slot = "7")]
	public void HGKIKABGAIF(NCGMOGGOLJC AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C910", Offset = "0x5B3BD10", VA = "0x185B3C910", Slot = "4")]
	public void GKKELJKGEHE(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C560", Offset = "0x5B3B960", VA = "0x185B3C560", Slot = "5")]
	public void EFGKFCOBOBC(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C880", Offset = "0x5B3BC80", VA = "0x185B3C880")]
	private void GBNKCMIGEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5B3C3A0", Offset = "0x5B3B7A0", VA = "0x185B3C3A0")]
	private void CKNPMPBKFGC(NCGMOGGOLJC AIACOCFNFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D210", Offset = "0x5B3C610", VA = "0x185B3D210")]
	private void MILOMENKFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D790", Offset = "0x5B3CB90", VA = "0x185B3D790")]
	private void NOOJAFENDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D8C0", Offset = "0x5B3CCC0", VA = "0x185B3D8C0")]
	private void OBJHHAIKDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5B3D080", Offset = "0x5B3C480", VA = "0x185B3D080")]
	[CompilerGenerated]
	private object LOHAFKBNMHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal static class EKGGGPFOBNG
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5B4C360", Offset = "0x5B4B760", VA = "0x185B4C360")]
	public static IOEOAKFDDGO LJHMBDPCDOC(this NCGMOGGOLJC JGNMLMMCBGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class CGBHKJKPPPJ : NNIKCNPIEIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly GLMKJHJBJDA IJMBIKHEEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HIECNPEDPHM IAEICMCBOLA;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool DDEHEDMAJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF010", Offset = "0x8BE410", VA = "0x1808BF010", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public HIECNPEDPHM GOKPJCPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "11")]
		get
		{
			return default(HIECNPEDPHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5B49530", Offset = "0x5B48930", VA = "0x185B49530")]
	public CGBHKJKPPPJ(NCGMOGGOLJC LDOEEENLAJO, in IAPDAIABMEI CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5B491A0", Offset = "0x5B485A0", VA = "0x185B491A0", Slot = "4")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5B49430", Offset = "0x5B48830", VA = "0x185B49430")]
	private bool NDJDAJDAIHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5B49500", Offset = "0x5B48900", VA = "0x185B49500", Slot = "5")]
	public void NHIGIGKHNPC(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5B494D0", Offset = "0x5B488D0", VA = "0x185B494D0", Slot = "6")]
	public void NFFHDDPAMGB(object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5B48F20", Offset = "0x5B48320", VA = "0x185B48F20", Slot = "9")]
	public void EMGKBBNOLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5B49050", Offset = "0x5B48450", VA = "0x185B49050")]
	private void HCAMIMIHBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5B49270", Offset = "0x5B48670", VA = "0x185B49270")]
	private void KCFMLANKGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5B49160", Offset = "0x5B48560", VA = "0x185B49160", Slot = "8")]
	public void HDHNAGLIDII(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5B493F0", Offset = "0x5B487F0", VA = "0x185B493F0", Slot = "7")]
	public void MGNPHDFIGEA(NCGMOGGOLJC LDOEEENLAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NOEGLLKEKKA : EELEJHNFDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) MABINJOIHNC(Rigidbody BIMEOLEJKOG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface IOEOAKFDDGO : OBAIIGLIFII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKKELJKGEHE(NCGMOGGOLJC LDOEEENLAJO);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGKFCOBOBC(NCGMOGGOLJC LDOEEENLAJO);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NILGCEFECPE(NCGMOGGOLJC AIACOCFNFIN);

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HGKIKABGAIF(NCGMOGGOLJC AIACOCFNFIN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class HIAJCHMDNBG : AMGJBKJIDFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool JDDNIBAEAOP;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool GIFHPFBLOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x5B553E0", Offset = "0x5B547E0", VA = "0x185B553E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5B554F0", Offset = "0x5B548F0", VA = "0x185B554F0")]
	public HIAJCHMDNBG(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5B553B0", Offset = "0x5B547B0", VA = "0x185B553B0", Slot = "6")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5B55340", Offset = "0x5B54740", VA = "0x185B55340", Slot = "7")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class IIPGNEEBNKE : GKMLGKADIJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly GIIKJICOFOC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool CEDAIHJJBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool GPANKEPJANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int ALONJDCNGDE;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private Rigidbody BHLLKFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5B45F20", Offset = "0x5B45320", VA = "0x185B45F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private bool GKDECOKBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5B58170", Offset = "0x5B57570", VA = "0x185B58170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private NCGMOGGOLJC BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5B57930", Offset = "0x5B56D30", VA = "0x185B57930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool AADCIPIJFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5B57DD0", Offset = "0x5B571D0", VA = "0x185B57DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ELIHEGNOPEG IBIENMBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5B57D30", Offset = "0x5B57130", VA = "0x185B57D30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5B57890", Offset = "0x5B56C90", VA = "0x185B57890", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x5B58190", Offset = "0x5B57590", VA = "0x185B58190")]
	public IIPGNEEBNKE(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x5B57C90", Offset = "0x5B57090", VA = "0x185B57C90", Slot = "6")]
	public void JGIDPLFHMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x5B57990", Offset = "0x5B56D90", VA = "0x185B57990", Slot = "8")]
	public void DFLCAEDMDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x5B579A0", Offset = "0x5B56DA0", VA = "0x185B579A0", Slot = "7")]
	public bool DGEIDJLIEBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5B57F10", Offset = "0x5B57310", VA = "0x185B57F10", Slot = "9")]
	public void PDFPHCJBIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5B57E70", Offset = "0x5B57270", VA = "0x185B57E70", Slot = "11")]
	public void PBBFKBBPONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5B57E30", Offset = "0x5B57230", VA = "0x185B57E30", Slot = "12")]
	public void MMGNIMIBHCI(bool NNFJFPAHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5B576E0", Offset = "0x5B56AE0", VA = "0x185B576E0", Slot = "10")]
	public void AHIALGIDODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x5B57FB0", Offset = "0x5B573B0", VA = "0x185B57FB0")]
	private bool PEIHJODMLGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5B57B00", Offset = "0x5B56F00", VA = "0x185B57B00")]
	private void FMDFJLAAGAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FBJNABDLDKO : EGCGLKGHOFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NCGMOGGOLJC LDOEEENLAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float ODPCCEIIAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private float KGIGLEACBMK;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float AGHIMPLBGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x985820", Offset = "0x984C20", VA = "0x180985820", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D2F0", Offset = "0x5B4C6F0", VA = "0x185B4D2F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float MHGJBEEHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x985810", Offset = "0x984C10", VA = "0x180985810", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D130", Offset = "0x5B4C530", VA = "0x185B4D130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D3C0", Offset = "0x5B4C7C0", VA = "0x185B4D3C0")]
	public FBJNABDLDKO(NCGMOGGOLJC LDOEEENLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D2A0", Offset = "0x5B4C6A0", VA = "0x185B4D2A0", Slot = "8")]
	public void NPFPPHNMPFN(Rigidbody AHLEEGMGCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5B4D200", Offset = "0x5B4C600", VA = "0x185B4D200", Slot = "9")]
	public void JLDPONOIEBN(Rigidbody AHLEEGMGCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface GHOKBPPLIHC : IEPLNCDMOAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PhotonView KMCGLOFOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NBHAMHKLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x710E050", Offset = "0x710D450", VA = "0x18710E050", Slot = "6")]
		public sealed override void FIPMMMKIJLD(KJGAKLCAAAB IPDGCBIIEII)
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
