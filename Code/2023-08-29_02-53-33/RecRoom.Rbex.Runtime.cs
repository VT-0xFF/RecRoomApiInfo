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
		public static LNCHJMFHBFC UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int HGOEAGHNHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int MFAKHFIANJD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E190", Offset = "0x6E4D590", VA = "0x186E4E190")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E1D0", Offset = "0x6E4D5D0", VA = "0x186E4E1D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E1B0", Offset = "0x6E4D5B0", VA = "0x186E4E1B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HGJHDPGFLKO, [Optional] UnityEngine.Object JNNDIHFHMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HGJHDPGFLKO, [Optional] UnityEngine.Object JNNDIHFHMHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E2C0", Offset = "0x6E4D6C0", VA = "0x186E4E2C0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JIPFGDMBBHI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class GKPKKAMLCLM : CKJAHABHLOJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF1BE50", Offset = "0xF1B250", VA = "0x180F1BE50", Slot = "4")]
		public Vector3 EJOOJLNKBOL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF1BE50", Offset = "0xF1B250", VA = "0x180F1BE50", Slot = "5")]
		public Vector3 IOHDKLJLHFM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GKPKKAMLCLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CKJAHABHLOJ GGDFNEFDHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x59B3720", Offset = "0x59B2B20", VA = "0x1859B3720")]
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
		private static readonly PILIJFIMAJF LMMBOFJBJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool OGDPMLMGDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private EAHCLCDMENH EDKEDLEOENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[DKFFELGGOBP(NKLEIIOOMFD.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[DKFFELGGOBP(NKLEIIOOMFD.SelfAndParent, true, false, false)]
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
		private BBBIHACBHFO physicsInterpolation;

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
		internal EAHCLCDMENH JNJIAANLANL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E4F800", Offset = "0x6E4EC00", VA = "0x186E4F800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> MNIKMGFJGLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx GCNIHIMKBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E50F30", Offset = "0x6E50330", VA = "0x186E50F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx KABGFLLOEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E50ED0", Offset = "0x6E502D0", VA = "0x186E50ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ILDFJHMNOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E51A80", Offset = "0x6E50E80", VA = "0x186E51A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6E52F40", Offset = "0x6E52340", VA = "0x186E52F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform HJKMBOKDOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x990710", Offset = "0x98FB10", VA = "0x180990710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FCDBEGFHINM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x990710", Offset = "0x98FB10", VA = "0x180990710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IKCLPGCCHEM IFFHEHFIFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6E50C30", Offset = "0x6E50030", VA = "0x186E50C30")]
			get
			{
				return default(IKCLPGCCHEM);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E526E0", Offset = "0x6E51AE0", VA = "0x186E526E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KMBEOGBGIDM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E51190", Offset = "0x6E50590", VA = "0x186E51190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JHELJEMIHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E50DB0", Offset = "0x6E501B0", VA = "0x186E50DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CKJAHABHLOJ PEKJBPIFAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E510D0", Offset = "0x6E504D0", VA = "0x186E510D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6E528F0", Offset = "0x6E51CF0", VA = "0x186E528F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BJHOFABHIPO PPBCHFPJNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6E51070", Offset = "0x6E50470", VA = "0x186E51070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6E52880", Offset = "0x6E51C80", VA = "0x186E52880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HHKAMPHDMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E50F60", Offset = "0x6E50360", VA = "0x186E50F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody ANHFJLADDLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E50FC0", Offset = "0x6E503C0", VA = "0x186E50FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GJCJNFANJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E50E10", Offset = "0x6E50210", VA = "0x186E50E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E527A0", Offset = "0x6E51BA0", VA = "0x186E527A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EMHNNIELJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x16C1A40", Offset = "0x16C0E40", VA = "0x1816C1A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3406590", Offset = "0x3405990", VA = "0x183406590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float GAENOBMELFL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6E51A20", Offset = "0x6E50E20", VA = "0x186E51A20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float IJHDENPEBHM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6E519C0", Offset = "0x6E50DC0", VA = "0x186E519C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6E52ED0", Offset = "0x6E522D0", VA = "0x186E52ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float FENJALIMCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E513E0", Offset = "0x6E507E0", VA = "0x186E513E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E52B80", Offset = "0x6E51F80", VA = "0x186E52B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KCMLGKKALGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E511F0", Offset = "0x6E505F0", VA = "0x186E511F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6E52960", Offset = "0x6E51D60", VA = "0x186E52960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool PDLAIGCKACG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6E51F50", Offset = "0x6E51350", VA = "0x186E51F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E53430", Offset = "0x6E52830", VA = "0x186E53430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 IEBODNINOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E517C0", Offset = "0x6E50BC0", VA = "0x186E517C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E52CC0", Offset = "0x6E520C0", VA = "0x186E52CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 ONBKJEAHOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E52080", Offset = "0x6E51480", VA = "0x186E52080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode OAFAJBEICIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E51320", Offset = "0x6E50720", VA = "0x186E51320")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E52AA0", Offset = "0x6E51EA0", VA = "0x186E52AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float HLEBFPJBDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E50E70", Offset = "0x6E50270", VA = "0x186E50E70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6E52810", Offset = "0x6E51C10", VA = "0x186E52810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints JKGGBHCJEBE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E51380", Offset = "0x6E50780", VA = "0x186E51380")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6E52B10", Offset = "0x6E51F10", VA = "0x186E52B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 IDDOOAHCHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E51AE0", Offset = "0x6E50EE0", VA = "0x186E51AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 IPEAGHIHNPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6E51AE0", Offset = "0x6E50EE0", VA = "0x186E51AE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E53220", Offset = "0x6E52620", VA = "0x186E53220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float JOHKAAPFFLA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6E51890", Offset = "0x6E50C90", VA = "0x186E51890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E52D90", Offset = "0x6E52190", VA = "0x186E52D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JEDDGFILBFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6E51EF0", Offset = "0x6E512F0", VA = "0x186E51EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6E533C0", Offset = "0x6E527C0", VA = "0x186E533C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion HIHDKPGBDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E51BB0", Offset = "0x6E50FB0", VA = "0x186E51BB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E52FB0", Offset = "0x6E523B0", VA = "0x186E52FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion HEBDFNEHKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E51E20", Offset = "0x6E51220", VA = "0x186E51E20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E532F0", Offset = "0x6E526F0", VA = "0x186E532F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 FAHFHHFOMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6E51C80", Offset = "0x6E51080", VA = "0x186E51C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6E53080", Offset = "0x6E52480", VA = "0x186E53080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion DOPPPLLLHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6E51D50", Offset = "0x6E51150", VA = "0x186E51D50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6E53150", Offset = "0x6E52550", VA = "0x186E53150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 CPDGHJJAFAA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6E51FB0", Offset = "0x6E513B0", VA = "0x186E51FB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6E534A0", Offset = "0x6E528A0", VA = "0x186E534A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BGOLDLKKMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E518F0", Offset = "0x6E50CF0", VA = "0x186E518F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6E52E00", Offset = "0x6E52200", VA = "0x186E52E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 HNJKKMCILJI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6E51250", Offset = "0x6E50650", VA = "0x186E51250")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E529D0", Offset = "0x6E51DD0", VA = "0x186E529D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FFBOOOFJHCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6E516F0", Offset = "0x6E50AF0", VA = "0x186E516F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6E52BF0", Offset = "0x6E51FF0", VA = "0x186E52BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KOKGDFJBDJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6E515C0", Offset = "0x6E509C0", VA = "0x186E515C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion IKAACEJABCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6E514F0", Offset = "0x6E508F0", VA = "0x186E514F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 IIIOMIBOJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6E52220", Offset = "0x6E51620", VA = "0x186E52220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 GCLMJKKFNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6E52150", Offset = "0x6E51550", VA = "0x186E52150")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NDMAAJEOGII
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6E51690", Offset = "0x6E50A90", VA = "0x186E51690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PKFGFIFDCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6E51130", Offset = "0x6E50530", VA = "0x186E51130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DDBKOCGOAMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6E50D50", Offset = "0x6E50150", VA = "0x186E50D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KHJMFPKDNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E50CF0", Offset = "0x6E500F0", VA = "0x186E50CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AJIHOIMLFAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6E50BD0", Offset = "0x6E4FFD0", VA = "0x186E50BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FELKBHADKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E51440", Offset = "0x6E50840", VA = "0x186E51440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MADHFPDLGFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3196E80", Offset = "0x3196280", VA = "0x183196E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ABKBPFMJPBP GMIENDAAHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E50AF0", Offset = "0x6E4FEF0", VA = "0x186E50AF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E52600", Offset = "0x6E51A00", VA = "0x186E52600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GPFPGDKFNGA LMBAJEBBIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6E50A80", Offset = "0x6E4FE80", VA = "0x186E50A80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E52590", Offset = "0x6E51990", VA = "0x186E52590")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ABKBPFMJPBP OCMEHKGHOMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E507E0", Offset = "0x6E4FBE0", VA = "0x186E507E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E522F0", Offset = "0x6E516F0", VA = "0x186E522F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ABKBPFMJPBP GDCCEAOECPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E50850", Offset = "0x6E4FC50", VA = "0x186E50850")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E52360", Offset = "0x6E51760", VA = "0x186E52360")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ABKBPFMJPBP DBOBKOEDDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E509A0", Offset = "0x6E4FDA0", VA = "0x186E509A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E524B0", Offset = "0x6E518B0", VA = "0x186E524B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E50930", Offset = "0x6E4FD30", VA = "0x186E50930")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E52440", Offset = "0x6E51840", VA = "0x186E52440")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ABKBPFMJPBP KHKILFGDFKE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E50A10", Offset = "0x6E4FE10", VA = "0x186E50A10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6E52520", Offset = "0x6E51920", VA = "0x186E52520")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ABKBPFMJPBP LFNLGBEJDAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6E50B60", Offset = "0x6E4FF60", VA = "0x186E50B60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E52670", Offset = "0x6E51A70", VA = "0x186E52670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ABKBPFMJPBP CELEGIEBBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6E508C0", Offset = "0x6E4FCC0", VA = "0x186E508C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6E523D0", Offset = "0x6E517D0", VA = "0x186E523D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		internal void GJNAMALCLAO(EAHCLCDMENH LCKHNIKLMMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F770", Offset = "0x6E4EB70", VA = "0x186E4F770")]
		internal void MDKGJDALKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E504D0", Offset = "0x6E4F8D0", VA = "0x186E504D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody KLHBDGFDIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E50190", Offset = "0x6E4F590", VA = "0x186E50190")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KKLEBPJFJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4ED50", Offset = "0x6E4E150", VA = "0x186E4ED50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F800", Offset = "0x6E4EC00", VA = "0x186E4F800")]
		private EAHCLCDMENH OJIANGLDOHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EDC0", Offset = "0x6E4E1C0", VA = "0x186E4EDC0")]
		private void BFCHCMHGCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F980", Offset = "0x6E4ED80", VA = "0x186E4F980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F910", Offset = "0x6E4ED10", VA = "0x186E4F910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F920", Offset = "0x6E4ED20", VA = "0x186E4F920")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F9E0", Offset = "0x6E4EDE0", VA = "0x186E4F9E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E310", Offset = "0x6E4D710", VA = "0x186E4E310")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FA50", Offset = "0x6E4EE50", VA = "0x186E4FA50")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F330", Offset = "0x6E4E730", VA = "0x186E4F330")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F8B0", Offset = "0x6E4ECB0", VA = "0x186E4F8B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E502F0", Offset = "0x6E4F6F0", VA = "0x186E502F0")]
		public void SetParent(RigidbodyEx KKIAKNLLHIO, bool GPCIIKMAAIK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FD50", Offset = "0x6E4F150", VA = "0x186E4FD50")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F590", Offset = "0x6E4E990", VA = "0x186E4F590")]
		public bool IsRigidbodyAncestor(RigidbodyEx KBNFPNFHPPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F5D0", Offset = "0x6E4E9D0", VA = "0x186E4F5D0")]
		public bool IsRigidbodyDescendant(RigidbodyEx KFLNILANLHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E580", Offset = "0x6E4D980", VA = "0x186E4E580")]
		public void AddInterpolationRestriction(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FAC0", Offset = "0x6E4EEC0", VA = "0x186E4FAC0")]
		public void RemoveInterpolationRestriction(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F150", Offset = "0x6E4E550", VA = "0x186E4F150")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E5F0", Offset = "0x6E4D9F0", VA = "0x186E4E5F0")]
		public void AddKinematic(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FB30", Offset = "0x6E4EF30", VA = "0x186E4FB30")]
		public void RemoveKinematic(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E50270", Offset = "0x6E4F670", VA = "0x186E50270")]
		public void SetKinematic(object GAOLOMEJCOK, bool OLBFAGCJMOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E500A0", Offset = "0x6E4F4A0", VA = "0x186E500A0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 KBIMMDIDBHL, Quaternion MJHKKDHDILL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FFB0", Offset = "0x6E4F3B0", VA = "0x186E4FFB0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LLJDDGPKDOH, Quaternion LHHJFNHIMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F490", Offset = "0x6E4E890", VA = "0x186E4F490")]
		public Vector3 GetConstrainedVelocity(Vector3 CPDGHJJAFAA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F390", Offset = "0x6E4E790", VA = "0x186E4F390")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 HNJKKMCILJI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E490", Offset = "0x6E4D890", VA = "0x186E4E490")]
		public void AddForce(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E380", Offset = "0x6E4D780", VA = "0x186E4E380")]
		public void AddForceAtPosition(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E7C0", Offset = "0x6E4DBC0", VA = "0x186E4E7C0")]
		public void AddTorque(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E660", Offset = "0x6E4DA60", VA = "0x186E4E660")]
		public void AddRelativeTorque(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E505B0", Offset = "0x6E4F9B0", VA = "0x186E505B0")]
		public Vector3 WorldToLocalVelocity(Vector3 DLEGEFCLFKO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F670", Offset = "0x6E4EA70", VA = "0x186E4F670")]
		public Vector3 LocalToWorldVelocity(Vector3 BGOLDLKKMLJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F2D0", Offset = "0x6E4E6D0", VA = "0x186E4F2D0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F270", Offset = "0x6E4E670", VA = "0x186E4F270")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F210", Offset = "0x6E4E610", VA = "0x186E4F210")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F1B0", Offset = "0x6E4E5B0", VA = "0x186E4F1B0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FEB0", Offset = "0x6E4F2B0", VA = "0x186E4FEB0")]
		public void ResetVelocityWorldSpace(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FDB0", Offset = "0x6E4F1B0", VA = "0x186E4FDB0")]
		public void ResetVelocityLocalSpace(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FC80", Offset = "0x6E4F080", VA = "0x186E4FC80")]
		public void ResetLinearVelocityLocalSpace(Vector3 JMBFKAOIALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E503E0", Offset = "0x6E4F7E0", VA = "0x186E503E0")]
		public bool SweepTest(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F610", Offset = "0x6E4EA10", VA = "0x186E4F610")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E50380", Offset = "0x6E4F780", VA = "0x186E50380")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E50550", Offset = "0x6E4F950", VA = "0x186E50550")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E750", Offset = "0x6E4DB50", VA = "0x186E4E750")]
		public void AddShouldHaveUnityRigidbodyToken(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FBA0", Offset = "0x6E4EFA0", VA = "0x186E4FBA0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EB40", Offset = "0x6E4DF40", VA = "0x186E4EB40")]
		public void ApplyForceVelocityChange(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EA50", Offset = "0x6E4DE50", VA = "0x186E4EA50")]
		public void ApplyAngularVelocityChange(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EC50", Offset = "0x6E4E050", VA = "0x186E4EC50")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E990", Offset = "0x6E4DD90", VA = "0x186E4E990")]
		public bool AllowedScaleChange(float JLFGAMMLIDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E4E8B0", Offset = "0x6E4DCB0", VA = "0x186E4E8B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MIBNLDFCFFK, object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FC10", Offset = "0x6E4F010", VA = "0x186E4FC10")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E50740", Offset = "0x6E4FB40", VA = "0x186E50740")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class LBFDFMIHBGI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x59B8A00", Offset = "0x59B7E00", VA = "0x1859B8A00")]
	public static EAHCLCDMENH JNJIAANLANL(this RigidbodyEx LJACJOOEGHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ABKBPFMJPBP(RigidbodyEx EPEOKOONLCK);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BBBIHACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LOHJNOKMBFM
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OKDLMPEGAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Rigidbody GICHLCJAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public PhotonView JDECFKODFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OverridableVector3 NCNEIKFOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 FCMNAMHJMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BBBIHACBHFO MCKIFIEILPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool ALOCBCBOFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool IKIJAJHMBKH;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GPFPGDKFNGA(RigidbodyEx EPEOKOONLCK, bool GPCIIKMAAIK = false);
[Cpp2IlInjected.Token(Token = "0x200000D")]
[EFDJEPLIMOC(typeof(IJADIHPLMME), new string[] { "Ignore", "Mock" })]
public class OGINFKHIMBL : IJADIHPLMME
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HCNCAKBKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA2ED20", Offset = "0xA2E120", VA = "0x180A2ED20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void HICEKIJCIBK(string KDPCEEMNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
	public void OIIPKPCLNJI(RigidbodyEx LJACJOOEGHH, Action FJBAKNFCPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "7")]
	public LDKPPGCLIKN IHDKMGKLMBI(int EBIFMODHOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void OFJGHMGNLEK(Vector3 ONBKJEAHOFE, float EAIKNGELPEN, Color FJGGIOBFKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OGINFKHIMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[EFDJEPLIMOC(typeof(BCPFDHDHBHN), new string[] { })]
public class OLFCLNHDAGG : BCPFDHDHBHN, AKFIPDJCCOH
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GFGEKEKINCH CMKMKKAFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IJADIHPLMME LEGFAAONKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MCIKANEBNMG IKFNPJJBCEE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IJADIHPLMME JABBLKIHJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MCIKANEBNMG DKFECOPNJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B2B0", Offset = "0x6E4A6B0", VA = "0x186E4B2B0", Slot = "10")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B340", Offset = "0x6E4A740", VA = "0x186E4B340", Slot = "6")]
	public KDLENLDMBAK JLKLOPKEDML(RigidbodyEx LJACJOOEGHH)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B1B0", Offset = "0x6E4A5B0", VA = "0x186E4B1B0")]
	private static KDLENLDMBAK HLMKCDNJDAF(RigidbodyEx LJACJOOEGHH)
	{
		return default(KDLENLDMBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AFB0", Offset = "0x6E4A3B0", VA = "0x186E4AFB0", Slot = "7")]
	public EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B0C0", Offset = "0x6E4A4C0", VA = "0x186E4B0C0", Slot = "8")]
	public void CGJLLMBLPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B640", Offset = "0x6E4AA40", VA = "0x186E4B640", Slot = "9")]
	public void LIIKFGGKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OLFCLNHDAGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DACIFHMODME
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x59A9310", Offset = "0x59A8710", VA = "0x1859A9310")]
	public static void JMJAIKGNBCN(this Rigidbody KLHBDGFDIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x59A9460", Offset = "0x59A8860", VA = "0x1859A9460")]
	public static void JMJAIKGNBCN(this Rigidbody KLHBDGFDIBK, Vector3 PMHNBDLADFI, Quaternion IKAACEJABCD, Vector3 LGMCNLJGLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21BA2A0", Offset = "0x21B96A0", VA = "0x1821BA2A0")]
	public static void OALLEHBNIIB(Vector3 CPDGHJJAFAA, Vector3 LHLKLIEJLPJ, out Vector3 GOLHOAEEGEE, out Vector3 CHDEGHJIGKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum JLBDMCGEPFC
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KMDNIJEJNBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ABKBPFMJPBP IJABNKFJANE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBNODPMJKAO(EAHCLCDMENH ILDFJHMNOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPNNLJAEKJC(EAHCLCDMENH ILDFJHMNOPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IFAGKIJIHAD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DALFAPDLNEA(Rigidbody GICHLCJAAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface IJADIHPLMME
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool HCNCAKBKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HICEKIJCIBK(string KDPCEEMNMDK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIIPKPCLNJI(RigidbodyEx LJACJOOEGHH, Action FJBAKNFCPGP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDKPPGCLIKN IHDKMGKLMBI(int EBIFMODHOLB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFJGHMGNLEK(Vector3 ONBKJEAHOFE, float EAIKNGELPEN, Color FJGGIOBFKGO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface BCPFDHDHBHN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IJADIHPLMME JABBLKIHJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MCIKANEBNMG DKFECOPNJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KDLENLDMBAK JLKLOPKEDML(RigidbodyEx LJACJOOEGHH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGJLLMBLPLK();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIIKFGGKMIG();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MLAKACHFLPP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx KKEDJEEJDDH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GIHANPIMODL
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMANKEHBFOH(EAHCLCDMENH ILDFJHMNOPJ, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FJIAHIOLIEL(object GAOLOMEJCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class LFKDIJNNPHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x59B98E0", Offset = "0x59B8CE0", VA = "0x1859B98E0")]
	public LFKDIJNNPHN(AFAOFDBMCDE OBNCFODAOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x59B9880", Offset = "0x59B8C80", VA = "0x1859B9880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AFAOFDBMCDE : EAHCLCDMENH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly BCPFDHDHBHN MLODHIKJENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NGDGBGPMNDG FEJKNPAOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NBBLFILMLJG HDMALACHNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal KMDNIJEJNBK MCJOPJDGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal NLMOECEILLG CPDGHJJAFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal GIHANPIMODL AKJHENKFKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal GPOBHMGKMJL AJGBIKLFNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal IFAGKIJIHAD JAJBJHKGOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal LAPMGAFDIDC ADNLEMFNLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal BLLOODMDKJF DGOLMCHDFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal BLBLCFEJOBG PJCIPDPICGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal DIFPEGGHMMK CAOIJOJLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal KADBGOOJEOK FCCLLNHHFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal LBLOJOEPDDJ FPJANLNGMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal LBENAEPJLBH GICHLCJAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal NLLPDNBDLAA IICBGDOOIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IDisposable KLEFDPCBCOE;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public RigidbodyEx PDKMCAJHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA49860", Offset = "0xA48C60", VA = "0x180A49860", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA9B0", Offset = "0x9E9DB0", VA = "0x1809EA9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GameObject EHDLGABJMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EA9A0", Offset = "0x9E9DA0", VA = "0x1809EA9A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA900", Offset = "0x9E9D00", VA = "0x1809EA900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Transform GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x59A14E0", Offset = "0x59A08E0", VA = "0x1859A14E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x59A31D0", Offset = "0x59A25D0", VA = "0x1859A31D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x59A1190", Offset = "0x59A0590", VA = "0x1859A1190", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x59A0DE0", Offset = "0x59A01E0", VA = "0x1859A0DE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x59A0EC0", Offset = "0x59A02C0", VA = "0x1859A0EC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x59A4240", Offset = "0x59A3640", VA = "0x1859A4240", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x59A4290", Offset = "0x59A3690", VA = "0x1859A4290", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x59A4DC0", Offset = "0x59A41C0", VA = "0x1859A4DC0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x59A1F20", Offset = "0x59A1320", VA = "0x1859A1F20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x59A4A60", Offset = "0x59A3E60", VA = "0x1859A4A60", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x59A2190", Offset = "0x59A1590", VA = "0x1859A2190", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x59A3780", Offset = "0x59A2B80", VA = "0x1859A3780", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x59A4120", Offset = "0x59A3520", VA = "0x1859A4120", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x59A2E70", Offset = "0x59A2270", VA = "0x1859A2E70", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x59A41E0", Offset = "0x59A35E0", VA = "0x1859A41E0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x59A2FE0", Offset = "0x59A23E0", VA = "0x1859A2FE0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x599EE30", Offset = "0x599E230", VA = "0x18599EE30", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x59A2F10", Offset = "0x59A2310", VA = "0x1859A2F10", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x59A1230", Offset = "0x59A0630", VA = "0x1859A1230", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x599F6A0", Offset = "0x599EAA0", VA = "0x18599F6A0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x59A33F0", Offset = "0x59A27F0", VA = "0x1859A33F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x59A1980", Offset = "0x59A0D80", VA = "0x1859A1980", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x599F7C0", Offset = "0x599EBC0", VA = "0x18599F7C0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool DDBKOCGOAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x599F5E0", Offset = "0x599E9E0", VA = "0x18599F5E0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool KHJMFPKDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x59A2AB0", Offset = "0x59A1EB0", VA = "0x1859A2AB0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool AJIHOIMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x59A4BD0", Offset = "0x59A3FD0", VA = "0x1859A4BD0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x59A40D0", Offset = "0x59A34D0", VA = "0x1859A40D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x59A4890", Offset = "0x59A3C90", VA = "0x1859A4890", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x59A3B50", Offset = "0x59A2F50", VA = "0x1859A3B50", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x59A22F0", Offset = "0x59A16F0", VA = "0x1859A22F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x59A2920", Offset = "0x59A1D20", VA = "0x1859A2920", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x59A42F0", Offset = "0x59A36F0", VA = "0x1859A42F0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x59A3B00", Offset = "0x59A2F00", VA = "0x1859A3B00", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x59A3C20", Offset = "0x59A3020", VA = "0x1859A3C20", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x59A4570", Offset = "0x59A3970", VA = "0x1859A4570", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x599F890", Offset = "0x599EC90", VA = "0x18599F890", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x59A4710", Offset = "0x59A3B10", VA = "0x1859A4710", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x599F960", Offset = "0x599ED60", VA = "0x18599F960", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x59A1FF0", Offset = "0x59A13F0", VA = "0x1859A1FF0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x59A3C70", Offset = "0x59A3070", VA = "0x1859A3C70", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x59A32E0", Offset = "0x59A26E0", VA = "0x1859A32E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x59A45D0", Offset = "0x59A39D0", VA = "0x1859A45D0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x59A2A50", Offset = "0x59A1E50", VA = "0x1859A2A50", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x59A1730", Offset = "0x59A0B30", VA = "0x1859A1730", Slot = "48")]
		get
		{
			return default(PPADPBDPHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x59A0730", Offset = "0x599FB30", VA = "0x1859A0730", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x59A3F40", Offset = "0x59A3340", VA = "0x1859A3F40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Transform FCDBEGFHINM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x59A1C30", Offset = "0x59A1030", VA = "0x1859A1C30", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 EAJGLLBNNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x59A3220", Offset = "0x59A2620", VA = "0x1859A3220", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x59A47E0", Offset = "0x59A3BE0", VA = "0x1859A47E0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float DFLNGLEFOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x59A1FD0", Offset = "0x59A13D0", VA = "0x1859A1FD0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x599F4B0", Offset = "0x599E8B0", VA = "0x18599F4B0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public float GECDAEFNECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x59A0EA0", Offset = "0x59A02A0", VA = "0x1859A0EA0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x59A1870", Offset = "0x59A0C70", VA = "0x1859A1870", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Quaternion FINBMEHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x59A4CC0", Offset = "0x59A40C0", VA = "0x1859A4CC0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x59A1C40", Offset = "0x59A1040", VA = "0x1859A1C40", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector3 MOMDFBGEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x59A22A0", Offset = "0x59A16A0", VA = "0x1859A22A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x59A4D70", Offset = "0x59A4170", VA = "0x1859A4D70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Quaternion LBNLHCEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x59A1B30", Offset = "0x59A0F30", VA = "0x1859A1B30", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x59A4530", Offset = "0x59A3930", VA = "0x1859A4530", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x599F770", Offset = "0x599EB70", VA = "0x18599F770", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x59A28C0", Offset = "0x59A1CC0", VA = "0x1859A28C0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x59A2EC0", Offset = "0x59A22C0", VA = "0x1859A2EC0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x59A3E00", Offset = "0x59A3200", VA = "0x1859A3E00", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x59A26A0", Offset = "0x59A1AA0", VA = "0x1859A26A0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x59A2D20", Offset = "0x59A2120", VA = "0x1859A2D20", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool DIGMNPKCMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x59A1DD0", Offset = "0x59A11D0", VA = "0x1859A1DD0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool PKFGFIFDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x599F320", Offset = "0x599E720", VA = "0x18599F320", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool PMIIMNGELNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x59A08E0", Offset = "0x599FCE0", VA = "0x1859A08E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool IODHHHOKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x599F9B0", Offset = "0x599EDB0", VA = "0x18599F9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event ABKBPFMJPBP OCMEHKGHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x59A37D0", Offset = "0x59A2BD0", VA = "0x1859A37D0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59A4B70", Offset = "0x59A3F70", VA = "0x1859A4B70", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event ABKBPFMJPBP GDCCEAOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x59A3AA0", Offset = "0x59A2EA0", VA = "0x1859A3AA0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x59A29F0", Offset = "0x59A1DF0", VA = "0x1859A29F0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event GPFPGDKFNGA FDBHKJAPMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x59A0AC0", Offset = "0x599FEC0", VA = "0x1859A0AC0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x59A44D0", Offset = "0x59A38D0", VA = "0x1859A44D0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event ABKBPFMJPBP IJABNKFJANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x59A1570", Offset = "0x59A0970", VA = "0x1859A1570", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x59A3340", Offset = "0x59A2740", VA = "0x1859A3340", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event ABKBPFMJPBP DBOBKOEDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x59A3170", Offset = "0x59A2570", VA = "0x1859A3170", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x59A16D0", Offset = "0x59A0AD0", VA = "0x1859A16D0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event ABKBPFMJPBP OCPDCNELHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x59A3110", Offset = "0x59A2510", VA = "0x1859A3110", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x59A4AB0", Offset = "0x59A3EB0", VA = "0x1859A4AB0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x59A1BD0", Offset = "0x59A0FD0", VA = "0x1859A1BD0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x59A1B70", Offset = "0x59A0F70", VA = "0x1859A1B70", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event ABKBPFMJPBP KBIHLCENPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x59A0E40", Offset = "0x59A0240", VA = "0x1859A0E40", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x599FCF0", Offset = "0x599F0F0", VA = "0x18599FCF0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event ABKBPFMJPBP CELEGIEBBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x59A27D0", Offset = "0x59A1BD0", VA = "0x1859A27D0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x59A17D0", Offset = "0x59A0BD0", VA = "0x1859A17D0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x59A4F90", Offset = "0x59A4390", VA = "0x1859A4F90")]
	public AFAOFDBMCDE(GameObject GACFHLOJJGF, RigidbodyEx CPBAKEFGMHN, BCPFDHDHBHN MLODHIKJENP, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x599FF50", Offset = "0x599F350", VA = "0x18599FF50", Slot = "135")]
	protected virtual void COKNCMNBNHP(BCPFDHDHBHN MLODHIKJENP, OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x59A09F0", Offset = "0x599FDF0", VA = "0x1859A09F0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x59A4E10", Offset = "0x59A4210", VA = "0x1859A4E10", Slot = "71")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x599F140", Offset = "0x599E540", VA = "0x18599F140", Slot = "72")]
	public void AILPEEFKMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x599F300", Offset = "0x599E700", VA = "0x18599F300", Slot = "73")]
	public void AKHHEEOMHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x599ED80", Offset = "0x599E180", VA = "0x18599ED80")]
	private void ABNCHIAHMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x599FEE0", Offset = "0x599F2E0", VA = "0x18599FEE0", Slot = "81")]
	public void CIGBDIGMBAB(EAHCLCDMENH KKIAKNLLHIO, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x59A4180", Offset = "0x59A3580", VA = "0x1859A4180", Slot = "84")]
	public void NACBDIDMAEK(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x59A4B10", Offset = "0x59A3F10", VA = "0x1859A4B10", Slot = "85")]
	public void PFIEFHMFEBD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x59A07F0", Offset = "0x599FBF0", VA = "0x1859A07F0", Slot = "86")]
	public Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x59A3CC0", Offset = "0x59A30C0", VA = "0x1859A3CC0", Slot = "87")]
	public Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x599F140", Offset = "0x599E540", VA = "0x18599F140", Slot = "88")]
	public void AMOGEPNPKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x599EF00", Offset = "0x599E300", VA = "0x18599EF00", Slot = "89")]
	public void ADOFMEEMJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x59A4080", Offset = "0x59A3480", VA = "0x1859A4080", Slot = "90")]
	public void MIEKIDJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x59A3F90", Offset = "0x59A3390", VA = "0x1859A3F90", Slot = "91")]
	public void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x59A1CE0", Offset = "0x59A10E0", VA = "0x1859A1CE0", Slot = "92")]
	public void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x599FD50", Offset = "0x599F150", VA = "0x18599FD50", Slot = "93")]
	public void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x59A43C0", Offset = "0x59A37C0", VA = "0x1859A43C0", Slot = "94")]
	public void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x59A4620", Offset = "0x59A3A20", VA = "0x1859A4620", Slot = "95")]
	public void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x59A4960", Offset = "0x59A3D60", VA = "0x1859A4960", Slot = "96")]
	[Obsolete]
	public void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x59A3690", Offset = "0x59A2A90", VA = "0x1859A3690", Slot = "97")]
	public Vector3 KGFOHHPIBKL(Vector3 KKIAKNLLHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x59A2D80", Offset = "0x59A2180", VA = "0x1859A2D80", Slot = "98")]
	public Vector3 JCAJFPBNAOB(Vector3 KKIAKNLLHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x59A11E0", Offset = "0x59A05E0", VA = "0x1859A11E0", Slot = "99")]
	public void EPOHAHFFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x599F520", Offset = "0x599E920", VA = "0x18599F520", Slot = "100")]
	public void BHCDCOACEBK(EAHCLCDMENH MIBNLDFCFFK, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x599FE80", Offset = "0x599F280", VA = "0x18599FE80", Slot = "101")]
	public void CHLPIOHBPHF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x59A23C0", Offset = "0x59A17C0", VA = "0x1859A23C0", Slot = "41")]
	public void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x59A2650", Offset = "0x59A1A50", VA = "0x1859A2650", Slot = "104")]
	public void IANILGHLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x599F0F0", Offset = "0x599E4F0", VA = "0x18599F0F0", Slot = "105")]
	public void AFKHDNAIDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x59A15D0", Offset = "0x59A09D0", VA = "0x1859A15D0", Slot = "106")]
	public void FIJLCNFMINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x59A1620", Offset = "0x59A0A20", VA = "0x1859A1620", Slot = "109")]
	public bool FJPDMKBDPKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x59A2870", Offset = "0x59A1C70", VA = "0x1859A2870", Slot = "74")]
	public void IKBHHOGFNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x59A3DB0", Offset = "0x59A31B0", VA = "0x1859A3DB0", Slot = "110")]
	public void MANGGEGDHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x59A33A0", Offset = "0x59A27A0", VA = "0x1859A33A0", Slot = "115")]
	public IDisposable JOJJOHNBPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x59A2CC0", Offset = "0x59A20C0", VA = "0x1859A2CC0", Slot = "116")]
	public void IPEGEGKFAIF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x599FE20", Offset = "0x599F220", VA = "0x18599FE20", Slot = "117")]
	public void CGABPKKHALD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x599F630", Offset = "0x599EA30", VA = "0x18599F630", Slot = "118")]
	public void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x59A3830", Offset = "0x59A2C30", VA = "0x1859A3830", Slot = "121")]
	public void LDECEFAOEKE(Vector3 KBIMMDIDBHL, Quaternion MJHKKDHDILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x59A24A0", Offset = "0x59A18A0", VA = "0x1859A24A0", Slot = "122")]
	public void HOLMJOIABJP(Vector3 LLJDDGPKDOH, Quaternion LHHJFNHIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x59A30B0", Offset = "0x59A24B0", VA = "0x1859A30B0", Slot = "123")]
	public bool JGFGLKEIOCO(float JLFGAMMLIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x59A2050", Offset = "0x59A1450", VA = "0x1859A2050", Slot = "124")]
	public void HDBJNMJIFCG(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x59A0990", Offset = "0x599FD90", VA = "0x1859A0990", Slot = "125")]
	public void DNCPBGHIBNM(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x59A1670", Offset = "0x59A0A70", VA = "0x1859A1670", Slot = "126")]
	public void FOEDBBCKFAI(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x59A1F70", Offset = "0x59A1370", VA = "0x1859A1F70", Slot = "127")]
	public void GNGBJDCLCGN(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x59A26F0", Offset = "0x59A1AF0", VA = "0x1859A26F0", Slot = "128")]
	public void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x599EFE0", Offset = "0x599E3E0", VA = "0x18599EFE0", Slot = "129")]
	public void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x59A20B0", Offset = "0x59A14B0", VA = "0x1859A20B0", Slot = "130")]
	public void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x59A1A50", Offset = "0x59A0E50", VA = "0x1859A1A50", Slot = "131")]
	public void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x59A34C0", Offset = "0x59A28C0", VA = "0x1859A34C0", Slot = "132")]
	public bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x59A1780", Offset = "0x59A0B80", VA = "0x1859A1780", Slot = "133")]
	public void GACDEFCAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x59A4F50", Offset = "0x59A4350", VA = "0x1859A4F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x59A0B20", Offset = "0x599FF20", VA = "0x1859A0B20")]
	private void EBAPEKFFEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x59A2B10", Offset = "0x59A1F10", VA = "0x1859A2B10")]
	private void INHHBNCCFOG(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x59A0BF0", Offset = "0x599FFF0", VA = "0x1859A0BF0")]
	private void ECEBOEDDHBC(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x59A21F0", Offset = "0x59A15F0", VA = "0x1859A21F0")]
	private void HHGEOHOPEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x59A0230", Offset = "0x599F630", VA = "0x1859A0230")]
	private void DCKDHBOBCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x59A1300", Offset = "0x59A0700", VA = "0x1859A1300")]
	private void FDPDIHDJHEB(EAHCLCDMENH NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x59A3E60", Offset = "0x59A3260", VA = "0x1859A3E60")]
	private void MBNODPMJKAO(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x59A35B0", Offset = "0x59A29B0", VA = "0x1859A35B0")]
	private void JPNNLJAEKJC(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x599F190", Offset = "0x599E590", VA = "0x18599F190")]
	private void AJJKCDAGJNI(RigidbodyEx ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x59A0F10", Offset = "0x59A0310", VA = "0x1859A0F10", Slot = "140")]
	protected virtual void EKJIADIMKGC(RigidbodyEx LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x599F9F0", Offset = "0x599EDF0", VA = "0x18599F9F0")]
	protected void CBIFPABOGJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x59A0330", Offset = "0x599F730", VA = "0x1859A0330")]
	protected void DCKPKEPEGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x599EF50", Offset = "0x599E350", VA = "0x18599EF50", Slot = "141")]
	protected virtual IDisposable AEKIOPBAAIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class MNPAIDHLCIL
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x59C3500", Offset = "0x59C2900", VA = "0x1859C3500")]
	public static EAHCLCDMENH OAJMMJCHIMN(this EAHCLCDMENH LJACJOOEGHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x59C3480", Offset = "0x59C2880", VA = "0x1859C3480")]
	public static bool JCMEEODBMIN(this EAHCLCDMENH LJACJOOEGHH, EAHCLCDMENH KBNFPNFHPPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x59C3390", Offset = "0x59C2790", VA = "0x1859C3390")]
	public static bool ICDJKCDDEIP(this EAHCLCDMENH LJACJOOEGHH, EAHCLCDMENH KFLNILANLHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x59C35C0", Offset = "0x59C29C0", VA = "0x1859C35C0")]
	public static RigidbodyEx PDKMCAJHMEF(this EAHCLCDMENH JNJIAANLANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x59C3410", Offset = "0x59C2810", VA = "0x1859C3410")]
	public static AFAOFDBMCDE INEDAFNPPCJ(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GPOBHMGKMJL
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ABKBPFMJPBP OPIECLHNAAO;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AFKHDNAIDMM();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IANILGHLEDK();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FIJLCNFMINC();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DALFAPDLNEA(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GACDEFCAIFI();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EAHCLCDMENH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	RigidbodyEx PDKMCAJHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GameObject EHDLGABJMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Transform GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool KHJMFPKDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool AJIHOIMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform FCDBEGFHINM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 EAJGLLBNNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float DFLNGLEFOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float GECDAEFNECM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Quaternion FINBMEHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 MOMDFBGEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Quaternion LBNLHCEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool PKFGFIFDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ABKBPFMJPBP OCMEHKGHOMG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ABKBPFMJPBP GDCCEAOECPH;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event GPFPGDKFNGA FDBHKJAPMML;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event ABKBPFMJPBP IJABNKFJANE;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event ABKBPFMJPBP DBOBKOEDDBB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ABKBPFMJPBP OCPDCNELHLB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event ABKBPFMJPBP KBIHLCENPEG;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event ABKBPFMJPBP CELEGIEBBMI;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void AILPEEFKMDO();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void AKHHEEOMHLP();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void IKBHHOGFNFL();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void CIGBDIGMBAB(EAHCLCDMENH KKIAKNLLHIO, bool GPCIIKMAAIK = false);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void NACBDIDMAEK(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void PFIEFHMFEBD(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void AMOGEPNPKFB();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void ADOFMEEMJHI();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void MIEKIDJHBLN();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 KGFOHHPIBKL(Vector3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 JCAJFPBNAOB(Vector3 KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void EPOHAHFFPCN();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void BHCDCOACEBK(EAHCLCDMENH MIBNLDFCFFK, object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void CHLPIOHBPHF(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void IANILGHLEDK();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void AFKHDNAIDMM();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void FIJLCNFMINC();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool FJPDMKBDPKA();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void MANGGEGDHKL();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable JOJJOHNBPBJ();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IPEGEGKFAIF(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CGABPKKHALD(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void LDECEFAOEKE(Vector3 KBIMMDIDBHL, Quaternion MJHKKDHDILL);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HOLMJOIABJP(Vector3 LLJDDGPKDOH, Quaternion LHHJFNHIMFF);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool JGFGLKEIOCO(float JLFGAMMLIDN);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void HDBJNMJIFCG(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void DNCPBGHIBNM(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FOEDBBCKFAI(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void GNGBJDCLCGN(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void GACDEFCAIFI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KADBGOOJEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CKJAHABHLOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EJOOJLNKBOL();

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IOHDKLJLHFM();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NBBLFILMLJG
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGFDFEJJGCB(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMLEAJNOELO(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHEHOMOIPOM(EAHCLCDMENH LJACJOOEGHH);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIBFOBAFNNP(EAHCLCDMENH LJACJOOEGHH);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFPENNDCBCP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BLBLCFEJOBG : IDisposable, CAJOJINPBPL
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPANCNBNGPF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NGDGBGPMNDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event ABKBPFMJPBP OCMEHKGHOMG;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event ABKBPFMJPBP GDCCEAOECPH;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event GPFPGDKFNGA FDBHKJAPMML;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action IOKKCNKMBCK;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action CNKIMCMFKFN;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<EAHCLCDMENH> IOKJLMPMCIJ;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<EAHCLCDMENH> HDNMOMGDEGA;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action JJDNGEBPMII;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<EAHCLCDMENH> DBCLHMMPKJG;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CIGBDIGMBAB(EAHCLCDMENH GHLIBENNEBB, bool GPCIIKMAAIK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[JOCOBGMDOKK(CAGOEBHGGNL.Application)]
public interface MCIKANEBNMG
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGDGBGPMNDG DNMHDDBILFO(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NLMOECEILLG HAHHPANPKEF(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIHANPIMODL IFJFOOPBCIG(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IFAGKIJIHAD DGMODLBACCJ(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BLLOODMDKJF COJJGOJLGFB(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLBLCFEJOBG HOCKFGNGOCH(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DIFPEGGHMMK JJPGFMHCBPI(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KADBGOOJEOK DNLPLFMNDAO(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NLLPDNBDLAA MOCJAKNHGGG(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LAPMGAFDIDC NPHPHMDHGBA(EAHCLCDMENH LCKHNIKLMMC);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LBENAEPJLBH LBGFONNAIPO(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KMDNIJEJNBK AEPBLKBIPLF(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NBBLFILMLJG KBLELAONPDA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GPOBHMGKMJL LGMJPCAEIDD(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	LBLOJOEPDDJ JOIFNHKACNI(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA, BCPFDHDHBHN MLODHIKJENP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LBLOJOEPDDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool GFICPLAOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DALFAPDLNEA(Rigidbody GICHLCJAAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BJHOFABHIPO
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHGCEOOAANL(Vector3 HIGNDJMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOJCMIAJBGA(Vector3 HNJKKMCILJI);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIPDOOIGDOL(Vector3 HIGNDJMGLCM);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKDOJEPHPMJ(Vector3 HNJKKMCILJI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DIFPEGGHMMK
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event ABKBPFMJPBP KBIHLCENPEG;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGBEIPBBBMP();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPEGEGKFAIF(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGABPKKHALD(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable JOJJOHNBPBJ();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFEDNFBGKEI(Rigidbody HCHEOFCJLMB);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DALFAPDLNEA(Rigidbody GICHLCJAAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NLLPDNBDLAA
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGFGECMKBOI(bool NDMAAJEOGII);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POLOMBPGGEK(bool NDMAAJEOGII);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NLMOECEILLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NJGMCFMDMDK(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MIEKIDJHBLN();

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ADOFMEEMJHI();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EPOHAHFFPCN();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AMOGEPNPKFB();

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KGFOHHPIBKL(Vector3 CPDGHJJAFAA);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OJHNDODACGE(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LBENAEPJLBH
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool NDDLNIJEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOEDBBCKFAI(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNGBJDCLCGN(object GAOLOMEJCOK);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PODMBMBFBEK();

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMJGGFDFKKA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LAPMGAFDIDC
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFEDNFBGKEI(Rigidbody GICHLCJAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DALFAPDLNEA(Rigidbody GICHLCJAAHE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BLLOODMDKJF
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event ABKBPFMJPBP OCPDCNELHLB;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPANCNBNGPF();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJPDMKBDPKA();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OANFHLODHBD();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKBHHOGFNFL();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOKNGPICNHO();

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MANGGEGDHKL();

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IFCKMHMOBIO(bool KLOFHCIIDLL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[EFDJEPLIMOC(typeof(FKMCIKMFIDA), new string[] { })]
public sealed class OKNBLJEGIOD : AKFIPDJCCOH, FKMCIKMFIDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ONGFANECMJO]
	private HNIPNFEMKKN LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ABF0", Offset = "0x6E49FF0", VA = "0x186E4ABF0", Slot = "4")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ABC0", Offset = "0x6E49FC0", VA = "0x186E4ABC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AA50", Offset = "0x6E49E50", VA = "0x186E4AA50", Slot = "6")]
	public void DHEKLBGCINI(KDLENLDMBAK LCODCOPGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AC40", Offset = "0x6E4A040", VA = "0x186E4AC40", Slot = "7")]
	public void JPCDMGCOEAP(KDLENLDMBAK LCODCOPGHJA, bool KGPEAFEAABL, bool APGLEAFLIOH, bool JDMEJOLPODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A910", Offset = "0x6E49D10", VA = "0x186E4A910")]
	private bool BNIHBPPFFED(KDLENLDMBAK LCODCOPGHJA, out MMCIBGLLBBL LCKHNIKLMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AE40", Offset = "0x6E4A240", VA = "0x186E4AE40")]
	private bool KMPEGOLHJOC(KDLENLDMBAK LCODCOPGHJA, out LJJONFJOIJH DBNIGDCKBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public OKNBLJEGIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LJJONFJOIJH : KNLFGDKJAII, GPOBHMGKMJL
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	[Obsolete]
	public Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x59BE410", Offset = "0x59BD810", VA = "0x1859BE410", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x59BEA70", Offset = "0x59BDE70", VA = "0x1859BEA70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 GPIHHAJIOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x59BEEB0", Offset = "0x59BE2B0", VA = "0x1859BEEB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 JCAJAPBFPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x59BED70", Offset = "0x59BE170", VA = "0x1859BED70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[Obsolete]
	public Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x59BF1D0", Offset = "0x59BE5D0", VA = "0x1859BF1D0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	[Obsolete]
	public float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x59BEFF0", Offset = "0x59BE3F0", VA = "0x1859BEFF0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float MEPKKNIIAII
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x59BC260", Offset = "0x59BB660", VA = "0x1859BC260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x59BF0E0", Offset = "0x59BE4E0", VA = "0x1859BF0E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x59BEC60", Offset = "0x59BE060", VA = "0x1859BEC60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x59BC360", Offset = "0x59BB760", VA = "0x1859BC360", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x59BF4B0", Offset = "0x59BE8B0", VA = "0x1859BF4B0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event ABKBPFMJPBP OPIECLHNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x59BEBC0", Offset = "0x59BDFC0", VA = "0x1859BEBC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x59BF410", Offset = "0x59BE810", VA = "0x1859BF410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x59BF4E0", Offset = "0x59BE8E0", VA = "0x1859BF4E0")]
	public LJJONFJOIJH(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x59BF350", Offset = "0x59BE750", VA = "0x1859BF350")]
	public float3 OHJONJNDLKE()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x59BE550", Offset = "0x59BD950", VA = "0x1859BE550", Slot = "14")]
	public void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x59BE7E0", Offset = "0x59BDBE0", VA = "0x1859BE7E0", Slot = "16")]
	public void IANILGHLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x59BBC00", Offset = "0x59BB000", VA = "0x1859BBC00", Slot = "15")]
	public void AFKHDNAIDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x59BE2C0", Offset = "0x59BD6C0", VA = "0x1859BE2C0", Slot = "18")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x59BC390", Offset = "0x59BB790", VA = "0x1859BC390", Slot = "19")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x59BDCB0", Offset = "0x59BD0B0", VA = "0x1859BDCB0", Slot = "17")]
	public void FIJLCNFMINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x59BDDA0", Offset = "0x59BD1A0", VA = "0x1859BDDA0", Slot = "20")]
	public void GACDEFCAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x59B3A10", Offset = "0x59B2E10", VA = "0x1859B3A10")]
	public void LFPHDJFFNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x59BBAB0", Offset = "0x59BAEB0", VA = "0x1859BBAB0")]
	private void AFDKBPGBFOP(Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x59BD900", Offset = "0x59BCD00", VA = "0x1859BD900")]
	[Obsolete]
	private Vector3 ELAMACFNEFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x59BEC60", Offset = "0x59BE060", VA = "0x1859BEC60")]
	private void JENCFFBEKON(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x59BC010", Offset = "0x59BB410", VA = "0x1859BC010")]
	private Vector3 ALNJEBKKIKC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x59BDA70", Offset = "0x59BCE70", VA = "0x1859BDA70")]
	private Quaternion FHGEAIHNDOJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x59BC6E0", Offset = "0x59BBAE0", VA = "0x1859BC6E0")]
	internal (float, Vector3) DHEKLBGCINI(Rigidbody AGJLJDEIJBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class ACJADNMNMBM
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x599ECF0", Offset = "0x599E0F0", VA = "0x18599ECF0")]
	public static LJJONFJOIJH JKFEOOIKLFG(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KJECABADAHC : KNLFGDKJAII, NLMOECEILLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x59B7CB0", Offset = "0x59B70B0", VA = "0x1859B7CB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x59B5180", Offset = "0x59B4580", VA = "0x1859B5180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x59B67F0", Offset = "0x59B5BF0", VA = "0x1859B67F0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x59B7020", Offset = "0x59B6420", VA = "0x1859B7020", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x59B4580", Offset = "0x59B3980", VA = "0x1859B4580", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x59B6610", Offset = "0x59B5A10", VA = "0x1859B6610", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x59B5B60", Offset = "0x59B4F60", VA = "0x1859B5B60", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x59B42B0", Offset = "0x59B36B0", VA = "0x1859B42B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x59B50A0", Offset = "0x59B44A0", VA = "0x1859B50A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x59B45E0", Offset = "0x59B39E0", VA = "0x1859B45E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x59B5B30", Offset = "0x59B4F30", VA = "0x1859B5B30", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x59B5070", Offset = "0x59B4470", VA = "0x1859B5070", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x59B5A40", Offset = "0x59B4E40", VA = "0x1859B5A40", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x59B7120", Offset = "0x59B6520", VA = "0x1859B7120", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x59B6F30", Offset = "0x59B6330", VA = "0x1859B6F30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private KADBGOOJEOK GBELGBHNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x214ECF0", Offset = "0x214E0F0", VA = "0x18214ECF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool DIGMNPKCMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x59B5160", Offset = "0x59B4560", VA = "0x1859B5160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public KJECABADAHC(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x59B7130", Offset = "0x59B6530", VA = "0x1859B7130", Slot = "20")]
	public void NJGMCFMDMDK(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x59B7650", Offset = "0x59B6A50", VA = "0x1859B7650", Slot = "30")]
	public void OJHNDODACGE(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x59B4320", Offset = "0x59B3720", VA = "0x1859B4320", Slot = "19")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x59B4A50", Offset = "0x59B3E50", VA = "0x1859B4A50", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x59B5280", Offset = "0x59B4680", VA = "0x1859B5280", Slot = "28")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x59B4870", Offset = "0x59B3C70", VA = "0x1859B4870", Slot = "35")]
	public Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x59B6AF0", Offset = "0x59B5EF0", VA = "0x1859B6AF0", Slot = "34")]
	public Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x59B4320", Offset = "0x59B3720", VA = "0x1859B4320", Slot = "27")]
	public void AMOGEPNPKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x59B42E0", Offset = "0x59B36E0", VA = "0x1859B42E0", Slot = "25")]
	public void ADOFMEEMJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x59B6EF0", Offset = "0x59B62F0", VA = "0x1859B6EF0", Slot = "24")]
	public void MIEKIDJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x59B6CB0", Offset = "0x59B60B0", VA = "0x1859B6CB0", Slot = "33")]
	public void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x59B5100", Offset = "0x59B4500", VA = "0x1859B5100", Slot = "32")]
	public void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x59B46A0", Offset = "0x59B3AA0", VA = "0x1859B46A0", Slot = "31")]
	public void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x59B7230", Offset = "0x59B6630", VA = "0x1859B7230", Slot = "22")]
	public void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x59B7750", Offset = "0x59B6B50", VA = "0x1859B7750", Slot = "21")]
	public void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x59B7990", Offset = "0x59B6D90", VA = "0x1859B7990", Slot = "23")]
	[Obsolete]
	public void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x59B6730", Offset = "0x59B5B30", VA = "0x1859B6730", Slot = "29")]
	public Vector3 KGFOHHPIBKL(Vector3 CPDGHJJAFAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x59B4F10", Offset = "0x59B4310", VA = "0x1859B4F10", Slot = "26")]
	public void EPOHAHFFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x59B4390", Offset = "0x59B3790", VA = "0x1859B4390")]
	private void BHBJAIOINPH(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x59B6920", Offset = "0x59B5D20", VA = "0x1859B6920")]
	private void LKDFNPNMIEM(Vector3 NBGGCFEJDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x59B4B90", Offset = "0x59B3F90", VA = "0x1859B4B90")]
	private Vector3 ECMFDAFPGOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x59B5B90", Offset = "0x59B4F90", VA = "0x1859B5B90")]
	private void JLAJFHAPNAN(Vector3 BGOLDLKKMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x59B5780", Offset = "0x59B4B80", VA = "0x1859B5780")]
	private Vector3 IOHDKLJLHFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x59B52C0", Offset = "0x59B46C0", VA = "0x1859B52C0")]
	private void HOJCMIAJBGA(Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x59B5720", Offset = "0x59B4B20", VA = "0x1859B5720")]
	private void ILKCHJKACJK(Vector3 CPDGHJJAFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x59B66D0", Offset = "0x59B5AD0", VA = "0x1859B66D0")]
	private void KEHKKIJLOBK(Vector3 HNJKKMCILJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x59B6000", Offset = "0x59B5400", VA = "0x1859B6000")]
	private void JNHKLHKDBJE(string LPDFAHOGJAH, Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x59B4E50", Offset = "0x59B4250", VA = "0x1859B4E50")]
	private void EMGBOBOHMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class NIMOFKMKEFP : KNLFGDKJAII, IFAGKIJIHAD
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x59C38A0", Offset = "0x59C2CA0", VA = "0x1859C38A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x59C3A60", Offset = "0x59C2E60", VA = "0x1859C3A60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x59C4030", Offset = "0x59C3430", VA = "0x1859C4030", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x59C3E40", Offset = "0x59C3240", VA = "0x1859C3E40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public NIMOFKMKEFP(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x59C3C50", Offset = "0x59C3050", VA = "0x1859C3C50", Slot = "8")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x59C3990", Offset = "0x59C2D90", VA = "0x1859C3990", Slot = "9")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[UnityEngine.Scripting.Preserve]
public sealed class JNFHINOHHLM : EAHCLCDMENH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JNFHINOHHLM HLFGGJBLCBK;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public RigidbodyEx PDKMCAJHMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GameObject EHDLGABJMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Transform GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA828D0", Offset = "0xA81CD0", VA = "0x180A828D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xC5E150", Offset = "0xC5D550", VA = "0x180C5E150", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xB90640", Offset = "0xB8FA40", VA = "0x180B90640", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x234E020", Offset = "0x234D420", VA = "0x18234E020", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x17725F0", Offset = "0x17719F0", VA = "0x1817725F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x33691F0", Offset = "0x33685F0", VA = "0x1833691F0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2EEC500", Offset = "0x2EEB900", VA = "0x182EEC500", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x59B38B0", Offset = "0x59B2CB0", VA = "0x1859B38B0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C940", Offset = "0x2A3BD40", VA = "0x182A3C940", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1B4C7D0", Offset = "0x1B4BBD0", VA = "0x181B4C7D0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool KHJMFPKDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8F8CF0", Offset = "0x8F80F0", VA = "0x1808F8CF0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool AJIHOIMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5E0", Offset = "0x9BA9E0", VA = "0x1809BB5E0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5F0", Offset = "0x9BA9F0", VA = "0x1809BB5F0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2EEC530", Offset = "0x2EEB930", VA = "0x182EEC530", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x11A7D10", Offset = "0x11A7110", VA = "0x1811A7D10", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF0EC0", Offset = "0x1DF02C0", VA = "0x181DF0EC0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x59B38E0", Offset = "0x59B2CE0", VA = "0x1859B38E0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9FBD20", Offset = "0x9FB120", VA = "0x1809FBD20", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x993850", Offset = "0x992C50", VA = "0x180993850", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9FBD20", Offset = "0x9FB120", VA = "0x1809FBD20", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9FBD20", Offset = "0x9FB120", VA = "0x1809FBD20", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "48")]
		get
		{
			return default(PPADPBDPHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x152AB30", Offset = "0x1529F30", VA = "0x18152AB30", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Transform FCDBEGFHINM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9924A0", Offset = "0x9918A0", VA = "0x1809924A0", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 EAJGLLBNNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float DFLNGLEFOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9FBD20", Offset = "0x9FB120", VA = "0x1809FBD20", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float GECDAEFNECM
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9FBD20", Offset = "0x9FB120", VA = "0x1809FBD20", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion FINBMEHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xD572D0", Offset = "0xD566D0", VA = "0x180D572D0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 MOMDFBGEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Quaternion LBNLHCEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xD572D0", Offset = "0xD566D0", VA = "0x180D572D0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool PKFGFIFDCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1B121F0", Offset = "0x1B115F0", VA = "0x181B121F0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ABKBPFMJPBP OCMEHKGHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ABKBPFMJPBP GDCCEAOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event GPFPGDKFNGA FDBHKJAPMML
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event ABKBPFMJPBP IJABNKFJANE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event ABKBPFMJPBP DBOBKOEDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event ABKBPFMJPBP OCPDCNELHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event ABKBPFMJPBP KBIHLCENPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event ABKBPFMJPBP CELEGIEBBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "41")]
	public void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "71")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "72")]
	public void AILPEEFKMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "73")]
	public void AKHHEEOMHLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "74")]
	public void IKBHHOGFNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "81")]
	public void CIGBDIGMBAB(EAHCLCDMENH KKIAKNLLHIO, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "84")]
	public void NACBDIDMAEK(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "85")]
	public void PFIEFHMFEBD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "86")]
	public Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "87")]
	public Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "88")]
	public void AMOGEPNPKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "89")]
	public void ADOFMEEMJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "90")]
	public void MIEKIDJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "91")]
	public void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "92")]
	public void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "93")]
	public void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "94")]
	public void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "95")]
	public void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "96")]
	public void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "97")]
	public Vector3 KGFOHHPIBKL(Vector3 KKIAKNLLHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1A7B520", Offset = "0x1A7A920", VA = "0x181A7B520", Slot = "98")]
	public Vector3 JCAJFPBNAOB(Vector3 KKIAKNLLHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "99")]
	public void EPOHAHFFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "100")]
	public void BHCDCOACEBK(EAHCLCDMENH MIBNLDFCFFK, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "101")]
	public void CHLPIOHBPHF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "104")]
	public void IANILGHLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "105")]
	public void AFKHDNAIDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "106")]
	public void FIJLCNFMINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "109")]
	public bool FJPDMKBDPKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "110")]
	public void MANGGEGDHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "115")]
	public IDisposable JOJJOHNBPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "116")]
	public void IPEGEGKFAIF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "117")]
	public void CGABPKKHALD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "118")]
	public void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "121")]
	public void LDECEFAOEKE(Vector3 KBIMMDIDBHL, Quaternion MJHKKDHDILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "122")]
	public void HOLMJOIABJP(Vector3 LLJDDGPKDOH, Quaternion LHHJFNHIMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "123")]
	public bool JGFGLKEIOCO(float JLFGAMMLIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "124")]
	public void HDBJNMJIFCG(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "125")]
	public void DNCPBGHIBNM(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "126")]
	public void FOEDBBCKFAI(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "127")]
	public void GNGBJDCLCGN(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "128")]
	public void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "129")]
	public void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "130")]
	public void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "131")]
	public void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x59B38C0", Offset = "0x59B2CC0", VA = "0x1859B38C0", Slot = "132")]
	public bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "133")]
	public void GACDEFCAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public JNFHINOHHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OIKILLAJONK : KNLFGDKJAII, GIHANPIMODL
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A590", Offset = "0x6E49990", VA = "0x186E4A590", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A140", Offset = "0x6E49540", VA = "0x186E4A140", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6E49E00", Offset = "0x6E49200", VA = "0x186E49E00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EAHCLCDMENH PICDHIIIKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6E49FF0", Offset = "0x6E493F0", VA = "0x186E49FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A900", Offset = "0x6E49D00", VA = "0x186E4A900")]
	public OIKILLAJONK(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A2C0", Offset = "0x6E496C0", VA = "0x186E4A2C0", Slot = "6")]
	public void LMANKEHBFOH(EAHCLCDMENH ILDFJHMNOPJ, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A450", Offset = "0x6E49850", VA = "0x186E4A450")]
	private void LMANKEHBFOH(MMCIBGLLBBL ILDFJHMNOPJ, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6E49EE0", Offset = "0x6E492E0", VA = "0x186E49EE0", Slot = "7")]
	public void FJIAHIOLIEL(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A5C0", Offset = "0x6E499C0", VA = "0x186E4A5C0")]
	private Vector3 PEHDKDDCJHK()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class IEHIIKIMFAH
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x59B3690", Offset = "0x59B2A90", VA = "0x1859B3690")]
	public static OIKILLAJONK JDNCCJBJONI(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class EAHNEOOEKIJ : KNLFGDKJAII, NGDGBGPMNDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly PILIJFIMAJF LDJICMCHFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EHEHGHCKFII NPNHLMGKIGM;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Transform GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x59ABE20", Offset = "0x59AB220", VA = "0x1859ABE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public KDLENLDMBAK BKKBKFEEACI
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x59ABFB0", Offset = "0x59AB3B0", VA = "0x1859ABFB0")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x59AB2E0", Offset = "0x59AA6E0", VA = "0x1859AB2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x59ABDE0", Offset = "0x59AB1E0", VA = "0x1859ABDE0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x59ABD70", Offset = "0x59AB170", VA = "0x1859ABD70", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public KDLENLDMBAK BELNIHBNKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x59AAFD0", Offset = "0x59AA3D0", VA = "0x1859AAFD0")]
		get
		{
			return default(KDLENLDMBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x59AC500", Offset = "0x59AB900", VA = "0x1859AC500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x59AC9D0", Offset = "0x59ABDD0", VA = "0x1859AC9D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ABKBPFMJPBP OCMEHKGHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x59AC6B0", Offset = "0x59ABAB0", VA = "0x1859AC6B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x59ACBA0", Offset = "0x59ABFA0", VA = "0x1859ACBA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ABKBPFMJPBP GDCCEAOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x59AC7F0", Offset = "0x59ABBF0", VA = "0x1859AC7F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x59AC300", Offset = "0x59AB700", VA = "0x1859AC300", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event GPFPGDKFNGA FDBHKJAPMML
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x59AB610", Offset = "0x59AAA10", VA = "0x1859AB610", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x59ACA10", Offset = "0x59ABE10", VA = "0x1859ACA10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action IOKKCNKMBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x59AA7E0", Offset = "0x59A9BE0", VA = "0x1859AA7E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x59AAAB0", Offset = "0x59A9EB0", VA = "0x1859AAAB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action CNKIMCMFKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x59AADA0", Offset = "0x59AA1A0", VA = "0x1859AADA0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x59ABF10", Offset = "0x59AB310", VA = "0x1859ABF10", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<EAHCLCDMENH> IOKJLMPMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x59AAF30", Offset = "0x59AA330", VA = "0x1859AAF30", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x59AC610", Offset = "0x59ABA10", VA = "0x1859AC610", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<EAHCLCDMENH> HDNMOMGDEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x59AC890", Offset = "0x59ABC90", VA = "0x1859AC890", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x59AC930", Offset = "0x59ABD30", VA = "0x1859AC930", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action JJDNGEBPMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x59AAD00", Offset = "0x59AA100", VA = "0x1859AAD00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x59AC750", Offset = "0x59ABB50", VA = "0x1859AC750", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<EAHCLCDMENH> DBCLHMMPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x59AC0C0", Offset = "0x59AB4C0", VA = "0x1859AC0C0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x59AB0E0", Offset = "0x59AA4E0", VA = "0x1859AB0E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x59ACCD0", Offset = "0x59AC0D0", VA = "0x1859ACCD0")]
	public EAHNEOOEKIJ(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x59AB3F0", Offset = "0x59AA7F0", VA = "0x1859AB3F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x59AAE40", Offset = "0x59AA240", VA = "0x1859AAE40", Slot = "26")]
	public void CIGBDIGMBAB(EAHCLCDMENH GHLIBENNEBB, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x59AAEC0", Offset = "0x59AA2C0", VA = "0x1859AAEC0")]
	private void CIGBDIGMBAB(MMCIBGLLBBL GHLIBENNEBB, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x59AB6B0", Offset = "0x59AAAB0", VA = "0x1859AB6B0")]
	private void EBMFDOIIIKI(MMCIBGLLBBL GHLIBENNEBB, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x59AAB50", Offset = "0x59A9F50", VA = "0x1859AAB50")]
	private void BOOBLANHJJF(MMCIBGLLBBL NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x59AC160", Offset = "0x59AB560", VA = "0x1859AC160")]
	private void IIIOMNJBEPA(MMCIBGLLBBL NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x59AA880", Offset = "0x59A9C80", VA = "0x1859AA880")]
	private void BKFOCEPJGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x59ACAB0", Offset = "0x59ABEB0", VA = "0x1859ACAB0")]
	private void ONKICCKEALM(MMCIBGLLBBL NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x59ABE50", Offset = "0x59AB250", VA = "0x1859ABE50")]
	private void FGDHMLIDGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x59AB180", Offset = "0x59AA580", VA = "0x1859AB180")]
	private void DHPKFCEIGDC(MMCIBGLLBBL LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x59AC3A0", Offset = "0x59AB7A0", VA = "0x1859AC3A0")]
	private void JGCNEKOCFFL(MMCIBGLLBBL LJACJOOEGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class DCJNGNHJKOO
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x59A9570", Offset = "0x59A8970", VA = "0x1859A9570")]
	public static EAHNEOOEKIJ HIGPLAHDIIH(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class MMCIBGLLBBL : AFAOFDBMCDE, ELAIMCPDFHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal HNIPNFEMKKN FJBKBEHBEBC;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x59C3380", Offset = "0x59C2780", VA = "0x1859C3380")]
	public MMCIBGLLBBL(GameObject GACFHLOJJGF, RigidbodyEx CPBAKEFGMHN, BCPFDHDHBHN MLODHIKJENP, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x59C2970", Offset = "0x59C1D70", VA = "0x1859C2970", Slot = "135")]
	protected override void COKNCMNBNHP(BCPFDHDHBHN MLODHIKJENP, OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "141")]
	protected override IDisposable AEKIOPBAAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x59C2C00", Offset = "0x59C2000", VA = "0x1859C2C00", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x59C2D90", Offset = "0x59C2190", VA = "0x1859C2D90", Slot = "142")]
	public void GCCKACDCBAD(GIOFAADFPJL LCEOCHLKMEN, GIOFAADFPJL OIKAFLDALHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x59C3260", Offset = "0x59C2660", VA = "0x1859C3260", Slot = "143")]
	public void NFBEFECEPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x59C28B0", Offset = "0x59C1CB0", VA = "0x1859C28B0", Slot = "144")]
	public void CCEMKNHLLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x59C2E50", Offset = "0x59C2250", VA = "0x1859C2E50", Slot = "145")]
	public void IFCKMHMOBIO(bool KLOFHCIIDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x59C2EB0", Offset = "0x59C22B0", VA = "0x1859C2EB0", Slot = "146")]
	public bool KAMMMEIPBPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x59C3320", Offset = "0x59C2720", VA = "0x1859C3320", Slot = "147")]
	public void PIDBIPDDMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "140")]
	protected override void EKJIADIMKGC(RigidbodyEx AHNODGPGJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x59C3020", Offset = "0x59C2420", VA = "0x1859C3020")]
	private void MNOEAAGDHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class NDMBJCJIKLD
{
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x59C3850", Offset = "0x59C2C50", VA = "0x1859C3850")]
	public static AFAOFDBMCDE GEMOAJEBENN(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OHFJGAPABCN : KNLFGDKJAII, NBBLFILMLJG
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool KFBBINHOBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E49600", Offset = "0x6E48A00", VA = "0x186E49600", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public BFEGGBIPHDI LGEBLOBJMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E493E0", Offset = "0x6E487E0", VA = "0x186E493E0", Slot = "11")]
		get
		{
			return default(BFEGGBIPHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private BFEGGBIPHDI PPPAMNCBJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E498F0", Offset = "0x6E48CF0", VA = "0x186E498F0")]
		get
		{
			return default(BFEGGBIPHDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E49B30", Offset = "0x6E48F30", VA = "0x186E49B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E49CF0", Offset = "0x6E490F0", VA = "0x186E49CF0")]
	public OHFJGAPABCN(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E49C30", Offset = "0x6E49030", VA = "0x186E49C30", Slot = "4")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E49340", Offset = "0x6E48740", VA = "0x186E49340")]
	private bool CEGKJJKNDNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E496F0", Offset = "0x6E48AF0", VA = "0x186E496F0", Slot = "5")]
	public void GGFDFEJJGCB(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E49A20", Offset = "0x6E48E20", VA = "0x186E49A20", Slot = "6")]
	public void NMLEAJNOELO(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E493F0", Offset = "0x6E487F0", VA = "0x186E493F0", Slot = "9")]
	public void FFPENNDCBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E49800", Offset = "0x6E48C00", VA = "0x186E49800")]
	private void GNNMACLDFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E49500", Offset = "0x6E48900", VA = "0x186E49500")]
	private void GELMNFDDDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E49300", Offset = "0x6E48700", VA = "0x186E49300", Slot = "8")]
	public void AIBFOBAFNNP(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E499E0", Offset = "0x6E48DE0", VA = "0x186E499E0", Slot = "7")]
	public void LHEHOMOIPOM(EAHCLCDMENH LJACJOOEGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class EPCLLDFALAO : KNLFGDKJAII, KADBGOOJEOK
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DF0", Offset = "0x59A51F0", VA = "0x1859A5DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x59A5E40", Offset = "0x59A5240", VA = "0x1859A5E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x59B0400", Offset = "0x59AF800", VA = "0x1859B0400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public EPCLLDFALAO(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x59B0C20", Offset = "0x59B0020", VA = "0x1859B0C20", Slot = "4")]
	public void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x59B07D0", Offset = "0x59AFBD0", VA = "0x1859B07D0")]
	private void HEBKDFHHOJG(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x59AFEE0", Offset = "0x59AF2E0", VA = "0x1859AFEE0", Slot = "5")]
	public void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x59B0AC0", Offset = "0x59AFEC0", VA = "0x1859B0AC0", Slot = "6")]
	public void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x59B0180", Offset = "0x59AF580", VA = "0x1859B0180")]
	private void DDLKGKLCOHK(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x59B0550", Offset = "0x59AF950", VA = "0x1859B0550", Slot = "7")]
	public void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x59B0460", Offset = "0x59AF860", VA = "0x1859B0460")]
	private void GEPKNBOCDIP(string HGJHDPGFLKO, UnityEngine.Object JNNDIHFHMHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class LDIHGJGELEO : KNLFGDKJAII, LBENAEPJLBH
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x59B8F50", Offset = "0x59B8350", VA = "0x1859B8F50", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x59B8B40", Offset = "0x59B7F40", VA = "0x1859B8B40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x59A5E40", Offset = "0x59A5240", VA = "0x1859A5E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool NDDLNIJEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x59B8C40", Offset = "0x59B8040", VA = "0x1859B8C40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x59B97F0", Offset = "0x59B8BF0", VA = "0x1859B97F0")]
	public LDIHGJGELEO(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x59B9740", Offset = "0x59B8B40", VA = "0x1859B9740", Slot = "5")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x59B8D30", Offset = "0x59B8130", VA = "0x1859B8D30", Slot = "7")]
	public void FOEDBBCKFAI(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x59B8E40", Offset = "0x59B8240", VA = "0x1859B8E40", Slot = "8")]
	public void GNGBJDCLCGN(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x59B9470", Offset = "0x59B8870", VA = "0x1859B9470", Slot = "9")]
	public void PODMBMBFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x59B9040", Offset = "0x59B8440", VA = "0x1859B9040", Slot = "11")]
	public void MOFCAKPKPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x59B92A0", Offset = "0x59B86A0", VA = "0x1859B92A0", Slot = "12")]
	public void ODKMHFDBDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "10")]
	public void IMJGGFDFKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class KFPNHJPMGBA : KNLFGDKJAII, DIFPEGGHMMK
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x59B41C0", Offset = "0x59B35C0", VA = "0x1859B41C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private bool CKMBKBGHJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x59B3EC0", Offset = "0x59B32C0", VA = "0x1859B3EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ABKBPFMJPBP KBIHLCENPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x59B3E20", Offset = "0x59B3220", VA = "0x1859B3E20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x59B3B60", Offset = "0x59B2F60", VA = "0x1859B3B60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public KFPNHJPMGBA(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x59B4160", Offset = "0x59B3560", VA = "0x1859B4160", Slot = "11")]
	public IDisposable JOJJOHNBPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x59B4150", Offset = "0x59B3550", VA = "0x1859B4150", Slot = "8")]
	public void IPEGEGKFAIF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x59B3C00", Offset = "0x59B3000", VA = "0x1859B3C00", Slot = "9")]
	public void CGABPKKHALD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x59B3A50", Offset = "0x59B2E50", VA = "0x1859B3A50", Slot = "10")]
	public void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x59B3FB0", Offset = "0x59B33B0", VA = "0x1859B3FB0", Slot = "12")]
	public void HFEDNFBGKEI(Rigidbody HCHEOFCJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x59B3C10", Offset = "0x59B3010", VA = "0x1859B3C10", Slot = "13")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x59B3A10", Offset = "0x59B2E10", VA = "0x1859B3A10", Slot = "6")]
	public void AGBEIPBBBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CMAHOHNOIGM : KNLFGDKJAII, NLLPDNBDLAA
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private CollisionDetectionMode GEMCOFJDNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x59A9100", Offset = "0x59A8500", VA = "0x1859A9100")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x59A9000", Offset = "0x59A8400", VA = "0x1859A9000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x59A8D00", Offset = "0x59A8100", VA = "0x1859A8D00", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x59A8E10", Offset = "0x59A8210", VA = "0x1859A8E10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public CMAHOHNOIGM(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x59A9200", Offset = "0x59A8600", VA = "0x1859A9200", Slot = "6")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x59A8C70", Offset = "0x59A8070", VA = "0x1859A8C70", Slot = "9")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x59A8A40", Offset = "0x59A7E40", VA = "0x1859A8A40", Slot = "7")]
	public void DGFGECMKBOI(bool NDMAAJEOGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x59A91F0", Offset = "0x59A85F0", VA = "0x1859A91F0", Slot = "8")]
	public void POLOMBPGGEK(bool NDMAAJEOGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x59A8E90", Offset = "0x59A8290", VA = "0x1859A8E90", Slot = "10")]
	public bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x59A8A50", Offset = "0x59A7E50", VA = "0x1859A8A50")]
	private void EPMMHMHCJEJ(bool NDMAAJEOGII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DefaultMember("Item")]
public sealed class EHEHGHCKFII : IReadOnlyList<EAHCLCDMENH>, IEnumerable<EAHCLCDMENH>, IEnumerable, IReadOnlyCollection<EAHCLCDMENH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly KDLENLDMBAK BGPCGOEKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly HNIPNFEMKKN OBOAIKCPODL;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x59ADF90", Offset = "0x59AD390", VA = "0x1859ADF90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public EAHCLCDMENH OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x59AE070", Offset = "0x59AD470", VA = "0x1859AE070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x59ADF40", Offset = "0x59AD340", VA = "0x1859ADF40")]
	public EHEHGHCKFII(KDLENLDMBAK BGPCGOEKFEF, HNIPNFEMKKN OBOAIKCPODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x59ADDA0", Offset = "0x59AD1A0", VA = "0x1859ADDA0", Slot = "6")]
	public IEnumerator<EAHCLCDMENH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x59ADDA0", Offset = "0x59AD1A0", VA = "0x1859ADDA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x59ADD90", Offset = "0x59AD190", VA = "0x1859ADD90")]
	[CompilerGenerated]
	private EAHCLCDMENH DMBHCAJGGEL(int GNPGECNAJNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KKAINODEBLL : MCIKANEBNMG
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x59B80F0", Offset = "0x59B74F0", VA = "0x1859B80F0", Slot = "4")]
	public NGDGBGPMNDG DNMHDDBILFO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x59B8430", Offset = "0x59B7830", VA = "0x1859B8430", Slot = "5")]
	public NLMOECEILLG HAHHPANPKEF(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x59B8570", Offset = "0x59B7970", VA = "0x1859B8570", Slot = "6")]
	public GIHANPIMODL IFJFOOPBCIG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x59B7FB0", Offset = "0x59B73B0", VA = "0x1859B7FB0", Slot = "7")]
	public IFAGKIJIHAD DGMODLBACCJ(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x59B7F50", Offset = "0x59B7350", VA = "0x1859B7F50", Slot = "8")]
	public BLLOODMDKJF COJJGOJLGFB(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x59B84D0", Offset = "0x59B78D0", VA = "0x1859B84D0", Slot = "9")]
	public BLBLCFEJOBG HOCKFGNGOCH(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x59B85D0", Offset = "0x59B79D0", VA = "0x1859B85D0", Slot = "10")]
	public DIFPEGGHMMK JJPGFMHCBPI(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x59B8050", Offset = "0x59B7450", VA = "0x1859B8050", Slot = "11")]
	public KADBGOOJEOK DNLPLFMNDAO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x59B8750", Offset = "0x59B7B50", VA = "0x1859B8750", Slot = "12")]
	public NLLPDNBDLAA MOCJAKNHGGG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x59B87F0", Offset = "0x59B7BF0", VA = "0x1859B87F0", Slot = "13")]
	public LAPMGAFDIDC NPHPHMDHGBA(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x59B8300", Offset = "0x59B7700", VA = "0x1859B8300")]
	public LBENAEPJLBH LBGFONNAIPO(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x59B7DE0", Offset = "0x59B71E0", VA = "0x1859B7DE0")]
	public KMDNIJEJNBK AEPBLKBIPLF(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x59B86E0", Offset = "0x59B7AE0", VA = "0x1859B86E0")]
	public NBBLFILMLJG KBLELAONPDA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x59B83C0", Offset = "0x59B77C0", VA = "0x1859B83C0")]
	public GPOBHMGKMJL LGMJPCAEIDD(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x59B8670", Offset = "0x59B7A70", VA = "0x1859B8670")]
	public LBLOJOEPDDJ JOIFNHKACNI(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x59B7EA0", Offset = "0x59B72A0", VA = "0x1859B7EA0", Slot = "19")]
	public EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA, BCPFDHDHBHN MLODHIKJENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public KKAINODEBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x59B8300", Offset = "0x59B7700", VA = "0x1859B8300", Slot = "14")]
	private LBENAEPJLBH FBBCIKFKOKP(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x59B7DE0", Offset = "0x59B71E0", VA = "0x1859B7DE0", Slot = "15")]
	private KMDNIJEJNBK IMIEIJIOMGE(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x59B86E0", Offset = "0x59B7AE0", VA = "0x1859B86E0", Slot = "16")]
	private NBBLFILMLJG OBGDPJFNKHG(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x59B83C0", Offset = "0x59B77C0", VA = "0x1859B83C0", Slot = "17")]
	private GPOBHMGKMJL FFMKOLPLCAA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x59B8670", Offset = "0x59B7A70", VA = "0x1859B8670", Slot = "18")]
	private LBLOJOEPDDJ MBELMNKDLEL(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MHKGHOKOJED : KNLFGDKJAII, BLLOODMDKJF
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool DIGMNPKCMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x59B5160", Offset = "0x59B4560", VA = "0x1859B5160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x59C1C00", Offset = "0x59C1000", VA = "0x1859C1C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x59C2370", Offset = "0x59C1770", VA = "0x1859C2370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private bool LDPIDNCDJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x59C2280", Offset = "0x59C1680", VA = "0x1859C2280")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x59C1B00", Offset = "0x59C0F00", VA = "0x1859C1B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private bool IEFEGLIBNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x59C1E90", Offset = "0x59C1290", VA = "0x1859C1E90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x59C1A00", Offset = "0x59C0E00", VA = "0x1859C1A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private int JNNHCFKGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x59C20D0", Offset = "0x59C14D0", VA = "0x1859C20D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event ABKBPFMJPBP OCPDCNELHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x59C2030", Offset = "0x59C1430", VA = "0x1859C2030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x59C23E0", Offset = "0x59C17E0", VA = "0x1859C23E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x59C2690", Offset = "0x59C1A90", VA = "0x1859C2690")]
	public MHKGHOKOJED(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x59C25E0", Offset = "0x59C19E0", VA = "0x1859C25E0", Slot = "6")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x59C23D0", Offset = "0x59C17D0", VA = "0x1859C23D0", Slot = "8")]
	public void OANFHLODHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x59C1C60", Offset = "0x59C1060", VA = "0x1859C1C60", Slot = "7")]
	public bool FJPDMKBDPKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x59C1F80", Offset = "0x59C1380", VA = "0x1859C1F80", Slot = "9")]
	public void IKBHHOGFNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x59B3A10", Offset = "0x59B2E10", VA = "0x1859B3A10", Slot = "12")]
	public void IFCKMHMOBIO(bool KLOFHCIIDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x59C21D0", Offset = "0x59C15D0", VA = "0x1859C21D0", Slot = "11")]
	public void MANGGEGDHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "10")]
	public void OOKNGPICNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x59C2480", Offset = "0x59C1880", VA = "0x1859C2480")]
	private void POCCACEIIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[EFDJEPLIMOC(typeof(MCIKANEBNMG), new string[] { })]
public class GDCBFEBLCBB : MCIKANEBNMG, AKFIPDJCCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly MCIKANEBNMG OMNFJBGJNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MCIKANEBNMG NNBEJFPKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GFGEKEKINCH CMKMKKAFPAC;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private MCIKANEBNMG DKFECOPNJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x59B2060", Offset = "0x59B1460", VA = "0x1859B2060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x59B1CD0", Offset = "0x59B10D0", VA = "0x1859B1CD0", Slot = "20")]
	public void InitReferences(EMFBCBAOENA PHPOLCBAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x59B18F0", Offset = "0x59B0CF0", VA = "0x1859B18F0", Slot = "4")]
	public NGDGBGPMNDG DNMHDDBILFO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x59B1AF0", Offset = "0x59B0EF0", VA = "0x1859B1AF0", Slot = "5")]
	public NLMOECEILLG HAHHPANPKEF(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x59B1C30", Offset = "0x59B1030", VA = "0x1859B1C30", Slot = "6")]
	public GIHANPIMODL IFJFOOPBCIG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x59B17B0", Offset = "0x59B0BB0", VA = "0x1859B17B0", Slot = "7")]
	public IFAGKIJIHAD DGMODLBACCJ(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x59B1710", Offset = "0x59B0B10", VA = "0x1859B1710", Slot = "8")]
	public BLLOODMDKJF COJJGOJLGFB(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x59B1B90", Offset = "0x59B0F90", VA = "0x1859B1B90", Slot = "9")]
	public BLBLCFEJOBG HOCKFGNGOCH(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x59B1D20", Offset = "0x59B1120", VA = "0x1859B1D20", Slot = "10")]
	public DIFPEGGHMMK JJPGFMHCBPI(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x59B1850", Offset = "0x59B0C50", VA = "0x1859B1850", Slot = "11")]
	public KADBGOOJEOK DNLPLFMNDAO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x59B1F20", Offset = "0x59B1320", VA = "0x1859B1F20", Slot = "12")]
	public NLLPDNBDLAA MOCJAKNHGGG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x59B1FC0", Offset = "0x59B13C0", VA = "0x1859B1FC0", Slot = "13")]
	public LAPMGAFDIDC NPHPHMDHGBA(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x59B1990", Offset = "0x59B0D90", VA = "0x1859B1990")]
	public LBENAEPJLBH LBGFONNAIPO(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x59B1510", Offset = "0x59B0910", VA = "0x1859B1510")]
	public KMDNIJEJNBK AEPBLKBIPLF(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x59B1E70", Offset = "0x59B1270", VA = "0x1859B1E70")]
	public NBBLFILMLJG KBLELAONPDA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x59B1A40", Offset = "0x59B0E40", VA = "0x1859B1A40")]
	public GPOBHMGKMJL LGMJPCAEIDD(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x59B1DC0", Offset = "0x59B11C0", VA = "0x1859B1DC0")]
	public LBLOJOEPDDJ JOIFNHKACNI(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x59B15C0", Offset = "0x59B09C0", VA = "0x1859B15C0", Slot = "19")]
	public EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA, BCPFDHDHBHN MLODHIKJENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x59B20C0", Offset = "0x59B14C0", VA = "0x1859B20C0")]
	public GDCBFEBLCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x59B1990", Offset = "0x59B0D90", VA = "0x1859B1990", Slot = "14")]
	private LBENAEPJLBH FBBCIKFKOKP(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x59B1510", Offset = "0x59B0910", VA = "0x1859B1510", Slot = "15")]
	private KMDNIJEJNBK IMIEIJIOMGE(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x59B1E70", Offset = "0x59B1270", VA = "0x1859B1E70", Slot = "16")]
	private NBBLFILMLJG OBGDPJFNKHG(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x59B1A40", Offset = "0x59B0E40", VA = "0x1859B1A40", Slot = "17")]
	private GPOBHMGKMJL FFMKOLPLCAA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x59B1DC0", Offset = "0x59B11C0", VA = "0x1859B1DC0", Slot = "18")]
	private LBLOJOEPDDJ MBELMNKDLEL(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class ABAEBKPMBMM : KNLFGDKJAII, LAPMGAFDIDC
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x599EB80", Offset = "0x599DF80", VA = "0x18599EB80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x599E990", Offset = "0x599DD90", VA = "0x18599E990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public ABAEBKPMBMM(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x599E870", Offset = "0x599DC70", VA = "0x18599E870", Slot = "6")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x599E800", Offset = "0x599DC00", VA = "0x18599E800", Slot = "7")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class KNLFGDKJAII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly MMCIBGLLBBL LJACJOOEGHH;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected HNIPNFEMKKN BEOFNEDOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x59B89E0", Offset = "0x59B7DE0", VA = "0x1859B89E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected KDLENLDMBAK KEENOEKFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x59B8890", Offset = "0x59B7C90", VA = "0x1859B8890")]
		get
		{
			return default(KDLENLDMBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public KNLFGDKJAII(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x59B88C0", Offset = "0x59B7CC0", VA = "0x1859B88C0")]
	protected EAHCLCDMENH IGNLKMAHOOH(KDLENLDMBAK BGPCGOEKFEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class LIPIKIHPFMI : KNLFGDKJAII, KMDNIJEJNBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PhotonView JDECFKODFEF;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x59AD9B0", Offset = "0x59ACDB0", VA = "0x1859AD9B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x59BAD00", Offset = "0x59BA100", VA = "0x1859BAD00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ABKBPFMJPBP IJABNKFJANE
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x59BAC60", Offset = "0x59BA060", VA = "0x1859BAC60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x59BAE50", Offset = "0x59BA250", VA = "0x1859BAE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x59BBA20", Offset = "0x59BAE20", VA = "0x1859BBA20")]
	public LIPIKIHPFMI(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x59BB8D0", Offset = "0x59BACD0", VA = "0x1859BB8D0", Slot = "8")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x59BAA50", Offset = "0x59B9E50", VA = "0x1859BAA50", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x59BB2E0", Offset = "0x59BA6E0", VA = "0x1859BB2E0", Slot = "9")]
	public void MBNODPMJKAO(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x59BAEF0", Offset = "0x59BA2F0", VA = "0x1859BAEF0", Slot = "10")]
	public void JPNNLJAEKJC(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x59BB6A0", Offset = "0x59BAAA0", VA = "0x1859BB6A0")]
	private void OHINHJPFKFI(PhotonView DBKMCOAAEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x59BB4F0", Offset = "0x59BA8F0", VA = "0x1859BB4F0")]
	private void MEKLAGNOKHP(RigidbodyEx PLHHGAJBDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x59BB100", Offset = "0x59BA500", VA = "0x1859BB100")]
	private void KBDOFCKCNAF(PhotonView AIOGCLCJMKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class IBDBCLNEPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x59B3360", Offset = "0x59B2760", VA = "0x1859B3360")]
	public static LIPIKIHPFMI PBEFJDJDDEC(this AFAOFDBMCDE LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class MBNIMJBIEEH : KNLFGDKJAII, LBLOJOEPDDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x59C0400", Offset = "0x59BF800", VA = "0x1859C0400", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x59C04F0", Offset = "0x59BF8F0", VA = "0x1859C04F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool GFICPLAOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x59BFFE0", Offset = "0x59BF3E0", VA = "0x1859BFFE0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x59C05F0", Offset = "0x59BF9F0", VA = "0x1859C05F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x59BFDE0", Offset = "0x59BF1E0", VA = "0x1859BFDE0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x59C01F0", Offset = "0x59BF5F0", VA = "0x1859C01F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x59C06F0", Offset = "0x59BFAF0", VA = "0x1859C06F0")]
	public MBNIMJBIEEH(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x59C00D0", Offset = "0x59BF4D0", VA = "0x1859C00D0", Slot = "9")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x59BFED0", Offset = "0x59BF2D0", VA = "0x1859BFED0", Slot = "10")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class DGEBKBEEBEC : KNLFGDKJAII, BLBLCFEJOBG, IDisposable, CAJOJINPBPL
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public PPADPBDPHGN MLCJPNABEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x59AA690", Offset = "0x59A9A90", VA = "0x1859AA690")]
		get
		{
			return default(PPADPBDPHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x59AA230", Offset = "0x59A9630", VA = "0x1859AA230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x59AA330", Offset = "0x59A9730", VA = "0x1859AA330", Slot = "6")]
		get
		{
			return default(PPADPBDPHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x59AA230", Offset = "0x59A9630", VA = "0x1859AA230", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private Transform HAKBFDNOHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x59AA5F0", Offset = "0x59A99F0", VA = "0x1859AA5F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x59AA550", Offset = "0x59A9950", VA = "0x1859AA550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x599EC70", Offset = "0x599E070", VA = "0x18599EC70")]
	public DGEBKBEEBEC(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x59AA780", Offset = "0x59A9B80", VA = "0x1859AA780", Slot = "11")]
	public void OnChangedDistanceBand(JCCBPCLKPNF LCEOCHLKMEN, JCCBPCLKPNF OIKAFLDALHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "12")]
	public void OnChangedVisibility(bool FJINNNNEOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class FLOJPAMKKDO : BLBLCFEJOBG, IDisposable, CAJOJINPBPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private PPADPBDPHGN HCKFBHFEJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private LDKPPGCLIKN BGPECPMMKKE;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public PPADPBDPHGN IFFHEHFIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x59B0F20", Offset = "0x59B0320", VA = "0x1859B0F20", Slot = "6")]
		get
		{
			return default(PPADPBDPHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x59B0DA0", Offset = "0x59B01A0", VA = "0x1859B0DA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private Transform HAKBFDNOHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x59B0D80", Offset = "0x59B0180", VA = "0x1859B0D80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<JCCBPCLKPNF, JCCBPCLKPNF> KOAPKECCHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x59B1100", Offset = "0x59B0500", VA = "0x1859B1100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x59B1060", Offset = "0x59B0460", VA = "0x1859B1060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x59B1480", Offset = "0x59B0880", VA = "0x1859B1480")]
	public FLOJPAMKKDO(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x59B11A0", Offset = "0x59B05A0", VA = "0x1859B11A0", Slot = "8")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x59B0E70", Offset = "0x59B0270", VA = "0x1859B0E70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x59B0EC0", Offset = "0x59B02C0", VA = "0x1859B0EC0", Slot = "11")]
	private void EOONMFJEDIO(JCCBPCLKPNF NOHEHILFFFE, JCCBPCLKPNF BMNLJMGMOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "12")]
	private void KFPECLOMAOK(bool FJINNNNEOHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class EELAFDHGBAJ : EJECMIKAEFE, KMDNIJEJNBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PhotonView JDECFKODFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool GLKLKGICMCI;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PhotonView OKCLDFPFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool KMBEOGBGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x59AD9B0", Offset = "0x59ACDB0", VA = "0x1859AD9B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool JHELJEMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ABKBPFMJPBP IJABNKFJANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x59ACFC0", Offset = "0x59AC3C0", VA = "0x1859ACFC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x59AD060", Offset = "0x59AC460", VA = "0x1859AD060", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x59ADB20", Offset = "0x59ACF20", VA = "0x1859ADB20")]
	public EELAFDHGBAJ(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x59AD9D0", Offset = "0x59ACDD0", VA = "0x1859AD9D0", Slot = "9")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x59ACEB0", Offset = "0x59AC2B0", VA = "0x1859ACEB0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x59AD520", Offset = "0x59AC920", VA = "0x1859AD520", Slot = "10")]
	public void MBNODPMJKAO(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x59AD100", Offset = "0x59AC500", VA = "0x1859AD100", Slot = "11")]
	public void JPNNLJAEKJC(EAHCLCDMENH ILDFJHMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x59AD830", Offset = "0x59ACC30", VA = "0x1859AD830")]
	private void OHINHJPFKFI(PhotonView DBKMCOAAEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x59AD6B0", Offset = "0x59ACAB0", VA = "0x1859AD6B0")]
	private void MEKLAGNOKHP(RigidbodyEx PLHHGAJBDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x59AD290", Offset = "0x59AC690", VA = "0x1859AD290")]
	private void KBDOFCKCNAF(PhotonView AIOGCLCJMKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal static class KFDPDEAIGDP
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x59B3950", Offset = "0x59B2D50", VA = "0x1859B3950")]
	public static EJECMIKAEFE PBEFJDJDDEC(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LGPEBNDLOPE : LBENAEPJLBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly LMDJEEFCDOJ BIPAKGEMKKA;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x59A5E40", Offset = "0x59A5240", VA = "0x1859A5E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool NDDLNIJEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xC2E720", Offset = "0xC2DB20", VA = "0x180C2E720", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x59BA960", Offset = "0x59B9D60", VA = "0x1859BA960")]
	public LGPEBNDLOPE(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x59BA8B0", Offset = "0x59B9CB0", VA = "0x1859BA8B0", Slot = "5")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x59B9970", Offset = "0x59B8D70", VA = "0x1859B9970", Slot = "7")]
	public void FOEDBBCKFAI(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x59B99A0", Offset = "0x59B8DA0", VA = "0x1859B99A0", Slot = "8")]
	public void GNGBJDCLCGN(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x59BA550", Offset = "0x59B9950", VA = "0x1859BA550", Slot = "9")]
	public void PODMBMBFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x59BA1D0", Offset = "0x59B95D0", VA = "0x1859BA1D0", Slot = "11")]
	public void MOFCAKPKPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x59BA3D0", Offset = "0x59B97D0", VA = "0x1859BA3D0", Slot = "12")]
	public void ODKMHFDBDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x59B99D0", Offset = "0x59B8DD0", VA = "0x1859B99D0", Slot = "10")]
	public void IMJGGFDFKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x59B9E70", Offset = "0x59B9270", VA = "0x1859B9E70")]
	private void LAAPELNMCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x59BA020", Offset = "0x59B9420", VA = "0x1859BA020")]
	private void LIHHCGEHHFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class MPGKAFODKDA : LBLOJOEPDDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private RigidbodyConstraints JKGGBHCJEBE;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool GJCJNFANJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xFBB500", Offset = "0xFBA900", VA = "0x180FBB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1F61690", Offset = "0x1F60A90", VA = "0x181F61690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool GFICPLAOLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1F616B0", Offset = "0x1F60AB0", VA = "0x181F616B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1F616A0", Offset = "0x1F60AA0", VA = "0x181F616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public RigidbodyConstraints LPEGCPLAALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x59C3670", Offset = "0x59C2A70", VA = "0x1859C3670", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x59C37B0", Offset = "0x59C2BB0", VA = "0x1859C37B0")]
	public MPGKAFODKDA(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x59C3640", Offset = "0x59C2A40", VA = "0x1859C3640", Slot = "9")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x59C3610", Offset = "0x59C2A10", VA = "0x1859C3610", Slot = "10")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class BCMGNBPEJCN : KADBGOOJEOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DF0", Offset = "0x59A51F0", VA = "0x1859A5DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x59A5E40", Offset = "0x59A5240", VA = "0x1859A5E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x59A5580", Offset = "0x59A4980", VA = "0x1859A5580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x59A5EA0", Offset = "0x59A52A0", VA = "0x1859A5EA0")]
	public BCMGNBPEJCN(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x59A5C40", Offset = "0x59A5040", VA = "0x1859A5C40", Slot = "4")]
	public void ICOGJOLMCIF(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x59A5860", Offset = "0x59A4C60", VA = "0x1859A5860")]
	private void HEBKDFHHOJG(Vector3 FCCLLNHHFFA, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x59A5060", Offset = "0x59A4460", VA = "0x1859A5060", Slot = "5")]
	public void AEOGCDFBPKE(Vector3 FCCLLNHHFFA, Vector3 OMFIFBMFGMG, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x59A5AE0", Offset = "0x59A4EE0", VA = "0x1859A5AE0", Slot = "6")]
	public void HEHKKKAPLGA(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x59A5300", Offset = "0x59A4700", VA = "0x1859A5300")]
	private void DDLKGKLCOHK(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x59A55E0", Offset = "0x59A49E0", VA = "0x1859A55E0", Slot = "7")]
	public void GGINNKHOJNL(Vector3 CNCCBNNCONB, ForceMode GFBPKEKEDGN = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DENJGEFMJCE : AFJKGNOABEG, GIHANPIMODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly JIEMGALBLIM<EAHCLCDMENH> CDKLHOODPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool OCMHHFEJPAC;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public JIEMGALBLIM<EAHCLCDMENH> BONKPMHELMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 FEKBDILDBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x59A9DE0", Offset = "0x59A91E0", VA = "0x1859A9DE0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 DKPMBAOOMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x59A97F0", Offset = "0x59A8BF0", VA = "0x1859A97F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x59A9600", Offset = "0x59A8A00", VA = "0x1859A9600")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public EAHCLCDMENH PICDHIIIKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x59A9740", Offset = "0x59A8B40", VA = "0x1859A9740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x59AA140", Offset = "0x59A9540", VA = "0x1859AA140")]
	public DENJGEFMJCE(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x59A99C0", Offset = "0x59A8DC0", VA = "0x1859A99C0", Slot = "8")]
	public void LMANKEHBFOH(EAHCLCDMENH ILDFJHMNOPJ, object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x59A96E0", Offset = "0x59A8AE0", VA = "0x1859A96E0", Slot = "9")]
	public void FJIAHIOLIEL(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x59A9E10", Offset = "0x59A9210", VA = "0x1859A9E10")]
	private Vector3 PEHDKDDCJHK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x59A9A30", Offset = "0x59A8E30", VA = "0x1859A9A30")]
	private void ONBPFCJECPB(EAHCLCDMENH PPHGILJIHFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class LCDFODDAPMM
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x59B8A80", Offset = "0x59B7E80", VA = "0x1859B8A80")]
	public static AFJKGNOABEG JDNCCJBJONI(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class CANHLLDGOAJ : IJEPMFEAOBO, GPOBHMGKMJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OverridableVector3 NCNEIKFOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OverridableVector3 FCMNAMHJMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float IJHDENPEBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float GAENOBMELFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Vector3 IEBODNINOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Vector3? KOKGDFJBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Quaternion? IKAACEJABCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool MLCILJFFOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool GGBOFHCMMBC;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 MMCCDHIMCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5C80", Offset = "0x1BE5080", VA = "0x181BE5C80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x59A83D0", Offset = "0x59A77D0", VA = "0x1859A83D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 DIFKKFEKEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x59A8620", Offset = "0x59A7A20", VA = "0x1859A8620", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float EBIMPOLOLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xCF9D40", Offset = "0xCF9140", VA = "0x180CF9D40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x59A7630", Offset = "0x59A6A30", VA = "0x1859A7630")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float KALJMBMLCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xB56C80", Offset = "0xB56080", VA = "0x180B56C80", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x59A8520", Offset = "0x59A7920", VA = "0x1859A8520", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 EDBAIBKPLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x59A61C0", Offset = "0x59A55C0", VA = "0x1859A61C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Quaternion GKGOMHPKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x59A87D0", Offset = "0x59A7BD0", VA = "0x1859A87D0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x59A85D0", Offset = "0x59A79D0", VA = "0x1859A85D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ABKBPFMJPBP OPIECLHNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x59A8480", Offset = "0x59A7880", VA = "0x1859A8480", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x59A8730", Offset = "0x59A7B30", VA = "0x1859A8730", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x59A8940", Offset = "0x59A7D40", VA = "0x1859A8940")]
	public CANHLLDGOAJ(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x59A8200", Offset = "0x59A7600", VA = "0x1859A8200", Slot = "17")]
	public void IANILGHLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x59A5F30", Offset = "0x59A5330", VA = "0x1859A5F30", Slot = "16")]
	public void AFKHDNAIDMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x59A7EE0", Offset = "0x59A72E0", VA = "0x1859A7EE0", Slot = "19")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x59A6330", Offset = "0x59A5730", VA = "0x1859A6330", Slot = "20")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x59A78C0", Offset = "0x59A6CC0", VA = "0x1859A78C0", Slot = "18")]
	public void FIJLCNFMINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x59A7A20", Offset = "0x59A6E20", VA = "0x1859A7A20", Slot = "21")]
	public void GACDEFCAIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x59A83D0", Offset = "0x59A77D0", VA = "0x1859A83D0")]
	private void OBKDGNJGCDI(Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x59A7520", Offset = "0x59A6920", VA = "0x1859A7520")]
	[Obsolete]
	private Vector3 ELAMACFNEFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x59A7630", Offset = "0x59A6A30", VA = "0x1859A7630")]
	private void FDHNILNKNJL(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x59A8520", Offset = "0x59A7920", VA = "0x1859A8520")]
	private void JENCFFBEKON(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x59A6050", Offset = "0x59A5450", VA = "0x1859A6050")]
	private Vector3 ALNJEBKKIKC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x59A7FC0", Offset = "0x59A73C0", VA = "0x1859A7FC0", Slot = "15")]
	public void HKPCMEKJGIO((Quaternion rot, Vector3 moments) KKLEBPJFJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x59A7750", Offset = "0x59A6B50", VA = "0x1859A7750")]
	private Quaternion FHGEAIHNDOJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x59A6580", Offset = "0x59A5980", VA = "0x1859A6580")]
	public void DHEKLBGCINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x59A6660", Offset = "0x59A5A60", VA = "0x1859A6660", Slot = "4")]
	public (float, Vector3) DHEKLBGCINI(Rigidbody AGJLJDEIJBN)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class JKFGMKNPKIP
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x59B37F0", Offset = "0x59B2BF0", VA = "0x1859B37F0")]
	public static IJEPMFEAOBO JKFEOOIKLFG(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface AFJKGNOABEG : GIHANPIMODL
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	JIEMGALBLIM<EAHCLCDMENH> BONKPMHELMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	EAHCLCDMENH PICDHIIIKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class PKDGDPMBHIM : NLMOECEILLG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LMDJEEFCDOJ PDCANCIPJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float LCOFKBFBENG;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public CKJAHABHLOJ PEKJBPIFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F3120", Offset = "0x7F2520", VA = "0x1807F3120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public BJHOFABHIPO PPBCHFPJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 HCKHHCMAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4BA40", Offset = "0x6E4AE40", VA = "0x186E4BA40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E4D100", Offset = "0x6E4C500", VA = "0x186E4D100", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 JGOAIDMBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E4CD50", Offset = "0x6E4C150", VA = "0x186E4CD50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B8A0", Offset = "0x6E4ACA0", VA = "0x186E4B8A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 GMLNOOCBNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E4C1C0", Offset = "0x6E4B5C0", VA = "0x186E4C1C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E4BB20", Offset = "0x6E4AF20", VA = "0x186E4BB20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 KGHEKPCCNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4CC90", Offset = "0x6E4C090", VA = "0x186E4CC90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E4C190", Offset = "0x6E4B590", VA = "0x186E4C190", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float HLEBFPJBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x940BD0", Offset = "0x93FFD0", VA = "0x180940BD0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E4B980", Offset = "0x6E4AD80", VA = "0x186E4B980", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool HHKAMPHDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF70", Offset = "0x9BC370", VA = "0x1809BCF70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private KADBGOOJEOK GBELGBHNPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x214ECF0", Offset = "0x214E0F0", VA = "0x18214ECF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private bool DIGMNPKCMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x59B5160", Offset = "0x59B4560", VA = "0x1859B5160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E0F0", Offset = "0x6E4D4F0", VA = "0x186E4E0F0")]
	public PKDGDPMBHIM(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B910", Offset = "0x6E4AD10", VA = "0x186E4B910", Slot = "19")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BEC0", Offset = "0x6E4B2C0", VA = "0x186E4BEC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C300", Offset = "0x6E4B700", VA = "0x186E4C300", Slot = "28")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x9BCBE0", Offset = "0x9BBFE0", VA = "0x1809BCBE0", Slot = "20")]
	public void NJGMCFMDMDK(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x9BC360", Offset = "0x9BB760", VA = "0x1809BC360", Slot = "30")]
	public void OJHNDODACGE(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BD50", Offset = "0x6E4B150", VA = "0x186E4BD50", Slot = "35")]
	public Vector3 DFFPMBMICON(Vector3 DLEGEFCLFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D3F0", Offset = "0x6E4C7F0", VA = "0x186E4D3F0", Slot = "34")]
	public Vector3 LPEMFNIEBCA(Vector3 BGOLDLKKMLJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B910", Offset = "0x6E4AD10", VA = "0x186E4B910", Slot = "27")]
	public void AMOGEPNPKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B8D0", Offset = "0x6E4ACD0", VA = "0x186E4B8D0", Slot = "25")]
	public void ADOFMEEMJHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D6D0", Offset = "0x6E4CAD0", VA = "0x186E4D6D0", Slot = "24")]
	public void MIEKIDJHBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D530", Offset = "0x6E4C930", VA = "0x186E4D530", Slot = "33")]
	public void MGGPJFDCCPI(Vector3 PJKIPFKMMEP, Vector3 LBHCPEIAPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C2A0", Offset = "0x6E4B6A0", VA = "0x186E4C2A0", Slot = "32")]
	public void GKDAKABEGFK(Vector3 JMBFKAOIALI, Vector3 FFBOOOFJHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BBE0", Offset = "0x6E4AFE0", VA = "0x186E4BBE0", Slot = "31")]
	public void CFIPFHBDHAN(Vector3 PGAMLAKLFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D710", Offset = "0x6E4CB10", VA = "0x186E4D710", Slot = "22")]
	public void NMPJCBJOGAO(JLBDMCGEPFC ONIAJAOPDCJ, Vector3 GAMCDHDDFEM, float FAAOBAKICCM, float HBLDBKIGDMA = 8f, float NHNKGENPFBL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DBC0", Offset = "0x6E4CFC0", VA = "0x186E4DBC0", Slot = "21")]
	public void ONNLOOIDBIF(LOHJNOKMBFM BCOKIHCMLBM, Vector3 NBGGCFEJDBP, float PGJJMKJMOBJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DDF0", Offset = "0x6E4D1F0", VA = "0x186E4DDF0", Slot = "23")]
	[Obsolete]
	public void PAPNLOIPNIK(LOHJNOKMBFM BCOKIHCMLBM, Vector3 PFHPGOOLCFP, float MLFALKJHFKE = 7f, float HEJLLLGKALE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D1C0", Offset = "0x6E4C5C0", VA = "0x186E4D1C0", Slot = "29")]
	public Vector3 KGFOHHPIBKL(Vector3 CPDGHJJAFAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C0A0", Offset = "0x6E4B4A0", VA = "0x186E4C0A0", Slot = "26")]
	public void EPOHAHFFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B980", Offset = "0x6E4AD80", VA = "0x186E4B980")]
	private void BHBJAIOINPH(float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D280", Offset = "0x6E4C680", VA = "0x186E4D280")]
	private void LKDFNPNMIEM(Vector3 NBGGCFEJDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BF20", Offset = "0x6E4B320", VA = "0x186E4BF20")]
	private Vector3 ECMFDAFPGOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CE10", Offset = "0x6E4C210", VA = "0x186E4CE10")]
	private void JLAJFHAPNAN(Vector3 BGOLDLKKMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CBD0", Offset = "0x6E4BFD0", VA = "0x186E4CBD0")]
	private Vector3 IOHDKLJLHFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C3D0", Offset = "0x6E4B7D0", VA = "0x186E4C3D0")]
	private void HOJCMIAJBGA(Vector3 KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C6E0", Offset = "0x6E4BAE0", VA = "0x186E4C6E0")]
	private void ILKCHJKACJK(Vector3 BGOLDLKKMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BFE0", Offset = "0x6E4B3E0", VA = "0x186E4BFE0")]
	private void EMGBOBOHMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class MEIDCIAFGED : DIFPEGGHMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly LMDJEEFCDOJ PKJGGFCLIPK;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool KHECNLMGIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x59C0CF0", Offset = "0x59C00F0", VA = "0x1859C0CF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ABKBPFMJPBP KBIHLCENPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x59C0B60", Offset = "0x59BFF60", VA = "0x1859C0B60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x59C0A80", Offset = "0x59BFE80", VA = "0x1859C0A80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x59C0DC0", Offset = "0x59C01C0", VA = "0x1859C0DC0")]
	public MEIDCIAFGED(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x59C0C90", Offset = "0x59C0090", VA = "0x1859C0C90", Slot = "11")]
	public IDisposable JOJJOHNBPBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x59C0C80", Offset = "0x59C0080", VA = "0x1859C0C80", Slot = "8")]
	public void IPEGEGKFAIF(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x59C0B20", Offset = "0x59BFF20", VA = "0x1859C0B20", Slot = "9")]
	public void CGABPKKHALD(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x59C0980", Offset = "0x59BFD80", VA = "0x1859C0980", Slot = "10")]
	public void BJIBFMGFGPF(object GAOLOMEJCOK, bool OLBFAGCJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x59C0940", Offset = "0x59BFD40", VA = "0x1859C0940", Slot = "6")]
	public void AGBEIPBBBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x59C0C00", Offset = "0x59C0000", VA = "0x1859C0C00", Slot = "12")]
	public void HFEDNFBGKEI(Rigidbody HCHEOFCJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x59C0B30", Offset = "0x59BFF30", VA = "0x1859C0B30", Slot = "13")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal sealed class LPIEOLFJFJM : NLLPDNBDLAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CollisionDetectionMode FLKFFLLKHDE;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x59A5DA0", Offset = "0x59A51A0", VA = "0x1859A5DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CollisionDetectionMode CAJCIOKNAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x59BF9C0", Offset = "0x59BEDC0", VA = "0x1859BF9C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x59BFAD0", Offset = "0x59BEED0", VA = "0x1859BFAD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x59A5EA0", Offset = "0x59A52A0", VA = "0x1859A5EA0")]
	public LPIEOLFJFJM(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x59BFCC0", Offset = "0x59BF0C0", VA = "0x1859BFCC0", Slot = "6")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x59BF940", Offset = "0x59BED40", VA = "0x1859BF940", Slot = "9")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x59BF800", Offset = "0x59BEC00", VA = "0x1859BF800", Slot = "7")]
	public void DGFGECMKBOI(bool NDMAAJEOGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x59BFCB0", Offset = "0x59BF0B0", VA = "0x1859BFCB0", Slot = "8")]
	public void POLOMBPGGEK(bool NDMAAJEOGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x59BFB40", Offset = "0x59BEF40", VA = "0x1859BFB40", Slot = "10")]
	public bool JOPHHLLOFKI(Vector3 KDLMOBCGODE, out RaycastHit KGPALFLMPAN, float AMDMMLBNHAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x59BF810", Offset = "0x59BEC10", VA = "0x1859BF810")]
	private void EPMMHMHCJEJ(bool NDMAAJEOGII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GHNFGGGDFKE : MCIKANEBNMG
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x59B24E0", Offset = "0x59B18E0", VA = "0x1859B24E0", Slot = "4")]
	public NGDGBGPMNDG DNMHDDBILFO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x59B2820", Offset = "0x59B1C20", VA = "0x1859B2820", Slot = "5")]
	public NLMOECEILLG HAHHPANPKEF(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x59B2940", Offset = "0x59B1D40", VA = "0x1859B2940", Slot = "6")]
	public GIHANPIMODL IFJFOOPBCIG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x59B23C0", Offset = "0x59B17C0", VA = "0x1859B23C0", Slot = "7")]
	public IFAGKIJIHAD DGMODLBACCJ(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x59B22E0", Offset = "0x59B16E0", VA = "0x1859B22E0", Slot = "8")]
	public BLLOODMDKJF COJJGOJLGFB(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x59B2880", Offset = "0x59B1C80", VA = "0x1859B2880", Slot = "9")]
	public BLBLCFEJOBG HOCKFGNGOCH(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x59B2A60", Offset = "0x59B1E60", VA = "0x1859B2A60", Slot = "10")]
	public DIFPEGGHMMK JJPGFMHCBPI(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x59B2430", Offset = "0x59B1830", VA = "0x1859B2430", Slot = "11")]
	public KADBGOOJEOK DNLPLFMNDAO(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x59B2D50", Offset = "0x59B2150", VA = "0x1859B2D50", Slot = "12")]
	public NLLPDNBDLAA MOCJAKNHGGG(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x59B2E00", Offset = "0x59B2200", VA = "0x1859B2E00", Slot = "13")]
	public LAPMGAFDIDC NPHPHMDHGBA(EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x59B25D0", Offset = "0x59B19D0", VA = "0x1859B25D0")]
	public LBENAEPJLBH LBGFONNAIPO(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x59B2160", Offset = "0x59B1560", VA = "0x1859B2160")]
	public KMDNIJEJNBK AEPBLKBIPLF(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x59B2C30", Offset = "0x59B2030", VA = "0x1859B2C30")]
	public NBBLFILMLJG KBLELAONPDA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x59B26F0", Offset = "0x59B1AF0", VA = "0x1859B26F0")]
	public GPOBHMGKMJL LGMJPCAEIDD(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x59B2B60", Offset = "0x59B1F60", VA = "0x1859B2B60")]
	public LBLOJOEPDDJ JOIFNHKACNI(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x59B2230", Offset = "0x59B1630", VA = "0x1859B2230", Slot = "19")]
	public EAHCLCDMENH BMPKMIFFNGN(RigidbodyEx LJACJOOEGHH, OKDLMPEGAOG KJFNAECAHBA, BCPFDHDHBHN MLODHIKJENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public GHNFGGGDFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x59B25D0", Offset = "0x59B19D0", VA = "0x1859B25D0", Slot = "14")]
	private LBENAEPJLBH FBBCIKFKOKP(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x59B2160", Offset = "0x59B1560", VA = "0x1859B2160", Slot = "15")]
	private KMDNIJEJNBK IMIEIJIOMGE(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x59B2C30", Offset = "0x59B2030", VA = "0x1859B2C30", Slot = "16")]
	private NBBLFILMLJG OBGDPJFNKHG(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x59B26F0", Offset = "0x59B1AF0", VA = "0x1859B26F0", Slot = "17")]
	private GPOBHMGKMJL FFMKOLPLCAA(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x59B2B60", Offset = "0x59B1F60", VA = "0x1859B2B60", Slot = "18")]
	private LBLOJOEPDDJ MBELMNKDLEL(EAHCLCDMENH LCKHNIKLMMC, in OKDLMPEGAOG KJFNAECAHBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class EKJDAJPMKDF : KLNDBCEGEKP, NGDGBGPMNDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly EAHCLCDMENH LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<EAHCLCDMENH> CIHGKBGGPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private EAHCLCDMENH COMCNEGAGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private EAHCLCDMENH ILDFJHMNOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform CMCHINKGAPD;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Transform GOPDKEIBKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x59AEFA0", Offset = "0x59AE3A0", VA = "0x1859AEFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x59AEF90", Offset = "0x59AE390", VA = "0x1859AEF90", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public EAHCLCDMENH KABGFLLOEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IReadOnlyList<EAHCLCDMENH> ALPIHCDGAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event ABKBPFMJPBP OCMEHKGHOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x59AF740", Offset = "0x59AEB40", VA = "0x1859AF740", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x59AFD80", Offset = "0x59AF180", VA = "0x1859AFD80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event ABKBPFMJPBP GDCCEAOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x59AF880", Offset = "0x59AEC80", VA = "0x1859AF880", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x59AF430", Offset = "0x59AE830", VA = "0x1859AF430", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event GPFPGDKFNGA FDBHKJAPMML
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x59AEEF0", Offset = "0x59AE2F0", VA = "0x1859AEEF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x59AFB50", Offset = "0x59AEF50", VA = "0x1859AFB50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action IOKKCNKMBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x59AE240", Offset = "0x59AD640", VA = "0x1859AE240", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x59AE370", Offset = "0x59AD770", VA = "0x1859AE370", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action CNKIMCMFKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x59AE660", Offset = "0x59ADA60", VA = "0x1859AE660", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x59AF130", Offset = "0x59AE530", VA = "0x1859AF130", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<EAHCLCDMENH> IOKJLMPMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x59AEC90", Offset = "0x59AE090", VA = "0x1859AEC90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x59AF570", Offset = "0x59AE970", VA = "0x1859AF570", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<EAHCLCDMENH> HDNMOMGDEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x59AF920", Offset = "0x59AED20", VA = "0x1859AF920", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x59AFAB0", Offset = "0x59AEEB0", VA = "0x1859AFAB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action JJDNGEBPMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x59AE5C0", Offset = "0x59AD9C0", VA = "0x1859AE5C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x59AF7E0", Offset = "0x59AEBE0", VA = "0x1859AF7E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<EAHCLCDMENH> DBCLHMMPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x59AF1D0", Offset = "0x59AE5D0", VA = "0x1859AF1D0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x59AED30", Offset = "0x59AE130", VA = "0x1859AED30", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x59AFE20", Offset = "0x59AF220", VA = "0x1859AFE20")]
	public EKJDAJPMKDF(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x59AEE70", Offset = "0x59AE270", VA = "0x1859AEE70", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x59AE700", Offset = "0x59ADB00", VA = "0x1859AE700", Slot = "30")]
	public void CIGBDIGMBAB(EAHCLCDMENH GHLIBENNEBB, bool GPCIIKMAAIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x59AE410", Offset = "0x59AD810", VA = "0x1859AE410", Slot = "6")]
	public void BOOBLANHJJF(EAHCLCDMENH NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x59AF270", Offset = "0x59AE670", VA = "0x1859AF270", Slot = "7")]
	public void IIIOMNJBEPA(EAHCLCDMENH NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x59AEDD0", Offset = "0x59AE1D0", VA = "0x1859AEDD0", Slot = "4")]
	public void DHPKFCEIGDC(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x59AF4D0", Offset = "0x59AE8D0", VA = "0x1859AF4D0", Slot = "5")]
	public void JGCNEKOCFFL(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x59AE2E0", Offset = "0x59AD6E0", VA = "0x1859AE2E0")]
	private void BKFOCEPJGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x59AFBF0", Offset = "0x59AEFF0", VA = "0x1859AFBF0")]
	private void ONKICCKEALM(EAHCLCDMENH NAJKEMDIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x59AFC30", Offset = "0x59AF030", VA = "0x1859AFC30")]
	private void PCHKLPKJHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x59AF000", Offset = "0x59AE400", VA = "0x1859AF000")]
	private void FGDHMLIDGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x59AF610", Offset = "0x59AEA10", VA = "0x1859AF610")]
	private void KAPMOHBIDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x59AF9C0", Offset = "0x59AEDC0", VA = "0x1859AF9C0")]
	[CompilerGenerated]
	private object MJODLCOMOAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal static class OMEBFFOHJPH
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B820", Offset = "0x6E4AC20", VA = "0x186E4B820")]
	public static KLNDBCEGEKP HIGPLAHDIIH(this EAHCLCDMENH LCKHNIKLMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class OFPCGGAOIND : NBBLFILMLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly LMDJEEFCDOJ HFIOKAFFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BFEGGBIPHDI MCKIFIEILPL;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool KFBBINHOBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xC2E720", Offset = "0xC2DB20", VA = "0x180C2E720", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public BFEGGBIPHDI LGEBLOBJMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "11")]
		get
		{
			return default(BFEGGBIPHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x59C4730", Offset = "0x59C3B30", VA = "0x1859C4730")]
	public OFPCGGAOIND(EAHCLCDMENH LJACJOOEGHH, in OKDLMPEGAOG KJFNAECAHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x59C4660", Offset = "0x59C3A60", VA = "0x1859C4660", Slot = "4")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x59C4160", Offset = "0x59C3560", VA = "0x1859C4160")]
	private bool CEGKJJKNDNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x59C44B0", Offset = "0x59C38B0", VA = "0x1859C44B0", Slot = "5")]
	public void GGFDFEJJGCB(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x59C4630", Offset = "0x59C3A30", VA = "0x1859C4630", Slot = "6")]
	public void NMLEAJNOELO(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x59C4200", Offset = "0x59C3600", VA = "0x1859C4200", Slot = "9")]
	public void FFPENNDCBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x59C44E0", Offset = "0x59C38E0", VA = "0x1859C44E0")]
	private void GNNMACLDFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x59C4330", Offset = "0x59C3730", VA = "0x1859C4330")]
	private void GELMNFDDDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x59C4120", Offset = "0x59C3520", VA = "0x1859C4120", Slot = "8")]
	public void AIBFOBAFNNP(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x59C45F0", Offset = "0x59C39F0", VA = "0x1859C45F0", Slot = "7")]
	public void LHEHOMOIPOM(EAHCLCDMENH LJACJOOEGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface IJEPMFEAOBO : GPOBHMGKMJL
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DHEKLBGCINI(Rigidbody AGJLJDEIJBN);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface KLNDBCEGEKP : NGDGBGPMNDG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHPKFCEIGDC(EAHCLCDMENH LJACJOOEGHH);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGCNEKOCFFL(EAHCLCDMENH LJACJOOEGHH);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOOBLANHJJF(EAHCLCDMENH NAJKEMDIEIE);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IIIOMNJBEPA(EAHCLCDMENH NAJKEMDIEIE);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class EFNCNEHMJGG : LAPMGAFDIDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool PDLAIGCKACG;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool NOLEDMNHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x59ADBF0", Offset = "0x59ACFF0", VA = "0x1859ADBF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x59ADD00", Offset = "0x59AD100", VA = "0x1859ADD00")]
	public EFNCNEHMJGG(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x59ADBC0", Offset = "0x59ACFC0", VA = "0x1859ADBC0", Slot = "6")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x599E800", Offset = "0x599DC00", VA = "0x18599E800", Slot = "7")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class MFDIDBJPELB : BLLOODMDKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly AFAOFDBMCDE LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool BNJEHIHNMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool IGLFEICNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int GMMFAMNGGHK;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private Rigidbody ANHFJLADDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x59A85D0", Offset = "0x59A79D0", VA = "0x1859A85D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private bool DIGMNPKCMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x59C1060", Offset = "0x59C0460", VA = "0x1859C1060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EAHCLCDMENH CECPGAGDNBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x59C0EA0", Offset = "0x59C02A0", VA = "0x1859C0EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool ICNFEAKJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x59C12A0", Offset = "0x59C06A0", VA = "0x1859C12A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ABKBPFMJPBP OCPDCNELHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x59C1160", Offset = "0x59C0560", VA = "0x1859C1160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x59C1680", Offset = "0x59C0A80", VA = "0x1859C1680", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x59C1950", Offset = "0x59C0D50", VA = "0x1859C1950")]
	public MFDIDBJPELB(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x59C18B0", Offset = "0x59C0CB0", VA = "0x1859C18B0", Slot = "6")]
	public void PPANCNBNGPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x59C1300", Offset = "0x59C0700", VA = "0x1859C1300", Slot = "8")]
	public void OANFHLODHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x59C0F00", Offset = "0x59C0300", VA = "0x1859C0F00", Slot = "7")]
	public bool FJPDMKBDPKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x59C10C0", Offset = "0x59C04C0", VA = "0x1859C10C0", Slot = "9")]
	public void IKBHHOGFNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x59C1200", Offset = "0x59C0600", VA = "0x1859C1200", Slot = "11")]
	public void MANGGEGDHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x59C1080", Offset = "0x59C0480", VA = "0x1859C1080", Slot = "12")]
	public void IFCKMHMOBIO(bool KLOFHCIIDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x59C1310", Offset = "0x59C0710", VA = "0x1859C1310", Slot = "10")]
	public void OOKNGPICNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x59C14C0", Offset = "0x59C08C0", VA = "0x1859C14C0")]
	private bool OPECKCIBJAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x59C1720", Offset = "0x59C0B20", VA = "0x1859C1720")]
	private void POCCACEIIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class ICKAAPHJIPP : IFAGKIJIHAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EAHCLCDMENH LJACJOOEGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float FENJALIMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private float KCMLGKKALGC;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float MCHFLOGFMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9CDAA0", Offset = "0x9CCEA0", VA = "0x1809CDAA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x59B3460", Offset = "0x59B2860", VA = "0x1859B3460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float BEGANPJFHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x94EDA0", Offset = "0x94E1A0", VA = "0x18094EDA0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x59B3580", Offset = "0x59B2980", VA = "0x1859B3580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x59B3650", Offset = "0x59B2A50", VA = "0x1859B3650")]
	public ICKAAPHJIPP(EAHCLCDMENH LJACJOOEGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x59B3530", Offset = "0x59B2930", VA = "0x1859B3530", Slot = "8")]
	public void HFEDNFBGKEI(Rigidbody GICHLCJAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x59B33C0", Offset = "0x59B27C0", VA = "0x1859B33C0", Slot = "9")]
	public void DALFAPDLNEA(Rigidbody GICHLCJAAHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface EJECMIKAEFE : KMDNIJEJNBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PhotonView OKCLDFPFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DMCBJAFGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6E53680", Offset = "0x6E52A80", VA = "0x186E53680", Slot = "6")]
		public sealed override void LPGLFILFNHK(AOEKEIHNKAE GBCKPIBLKJM)
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
