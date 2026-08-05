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
		public static NJDLJLDNKHA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int HMNBNHPLDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int PEMLOBEDMFM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D991F0", Offset = "0x6D979F0", VA = "0x186D991F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D99230", Offset = "0x6D97A30", VA = "0x186D99230")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D99210", Offset = "0x6D97A10", VA = "0x186D99210")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string AKADEFDGONP, [Optional] UnityEngine.Object HNBDDLBIIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string AKADEFDGONP, [Optional] UnityEngine.Object HNBDDLBIIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D99320", Offset = "0x6D97B20", VA = "0x186D99320")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JOBOPALOCFG
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class EFDJLLDKJFG : GOEGIKJGDDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDCD1C0", Offset = "0xDCB9C0", VA = "0x180DCD1C0", Slot = "4")]
		public Vector3 FNCLHIKAKJP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDCD1C0", Offset = "0xDCB9C0", VA = "0x180DCD1C0", Slot = "5")]
		public Vector3 OMBLOOEPIKP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EFDJLLDKJFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GOEGIKJGDDB ICDMDJDGEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AE00", Offset = "0x5A39600", VA = "0x185A3AE00")]
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
		private static readonly JNGNMMOLKFF IEGJHNBFNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool EPCMNBEPEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private AKPAKEJMCNB HPKCFMILJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AHENNPNFFLM(OBCONDONEKN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[AHENNPNFFLM(OBCONDONEKN.SelfAndParent, true, false, false)]
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
		private JBGEEDNKLEH physicsInterpolation;

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
		internal AKPAKEJMCNB MOJFAFLNEFM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D99E20", Offset = "0x6D98620", VA = "0x186D99E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> LIHHNICJHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx ALLNGMDIDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BF90", Offset = "0x6D9A790", VA = "0x186D9BF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx AELGKCJPGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BF30", Offset = "0x6D9A730", VA = "0x186D9BF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GJPBCFJDGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CA80", Offset = "0x6D9B280", VA = "0x186D9CA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DF40", Offset = "0x6D9C740", VA = "0x186D9DF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform BFAFCBLHGCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBB70D0", Offset = "0xBB58D0", VA = "0x180BB70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform HNADCANFNEA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBB70D0", Offset = "0xBB58D0", VA = "0x180BB70D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DMDAFLHMPLA BLNAIHIKBIL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BC90", Offset = "0x6D9A490", VA = "0x186D9BC90")]
			get
			{
				return default(DMDAFLHMPLA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D6E0", Offset = "0x6D9BEE0", VA = "0x186D9D6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CHJBBOLJPBF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C190", Offset = "0x6D9A990", VA = "0x186D9C190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GKMPJAPBOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BE10", Offset = "0x6D9A610", VA = "0x186D9BE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GOEGIKJGDDB KNNIBJCFICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C0D0", Offset = "0x6D9A8D0", VA = "0x186D9C0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D8F0", Offset = "0x6D9C0F0", VA = "0x186D9D8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DLBCBPHCDEM JOALNHNOPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C070", Offset = "0x6D9A870", VA = "0x186D9C070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D880", Offset = "0x6D9C080", VA = "0x186D9D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HEOAKAHPFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BFC0", Offset = "0x6D9A7C0", VA = "0x186D9BFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody JIIBPHMGFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C020", Offset = "0x6D9A820", VA = "0x186D9C020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KDACLMIFKLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BE70", Offset = "0x6D9A670", VA = "0x186D9BE70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D7A0", Offset = "0x6D9BFA0", VA = "0x186D9D7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DKBJJEIFBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x15F5EC0", Offset = "0x15F46C0", VA = "0x1815F5EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2DCCFA0", Offset = "0x2DCB7A0", VA = "0x182DCCFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float IOJLBENOPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CA20", Offset = "0x6D9B220", VA = "0x186D9CA20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float OJBLBIFAIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C9C0", Offset = "0x6D9B1C0", VA = "0x186D9C9C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DED0", Offset = "0x6D9C6D0", VA = "0x186D9DED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float HJCLBHJHBFA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C3E0", Offset = "0x6D9ABE0", VA = "0x186D9C3E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DB80", Offset = "0x6D9C380", VA = "0x186D9DB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float CGJHCIBEHBB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C1F0", Offset = "0x6D9A9F0", VA = "0x186D9C1F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D960", Offset = "0x6D9C160", VA = "0x186D9D960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BJECCAMEEHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CF50", Offset = "0x6D9B750", VA = "0x186D9CF50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E430", Offset = "0x6D9CC30", VA = "0x186D9E430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 ELNDMEMCHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C7C0", Offset = "0x6D9AFC0", VA = "0x186D9C7C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DCC0", Offset = "0x6D9C4C0", VA = "0x186D9DCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 BHFPMLIEGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D080", Offset = "0x6D9B880", VA = "0x186D9D080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode GOLDAGJLMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C320", Offset = "0x6D9AB20", VA = "0x186D9C320")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DAA0", Offset = "0x6D9C2A0", VA = "0x186D9DAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float AHCJBMNCNNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BED0", Offset = "0x6D9A6D0", VA = "0x186D9BED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D810", Offset = "0x6D9C010", VA = "0x186D9D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints DCLENAIADPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C380", Offset = "0x6D9AB80", VA = "0x186D9C380")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DB10", Offset = "0x6D9C310", VA = "0x186D9DB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 POJIONIPHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CAE0", Offset = "0x6D9B2E0", VA = "0x186D9CAE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 HKJHMOFHGAF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CAE0", Offset = "0x6D9B2E0", VA = "0x186D9CAE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E220", Offset = "0x6D9CA20", VA = "0x186D9E220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float HHDKGMDEOLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C890", Offset = "0x6D9B090", VA = "0x186D9C890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DD90", Offset = "0x6D9C590", VA = "0x186D9DD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MFIGNEPFOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CEF0", Offset = "0x6D9B6F0", VA = "0x186D9CEF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E3C0", Offset = "0x6D9CBC0", VA = "0x186D9E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion PKBIMAMIMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CBB0", Offset = "0x6D9B3B0", VA = "0x186D9CBB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DFB0", Offset = "0x6D9C7B0", VA = "0x186D9DFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion OAMMHKOINLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CE20", Offset = "0x6D9B620", VA = "0x186D9CE20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E2F0", Offset = "0x6D9CAF0", VA = "0x186D9E2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DHIPIEPDPIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CC80", Offset = "0x6D9B480", VA = "0x186D9CC80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E080", Offset = "0x6D9C880", VA = "0x186D9E080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NNONIIOOJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CD50", Offset = "0x6D9B550", VA = "0x186D9CD50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E150", Offset = "0x6D9C950", VA = "0x186D9E150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 KFENDEDNACE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9CFB0", Offset = "0x6D9B7B0", VA = "0x186D9CFB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9E4A0", Offset = "0x6D9CCA0", VA = "0x186D9E4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PJDFDKKMIAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C8F0", Offset = "0x6D9B0F0", VA = "0x186D9C8F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DE00", Offset = "0x6D9C600", VA = "0x186D9DE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 ODPEGCEAOBB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C250", Offset = "0x6D9AA50", VA = "0x186D9C250")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D9D0", Offset = "0x6D9C1D0", VA = "0x186D9D9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BGCIGAGAEDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C6F0", Offset = "0x6D9AEF0", VA = "0x186D9C6F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6D9DBF0", Offset = "0x6D9C3F0", VA = "0x186D9DBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 IIFKPCGOIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C5C0", Offset = "0x6D9ADC0", VA = "0x186D9C5C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion JCNMPFHIMEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C4F0", Offset = "0x6D9ACF0", VA = "0x186D9C4F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LBLIMALICPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D220", Offset = "0x6D9BA20", VA = "0x186D9D220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HIFOCPOGJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D150", Offset = "0x6D9B950", VA = "0x186D9D150")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LJKNFCFGHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C690", Offset = "0x6D9AE90", VA = "0x186D9C690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool MNGOCFLODEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C130", Offset = "0x6D9A930", VA = "0x186D9C130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool MAFMNHOECEI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BDB0", Offset = "0x6D9A5B0", VA = "0x186D9BDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FFGMKNBJONO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BD50", Offset = "0x6D9A550", VA = "0x186D9BD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool GNLHFFBDGKP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BC30", Offset = "0x6D9A430", VA = "0x186D9BC30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PMDCIGDHEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9C440", Offset = "0x6D9AC40", VA = "0x186D9C440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CENAPLLCNNC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2EB36E0", Offset = "0x2EB1EE0", VA = "0x182EB36E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event BKKLCHMMMPO IKOMPCJBPCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BB50", Offset = "0x6D9A350", VA = "0x186D9BB50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D600", Offset = "0x6D9BE00", VA = "0x186D9D600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CPNLBCPAMIE IMJHECABFHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BAE0", Offset = "0x6D9A2E0", VA = "0x186D9BAE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D590", Offset = "0x6D9BD90", VA = "0x186D9D590")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event BKKLCHMMMPO HIAKNGJBCCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B840", Offset = "0x6D9A040", VA = "0x186D9B840")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D2F0", Offset = "0x6D9BAF0", VA = "0x186D9D2F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event BKKLCHMMMPO AMONPALDEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B8B0", Offset = "0x6D9A0B0", VA = "0x186D9B8B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D360", Offset = "0x6D9BB60", VA = "0x186D9D360")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event BKKLCHMMMPO AFNMNLNKLIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BA00", Offset = "0x6D9A200", VA = "0x186D9BA00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D4B0", Offset = "0x6D9BCB0", VA = "0x186D9D4B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B990", Offset = "0x6D9A190", VA = "0x186D9B990")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D440", Offset = "0x6D9BC40", VA = "0x186D9D440")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event BKKLCHMMMPO LHEMINCPAHL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BA70", Offset = "0x6D9A270", VA = "0x186D9BA70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D520", Offset = "0x6D9BD20", VA = "0x186D9D520")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event BKKLCHMMMPO FPJHKMDLHEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BBC0", Offset = "0x6D9A3C0", VA = "0x186D9BBC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D670", Offset = "0x6D9BE70", VA = "0x186D9D670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event BKKLCHMMMPO AJBELLAEFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B920", Offset = "0x6D9A120", VA = "0x186D9B920")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D3D0", Offset = "0x6D9BBD0", VA = "0x186D9D3D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		internal void CEHFOAGIHKC(AKPAKEJMCNB PBDNMEDOHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A310", Offset = "0x6D98B10", VA = "0x186D9A310")]
		internal void HALKMOHNGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B530", Offset = "0x6D99D30", VA = "0x186D9B530")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody FMDAJDAFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B1F0", Offset = "0x6D999F0", VA = "0x186D9B1F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CLIBLALIAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D99DB0", Offset = "0x6D985B0", VA = "0x186D99DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D99E20", Offset = "0x6D98620", VA = "0x186D99E20")]
		private AKPAKEJMCNB BKKAFNMOCAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A480", Offset = "0x6D98C80", VA = "0x186D9A480")]
		private void LDEGPCHGKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A9E0", Offset = "0x6D991E0", VA = "0x186D9A9E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A970", Offset = "0x6D99170", VA = "0x186D9A970")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A980", Offset = "0x6D99180", VA = "0x186D9A980")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AA40", Offset = "0x6D99240", VA = "0x186D9AA40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D99370", Offset = "0x6D97B70", VA = "0x186D99370")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AAB0", Offset = "0x6D992B0", VA = "0x186D9AAB0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A0B0", Offset = "0x6D988B0", VA = "0x186D9A0B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A910", Offset = "0x6D99110", VA = "0x186D9A910")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B350", Offset = "0x6D99B50", VA = "0x186D9B350")]
		public void SetParent(RigidbodyEx MENBIMCLIOI, bool JOHIKFAEACC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9ADB0", Offset = "0x6D995B0", VA = "0x186D9ADB0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A3A0", Offset = "0x6D98BA0", VA = "0x186D9A3A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx IJDDBMPJGDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A3E0", Offset = "0x6D98BE0", VA = "0x186D9A3E0")]
		public bool IsRigidbodyDescendant(RigidbodyEx LEMMIKBFPGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D995E0", Offset = "0x6D97DE0", VA = "0x186D995E0")]
		public void AddInterpolationRestriction(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AB20", Offset = "0x6D99320", VA = "0x186D9AB20")]
		public void RemoveInterpolationRestriction(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D99ED0", Offset = "0x6D986D0", VA = "0x186D99ED0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D99650", Offset = "0x6D97E50", VA = "0x186D99650")]
		public void AddKinematic(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AB90", Offset = "0x6D99390", VA = "0x186D9AB90")]
		public void RemoveKinematic(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B2D0", Offset = "0x6D99AD0", VA = "0x186D9B2D0")]
		public void SetKinematic(object AMCDGOPKAOE, bool KOHKILNBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B100", Offset = "0x6D99900", VA = "0x186D9B100")]
		public void SetDiscontinuousPositionAndRotation(Vector3 OCDLANKHJEL, Quaternion ONHAKCONDDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B010", Offset = "0x6D99810", VA = "0x186D9B010")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 OJECHCGNLLP, Quaternion NEPCPOJAKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A210", Offset = "0x6D98A10", VA = "0x186D9A210")]
		public Vector3 GetConstrainedVelocity(Vector3 KFENDEDNACE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A110", Offset = "0x6D98910", VA = "0x186D9A110")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 ODPEGCEAOBB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6D994F0", Offset = "0x6D97CF0", VA = "0x186D994F0")]
		public void AddForce(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D993E0", Offset = "0x6D97BE0", VA = "0x186D993E0")]
		public void AddForceAtPosition(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D99820", Offset = "0x6D98020", VA = "0x186D99820")]
		public void AddTorque(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D996C0", Offset = "0x6D97EC0", VA = "0x186D996C0")]
		public void AddRelativeTorque(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B610", Offset = "0x6D99E10", VA = "0x186D9B610")]
		public Vector3 WorldToLocalVelocity(Vector3 IKNBMJJLOME)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A810", Offset = "0x6D99010", VA = "0x186D9A810")]
		public Vector3 LocalToWorldVelocity(Vector3 PJDFDKKMIAH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A050", Offset = "0x6D98850", VA = "0x186D9A050")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D99FF0", Offset = "0x6D987F0", VA = "0x186D99FF0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D99F90", Offset = "0x6D98790", VA = "0x186D99F90")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D99F30", Offset = "0x6D98730", VA = "0x186D99F30")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AF10", Offset = "0x6D99710", VA = "0x186D9AF10")]
		public void ResetVelocityWorldSpace(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AE10", Offset = "0x6D99610", VA = "0x186D9AE10")]
		public void ResetVelocityLocalSpace(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D9ACE0", Offset = "0x6D994E0", VA = "0x186D9ACE0")]
		public void ResetLinearVelocityLocalSpace(Vector3 LNOCFHHMHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B440", Offset = "0x6D99C40", VA = "0x186D9B440")]
		public bool SweepTest(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D9A420", Offset = "0x6D98C20", VA = "0x186D9A420")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B3E0", Offset = "0x6D99BE0", VA = "0x186D9B3E0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B5B0", Offset = "0x6D99DB0", VA = "0x186D9B5B0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D997B0", Offset = "0x6D97FB0", VA = "0x186D997B0")]
		public void AddShouldHaveUnityRigidbodyToken(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AC00", Offset = "0x6D99400", VA = "0x186D9AC00")]
		public void RemoveShouldHaveUnityRigidbodyToken(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6D99BA0", Offset = "0x6D983A0", VA = "0x186D99BA0")]
		public void ApplyForceVelocityChange(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D99AB0", Offset = "0x6D982B0", VA = "0x186D99AB0")]
		public void ApplyAngularVelocityChange(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D99CB0", Offset = "0x6D984B0", VA = "0x186D99CB0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D999F0", Offset = "0x6D981F0", VA = "0x186D999F0")]
		public bool AllowedScaleChange(float IJICPBHJJLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D99910", Offset = "0x6D98110", VA = "0x186D99910")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LGKFEACNPCO, object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AC70", Offset = "0x6D99470", VA = "0x186D9AC70")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D9B7A0", Offset = "0x6D99FA0", VA = "0x186D9B7A0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class BOGPNBKBJNC
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B520", Offset = "0x5A19D20", VA = "0x185A1B520")]
	public static AKPAKEJMCNB MOJFAFLNEFM(this RigidbodyEx KLEOGNMJFCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BKKLCHMMMPO(RigidbodyEx KGIMHPNFCJK);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JBGEEDNKLEH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JFEEFBCBMJF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LPMCBAJFHEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Rigidbody GLNPLCBFALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public PhotonView DNKOGNNJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OverridableVector3 PIFGOLLJLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 NMPHIMCIEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JBGEEDNKLEH IBCDMIPMGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool KFLDHNBMCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool KOJOEKJAHGH;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CPNLBCPAMIE(RigidbodyEx KGIMHPNFCJK, bool JOHIKFAEACC = false);
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KHNAILLFHGJ(typeof(CCALBGNPAOK), new string[] { "Ignore", "Mock" })]
public class DFOCKKIAEAD : CCALBGNPAOK
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EDKPIAFEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x97D920", Offset = "0x97C120", VA = "0x18097D920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
	public void JIFAGCCPENF(string OABOGFOJNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void EGFGMKKHCEO(RigidbodyEx KLEOGNMJFCE, Action COPPLLLOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "7")]
	public GNNADOJEIPI AIBAFFDENOL(int EEHNLFMGGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
	public void MDDFKPHHDIO(Vector3 BHFPMLIEGNC, float EBPJLFDIABG, Color JIINIIPALJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public DFOCKKIAEAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KHNAILLFHGJ(typeof(JBIENGFNALE), new string[] { })]
public class MIFGGDFKECB : JBIENGFNALE, NOFCHOCEBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KANIKAONFJI JDHDNBAMDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private CCALBGNPAOK BOBHLPNKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LOJAGMFINDG FGCPBCFBMII;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CCALBGNPAOK BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LOJAGMFINDG MBIMOONHHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D95790", Offset = "0x6D93F90", VA = "0x186D95790", Slot = "10")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D954A0", Offset = "0x6D93CA0", VA = "0x186D954A0", Slot = "6")]
	public LPLJHAHPEEF GFGNIEEJMNC(RigidbodyEx KLEOGNMJFCE)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D95970", Offset = "0x6D94170", VA = "0x186D95970")]
	private static LPLJHAHPEEF MGLPOPFKDCJ(RigidbodyEx KLEOGNMJFCE)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D95390", Offset = "0x6D93B90", VA = "0x186D95390", Slot = "7")]
	public AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D952A0", Offset = "0x6D93AA0", VA = "0x186D952A0", Slot = "8")]
	public void CFHLEJKGPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D95820", Offset = "0x6D94020", VA = "0x186D95820", Slot = "9")]
	public void KIOMOLIAAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public MIFGGDFKECB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OPLIFJKHELG
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D98930", Offset = "0x6D97130", VA = "0x186D98930")]
	public static void FCHOIDFGJBK(this Rigidbody FMDAJDAFCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D98820", Offset = "0x6D97020", VA = "0x186D98820")]
	public static void FCHOIDFGJBK(this Rigidbody FMDAJDAFCNM, Vector3 CHPLFGACBBI, Quaternion JCNMPFHIMEO, Vector3 BLKBIIEKLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2592D70", Offset = "0x2591570", VA = "0x182592D70")]
	public static void NGIIGIPLGHC(Vector3 KFENDEDNACE, Vector3 LKJKFPNAKOC, out Vector3 PNBALGHEMOP, out Vector3 IBHIJLFEHFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum BHFNLKFHFPC
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LCHNDCKOECL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event BKKLCHMMMPO LGMNOFJACDE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGNOKCGFCAC(AKPAKEJMCNB GJPBCFJDGCH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKCFBPNEIIF(AKPAKEJMCNB GJPBCFJDGCH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BLDDGFDICNL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float CKPKIJGPBPL
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
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLNFCJEOCDM(Rigidbody GLNPLCBFALF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface CCALBGNPAOK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EDKPIAFEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIFAGCCPENF(string OABOGFOJNOI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGFGMKKHCEO(RigidbodyEx KLEOGNMJFCE, Action COPPLLLOGLG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GNNADOJEIPI AIBAFFDENOL(int EEHNLFMGGEK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDDFKPHHDIO(Vector3 BHFPMLIEGNC, float EBPJLFDIABG, Color JIINIIPALJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface JBIENGFNALE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CCALBGNPAOK BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LOJAGMFINDG MBIMOONHHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPLJHAHPEEF GFGNIEEJMNC(RigidbodyEx KLEOGNMJFCE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFHLEJKGPHE();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KIOMOLIAAFN();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GPMFGGALJAP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx COPACIADPOC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HBPPGIEGCED
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFJCPAMONEK(AKPAKEJMCNB GJPBCFJDGCH, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HINHLDOAKJB(object AMCDGOPKAOE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FDPPAOHONBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A26A00", Offset = "0x5A25200", VA = "0x185A26A00")]
	public FDPPAOHONBM(FNPFPKJAEFL LIOFIIHFDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A269A0", Offset = "0x5A251A0", VA = "0x185A269A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FNPFPKJAEFL : AKPAKEJMCNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly JBIENGFNALE OAFFOBLPFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal CGOOPOPNOJO AAOAOHHKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal BHLMJHGKFAD ONOALFHAMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LCHNDCKOECL PBHLNILGHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LANDKDCHLLJ KFENDEDNACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal HBPPGIEGCED OJOMEGGEAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal GCLEJFKMCNI ACAFHFIGJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal BLDDGFDICNL IKFDMEAPJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal LOEDKPJOLCN JHBKJNBAAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IPCMKIOFGLK FBIMLKGBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal FBMHFJKGPFK EJPKDMJODCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal GJPEMKFINBD GEMHLKPIKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BLIOHBLGLJI BJDJJEPMPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal EDCPAEHNJPE DLAKIGOOKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal EFOPFPCNKBB GLNPLCBFALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal FHFHCPDLIAC AIKHGHGAJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IDisposable KMMADIMBJLG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public RigidbodyEx BCJHCHCMMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD0", Offset = "0x7EF4D0", VA = "0x1807F0CD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C70", Offset = "0x7EF470", VA = "0x1807F0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GameObject DCKJHLJNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F39B0", Offset = "0x7F21B0", VA = "0x1807F39B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C00", Offset = "0x7F2400", VA = "0x1807F3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Transform HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A050", Offset = "0x5A28850", VA = "0x185A2A050", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5A277B0", Offset = "0x5A25FB0", VA = "0x185A277B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5A28790", Offset = "0x5A26F90", VA = "0x185A28790", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5A27680", Offset = "0x5A25E80", VA = "0x185A27680", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CBF0", Offset = "0x5A2B3F0", VA = "0x185A2CBF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5A27400", Offset = "0x5A25C00", VA = "0x185A27400", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BAA0", Offset = "0x5A2A2A0", VA = "0x185A2BAA0", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CAF0", Offset = "0x5A2B2F0", VA = "0x185A2CAF0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5A28A40", Offset = "0x5A27240", VA = "0x185A28A40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C5E0", Offset = "0x5A2ADE0", VA = "0x185A2C5E0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5A27450", Offset = "0x5A25C50", VA = "0x185A27450", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A7C0", Offset = "0x5A28FC0", VA = "0x185A2A7C0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AA70", Offset = "0x5A29270", VA = "0x185A2AA70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C030", Offset = "0x5A2A830", VA = "0x185A2C030", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B820", Offset = "0x5A2A020", VA = "0x185A2B820", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A29610", Offset = "0x5A27E10", VA = "0x185A29610", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C890", Offset = "0x5A2B090", VA = "0x185A2C890", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D140", Offset = "0x5A2B940", VA = "0x185A2D140", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A6F0", Offset = "0x5A28EF0", VA = "0x185A2A6F0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C1B0", Offset = "0x5A2A9B0", VA = "0x185A2C1B0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D2C0", Offset = "0x5A2BAC0", VA = "0x185A2D2C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BC50", Offset = "0x5A2A450", VA = "0x185A2BC50", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5A29540", Offset = "0x5A27D40", VA = "0x185A29540", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool MAFMNHOECEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5A29CC0", Offset = "0x5A284C0", VA = "0x185A29CC0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FFGMKNBJONO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5A299B0", Offset = "0x5A281B0", VA = "0x185A299B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool GNLHFFBDGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5A29200", Offset = "0x5A27A00", VA = "0x185A29200", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5A29E20", Offset = "0x5A28620", VA = "0x185A29E20", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CA20", Offset = "0x5A2B220", VA = "0x185A2CA20", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A860", Offset = "0x5A29060", VA = "0x185A2A860", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5A275B0", Offset = "0x5A25DB0", VA = "0x185A275B0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5A28E40", Offset = "0x5A27640", VA = "0x185A28E40", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BD20", Offset = "0x5A2A520", VA = "0x185A2BD20", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AA20", Offset = "0x5A29220", VA = "0x185A2AA20", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A0E0", Offset = "0x5A288E0", VA = "0x185A2A0E0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5A280A0", Offset = "0x5A268A0", VA = "0x185A280A0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5A285F0", Offset = "0x5A26DF0", VA = "0x185A285F0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C080", Offset = "0x5A2A880", VA = "0x185A2C080", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AAD0", Offset = "0x5A292D0", VA = "0x185A2AAD0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C580", Offset = "0x5A2AD80", VA = "0x185A2C580", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float CKPKIJGPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5A291B0", Offset = "0x5A279B0", VA = "0x185A291B0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5A28280", Offset = "0x5A26A80", VA = "0x185A28280", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool MNGNMLJNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5A27C50", Offset = "0x5A26450", VA = "0x185A27C50", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CCB0", Offset = "0x5A2B4B0", VA = "0x185A2CCB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AB80", Offset = "0x5A29380", VA = "0x185A2AB80", Slot = "48")]
		get
		{
			return default(JOKBKMCLMIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C960", Offset = "0x5A2B160", VA = "0x185A2C960", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CC40", Offset = "0x5A2B440", VA = "0x185A2CC40", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Transform HNADCANFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5A28030", Offset = "0x5A26830", VA = "0x185A28030", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 PFJCFHCNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AFF0", Offset = "0x5A297F0", VA = "0x185A2AFF0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5A27300", Offset = "0x5A25B00", VA = "0x185A27300", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float KOOJKGHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CC90", Offset = "0x5A2B490", VA = "0x185A2CC90", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5A27740", Offset = "0x5A25F40", VA = "0x185A27740", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public float DINGNFIDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5A296E0", Offset = "0x5A27EE0", VA = "0x185A296E0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5A29D10", Offset = "0x5A28510", VA = "0x185A29D10", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Quaternion GILONKGEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B8E0", Offset = "0x5A2A0E0", VA = "0x185A2B8E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B640", Offset = "0x5A29E40", VA = "0x185A2B640", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A000", Offset = "0x5A28800", VA = "0x185A2A000", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D270", Offset = "0x5A2BA70", VA = "0x185A2D270", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Quaternion FBEABAEGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5A28F10", Offset = "0x5A27710", VA = "0x185A28F10", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A930", Offset = "0x5A29130", VA = "0x185A2A930", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public RigidbodyConstraints MMPKMGKHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A810", Offset = "0x5A29010", VA = "0x185A2A810", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5A29F20", Offset = "0x5A28720", VA = "0x185A29F20", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CE10", Offset = "0x5A2B610", VA = "0x185A2CE10", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2BA40", Offset = "0x5A2A240", VA = "0x185A2BA40", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CollisionDetectionMode OCGEKFIJCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CB40", Offset = "0x5A2B340", VA = "0x185A2CB40", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5A28040", Offset = "0x5A26840", VA = "0x185A28040", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PLOJOLEFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5A28F50", Offset = "0x5A27750", VA = "0x185A28F50", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MNGOCFLODEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D3F0", Offset = "0x5A2BBF0", VA = "0x185A2D3F0", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool AFMEOPHBLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A970", Offset = "0x5A29170", VA = "0x185A2A970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LLOOHBEJBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5A281A0", Offset = "0x5A269A0", VA = "0x185A281A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event BKKLCHMMMPO HIAKNGJBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5A29700", Offset = "0x5A27F00", VA = "0x185A29700", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5A272A0", Offset = "0x5A25AA0", VA = "0x185A272A0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event BKKLCHMMMPO AMONPALDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A2CDB0", Offset = "0x5A2B5B0", VA = "0x185A2CDB0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A2D390", Offset = "0x5A2BB90", VA = "0x185A2D390", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event CPNLBCPAMIE FHMNKCMGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A28590", Offset = "0x5A26D90", VA = "0x185A28590", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B9E0", Offset = "0x5A2A1E0", VA = "0x185A2B9E0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event BKKLCHMMMPO LGMNOFJACDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A350", Offset = "0x5A28B50", VA = "0x185A2A350", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A27EE0", Offset = "0x5A266E0", VA = "0x185A27EE0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event BKKLCHMMMPO AFNMNLNKLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A29FA0", Offset = "0x5A287A0", VA = "0x185A29FA0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A27E80", Offset = "0x5A26680", VA = "0x185A27E80", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event BKKLCHMMMPO MLNFNBBFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C730", Offset = "0x5A2AF30", VA = "0x185A2C730", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B880", Offset = "0x5A2A080", VA = "0x185A2B880", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C150", Offset = "0x5A2A950", VA = "0x185A2C150", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5A27500", Offset = "0x5A25D00", VA = "0x185A27500", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event BKKLCHMMMPO MKAFGOIDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B580", Offset = "0x5A29D80", VA = "0x185A2B580", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5A2AB20", Offset = "0x5A29320", VA = "0x185A2AB20", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event BKKLCHMMMPO AJBELLAEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5A2C790", Offset = "0x5A2AF90", VA = "0x185A2C790", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5A28100", Offset = "0x5A26900", VA = "0x185A28100", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D5C0", Offset = "0x5A2BDC0", VA = "0x185A2D5C0")]
	public FNPFPKJAEFL(GameObject OAOEKKJFJKH, RigidbodyEx HNIHEJEANNM, JBIENGFNALE OAFFOBLPFIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CE60", Offset = "0x5A2B660", VA = "0x185A2CE60", Slot = "135")]
	protected virtual void PCCOFNIADNN(JBIENGFNALE OAFFOBLPFIG, LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A286C0", Offset = "0x5A26EC0", VA = "0x185A286C0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B6E0", Offset = "0x5A29EE0", VA = "0x185A2B6E0", Slot = "71")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A274B0", Offset = "0x5A25CB0", VA = "0x185A274B0", Slot = "72")]
	public void MBNMLGBBHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A29F80", Offset = "0x5A28780", VA = "0x185A29F80", Slot = "73")]
	public void GPEDMKMFLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A29490", Offset = "0x5A27C90", VA = "0x185A29490")]
	private void EOBJHGDDJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5A287E0", Offset = "0x5A26FE0", VA = "0x185A287E0", Slot = "81")]
	public void EALODDMPHDN(AKPAKEJMCNB MENBIMCLIOI, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5A2BBF0", Offset = "0x5A2A3F0", VA = "0x185A2BBF0", Slot = "84")]
	public void LGBNNKCCJDF(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5A276E0", Offset = "0x5A25EE0", VA = "0x185A276E0", Slot = "85")]
	public void BACGCOBCGPN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5A2BDF0", Offset = "0x5A2A5F0", VA = "0x185A2BDF0", Slot = "86")]
	public Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C280", Offset = "0x5A2AA80", VA = "0x185A2C280", Slot = "87")]
	public Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5A274B0", Offset = "0x5A25CB0", VA = "0x185A274B0", Slot = "88")]
	public void AFCAJNFFHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C530", Offset = "0x5A2AD30", VA = "0x185A2C530", Slot = "89")]
	public void MKALHOHGPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B990", Offset = "0x5A2A190", VA = "0x185A2B990", Slot = "90")]
	public void KKFKLNMJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5A2BB00", Offset = "0x5A2A300", VA = "0x185A2BB00", Slot = "91")]
	public void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5A298C0", Offset = "0x5A280C0", VA = "0x185A298C0", Slot = "92")]
	public void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C370", Offset = "0x5A2AB70", VA = "0x185A2C370", Slot = "93")]
	public void MFJEJHNKAAO(Vector3 EEPMGGAMMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5A290A0", Offset = "0x5A278A0", VA = "0x185A290A0", Slot = "94")]
	public void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5A29A10", Offset = "0x5A28210", VA = "0x185A29A10", Slot = "95")]
	public void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C630", Offset = "0x5A2AE30", VA = "0x185A2C630", Slot = "96")]
	[Obsolete]
	public void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C440", Offset = "0x5A2AC40", VA = "0x185A2C440", Slot = "97")]
	public Vector3 MJHIJDKBEBN(Vector3 MENBIMCLIOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5A282E0", Offset = "0x5A26AE0", VA = "0x185A282E0", Slot = "98")]
	public Vector3 DNJKEGKNPCL(Vector3 MENBIMCLIOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5A27800", Offset = "0x5A26000", VA = "0x185A27800", Slot = "99")]
	public void BDOFOKEDCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5A2AF30", Offset = "0x5A29730", VA = "0x185A2AF30", Slot = "100")]
	public void JIADAFOBLOJ(AKPAKEJMCNB LGKFEACNPCO, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B0B0", Offset = "0x5A298B0", VA = "0x185A2B0B0", Slot = "101")]
	public void JKFFINDNBFC(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B110", Offset = "0x5A29910", VA = "0x185A2B110", Slot = "41")]
	public void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5A28230", Offset = "0x5A26A30", VA = "0x185A28230", Slot = "104")]
	public void DEADAFLGDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CD10", Offset = "0x5A2B510", VA = "0x185A2CD10", Slot = "105")]
	public void OJDDIEONFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5A28540", Offset = "0x5A26D40", VA = "0x185A28540", Slot = "106")]
	public void DPBNPPEAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5A27560", Offset = "0x5A25D60", VA = "0x185A27560", Slot = "109")]
	public bool AKMPDAKLHKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CD60", Offset = "0x5A2B560", VA = "0x185A2CD60", Slot = "74")]
	public void OLEEDMGNOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5A28D90", Offset = "0x5A27590", VA = "0x185A28D90", Slot = "110")]
	public void EFEMKHDKMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5A281E0", Offset = "0x5A269E0", VA = "0x185A281E0", Slot = "115")]
	public IDisposable DCLGFCOEFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C830", Offset = "0x5A2B030", VA = "0x185A2C830", Slot = "116")]
	public void NGCNAJEIOBN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5A2A2F0", Offset = "0x5A28AF0", VA = "0x185A2A2F0", Slot = "117")]
	public void HJPDMAGHGCM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5A2BFC0", Offset = "0x5A2A7C0", VA = "0x185A2BFC0", Slot = "118")]
	public void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5A2A3B0", Offset = "0x5A28BB0", VA = "0x185A2A3B0", Slot = "121")]
	public void HLINOHCMAOK(Vector3 OCDLANKHJEL, Quaternion ONHAKCONDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5A2ABD0", Offset = "0x5A293D0", VA = "0x185A2ABD0", Slot = "122")]
	public void JGCNGOMIAFD(Vector3 OJECHCGNLLP, Quaternion NEPCPOJAKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B5E0", Offset = "0x5A29DE0", VA = "0x185A2B5E0", Slot = "123")]
	public bool JPFLEDFLNPC(float IJICPBHJJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2CB90", Offset = "0x5A2B390", VA = "0x185A2CB90", Slot = "124")]
	public void NLLHBIAAMEO(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D210", Offset = "0x5A2BA10", VA = "0x185A2D210", Slot = "125")]
	public void PIEMCLDGJBD(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5A29860", Offset = "0x5A28060", VA = "0x185A29860", Slot = "126")]
	public void FNHMFKFJJBB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5A28DE0", Offset = "0x5A275E0", VA = "0x185A28DE0", Slot = "127")]
	public void EFFIDBKNFJH(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5A2A210", Offset = "0x5A28A10", VA = "0x185A2A210", Slot = "128")]
	public void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5A29380", Offset = "0x5A27B80", VA = "0x185A29380", Slot = "129")]
	public void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5A2A130", Offset = "0x5A28930", VA = "0x185A2A130", Slot = "130")]
	public void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5A29B00", Offset = "0x5A28300", VA = "0x185A29B00", Slot = "131")]
	public void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5A27F40", Offset = "0x5A26740", VA = "0x185A27F40", Slot = "132")]
	public bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5A273B0", Offset = "0x5A25BB0", VA = "0x185A273B0", Slot = "133")]
	public void ACGNHPHLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D580", Offset = "0x5A2BD80", VA = "0x185A2D580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5A2A620", Offset = "0x5A28E20", VA = "0x185A2A620")]
	private void IAGFGPGGLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5A2AD80", Offset = "0x5A29580", VA = "0x185A2AD80")]
	private void JGJCHNPHDNJ(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5A28850", Offset = "0x5A27050", VA = "0x185A28850")]
	private void ECDFCIJOIML(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5A29E70", Offset = "0x5A28670", VA = "0x185A29E70")]
	private void GKFFPCDAGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5A29760", Offset = "0x5A27F60", VA = "0x185A29760")]
	private void FKCEMPEIFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5A27CA0", Offset = "0x5A264A0", VA = "0x185A27CA0")]
	private void CDAAPNMNMCL(AKPAKEJMCNB LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5A29BE0", Offset = "0x5A283E0", VA = "0x185A29BE0")]
	private void GGNOKCGFCAC(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5A2BEE0", Offset = "0x5A2A6E0", VA = "0x185A2BEE0")]
	private void LKCFBPNEIIF(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5A283D0", Offset = "0x5A26BD0", VA = "0x185A283D0")]
	private void DOLOJNJAPGD(RigidbodyEx GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5A2B1F0", Offset = "0x5A299F0", VA = "0x185A2B1F0", Slot = "140")]
	protected virtual void JMMEGHKEPMO(RigidbodyEx KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5A28A90", Offset = "0x5A27290", VA = "0x185A28A90")]
	protected void EDBPGAMFMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5A27850", Offset = "0x5A26050", VA = "0x185A27850")]
	protected void BNNCBECKPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5A292F0", Offset = "0x5A27AF0", VA = "0x185A292F0", Slot = "141")]
	protected virtual IDisposable ELMHODLNPCI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class CIPOGGFJMMK
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5A1DA40", Offset = "0x5A1C240", VA = "0x185A1DA40")]
	public static AKPAKEJMCNB IHLCJEMDPJP(this AKPAKEJMCNB KLEOGNMJFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5A1DB00", Offset = "0x5A1C300", VA = "0x185A1DB00")]
	public static bool KFCCPAAMKHF(this AKPAKEJMCNB KLEOGNMJFCE, AKPAKEJMCNB IJDDBMPJGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D9C0", Offset = "0x5A1C1C0", VA = "0x185A1D9C0")]
	public static bool GBBLJKDLOCI(this AKPAKEJMCNB KLEOGNMJFCE, AKPAKEJMCNB LEMMIKBFPGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D900", Offset = "0x5A1C100", VA = "0x185A1D900")]
	public static RigidbodyEx BCJHCHCMMLE(this AKPAKEJMCNB MOJFAFLNEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D950", Offset = "0x5A1C150", VA = "0x185A1D950")]
	public static FNPFPKJAEFL FGNDKEPECAO(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GCLEJFKMCNI
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event BKKLCHMMMPO PEJOIPBMLOH;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OJDDIEONFDL();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DEADAFLGDAP();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DPBNPPEAMPG();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLNFCJEOCDM(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ACGNHPHLMBP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AKPAKEJMCNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	RigidbodyEx BCJHCHCMMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GameObject DCKJHLJNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Transform HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool FFGMKNBJONO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool GNLHFFBDGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float CKPKIJGPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool MNGNMLJNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform HNADCANFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 PFJCFHCNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float KOOJKGHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float DINGNFIDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Quaternion GILONKGEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Quaternion FBEABAEGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	RigidbodyConstraints MMPKMGKHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CollisionDetectionMode OCGEKFIJCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool MNGOCFLODEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event BKKLCHMMMPO HIAKNGJBCCL;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event BKKLCHMMMPO AMONPALDEJK;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event CPNLBCPAMIE FHMNKCMGCIM;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event BKKLCHMMMPO LGMNOFJACDE;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event BKKLCHMMMPO AFNMNLNKLIO;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event BKKLCHMMMPO MLNFNBBFIEO;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event BKKLCHMMMPO MKAFGOIDMAG;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event BKKLCHMMMPO AJBELLAEFNN;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MBNMLGBBHEA();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void GPEDMKMFLAL();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void OLEEDMGNOMI();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void EALODDMPHDN(AKPAKEJMCNB MENBIMCLIOI, bool JOHIKFAEACC = false);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void LGBNNKCCJDF(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void BACGCOBCGPN(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void AFCAJNFFHFG();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void MKALHOHGPEL();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void KKFKLNMJFPO();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void MFJEJHNKAAO(Vector3 EEPMGGAMMHG);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 MJHIJDKBEBN(Vector3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 DNJKEGKNPCL(Vector3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BDOFOKEDCAB();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void JIADAFOBLOJ(AKPAKEJMCNB LGKFEACNPCO, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void JKFFINDNBFC(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void DEADAFLGDAP();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void OJDDIEONFDL();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void DPBNPPEAMPG();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool AKMPDAKLHKD();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void EFEMKHDKMEH();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable DCLGFCOEFDJ();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void NGCNAJEIOBN(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void HJPDMAGHGCM(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HLINOHCMAOK(Vector3 OCDLANKHJEL, Quaternion ONHAKCONDDA);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void JGCNGOMIAFD(Vector3 OJECHCGNLLP, Quaternion NEPCPOJAKJJ);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool JPFLEDFLNPC(float IJICPBHJJLL);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void NLLHBIAAMEO(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void PIEMCLDGJBD(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void FNHMFKFJJBB(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void EFFIDBKNFJH(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ACGNHPHLMBP();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BLIOHBLGLJI
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GOEGIKJGDDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FNCLHIKAKJP();

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 OMBLOOEPIKP();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BHLMJHGKFAD
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIHGBPNJOHD(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDJBAOKPDJB(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DADDKKKDJOH(AKPAKEJMCNB KLEOGNMJFCE);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKCPPLBKLPM(AKPAKEJMCNB KLEOGNMJFCE);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGMANOOHJGB();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FBMHFJKGPFK : IDisposable, EECIICGPDHK
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPLAAMDJJDO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CGOOPOPNOJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event BKKLCHMMMPO HIAKNGJBCCL;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event BKKLCHMMMPO AMONPALDEJK;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event CPNLBCPAMIE FHMNKCMGCIM;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action PJNPOLFAFMF;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action FPPAMAPICNA;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<AKPAKEJMCNB> DHJFGGHKMFE;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<AKPAKEJMCNB> LMAPAMAFAPN;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action KPJPGGONCHL;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<AKPAKEJMCNB> GDGGFNPJHIA;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EALODDMPHDN(AKPAKEJMCNB ILLDOGNGNOD, bool JOHIKFAEACC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface LOJAGMFINDG
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGOOPOPNOJO PHOFNEKNNNH(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LANDKDCHLLJ FKALCADODMK(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBPPGIEGCED JKGLPFCGEGB(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BLDDGFDICNL JCDNPNIAGHA(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IPCMKIOFGLK NMMMIOCGEKK(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FBMHFJKGPFK IEBCGGCMFNG(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GJPEMKFINBD IDKHNADJKHA(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLIOHBLGLJI KJFCMMFDBHH(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FHFHCPDLIAC LLLLJJGLNHD(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LOEDKPJOLCN BGOALPEAHCL(AKPAKEJMCNB PBDNMEDOHIG);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EFOPFPCNKBB HGKMPKMJCJF(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LCHNDCKOECL FJMODFIMAEI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BHLMJHGKFAD JFNBEHDHEBH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GCLEJFKMCNI JOKJIGHCNAL(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EDCPAEHNJPE MOHAEICDOFM(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN, JBIENGFNALE OAFFOBLPFIG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EDCPAEHNJPE
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool DABGOPGBGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	RigidbodyConstraints MMPKMGKHCPL
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
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLNFCJEOCDM(Rigidbody GLNPLCBFALF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DLBCBPHCDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBIJCGAODLP(Vector3 JKKMOJALIJA);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANCGGGFGPDK(Vector3 ODPEGCEAOBB);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCCBIBGOCGM(Vector3 JKKMOJALIJA);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCFLANMHPHE(Vector3 ODPEGCEAOBB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GJPEMKFINBD
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event BKKLCHMMMPO MKAFGOIDMAG;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCKDCFBABOA();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGCNAJEIOBN(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJPDMAGHGCM(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable DCLGFCOEFDJ();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCJGAKFHEKJ(Rigidbody JICGNHIFHFC);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLNFCJEOCDM(Rigidbody GLNPLCBFALF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface FHFHCPDLIAC
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CollisionDetectionMode OCGEKFIJCNF
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
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANEEKHEMGCN(bool LJKNFCFGHFA);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHDHOHJEEID(bool LJKNFCFGHFA);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LANDKDCHLLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IHIEAEPOKJM(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KKFKLNMJFPO();

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MKALHOHGPEL();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BDOFOKEDCAB();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AFCAJNFFHFG();

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MJHIJDKBEBN(Vector3 KFENDEDNACE);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OBPBANLJNBF(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MFJEJHNKAAO(Vector3 EEPMGGAMMHG);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EFOPFPCNKBB
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool CHLOKOHCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNHMFKFJJBB(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFFIDBKNFJH(object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLCNCHCBIPH();

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LGKKAHMHJJO();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LOEDKPJOLCN
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool MNGNMLJNFDC
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
	void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NLNFCJEOCDM(Rigidbody GLNPLCBFALF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface IPCMKIOFGLK
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event BKKLCHMMMPO MLNFNBBFIEO;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPLAAMDJJDO();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AKMPDAKLHKD();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBEFMJDNBDF();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLEEDMGNOMI();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOLLPCOJDJI();

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFEMKHDKMEH();

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EECOEHINOGD(bool JMCPMHHMAPD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[KHNAILLFHGJ(typeof(OBIIMMCNMNC), new string[] { })]
public sealed class BHKDKNCHBEN : NOFCHOCEBPC, OBIIMMCNMNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[NAAJCOHOAKA]
	private HCOBHGJLPEC KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5A19CA0", Offset = "0x5A184A0", VA = "0x185A19CA0", Slot = "4")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5A19C70", Offset = "0x5A18470", VA = "0x185A19C70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5A19CF0", Offset = "0x5A184F0", VA = "0x185A19CF0", Slot = "6")]
	public void JKAIIPECNDE(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5A19E70", Offset = "0x5A18670", VA = "0x185A19E70", Slot = "7")]
	public void LGGJMHBFDJB(LPLJHAHPEEF BBNGIDIFEAM, bool MODLCEHPNLL, bool FIPHPGDDBJE, bool PLNJLKFIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A0F0", Offset = "0x5A188F0", VA = "0x185A1A0F0")]
	private bool PGDAJAENJPC(LPLJHAHPEEF BBNGIDIFEAM, out OOIJGCADMAO PBDNMEDOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5A19B10", Offset = "0x5A18310", VA = "0x185A19B10")]
	private bool DNPLACBPGIF(LPLJHAHPEEF BBNGIDIFEAM, out CJLBAKDMNIG HPKKOEAIPML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public BHKDKNCHBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CJLBAKDMNIG : EOCMCKCGEEJ, GCLEJFKMCNI
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	[Obsolete]
	public Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E0A0", Offset = "0x5A1C8A0", VA = "0x185A1E0A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E730", Offset = "0x5A1CF30", VA = "0x185A1E730", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 ABPDBADKGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5A20770", Offset = "0x5A1EF70", VA = "0x185A20770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 JLAOLMKMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A20640", Offset = "0x5A1EE40", VA = "0x185A20640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[Obsolete]
	public Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5A20490", Offset = "0x5A1EC90", VA = "0x185A20490", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	[Obsolete]
	public float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5A1F0A0", Offset = "0x5A1D8A0", VA = "0x185A1F0A0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float IDKNMICOONA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E970", Offset = "0x5A1D170", VA = "0x185A1E970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x5A1EFD0", Offset = "0x5A1D7D0", VA = "0x185A1EFD0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E3A0", Offset = "0x5A1CBA0", VA = "0x185A1E3A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E940", Offset = "0x5A1D140", VA = "0x185A1E940", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x5A20610", Offset = "0x5A1EE10", VA = "0x185A20610", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D250", Offset = "0x5A1BA50", VA = "0x185A1D250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event BKKLCHMMMPO PEJOIPBMLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5A1E1C0", Offset = "0x5A1C9C0", VA = "0x185A1E1C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5A21030", Offset = "0x5A1F830", VA = "0x185A21030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5A210D0", Offset = "0x5A1F8D0", VA = "0x185A210D0")]
	public CJLBAKDMNIG(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ECA0", Offset = "0x5A1D4A0", VA = "0x185A1ECA0")]
	public float3 FCHDDAGGBPC()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5A20220", Offset = "0x5A1EA20", VA = "0x185A20220", Slot = "14")]
	public void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E4A0", Offset = "0x5A1CCA0", VA = "0x185A1E4A0", Slot = "16")]
	public void DEADAFLGDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5A20B40", Offset = "0x5A1F340", VA = "0x185A20B40", Slot = "15")]
	public void OJDDIEONFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E260", Offset = "0x5A1CA60", VA = "0x185A1E260", Slot = "18")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5A20890", Offset = "0x5A1F090", VA = "0x185A20890", Slot = "19")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E870", Offset = "0x5A1D070", VA = "0x185A1E870", Slot = "17")]
	public void DPBNPPEAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5A1DB80", Offset = "0x5A1C380", VA = "0x185A1DB80", Slot = "20")]
	public void ACGNHPHLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ED60", Offset = "0x5A1D560", VA = "0x185A1ED60")]
	public void GEMNCPCBMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E730", Offset = "0x5A1CF30", VA = "0x185A1E730")]
	private void DOILEHPKOHH(Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5A20EC0", Offset = "0x5A1F6C0", VA = "0x185A20EC0")]
	[Obsolete]
	private Vector3 PJEEJGGABIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5A1E3A0", Offset = "0x5A1CBA0", VA = "0x185A1E3A0")]
	private void IJDFPPHCBKN(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1EA60", Offset = "0x5A1D260", VA = "0x185A1EA60")]
	private Vector3 ECCFFPHGNIL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5A1EDA0", Offset = "0x5A1D5A0", VA = "0x185A1EDA0")]
	private Quaternion GKCCKIPLOBH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1F170", Offset = "0x5A1D970", VA = "0x185A1F170")]
	internal (float, Vector3) JKAIIPECNDE(Rigidbody KPJEACPPCOE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class KDBJIKJOJNF
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AF90", Offset = "0x5A39790", VA = "0x185A3AF90")]
	public static CJLBAKDMNIG BEOLNAIAMKF(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class HLDGMHKAPCK : EOCMCKCGEEJ, LANDKDCHLLJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5A35C40", Offset = "0x5A34440", VA = "0x185A35C40", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5A33130", Offset = "0x5A31930", VA = "0x185A33130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5A34730", Offset = "0x5A32F30", VA = "0x185A34730", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5A34950", Offset = "0x5A33150", VA = "0x185A34950", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5A35750", Offset = "0x5A33F50", VA = "0x185A35750", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5A36AA0", Offset = "0x5A352A0", VA = "0x185A36AA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5A34180", Offset = "0x5A32980", VA = "0x185A34180", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5A36090", Offset = "0x5A34890", VA = "0x185A36090", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5A35440", Offset = "0x5A33C40", VA = "0x185A35440", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A340C0", Offset = "0x5A328C0", VA = "0x185A340C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A36A70", Offset = "0x5A35270", VA = "0x185A36A70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A34700", Offset = "0x5A32F00", VA = "0x185A34700", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A35680", Offset = "0x5A33E80", VA = "0x185A35680", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5A34EA0", Offset = "0x5A336A0", VA = "0x185A34EA0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5A34620", Offset = "0x5A32E20", VA = "0x185A34620", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private BLIOHBLGLJI GPKEGOCEHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2026BE0", Offset = "0x20253E0", VA = "0x182026BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool PLOJOLEFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5A2EF60", Offset = "0x5A2D760", VA = "0x185A2EF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public HLDGMHKAPCK(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A34860", Offset = "0x5A33060", VA = "0x185A34860", Slot = "20")]
	public void IHIEAEPOKJM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5A366D0", Offset = "0x5A34ED0", VA = "0x185A366D0", Slot = "30")]
	public void OBPBANLJNBF(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5A33220", Offset = "0x5A31A20", VA = "0x185A33220", Slot = "19")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5A33940", Offset = "0x5A32140", VA = "0x185A33940", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A33840", Offset = "0x5A32040", VA = "0x185A33840", Slot = "28")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5A354A0", Offset = "0x5A33CA0", VA = "0x185A354A0", Slot = "35")]
	public Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5A357B0", Offset = "0x5A33FB0", VA = "0x185A357B0", Slot = "34")]
	public Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5A33220", Offset = "0x5A31A20", VA = "0x185A33220", Slot = "27")]
	public void AFCAJNFFHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A35C00", Offset = "0x5A34400", VA = "0x185A35C00", Slot = "25")]
	public void MKALHOHGPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A34F10", Offset = "0x5A33710", VA = "0x185A34F10", Slot = "24")]
	public void KKFKLNMJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5A35200", Offset = "0x5A33A00", VA = "0x185A35200", Slot = "33")]
	public void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A34380", Offset = "0x5A32B80", VA = "0x185A34380", Slot = "32")]
	public void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A35970", Offset = "0x5A34170", VA = "0x185A35970", Slot = "31")]
	public void MFJEJHNKAAO(Vector3 EEPMGGAMMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A33A70", Offset = "0x5A32270", VA = "0x185A33A70", Slot = "22")]
	public void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A343E0", Offset = "0x5A32BE0", VA = "0x185A343E0", Slot = "21")]
	public void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5A35D70", Offset = "0x5A34570", VA = "0x185A35D70", Slot = "23")]
	[Obsolete]
	public void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5A35B40", Offset = "0x5A34340", VA = "0x185A35B40", Slot = "29")]
	public Vector3 MJHIJDKBEBN(Vector3 KFENDEDNACE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A336E0", Offset = "0x5A31EE0", VA = "0x185A336E0", Slot = "26")]
	public void BDOFOKEDCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A341B0", Offset = "0x5A329B0", VA = "0x185A341B0")]
	private void FHCNDHPPAAH(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A33E90", Offset = "0x5A32690", VA = "0x185A33E90")]
	private void FAOLNCKPKFI(Vector3 MFOCPNHPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A34F50", Offset = "0x5A33750", VA = "0x185A34F50")]
	private Vector3 KOFJBNMBHEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A34A40", Offset = "0x5A33240", VA = "0x185A34A40")]
	private void JDIKDPBGKIL(Vector3 PJDFDKKMIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A367C0", Offset = "0x5A34FC0", VA = "0x185A367C0")]
	private Vector3 OMBLOOEPIKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A33290", Offset = "0x5A31A90", VA = "0x185A33290")]
	private void ANCGGGFGPDK(Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A34EB0", Offset = "0x5A336B0", VA = "0x185A34EB0")]
	private void KCPLIABIADK(Vector3 KFENDEDNACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A34060", Offset = "0x5A32860", VA = "0x185A34060")]
	private void FBJALPHCDHB(Vector3 ODPEGCEAOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A360C0", Offset = "0x5A348C0", VA = "0x185A360C0")]
	private void OBOAMCPFBFM(string EHNOBJDBHFJ, Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5A33880", Offset = "0x5A32080", VA = "0x185A33880")]
	private void CKEFKFLANCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HPIODJAPNGK : EOCMCKCGEEJ, BLDDGFDICNL
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A399C0", Offset = "0x5A381C0", VA = "0x185A399C0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5A39A90", Offset = "0x5A38290", VA = "0x185A39A90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float CKPKIJGPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5A398F0", Offset = "0x5A380F0", VA = "0x185A398F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5A39720", Offset = "0x5A37F20", VA = "0x185A39720", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public HPIODJAPNGK(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5A39560", Offset = "0x5A37D60", VA = "0x185A39560", Slot = "8")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5A39C60", Offset = "0x5A38460", VA = "0x185A39C60", Slot = "9")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[UnityEngine.Scripting.Preserve]
public sealed class GDACEIIMIAF : AKPAKEJMCNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly GDACEIIMIAF OEFAOPMNMGM;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public RigidbodyEx BCJHCHCMMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GameObject DCKJHLJNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Transform HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA55970", Offset = "0xA54170", VA = "0x180A55970", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA98520", Offset = "0xA96D20", VA = "0x180A98520", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xFB2650", Offset = "0xFB0E50", VA = "0x180FB2650", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2E9FF60", Offset = "0x2E9E760", VA = "0x182E9FF60", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x149B980", Offset = "0x149A180", VA = "0x18149B980", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x27D98F0", Offset = "0x27D80F0", VA = "0x1827D98F0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2F541F0", Offset = "0x2F529F0", VA = "0x182F541F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E790", Offset = "0x5A2CF90", VA = "0x185A2E790", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3176E80", Offset = "0x3175680", VA = "0x183176E80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1BDCD20", Offset = "0x1BDB520", VA = "0x181BDCD20", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FFGMKNBJONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xBBC800", Offset = "0xBBB000", VA = "0x180BBC800", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool GNLHFFBDGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x1A1B390", Offset = "0x1A19B90", VA = "0x181A1B390", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x11E12C0", Offset = "0x11DFAC0", VA = "0x1811E12C0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2062FE0", Offset = "0x20617E0", VA = "0x182062FE0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1160190", Offset = "0x115E990", VA = "0x181160190", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1ED68B0", Offset = "0x1ED50B0", VA = "0x181ED68B0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E7A0", Offset = "0x5A2CFA0", VA = "0x185A2E7A0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x924430", Offset = "0x922C30", VA = "0x180924430", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x13C0350", Offset = "0x13BEB50", VA = "0x1813C0350", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x924430", Offset = "0x922C30", VA = "0x180924430", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float CKPKIJGPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x924430", Offset = "0x922C30", VA = "0x180924430", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool MNGNMLJNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "48")]
		get
		{
			return default(JOKBKMCLMIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3370", Offset = "0x4FF1B70", VA = "0x184FF3370", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Transform HNADCANFNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA40", Offset = "0xA4C240", VA = "0x180A4DA40", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 PFJCFHCNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float KOOJKGHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x924430", Offset = "0x922C30", VA = "0x180924430", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float DINGNFIDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x924430", Offset = "0x922C30", VA = "0x180924430", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion GILONKGEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xB3CBE0", Offset = "0xB3B3E0", VA = "0x180B3CBE0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Quaternion FBEABAEGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xB3CBE0", Offset = "0xB3B3E0", VA = "0x180B3CBE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public RigidbodyConstraints MMPKMGKHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CollisionDetectionMode OCGEKFIJCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool MNGOCFLODEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x147EFF0", Offset = "0x147D7F0", VA = "0x18147EFF0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event BKKLCHMMMPO HIAKNGJBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event BKKLCHMMMPO AMONPALDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CPNLBCPAMIE FHMNKCMGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event BKKLCHMMMPO LGMNOFJACDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event BKKLCHMMMPO AFNMNLNKLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event BKKLCHMMMPO MLNFNBBFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event BKKLCHMMMPO MKAFGOIDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event BKKLCHMMMPO AJBELLAEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "41")]
	public void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "71")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "72")]
	public void MBNMLGBBHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "73")]
	public void GPEDMKMFLAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "74")]
	public void OLEEDMGNOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "81")]
	public void EALODDMPHDN(AKPAKEJMCNB MENBIMCLIOI, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "84")]
	public void LGBNNKCCJDF(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "85")]
	public void BACGCOBCGPN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "86")]
	public Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "87")]
	public Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "88")]
	public void AFCAJNFFHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "89")]
	public void MKALHOHGPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "90")]
	public void KKFKLNMJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "91")]
	public void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "92")]
	public void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "93")]
	public void MFJEJHNKAAO(Vector3 EEPMGGAMMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "94")]
	public void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "95")]
	public void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "96")]
	public void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "97")]
	public Vector3 MJHIJDKBEBN(Vector3 MENBIMCLIOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x132BB00", Offset = "0x132A300", VA = "0x18132BB00", Slot = "98")]
	public Vector3 DNJKEGKNPCL(Vector3 MENBIMCLIOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "99")]
	public void BDOFOKEDCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "100")]
	public void JIADAFOBLOJ(AKPAKEJMCNB LGKFEACNPCO, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "101")]
	public void JKFFINDNBFC(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "104")]
	public void DEADAFLGDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "105")]
	public void OJDDIEONFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "106")]
	public void DPBNPPEAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "109")]
	public bool AKMPDAKLHKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "110")]
	public void EFEMKHDKMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "115")]
	public IDisposable DCLGFCOEFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "116")]
	public void NGCNAJEIOBN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "117")]
	public void HJPDMAGHGCM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "118")]
	public void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "121")]
	public void HLINOHCMAOK(Vector3 OCDLANKHJEL, Quaternion ONHAKCONDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "122")]
	public void JGCNGOMIAFD(Vector3 OJECHCGNLLP, Quaternion NEPCPOJAKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "123")]
	public bool JPFLEDFLNPC(float IJICPBHJJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "124")]
	public void NLLHBIAAMEO(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "125")]
	public void PIEMCLDGJBD(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "126")]
	public void FNHMFKFJJBB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "127")]
	public void EFFIDBKNFJH(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "128")]
	public void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "129")]
	public void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "130")]
	public void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "131")]
	public void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E770", Offset = "0x5A2CF70", VA = "0x185A2E770", Slot = "132")]
	public bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "133")]
	public void ACGNHPHLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public GDACEIIMIAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NFBAEOFNOLB : EOCMCKCGEEJ, HBPPGIEGCED
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6D962B0", Offset = "0x6D94AB0", VA = "0x186D962B0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6D96050", Offset = "0x6D94850", VA = "0x186D96050", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6D961D0", Offset = "0x6D949D0", VA = "0x186D961D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private AKPAKEJMCNB OPFEABGAGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6D95AF0", Offset = "0x6D942F0", VA = "0x186D95AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6D965A0", Offset = "0x6D94DA0", VA = "0x186D965A0")]
	public NFBAEOFNOLB(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6D96420", Offset = "0x6D94C20", VA = "0x186D96420", Slot = "6")]
	public void PFJCPAMONEK(AKPAKEJMCNB GJPBCFJDGCH, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6D962E0", Offset = "0x6D94AE0", VA = "0x186D962E0")]
	private void PFJCPAMONEK(OOIJGCADMAO GJPBCFJDGCH, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6D95F50", Offset = "0x6D94750", VA = "0x186D95F50", Slot = "7")]
	public void HINHLDOAKJB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6D95C20", Offset = "0x6D94420", VA = "0x186D95C20")]
	private Vector3 BIEENBDEKDM()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class CPFHLHHAHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5A213C0", Offset = "0x5A1FBC0", VA = "0x185A213C0")]
	public static NFBAEOFNOLB FAPEFNHAIGN(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class EFPJBMFHBCP : EOCMCKCGEEJ, CGOOPOPNOJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly JNGNMMOLKFF KKCMBFMKBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EGDLEMHFPJM GNFOOKBNIOK;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Transform HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5A24440", Offset = "0x5A22C40", VA = "0x185A24440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public LPLJHAHPEEF CCFKDBKBIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5A25070", Offset = "0x5A23870", VA = "0x185A25070")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5A24D30", Offset = "0x5A23530", VA = "0x185A24D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5A23F80", Offset = "0x5A22780", VA = "0x185A23F80", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5A23250", Offset = "0x5A21A50", VA = "0x185A23250", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LPLJHAHPEEF INFFPALINAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5A24E30", Offset = "0x5A23630", VA = "0x185A24E30")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5A240B0", Offset = "0x5A228B0", VA = "0x185A240B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5A23170", Offset = "0x5A21970", VA = "0x185A23170", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event BKKLCHMMMPO HIAKNGJBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5A24300", Offset = "0x5A22B00", VA = "0x185A24300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5A23030", Offset = "0x5A21830", VA = "0x185A23030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event BKKLCHMMMPO AMONPALDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5A24FD0", Offset = "0x5A237D0", VA = "0x185A24FD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5A25210", Offset = "0x5A23A10", VA = "0x185A25210", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event CPNLBCPAMIE FHMNKCMGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5A23D00", Offset = "0x5A22500", VA = "0x185A23D00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5A248B0", Offset = "0x5A230B0", VA = "0x185A248B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action PJNPOLFAFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5A24F30", Offset = "0x5A23730", VA = "0x185A24F30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5A24470", Offset = "0x5A22C70", VA = "0x185A24470", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action FPPAMAPICNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5A24AF0", Offset = "0x5A232F0", VA = "0x185A24AF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5A243A0", Offset = "0x5A22BA0", VA = "0x185A243A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<AKPAKEJMCNB> DHJFGGHKMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5A24510", Offset = "0x5A22D10", VA = "0x185A24510", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5A231B0", Offset = "0x5A219B0", VA = "0x185A231B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<AKPAKEJMCNB> LMAPAMAFAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5A246E0", Offset = "0x5A22EE0", VA = "0x185A246E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5A23AF0", Offset = "0x5A222F0", VA = "0x185A23AF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action KPJPGGONCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5A24260", Offset = "0x5A22A60", VA = "0x185A24260", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5A23C60", Offset = "0x5A22460", VA = "0x185A23C60", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<AKPAKEJMCNB> GDGGFNPJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5A25170", Offset = "0x5A23970", VA = "0x185A25170", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5A230D0", Offset = "0x5A218D0", VA = "0x185A230D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5A25340", Offset = "0x5A23B40", VA = "0x185A25340")]
	public EFPJBMFHBCP(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5A23DA0", Offset = "0x5A225A0", VA = "0x185A23DA0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A24030", Offset = "0x5A22830", VA = "0x185A24030", Slot = "26")]
	public void EALODDMPHDN(AKPAKEJMCNB ILLDOGNGNOD, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5A23FC0", Offset = "0x5A227C0", VA = "0x185A23FC0")]
	private void EALODDMPHDN(OOIJGCADMAO ILLDOGNGNOD, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5A234C0", Offset = "0x5A21CC0", VA = "0x185A234C0")]
	private void BBBGOPEAOLP(OOIJGCADMAO ILLDOGNGNOD, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5A24950", Offset = "0x5A23150", VA = "0x185A24950")]
	private void MADHPOOKIMJ(OOIJGCADMAO LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5A24B90", Offset = "0x5A23390", VA = "0x185A24B90")]
	private void NKGELCCJPPJ(OOIJGCADMAO LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A232C0", Offset = "0x5A21AC0", VA = "0x185A232C0")]
	private void BABCGJOJNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5A23B90", Offset = "0x5A22390", VA = "0x185A23B90")]
	private void CHOBMOLMBHF(OOIJGCADMAO LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5A241B0", Offset = "0x5A229B0", VA = "0x185A241B0")]
	private void FAOKGKCIFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A245B0", Offset = "0x5A22DB0", VA = "0x185A245B0")]
	private void IFGNKHDPNPM(OOIJGCADMAO KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5A24780", Offset = "0x5A22F80", VA = "0x185A24780")]
	private void KNCIMBFFAPF(OOIJGCADMAO KLEOGNMJFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class BGGOPKBCFMJ
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5A19A80", Offset = "0x5A18280", VA = "0x185A19A80")]
	public static EFPJBMFHBCP EAFOKJKFLFJ(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class OOIJGCADMAO : FNPFPKJAEFL, KBFDDENCLAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal HCOBHGJLPEC FJADOINEFDC;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D98810", Offset = "0x6D97010", VA = "0x186D98810")]
	public OOIJGCADMAO(GameObject OAOEKKJFJKH, RigidbodyEx HNIHEJEANNM, JBIENGFNALE OAFFOBLPFIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D98530", Offset = "0x6D96D30", VA = "0x186D98530", Slot = "135")]
	protected override void PCCOFNIADNN(JBIENGFNALE OAFFOBLPFIG, LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "141")]
	protected override IDisposable ELMHODLNPCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D97F00", Offset = "0x6D96700", VA = "0x186D97F00", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D98330", Offset = "0x6D96B30", VA = "0x186D98330", Slot = "142")]
	public void JNNBPIJMIEA(LNBFOKMABPL MMOFNBHFDNB, LNBFOKMABPL MAIOOLBIJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D97E40", Offset = "0x6D96640", VA = "0x186D97E40", Slot = "143")]
	public void DLJENAHFIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D98270", Offset = "0x6D96A70", VA = "0x186D98270", Slot = "144")]
	public void JIGHMIOOHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D981B0", Offset = "0x6D969B0", VA = "0x186D981B0", Slot = "145")]
	public void EECOEHINOGD(bool JMCPMHHMAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D983F0", Offset = "0x6D96BF0", VA = "0x186D983F0", Slot = "146")]
	public bool OBEPMJOPCLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D98210", Offset = "0x6D96A10", VA = "0x186D98210", Slot = "147")]
	public void EFHAKCGIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "140")]
	protected override void JMMEGHKEPMO(RigidbodyEx FFEHKCANNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D97FD0", Offset = "0x6D967D0", VA = "0x186D97FD0")]
	private void EDGJDEAFFIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class HMCLFNEMJHN
{
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A36B60", Offset = "0x5A35360", VA = "0x185A36B60")]
	public static FNPFPKJAEFL ENPJJKJFADF(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IGLNGIBDPJG : EOCMCKCGEEJ, BHLMJHGKFAD
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool CLEPFPONEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A4C0", Offset = "0x5A38CC0", VA = "0x185A3A4C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public NNAEKKHECGM MPEFEKMEMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A630", Offset = "0x5A38E30", VA = "0x185A3A630", Slot = "11")]
		get
		{
			return default(NNAEKKHECGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private NNAEKKHECGM POMNDBNLECA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A39E40", Offset = "0x5A38640", VA = "0x185A39E40")]
		get
		{
			return default(NNAEKKHECGM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A140", Offset = "0x5A38940", VA = "0x185A3A140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A740", Offset = "0x5A38F40", VA = "0x185A3A740")]
	public IGLNGIBDPJG(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A3C0", Offset = "0x5A38BC0", VA = "0x185A3A3C0", Slot = "4")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A590", Offset = "0x5A38D90", VA = "0x185A3A590")]
	private bool LJDICJJMEOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A640", Offset = "0x5A38E40", VA = "0x185A3A640", Slot = "5")]
	public void PIHGBPNJOHD(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A040", Offset = "0x5A38840", VA = "0x185A3A040", Slot = "6")]
	public void FDJBAOKPDJB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A39D30", Offset = "0x5A38530", VA = "0x185A39D30", Slot = "9")]
	public void AGMANOOHJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5A39F50", Offset = "0x5A38750", VA = "0x185A39F50")]
	private void DELLJMKFCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A230", Offset = "0x5A38A30", VA = "0x185A3A230")]
	private void JPKAGKBADBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A480", Offset = "0x5A38C80", VA = "0x185A3A480", Slot = "8")]
	public void KKCPPLBKLPM(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A39F10", Offset = "0x5A38710", VA = "0x185A39F10", Slot = "7")]
	public void DADDKKKDJOH(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HDIKBOCLOJH : EOCMCKCGEEJ, BLIOHBLGLJI
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D250", Offset = "0x5A1BA50", VA = "0x185A1D250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A32620", Offset = "0x5A30E20", VA = "0x185A32620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A1AC70", Offset = "0x5A19470", VA = "0x185A1AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A31780", Offset = "0x5A2FF80", VA = "0x185A31780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public HDIKBOCLOJH(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A320E0", Offset = "0x5A308E0", VA = "0x185A320E0", Slot = "4")]
	public void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A32240", Offset = "0x5A30A40", VA = "0x185A32240")]
	private void HMOLFFPLPDI(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5A317E0", Offset = "0x5A2FFE0", VA = "0x185A317E0", Slot = "5")]
	public void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5A31F80", Offset = "0x5A30780", VA = "0x185A31F80", Slot = "6")]
	public void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5A31A80", Offset = "0x5A30280", VA = "0x185A31A80")]
	private void FDJPBIAOFBI(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5A31D00", Offset = "0x5A30500", VA = "0x185A31D00", Slot = "7")]
	public void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5A32530", Offset = "0x5A30D30", VA = "0x185A32530")]
	private void MFCLMPLONOJ(string AKADEFDGONP, UnityEngine.Object HNBDDLBIIOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class BHPHOPIHDEI : EOCMCKCGEEJ, EFOPFPCNKBB
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5A1A220", Offset = "0x5A18A20", VA = "0x185A1A220", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5A1A550", Offset = "0x5A18D50", VA = "0x185A1A550")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5A1AC70", Offset = "0x5A19470", VA = "0x185A1AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CHLOKOHCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5A1A840", Offset = "0x5A19040", VA = "0x185A1A840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5A1AEA0", Offset = "0x5A196A0", VA = "0x185A1AEA0")]
	public BHPHOPIHDEI(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ABC0", Offset = "0x5A193C0", VA = "0x185A1ABC0", Slot = "5")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A740", Offset = "0x5A18F40", VA = "0x185A1A740", Slot = "7")]
	public void FNHMFKFJJBB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A640", Offset = "0x5A18E40", VA = "0x185A1A640", Slot = "8")]
	public void EFFIDBKNFJH(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A910", Offset = "0x5A19110", VA = "0x185A1A910", Slot = "9")]
	public void JLCNCHCBIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A1A2F0", Offset = "0x5A18AF0", VA = "0x185A1A2F0", Slot = "11")]
	public void EAGNMGLAHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ACD0", Offset = "0x5A194D0", VA = "0x185A1ACD0", Slot = "12")]
	public void NOBMLPENOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "10")]
	public void LGKKAHMHJJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class FGELKNJGKAN : EOCMCKCGEEJ, GJPEMKFINBD
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5A271D0", Offset = "0x5A259D0", VA = "0x185A271D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private bool DBENELNKFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5A26F10", Offset = "0x5A25710", VA = "0x185A26F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event BKKLCHMMMPO MKAFGOIDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5A26D70", Offset = "0x5A25570", VA = "0x185A26D70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5A26CD0", Offset = "0x5A254D0", VA = "0x185A26CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public FGELKNJGKAN(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A26C60", Offset = "0x5A25460", VA = "0x185A26C60", Slot = "11")]
	public IDisposable DCLGFCOEFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A26FE0", Offset = "0x5A257E0", VA = "0x185A26FE0", Slot = "8")]
	public void NGCNAJEIOBN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A26CC0", Offset = "0x5A254C0", VA = "0x185A26CC0", Slot = "9")]
	public void HJPDMAGHGCM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A26E10", Offset = "0x5A25610", VA = "0x185A26E10", Slot = "10")]
	public void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A26A90", Offset = "0x5A25290", VA = "0x185A26A90", Slot = "12")]
	public void CCJGAKFHEKJ(Rigidbody JICGNHIFHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A26FF0", Offset = "0x5A257F0", VA = "0x185A26FF0", Slot = "13")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ED60", Offset = "0x5A1D560", VA = "0x185A1ED60", Slot = "6")]
	public void LCKDCFBABOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HKLHHCBJBIH : EOCMCKCGEEJ, FHFHCPDLIAC
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private CollisionDetectionMode MCAFNODADMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5A32B40", Offset = "0x5A31340", VA = "0x185A32B40")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5A32C10", Offset = "0x5A31410", VA = "0x185A32C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D250", Offset = "0x5A1BA50", VA = "0x185A1D250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CollisionDetectionMode OCGEKFIJCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5A33010", Offset = "0x5A31810", VA = "0x185A33010", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5A32AC0", Offset = "0x5A312C0", VA = "0x185A32AC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public HKLHHCBJBIH(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5A32D00", Offset = "0x5A31500", VA = "0x185A32D00", Slot = "6")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5A328C0", Offset = "0x5A310C0", VA = "0x185A328C0", Slot = "9")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5A328B0", Offset = "0x5A310B0", VA = "0x185A328B0", Slot = "7")]
	public void ANEEKHEMGCN(bool LJKNFCFGHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5A33120", Offset = "0x5A31920", VA = "0x185A33120", Slot = "8")]
	public void PHDHOHJEEID(bool LJKNFCFGHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5A32950", Offset = "0x5A31150", VA = "0x185A32950", Slot = "10")]
	public bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5A32E10", Offset = "0x5A31610", VA = "0x185A32E10")]
	private void MGCNJHCCFFN(bool LJKNFCFGHFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DefaultMember("Item")]
public sealed class EGDLEMHFPJM : IReadOnlyList<AKPAKEJMCNB>, IEnumerable<AKPAKEJMCNB>, IEnumerable, IReadOnlyCollection<AKPAKEJMCNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly HCOBHGJLPEC DBAHNFPKFPM;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A256E0", Offset = "0x5A23EE0", VA = "0x185A256E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public AKPAKEJMCNB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5A257B0", Offset = "0x5A23FB0", VA = "0x185A257B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5A25690", Offset = "0x5A23E90", VA = "0x185A25690")]
	public EGDLEMHFPJM(LPLJHAHPEEF PMFGMJJBADH, HCOBHGJLPEC DBAHNFPKFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5A25500", Offset = "0x5A23D00", VA = "0x185A25500", Slot = "6")]
	public IEnumerator<AKPAKEJMCNB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5A25500", Offset = "0x5A23D00", VA = "0x185A25500", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5A254F0", Offset = "0x5A23CF0", VA = "0x185A254F0")]
	[CompilerGenerated]
	private AKPAKEJMCNB CPJJAIMLLGF(int NLNOELCPLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EKDPCLJALJO : LOJAGMFINDG
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5A262C0", Offset = "0x5A24AC0", VA = "0x185A262C0", Slot = "4")]
	public CGOOPOPNOJO PHOFNEKNNNH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5A25C50", Offset = "0x5A24450", VA = "0x185A25C50", Slot = "5")]
	public LANDKDCHLLJ FKALCADODMK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5A260C0", Offset = "0x5A248C0", VA = "0x185A260C0", Slot = "6")]
	public HBPPGIEGCED JKGLPFCGEGB(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5A25EA0", Offset = "0x5A246A0", VA = "0x185A25EA0", Slot = "7")]
	public BLDDGFDICNL JCDNPNIAGHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5A26260", Offset = "0x5A24A60", VA = "0x185A26260", Slot = "8")]
	public IPCMKIOFGLK NMMMIOCGEKK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5A25E00", Offset = "0x5A24600", VA = "0x185A25E00", Slot = "9")]
	public FBMHFJKGPFK IEBCGGCMFNG(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5A25D60", Offset = "0x5A24560", VA = "0x185A25D60", Slot = "10")]
	public GJPEMKFINBD IDKHNADJKHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5A26120", Offset = "0x5A24920", VA = "0x185A26120", Slot = "11")]
	public BLIOHBLGLJI KJFCMMFDBHH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5A261C0", Offset = "0x5A249C0", VA = "0x185A261C0", Slot = "12")]
	public FHFHCPDLIAC LLLLJJGLNHD(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5A259D0", Offset = "0x5A241D0", VA = "0x185A259D0", Slot = "13")]
	public LOEDKPJOLCN BGOALPEAHCL(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5A25A70", Offset = "0x5A24270", VA = "0x185A25A70")]
	public EFOPFPCNKBB HGKMPKMJCJF(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5A25960", Offset = "0x5A24160", VA = "0x185A25960")]
	public LCHNDCKOECL FJMODFIMAEI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5A25F40", Offset = "0x5A24740", VA = "0x185A25F40")]
	public BHLMJHGKFAD JFNBEHDHEBH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5A25BE0", Offset = "0x5A243E0", VA = "0x185A25BE0")]
	public GCLEJFKMCNI JOKJIGHCNAL(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5A25CF0", Offset = "0x5A244F0", VA = "0x185A25CF0")]
	public EDCPAEHNJPE MOHAEICDOFM(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5A25B30", Offset = "0x5A24330", VA = "0x185A25B30", Slot = "19")]
	public AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN, JBIENGFNALE OAFFOBLPFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public EKDPCLJALJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5A25A70", Offset = "0x5A24270", VA = "0x185A25A70", Slot = "14")]
	private EFOPFPCNKBB COOIGNFPEHP(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5A25960", Offset = "0x5A24160", VA = "0x185A25960", Slot = "15")]
	private LCHNDCKOECL AMOPGMLMPHG(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5A25F40", Offset = "0x5A24740", VA = "0x185A25F40", Slot = "16")]
	private BHLMJHGKFAD MAIKEEGNLCI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5A25BE0", Offset = "0x5A243E0", VA = "0x185A25BE0", Slot = "17")]
	private GCLEJFKMCNI EBBIEFCIACH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5A25CF0", Offset = "0x5A244F0", VA = "0x185A25CF0", Slot = "18")]
	private EDCPAEHNJPE GIALJMAEFKB(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class KLFHLOHMOBE : EOCMCKCGEEJ, IPCMKIOFGLK
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D250", Offset = "0x5A1BA50", VA = "0x185A1D250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool PLOJOLEFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2EF60", Offset = "0x5A2D760", VA = "0x185A2EF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B330", Offset = "0x5A39B30", VA = "0x185A3B330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B980", Offset = "0x5A3A180", VA = "0x185A3B980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private bool EPPCAOHFMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B8B0", Offset = "0x5A3A0B0", VA = "0x185A3B8B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B020", Offset = "0x5A39820", VA = "0x185A3B020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private bool PCKFGPBKOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B440", Offset = "0x5A39C40", VA = "0x185A3B440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B670", Offset = "0x5A39E70", VA = "0x185A3B670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private int GNJHLHNKHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B9E0", Offset = "0x5A3A1E0", VA = "0x185A3B9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event BKKLCHMMMPO MLNFNBBFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5A3BAD0", Offset = "0x5A3A2D0", VA = "0x185A3BAD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5A3B810", Offset = "0x5A3A010", VA = "0x185A3B810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BC30", Offset = "0x5A3A430", VA = "0x185A3BC30")]
	public KLFHLOHMOBE(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B760", Offset = "0x5A39F60", VA = "0x185A3B760", Slot = "6")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BB70", Offset = "0x5A3A370", VA = "0x185A3BB70", Slot = "8")]
	public void NBEFMJDNBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B110", Offset = "0x5A39910", VA = "0x185A3B110", Slot = "7")]
	public bool AKMPDAKLHKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BB80", Offset = "0x5A3A380", VA = "0x185A3BB80", Slot = "9")]
	public void OLEEDMGNOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5A1ED60", Offset = "0x5A1D560", VA = "0x185A1ED60", Slot = "12")]
	public void EECOEHINOGD(bool JMCPMHHMAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B390", Offset = "0x5A39B90", VA = "0x185A3B390", Slot = "11")]
	public void EFEMKHDKMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "10")]
	public void EOLLPCOJDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B510", Offset = "0x5A39D10", VA = "0x185A3B510")]
	private void FFLDMLJOGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KHNAILLFHGJ(typeof(LOJAGMFINDG), new string[] { })]
public class EBHIIFONCGL : LOJAGMFINDG, NOFCHOCEBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LOJAGMFINDG AGFADBMLAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LOJAGMFINDG ODAMNCBMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private KANIKAONFJI JDHDNBAMDPL;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private LOJAGMFINDG MBIMOONHHME
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5A223E0", Offset = "0x5A20BE0", VA = "0x185A223E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5A22AD0", Offset = "0x5A212D0", VA = "0x185A22AD0", Slot = "20")]
	public void InitReferences(NCFCHDEHMHC KGMNNCCACLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5A22EF0", Offset = "0x5A216F0", VA = "0x185A22EF0", Slot = "4")]
	public CGOOPOPNOJO PHOFNEKNNNH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5A22840", Offset = "0x5A21040", VA = "0x185A22840", Slot = "5")]
	public LANDKDCHLLJ FKALCADODMK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5A22C70", Offset = "0x5A21470", VA = "0x185A22C70", Slot = "6")]
	public HBPPGIEGCED JKGLPFCGEGB(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5A22B20", Offset = "0x5A21320", VA = "0x185A22B20", Slot = "7")]
	public BLDDGFDICNL JCDNPNIAGHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5A22E50", Offset = "0x5A21650", VA = "0x185A22E50", Slot = "8")]
	public IPCMKIOFGLK NMMMIOCGEKK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5A22A30", Offset = "0x5A21230", VA = "0x185A22A30", Slot = "9")]
	public FBMHFJKGPFK IEBCGGCMFNG(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5A22990", Offset = "0x5A21190", VA = "0x185A22990", Slot = "10")]
	public GJPEMKFINBD IDKHNADJKHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5A22D10", Offset = "0x5A21510", VA = "0x185A22D10", Slot = "11")]
	public BLIOHBLGLJI KJFCMMFDBHH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5A22DB0", Offset = "0x5A215B0", VA = "0x185A22DB0", Slot = "12")]
	public FHFHCPDLIAC LLLLJJGLNHD(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5A224F0", Offset = "0x5A20CF0", VA = "0x185A224F0", Slot = "13")]
	public LOEDKPJOLCN BGOALPEAHCL(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5A22590", Offset = "0x5A20D90", VA = "0x185A22590")]
	public EFOPFPCNKBB HGKMPKMJCJF(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5A22440", Offset = "0x5A20C40", VA = "0x185A22440")]
	public LCHNDCKOECL FJMODFIMAEI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5A22BC0", Offset = "0x5A213C0", VA = "0x185A22BC0")]
	public BHLMJHGKFAD JFNBEHDHEBH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5A22790", Offset = "0x5A20F90", VA = "0x185A22790")]
	public GCLEJFKMCNI JOKJIGHCNAL(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5A228E0", Offset = "0x5A210E0", VA = "0x185A228E0")]
	public EDCPAEHNJPE MOHAEICDOFM(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5A22640", Offset = "0x5A20E40", VA = "0x185A22640", Slot = "19")]
	public AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN, JBIENGFNALE OAFFOBLPFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5A22F90", Offset = "0x5A21790", VA = "0x185A22F90")]
	public EBHIIFONCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5A22590", Offset = "0x5A20D90", VA = "0x185A22590", Slot = "14")]
	private EFOPFPCNKBB COOIGNFPEHP(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5A22440", Offset = "0x5A20C40", VA = "0x185A22440", Slot = "15")]
	private LCHNDCKOECL AMOPGMLMPHG(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5A22BC0", Offset = "0x5A213C0", VA = "0x185A22BC0", Slot = "16")]
	private BHLMJHGKFAD MAIKEEGNLCI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5A22790", Offset = "0x5A20F90", VA = "0x185A22790", Slot = "17")]
	private GCLEJFKMCNI EBBIEFCIACH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5A228E0", Offset = "0x5A210E0", VA = "0x185A228E0", Slot = "18")]
	private EDCPAEHNJPE GIALJMAEFKB(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EPAKGPHKGHC : EOCMCKCGEEJ, LOEDKPJOLCN
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool MNGNMLJNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5A26600", Offset = "0x5A24E00", VA = "0x185A26600", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5A267D0", Offset = "0x5A24FD0", VA = "0x185A267D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public EPAKGPHKGHC(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5A266D0", Offset = "0x5A24ED0", VA = "0x185A266D0", Slot = "6")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5A18B60", Offset = "0x5A17360", VA = "0x185A18B60", Slot = "7")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class EOCMCKCGEEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly OOIJGCADMAO KLEOGNMJFCE;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected HCOBHGJLPEC EECEBNLKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5A26490", Offset = "0x5A24C90", VA = "0x185A26490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5A265D0", Offset = "0x5A24DD0", VA = "0x185A265D0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public EOCMCKCGEEJ(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5A264B0", Offset = "0x5A24CB0", VA = "0x185A264B0")]
	protected AKPAKEJMCNB CFFEELJPKOE(LPLJHAHPEEF PMFGMJJBADH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class OGGEKOOLLPD : EOCMCKCGEEJ, LCHNDCKOECL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PhotonView DNKOGNNJHGM;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5A199C0", Offset = "0x5A181C0", VA = "0x185A199C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6D973F0", Offset = "0x6D95BF0", VA = "0x186D973F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event BKKLCHMMMPO LGMNOFJACDE
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6D97690", Offset = "0x6D95E90", VA = "0x186D97690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6D97150", Offset = "0x6D95950", VA = "0x186D97150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6D97D80", Offset = "0x6D96580", VA = "0x186D97D80")]
	public OGGEKOOLLPD(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6D97910", Offset = "0x6D96110", VA = "0x186D97910", Slot = "8")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6D971F0", Offset = "0x6D959F0", VA = "0x186D971F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6D97520", Offset = "0x6D95D20", VA = "0x186D97520", Slot = "9")]
	public void GGNOKCGFCAC(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6D97B80", Offset = "0x6D96380", VA = "0x186D97B80", Slot = "10")]
	public void LKCFBPNEIIF(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6D97A60", Offset = "0x6D96260", VA = "0x186D97A60")]
	private void KOKLIEBHCLO(PhotonView IPALMNAFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6D97CF0", Offset = "0x6D964F0", VA = "0x186D97CF0")]
	private void LOPAFMANKFN(RigidbodyEx CKJCMMKDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6D97730", Offset = "0x6D95F30", VA = "0x186D97730")]
	private void JJMDGNGINPN(PhotonView JMMJOHIEJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class DBNNMHKICKI
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5A218F0", Offset = "0x5A200F0", VA = "0x185A218F0")]
	public static OGGEKOOLLPD GDJEIJCNANO(this FNPFPKJAEFL PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class DIACEMNDFEM : EOCMCKCGEEJ, EDCPAEHNJPE
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x5A220E0", Offset = "0x5A208E0", VA = "0x185A220E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5A21EF0", Offset = "0x5A206F0", VA = "0x185A21EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool DABGOPGBGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x5A21E20", Offset = "0x5A20620", VA = "0x185A21E20", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5A21950", Offset = "0x5A20150", VA = "0x185A21950")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints MMPKMGKHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5A21D50", Offset = "0x5A20550", VA = "0x185A21D50", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x5A21B40", Offset = "0x5A20340", VA = "0x185A21B40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5A221B0", Offset = "0x5A209B0", VA = "0x185A221B0")]
	public DIACEMNDFEM(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5A21A40", Offset = "0x5A20240", VA = "0x185A21A40", Slot = "9")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5A21FE0", Offset = "0x5A207E0", VA = "0x185A21FE0", Slot = "10")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class BIIKCNOHHLH : EOCMCKCGEEJ, FBMHFJKGPFK, IDisposable, EECIICGPDHK
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public JOKBKMCLMIE DOIPLKNHIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B1E0", Offset = "0x5A199E0", VA = "0x185A1B1E0")]
		get
		{
			return default(JOKBKMCLMIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B2B0", Offset = "0x5A19AB0", VA = "0x185A1B2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x5A1AFD0", Offset = "0x5A197D0", VA = "0x185A1AFD0", Slot = "6")]
		get
		{
			return default(JOKBKMCLMIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B2B0", Offset = "0x5A19AB0", VA = "0x185A1B2B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private Transform JAMGCHOFJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B3A0", Offset = "0x5A19BA0", VA = "0x185A1B3A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5A1AF30", Offset = "0x5A19730", VA = "0x185A1AF30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B4A0", Offset = "0x5A19CA0", VA = "0x185A1B4A0")]
	public BIIKCNOHHLH(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B440", Offset = "0x5A19C40", VA = "0x185A1B440", Slot = "11")]
	public void OnChangedDistanceBand(DOFNHLHKMBC MMOFNBHFDNB, DOFNHLHKMBC MAIOOLBIJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "12")]
	public void OnChangedVisibility(bool BIGEBELPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class KMEIGFGAGAG : FBMHFJKGPFK, IDisposable, EECIICGPDHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private JOKBKMCLMIE IJDPIPLEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private GNNADOJEIPI GHPALGLCMMF;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public JOKBKMCLMIE BLNAIHIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x5A3BF30", Offset = "0x5A3A730", VA = "0x185A3BF30", Slot = "6")]
		get
		{
			return default(JOKBKMCLMIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x5A3C450", Offset = "0x5A3AC50", VA = "0x185A3C450", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private Transform JAMGCHOFJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x5A3BF10", Offset = "0x5A3A710", VA = "0x185A3BF10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<DOFNHLHKMBC, DOFNHLHKMBC> GANLFEOHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5A3C350", Offset = "0x5A3AB50", VA = "0x185A3C350", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5A3BE20", Offset = "0x5A3A620", VA = "0x185A3BE20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C520", Offset = "0x5A3AD20", VA = "0x185A3C520")]
	public KMEIGFGAGAG(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C070", Offset = "0x5A3A870", VA = "0x185A3C070", Slot = "8")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5A3BEC0", Offset = "0x5A3A6C0", VA = "0x185A3BEC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C3F0", Offset = "0x5A3ABF0", VA = "0x185A3C3F0", Slot = "11")]
	private void MHPCDMFKCPA(DOFNHLHKMBC MFLEOKKEBPK, DOFNHLHKMBC KGDFMKBNLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "12")]
	private void KNGGHIMNMJP(bool BIGEBELPANE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class AHDOFDCBALI : LACNGNLFBEF, LCHNDCKOECL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PhotonView DNKOGNNJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool HHBONDDOKMO;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PhotonView MLMKKIMLECH
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool CHJBBOLJPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5A199C0", Offset = "0x5A181C0", VA = "0x185A199C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool GKMPJAPBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event BKKLCHMMMPO LGMNOFJACDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x5A190B0", Offset = "0x5A178B0", VA = "0x185A190B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5A18D70", Offset = "0x5A17570", VA = "0x185A18D70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5A199E0", Offset = "0x5A181E0", VA = "0x185A199E0")]
	public AHDOFDCBALI(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5A193E0", Offset = "0x5A17BE0", VA = "0x185A193E0", Slot = "9")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5A18E10", Offset = "0x5A17610", VA = "0x185A18E10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5A18F20", Offset = "0x5A17720", VA = "0x185A18F20", Slot = "10")]
	public void GGNOKCGFCAC(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5A196B0", Offset = "0x5A17EB0", VA = "0x185A196B0", Slot = "11")]
	public void LKCFBPNEIIF(AKPAKEJMCNB GJPBCFJDGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5A19530", Offset = "0x5A17D30", VA = "0x185A19530")]
	private void KOKLIEBHCLO(PhotonView IPALMNAFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5A19840", Offset = "0x5A18040", VA = "0x185A19840")]
	private void LOPAFMANKFN(RigidbodyEx CKJCMMKDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5A19150", Offset = "0x5A17950", VA = "0x185A19150")]
	private void JJMDGNGINPN(PhotonView JMMJOHIEJDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal static class PKFJPHBOPJG
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6D99170", Offset = "0x6D97970", VA = "0x186D99170")]
	public static LACNGNLFBEF GDJEIJCNANO(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class GCBGAAIMKMK : EFOPFPCNKBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly JCAEGCAOHJG PAOHODMPCOL;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5A1AC70", Offset = "0x5A19470", VA = "0x185A1AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool CHLOKOHCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x10195E0", Offset = "0x1017DE0", VA = "0x1810195E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E680", Offset = "0x5A2CE80", VA = "0x185A2E680")]
	public GCBGAAIMKMK(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DFB0", Offset = "0x5A2C7B0", VA = "0x185A2DFB0", Slot = "5")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DC20", Offset = "0x5A2C420", VA = "0x185A2DC20", Slot = "7")]
	public void FNHMFKFJJBB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DA40", Offset = "0x5A2C240", VA = "0x185A2DA40", Slot = "8")]
	public void EFFIDBKNFJH(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DC50", Offset = "0x5A2C450", VA = "0x185A2DC50", Slot = "9")]
	public void JLCNCHCBIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D840", Offset = "0x5A2C040", VA = "0x185A2D840", Slot = "11")]
	public void EAGNMGLAHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E500", Offset = "0x5A2CD00", VA = "0x185A2E500", Slot = "12")]
	public void NOBMLPENOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E060", Offset = "0x5A2C860", VA = "0x185A2E060", Slot = "10")]
	public void LGKKAHMHJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x5A2DA70", Offset = "0x5A2C270", VA = "0x185A2DA70")]
	private void FJFPDBLPBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D690", Offset = "0x5A2BE90", VA = "0x185A2D690")]
	private void CGCLLLNEOIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class HJOAOJLGPIG : EDCPAEHNJPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private RigidbodyConstraints DCLENAIADPL;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool KDACLMIFKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xB7C640", Offset = "0xB7AE40", VA = "0x180B7C640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x20E50A0", Offset = "0x20E38A0", VA = "0x1820E50A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool DABGOPGBGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x20E50B0", Offset = "0x20E38B0", VA = "0x1820E50B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x20E5090", Offset = "0x20E3890", VA = "0x1820E5090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public RigidbodyConstraints MMPKMGKHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5A326A0", Offset = "0x5A30EA0", VA = "0x185A326A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5A32810", Offset = "0x5A31010", VA = "0x185A32810")]
	public HJOAOJLGPIG(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5A32670", Offset = "0x5A30E70", VA = "0x185A32670", Slot = "9")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5A327E0", Offset = "0x5A30FE0", VA = "0x185A327E0", Slot = "10")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class NKHHAEHCCJE : BLIOHBLGLJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6D965B0", Offset = "0x6D94DB0", VA = "0x186D965B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6D97070", Offset = "0x6D95870", VA = "0x186D97070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D97050", Offset = "0x6D95850", VA = "0x186D97050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D965D0", Offset = "0x6D94DD0", VA = "0x186D965D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D97090", Offset = "0x6D95890", VA = "0x186D97090")]
	public NKHHAEHCCJE(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D96D60", Offset = "0x6D95560", VA = "0x186D96D60", Slot = "4")]
	public void HEPFBPFANIO(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D96E50", Offset = "0x6D95650", VA = "0x186D96E50")]
	private void HMOLFFPLPDI(Vector3 BJDJJEPMPIM, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D96630", Offset = "0x6D94E30", VA = "0x186D96630", Slot = "5")]
	public void ENOEHCEKLLG(Vector3 BJDJJEPMPIM, Vector3 PAOMABBDKAH, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D96C40", Offset = "0x6D95440", VA = "0x186D96C40", Slot = "6")]
	public void HEMKGKMPAPE(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D96840", Offset = "0x6D95040", VA = "0x186D96840")]
	private void FDJPBIAOFBI(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D96A40", Offset = "0x6D95240", VA = "0x186D96A40", Slot = "7")]
	public void GGJNGNAHAAP(Vector3 CPBDPODOONA, ForceMode KDMHKJDJBIC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KPDLFOAJNDE : AJEOKDBCACN, HBPPGIEGCED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NOPNCOEIJNA<AKPAKEJMCNB> FODECPFAAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool OCKDEHBMPEN;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public NOPNCOEIJNA<AKPAKEJMCNB> BNCIJHLIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 EHIMNACIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5A3D050", Offset = "0x5A3B850", VA = "0x185A3D050", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 LEIMKDIGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5A3CDA0", Offset = "0x5A3B5A0", VA = "0x185A3CDA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3CF70", Offset = "0x5A3B770", VA = "0x185A3CF70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public AKPAKEJMCNB OPFEABGAGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5A3C5B0", Offset = "0x5A3ADB0", VA = "0x185A3C5B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D0F0", Offset = "0x5A3B8F0", VA = "0x185A3D0F0")]
	public KPDLFOAJNDE(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D080", Offset = "0x5A3B880", VA = "0x185A3D080", Slot = "8")]
	public void PFJCPAMONEK(AKPAKEJMCNB GJPBCFJDGCH, object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C990", Offset = "0x5A3B190", VA = "0x185A3C990", Slot = "9")]
	public void HINHLDOAKJB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C660", Offset = "0x5A3AE60", VA = "0x185A3C660")]
	private Vector3 BIEENBDEKDM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5A3C9F0", Offset = "0x5A3B1F0", VA = "0x185A3C9F0")]
	private void HPKFFCJCNMC(AKPAKEJMCNB ABCMBNLAEKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class NNLADEMGLEF
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D970D0", Offset = "0x6D958D0", VA = "0x186D970D0")]
	public static AJEOKDBCACN FAPEFNHAIGN(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class HMDIIOFBMME : IDNHOLKICPA, GCLEJFKMCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OverridableVector3 PIFGOLLJLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OverridableVector3 NMPHIMCIEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float OJBLBIFAIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float IOJLBENOPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Vector3 ELNDMEMCHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Vector3? IIFKPCGOIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Quaternion? JCNMPFHIMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool MFODBGFMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool IIFKKHANCCP;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 DLFKHCDFPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x122FF90", Offset = "0x122E790", VA = "0x18122FF90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x5A37900", Offset = "0x5A36100", VA = "0x185A37900", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 GBKOJFLKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A38C00", Offset = "0x5A37400", VA = "0x185A38C00", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float HOKFEOCNGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9780", Offset = "0x8A7F80", VA = "0x1808A9780", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5A38D10", Offset = "0x5A37510", VA = "0x185A38D10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float HBNNBDHLHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9790", Offset = "0x8A7F90", VA = "0x1808A9790", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5A37240", Offset = "0x5A35A40", VA = "0x185A37240", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 CEHIDOAGLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5A37620", Offset = "0x5A35E20", VA = "0x185A37620", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Quaternion CEOECAEDONN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A38E30", Offset = "0x5A37630", VA = "0x185A38E30", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5A37070", Offset = "0x5A35870", VA = "0x185A37070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event BKKLCHMMMPO PEJOIPBMLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5A370C0", Offset = "0x5A358C0", VA = "0x185A370C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5A393C0", Offset = "0x5A37BC0", VA = "0x185A393C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5A39460", Offset = "0x5A37C60", VA = "0x185A39460")]
	public HMDIIOFBMME(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5A372F0", Offset = "0x5A35AF0", VA = "0x185A372F0", Slot = "17")]
	public void DEADAFLGDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5A39190", Offset = "0x5A37990", VA = "0x185A39190", Slot = "16")]
	public void OJDDIEONFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5A37160", Offset = "0x5A35960", VA = "0x185A37160", Slot = "19")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A38FA0", Offset = "0x5A377A0", VA = "0x185A38FA0", Slot = "20")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5A374C0", Offset = "0x5A35CC0", VA = "0x185A374C0", Slot = "18")]
	public void DPBNPPEAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A36BB0", Offset = "0x5A353B0", VA = "0x185A36BB0", Slot = "21")]
	public void ACGNHPHLMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A37900", Offset = "0x5A36100", VA = "0x185A37900")]
	private void LHJKPFJNOJJ(Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5A392B0", Offset = "0x5A37AB0", VA = "0x185A392B0")]
	[Obsolete]
	private Vector3 PJEEJGGABIJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5A38D10", Offset = "0x5A37510", VA = "0x185A38D10")]
	private void LNFHKFLCFLA(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A37240", Offset = "0x5A35A40", VA = "0x185A37240")]
	private void IJDFPPHCBKN(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5A37790", Offset = "0x5A35F90", VA = "0x185A37790")]
	private Vector3 ECCFFPHGNIL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5A389C0", Offset = "0x5A371C0", VA = "0x185A389C0", Slot = "15")]
	public void JMKBKFIPMFM((Quaternion rot, Vector3 moments) CLIBLALIAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5A379B0", Offset = "0x5A361B0", VA = "0x185A379B0")]
	private Quaternion GKCCKIPLOBH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5A37B20", Offset = "0x5A36320", VA = "0x185A37B20")]
	public void JKAIIPECNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5A37C00", Offset = "0x5A36400", VA = "0x185A37C00", Slot = "4")]
	public (float, Vector3) JKAIIPECNDE(Rigidbody KPJEACPPCOE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class KDAELBAJOJD
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AED0", Offset = "0x5A396D0", VA = "0x185A3AED0")]
	public static IDNHOLKICPA BEOLNAIAMKF(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface AJEOKDBCACN : HBPPGIEGCED
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	NOPNCOEIJNA<AKPAKEJMCNB> BNCIJHLIJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	AKPAKEJMCNB OPFEABGAGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class GMBKAFLLNKD : LANDKDCHLLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JCAEGCAOHJG DCBNAEOEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float MLOOOCKJLNH;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public GOEGIKJGDDB KNNIBJCFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A97C0", Offset = "0x8A7FC0", VA = "0x1808A97C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public DLBCBPHCDEM JOALNHNOPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 PFGCKNBNHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5A30B40", Offset = "0x5A2F340", VA = "0x185A30B40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5A315E0", Offset = "0x5A2FDE0", VA = "0x185A315E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 NPJOEDJGBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x5A2F6D0", Offset = "0x5A2DED0", VA = "0x185A2F6D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x5A313C0", Offset = "0x5A2FBC0", VA = "0x185A313C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 HMKLLJOCLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x5A30830", Offset = "0x5A2F030", VA = "0x185A30830", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x5A2F610", Offset = "0x5A2DE10", VA = "0x185A2F610", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 EGCPGAMBAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x5A314F0", Offset = "0x5A2FCF0", VA = "0x185A314F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x5A2FB70", Offset = "0x5A2E370", VA = "0x185A2FB70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float AHCJBMNCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7ECDA0", Offset = "0x7EB5A0", VA = "0x1807ECDA0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x5A2F7C0", Offset = "0x5A2DFC0", VA = "0x185A2F7C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool HEOAKAHPFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9082F0", Offset = "0x906AF0", VA = "0x1809082F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private BLIOHBLGLJI GPKEGOCEHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2026BE0", Offset = "0x20253E0", VA = "0x182026BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private bool PLOJOLEFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x5A2EF60", Offset = "0x5A2D760", VA = "0x185A2EF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A316A0", Offset = "0x5A2FEA0", VA = "0x185A316A0")]
	public GMBKAFLLNKD(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E810", Offset = "0x5A2D010", VA = "0x185A2E810", Slot = "19")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EF00", Offset = "0x5A2D700", VA = "0x185A2EF00", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A2ED10", Offset = "0x5A2D510", VA = "0x185A2ED10", Slot = "28")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x907BC0", Offset = "0x9063C0", VA = "0x180907BC0", Slot = "20")]
	public void IHIEAEPOKJM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x907BE0", Offset = "0x9063E0", VA = "0x180907BE0", Slot = "30")]
	public void OBPBANLJNBF(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A30960", Offset = "0x5A2F160", VA = "0x185A30960", Slot = "35")]
	public Vector3 LJNHNOCAGJN(Vector3 IKNBMJJLOME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A30C60", Offset = "0x5A2F460", VA = "0x185A30C60", Slot = "34")]
	public Vector3 MFIGMAENOPG(Vector3 PJDFDKKMIAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E810", Offset = "0x5A2D010", VA = "0x185A2E810", Slot = "27")]
	public void AFCAJNFFHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A31080", Offset = "0x5A2F880", VA = "0x185A31080", Slot = "25")]
	public void MKALHOHGPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A304C0", Offset = "0x5A2ECC0", VA = "0x185A304C0", Slot = "24")]
	public void KKFKLNMJFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A305F0", Offset = "0x5A2EDF0", VA = "0x185A305F0", Slot = "33")]
	public void LFNPHDFHMEC(Vector3 HDPACBJMLEB, Vector3 LHMCCGHADBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F8E0", Offset = "0x5A2E0E0", VA = "0x185A2F8E0", Slot = "32")]
	public void GDIFHKNMIHL(Vector3 LNOCFHHMHGI, Vector3 BGCIGAGAEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A30E20", Offset = "0x5A2F620", VA = "0x185A30E20", Slot = "31")]
	public void MFJEJHNKAAO(Vector3 EEPMGGAMMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EF80", Offset = "0x5A2D780", VA = "0x185A2EF80", Slot = "22")]
	public void EJIHJFJFPHO(BHFNLKFHFPC PKDHEEJAPHN, Vector3 CEIMLLJAMLE, float KKBBBDDJBEF, float ICDAAODNOBK = 8f, float CEJHOCELLIL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F940", Offset = "0x5A2E140", VA = "0x185A2F940", Slot = "21")]
	public void GGGOEKGGDOB(JFEEFBCBMJF DPGAHOJHAGP, Vector3 MFOCPNHPHMO, float EKGEACGEPIN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A310C0", Offset = "0x5A2F8C0", VA = "0x185A310C0", Slot = "23")]
	[Obsolete]
	public void MMMMOCBPECO(JFEEFBCBMJF DPGAHOJHAGP, Vector3 APAHFEOKBOD, float KCLIIHDCHKM = 7f, float LOMEGCKIGPM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5A30FC0", Offset = "0x5A2F7C0", VA = "0x185A30FC0", Slot = "29")]
	public Vector3 MJHIJDKBEBN(Vector3 KFENDEDNACE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EBB0", Offset = "0x5A2D3B0", VA = "0x185A2EBB0", Slot = "26")]
	public void BDOFOKEDCAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F7C0", Offset = "0x5A2DFC0", VA = "0x185A2F7C0")]
	private void FHCNDHPPAAH(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5A2F470", Offset = "0x5A2DC70", VA = "0x185A2F470")]
	private void FAOLNCKPKFI(Vector3 MFOCPNHPHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5A30500", Offset = "0x5A2ED00", VA = "0x185A30500")]
	private Vector3 KOFJBNMBHEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FBA0", Offset = "0x5A2E3A0", VA = "0x185A2FBA0")]
	private void JDIKDPBGKIL(Vector3 PJDFDKKMIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5A313F0", Offset = "0x5A2FBF0", VA = "0x185A313F0")]
	private Vector3 OMBLOOEPIKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5A2E880", Offset = "0x5A2D080", VA = "0x185A2E880")]
	private void ANCGGGFGPDK(Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5A2FEC0", Offset = "0x5A2E6C0", VA = "0x185A2FEC0")]
	private void KCPLIABIADK(Vector3 PJDFDKKMIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5A2EE40", Offset = "0x5A2D640", VA = "0x185A2EE40")]
	private void CKEFKFLANCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class IMJGMIFKCGB : GJPEMKFINBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JCAEGCAOHJG OJNEJBECMAE;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool JFPOCPBHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AC50", Offset = "0x5A39450", VA = "0x185A3AC50", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event BKKLCHMMMPO MKAFGOIDMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3AA30", Offset = "0x5A39230", VA = "0x185A3AA30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A990", Offset = "0x5A39190", VA = "0x185A3A990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AD20", Offset = "0x5A39520", VA = "0x185A3AD20")]
	public IMJGMIFKCGB(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A920", Offset = "0x5A39120", VA = "0x185A3A920", Slot = "11")]
	public IDisposable DCLGFCOEFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AC10", Offset = "0x5A39410", VA = "0x185A3AC10", Slot = "8")]
	public void NGCNAJEIOBN(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A980", Offset = "0x5A39180", VA = "0x185A3A980", Slot = "9")]
	public void HJPDMAGHGCM(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AB10", Offset = "0x5A39310", VA = "0x185A3AB10", Slot = "10")]
	public void LPLEBFGJKHM(object AMCDGOPKAOE, bool KOHKILNBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AAD0", Offset = "0x5A392D0", VA = "0x185A3AAD0", Slot = "6")]
	public void LCKDCFBABOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5A3A8A0", Offset = "0x5A390A0", VA = "0x185A3A8A0", Slot = "12")]
	public void CCJGAKFHEKJ(Rigidbody JICGNHIFHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5A3AC20", Offset = "0x5A39420", VA = "0x185A3AC20", Slot = "13")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal sealed class CGKAEOKKPHE : FHFHCPDLIAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CollisionDetectionMode NOPLHLDNABA;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D250", Offset = "0x5A1BA50", VA = "0x185A1D250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CollisionDetectionMode OCGEKFIJCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D750", Offset = "0x5A1BF50", VA = "0x185A1D750", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D490", Offset = "0x5A1BC90", VA = "0x185A1D490", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D870", Offset = "0x5A1C070", VA = "0x185A1D870")]
	public CGKAEOKKPHE(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D500", Offset = "0x5A1BD00", VA = "0x185A1D500", Slot = "6")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D2A0", Offset = "0x5A1BAA0", VA = "0x185A1D2A0", Slot = "9")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D240", Offset = "0x5A1BA40", VA = "0x185A1D240", Slot = "7")]
	public void ANEEKHEMGCN(bool LJKNFCFGHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D860", Offset = "0x5A1C060", VA = "0x185A1D860", Slot = "8")]
	public void PHDHOHJEEID(bool LJKNFCFGHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D320", Offset = "0x5A1BB20", VA = "0x185A1D320", Slot = "10")]
	public bool CGAKABJIDBK(Vector3 JJEDPBPHNPK, out RaycastHit ACIOBOOOHBC, float BJICICOAOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D620", Offset = "0x5A1BE20", VA = "0x185A1D620")]
	private void MGCNJHCCFFN(bool LJKNFCFGHFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PFLFFLNHPEL : LOJAGMFINDG
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6D99110", Offset = "0x6D97910", VA = "0x186D99110", Slot = "4")]
	public CGOOPOPNOJO PHOFNEKNNNH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x6D98CE0", Offset = "0x6D974E0", VA = "0x186D98CE0", Slot = "5")]
	public LANDKDCHLLJ FKALCADODMK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x6D98F50", Offset = "0x6D97750", VA = "0x186D98F50", Slot = "6")]
	public HBPPGIEGCED JKGLPFCGEGB(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6D98E70", Offset = "0x6D97670", VA = "0x186D98E70", Slot = "7")]
	public BLDDGFDICNL JCDNPNIAGHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x6D99080", Offset = "0x6D97880", VA = "0x186D99080", Slot = "8")]
	public IPCMKIOFGLK NMMMIOCGEKK(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6D98E10", Offset = "0x6D97610", VA = "0x186D98E10", Slot = "9")]
	public FBMHFJKGPFK IEBCGGCMFNG(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6D98DB0", Offset = "0x6D975B0", VA = "0x186D98DB0", Slot = "10")]
	public GJPEMKFINBD IDKHNADJKHA(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6D98FB0", Offset = "0x6D977B0", VA = "0x186D98FB0", Slot = "11")]
	public BLIOHBLGLJI KJFCMMFDBHH(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6D99020", Offset = "0x6D97820", VA = "0x186D99020", Slot = "12")]
	public FHFHCPDLIAC LLLLJJGLNHD(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x6D98AF0", Offset = "0x6D972F0", VA = "0x186D98AF0", Slot = "13")]
	public LOEDKPJOLCN BGOALPEAHCL(AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6D98B50", Offset = "0x6D97350", VA = "0x186D98B50")]
	public EFOPFPCNKBB HGKMPKMJCJF(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6D98A80", Offset = "0x6D97280", VA = "0x186D98A80")]
	public LCHNDCKOECL FJMODFIMAEI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6D98EE0", Offset = "0x6D976E0", VA = "0x186D98EE0")]
	public BHLMJHGKFAD JFNBEHDHEBH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6D98C70", Offset = "0x6D97470", VA = "0x186D98C70")]
	public GCLEJFKMCNI JOKJIGHCNAL(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6D98D40", Offset = "0x6D97540", VA = "0x186D98D40")]
	public EDCPAEHNJPE MOHAEICDOFM(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6D98BC0", Offset = "0x6D973C0", VA = "0x186D98BC0", Slot = "19")]
	public AKPAKEJMCNB DMNLMLNEIBB(RigidbodyEx KLEOGNMJFCE, LPMCBAJFHEN NFBDMLCENEN, JBIENGFNALE OAFFOBLPFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PFLFFLNHPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6D98B50", Offset = "0x6D97350", VA = "0x186D98B50", Slot = "14")]
	private EFOPFPCNKBB COOIGNFPEHP(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6D98A80", Offset = "0x6D97280", VA = "0x186D98A80", Slot = "15")]
	private LCHNDCKOECL AMOPGMLMPHG(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6D98EE0", Offset = "0x6D976E0", VA = "0x186D98EE0", Slot = "16")]
	private BHLMJHGKFAD MAIKEEGNLCI(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x6D98C70", Offset = "0x6D97470", VA = "0x186D98C70", Slot = "17")]
	private GCLEJFKMCNI EBBIEFCIACH(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6D98D40", Offset = "0x6D97540", VA = "0x186D98D40", Slot = "18")]
	private EDCPAEHNJPE GIALJMAEFKB(AKPAKEJMCNB PBDNMEDOHIG, in LPMCBAJFHEN NFBDMLCENEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class CDCMEHGEPIJ : AFIHIJBJHOL, CGOOPOPNOJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly AKPAKEJMCNB KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<AKPAKEJMCNB> LHKEFPJAGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AKPAKEJMCNB CEABICNIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AKPAKEJMCNB GJPBCFJDGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform FPHBFELKNGA;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Transform HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C360", Offset = "0x5A1AB60", VA = "0x185A1C360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B780", Offset = "0x5A19F80", VA = "0x185A1B780", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public AKPAKEJMCNB AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IReadOnlyList<AKPAKEJMCNB> DKGJLABBNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event BKKLCHMMMPO HIAKNGJBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C220", Offset = "0x5A1AA20", VA = "0x185A1C220", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B5A0", Offset = "0x5A19DA0", VA = "0x185A1B5A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event BKKLCHMMMPO AMONPALDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CFA0", Offset = "0x5A1B7A0", VA = "0x185A1CFA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D0E0", Offset = "0x5A1B8E0", VA = "0x185A1D0E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event CPNLBCPAMIE FHMNKCMGCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B9A0", Offset = "0x5A1A1A0", VA = "0x185A1B9A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C7D0", Offset = "0x5A1AFD0", VA = "0x185A1C7D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action PJNPOLFAFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CF00", Offset = "0x5A1B700", VA = "0x185A1CF00", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C4B0", Offset = "0x5A1ACB0", VA = "0x185A1C4B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action FPPAMAPICNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5A1CCA0", Offset = "0x5A1B4A0", VA = "0x185A1CCA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C2C0", Offset = "0x5A1AAC0", VA = "0x185A1C2C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<AKPAKEJMCNB> DHJFGGHKMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C550", Offset = "0x5A1AD50", VA = "0x185A1C550", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B6E0", Offset = "0x5A19EE0", VA = "0x185A1B6E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<AKPAKEJMCNB> LMAPAMAFAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C690", Offset = "0x5A1AE90", VA = "0x185A1C690", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B820", Offset = "0x5A1A020", VA = "0x185A1B820", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action KPJPGGONCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C180", Offset = "0x5A1A980", VA = "0x185A1C180", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B900", Offset = "0x5A1A100", VA = "0x185A1B900", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<AKPAKEJMCNB> GDGGFNPJHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1D040", Offset = "0x5A1B840", VA = "0x185A1D040", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B640", Offset = "0x5A19E40", VA = "0x185A1B640", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5A1D180", Offset = "0x5A1B980", VA = "0x185A1D180")]
	public CDCMEHGEPIJ(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x5A1BA40", Offset = "0x5A1A240", VA = "0x185A1BA40", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5A1BAC0", Offset = "0x5A1A2C0", VA = "0x185A1BAC0", Slot = "30")]
	public void EALODDMPHDN(AKPAKEJMCNB ILLDOGNGNOD, bool JOHIKFAEACC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CAF0", Offset = "0x5A1B2F0", VA = "0x185A1CAF0", Slot = "6")]
	public void MADHPOOKIMJ(AKPAKEJMCNB LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5A1CD40", Offset = "0x5A1B540", VA = "0x185A1CD40", Slot = "7")]
	public void NKGELCCJPPJ(AKPAKEJMCNB LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C5F0", Offset = "0x5A1ADF0", VA = "0x185A1C5F0", Slot = "4")]
	public void IFGNKHDPNPM(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C730", Offset = "0x5A1AF30", VA = "0x185A1C730", Slot = "5")]
	public void KNCIMBFFAPF(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B790", Offset = "0x5A19F90", VA = "0x185A1B790")]
	private void BABCGJOJNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5A1B8C0", Offset = "0x5A1A0C0", VA = "0x185A1B8C0")]
	private void CHOBMOLMBHF(AKPAKEJMCNB LOKPKOHLHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C9A0", Offset = "0x5A1B1A0", VA = "0x185A1C9A0")]
	private void LNLIFMPBJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C050", Offset = "0x5A1A850", VA = "0x185A1C050")]
	private void FAOKGKCIFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C870", Offset = "0x5A1B070", VA = "0x185A1C870")]
	private void LNHNPICGFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5A1C3C0", Offset = "0x5A1ABC0", VA = "0x185A1C3C0")]
	[CompilerGenerated]
	private object HCMBPPEMKID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal static class ONNANCDEIDG
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6D97DC0", Offset = "0x6D965C0", VA = "0x186D97DC0")]
	public static AFIHIJBJHOL EAFOKJKFLFJ(this AKPAKEJMCNB PBDNMEDOHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ACGLADJIGLL : BHLMJHGKFAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JCAEGCAOHJG DBBIOBOPNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NNAEKKHECGM IBCDMIPMGAK;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool CLEPFPONEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x10195E0", Offset = "0x1017DE0", VA = "0x1810195E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public NNAEKKHECGM MPEFEKMEMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10", Slot = "11")]
		get
		{
			return default(NNAEKKHECGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5A18A40", Offset = "0x5A17240", VA = "0x185A18A40")]
	public ACGLADJIGLL(AKPAKEJMCNB KLEOGNMJFCE, in LPMCBAJFHEN NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5A18860", Offset = "0x5A17060", VA = "0x185A18860", Slot = "4")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5A18970", Offset = "0x5A17170", VA = "0x185A18970")]
	private bool LJDICJJMEOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5A18A10", Offset = "0x5A17210", VA = "0x185A18A10", Slot = "5")]
	public void PIHGBPNJOHD(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5A186B0", Offset = "0x5A16EB0", VA = "0x185A186B0", Slot = "6")]
	public void FDJBAOKPDJB(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5A18430", Offset = "0x5A16C30", VA = "0x185A18430", Slot = "9")]
	public void AGMANOOHJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5A185A0", Offset = "0x5A16DA0", VA = "0x185A185A0")]
	private void DELLJMKFCNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5A186E0", Offset = "0x5A16EE0", VA = "0x185A186E0")]
	private void JPKAGKBADBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5A18930", Offset = "0x5A17130", VA = "0x185A18930", Slot = "8")]
	public void KKCPPLBKLPM(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5A18560", Offset = "0x5A16D60", VA = "0x185A18560", Slot = "7")]
	public void DADDKKKDJOH(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface IDNHOLKICPA : GCLEJFKMCNI
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JKAIIPECNDE(Rigidbody KPJEACPPCOE);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AFIHIJBJHOL : CGOOPOPNOJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFGNKHDPNPM(AKPAKEJMCNB KLEOGNMJFCE);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNCIMBFFAPF(AKPAKEJMCNB KLEOGNMJFCE);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MADHPOOKIMJ(AKPAKEJMCNB LOKPKOHLHNH);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKGELCCJPPJ(AKPAKEJMCNB LOKPKOHLHNH);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class ACMCAPJEAIK : LOEDKPJOLCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool BJECCAMEEHC;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool MNGNMLJNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8F14D0", Offset = "0x8EFCD0", VA = "0x1808F14D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5A18BD0", Offset = "0x5A173D0", VA = "0x185A18BD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5A18CE0", Offset = "0x5A174E0", VA = "0x185A18CE0")]
	public ACMCAPJEAIK(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x5A18B30", Offset = "0x5A17330", VA = "0x185A18B30", Slot = "6")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x5A18B60", Offset = "0x5A17360", VA = "0x185A18B60", Slot = "7")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class LNBAEPABKCO : IPCMKIOFGLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly FNPFPKJAEFL KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool LPHMGPELDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool OCDPOGKAEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int KEEDPPAHJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private Rigidbody JIIBPHMGFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6D94700", Offset = "0x6D92F00", VA = "0x186D94700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private bool PLOJOLEFDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6D94820", Offset = "0x6D93020", VA = "0x186D94820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private AKPAKEJMCNB PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6D94720", Offset = "0x6D92F20", VA = "0x186D94720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool FEKKIFEGAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x6D94DF0", Offset = "0x6D935F0", VA = "0x186D94DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event BKKLCHMMMPO MLNFNBBFIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6D94E50", Offset = "0x6D93650", VA = "0x186D94E50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x6D94C30", Offset = "0x6D93430", VA = "0x186D94C30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6D94F70", Offset = "0x6D93770", VA = "0x186D94F70")]
	public LNBAEPABKCO(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6D94BD0", Offset = "0x6D933D0", VA = "0x186D94BD0", Slot = "6")]
	public void JPLAAMDJJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6D94EF0", Offset = "0x6D936F0", VA = "0x186D94EF0", Slot = "8")]
	public void NBEFMJDNBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6D945E0", Offset = "0x6D92DE0", VA = "0x186D945E0", Slot = "7")]
	public bool AKMPDAKLHKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x6D94F00", Offset = "0x6D93700", VA = "0x186D94F00", Slot = "9")]
	public void OLEEDMGNOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6D947C0", Offset = "0x6D92FC0", VA = "0x186D947C0", Slot = "11")]
	public void EFEMKHDKMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6D94780", Offset = "0x6D92F80", VA = "0x186D94780", Slot = "12")]
	public void EECOEHINOGD(bool JMCPMHHMAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6D94840", Offset = "0x6D93040", VA = "0x186D94840", Slot = "10")]
	public void EOLLPCOJDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6D94CD0", Offset = "0x6D934D0", VA = "0x186D94CD0")]
	private bool KLCDBDNEBMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6D94A80", Offset = "0x6D93280", VA = "0x186D94A80")]
	private void FFLDMLJOGMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class LPEBDIFGEHB : BLDDGFDICNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly AKPAKEJMCNB KLEOGNMJFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float HJCLBHJHBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private float CGJHCIBEHBB;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float EGBHIEJFIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x918E10", Offset = "0x917610", VA = "0x180918E10", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6D950F0", Offset = "0x6D938F0", VA = "0x186D950F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float CKPKIJGPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x918E00", Offset = "0x917600", VA = "0x180918E00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6D95020", Offset = "0x6D93820", VA = "0x186D95020", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6D95260", Offset = "0x6D93A60", VA = "0x186D95260")]
	public LPEBDIFGEHB(AKPAKEJMCNB KLEOGNMJFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6D94FD0", Offset = "0x6D937D0", VA = "0x186D94FD0", Slot = "8")]
	public void CCJGAKFHEKJ(Rigidbody GLNPLCBFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6D951C0", Offset = "0x6D939C0", VA = "0x186D951C0", Slot = "9")]
	public void NLNFCJEOCDM(Rigidbody GLNPLCBFALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface LACNGNLFBEF : LCHNDCKOECL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PhotonView MLMKKIMLECH
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
	internal class _RRAssemblyIndex : BBDIJCIAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E680", Offset = "0x6D9CE80", VA = "0x186D9E680", Slot = "6")]
		public sealed override void CJHJKHMBMOJ(DCJCPNPABDN JJFOLBCEJBD)
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
