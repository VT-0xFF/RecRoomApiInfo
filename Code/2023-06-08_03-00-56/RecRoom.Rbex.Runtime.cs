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
		public static PGDADKMBOJE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int EHKBIDIHFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int MHGPAEONDBE;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F37330", Offset = "0x6F36130", VA = "0x186F37330")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F37370", Offset = "0x6F36170", VA = "0x186F37370")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F37350", Offset = "0x6F36150", VA = "0x186F37350")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CAJMIGKHKEC, [Optional] UnityEngine.Object CNBGAPJABKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CAJMIGKHKEC, [Optional] UnityEngine.Object CNBGAPJABKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F37460", Offset = "0x6F36260", VA = "0x186F37460")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DNEKOKFKCIB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class JDGILACMOJM : EGEGDCABNBB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1859620", Offset = "0x1858420", VA = "0x181859620", Slot = "4")]
		public Vector3 EJAELIOAKCH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1859620", Offset = "0x1858420", VA = "0x181859620", Slot = "5")]
		public Vector3 BFNFMPBLCOB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JDGILACMOJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EGEGDCABNBB AHDBNJNPNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x631AEC0", Offset = "0x6319CC0", VA = "0x18631AEC0")]
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
		private static readonly IBKLHAEEEEI KMHMKCJNHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool KFLNDDALKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IALNGFFKNLN LNBJPHPCLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GBDGAMPCIGJ(PNNHMCGEKHG.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[GBDGAMPCIGJ(PNNHMCGEKHG.SelfAndParent, true, false, false)]
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
		private FAALEIENKLI physicsInterpolation;

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
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal IALNGFFKNLN DANFCPCKCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F38400", Offset = "0x6F37200", VA = "0x186F38400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> JPOCNGPAMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x998D70", Offset = "0x997B70", VA = "0x180998D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx PDNPFCPEIGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A0D0", Offset = "0x6F38ED0", VA = "0x186F3A0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx EDOHGCDFIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A070", Offset = "0x6F38E70", VA = "0x186F3A070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GMBPOBACJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AC20", Offset = "0x6F39A20", VA = "0x186F3AC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C1B0", Offset = "0x6F3AFB0", VA = "0x186F3C1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform FAEAMGOIDHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xF812D0", Offset = "0xF800D0", VA = "0x180F812D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform IKECMLMKJLP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xF812D0", Offset = "0xF800D0", VA = "0x180F812D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public APCJLGDLLCP GAFGFPPMOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F39DC0", Offset = "0x6F38BC0", VA = "0x186F39DC0")]
			get
			{
				return default(APCJLGDLLCP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B910", Offset = "0x6F3A710", VA = "0x186F3B910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IEHNKMMIJID
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A2D0", Offset = "0x6F390D0", VA = "0x186F3A2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PEPAEONPLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F39F50", Offset = "0x6F38D50", VA = "0x186F39F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EGEGDCABNBB ANDFKAGCBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A210", Offset = "0x6F39010", VA = "0x186F3A210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BB20", Offset = "0x6F3A920", VA = "0x186F3BB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BJMPOEOOJOD CHDINDNKIFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A1B0", Offset = "0x6F38FB0", VA = "0x186F3A1B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BAB0", Offset = "0x6F3A8B0", VA = "0x186F3BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DNHBNNEOGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A100", Offset = "0x6F38F00", VA = "0x186F3A100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody NEMLBINNKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A160", Offset = "0x6F38F60", VA = "0x186F3A160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BKIOEHLENKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F39FB0", Offset = "0x6F38DB0", VA = "0x186F39FB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B9D0", Offset = "0x6F3A7D0", VA = "0x186F3B9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FNABOENAKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x24CDDA0", Offset = "0x24CCBA0", VA = "0x1824CDDA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4453000", Offset = "0x4451E00", VA = "0x184453000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float BPAIDGPANCI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6F3ABC0", Offset = "0x6F399C0", VA = "0x186F3ABC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float LHHPCOFPECN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AB60", Offset = "0x6F39960", VA = "0x186F3AB60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C140", Offset = "0x6F3AF40", VA = "0x186F3C140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float JJAPGBCDNEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A530", Offset = "0x6F39330", VA = "0x186F3A530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BDC0", Offset = "0x6F3ABC0", VA = "0x186F3BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BEKPKNPABJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A330", Offset = "0x6F39130", VA = "0x186F3A330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BB90", Offset = "0x6F3A990", VA = "0x186F3BB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BDDLPAANOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B140", Offset = "0x6F39F40", VA = "0x186F3B140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C6F0", Offset = "0x6F3B4F0", VA = "0x186F3C6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 EGAGGEIKBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A940", Offset = "0x6F39740", VA = "0x186F3A940")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BF10", Offset = "0x6F3AD10", VA = "0x186F3BF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 DJIDMHHBDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B280", Offset = "0x6F3A080", VA = "0x186F3B280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode JDKKGHCHCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A470", Offset = "0x6F39270", VA = "0x186F3A470")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BCE0", Offset = "0x6F3AAE0", VA = "0x186F3BCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float LENBPNMMAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A010", Offset = "0x6F38E10", VA = "0x186F3A010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BA40", Offset = "0x6F3A840", VA = "0x186F3BA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints LJBMLIOKNCM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A4D0", Offset = "0x6F392D0", VA = "0x186F3A4D0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BD50", Offset = "0x6F3AB50", VA = "0x186F3BD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 JPKGHIEELHF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AC80", Offset = "0x6F39A80", VA = "0x186F3AC80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 MNNJBJCDKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AC80", Offset = "0x6F39A80", VA = "0x186F3AC80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C4C0", Offset = "0x6F3B2C0", VA = "0x186F3C4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float KHGEHKDLIDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AA20", Offset = "0x6F39820", VA = "0x186F3AA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BFF0", Offset = "0x6F3ADF0", VA = "0x186F3BFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NMNJDGFBIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B0E0", Offset = "0x6F39EE0", VA = "0x186F3B0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C680", Offset = "0x6F3B480", VA = "0x186F3C680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion KGBAEFBDIKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AD60", Offset = "0x6F39B60", VA = "0x186F3AD60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C220", Offset = "0x6F3B020", VA = "0x186F3C220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion KFEKKMLJCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B000", Offset = "0x6F39E00", VA = "0x186F3B000")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C5A0", Offset = "0x6F3B3A0", VA = "0x186F3C5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 MPKIJOBICEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AE40", Offset = "0x6F39C40", VA = "0x186F3AE40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C300", Offset = "0x6F3B100", VA = "0x186F3C300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion IHBFJFOHHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AF20", Offset = "0x6F39D20", VA = "0x186F3AF20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C3E0", Offset = "0x6F3B1E0", VA = "0x186F3C3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LDCHPECNIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B1A0", Offset = "0x6F39FA0", VA = "0x186F3B1A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C760", Offset = "0x6F3B560", VA = "0x186F3C760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NNODOCALLNC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AA80", Offset = "0x6F39880", VA = "0x186F3AA80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C060", Offset = "0x6F3AE60", VA = "0x186F3C060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 OFMHBIEBPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A390", Offset = "0x6F39190", VA = "0x186F3A390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BC00", Offset = "0x6F3AA00", VA = "0x186F3BC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 CEMPKCEOHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A860", Offset = "0x6F39660", VA = "0x186F3A860")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BE30", Offset = "0x6F3AC30", VA = "0x186F3BE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KNPDJDGFNIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A720", Offset = "0x6F39520", VA = "0x186F3A720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion CFBCJFMEGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A640", Offset = "0x6F39440", VA = "0x186F3A640")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 EJMMACDLGGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B440", Offset = "0x6F3A240", VA = "0x186F3B440")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 OFFMABKANAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B360", Offset = "0x6F3A160", VA = "0x186F3B360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OENOBJMCJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A800", Offset = "0x6F39600", VA = "0x186F3A800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool CHBEOBEAFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A270", Offset = "0x6F39070", VA = "0x186F3A270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DJGOBGBGCPM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F39EF0", Offset = "0x6F38CF0", VA = "0x186F39EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NENCKFPJOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6F39E90", Offset = "0x6F38C90", VA = "0x186F39E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CFGMCKBFGNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6F39D60", Offset = "0x6F38B60", VA = "0x186F39D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IGNJMCIDIIG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A590", Offset = "0x6F39390", VA = "0x186F3A590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PDHBIJBGJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA460C0", Offset = "0xA44EC0", VA = "0x180A460C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IFNJCNLFDEL AICKJHOBFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F39C80", Offset = "0x6F38A80", VA = "0x186F39C80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B830", Offset = "0x6F3A630", VA = "0x186F3B830")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OIDDCDOJCLP APPIEBBNAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6F39C10", Offset = "0x6F38A10", VA = "0x186F39C10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B7C0", Offset = "0x6F3A5C0", VA = "0x186F3B7C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IFNJCNLFDEL KAGOLOCGGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F39970", Offset = "0x6F38770", VA = "0x186F39970")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B520", Offset = "0x6F3A320", VA = "0x186F3B520")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event IFNJCNLFDEL AEDPCMKMNHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F399E0", Offset = "0x6F387E0", VA = "0x186F399E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B590", Offset = "0x6F3A390", VA = "0x186F3B590")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event IFNJCNLFDEL PLAINJNAPCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F39B30", Offset = "0x6F38930", VA = "0x186F39B30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B6E0", Offset = "0x6F3A4E0", VA = "0x186F3B6E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F39AC0", Offset = "0x6F388C0", VA = "0x186F39AC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B670", Offset = "0x6F3A470", VA = "0x186F3B670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event IFNJCNLFDEL MPKALOGIEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F39BA0", Offset = "0x6F389A0", VA = "0x186F39BA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B750", Offset = "0x6F3A550", VA = "0x186F3B750")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event IFNJCNLFDEL DEOPBPJPFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F39CF0", Offset = "0x6F38AF0", VA = "0x186F39CF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B8A0", Offset = "0x6F3A6A0", VA = "0x186F3B8A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event IFNJCNLFDEL EBPOFLBPHPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6F39A50", Offset = "0x6F38850", VA = "0x186F39A50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B600", Offset = "0x6F3A400", VA = "0x186F3B600")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
		internal void MDANNPAMNON(IALNGFFKNLN MLPNLAGGHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F38570", Offset = "0x6F37370", VA = "0x186F38570")]
		internal void GBDNPMPBKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F39660", Offset = "0x6F38460", VA = "0x186F39660")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody INPMCKGDDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6F392F0", Offset = "0x6F380F0", VA = "0x186F392F0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) INIANJPOEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F37E20", Offset = "0x6F36C20", VA = "0x186F37E20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F38400", Offset = "0x6F37200", VA = "0x186F38400")]
		private IALNGFFKNLN DGBJOHONCFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F38070", Offset = "0x6F36E70", VA = "0x186F38070")]
		private void DFMCNBMFALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F38AB0", Offset = "0x6F378B0", VA = "0x186F38AB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F38A40", Offset = "0x6F37840", VA = "0x186F38A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F38510", Offset = "0x6F37310", VA = "0x186F38510")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F38A50", Offset = "0x6F37850", VA = "0x186F38A50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F38B10", Offset = "0x6F37910", VA = "0x186F38B10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F374B0", Offset = "0x6F362B0", VA = "0x186F374B0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F38B80", Offset = "0x6F37980", VA = "0x186F38B80")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6F384B0", Offset = "0x6F372B0", VA = "0x186F384B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F389E0", Offset = "0x6F377E0", VA = "0x186F389E0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F39460", Offset = "0x6F38260", VA = "0x186F39460")]
		public void SetParent(RigidbodyEx KKLNCEHOHED, bool HKPKHHHLHMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F38E90", Offset = "0x6F37C90", VA = "0x186F38E90")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F38800", Offset = "0x6F37600", VA = "0x186F38800")]
		public bool IsRigidbodyAncestor(RigidbodyEx NLBLEKCLNJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F38840", Offset = "0x6F37640", VA = "0x186F38840")]
		public bool IsRigidbodyDescendant(RigidbodyEx HCBAAMFHHEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F376D0", Offset = "0x6F364D0", VA = "0x186F376D0")]
		public void AddInterpolationRestriction(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F38BF0", Offset = "0x6F379F0", VA = "0x186F38BF0")]
		public void RemoveInterpolationRestriction(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F37E90", Offset = "0x6F36C90", VA = "0x186F37E90")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F37740", Offset = "0x6F36540", VA = "0x186F37740")]
		public void AddKinematic(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F38C60", Offset = "0x6F37A60", VA = "0x186F38C60")]
		public void RemoveKinematic(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F393E0", Offset = "0x6F381E0", VA = "0x186F393E0")]
		public void SetKinematic(object GKNJCIECGND, bool FDNLKPOOHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F391F0", Offset = "0x6F37FF0", VA = "0x186F391F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MEKMIGBCKMO, Quaternion LAHNFJGIBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F390F0", Offset = "0x6F37EF0", VA = "0x186F390F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ODAJBDOBDMM, Quaternion MKOKOOBHKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F38700", Offset = "0x6F37500", VA = "0x186F38700")]
		public Vector3 GetConstrainedVelocity(Vector3 LDCHPECNIMD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F38600", Offset = "0x6F37400", VA = "0x186F38600")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 OFMHBIEBPJA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F37640", Offset = "0x6F36440", VA = "0x186F37640")]
		public void AddForce(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F37520", Offset = "0x6F36320", VA = "0x186F37520")]
		public void AddForceAtPosition(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F378B0", Offset = "0x6F366B0", VA = "0x186F378B0")]
		public void AddTorque(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F377B0", Offset = "0x6F365B0", VA = "0x186F377B0")]
		public void AddRelativeTorque(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F39740", Offset = "0x6F38540", VA = "0x186F39740")]
		public Vector3 WorldToLocalVelocity(Vector3 CEOAKEMPANE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F388E0", Offset = "0x6F376E0", VA = "0x186F388E0")]
		public Vector3 LocalToWorldVelocity(Vector3 NNODOCALLNC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F38010", Offset = "0x6F36E10", VA = "0x186F38010")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F37FB0", Offset = "0x6F36DB0", VA = "0x186F37FB0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F37F50", Offset = "0x6F36D50", VA = "0x186F37F50")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6F37EF0", Offset = "0x6F36CF0", VA = "0x186F37EF0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F38FF0", Offset = "0x6F37DF0", VA = "0x186F38FF0")]
		public void ResetVelocityWorldSpace(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F38EF0", Offset = "0x6F37CF0", VA = "0x186F38EF0")]
		public void ResetVelocityLocalSpace(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F38DB0", Offset = "0x6F37BB0", VA = "0x186F38DB0")]
		public void ResetLinearVelocityLocalSpace(Vector3 DPCMLJCFEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F39550", Offset = "0x6F38350", VA = "0x186F39550")]
		public bool SweepTest(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F38880", Offset = "0x6F37680", VA = "0x186F38880")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F394F0", Offset = "0x6F382F0", VA = "0x186F394F0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F396E0", Offset = "0x6F384E0", VA = "0x186F396E0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F37840", Offset = "0x6F36640", VA = "0x186F37840")]
		public void AddShouldHaveUnityRigidbodyToken(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F38CD0", Offset = "0x6F37AD0", VA = "0x186F38CD0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F37BF0", Offset = "0x6F369F0", VA = "0x186F37BF0")]
		public void ApplyForceVelocityChange(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F37AF0", Offset = "0x6F368F0", VA = "0x186F37AF0")]
		public void ApplyAngularVelocityChange(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F37D10", Offset = "0x6F36B10", VA = "0x186F37D10")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F37A30", Offset = "0x6F36830", VA = "0x186F37A30")]
		public bool AllowedScaleChange(float EDJIMOOOPCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F37940", Offset = "0x6F36740", VA = "0x186F37940")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx DCPPCGLJPCL, object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F38D40", Offset = "0x6F37B40", VA = "0x186F38D40")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F398D0", Offset = "0x6F386D0", VA = "0x186F398D0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class HBIIEGFBIBI
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x632CC70", Offset = "0x632BA70", VA = "0x18632CC70")]
	public static IALNGFFKNLN DANFCPCKCCJ(this RigidbodyEx LEDEJPFJONC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IFNJCNLFDEL(RigidbodyEx KKOECOBIKMI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BGJCKGINNLF : LEKPDBJGEEP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GLCLFAJCKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NCNHNJDENHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x838BE0", Offset = "0x8379E0", VA = "0x180838BE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "6")]
	public BBLMJPEOFPH FDKHBNFKCNO(float ANELFAJAIBO)
	{
		return default(BBLMJPEOFPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
	public void IMFFJGIMDFG(KMLGDIKJPGE GNOEFMFMEOO, float JDDHCIGHCNC, APCJLGDLLCP JLKDOFBPBFO = APCJLGDLLCP.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void IMFFJGIMDFG(KMLGDIKJPGE GNOEFMFMEOO, Transform OPOMAFCDEIO, float JDDHCIGHCNC, APCJLGDLLCP JLKDOFBPBFO = APCJLGDLLCP.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
	public void KGIAHNLKLGP(KMLGDIKJPGE GNOEFMFMEOO, [Optional] float? JDDHCIGHCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "10")]
	public void OIPPMFBKPAM(KMLGDIKJPGE PLHPLLFKFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "11")]
	public BBLMJPEOFPH DBEEGCKPBON(KMLGDIKJPGE GNOEFMFMEOO)
	{
		return default(BBLMJPEOFPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "12")]
	public bool LGMAFABJEJG(KMLGDIKJPGE GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "13")]
	public void AAFAPMOELIB(KMLGDIKJPGE GNOEFMFMEOO, APCJLGDLLCP KBPGBJHCDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public BGJCKGINNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FAALEIENKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AMCNMDEBLKK
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KNMEOCMIJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody DDMKFDDLOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView EEOMANDKECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 OGKLPMINDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 DKNNDEIMELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public FAALEIENKLI NOABEHCLBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool BMAJCHNGMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool ODGPFJNFDJC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void OIDDCDOJCLP(RigidbodyEx KKOECOBIKMI, bool HKPKHHHLHMB = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PGKHHMAEBMO(typeof(KMDCJPJPCBD), new string[] { "Ignore", "Mock" })]
public class NMDMNAPMDGL : KMDCJPJPCBD
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool AJBBBFFHOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83B610", Offset = "0x83A410", VA = "0x18083B610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
	public void BCEIAHNIBDC(string JKCLFNEEMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "6")]
	public void ECECMOPEMMJ(RigidbodyEx LEDEJPFJONC, Action EHPEOJCHKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8667F0", Offset = "0x8655F0", VA = "0x1808667F0", Slot = "7")]
	public LEKPDBJGEEP NKKDAFNEAOL(int EJPIPGCBHFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void DDHLFDIAAOK(Vector3 DJIDMHHBDBL, float LNLBHJMFKPE, Color OPEMNAAFCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public NMDMNAPMDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PGKHHMAEBMO(typeof(EIAOGNGKKKE), new string[] { })]
public class MBFLLHPBCHD : EIAOGNGKKKE, MLAMHJJBADC
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OFOPFPOKLCG ADNDPOMCNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KMDCJPJPCBD KMPEFKMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ADAILKIPHED NIFCNCONNGM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HHKGJINNNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F33AC0", Offset = "0x6F328C0", VA = "0x186F33AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KMDCJPJPCBD KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public ADAILKIPHED ECDBAGNEFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F33A30", Offset = "0x6F32830", VA = "0x186F33A30", Slot = "12")]
	public void InitReferences(JNPNBLMGJNE LIBJJFNFJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F33B10", Offset = "0x6F32910", VA = "0x186F33B10", Slot = "7")]
	public EGCGFMJAHFA NCLJPBPIFGA(RigidbodyEx LEDEJPFJONC)
	{
		return default(EGCGFMJAHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F33840", Offset = "0x6F32640", VA = "0x186F33840")]
	private static EGCGFMJAHFA GHNMBANIIBC(RigidbodyEx LEDEJPFJONC)
	{
		return default(EGCGFMJAHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F33F60", Offset = "0x6F32D60", VA = "0x186F33F60", Slot = "8")]
	public IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F33770", Offset = "0x6F32570", VA = "0x186F33770", Slot = "11")]
	private RigidbodyEx CDDFKBGPLFG(GameObject CJDEFKBLNIP, KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F33940", Offset = "0x6F32740", VA = "0x186F33940", Slot = "9")]
	public void HCGKABNEBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F33E10", Offset = "0x6F32C10", VA = "0x186F33E10", Slot = "10")]
	public void OIFLKJHIJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public MBFLLHPBCHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FCFJLMGBDDC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float CBBDBINPKID = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float LHDBBCICMHA = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float DBMEEGKKCML = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public FCFJLMGBDDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AHDMHKINIDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6317F40", Offset = "0x6316D40", VA = "0x186317F40")]
	public static void GHJLFLDHOLG(this Rigidbody INPMCKGDDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6318090", Offset = "0x6316E90", VA = "0x186318090")]
	public static void GHJLFLDHOLG(this Rigidbody INPMCKGDDAI, Vector3 NLMEHGLMJLG, Quaternion CFBCJFMEGCA, Vector3 GFOMDDJMDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6317E70", Offset = "0x6316C70", VA = "0x186317E70")]
	public static void DHDJHNCKDEE(Vector3 LDCHPECNIMD, Vector3 AEKDOICBOKF, out Vector3 HLMJGKEECNG, out Vector3 NGELBCLHMNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum LBNGCHOCAHD
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EIMKGKBMLOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IFNJCNLFDEL DHIKPIOCKPJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNCCHFFDOCI(IALNGFFKNLN GMBPOBACJJI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGINMFDINPO(IALNGFFKNLN GMBPOBACJJI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CGOLBACNLLK
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface KMDCJPJPCBD
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool AJBBBFFHOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCEIAHNIBDC(string JKCLFNEEMGK);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECECMOPEMMJ(RigidbodyEx LEDEJPFJONC, Action EHPEOJCHKEM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LEKPDBJGEEP NKKDAFNEAOL(int EJPIPGCBHFH);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDHLFDIAAOK(Vector3 DJIDMHHBDBL, float LNLBHJMFKPE, Color OPEMNAAFCJM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface EIAOGNGKKKE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KMDCJPJPCBD KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ADAILKIPHED ECDBAGNEFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool HHKGJINNNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EGCGFMJAHFA NCLJPBPIFGA(RigidbodyEx LEDEJPFJONC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCGKABNEBKB();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OIFLKJHIJEK();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx CFFMNLJMDBK(GameObject CJDEFKBLNIP, [Optional] KNMEOCMIJIH FAJCHBCCGOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BEAGLMKEMKE
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx BNKKNBAMBIK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PNCCDDDKOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOALLBDKCNE(IALNGFFKNLN GMBPOBACJJI, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOGGLKJKLHN(object GKNJCIECGND);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class PKGGDDJCGFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F367D0", Offset = "0x6F355D0", VA = "0x186F367D0")]
	public PKGGDDJCGFG(GOKKFMHLLAO KKKNDAKKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F36770", Offset = "0x6F35570", VA = "0x186F36770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GOKKFMHLLAO : IALNGFFKNLN, IDisposable, PKJGHIIJMLK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string PDEPLPPOIIE = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly EIAOGNGKKKE PNDAGJIDNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal OIFOPOHAFPB LJIJHMFKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal NMPBGFBGGBD CBHCOOHACCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal EIMKGKBMLOG IHFEIGFBOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MKIOOEIOHIP LDCHPECNIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal PNCCDDDKOCF FICNPLFFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal IFINNAKNKCK PCKNJEIIFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal CGOLBACNLLK DFJDNGEOJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal KJLHMIPJPNH FBGAGMHDCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal HCFELOBKGID ACNLONILPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal LDIIINLPLHP GFPMOCBOGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal HJPNGMGJMDN KJPDBCPAEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal CIKDHHPJFFL CONMELFNDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal NBADJKPBDNO LGEHJCAADPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal EAKOJIJAJHN DDMKFDDLOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal BJJFLCNOKNL CLDLDLMNILJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx OFFAAFJHABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921300", VA = "0x180922500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xC29A60", Offset = "0xC28860", VA = "0x180C29A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject CAOJNABKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96DD20", VA = "0x18096EF20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCDEF80", Offset = "0xCDDD80", VA = "0x180CDEF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6327E80", Offset = "0x6326C80", VA = "0x186327E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> ODCDJKEBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x632B620", Offset = "0x632A420", VA = "0x18632B620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x632B6C0", Offset = "0x632A4C0", VA = "0x18632B6C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x632B990", Offset = "0x632A790", VA = "0x18632B990", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x63286E0", Offset = "0x63274E0", VA = "0x1863286E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6327390", Offset = "0x6326190", VA = "0x186327390", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x63293A0", Offset = "0x63281A0", VA = "0x1863293A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6328AD0", Offset = "0x63278D0", VA = "0x186328AD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6327900", Offset = "0x6326700", VA = "0x186327900", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x632C320", Offset = "0x632B120", VA = "0x18632C320", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6328030", Offset = "0x6326E30", VA = "0x186328030", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6328080", Offset = "0x6326E80", VA = "0x186328080", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x63283A0", Offset = "0x63271A0", VA = "0x1863283A0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6328B30", Offset = "0x6327930", VA = "0x186328B30", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x632C940", Offset = "0x632B740", VA = "0x18632C940", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6328CE0", Offset = "0x6327AE0", VA = "0x186328CE0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x632BE10", Offset = "0x632AC10", VA = "0x18632BE10", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6327440", Offset = "0x6326240", VA = "0x186327440", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6328260", Offset = "0x6327060", VA = "0x186328260", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x63271C0", Offset = "0x6325FC0", VA = "0x1863271C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6328A00", Offset = "0x6327800", VA = "0x186328A00", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6328130", Offset = "0x6326F30", VA = "0x186328130", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x63287E0", Offset = "0x63275E0", VA = "0x1863287E0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6329650", Offset = "0x6328450", VA = "0x186329650", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DJGOBGBGCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6327CB0", Offset = "0x6326AB0", VA = "0x186327CB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool NENCKFPJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x632C8E0", Offset = "0x632B6E0", VA = "0x18632C8E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool CFGMCKBFGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6326C90", Offset = "0x6325A90", VA = "0x186326C90", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x632A840", Offset = "0x6329640", VA = "0x18632A840", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x63284B0", Offset = "0x63272B0", VA = "0x1863284B0", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x632AF80", Offset = "0x6329D80", VA = "0x18632AF80", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x632A210", Offset = "0x6329010", VA = "0x18632A210", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6327F60", Offset = "0x6326D60", VA = "0x186327F60", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6329DD0", Offset = "0x6328BD0", VA = "0x186329DD0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6328EA0", Offset = "0x6327CA0", VA = "0x186328EA0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x63289B0", Offset = "0x63277B0", VA = "0x1863289B0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x63272E0", Offset = "0x63260E0", VA = "0x1863272E0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x632A770", Offset = "0x6329570", VA = "0x18632A770", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x632CA90", Offset = "0x632B890", VA = "0x18632CA90", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6328F50", Offset = "0x6327D50", VA = "0x186328F50", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6328EF0", Offset = "0x6327CF0", VA = "0x186328EF0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6328C90", Offset = "0x6327A90", VA = "0x186328C90", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6328950", Offset = "0x6327750", VA = "0x186328950", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x632B670", Offset = "0x632A470", VA = "0x18632B670", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x632C260", Offset = "0x632B060", VA = "0x18632C260", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6328650", Offset = "0x6327450", VA = "0x186328650", Slot = "51")]
		get
		{
			return default(MNKJPBHDJIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6326A10", Offset = "0x6325810", VA = "0x186326A10", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6329020", Offset = "0x6327E20", VA = "0x186329020", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform FAEAMGOIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6329070", Offset = "0x6327E70", VA = "0x186329070", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform IKECMLMKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6329070", Offset = "0x6327E70", VA = "0x186329070", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 BGOHBKDCLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6329130", Offset = "0x6327F30", VA = "0x186329130", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6327BA0", Offset = "0x63269A0", VA = "0x186327BA0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float JEAFPGEMHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6328C70", Offset = "0x6327A70", VA = "0x186328C70", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6328E30", Offset = "0x6327C30", VA = "0x186328E30", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float EBNLFIFLFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x632C8C0", Offset = "0x632B6C0", VA = "0x18632C8C0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6329540", Offset = "0x6328340", VA = "0x186329540", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion NFHCBBLAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6327D00", Offset = "0x6326B00", VA = "0x186327D00", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x632AA80", Offset = "0x6329880", VA = "0x18632AA80", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x632B7D0", Offset = "0x632A5D0", VA = "0x18632B7D0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6327F10", Offset = "0x6326D10", VA = "0x186327F10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x63286A0", Offset = "0x63274A0", VA = "0x1863286A0", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x63287A0", Offset = "0x63275A0", VA = "0x1863287A0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6327950", Offset = "0x6326750", VA = "0x186327950", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x632C720", Offset = "0x632B520", VA = "0x18632C720", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x632C870", Offset = "0x632B670", VA = "0x18632C870", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x632A030", Offset = "0x6328E30", VA = "0x18632A030", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x63280E0", Offset = "0x6326EE0", VA = "0x1863280E0", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6327610", Offset = "0x6326410", VA = "0x186327610", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x632A160", Offset = "0x6328F60", VA = "0x18632A160", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x63293F0", Offset = "0x63281F0", VA = "0x1863293F0", Slot = "142")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool CHBEOBEAFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6327770", Offset = "0x6326570", VA = "0x186327770", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool MAOHMINOMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x632A090", Offset = "0x6328E90", VA = "0x18632A090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool HHHDAPJJHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63283F0", Offset = "0x63271F0", VA = "0x1863283F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event IFNJCNLFDEL KAGOLOCGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6326C30", Offset = "0x6325A30", VA = "0x186326C30", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x63269B0", Offset = "0x63257B0", VA = "0x1863269B0", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event IFNJCNLFDEL AEDPCMKMNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x632AB10", Offset = "0x6329910", VA = "0x18632AB10", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x632A710", Offset = "0x6329510", VA = "0x18632A710", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event OIDDCDOJCLP NNPHJKIILCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6327710", Offset = "0x6326510", VA = "0x186327710", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x63273E0", Offset = "0x63261E0", VA = "0x1863273E0", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event IFNJCNLFDEL DHIKPIOCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6329080", Offset = "0x6327E80", VA = "0x186329080", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x632C2C0", Offset = "0x632B0C0", VA = "0x18632C2C0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event IFNJCNLFDEL PLAINJNAPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x632B710", Offset = "0x632A510", VA = "0x18632B710", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x632B930", Offset = "0x632A730", VA = "0x18632B930", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event IFNJCNLFDEL BKLODMPEDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6329970", Offset = "0x6328770", VA = "0x186329970", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6326AD0", Offset = "0x63258D0", VA = "0x186326AD0", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x63276B0", Offset = "0x63264B0", VA = "0x1863276B0", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x63279A0", Offset = "0x63267A0", VA = "0x1863279A0", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event IFNJCNLFDEL NHDANFKPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6328740", Offset = "0x6327540", VA = "0x186328740", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x63299D0", Offset = "0x63287D0", VA = "0x1863299D0", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event IFNJCNLFDEL EBPOFLBPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6326B30", Offset = "0x6325930", VA = "0x186326B30", Slot = "124")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x632C370", Offset = "0x632B170", VA = "0x18632C370", Slot = "125")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x632CBA0", Offset = "0x632B9A0", VA = "0x18632CBA0")]
	public GOKKFMHLLAO(GameObject KKHNMHOFPEF, RigidbodyEx DAGMEMLNMIF, EIAOGNGKKKE PNDAGJIDNCN, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x632B2E0", Offset = "0x632A0E0", VA = "0x18632B2E0", Slot = "143")]
	protected virtual void NAICFIAIFFE(EIAOGNGKKKE PNDAGJIDNCN, KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6327DB0", Offset = "0x6326BB0", VA = "0x186327DB0", Slot = "144")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x632A5D0", Offset = "0x63293D0", VA = "0x18632A5D0", Slot = "75")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6328900", Offset = "0x6327700", VA = "0x186328900", Slot = "76")]
	public void GCMEGLCAEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x632A140", Offset = "0x6328F40", VA = "0x18632A140", Slot = "77")]
	public void JMDGDLIGGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6327560", Offset = "0x6326360", VA = "0x186327560", Slot = "145")]
	public virtual void CDMEBJDBNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x632A560", Offset = "0x6329360", VA = "0x18632A560", Slot = "86")]
	public void KPFIAOMFCDP(IALNGFFKNLN KKLNCEHOHED, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x632BDB0", Offset = "0x632ABB0", VA = "0x18632BDB0", Slot = "89")]
	public void ODPHPFOLFMH(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6326950", Offset = "0x6325750", VA = "0x186326950", Slot = "90")]
	public void AAEIFBBACMI(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6328D40", Offset = "0x6327B40", VA = "0x186328D40", Slot = "91")]
	public Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6326D80", Offset = "0x6325B80", VA = "0x186326D80", Slot = "92")]
	public Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6328900", Offset = "0x6327700", VA = "0x186328900", Slot = "93")]
	public void JDCBOABIJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x632A1C0", Offset = "0x6328FC0", VA = "0x18632A1C0", Slot = "94")]
	public void KBDPAPHONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x632C210", Offset = "0x632B010", VA = "0x18632C210", Slot = "95")]
	public void OIJAMDNJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x632C780", Offset = "0x632B580", VA = "0x18632C780", Slot = "96")]
	public void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6327AB0", Offset = "0x63268B0", VA = "0x186327AB0", Slot = "97")]
	public void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x63270A0", Offset = "0x6325EA0", VA = "0x1863270A0", Slot = "98")]
	public void BIDFFMKKIHO(Vector3 GDDEOPEKIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6326F80", Offset = "0x6325D80", VA = "0x186326F80", Slot = "99")]
	public void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x632C620", Offset = "0x632B420", VA = "0x18632C620", Slot = "100")]
	public void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6326E70", Offset = "0x6325C70", VA = "0x186326E70", Slot = "101")]
	[Obsolete]
	public void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x632C050", Offset = "0x632AE50", VA = "0x18632C050", Slot = "102")]
	public Vector3 OIABDKINBPG(Vector3 KKLNCEHOHED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x632A360", Offset = "0x6329160", VA = "0x18632A360", Slot = "103")]
	public Vector3 KFENALNODBH(Vector3 KKLNCEHOHED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x63290E0", Offset = "0x6327EE0", VA = "0x1863290E0", Slot = "104")]
	public void IBAOFCANNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x632C140", Offset = "0x632AF40", VA = "0x18632C140", Slot = "105")]
	public void OIBMBIJGELC(IALNGFFKNLN DCPPCGLJPCL, object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6329FD0", Offset = "0x6328DD0", VA = "0x186329FD0", Slot = "106")]
	public void JHAIMIOBEIO(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x632B200", Offset = "0x632A000", VA = "0x18632B200", Slot = "44")]
	public void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6327340", Offset = "0x6326140", VA = "0x186327340", Slot = "109")]
	public void BNKJGKNHLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x63288B0", Offset = "0x63276B0", VA = "0x1863288B0", Slot = "110")]
	public void GAOADMKHFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x632A4B0", Offset = "0x63292B0", VA = "0x18632A4B0", Slot = "111")]
	public void KMNOHMMJKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6327660", Offset = "0x6326460", VA = "0x186327660", Slot = "114")]
	public bool CFPNCHFMENI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6327510", Offset = "0x6326310", VA = "0x186327510", Slot = "78")]
	public void CBGLCKOLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6327290", Offset = "0x6326090", VA = "0x186327290", Slot = "115")]
	public void BLIEODGKOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6327170", Offset = "0x6325F70", VA = "0x186327170", Slot = "120")]
	public IDisposable BKCIPBJCHLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6327C50", Offset = "0x6326A50", VA = "0x186327C50", Slot = "121")]
	public void DLJPCIDNJKK(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6326BD0", Offset = "0x63259D0", VA = "0x186326BD0", Slot = "122")]
	public void AJHIMKJCCCC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6328330", Offset = "0x6327130", VA = "0x186328330", Slot = "123")]
	public void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x632C410", Offset = "0x632B210", VA = "0x18632C410", Slot = "126")]
	public void OPHLBBEDCOI(Vector3 MEKMIGBCKMO, Quaternion LAHNFJGIBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x63297C0", Offset = "0x63285C0", VA = "0x1863297C0", Slot = "127")]
	public void IHGOMKPAJGI(Vector3 ODAJBDOBDMM, Quaternion MKOKOOBHKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x632A450", Offset = "0x6329250", VA = "0x18632A450", Slot = "128")]
	public bool KIOAFHIMDKK(float EDJIMOOOPCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x632B5C0", Offset = "0x632A3C0", VA = "0x18632B5C0", Slot = "129")]
	public void NAJLIHGLMOF(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x632B770", Offset = "0x632A570", VA = "0x18632B770", Slot = "130")]
	public void NLMOGDNMKPG(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x632A500", Offset = "0x6329300", VA = "0x18632A500", Slot = "131")]
	public void KPECEJGALAC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6328200", Offset = "0x6327000", VA = "0x186328200", Slot = "132")]
	public void EKFGHHIJGFL(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6329720", Offset = "0x6328520", VA = "0x186329720")]
	public void IHAFDAIPNIB(object GKNJCIECGND, bool FIJKCKMMGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6328FA0", Offset = "0x6327DA0", VA = "0x186328FA0", Slot = "134")]
	public void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x632B820", Offset = "0x632A620", VA = "0x18632B820", Slot = "135")]
	public void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6328430", Offset = "0x6327230", VA = "0x186328430", Slot = "136")]
	public void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x632A2E0", Offset = "0x63290E0", VA = "0x18632A2E0", Slot = "137")]
	public void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x632C990", Offset = "0x632B790", VA = "0x18632C990", Slot = "138")]
	public bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x632AB70", Offset = "0x6329970", VA = "0x18632AB70", Slot = "139")]
	public void MEDKFCBLLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x632CB60", Offset = "0x632B960", VA = "0x18632CB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6328580", Offset = "0x6327380", VA = "0x186328580")]
	private void FHBJLDNIFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x63291F0", Offset = "0x6327FF0", VA = "0x1863291F0")]
	private void ICJEBJEKOEK(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x632A890", Offset = "0x6329690", VA = "0x18632A890")]
	private void LJFLFPDCMGE(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x632B150", Offset = "0x6329F50", VA = "0x18632B150")]
	private void MKNFFKOBOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x632B050", Offset = "0x6329E50", VA = "0x18632B050")]
	private void MHLIGGPDMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6327A00", Offset = "0x6326800", VA = "0x186327A00")]
	private void DDFBAHHINOK(IALNGFFKNLN LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6328B90", Offset = "0x6327990", VA = "0x186328B90")]
	private void GNCCHFFDOCI(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x632AEA0", Offset = "0x6329CA0", VA = "0x18632AEA0")]
	private void MGINMFDINPO(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x632BEE0", Offset = "0x632ACE0", VA = "0x18632BEE0")]
	private void OHLKJNLNICL(RigidbodyEx GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6329A30", Offset = "0x6328830", VA = "0x186329A30", Slot = "146")]
	protected virtual void JAIJFHCIEJG(RigidbodyEx LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6329EA0", Offset = "0x6328CA0", VA = "0x186329EA0")]
	[Conditional("UNITY_EDITOR")]
	private void JCPGBFMEJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x632ABC0", Offset = "0x63299C0", VA = "0x18632ABC0")]
	protected void MGAHKPLPHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x632B9E0", Offset = "0x632A7E0", VA = "0x18632B9E0")]
	protected void ODOIADFDACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class ENJHEKKMEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x631D6C0", Offset = "0x631C4C0", VA = "0x18631D6C0")]
	public static IALNGFFKNLN IDBOLLPEFLF(this IALNGFFKNLN LEDEJPFJONC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x631D5D0", Offset = "0x631C3D0", VA = "0x18631D5D0")]
	public static bool DKNMEAOKBBE(this IALNGFFKNLN LEDEJPFJONC, IALNGFFKNLN NLBLEKCLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x631D780", Offset = "0x631C580", VA = "0x18631D780")]
	public static bool JDDOFOKAJNO(this IALNGFFKNLN LEDEJPFJONC, IALNGFFKNLN HCBAAMFHHEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x631D800", Offset = "0x631C600", VA = "0x18631D800")]
	public static RigidbodyEx OFFAAFJHABL(this IALNGFFKNLN DANFCPCKCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x631D650", Offset = "0x631C450", VA = "0x18631D650")]
	public static GOKKFMHLLAO GFLFHAJGKNN(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IFINNAKNKCK
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event IFNJCNLFDEL GAIPCOJICPC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GAOADMKHFLJ();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BNKJGKNHLLJ();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KMNOHMMJKOG();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MEDKFCBLLCJ();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface PKJGHIIJMLK
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IALNGFFKNLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx OFFAAFJHABL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject CAOJNABKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> ODCDJKEBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool DJGOBGBGCPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool NENCKFPJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool CFGMCKBFGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform FAEAMGOIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform IKECMLMKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 BGOHBKDCLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float JEAFPGEMHME
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float EBNLFIFLFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion NFHCBBLAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool CHBEOBEAFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "129")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event IFNJCNLFDEL KAGOLOCGGHP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event IFNJCNLFDEL AEDPCMKMNHE;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event OIDDCDOJCLP NNPHJKIILCJ;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event IFNJCNLFDEL DHIKPIOCKPJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event IFNJCNLFDEL PLAINJNAPCL;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event IFNJCNLFDEL BKLODMPEDDA;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event IFNJCNLFDEL NHDANFKPPIP;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event IFNJCNLFDEL EBPOFLBPHPP;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void GCMEGLCAEMC();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void JMDGDLIGGKJ();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void CBGLCKOLBIJ();

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void CDMEBJDBNEP();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void KPFIAOMFCDP(IALNGFFKNLN KKLNCEHOHED, bool HKPKHHHLHMB = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void ODPHPFOLFMH(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void AAEIFBBACMI(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JDCBOABIJIM();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void KBDPAPHONNN();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OIJAMDNJAFB();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void BIDFFMKKIHO(Vector3 GDDEOPEKIDH);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 OIABDKINBPG(Vector3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 KFENALNODBH(Vector3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void IBAOFCANNDI();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void OIBMBIJGELC(IALNGFFKNLN DCPPCGLJPCL, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void JHAIMIOBEIO(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void BNKJGKNHLLJ();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GAOADMKHFLJ();

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KMNOHMMJKOG();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	bool CFPNCHFMENI();

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void BLIEODGKOHG();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	IDisposable BKCIPBJCHLL();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void DLJPCIDNJKK(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void AJHIMKJCCCC(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void OPHLBBEDCOI(Vector3 MEKMIGBCKMO, Quaternion LAHNFJGIBKB);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void IHGOMKPAJGI(Vector3 ODAJBDOBDMM, Quaternion MKOKOOBHKBI);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	bool KIOAFHIMDKK(float EDJIMOOOPCO);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NAJLIHGLMOF(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NLMOGDNMKPG(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KPECEJGALAC(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void EKFGHHIJGFL(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void MEDKFCBLLCJ();

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CIKDHHPJFFL
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EGEGDCABNBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 EJAELIOAKCH();

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BFNFMPBLCOB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NMPBGFBGGBD
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool MFOPKPKPJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	ALFCLIHOIFK HAKJBDNGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICNLGMGOCPN(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMKMOJIOGGF(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PBAEKOAAOCJ(IALNGFFKNLN LEDEJPFJONC);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKLALIPFLPJ(IALNGFFKNLN LEDEJPFJONC);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EGAALMNGAID();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LDIIINLPLHP : IDisposable, KMLGDIKJPGE
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP;

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBINDKHDICH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OIFOPOHAFPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event IFNJCNLFDEL KAGOLOCGGHP;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event IFNJCNLFDEL AEDPCMKMNHE;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event OIDDCDOJCLP NNPHJKIILCJ;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action FLKLBAJIKCC;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action IFIFPLHFPLE;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<IALNGFFKNLN> KNBCIOJNONG;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<IALNGFFKNLN> JDPFLLJJCAO;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action GFNJNPKMJON;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<IALNGFFKNLN> FOABOMCNIAF;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KPFIAOMFCDP(IALNGFFKNLN DOJCGKKDJND, bool HKPKHHHLHMB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface ADAILKIPHED
{
	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OIFOPOHAFPB ANNDNAJJOFM(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MKIOOEIOHIP PLCCLHMAKNM(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PNCCDDDKOCF BLABPLKENBJ(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CGOLBACNLLK GGDJAJDLFNG(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HCFELOBKGID BIGIOGEFDAN(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LDIIINLPLHP OOEPPHJENMK(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HJPNGMGJMDN IBKJADICPAF(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CIKDHHPJFFL ODLMKJEEAAO(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BJJFLCNOKNL KGANBOGAEFP(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KJLHMIPJPNH ICOCGDJFBPO(IALNGFFKNLN MLPNLAGGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EAKOJIJAJHN LONFOCMCGKC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EIMKGKBMLOG EBLKMNKPDMD(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NMPBGFBGGBD MODNEAFIHDM(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IFINNAKNKCK AHEFAPJEEGF(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NBADJKPBDNO NKAPFOCNGOL(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ, EIAOGNGKKKE PNDAGJIDNCN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NBADJKPBDNO
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool NOOGGOBEFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BJMPOEOOJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIKNAGKMKOI(Vector3 NGGNEEEKAEN);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAKFHDCMHLH(Vector3 OFMHBIEBPJA);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGKLGDOBFDH(Vector3 NGGNEEEKAEN);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGBIBIFKBCI(Vector3 OFMHBIEBPJA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HJPNGMGJMDN
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> CMGNAEHMDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event IFNJCNLFDEL NHDANFKPPIP;

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOHFBAPPANC();

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLJPCIDNJKK(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJHIMKJCCCC(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable BKCIPBJCHLL();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BJCGJBOMHCB(Rigidbody MFDMLFENPMD);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BJJFLCNOKNL
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNJEPLFPOMM(bool OENOBJMCJEA);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELDFNEOBPBB(bool OENOBJMCJEA);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MKIOOEIOHIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BCFPDJEFOBH(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OIJAMDNJAFB();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KBDPAPHONNN();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IBAOFCANNDI();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JDCBOABIJIM();

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KFENALNODBH(Vector3 OFMHBIEBPJA);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 OIABDKINBPG(Vector3 LDCHPECNIMD);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BEKBIOKODGA(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BIDFFMKKIHO(Vector3 GDDEOPEKIDH);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EAKOJIJAJHN
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPECEJGALAC(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKFGHHIJGFL(object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJFIBFHCMBF();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IEHCDHJECBA();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHALJJHEJAL();

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FJLKKIGBBBN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KJLHMIPJPNH
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HCFELOBKGID
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event IFNJCNLFDEL BKLODMPEDDA;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBINDKHDICH();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CFPNCHFMENI();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDHGMECENAF();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CBGLCKOLBIJ();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NJDEBHJDAKP();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLIEODGKOHG();

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMEGEDMPEND(bool LBLKJDFBHDJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[PGKHHMAEBMO(typeof(OFNDOOEFNOF), new string[] { })]
public sealed class NMJBHKGGNKL : MLAMHJJBADC, OFNDOOEFNOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[DHEDBDPPIHN]
	private AAOBMHINIMM LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool CGHLOCINKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x935A20", Offset = "0x934820", VA = "0x180935A20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F35320", Offset = "0x6F34120", VA = "0x186F35320", Slot = "4")]
	public void InitReferences(JNPNBLMGJNE LIBJJFNFJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F35060", Offset = "0x6F33E60", VA = "0x186F35060", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F34CF0", Offset = "0x6F33AF0", VA = "0x186F34CF0", Slot = "6")]
	public void APBNGMGGMEG(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F34E60", Offset = "0x6F33C60", VA = "0x186F34E60", Slot = "7")]
	public void CFILBMCKDIO(EGCGFMJAHFA OEJOEELBGEB, bool HDOHPPEDCPA, bool KPLCIBPDIJA, bool KMNIGCGNOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F351E0", Offset = "0x6F33FE0", VA = "0x186F351E0")]
	private bool EGCGIFFPBKH(EGCGFMJAHFA OEJOEELBGEB, out PHPKPLLNMHF MLPNLAGGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F35090", Offset = "0x6F33E90", VA = "0x186F35090")]
	private bool EFBGCCGNNBP(EGCGFMJAHFA OEJOEELBGEB, out JLIIOKFJGOA MNGLHLHJBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F35370", Offset = "0x6F34170", VA = "0x186F35370")]
	private bool NIMDEENDJCF(EGCGFMJAHFA OEJOEELBGEB, out GGDEPPJEJEE HLNBLOOKKLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public NMJBHKGGNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class GGDEPPJEJEE : GBOPPMEKOPM, IFINNAKNKCK
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6322510", Offset = "0x6321310", VA = "0x186322510", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6321290", Offset = "0x6320090", VA = "0x186321290", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 LHBJNCDFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6322C60", Offset = "0x6321A60", VA = "0x186322C60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6321290", Offset = "0x6320090", VA = "0x186321290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 PBEEFAACFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6321400", Offset = "0x6320200", VA = "0x186321400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x63222F0", Offset = "0x63210F0", VA = "0x1863222F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6322090", Offset = "0x6320E90", VA = "0x186322090", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float IPGPDDHLLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x63211A0", Offset = "0x631FFA0", VA = "0x1863211A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6321BE0", Offset = "0x63209E0", VA = "0x186321BE0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6320E20", Offset = "0x631FC20", VA = "0x186320E20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6322720", Offset = "0x6321520", VA = "0x186322720", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6323410", Offset = "0x6322210", VA = "0x186323410", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event IFNJCNLFDEL GAIPCOJICPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6323010", Offset = "0x6321E10", VA = "0x186323010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6322470", Offset = "0x6321270", VA = "0x186322470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6323440", Offset = "0x6322240", VA = "0x186323440")]
	public GGDEPPJEJEE(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6321FD0", Offset = "0x6320DD0", VA = "0x186321FD0")]
	public float3 HDLDDABBKIN()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6321AF0", Offset = "0x63208F0", VA = "0x186321AF0")]
	public bool GHNNHNCBBDP(out float3 DJIDMHHBDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6321EF0", Offset = "0x6320CF0", VA = "0x186321EF0")]
	public void GLELFJPDFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x631F980", Offset = "0x631E780", VA = "0x18631F980")]
	public bool AAHBIACKMOC(out float BPAIDGPANCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6322D90", Offset = "0x6321B90", VA = "0x186322D90", Slot = "14")]
	public void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6320F20", Offset = "0x631FD20", VA = "0x186320F20", Slot = "16")]
	public void BNKJGKNHLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6321770", Offset = "0x6320570", VA = "0x186321770", Slot = "15")]
	public void GAOADMKHFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6320CD0", Offset = "0x631FAD0", VA = "0x186320CD0", Slot = "18")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63230B0", Offset = "0x6321EB0", VA = "0x1863230B0", Slot = "19")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6322640", Offset = "0x6321440", VA = "0x186322640", Slot = "17")]
	public void KMNOHMMJKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6322750", Offset = "0x6321550", VA = "0x186322750", Slot = "20")]
	public void MEDKFCBLLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x631BDC0", Offset = "0x631ABC0", VA = "0x18631BDC0")]
	public void DBDLJJNGALD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x63212C0", Offset = "0x63200C0", VA = "0x1863212C0")]
	private void FDGBFGPOMGK(Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6322170", Offset = "0x6320F70", VA = "0x186322170")]
	[Obsolete]
	private Vector3 INEHLPLKOGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6320E20", Offset = "0x631FC20", VA = "0x186320E20")]
	private void MKNJOIAJOIO(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6321530", Offset = "0x6320330", VA = "0x186321530")]
	private Vector3 FNBMKMDDCFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6321CC0", Offset = "0x6320AC0", VA = "0x186321CC0")]
	private Quaternion GJGCMLDOBPO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x631FA70", Offset = "0x631E870", VA = "0x18631FA70")]
	internal (float, Vector3) APBNGMGGMEG(Rigidbody MLBCOOBBBGK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class HGJGJBHGBBK
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x632F7F0", Offset = "0x632E5F0", VA = "0x18632F7F0")]
	public static GGDEPPJEJEE KMJPHJDNODP(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IGIOAMAFHJF : GBOPPMEKOPM, MKIOOEIOHIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x63340C0", Offset = "0x6332EC0", VA = "0x1863340C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x63341F0", Offset = "0x6332FF0", VA = "0x1863341F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x63343D0", Offset = "0x63331D0", VA = "0x1863343D0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6334BD0", Offset = "0x63339D0", VA = "0x186334BD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6334B70", Offset = "0x6333970", VA = "0x186334B70", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x63342E0", Offset = "0x63330E0", VA = "0x1863342E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6335870", Offset = "0x6334670", VA = "0x186335870", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6333F00", Offset = "0x6332D00", VA = "0x186333F00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6334B10", Offset = "0x6333910", VA = "0x186334B10", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6335010", Offset = "0x6333E10", VA = "0x186335010", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x63343A0", Offset = "0x63331A0", VA = "0x1863343A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6333D00", Offset = "0x6332B00", VA = "0x186333D00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6335F90", Offset = "0x6334D90", VA = "0x186335F90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6334CC0", Offset = "0x6333AC0", VA = "0x186334CC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x63356D0", Offset = "0x63344D0", VA = "0x1863356D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private CIKDHHPJFFL BNICLINLGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x29AEF10", Offset = "0x29ADD10", VA = "0x1829AEF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x631BB50", Offset = "0x631A950", VA = "0x18631BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public IGIOAMAFHJF(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6332F80", Offset = "0x6331D80", VA = "0x186332F80", Slot = "20")]
	public void BCFPDJEFOBH(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6333420", Offset = "0x6332220", VA = "0x186333420", Slot = "31")]
	public void BEKBIOKODGA(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x63350D0", Offset = "0x6333ED0", VA = "0x1863350D0", Slot = "19")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6333F90", Offset = "0x6332D90", VA = "0x186333F90", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6333CC0", Offset = "0x6332AC0", VA = "0x186333CC0", Slot = "28")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6334CD0", Offset = "0x6333AD0", VA = "0x186334CD0", Slot = "36")]
	public Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6332B00", Offset = "0x6331900", VA = "0x186332B00", Slot = "35")]
	public Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x63350D0", Offset = "0x6333ED0", VA = "0x1863350D0", Slot = "27")]
	public void JDCBOABIJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6335590", Offset = "0x6334390", VA = "0x186335590", Slot = "25")]
	public void KBDPAPHONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6335960", Offset = "0x6334760", VA = "0x186335960", Slot = "24")]
	public void OIJAMDNJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6335BF0", Offset = "0x63349F0", VA = "0x186335BF0", Slot = "34")]
	public void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6333F30", Offset = "0x6332D30", VA = "0x186333F30", Slot = "33")]
	public void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6333B60", Offset = "0x6332960", VA = "0x186333B60", Slot = "32")]
	public void BIDFFMKKIHO(Vector3 GDDEOPEKIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63337D0", Offset = "0x63325D0", VA = "0x1863337D0", Slot = "22")]
	public void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x63359A0", Offset = "0x63347A0", VA = "0x1863359A0", Slot = "21")]
	public void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6333130", Offset = "0x6331F30", VA = "0x186333130", Slot = "23")]
	[Obsolete]
	public void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63358A0", Offset = "0x63346A0", VA = "0x1863358A0", Slot = "30")]
	public Vector3 OIABDKINBPG(Vector3 LDCHPECNIMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x63355D0", Offset = "0x63343D0", VA = "0x1863355D0", Slot = "29")]
	public Vector3 KFENALNODBH(Vector3 OFMHBIEBPJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6334EB0", Offset = "0x6333CB0", VA = "0x186334EB0", Slot = "26")]
	public void IBAOFCANNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6333D30", Offset = "0x6332B30", VA = "0x186333D30")]
	private void BMDEFPEJBON(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6335E30", Offset = "0x6334C30", VA = "0x186335E30")]
	private void PIGABDBLJPM(Vector3 KEDGNOGDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6332CC0", Offset = "0x6331AC0", VA = "0x186332CC0")]
	private Vector3 BAFCGALEOLN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6335140", Offset = "0x6333F40", VA = "0x186335140")]
	private void JHAKCAJJLCC(Vector3 NNODOCALLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6333510", Offset = "0x6332310", VA = "0x186333510")]
	private Vector3 BFNFMPBLCOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x63326C0", Offset = "0x63314C0", VA = "0x1863326C0")]
	private void AAKFHDCMHLH(Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x63357B0", Offset = "0x63345B0", VA = "0x1863357B0")]
	private void NAPLKAFCFCK(Vector3 LDCHPECNIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6335810", Offset = "0x6334610", VA = "0x186335810")]
	private void NCHPBAFBOLL(Vector3 OFMHBIEBPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6334500", Offset = "0x6333300", VA = "0x186334500")]
	private void FHKPDKCMJGP(string OGMHEPKJMNH, Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6333070", Offset = "0x6331E70", VA = "0x186333070")]
	private void BCKCMFFLGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JCJDHJDFNPG : GBOPPMEKOPM, CGOLBACNLLK
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6338200", Offset = "0x6337000", VA = "0x186338200", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x6338030", Offset = "0x6336E30", VA = "0x186338030", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6337F50", Offset = "0x6336D50", VA = "0x186337F50", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6337D80", Offset = "0x6336B80", VA = "0x186337D80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public JCJDHJDFNPG(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6337BB0", Offset = "0x63369B0", VA = "0x186337BB0", Slot = "8")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x63382E0", Offset = "0x63370E0", VA = "0x1863382E0", Slot = "9")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class DEAIEAOGAIB : IALNGFFKNLN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DEAIEAOGAIB LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx OFFAAFJHABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject CAOJNABKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> ODCDJKEBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915830", VA = "0x180916A30", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3050", Offset = "0x9D1E50", VA = "0x1809D3050", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9168B0", Offset = "0x9156B0", VA = "0x1809168B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xBF38F0", Offset = "0xBF26F0", VA = "0x180BF38F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x998D60", Offset = "0x997B60", VA = "0x180998D60", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x998D70", Offset = "0x997B70", VA = "0x180998D70", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x1E03280", Offset = "0x1E02080", VA = "0x181E03280", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1662AE0", Offset = "0x16618E0", VA = "0x181662AE0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2C44D00", Offset = "0x2C43B00", VA = "0x182C44D00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2C44CC0", Offset = "0x2C43AC0", VA = "0x182C44CC0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x268EC30", Offset = "0x268DA30", VA = "0x18268EC30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x2689FA0", Offset = "0x2688DA0", VA = "0x182689FA0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x268EC50", Offset = "0x268DA50", VA = "0x18268EC50", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x268CD50", Offset = "0x268BB50", VA = "0x18268CD50", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool DJGOBGBGCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1268550", Offset = "0x1267350", VA = "0x181268550", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool NENCKFPJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x12C2B50", Offset = "0x12C1950", VA = "0x1812C2B50", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool CFGMCKBFGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x12C2B40", Offset = "0x12C1940", VA = "0x1812C2B40", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xFED8F0", Offset = "0xFEC6F0", VA = "0x180FED8F0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x23C0210", Offset = "0x23BF010", VA = "0x1823C0210", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x24E6BB0", Offset = "0x24E59B0", VA = "0x1824E6BB0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x23A2F20", Offset = "0x23A1D20", VA = "0x1823A2F20", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xBE0E50", Offset = "0xBDFC50", VA = "0x180BE0E50", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB1E0", Offset = "0x1EA9FE0", VA = "0x181EAB1E0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x824060", Offset = "0x822E60", VA = "0x180824060", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB1E0", Offset = "0x1EA9FE0", VA = "0x181EAB1E0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB1E0", Offset = "0x1EA9FE0", VA = "0x181EAB1E0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool BDEPJAONPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "51")]
		get
		{
			return default(MNKJPBHDJIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x384C750", Offset = "0x384B550", VA = "0x18384C750", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform FAEAMGOIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xB9DB90", Offset = "0xB9C990", VA = "0x180B9DB90", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform IKECMLMKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xB05E00", Offset = "0xB04C00", VA = "0x180B05E00", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 BGOHBKDCLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float JEAFPGEMHME
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB1E0", Offset = "0x1EA9FE0", VA = "0x181EAB1E0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float EBNLFIFLFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1EAB1E0", Offset = "0x1EA9FE0", VA = "0x181EAB1E0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion NFHCBBLAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1B95B30", Offset = "0x1B94930", VA = "0x181B95B30", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1B95B30", Offset = "0x1B94930", VA = "0x181B95B30", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CHBEOBEAFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1EBE1D0", Offset = "0x1EBCFD0", VA = "0x181EBE1D0", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "133")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event IFNJCNLFDEL KAGOLOCGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "80")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "81")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event IFNJCNLFDEL AEDPCMKMNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OIDDCDOJCLP NNPHJKIILCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "84")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "85")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event IFNJCNLFDEL DHIKPIOCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "87")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "88")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event IFNJCNLFDEL PLAINJNAPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event IFNJCNLFDEL BKLODMPEDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "112")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "113")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "116")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "117")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event IFNJCNLFDEL NHDANFKPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "118")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "119")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event IFNJCNLFDEL EBPOFLBPHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "124")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "125")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "44")]
	public void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "75")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "76")]
	public void GCMEGLCAEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "77")]
	public void JMDGDLIGGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "78")]
	public void CBGLCKOLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "79")]
	public void CDMEBJDBNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "86")]
	public void KPFIAOMFCDP(IALNGFFKNLN KKLNCEHOHED, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "89")]
	public void ODPHPFOLFMH(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "90")]
	public void AAEIFBBACMI(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "91")]
	public Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "92")]
	public Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "93")]
	public void JDCBOABIJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "94")]
	public void KBDPAPHONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "95")]
	public void OIJAMDNJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "96")]
	public void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "97")]
	public void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "98")]
	public void BIDFFMKKIHO(Vector3 GDDEOPEKIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "99")]
	public void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "100")]
	public void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "101")]
	public void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "102")]
	public Vector3 OIABDKINBPG(Vector3 KKLNCEHOHED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40", Slot = "103")]
	public Vector3 KFENALNODBH(Vector3 KKLNCEHOHED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "104")]
	public void IBAOFCANNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "105")]
	public void OIBMBIJGELC(IALNGFFKNLN DCPPCGLJPCL, object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "106")]
	public void JHAIMIOBEIO(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "109")]
	public void BNKJGKNHLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "110")]
	public void GAOADMKHFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "111")]
	public void KMNOHMMJKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "114")]
	public bool CFPNCHFMENI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "115")]
	public void BLIEODGKOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "120")]
	public IDisposable BKCIPBJCHLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "121")]
	public void DLJPCIDNJKK(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "122")]
	public void AJHIMKJCCCC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "123")]
	public void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "126")]
	public void OPHLBBEDCOI(Vector3 MEKMIGBCKMO, Quaternion LAHNFJGIBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "127")]
	public void IHGOMKPAJGI(Vector3 ODAJBDOBDMM, Quaternion MKOKOOBHKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "128")]
	public bool KIOAFHIMDKK(float EDJIMOOOPCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "129")]
	public void NAJLIHGLMOF(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "130")]
	public void NLMOGDNMKPG(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "131")]
	public void KPECEJGALAC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "132")]
	public void EKFGHHIJGFL(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "134")]
	public void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "135")]
	public void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "136")]
	public void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "137")]
	public void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x631AE40", Offset = "0x6319C40", VA = "0x18631AE40", Slot = "138")]
	public bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "139")]
	public void MEDKFCBLLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public DEAIEAOGAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class NKEIMBIKOIJ : GBOPPMEKOPM, PNCCDDDKOCF
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F34330", Offset = "0x6F33130", VA = "0x186F34330", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F34B70", Offset = "0x6F33970", VA = "0x186F34B70", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F34990", Offset = "0x6F33790", VA = "0x186F34990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private IALNGFFKNLN EKDLBKFMOED
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F34200", Offset = "0x6F33000", VA = "0x186F34200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F20", Offset = "0x6F31D20", VA = "0x186F32F20")]
	public NKEIMBIKOIJ(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F344A0", Offset = "0x6F332A0", VA = "0x186F344A0", Slot = "6")]
	public void FOALLBDKCNE(IALNGFFKNLN GMBPOBACJJI, object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F34360", Offset = "0x6F33160", VA = "0x186F34360")]
	private void FOALLBDKCNE(PHPKPLLNMHF GMBPOBACJJI, object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F34A70", Offset = "0x6F33870", VA = "0x186F34A70", Slot = "7")]
	public void JOGGLKJKLHN(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F34640", Offset = "0x6F33440", VA = "0x186F34640")]
	private Vector3 GIAIJPHLPAC()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class AINDJOFAPEP
{
	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x63181A0", Offset = "0x6316FA0", VA = "0x1863181A0")]
	public static NKEIMBIKOIJ DLIJDJMICGD(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LDJLNHKMEDO : GBOPPMEKOPM, OIFOPOHAFPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly IBKLHAEEEEI GNFFKNEJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PGLINAMDJMJ DKLNCMBCEGD;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F30DE0", Offset = "0x6F2FBE0", VA = "0x186F30DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public EGCGFMJAHFA DPGJHECPFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F30880", Offset = "0x6F2F680", VA = "0x186F30880")]
		get
		{
			return default(EGCGFMJAHFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F310E0", Offset = "0x6F2FEE0", VA = "0x186F310E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F32520", Offset = "0x6F31320", VA = "0x186F32520", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F30FD0", Offset = "0x6F2FDD0", VA = "0x186F30FD0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public EGCGFMJAHFA IDJACCOJGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F315C0", Offset = "0x6F303C0", VA = "0x186F315C0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F32560", Offset = "0x6F31360", VA = "0x186F32560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F311F0", Offset = "0x6F2FFF0", VA = "0x186F311F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event IFNJCNLFDEL KAGOLOCGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F30600", Offset = "0x6F2F400", VA = "0x186F30600", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F303F0", Offset = "0x6F2F1F0", VA = "0x186F303F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event IFNJCNLFDEL AEDPCMKMNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F31C00", Offset = "0x6F30A00", VA = "0x186F31C00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F31AC0", Offset = "0x6F308C0", VA = "0x186F31AC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OIDDCDOJCLP NNPHJKIILCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F30990", Offset = "0x6F2F790", VA = "0x186F30990", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F307E0", Offset = "0x6F2F5E0", VA = "0x186F307E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action FLKLBAJIKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F31040", Offset = "0x6F2FE40", VA = "0x186F31040", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F30560", Offset = "0x6F2F360", VA = "0x186F30560", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action IFIFPLHFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F31890", Offset = "0x6F30690", VA = "0x186F31890", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F31230", Offset = "0x6F30030", VA = "0x186F31230", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<IALNGFFKNLN> KNBCIOJNONG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F30E10", Offset = "0x6F2FC10", VA = "0x186F30E10", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F31CA0", Offset = "0x6F30AA0", VA = "0x186F31CA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<IALNGFFKNLN> JDPFLLJJCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F30AD0", Offset = "0x6F2F8D0", VA = "0x186F30AD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F306A0", Offset = "0x6F2F4A0", VA = "0x186F306A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action GFNJNPKMJON
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F30740", Offset = "0x6F2F540", VA = "0x186F30740", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F31930", Offset = "0x6F30730", VA = "0x186F31930", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<IALNGFFKNLN> FOABOMCNIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F31B60", Offset = "0x6F30960", VA = "0x186F31B60", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x6F30A30", Offset = "0x6F2F830", VA = "0x186F30A30", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F32A00", Offset = "0x6F31800", VA = "0x186F32A00")]
	public LDJLNHKMEDO(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F30B70", Offset = "0x6F2F970", VA = "0x186F30B70", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F31A40", Offset = "0x6F30840", VA = "0x186F31A40", Slot = "26")]
	public void KPFIAOMFCDP(IALNGFFKNLN DOJCGKKDJND, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F319D0", Offset = "0x6F307D0", VA = "0x186F319D0")]
	private void KPFIAOMFCDP(PHPKPLLNMHF DOJCGKKDJND, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F31D40", Offset = "0x6F30B40", VA = "0x186F31D40")]
	private void NOGDEFNJILA(PHPKPLLNMHF DOJCGKKDJND, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F32670", Offset = "0x6F31470", VA = "0x186F32670")]
	private void ODDJDBLOLGF(PHPKPLLNMHF LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F316D0", Offset = "0x6F304D0", VA = "0x186F316D0")]
	private void KDAJMNLBGMP(PHPKPLLNMHF LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F312D0", Offset = "0x6F300D0", VA = "0x186F312D0")]
	private void ILKKONNJNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F30490", Offset = "0x6F2F290", VA = "0x186F30490")]
	private void ACLLGKLKLID(PHPKPLLNMHF LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F30EB0", Offset = "0x6F2FCB0", VA = "0x186F30EB0")]
	private void FCLKOIELBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F31480", Offset = "0x6F30280", VA = "0x186F31480")]
	private void JGLPKFEFEPD(PHPKPLLNMHF LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F32830", Offset = "0x6F31630", VA = "0x186F32830")]
	private void OOMFGDNBOAA(PHPKPLLNMHF LEDEJPFJONC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class LOONIHEHNKE
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F30", Offset = "0x6F31D30", VA = "0x186F32F30")]
	public static LDJLNHKMEDO HMGBIMLLIDC(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PHPKPLLNMHF : GOKKFMHLLAO, NNCIKKMHHAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal AAOBMHINIMM CCNEDMMMIMO;

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F36760", Offset = "0x6F35560", VA = "0x186F36760")]
	public PHPKPLLNMHF(GameObject KKHNMHOFPEF, RigidbodyEx DAGMEMLNMIF, EIAOGNGKKKE PNDAGJIDNCN, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F36110", Offset = "0x6F34F10", VA = "0x186F36110", Slot = "143")]
	protected override void NAICFIAIFFE(EIAOGNGKKKE PNDAGJIDNCN, KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F35E50", Offset = "0x6F34C50", VA = "0x186F35E50", Slot = "144")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F36390", Offset = "0x6F35190", VA = "0x186F36390", Slot = "147")]
	public void NCJGBBCDJPE(KOMKGHLBIAP PMPNCLBDLNA, KOMKGHLBIAP ECOPHBMBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F364C0", Offset = "0x6F352C0", VA = "0x186F364C0", Slot = "148")]
	public void OKGLBNOFCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F36050", Offset = "0x6F34E50", VA = "0x186F36050", Slot = "149")]
	public void JPCJMHADBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F36460", Offset = "0x6F35260", VA = "0x186F36460", Slot = "150")]
	public void NMEGEDMPEND(bool LBLKJDFBHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F35F20", Offset = "0x6F34D20", VA = "0x186F35F20", Slot = "151")]
	public bool JGNHFAIMFLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F35DF0", Offset = "0x6F34BF0", VA = "0x186F35DF0", Slot = "152")]
	public void DPIDGJCIFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "146")]
	protected override void JAIJFHCIEJG(RigidbodyEx FLIPNKNBGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F36580", Offset = "0x6F35380", VA = "0x186F36580")]
	private void PHPNNPCCCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "145")]
	public override void CDMEBJDBNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class IOOPOOIIHCN
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6337B60", Offset = "0x6336960", VA = "0x186337B60")]
	public static GOKKFMHLLAO FJFDHIJJNHG(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class BHCNDFIGOID : GBOPPMEKOPM, NMPBGFBGGBD
{
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private const string PBFCHKKHDLG = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool MFOPKPKPJON
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x6318F20", Offset = "0x6317D20", VA = "0x186318F20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public ALFCLIHOIFK HAKJBDNGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x6319000", Offset = "0x6317E00", VA = "0x186319000", Slot = "5")]
		get
		{
			return default(ALFCLIHOIFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private ALFCLIHOIFK FDLANBHOPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x63190D0", Offset = "0x6317ED0", VA = "0x1863190D0")]
		get
		{
			return default(ALFCLIHOIFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x6318990", Offset = "0x6317790", VA = "0x186318990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6319230", Offset = "0x6318030", VA = "0x186319230")]
	public BHCNDFIGOID(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6319010", Offset = "0x6317E10", VA = "0x186319010", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6318B80", Offset = "0x6317980", VA = "0x186318B80")]
	private bool EDKABCILPJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6318E20", Offset = "0x6317C20", VA = "0x186318E20", Slot = "7")]
	public void ICNLGMGOCPN(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6318A80", Offset = "0x6317880", VA = "0x186318A80", Slot = "8")]
	public void BMKMOJIOGGF(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6318C20", Offset = "0x6317A20", VA = "0x186318C20", Slot = "11")]
	public void EGAALMNGAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6318D30", Offset = "0x6317B30", VA = "0x186318D30")]
	private void GIJCDHPONMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6318800", Offset = "0x6317600", VA = "0x186318800")]
	private void ADFEKAGJNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x63191B0", Offset = "0x6317FB0", VA = "0x1863191B0", Slot = "10")]
	public void OKLALIPFLPJ(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63191F0", Offset = "0x6317FF0", VA = "0x1863191F0", Slot = "9")]
	public void PBAEKOAAOCJ(IALNGFFKNLN LEDEJPFJONC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class IJJAEFKENPL : GBOPPMEKOPM, CIKDHHPJFFL
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x631EE20", Offset = "0x631DC20", VA = "0x18631EE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6319870", Offset = "0x6318670", VA = "0x186319870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6336EB0", Offset = "0x6335CB0", VA = "0x186336EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public IJJAEFKENPL(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x63361D0", Offset = "0x6334FD0", VA = "0x1863361D0", Slot = "4")]
	public void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6336330", Offset = "0x6335130", VA = "0x186336330")]
	private void IBNLFDEOFEF(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6336C10", Offset = "0x6335A10", VA = "0x186336C10", Slot = "5")]
	public void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6336070", Offset = "0x6334E70", VA = "0x186336070", Slot = "6")]
	public void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6336620", Offset = "0x6335420", VA = "0x186336620")]
	private void JBAJKKAOMKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6336990", Offset = "0x6335790", VA = "0x186336990", Slot = "7")]
	public void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x63368A0", Offset = "0x63356A0", VA = "0x1863368A0")]
	private void JMPIMKEPGCC(string CAJMIGKHKEC, UnityEngine.Object CNBGAPJABKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class JOCKMAIPKPH : GBOPPMEKOPM, EAKOJIJAJHN
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string GHCCNCPOEDK = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x633A6B0", Offset = "0x63394B0", VA = "0x18633A6B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6339E30", Offset = "0x6338C30", VA = "0x186339E30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6319870", Offset = "0x6318670", VA = "0x186319870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6339C50", Offset = "0x6338A50", VA = "0x186339C50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x633AC10", Offset = "0x6339A10", VA = "0x18633AC10")]
	public JOCKMAIPKPH(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x633A280", Offset = "0x6339080", VA = "0x18633A280", Slot = "5")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x633A180", Offset = "0x6338F80", VA = "0x18633A180", Slot = "7")]
	public void KPECEJGALAC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6339D30", Offset = "0x6338B30", VA = "0x186339D30", Slot = "8")]
	public void EKFGHHIJGFL(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x633A790", Offset = "0x6339590", VA = "0x18633A790", Slot = "9")]
	public void OJFIBFHCMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6339F20", Offset = "0x6338D20", VA = "0x186339F20", Slot = "10")]
	public void IEHCDHJECBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x633AA40", Offset = "0x6339840", VA = "0x18633AA40", Slot = "11")]
	public void PHALJJHEJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "12")]
	public void FJLKKIGBBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x633A4F0", Offset = "0x63392F0", VA = "0x18633A4F0")]
	private void NCBMMMDIABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x633A330", Offset = "0x6339130", VA = "0x18633A330")]
	private void LMJJKLGAPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class JLIIOKFJGOA : GBOPPMEKOPM, HJPNGMGJMDN
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x6339730", Offset = "0x6338530", VA = "0x186339730", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> CMGNAEHMDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x63398B0", Offset = "0x63386B0", VA = "0x1863398B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool OOFPMMPGNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x6339B70", Offset = "0x6338970", VA = "0x186339B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event IFNJCNLFDEL NHDANFKPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6339690", Offset = "0x6338490", VA = "0x186339690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x6339810", Offset = "0x6338610", VA = "0x186339810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public JLIIOKFJGOA(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6339520", Offset = "0x6338320", VA = "0x186339520", Slot = "12")]
	public IDisposable BKCIPBJCHLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x6339580", Offset = "0x6338380", VA = "0x186339580", Slot = "9")]
	public void DLJPCIDNJKK(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x63393A0", Offset = "0x63381A0", VA = "0x1863393A0", Slot = "10")]
	public void AJHIMKJCCCC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6339590", Offset = "0x6338390", VA = "0x186339590", Slot = "11")]
	public void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x63393B0", Offset = "0x63381B0", VA = "0x1863393B0", Slot = "13")]
	public void BJCGJBOMHCB(Rigidbody MFDMLFENPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6339990", Offset = "0x6338790", VA = "0x186339990", Slot = "14")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x631BDC0", Offset = "0x631ABC0", VA = "0x18631BDC0", Slot = "6")]
	public void BOHFBAPPANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class CNAEGHLCCMB : GBOPPMEKOPM, BJJFLCNOKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode GMAGAOFHOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x631A890", Offset = "0x6319690", VA = "0x18631A890")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x631A9F0", Offset = "0x63197F0", VA = "0x18631A9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x631A570", Offset = "0x6319370", VA = "0x18631A570", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x631A970", Offset = "0x6319770", VA = "0x18631A970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public CNAEGHLCCMB(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x631AAE0", Offset = "0x63198E0", VA = "0x18631AAE0", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x631A4E0", Offset = "0x63192E0", VA = "0x18631A4E0", Slot = "9")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x631AC40", Offset = "0x6319A40", VA = "0x18631AC40", Slot = "7")]
	public void PNJEPLFPOMM(bool OENOBJMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x631A880", Offset = "0x6319680", VA = "0x18631A880", Slot = "8")]
	public void ELDFNEOBPBB(bool OENOBJMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x631AC50", Offset = "0x6319A50", VA = "0x18631AC50", Slot = "10")]
	public bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x631A680", Offset = "0x6319480", VA = "0x18631A680")]
	private void DLCGECAJPPH(bool OENOBJMCJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class PGLINAMDJMJ : IReadOnlyList<IALNGFFKNLN>, IEnumerable<IALNGFFKNLN>, IEnumerable, IReadOnlyCollection<IALNGFFKNLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly AAOBMHINIMM DNLLCPMDAID;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F35B70", Offset = "0x6F34970", VA = "0x186F35B70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public IALNGFFKNLN MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6F35C40", Offset = "0x6F34A40", VA = "0x186F35C40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6F35B20", Offset = "0x6F34920", VA = "0x186F35B20")]
	public PGLINAMDJMJ(EGCGFMJAHFA BBBLGPNEOJP, AAOBMHINIMM DNLLCPMDAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6F35990", Offset = "0x6F34790", VA = "0x186F35990", Slot = "6")]
	public IEnumerator<IALNGFFKNLN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6F35990", Offset = "0x6F34790", VA = "0x186F35990", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6F35980", Offset = "0x6F34780", VA = "0x186F35980")]
	[CompilerGenerated]
	private IALNGFFKNLN EDLGAFLAGHK(int EFGAFPEAGGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MBECAHNBMCN : ADAILKIPHED
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6F33010", Offset = "0x6F31E10", VA = "0x186F33010", Slot = "4")]
	public OIFOPOHAFPB ANNDNAJJOFM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6F33710", Offset = "0x6F32510", VA = "0x186F33710", Slot = "5")]
	public MKIOOEIOHIP PLCCLHMAKNM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6F33200", Offset = "0x6F32000", VA = "0x186F33200", Slot = "6")]
	public PNCCDDDKOCF BLABPLKENBJ(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6F33340", Offset = "0x6F32140", VA = "0x186F33340", Slot = "7")]
	public CGOLBACNLLK GGDJAJDLFNG(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6F331A0", Offset = "0x6F31FA0", VA = "0x186F331A0", Slot = "8")]
	public HCFELOBKGID BIGIOGEFDAN(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6F33600", Offset = "0x6F32400", VA = "0x186F33600", Slot = "9")]
	public LDIIINLPLHP OOEPPHJENMK(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6F33410", Offset = "0x6F32210", VA = "0x186F33410", Slot = "10")]
	public HJPNGMGJMDN IBKJADICPAF(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6F335A0", Offset = "0x6F323A0", VA = "0x186F335A0", Slot = "11")]
	public CIKDHHPJFFL ODLMKJEEAAO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6F33540", Offset = "0x6F32340", VA = "0x186F33540", Slot = "12")]
	public BJJFLCNOKNL KGANBOGAEFP(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6F33470", Offset = "0x6F32270", VA = "0x186F33470", Slot = "13")]
	public KJLHMIPJPNH ICOCGDJFBPO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6F333A0", Offset = "0x6F321A0", VA = "0x186F333A0")]
	public EAKOJIJAJHN LONFOCMCGKC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6F33260", Offset = "0x6F32060", VA = "0x186F33260")]
	public EIMKGKBMLOG EBLKMNKPDMD(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6F332D0", Offset = "0x6F320D0", VA = "0x186F332D0")]
	public NMPBGFBGGBD MODNEAFIHDM(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6F32FA0", Offset = "0x6F31DA0", VA = "0x186F32FA0")]
	public IFINNAKNKCK AHEFAPJEEGF(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6F334D0", Offset = "0x6F322D0", VA = "0x186F334D0")]
	public NBADJKPBDNO NKAPFOCNGOL(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F33660", Offset = "0x6F32460", VA = "0x186F33660", Slot = "19")]
	public IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ, EIAOGNGKKKE PNDAGJIDNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public MBECAHNBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6F333A0", Offset = "0x6F321A0", VA = "0x186F333A0", Slot = "14")]
	private EAKOJIJAJHN GJCMDDJNKEE(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6F33260", Offset = "0x6F32060", VA = "0x186F33260", Slot = "15")]
	private EIMKGKBMLOG MCEAHHKLION(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F332D0", Offset = "0x6F320D0", VA = "0x186F332D0", Slot = "16")]
	private NMPBGFBGGBD EODMBOOGFOC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6F32FA0", Offset = "0x6F31DA0", VA = "0x186F32FA0", Slot = "17")]
	private IFINNAKNKCK COIECADNJAO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F334D0", Offset = "0x6F322D0", VA = "0x186F334D0", Slot = "18")]
	private NBADJKPBDNO JDEFFCNKICO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class DNIMJOOKPIB : GBOPPMEKOPM, HCFELOBKGID
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public const int HKLIOKBMGDC = 10;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const float OAAHJBGGCHD = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float JOMBCLMMJHK = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float MIHDINNGHNC = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool IPEPENJLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x631BAB0", Offset = "0x631A8B0", VA = "0x18631BAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x631BB50", Offset = "0x631A950", VA = "0x18631BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x631BE00", Offset = "0x631AC00", VA = "0x18631BE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x631B970", Offset = "0x631A770", VA = "0x18631B970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool LBHIMBLEEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x631BE60", Offset = "0x631AC60", VA = "0x18631BE60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x631B420", Offset = "0x631A220", VA = "0x18631B420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool BENBNCCIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x631B9D0", Offset = "0x631A7D0", VA = "0x18631B9D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x631B880", Offset = "0x631A680", VA = "0x18631B880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int GFKEJJMDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x631B030", Offset = "0x6319E30", VA = "0x18631B030")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x631BCC0", Offset = "0x631AAC0", VA = "0x18631BCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event IFNJCNLFDEL BKLODMPEDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x631BB70", Offset = "0x631A970", VA = "0x18631BB70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x631AF90", Offset = "0x6319D90", VA = "0x18631AF90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x631BF40", Offset = "0x631AD40", VA = "0x18631BF40")]
	public DNIMJOOKPIB(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x631BC10", Offset = "0x631AA10", VA = "0x18631BC10", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x631BDB0", Offset = "0x631ABB0", VA = "0x18631BDB0", Slot = "8")]
	public void NDHGMECENAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x631B510", Offset = "0x631A310", VA = "0x18631B510", Slot = "7")]
	public bool CFPNCHFMENI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x631B370", Offset = "0x631A170", VA = "0x18631B370", Slot = "9")]
	public void CBGLCKOLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x631BDC0", Offset = "0x631ABC0", VA = "0x18631BDC0", Slot = "12")]
	public void NMEGEDMPEND(bool LBLKJDFBHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x631B2C0", Offset = "0x631A0C0", VA = "0x18631B2C0", Slot = "11")]
	public void BLIEODGKOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "10")]
	public void NJDEBHJDAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x631B110", Offset = "0x6319F10", VA = "0x18631B110")]
	private bool BKFLIONCNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x631B730", Offset = "0x631A530", VA = "0x18631B730")]
	private void CMIJNBENPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PGKHHMAEBMO(typeof(ADAILKIPHED), new string[] { })]
public class INLPEGBMDNM : ADAILKIPHED, MLAMHJJBADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ADAILKIPHED EMBPPALJEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ADAILKIPHED AMINOMAJENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private OFOPFPOKLCG ADNDPOMCNLP;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private ADAILKIPHED ECDBAGNEFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6336FC0", Offset = "0x6335DC0", VA = "0x186336FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x63375F0", Offset = "0x63363F0", VA = "0x1863375F0", Slot = "20")]
	public void InitReferences(JNPNBLMGJNE LIBJJFNFJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6337020", Offset = "0x6335E20", VA = "0x186337020", Slot = "4")]
	public OIFOPOHAFPB ANNDNAJJOFM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6337A20", Offset = "0x6336820", VA = "0x186337A20", Slot = "5")]
	public MKIOOEIOHIP PLCCLHMAKNM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6337160", Offset = "0x6335F60", VA = "0x186337160", Slot = "6")]
	public PNCCDDDKOCF BLABPLKENBJ(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6337360", Offset = "0x6336160", VA = "0x186337360", Slot = "7")]
	public CGOLBACNLLK GGDJAJDLFNG(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x63370C0", Offset = "0x6335EC0", VA = "0x1863370C0", Slot = "8")]
	public HCFELOBKGID BIGIOGEFDAN(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6337830", Offset = "0x6336630", VA = "0x186337830", Slot = "9")]
	public LDIIINLPLHP OOEPPHJENMK(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x63374B0", Offset = "0x63362B0", VA = "0x1863374B0", Slot = "10")]
	public HJPNGMGJMDN IBKJADICPAF(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6337790", Offset = "0x6336590", VA = "0x186337790", Slot = "11")]
	public CIKDHHPJFFL ODLMKJEEAAO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x63376F0", Offset = "0x63364F0", VA = "0x1863376F0", Slot = "12")]
	public BJJFLCNOKNL KGANBOGAEFP(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6337550", Offset = "0x6336350", VA = "0x186337550", Slot = "13")]
	public KJLHMIPJPNH ICOCGDJFBPO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6337400", Offset = "0x6336200", VA = "0x186337400")]
	public EAKOJIJAJHN LONFOCMCGKC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6337200", Offset = "0x6336000", VA = "0x186337200")]
	public EIMKGKBMLOG EBLKMNKPDMD(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x63372B0", Offset = "0x63360B0", VA = "0x1863372B0")]
	public NMPBGFBGGBD MODNEAFIHDM(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6336F10", Offset = "0x6335D10", VA = "0x186336F10")]
	public IFINNAKNKCK AHEFAPJEEGF(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6337640", Offset = "0x6336440", VA = "0x186337640")]
	public NBADJKPBDNO NKAPFOCNGOL(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x63378D0", Offset = "0x63366D0", VA = "0x1863378D0", Slot = "19")]
	public IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ, EIAOGNGKKKE PNDAGJIDNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6337AC0", Offset = "0x63368C0", VA = "0x186337AC0")]
	public INLPEGBMDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6337400", Offset = "0x6336200", VA = "0x186337400", Slot = "14")]
	private EAKOJIJAJHN GJCMDDJNKEE(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6337200", Offset = "0x6336000", VA = "0x186337200", Slot = "15")]
	private EIMKGKBMLOG MCEAHHKLION(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x63372B0", Offset = "0x63360B0", VA = "0x1863372B0", Slot = "16")]
	private NMPBGFBGGBD EODMBOOGFOC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6336F10", Offset = "0x6335D10", VA = "0x186336F10", Slot = "17")]
	private IFINNAKNKCK COIECADNJAO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6337640", Offset = "0x6336440", VA = "0x186337640", Slot = "18")]
	private NBADJKPBDNO JDEFFCNKICO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class LLFMACLDBPH : GBOPPMEKOPM, KJLHMIPJPNH
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6F32C80", Offset = "0x6F31A80", VA = "0x186F32C80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6F32DB0", Offset = "0x6F31BB0", VA = "0x186F32DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F20", Offset = "0x6F31D20", VA = "0x186F32F20")]
	public LLFMACLDBPH(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F32B60", Offset = "0x6F31960", VA = "0x186F32B60", Slot = "6")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F32D70", Offset = "0x6F31B70", VA = "0x186F32D70", Slot = "7")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class GBOPPMEKOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly PHPKPLLNMHF LEDEJPFJONC;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected AAOBMHINIMM MLBOGFEFIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1264910", Offset = "0x1263710", VA = "0x181264910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x631EA10", Offset = "0x631D810", VA = "0x18631EA10")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public GBOPPMEKOPM(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x631EA40", Offset = "0x631D840", VA = "0x18631EA40")]
	protected IALNGFFKNLN MIHCMFFJEAH(EGCGFMJAHFA BBBLGPNEOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class JFPCJGMECJF : GBOPPMEKOPM, EIMKGKBMLOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private PhotonView EEOMANDKECF;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x631C140", Offset = "0x631AF40", VA = "0x18631C140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x63391F0", Offset = "0x6337FF0", VA = "0x1863391F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event IFNJCNLFDEL DHIKPIOCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6338940", Offset = "0x6337740", VA = "0x186338940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6339150", Offset = "0x6337F50", VA = "0x186339150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6339310", Offset = "0x6338110", VA = "0x186339310")]
	public JFPCJGMECJF(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6338BC0", Offset = "0x63379C0", VA = "0x186338BC0", Slot = "8")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x63383B0", Offset = "0x63371B0", VA = "0x1863383B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6338730", Offset = "0x6337530", VA = "0x186338730", Slot = "9")]
	public void GNCCHFFDOCI(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6338F40", Offset = "0x6337D40", VA = "0x186338F40", Slot = "10")]
	public void MGINMFDINPO(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6338D10", Offset = "0x6337B10", VA = "0x186338D10")]
	private void LFLIJMBBKNN(PhotonView DBDKGCMLCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63385A0", Offset = "0x63373A0", VA = "0x1863385A0")]
	private void FFEKGNECKMK(RigidbodyEx PCKMCLCEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63389E0", Offset = "0x63377E0", VA = "0x1863389E0")]
	private void JNIDCCKEFHK(PhotonView AOEDCDDPHPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class GIADPHIDEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6323730", Offset = "0x6322530", VA = "0x186323730")]
	public static JFPCJGMECJF CJEPDILKFMD(this GOKKFMHLLAO MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class FMNBICMFDBH : GBOPPMEKOPM, NBADJKPBDNO
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x631DFF0", Offset = "0x631CDF0", VA = "0x18631DFF0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x631DB20", Offset = "0x631C920", VA = "0x18631DB20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool NOOGGOBEFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x631DC10", Offset = "0x631CA10", VA = "0x18631DC10", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x631DA30", Offset = "0x631C830", VA = "0x18631DA30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x631D950", Offset = "0x631C750", VA = "0x18631D950", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x631DDF0", Offset = "0x631CBF0", VA = "0x18631DDF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x631E0D0", Offset = "0x631CED0", VA = "0x18631E0D0")]
	public FMNBICMFDBH(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x631D850", Offset = "0x631C650", VA = "0x18631D850", Slot = "9")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x631DCF0", Offset = "0x631CAF0", VA = "0x18631DCF0", Slot = "10")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class HJNEDLBNCEB : GBOPPMEKOPM, LDIIINLPLHP, IDisposable, KMLGDIKJPGE
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MNKJPBHDJIH KIPIAABBONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6332360", Offset = "0x6331160", VA = "0x186332360")]
		get
		{
			return default(MNKJPBHDJIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6332130", Offset = "0x6330F30", VA = "0x186332130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6332440", Offset = "0x6331240", VA = "0x186332440", Slot = "6")]
		get
		{
			return default(MNKJPBHDJIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6332130", Offset = "0x6330F30", VA = "0x186332130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform OGLNPJHALAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6332220", Offset = "0x6331020", VA = "0x186332220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x63322C0", Offset = "0x63310C0", VA = "0x1863322C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x631ADC0", Offset = "0x6319BC0", VA = "0x18631ADC0")]
	public HJNEDLBNCEB(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6332660", Offset = "0x6331460", VA = "0x186332660", Slot = "11")]
	public void OnChangedDistanceBand(BBLMJPEOFPH PMPNCLBDLNA, BBLMJPEOFPH ECOPHBMBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "12")]
	public void OnChangedVisibility(bool INLLACPAEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class EKJJEAFMKEC : LDIIINLPLHP, IDisposable, KMLGDIKJPGE
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int DFIJOFDNADA = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private MNKJPBHDJIH DOJIIOCFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private LEKPDBJGEEP BBOOALHIMMH;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public MNKJPBHDJIH GAFGFPPMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x631D0A0", Offset = "0x631BEA0", VA = "0x18631D0A0", Slot = "6")]
		get
		{
			return default(MNKJPBHDJIH);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x631CE40", Offset = "0x631BC40", VA = "0x18631CE40", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform OGLNPJHALAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x631D520", Offset = "0x631C320", VA = "0x18631D520", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<BBLMJPEOFPH, BBLMJPEOFPH> IJIBJAKIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x631CF10", Offset = "0x631BD10", VA = "0x18631CF10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x631CFB0", Offset = "0x631BDB0", VA = "0x18631CFB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x631D540", Offset = "0x631C340", VA = "0x18631D540")]
	public EKJJEAFMKEC(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x631D240", Offset = "0x631C040", VA = "0x18631D240", Slot = "8")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x631D050", Offset = "0x631BE50", VA = "0x18631D050", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x631D1E0", Offset = "0x631BFE0", VA = "0x18631D1E0", Slot = "11")]
	private void HAFDMOGCLKC(BBLMJPEOFPH NBFPLCPGBFE, BBLMJPEOFPH PEJJGPPCBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "12")]
	private void HFLIGOBHEAN(bool INLLACPAEAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class DNJDHAAMPME : FNCIBFKIHKN, EIMKGKBMLOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PhotonView EEOMANDKECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool GKHIOOPNCCM;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView BCNMFMEFBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool IEHNKMMIJID
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x631C140", Offset = "0x631AF40", VA = "0x18631C140", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool PEPAEONPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event IFNJCNLFDEL DHIKPIOCKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x631C570", Offset = "0x631B370", VA = "0x18631C570", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x631CD00", Offset = "0x631BB00", VA = "0x18631CD00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x631CDA0", Offset = "0x631BBA0", VA = "0x18631CDA0")]
	public DNJDHAAMPME(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x631C8A0", Offset = "0x631B6A0", VA = "0x18631C8A0", Slot = "9")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x631C160", Offset = "0x631AF60", VA = "0x18631C160", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x631C3E0", Offset = "0x631B1E0", VA = "0x18631C3E0", Slot = "10")]
	public void GNCCHFFDOCI(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x631CB70", Offset = "0x631B970", VA = "0x18631CB70", Slot = "11")]
	public void MGINMFDINPO(IALNGFFKNLN GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x631C9F0", Offset = "0x631B7F0", VA = "0x18631C9F0")]
	private void LFLIJMBBKNN(PhotonView DBDKGCMLCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x631C270", Offset = "0x631B070", VA = "0x18631C270")]
	private void FFEKGNECKMK(RigidbodyEx PCKMCLCEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x631C610", Offset = "0x631B410", VA = "0x18631C610")]
	private void JNIDCCKEFHK(PhotonView AOEDCDDPHPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class BFDMMJALBHG
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6318500", Offset = "0x6317300", VA = "0x186318500")]
	public static FNCIBFKIHKN CJEPDILKFMD(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class CGHCCMKPGMK : EAKOJIJAJHN
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const string GHCCNCPOEDK = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LHKDGCOKKGC EHJAAIBFGNK;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x6319870", Offset = "0x6318670", VA = "0x186319870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool LJKGGCJKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CB80", Offset = "0x1A5B980", VA = "0x181A5CB80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x631A3F0", Offset = "0x63191F0", VA = "0x18631A3F0")]
	public CGHCCMKPGMK(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x6319B00", Offset = "0x6318900", VA = "0x186319B00", Slot = "5")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6319AD0", Offset = "0x63188D0", VA = "0x186319AD0", Slot = "7")]
	public void KPECEJGALAC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x63193A0", Offset = "0x63181A0", VA = "0x1863193A0", Slot = "8")]
	public void EKFGHHIJGFL(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6319F10", Offset = "0x6318D10", VA = "0x186319F10", Slot = "9")]
	public void OJFIBFHCMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x63198D0", Offset = "0x63186D0", VA = "0x1863198D0", Slot = "10")]
	public void IEHCDHJECBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x631A270", Offset = "0x6319070", VA = "0x18631A270", Slot = "11")]
	public void PHALJJHEJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x63193D0", Offset = "0x63181D0", VA = "0x1863193D0", Slot = "12")]
	public void FJLKKIGBBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6319D60", Offset = "0x6318B60", VA = "0x186319D60")]
	private void NCBMMMDIABD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6319BB0", Offset = "0x63189B0", VA = "0x186319BB0")]
	private void LMJJKLGAPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class GMLDCIGKEBM : NBADJKPBDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private RigidbodyConstraints LJBMLIOKNCM;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool BKIOEHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F40", Offset = "0x9A3D40", VA = "0x1809A4F40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A4F50", Offset = "0x9A3D50", VA = "0x1809A4F50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool NOOGGOBEFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3182C40", Offset = "0x3181A40", VA = "0x183182C40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x12D89A0", Offset = "0x12D77A0", VA = "0x1812D89A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints GFJPNPBCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x63238B0", Offset = "0x63226B0", VA = "0x1863238B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63239F0", Offset = "0x63227F0", VA = "0x1863239F0")]
	public GMLDCIGKEBM(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6323850", Offset = "0x6322650", VA = "0x186323850", Slot = "9")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6323880", Offset = "0x6322680", VA = "0x186323880", Slot = "10")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GDOLFKCKFJC : CIKDHHPJFFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x631EE20", Offset = "0x631DC20", VA = "0x18631EE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6319870", Offset = "0x6318670", VA = "0x186319870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x631F890", Offset = "0x631E690", VA = "0x18631F890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x631F8F0", Offset = "0x631E6F0", VA = "0x18631F8F0")]
	public GDOLFKCKFJC(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x631ECC0", Offset = "0x631DAC0", VA = "0x18631ECC0", Slot = "4")]
	public void HKBLJBPIIPE(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x631EE70", Offset = "0x631DC70", VA = "0x18631EE70")]
	private void IBNLFDEOFEF(Vector3 CONMELFNDPK, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x631F5F0", Offset = "0x631E3F0", VA = "0x18631F5F0", Slot = "5")]
	public void NPLDDBIEFMH(Vector3 CONMELFNDPK, Vector3 IHHJAKDKGPC, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x631EB60", Offset = "0x631D960", VA = "0x18631EB60", Slot = "6")]
	public void FGODPGJMOMO(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x631F0F0", Offset = "0x631DEF0", VA = "0x18631F0F0")]
	private void JBAJKKAOMKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x631F370", Offset = "0x631E170", VA = "0x18631F370", Slot = "7")]
	public void KEFEJFBPGKL(Vector3 MHIPCOMEGLM, ForceMode NCPHBEKKHLG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class PNFBFJFLGHF : IAGCCGCHEPH, PNCCDDDKOCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ILCGPACMPCB<IALNGFFKNLN> NGHJHCKHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool GBPBAGAIGEB;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public ILCGPACMPCB<IALNGFFKNLN> NFDOMJAJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 POJCLIPECGH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F368E0", Offset = "0x6F356E0", VA = "0x186F368E0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 BBCIHMFBGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F370F0", Offset = "0x6F35EF0", VA = "0x186F370F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F36FB0", Offset = "0x6F35DB0", VA = "0x186F36FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IALNGFFKNLN EKDLBKFMOED
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F36860", Offset = "0x6F35660", VA = "0x186F36860", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F37290", Offset = "0x6F36090", VA = "0x186F37290")]
	public PNFBFJFLGHF(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F36C80", Offset = "0x6F35A80", VA = "0x186F36C80", Slot = "8")]
	public void FOALLBDKCNE(IALNGFFKNLN GMBPOBACJJI, object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F37090", Offset = "0x6F35E90", VA = "0x186F37090", Slot = "9")]
	public void JOGGLKJKLHN(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F36CF0", Offset = "0x6F35AF0", VA = "0x186F36CF0")]
	private Vector3 GIAIJPHLPAC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F36910", Offset = "0x6F35710", VA = "0x186F36910")]
	private void FJOPKGKHJEI(IALNGFFKNLN FALFKPBJAOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class GJONCMHEDFM
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6323790", Offset = "0x6322590", VA = "0x186323790")]
	public static IAGCCGCHEPH DLIJDJMICGD(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class HCGECCALBJH : CGIGBEFKFDP, IFINNAKNKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly OverridableVector3 OGKLPMINDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 DKNNDEIMELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float LHHPCOFPECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float BPAIDGPANCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Vector3 EGAGGEIKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3? KNPDJDGFNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Quaternion? CFBCJFMEGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool BEGGJGMLEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool PKABPGDFMLM;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 AELHPIBFHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1BE0", Offset = "0x4FE09E0", VA = "0x184FE1BE0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x632DFE0", Offset = "0x632CDE0", VA = "0x18632DFE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 BMKOHJLAKII
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x632E6B0", Offset = "0x632D4B0", VA = "0x18632E6B0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float FOJKLBPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xC8B490", Offset = "0xC8A290", VA = "0x180C8B490", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x632E090", Offset = "0x632CE90", VA = "0x18632E090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float IKGOPPNHHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1B55890", Offset = "0x1B54690", VA = "0x181B55890", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x632DD70", Offset = "0x632CB70", VA = "0x18632DD70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 HLMLLGFGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x632E9C0", Offset = "0x632D7C0", VA = "0x18632E9C0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion GNPNPCHGBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x632F580", Offset = "0x632E380", VA = "0x18632F580", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x632F2D0", Offset = "0x632E0D0", VA = "0x18632F2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event IFNJCNLFDEL GAIPCOJICPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x632F230", Offset = "0x632E030", VA = "0x18632F230", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x632E7B0", Offset = "0x632D5B0", VA = "0x18632E7B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x632F6F0", Offset = "0x632E4F0", VA = "0x18632F6F0")]
	public HCGECCALBJH(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x632DE20", Offset = "0x632CC20", VA = "0x18632DE20", Slot = "17")]
	public void BNKJGKNHLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x632E320", Offset = "0x632D120", VA = "0x18632E320", Slot = "16")]
	public void GAOADMKHFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x632DC90", Offset = "0x632CA90", VA = "0x18632DC90", Slot = "19")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x632F320", Offset = "0x632E120", VA = "0x18632F320", Slot = "20")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x632E850", Offset = "0x632D650", VA = "0x18632E850", Slot = "18")]
	public void KMNOHMMJKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x632EB30", Offset = "0x632D930", VA = "0x18632EB30", Slot = "21")]
	public void MEDKFCBLLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x632DFE0", Offset = "0x632CDE0", VA = "0x18632DFE0")]
	private void GHFCMBJGBMJ(Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x632E5B0", Offset = "0x632D3B0", VA = "0x18632E5B0")]
	[Obsolete]
	private Vector3 INEHLPLKOGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x632E090", Offset = "0x632CE90", VA = "0x18632E090")]
	private void JECPHEALEGK(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x632DD70", Offset = "0x632CB70", VA = "0x18632DD70")]
	private void MKNJOIAJOIO(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x632E1B0", Offset = "0x632CFB0", VA = "0x18632E1B0")]
	private Vector3 FNBMKMDDCFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x632EFF0", Offset = "0x632DDF0", VA = "0x18632EFF0", Slot = "15")]
	public void MNDGPPDAOPE((Quaternion rot, Vector3 moments) INIANJPOEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x632E440", Offset = "0x632D240", VA = "0x18632E440")]
	private Quaternion GJGCMLDOBPO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x632DBB0", Offset = "0x632C9B0", VA = "0x18632DBB0")]
	public void APBNGMGGMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x632CCF0", Offset = "0x632BAF0", VA = "0x18632CCF0", Slot = "4")]
	public (float, Vector3) APBNGMGGMEG(Rigidbody MLBCOOBBBGK)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class MPCOOMIFOAO
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6F34180", Offset = "0x6F32F80", VA = "0x186F34180")]
	public static CGIGBEFKFDP KMJPHJDNODP(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface IAGCCGCHEPH : PNCCDDDKOCF
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	ILCGPACMPCB<IALNGFFKNLN> NFDOMJAJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	IALNGFFKNLN EKDLBKFMOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GNAJCNNKNGP : MKIOOEIOHIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LHKDGCOKKGC DDBBKDCOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private float GCPCFLAFFFD;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public EGEGDCABNBB ANDFKAGCBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x838D80", Offset = "0x837B80", VA = "0x180838D80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public BJMPOEOOJOD CHDINDNKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 NONHJKDNIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x63250E0", Offset = "0x6323EE0", VA = "0x1863250E0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6324E00", Offset = "0x6323C00", VA = "0x186324E00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 FHJJEHFFFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x63260D0", Offset = "0x6324ED0", VA = "0x1863260D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6324D10", Offset = "0x6323B10", VA = "0x186324D10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 EHLBLONNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6324FB0", Offset = "0x6323DB0", VA = "0x186324FB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6325540", Offset = "0x6324340", VA = "0x186325540", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 HJBEILNBEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6324EC0", Offset = "0x6323CC0", VA = "0x186324EC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6324BC0", Offset = "0x63239C0", VA = "0x186324BC0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float LENBPNMMAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xD6BBD0", Offset = "0xD6A9D0", VA = "0x180D6BBD0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6324BF0", Offset = "0x63239F0", VA = "0x186324BF0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool DNHBNNEOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x1A99B20", Offset = "0x1A98920", VA = "0x181A99B20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private CIKDHHPJFFL BNICLINLGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x29AEF10", Offset = "0x29ADD10", VA = "0x1829AEF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x631BB50", Offset = "0x631A950", VA = "0x18631BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x6326870", Offset = "0x6325670", VA = "0x186326870")]
	public GNAJCNNKNGP(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6325600", Offset = "0x6324400", VA = "0x186325600", Slot = "19")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6324DA0", Offset = "0x6323BA0", VA = "0x186324DA0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x6324A90", Offset = "0x6323890", VA = "0x186324A90", Slot = "28")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1A997D0", Offset = "0x1A985D0", VA = "0x181A997D0", Slot = "20")]
	public void BCFPDJEFOBH(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1A99050", Offset = "0x1A97E50", VA = "0x181A99050", Slot = "31")]
	public void BEKBIOKODGA(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6325200", Offset = "0x6324000", VA = "0x186325200", Slot = "36")]
	public Vector3 HCOPMGDHDCE(Vector3 CEOAKEMPANE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6323DC0", Offset = "0x6322BC0", VA = "0x186323DC0", Slot = "35")]
	public Vector3 APIBJKGDLJI(Vector3 NNODOCALLNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6325600", Offset = "0x6324400", VA = "0x186325600", Slot = "27")]
	public void JDCBOABIJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6325990", Offset = "0x6324790", VA = "0x186325990", Slot = "25")]
	public void KBDPAPHONNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x6326280", Offset = "0x6325080", VA = "0x186326280", Slot = "24")]
	public void OIJAMDNJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x63264F0", Offset = "0x63252F0", VA = "0x1863264F0", Slot = "34")]
	public void PDPGPKCFLHI(Vector3 IADFGDHFMKJ, Vector3 KJHIFNGMMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6324D40", Offset = "0x6323B40", VA = "0x186324D40", Slot = "33")]
	public void DEFEBCBIINH(Vector3 DPCMLJCFEHN, Vector3 CEMPKCEOHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6324950", Offset = "0x6323750", VA = "0x186324950", Slot = "32")]
	public void BIDFFMKKIHO(Vector3 GDDEOPEKIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6324500", Offset = "0x6323300", VA = "0x186324500", Slot = "22")]
	public void BHCLFGJPFCI(LBNGCHOCAHD NCJMADCNFHO, Vector3 BAJBNGLNLPF, float DLPHPKDHIAL, float LEFEAADDOCH = 8f, float IAEKKDPLLNH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x63262C0", Offset = "0x63250C0", VA = "0x1863262C0", Slot = "21")]
	public void PAKEFPOJCAF(AMCNMDEBLKK GGBIFNIKGDC, Vector3 KEDGNOGDIJL, float DEFDEFHLBPN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6324130", Offset = "0x6322F30", VA = "0x186324130", Slot = "23")]
	[Obsolete]
	public void BECJMPHICME(AMCNMDEBLKK GGBIFNIKGDC, Vector3 EMNOFGLPALH, float IACHGJCPLNE = 7f, float ONDDBCLLOPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x63261C0", Offset = "0x6324FC0", VA = "0x1863261C0", Slot = "30")]
	public Vector3 OIABDKINBPG(Vector3 LDCHPECNIMD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x63259D0", Offset = "0x63247D0", VA = "0x1863259D0", Slot = "29")]
	public Vector3 KFENALNODBH(Vector3 OFMHBIEBPJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x63253E0", Offset = "0x63241E0", VA = "0x1863253E0", Slot = "26")]
	public void IBAOFCANNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6324BF0", Offset = "0x63239F0", VA = "0x186324BF0")]
	private void BMDEFPEJBON(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6326730", Offset = "0x6325530", VA = "0x186326730")]
	private void PIGABDBLJPM(Vector3 KEDGNOGDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6323F80", Offset = "0x6322D80", VA = "0x186323F80")]
	private Vector3 BAFCGALEOLN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6325670", Offset = "0x6324470", VA = "0x186325670")]
	private void JHAKCAJJLCC(Vector3 NNODOCALLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6324400", Offset = "0x6323200", VA = "0x186324400")]
	private Vector3 BFNFMPBLCOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6323A90", Offset = "0x6322890", VA = "0x186323A90")]
	private void AAKFHDCMHLH(Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6325AD0", Offset = "0x63248D0", VA = "0x186325AD0")]
	private void NAPLKAFCFCK(Vector3 NNODOCALLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6324070", Offset = "0x6322E70", VA = "0x186324070")]
	private void BCKCMFFLGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class KOLDEAOICCI : HJPNGMGJMDN
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private const string MNDDMKHOMJC = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly LHKDGCOKKGC OCBBFPDGHJD;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool MOGBHMOHBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6F301D0", Offset = "0x6F2EFD0", VA = "0x186F301D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> CMGNAEHMDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6F30310", Offset = "0x6F2F110", VA = "0x186F30310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event IFNJCNLFDEL NHDANFKPPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6F30130", Offset = "0x6F2EF30", VA = "0x186F30130", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6F30270", Offset = "0x6F2F070", VA = "0x186F30270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6F30360", Offset = "0x6F2F160", VA = "0x186F30360")]
	public KOLDEAOICCI(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FE50", Offset = "0x6F2EC50", VA = "0x186F2FE50", Slot = "12")]
	public IDisposable BKCIPBJCHLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF50", Offset = "0x6F2ED50", VA = "0x186F2FF50", Slot = "9")]
	public void DLJPCIDNJKK(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FDC0", Offset = "0x6F2EBC0", VA = "0x186F2FDC0", Slot = "10")]
	public void AJHIMKJCCCC(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6F30030", Offset = "0x6F2EE30", VA = "0x186F30030", Slot = "11")]
	public void FAEBOJNIKJG(object GKNJCIECGND, bool FDNLKPOOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF10", Offset = "0x6F2ED10", VA = "0x186F2FF10", Slot = "6")]
	public void BOHFBAPPANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FDD0", Offset = "0x6F2EBD0", VA = "0x186F2FDD0", Slot = "13")]
	public void BJCGJBOMHCB(Rigidbody MFDMLFENPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6F30330", Offset = "0x6F2F130", VA = "0x186F30330", Slot = "14")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JPIOIMAPGHA : BJJFLCNOKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private CollisionDetectionMode IDKLOPNLCFM;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x631ABF0", Offset = "0x63199F0", VA = "0x18631ABF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode EBIKFCEDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x633AD20", Offset = "0x6339B20", VA = "0x18633AD20", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x633AF70", Offset = "0x6339D70", VA = "0x18633AF70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x631F8F0", Offset = "0x631E6F0", VA = "0x18631F8F0")]
	public JPIOIMAPGHA(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x633AFE0", Offset = "0x6339DE0", VA = "0x18633AFE0", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x633ACA0", Offset = "0x6339AA0", VA = "0x18633ACA0", Slot = "9")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x633B100", Offset = "0x6339F00", VA = "0x18633B100", Slot = "7")]
	public void PNJEPLFPOMM(bool OENOBJMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x633AF60", Offset = "0x6339D60", VA = "0x18633AF60", Slot = "8")]
	public void ELDFNEOBPBB(bool OENOBJMCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x633B110", Offset = "0x6339F10", VA = "0x18633B110", Slot = "10")]
	public bool POKGBEBBDDM(Vector3 DMABJFINPCN, out RaycastHit KBGFPDHGIJI, float HLNABDEKNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x633AE30", Offset = "0x6339C30", VA = "0x18633AE30")]
	private void DLCGECAJPPH(bool OENOBJMCJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AGBBGJGCMOE : ADAILKIPHED
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6317280", Offset = "0x6316080", VA = "0x186317280", Slot = "4")]
	public OIFOPOHAFPB ANNDNAJJOFM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6317D60", Offset = "0x6316B60", VA = "0x186317D60", Slot = "5")]
	public MKIOOEIOHIP PLCCLHMAKNM(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6317450", Offset = "0x6316250", VA = "0x186317450", Slot = "6")]
	public PNCCDDDKOCF BLABPLKENBJ(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x63176A0", Offset = "0x63164A0", VA = "0x1863176A0", Slot = "7")]
	public CGOLBACNLLK GGDJAJDLFNG(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6317370", Offset = "0x6316170", VA = "0x186317370", Slot = "8")]
	public HCFELOBKGID BIGIOGEFDAN(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6317B80", Offset = "0x6316980", VA = "0x186317B80", Slot = "9")]
	public LDIIINLPLHP OOEPPHJENMK(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6317830", Offset = "0x6316630", VA = "0x186317830", Slot = "10")]
	public HJPNGMGJMDN IBKJADICPAF(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6317AD0", Offset = "0x63168D0", VA = "0x186317AD0", Slot = "11")]
	public CIKDHHPJFFL ODLMKJEEAAO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6317A20", Offset = "0x6316820", VA = "0x186317A20", Slot = "12")]
	public BJJFLCNOKNL KGANBOGAEFP(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6317890", Offset = "0x6316690", VA = "0x186317890", Slot = "13")]
	public KJLHMIPJPNH ICOCGDJFBPO(IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6317710", Offset = "0x6316510", VA = "0x186317710")]
	public EAKOJIJAJHN LONFOCMCGKC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x63174B0", Offset = "0x63162B0", VA = "0x1863174B0")]
	public EIMKGKBMLOG EBLKMNKPDMD(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6317580", Offset = "0x6316380", VA = "0x186317580")]
	public NMPBGFBGGBD MODNEAFIHDM(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6317150", Offset = "0x6315F50", VA = "0x186317150")]
	public IFINNAKNKCK AHEFAPJEEGF(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6317950", Offset = "0x6316750", VA = "0x186317950")]
	public NBADJKPBDNO NKAPFOCNGOL(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6317C40", Offset = "0x6316A40", VA = "0x186317C40", Slot = "19")]
	public IALNGFFKNLN OOGHFDKGEEL(RigidbodyEx LEDEJPFJONC, KNMEOCMIJIH FAJCHBCCGOJ, EIAOGNGKKKE PNDAGJIDNCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public AGBBGJGCMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x6317710", Offset = "0x6316510", VA = "0x186317710", Slot = "14")]
	private EAKOJIJAJHN GJCMDDJNKEE(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x63174B0", Offset = "0x63162B0", VA = "0x1863174B0", Slot = "15")]
	private EIMKGKBMLOG MCEAHHKLION(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6317580", Offset = "0x6316380", VA = "0x186317580", Slot = "16")]
	private NMPBGFBGGBD EODMBOOGFOC(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6317150", Offset = "0x6315F50", VA = "0x186317150", Slot = "17")]
	private IFINNAKNKCK COIECADNJAO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6317950", Offset = "0x6316750", VA = "0x186317950", Slot = "18")]
	private NBADJKPBDNO JDEFFCNKICO(IALNGFFKNLN MLPNLAGGHNI, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class HHIPEMEFJMO : HEPKBHODPEN, OIFOPOHAFPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly IALNGFFKNLN LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly List<IALNGFFKNLN> OINDOPOHBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private IALNGFFKNLN BHODGDEIEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private IALNGFFKNLN GMBPOBACJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Transform MNGJPAKAGOK;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x6330030", Offset = "0x632EE30", VA = "0x186330030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6330350", Offset = "0x632F150", VA = "0x186330350", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public IALNGFFKNLN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<IALNGFFKNLN> HEGGKNALOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event IFNJCNLFDEL KAGOLOCGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x632FA00", Offset = "0x632E800", VA = "0x18632FA00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x632F880", Offset = "0x632E680", VA = "0x18632F880", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event IFNJCNLFDEL AEDPCMKMNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x63310F0", Offset = "0x632FEF0", VA = "0x1863310F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x6330FB0", Offset = "0x632FDB0", VA = "0x186330FB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event OIDDCDOJCLP NNPHJKIILCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x632FDD0", Offset = "0x632EBD0", VA = "0x18632FDD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x632FD30", Offset = "0x632EB30", VA = "0x18632FD30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action FLKLBAJIKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6330360", Offset = "0x632F160", VA = "0x186330360", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x632F960", Offset = "0x632E760", VA = "0x18632F960", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action IFIFPLHFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x63308D0", Offset = "0x632F6D0", VA = "0x1863308D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6330400", Offset = "0x632F200", VA = "0x186330400", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<IALNGFFKNLN> KNBCIOJNONG
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6330090", Offset = "0x632EE90", VA = "0x186330090", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6331190", Offset = "0x632FF90", VA = "0x186331190", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<IALNGFFKNLN> JDPFLLJJCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x632FF10", Offset = "0x632ED10", VA = "0x18632FF10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x632FAA0", Offset = "0x632E8A0", VA = "0x18632FAA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action GFNJNPKMJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x632FB40", Offset = "0x632E940", VA = "0x18632FB40", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6330970", Offset = "0x632F770", VA = "0x186330970", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<IALNGFFKNLN> FOABOMCNIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x6331050", Offset = "0x632FE50", VA = "0x186331050", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x632FE70", Offset = "0x632EC70", VA = "0x18632FE70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6331490", Offset = "0x6330290", VA = "0x186331490")]
	public HHIPEMEFJMO(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x632FFB0", Offset = "0x632EDB0", VA = "0x18632FFB0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6330A10", Offset = "0x632F810", VA = "0x186330A10", Slot = "30")]
	public void KPFIAOMFCDP(IALNGFFKNLN DOJCGKKDJND, bool HKPKHHHLHMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x6331230", Offset = "0x6330030", VA = "0x186331230", Slot = "6")]
	public void ODDJDBLOLGF(IALNGFFKNLN LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x6330700", Offset = "0x632F500", VA = "0x186330700", Slot = "7")]
	public void KDAJMNLBGMP(IALNGFFKNLN LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6330660", Offset = "0x632F460", VA = "0x186330660", Slot = "4")]
	public void JGLPKFEFEPD(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x63313F0", Offset = "0x63301F0", VA = "0x1863313F0", Slot = "5")]
	public void OOMFGDNBOAA(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x63305D0", Offset = "0x632F3D0", VA = "0x1863305D0")]
	private void ILKKONNJNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x632F920", Offset = "0x632E720", VA = "0x18632F920")]
	private void ACLLGKLKLID(IALNGFFKNLN LLDBOKELGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x632FBE0", Offset = "0x632E9E0", VA = "0x18632FBE0")]
	private void BIOFMKBFPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x6330220", Offset = "0x632F020", VA = "0x186330220")]
	private void FCLKOIELBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x63304A0", Offset = "0x632F2A0", VA = "0x1863304A0")]
	private void IJEKPOLJAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6330130", Offset = "0x632EF30", VA = "0x186330130")]
	[CompilerGenerated]
	private object EJJMBGDMHED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class MNCJIIKPOBG
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x6F34100", Offset = "0x6F32F00", VA = "0x186F34100")]
	public static HEPKBHODPEN HMGBIMLLIDC(this IALNGFFKNLN MLPNLAGGHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class FPGNFBMJNPH : NMPBGFBGGBD
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const string PBFCHKKHDLG = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly LHKDGCOKKGC OOHDKNGIAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ALFCLIHOIFK NOABEHCLBOM;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool MFOPKPKPJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x1A5CB80", Offset = "0x1A5B980", VA = "0x181A5CB80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public ALFCLIHOIFK HAKJBDNGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0", Slot = "5")]
		get
		{
			return default(ALFCLIHOIFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x631E920", Offset = "0x631D720", VA = "0x18631E920")]
	public FPGNFBMJNPH(IALNGFFKNLN LEDEJPFJONC, in KNMEOCMIJIH FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x631E7D0", Offset = "0x631D5D0", VA = "0x18631E7D0", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x631E4C0", Offset = "0x631D2C0", VA = "0x18631E4C0")]
	private bool EDKABCILPJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x631E7A0", Offset = "0x631D5A0", VA = "0x18631E7A0", Slot = "7")]
	public void ICNLGMGOCPN(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x631E490", Offset = "0x631D290", VA = "0x18631E490", Slot = "8")]
	public void BMKMOJIOGGF(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x631E560", Offset = "0x631D360", VA = "0x18631E560", Slot = "11")]
	public void EGAALMNGAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x631E690", Offset = "0x631D490", VA = "0x18631E690")]
	private void GIJCDHPONMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x631E310", Offset = "0x631D110", VA = "0x18631E310")]
	private void ADFEKAGJNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x631E8A0", Offset = "0x631D6A0", VA = "0x18631E8A0", Slot = "10")]
	public void OKLALIPFLPJ(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x631E8E0", Offset = "0x631D6E0", VA = "0x18631E8E0", Slot = "9")]
	public void PBAEKOAAOCJ(IALNGFFKNLN LEDEJPFJONC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CGIGBEFKFDP : IFINNAKNKCK
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) APBNGMGGMEG(Rigidbody MLBCOOBBBGK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HEPKBHODPEN : OIFOPOHAFPB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGLPKFEFEPD(IALNGFFKNLN LEDEJPFJONC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOMFGDNBOAA(IALNGFFKNLN LEDEJPFJONC);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODDJDBLOLGF(IALNGFFKNLN LLDBOKELGIF);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDAJMNLBGMP(IALNGFFKNLN LLDBOKELGIF);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class BFJCFMLLNIE : KJLHMIPJPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool BDDLPAANOKK;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool JELEANJODIB
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x935A20", Offset = "0x934820", VA = "0x180935A20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6318660", Offset = "0x6317460", VA = "0x186318660", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x6318770", Offset = "0x6317570", VA = "0x186318770")]
	public BFJCFMLLNIE(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x63185C0", Offset = "0x63173C0", VA = "0x1863185C0", Slot = "6")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x63185F0", Offset = "0x63173F0", VA = "0x1863185F0", Slot = "7")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HHNNBDDFKOL : HCFELOBKGID
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int HKLIOKBMGDC = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const float OAAHJBGGCHD = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float JOMBCLMMJHK = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float MIHDINNGHNC = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly GOKKFMHLLAO LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private bool KCFJKBHDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool IJNHMCNJIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private int EELACDAEOIA;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody NEMLBINNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x632F2D0", Offset = "0x632E0D0", VA = "0x18632F2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool IPEPENJLGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6331C30", Offset = "0x6330A30", VA = "0x186331C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool PIEFCHMNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x6331CD0", Offset = "0x6330AD0", VA = "0x186331CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private IALNGFFKNLN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6332020", Offset = "0x6330E20", VA = "0x186332020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool KCGKKPBCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6331BD0", Offset = "0x63309D0", VA = "0x186331BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event IFNJCNLFDEL BKLODMPEDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6331CF0", Offset = "0x6330AF0", VA = "0x186331CF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x6331550", Offset = "0x6330350", VA = "0x186331550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6332080", Offset = "0x6330E80", VA = "0x186332080")]
	public HHNNBDDFKOL(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6331D90", Offset = "0x6330B90", VA = "0x186331D90", Slot = "6")]
	public void LBINDKHDICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x6331E20", Offset = "0x6330C20", VA = "0x186331E20", Slot = "8")]
	public void NDHGMECENAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x63318E0", Offset = "0x63306E0", VA = "0x1863318E0", Slot = "7")]
	public bool CFPNCHFMENI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6331840", Offset = "0x6330640", VA = "0x186331840", Slot = "9")]
	public void CBGLCKOLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x63317A0", Offset = "0x63305A0", VA = "0x1863317A0", Slot = "11")]
	public void BLIEODGKOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x6331FE0", Offset = "0x6330DE0", VA = "0x186331FE0", Slot = "12")]
	public void NMEGEDMPEND(bool LBLKJDFBHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x6331E30", Offset = "0x6330C30", VA = "0x186331E30", Slot = "10")]
	public void NJDEBHJDAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x63315F0", Offset = "0x63303F0", VA = "0x1863315F0")]
	private bool BKFLIONCNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6331A40", Offset = "0x6330840", VA = "0x186331A40")]
	private void CMIJNBENPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class BBJAPEGJDPB : CGOLBACNLLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly IALNGFFKNLN LEDEJPFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float JJAPGBCDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float BEKPKNPABJJ;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float IGCPKFHIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x952E10", Offset = "0x951C10", VA = "0x180952E10", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6318350", Offset = "0x6317150", VA = "0x186318350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float HBOBNEHCGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC54A00", Offset = "0xC53800", VA = "0x180C54A00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x6318280", Offset = "0x6317080", VA = "0x186318280", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x63184C0", Offset = "0x63172C0", VA = "0x1863184C0")]
	public BBJAPEGJDPB(IALNGFFKNLN LEDEJPFJONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x6318230", Offset = "0x6317030", VA = "0x186318230", Slot = "8")]
	public void BJCGJBOMHCB(Rigidbody DDMKFDDLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x6318420", Offset = "0x6317220", VA = "0x186318420", Slot = "9")]
	public void NIHDJIJKCNH(Rigidbody DDMKFDDLOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface FNCIBFKIHKN : EIMKGKBMLOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView BCNMFMEFBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : CEBDOCPDCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C960", Offset = "0x6F3B760", VA = "0x186F3C960", Slot = "6")]
		public sealed override void IBHIGIGKEIP(EIAOOKBBMKJ IIPKIDOCHMK)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
