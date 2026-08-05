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
		public static HFMPGNIBJKD UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int DBPCFMOAGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int GFDIKGLODBN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E568F0", Offset = "0x6E55AF0", VA = "0x186E568F0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E56930", Offset = "0x6E55B30", VA = "0x186E56930")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E56910", Offset = "0x6E55B10", VA = "0x186E56910")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JPOEHOENKPI, [Optional] UnityEngine.Object JDFBABENAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JPOEHOENKPI, [Optional] UnityEngine.Object JDFBABENAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E56A20", Offset = "0x6E55C20", VA = "0x186E56A20")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AAJBANJCLIH
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class FHCPJAOEPHM : EJBDMPOPPCG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD51560", Offset = "0xD50760", VA = "0x180D51560", Slot = "4")]
		public Vector3 AFIENOGDEKL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD51560", Offset = "0xD50760", VA = "0x180D51560", Slot = "5")]
		public Vector3 DPMCLMPNMHG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FHCPJAOEPHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EJBDMPOPPCG ANBEKFFKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA500", Offset = "0x5AF9700", VA = "0x185AFA500")]
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
		private static readonly PEKDFCFCENH LGHHMCDAOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool GBEEDJCDOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private JNNFBKKLCNP FHLHCPACODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GADDJAGEFDD(PFIMANMCDOB.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[GADDJAGEFDD(PFIMANMCDOB.SelfAndParent, true, false, false)]
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
		private DDKBLCFBKDC physicsInterpolation;

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
		internal JNNFBKKLCNP MLPMIPJPDID
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E56A70", Offset = "0x6E55C70", VA = "0x186E56A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> IELDKDGLEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx CGDONPKMDCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E59520", Offset = "0x6E58720", VA = "0x186E59520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NMFNLMEMDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E594C0", Offset = "0x6E586C0", VA = "0x186E594C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx OJEMCPHOKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A010", Offset = "0x6E59210", VA = "0x186E5A010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B480", Offset = "0x6E5A680", VA = "0x186E5B480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform AIHHJFGALFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBE1B30", Offset = "0xBE0D30", VA = "0x180BE1B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform BNLJGJBLPCM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBE1B30", Offset = "0xBE0D30", VA = "0x180BE1B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EIEHKGHKNNG COLLNILCOHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6E59280", Offset = "0x6E58480", VA = "0x186E59280")]
			get
			{
				return default(EIEHKGHKNNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC70", Offset = "0x6E59E70", VA = "0x186E5AC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HNFBBGDNHEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E59720", Offset = "0x6E58920", VA = "0x186E59720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GPLMOONBEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E593A0", Offset = "0x6E585A0", VA = "0x186E593A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EJBDMPOPPCG CHIJILNJGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E59660", Offset = "0x6E58860", VA = "0x186E59660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AE30", Offset = "0x6E5A030", VA = "0x186E5AE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ANKGBAPAGNP LFBGPIICJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6E59600", Offset = "0x6E58800", VA = "0x186E59600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6E5ADC0", Offset = "0x6E59FC0", VA = "0x186E5ADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EOGICCLHOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E59550", Offset = "0x6E58750", VA = "0x186E59550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody FHBDNCAGEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E595B0", Offset = "0x6E587B0", VA = "0x186E595B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FEDBINNMPLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E59400", Offset = "0x6E58600", VA = "0x186E59400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E5ACE0", Offset = "0x6E59EE0", VA = "0x186E5ACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ILCHNKINAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1500DA0", Offset = "0x14FFFA0", VA = "0x181500DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x43FBB00", Offset = "0x43FAD00", VA = "0x1843FBB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float KFLBBLALBEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6E59FB0", Offset = "0x6E591B0", VA = "0x186E59FB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float FKHLIFIDPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6E59F50", Offset = "0x6E59150", VA = "0x186E59F50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B410", Offset = "0x6E5A610", VA = "0x186E5B410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NPCGKJPCPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E59970", Offset = "0x6E58B70", VA = "0x186E59970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B0C0", Offset = "0x6E5A2C0", VA = "0x186E5B0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KGDEANLCBAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E59780", Offset = "0x6E58980", VA = "0x186E59780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AEA0", Offset = "0x6E5A0A0", VA = "0x186E5AEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool AIGNLPFDKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A4E0", Offset = "0x6E596E0", VA = "0x186E5A4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B970", Offset = "0x6E5AB70", VA = "0x186E5B970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 PBAIHAACBEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E59D50", Offset = "0x6E58F50", VA = "0x186E59D50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B200", Offset = "0x6E5A400", VA = "0x186E5B200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 GHKLNKAOCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A610", Offset = "0x6E59810", VA = "0x186E5A610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode MEKKGMKIKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E598B0", Offset = "0x6E58AB0", VA = "0x186E598B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AFE0", Offset = "0x6E5A1E0", VA = "0x186E5AFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NJIJFHJDACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E59460", Offset = "0x6E58660", VA = "0x186E59460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD50", Offset = "0x6E59F50", VA = "0x186E5AD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints LFNBMNEJBMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6E59910", Offset = "0x6E58B10", VA = "0x186E59910")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B050", Offset = "0x6E5A250", VA = "0x186E5B050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 IJHPBAJMGNC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A070", Offset = "0x6E59270", VA = "0x186E5A070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 NHAJLPJDIND
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A070", Offset = "0x6E59270", VA = "0x186E5A070")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B760", Offset = "0x6E5A960", VA = "0x186E5B760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float MELLDFCPCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6E59E20", Offset = "0x6E59020", VA = "0x186E59E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B2D0", Offset = "0x6E5A4D0", VA = "0x186E5B2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JABLBNOGEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A480", Offset = "0x6E59680", VA = "0x186E5A480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B900", Offset = "0x6E5AB00", VA = "0x186E5B900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion JEJCNHKILMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A140", Offset = "0x6E59340", VA = "0x186E5A140")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B4F0", Offset = "0x6E5A6F0", VA = "0x186E5B4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion MMMNCDNPKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A3B0", Offset = "0x6E595B0", VA = "0x186E5A3B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B830", Offset = "0x6E5AA30", VA = "0x186E5B830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DHMCEHJGKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A210", Offset = "0x6E59410", VA = "0x186E5A210")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B5C0", Offset = "0x6E5A7C0", VA = "0x186E5B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NGBHKBFPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A2E0", Offset = "0x6E594E0", VA = "0x186E5A2E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B690", Offset = "0x6E5A890", VA = "0x186E5B690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 NHADPEGDINF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A540", Offset = "0x6E59740", VA = "0x186E5A540")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B9E0", Offset = "0x6E5ABE0", VA = "0x186E5B9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DIJLLIEJNJK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E59E80", Offset = "0x6E59080", VA = "0x186E59E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B340", Offset = "0x6E5A540", VA = "0x186E5B340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FDDOLPLJELI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6E597E0", Offset = "0x6E589E0", VA = "0x186E597E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AF10", Offset = "0x6E5A110", VA = "0x186E5AF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HHEOJMFHCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6E59C80", Offset = "0x6E58E80", VA = "0x186E59C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B130", Offset = "0x6E5A330", VA = "0x186E5B130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KMHFCIGLKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6E59B50", Offset = "0x6E58D50", VA = "0x186E59B50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion NDOHNAIABBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6E59A80", Offset = "0x6E58C80", VA = "0x186E59A80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 FJNAOAAHCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A7B0", Offset = "0x6E599B0", VA = "0x186E5A7B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PLBINEABDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A6E0", Offset = "0x6E598E0", VA = "0x186E5A6E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool FNCAGMCDJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6E59C20", Offset = "0x6E58E20", VA = "0x186E59C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool NOOMLKKPLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6E596C0", Offset = "0x6E588C0", VA = "0x186E596C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool JOFBFPLILJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6E59340", Offset = "0x6E58540", VA = "0x186E59340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ADMDIOHDIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6E592E0", Offset = "0x6E584E0", VA = "0x186E592E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AJMPPBDBJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6E59220", Offset = "0x6E58420", VA = "0x186E59220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DDKHKJKHLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E599D0", Offset = "0x6E58BD0", VA = "0x186E599D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DILEBBOMEIA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2CF0210", Offset = "0x2CEF410", VA = "0x182CF0210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FHMOCDKOLCB KDDNNAKHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6E59140", Offset = "0x6E58340", VA = "0x186E59140")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB90", Offset = "0x6E59D90", VA = "0x186E5AB90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MMLNCAADDIJ POGOKBEJEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6E590D0", Offset = "0x6E582D0", VA = "0x186E590D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB20", Offset = "0x6E59D20", VA = "0x186E5AB20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event FHMOCDKOLCB PGDBJJOKEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E58E30", Offset = "0x6E58030", VA = "0x186E58E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A880", Offset = "0x6E59A80", VA = "0x186E5A880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event FHMOCDKOLCB ACIGIMNAPIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6E58EA0", Offset = "0x6E580A0", VA = "0x186E58EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A8F0", Offset = "0x6E59AF0", VA = "0x186E5A8F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event FHMOCDKOLCB BNCEOMFHLOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E58FF0", Offset = "0x6E581F0", VA = "0x186E58FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AA40", Offset = "0x6E59C40", VA = "0x186E5AA40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E58F80", Offset = "0x6E58180", VA = "0x186E58F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A9D0", Offset = "0x6E59BD0", VA = "0x186E5A9D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event FHMOCDKOLCB DPAFEMGCJJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E59060", Offset = "0x6E58260", VA = "0x186E59060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AAB0", Offset = "0x6E59CB0", VA = "0x186E5AAB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event FHMOCDKOLCB LMNBCKOFHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6E591B0", Offset = "0x6E583B0", VA = "0x186E591B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC00", Offset = "0x6E59E00", VA = "0x186E5AC00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event FHMOCDKOLCB HGFAHEFHFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6E58F10", Offset = "0x6E58110", VA = "0x186E58F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6E5A960", Offset = "0x6E59B60", VA = "0x186E5A960")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		internal void PJOAPLGCPLH(JNNFBKKLCNP KPCECNDHFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E57B00", Offset = "0x6E56D00", VA = "0x186E57B00")]
		internal void FMLNJIGCBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E58B20", Offset = "0x6E57D20", VA = "0x186E58B20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody FFNFBCHKGBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E58840", Offset = "0x6E57A40", VA = "0x186E58840")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BCLEDNCILCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6E574C0", Offset = "0x6E566C0", VA = "0x186E574C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E56A70", Offset = "0x6E55C70", VA = "0x186E56A70")]
		private JNNFBKKLCNP LIBFMGDJLKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E57770", Offset = "0x6E56970", VA = "0x186E57770")]
		private void FGNOPHJIAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E58030", Offset = "0x6E57230", VA = "0x186E58030")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E57B00", Offset = "0x6E56D00", VA = "0x186E57B00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6E57FD0", Offset = "0x6E571D0", VA = "0x186E57FD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E58090", Offset = "0x6E57290", VA = "0x186E58090")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E56B20", Offset = "0x6E55D20", VA = "0x186E56B20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E58100", Offset = "0x6E57300", VA = "0x186E58100")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E57710", Offset = "0x6E56910", VA = "0x186E57710")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E57F70", Offset = "0x6E57170", VA = "0x186E57F70")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E58940", Offset = "0x6E57B40", VA = "0x186E58940")]
		public void SetParent(RigidbodyEx NABCGCEIEGG, bool AEDCFFPKIIA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E58400", Offset = "0x6E57600", VA = "0x186E58400")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E57D90", Offset = "0x6E56F90", VA = "0x186E57D90")]
		public bool IsRigidbodyAncestor(RigidbodyEx MOMLIJDNAEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6E57DD0", Offset = "0x6E56FD0", VA = "0x186E57DD0")]
		public bool IsRigidbodyDescendant(RigidbodyEx JIEACFIKHOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E56D90", Offset = "0x6E55F90", VA = "0x186E56D90")]
		public void AddInterpolationRestriction(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E58170", Offset = "0x6E57370", VA = "0x186E58170")]
		public void RemoveInterpolationRestriction(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E57530", Offset = "0x6E56730", VA = "0x186E57530")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E56E00", Offset = "0x6E56000", VA = "0x186E56E00")]
		public void AddKinematic(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6E581E0", Offset = "0x6E573E0", VA = "0x186E581E0")]
		public void RemoveKinematic(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E588C0", Offset = "0x6E57AC0", VA = "0x186E588C0")]
		public void SetKinematic(object FDCOCHLAHJD, bool ALGGMCABHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E58750", Offset = "0x6E57950", VA = "0x186E58750")]
		public void SetDiscontinuousPositionAndRotation(Vector3 GEICLMBHNCD, Quaternion JENNBLFMFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E58660", Offset = "0x6E57860", VA = "0x186E58660")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 HLHPPEJOIGH, Quaternion HOFLFMNCNEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E57C90", Offset = "0x6E56E90", VA = "0x186E57C90")]
		public Vector3 GetConstrainedVelocity(Vector3 NHADPEGDINF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E57B90", Offset = "0x6E56D90", VA = "0x186E57B90")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FDDOLPLJELI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E56CA0", Offset = "0x6E55EA0", VA = "0x186E56CA0")]
		public void AddForce(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E56B90", Offset = "0x6E55D90", VA = "0x186E56B90")]
		public void AddForceAtPosition(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E56FD0", Offset = "0x6E561D0", VA = "0x186E56FD0")]
		public void AddTorque(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E56E70", Offset = "0x6E56070", VA = "0x186E56E70")]
		public void AddRelativeTorque(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E58C00", Offset = "0x6E57E00", VA = "0x186E58C00")]
		public Vector3 WorldToLocalVelocity(Vector3 GPMDOJGCNNI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E57E70", Offset = "0x6E57070", VA = "0x186E57E70")]
		public Vector3 LocalToWorldVelocity(Vector3 DIJLLIEJNJK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E576B0", Offset = "0x6E568B0", VA = "0x186E576B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E57650", Offset = "0x6E56850", VA = "0x186E57650")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E575F0", Offset = "0x6E567F0", VA = "0x186E575F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E57590", Offset = "0x6E56790", VA = "0x186E57590")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E58560", Offset = "0x6E57760", VA = "0x186E58560")]
		public void ResetVelocityWorldSpace(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E58460", Offset = "0x6E57660", VA = "0x186E58460")]
		public void ResetVelocityLocalSpace(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E58330", Offset = "0x6E57530", VA = "0x186E58330")]
		public void ResetLinearVelocityLocalSpace(Vector3 DNBIGGMJMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E58A30", Offset = "0x6E57C30", VA = "0x186E58A30")]
		public bool SweepTest(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6E57E10", Offset = "0x6E57010", VA = "0x186E57E10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E589D0", Offset = "0x6E57BD0", VA = "0x186E589D0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E58BA0", Offset = "0x6E57DA0", VA = "0x186E58BA0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E56F60", Offset = "0x6E56160", VA = "0x186E56F60")]
		public void AddShouldHaveUnityRigidbodyToken(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E58250", Offset = "0x6E57450", VA = "0x186E58250")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6E57300", Offset = "0x6E56500", VA = "0x186E57300")]
		public void ApplyForceVelocityChange(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E57210", Offset = "0x6E56410", VA = "0x186E57210")]
		public void ApplyAngularVelocityChange(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E573C0", Offset = "0x6E565C0", VA = "0x186E573C0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E57150", Offset = "0x6E56350", VA = "0x186E57150")]
		public bool AllowedScaleChange(float AJOPLFDEMOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E570C0", Offset = "0x6E562C0", VA = "0x186E570C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx NNCDMIKDPHD, object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E582C0", Offset = "0x6E574C0", VA = "0x186E582C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E58D90", Offset = "0x6E57F90", VA = "0x186E58D90")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class ADPKLNMBBIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB390", Offset = "0x5AFA590", VA = "0x185AFB390")]
	public static JNNFBKKLCNP MLPMIPJPDID(this RigidbodyEx IPECNCNJKEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FHMOCDKOLCB(RigidbodyEx BDCHBJKFPFH);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DDKBLCFBKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ODNJCKFBJEK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PDMLEGIKGPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Rigidbody POLLJMGANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public PhotonView IONLKPOKNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OverridableVector3 IADJPJPANBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OverridableVector3 GJEHAPNKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public DDKBLCFBKDC NPMHEGCJEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool GBPHHADEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool LICAAPALAAK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void MMLNCAADDIJ(RigidbodyEx BDCHBJKFPFH, bool AEDCFFPKIIA = false);
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DDDGJOKMEDO(typeof(ONMJEHFOPKC), new string[] { "Ignore", "Mock" })]
public class CCMPHLCKLMA : ONMJEHFOPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DICLNFKOJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
	public void DJDBNANEGED(string BMNKLBFFLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void MAEKMAEHDBL(RigidbodyEx IPECNCNJKEI, Action AMEKOPCKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "7")]
	public MCBHBLDEFKB CKHIJIFLLNK(int CADGNJBONJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
	public void KNILJHKDDGL(Vector3 GHKLNKAOCCE, float DKLPAMKELHF, Color GGJPGIMIKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public CCMPHLCKLMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DDDGJOKMEDO(typeof(BEHCIJIDLFI), new string[] { })]
public class KIINALLMICN : BEHCIJIDLFI, DCLDDNDKGBL
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private PKKEKIECBNE IJNKFHNOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private ONMJEHFOPKC LJKHADFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JPNGNCNEENI MFFDAOAAOBC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ONMJEHFOPKC JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JPNGNCNEENI JOEJCJHPHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B113F0", Offset = "0x5B105F0", VA = "0x185B113F0", Slot = "10")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B10FF0", Offset = "0x5B101F0", VA = "0x185B10FF0", Slot = "6")]
	public BMDJOHDFBDL FNBHICMIOEE(RigidbodyEx IPECNCNJKEI)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B112F0", Offset = "0x5B104F0", VA = "0x185B112F0")]
	private static BMDJOHDFBDL FPBCDDAGIMG(RigidbodyEx IPECNCNJKEI)
	{
		return default(BMDJOHDFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B10D10", Offset = "0x5B0FF10", VA = "0x185B10D10", Slot = "7")]
	public JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B10DB0", Offset = "0x5B0FFB0", VA = "0x185B10DB0", Slot = "8")]
	public void BNCECLOACBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B10EA0", Offset = "0x5B100A0", VA = "0x185B10EA0", Slot = "9")]
	public void DBCKEKGEOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public KIINALLMICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HFBDJJOGMLG
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B08FB0", Offset = "0x5B081B0", VA = "0x185B08FB0")]
	public static void HDCAIPBBHFE(this Rigidbody FFNFBCHKGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B08EA0", Offset = "0x5B080A0", VA = "0x185B08EA0")]
	public static void HDCAIPBBHFE(this Rigidbody FFNFBCHKGBE, Vector3 MIMFDOMJCBE, Quaternion NDOHNAIABBD, Vector3 LPNCNGDJBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1AD74C0", Offset = "0x1AD66C0", VA = "0x181AD74C0")]
	public static void NELJJFKOMEO(Vector3 NHADPEGDINF, Vector3 AHEOGBFEFAD, out Vector3 ILHHJMONADN, out Vector3 JNOEDJAJIIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum AHAMDIDODGE
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OIBGLHFGEDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FHMOCDKOLCB LHFNBHELECJ;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFLMGBECOEP(JNNFBKKLCNP OJEMCPHOKBP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MBBLCNONAFI(JNNFBKKLCNP OJEMCPHOKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AHOFNLCCEAG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float ECIGOEANLFE
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
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COOFPFOLHOK(Rigidbody POLLJMGANIP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface ONMJEHFOPKC
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool DICLNFKOJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJDBNANEGED(string BMNKLBFFLLF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAEKMAEHDBL(RigidbodyEx IPECNCNJKEI, Action AMEKOPCKNIK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCBHBLDEFKB CKHIJIFLLNK(int CADGNJBONJE);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNILJHKDDGL(Vector3 GHKLNKAOCCE, float DKLPAMKELHF, Color GGJPGIMIKJF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface BEHCIJIDLFI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ONMJEHFOPKC JOECKGCKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JPNGNCNEENI JOEJCJHPHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMDJOHDFBDL FNBHICMIOEE(RigidbodyEx IPECNCNJKEI);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNCECLOACBI();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DBCKEKGEOED();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LPMHKAOMCFP
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx IDCEGNMPEOL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MHFPEKHOIMM
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBGHHBLMJDP(JNNFBKKLCNP OJEMCPHOKBP, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEJGNJICIEA(object FDCOCHLAHJD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FPHDCGCGPMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B055E0", Offset = "0x5B047E0", VA = "0x185B055E0")]
	public FPHDCGCGPMM(PAFFMNAJGCG CINIEBHLBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B05580", Offset = "0x5B04780", VA = "0x185B05580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PAFFMNAJGCG : JNNFBKKLCNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly BEHCIJIDLFI MHGFMGGOLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal KOANIGNFMFL HBHMCMADCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DDJGOOKKHFM NELGIBKGJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal OIBGLHFGEDH BNMBMDEENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal BOPFKHAHFCC NHADPEGDINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal MHFPEKHOIMM INOPLHLCIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal BDPEDMBBICC LEINKJAMKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal AHOFNLCCEAG DCLCBDBJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal EBNHILLEDLL KBEDKPDGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal FDONOFLBIKP IJJJELNKCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MKFCLLNMJLN NELOALCPECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal IEMGGGMGCPB KCPFDLJOHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal EFKPJKOBEKA BEIAPGFNLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal GEKNMADPOKF IBEDDMJMJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal BAOCCFHJKDL POLLJMGANIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal PEMJLNPLGEL CHOBAIMIJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IDisposable DKHMKNIFOAC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public RigidbodyEx MILNGHOHCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E70", Offset = "0x8D4070", VA = "0x1808D4E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GameObject KHDPFEHDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA13AD0", Offset = "0xA12CD0", VA = "0x180A13AD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA13AC0", Offset = "0xA12CC0", VA = "0x180A13AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Transform JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E56590", Offset = "0x6E55790", VA = "0x186E56590", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E54E50", Offset = "0x6E54050", VA = "0x186E54E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E50700", Offset = "0x6E4F900", VA = "0x186E50700", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E54B60", Offset = "0x6E53D60", VA = "0x186E54B60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E53170", Offset = "0x6E52370", VA = "0x186E53170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E50CA0", Offset = "0x6E4FEA0", VA = "0x186E50CA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E53700", Offset = "0x6E52900", VA = "0x186E53700", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E51780", Offset = "0x6E50980", VA = "0x186E51780", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E52510", Offset = "0x6E51710", VA = "0x186E52510", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E51120", Offset = "0x6E50320", VA = "0x186E51120", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E53DE0", Offset = "0x6E52FE0", VA = "0x186E53DE0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E549A0", Offset = "0x6E53BA0", VA = "0x186E549A0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E55490", Offset = "0x6E54690", VA = "0x186E55490", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6E55320", Offset = "0x6E54520", VA = "0x186E55320", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6E549F0", Offset = "0x6E53BF0", VA = "0x186E549F0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6E556E0", Offset = "0x6E548E0", VA = "0x186E556E0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6E50D40", Offset = "0x6E4FF40", VA = "0x186E50D40", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6E52890", Offset = "0x6E51A90", VA = "0x186E52890", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E51260", Offset = "0x6E50460", VA = "0x186E51260", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6E55CF0", Offset = "0x6E54EF0", VA = "0x186E55CF0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6E54390", Offset = "0x6E53590", VA = "0x186E54390", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6E553C0", Offset = "0x6E545C0", VA = "0x186E553C0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6E554F0", Offset = "0x6E546F0", VA = "0x186E554F0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool JOFBFPLILJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6E55FE0", Offset = "0x6E551E0", VA = "0x186E55FE0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ADMDIOHDIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E56780", Offset = "0x6E55980", VA = "0x186E56780", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool AJMPPBDBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E54060", Offset = "0x6E53260", VA = "0x186E54060", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6E53C40", Offset = "0x6E52E40", VA = "0x186E53C40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6E55160", Offset = "0x6E54360", VA = "0x186E55160", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6E51600", Offset = "0x6E50800", VA = "0x186E51600", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E547F0", Offset = "0x6E539F0", VA = "0x186E547F0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E52CA0", Offset = "0x6E51EA0", VA = "0x186E52CA0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6E55EB0", Offset = "0x6E550B0", VA = "0x186E55EB0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6E53E40", Offset = "0x6E53040", VA = "0x186E53E40", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6E531C0", Offset = "0x6E523C0", VA = "0x186E531C0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6E54FD0", Offset = "0x6E541D0", VA = "0x186E54FD0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6E52960", Offset = "0x6E51B60", VA = "0x186E52960", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E53B10", Offset = "0x6E52D10", VA = "0x186E53B10", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6E52290", Offset = "0x6E51490", VA = "0x186E52290", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6E52F00", Offset = "0x6E52100", VA = "0x186E52F00", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float ECIGOEANLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6E53FF0", Offset = "0x6E531F0", VA = "0x186E53FF0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6E53C90", Offset = "0x6E52E90", VA = "0x186E53C90", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CFDJGMFCIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E55370", Offset = "0x6E54570", VA = "0x186E55370", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6E517D0", Offset = "0x6E509D0", VA = "0x186E517D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6E56380", Offset = "0x6E55580", VA = "0x186E56380", Slot = "48")]
		get
		{
			return default(LGJDBCELJGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E52060", Offset = "0x6E51260", VA = "0x186E52060", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6E54C10", Offset = "0x6E53E10", VA = "0x186E54C10", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Transform BNLJGJBLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6E55FD0", Offset = "0x6E551D0", VA = "0x186E55FD0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Vector3 FNJEBECGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6E526B0", Offset = "0x6E518B0", VA = "0x186E526B0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6E516D0", Offset = "0x6E508D0", VA = "0x186E516D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public float HOONDNJHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E511E0", Offset = "0x6E503E0", VA = "0x186E511E0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6E51390", Offset = "0x6E50590", VA = "0x186E51390", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public float FHGKACAELGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6E54040", Offset = "0x6E53240", VA = "0x186E54040", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6E52FB0", Offset = "0x6E521B0", VA = "0x186E52FB0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Quaternion LJIKOHIAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6E54D40", Offset = "0x6E53F40", VA = "0x186E54D40", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6E55230", Offset = "0x6E54430", VA = "0x186E55230", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Vector3 IEOOHOKMJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6E54EA0", Offset = "0x6E540A0", VA = "0x186E54EA0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6E51F70", Offset = "0x6E51170", VA = "0x186E51F70", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Quaternion NDNFEPKHJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6E51FC0", Offset = "0x6E511C0", VA = "0x186E51FC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6E556A0", Offset = "0x6E548A0", VA = "0x186E556A0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public RigidbodyConstraints KMCJGCKIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6E51F20", Offset = "0x6E51120", VA = "0x186E51F20", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6E54B00", Offset = "0x6E53D00", VA = "0x186E54B00", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6E50AD0", Offset = "0x6E4FCD0", VA = "0x186E50AD0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6E50C40", Offset = "0x6E4FE40", VA = "0x186E50C40", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CollisionDetectionMode NHLPADNJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6E51A10", Offset = "0x6E50C10", VA = "0x186E51A10", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6E53860", Offset = "0x6E52A60", VA = "0x186E53860", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool HNOEMKACOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E52560", Offset = "0x6E51760", VA = "0x186E52560", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool NOOMLKKPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E52D70", Offset = "0x6E51F70", VA = "0x186E52D70", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool CBHFDIOOKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E530C0", Offset = "0x6E522C0", VA = "0x186E530C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool NPBGMAJHLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6E51D40", Offset = "0x6E50F40", VA = "0x186E51D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event FHMOCDKOLCB PGDBJJOKEID
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E55100", Offset = "0x6E54300", VA = "0x186E55100", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E527E0", Offset = "0x6E519E0", VA = "0x186E527E0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event FHMOCDKOLCB ACIGIMNAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E55DC0", Offset = "0x6E54FC0", VA = "0x186E55DC0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E53490", Offset = "0x6E52690", VA = "0x186E53490", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event MMLNCAADDIJ AOOINOALPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E564D0", Offset = "0x6E556D0", VA = "0x186E564D0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E53F90", Offset = "0x6E53190", VA = "0x186E53F90", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event FHMOCDKOLCB LHFNBHELECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E55860", Offset = "0x6E54A60", VA = "0x186E55860", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E510C0", Offset = "0x6E502C0", VA = "0x186E510C0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FHMOCDKOLCB BNCEOMFHLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6E52000", Offset = "0x6E51200", VA = "0x186E52000", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6E534F0", Offset = "0x6E526F0", VA = "0x186E534F0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event FHMOCDKOLCB AHDFCKMFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E54DF0", Offset = "0x6E53FF0", VA = "0x186E54DF0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6E50B80", Offset = "0x6E4FD80", VA = "0x186E50B80", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6E56720", Offset = "0x6E55920", VA = "0x186E56720", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6E51DD0", Offset = "0x6E50FD0", VA = "0x186E51DD0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event FHMOCDKOLCB KGGDBIPPADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E50BE0", Offset = "0x6E4FDE0", VA = "0x186E50BE0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6E56530", Offset = "0x6E55730", VA = "0x186E56530", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event FHMOCDKOLCB HGFAHEFHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6E53E90", Offset = "0x6E53090", VA = "0x186E53E90", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6E56620", Offset = "0x6E55820", VA = "0x186E56620", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E56820", Offset = "0x6E55A20", VA = "0x186E56820")]
	public PAFFMNAJGCG(GameObject HAAGKPEGEHP, RigidbodyEx MKENHFKHDMB, BEHCIJIDLFI MHGFMGGOLKA, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E51A60", Offset = "0x6E50C60", VA = "0x186E51A60", Slot = "135")]
	protected virtual void DDONNGCMFHE(BEHCIJIDLFI MHGFMGGOLKA, PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E520C0", Offset = "0x6E512C0", VA = "0x186E520C0", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E539D0", Offset = "0x6E52BD0", VA = "0x186E539D0", Slot = "71")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E51D80", Offset = "0x6E50F80", VA = "0x186E51D80", Slot = "72")]
	public void FLPNHHCDPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E53DC0", Offset = "0x6E52FC0", VA = "0x186E53DC0", Slot = "73")]
	public void JGAGNNHBMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E54A50", Offset = "0x6E53C50", VA = "0x186E54A50")]
	private void LBFNILJHKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E51170", Offset = "0x6E50370", VA = "0x186E51170", Slot = "81")]
	public void BPMJPILKAOG(JNNFBKKLCNP NABCGCEIEGG, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E53BE0", Offset = "0x6E52DE0", VA = "0x186E53BE0", Slot = "84")]
	public void JCKINNNFBKH(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E53F30", Offset = "0x6E53130", VA = "0x186E53F30", Slot = "85")]
	public void JMNODBEHJJP(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E52420", Offset = "0x6E51620", VA = "0x186E52420", Slot = "86")]
	public Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E50750", Offset = "0x6E4F950", VA = "0x186E50750", Slot = "87")]
	public Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E51D80", Offset = "0x6E50F80", VA = "0x186E51D80", Slot = "88")]
	public void DENAPAMEMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E552D0", Offset = "0x6E544D0", VA = "0x186E552D0", Slot = "89")]
	public void MGFIKICABEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E54BC0", Offset = "0x6E53DC0", VA = "0x186E54BC0", Slot = "90")]
	public void LGBHMKPKECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E541B0", Offset = "0x6E533B0", VA = "0x186E541B0", Slot = "91")]
	public void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E50E10", Offset = "0x6E50010", VA = "0x186E50E10", Slot = "92")]
	public void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E50F00", Offset = "0x6E50100", VA = "0x186E50F00", Slot = "93")]
	public void BJELPPHKBOD(Vector3 PPDKEPEEKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E53380", Offset = "0x6E52580", VA = "0x186E53380", Slot = "94")]
	public void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E50FD0", Offset = "0x6E501D0", VA = "0x186E50FD0", Slot = "95")]
	public void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E53760", Offset = "0x6E52960", VA = "0x186E53760", Slot = "96")]
	[Obsolete]
	public void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E51E30", Offset = "0x6E51030", VA = "0x186E51E30", Slot = "97")]
	public Vector3 DIPKJPKPJDH(Vector3 NABCGCEIEGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E542A0", Offset = "0x6E534A0", VA = "0x186E542A0", Slot = "98")]
	public Vector3 KGDOPDDGCDM(Vector3 NABCGCEIEGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E515B0", Offset = "0x6E507B0", VA = "0x186E515B0", Slot = "99")]
	public void CDJNKINJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E52770", Offset = "0x6E51970", VA = "0x186E52770", Slot = "100")]
	public void FGDOKKGIEDA(JNNFBKKLCNP NNCDMIKDPHD, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E54150", Offset = "0x6E53350", VA = "0x186E54150", Slot = "101")]
	public void KDIDJMPLDHN(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E54CC0", Offset = "0x6E53EC0", VA = "0x186E54CC0", Slot = "41")]
	public void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E557B0", Offset = "0x6E549B0", VA = "0x186E557B0", Slot = "104")]
	public void NJKDMPPEMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E50CF0", Offset = "0x6E4FEF0", VA = "0x186E50CF0", Slot = "105")]
	public void BEBJBIKDNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E53440", Offset = "0x6E52640", VA = "0x186E53440", Slot = "106")]
	public void HLEAECEIFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E52F60", Offset = "0x6E52160", VA = "0x186E52F60", Slot = "109")]
	public bool HBPBHBBKDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6E523D0", Offset = "0x6E515D0", VA = "0x186E523D0", Slot = "74")]
	public void ELIFEDCAFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E55F80", Offset = "0x6E55180", VA = "0x186E55F80", Slot = "110")]
	public void OFAKLCMNIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E55CA0", Offset = "0x6E54EA0", VA = "0x186E55CA0", Slot = "115")]
	public IDisposable OAIGIPAMEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E54C60", Offset = "0x6E53E60", VA = "0x186E54C60", Slot = "116")]
	public void LJOKGLLHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E55800", Offset = "0x6E54A00", VA = "0x186E55800", Slot = "117")]
	public void NMEIAMOCCPI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E52220", Offset = "0x6E51420", VA = "0x186E52220", Slot = "118")]
	public void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E52A30", Offset = "0x6E51C30", VA = "0x186E52A30", Slot = "121")]
	public void GHKEOHIGNLN(Vector3 GEICLMBHNCD, Quaternion JENNBLFMFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E53550", Offset = "0x6E52750", VA = "0x186E53550", Slot = "122")]
	public void ICOFBPMLANI(Vector3 HLHPPEJOIGH, Quaternion HOFLFMNCNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E566C0", Offset = "0x6E558C0", VA = "0x186E566C0", Slot = "123")]
	public bool PNNDDFIMDBM(float AJOPLFDEMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E51200", Offset = "0x6E50400", VA = "0x186E51200", Slot = "124")]
	public void CAEGAPPILAB(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E51330", Offset = "0x6E50530", VA = "0x186E51330", Slot = "125")]
	public void CCBAJFHCGLB(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E50B20", Offset = "0x6E4FD20", VA = "0x186E50B20", Slot = "126")]
	public void AGNJHCMHGPC(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E56320", Offset = "0x6E55520", VA = "0x186E56320", Slot = "127")]
	public void PDDIPNMKOKI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E54EF0", Offset = "0x6E540F0", VA = "0x186E54EF0", Slot = "128")]
	public void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E538C0", Offset = "0x6E52AC0", VA = "0x186E538C0", Slot = "129")]
	public void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E548C0", Offset = "0x6E53AC0", VA = "0x186E548C0", Slot = "130")]
	public void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E555C0", Offset = "0x6E547C0", VA = "0x186E555C0", Slot = "131")]
	public void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E522E0", Offset = "0x6E514E0", VA = "0x186E522E0", Slot = "132")]
	public bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E52840", Offset = "0x6E51A40", VA = "0x186E52840", Slot = "133")]
	public void FLBFFHEDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E567E0", Offset = "0x6E559E0", VA = "0x186E567E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E55E20", Offset = "0x6E55020", VA = "0x186E55E20")]
	private void OCFJAHAIOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E51400", Offset = "0x6E50600", VA = "0x186E51400")]
	private void CCLFPCMNGLI(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6E51830", Offset = "0x6E50A30", VA = "0x186E51830")]
	private void DAHGAHOLLFF(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E50A20", Offset = "0x6E4FC20", VA = "0x186E50A20")]
	private void ACOCAEDNEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6E563D0", Offset = "0x6E555D0", VA = "0x186E563D0")]
	private void PHOCCLPGIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6E50840", Offset = "0x6E4FA40", VA = "0x186E50840")]
	private void ABLHNDLLIDP(JNNFBKKLCNP BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6E53CF0", Offset = "0x6E52EF0", VA = "0x186E53CF0")]
	private void JFLMGBECOEP(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6E55030", Offset = "0x6E54230", VA = "0x186E55030")]
	private void MBBLCNONAFI(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E53210", Offset = "0x6E52410", VA = "0x186E53210")]
	private void HJPJBCMDNCD(RigidbodyEx OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E54460", Offset = "0x6E53660", VA = "0x186E54460", Slot = "140")]
	protected virtual void KIBOANONILA(RigidbodyEx IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E56030", Offset = "0x6E55230", VA = "0x186E56030")]
	protected void OLOJKHNOEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E558C0", Offset = "0x6E54AC0", VA = "0x186E558C0")]
	protected void NODGKKEPEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E52190", Offset = "0x6E51390", VA = "0x186E52190", Slot = "141")]
	protected virtual IDisposable EBHMAAOIGJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class NOHIEHGHLEI
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BED0", Offset = "0x5B1B0D0", VA = "0x185B1BED0")]
	public static JNNFBKKLCNP LHECEFAKMOC(this JNNFBKKLCNP IPECNCNJKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BDE0", Offset = "0x5B1AFE0", VA = "0x185B1BDE0")]
	public static bool DNBIDKIIBIG(this JNNFBKKLCNP IPECNCNJKEI, JNNFBKKLCNP MOMLIJDNAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BD60", Offset = "0x5B1AF60", VA = "0x185B1BD60")]
	public static bool BEFAOFKOPIB(this JNNFBKKLCNP IPECNCNJKEI, JNNFBKKLCNP JIEACFIKHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BF90", Offset = "0x5B1B190", VA = "0x185B1BF90")]
	public static RigidbodyEx MILNGHOHCCP(this JNNFBKKLCNP MLPMIPJPDID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BE60", Offset = "0x5B1B060", VA = "0x185B1BE60")]
	public static PAFFMNAJGCG KIKJEKDPLCC(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BDPEDMBBICC
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event FHMOCDKOLCB MINAOALHGPM;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEBJBIKDNKA();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJKDMPPEMNF();

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HLEAECEIFKG();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void COOFPFOLHOK(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FLBFFHEDHFO();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JNNFBKKLCNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	RigidbodyEx MILNGHOHCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	GameObject KHDPFEHDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Transform JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool ADMDIOHDIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool AJMPPBDBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	float ECIGOEANLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool CFDJGMFCIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform BNLJGJBLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 FNJEBECGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float HOONDNJHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float FHGKACAELGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Quaternion LJIKOHIAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Vector3 IEOOHOKMJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Quaternion NDNFEPKHJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	RigidbodyConstraints KMCJGCKIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	CollisionDetectionMode NHLPADNJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool NOOMLKKPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event FHMOCDKOLCB PGDBJJOKEID;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event FHMOCDKOLCB ACIGIMNAPIH;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event MMLNCAADDIJ AOOINOALPFA;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event FHMOCDKOLCB LHFNBHELECJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event FHMOCDKOLCB BNCEOMFHLOO;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FHMOCDKOLCB AHDFCKMFLJI;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event FHMOCDKOLCB KGGDBIPPADG;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event FHMOCDKOLCB HGFAHEFHFIF;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FLPNHHCDPME();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void JGAGNNHBMGI();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void ELIFEDCAFMF();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void BPMJPILKAOG(JNNFBKKLCNP NABCGCEIEGG, bool AEDCFFPKIIA = false);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void JCKINNNFBKH(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void JMNODBEHJJP(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void DENAPAMEMBP();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void MGFIKICABEF();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void LGBHMKPKECC();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void BJELPPHKBOD(Vector3 PPDKEPEEKEN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 DIPKJPKPJDH(Vector3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 KGDOPDDGCDM(Vector3 NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CDJNKINJAGE();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void FGDOKKGIEDA(JNNFBKKLCNP NNCDMIKDPHD, object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KDIDJMPLDHN(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NJKDMPPEMNF();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void BEBJBIKDNKA();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HLEAECEIFKG();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool HBPBHBBKDLM();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OFAKLCMNIAL();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable OAIGIPAMEKL();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void LJOKGLLHMNG(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void NMEIAMOCCPI(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GHKEOHIGNLN(Vector3 GEICLMBHNCD, Quaternion JENNBLFMFOM);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void ICOFBPMLANI(Vector3 HLHPPEJOIGH, Quaternion HOFLFMNCNEA);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool PNNDDFIMDBM(float AJOPLFDEMOP);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CAEGAPPILAB(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void CCBAJFHCGLB(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void AGNJHCMHGPC(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void PDDIPNMKOKI(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void FLBFFHEDHFO();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EFKPJKOBEKA
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EJBDMPOPPCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 AFIENOGDEKL();

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DPMCLMPNMHG();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DDJGOOKKHFM
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GENHNABINCI(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDKCMIDHMNG(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAOBOJPIKEP(JNNFBKKLCNP IPECNCNJKEI);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMLPHEPAMBM(JNNFBKKLCNP IPECNCNJKEI);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOJJHHDONKJ();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MKFCLLNMJLN : IDisposable, JLGODPLKKFG
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKFPHNABPBP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KOANIGNFMFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event FHMOCDKOLCB PGDBJJOKEID;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event FHMOCDKOLCB ACIGIMNAPIH;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event MMLNCAADDIJ AOOINOALPFA;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action GDBIHJIJHIG;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action HDMDOBCOFCC;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<JNNFBKKLCNP> KPANILCJNPK;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<JNNFBKKLCNP> GLAGENAGHJM;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action BGMBAOIPHPB;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<JNNFBKKLCNP> JAIJKKICOFH;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BPMJPILKAOG(JNNFBKKLCNP PCCOHMIFFHJ, bool AEDCFFPKIIA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[LJJFMBKPAEC(CCDGJKNFPNB.Application)]
public interface JPNGNCNEENI
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOANIGNFMFL DEMJMLEOOEB(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BOPFKHAHFCC KEANAKMLBDJ(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHFPEKHOIMM BOIOMKGBLBN(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHOFNLCCEAG LNEPNADPDJC(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FDONOFLBIKP MCFDFDOBHIH(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MKFCLLNMJLN IPCNFOBLBMF(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEMGGGMGCPB CMFKPGPAELA(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EFKPJKOBEKA PHHGIJJDMGF(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PEMJLNPLGEL GDCFPPNAKHF(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EBNHILLEDLL EJPKCMHAIPA(JNNFBKKLCNP KPCECNDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BAOCCFHJKDL KDDCLGOEJPB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OIBGLHFGEDH MHINDGKIGIJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DDJGOOKKHFM PAJBCAEKJME(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BDPEDMBBICC AINHGCPEMCM(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GEKNMADPOKF OLPAIPCDBIK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL, BEHCIJIDLFI MHGFMGGOLKA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GEKNMADPOKF
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool DKLJPOKJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	RigidbodyConstraints KMCJGCKIDFI
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
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void COOFPFOLHOK(Rigidbody POLLJMGANIP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ANKGBAPAGNP
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOOJOINCJPK(Vector3 LCMOILCAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHFKAALBPEJ(Vector3 FDDOLPLJELI);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKPHONKAFJA(Vector3 LCMOILCAONJ);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKOGKADFKJH(Vector3 FDDOLPLJELI);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IEMGGGMGCPB
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event FHMOCDKOLCB KGGDBIPPADG;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NCGJOIFICKG();

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJOKGLLHMNG(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMEIAMOCCPI(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable OAIGIPAMEKL();

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GHKDIGPJJDI(Rigidbody JPHDKFDHOEE);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COOFPFOLHOK(Rigidbody POLLJMGANIP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PEMJLNPLGEL
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CollisionDetectionMode NHLPADNJOPN
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
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNLFANIDHAN(bool FNCAGMCDJEO);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFOELHOEKBI(bool FNCAGMCDJEO);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BOPFKHAHFCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PCMEHDOOIHG(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LGBHMKPKECC();

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void MGFIKICABEF();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CDJNKINJAGE();

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DENAPAMEMBP();

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 DIPKJPKPJDH(Vector3 NHADPEGDINF);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EHHEGDKBOAP(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BJELPPHKBOD(Vector3 PPDKEPEEKEN);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BAOCCFHJKDL
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	bool KNMEIJBGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGNJHCMHGPC(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDDIPNMKOKI(object FDCOCHLAHJD);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMFBMNJFLOB();

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJKBMHAAIOA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface EBNHILLEDLL
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool CFDJGMFCIDD
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
	void GHKDIGPJJDI(Rigidbody POLLJMGANIP);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COOFPFOLHOK(Rigidbody POLLJMGANIP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FDONOFLBIKP
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event FHMOCDKOLCB AHDFCKMFLJI;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKFPHNABPBP();

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBPBHBBKDLM();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACILHPKMLJH();

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELIFEDCAFMF();

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MKMFHCAECPA();

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OFAKLCMNIAL();

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHFILNFIKBO(bool IHFFPKKEBBB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DDDGJOKMEDO(typeof(BDHDJNEMBDK), new string[] { })]
public sealed class FLONLIFPOHK : DCLDDNDKGBL, BDHDJNEMBDK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[MOHONECELPE]
	private HEJIKGNEDOI IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5B04C00", Offset = "0x5B03E00", VA = "0x185B04C00", Slot = "4")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5B04BD0", Offset = "0x5B03DD0", VA = "0x185B04BD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5B04D90", Offset = "0x5B03F90", VA = "0x185B04D90", Slot = "6")]
	public void KPEJLEKGJIO(BMDJOHDFBDL JHJPAJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5B04F20", Offset = "0x5B04120", VA = "0x185B04F20", Slot = "7")]
	public void PAIDDININKM(BMDJOHDFBDL JHJPAJMEGAG, bool HAFHGDFKLEP, bool BOPJHDIEMNC, bool BBKCDHCHMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B04C50", Offset = "0x5B03E50", VA = "0x185B04C50")]
	private bool KMMPOHIAGPF(BMDJOHDFBDL JHJPAJMEGAG, out NIOPEDCGBEL KPCECNDHFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B04A60", Offset = "0x5B03C60", VA = "0x185B04A60")]
	private bool CJAIICJLDPA(BMDJOHDFBDL JHJPAJMEGAG, out ELPHBOHIBBE MHCCDFMKOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FLONLIFPOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class ELPHBOHIBBE : MHGCBGLMEKK, BDPEDMBBICC
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	[Obsolete]
	public Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFE60", Offset = "0x5AFF060", VA = "0x185AFFE60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF560", Offset = "0x5AFE760", VA = "0x185AFF560", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 DOGLBNGCFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AFE100", Offset = "0x5AFD300", VA = "0x185AFE100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 FLPKPAHBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5AFEC60", Offset = "0x5AFDE60", VA = "0x185AFEC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[Obsolete]
	public Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5B01400", Offset = "0x5B00600", VA = "0x185B01400", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	[Obsolete]
	public float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFC70", Offset = "0x5AFEE70", VA = "0x185AFFC70", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float OJEGAIGOOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFD60", Offset = "0x5AFEF60", VA = "0x185AFFD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF7C0", Offset = "0x5AFE9C0", VA = "0x185AFF7C0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF6B0", Offset = "0x5AFE8B0", VA = "0x185AFF6B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF420", Offset = "0x5AFE620", VA = "0x185AFF420", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFC40", Offset = "0x5AFEE40", VA = "0x185AFFC40", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event FHMOCDKOLCB MINAOALHGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B00F70", Offset = "0x5B00170", VA = "0x185B00F70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5AFF9A0", Offset = "0x5AFEBA0", VA = "0x185AFF9A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B01540", Offset = "0x5B00740", VA = "0x185B01540")]
	public ELPHBOHIBBE(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AFFA40", Offset = "0x5AFEC40", VA = "0x185AFFA40")]
	public float3 IDAAMOHDGLP()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B01010", Offset = "0x5B00210", VA = "0x185B01010", Slot = "14")]
	public void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B01200", Offset = "0x5B00400", VA = "0x185B01200", Slot = "16")]
	public void NJKDMPPEMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5AFE240", Offset = "0x5AFD440", VA = "0x185AFE240", Slot = "15")]
	public void BEBJBIKDNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF450", Offset = "0x5AFE650", VA = "0x185AFF450", Slot = "18")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AFE800", Offset = "0x5AFDA00", VA = "0x185AFE800", Slot = "19")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF8B0", Offset = "0x5AFEAB0", VA = "0x185AFF8B0", Slot = "17")]
	public void HLEAECEIFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5AFEDA0", Offset = "0x5AFDFA0", VA = "0x185AFEDA0", Slot = "20")]
	public void FLBFFHEDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDC30", Offset = "0x5AFCE30", VA = "0x185AFDC30")]
	public void HNLLNCABDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5AFEB10", Offset = "0x5AFDD10", VA = "0x185AFEB10")]
	private void DLLJDJDFPMK(Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5AFFB00", Offset = "0x5AFED00", VA = "0x185AFFB00")]
	[Obsolete]
	private Vector3 IMHNOJEFFOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF6B0", Offset = "0x5AFE8B0", VA = "0x185AFF6B0")]
	private void GLNLPFFODII(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5AFF220", Offset = "0x5AFE420", VA = "0x185AFF220")]
	private Vector3 FNACKLPGLEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5AFE620", Offset = "0x5AFD820", VA = "0x185AFE620")]
	private Quaternion BPAADPHGDDF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5AFFFA0", Offset = "0x5AFF1A0", VA = "0x185AFFFA0")]
	internal (float, Vector3) KPEJLEKGJIO(Rigidbody EEBBBICFICB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class IJMBECAFIFM
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A260", Offset = "0x5B09460", VA = "0x185B0A260")]
	public static ELPHBOHIBBE MHKKKOKLPPO(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MDGDJOHJLDA : MHGCBGLMEKK, BOPFKHAHFCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B15EC0", Offset = "0x5B150C0", VA = "0x185B15EC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B177C0", Offset = "0x5B169C0", VA = "0x185B177C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B17B20", Offset = "0x5B16D20", VA = "0x185B17B20", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B18580", Offset = "0x5B17780", VA = "0x185B18580", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B18770", Offset = "0x5B17970", VA = "0x185B18770", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B17A60", Offset = "0x5B16C60", VA = "0x185B17A60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5B18740", Offset = "0x5B17940", VA = "0x185B18740", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B15640", Offset = "0x5B14840", VA = "0x185B15640", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B182D0", Offset = "0x5B174D0", VA = "0x185B182D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5B18680", Offset = "0x5B17880", VA = "0x185B18680", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B169C0", Offset = "0x5B15BC0", VA = "0x185B169C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B15FF0", Offset = "0x5B151F0", VA = "0x185B15FF0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B181E0", Offset = "0x5B173E0", VA = "0x185B181E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5B15310", Offset = "0x5B14510", VA = "0x185B15310", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B176D0", Offset = "0x5B168D0", VA = "0x185B176D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private EFKPJKOBEKA CIDOCHIIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2107BB0", Offset = "0x2106DB0", VA = "0x182107BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private bool HNOEMKACOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD610", Offset = "0x5AFC810", VA = "0x185AFD610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public MDGDJOHJLDA(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B187D0", Offset = "0x5B179D0", VA = "0x185B187D0", Slot = "20")]
	public void PCMEHDOOIHG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5B16690", Offset = "0x5B15890", VA = "0x185B16690", Slot = "30")]
	public void EHHEGDKBOAP(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B16170", Offset = "0x5B15370", VA = "0x185B16170", Slot = "19")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B16550", Offset = "0x5B15750", VA = "0x185B16550", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5B169F0", Offset = "0x5B15BF0", VA = "0x185B169F0", Slot = "28")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5B16850", Offset = "0x5B15A50", VA = "0x185B16850", Slot = "35")]
	public Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5B151D0", Offset = "0x5B143D0", VA = "0x185B151D0", Slot = "34")]
	public Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5B16170", Offset = "0x5B15370", VA = "0x185B16170", Slot = "27")]
	public void DENAPAMEMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5B181A0", Offset = "0x5B173A0", VA = "0x185B181A0", Slot = "25")]
	public void MGFIKICABEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5B18160", Offset = "0x5B17360", VA = "0x185B18160", Slot = "24")]
	public void LGBHMKPKECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5B178C0", Offset = "0x5B16AC0", VA = "0x185B178C0", Slot = "33")]
	public void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5B15670", Offset = "0x5B14870", VA = "0x185B15670", Slot = "32")]
	public void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5B15AE0", Offset = "0x5B14CE0", VA = "0x185B15AE0", Slot = "31")]
	public void BJELPPHKBOD(Vector3 PPDKEPEEKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5B16B90", Offset = "0x5B15D90", VA = "0x185B16B90", Slot = "22")]
	public void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5B15C80", Offset = "0x5B14E80", VA = "0x185B15C80", Slot = "21")]
	public void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5B16FB0", Offset = "0x5B161B0", VA = "0x185B16FB0", Slot = "23")]
	[Obsolete]
	public void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B161E0", Offset = "0x5B153E0", VA = "0x185B161E0", Slot = "29")]
	public Vector3 DIPKJPKPJDH(Vector3 NHADPEGDINF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B16020", Offset = "0x5B15220", VA = "0x185B16020", Slot = "26")]
	public void CDJNKINJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B15310", Offset = "0x5B14510", VA = "0x185B15310")]
	private void ADCPGHCAFFF(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B154A0", Offset = "0x5B146A0", VA = "0x185B154A0")]
	private void BFGNJHHPAAI(Vector3 KBKEFLIJIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B18330", Offset = "0x5B17530", VA = "0x185B18330")]
	private Vector3 MNHKGMFAJBJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B156D0", Offset = "0x5B148D0", VA = "0x185B156D0")]
	private void BJEJHBFKOME(Vector3 DIJLLIEJNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B16300", Offset = "0x5B15500", VA = "0x185B16300")]
	private Vector3 DPMCLMPNMHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B172D0", Offset = "0x5B164D0", VA = "0x185B172D0")]
	private void IHFKAALBPEJ(Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B162A0", Offset = "0x5B154A0", VA = "0x185B162A0")]
	private void DJPOPLDCGPL(Vector3 NHADPEGDINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B16110", Offset = "0x5B15310", VA = "0x185B16110")]
	private void CDKJDHACDGH(Vector3 FDDOLPLJELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B17C50", Offset = "0x5B16E50", VA = "0x185B17C50")]
	private void KOKLEDAIDMA(string DCILCFJKDLJ, Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B16790", Offset = "0x5B15990", VA = "0x185B16790")]
	private void ELNOEBBMBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class MOBNBBGCAGN : MHGCBGLMEKK, AHOFNLCCEAG
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B18FA0", Offset = "0x5B181A0", VA = "0x185B18FA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B19280", Offset = "0x5B18480", VA = "0x185B19280", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float ECIGOEANLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B195A0", Offset = "0x5B187A0", VA = "0x185B195A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B19410", Offset = "0x5B18610", VA = "0x185B19410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public MOBNBBGCAGN(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B19090", Offset = "0x5B18290", VA = "0x185B19090", Slot = "8")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B18F30", Offset = "0x5B18130", VA = "0x185B18F30", Slot = "9")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[UnityEngine.Scripting.Preserve]
public sealed class LLIMDHNCAAL : JNNFBKKLCNP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LLIMDHNCAAL JHOAALADPKE;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public RigidbodyEx MILNGHOHCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public GameObject KHDPFEHDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Transform JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA4C060", Offset = "0xA4B260", VA = "0x180A4C060", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xBA0F80", Offset = "0xBA0180", VA = "0x180BA0F80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x156D160", Offset = "0x156C360", VA = "0x18156D160", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2C43BF0", Offset = "0x2C42DF0", VA = "0x182C43BF0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xFC6D90", Offset = "0xFC5F90", VA = "0x180FC6D90", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xFC6D80", Offset = "0xFC5F80", VA = "0x180FC6D80", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2EDD2C0", Offset = "0x2EDC4C0", VA = "0x182EDD2C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5B15130", Offset = "0x5B14330", VA = "0x185B15130", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1C722D0", Offset = "0x1C714D0", VA = "0x181C722D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1BCE900", Offset = "0x1BCDB00", VA = "0x181BCE900", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool ADMDIOHDIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x88B7C0", Offset = "0x88A9C0", VA = "0x18088B7C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool AJMPPBDBJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xB9B220", Offset = "0xB9A420", VA = "0x180B9B220", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1122210", Offset = "0x1121410", VA = "0x181122210", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1C74480", Offset = "0x1C73680", VA = "0x181C74480", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x108C2A0", Offset = "0x108B4A0", VA = "0x18108C2A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1EFD050", Offset = "0x1EFC250", VA = "0x181EFD050", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5B15160", Offset = "0x5B14360", VA = "0x185B15160", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x964C30", Offset = "0x963E30", VA = "0x180964C30", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x13F2760", Offset = "0x13F1960", VA = "0x1813F2760", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x964C30", Offset = "0x963E30", VA = "0x180964C30", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float ECIGOEANLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x964C30", Offset = "0x963E30", VA = "0x180964C30", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public bool CFDJGMFCIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "48")]
		get
		{
			return default(LGJDBCELJGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x4F57310", Offset = "0x4F56510", VA = "0x184F57310", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Transform BNLJGJBLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC30", Offset = "0xA2DE30", VA = "0x180A2EC30", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 FNJEBECGDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float HOONDNJHIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x964C30", Offset = "0x963E30", VA = "0x180964C30", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float FHGKACAELGH
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x964C30", Offset = "0x963E30", VA = "0x180964C30", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Quaternion LJIKOHIAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xF86260", Offset = "0xF85460", VA = "0x180F86260", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 IEOOHOKMJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Quaternion NDNFEPKHJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xF86260", Offset = "0xF85460", VA = "0x180F86260", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public RigidbodyConstraints KMCJGCKIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CollisionDetectionMode NHLPADNJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool NOOMLKKPLOI
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x158FAA0", Offset = "0x158ECA0", VA = "0x18158FAA0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event FHMOCDKOLCB PGDBJJOKEID
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event FHMOCDKOLCB ACIGIMNAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MMLNCAADDIJ AOOINOALPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event FHMOCDKOLCB LHFNBHELECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event FHMOCDKOLCB BNCEOMFHLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event FHMOCDKOLCB AHDFCKMFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event FHMOCDKOLCB KGGDBIPPADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event FHMOCDKOLCB HGFAHEFHFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "41")]
	public void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "71")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "72")]
	public void FLPNHHCDPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "73")]
	public void JGAGNNHBMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "74")]
	public void ELIFEDCAFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "81")]
	public void BPMJPILKAOG(JNNFBKKLCNP NABCGCEIEGG, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "84")]
	public void JCKINNNFBKH(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "85")]
	public void JMNODBEHJJP(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "86")]
	public Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "87")]
	public Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "88")]
	public void DENAPAMEMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "89")]
	public void MGFIKICABEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "90")]
	public void LGBHMKPKECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "91")]
	public void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "92")]
	public void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "93")]
	public void BJELPPHKBOD(Vector3 PPDKEPEEKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "94")]
	public void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "95")]
	public void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "96")]
	public void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "97")]
	public Vector3 DIPKJPKPJDH(Vector3 NABCGCEIEGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C300", Offset = "0x1B5B500", VA = "0x181B5C300", Slot = "98")]
	public Vector3 KGDOPDDGCDM(Vector3 NABCGCEIEGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "99")]
	public void CDJNKINJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "100")]
	public void FGDOKKGIEDA(JNNFBKKLCNP NNCDMIKDPHD, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "101")]
	public void KDIDJMPLDHN(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "104")]
	public void NJKDMPPEMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "105")]
	public void BEBJBIKDNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "106")]
	public void HLEAECEIFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "109")]
	public bool HBPBHBBKDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "110")]
	public void OFAKLCMNIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "115")]
	public IDisposable OAIGIPAMEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "116")]
	public void LJOKGLLHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "117")]
	public void NMEIAMOCCPI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "118")]
	public void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "121")]
	public void GHKEOHIGNLN(Vector3 GEICLMBHNCD, Quaternion JENNBLFMFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "122")]
	public void ICOFBPMLANI(Vector3 HLHPPEJOIGH, Quaternion HOFLFMNCNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "123")]
	public bool PNNDDFIMDBM(float AJOPLFDEMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "124")]
	public void CAEGAPPILAB(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "125")]
	public void CCBAJFHCGLB(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "126")]
	public void AGNJHCMHGPC(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "127")]
	public void PDDIPNMKOKI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "128")]
	public void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "129")]
	public void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "130")]
	public void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "131")]
	public void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5B15140", Offset = "0x5B14340", VA = "0x185B15140", Slot = "132")]
	public bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "133")]
	public void FLBFFHEDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public LLIMDHNCAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HLBPFDLMHIA : MHGCBGLMEKK, MHFPEKHOIMM
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A0F0", Offset = "0x5B092F0", VA = "0x185B0A0F0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5B09640", Offset = "0x5B08840", VA = "0x185B09640", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A120", Offset = "0x5B09320", VA = "0x185B0A120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private JNNFBKKLCNP CCLIHMMHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5B09CE0", Offset = "0x5B08EE0", VA = "0x185B09CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public HLBPFDLMHIA(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5B09F70", Offset = "0x5B09170", VA = "0x185B09F70", Slot = "6")]
	public void JBGHHBLMJDP(JNNFBKKLCNP OJEMCPHOKBP, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5B09E30", Offset = "0x5B09030", VA = "0x185B09E30")]
	private void JBGHHBLMJDP(NIOPEDCGBEL OJEMCPHOKBP, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5B09BE0", Offset = "0x5B08DE0", VA = "0x185B09BE0", Slot = "7")]
	public void DEJGNJICIEA(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5B09850", Offset = "0x5B08A50", VA = "0x185B09850")]
	private Vector3 CEAEPHPNHJO()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class HGJANNOGCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5B095B0", Offset = "0x5B087B0", VA = "0x185B095B0")]
	public static HLBPFDLMHIA NBLFFBBGCCE(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class KKJHOIAMLEF : MHGCBGLMEKK, KOANIGNFMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly PEKDFCFCENH MAAMJGHMFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HGDKNJLBBNP CKHEILPLJII;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private Transform JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5B137D0", Offset = "0x5B129D0", VA = "0x185B137D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public BMDJOHDFBDL ANJCEMJLKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5B11550", Offset = "0x5B10750", VA = "0x185B11550")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5B127D0", Offset = "0x5B119D0", VA = "0x185B127D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5B11510", Offset = "0x5B10710", VA = "0x185B11510", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B13420", Offset = "0x5B12620", VA = "0x185B13420", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public BMDJOHDFBDL AIABNJNFCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B11BD0", Offset = "0x5B10DD0", VA = "0x185B11BD0")]
		get
		{
			return default(BMDJOHDFBDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B12470", Offset = "0x5B11670", VA = "0x185B12470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5B11660", Offset = "0x5B10860", VA = "0x185B11660", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event FHMOCDKOLCB PGDBJJOKEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5B13490", Offset = "0x5B12690", VA = "0x185B13490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5B12330", Offset = "0x5B11530", VA = "0x185B12330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event FHMOCDKOLCB ACIGIMNAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5B13690", Offset = "0x5B12890", VA = "0x185B13690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5B128E0", Offset = "0x5B11AE0", VA = "0x185B128E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event MMLNCAADDIJ AOOINOALPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5B13730", Offset = "0x5B12930", VA = "0x185B13730", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5B12AC0", Offset = "0x5B11CC0", VA = "0x185B12AC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action GDBIHJIJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5B11F00", Offset = "0x5B11100", VA = "0x185B11F00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5B12A20", Offset = "0x5B11C20", VA = "0x185B12A20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action HDMDOBCOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5B12730", Offset = "0x5B11930", VA = "0x185B12730", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x5B12B60", Offset = "0x5B11D60", VA = "0x185B12B60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<JNNFBKKLCNP> KPANILCJNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5B12980", Offset = "0x5B11B80", VA = "0x185B12980", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5B138A0", Offset = "0x5B12AA0", VA = "0x185B138A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<JNNFBKKLCNP> GLAGENAGHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5B116A0", Offset = "0x5B108A0", VA = "0x185B116A0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5B123D0", Offset = "0x5B115D0", VA = "0x185B123D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action BGMBAOIPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5B11B30", Offset = "0x5B10D30", VA = "0x185B11B30", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5B13800", Offset = "0x5B12A00", VA = "0x185B13800", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<JNNFBKKLCNP> JAIJKKICOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5B12C00", Offset = "0x5B11E00", VA = "0x185B12C00", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5B13530", Offset = "0x5B12730", VA = "0x185B13530", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5B139D0", Offset = "0x5B12BD0", VA = "0x185B139D0")]
	public KKJHOIAMLEF(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x5B11CE0", Offset = "0x5B10EE0", VA = "0x185B11CE0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B11AB0", Offset = "0x5B10CB0", VA = "0x185B11AB0", Slot = "26")]
	public void BPMJPILKAOG(JNNFBKKLCNP PCCOHMIFFHJ, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B11A40", Offset = "0x5B10C40", VA = "0x185B11A40")]
	private void BPMJPILKAOG(NIOPEDCGBEL PCCOHMIFFHJ, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B12CA0", Offset = "0x5B11EA0", VA = "0x185B12CA0")]
	private void KLLPCJKLJCA(NIOPEDCGBEL PCCOHMIFFHJ, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B12580", Offset = "0x5B11780", VA = "0x185B12580")]
	private void HHHHCAJMDJK(NIOPEDCGBEL BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5B118A0", Offset = "0x5B10AA0", VA = "0x185B118A0")]
	private void BJCPPCDLANN(NIOPEDCGBEL BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5B11FA0", Offset = "0x5B111A0", VA = "0x185B11FA0")]
	private void EFCGFHJBBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5B13330", Offset = "0x5B12530", VA = "0x185B13330")]
	private void LBCEDGFJDLM(NIOPEDCGBEL BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5B135D0", Offset = "0x5B127D0", VA = "0x185B135D0")]
	private void NAMMNFHJAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5B11740", Offset = "0x5B10940", VA = "0x185B11740")]
	private void BIBGAGBKMNG(NIOPEDCGBEL IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5B121D0", Offset = "0x5B113D0", VA = "0x185B121D0")]
	private void EOEHEOKPEGA(NIOPEDCGBEL IPECNCNJKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class FJJLHFOOIGO
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5B04560", Offset = "0x5B03760", VA = "0x185B04560")]
	public static KKJHOIAMLEF NMACKCAFKHJ(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NIOPEDCGBEL : PAFFMNAJGCG, JGABCBFOGEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal HEJIKGNEDOI JAKPJJKEAKD;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BD50", Offset = "0x5B1AF50", VA = "0x185B1BD50")]
	public NIOPEDCGBEL(GameObject HAAGKPEGEHP, RigidbodyEx MKENHFKHDMB, BEHCIJIDLFI MHGFMGGOLKA, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B6D0", Offset = "0x5B1A8D0", VA = "0x185B1B6D0", Slot = "135")]
	protected override void DDONNGCMFHE(BEHCIJIDLFI MHGFMGGOLKA, PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "141")]
	protected override IDisposable EBHMAAOIGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B960", Offset = "0x5B1AB60", VA = "0x185B1B960", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BAF0", Offset = "0x5B1ACF0", VA = "0x185B1BAF0", Slot = "142")]
	public void JNDBIBLBMII(PABPBCLLOCG CNPGLHEDJDI, PABPBCLLOCG KJOKOFBOJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B430", Offset = "0x5B1A630", VA = "0x185B1B430", Slot = "143")]
	public void BBGBMBFEMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BA30", Offset = "0x5B1AC30", VA = "0x185B1BA30", Slot = "144")]
	public void FPCHLFAKBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BBB0", Offset = "0x5B1ADB0", VA = "0x185B1BBB0", Slot = "145")]
	public void MHFILNFIKBO(bool IHFFPKKEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BC10", Offset = "0x5B1AE10", VA = "0x185B1BC10", Slot = "146")]
	public bool NKFNMJBKDMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B3D0", Offset = "0x5B1A5D0", VA = "0x185B1B3D0", Slot = "147")]
	public void AAGOALKPFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "140")]
	protected override void KIBOANONILA(RigidbodyEx JBFDNABELLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B4F0", Offset = "0x5B1A6F0", VA = "0x185B1B4F0")]
	private void CBKFDOCOHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class MEAAOLNKIIA
{
	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B188D0", Offset = "0x5B17AD0", VA = "0x185B188D0")]
	public static PAFFMNAJGCG MDOLKANBPLD(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LGJNLALAFCB : MHGCBGLMEKK, DDJGOOKKHFM
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool PJNIPKELBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B141C0", Offset = "0x5B133C0", VA = "0x185B141C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public FOILGMPPBAK BLIMLNECNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5B13DA0", Offset = "0x5B12FA0", VA = "0x185B13DA0", Slot = "11")]
		get
		{
			return default(FOILGMPPBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private FOILGMPPBAK IMHFFBNNCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B143C0", Offset = "0x5B135C0", VA = "0x185B143C0")]
		get
		{
			return default(FOILGMPPBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5B13F70", Offset = "0x5B13170", VA = "0x185B13F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B145A0", Offset = "0x5B137A0", VA = "0x185B145A0")]
	public LGJNLALAFCB(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B13DB0", Offset = "0x5B12FB0", VA = "0x185B13DB0", Slot = "4")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B13BB0", Offset = "0x5B12DB0", VA = "0x185B13BB0")]
	private bool ALAGGMLBNAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B13C90", Offset = "0x5B12E90", VA = "0x185B13C90", Slot = "5")]
	public void GENHNABINCI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B140B0", Offset = "0x5B132B0", VA = "0x185B140B0", Slot = "6")]
	public void KDKCMIDHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B142B0", Offset = "0x5B134B0", VA = "0x185B142B0", Slot = "9")]
	public void NOJJHHDONKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B144B0", Offset = "0x5B136B0", VA = "0x185B144B0")]
	private void PAMIEJKOIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B13E70", Offset = "0x5B13070", VA = "0x185B13E70")]
	private void JEPNEJBDHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B14070", Offset = "0x5B13270", VA = "0x185B14070", Slot = "8")]
	public void JMLPHEPAMBM(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B13C50", Offset = "0x5B12E50", VA = "0x185B13C50", Slot = "7")]
	public void GAOBOJPIKEP(JNNFBKKLCNP IPECNCNJKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NAGCOJNPHGF : MHGCBGLMEKK, EFKPJKOBEKA
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5B0E3C0", Offset = "0x5B0D5C0", VA = "0x185B0E3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAB60", Offset = "0x5AF9D60", VA = "0x185AFAB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B19C10", Offset = "0x5B18E10", VA = "0x185B19C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public NAGCOJNPHGF(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A4F0", Offset = "0x5B196F0", VA = "0x185B1A4F0", Slot = "4")]
	public void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5B19C70", Offset = "0x5B18E70", VA = "0x185B19C70")]
	private void EKMEDEACDKC(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5B19FC0", Offset = "0x5B191C0", VA = "0x185B19FC0", Slot = "5")]
	public void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A1D0", Offset = "0x5B193D0", VA = "0x185B1A1D0", Slot = "6")]
	public void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A2F0", Offset = "0x5B194F0", VA = "0x185B1A2F0")]
	private void LAIJDEOMBFB(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A5E0", Offset = "0x5B197E0", VA = "0x185B1A5E0", Slot = "7")]
	public void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5B19ED0", Offset = "0x5B190D0", VA = "0x185B19ED0")]
	private void GMDPMBHBMHO(string JPOEHOENKPI, UnityEngine.Object JDFBABENAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class ADPEHEAMGMD : MHGCBGLMEKK, BAOCCFHJKDL
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAEA0", Offset = "0x5AFA0A0", VA = "0x185AFAEA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAA60", Offset = "0x5AF9C60", VA = "0x185AFAA60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAB60", Offset = "0x5AF9D60", VA = "0x185AFAB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool KNMEIJBGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x5AFA970", Offset = "0x5AF9B70", VA = "0x185AFA970", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB300", Offset = "0x5AFA500", VA = "0x185AFB300")]
	public ADPEHEAMGMD(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAB80", Offset = "0x5AF9D80", VA = "0x185AFAB80", Slot = "5")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA860", Offset = "0x5AF9A60", VA = "0x185AFA860", Slot = "7")]
	public void AGNJHCMHGPC(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB1F0", Offset = "0x5AFA3F0", VA = "0x185AFB1F0", Slot = "8")]
	public void PDDIPNMKOKI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAC30", Offset = "0x5AF9E30", VA = "0x185AFAC30", Slot = "9")]
	public void LMFBMNJFLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5AFAF90", Offset = "0x5AFA190", VA = "0x185AFAF90", Slot = "11")]
	public void MNPHCLFIGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA690", Offset = "0x5AF9890", VA = "0x185AFA690", Slot = "12")]
	public void AEMAHLLJOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "10")]
	public void HJKBMHAAIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class KCGFDAAGACA : MHGCBGLMEKK, IEMGGGMGCPB
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B10B00", Offset = "0x5B0FD00", VA = "0x185B10B00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	private bool JOLBOBCPIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B10870", Offset = "0x5B0FA70", VA = "0x185B10870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event FHMOCDKOLCB KGGDBIPPADG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B104B0", Offset = "0x5B0F6B0", VA = "0x185B104B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5B10C70", Offset = "0x5B0FE70", VA = "0x185B10C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public KCGFDAAGACA(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B10C10", Offset = "0x5B0FE10", VA = "0x185B10C10", Slot = "11")]
	public IDisposable OAIGIPAMEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B10BF0", Offset = "0x5B0FDF0", VA = "0x185B10BF0", Slot = "8")]
	public void LJOKGLLHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B10C00", Offset = "0x5B0FE00", VA = "0x185B10C00", Slot = "9")]
	public void NMEIAMOCCPI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B10760", Offset = "0x5B0F960", VA = "0x185B10760", Slot = "10")]
	public void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B10960", Offset = "0x5B0FB60", VA = "0x185B10960", Slot = "12")]
	public void GHKDIGPJJDI(Rigidbody JPHDKFDHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B10550", Offset = "0x5B0F750", VA = "0x185B10550", Slot = "13")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDC30", Offset = "0x5AFCE30", VA = "0x185AFDC30", Slot = "6")]
	public void NCGJOIFICKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class JLEGNPBLINH : MHGCBGLMEKK, PEMJLNPLGEL
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private CollisionDetectionMode JGGIKAFGMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DB40", Offset = "0x5B0CD40", VA = "0x185B0DB40")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D550", Offset = "0x5B0C750", VA = "0x185B0D550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public CollisionDetectionMode NHLPADNJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D810", Offset = "0x5B0CA10", VA = "0x185B0D810", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DA40", Offset = "0x5B0CC40", VA = "0x185B0DA40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public JLEGNPBLINH(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DA80", Offset = "0x5B0CC80", VA = "0x185B0DA80", Slot = "6")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D9D0", Offset = "0x5B0CBD0", VA = "0x185B0D9D0", Slot = "9")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D9C0", Offset = "0x5B0CBC0", VA = "0x185B0D9C0", Slot = "7")]
	public void FNLFANIDHAN(bool FNCAGMCDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DA30", Offset = "0x5B0CC30", VA = "0x185B0DA30", Slot = "8")]
	public void IFOELHOEKBI(bool FNCAGMCDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D8C0", Offset = "0x5B0CAC0", VA = "0x185B0D8C0", Slot = "10")]
	public bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D650", Offset = "0x5B0C850", VA = "0x185B0D650")]
	private void BICCFBGNBKE(bool FNCAGMCDJEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DefaultMember("Item")]
public sealed class HGDKNJLBBNP : IReadOnlyList<JNNFBKKLCNP>, IEnumerable<JNNFBKKLCNP>, IEnumerable, IReadOnlyCollection<JNNFBKKLCNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly BMDJOHDFBDL KHBBAOCDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly HEJIKGNEDOI INBMBKDICBE;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08500", VA = "0x185B09300", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public JNNFBKKLCNP JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5B093E0", Offset = "0x5B085E0", VA = "0x185B093E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B092B0", Offset = "0x5B084B0", VA = "0x185B092B0")]
	public HGDKNJLBBNP(BMDJOHDFBDL KHBBAOCDKFN, HEJIKGNEDOI INBMBKDICBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B09100", Offset = "0x5B08300", VA = "0x185B09100", Slot = "6")]
	public IEnumerator<JNNFBKKLCNP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B09100", Offset = "0x5B08300", VA = "0x185B09100", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5B092A0", Offset = "0x5B084A0", VA = "0x185B092A0")]
	[CompilerGenerated]
	private JNNFBKKLCNP IMJFIAFLLOM(int LHPGLCOPMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class FBFEKCOENBH : JPNGNCNEENI
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5B01AC0", Offset = "0x5B00CC0", VA = "0x185B01AC0", Slot = "4")]
	public KOANIGNFMFL DEMJMLEOOEB(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5B02110", Offset = "0x5B01310", VA = "0x185B02110", Slot = "5")]
	public BOPFKHAHFCC KEANAKMLBDJ(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5B01980", Offset = "0x5B00B80", VA = "0x185B01980", Slot = "6")]
	public MHFPEKHOIMM BOIOMKGBLBN(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5B02270", Offset = "0x5B01470", VA = "0x185B02270", Slot = "7")]
	public AHOFNLCCEAG LNEPNADPDJC(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5B02380", Offset = "0x5B01580", VA = "0x185B02380", Slot = "8")]
	public FDONOFLBIKP MCFDFDOBHIH(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5B01E10", Offset = "0x5B01010", VA = "0x185B01E10", Slot = "9")]
	public MKFCLLNMJLN IPCNFOBLBMF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5B01A20", Offset = "0x5B00C20", VA = "0x185B01A20", Slot = "10")]
	public IEMGGGMGCPB CMFKPGPAELA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5B023E0", Offset = "0x5B015E0", VA = "0x185B023E0", Slot = "11")]
	public EFKPJKOBEKA PHHGIJJDMGF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5B01D70", Offset = "0x5B00F70", VA = "0x185B01D70", Slot = "12")]
	public PEMJLNPLGEL GDCFPPNAKHF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5B01CD0", Offset = "0x5B00ED0", VA = "0x185B01CD0", Slot = "13")]
	public EBNHILLEDLL EJPKCMHAIPA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5B02050", Offset = "0x5B01250", VA = "0x185B02050")]
	public BAOCCFHJKDL KDDCLGOEJPB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5B021B0", Offset = "0x5B013B0", VA = "0x185B021B0")]
	public OIBGLHFGEDH MHINDGKIGIJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5B01EB0", Offset = "0x5B010B0", VA = "0x185B01EB0")]
	public DDJGOOKKHFM PAJBCAEKJME(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5B01860", Offset = "0x5B00A60", VA = "0x185B01860")]
	public BDPEDMBBICC AINHGCPEMCM(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5B02310", Offset = "0x5B01510", VA = "0x185B02310")]
	public GEKNMADPOKF OLPAIPCDBIK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5B018D0", Offset = "0x5B00AD0", VA = "0x185B018D0", Slot = "19")]
	public JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL, BEHCIJIDLFI MHGFMGGOLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FBFEKCOENBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5B02050", Offset = "0x5B01250", VA = "0x185B02050", Slot = "14")]
	private BAOCCFHJKDL NMLAEDLDOAB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5B021B0", Offset = "0x5B013B0", VA = "0x185B021B0", Slot = "15")]
	private OIBGLHFGEDH KPDAOEBCGHG(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5B01EB0", Offset = "0x5B010B0", VA = "0x185B01EB0", Slot = "16")]
	private DDJGOOKKHFM JNHAONCMHFJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5B01860", Offset = "0x5B00A60", VA = "0x185B01860", Slot = "17")]
	private BDPEDMBBICC FDCFPPDEGMN(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5B02310", Offset = "0x5B01510", VA = "0x185B02310", Slot = "18")]
	private GEKNMADPOKF LOAIHCPKOPK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class DFNADGFBLHJ : MHGCBGLMEKK, FDONOFLBIKP
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private bool HNOEMKACOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD610", Offset = "0x5AFC810", VA = "0x185AFD610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD2A0", Offset = "0x5AFC4A0", VA = "0x185AFD2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDA90", Offset = "0x5AFCC90", VA = "0x185AFDA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private bool JOLAGNMEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD4A0", Offset = "0x5AFC6A0", VA = "0x185AFD4A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDDE0", Offset = "0x5AFCFE0", VA = "0x185AFDDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private bool CFCDJPKKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD3B0", Offset = "0x5AFC5B0", VA = "0x185AFD3B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC70", Offset = "0x5AFCE70", VA = "0x185AFDC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private int HFFBLAAJAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD790", Offset = "0x5AFC990", VA = "0x185AFD790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event FHMOCDKOLCB AHDFCKMFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDB70", Offset = "0x5AFCD70", VA = "0x185AFDB70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD310", Offset = "0x5AFC510", VA = "0x185AFD310", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDEE0", Offset = "0x5AFD0E0", VA = "0x185AFDEE0")]
	public DFNADGFBLHJ(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDAF0", Offset = "0x5AFCCF0", VA = "0x185AFDAF0", Slot = "6")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD300", Offset = "0x5AFC500", VA = "0x185AFD300", Slot = "8")]
	public void ACILHPKMLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD890", Offset = "0x5AFCA90", VA = "0x185AFD890", Slot = "7")]
	public bool HBPBHBBKDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD590", Offset = "0x5AFC790", VA = "0x185AFD590", Slot = "9")]
	public void ELIFEDCAFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDC30", Offset = "0x5AFCE30", VA = "0x185AFDC30", Slot = "12")]
	public void MHFILNFIKBO(bool IHFFPKKEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDD70", Offset = "0x5AFCF70", VA = "0x185AFDD70", Slot = "11")]
	public void OFAKLCMNIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "10")]
	public void MKMFHCAECPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD630", Offset = "0x5AFC830", VA = "0x185AFD630")]
	private void FFJEFCCJOLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DDDGJOKMEDO(typeof(JPNGNCNEENI), new string[] { })]
public class NBHAJMOKGDG : JPNGNCNEENI, DCLDDNDKGBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly JPNGNCNEENI HNNKHNHNJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JPNGNCNEENI ONMNMDAFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private PKKEKIECBNE IJNKFHNOMBE;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private JPNGNCNEENI JOEJCJHPHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AC00", Offset = "0x5B19E00", VA = "0x185B1AC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5B1ADA0", Offset = "0x5B19FA0", VA = "0x185B1ADA0", Slot = "20")]
	public void InitReferences(POCHLGNFBCE DAJKBHKJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AAC0", Offset = "0x5B19CC0", VA = "0x185B1AAC0", Slot = "4")]
	public KOANIGNFMFL DEMJMLEOOEB(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AF50", Offset = "0x5B1A150", VA = "0x185B1AF50", Slot = "5")]
	public BOPFKHAHFCC KEANAKMLBDJ(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A980", Offset = "0x5B19B80", VA = "0x185B1A980", Slot = "6")]
	public MHFPEKHOIMM BOIOMKGBLBN(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B0A0", Offset = "0x5B1A2A0", VA = "0x185B1B0A0", Slot = "7")]
	public AHOFNLCCEAG LNEPNADPDJC(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B1F0", Offset = "0x5B1A3F0", VA = "0x185B1B1F0", Slot = "8")]
	public FDONOFLBIKP MCFDFDOBHIH(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AD00", Offset = "0x5B19F00", VA = "0x185B1AD00", Slot = "9")]
	public MKFCLLNMJLN IPCNFOBLBMF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AA20", Offset = "0x5B19C20", VA = "0x185B1AA20", Slot = "10")]
	public IEMGGGMGCPB CMFKPGPAELA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B290", Offset = "0x5B1A490", VA = "0x185B1B290", Slot = "11")]
	public EFKPJKOBEKA PHHGIJJDMGF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AC60", Offset = "0x5B19E60", VA = "0x185B1AC60", Slot = "12")]
	public PEMJLNPLGEL GDCFPPNAKHF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AB60", Offset = "0x5B19D60", VA = "0x185B1AB60", Slot = "13")]
	public EBNHILLEDLL EJPKCMHAIPA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AEA0", Offset = "0x5B1A0A0", VA = "0x185B1AEA0")]
	public BAOCCFHJKDL KDDCLGOEJPB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AFF0", Offset = "0x5B1A1F0", VA = "0x185B1AFF0")]
	public OIBGLHFGEDH MHINDGKIGIJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5B1ADF0", Offset = "0x5B19FF0", VA = "0x185B1ADF0")]
	public DDJGOOKKHFM PAJBCAEKJME(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A7E0", Offset = "0x5B199E0", VA = "0x185B1A7E0")]
	public BDPEDMBBICC AINHGCPEMCM(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B140", Offset = "0x5B1A340", VA = "0x185B1B140")]
	public GEKNMADPOKF OLPAIPCDBIK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A890", Offset = "0x5B19A90", VA = "0x185B1A890", Slot = "19")]
	public JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL, BEHCIJIDLFI MHGFMGGOLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B330", Offset = "0x5B1A530", VA = "0x185B1B330")]
	public NBHAJMOKGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AEA0", Offset = "0x5B1A0A0", VA = "0x185B1AEA0", Slot = "14")]
	private BAOCCFHJKDL NMLAEDLDOAB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5B1AFF0", Offset = "0x5B1A1F0", VA = "0x185B1AFF0", Slot = "15")]
	private OIBGLHFGEDH KPDAOEBCGHG(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5B1ADF0", Offset = "0x5B19FF0", VA = "0x185B1ADF0", Slot = "16")]
	private DDJGOOKKHFM JNHAONCMHFJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5B1A7E0", Offset = "0x5B199E0", VA = "0x185B1A7E0", Slot = "17")]
	private BDPEDMBBICC FDCFPPDEGMN(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5B1B140", Offset = "0x5B1A340", VA = "0x185B1B140", Slot = "18")]
	private GEKNMADPOKF LOAIHCPKOPK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class FMLLONPNPBP : MHGCBGLMEKK, EBNHILLEDLL
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool CFDJGMFCIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5B05410", Offset = "0x5B04610", VA = "0x185B05410", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5B05160", Offset = "0x5B04360", VA = "0x185B05160", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public FMLLONPNPBP(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5B052F0", Offset = "0x5B044F0", VA = "0x185B052F0", Slot = "6")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5B05120", Offset = "0x5B04320", VA = "0x185B05120", Slot = "7")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class MHGCBGLMEKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly NIOPEDCGBEL IPECNCNJKEI;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	protected HEJIKGNEDOI MNCMPBCCBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x5B18950", Offset = "0x5B17B50", VA = "0x185B18950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	protected BMDJOHDFBDL CFLIMOEMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5B18920", Offset = "0x5B17B20", VA = "0x185B18920")]
		get
		{
			return default(BMDJOHDFBDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public MHGCBGLMEKK(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5B18970", Offset = "0x5B17B70", VA = "0x185B18970")]
	protected JNNFBKKLCNP KMGEAJJHPPK(BMDJOHDFBDL KHBBAOCDKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class GCIAJGNNCEL : MHGCBGLMEKK, OIBGLHFGEDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private PhotonView IONLKPOKNHO;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFB570", Offset = "0x5AFA770", VA = "0x185AFB570", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5B05A90", Offset = "0x5B04C90", VA = "0x185B05A90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event FHMOCDKOLCB LHFNBHELECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5B064C0", Offset = "0x5B056C0", VA = "0x185B064C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5B057E0", Offset = "0x5B049E0", VA = "0x185B057E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5B06660", Offset = "0x5B05860", VA = "0x185B06660")]
	public GCIAJGNNCEL(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5B05DB0", Offset = "0x5B04FB0", VA = "0x185B05DB0", Slot = "8")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5B05880", Offset = "0x5B04A80", VA = "0x185B05880", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5B060A0", Offset = "0x5B052A0", VA = "0x185B060A0", Slot = "9")]
	public void JFLMGBECOEP(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5B062B0", Offset = "0x5B054B0", VA = "0x185B062B0", Slot = "10")]
	public void MBBLCNONAFI(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5B05BE0", Offset = "0x5B04DE0", VA = "0x185B05BE0")]
	private void IBCAEHMCECH(PhotonView NAKMEOEKLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5B06560", Offset = "0x5B05760", VA = "0x185B06560")]
	private void OKJLPHMJLFN(RigidbodyEx MEHGCJCMKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5B05F00", Offset = "0x5B05100", VA = "0x185B05F00")]
	private void IOLJCBHHHLK(PhotonView PAADMHOOIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal static class HLOELLPGMOH
{
	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A200", Offset = "0x5B09400", VA = "0x185B0A200")]
	public static GCIAJGNNCEL LJPOGGEAOMF(this PAFFMNAJGCG KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class OEOCBMNEIEB : MHGCBGLMEKK, GEKNMADPOKF
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FCE0", Offset = "0x6E4EEE0", VA = "0x186E4FCE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FDD0", Offset = "0x6E4EFD0", VA = "0x186E4FDD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool DKLJPOKJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FEE0", Offset = "0x6E4F0E0", VA = "0x186E4FEE0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FBD0", Offset = "0x6E4EDD0", VA = "0x186E4FBD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints KMCJGCKIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x6E500E0", Offset = "0x6E4F2E0", VA = "0x186E500E0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6E502F0", Offset = "0x6E4F4F0", VA = "0x186E502F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6E50510", Offset = "0x6E4F710", VA = "0x186E50510")]
	public OEOCBMNEIEB(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6E501D0", Offset = "0x6E4F3D0", VA = "0x186E501D0", Slot = "9")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FFD0", Offset = "0x6E4F1D0", VA = "0x186E4FFD0", Slot = "10")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MOHNHFBAFDG : MHGCBGLMEKK, MKFCLLNMJLN, IDisposable, JLGODPLKKFG
{
	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public LGJDBCELJGC DCABOFOMGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5B19690", Offset = "0x5B18890", VA = "0x185B19690")]
		get
		{
			return default(LGJDBCELJGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x5B19780", Offset = "0x5B18980", VA = "0x185B19780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x5B19980", Offset = "0x5B18B80", VA = "0x185B19980", Slot = "6")]
		get
		{
			return default(LGJDBCELJGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x5B19780", Offset = "0x5B18980", VA = "0x185B19780", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private Transform NFGOIAFKKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5B19B70", Offset = "0x5B18D70", VA = "0x185B19B70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5B19880", Offset = "0x5B18A80", VA = "0x185B19880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5B05500", Offset = "0x5B04700", VA = "0x185B05500")]
	public MOHNHFBAFDG(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5B19920", Offset = "0x5B18B20", VA = "0x185B19920", Slot = "11")]
	public void OnChangedDistanceBand(LOHCJBKKAAK CNPGLHEDJDI, LOHCJBKKAAK KJOKOFBOJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
	public void OnChangedVisibility(bool CPOAPAFNIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class COINBIJBFLM : MKFCLLNMJLN, IDisposable, JLGODPLKKFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LGJDBCELJGC GDLINKPFDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private MCBHBLDEFKB PFKOHCEDHGC;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public LGJDBCELJGC COLLNILCOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC510", Offset = "0x5AFB710", VA = "0x185AFC510", Slot = "6")]
		get
		{
			return default(LGJDBCELJGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC0C0", Offset = "0x5AFB2C0", VA = "0x185AFC0C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	private Transform NFGOIAFKKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC1E0", Offset = "0x5AFB3E0", VA = "0x185AFC1E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<LOHCJBKKAAK, LOHCJBKKAAK> FBFAMEPIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC610", Offset = "0x5AFB810", VA = "0x185AFC610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC020", Offset = "0x5AFB220", VA = "0x185AFC020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC6B0", Offset = "0x5AFB8B0", VA = "0x185AFC6B0")]
	public COINBIJBFLM(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC200", Offset = "0x5AFB400", VA = "0x185AFC200", Slot = "8")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC190", Offset = "0x5AFB390", VA = "0x185AFC190", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC4B0", Offset = "0x5AFB6B0", VA = "0x185AFC4B0", Slot = "11")]
	private void NDHNPCPKBPL(LOHCJBKKAAK JIDECECIIFE, LOHCJBKKAAK EBJPGOJMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "12")]
	private void MJFOBPIPMIP(bool CPOAPAFNIPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class CGGFNIMOCIN : GEGLHAJMKKE, OIBGLHFGEDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private PhotonView IONLKPOKNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool PEJLEIKMNKB;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public PhotonView GELLECCBPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool HNFBBGDNHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFB570", Offset = "0x5AFA770", VA = "0x185AFB570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool GPLMOONBEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event FHMOCDKOLCB LHFNBHELECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x5AFBE10", Offset = "0x5AFB010", VA = "0x185AFBE10", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5AFB4D0", Offset = "0x5AFA6D0", VA = "0x185AFB4D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBF80", Offset = "0x5AFB180", VA = "0x185AFBF80")]
	public CGGFNIMOCIN(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB7B0", Offset = "0x5AFA9B0", VA = "0x185AFB7B0", Slot = "9")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB590", Offset = "0x5AFA790", VA = "0x185AFB590", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBAF0", Offset = "0x5AFACF0", VA = "0x185AFBAF0", Slot = "10")]
	public void JFLMGBECOEP(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBC80", Offset = "0x5AFAE80", VA = "0x185AFBC80", Slot = "11")]
	public void MBBLCNONAFI(JNNFBKKLCNP OJEMCPHOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB6A0", Offset = "0x5AFA8A0", VA = "0x185AFB6A0")]
	private void IBCAEHMCECH(PhotonView NAKMEOEKLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5AFBEB0", Offset = "0x5AFB0B0", VA = "0x185AFBEB0")]
	private void OKJLPHMJLFN(RigidbodyEx MEHGCJCMKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB900", Offset = "0x5AFAB00", VA = "0x185AFB900")]
	private void IOLJCBHHHLK(PhotonView PAADMHOOIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal static class ADBJFKAELFI
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5AFA5D0", Offset = "0x5AF97D0", VA = "0x185AFA5D0")]
	public static GEGLHAJMKKE LJPOGGEAOMF(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class FECKEEBNPPM : BAOCCFHJKDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly PDJBEHKNNCI AAJFIDGJFOP;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAB60", Offset = "0x5AF9D60", VA = "0x185AFAB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool KNMEIJBGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x947A10", Offset = "0x946C10", VA = "0x180947A10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5B03480", Offset = "0x5B02680", VA = "0x185B03480")]
	public FECKEEBNPPM(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5B02EA0", Offset = "0x5B020A0", VA = "0x185B02EA0", Slot = "5")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5B026C0", Offset = "0x5B018C0", VA = "0x185B026C0", Slot = "7")]
	public void AGNJHCMHGPC(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5B03450", Offset = "0x5B02650", VA = "0x185B03450", Slot = "8")]
	public void PDDIPNMKOKI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5B02F50", Offset = "0x5B02150", VA = "0x185B02F50", Slot = "9")]
	public void LMFBMNJFLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5B03250", Offset = "0x5B02450", VA = "0x185B03250", Slot = "11")]
	public void MNPHCLFIGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x5B02540", Offset = "0x5B01740", VA = "0x185B02540", Slot = "12")]
	public void AEMAHLLJOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5B029F0", Offset = "0x5B01BF0", VA = "0x185B029F0", Slot = "10")]
	public void HJKBMHAAIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x5B02870", Offset = "0x5B01A70", VA = "0x185B02870")]
	private void FIFDGHDJELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5B026F0", Offset = "0x5B018F0", VA = "0x185B026F0")]
	private void BAFAAPKIIHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class FGONBOBIOPI : GEKNMADPOKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private RigidbodyConstraints LFNBMNEJBMG;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool FEDBINNMPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C30", Offset = "0x8C7E30", VA = "0x1808C8C30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1C48FF0", Offset = "0x1C481F0", VA = "0x181C48FF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool DKLJPOKJKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1C48FD0", Offset = "0x1C481D0", VA = "0x181C48FD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1C48FE0", Offset = "0x1C481E0", VA = "0x181C48FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public RigidbodyConstraints KMCJGCKIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5B035D0", Offset = "0x5B027D0", VA = "0x185B035D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5B036B0", Offset = "0x5B028B0", VA = "0x185B036B0")]
	public FGONBOBIOPI(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5B035A0", Offset = "0x5B027A0", VA = "0x185B035A0", Slot = "9")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5B03570", Offset = "0x5B02770", VA = "0x185B03570", Slot = "10")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class KBBJEPGGCJG : EFKPJKOBEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0E3C0", Offset = "0x5B0D5C0", VA = "0x185B0E3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAB60", Offset = "0x5AF9D60", VA = "0x185AFAB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DC30", Offset = "0x5B0CE30", VA = "0x185B0DC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5B049D0", Offset = "0x5B03BD0", VA = "0x185B049D0")]
	public KBBJEPGGCJG(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E3E0", Offset = "0x5B0D5E0", VA = "0x185B0E3E0", Slot = "4")]
	public void LOIJCLMNHII(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DC90", Offset = "0x5B0CE90", VA = "0x185B0DC90")]
	private void EKMEDEACDKC(Vector3 BEIAPGFNLDJ, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0DE90", Offset = "0x5B0D090", VA = "0x185B0DE90", Slot = "5")]
	public void IJKNLAHELKO(Vector3 BEIAPGFNLDJ, Vector3 BOEKENJNLKP, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E0A0", Offset = "0x5B0D2A0", VA = "0x185B0E0A0", Slot = "6")]
	public void KMBBDAABCLK(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E1C0", Offset = "0x5B0D3C0", VA = "0x185B0E1C0")]
	private void LAIJDEOMBFB(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E4D0", Offset = "0x5B0D6D0", VA = "0x185B0E4D0", Slot = "7")]
	public void NFEDINGDCDL(Vector3 IGPPMNNJKCA, ForceMode HHNIPMBAKHG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DFHLFBEMDMG : APPIBGADCJD, MHFPEKHOIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly LDCCMPJJNLC<JNNFBKKLCNP> JPEEBGALOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool IDDCGDCOJNO;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public LDCCMPJJNLC<JNNFBKKLCNP> FHCPNDEGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 BFALOANHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD0A0", Offset = "0x5AFC2A0", VA = "0x185AFD0A0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 GBFNMJBAIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC740", Offset = "0x5AFB940", VA = "0x185AFC740", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD0D0", Offset = "0x5AFC2D0", VA = "0x185AFD0D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public JNNFBKKLCNP CCLIHMMHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5AFCFB0", Offset = "0x5AFC1B0", VA = "0x185AFCFB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD1B0", Offset = "0x5AFC3B0", VA = "0x185AFD1B0")]
	public DFHLFBEMDMG(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD030", Offset = "0x5AFC230", VA = "0x185AFD030", Slot = "8")]
	public void JBGHHBLMJDP(JNNFBKKLCNP OJEMCPHOKBP, object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5AFCF50", Offset = "0x5AFC150", VA = "0x185AFCF50", Slot = "9")]
	public void DEJGNJICIEA(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5AFC8D0", Offset = "0x5AFBAD0", VA = "0x185AFC8D0")]
	private Vector3 CEAEPHPNHJO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AFCBD0", Offset = "0x5AFBDD0", VA = "0x185AFCBD0")]
	private void DAONCBBMDBO(JNNFBKKLCNP HOMJKGIFFLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class FDIJCEGKADJ
{
	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5B02480", Offset = "0x5B01680", VA = "0x185B02480")]
	public static APPIBGADCJD NBLFFBBGCCE(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GPJBGIMPJEE : JJEMPJJPPMB, BDPEDMBBICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly OverridableVector3 IADJPJPANBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OverridableVector3 GJEHAPNKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private float FKHLIFIDPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float KFLBBLALBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Vector3 PBAIHAACBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Vector3? KMHFCIGLKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Quaternion? NDOHNAIABBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool GLDLOABGIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool MKEJBCHLFME;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Vector3 FMGFDDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A99A80", Offset = "0x1A98C80", VA = "0x181A99A80", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x5B06ED0", Offset = "0x5B060D0", VA = "0x185B06ED0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 HACJEEKBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x5B08CD0", Offset = "0x5B07ED0", VA = "0x185B08CD0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float LIHJBPFHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xC9B710", Offset = "0xC9A910", VA = "0x180C9B710", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x5B06D10", Offset = "0x5B05F10", VA = "0x185B06D10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float FKAKAOAIGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC6DB60", Offset = "0xC6CD60", VA = "0x180C6DB60", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5B07810", Offset = "0x5B06A10", VA = "0x185B07810", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 ACHPOPOGFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5B07690", Offset = "0x5B06890", VA = "0x185B07690", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Quaternion AAFENMBDNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5B07B60", Offset = "0x5B06D60", VA = "0x185B07B60", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B08B80", Offset = "0x5B07D80", VA = "0x185B08B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event FHMOCDKOLCB MINAOALHGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5B08940", Offset = "0x5B07B40", VA = "0x185B08940", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x5B079F0", Offset = "0x5B06BF0", VA = "0x185B079F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B08DA0", Offset = "0x5B07FA0", VA = "0x185B08DA0")]
	public GPJBGIMPJEE(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B08BA0", Offset = "0x5B07DA0", VA = "0x185B08BA0", Slot = "17")]
	public void NJKDMPPEMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5B06C20", Offset = "0x5B05E20", VA = "0x185B06C20", Slot = "16")]
	public void BEBJBIKDNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5B077A0", Offset = "0x5B069A0", VA = "0x185B077A0", Slot = "19")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B06F50", Offset = "0x5B06150", VA = "0x185B06F50", Slot = "20")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5B07890", Offset = "0x5B06A90", VA = "0x185B07890", Slot = "18")]
	public void HLEAECEIFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5B07160", Offset = "0x5B06360", VA = "0x185B07160", Slot = "21")]
	public void FLBFFHEDHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B06ED0", Offset = "0x5B060D0", VA = "0x185B06ED0")]
	private void CCJHLONCKFN(Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B07A90", Offset = "0x5B06C90", VA = "0x185B07A90")]
	[Obsolete]
	private Vector3 IMHNOJEFFOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5B06D10", Offset = "0x5B05F10", VA = "0x185B06D10")]
	private void BONKJOLFAJO(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B07810", Offset = "0x5B06A10", VA = "0x185B07810")]
	private void GLNLPFFODII(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B07580", Offset = "0x5B06780", VA = "0x185B07580")]
	private Vector3 FNACKLPGLEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B089E0", Offset = "0x5B07BE0", VA = "0x185B089E0", Slot = "15")]
	public void LLOGJICJMPJ((Quaternion rot, Vector3 moments) BCLEDNCILCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5B06DC0", Offset = "0x5B05FC0", VA = "0x185B06DC0")]
	private Quaternion BPAADPHGDDF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5B08860", Offset = "0x5B07A60", VA = "0x185B08860")]
	public void KPEJLEKGJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5B07C70", Offset = "0x5B06E70", VA = "0x185B07C70", Slot = "4")]
	public (float, Vector3) KPEJLEKGJIO(Rigidbody EEBBBICFICB)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class OCIADHOPLHL
{
	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FB50", Offset = "0x6E4ED50", VA = "0x186E4FB50")]
	public static JJEMPJJPPMB MHKKKOKLPPO(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface APPIBGADCJD : MHFPEKHOIMM
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	LDCCMPJJNLC<JNNFBKKLCNP> FHCPNDEGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	JNNFBKKLCNP CCLIHMMHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class JKNHDPPONPL : BOPFKHAHFCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PDJBEHKNNCI KOADICBDMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float COIOKMCEEHL;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EJBDMPOPPCG CHIJILNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x88F7E0", Offset = "0x88E9E0", VA = "0x18088F7E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public ANKGBAPAGNP LFBGPIICJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 BABMIFHMKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D390", Offset = "0x5B0C590", VA = "0x185B0D390", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CF30", Offset = "0x5B0C130", VA = "0x185B0CF30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 HBBLFIMIEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D2D0", Offset = "0x5B0C4D0", VA = "0x185B0D2D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AF90", Offset = "0x5B0A190", VA = "0x185B0AF90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 GIPILIJCFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D070", Offset = "0x5B0C270", VA = "0x185B0D070", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D210", Offset = "0x5B0C410", VA = "0x185B0D210", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 PIHIDDADJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x5B0C140", Offset = "0x5B0B340", VA = "0x185B0C140", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B6B0", Offset = "0x5B0A8B0", VA = "0x185B0B6B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float NJIJFHJDACD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x9297A0", Offset = "0x9289A0", VA = "0x1809297A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AD60", Offset = "0x5B09F60", VA = "0x185B0AD60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool EOGICCLHOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x98AD50", Offset = "0x989F50", VA = "0x18098AD50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private EFKPJKOBEKA CIDOCHIIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x2107BB0", Offset = "0x2106DB0", VA = "0x182107BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private bool HNOEMKACOJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD610", Offset = "0x5AFC810", VA = "0x185AFD610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D470", Offset = "0x5B0C670", VA = "0x185B0D470")]
	public JKNHDPPONPL(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B7D0", Offset = "0x5B0A9D0", VA = "0x185B0B7D0", Slot = "19")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BEB0", Offset = "0x5B0B0B0", VA = "0x185B0BEB0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C200", Offset = "0x5B0B400", VA = "0x185B0C200", Slot = "28")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x98A400", Offset = "0x989600", VA = "0x18098A400", Slot = "20")]
	public void PCMEHDOOIHG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x98A4E0", Offset = "0x9896E0", VA = "0x18098A4E0", Slot = "30")]
	public void EHHEGDKBOAP(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BFD0", Offset = "0x5B0B1D0", VA = "0x185B0BFD0", Slot = "35")]
	public Vector3 FAFEPGIECNN(Vector3 GPMDOJGCNNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AC20", Offset = "0x5B09E20", VA = "0x185B0AC20", Slot = "34")]
	public Vector3 ABHFFJKPIEN(Vector3 DIJLLIEJNJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B7D0", Offset = "0x5B0A9D0", VA = "0x185B0B7D0", Slot = "27")]
	public void DENAPAMEMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D030", Offset = "0x5B0C230", VA = "0x185B0D030", Slot = "25")]
	public void MGFIKICABEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CFF0", Offset = "0x5B0C1F0", VA = "0x185B0CFF0", Slot = "24")]
	public void LGBHMKPKECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CD90", Offset = "0x5B0BF90", VA = "0x185B0CD90", Slot = "33")]
	public void KEHAFABICEL(Vector3 MOACIHKIHNM, Vector3 BIMEPILEHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AFC0", Offset = "0x5B0A1C0", VA = "0x185B0AFC0", Slot = "32")]
	public void BILCGIPBEOE(Vector3 DNBIGGMJMLA, Vector3 HHEOJMFHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B310", Offset = "0x5B0A510", VA = "0x185B0B310", Slot = "31")]
	public void BJELPPHKBOD(Vector3 PPDKEPEEKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C2D0", Offset = "0x5B0B4D0", VA = "0x185B0C2D0", Slot = "22")]
	public void HKFBJKFEKKG(AHAMDIDODGE DCMFDIEFKDC, Vector3 GOKBBBLHMAN, float MMGOLHLJEEA, float LHLMIEEHIAB = 8f, float HEKHMFGAKII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B480", Offset = "0x5B0A680", VA = "0x185B0B480", Slot = "21")]
	public void BLCHIICFPCO(ODNJCKFBJEK BKBEJNMEIFP, Vector3 KBKEFLIJIMP, float GKFGKJGIGIM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C780", Offset = "0x5B0B980", VA = "0x185B0C780", Slot = "23")]
	[Obsolete]
	public void IGFANKIHNBN(ODNJCKFBJEK BKBEJNMEIFP, Vector3 ELGEECMLAMI, float DLGDABOLFCD = 7f, float PDCMAOKNMKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B840", Offset = "0x5B0AA40", VA = "0x185B0B840", Slot = "29")]
	public Vector3 DIPKJPKPJDH(Vector3 NHADPEGDINF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B6E0", Offset = "0x5B0A8E0", VA = "0x185B0B6E0", Slot = "26")]
	public void CDJNKINJAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AD60", Offset = "0x5B09F60", VA = "0x185B0AD60")]
	private void ADCPGHCAFFF(float NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5B0AE20", Offset = "0x5B0A020", VA = "0x185B0AE20")]
	private void BFGNJHHPAAI(Vector3 KBKEFLIJIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5B0D150", Offset = "0x5B0C350", VA = "0x185B0D150")]
	private Vector3 MNHKGMFAJBJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B020", Offset = "0x5B0A220", VA = "0x185B0B020")]
	private void BJEJHBFKOME(Vector3 DIJLLIEJNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BDF0", Offset = "0x5B0AFF0", VA = "0x185B0BDF0")]
	private Vector3 DPMCLMPNMHG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CA80", Offset = "0x5B0BC80", VA = "0x185B0CA80")]
	private void IHFKAALBPEJ(Vector3 NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B900", Offset = "0x5B0AB00", VA = "0x185B0B900")]
	private void DJPOPLDCGPL(Vector3 DIJLLIEJNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BF10", Offset = "0x5B0B110", VA = "0x185B0BF10")]
	private void ELNOEBBMBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class GNHFCBEHAJO : IEMGGGMGCPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PDJBEHKNNCI HEKPPLGEFPJ;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool HLNAEHOELNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x5B06940", Offset = "0x5B05B40", VA = "0x185B06940", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event FHMOCDKOLCB KGGDBIPPADG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x5B066F0", Offset = "0x5B058F0", VA = "0x185B066F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x5B06AA0", Offset = "0x5B05CA0", VA = "0x185B06AA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5B06B40", Offset = "0x5B05D40", VA = "0x185B06B40")]
	public GNHFCBEHAJO(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A40", Offset = "0x5B05C40", VA = "0x185B06A40", Slot = "11")]
	public IDisposable OAIGIPAMEKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5B069E0", Offset = "0x5B05BE0", VA = "0x185B069E0", Slot = "8")]
	public void LJOKGLLHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5B06A30", Offset = "0x5B05C30", VA = "0x185B06A30", Slot = "9")]
	public void NMEIAMOCCPI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5B067C0", Offset = "0x5B059C0", VA = "0x185B067C0", Slot = "10")]
	public void EDGICHNPKDM(object FDCOCHLAHJD, bool ALGGMCABHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5B069F0", Offset = "0x5B05BF0", VA = "0x185B069F0", Slot = "6")]
	public void NCGJOIFICKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5B068C0", Offset = "0x5B05AC0", VA = "0x185B068C0", Slot = "12")]
	public void GHKDIGPJJDI(Rigidbody JPHDKFDHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5B06790", Offset = "0x5B05990", VA = "0x185B06790", Slot = "13")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal sealed class FJOPILEACIC : PEMJLNPLGEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CollisionDetectionMode LGMAMNAKKDG;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x5AFDC10", Offset = "0x5AFCE10", VA = "0x185AFDC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CollisionDetectionMode NHLPADNJOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x5B046C0", Offset = "0x5B038C0", VA = "0x185B046C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x5B048E0", Offset = "0x5B03AE0", VA = "0x185B048E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5B049D0", Offset = "0x5B03BD0", VA = "0x185B049D0")]
	public FJOPILEACIC(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5B04920", Offset = "0x5B03B20", VA = "0x185B04920", Slot = "6")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5B04880", Offset = "0x5B03A80", VA = "0x185B04880", Slot = "9")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5B04870", Offset = "0x5B03A70", VA = "0x185B04870", Slot = "7")]
	public void FNLFANIDHAN(bool FNCAGMCDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5B048D0", Offset = "0x5B03AD0", VA = "0x185B048D0", Slot = "8")]
	public void IFOELHOEKBI(bool FNCAGMCDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5B04770", Offset = "0x5B03970", VA = "0x185B04770", Slot = "10")]
	public bool ELCEGLMICPO(Vector3 KCEMMLEMANI, out RaycastHit CNAOKLOLPLL, float EKIBGBMDOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5B045F0", Offset = "0x5B037F0", VA = "0x185B045F0")]
	private void BICCFBGNBKE(bool FNCAGMCDJEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FIEKHDADOBB : JPNGNCNEENI
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x5B03B50", Offset = "0x5B02D50", VA = "0x185B03B50", Slot = "4")]
	public KOANIGNFMFL DEMJMLEOOEB(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x5B040B0", Offset = "0x5B032B0", VA = "0x185B040B0", Slot = "5")]
	public BOPFKHAHFCC KEANAKMLBDJ(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x5B03930", Offset = "0x5B02B30", VA = "0x185B03930", Slot = "6")]
	public MHFPEKHOIMM BOIOMKGBLBN(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x5B04290", Offset = "0x5B03490", VA = "0x185B04290", Slot = "7")]
	public AHOFNLCCEAG LNEPNADPDJC(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5B043D0", Offset = "0x5B035D0", VA = "0x185B043D0", Slot = "8")]
	public FDONOFLBIKP MCFDFDOBHIH(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5B03DB0", Offset = "0x5B02FB0", VA = "0x185B03DB0", Slot = "9")]
	public MKFCLLNMJLN IPCNFOBLBMF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5B03A50", Offset = "0x5B02C50", VA = "0x185B03A50", Slot = "10")]
	public IEMGGGMGCPB CMFKPGPAELA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5B044B0", Offset = "0x5B036B0", VA = "0x185B044B0", Slot = "11")]
	public EFKPJKOBEKA PHHGIJJDMGF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5B03D00", Offset = "0x5B02F00", VA = "0x185B03D00", Slot = "12")]
	public PEMJLNPLGEL GDCFPPNAKHF(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x5B03C40", Offset = "0x5B02E40", VA = "0x185B03C40", Slot = "13")]
	public EBNHILLEDLL EJPKCMHAIPA(JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x5B03F90", Offset = "0x5B03190", VA = "0x185B03F90")]
	public BAOCCFHJKDL KDDCLGOEJPB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5B041C0", Offset = "0x5B033C0", VA = "0x185B041C0")]
	public OIBGLHFGEDH MHINDGKIGIJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5B03E70", Offset = "0x5B03070", VA = "0x185B03E70")]
	public DDJGOOKKHFM PAJBCAEKJME(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5B03750", Offset = "0x5B02950", VA = "0x185B03750")]
	public BDPEDMBBICC AINHGCPEMCM(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5B04300", Offset = "0x5B03500", VA = "0x185B04300")]
	public GEKNMADPOKF OLPAIPCDBIK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5B03880", Offset = "0x5B02A80", VA = "0x185B03880", Slot = "19")]
	public JNNFBKKLCNP AJMEGNGJDCH(RigidbodyEx IPECNCNJKEI, PDMLEGIKGPH JFGIPFOFKHL, BEHCIJIDLFI MHGFMGGOLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FIEKHDADOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5B03F90", Offset = "0x5B03190", VA = "0x185B03F90", Slot = "14")]
	private BAOCCFHJKDL NMLAEDLDOAB(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5B041C0", Offset = "0x5B033C0", VA = "0x185B041C0", Slot = "15")]
	private OIBGLHFGEDH KPDAOEBCGHG(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5B03E70", Offset = "0x5B03070", VA = "0x185B03E70", Slot = "16")]
	private DDJGOOKKHFM JNHAONCMHFJ(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x5B03750", Offset = "0x5B02950", VA = "0x185B03750", Slot = "17")]
	private BDPEDMBBICC FDCFPPDEGMN(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x5B04300", Offset = "0x5B03500", VA = "0x185B04300", Slot = "18")]
	private GEKNMADPOKF LOAIHCPKOPK(JNNFBKKLCNP KPCECNDHFND, in PDMLEGIKGPH JFGIPFOFKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class KBIOCIIOLGD : CCHGOGGMHLO, KOANIGNFMFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly JNNFBKKLCNP IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<JNNFBKKLCNP> KNNJOFGDFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private JNNFBKKLCNP MKADPIPCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private JNNFBKKLCNP OJEMCPHOKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform MOMMGECIAJG;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Transform JIMDMFMPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x5B10250", Offset = "0x5B0F450", VA = "0x185B10250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FD60", Offset = "0x5B0EF60", VA = "0x185B0FD60", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public JNNFBKKLCNP NMFNLMEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IReadOnlyList<JNNFBKKLCNP> PLFGDAKPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event FHMOCDKOLCB PGDBJJOKEID
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FD70", Offset = "0x5B0EF70", VA = "0x185B0FD70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F440", Offset = "0x5B0E640", VA = "0x185B0F440", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event FHMOCDKOLCB ACIGIMNAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5B10110", Offset = "0x5B0F310", VA = "0x185B10110", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F870", Offset = "0x5B0EA70", VA = "0x185B0F870", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event MMLNCAADDIJ AOOINOALPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x5B101B0", Offset = "0x5B0F3B0", VA = "0x185B101B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FA50", Offset = "0x5B0EC50", VA = "0x185B0FA50", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action GDBIHJIJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F120", Offset = "0x5B0E320", VA = "0x185B0F120", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F9B0", Offset = "0x5B0EBB0", VA = "0x185B0F9B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HDMDOBCOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F7D0", Offset = "0x5B0E9D0", VA = "0x185B0F7D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FAF0", Offset = "0x5B0ECF0", VA = "0x185B0FAF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<JNNFBKKLCNP> KPANILCJNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F910", Offset = "0x5B0EB10", VA = "0x185B0F910", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x5B10350", Offset = "0x5B0F550", VA = "0x185B10350", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<JNNFBKKLCNP> GLAGENAGHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x5B0E6D0", Offset = "0x5B0D8D0", VA = "0x185B0E6D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F4E0", Offset = "0x5B0E6E0", VA = "0x185B0F4E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action BGMBAOIPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F000", Offset = "0x5B0E200", VA = "0x185B0F000", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5B102B0", Offset = "0x5B0F4B0", VA = "0x185B102B0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<JNNFBKKLCNP> JAIJKKICOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FB90", Offset = "0x5B0ED90", VA = "0x185B0FB90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0FE10", Offset = "0x5B0F010", VA = "0x185B0FE10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5B103F0", Offset = "0x5B0F5F0", VA = "0x185B103F0")]
	public KBIOCIIOLGD(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F0A0", Offset = "0x5B0E2A0", VA = "0x185B0F0A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EA70", Offset = "0x5B0DC70", VA = "0x185B0EA70", Slot = "30")]
	public void BPMJPILKAOG(JNNFBKKLCNP PCCOHMIFFHJ, bool AEDCFFPKIIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F580", Offset = "0x5B0E780", VA = "0x185B0F580", Slot = "6")]
	public void HHHHCAJMDJK(JNNFBKKLCNP BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E810", Offset = "0x5B0DA10", VA = "0x185B0E810", Slot = "7")]
	public void BJCPPCDLANN(JNNFBKKLCNP BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5B0E770", Offset = "0x5B0D970", VA = "0x185B0E770", Slot = "4")]
	public void BIBGAGBKMNG(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F3A0", Offset = "0x5B0E5A0", VA = "0x185B0F3A0", Slot = "5")]
	public void EOEHEOKPEGA(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F1C0", Offset = "0x5B0E3C0", VA = "0x185B0F1C0")]
	private void EFCGFHJBBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FC30", Offset = "0x5B0EE30", VA = "0x185B0FC30")]
	private void LBCEDGFJDLM(JNNFBKKLCNP BBBPGBFGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F250", Offset = "0x5B0E450", VA = "0x185B0F250")]
	private void EODNNNGDAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FEB0", Offset = "0x5B0F0B0", VA = "0x185B0FEB0")]
	private void NAMMNFHJAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FFE0", Offset = "0x5B0F1E0", VA = "0x185B0FFE0")]
	private void NKPGDAGMDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FC70", Offset = "0x5B0EE70", VA = "0x185B0FC70")]
	[CompilerGenerated]
	private object LCKONINFIDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal static class BGLBDJDONAO
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5AFB410", Offset = "0x5AFA610", VA = "0x185AFB410")]
	public static CCHGOGGMHLO NMACKCAFKHJ(this JNNFBKKLCNP KPCECNDHFND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class IOHMFKOLAEK : DDJGOOKKHFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly PDJBEHKNNCI JLINDLBPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FOILGMPPBAK NPMHEGCJEAG;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool PJNIPKELBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x947A10", Offset = "0x946C10", VA = "0x180947A10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public FOILGMPPBAK BLIMLNECNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "11")]
		get
		{
			return default(FOILGMPPBAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A860", Offset = "0x5B09A60", VA = "0x185B0A860")]
	public IOHMFKOLAEK(JNNFBKKLCNP IPECNCNJKEI, in PDMLEGIKGPH JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A400", Offset = "0x5B09600", VA = "0x185B0A400", Slot = "4")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A2F0", Offset = "0x5B094F0", VA = "0x185B0A2F0")]
	private bool ALAGGMLBNAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A3D0", Offset = "0x5B095D0", VA = "0x185B0A3D0", Slot = "5")]
	public void GENHNABINCI(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A5F0", Offset = "0x5B097F0", VA = "0x185B0A5F0", Slot = "6")]
	public void KDKCMIDHMNG(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A620", Offset = "0x5B09820", VA = "0x185B0A620", Slot = "9")]
	public void NOJJHHDONKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A750", Offset = "0x5B09950", VA = "0x185B0A750")]
	private void PAMIEJKOIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A4D0", Offset = "0x5B096D0", VA = "0x185B0A4D0")]
	private void JEPNEJBDHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A5B0", Offset = "0x5B097B0", VA = "0x185B0A5B0", Slot = "8")]
	public void JMLPHEPAMBM(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A390", Offset = "0x5B09590", VA = "0x185B0A390", Slot = "7")]
	public void GAOBOJPIKEP(JNNFBKKLCNP IPECNCNJKEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface JJEMPJJPPMB : BDPEDMBBICC
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KPEJLEKGJIO(Rigidbody EEBBBICFICB);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CCHGOGGMHLO : KOANIGNFMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIBGAGBKMNG(JNNFBKKLCNP IPECNCNJKEI);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOEHEOKPEGA(JNNFBKKLCNP IPECNCNJKEI);

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHHHCAJMDJK(JNNFBKKLCNP BBBPGBFGGDN);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJCPPCDLANN(JNNFBKKLCNP BBBPGBFGGDN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class GAHCOMLAKCC : EBNHILLEDLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool AIGNLPFDKBJ;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool CFDJGMFCIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x94D950", Offset = "0x94CB50", VA = "0x18094D950", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5B05670", Offset = "0x5B04870", VA = "0x185B05670", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5B05750", Offset = "0x5B04950", VA = "0x185B05750")]
	public GAHCOMLAKCC(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x5B05720", Offset = "0x5B04920", VA = "0x185B05720", Slot = "6")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x5B05120", Offset = "0x5B04320", VA = "0x185B05120", Slot = "7")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class LIFDOFNLMBG : FDONOFLBIKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly PAFFMNAJGCG IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool AHNIIDKLIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool AKKNCMKKGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int KOEDGHJMMIE;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private Rigidbody FHBDNCAGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5B08B80", Offset = "0x5B07D80", VA = "0x185B08B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private bool HNOEMKACOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5B14890", Offset = "0x5B13A90", VA = "0x185B14890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private JNNFBKKLCNP OBEGGMICJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5B14710", Offset = "0x5B13910", VA = "0x185B14710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool AKIBOJKDGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5B14B20", Offset = "0x5B13D20", VA = "0x185B14B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event FHMOCDKOLCB AHDFCKMFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5B14D00", Offset = "0x5B13F00", VA = "0x185B14D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5B14780", Offset = "0x5B13980", VA = "0x185B14780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5B15080", Offset = "0x5B14280", VA = "0x185B15080")]
	public LIFDOFNLMBG(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5B14B80", Offset = "0x5B13D80", VA = "0x185B14B80", Slot = "6")]
	public void IKFPHNABPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5B14770", Offset = "0x5B13970", VA = "0x185B14770", Slot = "8")]
	public void ACILHPKMLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5B14A00", Offset = "0x5B13C00", VA = "0x185B14A00", Slot = "7")]
	public bool HBPBHBBKDLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x5B14820", Offset = "0x5B13A20", VA = "0x185B14820", Slot = "9")]
	public void ELIFEDCAFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5B15020", Offset = "0x5B14220", VA = "0x185B15020", Slot = "11")]
	public void OFAKLCMNIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5B14DA0", Offset = "0x5B13FA0", VA = "0x185B14DA0", Slot = "12")]
	public void MHFILNFIKBO(bool IHFFPKKEBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5B14DE0", Offset = "0x5B13FE0", VA = "0x185B14DE0", Slot = "10")]
	public void MKMFHCAECPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5B14BE0", Offset = "0x5B13DE0", VA = "0x185B14BE0")]
	private bool KGOFCNBEOEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5B148B0", Offset = "0x5B13AB0", VA = "0x185B148B0")]
	private void FFJEFCCJOLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JIJMNAHHMCK : AHOFNLCCEAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly JNNFBKKLCNP IPECNCNJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float NPCGKJPCPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private float KGDEANLCBAE;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float CDJHNDKPAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x99B890", Offset = "0x99AA90", VA = "0x18099B890", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AA40", Offset = "0x5B09C40", VA = "0x185B0AA40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public float ECIGOEANLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x893F50", Offset = "0x893150", VA = "0x180893F50", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AB10", Offset = "0x5B09D10", VA = "0x185B0AB10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5B0ABE0", Offset = "0x5B09DE0", VA = "0x185B0ABE0")]
	public JIJMNAHHMCK(JNNFBKKLCNP IPECNCNJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A9F0", Offset = "0x5B09BF0", VA = "0x185B0A9F0", Slot = "8")]
	public void GHKDIGPJJDI(Rigidbody POLLJMGANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0A950", Offset = "0x5B09B50", VA = "0x185B0A950", Slot = "9")]
	public void COOFPFOLHOK(Rigidbody POLLJMGANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface GEGLHAJMKKE : OIBGLHFGEDH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	PhotonView GELLECCBPIH
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
	internal class _RRAssemblyIndex : MCOMHBDOHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5BB60", Offset = "0x6E5AD60", VA = "0x186E5BB60", Slot = "6")]
		public sealed override void LKAMFIMFKPG(FBLIJCAPIKE JHGMNDBGFFP)
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
